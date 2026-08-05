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
using RecRoom.DataLayer;
using RecRoom.Foundation;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ObjectModel_Interfaces_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : KBDNGCLCFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x60CBEC0", Offset = "0x60CACC0", VA = "0x1860CBEC0", Slot = "4")]
		public override void NLHDMBJLIGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[DefaultMember("Item")]
public struct OEAIGCFLLHH : IReadOnlyList<MIGCCDNHDEL>, IEnumerable<MIGCCDNHDEL>, IEnumerable, IReadOnlyCollection<MIGCCDNHDEL>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct LDHNKJFFHJJ : IEnumerator<MIGCCDNHDEL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly NEPAPILBIHM FGAJNCNIHHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator GBMJFFENPGE;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public MIGCCDNHDEL ODMJFPGIBHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x60CB7D0", Offset = "0x60CA5D0", VA = "0x1860CB7D0", Slot = "4")]
			get
			{
				return default(MIGCCDNHDEL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x60CB750", Offset = "0x60CA550", VA = "0x1860CB750", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3B957E0", Offset = "0x3B945E0", VA = "0x183B957E0")]
		public LDHNKJFFHJJ(NEPAPILBIHM FGAJNCNIHHF, NativeArray<LocalId>.Enumerator GBMJFFENPGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x60CB690", Offset = "0x60CA490", VA = "0x1860CB690", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x60CB6D0", Offset = "0x60CA4D0", VA = "0x1860CB6D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x60CB710", Offset = "0x60CA510", VA = "0x1860CB710", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly NEPAPILBIHM FGAJNCNIHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> IMKJMOFIELG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MIGCCDNHDEL LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x60CF7F0", Offset = "0x60CE5F0", VA = "0x1860CF7F0", Slot = "4")]
		get
		{
			return default(MIGCCDNHDEL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x60CF150", Offset = "0x60CDF50", VA = "0x1860CF150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int JNAIEKBMBDN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7A8180", Offset = "0x7A6F80", VA = "0x1807A8180", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NEPAPILBIHM LKLADFJBKCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int AAKPPKIKEIO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7A8180", Offset = "0x7A6F80", VA = "0x1807A8180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CIOMBLIBDKG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x60CF1E0", Offset = "0x60CDFE0", VA = "0x1860CF1E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> GMEFPFCFEPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2208680", Offset = "0x2207480", VA = "0x182208680")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> ABIPBOGICND
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60CF2D0", Offset = "0x60CE0D0", VA = "0x1860CF2D0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60CF760", Offset = "0x60CE560", VA = "0x1860CF760")]
	public OEAIGCFLLHH(int BKPALGGNBEN, NEPAPILBIHM FGAJNCNIHHF, Allocator MGPHHCICJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3B95900", Offset = "0x3B94700", VA = "0x183B95900")]
	public OEAIGCFLLHH(NEPAPILBIHM FGAJNCNIHHF, NativeArray<LocalId> IMKJMOFIELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60CF5A0", Offset = "0x60CE3A0", VA = "0x1860CF5A0")]
	internal OEAIGCFLLHH(NEPAPILBIHM FGAJNCNIHHF, NativeArray<Entity> MPOMEEMHIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60CF610", Offset = "0x60CE410", VA = "0x1860CF610")]
	public OEAIGCFLLHH(NEPAPILBIHM FGAJNCNIHHF, int FAPCCJLFBAA, Allocator MGPHHCICJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60CF6B0", Offset = "0x60CE4B0", VA = "0x1860CF6B0")]
	public OEAIGCFLLHH(OEAIGCFLLHH CGPCKKFDJDM, Allocator MGPHHCICJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x60CF220", Offset = "0x60CE020", VA = "0x1860CF220")]
	public OEAIGCFLLHH JLEDLPHOJFD(Allocator MGPHHCICJPF = Allocator.Temp)
	{
		return default(OEAIGCFLLHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x60CF1A0", Offset = "0x60CDFA0", VA = "0x1860CF1A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60CF330", Offset = "0x60CE130", VA = "0x1860CF330")]
	public LDHNKJFFHJJ OOEEFIELKKG()
	{
		return default(LDHNKJFFHJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x60CF3C0", Offset = "0x60CE1C0", VA = "0x1860CF3C0", Slot = "6")]
	private IEnumerator<MIGCCDNHDEL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x60CF4B0", Offset = "0x60CE2B0", VA = "0x1860CF4B0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[DefaultMember("Item")]
public struct BJNGMJIIBDE : IList<MIGCCDNHDEL>, ICollection<MIGCCDNHDEL>, IEnumerable<MIGCCDNHDEL>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct KBIGIMBDKLJ : IEnumerator<MIGCCDNHDEL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly NEPAPILBIHM FGAJNCNIHHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator GBMJFFENPGE;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public MIGCCDNHDEL ODMJFPGIBHC
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x60C7EF0", Offset = "0x60C6CF0", VA = "0x1860C7EF0", Slot = "4")]
			get
			{
				return default(MIGCCDNHDEL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x60C7E70", Offset = "0x60C6C70", VA = "0x1860C7E70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3B957E0", Offset = "0x3B945E0", VA = "0x183B957E0")]
		public KBIGIMBDKLJ(NEPAPILBIHM FGAJNCNIHHF, NativeArray<LocalId>.Enumerator GBMJFFENPGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x60C7DB0", Offset = "0x60C6BB0", VA = "0x1860C7DB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x60C7DF0", Offset = "0x60C6BF0", VA = "0x1860C7DF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x60C7E30", Offset = "0x60C6C30", VA = "0x1860C7E30", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NEPAPILBIHM FGAJNCNIHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> IMKJMOFIELG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public MIGCCDNHDEL LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x60BFB70", Offset = "0x60BE970", VA = "0x1860BFB70", Slot = "4")]
		get
		{
			return default(MIGCCDNHDEL);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x60BFBF0", Offset = "0x60BE9F0", VA = "0x1860BFBF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x60BF2F0", Offset = "0x60BE0F0", VA = "0x1860BF2F0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int AAKPPKIKEIO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x60BF2F0", Offset = "0x60BE0F0", VA = "0x1860BF2F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool JPJFNMHJCCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60BFAE0", Offset = "0x60BE8E0", VA = "0x1860BFAE0")]
	public BJNGMJIIBDE(NEPAPILBIHM FGAJNCNIHHF, int FAPCCJLFBAA, Allocator MGPHHCICJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60BF590", Offset = "0x60BE390", VA = "0x1860BF590")]
	public OEAIGCFLLHH HADDBDNBGGO()
	{
		return default(OEAIGCFLLHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x60BF330", Offset = "0x60BE130", VA = "0x1860BF330", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x60BF370", Offset = "0x60BE170", VA = "0x1860BF370", Slot = "13")]
	public bool Contains(MIGCCDNHDEL PEFIMPHEJCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60BF400", Offset = "0x60BE200", VA = "0x1860BF400", Slot = "14")]
	public void CopyTo(MIGCCDNHDEL[] AAKJIOEDOGA, int LNFNDNMPKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60BF270", Offset = "0x60BE070", VA = "0x1860BF270", Slot = "11")]
	public void Add(MIGCCDNHDEL PEFIMPHEJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x60BF6A0", Offset = "0x60BE4A0", VA = "0x1860BF6A0", Slot = "7")]
	public void Insert(int ENPOKNEMOMH, MIGCCDNHDEL PEFIMPHEJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x60BF830", Offset = "0x60BE630", VA = "0x1860BF830", Slot = "15")]
	public bool Remove(MIGCCDNHDEL PEFIMPHEJCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x60BF610", Offset = "0x60BE410", VA = "0x1860BF610", Slot = "6")]
	public int IndexOf(MIGCCDNHDEL PEFIMPHEJCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60BF7E0", Offset = "0x60BE5E0", VA = "0x1860BF7E0", Slot = "8")]
	public void RemoveAt(int ENPOKNEMOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60BF550", Offset = "0x60BE350", VA = "0x1860BF550", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60BF750", Offset = "0x60BE550", VA = "0x1860BF750")]
	public KBIGIMBDKLJ OOEEFIELKKG()
	{
		return default(KBIGIMBDKLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60BF900", Offset = "0x60BE700", VA = "0x1860BF900", Slot = "16")]
	private IEnumerator<MIGCCDNHDEL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60BF9F0", Offset = "0x60BE7F0", VA = "0x1860BF9F0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GMNKLNHBHNN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int MMHCPGCBIOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> AJGCFFPDLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MIGCCDNHDEL MNLMGEOMNIP(MIGCCDNHDEL IMKJMOFIELG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BFBLOGPPMGP : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface JGDADIILLEF : CBPPAHFDLDK, CNFJBICKGLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool NJDBJPCDOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	GLNICPJCMKM DIGKIOCAJEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	BPOKKCAPHDK CKKLAGFGFGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	IECCBCMHOEC HOMFGFJJJBN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	GCOBOHLMHJJ AGAABJOBFIK
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	OCCNIHGDLAD IMNKILDFEHH
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface CNFJBICKGLP
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool CJCOPDMOHOD
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface PGONFBFLKDF
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GAIMKIDDHOI(bool NKKIECLCEML);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface GCOBOHLMHJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool NCICOJGGFBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action CBHKINLDILL;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void POIGBAPIGKJ(bool IFBLBHFFNFB);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JIDAOKDEOKE(ByteString CBOHHFCFEEA);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HMDHDEHJLLB();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EKGBDDJHLJH();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EMMABDCBPHH();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface IECCBCMHOEC
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	IIHLCNFMGKJ DIGKIOCAJEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	BPOKKCAPHDK CKKLAGFGFGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	EBFBKHOOOEA IHDKOAAKCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	JGDADIILLEF CAEBANCCKGB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	NEPAPILBIHM LKLADFJBKCO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	ODIANNFGKAF GNCIEAAOHHD
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	DFABAHDIACI MDGCLHFJEPL
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	LLFDLNEFNID CANNLLDHGNM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	BKAKBOLCJLI GOBBJMDOOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	MEPJABONPCO NMABOFONIGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	FJIKJOHMBPB HHJNAHKAKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	BNDBHDACPHO DCJDEIKKFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	GNGDICKHHJP DKLCDEAEDPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	JFNPMPLFNGM KLGMNKDGGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	EIEKLJLBKOA HMNGJJIMHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	DKBBMGDJMLO DKBCCLDNOGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	OJKBFKGCFKK DJKLHOPKPCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	HEGJMPEONPB CHMPFBLMECB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	PDGABMKCFMI HEEBOPHBAIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	HAAMGEKAOIM LFMKFDGHGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	DAFPGOIBLIB JLDKLCPDFKK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	MJBDPFKGJLO IHJJPBICPFO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	GFFIINEADMC IKJOCKAPEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(KONHLANCFAH))]
public readonly struct MIGCCDNHDEL : IComparable<MIGCCDNHDEL>, IEquatable<MIGCCDNHDEL>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly MIGCCDNHDEL ONINMHIBMCC;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int ELJEEMOECPP = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int OOMKAJEGACO = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int JMLLNDFAMLE = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int HOECHFLEFGI = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId IOGJGBJCGKK;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public NEPAPILBIHM LKLADFJBKCO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x60C0AD0", Offset = "0x60BF8D0", VA = "0x1860C0AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JGDADIILLEF CAEBANCCKGB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x60CC800", Offset = "0x60CB600", VA = "0x1860CC800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public LocalId BMCDJEJNAAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x60CC990", Offset = "0x60CB790", VA = "0x1860CC990")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	internal OCCNIHGDLAD IMNKILDFEHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x60CC6D0", Offset = "0x60CB4D0", VA = "0x1860CC6D0")]
		get
		{
			return default(OCCNIHGDLAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool BEFJOKMDIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x60CC8B0", Offset = "0x60CB6B0", VA = "0x1860CC8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool FLFLIAODPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x60CC680", Offset = "0x60CB480", VA = "0x1860CC680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool FPINCHFCJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x60CC860", Offset = "0x60CB660", VA = "0x1860CC860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x60CCB00", Offset = "0x60CB900", VA = "0x1860CCB00")]
	public MIGCCDNHDEL(NEPAPILBIHM PEGLDGLPOPG, LocalId IOGJGBJCGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
	public IMJAJJJILNA DIFJNEMPMOO()
	{
		return default(IMJAJJJILNA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x60CC470", Offset = "0x60CB270", VA = "0x1860CC470")]
	public static LocalId EADAJIFKEOK(MIGCCDNHDEL EKNJNLADAJE)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x60CC4B0", Offset = "0x60CB2B0", VA = "0x1860CC4B0")]
	public static Entity EADAJIFKEOK(MIGCCDNHDEL EKNJNLADAJE)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x60CC6E0", Offset = "0x60CB4E0", VA = "0x1860CC6E0")]
	public static bool JACCNGOPODK(MIGCCDNHDEL GCMDJKOKHCO, MIGCCDNHDEL LGCDJBDIEJC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x60C16B0", Offset = "0x60C04B0", VA = "0x1860C16B0")]
	public static bool PONNJIKFNKJ(MIGCCDNHDEL GCMDJKOKHCO, MIGCCDNHDEL LGCDJBDIEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x60CC9D0", Offset = "0x60CB7D0", VA = "0x1860CC9D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x60CC4F0", Offset = "0x60CB2F0", VA = "0x1860CC4F0", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x60CC390", Offset = "0x60CB190", VA = "0x1860CC390", Slot = "4")]
	public int CompareTo(MIGCCDNHDEL FPEEGIOMOFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "5")]
	public bool Equals(MIGCCDNHDEL FPEEGIOMOFF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MIFOCGMJCBD
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x60CC190", Offset = "0x60CAF90", VA = "0x1860CC190")]
	public static MHNLEJCAAIM EJPCOBEMLHO(this MIGCCDNHDEL NHLNHJGAONN)
	{
		return default(MHNLEJCAAIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x60CC280", Offset = "0x60CB080", VA = "0x1860CC280")]
	public static IMJAJJJILNA LEDAEDECAOJ(this MIGCCDNHDEL NHLNHJGAONN, [Optional] object NBGOKNOECBH)
	{
		return default(IMJAJJJILNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x27CF790", Offset = "0x27CE590", VA = "0x1827CF790")]
	public static T BFMLIFEGEON<T>(this MIGCCDNHDEL NHLNHJGAONN) where T : struct, EFLJMIKJDOL
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class KONHLANCFAH
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct OCCNIHGDLAD : IEquatable<OCCNIHGDLAD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte LDKFOPCPMCG;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] PBEIBJFHJBJ;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static NEPAPILBIHM JIGJBJHAOKG;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static JGDADIILLEF JPEHKCHECMM;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static NEPAPILBIHM[] OEMKGIGPJEF;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static JGDADIILLEF[] JBFGCCDLFLI;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> FCNGAAFOIJN;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public JGDADIILLEF CAEBANCCKGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x60CE820", Offset = "0x60CD620", VA = "0x1860CE820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public NEPAPILBIHM NCGCHILBMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x60CE690", Offset = "0x60CD490", VA = "0x1860CE690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x60CF140", Offset = "0x60CDF40", VA = "0x1860CF140")]
	static OCCNIHGDLAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xC37340", Offset = "0xC36140", VA = "0x180C37340")]
	internal OCCNIHGDLAD(byte NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x52FD9E0", Offset = "0x52FC7E0", VA = "0x1852FD9E0", Slot = "4")]
	public bool Equals(OCCNIHGDLAD FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x60CE3D0", Offset = "0x60CD1D0", VA = "0x1860CE3D0", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1A76520", Offset = "0x1A75320", VA = "0x181A76520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x60CF080", Offset = "0x60CDE80", VA = "0x1860CF080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x60CE770", Offset = "0x60CD570", VA = "0x1860CE770")]
	private static NEPAPILBIHM JEEEMLGKMOD(byte LDKFOPCPMCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x60CEFD0", Offset = "0x60CDDD0", VA = "0x1860CEFD0")]
	private static JGDADIILLEF NPPPIKNMEHO(byte LDKFOPCPMCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x60CE250", Offset = "0x60CD050", VA = "0x1860CE250")]
	private static object DOCKJMILNJO(byte LDKFOPCPMCG, object[] NCNPEIAEPGG, object IDLIOJCDHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x60CE240", Offset = "0x60CD040", VA = "0x1860CE240")]
	private static int BHMABKOICNO(byte LDKFOPCPMCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x60CE3C0", Offset = "0x60CD1C0", VA = "0x1860CE3C0")]
	private static int EIJFKNAJFCM(byte LDKFOPCPMCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x60CE900", Offset = "0x60CD700", VA = "0x1860CE900")]
	private static (int, int) KFMEFFLDEDL(byte LDKFOPCPMCG)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x60CE470", Offset = "0x60CD270", VA = "0x1860CE470")]
	private static byte FLEHANINEDN(int ILCLKBNEPAJ, int ENPOKNEMOMH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x60CED10", Offset = "0x60CDB10", VA = "0x1860CED10")]
	internal static OCCNIHGDLAD NLHDMBJLIGN(JGDADIILLEF NHEKDGNCFAN, NEPAPILBIHM KDNFPNKFDNF)
	{
		return default(OCCNIHGDLAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x60CE480", Offset = "0x60CD280", VA = "0x1860CE480")]
	internal static void GLLKHIKCFCF(OCCNIHGDLAD LDKFOPCPMCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x60CE980", Offset = "0x60CD780", VA = "0x1860CE980")]
	private static void KKEOCOENGIK(int BKPALGGNBEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface GPKLFHGGNIO
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PLKKIAFPPLF();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ECNMHPKDNAE(bool EIJNCJBIEPG);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DPPLHAHGIJH(GameObject IPHCMOEHILB);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface FKFKLMBDNNL
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	Guid DOOOPHKHHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FENENPKMFJC(Guid NGBFCMLOLGF, Guid ADIGEEHPOLN);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task ABOECNMFIKP(MIGCCDNHDEL PJKONFPHJEL);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NEJGKILHDIP(MIGCCDNHDEL BIFNKFCMILB, MIGCCDNHDEL AJKCELPHOFC, [Out] Vector3 OBIONJJHEHM, [Out] Quaternion MMKDNLHLGPC);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GGKGILCGAJP(IBKPGMABGHB EAHBEEFKKCM, Vector3 OBIONJJHEHM, Quaternion MMKDNLHLGPC);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AJINPNJPPCE(MIGCCDNHDEL NFCNKFCEIOG, [Out] Vector3 OMPEIODODMB, [Out] Quaternion ANOLLEPGDFA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface IAGILOKACFE
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPAINDDOFAF(OEAIGCFLLHH IMKJMOFIELG);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface KKFACLNEPDB
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DKAMGPHEKIF(GameObject DLMDLCELFMB, GameObject AOBDNICEBOP, int NDFKLLHMKEI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface BPOKKCAPHDK
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	GPKLFHGGNIO OPKHGMLCFPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	CNKFEHENKCO BGNFEIBBJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	KNONIDBAEGC KFCNCBOPMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	BLPANKBGLKG OMJBCCFBKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	JAADGOBKGIC JKPGANMIKKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	CMPODGPCHIG OADFJJNLBNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	ILGPOFBMKBJ JBFEKPDECFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	OGBDOMIBKME EABJJBLHDGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface IFOEBMLHPBO
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFOABCMGDFA(Action ENHEBPDFNME, bool ACFNOJOHDBH);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GOAADOPDJIJ(string OHHBGJPCFJD);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface CNKFEHENKCO
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string KAMAFPICJIB
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] NLEMANIKFEF(IEnumerable<LGLLGEJOBIO> CMCBMKAJBPJ);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CAODGMBMHAA(GameObject IPHCMOEHILB, [Out] MHNLEJCAAIM[] MDPGDDGMJNJ);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IMCHBJCEAEA(GameObject IPHCMOEHILB, [Out] int JOLMLEHCMLI, [Out] EGPFMLCEFJD MLPCHFIIHMO);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NPILDFLMCDB IFIIPOHDBPH(LGLLGEJOBIO MIMLCIHLPAB);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NPILDFLMCDB IFIIPOHDBPH(string PDNLHMCHEMA, MHNLEJCAAIM[] DFMCILKNNOJ, Vector3 JCOIMLJCHFJ, Quaternion GJMDICOFEBG, Vector3 NANBGKEHFBG);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GameObject JFEOCDIEJGO(string PDNLHMCHEMA);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EPIFFGCFGKI(GameObject OMEFOIPMMGG, bool LPLPENEECKG);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NJNOBMNGPBB(GameObject IPHCMOEHILB, bool CILOBMIJEBH, bool MIOJPBBMEOH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class CGEDHKIFBIG
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x60BFE80", Offset = "0x60BEC80", VA = "0x1860BFE80")]
	public static NPILDFLMCDB IFIIPOHDBPH(this CNKFEHENKCO ADOCEOOMFBH, Vector3 JCOIMLJCHFJ, Quaternion GJMDICOFEBG, Vector3 NANBGKEHFBG, params MHNLEJCAAIM[] MDPGDDGMJNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface KNONIDBAEGC
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FIHMIHOGMGC(bool IFBLBHFFNFB);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface BLPANKBGLKG
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool FIPNCELANHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool JBGIEENIBLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool AIDMAOKFLCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	int MKDICPNFCFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool JPPIOBAGIGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HLNILOKFPHH(object FCMJAHOHNCO);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JGIDMBLKJMH(object FCMJAHOHNCO);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OKKJJOOEDJA(object KAKJJOAALHM);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PJOMFPDMPEB(object KAKJJOAALHM);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int HOIIGLDDLOP(GameObject FEGJFGOAMKG);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PFLMNLEOHIO(NativeArray<int> CFDJEDLDIAI);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KJOCGGAOLCB(NativeArray<int> MELGKDKIBHL);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KDGMIBIICLM();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KHLMFJNDFNH(uint JLLBMKNIENL, ReadOnlySpan<byte> KIPDFMDDCNF, bool NGMOECCHICF = false);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KHLMFJNDFNH(uint JLLBMKNIENL, ReadOnlySpan<byte> KIPDFMDDCNF, ReadOnlySpan<byte> IMMDHPGPPPE, bool NGMOECCHICF = false);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface JAADGOBKGIC
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KKNPCAODPEE(GameObject IPHCMOEHILB);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface MCKABMKHDDJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNELLJFCKAL(string EMKENBOOEOH);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface OINGIKGIBJG
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int IKEHFEKIDPC(GameObject IPHCMOEHILB);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PEDNIDOMCEK(GameObject IPHCMOEHILB);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	object PMKKHCGMIGH(MIGCCDNHDEL IOGJGBJCGKK, GameObject IPHCMOEHILB, Action<MIGCCDNHDEL, int> IDFHKFHMFGD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IDNAGNFJGDH(GameObject IPHCMOEHILB, object NKAKFECLGKL);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface CMPODGPCHIG
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	int EIALEDBDBNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int FKMCMOOPJNO(GameObject IPHCMOEHILB);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MCDJDFDBFDH([Out] Vector3 JCOIMLJCHFJ);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NJLAKNEJDFE();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface ILGPOFBMKBJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool NCICOJGGFBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool HKMJKEHMKFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface AIAOFDPNHGI
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	CBBHLNFCBGP FFNBOAJJEHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	LKINHOILCBI KONGBPPAKFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ADMMGPEHIBA(Transform PFIKOEBPDGA);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HAGMGALEEOF(Transform PFIKOEBPDGA, OAILCNKFKII IPLJLGINJNG);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KNGPHIFCMCI(Transform PFIKOEBPDGA, LPOKNNAKEAE KKDBAKJEPPA);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface OGBDOMIBKME
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGJDOIMFMFH();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface JGEFDKEEHKB
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PCBKGCCAGHP();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface IAJKHPGEFOD
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EGPFMLCEFJD AFAGMGLHFAP(GameObject FEGJFGOAMKG);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CEHHBMGAOPM(GameObject IPHCMOEHILB, HJHFJNCLMIG CIPMPOGHIFK, ADOEKHBDHCN EGBLLKJEKDE);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string JGAAHDNEFCJ(int DGIBOINMLED);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HLNCKHDPOEM(string HEMGNEANHEC);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MPNDNOPGMIK(MIGCCDNHDEL IOGJGBJCGKK, int[] JAKMGJIIIFN);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HKMCKIINDAL(InteractionFilterData OMHIFBJFAGA, int PMIHOHEADPP);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ODJOFOGEIBN(MIGCCDNHDEL IOGJGBJCGKK, int JAKMGJIIIFN);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NLKODHILNPM(MIGCCDNHDEL IOGJGBJCGKK, int JAKMGJIIIFN);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct OJONJLAICGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly KDKONDCEPOP IFADIJDFJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly KDKONDCEPOP DBFFCPMHGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal readonly uint OJBHMDINDJA;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x60CF830", Offset = "0x60CE630", VA = "0x1860CF830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct NNPAGHPLKEF
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly KNPFMNBIIDA PGKJJCPHNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly OJONJLAICGO ENHEBPDFNME;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x60BF1D0", Offset = "0x60BDFD0", VA = "0x1860BF1D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct BFFHJOKKLCG
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly KNPFMNBIIDA PGKJJCPHNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly OJONJLAICGO ENHEBPDFNME;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x60BF1D0", Offset = "0x60BDFD0", VA = "0x1860BF1D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct ANMAGEBPDPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint OJBHMDINDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly bool JFJJBIIGMLD;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x60BF0A0", Offset = "0x60BDEA0", VA = "0x1860BF0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct KDKONDCEPOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal int OOCJLKADJBK;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x60C7FD0", Offset = "0x60C6DD0", VA = "0x1860C7FD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface FLIIOCNNIAO
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	OOACEIKKJKD MAHPHOKDIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum EKPOCFMMJLC
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
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface NPILDFLMCDB : EDKBMCFCDEN
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	IMJAJJJILNA FELLAFAONPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	EKPOCFMMJLC PHJHFHNKPFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool MJOGHLFENCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	GameObject IPHCMOEHILB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<NPILDFLMCDB> DALNMJEGLBG;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(EBFBKHOOOEA CIJLPONPBAP, MIGCCDNHDEL CJGLJDBADGH);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool NIDILBMLHJJ);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class NMAANNAPFME
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x60CD950", Offset = "0x60CC750", VA = "0x1860CD950")]
	public static bool DHAJOCKCAOP(this NPILDFLMCDB ONJHEJOFAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x60CDA30", Offset = "0x60CC830", VA = "0x1860CDA30")]
	public static bool PFKFHNOCPAK(this NPILDFLMCDB ONJHEJOFAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x60CD900", Offset = "0x60CC700", VA = "0x1860CD900")]
	public static bool BALAFNPIGKP(this NPILDFLMCDB ONJHEJOFAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x60CD9A0", Offset = "0x60CC7A0", VA = "0x1860CD9A0")]
	public static bool NJDBJPCDOCO(this NPILDFLMCDB ONJHEJOFAPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface EDKBMCFCDEN
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool LICKKMNBHJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	MIGCCDNHDEL AMEJLJKIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[PFENABFDEFA(DCCNCNLIDJL.LoadInstance)]
internal interface NCPDMLJNDAL
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<NLNCEIOIPED> IGEJOPMGBBF;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface EGHHAKCNGGN : NBDJLKCFGEL<MHNLEJCAAIM>, KPKMJLOHOBJ, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface JLNAKLEEIGH<T> : OLAGFPLOBDD<MHNLEJCAAIM, T>, NBDJLKCFGEL<MHNLEJCAAIM>, KPKMJLOHOBJ, IDisposable, EGHHAKCNGGN where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class MFEJKBBDGPF
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x27596B0", Offset = "0x27584B0", VA = "0x1827596B0")]
	public static bool HPFCNKHIJLK<T>(this NBDJLKCFGEL<MHNLEJCAAIM> EDANCLIIPKG, MHNLEJCAAIM DFMCILKNNOJ, [Out] T NKKIECLCEML) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x26FE750", Offset = "0x26FD550", VA = "0x1826FE750")]
	public static bool FOBLAMHLHCD<T>(this NBDJLKCFGEL<MHNLEJCAAIM> EDANCLIIPKG, MHNLEJCAAIM DFMCILKNNOJ, [In] T OAIFDBCCKDL) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface JNGBIGCDMGC : NBDJLKCFGEL<MIGCCDNHDEL>, KPKMJLOHOBJ, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface IIEIDOKHIGD<T> : OLAGFPLOBDD<MIGCCDNHDEL, T>, NBDJLKCFGEL<MIGCCDNHDEL>, KPKMJLOHOBJ, IDisposable, JNGBIGCDMGC where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class CGFHJMOCLII
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x24E28B0", Offset = "0x24E16B0", VA = "0x1824E28B0")]
	public static T IKJEAFPPDKF<T>(this NBDJLKCFGEL<MIGCCDNHDEL> EDANCLIIPKG, MIGCCDNHDEL IOGJGBJCGKK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2562630", Offset = "0x2561430", VA = "0x182562630")]
	public static bool FOBLAMHLHCD<T>(this NBDJLKCFGEL<MIGCCDNHDEL> EDANCLIIPKG, MIGCCDNHDEL IOGJGBJCGKK, [In] T OAIFDBCCKDL) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct IJBMCFIHFAI : IComparable<IJBMCFIHFAI>, IEquatable<IJBMCFIHFAI>
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly IJBMCFIHFAI ONINMHIBMCC;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly IJBMCFIHFAI OEMGIHDJEGO;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IJBMCFIHFAI BHDFEACNLEH;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly IJBMCFIHFAI GBODPICHHDK;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly IJBMCFIHFAI HMOGELHJIBL;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly IJBMCFIHFAI GMOGNGBDOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int CCEAOHGDFHD;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool OAELPMHBINF
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x60C5DC0", Offset = "0x60C4BC0", VA = "0x1860C5DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public int COAKKPFAKKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x60C5EB0", Offset = "0x60C4CB0", VA = "0x1860C5EB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x898350", Offset = "0x897150", VA = "0x180898350")]
	public IJBMCFIHFAI(int ENPOKNEMOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x60C5E50", Offset = "0x60C4C50", VA = "0x1860C5E50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x60C5DD0", Offset = "0x60C4BD0", VA = "0x1860C5DD0", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x81DD00", Offset = "0x81CB00", VA = "0x18081DD00", Slot = "5")]
	public bool Equals(IJBMCFIHFAI FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1796720", Offset = "0x1795520", VA = "0x181796720", Slot = "4")]
	public int CompareTo(IJBMCFIHFAI FPEEGIOMOFF)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xC163E0", Offset = "0xC151E0", VA = "0x180C163E0")]
	public static IJBMCFIHFAI EADAJIFKEOK(int ENPOKNEMOMH)
	{
		return default(IJBMCFIHFAI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0xC163E0", Offset = "0xC151E0", VA = "0x180C163E0")]
	public static int EADAJIFKEOK(IJBMCFIHFAI LHOPDKBHFLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x60C5EC0", Offset = "0x60C4CC0", VA = "0x1860C5EC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public readonly struct IMJAJJJILNA : IEquatable<IMJAJJJILNA>, EDKBMCFCDEN
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly IMJAJJJILNA KOOIJIDLAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public MIGCCDNHDEL AMEJLJKIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0", Slot = "6")]
		get
		{
			return default(MIGCCDNHDEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public KGAGFPJCGEF EHAKBGMPING
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(KGAGFPJCGEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public KLEFMODELJN GNCIEAAOHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(KLEFMODELJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private NEPAPILBIHM LKLADFJBKCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x60C0AD0", Offset = "0x60BF8D0", VA = "0x1860C0AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public GameObject IPHCMOEHILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x60C7110", Offset = "0x60C5F10", VA = "0x1860C7110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public MHNLEJCAAIM MDJJFCHDPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x60C73A0", Offset = "0x60C61A0", VA = "0x1860C73A0")]
		get
		{
			return default(MHNLEJCAAIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public JICCPKLHMMF OFONPHGBJEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x60C7770", Offset = "0x60C6570", VA = "0x1860C7770")]
		get
		{
			return default(JICCPKLHMMF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public EGPFMLCEFJD BMDIMHNFBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x60C72A0", Offset = "0x60C60A0", VA = "0x1860C72A0")]
		get
		{
			return default(EGPFMLCEFJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool CLNFHHMOEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x60C7810", Offset = "0x60C6610", VA = "0x1860C7810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool LFHGNGEEIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x60C75A0", Offset = "0x60C63A0", VA = "0x1860C75A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool MNIHJLPBPLB
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x60C75C0", Offset = "0x60C63C0", VA = "0x1860C75C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool MBJHDDACNEF
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x60C7340", Offset = "0x60C6140", VA = "0x1860C7340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool DJJGIMBHKOG
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x60C7440", Offset = "0x60C6240", VA = "0x1860C7440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool ODNCHKGCDLM
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x60C78D0", Offset = "0x60C66D0", VA = "0x1860C78D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool IJOBKOFLNIA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x60C74F0", Offset = "0x60C62F0", VA = "0x1860C74F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool DCLNGMMCOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x60C7360", Offset = "0x60C6160", VA = "0x1860C7360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool LBEDLFFDOGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x60C7750", Offset = "0x60C6550", VA = "0x1860C7750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public GEDFGHFFCDF MDNMFOGHINI
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(GEDFGHFFCDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public IIHLCAHNMLK DELMMOJNALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IIHLCAHNMLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public AAFPIKOKCHE DKLCDEAEDPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(AAFPIKOKCHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public IJPIFPKLFGL KNDMKPNNJPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IJPIFPKLFGL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public DDHDJGOGPPL DCJDEIKKFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(DDHDJGOGPPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public NEHIFFEKPLE GPFAOGHJGKH
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(NEHIFFEKPLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IBKPGMABGHB CHEIGIDLHEA
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IBKPGMABGHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public NNOHNLLAFIJ OPFEHHNKGAK
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(NNOHNLLAFIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool DHAJOCKCAOP
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x60C7660", Offset = "0x60C6460", VA = "0x1860C7660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool NNNFFCJBKNE
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x60C7560", Offset = "0x60C6360", VA = "0x1860C7560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool CFENDFCHHDF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x60C7B40", Offset = "0x60C6940", VA = "0x1860C7B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	private bool JFBFGLMJLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7C4100", Offset = "0x7C2F00", VA = "0x1807C4100", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0")]
	public IMJAJJJILNA(MIGCCDNHDEL IOGJGBJCGKK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x60BFD10", Offset = "0x60BEB10", VA = "0x1860BFD10")]
	public static bool EADAJIFKEOK(IMJAJJJILNA NKKIECLCEML)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0")]
	public static MIGCCDNHDEL EADAJIFKEOK(IMJAJJJILNA NKKIECLCEML)
	{
		return default(MIGCCDNHDEL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x60C2220", Offset = "0x60C1020", VA = "0x1860C2220")]
	public static bool JACCNGOPODK(IMJAJJJILNA GCMDJKOKHCO, IMJAJJJILNA LGCDJBDIEJC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x60C16B0", Offset = "0x60C04B0", VA = "0x1860C16B0")]
	public static bool PONNJIKFNKJ(IMJAJJJILNA GCMDJKOKHCO, IMJAJJJILNA LGCDJBDIEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x60C7460", Offset = "0x60C6260", VA = "0x1860C7460", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "4")]
	public bool Equals(IMJAJJJILNA FPEEGIOMOFF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0")]
	public static IMJAJJJILNA EADAJIFKEOK(MIGCCDNHDEL GDLGHGPGIOA)
	{
		return default(IMJAJJJILNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x60C75E0", Offset = "0x60C63E0", VA = "0x1860C75E0")]
	public EFACEBFDCDO HPEFPFBNCKN()
	{
		return default(EFACEBFDCDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x60C7530", Offset = "0x60C6330", VA = "0x1860C7530")]
	public DGGHBPCOPFF FLJJEPPCAGK()
	{
		return default(DGGHBPCOPFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x60C7A00", Offset = "0x60C6800", VA = "0x1860C7A00")]
	public ONOPCOLEGDI NOIAPEOIIHE()
	{
		return default(ONOPCOLEGDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x60C7830", Offset = "0x60C6630", VA = "0x1860C7830")]
	public void LEDAEDECAOJ([Optional] object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x60C7A50", Offset = "0x60C6850", VA = "0x1860C7A50")]
	public bool OFCAKKBODJB(object NBGOKNOECBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x60C7910", Offset = "0x60C6710", VA = "0x1860C7910")]
	public bool MJAHKFLNCPD(object NBGOKNOECBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x60C7B80", Offset = "0x60C6980", VA = "0x1860C7B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct IBKPGMABGHB : IEquatable<IBKPGMABGHB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public MIGCCDNHDEL AMEJLJKIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(MIGCCDNHDEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public IMJAJJJILNA FELLAFAONPG
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	private NEPAPILBIHM LKLADFJBKCO
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x60C0AD0", Offset = "0x60BF8D0", VA = "0x1860C0AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	private IECCBCMHOEC HOMFGFJJJBN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x60C5870", Offset = "0x60C4670", VA = "0x1860C5870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	private DKBBMGDJMLO DGMCIKCPDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x60C55D0", Offset = "0x60C43D0", VA = "0x1860C55D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool MCMALMJBHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x60C5B60", Offset = "0x60C4960", VA = "0x1860C5B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public Guid IKIMANOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x60C59A0", Offset = "0x60C47A0", VA = "0x1860C59A0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public bool INGGAIABJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x60C57E0", Offset = "0x60C45E0", VA = "0x1860C57E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public Guid LFNEIHLFHBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x60C54B0", Offset = "0x60C42B0", VA = "0x1860C54B0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0")]
	public IBKPGMABGHB(MIGCCDNHDEL IOGJGBJCGKK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x60BFD10", Offset = "0x60BEB10", VA = "0x1860BFD10")]
	public static bool EADAJIFKEOK(IBKPGMABGHB NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x60C5420", Offset = "0x60C4220", VA = "0x1860C5420", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "4")]
	public bool Equals(IBKPGMABGHB FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFF0", Offset = "0x60BDDF0", VA = "0x1860BEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x60C5900", Offset = "0x60C4700", VA = "0x1860C5900")]
	public bool MGAMNMPOIMC([Out] Guid MOJJMHEPCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x60C5300", Offset = "0x60C4100", VA = "0x1860C5300")]
	public void DAJNFIGKLIJ(Guid NGFDKOKHGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x60C5AC0", Offset = "0x60C48C0", VA = "0x1860C5AC0")]
	public bool MJPHNCNBECE([Out] Guid IBLKHIACFEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x60C56C0", Offset = "0x60C44C0", VA = "0x1860C56C0")]
	public void IAEFMHFHBPJ(Guid NGFDKOKHGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x60C5630", Offset = "0x60C4430", VA = "0x1860C5630")]
	public void FIEGOALBIOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct ONOPCOLEGDI : IEquatable<ONOPCOLEGDI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public MIGCCDNHDEL AMEJLJKIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(MIGCCDNHDEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public IMJAJJJILNA FELLAFAONPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private NEPAPILBIHM LKLADFJBKCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x60C0AD0", Offset = "0x60BF8D0", VA = "0x1860C0AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private IECCBCMHOEC HOMFGFJJJBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x60CFC50", Offset = "0x60CEA50", VA = "0x1860CFC50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private OJKBFKGCFKK HEIGJKHPFJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x60CFCE0", Offset = "0x60CEAE0", VA = "0x1860CFCE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float3 DNNLIPCDJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x60CFB20", Offset = "0x60CE920", VA = "0x1860CFB20")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public quaternion PPMGIEOCAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x60CFDD0", Offset = "0x60CEBD0", VA = "0x1860CFDD0")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public IMJAJJJILNA OJBLEGNMFBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x60CFD40", Offset = "0x60CEB40", VA = "0x1860CFD40")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0")]
	public ONOPCOLEGDI(MIGCCDNHDEL IOGJGBJCGKK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0")]
	public static MIGCCDNHDEL EADAJIFKEOK(ONOPCOLEGDI NKKIECLCEML)
	{
		return default(MIGCCDNHDEL);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x60CFA90", Offset = "0x60CE890", VA = "0x1860CFA90", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "4")]
	public bool Equals(ONOPCOLEGDI FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFF0", Offset = "0x60BDDF0", VA = "0x1860BEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct EFACEBFDCDO : IEquatable<EFACEBFDCDO>
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly EFACEBFDCDO KOOIJIDLAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public MIGCCDNHDEL AMEJLJKIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(MIGCCDNHDEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public IMJAJJJILNA FELLAFAONPG
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public KGAGFPJCGEF EHAKBGMPING
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(KGAGFPJCGEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public KLEFMODELJN GNCIEAAOHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(KLEFMODELJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private NEPAPILBIHM LKLADFJBKCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x60C0AD0", Offset = "0x60BF8D0", VA = "0x1860C0AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private IECCBCMHOEC HOMFGFJJJBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x60C3830", Offset = "0x60C2630", VA = "0x1860C3830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private ODIANNFGKAF PFDBOBHNDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x60C36A0", Offset = "0x60C24A0", VA = "0x1860C36A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public OEAIGCFLLHH HAEJELEKAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x60C2F00", Offset = "0x60C1D00", VA = "0x1860C2F00")]
		get
		{
			return default(OEAIGCFLLHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public IEnumerable<IMJAJJJILNA> CGEECCJFLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x60C3530", Offset = "0x60C2330", VA = "0x1860C3530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public IEnumerable<IMJAJJJILNA> JCKLDPLGJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x60C2DD0", Offset = "0x60C1BD0", VA = "0x1860C2DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public int OGMCKIIPBPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x60C34A0", Offset = "0x60C22A0", VA = "0x1860C34A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public int AFMKANGIJMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x60C3030", Offset = "0x60C1E30", VA = "0x1860C3030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public string GMLPMAJDOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x60C26C0", Offset = "0x60C14C0", VA = "0x1860C26C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x60C3110", Offset = "0x60C1F10", VA = "0x1860C3110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public HIDCIFMCKAM JAFJIPNNHOC
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x60C41F0", Offset = "0x60C2FF0", VA = "0x1860C41F0")]
		get
		{
			return default(HIDCIFMCKAM);
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x60C4310", Offset = "0x60C3110", VA = "0x1860C4310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public KHCGBLHLHMN EOEOBOMMEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x60C42B0", Offset = "0x60C30B0", VA = "0x1860C42B0")]
		get
		{
			return default(KHCGBLHLHMN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x60C2A90", Offset = "0x60C1890", VA = "0x1860C2A90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public HLOOMFKOIJH MHCEHCLDGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x60C2770", Offset = "0x60C1570", VA = "0x1860C2770")]
		get
		{
			return default(HLOOMFKOIJH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x60C3A70", Offset = "0x60C2870", VA = "0x1860C3A70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public float KBPJJBIBHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x60C3700", Offset = "0x60C2500", VA = "0x1860C3700")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x60C3AE0", Offset = "0x60C28E0", VA = "0x1860C3AE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool NAMLLFNACEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x60C4250", Offset = "0x60C3050", VA = "0x1860C4250")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x60C2FC0", Offset = "0x60C1DC0", VA = "0x1860C2FC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool LNMDJKADLIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x60C2590", Offset = "0x60C1390", VA = "0x1860C2590")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x60C4110", Offset = "0x60C2F10", VA = "0x1860C4110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool NEHDDJNAIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x60C43F0", Offset = "0x60C31F0", VA = "0x1860C43F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x60C4180", Offset = "0x60C2F80", VA = "0x1860C4180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool KDDCJIBPPKG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x60C3920", Offset = "0x60C2720", VA = "0x1860C3920")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x60C3980", Offset = "0x60C2780", VA = "0x1860C3980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool GEHOBBDPABA
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x60C25F0", Offset = "0x60C13F0", VA = "0x1860C25F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x60C4380", Offset = "0x60C3180", VA = "0x1860C4380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool BJFEFJCCCBL
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x60C37D0", Offset = "0x60C25D0", VA = "0x1860C37D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x60C3760", Offset = "0x60C2560", VA = "0x1860C3760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool JHODPNMKMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x60C38C0", Offset = "0x60C26C0", VA = "0x1860C38C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x60C2A20", Offset = "0x60C1820", VA = "0x1860C2A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public OPGILECLNBH MJEDMLECPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x60C44F0", Offset = "0x60C32F0", VA = "0x1860C44F0")]
		get
		{
			return default(OPGILECLNBH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x60C2B00", Offset = "0x60C1900", VA = "0x1860C2B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public IEnumerable<int> NFNBMEBNGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x60C2980", Offset = "0x60C1780", VA = "0x1860C2980")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x60C2B70", Offset = "0x60C1970", VA = "0x1860C2B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public int DAIBDIKPPDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x60C4450", Offset = "0x60C3250", VA = "0x1860C4450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0")]
	public EFACEBFDCDO(MIGCCDNHDEL IOGJGBJCGKK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x60BFD10", Offset = "0x60BEB10", VA = "0x1860BFD10")]
	public static bool EADAJIFKEOK(EFACEBFDCDO NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x60C3080", Offset = "0x60C1E80", VA = "0x1860C3080", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "4")]
	public bool Equals(EFACEBFDCDO FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFF0", Offset = "0x60BDDF0", VA = "0x1860BEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0")]
	public static IMJAJJJILNA EADAJIFKEOK(EFACEBFDCDO PPDHICBEIFC)
	{
		return default(IMJAJJJILNA);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x60C40F0", Offset = "0x60C2EF0", VA = "0x1860C40F0")]
	public bool LAGOCLCFLIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x60C2650", Offset = "0x60C1450", VA = "0x1860C2650")]
	public bool AIMPCJFMBAD(NONJHGAANGP KFDHFHHOOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x60C39F0", Offset = "0x60C27F0", VA = "0x1860C39F0")]
	public void JJFKLBGHMEO(NONJHGAANGP KFDHFHHOOMP, bool NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x60C27D0", Offset = "0x60C15D0", VA = "0x1860C27D0")]
	public OEAIGCFLLHH BFHEHOIGJBM(Allocator MGPHHCICJPF)
	{
		return default(OEAIGCFLLHH);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x60C31C0", Offset = "0x60C1FC0", VA = "0x1860C31C0")]
	public void FGLGAJGDDIF(EFACEBFDCDO FPEEGIOMOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x60C3B50", Offset = "0x60C2950", VA = "0x1860C3B50")]
	public void KIJBLHBJJNC(List<IMJAJJJILNA> HHINNDPJDPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct AECACGGIBNL : IEquatable<AECACGGIBNL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public IMJAJJJILNA FELLAFAONPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x60BF010", Offset = "0x60BDE10", VA = "0x1860BF010", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "4")]
	public bool Equals(AECACGGIBNL FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFF0", Offset = "0x60BDDF0", VA = "0x1860BEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct IIHLCAHNMLK : IEquatable<IIHLCAHNMLK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public IMJAJJJILNA FELLAFAONPG
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private NEPAPILBIHM LKLADFJBKCO
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x60C0AD0", Offset = "0x60BF8D0", VA = "0x1860C0AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0")]
	public IIHLCAHNMLK(MIGCCDNHDEL IOGJGBJCGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x60C5D30", Offset = "0x60C4B30", VA = "0x1860C5D30", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "4")]
	public bool Equals(IIHLCAHNMLK FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFF0", Offset = "0x60BDDF0", VA = "0x1860BEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x60C5BF0", Offset = "0x60C49F0", VA = "0x1860C5BF0")]
	public void ECEAPGIDAKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x60C5C90", Offset = "0x60C4A90", VA = "0x1860C5C90")]
	public void ELALDILJBKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct IKIALGBCCAF : IEquatable<IKIALGBCCAF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public IMJAJJJILNA FELLAFAONPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x60C6FD0", Offset = "0x60C5DD0", VA = "0x1860C6FD0", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "4")]
	public bool Equals(IKIALGBCCAF FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFF0", Offset = "0x60BDDF0", VA = "0x1860BEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct MMAIBCBMEHE : IEquatable<MMAIBCBMEHE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public IMJAJJJILNA FELLAFAONPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x60CCC40", Offset = "0x60CBA40", VA = "0x1860CCC40", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "4")]
	public bool Equals(MMAIBCBMEHE FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFF0", Offset = "0x60BDDF0", VA = "0x1860BEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public readonly struct BKMFFAKAGIL : IEquatable<BKMFFAKAGIL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public IMJAJJJILNA FELLAFAONPG
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x60BFC80", Offset = "0x60BEA80", VA = "0x1860BFC80", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "4")]
	public bool Equals(BKMFFAKAGIL FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFF0", Offset = "0x60BDDF0", VA = "0x1860BEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct BCJPFNNJMKK : IEquatable<BCJPFNNJMKK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public IMJAJJJILNA FELLAFAONPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x60BF140", Offset = "0x60BDF40", VA = "0x1860BF140", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "4")]
	public bool Equals(BCJPFNNJMKK FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFF0", Offset = "0x60BDDF0", VA = "0x1860BEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct KLEFMODELJN : IEquatable<KLEFMODELJN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public MIGCCDNHDEL AMEJLJKIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(MIGCCDNHDEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public IMJAJJJILNA FELLAFAONPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	private NEPAPILBIHM LKLADFJBKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x60C0AD0", Offset = "0x60BF8D0", VA = "0x1860C0AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	private IECCBCMHOEC HOMFGFJJJBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x60CAB10", Offset = "0x60C9910", VA = "0x1860CAB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private ODIANNFGKAF PFDBOBHNDPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x60CA8E0", Offset = "0x60C96E0", VA = "0x1860CA8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public MIGCCDNHDEL BGEJPFHDMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x60CACC0", Offset = "0x60C9AC0", VA = "0x1860CACC0")]
		get
		{
			return default(MIGCCDNHDEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public IMJAJJJILNA DIOGANGKEJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x60CA850", Offset = "0x60C9650", VA = "0x1860CA850")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public IMJAJJJILNA CGOAPMHKIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x60CA730", Offset = "0x60C9530", VA = "0x1860CA730")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0")]
	public KLEFMODELJN(MIGCCDNHDEL IOGJGBJCGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x60CA6A0", Offset = "0x60C94A0", VA = "0x1860CA6A0", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "4")]
	public bool Equals(KLEFMODELJN FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFF0", Offset = "0x60BDDF0", VA = "0x1860BEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x60CA9E0", Offset = "0x60C97E0", VA = "0x1860CA9E0")]
	public bool IEJEABLOHEA(IMJAJJJILNA AJKCELPHOFC, bool IACPBLHMLLC = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x60CA940", Offset = "0x60C9740", VA = "0x1860CA940")]
	public bool HMCKMKJJLHM(IMJAJJJILNA CGCPLEANCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x60CA410", Offset = "0x60C9210", VA = "0x1860CA410")]
	private void EMEMHMGKAOK(IMJAJJJILNA FKPBAFKNJJP, List<IMJAJJJILNA> BIHFKLNEJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x60CA7C0", Offset = "0x60C95C0", VA = "0x1860CA7C0")]
	public EFACEBFDCDO FHIBDGGGOOK()
	{
		return default(EFACEBFDCDO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x60CAD50", Offset = "0x60C9B50", VA = "0x1860CAD50")]
	public void OCGFHKAMDDN(List<IMJAJJJILNA> HNGJCCLKLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x60CABA0", Offset = "0x60C99A0", VA = "0x1860CABA0")]
	public NativeArray<MIGCCDNHDEL> NELFBEKOIFL()
	{
		return default(NativeArray<MIGCCDNHDEL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct GEDFGHFFCDF : IEquatable<GEDFGHFFCDF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public IMJAJJJILNA FELLAFAONPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public string GICPKDKGGCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x60C49A0", Offset = "0x60C37A0", VA = "0x1860C49A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public string DMJOLEIAKIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x60C4AB0", Offset = "0x60C38B0", VA = "0x1860C4AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool ACJEDFEPJOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x60C4B80", Offset = "0x60C3980", VA = "0x1860C4B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public string CFGHKIAKHGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x60C4DB0", Offset = "0x60C3BB0", VA = "0x1860C4DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public string NMGFDLDCEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x60C4750", Offset = "0x60C3550", VA = "0x1860C4750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public string JLHNBBBHLJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x60C4CC0", Offset = "0x60C3AC0", VA = "0x1860C4CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0")]
	public GEDFGHFFCDF(MIGCCDNHDEL IOGJGBJCGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x60C4A20", Offset = "0x60C3820", VA = "0x1860C4A20", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "4")]
	public bool Equals(GEDFGHFFCDF FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFF0", Offset = "0x60BDDF0", VA = "0x1860BEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct PGJFPMJFBJD : IEquatable<PGJFPMJFBJD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public IMJAJJJILNA FELLAFAONPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x60CFEF0", Offset = "0x60CECF0", VA = "0x1860CFEF0", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "4")]
	public bool Equals(PGJFPMJFBJD FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFF0", Offset = "0x60BDDF0", VA = "0x1860BEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct AAFPIKOKCHE : IEquatable<AAFPIKOKCHE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public IMJAJJJILNA FELLAFAONPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0")]
	public AAFPIKOKCHE(MIGCCDNHDEL IOGJGBJCGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x60BEDB0", Offset = "0x60BDBB0", VA = "0x1860BEDB0", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "4")]
	public bool Equals(AAFPIKOKCHE FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFF0", Offset = "0x60BDDF0", VA = "0x1860BEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE80", Offset = "0x60BDC80", VA = "0x1860BEE80")]
	public bool HMPPMPFFPJN([Out] Collider ABKAPOJFHND)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct IJPIFPKLFGL : IEquatable<IJPIFPKLFGL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public MIGCCDNHDEL AMEJLJKIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(MIGCCDNHDEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public IMJAJJJILNA FELLAFAONPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private NEPAPILBIHM LKLADFJBKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x60C0AD0", Offset = "0x60BF8D0", VA = "0x1860C0AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private IECCBCMHOEC HOMFGFJJJBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x60C6740", Offset = "0x60C5540", VA = "0x1860C6740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private ObjectPolicyDataWrapper BEDMHJIBAIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x60C6480", Offset = "0x60C5280", VA = "0x1860C6480")]
		get
		{
			return default(ObjectPolicyDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private NavMeshGenerationDataWrapper AGIKDMEJNBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x60C6EA0", Offset = "0x60C5CA0", VA = "0x1860C6EA0")]
		get
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool MMJFLOLHNNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x60C64E0", Offset = "0x60C52E0", VA = "0x1860C64E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool OJIIDHEDHBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x60C6CC0", Offset = "0x60C5AC0", VA = "0x1860C6CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool GFHNBIMPABF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x60C60F0", Offset = "0x60C4EF0", VA = "0x1860C60F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool PGHCHOFEKLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x60C6C50", Offset = "0x60C5A50", VA = "0x1860C6C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool HBBEKMCEPFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x60C62A0", Offset = "0x60C50A0", VA = "0x1860C62A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool FDKLBADHHFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x60C6B00", Offset = "0x60C5900", VA = "0x1860C6B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool DCHOMFCJABC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x60C6160", Offset = "0x60C4F60", VA = "0x1860C6160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool IBMKNHFHMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x60C6F00", Offset = "0x60C5D00", VA = "0x1860C6F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool DFGPGJDJHNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x60C6080", Offset = "0x60C4E80", VA = "0x1860C6080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool PCHEEGGPNMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x60C6520", Offset = "0x60C5320", VA = "0x1860C6520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool JCHFBFCHHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x60C66D0", Offset = "0x60C54D0", VA = "0x1860C66D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool GKDHPIJAGOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x60C63A0", Offset = "0x60C51A0", VA = "0x1860C63A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool NNIILFEAKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x60C61D0", Offset = "0x60C4FD0", VA = "0x1860C61D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool FIGIACMIMIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x60C6590", Offset = "0x60C5390", VA = "0x1860C6590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool HAEKMBCFPGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x60C6670", Offset = "0x60C5470", VA = "0x1860C6670")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x60C6B70", Offset = "0x60C5970", VA = "0x1860C6B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public MIHOOCPGHPC BAFDHKFBKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x60C6240", Offset = "0x60C5040", VA = "0x1860C6240")]
		get
		{
			return default(MIHOOCPGHPC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x60C6BE0", Offset = "0x60C59E0", VA = "0x1860C6BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool HICFDFMCKKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x60C6930", Offset = "0x60C5730", VA = "0x1860C6930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public ADOEKHBDHCN BINEJBJAEBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x60C6F70", Offset = "0x60C5D70", VA = "0x1860C6F70")]
		get
		{
			return default(ADOEKHBDHCN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool BPLGGKJEBCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x60C68D0", Offset = "0x60C56D0", VA = "0x1860C68D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Vector3 OMOKLCIDAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x60C6DE0", Offset = "0x60C5BE0", VA = "0x1860C6DE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Vector3 FMGIFDJBBJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x60C6D30", Offset = "0x60C5B30", VA = "0x1860C6D30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool LCIJKEHIHGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x60C67D0", Offset = "0x60C55D0", VA = "0x1860C67D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0")]
	public IJPIFPKLFGL(MIGCCDNHDEL IOGJGBJCGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x60C6310", Offset = "0x60C5110", VA = "0x1860C6310", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "4")]
	public bool Equals(IJPIFPKLFGL FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFF0", Offset = "0x60BDDF0", VA = "0x1860BEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x60C6010", Offset = "0x60C4E10", VA = "0x1860C6010")]
	public bool AHKOKKAOMFM(CBPNEJPCKLD KFDHFHHOOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x60C6410", Offset = "0x60C5210", VA = "0x1860C6410")]
	public bool FHCKNCPFANP(HJHFJNCLMIG KFDHFHHOOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x60C65F0", Offset = "0x60C53F0", VA = "0x1860C65F0")]
	public void HCIAGLAIKNM(HJHFJNCLMIG KFDHFHHOOMP, bool FDOMNJMGLCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct NEHIFFEKPLE : IEquatable<NEHIFFEKPLE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public MIGCCDNHDEL AMEJLJKIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(MIGCCDNHDEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public IMJAJJJILNA FELLAFAONPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	private NEPAPILBIHM LKLADFJBKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x60C0AD0", Offset = "0x60BF8D0", VA = "0x1860C0AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private IECCBCMHOEC HOMFGFJJJBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x60CCE90", Offset = "0x60CBC90", VA = "0x1860CCE90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0")]
	public NEHIFFEKPLE(MIGCCDNHDEL IOGJGBJCGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x60CCD70", Offset = "0x60CBB70", VA = "0x1860CCD70", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "4")]
	public bool Equals(NEHIFFEKPLE FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFF0", Offset = "0x60BDDF0", VA = "0x1860BEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x60CCE00", Offset = "0x60CBC00", VA = "0x1860CCE00")]
	public void IIFJIANHIPK(bool NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x60CCF20", Offset = "0x60CBD20", VA = "0x1860CCF20")]
	public void LHGHNHDAPFD(bool NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x282A800", Offset = "0x2829600", VA = "0x18282A800")]
	public T ODDKLDFMJND<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct DDHDJGOGPPL : IEquatable<DDHDJGOGPPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public MIGCCDNHDEL AMEJLJKIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(MIGCCDNHDEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public IMJAJJJILNA FELLAFAONPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	private NEPAPILBIHM LKLADFJBKCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x60C0AD0", Offset = "0x60BF8D0", VA = "0x1860C0AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private IECCBCMHOEC HOMFGFJJJBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x60C0840", Offset = "0x60BF640", VA = "0x1860C0840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private BNDBHDACPHO DEEFFFANDIP
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x60C06D0", Offset = "0x60BF4D0", VA = "0x1860C06D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	private DAFPGOIBLIB JLDKLCPDFKK
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x60C0DE0", Offset = "0x60BFBE0", VA = "0x1860C0DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public bool AHCGGONPOBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x60C0120", Offset = "0x60BEF20", VA = "0x1860C0120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool PBOEEMKHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x60C0D40", Offset = "0x60BFB40", VA = "0x1860C0D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool LNHJNJPFEFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x60C0A00", Offset = "0x60BF800", VA = "0x1860C0A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool FMLNLNJMFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x60C0600", Offset = "0x60BF400", VA = "0x1860C0600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool AIFEDEICNPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x60C02C0", Offset = "0x60BF0C0", VA = "0x1860C02C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public bool NDAOIGCMMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x60C0970", Offset = "0x60BF770", VA = "0x1860C0970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public bool BOJNKEFCPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x60C02F0", Offset = "0x60BF0F0", VA = "0x1860C02F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public bool NNKAKDNHAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x60C0BD0", Offset = "0x60BF9D0", VA = "0x1860C0BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0")]
	public DDHDJGOGPPL(MIGCCDNHDEL IOGJGBJCGKK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x60BFD10", Offset = "0x60BEB10", VA = "0x1860BFD10")]
	public static bool EADAJIFKEOK(DDHDJGOGPPL NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x60C0500", Offset = "0x60BF300", VA = "0x1860C0500", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "4")]
	public bool Equals(DDHDJGOGPPL FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFF0", Offset = "0x60BDDF0", VA = "0x1860BEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x60C0590", Offset = "0x60BF390", VA = "0x1860C0590")]
	public bool GNOLDFJHBPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x60C0A30", Offset = "0x60BF830", VA = "0x1860C0A30")]
	public IMJAJJJILNA MAGKJHHDOBC(IMJAJJJILNA KAKJJOAALHM)
	{
		return default(IMJAJJJILNA);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x60C0730", Offset = "0x60BF530", VA = "0x1860C0730")]
	public MIGCCDNHDEL IIFOIAJHGHG()
	{
		return default(MIGCCDNHDEL);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x60C0B30", Offset = "0x60BF930", VA = "0x1860C0B30")]
	public bool NGMNJHPDPMO(MIGCCDNHDEL LPGGFINOBAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x60C08D0", Offset = "0x60BF6D0", VA = "0x1860C08D0")]
	public bool IOKAOGAHBLC(MIGCCDNHDEL JAAKLJFMDMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x60C01B0", Offset = "0x60BEFB0", VA = "0x1860C01B0")]
	public bool CCMJJAODEIC(MIGCCDNHDEL KAKJJOAALHM, [Out] MIGCCDNHDEL LPGGFINOBAM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct DGGHBPCOPFF : IEquatable<DGGHBPCOPFF>
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly DGGHBPCOPFF KOOIJIDLAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public MIGCCDNHDEL AMEJLJKIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(MIGCCDNHDEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public IMJAJJJILNA FELLAFAONPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public KGAGFPJCGEF EHAKBGMPING
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(KGAGFPJCGEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private ShapeTypeDataWrapper DKIMDBKBEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x60C14E0", Offset = "0x60C02E0", VA = "0x1860C14E0")]
		get
		{
			return default(ShapeTypeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public StandardRenderableVisualDataWrapper BFDALDCKCIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x60C1000", Offset = "0x60BFE00", VA = "0x1860C1000")]
		get
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public PhysicsMaterialDataWrapper KLNKLNCIJEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x60C12B0", Offset = "0x60C00B0", VA = "0x1860C12B0")]
		get
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public ShapeConfigDataWrapper ADOJBFDGCPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x60C1150", Offset = "0x60BFF50", VA = "0x1860C1150")]
		get
		{
			return default(ShapeConfigDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public HNFAPBIOGOE LCBCHJFIBJD
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x60C1540", Offset = "0x60C0340", VA = "0x1860C1540")]
		get
		{
			return default(HNFAPBIOGOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public NODCJNFOCGG BDGDBNCMBEH
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x60C1310", Offset = "0x60C0110", VA = "0x1860C1310")]
		get
		{
			return default(NODCJNFOCGG);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x60C0F90", Offset = "0x60BFD90", VA = "0x1860C0F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public NHCCMKBOPPD NLLGBGNAADK
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x60C0E40", Offset = "0x60BFC40", VA = "0x1860C0E40")]
		get
		{
			return default(NHCCMKBOPPD);
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x60C11B0", Offset = "0x60BFFB0", VA = "0x1860C11B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public float CLLBCLAJGHA
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x60C1410", Offset = "0x60C0210", VA = "0x1860C1410")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x60C0EA0", Offset = "0x60BFCA0", VA = "0x1860C0EA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public Vector3 KNLPIPANCLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x60C1370", Offset = "0x60C0170", VA = "0x1860C1370")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x60C15B0", Offset = "0x60C03B0", VA = "0x1860C15B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public float GKABDFEABHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x60C10E0", Offset = "0x60BFEE0", VA = "0x1860C10E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public DLCHMDBBJIK HMMFAGIMMOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x60C1650", Offset = "0x60C0450", VA = "0x1860C1650")]
		get
		{
			return default(DLCHMDBBJIK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x60C1470", Offset = "0x60C0270", VA = "0x1860C1470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0")]
	public DGGHBPCOPFF(MIGCCDNHDEL IOGJGBJCGKK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x60BFD10", Offset = "0x60BEB10", VA = "0x1860BFD10")]
	public static bool EADAJIFKEOK(DGGHBPCOPFF NKKIECLCEML)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x60C16B0", Offset = "0x60C04B0", VA = "0x1860C16B0")]
	public static bool PONNJIKFNKJ(DGGHBPCOPFF GCMDJKOKHCO, DGGHBPCOPFF LGCDJBDIEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x60C1220", Offset = "0x60C0020", VA = "0x1860C1220", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "4")]
	public bool Equals(DGGHBPCOPFF FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFF0", Offset = "0x60BDDF0", VA = "0x1860BEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x60C0F10", Offset = "0x60BFD10", VA = "0x1860C0F10")]
	public CBJAMMNEJCO BOPGHEFKOIE()
	{
		return default(CBJAMMNEJCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x60C1060", Offset = "0x60BFE60", VA = "0x1860C1060")]
	public EEOHOBEANBK DADKPNBAIGE()
	{
		return default(EEOHOBEANBK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct CBJAMMNEJCO : IEquatable<CBJAMMNEJCO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public MIGCCDNHDEL AMEJLJKIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(MIGCCDNHDEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public IMJAJJJILNA FELLAFAONPG
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public DGGHBPCOPFF NMPNIEFCGGH
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(DGGHBPCOPFF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	private PrimitiveShapeDataWrapper IEKAAHOECEK
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x60BFDC0", Offset = "0x60BEBC0", VA = "0x1860BFDC0")]
		get
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public MCEJPAIOHJF PJBJKGPHCDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x60BFE20", Offset = "0x60BEC20", VA = "0x1860BFE20")]
		get
		{
			return default(MCEJPAIOHJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0")]
	public CBJAMMNEJCO(MIGCCDNHDEL IOGJGBJCGKK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x60BFD10", Offset = "0x60BEB10", VA = "0x1860BFD10")]
	public static bool EADAJIFKEOK(CBJAMMNEJCO NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x60BFD30", Offset = "0x60BEB30", VA = "0x1860BFD30", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "4")]
	public bool Equals(CBJAMMNEJCO FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFF0", Offset = "0x60BDDF0", VA = "0x1860BEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[DefaultMember("Item")]
public readonly struct EEOHOBEANBK : IEquatable<EEOHOBEANBK>
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly EEOHOBEANBK KOOIJIDLAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public MIGCCDNHDEL AMEJLJKIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(MIGCCDNHDEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public IMJAJJJILNA FELLAFAONPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public KGAGFPJCGEF EHAKBGMPING
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(KGAGFPJCGEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	private NEPAPILBIHM LKLADFJBKCO
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x60C0AD0", Offset = "0x60BF8D0", VA = "0x1860C0AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	private IECCBCMHOEC HOMFGFJJJBN
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x60C2100", Offset = "0x60C0F00", VA = "0x1860C2100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	private MEPJABONPCO NMABOFONIGH
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x60C1810", Offset = "0x60C0610", VA = "0x1860C1810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public DGGHBPCOPFF NMPNIEFCGGH
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(DGGHBPCOPFF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public CECJBHNPNAC JAMOOHLGDLK
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x60C2230", Offset = "0x60C1030", VA = "0x1860C2230")]
		get
		{
			return default(CECJBHNPNAC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x60C1900", Offset = "0x60C0700", VA = "0x1860C1900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public IEnumerable<NIIDFDHEJBF> NDFDCPDDEFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x60C1AB0", Offset = "0x60C08B0", VA = "0x1860C1AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public NIIDFDHEJBF LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x60C1CC0", Offset = "0x60C0AC0", VA = "0x1860C1CC0")]
		get
		{
			return default(NIIDFDHEJBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public int DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x60C2190", Offset = "0x60C0F90", VA = "0x1860C2190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0")]
	public EEOHOBEANBK(MIGCCDNHDEL IOGJGBJCGKK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x60BFD10", Offset = "0x60BEB10", VA = "0x1860BFD10")]
	public static bool EADAJIFKEOK(EEOHOBEANBK NKKIECLCEML)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x60C2220", Offset = "0x60C1020", VA = "0x1860C2220")]
	public static bool JACCNGOPODK(EEOHOBEANBK GCMDJKOKHCO, EEOHOBEANBK LGCDJBDIEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x60C1A20", Offset = "0x60C0820", VA = "0x1860C1A20", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "4")]
	public bool Equals(EEOHOBEANBK FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFF0", Offset = "0x60BDDF0", VA = "0x1860BEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x60C1DD0", Offset = "0x60C0BD0", VA = "0x1860C1DD0")]
	public NIIDFDHEJBF ICLMOFPCEIP(float3? JCOIMLJCHFJ, [Optional] quaternion? GJMDICOFEBG, [Optional] Vector3? NANBGKEHFBG)
	{
		return default(NIIDFDHEJBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x60C2360", Offset = "0x60C1160", VA = "0x1860C2360")]
	public NIIDFDHEJBF PALGEKGKIDP(int ENPOKNEMOMH, float3? JCOIMLJCHFJ, [Optional] quaternion? GJMDICOFEBG, [Optional] Vector3? NANBGKEHFBG)
	{
		return default(NIIDFDHEJBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x60C1FF0", Offset = "0x60C0DF0", VA = "0x1860C1FF0")]
	public void IHIODFMFKMD(int ENPOKNEMOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x60C1870", Offset = "0x60C0670", VA = "0x1860C1870")]
	public void BBGCGJHDDBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct NIIDFDHEJBF : IEquatable<NIIDFDHEJBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public MIGCCDNHDEL AMEJLJKIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(MIGCCDNHDEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public IMJAJJJILNA FELLAFAONPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public EEOHOBEANBK JNEKDFIHIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x60CD190", Offset = "0x60CBF90", VA = "0x1860CD190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public float3 FGMHAIMGDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x60CD450", Offset = "0x60CC250", VA = "0x1860CD450")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x60CD010", Offset = "0x60CBE10", VA = "0x1860CD010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public quaternion LMICPFEIIJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x60CD280", Offset = "0x60CC080", VA = "0x1860CD280")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x60CD090", Offset = "0x60CBE90", VA = "0x1860CD090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public float3 FEDAMMADAHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x60CD370", Offset = "0x60CC170", VA = "0x1860CD370")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x60CD530", Offset = "0x60CC330", VA = "0x1860CD530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public CGCPEDGLCON LHGGMJALACK
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x60CD300", Offset = "0x60CC100", VA = "0x1860CD300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	private SplinePointParentDataWrapper MMAABHNNAOE
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x60CCFB0", Offset = "0x60CBDB0", VA = "0x1860CCFB0")]
		get
		{
			return default(SplinePointParentDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	private SplinePointPositionDataWrapper KIBHGAFHMIO
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x60CD5B0", Offset = "0x60CC3B0", VA = "0x1860CD5B0")]
		get
		{
			return default(SplinePointPositionDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	private SplinePointRotationDataWrapper MLCAMPLNHMO
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x60CD3F0", Offset = "0x60CC1F0", VA = "0x1860CD3F0")]
		get
		{
			return default(SplinePointRotationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	private SplinePointScaleDataWrapper GFFOGJLLJHN
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x60CD4D0", Offset = "0x60CC2D0", VA = "0x1860CD4D0")]
		get
		{
			return default(SplinePointScaleDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	private SplinePointOrderDataWrapper KLCBHCDOIHH
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x60CD220", Offset = "0x60CC020", VA = "0x1860CD220")]
		get
		{
			return default(SplinePointOrderDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0")]
	public NIIDFDHEJBF(MIGCCDNHDEL IOGJGBJCGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x60CD100", Offset = "0x60CBF00", VA = "0x1860CD100", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "4")]
	public bool Equals(NIIDFDHEJBF FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFF0", Offset = "0x60BDDF0", VA = "0x1860BEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x60CD190", Offset = "0x60CBF90", VA = "0x1860CD190")]
	public void HFMAHBNLNMD(EEOHOBEANBK NKKIECLCEML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct KGAGFPJCGEF : IEquatable<KGAGFPJCGEF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public IMJAJJJILNA FELLAFAONPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public KLEFMODELJN GNCIEAAOHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(KLEFMODELJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	private NEPAPILBIHM LKLADFJBKCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x60C0AD0", Offset = "0x60BF8D0", VA = "0x1860C0AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	private DFABAHDIACI ILHGMDCNBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x60C9560", Offset = "0x60C8360", VA = "0x1860C9560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool CDCLHNPADBI
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x60C8D20", Offset = "0x60C7B20", VA = "0x1860C8D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public Vector3 FGMHAIMGDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x60C9770", Offset = "0x60C8570", VA = "0x1860C9770")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x60C84F0", Offset = "0x60C72F0", VA = "0x1860C84F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public Quaternion LMICPFEIIJH
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x60C9090", Offset = "0x60C7E90", VA = "0x1860C9090")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x60C8690", Offset = "0x60C7490", VA = "0x1860C8690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Vector3 CHHOCLKGNBO
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x60C8030", Offset = "0x60C6E30", VA = "0x1860C8030")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x60C8B20", Offset = "0x60C7920", VA = "0x1860C8B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Quaternion DCJMENCHFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x60C9620", Offset = "0x60C8420", VA = "0x1860C9620")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x60C9A20", Offset = "0x60C8820", VA = "0x1860C9A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public float AEBHJKHKDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x60CA370", Offset = "0x60C9170", VA = "0x1860CA370")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x60C9D80", Offset = "0x60C8B80", VA = "0x1860C9D80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public float NAACHPNFHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x60C8380", Offset = "0x60C7180", VA = "0x1860C8380")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public Vector3 FEDAMMADAHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x60C92D0", Offset = "0x60C80D0", VA = "0x1860C92D0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x60C9CB0", Offset = "0x60C8AB0", VA = "0x1860C9CB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Vector3 OBECHJMDFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x60C9AF0", Offset = "0x60C88F0", VA = "0x1860C9AF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Matrix4x4 KGCBBKIPHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x60C9FF0", Offset = "0x60C8DF0", VA = "0x1860C9FF0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0")]
	public KGAGFPJCGEF(MIGCCDNHDEL IOGJGBJCGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x60C8BF0", Offset = "0x60C79F0", VA = "0x1860C8BF0", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "4")]
	public bool Equals(KGAGFPJCGEF FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFF0", Offset = "0x60BDDF0", VA = "0x1860BEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x60C93C0", Offset = "0x60C81C0", VA = "0x1860C93C0")]
	public AMFINDHLENJ JGMDLKJAKBG()
	{
		return default(AMFINDHLENJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x60C8260", Offset = "0x60C7060", VA = "0x1860C8260")]
	public void BAOOENBNILO([Out] Matrix4x4 GBHGFIFOAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x60C8120", Offset = "0x60C6F20", VA = "0x1860C8120")]
	public void AGJKPHJBOAL([Out] Vector3 COMHNOLDLFA, [Out] Quaternion FKMBLIBDELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x60C89A0", Offset = "0x60C77A0", VA = "0x1860C89A0")]
	public void EIPDNGKJADC([Out] RigidTransform DAIEMHEDLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x60C9F00", Offset = "0x60C8D00", VA = "0x1860C9F00")]
	public PBAJPJIMDKJ PAMKNAMFMJC()
	{
		return default(PBAJPJIMDKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x60C9F30", Offset = "0x60C8D30", VA = "0x1860C9F30")]
	public void PAMKNAMFMJC([Out] PBAJPJIMDKJ LDOMCECECHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x60C9060", Offset = "0x60C7E60", VA = "0x1860C9060")]
	public PBAJPJIMDKJ HNHMNBODMEG()
	{
		return default(PBAJPJIMDKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x60C8FA0", Offset = "0x60C7DA0", VA = "0x1860C8FA0")]
	public void HNHMNBODMEG([Out] PBAJPJIMDKJ DAIEMHEDLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x60C9860", Offset = "0x60C8660", VA = "0x1860C9860")]
	public Vector3 MEAEFGFJANH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x60C85C0", Offset = "0x60C73C0", VA = "0x1860C85C0")]
	public void CIGDLPADLPF([In] Vector3 NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x60C8760", Offset = "0x60C7560", VA = "0x1860C8760")]
	public Vector3 EANHNNMAEME()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x60C8A50", Offset = "0x60C7850", VA = "0x1860C8A50")]
	public void EJEAHEJLGPE([In] Vector3 NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x60C8850", Offset = "0x60C7650", VA = "0x1860C8850")]
	public Quaternion EHNDAFKDPKG()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x60CA120", Offset = "0x60C8F20", VA = "0x1860CA120")]
	public void PGKPNEEBDNJ([In] Quaternion NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x60C9410", Offset = "0x60C8210", VA = "0x1860C9410")]
	public Quaternion KAAMMNEMGKC()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x60C9950", Offset = "0x60C8750", VA = "0x1860C9950")]
	public void MGKFEDDFLIJ([In] Quaternion NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x60C8F00", Offset = "0x60C7D00", VA = "0x1860C8F00")]
	public float HLNBKIFOEGC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x60C8E50", Offset = "0x60C7C50", VA = "0x1860C8E50")]
	public void FMKJLDPDIJB(float NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x60C8C80", Offset = "0x60C7A80", VA = "0x1860C8C80")]
	public float FIGEHDKCPAP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x60CA1F0", Offset = "0x60C8FF0", VA = "0x1860CA1F0")]
	public void PJOIBGHKFEF(float NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x60CA2A0", Offset = "0x60C90A0", VA = "0x1860CA2A0")]
	public void PLKBDLNEJEK([In] Vector3 NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x60CA030", Offset = "0x60C8E30", VA = "0x1860CA030")]
	public Vector3 PDHFEAGFHAE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x60C8420", Offset = "0x60C7220", VA = "0x1860C8420")]
	public void BNPNMKLDLFG([In] Vector3 NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x60C8D60", Offset = "0x60C7B60", VA = "0x1860C8D60")]
	public Vector3 FLHDOEFFEMJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x60C9BE0", Offset = "0x60C89E0", VA = "0x1860C9BE0")]
	public void NKGBBFGCBAH([In] Vector3 NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x60C91E0", Offset = "0x60C7FE0", VA = "0x1860C91E0")]
	public Vector3 JDMAAGNINAN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x60C9E30", Offset = "0x60C8C30", VA = "0x1860C9E30")]
	public void OKKLNINFPKG([In] Vector3 NKKIECLCEML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct NNOHNLLAFIJ : IEquatable<NNOHNLLAFIJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public MIGCCDNHDEL AMEJLJKIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(MIGCCDNHDEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public IMJAJJJILNA FELLAFAONPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
		get
		{
			return default(IMJAJJJILNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public int[] BJPBMGFDOKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x60CDA80", Offset = "0x60CC880", VA = "0x1860CDA80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool NAOPIEADIPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x60CDC70", Offset = "0x60CCA70", VA = "0x1860CDC70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x60CDB70", Offset = "0x60CC970", VA = "0x1860CDB70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0")]
	public NNOHNLLAFIJ(MIGCCDNHDEL IOGJGBJCGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE50", Offset = "0x60BDC50", VA = "0x1860BEE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x60CDBE0", Offset = "0x60CC9E0", VA = "0x1860CDBE0", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE40", Offset = "0x60BDC40", VA = "0x1860BEE40", Slot = "4")]
	public bool Equals(NNOHNLLAFIJ FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFF0", Offset = "0x60BDDF0", VA = "0x1860BEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class IKPMFMCNKJM
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct MCCHAMMIJPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid FANIDECOFDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public MNHJBKBGBCJ FIIMGJMCOBH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct MNHJBKBGBCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int NKKIECLCEML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int DHOELIAHPDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int JLLBMKNIENL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int OKDACPPHIEB;

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x60CCCD0", Offset = "0x60CBAD0", VA = "0x1860CCCD0")]
		public bool DPFNJIIGELO([Out] MHNLEJCAAIM DFMCILKNNOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x60CCD50", Offset = "0x60CBB50", VA = "0x1860CCD50")]
		public MNHJBKBGBCJ(MHNLEJCAAIM DFMCILKNNOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x60C7060", Offset = "0x60C5E60", VA = "0x1860C7060")]
	public static Guid LNCMNJNDMBA(this MHNLEJCAAIM DFMCILKNNOJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x60C70F0", Offset = "0x60C5EF0", VA = "0x1860C70F0")]
	public static bool NMOPFLFMJJH(this Guid FANIDECOFDM, [Out] MHNLEJCAAIM DFMCILKNNOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal static class HFNKGMCEDCP
{
	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x60C4FA0", Offset = "0x60C3DA0", VA = "0x1860C4FA0")]
	public static IECCBCMHOEC HOMFGFJJJBN(this MIGCCDNHDEL DGIBOINMLED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x60C5030", Offset = "0x60C3E30", VA = "0x1860C5030")]
	public static EBFBKHOOOEA IHDKOAAKCJK(this MIGCCDNHDEL DGIBOINMLED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x60C4EA0", Offset = "0x60C3CA0", VA = "0x1860C4EA0")]
	public static EntityManager DKPFEFECAOD(this MIGCCDNHDEL DGIBOINMLED)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x2712000", Offset = "0x2710E00", VA = "0x182712000")]
	public static T AKLKGJOCHHP<T>(this MIGCCDNHDEL DGIBOINMLED) where T : struct, EFLJMIKJDOL
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2713040", Offset = "0x2711E40", VA = "0x182713040")]
	public static bool HOIACFFFAAG<T>(this MIGCCDNHDEL DGIBOINMLED) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x27133B0", Offset = "0x27121B0", VA = "0x1827133B0")]
	public static bool MENEMJEFCLP<T>(this MIGCCDNHDEL DGIBOINMLED) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface DKBBMGDJMLO
{
	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INGGAIABJAF(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MCMALMJBHOO(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MGAMNMPOIMC(MIGCCDNHDEL IOGJGBJCGKK, [Out] Guid MOJJMHEPCMN);

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid FDBCIPIIAKM(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DAJNFIGKLIJ(MIGCCDNHDEL IOGJGBJCGKK, Guid MOJJMHEPCMN);

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MJPHNCNBECE(MIGCCDNHDEL IOGJGBJCGKK, [Out] Guid IBLKHIACFEF);

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid GOOPFCJBAJD(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IAEFMHFHBPJ(MIGCCDNHDEL IOGJGBJCGKK, Guid IBLKHIACFEF);

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FIEGOALBIOF(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task NGFBIDGMMBN(MIGCCDNHDEL BIFNKFCMILB, MIGCCDNHDEL AJKCELPHOFC);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[PFENABFDEFA(DCCNCNLIDJL.LoadInstance)]
public interface OEBKENNBEOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000122")]
	Guid DOOOPHKHHFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DPKGBOBMMFA(NativeList<Guid> CEIGPEFAPGA, NativeList<Guid> LIJEKDFJAPF, NativeList<FixedString64Bytes> PPCGPNCNEBH);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface MJBDPFKGJLO
{
	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJFABPHOMLP(List<MIGCCDNHDEL> GGNIELNEMEF);

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JPPDJIGBHMO(MIGCCDNHDEL CJGLJDBADGH);

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CAKKNLKKLAI(MIGCCDNHDEL CJGLJDBADGH);

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IMDMGKFEPLK(MIGCCDNHDEL CJGLJDBADGH);

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PNANHNBOPEA(MIGCCDNHDEL CJGLJDBADGH, int PMIHOHEADPP);

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MIGCCDNHDEL MJHHBDNLLJM(MIGCCDNHDEL MCFFCBKFGEO);

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BGMGMOFDDDL(MIGCCDNHDEL MCFFCBKFGEO, MIGCCDNHDEL EAMLCMCFDGK);

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OGMMGHLGOCN(MIGCCDNHDEL MCFFCBKFGEO);

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MPJAGEBPMCK(MIGCCDNHDEL GDLGHGPGIOA);

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ECFOMIENKEE(MIGCCDNHDEL IOGJGBJCGKK, bool JOJFOMPGGKD);

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NHFPDNMDHKP(MIGCCDNHDEL[] IMKJMOFIELG, bool JOJFOMPGGKD);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface HAAMGEKAOIM
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	IReadOnlyCollection<LMIGMJPCLHI> MABGAKOHJOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AJDIMKJEOCA(int CMJIGCCPHNK, [Out] LMIGMJPCLHI AHBOHNPMBLB);

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LMIGMJPCLHI MKPIDMGDLCE(Type HFFNCGFKMBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class LENLKKNHICE
{
	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x279BAA0", Offset = "0x279A8A0", VA = "0x18279BAA0")]
	public static T OBPCNBJJCHL<T>(this HAAMGEKAOIM MFFDBPLNNFL, Entity KEAAKDKHLOM) where T : struct, EFLJMIKJDOL
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x279AE40", Offset = "0x2799C40", VA = "0x18279AE40")]
	public static LMIGMJPCLHI MKPIDMGDLCE<T>(this HAAMGEKAOIM MFFDBPLNNFL) where T : struct, EFLJMIKJDOL
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface GJIPEINGCIJ
{
	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MHNLEJCAAIM[] HNPLKGMBCNJ(string OHHBGJPCFJD, IMJAJJJILNA DFHEIALDHKF, bool FEBBCHIJFKH = false);

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAGHPAJNNPE(string PDNLHMCHEMA, MHNLEJCAAIM[] MDPGDDGMJNJ);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[PFENABFDEFA(DCCNCNLIDJL.LoadInstance)]
public interface OJKBFKGCFKK
{
	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<MIGCCDNHDEL, MIGCCDNHDEL> BHBOMMFJFHI;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<MIGCCDNHDEL, MIGCCDNHDEL> BFHILKDNPBO;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<MIGCCDNHDEL, MIGCCDNHDEL, MIGCCDNHDEL> LCHHOKICNLA;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<MIGCCDNHDEL> AODBILELMPI;

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FCBCBOOMBFI(MIGCCDNHDEL IOGJGBJCGKK, MIGCCDNHDEL AIFNAINAIBK);

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MIGCCDNHDEL BMDNOKODBON(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<MIGCCDNHDEL> PMJBJJEMEFG(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	MIGCCDNHDEL PALHNNABOGI(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IFFIAPFFALA(MIGCCDNHDEL IOGJGBJCGKK, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC);

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IONKIJFJDJN(MIGCCDNHDEL IOGJGBJCGKK, float FIDHJLMONDA);

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool FFHHICFFKKM(MIGCCDNHDEL IOGJGBJCGKK, [Out] RigidTransform MBEFPKGDFKP);

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool CMIPPHGGLII(MIGCCDNHDEL IOGJGBJCGKK, [Out] float IECFDKENAOK);

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 MJIBJNBMNCL(ONOPCOLEGDI LGCKGKGAGHK);

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion FEHFIOHNBFK(ONOPCOLEGDI LGCKGKGAGHK);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class HNEOIGPGJPM
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[PFENABFDEFA(DCCNCNLIDJL.LoadInstance)]
public interface OKBDJMLILFD
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	object CFGICOALJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DPAINDDOFAF(OEAIGCFLLHH IMKJMOFIELG);
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum GKHHIADPMAF
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class MOEOEOMLHOD
{
	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0xB75020", Offset = "0xB73E20", VA = "0x180B75020")]
	public static bool LBIAKIKGCML(this GKHHIADPMAF DCBJOKKHJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0xB75030", Offset = "0xB73E30", VA = "0x180B75030")]
	public static bool MGMOIDHOBGN(this GKHHIADPMAF DCBJOKKHJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x21EA1C0", Offset = "0x21E8FC0", VA = "0x1821EA1C0")]
	public static bool ENICOEHNBIM(this GKHHIADPMAF DCBJOKKHJFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface PDGABMKCFMI
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	GKHHIADPMAF IEDPINANGND
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	GKHHIADPMAF NEJINHEJMFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	GKHHIADPMAF CGCPFECLPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	GKHHIADPMAF JLEDLPHOJFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	GKHHIADPMAF CIMPPHMAGPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	GKHHIADPMAF OPMPJHOLHCN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	GKHHIADPMAF DKLCDEAEDPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	GKHHIADPMAF MGAEELMCKGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	GKHHIADPMAF EMBFCPGPJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	GKHHIADPMAF ACGFCLPABLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	GKHHIADPMAF DGPMDACOPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	GKHHIADPMAF MCGNHPJAJCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	GKHHIADPMAF FMILPHJLECG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface ODIANNFGKAF
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<NLNCEIOIPED> IGEJOPMGBBF;

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MIGCCDNHDEL MMFPPIIMBDD(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MBBHOJGJBBL(List<MIGCCDNHDEL> GGNIELNEMEF);

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MIGCCDNHDEL KDGNHAPLGEO(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IEJEABLOHEA(MIGCCDNHDEL IOGJGBJCGKK, MIGCCDNHDEL AJKCELPHOFC, bool IACPBLHMLLC);

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FIBIHEIHOOC(MIGCCDNHDEL IOGJGBJCGKK, MIGCCDNHDEL AJKCELPHOFC);

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int HEFOGEHPGHP(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OEAIGCFLLHH EGGJHDDODMO(MIGCCDNHDEL GDLGHGPGIOA);

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NativeArray<MIGCCDNHDEL> NELFBEKOIFL(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MHOLDLKJKJK(MIGCCDNHDEL IOGJGBJCGKK, MIGCCDNHDEL DOEPBBFCPHE);

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool HMCKMKJJLHM(MIGCCDNHDEL IOGJGBJCGKK, MIGCCDNHDEL CGCPLEANCCA);

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(Slot = "12")]
	MIGCCDNHDEL IOGIOMBGOEK(MIGCCDNHDEL KAKJJOAALHM, MIGCCDNHDEL MHOPMKILDEB);

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool FBACOKCFCEK(MIGCCDNHDEL KAKJJOAALHM, MIGCCDNHDEL MHOPMKILDEB, [Out] MIGCCDNHDEL PLELNJKDIDO);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class LFKMEEHOLIP
{
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x60CB930", Offset = "0x60CA730", VA = "0x1860CB930")]
	public static List<MIGCCDNHDEL> MBBHOJGJBBL(this ODIANNFGKAF BIBHPACHOGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[PFENABFDEFA(DCCNCNLIDJL.LoadInstance)]
public interface PAHGJBLFODF
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	bool FFDKMBCLGHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	bool HLLHPGHENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface OFCBILAEHLB : PFLGNMGOPNA
{
	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LKCLLLOOPJI(Entity KEAAKDKHLOM, [Out] GDEIDBKHBNC LDKFOPCPMCG);

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MFMMIHPDMOC(NativeArray<GDEIDBKHBNC> PBEIBJFHJBJ, NativeArray<NPBNPMOJOCP> PPDPHIMAJOG);

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AOAHFDIHFDE(GDEIDBKHBNC LDKFOPCPMCG);

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HEANDDHLHDO(GDEIDBKHBNC LDKFOPCPMCG, [Out] Collider ABKAPOJFHND);
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[PFENABFDEFA(DCCNCNLIDJL.LoadInstance)]
public interface PFLGNMGOPNA
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GJLIMKDCOPA([In] float3 HDDLJEHAKEP, [In] float3 LLMNHBKBLPP, float ABEPJPPAIOB, Allocator MGPHHCICJPF, [Out] NativeArray<Entity> MPOMEEMHIFI);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[PFENABFDEFA(DCCNCNLIDJL.LoadInstance)]
public interface FJIKJOHMBPB
{
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GJLIMKDCOPA([In] float3 HDDLJEHAKEP, [In] float3 LLMNHBKBLPP, float ABEPJPPAIOB, [Out] FOHMFJNBJGA ADCMIEOLCBP, [Out] MIGCCDNHDEL ICJDMMCGALH);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[PFENABFDEFA(DCCNCNLIDJL.LoadInstance)]
public interface PAPCKKOOFIB
{
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJLIMKDCOPA([In] NativeArray<Entity> MPOMEEMHIFI, [In] float3 HDDLJEHAKEP, [In] float3 LLMNHBKBLPP, [In] NativeArray<FOHMFJNBJGA> JFHKAJNPJCK);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct GDEIDBKHBNC : CDBBGDPCLAA, IEquatable<GDEIDBKHBNC>
{
	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public int CCEAOHGDFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8982F0", Offset = "0x8970F0", VA = "0x1808982F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x898350", Offset = "0x897150", VA = "0x180898350", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public int KKDGMDBLCIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x2200D30", Offset = "0x21FFB30", VA = "0x182200D30", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x544ED00", Offset = "0x544DB00", VA = "0x18544ED00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x60C46B0", Offset = "0x60C34B0", VA = "0x1860C46B0", Slot = "8")]
	public bool Equals(GDEIDBKHBNC FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x60C4700", Offset = "0x60C3500", VA = "0x1860C4700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct FOHMFJNBJGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float MOBPAJGHAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float3 NPJIMHPPOGG;
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface JJAHDHCBBNM
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface NEPAPILBIHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000136")]
	IECCBCMHOEC HOMFGFJJJBN
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	OCCNIHGDLAD IMNKILDFEHH
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<OEAIGCFLLHH, NativeArray<EGPFMLCEFJD>> HBJBHABBPCO;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<OEAIGCFLLHH> IJBPIOHPMEH;

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JICCPKLHMMF NEEKCKJKFFJ(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EGPFMLCEFJD LGPMCLGNJFG(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NLHDMBJLIGN(MHNLEJCAAIM DFMCILKNNOJ, NPILDFLMCDB ONJHEJOFAPF);

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DGKKPMEKMCC(MHNLEJCAAIM[] MDPGDDGMJNJ, GameObject IPHCMOEHILB);

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IMJAJJJILNA LEDAEDECAOJ(MIGCCDNHDEL IOGJGBJCGKK, [Optional] object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool COBMKNCFBLG(MIGCCDNHDEL IOGJGBJCGKK, [Out] NPILDFLMCDB ONJHEJOFAPF);

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool POEMIAHODDO(MIGCCDNHDEL IOGJGBJCGKK, [Out] Transform PFIKOEBPDGA);

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool DHAJOCKCAOP(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KCBPKAHKFLD(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool OFCAKKBODJB(LocalId IOGJGBJCGKK, object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool MJAHKFLNCPD(LocalId IOGJGBJCGKK, object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(Slot = "17")]
	MIGCCDNHDEL KOLHFGBFEBP(MHNLEJCAAIM DFMCILKNNOJ);

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool MNPACHCAMDC(MHNLEJCAAIM DFMCILKNNOJ, [Out] MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	MHNLEJCAAIM EJPCOBEMLHO(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	OEAIGCFLLHH KOLHFGBFEBP(NativeArray<MHNLEJCAAIM> DFMCILKNNOJ, Allocator MGPHHCICJPF);

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	OEAIGCFLLHH GMNKIGBDAJH(EGPFMLCEFJD MLPCHFIIHMO, int BPFMGMBDOBA, Allocator MGPHHCICJPF);

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "22")]
	OEAIGCFLLHH HJDGPBEJFEM(NativeArray<MHNLEJCAAIM> DFMCILKNNOJ, NativeArray<DMHOLNOMFBP> DMNCHBMJLJK, Allocator MGPHHCICJPF);

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	MHNLEJCAAIM[] HNPLKGMBCNJ(string PDNLHMCHEMA, IMJAJJJILNA DFHEIALDHKF, bool FEBBCHIJFKH);

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BAGHPAJNNPE(string PDNLHMCHEMA, MHNLEJCAAIM[] MDPGDDGMJNJ);

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "25")]
	IMJAJJJILNA OEMGIHDJEGO(EGPFMLCEFJD MLPCHFIIHMO, bool PAHIEDOEMJI);

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(Slot = "26")]
	IMJAJJJILNA OEMGIHDJEGO(EGPFMLCEFJD MLPCHFIIHMO);

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(Slot = "27")]
	IMJAJJJILNA BCKDOPCAGDD(EGPFMLCEFJD MLPCHFIIHMO);

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "28")]
	IMJAJJJILNA LAKFGKICHCN(EGPFMLCEFJD MLPCHFIIHMO);

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(Slot = "29")]
	IMJAJJJILNA HJDGPBEJFEM(MHNLEJCAAIM DFMCILKNNOJ, EGPFMLCEFJD MLPCHFIIHMO);

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(Slot = "30")]
	EFACEBFDCDO NFDPCKPLHGB();

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(Slot = "31")]
	EEOHOBEANBK BCLNGAHLLJM();

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(Slot = "32")]
	CBJAMMNEJCO AAILEMFGFFP(MCEJPAIOHJF JEBFDGBNMHB);

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void ELALDILJBKJ(OEAIGCFLLHH IMKJMOFIELG);

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void ECEAPGIDAKG(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void BJOOPHBAEAE(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void ELALDILJBKJ(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "37")]
	OEAIGCFLLHH LFBBMLBILDK(OEAIGCFLLHH NIJOJKIGFMN, Allocator MGPHHCICJPF);

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool BEFJOKMDIPF(MIGCCDNHDEL IOGJGBJCGKK);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class LAACABBKPHI
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x60CB580", Offset = "0x60CA380", VA = "0x1860CB580")]
	public static void KCBPKAHKFLD(this NEPAPILBIHM FGAJNCNIHHF, NPILDFLMCDB ONJHEJOFAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x60CB600", Offset = "0x60CA400", VA = "0x1860CB600")]
	public static IMJAJJJILNA NBHFPBJADCN(this NEPAPILBIHM FGAJNCNIHHF, LocalId IOGJGBJCGKK)
	{
		return default(IMJAJJJILNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x60CB630", Offset = "0x60CA430", VA = "0x1860CB630")]
	public static IMJAJJJILNA NBHFPBJADCN(this NEPAPILBIHM FGAJNCNIHHF, MHNLEJCAAIM DFMCILKNNOJ)
	{
		return default(IMJAJJJILNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x60CB600", Offset = "0x60CA400", VA = "0x1860CB600")]
	public static MIGCCDNHDEL KOLHFGBFEBP(this NEPAPILBIHM FGAJNCNIHHF, LocalId IOGJGBJCGKK)
	{
		return default(MIGCCDNHDEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x60CB0D0", Offset = "0x60C9ED0", VA = "0x1860CB0D0")]
	public static MHNLEJCAAIM EJPCOBEMLHO(this NEPAPILBIHM FGAJNCNIHHF, LocalId IOGJGBJCGKK)
	{
		return default(MHNLEJCAAIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x60CB060", Offset = "0x60C9E60", VA = "0x1860CB060")]
	public static bool BEFJOKMDIPF(this NEPAPILBIHM FGAJNCNIHHF, MHNLEJCAAIM DFMCILKNNOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x2785540", Offset = "0x2784340", VA = "0x182785540")]
	public static T BFMLIFEGEON<T>(this NEPAPILBIHM FGAJNCNIHHF, LocalId IOGJGBJCGKK) where T : struct, EFLJMIKJDOL
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x60CAF60", Offset = "0x60C9D60", VA = "0x1860CAF60")]
	public static EFACEBFDCDO BCCEGEFEMDC(this NEPAPILBIHM FGAJNCNIHHF, RigidTransform LDOMCECECHK, [Optional] object NBGOKNOECBH)
	{
		return default(EFACEBFDCDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x60CB470", Offset = "0x60CA270", VA = "0x1860CB470")]
	public static CBJAMMNEJCO JOFKKMACMGM(this NEPAPILBIHM FGAJNCNIHHF, MCEJPAIOHJF PDIGECAMHIA, RigidTransform LDOMCECECHK, [Optional] object NBGOKNOECBH)
	{
		return default(CBJAMMNEJCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x60CB150", Offset = "0x60C9F50", VA = "0x1860CB150")]
	public static EEOHOBEANBK FMJIFBJJJDK(this NEPAPILBIHM FGAJNCNIHHF, RigidTransform LDOMCECECHK, [Optional] object NBGOKNOECBH)
	{
		return default(EEOHOBEANBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x60CB250", Offset = "0x60CA050", VA = "0x1860CB250")]
	private static void HLPIKBNNNIE(IMJAJJJILNA DFCKLLIFDIB, RigidTransform LDOMCECECHK, [Optional] object NBGOKNOECBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[PFENABFDEFA(DCCNCNLIDJL.LoadInstance)]
public interface BNDBHDACPHO
{
	[Cpp2IlInjected.Token(Token = "0x17000138")]
	bool GJFDFPEJKPL
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	MIGCCDNHDEL CBBPCFKOELE
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	IMJAJJJILNA OCFAABNMOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event NFLOJBABBMC HEIFNFCLCPB;

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MIGCCDNHDEL IOGIOMBGOEK(MIGCCDNHDEL KAKJJOAALHM, MIGCCDNHDEL MHOPMKILDEB);

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FBACOKCFCEK(MIGCCDNHDEL KAKJJOAALHM, MIGCCDNHDEL MHOPMKILDEB, [Out] MIGCCDNHDEL PLELNJKDIDO);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PLPKGIIHBCD();

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NIKFEEKBPJN();

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool AHCGGONPOBD(MIGCCDNHDEL KAKJJOAALHM);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NDAOIGCMMBO(MIGCCDNHDEL KAKJJOAALHM);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public delegate void NFLOJBABBMC(IMJAJJJILNA AIOEOOMKHJK, IMJAJJJILNA MHDAHFMHFLD);
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class KNCKAHEPELG
{
	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x60CAF10", Offset = "0x60C9D10", VA = "0x1860CAF10")]
	public static bool JIEPJNEKBLH(this BNDBHDACPHO KDFFOJFIJIN, IMJAJJJILNA KAKJJOAALHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x60CAE30", Offset = "0x60C9C30", VA = "0x1860CAE30")]
	public static bool HEPNKNOCHFH(this BNDBHDACPHO KDFFOJFIJIN, MIGCCDNHDEL KAKJJOAALHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x60CADB0", Offset = "0x60C9BB0", VA = "0x1860CADB0")]
	public static bool FMLNLNJMFEH(this BNDBHDACPHO KDFFOJFIJIN, MIGCCDNHDEL KAKJJOAALHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface NHPDMPLGLLE
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IONOAGOBILJ(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JJOLBGEDJLI(MIGCCDNHDEL IOGJGBJCGKK, Transform PFIKOEBPDGA);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface DAFPGOIBLIB
{
	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NGMNJHPDPMO(MIGCCDNHDEL KAKJJOAALHM, MIGCCDNHDEL LPGGFINOBAM);

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IOKAOGAHBLC(MIGCCDNHDEL KAKJJOAALHM, MIGCCDNHDEL JAAKLJFMDMN);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CCMJJAODEIC(MIGCCDNHDEL KAKJJOAALHM, [Out] MIGCCDNHDEL ELGILLEMACH);
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[PFENABFDEFA(DCCNCNLIDJL.LoadInstance)]
public interface EIEKLJLBKOA
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIFJIANHIPK(MIGCCDNHDEL GDLGHGPGIOA, bool NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LHGHNHDAPFD(MIGCCDNHDEL GDLGHGPGIOA, bool NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AAGBBIOAGAG(MIGCCDNHDEL GDLGHGPGIOA, int NKKIECLCEML);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[PFENABFDEFA(DCCNCNLIDJL.LoadInstance)]
public interface MEPJABONPCO
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<MIGCCDNHDEL> JNLMHEBCLFN(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MIGCCDNHDEL HFLHGEPMMAC(MIGCCDNHDEL IOGJGBJCGKK, int ENPOKNEMOMH);

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int CLDCGJEIFPG(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CECJBHNPNAC DIJMEILOMDF(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PLKFDJLPGIL(MIGCCDNHDEL IOGJGBJCGKK, CECJBHNPNAC FGAICHJHDGD);

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MIGCCDNHDEL GCBLBJKMNLG(MIGCCDNHDEL IOGJGBJCGKK, [Optional] float3? JCOIMLJCHFJ, [Optional] quaternion? GJMDICOFEBG, [Optional] float3? NANBGKEHFBG);

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MIGCCDNHDEL LIBJCLHMDHM(MIGCCDNHDEL IOGJGBJCGKK, int ENPOKNEMOMH, [Optional] float3? JCOIMLJCHFJ, [Optional] quaternion? GJMDICOFEBG, [Optional] float3? NANBGKEHFBG);

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EOHCBMKHENE(MIGCCDNHDEL IOGJGBJCGKK, int ENPOKNEMOMH);

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OLACCDFHFBL(MIGCCDNHDEL IOGJGBJCGKK);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface HFNKEIOBHDP
{
	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CDJLNKNLEPB();

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IKIEHINADPG();

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CHLKMMOJOIK();

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KLMKNGHJKGI();

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OKGLOMLLPKI();

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JKLMJACPFBB();

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OHNKMPIMHHI();

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GNCIMNIFEAN();

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KPKAJEOJPPE();

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BBMKMBDCHPF();

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AMCNLDKHMKN();
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface DFABAHDIACI
{
	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GEJOBLMHGEG(Entity KEAAKDKHLOM);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CIGDLPADLPF(Entity KEAAKDKHLOM, [In] float3 NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 MEAEFGFJANH(Entity KEAAKDKHLOM);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PGKPNEEBDNJ(Entity KEAAKDKHLOM, [In] quaternion NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion EHNDAFKDPKG(Entity KEAAKDKHLOM);

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AGJKPHJBOAL(Entity KEAAKDKHLOM, [Out] float3 JCOIMLJCHFJ, [Out] quaternion GJMDICOFEBG);

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AGJKPHJBOAL(Entity KEAAKDKHLOM, [Out] RigidTransform EEMOGCFOJMM);

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EIPDNGKJADC(Entity KEAAKDKHLOM, [Out] RigidTransform EEMOGCFOJMM);

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 FILPDLFPHIB(Entity KEAAKDKHLOM);

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PLKBDLNEJEK(Entity KEAAKDKHLOM, [In] float3 NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FMKJLDPDIJB(Entity KEAAKDKHLOM, float NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float HLNBKIFOEGC(Entity KEAAKDKHLOM);

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NKGBBFGCBAH(Entity KEAAKDKHLOM, [In] float3 NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 FLHDOEFFEMJ(Entity KEAAKDKHLOM);

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EJEAHEJLGPE(Entity KEAAKDKHLOM, [In] float3 NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 EANHNNMAEME(Entity KEAAKDKHLOM);

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MGKFEDDFLIJ(Entity KEAAKDKHLOM, [In] quaternion NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion KAAMMNEMGKC(Entity KEAAKDKHLOM);

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 PDHFEAGFHAE(Entity KEAAKDKHLOM);

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void BNPNMKLDLFG(Entity KEAAKDKHLOM, [In] float3 NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PJOIBGHKFEF(Entity KEAAKDKHLOM, float NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float FIGEHDKCPAP(Entity KEAAKDKHLOM);

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void OKKLNINFPKG(Entity KEAAKDKHLOM, [In] float3 NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 JDMAAGNINAN(Entity KEAAKDKHLOM);

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FCCLKMBDAGO(Entity KEAAKDKHLOM, [Out] float4x4 GBHGFIFOAOD);

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void FHHEEEEGJDH(Entity KEAAKDKHLOM, [In] float4x4 GBHGFIFOAOD);

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void HJOLMBCAINH(Entity KEAAKDKHLOM, [Out] float4x4 GBHGFIFOAOD);

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool POEMIAHODDO(Entity KEAAKDKHLOM, [Out] Transform PFIKOEBPDGA);

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void FBJNFBOOAGD(Entity KEAAKDKHLOM);

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void NBOHKEALOGG(Entity KEAAKDKHLOM, Entity MGPBFMAKCJE, Entity PKMANOIKNOC);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class MOECAGLDHOK
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface IOHPHJAIIBK
{
	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World LILAFEAOPBN(string DNFIAMDIFMG = "Main");

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World BCGPHGNBINK(string DNFIAMDIFMG = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World JHBHHFDFJKA(string DNFIAMDIFMG = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World IGPMIDDAGBI(string DNFIAMDIFMG = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface EBFBKHOOOEA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	World AAGBHDMDCNF
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	World MEAHPMGEHPM
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	EntityManager DKPFEFECAOD
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	bool NJDBJPCDOCO
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase FBLIJNCFIKO(Type HFFNCGFKMBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public static class KDCIIDDFKBI
{
	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x60C7F40", Offset = "0x60C6D40", VA = "0x1860C7F40")]
	public static ComponentSystemBase HLDJKPPACEB(this World CIJLPONPBAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x27727E0", Offset = "0x27715E0", VA = "0x1827727E0")]
	public static T FBLIJNCFIKO<T>(this EBFBKHOOOEA IMOGMDFKJEC) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[PFENABFDEFA(DCCNCNLIDJL.LoadInstance)]
public interface JBAEKJONIMN
{
	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAEEAPGGHEI(NativeListAsync<Entity> KCBIBFJDHPA);

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LMDIJCHPJEF(GMNAKELLJDL MLOJEFFBADA);

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DMGJECKOFAM(NativeListAsync<Entity> ANNOPCHCGAA, bool JEAJGNJPFOP);

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MNHMDOMFIMB();
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[PFENABFDEFA(DCCNCNLIDJL.LoadInstance)]
public interface GFFIINEADMC
{
	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MGKPMOIGBFM(Collider ABKAPOJFHND, [Out] MACOEFFCPFN FHLFIAAHGEA);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[PFENABFDEFA(DCCNCNLIDJL.LoadInstance)]
public interface GNGDICKHHJP
{
	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NGNKDJAHMFF(MIGCCDNHDEL IOGJGBJCGKK, [Out] Collider ABKAPOJFHND);

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject BFBFOOIAFCA(MIGCCDNHDEL OFGFABKMHKM, GameObject PEPHKFMNMNP, Vector3 JCHLCJBNBDI, Quaternion JHGEDFGCAEH);

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KMGDKBGDLHJ(GameObject ABKAPOJFHND);

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider HMHEIEAMPMI<TCollider>(GameObject PFHMKKLDFFH) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AHCCEJJBCEE(Collider ABKAPOJFHND);

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject DOKJLMPKJGN<TCollider>(string OHHBGJPCFJD) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[PFENABFDEFA(DCCNCNLIDJL.LoadInstance)]
public interface DMEPFICKIAD
{
	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KMJPMHAONPA(MIGCCDNHDEL IOGJGBJCGKK, HIDCIFMCKAM BKDACHMGCDK, bool EOHGHPMOIIE, NONJHGAANGP LFMLPPAFPPD);

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHAHBLIDKHO(MIGCCDNHDEL IOGJGBJCGKK, HIDCIFMCKAM BKDACHMGCDK, bool EOHGHPMOIIE, bool PIMANLFJONN, bool BDPGFIMEFJP);

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ADOEHHLMBOA DGJFPKLGCFN(MIGCCDNHDEL ADCDJFADKCK, List<MIGCCDNHDEL> PBMKMGBDLMM);

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ABMOEGHMGME(GameObject MOOPDKFKEPG, GameObject FDGNDEJEMMN);

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FBHDDDFPEFD(GameObject FDGNDEJEMMN);

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T HMHEIEAMPMI<T>(GameObject PFHMKKLDFFH) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AHCCEJJBCEE(Collider ABKAPOJFHND);

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject COKKLKALOME<T>(string OHHBGJPCFJD) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IOCLAMKHOJF(Collider ABKAPOJFHND, [Out] MIGCCDNHDEL ACCBBJBNABI);

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JNAEMOAOFGA(MIGCCDNHDEL IOGJGBJCGKK, [Out] MACOEFFCPFN FHLFIAAHGEA);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[PFENABFDEFA(DCCNCNLIDJL.LoadInstance)]
public interface HEGJMPEONPB
{
	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDHHLKFMMFB(MIGCCDNHDEL IOGJGBJCGKK, BNMCAMKAGGO NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BNMCAMKAGGO CLDHNLCBDNM(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void POLLOHFPCNE(MIGCCDNHDEL IOGJGBJCGKK, MIGCCDNHDEL NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PJHLAHADDHF(MIGCCDNHDEL IOGJGBJCGKK, MIGCCDNHDEL NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int HEFOGEHPGHP(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MIGCCDNHDEL NDAJPBGIEMC(MIGCCDNHDEL IOGJGBJCGKK, int ENPOKNEMOMH);

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JOELEFKEIEP(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FHPLFKDHCKD(MIGCCDNHDEL IOGJGBJCGKK, object NBGOKNOECBH, MIGCCDNHDEL NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JBGNDGJIODO(MIGCCDNHDEL IOGJGBJCGKK, object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool EOKDEGGGIEN(MIGCCDNHDEL IOGJGBJCGKK, [Out] MIGCCDNHDEL NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IKBJIBABKKC(MIGCCDNHDEL IOGJGBJCGKK, float3 NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool JEHKOPGJDNA(MIGCCDNHDEL IOGJGBJCGKK, [Out] float3 NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HJKKNENLJHA(MIGCCDNHDEL IOGJGBJCGKK, float3 NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool EFFPIOAPCDA(MIGCCDNHDEL IOGJGBJCGKK, [Out] float3 NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FCNEFMLEHBE(MIGCCDNHDEL IOGJGBJCGKK, (Quaternion rot, Vector3 moments) JDFPGJKLCLE);

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool DJFCDIMGOFN(MIGCCDNHDEL IOGJGBJCGKK, [Out] quaternion MMKDNLHLGPC, [Out] float3 OAPEIKBJCOB);

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MHFHKFODKMC(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CPCHJLGCDBN(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 HLHPECMJJIG(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 OJHMBBNIIFG(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void IPPIMLLGJJO(MIGCCDNHDEL IOGJGBJCGKK, float3 NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void LAICNGCOFCA(MIGCCDNHDEL IOGJGBJCGKK, float3 NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float OPGFCFHMNGI(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float COCAEODHAHC(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void PNGEOPILNMJ(MIGCCDNHDEL IOGJGBJCGKK, float NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void LLJJHIFAJJE(MIGCCDNHDEL IOGJGBJCGKK, float NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CollisionDetectionMode JHKOKMCJJFP(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void KGOINMAIPII(MIGCCDNHDEL IOGJGBJCGKK, CollisionDetectionMode NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "28")]
	OIIAKGKODFP MPKMPEMKNJL(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void KHKNMAFJFGC(MIGCCDNHDEL IOGJGBJCGKK, OIIAKGKODFP NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool DHPKGKALJML(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void FONBGINNAEN(MIGCCDNHDEL IOGJGBJCGKK, bool NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "32")]
	MIGCCDNHDEL MMFPPIIMBDD(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void LICAJNAPINP(MIGCCDNHDEL IOGJGBJCGKK, MIGCCDNHDEL NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "34")]
	MIGCCDNHDEL KDGNHAPLGEO(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void IEJEABLOHEA(MIGCCDNHDEL IOGJGBJCGKK, MIGCCDNHDEL NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "36")]
	PMOKGNOEINJ GEOLDBHHNEC(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void CEHFPEDBPPK(MIGCCDNHDEL IOGJGBJCGKK, PMOKGNOEINJ PNBIKGIPGPP);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool OMCMMOEDADJ(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void DFLABFBJOFA(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool EFJCCHMFIEA(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void NAOAOFGLPPK(MIGCCDNHDEL IOGJGBJCGKK, bool NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool EMIAIDKIDFB(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void JJMMKCLDOLL(MIGCCDNHDEL IOGJGBJCGKK, bool NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "44")]
	RigidbodyConstraints HPEMDNIKKDO(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void ANNCDDIHKCG(MIGCCDNHDEL IOGJGBJCGKK, RigidbodyConstraints NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "46")]
	float LNHOABLDKOB(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void PDJPJPALBKD(MIGCCDNHDEL IOGJGBJCGKK, float NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float KNKNJIDPMON(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void CNJNPEAEPEP(MIGCCDNHDEL IOGJGBJCGKK, float NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool KAMPPPGKMHH(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void COGNCIJKDEI(MIGCCDNHDEL IOGJGBJCGKK, bool NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool BFHNEGENFAG(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void LINJJBAIPPO(MIGCCDNHDEL IOGJGBJCGKK, bool NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void BNDKHEJLDEF(MIGCCDNHDEL IOGJGBJCGKK, int NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "55")]
	object CGDHHMNPFEH(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void ABKHCOAGAAM(MIGCCDNHDEL IOGJGBJCGKK, object NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "57")]
	object HPKFPLHDINJ(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void INKIKKOAPFB(MIGCCDNHDEL IOGJGBJCGKK, object NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "59")]
	float LCIMHEJHPHI(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void JNLJIFONGKG(MIGCCDNHDEL IOGJGBJCGKK, float NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void OFAPPNFFACP(MIGCCDNHDEL IOGJGBJCGKK, object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void CEILOFHLMCK(MIGCCDNHDEL IOGJGBJCGKK, object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(Slot = "63")]
	bool ENJONGOOAJD(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void HDACNEGENEA(MIGCCDNHDEL IOGJGBJCGKK, object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void KLNPNAPPHAL(MIGCCDNHDEL IOGJGBJCGKK, object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "66")]
	bool OJPNKABHHDI(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool NBJEBOCFAJG(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Rigidbody IEGIFFHLENL(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void CDHBOBNGFIB(MIGCCDNHDEL IOGJGBJCGKK, Rigidbody EMNDMNOMIMH);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void CDPAFGMHMDL(MIGCCDNHDEL IOGJGBJCGKK, object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void MEKAPPHPEHP(MIGCCDNHDEL IOGJGBJCGKK, object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool EINAJJBLBHH(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void EJCPKMMKIKK(MIGCCDNHDEL IOGJGBJCGKK, float3 FEAOCKEGNIC);

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void BNHMIFFBPPF(MIGCCDNHDEL IOGJGBJCGKK, float3 NDNOKJPALDK);

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "75")]
	bool GBOKIKDGIGK(MIGCCDNHDEL IOGJGBJCGKK, [Out] float3 FEAOCKEGNIC);

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool JJAOIPHJHMI(MIGCCDNHDEL IOGJGBJCGKK, [Out] float3 NDNOKJPALDK);

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool AMMBJOPJAEG(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void JJPGLKMHODG(MIGCCDNHDEL IOGJGBJCGKK, object NBGOKNOECBH, bool DDKFBELPPHE);

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "79")]
	void BFKNCIFAHGN(MIGCCDNHDEL IOGJGBJCGKK, bool HFJKAIIOMEF);

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void HFHFHGPMIMB(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool JHMOKIIPEAH(MIGCCDNHDEL IOGJGBJCGKK);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[PFENABFDEFA(DCCNCNLIDJL.LoadInstance)]
public interface KNFKJECPPJO
{
	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	bool NJDBJPCDOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NFIMNMGPDKG(MIGCCDNHDEL IOGJGBJCGKK);

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LIMLDMPNEFF(MIGCCDNHDEL IOGJGBJCGKK, bool EOHGHPMOIIE, bool PIMANLFJONN, bool DKPCEIDIKMO);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EDAFJPAHDLE(MIGCCDNHDEL IOGJGBJCGKK, float3 MECEBMJGHLN);

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KDMPNOEJLEF(MIGCCDNHDEL IOGJGBJCGKK, float3 MECEBMJGHLN);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[PFENABFDEFA(DCCNCNLIDJL.LoadInstance)]
public interface NJIEGEILOHA
{
	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EFMDIPEPPMG(Entity ANBGJJIMKMN);

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NDOLKNOLBHB(Entity ANBGJJIMKMN);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public delegate void NMEDDHBPLKG(DBJGAALHGON ININALBFLLI);
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct DBJGAALHGON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly OEAIGCFLLHH NMMHKDBNLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly NativeArray<byte> HPFNNCFAOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly NativeArray<byte> FLONDMFIAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly IJBMCFIHFAI LHOPDKBHFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly int DIJIPHBPIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Type AKIMNJKPNCB;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public OEAIGCFLLHH CELGAAAJHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E160", Offset = "0x3A5CF60", VA = "0x183A5E160")]
		get
		{
			return default(OEAIGCFLLHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x60C00B0", Offset = "0x60BEEB0", VA = "0x1860C00B0")]
	public DBJGAALHGON(OEAIGCFLLHH NMMHKDBNLJN, NativeArray<byte> HPFNNCFAOFH, NativeArray<byte> FLONDMFIAEL, IJBMCFIHFAI LHOPDKBHFLC, int DIJIPHBPIHB, Type AKIMNJKPNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x2598770", Offset = "0x2597570", VA = "0x182598770")]
	public NativeArray<T> MNEOAOPIOMO<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x25987B0", Offset = "0x25975B0", VA = "0x1825987B0")]
	public NativeArray<T> NGGIDDPDNDP<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x2598680", Offset = "0x2597480", VA = "0x182598680")]
	public (OEAIGCFLLHH, NativeArray<T>, NativeArray<T>) IKJEAFPPDKF<T>() where T : struct
	{
		return default((OEAIGCFLLHH, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x60C0060", Offset = "0x60BEE60", VA = "0x1860C0060")]
	public NLNCEIOIPED HFNKINHIINF()
	{
		return default(NLNCEIOIPED);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface IMIKMEFNPFB
{
	[Cpp2IlInjected.Token(Token = "0x17000141")]
	string IMBOENKIFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	IMIKMEFNPFB FLNPMHGMJEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	IEnumerable<IMIKMEFNPFB> ICMGAGBMAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[PFENABFDEFA(DCCNCNLIDJL.LoadInstance)]
public interface DDGLAEHKAPB
{
	[Cpp2IlInjected.Token(Token = "0x17000144")]
	IMIKMEFNPFB KEJAIOIOIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	List<JNGBIGCDMGC> ADLBFGKCECI
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CGJGNKEMENJ(JNGBIGCDMGC EDANCLIIPKG, [Out] IMIKMEFNPFB JNOOPBCIILF);

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NLHDMBJLIGN(JNGBIGCDMGC EDANCLIIPKG, NMEDDHBPLKG POJHJDCNAAN);

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GLLKHIKCFCF(JNGBIGCDMGC EDANCLIIPKG, NMEDDHBPLKG POJHJDCNAAN);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public readonly struct NLNCEIOIPED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly DBJGAALHGON OMHIFBJFAGA;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public OEAIGCFLLHH CELGAAAJHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E160", Offset = "0x3A5CF60", VA = "0x183A5E160")]
		get
		{
			return default(OEAIGCFLLHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x60CD8D0", Offset = "0x60CC6D0", VA = "0x1860CD8D0")]
	public NLNCEIOIPED(DBJGAALHGON OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x60CD730", Offset = "0x60CC530", VA = "0x1860CD730")]
	public OEAIGCFLLHH MNEOAOPIOMO()
	{
		return default(OEAIGCFLLHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x60CD800", Offset = "0x60CC600", VA = "0x1860CD800")]
	public OEAIGCFLLHH NGGIDDPDNDP()
	{
		return default(OEAIGCFLLHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x60CD610", Offset = "0x60CC410", VA = "0x1860CD610")]
	public (OEAIGCFLLHH, OEAIGCFLLHH, OEAIGCFLLHH) IKJEAFPPDKF()
	{
		return default((OEAIGCFLLHH, OEAIGCFLLHH, OEAIGCFLLHH));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
[DefaultMember("Item")]
public interface JHKGODDCMGE : IEnumerable<DCNLFJJFHMC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000147")]
	NativeBitArray DDHPCFGDBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	NativeArray<int> MHEAHNMNOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	int DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	DCNLFJJFHMC LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	DCNLFJJFHMC LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DCNLFJJFHMC CDCMDPDGEKD(JBEBIKKBBJJ FEDBJFFPCAF);

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IJBMCFIHFAI KDMMCAEDFBJ(JBEBIKKBBJJ FEDBJFFPCAF);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class JCKKGMECNIF
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[DefaultMember("Item")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface EELIEIHALJF : IEnumerable<EGHHAKCNGGN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	int DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	EGHHAKCNGGN LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EGHHAKCNGGN CDCMDPDGEKD(JBEBIKKBBJJ FEDBJFFPCAF);

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IJBMCFIHFAI KDMMCAEDFBJ(JBEBIKKBBJJ FEDBJFFPCAF);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class KCFNKCDMBNO
{
	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x2771CF0", Offset = "0x2770AF0", VA = "0x182771CF0")]
	public static IJBMCFIHFAI KDMMCAEDFBJ<T>(this EELIEIHALJF GGBBBBDBDBA, DJEGHLLJLPD<T> OHHBGJPCFJD) where T : struct
	{
		return default(IJBMCFIHFAI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[DefaultMember("Item")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface OONEPHOMHDK : IEnumerable<JNGBIGCDMGC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	int DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	JNGBIGCDMGC LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JNGBIGCDMGC CDCMDPDGEKD(JBEBIKKBBJJ FEDBJFFPCAF);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IJBMCFIHFAI KDMMCAEDFBJ(JBEBIKKBBJJ FEDBJFFPCAF);
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class IINPLKEKIJP
{
	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x273F560", Offset = "0x273E360", VA = "0x18273F560")]
	public static IIEIDOKHIGD<T> CDCMDPDGEKD<T>(this OONEPHOMHDK GGBBBBDBDBA, JBEBIKKBBJJ OHHBGJPCFJD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x273F6A0", Offset = "0x273E4A0", VA = "0x18273F6A0")]
	public static IJBMCFIHFAI KDMMCAEDFBJ<T>(this OONEPHOMHDK GGBBBBDBDBA, DJEGHLLJLPD<T> OHHBGJPCFJD) where T : struct
	{
		return default(IJBMCFIHFAI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[PFENABFDEFA(DCCNCNLIDJL.LoadInstance)]
public interface BKAKBOLCJLI
{
	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLHDMBJLIGN(JBEBIKKBBJJ EDANCLIIPKG, NMEDDHBPLKG POJHJDCNAAN);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GLLKHIKCFCF(JBEBIKKBBJJ EDANCLIIPKG, NMEDDHBPLKG POJHJDCNAAN);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class MIPHJGOBDBH
{
	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x27CFCF0", Offset = "0x27CEAF0", VA = "0x1827CFCF0")]
	public static void NLHDMBJLIGN<T>(this BKAKBOLCJLI AMBIOCKKGLI, DJEGHLLJLPD<T> EDANCLIIPKG, NMEDDHBPLKG POJHJDCNAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x27CFAD0", Offset = "0x27CE8D0", VA = "0x1827CFAD0")]
	public static void GLLKHIKCFCF<T>(this BKAKBOLCJLI AMBIOCKKGLI, DJEGHLLJLPD<T> EDANCLIIPKG, NMEDDHBPLKG POJHJDCNAAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface FJNOEGLAODO
{
	[Cpp2IlInjected.Token(Token = "0x17000150")]
	JLLMMEDLBOH OIFKGLKMCEF
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPMIGLMHLHN(MHNLEJCAAIM DFMCILKNNOJ, IJBMCFIHFAI EDANCLIIPKG);

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LJCDDHODOPG(MHNLEJCAAIM DFMCILKNNOJ, Span<IJBMCFIHFAI> GGBBBBDBDBA, bool JPHAMKDPNFF);

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AJEDABAKDEL(NativeArray<MHNLEJCAAIM> MDPGDDGMJNJ);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class ELEPDNOCHMO
{
	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x60C4550", Offset = "0x60C3350", VA = "0x1860C4550")]
	public static void LJCDDHODOPG(this FJNOEGLAODO CDLMOEGEGLO, MHNLEJCAAIM DFMCILKNNOJ, IJBMCFIHFAI EDANCLIIPKG, bool JPHAMKDPNFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public readonly struct JLLMMEDLBOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly NativeBitArray LDKFJEELPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly NativeParallelHashMap<MHNLEJCAAIM, int> HKLHFNMLBLB;

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool CJCOPDMOHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x60C7C60", Offset = "0x60C6A60", VA = "0x1860C7C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xB6E450", Offset = "0xB6D250", VA = "0x180B6E450")]
	public JLLMMEDLBOH(NativeBitArray LDKFJEELPCB, NativeParallelHashMap<MHNLEJCAAIM, int> HKLHFNMLBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x60C7C80", Offset = "0x60C6A80", VA = "0x1860C7C80")]
	public bool OPMIGLMHLHN(MHNLEJCAAIM DFMCILKNNOJ, IJBMCFIHFAI EDANCLIIPKG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[PFENABFDEFA(DCCNCNLIDJL.LoadInstance)]
public interface JDBMMOGONEC
{
	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EGCLIJNKFOI(MIGCCDNHDEL IOGJGBJCGKK, PCAIKHINMBJ NKKIECLCEML);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface CNNIGFCLBPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000152")]
	LPOKNNAKEAE IJAEBLMPGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface OGMOLABACED
{
	[Cpp2IlInjected.Token(Token = "0x17000153")]
	Type KJJIDNONCHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[PFENABFDEFA(DCCNCNLIDJL.LoadInstance)]
public interface JFNPMPLFNGM
{
	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HNNFJIFJLHE(MIGCCDNHDEL GDLGHGPGIOA, bool NKKIECLCEML);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public readonly struct NPJOKDBBCCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly IEnumerable<LGLLGEJOBIO> CMCBMKAJBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly IReadOnlyList<GameObject> EPMPODCIKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly IReadOnlyList<int> FCENLOLJAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly IReadOnlyList<(MHNLEJCAAIM, MHNLEJCAAIM)> DDMIPAAELFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly int FGODLNFFAKD;

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool MEKBGLMALDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x60CE170", Offset = "0x60CCF70", VA = "0x1860CE170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public int LBKCHOGNBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x8CBDA0", Offset = "0x8CABA0", VA = "0x1808CBDA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public IEnumerable<GameObject> OPPGFDHMAKM
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x898230", Offset = "0x897030", VA = "0x180898230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public IEnumerable<(MHNLEJCAAIM src, MHNLEJCAAIM dst)> JLPHKLBILML
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x60CE1D0", Offset = "0x60CCFD0", VA = "0x1860CE1D0")]
	public NPJOKDBBCCJ(IEnumerable<LGLLGEJOBIO> CMCBMKAJBPJ, IReadOnlyList<GameObject> EPMPODCIKFN, IReadOnlyList<int> FCENLOLJAOO, IReadOnlyList<(MHNLEJCAAIM src, MHNLEJCAAIM dst)> DDMIPAAELFA, int FGODLNFFAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x60CDDE0", Offset = "0x60CCBE0", VA = "0x1860CDDE0")]
	public (GameObject, int)[] FDBEOEFJJDG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface LLFDLNEFNID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000158")]
	bool ILCFBHLDPCH
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	bool FEOHPEEHCEF
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	MKCLNCOBEGE GMIGPMOCEHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MOBHFKEFFNG CNPPKHOGHPE();

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MOBHFKEFFNG BLADMHDDODK(IEnumerable<MIGCCDNHDEL> IMKJMOFIELG, [In] PBAJPJIMDKJ NOAFMEKBLDG);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DGGHEDKHDLK LACPEKAALNL(ByteString FGKODFIPGJC);

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EDPOIOPBOMJ ANPEBMAAIOG(ByteString CBOHHFCFEEA, MIGCCDNHDEL AJKCELPHOFC, [In] PBAJPJIMDKJ HPJEPLPIKEG, AFPOCNMGMNH MKDNFAOKBDC, bool IIKDFCPKJLA = true);

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CKCALOCHIAN();

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NPJOKDBBCCJ FMLEAFGKEAE(IEnumerable<LGLLGEJOBIO> CMCBMKAJBPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class JLIKOGHKHCD
{
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface KFHHHBEMCOL
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action EKGBDDJHLJH;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action CMOKCDMONMI;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct DMHOLNOMFBP : OJMAAKOJIEC, IEquatable<DMHOLNOMFBP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public EGPFMLCEFJD MLPCHFIIHMO;

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x60C16D0", Offset = "0x60C04D0", VA = "0x1860C16D0", Slot = "5")]
	public void CINNELLPCMC(PGFAOLEECFO FECOEFBKMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x60C1780", Offset = "0x60C0580", VA = "0x1860C1780", Slot = "4")]
	public void FILLENIGNNA(FHKCGDAMCNJ HNIKDBEHAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x60C17B0", Offset = "0x60C05B0", VA = "0x1860C17B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x81DD00", Offset = "0x81CB00", VA = "0x18081DD00", Slot = "6")]
	public bool Equals(DMHOLNOMFBP FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x60C1700", Offset = "0x60C0500", VA = "0x1860C1700", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x8982F0", Offset = "0x8970F0", VA = "0x1808982F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct MHNLEJCAAIM : IComparable<MHNLEJCAAIM>, IEquatable<MHNLEJCAAIM>, OJMAAKOJIEC
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public const uint JEMPBDLIPHA = 0u;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public const uint MHMGOEIPBFO = 255u;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static readonly MHNLEJCAAIM ONINMHIBMCC;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private const int KNCLLNFPMOB = 24;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private const uint NELADFDMFHE = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private const int BBEPFPFJMMC = 8;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private const uint DIMEMFLDINO = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly uint JAHCJGGEGHK;

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public uint KNOFGJLKGBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x1AC7130", Offset = "0x1AC5F30", VA = "0x181AC7130")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public uint DFPHMDCMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x60CC0D0", Offset = "0x60CAED0", VA = "0x1860CC0D0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public uint EFAGEEFKDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x8982F0", Offset = "0x8970F0", VA = "0x1808982F0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public bool MEKBGLMALDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x604AA20", Offset = "0x6049820", VA = "0x18604AA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0xC163E0", Offset = "0xC151E0", VA = "0x180C163E0")]
	public static MHNLEJCAAIM LALLKEDANCB(uint JAHCJGGEGHK)
	{
		return default(MHNLEJCAAIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x60CC180", Offset = "0x60CAF80", VA = "0x1860CC180")]
	public MHNLEJCAAIM(int OEADNCMGLNB, int DIKCHANJAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x60CC180", Offset = "0x60CAF80", VA = "0x1860CC180")]
	public MHNLEJCAAIM(uint OEADNCMGLNB, int DIKCHANJAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x60CC180", Offset = "0x60CAF80", VA = "0x1860CC180")]
	public MHNLEJCAAIM(uint OEADNCMGLNB, uint DIKCHANJAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x898350", Offset = "0x897150", VA = "0x180898350")]
	private MHNLEJCAAIM(uint JAHCJGGEGHK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x1788D20", Offset = "0x1787B20", VA = "0x181788D20")]
	public static bool JACCNGOPODK(MHNLEJCAAIM GCMDJKOKHCO, MHNLEJCAAIM LGCDJBDIEJC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x60CC0E0", Offset = "0x60CAEE0", VA = "0x1860CC0E0")]
	public static bool PONNJIKFNKJ(MHNLEJCAAIM GCMDJKOKHCO, MHNLEJCAAIM LGCDJBDIEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x81DD00", Offset = "0x81CB00", VA = "0x18081DD00", Slot = "5")]
	public bool Equals(MHNLEJCAAIM DGIBOINMLED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x60CBFF0", Offset = "0x60CADF0", VA = "0x1860CBFF0", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x21EA0D0", Offset = "0x21E8ED0", VA = "0x1821EA0D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x60CC0F0", Offset = "0x60CAEF0", VA = "0x1860CC0F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x60CC070", Offset = "0x60CAE70", VA = "0x1860CC070", Slot = "6")]
	public void FILLENIGNNA(FHKCGDAMCNJ HNIKDBEHAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x60CBF90", Offset = "0x60CAD90", VA = "0x1860CBF90", Slot = "7")]
	public void CINNELLPCMC(PGFAOLEECFO FECOEFBKMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x5FF9F40", Offset = "0x5FF8D40", VA = "0x185FF9F40", Slot = "4")]
	public int CompareTo(MHNLEJCAAIM FPEEGIOMOFF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct LGLLGEJOBIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Guid FANIDECOFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public string PDNLHMCHEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Vector3 JCOIMLJCHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Quaternion GJMDICOFEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Vector3 NANBGKEHFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int INGMBMKCLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Dictionary<string, object> FGAICHJHDGD;

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x60CBBD0", Offset = "0x60CA9D0", VA = "0x1860CBBD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x60CBA40", Offset = "0x60CA840", VA = "0x1860CBA40")]
	private static string FDKOHMNDHEF(Dictionary<string, object> HPLMOGBCEGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public enum LLJEMOGMBEL
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	World,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class OAJJOKDNNLI
{
	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x55843E0", Offset = "0x55831E0", VA = "0x1855843E0")]
	public static bool GIODONEGLCA(this LLJEMOGMBEL HFFNCGFKMBJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[Flags]
public enum MJFPLCHEFPH
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	WorldPhasesMaster = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	AdditivePhases = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface EDPOIOPBOMJ : MKCLNCOBEGE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	AFPOCNMGMNH EIPLEIBEAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MICHEHPNDIJ();

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLOCFINDBKF();
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface MKCLNCOBEGE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000160")]
	IEnumerable<LGLLGEJOBIO> HMDBNBAIGAI
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	NPJOKDBBCCJ ICKEDBDNBKG
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	LocalId AFKCAGBJINN
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	GMNKLNHBHNN GMDDNJOCOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PDKGJAINHLN(MJFPLCHEFPH EBMBDCABEHC);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public interface AFPOCNMGMNH
{
	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HNOBENEHFCJ(Guid HAMFKMJEGLE, [Out] Guid JJHNOAEPPEK);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public interface DGGHEDKHDLK : MKCLNCOBEGE, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[Flags]
public enum JAPFOCDKOMD
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public interface MOBHFKEFFNG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000164")]
	GMNKLNHBHNN HONLDBNEBFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString BPBKKIKBEHP();
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public enum DINCOGKDPHA
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public delegate bool OMAFKKCNAIH(IPICODGFGNG CKEIEDLKGFD, [In] CLBEHKJPCJM NKKIECLCEML);
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public delegate bool JLKOPJFHNDF<T>(IPICODGFGNG CKEIEDLKGFD, [In] T NKKIECLCEML);
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface JKAFAGMJCBM
{
	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLHDMBJLIGN(IJBMCFIHFAI LHOPDKBHFLC, Type LEBKGLINOFN, OMAFKKCNAIH HNNKDAANMAI);

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool APBOFLDPIDA(IJBMCFIHFAI LHOPDKBHFLC, [Out] OMAFKKCNAIH HNNKDAANMAI);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class LFFMKBMHLJI
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class OBPIBHFPLOH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public JLKOPJFHNDF<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public OBPIBHFPLOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x3F50CC0", Offset = "0x3F4FAC0", VA = "0x183F50CC0")]
		internal bool IBONBGIHPHO(IPICODGFGNG pendingList, [In] CLBEHKJPCJM value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x279BC40", Offset = "0x279AA40", VA = "0x18279BC40")]
	public static void NLHDMBJLIGN<T>(this JKAFAGMJCBM AMBIOCKKGLI, IJBMCFIHFAI LHOPDKBHFLC, JLKOPJFHNDF<T> HNNKDAANMAI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x60CB820", Offset = "0x60CA620", VA = "0x1860CB820")]
	public static bool KNEBFOPEDPK(this JKAFAGMJCBM AMBIOCKKGLI, IPICODGFGNG CKEIEDLKGFD, IJBMCFIHFAI LHOPDKBHFLC, [In] CLBEHKJPCJM NKKIECLCEML)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface NLBIBCJDIEP
{
	[Cpp2IlInjected.Token(Token = "0x17000165")]
	uint CEBFFCKHNEK
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface IPICODGFGNG
{
	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DHMMBEGNNKL(MHNLEJCAAIM NOEGJCKBDKK, IJBMCFIHFAI LHOPDKBHFLC, ReadOnlySpan<byte> HIOKGJINFND, ReadOnlySpan<byte> OKOBEHKNMBD);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HBBEFDDGJEA(MHNLEJCAAIM NOEGJCKBDKK, IJBMCFIHFAI LHOPDKBHFLC);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LEFPJKBKGFO(MHNLEJCAAIM NOEGJCKBDKK, IJBMCFIHFAI LHOPDKBHFLC, ReadOnlySpan<byte> OKOBEHKNMBD);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NBLPMHMMFGH(MHNLEJCAAIM NOEGJCKBDKK, IJBMCFIHFAI LHOPDKBHFLC, Span<byte> HIOKGJINFND, Span<byte> OKOBEHKNMBD);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class NFLKKNJKIOM
{
	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x282DA20", Offset = "0x282C820", VA = "0x18282DA20")]
	public static bool NBLPMHMMFGH<T>(this IPICODGFGNG FOOKBPNBOPP, MHNLEJCAAIM NOEGJCKBDKK, IJBMCFIHFAI LHOPDKBHFLC, [Out] T HIOKGJINFND, [Out] T OKOBEHKNMBD) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x282D8F0", Offset = "0x282C6F0", VA = "0x18282D8F0")]
	public static bool LEFPJKBKGFO<T>(this IPICODGFGNG FOOKBPNBOPP, MHNLEJCAAIM NOEGJCKBDKK, IJBMCFIHFAI LHOPDKBHFLC, T OKOBEHKNMBD) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public enum EEEMGNJJKHH
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	End,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface ANAFMHPADBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPCHPOONIBE(HOAFKBKHAPB DIIPJIMFFMD, ReadOnlySpan<byte> FCMJAHOHNCO);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHMAODPOEMM(uint JLLBMKNIENL, ReadOnlySpan<byte> FCMJAHOHNCO);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface AHPLDECFOEO
{
	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HOAFKBKHAPB JKHNAPKIAJA(ReadOnlySpan<byte> FCMJAHOHNCO);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface HEFENBIAICP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HLNILOKFPHH(HOAFKBKHAPB JCMGBFKGKLO, ReadOnlySpan<byte> FCMJAHOHNCO);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ANFDOLHCABC(ReadOnlySpan<HOAFKBKHAPB> NDINBPOABIA);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct GLICMFNHOLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public HOAFKBKHAPB DIIPJIMFFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public ReadOnlyMemory<byte> FCMJAHOHNCO;
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct HOAFKBKHAPB
{
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public static HOAFKBKHAPB OEFHKLDCPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public uint OEADNCMGLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public int CLLOGGOKFIA;

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0xA58C60", Offset = "0xA57A60", VA = "0x180A58C60")]
	public HOAFKBKHAPB(uint OEADNCMGLNB, int CLLOGGOKFIA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x60C51F0", Offset = "0x60C3FF0", VA = "0x1860C51F0")]
	public static bool JACCNGOPODK([In] HOAFKBKHAPB EHBONBMIDMA, [In] HOAFKBKHAPB MKAKMHGMJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x60C5100", Offset = "0x60C3F00", VA = "0x1860C5100", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x60C51C0", Offset = "0x60C3FC0", VA = "0x1860C51C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x60C5210", Offset = "0x60C4010", VA = "0x1860C5210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x60C51B0", Offset = "0x60C3FB0", VA = "0x1860C51B0")]
	public void FLAGJIHGEHA([Out] uint OEADNCMGLNB, [Out] int CLLOGGOKFIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface DPIKOBEEKMH : NJMEIBCCBLI<DPIKOBEEKMH>
{
	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPFCNKHIJLK(IJBMCFIHFAI DGIBOINMLED, [Out] CHCGOKOEAAG AHBOHNPMBLB);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public static class PLGKJKGKHOK
{
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public interface CHCGOKOEAAG
{
	[Cpp2IlInjected.Token(Token = "0x17000166")]
	Type ONHIFICBDKC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CINNELLPCMC(PGFAOLEECFO FECOEFBKMHD, Span<byte> KAKJJOAALHM);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FILLENIGNNA(FHKCGDAMCNJ HNIKDBEHAFP, ReadOnlySpan<byte> DIIPJIMFFMD);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class ELLBCIBMMBG
{
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public struct NPBNPMOJOCP : ISystemStateComponentData, IComponentData, IEquatable<NPBNPMOJOCP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public float3 PKELPHINLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public float3 HGDLBGPGPFM;

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x60CDD60", Offset = "0x60CCB60", VA = "0x1860CDD60", Slot = "4")]
	public bool Equals(NPBNPMOJOCP FPEEGIOMOFF)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class JLGMMEPJMLK
{
	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public JLGMMEPJMLK()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
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
