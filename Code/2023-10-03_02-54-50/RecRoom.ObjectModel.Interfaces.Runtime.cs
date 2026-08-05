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
public struct LKEHPHAMPJC : IReadOnlyList<JEDJBKOCEME>, IEnumerable<JEDJBKOCEME>, IEnumerable, IReadOnlyCollection<JEDJBKOCEME>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct GGABNELEOMA : IEnumerator<JEDJBKOCEME>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly HOKKMAFBPHI BAKIPPCJAEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator AGGHFLICNAL;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JEDJBKOCEME IODFMFKEHHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5D773F0", Offset = "0x5D75BF0", VA = "0x185D773F0", Slot = "4")]
			get
			{
				return default(JEDJBKOCEME);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5D77370", Offset = "0x5D75B70", VA = "0x185D77370", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x39753B0", Offset = "0x3973BB0", VA = "0x1839753B0")]
		public GGABNELEOMA(HOKKMAFBPHI BAKIPPCJAEK, NativeArray<LocalId>.Enumerator AGGHFLICNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5D772B0", Offset = "0x5D75AB0", VA = "0x185D772B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5D772F0", Offset = "0x5D75AF0", VA = "0x185D772F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5D77330", Offset = "0x5D75B30", VA = "0x185D77330", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> MGOMOGOCFIB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public JEDJBKOCEME NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D7CAE0", Offset = "0x5D7B2E0", VA = "0x185D7CAE0", Slot = "4")]
		get
		{
			return default(JEDJBKOCEME);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D7C5D0", Offset = "0x5D7ADD0", VA = "0x185D7C5D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int ENCHCEMLEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x760180", Offset = "0x75E980", VA = "0x180760180", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public HOKKMAFBPHI HMDFIBLPPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int FPGKKKADJDC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x760180", Offset = "0x75E980", VA = "0x180760180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool GABGEKOCFIO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D7C4A0", Offset = "0x5D7ACA0", VA = "0x185D7C4A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> ACNCIJOILJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x396EF40", Offset = "0x396D740", VA = "0x18396EF40")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C9B0", Offset = "0x5D7B1B0", VA = "0x185D7C9B0")]
	public LKEHPHAMPJC(int OLEHEDGFINF, HOKKMAFBPHI BAKIPPCJAEK, Allocator OPPHPFNHPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3975050", Offset = "0x3973850", VA = "0x183975050")]
	public LKEHPHAMPJC(HOKKMAFBPHI BAKIPPCJAEK, NativeArray<LocalId> MGOMOGOCFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C940", Offset = "0x5D7B140", VA = "0x185D7C940")]
	internal LKEHPHAMPJC(HOKKMAFBPHI BAKIPPCJAEK, NativeArray<Entity> EFLDIIILPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D7CA40", Offset = "0x5D7B240", VA = "0x185D7CA40")]
	public LKEHPHAMPJC(HOKKMAFBPHI BAKIPPCJAEK, int OOHKMCMOCLB, Allocator OPPHPFNHPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C890", Offset = "0x5D7B090", VA = "0x185D7C890")]
	public LKEHPHAMPJC(LKEHPHAMPJC MECHJEAPJEP, Allocator OPPHPFNHPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C520", Offset = "0x5D7AD20", VA = "0x185D7C520")]
	public LKEHPHAMPJC FGACGACICLO(Allocator OPPHPFNHPMG = Allocator.Temp)
	{
		return default(LKEHPHAMPJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C4E0", Offset = "0x5D7ACE0", VA = "0x185D7C4E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C620", Offset = "0x5D7AE20", VA = "0x185D7C620")]
	public GGABNELEOMA NNHLEKOBGNG()
	{
		return default(GGABNELEOMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C6B0", Offset = "0x5D7AEB0", VA = "0x185D7C6B0", Slot = "6")]
	private IEnumerator<JEDJBKOCEME> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C7A0", Offset = "0x5D7AFA0", VA = "0x185D7C7A0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct PFOEBJGKGMH : IList<JEDJBKOCEME>, ICollection<JEDJBKOCEME>, IEnumerable<JEDJBKOCEME>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct AACFJDPACNA : IEnumerator<JEDJBKOCEME>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly HOKKMAFBPHI BAKIPPCJAEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator AGGHFLICNAL;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public JEDJBKOCEME IODFMFKEHHG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5D71CC0", Offset = "0x5D704C0", VA = "0x185D71CC0", Slot = "4")]
			get
			{
				return default(JEDJBKOCEME);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5D71C40", Offset = "0x5D70440", VA = "0x185D71C40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x39753B0", Offset = "0x3973BB0", VA = "0x1839753B0")]
		public AACFJDPACNA(HOKKMAFBPHI BAKIPPCJAEK, NativeArray<LocalId>.Enumerator AGGHFLICNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5D71B80", Offset = "0x5D70380", VA = "0x185D71B80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5D71BC0", Offset = "0x5D703C0", VA = "0x185D71BC0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5D71C00", Offset = "0x5D70400", VA = "0x185D71C00", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> MGOMOGOCFIB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JEDJBKOCEME NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5D80570", Offset = "0x5D7ED70", VA = "0x185D80570", Slot = "4")]
		get
		{
			return default(JEDJBKOCEME);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5D805F0", Offset = "0x5D7EDF0", VA = "0x185D805F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5D7FCF0", Offset = "0x5D7E4F0", VA = "0x185D7FCF0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FPGKKKADJDC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5D7FCF0", Offset = "0x5D7E4F0", VA = "0x185D7FCF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool FCEGNANDKHA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5D804E0", Offset = "0x5D7ECE0", VA = "0x185D804E0")]
	public PFOEBJGKGMH(HOKKMAFBPHI BAKIPPCJAEK, int OOHKMCMOCLB, Allocator OPPHPFNHPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D80160", Offset = "0x5D7E960", VA = "0x185D80160")]
	public LKEHPHAMPJC OHNKNCMAPCB()
	{
		return default(LKEHPHAMPJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D7FD30", Offset = "0x5D7E530", VA = "0x185D7FD30", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D7FD70", Offset = "0x5D7E570", VA = "0x185D7FD70", Slot = "13")]
	public bool Contains(JEDJBKOCEME AKPEBFBEHGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D7FE00", Offset = "0x5D7E600", VA = "0x185D7FE00", Slot = "14")]
	public void CopyTo(JEDJBKOCEME[] JMHHCKCLFBI, int HPIBLFHGGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D7FC70", Offset = "0x5D7E470", VA = "0x185D7FC70", Slot = "11")]
	public void Add(JEDJBKOCEME AKPEBFBEHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5D80020", Offset = "0x5D7E820", VA = "0x185D80020", Slot = "7")]
	public void Insert(int ADMJKDLHPCI, JEDJBKOCEME AKPEBFBEHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5D80230", Offset = "0x5D7EA30", VA = "0x185D80230", Slot = "15")]
	public bool Remove(JEDJBKOCEME AKPEBFBEHGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D7FF90", Offset = "0x5D7E790", VA = "0x185D7FF90", Slot = "6")]
	public int IndexOf(JEDJBKOCEME AKPEBFBEHGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D801E0", Offset = "0x5D7E9E0", VA = "0x185D801E0", Slot = "8")]
	public void RemoveAt(int ADMJKDLHPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D7FF50", Offset = "0x5D7E750", VA = "0x185D7FF50", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D800D0", Offset = "0x5D7E8D0", VA = "0x185D800D0")]
	public AACFJDPACNA NNHLEKOBGNG()
	{
		return default(AACFJDPACNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D80300", Offset = "0x5D7EB00", VA = "0x185D80300", Slot = "16")]
	private IEnumerator<JEDJBKOCEME> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5D803F0", Offset = "0x5D7EBF0", VA = "0x185D803F0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HLHILOHMCCK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int ABNIMCNEPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> EBLDPCNAJMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JEDJBKOCEME FNCLAMKMMGO(JEDJBKOCEME MGOMOGOCFIB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CJHKDGKNDPP : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface EMFAHBILPMG : GIFDCKIGEDL, LAKKFPDMDNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool PLFIBBCFHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	MDHODIMGPDH EFBOCBBNCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	KOALBKCLEGM AAHFJAMBBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	GIMAKLLKNAL JBIHOCPBPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	FBPCDIFNPDJ GLPMIAODPCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	KJLFDPOCKCE EFMELCOCEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface LAKKFPDMDNI
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool HAOKFJJANAB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface ELEFKBAOJOL
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LCCKBFMBNHJ(bool IFKKLLBODIE);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface FBPCDIFNPDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool OGJFKDFIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NMFGDAJNFLD;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DBLFJEFFIEC(bool ICGNKEDIKDH);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FELPLDHBPNL(ByteString BGGDIKOMABC);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IHKIJDKGJEI();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NFFICPMCDGF();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DFHLKILPECC();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface GIMAKLLKNAL
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	FHMIKLMEDIH EFBOCBBNCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	KOALBKCLEGM AAHFJAMBBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	HLLCKCNCCJD HIGJMHAGADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	EMFAHBILPMG PGDDJJAGELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	HOKKMAFBPHI HMDFIBLPPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	GKGBAHAPFBD IABBJBIJJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	CECLHBPNMGM MCMPNLKGJLG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	FBKLHLEKBGM ALADFHAJFHF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	PMIAAANLCEE PBKEOGNNMGF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	FICELHLOKNG HLIFDNJKFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	AAKMNAOGINP EPHCILPJDEG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	ALHOKAPBJCK EMECCKDFMAF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	GCMHDFHOGLD DMOAKNOPDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	OELIOIGNFBB GPKLFGNLOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	DIIBKKJDGKE CCNBEKFDMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	ALLPNMMCFOG BPKFHANFHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	FLFBKAFPGOO PLBMDFFGFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	ENDHILGPLNG EMABDOFCGDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	JDCOPOKIPOM IDKAMGHJFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	EIGPEOIKDPK CDPDDDCBCIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DebuggerTypeProxy(typeof(FPJLIDDEMOG))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct JEDJBKOCEME : IComparable<JEDJBKOCEME>, IEquatable<JEDJBKOCEME>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly JEDJBKOCEME GCBDJIKNIJL;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int MPAHFOOKKLO = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int HALGNKBBKOM = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int HJFLNIMBLMP = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int MLNBKPNAMNF = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId JBPJNGFGLPC;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public HOKKMAFBPHI HMDFIBLPPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5D71B00", Offset = "0x5D70300", VA = "0x185D71B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public LocalId MIJIOCIHADN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5D79730", Offset = "0x5D77F30", VA = "0x185D79730")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	internal KJLFDPOCKCE EFMELCOCEHF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5D79900", Offset = "0x5D78100", VA = "0x185D79900")]
		get
		{
			return default(KJLFDPOCKCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool CHBJDEDBAAF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5D79910", Offset = "0x5D78110", VA = "0x185D79910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool JDAHGFGELFB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5D799F0", Offset = "0x5D781F0", VA = "0x185D799F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool FDPBIINIBFH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5D79580", Offset = "0x5D77D80", VA = "0x185D79580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5D79C90", Offset = "0x5D78490", VA = "0x185D79C90")]
	public JEDJBKOCEME(HOKKMAFBPHI EJDLHBDBDML, LocalId JBPJNGFGLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
	public EEKEIMNDBGI EJFJODBKHAI()
	{
		return default(EEKEIMNDBGI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5D796B0", Offset = "0x5D77EB0", VA = "0x185D796B0")]
	public static LocalId DAOGIJOJDNF(JEDJBKOCEME PKDAMHLPDJG)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5D796F0", Offset = "0x5D77EF0", VA = "0x185D796F0")]
	public static Entity DAOGIJOJDNF(JEDJBKOCEME PKDAMHLPDJG)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5D79A40", Offset = "0x5D78240", VA = "0x185D79A40")]
	public static bool PEFPHNLEPOM(JEDJBKOCEME FABNAGLLOKN, JEDJBKOCEME FCOICCIGANJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5D76D00", Offset = "0x5D75500", VA = "0x185D76D00")]
	public static bool OONIEGCHHIB(JEDJBKOCEME FABNAGLLOKN, JEDJBKOCEME FCOICCIGANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D79B60", Offset = "0x5D78360", VA = "0x185D79B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5D79770", Offset = "0x5D77F70", VA = "0x185D79770", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5D719B0", Offset = "0x5D701B0", VA = "0x185D719B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5D795D0", Offset = "0x5D77DD0", VA = "0x185D795D0", Slot = "4")]
	public int CompareTo(JEDJBKOCEME GHNNCJBDHKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D701A0", VA = "0x185D719A0", Slot = "5")]
	public bool Equals(JEDJBKOCEME GHNNCJBDHKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class CHOLDDDKLEF
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5D75800", Offset = "0x5D74000", VA = "0x185D75800")]
	public static KLEIPEFFJCP DFKMDGDCJGD(this JEDJBKOCEME ELOCHLKHPBP)
	{
		return default(KLEIPEFFJCP);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x21FD1F0", Offset = "0x21FB9F0", VA = "0x1821FD1F0")]
	public static T JIDCLJEKFID<T>(this JEDJBKOCEME ELOCHLKHPBP) where T : struct, IComponent
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal sealed class FPJLIDDEMOG
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct KJLFDPOCKCE : IEquatable<KJLFDPOCKCE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte FJFHMLGEMLM;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] FOJKHBGCMEP;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static HOKKMAFBPHI KPAJOHNBIHM;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static EMFAHBILPMG LEDOOPOPHLI;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static HOKKMAFBPHI[] GJCPMLOEKHA;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static EMFAHBILPMG[] PDACLOEBJLK;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static int DKFDFNGHHBB;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public HOKKMAFBPHI DJAKHGGJELP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5D7BAA0", Offset = "0x5D7A2A0", VA = "0x185D7BAA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5D7BC50", Offset = "0x5D7A450", VA = "0x185D7BC50")]
	static KJLFDPOCKCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xB30410", Offset = "0xB2EC10", VA = "0x180B30410")]
	internal KJLFDPOCKCE(byte IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x509AD00", Offset = "0x5099500", VA = "0x18509AD00", Slot = "4")]
	public bool Equals(KJLFDPOCKCE GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5D7B1D0", Offset = "0x5D799D0", VA = "0x185D7B1D0", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1902970", Offset = "0x1901170", VA = "0x181902970", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5D7BB90", Offset = "0x5D7A390", VA = "0x185D7BB90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5D7B9F0", Offset = "0x5D7A1F0", VA = "0x185D7B9F0")]
	private static HOKKMAFBPHI KHPAGAIEMOB(byte FJFHMLGEMLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5D7B060", Offset = "0x5D79860", VA = "0x185D7B060")]
	private static object DMCBJOMMJJE(byte FJFHMLGEMLM, object[] EMKFAOJKFLD, object FEAAGHJCDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5D7BB80", Offset = "0x5D7A380", VA = "0x185D7BB80")]
	private static int PKKKKLICPFG(byte FJFHMLGEMLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5D7AFD0", Offset = "0x5D797D0", VA = "0x185D7AFD0")]
	private static int ANJGBPDLBLK(byte FJFHMLGEMLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5D7AFE0", Offset = "0x5D797E0", VA = "0x185D7AFE0")]
	private static (int, int) DLKOEFAANGN(byte FJFHMLGEMLM)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5D7B270", Offset = "0x5D79A70", VA = "0x185D7B270")]
	private static byte FOIMGEMOJAO(int OJAHFIICKFC, int ADMJKDLHPCI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5D7B740", Offset = "0x5D79F40", VA = "0x185D7B740")]
	internal static KJLFDPOCKCE JKCLJMACCFA(EMFAHBILPMG IBCFJAAICJF, HOKKMAFBPHI MDMPLMBODCL)
	{
		return default(KJLFDPOCKCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5D7B560", Offset = "0x5D79D60", VA = "0x185D7B560")]
	internal static void HOLDKHPGNLM(KJLFDPOCKCE FJFHMLGEMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5D7B280", Offset = "0x5D79A80", VA = "0x185D7B280")]
	private static void HGMCDOHNFEC(int OLEHEDGFINF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface GPHJLMFLCDC
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJNJDKELLEP();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCFGBCJGIGD(bool GKNOFLJPEJH);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LNGOGFCNCCB(GameObject AAAOHJGLLEG);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface LBNHEJPIPLE
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFAPJEDBGJA(LKEHPHAMPJC MGOMOGOCFIB);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 IKHFCADGODI(GameObject AAAOHJGLLEG, int GLGJIONJPFC);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface KOALBKCLEGM
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	GPHJLMFLCDC ECHANCJFMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	GIBCPELIMEL IJJFGODKJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	BKAHPKLHPCE LKNJHBFLKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	FECOAHBOMEJ PEMJIEHFMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	GANMDIKNMFL MMNIHLBJIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	FGIBAMAPNKP IJFOHPLHFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	JGCGHOOJAFE NIGJOADKDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	CLKHJAFEIDJ CKCNJFHNAHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface JCIAOBDAFHE
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KDMBDCDNMAJ(Action POMIBLHGGHJ, bool LHJIANPECCM);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NMKDHCMAGGL(string BOBHOMKFHJB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface GIBCPELIMEL
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string MLEIADMNJBA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] MKCHDDFFIHG(IEnumerable<NDNCPECEFHH> HPFBMIPPKKG);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KLEIPEFFJCP JNHDICPLMIP(Guid DAGAPKMPAFA);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LGFBLDJAEMF(GameObject AAAOHJGLLEG, [Out] KLEIPEFFJCP LFHNIGHPLBN);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EPEBGDFIALM(GameObject AAAOHJGLLEG, [Out] int FACFMDAAPGF, [Out] KNBFLDNEILM FGDLEJGCDOG);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HFBIDPNKJHF JOKLGCGLJGJ(NDNCPECEFHH FDOGBBKMGKO);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HFBIDPNKJHF JOKLGCGLJGJ(string LKJPOGNICEK, KLEIPEFFJCP LFHNIGHPLBN, Vector3 OBAACBLACLC, Quaternion AHLHKGGFBGH, Vector3 CDLIHEJMBGO);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EJDKNJPJIMN(GameObject KGPBGLHBMIN, bool MGALCAEGIBE);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FDKNKEFNNNG(GameObject AAAOHJGLLEG, bool LKOCDFMKJJF, bool ILPLKNGNLOE);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class NADPBLLEGHI
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5D7CF00", Offset = "0x5D7B700", VA = "0x185D7CF00")]
	public static HFBIDPNKJHF JOKLGCGLJGJ(this GIBCPELIMEL PEPBPPBDPDE, KLEIPEFFJCP LFHNIGHPLBN, Vector3 OBAACBLACLC, Quaternion AHLHKGGFBGH, Vector3 CDLIHEJMBGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface BKAHPKLHPCE
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PAOJHMMCJFJ(bool ICGNKEDIKDH);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface FECOAHBOMEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool KNIBJIGJHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	bool JAIPJDBIFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool LNDKJAHGPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool PAEBIKIJGMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CLFJCMJBKBK(object AJPCNFDACDH);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HKOEJJHDOJP(object HBMBMELELPF);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CBNMHDDCGLG(object HBMBMELELPF);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int KOBDNJCMGML(GameObject LCKCBKEEMNI);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ANNLCLKDMJK(NativeArray<int> GCLNKKJCMGB);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface GANMDIKNMFL
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPPBBLOBCND(GameObject AAAOHJGLLEG);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface DIFCPOBJEFP
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IOIAKDHMFPL(string LACIBLEADOC);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface BODCEDFCLFN
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LAKEKMIAEAN(GameObject AAAOHJGLLEG);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IFLNJNAOGEF(GameObject AAAOHJGLLEG);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	object LLCHHAHNAFH(JEDJBKOCEME JBPJNGFGLPC, GameObject AAAOHJGLLEG, Action<JEDJBKOCEME, int> ELLFKJCIDIE);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JHCBLDFPKPL(GameObject AAAOHJGLLEG, object ODPHAECAKPG);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface FGIBAMAPNKP
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int JHFHPGDCFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int CPPGGININBM(GameObject AAAOHJGLLEG);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NACONCBDFNM([Out] Vector3 OBAACBLACLC);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MPAGMIDJBEE();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface JGCGHOOJAFE
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	bool OGJFKDFIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool ANHKDIAAINO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface DELEEKPOPNO
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	JMJOKMNENBD BCLDGBOKDJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	LPLNEKGDBBF FDMGBKFBLOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GHCAEKMMCDM(Transform KHFCFAPNPDN);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LKNAGLPCCMD(Transform KHFCFAPNPDN, NJNMPGINBDC DBPNJKCCAGK);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PBPIEPLOHEN(Transform KHFCFAPNPDN, PFCOBFLEOJA JMCPMFFLLGB);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface CLKHJAFEIDJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCCDPNOJNEG();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface NMGHNJPMHGE
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACDLAKMNKID();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface KAPOAGACOPL
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KNBFLDNEILM AHEAMLAMHCJ(GameObject LCKCBKEEMNI);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GJLPJLFOHOO(GameObject AAAOHJGLLEG, ANBGLIGJGHH ILOFMEFDBIB, MGGMMJMNCIF MGMIBBJCOPP);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct PHAAPDDMCCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly NDFAHNCMLOC IAIBEBECMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly NDFAHNCMLOC BMNCKBBLELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal readonly uint BPOFIOCJDBH;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D80680", Offset = "0x5D7EE80", VA = "0x185D80680", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct IMKLMPANNNO
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly PHAAPDDMCCJ POMIBLHGGHJ;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D774D0", Offset = "0x5D75CD0", VA = "0x185D774D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct GIJOKCJBBMH
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly PHAAPDDMCCJ POMIBLHGGHJ;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D774D0", Offset = "0x5D75CD0", VA = "0x185D774D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct KOFMHELMOFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint BPOFIOCJDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly bool JJLCPLAALIG;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C360", Offset = "0x5D7AB60", VA = "0x185D7C360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct NDFAHNCMLOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal int INDDJJFOAAH;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D7D170", Offset = "0x5D7B970", VA = "0x185D7D170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface COPLHEOFJFO
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	EAEOAMHBCGO PGNFDCDEMIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum GHPHGOGKJOP
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
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface HFBIDPNKJHF : BJHONPBLHDC
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	EEKEIMNDBGI HAMOKPMJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	GHPHGOGKJOP JCKCILLABLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool NDJPHOJOLCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	GameObject AAAOHJGLLEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<HFBIDPNKJHF> NKJOAKEGNMB;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(HLLCKCNCCJD LPBOBKJPICK, JEDJBKOCEME DFEGGPKBMON);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool HJMJHNEJCGP);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class HPLFGKIIGMC
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5D78130", Offset = "0x5D76930", VA = "0x185D78130")]
	public static bool LNCBCICGOEB(this HFBIDPNKJHF IBCBDBLGJKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5D780E0", Offset = "0x5D768E0", VA = "0x185D780E0")]
	public static bool LFNHECMKBDH(this HFBIDPNKJHF IBCBDBLGJKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5D78090", Offset = "0x5D76890", VA = "0x185D78090")]
	public static bool ABIKCDPGOIG(this HFBIDPNKJHF IBCBDBLGJKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5D78180", Offset = "0x5D76980", VA = "0x185D78180")]
	public static bool PLFIBBCFHEC(this HFBIDPNKJHF IBCBDBLGJKJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface BJHONPBLHDC
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool KCOGMFJCNBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	JEDJBKOCEME MIIIPHIJIPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
internal interface NPOOFHNLFBB
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<HCBGKMEOBBG> GAALPPINDPM;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface MNOPJOLALGH : EMOGJLILLHF<KLEIPEFFJCP>, HHEDIONCJJG, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface DOGKHPFFKKJ<T> : MONKJDIIJEC<KLEIPEFFJCP, T>, EMOGJLILLHF<KLEIPEFFJCP>, HHEDIONCJJG, IDisposable, MNOPJOLALGH where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class PNFMGBMLNNL
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2505770", Offset = "0x2503F70", VA = "0x182505770")]
	public static bool GBJDFDNKBJP<T>(this EMOGJLILLHF<KLEIPEFFJCP> OLJMCOBAMDO, KLEIPEFFJCP LFHNIGHPLBN, [Out] T IFKKLLBODIE) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x23746A0", Offset = "0x2372EA0", VA = "0x1823746A0")]
	public static bool ABNCEPDOIJI<T>(this EMOGJLILLHF<KLEIPEFFJCP> OLJMCOBAMDO, KLEIPEFFJCP LFHNIGHPLBN, [In] T EPKJMINCAGG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface AMEANBJHGMM : EMOGJLILLHF<JEDJBKOCEME>, HHEDIONCJJG, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface OCJCHIJHGBA<T> : MONKJDIIJEC<JEDJBKOCEME, T>, EMOGJLILLHF<JEDJBKOCEME>, HHEDIONCJJG, IDisposable, AMEANBJHGMM where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class KHJDNEDACFM
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2196F10", Offset = "0x2195710", VA = "0x182196F10")]
	public static T BCFBOGKIONB<T>(this EMOGJLILLHF<JEDJBKOCEME> OLJMCOBAMDO, JEDJBKOCEME JBPJNGFGLPC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2374660", Offset = "0x2372E60", VA = "0x182374660")]
	public static bool ABNCEPDOIJI<T>(this EMOGJLILLHF<JEDJBKOCEME> OLJMCOBAMDO, JEDJBKOCEME JBPJNGFGLPC, [In] T EPKJMINCAGG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct BCJCKPDGHHM : IComparable<BCJCKPDGHHM>, IEquatable<BCJCKPDGHHM>
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly BCJCKPDGHHM GCBDJIKNIJL;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly BCJCKPDGHHM ICDNAHMBOHK;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly BCJCKPDGHHM IPPJCJGHAFO;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly BCJCKPDGHHM GEECFHGCBCO;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly BCJCKPDGHHM JOBILGPCFLP;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly BCJCKPDGHHM FGDNNCDCNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int DIEGBKIOLGK;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool LILDMNCLBEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5D72A60", Offset = "0x5D71260", VA = "0x185D72A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int LJGHGDGJIHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5D72A50", Offset = "0x5D71250", VA = "0x185D72A50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFB0", Offset = "0x7EB7B0", VA = "0x1807ECFB0")]
	public BCJCKPDGHHM(int ADMJKDLHPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5D729F0", Offset = "0x5D711F0", VA = "0x185D729F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5D72970", Offset = "0x5D71170", VA = "0x185D72970", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x160F1B0", Offset = "0x160D9B0", VA = "0x18160F1B0", Slot = "5")]
	public bool Equals(BCJCKPDGHHM GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x161C8C0", Offset = "0x161B0C0", VA = "0x18161C8C0", Slot = "4")]
	public int CompareTo(BCJCKPDGHHM GHNNCJBDHKF)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0xBCE930", Offset = "0xBCD130", VA = "0x180BCE930")]
	public static BCJCKPDGHHM DAOGIJOJDNF(int ADMJKDLHPCI)
	{
		return default(BCJCKPDGHHM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0xBCE930", Offset = "0xBCD130", VA = "0x180BCE930")]
	public static int DAOGIJOJDNF(BCJCKPDGHHM BFLLNKNNDBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5D72A70", Offset = "0x5D71270", VA = "0x185D72A70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public readonly struct EEKEIMNDBGI : IEquatable<EEKEIMNDBGI>, BJHONPBLHDC
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly EEKEIMNDBGI KOOCNEMHOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly JEDJBKOCEME ADMPFLAIEKN;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public JEDJBKOCEME MIIIPHIJIPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710", Slot = "6")]
		get
		{
			return default(JEDJBKOCEME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public BFNIBHHKBLF KMBMFNEKLGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(BFNIBHHKBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public DJDJGHADPGK IABBJBIJJPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(DJDJGHADPGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private HOKKMAFBPHI HMDFIBLPPLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5D71B00", Offset = "0x5D70300", VA = "0x185D71B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public GameObject AAAOHJGLLEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5D76A40", Offset = "0x5D75240", VA = "0x185D76A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public KLEIPEFFJCP JFLMIGKMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5D76BF0", Offset = "0x5D753F0", VA = "0x185D76BF0")]
		get
		{
			return default(KLEIPEFFJCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public GALEJKINAHP NBIDIMPHAEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5D766D0", Offset = "0x5D74ED0", VA = "0x185D766D0")]
		get
		{
			return default(GALEJKINAHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public KNBFLDNEILM ELHAOCBDMKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5D76630", Offset = "0x5D74E30", VA = "0x185D76630")]
		get
		{
			return default(KNBFLDNEILM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool LIJNJOKMPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5D76770", Offset = "0x5D74F70", VA = "0x185D76770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool IIFPCKCKCDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5D768E0", Offset = "0x5D750E0", VA = "0x185D768E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool MBJPLBKGCLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5D76BD0", Offset = "0x5D753D0", VA = "0x185D76BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool GDMJCBNAFEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5D76610", Offset = "0x5D74E10", VA = "0x185D76610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool EAGHCCCLGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D76790", Offset = "0x5D74F90", VA = "0x185D76790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool FJNANJBGKAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5D76D30", Offset = "0x5D75530", VA = "0x185D76D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool PGLANOKIJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5D76C90", Offset = "0x5D75490", VA = "0x185D76C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public IMBGJOIJNNH LGJOCDFOJEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(IMBGJOIJNNH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public NNMPHMMLMAL DFHDNNAKKOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(NNMPHMMLMAL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public CKLOBGIPPGP DMOAKNOPDFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(CKLOBGIPPGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public OOJJHMDPNJF AOFBKJKEMBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(OOJJHMDPNJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public ADEFEJOLDHC EMECCKDFMAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(ADEFEJOLDHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public AABMLEJPFBC MCDCEMNMNJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(AABMLEJPFBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public OBODBJKNAJN DLMGGCPEADI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(OBODBJKNAJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool LNCBCICGOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5D76350", Offset = "0x5D74B50", VA = "0x185D76350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool LKIMKDPCJKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5D767B0", Offset = "0x5D74FB0", VA = "0x185D767B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	private bool JOIIBNLPGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x77C260", Offset = "0x77AA60", VA = "0x18077C260", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00")]
	public EEKEIMNDBGI(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5D71F60", Offset = "0x5D70760", VA = "0x185D71F60")]
	public static bool DAOGIJOJDNF(EEKEIMNDBGI IFKKLLBODIE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0xA207E0", Offset = "0xA1EFE0", VA = "0x180A207E0")]
	public static JEDJBKOCEME DAOGIJOJDNF(EEKEIMNDBGI IFKKLLBODIE)
	{
		return default(JEDJBKOCEME);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5D76D20", Offset = "0x5D75520", VA = "0x185D76D20")]
	public static bool PEFPHNLEPOM(EEKEIMNDBGI FABNAGLLOKN, EEKEIMNDBGI FCOICCIGANJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5D76D00", Offset = "0x5D75500", VA = "0x185D76D00")]
	public static bool OONIEGCHHIB(EEKEIMNDBGI FABNAGLLOKN, EEKEIMNDBGI FCOICCIGANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5D719B0", Offset = "0x5D701B0", VA = "0x185D719B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5D76580", Offset = "0x5D74D80", VA = "0x185D76580", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D701A0", VA = "0x185D719A0", Slot = "4")]
	public bool Equals(EEKEIMNDBGI GHNNCJBDHKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0xA207E0", Offset = "0xA1EFE0", VA = "0x180A207E0")]
	public static EEKEIMNDBGI DAOGIJOJDNF(JEDJBKOCEME ADMPFLAIEKN)
	{
		return default(EEKEIMNDBGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D769F0", Offset = "0x5D751F0", VA = "0x185D769F0")]
	public JMAMHBBAHMA LGACBADJGNB()
	{
		return default(JMAMHBBAHMA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5D76440", Offset = "0x5D74C40", VA = "0x185D76440")]
	public HAEFPOHFJCO BCNNJLCKECM()
	{
		return default(HAEFPOHFJCO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D76CB0", Offset = "0x5D754B0", VA = "0x185D76CB0")]
	public KJNJJDIGKBN OOECPCJEBJF()
	{
		return default(KJNJJDIGKBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5D76470", Offset = "0x5D74C70", VA = "0x185D76470")]
	public void CKHHEFMHFCG([Optional] object PIPCHJCEPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5D767F0", Offset = "0x5D74FF0", VA = "0x185D767F0")]
	public bool JEDDAFCMBOC(object PIPCHJCEPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5D76900", Offset = "0x5D75100", VA = "0x185D76900")]
	public bool KJPIJIECLLM(object PIPCHJCEPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5D76D70", Offset = "0x5D75570", VA = "0x185D76D70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct OBODBJKNAJN : IEquatable<OBODBJKNAJN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly JEDJBKOCEME ADMPFLAIEKN;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public JEDJBKOCEME MIIIPHIJIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(JEDJBKOCEME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public EEKEIMNDBGI HAMOKPMJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	private HOKKMAFBPHI HMDFIBLPPLC
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5D71B00", Offset = "0x5D70300", VA = "0x185D71B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	private GIMAKLLKNAL JBIHOCPBPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5D7DD20", Offset = "0x5D7C520", VA = "0x185D7DD20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	private ALLPNMMCFOG PNMJKBNOMLK
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5D7DF70", Offset = "0x5D7C770", VA = "0x185D7DF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool EEIIPDLDMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5D7DDB0", Offset = "0x5D7C5B0", VA = "0x185D7DDB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public Guid PKLFMHJMJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5D7DC00", Offset = "0x5D7C400", VA = "0x185D7DC00")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool JIJMCBPOPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5D7E2A0", Offset = "0x5D7CAA0", VA = "0x185D7E2A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Guid EKHLCJBCABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5D7DFD0", Offset = "0x5D7C7D0", VA = "0x185D7DFD0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00")]
	public OBODBJKNAJN(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5D71F60", Offset = "0x5D70760", VA = "0x185D71F60")]
	public static bool DAOGIJOJDNF(OBODBJKNAJN IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5D719B0", Offset = "0x5D701B0", VA = "0x185D719B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5D7DEE0", Offset = "0x5D7C6E0", VA = "0x185D7DEE0", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D701A0", VA = "0x185D719A0", Slot = "4")]
	public bool Equals(OBODBJKNAJN GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5D71B60", Offset = "0x5D70360", VA = "0x185D71B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5D7DE40", Offset = "0x5D7C640", VA = "0x185D7DE40")]
	public bool EIOBLOPDBJG([Out] Guid GHAIFMOEMBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5D7E330", Offset = "0x5D7CB30", VA = "0x185D7E330")]
	public void ODKAAPPFPBO(Guid HBAHLIBAHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5D7DB60", Offset = "0x5D7C360", VA = "0x185D7DB60")]
	public bool AIOGPADGMDO([Out] Guid PCPOCGCMPJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5D7E180", Offset = "0x5D7C980", VA = "0x185D7E180")]
	public void NCIKPNOMIED(Guid HBAHLIBAHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5D7E0F0", Offset = "0x5D7C8F0", VA = "0x185D7E0F0")]
	public void KAMCNLOJOMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct KJNJJDIGKBN : IEquatable<KJNJJDIGKBN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly JEDJBKOCEME ADMPFLAIEKN;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public JEDJBKOCEME MIIIPHIJIPF
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(JEDJBKOCEME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public EEKEIMNDBGI HAMOKPMJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	private HOKKMAFBPHI HMDFIBLPPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5D71B00", Offset = "0x5D70300", VA = "0x185D71B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	private GIMAKLLKNAL JBIHOCPBPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5D7BC60", Offset = "0x5D7A460", VA = "0x185D7BC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	private FLFBKAFPGOO AGFHIIIOCAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5D7BF30", Offset = "0x5D7A730", VA = "0x185D7BF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float3 KIFMLLOLFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5D7BF90", Offset = "0x5D7A790", VA = "0x185D7BF90")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public quaternion NDPDNBCADDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5D7BE10", Offset = "0x5D7A610", VA = "0x185D7BE10")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public EEKEIMNDBGI IHEBMPMGHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5D7BD80", Offset = "0x5D7A580", VA = "0x185D7BD80")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00")]
	public KJNJJDIGKBN(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xA207E0", Offset = "0xA1EFE0", VA = "0x180A207E0")]
	public static JEDJBKOCEME DAOGIJOJDNF(KJNJJDIGKBN IFKKLLBODIE)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5D719B0", Offset = "0x5D701B0", VA = "0x185D719B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5D7BCF0", Offset = "0x5D7A4F0", VA = "0x185D7BCF0", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D701A0", VA = "0x185D719A0", Slot = "4")]
	public bool Equals(KJNJJDIGKBN GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5D71B60", Offset = "0x5D70360", VA = "0x185D71B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public readonly struct JMAMHBBAHMA : IEquatable<JMAMHBBAHMA>
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly JMAMHBBAHMA KOOCNEMHOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly JEDJBKOCEME ADMPFLAIEKN;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public JEDJBKOCEME MIIIPHIJIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(JEDJBKOCEME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public EEKEIMNDBGI HAMOKPMJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public BFNIBHHKBLF KMBMFNEKLGM
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(BFNIBHHKBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public DJDJGHADPGK IABBJBIJJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(DJDJGHADPGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private HOKKMAFBPHI HMDFIBLPPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5D71B00", Offset = "0x5D70300", VA = "0x185D71B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private GIMAKLLKNAL JBIHOCPBPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5D7A010", Offset = "0x5D78810", VA = "0x185D7A010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private GKGBAHAPFBD NEJEOFONMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5D7A860", Offset = "0x5D79060", VA = "0x185D7A860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public LKEHPHAMPJC EEDAPMMOAEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5D7AAD0", Offset = "0x5D792D0", VA = "0x185D7AAD0")]
		get
		{
			return default(LKEHPHAMPJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public IEnumerable<EEKEIMNDBGI> IAJODELCOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x5D7A370", Offset = "0x5D78B70", VA = "0x185D7A370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public IEnumerable<EEKEIMNDBGI> ODBHDDOMCMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5D7A1E0", Offset = "0x5D789E0", VA = "0x185D7A1E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public int HOEFFIKONMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5D7A150", Offset = "0x5D78950", VA = "0x185D7A150")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int NIKJMKBNMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5D7A7A0", Offset = "0x5D78FA0", VA = "0x185D7A7A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public string MJLCABAKOPI
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5D7A0A0", Offset = "0x5D788A0", VA = "0x185D7A0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public IDGPFAGGINB KMMBCIOFOCI
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5D7A6D0", Offset = "0x5D78ED0", VA = "0x185D7A6D0")]
		get
		{
			return default(IDGPFAGGINB);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5D7A7F0", Offset = "0x5D78FF0", VA = "0x185D7A7F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public MKPMEJLHKCN AKIJILEDGFB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5D7AA70", Offset = "0x5D79270", VA = "0x185D7AA70")]
		get
		{
			return default(MKPMEJLHKCN);
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5D7AA00", Offset = "0x5D79200", VA = "0x185D7AA00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool DCEEHMPEBBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5D7A990", Offset = "0x5D79190", VA = "0x185D7A990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool HMJBOIMFJJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5D7AE10", Offset = "0x5D79610", VA = "0x185D7AE10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool JOHDFIICJNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5D7A920", Offset = "0x5D79120", VA = "0x185D7A920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool HGKFHJOEBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5D7A4E0", Offset = "0x5D78CE0", VA = "0x185D7A4E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool NDLDMCLPNDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5D7A8C0", Offset = "0x5D790C0", VA = "0x185D7A8C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5D79DD0", Offset = "0x5D785D0", VA = "0x185D79DD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool CMOOICMOPKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5D7A310", Offset = "0x5D78B10", VA = "0x185D7A310")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5D7A660", Offset = "0x5D78E60", VA = "0x185D7A660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00")]
	public JMAMHBBAHMA(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5D71F60", Offset = "0x5D70760", VA = "0x185D71F60")]
	public static bool DAOGIJOJDNF(JMAMHBBAHMA IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5D719B0", Offset = "0x5D701B0", VA = "0x185D719B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5D7A550", Offset = "0x5D78D50", VA = "0x185D7A550", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D701A0", VA = "0x185D719A0", Slot = "4")]
	public bool Equals(JMAMHBBAHMA GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5D71B60", Offset = "0x5D70360", VA = "0x185D71B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0xA207E0", Offset = "0xA1EFE0", VA = "0x180A207E0")]
	public static EEKEIMNDBGI DAOGIJOJDNF(JMAMHBBAHMA DJDFFLPPHHA)
	{
		return default(EEKEIMNDBGI);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5D79FF0", Offset = "0x5D787F0", VA = "0x185D79FF0")]
	public bool BIALBLFPNOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5D7A730", Offset = "0x5D78F30", VA = "0x185D7A730")]
	public bool JJLJHJJNIPB(FKFBMKLOGHG BDGFIKIEHCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5D7A5E0", Offset = "0x5D78DE0", VA = "0x185D7A5E0")]
	public void FJEKAADIGDH(FKFBMKLOGHG BDGFIKIEHCP, bool IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5D79E40", Offset = "0x5D78640", VA = "0x185D79E40")]
	public LKEHPHAMPJC BCHOGEJGBHC(Allocator OPPHPFNHPMG)
	{
		return default(LKEHPHAMPJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5D7AB90", Offset = "0x5D79390", VA = "0x185D7AB90")]
	public void PDNFCHNGCND(JMAMHBBAHMA GHNNCJBDHKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct NEBILGHFDIL : IEquatable<NEBILGHFDIL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JEDJBKOCEME ADMPFLAIEKN;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public EEKEIMNDBGI HAMOKPMJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5D719B0", Offset = "0x5D701B0", VA = "0x185D719B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5D7D650", Offset = "0x5D7BE50", VA = "0x185D7D650", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D701A0", VA = "0x185D719A0", Slot = "4")]
	public bool Equals(NEBILGHFDIL GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5D71B60", Offset = "0x5D70360", VA = "0x185D71B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct NNMPHMMLMAL : IEquatable<NNMPHMMLMAL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly JEDJBKOCEME ADMPFLAIEKN;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public EEKEIMNDBGI HAMOKPMJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private HOKKMAFBPHI HMDFIBLPPLC
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5D71B00", Offset = "0x5D70300", VA = "0x185D71B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00")]
	public NNMPHMMLMAL(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5D719B0", Offset = "0x5D701B0", VA = "0x185D719B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5D7D990", Offset = "0x5D7C190", VA = "0x185D7D990", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D701A0", VA = "0x185D719A0", Slot = "4")]
	public bool Equals(NNMPHMMLMAL GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5D71B60", Offset = "0x5D70360", VA = "0x185D71B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5D7DAC0", Offset = "0x5D7C2C0", VA = "0x185D7DAC0")]
	public void LJGAFCKKELL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5D7DA20", Offset = "0x5D7C220", VA = "0x185D7DA20")]
	public void GFLGNEDPNAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct PJIAINMBOGN : IEquatable<PJIAINMBOGN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly JEDJBKOCEME ADMPFLAIEKN;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public EEKEIMNDBGI HAMOKPMJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5D719B0", Offset = "0x5D701B0", VA = "0x185D719B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5D808E0", Offset = "0x5D7F0E0", VA = "0x185D808E0", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D701A0", VA = "0x185D719A0", Slot = "4")]
	public bool Equals(PJIAINMBOGN GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5D71B60", Offset = "0x5D70360", VA = "0x185D71B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct OGNKDOJPIDG : IEquatable<OGNKDOJPIDG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly JEDJBKOCEME ADMPFLAIEKN;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public EEKEIMNDBGI HAMOKPMJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5D719B0", Offset = "0x5D701B0", VA = "0x185D719B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5D7E450", Offset = "0x5D7CC50", VA = "0x185D7E450", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D701A0", VA = "0x185D719A0", Slot = "4")]
	public bool Equals(OGNKDOJPIDG GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5D71B60", Offset = "0x5D70360", VA = "0x185D71B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct PFNPDINDJJO : IEquatable<PFNPDINDJJO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly JEDJBKOCEME ADMPFLAIEKN;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public EEKEIMNDBGI HAMOKPMJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5D719B0", Offset = "0x5D701B0", VA = "0x185D719B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5D7FBE0", Offset = "0x5D7E3E0", VA = "0x185D7FBE0", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D701A0", VA = "0x185D719A0", Slot = "4")]
	public bool Equals(PFNPDINDJJO GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5D71B60", Offset = "0x5D70360", VA = "0x185D71B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct NCFPDLODHBG : IEquatable<NCFPDLODHBG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly JEDJBKOCEME ADMPFLAIEKN;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public EEKEIMNDBGI HAMOKPMJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5D719B0", Offset = "0x5D701B0", VA = "0x185D719B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5D7D0E0", Offset = "0x5D7B8E0", VA = "0x185D7D0E0", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D701A0", VA = "0x185D719A0", Slot = "4")]
	public bool Equals(NCFPDLODHBG GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5D71B60", Offset = "0x5D70360", VA = "0x185D71B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct DJDJGHADPGK : IEquatable<DJDJGHADPGK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly JEDJBKOCEME ADMPFLAIEKN;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public JEDJBKOCEME MIIIPHIJIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(JEDJBKOCEME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public EEKEIMNDBGI HAMOKPMJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private HOKKMAFBPHI HMDFIBLPPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x5D71B00", Offset = "0x5D70300", VA = "0x185D71B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private GIMAKLLKNAL JBIHOCPBPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5D75BA0", Offset = "0x5D743A0", VA = "0x185D75BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private GKGBAHAPFBD NEJEOFONMHP
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5D75F10", Offset = "0x5D74710", VA = "0x185D75F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public JEDJBKOCEME HDPACEHHKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5D75E80", Offset = "0x5D74680", VA = "0x185D75E80")]
		get
		{
			return default(JEDJBKOCEME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public EEKEIMNDBGI BPJPJIKDALM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5D75CC0", Offset = "0x5D744C0", VA = "0x185D75CC0")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public EEKEIMNDBGI AAPMKHJIGLO
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5D75C30", Offset = "0x5D74430", VA = "0x185D75C30")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00")]
	public DJDJGHADPGK(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5D719B0", Offset = "0x5D701B0", VA = "0x185D719B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5D75DF0", Offset = "0x5D745F0", VA = "0x185D75DF0", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D701A0", VA = "0x185D719A0", Slot = "4")]
	public bool Equals(DJDJGHADPGK GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5D71B60", Offset = "0x5D70360", VA = "0x185D71B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5D75F70", Offset = "0x5D74770", VA = "0x185D75F70")]
	public bool OABOCDMKFCC(EEKEIMNDBGI KLGMOMIJPLM, bool PMNMIAAPPOK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5D75D50", Offset = "0x5D74550", VA = "0x185D75D50")]
	public bool EHHMCMCJOLD(EEKEIMNDBGI INIMKGAHAEJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public readonly struct IMBGJOIJNNH : IEquatable<IMBGJOIJNNH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly JEDJBKOCEME ADMPFLAIEKN;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public EEKEIMNDBGI HAMOKPMJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public string HCNBCPLJCJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5D790F0", Offset = "0x5D778F0", VA = "0x185D790F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public string IAAKPICBMBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5D79010", Offset = "0x5D77810", VA = "0x185D79010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00")]
	public IMBGJOIJNNH(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5D719B0", Offset = "0x5D701B0", VA = "0x185D719B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5D78F80", Offset = "0x5D77780", VA = "0x185D78F80", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D701A0", VA = "0x185D719A0", Slot = "4")]
	public bool Equals(IMBGJOIJNNH GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5D71B60", Offset = "0x5D70360", VA = "0x185D71B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct GGDHBOOJAFP : IEquatable<GGDHBOOJAFP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly JEDJBKOCEME ADMPFLAIEKN;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public EEKEIMNDBGI HAMOKPMJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5D719B0", Offset = "0x5D701B0", VA = "0x185D719B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5D77440", Offset = "0x5D75C40", VA = "0x185D77440", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D701A0", VA = "0x185D719A0", Slot = "4")]
	public bool Equals(GGDHBOOJAFP GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5D71B60", Offset = "0x5D70360", VA = "0x185D71B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct CKLOBGIPPGP : IEquatable<CKLOBGIPPGP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly JEDJBKOCEME ADMPFLAIEKN;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public EEKEIMNDBGI HAMOKPMJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00")]
	public CKLOBGIPPGP(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5D719B0", Offset = "0x5D701B0", VA = "0x185D719B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5D75B10", Offset = "0x5D74310", VA = "0x185D75B10", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D701A0", VA = "0x185D719A0", Slot = "4")]
	public bool Equals(CKLOBGIPPGP GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5D71B60", Offset = "0x5D70360", VA = "0x185D71B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5D759A0", Offset = "0x5D741A0", VA = "0x185D759A0")]
	public bool CNAHNBBCCOG([Out] Collider AFMGELLDLJH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct OOJJHMDPNJF : IEquatable<OOJJHMDPNJF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly JEDJBKOCEME ADMPFLAIEKN;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public JEDJBKOCEME MIIIPHIJIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(JEDJBKOCEME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public EEKEIMNDBGI HAMOKPMJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private HOKKMAFBPHI HMDFIBLPPLC
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x5D71B00", Offset = "0x5D70300", VA = "0x185D71B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private GIMAKLLKNAL JBIHOCPBPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x5D7ECE0", Offset = "0x5D7D4E0", VA = "0x185D7ECE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private MIOPMFJJHFP ONMIIGFKGEC
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x5D7FA70", Offset = "0x5D7E270", VA = "0x185D7FA70")]
		get
		{
			return default(MIOPMFJJHFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool DMNBHNKPJBC
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F7E0", Offset = "0x5D7DFE0", VA = "0x185D7F7E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool AJEMEOAMLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x5D7EF30", Offset = "0x5D7D730", VA = "0x185D7EF30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool IALLKMPJPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x5D7EEC0", Offset = "0x5D7D6C0", VA = "0x185D7EEC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool MILFFGAMIAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F200", Offset = "0x5D7DA00", VA = "0x185D7F200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool NNJIFLBLPON
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x5D7EE50", Offset = "0x5D7D650", VA = "0x185D7EE50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool HFEHGDDAMJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x5D7ED70", Offset = "0x5D7D570", VA = "0x185D7ED70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool OHDCKCINFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F480", Offset = "0x5D7DC80", VA = "0x185D7F480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool JNIEHKJGIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x5D7EC10", Offset = "0x5D7D410", VA = "0x185D7EC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool EPCHCNMIOEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F270", Offset = "0x5D7DA70", VA = "0x185D7F270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool OMAHKHFJEFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x5D7FA00", Offset = "0x5D7E200", VA = "0x185D7FA00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool PPKLGCGOILE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F770", Offset = "0x5D7DF70", VA = "0x185D7F770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool IHNNLIKGHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F690", Offset = "0x5D7DE90", VA = "0x185D7F690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool PNGJAGLLMOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F4F0", Offset = "0x5D7DCF0", VA = "0x185D7F4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool FIDLHPKHONE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F700", Offset = "0x5D7DF00", VA = "0x185D7F700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool IPKHINIBHGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x5D7EDE0", Offset = "0x5D7D5E0", VA = "0x185D7EDE0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F2E0", Offset = "0x5D7DAE0", VA = "0x185D7F2E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool HCFELOKPHGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5D7EFA0", Offset = "0x5D7D7A0", VA = "0x185D7EFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public MGGMMJMNCIF OCGLGPPFJGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5D7EC80", Offset = "0x5D7D480", VA = "0x185D7EC80")]
		get
		{
			return default(MGGMMJMNCIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool JLKPKCPEMNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F350", Offset = "0x5D7DB50", VA = "0x185D7F350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public Vector3 CDJNFNHOAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F3B0", Offset = "0x5D7DBB0", VA = "0x185D7F3B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 EKCOBBJNLJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F5E0", Offset = "0x5D7DDE0", VA = "0x185D7F5E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool PMKFLCDPBDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F890", Offset = "0x5D7E090", VA = "0x185D7F890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00")]
	public OOJJHMDPNJF(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x5D719B0", Offset = "0x5D701B0", VA = "0x185D719B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x5D7F170", Offset = "0x5D7D970", VA = "0x185D7F170", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D701A0", VA = "0x185D719A0", Slot = "4")]
	public bool Equals(OOJJHMDPNJF GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x5D71B60", Offset = "0x5D70360", VA = "0x185D71B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D7F820", Offset = "0x5D7E020", VA = "0x185D7F820")]
	public bool MGIJFPHDNJJ(EPPPDPOLJMF BDGFIKIEHCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D7F990", Offset = "0x5D7E190", VA = "0x185D7F990")]
	public bool NIACELFOLNH(ANBGLIGJGHH BDGFIKIEHCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5D7F560", Offset = "0x5D7DD60", VA = "0x185D7F560")]
	public void JMKAFFKNEAH(ANBGLIGJGHH BDGFIKIEHCP, bool JOHPJDFABPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct AABMLEJPFBC : IEquatable<AABMLEJPFBC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly JEDJBKOCEME ADMPFLAIEKN;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public JEDJBKOCEME MIIIPHIJIPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(JEDJBKOCEME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public EEKEIMNDBGI HAMOKPMJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private HOKKMAFBPHI HMDFIBLPPLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5D71B00", Offset = "0x5D70300", VA = "0x185D71B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private GIMAKLLKNAL JBIHOCPBPAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x5D71880", Offset = "0x5D70080", VA = "0x185D71880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00")]
	public AABMLEJPFBC(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D719B0", Offset = "0x5D701B0", VA = "0x185D719B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D71910", Offset = "0x5D70110", VA = "0x185D71910", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D701A0", VA = "0x185D719A0", Slot = "4")]
	public bool Equals(AABMLEJPFBC GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5D71B60", Offset = "0x5D70360", VA = "0x185D71B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5D719E0", Offset = "0x5D701E0", VA = "0x185D719E0")]
	public void JCDNFBLLCNJ(bool IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5D71A70", Offset = "0x5D70270", VA = "0x185D71A70")]
	public void LGCIEALPAHC(bool IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x29A0FC0", Offset = "0x299F7C0", VA = "0x1829A0FC0")]
	public T HLHKDLIDLEI<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct ADEFEJOLDHC : IEquatable<ADEFEJOLDHC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly JEDJBKOCEME ADMPFLAIEKN;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public JEDJBKOCEME MIIIPHIJIPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(JEDJBKOCEME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public EEKEIMNDBGI HAMOKPMJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private HOKKMAFBPHI HMDFIBLPPLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5D71B00", Offset = "0x5D70300", VA = "0x185D71B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private GIMAKLLKNAL JBIHOCPBPAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5D71E00", Offset = "0x5D70600", VA = "0x185D71E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private ALHOKAPBJCK BCNGLBJOPGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D71DA0", Offset = "0x5D705A0", VA = "0x185D71DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool FOHLCEBFGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5D71D10", Offset = "0x5D70510", VA = "0x185D71D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool EDBGCDFPMBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5D71E90", Offset = "0x5D70690", VA = "0x185D71E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool LBDGPGGMCJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5D71F30", Offset = "0x5D70730", VA = "0x185D71F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool BLEINLMBJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x5D72760", Offset = "0x5D70F60", VA = "0x185D72760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool GHKNDPCLBLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5D72010", Offset = "0x5D70810", VA = "0x185D72010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool ECKHEKGIANI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5D724E0", Offset = "0x5D70CE0", VA = "0x185D724E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool FKCCPELHJON
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5D72370", Offset = "0x5D70B70", VA = "0x185D72370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00")]
	public ADEFEJOLDHC(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5D71F60", Offset = "0x5D70760", VA = "0x185D71F60")]
	public static bool DAOGIJOJDNF(ADEFEJOLDHC IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5D719B0", Offset = "0x5D701B0", VA = "0x185D719B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5D71F80", Offset = "0x5D70780", VA = "0x185D71F80", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D701A0", VA = "0x185D719A0", Slot = "4")]
	public bool Equals(ADEFEJOLDHC GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5D71B60", Offset = "0x5D70360", VA = "0x185D71B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5D72140", Offset = "0x5D70940", VA = "0x185D72140")]
	public bool INPLNKBICEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5D720A0", Offset = "0x5D708A0", VA = "0x185D720A0")]
	public EEKEIMNDBGI HHKOPFPKPJK(EEKEIMNDBGI HBMBMELELPF)
	{
		return default(EEKEIMNDBGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5D72260", Offset = "0x5D70A60", VA = "0x185D72260")]
	public JEDJBKOCEME KANHHKENMMA()
	{
		return default(JEDJBKOCEME);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct HAEFPOHFJCO : IEquatable<HAEFPOHFJCO>
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly HAEFPOHFJCO KOOCNEMHOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly JEDJBKOCEME ADMPFLAIEKN;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public JEDJBKOCEME MIIIPHIJIPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(JEDJBKOCEME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public EEKEIMNDBGI HAMOKPMJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public BFNIBHHKBLF KMBMFNEKLGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(BFNIBHHKBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	private MDENMGPCIHC FILHDAGLPIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5D775F0", Offset = "0x5D75DF0", VA = "0x185D775F0")]
		get
		{
			return default(MDENMGPCIHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public HIMLNGICGIK LDNLHJJDHAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5D777B0", Offset = "0x5D75FB0", VA = "0x185D777B0")]
		get
		{
			return default(HIMLNGICGIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public OCHEGPFGJLH FHDFCIGFAPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5D778E0", Offset = "0x5D760E0", VA = "0x185D778E0")]
		get
		{
			return default(OCHEGPFGJLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public CKDIFAAFGDN NBPJPAMABJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5D779A0", Offset = "0x5D761A0", VA = "0x185D779A0")]
		get
		{
			return default(CKDIFAAFGDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public IJCEPGAJEMC GIFOMBMFJCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x5D77B70", Offset = "0x5D76370", VA = "0x185D77B70")]
		get
		{
			return default(IJCEPGAJEMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public DGNJHIEONCC LNHOIGGNIFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x5D77940", Offset = "0x5D76140", VA = "0x185D77940")]
		get
		{
			return default(DGNJHIEONCC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x5D77C40", Offset = "0x5D76440", VA = "0x185D77C40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public JBMDKADPDLM DOGHILBAHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5D77BE0", Offset = "0x5D763E0", VA = "0x185D77BE0")]
		get
		{
			return default(JBMDKADPDLM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x5D77A00", Offset = "0x5D76200", VA = "0x185D77A00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public float ABHNBLFGKLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5D77880", Offset = "0x5D76080", VA = "0x185D77880")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5D77CB0", Offset = "0x5D764B0", VA = "0x185D77CB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public Vector3 JMFBKECOBDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x5D77570", Offset = "0x5D75D70", VA = "0x185D77570")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x5D77AF0", Offset = "0x5D762F0", VA = "0x185D77AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public float IKPOFBNHHNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D77810", Offset = "0x5D76010", VA = "0x185D77810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public NIBGBNOGEJK.AINLCGKGFIG IJCKCGAEBMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x5D776C0", Offset = "0x5D75EC0", VA = "0x185D776C0")]
		get
		{
			return default(NIBGBNOGEJK.AINLCGKGFIG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5D77650", Offset = "0x5D75E50", VA = "0x185D77650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00")]
	public HAEFPOHFJCO(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5D71F60", Offset = "0x5D70760", VA = "0x185D71F60")]
	public static bool DAOGIJOJDNF(HAEFPOHFJCO IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5D719B0", Offset = "0x5D701B0", VA = "0x185D719B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5D77720", Offset = "0x5D75F20", VA = "0x185D77720", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D701A0", VA = "0x185D719A0", Slot = "4")]
	public bool Equals(HAEFPOHFJCO GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5D71B60", Offset = "0x5D70360", VA = "0x185D71B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5D77D20", Offset = "0x5D76520", VA = "0x185D77D20")]
	public NFEMEFJAPJB NOBJGOPBFMG()
	{
		return default(NFEMEFJAPJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5D77A70", Offset = "0x5D76270", VA = "0x185D77A70")]
	public IIGOCDJOBNI JHADAABJMOP()
	{
		return default(IIGOCDJOBNI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct NFEMEFJAPJB : IEquatable<NFEMEFJAPJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly JEDJBKOCEME ADMPFLAIEKN;

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public JEDJBKOCEME MIIIPHIJIPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(JEDJBKOCEME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public EEKEIMNDBGI HAMOKPMJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public HAEFPOHFJCO OABJNCCGMCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(HAEFPOHFJCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	private LCINMADOIIA OAMAGPIGNHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x5D7D7D0", Offset = "0x5D7BFD0", VA = "0x185D7D7D0")]
		get
		{
			return default(LCINMADOIIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public DFMGIJCAPCL PCCGFCLBFOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x5D7D6E0", Offset = "0x5D7BEE0", VA = "0x185D7D6E0")]
		get
		{
			return default(DFMGIJCAPCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00")]
	public NFEMEFJAPJB(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D71F60", Offset = "0x5D70760", VA = "0x185D71F60")]
	public static bool DAOGIJOJDNF(NFEMEFJAPJB IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5D719B0", Offset = "0x5D701B0", VA = "0x185D719B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5D7D740", Offset = "0x5D7BF40", VA = "0x185D7D740", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D701A0", VA = "0x185D719A0", Slot = "4")]
	public bool Equals(NFEMEFJAPJB GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5D71B60", Offset = "0x5D70360", VA = "0x185D71B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[DefaultMember("Item")]
public readonly struct IIGOCDJOBNI : IEquatable<IIGOCDJOBNI>
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly IIGOCDJOBNI KOOCNEMHOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly JEDJBKOCEME ADMPFLAIEKN;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public JEDJBKOCEME MIIIPHIJIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(JEDJBKOCEME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public EEKEIMNDBGI HAMOKPMJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public BFNIBHHKBLF KMBMFNEKLGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(BFNIBHHKBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private HOKKMAFBPHI HMDFIBLPPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x5D71B00", Offset = "0x5D70300", VA = "0x185D71B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private GIMAKLLKNAL JBIHOCPBPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x5D78560", Offset = "0x5D76D60", VA = "0x185D78560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private FICELHLOKNG HLIFDNJKFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x5D78B40", Offset = "0x5D77340", VA = "0x185D78B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public HAEFPOHFJCO OABJNCCGMCC
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(HAEFPOHFJCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public BHBLOOFPBII HOGNGLGNEAB
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x5D78320", Offset = "0x5D76B20", VA = "0x185D78320")]
		get
		{
			return default(BHBLOOFPBII);
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5D78BA0", Offset = "0x5D773A0", VA = "0x185D78BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public IEnumerable<BKNPNCHAPIL> LOCDILGAIGG
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x5D78710", Offset = "0x5D76F10", VA = "0x185D78710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public BKNPNCHAPIL NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x5D78450", Offset = "0x5D76C50", VA = "0x185D78450")]
		get
		{
			return default(BKNPNCHAPIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x5D785F0", Offset = "0x5D76DF0", VA = "0x185D785F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00")]
	public IIGOCDJOBNI(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5D71F60", Offset = "0x5D70760", VA = "0x185D71F60")]
	public static bool DAOGIJOJDNF(IIGOCDJOBNI IFKKLLBODIE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x5D76D20", Offset = "0x5D75520", VA = "0x185D76D20")]
	public static bool PEFPHNLEPOM(IIGOCDJOBNI FABNAGLLOKN, IIGOCDJOBNI FCOICCIGANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x5D719B0", Offset = "0x5D701B0", VA = "0x185D719B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x5D78680", Offset = "0x5D76E80", VA = "0x185D78680", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D701A0", VA = "0x185D719A0", Slot = "4")]
	public bool Equals(IIGOCDJOBNI GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5D71B60", Offset = "0x5D70360", VA = "0x185D71B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5D78920", Offset = "0x5D77120", VA = "0x185D78920")]
	public BKNPNCHAPIL GAAGGFFDGKN(float3? OBAACBLACLC, [Optional] quaternion? AHLHKGGFBGH, [Optional] Vector3? CDLIHEJMBGO)
	{
		return default(BKNPNCHAPIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5D78D50", Offset = "0x5D77550", VA = "0x185D78D50")]
	public BKNPNCHAPIL PKOOMGJPBIH(int ADMJKDLHPCI, float3? OBAACBLACLC, [Optional] quaternion? AHLHKGGFBGH, [Optional] Vector3? CDLIHEJMBGO)
	{
		return default(BKNPNCHAPIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5D78210", Offset = "0x5D76A10", VA = "0x185D78210")]
	public void AANLEJDLNLP(int ADMJKDLHPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5D78CC0", Offset = "0x5D774C0", VA = "0x185D78CC0")]
	public void PAMPKEGOCOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct BKNPNCHAPIL : IEquatable<BKNPNCHAPIL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly JEDJBKOCEME ADMPFLAIEKN;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public JEDJBKOCEME MIIIPHIJIPF
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(JEDJBKOCEME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public EEKEIMNDBGI HAMOKPMJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public IIGOCDJOBNI JAIOFBKAOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5D752E0", Offset = "0x5D73AE0", VA = "0x185D752E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public float3 DHKCHGJHBAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5D75090", Offset = "0x5D73890", VA = "0x185D75090")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5D75520", Offset = "0x5D73D20", VA = "0x185D75520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public quaternion MHJIDDLHFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5D755A0", Offset = "0x5D73DA0", VA = "0x185D755A0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x5D75020", Offset = "0x5D73820", VA = "0x185D75020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public float3 NAGLMJAMGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x5D75260", Offset = "0x5D73A60", VA = "0x185D75260")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x5D75440", Offset = "0x5D73C40", VA = "0x185D75440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public OBANPEKKDOK AKBLLLAIBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x5D75370", Offset = "0x5D73B70", VA = "0x185D75370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private DENJCPPHLCG PIOLACKIHHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x5D75170", Offset = "0x5D73970", VA = "0x185D75170")]
		get
		{
			return default(DENJCPPHLCG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private GGDFJAPPJKF OGJPPPIPJDK
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x5D754C0", Offset = "0x5D73CC0", VA = "0x185D754C0")]
		get
		{
			return default(GGDFJAPPJKF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private EKDDEGIAPEP AIBNFKMACBI
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x5D75620", Offset = "0x5D73E20", VA = "0x185D75620")]
		get
		{
			return default(EKDDEGIAPEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private BBAPEFDFDEP FGOCONOCJGG
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x5D75110", Offset = "0x5D73910", VA = "0x185D75110")]
		get
		{
			return default(BBAPEFDFDEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	private FJCJKJLPANB HPCEIOAKDJA
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x5D753E0", Offset = "0x5D73BE0", VA = "0x185D753E0")]
		get
		{
			return default(FJCJKJLPANB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00")]
	public BKNPNCHAPIL(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5D719B0", Offset = "0x5D701B0", VA = "0x185D719B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5D751D0", Offset = "0x5D739D0", VA = "0x185D751D0", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D701A0", VA = "0x185D719A0", Slot = "4")]
	public bool Equals(BKNPNCHAPIL GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5D71B60", Offset = "0x5D70360", VA = "0x185D71B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x5D752E0", Offset = "0x5D73AE0", VA = "0x185D752E0")]
	public void HMJMJIAEDHN(IIGOCDJOBNI IFKKLLBODIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct BFNIBHHKBLF : IEquatable<BFNIBHHKBLF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly JEDJBKOCEME ADMPFLAIEKN;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public EEKEIMNDBGI HAMOKPMJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	private HOKKMAFBPHI HMDFIBLPPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x5D71B00", Offset = "0x5D70300", VA = "0x185D71B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private CECLHBPNMGM ACMGJAFMLFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x5D74870", Offset = "0x5D73070", VA = "0x185D74870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public bool IBALGBHCJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x5D745A0", Offset = "0x5D72DA0", VA = "0x185D745A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public Vector3 DHKCHGJHBAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x5D73140", Offset = "0x5D71940", VA = "0x185D73140")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x5D746D0", Offset = "0x5D72ED0", VA = "0x185D746D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public Quaternion MHJIDDLHFHH
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x5D74930", Offset = "0x5D73130", VA = "0x185D74930")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x5D72E90", Offset = "0x5D71690", VA = "0x185D72E90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public Vector3 ECMBGLIHDHE
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5D72C60", Offset = "0x5D71460", VA = "0x185D72C60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x5D73740", Offset = "0x5D71F40", VA = "0x185D73740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public Quaternion AMGJFKEDOLG
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5D73D30", Offset = "0x5D72530", VA = "0x185D73D30")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x5D73380", Offset = "0x5D71B80", VA = "0x185D73380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public float LDJBFELLNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5D74150", Offset = "0x5D72950", VA = "0x185D74150")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5D74CE0", Offset = "0x5D734E0", VA = "0x185D74CE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public float KOGDMHCCGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x5D72BC0", Offset = "0x5D713C0", VA = "0x185D72BC0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Vector3 NAGLMJAMGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x5D73AA0", Offset = "0x5D722A0", VA = "0x185D73AA0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5D74310", Offset = "0x5D72B10", VA = "0x185D74310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public Vector3 KDANMFMGHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x5D73E80", Offset = "0x5D72680", VA = "0x185D73E80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public Matrix4x4 FCECGHBOCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5D74EB0", Offset = "0x5D736B0", VA = "0x185D74EB0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00")]
	public BFNIBHHKBLF(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x5D719B0", Offset = "0x5D701B0", VA = "0x185D719B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x5D73810", Offset = "0x5D72010", VA = "0x185D73810", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D701A0", VA = "0x185D719A0", Slot = "4")]
	public bool Equals(BFNIBHHKBLF GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x5D71B60", Offset = "0x5D70360", VA = "0x185D71B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x5D74D90", Offset = "0x5D73590", VA = "0x185D74D90")]
	public FEDLPIHABFD OLNAILJGHLA()
	{
		return default(FEDLPIHABFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x5D741F0", Offset = "0x5D729F0", VA = "0x185D741F0")]
	public void JOIKHGMBBOF([Out] Matrix4x4 JBBMMCAIOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5D72D50", Offset = "0x5D71550", VA = "0x185D72D50")]
	public void BNBGHPKENHC([Out] Vector3 APKHABFECKC, [Out] Quaternion DDIKAJJHFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5D735C0", Offset = "0x5D71DC0", VA = "0x185D735C0")]
	public void EJPJNKLKFNO([Out] RigidTransform PODEKJEMHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x5D74B20", Offset = "0x5D73320", VA = "0x185D74B20")]
	public PKIFHEFFKDB OCEAALMECOG()
	{
		return default(PKIFHEFFKDB);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x5D74B50", Offset = "0x5D73350", VA = "0x185D74B50")]
	public void OCEAALMECOG([Out] PKIFHEFFKDB NINJNMPBFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x5D745E0", Offset = "0x5D72DE0", VA = "0x185D745E0")]
	public PKIFHEFFKDB KPHOOGAOAGF()
	{
		return default(PKIFHEFFKDB);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x5D74610", Offset = "0x5D72E10", VA = "0x185D74610")]
	public void KPHOOGAOAGF([Out] PKIFHEFFKDB PODEKJEMHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x5D73F70", Offset = "0x5D72770", VA = "0x185D73F70")]
	public Vector3 IHGFPBPPIPI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x5D73B90", Offset = "0x5D72390", VA = "0x185D73B90")]
	public void HBBHLLMBFHE([In] Vector3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x5D72F60", Offset = "0x5D71760", VA = "0x185D72F60")]
	public Vector3 CCMLCBBPAHG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x5D73450", Offset = "0x5D71C50", VA = "0x185D73450")]
	public void DPECHGGPJEI([In] Vector3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x5D73230", Offset = "0x5D71A30", VA = "0x185D73230")]
	public Quaternion CGFFHINEJNH()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x5D73670", Offset = "0x5D71E70", VA = "0x185D73670")]
	public void ELMILBICGGO([In] Quaternion IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x5D738A0", Offset = "0x5D720A0", VA = "0x185D738A0")]
	public Quaternion FEBHODBBOCG()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x5D73C60", Offset = "0x5D72460", VA = "0x185D73C60")]
	public void HOAELCHFHGH([In] Quaternion IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5D73520", Offset = "0x5D71D20", VA = "0x185D73520")]
	public float EJOPFAAHEAG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x5D74EF0", Offset = "0x5D736F0", VA = "0x185D74EF0")]
	public void PEPPDALBKEN(float IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x5D74A80", Offset = "0x5D73280", VA = "0x185D74A80")]
	public float OAFGKNILALL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x5D739F0", Offset = "0x5D721F0", VA = "0x185D739F0")]
	public void FHKELFMBAKA(float IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x5D74C10", Offset = "0x5D73410", VA = "0x185D74C10")]
	public void OFDIEADNOLH([In] Vector3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x5D73050", Offset = "0x5D71850", VA = "0x185D73050")]
	public Vector3 CEINPCLGFLC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x5D744D0", Offset = "0x5D72CD0", VA = "0x185D744D0")]
	public void KHJHELBEAPB([In] Vector3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5D74060", Offset = "0x5D72860", VA = "0x185D74060")]
	public Vector3 IHOJOHHJHEF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x5D74DE0", Offset = "0x5D735E0", VA = "0x185D74DE0")]
	public void OMNLGNICBHB([In] Vector3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x5D743E0", Offset = "0x5D72BE0", VA = "0x185D743E0")]
	public Vector3 KDOEDCEPBPD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x5D747A0", Offset = "0x5D72FA0", VA = "0x185D747A0")]
	public void MDIJLBBADLH([In] Vector3 IFKKLLBODIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class CKKFCKCFAAE
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private struct BCLNALEJPKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public Guid ACBJLDAEBBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public LDJJIDDDIBJ NLKBHDBADEE;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct LDJJIDDDIBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int IFKKLLBODIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int PGIPLHIBKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int CCBKBFLFKDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int KHIOKGJBMDO;

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x5D7C400", Offset = "0x5D7AC00", VA = "0x185D7C400")]
		public bool ABCOMOGDEBC([Out] KLEIPEFFJCP LFHNIGHPLBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x5D7C480", Offset = "0x5D7AC80", VA = "0x185D7C480")]
		public LDJJIDDDIBJ(KLEIPEFFJCP LFHNIGHPLBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x5D758F0", Offset = "0x5D740F0", VA = "0x185D758F0")]
	public static Guid AGBNFMNAMLN(this KLEIPEFFJCP LFHNIGHPLBN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x5D75980", Offset = "0x5D74180", VA = "0x185D75980")]
	public static bool CKAFGFBEMJM(this Guid ACBJLDAEBBN, [Out] KLEIPEFFJCP LFHNIGHPLBN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal static class LPEMNNAHIHN
{
	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x5D7CBF0", Offset = "0x5D7B3F0", VA = "0x185D7CBF0")]
	public static GIMAKLLKNAL JBIHOCPBPAP(this JEDJBKOCEME LJHGKCLAIHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x5D7CB20", Offset = "0x5D7B320", VA = "0x185D7CB20")]
	public static HLLCKCNCCJD HIGJMHAGADA(this JEDJBKOCEME LJHGKCLAIHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x5D7CC80", Offset = "0x5D7B480", VA = "0x185D7CC80")]
	public static EntityManager NHMANGHHOMH(this JEDJBKOCEME LJHGKCLAIHG)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x2456B80", Offset = "0x2455380", VA = "0x182456B80")]
	public static T HIKPDMGBNLM<T>(this JEDJBKOCEME LJHGKCLAIHG) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x2456970", Offset = "0x2455170", VA = "0x182456970")]
	public static bool AJAAGDHIJIM<T>(this JEDJBKOCEME LJHGKCLAIHG) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface NOFHMIDEIDD
{
	[Cpp2IlInjected.Token(Token = "0x17000103")]
	Guid POGMJMAHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task INKDINOAHKD(Guid HCBNGKDJCPO, Guid DEOHJMHDGFJ);

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task FOLIJCJIILB(JEDJBKOCEME ABFOGBKLNKN);

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DPPJIFKAFJL(JEDJBKOCEME JDEFHCADEPK, JEDJBKOCEME KLGMOMIJPLM, [Out] Vector3 LHFDFHNAOOD, [Out] Quaternion CPFEILLBOLJ);

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FDJGDNEJCIN(OBODBJKNAJN AMAPEBNIFNL, Vector3 LHFDFHNAOOD, Quaternion CPFEILLBOLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public interface ALLPNMMCFOG
{
	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JIJMCBPOPLD(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EEIIPDLDMJM(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EIOBLOPDBJG(JEDJBKOCEME JBPJNGFGLPC, [Out] Guid GHAIFMOEMBF);

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid OPLDHECNLON(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ODKAAPPFPBO(JEDJBKOCEME JBPJNGFGLPC, Guid GHAIFMOEMBF);

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AIOGPADGMDO(JEDJBKOCEME JBPJNGFGLPC, [Out] Guid PCPOCGCMPJO);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid HOCFDAIAFLL(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NCIKPNOMIED(JEDJBKOCEME JBPJNGFGLPC, Guid PCPOCGCMPJO);

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KAMCNLOJOMB(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DEIMECNJIGL(JEDJBKOCEME JDEFHCADEPK, JEDJBKOCEME KLGMOMIJPLM);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
public interface GGDHIKOIDJD
{
	[Cpp2IlInjected.Token(Token = "0x17000104")]
	Guid POGMJMAHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIDEOHKFANP(Guid GHAIFMOEMBF, Guid PCPOCGCMPJO, string BOBHOMKFHJB);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface EIGPEOIKDPK
{
	[Cpp2IlInjected.Token(Token = "0x17000105")]
	IReadOnlyCollection<NGLBPOGABCB> ALPOIMOAEHM
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GAALDGDBBOE(int GIBOEKFJFBH, [Out] NGLBPOGABCB DKBOLDMDFGM);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NGLBPOGABCB HKJDFBCMHMP(Type BJKOKHNAAID);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class FLPJKPKAPCP
{
	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x2376760", Offset = "0x2374F60", VA = "0x182376760")]
	public static T KENOOPILGCD<T>(this EIGPEOIKDPK IPCIGPCKHNO, Entity MFFDEAINOPL) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x2375DD0", Offset = "0x23745D0", VA = "0x182375DD0")]
	public static NGLBPOGABCB HKJDFBCMHMP<T>(this EIGPEOIKDPK IPCIGPCKHNO) where T : struct, IComponent
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
public interface FLFBKAFPGOO
{
	[Cpp2IlInjected.Token(Token = "0x17000106")]
	Func<FAFPMDAFMJH> PDDCFGOIPDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<JEDJBKOCEME, JEDJBKOCEME> EMMFDAGNMKC;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<JEDJBKOCEME, JEDJBKOCEME> CCACHDHBGCN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<JEDJBKOCEME, JEDJBKOCEME, JEDJBKOCEME> DCNKJJMPIND;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<JEDJBKOCEME> FLNBKIJCEPM;

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GLBIBCAPKCD(JEDJBKOCEME JBPJNGFGLPC, int ADCGCEAHPOG);

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float3 IKHFCADGODI(JEDJBKOCEME JBPJNGFGLPC, int ADCGCEAHPOG);

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool KPICGGKADCC(JEDJBKOCEME JBPJNGFGLPC, JEDJBKOCEME PFHLHDBEOOD);

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	JEDJBKOCEME ENBJCEJNJMC(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<JEDJBKOCEME> NHIKPKIKCHH(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	JEDJBKOCEME ANFFDKGHAPF(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DFLMEMMFCBP(JEDJBKOCEME JBPJNGFGLPC, Vector3 FPDDPNFNLKP, Quaternion LIKNMKOHLDB);

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OOIOJBCOOGF(JEDJBKOCEME JBPJNGFGLPC, float MAJLENJGEMK);

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool NEBPLLMDODA(JEDJBKOCEME JBPJNGFGLPC, [Out] RigidTransform FONOJOLCEDD);

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool GGDFEGBNEPC(JEDJBKOCEME JBPJNGFGLPC, [Out] float PFGGCCINGHD);

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 IPFBPJDBNDF(KJNJJDIGKBN FEFPHEAOMGP);

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(Slot = "21")]
	quaternion GNMKCONEBLP(KJNJJDIGKBN FEFPHEAOMGP);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class IJDHFCDOOGI
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
public interface HDMGEIDHKCL
{
	[Cpp2IlInjected.Token(Token = "0x17000107")]
	object LJGLFJEDLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFAPJEDBGJA(LKEHPHAMPJC MGOMOGOCFIB);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface FAFPMDAFMJH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000108")]
	LocalId FEEFFHBCANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	LocalId PHOEMMBKKLB
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
	void OIAJOKNAJNB(float3 LHFDFHNAOOD);

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LFEBEPONPEA(float3 LHFDFHNAOOD);

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KEMADNFCAIO([Out] float3 IAIBEBECMJB, [Out] float3 BMNCKBBLELB);

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AEAEIDKPOHG(float3 IAIBEBECMJB, float3 BMNCKBBLELB);

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EPNMEBJGNIH(Color IAIBEBECMJB, Color BMNCKBBLELB);

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FAFPMDAFMJH Instantiate(Transform KHFCFAPNPDN);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface HGJIBOOANGO
{
	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJKJMKCCJMD(Transform KHFCFAPNPDN, FAFPMDAFMJH MMFLEPIKAEM);

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FAFPMDAFMJH PDDCFGOIPDF();
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum MNFBAAHKEIO
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class NFLLONNOHHB
{
	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0xA8A550", Offset = "0xA88D50", VA = "0x180A8A550")]
	public static bool KAPMHPBCKOI(this MNFBAAHKEIO KAFJGNMGLLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0xA8A540", Offset = "0xA88D40", VA = "0x180A8A540")]
	public static bool GECDKOLCDON(this MNFBAAHKEIO KAFJGNMGLLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1950", Offset = "0x1FA0150", VA = "0x181FA1950")]
	public static bool JEOPMMNMNNK(this MNFBAAHKEIO KAFJGNMGLLD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface JDCOPOKIPOM
{
	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	MNFBAAHKEIO NMCOEMBMGII
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	MNFBAAHKEIO FLCKHBFKILB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	MNFBAAHKEIO HNDLGNHGPIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	MNFBAAHKEIO FGACGACICLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	MNFBAAHKEIO DPMJCCMAIMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	MNFBAAHKEIO FGPEGCEMNMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	MNFBAAHKEIO DMOAKNOPDFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	MNFBAAHKEIO IDHALOIJDJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	MNFBAAHKEIO NPGBHPCMHEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	MNFBAAHKEIO EKGIBGFKKJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	MNFBAAHKEIO FCBNLHCPKCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	MNFBAAHKEIO OKOLLGNKKPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public interface GKGBAHAPFBD
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<HCBGKMEOBBG> GAALPPINDPM;

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JEDJBKOCEME OEBJBPNCIBI(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AIEGMIMLKAE(List<JEDJBKOCEME> BELHJIJANEK);

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JEDJBKOCEME KAHCMOIEBOO(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OABOCDMKFCC(JEDJBKOCEME JBPJNGFGLPC, JEDJBKOCEME KLGMOMIJPLM, bool PMNMIAAPPOK);

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LKMEJDMDFEJ(JEDJBKOCEME JBPJNGFGLPC, JEDJBKOCEME KLGMOMIJPLM);

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int FAGDHMFPDCE(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LKEHPHAMPJC MEPAMCFEHGM(JEDJBKOCEME ADMPFLAIEKN);

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool DGPBLLKPAEP(JEDJBKOCEME JBPJNGFGLPC, JEDJBKOCEME HBIJIKOLFNL);

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool EHHMCMCJOLD(JEDJBKOCEME JBPJNGFGLPC, JEDJBKOCEME INIMKGAHAEJ);

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	JEDJBKOCEME HJLGGCKIIPA(JEDJBKOCEME HBMBMELELPF, JEDJBKOCEME OPFJANEEJKH);

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool EPHMNKOPEON(JEDJBKOCEME HBMBMELELPF, JEDJBKOCEME OPFJANEEJKH, [Out] JEDJBKOCEME NIPMIADLFPJ);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class CBIIMLNFOJM
{
	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x5D75680", Offset = "0x5D73E80", VA = "0x185D75680")]
	public static List<JEDJBKOCEME> AIEGMIMLKAE(this GKGBAHAPFBD IGBOANLHLEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x5D75790", Offset = "0x5D73F90", VA = "0x185D75790")]
	public static bool LEPHDAKBGCH(this GKGBAHAPFBD IGBOANLHLEL, JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
public interface HDJPIOFEPJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000116")]
	bool NHJFFHINDIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	bool OANLFGFOFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public interface IJGBKLONMFB : ICIOAGALKFA
{
	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KJPNOOMBEMH FBGDFKDPALJ(Entity MFFDEAINOPL);

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGKIELIANDK(NativeArray<KJPNOOMBEMH> FOJKHBGCMEP, NativeArray<BIJOGOIADPC> DPMIOBOIGFA);

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OKIABKAIMMK(KJPNOOMBEMH FJFHMLGEMLM);

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NIOIIDPGMGC(KJPNOOMBEMH FJFHMLGEMLM, [Out] Collider AFMGELLDLJH);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
public interface ICIOAGALKFA
{
	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GAKHGBNKMAO([In] float3 JAKDKBMGPIO, [In] float3 CFFFGOJOPLK, float NCCGMAJNKDF, Allocator OPPHPFNHPMG, [Out] NativeArray<Entity> EFLDIIILPLM);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
public interface AAKMNAOGINP
{
	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GAKHGBNKMAO([In] float3 JAKDKBMGPIO, [In] float3 CFFFGOJOPLK, float NCCGMAJNKDF, [Out] EJJHCOFCEKO HCELIOKKCLG, [Out] JEDJBKOCEME CPJMAEMAJBC);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
public interface JPEDMCPMCEO
{
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GAKHGBNKMAO([In] NativeArray<Entity> EFLDIIILPLM, [In] float3 JAKDKBMGPIO, [In] float3 CFFFGOJOPLK, [In] NativeArray<EJJHCOFCEKO> NIKNKKEHNEF);
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct KJPNOOMBEMH : GDENHPGEPFJ, IEquatable<KJPNOOMBEMH>
{
	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public int DIEGBKIOLGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x98EA60", Offset = "0x98D260", VA = "0x18098EA60", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7ECFB0", Offset = "0x7EB7B0", VA = "0x1807ECFB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public int PEONAEBENMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x1FBDFF0", Offset = "0x1FBC7F0", VA = "0x181FBDFF0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x51E9800", Offset = "0x51E8000", VA = "0x1851E9800", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C0C0", Offset = "0x5D7A8C0", VA = "0x185D7C0C0", Slot = "8")]
	public bool Equals(KJPNOOMBEMH GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C110", Offset = "0x5D7A910", VA = "0x185D7C110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct EJJHCOFCEKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float NEJMDAHPNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float3 HOBKDEMPIOI;
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public interface OBCIENLNPHB
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public interface HOKKMAFBPHI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	GIMAKLLKNAL JBIHOCPBPAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	KJLFDPOCKCE EFMELCOCEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<LKEHPHAMPJC, NativeArray<KNBFLDNEILM>> HKHPNKEMEME;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<LKEHPHAMPJC> MBKONJONAAK;

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GALEJKINAHP NJLDOJCCPCF(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KNBFLDNEILM NPLADJFCMGH(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JKCLJMACCFA(KLEIPEFFJCP LFHNIGHPLBN, HFBIDPNKJHF IBCBDBLGJKJ);

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EEKEIMNDBGI CKHHEFMHFCG(JEDJBKOCEME JBPJNGFGLPC, [Optional] object PIPCHJCEPPJ);

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool LGFAPDODONP(JEDJBKOCEME JBPJNGFGLPC, [Out] HFBIDPNKJHF IBCBDBLGJKJ);

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool INAPGCCILNA(JEDJBKOCEME JBPJNGFGLPC, [Out] Transform KHFCFAPNPDN);

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool LNCBCICGOEB(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AGLJDNIIPBG(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool JEDDAFCMBOC(LocalId JBPJNGFGLPC, object PIPCHJCEPPJ);

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool KJPIJIECLLM(LocalId JBPJNGFGLPC, object PIPCHJCEPPJ);

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	JEDJBKOCEME FMGHHHBPNNI(KLEIPEFFJCP LFHNIGHPLBN);

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool ODENBBBJBHB(KLEIPEFFJCP LFHNIGHPLBN, [Out] JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	KLEIPEFFJCP DFKMDGDCJGD(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	LKEHPHAMPJC FMGHHHBPNNI(NativeArray<KLEIPEFFJCP> LFHNIGHPLBN, Allocator OPPHPFNHPMG);

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(Slot = "20")]
	LKEHPHAMPJC LBMAOBBLIAO(NativeArray<KLEIPEFFJCP> LFHNIGHPLBN, NativeArray<ALDBGJKBJJO> PJDHECENIOE, Allocator OPPHPFNHPMG);

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(Slot = "21")]
	EEKEIMNDBGI ICDNAHMBOHK(KNBFLDNEILM FGDLEJGCDOG, bool JCAFFHKHKGP);

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(Slot = "22")]
	EEKEIMNDBGI ICDNAHMBOHK(KNBFLDNEILM FGDLEJGCDOG);

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(Slot = "23")]
	EEKEIMNDBGI HOOEEMONOLC(KNBFLDNEILM FGDLEJGCDOG);

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(Slot = "24")]
	EEKEIMNDBGI CJEAHKBADIA(KNBFLDNEILM FGDLEJGCDOG);

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(Slot = "25")]
	EEKEIMNDBGI LBMAOBBLIAO(KLEIPEFFJCP LFHNIGHPLBN, KNBFLDNEILM FGDLEJGCDOG);

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(Slot = "26")]
	JMAMHBBAHMA EBDAPBIFBLO();

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(Slot = "27")]
	IIGOCDJOBNI DNMJJDELJGL();

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(Slot = "28")]
	NFEMEFJAPJB LEGEKJGKEJG(DFMGIJCAPCL EANNAMPLJGI);

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void GFLGNEDPNAG(LKEHPHAMPJC MGOMOGOCFIB);

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void LJGAFCKKELL(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void IDBPEFCBIMG(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void GFLGNEDPNAG(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "33")]
	LKEHPHAMPJC DNOIDEGKJNI(LKEHPHAMPJC EPMKOOAIFAO, Allocator OPPHPFNHPMG);

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool CHBJDEDBAAF(JEDJBKOCEME JBPJNGFGLPC);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class ONPGGNPOAON
{
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5D7E4E0", Offset = "0x5D7CCE0", VA = "0x185D7E4E0")]
	public static void AGLJDNIIPBG(this HOKKMAFBPHI BAKIPPCJAEK, HFBIDPNKJHF IBCBDBLGJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D7E740", Offset = "0x5D7CF40", VA = "0x185D7E740")]
	public static EEKEIMNDBGI CIMNIINOJIK(this HOKKMAFBPHI BAKIPPCJAEK, LocalId JBPJNGFGLPC)
	{
		return default(EEKEIMNDBGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x5D7E740", Offset = "0x5D7CF40", VA = "0x185D7E740")]
	public static JEDJBKOCEME FMGHHHBPNNI(this HOKKMAFBPHI BAKIPPCJAEK, LocalId JBPJNGFGLPC)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D7E770", Offset = "0x5D7CF70", VA = "0x185D7E770")]
	public static KLEIPEFFJCP DFKMDGDCJGD(this HOKKMAFBPHI BAKIPPCJAEK, LocalId JBPJNGFGLPC)
	{
		return default(KLEIPEFFJCP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5D7E670", Offset = "0x5D7CE70", VA = "0x185D7E670")]
	public static bool CHBJDEDBAAF(this HOKKMAFBPHI BAKIPPCJAEK, KLEIPEFFJCP LFHNIGHPLBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x24F4A80", Offset = "0x24F3280", VA = "0x1824F4A80")]
	public static T JIDCLJEKFID<T>(this HOKKMAFBPHI BAKIPPCJAEK, LocalId JBPJNGFGLPC) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5D7EB10", Offset = "0x5D7D310", VA = "0x185D7EB10")]
	public static JMAMHBBAHMA NNMONMBCGJF(this HOKKMAFBPHI BAKIPPCJAEK, RigidTransform NINJNMPBFJA, [Optional] object PIPCHJCEPPJ)
	{
		return default(JMAMHBBAHMA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5D7E560", Offset = "0x5D7CD60", VA = "0x185D7E560")]
	public static NFEMEFJAPJB CAIDMOCKNDA(this HOKKMAFBPHI BAKIPPCJAEK, DFMGIJCAPCL DHHHOBPFDED, RigidTransform NINJNMPBFJA, [Optional] object PIPCHJCEPPJ)
	{
		return default(NFEMEFJAPJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5D7EA10", Offset = "0x5D7D210", VA = "0x185D7EA10")]
	public static IIGOCDJOBNI NDCFCGMNIFP(this HOKKMAFBPHI BAKIPPCJAEK, RigidTransform NINJNMPBFJA, [Optional] object PIPCHJCEPPJ)
	{
		return default(IIGOCDJOBNI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x5D7E7F0", Offset = "0x5D7CFF0", VA = "0x185D7E7F0")]
	private static void GJPAPKCMMCH(EEKEIMNDBGI GMAMBMHGKLK, RigidTransform NINJNMPBFJA, [Optional] object PIPCHJCEPPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
public interface ALHOKAPBJCK
{
	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	bool EMICMDNOLJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	JEDJBKOCEME LBDDMOPJKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	EEKEIMNDBGI BKPEDCHIMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event BDBNCJGLFHC MKOHONAJGCK;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JEDJBKOCEME HJLGGCKIIPA(JEDJBKOCEME HBMBMELELPF, JEDJBKOCEME OPFJANEEJKH);

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EPHMNKOPEON(JEDJBKOCEME HBMBMELELPF, JEDJBKOCEME OPFJANEEJKH, [Out] JEDJBKOCEME NIPMIADLFPJ);

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OLGBIOFNHLB();

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BMABAHCPNMA();

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FOHLCEBFGFM(JEDJBKOCEME HBMBMELELPF);

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GHKNDPCLBLC(JEDJBKOCEME HBMBMELELPF);
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public delegate void BDBNCJGLFHC(EEKEIMNDBGI MOIEHNGIABB, EEKEIMNDBGI AECEHMHBMDH);
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class EEKADGCOJAL
{
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x5D76270", Offset = "0x5D74A70", VA = "0x185D76270")]
	public static bool IIMHGPBJJNC(this ALHOKAPBJCK PDEHEGCALFK, JEDJBKOCEME HBMBMELELPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x5D761F0", Offset = "0x5D749F0", VA = "0x185D761F0")]
	public static bool BLEINLMBJIM(this ALHOKAPBJCK PDEHEGCALFK, JEDJBKOCEME HBMBMELELPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public interface ABILNOGAPGJ
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLLNHFGFEEH(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HKOIKNLODAH(JEDJBKOCEME JBPJNGFGLPC, Transform KHFCFAPNPDN);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
public interface DIIBKKJDGKE
{
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JCDNFBLLCNJ(JEDJBKOCEME ADMPFLAIEKN, bool IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LGCIEALPAHC(JEDJBKOCEME ADMPFLAIEKN, bool IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void POCOFDDFHIM(JEDJBKOCEME ADMPFLAIEKN, int IFKKLLBODIE);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
public interface FICELHLOKNG
{
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<JEDJBKOCEME> CGGFHGGMLOG(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JEDJBKOCEME CAEMJNGCCEJ(JEDJBKOCEME JBPJNGFGLPC, int ADMJKDLHPCI);

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int PPFDBIGIDOE(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BHBLOOFPBII PKICGDOOCHG(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BHFPONILALJ(JEDJBKOCEME JBPJNGFGLPC, BHBLOOFPBII HIKDFDIFDNM);

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JEDJBKOCEME EPKAANPGFPP(JEDJBKOCEME JBPJNGFGLPC, [Optional] float3? OBAACBLACLC, [Optional] quaternion? AHLHKGGFBGH, [Optional] float3? CDLIHEJMBGO);

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JEDJBKOCEME OJAECIPOLAJ(JEDJBKOCEME JBPJNGFGLPC, int ADMJKDLHPCI, [Optional] float3? OBAACBLACLC, [Optional] quaternion? AHLHKGGFBGH, [Optional] float3? CDLIHEJMBGO);

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LLCEFGLJOCI(JEDJBKOCEME JBPJNGFGLPC, int ADMJKDLHPCI);

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KJLDKFCGMLK(JEDJBKOCEME JBPJNGFGLPC);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public interface PHLKAMANPNI
{
	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCLKDCELABH();

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFIFDHHKADN();

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DPJCPLNJPJE();

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GEDHAHNGGKK();

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BDCFBGEAMLC();

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MBILDHLJGBJ();

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OBHHNLPNAAG();

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GLKPHCPGAEO();

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DPNHDPCLHHO();

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BPOIEOCFCPK();

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BNHGMKAFILP();
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public interface CECLHBPNMGM
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJECEOOKNJC(Entity MFFDEAINOPL);

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBBHLLMBFHE(Entity MFFDEAINOPL, [In] float3 IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 IHGFPBPPIPI(Entity MFFDEAINOPL);

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ELMILBICGGO(Entity MFFDEAINOPL, [In] quaternion IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion CGFFHINEJNH(Entity MFFDEAINOPL);

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BNBGHPKENHC(Entity MFFDEAINOPL, [Out] float3 OBAACBLACLC, [Out] quaternion AHLHKGGFBGH);

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BNBGHPKENHC(Entity MFFDEAINOPL, [Out] RigidTransform IFJLAEGOCNL);

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EJPJNKLKFNO(Entity MFFDEAINOPL, [Out] RigidTransform IFJLAEGOCNL);

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 GCMJJMGKIDK(Entity MFFDEAINOPL);

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OFDIEADNOLH(Entity MFFDEAINOPL, [In] float3 IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PEPPDALBKEN(Entity MFFDEAINOPL, float IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float EJOPFAAHEAG(Entity MFFDEAINOPL);

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OMNLGNICBHB(Entity MFFDEAINOPL, [In] float3 IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 IHOJOHHJHEF(Entity MFFDEAINOPL);

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DPECHGGPJEI(Entity MFFDEAINOPL, [In] float3 IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 CCMLCBBPAHG(Entity MFFDEAINOPL);

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HOAELCHFHGH(Entity MFFDEAINOPL, [In] quaternion IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion FEBHODBBOCG(Entity MFFDEAINOPL);

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 CEINPCLGFLC(Entity MFFDEAINOPL);

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void KHJHELBEAPB(Entity MFFDEAINOPL, [In] float3 IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void FHKELFMBAKA(Entity MFFDEAINOPL, float IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float OAFGKNILALL(Entity MFFDEAINOPL);

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void MDIJLBBADLH(Entity MFFDEAINOPL, [In] float3 IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 KDOEDCEPBPD(Entity MFFDEAINOPL);

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void PHGNOICOEMF(Entity MFFDEAINOPL, [Out] float4x4 JBBMMCAIOID);

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void HDKMMDABAHD(Entity MFFDEAINOPL, [In] float4x4 JBBMMCAIOID);

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void FDAMOPAPLIC(Entity MFFDEAINOPL, [Out] float4x4 JBBMMCAIOID);

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool INAPGCCILNA(Entity MFFDEAINOPL, [Out] Transform KHFCFAPNPDN);

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void IKJIMFLEKAF(Entity MFFDEAINOPL);

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void JAIEFPJGNPM(Entity MFFDEAINOPL, Entity HPAAJPNIILF, Entity IKMOPDEAPOG);
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class ICDOCDJHJFF
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public interface GABKHNGOBOD
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World IMOGAMJLLMI();

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World HPLEAIHCPCD();

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World NENKLEKOHPG();

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World LDOMJPCBOFH();
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public interface HLLCKCNCCJD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	World CPJGAENFGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	World OENOGIIIABG
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	EntityManager NHMANGHHOMH
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	bool PLFIBBCFHEC
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase HCDALFIJJEN(Type BJKOKHNAAID);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class EAGEGGJCIJM
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x5D760A0", Offset = "0x5D748A0", VA = "0x185D760A0")]
	public static ComponentSystemBase MLAIHLJDHEC(this World LPBOBKJPICK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2245F00", Offset = "0x2244700", VA = "0x182245F00")]
	public static T HCDALFIJJEN<T>(this HLLCKCNCCJD OHICNBEMHGO) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
public interface ECPCCCMKFNI
{
	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFENILBFJGD(NativeListAsync<Entity> HHLMEFGMPJM);

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INAEBBEGAOI(BKNKPPEAGMA HJPFOJOENMO);

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HOIAKKKELCJ(NativeListAsync<Entity> FNPBGIOPPOI, bool CGOADIFEIKK);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FHIKBDLBFCD();
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
public interface GCMHDFHOGLD
{
	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CNJCCDOBAJF(JEDJBKOCEME JBPJNGFGLPC, [Out] Collider AFMGELLDLJH);

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject LPIGCKLIIJJ(JEDJBKOCEME BHCOIPLBHEB, GameObject NDAADLGGBHN, Vector3 CINCGMPJHMP, Quaternion LAEFAMPNPGA);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PEFMBIDFLKC(GameObject AFMGELLDLJH);

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider EGABHFCCJFL<TCollider>(GameObject GJLPKBPIBII) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OGJABHOKEIG(Collider AFMGELLDLJH);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject JOKJHJACKFI<TCollider>(string BOBHOMKFHJB) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
public interface DGCDFIAGJDB
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NFBPPCAOKAF(JEDJBKOCEME JBPJNGFGLPC, IDGPFAGGINB NDPFDICGPIF, bool GACJCDFOCBD, FKFBMKLOGHG KCDFJLKNNIH);

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LIEMPDODBIH(JEDJBKOCEME JBPJNGFGLPC, IDGPFAGGINB NDPFDICGPIF, bool GACJCDFOCBD, bool FDAJLHPEAIE, bool MLJHOCLLKLJ);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DHMCMFMECFD HIKFKGDFODG(JEDJBKOCEME KLOAHFNCDKG, List<JEDJBKOCEME> OGLEGAFPLHN);

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MHANENCGLEL(GameObject IMLOCFCHBGF, GameObject GGNCBFNAEJK);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BICADDBILCE(GameObject GGNCBFNAEJK);

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T EGABHFCCJFL<T>(GameObject GJLPKBPIBII) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OGJABHOKEIG(Collider AFMGELLDLJH);

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject LJPNMLEBMHN<T>(string BOBHOMKFHJB) where T : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
public interface ENDHILGPLNG
{
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IDJNBDCKNEO(JEDJBKOCEME JBPJNGFGLPC, APEBMOKBFMO IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "1")]
	APEBMOKBFMO ADLCCDLFKBK(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BIJCLJDBJFN(JEDJBKOCEME JBPJNGFGLPC, JEDJBKOCEME IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NMIJLKFFGOC(JEDJBKOCEME JBPJNGFGLPC, JEDJBKOCEME IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int FAGDHMFPDCE(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JEDJBKOCEME IJPOHDMBNCL(JEDJBKOCEME JBPJNGFGLPC, int ADMJKDLHPCI);

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OPFMAOODMHA(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void INEGLMPLIJI(JEDJBKOCEME JBPJNGFGLPC, object PIPCHJCEPPJ, JEDJBKOCEME IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FBLAOPIDCJE(JEDJBKOCEME JBPJNGFGLPC, object PIPCHJCEPPJ);

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GNKFCBMJMND(JEDJBKOCEME JBPJNGFGLPC, [Out] JEDJBKOCEME IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HOOLMEOMJIJ(JEDJBKOCEME JBPJNGFGLPC, float3 IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FODAOOGGFDN(JEDJBKOCEME JBPJNGFGLPC, [Out] float3 IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DHLGNIMEIAH(JEDJBKOCEME JBPJNGFGLPC, float3 IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool DEEHGLALCJH(JEDJBKOCEME JBPJNGFGLPC, [Out] float3 IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CGPMENMPDBK(JEDJBKOCEME JBPJNGFGLPC, (Quaternion rot, Vector3 moments) JGHIMDFPNCP);

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool ECEOBPMANAA(JEDJBKOCEME JBPJNGFGLPC, [Out] quaternion CPFEILLBOLJ, [Out] float3 PBHIHEKOGGM);

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KEADNDDAJAP(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IAHAACMDFPI(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 PCAOACOIBDA(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 ADHPFGALHMG(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void DMPEBFBDADG(JEDJBKOCEME JBPJNGFGLPC, float3 IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FBPGIPIFKPF(JEDJBKOCEME JBPJNGFGLPC, float3 IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float BFHHHEHGJHE(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float EBIEOOBOFFF(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FBPOOIAEPPI(JEDJBKOCEME JBPJNGFGLPC, float IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void FJFGNOGNIPG(JEDJBKOCEME JBPJNGFGLPC, float IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CollisionDetectionMode BOIMHFBMNHE(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void NFCDBCIDGLE(JEDJBKOCEME JBPJNGFGLPC, CollisionDetectionMode IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	ACDLKJGOCEB IJOJEICANOI(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void POPKEHJKHCN(JEDJBKOCEME JBPJNGFGLPC, ACDLKJGOCEB IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool OBIPMIJMEMG(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void DEJIMFJNPOK(JEDJBKOCEME JBPJNGFGLPC, bool IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "32")]
	JEDJBKOCEME OEBJBPNCIBI(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void BGDMOBMKPEP(JEDJBKOCEME JBPJNGFGLPC, JEDJBKOCEME IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(Slot = "34")]
	JEDJBKOCEME KAHCMOIEBOO(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void OABOCDMKFCC(JEDJBKOCEME JBPJNGFGLPC, JEDJBKOCEME IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(Slot = "36")]
	JEFEPIIEDML FFLMPCIJDNG(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void JOHICBMMGMC(JEDJBKOCEME JBPJNGFGLPC, JEFEPIIEDML MHHPDFGAFLP);

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool KFLOMCKHFNP(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void KONKPDAFHHD(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool EGNCGMNJKHM(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void BOFHFKCFBFE(JEDJBKOCEME JBPJNGFGLPC, bool IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool GNACBDJCOFO(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void MGKNGPLIMBE(JEDJBKOCEME JBPJNGFGLPC, bool IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(Slot = "44")]
	RigidbodyConstraints CCDGOFOBEFK(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void JBGHOPGBENE(JEDJBKOCEME JBPJNGFGLPC, RigidbodyConstraints IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(Slot = "46")]
	float MGFHFBPONOO(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void BKFACAEFAPB(JEDJBKOCEME JBPJNGFGLPC, float IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float DCCLHLFILNI(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void NAINPBDLHCD(JEDJBKOCEME JBPJNGFGLPC, float IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool JPGOJHAEBHE(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void OAGKNKPIAAK(JEDJBKOCEME JBPJNGFGLPC, bool IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool GNBJNOHOJGE(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void CONADDACDID(JEDJBKOCEME JBPJNGFGLPC, bool IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void FCDLLIFCHJB(JEDJBKOCEME JBPJNGFGLPC, int IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(Slot = "55")]
	object IBMBDHLADFN(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void AIMINBMBFEM(JEDJBKOCEME JBPJNGFGLPC, object IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(Slot = "57")]
	object EGNMIMGKNNL(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void CCBCAMHGMLP(JEDJBKOCEME JBPJNGFGLPC, object IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(Slot = "59")]
	float IMEABJDGKPL(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void KIJOJFKOOLG(JEDJBKOCEME JBPJNGFGLPC, float IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void LMGGNPNHCDB(JEDJBKOCEME JBPJNGFGLPC, object PIPCHJCEPPJ);

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void HKAPCFMCLBE(JEDJBKOCEME JBPJNGFGLPC, object PIPCHJCEPPJ);

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(Slot = "63")]
	bool DHONLPJLAOP(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void IOPFONODHLH(JEDJBKOCEME JBPJNGFGLPC, object PIPCHJCEPPJ);

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void CJPMHOBDDOK(JEDJBKOCEME JBPJNGFGLPC, object PIPCHJCEPPJ);

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(Slot = "66")]
	bool BGJCFKMOCMI(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool GLPILHNPIFA(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Rigidbody PEOJOCDELNF(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void PELFENJJLEC(JEDJBKOCEME JBPJNGFGLPC, Rigidbody BCBKDKMIJHH);

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void AEFFGJKAICA(JEDJBKOCEME JBPJNGFGLPC, object PIPCHJCEPPJ);

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void INPHNFIIGGF(JEDJBKOCEME JBPJNGFGLPC, object PIPCHJCEPPJ);

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool AGDAIGECDLC(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void BHLHPBLDOID(JEDJBKOCEME JBPJNGFGLPC, float3 NKFCPJHMPBB);

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void DMIBDKPMJHG(JEDJBKOCEME JBPJNGFGLPC, float3 GNGHKECLLEF);

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(Slot = "75")]
	bool BAPFICDKPHL(JEDJBKOCEME JBPJNGFGLPC, [Out] float3 NKFCPJHMPBB);

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool HLMGGFKHOOK(JEDJBKOCEME JBPJNGFGLPC, [Out] float3 GNGHKECLLEF);

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool LKMIIIPIBNF(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void AMGLABEOBOG(JEDJBKOCEME JBPJNGFGLPC, object PIPCHJCEPPJ, bool NJMFKLMAKKM);

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(Slot = "79")]
	void GFEDIGIOGCL(JEDJBKOCEME JBPJNGFGLPC, bool JMHLHMDOJGN);

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void AJCGAKODIKP(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool IGONBLFBHLO(JEDJBKOCEME JBPJNGFGLPC);
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
public interface LANFDNHMLHI
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	bool PLFIBBCFHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KDGLLOALCLH(JEDJBKOCEME JBPJNGFGLPC);

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJJBEEPJHBA(JEDJBKOCEME JBPJNGFGLPC, bool GACJCDFOCBD, bool FDAJLHPEAIE, bool CNBJCAJCBMG);
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
public interface ONKAIGMIMMN
{
	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JBCNIMKDPDB(Entity APJPFCLOHOC);

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BGNOAGNIPIH(Entity APJPFCLOHOC);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public delegate void IEMADMGHMDI(ECFICEJMGLN JGFMOPALCBN);
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct ECFICEJMGLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly LKEHPHAMPJC BKPJJLPFOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly NativeArray<byte> HCFJKNGNHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly NativeArray<byte> NIGNLJEOLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly BCJCKPDGHHM BFLLNKNNDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly int KLKOABBDJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Type OCMKLPMHPNE;

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public LKEHPHAMPJC ADJBFIHJPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x3537460", Offset = "0x3535C60", VA = "0x183537460")]
		get
		{
			return default(LKEHPHAMPJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D76180", Offset = "0x5D74980", VA = "0x185D76180")]
	public ECFICEJMGLN(LKEHPHAMPJC BKPJJLPFOIL, NativeArray<byte> HCFJKNGNHKA, NativeArray<byte> NIGNLJEOLLK, BCJCKPDGHHM BFLLNKNNDBB, int KLKOABBDJDL, Type OCMKLPMHPNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x2246FE0", Offset = "0x22457E0", VA = "0x182246FE0")]
	public NativeArray<T> GFGEKHLEEFN<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x2246FA0", Offset = "0x22457A0", VA = "0x182246FA0")]
	public NativeArray<T> DIGLDFIHOPM<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x2246EB0", Offset = "0x22456B0", VA = "0x182246EB0")]
	public (LKEHPHAMPJC, NativeArray<T>, NativeArray<T>) BCFBOGKIONB<T>() where T : struct
	{
		return default((LKEHPHAMPJC, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5D76130", Offset = "0x5D74930", VA = "0x185D76130")]
	public HCBGKMEOBBG KBKDGAABGNH()
	{
		return default(HCBGKMEOBBG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public interface DCPFKNBLOIN
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	string DCLBODHBAJG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	DCPFKNBLOIN FFLAMFCLHPI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	IEnumerable<DCPFKNBLOIN> AJPLGJPKKCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
public interface CKPCCLGFCBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000128")]
	DCPFKNBLOIN EEKBPFNPIJG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	List<AMEANBJHGMM> LGPEMBMIPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NFOOEPBFDFJ(AMEANBJHGMM OLJMCOBAMDO, [Out] DCPFKNBLOIN ENJDCNEMLMG);

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JKCLJMACCFA(AMEANBJHGMM OLJMCOBAMDO, IEMADMGHMDI LBLABPJPMGM);

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HOLDKHPGNLM(AMEANBJHGMM OLJMCOBAMDO, IEMADMGHMDI LBLABPJPMGM);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public readonly struct HCBGKMEOBBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly ECFICEJMGLN KOIMDAJNDOD;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public LKEHPHAMPJC ADJBFIHJPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x3537460", Offset = "0x3535C60", VA = "0x183537460")]
		get
		{
			return default(LKEHPHAMPJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x5D78060", Offset = "0x5D76860", VA = "0x185D78060")]
	public HCBGKMEOBBG(ECFICEJMGLN KOIMDAJNDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x5D77F90", Offset = "0x5D76790", VA = "0x185D77F90")]
	public LKEHPHAMPJC GFGEKHLEEFN()
	{
		return default(LKEHPHAMPJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x5D77EC0", Offset = "0x5D766C0", VA = "0x185D77EC0")]
	public LKEHPHAMPJC DIGLDFIHOPM()
	{
		return default(LKEHPHAMPJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x5D77DA0", Offset = "0x5D765A0", VA = "0x185D77DA0")]
	public (LKEHPHAMPJC, LKEHPHAMPJC, LKEHPHAMPJC) BCFBOGKIONB()
	{
		return default((LKEHPHAMPJC, LKEHPHAMPJC, LKEHPHAMPJC));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
[DefaultMember("Item")]
public interface AACGNIFANPK : IEnumerable<ACMAOFLJBJE>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	NativeBitArray HHODHICOEPF
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	NativeArray<int> DFOKADMDJED
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	ACMAOFLJBJE NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	ACMAOFLJBJE NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ACMAOFLJBJE GPMFIJBJGKK(CBPEEJLPJDB JHFJPGOBMLL);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BCJCKPDGHHM MCCDHJKIPHH(CBPEEJLPJDB JHFJPGOBMLL);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class OJNFGPFJHMK
{
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DefaultMember("Item")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public interface HCANMCICAMH : IEnumerable<MNOPJOLALGH>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	MNOPJOLALGH NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MNOPJOLALGH GPMFIJBJGKK(CBPEEJLPJDB JHFJPGOBMLL);

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BCJCKPDGHHM MCCDHJKIPHH(CBPEEJLPJDB JHFJPGOBMLL);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class CGLCEALGNGH
{
	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x21F9C90", Offset = "0x21F8490", VA = "0x1821F9C90")]
	public static BCJCKPDGHHM MCCDHJKIPHH<T>(this HCANMCICAMH PBFNCDEJLIJ, GOOBEKCPDHA<T> BOBHOMKFHJB) where T : struct
	{
		return default(BCJCKPDGHHM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
[DefaultMember("Item")]
public interface ANGAFLNDJOG : IEnumerable<AMEANBJHGMM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	AMEANBJHGMM NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AMEANBJHGMM GPMFIJBJGKK(CBPEEJLPJDB JHFJPGOBMLL);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BCJCKPDGHHM MCCDHJKIPHH(CBPEEJLPJDB JHFJPGOBMLL);
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class NBFIABILIGC
{
	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x24CE750", Offset = "0x24CCF50", VA = "0x1824CE750")]
	public static OCJCHIJHGBA<T> GPMFIJBJGKK<T>(this ANGAFLNDJOG PBFNCDEJLIJ, CBPEEJLPJDB BOBHOMKFHJB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x24CE890", Offset = "0x24CD090", VA = "0x1824CE890")]
	public static BCJCKPDGHHM MCCDHJKIPHH<T>(this ANGAFLNDJOG PBFNCDEJLIJ, GOOBEKCPDHA<T> BOBHOMKFHJB) where T : struct
	{
		return default(BCJCKPDGHHM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
public interface PMIAAANLCEE
{
	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JKCLJMACCFA(CBPEEJLPJDB OLJMCOBAMDO, IEMADMGHMDI LBLABPJPMGM);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HOLDKHPGNLM(CBPEEJLPJDB OLJMCOBAMDO, IEMADMGHMDI LBLABPJPMGM);
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public interface MOJADNJPIHP
{
	[Cpp2IlInjected.Token(Token = "0x17000134")]
	JNDAOLABELB NGBGNFOOION
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KGFOKHJBJIO(KLEIPEFFJCP LFHNIGHPLBN, BCJCKPDGHHM OLJMCOBAMDO);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JKFJKJELKDO(KLEIPEFFJCP LFHNIGHPLBN, Span<BCJCKPDGHHM> PBFNCDEJLIJ, bool HHNLEOOPNHA);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ABMJGICBDEI(NativeArray<KLEIPEFFJCP> BMJMOJMCGHB);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class NKKBNBIIDFH
{
	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5D7D830", Offset = "0x5D7C030", VA = "0x185D7D830")]
	public static void JKFJKJELKDO(this MOJADNJPIHP PCANEKAMGEO, KLEIPEFFJCP LFHNIGHPLBN, BCJCKPDGHHM OLJMCOBAMDO, bool HHNLEOOPNHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public readonly struct JNDAOLABELB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly NativeBitArray FDKJHGILMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly NativeParallelHashMap<KLEIPEFFJCP, int> GAMLEOPMCCC;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool HAOKFJJANAB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x5D7AFB0", Offset = "0x5D797B0", VA = "0x185D7AFB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0xA70090", Offset = "0xA6E890", VA = "0x180A70090")]
	public JNDAOLABELB(NativeBitArray FDKJHGILMDN, NativeParallelHashMap<KLEIPEFFJCP, int> GAMLEOPMCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5D7AE80", Offset = "0x5D79680", VA = "0x185D7AE80")]
	public bool KGFOKHJBJIO(KLEIPEFFJCP LFHNIGHPLBN, BCJCKPDGHHM OLJMCOBAMDO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
public interface AKEDEPNKODI
{
	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLHMEGMFJOA(JEDJBKOCEME JBPJNGFGLPC, IHMFBHLJOII IFKKLLBODIE);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public interface CEKKBMINEOM
{
	[Cpp2IlInjected.Token(Token = "0x17000136")]
	PFCOBFLEOJA LOADHPIPCHJ
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
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public interface BNPBAMGOGIA
{
	[Cpp2IlInjected.Token(Token = "0x17000137")]
	Type PLGADPKENCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
public interface OELIOIGNFBB
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DBJCJOALLJP(JEDJBKOCEME ADMPFLAIEKN, bool IFKKLLBODIE);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public readonly struct EMCHIFDMDCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly IEnumerable<NDNCPECEFHH> HPFBMIPPKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly IReadOnlyList<GameObject> ILLAGPPDPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly IReadOnlyList<int> OGOEELLJHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly IReadOnlyList<(KLEIPEFFJCP, KLEIPEFFJCP)> FJKHGOMIJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly int AAEFGPLLDOJ;

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool NLJMBAJEDED
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5D771E0", Offset = "0x5D759E0", VA = "0x185D771E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public int DAPECLKNEDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x807520", Offset = "0x805D20", VA = "0x180807520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public IEnumerable<GameObject> MJPPMPDIEPN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x98EAD0", Offset = "0x98D2D0", VA = "0x18098EAD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public IEnumerable<(KLEIPEFFJCP src, KLEIPEFFJCP dst)> IJKDNPDCOAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D77240", Offset = "0x5D75A40", VA = "0x185D77240")]
	public EMCHIFDMDCK(IEnumerable<NDNCPECEFHH> HPFBMIPPKKG, IReadOnlyList<GameObject> ILLAGPPDPIL, IReadOnlyList<int> OGOEELLJHKP, IReadOnlyList<(KLEIPEFFJCP src, KLEIPEFFJCP dst)> FJKHGOMIJOI, int AAEFGPLLDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D76E50", Offset = "0x5D75650", VA = "0x185D76E50")]
	public (GameObject, int)[] EAKFJDNFDII()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface FBKLHLEKBGM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	bool CBAHOLKLKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	bool ANAJIHMOHHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	CGIIEKIPGLL CHMEEMGNLAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EJKJGDNPOAM DBLNJICLIJI();

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EJKJGDNPOAM FOJGOEMNBIK(IEnumerable<JEDJBKOCEME> MGOMOGOCFIB, [In] PKIFHEFFKDB OBKIDCLEHOP);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GCBHCOCLCNM NNKIPHEIGCA(ByteString BDIHBOFNJCJ);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AKFDJCNPOFK CDACMPCKPIA(ByteString BGGDIKOMABC, JEDJBKOCEME KLGMOMIJPLM, [In] PKIFHEFFKDB GGJIEMCKGGE, DKFKBKKOBGP FAJOCDCHOMD, bool OCPLIKPJDLN = true);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DKNLAPGFFHA();

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EMCHIFDMDCK GGGEOAKANAC(IEnumerable<NDNCPECEFHH> HPFBMIPPKKG);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class PCKOCEEBJHB
{
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface KHMIANHLIDA
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action NFFICPMCDGF;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action EOEDPJLDECF;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct ALDBGJKBJJO : MPANBJGAAIE, IEquatable<ALDBGJKBJJO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public KNBFLDNEILM FGDLEJGCDOG;

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5D728B0", Offset = "0x5D710B0", VA = "0x185D728B0", Slot = "5")]
	public void GHFHHMFPNJI(BJGJBDHKABD PBFIJMOIIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5D728E0", Offset = "0x5D710E0", VA = "0x185D728E0", Slot = "4")]
	public void NDMEHJLGNHG(KMMIKOANJPK OPKLFJAIALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5D72910", Offset = "0x5D71110", VA = "0x185D72910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x160F1B0", Offset = "0x160D9B0", VA = "0x18160F1B0", Slot = "6")]
	public bool Equals(ALDBGJKBJJO GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5D72830", Offset = "0x5D71030", VA = "0x185D72830", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x98EA60", Offset = "0x98D260", VA = "0x18098EA60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct KLEIPEFFJCP : IComparable<KLEIPEFFJCP>, IEquatable<KLEIPEFFJCP>, MPANBJGAAIE
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public const uint ILOMOHHPICA = 0u;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public const uint AMIANMBJBPD = 255u;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly KLEIPEFFJCP GCBDJIKNIJL;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private const int EIABBNDACBE = 24;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private const uint PPEJHDOPDKB = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private const int BOFOOHDFDJF = 8;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private const uint HDNOIEJGJPA = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly uint CMDCHMPDLBJ;

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public uint GHAPDFFEOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x7B7740", Offset = "0x7B5F40", VA = "0x1807B7740")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public uint GNAEIIEFOAF
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x5D7C170", Offset = "0x5D7A970", VA = "0x185D7C170")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public uint OJDPJEKEOIP
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x98EA60", Offset = "0x98D260", VA = "0x18098EA60")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool NLJMBAJEDED
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x5CDF7F0", Offset = "0x5CDDFF0", VA = "0x185CDF7F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0xBCE930", Offset = "0xBCD130", VA = "0x180BCE930")]
	public static KLEIPEFFJCP HMHAOCEAFGB(uint CMDCHMPDLBJ)
	{
		return default(KLEIPEFFJCP);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C350", Offset = "0x5D7AB50", VA = "0x185D7C350")]
	public KLEIPEFFJCP(int GKDFLIHPFGB, int EJFCJCIMMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C350", Offset = "0x5D7AB50", VA = "0x185D7C350")]
	public KLEIPEFFJCP(uint GKDFLIHPFGB, int EJFCJCIMMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C350", Offset = "0x5D7AB50", VA = "0x185D7C350")]
	public KLEIPEFFJCP(uint GKDFLIHPFGB, uint EJFCJCIMMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFB0", Offset = "0x7EB7B0", VA = "0x1807ECFB0")]
	private KLEIPEFFJCP(uint CMDCHMPDLBJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x160F1D0", Offset = "0x160D9D0", VA = "0x18160F1D0")]
	public static bool PEFPHNLEPOM(KLEIPEFFJCP FABNAGLLOKN, KLEIPEFFJCP FCOICCIGANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x160F1B0", Offset = "0x160D9B0", VA = "0x18160F1B0", Slot = "5")]
	public bool Equals(KLEIPEFFJCP LJHGKCLAIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C180", Offset = "0x5D7A980", VA = "0x185D7C180", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1860", Offset = "0x1FA0060", VA = "0x181FA1860", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C2C0", Offset = "0x5D7AAC0", VA = "0x185D7C2C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C260", Offset = "0x5D7AA60", VA = "0x185D7C260", Slot = "6")]
	public void NDMEHJLGNHG(KMMIKOANJPK OPKLFJAIALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C200", Offset = "0x5D7AA00", VA = "0x185D7C200", Slot = "7")]
	public void GHFHHMFPNJI(BJGJBDHKABD PBFIJMOIIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C160", Offset = "0x5D7A960", VA = "0x185D7C160", Slot = "4")]
	public int CompareTo(KLEIPEFFJCP GHNNCJBDHKF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct NDNCPECEFHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Guid ACBJLDAEBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public string LKJPOGNICEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Vector3 OBAACBLACLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Quaternion AHLHKGGFBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Vector3 CDLIHEJMBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public int DNPENFJCPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Dictionary<string, object> HIKDFDIFDNM;

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x5D7D360", Offset = "0x5D7BB60", VA = "0x185D7D360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x5D7D1D0", Offset = "0x5D7B9D0", VA = "0x185D7D1D0")]
	private static string BGAGOAGNIOF(Dictionary<string, object> GAAKFFCHNLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public enum JKBEFCOKGIC
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	World,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class CBPAKBPIDLN
{
	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x52FFA50", Offset = "0x52FE250", VA = "0x1852FFA50")]
	public static bool KFAIEDPMGEI(this JKBEFCOKGIC BJKOKHNAAID)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[Flags]
public enum FIEDEPEHHFE
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
public interface AKFDJCNPOFK : CGIIEKIPGLL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000143")]
	DKFKBKKOBGP BOPBILOGGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFKLAMKNNLG();

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HFPOPCKJKOL();
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public interface CGIIEKIPGLL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000144")]
	IEnumerable<NDNCPECEFHH> HKEMKPJOFNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	EMCHIFDMDCK CHEBIDIFNAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	LocalId DBLKKOICMLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	HLHILOHMCCK JKBKPBPMOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	Task LJEJHLGKKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KDJJLACMJLH(FIEDEPEHHFE KCBHFKGPFEE);
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public interface DKFKBKKOBGP
{
	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NALBANPEJMF(Guid PMFLLGPMIME, [Out] Guid PCLAHFAGOCH);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public interface GCBHCOCLCNM : CGIIEKIPGLL, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[Flags]
public enum GCAKOHANNLG
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
public interface EJKJGDNPOAM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000149")]
	HLHILOHMCCK LOPFPNGGAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString CGIMOENKJPM();
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public enum PGFGMDLLDHI
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public delegate bool KHEJHCOLHBJ(ADNGMPCLMLO EDDCAIAHGKK, [In] LELJJGNMHGH IFKKLLBODIE);
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public delegate bool KPEDHDLDANH<T>(ADNGMPCLMLO EDDCAIAHGKK, [In] T IFKKLLBODIE);
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public interface FKPECEFBIMH
{
	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JKCLJMACCFA(BCJCKPDGHHM BFLLNKNNDBB, Type JGBDEOEIAJA, KHEJHCOLHBJ IFGLBNBGECN);

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HIEENLAACHG(BCJCKPDGHHM BFLLNKNNDBB, [Out] KHEJHCOLHBJ IFGLBNBGECN);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class PEOHKJIJHEF
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class MBAFEJMGACN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public KPEDHDLDANH<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public MBAFEJMGACN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x3B958D0", Offset = "0x3B940D0", VA = "0x183B958D0")]
		internal bool HGLKLCJPDDF(ADNGMPCLMLO pendingList, [In] LELJJGNMHGH value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x2502B40", Offset = "0x2501340", VA = "0x182502B40")]
	public static void JKCLJMACCFA<T>(this FKPECEFBIMH CMJAHIOHOCL, BCJCKPDGHHM BFLLNKNNDBB, KPEDHDLDANH<T> IFGLBNBGECN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x5D7FAD0", Offset = "0x5D7E2D0", VA = "0x185D7FAD0")]
	public static bool GNDHFGAFBGM(this FKPECEFBIMH CMJAHIOHOCL, ADNGMPCLMLO EDDCAIAHGKK, BCJCKPDGHHM BFLLNKNNDBB, [In] LELJJGNMHGH IFKKLLBODIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public interface KKDHBJBFPOF
{
	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	uint ABDNOGHCJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public interface ADNGMPCLMLO
{
	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EPNMOIJNKPL(KLEIPEFFJCP LCAJFKKKEOL, BCJCKPDGHHM BFLLNKNNDBB, ReadOnlySpan<byte> CKEMPKBOFPJ, ReadOnlySpan<byte> IMFCBNHMGHI);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HEPDOENIAOL(KLEIPEFFJCP LCAJFKKKEOL, BCJCKPDGHHM BFLLNKNNDBB);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PHFEJGBGEEF(KLEIPEFFJCP LCAJFKKKEOL, BCJCKPDGHHM BFLLNKNNDBB, ReadOnlySpan<byte> IMFCBNHMGHI);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IAGAGAIFGOK(KLEIPEFFJCP LCAJFKKKEOL, BCJCKPDGHHM BFLLNKNNDBB, Span<byte> CKEMPKBOFPJ, Span<byte> IMFCBNHMGHI);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class NKICFEHEOOB
{
	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x24D7490", Offset = "0x24D5C90", VA = "0x1824D7490")]
	public static bool IAGAGAIFGOK<T>(this ADNGMPCLMLO ILHAAPGODPE, KLEIPEFFJCP LCAJFKKKEOL, BCJCKPDGHHM BFLLNKNNDBB, [Out] T CKEMPKBOFPJ, [Out] T IMFCBNHMGHI) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x24D7640", Offset = "0x24D5E40", VA = "0x1824D7640")]
	public static bool PHFEJGBGEEF<T>(this ADNGMPCLMLO ILHAAPGODPE, KLEIPEFFJCP LCAJFKKKEOL, BCJCKPDGHHM BFLLNKNNDBB, T IMFCBNHMGHI) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public enum MHAGJCCCDGL
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
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public interface HHCNHIPPGNG
{
	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HKLFJAOHIIH(MMNLNLKKOGE MOHHJLIGFPM, ReadOnlySpan<byte> AJPCNFDACDH);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public interface HOAMBCOIHOO
{
	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MMNLNLKKOGE PDAJPLMOMFK(ReadOnlySpan<byte> AJPCNFDACDH);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public interface MEABKCDHNCD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CLFJCMJBKBK(MMNLNLKKOGE EBICOEDOGKC, ReadOnlySpan<byte> AJPCNFDACDH);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public struct AAHNJDMDDJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public MMNLNLKKOGE MOHHJLIGFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public ReadOnlyMemory<byte> AJPCNFDACDH;
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct MMNLNLKKOGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public uint GKDFLIHPFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public int BNIONIMDDLK;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x978550", Offset = "0x976D50", VA = "0x180978550")]
	public MMNLNLKKOGE(uint GKDFLIHPFGB, int BNIONIMDDLK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x5D7CE40", Offset = "0x5D7B640", VA = "0x185D7CE40")]
	public static bool PEFPHNLEPOM([In] MMNLNLKKOGE LCFOIJICGNF, [In] MMNLNLKKOGE CEDMGMKLGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x5D7CD80", Offset = "0x5D7B580", VA = "0x185D7CD80", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x5D7CE10", Offset = "0x5D7B610", VA = "0x185D7CE10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x5D7CE60", Offset = "0x5D7B660", VA = "0x185D7CE60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public interface OPHKKINCMBH : KPJBNKFBBOP<OPHKKINCMBH>
{
	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GBJDFDNKBJP(BCJCKPDGHHM LJHGKCLAIHG, [Out] FDINMBBOPJN DKBOLDMDFGM);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class JNFPFMNFHNH
{
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public interface FDINMBBOPJN
{
	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	Type HAJHMPBBGDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GHFHHMFPNJI(BJGJBDHKABD PBFIJMOIIIO, Span<byte> HBMBMELELPF);

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NDMEHJLGNHG(KMMIKOANJPK OPKLFJAIALA, ReadOnlySpan<byte> MOHHJLIGFPM);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class FNBKDLAKBHM
{
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct BIJOGOIADPC : ISystemStateComponentData, IComponentData, IEquatable<BIJOGOIADPC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public float3 DBAAOKLDPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public float3 LNBPNHLAAEM;

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x5D74FA0", Offset = "0x5D737A0", VA = "0x185D74FA0", Slot = "4")]
	public bool Equals(BIJOGOIADPC GHNNCJBDHKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface ECJAJDGHKCC
{
	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KIBODBGDLMG IBFOAOJHAJB(int GIBOEKFJFBH);

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int FEEGMBIGLHB(KIBODBGDLMG CACPLMILIMA);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface KJLCCDCFOPB
{
	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	IEnumerable<EEIEPFPEPFC> ABLGOEFHFEL
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AMBPMIOKMJD(int GIBOEKFJFBH, [Out] EEIEPFPEPFC DKBOLDMDFGM);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface BDLBABFAOCA
{
	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PKKKKLICPFG(int GIBOEKFJFBH);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface IINGCDCGONO
{
	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	List<(KIBODBGDLMG nameHash, BKGNILJGMHF stableTypeHash, Type type)> JGGNJECNLLL
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public class OBJMCPPPHHO
{
	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public OBJMCPPPHHO()
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
