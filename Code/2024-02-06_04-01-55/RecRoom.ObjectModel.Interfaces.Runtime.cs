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
public struct NKDFDPPNGFC : IReadOnlyList<FNONGLLGKNI>, IEnumerable<FNONGLLGKNI>, IEnumerable, IReadOnlyCollection<FNONGLLGKNI>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct BLHMNMIOLGB : IEnumerator<FNONGLLGKNI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly PJGGPMIHDNH LCOFKHKJALF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator CPMPLPGKMDA;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public FNONGLLGKNI PPPEJOJKNAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x616D3B0", Offset = "0x616C7B0", VA = "0x18616D3B0", Slot = "4")]
			get
			{
				return default(FNONGLLGKNI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x616D330", Offset = "0x616C730", VA = "0x18616D330", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3B50160", Offset = "0x3B4F560", VA = "0x183B50160")]
		public BLHMNMIOLGB(PJGGPMIHDNH LCOFKHKJALF, NativeArray<LocalId>.Enumerator CPMPLPGKMDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x616D270", Offset = "0x616C670", VA = "0x18616D270", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x616D2B0", Offset = "0x616C6B0", VA = "0x18616D2B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x616D2F0", Offset = "0x616C6F0", VA = "0x18616D2F0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly PJGGPMIHDNH LCOFKHKJALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> LKLMPHAAIMO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FNONGLLGKNI LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6178F90", Offset = "0x6178390", VA = "0x186178F90", Slot = "4")]
		get
		{
			return default(FNONGLLGKNI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6178A20", Offset = "0x6177E20", VA = "0x186178A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int AAJCECFJBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x79E180", Offset = "0x79D580", VA = "0x18079E180", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public PJGGPMIHDNH NIOANIAOFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int BGGPFCEBPPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x79E180", Offset = "0x79D580", VA = "0x18079E180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool JENMABEOJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6178A70", Offset = "0x6177E70", VA = "0x186178A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> GLJJKENMIPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x21B07F0", Offset = "0x21AFBF0", VA = "0x1821B07F0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6178F00", Offset = "0x6178300", VA = "0x186178F00")]
	public NKDFDPPNGFC(int LNJIGPAGCFO, PJGGPMIHDNH LCOFKHKJALF, Allocator OLAJGHFDGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3B50450", Offset = "0x3B4F850", VA = "0x183B50450")]
	public NKDFDPPNGFC(PJGGPMIHDNH LCOFKHKJALF, NativeArray<LocalId> LKLMPHAAIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6178DE0", Offset = "0x61781E0", VA = "0x186178DE0")]
	internal NKDFDPPNGFC(PJGGPMIHDNH LCOFKHKJALF, NativeArray<Entity> KMGEJEMFJBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6178D40", Offset = "0x6178140", VA = "0x186178D40")]
	public NKDFDPPNGFC(PJGGPMIHDNH LCOFKHKJALF, int FLCGLAMBOBC, Allocator OLAJGHFDGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6178E50", Offset = "0x6178250", VA = "0x186178E50")]
	public NKDFDPPNGFC(NKDFDPPNGFC JBJHDFJDOMN, Allocator OLAJGHFDGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6178AB0", Offset = "0x6177EB0", VA = "0x186178AB0")]
	public NKDFDPPNGFC PEJOGFDJNOA(Allocator OLAJGHFDGHM = Allocator.Temp)
	{
		return default(NKDFDPPNGFC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6178950", Offset = "0x6177D50", VA = "0x186178950", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6178990", Offset = "0x6177D90", VA = "0x186178990")]
	public BLHMNMIOLGB JLFJDPHFECC()
	{
		return default(BLHMNMIOLGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6178B60", Offset = "0x6177F60", VA = "0x186178B60", Slot = "6")]
	private IEnumerator<FNONGLLGKNI> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6178C50", Offset = "0x6178050", VA = "0x186178C50", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct DCBKNCAFIAO : IList<FNONGLLGKNI>, ICollection<FNONGLLGKNI>, IEnumerable<FNONGLLGKNI>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct PDJDGPPGAGA : IEnumerator<FNONGLLGKNI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly PJGGPMIHDNH LCOFKHKJALF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator CPMPLPGKMDA;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public FNONGLLGKNI PPPEJOJKNAK
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6179B70", Offset = "0x6178F70", VA = "0x186179B70", Slot = "4")]
			get
			{
				return default(FNONGLLGKNI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6179AF0", Offset = "0x6178EF0", VA = "0x186179AF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3B50160", Offset = "0x3B4F560", VA = "0x183B50160")]
		public PDJDGPPGAGA(PJGGPMIHDNH LCOFKHKJALF, NativeArray<LocalId>.Enumerator CPMPLPGKMDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6179A30", Offset = "0x6178E30", VA = "0x186179A30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6179A70", Offset = "0x6178E70", VA = "0x186179A70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6179AB0", Offset = "0x6178EB0", VA = "0x186179AB0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly PJGGPMIHDNH LCOFKHKJALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> LKLMPHAAIMO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public FNONGLLGKNI LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6170CC0", Offset = "0x61700C0", VA = "0x186170CC0", Slot = "4")]
		get
		{
			return default(FNONGLLGKNI);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6170D40", Offset = "0x6170140", VA = "0x186170D40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x61708F0", Offset = "0x616FCF0", VA = "0x1861708F0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int BGGPFCEBPPM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x61708F0", Offset = "0x616FCF0", VA = "0x1861708F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool DKAJDONKALI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6170C30", Offset = "0x6170030", VA = "0x186170C30")]
	public DCBKNCAFIAO(PJGGPMIHDNH LCOFKHKJALF, int FLCGLAMBOBC, Allocator OLAJGHFDGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6170870", Offset = "0x616FC70", VA = "0x186170870")]
	public NKDFDPPNGFC JMJIOCHLOAP()
	{
		return default(NKDFDPPNGFC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6170440", Offset = "0x616F840", VA = "0x186170440", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6170480", Offset = "0x616F880", VA = "0x186170480", Slot = "13")]
	public bool Contains(FNONGLLGKNI IEEBNOOJIPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6170510", Offset = "0x616F910", VA = "0x186170510", Slot = "14")]
	public void CopyTo(FNONGLLGKNI[] MGNOJHKHDPK, int PNCNANACKBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x61703C0", Offset = "0x616F7C0", VA = "0x1861703C0", Slot = "11")]
	public void Add(FNONGLLGKNI IEEBNOOJIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6170730", Offset = "0x616FB30", VA = "0x186170730", Slot = "7")]
	public void Insert(int AHDNEIKOMIB, FNONGLLGKNI IEEBNOOJIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6170980", Offset = "0x616FD80", VA = "0x186170980", Slot = "15")]
	public bool Remove(FNONGLLGKNI IEEBNOOJIPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x61706A0", Offset = "0x616FAA0", VA = "0x1861706A0", Slot = "6")]
	public int IndexOf(FNONGLLGKNI IEEBNOOJIPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6170930", Offset = "0x616FD30", VA = "0x186170930", Slot = "8")]
	public void RemoveAt(int AHDNEIKOMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6170660", Offset = "0x616FA60", VA = "0x186170660", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x61707E0", Offset = "0x616FBE0", VA = "0x1861707E0")]
	public PDJDGPPGAGA JLFJDPHFECC()
	{
		return default(PDJDGPPGAGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6170A50", Offset = "0x616FE50", VA = "0x186170A50", Slot = "16")]
	private IEnumerator<FNONGLLGKNI> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6170B40", Offset = "0x616FF40", VA = "0x186170B40", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IEOCNNKMDFD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int HPPJNHHBINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> BHJBGBFGPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FNONGLLGKNI DDCBHGPHPGH(FNONGLLGKNI LKLMPHAAIMO);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DHIMHLCPHEB : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface OHNEMMIKCPK : FACBGDBFBKG, FKEJGOFEJBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool FMCKFONPAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	CPLMDABFNOO OOJLFEDANOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	GNNAPPBDGGF NNEHBHOOFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IBEAMCOGAPL NIHNDEIKMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	IPJGGBFFCFD OHGODJGHGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	NFJNLPGNNDE MNAIPDFKAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface FKEJGOFEJBL
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool DPGNIFMCGBF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface MOEFHBAMFDB
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDHGHDEABEH(bool ANJCCKHBJJO);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface IPJGGBFFCFD
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool CLFDBHLJNCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action LGMNKJFAICO;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFKOHKNDNEC(bool FAEFLPADKEG);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CCBAIOIIHBI(ByteString PKHNCMEKMEL);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LNFGBBLFOBA();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BDFAFMOCJNE();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GILOOPADIJN();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface IBEAMCOGAPL
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	DOHCFJAHLBK OOJLFEDANOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GNNAPPBDGGF NNEHBHOOFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	JOIBJAFEBEM CPBBNGJCNBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	OHNEMMIKCPK KMOMDJJEIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	PJGGPMIHDNH NIOANIAOFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	BDAIBKCOJKP LHMFADBCBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	LEDNLDAHKNG DGHCIHHPJHM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	KIGOPKFJJPN MKDLDMKBFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	DBGCEIOHAFF IFIBDIFEBAE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	JOGEJDIDHKN GFGIOLJJDON
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	LAOLJMFJDJJ AGJACAPMFDK
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	JBPFLEGOCOA MDAJMKNDCGC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	LNHBMHNCNAM OFJJEBLFKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	GJIPPHEDIAE GCBEMNOOIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	GGNMPEEIGMH KBEPPPHLCMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	GPNCCIIBJBO CJIIDADEMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	IGENMOGNKOM JFECLIOJJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	MNHOJKKMHCG FJMIDFPMALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	CBCJBIKHIKA CAICIKMOCPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	CACPONBEAJI NLLCLBLHHEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	LGECPKFCJMH CCGADKBEPLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	GHIANNFGJHH NDGKEHMFEJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(FONJKLBOFJC))]
public readonly struct FNONGLLGKNI : IComparable<FNONGLLGKNI>, IEquatable<FNONGLLGKNI>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly FNONGLLGKNI FGEMAOBKBLF;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int JPLBCKCHCOJ = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int BPNINDIMMAC = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int FNLBDMFIIEC = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int MLPMBDGPHFL = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId KKLABGAMOPP;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public PJGGPMIHDNH NIOANIAOFAO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x616BC40", Offset = "0x616B040", VA = "0x18616BC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public OHNEMMIKCPK KMOMDJJEIMP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6171760", Offset = "0x6170B60", VA = "0x186171760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public LocalId IIMNLPOHJAK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x61714B0", Offset = "0x61708B0", VA = "0x1861714B0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	internal NFJNLPGNNDE MNAIPDFKAPA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6171A90", Offset = "0x6170E90", VA = "0x186171A90")]
		get
		{
			return default(NFJNLPGNNDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool HMCLEKMJLHA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x61717C0", Offset = "0x6170BC0", VA = "0x1861717C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool NDFDIPHKIPN
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6171AA0", Offset = "0x6170EA0", VA = "0x186171AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool OBKMOJCOIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x61719C0", Offset = "0x6170DC0", VA = "0x1861719C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6171C20", Offset = "0x6171020", VA = "0x186171C20")]
	public FNONGLLGKNI(PJGGPMIHDNH LKBPNCCNGNI, LocalId KKLABGAMOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
	public PLEIFDIMDAG KFFEMHHNAHI()
	{
		return default(PLEIFDIMDAG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6171A50", Offset = "0x6170E50", VA = "0x186171A50")]
	public static LocalId JPANIEAALPM(FNONGLLGKNI HDGHFEIADNA)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6171A10", Offset = "0x6170E10", VA = "0x186171A10")]
	public static Entity JPANIEAALPM(FNONGLLGKNI HDGHFEIADNA)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x61718A0", Offset = "0x6170CA0", VA = "0x1861718A0")]
	public static bool HOHCACPHFGD(FNONGLLGKNI KHCOFGFJDMP, FNONGLLGKNI NFAPJGNODPK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6171490", Offset = "0x6170890", VA = "0x186171490")]
	public static bool AEMEGLCBHEE(FNONGLLGKNI KHCOFGFJDMP, FNONGLLGKNI NFAPJGNODPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6171AF0", Offset = "0x6170EF0", VA = "0x186171AF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x61715D0", Offset = "0x61709D0", VA = "0x1861715D0", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x61714F0", Offset = "0x61708F0", VA = "0x1861714F0", Slot = "4")]
	public int CompareTo(FNONGLLGKNI KMJGEHGGFFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "5")]
	public bool Equals(FNONGLLGKNI KMJGEHGGFFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class OIMFOAEKKAE
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6179060", Offset = "0x6178460", VA = "0x186179060")]
	public static HJCBPKJLHPC CNKGNBEFLAF(this FNONGLLGKNI BHPOPDOKECN)
	{
		return default(HJCBPKJLHPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6179150", Offset = "0x6178550", VA = "0x186179150")]
	public static PLEIFDIMDAG PLJJBNJMADP(this FNONGLLGKNI BHPOPDOKECN, [Optional] object BDHKJODLPCL)
	{
		return default(PLEIFDIMDAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x27DC920", Offset = "0x27DBD20", VA = "0x1827DC920")]
	public static T IHGEGCJOLLG<T>(this FNONGLLGKNI BHPOPDOKECN) where T : struct, IComponent
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal sealed class FONJKLBOFJC
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct NFJNLPGNNDE : IEquatable<NFJNLPGNNDE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte PPOPFLAHPIC;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] HPJNFECJPHL;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static PJGGPMIHDNH PEPBCIJEAGM;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static OHNEMMIKCPK IIKMNNEBBFN;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static PJGGPMIHDNH[] NKBBDKNBOIJ;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static OHNEMMIKCPK[] NOKEMENIBIP;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> IHCJKICFLOA;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public OHNEMMIKCPK KMOMDJJEIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6177C30", Offset = "0x6177030", VA = "0x186177C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public PJGGPMIHDNH EDHIFAHPPJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x61780A0", Offset = "0x61774A0", VA = "0x1861780A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6178940", Offset = "0x6177D40", VA = "0x186178940")]
	static NFJNLPGNNDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xC48A30", Offset = "0xC47E30", VA = "0x180C48A30")]
	internal NFJNLPGNNDE(byte ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x53BDED0", Offset = "0x53BD2D0", VA = "0x1853BDED0", Slot = "4")]
	public bool Equals(NFJNLPGNNDE KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6177B90", Offset = "0x6176F90", VA = "0x186177B90", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1A33610", Offset = "0x1A32A10", VA = "0x181A33610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6178880", Offset = "0x6177C80", VA = "0x186178880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6178660", Offset = "0x6177A60", VA = "0x186178660")]
	private static PJGGPMIHDNH OAICACNCGBF(byte PPOPFLAHPIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6177A50", Offset = "0x6176E50", VA = "0x186177A50")]
	private static OHNEMMIKCPK BFECGDDEDHB(byte PPOPFLAHPIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6178710", Offset = "0x6177B10", VA = "0x186178710")]
	private static object PCLMEPLPCBA(byte PPOPFLAHPIC, object[] KOOGKOFEACD, object ELCHMECHBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6178390", Offset = "0x6177790", VA = "0x186178390")]
	private static int NHOPECANBOE(byte PPOPFLAHPIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6177A40", Offset = "0x6176E40", VA = "0x186177A40")]
	private static int AAFGDJAPIGG(byte PPOPFLAHPIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6177B10", Offset = "0x6176F10", VA = "0x186177B10")]
	private static (int, int) DIFPJNMBCBO(byte PPOPFLAHPIC)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6177B00", Offset = "0x6176F00", VA = "0x186177B00")]
	private static byte CAHNNHDCDLP(int MCCNLGBAILL, int AHDNEIKOMIB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x61783A0", Offset = "0x61777A0", VA = "0x1861783A0")]
	internal static NFJNLPGNNDE NLKKEGKJEDJ(OHNEMMIKCPK OAKCPJJHBIB, PJGGPMIHDNH NGCKCIJJGEE)
	{
		return default(NFJNLPGNNDE);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6178180", Offset = "0x6177580", VA = "0x186178180")]
	internal static void MHIFDGFFNKK(NFJNLPGNNDE PPOPFLAHPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6177D10", Offset = "0x6177110", VA = "0x186177D10")]
	private static void GHBEJCHNAPG(int LNJIGPAGCFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface KEFAMKCIBEG
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MAFDDIOOCAE();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BONIOFDAPCD(bool OEIALCNHGBO);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJNBOFHIDIC(GameObject ILLDLCGIGNA);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface AIMBKOLKPOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	Guid MFOENJNILEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EAILLHKMBLB(Guid NBAEPLMBFHD, Guid DMODMMDCPDA);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task MBDMOPCINOB(FNONGLLGKNI PAABBLGPJOB);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LGCPBFJBNEM(FNONGLLGKNI PBEFJCLMEAP, FNONGLLGKNI EMDODFFCGEF, [Out] Vector3 KGGMKBFJBJC, [Out] Quaternion PDMDMCJFOIG);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PFFLBBAAMFO(JKIDKBCCJKE HNAKOOHHEPN, Vector3 KGGMKBFJBJC, Quaternion PDMDMCJFOIG);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IELHGKABECL(FNONGLLGKNI COPNIDIBKHK, [Out] Vector3 CNPCEAPPFCB, [Out] Quaternion DCKHAEFABGE);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface MLNIEIGCEIL
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDJCHMDEJED(NKDFDPPNGFC LKLMPHAAIMO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface GNNAPPBDGGF
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	KEFAMKCIBEG NCBMGDCIFIB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IEDONMNAMME IHOHCHHHLDA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	AOEHKGJPNBJ OIIOCALBIKH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	CKDLAGLLCOC BOPODBABCIK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	BAKFKCHKGLC IHHIHGEHIDO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	DJNDFLEDODA IKEKDKLKGAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	IMNHHLOMKAF LGLLGPMOAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	FNJKDFMOKHL NJKEMCHKLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface LLJOMNNBKKE
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NFFDCJDPABB(Action HKJBPIINLDG, bool HOJGMPHIEKK);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EHJMPIPKGHI(string GFBABMFGHOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface IEDONMNAMME
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string OOLDEMKFHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] NJDHAPBPKEG(IEnumerable<CBHEKEEBBBM> FMMNCBEKOKF);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DNLLFFNFDNG(GameObject ILLDLCGIGNA, [Out] HJCBPKJLHPC[] PBCPOGJBFBN);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NCOFHLBFEKK(GameObject ILLDLCGIGNA, [Out] int LEMOAJNHJKK, [Out] GLDOCFALIAD APPOBJLFBKD);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EABJBIEJJPB NJAMFAAHKJF(CBHEKEEBBBM DKBCOOIEPBC);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EABJBIEJJPB NJAMFAAHKJF(string FBLBKEHCCCC, HJCBPKJLHPC[] KLMFOODJGLC, Vector3 BEBKKMFGLCG, Quaternion IKFFGJBHBIC, Vector3 LFBOEHOBPJC);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GameObject DFGBGMBOGPC(string FBLBKEHCCCC);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PPBNBPBJKAD(GameObject JKBMEMAAEKB, bool NAPMNDMEGPA);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EJPFKONGHLN(GameObject ILLDLCGIGNA, bool MEMMIKBNBJL, bool JAIGDPEHPNK);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class LFBKKKONBAM
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6175990", Offset = "0x6174D90", VA = "0x186175990")]
	public static EABJBIEJJPB NJAMFAAHKJF(this IEDONMNAMME LBELJDFAMCF, Vector3 BEBKKMFGLCG, Quaternion IKFFGJBHBIC, Vector3 LFBOEHOBPJC, params HJCBPKJLHPC[] PBCPOGJBFBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface AOEHKGJPNBJ
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNFAADENKLK(bool FAEFLPADKEG);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface CKDLAGLLCOC
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	bool EJPGANCAHMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool LOAJFNLOKMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool DPIFJLIOOKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	int GAONKOELJGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool JFNJEFEPCGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DDPCPBKAGMH(object KFANGHDLFAN);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GCCBJLILJEJ(object KFANGHDLFAN);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KMLAGPKJBNF(object JILDGEDOLHB);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DELDGMEOHNB(object JILDGEDOLHB);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int FGEAEFLMOPA(GameObject KBHIFOELGCI);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DDMEPODGNEI(NativeArray<int> LEIAANOKLFE);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LFDKMPPNGMA(NativeArray<int> JCEADIDHIIK);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NPPEPJEGBBN();

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IIELNCNDOEB(uint AAELINCEHGC, ReadOnlySpan<byte> LBOIGODDLNK, bool INPMFMGKHHN = false);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IIELNCNDOEB(uint AAELINCEHGC, ReadOnlySpan<byte> LBOIGODDLNK, ReadOnlySpan<byte> COJMPDCGHJO, bool INPMFMGKHHN = false);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface BAKFKCHKGLC
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGDJFFMEKAB(GameObject ILLDLCGIGNA);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface CFHDIAJBOAK
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OBPJIBBPOGO(string CAIOIMEOMNJ);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface JEFELECJKEI
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int EGBBAMNMGLJ(GameObject ILLDLCGIGNA);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EFGPJOHCEJM(GameObject ILLDLCGIGNA);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	object GGAJKJBJAJK(FNONGLLGKNI KKLABGAMOPP, GameObject ILLDLCGIGNA, Action<FNONGLLGKNI, int> KNDPECEGMIA);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KAIKMMAKDDI(GameObject ILLDLCGIGNA, object CAGMEEIAENN);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface DJNDFLEDODA
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	int LBAINHPOBMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int BCFGGKPEJNN(GameObject ILLDLCGIGNA);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BLBMBGMCLBC([Out] Vector3 BEBKKMFGLCG);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CEAKAFFNHDK();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface IMNHHLOMKAF
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool CLFDBHLJNCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool DFBFKPGIPLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface AFIHOMCOABE
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	IPAOBGLAFFA KDCANKHIHAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	PEPEGHHKMCG OBHHJOCLNKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NBLEIHMLNGM(Transform NPBNAACKOLN);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DAIBHJEOECC(Transform NPBNAACKOLN, INGFDOACPCK LOENDAIPILK);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BHJPEBGBBEJ(Transform NPBNAACKOLN, PBFAHIGAOLI DBDNECKMLBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface FNJKDFMOKHL
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JCLKEGHMEOG();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface JOOJMEEGGDM
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DIMJBNAOFJE();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface CJFHBHJENEE
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GLDOCFALIAD EAPBBLHELIC(GameObject KBHIFOELGCI);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJHBJKOKCJN(GameObject ILLDLCGIGNA, MHFGPABNDNL BMNCEFOPECL, GDIOOMEIOJG LHBLMHEALGF);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string NPNONODEEFC(int FNOGEAGAPLC);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HIDNDOAOKKH(string LALDDLOBIGN);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JJKBPABIDLM(FNONGLLGKNI KKLABGAMOPP, int[] JIPOHLKKMIP);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ALCPEONCBNK(GameObject NNNCDAOFHHD, GameObject FJPKFAEKDOB, int MAMLOLDGGEI);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct ANBDOEMDPBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly CKDLBJDLPKI PKHCCBJJMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly CKDLBJDLPKI NDFFDHJCFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal readonly uint JNMOHELIJKL;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x616AE40", Offset = "0x616A240", VA = "0x18616AE40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct MNPHOKCIFBM
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly OKECMMGLCGL ECHPFBNKINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly ANBDOEMDPBJ HKJBPIINLDG;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6177900", Offset = "0x6176D00", VA = "0x186177900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct PABMFAKCNKJ
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly OKECMMGLCGL ECHPFBNKINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly ANBDOEMDPBJ HKJBPIINLDG;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6177900", Offset = "0x6176D00", VA = "0x186177900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct LFDJFKKKHEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint JNMOHELIJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly bool NEDBOOHDCJC;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6175B70", Offset = "0x6174F70", VA = "0x186175B70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct CKDLBJDLPKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal int JNLHAMBBADE;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x616DD40", Offset = "0x616D140", VA = "0x18616DD40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface MLKJICGHHKE
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	HNCLNHGECCD AFGHAMIKJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum FDMKFPHEELP
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
public interface EABJBIEJJPB : NGNKAINABOH
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	PLEIFDIMDAG CGKIHHOMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	FDMKFPHEELP MOEOMELAFIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool OMCAIPDPOOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	GameObject ILLDLCGIGNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<EABJBIEJJPB> JBOPHGOEFLH;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(JOIBJAFEBEM MPJNGJLMHCG, FNONGLLGKNI HBHEEJPNNOO);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool GLJDFNLADAF);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class HEBOGAOJHJB
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6172C70", Offset = "0x6172070", VA = "0x186172C70")]
	public static bool JGOCMMKBBDN(this EABJBIEJJPB FLHPNPKFFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6172B40", Offset = "0x6171F40", VA = "0x186172B40")]
	public static bool EMFEOJIPCLL(this EABJBIEJJPB FLHPNPKFFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6172C20", Offset = "0x6172020", VA = "0x186172C20")]
	public static bool JFJEGDNHGOM(this EABJBIEJJPB FLHPNPKFFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6172B90", Offset = "0x6171F90", VA = "0x186172B90")]
	public static bool FMCKFONPAAG(this EABJBIEJJPB FLHPNPKFFLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface NGNKAINABOH
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool HGMIANMMKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	FNONGLLGKNI KFCEIPDGLIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[DKGHNNODKMB(NKCLGJJOGJC.LoadInstance)]
internal interface JOMPOKGPCIC
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<BCPLPKEILJC> ACILPJOBBEN;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface BHDPGAHBOKN : BCDJLPHBKHK<HJCBPKJLHPC>, JHNLCGMJGKI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface FEDNEGDEHCB<T> : DCLIEALIPIH<HJCBPKJLHPC, T>, BCDJLPHBKHK<HJCBPKJLHPC>, JHNLCGMJGKI, IDisposable, BHDPGAHBOKN where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class NMGMMBBFCHJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x26852D0", Offset = "0x26846D0", VA = "0x1826852D0")]
	public static bool DABECMHCGCA<T>(this BCDJLPHBKHK<HJCBPKJLHPC> PLNALAIILFK, HJCBPKJLHPC KLMFOODJGLC, [Out] T ANJCCKHBJJO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x25419B0", Offset = "0x2540DB0", VA = "0x1825419B0")]
	public static bool ENHGLNPEFHG<T>(this BCDJLPHBKHK<HJCBPKJLHPC> PLNALAIILFK, HJCBPKJLHPC KLMFOODJGLC, [In] T IDOIAPJOEJP) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface PNOKIMEDNFB : BCDJLPHBKHK<FNONGLLGKNI>, JHNLCGMJGKI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface KCKMABFBDCH<T> : DCLIEALIPIH<FNONGLLGKNI, T>, BCDJLPHBKHK<FNONGLLGKNI>, JHNLCGMJGKI, IDisposable, PNOKIMEDNFB where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class OKJPFBHAFBC
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2519BF0", Offset = "0x2518FF0", VA = "0x182519BF0")]
	public static T JJNOBLLAEFC<T>(this BCDJLPHBKHK<FNONGLLGKNI> PLNALAIILFK, FNONGLLGKNI KKLABGAMOPP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x25419F0", Offset = "0x2540DF0", VA = "0x1825419F0")]
	public static bool ENHGLNPEFHG<T>(this BCDJLPHBKHK<FNONGLLGKNI> PLNALAIILFK, FNONGLLGKNI KKLABGAMOPP, [In] T IDOIAPJOEJP) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct OPJBLBHDCME : IComparable<OPJBLBHDCME>, IEquatable<OPJBLBHDCME>
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly OPJBLBHDCME FGEMAOBKBLF;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly OPJBLBHDCME CAGPIAFFFOG;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly OPJBLBHDCME IPMNHPMONLO;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly OPJBLBHDCME OFDJJMLLPNA;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly OPJBLBHDCME HIDHPNALKCP;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly OPJBLBHDCME MCIHCLCLBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int BLAEHDOLMPP;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool PFGNAENCKGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6179830", Offset = "0x6178C30", VA = "0x186179830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int JCJHBJFMBLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6179840", Offset = "0x6178C40", VA = "0x186179840")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x88D240", Offset = "0x88C640", VA = "0x18088D240")]
	public OPJBLBHDCME(int AHDNEIKOMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x61797D0", Offset = "0x6178BD0", VA = "0x1861797D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6179750", Offset = "0x6178B50", VA = "0x186179750", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x818880", Offset = "0x817C80", VA = "0x180818880", Slot = "5")]
	public bool Equals(OPJBLBHDCME KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x175E4A0", Offset = "0x175D8A0", VA = "0x18175E4A0", Slot = "4")]
	public int CompareTo(OPJBLBHDCME KMJGEHGGFFC)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0xBFD9F0", Offset = "0xBFCDF0", VA = "0x180BFD9F0")]
	public static OPJBLBHDCME JPANIEAALPM(int AHDNEIKOMIB)
	{
		return default(OPJBLBHDCME);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0xBFD9F0", Offset = "0xBFCDF0", VA = "0x180BFD9F0")]
	public static int JPANIEAALPM(OPJBLBHDCME BLGMLDLMDIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6179850", Offset = "0x6178C50", VA = "0x186179850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct PLEIFDIMDAG : IEquatable<PLEIFDIMDAG>, NGNKAINABOH
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly PLEIFDIMDAG JGKJOMMEPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public FNONGLLGKNI KFCEIPDGLIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0", Slot = "6")]
		get
		{
			return default(FNONGLLGKNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public CMFAFOIMJFG ODAEKBBDPFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(CMFAFOIMJFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public HGMCICPFHLP LHMFADBCBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(HGMCICPFHLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private PJGGPMIHDNH NIOANIAOFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x616BC40", Offset = "0x616B040", VA = "0x18616BC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public GameObject ILLDLCGIGNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x617A490", Offset = "0x6179890", VA = "0x18617A490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public HJCBPKJLHPC MIGPOKGFDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x617A0F0", Offset = "0x61794F0", VA = "0x18617A0F0")]
		get
		{
			return default(HJCBPKJLHPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public CPHIGBBODAJ OEDNFHGCONC
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6179ED0", Offset = "0x61792D0", VA = "0x186179ED0")]
		get
		{
			return default(CPHIGBBODAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GLDOCFALIAD GIKALMDJECI
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x617A390", Offset = "0x6179790", VA = "0x18617A390")]
		get
		{
			return default(GLDOCFALIAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool PMEAACKPABD
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x617A370", Offset = "0x6179770", VA = "0x18617A370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool PPEGNKLAEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6179F70", Offset = "0x6179370", VA = "0x186179F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool EPEDPDLOINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x617A090", Offset = "0x6179490", VA = "0x18617A090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool BGOMFGLKCNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x617A470", Offset = "0x6179870", VA = "0x18617A470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool PBCPMOMFNJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x617A6A0", Offset = "0x6179AA0", VA = "0x18617A6A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool OKBOGHPPEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x617A020", Offset = "0x6179420", VA = "0x18617A020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool GBCJIEFCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6179D80", Offset = "0x6179180", VA = "0x186179D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool ICHKHIPCACH
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6179EB0", Offset = "0x61792B0", VA = "0x186179EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public AMHNGBDNBPG IDHBKOOIBCK
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(AMHNGBDNBPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public DJKGDIDIMEN EKCILPMBDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(DJKGDIDIMEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public EICPDCPMDBD OFJJEBLFKLI
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(EICPDCPMDBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public BKNIGHKIKGL LNHDLNIFHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(BKNIGHKIKGL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public BFGICBBFPDD MDAJMKNDCGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(BFGICBBFPDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public CNGDGOIFCDH CEGMKCDNHGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(CNGDGOIFCDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public JKIDKBCCJKE PPGPIILCKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(JKIDKBCCJKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public AAFFIEDODNK JHFLNBCJNLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(AAFFIEDODNK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool JGOCMMKBBDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x617A190", Offset = "0x6179590", VA = "0x18617A190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool BPPJBMJEACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x617A430", Offset = "0x6179830", VA = "0x18617A430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool JBCJOHFGJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x617A0B0", Offset = "0x61794B0", VA = "0x18617A0B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private bool MPKHDLDDAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2A0", Offset = "0x7B96A0", VA = "0x1807BA2A0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060")]
	public PLEIFDIMDAG(FNONGLLGKNI KKLABGAMOPP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x616BB90", Offset = "0x616AF90", VA = "0x18616BB90")]
	public static bool JPANIEAALPM(PLEIFDIMDAG ANJCCKHBJJO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x86E470", Offset = "0x86D870", VA = "0x18086E470")]
	public static FNONGLLGKNI JPANIEAALPM(PLEIFDIMDAG ANJCCKHBJJO)
	{
		return default(FNONGLLGKNI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x61763B0", Offset = "0x61757B0", VA = "0x1861763B0")]
	public static bool HOHCACPHFGD(PLEIFDIMDAG KHCOFGFJDMP, PLEIFDIMDAG NFAPJGNODPK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6171490", Offset = "0x6170890", VA = "0x186171490")]
	public static bool AEMEGLCBHEE(PLEIFDIMDAG KHCOFGFJDMP, PLEIFDIMDAG NFAPJGNODPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6179F90", Offset = "0x6179390", VA = "0x186179F90", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "4")]
	public bool Equals(PLEIFDIMDAG KMJGEHGGFFC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x86E470", Offset = "0x86D870", VA = "0x18086E470")]
	public static PLEIFDIMDAG JPANIEAALPM(FNONGLLGKNI CMIPJIFIMCO)
	{
		return default(PLEIFDIMDAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x617A620", Offset = "0x6179A20", VA = "0x18617A620")]
	public KDBHPJJIIHH MLMIFOIEOOP()
	{
		return default(KDBHPJJIIHH);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x617A060", Offset = "0x6179460", VA = "0x18617A060")]
	public MKFOBKHKHDC GNCPGGLGGAE()
	{
		return default(MKFOBKHKHDC);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x617A6C0", Offset = "0x6179AC0", VA = "0x18617A6C0")]
	public IILPDAHBFFI PLCKAJABDEP()
	{
		return default(IILPDAHBFFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x617A710", Offset = "0x6179B10", VA = "0x18617A710")]
	public void PLJJBNJMADP([Optional] object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x617A280", Offset = "0x6179680", VA = "0x18617A280")]
	public bool IGOADJGKMMD(object BDHKJODLPCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6179DC0", Offset = "0x61791C0", VA = "0x186179DC0")]
	public bool BMKKBMKMEJD(object BDHKJODLPCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x617A7B0", Offset = "0x6179BB0", VA = "0x18617A7B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct JKIDKBCCJKE : IEquatable<JKIDKBCCJKE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public FNONGLLGKNI KFCEIPDGLIM
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(FNONGLLGKNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public PLEIFDIMDAG CGKIHHOMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	private PJGGPMIHDNH NIOANIAOFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x616BC40", Offset = "0x616B040", VA = "0x18616BC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	private IBEAMCOGAPL NIHNDEIKMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x61744C0", Offset = "0x61738C0", VA = "0x1861744C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	private GPNCCIIBJBO DHALLHKMMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6173EB0", Offset = "0x61732B0", VA = "0x186173EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public bool FAOGHBDCBEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6173D00", Offset = "0x6173100", VA = "0x186173D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Guid NPFNAAOAHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6174030", Offset = "0x6173430", VA = "0x186174030")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public bool NIFBBDBFDDG
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6174430", Offset = "0x6173830", VA = "0x186174430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Guid KOCONPECOPH
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6174310", Offset = "0x6173710", VA = "0x186174310")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060")]
	public JKIDKBCCJKE(FNONGLLGKNI KKLABGAMOPP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x616BB90", Offset = "0x616AF90", VA = "0x18616BB90")]
	public static bool JPANIEAALPM(JKIDKBCCJKE ANJCCKHBJJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6173E20", Offset = "0x6173220", VA = "0x186173E20", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "4")]
	public bool Equals(JKIDKBCCJKE KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x616A140", Offset = "0x6169540", VA = "0x18616A140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6174270", Offset = "0x6173670", VA = "0x186174270")]
	public bool LKPMIEBMBOO([Out] Guid NGLJABNBABA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6174150", Offset = "0x6173550", VA = "0x186174150")]
	public void JOHBCAKNIGN(Guid LEPPJAEDELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6173C60", Offset = "0x6173060", VA = "0x186173C60")]
	public bool BIOEKMHOFPE([Out] Guid MADPFKENMIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6173F10", Offset = "0x6173310", VA = "0x186173F10")]
	public void HMPDANIFOJB(Guid LEPPJAEDELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6173D90", Offset = "0x6173190", VA = "0x186173D90")]
	public void DIHLCPMIEIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public readonly struct IILPDAHBFFI : IEquatable<IILPDAHBFFI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public FNONGLLGKNI KFCEIPDGLIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(FNONGLLGKNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public PLEIFDIMDAG CGKIHHOMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private PJGGPMIHDNH NIOANIAOFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x616BC40", Offset = "0x616B040", VA = "0x18616BC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private IBEAMCOGAPL NIHNDEIKMHK
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6173A90", Offset = "0x6172E90", VA = "0x186173A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private IGENMOGNKOM AAKHGAFGOMP
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x61737F0", Offset = "0x6172BF0", VA = "0x1861737F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float3 MLLPKPKNAIP
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x61736C0", Offset = "0x6172AC0", VA = "0x1861736C0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public quaternion NOABNDFAPGA
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x61738E0", Offset = "0x6172CE0", VA = "0x1861738E0")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public PLEIFDIMDAG HACECPECNGG
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6173A00", Offset = "0x6172E00", VA = "0x186173A00")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060")]
	public IILPDAHBFFI(FNONGLLGKNI KKLABGAMOPP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x86E470", Offset = "0x86D870", VA = "0x18086E470")]
	public static FNONGLLGKNI JPANIEAALPM(IILPDAHBFFI ANJCCKHBJJO)
	{
		return default(FNONGLLGKNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6173850", Offset = "0x6172C50", VA = "0x186173850", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "4")]
	public bool Equals(IILPDAHBFFI KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x616A140", Offset = "0x6169540", VA = "0x18616A140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct KDBHPJJIIHH : IEquatable<KDBHPJJIIHH>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class GOAFFFFFPPH : IEnumerable<PLEIFDIMDAG>, IEnumerable, IEnumerator<PLEIFDIMDAG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private PLEIFDIMDAG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public KDBHPJJIIHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public KDBHPJJIIHH <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private IEnumerator<PLEIFDIMDAG> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private IEnumerator<FNONGLLGKNI> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		private PLEIFDIMDAG System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.RRObject>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x333EDE0", Offset = "0x333E1E0", VA = "0x18333EDE0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(PLEIFDIMDAG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x61727C0", Offset = "0x6171BC0", VA = "0x1861727C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3535DA0", Offset = "0x35351A0", VA = "0x183535DA0")]
		[DebuggerHidden]
		public GOAFFFFFPPH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6172810", Offset = "0x6171C10", VA = "0x186172810", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x61721B0", Offset = "0x61715B0", VA = "0x1861721B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6172110", Offset = "0x6171510", VA = "0x186172110")]
		private void JIKMBFFNLEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x61720C0", Offset = "0x61714C0", VA = "0x1861720C0")]
		private void DNFFEPBIMEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6172160", Offset = "0x6171560", VA = "0x186172160")]
		private void JLPNAMOJFPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6172770", Offset = "0x6171B70", VA = "0x186172770", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x61726D0", Offset = "0x6171AD0", VA = "0x1861726D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PLEIFDIMDAG> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.RRObject>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x61726D0", Offset = "0x6171AD0", VA = "0x1861726D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly KDBHPJJIIHH JGKJOMMEPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public FNONGLLGKNI KFCEIPDGLIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(FNONGLLGKNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public PLEIFDIMDAG CGKIHHOMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public CMFAFOIMJFG ODAEKBBDPFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(CMFAFOIMJFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public HGMCICPFHLP LHMFADBCBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(HGMCICPFHLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private PJGGPMIHDNH NIOANIAOFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x616BC40", Offset = "0x616B040", VA = "0x18616BC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private IBEAMCOGAPL NIHNDEIKMHK
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6175900", Offset = "0x6174D00", VA = "0x186175900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private BDAIBKCOJKP FKEIMMILHDE
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x61758A0", Offset = "0x6174CA0", VA = "0x1861758A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public NKDFDPPNGFC CLDEBBGNCCG
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6175180", Offset = "0x6174580", VA = "0x186175180")]
		get
		{
			return default(NKDFDPPNGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public IEnumerable<PLEIFDIMDAG> BDNCPDNOGEM
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6174EF0", Offset = "0x61742F0", VA = "0x186174EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public IEnumerable<PLEIFDIMDAG> FDILAKMLCCP
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6174BD0", Offset = "0x6173FD0", VA = "0x186174BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int DBLLBONODBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x6174D90", Offset = "0x6174190", VA = "0x186174D90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public int DIHDDJAFMFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6175130", Offset = "0x6174530", VA = "0x186175130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public string GAOODFEKINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6175780", Offset = "0x6174B80", VA = "0x186175780")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x61754C0", Offset = "0x61748C0", VA = "0x1861754C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public OBAOFNGLGAB PEAPDPKGGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6175650", Offset = "0x6174A50", VA = "0x186175650")]
		get
		{
			return default(OBAOFNGLGAB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6175060", Offset = "0x6174460", VA = "0x186175060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public PKHEKFLKJFO PGCGEBKEOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x6174850", Offset = "0x6173C50", VA = "0x186174850")]
		get
		{
			return default(PKHEKFLKJFO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x6175450", Offset = "0x6174850", VA = "0x186175450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public EEEFPBMLPEF AOCKELJAGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6175240", Offset = "0x6174640", VA = "0x186175240")]
		get
		{
			return default(EEEFPBMLPEF);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x61745E0", Offset = "0x61739E0", VA = "0x1861745E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public float JFJBKFHHAFN
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6174E90", Offset = "0x6174290", VA = "0x186174E90")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x6175570", Offset = "0x6174970", VA = "0x186175570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool JKDAGLKAMHP
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x61746C0", Offset = "0x6173AC0", VA = "0x1861746C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool GKEMENEFAIN
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6174650", Offset = "0x6173A50", VA = "0x186174650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool KCOMMAEBIDF
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6174E20", Offset = "0x6174220", VA = "0x186174E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool IODMDAPCFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6175830", Offset = "0x6174C30", VA = "0x186175830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool HFLINLCHLEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x61756B0", Offset = "0x6174AB0", VA = "0x1861756B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x61755E0", Offset = "0x61749E0", VA = "0x1861755E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool GIJPEGMBMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x61750D0", Offset = "0x61744D0", VA = "0x1861750D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x6175710", Offset = "0x6174B10", VA = "0x186175710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060")]
	public KDBHPJJIIHH(FNONGLLGKNI KKLABGAMOPP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x616BB90", Offset = "0x616AF90", VA = "0x18616BB90")]
	public static bool JPANIEAALPM(KDBHPJJIIHH ANJCCKHBJJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6174D00", Offset = "0x6174100", VA = "0x186174D00", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "4")]
	public bool Equals(KDBHPJJIIHH KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x616A140", Offset = "0x6169540", VA = "0x18616A140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x86E470", Offset = "0x86D870", VA = "0x18086E470")]
	public static PLEIFDIMDAG JPANIEAALPM(KDBHPJJIIHH BHGHMPIHGBP)
	{
		return default(PLEIFDIMDAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6174730", Offset = "0x6173B30", VA = "0x186174730")]
	public bool BKOGKJAIKEJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x61748B0", Offset = "0x6173CB0", VA = "0x1861748B0")]
	public bool DMLOODOMPBN(IHKKOAMIJFG MKKNEKCALEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x61747D0", Offset = "0x6173BD0", VA = "0x1861747D0")]
	public void CJOEKALIIPK(IHKKOAMIJFG MKKNEKCALEF, bool ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x61752A0", Offset = "0x61746A0", VA = "0x1861752A0")]
	public NKDFDPPNGFC JGDDLMNKDCL(Allocator OLAJGHFDGHM)
	{
		return default(NKDFDPPNGFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6174920", Offset = "0x6173D20", VA = "0x186174920")]
	public void DOEBEKLJJAB(KDBHPJJIIHH KMJGEHGGFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6174750", Offset = "0x6173B50", VA = "0x186174750")]
	[IteratorStateMachine(typeof(GOAFFFFFPPH))]
	public IEnumerable<PLEIFDIMDAG> BMKNLKIFAED()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct PHKGHNBGPJP : IEquatable<PHKGHNBGPJP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public PLEIFDIMDAG CGKIHHOMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6179CF0", Offset = "0x61790F0", VA = "0x186179CF0", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "4")]
	public bool Equals(PHKGHNBGPJP KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x616A140", Offset = "0x6169540", VA = "0x18616A140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct DJKGDIDIMEN : IEquatable<DJKGDIDIMEN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public PLEIFDIMDAG CGKIHHOMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private PJGGPMIHDNH NIOANIAOFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x616BC40", Offset = "0x616B040", VA = "0x18616BC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060")]
	public DJKGDIDIMEN(FNONGLLGKNI KKLABGAMOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6170DD0", Offset = "0x61701D0", VA = "0x186170DD0", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "4")]
	public bool Equals(DJKGDIDIMEN KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x616A140", Offset = "0x6169540", VA = "0x18616A140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6170F00", Offset = "0x6170300", VA = "0x186170F00")]
	public void HJKKNDHGMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6170E60", Offset = "0x6170260", VA = "0x186170E60")]
	public void FOLNLKAHFII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct FIHMFJEMCPM : IEquatable<FIHMFJEMCPM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public PLEIFDIMDAG CGKIHHOMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x61712B0", Offset = "0x61706B0", VA = "0x1861712B0", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "4")]
	public bool Equals(FIHMFJEMCPM KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x616A140", Offset = "0x6169540", VA = "0x18616A140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct KAJILOHNPFM : IEquatable<KAJILOHNPFM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public PLEIFDIMDAG CGKIHHOMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6174550", Offset = "0x6173950", VA = "0x186174550", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "4")]
	public bool Equals(KAJILOHNPFM KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x616A140", Offset = "0x6169540", VA = "0x18616A140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct LJCJNMLBMHM : IEquatable<LJCJNMLBMHM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public PLEIFDIMDAG CGKIHHOMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6175C10", Offset = "0x6175010", VA = "0x186175C10", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "4")]
	public bool Equals(LJCJNMLBMHM KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x616A140", Offset = "0x6169540", VA = "0x18616A140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public readonly struct HADJFMKCKPC : IEquatable<HADJFMKCKPC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public PLEIFDIMDAG CGKIHHOMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6172A10", Offset = "0x6171E10", VA = "0x186172A10", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "4")]
	public bool Equals(HADJFMKCKPC KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x616A140", Offset = "0x6169540", VA = "0x18616A140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct HGMCICPFHLP : IEquatable<HGMCICPFHLP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public FNONGLLGKNI KFCEIPDGLIM
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(FNONGLLGKNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public PLEIFDIMDAG CGKIHHOMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private PJGGPMIHDNH NIOANIAOFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x616BC40", Offset = "0x616B040", VA = "0x18616BC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private IBEAMCOGAPL NIHNDEIKMHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x6173420", Offset = "0x6172820", VA = "0x186173420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private BDAIBKCOJKP FKEIMMILHDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x61733C0", Offset = "0x61727C0", VA = "0x1861733C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public FNONGLLGKNI LEAOLOGLNHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6172D50", Offset = "0x6172150", VA = "0x186172D50")]
		get
		{
			return default(FNONGLLGKNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public PLEIFDIMDAG EOGAOJCDEEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6172CC0", Offset = "0x61720C0", VA = "0x186172CC0")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PLEIFDIMDAG OPHGKOLAGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6173290", Offset = "0x6172690", VA = "0x186173290")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060")]
	public HGMCICPFHLP(FNONGLLGKNI KKLABGAMOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6172DE0", Offset = "0x61721E0", VA = "0x186172DE0", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "4")]
	public bool Equals(HGMCICPFHLP KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x616A140", Offset = "0x6169540", VA = "0x18616A140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6173100", Offset = "0x6172500", VA = "0x186173100")]
	public bool IPJNFPFPNEM(PLEIFDIMDAG EMDODFFCGEF, bool ANNNFPPNMGG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6173320", Offset = "0x6172720", VA = "0x186173320")]
	public bool NKBPKGMMCKJ(PLEIFDIMDAG KONKEKDJKDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6172E70", Offset = "0x6172270", VA = "0x186172E70")]
	private void IONKJNJGCHJ(PLEIFDIMDAG EGOMPMODMEH, List<PLEIFDIMDAG> PLPJHPFDINJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6173230", Offset = "0x6172630", VA = "0x186173230")]
	public void JEGOMANOLAD(List<PLEIFDIMDAG> NBOONPHGBPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct AMHNGBDNBPG : IEquatable<AMHNGBDNBPG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public PLEIFDIMDAG CGKIHHOMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public string AHFHDEHNJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x616ADC0", Offset = "0x616A1C0", VA = "0x18616ADC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public string AOBAFJPCMJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x616A160", Offset = "0x6169560", VA = "0x18616A160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private bool GJPJFOPLHFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x616A2E0", Offset = "0x61696E0", VA = "0x18616A2E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public string LLCHHIHBGEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x616ACD0", Offset = "0x616A0D0", VA = "0x18616ACD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public string EGPJPGMELHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x616AA80", Offset = "0x6169E80", VA = "0x18616AA80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public string AEOPKICPLLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x616A230", Offset = "0x6169630", VA = "0x18616A230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060")]
	public AMHNGBDNBPG(FNONGLLGKNI KKLABGAMOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x616A420", Offset = "0x6169820", VA = "0x18616A420", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "4")]
	public bool Equals(AMHNGBDNBPG KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x616A140", Offset = "0x6169540", VA = "0x18616A140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x616A4B0", Offset = "0x61698B0", VA = "0x18616A4B0")]
	private static string ICDAIKKLEFH(GLDOCFALIAD BEJFBOABMOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct OHGMPMBGFJE : IEquatable<OHGMPMBGFJE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public PLEIFDIMDAG CGKIHHOMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6178FD0", Offset = "0x61783D0", VA = "0x186178FD0", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "4")]
	public bool Equals(OHGMPMBGFJE KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x616A140", Offset = "0x6169540", VA = "0x18616A140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct EICPDCPMDBD : IEquatable<EICPDCPMDBD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public PLEIFDIMDAG CGKIHHOMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060")]
	public EICPDCPMDBD(FNONGLLGKNI KKLABGAMOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6171110", Offset = "0x6170510", VA = "0x186171110", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "4")]
	public bool Equals(EICPDCPMDBD KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x616A140", Offset = "0x6169540", VA = "0x18616A140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x6170FA0", Offset = "0x61703A0", VA = "0x186170FA0")]
	public bool DMLIEKHBGAG([Out] Collider AILIANBMFFG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct BKNIGHKIKGL : IEquatable<BKNIGHKIKGL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public FNONGLLGKNI KFCEIPDGLIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(FNONGLLGKNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public PLEIFDIMDAG CGKIHHOMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private PJGGPMIHDNH NIOANIAOFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x616BC40", Offset = "0x616B040", VA = "0x18616BC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private IBEAMCOGAPL NIHNDEIKMHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x616D170", Offset = "0x616C570", VA = "0x18616D170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private BPIEEIGEMIJ MNHNLIMEIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x616CB50", Offset = "0x616BF50", VA = "0x18616CB50")]
		get
		{
			return default(BPIEEIGEMIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private ALEHIFLAIFG OGGDLNGIDBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x616CC10", Offset = "0x616C010", VA = "0x18616CC10")]
		get
		{
			return default(ALEHIFLAIFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool LFFDDKIBJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x616CFA0", Offset = "0x616C3A0", VA = "0x18616CFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool PIDFNOMNIBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x616D090", Offset = "0x616C490", VA = "0x18616D090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool NPKAGFJPPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x616C830", Offset = "0x616BC30", VA = "0x18616C830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool KDNEKCCAFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x616C990", Offset = "0x616BD90", VA = "0x18616C990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool MBHJDNBEKDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x616C2F0", Offset = "0x616B6F0", VA = "0x18616C2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool GBELDHCKKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x616C670", Offset = "0x616BA70", VA = "0x18616C670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool FDLHGBPMHEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x616C280", Offset = "0x616B680", VA = "0x18616C280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool CHNGDLNFBEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x616C750", Offset = "0x616BB50", VA = "0x18616C750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool KJJDLPNBNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x616CC70", Offset = "0x616C070", VA = "0x18616CC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool FDCCNNLPIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x616CE50", Offset = "0x616C250", VA = "0x18616CE50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool IIEFLFHLNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x616CA60", Offset = "0x616BE60", VA = "0x18616CA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool OOFHOJDMJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x616C6E0", Offset = "0x616BAE0", VA = "0x18616C6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool ONDMIFJPLEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x616C360", Offset = "0x616B760", VA = "0x18616C360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool GGCMCGCHCCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x616D200", Offset = "0x616C600", VA = "0x18616D200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool FKGCHLCEBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x616CCE0", Offset = "0x616C0E0", VA = "0x18616CCE0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x616D100", Offset = "0x616C500", VA = "0x18616D100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public EOCLBPNGFMP BNDHEMAHDIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x616CA00", Offset = "0x616BE00", VA = "0x18616CA00")]
		get
		{
			return default(EOCLBPNGFMP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x616CEC0", Offset = "0x616C2C0", VA = "0x18616CEC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool LOANPJHPBPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x616C4A0", Offset = "0x616B8A0", VA = "0x18616C4A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public GDIOOMEIOJG FOIABLEMDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x616C8A0", Offset = "0x616BCA0", VA = "0x18616C8A0")]
		get
		{
			return default(GDIOOMEIOJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool OOHEJACBDLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x616CBB0", Offset = "0x616BFB0", VA = "0x18616CBB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public Vector3 MPFEMBMHPND
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x616C3D0", Offset = "0x616B7D0", VA = "0x18616C3D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public Vector3 LPCMJJOPGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x616CFE0", Offset = "0x616C3E0", VA = "0x18616CFE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool JPEGPINEOKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x616CD50", Offset = "0x616C150", VA = "0x18616CD50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060")]
	public BKNIGHKIKGL(FNONGLLGKNI KKLABGAMOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x616C900", Offset = "0x616BD00", VA = "0x18616C900", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "4")]
	public bool Equals(BKNIGHKIKGL KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x616A140", Offset = "0x6169540", VA = "0x18616A140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x616CF30", Offset = "0x616C330", VA = "0x18616CF30")]
	public bool OIEPCLIGNCD(FEJJMBJFONO MKKNEKCALEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x616C7C0", Offset = "0x616BBC0", VA = "0x18616C7C0")]
	public bool EABHJMMBOAM(MHFGPABNDNL MKKNEKCALEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x616CAD0", Offset = "0x616BED0", VA = "0x18616CAD0")]
	public void ICJKBIAOGAC(MHFGPABNDNL MKKNEKCALEF, bool AKOFKNDDBNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct CNGDGOIFCDH : IEquatable<CNGDGOIFCDH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public FNONGLLGKNI KFCEIPDGLIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(FNONGLLGKNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public PLEIFDIMDAG CGKIHHOMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	private PJGGPMIHDNH NIOANIAOFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x616BC40", Offset = "0x616B040", VA = "0x18616BC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private IBEAMCOGAPL NIHNDEIKMHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6170330", Offset = "0x616F730", VA = "0x186170330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060")]
	public CNGDGOIFCDH(FNONGLLGKNI KKLABGAMOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6170180", Offset = "0x616F580", VA = "0x186170180", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "4")]
	public bool Equals(CNGDGOIFCDH KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x616A140", Offset = "0x6169540", VA = "0x18616A140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6170210", Offset = "0x616F610", VA = "0x186170210")]
	public void MBJFNPFGDMA(bool ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x61702A0", Offset = "0x616F6A0", VA = "0x1861702A0")]
	public void OHCFLLPNHPG(bool ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x24F4CA0", Offset = "0x24F40A0", VA = "0x1824F4CA0")]
	public T GAOIGOOEECJ<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct BFGICBBFPDD : IEquatable<BFGICBBFPDD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public FNONGLLGKNI KFCEIPDGLIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(FNONGLLGKNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public PLEIFDIMDAG CGKIHHOMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	private PJGGPMIHDNH NIOANIAOFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x616BC40", Offset = "0x616B040", VA = "0x18616BC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	private IBEAMCOGAPL NIHNDEIKMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x616C090", Offset = "0x616B490", VA = "0x18616C090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private JBPFLEGOCOA IOKMGMFDEHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x616B6C0", Offset = "0x616AAC0", VA = "0x18616B6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private LGECPKFCJMH CCGADKBEPLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x616B660", Offset = "0x616AA60", VA = "0x18616B660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool PPKMANGEKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x616BBB0", Offset = "0x616AFB0", VA = "0x18616BBB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool ALFLBOJNKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x616B450", Offset = "0x616A850", VA = "0x18616B450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool JKJFMNKJIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x616BAC0", Offset = "0x616AEC0", VA = "0x18616BAC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool OBNKLAKECJK
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x616B7B0", Offset = "0x616ABB0", VA = "0x18616B7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool FHKAOLKLBCC
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x616BA90", Offset = "0x616AE90", VA = "0x18616BA90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public bool HHPNNAKFCKB
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x616BCA0", Offset = "0x616B0A0", VA = "0x18616BCA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool DKGGHDLOBNP
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x616B880", Offset = "0x616AC80", VA = "0x18616B880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool NIMIOKGKDBN
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x616B4F0", Offset = "0x616A8F0", VA = "0x18616B4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060")]
	public BFGICBBFPDD(FNONGLLGKNI KKLABGAMOPP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x616BB90", Offset = "0x616AF90", VA = "0x18616BB90")]
	public static bool JPANIEAALPM(BFGICBBFPDD ANJCCKHBJJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x616B720", Offset = "0x616AB20", VA = "0x18616B720", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "4")]
	public bool Equals(BFGICBBFPDD KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x616A140", Offset = "0x6169540", VA = "0x18616A140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x616BE40", Offset = "0x616B240", VA = "0x18616BE40")]
	public bool OACEPENIHMM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x616BAF0", Offset = "0x616AEF0", VA = "0x18616BAF0")]
	public PLEIFDIMDAG JGPEDIJAKHN(PLEIFDIMDAG JILDGEDOLHB)
	{
		return default(PLEIFDIMDAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x616BD30", Offset = "0x616B130", VA = "0x18616BD30")]
	public FNONGLLGKNI NHAMGOHPNEN()
	{
		return default(FNONGLLGKNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x616BF60", Offset = "0x616B360", VA = "0x18616BF60")]
	public void PAJENKBEFBI(FNONGLLGKNI JILDGEDOLHB, FNONGLLGKNI ICHKLHFLBEC, FNONGLLGKNI HFELCKCMCCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct MKFOBKHKHDC : IEquatable<MKFOBKHKHDC>
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly MKFOBKHKHDC JGKJOMMEPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public FNONGLLGKNI KFCEIPDGLIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(FNONGLLGKNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public PLEIFDIMDAG CGKIHHOMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public CMFAFOIMJFG ODAEKBBDPFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(CMFAFOIMJFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private IAEPMJBDEDP ODKMFLAPJJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6176FD0", Offset = "0x61763D0", VA = "0x186176FD0")]
		get
		{
			return default(IAEPMJBDEDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public HJMLKLJEBMB MPJBLMCAKGB
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6177100", Offset = "0x6176500", VA = "0x186177100")]
		get
		{
			return default(HJMLKLJEBMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public HPHLIBHKDEL FMDCBJAHHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6176E10", Offset = "0x6176210", VA = "0x186176E10")]
		get
		{
			return default(HPHLIBHKDEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public AOFOHGHCAIB MMJHLPGLMJD
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x61770A0", Offset = "0x61764A0", VA = "0x1861770A0")]
		get
		{
			return default(AOFOHGHCAIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public MOHLMHCIFIA GIPJMOODOAL
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x61769A0", Offset = "0x6175DA0", VA = "0x1861769A0")]
		get
		{
			return default(MOHLMHCIFIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public OJGEFPMKAAH BLNABIPFJBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6176A10", Offset = "0x6175E10", VA = "0x186176A10")]
		get
		{
			return default(OJGEFPMKAAH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6176D20", Offset = "0x6176120", VA = "0x186176D20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public BGGEFIEDCNC EGILJJMFIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6176BD0", Offset = "0x6175FD0", VA = "0x186176BD0")]
		get
		{
			return default(BGGEFIEDCNC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6177160", Offset = "0x6176560", VA = "0x186177160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public float PNKIMIPPNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6176AE0", Offset = "0x6175EE0", VA = "0x186176AE0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6176C30", Offset = "0x6176030", VA = "0x186176C30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 AAPPKDJMGBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x6176E70", Offset = "0x6176270", VA = "0x186176E70")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6176EF0", Offset = "0x61762F0", VA = "0x186176EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public float LDCDCKDIPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6177030", Offset = "0x6176430", VA = "0x186177030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public EHGOBIJGDME.LPPDOANOCNF BCNDJHHMEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x6176F70", Offset = "0x6176370", VA = "0x186176F70")]
		get
		{
			return default(EHGOBIJGDME.LPPDOANOCNF);
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6176A70", Offset = "0x6175E70", VA = "0x186176A70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060")]
	public MKFOBKHKHDC(FNONGLLGKNI KKLABGAMOPP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x616BB90", Offset = "0x616AF90", VA = "0x18616BB90")]
	public static bool JPANIEAALPM(MKFOBKHKHDC ANJCCKHBJJO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6171490", Offset = "0x6170890", VA = "0x186171490")]
	public static bool AEMEGLCBHEE(MKFOBKHKHDC KHCOFGFJDMP, MKFOBKHKHDC NFAPJGNODPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6176B40", Offset = "0x6175F40", VA = "0x186176B40", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "4")]
	public bool Equals(MKFOBKHKHDC KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x616A140", Offset = "0x6169540", VA = "0x18616A140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6176D90", Offset = "0x6176190", VA = "0x186176D90")]
	public CCHDCFKIGFD ILLLHHAIGML()
	{
		return default(CCHDCFKIGFD);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6176CA0", Offset = "0x61760A0", VA = "0x186176CA0")]
	public MDKPHFLODKL HILEADEKMIG()
	{
		return default(MDKPHFLODKL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct CCHDCFKIGFD : IEquatable<CCHDCFKIGFD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public FNONGLLGKNI KFCEIPDGLIM
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(FNONGLLGKNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public PLEIFDIMDAG CGKIHHOMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public MKFOBKHKHDC PKOCGOCPKCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(MKFOBKHKHDC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private KDGHIKPCAGN AKPCIFPLLCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x616D990", Offset = "0x616CD90", VA = "0x18616D990")]
		get
		{
			return default(KDGHIKPCAGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public JGGHLKICFJK HJFLJKIPPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x616DA80", Offset = "0x616CE80", VA = "0x18616DA80")]
		get
		{
			return default(JGGHLKICFJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060")]
	public CCHDCFKIGFD(FNONGLLGKNI KKLABGAMOPP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x616BB90", Offset = "0x616AF90", VA = "0x18616BB90")]
	public static bool JPANIEAALPM(CCHDCFKIGFD ANJCCKHBJJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x616D9F0", Offset = "0x616CDF0", VA = "0x18616D9F0", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "4")]
	public bool Equals(CCHDCFKIGFD KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x616A140", Offset = "0x6169540", VA = "0x18616A140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public readonly struct MDKPHFLODKL : IEquatable<MDKPHFLODKL>
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly MDKPHFLODKL JGKJOMMEPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public FNONGLLGKNI KFCEIPDGLIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(FNONGLLGKNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public PLEIFDIMDAG CGKIHHOMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public CMFAFOIMJFG ODAEKBBDPFC
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(CMFAFOIMJFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	private PJGGPMIHDNH NIOANIAOFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x616BC40", Offset = "0x616B040", VA = "0x18616BC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private IBEAMCOGAPL NIHNDEIKMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x6176910", Offset = "0x6175D10", VA = "0x186176910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private JOGEJDIDHKN GFGIOLJJDON
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x6176600", Offset = "0x6175A00", VA = "0x186176600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public MKFOBKHKHDC PKOCGOCPKCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(MKFOBKHKHDC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public GPHGMGDDHEA GEPJFGFJENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x61763C0", Offset = "0x61757C0", VA = "0x1861763C0")]
		get
		{
			return default(GPHGMGDDHEA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x6175E40", Offset = "0x6175240", VA = "0x186175E40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public IEnumerable<PPPAIJOOJDP> NMMFMBPJJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x6175FF0", Offset = "0x61753F0", VA = "0x186175FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public PPPAIJOOJDP LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x6175CA0", Offset = "0x61750A0", VA = "0x186175CA0")]
		get
		{
			return default(PPPAIJOOJDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x6176880", Offset = "0x6175C80", VA = "0x186176880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060")]
	public MDKPHFLODKL(FNONGLLGKNI KKLABGAMOPP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x616BB90", Offset = "0x616AF90", VA = "0x18616BB90")]
	public static bool JPANIEAALPM(MDKPHFLODKL ANJCCKHBJJO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x61763B0", Offset = "0x61757B0", VA = "0x1861763B0")]
	public static bool HOHCACPHFGD(MDKPHFLODKL KHCOFGFJDMP, MDKPHFLODKL NFAPJGNODPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x6175F60", Offset = "0x6175360", VA = "0x186175F60", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "4")]
	public bool Equals(MDKPHFLODKL KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x616A140", Offset = "0x6169540", VA = "0x18616A140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6176660", Offset = "0x6175A60", VA = "0x186176660")]
	public PPPAIJOOJDP LKBFLCPJNNK(float3? BEBKKMFGLCG, [Optional] quaternion? IKFFGJBHBIC, [Optional] Vector3? LFBOEHOBPJC)
	{
		return default(PPPAIJOOJDP);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6176180", Offset = "0x6175580", VA = "0x186176180")]
	public PPPAIJOOJDP HMFLAEKIEJM(int AHDNEIKOMIB, float3? BEBKKMFGLCG, [Optional] quaternion? IKFFGJBHBIC, [Optional] Vector3? LFBOEHOBPJC)
	{
		return default(PPPAIJOOJDP);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x61764F0", Offset = "0x61758F0", VA = "0x1861764F0")]
	public void INHKIJFMENC(int AHDNEIKOMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6175DB0", Offset = "0x61751B0", VA = "0x186175DB0")]
	public void BILLODBOEME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct PPPAIJOOJDP : IEquatable<PPPAIJOOJDP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public FNONGLLGKNI KFCEIPDGLIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(FNONGLLGKNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public PLEIFDIMDAG CGKIHHOMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public MDKPHFLODKL APFEEAIMFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x617AD20", Offset = "0x617A120", VA = "0x18617AD20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public float3 PEDCHEEBCKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x617AA50", Offset = "0x6179E50", VA = "0x18617AA50")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x617AE10", Offset = "0x617A210", VA = "0x18617AE10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public quaternion IFBEDGFGEHN
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x617AAD0", Offset = "0x6179ED0", VA = "0x18617AAD0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x617AC40", Offset = "0x617A040", VA = "0x18617AC40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public float3 IBGFNMNJGLI
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x617A8F0", Offset = "0x6179CF0", VA = "0x18617A8F0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x617A9D0", Offset = "0x6179DD0", VA = "0x18617A9D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public LEBFLHDALFO JNPOMBEHFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x617ACB0", Offset = "0x617A0B0", VA = "0x18617ACB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private HDPIPNHLIII BNCNKGMHEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x617A970", Offset = "0x6179D70", VA = "0x18617A970")]
		get
		{
			return default(HDPIPNHLIII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	private PMKPLPNBGOM ADHAFBHIIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x617ADB0", Offset = "0x617A1B0", VA = "0x18617ADB0")]
		get
		{
			return default(PMKPLPNBGOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	private DHDKLFDFGGE BPIJAGCIFGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x617AE90", Offset = "0x617A290", VA = "0x18617AE90")]
		get
		{
			return default(DHDKLFDFGGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	private AELGKMODMCE CFOECFBELNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x617ABE0", Offset = "0x6179FE0", VA = "0x18617ABE0")]
		get
		{
			return default(AELGKMODMCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	private OCKJKAOGOKN MCMFBDGLKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x617A890", Offset = "0x6179C90", VA = "0x18617A890")]
		get
		{
			return default(OCKJKAOGOKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060")]
	public PPPAIJOOJDP(FNONGLLGKNI KKLABGAMOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x617AB50", Offset = "0x6179F50", VA = "0x18617AB50", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "4")]
	public bool Equals(PPPAIJOOJDP KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x616A140", Offset = "0x6169540", VA = "0x18616A140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x617AD20", Offset = "0x617A120", VA = "0x18617AD20")]
	public void LLPINLAMLDC(MDKPHFLODKL ANJCCKHBJJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct CMFAFOIMJFG : IEquatable<CMFAFOIMJFG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public PLEIFDIMDAG CGKIHHOMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public HGMCICPFHLP LHMFADBCBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(HGMCICPFHLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	private PJGGPMIHDNH NIOANIAOFAO
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x616BC40", Offset = "0x616B040", VA = "0x18616BC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	private LEDNLDAHKNG FKIBLFGFDND
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x616F880", Offset = "0x616EC80", VA = "0x18616F880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public bool OCGCGPHMKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x616E180", Offset = "0x616D580", VA = "0x18616E180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 PEDCHEEBCKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x616E910", Offset = "0x616DD10", VA = "0x18616E910")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x616FD00", Offset = "0x616F100", VA = "0x18616FD00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public Quaternion IFBEDGFGEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x616EAB0", Offset = "0x616DEB0", VA = "0x18616EAB0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x616F250", Offset = "0x616E650", VA = "0x18616F250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public Vector3 IMJAMINFNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x616FDD0", Offset = "0x616F1D0", VA = "0x18616FDD0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x616E5D0", Offset = "0x616D9D0", VA = "0x18616E5D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Quaternion OIJGDFEHDPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x616DDA0", Offset = "0x616D1A0", VA = "0x18616DDA0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x616F180", Offset = "0x616E580", VA = "0x18616F180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public float AOLGPBNKCKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x616E310", Offset = "0x616D710", VA = "0x18616E310")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x616E0D0", Offset = "0x616D4D0", VA = "0x18616E0D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float GDAJCJKIBLE
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x616EC90", Offset = "0x616E090", VA = "0x18616EC90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public Vector3 IBGFNMNJGLI
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x616DFE0", Offset = "0x616D3E0", VA = "0x18616DFE0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x616E840", Offset = "0x616DC40", VA = "0x18616E840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Vector3 FHBNMLJHELH
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x616EF10", Offset = "0x616E310", VA = "0x18616EF10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Matrix4x4 LAFHKHIBCIM
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x616F000", Offset = "0x616E400", VA = "0x18616F000")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060")]
	public CMFAFOIMJFG(FNONGLLGKNI KKLABGAMOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x616EC00", Offset = "0x616E000", VA = "0x18616EC00", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "4")]
	public bool Equals(CMFAFOIMJFG KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x616A140", Offset = "0x6169540", VA = "0x18616A140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x616F5A0", Offset = "0x616E9A0", VA = "0x18616F5A0")]
	public NKGPPJOONDJ KEBHPDPPLLC()
	{
		return default(NKGPPJOONDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x616FF90", Offset = "0x616F390", VA = "0x18616FF90")]
	public void NPHNPIIDPBN([Out] Matrix4x4 FAKNLJFMEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x616F040", Offset = "0x616E440", VA = "0x18616F040")]
	public void HEFBMNJFHCM([Out] Vector3 DGBPMNBAKHH, [Out] Quaternion HKIPMODFIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x616FC50", Offset = "0x616F050", VA = "0x18616FC50")]
	public void MJMFKABFEPB([Out] RigidTransform GBOLPDDGPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x616DFB0", Offset = "0x616D3B0", VA = "0x18616DFB0")]
	public PHCICLADBII AEFEHBJJGHJ()
	{
		return default(PHCICLADBII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x616DEF0", Offset = "0x616D2F0", VA = "0x18616DEF0")]
	public void AEFEHBJJGHJ([Out] PHCICLADBII JIHDMGJDKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x616F5F0", Offset = "0x616E9F0", VA = "0x18616F5F0")]
	public PHCICLADBII KJAHNFCPGGL()
	{
		return default(PHCICLADBII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x616F620", Offset = "0x616EA20", VA = "0x18616F620")]
	public void KJAHNFCPGGL([Out] PHCICLADBII GBOLPDDGPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x616F3C0", Offset = "0x616E7C0", VA = "0x18616F3C0")]
	public Vector3 JDGPHAFNFCN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x616E6A0", Offset = "0x616DAA0", VA = "0x18616E6A0")]
	public void DKMFDIBAPHM([In] Vector3 ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x616EE20", Offset = "0x616E220", VA = "0x18616EE20")]
	public Vector3 GFFIGHOCODE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x61700B0", Offset = "0x616F4B0", VA = "0x1861700B0")]
	public void OOEEKMDLLHC([In] Vector3 ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x616FA10", Offset = "0x616EE10", VA = "0x18616FA10")]
	public Quaternion MDJGFHBOPFK()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x616E3B0", Offset = "0x616D7B0", VA = "0x18616E3B0")]
	public void BNCOLLDFPEI([In] Quaternion ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x616E1C0", Offset = "0x616D5C0", VA = "0x18616E1C0")]
	public Quaternion BACCOJHBOAG()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x616FEC0", Offset = "0x616F2C0", VA = "0x18616FEC0")]
	public void NJFBACHECLF([In] Quaternion ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x616F320", Offset = "0x616E720", VA = "0x18616F320")]
	public float JCCIKIBJIIG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x616E480", Offset = "0x616D880", VA = "0x18616E480")]
	public void BOFIBCKCAFP(float ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x616E530", Offset = "0x616D930", VA = "0x18616E530")]
	public float CIJFJPAINFP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x616EA00", Offset = "0x616DE00", VA = "0x18616EA00")]
	public void EKPHLGOKPLN(float ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x616E770", Offset = "0x616DB70", VA = "0x18616E770")]
	public void DNMGOHCEEED([In] Vector3 ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x616F4B0", Offset = "0x616E8B0", VA = "0x18616F4B0")]
	public Vector3 KAJGKPMLNIO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x616F6E0", Offset = "0x616EAE0", VA = "0x18616F6E0")]
	public void KNPKAPHHFII([In] Vector3 ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x616FB60", Offset = "0x616EF60", VA = "0x18616FB60")]
	public Vector3 MFHPFLGJELH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x616F7B0", Offset = "0x616EBB0", VA = "0x18616F7B0")]
	public void LBAMMMJNOCI([In] Vector3 ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x616ED30", Offset = "0x616E130", VA = "0x18616ED30")]
	public Vector3 FPECECDPDPO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x616F940", Offset = "0x616ED40", VA = "0x18616F940")]
	public void LGONNNLKLIK([In] Vector3 ANJCCKHBJJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct AAFFIEDODNK : IEquatable<AAFFIEDODNK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public FNONGLLGKNI KFCEIPDGLIM
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(FNONGLLGKNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public PLEIFDIMDAG CGKIHHOMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
		get
		{
			return default(PLEIFDIMDAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public int[] MJIEEPKAOHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x6169F80", Offset = "0x6169380", VA = "0x186169F80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060")]
	public AAFFIEDODNK(FNONGLLGKNI KKLABGAMOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x616A110", Offset = "0x6169510", VA = "0x18616A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x616A070", Offset = "0x6169470", VA = "0x18616A070", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x616A100", Offset = "0x6169500", VA = "0x18616A100", Slot = "4")]
	public bool Equals(AAFFIEDODNK KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x616A140", Offset = "0x6169540", VA = "0x18616A140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class PHJANHCKHJC
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct FEIHJGIDHFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Guid LHLNCEHJAOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public HDEJECNOJKI JILEPIFCGOI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct HDEJECNOJKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int ANJCCKHBJJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int OCGJEPBHGOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int AAELINCEHGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int OJMEGOGOGMH;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6172AA0", Offset = "0x6171EA0", VA = "0x186172AA0")]
		public bool GNBONDCILEF([Out] HJCBPKJLHPC KLMFOODJGLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6172B20", Offset = "0x6171F20", VA = "0x186172B20")]
		public HDEJECNOJKI(HJCBPKJLHPC KLMFOODJGLC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6179C40", Offset = "0x6179040", VA = "0x186179C40")]
	public static Guid IPBMOAHFNLH(this HJCBPKJLHPC KLMFOODJGLC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6179CD0", Offset = "0x61790D0", VA = "0x186179CD0")]
	public static bool NCMHEDPNCKO(this Guid LHLNCEHJAOH, [Out] HJCBPKJLHPC KLMFOODJGLC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class CGFABGHAPOH
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x616DCB0", Offset = "0x616D0B0", VA = "0x18616DCB0")]
	public static IBEAMCOGAPL NIHNDEIKMHK(this FNONGLLGKNI FNOGEAGAPLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x616DAE0", Offset = "0x616CEE0", VA = "0x18616DAE0")]
	public static JOIBJAFEBEM CPBBNGJCNBF(this FNONGLLGKNI FNOGEAGAPLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x616DBB0", Offset = "0x616CFB0", VA = "0x18616DBB0")]
	public static EntityManager LHMCMOFKAOP(this FNONGLLGKNI FNOGEAGAPLC)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x24EF070", Offset = "0x24EE470", VA = "0x1824EF070")]
	public static T AGADEPOKKIP<T>(this FNONGLLGKNI FNOGEAGAPLC) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x24EFFE0", Offset = "0x24EF3E0", VA = "0x1824EFFE0")]
	public static bool ELIDIKLFOPA<T>(this FNONGLLGKNI FNOGEAGAPLC) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x24F02A0", Offset = "0x24EF6A0", VA = "0x1824F02A0")]
	public static bool KPAGEBLBEDI<T>(this FNONGLLGKNI FNOGEAGAPLC) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface GPNCCIIBJBO
{
	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NIFBBDBFDDG(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FAOGHBDCBEC(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LKPMIEBMBOO(FNONGLLGKNI KKLABGAMOPP, [Out] Guid NGLJABNBABA);

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid LFDHGCGIFGE(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JOHBCAKNIGN(FNONGLLGKNI KKLABGAMOPP, Guid NGLJABNBABA);

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BIOEKMHOFPE(FNONGLLGKNI KKLABGAMOPP, [Out] Guid MADPFKENMIG);

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid AEHBKCGNGFP(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HMPDANIFOJB(FNONGLLGKNI KKLABGAMOPP, Guid MADPFKENMIG);

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DIHLCPMIEIC(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task IHHLNPHLGBJ(FNONGLLGKNI PBEFJCLMEAP, FNONGLLGKNI EMDODFFCGEF);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DKGHNNODKMB(NKCLGJJOGJC.LoadInstance)]
public interface LIPODAAPNMA
{
	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	Guid MFOENJNILEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IBJMMGMFMCF(NativeList<Guid> LNJNNGKILDH, NativeList<Guid> FENLIFLFKJK, NativeList<FixedString64Bytes> PGBHGKKFCPD);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface GHIANNFGJHH
{
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DHJACIGLOOC(List<FNONGLLGKNI> FAMHOPCNFHI);

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OLCEFJNGPDB(FNONGLLGKNI HBHEEJPNNOO);

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KGFOEENIJAO(FNONGLLGKNI HBHEEJPNNOO);

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FNONGLLGKNI DDNLMNDAIFC(FNONGLLGKNI BGAGBHOEEFI);

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JLDMIMIPIHI(FNONGLLGKNI BGAGBHOEEFI, FNONGLLGKNI KALHFINPHCE);

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OPFONEOAHDC(FNONGLLGKNI BGAGBHOEEFI);

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FBGFGKAPLCO(FNONGLLGKNI CMIPJIFIMCO);

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FOLDOFEJADH(FNONGLLGKNI KKLABGAMOPP, bool FFMHAAMBKND);

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DJGMABNKAMN(FNONGLLGKNI[] LKLMPHAAIMO, bool FFMHAAMBKND);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface CACPONBEAJI
{
	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	IReadOnlyCollection<PEPLKLBPNAK> ELKOJPELCCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EIEBLDCJBCH(int MFEIPIKIEAE, [Out] PEPLKLBPNAK AILKMOHODBL);

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PEPLKLBPNAK BIMABMAHDCK(Type FICJMFBEBIN);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class ACBHHPIEJPH
{
	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x2CE0270", Offset = "0x2CDF670", VA = "0x182CE0270")]
	public static T ICBDCDNKIIB<T>(this CACPONBEAJI JAOCBDDBJFH, Entity JPDMAMIIECO) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF6A0", Offset = "0x2CDEAA0", VA = "0x182CDF6A0")]
	public static PEPLKLBPNAK BIMABMAHDCK<T>(this CACPONBEAJI JAOCBDDBJFH) where T : struct, IComponent
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface FIOJCOPJENG
{
	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HJCBPKJLHPC[] LHGJAPIBPHP(string GFBABMFGHOJ, PLEIFDIMDAG PKAMMDKGKCE, bool BPGDDFHAAHF = false);

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PPLMJMFPNLO(string FBLBKEHCCCC, HJCBPKJLHPC[] PBCPOGJBFBN);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[DKGHNNODKMB(NKCLGJJOGJC.LoadInstance)]
public interface IGENMOGNKOM
{
	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<FNONGLLGKNI, FNONGLLGKNI> NLAJDAAHPJP;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<FNONGLLGKNI, FNONGLLGKNI> JJJIPKKKKML;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<FNONGLLGKNI, FNONGLLGKNI, FNONGLLGKNI> NKDHJJNDCDN;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<FNONGLLGKNI> NIGBEDPEDNJ;

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OPBBAPHBHHL(FNONGLLGKNI KKLABGAMOPP, FNONGLLGKNI KGDEKIEJOEO);

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FNONGLLGKNI KNNKEADBKIN(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<FNONGLLGKNI> NKPIGKEOBFE(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FNONGLLGKNI IEEFBKMNDEN(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PLLHDOJFKKL(FNONGLLGKNI KKLABGAMOPP, Vector3 CPJLFJBDJGE, Quaternion FCFOFOOLACD);

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LMABCOPCPBA(FNONGLLGKNI KKLABGAMOPP, float EIGJFJNPCGJ);

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool GEJEACBLICO(FNONGLLGKNI KKLABGAMOPP, [Out] RigidTransform PLMODDBKBLL);

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool ACNELIKLJGD(FNONGLLGKNI KKLABGAMOPP, [Out] float FOHFPGGDJAM);

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 INNDMOBMIPN(IILPDAHBFFI AEGADGBFHKO);

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion EJHOHMFAEMD(IILPDAHBFFI AEGADGBFHKO);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class NOPCAOFBPIN
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[DKGHNNODKMB(NKCLGJJOGJC.LoadInstance)]
public interface EDKOGJDMEGM
{
	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	object LJMNDABAJKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GDJCHMDEJED(NKDFDPPNGFC LKLMPHAAIMO);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum PLGOGLDHCMJ
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class NPDIPLIHIKP
{
	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0xB5E2A0", Offset = "0xB5D6A0", VA = "0x180B5E2A0")]
	public static bool JLCGMNOLKKJ(this PLGOGLDHCMJ DMBLKCJLHHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0xB5E190", Offset = "0xB5D590", VA = "0x180B5E190")]
	public static bool COJONNPPFMN(this PLGOGLDHCMJ DMBLKCJLHHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2198270", Offset = "0x2197670", VA = "0x182198270")]
	public static bool GJIPKHMNFIO(this PLGOGLDHCMJ DMBLKCJLHHH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public enum MFBOFAEKEPJ
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
public static class BDHEJJPPGKF
{
	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0xBFD9F0", Offset = "0xBFCDF0", VA = "0x180BFD9F0")]
	public static int GKNEGECMEJP(this MFBOFAEKEPJ ANJCCKHBJJO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface FDDGCLLGBGB
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface CBCJBIKHIKA
{
	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	PLGOGLDHCMJ KKMHMEFJIKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	PLGOGLDHCMJ JDOIJDDAALD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	PLGOGLDHCMJ IDKMHHLNFJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	PLGOGLDHCMJ PEJOGFDJNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	PLGOGLDHCMJ PKMBFOAFGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	PLGOGLDHCMJ OOFNHCCPIFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	PLGOGLDHCMJ OFJJEBLFKLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	PLGOGLDHCMJ OLLNBFMCFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	PLGOGLDHCMJ KEPKHJFCMEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	PLGOGLDHCMJ FHGJHGCPNIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	PLGOGLDHCMJ AGJGOHIIPLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	PLGOGLDHCMJ JCKLKPLPONO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	PLGOGLDHCMJ EGECNPHAMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface BDAIBKCOJKP
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<BCPLPKEILJC> ACILPJOBBEN;

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FNONGLLGKNI BIAFFCJKDJO(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HPDBBAFGCBD(List<FNONGLLGKNI> FAMHOPCNFHI);

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FNONGLLGKNI KOBPKOONGJA(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IPJNFPFPNEM(FNONGLLGKNI KKLABGAMOPP, FNONGLLGKNI EMDODFFCGEF, bool ANNNFPPNMGG);

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool AHMADENNNPK(FNONGLLGKNI KKLABGAMOPP, FNONGLLGKNI EMDODFFCGEF);

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int BKLFJDNEAKP(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NKDFDPPNGFC BCLCNKKDCDE(FNONGLLGKNI CMIPJIFIMCO);

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<FNONGLLGKNI> JEAOFJCIHAE(FNONGLLGKNI CMIPJIFIMCO);

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FPDDDNEAOGM(FNONGLLGKNI KKLABGAMOPP, FNONGLLGKNI GPNMLHJGGKB);

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NKBPKGMMCKJ(FNONGLLGKNI KKLABGAMOPP, FNONGLLGKNI KONKEKDJKDB);

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	FNONGLLGKNI MNFDGBHGPHM(FNONGLLGKNI JILDGEDOLHB, FNONGLLGKNI BILEBAJDDMN);

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool CDBKGLKCKHL(FNONGLLGKNI JILDGEDOLHB, FNONGLLGKNI BILEBAJDDMN, [Out] FNONGLLGKNI NKKJBJNMCDG);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class BOLJMLBPMIG
{
	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x616D400", Offset = "0x616C800", VA = "0x18616D400")]
	public static List<FNONGLLGKNI> HPDBBAFGCBD(this BDAIBKCOJKP AANFIOBCLIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DKGHNNODKMB(NKCLGJJOGJC.LoadInstance)]
public interface CIEGEFCJOPK
{
	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	bool NALLHGBCKCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	bool GPKNNAFMLIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface NHDLDDMILMN : LKBLGBEDCCF
{
	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MBNGDMFOAHI(Entity JPDMAMIIECO, [Out] NCJGPOICADL PPOPFLAHPIC);

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FBHKOELGKLO(NativeArray<NCJGPOICADL> HPJNFECJPHL, NativeArray<PFJBAMHBMBN> FEBMGBNBBPI);

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ABGNBCGMJNH(NCJGPOICADL PPOPFLAHPIC);

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IHPABINKKNE(NCJGPOICADL PPOPFLAHPIC, [Out] Collider AILIANBMFFG);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[DKGHNNODKMB(NKCLGJJOGJC.LoadInstance)]
public interface LKBLGBEDCCF
{
	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HOHNAIAECPB([In] float3 KMMPCLIFELN, [In] float3 PNADBCDBNOL, float FIOIECEGGAH, Allocator OLAJGHFDGHM, [Out] NativeArray<Entity> KMGEJEMFJBE);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[DKGHNNODKMB(NKCLGJJOGJC.LoadInstance)]
public interface LAOLJMFJDJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HOHNAIAECPB([In] float3 KMMPCLIFELN, [In] float3 PNADBCDBNOL, float FIOIECEGGAH, [Out] AIMLHCLKLCO PGLGOCKLPKH, [Out] FNONGLLGKNI HKJODEDAPCK);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[DKGHNNODKMB(NKCLGJJOGJC.LoadInstance)]
public interface FAIMJBDNNNC
{
	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HOHNAIAECPB([In] NativeArray<Entity> KMGEJEMFJBE, [In] float3 KMMPCLIFELN, [In] float3 PNADBCDBNOL, [In] NativeArray<AIMLHCLKLCO> DODOKCHEIBE);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct NCJGPOICADL : DAFDIAIBHKC, IEquatable<NCJGPOICADL>
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public int BLAEHDOLMPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x88D230", Offset = "0x88C630", VA = "0x18088D230", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x88D240", Offset = "0x88C640", VA = "0x18088D240", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public int IGAANOGKMJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x21AF6D0", Offset = "0x21AEAD0", VA = "0x1821AF6D0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x550F1E0", Offset = "0x550E5E0", VA = "0x18550F1E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x61779A0", Offset = "0x6176DA0", VA = "0x1861779A0", Slot = "8")]
	public bool Equals(NCJGPOICADL KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x61779F0", Offset = "0x6176DF0", VA = "0x1861779F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct AIMLHCLKLCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float ECGFGADGAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float3 PKPPJECMOIC;
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface PNCNNJIHGAG
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface PJGGPMIHDNH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	IBEAMCOGAPL NIHNDEIKMHK
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	NFJNLPGNNDE MNAIPDFKAPA
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<NKDFDPPNGFC, NativeArray<GLDOCFALIAD>> GFKJHPHKAAN;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<NKDFDPPNGFC> LLCIHIBGKJA;

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CPHIGBBODAJ JIKMEJJMJNA(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GLDOCFALIAD PPEDLEODJHH(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NLKKEGKJEDJ(HJCBPKJLHPC KLMFOODJGLC, EABJBIEJJPB FLHPNPKFFLJ);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BLEIJLKJAHJ(HJCBPKJLHPC[] PBCPOGJBFBN, GameObject ILLDLCGIGNA);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(Slot = "10")]
	PLEIFDIMDAG PLJJBNJMADP(FNONGLLGKNI KKLABGAMOPP, [Optional] object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FIKBDFFMBNN(FNONGLLGKNI KKLABGAMOPP, [Out] EABJBIEJJPB FLHPNPKFFLJ);

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool PGDFIJEOMHL(FNONGLLGKNI KKLABGAMOPP, [Out] Transform NPBNAACKOLN);

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool JGOCMMKBBDN(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LHOFCKJDBGA(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool IGOADJGKMMD(LocalId KKLABGAMOPP, object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool BMKKBMKMEJD(LocalId KKLABGAMOPP, object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	FNONGLLGKNI JKKBNNKJGDC(HJCBPKJLHPC KLMFOODJGLC);

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool DKNPIPJPMLN(HJCBPKJLHPC KLMFOODJGLC, [Out] FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	HJCBPKJLHPC CNKGNBEFLAF(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	NKDFDPPNGFC JKKBNNKJGDC(NativeArray<HJCBPKJLHPC> KLMFOODJGLC, Allocator OLAJGHFDGHM);

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	NKDFDPPNGFC NFAPGCPKKJJ(GLDOCFALIAD APPOBJLFBKD, int CBPPKGAPPDD, Allocator OLAJGHFDGHM);

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(Slot = "22")]
	NKDFDPPNGFC POKKNPJNAGL(NativeArray<HJCBPKJLHPC> KLMFOODJGLC, NativeArray<IPJOENJPJJE> IOGHFFGADHJ, Allocator OLAJGHFDGHM);

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(Slot = "23")]
	HJCBPKJLHPC[] LHGJAPIBPHP(string FBLBKEHCCCC, PLEIFDIMDAG PKAMMDKGKCE, bool BPGDDFHAAHF);

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void PPLMJMFPNLO(string FBLBKEHCCCC, HJCBPKJLHPC[] PBCPOGJBFBN);

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "25")]
	PLEIFDIMDAG CAGPIAFFFOG(GLDOCFALIAD APPOBJLFBKD, bool HAEMHMLNIEC);

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "26")]
	PLEIFDIMDAG CAGPIAFFFOG(GLDOCFALIAD APPOBJLFBKD);

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "27")]
	PLEIFDIMDAG PHMMAFAODAG(GLDOCFALIAD APPOBJLFBKD);

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(Slot = "28")]
	PLEIFDIMDAG CNBGLKHFPHG(GLDOCFALIAD APPOBJLFBKD);

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(Slot = "29")]
	PLEIFDIMDAG POKKNPJNAGL(HJCBPKJLHPC KLMFOODJGLC, GLDOCFALIAD APPOBJLFBKD);

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(Slot = "30")]
	KDBHPJJIIHH LNKDLMELDKC();

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(Slot = "31")]
	MDKPHFLODKL LEKHJNAPPAH();

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(Slot = "32")]
	CCHDCFKIGFD ADPNFBOIHAD(JGGHLKICFJK FEFLJJOCBOE);

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void FOLNLKAHFII(NKDFDPPNGFC LKLMPHAAIMO);

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void HJKKNDHGMPB(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void CIJGIEJCMBJ(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void FOLNLKAHFII(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(Slot = "37")]
	NKDFDPPNGFC HPDMOECDPGA(NKDFDPPNGFC MEBMECIMCCH, Allocator OLAJGHFDGHM);

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool HMCLEKMJLHA(FNONGLLGKNI KKLABGAMOPP);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public static class MLNAJCAPIJA
{
	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x6177770", Offset = "0x6176B70", VA = "0x186177770")]
	public static void LHOFCKJDBGA(this PJGGPMIHDNH LCOFKHKJALF, EABJBIEJJPB FLHPNPKFFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x6177740", Offset = "0x6176B40", VA = "0x186177740")]
	public static PLEIFDIMDAG JKJDNCKDLLM(this PJGGPMIHDNH LCOFKHKJALF, LocalId KKLABGAMOPP)
	{
		return default(PLEIFDIMDAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x61776E0", Offset = "0x6176AE0", VA = "0x1861776E0")]
	public static PLEIFDIMDAG JKJDNCKDLLM(this PJGGPMIHDNH LCOFKHKJALF, HJCBPKJLHPC KLMFOODJGLC)
	{
		return default(PLEIFDIMDAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x6177740", Offset = "0x6176B40", VA = "0x186177740")]
	public static FNONGLLGKNI JKKBNNKJGDC(this PJGGPMIHDNH LCOFKHKJALF, LocalId KKLABGAMOPP)
	{
		return default(FNONGLLGKNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x61773F0", Offset = "0x61767F0", VA = "0x1861773F0")]
	public static HJCBPKJLHPC CNKGNBEFLAF(this PJGGPMIHDNH LCOFKHKJALF, LocalId KKLABGAMOPP)
	{
		return default(HJCBPKJLHPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x6177570", Offset = "0x6176970", VA = "0x186177570")]
	public static bool HMCLEKMJLHA(this PJGGPMIHDNH LCOFKHKJALF, HJCBPKJLHPC KLMFOODJGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x27568E0", Offset = "0x2755CE0", VA = "0x1827568E0")]
	public static T IHGEGCJOLLG<T>(this PJGGPMIHDNH LCOFKHKJALF, LocalId KKLABGAMOPP) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x61775E0", Offset = "0x61769E0", VA = "0x1861775E0")]
	public static KDBHPJJIIHH IEPJOMFBNLA(this PJGGPMIHDNH LCOFKHKJALF, RigidTransform JIHDMGJDKFM, [Optional] object BDHKJODLPCL)
	{
		return default(KDBHPJJIIHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x61777F0", Offset = "0x6176BF0", VA = "0x1861777F0")]
	public static CCHDCFKIGFD NNHLKNEIPJJ(this PJGGPMIHDNH LCOFKHKJALF, JGGHLKICFJK GCLPELPNPBI, RigidTransform JIHDMGJDKFM, [Optional] object BDHKJODLPCL)
	{
		return default(CCHDCFKIGFD);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x6177470", Offset = "0x6176870", VA = "0x186177470")]
	public static MDKPHFLODKL DCIDMHCBCFA(this PJGGPMIHDNH LCOFKHKJALF, RigidTransform JIHDMGJDKFM, [Optional] object BDHKJODLPCL)
	{
		return default(MDKPHFLODKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x61771D0", Offset = "0x61765D0", VA = "0x1861771D0")]
	private static void CFFHBOBCGCL(PLEIFDIMDAG NKDONLAAHLF, RigidTransform JIHDMGJDKFM, [Optional] object BDHKJODLPCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[DKGHNNODKMB(NKCLGJJOGJC.LoadInstance)]
public interface JBPFLEGOCOA
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	bool JHFBAEOPAHI
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	FNONGLLGKNI JIFNPDIBNCG
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	PLEIFDIMDAG FPLKKFNPNCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event CDCHBDDLFEP KMGBCECHBDI;

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FNONGLLGKNI MNFDGBHGPHM(FNONGLLGKNI JILDGEDOLHB, FNONGLLGKNI BILEBAJDDMN);

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CDBKGLKCKHL(FNONGLLGKNI JILDGEDOLHB, FNONGLLGKNI BILEBAJDDMN, [Out] FNONGLLGKNI NKKJBJNMCDG);

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PMCPAFBCFAG();

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AONOEDNMNAP();

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool PPKMANGEKON(FNONGLLGKNI JILDGEDOLHB);

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool HHPNNAKFCKB(FNONGLLGKNI JILDGEDOLHB);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public delegate void CDCHBDDLFEP(PLEIFDIMDAG GDCADBOOLDH, PLEIFDIMDAG PLLJKOEOPJK);
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class GEEEJGCEIBG
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x6171D60", Offset = "0x6171160", VA = "0x186171D60")]
	public static bool KKFNEEAAIHF(this JBPFLEGOCOA HOAJOLHEMAG, FNONGLLGKNI JILDGEDOLHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6171E40", Offset = "0x6171240", VA = "0x186171E40")]
	public static bool OBNKLAKECJK(this JBPFLEGOCOA HOAJOLHEMAG, FNONGLLGKNI JILDGEDOLHB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface BJAPFEILNCE
{
	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FGIJLMJHOAG(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MELCCGEDFPO(FNONGLLGKNI KKLABGAMOPP, Transform NPBNAACKOLN);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface LGECPKFCJMH
{
	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PAJENKBEFBI(FNONGLLGKNI JILDGEDOLHB, FNONGLLGKNI ICHKLHFLBEC, FNONGLLGKNI HFELCKCMCCC);

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FNONGLLGKNI DIJGKMJBBNI(FNONGLLGKNI JILDGEDOLHB);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[DKGHNNODKMB(NKCLGJJOGJC.LoadInstance)]
public interface GGNMPEEIGMH
{
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBJFNPFGDMA(FNONGLLGKNI CMIPJIFIMCO, bool ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OHCFLLPNHPG(FNONGLLGKNI CMIPJIFIMCO, bool ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AGBFKADKOIE(FNONGLLGKNI CMIPJIFIMCO, int ANJCCKHBJJO);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[DKGHNNODKMB(NKCLGJJOGJC.LoadInstance)]
public interface JOGEJDIDHKN
{
	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<FNONGLLGKNI> NDOLJOOLHCH(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FNONGLLGKNI FDOBLCGBHFP(FNONGLLGKNI KKLABGAMOPP, int AHDNEIKOMIB);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int BBKNGBHKMPL(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GPHGMGDDHEA EEJGMLOBHAC(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DFHDGHJGDFB(FNONGLLGKNI KKLABGAMOPP, GPHGMGDDHEA HKMEMMHNFBF);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FNONGLLGKNI JNBJAHMJENG(FNONGLLGKNI KKLABGAMOPP, [Optional] float3? BEBKKMFGLCG, [Optional] quaternion? IKFFGJBHBIC, [Optional] float3? LFBOEHOBPJC);

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FNONGLLGKNI AECEAAKAIHE(FNONGLLGKNI KKLABGAMOPP, int AHDNEIKOMIB, [Optional] float3? BEBKKMFGLCG, [Optional] quaternion? IKFFGJBHBIC, [Optional] float3? LFBOEHOBPJC);

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EJCDGLBHAOL(FNONGLLGKNI KKLABGAMOPP, int AHDNEIKOMIB);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OBOIJCMOGEE(FNONGLLGKNI KKLABGAMOPP);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface MLLHJGOJNME
{
	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ICBILCADHGI();

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAICGBHEMHF();

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FJGHKHDFIHL();

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NHLEALGFKPC();

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JOEIBOJKAKE();

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PDHHAFABBBE();

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MMOCHIMGDHJ();

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DMGLNAGAHPF();

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BPMDGJFIJFC();

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PNMJLMEMPNC();

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KAIPBJJHGOJ();
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface LEDNLDAHKNG
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGGEFIJEDOG(Entity JPDMAMIIECO);

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKMFDIBAPHM(Entity JPDMAMIIECO, [In] float3 ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 JDGPHAFNFCN(Entity JPDMAMIIECO);

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BNCOLLDFPEI(Entity JPDMAMIIECO, [In] quaternion ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion MDJGFHBOPFK(Entity JPDMAMIIECO);

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HEFBMNJFHCM(Entity JPDMAMIIECO, [Out] float3 BEBKKMFGLCG, [Out] quaternion IKFFGJBHBIC);

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HEFBMNJFHCM(Entity JPDMAMIIECO, [Out] RigidTransform NKFPICCPEJK);

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MJMFKABFEPB(Entity JPDMAMIIECO, [Out] RigidTransform NKFPICCPEJK);

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 PDKBMKBMGCN(Entity JPDMAMIIECO);

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DNMGOHCEEED(Entity JPDMAMIIECO, [In] float3 ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BOFIBCKCAFP(Entity JPDMAMIIECO, float ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float JCCIKIBJIIG(Entity JPDMAMIIECO);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LBAMMMJNOCI(Entity JPDMAMIIECO, [In] float3 ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 MFHPFLGJELH(Entity JPDMAMIIECO);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OOEEKMDLLHC(Entity JPDMAMIIECO, [In] float3 ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 GFFIGHOCODE(Entity JPDMAMIIECO);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NJFBACHECLF(Entity JPDMAMIIECO, [In] quaternion ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion BACCOJHBOAG(Entity JPDMAMIIECO);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 KAJGKPMLNIO(Entity JPDMAMIIECO);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void KNPKAPHHFII(Entity JPDMAMIIECO, [In] float3 ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void EKPHLGOKPLN(Entity JPDMAMIIECO, float ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float CIJFJPAINFP(Entity JPDMAMIIECO);

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void LGONNNLKLIK(Entity JPDMAMIIECO, [In] float3 ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 FPECECDPDPO(Entity JPDMAMIIECO);

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DOLPCIDJCIL(Entity JPDMAMIIECO, [Out] float4x4 FAKNLJFMEDI);

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void GJCNDJJPNEC(Entity JPDMAMIIECO, [In] float4x4 FAKNLJFMEDI);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void IIMJHGJJHAD(Entity JPDMAMIIECO, [Out] float4x4 FAKNLJFMEDI);

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool PGDFIJEOMHL(Entity JPDMAMIIECO, [Out] Transform NPBNAACKOLN);

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void HGFADACIAON(Entity JPDMAMIIECO);

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FGFFLLKMKJF(Entity JPDMAMIIECO, Entity HFCHCAOEJFO, Entity FOONBHGCLLE);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class LCLJKFCBOGE
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface GPFDEENFPHB
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World OPDBMFGJNKB(string JKNMKACJNJD = "Main");

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World AIKCGCAHGOM(string JKNMKACJNJD = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World DGJDAIDHPKA(string JKNMKACJNJD = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World CIGFBDEFAKO(string JKNMKACJNJD = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface JOIBJAFEBEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000135")]
	World EDCLJAPJPNF
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	World FBPMCBBALOG
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	EntityManager LHMCMOFKAOP
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	bool FMCKFONPAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase LAHCDGCCKFH(Type FICJMFBEBIN);
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class OJDLHPMJEBA
{
	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x61796C0", Offset = "0x6178AC0", VA = "0x1861796C0")]
	public static ComponentSystemBase NMLFPGFLFAL(this World MPJNGJLMHCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x27E21C0", Offset = "0x27E15C0", VA = "0x1827E21C0")]
	public static T LAHCDGCCKFH<T>(this JOIBJAFEBEM LOCIOGNKLEF) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[DKGHNNODKMB(NKCLGJJOGJC.LoadInstance)]
public interface EAKPGAHLNME
{
	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BJKCAKEDDOD(NativeListAsync<Entity> JDBBKBPLDBM);

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NKDDIKMEGHF(PKEONHGMECA EDCPLLCCAPH);

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JKNCNBBPHGD(NativeListAsync<Entity> CGGGMGGMJHI, bool LACEMIJHNDA);

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KAEKJCCJBGC();
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[DKGHNNODKMB(NKCLGJJOGJC.LoadInstance)]
public interface LNHBMHNCNAM
{
	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BHNKJEAADHJ(FNONGLLGKNI KKLABGAMOPP, [Out] Collider AILIANBMFFG);

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject JPHFAFJIPLO(FNONGLLGKNI HKBMGGMGIOE, GameObject GIMBJDMJFNN, Vector3 IPLJDJCHMDC, Quaternion BHCBAPBJJED);

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KCJLHEBGHFL(GameObject AILIANBMFFG);

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider LMDAKEAGGNB<TCollider>(GameObject HOPMPOANKCC) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LDAADKFKHGD(Collider AILIANBMFFG);

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject MBFFGHEKOID<TCollider>(string GFBABMFGHOJ) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[DKGHNNODKMB(NKCLGJJOGJC.LoadInstance)]
public interface FDDINPNDFCA
{
	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AODDFJELEKH(FNONGLLGKNI KKLABGAMOPP, OBAOFNGLGAB DEBBKMAMIAM, bool AMKFLCNFGFN, IHKKOAMIJFG HLEHJJOCNAN);

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FOGFHLEPABE(FNONGLLGKNI KKLABGAMOPP, OBAOFNGLGAB DEBBKMAMIAM, bool AMKFLCNFGFN, bool MKOPIDPHAFP, bool MMLJKPHOLMH);

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PEJKEFFMFHE FIFPAFDHDDN(FNONGLLGKNI DHHBNGOGOPD, List<FNONGLLGKNI> JHBCOLCEKLH);

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BINBEABCGGM(GameObject JPBNNCFDNAI, GameObject MHHCGNINIHG);

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AANLINLCEFM(GameObject MHHCGNINIHG);

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T LMDAKEAGGNB<T>(GameObject HOPMPOANKCC) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LDAADKFKHGD(Collider AILIANBMFFG);

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject OJOJCHLCMBL<T>(string GFBABMFGHOJ) where T : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DKGHNNODKMB(NKCLGJJOGJC.LoadInstance)]
public interface MNHOJKKMHCG
{
	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JABOJPCHLHA(FNONGLLGKNI KKLABGAMOPP, FNEPNDPKACM ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FNEPNDPKACM EKJBBKHEIMA(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CBNJEMBLCPC(FNONGLLGKNI KKLABGAMOPP, FNONGLLGKNI ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IALHOMHICOG(FNONGLLGKNI KKLABGAMOPP, FNONGLLGKNI ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int BKLFJDNEAKP(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FNONGLLGKNI APMNNJDCPBE(FNONGLLGKNI KKLABGAMOPP, int AHDNEIKOMIB);

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EDPHMOFCHLI(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FJKDDDFFGID(FNONGLLGKNI KKLABGAMOPP, object BDHKJODLPCL, FNONGLLGKNI ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CFPODBBGKKM(FNONGLLGKNI KKLABGAMOPP, object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool DMIBMGKHLEA(FNONGLLGKNI KKLABGAMOPP, [Out] FNONGLLGKNI ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PAFGFOLEAAL(FNONGLLGKNI KKLABGAMOPP, float3 ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ELLDHDLFJIE(FNONGLLGKNI KKLABGAMOPP, [Out] float3 ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EGGJBNLALBE(FNONGLLGKNI KKLABGAMOPP, float3 ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool DDNGMNIAECB(FNONGLLGKNI KKLABGAMOPP, [Out] float3 ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KPAJLCPLECN(FNONGLLGKNI KKLABGAMOPP, (Quaternion rot, Vector3 moments) EELLIIPGCJG);

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool AEMFPOOACLC(FNONGLLGKNI KKLABGAMOPP, [Out] quaternion PDMDMCJFOIG, [Out] float3 PEHHJBPLNPL);

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OLEMAIHKECF(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LNPDKKPCOCD(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 JCDIAPIGAEL(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 DLNMFNGFFCG(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void JFJMBHLBLPD(FNONGLLGKNI KKLABGAMOPP, float3 ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IJANCIKMOIA(FNONGLLGKNI KKLABGAMOPP, float3 ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float DFNENMPLIEI(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float ONHCGHMAILB(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void ALCPMLGJMCJ(FNONGLLGKNI KKLABGAMOPP, float ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void PJKKGHABFHP(FNONGLLGKNI KKLABGAMOPP, float ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CollisionDetectionMode ODOMBDGNFJK(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void HPGFHKBJHGF(FNONGLLGKNI KKLABGAMOPP, CollisionDetectionMode ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	GOOCPGCLLJK FDJHBJCFKIB(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void KHFPPGGNFMJ(FNONGLLGKNI KKLABGAMOPP, GOOCPGCLLJK ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool HHGLKANKDMM(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void LHDKMPMCCKI(FNONGLLGKNI KKLABGAMOPP, bool ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	FNONGLLGKNI BIAFFCJKDJO(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void FHJDEHJPPBB(FNONGLLGKNI KKLABGAMOPP, FNONGLLGKNI ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	FNONGLLGKNI KOBPKOONGJA(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void IPJNFPFPNEM(FNONGLLGKNI KKLABGAMOPP, FNONGLLGKNI ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	PKGDKKKFHAD LEFHNLCFKHO(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void BKMGHNOIION(FNONGLLGKNI KKLABGAMOPP, PKGDKKKFHAD DEAMFKGMENA);

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool NKDFNBGBJGF(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void OEOLFIBNICC(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool IACLPHFBJCL(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void GBFEPNBCNCF(FNONGLLGKNI KKLABGAMOPP, bool ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool JIJGHOJMHHM(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void CPPMAOHIHKG(FNONGLLGKNI KKLABGAMOPP, bool ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "44")]
	RigidbodyConstraints KLFPNDPCPBH(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void GGBNOICEKOA(FNONGLLGKNI KKLABGAMOPP, RigidbodyConstraints ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "46")]
	float AELLFIIJJMG(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void PJJIFHAECJB(FNONGLLGKNI KKLABGAMOPP, float ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float HHOCCKGAHMP(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void CCEHGALLFPI(FNONGLLGKNI KKLABGAMOPP, float ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool JCKLFGGLJOG(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void BODBOBPEEAI(FNONGLLGKNI KKLABGAMOPP, bool ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool PJCDEIKCPMA(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void OBEGGDKJDHC(FNONGLLGKNI KKLABGAMOPP, bool ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void CPNIDKDFCLK(FNONGLLGKNI KKLABGAMOPP, int ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "55")]
	object MAOCDPGEIIJ(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void NCNNIMEGDOK(FNONGLLGKNI KKLABGAMOPP, object ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "57")]
	object OFGBKDBEFGJ(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void GIPHPDLCAKM(FNONGLLGKNI KKLABGAMOPP, object ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "59")]
	float DMNLDDFKMBG(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void FFCMOHMCFGD(FNONGLLGKNI KKLABGAMOPP, float ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void IDBCMAFCGJD(FNONGLLGKNI KKLABGAMOPP, object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void KKICNAEPDLP(FNONGLLGKNI KKLABGAMOPP, object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "63")]
	bool MKJPCCDDPBB(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void CIJFMIBEFJC(FNONGLLGKNI KKLABGAMOPP, object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void BDLJMJMGDMM(FNONGLLGKNI KKLABGAMOPP, object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "66")]
	bool HMELBOFCBCA(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool NBKKBJNPLAC(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Rigidbody HOIKJDCOLOB(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void PJCNFLNENOC(FNONGLLGKNI KKLABGAMOPP, Rigidbody APJBIKHBABA);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void IFAGMNAOPKH(FNONGLLGKNI KKLABGAMOPP, object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void ONPKKIOKJND(FNONGLLGKNI KKLABGAMOPP, object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool KCKHDDHFPBO(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void ABHCPIHHOOB(FNONGLLGKNI KKLABGAMOPP, float3 KDGFADJDBBB);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void KIJDCIFKDIG(FNONGLLGKNI KKLABGAMOPP, float3 HIEIGGIPFIC);

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "75")]
	bool EJLHCCHNCAJ(FNONGLLGKNI KKLABGAMOPP, [Out] float3 KDGFADJDBBB);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool KFGKIDKKGLH(FNONGLLGKNI KKLABGAMOPP, [Out] float3 HIEIGGIPFIC);

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool LBJIFIJGLFG(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void JEJKCELEPAM(FNONGLLGKNI KKLABGAMOPP, object BDHKJODLPCL, bool JEKJDJALDPH);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "79")]
	void BGKCCAKLNCF(FNONGLLGKNI KKLABGAMOPP, bool AEGMHHHLKGI);

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void DKCDKBNBKIK(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool DKEHNDCBGJK(FNONGLLGKNI KKLABGAMOPP);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DKGHNNODKMB(NKCLGJJOGJC.LoadInstance)]
public interface MCBMILBCKIF
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	bool FMCKFONPAAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNCJOPAIPEH(FNONGLLGKNI KKLABGAMOPP);

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NGGLADBIMLL(FNONGLLGKNI KKLABGAMOPP, bool AMKFLCNFGFN, bool MKOPIDPHAFP, bool JDEPFPLLMON);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KHOLBDAIFFF(FNONGLLGKNI KKLABGAMOPP, float3 BNBPPNLIKAM);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PPPNDANFPFC(FNONGLLGKNI KKLABGAMOPP, float3 BNBPPNLIKAM);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DKGHNNODKMB(NKCLGJJOGJC.LoadInstance)]
public interface BEAJDPPDHMC
{
	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEIPAGKGKDJ(Entity CENKCPOKEBE);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void COAMIINDPKO(Entity CENKCPOKEBE);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public delegate void LABBHNDNHNG(BDFICDHFNMN BOFEEJLABHJ);
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct BDFICDHFNMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly NKDFDPPNGFC ONNDBJLPNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly NativeArray<byte> BIHDJPFDCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly NativeArray<byte> MLMOJGJLJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly OPJBLBHDCME BLGMLDLMDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly int LDPDCEPMGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Type EHHLDCJKKMI;

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public NKDFDPPNGFC DLOMHDMNPGK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x3B48AC0", Offset = "0x3B47EC0", VA = "0x183B48AC0")]
		get
		{
			return default(NKDFDPPNGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x616B3E0", Offset = "0x616A7E0", VA = "0x18616B3E0")]
	public BDFICDHFNMN(NKDFDPPNGFC ONNDBJLPNOI, NativeArray<byte> BIHDJPFDCHH, NativeArray<byte> MLMOJGJLJGF, OPJBLBHDCME BLGMLDLMDIJ, int LDPDCEPMGEF, Type EHHLDCJKKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x24538F0", Offset = "0x2452CF0", VA = "0x1824538F0")]
	public NativeArray<T> JHCLGBPPMJO<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x24538B0", Offset = "0x2452CB0", VA = "0x1824538B0")]
	public NativeArray<T> GFCBNDLFFLJ<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2453930", Offset = "0x2452D30", VA = "0x182453930")]
	public (NKDFDPPNGFC, NativeArray<T>, NativeArray<T>) JJNOBLLAEFC<T>() where T : struct
	{
		return default((NKDFDPPNGFC, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x616B390", Offset = "0x616A790", VA = "0x18616B390")]
	public BCPLPKEILJC GLNOLEBGANL()
	{
		return default(BCPLPKEILJC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface PDBGIIDLLEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	string JHIFBHGDLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	PDBGIIDLLEJ FFNJFIBPAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	IEnumerable<PDBGIIDLLEJ> EBCAOFMKCJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DKGHNNODKMB(NKCLGJJOGJC.LoadInstance)]
public interface PMOAIBDMMLB
{
	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	PDBGIIDLLEJ FMFLJMNFGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	List<PNOKIMEDNFB> OELMOMOICHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PBDAHJHBEGP(PNOKIMEDNFB PLNALAIILFK, [Out] PDBGIIDLLEJ AIECLKGHHBK);

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NLKKEGKJEDJ(PNOKIMEDNFB PLNALAIILFK, LABBHNDNHNG LCILDPJHBNK);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MHIFDGFFNKK(PNOKIMEDNFB PLNALAIILFK, LABBHNDNHNG LCILDPJHBNK);
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public readonly struct BCPLPKEILJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly BDFICDHFNMN ALPLHOOHPEL;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public NKDFDPPNGFC DLOMHDMNPGK
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x3B48AC0", Offset = "0x3B47EC0", VA = "0x183B48AC0")]
		get
		{
			return default(NKDFDPPNGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x616B360", Offset = "0x616A760", VA = "0x18616B360")]
	public BCPLPKEILJC(BDFICDHFNMN ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x616B170", Offset = "0x616A570", VA = "0x18616B170")]
	public NKDFDPPNGFC JHCLGBPPMJO()
	{
		return default(NKDFDPPNGFC);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x616B0A0", Offset = "0x616A4A0", VA = "0x18616B0A0")]
	public NKDFDPPNGFC GFCBNDLFFLJ()
	{
		return default(NKDFDPPNGFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x616B240", Offset = "0x616A640", VA = "0x18616B240")]
	public (NKDFDPPNGFC, NKDFDPPNGFC, NKDFDPPNGFC) JJNOBLLAEFC()
	{
		return default((NKDFDPPNGFC, NKDFDPPNGFC, NKDFDPPNGFC));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DefaultMember("Item")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface HHLOLPHFDCA : IEnumerable<NEKAIANIFDN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000141")]
	NativeBitArray EENFOAFIEDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	NativeArray<int> MFOHDCNKGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	NEKAIANIFDN LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	NEKAIANIFDN LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NEKAIANIFDN OOFFNAPMJBI(DNGABECEBMG GHNNEBBEGEC);

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OPJBLBHDCME GMMILAPLKOH(DNGABECEBMG GHNNEBBEGEC);
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class DPANNBMEFAC
{
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
[DefaultMember("Item")]
public interface LODHNFMNNNL : IEnumerable<BHDPGAHBOKN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000146")]
	int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	BHDPGAHBOKN LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BHDPGAHBOKN OOFFNAPMJBI(DNGABECEBMG GHNNEBBEGEC);

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OPJBLBHDCME GMMILAPLKOH(DNGABECEBMG GHNNEBBEGEC);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public static class GOPAIMLGOKO
{
	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x26828E0", Offset = "0x2681CE0", VA = "0x1826828E0")]
	public static OPJBLBHDCME GMMILAPLKOH<T>(this LODHNFMNNNL LOFNNPAJGEF, ONAGJBKEBCK<T> GFBABMFGHOJ) where T : struct
	{
		return default(OPJBLBHDCME);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[DefaultMember("Item")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface OHOMLPOINDI : IEnumerable<PNOKIMEDNFB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000148")]
	int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	PNOKIMEDNFB LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PNOKIMEDNFB OOFFNAPMJBI(DNGABECEBMG GHNNEBBEGEC);

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OPJBLBHDCME GMMILAPLKOH(DNGABECEBMG GHNNEBBEGEC);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public static class JACLLNOCMIC
{
	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x26CA560", Offset = "0x26C9960", VA = "0x1826CA560")]
	public static KCKMABFBDCH<T> OOFFNAPMJBI<T>(this OHOMLPOINDI LOFNNPAJGEF, DNGABECEBMG GFBABMFGHOJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x26CA460", Offset = "0x26C9860", VA = "0x1826CA460")]
	public static OPJBLBHDCME GMMILAPLKOH<T>(this OHOMLPOINDI LOFNNPAJGEF, ONAGJBKEBCK<T> GFBABMFGHOJ) where T : struct
	{
		return default(OPJBLBHDCME);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[DKGHNNODKMB(NKCLGJJOGJC.LoadInstance)]
public interface DBGCEIOHAFF
{
	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLKKEGKJEDJ(DNGABECEBMG PLNALAIILFK, LABBHNDNHNG LCILDPJHBNK);

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MHIFDGFFNKK(DNGABECEBMG PLNALAIILFK, LABBHNDNHNG LCILDPJHBNK);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class OCANFOJPEGB
{
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface GBGOJIDKIAB
{
	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	FNCABFEGHHN CCOFHMCIBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJIDGIEJJIB(HJCBPKJLHPC KLMFOODJGLC, OPJBLBHDCME PLNALAIILFK);

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LFACBIMBKJI(HJCBPKJLHPC KLMFOODJGLC, Span<OPJBLBHDCME> LOFNNPAJGEF, bool CIIDDEKBHLC);

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HEFBBHIMLDK(NativeArray<HJCBPKJLHPC> PBCPOGJBFBN);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class BHMNKLHLFAC
{
	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x616C120", Offset = "0x616B520", VA = "0x18616C120")]
	public static void LFACBIMBKJI(this GBGOJIDKIAB LNMDBIIJIBB, HJCBPKJLHPC KLMFOODJGLC, OPJBLBHDCME PLNALAIILFK, bool CIIDDEKBHLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public readonly struct FNCABFEGHHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly NativeBitArray OECFFOENDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly NativeParallelHashMap<HJCBPKJLHPC, int> BFPCLCKHHOE;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool DPGNIFMCGBF
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x6171470", Offset = "0x6170870", VA = "0x186171470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0xB51620", Offset = "0xB50A20", VA = "0x180B51620")]
	public FNCABFEGHHN(NativeBitArray OECFFOENDNA, NativeParallelHashMap<HJCBPKJLHPC, int> BFPCLCKHHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x6171340", Offset = "0x6170740", VA = "0x186171340")]
	public bool EJIDGIEJJIB(HJCBPKJLHPC KLMFOODJGLC, OPJBLBHDCME PLNALAIILFK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[DKGHNNODKMB(NKCLGJJOGJC.LoadInstance)]
public interface PLPFILGJLBF
{
	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLBEKMGPCNG(FNONGLLGKNI KKLABGAMOPP, GADPHOCEFPI ANJCCKHBJJO);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface NKBNECJGHKH
{
	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	PBFAHIGAOLI GLJIGJLJPIC
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface FEHGFKPFIKL
{
	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	Type KJMAINNMAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[DKGHNNODKMB(NKCLGJJOGJC.LoadInstance)]
public interface GJIPPHEDIAE
{
	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ALBPKKOKJMA(FNONGLLGKNI CMIPJIFIMCO, bool ANJCCKHBJJO);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public readonly struct OJDCKENHJBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly IEnumerable<CBHEKEEBBBM> FMMNCBEKOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly IReadOnlyList<GameObject> KKLPKEICOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly IReadOnlyList<int> OMKGJIIPLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly IReadOnlyList<(HJCBPKJLHPC, HJCBPKJLHPC)> OCOAMNKIEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int DCFKLIBECJK;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public bool OPNBALCMBJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x61795F0", Offset = "0x61789F0", VA = "0x1861795F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public int FHODGEILLAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x8BDD90", Offset = "0x8BD190", VA = "0x1808BDD90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public IEnumerable<GameObject> AOFJOAADMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x885AD0", Offset = "0x884ED0", VA = "0x180885AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public IEnumerable<(HJCBPKJLHPC src, HJCBPKJLHPC dst)> LNJEKDBCEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x6179650", Offset = "0x6178A50", VA = "0x186179650")]
	public OJDCKENHJBA(IEnumerable<CBHEKEEBBBM> FMMNCBEKOKF, IReadOnlyList<GameObject> KKLPKEICOAG, IReadOnlyList<int> OMKGJIIPLIF, IReadOnlyList<(HJCBPKJLHPC src, HJCBPKJLHPC dst)> OCOAMNKIEHL, int DCFKLIBECJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x6179260", Offset = "0x6178660", VA = "0x186179260")]
	public (GameObject, int)[] AKANKCHHNIJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface KIGOPKFJJPN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000152")]
	bool JANIHDADIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	bool PMKBLFKMFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	CDHCGAIFLOH KKDPFNBMGIM
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LAAEIOOBCPL JLGKDADNEEC();

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LAAEIOOBCPL AEPPHMPCFLD(IEnumerable<FNONGLLGKNI> LKLMPHAAIMO, [In] PHCICLADBII IEDNNBHAIOM);

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EEJCCFGPODG OBOKOKGOILM(ByteString AKHLNCPLGAP);

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KHEJHEBDALJ JIFOBNNIMDJ(ByteString PKHNCMEKMEL, FNONGLLGKNI EMDODFFCGEF, [In] PHCICLADBII HDIDEIEGCGE, AIONPAICNPB KHHHFGFABJI, bool NFCGAIKCBFN = true);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JFBIOJFHDBK();

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "9")]
	OJDCKENHJBA EOEIEJKFMBB(IEnumerable<CBHEKEEBBBM> FMMNCBEKOKF);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class DIABKHENGGB
{
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface NPEDOKPMEEF
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action BDFAFMOCJNE;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action DOLMKKFJIHI;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct IPJOENJPJJE : POPBFOOPFKL, IEquatable<IPJOENJPJJE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public GLDOCFALIAD APPOBJLFBKD;

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x6173BD0", Offset = "0x6172FD0", VA = "0x186173BD0", Slot = "5")]
	public void JCEFODEMOAF(BEMFMJIIFFM EMDFNBPIKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x6173BA0", Offset = "0x6172FA0", VA = "0x186173BA0", Slot = "4")]
	public void ILCGODJBNBA(PKCECONMEHL MGAHLAJFBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x6173C00", Offset = "0x6173000", VA = "0x186173C00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x818880", Offset = "0x817C80", VA = "0x180818880", Slot = "6")]
	public bool Equals(IPJOENJPJJE KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x6173B20", Offset = "0x6172F20", VA = "0x186173B20", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x88D230", Offset = "0x88C630", VA = "0x18088D230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct HJCBPKJLHPC : IComparable<HJCBPKJLHPC>, IEquatable<HJCBPKJLHPC>, POPBFOOPFKL
{
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public const uint NKNDLKNDKAC = 0u;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public const uint NHEFMBGAGHC = 255u;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly HJCBPKJLHPC FGEMAOBKBLF;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private const int GOKAIPFKLNB = 24;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private const uint APJBMIFOLCN = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private const int DELGKIBNCAJ = 8;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private const uint HODCAGKHOFJ = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly uint PIOIENDCJNH;

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public uint JDALNLABFKF
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x1A99680", Offset = "0x1A98A80", VA = "0x181A99680")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public uint BDGBGLMDOLF
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x6173550", Offset = "0x6172950", VA = "0x186173550")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public uint GMLHINFPKMG
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x88D230", Offset = "0x88C630", VA = "0x18088D230")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public bool OPNBALCMBJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x60C9180", Offset = "0x60C8580", VA = "0x1860C9180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0xBFD9F0", Offset = "0xBFCDF0", VA = "0x180BFD9F0")]
	public static HJCBPKJLHPC OMBDOICDGEF(uint PIOIENDCJNH)
	{
		return default(HJCBPKJLHPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x61736B0", Offset = "0x6172AB0", VA = "0x1861736B0")]
	public HJCBPKJLHPC(int NCCJGGHNBDP, int LKAMEDCBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x61736B0", Offset = "0x6172AB0", VA = "0x1861736B0")]
	public HJCBPKJLHPC(uint NCCJGGHNBDP, int LKAMEDCBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x61736B0", Offset = "0x6172AB0", VA = "0x1861736B0")]
	public HJCBPKJLHPC(uint NCCJGGHNBDP, uint LKAMEDCBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x88D240", Offset = "0x88C640", VA = "0x18088D240")]
	private HJCBPKJLHPC(uint PIOIENDCJNH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x174DD70", Offset = "0x174D170", VA = "0x18174DD70")]
	public static bool HOHCACPHFGD(HJCBPKJLHPC KHCOFGFJDMP, HJCBPKJLHPC NFAPJGNODPK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x61734B0", Offset = "0x61728B0", VA = "0x1861734B0")]
	public static bool AEMEGLCBHEE(HJCBPKJLHPC KHCOFGFJDMP, HJCBPKJLHPC NFAPJGNODPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x818880", Offset = "0x817C80", VA = "0x180818880", Slot = "5")]
	public bool Equals(HJCBPKJLHPC FNOGEAGAPLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x61734D0", Offset = "0x61728D0", VA = "0x1861734D0", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2198180", Offset = "0x2197580", VA = "0x182198180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x6173620", Offset = "0x6172A20", VA = "0x186173620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x6173560", Offset = "0x6172960", VA = "0x186173560", Slot = "6")]
	public void ILCGODJBNBA(PKCECONMEHL MGAHLAJFBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x61735C0", Offset = "0x61729C0", VA = "0x1861735C0", Slot = "7")]
	public void JCEFODEMOAF(BEMFMJIIFFM EMDFNBPIKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x61734C0", Offset = "0x61728C0", VA = "0x1861734C0", Slot = "4")]
	public int CompareTo(HJCBPKJLHPC KMJGEHGGFFC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct CBHEKEEBBBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Guid LHLNCEHJAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public string FBLBKEHCCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Vector3 BEBKKMFGLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Quaternion IKFFGJBHBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Vector3 LFBOEHOBPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public int KFPIIMGLAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Dictionary<string, object> HKMEMMHNFBF;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x616D6A0", Offset = "0x616CAA0", VA = "0x18616D6A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x616D510", Offset = "0x616C910", VA = "0x18616D510")]
	private static string GKAFFCGNCLO(Dictionary<string, object> DJGCKIJAAIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public enum HGFLCAIHENN
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public static class FOJGHMLNMBH
{
	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x5636480", Offset = "0x5635880", VA = "0x185636480")]
	public static bool EFFMBFGABGG(this HGFLCAIHENN FICJMFBEBIN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[Flags]
public enum JLGEEFACADE
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
public interface KHEJHEBDALJ : CDHCGAIFLOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000159")]
	AIONPAICNPB MGGNKLOBIMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAFODOIJADE();

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DANHBAPKGNE();
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public interface CDHCGAIFLOH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	IEnumerable<CBHEKEEBBBM> AKGBOAKHBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	OJDCKENHJBA PPMAJMANBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	LocalId PEMCAJGHIAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	IEOCNNKMDFD MCAMBJJGILK
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GPHODLAFDGD(JLGEEFACADE CAJIFBPKGHL);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public interface AIONPAICNPB
{
	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ICPJLLDFOEG(Guid KILNCFNEBFG, [Out] Guid LHDFPPNLHJD);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface EEJCCFGPODG : CDHCGAIFLOH, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[Flags]
public enum IHCLIPJCKPG
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
public interface LAAEIOOBCPL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	IEOCNNKMDFD FLDBEFACJGP
	{
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString KGKFMPEBGGG();
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public enum BHLLJDOBKHM
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public delegate bool NAMILCHMEBB(HLJFGNMJDBJ MNDPBNJNCDG, [In] OJBPBHNMAAA ANJCCKHBJJO);
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public delegate bool CKBJJJKAOME<T>(HLJFGNMJDBJ MNDPBNJNCDG, [In] T ANJCCKHBJJO);
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface LCEGBNMGDCH
{
	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLKKEGKJEDJ(OPJBLBHDCME BLGMLDLMDIJ, Type MHHHJJDKBAE, NAMILCHMEBB NGJOKDNOLGO);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FBPCHBCEPJI(OPJBLBHDCME BLGMLDLMDIJ, [Out] NAMILCHMEBB NGJOKDNOLGO);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class EJHIFMDDOMA
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class MDEKNOAANCB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public CKBJJJKAOME<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public MDEKNOAANCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x3DBA920", Offset = "0x3DB9D20", VA = "0x183DBA920")]
		internal bool HFPBKFFBPMJ(HLJFGNMJDBJ pendingList, [In] OJBPBHNMAAA value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x2539B60", Offset = "0x2538F60", VA = "0x182539B60")]
	public static void NLKKEGKJEDJ<T>(this LCEGBNMGDCH JDDNEABEJAK, OPJBLBHDCME BLGMLDLMDIJ, CKBJJJKAOME<T> NGJOKDNOLGO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x61711A0", Offset = "0x61705A0", VA = "0x1861711A0")]
	public static bool INBOPPJJMBF(this LCEGBNMGDCH JDDNEABEJAK, HLJFGNMJDBJ MNDPBNJNCDG, OPJBLBHDCME BLGMLDLMDIJ, [In] OJBPBHNMAAA ANJCCKHBJJO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface OPBLMCKDKOL
{
	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	uint PNBGIBKFCBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface HLJFGNMJDBJ
{
	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KGOKMMFCBFP(HJCBPKJLHPC BIAEJAJDCAB, OPJBLBHDCME BLGMLDLMDIJ, ReadOnlySpan<byte> OFKEPGCHPGG, ReadOnlySpan<byte> LGINMOADOIB);

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LAIAJIECPHL(HJCBPKJLHPC BIAEJAJDCAB, OPJBLBHDCME BLGMLDLMDIJ);

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BLBPHKAFJON(HJCBPKJLHPC BIAEJAJDCAB, OPJBLBHDCME BLGMLDLMDIJ, ReadOnlySpan<byte> LGINMOADOIB);

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JINMFBPAGEO(HJCBPKJLHPC BIAEJAJDCAB, OPJBLBHDCME BLGMLDLMDIJ, Span<byte> OFKEPGCHPGG, Span<byte> LGINMOADOIB);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public static class DPGFJEBAGBG
{
	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x2521CD0", Offset = "0x25210D0", VA = "0x182521CD0")]
	public static bool JINMFBPAGEO<T>(this HLJFGNMJDBJ FABLKOPOIGL, HJCBPKJLHPC BIAEJAJDCAB, OPJBLBHDCME BLGMLDLMDIJ, [Out] T OFKEPGCHPGG, [Out] T LGINMOADOIB) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x2521BA0", Offset = "0x2520FA0", VA = "0x182521BA0")]
	public static bool BLBPHKAFJON<T>(this HLJFGNMJDBJ FABLKOPOIGL, HJCBPKJLHPC BIAEJAJDCAB, OPJBLBHDCME BLGMLDLMDIJ, T LGINMOADOIB) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public enum PCBIFJJOELP
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
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface CHBHNGBMHCK
{
	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PIGMLOGDFOF(GEKANCKOEPJ HEKLPNHIOGD, ReadOnlySpan<byte> KFANGHDLFAN);

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBAAODNOPMA(uint AAELINCEHGC, ReadOnlySpan<byte> KFANGHDLFAN);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface HAPINLOGNCN
{
	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GEKANCKOEPJ LPNPAEJDNIN(ReadOnlySpan<byte> KFANGHDLFAN);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface OBPLLFDIIMM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDPCPBKAGMH(GEKANCKOEPJ GPGELODKPOB, ReadOnlySpan<byte> KFANGHDLFAN);

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CLJFPFEBCAL(ReadOnlySpan<GEKANCKOEPJ> LMNCENGPHHC);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct MJOLONBACDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public GEKANCKOEPJ HEKLPNHIOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public ReadOnlyMemory<byte> KFANGHDLFAN;
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct GEKANCKOEPJ
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public static GEKANCKOEPJ NOGPOCGINBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public uint NCCJGGHNBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public int BJPIODFMGHL;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0xA43A60", Offset = "0xA42E60", VA = "0x180A43A60")]
	public GEKANCKOEPJ(uint NCCJGGHNBDP, int BJPIODFMGHL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x6171FB0", Offset = "0x61713B0", VA = "0x186171FB0")]
	public static bool HOHCACPHFGD([In] GEKANCKOEPJ NNOKPENDLPE, [In] GEKANCKOEPJ OBLEBBNJEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6171ED0", Offset = "0x61712D0", VA = "0x186171ED0", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x6171F80", Offset = "0x6171380", VA = "0x186171F80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x6171FD0", Offset = "0x61713D0", VA = "0x186171FD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6171EC0", Offset = "0x61712C0", VA = "0x186171EC0")]
	public void ABNKHBBCCGC([Out] uint NCCJGGHNBDP, [Out] int BJPIODFMGHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[DKGHNNODKMB(NKCLGJJOGJC.OMRoom)]
public interface IOECBJLKJOO : GFKANFPOOHC<IOECBJLKJOO>
{
	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DABECMHCGCA(OPJBLBHDCME FNOGEAGAPLC, [Out] JDPFLIFHEOF AILKMOHODBL);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public static class LOKNDBGKOOP
{
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public interface JDPFLIFHEOF
{
	[Cpp2IlInjected.Token(Token = "0x17000160")]
	Type IAEHHDJCGAF
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCEFODEMOAF(BEMFMJIIFFM EMDFNBPIKNJ, Span<byte> JILDGEDOLHB);

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ILCGODJBNBA(PKCECONMEHL MGAHLAJFBKF, ReadOnlySpan<byte> HEKLPNHIOGD);
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class EOCOJDKAAJD
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public struct PFJBAMHBMBN : ISystemStateComponentData, IComponentData, IEquatable<PFJBAMHBMBN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public float3 COIGLFMEKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public float3 FOLIPECGAFM;

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x6179BC0", Offset = "0x6178FC0", VA = "0x186179BC0", Slot = "4")]
	public bool Equals(PFJBAMHBMBN KMJGEHGGFFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface DIKOJODIIMC
{
	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MKAAPPADLOF KKELCEGLMMO(int MFEIPIKIEAE);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int GBBOIMDAKNO(MKAAPPADLOF ELDCCOEAPPI);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface IICABKJGKAO
{
	[Cpp2IlInjected.Token(Token = "0x17000161")]
	IEnumerable<GFLJOJJBMJJ> KDKFMCACCAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GDCEBGCAGBP(int MFEIPIKIEAE, [Out] GFLJOJJBMJJ AILKMOHODBL);
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface IBEBEPHEMOD
{
	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NHOPECANBOE(int MFEIPIKIEAE);
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface FOIKDLJALDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000162")]
	List<(MKAAPPADLOF nameHash, BOJFCNCMMAN stableTypeHash, Type type)> BDJHMMFEIAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public class CEDJFJLKOPL
{
	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public CEDJFJLKOPL()
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
