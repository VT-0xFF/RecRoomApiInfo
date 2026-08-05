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
using RecRoom.Foundation.Mathematics;
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
	public class LogRegistrationIndex : PDIMPOELJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x62D9160", Offset = "0x62D8360", VA = "0x1862D9160", Slot = "4")]
		public override void FPMBLPAHIMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class IGNGLHPPDNF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x62D4FB0", Offset = "0x62D41B0", VA = "0x1862D4FB0")]
	public static void PNJAGHHHNEJ(this Rigidbody IHLMKEPNEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x62D4E80", Offset = "0x62D4080", VA = "0x1862D4E80")]
	public static void PNJAGHHHNEJ(this Rigidbody IHLMKEPNEBP, Vector3 GFGCKDBPIDM, Quaternion HMLJOKKHKOB, Vector3 CCILDEGFAKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct BFODOFFDAJG : IReadOnlyList<MDCKLNCPLLP>, IEnumerable<MDCKLNCPLLP>, IEnumerable, IReadOnlyCollection<MDCKLNCPLLP>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct CKLPKEDFPIC : IEnumerator<MDCKLNCPLLP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly LFHNKPCBEHN PLCIIOBANHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator JEGBGBMOBCA;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public MDCKLNCPLLP DCJELCPGFEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x62CD810", Offset = "0x62CCA10", VA = "0x1862CD810", Slot = "4")]
			get
			{
				return default(MDCKLNCPLLP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x62CD790", Offset = "0x62CC990", VA = "0x1862CD790", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3D0FF20", Offset = "0x3D0F120", VA = "0x183D0FF20")]
		public CKLPKEDFPIC(LFHNKPCBEHN PLCIIOBANHB, NativeArray<LocalId>.Enumerator JEGBGBMOBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x62CD6D0", Offset = "0x62CC8D0", VA = "0x1862CD6D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x62CD710", Offset = "0x62CC910", VA = "0x1862CD710", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x62CD750", Offset = "0x62CC950", VA = "0x1862CD750", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly LFHNKPCBEHN PLCIIOBANHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> AIHKOKEKKPF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MDCKLNCPLLP HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x62CCF50", Offset = "0x62CC150", VA = "0x1862CCF50", Slot = "4")]
		get
		{
			return default(MDCKLNCPLLP);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x62CC9E0", Offset = "0x62CBBE0", VA = "0x1862CC9E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int GLAOJGMDMHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7B3110", Offset = "0x7B2310", VA = "0x1807B3110", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LFHNKPCBEHN GHGFAEOICJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int FPAACNPAGCG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7B3110", Offset = "0x7B2310", VA = "0x1807B3110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool JFENMLEHNAP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x62CC9A0", Offset = "0x62CBBA0", VA = "0x1862CC9A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> KGKPHJFDAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x237C660", Offset = "0x237B860", VA = "0x18237C660")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> KPJAJINLDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x62CCAC0", Offset = "0x62CBCC0", VA = "0x1862CCAC0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x62CCD00", Offset = "0x62CBF00", VA = "0x1862CCD00")]
	public BFODOFFDAJG(int DIHLAEIGMPG, LFHNKPCBEHN PLCIIOBANHB, Allocator ILEAEEDKNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3D0FB30", Offset = "0x3D0ED30", VA = "0x183D0FB30")]
	public BFODOFFDAJG(LFHNKPCBEHN PLCIIOBANHB, NativeArray<LocalId> AIHKOKEKKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x62CCE30", Offset = "0x62CC030", VA = "0x1862CCE30")]
	internal BFODOFFDAJG(LFHNKPCBEHN PLCIIOBANHB, NativeArray<Entity> AFOPCKBACJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x62CCD90", Offset = "0x62CBF90", VA = "0x1862CCD90")]
	public BFODOFFDAJG(LFHNKPCBEHN PLCIIOBANHB, int HHOELNLHIEN, Allocator ILEAEEDKNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x62CCEA0", Offset = "0x62CC0A0", VA = "0x1862CCEA0")]
	public BFODOFFDAJG(BFODOFFDAJG FOMCOKAFOOF, Allocator ILEAEEDKNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x62CC8F0", Offset = "0x62CBAF0", VA = "0x1862CC8F0")]
	public BFODOFFDAJG GMJOKEELPME(Allocator ILEAEEDKNCF = Allocator.Temp)
	{
		return default(BFODOFFDAJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x62CC8B0", Offset = "0x62CBAB0", VA = "0x1862CC8B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x62CCA30", Offset = "0x62CBC30", VA = "0x1862CCA30")]
	public CKLPKEDFPIC ODDJKKOCOEI()
	{
		return default(CKLPKEDFPIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x62CCB20", Offset = "0x62CBD20", VA = "0x1862CCB20", Slot = "6")]
	private IEnumerator<MDCKLNCPLLP> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x62CCC10", Offset = "0x62CBE10", VA = "0x1862CCC10", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public struct HFELIEOCMNF : IList<MDCKLNCPLLP>, ICollection<MDCKLNCPLLP>, IEnumerable<MDCKLNCPLLP>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct DFPOODGBMMJ : IEnumerator<MDCKLNCPLLP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly LFHNKPCBEHN PLCIIOBANHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator JEGBGBMOBCA;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public MDCKLNCPLLP DCJELCPGFEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x62CDE00", Offset = "0x62CD000", VA = "0x1862CDE00", Slot = "4")]
			get
			{
				return default(MDCKLNCPLLP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x62CDD80", Offset = "0x62CCF80", VA = "0x1862CDD80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3D0FF20", Offset = "0x3D0F120", VA = "0x183D0FF20")]
		public DFPOODGBMMJ(LFHNKPCBEHN PLCIIOBANHB, NativeArray<LocalId>.Enumerator JEGBGBMOBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x62CDCC0", Offset = "0x62CCEC0", VA = "0x1862CDCC0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x62CDD00", Offset = "0x62CCF00", VA = "0x1862CDD00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x62CDD40", Offset = "0x62CCF40", VA = "0x1862CDD40", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly LFHNKPCBEHN PLCIIOBANHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> AIHKOKEKKPF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public MDCKLNCPLLP HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x62D2300", Offset = "0x62D1500", VA = "0x1862D2300", Slot = "4")]
		get
		{
			return default(MDCKLNCPLLP);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x62D2380", Offset = "0x62D1580", VA = "0x1862D2380", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x62D1A80", Offset = "0x62D0C80", VA = "0x1862D1A80", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int FPAACNPAGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x62D1A80", Offset = "0x62D0C80", VA = "0x1862D1A80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool EABCDIJODPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x62D2270", Offset = "0x62D1470", VA = "0x1862D2270")]
	public HFELIEOCMNF(LFHNKPCBEHN PLCIIOBANHB, int HHOELNLHIEN, Allocator ILEAEEDKNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x62D1E60", Offset = "0x62D1060", VA = "0x1862D1E60")]
	public BFODOFFDAJG LDNINMGPLJA()
	{
		return default(BFODOFFDAJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x62D1AC0", Offset = "0x62D0CC0", VA = "0x1862D1AC0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x62D1B00", Offset = "0x62D0D00", VA = "0x1862D1B00", Slot = "13")]
	public bool Contains(MDCKLNCPLLP DMLEKJCHBDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x62D1B90", Offset = "0x62D0D90", VA = "0x1862D1B90", Slot = "14")]
	public void CopyTo(MDCKLNCPLLP[] GEHAOEPMDJB, int NENFDGMLFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x62D1A00", Offset = "0x62D0C00", VA = "0x1862D1A00", Slot = "11")]
	public void Add(MDCKLNCPLLP DMLEKJCHBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x62D1DB0", Offset = "0x62D0FB0", VA = "0x1862D1DB0", Slot = "7")]
	public void Insert(int HMFNCGHECPG, MDCKLNCPLLP DMLEKJCHBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x62D1FC0", Offset = "0x62D11C0", VA = "0x1862D1FC0", Slot = "15")]
	public bool Remove(MDCKLNCPLLP DMLEKJCHBDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x62D1D20", Offset = "0x62D0F20", VA = "0x1862D1D20", Slot = "6")]
	public int IndexOf(MDCKLNCPLLP DMLEKJCHBDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x62D1F70", Offset = "0x62D1170", VA = "0x1862D1F70", Slot = "8")]
	public void RemoveAt(int HMFNCGHECPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x62D1CE0", Offset = "0x62D0EE0", VA = "0x1862D1CE0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x62D1EE0", Offset = "0x62D10E0", VA = "0x1862D1EE0")]
	public DFPOODGBMMJ ODDJKKOCOEI()
	{
		return default(DFPOODGBMMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x62D2090", Offset = "0x62D1290", VA = "0x1862D2090", Slot = "16")]
	private IEnumerator<MDCKLNCPLLP> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x62D2180", Offset = "0x62D1380", VA = "0x1862D2180", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface MIMHHPCOOGI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int PJBEPMHOGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> BENIBAJPLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MDCKLNCPLLP HJKMIENEDAL(MDCKLNCPLLP AIHKOKEKKPF);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MBBAILCOCOP : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface GFIIIODKNJM : POJJPCNMGBA, LCCCJGOFHBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool CBEJMOMNALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	CBJMCJFCPJG DFKAEGKBLCB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	PMCGADGDGBF OOEJLJJBLCO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	ELBMHFDBKDI GDBJCNNKDCD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	LPIGOAOHECB ODOBKOMFALN
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	JAHLMKKKDAC FABCNCMPKIO
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface LCCCJGOFHBF
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool JDLAAFJNJPK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface CIEFLJDLBMO
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PFKODOFBAIG(bool NICEPFIEJED);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface LPIGOAOHECB
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool DIMAJDONLHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NMMNKKBBMCM;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PEGPBKFJJLF(bool FFABKOCEGNL);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HLAENNFELMK(ByteString NBPNGOIAHPG);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ADIEPPJANEC();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HLDACPIAIEH();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EDHFNCHHDHD();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface ELBMHFDBKDI
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	CKDGHLLENBO DFKAEGKBLCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	PMCGADGDGBF OOEJLJJBLCO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	KHINBPNOGDJ ECICAOENAAA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	GFIIIODKNJM EODCGGGIEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	LFHNKPCBEHN GHGFAEOICJB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	HFHCPMEEFCA EGEOJFLJNFD
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	GDEPNCNFLGE BJDMCOHFLEF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	OHBPHFCLDHF HDKLGMNONEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	MCFGOKIHHDE JMJAENDDDLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	KDPNAEBNBHP NEGANFAOGFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	DBBNFNPBNOE JFJKIEHPMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	HKPMFOHDGBB LCAKBNHDLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	BLPHHJHLHIF LFICFFCBEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	BDNPGHAKEMD ALIKBFGGBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	NJDMDMAJPPB AFMFCFFGKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	AFMPDJPGEFE HEAAADOPOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	GCOOEKKAODH ILPEFJKKDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	ECOGKIPDPMJ PIJFOFJIIOM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	EIFBEDIBPOB PEGLPLAHCGL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	FDGHPOGDEKP NDENCNMNDDL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	OKCLBCCMOAE MDCEOKAFNCO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	KJNPLFCGHJE JINFEMGECHH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	FEHFHAOFPPA IBKOMOHFGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	BMAGIPMGFHK ABAKFIAPGOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	AGMMIOEHCNJ DHHDOCJNLLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DebuggerTypeProxy(typeof(HNOBIOHGNBG))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct MDCKLNCPLLP : IComparable<MDCKLNCPLLP>, IEquatable<MDCKLNCPLLP>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly MDCKLNCPLLP BKMHILKPIAJ;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int NJNFIHOHBBF = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int NKMDHJAKDEH = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int DLNCHHLLGKF = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int BHFLNLGBENA = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId CGNAIHEOONH;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public LFHNKPCBEHN GHGFAEOICJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x62C9FD0", Offset = "0x62C91D0", VA = "0x1862C9FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public GFIIIODKNJM EODCGGGIEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x62D9350", Offset = "0x62D8550", VA = "0x1862D9350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public LocalId FOMEDDKJIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x62D9840", Offset = "0x62D8A40", VA = "0x1862D9840")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal JAHLMKKKDAC FABCNCMPKIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x62D9670", Offset = "0x62D8870", VA = "0x1862D9670")]
		get
		{
			return default(JAHLMKKKDAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool FJFIJPOJCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x62D9680", Offset = "0x62D8880", VA = "0x1862D9680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private bool NHDIFHKEBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x62D9620", Offset = "0x62D8820", VA = "0x1862D9620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x62D99B0", Offset = "0x62D8BB0", VA = "0x1862D99B0")]
	public MDCKLNCPLLP(LFHNKPCBEHN HCPLCIDPJDB, LocalId CGNAIHEOONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
	public MMHEEOMDOGK DPONKLGBLPJ()
	{
		return default(MMHEEOMDOGK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x62D97C0", Offset = "0x62D89C0", VA = "0x1862D97C0")]
	public static LocalId LOOIAEAGNBK(MDCKLNCPLLP GKOJFEPCICN)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x62D9800", Offset = "0x62D8A00", VA = "0x1862D9800")]
	public static Entity LOOIAEAGNBK(MDCKLNCPLLP GKOJFEPCICN)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x62D9230", Offset = "0x62D8430", VA = "0x1862D9230")]
	public static bool AIPCENMEJFE(MDCKLNCPLLP JPEEHDCLFEK, MDCKLNCPLLP HGMCBKHHGFH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x62CF8D0", Offset = "0x62CEAD0", VA = "0x1862CF8D0")]
	public static bool KEIKIALHENC(MDCKLNCPLLP JPEEHDCLFEK, MDCKLNCPLLP HGMCBKHHGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x62D9880", Offset = "0x62D8A80", VA = "0x1862D9880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x62D9490", Offset = "0x62D8690", VA = "0x1862D9490", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x62C9840", Offset = "0x62C8A40", VA = "0x1862C9840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x62D93B0", Offset = "0x62D85B0", VA = "0x1862D93B0", Slot = "4")]
	public int CompareTo(MDCKLNCPLLP NOBJAPGNDAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x62C9510", Offset = "0x62C8710", VA = "0x1862C9510", Slot = "5")]
	public bool Equals(MDCKLNCPLLP NOBJAPGNDAK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class DOMNBOOEFFG
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x62CF1A0", Offset = "0x62CE3A0", VA = "0x1862CF1A0")]
	public static BEHBFJOGLOH KAIMGDNBOJI(this MDCKLNCPLLP JFJMICPDNDH)
	{
		return default(BEHBFJOGLOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x62CF0E0", Offset = "0x62CE2E0", VA = "0x1862CF0E0")]
	public static MMHEEOMDOGK AHOBIBHLCHM(this MDCKLNCPLLP JFJMICPDNDH, [Optional] object FCKLPDKGPKE)
	{
		return default(MMHEEOMDOGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2764340", Offset = "0x2763540", VA = "0x182764340")]
	public static T MDFIOECIHPP<T>(this MDCKLNCPLLP JFJMICPDNDH) where T : struct, HDJOPFOEMAB
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class HNOBIOHGNBG
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct JAHLMKKKDAC : IEquatable<JAHLMKKKDAC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte EIKDEMMADOB;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] CHMHEFBBNJL;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static LFHNKPCBEHN PDPLGHAEAKA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static GFIIIODKNJM HLADAACKJKF;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static LFHNKPCBEHN[] JDDMELGLAOP;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static GFIIIODKNJM[] HIKNPLNHLIA;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> JBJILIDLAGN;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public GFIIIODKNJM EODCGGGIEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x62D5C80", Offset = "0x62D4E80", VA = "0x1862D5C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public LFHNKPCBEHN AHHCOBPPNGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x62D5D60", Offset = "0x62D4F60", VA = "0x1862D5D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x62D6AE0", Offset = "0x62D5CE0", VA = "0x1862D6AE0")]
	static JAHLMKKKDAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xCCE730", Offset = "0xCCD930", VA = "0x180CCE730")]
	internal JAHLMKKKDAC(byte NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x54CFEA0", Offset = "0x54CF0A0", VA = "0x1854CFEA0", Slot = "4")]
	public bool Equals(JAHLMKKKDAC NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x62D5EC0", Offset = "0x62D50C0", VA = "0x1862D5EC0", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1BA55B0", Offset = "0x1BA47B0", VA = "0x181BA55B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x62D6A20", Offset = "0x62D5C20", VA = "0x1862D6A20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x62D6490", Offset = "0x62D5690", VA = "0x1862D6490")]
	private static LFHNKPCBEHN IGCJEHPNHMK(byte EIKDEMMADOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x62D6200", Offset = "0x62D5400", VA = "0x1862D6200")]
	private static GFIIIODKNJM GEOMACIBIEF(byte EIKDEMMADOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x62D68C0", Offset = "0x62D5AC0", VA = "0x1862D68C0")]
	private static object PJJPFMNKMNI(byte EIKDEMMADOB, object[] NGOGJHGFHFE, object FJPKGOAOIBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x62D6530", Offset = "0x62D5730", VA = "0x1862D6530")]
	private static int LLPFBECDKKK(byte EIKDEMMADOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x62D68B0", Offset = "0x62D5AB0", VA = "0x1862D68B0")]
	private static int PDCECLDILLH(byte EIKDEMMADOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x62D5E40", Offset = "0x62D5040", VA = "0x1862D5E40")]
	private static (int, int) EMCFEONLAOH(byte EIKDEMMADOB)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x62D6540", Offset = "0x62D5740", VA = "0x1862D6540")]
	private static byte NDODMDGGALE(int LOGOABBJBAN, int HMFNCGHECPG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x62D5F60", Offset = "0x62D5160", VA = "0x1862D5F60")]
	internal static JAHLMKKKDAC FPMBLPAHIMD(GFIIIODKNJM ACACPAMHNIM, LFHNKPCBEHN LEGMJFKFJFB)
	{
		return default(JAHLMKKKDAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x62D62A0", Offset = "0x62D54A0", VA = "0x1862D62A0")]
	internal static void GFJGGIBFIEB(JAHLMKKKDAC EIKDEMMADOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x62D6550", Offset = "0x62D5750", VA = "0x1862D6550")]
	private static void PAFOJOEGABB(int DIHLAEIGMPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface BKOKBCLJMPE
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOOCLPKBDKK();

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKABDGEFPCP(bool OFKCCPGOBII);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JCOHMICKPPL(GameObject OPEBICILKJE);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface CGALDJFDJCE
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	Guid BENDDHGOKEK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JKCAMIJGNLI(Guid OAGAABJOFBC, Guid ELNJHDPNNOK);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task PCADLPKNPJP(MDCKLNCPLLP BKCLCGKHHEB);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NAIOLKNIOFB(MDCKLNCPLLP DEGINJHPGFA, MDCKLNCPLLP BHNONFFBKHO, [Out] Vector3 CNJLCEDOCCB, [Out] Quaternion AFBNOBHGJDB);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LBLJILIFGBP(IJCJMANMMKE LFFABBECHAI, Vector3 CNJLCEDOCCB, Quaternion AFBNOBHGJDB);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IKAGMGAICEB(MDCKLNCPLLP MAFAGEEAAGE, [Out] Vector3 PCBLFENGENP, [Out] Quaternion AICLHIDEDPN);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface IHKMJMNJGCH
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBKNMLIJKNH(BFODOFFDAJG AIHKOKEKKPF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface HBMIHGGHFFE
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GABKOJBPCDB(GameObject IMDEFAKIFLL, GameObject AMGMODOKKGO, int MJOBHIAHLCN);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface PMCGADGDGBF
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	BKOKBCLJMPE GOABJDDPCFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	KOALNPGNECH NKAJOMELKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	BFBHBFFDJJN BEPAMMOMDFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	OBCILNMFPFO IJPHIJDHIOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	FOOPKFOPIJB DPMINDMFGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	ACFBOLGEALM HJOFENBIPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	LLMBHAGCCEI GGHNJNCEIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	JNLOMPHFFBL AGKPJDFEDEE
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface DKBGIGABAOH
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EPDBIPPOHHC(Action GKGLDBAJJCH, bool PNIJDNLHKEP);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CIHPNJBPLKG(string IKEFBMMMAJB);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface KOALNPGNECH
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	string AFBLMNFGKDM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] PKAEHGCIBPJ(IEnumerable<DNPECAPILFC> EKFGLAKJDMD);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DBJKPPNPNIN(GameObject OPEBICILKJE, [Out] BEHBFJOGLOH[] PNMDPJJJHMB);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NNOEDMDCJIF(GameObject OPEBICILKJE, [Out] int ACNGHKBEDHP, [Out] FHHKGBHDBDG GEFIJDDLJAH);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HCDICLIGECB EBKLMIFEENM(DNPECAPILFC AIJPHINHCJO);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HCDICLIGECB EBKLMIFEENM(string KNKPACLBJAJ, BEHBFJOGLOH[] IGMILLALAMN, Vector3 DHMMMGDKPCG, Quaternion HBCECKEGCGH, Vector3 EKCHLHLGOBO);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GameObject GEFGAPCNCIJ(string KNKPACLBJAJ);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NHAAMHDKCAD(GameObject KFAIAOFCNBB, bool IPJGMHONMIO);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ECEOGBJBBLD(GameObject OPEBICILKJE, bool OKBHMEEOBED, bool HENBBIADCOM);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class GEBIEHNAMJO
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x62CFFF0", Offset = "0x62CF1F0", VA = "0x1862CFFF0")]
	public static HCDICLIGECB EBKLMIFEENM(this KOALNPGNECH KIGDILPPPPG, Vector3 DHMMMGDKPCG, Quaternion HBCECKEGCGH, Vector3 EKCHLHLGOBO, params BEHBFJOGLOH[] PNMDPJJJHMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface BFBHBFFDJJN
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEJICDDAOKI(bool FFABKOCEGNL);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface OBCILNMFPFO
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool JFHBNNLHLAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool KCAKKPDCFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool BCPMMAEMFAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	int ICAPPPJDCIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool NLAKDKOAFCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CKCENLAKMII(object AENCBMJJMMB);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NLONLACKCHH(object AENCBMJJMMB);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OGLGOICKGAC(object IOCBLPNBBJM);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HFBMAHGNJHH(object IOCBLPNBBJM);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int BFALIJGGMHE(GameObject IEMCJEEOMLG);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NDDHHDHLDPP(NativeArray<int> PJDPFOJIHDL);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NKBPGNKPCMF(NativeArray<int> MLKKLLKBJAJ);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CMMIBMIGDLL();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BBCECMHOCNL(uint MBFJIGPHJKO, ReadOnlySpan<byte> JMPOIIIDFDE, bool GCOCIDPGCME = false);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BBCECMHOCNL(uint MBFJIGPHJKO, ReadOnlySpan<byte> JMPOIIIDFDE, ReadOnlySpan<byte> ECLLOBGLFDG, bool GCOCIDPGCME = false);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface FOOPKFOPIJB
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMDKIGDEEHK(GameObject OPEBICILKJE);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface IBEEAMNADKM
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCFBKPGIKMB(string JGNAJPMGGNE);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface ABFKEOIHPGM
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GEAMANENCBA(GameObject OPEBICILKJE);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CIPGGDDOBEB(GameObject OPEBICILKJE);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MMKAELHHJIM(int FNJDHDECLPG);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object CCDFEHDJIKL(MDCKLNCPLLP CGNAIHEOONH, GameObject OPEBICILKJE, Action<MDCKLNCPLLP, int> IAPBAMILEGB);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HNPGFKMBHGJ(GameObject OPEBICILKJE, object NMDBNCIJMGG);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface FPBMBJGEFEB
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool LBLCHCBIHMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate DNFDIFFICIP(AIFPHELDACK.ODGMCIGJBLM MHINBBDFMKC, Action<AIFPHELDACK.ODGMCIGJBLM> IAPBAMILEGB);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PEMKBKIBMGO(AIFPHELDACK.ODGMCIGJBLM MHINBBDFMKC, Delegate IAPBAMILEGB);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate IJPLGIBDLDK(AIFPHELDACK.ODGMCIGJBLM MHINBBDFMKC, Action<AIFPHELDACK.ODGMCIGJBLM> KMPNPMEEDJJ);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OPKOBHOFJGO(AIFPHELDACK.ODGMCIGJBLM MHINBBDFMKC, Delegate IAPBAMILEGB);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GIFOIMPOILG(AIFPHELDACK.ODGMCIGJBLM MHINBBDFMKC);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AIFPHELDACK.ODGMCIGJBLM ELKAHOOGIKO(GameObject OPEBICILKJE);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface ACFBOLGEALM
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	int MIMELPHIFAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	int JGIKMDBBGNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int BNHODOKIHOE(GameObject OPEBICILKJE);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BBLFMMCENCB([Out] Vector3 DHMMMGDKPCG);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IBMFEDOGHIN();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface LLMBHAGCCEI
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool DIMAJDONLHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool ONGMJFFKMLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface CGCJIECAFKG
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	CNIMFFKCDKE IACJMLDKIBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	LEHHIHDEOOP DHMIHLDMGLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GHHIFDIEENG(Transform GCDMIBEHAIO);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GNNFIOCNACJ(Transform GCDMIBEHAIO, PLMNGBPDPGF ECDIKEJHHBO);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GJHOCIGCGMF(Transform GCDMIBEHAIO, AAFKKJIDNGJ OBOFIGAGAMN);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface JNLOMPHFFBL
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FGKADBKHKMI();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface BDIPBPNOJLM
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LOGJIBNILEL();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface PEOEJDGGIGC
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FHHKGBHDBDG AJGAEBKGFMK(GameObject IEMCJEEOMLG);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHLOGFJAJNN(GameObject OPEBICILKJE, ENENJKLEDNA GOEJBFNFGGO, NHMPFBPMHDB BHPEPMMDJAD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string NFNNLNJMBND(int JNIKIHKLGAD);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int CPEHDPMFCEE(string NOPGIOBJJNI);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IJALEHOJGAE(MDCKLNCPLLP CGNAIHEOONH, int[] EHMKHCNPLNL);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NIAGNAFEDLH(InteractionFilterData FODGEDCJIDC, int BMIJGDHAHBI);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HFJJDKOMEOI(MDCKLNCPLLP CGNAIHEOONH, int EHMKHCNPLNL);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OFELLEAGPAP(MDCKLNCPLLP CGNAIHEOONH, int EHMKHCNPLNL);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OFODDBEGEDJ(MDCKLNCPLLP CGNAIHEOONH, bool GEAEHLEHBGO, float3 JKGGEABKIED, quaternion JCKDPKHNCNK);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct HGHFCNEMIBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly AOFPJNNCMKG PFGKDMDHLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly AOFPJNNCMKG KOILIPEDBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal readonly uint JHCOOEGFNBK;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x62D2410", Offset = "0x62D1610", VA = "0x1862D2410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct FNALNDFLECD
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly JJNHGMIGPBK OMJOPGOBIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly HGHFCNEMIBF GKGLDBAJJCH;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x62CFF60", Offset = "0x62CF160", VA = "0x1862CFF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct OILLPCIPPPG
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly JJNHGMIGPBK OMJOPGOBIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly HGHFCNEMIBF GKGLDBAJJCH;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x62CFF60", Offset = "0x62CF160", VA = "0x1862CFF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct LJNIKKDPLJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint JHCOOEGFNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly bool CKOENBNHACE;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x62D8FB0", Offset = "0x62D81B0", VA = "0x1862D8FB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct AOFPJNNCMKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal int BJPGLMJPACN;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x62CA3C0", Offset = "0x62C95C0", VA = "0x1862CA3C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface LOGEEDJCMFA
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	GMCHIPBIPME BDNNHGANLLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum JDKLAEJFCJC
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
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface HCDICLIGECB : INPBENCNOFG
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	MMHEEOMDOGK HGMDLMKNDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	JDKLAEJFCJC PJAIGADGNKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool BEAKKFJKNIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	GameObject OPEBICILKJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<HCDICLIGECB> GIMPJHBMOKH;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(KHINBPNOGDJ AKNFCAPOGJB, MDCKLNCPLLP PCDBKMHIJDL);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool DLFPCPCLDIJ);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class HIKPANKAPNG
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x62D2670", Offset = "0x62D1870", VA = "0x1862D2670")]
	public static bool BIENBGMELLL(this HCDICLIGECB LLNGKGLKEOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x62D27A0", Offset = "0x62D19A0", VA = "0x1862D27A0")]
	public static bool OFLCHLKHCFI(this HCDICLIGECB LLNGKGLKEOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x62D2750", Offset = "0x62D1950", VA = "0x1862D2750")]
	public static bool DMELKBNPCCJ(this HCDICLIGECB LLNGKGLKEOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x62D26C0", Offset = "0x62D18C0", VA = "0x1862D26C0")]
	public static bool CBEJMOMNALI(this HCDICLIGECB LLNGKGLKEOB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface INPBENCNOFG
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool FLFFMMHGNFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	MDCKLNCPLLP AHIKPAJLFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[CNJGMKKABCG(FGONPGLMBDD.LoadInstance)]
internal interface FBODJCOFIAC
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<GHMDAAEBJMA> DECIBNNFKCI;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface BPLBIHICDIL
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface AFJNJNBJEFF
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(IHMHPNACLKD OGPPKJBOECO);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface IHMHPNACLKD
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	GameObject OPEBICILKJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Transform GCDMIBEHAIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	HCDGCCECAEP LCMBEJAKIIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool AOBLMCNBENP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LJOKIFACMPC(HCDGCCECAEP PFGBPGKFOLN);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface HCDGCCECAEP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	MDCKLNCPLLP AHIKPAJLFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	Rigidbody FLEDBGNMPOM
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	IHMHPNACLKD BGJAPCJPLML
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	GameObject OFPFIDAFJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	Transform BHIBJBFFJDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	HCDGCCECAEP ANNFPHELCLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	HCDGCCECAEP AKJHKAMODFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	int JKBKEJCNPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool GIFOIMPOILG
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool HBONMENFLEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	CKLELEBFCJP GBLMDIJCCFK
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	EJAOGNIOOGM CIHJGHDKNLG
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	float PNFPKEPCDAO
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	Vector3 JKHEFEAECKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	Vector3 AOFHKBKNJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	Vector3 JPCJHLPMEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Vector3 MEJNHHCNIPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	bool LFOGNOOKPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	bool FFDPHNMHHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	bool IJKNPLBEOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 OKKAABABFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	Vector3 NPHAPCACINB
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 CJACLIKLAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "50")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Vector3 BGMIGEKMIAN
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	float KHKDBEGDKEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float DHGDJCEHBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 EDGGKDBKLPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Quaternion AKMHFFBBAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	float HILNNJPODPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float HMHKEPLBCDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	bool GKIDIPKJAKF
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	GPHAHJNAAFN CNDJCFNOHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool CCEEOOAEGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Transform BHDKKMFADHO
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Vector3 GBDENECPBOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	float FDAEOKKDIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	float AMNHIPPOEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	Quaternion HEEFMLJPIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Vector3 APOIDAPMEHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Quaternion CDOBGHCOBEA
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	RigidbodyConstraints HHECACDFAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool DOGPMNAPHGE
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	CollisionDetectionMode GKMIBJKCABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool DKMCEHCODFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event MGHEEHNOJLO FNMAGHNOFCC;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event MGHEEHNOJLO NOBKCJFFBGK;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event MGHEEHNOJLO DFAPJOPCDIP;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event MGHEEHNOJLO CMLAOOOKDID;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event MGHEEHNOJLO EMCCEHAFIAI;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event MGHEEHNOJLO MCFIPJHMPLA;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event MGHEEHNOJLO DKDFEBGJMEJ;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event BEBLGGPGHFJ BLDJHFBKICJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<PGDHFLLAIAB, PGDHFLLAIAB> HJIJHKADNOE;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "26")]
	HCDGCCECAEP PEEDFMHLIJM(int HMFNCGHECPG);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void HMIPLFKMHEA((Quaternion rot, Vector3 moments) PCCDIKIMCKI);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void ABMIDKDAPOK();

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void KJLBGOBDLMG();

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void HGCNFAPLFPD();

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void EFMNMIEBMDH();

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void CFLHPBMALHN(HCDGCCECAEP NICEPFIEJED, bool BGMNOFHPMFB = false);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void GOMMJMMMPNA(object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void IFAHBEOHDON(object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 JKEILGMCIDM(Vector3 DEPCJPCCEGP);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "95")]
	Vector3 PDOGEJIDCEK(Vector3 MGKFELLKNBM);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void MANEBCKGDDJ();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void JOHLBECDCDI();

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void HAFMKOKJLCL();

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void OPBCAKCJMIB(Vector3 FDMEDIMDJFI, Vector3 OJHACBOBKAK);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void LOHDNDLMHOO(Vector3 DHIAIOAJMJE, Vector3 IOOLPCCNOIN);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void PJDEILJPDJM(Vector3 HLNHFEOKKJM);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void OINGMABDDGL(ODFIFOEIPOB JPNLMCAHNCF, Vector3 IIJKIDIFJNO, float OPKCPNAOJLG, float ADLHHECADCN = 8f, float GGJBGFMFPBH = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void FFBBIPLAOEM(MCKLPPJOMOK LAEAKPFEGLK, Vector3 PNGPNDMJNGP, float GEHEKDBMGLO = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void NNKFGPELLFO(MCKLPPJOMOK LAEAKPFEGLK, Vector3 HBCECKEGCGH, float NKOKHDMEPJH = 7f, float IDFHKKPEKIN = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "105")]
	Vector3 NMFIDAGOJBF(Vector3 NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "106")]
	Vector3 CEABJHICAGI(Vector3 NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void LCCEBIADBEF();

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void DOKFGGFHMDO(HCDGCCECAEP KJBFBPNGEEG, object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "109")]
	void GMNNFMBMAAC(object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void OMDJECHMMFA();

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void LOMDLBEHMCP();

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void JOHBOOBKFFJ();

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "113")]
	bool EDCIGFOEIPE();

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void IGFKFBEIGID();

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void CKIHJJBLEMP(object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "116")]
	void GPHBMEFNNLI(object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void CMOHPMGOLDH(object FCKLPDKGPKE, bool PDEBHACKBII);

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void AGAKJCEELFL(Vector3 JGCGPCIKADF, Quaternion KFAMAMEBBII);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void LODAHKFJHLF(Vector3 DCAILIEPHOG, Quaternion MIBEENCCLHM);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "120")]
	bool DLKDHMHCAPE(float FHNIBDNNPGA);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void EABMDPMPNDC(object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void JBNOLFEOKIP(object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void KHEHMGDAINE(object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void MBIBPFFCOBC(object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void HJAMKJNKGOF(Vector3 FCLAIJBMLJG, ForceMode OAEDCOGNIMA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void JKIBLHBEEPO(Vector3 FCLAIJBMLJG, Vector3 DHMMMGDKPCG, ForceMode OAEDCOGNIMA);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void OFMNNELFOAF(Vector3 BCBAKMNPAGJ, ForceMode OAEDCOGNIMA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void OLEFEGOKGDN(Vector3 BCBAKMNPAGJ, ForceMode OAEDCOGNIMA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "129")]
	bool FPAFMIKNLGH(Vector3 ILKFGPOHBIP, [Out] RaycastHit CMMBAEFAAGG, float HJPKMNIGHNC);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void IFIADBNNDNA();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface EJAOGNIOOGM
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FIMMCNENAJG(Vector3 HIILLBLGAAE);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MBMOHCEGCBL(Vector3 IACHFILKNFB);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IBGMGCGOKGP(Vector3 HIILLBLGAAE);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ICAHDJBPAKD(Vector3 IACHFILKNFB);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface CKLELEBFCJP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 AIKAIHNNGMM();

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 MJKMLEIDIIO();
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public delegate void MGHEEHNOJLO(IHMHPNACLKD MBPOIKOGCKA);
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum LPCEMBMOFAI
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	ChildAdded,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	ChildRemoved,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	ParentChanged,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	HierarchyMassUpdated,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	SleepChanged,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	DistanceBandChanged,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	IsKinematicChanged,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Discontinuity,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Destroyed,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum ODFIFOEIPOB
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Reflective,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	FullOverride
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public delegate void BEBLGGPGHFJ(IHMHPNACLKD MBPOIKOGCKA, bool BGMNOFHPMFB = false);
[Cpp2IlInjected.Token(Token = "0x200003C")]
public enum MCKLPPJOMOK
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct BICJDOJJHMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Rigidbody PDECCLFHGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object MMBOHDDPJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Vector3 FKMCDAMJKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Vector3 MNGMGGGOAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public ANOFOMAGMPD JMKNFJCECHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public bool EBHHPKLMFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public bool LGCGEIPODOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool INMFOMLNIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public bool CPIPADDFABF;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface JPMALLCFNFB : CECJNIGALIJ<BEHBFJOGLOH>, GHMNNMAOIGN, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface BINCGBJEMIN<T> : BGMJOKDMFMI<BEHBFJOGLOH, T>, CECJNIGALIJ<BEHBFJOGLOH>, GHMNNMAOIGN, IDisposable, JPMALLCFNFB where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class BDFCLPFJIAN
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x26A5E10", Offset = "0x26A5010", VA = "0x1826A5E10")]
	public static bool FBKMABELHLO<T>(this CECJNIGALIJ<BEHBFJOGLOH> KCBHGLJDNNP, BEHBFJOGLOH IGMILLALAMN, [Out] T NICEPFIEJED) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x26A5DF0", Offset = "0x26A4FF0", VA = "0x1826A5DF0")]
	public static bool BHMONLIGLCO<T>(this CECJNIGALIJ<BEHBFJOGLOH> KCBHGLJDNNP, BEHBFJOGLOH IGMILLALAMN, [In] T AOEOAHBCBKJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface JKOHOMCCJCN : CECJNIGALIJ<MDCKLNCPLLP>, GHMNNMAOIGN, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface CFJCCJNMOGI<T> : BGMJOKDMFMI<MDCKLNCPLLP, T>, CECJNIGALIJ<MDCKLNCPLLP>, GHMNNMAOIGN, IDisposable, JKOHOMCCJCN where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class DKAHNJCOOBC
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x26A6EE0", Offset = "0x26A60E0", VA = "0x1826A6EE0")]
	public static T OLBNKGLEPPK<T>(this CECJNIGALIJ<MDCKLNCPLLP> KCBHGLJDNNP, MDCKLNCPLLP CGNAIHEOONH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x27183B0", Offset = "0x27175B0", VA = "0x1827183B0")]
	public static bool BHMONLIGLCO<T>(this CECJNIGALIJ<MDCKLNCPLLP> KCBHGLJDNNP, MDCKLNCPLLP CGNAIHEOONH, [In] T AOEOAHBCBKJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct HNNMKBLNAPG : IComparable<HNNMKBLNAPG>, IEquatable<HNNMKBLNAPG>
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly HNNMKBLNAPG BKMHILKPIAJ;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly HNNMKBLNAPG GAHAOKGFKGD;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly HNNMKBLNAPG CKIDNMMNGDK;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly HNNMKBLNAPG ICKPHAFMBOG;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly HNNMKBLNAPG LCOKBLDALKP;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly HNNMKBLNAPG LKOJBMCCPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public int JPDBMMOIFEO;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool EIJIIFJJGPA
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x62D4C50", Offset = "0x62D3E50", VA = "0x1862D4C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int NJINHJNHEIC
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x62D4D40", Offset = "0x62D3F40", VA = "0x1862D4D40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x91AD70", Offset = "0x919F70", VA = "0x18091AD70")]
	public HNNMKBLNAPG(int HMFNCGHECPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x62D4CE0", Offset = "0x62D3EE0", VA = "0x1862D4CE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x62D4C60", Offset = "0x62D3E60", VA = "0x1862D4C60", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x8A5400", Offset = "0x8A4600", VA = "0x1808A5400", Slot = "5")]
	public bool Equals(HNNMKBLNAPG NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x18AC8F0", Offset = "0x18ABAF0", VA = "0x1818AC8F0", Slot = "4")]
	public int CompareTo(HNNMKBLNAPG NOBJAPGNDAK)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0xD64C80", Offset = "0xD63E80", VA = "0x180D64C80")]
	public static HNNMKBLNAPG LOOIAEAGNBK(int HMFNCGHECPG)
	{
		return default(HNNMKBLNAPG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0xD64C80", Offset = "0xD63E80", VA = "0x180D64C80")]
	public static int LOOIAEAGNBK(HNNMKBLNAPG ECGHOPLJMLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x62D4D50", Offset = "0x62D3F50", VA = "0x1862D4D50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct MMHEEOMDOGK : IEquatable<MMHEEOMDOGK>, INPBENCNOFG
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly MMHEEOMDOGK PHIOOJJLEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly MDCKLNCPLLP GCHHFDIEIFL;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public MDCKLNCPLLP AHIKPAJLFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60", Slot = "6")]
		get
		{
			return default(MDCKLNCPLLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public HKECDLCMNBC BHIBJBFFJDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(HKECDLCMNBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public LCLEMNDIDBM EGEOJFLJNFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(LCLEMNDIDBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private LFHNKPCBEHN GHGFAEOICJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x62C9FD0", Offset = "0x62C91D0", VA = "0x1862C9FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public GameObject OPEBICILKJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x62DA110", Offset = "0x62D9310", VA = "0x1862DA110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public BEHBFJOGLOH CMGNAPMDEJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x62DA2A0", Offset = "0x62D94A0", VA = "0x1862DA2A0")]
		get
		{
			return default(BEHBFJOGLOH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public KEHJAHBCGEJ AEMALGFOGAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x62DA6C0", Offset = "0x62D98C0", VA = "0x1862DA6C0")]
		get
		{
			return default(KEHJAHBCGEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public FHHKGBHDBDG NILAPJACLEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x62D9EF0", Offset = "0x62D90F0", VA = "0x1862D9EF0")]
		get
		{
			return default(FHHKGBHDBDG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool DAFLNHNIMDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x62DA660", Offset = "0x62D9860", VA = "0x1862DA660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool AAGEECELGNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x62DA4F0", Offset = "0x62D96F0", VA = "0x1862DA4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool LPKMGJEJKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x62D9EA0", Offset = "0x62D90A0", VA = "0x1862D9EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool KELBFIADBDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x62DA4D0", Offset = "0x62D96D0", VA = "0x1862DA4D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool DOFIDEMEGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x62DA510", Offset = "0x62D9710", VA = "0x1862DA510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool GBPLPLCAHHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x62D9E60", Offset = "0x62D9060", VA = "0x1862D9E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool FGBIEOEINHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x62D9CF0", Offset = "0x62D8EF0", VA = "0x1862D9CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool BOJBGKGICLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x62DA680", Offset = "0x62D9880", VA = "0x1862DA680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool COKOKLPGLKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x62DA430", Offset = "0x62D9630", VA = "0x1862DA430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public CDJIAPHACPI JPJIJKHKHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(CDJIAPHACPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public EHNHBKECIIL FCJBIIILLCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(EHNHBKECIIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public AMKODCLOMJB LFICFFCBEAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(AMKODCLOMJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public HCLBILLFMLM AFMIKDCKMNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(HCLBILLFMLM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public JJNLOFNOCLC LCAKBNHDLCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(JJNLOFNOCLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public ONKELNLIBIK PIPFHLNKOPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(ONKELNLIBIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public IJCJMANMMKE FMAOBKDICEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(IJCJMANMMKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public BAGMNPAANOG DDNJLFAGHHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(BAGMNPAANOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public AAIKHDJKBFM IANMFDKKHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(AAIKHDJKBFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public JJMEODHOBLE FKHFHLJOAIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(JJMEODHOBLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool BIENBGMELLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x62DA020", Offset = "0x62D9220", VA = "0x1862DA020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool HIDJFDMLPBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x62DA620", Offset = "0x62D9820", VA = "0x1862DA620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool BLFKKHENLNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x62D9D30", Offset = "0x62D8F30", VA = "0x1862D9D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private bool NAPLDFEDLIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
	public MMHEEOMDOGK(MDCKLNCPLLP CGNAIHEOONH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x62CA1A0", Offset = "0x62C93A0", VA = "0x1862CA1A0")]
	public static bool LOOIAEAGNBK(MMHEEOMDOGK NICEPFIEJED)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220")]
	public static MDCKLNCPLLP LOOIAEAGNBK(MMHEEOMDOGK NICEPFIEJED)
	{
		return default(MDCKLNCPLLP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x62CA670", Offset = "0x62C9870", VA = "0x1862CA670")]
	public static bool AIPCENMEJFE(MMHEEOMDOGK JPEEHDCLFEK, MMHEEOMDOGK HGMCBKHHGFH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x62CF8D0", Offset = "0x62CEAD0", VA = "0x1862CF8D0")]
	public static bool KEIKIALHENC(MMHEEOMDOGK JPEEHDCLFEK, MMHEEOMDOGK HGMCBKHHGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x62C9840", Offset = "0x62C8A40", VA = "0x1862C9840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x62D9F90", Offset = "0x62D9190", VA = "0x1862D9F90", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x62C9510", Offset = "0x62C8710", VA = "0x1862C9510", Slot = "4")]
	public bool Equals(MMHEEOMDOGK NOBJAPGNDAK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220")]
	public static MMHEEOMDOGK LOOIAEAGNBK(MDCKLNCPLLP GCHHFDIEIFL)
	{
		return default(MMHEEOMDOGK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x62DA450", Offset = "0x62D9650", VA = "0x1862DA450")]
	public BBOANHNJHNL MKAPNIFLCDI()
	{
		return default(BBOANHNJHNL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x62D9EC0", Offset = "0x62D90C0", VA = "0x1862D9EC0")]
	public EBFGHMDKGAI EJCFJNCMPHD()
	{
		return default(EBFGHMDKGAI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x62D9E10", Offset = "0x62D9010", VA = "0x1862D9E10")]
	public GPEKCHACHHJ CJIMAKHLGDK()
	{
		return default(GPEKCHACHHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x62D9D70", Offset = "0x62D8F70", VA = "0x1862D9D70")]
	public void AHOBIBHLCHM([Optional] object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x62DA530", Offset = "0x62D9730", VA = "0x1862DA530")]
	public bool NOEDNAEMJPE(object FCKLPDKGPKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x62DA340", Offset = "0x62D9540", VA = "0x1862DA340")]
	public bool HKAHEJFAHNP(object FCKLPDKGPKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x62DA760", Offset = "0x62D9960", VA = "0x1862DA760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct IJCJMANMMKE : IEquatable<IJCJMANMMKE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly MDCKLNCPLLP GCHHFDIEIFL;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public MDCKLNCPLLP AHIKPAJLFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MDCKLNCPLLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public MMHEEOMDOGK HGMDLMKNDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MMHEEOMDOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private LFHNKPCBEHN GHGFAEOICJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x62C9FD0", Offset = "0x62C91D0", VA = "0x1862C9FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private ELBMHFDBKDI GDBJCNNKDCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x62D5370", Offset = "0x62D4570", VA = "0x1862D5370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private AFMPDJPGEFE EHOHNPNMIMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x62D56D0", Offset = "0x62D48D0", VA = "0x1862D56D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool IFFFJGKLJJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x62D55B0", Offset = "0x62D47B0", VA = "0x1862D55B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public Guid AABEKGJBOCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x62D5250", Offset = "0x62D4450", VA = "0x1862D5250")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool HJJKMBOAFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x62D5400", Offset = "0x62D4600", VA = "0x1862D5400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Guid JAJIKDFMLDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x62D5130", Offset = "0x62D4330", VA = "0x1862D5130")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
	public IJCJMANMMKE(MDCKLNCPLLP CGNAIHEOONH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x62CA1A0", Offset = "0x62C93A0", VA = "0x1862CA1A0")]
	public static bool LOOIAEAGNBK(IJCJMANMMKE NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x62C9840", Offset = "0x62C8A40", VA = "0x1862C9840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x62D5640", Offset = "0x62D4840", VA = "0x1862D5640", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x62C9510", Offset = "0x62C8710", VA = "0x1862C9510", Slot = "4")]
	public bool Equals(IJCJMANMMKE NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x62CA030", Offset = "0x62C9230", VA = "0x1862CA030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x62D5730", Offset = "0x62D4930", VA = "0x1862D5730")]
	public bool LDFFGEIMPAC([Out] Guid NMEFCALOOLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x62D57D0", Offset = "0x62D49D0", VA = "0x1862D57D0")]
	public void LGPLLFKNPJH(Guid LJPPKNAEGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x62D5980", Offset = "0x62D4B80", VA = "0x1862D5980")]
	public bool PNMFBNOFHIA([Out] Guid EPGOCEDJKAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x62D5490", Offset = "0x62D4690", VA = "0x1862D5490")]
	public void EKBJNAIONOF(Guid LJPPKNAEGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x62D58F0", Offset = "0x62D4AF0", VA = "0x1862D58F0")]
	public void MGOLJJNPJDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct GPEKCHACHHJ : IEquatable<GPEKCHACHHJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly MDCKLNCPLLP GCHHFDIEIFL;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public MDCKLNCPLLP AHIKPAJLFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MDCKLNCPLLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public MMHEEOMDOGK HGMDLMKNDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MMHEEOMDOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private LFHNKPCBEHN GHGFAEOICJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x62C9FD0", Offset = "0x62C91D0", VA = "0x1862C9FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private ELBMHFDBKDI GDBJCNNKDCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x62D04C0", Offset = "0x62CF6C0", VA = "0x1862D04C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private GCOOEKKAODH GEOKEPKEAAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x62D05E0", Offset = "0x62CF7E0", VA = "0x1862D05E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 MHBBGGHLPKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x62D0820", Offset = "0x62CFA20", VA = "0x1862D0820")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Quaternion BGMLKMCPCNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x62D06D0", Offset = "0x62CF8D0", VA = "0x1862D06D0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public MMHEEOMDOGK EFNHHCABGND
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x62D0550", Offset = "0x62CF750", VA = "0x1862D0550")]
		get
		{
			return default(MMHEEOMDOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
	public GPEKCHACHHJ(MDCKLNCPLLP CGNAIHEOONH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220")]
	public static MDCKLNCPLLP LOOIAEAGNBK(GPEKCHACHHJ NICEPFIEJED)
	{
		return default(MDCKLNCPLLP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x62C9840", Offset = "0x62C8A40", VA = "0x1862C9840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x62D0640", Offset = "0x62CF840", VA = "0x1862D0640", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x62C9510", Offset = "0x62C8710", VA = "0x1862C9510", Slot = "4")]
	public bool Equals(GPEKCHACHHJ NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x62CA030", Offset = "0x62C9230", VA = "0x1862CA030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct BBOANHNJHNL : IEquatable<BBOANHNJHNL>
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly BBOANHNJHNL PHIOOJJLEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly MDCKLNCPLLP GCHHFDIEIFL;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public MDCKLNCPLLP AHIKPAJLFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MDCKLNCPLLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public MMHEEOMDOGK HGMDLMKNDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MMHEEOMDOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public HKECDLCMNBC BHIBJBFFJDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(HKECDLCMNBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public LCLEMNDIDBM EGEOJFLJNFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(LCLEMNDIDBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private LFHNKPCBEHN GHGFAEOICJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x62C9FD0", Offset = "0x62C91D0", VA = "0x1862C9FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private ELBMHFDBKDI GDBJCNNKDCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x62CA6E0", Offset = "0x62C98E0", VA = "0x1862CA6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private HFHCPMEEFCA LNMJDPGKFOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x62CBA80", Offset = "0x62CAC80", VA = "0x1862CBA80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public BFODOFFDAJG CNPHDGKDAGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x62CB540", Offset = "0x62CA740", VA = "0x1862CB540")]
		get
		{
			return default(BFODOFFDAJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public IEnumerable<MMHEEOMDOGK> JHNAJOHIHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x62CB140", Offset = "0x62CA340", VA = "0x1862CB140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public IEnumerable<MMHEEOMDOGK> IBNAECFDMHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x62CBDD0", Offset = "0x62CAFD0", VA = "0x1862CBDD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public int JKBKEJCNPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x62CBEF0", Offset = "0x62CB0F0", VA = "0x1862CBEF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int IOAFLOLFOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x62CBCC0", Offset = "0x62CAEC0", VA = "0x1862CBCC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public string ECHFBJHACCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x62CBC10", Offset = "0x62CAE10", VA = "0x1862CBC10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x62CAFB0", Offset = "0x62CA1B0", VA = "0x1862CAFB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public AMPNCKEABLE OBCGKJKMOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x62CB8E0", Offset = "0x62CAAE0", VA = "0x1862CB8E0")]
		get
		{
			return default(AMPNCKEABLE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x62CB0D0", Offset = "0x62CA2D0", VA = "0x1862CB0D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public IFHCIJGELLJ PPNCGCOAAHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x62CA8C0", Offset = "0x62C9AC0", VA = "0x1862CA8C0")]
		get
		{
			return default(IFHCIJGELLJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x62CA770", Offset = "0x62C9970", VA = "0x1862CA770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public HFGDBBHGGDC OBBANGDGIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x62CBD70", Offset = "0x62CAF70", VA = "0x1862CBD70")]
		get
		{
			return default(HFGDBBHGGDC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x62CB810", Offset = "0x62CAA10", VA = "0x1862CB810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public float MPAOELPKDOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x62CBD10", Offset = "0x62CAF10", VA = "0x1862CBD10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x62CC640", Offset = "0x62CB840", VA = "0x1862CC640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool APFLCDNOOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x62CB940", Offset = "0x62CAB40", VA = "0x1862CB940")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x62CBF80", Offset = "0x62CB180", VA = "0x1862CBF80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool KFOGOILFLIL
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x62CA680", Offset = "0x62C9880", VA = "0x1862CA680")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x62CA7E0", Offset = "0x62C99E0", VA = "0x1862CA7E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool MBPLNIPDMMC
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x62CB880", Offset = "0x62CAA80", VA = "0x1862CB880")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x62CB700", Offset = "0x62CA900", VA = "0x1862CB700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool KJABJCFMOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x62CC5C0", Offset = "0x62CB7C0", VA = "0x1862CC5C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x62CBAE0", Offset = "0x62CACE0", VA = "0x1862CBAE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool MPPPJNNMCNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x62CBB50", Offset = "0x62CAD50", VA = "0x1862CBB50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x62CB060", Offset = "0x62CA260", VA = "0x1862CB060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool DCHAKGHGNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x62CB6A0", Offset = "0x62CA8A0", VA = "0x1862CB6A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x62CA850", Offset = "0x62C9A50", VA = "0x1862CA850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool OFCFAJAFBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x62CB450", Offset = "0x62CA650", VA = "0x1862CB450")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x62CA920", Offset = "0x62C9B20", VA = "0x1862CA920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public CBEOBLKLLNC JLIEDANMFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x62CBBB0", Offset = "0x62CADB0", VA = "0x1862CBBB0")]
		get
		{
			return default(CBEOBLKLLNC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x62CB9A0", Offset = "0x62CABA0", VA = "0x1862CB9A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public IEnumerable<int> CLNMMPEOIKL
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x62CB600", Offset = "0x62CA800", VA = "0x1862CB600")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x62CBFF0", Offset = "0x62CB1F0", VA = "0x1862CBFF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public int KGPEDAENDBN
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x62CB770", Offset = "0x62CA970", VA = "0x1862CB770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
	public BBOANHNJHNL(MDCKLNCPLLP CGNAIHEOONH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x62CA1A0", Offset = "0x62C93A0", VA = "0x1862CA1A0")]
	public static bool LOOIAEAGNBK(BBOANHNJHNL NICEPFIEJED)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x62CA670", Offset = "0x62C9870", VA = "0x1862CA670")]
	public static bool AIPCENMEJFE(BBOANHNJHNL JPEEHDCLFEK, BBOANHNJHNL HGMCBKHHGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x62C9840", Offset = "0x62C8A40", VA = "0x1862C9840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x62CB4B0", Offset = "0x62CA6B0", VA = "0x1862CB4B0", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x62C9510", Offset = "0x62C8710", VA = "0x1862C9510", Slot = "4")]
	public bool Equals(BBOANHNJHNL NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x62CA030", Offset = "0x62C9230", VA = "0x1862CA030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220")]
	public static MMHEEOMDOGK LOOIAEAGNBK(BBOANHNJHNL KNKOEEEKHDK)
	{
		return default(MMHEEOMDOGK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x62CC620", Offset = "0x62CB820", VA = "0x1862CC620")]
	public bool PMKOCJMHJOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x62CBA10", Offset = "0x62CAC10", VA = "0x1862CBA10")]
	public bool LCOFGLCOHLD(DMFJIBOHKNI OMDDAPPBCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x62CA990", Offset = "0x62C9B90", VA = "0x1862CA990")]
	public void CBIHCEJBLKA(DMFJIBOHKNI OMDDAPPBCGD, bool NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x62CB2A0", Offset = "0x62CA4A0", VA = "0x1862CB2A0")]
	public BFODOFFDAJG EBILONJNKNB(Allocator ILEAEEDKNCF)
	{
		return default(BFODOFFDAJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x62CC250", Offset = "0x62CB450", VA = "0x1862CC250")]
	public void OHMPFPNJAIM(BBOANHNJHNL NOBJAPGNDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x62CAA10", Offset = "0x62C9C10", VA = "0x1862CAA10")]
	public void CEBLABGKANI(List<MMHEEOMDOGK> MHALBOHBHDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct KLHOMOKKCLH : IEquatable<KLHOMOKKCLH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly MDCKLNCPLLP GCHHFDIEIFL;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public MMHEEOMDOGK HGMDLMKNDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MMHEEOMDOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x62C9840", Offset = "0x62C8A40", VA = "0x1862C9840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x62D8270", Offset = "0x62D7470", VA = "0x1862D8270", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x62C9510", Offset = "0x62C8710", VA = "0x1862C9510", Slot = "4")]
	public bool Equals(KLHOMOKKCLH NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x62CA030", Offset = "0x62C9230", VA = "0x1862CA030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct EHNHBKECIIL : IEquatable<EHNHBKECIIL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly MDCKLNCPLLP GCHHFDIEIFL;

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public MMHEEOMDOGK HGMDLMKNDIN
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MMHEEOMDOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private LFHNKPCBEHN GHGFAEOICJB
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x62C9FD0", Offset = "0x62C91D0", VA = "0x1862C9FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
	public EHNHBKECIIL(MDCKLNCPLLP CGNAIHEOONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x62C9840", Offset = "0x62C8A40", VA = "0x1862C9840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x62CFD70", Offset = "0x62CEF70", VA = "0x1862CFD70", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x62C9510", Offset = "0x62C8710", VA = "0x1862C9510", Slot = "4")]
	public bool Equals(EHNHBKECIIL NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x62CA030", Offset = "0x62C9230", VA = "0x1862CA030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x62CFE00", Offset = "0x62CF000", VA = "0x1862CFE00")]
	public void HDPILJBHDHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x62CFC30", Offset = "0x62CEE30", VA = "0x1862CFC30")]
	public void DCPEIGABIML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x62CFCD0", Offset = "0x62CEED0", VA = "0x1862CFCD0")]
	public bool ELAECKMNNOJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct LCLEMNDIDBM : IEquatable<LCLEMNDIDBM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly MDCKLNCPLLP GCHHFDIEIFL;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public MDCKLNCPLLP AHIKPAJLFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MDCKLNCPLLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public MMHEEOMDOGK HGMDLMKNDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MMHEEOMDOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	private LFHNKPCBEHN GHGFAEOICJB
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x62C9FD0", Offset = "0x62C91D0", VA = "0x1862C9FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private ELBMHFDBKDI GDBJCNNKDCD
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x62D8540", Offset = "0x62D7740", VA = "0x1862D8540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private HFHCPMEEFCA LNMJDPGKFOD
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x62D8D60", Offset = "0x62D7F60", VA = "0x1862D8D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public MDCKLNCPLLP NGEOFNPMHDL
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x62D84B0", Offset = "0x62D76B0", VA = "0x1862D84B0")]
		get
		{
			return default(MDCKLNCPLLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public MMHEEOMDOGK ANNFPHELCLK
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x62D8BD0", Offset = "0x62D7DD0", VA = "0x1862D8BD0")]
		get
		{
			return default(MMHEEOMDOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public MMHEEOMDOGK AKJHKAMODFK
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x62D8A20", Offset = "0x62D7C20", VA = "0x1862D8A20")]
		get
		{
			return default(MMHEEOMDOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
	public LCLEMNDIDBM(MDCKLNCPLLP CGNAIHEOONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x62C9840", Offset = "0x62C8A40", VA = "0x1862C9840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x62D8990", Offset = "0x62D7B90", VA = "0x1862D8990", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x62C9510", Offset = "0x62C8710", VA = "0x1862C9510", Slot = "4")]
	public bool Equals(LCLEMNDIDBM NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x62CA030", Offset = "0x62C9230", VA = "0x1862CA030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x62D8860", Offset = "0x62D7A60", VA = "0x1862D8860")]
	public bool CFLHPBMALHN(MMHEEOMDOGK BHNONFFBKHO, bool OFFENFFHFHL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x62D8CC0", Offset = "0x62D7EC0", VA = "0x1862D8CC0")]
	public bool KLNMCLIFBCH(MMHEEOMDOGK PBHEBDNHMAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x62D85D0", Offset = "0x62D77D0", VA = "0x1862D85D0")]
	private void BJLDOIICPAG(MMHEEOMDOGK KFHPHPJFPMG, List<MMHEEOMDOGK> OEJONKCDKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x62D8DC0", Offset = "0x62D7FC0", VA = "0x1862D8DC0")]
	public BBOANHNJHNL MMJMNKMHCDM()
	{
		return default(BBOANHNJHNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x62D8C60", Offset = "0x62D7E60", VA = "0x1862D8C60")]
	public void KJLJHMBALIA(List<MMHEEOMDOGK> NDCEPMBPNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x62D8AB0", Offset = "0x62D7CB0", VA = "0x1862D8AB0")]
	public NativeArray<MDCKLNCPLLP> FKIGIOKGPMP()
	{
		return default(NativeArray<MDCKLNCPLLP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct CDJIAPHACPI : IEquatable<CDJIAPHACPI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly MDCKLNCPLLP GCHHFDIEIFL;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public MMHEEOMDOGK HGMDLMKNDIN
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MMHEEOMDOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public string IOJNOHEFDDD
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x62CD650", Offset = "0x62CC850", VA = "0x1862CD650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public string HIOIPIMIKNP
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x62CD590", Offset = "0x62CC790", VA = "0x1862CD590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private bool OCNLMNNNHHM
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x62CD110", Offset = "0x62CC310", VA = "0x1862CD110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public string HINELFHPNCA
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x62CD4A0", Offset = "0x62CC6A0", VA = "0x1862CD4A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public string LEIPPFDILCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x62CD250", Offset = "0x62CC450", VA = "0x1862CD250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public string FEAJDDLBIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x62CD020", Offset = "0x62CC220", VA = "0x1862CD020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
	public CDJIAPHACPI(MDCKLNCPLLP CGNAIHEOONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x62C9840", Offset = "0x62C8A40", VA = "0x1862C9840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x62CCF90", Offset = "0x62CC190", VA = "0x1862CCF90", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x62C9510", Offset = "0x62C8710", VA = "0x1862C9510", Slot = "4")]
	public bool Equals(CDJIAPHACPI NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x62CA030", Offset = "0x62C9230", VA = "0x1862CA030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct OOPKOAPBKML : IEquatable<OOPKOAPBKML>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly MDCKLNCPLLP GCHHFDIEIFL;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public MMHEEOMDOGK HGMDLMKNDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MMHEEOMDOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x62C9840", Offset = "0x62C8A40", VA = "0x1862C9840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x62DB200", Offset = "0x62DA400", VA = "0x1862DB200", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x62C9510", Offset = "0x62C8710", VA = "0x1862C9510", Slot = "4")]
	public bool Equals(OOPKOAPBKML NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x62CA030", Offset = "0x62C9230", VA = "0x1862CA030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct AMKODCLOMJB : IEquatable<AMKODCLOMJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly MDCKLNCPLLP GCHHFDIEIFL;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public MMHEEOMDOGK HGMDLMKNDIN
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MMHEEOMDOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
	public AMKODCLOMJB(MDCKLNCPLLP CGNAIHEOONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x62C9840", Offset = "0x62C8A40", VA = "0x1862C9840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x62CA330", Offset = "0x62C9530", VA = "0x1862CA330", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x62C9510", Offset = "0x62C8710", VA = "0x1862C9510", Slot = "4")]
	public bool Equals(AMKODCLOMJB NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x62CA030", Offset = "0x62C9230", VA = "0x1862CA030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x62CA1C0", Offset = "0x62C93C0", VA = "0x1862CA1C0")]
	public bool BOOBGCCCNPH([Out] Collider ENONIHHKHLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct JJMEODHOBLE : IEquatable<JJMEODHOBLE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly MDCKLNCPLLP GCHHFDIEIFL;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public MDCKLNCPLLP AHIKPAJLFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MDCKLNCPLLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public MMHEEOMDOGK HGMDLMKNDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MMHEEOMDOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private BMAGIPMGFHK OHDPMBAKNOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x62D6AF0", Offset = "0x62D5CF0", VA = "0x1862D6AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
	public JJMEODHOBLE(MDCKLNCPLLP CGNAIHEOONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x62C9840", Offset = "0x62C8A40", VA = "0x1862C9840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x62D6C20", Offset = "0x62D5E20", VA = "0x1862D6C20", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x62C9510", Offset = "0x62C8710", VA = "0x1862C9510", Slot = "4")]
	public bool Equals(JJMEODHOBLE NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x62CA030", Offset = "0x62C9230", VA = "0x1862CA030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x62D6BB0", Offset = "0x62D5DB0", VA = "0x1862D6BB0")]
	public void CNHGDPKLDGO(bool JFBFINDMIJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct HCLBILLFMLM : IEquatable<HCLBILLFMLM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly MDCKLNCPLLP GCHHFDIEIFL;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public MDCKLNCPLLP AHIKPAJLFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MDCKLNCPLLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public MMHEEOMDOGK HGMDLMKNDIN
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MMHEEOMDOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private LFHNKPCBEHN GHGFAEOICJB
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x62C9FD0", Offset = "0x62C91D0", VA = "0x1862C9FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	private ELBMHFDBKDI GDBJCNNKDCD
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x62D09E0", Offset = "0x62CFBE0", VA = "0x1862D09E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private ObjectPolicyDataWrapper EANDFNOEPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x62D1720", Offset = "0x62D0920", VA = "0x1862D1720")]
		get
		{
			return default(ObjectPolicyDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private NavMeshGenerationDataWrapper LJBMDOOGLDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x62D1850", Offset = "0x62D0A50", VA = "0x1862D1850")]
		get
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool MPKKLDCHJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x62D1150", Offset = "0x62D0350", VA = "0x1862D1150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public bool EOOPCHFKFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x62D0970", Offset = "0x62CFB70", VA = "0x1862D0970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public bool IFNBNMFKENB
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x62D1990", Offset = "0x62D0B90", VA = "0x1862D1990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool DGCCKFCJNME
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x62D0B90", Offset = "0x62CFD90", VA = "0x1862D0B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public bool IMOGEFLJKPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x62D0C00", Offset = "0x62CFE00", VA = "0x1862D0C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public bool IAAICLBGJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x62D14E0", Offset = "0x62D06E0", VA = "0x1862D14E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool CGFONKMMMGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x62D0CD0", Offset = "0x62CFED0", VA = "0x1862D0CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public bool GOEAODGKAIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x62D17E0", Offset = "0x62D09E0", VA = "0x1862D17E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public bool DEOKPCFHAIF
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x62D1190", Offset = "0x62D0390", VA = "0x1862D1190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public bool JFIAGHIKJBB
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x62D13B0", Offset = "0x62D05B0", VA = "0x1862D13B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool BGLPGIGMAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x62D1340", Offset = "0x62D0540", VA = "0x1862D1340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public bool ANNBICACPFL
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x62D1200", Offset = "0x62D0400", VA = "0x1862D1200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public bool NNOIABCBOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x62D0B20", Offset = "0x62CFD20", VA = "0x1862D0B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public bool OABLFPHMBIC
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x62D16C0", Offset = "0x62D08C0", VA = "0x1862D16C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool CFMPHBNKPNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x62D1780", Offset = "0x62D0980", VA = "0x1862D1780")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x62D18B0", Offset = "0x62D0AB0", VA = "0x1862D18B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public OIOGKNHCGED GOJEOEHOBLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x62D0F10", Offset = "0x62D0110", VA = "0x1862D0F10")]
		get
		{
			return default(OIOGKNHCGED);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x62D1920", Offset = "0x62D0B20", VA = "0x1862D1920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public bool EIJPBKLDENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x62D0D40", Offset = "0x62CFF40", VA = "0x1862D0D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public NHMPFBPMHDB PIMMBIPDEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x62D12E0", Offset = "0x62D04E0", VA = "0x1862D12E0")]
		get
		{
			return default(NHMPFBPMHDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public bool HJOPDHEAJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x62D1080", Offset = "0x62D0280", VA = "0x1862D1080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 PFANBCIFBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x62D1420", Offset = "0x62D0620", VA = "0x1862D1420")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 HEOBOOKNHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x62D0A70", Offset = "0x62CFC70", VA = "0x1862D0A70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool NJKOMJFBEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x62D15C0", Offset = "0x62D07C0", VA = "0x1862D15C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
	public HCLBILLFMLM(MDCKLNCPLLP CGNAIHEOONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x62C9840", Offset = "0x62C8A40", VA = "0x1862C9840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x62D0F70", Offset = "0x62D0170", VA = "0x1862D0F70", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x62C9510", Offset = "0x62C8710", VA = "0x1862C9510", Slot = "4")]
	public bool Equals(HCLBILLFMLM NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x62CA030", Offset = "0x62C9230", VA = "0x1862CA030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x62D10E0", Offset = "0x62D02E0", VA = "0x1862D10E0")]
	public bool HCOHDDCLBFD(MLDEANCMBFE OMDDAPPBCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x62D1270", Offset = "0x62D0470", VA = "0x1862D1270")]
	public bool IBGMMPDNPHB(ENENJKLEDNA OMDDAPPBCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x62D1000", Offset = "0x62D0200", VA = "0x1862D1000")]
	public void GKKHGHPLNLJ(ENENJKLEDNA OMDDAPPBCGD, bool COENLOODJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x62D0C70", Offset = "0x62CFE70", VA = "0x1862D0C70")]
	public ENENJKLEDNA EGHOACMKIND()
	{
		return default(ENENJKLEDNA);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x62D1550", Offset = "0x62D0750", VA = "0x1862D1550")]
	public bool JKKHJMNABCJ(ENENJKLEDNA NICEPFIEJED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct ONKELNLIBIK : IEquatable<ONKELNLIBIK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly MDCKLNCPLLP GCHHFDIEIFL;

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public MDCKLNCPLLP AHIKPAJLFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MDCKLNCPLLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public MMHEEOMDOGK HGMDLMKNDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MMHEEOMDOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	private LFHNKPCBEHN GHGFAEOICJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x62C9FD0", Offset = "0x62C91D0", VA = "0x1862C9FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	private ELBMHFDBKDI GDBJCNNKDCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x62DAFC0", Offset = "0x62DA1C0", VA = "0x1862DAFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
	public ONKELNLIBIK(MDCKLNCPLLP CGNAIHEOONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x62C9840", Offset = "0x62C8A40", VA = "0x1862C9840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x62DB050", Offset = "0x62DA250", VA = "0x1862DB050", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x62C9510", Offset = "0x62C8710", VA = "0x1862C9510", Slot = "4")]
	public bool Equals(ONKELNLIBIK NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x62CA030", Offset = "0x62C9230", VA = "0x1862CA030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x62DB0E0", Offset = "0x62DA2E0", VA = "0x1862DB0E0")]
	public void ICBPLHLOKAI(bool NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x62DB170", Offset = "0x62DA370", VA = "0x1862DB170")]
	public void KLIBBJDOPDI(bool NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x2A4E5B0", Offset = "0x2A4D7B0", VA = "0x182A4E5B0")]
	public T LGPFLDPCFEF<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct JJNLOFNOCLC : IEquatable<JJNLOFNOCLC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly MDCKLNCPLLP GCHHFDIEIFL;

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public MDCKLNCPLLP AHIKPAJLFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MDCKLNCPLLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public MMHEEOMDOGK HGMDLMKNDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MMHEEOMDOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	private LFHNKPCBEHN GHGFAEOICJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x62C9FD0", Offset = "0x62C91D0", VA = "0x1862C9FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	private ELBMHFDBKDI GDBJCNNKDCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x62D6CB0", Offset = "0x62D5EB0", VA = "0x1862D6CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private HKPMFOHDGBB AANPEOAENCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x62D6FB0", Offset = "0x62D61B0", VA = "0x1862D6FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private FDGHPOGDEKP NDENCNMNDDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x62D7080", Offset = "0x62D6280", VA = "0x1862D7080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool PCIAMOAALBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x62D7460", Offset = "0x62D6660", VA = "0x1862D7460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool NAIEFIPBEME
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x62D76F0", Offset = "0x62D68F0", VA = "0x1862D76F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool LMCFLGPCFJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x62D74F0", Offset = "0x62D66F0", VA = "0x1862D74F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool EPBIAFIPGMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x62D7790", Offset = "0x62D6990", VA = "0x1862D7790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool AHGAIIPAJBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x62D6D40", Offset = "0x62D5F40", VA = "0x1862D6D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool IMDGPPGHNOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x62D75C0", Offset = "0x62D67C0", VA = "0x1862D75C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool KIDABKNKBBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x62D70E0", Offset = "0x62D62E0", VA = "0x1862D70E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool CPPNNHEPNNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x62D72F0", Offset = "0x62D64F0", VA = "0x1862D72F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
	public JJNLOFNOCLC(MDCKLNCPLLP CGNAIHEOONH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x62CA1A0", Offset = "0x62C93A0", VA = "0x1862CA1A0")]
	public static bool LOOIAEAGNBK(JJNLOFNOCLC NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x62C9840", Offset = "0x62C8A40", VA = "0x1862C9840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x62D6E80", Offset = "0x62D6080", VA = "0x1862D6E80", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x62C9510", Offset = "0x62C8710", VA = "0x1862C9510", Slot = "4")]
	public bool Equals(JJNLOFNOCLC NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x62CA030", Offset = "0x62C9230", VA = "0x1862CA030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x62D7010", Offset = "0x62D6210", VA = "0x1862D7010")]
	public bool HNFAFNCEINK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x62D7520", Offset = "0x62D6720", VA = "0x1862D7520")]
	public MMHEEOMDOGK LNCHCJOKOAL(MMHEEOMDOGK IOCBLPNBBJM)
	{
		return default(MMHEEOMDOGK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x62D6D70", Offset = "0x62D5F70", VA = "0x1862D6D70")]
	public MDCKLNCPLLP EPHJMAPLDMJ()
	{
		return default(MDCKLNCPLLP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x62D7650", Offset = "0x62D6850", VA = "0x1862D7650")]
	public bool NBLMKJAFGKJ(MDCKLNCPLLP EOHMBFIJAKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x62D6F10", Offset = "0x62D6110", VA = "0x1862D6F10")]
	public bool FGEFIOHDLCL(MDCKLNCPLLP AGBFMBMONKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x62D7860", Offset = "0x62D6A60", VA = "0x1862D7860")]
	public bool PCGFFJKGFLF(MDCKLNCPLLP IOCBLPNBBJM, [Out] MDCKLNCPLLP EOHMBFIJAKL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct EBFGHMDKGAI : IEquatable<EBFGHMDKGAI>
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly EBFGHMDKGAI PHIOOJJLEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly MDCKLNCPLLP GCHHFDIEIFL;

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public MDCKLNCPLLP AHIKPAJLFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MDCKLNCPLLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public MMHEEOMDOGK HGMDLMKNDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MMHEEOMDOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public HKECDLCMNBC BHIBJBFFJDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(HKECDLCMNBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public LCLEMNDIDBM EGEOJFLJNFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(LCLEMNDIDBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private ShapeTypeDataWrapper HNHCDPJGIFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x62CF9D0", Offset = "0x62CEBD0", VA = "0x1862CF9D0")]
		get
		{
			return default(ShapeTypeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public StandardRenderableVisualDataWrapper NFLKABGCLIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x62CF710", Offset = "0x62CE910", VA = "0x1862CF710")]
		get
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public PhysicsMaterialDataWrapper OGHEGNJKBCL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x62CF8F0", Offset = "0x62CEAF0", VA = "0x1862CF8F0")]
		get
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public ShapeConfigDataWrapper MDHEOOMEOAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x62CF410", Offset = "0x62CE610", VA = "0x1862CF410")]
		get
		{
			return default(ShapeConfigDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public EHKIBNJBFBB HJNKFKPGNBA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x62CFA30", Offset = "0x62CEC30", VA = "0x1862CFA30")]
		get
		{
			return default(EHKIBNJBFBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public PGGNMAEFFLG MKJPAJDIBPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x62CFB60", Offset = "0x62CED60", VA = "0x1862CFB60")]
		get
		{
			return default(PGGNMAEFFLG);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x62CF7E0", Offset = "0x62CE9E0", VA = "0x1862CF7E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public FKDILDJBONM OHGAACDKLGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x62CFAA0", Offset = "0x62CECA0", VA = "0x1862CFAA0")]
		get
		{
			return default(FKDILDJBONM);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x62CF3A0", Offset = "0x62CE5A0", VA = "0x1862CF3A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public float NIOPHMJOMJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x62CF580", Offset = "0x62CE780", VA = "0x1862CF580")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x62CF770", Offset = "0x62CE970", VA = "0x1862CF770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public Vector3 AGMPIGBMCAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x62CF470", Offset = "0x62CE670", VA = "0x1862CF470")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x62CF5E0", Offset = "0x62CE7E0", VA = "0x1862CF5E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public float FIKCOFHFCGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x62CFBC0", Offset = "0x62CEDC0", VA = "0x1862CFBC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public MKMLIFLADIO EEDNKFFKJHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x62CFB00", Offset = "0x62CED00", VA = "0x1862CFB00")]
		get
		{
			return default(MKMLIFLADIO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x62CF510", Offset = "0x62CE710", VA = "0x1862CF510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
	public EBFGHMDKGAI(MDCKLNCPLLP CGNAIHEOONH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x62CA1A0", Offset = "0x62C93A0", VA = "0x1862CA1A0")]
	public static bool LOOIAEAGNBK(EBFGHMDKGAI NICEPFIEJED)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x62CF8D0", Offset = "0x62CEAD0", VA = "0x1862CF8D0")]
	public static bool KEIKIALHENC(EBFGHMDKGAI JPEEHDCLFEK, EBFGHMDKGAI HGMCBKHHGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x62C9840", Offset = "0x62C8A40", VA = "0x1862C9840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x62CF680", Offset = "0x62CE880", VA = "0x1862CF680", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x62C9510", Offset = "0x62C8710", VA = "0x1862C9510", Slot = "4")]
	public bool Equals(EBFGHMDKGAI NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x62CA030", Offset = "0x62C9230", VA = "0x1862CA030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x62CF850", Offset = "0x62CEA50", VA = "0x1862CF850")]
	public AMFLPNHBEOL JMHEHCANDKM()
	{
		return default(AMFLPNHBEOL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x62CF950", Offset = "0x62CEB50", VA = "0x1862CF950")]
	public DODCEHKEJEF MDAEEFGAPJP()
	{
		return default(DODCEHKEJEF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct AMFLPNHBEOL : IEquatable<AMFLPNHBEOL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly MDCKLNCPLLP GCHHFDIEIFL;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public MDCKLNCPLLP AHIKPAJLFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MDCKLNCPLLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public MMHEEOMDOGK HGMDLMKNDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MMHEEOMDOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public EBFGHMDKGAI HBFHPLIPOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(EBFGHMDKGAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private PrimitiveShapeDataWrapper DFIJAJALKAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x62CA050", Offset = "0x62C9250", VA = "0x1862CA050")]
		get
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public OONAHILDADH HJHIHIAFLOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x62CA140", Offset = "0x62C9340", VA = "0x1862CA140")]
		get
		{
			return default(OONAHILDADH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
	public AMFLPNHBEOL(MDCKLNCPLLP CGNAIHEOONH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x62CA1A0", Offset = "0x62C93A0", VA = "0x1862CA1A0")]
	public static bool LOOIAEAGNBK(AMFLPNHBEOL NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x62C9840", Offset = "0x62C8A40", VA = "0x1862C9840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x62CA0B0", Offset = "0x62C92B0", VA = "0x1862CA0B0", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x62C9510", Offset = "0x62C8710", VA = "0x1862C9510", Slot = "4")]
	public bool Equals(AMFLPNHBEOL NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x62CA030", Offset = "0x62C9230", VA = "0x1862CA030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[DefaultMember("Item")]
public readonly struct DODCEHKEJEF : IEquatable<DODCEHKEJEF>
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly DODCEHKEJEF PHIOOJJLEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly MDCKLNCPLLP GCHHFDIEIFL;

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public MDCKLNCPLLP AHIKPAJLFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MDCKLNCPLLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public MMHEEOMDOGK HGMDLMKNDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MMHEEOMDOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public HKECDLCMNBC BHIBJBFFJDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(HKECDLCMNBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private LFHNKPCBEHN GHGFAEOICJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x62C9FD0", Offset = "0x62C91D0", VA = "0x1862C9FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private ELBMHFDBKDI GDBJCNNKDCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x62CE5F0", Offset = "0x62CD7F0", VA = "0x1862CE5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	private KDPNAEBNBHP NEGANFAOGFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x62CEB10", Offset = "0x62CDD10", VA = "0x1862CEB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public EBFGHMDKGAI HBFHPLIPOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(EBFGHMDKGAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public KJGIJINEINK OKKHGFLBCCL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x62CE720", Offset = "0x62CD920", VA = "0x1862CE720")]
		get
		{
			return default(KJGIJINEINK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x62CE850", Offset = "0x62CDA50", VA = "0x1862CE850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public IEnumerable<MPDPHEABMJP> POMOJPLHCPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x62CE3F0", Offset = "0x62CD5F0", VA = "0x1862CE3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public MPDPHEABMJP HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x62CEA00", Offset = "0x62CDC00", VA = "0x1862CEA00")]
		get
		{
			return default(MPDPHEABMJP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public int PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x62CEDA0", Offset = "0x62CDFA0", VA = "0x1862CEDA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
	public DODCEHKEJEF(MDCKLNCPLLP CGNAIHEOONH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x62CA1A0", Offset = "0x62C93A0", VA = "0x1862CA1A0")]
	public static bool LOOIAEAGNBK(DODCEHKEJEF NICEPFIEJED)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x62CA670", Offset = "0x62C9870", VA = "0x1862CA670")]
	public static bool AIPCENMEJFE(DODCEHKEJEF JPEEHDCLFEK, DODCEHKEJEF HGMCBKHHGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x62C9840", Offset = "0x62C8A40", VA = "0x1862C9840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x62CE970", Offset = "0x62CDB70", VA = "0x1862CE970", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x62C9510", Offset = "0x62C8710", VA = "0x1862C9510", Slot = "4")]
	public bool Equals(DODCEHKEJEF NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x62CA030", Offset = "0x62C9230", VA = "0x1862CA030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x62CEEC0", Offset = "0x62CE0C0", VA = "0x1862CEEC0")]
	public MPDPHEABMJP PHDFONJIJLP(float3? DHMMMGDKPCG, [Optional] quaternion? HBCECKEGCGH, [Optional] Vector3? EKCHLHLGOBO)
	{
		return default(MPDPHEABMJP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x62CEB70", Offset = "0x62CDD70", VA = "0x1862CEB70")]
	public MPDPHEABMJP JALAHJILOMO(int HMFNCGHECPG, float3? DHMMMGDKPCG, [Optional] quaternion? HBCECKEGCGH, [Optional] Vector3? EKCHLHLGOBO)
	{
		return default(MPDPHEABMJP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x62CE680", Offset = "0x62CD880", VA = "0x1862CE680")]
	public void BJKKLHHIGJO(int HMFNCGHECPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x62CEE30", Offset = "0x62CE030", VA = "0x1862CEE30")]
	public void NDGKPACNNFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct MPDPHEABMJP : IEquatable<MPDPHEABMJP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly MDCKLNCPLLP GCHHFDIEIFL;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public MDCKLNCPLLP AHIKPAJLFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MDCKLNCPLLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public MMHEEOMDOGK HGMDLMKNDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MMHEEOMDOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public DODCEHKEJEF JEPAAMNIEGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x62DA8B0", Offset = "0x62D9AB0", VA = "0x1862DA8B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public float3 APOIDAPMEHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x62DADC0", Offset = "0x62D9FC0", VA = "0x1862DADC0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x62DAC40", Offset = "0x62D9E40", VA = "0x1862DAC40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public quaternion CDOBGHCOBEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x62DACC0", Offset = "0x62D9EC0", VA = "0x1862DACC0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x62DA840", Offset = "0x62D9A40", VA = "0x1862DA840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public float3 GLMGHAJOMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x62DAD40", Offset = "0x62D9F40", VA = "0x1862DAD40")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x62DAA70", Offset = "0x62D9C70", VA = "0x1862DAA70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public OICAAOIBBBA IGHHDFEIIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x62DA940", Offset = "0x62D9B40", VA = "0x1862DA940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private SplinePointParentDataWrapper EODHPBCGIOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x62DAB80", Offset = "0x62D9D80", VA = "0x1862DAB80")]
		get
		{
			return default(SplinePointParentDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private SplinePointPositionDataWrapper LDOBNHEKNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x62DA9B0", Offset = "0x62D9BB0", VA = "0x1862DA9B0")]
		get
		{
			return default(SplinePointPositionDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private SplinePointRotationDataWrapper CHCAJIKNEEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x62DAA10", Offset = "0x62D9C10", VA = "0x1862DAA10")]
		get
		{
			return default(SplinePointRotationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private SplinePointScaleDataWrapper CKAHFOPOBHE
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x62DAE40", Offset = "0x62DA040", VA = "0x1862DAE40")]
		get
		{
			return default(SplinePointScaleDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	private SplinePointOrderDataWrapper PJMKOGJHGEP
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x62DABE0", Offset = "0x62D9DE0", VA = "0x1862DABE0")]
		get
		{
			return default(SplinePointOrderDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
	public MPDPHEABMJP(MDCKLNCPLLP CGNAIHEOONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x62C9840", Offset = "0x62C8A40", VA = "0x1862C9840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x62DAAF0", Offset = "0x62D9CF0", VA = "0x1862DAAF0", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x62C9510", Offset = "0x62C8710", VA = "0x1862C9510", Slot = "4")]
	public bool Equals(MPDPHEABMJP NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x62CA030", Offset = "0x62C9230", VA = "0x1862CA030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x62DA8B0", Offset = "0x62D9AB0", VA = "0x1862DA8B0")]
	public void OOONIKFPIAC(DODCEHKEJEF NICEPFIEJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct AAIKHDJKBFM : IEquatable<AAIKHDJKBFM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly MDCKLNCPLLP GCHHFDIEIFL;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public MDCKLNCPLLP AHIKPAJLFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MDCKLNCPLLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public MMHEEOMDOGK HGMDLMKNDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MMHEEOMDOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	private LFHNKPCBEHN GHGFAEOICJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x62C9FD0", Offset = "0x62C91D0", VA = "0x1862C9FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private ELBMHFDBKDI GDBJCNNKDCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x62C9350", Offset = "0x62C8550", VA = "0x1862C9350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private FEHFHAOFPPA IFKCMGMMIJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x62C9B80", Offset = "0x62C8D80", VA = "0x1862C9B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private ToolCleanupSettingsDataWrapper GDMCNCAPAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x62C9C50", Offset = "0x62C8E50", VA = "0x1862C9C50")]
		get
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool PINDNOABKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x62C93E0", Offset = "0x62C85E0", VA = "0x1862C93E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x62C9BE0", Offset = "0x62C8DE0", VA = "0x1862C9BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool DBFOMAGPBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x62C94B0", Offset = "0x62C86B0", VA = "0x1862C94B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x62C9B10", Offset = "0x62C8D10", VA = "0x1862C9B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public float GCIEOODGKBB
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x62C9870", Offset = "0x62C8A70", VA = "0x1862C9870")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x62C9440", Offset = "0x62C8640", VA = "0x1862C9440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public bool NCGOLEPDJDL
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x62C97A0", Offset = "0x62C89A0", VA = "0x1862C97A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
	public AAIKHDJKBFM(MDCKLNCPLLP CGNAIHEOONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x62C9840", Offset = "0x62C8A40", VA = "0x1862C9840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x62C9520", Offset = "0x62C8720", VA = "0x1862C9520", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x62C9510", Offset = "0x62C8710", VA = "0x1862C9510", Slot = "4")]
	public bool Equals(AAIKHDJKBFM NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x62CA030", Offset = "0x62C9230", VA = "0x1862CA030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x62C95B0", Offset = "0x62C87B0", VA = "0x1862C95B0")]
	public void FCCNDHPHLPD(int NMBNNEFKAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x62C98D0", Offset = "0x62C8AD0", VA = "0x1862C98D0")]
	public bool HMMOLGBGEDJ([Out] int NMBNNEFKAJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x62C9E00", Offset = "0x62C9000", VA = "0x1862C9E00")]
	public void LHKGLEJBGOE(bool NCAAMHCMMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x62C9650", Offset = "0x62C8850", VA = "0x1862C9650")]
	public void FCDKHGBDCGM(float GMLPINIHLII, float HBACAFFAMOA, float LAHFOKMEGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x62C9CB0", Offset = "0x62C8EB0", VA = "0x1862C9CB0")]
	public void LDJFLPLAFLN(float3 COEKCEIANFL, quaternion PGNLIBOCGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x62C9EA0", Offset = "0x62C90A0", VA = "0x1862C9EA0")]
	public bool MJNILCGJPPP([Out] float3 COEKCEIANFL, [Out] quaternion PGNLIBOCGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x62C99E0", Offset = "0x62C8BE0", VA = "0x1862C99E0")]
	public bool IJBGPFDJIHO([Out] float GNMGCBINKLP, [Out] float KGLOJNMOKAH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct HKECDLCMNBC : IEquatable<HKECDLCMNBC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly MDCKLNCPLLP GCHHFDIEIFL;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public MMHEEOMDOGK HGMDLMKNDIN
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MMHEEOMDOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public LCLEMNDIDBM EGEOJFLJNFD
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(LCLEMNDIDBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private LFHNKPCBEHN GHGFAEOICJB
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x62C9FD0", Offset = "0x62C91D0", VA = "0x1862C9FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	private GDEPNCNFLGE AHHEMKEKMDO
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x62D2B70", Offset = "0x62D1D70", VA = "0x1862D2B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool HNKEGFEBNCC
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x62D4180", Offset = "0x62D3380", VA = "0x1862D4180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 APOIDAPMEHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x62D4AC0", Offset = "0x62D3CC0", VA = "0x1862D4AC0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x62D41C0", Offset = "0x62D33C0", VA = "0x1862D41C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Quaternion CDOBGHCOBEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x62D4290", Offset = "0x62D3490", VA = "0x1862D4290")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x62D2940", Offset = "0x62D1B40", VA = "0x1862D2940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 GBDENECPBOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x62D2EE0", Offset = "0x62D20E0", VA = "0x1862D2EE0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x62D3840", Offset = "0x62D2A40", VA = "0x1862D3840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Quaternion HEEFMLJPIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x62D3C40", Offset = "0x62D2E40", VA = "0x1862D3C40")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x62D3120", Offset = "0x62D2320", VA = "0x1862D3120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public float FDAEOKKDIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x62D3D90", Offset = "0x62D2F90", VA = "0x1862D3D90")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x62D3A00", Offset = "0x62D2C00", VA = "0x1862D3A00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public float AMNHIPPOEGD
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x62D3AB0", Offset = "0x62D2CB0", VA = "0x1862D3AB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public Vector3 GLMGHAJOMJA
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x62D44B0", Offset = "0x62D36B0", VA = "0x1862D44B0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x62D3520", Offset = "0x62D2720", VA = "0x1862D3520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public Vector3 MCGMGDAMDKB
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x62D3910", Offset = "0x62D2B10", VA = "0x1862D3910")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public Matrix4x4 MJJLEPLJKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x62D45A0", Offset = "0x62D37A0", VA = "0x1862D45A0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
	public HKECDLCMNBC(MDCKLNCPLLP CGNAIHEOONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x62C9840", Offset = "0x62C8A40", VA = "0x1862C9840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x62D35F0", Offset = "0x62D27F0", VA = "0x1862D35F0", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x62C9510", Offset = "0x62C8710", VA = "0x1862C9510", Slot = "4")]
	public bool Equals(HKECDLCMNBC NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x62CA030", Offset = "0x62C9230", VA = "0x1862CA030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x62D4130", Offset = "0x62D3330", VA = "0x1862D4130")]
	public NMHECPHFLPD KPADAOEIDCP()
	{
		return default(NMHECPHFLPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x62D3E30", Offset = "0x62D3030", VA = "0x1862D3E30")]
	public void KJHEFOHANPK([Out] Matrix4x4 JGFCBJHFPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x62D4760", Offset = "0x62D3960", VA = "0x1862D4760")]
	public void NMGMFLMJAPI([Out] Vector3 GHMEDCCDJNA, [Out] Quaternion BAFAPAAJHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x62D2A10", Offset = "0x62D1C10", VA = "0x1862D2A10")]
	public void ALEIPLIBNLG([Out] RigidTransform BIGANLADIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x62D2DE0", Offset = "0x62D1FE0", VA = "0x1862D2DE0")]
	public UniformTRS BHGAHGLMAGD()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x62D2D20", Offset = "0x62D1F20", VA = "0x1862D2D20")]
	public void BHGAHGLMAGD([Out] UniformTRS OABAOAEABAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x62D3F50", Offset = "0x62D3150", VA = "0x1862D3F50")]
	public UniformTRS KNMJEKKOBBD()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x62D3F80", Offset = "0x62D3180", VA = "0x1862D3F80")]
	public void KNMJEKKOBBD([Out] UniformTRS BIGANLADIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x62D4040", Offset = "0x62D3240", VA = "0x1862D4040")]
	public Vector3 KOOAOKHOGKP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x62D43E0", Offset = "0x62D35E0", VA = "0x1862D43E0")]
	public void LGPOCLAELFE([In] Vector3 NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x62D3B50", Offset = "0x62D2D50", VA = "0x1862D3B50")]
	public Vector3 IKFKKFFIAOE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x62D48A0", Offset = "0x62D3AA0", VA = "0x1862D48A0")]
	public void NPLDOGBMGKM([In] Vector3 NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x62D4970", Offset = "0x62D3B70", VA = "0x1862D4970")]
	public Quaternion ODGAHOHDEDL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x62D2870", Offset = "0x62D1A70", VA = "0x1862D2870")]
	public void ACFFKPKOHOL([In] Quaternion NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x62D2FD0", Offset = "0x62D21D0", VA = "0x1862D2FD0")]
	public Quaternion BPJLDNCPOGL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x62D3380", Offset = "0x62D2580", VA = "0x1862D3380")]
	public void DNJIDEMOCDP([In] Quaternion NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x62D32E0", Offset = "0x62D24E0", VA = "0x1862D32E0")]
	public float DNHBHJEFDAL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x62D46B0", Offset = "0x62D38B0", VA = "0x1862D46B0")]
	public void MKIDLIGJEFK(float NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x62D4BB0", Offset = "0x62D3DB0", VA = "0x1862D4BB0")]
	public float PBOOBCEJLIJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x62D2AC0", Offset = "0x62D1CC0", VA = "0x1862D2AC0")]
	public void BCMOPDFOPMN(float NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x62D3680", Offset = "0x62D2880", VA = "0x1862D3680")]
	public void FBKPAIBIPHE([In] Vector3 NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x62D31F0", Offset = "0x62D23F0", VA = "0x1862D31F0")]
	public Vector3 DGKOAEPGNEA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x62D3450", Offset = "0x62D2650", VA = "0x1862D3450")]
	public void EEPGOGOBKPP([In] Vector3 NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x62D3750", Offset = "0x62D2950", VA = "0x1862D3750")]
	public Vector3 FDFGHKPPKEJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x62D2E10", Offset = "0x62D2010", VA = "0x1862D2E10")]
	public void BHKJGDOLILI([In] Vector3 NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x62D2C30", Offset = "0x62D1E30", VA = "0x1862D2C30")]
	public Vector3 BFLHBIPPJEE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x62D45E0", Offset = "0x62D37E0", VA = "0x1862D45E0")]
	public void MBLMAFCAGGN([In] Vector3 NICEPFIEJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct BAGMNPAANOG : IEquatable<BAGMNPAANOG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly MDCKLNCPLLP GCHHFDIEIFL;

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public MDCKLNCPLLP AHIKPAJLFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MDCKLNCPLLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public MMHEEOMDOGK HGMDLMKNDIN
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		get
		{
			return default(MMHEEOMDOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public int[] ILJNEJBOPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x62CA420", Offset = "0x62C9620", VA = "0x1862CA420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool MPDFHCABBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x62CA5A0", Offset = "0x62C97A0", VA = "0x1862CA5A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x62CA600", Offset = "0x62C9800", VA = "0x1862CA600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
	public BAGMNPAANOG(MDCKLNCPLLP CGNAIHEOONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x62C9840", Offset = "0x62C8A40", VA = "0x1862C9840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x62CA510", Offset = "0x62C9710", VA = "0x1862CA510", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x62C9510", Offset = "0x62C8710", VA = "0x1862C9510", Slot = "4")]
	public bool Equals(BAGMNPAANOG NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x62CA030", Offset = "0x62C9230", VA = "0x1862CA030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class KEDAMMMEHNN
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private struct COBFEPPDKLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Guid IKOKEKHMFKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public KKKHPMAOIJF JEPHFIKDAPC;
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct KKKHPMAOIJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int NICEPFIEJED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int JHKGHKNIHEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int MBFJIGPHJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int OHNDEBDIFJH;

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x62D81D0", Offset = "0x62D73D0", VA = "0x1862D81D0")]
		public bool DOLEHMDAEIG([Out] BEHBFJOGLOH IGMILLALAMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x62D8250", Offset = "0x62D7450", VA = "0x1862D8250")]
		public KKKHPMAOIJF(BEHBFJOGLOH IGMILLALAMN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x62D7990", Offset = "0x62D6B90", VA = "0x1862D7990")]
	public static Guid IOELBNKIFMI(this BEHBFJOGLOH IGMILLALAMN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x62D7970", Offset = "0x62D6B70", VA = "0x1862D7970")]
	public static bool BEEOFMABJME(this Guid IKOKEKHMFKH, [Out] BEHBFJOGLOH IGMILLALAMN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal static class IJEPPBEKEEE
{
	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x62D5AF0", Offset = "0x62D4CF0", VA = "0x1862D5AF0")]
	public static ELBMHFDBKDI GDBJCNNKDCD(this MDCKLNCPLLP JNIKIHKLGAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x62D5A20", Offset = "0x62D4C20", VA = "0x1862D5A20")]
	public static KHINBPNOGDJ ECICAOENAAA(this MDCKLNCPLLP JNIKIHKLGAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x62D5B80", Offset = "0x62D4D80", VA = "0x1862D5B80")]
	public static EntityManager OGMFHBAHCFL(this MDCKLNCPLLP JNIKIHKLGAD)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2928330", Offset = "0x2927530", VA = "0x182928330")]
	public static T MLGPLDODMMB<T>(this MDCKLNCPLLP JNIKIHKLGAD) where T : struct, HDJOPFOEMAB
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x2927F10", Offset = "0x2927110", VA = "0x182927F10")]
	public static bool IPAEGOOFLPJ<T>(this MDCKLNCPLLP JNIKIHKLGAD) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x2928280", Offset = "0x2927480", VA = "0x182928280")]
	public static bool KOGBCGEDBHN<T>(this MDCKLNCPLLP JNIKIHKLGAD) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface AFMPDJPGEFE
{
	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HJJKMBOAFFJ(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IFFFJGKLJJA(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LDFFGEIMPAC(MDCKLNCPLLP CGNAIHEOONH, [Out] Guid NMEFCALOOLI);

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid CEIBAJMEFJE(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LGPLLFKNPJH(MDCKLNCPLLP CGNAIHEOONH, Guid NMEFCALOOLI);

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PNMFBNOFHIA(MDCKLNCPLLP CGNAIHEOONH, [Out] Guid EPGOCEDJKAG);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid MFMKEKJOMEF(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EKBJNAIONOF(MDCKLNCPLLP CGNAIHEOONH, Guid EPGOCEDJKAG);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MGOLJJNPJDL(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task CMMFHIEDJLJ(MDCKLNCPLLP DEGINJHPGFA, MDCKLNCPLLP BHNONFFBKHO);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[CNJGMKKABCG(FGONPGLMBDD.LoadInstance)]
public interface CNJAOOGGIIK
{
	[Cpp2IlInjected.Token(Token = "0x17000161")]
	Guid BENDDHGOKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HFCODJFLIIM(NativeList<Guid> GAGJEDMNBKL, NativeList<Guid> OPGEJLECNEF, NativeList<FixedString64Bytes> IFCLKNGACCA);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface OKCLBCCMOAE
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PHAKKOFMNHD(List<MDCKLNCPLLP> KFJAAJFKGJC);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BMDCFBJLEGI(MDCKLNCPLLP PCDBKMHIJDL);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HMLKFCMMNJD(MDCKLNCPLLP PCDBKMHIJDL);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HDKPPFOCELJ(MDCKLNCPLLP PCDBKMHIJDL);

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int JFGGKKBGBPN(MDCKLNCPLLP PCDBKMHIJDL);

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MDCGMEMHEGP(MDCKLNCPLLP PCDBKMHIJDL, int BMIJGDHAHBI);

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MDCKLNCPLLP NNMIBOPJIEI(MDCKLNCPLLP KGJMGCOEHJJ);

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DBMHLEELDCE(MDCKLNCPLLP KGJMGCOEHJJ, MDCKLNCPLLP PDNMIBHFCLI);

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HOKDGFDLNCA(MDCKLNCPLLP KGJMGCOEHJJ);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int LNKGIDPCKDB(MDCKLNCPLLP KGJMGCOEHJJ);

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HHCOLBANMCM(MDCKLNCPLLP KGJMGCOEHJJ, int JCJIBGPFPGL);

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JBNAOFFMHKF(MDCKLNCPLLP GCHHFDIEIFL);

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NHKIDBDAFHF(MDCKLNCPLLP CGNAIHEOONH, bool HHLLHOMCPGP);

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HLJNLIAMAEE(MDCKLNCPLLP[] AIHKOKEKKPF, bool HHLLHOMCPGP);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface EIFBEDIBPOB
{
	[Cpp2IlInjected.Token(Token = "0x17000162")]
	IReadOnlyCollection<BMDPJHFGELP> JMDKMCNOLOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IMGPDCGBMDP(int OLIJILKFIJO, [Out] BMDPJHFGELP EOAKDGCPOJO);

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BMDPJHFGELP FJEBIFENIGC(Type FLPJMDMACMC);
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class KOGBBOBAIHB
{
	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x297E7A0", Offset = "0x297D9A0", VA = "0x18297E7A0")]
	public static T HKOAFCEMFKN<T>(this EIFBEDIBPOB DOPPAKGEOPE, Entity NFFCGLFHPNG) where T : struct, HDJOPFOEMAB
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x297DB40", Offset = "0x297CD40", VA = "0x18297DB40")]
	public static BMDPJHFGELP FJEBIFENIGC<T>(this EIFBEDIBPOB DOPPAKGEOPE) where T : struct, HDJOPFOEMAB
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface MBKCKJBNOKE
{
	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BEHBFJOGLOH[] KMCDACLHEKA(string IKEFBMMMAJB, MMHEEOMDOGK FIOCKHMPFNF, bool OFFDNHIIDJJ = false);

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LPKEMFHOHGH(string KNKPACLBJAJ, BEHBFJOGLOH[] PNMDPJJJHMB);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[CNJGMKKABCG(FGONPGLMBDD.LoadInstance)]
public interface GCOOEKKAODH
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<MDCKLNCPLLP, MDCKLNCPLLP> FBNEHPMOEEP;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<MDCKLNCPLLP, MDCKLNCPLLP> KAJJMPLOKED;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<MDCKLNCPLLP, MDCKLNCPLLP, MDCKLNCPLLP> MMPHHAGLMOI;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<MDCKLNCPLLP> AIKCBBJLJLK;

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KKKDMAKDJMM(MDCKLNCPLLP CGNAIHEOONH, MDCKLNCPLLP LCIFLCGALAH);

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MDCKLNCPLLP GJLPABMDACO(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<MDCKLNCPLLP> DDICFBEJCAL(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(Slot = "11")]
	MDCKLNCPLLP IEMDIKBBFBN(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NKMMIIPCOAL(MDCKLNCPLLP CGNAIHEOONH, Vector3 PHGHGOEODKN, Quaternion CFOBNEEFCOP);

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LKFIJEPGHJD(MDCKLNCPLLP CGNAIHEOONH, float AEDNJMFCMKJ);

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool LEAIOABIOJK(MDCKLNCPLLP CGNAIHEOONH, [Out] RigidTransform MMCMKPINFKK);

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool CDEHGBCNDNI(MDCKLNCPLLP CGNAIHEOONH, [Out] float BJPGODCCJOG);

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 PFBECJELOJH(GPEKCHACHHJ FGCNLMAPKLM);

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion INGAFOIBKMN(GPEKCHACHHJ FGCNLMAPKLM);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class AINKCKCPHLJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[CNJGMKKABCG(FGONPGLMBDD.LoadInstance)]
public interface GCAHBDICCPK
{
	[Cpp2IlInjected.Token(Token = "0x17000163")]
	object DBNFBOOOLKF
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBKNMLIJKNH(BFODOFFDAJG AIHKOKEKKPF);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public enum HMADIIIPOND
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class DAOLPDJBGNN
{
	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0xC17C40", Offset = "0xC16E40", VA = "0x180C17C40")]
	public static bool DEDLBMAFFHI(this HMADIIIPOND OAODOPKGJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0xC17C20", Offset = "0xC16E20", VA = "0x180C17C20")]
	public static bool NHCAIGHOKHM(this HMADIIIPOND OAODOPKGJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x2371380", Offset = "0x2370580", VA = "0x182371380")]
	public static bool EIBGNHJDKHD(this HMADIIIPOND OAODOPKGJBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface ECOGKIPDPMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000164")]
	HMADIIIPOND KJNGCGCMKCB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	HMADIIIPOND FIHLDGBNKAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	HMADIIIPOND GJIFFJEBAAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	HMADIIIPOND GMJOKEELPME
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	HMADIIIPOND PEFANGPEHHH
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	HMADIIIPOND NIDDILBNIII
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	HMADIIIPOND LFICFFCBEAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	HMADIIIPOND BKBJLNDEOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	HMADIIIPOND BLDDDPNLENP
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	HMADIIIPOND AELIECJJEJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	HMADIIIPOND EGFBHLGCOPC
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	HMADIIIPOND BFKKGECFABG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	HMADIIIPOND LOGPKJCPEBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface HFHCPMEEFCA
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<GHMDAAEBJMA> DECIBNNFKCI;

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MDCKLNCPLLP FCCKNACKBOP(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BENNEKOMNHO(List<MDCKLNCPLLP> KFJAAJFKGJC);

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OICAAOIBBBA HGBGODJIIFD(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OICAAOIBBBA GAALBAFDDKA(MDCKLNCPLLP BHNONFFBKHO, MDCKLNCPLLP LHCBCAKMNGO, bool FNMNHGOJKGN, MDCKLNCPLLP IOCBLPNBBJM);

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MDCKLNCPLLP ENFGANHBDNA(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool CFLHPBMALHN(MDCKLNCPLLP CGNAIHEOONH, MDCKLNCPLLP BHNONFFBKHO, bool OFFENFFHFHL);

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LAPFOCIFPOH(MDCKLNCPLLP CGNAIHEOONH, MDCKLNCPLLP BHNONFFBKHO);

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool MJKEGAMCHPD(MDCKLNCPLLP HBNCLCPLNBN, MDCKLNCPLLP IFOGGGIGHOG);

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int PPHLDGBPLKK(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BFODOFFDAJG KHFOJJIIKCH(MDCKLNCPLLP GCHHFDIEIFL);

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NativeArray<MDCKLNCPLLP> FKIGIOKGPMP(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool BLGGOJLIPKB(MDCKLNCPLLP CGNAIHEOONH, MDCKLNCPLLP JDFNHFCFMAC);

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<MDCKLNCPLLP> DPMJDCLCJFJ(MDCKLNCPLLP CGNAIHEOONH, bool FKBHHEHBNBH = false);

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool KLNMCLIFBCH(MDCKLNCPLLP CGNAIHEOONH, MDCKLNCPLLP PBHEBDNHMAN);

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(Slot = "16")]
	MDCKLNCPLLP DMMFDKDFHEO(MDCKLNCPLLP IOCBLPNBBJM, MDCKLNCPLLP BEHLFKHHLHF);

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool BEDIGEOEPMA(MDCKLNCPLLP IOCBLPNBBJM, MDCKLNCPLLP BEHLFKHHLHF, [Out] MDCKLNCPLLP OLOMOFKKDHI);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public static class PDBIBCGHNFG
{
	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x62DB290", Offset = "0x62DA490", VA = "0x1862DB290")]
	public static List<MDCKLNCPLLP> BENNEKOMNHO(this HFHCPMEEFCA JBNJEEOOCEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x62DB3A0", Offset = "0x62DA5A0", VA = "0x1862DB3A0")]
	public static bool MEHFEOAECPP(this HFHCPMEEFCA JBNJEEOOCEE, MDCKLNCPLLP CGNAIHEOONH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[CNJGMKKABCG(FGONPGLMBDD.LoadInstance)]
public interface FHHFDFPIDAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000171")]
	bool LIJAJNDNGEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	bool CKBHAOJLIGD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface LKEIAAMIJFC : GLMNCPGKIGP
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LEKKJCPBBNF(Entity NFFCGLFHPNG, [Out] OALEIPIGPHD EIKDEMMADOB);

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GCPIBNNEADD(NativeArray<OALEIPIGPHD> CHMHEFBBNJL, NativeArray<HIOOIHDEAGK> NGILAIAMGMH);

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EAOCNAEBEDH(OALEIPIGPHD EIKDEMMADOB);

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IFDDAIGOOOG(OALEIPIGPHD EIKDEMMADOB, [Out] Collider ENONIHHKHLG);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[CNJGMKKABCG(FGONPGLMBDD.LoadInstance)]
public interface GLMNCPGKIGP
{
	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BDMHGPBPFNB([In] float3 JJLFBACIKHP, [In] float3 ILKFGPOHBIP, float HJPKMNIGHNC, Allocator ILEAEEDKNCF, [Out] NativeArray<Entity> AFOPCKBACJG);
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[CNJGMKKABCG(FGONPGLMBDD.LoadInstance)]
public interface DBBNFNPBNOE
{
	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BDMHGPBPFNB([In] float3 JJLFBACIKHP, [In] float3 ILKFGPOHBIP, float HJPKMNIGHNC, [Out] IACPJMHHFCO CEOPNMHLJBN, [Out] MDCKLNCPLLP PEFLLODODLA);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[CNJGMKKABCG(FGONPGLMBDD.LoadInstance)]
public interface JJBLMKCCDLI
{
	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BDMHGPBPFNB([In] NativeArray<Entity> AFOPCKBACJG, [In] float3 JJLFBACIKHP, [In] float3 ILKFGPOHBIP, [In] NativeArray<IACPJMHHFCO> NJFEICAJDAH);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct OALEIPIGPHD : CJGADGIIKPL, IEquatable<OALEIPIGPHD>
{
	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int JPDBMMOIFEO
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x91AD60", Offset = "0x919F60", VA = "0x18091AD60", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x91AD70", Offset = "0x919F70", VA = "0x18091AD70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public int CIPMFJNCALK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x238FDE0", Offset = "0x238EFE0", VA = "0x18238FDE0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x561FD50", Offset = "0x561EF50", VA = "0x18561FD50", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x62DAEA0", Offset = "0x62DA0A0", VA = "0x1862DAEA0", Slot = "8")]
	public bool Equals(OALEIPIGPHD NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x62DAEF0", Offset = "0x62DA0F0", VA = "0x1862DAEF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct IACPJMHHFCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float HLENKHCCOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float3 IAAOFHLOLIL;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface LHGKPKPPKOJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface LFHNKPCBEHN
{
	[Cpp2IlInjected.Token(Token = "0x17000175")]
	ELBMHFDBKDI GDBJCNNKDCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	JAHLMKKKDAC FABCNCMPKIO
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<BFODOFFDAJG, NativeArray<FHHKGBHDBDG>> BENDPDEOGAA;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<BFODOFFDAJG> CEMINEOKHBA;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KEHJAHBCGEJ LIJPLHCDJBF(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FHHKGBHDBDG MPGPMICLGJN(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FPMBLPAHIMD(BEHBFJOGLOH IGMILLALAMN, HCDICLIGECB LLNGKGLKEOB);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JDCEJNLNJKM(BEHBFJOGLOH[] PNMDPJJJHMB, GameObject OPEBICILKJE);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	MMHEEOMDOGK AHOBIBHLCHM(MDCKLNCPLLP CGNAIHEOONH, [Optional] object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool GBLMCJHEGHP(MDCKLNCPLLP CGNAIHEOONH, [Out] HCDICLIGECB LLNGKGLKEOB);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool KOPMFIEDGOH(MDCKLNCPLLP CGNAIHEOONH, [Out] Transform GCDMIBEHAIO);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool BIENBGMELLL(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NOGOKGOKMJM(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool NOEDNAEMJPE(LocalId CGNAIHEOONH, object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool HKAHEJFAHNP(LocalId CGNAIHEOONH, object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	MDCKLNCPLLP NKAKKIKJBLC(BEHBFJOGLOH IGMILLALAMN);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool DDNMKOKFEHM(BEHBFJOGLOH IGMILLALAMN, [Out] MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "19")]
	BEHBFJOGLOH KAIMGDNBOJI(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "20")]
	BFODOFFDAJG NKAKKIKJBLC(NativeArray<BEHBFJOGLOH> IGMILLALAMN, Allocator ILEAEEDKNCF);

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "21")]
	BFODOFFDAJG DJBICKMGKBP(FHHKGBHDBDG GEFIJDDLJAH, int KIGJDGACGDD, Allocator ILEAEEDKNCF);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	BFODOFFDAJG ALHFNFKFPNM(NativeArray<BEHBFJOGLOH> IGMILLALAMN, NativeArray<DMAPIOCJDKG> DBJFHNHDBKP, Allocator ILEAEEDKNCF);

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "23")]
	BEHBFJOGLOH[] KMCDACLHEKA(string KNKPACLBJAJ, MMHEEOMDOGK FIOCKHMPFNF, bool OFFDNHIIDJJ);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LPKEMFHOHGH(string KNKPACLBJAJ, BEHBFJOGLOH[] PNMDPJJJHMB);

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "25")]
	MMHEEOMDOGK GAHAOKGFKGD(FHHKGBHDBDG GEFIJDDLJAH, bool GEEMEPLGPFP);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	MMHEEOMDOGK GAHAOKGFKGD(FHHKGBHDBDG GEFIJDDLJAH);

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "27")]
	MMHEEOMDOGK ADPHKMOCLJH(FHHKGBHDBDG GEFIJDDLJAH);

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "28")]
	MMHEEOMDOGK HPGCLCBDPHN(FHHKGBHDBDG GEFIJDDLJAH);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "29")]
	MMHEEOMDOGK DJPAPGJAFCK(BEHBFJOGLOH IGMILLALAMN, FHHKGBHDBDG GEFIJDDLJAH);

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "30")]
	BBOANHNJHNL MCCDHACJEPI();

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DODCEHKEJEF IABKCOGIMAE();

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(Slot = "32")]
	AMFLPNHBEOL ILEKJFMFAAI(OONAHILDADH BALPHGAINLA);

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void DCPEIGABIML(BFODOFFDAJG AIHKOKEKKPF);

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void HDPILJBHDHI(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void LHIFOJEHDOI(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void DCPEIGABIML(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool ELAECKMNNOJ(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "38")]
	BFODOFFDAJG DMPIHCIDPJP(BFODOFFDAJG KJILBAIBGNA, Allocator ILEAEEDKNCF);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool FJFIJPOJCAC(MDCKLNCPLLP CGNAIHEOONH);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class KHJMLCGNNGN
{
	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x62D8050", Offset = "0x62D7250", VA = "0x1862D8050")]
	public static void NOGOKGOKMJM(this LFHNKPCBEHN PLCIIOBANHB, HCDICLIGECB LLNGKGLKEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x62D7E30", Offset = "0x62D7030", VA = "0x1862D7E30")]
	public static MMHEEOMDOGK JCDADKDCCAA(this LFHNKPCBEHN PLCIIOBANHB, LocalId CGNAIHEOONH)
	{
		return default(MMHEEOMDOGK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x62D7E60", Offset = "0x62D7060", VA = "0x1862D7E60")]
	public static MMHEEOMDOGK JCDADKDCCAA(this LFHNKPCBEHN PLCIIOBANHB, BEHBFJOGLOH IGMILLALAMN)
	{
		return default(MMHEEOMDOGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x62D7E30", Offset = "0x62D7030", VA = "0x1862D7E30")]
	public static MDCKLNCPLLP NKAKKIKJBLC(this LFHNKPCBEHN PLCIIOBANHB, LocalId CGNAIHEOONH)
	{
		return default(MDCKLNCPLLP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x62D7EC0", Offset = "0x62D70C0", VA = "0x1862D7EC0")]
	public static BEHBFJOGLOH KAIMGDNBOJI(this LFHNKPCBEHN PLCIIOBANHB, LocalId CGNAIHEOONH)
	{
		return default(BEHBFJOGLOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x62D7DC0", Offset = "0x62D6FC0", VA = "0x1862D7DC0")]
	public static bool FJFIJPOJCAC(this LFHNKPCBEHN PLCIIOBANHB, BEHBFJOGLOH IGMILLALAMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x2978080", Offset = "0x2977280", VA = "0x182978080")]
	public static T MDFIOECIHPP<T>(this LFHNKPCBEHN PLCIIOBANHB, LocalId CGNAIHEOONH) where T : struct, HDJOPFOEMAB
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x62D80D0", Offset = "0x62D72D0", VA = "0x1862D80D0")]
	public static BBOANHNJHNL PPKPOBLGFKD(this LFHNKPCBEHN PLCIIOBANHB, RigidTransform OABAOAEABAB, [Optional] object FCKLPDKGPKE)
	{
		return default(BBOANHNJHNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x62D7F40", Offset = "0x62D7140", VA = "0x1862D7F40")]
	public static AMFLPNHBEOL LMDCEJPPNJL(this LFHNKPCBEHN PLCIIOBANHB, OONAHILDADH MBDMKGPBFOC, RigidTransform OABAOAEABAB, [Optional] object FCKLPDKGPKE)
	{
		return default(AMFLPNHBEOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x62D7AA0", Offset = "0x62D6CA0", VA = "0x1862D7AA0")]
	public static DODCEHKEJEF AGAPGHAFELP(this LFHNKPCBEHN PLCIIOBANHB, RigidTransform OABAOAEABAB, [Optional] object FCKLPDKGPKE)
	{
		return default(DODCEHKEJEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x62D7BA0", Offset = "0x62D6DA0", VA = "0x1862D7BA0")]
	private static void CDJHLBDNBNB(MMHEEOMDOGK BANANMCKKCJ, RigidTransform OABAOAEABAB, [Optional] object FCKLPDKGPKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[CNJGMKKABCG(FGONPGLMBDD.LoadInstance)]
public interface HKPMFOHDGBB
{
	[Cpp2IlInjected.Token(Token = "0x17000177")]
	bool DGDHGHOFHJM
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	MDCKLNCPLLP HKHCMCEHOEG
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	MMHEEOMDOGK PJFPCDNEHNK
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event OIMHDJAHGMI KHEMCDJMIEC;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MDCKLNCPLLP DMMFDKDFHEO(MDCKLNCPLLP IOCBLPNBBJM, MDCKLNCPLLP BEHLFKHHLHF);

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BEDIGEOEPMA(MDCKLNCPLLP IOCBLPNBBJM, MDCKLNCPLLP BEHLFKHHLHF, [Out] MDCKLNCPLLP OLOMOFKKDHI);

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HCMOCENNHJH();

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OGKLKBNLOBA();

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool PCIAMOAALBP(MDCKLNCPLLP IOCBLPNBBJM);

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool IMDGPPGHNOE(MDCKLNCPLLP IOCBLPNBBJM);
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public delegate void OIMHDJAHGMI(MMHEEOMDOGK KHNHPOPMCAL, MMHEEOMDOGK GBBEJEIDMKP);
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class KNKCLJLOFOF
{
	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x62D8300", Offset = "0x62D7500", VA = "0x1862D8300")]
	public static bool DDLNGCBIGNL(this HKPMFOHDGBB FDFEOOOLFEE, MMHEEOMDOGK IOCBLPNBBJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x62D83D0", Offset = "0x62D75D0", VA = "0x1862D83D0")]
	public static bool LHHLPHCDOEH(this HKPMFOHDGBB FDFEOOOLFEE, MDCKLNCPLLP IOCBLPNBBJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x62D8350", Offset = "0x62D7550", VA = "0x1862D8350")]
	public static bool EPBIAFIPGMC(this HKPMFOHDGBB FDFEOOOLFEE, MDCKLNCPLLP IOCBLPNBBJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface IKHOCOHBKFK
{
	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBAIPNKOJBJ(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FKOKPHMMBNG(MDCKLNCPLLP CGNAIHEOONH, Transform GCDMIBEHAIO);
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface FDGHPOGDEKP
{
	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBLMKJAFGKJ(MDCKLNCPLLP IOCBLPNBBJM, MDCKLNCPLLP EOHMBFIJAKL);

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FGEFIOHDLCL(MDCKLNCPLLP IOCBLPNBBJM, MDCKLNCPLLP AGBFMBMONKH);

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PCGFFJKGFLF(MDCKLNCPLLP IOCBLPNBBJM, [Out] MDCKLNCPLLP LOEKEGONNLI);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[CNJGMKKABCG(FGONPGLMBDD.LoadInstance)]
public interface NJDMDMAJPPB
{
	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ICBPLHLOKAI(MDCKLNCPLLP GCHHFDIEIFL, bool NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KLIBBJDOPDI(MDCKLNCPLLP GCHHFDIEIFL, bool NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OCMABELBFDA(MDCKLNCPLLP GCHHFDIEIFL, int NICEPFIEJED);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[CNJGMKKABCG(FGONPGLMBDD.LoadInstance)]
public interface KDPNAEBNBHP
{
	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<MDCKLNCPLLP> GDFFHHFKJOC(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MDCKLNCPLLP MBBFDIGDFMH(MDCKLNCPLLP CGNAIHEOONH, int HMFNCGHECPG);

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int CIFKELHFELM(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KJGIJINEINK HBIEOHLAFCB(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MPFMEMAJADB(MDCKLNCPLLP CGNAIHEOONH, KJGIJINEINK HELLICJGLED);

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MDCKLNCPLLP IFJEKDKMBFP(MDCKLNCPLLP CGNAIHEOONH, [Optional] float3? DHMMMGDKPCG, [Optional] quaternion? HBCECKEGCGH, [Optional] float3? EKCHLHLGOBO);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MDCKLNCPLLP MKIAHMKPKBD(MDCKLNCPLLP CGNAIHEOONH, int HMFNCGHECPG, [Optional] float3? DHMMMGDKPCG, [Optional] quaternion? HBCECKEGCGH, [Optional] float3? EKCHLHLGOBO);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MNALNBNNOMB(MDCKLNCPLLP CGNAIHEOONH, int HMFNCGHECPG);

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NHOAFBBJBKG(MDCKLNCPLLP CGNAIHEOONH);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface BCHBPNBNEIP
{
	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FOJMKAKGNOP();

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FDIJLMPFOFF();

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LNCHAFBOMKH();

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CNMAHKIEBCO();

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DBDECOBGEDK();

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GCAOPCPIOPO();

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IKNONAOPPEI();

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MMDKOPPNJGF();

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BADCCJNEABA();

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FNADBLEIKGK();

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LGHJCPNFEOA();

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ABMJKBKDJPA();
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[CNJGMKKABCG(FGONPGLMBDD.LoadInstance)]
public interface FEHFHAOFPPA
{
	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HMMOLGBGEDJ(MDCKLNCPLLP IOCBLPNBBJM, [Out] int NMBNNEFKAJB);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FCCNDHPHLPD(MDCKLNCPLLP IOCBLPNBBJM, int NMBNNEFKAJB);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GBHFDKEJCGM(MDCKLNCPLLP IOCBLPNBBJM, bool COENLOODJMM);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LHKGLEJBGOE(MDCKLNCPLLP IOCBLPNBBJM, bool NCAAMHCMMCO);

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FCDKHGBDCGM(MDCKLNCPLLP IOCBLPNBBJM, float GMLPINIHLII, float HBACAFFAMOA, float LAHFOKMEGHE);

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IJBGPFDJIHO(MDCKLNCPLLP CGNAIHEOONH, [Out] float HBACAFFAMOA, [Out] float LAHFOKMEGHE);

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LDJFLPLAFLN(MDCKLNCPLLP IOCBLPNBBJM, float3 DHMMMGDKPCG, quaternion HBCECKEGCGH);

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MJNILCGJPPP(MDCKLNCPLLP IOCBLPNBBJM, [Out] float3 DHMMMGDKPCG, [Out] quaternion HBCECKEGCGH);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface GDEPNCNFLGE
{
	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCEHGCGHKAD(Entity NFFCGLFHPNG);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LGPOCLAELFE(Entity NFFCGLFHPNG, [In] float3 NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 KOOAOKHOGKP(Entity NFFCGLFHPNG);

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ACFFKPKOHOL(Entity NFFCGLFHPNG, [In] quaternion NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion ODGAHOHDEDL(Entity NFFCGLFHPNG);

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NMGMFLMJAPI(Entity NFFCGLFHPNG, [Out] float3 DHMMMGDKPCG, [Out] quaternion HBCECKEGCGH);

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NMGMFLMJAPI(Entity NFFCGLFHPNG, [Out] RigidTransform PJKJNGHGPCA);

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ALEIPLIBNLG(Entity NFFCGLFHPNG, [Out] RigidTransform PJKJNGHGPCA);

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 MAKDGKKEEHA(Entity NFFCGLFHPNG);

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FBKPAIBIPHE(Entity NFFCGLFHPNG, [In] float3 NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MKIDLIGJEFK(Entity NFFCGLFHPNG, float NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float DNHBHJEFDAL(Entity NFFCGLFHPNG);

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BHKJGDOLILI(Entity NFFCGLFHPNG, [In] float3 NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 FDFGHKPPKEJ(Entity NFFCGLFHPNG);

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NPLDOGBMGKM(Entity NFFCGLFHPNG, [In] float3 NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 IKFKKFFIAOE(Entity NFFCGLFHPNG);

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DNJIDEMOCDP(Entity NFFCGLFHPNG, [In] quaternion NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion BPJLDNCPOGL(Entity NFFCGLFHPNG);

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 DGKOAEPGNEA(Entity NFFCGLFHPNG);

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void EEPGOGOBKPP(Entity NFFCGLFHPNG, [In] float3 NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void BCMOPDFOPMN(Entity NFFCGLFHPNG, float NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float PBOOBCEJLIJ(Entity NFFCGLFHPNG);

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void MBLMAFCAGGN(Entity NFFCGLFHPNG, [In] float3 NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 BFLHBIPPJEE(Entity NFFCGLFHPNG);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void NACAKMOBAMI(Entity NFFCGLFHPNG, [Out] float4x4 JGFCBJHFPMK);

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void ICCALFACKAP(Entity NFFCGLFHPNG, [In] float4x4 JGFCBJHFPMK);

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void PMMMLNNFDMJ(Entity NFFCGLFHPNG, [Out] float4x4 JGFCBJHFPMK);

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool KOPMFIEDGOH(Entity NFFCGLFHPNG, [Out] Transform GCDMIBEHAIO);

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void KLCEBAACKAA(Entity NFFCGLFHPNG);

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void PADKFNJBJPI(Entity NFFCGLFHPNG, Entity JBPOEGEBKNI, Entity MHAMFGHDGFA);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class KNIHBGOCJGH
{
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface AGMMIOEHCNJ
{
	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJBGAJAFBIL(bool BIHAIGGADAK);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface BAKOPFNPBDH
{
	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World NEFPAEPAMOE(string OGNDEDBDJDL = "Main");

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World BHLCCNDNKCC(string OGNDEDBDJDL = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World DJPDJPFDNKA(string OGNDEDBDJDL = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World NEHDBLCBDNP(string OGNDEDBDJDL = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface KHINBPNOGDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	World HIFGKDJJMAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	World KDNGPHJGEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	EntityManager OGMFHBAHCFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	bool CBEJMOMNALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase AMBNEPGOKGK(Type FLPJMDMACMC);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class KEHIFIIJCNE
{
	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x62D7A10", Offset = "0x62D6C10", VA = "0x1862D7A10")]
	public static ComponentSystemBase JJLDMILHHLB(this World AKNFCAPOGJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x2977D20", Offset = "0x2976F20", VA = "0x182977D20")]
	public static T AMBNEPGOKGK<T>(this KHINBPNOGDJ FKPHAOCNFGH) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[CNJGMKKABCG(FGONPGLMBDD.LoadInstance)]
public interface OIPCHJPLFIB
{
	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HOFIKFMIJFK(NativeListAsync<Entity> MDOLKBIMIAF);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ICJCGNJHHMD(CHPHCLJDLAE ABLKANDHKHH);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CGMKELPANAI(NativeListAsync<Entity> LDFHCFMDJPO, bool IMLBCEHFOAP);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FHHMNMELCON();
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[CNJGMKKABCG(FGONPGLMBDD.LoadInstance)]
public interface KJNPLFCGHJE
{
	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IBBJIJDBAPD(Collider ENONIHHKHLG, [Out] CIKHAOECKEP DLOBCALFBAC);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[CNJGMKKABCG(FGONPGLMBDD.LoadInstance)]
public interface BLPHHJHLHIF
{
	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CHANICMPPDC(MDCKLNCPLLP CGNAIHEOONH, [Out] Collider ENONIHHKHLG);

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject IJOKLLCCAJB(MDCKLNCPLLP NPEOMHCHABA, GameObject ICCEKMKAHCK, Vector3 CMGCCDJMKGB, Quaternion MGHFLNIAHPI);

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FOOBMIBMGIN(GameObject ENONIHHKHLG);

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider HGNBHGHKFIO<TCollider>(GameObject DMEIOFJLCBO) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ALFMBOCHKBL(Collider ENONIHHKHLG);

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject JOMHOLHHOPE<TCollider>(string IKEFBMMMAJB) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[CNJGMKKABCG(FGONPGLMBDD.LoadInstance)]
public interface IIKKJNNMKJB
{
	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IDNLPKBOMAN(MDCKLNCPLLP CGNAIHEOONH, AMPNCKEABLE EHFHABCBDKM, bool EHJBBGJBDOI, DMFJIBOHKNI FFPKGBDFLNM);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HHEKGNKMOFG(MDCKLNCPLLP CGNAIHEOONH, AMPNCKEABLE EHFHABCBDKM, bool EHJBBGJBDOI, bool JBFAONOGLAL, bool ADJMCNHAEAM);

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NANLOOGAICB OCBHMFJDMFM(MDCKLNCPLLP MIAAKEAGJGI, List<MDCKLNCPLLP> LIFOFLKOFAB);

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GJNJAEJODOK(GameObject JKHCPKCAKNM, GameObject BAMLOKINADG);

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DKPIIPFOMFA(GameObject BAMLOKINADG);

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T HGNBHGHKFIO<T>(GameObject DMEIOFJLCBO) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ALFMBOCHKBL(Collider ENONIHHKHLG);

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject HMPHJLNHJAA<T>(string IKEFBMMMAJB) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CKAPIHMEMNH(Collider ENONIHHKHLG, [Out] MDCKLNCPLLP NMBNNEFKAJB);

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool KKOENAADBKG(MDCKLNCPLLP CGNAIHEOONH, [Out] CIKHAOECKEP DLOBCALFBAC);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface OHCJNDDIONC
{
	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIMOOLAODCJ(MDCKLNCPLLP CGNAIHEOONH, MDCKLNCPLLP NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIOAHDHBHDM(MDCKLNCPLLP CGNAIHEOONH, MDCKLNCPLLP NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int PPHLDGBPLKK(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MDCKLNCPLLP PEEDFMHLIJM(MDCKLNCPLLP CGNAIHEOONH, int HMFNCGHECPG);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BFODOFFDAJG CCBHNAINIAA(MDCKLNCPLLP CGNAIHEOONH, Allocator ILEAEEDKNCF = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BBFIGAPNPDC(MDCKLNCPLLP CGNAIHEOONH, object FCKLPDKGPKE, MDCKLNCPLLP NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BICOCOANEMK(MDCKLNCPLLP CGNAIHEOONH, object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FDAJDCLCEML(MDCKLNCPLLP CGNAIHEOONH, [Out] MDCKLNCPLLP NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CLHMJOFKBKA(MDCKLNCPLLP CGNAIHEOONH, float3 NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool EJINMELDOMG(MDCKLNCPLLP CGNAIHEOONH, [Out] float3 NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GIFJJGEOELF(MDCKLNCPLLP CGNAIHEOONH, float3 NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CCDILGHNGIO(MDCKLNCPLLP CGNAIHEOONH, [Out] float3 NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EMDCNGHMDNO(MDCKLNCPLLP CGNAIHEOONH, (Quaternion rot, Vector3 moments) PCCDIKIMCKI);

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool NLNNCNNPOOO(MDCKLNCPLLP CGNAIHEOONH, [Out] quaternion AFBNOBHGJDB, [Out] float3 ONLBPGGOPIO);

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JIDNHBNLGAG(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 MOMBPLPDGOG(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 ABBPGIMENKN(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JEPDHKODJCM(MDCKLNCPLLP CGNAIHEOONH, float3 NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FODDHFCOJGG(MDCKLNCPLLP CGNAIHEOONH, float3 NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float JJJDKLEKGCP(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float BMFHAMEHPMO(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void JKAPACFBBGJ(MDCKLNCPLLP CGNAIHEOONH, float NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void FDFBCACEJIM(MDCKLNCPLLP CGNAIHEOONH, float NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode PGEBEHMLKJD(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FNIAPPDMPBA(MDCKLNCPLLP CGNAIHEOONH, CollisionDetectionMode NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "25")]
	GPHAHJNAAFN CMGCNEMDHPG(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DFBIDNMCBNB(MDCKLNCPLLP CGNAIHEOONH, GPHAHJNAAFN NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool FOAGIMEJMAP(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void AFIECGMCJFC(MDCKLNCPLLP CGNAIHEOONH, bool NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	MDCKLNCPLLP FCCKNACKBOP(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void GMNNFIGECBK(MDCKLNCPLLP CGNAIHEOONH, MDCKLNCPLLP NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	MDCKLNCPLLP ENFGANHBDNA(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void CFLHPBMALHN(MDCKLNCPLLP CGNAIHEOONH, MDCKLNCPLLP NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "33")]
	ANOFOMAGMPD JOMMBLIDKPN(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void IEONNCBCGJJ(MDCKLNCPLLP CGNAIHEOONH, ANOFOMAGMPD JMKNFJCECHO);

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool JNEEHCOPGMI(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void NKKEMJLOGAG(MDCKLNCPLLP CGNAIHEOONH, bool NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool GBJMFMAPPIO(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void ENMCMPMNPCO(MDCKLNCPLLP CGNAIHEOONH, bool NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints IDBALNPFOPP(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void PEJBCKPJAFC(MDCKLNCPLLP CGNAIHEOONH, RigidbodyConstraints NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float NGCMAJEDHOF(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void MEFMCEHEHGH(MDCKLNCPLLP CGNAIHEOONH, float NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float NMMCIPPPECG(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void PNMCJAGEAMC(MDCKLNCPLLP CGNAIHEOONH, float NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool EEGNCCNFMDK(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void MBJGKIONONP(MDCKLNCPLLP CGNAIHEOONH, bool NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool APDGFKGGMAD(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void OOHKAAKBLKI(MDCKLNCPLLP CGNAIHEOONH, bool NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void CPLHCPKLFMI(MDCKLNCPLLP CGNAIHEOONH, int NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "50")]
	CKLELEBFCJP JFMHEJNIFBK(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void LHFFIEOOBJC(MDCKLNCPLLP CGNAIHEOONH, CKLELEBFCJP NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "52")]
	EJAOGNIOOGM OBJAIHIEIGD(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void LOLCIDOLGGA(MDCKLNCPLLP CGNAIHEOONH, EJAOGNIOOGM NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float HINBNCBACGP(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void KIEEBBGGDPJ(MDCKLNCPLLP CGNAIHEOONH, float NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void LJHPBINKPGD(MDCKLNCPLLP CGNAIHEOONH, object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void LCLICGOICCM(MDCKLNCPLLP CGNAIHEOONH, object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool KALOANPOFBO(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void CFKOIIGPELH(MDCKLNCPLLP CGNAIHEOONH, object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void JNNAHAHOAKK(MDCKLNCPLLP CGNAIHEOONH, object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool DPCDMJNOOJG(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool LEHOODADPKJ(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody GNBCGFHMMDG(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void PNKLALFLAMM(MDCKLNCPLLP CGNAIHEOONH, Rigidbody LAANOCCOMFF);

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void KHEHMGDAINE(MDCKLNCPLLP CGNAIHEOONH, object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void MBIBPFFCOBC(MDCKLNCPLLP CGNAIHEOONH, object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool BNGMNACODNJ(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void MOFEDMMJECM(MDCKLNCPLLP CGNAIHEOONH, float3 JPMMLNGJNDB);

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void CHEEPPHINFK(MDCKLNCPLLP CGNAIHEOONH, float3 IACHFILKNFB);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool PKEOOLLPLOH(MDCKLNCPLLP CGNAIHEOONH, [Out] float3 JPMMLNGJNDB);

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool JIBDNDELFJD(MDCKLNCPLLP CGNAIHEOONH, [Out] float3 IACHFILKNFB);

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool CCEEOOAEGCJ(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void FIJJEGKGDND(MDCKLNCPLLP CGNAIHEOONH, object FCKLPDKGPKE, bool PDEBHACKBII);

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void DMNCGLEMIMG(MDCKLNCPLLP CGNAIHEOONH, bool JPAGBPMFOLJ);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void NLJKINDMBPC(MDCKLNCPLLP CGNAIHEOONH);

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool OFLDNPAEHDN(MDCKLNCPLLP CGNAIHEOONH);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[CNJGMKKABCG(FGONPGLMBDD.LoadInstance)]
public interface KMFDHEKDHHC
{
	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FNFFNDPCEJF(Entity JAKABPEKCFJ);

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNPMMHGDALF(Entity JAKABPEKCFJ);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[CNJGMKKABCG(FGONPGLMBDD.LoadInstance)]
public interface BMAGIPMGFHK
{
	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KACGHLBOFLD(MDCKLNCPLLP IOCBLPNBBJM, bool JFBFINDMIJL);

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NKNNFPDJAFD(MDCKLNCPLLP IOCBLPNBBJM, int FNJDHDECLPG);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public delegate void IKIPDDAMCKI(FHPPLMFCEDO JLLJKLDBKGP);
[Cpp2IlInjected.Token(Token = "0x200008F")]
public readonly struct FHPPLMFCEDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly BFODOFFDAJG LONCICKJOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly NativeArray<byte> FDJNKOJIHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly NativeArray<byte> OIFLEBLGNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly HNNMKBLNAPG ECGHOPLJMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly int KLNHHPHPFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly Type FLHDIDDDAPF;

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public BFODOFFDAJG AAKBGKMIIBD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x916970", Offset = "0x915B70", VA = "0x180916970")]
		get
		{
			return default(BFODOFFDAJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x62CFEF0", Offset = "0x62CF0F0", VA = "0x1862CFEF0")]
	public FHPPLMFCEDO(BFODOFFDAJG LONCICKJOML, NativeArray<byte> FDJNKOJIHGN, NativeArray<byte> OIFLEBLGNMG, HNNMKBLNAPG ECGHOPLJMLM, int KLNHHPHPFKJ, Type FLHDIDDDAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x28C9130", Offset = "0x28C8330", VA = "0x1828C9130")]
	public NativeArray<T> FOPINGKIIMB<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x28C9260", Offset = "0x28C8460", VA = "0x1828C9260")]
	public NativeArray<T> PIFMLPCHFON<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x28C9170", Offset = "0x28C8370", VA = "0x1828C9170")]
	public (BFODOFFDAJG, NativeArray<T>, NativeArray<T>) OLBNKGLEPPK<T>() where T : struct
	{
		return default((BFODOFFDAJG, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x62CFEA0", Offset = "0x62CF0A0", VA = "0x1862CFEA0")]
	public GHMDAAEBJMA PCNJOCCLOCP()
	{
		return default(GHMDAAEBJMA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public interface INOLJLNFAPA
{
	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	string EJJJKACADOC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	INOLJLNFAPA BDHMAMCINCF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	IEnumerable<INOLJLNFAPA> KPOPALPAOJG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[CNJGMKKABCG(FGONPGLMBDD.LoadInstance)]
public interface NEOJAKAGFDP
{
	[Cpp2IlInjected.Token(Token = "0x17000182")]
	INOLJLNFAPA AOJCLLAJIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	List<JKOHOMCCJCN> PNFDEEHBEKL
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BFKNIKJGCJJ(JKOHOMCCJCN KCBHGLJDNNP, [Out] INOLJLNFAPA FDPICAHAKBP);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FPMBLPAHIMD(JKOHOMCCJCN KCBHGLJDNNP, IKIPDDAMCKI MOOBJFLLMBE);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GFJGGIBFIEB(JKOHOMCCJCN KCBHGLJDNNP, IKIPDDAMCKI MOOBJFLLMBE);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public readonly struct GHMDAAEBJMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly FHPPLMFCEDO FODGEDCJIDC;

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public BFODOFFDAJG AAKBGKMIIBD
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x916970", Offset = "0x915B70", VA = "0x180916970")]
		get
		{
			return default(BFODOFFDAJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x62D0490", Offset = "0x62CF690", VA = "0x1862D0490")]
	public GHMDAAEBJMA(FHPPLMFCEDO FODGEDCJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x62D01D0", Offset = "0x62CF3D0", VA = "0x1862D01D0")]
	public BFODOFFDAJG FOPINGKIIMB()
	{
		return default(BFODOFFDAJG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x62D03C0", Offset = "0x62CF5C0", VA = "0x1862D03C0")]
	public BFODOFFDAJG PIFMLPCHFON()
	{
		return default(BFODOFFDAJG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x62D02A0", Offset = "0x62CF4A0", VA = "0x1862D02A0")]
	public (BFODOFFDAJG, BFODOFFDAJG, BFODOFFDAJG) OLBNKGLEPPK()
	{
		return default((BFODOFFDAJG, BFODOFFDAJG, BFODOFFDAJG));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[DefaultMember("Item")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface OHICECADNGL : IEnumerable<CBLKJOJOGPN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000185")]
	NativeBitArray KMFPNIPMPBF
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	NativeArray<int> MCFFBFILGFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	int PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	CBLKJOJOGPN HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	CBLKJOJOGPN HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CBLKJOJOGPN PNPADJFMDCO(FADFJPOCFCM COCPAGHPOPH);

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HNNMKBLNAPG IOMKOKJDHKM(FADFJPOCFCM COCPAGHPOPH);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class ELPNMNFABNP
{
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
[DefaultMember("Item")]
public interface NLIKDMIEBKH : IEnumerable<JPMALLCFNFB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	int PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	JPMALLCFNFB HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JPMALLCFNFB PNPADJFMDCO(FADFJPOCFCM COCPAGHPOPH);

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HNNMKBLNAPG IOMKOKJDHKM(FADFJPOCFCM COCPAGHPOPH);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class HIDNFEAKKLK
{
	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x2907BF0", Offset = "0x2906DF0", VA = "0x182907BF0")]
	public static HNNMKBLNAPG IOMKOKJDHKM<T>(this NLIKDMIEBKH OEENDMDOMOO, NHBFCLBDPEE<T> IKEFBMMMAJB) where T : struct
	{
		return default(HNNMKBLNAPG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
[DefaultMember("Item")]
public interface NBMBNGCIBOD : IEnumerable<JKOHOMCCJCN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	int PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	JKOHOMCCJCN HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JKOHOMCCJCN PNPADJFMDCO(FADFJPOCFCM COCPAGHPOPH);

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HNNMKBLNAPG IOMKOKJDHKM(FADFJPOCFCM COCPAGHPOPH);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class PIFJIDGJPNG
{
	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x2A6BC30", Offset = "0x2A6AE30", VA = "0x182A6BC30")]
	public static CFJCCJNMOGI<T> PNPADJFMDCO<T>(this NBMBNGCIBOD OEENDMDOMOO, FADFJPOCFCM IKEFBMMMAJB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2A6BB30", Offset = "0x2A6AD30", VA = "0x182A6BB30")]
	public static HNNMKBLNAPG IOMKOKJDHKM<T>(this NBMBNGCIBOD OEENDMDOMOO, NHBFCLBDPEE<T> IKEFBMMMAJB) where T : struct
	{
		return default(HNNMKBLNAPG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[CNJGMKKABCG(FGONPGLMBDD.LoadInstance)]
public interface MCFGOKIHHDE
{
	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPMBLPAHIMD(FADFJPOCFCM KCBHGLJDNNP, IKIPDDAMCKI MOOBJFLLMBE);

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFJGGIBFIEB(FADFJPOCFCM KCBHGLJDNNP, IKIPDDAMCKI MOOBJFLLMBE);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class MEJPALLNAMA
{
	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x29B4C20", Offset = "0x29B3E20", VA = "0x1829B4C20")]
	public static void FPMBLPAHIMD<T>(this MCFGOKIHHDE CFHIBCOMMJF, NHBFCLBDPEE<T> KCBHGLJDNNP, IKIPDDAMCKI MOOBJFLLMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x29B4E40", Offset = "0x29B4040", VA = "0x1829B4E40")]
	public static void GFJGGIBFIEB<T>(this MCFGOKIHHDE CFHIBCOMMJF, NHBFCLBDPEE<T> KCBHGLJDNNP, IKIPDDAMCKI MOOBJFLLMBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface NFADBMNNAFP
{
	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	EAOCGGFCDCK OJONDBEDCLN
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ALOFPKGICGN(BEHBFJOGLOH IGMILLALAMN, HNNMKBLNAPG KCBHGLJDNNP);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OHBKMALNEDI(BEHBFJOGLOH IGMILLALAMN, Span<HNNMKBLNAPG> OEENDMDOMOO, bool EDCEEKFEEAP);

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FCNEDGLKBNM(NativeArray<BEHBFJOGLOH> PNMDPJJJHMB);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public static class LDNKGCJOFPM
{
	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x62D8E50", Offset = "0x62D8050", VA = "0x1862D8E50")]
	public static void OHBKMALNEDI(this NFADBMNNAFP EJJEHBGMJMK, BEHBFJOGLOH IGMILLALAMN, HNNMKBLNAPG KCBHGLJDNNP, bool EDCEEKFEEAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public readonly struct EAOCGGFCDCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly NativeBitArray DDKBGNJANKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly NativeParallelHashMap<BEHBFJOGLOH, int> LMCLDHLNBDD;

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public bool JDLAAFJNJPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x62CF380", Offset = "0x62CE580", VA = "0x1862CF380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0xBE7D10", Offset = "0xBE6F10", VA = "0x180BE7D10")]
	public EAOCGGFCDCK(NativeBitArray DDKBGNJANKP, NativeParallelHashMap<BEHBFJOGLOH, int> LMCLDHLNBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x62CF250", Offset = "0x62CE450", VA = "0x1862CF250")]
	public bool ALOFPKGICGN(BEHBFJOGLOH IGMILLALAMN, HNNMKBLNAPG KCBHGLJDNNP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[CNJGMKKABCG(FGONPGLMBDD.LoadInstance)]
public interface FPODHPNNEME
{
	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AHNOAFEILNB(MDCKLNCPLLP CGNAIHEOONH, OMJAHFJIINL NICEPFIEJED);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface DPBKJDAJPEB
{
	[Cpp2IlInjected.Token(Token = "0x17000190")]
	AAFKKJIDNGJ OKNCOMLAEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface DOFHKIJFLFB
{
	[Cpp2IlInjected.Token(Token = "0x17000191")]
	Type ECGMEPICDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[CNJGMKKABCG(FGONPGLMBDD.LoadInstance)]
public interface BDNPGHAKEMD
{
	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFKLBGCOPBK(MDCKLNCPLLP GCHHFDIEIFL, bool NICEPFIEJED);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public readonly struct DBLNBBHIKIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly IEnumerable<DNPECAPILFC> EKFGLAKJDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly IReadOnlyList<GameObject> LHDIEDCHDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly IReadOnlyList<int> ILMGEMIHKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly IReadOnlyList<(BEHBFJOGLOH, BEHBFJOGLOH)> OGKALCNAMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly int EGLEACFEBII;

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public bool KMIBCIBKNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x62CD860", Offset = "0x62CCA60", VA = "0x1862CD860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public int HDLIOJPLMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x821ED0", Offset = "0x8210D0", VA = "0x180821ED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public IEnumerable<GameObject> IIHLLBNBGFO
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x9154B0", Offset = "0x9146B0", VA = "0x1809154B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public IEnumerable<(BEHBFJOGLOH src, BEHBFJOGLOH dst)> BLPCCLOBMCI
	{
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x62CDC50", Offset = "0x62CCE50", VA = "0x1862CDC50")]
	public DBLNBBHIKIP(IEnumerable<DNPECAPILFC> EKFGLAKJDMD, IReadOnlyList<GameObject> LHDIEDCHDAE, IReadOnlyList<int> ILMGEMIHKCB, IReadOnlyList<(BEHBFJOGLOH src, BEHBFJOGLOH dst)> OGKALCNAMNH, int EGLEACFEBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x62CD8C0", Offset = "0x62CCAC0", VA = "0x1862CD8C0")]
	public (GameObject, int)[] GDBFMLGOHBB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface OHBPHFCLDHF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000196")]
	bool BJAFCFELEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	bool PMPNOLNBOEH
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	EGMFDPLOHAJ BCHPKHADHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OGPAABABKPJ LJLEDMDPABE();

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OGPAABABKPJ AFFHMJNFKAF(IEnumerable<MDCKLNCPLLP> AIHKOKEKKPF, [In] UniformTRS PHDCLFGNGIO);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IECCNPEDOHA KGEEBFDNFHH(ByteString FJPDDAJPKIG);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MBLOGGKGAEO ONACMJPBMJI(ByteString NBPNGOIAHPG, MDCKLNCPLLP BHNONFFBKHO, [In] UniformTRS GKBONMCDLOM, JPJAGBHJOOF JAGBPPCBHNI, bool FBNLBKJPACF = true);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CCJDIJCAPIN();

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DBLNBBHIKIP EAFHGEAIFOF(IEnumerable<DNPECAPILFC> EKFGLAKJDMD);
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class PNFGOLCJPPN
{
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface CBDKHEEDCDD
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action HLDACPIAIEH;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action DOHNKGKOPGD;
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct DMAPIOCJDKG : EDPFHBBGDGC, IEquatable<DMAPIOCJDKG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public FHHKGBHDBDG GEFIJDDLJAH;

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x62CDED0", Offset = "0x62CD0D0", VA = "0x1862CDED0", Slot = "5")]
	public void LKMADFBDLGL(AEJGALJMLND CAMFAGAEHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x62CDF00", Offset = "0x62CD100", VA = "0x1862CDF00", Slot = "4")]
	public void OHDBDPJBHPM(ENKDIFGMEIN KPDGEKKKOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x62CDF30", Offset = "0x62CD130", VA = "0x1862CDF30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x8A5400", Offset = "0x8A4600", VA = "0x1808A5400", Slot = "6")]
	public bool Equals(DMAPIOCJDKG NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x62CDE50", Offset = "0x62CD050", VA = "0x1862CDE50", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x91AD60", Offset = "0x919F60", VA = "0x18091AD60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct BEHBFJOGLOH : IComparable<BEHBFJOGLOH>, IEquatable<BEHBFJOGLOH>, EDPFHBBGDGC
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public const uint AKCCIFCOJHP = 0u;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public const uint APAKJDKIEKK = 255u;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly BEHBFJOGLOH BKMHILKPIAJ;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private const int JPAFLFCBGKD = 24;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private const uint MBDIFLOOIMA = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private const int NPCJJICPOFF = 8;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private const uint PHMPLPINEGK = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly uint CGAHJPHALBC;

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	public uint KLPAKGPGNAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x802050", Offset = "0x801250", VA = "0x180802050")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public uint FJJHODHBEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x62CC6B0", Offset = "0x62CB8B0", VA = "0x1862CC6B0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public uint MNKEOMKCPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x91AD60", Offset = "0x919F60", VA = "0x18091AD60")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	public bool KMIBCIBKNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x62428F0", Offset = "0x6241AF0", VA = "0x1862428F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0xD64C80", Offset = "0xD63E80", VA = "0x180D64C80")]
	public static BEHBFJOGLOH DBFCGOMANOO(uint CGAHJPHALBC)
	{
		return default(BEHBFJOGLOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x62CC8A0", Offset = "0x62CBAA0", VA = "0x1862CC8A0")]
	public BEHBFJOGLOH(int EGPEDDDFDOG, int FINIPMFGOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x62CC8A0", Offset = "0x62CBAA0", VA = "0x1862CC8A0")]
	public BEHBFJOGLOH(uint EGPEDDDFDOG, int FINIPMFGOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x62CC8A0", Offset = "0x62CBAA0", VA = "0x1862CC8A0")]
	public BEHBFJOGLOH(uint EGPEDDDFDOG, uint FINIPMFGOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x91AD70", Offset = "0x919F70", VA = "0x18091AD70")]
	private BEHBFJOGLOH(uint CGAHJPHALBC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x18A2530", Offset = "0x18A1730", VA = "0x1818A2530")]
	public static bool AIPCENMEJFE(BEHBFJOGLOH JPEEHDCLFEK, BEHBFJOGLOH HGMCBKHHGFH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x62CC740", Offset = "0x62CB940", VA = "0x1862CC740")]
	public static bool KEIKIALHENC(BEHBFJOGLOH JPEEHDCLFEK, BEHBFJOGLOH HGMCBKHHGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x8A5400", Offset = "0x8A4600", VA = "0x1808A5400", Slot = "5")]
	public bool Equals(BEHBFJOGLOH JNIKIHKLGAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x62CC6C0", Offset = "0x62CB8C0", VA = "0x1862CC6C0", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x2371290", Offset = "0x2370490", VA = "0x182371290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x62CC810", Offset = "0x62CBA10", VA = "0x1862CC810", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x62CC7B0", Offset = "0x62CB9B0", VA = "0x1862CC7B0", Slot = "6")]
	public void OHDBDPJBHPM(ENKDIFGMEIN KPDGEKKKOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x62CC750", Offset = "0x62CB950", VA = "0x1862CC750", Slot = "7")]
	public void LKMADFBDLGL(AEJGALJMLND CAMFAGAEHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x61F0480", Offset = "0x61EF680", VA = "0x1861F0480", Slot = "4")]
	public int CompareTo(BEHBFJOGLOH NOBJAPGNDAK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct DNPECAPILFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Guid IKOKEKHMFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public string KNKPACLBJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Vector3 DHMMMGDKPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Quaternion HBCECKEGCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Vector3 EKCHLHLGOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public int OPNAIEFAHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Dictionary<string, object> HELLICJGLED;

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x62CE110", Offset = "0x62CD310", VA = "0x1862CE110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x62CDF90", Offset = "0x62CD190", VA = "0x1862CDF90")]
	private static string GPNOKGMNMHL(Dictionary<string, object> MGDCNENJAML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public enum HJENLJAMDKO
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class PEEJJOFKJFK
{
	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x5758440", Offset = "0x5757640", VA = "0x185758440")]
	public static bool ICLELNHGCDJ(this HJENLJAMDKO FLPJMDMACMC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[Flags]
public enum INDEAEPHMKH
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	WorldPhasesMaster = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	AdditivePhases = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public interface MBLOGGKGAEO : EGMFDPLOHAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	JPJAGBHJOOF MJEKEJJOMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPBPNKPIOLJ();

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DPHDNMHCFNL();
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public interface EGMFDPLOHAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	IEnumerable<DNPECAPILFC> DPINEHBMOLN
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	DBLNBBHIKIP JJGCEALCCHG
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	LocalId GFIEMNBCBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	MIMHHPCOOGI EKDNHCPFJEN
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CHEEFNHIJMB(INDEAEPHMKH LEPACINJDJM);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public interface JPJAGBHJOOF
{
	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GLIDFODHJJL(Guid LHCBCAKMNGO, [Out] Guid BOFPFAHMDKM);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public interface IECCNPEDOHA : EGMFDPLOHAJ, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[Flags]
public enum DHKFJLMHILI
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public interface OGPAABABKPJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	MIMHHPCOOGI FFHKGKNIEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString OFNIGLCJGDE();
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public enum GENCJGIGKPF
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public delegate bool LOKJLBFAFHE(EGBPKFDCIJK LGCFAMHJDOL, [In] OJHLMDHDACG NICEPFIEJED);
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public delegate bool LMIHMJLPABJ<T>(EGBPKFDCIJK LGCFAMHJDOL, [In] T NICEPFIEJED);
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface KCKGPOPBECD
{
	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPMBLPAHIMD(HNNMKBLNAPG ECGHOPLJMLM, Type ADCLODFGCEM, LOKJLBFAFHE CPMDEJJCHEA);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MJDDBJJDBFL(HNNMKBLNAPG ECGHOPLJMLM, [Out] LOKJLBFAFHE CPMDEJJCHEA);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class LOHNMIONHEK
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class OMGJOLBOIED<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public LMIHMJLPABJ<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public OMGJOLBOIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x41C3800", Offset = "0x41C2A00", VA = "0x1841C3800")]
		internal bool MKKBMGAKFCM(EGBPKFDCIJK pendingList, [In] OJHLMDHDACG value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x298D170", Offset = "0x298C370", VA = "0x18298D170")]
	public static void FPMBLPAHIMD<T>(this KCKGPOPBECD CFHIBCOMMJF, HNNMKBLNAPG ECGHOPLJMLM, LMIHMJLPABJ<T> CPMDEJJCHEA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x62D9050", Offset = "0x62D8250", VA = "0x1862D9050")]
	public static bool LIAIKGODOFB(this KCKGPOPBECD CFHIBCOMMJF, EGBPKFDCIJK LGCFAMHJDOL, HNNMKBLNAPG ECGHOPLJMLM, [In] OJHLMDHDACG NICEPFIEJED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface MAFIHAEHOIM
{
	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	uint JCJLNHDGEGK
	{
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface EGBPKFDCIJK
{
	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PHBLDNEEDMM(BEHBFJOGLOH MGJCHMCGOCI, HNNMKBLNAPG ECGHOPLJMLM, ReadOnlySpan<byte> HCBDGEOEFBK, ReadOnlySpan<byte> JBMEGHIGOPG);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EOAJDAGKAIC(BEHBFJOGLOH MGJCHMCGOCI, HNNMKBLNAPG ECGHOPLJMLM);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NDOIOGDCHOF(BEHBFJOGLOH MGJCHMCGOCI, HNNMKBLNAPG ECGHOPLJMLM, ReadOnlySpan<byte> JBMEGHIGOPG);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PDGAAHENDNE(BEHBFJOGLOH MGJCHMCGOCI, HNNMKBLNAPG ECGHOPLJMLM, Span<byte> HCBDGEOEFBK, Span<byte> JBMEGHIGOPG);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class DLHBJADEHBM
{
	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x275C2F0", Offset = "0x275B4F0", VA = "0x18275C2F0")]
	public static bool PDGAAHENDNE<T>(this EGBPKFDCIJK NHBNLNKIDCL, BEHBFJOGLOH MGJCHMCGOCI, HNNMKBLNAPG ECGHOPLJMLM, [Out] T HCBDGEOEFBK, [Out] T JBMEGHIGOPG) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x275C1C0", Offset = "0x275B3C0", VA = "0x18275C1C0")]
	public static bool NDOIOGDCHOF<T>(this EGBPKFDCIJK NHBNLNKIDCL, BEHBFJOGLOH MGJCHMCGOCI, HNNMKBLNAPG ECGHOPLJMLM, T JBMEGHIGOPG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public enum NEPOFAHFFEO
{
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	End,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface BALDMLDPLLO
{
	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FBLIPPBLBPC(MFDKAFGFEFA GBHPBJPAFFB, ReadOnlySpan<byte> AENCBMJJMMB);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKJKACIAAAG(uint MBFJIGPHJKO, ReadOnlySpan<byte> AENCBMJJMMB);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BEIIHALLGOI(int JKHMKIDBHPH);
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface GDPBIICJIJP
{
	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MFDKAFGFEFA PMEHBCCFPJM(ReadOnlySpan<byte> AENCBMJJMMB);
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface GGBLOEMBGMP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKCENLAKMII(MFDKAFGFEFA GOBGGNLGONA, ReadOnlySpan<byte> AENCBMJJMMB);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NAHGLMCOJGJ(ReadOnlySpan<MFDKAFGFEFA> OPNIOHHNMOO);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public struct KBACGOKKDEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public MFDKAFGFEFA GBHPBJPAFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public ReadOnlyMemory<byte> AENCBMJJMMB;
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public struct MFDKAFGFEFA
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public static MFDKAFGFEFA KBFDMMHKHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public uint EGPEDDDFDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public int GFBDPDEFDKK;

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0xAF4D20", Offset = "0xAF3F20", VA = "0x180AF4D20")]
	public MFDKAFGFEFA(uint EGPEDDDFDOG, int GFBDPDEFDKK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x62D9AF0", Offset = "0x62D8CF0", VA = "0x1862D9AF0")]
	public static bool AIPCENMEJFE([In] MFDKAFGFEFA EFLJLNCMHDD, [In] MFDKAFGFEFA DJDKOLONKNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x62D9B10", Offset = "0x62D8D10", VA = "0x1862D9B10", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x62D9BC0", Offset = "0x62D8DC0", VA = "0x1862D9BC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x62D9C00", Offset = "0x62D8E00", VA = "0x1862D9C00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x62D9BF0", Offset = "0x62D8DF0", VA = "0x1862D9BF0")]
	public void NAEOOGIIDLH([Out] uint EGPEDDDFDOG, [Out] int GFBDPDEFDKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[CNJGMKKABCG(FGONPGLMBDD.OMRoom)]
public interface COOPMELIKLP : FNBJDJBJKKG<COOPMELIKLP>
{
	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FBKMABELHLO(HNNMKBLNAPG JNIKIHKLGAD, [Out] LFHJNKEGHPA EOAKDGCPOJO);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public static class OEGFADNNHGP
{
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public interface LFHJNKEGHPA
{
	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	Type IOBJBJJDJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKMADFBDLGL(AEJGALJMLND CAMFAGAEHOD, Span<byte> IOCBLPNBBJM);

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OHDBDPJBHPM(ENKDIFGMEIN KPDGEKKKOHO, ReadOnlySpan<byte> GBHPBJPAFFB);
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class DHCDAHBPPEM
{
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public struct HIOOIHDEAGK : ISystemStateComponentData, IComponentData, IEquatable<HIOOIHDEAGK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public float3 MBHINFPNBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public float3 DKBDMNBKALM;

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x62D27F0", Offset = "0x62D19F0", VA = "0x1862D27F0", Slot = "4")]
	public bool Equals(HIOOIHDEAGK NOBJAPGNDAK)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class NIBLCMOALME
{
	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public NIBLCMOALME()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
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
