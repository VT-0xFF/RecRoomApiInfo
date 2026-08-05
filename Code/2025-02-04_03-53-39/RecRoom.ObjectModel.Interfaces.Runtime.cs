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
using RecRoom;
using RecRoom.DataLayer;
using RecRoom.Foundation;
using RecRoom.Foundation.Mathematics;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
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
	public class LogRegistrationIndex : CGFLIBNDCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x73ECD70", Offset = "0x73EBB70", VA = "0x1873ECD70", Slot = "4")]
		public override void EHDMJEMLBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DEHPBPNIJGM
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x73E2D70", Offset = "0x73E1B70", VA = "0x1873E2D70")]
	public static void EGENHMLIFEA(this Rigidbody EABHCMANNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x73E2C40", Offset = "0x73E1A40", VA = "0x1873E2C40")]
	public static void EGENHMLIFEA(this Rigidbody EABHCMANNGM, Vector3 MBNDJABAEND, Quaternion BHKBJKMFMDA, Vector3 OOPIEJBABDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct FEBOOADAFMA : IReadOnlyList<ODHMICMEHJH>, IEnumerable<ODHMICMEHJH>, IEnumerable, IReadOnlyCollection<ODHMICMEHJH>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct NBPJANPGBBK : IEnumerator<ODHMICMEHJH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly PHOLKIHIPKK CPAMHBBHFKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator NCNLLJPEKAC;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ODHMICMEHJH ABCAFDPDGPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x73ED0F0", Offset = "0x73EBEF0", VA = "0x1873ED0F0", Slot = "4")]
			get
			{
				return default(ODHMICMEHJH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x73ED070", Offset = "0x73EBE70", VA = "0x1873ED070", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4A3ABA0", Offset = "0x4A399A0", VA = "0x184A3ABA0")]
		public NBPJANPGBBK(PHOLKIHIPKK CPAMHBBHFKC, NativeArray<LocalId>.Enumerator NCNLLJPEKAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x73ECFB0", Offset = "0x73EBDB0", VA = "0x1873ECFB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x73ECFF0", Offset = "0x73EBDF0", VA = "0x1873ECFF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x73ED030", Offset = "0x73EBE30", VA = "0x1873ED030", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly PHOLKIHIPKK CPAMHBBHFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> CKLFLFGMLGN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ODHMICMEHJH FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x73E4B80", Offset = "0x73E3980", VA = "0x1873E4B80", Slot = "4")]
		get
		{
			return default(ODHMICMEHJH);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x73E4540", Offset = "0x73E3340", VA = "0x1873E4540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int JLFHOJBDCMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8F41A0", Offset = "0x8F2FA0", VA = "0x1808F41A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public PHOLKIHIPKK FMOMHMCAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int BNJCPJCFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8F41A0", Offset = "0x8F2FA0", VA = "0x1808F41A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HLLEOGFNEAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x73E4590", Offset = "0x73E3390", VA = "0x1873E4590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> EKECJEHHBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B400", Offset = "0x2B5A200", VA = "0x182B5B400")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> NHCAFINPMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x73E4710", Offset = "0x73E3510", VA = "0x1873E4710")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x73E49D0", Offset = "0x73E37D0", VA = "0x1873E49D0")]
	public FEBOOADAFMA(int MLAKJOPIGGN, PHOLKIHIPKK CPAMHBBHFKC, Allocator GCNJHJPCIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4A3AAB0", Offset = "0x4A398B0", VA = "0x184A3AAB0")]
	public FEBOOADAFMA(PHOLKIHIPKK CPAMHBBHFKC, NativeArray<LocalId> CKLFLFGMLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x73E4B10", Offset = "0x73E3910", VA = "0x1873E4B10")]
	internal FEBOOADAFMA(PHOLKIHIPKK CPAMHBBHFKC, NativeArray<Entity> AIJKCNMCOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x73E4930", Offset = "0x73E3730", VA = "0x1873E4930")]
	public FEBOOADAFMA(PHOLKIHIPKK CPAMHBBHFKC, int AIIKLGOLFIK, Allocator GCNJHJPCIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x73E4A60", Offset = "0x73E3860", VA = "0x1873E4A60")]
	public FEBOOADAFMA(FEBOOADAFMA GBIKOGIMMHE, Allocator GCNJHJPCIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x73E45D0", Offset = "0x73E33D0", VA = "0x1873E45D0")]
	public FEBOOADAFMA HNEOLFGNEMG(Allocator GCNJHJPCIGN = Allocator.Temp)
	{
		return default(FEBOOADAFMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x73E4500", Offset = "0x73E3300", VA = "0x1873E4500", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x73E4680", Offset = "0x73E3480", VA = "0x1873E4680")]
	public NBPJANPGBBK NAPBKLICNNH()
	{
		return default(NBPJANPGBBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x73E4770", Offset = "0x73E3570", VA = "0x1873E4770", Slot = "6")]
	private IEnumerator<ODHMICMEHJH> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x73E4850", Offset = "0x73E3650", VA = "0x1873E4850", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public struct LKIJHMINLPF : IList<ODHMICMEHJH>, ICollection<ODHMICMEHJH>, IEnumerable<ODHMICMEHJH>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct FHLIAMJFLAL : IEnumerator<ODHMICMEHJH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly PHOLKIHIPKK CPAMHBBHFKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator NCNLLJPEKAC;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ODHMICMEHJH ABCAFDPDGPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x73E4D00", Offset = "0x73E3B00", VA = "0x1873E4D00", Slot = "4")]
			get
			{
				return default(ODHMICMEHJH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x73E4C80", Offset = "0x73E3A80", VA = "0x1873E4C80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4A3ABA0", Offset = "0x4A399A0", VA = "0x184A3ABA0")]
		public FHLIAMJFLAL(PHOLKIHIPKK CPAMHBBHFKC, NativeArray<LocalId>.Enumerator NCNLLJPEKAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x73E4BC0", Offset = "0x73E39C0", VA = "0x1873E4BC0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x73E4C00", Offset = "0x73E3A00", VA = "0x1873E4C00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x73E4C40", Offset = "0x73E3A40", VA = "0x1873E4C40", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly PHOLKIHIPKK CPAMHBBHFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> CKLFLFGMLGN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ODHMICMEHJH FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x73EBA30", Offset = "0x73EA830", VA = "0x1873EBA30", Slot = "4")]
		get
		{
			return default(ODHMICMEHJH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x73EBAB0", Offset = "0x73EA8B0", VA = "0x1873EBAB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int IPKHGMJKDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x73EB320", Offset = "0x73EA120", VA = "0x1873EB320", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int BNJCPJCFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x73EB320", Offset = "0x73EA120", VA = "0x1873EB320")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> EKECJEHHBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B400", Offset = "0x2B5A200", VA = "0x182B5B400")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool HPHENKFIHIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x73EB890", Offset = "0x73EA690", VA = "0x1873EB890")]
	public LKIJHMINLPF(int MLAKJOPIGGN, PHOLKIHIPKK CPAMHBBHFKC, Allocator GCNJHJPCIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x73EB9B0", Offset = "0x73EA7B0", VA = "0x1873EB9B0")]
	public LKIJHMINLPF(PHOLKIHIPKK CPAMHBBHFKC, Allocator GCNJHJPCIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x73EB920", Offset = "0x73EA720", VA = "0x1873EB920")]
	public LKIJHMINLPF(PHOLKIHIPKK CPAMHBBHFKC, int AIIKLGOLFIK, Allocator GCNJHJPCIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x73EB530", Offset = "0x73EA330", VA = "0x1873EB530")]
	public FEBOOADAFMA PEGOEAKBHDC()
	{
		return default(FEBOOADAFMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x73EB0C0", Offset = "0x73E9EC0", VA = "0x1873EB0C0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x73EB100", Offset = "0x73E9F00", VA = "0x1873EB100", Slot = "13")]
	public bool Contains(ODHMICMEHJH MJONLBMPPCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x73EB190", Offset = "0x73E9F90", VA = "0x1873EB190", Slot = "14")]
	public void CopyTo(ODHMICMEHJH[] EOOCBMPNEML, int FJBNAIEDHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x73EB040", Offset = "0x73E9E40", VA = "0x1873EB040", Slot = "11")]
	public void Add(ODHMICMEHJH MJONLBMPPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x73EB3F0", Offset = "0x73EA1F0", VA = "0x1873EB3F0", Slot = "7")]
	public void Insert(int KNCPCNBMDNF, ODHMICMEHJH MJONLBMPPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x73EB600", Offset = "0x73EA400", VA = "0x1873EB600", Slot = "15")]
	public bool Remove(ODHMICMEHJH MJONLBMPPCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x73EB360", Offset = "0x73EA160", VA = "0x1873EB360", Slot = "6")]
	public int IndexOf(ODHMICMEHJH MJONLBMPPCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x73EB5B0", Offset = "0x73EA3B0", VA = "0x1873EB5B0", Slot = "8")]
	public void RemoveAt(int KNCPCNBMDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x73EB2E0", Offset = "0x73EA0E0", VA = "0x1873EB2E0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x73EB4A0", Offset = "0x73EA2A0", VA = "0x1873EB4A0")]
	public FHLIAMJFLAL NAPBKLICNNH()
	{
		return default(FHLIAMJFLAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x73EB6D0", Offset = "0x73EA4D0", VA = "0x1873EB6D0", Slot = "16")]
	private IEnumerator<ODHMICMEHJH> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x73EB7B0", Offset = "0x73EA5B0", VA = "0x1873EB7B0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface LJBOAHCHHOK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int LGHKLEMFHEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> CBDJHJOHDJG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ODHMICMEHJH OJLEKLMNAAB(ODHMICMEHJH CKLFLFGMLGN);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AAFLOEHALJL : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[ServiceLifetime(Lifetime.Application)]
public interface DFFIGBPDFFA : CIBAJCMHNLK, MLFBOGPBFOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool FIMGNNJILII
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	GFBFNKLADJN KCDNGCJNCCG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	PHEMLIIONIG PGBNHHHODKC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	PLKPCGBKHBF FNNKILGPPMM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	NKALHBHGBLN PILFKAFCCEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface MLFBOGPBFOD
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool IJHDOOBJGHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface OAOJHLKLGLG
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFPLKHHFCMP(bool IPHILEOFJLB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface PGPMAJOBNDC
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool FFOFEKNCOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FFJIHLEJILC(bool KKHNIMMKCDA);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HGFHJABGPCK();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AJHFODBCPGH(ByteString IGPMBFACFOG);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DPDNFNMINMD();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OPFCFAHEFGG();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LEMACANIKPA();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CIMGEGFNHLB();

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AADPOGCMMKM();

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MOLBMFNLNDN();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.Application)]
public interface PLKPCGBKHBF
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	BFHPBCPPECP KCDNGCJNCCG
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	PHEMLIIONIG PGBNHHHODKC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	AMOENAFJHDD HPCKJPNFEMC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	PBBIECAKAED NDBKADFFDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	DFFIGBPDFFA CDDCEOEGDCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	PGPMAJOBNDC PKFMHKKKNKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	PHOLKIHIPKK FMOMHMCAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	JDCLPPHDFCC BADMGIIJNGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	FOBFMNKCFNO PBPJCDCONKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	OIEJAJNLBDC NIAMJNPLEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	OIBHCDOHPPM KNBANOHDJMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	CNNPLFAMFGP DJPFCNDPIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	LCJGIDNOGJF BELAGKPLDPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	MEFNBOPECIN FMNGDDDEIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	HNIGNHHFAAJ IOHAJMBFHGL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	GLFBCBNIDJG DHEMMOCEJKN
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	EPKMMGDJELD ANLDHGHOGDL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	AIIEKAIMAJJ JOAJKOMGDAH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	FBNMMGJAKMI EPDAIJOGFLB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	KBIMGFIJKIF BLLDJNMINEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	IOEFCJJFBBD IELLMGJHGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	DLJKKJKCGMB KKEKJNINMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	JGIIDBOOICE MPANFHDHNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	BBJFCFMHBJH ADNLNGKJEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	LNAPHJMMJKI KICKLNGJLJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	BHEMNCJIDNN EMNJBFEPNNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	JOJFIIODBIN EJDELEEGKCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	KEFGFKFONEL HFCFEAINKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	NPPFBIIJHFO CENNDKKNJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	FNPKDENMMNK KNINDBNDHHC
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	DIMHGMGMJDI FLAEOMALMHC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(PNBAIMHKNOH))]
public readonly struct ODHMICMEHJH : IComparable<ODHMICMEHJH>, IEquatable<ODHMICMEHJH>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly ODHMICMEHJH EKNPGNFGBJM;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int LOGMJHNEIOL = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int NDJHACNICKA = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int AKIEEFHEALP = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int MBCGEFCDCOI = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId ADODGOLJGFP;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public PHOLKIHIPKK FMOMHMCAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x73DFCA0", Offset = "0x73DEAA0", VA = "0x1873DFCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DFFIGBPDFFA CDDCEOEGDCL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x73EEFE0", Offset = "0x73EDDE0", VA = "0x1873EEFE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public LocalId MECKPFPPICL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x73EEE80", Offset = "0x73EDC80", VA = "0x1873EEE80")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	internal NKALHBHGBLN PILFKAFCCEH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x73EF130", Offset = "0x73EDF30", VA = "0x1873EF130")]
		get
		{
			return default(NKALHBHGBLN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool DMOEJHJGHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x73EF140", Offset = "0x73EDF40", VA = "0x1873EF140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private bool CODKLKDFEEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x73EF400", Offset = "0x73EE200", VA = "0x1873EF400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x73EF600", Offset = "0x73EE400", VA = "0x1873EF600")]
	public ODHMICMEHJH(PHOLKIHIPKK EOOMIJAKNEJ, LocalId ADODGOLJGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
	public JNCOEOPKELP DLFKBMBKOEM()
	{
		return default(JNCOEOPKELP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x73EF490", Offset = "0x73EE290", VA = "0x1873EF490")]
	public static LocalId JCHCBNMNCNP(ODHMICMEHJH ALECBNGKKEM)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x73EF450", Offset = "0x73EE250", VA = "0x1873EF450")]
	public static Entity JCHCBNMNCNP(ODHMICMEHJH ALECBNGKKEM)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x73EEEC0", Offset = "0x73EDCC0", VA = "0x1873EEEC0")]
	public static bool BHDCHHANDIG(ODHMICMEHJH HJGGLHBFMKO, ODHMICMEHJH AGAPPIBJJBC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x73E6480", Offset = "0x73E5280", VA = "0x1873E6480")]
	public static bool HGMDHININLF(ODHMICMEHJH HJGGLHBFMKO, ODHMICMEHJH AGAPPIBJJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x73EF4D0", Offset = "0x73EE2D0", VA = "0x1873EF4D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x73EF260", Offset = "0x73EE060", VA = "0x1873EF260", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x73EF040", Offset = "0x73EDE40", VA = "0x1873EF040", Slot = "4")]
	public int CompareTo(ODHMICMEHJH LHMPMCLNOPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "5")]
	public bool Equals(ODHMICMEHJH LHMPMCLNOPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CIKGFPBLOLJ
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x73E26A0", Offset = "0x73E14A0", VA = "0x1873E26A0")]
	public static HLIKGPHNDCA LMHLPAKGJBL(this ODHMICMEHJH JOOHPPHJKMI)
	{
		return default(HLIKGPHNDCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x73E25F0", Offset = "0x73E13F0", VA = "0x1873E25F0")]
	public static JNCOEOPKELP HMNMNNCNPAL(this ODHMICMEHJH JOOHPPHJKMI)
	{
		return default(JNCOEOPKELP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class PNBAIMHKNOH
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct NKALHBHGBLN : IEquatable<NKALHBHGBLN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte IPNJAOPIHCP;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] GOFFLFBJEKK;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static PHOLKIHIPKK LIAOPEALACN;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static DFFIGBPDFFA BEILDFKJHOG;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static PHOLKIHIPKK[] DJGNBNPJOLC;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static DFFIGBPDFFA[] JGCJPLEBGME;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> CPNHLGPAHCC;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DFFIGBPDFFA CDDCEOEGDCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x73EE240", Offset = "0x73ED040", VA = "0x1873EE240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public PHOLKIHIPKK CNPFHIONKKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x73EDDC0", Offset = "0x73ECBC0", VA = "0x1873EDDC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x73EECC0", Offset = "0x73EDAC0", VA = "0x1873EECC0")]
	static NKALHBHGBLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x271F930", Offset = "0x271E730", VA = "0x18271F930")]
	internal NKALHBHGBLN(byte IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6441B10", Offset = "0x6440910", VA = "0x186441B10", Slot = "4")]
	public bool Equals(NKALHBHGBLN LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x73EE750", Offset = "0x73ED550", VA = "0x1873EE750", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xD95630", Offset = "0xD94430", VA = "0x180D95630", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x73EEC00", Offset = "0x73EDA00", VA = "0x1873EEC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x73EE8A0", Offset = "0x73ED6A0", VA = "0x1873EE8A0")]
	private static PHOLKIHIPKK GFLIDJDNJBN(byte IPNJAOPIHCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x73EE7F0", Offset = "0x73ED5F0", VA = "0x1873EE7F0")]
	private static DFFIGBPDFFA FKBBBFIMPOJ(byte IPNJAOPIHCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x73EE320", Offset = "0x73ED120", VA = "0x1873EE320")]
	private static object DHLDOFBIFNK(byte IPNJAOPIHCP, object[] DCFFMJLJGJB, object KBHDDKCAINE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x73EEBF0", Offset = "0x73ED9F0", VA = "0x1873EEBF0")]
	private static int PKKAMJJCPLI(byte IPNJAOPIHCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x73EEBE0", Offset = "0x73ED9E0", VA = "0x1873EEBE0")]
	private static int JJJCBKKHHGM(byte IPNJAOPIHCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x73EE950", Offset = "0x73ED750", VA = "0x1873EE950")]
	private static (int, int) HJGOKDBMLAB(byte IPNJAOPIHCP)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x73EE230", Offset = "0x73ED030", VA = "0x1873EE230")]
	private static byte BFMIGMHJCDC(int BBDOELHAPOH, int KNCPCNBMDNF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x73EE490", Offset = "0x73ED290", VA = "0x1873EE490")]
	internal static NKALHBHGBLN EHDMJEMLBPD(DFFIGBPDFFA AJIDGGFAOBE, PHOLKIHIPKK KOCCLJIALDN)
	{
		return default(NKALHBHGBLN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x73EE9D0", Offset = "0x73ED7D0", VA = "0x1873EE9D0")]
	internal static void HLGNNFLCMJP(NKALHBHGBLN IPNJAOPIHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x73EDEA0", Offset = "0x73ECCA0", VA = "0x1873EDEA0")]
	private static void BFJCPGMBFOI(int MLAKJOPIGGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface HBLJKPNEHGO
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LIKNKKDNKHG();

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NFOPMBAKJFH(bool EBAGDCJLDLP);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FGLCOONOLPO(GameObject IHNPMPCJPIK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[ServiceLifetime(Lifetime.Application)]
public interface IFCOENKBBFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Guid ICHFABHHNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BLOOGCIJMKL(Guid CKLHIMIDKKB, Guid INONPKMEIIH, Guid MBMICGOJGMN);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task BHOKFKBJCPE(Guid CKLHIMIDKKB, Guid[] NKEGLDNAHCJ, Guid MBMICGOJGMN);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid APEJPGGMBGJ(Guid FDFKGMJMPMO);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task GLNCBMHKBCF(ODHMICMEHJH IMCPNLBHHHB);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JIALDKGNMMJ(Guid FDFKGMJMPMO);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EEGELOMPMAJ(HILEJELFOGB HOGOICDMOFN, Guid PJNLCFAMJPK);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PHBPJENAJMM(Guid FDFKGMJMPMO, bool KKHNIMMKCDA);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[ServiceLifetime(Lifetime.Application)]
public interface NFHKFLLBENH
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHPBCOGJFOK(FEBOOADAFMA CKLFLFGMLGN);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[ServiceLifetime(Lifetime.Application)]
public interface NCEODMBLKHK
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NMLGKLDPNJO(GameObject CCGEAKOEIII, GameObject DHIIAEJCIIH, int FONONCEMPGM);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[ServiceLifetime(Lifetime.Application)]
public interface PHEMLIIONIG
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	HBLJKPNEHGO HJCCGGHECLB
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	MIPGKPNCIGA GJGCFMHKLIH
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	GGILMPONHJJ DMJOBHLOPKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	GNIOJIAFIPM LLJKLCOBIAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	MNAINDGMCBJ HHBLMDFKOHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	BLPBPHHHACK CJDONOFKCLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	HPANJILFMCB NAOCDIPDKMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	INDFHNPPFBP MBPKLEBKHPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	LFPMJKNNKNH KEGILBOJGFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	IBDHPMDGIEI EMBMMHOPDOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	CIGGIKCEEHL AJHEPIMFIOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[ServiceLifetime(Lifetime.Application)]
public interface MIPGKPNCIGA
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	string GMIGIBJBOBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[ServiceLifetime(Lifetime.Application)]
public interface JBBJCCBOILI
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BLKFBDAIBFK(Action OOCJAOHFGJK, bool MANHCMJFANP);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BBGFONAOLLJ(string PPKJBGAOBJL);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int PCCCIKMEHOJ(string PPKJBGAOBJL, int KBHDDKCAINE);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GPNINPHHJPM([Out] bool IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IHNBGDIEJMH([Out] bool IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HODBGFKBOFL([Out] int IPHILEOFJLB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface GGILMPONHJJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	string OJFOPDCCGNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] OCGLMPOPINK(IEnumerable<CBHCFMFILCI> ANBIEBHOEKC, bool JIPCFJBBEOK);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MANHGNPGMLL(GameObject IHNPMPCJPIK, [Out] HLIKGPHNDCA[] AHLBJHAJDGN);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PBEAKDNBHAE(GameObject IHNPMPCJPIK, [Out] int HDGNPOFLNKM, [Out] NJNFOMGPIJM GFOODEKJMLI);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HILEJELFOGB PKIHICHNCHN(CBHCFMFILCI HJFGAIAKKLJ);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HILEJELFOGB PKIHICHNCHN(string IHNBODLLFGB, HLIKGPHNDCA[] LOJFIEKGPLG, Vector3 AKEODPFBHJE, Quaternion CKABIAOPKPM, Vector3 KFHMJCONBDC);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HILEJELFOGB JLEALDHNHCD(string IHNBODLLFGB, HLIKGPHNDCA[] LOJFIEKGPLG, Vector3 AKEODPFBHJE, Quaternion CKABIAOPKPM, Vector3 KFHMJCONBDC);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject JGNMFJEEPIO(string IHNBODLLFGB);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PNGFBOKIIDA(GameObject OMFELEGIJMF, bool BNMEJFFHBGD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JEAIDHAPOOI(GameObject IHNPMPCJPIK, bool NENBFJMEHII, bool JKEDOFAPFOC);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class ILLKIABKJJG
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x73E6870", Offset = "0x73E5670", VA = "0x1873E6870")]
	public static HILEJELFOGB PKIHICHNCHN(this GGILMPONHJJ BPGIOHMMDAI, Vector3 AKEODPFBHJE, Quaternion CKABIAOPKPM, Vector3 KFHMJCONBDC, params HLIKGPHNDCA[] AHLBJHAJDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x73E6720", Offset = "0x73E5520", VA = "0x1873E6720")]
	public static HILEJELFOGB JLEALDHNHCD(this GGILMPONHJJ BPGIOHMMDAI, Vector3 AKEODPFBHJE, Quaternion CKABIAOPKPM, Vector3 KFHMJCONBDC, params HLIKGPHNDCA[] AHLBJHAJDGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[ServiceLifetime(Lifetime.Application)]
public interface GNIOJIAFIPM
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCNNEGBJDBH(bool KKHNIMMKCDA);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[ServiceLifetime(Lifetime.Application)]
public interface MNAINDGMCBJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool NNCLGJKIMME
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool KMMCJNIIPIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool GCNIMFJKHNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	int HBKNBHLPDBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool ECIMPAGAHCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GMCPIEJALIK(object KGDIEBJBNPG);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AABIPHPNPDN(object KGDIEBJBNPG);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CCGMIKHAJED(object OBIPBFFAILK);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void POFDCIIMJEA(object OBIPBFFAILK);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ViewId BNOMFLANDKK(GameObject IDGNIKPAEDA);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LPKNFIDOBGA(NativeArray<ViewId> ICBLKMBJJEL);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GPGNNLKCCJM(NativeArray<ViewId> HKPDAKJGMCC);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JJJBMKEOIAA();

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DBABEIMJEGF(uint JFLMHBKGFHK, ReadOnlySpan<byte> JHCCCOKLDEN, bool CHPIDMEBDHA = false);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DBABEIMJEGF(uint JFLMHBKGFHK, ReadOnlySpan<byte> JHCCCOKLDEN, ReadOnlySpan<byte> LOGGJGLNDEL, bool CHPIDMEBDHA = false);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AJHOAOALPAA(Func<int, bool, int> FCNCNHONCLP, bool GPAIJGOPKMN);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AAKKLGJMGMP(object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FPOINEGAOEN(object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "18")]
	uint JFKIHJBOFEM(uint KBFABHDAKIJ);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class KIKHLPGKPMG
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x73EAA10", Offset = "0x73E9810", VA = "0x1873EAA10")]
	public static MMGPAENDKMA MADCDAGCEEG(this MNAINDGMCBJ ONBPKFMECNJ, object HACFGBHNOCC)
	{
		return default(MMGPAENDKMA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct MMGPAENDKMA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private MNAINDGMCBJ ONBPKFMECNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private object HACFGBHNOCC;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x73ECE90", Offset = "0x73EBC90", VA = "0x1873ECE90")]
	public MMGPAENDKMA(MNAINDGMCBJ ONBPKFMECNJ, object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x73ECE40", Offset = "0x73EBC40", VA = "0x1873ECE40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface BLPBPHHHACK
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JEPHIKLGIJJ(GameObject IHNPMPCJPIK);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface HPANJILFMCB
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public struct OFMBJDHMOMH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private HPANJILFMCB PEIGPNDOBAF;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x73EF7F0", Offset = "0x73EE5F0", VA = "0x1873EF7F0")]
		public OFMBJDHMOMH(HPANJILFMCB PEIGPNDOBAF, string NDKKADCKLPM, string HGDCNIGAAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x73EF730", Offset = "0x73EE530", VA = "0x1873EF730", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct INHKFFGFCNH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private HPANJILFMCB PEIGPNDOBAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Task BDCCICFJHCL;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x73E69C0", Offset = "0x73E57C0", VA = "0x1873E69C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FELLKJDJBME(string KKBJAPCBOHH, float ENFBFHBOFDG = 5f);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FEHDKPFPEPD();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JCMKFFCHABP(bool FHEMFHLDPHC, string NDKKADCKLPM, string HGDCNIGAAED);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class OLNKOGBDNIF
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x73EFA50", Offset = "0x73EE850", VA = "0x1873EFA50")]
	public static HPANJILFMCB.OFMBJDHMOMH DBGFPAGDFOC(this HPANJILFMCB ONBPKFMECNJ, string NDKKADCKLPM, string HGDCNIGAAED)
	{
		return default(HPANJILFMCB.OFMBJDHMOMH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface KKDJEPNEAFB
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int CFJCBDANDOL(GameObject IHNPMPCJPIK);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPNLPKIGFIJ(GameObject IHNPMPCJPIK);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AGFNAOHEJPC(int MLOEPLKKMAH);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object AOGDACJHGFI(ODHMICMEHJH ADODGOLJGFP, GameObject IHNPMPCJPIK, Action<ODHMICMEHJH, int> JMGOMJNPFIN);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FAGOFIEONHB(GameObject IHNPMPCJPIK, object OBEDIIEFCFG);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface PIMODLFOAFI
{
	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool KMFPCGGHCDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate INKFNJLFDOA(HHBGBBJKAME.BCLLILDAFHM LAEOPDOCNMC, Action<HHBGBBJKAME.BCLLILDAFHM> JMGOMJNPFIN);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JIJGJFMOHPI(HHBGBBJKAME.BCLLILDAFHM LAEOPDOCNMC, Delegate JMGOMJNPFIN);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate FOGMCDHMFLA(HHBGBBJKAME.BCLLILDAFHM LAEOPDOCNMC, Action<HHBGBBJKAME.BCLLILDAFHM> KGFKJEKAPCI);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FIAKEMLHNEJ(HHBGBBJKAME.BCLLILDAFHM LAEOPDOCNMC, Delegate JMGOMJNPFIN);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FIPIKFDPMLE(HHBGBBJKAME.BCLLILDAFHM LAEOPDOCNMC);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HHBGBBJKAME.BCLLILDAFHM BJBBKOICPCB(GameObject IHNPMPCJPIK);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface INDFHNPPFBP
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	int KANFELGFDHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	int NGPBOMJFGPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool KMMCJNIIPIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool GOPHOGMDGCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool MDMCOCMMDPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int ALIDLCIIBBF(GameObject IHNPMPCJPIK);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BMDBEKAHBGI([Out] Vector3 AKEODPFBHJE);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CDGBGPKNHCE();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ODHMICMEHJH OFDMANGCBAI(int MLOEPLKKMAH);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GGNBKAKPKAF();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[ServiceLifetime(Lifetime.Application)]
public interface LFPMJKNNKNH
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool FFOFEKNCOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[ServiceLifetime(Lifetime.Application)]
public interface IBDHPMDGIEI
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	EHONGHPLPEE FPIMKJAMJHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	CKINBMACMLL DFGBAIKMIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DPPNHHKLCAF(Transform KAEMFHJNGPI);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OOMJDDFKCLL(Transform KAEMFHJNGPI, IJIMINIKDMH KLFHBMBJDCM);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PLBGFADEOLA(Transform KAEMFHJNGPI, IIDEEAJADIF NCIPABHIJLA);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CEGJEEADBKB();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PBCAMCKLKLP();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[ServiceLifetime(Lifetime.Application)]
public interface LEADLMHJOLC
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[ServiceLifetime(Lifetime.Application)]
public interface CIGGIKCEEHL
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action MDFKGIEFDAJ;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FLCCOKPIINN(FEBOOADAFMA KAIJCPPINLO, bool FHEMFHLDPHC);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[ServiceLifetime(Lifetime.Application)]
public interface PHNHIBAIBBA
{
	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJIJCPDBBOF();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ServiceLifetime(Lifetime.Application)]
public interface FJJFALLIGAD
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NJNFOMGPIJM GNMMNBHNHIA(GameObject IDGNIKPAEDA);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NBPDOELLJDC(GameObject IHNPMPCJPIK, DEHCHGHMLNK LGGFGJBHLOJ, FJJIGCEJIMM HGNLBCNNPCJ);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KCPIKDHIGFH(ODHMICMEHJH ADODGOLJGFP, bool PMPDHOHKGEH, float3 GDKIGJIPJIH, quaternion ACGKDGJLJFJ);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JMHEDKPPPIB(JNCOEOPKELP MPGLDFENCOD, JNCOEOPKELP OBIPBFFAILK, PMJLGJGNALL NCGEJMOHJLG);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GOKDCMGCAMP(JNCOEOPKELP MPGLDFENCOD, PMJLGJGNALL NCGEJMOHJLG);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void APJKCAHNIEB(FEBOOADAFMA BPHLKHBHOOL);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void COGNFEIMPHA(FEBOOADAFMA CPAMHBBHFKC, NativeArray<LocalPoseData> KJPIIIAPJFC, NativeArray<float3> KJIAFCBILAD);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OKICGKFEMAL(FEBOOADAFMA CPAMHBBHFKC, FEBOOADAFMA CPBNAMBBBNC);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LDBKKGDIKKD(FEBOOADAFMA CPAMHBBHFKC, bool ACCEIPCNDGN);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JHAAPBMKDPJ(FEBOOADAFMA CPAMHBBHFKC, bool PCCNAPDOOIP);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GameObject DBNNJKCEFPL(Guid HBPAPJBMPIC);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AOMGGOBNKIB(ANIPKKMJKKG DFHAIKHKAKA);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct KEDMJBPGPFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly OGKFGJKAGBI EBKPEOBONHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly OGKFGJKAGBI GJDJJJOJIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint KKKLFOGDEBB;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x73EA390", Offset = "0x73E9190", VA = "0x1873EA390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct NAGPHOLGKIP
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal readonly KEDMJBPGPFE OOCJAOHFGJK;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x73E7300", Offset = "0x73E6100", VA = "0x1873E7300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct JFPBOBAHIAP
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal readonly KEDMJBPGPFE OOCJAOHFGJK;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x73E7300", Offset = "0x73E6100", VA = "0x1873E7300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct CMPAIBJAHLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal readonly uint KKKLFOGDEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal readonly bool AJLGBBONEKL;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x73E2BA0", Offset = "0x73E19A0", VA = "0x1873E2BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct OGKFGJKAGBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal int DACBEFNKNPO;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x73EF9F0", Offset = "0x73EE7F0", VA = "0x1873EF9F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.Application)]
public interface APMMMKDFFKN
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	AAPOJHFDKIL FNLDAALNKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public enum IDPBDBENFJD
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Legacy,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Embodied,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Disembodying,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Disembodied
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface HILEJELFOGB : MEONDNPMLGJ
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	IDPBDBENFJD ICKKEMKPCGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool BPDHCMKMIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	GameObject IHNPMPCJPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<HILEJELFOGB> DNLKAFGCCDH;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(AMOENAFJHDD FNFMGPKBOAC, ODHMICMEHJH HHAPNBLKCIB);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool ELAFKKLBKLG);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class KKFPCFJCNPL
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x73EAAF0", Offset = "0x73E98F0", VA = "0x1873EAAF0")]
	public static bool KPEJMDCNOPH(this HILEJELFOGB DDKBCACPHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x73EABD0", Offset = "0x73E99D0", VA = "0x1873EABD0")]
	public static bool PPOFHIMIKHG(this HILEJELFOGB DDKBCACPHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x73EAAA0", Offset = "0x73E98A0", VA = "0x1873EAAA0")]
	public static bool FKDABILKDNK(this HILEJELFOGB DDKBCACPHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x73EAB40", Offset = "0x73E9940", VA = "0x1873EAB40")]
	public static bool OBOEGBKEDDJ(this HILEJELFOGB DDKBCACPHPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface MEONDNPMLGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool FIMGNNJILII
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	ODHMICMEHJH PCOIIKCHBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface FEBIFDEGEEP
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate void KFPIFAPKEAP(JIDEKCFBIJM BNKPLOAOLMG);

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event KFPIFAPKEAP BNBACLCPHIP;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface FMLPLAELFOF
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CNLEAJPGOHI(Vector3 AKEODPFBHJE, Quaternion CKABIAOPKPM, Vector3 KFHMJCONBDC);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ODEJGNHFANL(ODHMICMEHJH IFAMCPHMKIP);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JKFIFJIDAGI(bool NFCLPJAADJC);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GMJOEFDDAGB(bool PCCNAPDOOIP);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface MHGKBNKKGDH
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface LNNBNEFDLBF
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(ODHMICMEHJH OLOJENFILPM);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool GCLJIDDBGGM);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PBOHCDBPFKK(ODHMICMEHJH HHAPNBLKCIB);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface GBACCFFNBFB
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(FHDFMCFBJMM GOOHNOGHBMN);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface FHDFMCFBJMM
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	GameObject IHNPMPCJPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Transform KAEMFHJNGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	BKMLAJCFPOO AILLLNJKDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool ADKGCMLHFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KGHDKIPKLKK(BKMLAJCFPOO MNCBDJMAFIF);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface BKMLAJCFPOO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000068")]
	ODHMICMEHJH PCOIIKCHBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	Rigidbody OKMLLKAPHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	FHDFMCFBJMM GPCHJNFJJDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	GameObject JEKAHIGLEHM
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Transform HHEFOFLOCNG
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	BKMLAJCFPOO LCIGPFKHHMP
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	BKMLAJCFPOO DIPIAJCGAGN
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	int ALNDPLKKMOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	bool NKAJLEECCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool FIPIKFDPMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool DDHKLPODPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	OIIFFMGENDA NDGKBOLHLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	PEHCDIDIDFL HADAHAKIAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float PGGIFJBJEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 AMLMBHHAEJE
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 GDFIBLLIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 LEFKCANEDPG
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Vector3 KHNLNENPKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	bool PDBINNACHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	bool OKLFBLPCGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool NGOKFAOAKNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	bool FFNKJNLOBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Vector3 DGPEONCCLJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Vector3 KJNCOIBLPBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	Vector3 MCNHMKCPMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	Vector3 MDDJDOBAIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	float GBFCDAFMDLO
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	float OKMBPDCAAGG
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 MCDNADKMFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	Quaternion AIGDBJBCJDE
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	float DBFJKFPLEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	float OMKMLLDNDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	bool HBLFKJDMPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	CDPBBJLFOGJ LAFBBOHALEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	bool JMMCPDFELOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	Transform CAKBGADMKLG
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	Vector3 CLLCLIPNFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	float DFEHGEIADFB
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	float CPHALJCMONF
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	Quaternion PIAIFHGNFML
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	Vector3 CIIGPNLPGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	Quaternion FDIJLBLBDEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	RigidbodyConstraints AHGDGGBFJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	bool NJLANIHBHFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	CollisionDetectionMode PJOKPNNELFB
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	bool HJFKNLHGEHL
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event ANKIPNDCANO MKLDCIAADDP;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event ANKIPNDCANO LEIJHKAEBAI;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event ANKIPNDCANO ALHCADIFMCB;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event ANKIPNDCANO HKDHMCAJDBJ;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event ANKIPNDCANO EOCIGPOJEAJ;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event ANKIPNDCANO MJOHIHKODKD;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event ANKIPNDCANO CKAOMBCKJPE;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event JFAIPABNDDB FKKLGGOKJNO;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<FMMANLJJECN, FMMANLJJECN> CPGMPPGCGAK;

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "26")]
	BKMLAJCFPOO MIKIBPHJIDH(int KNCPCNBMDNF);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void ABCJBEHKOHN((Quaternion rot, Vector3 moments) IEKPANIOKCJ);

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void NLNNABDBLFO();

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void LKOAEPLGAFF();

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void MNDLCNDCMOO();

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void LIAJGFPGOFL();

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void BFHIJDILBDB();

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void ODEJGNHFANL(BKMLAJCFPOO IPHILEOFJLB, bool CDNOMBACDJA = false);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void BPCIEHLINIP(object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void APKBLDCGCMI(object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 NJLCIKCJKMD(Vector3 DKHOBKICOML);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 HBLCPBHIIDI(Vector3 FOLDPAFFMOB);

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void ICNBDOGBKCC();

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void JOLLBIOJCBM();

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void CFNHIHGNLJC();

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void DMPLLEHEHHJ(Vector3 NKJFLEFCNNK, Vector3 KMOLFMJJEFF);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void NKCPNGJPKJI(Vector3 PGPILCGHHEN, Vector3 HPDLDIEKLGI);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void MHOOOJMNAMI(Vector3 GJDKCHCMPKK);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void FHDDMCOIBHK(DLLHHLOAIHN JNKNJFCPKCP, Vector3 DENBFHHPJGH, float INBGKGNKFFB, float LHLMMNAMGFA = 8f, float KOOKFIHBGFH = 1f);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void IIDMCFJEDDH(PKECHOKBABG EBIBFBONINJ, Vector3 JPKNKMLFEDJ, float LNNCFJOFHBA = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void GIPFFEIENKO(PKECHOKBABG EBIBFBONINJ, Vector3 CKABIAOPKPM, float HDGLIBMICCI = 7f, float DPLEKOGCINM = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 DBDODPLBOAD(Vector3 IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 BCLNKGGBOEH(Vector3 IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void IALHFLNDCNP();

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void OMLHKDNIBJN(BKMLAJCFPOO LNDOFDMKLIE, object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void GCANHKDPCOM(object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void EGIHCPCAFBE();

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void FAHHJFPOHIJ();

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void FCBHEDAOLDB();

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool ABCPKPFAHNI();

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void ACKEKMFONNI();

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void NDNHLHKLAJO(object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void DHHHJHJJACF(object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void LFKMFFNIBNF(object HACFGBHNOCC, bool AFBCKAHGIKH);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void PFJAPFPFLOE(Vector3 OHGAAEDJDPL, Quaternion LDPILEOMGMF);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void CAKBMNHOGBB(Vector3 ANBHGIAIIEJ, Quaternion OCGOOLKPBNF);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool MIPLFJJMAIB(float GCBKKLKKPFG);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void KHGLCMCLAGL(object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void HNINIJALCOE(object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void DMCOGFFPGPE(object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void GNBBEKCJFMA(object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void PGLBLAGLHBK(Vector3 MKKNPGPEIPF, ForceMode PBMLNEJDMIB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void JGMDIHEFGOP(Vector3 MKKNPGPEIPF, Vector3 AKEODPFBHJE, ForceMode PBMLNEJDMIB);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void HKABICKGENB(Vector3 FHOLONAELHO, ForceMode PBMLNEJDMIB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void PMLDNMMBFDJ(Vector3 FHOLONAELHO, ForceMode PBMLNEJDMIB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool MPEAOKEEILP(Vector3 GGAAGAFEPHJ, [Out] RaycastHit KCLINOMLMOA, float HKMCFNGLEFP);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void GLCKBHAHEJI();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface PEHCDIDIDFL
{
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGEFMCPCGDO(Vector3 OJCNKHHAHJK);

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMFDMIMODCH(Vector3 APIEHLLLAEO);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LKBFANAHDKI(Vector3 OJCNKHHAHJK);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void COKLCLNBGNH(Vector3 APIEHLLLAEO);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface OIIFFMGENDA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 JJHEALINOGK();

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 BLFAJILLKJA();
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public delegate void ANKIPNDCANO(FHDFMCFBJMM NPHAGJDLPNC);
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum INFABEOFNBB
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	ChildAdded,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	ChildRemoved,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	ParentChanged,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	HierarchyMassUpdated,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	SleepChanged,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	DistanceBandChanged,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	IsKinematicChanged,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Discontinuity,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Destroyed,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum DLLHHLOAIHN
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Reflective,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	FullOverride
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public delegate void JFAIPABNDDB(FHDFMCFBJMM NPHAGJDLPNC, bool CDNOMBACDJA = false);
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum PKECHOKBABG
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct HKDIAHPAMEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Rigidbody BFBNFNHBHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public object CCGHOCGLGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector3 GJBMPLJHKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector3 IHNNMMEJCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public OAPFEGBJMCF NOODLEOBFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool EOPHGICJGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool PHBDBJOLNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool FHCALEDIKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public bool CKKBEGCGEGG;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct JNCOEOPKELP : IEquatable<JNCOEOPKELP>, MEONDNPMLGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly JNCOEOPKELP NMEPCFHKJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public ODHMICMEHJH PCOIIKCHBNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020", Slot = "6")]
		get
		{
			return default(ODHMICMEHJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public JGPOHMGAPPN HHEFOFLOCNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JGPOHMGAPPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public PKPEDDDKDGE BADMGIIJNGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(PKPEDDDKDGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private PHOLKIHIPKK FMOMHMCAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x73DFCA0", Offset = "0x73DEAA0", VA = "0x1873DFCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public GameObject IHNPMPCJPIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x73E9650", Offset = "0x73E8450", VA = "0x1873E9650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public HLIKGPHNDCA IFPEIFDMIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x73E9C40", Offset = "0x73E8A40", VA = "0x1873E9C40")]
		get
		{
			return default(HLIKGPHNDCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public DCDDLCJJDIG KANAONGEIMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x73E9D00", Offset = "0x73E8B00", VA = "0x1873E9D00")]
		get
		{
			return default(DCDDLCJJDIG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public NJNFOMGPIJM IOCHNADDJBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x73E98D0", Offset = "0x73E86D0", VA = "0x1873E98D0")]
		get
		{
			return default(NJNFOMGPIJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool PIGCCLMLFEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x73E9CE0", Offset = "0x73E8AE0", VA = "0x1873E9CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool GFFCPDJKLAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x73E9DC0", Offset = "0x73E8BC0", VA = "0x1873E9DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool HJEMCGEOONA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x73E9B60", Offset = "0x73E8960", VA = "0x1873E9B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool PGMBGODDNLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x73E9DA0", Offset = "0x73E8BA0", VA = "0x1873E9DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool CFMGEHIGEPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x73E9C20", Offset = "0x73E8A20", VA = "0x1873E9C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool LJEHOBNCNCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x73E9870", Offset = "0x73E8670", VA = "0x1873E9870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool FJDHNCKANEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x73E9DE0", Offset = "0x73E8BE0", VA = "0x1873E9DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool KCKELFHIBIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x73E9A60", Offset = "0x73E8860", VA = "0x1873E9A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public POMLIFOMBED IAGGHIKOGKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(POMLIFOMBED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public LLIAENFOHDB JCEGGLJNFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(LLIAENFOHDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public CIIGNEOLGKC IOHAJMBFHGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(CIIGNEOLGKC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public AFHDOEFIJMN AOIHANHGLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(AFHDOEFIJMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public LMCLPELOPFB FMNGDDDEIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(LMCLPELOPFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public PFLMCLFEGIK ACDHCOBELOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(PFLMCLFEGIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public JCOIKEFKAMM BLBKIHLGIKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JCOIKEFKAMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public GDNANJCKLDI KNEGLEJMPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(GDNANJCKLDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public LDHKLCKOEGJ KNPHOPKJOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(LDHKLCKOEGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public DMBMBGJMECE ADHFICEHJOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(DMBMBGJMECE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public DNGDPKMGEOA ANCFKDAJKGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(DNGDPKMGEOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public KALIMOAKMIK KECNHJPECKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(KALIMOAKMIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public KEMCKKCMHAC DLHFADPONIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(KEMCKKCMHAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public LNINOJJDDHO ILIADINKFLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(LNINOJJDDHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool KPEJMDCNOPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x73E9970", Offset = "0x73E8770", VA = "0x1873E9970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool FECDHOFOOJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x73E9E20", Offset = "0x73E8C20", VA = "0x1873E9E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool OHAMMGIPJKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x73E9890", Offset = "0x73E8690", VA = "0x1873E9890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool JMLENOGLEBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public JNCOEOPKELP(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x73E0E30", Offset = "0x73DFC30", VA = "0x1873E0E30")]
	public static bool JCHCBNMNCNP(JNCOEOPKELP IPHILEOFJLB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
	public static ODHMICMEHJH JCHCBNMNCNP(JNCOEOPKELP IPHILEOFJLB)
	{
		return default(ODHMICMEHJH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x73E9860", Offset = "0x73E8660", VA = "0x1873E9860")]
	public static bool BHDCHHANDIG(JNCOEOPKELP HJGGLHBFMKO, JNCOEOPKELP AGAPPIBJJBC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x73E6480", Offset = "0x73E5280", VA = "0x1873E6480")]
	public static bool HGMDHININLF(JNCOEOPKELP HJGGLHBFMKO, JNCOEOPKELP AGAPPIBJJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x73E9AA0", Offset = "0x73E88A0", VA = "0x1873E9AA0", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(JNCOEOPKELP LHMPMCLNOPG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
	public static JNCOEOPKELP JCHCBNMNCNP(ODHMICMEHJH FEOCBDNIFLG)
	{
		return default(JNCOEOPKELP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x73E95D0", Offset = "0x73E83D0", VA = "0x1873E95D0")]
	public PLCHNMHOOON AAAEMHKLFOO()
	{
		return default(PLCHNMHOOON);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x73E9B30", Offset = "0x73E8930", VA = "0x1873E9B30")]
	public IKKILFFDLKJ FJBJCGKDDAA()
	{
		return default(IKKILFFDLKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x73E9810", Offset = "0x73E8610", VA = "0x1873E9810")]
	public BOHHOFLNGLL AGCDOEPLHNJ()
	{
		return default(BOHHOFLNGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x73E97E0", Offset = "0x73E85E0", VA = "0x1873E97E0")]
	public KBLNGFBNHON AAJKJJLOMIF()
	{
		return default(KBLNGFBNHON);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x73E9B80", Offset = "0x73E8980", VA = "0x1873E9B80")]
	public void HMNMNNCNPAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x73E9E60", Offset = "0x73E8C60", VA = "0x1873E9E60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct JCOIKEFKAMM : IEquatable<JCOIKEFKAMM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public ODHMICMEHJH PCOIIKCHBNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(ODHMICMEHJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private PHOLKIHIPKK FMOMHMCAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x73DFCA0", Offset = "0x73DEAA0", VA = "0x1873DFCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private PLKPCGBKHBF FNNKILGPPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x73E71E0", Offset = "0x73E5FE0", VA = "0x1873E71E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private AIIEKAIMAJJ EAJDHOOLMBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x73E7180", Offset = "0x73E5F80", VA = "0x1873E7180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool NNKGLOLMNCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x73E6EB0", Offset = "0x73E5CB0", VA = "0x1873E6EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Guid DNLBFIDHOBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x73E6F40", Offset = "0x73E5D40", VA = "0x1873E6F40")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool DJEHCHDNKFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x73E7270", Offset = "0x73E6070", VA = "0x1873E7270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public Guid LEGOCGBKEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x73E7060", Offset = "0x73E5E60", VA = "0x1873E7060")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public JCOIKEFKAMM(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x73E6B40", Offset = "0x73E5940", VA = "0x1873E6B40", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(JCOIKEFKAMM LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x73E6AA0", Offset = "0x73E58A0", VA = "0x1873E6AA0")]
	public bool CGEEJGLGBGM([Out] Guid FDFKGMJMPMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x73E6D90", Offset = "0x73E5B90", VA = "0x1873E6D90")]
	public void ICIPDGMLFKD(Guid OAJCPHOOFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x73E6CF0", Offset = "0x73E5AF0", VA = "0x1873E6CF0")]
	public bool IBIHBOLJFGP([Out] Guid INONPKMEIIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x73E6BD0", Offset = "0x73E59D0", VA = "0x1873E6BD0")]
	public void GLKOJDOJNMP(Guid OAJCPHOOFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x73E6A10", Offset = "0x73E5810", VA = "0x1873E6A10")]
	public void CAAOMFGMCOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct BOHHOFLNGLL : IEquatable<BOHHOFLNGLL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public ODHMICMEHJH PCOIIKCHBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(ODHMICMEHJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private PHOLKIHIPKK FMOMHMCAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x73DFCA0", Offset = "0x73DEAA0", VA = "0x1873DFCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private PLKPCGBKHBF FNNKILGPPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x73E11F0", Offset = "0x73DFFF0", VA = "0x1873E11F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private FBNMMGJAKMI GNGMFBOFNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x73E0C00", Offset = "0x73DFA00", VA = "0x1873E0C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 GAIHKFMLOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x73E1440", Offset = "0x73E0240", VA = "0x1873E1440")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public Quaternion CDBOBDPMJFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x73E0C60", Offset = "0x73DFA60", VA = "0x1873E0C60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public JNCOEOPKELP NMPNLFPGNAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x73E1590", Offset = "0x73E0390", VA = "0x1873E1590")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public BOHHOFLNGLL(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x73E0E30", Offset = "0x73DFC30", VA = "0x1873E0E30")]
	public static bool JCHCBNMNCNP(BOHHOFLNGLL IPHILEOFJLB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
	public static ODHMICMEHJH JCHCBNMNCNP(BOHHOFLNGLL IPHILEOFJLB)
	{
		return default(ODHMICMEHJH);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x73E0DA0", Offset = "0x73DFBA0", VA = "0x1873E0DA0", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(BOHHOFLNGLL LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x73E0F60", Offset = "0x73DFD60", VA = "0x1873E0F60")]
	public FEBOOADAFMA KFGJGODAEOL(Allocator GCNJHJPCIGN)
	{
		return default(FEBOOADAFMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x73E10A0", Offset = "0x73DFEA0", VA = "0x1873E10A0")]
	public void NIEJKPDKJLC(Vector3 AKEODPFBHJE, Quaternion CKABIAOPKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x73E0E50", Offset = "0x73DFC50", VA = "0x1873E0E50")]
	public void JFPGIEEIDME(float KFHMJCONBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x73E1280", Offset = "0x73E0080", VA = "0x1873E1280")]
	public void PBLJCGJAMHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct PLCHNMHOOON : IEquatable<PLCHNMHOOON>
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly PLCHNMHOOON NMEPCFHKJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public ODHMICMEHJH PCOIIKCHBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(ODHMICMEHJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public JGPOHMGAPPN HHEFOFLOCNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JGPOHMGAPPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public PKPEDDDKDGE BADMGIIJNGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(PKPEDDDKDGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	private PHOLKIHIPKK FMOMHMCAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x73DFCA0", Offset = "0x73DEAA0", VA = "0x1873DFCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	private PLKPCGBKHBF FNNKILGPPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x73F1BE0", Offset = "0x73F09E0", VA = "0x1873F1BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	private JDCLPPHDFCC HHMANLFDOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x73F0C20", Offset = "0x73EFA20", VA = "0x1873F0C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public FEBOOADAFMA JNIIAFNCACA
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x73F13C0", Offset = "0x73F01C0", VA = "0x1873F13C0")]
		get
		{
			return default(FEBOOADAFMA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public IEnumerable<JNCOEOPKELP> FDEJDHNLPJN
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x73F0A20", Offset = "0x73EF820", VA = "0x1873F0A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public IEnumerable<JNCOEOPKELP> EIPNECMBMFA
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x73F14E0", Offset = "0x73F02E0", VA = "0x1873F14E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public int ALNDPLKKMOO
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x73F0C80", Offset = "0x73EFA80", VA = "0x1873F0C80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public int LEOAEKODBLH
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x73F1370", Offset = "0x73F0170", VA = "0x1873F1370")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public string HIGBIGGFHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x73F1C70", Offset = "0x73F0A70", VA = "0x1873F1C70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x73F12F0", Offset = "0x73F00F0", VA = "0x1873F12F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public PLCHNMHOOON(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x73E0E30", Offset = "0x73DFC30", VA = "0x1873E0E30")]
	public static bool JCHCBNMNCNP(PLCHNMHOOON IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x73F0B90", Offset = "0x73EF990", VA = "0x1873F0B90", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(PLCHNMHOOON LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
	public static JNCOEOPKELP JCHCBNMNCNP(PLCHNMHOOON DJAJDIFOIHP)
	{
		return default(JNCOEOPKELP);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x73F1BC0", Offset = "0x73F09C0", VA = "0x1873F1BC0")]
	public bool LOBJAAALCEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x73F0D10", Offset = "0x73EFB10", VA = "0x1873F0D10")]
	public FEBOOADAFMA GNLGPLCCLKM(Allocator GCNJHJPCIGN)
	{
		return default(FEBOOADAFMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x73F0F40", Offset = "0x73EFD40", VA = "0x1873F0F40")]
	public void HGHKPOMJKIC(PLCHNMHOOON LHMPMCLNOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x73F1610", Offset = "0x73F0410", VA = "0x1873F1610")]
	public void LJEJAMEKPEJ(List<JNCOEOPKELP> MMBKIMKKEEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct LNINOJJDDHO : IEquatable<LNINOJJDDHO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool IFNPMNJPPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x73ECCA0", Offset = "0x73EBAA0", VA = "0x1873ECCA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public Vector3 BBGLKALGABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x73ECC20", Offset = "0x73EBA20", VA = "0x1873ECC20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x73ECD50", Offset = "0x73EBB50", VA = "0x1873ECD50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public LNINOJJDDHO(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x73ECB90", Offset = "0x73EB990", VA = "0x1873ECB90", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(LNINOJJDDHO LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x73ECC20", Offset = "0x73EBA20", VA = "0x1873ECC20")]
	public Vector3 LGACGNCCEGI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x73ECB10", Offset = "0x73EB910", VA = "0x1873ECB10")]
	public void COFNDFNGLIN([In] Vector3 IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x73ECCE0", Offset = "0x73EBAE0", VA = "0x1873ECCE0")]
	public bool ONGFJGIABPI([In] Vector3 IPHILEOFJLB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct LLIAENFOHDB : IEquatable<LLIAENFOHDB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	private PHOLKIHIPKK FMOMHMCAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x73DFCA0", Offset = "0x73DEAA0", VA = "0x1873DFCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public LLIAENFOHDB(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x73EBC80", Offset = "0x73EAA80", VA = "0x1873EBC80", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(LLIAENFOHDB LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x73EBB40", Offset = "0x73EA940", VA = "0x1873EBB40")]
	public void EALPOFJKPGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x73EBBE0", Offset = "0x73EA9E0", VA = "0x1873EBBE0")]
	public bool EJKMFKLLGAO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct PKPEDDDKDGE : IEquatable<PKPEDDDKDGE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public ODHMICMEHJH PCOIIKCHBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(ODHMICMEHJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	private PHOLKIHIPKK FMOMHMCAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x73DFCA0", Offset = "0x73DEAA0", VA = "0x1873DFCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private PLKPCGBKHBF FNNKILGPPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x73F0620", Offset = "0x73EF420", VA = "0x1873F0620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	private JDCLPPHDFCC HHMANLFDOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x73F0300", Offset = "0x73EF100", VA = "0x1873F0300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public ODHMICMEHJH OAGAJGBBCEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x73F0140", Offset = "0x73EEF40", VA = "0x1873F0140")]
		get
		{
			return default(ODHMICMEHJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public JNCOEOPKELP LCIGPFKHHMP
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x73F0010", Offset = "0x73EEE10", VA = "0x1873F0010")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public JNCOEOPKELP DIPIAJCGAGN
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x73F01D0", Offset = "0x73EEFD0", VA = "0x1873F01D0")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public int ALNDPLKKMOO
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x73F0360", Offset = "0x73EF160", VA = "0x1873F0360")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public PKPEDDDKDGE(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x73E0E30", Offset = "0x73DFC30", VA = "0x1873E0E30")]
	public static bool JCHCBNMNCNP(PKPEDDDKDGE IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x73F0270", Offset = "0x73EF070", VA = "0x1873F0270", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(PKPEDDDKDGE LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x73F04F0", Offset = "0x73EF2F0", VA = "0x1873F04F0")]
	public bool ODEJGNHFANL(JNCOEOPKELP IFAMCPHMKIP, bool FDDKCBOPFEO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x73F00A0", Offset = "0x73EEEA0", VA = "0x1873F00A0")]
	public bool CDHBLACNIBG(JNCOEOPKELP JBFBAHDHLKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x73F0740", Offset = "0x73EF540", VA = "0x1873F0740")]
	private void PGCCDJPHFEO(JNCOEOPKELP MGJMMLBKLMC, List<JNCOEOPKELP> FCEMGBEGPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x73F0440", Offset = "0x73EF240", VA = "0x1873F0440")]
	public bool LOBJAAALCEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x73F0260", Offset = "0x73EF060", VA = "0x1873F0260")]
	public void DNKJANCCAKP(List<JNCOEOPKELP> BEJJDEGPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x73F0460", Offset = "0x73EF260", VA = "0x1873F0460")]
	public PLCHNMHOOON MLNCMNJOEOK()
	{
		return default(PLCHNMHOOON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x73F09C0", Offset = "0x73EF7C0", VA = "0x1873F09C0")]
	public void PONBBLGMMAA(List<JNCOEOPKELP> BEJJDEGPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x73EFEF0", Offset = "0x73EECF0", VA = "0x1873EFEF0")]
	public NativeArray<ODHMICMEHJH> AJIPOIACMJB()
	{
		return default(NativeArray<ODHMICMEHJH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x73F06B0", Offset = "0x73EF4B0", VA = "0x1873F06B0")]
	public int OEGIMDNLDLC()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct POMLIFOMBED : IEquatable<POMLIFOMBED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public string CKOJFIPAENM
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x73F3150", Offset = "0x73F1F50", VA = "0x1873F3150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public string LBMLCMCGHND
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x73F3020", Offset = "0x73F1E20", VA = "0x1873F3020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private bool DBNMFMFHBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x73F2DF0", Offset = "0x73F1BF0", VA = "0x1873F2DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public string COKFHNOFNOI
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x73F29C0", Offset = "0x73F17C0", VA = "0x1873F29C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public string FJDKKOFPMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x73F2BA0", Offset = "0x73F19A0", VA = "0x1873F2BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public string ONHODFGOAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x73F2AB0", Offset = "0x73F18B0", VA = "0x1873F2AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public POMLIFOMBED(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x73F2F90", Offset = "0x73F1D90", VA = "0x1873F2F90", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(POMLIFOMBED LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct DNGDPKMGEOA : IEquatable<DNGDPKMGEOA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private PHOLKIHIPKK FMOMHMCAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x73DFCA0", Offset = "0x73DEAA0", VA = "0x1873DFCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private PLKPCGBKHBF FNNKILGPPMM
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x73E43D0", Offset = "0x73E31D0", VA = "0x1873E43D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private FNPKDENMMNK KNINDBNDHHC
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x73E41A0", Offset = "0x73E2FA0", VA = "0x1873E41A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public GADINOAACEO DHHLHCCAPDC
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x73E40A0", Offset = "0x73E2EA0", VA = "0x1873E40A0")]
		get
		{
			return default(GADINOAACEO);
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x73E3EF0", Offset = "0x73E2CF0", VA = "0x1873E3EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public bool LGAEAEMLLBK
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x73E3C00", Offset = "0x73E2A00", VA = "0x1873E3C00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x73E3E50", Offset = "0x73E2C50", VA = "0x1873E3E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public string[] MAHLPJPPKNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x73E4200", Offset = "0x73E3000", VA = "0x1873E4200")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x73E4000", Offset = "0x73E2E00", VA = "0x1873E4000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public string[] DGIKIJAEEKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x73E3AE0", Offset = "0x73E28E0", VA = "0x1873E3AE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x73E4460", Offset = "0x73E3260", VA = "0x1873E4460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public string[] CPPBLMDPLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x73E3C90", Offset = "0x73E2A90", VA = "0x1873E3C90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x73E4330", Offset = "0x73E3130", VA = "0x1873E4330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public string[] GBPJKJCHKCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x73E3B70", Offset = "0x73E2970", VA = "0x1873E3B70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x73E3D20", Offset = "0x73E2B20", VA = "0x1873E3D20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public DNGDPKMGEOA(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
	public static ODHMICMEHJH JCHCBNMNCNP(DNGDPKMGEOA IPHILEOFJLB)
	{
		return default(ODHMICMEHJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x73E3DC0", Offset = "0x73E2BC0", VA = "0x1873E3DC0", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(DNGDPKMGEOA LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x73E4290", Offset = "0x73E3090", VA = "0x1873E4290")]
	public bool MDLMHKLPOAN(ODHMICMEHJH CJJBIEHOBCD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct AILIBGCMGJB : IEquatable<AILIBGCMGJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x73E0AC0", Offset = "0x73DF8C0", VA = "0x1873E0AC0", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(AILIBGCMGJB LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct CIIGNEOLGKC : IEquatable<CIIGNEOLGKC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public Collider AHPKJLLODBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x73E1B70", Offset = "0x73E0970", VA = "0x1873E1B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public GLDFCNIMNAN EOIFCIELLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x73E2470", Offset = "0x73E1270", VA = "0x1873E2470")]
		get
		{
			return default(GLDFCNIMNAN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x73E2420", Offset = "0x73E1220", VA = "0x1873E2420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public JCNPJIGPNPG JANIDJOCIBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x73E23E0", Offset = "0x73E11E0", VA = "0x1873E23E0")]
		get
		{
			return default(JCNPJIGPNPG);
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x73E2530", Offset = "0x73E1330", VA = "0x1873E2530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public FKEFFIMPMDP NHNBFFOAGKD
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x73E1FB0", Offset = "0x73E0DB0", VA = "0x1873E1FB0")]
		get
		{
			return default(FKEFFIMPMDP);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x73E1CC0", Offset = "0x73E0AC0", VA = "0x1873E1CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public float OMNEGJDACEM
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x73E2180", Offset = "0x73E0F80", VA = "0x1873E2180")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x73E1E70", Offset = "0x73E0C70", VA = "0x1873E1E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool LFOEIEGEGEG
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x73E2210", Offset = "0x73E1010", VA = "0x1873E2210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public bool KENNKMCHECP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x73E2030", Offset = "0x73E0E30", VA = "0x1873E2030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public bool FHNMKKJMDIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x73E2370", Offset = "0x73E1170", VA = "0x1873E2370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public bool GHDNLKJHGEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x73E20A0", Offset = "0x73E0EA0", VA = "0x1873E20A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool NBDFBDPCOEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x73E1FF0", Offset = "0x73E0DF0", VA = "0x1873E1FF0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x73E2580", Offset = "0x73E1380", VA = "0x1873E2580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool DBJPCBCOHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x73E21C0", Offset = "0x73E0FC0", VA = "0x1873E21C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x73E2110", Offset = "0x73E0F10", VA = "0x1873E2110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public CIIGNEOLGKC(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x73E1F20", Offset = "0x73E0D20", VA = "0x1873E1F20", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(CIIGNEOLGKC LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x73E1D10", Offset = "0x73E0B10", VA = "0x1873E1D10")]
	public bool APKHHNCGNNH([Out] LNNBNEFDLBF LOHANPKBMOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x73E2280", Offset = "0x73E1080", VA = "0x1873E2280")]
	public bool MCLEBIGDCGG([Out] ODHMICMEHJH DOJENPPADJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x73E1EC0", Offset = "0x73E0CC0", VA = "0x1873E1EC0")]
	public bool COGKPFNDFPM(OFKIBJDIALG ACCBEMFKLOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x73E24B0", Offset = "0x73E12B0", VA = "0x1873E24B0")]
	public void NHFMCDMNGPL(OFKIBJDIALG ACCBEMFKLOI, bool OHPJAPBNBPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct KBLNGFBNHON : IEquatable<KBLNGFBNHON>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public bool PFMGOJLEIMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x73EA340", Offset = "0x73E9140", VA = "0x1873EA340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public KBLNGFBNHON(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x73EA2B0", Offset = "0x73E90B0", VA = "0x1873EA2B0", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(KBLNGFBNHON LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct LDHKLCKOEGJ : IEquatable<LDHKLCKOEGJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public ODHMICMEHJH PCOIIKCHBNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(ODHMICMEHJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private PHOLKIHIPKK FMOMHMCAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x73DFCA0", Offset = "0x73DEAA0", VA = "0x1873DFCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	private PLKPCGBKHBF FNNKILGPPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x73EAF50", Offset = "0x73E9D50", VA = "0x1873EAF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	private BHEMNCJIDNN EMNJBFEPNNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x73EAFE0", Offset = "0x73E9DE0", VA = "0x1873EAFE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public LDHKLCKOEGJ(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x73EAEC0", Offset = "0x73E9CC0", VA = "0x1873EAEC0", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(LDHKLCKOEGJ LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x73EAE20", Offset = "0x73E9C20", VA = "0x1873EAE20")]
	public void EDOENICBPIM(bool MJIMJNCKNCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct AFHDOEFIJMN : IEquatable<AFHDOEFIJMN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public ODHMICMEHJH PCOIIKCHBNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(ODHMICMEHJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	private PHOLKIHIPKK FMOMHMCAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x73DFCA0", Offset = "0x73DEAA0", VA = "0x1873DFCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	private PLKPCGBKHBF FNNKILGPPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x73E0670", Offset = "0x73DF470", VA = "0x1873E0670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public bool JLDHJIONHKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x73E02B0", Offset = "0x73DF0B0", VA = "0x1873E02B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public bool GGCMCIBNAEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x73E0260", Offset = "0x73DF060", VA = "0x1873E0260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public bool PNHHMLLOKBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x73E0960", Offset = "0x73DF760", VA = "0x1873E0960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public bool BABPOACCPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x73DFE40", Offset = "0x73DEC40", VA = "0x1873DFE40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool GGEDFEIEGAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x73DFEE0", Offset = "0x73DECE0", VA = "0x1873DFEE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool MNKACMEKFPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x73DFDF0", Offset = "0x73DEBF0", VA = "0x1873DFDF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool AALJKKKIKOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x73DFFD0", Offset = "0x73DEDD0", VA = "0x1873DFFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool IDOMMFBGEMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x73E03C0", Offset = "0x73DF1C0", VA = "0x1873E03C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool AJEEFMCDCCE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x73DFF30", Offset = "0x73DED30", VA = "0x1873DFF30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool EJECGBFOPJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x73DFE90", Offset = "0x73DEC90", VA = "0x1873DFE90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool KFFLBDMBLIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x73DFF80", Offset = "0x73DED80", VA = "0x1873DFF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool BIAMNNEFHKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x73DFD00", Offset = "0x73DEB00", VA = "0x1873DFD00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool OIGKKCAFMBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x73DFDA0", Offset = "0x73DEBA0", VA = "0x1873DFDA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public bool DPHBMMGPJDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x73E05F0", Offset = "0x73DF3F0", VA = "0x1873E05F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x73E01D0", Offset = "0x73DEFD0", VA = "0x1873E01D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public MDOGAOLHEIJ BBEJBKAOHHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x73E05B0", Offset = "0x73DF3B0", VA = "0x1873E05B0")]
		get
		{
			return default(MDOGAOLHEIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x73E02F0", Offset = "0x73DF0F0", VA = "0x1873E02F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public bool COACGIFDKMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x73E0750", Offset = "0x73DF550", VA = "0x1873E0750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public FJJIGCEJIMM PHNDLGDJCCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x73E0630", Offset = "0x73DF430", VA = "0x1873E0630")]
		get
		{
			return default(FJJIGCEJIMM);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x73DFD50", Offset = "0x73DEB50", VA = "0x1873DFD50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public bool IKCGEOKJMII
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x73E0510", Offset = "0x73DF310", VA = "0x1873E0510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Vector3 GCCOGNFECAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x73E0150", Offset = "0x73DEF50", VA = "0x1873E0150")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public Vector3 KPAKHODKLNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x73E08E0", Offset = "0x73DF6E0", VA = "0x1873E08E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool HEOHCNCPEJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x73E0410", Offset = "0x73DF210", VA = "0x1873E0410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public AFHDOEFIJMN(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x73E0060", Offset = "0x73DEE60", VA = "0x1873E0060", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(AFHDOEFIJMN LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x73E0550", Offset = "0x73DF350", VA = "0x1873E0550")]
	public bool LMAKPADMLKM(GBACOOFBNFH ACCBEMFKLOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x73E0700", Offset = "0x73DF500", VA = "0x1873E0700")]
	public bool OEEKMFLFJMH(DEHCHGHMLNK ACCBEMFKLOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x73E0340", Offset = "0x73DF140", VA = "0x1873E0340")]
	public void KFJIDCALCLF(DEHCHGHMLNK ACCBEMFKLOI, bool OHPJAPBNBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x73E0020", Offset = "0x73DEE20", VA = "0x1873E0020")]
	public DEHCHGHMLNK ENPHGMCJNAG()
	{
		return default(DEHCHGHMLNK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x73E0100", Offset = "0x73DEF00", VA = "0x1873E0100")]
	public bool FEKJICMLBDI(DEHCHGHMLNK IPHILEOFJLB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct DMBMBGJMECE : IEquatable<DMBMBGJMECE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private PHOLKIHIPKK FMOMHMCAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x73DFCA0", Offset = "0x73DEAA0", VA = "0x1873DFCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	private PLKPCGBKHBF FNNKILGPPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x73E3810", Offset = "0x73E2610", VA = "0x1873E3810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	private NPPFBIIJHFO CENNDKKNJDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x73E35F0", Offset = "0x73E23F0", VA = "0x1873E35F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public DMBMBGJMECE(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x73E3030", Offset = "0x73E1E30", VA = "0x1873E3030", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(DMBMBGJMECE LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x73E2F00", Offset = "0x73E1D00", VA = "0x1873E2F00")]
	public bool CPALJNGOHJD(PMJLGJGNALL NCGEJMOHJLG, List<JNCOEOPKELP> MMBKIMKKEEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x73E31F0", Offset = "0x73E1FF0", VA = "0x1873E31F0")]
	public int JGBBEJCNOIG(PMJLGJGNALL NCGEJMOHJLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x73E3650", Offset = "0x73E2450", VA = "0x1873E3650")]
	public void NMGIMHAECBO(List<JNCOEOPKELP> MMBKIMKKEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x73E30C0", Offset = "0x73E1EC0", VA = "0x1873E30C0")]
	public int IKKFBIBAJIP(JNCOEOPKELP OBIPBFFAILK, PMJLGJGNALL NCGEJMOHJLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x73E34C0", Offset = "0x73E22C0", VA = "0x1873E34C0")]
	public JNCOEOPKELP NKKHKBEJFHA(int KNCPCNBMDNF, PMJLGJGNALL NCGEJMOHJLG)
	{
		return default(JNCOEOPKELP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x73E39B0", Offset = "0x73E27B0", VA = "0x1873E39B0")]
	public void PEFLDJCHJMP(JNCOEOPKELP OBIPBFFAILK, PMJLGJGNALL NCGEJMOHJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x73E3410", Offset = "0x73E2210", VA = "0x1873E3410")]
	public bool MEBFANLCAED(JNCOEOPKELP OBIPBFFAILK, PMJLGJGNALL NCGEJMOHJLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x73E38A0", Offset = "0x73E26A0", VA = "0x1873E38A0")]
	public void OPJJEPKNECM(PMJLGJGNALL NCGEJMOHJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x73E3760", Offset = "0x73E2560", VA = "0x1873E3760")]
	public bool NOMBPAAGLAC(JNCOEOPKELP OBIPBFFAILK, PMJLGJGNALL NCGEJMOHJLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x73E3300", Offset = "0x73E2100", VA = "0x1873E3300")]
	public bool MCPLDDEBCIL(PMJLGJGNALL NCGEJMOHJLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct PFLMCLFEGIK : IEquatable<PFLMCLFEGIK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public ODHMICMEHJH PCOIIKCHBNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(ODHMICMEHJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private PHOLKIHIPKK FMOMHMCAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x73DFCA0", Offset = "0x73DEAA0", VA = "0x1873DFCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	private PLKPCGBKHBF FNNKILGPPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x73EFE60", Offset = "0x73EEC60", VA = "0x1873EFE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public PFLMCLFEGIK(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x73EFCB0", Offset = "0x73EEAB0", VA = "0x1873EFCB0", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(PFLMCLFEGIK LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x73EFD40", Offset = "0x73EEB40", VA = "0x1873EFD40")]
	public void FAAPPEOILNE(bool IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x73EFDD0", Offset = "0x73EEBD0", VA = "0x1873EFDD0")]
	public void JLCOCPLIGBF(bool IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x349D810", Offset = "0x349C610", VA = "0x18349D810")]
	public T PLMBLAENPHO<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct KALIMOAKMIK : IEquatable<KALIMOAKMIK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public ODHMICMEHJH PCOIIKCHBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(ODHMICMEHJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private PHOLKIHIPKK FMOMHMCAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x73DFCA0", Offset = "0x73DEAA0", VA = "0x1873DFCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private PLKPCGBKHBF FNNKILGPPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x73EA220", Offset = "0x73E9020", VA = "0x1873EA220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private JGIIDBOOICE AGNKLIBLDCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x73EA010", Offset = "0x73E8E10", VA = "0x1873EA010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool IENGECHDBED
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x73EA190", Offset = "0x73E8F90", VA = "0x1873EA190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool FJBKEEOMFDB
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x73EA100", Offset = "0x73E8F00", VA = "0x1873EA100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public KALIMOAKMIK(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x73EA070", Offset = "0x73E8E70", VA = "0x1873EA070", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(KALIMOAKMIK LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct KIDOKFACOMD : IEquatable<KIDOKFACOMD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x73EA980", Offset = "0x73E9780", VA = "0x1873EA980", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(KIDOKFACOMD LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct LMCLPELOPFB : IEquatable<LMCLPELOPFB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public ODHMICMEHJH PCOIIKCHBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(ODHMICMEHJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	private PHOLKIHIPKK FMOMHMCAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x73DFCA0", Offset = "0x73DEAA0", VA = "0x1873DFCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	private PLKPCGBKHBF FNNKILGPPMM
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x73EC950", Offset = "0x73EB750", VA = "0x1873EC950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private MEFNBOPECIN IMNONDKJFIA
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x73EBFC0", Offset = "0x73EADC0", VA = "0x1873EBFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private DLJKKJKCGMB KKEKJNINMND
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x73EBEC0", Offset = "0x73EACC0", VA = "0x1873EBEC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool LMJKOLPBKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x73ECA80", Offset = "0x73EB880", VA = "0x1873ECA80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public bool JAPCCAFFBIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x73EBD10", Offset = "0x73EAB10", VA = "0x1873EBD10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public bool FLOOEIENKJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x73EC350", Offset = "0x73EB150", VA = "0x1873EC350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool EIHHGCKCLHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x73EC490", Offset = "0x73EB290", VA = "0x1873EC490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public bool HIOIMIIOCDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x73EC920", Offset = "0x73EB720", VA = "0x1873EC920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public bool ADKHICABJLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x73EC2C0", Offset = "0x73EB0C0", VA = "0x1873EC2C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public bool HAODABPDOBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x73EC0B0", Offset = "0x73EAEB0", VA = "0x1873EC0B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public bool LBAHELCLBFF
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x73EC610", Offset = "0x73EB410", VA = "0x1873EC610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool AENGPINMCFB
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x73EC780", Offset = "0x73EB580", VA = "0x1873EC780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public LMCLPELOPFB(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x73E0E30", Offset = "0x73DFC30", VA = "0x1873E0E30")]
	public static bool JCHCBNMNCNP(LMCLPELOPFB IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x73EC020", Offset = "0x73EAE20", VA = "0x1873EC020", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(LMCLPELOPFB LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x73EBDB0", Offset = "0x73EABB0", VA = "0x1873EBDB0")]
	public bool BIGACKKDCGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x73EC9E0", Offset = "0x73EB7E0", VA = "0x1873EC9E0")]
	public JNCOEOPKELP PBHMPJLMCFC(JNCOEOPKELP OBIPBFFAILK)
	{
		return default(JNCOEOPKELP);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x73EC380", Offset = "0x73EB180", VA = "0x1873EC380")]
	public ODHMICMEHJH LBPPCMKJOMB()
	{
		return default(ODHMICMEHJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x73EBF20", Offset = "0x73EAD20", VA = "0x1873EBF20")]
	public bool DOJKGCFDJNE(ODHMICMEHJH KAENJJCPEMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x73EBE20", Offset = "0x73EAC20", VA = "0x1873EBE20")]
	public bool CMHHPINNKML(ODHMICMEHJH NEDFFIIHGDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x73EC560", Offset = "0x73EB360", VA = "0x1873EC560")]
	public bool MDGBDLBEFMO(ODHMICMEHJH OBIPBFFAILK, [Out] ODHMICMEHJH KAENJJCPEMG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct IKKILFFDLKJ : IEquatable<IKKILFFDLKJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly IKKILFFDLKJ NMEPCFHKJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public ODHMICMEHJH PCOIIKCHBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(ODHMICMEHJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public JGPOHMGAPPN HHEFOFLOCNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JGPOHMGAPPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public PKPEDDDKDGE BADMGIIJNGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(PKPEDDDKDGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public AOIDDNEDMCD FGCIIFGDGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x73E6650", Offset = "0x73E5450", VA = "0x1873E6650")]
		get
		{
			return default(AOIDDNEDMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public BHMDPIOBIIO AMMOEPOKKMB
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x73E64A0", Offset = "0x73E52A0", VA = "0x1873E64A0")]
		get
		{
			return default(BHMDPIOBIIO);
		}
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x73E6600", Offset = "0x73E5400", VA = "0x1873E6600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public CMKDMKNLIMB CELLCPCCNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x73E63A0", Offset = "0x73E51A0", VA = "0x1873E63A0")]
		get
		{
			return default(CMKDMKNLIMB);
		}
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x73E65B0", Offset = "0x73E53B0", VA = "0x1873E65B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public float MFGKKACAEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x73E6360", Offset = "0x73E5160", VA = "0x1873E6360")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x73E66D0", Offset = "0x73E54D0", VA = "0x1873E66D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public Vector3 CPPOPDIFPCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x73E62E0", Offset = "0x73E50E0", VA = "0x1873E62E0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x73E6530", Offset = "0x73E5330", VA = "0x1873E6530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public float EODJBOIOLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x73E6430", Offset = "0x73E5230", VA = "0x1873E6430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public GEJEIADHCHJ LPEAAOGDLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x73E6690", Offset = "0x73E5490", VA = "0x1873E6690")]
		get
		{
			return default(GEJEIADHCHJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x73E64E0", Offset = "0x73E52E0", VA = "0x1873E64E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool DPEGJFFOJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x73E6110", Offset = "0x73E4F10", VA = "0x1873E6110")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x73E61A0", Offset = "0x73E4FA0", VA = "0x1873E61A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public IKKILFFDLKJ(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x73E0E30", Offset = "0x73DFC30", VA = "0x1873E0E30")]
	public static bool JCHCBNMNCNP(IKKILFFDLKJ IPHILEOFJLB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x73E6480", Offset = "0x73E5280", VA = "0x1873E6480")]
	public static bool HGMDHININLF(IKKILFFDLKJ HJGGLHBFMKO, IKKILFFDLKJ AGAPPIBJJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x73E6200", Offset = "0x73E5000", VA = "0x1873E6200", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(IKKILFFDLKJ LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x73E63E0", Offset = "0x73E51E0", VA = "0x1873E63E0")]
	public HFJMKOLAGKF GCLPDBFIFDO()
	{
		return default(HFJMKOLAGKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x73E6290", Offset = "0x73E5090", VA = "0x1873E6290")]
	public PNAODGFELJJ FAMENMKLGGJ()
	{
		return default(PNAODGFELJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x73E6150", Offset = "0x73E4F50", VA = "0x1873E6150")]
	private bool DNBBJEDBCCJ(GEJEIADHCHJ ACCBEMFKLOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x73E6090", Offset = "0x73E4E90", VA = "0x1873E6090")]
	public void ACHFDFHMKDB(GEJEIADHCHJ ACCBEMFKLOI, bool OHPJAPBNBPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct HFJMKOLAGKF : IEquatable<HFJMKOLAGKF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public ODHMICMEHJH PCOIIKCHBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(ODHMICMEHJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public IKKILFFDLKJ OEHDMDOEAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(IKKILFFDLKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public LOEIMIFIJEN NLDIOBKAKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x73E6050", Offset = "0x73E4E50", VA = "0x1873E6050")]
		get
		{
			return default(LOEIMIFIJEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public HFJMKOLAGKF(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x73E0E30", Offset = "0x73DFC30", VA = "0x1873E0E30")]
	public static bool JCHCBNMNCNP(HFJMKOLAGKF IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x73E5FC0", Offset = "0x73E4DC0", VA = "0x1873E5FC0", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(HFJMKOLAGKF LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DefaultMember("Item")]
public readonly struct PNAODGFELJJ : IEquatable<PNAODGFELJJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly PNAODGFELJJ NMEPCFHKJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public ODHMICMEHJH PCOIIKCHBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(ODHMICMEHJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public JGPOHMGAPPN HHEFOFLOCNG
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JGPOHMGAPPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	private PHOLKIHIPKK FMOMHMCAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x73DFCA0", Offset = "0x73DEAA0", VA = "0x1873DFCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	private PLKPCGBKHBF FNNKILGPPMM
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x73F2930", Offset = "0x73F1730", VA = "0x1873F2930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	private CNNPLFAMFGP DJPFCNDPIFN
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x73F2420", Offset = "0x73F1220", VA = "0x1873F2420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public IKKILFFDLKJ OEHDMDOEAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(IKKILFFDLKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public KFOIBPICOAF GNGDPKNOOBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x73F1CF0", Offset = "0x73F0AF0", VA = "0x1873F1CF0")]
		get
		{
			return default(KFOIBPICOAF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x73F2480", Offset = "0x73F1280", VA = "0x1873F2480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public IEnumerable<GGEMMGDIFCI> FADLOKEJGGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x73F25A0", Offset = "0x73F13A0", VA = "0x1873F25A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public GGEMMGDIFCI FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x73F2820", Offset = "0x73F1620", VA = "0x1873F2820")]
		get
		{
			return default(GGEMMGDIFCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public int IPKHGMJKDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x73F22F0", Offset = "0x73F10F0", VA = "0x1873F22F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public PNAODGFELJJ(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x73E0E30", Offset = "0x73DFC30", VA = "0x1873E0E30")]
	public static bool JCHCBNMNCNP(PNAODGFELJJ IPHILEOFJLB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x73E9860", Offset = "0x73E8660", VA = "0x1873E9860")]
	public static bool BHDCHHANDIG(PNAODGFELJJ HJGGLHBFMKO, PNAODGFELJJ AGAPPIBJJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x73F2260", Offset = "0x73F1060", VA = "0x1873F2260", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(PNAODGFELJJ LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x73F1E10", Offset = "0x73F0C10", VA = "0x1873F1E10")]
	public GGEMMGDIFCI BDHIDIGOKNL(float3? AKEODPFBHJE, [Optional] quaternion? CKABIAOPKPM, [Optional] Vector3? KFHMJCONBDC)
	{
		return default(GGEMMGDIFCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x73F2030", Offset = "0x73F0E30", VA = "0x1873F2030")]
	public GGEMMGDIFCI DCGPLIBNGEG(int KNCPCNBMDNF, float3? AKEODPFBHJE, [Optional] quaternion? CKABIAOPKPM, [Optional] Vector3? KFHMJCONBDC)
	{
		return default(GGEMMGDIFCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x73F2380", Offset = "0x73F1180", VA = "0x1873F2380")]
	public void HNFFLMKNOKC(int KNCPCNBMDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x73F2790", Offset = "0x73F1590", VA = "0x1873F2790")]
	public void NCEIDOKFHPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct GGEMMGDIFCI : IEquatable<GGEMMGDIFCI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public ODHMICMEHJH PCOIIKCHBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(ODHMICMEHJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public PNAODGFELJJ LIDKGLNEOML
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x73E5AE0", Offset = "0x73E48E0", VA = "0x1873E5AE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public float3 CIIGPNLPGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x73E5CE0", Offset = "0x73E4AE0", VA = "0x1873E5CE0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x73E5BB0", Offset = "0x73E49B0", VA = "0x1873E5BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public quaternion FDIJLBLBDEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x73E5A90", Offset = "0x73E4890", VA = "0x1873E5A90")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x73E5B60", Offset = "0x73E4960", VA = "0x1873E5B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public float3 BJFKMHPOGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x73E5C70", Offset = "0x73E4A70", VA = "0x1873E5C70")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x73E5C10", Offset = "0x73E4A10", VA = "0x1873E5C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public GFAEAKCPAMB OGKDIOFFLEE
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x73E59B0", Offset = "0x73E47B0", VA = "0x1873E59B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public GGEMMGDIFCI(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x73E5A00", Offset = "0x73E4800", VA = "0x1873E5A00", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(GGEMMGDIFCI LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x73E5CD0", Offset = "0x73E4AD0", VA = "0x1873E5CD0")]
	public void OFDAEHBGKAM(PNAODGFELJJ IPHILEOFJLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct GDNANJCKLDI : IEquatable<GDNANJCKLDI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public ODHMICMEHJH PCOIIKCHBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(ODHMICMEHJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private PHOLKIHIPKK FMOMHMCAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x73DFCA0", Offset = "0x73DEAA0", VA = "0x1873DFCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	private PLKPCGBKHBF FNNKILGPPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x73E5670", Offset = "0x73E4470", VA = "0x1873E5670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private LNAPHJMMJKI MHMMKCGLAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x73E5220", Offset = "0x73E4020", VA = "0x1873E5220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public bool ICCEKNIPLNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x73E5960", Offset = "0x73E4760", VA = "0x1873E5960")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x73E4D50", Offset = "0x73E3B50", VA = "0x1873E4D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public bool FGHGJJIMFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x73E57E0", Offset = "0x73E45E0", VA = "0x1873E57E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x73E5590", Offset = "0x73E4390", VA = "0x1873E5590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public float DEIKBBEJPAO
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x73E4DB0", Offset = "0x73E3BB0", VA = "0x1873E4DB0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x73E5790", Offset = "0x73E4590", VA = "0x1873E5790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool HHFBENIEEFL
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x73E4DF0", Offset = "0x73E3BF0", VA = "0x1873E4DF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public GDNANJCKLDI(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x73E5190", Offset = "0x73E3F90", VA = "0x1873E5190", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(GDNANJCKLDI LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x73E5280", Offset = "0x73E4080", VA = "0x1873E5280")]
	public void GPGGOFPBANF(int MPGLDFENCOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x73E4FE0", Offset = "0x73E3DE0", VA = "0x1873E4FE0")]
	public bool EICDAPCNJHE([Out] int MPGLDFENCOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x73E50F0", Offset = "0x73E3EF0", VA = "0x1873E50F0")]
	public void EOLBFJPMBCB(bool KAMMMMDLMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x73E4F90", Offset = "0x73E3D90", VA = "0x1873E4F90")]
	public bool DPLDJPINDIE(GENLDHLGIGG ACCBEMFKLOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x73E55F0", Offset = "0x73E43F0", VA = "0x1873E55F0")]
	public void NDCKPFKMLFL(GENLDHLGIGG ACCBEMFKLOI, bool OHPJAPBNBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x73E5450", Offset = "0x73E4250", VA = "0x1873E5450")]
	public void KKOAANPLPPN(float JOBHLBLOPFP, float JPPGNPBNCFN, float DJECEOGDIBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x73E4E40", Offset = "0x73E3C40", VA = "0x1873E4E40")]
	public void BPBNMDONNNF(float3 AHLMCOAMGNH, quaternion LBOPMFFCJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x73E5320", Offset = "0x73E4120", VA = "0x1873E5320")]
	public bool HHMBEOPPNJH([Out] float3 AHLMCOAMGNH, [Out] quaternion LBOPMFFCJNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x73E5830", Offset = "0x73E4630", VA = "0x1873E5830")]
	public bool OOOHCPJOEMI([Out] float KFNOHABMDML, [Out] float FEIDMJDFNPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x73E5700", Offset = "0x73E4500", VA = "0x1873E5700")]
	public void ONCELMMECIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct JGPOHMGAPPN : IEquatable<JGPOHMGAPPN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public PKPEDDDKDGE BADMGIIJNGK
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(PKPEDDDKDGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	private PHOLKIHIPKK FMOMHMCAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x73DFCA0", Offset = "0x73DEAA0", VA = "0x1873DFCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	private FOBFMNKCFNO MPNAOGFBMHA
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x73E9030", Offset = "0x73E7E30", VA = "0x1873E9030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public Vector3 CIIGPNLPGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x73E8EE0", Offset = "0x73E7CE0", VA = "0x1873E8EE0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x73E8C20", Offset = "0x73E7A20", VA = "0x1873E8C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public Quaternion FDIJLBLBDEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x73E8040", Offset = "0x73E6E40", VA = "0x1873E8040")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x73E8900", Offset = "0x73E7700", VA = "0x1873E8900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public Vector3 CLLCLIPNFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x73E8CF0", Offset = "0x73E7AF0", VA = "0x1873E8CF0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x73E83E0", Offset = "0x73E71E0", VA = "0x1873E83E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public Quaternion PIAIFHGNFML
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x73E76D0", Offset = "0x73E64D0", VA = "0x1873E76D0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x73E8830", Offset = "0x73E7630", VA = "0x1873E8830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public float DFEHGEIADFB
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x73E7C50", Offset = "0x73E6A50", VA = "0x1873E7C50")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x73E8690", Offset = "0x73E7490", VA = "0x1873E8690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public float CPHALJCMONF
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x73E7BB0", Offset = "0x73E69B0", VA = "0x1873E7BB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public Matrix4x4 KMGKFAPGPBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x73E7B70", Offset = "0x73E6970", VA = "0x1873E7B70")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public JGPOHMGAPPN(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x73E7DA0", Offset = "0x73E6BA0", VA = "0x1873E7DA0", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(JGPOHMGAPPN LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x73E8640", Offset = "0x73E7440", VA = "0x1873E8640")]
	public IDOAIIMFGBF IEMNKGPPDDN()
	{
		return default(IDOAIIMFGBF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x73E8180", Offset = "0x73E6F80", VA = "0x1873E8180")]
	public void GFGGCGKFEAN([Out] Matrix4x4 DBNIFHLIALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x73E84B0", Offset = "0x73E72B0", VA = "0x1873E84B0")]
	public void HOJPHNGNLPO([Out] Vector3 EHBMDEGPNHO, [Out] Quaternion DHKINOJNJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x73E8590", Offset = "0x73E7390", VA = "0x1873E8590")]
	public void HOJPHNGNLPO([Out] RigidTransform JLAOGHHEHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x73E89D0", Offset = "0x73E77D0", VA = "0x1873E89D0")]
	public void LODPBBMCIIC([In] Vector3 EHBMDEGPNHO, [In] Quaternion DHKINOJNJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x73E73A0", Offset = "0x73E61A0", VA = "0x1873E73A0")]
	public void AELKACPNJBP([Out] Vector3 EHBMDEGPNHO, [Out] Quaternion DHKINOJNJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x73E7480", Offset = "0x73E6280", VA = "0x1873E7480")]
	public void AELKACPNJBP([Out] RigidTransform JLAOGHHEHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x73E8800", Offset = "0x73E7600", VA = "0x1873E8800")]
	public UniformTRS KFCDJKAHFBL()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x73E8740", Offset = "0x73E7540", VA = "0x1873E8740")]
	public void KFCDJKAHFBL([Out] UniformTRS MJKOCFIPPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x73E91B0", Offset = "0x73E7FB0", VA = "0x1873E91B0")]
	public UniformTRS PAEMPHNIDOP()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x73E90F0", Offset = "0x73E7EF0", VA = "0x1873E90F0")]
	public void PAEMPHNIDOP([Out] UniformTRS JLAOGHHEHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x73E8AD0", Offset = "0x73E78D0", VA = "0x1873E8AD0")]
	public Vector3 LPKAHCLOLEJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x73E7600", Offset = "0x73E6400", VA = "0x1873E7600")]
	public void AMOKKIFGFAC([In] Vector3 IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x73E8290", Offset = "0x73E7090", VA = "0x1873E8290")]
	public Vector3 HGBEBLGMMCE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x73E7F70", Offset = "0x73E6D70", VA = "0x1873E7F70")]
	public void FLPAAABGKIP([In] Vector3 IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x73E7E30", Offset = "0x73E6C30", VA = "0x1873E7E30")]
	public Quaternion FJMNDDPMEBN()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x73E7810", Offset = "0x73E6610", VA = "0x1873E7810")]
	public void BGLGBHBGMFH([In] Quaternion IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x73E7A30", Offset = "0x73E6830", VA = "0x1873E7A30")]
	public Quaternion BLKPPADJFEM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x73E7530", Offset = "0x73E6330", VA = "0x1873E7530")]
	public void AFIMJAOJHDF([In] Quaternion IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x73E78E0", Offset = "0x73E66E0", VA = "0x1873E78E0")]
	public float BGMJHOJFLDA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x73E7CF0", Offset = "0x73E6AF0", VA = "0x1873E7CF0")]
	public void EOIEMGHGDIA(float IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x73E8E40", Offset = "0x73E7C40", VA = "0x1873E8E40")]
	public float OBLFGLKGNAA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x73E7980", Offset = "0x73E6780", VA = "0x1873E7980")]
	public void BHHJEOOOPEE(float IPHILEOFJLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct KEMCKKCMHAC : IEquatable<KEMCKKCMHAC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	private PHOLKIHIPKK FMOMHMCAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x73DFCA0", Offset = "0x73DEAA0", VA = "0x1873DFCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	private PLKPCGBKHBF FNNKILGPPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x73EA830", Offset = "0x73E9630", VA = "0x1873EA830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	private KEFGFKFONEL HFCFEAINKMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x73EA7D0", Offset = "0x73E95D0", VA = "0x1873EA7D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	public KEMCKKCMHAC(ODHMICMEHJH ADODGOLJGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x73E0230", Offset = "0x73DF030", VA = "0x1873E0230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x73EA600", Offset = "0x73E9400", VA = "0x1873EA600", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x73E00F0", Offset = "0x73DEEF0", VA = "0x1873E00F0", Slot = "4")]
	public bool Equals(KEMCKKCMHAC LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x73E09B0", Offset = "0x73DF7B0", VA = "0x1873E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x73EA690", Offset = "0x73E9490", VA = "0x1873EA690")]
	public void FLNIODGAPKB(string LCGMANEHHDK, LKIJHMINLPF CPAMHBBHFKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class KFEHAINBMFA
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private struct DNGLMOMNKKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Guid OGOMDMBFOMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public CCDLNOICPKP KOBNGFIDOHF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private struct CCDLNOICPKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int IPHILEOFJLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int DNJEKDGCDMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int JFLMHBKGFHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int DPMGICCMBCJ;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x73E1AA0", Offset = "0x73E08A0", VA = "0x1873E1AA0")]
		public bool ALGJEMEAFKG([Out] HLIKGPHNDCA LOJFIEKGPLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x73E1B30", Offset = "0x73E0930", VA = "0x1873E1B30")]
		public CCDLNOICPKP(HLIKGPHNDCA LOJFIEKGPLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x73EA8E0", Offset = "0x73E96E0", VA = "0x1873EA8E0")]
	public static Guid EIGHEGKDKLP(this HLIKGPHNDCA LOJFIEKGPLG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x73EA8C0", Offset = "0x73E96C0", VA = "0x1873EA8C0")]
	public static bool BGDIPENKGAA(this Guid OGOMDMBFOMG, [Out] HLIKGPHNDCA LOJFIEKGPLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal static class CKIONCNPAIF
{
	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x73E2750", Offset = "0x73E1550", VA = "0x1873E2750")]
	public static PLKPCGBKHBF FNNKILGPPMM(this ODHMICMEHJH MIFPCBFGGLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x73E27E0", Offset = "0x73E15E0", VA = "0x1873E27E0")]
	public static AMOENAFJHDD HPCKJPNFEMC(this ODHMICMEHJH MIFPCBFGGLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x73E28B0", Offset = "0x73E16B0", VA = "0x1873E28B0")]
	public static EntityManager IDMDBPOIAOM(this ODHMICMEHJH MIFPCBFGGLI)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x310D9D0", Offset = "0x310C7D0", VA = "0x18310D9D0")]
	internal static bool LHMIPILONJO<T>(this ODHMICMEHJH MIFPCBFGGLI, bool OHPJAPBNBPO) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x73E29B0", Offset = "0x73E17B0", VA = "0x1873E29B0")]
	public static bool NGFEKJBCNJB(this ODHMICMEHJH MIFPCBFGGLI, KEJCGFMDGGO AMBDMECJFHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x310D750", Offset = "0x310C550", VA = "0x18310D750")]
	public static bool JMJGPOFPINI<T>(this ODHMICMEHJH MIFPCBFGGLI) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x310D6A0", Offset = "0x310C4A0", VA = "0x18310D6A0")]
	public static bool IDEJBCCJGCC<T>(this ODHMICMEHJH MIFPCBFGGLI) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x310DAB0", Offset = "0x310C8B0", VA = "0x18310DAB0")]
	[CIMGOOFOJHI]
	public static T OHDGEKFJCMN<T>(this ODHMICMEHJH MIFPCBFGGLI) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x310B4E0", Offset = "0x310A2E0", VA = "0x18310B4E0")]
	[CIMGOOFOJHI]
	public static T ICAFGFNJFCB<T>(this ODHMICMEHJH MIFPCBFGGLI) where T : struct, IComponentData
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AIIEKAIMAJJ
{
	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DJEHCHDNKFP(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NNKGLOLMNCM(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task EBJMBAIKKCJ(JNCOEOPKELP JOOHPPHJKMI);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CGEEJGLGBGM(ODHMICMEHJH ADODGOLJGFP, [Out] Guid FDFKGMJMPMO);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid NAADHBABFAC(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ICIPDGMLFKD(ODHMICMEHJH ADODGOLJGFP, Guid FDFKGMJMPMO);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool IBIHBOLJFGP(ODHMICMEHJH ADODGOLJGFP, [Out] Guid INONPKMEIIH);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Guid BPDJIJEFKPP(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GLKOJDOJNMP(ODHMICMEHJH ADODGOLJGFP, Guid INONPKMEIIH);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CAAOMFGMCOM(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task NBFMGIBGOKC(ODHMICMEHJH DOOFGBAMPBE, ODHMICMEHJH IFAMCPHMKIP);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface POLEPHFPPNE
{
	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	Guid ICHFABHHNCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BEGOOILCLGP(NativeList<Guid> BGAMLGBOIGO, NativeList<Guid> NKEGLDNAHCJ, NativeList<FixedString64Bytes> PBPJGDGNKNJ);
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JGIIDBOOICE
{
	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFFPBDINHLK(List<ODHMICMEHJH> EIMPJKEJPBK);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MOFKBIBFFPD(List<ODHMICMEHJH> NMGJGIIGOKD);

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FKALLBOPOAO(ODHMICMEHJH HHAPNBLKCIB);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IENGECHDBED(ODHMICMEHJH HHAPNBLKCIB);

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FJBKEEOMFDB(ODHMICMEHJH HHAPNBLKCIB);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int POHGOJGMBNE(ODHMICMEHJH HHAPNBLKCIB);

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CNKCAHHBKED(ODHMICMEHJH HHAPNBLKCIB, int JOGIDIAAHEC);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ODHMICMEHJH IANPODEACJK(ODHMICMEHJH PJKOGDABCLO);

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int OAJCAHIGNGF(ODHMICMEHJH PJKOGDABCLO);

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LICEOAOKGFD(ODHMICMEHJH PJKOGDABCLO, int DHPHJBFBJON);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int IHIPMCFGJLL(ODHMICMEHJH PJKOGDABCLO);

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EBEPKNGPOIL(ODHMICMEHJH PJKOGDABCLO, int BMDOAKHEDKE);

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BJHINCFDAHJ(ODHMICMEHJH FEOCBDNIFLG);

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GOLPDLCPICF(ODHMICMEHJH ADODGOLJGFP, bool BINMDLEJLEF);

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JLOKLNMNAKB(ODHMICMEHJH[] CKLFLFGMLGN, bool BINMDLEJLEF);

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool KFHNBJPJMAP(ODHMICMEHJH HHAPNBLKCIB);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FGNEDPBIAKE(ODHMICMEHJH HHAPNBLKCIB, bool EDGBDNEAECL);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AAHOECGAEOL
{
	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HLIKGPHNDCA[] JIDBFLDDHOJ(string PPKJBGAOBJL, JNCOEOPKELP DMKNIKMJOOO, bool ABGOKFFKKAM = false);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GJOELHMCDKI(string IHNBODLLFGB, HLIKGPHNDCA[] AHLBJHAJDGN);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface FBNMMGJAKMI
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<ODHMICMEHJH, ODHMICMEHJH> GIMHLAKKPPK;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<ODHMICMEHJH, ODHMICMEHJH> PGPOOIJIHKG;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<ODHMICMEHJH, ODHMICMEHJH, ODHMICMEHJH> GPHNIOJOLEA;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<ODHMICMEHJH> GLBLBCNKPKH;

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BJBPHLBHGDB(ODHMICMEHJH ADODGOLJGFP, ODHMICMEHJH DBNKGFDNLJG);

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ODHMICMEHJH DNOEHMBNLFC(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FEBOOADAFMA KFGJGODAEOL(ODHMICMEHJH ADODGOLJGFP, Allocator GCNJHJPCIGN);

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ODHMICMEHJH LDHJBHPHJAB(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NIEJKPDKJLC(ODHMICMEHJH ADODGOLJGFP, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID);

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JFPGIEEIDME(ODHMICMEHJH ADODGOLJGFP, float MCOIPKFBCAL);

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool CKCNNNIIDNE(ODHMICMEHJH ADODGOLJGFP, [Out] ODHMICMEHJH IFAMCPHMKIP);

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool PHEINOCPKGO(ODHMICMEHJH ADODGOLJGFP, [Out] RigidTransform GHAOOKPKFGO);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool NEADGOGKCEI(ODHMICMEHJH ADODGOLJGFP, [Out] float AACFPPDNBPN);

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 DOEAAFAKEMD(BOHHOFLNGLL DDPEIHFGGKE);

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	quaternion HPMMLBNCCJM(BOHHOFLNGLL DDPEIHFGGKE);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public static class KIMJIKBHIBD
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface MFEEIFPBBIA
{
	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	object JIBPPKENFOD
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OHPBCOGJFOK(FEBOOADAFMA CKLFLFGMLGN);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface DIMHGMGMJDI
{
	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFFFEPNDBFI(ODHMICMEHJH JOOHPPHJKMI, ANIPKKMJKKG DFHAIKHKAKA);

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FOEEHBMDPBB(ANIPKKMJKKG DFHAIKHKAKA);

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HAOHHIPHFAD(ODHMICMEHJH ADODGOLJGFP, [Out] ANIPKKMJKKG MKADFPIGDLB);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct DHKCMMPCEOK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly string PPKJBGAOBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly T KBHDDKCAINE;

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x60FF400", Offset = "0x60FE200", VA = "0x1860FF400")]
	public DHKCMMPCEOK(T KBHDDKCAINE, [Optional][CallerMemberName] string PPKJBGAOBJL)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public static readonly DHKCMMPCEOK<int> CBLMOGAPEDO;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly DHKCMMPCEOK<int> GLODBBIJKNM;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public static readonly DHKCMMPCEOK<int> AHILICMLGOK;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum EJHJFPIBLMA
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class JLELILBPGOH
{
	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x1062F10", Offset = "0x1061D10", VA = "0x181062F10")]
	public static bool GHPABINPJPM(this EJHJFPIBLMA DKNLFDPIIII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x13FDA50", Offset = "0x13FC850", VA = "0x1813FDA50")]
	public static bool DBMPFBGOIBI(this EJHJFPIBLMA DKNLFDPIIII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x2B419B0", Offset = "0x2B407B0", VA = "0x182B419B0")]
	public static bool JOCGGOCNEJL(this EJHJFPIBLMA DKNLFDPIIII)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface DFKNBFBBLAC
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public enum EKEJMKJDIMA
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		Unloaded,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		Loading,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		Loaded,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public enum CFKDMMKBONJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	EKEJMKJDIMA HLFNJOOCPKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	bool JBGEOLCJBOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	bool HFFFEGIENAA
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	CFKDMMKBONJ NKHADMIEGCP
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EEENFOONGMO();
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[ServiceLifetime(Lifetime.Application)]
public interface IOEFCJJFBBD
{
	[Cpp2IlInjected.Token(Token = "0x17000181")]
	EJHJFPIBLMA PKCODLGJGBK
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	EJHJFPIBLMA KPIDJMMGJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	EJHJFPIBLMA DFCGIAPCPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	EJHJFPIBLMA HNEOLFGNEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	EJHJFPIBLMA PAGMNPJJEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	EJHJFPIBLMA CPIENIPIPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	EJHJFPIBLMA BCJMDGFLBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	EJHJFPIBLMA DAAGBIHJJHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	EJHJFPIBLMA KKJFBDKDJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	EJHJFPIBLMA IOHAJMBFHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	EJHJFPIBLMA PHBFGJKPKDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	EJHJFPIBLMA NKJNGIGDHEN
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	EJHJFPIBLMA BCGCGJAEJMK
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	EJHJFPIBLMA NNANIPKDIKG
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	EJHJFPIBLMA GBAEJPALFJP
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	EJHJFPIBLMA PDEJDOFEDGM
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	EJHJFPIBLMA DCOCIDIOHEB
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int ANFJBBFMPMK(DHKCMMPCEOK<int> LHCHLNOABPH);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JDCLPPHDFCC
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event FEBIFDEGEEP.KFPIFAPKEAP BNBACLCPHIP;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ODHMICMEHJH HGPGJAIKILF(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CJOBAECPBFF(List<ODHMICMEHJH> NMGJGIIGOKD);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GFAEAKCPAMB PBANFJCIIJH(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FADADIIFLHB(IEnumerable<ODHMICMEHJH> DMLDIHCGALF);

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GFAEAKCPAMB CAFECMNKOCE(ODHMICMEHJH IFAMCPHMKIP, ODHMICMEHJH BKEPLGJNEJH, bool EEOPNNGFLAM, ODHMICMEHJH OBIPBFFAILK);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ODHMICMEHJH PIDHLJFJIOA(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ODEJGNHFANL(ODHMICMEHJH ADODGOLJGFP, ODHMICMEHJH IFAMCPHMKIP, bool FDDKCBOPFEO = false);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool NIKLMIEPEPE(ODHMICMEHJH ADODGOLJGFP, ODHMICMEHJH IFAMCPHMKIP);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool LMOHLHNBLJI(ODHMICMEHJH CCMPNCMDAAD, ODHMICMEHJH IMMHBHMHLCO);

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int OEGIMDNLDLC(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	FEBOOADAFMA LBAKOGLBBJK(ODHMICMEHJH FEOCBDNIFLG);

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<ODHMICMEHJH> AJIPOIACMJB(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool HIFDPFDBLDO(ODHMICMEHJH ADODGOLJGFP, ODHMICMEHJH CAAENHNCIDF);

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IEnumerable<ODHMICMEHJH> KJNBHPICIIN(ODHMICMEHJH ADODGOLJGFP, bool HHGJBHHOKKE = false);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool CDHBLACNIBG(ODHMICMEHJH ADODGOLJGFP, ODHMICMEHJH JBFBAHDHLKA);

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "17")]
	ODHMICMEHJH OLEJHJDGEPF(ODHMICMEHJH OBIPBFFAILK, ODHMICMEHJH KALIECIBHHC);

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool EFAPHGLMJGG(ODHMICMEHJH OBIPBFFAILK, ODHMICMEHJH KALIECIBHHC, [Out] ODHMICMEHJH JFDDJKKKFLL);

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "19")]
	ODHMICMEHJH AJDLIFKMGOC(ODHMICMEHJH[] CKLFLFGMLGN);
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public static class OGGNGKBBGOE
{
	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x73EF880", Offset = "0x73EE680", VA = "0x1873EF880")]
	public static List<ODHMICMEHJH> CJOBAECPBFF(this JDCLPPHDFCC ANPHJHHNLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x73EF980", Offset = "0x73EE780", VA = "0x1873EF980")]
	public static bool NKAJLEECCPJ(this JDCLPPHDFCC ANPHJHHNLJF, ODHMICMEHJH ADODGOLJGFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface FNPKDENMMNK
{
	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GADINOAACEO KKBJOFGAFCE(ODHMICMEHJH HHAPNBLKCIB);

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJKKKMBIPAH(ODHMICMEHJH HHAPNBLKCIB, GADINOAACEO DGMLNFIALIP);

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FCHJOFJEODL(ODHMICMEHJH HHAPNBLKCIB);

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CJOIBHEHAAM(ODHMICMEHJH HHAPNBLKCIB, bool IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string[] BJNCKDHCPGJ(ODHMICMEHJH HHAPNBLKCIB);

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GIJLJELFNEI(ODHMICMEHJH HHAPNBLKCIB, IEnumerable<string> LGAJBJOLBKK);

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string[] NJDOPCDJMNI(ODHMICMEHJH HHAPNBLKCIB);

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MIFLJJLLIAP(ODHMICMEHJH HHAPNBLKCIB, IEnumerable<string> LGAJBJOLBKK);

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	string[] LHIAFNHEGON(ODHMICMEHJH HHAPNBLKCIB);

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PKNABEOBKBD(ODHMICMEHJH HHAPNBLKCIB, IEnumerable<string> LGAJBJOLBKK);

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string[] PGBOFACDMJH(ODHMICMEHJH HHAPNBLKCIB);

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JLBPDOPBNOE(ODHMICMEHJH HHAPNBLKCIB, IEnumerable<string> LGAJBJOLBKK);

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MDLMHKLPOAN(ODHMICMEHJH HHAPNBLKCIB, ODHMICMEHJH CJJBIEHOBCD);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface FGGPAEHHFJE
{
	[Cpp2IlInjected.Token(Token = "0x17000192")]
	bool CEKPFHEBCAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	bool IMBAJGLFFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	bool BIDALNLPCHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LCJGIDNOGJF
{
	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OCHKDNKBENJ([In] float3 JBEADJDOHMN, [In] float3 GGAAGAFEPHJ, float HKMCFNGLEFP, [Out] PGNEPMPMMDB PAALJHKBEEB, [Out] ODHMICMEHJH MPFNEAFMDIA);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int CBFPMBEOHJD([In] float3 JBEADJDOHMN, float HCPBBIGLAFG, List<ODHMICMEHJH> CKLFLFGMLGN);

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int OLHPPAEELAA(Plane[] JCCKIMHKFIA, float3 JBEADJDOHMN, float3 OKNPOFKOCLA, quaternion CKABIAOPKPM, List<ODHMICMEHJH> CKLFLFGMLGN);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GEPBGEMIGAN
{
	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCHKDNKBENJ([In] NativeArray<Entity> AIJKCNMCOKI, [In] float3 JBEADJDOHMN, [In] float3 GGAAGAFEPHJ, [In] NativeArray<PGNEPMPMMDB> IDGIHLCJIIP);

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> CBFPMBEOHJD([In] NativeArray<Entity> AIJKCNMCOKI, [In] float3 JBEADJDOHMN, float HCPBBIGLAFG);

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> OLHPPAEELAA([In] NativeArray<Entity> AIJKCNMCOKI, [In] NativeArray<float4> DCGEMOGEKNL);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct GGJKNCEHGGB : PLHKHJEHJBK, IEquatable<GGJKNCEHGGB>
{
	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public int OFCLDJHOLLK
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xC71390", Offset = "0xC70190", VA = "0x180C71390", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0xFBB960", Offset = "0xFBA760", VA = "0x180FBB960", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	public int CKCKCAOJJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x2B506C0", Offset = "0x2B4F4C0", VA = "0x182B506C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x65B1030", Offset = "0x65AFE30", VA = "0x1865B1030", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x73E5D40", Offset = "0x73E4B40", VA = "0x1873E5D40", Slot = "8")]
	public bool Equals(GGJKNCEHGGB LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x73E5D90", Offset = "0x73E4B90", VA = "0x1873E5D90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct PGNEPMPMMDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float MOMMLAAEHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public float3 FOPIBLDPFFK;
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KOBEKIBIAAA
{
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PHOLKIHIPKK
{
	[Cpp2IlInjected.Token(Token = "0x17000197")]
	PLKPCGBKHBF FNNKILGPPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	NKALHBHGBLN PILFKAFCCEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<FEBOOADAFMA, NativeArray<NJNFOMGPIJM>> DHMHPOGNBKO;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<FEBOOADAFMA> EGCPEEPFOMB;

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DCDDLCJJDIG DCEEKKHGNNO(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NJNFOMGPIJM DCIIBODNPIM(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EHDMJEMLBPD(HLIKGPHNDCA LOJFIEKGPLG, HILEJELFOGB DDKBCACPHPK);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KNOFONHMNEE(HLIKGPHNDCA[] AHLBJHAJDGN, GameObject IHNPMPCJPIK);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JNCOEOPKELP HMNMNNCNPAL(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KINODOOIFMN(ODHMICMEHJH ADODGOLJGFP, [Out] Transform KAEMFHJNGPI);

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool KPEJMDCNOPH(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KFDPAOGNFPB(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ODHMICMEHJH JLGFKLNLFJN(HLIKGPHNDCA LOJFIEKGPLG);

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool EJDNEECCJGN(HLIKGPHNDCA LOJFIEKGPLG, [Out] ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "16")]
	HLIKGPHNDCA LMHLPAKGJBL(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "17")]
	FEBOOADAFMA JLGFKLNLFJN(NativeArray<HLIKGPHNDCA> LOJFIEKGPLG, Allocator GCNJHJPCIGN);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "18")]
	FEBOOADAFMA FFKCNOKNNIH(NJNFOMGPIJM GFOODEKJMLI, int BMGBDLLODJK, Allocator GCNJHJPCIGN);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "19")]
	FEBOOADAFMA OPPNOOIGBBB(NativeArray<HLIKGPHNDCA> LOJFIEKGPLG, NativeArray<AHHLMIECCJB> MEGPOPIOKLO, Allocator GCNJHJPCIGN);

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "20")]
	HLIKGPHNDCA[] JIDBFLDDHOJ(string IHNBODLLFGB, JNCOEOPKELP DMKNIKMJOOO, bool ABGOKFFKKAM);

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GJOELHMCDKI(string IHNBODLLFGB, HLIKGPHNDCA[] AHLBJHAJDGN);

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "22")]
	JNCOEOPKELP JFDAHOIGOOO(NJNFOMGPIJM GFOODEKJMLI, bool LFPCGELFPJN);

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "23")]
	JNCOEOPKELP JFDAHOIGOOO(NJNFOMGPIJM GFOODEKJMLI);

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	JNCOEOPKELP MLAJHGHINFM(NJNFOMGPIJM GFOODEKJMLI);

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	JNCOEOPKELP OIILICAEFPD(NJNFOMGPIJM GFOODEKJMLI);

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	JNCOEOPKELP FGBDBACMEFN(HLIKGPHNDCA LOJFIEKGPLG, NJNFOMGPIJM GFOODEKJMLI);

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	PLCHNMHOOON FNICFPBMNPE();

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	PNAODGFELJJ HIAHMGNEBIP();

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	HFJMKOLAGKF EEDMGNFKIKL(LOEIMIFIJEN OFEDGDMMCAO);

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void EALPOFJKPGM(FEBOOADAFMA CKLFLFGMLGN);

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void MJMAPJMIAED(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void HAGGIEGMHJM(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void EALPOFJKPGM(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void HCCKAKHGDPN(ODHMICMEHJH CKLFLFGMLGN);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool EJKMFKLLGAO(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "36")]
	FEBOOADAFMA KNLKGPGLODI(FEBOOADAFMA HNOPMDNKKMF, Allocator GCNJHJPCIGN);

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool DMOEJHJGHMI(ODHMICMEHJH ADODGOLJGFP);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class NJABCOEEEOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x73ED980", Offset = "0x73EC780", VA = "0x1873ED980")]
	public static void KFDPAOGNFPB(this PHOLKIHIPKK CPAMHBBHFKC, HILEJELFOGB DDKBCACPHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x73ED950", Offset = "0x73EC750", VA = "0x1873ED950")]
	public static JNCOEOPKELP KPJEDOIFDEL(this PHOLKIHIPKK CPAMHBBHFKC, LocalId ADODGOLJGFP)
	{
		return default(JNCOEOPKELP);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x73EDA00", Offset = "0x73EC800", VA = "0x1873EDA00")]
	public static JNCOEOPKELP KPJEDOIFDEL(this PHOLKIHIPKK CPAMHBBHFKC, HLIKGPHNDCA LOJFIEKGPLG)
	{
		return default(JNCOEOPKELP);
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x73ED950", Offset = "0x73EC750", VA = "0x1873ED950")]
	public static ODHMICMEHJH JLGFKLNLFJN(this PHOLKIHIPKK CPAMHBBHFKC, LocalId ADODGOLJGFP)
	{
		return default(ODHMICMEHJH);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x73EDA60", Offset = "0x73EC860", VA = "0x1873EDA60")]
	public static HLIKGPHNDCA LMHLPAKGJBL(this PHOLKIHIPKK CPAMHBBHFKC, LocalId ADODGOLJGFP)
	{
		return default(HLIKGPHNDCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x73ED6E0", Offset = "0x73EC4E0", VA = "0x1873ED6E0")]
	public static bool DMOEJHJGHMI(this PHOLKIHIPKK CPAMHBBHFKC, HLIKGPHNDCA LOJFIEKGPLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x73EDCD0", Offset = "0x73ECAD0", VA = "0x1873EDCD0")]
	public static PLCHNMHOOON NKNCIFIBIGE(this PHOLKIHIPKK CPAMHBBHFKC, RigidTransform MJKOCFIPPAP)
	{
		return default(PLCHNMHOOON);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x73EDBD0", Offset = "0x73EC9D0", VA = "0x1873EDBD0")]
	public static HFJMKOLAGKF NHMAHEHIBIL(this PHOLKIHIPKK CPAMHBBHFKC, LOEIMIFIJEN NEIPKGMCBIF, RigidTransform MJKOCFIPPAP)
	{
		return default(HFJMKOLAGKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x73EDAE0", Offset = "0x73EC8E0", VA = "0x1873EDAE0")]
	public static PNAODGFELJJ MKADEGNIBDP(this PHOLKIHIPKK CPAMHBBHFKC, RigidTransform MJKOCFIPPAP)
	{
		return default(PNAODGFELJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x73ED750", Offset = "0x73EC550", VA = "0x1873ED750")]
	private static void HEGNJLOLLNA(JNCOEOPKELP MJMDGKLHCDN, RigidTransform MJKOCFIPPAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface MEFNBOPECIN
{
	[Cpp2IlInjected.Token(Token = "0x17000199")]
	bool KOKDJABPLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	ODHMICMEHJH FNDPPCBBMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	JNCOEOPKELP DCBMBOMNMCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event ALIALHDHFBC JCFELEAILFC;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ODHMICMEHJH OLEJHJDGEPF(ODHMICMEHJH OBIPBFFAILK, ODHMICMEHJH KALIECIBHHC);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EFAPHGLMJGG(ODHMICMEHJH OBIPBFFAILK, ODHMICMEHJH KALIECIBHHC, [Out] ODHMICMEHJH JFDDJKKKFLL);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ADDPBHNOIFP();

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FHAEKBHNMEG();

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LMJKOLPBKIN(ODHMICMEHJH OBIPBFFAILK);

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool ADKHICABJLC(ODHMICMEHJH OBIPBFFAILK);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public delegate void ALIALHDHFBC(JNCOEOPKELP ENOFCNGKKAK, JNCOEOPKELP OBIJGOMAJKH);
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class NLNBLGCNLKH
{
	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x73EEE30", Offset = "0x73EDC30", VA = "0x1873EEE30")]
	public static bool OAOMFBMOBMI(this MEFNBOPECIN CKIOMIHLIHD, JNCOEOPKELP OBIPBFFAILK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x73EED50", Offset = "0x73EDB50", VA = "0x1873EED50")]
	public static bool LEBJBOBNACB(this MEFNBOPECIN CKIOMIHLIHD, ODHMICMEHJH OBIPBFFAILK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x73EECD0", Offset = "0x73EDAD0", VA = "0x1873EECD0")]
	public static bool EIHHGCKCLHC(this MEFNBOPECIN CKIOMIHLIHD, ODHMICMEHJH OBIPBFFAILK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NPPFBIIJHFO
{
	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CPALJNGOHJD(JNCOEOPKELP MJMDGKLHCDN, PMJLGJGNALL NCGEJMOHJLG, List<JNCOEOPKELP> MMBKIMKKEEE);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int JGBBEJCNOIG(JNCOEOPKELP MJMDGKLHCDN, PMJLGJGNALL NCGEJMOHJLG);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NMGIMHAECBO(JNCOEOPKELP MJMDGKLHCDN, List<JNCOEOPKELP> MMBKIMKKEEE);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IKKFBIBAJIP(JNCOEOPKELP MPGLDFENCOD, JNCOEOPKELP OBIPBFFAILK, PMJLGJGNALL NCGEJMOHJLG);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JNCOEOPKELP NKKHKBEJFHA(JNCOEOPKELP MPGLDFENCOD, int KNCPCNBMDNF, PMJLGJGNALL NCGEJMOHJLG);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PEFLDJCHJMP(JNCOEOPKELP MPGLDFENCOD, JNCOEOPKELP OBIPBFFAILK, PMJLGJGNALL NCGEJMOHJLG);

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MEBFANLCAED(JNCOEOPKELP MPGLDFENCOD, JNCOEOPKELP OBIPBFFAILK, PMJLGJGNALL NCGEJMOHJLG);

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OPJJEPKNECM(JNCOEOPKELP MPGLDFENCOD, PMJLGJGNALL NCGEJMOHJLG);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NOMBPAAGLAC(JNCOEOPKELP MPGLDFENCOD, JNCOEOPKELP OBIPBFFAILK, PMJLGJGNALL NCGEJMOHJLG);

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OPIOMGNDIBN(Entity MPGLDFENCOD, Entity OBIPBFFAILK, PMJLGJGNALL NCGEJMOHJLG);

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FDOAAKPBINL(Entity MPGLDFENCOD, PMJLGJGNALL NCGEJMOHJLG);

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool MCPLDDEBCIL(JNCOEOPKELP OBIPBFFAILK, PMJLGJGNALL NCGEJMOHJLG);
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ODEIMFCPPLA
{
	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OLAOOKLICDK(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool INMCHIEELOI(ODHMICMEHJH ADODGOLJGFP, Transform KAEMFHJNGPI);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DLJKKJKCGMB
{
	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOJKGCFDJNE(ODHMICMEHJH OBIPBFFAILK, ODHMICMEHJH KAENJJCPEMG);

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CMHHPINNKML(ODHMICMEHJH OBIPBFFAILK, ODHMICMEHJH NEDFFIIHGDN);

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MDGBDLBEFMO(ODHMICMEHJH OBIPBFFAILK, [Out] ODHMICMEHJH FPEABOOPLKD);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface EPKMMGDJELD
{
	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FAAPPEOILNE(ODHMICMEHJH FEOCBDNIFLG, bool IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JLCOCPLIGBF(ODHMICMEHJH FEOCBDNIFLG, bool IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MPJLFMJEJFO(ODHMICMEHJH FEOCBDNIFLG, int IPHILEOFJLB);
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface CNNPLFAMFGP
{
	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ODHMICMEHJH> NFJDFNHKLNG(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ODHMICMEHJH KKOOJOMHGKK(ODHMICMEHJH ADODGOLJGFP, int KNCPCNBMDNF);

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int FAINNCHONJM(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KFOIBPICOAF APEINEIHGPP(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JLJNAPGFAFC(ODHMICMEHJH ADODGOLJGFP, KFOIBPICOAF KODPGCABALO);

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ODHMICMEHJH NCKOLJGBBAA(ODHMICMEHJH ADODGOLJGFP, [Optional] float3? AKEODPFBHJE, [Optional] quaternion? CKABIAOPKPM, [Optional] float3? KFHMJCONBDC);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ODHMICMEHJH MDPHMNAFPGO(ODHMICMEHJH ADODGOLJGFP, int KNCPCNBMDNF, [Optional] float3? AKEODPFBHJE, [Optional] quaternion? CKABIAOPKPM, [Optional] float3? KFHMJCONBDC);

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BPDLKGOMANP(ODHMICMEHJH ADODGOLJGFP, int KNCPCNBMDNF);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NOLDHOBPFHM(ODHMICMEHJH ADODGOLJGFP);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PBBIECAKAED
{
	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCJAJLPMKLL();

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HFEIJJHDDKH();

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ABBAOJKGFCD();

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PCEIFOFKBOP();

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JDJNFPOKEKO();

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FDKIKOCKDAG();

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HEPFPDLECOA();

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LGOEGLFLAEI();

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KBOGFIGGAOL();

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BNLDCDIHDNF();

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PHPGABMLNLF();

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KBFGFODBFEN();

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KLOHJCALILB();
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface LNAPHJMMJKI
{
	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EICDAPCNJHE(ODHMICMEHJH OBIPBFFAILK, [Out] int MPGLDFENCOD);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GPGGOFPBANF(ODHMICMEHJH OBIPBFFAILK, int MPGLDFENCOD);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EOLBFJPMBCB(ODHMICMEHJH OBIPBFFAILK, bool KAMMMMDLMIB);

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KKOAANPLPPN(ODHMICMEHJH OBIPBFFAILK, float JOBHLBLOPFP, float JPPGNPBNCFN, float DJECEOGDIBF);

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OOOHCPJOEMI(ODHMICMEHJH ADODGOLJGFP, [Out] float JPPGNPBNCFN, [Out] float DJECEOGDIBF);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BPBNMDONNNF(ODHMICMEHJH OBIPBFFAILK, float3 AKEODPFBHJE, quaternion CKABIAOPKPM);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HHMBEOPPNJH(ODHMICMEHJH OBIPBFFAILK, [Out] float3 AKEODPFBHJE, [Out] quaternion CKABIAOPKPM);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ONCELMMECIL(ODHMICMEHJH OBIPBFFAILK);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FOBFMNKCFNO
{
	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGGDMAJEPAE(Entity DGNDJCBPFEH);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMOKKIFGFAC(Entity DGNDJCBPFEH, [In] float3 IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 LPKAHCLOLEJ(Entity DGNDJCBPFEH);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BGLGBHBGMFH(Entity DGNDJCBPFEH, [In] quaternion IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion FJMNDDPMEBN(Entity DGNDJCBPFEH);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MDMELNDIGBK(Entity DGNDJCBPFEH, [In] float3 AKEODPFBHJE, [In] quaternion CKABIAOPKPM);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HOJPHNGNLPO(Entity DGNDJCBPFEH, [Out] float3 AKEODPFBHJE, [Out] quaternion CKABIAOPKPM);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HOJPHNGNLPO(Entity DGNDJCBPFEH, [Out] RigidTransform CIFLHHLMPAM);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LODPBBMCIIC(Entity DGNDJCBPFEH, [In] float3 AKEODPFBHJE, [In] quaternion CKABIAOPKPM);

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AELKACPNJBP(Entity DGNDJCBPFEH, [Out] float3 AKEODPFBHJE, [Out] quaternion CKABIAOPKPM);

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AELKACPNJBP(Entity DGNDJCBPFEH, [Out] RigidTransform CIFLHHLMPAM);

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EOIEMGHGDIA(Entity DGNDJCBPFEH, float IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float BGMJHOJFLDA(Entity DGNDJCBPFEH);

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FLPAAABGKIP(Entity DGNDJCBPFEH, [In] float3 IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	float3 HGBEBLGMMCE(Entity DGNDJCBPFEH);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AFIMJAOJHDF(Entity DGNDJCBPFEH, [In] quaternion IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "16")]
	quaternion BLKPPADJFEM(Entity DGNDJCBPFEH);

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BHHJEOOOPEE(Entity DGNDJCBPFEH, float IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float OBLFGLKGNAA(Entity DGNDJCBPFEH);

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LFEFOIEGDCH(Entity DGNDJCBPFEH, [Out] float4x4 DBNIFHLIALC);

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LDEBBGMJMDP(Entity DGNDJCBPFEH, [In] float4x4 DBNIFHLIALC);

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FIEPGDKCMBJ(Entity DGNDJCBPFEH, [Out] float4x4 DBNIFHLIALC);

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool KINODOOIFMN(Entity DGNDJCBPFEH, [Out] Transform KAEMFHJNGPI);

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void KHMBPFGEHJN(Entity DGNDJCBPFEH);

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void ILNDLFFKLOA(Entity DGNDJCBPFEH, Entity NJOCGFOKJDP, Entity LBOOKOKCBHL);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class NPJGPCLNNPL
{
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JOJFIIODBIN
{
	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEMNJBNLABL(bool GDCAFGBKNFM);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface KEFGFKFONEL
{
	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFKPCLEOJJO(ODHMICMEHJH HHAPNBLKCIB, IEnumerable<string> LGAJBJOLBKK);

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JJJMHPIGFBJ(ODHMICMEHJH HHAPNBLKCIB, IEnumerable<string> LGAJBJOLBKK);

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FNFIDCPNDPG(ODHMICMEHJH HHAPNBLKCIB, params string[] LGAJBJOLBKK);

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IMEALFGFPCM(ODHMICMEHJH HHAPNBLKCIB, params string[] LGAJBJOLBKK);

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AIHOKJBPADD(ODHMICMEHJH HHAPNBLKCIB, params string[] LGAJBJOLBKK);

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NLDIMGJHONE(ODHMICMEHJH HHAPNBLKCIB, params string[] LGAJBJOLBKK);

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int BKPNJJGPBKL(ODHMICMEHJH HHAPNBLKCIB);

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int BOBHPDCDAJK(ODHMICMEHJH HHAPNBLKCIB);

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int NICPOLFBKKF(ODHMICMEHJH HHAPNBLKCIB);

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NKNDDDAOEIP(ODHMICMEHJH HHAPNBLKCIB, ICollection<string> AJNFBGDEAIP);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool DJMJFBNEOBG(ODHMICMEHJH HHAPNBLKCIB);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PKJAKAFBEHP(ODHMICMEHJH HHAPNBLKCIB, ICollection<string> AJNFBGDEAIP);

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool KAEDHCPGIBC(ODHMICMEHJH HHAPNBLKCIB, string LCGMANEHHDK);

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AFEIHPEMFCH(string LCGMANEHHDK, LKIJHMINLPF MGALIENNDCO);

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ODHMICMEHJH LPAKPGACLCL(string LCGMANEHHDK);

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NBHIIKGKPIA(string LCGMANEHHDK, LKIJHMINLPF MGALIENNDCO);

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FLNIODGAPKB(ODHMICMEHJH GNIDIMPCHLB, string LCGMANEHHDK, LKIJHMINLPF MGALIENNDCO);

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool PBNPKEDDPGP();

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void JBPPHLIKIIL(IEnumerable<string> LGAJBJOLBKK);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KDGHJFCLEJF
{
	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World HNNIEIJDBBH(string INMKHFLCDGL = "Main");

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World PLLGHMMNIPC(string INMKHFLCDGL = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World CCODNHCAIMM(string INMKHFLCDGL = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World GCLCEGCBANN(string INMKHFLCDGL = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AMOENAFJHDD
{
	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	World NEOHLOJDMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	World MPKBDBBPLLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	EntityManager IDMDBPOIAOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	bool FIMGNNJILII
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase LLPAHLJEPKO(Type OBDHBADPJNM);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class GJKBBCLOFKJ
{
	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x73E5DE0", Offset = "0x73E4BE0", VA = "0x1873E5DE0")]
	public static ComponentSystemBase JBFINEBPILI(this World FNFMGPKBOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x32B5720", Offset = "0x32B4520", VA = "0x1832B5720")]
	public static T LLPAHLJEPKO<T>(this AMOENAFJHDD MIPPEBJMALP) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface COGLLJGBDOH
{
	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JEBECLOJLEK(NativeListAsync<Entity> MDIHDCBEMLB);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFONJDBJFLD(DFAFMAKHMKI HKOCDDDJLDF);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OBGPOAMBONM(NativeListAsync<Entity> CLIKLEJJHHF, bool BHNACGAPBEO);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CEJIPNGHKCN();

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OKNENGFJANG(Entity DOJENPPADJD);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface BBJFCFMHBJH
{
	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MBLJEPPBKKE(Collider LOHANPKBMOF, [Out] BCJJDBKBEOO KGGOHBIHBLB);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface HNIGNHHFAAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider JGGDBKABLLM(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject IKIIHKDLDNK(ODHMICMEHJH OKBJHOFEFJB, GameObject MFDHKPDFMNP, Vector3 PFKOKOAMOAJ, Quaternion ACJIHPAJKOG);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EKOLKFEDCJD(GameObject LOHANPKBMOF);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider MIKDOPGFPAA<TCollider>(GameObject PIFGMJPLOAP) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OEMMCNPNGCH(Collider LOHANPKBMOF);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject GGGCLDIANJM<TCollider>(string PPKJBGAOBJL) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LNNBNEFDLBF MPFOFBFMHLL(ODHMICMEHJH JGJKLNAAJHI, ODHMICMEHJH FCLGADBELMH, LOEIMIFIJEN ADFCJIOCHKC, float3 MIPEHOJNDLP, quaternion PMKCACNGNHJ, float3 KBLPBKMHEGE);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool APKHHNCGNNH(ODHMICMEHJH ADODGOLJGFP, [Out] LNNBNEFDLBF LOHANPKBMOF);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LEGHENHKILH(ODHMICMEHJH ADODGOLJGFP, [Out] ODHMICMEHJH DOJENPPADJD);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public enum FJHDMEHDCNL
{
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface JIKIFDDGENG
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public struct PJPLNHNONLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int ADFCJIOCHKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public GameObject MFDHKPDFMNP;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMNOOIJBONM(ODHMICMEHJH ADODGOLJGFP, GLDFCNIMNAN LEMDPCBIAIC, bool GCJLLPACNKK, OFKIBJDIALG KENEIFBOANA);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILNCEEOOKPA(ODHMICMEHJH ADODGOLJGFP, GLDFCNIMNAN LEMDPCBIAIC, bool GCJLLPACNKK, bool MDEPEBMMEIL, bool EAPOHEAHKFJ);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ILBEHGLCKCF JAHOHEOAIFE(ODHMICMEHJH DOJENPPADJD, List<ODHMICMEHJH> IFOCGJEJLED);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LNNBNEFDLBF CPJFPNCMHFB(GameObject FMMGBEHOGOJ, GameObject MNFKPADDBGG);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JOIBOANONHH(GameObject FMMGBEHOGOJ, List<GameObject> POFABJDMGFG);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PFOFEIHJIEE(GameObject MNFKPADDBGG);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T MIKDOPGFPAA<T>(GameObject PIFGMJPLOAP) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OEMMCNPNGCH(Collider LOHANPKBMOF);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject EGDLINPAJOE<T>(string PPKJBGAOBJL) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool DMMAOFPOCGL(Collider LOHANPKBMOF, [Out] ODHMICMEHJH MPGLDFENCOD);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool NBAOPIEAIGC(ODHMICMEHJH ADODGOLJGFP, [Out] BCJJDBKBEOO KGGOHBIHBLB);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<FJHDMEHDCNL> BPILPGIKDDD(Allocator GCNJHJPCIGN = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] AILKFGHKMPN();

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int MELNNIDFOEH(GLDFCNIMNAN LEMDPCBIAIC);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	string ACHAPMKBNCD(GLDFCNIMNAN LEMDPCBIAIC);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KBIMGFIJKIF
{
	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOEKKHIFAME(ODHMICMEHJH ADODGOLJGFP, ODHMICMEHJH IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CFPEBBLKGPM(ODHMICMEHJH ADODGOLJGFP, ODHMICMEHJH IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int OEGIMDNLDLC(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ODHMICMEHJH MIKIBPHJIDH(ODHMICMEHJH ADODGOLJGFP, int KNCPCNBMDNF);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FEBOOADAFMA OKPEALCAHDF(ODHMICMEHJH ADODGOLJGFP, Allocator GCNJHJPCIGN = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KGJHFDNLOJC(ODHMICMEHJH ADODGOLJGFP, object HACFGBHNOCC, ODHMICMEHJH IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FCOPMMLJGNL(ODHMICMEHJH ADODGOLJGFP, object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool PAPFENFPHML(ODHMICMEHJH ADODGOLJGFP, [Out] ODHMICMEHJH IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GOBAJFGOJFC(ODHMICMEHJH ADODGOLJGFP, float3 IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool DKLPFBNKLCO(ODHMICMEHJH ADODGOLJGFP, [Out] float3 IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NFKPAOGLIMH(ODHMICMEHJH ADODGOLJGFP, float3 IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool HGKEEOHDEJH(ODHMICMEHJH ADODGOLJGFP, [Out] float3 IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HAFPDDDELNL(ODHMICMEHJH ADODGOLJGFP, (Quaternion rot, Vector3 moments) IEKPANIOKCJ);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool HJPKEBEJHFL(ODHMICMEHJH ADODGOLJGFP, [Out] quaternion DIGMAMODBCJ, [Out] float3 CBPOEAJALOK);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GFGLINJFLKN(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 JJCIJFPMKED(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 MPIFAPDKGBL(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KLJLOJIPBLC(ODHMICMEHJH ADODGOLJGFP, float3 IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void IIHPHHBMMDM(ODHMICMEHJH ADODGOLJGFP, float3 IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float MALACMOLPDB(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float AJIKPJKIHIF(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BBIDLKEGANG(ODHMICMEHJH ADODGOLJGFP, float IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IBDDMOBPAJO(ODHMICMEHJH ADODGOLJGFP, float IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode CDKJLCGAJHL(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LEPOEKPLAOP(ODHMICMEHJH ADODGOLJGFP, CollisionDetectionMode IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "25")]
	CDPBBJLFOGJ CDIOHPIKGIK(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GJEAOMDGDMK(ODHMICMEHJH ADODGOLJGFP, CDPBBJLFOGJ IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool DKPGDOGHNLO(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NBJLHIBJACO(ODHMICMEHJH ADODGOLJGFP, bool IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "29")]
	ODHMICMEHJH HGPGJAIKILF(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void IADPJODDCNB(ODHMICMEHJH ADODGOLJGFP, ODHMICMEHJH IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "31")]
	ODHMICMEHJH PIDHLJFJIOA(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void ODEJGNHFANL(ODHMICMEHJH ADODGOLJGFP, ODHMICMEHJH IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "33")]
	OAPFEGBJMCF NKPNHLLIBOH(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void DKPOJBOIFLJ(ODHMICMEHJH ADODGOLJGFP, OAPFEGBJMCF NOODLEOBFGB);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool NMFEBDFGEGI(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void KBAEJGFAPEB(ODHMICMEHJH ADODGOLJGFP, bool IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool GBCHPJGLMJN(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void MABFGEFDPDG(ODHMICMEHJH ADODGOLJGFP, bool IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints NKEGCLJJEMB(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void GNBMCAADLIM(ODHMICMEHJH ADODGOLJGFP, RigidbodyConstraints IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float KLKOLJNFJBA(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void JAKAJPGNOMN(ODHMICMEHJH ADODGOLJGFP, float IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float KJIKPEOMLOB(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void CBFAPPDPANI(ODHMICMEHJH ADODGOLJGFP, float IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool FILICADIPAG(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void HNAENEDIDCI(ODHMICMEHJH ADODGOLJGFP, bool IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool BADMCBOHMBF(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void CDBPAHPGEOD(ODHMICMEHJH ADODGOLJGFP, bool IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void JCJCPPAHJMA(ODHMICMEHJH ADODGOLJGFP, int IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "50")]
	OIIFFMGENDA EOJFJLPIJPI(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void LGJNMCMFJDL(ODHMICMEHJH ADODGOLJGFP, OIIFFMGENDA IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "52")]
	PEHCDIDIDFL LBJEMGJELEL(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void PCNPNCEJOOL(ODHMICMEHJH ADODGOLJGFP, PEHCDIDIDFL IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float NHACEAEAOGN(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void BNLHBIIGOGN(ODHMICMEHJH ADODGOLJGFP, float IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void PMKJCPKKKIN(ODHMICMEHJH ADODGOLJGFP, object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void PBLNAOLNEGP(ODHMICMEHJH ADODGOLJGFP, object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool PNKIKPDOJMN(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void NFFPCDHJMOD(ODHMICMEHJH ADODGOLJGFP, object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void DJBAKGBLMDC(ODHMICMEHJH ADODGOLJGFP, object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool GKAJOMFPAHN(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool HOFMCADMOBJ(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody CIDNMPCEAND(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void DIMDAFMOCAF(ODHMICMEHJH ADODGOLJGFP, Rigidbody IDAFMFPGOAC);

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void DMCOGFFPGPE(ODHMICMEHJH ADODGOLJGFP, object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void GNBBEKCJFMA(ODHMICMEHJH ADODGOLJGFP, object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool MPFEGINNEJE(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void NGHFOOBLHOP(ODHMICMEHJH ADODGOLJGFP, float3 PHFLICDNCII);

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void FGGKOJEDIGJ(ODHMICMEHJH ADODGOLJGFP, float3 APIEHLLLAEO);

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool KNKKPFPCJFC(ODHMICMEHJH ADODGOLJGFP, [Out] float3 PHFLICDNCII);

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool LJCFLFONNKJ(ODHMICMEHJH ADODGOLJGFP, [Out] float3 APIEHLLLAEO);

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool JMMCPDFELOG(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void DLHKNELCLFI(ODHMICMEHJH ADODGOLJGFP, object HACFGBHNOCC, bool AFBCKAHGIKH);

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void JMFHKEBOPMN(ODHMICMEHJH ADODGOLJGFP, bool NHNMGPIGNGC);

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void FMIJMEPIPHL(ODHMICMEHJH ADODGOLJGFP);

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool DGCKMGNHCHC(ODHMICMEHJH ADODGOLJGFP);
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface PPFCMIMPPPK
{
	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJPAHLECJDF(Entity NEBCKGEGDIP);

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BMFACPDOLGB(Entity NEBCKGEGDIP);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface BHEMNCJIDNN
{
	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNGCLJBECMG(ODHMICMEHJH OBIPBFFAILK, bool MJIMJNCKNCH);

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KIGGEJOAIDK(ODHMICMEHJH OBIPBFFAILK, int MLOEPLKKMAH);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public delegate void GELMGAAAIDC(BCNNNCBAKCN MHHMAEPHNCI);
[Cpp2IlInjected.Token(Token = "0x200009E")]
public readonly ref struct BCNNNCBAKCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly FEBOOADAFMA BPHLKHBHOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly NativeArray<byte> LCNMKIDANOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly NativeArray<byte> KDAODECDMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly KEJCGFMDGGO AMBDMECJFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly int OOFHEOHBJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly Type MJAJMLJJAFP;

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public FEBOOADAFMA NCDINPPGGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x4A36DE0", Offset = "0x4A35BE0", VA = "0x184A36DE0")]
		get
		{
			return default(FEBOOADAFMA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public int BNJCPJCFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x73E0BA0", Offset = "0x73DF9A0", VA = "0x1873E0BA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x73E0BC0", Offset = "0x73DF9C0", VA = "0x1873E0BC0")]
	public BCNNNCBAKCN(FEBOOADAFMA BPHLKHBHOOL, NativeArray<byte> LCNMKIDANOO, NativeArray<byte> KDAODECDMCG, KEJCGFMDGGO AMBDMECJFHI, int OOFHEOHBJPI, Type MJAJMLJJAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x3070100", Offset = "0x306EF00", VA = "0x183070100")]
	public NativeArray<T> GLDIIEMHBOO<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x3070140", Offset = "0x306EF40", VA = "0x183070140")]
	public NativeArray<T> ICFKBICEENB<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x3070010", Offset = "0x306EE10", VA = "0x183070010")]
	public (FEBOOADAFMA, NativeArray<T>, NativeArray<T>) ANFJBBFMPMK<T>() where T : struct
	{
		return default((FEBOOADAFMA, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x73E0B70", Offset = "0x73DF970", VA = "0x1873E0B70")]
	public JIDEKCFBIJM FPBJKGODLJI()
	{
		return default(JIDEKCFBIJM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface ECFHFAKIMGD
{
	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	string MDEECKCPKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	ECFHFAKIMGD FDCACIPKMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	IEnumerable<ECFHFAKIMGD> EMOCEEPAIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface BCBGGKGOEJO
{
	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	ECFHFAKIMGD IAGBKFHPHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	NativeArray<KEJCGFMDGGO> EFLFHCFLCGE
	{
		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PPGAHMHIDKH(KEJCGFMDGGO AMBDMECJFHI, [Out] ECFHFAKIMGD DGBJJAAHDHC);

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EHDMJEMLBPD(KEJCGFMDGGO AMBDMECJFHI, GELMGAAAIDC KKBILAKKKFF);

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HLGNNFLCMJP(KEJCGFMDGGO AMBDMECJFHI, GELMGAAAIDC KKBILAKKKFF);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface OIBHCDOHPPM
{
	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHDMJEMLBPD(KEJCGFMDGGO AMBDMECJFHI, GELMGAAAIDC KKBILAKKKFF);

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HLGNNFLCMJP(KEJCGFMDGGO AMBDMECJFHI, GELMGAAAIDC KKBILAKKKFF);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class BHHDFDNCOCA
{
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AELCFOEALJK
{
	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	NDMCJHPEEFG DGIFJCOJLAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OIPCCHMGIML(HLIKGPHNDCA LOJFIEKGPLG, KEJCGFMDGGO AMBDMECJFHI);

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GJPJAHJOKNM(HLIKGPHNDCA LOJFIEKGPLG, Span<KEJCGFMDGGO> ENPIDHGCEBL, bool AGBDGAAAHDO);

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CPICAANKKFE(NativeArray<HLIKGPHNDCA> AHLBJHAJDGN);
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class OPPCFCAOCEP
{
	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x73EFB60", Offset = "0x73EE960", VA = "0x1873EFB60")]
	public static void GJPJAHJOKNM(this AELCFOEALJK NJDIKEIFNFJ, HLIKGPHNDCA LOJFIEKGPLG, KEJCGFMDGGO AMBDMECJFHI, bool AGBDGAAAHDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public readonly ref struct JIDEKCFBIJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly BCNNNCBAKCN JOAPLPPIFPC;

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public FEBOOADAFMA NCDINPPGGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x4A36DE0", Offset = "0x4A35BE0", VA = "0x184A36DE0")]
		get
		{
			return default(FEBOOADAFMA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x73E95A0", Offset = "0x73E83A0", VA = "0x1873E95A0")]
	public JIDEKCFBIJM(BCNNNCBAKCN JOAPLPPIFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x73E9400", Offset = "0x73E8200", VA = "0x1873E9400")]
	public FEBOOADAFMA GLDIIEMHBOO()
	{
		return default(FEBOOADAFMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x73E94D0", Offset = "0x73E82D0", VA = "0x1873E94D0")]
	public FEBOOADAFMA ICFKBICEENB()
	{
		return default(FEBOOADAFMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x73E91E0", Offset = "0x73E7FE0", VA = "0x1873E91E0")]
	public (FEBOOADAFMA, FEBOOADAFMA, FEBOOADAFMA) ANFJBBFMPMK()
	{
		return default((FEBOOADAFMA, FEBOOADAFMA, FEBOOADAFMA));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class CECOJGPHHBB
{
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public readonly struct NDMCJHPEEFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly NativeBitArray OFDILHDGEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly NativeParallelHashMap<HLIKGPHNDCA, int> FCHOIJMJIAM;

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public bool IJHDOOBJGHE
	{
		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x73ED590", Offset = "0x73EC390", VA = "0x1873ED590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x4A36BA0", Offset = "0x4A359A0", VA = "0x184A36BA0")]
	public NDMCJHPEEFG(NativeBitArray OFDILHDGEGL, NativeParallelHashMap<HLIKGPHNDCA, int> FCHOIJMJIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x73ED5B0", Offset = "0x73EC3B0", VA = "0x1873ED5B0")]
	public bool OIPCCHMGIML(HLIKGPHNDCA LOJFIEKGPLG, KEJCGFMDGGO AMBDMECJFHI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GMHFBEBHIDF
{
	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	IIDEEAJADIF NLPDAPCFJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface OPBMJKMLKCL
{
	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MENCIGIFFDE(ODHMICMEHJH ADODGOLJGFP, ALJDIGJCPKP IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KLDPLFJBOPH ODJAFLHPDJO();
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BFBEPFHMAPD
{
	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PLINPMHMJOD(World FNFMGPKBOAC);

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPGDGGIAKEK(World FNFMGPKBOAC);

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase EHMOIDFHDIG(World FNFMGPKBOAC);

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LJEMOLEJMJP(World FNFMGPKBOAC);

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EJFJHNLPPEG(World FNFMGPKBOAC);

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HBLJNIJLLOH(World FNFMGPKBOAC);

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CENLLPEJCFJ(World FNFMGPKBOAC);

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> JKPMJLOGEON();
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface GLFBCBNIDJG
{
	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DAKHOMNEHIF(ODHMICMEHJH FEOCBDNIFLG, bool IPHILEOFJLB);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public readonly struct NCGKOJCMKPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly IEnumerable<CBHCFMFILCI> ANBIEBHOEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly IReadOnlyList<GameObject> MJAGJLGKAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly IReadOnlyList<int> COAKHHAPHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly IReadOnlyList<(HLIKGPHNDCA, HLIKGPHNDCA)> JCCHECKAKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly int ANPFJLNGDFE;

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public bool JJCPGCBCCEF
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x73ED4C0", Offset = "0x73EC2C0", VA = "0x1873ED4C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public int PPDFCAOFPBM
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xAB5DD0", Offset = "0xAB4BD0", VA = "0x180AB5DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public IEnumerable<GameObject> IJKNJNMLLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0xC534D0", Offset = "0xC522D0", VA = "0x180C534D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public IEnumerable<(HLIKGPHNDCA src, HLIKGPHNDCA dst)> EJDIKJGDGML
	{
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x73ED520", Offset = "0x73EC320", VA = "0x1873ED520")]
	public NCGKOJCMKPD(IEnumerable<CBHCFMFILCI> ANBIEBHOEKC, IReadOnlyList<GameObject> MJAGJLGKAOI, IReadOnlyList<int> COAKHHAPHNJ, IReadOnlyList<(HLIKGPHNDCA src, HLIKGPHNDCA dst)> JCCHECKAKDI, int ANPFJLNGDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x73ED140", Offset = "0x73EBF40", VA = "0x1873ED140")]
	public (GameObject, int)[] GJAPHEAIIMM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[ServiceLifetime(Lifetime.Application)]
public interface OIEJAJNLBDC
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public class JNPAHOPAIKF
	{
		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public ODHMICMEHJH LCIGPFKHHMP
		{
			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
			[CompilerGenerated]
			get
			{
				return default(ODHMICMEHJH);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0xBCE2E0", Offset = "0xBCD0E0", VA = "0x180BCE2E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public UniformTRS OJNKPEALCDO
		{
			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0x405DE40", Offset = "0x405CC40", VA = "0x18405DE40")]
			[CompilerGenerated]
			get
			{
				return default(UniformTRS);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(RVA = "0x73E9F40", Offset = "0x73E8D40", VA = "0x1873E9F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public bool CHNCOHHPEOM
		{
			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0xC2CA50", Offset = "0xC2B850", VA = "0x180C2CA50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0xC2CA70", Offset = "0xC2B870", VA = "0x180C2CA70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public HMEPNEAJNFI LCNCEBIEDBC
		{
			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0x8F4330", Offset = "0x8F3130", VA = "0x1808F4330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0x8F4410", Offset = "0x8F3210", VA = "0x1808F4410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public bool MDOJOOFFJGD
		{
			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0xADD5A0", Offset = "0xADC3A0", VA = "0x180ADD5A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0xAFFF00", Offset = "0xAFED00", VA = "0x180AFFF00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public InventionIdData MGFCNAEOOJB
		{
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x8F4230", Offset = "0x8F3030", VA = "0x1808F4230")]
			[CompilerGenerated]
			get
			{
				return default(InventionIdData);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0xCE4AD0", Offset = "0xCE38D0", VA = "0x180CE4AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public InventionInstanceIdData NINELNKCLEH
		{
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0xBE3520", Offset = "0xBE2320", VA = "0x180BE3520")]
			[CompilerGenerated]
			get
			{
				return default(InventionInstanceIdData);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0xED95C0", Offset = "0xED83C0", VA = "0x180ED95C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public bool IFIBGOJCMIE
		{
			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0xBE3540", Offset = "0xBE2340", VA = "0x180BE3540")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x116BCF0", Offset = "0x116AAF0", VA = "0x18116BCF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x73E9F50", Offset = "0x73E8D50", VA = "0x1873E9F50")]
		public JNPAHOPAIKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	bool LGBGODPIFEM
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	bool EKKJMBDKAFN
	{
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	DKLJIPFGKKM LIPHJBNEIHI
	{
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	APBEAAJMJDH IKJLCKLCFJP();

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	APBEAAJMJDH GIGOOEKEMNP(IEnumerable<ODHMICMEHJH> CKLFLFGMLGN, [In] UniformTRS EHHIGNDNPKM);

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OOPOOJAEKDA BBHMIAJAEBC(ByteString IOGLIDBEBON);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JLDEMHCNNDL FIOIGLGCDLH(ByteString IGPMBFACFOG, JNPAHOPAIKF KODPGCABALO);

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OINCABNJGOC();

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NCGKOJCMKPD OKJBDECPAFC(IEnumerable<CBHCFMFILCI> ANBIEBHOEKC);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class KKKFHPEBFBH
{
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[ServiceLifetime(Lifetime.Application)]
public interface PLIOPLFDELI
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action DJCBOCIGNIE;
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public struct AHHLMIECCJB : IEquatable<AHHLMIECCJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NJNFOMGPIJM GFOODEKJMLI;

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x73E0A60", Offset = "0x73DF860", VA = "0x1873E0A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x1ED9E60", Offset = "0x1ED8C60", VA = "0x181ED9E60", Slot = "4")]
	public bool Equals(AHHLMIECCJB LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x73E09D0", Offset = "0x73DF7D0", VA = "0x1873E09D0", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0xC71390", Offset = "0xC70190", VA = "0x180C71390", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BDGKFPHLIBG
{
	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	uint FPHLGMBACMG
	{
		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public enum OPKBIGKGDDI
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	End,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NHAGIDOIKIP
{
	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OMPHBCMLKDG(LDGPMJIFPNF EDLHCINOAKH, ReadOnlySpan<byte> KGDIEBJBNPG);

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPNGMGPGALA(uint JFLMHBKGFHK, ReadOnlySpan<byte> KGDIEBJBNPG);

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JMKDOOMKOIC(int BKJICCAIIDL);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MLCFFMDKMPM
{
	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LDGPMJIFPNF MHAEGOBIOKK(ReadOnlySpan<byte> KGDIEBJBNPG);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DICJOICNEGI
{
	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMCPIEJALIK(LDGPMJIFPNF FFOHLCGHDKA, ReadOnlySpan<byte> KGDIEBJBNPG);

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CEPHDDHJMBE(ReadOnlySpan<LDGPMJIFPNF> JHLKGBMLHLF);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public struct HFAAKAALCDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public LDGPMJIFPNF EDLHCINOAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public ReadOnlyMemory<byte> KGDIEBJBNPG;
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public struct LDGPMJIFPNF
{
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public static LDGPMJIFPNF DGLFJOBKBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public uint DEKOGMDJDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int IBKIBHEEBJA;

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0xBD9040", Offset = "0xBD7E40", VA = "0x180BD9040")]
	public LDGPMJIFPNF(uint DEKOGMDJDDJ, int IBKIBHEEBJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x73EAC30", Offset = "0x73E9A30", VA = "0x1873EAC30")]
	public static bool BHDCHHANDIG([In] LDGPMJIFPNF NMOPBJNEFKL, [In] LDGPMJIFPNF KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x73EAC50", Offset = "0x73E9A50", VA = "0x1873EAC50", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x73EAD00", Offset = "0x73E9B00", VA = "0x1873EAD00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x73EAD30", Offset = "0x73E9B30", VA = "0x1873EAD30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x73EAC20", Offset = "0x73E9A20", VA = "0x1873EAC20")]
	public void AHAOIMLDBFI([Out] uint DEKOGMDJDDJ, [Out] int IBKIBHEEBJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public struct CBHCFMFILCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public Guid OGOMDMBFOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public string IHNBODLLFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public Vector3 AKEODPFBHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public Quaternion CKABIAOPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public Vector3 KFHMJCONBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public int JBCLNEOOKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public Dictionary<string, object> KODPGCABALO;

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x73E17B0", Offset = "0x73E05B0", VA = "0x1873E17B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x73E1620", Offset = "0x73E0420", VA = "0x1873E1620")]
	private static string GMPDGKGKCFK(Dictionary<string, object> BJHMCNLIEAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public enum EBBOGDCEAEP
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	SubGraphReplace,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	RestoreCreationData,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	InventionPreview
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class APFLMKHOPKL
{
	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x73E0B50", Offset = "0x73DF950", VA = "0x1873E0B50")]
	public static bool GLOIEOBNOAI(this EBBOGDCEAEP OBDHBADPJNM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[Flags]
public enum BEIDGMAPDGI
{
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	WorldPhasesMaster = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	AdditivePhases = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public interface JLDEMHCNNDL : DKLJIPFGKKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	HMEPNEAJNFI LCNCEBIEDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJAAPHNJHEI();

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DEJBLBADNNM();
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public interface DKLJIPFGKKM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	IEnumerable<CBHCFMFILCI> PJCANIPLNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	NCGKOJCMKPD HOBIKOBHHKM
	{
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	EBBOGDCEAEP LPNEJLDPBGO
	{
		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	LocalId OAKCLNOCPEH
	{
		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	LJBOAHCHHOK KDKJOIGCGFC
	{
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JEMOGMDLBLA(BEIDGMAPDGI HJGLPFDEOCA);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public interface HMEPNEAJNFI
{
	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HEKKAEANKMK(Guid BKEPLGJNEJH, [Out] Guid COJIJIEDOKL);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface OOPOOJAEKDA : DKLJIPFGKKM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[Flags]
public enum LAMPBNHCBGI
{
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public interface APBEAAJMJDH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	LJBOAHCHHOK JBOGAHFLOBB
	{
		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString JMPJFBIBIBL();
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public enum DHAPFAFJOKK
{
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public struct OONKDIKODLL : ISystemStateComponentData, IComponentData, IEquatable<OONKDIKODLL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public float3 OAEJNGPMFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public float3 LAPHNACKGKI;

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x73EFAE0", Offset = "0x73EE8E0", VA = "0x1873EFAE0", Slot = "4")]
	public bool Equals(OONKDIKODLL LHMPMCLNOPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HCJPPPDKAKL
{
	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LNEOJFGDFEP(long IENGHPNDFFA);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBLPJDCLGDP(NativeParallelHashSet<long> KGBHONPJKHA);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CHIACFKFPNK(World FNFMGPKBOAC, NativeParallelHashMap<Guid, long> IIFNGJHFFND);

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GGGOIJAGADA(HLIKGPHNDCA LOJFIEKGPLG);

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GPJHIKMPGOE(HLIKGPHNDCA LOJFIEKGPLG, [Out] Guid MDABGLDBGGP, [Out] long IENGHPNDFFA);

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MHNJPJPMAJF(HLIKGPHNDCA LOJFIEKGPLG, Guid MDABGLDBGGP, long IENGHPNDFFA);

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LGBLBHCANPA(Guid MDABGLDBGGP);

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool PPEDADMICDP(Guid MDABGLDBGGP, [Out] int MJGKBKKGBHP, [Out] int HDOIJPADHFI);

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GFMLFEOJPCB(Guid MDABGLDBGGP, int MJGKBKKGBHP, int HDOIJPADHFI);

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DGPMLOEAGNL(Guid MDABGLDBGGP);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class PINIBFHHCLA
{
	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public PINIBFHHCLA()
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
