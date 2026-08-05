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
	public class LogRegistrationIndex : PPFIOIJOILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x639A960", Offset = "0x6399960", VA = "0x18639A960", Slot = "4")]
		public override void GGEFLGLPFBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MEMAAIFLFDL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x639AB60", Offset = "0x6399B60", VA = "0x18639AB60")]
	public static void MIAFGJNBCNM(this Rigidbody EJDMIIBAALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x639AA30", Offset = "0x6399A30", VA = "0x18639AA30")]
	public static void MIAFGJNBCNM(this Rigidbody EJDMIIBAALL, Vector3 NFGLKAHKKHD, Quaternion GAGDFKFHNKA, Vector3 JABPOBBFFEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct BPHEFFILCAL : IReadOnlyList<NOFNFJEBPPG>, IEnumerable<NOFNFJEBPPG>, IEnumerable, IReadOnlyCollection<NOFNFJEBPPG>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct CIFCPPDBNDP : IEnumerator<NOFNFJEBPPG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly NHGHMDMJDML JHLCJNCOCND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator ABNJJAFLONB;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public NOFNFJEBPPG DGGBFKFKJBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x638F230", Offset = "0x638E230", VA = "0x18638F230", Slot = "4")]
			get
			{
				return default(NOFNFJEBPPG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x638F1B0", Offset = "0x638E1B0", VA = "0x18638F1B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3E12CA0", Offset = "0x3E11CA0", VA = "0x183E12CA0")]
		public CIFCPPDBNDP(NHGHMDMJDML JHLCJNCOCND, NativeArray<LocalId>.Enumerator ABNJJAFLONB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x638F0F0", Offset = "0x638E0F0", VA = "0x18638F0F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x638F130", Offset = "0x638E130", VA = "0x18638F130", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x638F170", Offset = "0x638E170", VA = "0x18638F170", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly NHGHMDMJDML JHLCJNCOCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> EGJIMMLDENN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NOFNFJEBPPG EAGDGAFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x638E470", Offset = "0x638D470", VA = "0x18638E470", Slot = "4")]
		get
		{
			return default(NOFNFJEBPPG);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x638DDD0", Offset = "0x638CDD0", VA = "0x18638DDD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int INJGANOFENO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7BF180", Offset = "0x7BE180", VA = "0x1807BF180", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NHGHMDMJDML NKCCKBIMPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int GBPKIPDCGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7BF180", Offset = "0x7BE180", VA = "0x1807BF180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool EDCFENPGADL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x638DE20", Offset = "0x638CE20", VA = "0x18638DE20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> HAJDGEGHLJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x238CF40", Offset = "0x238BF40", VA = "0x18238CF40")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> GCNFIMAJKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x638DF50", Offset = "0x638CF50", VA = "0x18638DF50")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x638E3E0", Offset = "0x638D3E0", VA = "0x18638E3E0")]
	public BPHEFFILCAL(int AFDLPCPCHIJ, NHGHMDMJDML JHLCJNCOCND, Allocator NFBFCGHLHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3E124E0", Offset = "0x3E114E0", VA = "0x183E124E0")]
	public BPHEFFILCAL(NHGHMDMJDML JHLCJNCOCND, NativeArray<LocalId> EGJIMMLDENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x638E370", Offset = "0x638D370", VA = "0x18638E370")]
	internal BPHEFFILCAL(NHGHMDMJDML JHLCJNCOCND, NativeArray<Entity> LEIOAKAEPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x638E2D0", Offset = "0x638D2D0", VA = "0x18638E2D0")]
	public BPHEFFILCAL(NHGHMDMJDML JHLCJNCOCND, int GOKGFKKLOOJ, Allocator NFBFCGHLHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x638E220", Offset = "0x638D220", VA = "0x18638E220")]
	public BPHEFFILCAL(BPHEFFILCAL CNKPBIFDFAM, Allocator NFBFCGHLHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x638DEA0", Offset = "0x638CEA0", VA = "0x18638DEA0")]
	public BPHEFFILCAL FIOFIJAFHNC(Allocator NFBFCGHLHAF = Allocator.Temp)
	{
		return default(BPHEFFILCAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x638DE60", Offset = "0x638CE60", VA = "0x18638DE60", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x638DFB0", Offset = "0x638CFB0", VA = "0x18638DFB0")]
	public CIFCPPDBNDP IEKFBOGGJFJ()
	{
		return default(CIFCPPDBNDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x638E040", Offset = "0x638D040", VA = "0x18638E040", Slot = "6")]
	private IEnumerator<NOFNFJEBPPG> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x638E130", Offset = "0x638D130", VA = "0x18638E130", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public struct AAEDJGPKFEH : IList<NOFNFJEBPPG>, ICollection<NOFNFJEBPPG>, IEnumerable<NOFNFJEBPPG>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct GOLDBFCFFPE : IEnumerator<NOFNFJEBPPG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly NHGHMDMJDML JHLCJNCOCND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator ABNJJAFLONB;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public NOFNFJEBPPG DGGBFKFKJBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6397F90", Offset = "0x6396F90", VA = "0x186397F90", Slot = "4")]
			get
			{
				return default(NOFNFJEBPPG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6397F10", Offset = "0x6396F10", VA = "0x186397F10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3E12CA0", Offset = "0x3E11CA0", VA = "0x183E12CA0")]
		public GOLDBFCFFPE(NHGHMDMJDML JHLCJNCOCND, NativeArray<LocalId>.Enumerator ABNJJAFLONB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6397E50", Offset = "0x6396E50", VA = "0x186397E50", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6397E90", Offset = "0x6396E90", VA = "0x186397E90", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6397ED0", Offset = "0x6396ED0", VA = "0x186397ED0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NHGHMDMJDML JHLCJNCOCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> EGJIMMLDENN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NOFNFJEBPPG EAGDGAFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x638D2E0", Offset = "0x638C2E0", VA = "0x18638D2E0", Slot = "4")]
		get
		{
			return default(NOFNFJEBPPG);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x638D360", Offset = "0x638C360", VA = "0x18638D360", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int JFLFCJGPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x638CCC0", Offset = "0x638BCC0", VA = "0x18638CCC0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GBPKIPDCGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x638CCC0", Offset = "0x638BCC0", VA = "0x18638CCC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool CNGKFBOLNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x638D250", Offset = "0x638C250", VA = "0x18638D250")]
	public AAEDJGPKFEH(NHGHMDMJDML JHLCJNCOCND, int GOKGFKKLOOJ, Allocator NFBFCGHLHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x638CED0", Offset = "0x638BED0", VA = "0x18638CED0")]
	public BPHEFFILCAL OGMHNNKGPMG()
	{
		return default(BPHEFFILCAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x638CA60", Offset = "0x638BA60", VA = "0x18638CA60", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x638CAA0", Offset = "0x638BAA0", VA = "0x18638CAA0", Slot = "13")]
	public bool Contains(NOFNFJEBPPG LLMAIFIKIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x638CB30", Offset = "0x638BB30", VA = "0x18638CB30", Slot = "14")]
	public void CopyTo(NOFNFJEBPPG[] PAFIMPMPKHD, int PKIBMLHJLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x638C9E0", Offset = "0x638B9E0", VA = "0x18638C9E0", Slot = "11")]
	public void Add(NOFNFJEBPPG LLMAIFIKIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x638CE20", Offset = "0x638BE20", VA = "0x18638CE20", Slot = "7")]
	public void Insert(int GPEHCABDGEJ, NOFNFJEBPPG LLMAIFIKIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x638CFA0", Offset = "0x638BFA0", VA = "0x18638CFA0", Slot = "15")]
	public bool Remove(NOFNFJEBPPG LLMAIFIKIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x638CD90", Offset = "0x638BD90", VA = "0x18638CD90", Slot = "6")]
	public int IndexOf(NOFNFJEBPPG LLMAIFIKIOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x638CF50", Offset = "0x638BF50", VA = "0x18638CF50", Slot = "8")]
	public void RemoveAt(int GPEHCABDGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x638CC80", Offset = "0x638BC80", VA = "0x18638CC80", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x638CD00", Offset = "0x638BD00", VA = "0x18638CD00")]
	public GOLDBFCFFPE IEKFBOGGJFJ()
	{
		return default(GOLDBFCFFPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x638D070", Offset = "0x638C070", VA = "0x18638D070", Slot = "16")]
	private IEnumerator<NOFNFJEBPPG> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x638D160", Offset = "0x638C160", VA = "0x18638D160", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DHIPLOGIHNP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int ICOAALOHOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> CLNMNFHEPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NOFNFJEBPPG KLDKAEHHJFD(NOFNFJEBPPG EGJIMMLDENN);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EIHALBBPDNA : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface CJLGCBJIILG : CHDHNNHGPMN, PGLBABFJBHF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool NPKMANILOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	CGPIPJGCIAG OIMJEJHLCBG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	GKCKNEIMCOC FGOACBGMJIH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	BPHONMBHKOI NNFHOLPEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	EGGCMOBOFDA JBBGPNKCNDO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	EIMGEGJKHGD PLFICIHIKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface PGLBABFJBHF
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool PNBCBOBDPIC
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface NDGDBMCKLNL
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJEEOIBECJE(bool LDGMLLMKHLF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface EGGCMOBOFDA
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool FGHHMAIFIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action MIDFFDLFIMD;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MKMCBBAICJO(bool IEEBLFDNOPE);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GJELFDOCOGO(ByteString FDACCKJJCFO);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CIFBNMOCIBC();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PMODJJGAJAK();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GHGDPOPKHLF();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface BPHONMBHKOI
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	DHADIMIDLEJ OIMJEJHLCBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	GKCKNEIMCOC FGOACBGMJIH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	NFAOAMBMPDB KKCGFPMMNKI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	CJLGCBJIILG DOMDMIFKLEM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	NHGHMDMJDML NKCCKBIMPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	IKLKAFPKEDF MLNDOKBLGCB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	OJDLIIODLKN KILMKMIOBHE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	NNCDPEOCJKB DEADKNEHDNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	PJIPKOCOCIF DOJJKABHFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	AEFAHGJABDO COACDLDMEFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	GPJDJEJJIBF BEFBPKLGOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	KGCMDANCEHN KNNOAGADDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	ILDANFGJJDF IFFLECHHEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	BMEJJBHHFBC JBAEIOKMACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	OHHAENLPPNG NBJGMFGCHAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	AAPFLIKBDKG JHCJNCHAPCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	PDLIOLLJFGJ GGINIBPMBGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	MMGJOIHPLGG EBHBDNIEAKO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	MJHALFBCDJO HBDGHHNIKIN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	OFJOHPHBCID EHAOBLJEHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	CBKBINEKGPM OGIBBIPCFDF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	DGACCNFLEDA EDIBODJJGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	HFOBDOLNFBM ELHNJIONAPD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	COBFHJNGGPC HDFPFNAEKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	PGFNEALGLEB JOMLKDPMCNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DebuggerTypeProxy(typeof(HLHHJADNBOM))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct NOFNFJEBPPG : IComparable<NOFNFJEBPPG>, IEquatable<NOFNFJEBPPG>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly NOFNFJEBPPG PPEPKDCDIPM;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int EHKPOJLMEOM = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int GJNDGBAKFEM = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int HMAFJFCAKDL = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int KENLHBMNLPK = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId OJJIOPECNPL;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public NHGHMDMJDML NKCCKBIMPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x638DA70", Offset = "0x638CA70", VA = "0x18638DA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public CJLGCBJIILG DOMDMIFKLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x639C9E0", Offset = "0x639B9E0", VA = "0x18639C9E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public LocalId NMHJFFIPIOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x639CE40", Offset = "0x639BE40", VA = "0x18639CE40")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal EIMGEGJKHGD PLFICIHIKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x639CB70", Offset = "0x639BB70", VA = "0x18639CB70")]
		get
		{
			return default(EIMGEGJKHGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool AGICPGAMDKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x639C8A0", Offset = "0x639B8A0", VA = "0x18639C8A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private bool BNMKFMAPMPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x639CA40", Offset = "0x639BA40", VA = "0x18639CA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x639D030", Offset = "0x639C030", VA = "0x18639D030")]
	public NOFNFJEBPPG(NHGHMDMJDML LGFIEBFIFDA, LocalId OJJIOPECNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
	public NEGNIICHCKG DJAPNADIFFA()
	{
		return default(NEGNIICHCKG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x639CEC0", Offset = "0x639BEC0", VA = "0x18639CEC0")]
	public static LocalId NCBCBLCGNHJ(NOFNFJEBPPG GFLHHEEIEFN)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x639CE80", Offset = "0x639BE80", VA = "0x18639CE80")]
	public static Entity NCBCBLCGNHJ(NOFNFJEBPPG GFLHHEEIEFN)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x639CD20", Offset = "0x639BD20", VA = "0x18639CD20")]
	public static bool JPKEALLKLNK(NOFNFJEBPPG AAOIMEIMECG, NOFNFJEBPPG ABLGCHAEIGE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x639A8E0", Offset = "0x63998E0", VA = "0x18639A8E0")]
	public static bool OECHKCIMKIG(NOFNFJEBPPG AAOIMEIMECG, NOFNFJEBPPG ABLGCHAEIGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x639CF00", Offset = "0x639BF00", VA = "0x18639CF00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x639CB80", Offset = "0x639BB80", VA = "0x18639CB80", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x638D690", Offset = "0x638C690", VA = "0x18638D690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x639CA90", Offset = "0x639BA90", VA = "0x18639CA90", Slot = "4")]
	public int CompareTo(NOFNFJEBPPG JNHFAFOIKEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x638D5F0", Offset = "0x638C5F0", VA = "0x18638D5F0", Slot = "5")]
	public bool Equals(NOFNFJEBPPG JNHFAFOIKEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NHDNGIGJBBH
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x639C6A0", Offset = "0x639B6A0", VA = "0x18639C6A0")]
	public static BLFAMKALCNM PJICHNILIOP(this NOFNFJEBPPG KDEEPMDJGFD)
	{
		return default(BLFAMKALCNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x639C5E0", Offset = "0x639B5E0", VA = "0x18639C5E0")]
	public static NEGNIICHCKG FDJEMHAFDGK(this NOFNFJEBPPG KDEEPMDJGFD, [Optional] object KONODCHOCOG)
	{
		return default(NEGNIICHCKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2A22A00", Offset = "0x2A21A00", VA = "0x182A22A00")]
	public static T EPPBODPJEEM<T>(this NOFNFJEBPPG KDEEPMDJGFD) where T : struct, HMFIKBKNPFM
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class HLHHJADNBOM
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct EIMGEGJKHGD : IEquatable<EIMGEGJKHGD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte NJADCNCCDAJ;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] CCBPBBGJGGO;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static NHGHMDMJDML NGDFHOOOICB;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static CJLGCBJIILG PLIDHCLOGBJ;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static NHGHMDMJDML[] KIILDEONNFF;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static CJLGCBJIILG[] OLJPHLBDOHK;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> IFMJNIFAHJP;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public CJLGCBJIILG DOMDMIFKLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x63954C0", Offset = "0x63944C0", VA = "0x1863954C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NHGHMDMJDML PFNLJFLGCGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6396220", Offset = "0x6395220", VA = "0x186396220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x63963C0", Offset = "0x63953C0", VA = "0x1863963C0")]
	static EIMGEGJKHGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xCBCF40", Offset = "0xCBBF40", VA = "0x180CBCF40")]
	internal EIMGEGJKHGD(byte LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x55990C0", Offset = "0x55980C0", VA = "0x1855990C0", Slot = "4")]
	public bool Equals(EIMGEGJKHGD JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6395670", Offset = "0x6394670", VA = "0x186395670", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1BA1E30", Offset = "0x1BA0E30", VA = "0x181BA1E30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6396300", Offset = "0x6395300", VA = "0x186396300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x63955A0", Offset = "0x63945A0", VA = "0x1863955A0")]
	private static NHGHMDMJDML DFJLOAJIKDB(byte NJADCNCCDAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6396170", Offset = "0x6395170", VA = "0x186396170")]
	private static CJLGCBJIILG OHCJPHOJMEN(byte NJADCNCCDAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6395A60", Offset = "0x6394A60", VA = "0x186395A60")]
	private static object HOKJMJDIDJH(byte NJADCNCCDAJ, object[] AGKDCPLPFCM, object HIFDPDGCHMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6395660", Offset = "0x6394660", VA = "0x186395660")]
	private static int EIJDEDJBBDC(byte NJADCNCCDAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6395650", Offset = "0x6394650", VA = "0x186395650")]
	private static int DIPEJLFDPHF(byte NJADCNCCDAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x63959E0", Offset = "0x63949E0", VA = "0x1863959E0")]
	private static (int, int) HKJCKNNNCBH(byte NJADCNCCDAJ)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6395710", Offset = "0x6394710", VA = "0x186395710")]
	private static byte GDIPOMNGGAN(int OECHNNBOAGJ, int GPEHCABDGEJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6395720", Offset = "0x6394720", VA = "0x186395720")]
	internal static EIMGEGJKHGD GGEFLGLPFBG(CJLGCBJIILG KAGECFGHMEH, NHGHMDMJDML CCOJAMNCLHB)
	{
		return default(EIMGEGJKHGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6395BD0", Offset = "0x6394BD0", VA = "0x186395BD0")]
	internal static void IEOHJNELHNB(EIMGEGJKHGD NJADCNCCDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6395DE0", Offset = "0x6394DE0", VA = "0x186395DE0")]
	private static void JHIGLKHJFPA(int AFDLPCPCHIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface CMHGANGKIFH
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NBGMFFMDKCL();

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JILCJCEAIDI(bool FIFOPDLCCPG);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HCCDBBKHHGK(GameObject HOHLOJNOGCD);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface GMOBPMDCAJB
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	Guid MLHOFNFENDG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KCCLOPDNMAF(Guid NAANNDDHJFD, Guid PJEBPDKCJMA);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task LCEGCEDLBCI(NOFNFJEBPPG NPOKDFFCADD);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OJPABADJGPP(NOFNFJEBPPG HJKHNDILIPH, NOFNFJEBPPG NNHBJFPLAAA, [Out] Vector3 PDJLKPJAKEO, [Out] Quaternion DGBIMPLNOFD);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GEALLAGJLLM(EMOEILOIFJN FNAJBDLCOMG, Vector3 PDJLKPJAKEO, Quaternion DGBIMPLNOFD);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OKJMECIGDFH(NOFNFJEBPPG FDLBKCMAFIA, [Out] Vector3 DBPOJBLHHGK, [Out] Quaternion IDANBLMOFJH);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface DKIABLIFKBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBICALOOKNB(BPHEFFILCAL EGJIMMLDENN);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface GFHAACCKEGK
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MFIMDMKJHNK(GameObject EJEJHAIFANL, GameObject JKFGCMKFOGF, int ECHFOFBAGPB);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface GKCKNEIMCOC
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	CMHGANGKIFH IDGFONALPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	OKOCBCLEIIN ELKPDBHDHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	NNOOJLALLLB HIMGNABPKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	HJLKODCLGHK EBKEFNAPGKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	PECBFDBLHFB OJAPNOBDOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	GJNPKGJCAFN HDMMDEFBMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	GLIKCJAIHBE INNELDGJLBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	NMPEOMJDKMJ IHBJNMDHMIM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface CGONKMPGAOE
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DMAEJJJAPPM(Action LNMJHEPMAAO, bool MFJEHAOJMJN);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EAPLKCGKGPK(string ONGJKHHOIAM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface OKOCBCLEIIN
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	string ELJBKLCFLMP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] CPADDLIJPFA(IEnumerable<OIIIDBNPELK> HKKEJBKELFH);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CPJDCOKAMLP(GameObject HOHLOJNOGCD, [Out] BLFAMKALCNM[] EFEJKJHNICM);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KLMPOMDJOMB(GameObject HOHLOJNOGCD, [Out] int IGBCOGJOFNN, [Out] PLACGONOKNH INLOKFDEDIJ);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JMDGFCECOJD PNNPDEOEGHC(OIIIDBNPELK MJJCOLDOFAC);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JMDGFCECOJD PNNPDEOEGHC(string JMIDDGLBCDI, BLFAMKALCNM[] PBKJILNOEKG, Vector3 BJIKBOECFPB, Quaternion CKCOAEGKOKA, Vector3 GJBNAOHDFNK);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GameObject CMFFINFKEHF(string JMIDDGLBCDI);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IFHLEHAKCFF(GameObject JJJGHOAIKCE, bool PPMCKDBJGCH);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KKLIMKHFMHG(GameObject HOHLOJNOGCD, bool OFIEOFCNLNJ, bool FLDDEDMLPNL);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class BNKBHHIBLPE
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x638DBF0", Offset = "0x638CBF0", VA = "0x18638DBF0")]
	public static JMDGFCECOJD PNNPDEOEGHC(this OKOCBCLEIIN AKJKFGAFELN, Vector3 BJIKBOECFPB, Quaternion CKCOAEGKOKA, Vector3 GJBNAOHDFNK, params BLFAMKALCNM[] EFEJKJHNICM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface NNOOJLALLLB
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FEIJMKBKDON(bool IEEBLFDNOPE);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface HJLKODCLGHK
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool FAIPMMOONBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool CHOBFOOMDGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool LDHPBALEDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	int OHEHNFFNLNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool KGCEMBICCCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LBOFMNMNLBA(object KKAPFENLPIM);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LJPMGGFJKMC(object KKAPFENLPIM);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EAAOPNIAPIK(object AOHFGFEGDPB);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ACHBAOIEOIF(object AOHFGFEGDPB);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int MGFJICFDEHP(GameObject JEDPLPDPMGC);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GGDKOMMPILE(NativeArray<int> LIDPCLPDEOA);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FCFNBHIPFMF(NativeArray<int> DCICODHCAPA);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FIALPFDLBGJ();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KFCKINPBNMH(uint KGCFOAELMEM, ReadOnlySpan<byte> OLKLJLNLNLM, bool HMPENGGGDPN = false);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KFCKINPBNMH(uint KGCFOAELMEM, ReadOnlySpan<byte> OLKLJLNLNLM, ReadOnlySpan<byte> JNKIHAKAIHF, bool HMPENGGGDPN = false);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface PECBFDBLHFB
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GPDFPLMMBGM(GameObject HOHLOJNOGCD);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface CEIDPDNJENK
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKIDINGHPBH(string JJJNODJJIFK);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface IEFLBCNKOBP
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int EDDECIFMCCH(GameObject HOHLOJNOGCD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAMNDGKMBAG(GameObject HOHLOJNOGCD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HEDMOGKEMMF(int PGMBNNJMIFL);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object KNEOJGOGDDD(NOFNFJEBPPG OJJIOPECNPL, GameObject HOHLOJNOGCD, Action<NOFNFJEBPPG, int> HLFIKKGGCCK);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EAMGOANLBBM(GameObject HOHLOJNOGCD, object ELBJPGAHCAF);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface BEHHGBPDABJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool CLNJDIKLKLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate GKDJAEKODDB(DIHGHIBMLDL.CEJFFOEHKDP IACIFFOLPPP, Action<DIHGHIBMLDL.CEJFFOEHKDP> HLFIKKGGCCK);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ELAMOGGFOMD(DIHGHIBMLDL.CEJFFOEHKDP IACIFFOLPPP, Delegate HLFIKKGGCCK);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate HHBMGJKMELL(DIHGHIBMLDL.CEJFFOEHKDP IACIFFOLPPP, Action<DIHGHIBMLDL.CEJFFOEHKDP> BJNAJLKCDDO);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JOPCPLPMACM(DIHGHIBMLDL.CEJFFOEHKDP IACIFFOLPPP, Delegate HLFIKKGGCCK);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ECGJJHKFHFE(DIHGHIBMLDL.CEJFFOEHKDP IACIFFOLPPP);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DIHGHIBMLDL.CEJFFOEHKDP AEIDNBMHGPG(GameObject HOHLOJNOGCD);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface GJNPKGJCAFN
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	int PFIPGHLMMCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	int AOHPPLPDECN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int AIBPIAIJHLD(GameObject HOHLOJNOGCD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EBGHEAHNHBM([Out] Vector3 BJIKBOECFPB);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IGJJLDPHHOH();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface GLIKCJAIHBE
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool FGHHMAIFIGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool MOBMLFDGMMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface HCPHMONKIKB
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	HFHDKKLEEBH BFGAIDOLOJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	ANGEEELJMNE BLJOJIBIFLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CJOHLEGFCGB(Transform JKAOMNONHAG);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OMJNOHJJAPE(Transform JKAOMNONHAG, LFIEDIGFABH FMLCCLILCIH);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ICNBFDHCCKF(Transform JKAOMNONHAG, MKFOLIFJABD AHFIKOMACCN);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface NMPEOMJDKMJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BDGNHAMHLMA();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface PFGJAFMMFCC
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BLMDHPBCIFE();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface PFKBFKFMEGF
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PLACGONOKNH CDBFEEIODAJ(GameObject JEDPLPDPMGC);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KGPHCFFCHML(GameObject HOHLOJNOGCD, GMGCKILLHIB AJKMLFAJDFB, CPLMIMIADNG IJOKPINDJPH);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string PABIJICDLFA(int JKEKANKKCCC);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int FKLDNPCDLPG(string KHOLDKJFPPN);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GEGKEOAPOFD(NOFNFJEBPPG OJJIOPECNPL, int[] GDLGHCFALIO);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PBPBDOBIOLG(InteractionFilterData GPKMLHOONCL, int BFJJJMDOJBG);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CCEPANGHLKG(NOFNFJEBPPG OJJIOPECNPL, int GDLGHCFALIO);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OFKAHAFNNAD(NOFNFJEBPPG OJJIOPECNPL, int GDLGHCFALIO);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BCDCJEPDNMA(NOFNFJEBPPG OJJIOPECNPL, bool PBDKCEDGDKM, float3 MHPGNIGAABC, quaternion GGEOJOIPCJG);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct GAIIDFMIHHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly INFGHFCLEIN GGOAAGPAMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly INFGHFCLEIN FPNFHKNNNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal readonly uint EGDKJPECMEF;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x63978F0", Offset = "0x63968F0", VA = "0x1863978F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct ANFACMIHHFN
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly NDLEKAMCBHL LAGKGKDNMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly GAIIDFMIHHH LNMJHEPMAAO;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x638D3F0", Offset = "0x638C3F0", VA = "0x18638D3F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct GJNKHKALFJL
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly NDLEKAMCBHL LAGKGKDNMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly GAIIDFMIHHH LNMJHEPMAAO;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x638D3F0", Offset = "0x638C3F0", VA = "0x18638D3F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct DGLHIFFILNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint EGDKJPECMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly bool IDEAHMINLNB;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6392860", Offset = "0x6391860", VA = "0x186392860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct INFGHFCLEIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal int NGKDOMEFDDB;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6399180", Offset = "0x6398180", VA = "0x186399180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface DAOILKNMDFD
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	FOKBFFDDNCJ BBPDHMGDNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum DENHEOMCIEC
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
public interface JMDGFCECOJD : PKJEEEJJPPN
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	NEGNIICHCKG PNEGOLACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	DENHEOMCIEC DNIBHEEJAHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool AACIMNOBLKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	GameObject HOHLOJNOGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<JMDGFCECOJD> IEJPNFOCFBO;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(NFAOAMBMPDB OLCIHNFFNMN, NOFNFJEBPPG HFAJNNFFFAD);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool IEJEMEHJDFD);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class FELPENEOMKJ
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6397520", Offset = "0x6396520", VA = "0x186397520")]
	public static bool OEAIGCDGPND(this JMDGFCECOJD BKIDBAPHALK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6397440", Offset = "0x6396440", VA = "0x186397440")]
	public static bool NLKLIJOLHPE(this JMDGFCECOJD BKIDBAPHALK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x63973F0", Offset = "0x63963F0", VA = "0x1863973F0")]
	public static bool JOLNBFMEPHF(this JMDGFCECOJD BKIDBAPHALK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6397490", Offset = "0x6396490", VA = "0x186397490")]
	public static bool NPKMANILOIC(this JMDGFCECOJD BKIDBAPHALK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface PKJEEEJJPPN
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool OLODGLIPGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	NOFNFJEBPPG ONFNEGMNIMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[CDGCFHBGICH(DOECOPLPHCH.LoadInstance)]
internal interface LNKGIPPOFNG
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<FHLCADEBNLH> CDGEKCKLBDA;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface BAHONCBBMJM
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface PJJDDEGBEKP
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(KMOJNPOCKBC EBKJFLAFMAB);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface KMOJNPOCKBC
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	GameObject HOHLOJNOGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Transform JKAOMNONHAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	BOJDJCGCFMG FHLOIFPFKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool JADDMCIFKEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HENKOJJCJEL(BOJDJCGCFMG OFFMGNOKEOO);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface BOJDJCGCFMG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	NOFNFJEBPPG ONFNEGMNIMD
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	Rigidbody FDIPIHCLHPM
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	KMOJNPOCKBC HGAHPJBABJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	GameObject GJCLDNHCHFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	Transform EAHPGDBNGDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	BOJDJCGCFMG MILAJCEOCBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	BOJDJCGCFMG NNCBLFAOELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	int EDAKNKJNJME
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool ECGJJHKFHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool HCNGLELBJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	BGLLLMAKHCH LIBOIILFAKL
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	EADDLCIMNLA HLMFNPADCNG
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	float DLPJBFBAGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	Vector3 GNIJNDIJCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	Vector3 GLOADELBEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	Vector3 HENBBEFCDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Vector3 BNHEIIAPBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	bool GOKKHBFMOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	bool KHOLFIBMOJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	bool LEDPLHBJICL
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 NFNLBCAFKLM
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	Vector3 OLPICLBCHEC
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 AKGFLCJGLGG
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "50")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Vector3 ALFJLBFCNPA
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	float JJJAFIFADHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float OBPCCJIKNGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 FMGJIJKKMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Quaternion MGCGHGJEPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	float BIJOGJPJFHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float AKNGIKMOIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	bool BPKCKECFMIF
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	HLEHOHIHLOC EDJEBEDGABJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool EIEMCPKOECE
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Transform ADFIPMCFPOO
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Vector3 MBMPBKDBNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	float NHENDHLPPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	float LOCPNBPMDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	Quaternion LAKOFGKCADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Vector3 OBJFNILBNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Quaternion KFGIAIMBKPH
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	RigidbodyConstraints CHMNFEIOEOL
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool KJNJAAONODH
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	CollisionDetectionMode NDGMOPBCDFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool AJCGGKDIPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event DGOFPGGNFJP JFHNFKPPMEC;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event DGOFPGGNFJP HMPCCEAHOEA;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event DGOFPGGNFJP KIOKNGMJMPL;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event DGOFPGGNFJP GFDECECHNDK;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event DGOFPGGNFJP JLKABBMECML;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event DGOFPGGNFJP MDPNGGMBOHD;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event DGOFPGGNFJP ANNJEHCBGGA;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event CBDBCCOAADF HCLIALJDDKI;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<DCFIIAFEJOH, DCFIIAFEJOH> IFLHJOAAPEF;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "26")]
	BOJDJCGCFMG KHDHHNMCMKL(int GPEHCABDGEJ);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void CACBNOKEGDD((Quaternion rot, Vector3 moments) AFGCIFLCAMM);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void KLABGHMFFPK();

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void IFFBACPBNDE();

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void NHILPMPKHGL();

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void LJLGIJFOGKH();

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void OEOFJMNAFOJ(BOJDJCGCFMG LDGMLLMKHLF, bool MKBGEMOIAJC = false);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void EBLINJOMMLD(object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void FIFANNIAEBO(object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 PCDPBCIHPMF(Vector3 EHDONMPNJKF);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "95")]
	Vector3 KFDJIPPCPAC(Vector3 EALHJCELKMC);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void CNBLDBEPIJO();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void NBFLDFHDMAO();

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void OCMGPNCLHDE();

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void LAALPFGIDKP(Vector3 GEFAOGEPMNH, Vector3 DHJFGPMFDHA);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void NMHNLHDMDNG(Vector3 AOILAALLFEL, Vector3 KMLMDMHBLNP);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void DBGNEKAAJMN(Vector3 LJLBLGLLKLB);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void FEBHEIBFEHM(MEKFJPELAOM MMJDJKINIEI, Vector3 JJCDAOEEONM, float APHKJGDFGHN, float FPIBBDFFLEM = 8f, float DMLBKDPKECC = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void PPJIHGGOEEG(FNFFNOPGDAE BIGJKOCLOKM, Vector3 PKJJGHKMLBD, float JGGJJDNDNCC = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void ECMFHAEHEHN(FNFFNOPGDAE BIGJKOCLOKM, Vector3 CKCOAEGKOKA, float GPACIKBBBFF = 7f, float KCOELLNBOPI = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "105")]
	Vector3 AHHIJEOIOIL(Vector3 LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "106")]
	Vector3 IAIOKFDJFOI(Vector3 LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void NNABBBGCDDE();

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void HNFKCCCCKML(BOJDJCGCFMG GBOPLKAOBPK, object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "109")]
	void PNIGGPGGNJB(object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void DNPAFIBIPED();

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void MEMEKBFDJIA();

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void PGAPFLHOLLI();

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "113")]
	bool FKBLMGOIBCC();

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void HMJJMGLGKAF();

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void LKKLCJKCPGN(object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "116")]
	void ILMFNMCMDMF(object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void NBOPJNDAAAI(object KONODCHOCOG, bool DALNOEDDEKB);

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void MPFPILCPKOL(Vector3 CMEGFIPCBCA, Quaternion DHACMNNFPAD);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void KBLCFEOGFLA(Vector3 NIPGJDJBIOA, Quaternion GHLENEHONEJ);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "120")]
	bool FOBJJPOFAAC(float FOHBFABOGNJ);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void KEBJJEPGHJJ(object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void MCIDAFBPLMF(object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void GBIEFGOKLIL(object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void IDJCOCMHAEG(object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void PGKGPOKEDFA(Vector3 CLNMAALIOEC, ForceMode LBNNCFGJHGI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void JDKDMOJNKJF(Vector3 CLNMAALIOEC, Vector3 BJIKBOECFPB, ForceMode LBNNCFGJHGI);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void PFKDPNCLGPF(Vector3 KAPPHDNKKED, ForceMode LBNNCFGJHGI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void HDFKIGIDKIK(Vector3 KAPPHDNKKED, ForceMode LBNNCFGJHGI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "129")]
	bool NOBMCNKALEC(Vector3 PFFNCAKFCDH, [Out] RaycastHit LABCFOAKNEI, float MPDLEMGFFNF);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void GPBBJKIHELB();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface EADDLCIMNLA
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELEOLACOBPC(Vector3 KODIMONJNNC);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BDADJPANPNB(Vector3 DNLKJNNJFNH);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IIGDPFHDKOE(Vector3 KODIMONJNNC);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NFNKPFDPCBA(Vector3 DNLKJNNJFNH);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface BGLLLMAKHCH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 KJNJHIEFCOC();

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 BKICNKODLMK();
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public delegate void DGOFPGGNFJP(KMOJNPOCKBC LJOKOAEBAKB);
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum FKDLBBPOLGF
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
public enum MEKFJPELAOM
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
public delegate void CBDBCCOAADF(KMOJNPOCKBC LJOKOAEBAKB, bool MKBGEMOIAJC = false);
[Cpp2IlInjected.Token(Token = "0x200003C")]
public enum FNFFNOPGDAE
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct KGDPENLDKCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Rigidbody PEFEIMLIJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object ACBFHDGPGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Vector3 FCDBGFFMOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Vector3 BBBLGHEEJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public KDOAGIGOPNE IIEIOLOGIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public bool FKLGPODHDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public bool CGOMNHGBCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool KKHCEACIBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public bool CKMADOBIGJC;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface JBJCOBLMJIM : DMDJCMJNNME<BLFAMKALCNM>, IAGPJEOHECM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface APBNLMGHNEP<T> : NGDAFPJMODP<BLFAMKALCNM, T>, DMDJCMJNNME<BLFAMKALCNM>, IAGPJEOHECM, IDisposable, JBJCOBLMJIM where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class OAJEAPFOIHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x2713210", Offset = "0x2712210", VA = "0x182713210")]
	public static bool FINPNHLFMNL<T>(this DMDJCMJNNME<BLFAMKALCNM> GFNKMDBLDFI, BLFAMKALCNM PBKJILNOEKG, [Out] T LDGMLLMKHLF) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x294FFE0", Offset = "0x294EFE0", VA = "0x18294FFE0")]
	public static bool PGLEONAELKI<T>(this DMDJCMJNNME<BLFAMKALCNM> GFNKMDBLDFI, BLFAMKALCNM PBKJILNOEKG, [In] T HDNPJBAOJAB) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface KNJMOJCGIMN : DMDJCMJNNME<NOFNFJEBPPG>, IAGPJEOHECM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface KNMJLKELCCJ<T> : NGDAFPJMODP<NOFNFJEBPPG, T>, DMDJCMJNNME<NOFNFJEBPPG>, IAGPJEOHECM, IDisposable, KNJMOJCGIMN where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class CKMJLJBMJHF
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2719EE0", Offset = "0x2718EE0", VA = "0x182719EE0")]
	public static T HBEPMKJLJFA<T>(this DMDJCMJNNME<NOFNFJEBPPG> GFNKMDBLDFI, NOFNFJEBPPG OJJIOPECNPL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2719F00", Offset = "0x2718F00", VA = "0x182719F00")]
	public static bool PGLEONAELKI<T>(this DMDJCMJNNME<NOFNFJEBPPG> GFNKMDBLDFI, NOFNFJEBPPG OJJIOPECNPL, [In] T HDNPJBAOJAB) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct GIKMEAFMKHD : IComparable<GIKMEAFMKHD>, IEquatable<GIKMEAFMKHD>
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly GIKMEAFMKHD PPEPKDCDIPM;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly GIKMEAFMKHD PHKEADMGLIL;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly GIKMEAFMKHD HMKNICGNICE;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly GIKMEAFMKHD IOFPKJFCINE;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly GIKMEAFMKHD FHHJPLOENFA;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly GIKMEAFMKHD KAPAJCELLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public int CBOGBOOIKCP;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool LFOELODJMEG
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6397C50", Offset = "0x6396C50", VA = "0x186397C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int AMOHLFMMMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6397C60", Offset = "0x6396C60", VA = "0x186397C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x915160", Offset = "0x914160", VA = "0x180915160")]
	public GIKMEAFMKHD(int GPEHCABDGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6397BF0", Offset = "0x6396BF0", VA = "0x186397BF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6397B60", Offset = "0x6396B60", VA = "0x186397B60", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x895C90", Offset = "0x894C90", VA = "0x180895C90", Slot = "5")]
	public bool Equals(GIKMEAFMKHD JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x18A9610", Offset = "0x18A8610", VA = "0x1818A9610", Slot = "4")]
	public int CompareTo(GIKMEAFMKHD JNHFAFOIKEO)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0xD80700", Offset = "0xD7F700", VA = "0x180D80700")]
	public static GIKMEAFMKHD NCBCBLCGNHJ(int GPEHCABDGEJ)
	{
		return default(GIKMEAFMKHD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0xD80700", Offset = "0xD7F700", VA = "0x180D80700")]
	public static int NCBCBLCGNHJ(GIKMEAFMKHD NCCEHAHLBDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6397C70", Offset = "0x6396C70", VA = "0x186397C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct NEGNIICHCKG : IEquatable<NEGNIICHCKG>, PKJEEEJJPPN
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly NEGNIICHCKG BEGBEMDALOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly NOFNFJEBPPG JOPDPKEGIDD;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public NOFNFJEBPPG ONFNEGMNIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0", Slot = "6")]
		get
		{
			return default(NOFNFJEBPPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public DKKIGLDKCDJ EAHPGDBNGDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(DKKIGLDKCDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public HGPFIONDCFH MLNDOKBLGCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(HGPFIONDCFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private NHGHMDMJDML NKCCKBIMPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x638DA70", Offset = "0x638CA70", VA = "0x18638DA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public GameObject HOHLOJNOGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x639B650", Offset = "0x639A650", VA = "0x18639B650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public BLFAMKALCNM HAKEAKDOCGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x639ADD0", Offset = "0x6399DD0", VA = "0x18639ADD0")]
		get
		{
			return default(BLFAMKALCNM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public BDFCCOKJLDJ HACPAFDEGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x639AEB0", Offset = "0x6399EB0", VA = "0x18639AEB0")]
		get
		{
			return default(BDFCCOKJLDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public PLACGONOKNH KKABLCJJCDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x639B530", Offset = "0x639A530", VA = "0x18639B530")]
		get
		{
			return default(PLACGONOKNH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool GFDNOAANMCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x639B7E0", Offset = "0x639A7E0", VA = "0x18639B7E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool LGDLHIMNAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x639AD90", Offset = "0x6399D90", VA = "0x18639AD90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool CCOPKPCLNKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x639B400", Offset = "0x639A400", VA = "0x18639B400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool OPCICKHKFGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x639B490", Offset = "0x639A490", VA = "0x18639B490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool MJGMNLCHLBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x639ADB0", Offset = "0x6399DB0", VA = "0x18639ADB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool FABHHPFCEBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x639B4B0", Offset = "0x639A4B0", VA = "0x18639B4B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool IHDPNKFDNAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x639AE70", Offset = "0x6399E70", VA = "0x18639AE70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool OCFJGIOKBLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x639B450", Offset = "0x639A450", VA = "0x18639B450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool BIOIEJOPPIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x639B390", Offset = "0x639A390", VA = "0x18639B390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public DLHELFKBPAP LAMKIMHBAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(DLHELFKBPAP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public KEIAMABAOAH EONEHOAOPCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(KEIAMABAOAH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public IOIJBHBKGOD IFFLECHHEPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(IOIJBHBKGOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public POMFJJJFHNE HJCBOAIBBNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(POMFJJJFHNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public CNFDAGECGBE KNNOAGADDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(CNFDAGECGBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public BNFNJBJDFOK EFDOGHLKDCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(BNFNJBJDFOK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public EMOEILOIFJN LOFPODCDPOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(EMOEILOIFJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public BFIEDNJLAOG MFOOOBJDENP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(BFIEDNJLAOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public CDICCEMLEHH HMHCDGODDJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(CDICCEMLEHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public DDHCHOMMCIO HAMFJJBNCEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(DDHCHOMMCIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool OEAIGCDGPND
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x639AF50", Offset = "0x6399F50", VA = "0x18639AF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool FEKBIFCEJCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x639B4F0", Offset = "0x639A4F0", VA = "0x18639B4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool GDGKLGNLOBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x639B260", Offset = "0x639A260", VA = "0x18639B260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private bool EPKCEFGOMLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
	public NEGNIICHCKG(NOFNFJEBPPG OJJIOPECNPL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6390CA0", Offset = "0x638FCA0", VA = "0x186390CA0")]
	public static bool NCBCBLCGNHJ(NEGNIICHCKG LDGMLLMKHLF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x882610", Offset = "0x881610", VA = "0x180882610")]
	public static NOFNFJEBPPG NCBCBLCGNHJ(NEGNIICHCKG LDGMLLMKHLF)
	{
		return default(NOFNFJEBPPG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6390510", Offset = "0x638F510", VA = "0x186390510")]
	public static bool JPKEALLKLNK(NEGNIICHCKG AAOIMEIMECG, NEGNIICHCKG ABLGCHAEIGE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x639A8E0", Offset = "0x63998E0", VA = "0x18639A8E0")]
	public static bool OECHKCIMKIG(NEGNIICHCKG AAOIMEIMECG, NEGNIICHCKG ABLGCHAEIGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x638D690", Offset = "0x638C690", VA = "0x18638D690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x639B040", Offset = "0x639A040", VA = "0x18639B040", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x638D5F0", Offset = "0x638C5F0", VA = "0x18638D5F0", Slot = "4")]
	public bool Equals(NEGNIICHCKG JNHFAFOIKEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x882610", Offset = "0x881610", VA = "0x180882610")]
	public static NEGNIICHCKG NCBCBLCGNHJ(NOFNFJEBPPG JOPDPKEGIDD)
	{
		return default(NEGNIICHCKG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x639B5D0", Offset = "0x639A5D0", VA = "0x18639B5D0")]
	public CLBCPOIMKHK MFNCNFJDEDB()
	{
		return default(CLBCPOIMKHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x639B420", Offset = "0x639A420", VA = "0x18639B420")]
	public LOBLMMMKECG KGHMFHPLMCM()
	{
		return default(LOBLMMMKECG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x639B3B0", Offset = "0x639A3B0", VA = "0x18639B3B0")]
	public KJLCKIHGKJG IJCFOLAGOAO()
	{
		return default(KJLCKIHGKJG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x639B0D0", Offset = "0x639A0D0", VA = "0x18639B0D0")]
	public void FDJEMHAFDGK([Optional] object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x639B2A0", Offset = "0x639A2A0", VA = "0x18639B2A0")]
	public bool GHDOMGBJCCJ(object KONODCHOCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x639B170", Offset = "0x639A170", VA = "0x18639B170")]
	public bool GAKMIGDGGBP(object KONODCHOCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x639B800", Offset = "0x639A800", VA = "0x18639B800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct EMOEILOIFJN : IEquatable<EMOEILOIFJN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly NOFNFJEBPPG JOPDPKEGIDD;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public NOFNFJEBPPG ONFNEGMNIMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NOFNFJEBPPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public NEGNIICHCKG PNEGOLACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NEGNIICHCKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private NHGHMDMJDML NKCCKBIMPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x638DA70", Offset = "0x638CA70", VA = "0x18638DA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private BPHONMBHKOI NNFHOLPEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6397360", Offset = "0x6396360", VA = "0x186397360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private AAPFLIKBDKG FGKODIHMDEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6396F00", Offset = "0x6395F00", VA = "0x186396F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool ABBLNKAJGGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x63971B0", Offset = "0x63961B0", VA = "0x1863971B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public Guid JNIBIMPDLHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6396DE0", Offset = "0x6395DE0", VA = "0x186396DE0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool NEMAJLBKHNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6397120", Offset = "0x6396120", VA = "0x186397120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Guid PFMLAPGJMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6397240", Offset = "0x6396240", VA = "0x186397240")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
	public EMOEILOIFJN(NOFNFJEBPPG OJJIOPECNPL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6390CA0", Offset = "0x638FCA0", VA = "0x186390CA0")]
	public static bool NCBCBLCGNHJ(EMOEILOIFJN LDGMLLMKHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x638D690", Offset = "0x638C690", VA = "0x18638D690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6396F60", Offset = "0x6395F60", VA = "0x186396F60", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x638D5F0", Offset = "0x638C5F0", VA = "0x18638D5F0", Slot = "4")]
	public bool Equals(EMOEILOIFJN JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x638D720", Offset = "0x638C720", VA = "0x18638D720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6396FF0", Offset = "0x6395FF0", VA = "0x186396FF0")]
	public bool FEIAGIAANHP([Out] Guid ABBEJOMODMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6396CC0", Offset = "0x6395CC0", VA = "0x186396CC0")]
	public void BKFCCJNLPOD(Guid PAFHPJKJPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6396C20", Offset = "0x6395C20", VA = "0x186396C20")]
	public bool BHBEMEFPMPI([Out] Guid KBFBOOCDDFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6396B00", Offset = "0x6395B00", VA = "0x186396B00")]
	public void ANHPCJMJCPL(Guid PAFHPJKJPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6397090", Offset = "0x6396090", VA = "0x186397090")]
	public void GMEDDILACON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct KJLCKIHGKJG : IEquatable<KJLCKIHGKJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly NOFNFJEBPPG JOPDPKEGIDD;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public NOFNFJEBPPG ONFNEGMNIMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NOFNFJEBPPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public NEGNIICHCKG PNEGOLACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NEGNIICHCKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private NHGHMDMJDML NKCCKBIMPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x638DA70", Offset = "0x638CA70", VA = "0x18638DA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private BPHONMBHKOI NNFHOLPEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6399BF0", Offset = "0x6398BF0", VA = "0x186399BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private PDLIOLLJFGJ BACCBPBAHNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6399B90", Offset = "0x6398B90", VA = "0x186399B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 FNBIJCDAOAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6399920", Offset = "0x6398920", VA = "0x186399920")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Quaternion IODKPILLMEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6399C80", Offset = "0x6398C80", VA = "0x186399C80")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public NEGNIICHCKG PPFJDGICJCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6399A70", Offset = "0x6398A70", VA = "0x186399A70")]
		get
		{
			return default(NEGNIICHCKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
	public KJLCKIHGKJG(NOFNFJEBPPG OJJIOPECNPL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x882610", Offset = "0x881610", VA = "0x180882610")]
	public static NOFNFJEBPPG NCBCBLCGNHJ(KJLCKIHGKJG LDGMLLMKHLF)
	{
		return default(NOFNFJEBPPG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x638D690", Offset = "0x638C690", VA = "0x18638D690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6399B00", Offset = "0x6398B00", VA = "0x186399B00", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x638D5F0", Offset = "0x638C5F0", VA = "0x18638D5F0", Slot = "4")]
	public bool Equals(KJLCKIHGKJG JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x638D720", Offset = "0x638C720", VA = "0x18638D720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct CLBCPOIMKHK : IEquatable<CLBCPOIMKHK>
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly CLBCPOIMKHK BEGBEMDALOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly NOFNFJEBPPG JOPDPKEGIDD;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public NOFNFJEBPPG ONFNEGMNIMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NOFNFJEBPPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public NEGNIICHCKG PNEGOLACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NEGNIICHCKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public DKKIGLDKCDJ EAHPGDBNGDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(DKKIGLDKCDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public HGPFIONDCFH MLNDOKBLGCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(HGPFIONDCFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private NHGHMDMJDML NKCCKBIMPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x638DA70", Offset = "0x638CA70", VA = "0x18638DA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private BPHONMBHKOI NNFHOLPEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6390ED0", Offset = "0x638FED0", VA = "0x186390ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private IKLKAFPKEDF AGDHMJBOBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x638F760", Offset = "0x638E760", VA = "0x18638F760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public BPHEFFILCAL GEJEIDOJJDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6390A80", Offset = "0x638FA80", VA = "0x186390A80")]
		get
		{
			return default(BPHEFFILCAL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public IEnumerable<NEGNIICHCKG> CLDMIFOOGLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6390910", Offset = "0x638F910", VA = "0x186390910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public IEnumerable<NEGNIICHCKG> KGDPMCGLNEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6390730", Offset = "0x638F730", VA = "0x186390730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public int EDAKNKJNJME
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6390C10", Offset = "0x638FC10", VA = "0x186390C10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int CCPLMFDEPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x638F2E0", Offset = "0x638E2E0", VA = "0x18638F2E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public string FJOKHGLGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x638F400", Offset = "0x638E400", VA = "0x18638F400")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x6390860", Offset = "0x638F860", VA = "0x186390860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public LKAELOHNMPI KKEEPGEGLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x638F7C0", Offset = "0x638E7C0", VA = "0x18638F7C0")]
		get
		{
			return default(LKAELOHNMPI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x638F390", Offset = "0x638E390", VA = "0x18638F390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public MDNCIBFEOMH PHAAHLDGPMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6390B40", Offset = "0x638FB40", VA = "0x186390B40")]
		get
		{
			return default(MDNCIBFEOMH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x638F820", Offset = "0x638E820", VA = "0x18638F820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public CGPNNOLEFAM LFHFOFGJLEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x638F330", Offset = "0x638E330", VA = "0x18638F330")]
		get
		{
			return default(CGPNNOLEFAM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x638F5F0", Offset = "0x638E5F0", VA = "0x18638F5F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public float BOJPPNECKFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x638F280", Offset = "0x638E280", VA = "0x18638F280")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x638F510", Offset = "0x638E510", VA = "0x18638F510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool NGFMLIHBHAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6390E00", Offset = "0x638FE00", VA = "0x186390E00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x63904A0", Offset = "0x638F4A0", VA = "0x1863904A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool KLCOKDGEEBC
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6391230", Offset = "0x6390230", VA = "0x186391230")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x638F580", Offset = "0x638E580", VA = "0x18638F580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool GJMNAENAKON
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6390520", Offset = "0x638F520", VA = "0x186390520")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6390CC0", Offset = "0x638FCC0", VA = "0x186390CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool AKFFBJMGECG
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x638F700", Offset = "0x638E700", VA = "0x18638F700")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6391290", Offset = "0x6390290", VA = "0x186391290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool NCFEMHIBMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x63900D0", Offset = "0x638F0D0", VA = "0x1863900D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6390E60", Offset = "0x638FE60", VA = "0x186390E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool JBCONPKBKPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x638F890", Offset = "0x638E890", VA = "0x18638F890")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6390D90", Offset = "0x638FD90", VA = "0x186390D90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool DLEHEODEBLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x638F4B0", Offset = "0x638E4B0", VA = "0x18638F4B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6390BA0", Offset = "0x638FBA0", VA = "0x186390BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public GMBEFCLIDAN LONJOFDFKCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6390D30", Offset = "0x638FD30", VA = "0x186390D30")]
		get
		{
			return default(GMBEFCLIDAN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x638F980", Offset = "0x638E980", VA = "0x18638F980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public IEnumerable<int> OCLCIJLCLJM
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x638F660", Offset = "0x638E660", VA = "0x18638F660")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6390FD0", Offset = "0x638FFD0", VA = "0x186390FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public int OFEGALIINPO
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x638FF90", Offset = "0x638EF90", VA = "0x18638FF90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
	public CLBCPOIMKHK(NOFNFJEBPPG OJJIOPECNPL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6390CA0", Offset = "0x638FCA0", VA = "0x186390CA0")]
	public static bool NCBCBLCGNHJ(CLBCPOIMKHK LDGMLLMKHLF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6390510", Offset = "0x638F510", VA = "0x186390510")]
	public static bool JPKEALLKLNK(CLBCPOIMKHK AAOIMEIMECG, CLBCPOIMKHK ABLGCHAEIGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x638D690", Offset = "0x638C690", VA = "0x18638D690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x638F8F0", Offset = "0x638E8F0", VA = "0x18638F8F0", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x638D5F0", Offset = "0x638C5F0", VA = "0x18638D5F0", Slot = "4")]
	public bool Equals(CLBCPOIMKHK JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x638D720", Offset = "0x638C720", VA = "0x18638D720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x882610", Offset = "0x881610", VA = "0x180882610")]
	public static NEGNIICHCKG NCBCBLCGNHJ(CLBCPOIMKHK HFLBADIEKAM)
	{
		return default(NEGNIICHCKG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x63900B0", Offset = "0x638F0B0", VA = "0x1863900B0")]
	public bool JFBHNCDGICJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6390F60", Offset = "0x638FF60", VA = "0x186390F60")]
	public bool OIGAINEHEEH(JIDDLIBAHMP JIBBCLPNIGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6390030", Offset = "0x638F030", VA = "0x186390030")]
	public void ICFJBDGKHCI(JIDDLIBAHMP JIBBCLPNIGH, bool LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6390580", Offset = "0x638F580", VA = "0x186390580")]
	public BPHEFFILCAL KKKBGOPGLCM(Allocator NFBFCGHLHAF)
	{
		return default(BPHEFFILCAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6390130", Offset = "0x638F130", VA = "0x186390130")]
	public void JKFNBPCGLAJ(CLBCPOIMKHK JNHFAFOIKEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x638F9F0", Offset = "0x638E9F0", VA = "0x18638F9F0")]
	public void GIBGAKBPLBO(List<NEGNIICHCKG> AGICEGCGLOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct DHLKEOMACJD : IEquatable<DHLKEOMACJD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly NOFNFJEBPPG JOPDPKEGIDD;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public NEGNIICHCKG PNEGOLACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NEGNIICHCKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x638D690", Offset = "0x638C690", VA = "0x18638D690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6392900", Offset = "0x6391900", VA = "0x186392900", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x638D5F0", Offset = "0x638C5F0", VA = "0x18638D5F0", Slot = "4")]
	public bool Equals(DHLKEOMACJD JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x638D720", Offset = "0x638C720", VA = "0x18638D720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct KEIAMABAOAH : IEquatable<KEIAMABAOAH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly NOFNFJEBPPG JOPDPKEGIDD;

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public NEGNIICHCKG PNEGOLACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NEGNIICHCKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private NHGHMDMJDML NKCCKBIMPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x638DA70", Offset = "0x638CA70", VA = "0x18638DA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
	public KEIAMABAOAH(NOFNFJEBPPG OJJIOPECNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x638D690", Offset = "0x638C690", VA = "0x18638D690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x63996A0", Offset = "0x63986A0", VA = "0x1863996A0", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x638D5F0", Offset = "0x638C5F0", VA = "0x18638D5F0", Slot = "4")]
	public bool Equals(KEIAMABAOAH JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x638D720", Offset = "0x638C720", VA = "0x18638D720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6399730", Offset = "0x6398730", VA = "0x186399730")]
	public void FAAFJENLCBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6399560", Offset = "0x6398560", VA = "0x186399560")]
	public void AHCMJKDHEOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x6399600", Offset = "0x6398600", VA = "0x186399600")]
	public bool CFIPAPCELIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct HGPFIONDCFH : IEquatable<HGPFIONDCFH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly NOFNFJEBPPG JOPDPKEGIDD;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public NOFNFJEBPPG ONFNEGMNIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NOFNFJEBPPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public NEGNIICHCKG PNEGOLACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NEGNIICHCKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	private NHGHMDMJDML NKCCKBIMPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x638DA70", Offset = "0x638CA70", VA = "0x18638DA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private BPHONMBHKOI NNFHOLPEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x63987D0", Offset = "0x63977D0", VA = "0x1863987D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private IKLKAFPKEDF AGDHMJBOBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6398160", Offset = "0x6397160", VA = "0x186398160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public NOFNFJEBPPG NALJJAJALME
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6398250", Offset = "0x6397250", VA = "0x186398250")]
		get
		{
			return default(NOFNFJEBPPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public NEGNIICHCKG MILAJCEOCBC
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6398070", Offset = "0x6397070", VA = "0x186398070")]
		get
		{
			return default(NEGNIICHCKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public NEGNIICHCKG NNCBLFAOELK
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x6397FE0", Offset = "0x6396FE0", VA = "0x186397FE0")]
		get
		{
			return default(NEGNIICHCKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
	public HGPFIONDCFH(NOFNFJEBPPG OJJIOPECNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x638D690", Offset = "0x638C690", VA = "0x18638D690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x63981C0", Offset = "0x63971C0", VA = "0x1863981C0", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x638D5F0", Offset = "0x638C5F0", VA = "0x18638D5F0", Slot = "4")]
	public bool Equals(HGPFIONDCFH JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x638D720", Offset = "0x638C720", VA = "0x18638D720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x63986A0", Offset = "0x63976A0", VA = "0x1863986A0")]
	public bool OEOFJMNAFOJ(NEGNIICHCKG NNHBJFPLAAA, bool NHOBIEBNNHC = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x63982E0", Offset = "0x63972E0", VA = "0x1863982E0")]
	public bool FOCOLPLKPCN(NEGNIICHCKG MCFHNMHDGHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6398380", Offset = "0x6397380", VA = "0x186398380")]
	private void JMAPIGLFKGP(NEGNIICHCKG FJHGPANNOKN, List<NEGNIICHCKG> DPNGGKHDMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6398610", Offset = "0x6397610", VA = "0x186398610")]
	public CLBCPOIMKHK LNHLJMEFFPE()
	{
		return default(CLBCPOIMKHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6398100", Offset = "0x6397100", VA = "0x186398100")]
	public void CIIEMDEFNKI(List<NEGNIICHCKG> LBGHOMJJMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6398860", Offset = "0x6397860", VA = "0x186398860")]
	public NativeArray<NOFNFJEBPPG> PHNJOPODPCA()
	{
		return default(NativeArray<NOFNFJEBPPG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct DLHELFKBPAP : IEquatable<DLHELFKBPAP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly NOFNFJEBPPG JOPDPKEGIDD;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public NEGNIICHCKG PNEGOLACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NEGNIICHCKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public string POHNNMMDIIN
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x6395350", Offset = "0x6394350", VA = "0x186395350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public string JKFJFGJIDFF
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x6395280", Offset = "0x6394280", VA = "0x186395280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private bool EMOIGBOIDMK
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x6394E60", Offset = "0x6393E60", VA = "0x186394E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public string AFNBACIDFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x63953D0", Offset = "0x63943D0", VA = "0x1863953D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public string AEMICNNONMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x6394FA0", Offset = "0x6393FA0", VA = "0x186394FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public string PGHJHMDJJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x6394D70", Offset = "0x6393D70", VA = "0x186394D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
	public DLHELFKBPAP(NOFNFJEBPPG OJJIOPECNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x638D690", Offset = "0x638C690", VA = "0x18638D690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x63951F0", Offset = "0x63941F0", VA = "0x1863951F0", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x638D5F0", Offset = "0x638C5F0", VA = "0x18638D5F0", Slot = "4")]
	public bool Equals(DLHELFKBPAP JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x638D720", Offset = "0x638C720", VA = "0x18638D720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct FHADGKOKDAL : IEquatable<FHADGKOKDAL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly NOFNFJEBPPG JOPDPKEGIDD;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public NEGNIICHCKG PNEGOLACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NEGNIICHCKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x638D690", Offset = "0x638C690", VA = "0x18638D690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6397570", Offset = "0x6396570", VA = "0x186397570", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x638D5F0", Offset = "0x638C5F0", VA = "0x18638D5F0", Slot = "4")]
	public bool Equals(FHADGKOKDAL JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x638D720", Offset = "0x638C720", VA = "0x18638D720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct IOIJBHBKGOD : IEquatable<IOIJBHBKGOD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly NOFNFJEBPPG JOPDPKEGIDD;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public NEGNIICHCKG PNEGOLACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NEGNIICHCKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
	public IOIJBHBKGOD(NOFNFJEBPPG OJJIOPECNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x638D690", Offset = "0x638C690", VA = "0x18638D690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x63991E0", Offset = "0x63981E0", VA = "0x1863991E0", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x638D5F0", Offset = "0x638C5F0", VA = "0x18638D5F0", Slot = "4")]
	public bool Equals(IOIJBHBKGOD JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x638D720", Offset = "0x638C720", VA = "0x18638D720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6399270", Offset = "0x6398270", VA = "0x186399270")]
	public bool PAPPOLDKGBC([Out] Collider MDIOCJFNBPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct DDHCHOMMCIO : IEquatable<DDHCHOMMCIO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly NOFNFJEBPPG JOPDPKEGIDD;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public NOFNFJEBPPG ONFNEGMNIMD
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NOFNFJEBPPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public NEGNIICHCKG PNEGOLACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NEGNIICHCKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private COBFHJNGGPC NBGIJKIBOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6391FC0", Offset = "0x6390FC0", VA = "0x186391FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
	public DDHCHOMMCIO(NOFNFJEBPPG OJJIOPECNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x638D690", Offset = "0x638C690", VA = "0x18638D690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6392080", Offset = "0x6391080", VA = "0x186392080", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x638D5F0", Offset = "0x638C5F0", VA = "0x18638D5F0", Slot = "4")]
	public bool Equals(DDHCHOMMCIO JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x638D720", Offset = "0x638C720", VA = "0x18638D720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6392110", Offset = "0x6391110", VA = "0x186392110")]
	public void HJMCAMNCKEH(bool KJEJKPAMMID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct POMFJJJFHNE : IEquatable<POMFJJJFHNE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly NOFNFJEBPPG JOPDPKEGIDD;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public NOFNFJEBPPG ONFNEGMNIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NOFNFJEBPPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public NEGNIICHCKG PNEGOLACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NEGNIICHCKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private NHGHMDMJDML NKCCKBIMPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x638DA70", Offset = "0x638CA70", VA = "0x18638DA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	private BPHONMBHKOI NNFHOLPEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x639E9C0", Offset = "0x639D9C0", VA = "0x18639E9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private ObjectPolicyDataWrapper KKGCLAGCDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x639E4F0", Offset = "0x639D4F0", VA = "0x18639E4F0")]
		get
		{
			return default(ObjectPolicyDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private NavMeshGenerationDataWrapper BIKIBBGGCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x639E020", Offset = "0x639D020", VA = "0x18639E020")]
		get
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool KNAHMJGBJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x639DD60", Offset = "0x639CD60", VA = "0x18639DD60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public bool GLHILCPIAEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x639DFB0", Offset = "0x639CFB0", VA = "0x18639DFB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public bool LCJFABGBGLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x639DF40", Offset = "0x639CF40", VA = "0x18639DF40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool OODBAKJDBBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x639EBE0", Offset = "0x639DBE0", VA = "0x18639EBE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public bool HIJJDBHJBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x639E630", Offset = "0x639D630", VA = "0x18639E630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public bool PBJHABGGFNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x639E5C0", Offset = "0x639D5C0", VA = "0x18639E5C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool ADKGDIKLHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x639EB70", Offset = "0x639DB70", VA = "0x18639EB70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public bool EBCIFIPMEMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x639E550", Offset = "0x639D550", VA = "0x18639E550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public bool OABKJCOJKOA
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x639E810", Offset = "0x639D810", VA = "0x18639E810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public bool CMENBLFHJFH
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x639DDA0", Offset = "0x639CDA0", VA = "0x18639DDA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool EGPMODJOAPK
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x639E2E0", Offset = "0x639D2E0", VA = "0x18639E2E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public bool GGNKCGAENEP
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x639E950", Offset = "0x639D950", VA = "0x18639E950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public bool FJOEHFBMBID
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x639E880", Offset = "0x639D880", VA = "0x18639E880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public bool DHJPNINGJFK
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x639E8F0", Offset = "0x639D8F0", VA = "0x18639E8F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool JEKONFNAILE
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x639EB10", Offset = "0x639DB10", VA = "0x18639EB10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x639DC70", Offset = "0x639CC70", VA = "0x18639DC70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public CCKMMCPNPKF OHNIACCHGJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x639EAB0", Offset = "0x639DAB0", VA = "0x18639EAB0")]
		get
		{
			return default(CCKMMCPNPKF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x639E3C0", Offset = "0x639D3C0", VA = "0x18639E3C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public bool NCBFECALODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x639E110", Offset = "0x639D110", VA = "0x18639E110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public CPLMIMIADNG NOKKBBNBACA
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x639EA50", Offset = "0x639DA50", VA = "0x18639EA50")]
		get
		{
			return default(CPLMIMIADNG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public bool KOEJHODBBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x639E430", Offset = "0x639D430", VA = "0x18639E430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 NEAINOGCAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x639DE80", Offset = "0x639CE80", VA = "0x18639DE80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 DBEKLJFHHEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x639DBC0", Offset = "0x639CBC0", VA = "0x18639DBC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool CHDDCLBFPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x639E6A0", Offset = "0x639D6A0", VA = "0x18639E6A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
	public POMFJJJFHNE(NOFNFJEBPPG OJJIOPECNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x638D690", Offset = "0x638C690", VA = "0x18638D690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x639E080", Offset = "0x639D080", VA = "0x18639E080", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x638D5F0", Offset = "0x638C5F0", VA = "0x18638D5F0", Slot = "4")]
	public bool Equals(POMFJJJFHNE JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x638D720", Offset = "0x638C720", VA = "0x18638D720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x639DE10", Offset = "0x639CE10", VA = "0x18639DE10")]
	public bool AOPHCOPJDCB(MEBBJNKIGHL JIBBCLPNIGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x639E350", Offset = "0x639D350", VA = "0x18639E350")]
	public bool FPDBDPDMJMN(GMGCKILLHIB JIBBCLPNIGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x639DCE0", Offset = "0x639CCE0", VA = "0x18639DCE0")]
	public void AFNKFMIKGLM(GMGCKILLHIB JIBBCLPNIGH, bool GEEDEEIHDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x639E490", Offset = "0x639D490", VA = "0x18639E490")]
	public GMGCKILLHIB HBIBNJFLPLC()
	{
		return default(GMGCKILLHIB);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x639E7A0", Offset = "0x639D7A0", VA = "0x18639E7A0")]
	public bool KBKHKGIIGCM(GMGCKILLHIB LDGMLLMKHLF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct BNFNJBJDFOK : IEquatable<BNFNJBJDFOK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly NOFNFJEBPPG JOPDPKEGIDD;

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public NOFNFJEBPPG ONFNEGMNIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NOFNFJEBPPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public NEGNIICHCKG PNEGOLACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NEGNIICHCKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	private NHGHMDMJDML NKCCKBIMPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x638DA70", Offset = "0x638CA70", VA = "0x18638DA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	private BPHONMBHKOI NNFHOLPEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x638DAD0", Offset = "0x638CAD0", VA = "0x18638DAD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
	public BNFNJBJDFOK(NOFNFJEBPPG OJJIOPECNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x638D690", Offset = "0x638C690", VA = "0x18638D690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x638D950", Offset = "0x638C950", VA = "0x18638D950", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x638D5F0", Offset = "0x638C5F0", VA = "0x18638D5F0", Slot = "4")]
	public bool Equals(BNFNJBJDFOK JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x638D720", Offset = "0x638C720", VA = "0x18638D720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x638DB60", Offset = "0x638CB60", VA = "0x18638DB60")]
	public void PDCAOGENEPA(bool LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x638D9E0", Offset = "0x638C9E0", VA = "0x18638D9E0")]
	public void KPCCLELGJCF(bool LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x26C0640", Offset = "0x26BF640", VA = "0x1826C0640")]
	public T LCKJOHNAGBL<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct CNFDAGECGBE : IEquatable<CNFDAGECGBE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly NOFNFJEBPPG JOPDPKEGIDD;

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public NOFNFJEBPPG ONFNEGMNIMD
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NOFNFJEBPPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public NEGNIICHCKG PNEGOLACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NEGNIICHCKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	private NHGHMDMJDML NKCCKBIMPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x638DA70", Offset = "0x638CA70", VA = "0x18638DA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	private BPHONMBHKOI NNFHOLPEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6391F30", Offset = "0x6390F30", VA = "0x186391F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private KGCMDANCEHN GIGHNGKHGCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6391ED0", Offset = "0x6390ED0", VA = "0x186391ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private OFJOHPHBCID EHAOBLJEHPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x63919C0", Offset = "0x63909C0", VA = "0x1863919C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool KLJLMDHJFGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6391A20", Offset = "0x6390A20", VA = "0x186391A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool PMEJGBAMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x63914E0", Offset = "0x63904E0", VA = "0x1863914E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool KELAKDNHOOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x63913A0", Offset = "0x63903A0", VA = "0x1863913A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool DDBAIIBABBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6391B50", Offset = "0x6390B50", VA = "0x186391B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool EKCDMBGNPBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x6391D90", Offset = "0x6390D90", VA = "0x186391D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool KAIBKMDKICL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x6391930", Offset = "0x6390930", VA = "0x186391930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool DKGADOHGGFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x6391610", Offset = "0x6390610", VA = "0x186391610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool HJLIEMDLBMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x6391C20", Offset = "0x6390C20", VA = "0x186391C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
	public CNFDAGECGBE(NOFNFJEBPPG OJJIOPECNPL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6390CA0", Offset = "0x638FCA0", VA = "0x186390CA0")]
	public static bool NCBCBLCGNHJ(CNFDAGECGBE LDGMLLMKHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x638D690", Offset = "0x638C690", VA = "0x18638D690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6391580", Offset = "0x6390580", VA = "0x186391580", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x638D5F0", Offset = "0x638C5F0", VA = "0x18638D5F0", Slot = "4")]
	public bool Equals(CNFDAGECGBE JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x638D720", Offset = "0x638C720", VA = "0x18638D720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6391E60", Offset = "0x6390E60", VA = "0x186391E60")]
	public bool MOIJPDBDGFD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6391DC0", Offset = "0x6390DC0", VA = "0x186391DC0")]
	public NEGNIICHCKG MIPFHEJMNAN(NEGNIICHCKG AOHFGFEGDPB)
	{
		return default(NEGNIICHCKG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x63913D0", Offset = "0x63903D0", VA = "0x1863913D0")]
	public NOFNFJEBPPG CMCFODKPIBI()
	{
		return default(NOFNFJEBPPG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6391300", Offset = "0x6390300", VA = "0x186391300")]
	public bool BIHGIPIMNKK(NOFNFJEBPPG ENPAABAJBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6391AB0", Offset = "0x6390AB0", VA = "0x186391AB0")]
	public bool INNEMIFHLAF(NOFNFJEBPPG HMKOCKODHEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6391820", Offset = "0x6390820", VA = "0x186391820")]
	public bool GABELOFOOGP(NOFNFJEBPPG AOHFGFEGDPB, [Out] NOFNFJEBPPG ENPAABAJBMI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct LOBLMMMKECG : IEquatable<LOBLMMMKECG>
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly LOBLMMMKECG BEGBEMDALOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly NOFNFJEBPPG JOPDPKEGIDD;

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public NOFNFJEBPPG ONFNEGMNIMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NOFNFJEBPPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public NEGNIICHCKG PNEGOLACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NEGNIICHCKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public DKKIGLDKCDJ EAHPGDBNGDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(DKKIGLDKCDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private ShapeTypeDataWrapper JAAMDMGOMNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x639A7B0", Offset = "0x63997B0", VA = "0x18639A7B0")]
		get
		{
			return default(ShapeTypeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public StandardRenderableVisualDataWrapper HLKKHMBEGBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x639A900", Offset = "0x6399900", VA = "0x18639A900")]
		get
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public PhysicsMaterialDataWrapper LCMMMFFJAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x639A6E0", Offset = "0x63996E0", VA = "0x18639A6E0")]
		get
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public ShapeConfigDataWrapper HDEPOAIFIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x639A680", Offset = "0x6399680", VA = "0x18639A680")]
		get
		{
			return default(ShapeConfigDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public LNMBGIBPONN KDFONLPGBKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x639A870", Offset = "0x6399870", VA = "0x18639A870")]
		get
		{
			return default(LNMBGIBPONN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public APCAPIKDGEA FBIBJOLBPGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x639A620", Offset = "0x6399620", VA = "0x18639A620")]
		get
		{
			return default(APCAPIKDGEA);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x639A1E0", Offset = "0x63991E0", VA = "0x18639A1E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public IAANGPEHLAC CEALGPHFCPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x639A5C0", Offset = "0x63995C0", VA = "0x18639A5C0")]
		get
		{
			return default(IAANGPEHLAC);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x639A250", Offset = "0x6399250", VA = "0x18639A250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public float AGMKCPJLDFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x639A2C0", Offset = "0x63992C0", VA = "0x18639A2C0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x639A0D0", Offset = "0x63990D0", VA = "0x18639A0D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public Vector3 DOILHLJJIOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x639A4A0", Offset = "0x63994A0", VA = "0x18639A4A0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x639A140", Offset = "0x6399140", VA = "0x18639A140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public float LEKNOJNGCCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x639A3B0", Offset = "0x63993B0", VA = "0x18639A3B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public BAOHCLKKAAJ EFPBCLJBJOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x639A810", Offset = "0x6399810", VA = "0x18639A810")]
		get
		{
			return default(BAOHCLKKAAJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x639A740", Offset = "0x6399740", VA = "0x18639A740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
	public LOBLMMMKECG(NOFNFJEBPPG OJJIOPECNPL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6390CA0", Offset = "0x638FCA0", VA = "0x186390CA0")]
	public static bool NCBCBLCGNHJ(LOBLMMMKECG LDGMLLMKHLF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x639A8E0", Offset = "0x63998E0", VA = "0x18639A8E0")]
	public static bool OECHKCIMKIG(LOBLMMMKECG AAOIMEIMECG, LOBLMMMKECG ABLGCHAEIGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x638D690", Offset = "0x638C690", VA = "0x18638D690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x639A320", Offset = "0x6399320", VA = "0x18639A320", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x638D5F0", Offset = "0x638C5F0", VA = "0x18638D5F0", Slot = "4")]
	public bool Equals(LOBLMMMKECG JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x638D720", Offset = "0x638C720", VA = "0x18638D720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x639A420", Offset = "0x6399420", VA = "0x18639A420")]
	public NNFMCPBEDNA GAPIPBKNHDB()
	{
		return default(NNFMCPBEDNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x639A540", Offset = "0x6399540", VA = "0x18639A540")]
	public NEICAAGKNCH HBKFEJHICMG()
	{
		return default(NEICAAGKNCH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct NNFMCPBEDNA : IEquatable<NNFMCPBEDNA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly NOFNFJEBPPG JOPDPKEGIDD;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public NOFNFJEBPPG ONFNEGMNIMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NOFNFJEBPPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public NEGNIICHCKG PNEGOLACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NEGNIICHCKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public LOBLMMMKECG FCBILDBGFEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(LOBLMMMKECG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private PrimitiveShapeDataWrapper IJKHGGMFJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x639C750", Offset = "0x639B750", VA = "0x18639C750")]
		get
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public NGHGEBOPDDH OIDHDJDILNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x639C840", Offset = "0x639B840", VA = "0x18639C840")]
		get
		{
			return default(NGHGEBOPDDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
	public NNFMCPBEDNA(NOFNFJEBPPG OJJIOPECNPL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6390CA0", Offset = "0x638FCA0", VA = "0x186390CA0")]
	public static bool NCBCBLCGNHJ(NNFMCPBEDNA LDGMLLMKHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x638D690", Offset = "0x638C690", VA = "0x18638D690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x639C7B0", Offset = "0x639B7B0", VA = "0x18639C7B0", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x638D5F0", Offset = "0x638C5F0", VA = "0x18638D5F0", Slot = "4")]
	public bool Equals(NNFMCPBEDNA JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x638D720", Offset = "0x638C720", VA = "0x18638D720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[DefaultMember("Item")]
public readonly struct NEICAAGKNCH : IEquatable<NEICAAGKNCH>
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly NEICAAGKNCH BEGBEMDALOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly NOFNFJEBPPG JOPDPKEGIDD;

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public NOFNFJEBPPG ONFNEGMNIMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NOFNFJEBPPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public NEGNIICHCKG PNEGOLACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NEGNIICHCKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public DKKIGLDKCDJ EAHPGDBNGDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(DKKIGLDKCDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private NHGHMDMJDML NKCCKBIMPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x638DA70", Offset = "0x638CA70", VA = "0x18638DA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private BPHONMBHKOI NNFHOLPEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x639C230", Offset = "0x639B230", VA = "0x18639C230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private AEFAHGJABDO COACDLDMEFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x639BF70", Offset = "0x639AF70", VA = "0x18639BF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public LOBLMMMKECG FCBILDBGFEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(LOBLMMMKECG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public DPMLOEBFPBC NPAPIDIBBGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x639BFD0", Offset = "0x639AFD0", VA = "0x18639BFD0")]
		get
		{
			return default(DPMLOEBFPBC);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x639B8E0", Offset = "0x639A8E0", VA = "0x18639B8E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public IEnumerable<DEKLPBBBKMH> NJGBLEOPEDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x639C2C0", Offset = "0x639B2C0", VA = "0x18639C2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public DEKLPBBBKMH EAGDGAFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x639C4D0", Offset = "0x639B4D0", VA = "0x18639C4D0")]
		get
		{
			return default(DEKLPBBBKMH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public int JFLFCJGPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x639C1A0", Offset = "0x639B1A0", VA = "0x18639C1A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
	public NEICAAGKNCH(NOFNFJEBPPG OJJIOPECNPL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6390CA0", Offset = "0x638FCA0", VA = "0x186390CA0")]
	public static bool NCBCBLCGNHJ(NEICAAGKNCH LDGMLLMKHLF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6390510", Offset = "0x638F510", VA = "0x186390510")]
	public static bool JPKEALLKLNK(NEICAAGKNCH AAOIMEIMECG, NEICAAGKNCH ABLGCHAEIGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x638D690", Offset = "0x638C690", VA = "0x18638D690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x639BC30", Offset = "0x639AC30", VA = "0x18639BC30", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x638D5F0", Offset = "0x638C5F0", VA = "0x18638D5F0", Slot = "4")]
	public bool Equals(NEICAAGKNCH JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x638D720", Offset = "0x638C720", VA = "0x18638D720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x639BCC0", Offset = "0x639ACC0", VA = "0x18639BCC0")]
	public DEKLPBBBKMH GAKNFFKFOCL(float3? BJIKBOECFPB, [Optional] quaternion? CKCOAEGKOKA, [Optional] Vector3? GJBNAOHDFNK)
	{
		return default(DEKLPBBBKMH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x639BA00", Offset = "0x639AA00", VA = "0x18639BA00")]
	public DEKLPBBBKMH CENKJJGAGNC(int GPEHCABDGEJ, float3? BJIKBOECFPB, [Optional] quaternion? CKCOAEGKOKA, [Optional] Vector3? GJBNAOHDFNK)
	{
		return default(DEKLPBBBKMH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x639C100", Offset = "0x639B100", VA = "0x18639C100")]
	public void LHDOHJPBAPM(int GPEHCABDGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x639BEE0", Offset = "0x639AEE0", VA = "0x18639BEE0")]
	public void HCLIMFMHPCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct DEKLPBBBKMH : IEquatable<DEKLPBBBKMH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly NOFNFJEBPPG JOPDPKEGIDD;

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public NOFNFJEBPPG ONFNEGMNIMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NOFNFJEBPPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public NEGNIICHCKG PNEGOLACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NEGNIICHCKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public NEICAAGKNCH GAHMDGKJMJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x6392200", Offset = "0x6391200", VA = "0x186392200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float3 OBJFNILBNAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x63926A0", Offset = "0x63916A0", VA = "0x1863926A0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x6392620", Offset = "0x6391620", VA = "0x186392620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public quaternion KFGIAIMBKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x6392180", Offset = "0x6391180", VA = "0x186392180")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x63923E0", Offset = "0x63913E0", VA = "0x1863923E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public float3 FEIDKBJBCDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x6392360", Offset = "0x6391360", VA = "0x186392360")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x6392540", Offset = "0x6391540", VA = "0x186392540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public ANOPJPDFGHP GKMKIPLOOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x6392290", Offset = "0x6391290", VA = "0x186392290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private SplinePointParentDataWrapper AJIMDOLAHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x63924E0", Offset = "0x63914E0", VA = "0x1863924E0")]
		get
		{
			return default(SplinePointParentDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private SplinePointPositionDataWrapper HEAFGJKNCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x63925C0", Offset = "0x63915C0", VA = "0x1863925C0")]
		get
		{
			return default(SplinePointPositionDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private SplinePointRotationDataWrapper LPACHMBDNOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x6392780", Offset = "0x6391780", VA = "0x186392780")]
		get
		{
			return default(SplinePointRotationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private SplinePointScaleDataWrapper MBMNHCMBNCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x6392300", Offset = "0x6391300", VA = "0x186392300")]
		get
		{
			return default(SplinePointScaleDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private SplinePointOrderDataWrapper MMNCCGMLOMB
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x6392720", Offset = "0x6391720", VA = "0x186392720")]
		get
		{
			return default(SplinePointOrderDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
	public DEKLPBBBKMH(NOFNFJEBPPG OJJIOPECNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x638D690", Offset = "0x638C690", VA = "0x18638D690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x6392450", Offset = "0x6391450", VA = "0x186392450", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x638D5F0", Offset = "0x638C5F0", VA = "0x18638D5F0", Slot = "4")]
	public bool Equals(DEKLPBBBKMH JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x638D720", Offset = "0x638C720", VA = "0x18638D720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6392200", Offset = "0x6391200", VA = "0x186392200")]
	public void AJNHOOJIMAF(NEICAAGKNCH LDGMLLMKHLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct CDICCEMLEHH : IEquatable<CDICCEMLEHH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly NOFNFJEBPPG JOPDPKEGIDD;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public NOFNFJEBPPG ONFNEGMNIMD
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NOFNFJEBPPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public NEGNIICHCKG PNEGOLACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NEGNIICHCKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	private NHGHMDMJDML NKCCKBIMPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x638DA70", Offset = "0x638CA70", VA = "0x18638DA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	private BPHONMBHKOI NNFHOLPEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x638EFC0", Offset = "0x638DFC0", VA = "0x18638EFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private HFOBDOLNFBM DIMFHHEEAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x638EF60", Offset = "0x638DF60", VA = "0x18638EF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private ToolCleanupSettingsDataWrapper OPJGHMCEPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x638E4B0", Offset = "0x638D4B0", VA = "0x18638E4B0")]
		get
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public bool IIOHJOLDEFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x638E8F0", Offset = "0x638D8F0", VA = "0x18638E8F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x638E6C0", Offset = "0x638D6C0", VA = "0x18638E6C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool GDLPEPGLBPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x638ED10", Offset = "0x638DD10", VA = "0x18638ED10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x638E950", Offset = "0x638D950", VA = "0x18638E950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public float BKLFAOEFILC
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x638E510", Offset = "0x638D510", VA = "0x18638E510")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x638E9C0", Offset = "0x638D9C0", VA = "0x18638E9C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public bool PMIDFEBICKN
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x638F050", Offset = "0x638E050", VA = "0x18638F050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
	public CDICCEMLEHH(NOFNFJEBPPG OJJIOPECNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x638D690", Offset = "0x638C690", VA = "0x18638D690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x638E860", Offset = "0x638D860", VA = "0x18638E860", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x638D5F0", Offset = "0x638C5F0", VA = "0x18638D5F0", Slot = "4")]
	public bool Equals(CDICCEMLEHH JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x638D720", Offset = "0x638C720", VA = "0x18638D720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x638EB40", Offset = "0x638DB40", VA = "0x18638EB40")]
	public void HAEODEKEBPL(int MMCALBDPLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x638EA30", Offset = "0x638DA30", VA = "0x18638EA30")]
	public bool GJJHHONLHBA([Out] int MMCALBDPLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x638ED70", Offset = "0x638DD70", VA = "0x18638ED70")]
	public void MKCKCGLEHOO(bool AFGEMIGJJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x638EE10", Offset = "0x638DE10", VA = "0x18638EE10")]
	public void NJPOCENFOEA(float DMKGABDFBCB, float IHHBNNLBGHG, float LGKJHIJCLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x638E570", Offset = "0x638D570", VA = "0x18638E570")]
	public void DJCMJOGDLPL(float3 PEBHKBCENGJ, quaternion LLJHAGPLEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x638E730", Offset = "0x638D730", VA = "0x18638E730")]
	public bool EHDDNMLCCGN([Out] float3 PEBHKBCENGJ, [Out] quaternion LLJHAGPLEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x638EBE0", Offset = "0x638DBE0", VA = "0x18638EBE0")]
	public bool JMIOGJONJOP([Out] float GPGJHPEPFMG, [Out] float NBCGLJCHBPO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct DKKIGLDKCDJ : IEquatable<DKKIGLDKCDJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly NOFNFJEBPPG JOPDPKEGIDD;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public NEGNIICHCKG PNEGOLACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NEGNIICHCKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public HGPFIONDCFH MLNDOKBLGCB
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(HGPFIONDCFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private NHGHMDMJDML NKCCKBIMPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x638DA70", Offset = "0x638CA70", VA = "0x18638DA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private OJDLIIODLKN ECPACPLABPF
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6393B70", Offset = "0x6392B70", VA = "0x186393B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool GOBLPBLFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x6392EC0", Offset = "0x6391EC0", VA = "0x186392EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public Vector3 OBJFNILBNAE
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x6394780", Offset = "0x6393780", VA = "0x186394780")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x6394560", Offset = "0x6393560", VA = "0x186394560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Quaternion KFGIAIMBKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x6392A80", Offset = "0x6391A80", VA = "0x186392A80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x6393330", Offset = "0x6392330", VA = "0x186393330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 MBMPBKDBNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x6393150", Offset = "0x6392150", VA = "0x186393150")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x6394940", Offset = "0x6393940", VA = "0x186394940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Quaternion LAKOFGKCADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x6392C80", Offset = "0x6391C80", VA = "0x186392C80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x6393080", Offset = "0x6392080", VA = "0x186393080")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public float NHENDHLPPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x6394200", Offset = "0x6393200", VA = "0x186394200")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x6392BD0", Offset = "0x6391BD0", VA = "0x186392BD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public float LOCPNBPMDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x63946E0", Offset = "0x63936E0", VA = "0x1863946E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public Vector3 FEIDKBJBCDD
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x6393240", Offset = "0x6392240", VA = "0x186393240")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x6393AA0", Offset = "0x6392AA0", VA = "0x186393AA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public Vector3 DDIBGADCGJC
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x6394A10", Offset = "0x6393A10", VA = "0x186394A10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public Matrix4x4 IEHEPPKBNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x6394D30", Offset = "0x6393D30", VA = "0x186394D30")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
	public DKKIGLDKCDJ(NOFNFJEBPPG OJJIOPECNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x638D690", Offset = "0x638C690", VA = "0x18638D690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x6393700", Offset = "0x6392700", VA = "0x186393700", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x638D5F0", Offset = "0x638C5F0", VA = "0x18638D5F0", Slot = "4")]
	public bool Equals(DKKIGLDKCDJ JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x638D720", Offset = "0x638C720", VA = "0x18638D720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x6394B00", Offset = "0x6393B00", VA = "0x186394B00")]
	public PPOBKJNJKIH PJDLDCPINMI()
	{
		return default(PPOBKJNJKIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x6394440", Offset = "0x6393440", VA = "0x186394440")]
	public void LGKMHDLBBHI([Out] Matrix4x4 IPMNAPGBLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x63935C0", Offset = "0x63925C0", VA = "0x1863935C0")]
	public void ELFJFGHMEOA([Out] Vector3 HPKGFEEENEO, [Out] Quaternion LBCEPBECANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x6392F00", Offset = "0x6391F00", VA = "0x186392F00")]
	public void CFAFONJLIIM([Out] RigidTransform ADIDGFKIOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x6393C30", Offset = "0x6392C30", VA = "0x186393C30")]
	public UniformTRS IEODMHNCJJH()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x6393C60", Offset = "0x6392C60", VA = "0x186393C60")]
	public void IEODMHNCJJH([Out] UniformTRS IODAAENEAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x6394C40", Offset = "0x6393C40", VA = "0x186394C40")]
	public UniformTRS PODGMPLOJMA()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x6394C70", Offset = "0x6393C70", VA = "0x186394C70")]
	public void PODGMPLOJMA([Out] UniformTRS ADIDGFKIOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x6394B50", Offset = "0x6393B50", VA = "0x186394B50")]
	public Vector3 PLJMBGNOMMN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x63934F0", Offset = "0x63924F0", VA = "0x1863934F0")]
	public void EIPCBGJCHKD([In] Vector3 LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x6392990", Offset = "0x6391990", VA = "0x186392990")]
	public Vector3 AENCLNDENKN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x6392FB0", Offset = "0x6391FB0", VA = "0x186392FB0")]
	public void CJGCDMANAGL([In] Vector3 LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x6393FE0", Offset = "0x6392FE0", VA = "0x186393FE0")]
	public Quaternion KDHKGBBCGIH()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x6394130", Offset = "0x6393130", VA = "0x186394130")]
	public void KDMKMKACNBM([In] Quaternion LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x6393E90", Offset = "0x6392E90", VA = "0x186393E90")]
	public Quaternion KBNKNBNPIIP()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x63939D0", Offset = "0x63929D0", VA = "0x1863939D0")]
	public void HCFODCODBKN([In] Quaternion LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x6393930", Offset = "0x6392930", VA = "0x186393930")]
	public float GMNNIBOIJIF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x6394630", Offset = "0x6393630", VA = "0x186394630")]
	public void LNECBOHOFAO(float LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6393D20", Offset = "0x6392D20", VA = "0x186393D20")]
	public float IKNKJOKINJB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x63942A0", Offset = "0x63932A0", VA = "0x1863942A0")]
	public void KPAGGHFAAMJ(float LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x6393790", Offset = "0x6392790", VA = "0x186393790")]
	public void FFJADLPHFIH([In] Vector3 LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x6394350", Offset = "0x6393350", VA = "0x186394350")]
	public Vector3 LDIDDFHGNEB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x6393860", Offset = "0x6392860", VA = "0x186393860")]
	public void GIELEHFMGDH([In] Vector3 LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x6392DD0", Offset = "0x6391DD0", VA = "0x186392DD0")]
	public Vector3 BLNCDCCEEOP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x6394870", Offset = "0x6393870", VA = "0x186394870")]
	public void MLECBFEAOIN([In] Vector3 LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x6393400", Offset = "0x6392400", VA = "0x186393400")]
	public Vector3 EIGJIJDEHBH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x6393DC0", Offset = "0x6392DC0", VA = "0x186393DC0")]
	public void JJECKFFLJMI([In] Vector3 LDGMLLMKHLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct BFIEDNJLAOG : IEquatable<BFIEDNJLAOG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly NOFNFJEBPPG JOPDPKEGIDD;

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public NOFNFJEBPPG ONFNEGMNIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NOFNFJEBPPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public NEGNIICHCKG PNEGOLACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
		get
		{
			return default(NEGNIICHCKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public int[] NKAEIFLENHB
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x638D500", Offset = "0x638C500", VA = "0x18638D500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public bool COEMGPCNENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x638D6C0", Offset = "0x638C6C0", VA = "0x18638D6C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x638D490", Offset = "0x638C490", VA = "0x18638D490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x189F2A0", Offset = "0x189E2A0", VA = "0x18189F2A0")]
	public BFIEDNJLAOG(NOFNFJEBPPG OJJIOPECNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x638D690", Offset = "0x638C690", VA = "0x18638D690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x638D600", Offset = "0x638C600", VA = "0x18638D600", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x638D5F0", Offset = "0x638C5F0", VA = "0x18638D5F0", Slot = "4")]
	public bool Equals(BFIEDNJLAOG JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x638D720", Offset = "0x638C720", VA = "0x18638D720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class PIBMKNJLCJJ
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private struct CINDNAOPAIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Guid KAABLCGOLKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public MKDICJOANFB BDINMGEDJAC;
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct MKDICJOANFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int LDGMLLMKHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int JHDKONBFBDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int KGCFOAELMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int JCGBDEENJJP;

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x639ACF0", Offset = "0x6399CF0", VA = "0x18639ACF0")]
		public bool KADCHGLFEIG([Out] BLFAMKALCNM PBKJILNOEKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x639AD70", Offset = "0x6399D70", VA = "0x18639AD70")]
		public MKDICJOANFB(BLFAMKALCNM PBKJILNOEKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x639DA70", Offset = "0x639CA70", VA = "0x18639DA70")]
	public static Guid LIFEIBDHEGE(this BLFAMKALCNM PBKJILNOEKG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x639DA50", Offset = "0x639CA50", VA = "0x18639DA50")]
	public static bool EMHMJMFONBC(this Guid KAABLCGOLKG, [Out] BLFAMKALCNM PBKJILNOEKG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal static class LDDFLIFMBOO
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x6399FA0", Offset = "0x6398FA0", VA = "0x186399FA0")]
	public static BPHONMBHKOI NNFHOLPEIKK(this NOFNFJEBPPG JKEKANKKCCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x6399ED0", Offset = "0x6398ED0", VA = "0x186399ED0")]
	public static NFAOAMBMPDB KKCGFPMMNKI(this NOFNFJEBPPG JKEKANKKCCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x6399DD0", Offset = "0x6398DD0", VA = "0x186399DD0")]
	public static EntityManager HMJAALKJPFG(this NOFNFJEBPPG JKEKANKKCCC)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x295C080", Offset = "0x295B080", VA = "0x18295C080")]
	public static T JPMNANBJCND<T>(this NOFNFJEBPPG JKEKANKKCCC) where T : struct, HMFIKBKNPFM
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x295BD10", Offset = "0x295AD10", VA = "0x18295BD10")]
	public static bool JHNHEHMGNMM<T>(this NOFNFJEBPPG JKEKANKKCCC) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x295BC60", Offset = "0x295AC60", VA = "0x18295BC60")]
	public static bool FDCHBLIDKKH<T>(this NOFNFJEBPPG JKEKANKKCCC) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface AAPFLIKBDKG
{
	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NEMAJLBKHNI(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ABBLNKAJGGI(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FEIAGIAANHP(NOFNFJEBPPG OJJIOPECNPL, [Out] Guid ABBEJOMODMP);

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid IAEPKMJAOGC(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BKFCCJNLPOD(NOFNFJEBPPG OJJIOPECNPL, Guid ABBEJOMODMP);

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BHBEMEFPMPI(NOFNFJEBPPG OJJIOPECNPL, [Out] Guid KBFBOOCDDFE);

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid PPDOFOLDGKJ(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ANHPCJMJCPL(NOFNFJEBPPG OJJIOPECNPL, Guid KBFBOOCDDFE);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GMEDDILACON(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task IKPGDJCJFCP(NOFNFJEBPPG HJKHNDILIPH, NOFNFJEBPPG NNHBJFPLAAA);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[CDGCFHBGICH(DOECOPLPHCH.LoadInstance)]
public interface NMOCEJOGDMK
{
	[Cpp2IlInjected.Token(Token = "0x17000160")]
	Guid MLHOFNFENDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AADELKIDHNE(NativeList<Guid> DBFMICHJKCB, NativeList<Guid> OPFKPFPOGFM, NativeList<FixedString64Bytes> FPLDPNEBANI);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface CBKBINEKGPM
{
	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FDGEBFKEIBP(List<NOFNFJEBPPG> MAELDAECGOK);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ECANANHFGMI(NOFNFJEBPPG HFAJNNFFFAD);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KKCIGOMBCKN(NOFNFJEBPPG HFAJNNFFFAD);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CHIBBJJGJDK(NOFNFJEBPPG HFAJNNFFFAD);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int HKMNJALGKEL(NOFNFJEBPPG HFAJNNFFFAD);

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FCBBPMKHAFN(NOFNFJEBPPG HFAJNNFFFAD, int BFJJJMDOJBG);

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NOFNFJEBPPG GGADCFGMJOP(NOFNFJEBPPG HDLIBBMEPIA);

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FDOAMJDGLEC(NOFNFJEBPPG HDLIBBMEPIA, NOFNFJEBPPG IHMANAIBDDP);

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OAPNNDPPLBJ(NOFNFJEBPPG HDLIBBMEPIA);

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int HIKLDLAJKEP(NOFNFJEBPPG HDLIBBMEPIA);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HPPLLKICJJG(NOFNFJEBPPG HDLIBBMEPIA, int HGJBIOCLJLE);

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GIDDOLAOIAC(NOFNFJEBPPG JOPDPKEGIDD);

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DCMGOEBLMHD(NOFNFJEBPPG OJJIOPECNPL, bool ACDDLDJCKFO);

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JDFLMKHOCLO(NOFNFJEBPPG[] EGJIMMLDENN, bool ACDDLDJCKFO);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface MJHALFBCDJO
{
	[Cpp2IlInjected.Token(Token = "0x17000161")]
	IReadOnlyCollection<FGHPGAJGNNM> MIHGDPONHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CEIAADOAJBG(int OGCKBBAGLEA, [Out] FGHPGAJGNNM PKKFIPNPBHJ);

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FGHPGAJGNNM LBNDCLEILGN(Type KBCNAJKPHNL);
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class LHHOKEMMFOG
{
	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2961850", Offset = "0x2960850", VA = "0x182961850")]
	public static T HGCECCMGAOE<T>(this MJHALFBCDJO LEHNCNEIKKA, Entity KNIDMAMMIEJ) where T : struct, HMFIKBKNPFM
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x29618F0", Offset = "0x29608F0", VA = "0x1829618F0")]
	public static FGHPGAJGNNM LBNDCLEILGN<T>(this MJHALFBCDJO LEHNCNEIKKA) where T : struct, HMFIKBKNPFM
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface KGIMPJEAKJA
{
	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BLFAMKALCNM[] HMPOPPBJJEF(string ONGJKHHOIAM, NEGNIICHCKG KJPLPLIHPEF, bool LPGNBBOOBEC = false);

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JJDJPOJKNJA(string JMIDDGLBCDI, BLFAMKALCNM[] EFEJKJHNICM);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[CDGCFHBGICH(DOECOPLPHCH.LoadInstance)]
public interface PDLIOLLJFGJ
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<NOFNFJEBPPG, NOFNFJEBPPG> MNNMMPGINBN;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<NOFNFJEBPPG, NOFNFJEBPPG> CECHCGHFNAG;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<NOFNFJEBPPG, NOFNFJEBPPG, NOFNFJEBPPG> NJNNACEOGEN;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<NOFNFJEBPPG> HPNGDKLBMOF;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NILDAMKHNLP(NOFNFJEBPPG OJJIOPECNPL, NOFNFJEBPPG HPBJDLMMPEJ);

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NOFNFJEBPPG KKLHDDACLEF(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<NOFNFJEBPPG> FHCNOJEJIDO(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NOFNFJEBPPG EEHMDHIOGPJ(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FGMJENGOLID(NOFNFJEBPPG OJJIOPECNPL, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN);

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JOHNCEJOLOD(NOFNFJEBPPG OJJIOPECNPL, float MHKKHPKKOCE);

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool BPPACHKMKIG(NOFNFJEBPPG OJJIOPECNPL, [Out] RigidTransform BHDPMHIHEAM);

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool ILPNKMDPDHG(NOFNFJEBPPG OJJIOPECNPL, [Out] float LAOPAKMLFMA);

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 PPCCJHHIKIO(KJLCKIHGKJG DLLAJEJNDGL);

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion EPCEKEDGOCH(KJLCKIHGKJG DLLAJEJNDGL);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class KMIFLIEEOFC
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[CDGCFHBGICH(DOECOPLPHCH.LoadInstance)]
public interface JKFAMPNKDHD
{
	[Cpp2IlInjected.Token(Token = "0x17000162")]
	object FPIBCOLODIC
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBICALOOKNB(BPHEFFILCAL EGJIMMLDENN);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public enum KAAPKJACBBL
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class DLPIJMEDIBH
{
	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0xC00CB0", Offset = "0xBFFCB0", VA = "0x180C00CB0")]
	public static bool JJJIFBLEFCM(this KAAPKJACBBL DKOKOEEPCNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0xC00B60", Offset = "0xBFFB60", VA = "0x180C00B60")]
	public static bool BAKOBNJFKIH(this KAAPKJACBBL DKOKOEEPCNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x236D0C0", Offset = "0x236C0C0", VA = "0x18236D0C0")]
	public static bool IJOIIKHJFOF(this KAAPKJACBBL DKOKOEEPCNN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface MMGJOIHPLGG
{
	[Cpp2IlInjected.Token(Token = "0x17000163")]
	KAAPKJACBBL KJFPNAEIHGF
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	KAAPKJACBBL JFKNDPACGEO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	KAAPKJACBBL HKOPKLJMPAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	KAAPKJACBBL FIOFIJAFHNC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	KAAPKJACBBL NLGFAJPKPLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	KAAPKJACBBL OJKNHJAIDFI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	KAAPKJACBBL IFFLECHHEPH
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	KAAPKJACBBL DJFPMMGCFOE
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	KAAPKJACBBL EAOLDCNKEGD
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	KAAPKJACBBL GGOJKHMEKCB
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	KAAPKJACBBL KPOCIJEGLBE
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	KAAPKJACBBL BKOFBKPNGMM
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	KAAPKJACBBL ALNAABJMNFF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface IKLKAFPKEDF
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<FHLCADEBNLH> CDGEKCKLBDA;

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NOFNFJEBPPG ACHDLPHBPJI(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JABHGBEJIPE(List<NOFNFJEBPPG> MAELDAECGOK);

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ANOPJPDFGHP LMCCGPAJMJA(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ANOPJPDFGHP ONCNNEOJLGE(NOFNFJEBPPG NNHBJFPLAAA, NOFNFJEBPPG KFMGLDNFPAF, bool MMICMACBNDO, NOFNFJEBPPG AOHFGFEGDPB);

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NOFNFJEBPPG GLPADCHGGOB(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OEOFJMNAFOJ(NOFNFJEBPPG OJJIOPECNPL, NOFNFJEBPPG NNHBJFPLAAA, bool NHOBIEBNNHC);

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HHGMBGAGKEE(NOFNFJEBPPG OJJIOPECNPL, NOFNFJEBPPG NNHBJFPLAAA);

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool INAJNGHOJAO(NOFNFJEBPPG KKGIDMBCHDF, NOFNFJEBPPG EANGLFCLDOH);

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int LEINIKJOIMH(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BPHEFFILCAL KBJFHGLEFPB(NOFNFJEBPPG JOPDPKEGIDD);

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NativeArray<NOFNFJEBPPG> PHNJOPODPCA(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool PBNLEBNPIJJ(NOFNFJEBPPG OJJIOPECNPL, NOFNFJEBPPG LBLNKMFAJIP);

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<NOFNFJEBPPG> IDHPAGLJLJH(NOFNFJEBPPG OJJIOPECNPL, bool JBGKGMPHNCA = false);

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool FOCOLPLKPCN(NOFNFJEBPPG OJJIOPECNPL, NOFNFJEBPPG MCFHNMHDGHK);

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	NOFNFJEBPPG ADEENOMPPIO(NOFNFJEBPPG AOHFGFEGDPB, NOFNFJEBPPG FMMPCEBEMDJ);

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool KBJCAFOLECL(NOFNFJEBPPG AOHFGFEGDPB, NOFNFJEBPPG FMMPCEBEMDJ, [Out] NOFNFJEBPPG NAAFDBHKMNP);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public static class JCEDNPGEDOH
{
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6399450", Offset = "0x6398450", VA = "0x186399450")]
	public static List<NOFNFJEBPPG> JABHGBEJIPE(this IKLKAFPKEDF KGKFKMCFLBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x63993E0", Offset = "0x63983E0", VA = "0x1863993E0")]
	public static bool ABHAFFOKCAG(this IKLKAFPKEDF KGKFKMCFLBF, NOFNFJEBPPG OJJIOPECNPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[CDGCFHBGICH(DOECOPLPHCH.LoadInstance)]
public interface GODFCKCLCAP
{
	[Cpp2IlInjected.Token(Token = "0x17000170")]
	bool KJOJBFMEFHA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	bool LPIBGAJNLIK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface FHCHPEGFPID : NIMALKDGLKE
{
	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DFNCMLOKJEI(Entity KNIDMAMMIEJ, [Out] LLEMPHEAMPJ NJADCNCCDAJ);

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NOKLGHJELDM(NativeArray<LLEMPHEAMPJ> CCBPBBGJGGO, NativeArray<DFHGEHPJGLL> CKGHEKIAJNJ);

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DDGBPFIKKJJ(LLEMPHEAMPJ NJADCNCCDAJ);

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OLGAJFKEFPI(LLEMPHEAMPJ NJADCNCCDAJ, [Out] Collider MDIOCJFNBPC);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[CDGCFHBGICH(DOECOPLPHCH.LoadInstance)]
public interface NIMALKDGLKE
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FPKEGACJJKE([In] float3 OHFPFGNFPGI, [In] float3 PFFNCAKFCDH, float MPDLEMGFFNF, Allocator NFBFCGHLHAF, [Out] NativeArray<Entity> LEIOAKAEPIN);
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[CDGCFHBGICH(DOECOPLPHCH.LoadInstance)]
public interface GPJDJEJJIBF
{
	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FPKEGACJJKE([In] float3 OHFPFGNFPGI, [In] float3 PFFNCAKFCDH, float MPDLEMGFFNF, [Out] GBNADJLGOLK NKPFABFBCKD, [Out] NOFNFJEBPPG OHAPFGLKHDC);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[CDGCFHBGICH(DOECOPLPHCH.LoadInstance)]
public interface LJNLAMBEJOD
{
	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPKEGACJJKE([In] NativeArray<Entity> LEIOAKAEPIN, [In] float3 OHFPFGNFPGI, [In] float3 PFFNCAKFCDH, [In] NativeArray<GBNADJLGOLK> LCDPJGNJKNN);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct LLEMPHEAMPJ : FFECINGEIPC, IEquatable<LLEMPHEAMPJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public int CBOGBOOIKCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x9151A0", Offset = "0x9141A0", VA = "0x1809151A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x915160", Offset = "0x914160", VA = "0x180915160", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int LDLNMMLFDEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x237F180", Offset = "0x237E180", VA = "0x18237F180", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x56EA740", Offset = "0x56E9740", VA = "0x1856EA740", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x639A030", Offset = "0x6399030", VA = "0x18639A030", Slot = "8")]
	public bool Equals(LLEMPHEAMPJ JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x639A080", Offset = "0x6399080", VA = "0x18639A080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct GBNADJLGOLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float ANHCLLGGJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float3 KMBEHGBELJC;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface JDNFBPEAEKF
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface NHGHMDMJDML
{
	[Cpp2IlInjected.Token(Token = "0x17000174")]
	BPHONMBHKOI NNFHOLPEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	EIMGEGJKHGD PLFICIHIKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<BPHEFFILCAL, NativeArray<PLACGONOKNH>> ADCDPMFANNN;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<BPHEFFILCAL> GDLKBLMPPPB;

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BDFCCOKJLDJ BPNCIKPBOHF(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PLACGONOKNH JABHFJKBJHO(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GGEFLGLPFBG(BLFAMKALCNM PBKJILNOEKG, JMDGFCECOJD BKIDBAPHALK);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MIOKFNKPKOG(BLFAMKALCNM[] EFEJKJHNICM, GameObject HOHLOJNOGCD);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NEGNIICHCKG FDJEMHAFDGK(NOFNFJEBPPG OJJIOPECNPL, [Optional] object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OHGJLDEOLMG(NOFNFJEBPPG OJJIOPECNPL, [Out] JMDGFCECOJD BKIDBAPHALK);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MLDDHNNLDBN(NOFNFJEBPPG OJJIOPECNPL, [Out] Transform JKAOMNONHAG);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool OEAIGCDGPND(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JJBFIOJGMGJ(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool GHDOMGBJCCJ(LocalId OJJIOPECNPL, object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool GAKMIGDGGBP(LocalId OJJIOPECNPL, object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	NOFNFJEBPPG PHKMMLGONEN(BLFAMKALCNM PBKJILNOEKG);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool NIDCICBCOFC(BLFAMKALCNM PBKJILNOEKG, [Out] NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	BLFAMKALCNM PJICHNILIOP(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	BPHEFFILCAL PHKMMLGONEN(NativeArray<BLFAMKALCNM> PBKJILNOEKG, Allocator NFBFCGHLHAF);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	BPHEFFILCAL OJBJOMNEJME(PLACGONOKNH INLOKFDEDIJ, int MJMIIGGLEFB, Allocator NFBFCGHLHAF);

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	BPHEFFILCAL CIBMPGAJGCJ(NativeArray<BLFAMKALCNM> PBKJILNOEKG, NativeArray<KGPBBDLJLEB> CJPPPACGFOM, Allocator NFBFCGHLHAF);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	BLFAMKALCNM[] HMPOPPBJJEF(string JMIDDGLBCDI, NEGNIICHCKG KJPLPLIHPEF, bool LPGNBBOOBEC);

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JJDJPOJKNJA(string JMIDDGLBCDI, BLFAMKALCNM[] EFEJKJHNICM);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "25")]
	NEGNIICHCKG PHKEADMGLIL(PLACGONOKNH INLOKFDEDIJ, bool BGCDGEIEHGA);

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "26")]
	NEGNIICHCKG PHKEADMGLIL(PLACGONOKNH INLOKFDEDIJ);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "27")]
	NEGNIICHCKG DIIEEDLOACN(PLACGONOKNH INLOKFDEDIJ);

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "28")]
	NEGNIICHCKG MJJNCAABGDG(PLACGONOKNH INLOKFDEDIJ);

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "29")]
	NEGNIICHCKG LPJEKJIDDAE(BLFAMKALCNM PBKJILNOEKG, PLACGONOKNH INLOKFDEDIJ);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "30")]
	CLBCPOIMKHK HGCMGNLJNNA();

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "31")]
	NEICAAGKNCH NIFNAPNKCJG();

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "32")]
	NNFMCPBEDNA IAFLLBOBAID(NGHGEBOPDDH HLODBPODIKI);

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void AHCMJKDHEOJ(BPHEFFILCAL EGJIMMLDENN);

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void FAAFJENLCBJ(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void JJDJDBKKMHM(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void AHCMJKDHEOJ(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool CFIPAPCELIK(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "38")]
	BPHEFFILCAL FNCMDJGCNCK(BPHEFFILCAL NNFMPGCIGPB, Allocator NFBFCGHLHAF);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool AGICPGAMDKF(NOFNFJEBPPG OJJIOPECNPL);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class ELEOINKGAOK
{
	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x63965D0", Offset = "0x63955D0", VA = "0x1863965D0")]
	public static void JJBFIOJGMGJ(this NHGHMDMJDML JHLCJNCOCND, JMDGFCECOJD BKIDBAPHALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x6396430", Offset = "0x6395430", VA = "0x186396430")]
	public static NEGNIICHCKG ABPBDMIFDJE(this NHGHMDMJDML JHLCJNCOCND, LocalId OJJIOPECNPL)
	{
		return default(NEGNIICHCKG);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x63963D0", Offset = "0x63953D0", VA = "0x1863963D0")]
	public static NEGNIICHCKG ABPBDMIFDJE(this NHGHMDMJDML JHLCJNCOCND, BLFAMKALCNM PBKJILNOEKG)
	{
		return default(NEGNIICHCKG);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x6396430", Offset = "0x6395430", VA = "0x186396430")]
	public static NOFNFJEBPPG PHKMMLGONEN(this NHGHMDMJDML JHLCJNCOCND, LocalId OJJIOPECNPL)
	{
		return default(NOFNFJEBPPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x6396A80", Offset = "0x6395A80", VA = "0x186396A80")]
	public static BLFAMKALCNM PJICHNILIOP(this NHGHMDMJDML JHLCJNCOCND, LocalId OJJIOPECNPL)
	{
		return default(BLFAMKALCNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x6396460", Offset = "0x6395460", VA = "0x186396460")]
	public static bool AGICPGAMDKF(this NHGHMDMJDML JHLCJNCOCND, BLFAMKALCNM PBKJILNOEKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2784050", Offset = "0x2783050", VA = "0x182784050")]
	public static T EPPBODPJEEM<T>(this NHGHMDMJDML JHLCJNCOCND, LocalId OJJIOPECNPL) where T : struct, HMFIKBKNPFM
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x63964D0", Offset = "0x63954D0", VA = "0x1863964D0")]
	public static CLBCPOIMKHK BHNNFEAHGEK(this NHGHMDMJDML JHLCJNCOCND, RigidTransform IODAAENEAHL, [Optional] object KONODCHOCOG)
	{
		return default(CLBCPOIMKHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x6396750", Offset = "0x6395750", VA = "0x186396750")]
	public static NNFMCPBEDNA LHMCIJBMOIP(this NHGHMDMJDML JHLCJNCOCND, NGHGEBOPDDH AHPMHFDAGPF, RigidTransform IODAAENEAHL, [Optional] object KONODCHOCOG)
	{
		return default(NNFMCPBEDNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x6396650", Offset = "0x6395650", VA = "0x186396650")]
	public static NEICAAGKNCH KOIOIMELBPL(this NHGHMDMJDML JHLCJNCOCND, RigidTransform IODAAENEAHL, [Optional] object KONODCHOCOG)
	{
		return default(NEICAAGKNCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x6396860", Offset = "0x6395860", VA = "0x186396860")]
	private static void PIPHGFCLBOP(NEGNIICHCKG HKPFELDFHFK, RigidTransform IODAAENEAHL, [Optional] object KONODCHOCOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[CDGCFHBGICH(DOECOPLPHCH.LoadInstance)]
public interface KGCMDANCEHN
{
	[Cpp2IlInjected.Token(Token = "0x17000176")]
	bool MLLDNPGLCIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	NOFNFJEBPPG DPOJNKDFAOD
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	NEGNIICHCKG OONEOAOOAIB
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event EDBLFDGCLIO PFJJCNAOJIE;

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NOFNFJEBPPG ADEENOMPPIO(NOFNFJEBPPG AOHFGFEGDPB, NOFNFJEBPPG FMMPCEBEMDJ);

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KBJCAFOLECL(NOFNFJEBPPG AOHFGFEGDPB, NOFNFJEBPPG FMMPCEBEMDJ, [Out] NOFNFJEBPPG NAAFDBHKMNP);

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JGKONALEFAM();

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AEMHALOCMEI();

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KLJLMDHJFGA(NOFNFJEBPPG AOHFGFEGDPB);

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool KAIBKMDKICL(NOFNFJEBPPG AOHFGFEGDPB);
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public delegate void EDBLFDGCLIO(NEGNIICHCKG EIGBGADPFHK, NEGNIICHCKG MEGOCLEACHD);
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class ILKPAGMPADD
{
	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x6399130", Offset = "0x6398130", VA = "0x186399130")]
	public static bool JFNKNEILIID(this KGCMDANCEHN ONMMLNMAFGG, NEGNIICHCKG AOHFGFEGDPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x6399050", Offset = "0x6398050", VA = "0x186399050")]
	public static bool EEHKIHGFALP(this KGCMDANCEHN ONMMLNMAFGG, NOFNFJEBPPG AOHFGFEGDPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x6398FD0", Offset = "0x6397FD0", VA = "0x186398FD0")]
	public static bool DDBAIIBABBD(this KGCMDANCEHN ONMMLNMAFGG, NOFNFJEBPPG AOHFGFEGDPB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface KJDAILCDHKG
{
	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BOFKIBHIGEI(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ANKLNFADFBD(NOFNFJEBPPG OJJIOPECNPL, Transform JKAOMNONHAG);
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface OFJOHPHBCID
{
	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BIHGIPIMNKK(NOFNFJEBPPG AOHFGFEGDPB, NOFNFJEBPPG ENPAABAJBMI);

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool INNEMIFHLAF(NOFNFJEBPPG AOHFGFEGDPB, NOFNFJEBPPG HMKOCKODHEK);

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GABELOFOOGP(NOFNFJEBPPG AOHFGFEGDPB, [Out] NOFNFJEBPPG NEEDNHLNNEP);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[CDGCFHBGICH(DOECOPLPHCH.LoadInstance)]
public interface OHHAENLPPNG
{
	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDCAOGENEPA(NOFNFJEBPPG JOPDPKEGIDD, bool LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPCCLELGJCF(NOFNFJEBPPG JOPDPKEGIDD, bool LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PEFMJADOBAL(NOFNFJEBPPG JOPDPKEGIDD, int LDGMLLMKHLF);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[CDGCFHBGICH(DOECOPLPHCH.LoadInstance)]
public interface AEFAHGJABDO
{
	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<NOFNFJEBPPG> GFAMBIELPFE(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NOFNFJEBPPG FGEJCBMGIEL(NOFNFJEBPPG OJJIOPECNPL, int GPEHCABDGEJ);

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int GOBOIPOLKBK(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DPMLOEBFPBC BJHMMJPNMJF(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BCNPHHBDHCL(NOFNFJEBPPG OJJIOPECNPL, DPMLOEBFPBC FBCKOOIGNJP);

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NOFNFJEBPPG NJFNKPABOGC(NOFNFJEBPPG OJJIOPECNPL, [Optional] float3? BJIKBOECFPB, [Optional] quaternion? CKCOAEGKOKA, [Optional] float3? GJBNAOHDFNK);

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NOFNFJEBPPG EODFHOPILMK(NOFNFJEBPPG OJJIOPECNPL, int GPEHCABDGEJ, [Optional] float3? BJIKBOECFPB, [Optional] quaternion? CKCOAEGKOKA, [Optional] float3? GJBNAOHDFNK);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NMDOBGMMNPB(NOFNFJEBPPG OJJIOPECNPL, int GPEHCABDGEJ);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IJKDIBODJIP(NOFNFJEBPPG OJJIOPECNPL);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface BEHJLOINEKE
{
	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KALJBPOCHOD();

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCJJNMAKKDP();

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PEDODMBDJCH();

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ABLJKMFLBJK();

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PHHDMAGGGLN();

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FJOECIBNNHF();

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BGENCBNBLFD();

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HJMIPBCEENB();

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CAICHNBLDCA();

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KAJHLBBDMFB();

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PKNFAGGCLEP();

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BAKLEOKNIKN();
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[CDGCFHBGICH(DOECOPLPHCH.LoadInstance)]
public interface HFOBDOLNFBM
{
	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GJJHHONLHBA(NOFNFJEBPPG AOHFGFEGDPB, [Out] int MMCALBDPLAH);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HAEODEKEBPL(NOFNFJEBPPG AOHFGFEGDPB, int MMCALBDPLAH);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FLHFLFAACAG(NOFNFJEBPPG AOHFGFEGDPB, bool GEEDEEIHDHN);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MKCKCGLEHOO(NOFNFJEBPPG AOHFGFEGDPB, bool AFGEMIGJJKM);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NJPOCENFOEA(NOFNFJEBPPG AOHFGFEGDPB, float DMKGABDFBCB, float IHHBNNLBGHG, float LGKJHIJCLIB);

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JMIOGJONJOP(NOFNFJEBPPG OJJIOPECNPL, [Out] float IHHBNNLBGHG, [Out] float LGKJHIJCLIB);

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DJCMJOGDLPL(NOFNFJEBPPG AOHFGFEGDPB, float3 BJIKBOECFPB, quaternion CKCOAEGKOKA);

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool EHDDNMLCCGN(NOFNFJEBPPG AOHFGFEGDPB, [Out] float3 BJIKBOECFPB, [Out] quaternion CKCOAEGKOKA);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface OJDLIIODLKN
{
	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOOGFDJCIAI(Entity KNIDMAMMIEJ);

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EIPCBGJCHKD(Entity KNIDMAMMIEJ, [In] float3 LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 PLJMBGNOMMN(Entity KNIDMAMMIEJ);

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KDMKMKACNBM(Entity KNIDMAMMIEJ, [In] quaternion LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion KDHKGBBCGIH(Entity KNIDMAMMIEJ);

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ELFJFGHMEOA(Entity KNIDMAMMIEJ, [Out] float3 BJIKBOECFPB, [Out] quaternion CKCOAEGKOKA);

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ELFJFGHMEOA(Entity KNIDMAMMIEJ, [Out] RigidTransform OOLFCKDEPNG);

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CFAFONJLIIM(Entity KNIDMAMMIEJ, [Out] RigidTransform OOLFCKDEPNG);

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 IJODEPNDEFA(Entity KNIDMAMMIEJ);

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FFJADLPHFIH(Entity KNIDMAMMIEJ, [In] float3 LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LNECBOHOFAO(Entity KNIDMAMMIEJ, float LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float GMNNIBOIJIF(Entity KNIDMAMMIEJ);

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MLECBFEAOIN(Entity KNIDMAMMIEJ, [In] float3 LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 BLNCDCCEEOP(Entity KNIDMAMMIEJ);

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CJGCDMANAGL(Entity KNIDMAMMIEJ, [In] float3 LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 AENCLNDENKN(Entity KNIDMAMMIEJ);

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HCFODCODBKN(Entity KNIDMAMMIEJ, [In] quaternion LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion KBNKNBNPIIP(Entity KNIDMAMMIEJ);

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 LDIDDFHGNEB(Entity KNIDMAMMIEJ);

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GIELEHFMGDH(Entity KNIDMAMMIEJ, [In] float3 LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void KPAGGHFAAMJ(Entity KNIDMAMMIEJ, float LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float IKNKJOKINJB(Entity KNIDMAMMIEJ);

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JJECKFFLJMI(Entity KNIDMAMMIEJ, [In] float3 LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 EIGJIJDEHBH(Entity KNIDMAMMIEJ);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void KOMKMGMKKFB(Entity KNIDMAMMIEJ, [Out] float4x4 IPMNAPGBLEC);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void AEPJEMFGFPG(Entity KNIDMAMMIEJ, [In] float4x4 IPMNAPGBLEC);

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LJALOABNNFL(Entity KNIDMAMMIEJ, [Out] float4x4 IPMNAPGBLEC);

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool MLDDHNNLDBN(Entity KNIDMAMMIEJ, [Out] Transform JKAOMNONHAG);

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void IGJDBGMHBHG(Entity KNIDMAMMIEJ);

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void PIMJOIKNLAB(Entity KNIDMAMMIEJ, Entity JMHMJAPCEIE, Entity GFOFKCGAIPE);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class AIFFNNGDJEP
{
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface PGFNEALGLEB
{
	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKHCIJFPDBK(bool DMOGIMEKMMF);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface AILBBBOCBIN
{
	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World HBKNKGPFHND(string GKDHGPKGMLC = "Main");

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World BHFHPMAPCIH(string GKDHGPKGMLC = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World GCFCBEHCHEI(string GKDHGPKGMLC = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World POEJINDCHFF(string GKDHGPKGMLC = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface NFAOAMBMPDB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000179")]
	World FHKCHDDAHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	World KFFCFEODMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	EntityManager HMJAALKJPFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	bool NPKMANILOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase LHLHFHEEBIA(Type KBCNAJKPHNL);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class HHPMGAAMKPP
{
	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x6398980", Offset = "0x6397980", VA = "0x186398980")]
	public static ComponentSystemBase EKKHHPILKCO(this World OLCIHNFFNMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x28EBF20", Offset = "0x28EAF20", VA = "0x1828EBF20")]
	public static T LHLHFHEEBIA<T>(this NFAOAMBMPDB AJGGCAADECH) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[CDGCFHBGICH(DOECOPLPHCH.LoadInstance)]
public interface MJALNMFEGND
{
	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGNFLMBBHEL(NativeListAsync<Entity> GCJJOAGHAAI);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NGGOJOKFFCA(AMPLDFHFLNF MJADPINCIBH);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HPEJEGIABLE(NativeListAsync<Entity> MPPEDLGKPMJ, bool MDKLDCHDJJL);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JNBNODFCCPN();
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[CDGCFHBGICH(DOECOPLPHCH.LoadInstance)]
public interface DGACCNFLEDA
{
	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CFCIJNDHFME(Collider MDIOCJFNBPC, [Out] PBJBKNABCBD MHPCPBMACGL);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[CDGCFHBGICH(DOECOPLPHCH.LoadInstance)]
public interface ILDANFGJJDF
{
	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPDPGGOIKHJ(NOFNFJEBPPG OJJIOPECNPL, [Out] Collider MDIOCJFNBPC);

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject GGBIODAJOPA(NOFNFJEBPPG CFIMNENALJG, GameObject CFIHBPMHFDG, Vector3 CMCMKLBCKPK, Quaternion JOFKHOOOHCD);

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NCFBNCDHMEF(GameObject MDIOCJFNBPC);

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider DAFLNCMPBPH<TCollider>(GameObject ONKICPKKICC) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DHLCEBGKLHP(Collider MDIOCJFNBPC);

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject NLIHODADGEH<TCollider>(string ONGJKHHOIAM) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[CDGCFHBGICH(DOECOPLPHCH.LoadInstance)]
public interface KBCBAKCMJKD
{
	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCOFOMHCANK(NOFNFJEBPPG OJJIOPECNPL, LKAELOHNMPI GBMGBPENDKI, bool EPIBFNOONDE, JIDDLIBAHMP EPEFKADMOEB);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EIBIJLIIMBH(NOFNFJEBPPG OJJIOPECNPL, LKAELOHNMPI GBMGBPENDKI, bool EPIBFNOONDE, bool DMOFHPFICPE, bool HGKDFAEFFDP);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NCJBLFEEFFO FKHFNALPLPF(NOFNFJEBPPG OPFDMIOAEHD, List<NOFNFJEBPPG> PPGDFFPLPAB);

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GFFICHFDFDM(GameObject DFDGEDFAPII, GameObject FFNGIJGOMHK);

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MEAPINDBJIH(GameObject FFNGIJGOMHK);

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T DAFLNCMPBPH<T>(GameObject ONKICPKKICC) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DHLCEBGKLHP(Collider MDIOCJFNBPC);

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject LLAEOGIBBOO<T>(string ONGJKHHOIAM) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EGKKHIGNMFN(Collider MDIOCJFNBPC, [Out] NOFNFJEBPPG MMCALBDPLAH);

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool AAMCIHHJCCN(NOFNFJEBPPG OJJIOPECNPL, [Out] PBJBKNABCBD MHPCPBMACGL);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface AKNGLDIDNCF
{
	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGINDGHHPNF(NOFNFJEBPPG OJJIOPECNPL, NOFNFJEBPPG LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHCKGLIGMOF(NOFNFJEBPPG OJJIOPECNPL, NOFNFJEBPPG LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int LEINIKJOIMH(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NOFNFJEBPPG KHDHHNMCMKL(NOFNFJEBPPG OJJIOPECNPL, int GPEHCABDGEJ);

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BPHEFFILCAL DPEOLOMFENH(NOFNFJEBPPG OJJIOPECNPL, Allocator NFBFCGHLHAF = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BAIMAGKCFKO(NOFNFJEBPPG OJJIOPECNPL, object KONODCHOCOG, NOFNFJEBPPG LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HDFNOBLFBIC(NOFNFJEBPPG OJJIOPECNPL, object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool GPEIFKHGCCI(NOFNFJEBPPG OJJIOPECNPL, [Out] NOFNFJEBPPG LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FHKEIGNLAFJ(NOFNFJEBPPG OJJIOPECNPL, float3 LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool LNMEDEGJCPD(NOFNFJEBPPG OJJIOPECNPL, [Out] float3 LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IGEDAGMGIKF(NOFNFJEBPPG OJJIOPECNPL, float3 LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IJOLCDEBAKI(NOFNFJEBPPG OJJIOPECNPL, [Out] float3 LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MMPBKOBKIMJ(NOFNFJEBPPG OJJIOPECNPL, (Quaternion rot, Vector3 moments) AFGCIFLCAMM);

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool JOBNIINJGAL(NOFNFJEBPPG OJJIOPECNPL, [Out] quaternion DGBIMPLNOFD, [Out] float3 LMOGMLBHJHH);

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HOPKDGJMFKC(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 PCPEHPOBDBA(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 BJKJBINHLGK(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OINOKFCNKOI(NOFNFJEBPPG OJJIOPECNPL, float3 LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void ANBEAHAJOCG(NOFNFJEBPPG OJJIOPECNPL, float3 LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float EHDOPDECOKB(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float JHMGBKPOIBP(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void OICMHIHEGAC(NOFNFJEBPPG OJJIOPECNPL, float LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PANJCAGAJIC(NOFNFJEBPPG OJJIOPECNPL, float LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode IFHFELLCNAJ(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OGJINAGACLI(NOFNFJEBPPG OJJIOPECNPL, CollisionDetectionMode LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "25")]
	HLEHOHIHLOC MGCPLIFOKDK(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void ONADBPKCJOD(NOFNFJEBPPG OJJIOPECNPL, HLEHOHIHLOC LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool EKAOAAJFKGE(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void LEEDMAKKKGF(NOFNFJEBPPG OJJIOPECNPL, bool LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "29")]
	NOFNFJEBPPG ACHDLPHBPJI(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void BMBHABJPCCG(NOFNFJEBPPG OJJIOPECNPL, NOFNFJEBPPG LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "31")]
	NOFNFJEBPPG GLPADCHGGOB(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void OEOFJMNAFOJ(NOFNFJEBPPG OJJIOPECNPL, NOFNFJEBPPG LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "33")]
	KDOAGIGOPNE DFOMDKFFJEC(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void OJMNDKBDGEO(NOFNFJEBPPG OJJIOPECNPL, KDOAGIGOPNE IIEIOLOGIHI);

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool CNLAKAMDDGF(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void LNANEHOBACG(NOFNFJEBPPG OJJIOPECNPL, bool LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool CBHKFCNCKML(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void FCFKAJBKMBN(NOFNFJEBPPG OJJIOPECNPL, bool LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints EAMFGONCNOM(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void EPIPDPLOBIM(NOFNFJEBPPG OJJIOPECNPL, RigidbodyConstraints LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float NAOFEJAIGEE(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void HJMEDEJKFMC(NOFNFJEBPPG OJJIOPECNPL, float LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float JLIKHFHCNLF(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void PCCMMLIJOJM(NOFNFJEBPPG OJJIOPECNPL, float LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool CCJOCHOFPJO(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void IAICGPDJENJ(NOFNFJEBPPG OJJIOPECNPL, bool LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool KIJMJMDOBOI(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void LPDPJJCPDHL(NOFNFJEBPPG OJJIOPECNPL, bool LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void FILHCLJGCAL(NOFNFJEBPPG OJJIOPECNPL, int LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "50")]
	BGLLLMAKHCH DHCDDBAHONE(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void JJKNGNNCJBG(NOFNFJEBPPG OJJIOPECNPL, BGLLLMAKHCH LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "52")]
	EADDLCIMNLA CBEOKANOKFL(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void OHEIPKPPMFE(NOFNFJEBPPG OJJIOPECNPL, EADDLCIMNLA LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float LBIOCGJJDCJ(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void BIMPCCIGFMD(NOFNFJEBPPG OJJIOPECNPL, float LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void PCCDCECILIA(NOFNFJEBPPG OJJIOPECNPL, object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void KGMFLCINAJP(NOFNFJEBPPG OJJIOPECNPL, object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool EJEMFOPMDHG(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void CAEBNPHBOPE(NOFNFJEBPPG OJJIOPECNPL, object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void JJFJDLFDHNI(NOFNFJEBPPG OJJIOPECNPL, object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool LKOAIMNKDBM(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool AOJLICNAIJJ(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody HAALFMBHNDH(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void MDDEJLJDPEC(NOFNFJEBPPG OJJIOPECNPL, Rigidbody JPKDDDJNLCK);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void GBIEFGOKLIL(NOFNFJEBPPG OJJIOPECNPL, object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void IDJCOCMHAEG(NOFNFJEBPPG OJJIOPECNPL, object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool BELNBOMJMOI(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void GDLNGGJHECC(NOFNFJEBPPG OJJIOPECNPL, float3 KKLIKHAJECJ);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void JONLIHBCKHO(NOFNFJEBPPG OJJIOPECNPL, float3 DNLKJNNJFNH);

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool OJGPOMAJNBE(NOFNFJEBPPG OJJIOPECNPL, [Out] float3 KKLIKHAJECJ);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool POAAMCDLECO(NOFNFJEBPPG OJJIOPECNPL, [Out] float3 DNLKJNNJFNH);

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool EIEMCPKOECE(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void MAOGKIIPEKA(NOFNFJEBPPG OJJIOPECNPL, object KONODCHOCOG, bool DALNOEDDEKB);

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void JJMLBJDIKCC(NOFNFJEBPPG OJJIOPECNPL, bool IPKFFFMFCMD);

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void NABFDJHNCEN(NOFNFJEBPPG OJJIOPECNPL);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool ADGNPPHHMEM(NOFNFJEBPPG OJJIOPECNPL);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[CDGCFHBGICH(DOECOPLPHCH.LoadInstance)]
public interface CKIFKOIBLAE
{
	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OIBFFNHIGCG(Entity EFGMHIDNJII);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOFBECHAKJA(Entity EFGMHIDNJII);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[CDGCFHBGICH(DOECOPLPHCH.LoadInstance)]
public interface COBFHJNGGPC
{
	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OKHICLIJFLA(NOFNFJEBPPG AOHFGFEGDPB, bool KJEJKPAMMID);

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIPOMODDCJO(NOFNFJEBPPG AOHFGFEGDPB, int PGMBNNJMIFL);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public delegate void ADKAANMNJAO(PLOLGNCLBFD KLCPAJDDJDL);
[Cpp2IlInjected.Token(Token = "0x200008F")]
public readonly struct PLOLGNCLBFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly BPHEFFILCAL CCAOHFJBJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly NativeArray<byte> NDCBPKHBNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly NativeArray<byte> NPDHCGMEKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly GIKMEAFMKHD NCCEHAHLBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly int NPJFNPFEBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly Type NKJFIAEPAAG;

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public BPHEFFILCAL NBGEGCBJCLE
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x9140E0", Offset = "0x9130E0", VA = "0x1809140E0")]
		get
		{
			return default(BPHEFFILCAL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x639DB50", Offset = "0x639CB50", VA = "0x18639DB50")]
	public PLOLGNCLBFD(BPHEFFILCAL CCAOHFJBJNA, NativeArray<byte> NDCBPKHBNLH, NativeArray<byte> NPDHCGMEKKD, GIKMEAFMKHD NCCEHAHLBDA, int NPJFNPFEBMJ, Type NKJFIAEPAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x2A571D0", Offset = "0x2A561D0", VA = "0x182A571D0")]
	public NativeArray<T> LJICNNFBMNB<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x2A57210", Offset = "0x2A56210", VA = "0x182A57210")]
	public NativeArray<T> PJMIOOABLKK<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x2A570E0", Offset = "0x2A560E0", VA = "0x182A570E0")]
	public (BPHEFFILCAL, NativeArray<T>, NativeArray<T>) HBEPMKJLJFA<T>() where T : struct
	{
		return default((BPHEFFILCAL, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x639DB00", Offset = "0x639CB00", VA = "0x18639DB00")]
	public FHLCADEBNLH PBLPILJBIKN()
	{
		return default(FHLCADEBNLH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public interface MOGFAGEEGLO
{
	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	string BNOECBKMEAN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	MOGFAGEEGLO DPEGNFFBBKD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	IEnumerable<MOGFAGEEGLO> NBFGOAOABAA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[CDGCFHBGICH(DOECOPLPHCH.LoadInstance)]
public interface BFBAJOAIKMN
{
	[Cpp2IlInjected.Token(Token = "0x17000181")]
	MOGFAGEEGLO NNPHNBCPFOK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	List<KNJMOJCGIMN> HIPNBJGPHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool POAGJMIENHF(KNJMOJCGIMN GFNKMDBLDFI, [Out] MOGFAGEEGLO CHIACAMHPOH);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GGEFLGLPFBG(KNJMOJCGIMN GFNKMDBLDFI, ADKAANMNJAO BMNBNLFAPDN);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IEOHJNELHNB(KNJMOJCGIMN GFNKMDBLDFI, ADKAANMNJAO BMNBNLFAPDN);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public readonly struct FHLCADEBNLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly PLOLGNCLBFD GPKMLHOONCL;

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public BPHEFFILCAL NBGEGCBJCLE
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x9140E0", Offset = "0x9130E0", VA = "0x1809140E0")]
		get
		{
			return default(BPHEFFILCAL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x63978C0", Offset = "0x63968C0", VA = "0x1863978C0")]
	public FHLCADEBNLH(PLOLGNCLBFD GPKMLHOONCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x6397720", Offset = "0x6396720", VA = "0x186397720")]
	public BPHEFFILCAL LJICNNFBMNB()
	{
		return default(BPHEFFILCAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x63977F0", Offset = "0x63967F0", VA = "0x1863977F0")]
	public BPHEFFILCAL PJMIOOABLKK()
	{
		return default(BPHEFFILCAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x6397600", Offset = "0x6396600", VA = "0x186397600")]
	public (BPHEFFILCAL, BPHEFFILCAL, BPHEFFILCAL) HBEPMKJLJFA()
	{
		return default((BPHEFFILCAL, BPHEFFILCAL, BPHEFFILCAL));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[DefaultMember("Item")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface OHEPIGILPJK : IEnumerable<EMOGGAKDLHK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000184")]
	NativeBitArray CLBJFBKGNHH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	NativeArray<int> DODPGNDLBOM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	int JFLFCJGPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	EMOGGAKDLHK EAGDGAFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	EMOGGAKDLHK EAGDGAFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EMOGGAKDLHK IDGPOLEOKLM(EEMICMGGHGO CMPNFAFPBLG);

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GIKMEAFMKHD BIBEOCDDIDO(EEMICMGGHGO CMPNFAFPBLG);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class KGMBEIDFPOF
{
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
[DefaultMember("Item")]
public interface FGJIPHLHKBD : IEnumerable<JBJCOBLMJIM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000189")]
	int JFLFCJGPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	JBJCOBLMJIM EAGDGAFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JBJCOBLMJIM IDGPOLEOKLM(EEMICMGGHGO CMPNFAFPBLG);

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GIKMEAFMKHD BIBEOCDDIDO(EEMICMGGHGO CMPNFAFPBLG);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class DJDBAMANEKP
{
	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x2743F20", Offset = "0x2742F20", VA = "0x182743F20")]
	public static GIKMEAFMKHD BIBEOCDDIDO<T>(this FGJIPHLHKBD OJBDIKJIJPD, GCNBGFEIDBJ<T> ONGJKHHOIAM) where T : struct
	{
		return default(GIKMEAFMKHD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
[DefaultMember("Item")]
public interface JKOMFKPPPDN : IEnumerable<KNJMOJCGIMN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	int JFLFCJGPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	KNJMOJCGIMN EAGDGAFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KNJMOJCGIMN IDGPOLEOKLM(EEMICMGGHGO CMPNFAFPBLG);

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GIKMEAFMKHD BIBEOCDDIDO(EEMICMGGHGO CMPNFAFPBLG);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class IEFHIGJJEGF
{
	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x28FE540", Offset = "0x28FD540", VA = "0x1828FE540")]
	public static KNMJLKELCCJ<T> IDGPOLEOKLM<T>(this JKOMFKPPPDN OJBDIKJIJPD, EEMICMGGHGO ONGJKHHOIAM) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x28FE440", Offset = "0x28FD440", VA = "0x1828FE440")]
	public static GIKMEAFMKHD BIBEOCDDIDO<T>(this JKOMFKPPPDN OJBDIKJIJPD, GCNBGFEIDBJ<T> ONGJKHHOIAM) where T : struct
	{
		return default(GIKMEAFMKHD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[CDGCFHBGICH(DOECOPLPHCH.LoadInstance)]
public interface PJIPKOCOCIF
{
	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGEFLGLPFBG(EEMICMGGHGO GFNKMDBLDFI, ADKAANMNJAO BMNBNLFAPDN);

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IEOHJNELHNB(EEMICMGGHGO GFNKMDBLDFI, ADKAANMNJAO BMNBNLFAPDN);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class LBBOMBCOKDD
{
	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x295A3C0", Offset = "0x29593C0", VA = "0x18295A3C0")]
	public static void GGEFLGLPFBG<T>(this PJIPKOCOCIF MBPGFBAJCPG, GCNBGFEIDBJ<T> GFNKMDBLDFI, ADKAANMNJAO BMNBNLFAPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x295A5E0", Offset = "0x29595E0", VA = "0x18295A5E0")]
	public static void IEOHJNELHNB<T>(this PJIPKOCOCIF MBPGFBAJCPG, GCNBGFEIDBJ<T> GFNKMDBLDFI, ADKAANMNJAO BMNBNLFAPDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface NFNNLCMCELB
{
	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	OGEJJJDFOFN DPEBOLFAFEL
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AIHGDFEADBF(BLFAMKALCNM PBKJILNOEKG, GIKMEAFMKHD GFNKMDBLDFI);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JDNFBPKDFFA(BLFAMKALCNM PBKJILNOEKG, Span<GIKMEAFMKHD> OJBDIKJIJPD, bool ALBHCIODBDL);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BCIMNPPCAKH(NativeArray<BLFAMKALCNM> EFEJKJHNICM);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public static class IJECCJJKHNF
{
	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x6398E70", Offset = "0x6397E70", VA = "0x186398E70")]
	public static void JDNFBPKDFFA(this NFNNLCMCELB MAPCPEKLLIM, BLFAMKALCNM PBKJILNOEKG, GIKMEAFMKHD GFNKMDBLDFI, bool ALBHCIODBDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public readonly struct OGEJJJDFOFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly NativeBitArray PLPBFBALGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly NativeParallelHashMap<BLFAMKALCNM, int> NHDMPAPGKEI;

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public bool PNBCBOBDPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x639D5B0", Offset = "0x639C5B0", VA = "0x18639D5B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0xBDFEF0", Offset = "0xBDEEF0", VA = "0x180BDFEF0")]
	public OGEJJJDFOFN(NativeBitArray PLPBFBALGMD, NativeParallelHashMap<BLFAMKALCNM, int> NHDMPAPGKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x639D480", Offset = "0x639C480", VA = "0x18639D480")]
	public bool AIHGDFEADBF(BLFAMKALCNM PBKJILNOEKG, GIKMEAFMKHD GFNKMDBLDFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[CDGCFHBGICH(DOECOPLPHCH.LoadInstance)]
public interface NHKOLKHKONN
{
	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EDLLPMKCJEI(NOFNFJEBPPG OJJIOPECNPL, GJPKIGALMON LDGMLLMKHLF);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface FJAJDLEMMOP
{
	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	MKFOLIFJABD CJPLMKABICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface HCICJAEGEEH
{
	[Cpp2IlInjected.Token(Token = "0x17000190")]
	Type BNGIAAAAJKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[CDGCFHBGICH(DOECOPLPHCH.LoadInstance)]
public interface BMEJJBHHFBC
{
	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLPNMDFMEEL(NOFNFJEBPPG JOPDPKEGIDD, bool LDGMLLMKHLF);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public readonly struct IFFMCAJJLBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly IEnumerable<OIIIDBNPELK> HKKEJBKELFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly IReadOnlyList<GameObject> AAIJLNDEMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly IReadOnlyList<int> NELKKLACCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly IReadOnlyList<(BLFAMKALCNM, BLFAMKALCNM)> JFCIJAGCKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly int LBALILPFDFE;

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public bool JAKHALGPHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x6398DA0", Offset = "0x6397DA0", VA = "0x186398DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public int DHPLNMPFPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x96ECB0", Offset = "0x96DCB0", VA = "0x18096ECB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public IEnumerable<GameObject> LCJHGBLMHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x90DA20", Offset = "0x90CA20", VA = "0x18090DA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public IEnumerable<(BLFAMKALCNM src, BLFAMKALCNM dst)> BBFCCAHAKCP
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x6398E00", Offset = "0x6397E00", VA = "0x186398E00")]
	public IFFMCAJJLBK(IEnumerable<OIIIDBNPELK> HKKEJBKELFH, IReadOnlyList<GameObject> AAIJLNDEMJE, IReadOnlyList<int> NELKKLACCGI, IReadOnlyList<(BLFAMKALCNM src, BLFAMKALCNM dst)> JFCIJAGCKMK, int LBALILPFDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x6398A10", Offset = "0x6397A10", VA = "0x186398A10")]
	public (GameObject, int)[] FPBLLPCNCKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface NNCDPEOCJKB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000195")]
	bool HJIEJIHBNDB
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	bool MPCMJCHALLF
	{
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	NBMAJMEFOLB GKPIGJJIMMC
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AGAOAFMPCBP PFDIPCDFCON();

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AGAOAFMPCBP KMMIGKLFGPC(IEnumerable<NOFNFJEBPPG> EGJIMMLDENN, [In] UniformTRS OKEDGPJNIFH);

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NEIBLLDOKDI JBJANBAHNCJ(ByteString HDCOIOEEELK);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ALBIBFNLIJG MLOPJKGEPMD(ByteString FDACCKJJCFO, NOFNFJEBPPG NNHBJFPLAAA, [In] UniformTRS AJKCLOPJEKL, LEIPHJCACJN LHHOOIBNPPC, bool JOCGPABKMMC = true);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CKPEFBGNCON();

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IFFMCAJJLBK JMIOLFGFCLD(IEnumerable<OIIIDBNPELK> HKKEJBKELFH);
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class MIBEENEAIEP
{
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface BJMINHDBIEO
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action PMODJJGAJAK;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action BGCEKLHMNPN;
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct KGPBBDLJLEB : FLDLAIGHMID, IEquatable<KGPBBDLJLEB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public PLACGONOKNH INLOKFDEDIJ;

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x6399890", Offset = "0x6398890", VA = "0x186399890", Slot = "5")]
	public void OMCMMHECHCJ(NGKBLPHGNPG AMMJOMFBDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x63997D0", Offset = "0x63987D0", VA = "0x1863997D0", Slot = "4")]
	public void AFIENNPCBKD(GJMGCHHKJOF BPEIDAMPHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x63998C0", Offset = "0x63988C0", VA = "0x1863998C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x895C90", Offset = "0x894C90", VA = "0x180895C90", Slot = "6")]
	public bool Equals(KGPBBDLJLEB JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x6399800", Offset = "0x6398800", VA = "0x186399800", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x9151A0", Offset = "0x9141A0", VA = "0x1809151A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct BLFAMKALCNM : IComparable<BLFAMKALCNM>, IEquatable<BLFAMKALCNM>, FLDLAIGHMID
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public const uint PFMPIFACGGK = 0u;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public const uint NBOADOHGDEA = 255u;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly BLFAMKALCNM PPEPKDCDIPM;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private const int DCJLKOHPFKM = 24;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private const uint PCEDNGIFKOP = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private const int IBCEIIDIIJJ = 8;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private const uint DPCPHCDKLBD = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly uint MFPMCBPILCI;

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public uint CGNKDNLHIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x813AC0", Offset = "0x812AC0", VA = "0x180813AC0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	public uint DMDNAKDAMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x638D8A0", Offset = "0x638C8A0", VA = "0x18638D8A0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public uint FMOACKBLLEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x9151A0", Offset = "0x9141A0", VA = "0x1809151A0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public bool JAKHALGPHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x63063E0", Offset = "0x63053E0", VA = "0x1863063E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0xD80700", Offset = "0xD7F700", VA = "0x180D80700")]
	public static BLFAMKALCNM FBEIFKOADBC(uint MFPMCBPILCI)
	{
		return default(BLFAMKALCNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x638D940", Offset = "0x638C940", VA = "0x18638D940")]
	public BLFAMKALCNM(int BLOMNAHFAAO, int FFHLNMFBPBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x638D940", Offset = "0x638C940", VA = "0x18638D940")]
	public BLFAMKALCNM(uint BLOMNAHFAAO, int FFHLNMFBPBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x638D940", Offset = "0x638C940", VA = "0x18638D940")]
	public BLFAMKALCNM(uint BLOMNAHFAAO, uint FFHLNMFBPBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x915160", Offset = "0x914160", VA = "0x180915160")]
	private BLFAMKALCNM(uint MFPMCBPILCI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x189A820", Offset = "0x1899820", VA = "0x18189A820")]
	public static bool JPKEALLKLNK(BLFAMKALCNM AAOIMEIMECG, BLFAMKALCNM ABLGCHAEIGE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x638D830", Offset = "0x638C830", VA = "0x18638D830")]
	public static bool OECHKCIMKIG(BLFAMKALCNM AAOIMEIMECG, BLFAMKALCNM ABLGCHAEIGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x895C90", Offset = "0x894C90", VA = "0x180895C90", Slot = "5")]
	public bool Equals(BLFAMKALCNM JKEKANKKCCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x638D7A0", Offset = "0x638C7A0", VA = "0x18638D7A0", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x236CFD0", Offset = "0x236BFD0", VA = "0x18236CFD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x638D8B0", Offset = "0x638C8B0", VA = "0x18638D8B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x638D740", Offset = "0x638C740", VA = "0x18638D740", Slot = "6")]
	public void AFIENNPCBKD(GJMGCHHKJOF BPEIDAMPHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x638D840", Offset = "0x638C840", VA = "0x18638D840", Slot = "7")]
	public void OMCMMHECHCJ(NGKBLPHGNPG AMMJOMFBDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x62B4880", Offset = "0x62B3880", VA = "0x1862B4880", Slot = "4")]
	public int CompareTo(BLFAMKALCNM JNHFAFOIKEO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct OIIIDBNPELK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Guid KAABLCGOLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public string JMIDDGLBCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Vector3 BJIKBOECFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Quaternion CKCOAEGKOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Vector3 GJBNAOHDFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public int IACKPNEJNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Dictionary<string, object> FBCKOOIGNJP;

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x639D760", Offset = "0x639C760", VA = "0x18639D760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x639D5D0", Offset = "0x639C5D0", VA = "0x18639D5D0")]
	private static string CFDBLLKLKKJ(Dictionary<string, object> CIHLNHKCPAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public enum PMIEDMNOFKI
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class KOMBPKFLHFM
{
	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x58200A0", Offset = "0x581F0A0", VA = "0x1858200A0")]
	public static bool GMGGLEKEPBJ(this PMIEDMNOFKI KBCNAJKPHNL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[Flags]
public enum IKBMCPAAIGL
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
public interface ALBIBFNLIJG : NBMAJMEFOLB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	LEIPHJCACJN BBALGDINLEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AOFLBJDIDMG();

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FBKAPFHCAMC();
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public interface NBMAJMEFOLB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	IEnumerable<OIIIDBNPELK> HMMEAHAADBB
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	IFFMCAJJLBK MNNLNFJOIFL
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	LocalId FKNBFHIPKAC
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	DHIPLOGIHNP DHGGHKOCFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EEKCMCCINIG(IKBMCPAAIGL FIHAJJFLEND);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public interface LEIPHJCACJN
{
	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LOKLIINMBBH(Guid KFMGLDNFPAF, [Out] Guid LJGNMEDPHKA);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public interface NEIBLLDOKDI : NBMAJMEFOLB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[Flags]
public enum IMOELFHAAEB
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
public interface AGAOAFMPCBP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	DHIPLOGIHNP NBEPAMECMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString OMJIENBFEPK();
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public enum CPJHFPMKBPO
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public delegate bool DOPGKOOPOCB(HCPLGONJKPA ADOBMJFINLK, [In] DLIKLLDCKDF LDGMLLMKHLF);
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public delegate bool OLMDPLLABCC<T>(HCPLGONJKPA ADOBMJFINLK, [In] T LDGMLLMKHLF);
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface GKJGELMCHNO
{
	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGEFLGLPFBG(GIKMEAFMKHD NCCEHAHLBDA, Type NKDLAGBMPMB, DOPGKOOPOCB MNIAOKEBKDE);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PLGLOKBMBOD(GIKMEAFMKHD NCCEHAHLBDA, [Out] DOPGKOOPOCB MNIAOKEBKDE);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class ODKBPBKHJNF
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class PPOBJDEEGJC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public OLMDPLLABCC<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public PPOBJDEEGJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x429F7E0", Offset = "0x429E7E0", VA = "0x18429F7E0")]
		internal bool EMCJCFADEDK(HCPLGONJKPA pendingList, [In] DLIKLLDCKDF value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2A40580", Offset = "0x2A3F580", VA = "0x182A40580")]
	public static void GGEFLGLPFBG<T>(this GKJGELMCHNO MBPGFBAJCPG, GIKMEAFMKHD NCCEHAHLBDA, OLMDPLLABCC<T> MNIAOKEBKDE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x639D370", Offset = "0x639C370", VA = "0x18639D370")]
	public static bool ODLGFFEJOID(this GKJGELMCHNO MBPGFBAJCPG, HCPLGONJKPA ADOBMJFINLK, GIKMEAFMKHD NCCEHAHLBDA, [In] DLIKLLDCKDF LDGMLLMKHLF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface GMIJCKBODKF
{
	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	uint OMKOBPCPPIP
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface HCPLGONJKPA
{
	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEHPIGDBMGH(BLFAMKALCNM IPJMCCIHDLL, GIKMEAFMKHD NCCEHAHLBDA, ReadOnlySpan<byte> DJFAOKBMAMH, ReadOnlySpan<byte> KFHMMEMHMDH);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MBHAGMBFFAJ(BLFAMKALCNM IPJMCCIHDLL, GIKMEAFMKHD NCCEHAHLBDA);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GPGHMIDOKFG(BLFAMKALCNM IPJMCCIHDLL, GIKMEAFMKHD NCCEHAHLBDA, ReadOnlySpan<byte> KFHMMEMHMDH);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AMMDCLJALML(BLFAMKALCNM IPJMCCIHDLL, GIKMEAFMKHD NCCEHAHLBDA, Span<byte> DJFAOKBMAMH, Span<byte> KFHMMEMHMDH);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class MADPNBJMKJI
{
	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x2972260", Offset = "0x2971260", VA = "0x182972260")]
	public static bool AMMDCLJALML<T>(this HCPLGONJKPA DINCHNKFFDM, BLFAMKALCNM IPJMCCIHDLL, GIKMEAFMKHD NCCEHAHLBDA, [Out] T DJFAOKBMAMH, [Out] T KFHMMEMHMDH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x2972410", Offset = "0x2971410", VA = "0x182972410")]
	public static bool GPGHMIDOKFG<T>(this HCPLGONJKPA DINCHNKFFDM, BLFAMKALCNM IPJMCCIHDLL, GIKMEAFMKHD NCCEHAHLBDA, T KFHMMEMHMDH) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public enum FCAJMLKIOGB
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
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface CGIGKDCGMJB
{
	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FEGHNKHPGOI(OBLIILPHGLH KEHDHCINJMM, ReadOnlySpan<byte> KKAPFENLPIM);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NEGNMLCOOJD(uint KGCFOAELMEM, ReadOnlySpan<byte> KKAPFENLPIM);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EILGNKIKIKF(int LMDLDKHFNGL);
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface ONCMCPIJLKE
{
	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OBLIILPHGLH BEKIJCEHIBL(ReadOnlySpan<byte> KKAPFENLPIM);
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface EJFODKPCDDC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LBOFMNMNLBA(OBLIILPHGLH OHNEPKBBADL, ReadOnlySpan<byte> KKAPFENLPIM);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NEJGAIHLDIF(ReadOnlySpan<OBLIILPHGLH> JLNFGMJKBFF);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public struct PMIFJNCMHMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public OBLIILPHGLH KEHDHCINJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public ReadOnlyMemory<byte> KKAPFENLPIM;
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public struct OBLIILPHGLH
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public static OBLIILPHGLH HEBEEBNPGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public uint BLOMNAHFAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public int DDHEAOMHGMF;

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0xAE6AB0", Offset = "0xAE5AB0", VA = "0x180AE6AB0")]
	public OBLIILPHGLH(uint BLOMNAHFAAO, int DDHEAOMHGMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x639D250", Offset = "0x639C250", VA = "0x18639D250")]
	public static bool JPKEALLKLNK([In] OBLIILPHGLH LEGDDGHJEMC, [In] OBLIILPHGLH KNJHKKJANOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x639D170", Offset = "0x639C170", VA = "0x18639D170", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x639D220", Offset = "0x639C220", VA = "0x18639D220", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x639D280", Offset = "0x639C280", VA = "0x18639D280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x639D270", Offset = "0x639C270", VA = "0x18639D270")]
	public void KNBCCAGJFOM([Out] uint BLOMNAHFAAO, [Out] int DDHEAOMHGMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface BFBEEABACGB : JBMBLCCHDLJ<BFBEEABACGB>
{
	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FINPNHLFMNL(GIKMEAFMKHD JKEKANKKCCC, [Out] NCBMOBDEBAJ PKKFIPNPBHJ);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public static class JCIIPPEMFKM
{
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public interface NCBMOBDEBAJ
{
	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	Type GLHLPFFHHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMCMMHECHCJ(NGKBLPHGNPG AMMJOMFBDDI, Span<byte> AOHFGFEGDPB);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AFIENNPCBKD(GJMGCHHKJOF BPEIDAMPHFE, ReadOnlySpan<byte> KEHDHCINJMM);
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class EBBKINJIHPK
{
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public struct DFHGEHPJGLL : ISystemStateComponentData, IComponentData, IEquatable<DFHGEHPJGLL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public float3 FALFEBBLGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public float3 HLHEAEOAKNJ;

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x63927E0", Offset = "0x63917E0", VA = "0x1863927E0", Slot = "4")]
	public bool Equals(DFHGEHPJGLL JNHFAFOIKEO)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class CKEHPJAMLMC
{
	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public CKEHPJAMLMC()
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
