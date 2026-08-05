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
	public class LogRegistrationIndex : DEDNPPDJFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x642A3D0", Offset = "0x6428DD0", VA = "0x18642A3D0", Slot = "4")]
		public override void JIGIEBIDGIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DPGDCBAFJCK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x641EAF0", Offset = "0x641D4F0", VA = "0x18641EAF0")]
	public static void LPDACEJGKLE(this Rigidbody ACOEBGHOHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x641E9C0", Offset = "0x641D3C0", VA = "0x18641E9C0")]
	public static void LPDACEJGKLE(this Rigidbody ACOEBGHOHJG, Vector3 IEFEGBADFJC, Quaternion GIHHPHDACDB, Vector3 MBPKDMNKEAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct JJOLFCGDJOI : IReadOnlyList<MMBMADJJEAB>, IEnumerable<MMBMADJJEAB>, IEnumerable, IReadOnlyCollection<MMBMADJJEAB>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct NIFHHJDIDON : IEnumerator<MMBMADJJEAB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly PHDJGIJHHIJ FDBOKAJBAPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator GKPKKDMKOIH;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public MMBMADJJEAB EIIOCLGDIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x642B710", Offset = "0x642A110", VA = "0x18642B710", Slot = "4")]
			get
			{
				return default(MMBMADJJEAB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x642B690", Offset = "0x642A090", VA = "0x18642B690", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3E023C0", Offset = "0x3E00DC0", VA = "0x183E023C0")]
		public NIFHHJDIDON(PHDJGIJHHIJ FDBOKAJBAPF, NativeArray<LocalId>.Enumerator GKPKKDMKOIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x642B5D0", Offset = "0x6429FD0", VA = "0x18642B5D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x642B610", Offset = "0x642A010", VA = "0x18642B610", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x642B650", Offset = "0x642A050", VA = "0x18642B650", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly PHDJGIJHHIJ FDBOKAJBAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> ONHBEAIBAJA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MMBMADJJEAB MIEEOIIACLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6427220", Offset = "0x6425C20", VA = "0x186427220", Slot = "4")]
		get
		{
			return default(MMBMADJJEAB);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6426CF0", Offset = "0x64256F0", VA = "0x186426CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int PEJNADIFMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C2110", Offset = "0x7C0B10", VA = "0x1807C2110", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public PHDJGIJHHIJ ODHOLIFAOMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int EEALFJDFGFI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C2110", Offset = "0x7C0B10", VA = "0x1807C2110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool IFFKIMEMNJN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6426C50", Offset = "0x6425650", VA = "0x186426C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> JHGEINCNFDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x23BB750", Offset = "0x23BA150", VA = "0x1823BB750")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> IPNBMDPPKCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6426C90", Offset = "0x6425690", VA = "0x186426C90")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x64270E0", Offset = "0x6425AE0", VA = "0x1864270E0")]
	public JJOLFCGDJOI(int JDNEKMCCAKP, PHDJGIJHHIJ FDBOKAJBAPF, Allocator IMPJLMNPHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3E02350", Offset = "0x3E00D50", VA = "0x183E02350")]
	public JJOLFCGDJOI(PHDJGIJHHIJ FDBOKAJBAPF, NativeArray<LocalId> ONHBEAIBAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6426FD0", Offset = "0x64259D0", VA = "0x186426FD0")]
	internal JJOLFCGDJOI(PHDJGIJHHIJ FDBOKAJBAPF, NativeArray<Entity> JKAMGAGLGEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6427040", Offset = "0x6425A40", VA = "0x186427040")]
	public JJOLFCGDJOI(PHDJGIJHHIJ FDBOKAJBAPF, int JEKCEPEEELJ, Allocator IMPJLMNPHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6427170", Offset = "0x6425B70", VA = "0x186427170")]
	public JJOLFCGDJOI(JJOLFCGDJOI DMPPHCKDGJI, Allocator IMPJLMNPHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6426D40", Offset = "0x6425740", VA = "0x186426D40")]
	public JJOLFCGDJOI NEBOBDLOGAK(Allocator IMPJLMNPHBC = Allocator.Temp)
	{
		return default(JJOLFCGDJOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6426B80", Offset = "0x6425580", VA = "0x186426B80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6426BC0", Offset = "0x64255C0", VA = "0x186426BC0")]
	public NIFHHJDIDON HOEJGHKHDAP()
	{
		return default(NIFHHJDIDON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6426DF0", Offset = "0x64257F0", VA = "0x186426DF0", Slot = "6")]
	private IEnumerator<MMBMADJJEAB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6426EE0", Offset = "0x64258E0", VA = "0x186426EE0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public struct KHOBLKMELAF : IList<MMBMADJJEAB>, ICollection<MMBMADJJEAB>, IEnumerable<MMBMADJJEAB>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct FLMNELPOJKO : IEnumerator<MMBMADJJEAB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly PHDJGIJHHIJ FDBOKAJBAPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator GKPKKDMKOIH;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public MMBMADJJEAB EIIOCLGDIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6422620", Offset = "0x6421020", VA = "0x186422620", Slot = "4")]
			get
			{
				return default(MMBMADJJEAB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x64225A0", Offset = "0x6420FA0", VA = "0x1864225A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3E023C0", Offset = "0x3E00DC0", VA = "0x183E023C0")]
		public FLMNELPOJKO(PHDJGIJHHIJ FDBOKAJBAPF, NativeArray<LocalId>.Enumerator GKPKKDMKOIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x64224E0", Offset = "0x6420EE0", VA = "0x1864224E0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6422520", Offset = "0x6420F20", VA = "0x186422520", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6422560", Offset = "0x6420F60", VA = "0x186422560", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly PHDJGIJHHIJ FDBOKAJBAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> ONHBEAIBAJA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public MMBMADJJEAB MIEEOIIACLC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6428520", Offset = "0x6426F20", VA = "0x186428520", Slot = "4")]
		get
		{
			return default(MMBMADJJEAB);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x64285A0", Offset = "0x6426FA0", VA = "0x1864285A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int IAGPAHCAHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6427EC0", Offset = "0x64268C0", VA = "0x186427EC0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int EEALFJDFGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6427EC0", Offset = "0x64268C0", VA = "0x186427EC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool FIKMFADPAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6428490", Offset = "0x6426E90", VA = "0x186428490")]
	public KHOBLKMELAF(PHDJGIJHHIJ FDBOKAJBAPF, int JEKCEPEEELJ, Allocator IMPJLMNPHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6428110", Offset = "0x6426B10", VA = "0x186428110")]
	public JJOLFCGDJOI MAGFNHKOFJM()
	{
		return default(JJOLFCGDJOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6427CA0", Offset = "0x64266A0", VA = "0x186427CA0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6427CE0", Offset = "0x64266E0", VA = "0x186427CE0", Slot = "13")]
	public bool Contains(MMBMADJJEAB ODDGLLCBILG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6427D70", Offset = "0x6426770", VA = "0x186427D70", Slot = "14")]
	public void CopyTo(MMBMADJJEAB[] KKAKPOKBAHF, int CJLMKFIOCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6427C20", Offset = "0x6426620", VA = "0x186427C20", Slot = "11")]
	public void Add(MMBMADJJEAB ODDGLLCBILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6428060", Offset = "0x6426A60", VA = "0x186428060", Slot = "7")]
	public void Insert(int ABBNIPHGMGH, MMBMADJJEAB ODDGLLCBILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x64281E0", Offset = "0x6426BE0", VA = "0x1864281E0", Slot = "15")]
	public bool Remove(MMBMADJJEAB ODDGLLCBILG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6427FD0", Offset = "0x64269D0", VA = "0x186427FD0", Slot = "6")]
	public int IndexOf(MMBMADJJEAB ODDGLLCBILG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6428190", Offset = "0x6426B90", VA = "0x186428190", Slot = "8")]
	public void RemoveAt(int ABBNIPHGMGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6427F00", Offset = "0x6426900", VA = "0x186427F00", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6427F40", Offset = "0x6426940", VA = "0x186427F40")]
	public FLMNELPOJKO HOEJGHKHDAP()
	{
		return default(FLMNELPOJKO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x64282B0", Offset = "0x6426CB0", VA = "0x1864282B0", Slot = "16")]
	private IEnumerator<MMBMADJJEAB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x64283A0", Offset = "0x6426DA0", VA = "0x1864283A0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IEBDAOBLIEO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int IHHGFNBNBLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> DEJHFNNHGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MMBMADJJEAB FODMFNOINIM(MMBMADJJEAB ONHBEAIBAJA);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IIEMFFOBKDJ : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface IOELMAOMHPF : NOGCNGGILPM, PNALMCICKOO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool DNNOPBKFOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	FOFEOENBKAF HPKAJMCANEI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	PIKLCFFHOBP DDGAPPJOMKH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	KHGNHJPOKLJ DLFOJMPEOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	MPGCFKMMOMM KEOILMDEIKC
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	DBCOGFGEFIA CJLPFLAIEEP
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface PNALMCICKOO
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool NKDNPGBEGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface GKMGKCNECCD
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EEKCLGPFNPI(bool AEJBOLFACJC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface MPGCFKMMOMM
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool PNGEGJODJJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action LKLLCGNCONA;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LPGDNMOOJDN(bool IHFMNOOBPFC);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DGNLKFHBMFO(ByteString KDBHEHGNFHP);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IEOFDAPLNLM();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BBOCPDIGEAF();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FFPFFJDIJNM();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface KHGNHJPOKLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GHIFKENEMPN HPKAJMCANEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	PIKLCFFHOBP DDGAPPJOMKH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	COPBAAFFJOH LFMOJFNDBLK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IOELMAOMHPF FNIKLAMJGPM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	PHDJGIJHHIJ ODHOLIFAOMH
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	NKGGJAMICIA KIOIPHAMENG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	OEODAGFIFJP JECPJGGOMFD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	FPOFPGIFBFC FHONMEEOPIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DCCEMINIHNL IHMADKDJBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	LFFIHBDPEIL MOHBCGFICMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	MHLBKKKNHKN HIFNAEHILJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	FGLCBFOPBJF EEOOAFACPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	PGDLMPLLEBE HJMPNLCGDLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	MCJNFOCOJDA FGNFCBMJMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	KPNNBHNLMKP HACEFGHNIIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	NFMDLGENFJM OKPCPCNGNEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	JBLMOBBNPEC AMKBHPACBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	OPNOFPPCLJE IMKNBMEDCBH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	KFMKKDGOGLH BGBONKIOONO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	IHFJFJMCELM FKGJKCAEGNF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	DBJOIANBJFL GPDJBPKDIDC
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	DNFAJIDFMJC CFLIFOECMBG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	OJAHMLCLCPK NFKGJFPJEAA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	IOOAHMGANFD GBJLIFKNCIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	FJMKJMIIHOE HEGPPIMPKOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(DMCIGMJNJCE))]
public readonly struct MMBMADJJEAB : IComparable<MMBMADJJEAB>, IEquatable<MMBMADJJEAB>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly MMBMADJJEAB ENOPEJBDPMA;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int CIPBGBMKOPO = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int GACMAJJDKNE = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int ABBBHGCLJBH = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int HDBGONNAPOK = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId OCMIGFBMBMB;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public PHDJGIJHHIJ ODHOLIFAOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x641B5F0", Offset = "0x6419FF0", VA = "0x18641B5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IOELMAOMHPF FNIKLAMJGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x642AD10", Offset = "0x6429710", VA = "0x18642AD10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public LocalId EFMKILEHJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x642B070", Offset = "0x6429A70", VA = "0x18642B070")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal DBCOGFGEFIA CJLPFLAIEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x642AFE0", Offset = "0x64299E0", VA = "0x18642AFE0")]
		get
		{
			return default(DBCOGFGEFIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool FPGLOIPLKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x642B1D0", Offset = "0x6429BD0", VA = "0x18642B1D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private bool IIBCAOEJDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x642B310", Offset = "0x6429D10", VA = "0x18642B310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x642B490", Offset = "0x6429E90", VA = "0x18642B490")]
	public MMBMADJJEAB(PHDJGIJHHIJ CODEIPNPDLI, LocalId OCMIGFBMBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
	public HFKEOLHFCHL NNBAIOAEAJO()
	{
		return default(HFKEOLHFCHL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x642B030", Offset = "0x6429A30", VA = "0x18642B030")]
	public static LocalId KHGGPLGKNCG(MMBMADJJEAB ICEOCGDMLJE)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x642AFF0", Offset = "0x64299F0", VA = "0x18642AFF0")]
	public static Entity KHGGPLGKNCG(MMBMADJJEAB ICEOCGDMLJE)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x642B0B0", Offset = "0x6429AB0", VA = "0x18642B0B0")]
	public static bool PIEEFOPMNNK(MMBMADJJEAB LMANHAAPNDE, MMBMADJJEAB AMHFHPBEBNM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x64253B0", Offset = "0x6423DB0", VA = "0x1864253B0")]
	public static bool EGKBPOJOPJH(MMBMADJJEAB LMANHAAPNDE, MMBMADJJEAB AMHFHPBEBNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x642B360", Offset = "0x6429D60", VA = "0x18642B360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x642AE50", Offset = "0x6429850", VA = "0x18642AE50", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x641ACC0", Offset = "0x64196C0", VA = "0x18641ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x642AD70", Offset = "0x6429770", VA = "0x18642AD70", Slot = "4")]
	public int CompareTo(MMBMADJJEAB HKMMPHJFKEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x641ACB0", Offset = "0x64196B0", VA = "0x18641ACB0", Slot = "5")]
	public bool Equals(MMBMADJJEAB HKMMPHJFKEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GKHEOPGCBJL
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6422EE0", Offset = "0x64218E0", VA = "0x186422EE0")]
	public static BHEOONDIPJK NBGAAEGCGPG(this MMBMADJJEAB COMOOAEHALC)
	{
		return default(BHEOONDIPJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6422E20", Offset = "0x6421820", VA = "0x186422E20")]
	public static HFKEOLHFCHL BNHCCGLIIAO(this MMBMADJJEAB COMOOAEHALC, [Optional] object AIDIDMJCFEK)
	{
		return default(HFKEOLHFCHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x295A3D0", Offset = "0x2958DD0", VA = "0x18295A3D0")]
	public static T GGFLGMHCOKL<T>(this MMBMADJJEAB COMOOAEHALC) where T : struct, BMBGJEDJJKC
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class DMCIGMJNJCE
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct DBCOGFGEFIA : IEquatable<DBCOGFGEFIA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte MEGCFGBDKPO;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] FHGPIEIOOLN;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static PHDJGIJHHIJ OMOGDPPCLGP;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static IOELMAOMHPF AGLFBKDGFKH;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static PHDJGIJHHIJ[] AEBNPENKPKH;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static IOELMAOMHPF[] LHJCECAALMH;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> EOFLMPGEACI;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public IOELMAOMHPF FNIKLAMJGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x641C150", Offset = "0x641AB50", VA = "0x18641C150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public PHDJGIJHHIJ CAPIPPCAOGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x641C230", Offset = "0x641AC30", VA = "0x18641C230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x641CCB0", Offset = "0x641B6B0", VA = "0x18641CCB0")]
	static DBCOGFGEFIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xCE6180", Offset = "0xCE4B80", VA = "0x180CE6180")]
	internal DBCOGFGEFIA(byte AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x55FABE0", Offset = "0x55F95E0", VA = "0x1855FABE0", Slot = "4")]
	public bool Equals(DBCOGFGEFIA HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x641C310", Offset = "0x641AD10", VA = "0x18641C310", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1BDB060", Offset = "0x1BD9A60", VA = "0x181BDB060", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x641CBF0", Offset = "0x641B5F0", VA = "0x18641CBF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x641C910", Offset = "0x641B310", VA = "0x18641C910")]
	private static PHDJGIJHHIJ JLNCGKNFKAD(byte MEGCFGBDKPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x641C9D0", Offset = "0x641B3D0", VA = "0x18641C9D0")]
	private static IOELMAOMHPF OLKJBEHALPG(byte MEGCFGBDKPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x641CA80", Offset = "0x641B480", VA = "0x18641CA80")]
	private static object OMFNFOKGNDP(byte MEGCFGBDKPO, object[] KCNHIGOABNO, object LFANPJOLHJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x641C9C0", Offset = "0x641B3C0", VA = "0x18641C9C0")]
	private static int KKNLDIKMFBN(byte MEGCFGBDKPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x641C640", Offset = "0x641B040", VA = "0x18641C640")]
	private static int JFGPHPKIMNL(byte MEGCFGBDKPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x641C5C0", Offset = "0x641AFC0", VA = "0x18641C5C0")]
	private static (int, int) IONMJDDHHDN(byte MEGCFGBDKPO)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x641C140", Offset = "0x641AB40", VA = "0x18641C140")]
	private static byte BOCFCJJIMKC(int LHMJGBJEDAH, int ABBNIPHGMGH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x641C650", Offset = "0x641B050", VA = "0x18641C650")]
	internal static DBCOGFGEFIA JIGIEBIDGIG(IOELMAOMHPF AJENIECCFKP, PHDJGIJHHIJ GPDEAACAMKP)
	{
		return default(DBCOGFGEFIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x641C3B0", Offset = "0x641ADB0", VA = "0x18641C3B0")]
	internal static void ILHGCENAOJC(DBCOGFGEFIA MEGCFGBDKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x641BDB0", Offset = "0x641A7B0", VA = "0x18641BDB0")]
	private static void BIGADFFIHBF(int JDNEKMCCAKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface OIHKHPIFIAD
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OLDJLDJCKKM();

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HAAEEDGPJHG(bool FMFCEPMBGCA);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BICGEPDEBFG(GameObject PACDKKMGCFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface LJHLGLFGAGK
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	Guid IGCFIOLOAOM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IKGIBAAIBCH(Guid DCIMKJPPFLA, Guid JDPMMMALKLJ);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task KILMABDBNME(MMBMADJJEAB IPJEENGJHFE);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AGGGPIELKBL(MMBMADJJEAB APJECMEEJIN, MMBMADJJEAB HHJLJBMAMDD, [Out] Vector3 BNPKKMNBEBA, [Out] Quaternion CMIACCILPCG);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HIFMJFAHMAF(IADANDIMIEH PAIANDGPMFL, Vector3 BNPKKMNBEBA, Quaternion CMIACCILPCG);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HENJFFIBGNA(MMBMADJJEAB PNIOCHGMKOM, [Out] Vector3 IDLICMBLPFF, [Out] Quaternion MHCEDPIIIGM);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface HNHOAKIDOJM
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFOBMEGHMMD(JJOLFCGDJOI ONHBEAIBAJA);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface LPFIJPDFBEC
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JNBPFCOODKC(GameObject IMEIKPMCLLA, GameObject FPHCOHLFEGE, int NEOBIHFFOEN);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface PIKLCFFHOBP
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	OIHKHPIFIAD KDJACBIMCHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	ILNPMLNECBH NGDPONDPLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	CBBAPEIKCEB FGDJFLANNKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	OGJHBDKANHE ALNEAKEPLOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	GFFHGMKHHDM MDABHPLLMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	EBLNIKNNOFF NOECMKNJKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	GKDABPNCCIE DEHOCPLNEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	ENPPLANPDEL DPEGLIMDIMK
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	JMIICAFGBDF IIIGFGBKACH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface CCFNABNMIHN
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NCIKHBNPCOK(Action HKIJJKKNOIF, bool GFBPKLFOHGH);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BAACKFOKJCO(string GKDOOPOCBPP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface ILNPMLNECBH
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string HBBOILGGPAE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] ABOGOCOOEOC(IEnumerable<FACMNNHGHFN> IPOPFDIMCBI);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IGOGNFNABEF(GameObject PACDKKMGCFJ, [Out] BHEOONDIPJK[] PEPGMDNCOKM);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IGELGNJGANP(GameObject PACDKKMGCFJ, [Out] int JHHPFDGPNFA, [Out] GAPHNGPGADD BHKMCAKMPKO);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PNBAEMMHAOF MALMOPKHCJI(FACMNNHGHFN ELBMMMMNOAO);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PNBAEMMHAOF MALMOPKHCJI(string GLBCDKMKLIG, BHEOONDIPJK[] POJEOJNHOEM, Vector3 DGOJEOCFHHN, Quaternion DMBBOEJIOJM, Vector3 LFNFJOFKAIK);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GameObject CDPAOHIPHBO(string GLBCDKMKLIG);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HJMPICIEPCA(GameObject HIHGEBEHOMJ, bool LPFEOFHGOJN);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FGEHGFENLMH(GameObject PACDKKMGCFJ, bool LKPCMPBDLLL, bool GMPKJHDPPBA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class KDJDCFJIOJF
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6427A40", Offset = "0x6426440", VA = "0x186427A40")]
	public static PNBAEMMHAOF MALMOPKHCJI(this ILNPMLNECBH NJALJHMFPEI, Vector3 DGOJEOCFHHN, Quaternion DMBBOEJIOJM, Vector3 LFNFJOFKAIK, params BHEOONDIPJK[] PEPGMDNCOKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface CBBAPEIKCEB
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBEGIIOPDHE(bool IHFMNOOBPFC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface OGJHBDKANHE
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool GHJEMFMGPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool DMPMMNCDIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool HFCJCHEKCDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	int MGNNIJGELIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool DDJJPMJOCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CLAIKHJNHOA(object PEFGDLBLMMP);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ECOBAFGDMEC(object PEFGDLBLMMP);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NNFKLBIPIGM(object PJDANIPAHEH);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LFBNIGOCBHN(object PJDANIPAHEH);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int HBHMOAIDDAM(GameObject BGNGBPICAOC);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NNHPPGLHGDK(NativeArray<int> LFEBABHLDCM);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FCAKHNMKDHM(NativeArray<int> ONKCIBFLMED);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LDJBHPDNOHP();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BOCMMLCEBBJ(uint BGEHONBPHFM, ReadOnlySpan<byte> BLNFHFEJACA, bool MOKAFBHPPFM = false);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BOCMMLCEBBJ(uint BGEHONBPHFM, ReadOnlySpan<byte> BLNFHFEJACA, ReadOnlySpan<byte> DODFHODOFHP, bool MOKAFBHPPFM = false);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface GFFHGMKHHDM
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFBJOENEIMF(GameObject PACDKKMGCFJ);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface EBILIHPFEKM
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IBFHABGPIKM(string CPPFNMDMGHI);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface MIBBDCGMILD
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PLNINEDPCNL(GameObject PACDKKMGCFJ);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKOJKPMNEHB(GameObject PACDKKMGCFJ);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GIMKNFNCKCP(int INOGMJCLNPP);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object GKFJCFEPFPH(MMBMADJJEAB OCMIGFBMBMB, GameObject PACDKKMGCFJ, Action<MMBMADJJEAB, int> JNDJHGKPENH);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BBIFNCGCMIO(GameObject PACDKKMGCFJ, object CNFHBHMMJIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface ABJCKIPLCKN
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool NNMJANJKAMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate PNDEJKJHAAB(ALDOMBMBCMK.KFPKDAKEGKH CMJNKAFKBHJ, Action<ALDOMBMBCMK.KFPKDAKEGKH> JNDJHGKPENH);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ANCAPCBBODP(ALDOMBMBCMK.KFPKDAKEGKH CMJNKAFKBHJ, Delegate JNDJHGKPENH);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate ALMACDIJMFA(ALDOMBMBCMK.KFPKDAKEGKH CMJNKAFKBHJ, Action<ALDOMBMBCMK.KFPKDAKEGKH> MCDLMONDFGF);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EFHNJICMCIM(ALDOMBMBCMK.KFPKDAKEGKH CMJNKAFKBHJ, Delegate JNDJHGKPENH);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IJNDOBJJHNI(ALDOMBMBCMK.KFPKDAKEGKH CMJNKAFKBHJ);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ALDOMBMBCMK.KFPKDAKEGKH CBIAJBGPINC(GameObject PACDKKMGCFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface EBLNIKNNOFF
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	int GLEHPLFEEOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	int JDBJECHCBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int CHCBNJNJMAF(GameObject PACDKKMGCFJ);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KOIKKPELLJC([Out] Vector3 DGOJEOCFHHN);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BFPIMLFAICJ();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface GKDABPNCCIE
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool PNGEGJODJJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool CGHIKCHIFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface DOOMGJDGKBF
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	BMHCNCJHKII NIDBBBBIPOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	KDMFOCPNFEJ KJDFICJFIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AJNNEFJHCKJ(Transform OEIDOHJNAOK);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OOLLOJGLBKO(Transform OEIDOHJNAOK, MNMFDBFBFJA PJOOCJADALP);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ACDACJLJNLO(Transform OEIDOHJNAOK, EFHPIJLIOIK EJPJPMIOAKL);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface ENPPLANPDEL
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DAMEMPACGJN();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface JMIICAFGBDF
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action NNDNBAGFPNO;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JEGAFOOLOOM(JJOLFCGDJOI APNPINEILHD, bool JGLFOIIEBAK);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface EOLCFJEAJCC
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BIMOMFLBFAC();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface BJNOODELNGC
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GAPHNGPGADD BGKOMBMDBKA(GameObject BGNGBPICAOC);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHGHIKHBCJB(GameObject PACDKKMGCFJ, GHGOCJLCCKJ LMLEJKMICOO, KDGNGEGHKGK LANIGIMEMHE);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string PGCCMECCEEH(int MCGNHGLIJDN);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int BBCDKOKHONI(string FGGJAMLKMFJ);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NNJNFEGGNOJ(MMBMADJJEAB OCMIGFBMBMB, int[] KAHJCFKMJIK);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JOCHMICPFGL(InteractionFilterData ABDLEBPKDKC, int OFMNGOBJEKH);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AHEPKEAMOJG(MMBMADJJEAB OCMIGFBMBMB, int KAHJCFKMJIK);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MHBFMEMPGEJ(MMBMADJJEAB OCMIGFBMBMB, int KAHJCFKMJIK);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FDNOOKOJLOF(MMBMADJJEAB OCMIGFBMBMB, bool AHHOJBKMNMA, float3 KMLPEOJAKGL, quaternion MJEDDCONDHD);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct FIJCDNIAMLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly LPJBAOIGPME HDAPKPHIPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly LPJBAOIGPME CIJJIBBMFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal readonly uint GCKOFFFGJBH;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6422280", Offset = "0x6420C80", VA = "0x186422280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct EPEHDMCANNA
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly LBNENDFDEJK EMEAPIGMNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly FIJCDNIAMLM HKIJJKKNOIF;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6421270", Offset = "0x641FC70", VA = "0x186421270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct OJNFHGOPPJP
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly LBNENDFDEJK EMEAPIGMNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly FIJCDNIAMLM HKIJJKKNOIF;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6421270", Offset = "0x641FC70", VA = "0x186421270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct FAMAIOBCJCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint GCKOFFFGJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly bool GNBJKMKOIOP;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6421910", Offset = "0x6420310", VA = "0x186421910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct LPJBAOIGPME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal int KNFIDNLGJFO;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x642A370", Offset = "0x6428D70", VA = "0x18642A370", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface AMBLDDMANNK
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	JLNANMIFCED MCFDNHBMDMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public enum EHGPGHGPHKL
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
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface PNBAEMMHAOF : AGOIJBKBBBC
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	HFKEOLHFCHL BHEGPEPPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	EHGPGHGPHKL PGBMHCDNOMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool ILDINDMNPME
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	GameObject PACDKKMGCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<PNBAEMMHAOF> NGKNDJLJJJN;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(COPBAAFFJOH GNMPCPCEMKG, MMBMADJJEAB OMINPEPNHJF);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool OHNPAPBNPIJ);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class AMNNCAPPCKK
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6419E10", Offset = "0x6418810", VA = "0x186419E10")]
	public static bool DMKKHJMNEEL(this PNBAEMMHAOF DKLOANBELPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6419EF0", Offset = "0x64188F0", VA = "0x186419EF0")]
	public static bool ELPNHGJAPJA(this PNBAEMMHAOF DKLOANBELPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6419F40", Offset = "0x6418940", VA = "0x186419F40")]
	public static bool IJEJGBPECKB(this PNBAEMMHAOF DKLOANBELPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6419E60", Offset = "0x6418860", VA = "0x186419E60")]
	public static bool DNNOPBKFOAJ(this PNBAEMMHAOF DKLOANBELPH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface AGOIJBKBBBC
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool CIENOIJGBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	MMBMADJJEAB BGGLMNANNIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[HGMHEGMFAAC(AKLDBHGLJNP.LoadInstance)]
internal interface CBAJAMPIJJG
{
	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<ABNLCLIOBGG> FPIOBDBICMI;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface FEDLEFMHMOG
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface KFPOIPODIAD
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(IHGKDIOHOHL LECHFDDPPOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface IHGKDIOHOHL
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	GameObject PACDKKMGCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	Transform OEIDOHJNAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	BGKFOFFDBCF KPIFBHLKNCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool DKANKFKPAML
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KNIMLEJFONN(BGKFOFFDBCF KGDPHHJJNLN);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface BGKFOFFDBCF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	MMBMADJJEAB BGGLMNANNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	Rigidbody POOBCMLELBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	IHGKDIOHOHL HDABIAIFIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	GameObject JKMOLLDKDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	Transform LJJCGBHAFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	BGKFOFFDBCF OCIMJODBDMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	BGKFOFFDBCF PCJLIOJLCMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	int OGNMMBAHNCH
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool IJNDOBJJHNI
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	bool EACCFBALNHB
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	KEGIGDFABJI NPEIHINPKOM
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "31")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	GJIGFONCOIL ELNOHMHCOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	float BGIOEPDEEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "35")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	Vector3 OIHIHNLLLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	Vector3 ANAGKNDCEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Vector3 FDLLPICOGHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 CBOMGOGEPHI
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	bool CEDGNNHPDFP
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	bool MPCJEDIBACP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	bool LAPOJFBCBHB
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	Vector3 IAKGHCODGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 HCALOFOLJOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Vector3 PGBEPMPOIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "50")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	Vector3 FGOOHHJNAIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float HNFBPHKMJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	float LADAJJHHKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 GEDNJPOJBNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Quaternion HHEPOOJKCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float APDNNPKAJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	float JGAGIKGBKMK
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	bool KHOANBPNIKG
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	OKAPGIDMLME GLFJHOPEKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	bool BNGHHFBGLAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Transform FCLFGALHMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Vector3 AIBDOKJKNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	float KCMMJBAEDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	float LKJBPNCMFLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Quaternion NLDEDKHADKF
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Vector3 BMNHEIGADNE
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Quaternion JGNDFHLFBKD
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	RigidbodyConstraints EBCHHJPEJPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool FDBNPEOBIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	CollisionDetectionMode LKBHNAHMPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	bool OIACFEKBPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event CLJCKLONOHI BJIOIJFOJBP;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event CLJCKLONOHI DPJFOMNMFGJ;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event CLJCKLONOHI KDCFGOKPIMG;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event CLJCKLONOHI LAIOPJDIFOC;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event CLJCKLONOHI BKCAALMFKGG;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event CLJCKLONOHI KHOLKLLCLIK;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event CLJCKLONOHI KLFKOBHMENA;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event OLMONNFPBFD JCBDPCJNBOI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<NGCLDJOGPMC, NGCLDJOGPMC> BJNHNPOFEEO;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	BGKFOFFDBCF NDAFDJIEKFK(int ABBNIPHGMGH);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void LBIDHDCCHFN((Quaternion rot, Vector3 moments) IIOBFIHKMKA);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void ADOMGPBBEKI();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void LINONLKPEJA();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void JKIOMGPKAMJ();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void FKGGGOAKKFI();

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void HADFEPOJAPP(BGKFOFFDBCF AEJBOLFACJC, bool NCHCLNHGGLP = false);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void FOEBIJPHJJJ(object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void IMPEAMEHLOH(object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 ABAJAMKFLOC(Vector3 EJPNFJPEMJC);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "95")]
	Vector3 GLHINNLNEJM(Vector3 BIIBBMJOAGE);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void AINBAPPNEND();

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void FNFLFILCDCB();

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void FLPNFDKEPED();

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void FKFBIOKHALP(Vector3 PCFNCEMBLII, Vector3 JDJIFNJBEPK);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void DJCKPOFCHOG(Vector3 LCOIJGMOGBI, Vector3 MCDLIMPJKBK);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void MEJCMJJNGAP(Vector3 OJFLAKENKHK);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void BFJMDJJMNGM(HFJBCEABLKK PKAFBMHMFIK, Vector3 OAEBAFNOOID, float JFGFKKKJALP, float BGKBBCAODHG = 8f, float LNEPLNANENF = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void BKIJAODPLKO(JICPGDJPMBL IAKHFJKEGIK, Vector3 EDDODGHDOCK, float NOGBLOAKKEM = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void OCKBMELOJNJ(JICPGDJPMBL IAKHFJKEGIK, Vector3 DMBBOEJIOJM, float OGMNDMHPDON = 7f, float AENPFKNAHJG = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "105")]
	Vector3 JHCACNAMEEL(Vector3 AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "106")]
	Vector3 GCAKDAIEHMO(Vector3 AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void PNMKOJELMAB();

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void HJJBINLBBCI(BGKFOFFDBCF EEDACFGPMMI, object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "109")]
	void LGFMBCFACKP(object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void MEIKPFPCEND();

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void CPBFJJKCNDF();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void DNFMDMLCDBL();

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "113")]
	bool IODNPBHJDNI();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void INLIEIBMNOL();

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void LFGJFDJEKON(object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "116")]
	void CFMMBGEIBIN(object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void GMPJPEGBADP(object AIDIDMJCFEK, bool PFAHELLLIJF);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void PGAPIICOCLF(Vector3 JDBMNCDPHAH, Quaternion LIPKGNFGFDK);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void KAAJFAFHMMP(Vector3 MOPEEKHJBPM, Quaternion GMLNFMGAOOI);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "120")]
	bool NJKBLPIDFPK(float BFAOHJDJGOF);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void IBEANELNEKL(object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void PFHJHANKBIH(object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void EIKEAHAJACC(object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void HEJIHGANKGN(object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void IOLAFBPFEMC(Vector3 AHPBABJEPBH, ForceMode CJPJJJBPAPC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void KCIPFGJCDLF(Vector3 AHPBABJEPBH, Vector3 DGOJEOCFHHN, ForceMode CJPJJJBPAPC);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void KJDDIPGEGOA(Vector3 CLENPCIPLGG, ForceMode CJPJJJBPAPC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void BOCDCMBKMJE(Vector3 CLENPCIPLGG, ForceMode CJPJJJBPAPC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "129")]
	bool CHGGLCJMIHC(Vector3 COKBJHHCBCI, [Out] RaycastHit AGDEAHCJKJG, float EHAOBONCKIL);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void EIDDFCDABLD();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface GJIGFONCOIL
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FIMEONFACOD(Vector3 HLFNEOMEHBN);

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FIPMDHEFNBJ(Vector3 CEBHPCKMGCF);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ACGAMPHLNKD(Vector3 HLFNEOMEHBN);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BIDNFAAFOKM(Vector3 CEBHPCKMGCF);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface KEGIGDFABJI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 BKEIKKAHGFA();

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 HBBAIEDHJIB();
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public delegate void CLJCKLONOHI(IHGKDIOHOHL KCKGLLPODHC);
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum OEPNINLFBID
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
[Cpp2IlInjected.Token(Token = "0x200003B")]
public enum HFJBCEABLKK
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
[Cpp2IlInjected.Token(Token = "0x200003C")]
public delegate void OLMONNFPBFD(IHGKDIOHOHL KCKGLLPODHC, bool NCHCLNHGGLP = false);
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum JICPGDJPMBL
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct JEHGHBKNBMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Rigidbody MAGECLDKLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object DJFIGOLNDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Vector3 IHPJGIMODNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Vector3 NPFKJJFNGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public JFKHEFJKEKA GACJJBDOHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public bool KKBHKNMPDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public bool BCODMNEKHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool MLGBIHHBPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public bool CCGAFMHONBI;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface BGFBMAMAINA : APJLGBGDILB<BHEOONDIPJK>, MPDJAPKPELI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface DKPOCHFPONK<T> : MCLFGODDOGC<BHEOONDIPJK, T>, APJLGBGDILB<BHEOONDIPJK>, MPDJAPKPELI, IDisposable, BGFBMAMAINA where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class AGNFOHAJMDL
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9650", Offset = "0x2AB8050", VA = "0x182AB9650")]
	public static bool NLEJDEABFNF<T>(this APJLGBGDILB<BHEOONDIPJK> DMJMLGBLOFK, BHEOONDIPJK POJEOJNHOEM, [Out] T AEJBOLFACJC) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x29A3930", Offset = "0x29A2330", VA = "0x1829A3930")]
	public static bool NPHNBOIFMNI<T>(this APJLGBGDILB<BHEOONDIPJK> DMJMLGBLOFK, BHEOONDIPJK POJEOJNHOEM, [In] T BCHBCOAIMKJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface MHOKDMFBKAD : APJLGBGDILB<MMBMADJJEAB>, MPDJAPKPELI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface GHPJCFCOAPK<T> : MCLFGODDOGC<MMBMADJJEAB, T>, APJLGBGDILB<MMBMADJJEAB>, MPDJAPKPELI, IDisposable, MHOKDMFBKAD where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class JNLBPECDIPI
{
	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2716AA0", Offset = "0x27154A0", VA = "0x182716AA0")]
	public static T OIFPBAJNOAG<T>(this APJLGBGDILB<MMBMADJJEAB> DMJMLGBLOFK, MMBMADJJEAB OCMIGFBMBMB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x29A3AA0", Offset = "0x29A24A0", VA = "0x1829A3AA0")]
	public static bool NPHNBOIFMNI<T>(this APJLGBGDILB<MMBMADJJEAB> DMJMLGBLOFK, MMBMADJJEAB OCMIGFBMBMB, [In] T BCHBCOAIMKJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct OIPBELAGDIB : IComparable<OIPBELAGDIB>, IEquatable<OIPBELAGDIB>
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly OIPBELAGDIB ENOPEJBDPMA;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly OIPBELAGDIB GFCPHFJBBPH;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly OIPBELAGDIB DKMLBCHNIGK;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly OIPBELAGDIB ONANBBIDLJL;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly OIPBELAGDIB CKMCLOFEGCN;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly OIPBELAGDIB MPGAGLHNNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public int JIFJFCOEJGO;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool CLIOPCNACCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x642B850", Offset = "0x642A250", VA = "0x18642B850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int HNLNBJIIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x642B760", Offset = "0x642A160", VA = "0x18642B760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x927740", Offset = "0x926140", VA = "0x180927740")]
	public OIPBELAGDIB(int ABBNIPHGMGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x642B7F0", Offset = "0x642A1F0", VA = "0x18642B7F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x642B770", Offset = "0x642A170", VA = "0x18642B770", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x8BB510", Offset = "0x8B9F10", VA = "0x1808BB510", Slot = "5")]
	public bool Equals(OIPBELAGDIB HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x18D5110", Offset = "0x18D3B10", VA = "0x1818D5110", Slot = "4")]
	public int CompareTo(OIPBELAGDIB HKMMPHJFKEA)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0xD7D0B0", Offset = "0xD7BAB0", VA = "0x180D7D0B0")]
	public static OIPBELAGDIB KHGGPLGKNCG(int ABBNIPHGMGH)
	{
		return default(OIPBELAGDIB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0xD7D0B0", Offset = "0xD7BAB0", VA = "0x180D7D0B0")]
	public static int KHGGPLGKNCG(OIPBELAGDIB LIJAEAOCHAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x642B860", Offset = "0x642A260", VA = "0x18642B860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct HFKEOLHFCHL : IEquatable<HFKEOLHFCHL>, AGOIJBKBBBC
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly HFKEOLHFCHL FCADOMHCKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly MMBMADJJEAB FPDMJJHHMMN;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public MMBMADJJEAB BGGLMNANNIP
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00", Slot = "6")]
		get
		{
			return default(MMBMADJJEAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public EDBDBECMNJC LJJCGBHAFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(EDBDBECMNJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public DEEDJPBLLLH KIOIPHAMENG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(DEEDJPBLLLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private PHDJGIJHHIJ ODHOLIFAOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x641B5F0", Offset = "0x6419FF0", VA = "0x18641B5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GameObject PACDKKMGCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6425980", Offset = "0x6424380", VA = "0x186425980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public BHEOONDIPJK DADCCMCPAHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x64251E0", Offset = "0x6423BE0", VA = "0x1864251E0")]
		get
		{
			return default(BHEOONDIPJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public ENJEGGGNAKF NIDCIKBJAMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x6425700", Offset = "0x6424100", VA = "0x186425700")]
		get
		{
			return default(ENJEGGGNAKF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public GAPHNGPGADD LLIEGJIDOBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6425510", Offset = "0x6423F10", VA = "0x186425510")]
		get
		{
			return default(GAPHNGPGADD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool DMGDDFFLLHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6425960", Offset = "0x6424360", VA = "0x186425960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool NFJEIHNDDDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x64255B0", Offset = "0x6423FB0", VA = "0x1864255B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool BEPEOIEHCJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6425280", Offset = "0x6423C80", VA = "0x186425280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool PEABNMFPFNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6425920", Offset = "0x6424320", VA = "0x186425920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool DNCLGFGCLMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x64252A0", Offset = "0x6423CA0", VA = "0x1864252A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool JLCJGBHBABE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6425460", Offset = "0x6423E60", VA = "0x186425460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool GHHLEEHIHGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x64254D0", Offset = "0x6423ED0", VA = "0x1864254D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool PCDGJIHFPAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6425890", Offset = "0x6424290", VA = "0x186425890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool OMAIKOJBJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6425940", Offset = "0x6424340", VA = "0x186425940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public JLGIBIJBHEP EAMLBAHMLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(JLGIBIJBHEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public FCEOJPMAFFC HNNHCFMLPJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(FCEOJPMAFFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public IKGMHLMPIAJ HJMPNLCGDLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(IKGMHLMPIAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public DJKHFDPDDJP GMKKCFLGNCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(DJKHFDPDDJP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public LNCFFMIOJHK EEOOAFACPNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(LNCFFMIOJHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public PNPHDFBNKJL FOAEPHGHFCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(PNPHDFBNKJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public IADANDIMIEH PCNBHBFMIJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(IADANDIMIEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public DCFJLEBNLBJ NCNBCMHDFEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(DCFJLEBNLBJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public KMFIKKEMJDI CMGKOOKJFDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(KMFIKKEMJDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public GJLJJAKOHMG NMDJKMGOOLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(GJLJJAKOHMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public LAJHAAIEOJE IEJJJLPJDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(LAJHAAIEOJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool DMKKHJMNEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x64252C0", Offset = "0x6423CC0", VA = "0x1864252C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool GPEKKLLHNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6425100", Offset = "0x6423B00", VA = "0x186425100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool NOGOOGLKKNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x64255D0", Offset = "0x6423FD0", VA = "0x1864255D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	private bool AEOEDKOMPLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7DD630", Offset = "0x7DC030", VA = "0x1807DD630", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420")]
	public HFKEOLHFCHL(MMBMADJJEAB OCMIGFBMBMB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x641B0D0", Offset = "0x6419AD0", VA = "0x18641B0D0")]
	public static bool KHGGPLGKNCG(HFKEOLHFCHL AEJBOLFACJC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x830920", Offset = "0x82F320", VA = "0x180830920")]
	public static MMBMADJJEAB KHGGPLGKNCG(HFKEOLHFCHL AEJBOLFACJC)
	{
		return default(MMBMADJJEAB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x641B650", Offset = "0x641A050", VA = "0x18641B650")]
	public static bool PIEEFOPMNNK(HFKEOLHFCHL LMANHAAPNDE, HFKEOLHFCHL AMHFHPBEBNM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x64253B0", Offset = "0x6423DB0", VA = "0x1864253B0")]
	public static bool EGKBPOJOPJH(HFKEOLHFCHL LMANHAAPNDE, HFKEOLHFCHL AMHFHPBEBNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x641ACC0", Offset = "0x64196C0", VA = "0x18641ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x64253D0", Offset = "0x6423DD0", VA = "0x1864253D0", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x641ACB0", Offset = "0x64196B0", VA = "0x18641ACB0", Slot = "4")]
	public bool Equals(HFKEOLHFCHL HKMMPHJFKEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x830920", Offset = "0x82F320", VA = "0x180830920")]
	public static HFKEOLHFCHL KHGGPLGKNCG(MMBMADJJEAB FPDMJJHHMMN)
	{
		return default(HFKEOLHFCHL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6425080", Offset = "0x6423A80", VA = "0x186425080")]
	public GNLNDIGCDIO APEHMNJMJLO()
	{
		return default(GNLNDIGCDIO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x64254A0", Offset = "0x6423EA0", VA = "0x1864254A0")]
	public MAOIGGAPMIH GGCEDOEOEEH()
	{
		return default(MAOIGGAPMIH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x64258D0", Offset = "0x64242D0", VA = "0x1864258D0")]
	public FONNMPGGNBM NOHDAGDLLEG()
	{
		return default(FONNMPGGNBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6425140", Offset = "0x6423B40", VA = "0x186425140")]
	public void BNHCCGLIIAO([Optional] object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x64257A0", Offset = "0x64241A0", VA = "0x1864257A0")]
	public bool MOHHOHPFDNH(object AIDIDMJCFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6425610", Offset = "0x6424010", VA = "0x186425610")]
	public bool MCDLHCANPKK(object AIDIDMJCFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6425B10", Offset = "0x6424510", VA = "0x186425B10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct IADANDIMIEH : IEquatable<IADANDIMIEH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly MMBMADJJEAB FPDMJJHHMMN;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public MMBMADJJEAB BGGLMNANNIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(MMBMADJJEAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public HFKEOLHFCHL BHEGPEPPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private PHDJGIJHHIJ ODHOLIFAOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x641B5F0", Offset = "0x6419FF0", VA = "0x18641B5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private KHGNHJPOKLJ DLFOJMPEOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6425BF0", Offset = "0x64245F0", VA = "0x186425BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	private NFMDLGENFJM HGGOFABADJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6425EC0", Offset = "0x64248C0", VA = "0x186425EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool DPONAONLEBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6425F20", Offset = "0x6424920", VA = "0x186425F20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Guid ECHGILGCMHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6426050", Offset = "0x6424A50", VA = "0x186426050")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool LLJIIIMGEGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6425DA0", Offset = "0x64247A0", VA = "0x186425DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public Guid MDCEAGJAKAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6426170", Offset = "0x6424B70", VA = "0x186426170")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420")]
	public IADANDIMIEH(MMBMADJJEAB OCMIGFBMBMB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x641B0D0", Offset = "0x6419AD0", VA = "0x18641B0D0")]
	public static bool KHGGPLGKNCG(IADANDIMIEH AEJBOLFACJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x641ACC0", Offset = "0x64196C0", VA = "0x18641ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6425E30", Offset = "0x6424830", VA = "0x186425E30", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x641ACB0", Offset = "0x64196B0", VA = "0x18641ACB0", Slot = "4")]
	public bool Equals(IADANDIMIEH HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x641B660", Offset = "0x641A060", VA = "0x18641B660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6426440", Offset = "0x6424E40", VA = "0x186426440")]
	public bool PNEJFNAENOB([Out] Guid NINCGKAKJEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6425C80", Offset = "0x6424680", VA = "0x186425C80")]
	public void CLCOHHMLNEJ(Guid OONFDHNBOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6425FB0", Offset = "0x64249B0", VA = "0x186425FB0")]
	public bool NADKDHADHIB([Out] Guid BKJEPPHMINA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6426290", Offset = "0x6424C90", VA = "0x186426290")]
	public void OLDOLGDKEGC(Guid OONFDHNBOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x64263B0", Offset = "0x6424DB0", VA = "0x1864263B0")]
	public void ONNNMFHPHEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct FONNMPGGNBM : IEquatable<FONNMPGGNBM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly MMBMADJJEAB FPDMJJHHMMN;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public MMBMADJJEAB BGGLMNANNIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(MMBMADJJEAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public HFKEOLHFCHL BHEGPEPPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private PHDJGIJHHIJ ODHOLIFAOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x641B5F0", Offset = "0x6419FF0", VA = "0x18641B5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private KHGNHJPOKLJ DLFOJMPEOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x64227C0", Offset = "0x64211C0", VA = "0x1864227C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private JBLMOBBNPEC MAEEKPBLIFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6422AB0", Offset = "0x64214B0", VA = "0x186422AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public Vector3 GNKIAIBFDLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6422670", Offset = "0x6421070", VA = "0x186422670")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Quaternion MKHJLPIKIMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6422970", Offset = "0x6421370", VA = "0x186422970")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public HFKEOLHFCHL APCGGGLKFHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6422850", Offset = "0x6421250", VA = "0x186422850")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420")]
	public FONNMPGGNBM(MMBMADJJEAB OCMIGFBMBMB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x830920", Offset = "0x82F320", VA = "0x180830920")]
	public static MMBMADJJEAB KHGGPLGKNCG(FONNMPGGNBM AEJBOLFACJC)
	{
		return default(MMBMADJJEAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x641ACC0", Offset = "0x64196C0", VA = "0x18641ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x64228E0", Offset = "0x64212E0", VA = "0x1864228E0", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x641ACB0", Offset = "0x64196B0", VA = "0x18641ACB0", Slot = "4")]
	public bool Equals(FONNMPGGNBM HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x641B660", Offset = "0x641A060", VA = "0x18641B660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct GNLNDIGCDIO : IEquatable<GNLNDIGCDIO>
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly GNLNDIGCDIO FCADOMHCKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly MMBMADJJEAB FPDMJJHHMMN;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public MMBMADJJEAB BGGLMNANNIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(MMBMADJJEAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public HFKEOLHFCHL BHEGPEPPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public EDBDBECMNJC LJJCGBHAFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(EDBDBECMNJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public DEEDJPBLLLH KIOIPHAMENG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(DEEDJPBLLLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private PHDJGIJHHIJ ODHOLIFAOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x641B5F0", Offset = "0x6419FF0", VA = "0x18641B5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private KHGNHJPOKLJ DLFOJMPEOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6422FF0", Offset = "0x64219F0", VA = "0x186422FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private NKGGJAMICIA DKLMHCEHFCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x64249E0", Offset = "0x64233E0", VA = "0x1864249E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public JJOLFCGDJOI HHAEINAOEDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x6424920", Offset = "0x6423320", VA = "0x186424920")]
		get
		{
			return default(JJOLFCGDJOI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public IEnumerable<HFKEOLHFCHL> PFDJACJHAON
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6423F40", Offset = "0x6422940", VA = "0x186423F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public IEnumerable<HFKEOLHFCHL> POKLBGBCCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x6423580", Offset = "0x6421F80", VA = "0x186423580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int OGNMMBAHNCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x6423390", Offset = "0x6421D90", VA = "0x186423390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public int ABHLHNMDACH
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6423190", Offset = "0x6421B90", VA = "0x186423190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public string HAKLMNHDJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x6424700", Offset = "0x6423100", VA = "0x186424700")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x64244B0", Offset = "0x6422EB0", VA = "0x1864244B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public DLCDNFGOMIH IPJHODCHOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6424180", Offset = "0x6422B80", VA = "0x186424180")]
		get
		{
			return default(DLCDNFGOMIH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6423510", Offset = "0x6421F10", VA = "0x186423510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public KEGOHNGKILF HIJCGBIPHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x64245D0", Offset = "0x6422FD0", VA = "0x1864245D0")]
		get
		{
			return default(KEGOHNGKILF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x64231E0", Offset = "0x6421BE0", VA = "0x1864231E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public GDIPAJDEFOF NDCFKCGGGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6423EE0", Offset = "0x64228E0", VA = "0x186423EE0")]
		get
		{
			return default(GDIPAJDEFOF);
		}
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6424630", Offset = "0x6423030", VA = "0x186424630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public float MIFHHFFMMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6424120", Offset = "0x6422B20", VA = "0x186424120")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6423E70", Offset = "0x6422870", VA = "0x186423E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool FAIBMNIIIHF
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x64247B0", Offset = "0x64231B0", VA = "0x1864247B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6424560", Offset = "0x6422F60", VA = "0x186424560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool EDAFIIEPDIC
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6423A90", Offset = "0x6422490", VA = "0x186423A90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x64234A0", Offset = "0x6421EA0", VA = "0x1864234A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool CDLOCCOBHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6423250", Offset = "0x6421C50", VA = "0x186423250")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x64236B0", Offset = "0x64220B0", VA = "0x1864236B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool OKMEMLAHCME
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x64246A0", Offset = "0x64230A0", VA = "0x1864246A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x64240B0", Offset = "0x6422AB0", VA = "0x1864240B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool DOMIPLDNNLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6422F90", Offset = "0x6421990", VA = "0x186422F90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6423D10", Offset = "0x6422710", VA = "0x186423D10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool GIILOEBIGGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6423440", Offset = "0x6421E40", VA = "0x186423440")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6423AF0", Offset = "0x64224F0", VA = "0x186423AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool BPPGIGOGNKC
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6423E10", Offset = "0x6422810", VA = "0x186423E10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x64248B0", Offset = "0x64232B0", VA = "0x1864248B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public DCBCIIIJMJG LIAEHDCIHBK
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6423330", Offset = "0x6421D30", VA = "0x186423330")]
		get
		{
			return default(DCBCIIIJMJG);
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6424440", Offset = "0x6422E40", VA = "0x186424440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public IEnumerable<int> IDPLLKCLHDL
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x6424810", Offset = "0x6423210", VA = "0x186424810")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x64241E0", Offset = "0x6422BE0", VA = "0x1864241E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public int FKPPGGHLDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x64230F0", Offset = "0x6421AF0", VA = "0x1864230F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420")]
	public GNLNDIGCDIO(MMBMADJJEAB OCMIGFBMBMB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x641B0D0", Offset = "0x6419AD0", VA = "0x18641B0D0")]
	public static bool KHGGPLGKNCG(GNLNDIGCDIO AEJBOLFACJC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x641B650", Offset = "0x641A050", VA = "0x18641B650")]
	public static bool PIEEFOPMNNK(GNLNDIGCDIO LMANHAAPNDE, GNLNDIGCDIO AMHFHPBEBNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x641ACC0", Offset = "0x64196C0", VA = "0x18641ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6423D80", Offset = "0x6422780", VA = "0x186423D80", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x641ACB0", Offset = "0x64196B0", VA = "0x18641ACB0", Slot = "4")]
	public bool Equals(GNLNDIGCDIO HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x641B660", Offset = "0x641A060", VA = "0x18641B660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x830920", Offset = "0x82F320", VA = "0x180830920")]
	public static HFKEOLHFCHL KHGGPLGKNCG(GNLNDIGCDIO CMJEIEIDHIK)
	{
		return default(HFKEOLHFCHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6423420", Offset = "0x6421E20", VA = "0x186423420")]
	public bool CMBEDJBJLKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6423080", Offset = "0x6421A80", VA = "0x186423080")]
	public bool BEIGMEPANIE(NIDCEBJLBCC JEMLOLBMJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x64232B0", Offset = "0x6421CB0", VA = "0x1864232B0")]
	public void CFAKDEIPAKE(NIDCEBJLBCC JEMLOLBMJHM, bool AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6423B60", Offset = "0x6422560", VA = "0x186423B60")]
	public JJOLFCGDJOI EKNFMAAMPFE(Allocator IMPJLMNPHBC)
	{
		return default(JJOLFCGDJOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6423720", Offset = "0x6422120", VA = "0x186423720")]
	public void DKLIDBOMCHM(GNLNDIGCDIO HKMMPHJFKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6424A40", Offset = "0x6423440", VA = "0x186424A40")]
	public void PNPIFLGCCII(List<HFKEOLHFCHL> EKFIDHAJPFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct KNKKNPBMIAE : IEquatable<KNKKNPBMIAE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly MMBMADJJEAB FPDMJJHHMMN;

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public HFKEOLHFCHL BHEGPEPPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x641ACC0", Offset = "0x64196C0", VA = "0x18641ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6429270", Offset = "0x6427C70", VA = "0x186429270", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x641ACB0", Offset = "0x64196B0", VA = "0x18641ACB0", Slot = "4")]
	public bool Equals(KNKKNPBMIAE HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x641B660", Offset = "0x641A060", VA = "0x18641B660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct FCEOJPMAFFC : IEquatable<FCEOJPMAFFC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly MMBMADJJEAB FPDMJJHHMMN;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public HFKEOLHFCHL BHEGPEPPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	private PHDJGIJHHIJ ODHOLIFAOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x641B5F0", Offset = "0x6419FF0", VA = "0x18641B5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420")]
	public FCEOJPMAFFC(MMBMADJJEAB OCMIGFBMBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x641ACC0", Offset = "0x64196C0", VA = "0x18641ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x64219B0", Offset = "0x64203B0", VA = "0x1864219B0", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x641ACB0", Offset = "0x64196B0", VA = "0x18641ACB0", Slot = "4")]
	public bool Equals(FCEOJPMAFFC HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x641B660", Offset = "0x641A060", VA = "0x18641B660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6421B80", Offset = "0x6420580", VA = "0x186421B80")]
	public void KDNFCEDEOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6421A40", Offset = "0x6420440", VA = "0x186421A40")]
	public void FMNMEJHCNFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6421AE0", Offset = "0x64204E0", VA = "0x186421AE0")]
	public bool HMNDFDEOCBP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct DEEDJPBLLLH : IEquatable<DEEDJPBLLLH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly MMBMADJJEAB FPDMJJHHMMN;

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public MMBMADJJEAB BGGLMNANNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(MMBMADJJEAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public HFKEOLHFCHL BHEGPEPPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private PHDJGIJHHIJ ODHOLIFAOMH
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x641B5F0", Offset = "0x6419FF0", VA = "0x18641B5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	private KHGNHJPOKLJ DLFOJMPEOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x641CFA0", Offset = "0x641B9A0", VA = "0x18641CFA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private NKGGJAMICIA DKLMHCEHFCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x641D850", Offset = "0x641C250", VA = "0x18641D850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public MMBMADJJEAB CCJDBBLHBDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x641D1E0", Offset = "0x641BBE0", VA = "0x18641D1E0")]
		get
		{
			return default(MMBMADJJEAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public HFKEOLHFCHL OCIMJODBDMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x641CF10", Offset = "0x641B910", VA = "0x18641CF10")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public HFKEOLHFCHL PCJLIOJLCMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x641D3A0", Offset = "0x641BDA0", VA = "0x18641D3A0")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420")]
	public DEEDJPBLLLH(MMBMADJJEAB OCMIGFBMBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x641ACC0", Offset = "0x64196C0", VA = "0x18641ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x641D030", Offset = "0x641BA30", VA = "0x18641D030", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x641ACB0", Offset = "0x64196B0", VA = "0x18641ACB0", Slot = "4")]
	public bool Equals(DEEDJPBLLLH HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x641B660", Offset = "0x641A060", VA = "0x18641B660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x641D270", Offset = "0x641BC70", VA = "0x18641D270")]
	public bool HADFEPOJAPP(HFKEOLHFCHL HHJLJBMAMDD, bool MNECKBBNCCM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x641D750", Offset = "0x641C150", VA = "0x18641D750")]
	public bool OAPKGKILNNE(HFKEOLHFCHL IMKPNBLFMEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x641D430", Offset = "0x641BE30", VA = "0x18641D430")]
	private void IMBCJCEFNNF(HFKEOLHFCHL EHDCBPMBGFL, List<HFKEOLHFCHL> NLKPFKCMDDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x641D6C0", Offset = "0x641C0C0", VA = "0x18641D6C0")]
	public GNLNDIGCDIO KCNAPCPKJKK()
	{
		return default(GNLNDIGCDIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x641D7F0", Offset = "0x641C1F0", VA = "0x18641D7F0")]
	public void OHGIBNOGMPI(List<HFKEOLHFCHL> OPIEDJGFJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x641D0C0", Offset = "0x641BAC0", VA = "0x18641D0C0")]
	public NativeArray<MMBMADJJEAB> FIKPEJOGGGC()
	{
		return default(NativeArray<MMBMADJJEAB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct JLGIBIJBHEP : IEquatable<JLGIBIJBHEP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly MMBMADJJEAB FPDMJJHHMMN;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public HFKEOLHFCHL BHEGPEPPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public string BMEHLGDELKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x64272F0", Offset = "0x6425CF0", VA = "0x1864272F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public string MBJGIPPGLBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x64274B0", Offset = "0x6425EB0", VA = "0x1864274B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool HICLCPADDKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x6427370", Offset = "0x6425D70", VA = "0x186427370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public string GGECHJJGNOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x6427580", Offset = "0x6425F80", VA = "0x186427580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public string AICBDHBPAGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x6427670", Offset = "0x6426070", VA = "0x186427670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public string EFHEKPOGNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x64278C0", Offset = "0x64262C0", VA = "0x1864278C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420")]
	public JLGIBIJBHEP(MMBMADJJEAB OCMIGFBMBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x641ACC0", Offset = "0x64196C0", VA = "0x18641ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6427260", Offset = "0x6425C60", VA = "0x186427260", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x641ACB0", Offset = "0x64196B0", VA = "0x18641ACB0", Slot = "4")]
	public bool Equals(JLGIBIJBHEP HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x641B660", Offset = "0x641A060", VA = "0x18641B660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct IJHHEMDNLCO : IEquatable<IJHHEMDNLCO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly MMBMADJJEAB FPDMJJHHMMN;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public HFKEOLHFCHL BHEGPEPPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x641ACC0", Offset = "0x64196C0", VA = "0x18641ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6426700", Offset = "0x6425100", VA = "0x186426700", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x641ACB0", Offset = "0x64196B0", VA = "0x18641ACB0", Slot = "4")]
	public bool Equals(IJHHEMDNLCO HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x641B660", Offset = "0x641A060", VA = "0x18641B660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct IKGMHLMPIAJ : IEquatable<IKGMHLMPIAJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly MMBMADJJEAB FPDMJJHHMMN;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public HFKEOLHFCHL BHEGPEPPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420")]
	public IKGMHLMPIAJ(MMBMADJJEAB OCMIGFBMBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x641ACC0", Offset = "0x64196C0", VA = "0x18641ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6426900", Offset = "0x6425300", VA = "0x186426900", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x641ACB0", Offset = "0x64196B0", VA = "0x18641ACB0", Slot = "4")]
	public bool Equals(IKGMHLMPIAJ HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x641B660", Offset = "0x641A060", VA = "0x18641B660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6426790", Offset = "0x6425190", VA = "0x186426790")]
	public bool BACHGEJJDHP([Out] Collider INFBHHFPGMA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct GJLJJAKOHMG : IEquatable<GJLJJAKOHMG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly MMBMADJJEAB FPDMJJHHMMN;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public MMBMADJJEAB BGGLMNANNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(MMBMADJJEAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public HFKEOLHFCHL BHEGPEPPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private IOOAHMGANFD AJNINFCDJMP
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6422CF0", Offset = "0x64216F0", VA = "0x186422CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420")]
	public GJLJJAKOHMG(MMBMADJJEAB OCMIGFBMBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x641ACC0", Offset = "0x64196C0", VA = "0x18641ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6422C60", Offset = "0x6421660", VA = "0x186422C60", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x641ACB0", Offset = "0x64196B0", VA = "0x18641ACB0", Slot = "4")]
	public bool Equals(GJLJJAKOHMG HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x641B660", Offset = "0x641A060", VA = "0x18641B660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6422DB0", Offset = "0x64217B0", VA = "0x186422DB0")]
	public void OEJNJANEHDI(bool MMANADCOJJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct DJKHFDPDDJP : IEquatable<DJKHFDPDDJP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly MMBMADJJEAB FPDMJJHHMMN;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public MMBMADJJEAB BGGLMNANNIP
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(MMBMADJJEAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public HFKEOLHFCHL BHEGPEPPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private PHDJGIJHHIJ ODHOLIFAOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x641B5F0", Offset = "0x6419FF0", VA = "0x18641B5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private KHGNHJPOKLJ DLFOJMPEOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x641D9F0", Offset = "0x641C3F0", VA = "0x18641D9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private ObjectPolicyDataWrapper OBPHLNIAKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x641E1F0", Offset = "0x641CBF0", VA = "0x18641E1F0")]
		get
		{
			return default(ObjectPolicyDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private NavMeshGenerationDataWrapper FIPBAJLMBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x641E470", Offset = "0x641CE70", VA = "0x18641E470")]
		get
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public bool JDKHKDKMIAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x641E6F0", Offset = "0x641D0F0", VA = "0x18641E6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool JAJMAFCBLNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x641DA80", Offset = "0x641C480", VA = "0x18641DA80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public bool CFMLCKJLOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x641E680", Offset = "0x641D080", VA = "0x18641E680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public bool EJLKJPNFLFN
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x641E120", Offset = "0x641CB20", VA = "0x18641E120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool PKAJKMDLCHF
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x641E0B0", Offset = "0x641CAB0", VA = "0x18641E0B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public bool GLGDPBCHJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x641E340", Offset = "0x641CD40", VA = "0x18641E340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public bool MPHOPMLHGNO
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x641E950", Offset = "0x641D350", VA = "0x18641E950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public bool BOFBJMIDGID
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x641DB60", Offset = "0x641C560", VA = "0x18641DB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool FCHNFOIHICO
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x641E4D0", Offset = "0x641CED0", VA = "0x18641E4D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public bool KCHLCDHJAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x641E610", Offset = "0x641D010", VA = "0x18641E610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public bool APGMAGFJADN
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x641E8E0", Offset = "0x641D2E0", VA = "0x18641E8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public bool ELGGOFCBKAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x641DBD0", Offset = "0x641C5D0", VA = "0x18641DBD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool NHICECMLBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x641DAF0", Offset = "0x641C4F0", VA = "0x18641DAF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool LOPCBAOOCCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x641E190", Offset = "0x641CB90", VA = "0x18641E190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public bool EBIEGCHLDMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x641E5B0", Offset = "0x641CFB0", VA = "0x18641E5B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x641DD30", Offset = "0x641C730", VA = "0x18641DD30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public AFFJPNLCPBK CCHFKFJDBJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x641DC40", Offset = "0x641C640", VA = "0x18641DC40")]
		get
		{
			return default(AFFJPNLCPBK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x641DE70", Offset = "0x641C870", VA = "0x18641DE70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public bool JCIODJGBFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x641DEE0", Offset = "0x641C8E0", VA = "0x18641DEE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public KDGNGEGHKGK BADIOFFLJEP
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x641D990", Offset = "0x641C390", VA = "0x18641D990")]
		get
		{
			return default(KDGNGEGHKGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public bool KOCKKAMPDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x641DDA0", Offset = "0x641C7A0", VA = "0x18641DDA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 MLMIHINFNIA
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x641E3B0", Offset = "0x641CDB0", VA = "0x18641E3B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 CKNPFBJLOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x641E730", Offset = "0x641D130", VA = "0x18641E730")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool APJOPCNENNE
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x641E7E0", Offset = "0x641D1E0", VA = "0x18641E7E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420")]
	public DJKHFDPDDJP(MMBMADJJEAB OCMIGFBMBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x641ACC0", Offset = "0x64196C0", VA = "0x18641ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x641DCA0", Offset = "0x641C6A0", VA = "0x18641DCA0", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x641ACB0", Offset = "0x64196B0", VA = "0x18641ACB0", Slot = "4")]
	public bool Equals(DJKHFDPDDJP HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x641B660", Offset = "0x641A060", VA = "0x18641B660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x641E540", Offset = "0x641CF40", VA = "0x18641E540")]
	public bool LANGAPJIPGD(OAAKBKFLAII JEMLOLBMJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x641E250", Offset = "0x641CC50", VA = "0x18641E250")]
	public bool JHINBBAGMII(GHGOCJLCCKJ JEMLOLBMJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x641E2C0", Offset = "0x641CCC0", VA = "0x18641E2C0")]
	public void JJHMMCPBLKH(GHGOCJLCCKJ JEMLOLBMJHM, bool EPKGBANDAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x641D930", Offset = "0x641C330", VA = "0x18641D930")]
	public GHGOCJLCCKJ AFHIKMGBPIO()
	{
		return default(GHGOCJLCCKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x641DE00", Offset = "0x641C800", VA = "0x18641DE00")]
	public bool FKJMLFMODNN(GHGOCJLCCKJ AEJBOLFACJC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct PNPHDFBNKJL : IEquatable<PNPHDFBNKJL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly MMBMADJJEAB FPDMJJHHMMN;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public MMBMADJJEAB BGGLMNANNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(MMBMADJJEAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public HFKEOLHFCHL BHEGPEPPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	private PHDJGIJHHIJ ODHOLIFAOMH
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x641B5F0", Offset = "0x6419FF0", VA = "0x18641B5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	private KHGNHJPOKLJ DLFOJMPEOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x642BB90", Offset = "0x642A590", VA = "0x18642BB90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420")]
	public PNPHDFBNKJL(MMBMADJJEAB OCMIGFBMBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x641ACC0", Offset = "0x64196C0", VA = "0x18641ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x642BC20", Offset = "0x642A620", VA = "0x18642BC20", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x641ACB0", Offset = "0x64196B0", VA = "0x18641ACB0", Slot = "4")]
	public bool Equals(PNPHDFBNKJL HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x641B660", Offset = "0x641A060", VA = "0x18641B660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x642BCB0", Offset = "0x642A6B0", VA = "0x18642BCB0")]
	public void GEMDADLKEPN(bool AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x642BD40", Offset = "0x642A740", VA = "0x18642BD40")]
	public void PHCGJIGAGNC(bool AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7390", Offset = "0x2AD5D90", VA = "0x182AD7390")]
	public T HBHJBPGKEDI<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct LAJHAAIEOJE : IEquatable<LAJHAAIEOJE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly MMBMADJJEAB FPDMJJHHMMN;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public MMBMADJJEAB BGGLMNANNIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(MMBMADJJEAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public HFKEOLHFCHL BHEGPEPPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private PHDJGIJHHIJ ODHOLIFAOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x641B5F0", Offset = "0x6419FF0", VA = "0x18641B5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private KHGNHJPOKLJ DLFOJMPEOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6429300", Offset = "0x6427D00", VA = "0x186429300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	private DBJOIANBJFL IOJDBCNIHLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6429540", Offset = "0x6427F40", VA = "0x186429540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool BGGLJNHEOGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x64294B0", Offset = "0x6427EB0", VA = "0x1864294B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool KDINANHBBJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6429390", Offset = "0x6427D90", VA = "0x186429390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420")]
	public LAJHAAIEOJE(MMBMADJJEAB OCMIGFBMBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x641ACC0", Offset = "0x64196C0", VA = "0x18641ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6429420", Offset = "0x6427E20", VA = "0x186429420", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x641ACB0", Offset = "0x64196B0", VA = "0x18641ACB0", Slot = "4")]
	public bool Equals(LAJHAAIEOJE HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x641B660", Offset = "0x641A060", VA = "0x18641B660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct LNCFFMIOJHK : IEquatable<LNCFFMIOJHK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly MMBMADJJEAB FPDMJJHHMMN;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public MMBMADJJEAB BGGLMNANNIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(MMBMADJJEAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public HFKEOLHFCHL BHEGPEPPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	private PHDJGIJHHIJ ODHOLIFAOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x641B5F0", Offset = "0x6419FF0", VA = "0x18641B5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	private KHGNHJPOKLJ DLFOJMPEOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x64296B0", Offset = "0x64280B0", VA = "0x1864296B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private FGLCBFOPBJF KMCHCICIDEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x6429D80", Offset = "0x6428780", VA = "0x186429D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	private IHFJFJMCELM FKGJKCAEGNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x6429A60", Offset = "0x6428460", VA = "0x186429A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public bool ELGDMHDBHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x6429CF0", Offset = "0x64286F0", VA = "0x186429CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public bool OPLHDONNNAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x6429DE0", Offset = "0x64287E0", VA = "0x186429DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public bool AJEHKNGMJKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x642A120", Offset = "0x6428B20", VA = "0x18642A120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public bool ADHBMKANGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6429AC0", Offset = "0x64284C0", VA = "0x186429AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public bool FKOFIHHJJKF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6429C20", Offset = "0x6428620", VA = "0x186429C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool PCCKDPLDFNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x642A090", Offset = "0x6428A90", VA = "0x18642A090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool LFOPHIKMCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6429E80", Offset = "0x6428880", VA = "0x186429E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public bool JPEFMDENOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6429740", Offset = "0x6428140", VA = "0x186429740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420")]
	public LNCFFMIOJHK(MMBMADJJEAB OCMIGFBMBMB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x641B0D0", Offset = "0x6419AD0", VA = "0x18641B0D0")]
	public static bool KHGGPLGKNCG(LNCFFMIOJHK AEJBOLFACJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x641ACC0", Offset = "0x64196C0", VA = "0x18641ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6429B90", Offset = "0x6428590", VA = "0x186429B90", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x641ACB0", Offset = "0x64196B0", VA = "0x18641ACB0", Slot = "4")]
	public bool Equals(LNCFFMIOJHK HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x641B660", Offset = "0x641A060", VA = "0x18641B660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x642A300", Offset = "0x6428D00", VA = "0x18642A300")]
	public bool PFJEKMFGKGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x64299C0", Offset = "0x64283C0", VA = "0x1864299C0")]
	public HFKEOLHFCHL BKNDFHLICEJ(HFKEOLHFCHL PJDANIPAHEH)
	{
		return default(HFKEOLHFCHL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x642A150", Offset = "0x6428B50", VA = "0x18642A150")]
	public MMBMADJJEAB PAKOLBFOPIF()
	{
		return default(MMBMADJJEAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6429C50", Offset = "0x6428650", VA = "0x186429C50")]
	public bool GLMJGJODMCH(MMBMADJJEAB OHBDJCHLCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x642A260", Offset = "0x6428C60", VA = "0x18642A260")]
	public bool PCJEEGNHECF(MMBMADJJEAB IONHNEHOGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x64298B0", Offset = "0x64282B0", VA = "0x1864298B0")]
	public bool BHGOKLBCAIG(MMBMADJJEAB PJDANIPAHEH, [Out] MMBMADJJEAB OHBDJCHLCLK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct MAOIGGAPMIH : IEquatable<MAOIGGAPMIH>
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly MAOIGGAPMIH FCADOMHCKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly MMBMADJJEAB FPDMJJHHMMN;

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public MMBMADJJEAB BGGLMNANNIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(MMBMADJJEAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public HFKEOLHFCHL BHEGPEPPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public EDBDBECMNJC LJJCGBHAFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(EDBDBECMNJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public DEEDJPBLLLH KIOIPHAMENG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(DEEDJPBLLLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private ShapeTypeDataWrapper DNFPNNKIJPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x642AC50", Offset = "0x6429650", VA = "0x18642AC50")]
		get
		{
			return default(ShapeTypeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public StandardRenderableVisualDataWrapper JBILDDIMILP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x642ACB0", Offset = "0x64296B0", VA = "0x18642ACB0")]
		get
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public PhysicsMaterialDataWrapper KDKKPOPGGOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x642A7F0", Offset = "0x64291F0", VA = "0x18642A7F0")]
		get
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public ShapeConfigDataWrapper CMAEIGGAOPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x642AB70", Offset = "0x6429570", VA = "0x18642AB70")]
		get
		{
			return default(ShapeConfigDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public JBBPHKINJON AGEDILPAACL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x642A510", Offset = "0x6428F10", VA = "0x18642A510")]
		get
		{
			return default(JBBPHKINJON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public COODFJCBCFA LLKBDMEOKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x642AB10", Offset = "0x6429510", VA = "0x18642AB10")]
		get
		{
			return default(COODFJCBCFA);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x642A4A0", Offset = "0x6428EA0", VA = "0x18642A4A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public MBDIACBDLED JFAIEMENCIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x642A6B0", Offset = "0x64290B0", VA = "0x18642A6B0")]
		get
		{
			return default(MBDIACBDLED);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x642AA40", Offset = "0x6429440", VA = "0x18642AA40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public float FPBINBHOBJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x642AAB0", Offset = "0x64294B0", VA = "0x18642AAB0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x642A710", Offset = "0x6429110", VA = "0x18642A710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public Vector3 HEGLFPMNEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x642A8C0", Offset = "0x64292C0", VA = "0x18642A8C0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x642A580", Offset = "0x6428F80", VA = "0x18642A580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public float JIPLDCPDIMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x642A780", Offset = "0x6429180", VA = "0x18642A780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public GALKDOKCBDD FCCIHHBGCMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x642A960", Offset = "0x6429360", VA = "0x18642A960")]
		get
		{
			return default(GALKDOKCBDD);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x642A850", Offset = "0x6429250", VA = "0x18642A850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420")]
	public MAOIGGAPMIH(MMBMADJJEAB OCMIGFBMBMB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x641B0D0", Offset = "0x6419AD0", VA = "0x18641B0D0")]
	public static bool KHGGPLGKNCG(MAOIGGAPMIH AEJBOLFACJC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x64253B0", Offset = "0x6423DB0", VA = "0x1864253B0")]
	public static bool EGKBPOJOPJH(MAOIGGAPMIH LMANHAAPNDE, MAOIGGAPMIH AMHFHPBEBNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x641ACC0", Offset = "0x64196C0", VA = "0x18641ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x642A620", Offset = "0x6429020", VA = "0x18642A620", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x641ACB0", Offset = "0x64196B0", VA = "0x18641ACB0", Slot = "4")]
	public bool Equals(MAOIGGAPMIH HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x641B660", Offset = "0x641A060", VA = "0x18641B660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x642ABD0", Offset = "0x64295D0", VA = "0x18642ABD0")]
	public OJBCFAAFGOB LOKCIBCFBFH()
	{
		return default(OJBCFAAFGOB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x642A9C0", Offset = "0x64293C0", VA = "0x18642A9C0")]
	public CKMMOJCNNGJ IGKJJCBAJGO()
	{
		return default(CKMMOJCNNGJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct OJBCFAAFGOB : IEquatable<OJBCFAAFGOB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly MMBMADJJEAB FPDMJJHHMMN;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public MMBMADJJEAB BGGLMNANNIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(MMBMADJJEAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public HFKEOLHFCHL BHEGPEPPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public MAOIGGAPMIH OFPNOANLDKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(MAOIGGAPMIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	private PrimitiveShapeDataWrapper PMGKHAADCNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x642BA40", Offset = "0x642A440", VA = "0x18642BA40")]
		get
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public IMOOPIBCBLJ LMGJJDHDEFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x642BAA0", Offset = "0x642A4A0", VA = "0x18642BAA0")]
		get
		{
			return default(IMOOPIBCBLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420")]
	public OJBCFAAFGOB(MMBMADJJEAB OCMIGFBMBMB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x641B0D0", Offset = "0x6419AD0", VA = "0x18641B0D0")]
	public static bool KHGGPLGKNCG(OJBCFAAFGOB AEJBOLFACJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x641ACC0", Offset = "0x64196C0", VA = "0x18641ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x642B9B0", Offset = "0x642A3B0", VA = "0x18642B9B0", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x641ACB0", Offset = "0x64196B0", VA = "0x18641ACB0", Slot = "4")]
	public bool Equals(OJBCFAAFGOB HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x641B660", Offset = "0x641A060", VA = "0x18641B660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[DefaultMember("Item")]
public readonly struct CKMMOJCNNGJ : IEquatable<CKMMOJCNNGJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly CKMMOJCNNGJ FCADOMHCKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly MMBMADJJEAB FPDMJJHHMMN;

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public MMBMADJJEAB BGGLMNANNIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(MMBMADJJEAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public HFKEOLHFCHL BHEGPEPPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public EDBDBECMNJC LJJCGBHAFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(EDBDBECMNJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	private PHDJGIJHHIJ ODHOLIFAOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x641B5F0", Offset = "0x6419FF0", VA = "0x18641B5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private KHGNHJPOKLJ DLFOJMPEOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x641A890", Offset = "0x6419290", VA = "0x18641A890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private LFFIHBDPEIL MOHBCGFICMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x641A920", Offset = "0x6419320", VA = "0x18641A920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public MAOIGGAPMIH OFPNOANLDKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(MAOIGGAPMIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public IADLKIOJNBI GAFFHPPLLMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x641B4C0", Offset = "0x6419EC0", VA = "0x18641B4C0")]
		get
		{
			return default(IADLKIOJNBI);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x641B180", Offset = "0x6419B80", VA = "0x18641B180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public IEnumerable<FHMDCDBEKNP> PNECOMKBFLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x641AA10", Offset = "0x6419410", VA = "0x18641AA10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public FHMDCDBEKNP MIEEOIIACLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x641ACF0", Offset = "0x64196F0", VA = "0x18641ACF0")]
		get
		{
			return default(FHMDCDBEKNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public int IAGPAHCAHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x641A980", Offset = "0x6419380", VA = "0x18641A980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420")]
	public CKMMOJCNNGJ(MMBMADJJEAB OCMIGFBMBMB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x641B0D0", Offset = "0x6419AD0", VA = "0x18641B0D0")]
	public static bool KHGGPLGKNCG(CKMMOJCNNGJ AEJBOLFACJC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x641B650", Offset = "0x641A050", VA = "0x18641B650")]
	public static bool PIEEFOPMNNK(CKMMOJCNNGJ LMANHAAPNDE, CKMMOJCNNGJ AMHFHPBEBNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x641ACC0", Offset = "0x64196C0", VA = "0x18641ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x641AC20", Offset = "0x6419620", VA = "0x18641AC20", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x641ACB0", Offset = "0x64196B0", VA = "0x18641ACB0", Slot = "4")]
	public bool Equals(CKMMOJCNNGJ HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x641B660", Offset = "0x641A060", VA = "0x18641B660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x641B2A0", Offset = "0x6419CA0", VA = "0x18641B2A0")]
	public FHMDCDBEKNP NJHPDJGABOH(float3? DGOJEOCFHHN, [Optional] quaternion? DMBBOEJIOJM, [Optional] Vector3? LFNFJOFKAIK)
	{
		return default(FHMDCDBEKNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x641AEA0", Offset = "0x64198A0", VA = "0x18641AEA0")]
	public FHMDCDBEKNP JHKFJEAFEFB(int ABBNIPHGMGH, float3? DGOJEOCFHHN, [Optional] quaternion? DMBBOEJIOJM, [Optional] Vector3? LFNFJOFKAIK)
	{
		return default(FHMDCDBEKNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x641AE00", Offset = "0x6419800", VA = "0x18641AE00")]
	public void IJEHCCFPBEB(int ABBNIPHGMGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x641B0F0", Offset = "0x6419AF0", VA = "0x18641B0F0")]
	public void LDCFGOINEDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct FHMDCDBEKNP : IEquatable<FHMDCDBEKNP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly MMBMADJJEAB FPDMJJHHMMN;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public MMBMADJJEAB BGGLMNANNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(MMBMADJJEAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public HFKEOLHFCHL BHEGPEPPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public CKMMOJCNNGJ CKGEFCDFKJM
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x6421C20", Offset = "0x6420620", VA = "0x186421C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public float3 BMNHEIGADNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x6421D30", Offset = "0x6420730", VA = "0x186421D30")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x6421F60", Offset = "0x6420960", VA = "0x186421F60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public quaternion JGNDFHLFBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x6422190", Offset = "0x6420B90", VA = "0x186422190")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x6421FE0", Offset = "0x64209E0", VA = "0x186421FE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float3 PPAMPBLEFIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x6422110", Offset = "0x6420B10", VA = "0x186422110")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x6421CB0", Offset = "0x64206B0", VA = "0x186421CB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public DENIDLPPMLE LBIPGKGBICB
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x6422210", Offset = "0x6420C10", VA = "0x186422210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private SplinePointParentDataWrapper IBKLLJAFINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x6421E40", Offset = "0x6420840", VA = "0x186421E40")]
		get
		{
			return default(SplinePointParentDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private SplinePointPositionDataWrapper CFJPOELLAAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x6422050", Offset = "0x6420A50", VA = "0x186422050")]
		get
		{
			return default(SplinePointPositionDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private SplinePointRotationDataWrapper FOPCNOPLKEB
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6421F00", Offset = "0x6420900", VA = "0x186421F00")]
		get
		{
			return default(SplinePointRotationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private SplinePointScaleDataWrapper FDLOIPEHNCH
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x6421EA0", Offset = "0x64208A0", VA = "0x186421EA0")]
		get
		{
			return default(SplinePointScaleDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private SplinePointOrderDataWrapper ODONGKNEHIC
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x64220B0", Offset = "0x6420AB0", VA = "0x1864220B0")]
		get
		{
			return default(SplinePointOrderDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420")]
	public FHMDCDBEKNP(MMBMADJJEAB OCMIGFBMBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x641ACC0", Offset = "0x64196C0", VA = "0x18641ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x6421DB0", Offset = "0x64207B0", VA = "0x186421DB0", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x641ACB0", Offset = "0x64196B0", VA = "0x18641ACB0", Slot = "4")]
	public bool Equals(FHMDCDBEKNP HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x641B660", Offset = "0x641A060", VA = "0x18641B660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x6421C20", Offset = "0x6420620", VA = "0x186421C20")]
	public void AFNOGOFEBJL(CKMMOJCNNGJ AEJBOLFACJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct KMFIKKEMJDI : IEquatable<KMFIKKEMJDI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly MMBMADJJEAB FPDMJJHHMMN;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public MMBMADJJEAB BGGLMNANNIP
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(MMBMADJJEAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public HFKEOLHFCHL BHEGPEPPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private PHDJGIJHHIJ ODHOLIFAOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x641B5F0", Offset = "0x6419FF0", VA = "0x18641B5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private KHGNHJPOKLJ DLFOJMPEOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6428890", Offset = "0x6427290", VA = "0x186428890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	private OJAHMLCLCPK EKIIFCGBGDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6428F10", Offset = "0x6427910", VA = "0x186428F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	private ToolCleanupSettingsDataWrapper LKHNCJAJILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x64290E0", Offset = "0x6427AE0", VA = "0x1864290E0")]
		get
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool BBIENJLIDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x6428920", Offset = "0x6427320", VA = "0x186428920")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x6428F70", Offset = "0x6427970", VA = "0x186428F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public bool DGNLAELJBKB
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x6429080", Offset = "0x6427A80", VA = "0x186429080")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x6428820", Offset = "0x6427220", VA = "0x186428820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public float KIFLPKKHMCM
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6428C50", Offset = "0x6427650", VA = "0x186428C50")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x6428D50", Offset = "0x6427750", VA = "0x186428D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public bool JOPLPFAJFJC
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x6428780", Offset = "0x6427180", VA = "0x186428780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420")]
	public KMFIKKEMJDI(MMBMADJJEAB OCMIGFBMBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x641ACC0", Offset = "0x64196C0", VA = "0x18641ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6428AB0", Offset = "0x64274B0", VA = "0x186428AB0", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x641ACB0", Offset = "0x64196B0", VA = "0x18641ACB0", Slot = "4")]
	public bool Equals(KMFIKKEMJDI HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x641B660", Offset = "0x641A060", VA = "0x18641B660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6428CB0", Offset = "0x64276B0", VA = "0x186428CB0")]
	public void HACDJIODNEB(int DLKCOBBNNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x6428B40", Offset = "0x6427540", VA = "0x186428B40")]
	public bool GFHGBHBGNFL([Out] int DLKCOBBNNLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x6428FE0", Offset = "0x64279E0", VA = "0x186428FE0")]
	public void MGHAPOFOEJE(bool ECAMNAANFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x6428630", Offset = "0x6427030", VA = "0x186428630")]
	public void AEEDFFIADLD(float NOGCLBNAPAH, float GIFDHMPGCEL, float PBGHLJCBOHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x6428DC0", Offset = "0x64277C0", VA = "0x186428DC0")]
	public void KFIGFEDJHAJ(float3 IFOFIOCGKPP, quaternion GJGODLGJHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x6429140", Offset = "0x6427B40", VA = "0x186429140")]
	public bool PKNAOCMMDNK([Out] float3 IFOFIOCGKPP, [Out] quaternion GJGODLGJHAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x6428980", Offset = "0x6427380", VA = "0x186428980")]
	public bool EBIOPDCOHPG([Out] float DHFPGJPHMFE, [Out] float CGOBILJPCCN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct EDBDBECMNJC : IEquatable<EDBDBECMNJC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly MMBMADJJEAB FPDMJJHHMMN;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public HFKEOLHFCHL BHEGPEPPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public DEEDJPBLLLH KIOIPHAMENG
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(DEEDJPBLLLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private PHDJGIJHHIJ ODHOLIFAOMH
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x641B5F0", Offset = "0x6419FF0", VA = "0x18641B5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private OEODAGFIFJP DOELIKOGMGG
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x6420F50", Offset = "0x641F950", VA = "0x186420F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool OMPMKHOBPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x641F470", Offset = "0x641DE70", VA = "0x18641F470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public Vector3 BMNHEIGADNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x641F2B0", Offset = "0x641DCB0", VA = "0x18641F2B0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x641FB60", Offset = "0x641E560", VA = "0x18641FB60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public Quaternion JGNDFHLFBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x6420C50", Offset = "0x641F650", VA = "0x186420C50")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x641FCD0", Offset = "0x641E6D0", VA = "0x18641FCD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public Vector3 AIBDOKJKNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x641FA70", Offset = "0x641E470", VA = "0x18641FA70")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x6420D90", Offset = "0x641F790", VA = "0x186420D90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public Quaternion NLDEDKHADKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x6420430", Offset = "0x641EE30", VA = "0x186420430")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x6420930", Offset = "0x641F330", VA = "0x186420930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public float KCMMJBAEDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x641FC30", Offset = "0x641E630", VA = "0x18641FC30")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x641FDA0", Offset = "0x641E7A0", VA = "0x18641FDA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public float LKJBPNCMFLD
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x64206B0", Offset = "0x641F0B0", VA = "0x1864206B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public Vector3 PPAMPBLEFIP
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x6420840", Offset = "0x641F240", VA = "0x186420840")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x641EC80", Offset = "0x641D680", VA = "0x18641EC80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public Vector3 MNFHPJFEFGN
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x641EF90", Offset = "0x641D990", VA = "0x18641EF90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public Matrix4x4 AFOLPPAKFJM
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x64201F0", Offset = "0x641EBF0", VA = "0x1864201F0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420")]
	public EDBDBECMNJC(MMBMADJJEAB OCMIGFBMBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x641ACC0", Offset = "0x64196C0", VA = "0x18641ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x641F860", Offset = "0x641E260", VA = "0x18641F860", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x641ACB0", Offset = "0x64196B0", VA = "0x18641ACB0", Slot = "4")]
	public bool Equals(EDBDBECMNJC HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x641B660", Offset = "0x641A060", VA = "0x18641B660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x641F260", Offset = "0x641DC60", VA = "0x18641F260")]
	public BGDAMFGELKE COAPCJBECJI()
	{
		return default(BGDAMFGELKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x6420030", Offset = "0x641EA30", VA = "0x186420030")]
	public void JDGADHAOGFP([Out] Matrix4x4 LDHLOHPAJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x6420230", Offset = "0x641EC30", VA = "0x186420230")]
	public void JPMMBCDKCDK([Out] Vector3 GIJADPCINFK, [Out] Quaternion DBCFAHKFJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x641F7B0", Offset = "0x641E1B0", VA = "0x18641F7B0")]
	public void EOILBODIOPD([Out] RigidTransform HHCJMGFKBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x641F230", Offset = "0x641DC30", VA = "0x18641F230")]
	public UniformTRS CGHOJBDHLIE()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x641F170", Offset = "0x641DB70", VA = "0x18641F170")]
	public void CGHOJBDHLIE([Out] UniformTRS HKMKIFGLNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x641FF10", Offset = "0x641E910", VA = "0x18641FF10")]
	public UniformTRS IOBEOILCHOA()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x641FE50", Offset = "0x641E850", VA = "0x18641FE50")]
	public void IOBEOILCHOA([Out] UniformTRS HHCJMGFKBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x641FF40", Offset = "0x641E940", VA = "0x18641FF40")]
	public Vector3 JCNOAADEIGE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x6420360", Offset = "0x641ED60", VA = "0x186420360")]
	public void KBEGKMDLNNO([In] Vector3 AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x641F080", Offset = "0x641DA80", VA = "0x18641F080")]
	public Vector3 BELBCCBMLOL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x641F3A0", Offset = "0x641DDA0", VA = "0x18641F3A0")]
	public void DHDDBFEJEMO([In] Vector3 AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x6420570", Offset = "0x641EF70", VA = "0x186420570")]
	public Quaternion KLEPMPAMBOE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x6420B80", Offset = "0x641F580", VA = "0x186420B80")]
	public void NMLNKJFAHDC([In] Quaternion AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x641F4B0", Offset = "0x641DEB0", VA = "0x18641F4B0")]
	public Quaternion EEDBAMKBEPK()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x641EDF0", Offset = "0x641D7F0", VA = "0x18641EDF0")]
	public void AMDMICOKAKN([In] Quaternion AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x6420150", Offset = "0x641EB50", VA = "0x186420150")]
	public float JFKBMKICGFN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x641F8F0", Offset = "0x641E2F0", VA = "0x18641F8F0")]
	public void HAPGHFMGILB(float AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x641ED50", Offset = "0x641D750", VA = "0x18641ED50")]
	public float ALCELEIDLAB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6420AD0", Offset = "0x641F4D0", VA = "0x186420AD0")]
	public void NLGALPDNNBG(float AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x641EEC0", Offset = "0x641D8C0", VA = "0x18641EEC0")]
	public void AMGFBBOOFBI([In] Vector3 AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x6420E60", Offset = "0x641F860", VA = "0x186420E60")]
	public Vector3 OKJFCBPLBPC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x641F5F0", Offset = "0x641DFF0", VA = "0x18641F5F0")]
	public void EIGEJLEANPN([In] Vector3 AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x641F6C0", Offset = "0x641E0C0", VA = "0x18641F6C0")]
	public Vector3 EIKAGPFIIGA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x641F9A0", Offset = "0x641E3A0", VA = "0x18641F9A0")]
	public void HIGNLFIOGDJ([In] Vector3 AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x6420750", Offset = "0x641F150", VA = "0x186420750")]
	public Vector3 MAAENKAEKPK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x6420A00", Offset = "0x641F400", VA = "0x186420A00")]
	public void NLFDEKDDNPG([In] Vector3 AEJBOLFACJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct DCFJLEBNLBJ : IEquatable<DCFJLEBNLBJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly MMBMADJJEAB FPDMJJHHMMN;

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public MMBMADJJEAB BGGLMNANNIP
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(MMBMADJJEAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public HFKEOLHFCHL BHEGPEPPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
		get
		{
			return default(HFKEOLHFCHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public int[] FKPAEGJJIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x641CE20", Offset = "0x641B820", VA = "0x18641CE20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public bool BAHCAHJPDPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x641CDC0", Offset = "0x641B7C0", VA = "0x18641CDC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x641CD50", Offset = "0x641B750", VA = "0x18641CD50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420")]
	public DCFJLEBNLBJ(MMBMADJJEAB OCMIGFBMBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x641ACC0", Offset = "0x64196C0", VA = "0x18641ACC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x641CCC0", Offset = "0x641B6C0", VA = "0x18641CCC0", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x641ACB0", Offset = "0x64196B0", VA = "0x18641ACB0", Slot = "4")]
	public bool Equals(DCFJLEBNLBJ HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x641B660", Offset = "0x641A060", VA = "0x18641B660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class JAHPFCNFIKB
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private struct GFKAOLHJCPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Guid JHOGCCPFJGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public HAGOKMJJJBL PHKMCGKHOJD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private struct HAGOKMJJJBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int AEJBOLFACJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int IAFLBHJLPGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int BGEHONBPHFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int HNNACCIBKNK;

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x6424FE0", Offset = "0x64239E0", VA = "0x186424FE0")]
		public bool AEAJPPEMGPB([Out] BHEOONDIPJK POJEOJNHOEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x6425060", Offset = "0x6423A60", VA = "0x186425060")]
		public HAGOKMJJJBL(BHEOONDIPJK POJEOJNHOEM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x6426990", Offset = "0x6425390", VA = "0x186426990")]
	public static Guid LJHEPNLOBKF(this BHEOONDIPJK POJEOJNHOEM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x6426A20", Offset = "0x6425420", VA = "0x186426A20")]
	public static bool PPIEEOBBPGK(this Guid JHOGCCPFJGM, [Out] BHEOONDIPJK POJEOJNHOEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal static class EKIGJEJJICB
{
	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x6421010", Offset = "0x641FA10", VA = "0x186421010")]
	public static KHGNHJPOKLJ DLFOJMPEOOC(this MMBMADJJEAB MCGNHGLIJDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x64210A0", Offset = "0x641FAA0", VA = "0x1864210A0")]
	public static COPBAAFFJOH LFMOJFNDBLK(this MMBMADJJEAB MCGNHGLIJDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x6421170", Offset = "0x641FB70", VA = "0x186421170")]
	public static EntityManager NMNDJPANEBG(this MMBMADJJEAB MCGNHGLIJDN)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x280C200", Offset = "0x280AC00", VA = "0x18280C200")]
	public static T KLABLLNMKBO<T>(this MMBMADJJEAB MCGNHGLIJDN) where T : struct, BMBGJEDJJKC
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x280BDE0", Offset = "0x280A7E0", VA = "0x18280BDE0")]
	public static bool JKACLCJBPGM<T>(this MMBMADJJEAB MCGNHGLIJDN) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x280C150", Offset = "0x280AB50", VA = "0x18280C150")]
	public static bool KDOFKKMOINC<T>(this MMBMADJJEAB MCGNHGLIJDN) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface NFMDLGENFJM
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LLJIIIMGEGH(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DPONAONLEBB(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PNEJFNAENOB(MMBMADJJEAB OCMIGFBMBMB, [Out] Guid NINCGKAKJEG);

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid IEDKICPMKFN(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CLCOHHMLNEJ(MMBMADJJEAB OCMIGFBMBMB, Guid NINCGKAKJEG);

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NADKDHADHIB(MMBMADJJEAB OCMIGFBMBMB, [Out] Guid BKJEPPHMINA);

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid EBEBBCCIHOJ(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OLDOLGDKEGC(MMBMADJJEAB OCMIGFBMBMB, Guid BKJEPPHMINA);

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ONNNMFHPHEG(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task PHGCJADCIOB(MMBMADJJEAB APJECMEEJIN, MMBMADJJEAB HHJLJBMAMDD);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[HGMHEGMFAAC(AKLDBHGLJNP.LoadInstance)]
public interface OCKDDDHJJBM
{
	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	Guid IGCFIOLOAOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MEKNEDIGLIO(NativeList<Guid> IFKAFDLLAAP, NativeList<Guid> FIEIGHAKNIK, NativeList<FixedString64Bytes> COHKCABJJID);
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface DBJOIANBJFL
{
	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPPDLIHBOPN(List<MMBMADJJEAB> HMLHKBFNJDD);

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OJJHPIPMIFK(MMBMADJJEAB OMINPEPNHJF);

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BGGLJNHEOGB(MMBMADJJEAB OMINPEPNHJF);

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KDINANHBBJP(MMBMADJJEAB OMINPEPNHJF);

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int OKJJAFCLBHI(MMBMADJJEAB OMINPEPNHJF);

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LIBLLGKFACI(MMBMADJJEAB OMINPEPNHJF, int OFMNGOBJEKH);

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MMBMADJJEAB ALEHJNLFCJF(MMBMADJJEAB BENBGKHADOB);

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LIBNLKIKNLM(MMBMADJJEAB BENBGKHADOB, MMBMADJJEAB JPCFJEAHLAA);

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IPOEBEPNLEG(MMBMADJJEAB BENBGKHADOB);

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int BFABBHCMMGM(MMBMADJJEAB BENBGKHADOB);

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IHKJMBNIDON(MMBMADJJEAB BENBGKHADOB, int LAPCHPGFIAK);

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MBJFJMMKFDL(MMBMADJJEAB FPDMJJHHMMN);

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LGAMGOIIOBP(MMBMADJJEAB OCMIGFBMBMB, bool PAFEGOLCNGI);

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PKDLPBBIICK(MMBMADJJEAB[] ONHBEAIBAJA, bool PAFEGOLCNGI);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface KFMKKDGOGLH
{
	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	IReadOnlyCollection<BEJCICNODIB> JHBAEFHLFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AIANBKEKOPD(int JOLOGDHIEGI, [Out] BEJCICNODIB PAKNEEDIODP);

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BEJCICNODIB NKBFHNBLAKJ(Type CGEOAHHPHHK);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public static class LHEKAFBJMFO
{
	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x29E7270", Offset = "0x29E5C70", VA = "0x1829E7270")]
	public static T FGHEOIFPKCI<T>(this KFMKKDGOGLH IJEFGJGJHGH, Entity DFBELOGKKCC) where T : struct, BMBGJEDJJKC
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x29E7310", Offset = "0x29E5D10", VA = "0x1829E7310")]
	public static BEJCICNODIB NKBFHNBLAKJ<T>(this KFMKKDGOGLH IJEFGJGJHGH) where T : struct, BMBGJEDJJKC
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface ENBOODDKHFC
{
	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BHEOONDIPJK[] MKPDLHKHEKI(string GKDOOPOCBPP, HFKEOLHFCHL APNLHMBAFNB, bool EBMFINBOJMP = false);

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CLFAIGHBJPA(string GLBCDKMKLIG, BHEOONDIPJK[] PEPGMDNCOKM);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[HGMHEGMFAAC(AKLDBHGLJNP.LoadInstance)]
public interface JBLMOBBNPEC
{
	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<MMBMADJJEAB, MMBMADJJEAB> HMBJDFDELDK;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<MMBMADJJEAB, MMBMADJJEAB> LGICIKKCNGM;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<MMBMADJJEAB, MMBMADJJEAB, MMBMADJJEAB> GMKOCFCBLBA;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<MMBMADJJEAB> NGCJHLEEFJL;

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OPNAPBMFLJP(MMBMADJJEAB OCMIGFBMBMB, MMBMADJJEAB GNNJFHIPNKM);

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MMBMADJJEAB HGCOPEJEPHH(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<MMBMADJJEAB> OEDEBFMOGOH(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	MMBMADJJEAB JPDGAEOLEDI(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JJCOJIMNMMK(MMBMADJJEAB OCMIGFBMBMB, Vector3 GBFCLDMNJNJ, Quaternion MDNCGLDKIJE);

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NACGHFOMGAD(MMBMADJJEAB OCMIGFBMBMB, float AFDEFBJNOPM);

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool DFIAIEJIGBF(MMBMADJJEAB OCMIGFBMBMB, [Out] RigidTransform ELBMHHGAEAH);

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool JBEKHFCKOOK(MMBMADJJEAB OCMIGFBMBMB, [Out] float MAAHGNBGEPO);

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 ADGGCIEJFJJ(FONNMPGGNBM PHMCJHPHMDK);

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion CHFIIMBJDDM(FONNMPGGNBM PHMCJHPHMDK);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class HBLNCGCPGGF
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[HGMHEGMFAAC(AKLDBHGLJNP.LoadInstance)]
public interface BMLDLPCBPFK
{
	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	object FLIDODGBOCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFOBMEGHMMD(JJOLFCGDJOI ONHBEAIBAJA);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public enum DBKDFDEMFHN
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class NIPJBFOMOHB
{
	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0xC3D610", Offset = "0xC3C010", VA = "0x180C3D610")]
	public static bool PHOALPLHKJO(this DBKDFDEMFHN MLJADEFEEPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0xC3D730", Offset = "0xC3C130", VA = "0x180C3D730")]
	public static bool JNGBCPACGPJ(this DBKDFDEMFHN MLJADEFEEPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x23AD870", Offset = "0x23AC270", VA = "0x1823AD870")]
	public static bool NKAOKMPMEGH(this DBKDFDEMFHN MLJADEFEEPB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface OPNOFPPCLJE
{
	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	DBKDFDEMFHN JJNLLEGMDIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	DBKDFDEMFHN HICALKHBLCI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	DBKDFDEMFHN JCNCJJKPAFA
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	DBKDFDEMFHN NEBOBDLOGAK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	DBKDFDEMFHN AKMEHMHCFDI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	DBKDFDEMFHN BCEOKNFJBLH
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	DBKDFDEMFHN HJMPNLCGDLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	DBKDFDEMFHN MAPOIFDCCPO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	DBKDFDEMFHN NGPLDKDCMLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	DBKDFDEMFHN BEIJIMJDMDB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	DBKDFDEMFHN MPKDIGHPBCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	DBKDFDEMFHN AOEGOLJKAJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	DBKDFDEMFHN AHHJKPBGFFN
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface NKGGJAMICIA
{
	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<ABNLCLIOBGG> FPIOBDBICMI;

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MMBMADJJEAB HABCBJBAMJE(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EMMIDPHNHKC(List<MMBMADJJEAB> HMLHKBFNJDD);

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DENIDLPPMLE PKJHMHHHLDE(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DENIDLPPMLE CMPMOMFPCMO(MMBMADJJEAB HHJLJBMAMDD, MMBMADJJEAB HJEPAOPBPKH, bool GBOFGINIOJB, MMBMADJJEAB PJDANIPAHEH);

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MMBMADJJEAB IGCDOLLFKEN(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HADFEPOJAPP(MMBMADJJEAB OCMIGFBMBMB, MMBMADJJEAB HHJLJBMAMDD, bool MNECKBBNCCM);

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GOFONPEFCOG(MMBMADJJEAB OCMIGFBMBMB, MMBMADJJEAB HHJLJBMAMDD);

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool CGPANNCIANN(MMBMADJJEAB IIMAOPKGKID, MMBMADJJEAB IFNCOMJLINC);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int BILHEDANBID(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	JJOLFCGDJOI GIDHHCEHHJG(MMBMADJJEAB FPDMJJHHMMN);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NativeArray<MMBMADJJEAB> FIKPEJOGGGC(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool CHMKIBEIHHL(MMBMADJJEAB OCMIGFBMBMB, MMBMADJJEAB MGCGHMJMIBG);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<MMBMADJJEAB> BOMCKGCHGFN(MMBMADJJEAB OCMIGFBMBMB, bool GEEEGCNOAMP = false);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool OAPKGKILNNE(MMBMADJJEAB OCMIGFBMBMB, MMBMADJJEAB IMKPNBLFMEL);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	MMBMADJJEAB JBCPECBGJEP(MMBMADJJEAB PJDANIPAHEH, MMBMADJJEAB MHEJFDBHKOL);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool CGLFOBJMPPH(MMBMADJJEAB PJDANIPAHEH, MMBMADJJEAB MHEJFDBHKOL, [Out] MMBMADJJEAB IKINOKKHDKO);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class EPEKNPMFOPC
{
	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6421310", Offset = "0x641FD10", VA = "0x186421310")]
	public static List<MMBMADJJEAB> EMMIDPHNHKC(this NKGGJAMICIA BMICOFMPFJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x6421420", Offset = "0x641FE20", VA = "0x186421420")]
	public static bool JBNBNCHDCBO(this NKGGJAMICIA BMICOFMPFJE, MMBMADJJEAB OCMIGFBMBMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[HGMHEGMFAAC(AKLDBHGLJNP.LoadInstance)]
public interface IAAOIKCKIMA
{
	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	bool APAJONFBGNC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	bool OLKCJOBNPIF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface LIFDAIGGFOC : OCJKJEBGDNP
{
	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GLDEAMKIHJC(Entity DFBELOGKKCC, [Out] CKEMELMKPAJ MEGCFGBDKPO);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JJEEILJCKCB(NativeArray<CKEMELMKPAJ> FHGPIEIOOLN, NativeArray<DFHIBOBMDCA> PGALGHEHOGN);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MBFGKKGHJIL(CKEMELMKPAJ MEGCFGBDKPO);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HMBDMNECMIL(CKEMELMKPAJ MEGCFGBDKPO, [Out] Collider INFBHHFPGMA);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[HGMHEGMFAAC(AKLDBHGLJNP.LoadInstance)]
public interface OCJKJEBGDNP
{
	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NOPDLNOAGLG([In] float3 FIMOJJMIEFE, [In] float3 COKBJHHCBCI, float EHAOBONCKIL, Allocator IMPJLMNPHBC, [Out] NativeArray<Entity> JKAMGAGLGEP);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[HGMHEGMFAAC(AKLDBHGLJNP.LoadInstance)]
public interface MHLBKKKNHKN
{
	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NOPDLNOAGLG([In] float3 FIMOJJMIEFE, [In] float3 COKBJHHCBCI, float EHAOBONCKIL, [Out] HCDHOEGEFOL HPNIJAIJGDA, [Out] MMBMADJJEAB DNEBDNGMCOF);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[HGMHEGMFAAC(AKLDBHGLJNP.LoadInstance)]
public interface CMDKKDBDFAE
{
	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NOPDLNOAGLG([In] NativeArray<Entity> JKAMGAGLGEP, [In] float3 FIMOJJMIEFE, [In] float3 COKBJHHCBCI, [In] NativeArray<HCDHOEGEFOL> BLOAAIFFKKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct CKEMELMKPAJ : FJKKAFGOBOJ, IEquatable<CKEMELMKPAJ>
{
	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public int JIFJFCOEJGO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x927700", Offset = "0x926100", VA = "0x180927700", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x927740", Offset = "0x926140", VA = "0x180927740", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public int HEDMKAPCFPD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x23C7760", Offset = "0x23C6160", VA = "0x1823C7760", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x575D410", Offset = "0x575BE10", VA = "0x18575D410", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x641A7F0", Offset = "0x64191F0", VA = "0x18641A7F0", Slot = "8")]
	public bool Equals(CKEMELMKPAJ HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x641A840", Offset = "0x6419240", VA = "0x18641A840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct HCDHOEGEFOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float JILFEJHFFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public float3 AMMBIDJOPFP;
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface KGHJKIBOBOI
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface PHDJGIJHHIJ
{
	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	KHGNHJPOKLJ DLFOJMPEOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	DBCOGFGEFIA CJLPFLAIEEP
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<JJOLFCGDJOI, NativeArray<GAPHNGPGADD>> IFKPGGFADGJ;

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event Action<JJOLFCGDJOI> FPNJBGOCDBI;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ENJEGGGNAKF IIHMPPMPJOP(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GAPHNGPGADD KPMJLLLMEBL(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JIGIEBIDGIG(BHEOONDIPJK POJEOJNHOEM, PNBAEMMHAOF DKLOANBELPH);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BFLCMMEBDIK(BHEOONDIPJK[] PEPGMDNCOKM, GameObject PACDKKMGCFJ);

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HFKEOLHFCHL BNHCCGLIIAO(MMBMADJJEAB OCMIGFBMBMB, [Optional] object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool DPCGOBMGBHI(MMBMADJJEAB OCMIGFBMBMB, [Out] PNBAEMMHAOF DKLOANBELPH);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool FDEPHNAPMBE(MMBMADJJEAB OCMIGFBMBMB, [Out] Transform OEIDOHJNAOK);

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool DMKKHJMNEEL(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NAFGBDDJKEK(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool MOHHOHPFDNH(LocalId OCMIGFBMBMB, object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool MCDLHCANPKK(LocalId OCMIGFBMBMB, object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	MMBMADJJEAB BFCENDCCHAA(BHEOONDIPJK POJEOJNHOEM);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool HMCAODDJENN(BHEOONDIPJK POJEOJNHOEM, [Out] MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	BHEOONDIPJK NBGAAEGCGPG(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	JJOLFCGDJOI BFCENDCCHAA(NativeArray<BHEOONDIPJK> POJEOJNHOEM, Allocator IMPJLMNPHBC);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	JJOLFCGDJOI NJPGBJBBHIF(GAPHNGPGADD BHKMCAKMPKO, int GBACAOOHJGH, Allocator IMPJLMNPHBC);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "22")]
	JJOLFCGDJOI JCFDOHGCJAH(NativeArray<BHEOONDIPJK> POJEOJNHOEM, NativeArray<JHDGNOIDKEL> ABHEBHNIEBA, Allocator IMPJLMNPHBC);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "23")]
	BHEOONDIPJK[] MKPDLHKHEKI(string GLBCDKMKLIG, HFKEOLHFCHL APNLHMBAFNB, bool EBMFINBOJMP);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CLFAIGHBJPA(string GLBCDKMKLIG, BHEOONDIPJK[] PEPGMDNCOKM);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "25")]
	HFKEOLHFCHL GFCPHFJBBPH(GAPHNGPGADD BHKMCAKMPKO, bool MHGEOIJKBBG);

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "26")]
	HFKEOLHFCHL GFCPHFJBBPH(GAPHNGPGADD BHKMCAKMPKO);

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "27")]
	HFKEOLHFCHL IBAJDJALEEP(GAPHNGPGADD BHKMCAKMPKO);

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "28")]
	HFKEOLHFCHL GPPNGPFJBJJ(GAPHNGPGADD BHKMCAKMPKO);

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(Slot = "29")]
	HFKEOLHFCHL ILAHILGNPMB(BHEOONDIPJK POJEOJNHOEM, GAPHNGPGADD BHKMCAKMPKO);

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "30")]
	GNLNDIGCDIO GIHKNFHGDOJ();

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "31")]
	CKMMOJCNNGJ KHJKFNJPMLD();

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "32")]
	OJBCFAAFGOB LIIOGPDDCPK(IMOOPIBCBLJ DEDOFAJBFEL);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void FMNMEJHCNFM(JJOLFCGDJOI ONHBEAIBAJA);

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void KDNFCEDEOOI(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void DONFAKNHBLF(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void FMNMEJHCNFM(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool HMNDFDEOCBP(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(Slot = "38")]
	JJOLFCGDJOI NIHPPODHEHE(JJOLFCGDJOI EGJMDKMBEOK, Allocator IMPJLMNPHBC);

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool FPGLOIPLKJL(MMBMADJJEAB OCMIGFBMBMB);
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public static class CLOBPFAIEDF
{
	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x641BA90", Offset = "0x641A490", VA = "0x18641BA90")]
	public static void NAFGBDDJKEK(this PHDJGIJHHIJ FDBOKAJBAPF, PNBAEMMHAOF DKLOANBELPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x641B680", Offset = "0x641A080", VA = "0x18641B680")]
	public static HFKEOLHFCHL IEHBAGEFFHO(this PHDJGIJHHIJ FDBOKAJBAPF, LocalId OCMIGFBMBMB)
	{
		return default(HFKEOLHFCHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x641B830", Offset = "0x641A230", VA = "0x18641B830")]
	public static HFKEOLHFCHL IEHBAGEFFHO(this PHDJGIJHHIJ FDBOKAJBAPF, BHEOONDIPJK POJEOJNHOEM)
	{
		return default(HFKEOLHFCHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x641B680", Offset = "0x641A080", VA = "0x18641B680")]
	public static MMBMADJJEAB BFCENDCCHAA(this PHDJGIJHHIJ FDBOKAJBAPF, LocalId OCMIGFBMBMB)
	{
		return default(MMBMADJJEAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x641BB10", Offset = "0x641A510", VA = "0x18641BB10")]
	public static BHEOONDIPJK NBGAAEGCGPG(this PHDJGIJHHIJ FDBOKAJBAPF, LocalId OCMIGFBMBMB)
	{
		return default(BHEOONDIPJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x641B7C0", Offset = "0x641A1C0", VA = "0x18641B7C0")]
	public static bool FPGLOIPLKJL(this PHDJGIJHHIJ FDBOKAJBAPF, BHEOONDIPJK POJEOJNHOEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x27BAE30", Offset = "0x27B9830", VA = "0x1827BAE30")]
	public static T GGFLGMHCOKL<T>(this PHDJGIJHHIJ FDBOKAJBAPF, LocalId OCMIGFBMBMB) where T : struct, BMBGJEDJJKC
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x641B890", Offset = "0x641A290", VA = "0x18641B890")]
	public static GNLNDIGCDIO IIHCPOFJAKP(this PHDJGIJHHIJ FDBOKAJBAPF, RigidTransform HKMKIFGLNNH, [Optional] object AIDIDMJCFEK)
	{
		return default(GNLNDIGCDIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x641B6B0", Offset = "0x641A0B0", VA = "0x18641B6B0")]
	public static OJBCFAAFGOB CHOIBHIIKCC(this PHDJGIJHHIJ FDBOKAJBAPF, IMOOPIBCBLJ PJLGOHFGDAD, RigidTransform HKMKIFGLNNH, [Optional] object AIDIDMJCFEK)
	{
		return default(OJBCFAAFGOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x641B990", Offset = "0x641A390", VA = "0x18641B990")]
	public static CKMMOJCNNGJ KBPMOOMPGGI(this PHDJGIJHHIJ FDBOKAJBAPF, RigidTransform HKMKIFGLNNH, [Optional] object AIDIDMJCFEK)
	{
		return default(CKMMOJCNNGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x641BB90", Offset = "0x641A590", VA = "0x18641BB90")]
	private static void PLJNBCABAFB(HFKEOLHFCHL BONBCALKGEP, RigidTransform HKMKIFGLNNH, [Optional] object AIDIDMJCFEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[HGMHEGMFAAC(AKLDBHGLJNP.LoadInstance)]
public interface FGLCBFOPBJF
{
	[Cpp2IlInjected.Token(Token = "0x17000180")]
	bool IJHPFBOCABF
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	MMBMADJJEAB AIALJPEJLAH
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	HFKEOLHFCHL PNIKHGMHDEE
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event MJFALCFMKLD CHEGEPPCOJE;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MMBMADJJEAB JBCPECBGJEP(MMBMADJJEAB PJDANIPAHEH, MMBMADJJEAB MHEJFDBHKOL);

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CGLFOBJMPPH(MMBMADJJEAB PJDANIPAHEH, MMBMADJJEAB MHEJFDBHKOL, [Out] MMBMADJJEAB IKINOKKHDKO);

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LKOENPANMNH();

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HJLJAMILNKK();

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ELGDMHDBHPJ(MMBMADJJEAB PJDANIPAHEH);

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool PCCKDPLDFNM(MMBMADJJEAB PJDANIPAHEH);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public delegate void MJFALCFMKLD(HFKEOLHFCHL AOCGBGHHANO, HFKEOLHFCHL HBKCCMLINOK);
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class PODHLAFILHM
{
	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x642BE50", Offset = "0x642A850", VA = "0x18642BE50")]
	public static bool DIPLLEBCGJL(this FGLCBFOPBJF OGHLENHBPGC, HFKEOLHFCHL PJDANIPAHEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x642BEA0", Offset = "0x642A8A0", VA = "0x18642BEA0")]
	public static bool LBGKOHFBAEG(this FGLCBFOPBJF OGHLENHBPGC, MMBMADJJEAB PJDANIPAHEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x642BDD0", Offset = "0x642A7D0", VA = "0x18642BDD0")]
	public static bool ADHBMKANGJI(this FGLCBFOPBJF OGHLENHBPGC, MMBMADJJEAB PJDANIPAHEH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface NFBPAIILLGK
{
	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JCNFOCJJLHO(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JINFDGJMCML(MMBMADJJEAB OCMIGFBMBMB, Transform OEIDOHJNAOK);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface IHFJFJMCELM
{
	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GLMJGJODMCH(MMBMADJJEAB PJDANIPAHEH, MMBMADJJEAB OHBDJCHLCLK);

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PCJEEGNHECF(MMBMADJJEAB PJDANIPAHEH, MMBMADJJEAB IONHNEHOGOA);

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BHGOKLBCAIG(MMBMADJJEAB PJDANIPAHEH, [Out] MMBMADJJEAB DNHBLLEGEGD);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[HGMHEGMFAAC(AKLDBHGLJNP.LoadInstance)]
public interface KPNNBHNLMKP
{
	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GEMDADLKEPN(MMBMADJJEAB FPDMJJHHMMN, bool AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHCGJIGAGNC(MMBMADJJEAB FPDMJJHHMMN, bool AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLOFOGAPLCH(MMBMADJJEAB FPDMJJHHMMN, int AEJBOLFACJC);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[HGMHEGMFAAC(AKLDBHGLJNP.LoadInstance)]
public interface LFFIHBDPEIL
{
	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<MMBMADJJEAB> NBPBANPGOCC(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MMBMADJJEAB NKGMKABOMGB(MMBMADJJEAB OCMIGFBMBMB, int ABBNIPHGMGH);

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int FJDIOGDOMNI(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IADLKIOJNBI DELCLPKPJHB(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DIGEPADHMGM(MMBMADJJEAB OCMIGFBMBMB, IADLKIOJNBI BJIJPHEEEMG);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MMBMADJJEAB EDIDPJHLLHD(MMBMADJJEAB OCMIGFBMBMB, [Optional] float3? DGOJEOCFHHN, [Optional] quaternion? DMBBOEJIOJM, [Optional] float3? LFNFJOFKAIK);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MMBMADJJEAB NNFFANBPFFG(MMBMADJJEAB OCMIGFBMBMB, int ABBNIPHGMGH, [Optional] float3? DGOJEOCFHHN, [Optional] quaternion? DMBBOEJIOJM, [Optional] float3? LFNFJOFKAIK);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CPPMKNKGODL(MMBMADJJEAB OCMIGFBMBMB, int ABBNIPHGMGH);

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JNELBEHIDML(MMBMADJJEAB OCMIGFBMBMB);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface AGPCACKMBEE
{
	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKMDMPFOHOL();

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JJIOHHDONGK();

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IJPFNFCGGDN();

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NBFEDJNIEPM();

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FBLBDGENKFH();

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NIGMHAIIBIN();

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OMJCHJIMHCD();

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OHEIPEEGHBB();

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HPLIDIEGPFJ();

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NGCKCHAHNGE();

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HJHHNEGDBED();

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CMFPOEHBEOL();
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[HGMHEGMFAAC(AKLDBHGLJNP.LoadInstance)]
public interface OJAHMLCLCPK
{
	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GFHGBHBGNFL(MMBMADJJEAB PJDANIPAHEH, [Out] int DLKCOBBNNLG);

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HACDJIODNEB(MMBMADJJEAB PJDANIPAHEH, int DLKCOBBNNLG);

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ACMICBDIFBG(MMBMADJJEAB PJDANIPAHEH, bool EPKGBANDAOF);

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MGHAPOFOEJE(MMBMADJJEAB PJDANIPAHEH, bool ECAMNAANFNJ);

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AEEDFFIADLD(MMBMADJJEAB PJDANIPAHEH, float NOGCLBNAPAH, float GIFDHMPGCEL, float PBGHLJCBOHN);

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EBIOPDCOHPG(MMBMADJJEAB OCMIGFBMBMB, [Out] float GIFDHMPGCEL, [Out] float PBGHLJCBOHN);

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KFIGFEDJHAJ(MMBMADJJEAB PJDANIPAHEH, float3 DGOJEOCFHHN, quaternion DMBBOEJIOJM);

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool PKNAOCMMDNK(MMBMADJJEAB PJDANIPAHEH, [Out] float3 DGOJEOCFHHN, [Out] quaternion DMBBOEJIOJM);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface OEODAGFIFJP
{
	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FJFDIFKLDPC(Entity DFBELOGKKCC);

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KBEGKMDLNNO(Entity DFBELOGKKCC, [In] float3 AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 JCNOAADEIGE(Entity DFBELOGKKCC);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NMLNKJFAHDC(Entity DFBELOGKKCC, [In] quaternion AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion KLEPMPAMBOE(Entity DFBELOGKKCC);

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JPMMBCDKCDK(Entity DFBELOGKKCC, [Out] float3 DGOJEOCFHHN, [Out] quaternion DMBBOEJIOJM);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JPMMBCDKCDK(Entity DFBELOGKKCC, [Out] RigidTransform LLBHFIOLJAG);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EOILBODIOPD(Entity DFBELOGKKCC, [Out] RigidTransform LLBHFIOLJAG);

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 POCINEIPOCN(Entity DFBELOGKKCC);

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AMGFBBOOFBI(Entity DFBELOGKKCC, [In] float3 AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HAPGHFMGILB(Entity DFBELOGKKCC, float AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float JFKBMKICGFN(Entity DFBELOGKKCC);

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HIGNLFIOGDJ(Entity DFBELOGKKCC, [In] float3 AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 EIKAGPFIIGA(Entity DFBELOGKKCC);

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DHDDBFEJEMO(Entity DFBELOGKKCC, [In] float3 AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 BELBCCBMLOL(Entity DFBELOGKKCC);

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AMDMICOKAKN(Entity DFBELOGKKCC, [In] quaternion AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion EEDBAMKBEPK(Entity DFBELOGKKCC);

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 OKJFCBPLBPC(Entity DFBELOGKKCC);

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void EIGEJLEANPN(Entity DFBELOGKKCC, [In] float3 AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NLGALPDNNBG(Entity DFBELOGKKCC, float AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float ALCELEIDLAB(Entity DFBELOGKKCC);

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NLFDEKDDNPG(Entity DFBELOGKKCC, [In] float3 AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 MAAENKAEKPK(Entity DFBELOGKKCC);

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CPINOEHHLLD(Entity DFBELOGKKCC, [Out] float4x4 LDHLOHPAJPD);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void EIDMDLHHHPM(Entity DFBELOGKKCC, [In] float4x4 LDHLOHPAJPD);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void HHKMEBDDOME(Entity DFBELOGKKCC, [Out] float4x4 LDHLOHPAJPD);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool FDEPHNAPMBE(Entity DFBELOGKKCC, [Out] Transform OEIDOHJNAOK);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void PBENLAFDICN(Entity DFBELOGKKCC);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void PGKKKMEDLGH(Entity DFBELOGKKCC, Entity EDLGCAMJGHA, Entity GCDDFMLCKMH);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class PNGBJLFJHDO
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface FJMKJMIIHOE
{
	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HNJPLDDLBDB(bool NPDFIGMPMJH);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface JMFGOFPIODH
{
	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World CCBBGFKCPGC(string ICNKDCALALI = "Main");

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World PMFMJFLGIPP(string ICNKDCALALI = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World GEAJENDINPN(string ICNKDCALALI = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World BBFFJPANDNO(string ICNKDCALALI = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface COPBAAFFJOH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000183")]
	World AFMNHCDFNJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	World HLDBJEGNMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	EntityManager NMNDJPANEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	bool DNNOPBKFOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase HJIKMHFDJBJ(Type CGEOAHHPHHK);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class KAPJLNFEKDD
{
	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x64279B0", Offset = "0x64263B0", VA = "0x1864279B0")]
	public static ComponentSystemBase JBLMKJIOOBO(this World GNMPCPCEMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x29C3760", Offset = "0x29C2160", VA = "0x1829C3760")]
	public static T HJIKMHFDJBJ<T>(this COPBAAFFJOH KFMOFCDKCJN) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[HGMHEGMFAAC(AKLDBHGLJNP.LoadInstance)]
public interface PGGONPGOPHF
{
	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NMKPNHLBFPK(NativeListAsync<Entity> NHMAPLLFFOF);

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHICFLOJMFG(NKCGPNBNNMK JMMFGGAAEIE);

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EDBKPAFHEAL(NativeListAsync<Entity> CABALEOCOAP, bool DJBNBKOJPGI);

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LEJLDCCOCLD();
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[HGMHEGMFAAC(AKLDBHGLJNP.LoadInstance)]
public interface DNFAJIDFMJC
{
	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DBJFJDCHJFE(Collider INFBHHFPGMA, [Out] DPJMMGOINKH MFMMOFNCPFG);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[HGMHEGMFAAC(AKLDBHGLJNP.LoadInstance)]
public interface PGDLMPLLEBE
{
	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HFIEMFJMLKI(MMBMADJJEAB OCMIGFBMBMB, [Out] Collider INFBHHFPGMA);

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject NJPEEKEFLIK(MMBMADJJEAB ANEKHOMHKKG, GameObject IGNCHADJNDE, Vector3 AFOLKIAHJCP, Quaternion JEMAGIAEKCI);

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JGOHPIIGNHD(GameObject INFBHHFPGMA);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider BKPEBBMEPDB<TCollider>(GameObject HPFCCGGJDBC) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BBFCIIFNBBD(Collider INFBHHFPGMA);

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject GHPHDIDOPHL<TCollider>(string GKDOOPOCBPP) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[HGMHEGMFAAC(AKLDBHGLJNP.LoadInstance)]
public interface BJEMADAFGFN
{
	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PBIHJIJDFNN(MMBMADJJEAB OCMIGFBMBMB, DLCDNFGOMIH LNNOPABPAOD, bool MACCLEMDPII, NIDCEBJLBCC NMGAIDGMJBP);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OCLEBNELPJC(MMBMADJJEAB OCMIGFBMBMB, DLCDNFGOMIH LNNOPABPAOD, bool MACCLEMDPII, bool PNBDIIOKABB, bool BIFFKPEOGNG);

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LNFPJAMJKKO JOCJAIDOGBI(MMBMADJJEAB AKBOHBAKCNP, List<MMBMADJJEAB> FEFNDPNHJGJ);

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KAANOMAGGEO(GameObject KBKBOPAENLI, GameObject PKDFKHHHFNH);

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JHCIBIFLLDM(GameObject PKDFKHHHFNH);

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T BKPEBBMEPDB<T>(GameObject HPFCCGGJDBC) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BBFCIIFNBBD(Collider INFBHHFPGMA);

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject FPJDDLCNPAA<T>(string GKDOOPOCBPP) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KJNEEOGHMEP(Collider INFBHHFPGMA, [Out] MMBMADJJEAB DLKCOBBNNLG);

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool FHPEHBFICCA(MMBMADJJEAB OCMIGFBMBMB, [Out] DPJMMGOINKH MFMMOFNCPFG);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface CGNHNOBPGCN
{
	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMKOOHPFFKM(MMBMADJJEAB OCMIGFBMBMB, MMBMADJJEAB AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OHMLBDKJDCI(MMBMADJJEAB OCMIGFBMBMB, MMBMADJJEAB AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int BILHEDANBID(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MMBMADJJEAB NDAFDJIEKFK(MMBMADJJEAB OCMIGFBMBMB, int ABBNIPHGMGH);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JJOLFCGDJOI CEJGOOHNJNP(MMBMADJJEAB OCMIGFBMBMB, Allocator IMPJLMNPHBC = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ACCJCEDMPCL(MMBMADJJEAB OCMIGFBMBMB, object AIDIDMJCFEK, MMBMADJJEAB AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DHPBDLLKMEJ(MMBMADJJEAB OCMIGFBMBMB, object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool LPKLAHAMDIP(MMBMADJJEAB OCMIGFBMBMB, [Out] MMBMADJJEAB AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FNEFMAJBHJE(MMBMADJJEAB OCMIGFBMBMB, float3 AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool BCMAEAPKPDC(MMBMADJJEAB OCMIGFBMBMB, [Out] float3 AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JPFLHFLBONB(MMBMADJJEAB OCMIGFBMBMB, float3 AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CPIBDLAJOBF(MMBMADJJEAB OCMIGFBMBMB, [Out] float3 AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JFMEMOFKPDK(MMBMADJJEAB OCMIGFBMBMB, (Quaternion rot, Vector3 moments) IIOBFIHKMKA);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool GBPAGLOBEPH(MMBMADJJEAB OCMIGFBMBMB, [Out] quaternion CMIACCILPCG, [Out] float3 HHFLGJPONKG);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FNBCBINHKHK(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 IKENNNEOEKG(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 OOPAEKAFCKP(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HLILOGEEKHE(MMBMADJJEAB OCMIGFBMBMB, float3 AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void JBEBJIPAHIO(MMBMADJJEAB OCMIGFBMBMB, float3 AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float IAMKBLENDCE(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float AJJFPCLBFAL(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void CJJJAIFDFNG(MMBMADJJEAB OCMIGFBMBMB, float AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IIBLBEMCEAA(MMBMADJJEAB OCMIGFBMBMB, float AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode JMJDIBLGFFG(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void KMPNEOLGIHF(MMBMADJJEAB OCMIGFBMBMB, CollisionDetectionMode AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "25")]
	OKAPGIDMLME IPLBIPPNKFP(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void FJACEEPEAMK(MMBMADJJEAB OCMIGFBMBMB, OKAPGIDMLME AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool CNJODIBGPCP(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void JJAPJCFOICN(MMBMADJJEAB OCMIGFBMBMB, bool AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "29")]
	MMBMADJJEAB HABCBJBAMJE(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void FMMCJCJCPIM(MMBMADJJEAB OCMIGFBMBMB, MMBMADJJEAB AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "31")]
	MMBMADJJEAB IGCDOLLFKEN(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void HADFEPOJAPP(MMBMADJJEAB OCMIGFBMBMB, MMBMADJJEAB AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "33")]
	JFKHEFJKEKA DCANJELMGBD(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void GPMIJFELKJL(MMBMADJJEAB OCMIGFBMBMB, JFKHEFJKEKA GACJJBDOHIK);

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool AHMHADJIHEH(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void MFPCIKANDPK(MMBMADJJEAB OCMIGFBMBMB, bool AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool PDDFPNGNNFH(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void NMLECKGDLAL(MMBMADJJEAB OCMIGFBMBMB, bool AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints JEAJJDLOHOE(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void KAHKGCEHHEP(MMBMADJJEAB OCMIGFBMBMB, RigidbodyConstraints AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float DIMIDBGLLDO(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void EOJONBHGONN(MMBMADJJEAB OCMIGFBMBMB, float AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float NKDHFIGNGJD(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void KMLFLEEMAND(MMBMADJJEAB OCMIGFBMBMB, float AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool DDOFHFGFKFA(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void IJMCGBIMJDJ(MMBMADJJEAB OCMIGFBMBMB, bool AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool DEDJJENPFKB(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void BICOFNLJBJJ(MMBMADJJEAB OCMIGFBMBMB, bool AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void HOOELKLOLJC(MMBMADJJEAB OCMIGFBMBMB, int AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "50")]
	KEGIGDFABJI IKCOPOPANBP(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void JJPHDABGFKN(MMBMADJJEAB OCMIGFBMBMB, KEGIGDFABJI AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "52")]
	GJIGFONCOIL BHPCJMPJHMJ(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void ADIEEBOPFCA(MMBMADJJEAB OCMIGFBMBMB, GJIGFONCOIL AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float CBJKKIFECCH(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void JIJNNJKNCGH(MMBMADJJEAB OCMIGFBMBMB, float AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void HLBGINFNDCD(MMBMADJJEAB OCMIGFBMBMB, object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void MCKIGNKIHPJ(MMBMADJJEAB OCMIGFBMBMB, object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool AJAMHFHKKPE(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void JKAHPDBDDOC(MMBMADJJEAB OCMIGFBMBMB, object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void JBHKGLMKCBI(MMBMADJJEAB OCMIGFBMBMB, object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool OEEGMLKPJFC(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool MDNECNBPLDO(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody CFCCBAEDKCI(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void IENINKEBMKB(MMBMADJJEAB OCMIGFBMBMB, Rigidbody LNCKMBKIAHH);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void EIKEAHAJACC(MMBMADJJEAB OCMIGFBMBMB, object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void HEJIHGANKGN(MMBMADJJEAB OCMIGFBMBMB, object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool IGCAJAIPOBN(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void BIBAFEMFDPM(MMBMADJJEAB OCMIGFBMBMB, float3 HLHANNCAGLP);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void KHNGEKFFLBG(MMBMADJJEAB OCMIGFBMBMB, float3 CEBHPCKMGCF);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool ALGKEKEFAGO(MMBMADJJEAB OCMIGFBMBMB, [Out] float3 HLHANNCAGLP);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool OPLHAENLLJO(MMBMADJJEAB OCMIGFBMBMB, [Out] float3 CEBHPCKMGCF);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool BNGHHFBGLAK(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void JKLOAOJOJJE(MMBMADJJEAB OCMIGFBMBMB, object AIDIDMJCFEK, bool PFAHELLLIJF);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void JCGCJFIPEHN(MMBMADJJEAB OCMIGFBMBMB, bool OHKPIPIKMGP);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void KDDCMKCFBGO(MMBMADJJEAB OCMIGFBMBMB);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool CAMGOBMMPLC(MMBMADJJEAB OCMIGFBMBMB);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[HGMHEGMFAAC(AKLDBHGLJNP.LoadInstance)]
public interface DJJOPLBDMEP
{
	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLGNAJENOEF(Entity MGBLADEOCLP);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MADPDJHIDLI(Entity MGBLADEOCLP);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[HGMHEGMFAAC(AKLDBHGLJNP.LoadInstance)]
public interface IOOAHMGANFD
{
	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PLNGLHOCLLL(MMBMADJJEAB PJDANIPAHEH, bool MMANADCOJJM);

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMPLFPMIGGM(MMBMADJJEAB PJDANIPAHEH, int INOGMJCLNPP);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public delegate void LDHIHNBDCLH(IBLEGJCAMPN NNMADJIPDJO);
[Cpp2IlInjected.Token(Token = "0x2000091")]
public readonly struct IBLEGJCAMPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly JJOLFCGDJOI HLMFICJOIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly NativeArray<byte> DPJJGOLFIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly NativeArray<byte> JKGBCKAGKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly OIPBELAGDIB LIJAEAOCHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly int GDGOGOGNCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly Type BPIMOPDMMDG;

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public JJOLFCGDJOI HKBEJEEBNHH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x92B100", Offset = "0x929B00", VA = "0x18092B100")]
		get
		{
			return default(JJOLFCGDJOI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x6426530", Offset = "0x6424F30", VA = "0x186426530")]
	public IBLEGJCAMPN(JJOLFCGDJOI HLMFICJOIGD, NativeArray<byte> DPJJGOLFIDF, NativeArray<byte> JKGBCKAGKEE, OIPBELAGDIB LIJAEAOCHAJ, int GDGOGOGNCOH, Type BPIMOPDMMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x297B7E0", Offset = "0x297A1E0", VA = "0x18297B7E0")]
	public NativeArray<T> DEBBBNEFIPF<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x297B7A0", Offset = "0x297A1A0", VA = "0x18297B7A0")]
	public NativeArray<T> DDPEPCPDIHP<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x297B820", Offset = "0x297A220", VA = "0x18297B820")]
	public (JJOLFCGDJOI, NativeArray<T>, NativeArray<T>) OIFPBAJNOAG<T>() where T : struct
	{
		return default((JJOLFCGDJOI, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x64264E0", Offset = "0x6424EE0", VA = "0x1864264E0")]
	public ABNLCLIOBGG PIOPJNKMCDJ()
	{
		return default(ABNLCLIOBGG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public interface PPHFGEIGIAP
{
	[Cpp2IlInjected.Token(Token = "0x17000188")]
	string LBGJHJBPCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	PPHFGEIGIAP AJHFDJOHKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	IEnumerable<PPHFGEIGIAP> OFMENFOMKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[HGMHEGMFAAC(AKLDBHGLJNP.LoadInstance)]
public interface NMOIPGGFOFC
{
	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	PPHFGEIGIAP PNGJALEFCPN
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	List<MHOKDMFBKAD> NMMLIAIELCD
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OOKJEBDIJOF(MHOKDMFBKAD DMJMLGBLOFK, [Out] PPHFGEIGIAP KNJMLCCPLDE);

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JIGIEBIDGIG(MHOKDMFBKAD DMJMLGBLOFK, LDHIHNBDCLH IKFEHPNNHEA);

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ILHGCENAOJC(MHOKDMFBKAD DMJMLGBLOFK, LDHIHNBDCLH IKFEHPNNHEA);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public readonly struct ABNLCLIOBGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly IBLEGJCAMPN ABDLEBPKDKC;

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public JJOLFCGDJOI HKBEJEEBNHH
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x92B100", Offset = "0x929B00", VA = "0x18092B100")]
		get
		{
			return default(JJOLFCGDJOI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x6419DE0", Offset = "0x64187E0", VA = "0x186419DE0")]
	public ABNLCLIOBGG(IBLEGJCAMPN ABDLEBPKDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x6419BF0", Offset = "0x64185F0", VA = "0x186419BF0")]
	public JJOLFCGDJOI DEBBBNEFIPF()
	{
		return default(JJOLFCGDJOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x6419B20", Offset = "0x6418520", VA = "0x186419B20")]
	public JJOLFCGDJOI DDPEPCPDIHP()
	{
		return default(JJOLFCGDJOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x6419CC0", Offset = "0x64186C0", VA = "0x186419CC0")]
	public (JJOLFCGDJOI, JJOLFCGDJOI, JJOLFCGDJOI) OIFPBAJNOAG()
	{
		return default((JJOLFCGDJOI, JJOLFCGDJOI, JJOLFCGDJOI));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[DefaultMember("Item")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface HCDKLNLBNOD : IEnumerable<LPBPPKKEEHB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	NativeBitArray BCIJJBFEJGH
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	NativeArray<int> MPBPNFGAOBM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	int IAGPAHCAHED
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	LPBPPKKEEHB MIEEOIIACLC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	LPBPPKKEEHB MIEEOIIACLC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LPBPPKKEEHB EAIMJCCAKII(FGBMCCIOKED AMPADKKCLFC);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OIPBELAGDIB LOCENLFEMAN(FGBMCCIOKED AMPADKKCLFC);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class ONFKMFBDALE
{
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
[DefaultMember("Item")]
public interface CBJKIPMCDHK : IEnumerable<BGFBMAMAINA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000193")]
	int IAGPAHCAHED
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	BGFBMAMAINA MIEEOIIACLC
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BGFBMAMAINA EAIMJCCAKII(FGBMCCIOKED AMPADKKCLFC);

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OIPBELAGDIB LOCENLFEMAN(FGBMCCIOKED AMPADKKCLFC);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class JCAFLGEPDPD
{
	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x2998C40", Offset = "0x2997640", VA = "0x182998C40")]
	public static OIPBELAGDIB LOCENLFEMAN<T>(this CBJKIPMCDHK FFPIOIIOFIN, ICAFADEJOLA<T> GKDOOPOCBPP) where T : struct
	{
		return default(OIPBELAGDIB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[DefaultMember("Item")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface EPLANDIFKNN : IEnumerable<MHOKDMFBKAD>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000195")]
	int IAGPAHCAHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	MHOKDMFBKAD MIEEOIIACLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MHOKDMFBKAD EAIMJCCAKII(FGBMCCIOKED AMPADKKCLFC);

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OIPBELAGDIB LOCENLFEMAN(FGBMCCIOKED AMPADKKCLFC);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class PBLDLMHFNDM
{
	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4070", Offset = "0x2AC2A70", VA = "0x182AC4070")]
	public static GHPJCFCOAPK<T> EAIMJCCAKII<T>(this EPLANDIFKNN FFPIOIIOFIN, FGBMCCIOKED GKDOOPOCBPP) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x2AC41B0", Offset = "0x2AC2BB0", VA = "0x182AC41B0")]
	public static OIPBELAGDIB LOCENLFEMAN<T>(this EPLANDIFKNN FFPIOIIOFIN, ICAFADEJOLA<T> GKDOOPOCBPP) where T : struct
	{
		return default(OIPBELAGDIB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[HGMHEGMFAAC(AKLDBHGLJNP.LoadInstance)]
public interface DCCEMINIHNL
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JIGIEBIDGIG(FGBMCCIOKED DMJMLGBLOFK, LDHIHNBDCLH IKFEHPNNHEA);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILHGCENAOJC(FGBMCCIOKED DMJMLGBLOFK, LDHIHNBDCLH IKFEHPNNHEA);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public static class OIMJPBJBBFH
{
	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x2AB5400", Offset = "0x2AB3E00", VA = "0x182AB5400")]
	public static void JIGIEBIDGIG<T>(this DCCEMINIHNL ILDKPJLGKFD, ICAFADEJOLA<T> DMJMLGBLOFK, LDHIHNBDCLH IKFEHPNNHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x2AB51E0", Offset = "0x2AB3BE0", VA = "0x182AB51E0")]
	public static void ILHGCENAOJC<T>(this DCCEMINIHNL ILDKPJLGKFD, ICAFADEJOLA<T> DMJMLGBLOFK, LDHIHNBDCLH IKFEHPNNHEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface GCLBAHEHNNM
{
	[Cpp2IlInjected.Token(Token = "0x17000197")]
	GJEGCIGALEN GNBDINBFNEA
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FFKANBJLBBI(BHEOONDIPJK POJEOJNHOEM, OIPBELAGDIB DMJMLGBLOFK);

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LDBHDAAIBHL(BHEOONDIPJK POJEOJNHOEM, Span<OIPBELAGDIB> FFPIOIIOFIN, bool CJDDKMIGGNH);

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NMMNALKEAIK(NativeArray<BHEOONDIPJK> PEPGMDNCOKM);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public static class IEHPMOEGEEO
{
	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x64265A0", Offset = "0x6424FA0", VA = "0x1864265A0")]
	public static void LDBHDAAIBHL(this GCLBAHEHNNM CJOHOCPFIND, BHEOONDIPJK POJEOJNHOEM, OIPBELAGDIB DMJMLGBLOFK, bool CJDDKMIGGNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public readonly struct GJEGCIGALEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly NativeBitArray PJNBKAENBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly NativeParallelHashMap<BHEOONDIPJK, int> NAJDLBBGADG;

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public bool NKDNPGBEGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x6422C40", Offset = "0x6421640", VA = "0x186422C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0xBF96D0", Offset = "0xBF80D0", VA = "0x180BF96D0")]
	public GJEGCIGALEN(NativeBitArray PJNBKAENBLM, NativeParallelHashMap<BHEOONDIPJK, int> NAJDLBBGADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x6422B10", Offset = "0x6421510", VA = "0x186422B10")]
	public bool FFKANBJLBBI(BHEOONDIPJK POJEOJNHOEM, OIPBELAGDIB DMJMLGBLOFK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[HGMHEGMFAAC(AKLDBHGLJNP.LoadInstance)]
public interface HCDDPCABDNM
{
	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FPHPNLBIDML(MMBMADJJEAB OCMIGFBMBMB, OOCJELEFBEL AEJBOLFACJC);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface IBIEEANIHFH
{
	[Cpp2IlInjected.Token(Token = "0x17000199")]
	EFHPIJLIOIK BBLOHKBCOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface LKNOBKGKEOA
{
	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	Type DLIBHGGLHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[HGMHEGMFAAC(AKLDBHGLJNP.LoadInstance)]
public interface MCJNFOCOJDA
{
	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKOPFHPEDIN(MMBMADJJEAB FPDMJJHHMMN, bool AEJBOLFACJC);
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public readonly struct CKEIMGIIFLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly IEnumerable<FACMNNHGHFN> IPOPFDIMCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly IReadOnlyList<GameObject> AABANDPALFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly IReadOnlyList<int> AMPFFHPONOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly IReadOnlyList<(BHEOONDIPJK, BHEOONDIPJK)> ICPLAONINJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly int LEEEHMGKPIG;

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public bool PCOPBBJPOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x641A720", Offset = "0x6419120", VA = "0x18641A720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	public int BBLMEDMKOHA
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x83FF90", Offset = "0x83E990", VA = "0x18083FF90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public IEnumerable<GameObject> PICPOOFLJPB
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x91FF80", Offset = "0x91E980", VA = "0x18091FF80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public IEnumerable<(BHEOONDIPJK src, BHEOONDIPJK dst)> JIHKLAJBMEE
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x641A780", Offset = "0x6419180", VA = "0x18641A780")]
	public CKEIMGIIFLN(IEnumerable<FACMNNHGHFN> IPOPFDIMCBI, IReadOnlyList<GameObject> AABANDPALFB, IReadOnlyList<int> AMPFFHPONOG, IReadOnlyList<(BHEOONDIPJK src, BHEOONDIPJK dst)> ICPLAONINJG, int LEEEHMGKPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x641A390", Offset = "0x6418D90", VA = "0x18641A390")]
	public (GameObject, int)[] OFOIEICOKLK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface FPOFPGIFBFC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	bool POIPEENGAAI
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	bool DKODPFCEHDH
	{
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	BFJOBPMJHKL KFJPGCCBGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BDJAOMMJCFP ILCDLNHENEN();

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BDJAOMMJCFP GCFDFKJOELO(IEnumerable<MMBMADJJEAB> ONHBEAIBAJA, [In] UniformTRS BFJBPKELEOA);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KGBMMPPGPKK GGCAMODACCI(ByteString LJPNPPIFFGF);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CLMEPIEOHJJ HIBFDPLDHFM(ByteString KDBHEHGNFHP, MMBMADJJEAB HHJLJBMAMDD, [In] UniformTRS GPJLCMKNMFK, GGBCCBPIJLH GAGFIMNOBMN, bool IIBPIEKKDHO = true);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AAJIBIFLKJF();

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CKEIMGIIFLN KJAOKOIMKPN(IEnumerable<FACMNNHGHFN> IPOPFDIMCBI);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class NFCCJPHPPGD
{
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface HFMAENKAEJN
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action BBOCPDIGEAF;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event Action PNHPKIPNPDF;
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct JHDGNOIDKEL : LGHGEKEBEGP, IEquatable<JHDGNOIDKEL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public GAPHNGPGADD BHKMCAKMPKO;

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x6426AF0", Offset = "0x64254F0", VA = "0x186426AF0", Slot = "5")]
	public void HIBHLHEFCGJ(DHFCGOPEGNA INBDAJDBDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x6426A40", Offset = "0x6425440", VA = "0x186426A40", Slot = "4")]
	public void BOALAEMEPIG(NHFGBLMIDIO KLKMGHMAEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x6426B20", Offset = "0x6425520", VA = "0x186426B20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x8BB510", Offset = "0x8B9F10", VA = "0x1808BB510", Slot = "6")]
	public bool Equals(JHDGNOIDKEL HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x6426A70", Offset = "0x6425470", VA = "0x186426A70", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x927700", Offset = "0x926100", VA = "0x180927700", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct BHEOONDIPJK : IComparable<BHEOONDIPJK>, IEquatable<BHEOONDIPJK>, LGHGEKEBEGP
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public const uint PCDOLHEIAKN = 0u;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public const uint GPLNBILDEII = 255u;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly BHEOONDIPJK ENOPEJBDPMA;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private const int IMONCLEHMLB = 24;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private const uint MKAJCEPEOKO = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private const int EHKALPOHDED = 8;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private const uint AHJEAIPENDK = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly uint OIKPPLLAJOB;

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public uint DNIDCMIGCFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x81D820", Offset = "0x81C220", VA = "0x18081D820")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public uint DPMGLPAKGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x641A1F0", Offset = "0x6418BF0", VA = "0x18641A1F0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public uint OCOFDFLIDIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x927700", Offset = "0x926100", VA = "0x180927700")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public bool PCOPBBJPOGB
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x6391CD0", Offset = "0x63906D0", VA = "0x186391CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0xD7D0B0", Offset = "0xD7BAB0", VA = "0x180D7D0B0")]
	public static BHEOONDIPJK GPIGJCHDPOL(uint OIKPPLLAJOB)
	{
		return default(BHEOONDIPJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x641A380", Offset = "0x6418D80", VA = "0x18641A380")]
	public BHEOONDIPJK(int GLMNAECDJEC, int JKHFIIMDLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x641A380", Offset = "0x6418D80", VA = "0x18641A380")]
	public BHEOONDIPJK(uint GLMNAECDJEC, int JKHFIIMDLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x641A380", Offset = "0x6418D80", VA = "0x18641A380")]
	public BHEOONDIPJK(uint GLMNAECDJEC, uint JKHFIIMDLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x927740", Offset = "0x926140", VA = "0x180927740")]
	private BHEOONDIPJK(uint OIKPPLLAJOB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x18C96F0", Offset = "0x18C80F0", VA = "0x1818C96F0")]
	public static bool PIEEFOPMNNK(BHEOONDIPJK LMANHAAPNDE, BHEOONDIPJK AMHFHPBEBNM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x641A200", Offset = "0x6418C00", VA = "0x18641A200")]
	public static bool EGKBPOJOPJH(BHEOONDIPJK LMANHAAPNDE, BHEOONDIPJK AMHFHPBEBNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x8BB510", Offset = "0x8B9F10", VA = "0x1808BB510", Slot = "5")]
	public bool Equals(BHEOONDIPJK MCGNHGLIJDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x641A210", Offset = "0x6418C10", VA = "0x18641A210", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x23AD780", Offset = "0x23AC180", VA = "0x1823AD780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x641A2F0", Offset = "0x6418CF0", VA = "0x18641A2F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x641A190", Offset = "0x6418B90", VA = "0x18641A190", Slot = "6")]
	public void BOALAEMEPIG(NHFGBLMIDIO KLKMGHMAEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x641A290", Offset = "0x6418C90", VA = "0x18641A290", Slot = "7")]
	public void HIBHLHEFCGJ(DHFCGOPEGNA INBDAJDBDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x633EE60", Offset = "0x633D860", VA = "0x18633EE60", Slot = "4")]
	public int CompareTo(BHEOONDIPJK HKMMPHJFKEA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public struct FACMNNHGHFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Guid JHOGCCPFJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public string GLBCDKMKLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Vector3 DGOJEOCFHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Quaternion DMBBOEJIOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Vector3 LFNFJOFKAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public int GDPICCDAHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Dictionary<string, object> BJIJPHEEEMG;

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x6421620", Offset = "0x6420020", VA = "0x186421620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x6421490", Offset = "0x641FE90", VA = "0x186421490")]
	private static string HDHLPENMGHP(Dictionary<string, object> LOBCGJMCNHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public enum ALMAJNJCNPN
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class GBCAIMOANIP
{
	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x5895D30", Offset = "0x5894730", VA = "0x185895D30")]
	public static bool MKEHPGNHMFF(this ALMAJNJCNPN CGEOAHHPHHK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[Flags]
public enum HCPAAGNAEEI
{
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	WorldPhasesMaster = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	AdditivePhases = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public interface CLMEPIEOHJJ : BFJOBPMJHKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	GGBCCBPIJLH ABEBALLPALG
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGEDHJJKDOM();

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CDPAADCLMHH();
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public interface BFJOBPMJHKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	IEnumerable<FACMNNHGHFN> GCECPOPBACF
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	CKEIMGIIFLN CBLJIONICMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	LocalId LOGIKBKIHIB
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	IEBDAOBLIEO CMDPMCMGMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AJCCCONLIKP(HCPAAGNAEEI LDDLAHMIJJI);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public interface GGBCCBPIJLH
{
	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JMHNFAECGGI(Guid HJEPAOPBPKH, [Out] Guid JJBDNKBHBIO);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public interface KGBMMPPGPKK : BFJOBPMJHKL, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[Flags]
public enum IADGCHMPNAC
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public interface BDJAOMMJCFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	IEBDAOBLIEO MDEOBLCGKPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString HJJNFPCAOHG();
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public enum NAGJGNPNFCG
{
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public delegate bool MLBHGNCLAED(FDKBGGDIHLN LAJKDLBCCBJ, [In] LEJCHFLILFL AEJBOLFACJC);
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public delegate bool ENHPPBPLOPI<T>(FDKBGGDIHLN LAJKDLBCCBJ, [In] T AEJBOLFACJC);
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface PNJEKMAJBBK
{
	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JIGIEBIDGIG(OIPBELAGDIB LIJAEAOCHAJ, Type KGCMNAFFMAM, MLBHGNCLAED IBPOHMBDBLN);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DOLFMIIKLBM(OIPBELAGDIB LIJAEAOCHAJ, [Out] MLBHGNCLAED IBPOHMBDBLN);
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public static class LNBFMJAJMBJ
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private sealed class FMDDAFCIJKJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public ENHPPBPLOPI<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public FMDDAFCIJKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x38C8850", Offset = "0x38C7250", VA = "0x1838C8850")]
		internal bool DNNOBBFGJOJ(FDKBGGDIHLN pendingList, [In] LEJCHFLILFL value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x29ED7B0", Offset = "0x29EC1B0", VA = "0x1829ED7B0")]
	public static void JIGIEBIDGIG<T>(this PNJEKMAJBBK ILDKPJLGKFD, OIPBELAGDIB LIJAEAOCHAJ, ENHPPBPLOPI<T> IBPOHMBDBLN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x64295A0", Offset = "0x6427FA0", VA = "0x1864295A0")]
	public static bool PONPAKKBLCC(this PNJEKMAJBBK ILDKPJLGKFD, FDKBGGDIHLN LAJKDLBCCBJ, OIPBELAGDIB LIJAEAOCHAJ, [In] LEJCHFLILFL AEJBOLFACJC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface IJMADPMOLLI
{
	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	uint OLBKLFADGEC
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface FDKBGGDIHLN
{
	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGPAOJOCANH(BHEOONDIPJK BACPAEEMLKE, OIPBELAGDIB LIJAEAOCHAJ, ReadOnlySpan<byte> OMHPHJDBEEI, ReadOnlySpan<byte> JIMEKLGBGKP);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BHBANAHECKF(BHEOONDIPJK BACPAEEMLKE, OIPBELAGDIB LIJAEAOCHAJ);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ONHLNFGGKHD(BHEOONDIPJK BACPAEEMLKE, OIPBELAGDIB LIJAEAOCHAJ, ReadOnlySpan<byte> JIMEKLGBGKP);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BCNBIHINHHD(BHEOONDIPJK BACPAEEMLKE, OIPBELAGDIB LIJAEAOCHAJ, Span<byte> OMHPHJDBEEI, Span<byte> JIMEKLGBGKP);
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class NHIOGKBDOPD
{
	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F220", Offset = "0x2A7DC20", VA = "0x182A7F220")]
	public static bool BCNBIHINHHD<T>(this FDKBGGDIHLN GHHANCBOJOP, BHEOONDIPJK BACPAEEMLKE, OIPBELAGDIB LIJAEAOCHAJ, [Out] T OMHPHJDBEEI, [Out] T JIMEKLGBGKP) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F3C0", Offset = "0x2A7DDC0", VA = "0x182A7F3C0")]
	public static bool ONHLNFGGKHD<T>(this FDKBGGDIHLN GHHANCBOJOP, BHEOONDIPJK BACPAEEMLKE, OIPBELAGDIB LIJAEAOCHAJ, T JIMEKLGBGKP) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public enum PMALPBMGAHD
{
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	End,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface LAJJGHCPLOP
{
	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCPIPPNLNME(BCLGKMBJACC HIHHIJKIJFM, ReadOnlySpan<byte> PEFGDLBLMMP);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IINFJCEJJHP(uint BGEHONBPHFM, ReadOnlySpan<byte> PEFGDLBLMMP);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CHHNFIAMMOB(int HLKGONIJIDN);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface LHDPHEPLEBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BCLGKMBJACC BPDHEOMBGHG(ReadOnlySpan<byte> PEFGDLBLMMP);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface BNPDLIPBPHH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CLAIKHJNHOA(BCLGKMBJACC KLDFLAABJKH, ReadOnlySpan<byte> PEFGDLBLMMP);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MAOHJAPOBFM(ReadOnlySpan<BCLGKMBJACC> EFPBALGLPNI);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public struct FKJMGIOMLDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public BCLGKMBJACC HIHHIJKIJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public ReadOnlyMemory<byte> PEFGDLBLMMP;
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public struct BCLGKMBJACC
{
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public static BCLGKMBJACC GLMFGPIDBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public uint GLMNAECDJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public int NJHCOBKJFJD;

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0xB14BF0", Offset = "0xB135F0", VA = "0x180B14BF0")]
	public BCLGKMBJACC(uint GLMNAECDJEC, int NJHCOBKJFJD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x641A080", Offset = "0x6418A80", VA = "0x18641A080")]
	public static bool PIEEFOPMNNK([In] BCLGKMBJACC OOMAGBGJFDN, [In] BCLGKMBJACC CBOPOPHGBGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x6419F90", Offset = "0x6418990", VA = "0x186419F90", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x641A040", Offset = "0x6418A40", VA = "0x18641A040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x641A0A0", Offset = "0x6418AA0", VA = "0x18641A0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x641A070", Offset = "0x6418A70", VA = "0x18641A070")]
	public void NKCMAJNBHJE([Out] uint GLMNAECDJEC, [Out] int NJHCOBKJFJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[HGMHEGMFAAC(AKLDBHGLJNP.OMRoom)]
public interface NBPMPDCELPC : FOAKDPGHHCK<NBPMPDCELPC>
{
	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NLEJDEABFNF(OIPBELAGDIB MCGNHGLIJDN, [Out] OHEBLILGJML PAKNEEDIODP);
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class FOFOHOCMAJE
{
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public interface OHEBLILGJML
{
	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	Type DMKHBNLDDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIBHLHEFCGJ(DHFCGOPEGNA INBDAJDBDHK, Span<byte> PJDANIPAHEH);

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BOALAEMEPIG(NHFGBLMIDIO KLKMGHMAEIH, ReadOnlySpan<byte> HIHHIJKIJFM);
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class OOKNPPIOINO
{
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public struct DFHIBOBMDCA : ISystemStateComponentData, IComponentData, IEquatable<DFHIBOBMDCA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public float3 DHAEDCCJHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public float3 MDLMGCCDKDB;

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x641D8B0", Offset = "0x641C2B0", VA = "0x18641D8B0", Slot = "4")]
	public bool Equals(DFHIBOBMDCA HKMMPHJFKEA)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class FJLMCBABILJ
{
	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public FJLMCBABILJ()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
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
