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
	public class LogRegistrationIndex : HLBHPGBFEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9B90", Offset = "0x6EF8F90", VA = "0x186EF9B90", Slot = "4")]
		public override void MHJHNBDIMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PKHFKDCPGDE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6EFD870", Offset = "0x6EFCC70", VA = "0x186EFD870")]
	public static void OBOMMEAEIHA(this Rigidbody MGNFHHHINDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6EFD9F0", Offset = "0x6EFCDF0", VA = "0x186EFD9F0")]
	public static void OBOMMEAEIHA(this Rigidbody MGNFHHHINDP, Vector3 NFIILPKAILH, Quaternion MOHECIHCDGC, Vector3 CIDBDHCNOHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct BLJMICDPKDA : IReadOnlyList<AGLPGLMEACF>, IEnumerable<AGLPGLMEACF>, IEnumerable, IReadOnlyCollection<AGLPGLMEACF>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct FCBKPFOJNCF : IEnumerator<AGLPGLMEACF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly LKGAMHHAMKI BNOCOAKANOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator ADGILLNPFAM;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AGLPGLMEACF GKCMOMIKDKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6EF2080", Offset = "0x6EF1480", VA = "0x186EF2080", Slot = "4")]
			get
			{
				return default(AGLPGLMEACF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6EF2000", Offset = "0x6EF1400", VA = "0x186EF2000", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x45857F0", Offset = "0x4584BF0", VA = "0x1845857F0")]
		public FCBKPFOJNCF(LKGAMHHAMKI BNOCOAKANOI, NativeArray<LocalId>.Enumerator ADGILLNPFAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6EF1F40", Offset = "0x6EF1340", VA = "0x186EF1F40", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6EF1F80", Offset = "0x6EF1380", VA = "0x186EF1F80", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF1FC0", Offset = "0x6EF13C0", VA = "0x186EF1FC0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly LKGAMHHAMKI BNOCOAKANOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> CCBEIEEDJFG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public AGLPGLMEACF MGACFGHHFEH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6EEF2A0", Offset = "0x6EEE6A0", VA = "0x186EEF2A0", Slot = "4")]
		get
		{
			return default(AGLPGLMEACF);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEC60", Offset = "0x6EEE060", VA = "0x186EEEC60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int OHMPCNLJFOC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8A81A0", Offset = "0x8A75A0", VA = "0x1808A81A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LKGAMHHAMKI FBMKFDLJDAK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int AEFILNEPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8A81A0", Offset = "0x8A75A0", VA = "0x1808A81A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool JDLMGHLFGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6EEECB0", Offset = "0x6EEE0B0", VA = "0x186EEECB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> BJGHNBHBHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x27DDDF0", Offset = "0x27DD1F0", VA = "0x1827DDDF0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> HIDOIMIILII
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6EEECF0", Offset = "0x6EEE0F0", VA = "0x186EEECF0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6EEF210", Offset = "0x6EEE610", VA = "0x186EEF210")]
	public BLJMICDPKDA(int BIMLHBENMHO, LKGAMHHAMKI BNOCOAKANOI, Allocator HPLNAKONHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x45855B0", Offset = "0x45849B0", VA = "0x1845855B0")]
	public BLJMICDPKDA(LKGAMHHAMKI BNOCOAKANOI, NativeArray<LocalId> CCBEIEEDJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6EEF1A0", Offset = "0x6EEE5A0", VA = "0x186EEF1A0")]
	internal BLJMICDPKDA(LKGAMHHAMKI BNOCOAKANOI, NativeArray<Entity> IKCCHOOOHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6EEF100", Offset = "0x6EEE500", VA = "0x186EEF100")]
	public BLJMICDPKDA(LKGAMHHAMKI BNOCOAKANOI, int LOKMFEIHLAN, Allocator HPLNAKONHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6EEF050", Offset = "0x6EEE450", VA = "0x186EEF050")]
	public BLJMICDPKDA(BLJMICDPKDA MOIONEBMHGD, Allocator HPLNAKONHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEDE0", Offset = "0x6EEE1E0", VA = "0x186EEEDE0")]
	public BLJMICDPKDA OOIHJHLMILI(Allocator HPLNAKONHEI = Allocator.Temp)
	{
		return default(BLJMICDPKDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEC20", Offset = "0x6EEE020", VA = "0x186EEEC20", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6EEED50", Offset = "0x6EEE150", VA = "0x186EEED50")]
	public FCBKPFOJNCF JLDAKMOMDIF()
	{
		return default(FCBKPFOJNCF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEE90", Offset = "0x6EEE290", VA = "0x186EEEE90", Slot = "6")]
	private IEnumerator<AGLPGLMEACF> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEF70", Offset = "0x6EEE370", VA = "0x186EEEF70", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public struct DKEAPBGBOMB : IList<AGLPGLMEACF>, ICollection<AGLPGLMEACF>, IEnumerable<AGLPGLMEACF>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct EOPBCOJFKCM : IEnumerator<AGLPGLMEACF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly LKGAMHHAMKI BNOCOAKANOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator ADGILLNPFAM;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public AGLPGLMEACF GKCMOMIKDKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6EF1EF0", Offset = "0x6EF12F0", VA = "0x186EF1EF0", Slot = "4")]
			get
			{
				return default(AGLPGLMEACF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6EF1E70", Offset = "0x6EF1270", VA = "0x186EF1E70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x45857F0", Offset = "0x4584BF0", VA = "0x1845857F0")]
		public EOPBCOJFKCM(LKGAMHHAMKI BNOCOAKANOI, NativeArray<LocalId>.Enumerator ADGILLNPFAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6EF1DB0", Offset = "0x6EF11B0", VA = "0x186EF1DB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6EF1DF0", Offset = "0x6EF11F0", VA = "0x186EF1DF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6EF1E30", Offset = "0x6EF1230", VA = "0x186EF1E30", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly LKGAMHHAMKI BNOCOAKANOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> CCBEIEEDJFG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public AGLPGLMEACF MGACFGHHFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0410", Offset = "0x6EEF810", VA = "0x186EF0410", Slot = "4")]
		get
		{
			return default(AGLPGLMEACF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0490", Offset = "0x6EEF890", VA = "0x186EF0490", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6EEFB20", Offset = "0x6EEEF20", VA = "0x186EEFB20", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int AEFILNEPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6EEFB20", Offset = "0x6EEEF20", VA = "0x186EEFB20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool IHEEMPBAFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0380", Offset = "0x6EEF780", VA = "0x186EF0380")]
	public DKEAPBGBOMB(int BIMLHBENMHO, LKGAMHHAMKI BNOCOAKANOI, Allocator HPLNAKONHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0300", Offset = "0x6EEF700", VA = "0x186EF0300")]
	public DKEAPBGBOMB(LKGAMHHAMKI BNOCOAKANOI, Allocator HPLNAKONHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0270", Offset = "0x6EEF670", VA = "0x186EF0270")]
	public DKEAPBGBOMB(LKGAMHHAMKI BNOCOAKANOI, int LOKMFEIHLAN, Allocator HPLNAKONHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6EEFAA0", Offset = "0x6EEEEA0", VA = "0x186EEFAA0")]
	public BLJMICDPKDA BFBIOAEABCG()
	{
		return default(BLJMICDPKDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6EEFB60", Offset = "0x6EEEF60", VA = "0x186EEFB60", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6EEFBA0", Offset = "0x6EEEFA0", VA = "0x186EEFBA0", Slot = "13")]
	public bool Contains(AGLPGLMEACF HHDONFMCNBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6EEFC30", Offset = "0x6EEF030", VA = "0x186EEFC30", Slot = "14")]
	public void CopyTo(AGLPGLMEACF[] IGGIDMIPNHL, int GJALKOIBMBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6EEFA20", Offset = "0x6EEEE20", VA = "0x186EEFA20", Slot = "11")]
	public void Add(AGLPGLMEACF HHDONFMCNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6EEFE50", Offset = "0x6EEF250", VA = "0x186EEFE50", Slot = "7")]
	public void Insert(int HAJICDLBEKC, AGLPGLMEACF HHDONFMCNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6EEFFE0", Offset = "0x6EEF3E0", VA = "0x186EEFFE0", Slot = "15")]
	public bool Remove(AGLPGLMEACF HHDONFMCNBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6EEFDC0", Offset = "0x6EEF1C0", VA = "0x186EEFDC0", Slot = "6")]
	public int IndexOf(AGLPGLMEACF HHDONFMCNBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6EEFF90", Offset = "0x6EEF390", VA = "0x186EEFF90", Slot = "8")]
	public void RemoveAt(int HAJICDLBEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6EEFD80", Offset = "0x6EEF180", VA = "0x186EEFD80", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6EEFF00", Offset = "0x6EEF300", VA = "0x186EEFF00")]
	public EOPBCOJFKCM JLDAKMOMDIF()
	{
		return default(EOPBCOJFKCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6EF00B0", Offset = "0x6EEF4B0", VA = "0x186EF00B0", Slot = "16")]
	private IEnumerator<AGLPGLMEACF> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0190", Offset = "0x6EEF590", VA = "0x186EF0190", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CIAGGIGPIGF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int JCGALALALJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> NCEIKCEHJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AGLPGLMEACF DNHPHIFKALA(AGLPGLMEACF CCBEIEEDJFG);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AHMKICNKDGM : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface FPNNKLJMNEK : LNEAFBHKLOP, PJAAGGJLMPG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool ANJBFCDOFPB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	OIMJMIILKDI BOLMOBAFHBH
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	CIEEKLELEJE LGKANLEKDNO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	EDFLPHOAHJN ODGMLGNBCNI
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	HNECHANNMPH GPOGOCPPPGF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface PJAAGGJLMPG
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool MJGGKOLDCNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface LIDLODBKAPP
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKCAMFNPPOK(bool EEPLCHCGAIN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[AEODNGLJNOH(HNNAHENHILF.PhotonRoom)]
public interface DBLMNPHHOHK
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool EMNHOLOOMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPFLDMDHGPH(bool BOCGODCJHIA);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPKIMNIGLND();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CPKDPECFFME(ByteString GNHHNHJOMCE);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void COKEGDLOHHF();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PLGFOFCBJKK();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FHLNLNDFCBG();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NNIOIKJJEFD();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IPHHDCDCHAJ();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface EDFLPHOAHJN
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	MLIFIICJDOD BOLMOBAFHBH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	CIEEKLELEJE LGKANLEKDNO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	JOEKENHMAMF KDBIFKJKAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	CKJDEBJNKBP KFNIKLGCBIA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	FPNNKLJMNEK ECCFFLGEBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	DBLMNPHHOHK MFCDIJKEAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	LKGAMHHAMKI FBMKFDLJDAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IJHAGBMDOFM KHJCAJHAJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	BGBCLBMHAOP JKJIFLFPOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	BGECJGGCEIF LCENDOGKNHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	PGNAGBGCDHO ENEGHJAJNGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	HPIODHHBGKA EJPMNFKECPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	FCNCDMPAPNL IKCFJCIBFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	JKJHEMKEGLM GBCAFPBDEBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	NJDIBDJKAFL BJPFGFDHAAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	HCPOBEAGGMH AEMGMJHNCPN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	HEKNHHAEJJM NFDCCJPGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	CDNMCPCLAEP NOLOBHFLPFK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	HJAHHCBGNIN MEMMNEFIKLH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	BPHANBLNBIF AGPIGIMFFIP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	BKKFHGJAJGB PPLHJICEPPH
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	HCFEDPOKDLG MOKNGPNIDCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	GNKOLMGLLIA DDEAHMBHMAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	ODMBJEACHDK AOFICFEGGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	FLNJFJCFCNI CKMCFMGJBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	MMMGDABNIKO JHMNBONADNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	OBONOIPFGME JLBJJLEJLPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	ICEDKPGDOIC JILHFGDJMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	LLBAMGDPGNH AIPMFAOGIIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	EICDJHOMJEC DAODIBHGMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	KJPFHAMOGGG IBKKELNMBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(LOGOKNCMHNI))]
public readonly struct AGLPGLMEACF : IComparable<AGLPGLMEACF>, IEquatable<AGLPGLMEACF>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly AGLPGLMEACF ILFKJMJAIPF;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int LHGOMHJFBGD = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int JIPIMNPLMFK = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int MLLOPJBGAIC = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int BIIKEIPKHGE = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId IMMJHCFALCP;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public LKGAMHHAMKI FBMKFDLJDAK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC6E0", Offset = "0x6EEBAE0", VA = "0x186EEC6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public FPNNKLJMNEK ECCFFLGEBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6EED2B0", Offset = "0x6EEC6B0", VA = "0x186EED2B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public LocalId FGHIOGIAEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6EECCA0", Offset = "0x6EEC0A0", VA = "0x186EECCA0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	internal HNECHANNMPH GPOGOCPPPGF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6EED180", Offset = "0x6EEC580", VA = "0x186EED180")]
		get
		{
			return default(HNECHANNMPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool AJEFCBIPMCP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6EED060", Offset = "0x6EEC460", VA = "0x186EED060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private bool OBJPLADPGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6EECDF0", Offset = "0x6EEC1F0", VA = "0x186EECDF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6EED440", Offset = "0x6EEC840", VA = "0x186EED440")]
	public AGLPGLMEACF(LKGAMHHAMKI POJJMAEFFND, LocalId IMMJHCFALCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
	public MELHPPJKMHE ILKAPCLCFHF()
	{
		return default(MELHPPJKMHE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6EECE40", Offset = "0x6EEC240", VA = "0x186EECE40")]
	public static LocalId EGFECENGKHG(AGLPGLMEACF ALFCIPHGFII)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6EECE80", Offset = "0x6EEC280", VA = "0x186EECE80")]
	public static Entity EGFECENGKHG(AGLPGLMEACF ALFCIPHGFII)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6EED190", Offset = "0x6EEC590", VA = "0x186EED190")]
	public static bool LBFMGPFDJNL(AGLPGLMEACF NIPIGODEADI, AGLPGLMEACF BCMPBHCEGGA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6EECCE0", Offset = "0x6EEC0E0", VA = "0x186EECCE0")]
	public static bool CJIGOGHINMG(AGLPGLMEACF NIPIGODEADI, AGLPGLMEACF BCMPBHCEGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6EED310", Offset = "0x6EEC710", VA = "0x186EED310", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6EECEC0", Offset = "0x6EEC2C0", VA = "0x186EECEC0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6EECD00", Offset = "0x6EEC100", VA = "0x186EECD00", Slot = "4")]
	public int CompareTo(AGLPGLMEACF KNLMODPGFOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "5")]
	public bool Equals(AGLPGLMEACF KNLMODPGFOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JAIJFCKBLOH
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6EF7E70", Offset = "0x6EF7270", VA = "0x186EF7E70")]
	public static PBFPCCNOOBK NDFEDNLMFGM(this AGLPGLMEACF FMAFBHGACNM)
	{
		return default(PBFPCCNOOBK);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6EF7DC0", Offset = "0x6EF71C0", VA = "0x186EF7DC0")]
	public static MELHPPJKMHE GAIGFBPDAAN(this AGLPGLMEACF FMAFBHGACNM)
	{
		return default(MELHPPJKMHE);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2EB0DB0", Offset = "0x2EB01B0", VA = "0x182EB0DB0")]
	public static T LDLFEBFOGPA<T>(this AGLPGLMEACF FMAFBHGACNM) where T : struct, IOJAJBKPDEN
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class LOGOKNCMHNI
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct HNECHANNMPH : IEquatable<HNECHANNMPH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte KNOJBNNAGCL;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] PBBPAIDOHGB;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static LKGAMHHAMKI MEFMEFJEEFF;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static FPNNKLJMNEK MJMKHMKNKMN;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static LKGAMHHAMKI[] FNLBMPNHAKE;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static FPNNKLJMNEK[] POKOGLMMDJP;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> GEOIGLONJMG;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public FPNNKLJMNEK ECCFFLGEBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5FF0", Offset = "0x6EF53F0", VA = "0x186EF5FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public LKGAMHHAMKI DJOFNFMBAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6EF60D0", Offset = "0x6EF54D0", VA = "0x186EF60D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6EF65E0", Offset = "0x6EF59E0", VA = "0x186EF65E0")]
	static HNECHANNMPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x23E8990", Offset = "0x23E7D90", VA = "0x1823E8990")]
	internal HNECHANNMPH(byte EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x60166E0", Offset = "0x6015AE0", VA = "0x1860166E0", Slot = "4")]
	public bool Equals(HNECHANNMPH KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5A10", Offset = "0x6EF4E10", VA = "0x186EF5A10", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xA4D510", Offset = "0xA4C910", VA = "0x180A4D510", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6EF6520", Offset = "0x6EF5920", VA = "0x186EF6520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5AC0", Offset = "0x6EF4EC0", VA = "0x186EF5AC0")]
	private static LKGAMHHAMKI HKPEEFCOCCD(byte KNOJBNNAGCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5970", Offset = "0x6EF4D70", VA = "0x186EF5970")]
	private static FPNNKLJMNEK DEKGHBJGHGL(byte KNOJBNNAGCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5B60", Offset = "0x6EF4F60", VA = "0x186EF5B60")]
	private static object IADNHEOAHGP(byte KNOJBNNAGCL, object[] BFAMJIIMLEB, object BMLEAJPEFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6EF6510", Offset = "0x6EF5910", VA = "0x186EF6510")]
	private static int OHOKOJNBFBN(byte KNOJBNNAGCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5AB0", Offset = "0x6EF4EB0", VA = "0x186EF5AB0")]
	private static int GIJCNGIJALM(byte KNOJBNNAGCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5CC0", Offset = "0x6EF50C0", VA = "0x186EF5CC0")]
	private static (int, int) KBGOFINCBBO(byte KNOJBNNAGCL)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5D40", Offset = "0x6EF5140", VA = "0x186EF5D40")]
	private static byte LCJHMCBHJLC(int ABNEAOFINHP, int HAJICDLBEKC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5D50", Offset = "0x6EF5150", VA = "0x186EF5D50")]
	internal static HNECHANNMPH MHJHNBDIMHP(FPNNKLJMNEK DCLPOILPFCM, LKGAMHHAMKI BCBAJCGOJJJ)
	{
		return default(HNECHANNMPH);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5780", Offset = "0x6EF4B80", VA = "0x186EF5780")]
	internal static void AMMAKBKKNOC(HNECHANNMPH KNOJBNNAGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6EF61B0", Offset = "0x6EF55B0", VA = "0x186EF61B0")]
	private static void NNBMBBGNHJA(int BIMLHBENMHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface FKPKPFIGLMB
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBLDIIAEBEO();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IDBKNPOJCHI(bool BIINKKMAPGO);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GJDDNGMBKDL(GameObject BCDDMHHPJBD);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface PNJAOBHMEKG
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Guid FGHPCPMNPJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AFKEBIHHCEN(Guid FKCNCBNHLBE, Guid BBANEDNDONM, Guid GJAKGOLEAJA);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task FHMNHNLFPBA(Guid FKCNCBNHLBE, Guid[] AHEKKHHJIID, Guid GJAKGOLEAJA);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid DDNMAMPOPFI(Guid HANIKMKPJIE);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task HGIMGGPMJED(AGLPGLMEACF DNGEPKJBLJE);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BKFHNJDPJJH(NNDKCHIADCC FENHBGJEOPK, Guid JFDMNOHMEDB);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CNLAMGNHACC(Guid HANIKMKPJIE, bool BOCGODCJHIA);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface IJLGCDDOACP
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NNDOMJKBNEK(BLJMICDPKDA CCBEIEEDJFG);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface JIFMOHGJOBG
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PODMOLIONOB(GameObject AEOKAFLGEDK, GameObject EPJGLONMAOO, int IAFMPAIKJAF);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface CIEEKLELEJE
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	FKPKPFIGLMB PFDEIBAHGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	FHEDFKNIJGD BCPLHCPKMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	ACCHHALNPMJ ODMOJAIPKJA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	MKLDPBHKPGK MNIACJAIICB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	BAIAGDIBPBB PFFMANNKDPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	GAKOPMILNDJ EEHPBPNPKKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	HNGLKNCJMKE MDNOGCMOBAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	KANBEMIBCIP PMLHBMBIHKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	PAKOBBEABNE PLLBAHJLFDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	OHPNGFIKINI GCIAEIHGLBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface FHEDFKNIJGD
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string EOMBBAKEGAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface EGOFFAMDGPE
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFHMDFGBGKK(Action HJOAJFDFEDM, bool JLFDOBMNHFK);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FDIGMGLPCBO(string DDDHPCNFCEK);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int OCMGAPNIPHI(string DDDHPCNFCEK, int BMLEAJPEFAD);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CPCOGJICGNE([Out] bool EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LLCLNHBOICK([Out] bool EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FIFFLAADMCK([Out] int EEPLCHCGAIN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface ACCHHALNPMJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string KJFBJMDFFII
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] BBLBOMNADBA(IEnumerable<AAFDHJHHGMN> FLIDBFKLGKA, bool GBBOKHGGHMP);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PENHLLIMKEN(GameObject BCDDMHHPJBD, [Out] PBFPCCNOOBK[] BIICPJAJNCF);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EJAEOEDFEIE(GameObject BCDDMHHPJBD, [Out] int IAMMIAGBEBC, [Out] APJHGHONFKE JJJPIBKENDJ);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NNDKCHIADCC EAJEMEBGEAH(AAFDHJHHGMN BCGNIJHEBIO);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NNDKCHIADCC EAJEMEBGEAH(string IMDAMHNKLIB, PBFPCCNOOBK[] LEELLFGMHHO, Vector3 CLHMEGFDOKF, Quaternion MDJOMEFJFHD, Vector3 KFNOLBCIBOH);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NNDKCHIADCC KMGGOLPJGBO(string IMDAMHNKLIB, PBFPCCNOOBK[] LEELLFGMHHO, Vector3 CLHMEGFDOKF, Quaternion MDJOMEFJFHD, Vector3 KFNOLBCIBOH);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject KOEENCJJNNB(string IMDAMHNKLIB);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EAKLNLAOBPO(GameObject OGMKOAEKJHL, bool OLDPCMHFMDA);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MHHJOCCLAPN(GameObject BCDDMHHPJBD, bool ALEIDMNELKE, bool LFANIDFFJBB);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class AEGILMFGCKF
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9E0", Offset = "0x6EEBDE0", VA = "0x186EEC9E0")]
	public static NNDKCHIADCC EAJEMEBGEAH(this ACCHHALNPMJ BLDEOEOIGBD, Vector3 CLHMEGFDOKF, Quaternion MDJOMEFJFHD, Vector3 KFNOLBCIBOH, params PBFPCCNOOBK[] BIICPJAJNCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6EECB40", Offset = "0x6EEBF40", VA = "0x186EECB40")]
	public static NNDKCHIADCC KMGGOLPJGBO(this ACCHHALNPMJ BLDEOEOIGBD, Vector3 CLHMEGFDOKF, Quaternion MDJOMEFJFHD, Vector3 KFNOLBCIBOH, params PBFPCCNOOBK[] BIICPJAJNCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface MKLDPBHKPGK
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGEKFANGKNN(bool BOCGODCJHIA);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface BAIAGDIBPBB
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool OFDBKCKCJIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool NIGDGGKMOFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool DGKDBHNNPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	int MMLKOECCCKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool LFFKIPAHCOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MLNLIMBFACL(object GKKLHKCNNPG);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KPBCGHFBBAC(object GKKLHKCNNPG);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AHEANJLBAJF(object KDGMCPCFIID);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IJIGJMBCPDK(object KDGMCPCFIID);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ViewId JDHOJEELNPP(GameObject OJGOEPKIAGN);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ANHOOLHNGEK(NativeArray<ViewId> JINHCNFILOB);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IOFJMFEBCPC(NativeArray<ViewId> HEMAIHEOPDO);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OLBAIIKCNPC();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HBKONLJCDDC(uint ENHLEGECDIF, ReadOnlySpan<byte> NOCGIAMLJII, bool LDGOOLPDNJH = false);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HBKONLJCDDC(uint ENHLEGECDIF, ReadOnlySpan<byte> NOCGIAMLJII, ReadOnlySpan<byte> FAPKLIDPPPF, bool LDGOOLPDNJH = false);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OPOJDJBHEEE(Func<int, bool, int> CCMCMDGAJMJ, bool GHAGHFBHIFA);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BHEDDJCOPMM(object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void GBLJPIIEJHK(object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	uint KHGKIPIHEFA(uint MPHJCCJMKLK);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class HEKJKFJDGCJ
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5470", Offset = "0x6EF4870", VA = "0x186EF5470")]
	public static HKBFDIECPIP FBJIOBJPBDK(this BAIAGDIBPBB DAOJAMKOACA, object ABHFNNFMPHA)
	{
		return default(HKBFDIECPIP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct HKBFDIECPIP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private BAIAGDIBPBB DAOJAMKOACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private object ABHFNNFMPHA;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5660", Offset = "0x6EF4A60", VA = "0x186EF5660")]
	public HKBFDIECPIP(BAIAGDIBPBB DAOJAMKOACA, object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5610", Offset = "0x6EF4A10", VA = "0x186EF5610", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface GAKOPMILNDJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBNCMEHONMH(GameObject BCDDMHHPJBD);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface HNGLKNCJMKE
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public struct LAKDPMMCDIG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private HNGLKNCJMKE EAHCPCLLBLN;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8F60", Offset = "0x6EF8360", VA = "0x186EF8F60")]
		public LAKDPMMCDIG(HNGLKNCJMKE EAHCPCLLBLN, string MOKGCFCFCPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8F00", Offset = "0x6EF8300", VA = "0x186EF8F00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct BELNOIPDLDK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private HNGLKNCJMKE EAHCPCLLBLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Task IALOMLEGCDH;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEAD0", Offset = "0x6EEDED0", VA = "0x186EEEAD0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DKFNPNEKLHO(string MOKGCFCFCPE, float AMGMJAOIIEE = 5f);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCHPHIJFEEL();

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MLCAKFPOJKH(bool DNIADNEFCPE, string MOKGCFCFCPE);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class GLFBENHGBKK
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2F00", Offset = "0x6EF2300", VA = "0x186EF2F00")]
	public static HNGLKNCJMKE.LAKDPMMCDIG EEOLHOBDFAP(this HNGLKNCJMKE DAOJAMKOACA, string MOKGCFCFCPE)
	{
		return default(HNGLKNCJMKE.LAKDPMMCDIG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface BEECPOONJGM
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BPCMEFHLCFE(GameObject BCDDMHHPJBD);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OBNMOJGPLIL(GameObject BCDDMHHPJBD);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IPOPLBEFMIB(int AEAJAMHEDBI);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object OEAMKOJAFED(AGLPGLMEACF IMMJHCFALCP, GameObject BCDDMHHPJBD, Action<AGLPGLMEACF, int> JMKLCPOKHHP);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LKBCBFMPDHF(GameObject BCDDMHHPJBD, object FAOCKDNNGFM);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface JPBBJMIKEAD
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool NIDBONJOPOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate OLPEBDBICOJ(CIANCIDELPI.PLMCINGOKGI NLHCMBOHPKL, Action<CIANCIDELPI.PLMCINGOKGI> JMKLCPOKHHP);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KEBHAJHPOCO(CIANCIDELPI.PLMCINGOKGI NLHCMBOHPKL, Delegate JMKLCPOKHHP);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate AHMIJACBGMJ(CIANCIDELPI.PLMCINGOKGI NLHCMBOHPKL, Action<CIANCIDELPI.PLMCINGOKGI> CKBNLFCBIIE);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AJBHHMNIGAM(CIANCIDELPI.PLMCINGOKGI NLHCMBOHPKL, Delegate JMKLCPOKHHP);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DAGLDKDIDPH(CIANCIDELPI.PLMCINGOKGI NLHCMBOHPKL);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CIANCIDELPI.PLMCINGOKGI JNKPGBEHINO(GameObject BCDDMHHPJBD);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface KANBEMIBCIP
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	int PAJICGKAMNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	int NLOLPPNIDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool NIGDGGKMOFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool GPAMKCKGEHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int OILKEDIFINI(GameObject BCDDMHHPJBD);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PDFAPKAPIGP([Out] Vector3 CLHMEGFDOKF);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LBCEEJNJAKI();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AGLPGLMEACF MOIIFEKFAIK(int AEAJAMHEDBI);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BGBBPAOFCED();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface PAKOBBEABNE
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool EMNHOLOOMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface JLJOACPNNEP
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	FAKHKPGPLLB HJDNOHLOLNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	DGKCKMLIMME AFOJCONHKEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LJJAMGEKIHH(Transform HGENDDPKHHK);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FHFLJKPPCND(Transform HGENDDPKHHK, EFBDBKLCEKO LOMMEPBLCJN);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NGCOAPEKGPK(Transform HGENDDPKHHK, OIBFOBLKIEF HOJKJKJCBGO);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface AKCCMNGHAJF
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface OHPNGFIKINI
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action ODDOGHOJJGE;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NMOMBEJIGCP(BLJMICDPKDA AIOCKHNDALE, bool DNIADNEFCPE);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface LOPOBPKCEJO
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NEPGPNEPJHJ();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface DHBOCIDCENJ
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	APJHGHONFKE KEKHDAHGLJK(GameObject OJGOEPKIAGN);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GCNCKOGDCFC(GameObject BCDDMHHPJBD, IABBENFALKI KBBLBIMGMGO, GLBDCLACINM BGNHKIJCCOF);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FGLDEAHODMM(AGLPGLMEACF IMMJHCFALCP, bool LFPOFHAFHBD, float3 NFEAPPHKMJN, quaternion AKGDBGGKFLH);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JDJBDLPEEBH(MELHPPJKMHE OACLGAKONPN, MELHPPJKMHE KDGMCPCFIID, ABCKHNEHFAE KEKHLMMPMLO);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NMEFJHHLFHD(MELHPPJKMHE OACLGAKONPN, ABCKHNEHFAE KEKHLMMPMLO);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BBMICOCBLIJ(BLJMICDPKDA KFGADIJPBAA);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IKOBAGMMGFA(BLJMICDPKDA BNOCOAKANOI, NativeArray<LocalPoseData> JKOOHBOFBBE, NativeArray<float3> FHAIHOHJBOE);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IAFHNFBJOCN(BLJMICDPKDA BNOCOAKANOI, BLJMICDPKDA EBILCIMIEBD);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MBBDLPLFJCC(BLJMICDPKDA BNOCOAKANOI, bool NFFIBAAGKAO);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KPEEPLCOPNP(BLJMICDPKDA BNOCOAKANOI, bool CJCOIHMGAHC);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct JJNALBHINGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly CCADDKHICPH IJLPKFECKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly CCADDKHICPH LELDIOMELDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint OIKEBIFLFHD;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6EF7FA0", Offset = "0x6EF73A0", VA = "0x186EF7FA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct HDBFEALPFDA
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal readonly JJNALBHINGM HJOAJFDFEDM;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6EF4B70", Offset = "0x6EF3F70", VA = "0x186EF4B70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct LCDAFANHOLD
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal readonly JJNALBHINGM HJOAJFDFEDM;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6EF4B70", Offset = "0x6EF3F70", VA = "0x186EF4B70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct EIAEDNODFGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal readonly uint OIKEBIFLFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal readonly bool IMHEAKPODDE;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6EF1D10", Offset = "0x6EF1110", VA = "0x186EF1D10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct CCADDKHICPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal int OLMEFNCLGNG;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6EEF2E0", Offset = "0x6EEE6E0", VA = "0x186EEF2E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface MAJMIEOAJFL
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	HIKKEACIMJK MCEKOHPIOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public enum CALIOONEHOM
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
public interface NNDKCHIADCC : PBNOLADHDNE
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	CALIOONEHOM CHLBNCIKFPI
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool DHLGMMCEDNN
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	GameObject BCDDMHHPJBD
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<NNDKCHIADCC> DFEBIBMKFIJ;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(JOEKENHMAMF NNBFJMEFHAJ, AGLPGLMEACF OKCLNECINJK);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool CMLFKMIJJMP);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class LNMBPCEAFJB
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9250", Offset = "0x6EF8650", VA = "0x186EF9250")]
	public static bool MKPJLPPJIBK(this NNDKCHIADCC MJLOJBGDGDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9200", Offset = "0x6EF8600", VA = "0x186EF9200")]
	public static bool HPMIKBKBIDB(this NNDKCHIADCC MJLOJBGDGDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6EF91B0", Offset = "0x6EF85B0", VA = "0x186EF91B0")]
	public static bool BDFONBEELMA(this NNDKCHIADCC MJLOJBGDGDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9120", Offset = "0x6EF8520", VA = "0x186EF9120")]
	public static bool ANJBFCDOFPB(this NNDKCHIADCC MJLOJBGDGDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface PBNOLADHDNE
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool BCAMLDHBAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	AGLPGLMEACF DGDENOKALKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface EEFIIKHCBIP
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate void EHMCKPFLGKN(KCBLGEGNIDN FNNPNFKDPMC);

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event EHMCKPFLGKN EAFPFLGIEOC;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface OPJEFPGPHFI
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KKHLNIJHHPM(Vector3 CLHMEGFDOKF, Quaternion MDJOMEFJFHD, Vector3 KFNOLBCIBOH);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HGECDLHOFAC(AGLPGLMEACF DEDHJMDEEIE);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OIPHGAFJPJC(bool GALHJOPKNMI);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FKELBAPJLHA(bool CJCOIHMGAHC);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface GFNFKBMBBAB
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface CPNJPJCPLFA
{
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(AKFJEGODPDH NMLDACOCLJB);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface AKFJEGODPDH
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	GameObject BCDDMHHPJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Transform HGENDDPKHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	GNENMCIDPEM CJDCMACJIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool PDIJHFMIAEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PPLEOIIDAMJ(GNENMCIDPEM JPNNGBEFPIE);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface GNENMCIDPEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	AGLPGLMEACF DGDENOKALKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Rigidbody KIKAKLALKIE
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	AKFJEGODPDH EBCPMMAAAGD
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	GameObject HAIKDHHODMO
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	Transform BDJMNGJGEPI
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	GNENMCIDPEM CNLABKPDMID
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	GNENMCIDPEM PAGLAEHKACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int JLNMICMFDCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	bool GAMAFBGALEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	bool DAGLDKDIDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	bool PNIHJIBCNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	OPFMAOOBLLA LGKPJBOBGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	PAFPNLLDLFP DLCPBKKGFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float MGCHCNEGFHE
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Vector3 BHOHPOALPMD
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	Vector3 APBHOELFNPE
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Vector3 LAGAIBFOEEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 KNNCHNCILOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool HMHOAFAJDHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool INBJHNLAIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	bool FMHHHMCOOIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 LBGLBFFMPFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Vector3 KLAEBFDLDLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	Vector3 MJDCGLHPNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Vector3 NALPKDKIGKK
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	float CMPNNGPHAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	float BICLGLJPJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	Vector3 PJNENDEALGA
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	Quaternion DNCJEDDOJMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	float GIIOJNIOBNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "60")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	float MKKCJHHNAOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	bool JODBLCMDIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "64")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	MLNLAOAECFA CPPBBBPHILE
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "66")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool OMKBNDMPAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Transform BAFDECEPINN
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 CAOBJIJNKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "70")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	float MKCNLDHEIBG
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "72")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	float JELEBBONDKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "73")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "74")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	Quaternion LFGAIGMMBCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "75")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	Vector3 ADKILKCAHGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "78")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	Quaternion CKEEBDBDPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "79")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "80")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	RigidbodyConstraints CCNGDIBBDAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "82")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	bool HCNFBODKBFP
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	CollisionDetectionMode HBONCPHCCAF
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "86")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	bool GBGJLIKBJAA
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "87")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event EIBFAGEEMAF IFCEEFDAHEF;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event EIBFAGEEMAF AEIMJFGGBMI;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event EIBFAGEEMAF LCICBLPNPKE;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event EIBFAGEEMAF CEHKLBHNDEK;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event EIBFAGEEMAF BMHAGMABFJE;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event EIBFAGEEMAF LFINLFDFJPP;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event EIBFAGEEMAF KCEGOHOIJLE;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event JGNAGMIJHCB PDDMGHPLGCE;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<JHPLKFFCHDF, JHPLKFFCHDF> LAAJLCKFOHC;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "26")]
	GNENMCIDPEM JJHMKPKLGIM(int HAJICDLBEKC);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void KKAKDEJIFDA((Quaternion rot, Vector3 moments) IFAMPJEONCG);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void OICKCJAMCMG();

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void JHKELGPFBMI();

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void HBBIBKLJMKH();

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void DLBLJMIMABA();

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void HGECDLHOFAC(GNENMCIDPEM EEPLCHCGAIN, bool LCNIJLOJAGJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void ABINNCCMOAN(object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void GDBGGEPKNII(object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "95")]
	Vector3 EIFFMIENBIO(Vector3 LFFEGBGDOPO);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "96")]
	Vector3 GIEDGGBOHPA(Vector3 AHELNOLPMIB);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void IJMNINGLFII();

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void CADKCHJHLHI();

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void CFNDDLJCEMO();

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void DJLBKENEHMH(Vector3 FICPNOACCPA, Vector3 MBHKBNFIGNE);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void FFAELKNMIGM(Vector3 KFINDPIHPIF, Vector3 GCFMFJNALIM);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void MGOINFGFJOD(Vector3 PCALPEJHEDG);

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void EGMKAAINCJN(ECHIOPDOMDO IONCIEEBOBO, Vector3 JOGLJMPKPKH, float PPDEONJIIMA, float OFOGFBIIGGI = 8f, float BJMNFCJBKKE = 1f);

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void EFLEMJFNFOP(ECJJLAKNLID KOCJMOOKFFH, Vector3 BBIPOCPEDJM, float JLDDDBDKMNI = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void ILEPDKIGMPO(ECJJLAKNLID KOCJMOOKFFH, Vector3 MDJOMEFJFHD, float BBBGCFNLFEE = 7f, float LDHDIPAMOEN = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "106")]
	Vector3 IIPLLEMKFCG(Vector3 EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "107")]
	Vector3 BOEHOBLDELA(Vector3 EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void JLGHMDCLJFJ();

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "109")]
	void MIPLODMEAFA(GNENMCIDPEM DFKIPILFANJ, object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void BEEFIIBDPNP(object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void BFCJABJNJNJ();

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void EGDBGLFOHBG();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void JKLECADOEME();

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "114")]
	bool KCNDEMAKNNC();

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void ENCEEBEJNHB();

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "116")]
	void MDOKJEKJEPB(object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void NFNBHJKHGPF(object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void COGFCLDDILJ(object ABHFNNFMPHA, bool PKMIKOAMPIA);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void NDJEINIBCNJ(Vector3 MFPJNNFLIFP, Quaternion LLJELCFPHCP);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void ADCAKFLGNGD(Vector3 IALALBHIOOH, Quaternion BDCEABKAEDO);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "121")]
	bool FJBFPEMPFFB(float KHDOIBPNKOB);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void JPLLGELEFGC(object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void MDHLEIDJAPD(object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void HNNIKFOPAHB(object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void LAJLCBGBEBF(object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void GOLMBOBCIAE(Vector3 MALABKOONDB, ForceMode BFEPKKCNFOD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void DMDNKPCMOML(Vector3 MALABKOONDB, Vector3 CLHMEGFDOKF, ForceMode BFEPKKCNFOD);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void LLJKEPGCFPF(Vector3 IHEPDJJOFIK, ForceMode BFEPKKCNFOD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void OENFINJMCLJ(Vector3 IHEPDJJOFIK, ForceMode BFEPKKCNFOD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "130")]
	bool CDGBDFLPKMM(Vector3 PAAGAJJEHGO, [Out] RaycastHit NKGBAALLKCD, float NHDEHMAPALH);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void HHLMEAPLHIF();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface PAFPNLLDLFP
{
	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DAACMFLJLFI(Vector3 IAJJOBCKNCH);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LIBLGCNPGEF(Vector3 BGJOJHOMGKA);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NDGNIFHGGGH(Vector3 IAJJOBCKNCH);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HAFAHPBFKKO(Vector3 BGJOJHOMGKA);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface OPFMAOOBLLA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 PGELIKFKMGC();

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 JBABKHBCFGJ();
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public delegate void EIBFAGEEMAF(AKFJEGODPDH HGBAHEHGAGM);
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum FPGIGNFFKDM
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
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum ECHIOPDOMDO
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
[Cpp2IlInjected.Token(Token = "0x2000044")]
public delegate void JGNAGMIJHCB(AKFJEGODPDH HGBAHEHGAGM, bool LCNIJLOJAGJ = false);
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum ECJJLAKNLID
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct HBBDMOFMLCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Rigidbody KLDNEBDEBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public object KKBKFEKPJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector3 HLPHMHEEKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector3 DPJDAGBFMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public LGMGBDCHIJJ LGKAHCGFMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool NMFLHNFIIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool GFCLAFDJHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool EJBCCFKAECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public bool CLLGHOFBDEM;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface BDNBHGILHDL : DBPOIKCPHGA<PBFPCCNOOBK>, MEKBBDHIBKK, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface BFPIHFDFMNN<T> : KIEMIBJKEGG<PBFPCCNOOBK, T>, DBPOIKCPHGA<PBFPCCNOOBK>, MEKBBDHIBKK, IDisposable, BDNBHGILHDL where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class DNPBDBMKJCK
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x2CA40E0", Offset = "0x2CA34E0", VA = "0x182CA40E0")]
	public static bool FAKKNFFMHEG<T>(this DBPOIKCPHGA<PBFPCCNOOBK> ECJEGOAKEPN, PBFPCCNOOBK LEELLFGMHHO, [Out] T EEPLCHCGAIN) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4110", Offset = "0x2CA3510", VA = "0x182CA4110")]
	public static bool MCAKFOHFDBM<T>(this DBPOIKCPHGA<PBFPCCNOOBK> ECJEGOAKEPN, PBFPCCNOOBK LEELLFGMHHO, [In] T JFKJABAPEAB) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface MBCPEBKFPIH : DBPOIKCPHGA<AGLPGLMEACF>, MEKBBDHIBKK, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface GKBFLFAGBPA<T> : KIEMIBJKEGG<AGLPGLMEACF, T>, DBPOIKCPHGA<AGLPGLMEACF>, MEKBBDHIBKK, IDisposable, MBCPEBKFPIH where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class KBIFDOKMOEB
{
	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x2C66260", Offset = "0x2C65660", VA = "0x182C66260")]
	public static T CADKKGPFCDD<T>(this DBPOIKCPHGA<AGLPGLMEACF> ECJEGOAKEPN, AGLPGLMEACF IMMJHCFALCP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4110", Offset = "0x2CA3510", VA = "0x182CA4110")]
	public static bool MCAKFOHFDBM<T>(this DBPOIKCPHGA<AGLPGLMEACF> ECJEGOAKEPN, AGLPGLMEACF IMMJHCFALCP, [In] T JFKJABAPEAB) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct CJLCNFBKAPH : IComparable<CJLCNFBKAPH>, IEquatable<CJLCNFBKAPH>
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly CJLCNFBKAPH ILFKJMJAIPF;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly CJLCNFBKAPH HODPKFMBBIM;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly CJLCNFBKAPH PLDJEPOJIIM;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly CJLCNFBKAPH OJNHDBLJLLI;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly CJLCNFBKAPH OABDELLAGCK;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly CJLCNFBKAPH GJNOPPNFNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public int KMIIBMECGKI;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool JDMENHKDOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6EEF5C0", Offset = "0x6EEE9C0", VA = "0x186EEF5C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int NNJFFCDDBHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6EEF630", Offset = "0x6EEEA30", VA = "0x186EEF630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0xC15E20", Offset = "0xC15220", VA = "0x180C15E20")]
	public CJLCNFBKAPH(int HAJICDLBEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x6EEF5D0", Offset = "0x6EEE9D0", VA = "0x186EEF5D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x6EEF530", Offset = "0x6EEE930", VA = "0x186EEF530", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0xCD3550", Offset = "0xCD2950", VA = "0x180CD3550", Slot = "5")]
	public bool Equals(CJLCNFBKAPH KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x1F33FB0", Offset = "0x1F333B0", VA = "0x181F33FB0", Slot = "4")]
	public int CompareTo(CJLCNFBKAPH KNLMODPGFOA)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x1731A10", Offset = "0x1730E10", VA = "0x181731A10")]
	public static CJLCNFBKAPH EGFECENGKHG(int HAJICDLBEKC)
	{
		return default(CJLCNFBKAPH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x1731A10", Offset = "0x1730E10", VA = "0x181731A10")]
	public static int EGFECENGKHG(CJLCNFBKAPH KKMBBLBCHGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x6EEF640", Offset = "0x6EEEA40", VA = "0x186EEF640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct MELHPPJKMHE : IEquatable<MELHPPJKMHE>, PBNOLADHDNE
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly MELHPPJKMHE BEKACKLLBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public AGLPGLMEACF DGDENOKALKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670", Slot = "6")]
		get
		{
			return default(AGLPGLMEACF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public PMJAPJOPPAD BDJMNGJGEPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(PMJAPJOPPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public OEKKEIIFBLP KHJCAJHAJIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(OEKKEIIFBLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private LKGAMHHAMKI FBMKFDLJDAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC6E0", Offset = "0x6EEBAE0", VA = "0x186EEC6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public GameObject BCDDMHHPJBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB010", Offset = "0x6EFA410", VA = "0x186EFB010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public PBFPCCNOOBK OCFIMBFBHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAEC0", Offset = "0x6EFA2C0", VA = "0x186EFAEC0")]
		get
		{
			return default(PBFPCCNOOBK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public GIJOINHKMKF EPLMMDFLFJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB550", Offset = "0x6EFA950", VA = "0x186EFB550")]
		get
		{
			return default(GIJOINHKMKF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public APJHGHONFKE IDOIKCPOFIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB420", Offset = "0x6EFA820", VA = "0x186EFB420")]
		get
		{
			return default(APJHGHONFKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool KMHKCEILPCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB400", Offset = "0x6EFA800", VA = "0x186EFB400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool ICEINDOIAJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB4C0", Offset = "0x6EFA8C0", VA = "0x186EFB4C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool NOLAELCDFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB370", Offset = "0x6EFA770", VA = "0x186EFB370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool KDIOFFJOPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAE80", Offset = "0x6EFA280", VA = "0x186EFAE80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool AGDLFCKNPIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAEA0", Offset = "0x6EFA2A0", VA = "0x186EFAEA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool LJJCDIPBFBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAF60", Offset = "0x6EFA360", VA = "0x186EFAF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool BPAJJKOLMMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAE40", Offset = "0x6EFA240", VA = "0x186EFAE40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool BANJDNPCAPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB3C0", Offset = "0x6EFA7C0", VA = "0x186EFB3C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool JHCJMICBEID
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB530", Offset = "0x6EFA930", VA = "0x186EFB530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public EEOGOEOEKHO LJHMOFOGHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(EEOGOEOEKHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public DMOJHJNFFFB HIDDFEPMBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(DMOJHJNFFFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public CDKNIABHDKE BJPFGFDHAAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(CDKNIABHDKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public MADAFJJEKKB NLEBNGBJDMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MADAFJJEKKB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public AIMOFFKPKBJ GBCAFPBDEBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(AIMOFFKPKBJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public ACMFIGHEFHB JPFOCPDLNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(ACMFIGHEFHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public LPIPPBACIOB PGBJCGBEBPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(LPIPPBACIOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public GGGGNDLKHCK IGIBMJDLDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(GGGGNDLKHCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public DDIEDIJGOLF AEOFECHNLHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(DDIEDIJGOLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public EEMBFJMODEC BPPCACHAAHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(EEMBFJMODEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public PAKLMHHNONJ FCKBDEPIAHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(PAKLMHHNONJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public JNGJNNKAEPL NNJNJPBBEMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(JNGJNNKAEPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public PICCOKOKACB DDLAACCKLOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(PICCOKOKACB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool MKPJLPPJIBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB1A0", Offset = "0x6EFA5A0", VA = "0x186EFB1A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool JAFKNEEOMEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6EFADD0", Offset = "0x6EFA1D0", VA = "0x186EFADD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool CKFALEOJAHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB330", Offset = "0x6EFA730", VA = "0x186EFB330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private bool EPOKKKJHEAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
	public MELHPPJKMHE(AGLPGLMEACF IMMJHCFALCP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6EED9A0", Offset = "0x6EECDA0", VA = "0x186EED9A0")]
	public static bool EGFECENGKHG(MELHPPJKMHE EEPLCHCGAIN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x9AD460", Offset = "0x9AC860", VA = "0x1809AD460")]
	public static AGLPGLMEACF EGFECENGKHG(MELHPPJKMHE EEPLCHCGAIN)
	{
		return default(AGLPGLMEACF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6EF45A0", Offset = "0x6EF39A0", VA = "0x186EF45A0")]
	public static bool LBFMGPFDJNL(MELHPPJKMHE NIPIGODEADI, MELHPPJKMHE BCMPBHCEGGA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6EECCE0", Offset = "0x6EEC0E0", VA = "0x186EECCE0")]
	public static bool CJIGOGHINMG(MELHPPJKMHE NIPIGODEADI, MELHPPJKMHE BCMPBHCEGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6EFAF80", Offset = "0x6EFA380", VA = "0x186EFAF80", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(MELHPPJKMHE KNLMODPGFOA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x9AD460", Offset = "0x9AC860", VA = "0x1809AD460")]
	public static MELHPPJKMHE EGFECENGKHG(AGLPGLMEACF KDHECHILKME)
	{
		return default(MELHPPJKMHE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB5F0", Offset = "0x6EFA9F0", VA = "0x186EFB5F0")]
	public GPKIBOOCFEJ PGDDIJOOJHM()
	{
		return default(GPKIBOOCFEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6EFAE10", Offset = "0x6EFA210", VA = "0x186EFAE10")]
	public HDJKLJOJNMC AMDKNKJHMMD()
	{
		return default(HDJKLJOJNMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB4E0", Offset = "0x6EFA8E0", VA = "0x186EFB4E0")]
	public JAIHHELCJDI NPAMPJEOLFG()
	{
		return default(JAIHHELCJDI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB390", Offset = "0x6EFA790", VA = "0x186EFB390")]
	public GNPBMIEDHEF HKKGEKACLIM()
	{
		return default(GNPBMIEDHEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB290", Offset = "0x6EFA690", VA = "0x186EFB290")]
	public void GAIGFBPDAAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB670", Offset = "0x6EFAA70", VA = "0x186EFB670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct LPIPPBACIOB : IEquatable<LPIPPBACIOB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public AGLPGLMEACF DGDENOKALKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(AGLPGLMEACF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private LKGAMHHAMKI FBMKFDLJDAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC6E0", Offset = "0x6EEBAE0", VA = "0x186EEC6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private EDFLPHOAHJN ODGMLGNBCNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9330", Offset = "0x6EF8730", VA = "0x186EF9330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private CDNMCPCLAEP IHCJNCGPBHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6EF94E0", Offset = "0x6EF88E0", VA = "0x186EF94E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool AOGPNDPOBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x6EF98A0", Offset = "0x6EF8CA0", VA = "0x186EF98A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Guid MBAEGOGEMFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x6EF99D0", Offset = "0x6EF8DD0", VA = "0x186EF99D0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool GPEGBMNHPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6EF96F0", Offset = "0x6EF8AF0", VA = "0x186EF96F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Guid FLFAKIMCFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9780", Offset = "0x6EF8B80", VA = "0x186EF9780")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
	public LPIPPBACIOB(AGLPGLMEACF IMMJHCFALCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9540", Offset = "0x6EF8940", VA = "0x186EF9540", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(LPIPPBACIOB KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9930", Offset = "0x6EF8D30", VA = "0x186EF9930")]
	public bool OJEALIINFBK([Out] Guid HANIKMKPJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6EF95D0", Offset = "0x6EF89D0", VA = "0x186EF95D0")]
	public void FCJCGCAEAIJ(Guid OAKJBMEGCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9AF0", Offset = "0x6EF8EF0", VA = "0x186EF9AF0")]
	public bool PGIOJICBJCI([Out] Guid BBANEDNDONM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6EF93C0", Offset = "0x6EF87C0", VA = "0x186EF93C0")]
	public void EFHAIAAJGOK(Guid OAKJBMEGCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6EF92A0", Offset = "0x6EF86A0", VA = "0x186EF92A0")]
	public void AKBHHCNMPPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct JAIHHELCJDI : IEquatable<JAIHHELCJDI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public AGLPGLMEACF DGDENOKALKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(AGLPGLMEACF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private LKGAMHHAMKI FBMKFDLJDAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC6E0", Offset = "0x6EEBAE0", VA = "0x186EEC6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private EDFLPHOAHJN ODGMLGNBCNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7640", Offset = "0x6EF6A40", VA = "0x186EF7640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private HJAHHCBGNIN KEHDKIPGADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6EF79B0", Offset = "0x6EF6DB0", VA = "0x186EF79B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public Vector3 MHHEOCNDKAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7C70", Offset = "0x6EF7070", VA = "0x186EF7C70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public Quaternion GBNGDHFLBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7500", Offset = "0x6EF6900", VA = "0x186EF7500")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public MELHPPJKMHE GJBGBLDDALN
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7920", Offset = "0x6EF6D20", VA = "0x186EF7920")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
	public JAIHHELCJDI(AGLPGLMEACF IMMJHCFALCP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6EED9A0", Offset = "0x6EECDA0", VA = "0x186EED9A0")]
	public static bool EGFECENGKHG(JAIHHELCJDI EEPLCHCGAIN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x9AD460", Offset = "0x9AC860", VA = "0x1809AD460")]
	public static AGLPGLMEACF EGFECENGKHG(JAIHHELCJDI EEPLCHCGAIN)
	{
		return default(AGLPGLMEACF);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6EF76D0", Offset = "0x6EF6AD0", VA = "0x186EF76D0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(JAIHHELCJDI KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6EF7A10", Offset = "0x6EF6E10", VA = "0x186EF7A10")]
	public void OILKJFPJAKD(Vector3 CLHMEGFDOKF, Quaternion MDJOMEFJFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6EF7B60", Offset = "0x6EF6F60", VA = "0x186EF7B60")]
	public void OMHMEICDLPM(float KFNOLBCIBOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6EF7760", Offset = "0x6EF6B60", VA = "0x186EF7760")]
	public void FOCLHKEAFGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct GPKIBOOCFEJ : IEquatable<GPKIBOOCFEJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly GPKIBOOCFEJ BEKACKLLBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public AGLPGLMEACF DGDENOKALKM
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(AGLPGLMEACF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public PMJAPJOPPAD BDJMNGJGEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(PMJAPJOPPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public OEKKEIIFBLP KHJCAJHAJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(OEKKEIIFBLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private LKGAMHHAMKI FBMKFDLJDAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC6E0", Offset = "0x6EEBAE0", VA = "0x186EEC6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	private EDFLPHOAHJN ODGMLGNBCNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6EF34D0", Offset = "0x6EF28D0", VA = "0x186EF34D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	private IJHAGBMDOFM NOGGPBACBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6EF44D0", Offset = "0x6EF38D0", VA = "0x186EF44D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public BLJMICDPKDA IMHBDFMHPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x6EF32C0", Offset = "0x6EF26C0", VA = "0x186EF32C0")]
		get
		{
			return default(BLJMICDPKDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public IEnumerable<MELHPPJKMHE> BGJNHCEFIII
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6EF47F0", Offset = "0x6EF3BF0", VA = "0x186EF47F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public IEnumerable<MELHPPJKMHE> OHNHEBDGPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6EF31A0", Offset = "0x6EF25A0", VA = "0x186EF31A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public int JLNMICMFDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4680", Offset = "0x6EF3A80", VA = "0x186EF4680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public int NPMIIHNNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4200", Offset = "0x6EF3600", VA = "0x186EF4200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public string ICAKBBAJKAF
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4330", Offset = "0x6EF3730", VA = "0x186EF4330")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4150", Offset = "0x6EF3550", VA = "0x186EF4150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public PAJDJEAGPFE BJGFOEDIBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4950", Offset = "0x6EF3D50", VA = "0x186EF4950")]
		get
		{
			return default(PAJDJEAGPFE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4610", Offset = "0x6EF3A10", VA = "0x186EF4610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public BBLMHHAIGHF ECDJOOAIFNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3140", Offset = "0x6EF2540", VA = "0x186EF3140")]
		get
		{
			return default(BBLMHHAIGHF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4780", Offset = "0x6EF3B80", VA = "0x186EF4780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public JONOJMMHPMA BICJIMLDCKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x6EF45B0", Offset = "0x6EF39B0", VA = "0x186EF45B0")]
		get
		{
			return default(JONOJMMHPMA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6EF42C0", Offset = "0x6EF36C0", VA = "0x186EF42C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public float HBMIEJPCGKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6EF49B0", Offset = "0x6EF3DB0", VA = "0x186EF49B0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3380", Offset = "0x6EF2780", VA = "0x186EF3380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool OAKEJNIKKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6EF33F0", Offset = "0x6EF27F0", VA = "0x186EF33F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool FPBNFDOLCBO
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4250", Offset = "0x6EF3650", VA = "0x186EF4250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool BMIGKGKKPNA
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4A10", Offset = "0x6EF3E10", VA = "0x186EF4A10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool DMGBGICDAEA
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4710", Offset = "0x6EF3B10", VA = "0x186EF4710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool IDJDOAIAEOC
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3A80", Offset = "0x6EF2E80", VA = "0x186EF3A80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF43E0", Offset = "0x6EF37E0", VA = "0x186EF43E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool IBFAOPODAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x6EF30E0", Offset = "0x6EF24E0", VA = "0x186EF30E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3460", Offset = "0x6EF2860", VA = "0x186EF3460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
	public GPKIBOOCFEJ(AGLPGLMEACF IMMJHCFALCP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6EED9A0", Offset = "0x6EECDA0", VA = "0x186EED9A0")]
	public static bool EGFECENGKHG(GPKIBOOCFEJ EEPLCHCGAIN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6EF45A0", Offset = "0x6EF39A0", VA = "0x186EF45A0")]
	public static bool LBFMGPFDJNL(GPKIBOOCFEJ NIPIGODEADI, GPKIBOOCFEJ BCMPBHCEGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6EF40C0", Offset = "0x6EF34C0", VA = "0x186EF40C0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(GPKIBOOCFEJ KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x9AD460", Offset = "0x9AC860", VA = "0x1809AD460")]
	public static MELHPPJKMHE EGFECENGKHG(GPKIBOOCFEJ MCPMOAEEEOJ)
	{
		return default(MELHPPJKMHE);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6EF40A0", Offset = "0x6EF34A0", VA = "0x186EF40A0")]
	public bool EPLFBEFIJGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6EF4530", Offset = "0x6EF3930", VA = "0x186EF4530")]
	public bool LBFCNKIOCKJ(MHPNLKALAJE JAMIELGGKLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6EF4450", Offset = "0x6EF3850", VA = "0x186EF4450")]
	public void JLFANAGEGPD(MHPNLKALAJE JAMIELGGKLH, bool EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6EF3560", Offset = "0x6EF2960", VA = "0x186EF3560")]
	public BLJMICDPKDA DPANLJMNDAO(Allocator HPLNAKONHEI)
	{
		return default(BLJMICDPKDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6EF3710", Offset = "0x6EF2B10", VA = "0x186EF3710")]
	public void DPMKGPADEJL(GPKIBOOCFEJ KNLMODPGFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6EF3AE0", Offset = "0x6EF2EE0", VA = "0x186EF3AE0")]
	public void EONPJCKBBAE(List<MELHPPJKMHE> MDGEJMLDPEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct COIPJCOKDMM : IEquatable<COIPJCOKDMM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6EEF770", Offset = "0x6EEEB70", VA = "0x186EEF770", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(COIPJCOKDMM KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct DMOJHJNFFFB : IEquatable<DMOJHJNFFFB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private LKGAMHHAMKI FBMKFDLJDAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC6E0", Offset = "0x6EEBAE0", VA = "0x186EEC6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
	public DMOJHJNFFFB(AGLPGLMEACF IMMJHCFALCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0520", Offset = "0x6EEF920", VA = "0x186EF0520", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(DMOJHJNFFFB KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6EF05B0", Offset = "0x6EEF9B0", VA = "0x186EF05B0")]
	public void KJDEEDGEPIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6EF06F0", Offset = "0x6EEFAF0", VA = "0x186EF06F0")]
	public void POJCOBBDMHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0650", Offset = "0x6EEFA50", VA = "0x186EF0650")]
	public bool LBEDGJHPDEO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct OEKKEIIFBLP : IEquatable<OEKKEIIFBLP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public AGLPGLMEACF DGDENOKALKM
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(AGLPGLMEACF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private LKGAMHHAMKI FBMKFDLJDAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC6E0", Offset = "0x6EEBAE0", VA = "0x186EEC6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private EDFLPHOAHJN ODGMLGNBCNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC570", Offset = "0x6EFB970", VA = "0x186EFC570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private IJHAGBMDOFM NOGGPBACBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6EFCB30", Offset = "0x6EFBF30", VA = "0x186EFCB30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public AGLPGLMEACF DOJPJLHJIJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC200", Offset = "0x6EFB600", VA = "0x186EFC200")]
		get
		{
			return default(AGLPGLMEACF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public MELHPPJKMHE CNLABKPDMID
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC690", Offset = "0x6EFBA90", VA = "0x186EFC690")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public MELHPPJKMHE PAGLAEHKACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC720", Offset = "0x6EFBB20", VA = "0x186EFC720")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
	public OEKKEIIFBLP(AGLPGLMEACF IMMJHCFALCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6EFC600", Offset = "0x6EFBA00", VA = "0x186EFC600", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(OEKKEIIFBLP KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6EFC7B0", Offset = "0x6EFBBB0", VA = "0x186EFC7B0")]
	public bool HGECDLHOFAC(MELHPPJKMHE DEDHJMDEEIE, bool JMAGNKLOJMN = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6EFC8E0", Offset = "0x6EFBCE0", VA = "0x186EFC8E0")]
	public bool HJNJHKBAOBC(MELHPPJKMHE NLHLJAMHHNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x6EFC2F0", Offset = "0x6EFB6F0", VA = "0x186EFC2F0")]
	private void DGCFMFMEPLM(MELHPPJKMHE EPCKEHONBCD, List<MELHPPJKMHE> KHJLEPCJHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6EFCAA0", Offset = "0x6EFBEA0", VA = "0x186EFCAA0")]
	public GPKIBOOCFEJ JDAPFCNLEHG()
	{
		return default(GPKIBOOCFEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6EFC290", Offset = "0x6EFB690", VA = "0x186EFC290")]
	public void DEEDPNMAGBC(List<MELHPPJKMHE> NDOGNIKHHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6EFC980", Offset = "0x6EFBD80", VA = "0x186EFC980")]
	public NativeArray<AGLPGLMEACF> IPNEHGLJOLL()
	{
		return default(NativeArray<AGLPGLMEACF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct EEOGOEOEKHO : IEquatable<EEOGOEOEKHO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public string NCDEOLGHIJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6EF1660", Offset = "0x6EF0A60", VA = "0x186EF1660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public string GJJDAHIAGNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6EF17D0", Offset = "0x6EF0BD0", VA = "0x186EF17D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private bool PIPLOLONCFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6EF1890", Offset = "0x6EF0C90", VA = "0x186EF1890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public string MBDJHIOCEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6EF16E0", Offset = "0x6EF0AE0", VA = "0x186EF16E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public string JOLHNIPOBMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6EF1AC0", Offset = "0x6EF0EC0", VA = "0x186EF1AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public string JGDBDEGDGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6EF19D0", Offset = "0x6EF0DD0", VA = "0x186EF19D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
	public EEOGOEOEKHO(AGLPGLMEACF IMMJHCFALCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x6EF15D0", Offset = "0x6EF09D0", VA = "0x186EF15D0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(EEOGOEOEKHO KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct PAKLMHHNONJ : IEquatable<PAKLMHHNONJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private LKGAMHHAMKI FBMKFDLJDAK
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC6E0", Offset = "0x6EEBAE0", VA = "0x186EEC6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private EDFLPHOAHJN ODGMLGNBCNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6EFCD10", Offset = "0x6EFC110", VA = "0x186EFCD10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private KJPFHAMOGGG IBKKELNMBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6EFCC20", Offset = "0x6EFC020", VA = "0x186EFCC20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public JANMPMPNNNK LPFJGOAOLEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6EFD000", Offset = "0x6EFC400", VA = "0x186EFD000")]
		get
		{
			return default(JANMPMPNNNK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6EFD100", Offset = "0x6EFC500", VA = "0x186EFD100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool KJKKDOGCGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6EFD480", Offset = "0x6EFC880", VA = "0x186EFD480")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6EFD3E0", Offset = "0x6EFC7E0", VA = "0x186EFD3E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public string[] HMDBKKPEFNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6EFCC80", Offset = "0x6EFC080", VA = "0x186EFCC80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6EFD2A0", Offset = "0x6EFC6A0", VA = "0x186EFD2A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public string[] MNHMONOMGFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6EFCED0", Offset = "0x6EFC2D0", VA = "0x186EFCED0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x6EFCDA0", Offset = "0x6EFC1A0", VA = "0x186EFCDA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public string[] FPMFKLMCMLN
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6EFCB90", Offset = "0x6EFBF90", VA = "0x186EFCB90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6EFD340", Offset = "0x6EFC740", VA = "0x186EFD340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public string[] KBHDICMMBBC
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6EFD210", Offset = "0x6EFC610", VA = "0x186EFD210")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6EFCF60", Offset = "0x6EFC360", VA = "0x186EFCF60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
	public PAKLMHHNONJ(AGLPGLMEACF IMMJHCFALCP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x9AD460", Offset = "0x9AC860", VA = "0x1809AD460")]
	public static AGLPGLMEACF EGFECENGKHG(PAKLMHHNONJ EEPLCHCGAIN)
	{
		return default(AGLPGLMEACF);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x6EFCE40", Offset = "0x6EFC240", VA = "0x186EFCE40", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(PAKLMHHNONJ KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6EFD510", Offset = "0x6EFC910", VA = "0x186EFD510")]
	public bool NIBBIBIAAMO(AGLPGLMEACF PEIJBHPINLD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct IOIEGJGPLBA : IEquatable<IOIEGJGPLBA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6EF72C0", Offset = "0x6EF66C0", VA = "0x186EF72C0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(IOIEGJGPLBA KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct CDKNIABHDKE : IEquatable<CDKNIABHDKE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
	public CDKNIABHDKE(AGLPGLMEACF IMMJHCFALCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6EEF4A0", Offset = "0x6EEE8A0", VA = "0x186EEF4A0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(CDKNIABHDKE KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6EEF340", Offset = "0x6EEE740", VA = "0x186EEF340")]
	public bool CICGHDGOHDJ([Out] Collider BHILPBPJHNM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct GNPBMIEDHEF : IEquatable<GNPBMIEDHEF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public AGLPGLMEACF DGDENOKALKM
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(AGLPGLMEACF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	private MakerPenHeldDataWrapper LKBLJIKCCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2F80", Offset = "0x6EF2380", VA = "0x186EF2F80")]
		get
		{
			return default(MakerPenHeldDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public bool APGBDCFGNIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2FE0", Offset = "0x6EF23E0", VA = "0x186EF2FE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
	public GNPBMIEDHEF(AGLPGLMEACF IMMJHCFALCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6EF3050", Offset = "0x6EF2450", VA = "0x186EF3050", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(GNPBMIEDHEF KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct DDIEDIJGOLF : IEquatable<DDIEDIJGOLF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public AGLPGLMEACF DGDENOKALKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(AGLPGLMEACF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private LKGAMHHAMKI FBMKFDLJDAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC6E0", Offset = "0x6EEBAE0", VA = "0x186EEC6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private EDFLPHOAHJN ODGMLGNBCNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6EEF800", Offset = "0x6EEEC00", VA = "0x186EEF800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	private OBONOIPFGME JLBJJLEJLPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6EEF9C0", Offset = "0x6EEEDC0", VA = "0x186EEF9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
	public DDIEDIJGOLF(AGLPGLMEACF IMMJHCFALCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6EEF890", Offset = "0x6EEEC90", VA = "0x186EEF890", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(DDIEDIJGOLF KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6EEF920", Offset = "0x6EEED20", VA = "0x186EEF920")]
	public void KFCBACHOHLD(bool NHGPHFBFMLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct MADAFJJEKKB : IEquatable<MADAFJJEKKB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public AGLPGLMEACF DGDENOKALKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(AGLPGLMEACF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	private LKGAMHHAMKI FBMKFDLJDAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC6E0", Offset = "0x6EEBAE0", VA = "0x186EEC6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	private EDFLPHOAHJN ODGMLGNBCNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA180", Offset = "0x6EF9580", VA = "0x186EFA180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	private ObjectPolicyDataWrapper AHDJCNFKKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9FE0", Offset = "0x6EF93E0", VA = "0x186EF9FE0")]
		get
		{
			return default(ObjectPolicyDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	private NavMeshGenerationDataWrapper JLCFMANPOBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAA70", Offset = "0x6EF9E70", VA = "0x186EFAA70")]
		get
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool DFOHJJNLOOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAA30", Offset = "0x6EF9E30", VA = "0x186EFAA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public bool OMHOFOFKCMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA960", Offset = "0x6EF9D60", VA = "0x186EFA960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public bool GCHKHNPKJFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA760", Offset = "0x6EF9B60", VA = "0x186EFA760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public bool MDMJIJPAPIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA620", Offset = "0x6EF9A20", VA = "0x186EFA620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public bool FHAONBJNBPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA6F0", Offset = "0x6EF9AF0", VA = "0x186EFA6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public bool DMOIHJFGDCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x6EFABA0", Offset = "0x6EF9FA0", VA = "0x186EFABA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool APAFNADJOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA7D0", Offset = "0x6EF9BD0", VA = "0x186EFA7D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool OKJMJGGGIPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA0B0", Offset = "0x6EF94B0", VA = "0x186EFA0B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool MDDHMHOMIIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA040", Offset = "0x6EF9440", VA = "0x186EFA040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool ICIKFBCIBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA210", Offset = "0x6EF9610", VA = "0x186EFA210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool NPMEPPKCPLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9F70", Offset = "0x6EF9370", VA = "0x186EF9F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool FBJBIKEJNPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAC10", Offset = "0x6EFA010", VA = "0x186EFAC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool BPDDHFJNLLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAAD0", Offset = "0x6EF9ED0", VA = "0x186EFAAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool AOGGOFABLDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9F10", Offset = "0x6EF9310", VA = "0x186EF9F10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9CC0", Offset = "0x6EF90C0", VA = "0x186EF9CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public AMKIIAGJEOD GFJINPGCGGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9C60", Offset = "0x6EF9060", VA = "0x186EF9C60")]
		get
		{
			return default(AMKIIAGJEOD);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAB30", Offset = "0x6EF9F30", VA = "0x186EFAB30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public bool ACONALDEMMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA280", Offset = "0x6EF9680", VA = "0x186EFA280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public GLBDCLACINM LGHNEDMPJLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA9D0", Offset = "0x6EF9DD0", VA = "0x186EFA9D0")]
		get
		{
			return default(GLBDCLACINM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public bool HONOGECKHFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA120", Offset = "0x6EF9520", VA = "0x186EFA120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Vector3 BDGLGOHAAPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA560", Offset = "0x6EF9960", VA = "0x186EFA560")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Vector3 MOBHNMBMLOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA8B0", Offset = "0x6EF9CB0", VA = "0x186EFA8B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public bool AGCKGDLAGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9E10", Offset = "0x6EF9210", VA = "0x186EF9E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
	public MADAFJJEKKB(AGLPGLMEACF IMMJHCFALCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA4D0", Offset = "0x6EF98D0", VA = "0x186EFA4D0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(MADAFJJEKKB KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA840", Offset = "0x6EF9C40", VA = "0x186EFA840")]
	public bool MJNOCHPFBDI(LPOGPOIKIFG JAMIELGGKLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9D30", Offset = "0x6EF9130", VA = "0x186EF9D30")]
	public bool AGKHNJJKMCE(IABBENFALKI JAMIELGGKLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA450", Offset = "0x6EF9850", VA = "0x186EFA450")]
	public void EFBNAGMNNDB(IABBENFALKI JAMIELGGKLH, bool JFIONMMANLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA690", Offset = "0x6EF9A90", VA = "0x186EFA690")]
	public IABBENFALKI GPFNAAMCJIK()
	{
		return default(IABBENFALKI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9DA0", Offset = "0x6EF91A0", VA = "0x186EF9DA0")]
	public bool BDGDGJJFJKM(IABBENFALKI EEPLCHCGAIN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct EEMBFJMODEC : IEquatable<EEMBFJMODEC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	private LKGAMHHAMKI FBMKFDLJDAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC6E0", Offset = "0x6EEBAE0", VA = "0x186EEC6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private EDFLPHOAHJN ODGMLGNBCNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0DF0", Offset = "0x6EF01F0", VA = "0x186EF0DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private EICDJHOMJEC DAODIBHGMPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x6EF10F0", Offset = "0x6EF04F0", VA = "0x186EF10F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
	public EEMBFJMODEC(AGLPGLMEACF IMMJHCFALCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0FB0", Offset = "0x6EF03B0", VA = "0x186EF0FB0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(EEMBFJMODEC KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0CC0", Offset = "0x6EF00C0", VA = "0x186EF0CC0")]
	public bool DEKPNKAFCOI(ABCKHNEHFAE KEKHLMMPMLO, List<MELHPPJKMHE> MDGEJMLDPEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0B00", Offset = "0x6EEFF00", VA = "0x186EF0B00")]
	public int ALNKFKLALCF(ABCKHNEHFAE KEKHLMMPMLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6EF13B0", Offset = "0x6EF07B0", VA = "0x186EF13B0")]
	public void POCHJDOFPAI(List<MELHPPJKMHE> MDGEJMLDPEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0E80", Offset = "0x6EF0280", VA = "0x186EF0E80")]
	public int EDNOBGFMLLB(MELHPPJKMHE KDGMCPCFIID, ABCKHNEHFAE KEKHLMMPMLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6EF1280", Offset = "0x6EF0680", VA = "0x186EF1280")]
	public MELHPPJKMHE OFMLIHECHBJ(int HAJICDLBEKC, ABCKHNEHFAE KEKHLMMPMLO)
	{
		return default(MELHPPJKMHE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6EF1150", Offset = "0x6EF0550", VA = "0x186EF1150")]
	public void NKLAEFEPCCP(MELHPPJKMHE KDGMCPCFIID, ABCKHNEHFAE KEKHLMMPMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x6EF1040", Offset = "0x6EF0440", VA = "0x186EF1040")]
	public bool MCFCIOFFNGJ(MELHPPJKMHE KDGMCPCFIID, ABCKHNEHFAE KEKHLMMPMLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6EF14C0", Offset = "0x6EF08C0", VA = "0x186EF14C0")]
	public void PPNCONCNLIJ(ABCKHNEHFAE KEKHLMMPMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0C10", Offset = "0x6EF0010", VA = "0x186EF0C10")]
	public bool BEICFCAEDNG(MELHPPJKMHE KDGMCPCFIID, ABCKHNEHFAE KEKHLMMPMLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6EF09F0", Offset = "0x6EEFDF0", VA = "0x186EF09F0")]
	public bool ACBBFJBEJFP(ABCKHNEHFAE KEKHLMMPMLO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public readonly struct ACMFIGHEFHB : IEquatable<ACMFIGHEFHB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public AGLPGLMEACF DGDENOKALKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(AGLPGLMEACF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	private LKGAMHHAMKI FBMKFDLJDAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC6E0", Offset = "0x6EEBAE0", VA = "0x186EEC6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private EDFLPHOAHJN ODGMLGNBCNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC740", Offset = "0x6EEBB40", VA = "0x186EEC740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
	public ACMFIGHEFHB(AGLPGLMEACF IMMJHCFALCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC870", Offset = "0x6EEBC70", VA = "0x186EEC870", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(ACMFIGHEFHB KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC930", Offset = "0x6EEBD30", VA = "0x186EEC930")]
	public void IGJAILKDKIA(bool EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC7D0", Offset = "0x6EEBBD0", VA = "0x186EEC7D0")]
	public void EBECJPIKOCB(bool EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x357F640", Offset = "0x357EA40", VA = "0x18357F640")]
	public T OBHBEBEJPBP<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct JNGJNNKAEPL : IEquatable<JNGJNNKAEPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public AGLPGLMEACF DGDENOKALKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(AGLPGLMEACF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private LKGAMHHAMKI FBMKFDLJDAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC6E0", Offset = "0x6EEBAE0", VA = "0x186EEC6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private EDFLPHOAHJN ODGMLGNBCNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8270", Offset = "0x6EF7670", VA = "0x186EF8270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private ODMBJEACHDK CJNOMDEGBAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8210", Offset = "0x6EF7610", VA = "0x186EF8210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool FPJJHFAONHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8420", Offset = "0x6EF7820", VA = "0x186EF8420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public bool NHDMAJHAJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8300", Offset = "0x6EF7700", VA = "0x186EF8300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
	public JNGJNNKAEPL(AGLPGLMEACF IMMJHCFALCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8390", Offset = "0x6EF7790", VA = "0x186EF8390", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(JNGJNNKAEPL KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct HNBLNBMNJEH : IEquatable<HNBLNBMNJEH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6EF56F0", Offset = "0x6EF4AF0", VA = "0x186EF56F0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(HNBLNBMNJEH KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct AIMOFFKPKBJ : IEquatable<AIMOFFKPKBJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public AGLPGLMEACF DGDENOKALKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(AGLPGLMEACF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private LKGAMHHAMKI FBMKFDLJDAK
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC6E0", Offset = "0x6EEBAE0", VA = "0x186EEC6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	private EDFLPHOAHJN ODGMLGNBCNI
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x6EED910", Offset = "0x6EECD10", VA = "0x186EED910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	private JKJHEMKEGLM GEKFIFPBEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x6EEDA80", Offset = "0x6EECE80", VA = "0x186EEDA80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	private GNKOLMGLLIA DDEAHMBHMAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x6EED770", Offset = "0x6EECB70", VA = "0x186EED770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool FPGIKIJPBDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x6EED570", Offset = "0x6EEC970", VA = "0x186EED570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool APPOFKPNNIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x6EEDB80", Offset = "0x6EECF80", VA = "0x186EEDB80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool MALKJFAELLH
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6EED8E0", Offset = "0x6EECCE0", VA = "0x186EED8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public bool GCFDEJJMMKL
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x6EEE180", Offset = "0x6EED580", VA = "0x186EEE180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public bool DKMIKFJFMCE
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x6EED9C0", Offset = "0x6EECDC0", VA = "0x186EED9C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool EJIIDCAJEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x6EEDFE0", Offset = "0x6EED3E0", VA = "0x186EEDFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public bool KEIGPEPIHHH
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x6EEDC90", Offset = "0x6EED090", VA = "0x186EEDC90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public bool MNGABKOAOBB
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x6EED600", Offset = "0x6EECA00", VA = "0x186EED600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
	public AIMOFFKPKBJ(AGLPGLMEACF IMMJHCFALCP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6EED9A0", Offset = "0x6EECDA0", VA = "0x186EED9A0")]
	public static bool EGFECENGKHG(AIMOFFKPKBJ EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x6EED9F0", Offset = "0x6EECDF0", VA = "0x186EED9F0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(AIMOFFKPKBJ KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6EEDC20", Offset = "0x6EED020", VA = "0x186EEDC20")]
	public bool LNOLFNGPFIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x6EEDEA0", Offset = "0x6EED2A0", VA = "0x186EEDEA0")]
	public MELHPPJKMHE MEKJHEINJPE(MELHPPJKMHE KDGMCPCFIID)
	{
		return default(MELHPPJKMHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x6EED7D0", Offset = "0x6EECBD0", VA = "0x186EED7D0")]
	public AGLPGLMEACF DBGAFOCNAOE()
	{
		return default(AGLPGLMEACF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6EEDAE0", Offset = "0x6EECEE0", VA = "0x186EEDAE0")]
	public bool HAPDOOJHCHP(AGLPGLMEACF FHEJNGEAHJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x6EEDF40", Offset = "0x6EED340", VA = "0x186EEDF40")]
	public bool MJEDDCMNOJI(AGLPGLMEACF BGCIDFKJJIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x6EEE070", Offset = "0x6EED470", VA = "0x186EEE070")]
	public bool PAOEALHIEAF(AGLPGLMEACF KDGMCPCFIID, [Out] AGLPGLMEACF FHEJNGEAHJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct HDJKLJOJNMC : IEquatable<HDJKLJOJNMC>
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly HDJKLJOJNMC BEKACKLLBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public AGLPGLMEACF DGDENOKALKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(AGLPGLMEACF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public PMJAPJOPPAD BDJMNGJGEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(PMJAPJOPPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public OEKKEIIFBLP KHJCAJHAJIN
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(OEKKEIIFBLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private ShapeTypeDataWrapper BEOGAKEIAGK
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4D30", Offset = "0x6EF4130", VA = "0x186EF4D30")]
		get
		{
			return default(ShapeTypeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public StandardRenderableVisualDataWrapper JOCLGMCOECO
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF50A0", Offset = "0x6EF44A0", VA = "0x186EF50A0")]
		get
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public PhysicsMaterialDataWrapper JJKGPCKPLFB
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4E00", Offset = "0x6EF4200", VA = "0x186EF4E00")]
		get
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public ShapeConfigDataWrapper ICDLMMOFOCH
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5100", Offset = "0x6EF4500", VA = "0x186EF5100")]
		get
		{
			return default(ShapeConfigDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public CMDJAGMILPH LAFOPNPPIHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4D90", Offset = "0x6EF4190", VA = "0x186EF4D90")]
		get
		{
			return default(CMDJAGMILPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public OOAFHLAGGAO BFHKACAHKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5040", Offset = "0x6EF4440", VA = "0x186EF5040")]
		get
		{
			return default(OOAFHLAGGAO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x6EF51D0", Offset = "0x6EF45D0", VA = "0x186EF51D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public DPKEFKKOFKL DLKIFPPKHGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4C00", Offset = "0x6EF4000", VA = "0x186EF4C00")]
		get
		{
			return default(DPKEFKKOFKL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4C60", Offset = "0x6EF4060", VA = "0x186EF4C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public float HIKGFOGMGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4FE0", Offset = "0x6EF43E0", VA = "0x186EF4FE0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5160", Offset = "0x6EF4560", VA = "0x186EF5160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public Vector3 IBCGFHOBCNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5240", Offset = "0x6EF4640", VA = "0x186EF5240")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x6EF53D0", Offset = "0x6EF47D0", VA = "0x186EF53D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public float MOIBPJDHPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x6EF52E0", Offset = "0x6EF46E0", VA = "0x186EF52E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public CGGBFCFFEOG KNBDODCCBKN
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4CD0", Offset = "0x6EF40D0", VA = "0x186EF4CD0")]
		get
		{
			return default(CGGBFCFFEOG);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4F70", Offset = "0x6EF4370", VA = "0x186EF4F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
	public HDJKLJOJNMC(AGLPGLMEACF IMMJHCFALCP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6EED9A0", Offset = "0x6EECDA0", VA = "0x186EED9A0")]
	public static bool EGFECENGKHG(HDJKLJOJNMC EEPLCHCGAIN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x6EECCE0", Offset = "0x6EEC0E0", VA = "0x186EECCE0")]
	public static bool CJIGOGHINMG(HDJKLJOJNMC NIPIGODEADI, HDJKLJOJNMC BCMPBHCEGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6EF4E60", Offset = "0x6EF4260", VA = "0x186EF4E60", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(HDJKLJOJNMC KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6EF4EF0", Offset = "0x6EF42F0", VA = "0x186EF4EF0")]
	public MPJMIBFKAFF FGMBOILGJLB()
	{
		return default(MPJMIBFKAFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5350", Offset = "0x6EF4750", VA = "0x186EF5350")]
	public IIDKDMNNOLN OHEFOAPLFFF()
	{
		return default(IIDKDMNNOLN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct MPJMIBFKAFF : IEquatable<MPJMIBFKAFF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public AGLPGLMEACF DGDENOKALKM
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(AGLPGLMEACF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public HDJKLJOJNMC MCBNJHIHCMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(HDJKLJOJNMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private PrimitiveShapeDataWrapper BMLBFMOBHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB9A0", Offset = "0x6EFADA0", VA = "0x186EFB9A0")]
		get
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public KONBFGBHLIN HANLMNGKFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB940", Offset = "0x6EFAD40", VA = "0x186EFB940")]
		get
		{
			return default(KONBFGBHLIN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
	public MPJMIBFKAFF(AGLPGLMEACF IMMJHCFALCP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x6EED9A0", Offset = "0x6EECDA0", VA = "0x186EED9A0")]
	public static bool EGFECENGKHG(MPJMIBFKAFF EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB8B0", Offset = "0x6EFACB0", VA = "0x186EFB8B0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(MPJMIBFKAFF KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DefaultMember("Item")]
public readonly struct IIDKDMNNOLN : IEquatable<IIDKDMNNOLN>
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public static readonly IIDKDMNNOLN BEKACKLLBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public AGLPGLMEACF DGDENOKALKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(AGLPGLMEACF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public PMJAPJOPPAD BDJMNGJGEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(PMJAPJOPPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	private LKGAMHHAMKI FBMKFDLJDAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC6E0", Offset = "0x6EEBAE0", VA = "0x186EEC6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	private EDFLPHOAHJN ODGMLGNBCNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x6EF65F0", Offset = "0x6EF59F0", VA = "0x186EF65F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	private HPIODHHBGKA EJPMNFKECPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7260", Offset = "0x6EF6660", VA = "0x186EF7260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public HDJKLJOJNMC MCBNJHIHCMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(HDJKLJOJNMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public DJEOIECAKFK CFCCCEBJJOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6C10", Offset = "0x6EF6010", VA = "0x186EF6C10")]
		get
		{
			return default(DJEOIECAKFK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6A50", Offset = "0x6EF5E50", VA = "0x186EF6A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public IEnumerable<OCDLILHIKGO> EIOGOABIADL
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6D30", Offset = "0x6EF6130", VA = "0x186EF6D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public OCDLILHIKGO MGACFGHHFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7150", Offset = "0x6EF6550", VA = "0x186EF7150")]
		get
		{
			return default(OCDLILHIKGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6930", Offset = "0x6EF5D30", VA = "0x186EF6930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
	public IIDKDMNNOLN(AGLPGLMEACF IMMJHCFALCP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x6EED9A0", Offset = "0x6EECDA0", VA = "0x186EED9A0")]
	public static bool EGFECENGKHG(IIDKDMNNOLN EEPLCHCGAIN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x6EF45A0", Offset = "0x6EF39A0", VA = "0x186EF45A0")]
	public static bool LBFMGPFDJNL(IIDKDMNNOLN NIPIGODEADI, IIDKDMNNOLN BCMPBHCEGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x6EF68A0", Offset = "0x6EF5CA0", VA = "0x186EF68A0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(IIDKDMNNOLN KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x6EF6680", Offset = "0x6EF5A80", VA = "0x186EF6680")]
	public OCDLILHIKGO EBIPGPONPOF(float3? CLHMEGFDOKF, [Optional] quaternion? MDJOMEFJFHD, [Optional] Vector3? KFNOLBCIBOH)
	{
		return default(OCDLILHIKGO);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x6EF6F20", Offset = "0x6EF6320", VA = "0x186EF6F20")]
	public OCDLILHIKGO OPILHCAGHCE(int HAJICDLBEKC, float3? CLHMEGFDOKF, [Optional] quaternion? MDJOMEFJFHD, [Optional] Vector3? KFNOLBCIBOH)
	{
		return default(OCDLILHIKGO);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x6EF6B70", Offset = "0x6EF5F70", VA = "0x186EF6B70")]
	public void NFGGCLAOHHC(int HAJICDLBEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x6EF69C0", Offset = "0x6EF5DC0", VA = "0x186EF69C0")]
	public void KMNEPMPOIBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct OCDLILHIKGO : IEquatable<OCDLILHIKGO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public AGLPGLMEACF DGDENOKALKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(AGLPGLMEACF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public IIDKDMNNOLN ANNGMBIJKAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x6EFBE60", Offset = "0x6EFB260", VA = "0x186EFBE60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public float3 ADKILKCAHGF
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x6EFBF70", Offset = "0x6EFB370", VA = "0x186EFBF70")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x6EFBD60", Offset = "0x6EFB160", VA = "0x186EFBD60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public quaternion CKEEBDBDPCG
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x6EFBEF0", Offset = "0x6EFB2F0", VA = "0x186EFBEF0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC190", Offset = "0x6EFB590", VA = "0x186EFC190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public float3 JLEAGKPIDLL
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC0B0", Offset = "0x6EFB4B0", VA = "0x186EFC0B0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x6EFBDE0", Offset = "0x6EFB1E0", VA = "0x186EFBDE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public EICPCIPDMKM OEPCLOHKPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6EFBC00", Offset = "0x6EFB000", VA = "0x186EFBC00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	private SplinePointParentDataWrapper LMOKOEBGGAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x6EFBFF0", Offset = "0x6EFB3F0", VA = "0x186EFBFF0")]
		get
		{
			return default(SplinePointParentDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private SplinePointPositionDataWrapper OANCCGLDMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC050", Offset = "0x6EFB450", VA = "0x186EFC050")]
		get
		{
			return default(SplinePointPositionDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	private SplinePointRotationDataWrapper GHIKLOACMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x6EFBBA0", Offset = "0x6EFAFA0", VA = "0x186EFBBA0")]
		get
		{
			return default(SplinePointRotationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private SplinePointScaleDataWrapper EBNHPKFDDOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x6EFBC70", Offset = "0x6EFB070", VA = "0x186EFBC70")]
		get
		{
			return default(SplinePointScaleDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private SplinePointOrderDataWrapper KKOILJDODEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC130", Offset = "0x6EFB530", VA = "0x186EFC130")]
		get
		{
			return default(SplinePointOrderDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
	public OCDLILHIKGO(AGLPGLMEACF IMMJHCFALCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x6EFBCD0", Offset = "0x6EFB0D0", VA = "0x186EFBCD0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(OCDLILHIKGO KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x6EFBE60", Offset = "0x6EFB260", VA = "0x186EFBE60")]
	public void IIOMMLHCKAC(IIDKDMNNOLN EEPLCHCGAIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct GGGGNDLKHCK : IEquatable<GGGGNDLKHCK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public AGLPGLMEACF DGDENOKALKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(AGLPGLMEACF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	private LKGAMHHAMKI FBMKFDLJDAK
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC6E0", Offset = "0x6EEBAE0", VA = "0x186EEC6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	private EDFLPHOAHJN ODGMLGNBCNI
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2480", Offset = "0x6EF1880", VA = "0x186EF2480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	private MMMGDABNIKO JDPFEFBBGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2870", Offset = "0x6EF1C70", VA = "0x186EF2870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	private ToolCleanupSettingsDataWrapper DOOOOMMMJAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2A10", Offset = "0x6EF1E10", VA = "0x186EF2A10")]
		get
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public bool NEJLMHNGACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2B40", Offset = "0x6EF1F40", VA = "0x186EF2B40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2AD0", Offset = "0x6EF1ED0", VA = "0x186EF2AD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public bool BOFDJLAACHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2A70", Offset = "0x6EF1E70", VA = "0x186EF2A70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2C40", Offset = "0x6EF2040", VA = "0x186EF2C40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public float OLBDNIIGJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2420", Offset = "0x6EF1820", VA = "0x186EF2420")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2510", Offset = "0x6EF1910", VA = "0x186EF2510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public bool FCMNKCGBIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2E60", Offset = "0x6EF2260", VA = "0x186EF2E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
	public GGGGNDLKHCK(AGLPGLMEACF IMMJHCFALCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x6EF27E0", Offset = "0x6EF1BE0", VA = "0x186EF27E0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(GGGGNDLKHCK KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2CB0", Offset = "0x6EF20B0", VA = "0x186EF2CB0")]
	public void NMLHCANHLHC(int OACLGAKONPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2D50", Offset = "0x6EF2150", VA = "0x186EF2D50")]
	public bool OEPDKFPACBM([Out] int OACLGAKONPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2BA0", Offset = "0x6EF1FA0", VA = "0x186EF2BA0")]
	public void MNHBGMFMBPM(bool BBDFJCNAOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x6EF28D0", Offset = "0x6EF1CD0", VA = "0x186EF28D0")]
	public void KFKBABIDPHF(float KPIMACCLGAK, float IKNEEEKAINH, float HHIKGLJPEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6EF22D0", Offset = "0x6EF16D0", VA = "0x186EF22D0")]
	public void CJEEJJMDBGB(float3 DIJPOANNLAJ, quaternion HICFIDGDIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2580", Offset = "0x6EF1980", VA = "0x186EF2580")]
	public bool EDGEFDNBPEJ([Out] float3 DIJPOANNLAJ, [Out] quaternion HICFIDGDIGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x6EF26B0", Offset = "0x6EF1AB0", VA = "0x186EF26B0")]
	public bool EPOGDCKLCNI([Out] float GMDMIEDBMPI, [Out] float FHGOFCLLJDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct PMJAPJOPPAD : IEquatable<PMJAPJOPPAD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public OEKKEIIFBLP KHJCAJHAJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(OEKKEIIFBLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	private LKGAMHHAMKI FBMKFDLJDAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC6E0", Offset = "0x6EEBAE0", VA = "0x186EEC6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	private BGBCLBMHAOP BNLONMENHHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6EFDF20", Offset = "0x6EFD320", VA = "0x186EFDF20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public bool CPBNHPBDMJN
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x6EFEA60", Offset = "0x6EFDE60", VA = "0x186EFEA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public Vector3 ADKILKCAHGF
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x6EFF270", Offset = "0x6EFE670", VA = "0x186EFF270")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x6EFE3E0", Offset = "0x6EFD7E0", VA = "0x186EFE3E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public Quaternion CKEEBDBDPCG
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x6EFEDB0", Offset = "0x6EFE1B0", VA = "0x186EFEDB0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x6EFF960", Offset = "0x6EFED60", VA = "0x186EFF960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public Vector3 CAOBJIJNKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x6EFF5C0", Offset = "0x6EFE9C0", VA = "0x186EFF5C0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x6EFF050", Offset = "0x6EFE450", VA = "0x186EFF050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public Quaternion LFGAIGMMBCL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x6EFFEE0", Offset = "0x6EFF2E0", VA = "0x186EFFEE0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x6EFDCC0", Offset = "0x6EFD0C0", VA = "0x186EFDCC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public float MKCNLDHEIBG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x6EFE9C0", Offset = "0x6EFDDC0", VA = "0x186EFE9C0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x6EFDFE0", Offset = "0x6EFD3E0", VA = "0x186EFDFE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public float JELEBBONDKP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x6EFF360", Offset = "0x6EFE760", VA = "0x186EFF360")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public Vector3 JLEAGKPIDLL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x6EFF6B0", Offset = "0x6EFEAB0", VA = "0x186EFF6B0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x6EFE4B0", Offset = "0x6EFD8B0", VA = "0x186EFE4B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public Vector3 HOMCPCHHGEA
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x6EFE0D0", Offset = "0x6EFD4D0", VA = "0x186EFE0D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public Matrix4x4 HOFFGBKEFCE
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x6EFE090", Offset = "0x6EFD490", VA = "0x186EFE090")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
	public PMJAPJOPPAD(AGLPGLMEACF IMMJHCFALCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x6EFE350", Offset = "0x6EFD750", VA = "0x186EFE350", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(PMJAPJOPPAD KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x6EFFC00", Offset = "0x6EFF000", VA = "0x186EFFC00")]
	public JGEJFGFHNHJ OPIDFGJBBFD()
	{
		return default(JGEJFGFHNHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6EFFA30", Offset = "0x6EFEE30", VA = "0x186EFFA30")]
	public void NLKFPCOLMLE([Out] Matrix4x4 PDPDNLJIBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6EFE1C0", Offset = "0x6EFD5C0", VA = "0x186EFE1C0")]
	public void DPIHJMAAAEG([Out] Vector3 HMCCMNIBCPP, [Out] Quaternion JEMDJKCPDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6EFE2A0", Offset = "0x6EFD6A0", VA = "0x186EFE2A0")]
	public void DPIHJMAAAEG([Out] RigidTransform MHMCKLPCBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6EFECD0", Offset = "0x6EFE0D0", VA = "0x186EFECD0")]
	public void IKCBLNGIOPP([Out] Vector3 HMCCMNIBCPP, [Out] Quaternion JEMDJKCPDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6EFEC20", Offset = "0x6EFE020", VA = "0x186EFEC20")]
	public void IKCBLNGIOPP([Out] RigidTransform MHMCKLPCBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x6EFF400", Offset = "0x6EFE800", VA = "0x186EFF400")]
	public UniformTRS KANANJEPCEO()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x6EFF430", Offset = "0x6EFE830", VA = "0x186EFF430")]
	public void KANANJEPCEO([Out] UniformTRS DGLIIEKJOKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x6EFFEB0", Offset = "0x6EFF2B0", VA = "0x186EFFEB0")]
	public UniformTRS PJCCCKAHKKK()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6EFFDF0", Offset = "0x6EFF1F0", VA = "0x186EFFDF0")]
	public void PJCCCKAHKKK([Out] UniformTRS MHMCKLPCBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x6EFE8D0", Offset = "0x6EFDCD0", VA = "0x186EFE8D0")]
	public Vector3 HMJFCDFHOID()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6EFE580", Offset = "0x6EFD980", VA = "0x186EFE580")]
	public void FICCALJBNHE([In] Vector3 EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6EFDD90", Offset = "0x6EFD190", VA = "0x186EFDD90")]
	public Vector3 BKJDEMGLGFN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6EFFD20", Offset = "0x6EFF120", VA = "0x186EFFD20")]
	public void PFACMCFMDDB([In] Vector3 EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x6EFF120", Offset = "0x6EFE520", VA = "0x186EFF120")]
	public Quaternion JBIIDAOAIDA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x6EFF890", Offset = "0x6EFEC90", VA = "0x186EFF890")]
	public void NEOMDPKJPAM([In] Quaternion EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x6EFEF00", Offset = "0x6EFE300", VA = "0x186EFEF00")]
	public Quaternion JAIDGHCONFA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x6EFFC50", Offset = "0x6EFF050", VA = "0x186EFFC50")]
	public void PBAPOIKBADC([In] Quaternion EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6EFDE80", Offset = "0x6EFD280", VA = "0x186EFDE80")]
	public float BLBLPEEINEB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x6EFEAA0", Offset = "0x6EFDEA0", VA = "0x186EFEAA0")]
	public void ICAKEINIGGE(float EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x6EFE650", Offset = "0x6EFDA50", VA = "0x186EFE650")]
	public float GGLBMKFNGKG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x6EFFB50", Offset = "0x6EFEF50", VA = "0x186EFFB50")]
	public void NPILFAGIGMF(float EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6EFEB50", Offset = "0x6EFDF50", VA = "0x186EFEB50")]
	public void IJBFMHIFJEH([In] Vector3 EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6EFF7A0", Offset = "0x6EFEBA0", VA = "0x186EFF7A0")]
	public Vector3 MBCBKBCHKFJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6EFDB20", Offset = "0x6EFCF20", VA = "0x186EFDB20")]
	public void BADEIMPGKBB([In] Vector3 EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6EFE6F0", Offset = "0x6EFDAF0", VA = "0x186EFE6F0")]
	public Vector3 HECMDDNPKDJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6EFF4F0", Offset = "0x6EFE8F0", VA = "0x186EFF4F0")]
	public void KFHGDHBECML([In] Vector3 EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6EFE7E0", Offset = "0x6EFDBE0", VA = "0x186EFE7E0")]
	public Vector3 HFBGCANCJJD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6EFDBF0", Offset = "0x6EFCFF0", VA = "0x186EFDBF0")]
	public void BCGFLLLHKPN([In] Vector3 EEPLCHCGAIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct PICCOKOKACB : IEquatable<PICCOKOKACB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly AGLPGLMEACF KDHECHILKME;

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public MELHPPJKMHE BAPHJCKPNHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
		get
		{
			return default(MELHPPJKMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	private LKGAMHHAMKI FBMKFDLJDAK
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x6EEC6E0", Offset = "0x6EEBAE0", VA = "0x186EEC6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	private EDFLPHOAHJN ODGMLGNBCNI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x6EFD5B0", Offset = "0x6EFC9B0", VA = "0x186EFD5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	private LLBAMGDPGNH AIPMFAOGIIE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x6EFD810", Offset = "0x6EFCC10", VA = "0x186EFD810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
	public PICCOKOKACB(AGLPGLMEACF IMMJHCFALCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEBD00", VA = "0x186EEC900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6EFD640", Offset = "0x6EFCA40", VA = "0x186EFD640", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC860", Offset = "0x6EEBC60", VA = "0x186EEC860", Slot = "4")]
	public bool Equals(PICCOKOKACB KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC9C0", Offset = "0x6EEBDC0", VA = "0x186EEC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6EFD6D0", Offset = "0x6EFCAD0", VA = "0x186EFD6D0")]
	public void HAIHIJEGIBG(string ICMMNOKPMGG, DKEAPBGBOMB BNOCOAKANOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class LGHFFJBHIID
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private struct AAJNBALEHON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Guid GPJCGLBMIBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public ANCHPGIJEPG KCDAHPIMDLD;
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private struct ANCHPGIJEPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int EEPLCHCGAIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int HFHPAEEBEHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int ENHLEGECDIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int KENPFFIPLAM;

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x6EEE250", Offset = "0x6EED650", VA = "0x186EEE250")]
		public bool CDAOOIKCPJI([Out] PBFPCCNOOBK LEELLFGMHHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x6EEE2E0", Offset = "0x6EED6E0", VA = "0x186EEE2E0")]
		public ANCHPGIJEPG(PBFPCCNOOBK LEELLFGMHHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9080", Offset = "0x6EF8480", VA = "0x186EF9080")]
	public static Guid GGCAHJFBLCG(this PBFPCCNOOBK LEELLFGMHHO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9060", Offset = "0x6EF8460", VA = "0x186EF9060")]
	public static bool ACNHPDGCMCO(this Guid GPJCGLBMIBA, [Out] PBFPCCNOOBK LEELLFGMHHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal static class EDBLFEBAMAH
{
	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0960", Offset = "0x6EEFD60", VA = "0x186EF0960")]
	public static EDFLPHOAHJN ODGMLGNBCNI(this AGLPGLMEACF NKPCGMJMEIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0890", Offset = "0x6EEFC90", VA = "0x186EF0890")]
	public static JOEKENHMAMF KDBIFKJKAEN(this AGLPGLMEACF NKPCGMJMEIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0790", Offset = "0x6EEFB90", VA = "0x186EF0790")]
	public static EntityManager EFHGOOFKIED(this AGLPGLMEACF NKPCGMJMEIE)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x2CBB450", Offset = "0x2CBA850", VA = "0x182CBB450")]
	public static T KAGMKJDDCCL<T>(this AGLPGLMEACF NKPCGMJMEIE) where T : struct, IOJAJBKPDEN
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2CBC710", Offset = "0x2CBBB10", VA = "0x182CBC710")]
	public static bool KIHAGKGHDFH<T>(this AGLPGLMEACF NKPCGMJMEIE) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x2CBB3A0", Offset = "0x2CBA7A0", VA = "0x182CBB3A0")]
	public static bool ANPDPIHOFEC<T>(this AGLPGLMEACF NKPCGMJMEIE) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface CDNMCPCLAEP
{
	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPEGBMNHPNC(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AOGPNDPOBLO(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OJEALIINFBK(AGLPGLMEACF IMMJHCFALCP, [Out] Guid HANIKMKPJIE);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid PHJOLBDCEEG(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FCJCGCAEAIJ(AGLPGLMEACF IMMJHCFALCP, Guid HANIKMKPJIE);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PGIOJICBJCI(AGLPGLMEACF IMMJHCFALCP, [Out] Guid BBANEDNDONM);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid DNFHOCJJMPI(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EFHAIAAJGOK(AGLPGLMEACF IMMJHCFALCP, Guid BBANEDNDONM);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AKBHHCNMPPJ(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task OPMOOENOOBP(AGLPGLMEACF KADEDLJJJFO, AGLPGLMEACF DEDHJMDEEIE);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface JMFCOPDJEJI
{
	[Cpp2IlInjected.Token(Token = "0x17000185")]
	Guid FGHPCPMNPJH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NIPHKLHLMAG(NativeList<Guid> IJJLBLEANKB, NativeList<Guid> AHEKKHHJIID, NativeList<FixedString64Bytes> GJGBCCOGMHO);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface ODMBJEACHDK
{
	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JDMIFPLBNDG(List<AGLPGLMEACF> OENAGHHGEGH);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FHNHFBIPNAO(List<AGLPGLMEACF> PHPOAPFDPHF);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HJJNHDMKFOC(AGLPGLMEACF OKCLNECINJK);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FPJJHFAONHI(AGLPGLMEACF OKCLNECINJK);

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NHDMAJHAJDL(AGLPGLMEACF OKCLNECINJK);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int HACHJJBDJMJ(AGLPGLMEACF OKCLNECINJK);

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MADDGNKNDFM(AGLPGLMEACF OKCLNECINJK, int KIGKEDGNJCM);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AGLPGLMEACF CDKGMPHKNBN(AGLPGLMEACF KAOOFPBIKMM);

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int AODPDEKMNHB(AGLPGLMEACF KAOOFPBIKMM);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GIMIOCNMPFB(AGLPGLMEACF KAOOFPBIKMM, int GKCOANHMJCG);

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int LKAEAMPIOED(AGLPGLMEACF KAOOFPBIKMM);

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JLEEHNIHCAA(AGLPGLMEACF KAOOFPBIKMM, int HHNFDFJAJJG);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EGBBOFFLFFL(AGLPGLMEACF KDHECHILKME);

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GIHPMCHLKGL(AGLPGLMEACF IMMJHCFALCP, bool KKAMKHLMMMH);

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PKFMADPDFAK(AGLPGLMEACF[] CCBEIEEDJFG, bool KKAMKHLMMMH);
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface HCFEDPOKDLG
{
	[Cpp2IlInjected.Token(Token = "0x17000186")]
	IReadOnlyCollection<BIIPLBIOAAM> DMKECDOMAAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BJNCGIMAOEC(int HPIFEIGNDML, [Out] BIIPLBIOAAM GDOIAPFGEKG);

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BIIPLBIOAAM KBIECBBDBLE(Type DPOLEDLIAMP);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class PGIDIBCNIPK
{
	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x30409B0", Offset = "0x303FDB0", VA = "0x1830409B0")]
	public static T CDCAAEMADEK<T>(this HCFEDPOKDLG CDMGAIENILI, Entity KFLBPHJAJJL) where T : struct, IOJAJBKPDEN
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x3040A60", Offset = "0x303FE60", VA = "0x183040A60")]
	public static BIIPLBIOAAM KBIECBBDBLE<T>(this HCFEDPOKDLG CDMGAIENILI) where T : struct, IOJAJBKPDEN
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface CFAHFNLBACB
{
	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PBFPCCNOOBK[] IHBMLHJENDN(string DDDHPCNFCEK, MELHPPJKMHE NDHCGBIDNIL, bool AHJNPODILMD = false);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IICMAMFNMOF(string IMDAMHNKLIB, PBFPCCNOOBK[] BIICPJAJNCF);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface HJAHHCBGNIN
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<AGLPGLMEACF, AGLPGLMEACF> BIFDFFLDFAB;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<AGLPGLMEACF, AGLPGLMEACF> FFJBJJKJHLP;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<AGLPGLMEACF, AGLPGLMEACF, AGLPGLMEACF> GAFCFKBMJJM;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<AGLPGLMEACF> LAIICPHPFJC;

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LGGKFKLIAMK(AGLPGLMEACF IMMJHCFALCP, AGLPGLMEACF CNBCAPIFOMI);

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "9")]
	AGLPGLMEACF GICECDHLLJM(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<AGLPGLMEACF> DCPDEPIMFEC(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "11")]
	AGLPGLMEACF LGKNCJIAJBH(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OILKJFPJAKD(AGLPGLMEACF IMMJHCFALCP, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG);

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OMHMEICDLPM(AGLPGLMEACF IMMJHCFALCP, float ABBNOLDJHOI);

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool BPCAFCPABOP(AGLPGLMEACF IMMJHCFALCP, [Out] AGLPGLMEACF DEDHJMDEEIE);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool CPNJMMECFHH(AGLPGLMEACF IMMJHCFALCP, [Out] RigidTransform GNDKOOFCEPM);

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool DKEPPGFNALP(AGLPGLMEACF IMMJHCFALCP, [Out] float JONAEFKFBFC);

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 IKFAIIMGDIK(JAIHHELCJDI MLKBGAPFGJD);

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	quaternion LOJMNPCNFMI(JAIHHELCJDI MLKBGAPFGJD);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class FBNBDCNGACD
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface DJEOLAGMMAK
{
	[Cpp2IlInjected.Token(Token = "0x17000187")]
	object BAPJBABIMID
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNDOMJKBNEK(BLJMICDPKDA CCBEIEEDJFG);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct CGBGBIPHBKB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly string DDDHPCNFCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly T BMLEAJPEFAD;

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x5880A70", Offset = "0x587FE70", VA = "0x185880A70")]
	public CGBGBIPHBKB(T BMLEAJPEFAD, [Optional][CallerMemberName] string DDDHPCNFCEK)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly CGBGBIPHBKB<int> KDEELCKFFFO;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly CGBGBIPHBKB<int> GODLEJDPHCB;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public enum CKJLNOMJJIH
{
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class DBBENIBMHOA
{
	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x10630F0", Offset = "0x10624F0", VA = "0x1810630F0")]
	public static bool DDOCPAGPFMG(this CKJLNOMJJIH NMAIGNOENJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x1063100", Offset = "0x1062500", VA = "0x181063100")]
	public static bool IKNKNPLOCJI(this CKJLNOMJJIH NMAIGNOENJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x27CC2B0", Offset = "0x27CB6B0", VA = "0x1827CC2B0")]
	public static bool ILLDLONJEOA(this CKJLNOMJJIH NMAIGNOENJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface ILOLAGNKFOI
{
	[Cpp2IlInjected.Token(Token = "0x17000188")]
	bool ONGFKGOPOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface BKKFHGJAJGB
{
	[Cpp2IlInjected.Token(Token = "0x17000189")]
	CKJLNOMJJIH GMADPMGAMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	CKJLNOMJJIH ANLGIKBMHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	CKJLNOMJJIH OOIHJHLMILI
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	CKJLNOMJJIH JHHDLGFACNH
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	CKJLNOMJJIH IBIOOLKMCJF
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	CKJLNOMJJIH BJPFGFDHAAE
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	CKJLNOMJJIH OGKJAICJHAO
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	CKJLNOMJJIH KHJPBCFGCJM
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	CKJLNOMJJIH MLBLELDPKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	CKJLNOMJJIH NDKMJKNFLNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	CKJLNOMJJIH HMEMMGJNFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	CKJLNOMJJIH AJJKEGJAEAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	CKJLNOMJJIH BCBPINCPBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	CKJLNOMJJIH DECPIFPEKGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	CKJLNOMJJIH BJIMMCNFKOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	CKJLNOMJJIH LDCJAGHIMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int CADKKGPFCDD(CGBGBIPHBKB<int> HGDDFPIIMHP);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface IJHAGBMDOFM
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event EEFIIKHCBIP.EHMCKPFLGKN EAFPFLGIEOC;

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AGLPGLMEACF MHBLEPABNBK(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NKAPMPEFCFI(List<AGLPGLMEACF> PHPOAPFDPHF);

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EICPCIPDMKM DKCHNKNACDL(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NMJPKLBPMDE(IEnumerable<AGLPGLMEACF> MPLLIACEKEG);

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EICPCIPDMKM JPJJAJKLFLM(AGLPGLMEACF DEDHJMDEEIE, AGLPGLMEACF CEMFCPJEKHI, bool GPGPOPGPCIH, AGLPGLMEACF KDGMCPCFIID);

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AGLPGLMEACF IPAKFDELFFC(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HGECDLHOFAC(AGLPGLMEACF IMMJHCFALCP, AGLPGLMEACF DEDHJMDEEIE, bool JMAGNKLOJMN);

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PHHLFIHBCIB(AGLPGLMEACF IMMJHCFALCP, AGLPGLMEACF DEDHJMDEEIE);

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool AJOADOBLJFI(AGLPGLMEACF PEGJINMDOEA, AGLPGLMEACF FHELANLIGJA);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int AEOLJGLACFG(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "12")]
	BLJMICDPKDA PFPECFIJPIK(AGLPGLMEACF KDHECHILKME);

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<AGLPGLMEACF> IPNEHGLJOLL(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool HDJIGGMJCGA(AGLPGLMEACF IMMJHCFALCP, AGLPGLMEACF BDDBHCKDBCP);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IEnumerable<AGLPGLMEACF> OBMDEAEHPMD(AGLPGLMEACF IMMJHCFALCP, bool AFMNJIEOBHN = false);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool HJNJHKBAOBC(AGLPGLMEACF IMMJHCFALCP, AGLPGLMEACF NLHLJAMHHNB);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "17")]
	AGLPGLMEACF BMIMCHHBHOM(AGLPGLMEACF KDGMCPCFIID, AGLPGLMEACF KHGKKPIFGKJ);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool MNMJAOBGJBJ(AGLPGLMEACF KDGMCPCFIID, AGLPGLMEACF KHGKKPIFGKJ, [Out] AGLPGLMEACF ENBPMOIJCGM);

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	AGLPGLMEACF PLLIBBCNJJG(AGLPGLMEACF[] CCBEIEEDJFG);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class KPJDNCKCJMA
{
	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8E00", Offset = "0x6EF8200", VA = "0x186EF8E00")]
	public static List<AGLPGLMEACF> NKAPMPEFCFI(this IJHAGBMDOFM HNGCDAAKGJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8D90", Offset = "0x6EF8190", VA = "0x186EF8D90")]
	public static bool GAMAFBGALEN(this IJHAGBMDOFM HNGCDAAKGJO, AGLPGLMEACF IMMJHCFALCP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface KJPFHAMOGGG
{
	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JANMPMPNNNK APAJKMNCBKC(AGLPGLMEACF OKCLNECINJK);

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ODHFBFHCMEH(AGLPGLMEACF OKCLNECINJK, JANMPMPNNNK OHLFCKDKOAP);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DCIPAFLBOCF(AGLPGLMEACF OKCLNECINJK);

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EEOPJKHAAFL(AGLPGLMEACF OKCLNECINJK, bool EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string[] GNIAPELFJHC(AGLPGLMEACF OKCLNECINJK);

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IACCGHMMGAF(AGLPGLMEACF OKCLNECINJK, IEnumerable<string> HNGFBCNFFAA);

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string[] AJGEPCDIBIF(AGLPGLMEACF OKCLNECINJK);

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LOMLONOIPFG(AGLPGLMEACF OKCLNECINJK, IEnumerable<string> HNGFBCNFFAA);

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "8")]
	string[] EBPCNMOIHBE(AGLPGLMEACF OKCLNECINJK);

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OMKOJPOMBGL(AGLPGLMEACF OKCLNECINJK, IEnumerable<string> HNGFBCNFFAA);

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string[] NLDMCBJFFCM(AGLPGLMEACF OKCLNECINJK);

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PNABGGGOKFI(AGLPGLMEACF OKCLNECINJK, IEnumerable<string> HNGFBCNFFAA);

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NIBBIBIAAMO(AGLPGLMEACF OKCLNECINJK, AGLPGLMEACF PEIJBHPINLD);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface AMHBDKOGHNI
{
	[Cpp2IlInjected.Token(Token = "0x17000199")]
	bool DNLNGDAJJJF
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	bool EEHFIAGIICF
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	bool CPLJLJLAGFP
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface COOOLKLDNDI : CHHCAPLNOLP
{
	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DPEJICFJMIC(Entity KFLBPHJAJJL, [Out] KAFEBIADMOE KNOJBNNAGCL);

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEFODANGFIE(NativeArray<KAFEBIADMOE> PBBPAIDOHGB, NativeArray<JJCGGMLKFDK> EONPPGPAKPM);

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FAGGIACGOII(KAFEBIADMOE KNOJBNNAGCL);

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JNAKBNGPKBO(KAFEBIADMOE KNOJBNNAGCL, [Out] Collider BHILPBPJHNM);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface CHHCAPLNOLP
{
	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLLEPKNLCMN([In] float3 JMGPOCBLPOM, [In] float3 PAAGAJJEHGO, float NHDEHMAPALH, Allocator HPLNAKONHEI, [Out] NativeArray<Entity> IKCCHOOOHEH);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface FCNCDMPAPNL
{
	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLLEPKNLCMN([In] float3 JMGPOCBLPOM, [In] float3 PAAGAJJEHGO, float NHDEHMAPALH, [Out] PGGPFOPDENE BIKIOBAJJOM, [Out] AGLPGLMEACF AHMPLBBAMHE);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface JCMPPKKCJLA
{
	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLLEPKNLCMN([In] NativeArray<Entity> IKCCHOOOHEH, [In] float3 JMGPOCBLPOM, [In] float3 PAAGAJJEHGO, [In] NativeArray<PGGPFOPDENE> JFPFLNDAGCI);
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct KAFEBIADMOE : NLGMFENKCMI, IEquatable<KAFEBIADMOE>
{
	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	public int KMIIBMECGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x92A840", Offset = "0x929C40", VA = "0x18092A840", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xC15E20", Offset = "0xC15220", VA = "0x180C15E20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public int GPEGCFLKPNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x27EB090", Offset = "0x27EA490", VA = "0x1827EB090", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x6183F60", Offset = "0x6183360", VA = "0x186183F60", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6EF84B0", Offset = "0x6EF78B0", VA = "0x186EF84B0", Slot = "8")]
	public bool Equals(KAFEBIADMOE KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8500", Offset = "0x6EF7900", VA = "0x186EF8500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct PGGPFOPDENE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float AOOMBCFPJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public float3 KENGOPLODLD;
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface JDGPICNNEAE
{
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface LKGAMHHAMKI
{
	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	EDFLPHOAHJN ODGMLGNBCNI
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	HNECHANNMPH GPOGOCPPPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<BLJMICDPKDA, NativeArray<APJHGHONFKE>> IDAJABAODCB;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<BLJMICDPKDA> HLFKEJPJKFD;

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GIJOINHKMKF ECFKFGFNNNN(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "7")]
	APJHGHONFKE NPABEMAPFCO(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MHJHNBDIMHP(PBFPCCNOOBK LEELLFGMHHO, NNDKCHIADCC MJLOJBGDGDC);

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IMEOCDMMODN(PBFPCCNOOBK[] BIICPJAJNCF, GameObject BCDDMHHPJBD);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "10")]
	MELHPPJKMHE GAIGFBPDAAN(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool AKEBDIGFKKM(AGLPGLMEACF IMMJHCFALCP, [Out] Transform HGENDDPKHHK);

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MKPJLPPJIBK(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PJCGKBNFBBC(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "14")]
	AGLPGLMEACF IFFBBEMKAOP(PBFPCCNOOBK LEELLFGMHHO);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool NBNGDGKLMML(PBFPCCNOOBK LEELLFGMHHO, [Out] AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	PBFPCCNOOBK NDFEDNLMFGM(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	LocalId CFFBMDCBMHD(LocalId NJODHGDJMLK);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	BLJMICDPKDA IFFBBEMKAOP(NativeArray<PBFPCCNOOBK> LEELLFGMHHO, Allocator HPLNAKONHEI);

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	BLJMICDPKDA LBCAONPBPHC(APJHGHONFKE JJJPIBKENDJ, int HMELIAGANNM, Allocator HPLNAKONHEI);

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	BLJMICDPKDA CJFEFOCCCAM(NativeArray<PBFPCCNOOBK> LEELLFGMHHO, NativeArray<NFPDGEHEBII> ADGJNPDCBAH, Allocator HPLNAKONHEI);

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "21")]
	PBFPCCNOOBK[] IHBMLHJENDN(string IMDAMHNKLIB, MELHPPJKMHE NDHCGBIDNIL, bool AHJNPODILMD);

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IICMAMFNMOF(string IMDAMHNKLIB, PBFPCCNOOBK[] BIICPJAJNCF);

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "23")]
	MELHPPJKMHE HODPKFMBBIM(APJHGHONFKE JJJPIBKENDJ, bool HAGDKLEOHLP);

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "24")]
	MELHPPJKMHE HODPKFMBBIM(APJHGHONFKE JJJPIBKENDJ);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "25")]
	MELHPPJKMHE NCNJHABOMPB(APJHGHONFKE JJJPIBKENDJ);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "26")]
	MELHPPJKMHE NPAHKLOACMJ(APJHGHONFKE JJJPIBKENDJ);

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "27")]
	MELHPPJKMHE FKLIFGOAEIN(PBFPCCNOOBK LEELLFGMHHO, APJHGHONFKE JJJPIBKENDJ);

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "28")]
	GPKIBOOCFEJ DNEAOOGFOGH();

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "29")]
	IIDKDMNNOLN CEDOGDEBJPH();

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "30")]
	MPJMIBFKAFF CJEDIAAKEKL(KONBFGBHLIN AKPBEKABCIE);

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void POJCOBBDMHO(BLJMICDPKDA CCBEIEEDJFG);

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void KJDEEDGEPIJ(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void CGCMGLCLMDB(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void POJCOBBDMHO(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void ECANEGBDLIC(AGLPGLMEACF CCBEIEEDJFG);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	bool LBEDGJHPDEO(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "37")]
	BLJMICDPKDA COMNECNLDLI(BLJMICDPKDA KBHKKMGGNKH, Allocator HPLNAKONHEI);

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool AJEFCBIPMCP(AGLPGLMEACF IMMJHCFALCP);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public static class ANDNKIMDPLL
{
	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6EEE980", Offset = "0x6EEDD80", VA = "0x186EEE980")]
	public static void PJCGKBNFBBC(this LKGAMHHAMKI BNOCOAKANOI, NNDKCHIADCC MJLOJBGDGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6EEE5F0", Offset = "0x6EED9F0", VA = "0x186EEE5F0")]
	public static MELHPPJKMHE HCBAGGFOKAG(this LKGAMHHAMKI BNOCOAKANOI, LocalId IMMJHCFALCP)
	{
		return default(MELHPPJKMHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x6EEE590", Offset = "0x6EED990", VA = "0x186EEE590")]
	public static MELHPPJKMHE HCBAGGFOKAG(this LKGAMHHAMKI BNOCOAKANOI, PBFPCCNOOBK LEELLFGMHHO)
	{
		return default(MELHPPJKMHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x6EEE5F0", Offset = "0x6EED9F0", VA = "0x186EEE5F0")]
	public static AGLPGLMEACF IFFBBEMKAOP(this LKGAMHHAMKI BNOCOAKANOI, LocalId IMMJHCFALCP)
	{
		return default(AGLPGLMEACF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x6EEE900", Offset = "0x6EEDD00", VA = "0x186EEE900")]
	public static PBFPCCNOOBK NDFEDNLMFGM(this LKGAMHHAMKI BNOCOAKANOI, LocalId IMMJHCFALCP)
	{
		return default(PBFPCCNOOBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6EEE520", Offset = "0x6EED920", VA = "0x186EEE520")]
	public static bool AJEFCBIPMCP(this LKGAMHHAMKI BNOCOAKANOI, PBFPCCNOOBK LEELLFGMHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x358A200", Offset = "0x3589600", VA = "0x18358A200")]
	public static T LDLFEBFOGPA<T>(this LKGAMHHAMKI BNOCOAKANOI, LocalId IMMJHCFALCP) where T : struct, IOJAJBKPDEN
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x6EEE620", Offset = "0x6EEDA20", VA = "0x186EEE620")]
	public static GPKIBOOCFEJ KECKPJPKDGL(this LKGAMHHAMKI BNOCOAKANOI, RigidTransform DGLIIEKJOKL)
	{
		return default(GPKIBOOCFEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6EEE710", Offset = "0x6EEDB10", VA = "0x186EEE710")]
	public static MPJMIBFKAFF KENKAHKOBBJ(this LKGAMHHAMKI BNOCOAKANOI, KONBFGBHLIN CBAFPMLAPJI, RigidTransform DGLIIEKJOKL)
	{
		return default(MPJMIBFKAFF);
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6EEE810", Offset = "0x6EEDC10", VA = "0x186EEE810")]
	public static IIDKDMNNOLN LLHDAKMPBBH(this LKGAMHHAMKI BNOCOAKANOI, RigidTransform DGLIIEKJOKL)
	{
		return default(IIDKDMNNOLN);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x6EEE320", Offset = "0x6EED720", VA = "0x186EEE320")]
	private static void AAFDNAPAFPF(MELHPPJKMHE KCLCLGPKGLN, RigidTransform DGLIIEKJOKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface JKJHEMKEGLM
{
	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	bool PPGAPGGFKGI
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	AGLPGLMEACF IAKHJJJMFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	MELHPPJKMHE DKHAOLFCBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event JNDPGCEEGKP JOMLEAIGKJO;

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AGLPGLMEACF BMIMCHHBHOM(AGLPGLMEACF KDGMCPCFIID, AGLPGLMEACF KHGKKPIFGKJ);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MNMJAOBGJBJ(AGLPGLMEACF KDGMCPCFIID, AGLPGLMEACF KHGKKPIFGKJ, [Out] AGLPGLMEACF ENBPMOIJCGM);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DAEIHDBHOMJ();

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ACBBKACEGEF();

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FPGIKIJPBDN(AGLPGLMEACF KDGMCPCFIID);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool EJIIDCAJEKJ(AGLPGLMEACF KDGMCPCFIID);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public delegate void JNDPGCEEGKP(MELHPPJKMHE EPGCGNCJNFJ, MELHPPJKMHE IHJBPOJBGAJ);
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class IPOGEIBOGBA
{
	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x6EF74B0", Offset = "0x6EF68B0", VA = "0x186EF74B0")]
	public static bool PFEEOGCJMHG(this JKJHEMKEGLM OIMJEANNONF, MELHPPJKMHE KDGMCPCFIID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x6EF7350", Offset = "0x6EF6750", VA = "0x186EF7350")]
	public static bool FKPHHHFNCNB(this JKJHEMKEGLM OIMJEANNONF, AGLPGLMEACF KDGMCPCFIID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x6EF7430", Offset = "0x6EF6830", VA = "0x186EF7430")]
	public static bool GCFDEJJMMKL(this JKJHEMKEGLM OIMJEANNONF, AGLPGLMEACF KDGMCPCFIID)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface EICDJHOMJEC
{
	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DEKPNKAFCOI(MELHPPJKMHE KCLCLGPKGLN, ABCKHNEHFAE KEKHLMMPMLO, List<MELHPPJKMHE> MDGEJMLDPEE);

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int ALNKFKLALCF(MELHPPJKMHE KCLCLGPKGLN, ABCKHNEHFAE KEKHLMMPMLO);

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void POCHJDOFPAI(MELHPPJKMHE KCLCLGPKGLN, List<MELHPPJKMHE> MDGEJMLDPEE);

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int EDNOBGFMLLB(MELHPPJKMHE OACLGAKONPN, MELHPPJKMHE KDGMCPCFIID, ABCKHNEHFAE KEKHLMMPMLO);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MELHPPJKMHE OFMLIHECHBJ(MELHPPJKMHE OACLGAKONPN, int HAJICDLBEKC, ABCKHNEHFAE KEKHLMMPMLO);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NKLAEFEPCCP(MELHPPJKMHE OACLGAKONPN, MELHPPJKMHE KDGMCPCFIID, ABCKHNEHFAE KEKHLMMPMLO);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MCFCIOFFNGJ(MELHPPJKMHE OACLGAKONPN, MELHPPJKMHE KDGMCPCFIID, ABCKHNEHFAE KEKHLMMPMLO);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PPNCONCNLIJ(MELHPPJKMHE OACLGAKONPN, ABCKHNEHFAE KEKHLMMPMLO);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BEICFCAEDNG(MELHPPJKMHE OACLGAKONPN, MELHPPJKMHE KDGMCPCFIID, ABCKHNEHFAE KEKHLMMPMLO);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GCCIAMKKLIF(Entity OACLGAKONPN, Entity KDGMCPCFIID, ABCKHNEHFAE KEKHLMMPMLO);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LBCGABIDLNG(Entity OACLGAKONPN, ABCKHNEHFAE KEKHLMMPMLO);

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ACBBFJBEJFP(MELHPPJKMHE KDGMCPCFIID, ABCKHNEHFAE KEKHLMMPMLO);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface IKIKEJKDAFH
{
	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BDHGEIKEMEH(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CLIPPOEADDF(AGLPGLMEACF IMMJHCFALCP, Transform HGENDDPKHHK);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface GNKOLMGLLIA
{
	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HAPDOOJHCHP(AGLPGLMEACF KDGMCPCFIID, AGLPGLMEACF FHEJNGEAHJI);

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MJEDDCMNOJI(AGLPGLMEACF KDGMCPCFIID, AGLPGLMEACF BGCIDFKJJIP);

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PAOEALHIEAF(AGLPGLMEACF KDGMCPCFIID, [Out] AGLPGLMEACF LEKBEEPJGFC);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface HEKNHHAEJJM
{
	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IGJAILKDKIA(AGLPGLMEACF KDHECHILKME, bool EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBECJPIKOCB(AGLPGLMEACF KDHECHILKME, bool EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LKPMCAMAFDI(AGLPGLMEACF KDHECHILKME, int EEPLCHCGAIN);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface HPIODHHBGKA
{
	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<AGLPGLMEACF> IKAKOKEDDJD(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AGLPGLMEACF BEBNEDCFAHK(AGLPGLMEACF IMMJHCFALCP, int HAJICDLBEKC);

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int NOABJBIMEOA(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DJEOIECAKFK MGBMHPBOLMH(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KKHBAHELEEI(AGLPGLMEACF IMMJHCFALCP, DJEOIECAKFK BJGOCALJFKP);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AGLPGLMEACF OKLDJFFJPHF(AGLPGLMEACF IMMJHCFALCP, [Optional] float3? CLHMEGFDOKF, [Optional] quaternion? MDJOMEFJFHD, [Optional] float3? KFNOLBCIBOH);

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AGLPGLMEACF IOGHAPBDHIK(AGLPGLMEACF IMMJHCFALCP, int HAJICDLBEKC, [Optional] float3? CLHMEGFDOKF, [Optional] quaternion? MDJOMEFJFHD, [Optional] float3? KFNOLBCIBOH);

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EGJMOFMODOG(AGLPGLMEACF IMMJHCFALCP, int HAJICDLBEKC);

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FMFLAMOHPCM(AGLPGLMEACF IMMJHCFALCP);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface CKJDEBJNKBP
{
	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GODMHHAGEOG();

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FONHKGEADDA();

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DIHDOBCFDIG();

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GKMBMIGFNAP();

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DLHNKPJIGCP();

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HNJJBFECJGI();

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OIFNBHGEANK();

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FKGHFACDBIG();

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HDBECDKCELO();

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PJLICOIIKHJ();

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CFPCGLFGIEH();

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MIJHKIKLKJJ();

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GGJEMGANCCB();
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface MMMGDABNIKO
{
	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OEPDKFPACBM(AGLPGLMEACF KDGMCPCFIID, [Out] int OACLGAKONPN);

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NMLHCANHLHC(AGLPGLMEACF KDGMCPCFIID, int OACLGAKONPN);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CJECPFFFACD(AGLPGLMEACF KDGMCPCFIID, bool JFIONMMANLA);

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MNHBGMFMBPM(AGLPGLMEACF KDGMCPCFIID, bool BBDFJCNAOIN);

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KFKBABIDPHF(AGLPGLMEACF KDGMCPCFIID, float KPIMACCLGAK, float IKNEEEKAINH, float HHIKGLJPEHC);

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EPOGDCKLCNI(AGLPGLMEACF IMMJHCFALCP, [Out] float IKNEEEKAINH, [Out] float HHIKGLJPEHC);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CJEEJJMDBGB(AGLPGLMEACF KDGMCPCFIID, float3 CLHMEGFDOKF, quaternion MDJOMEFJFHD);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool EDGEFDNBPEJ(AGLPGLMEACF KDGMCPCFIID, [Out] float3 CLHMEGFDOKF, [Out] quaternion MDJOMEFJFHD);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface BGBCLBMHAOP
{
	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHBPBLIKMDC(Entity KFLBPHJAJJL);

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FICCALJBNHE(Entity KFLBPHJAJJL, [In] float3 EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 HMJFCDFHOID(Entity KFLBPHJAJJL);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NEOMDPKJPAM(Entity KFLBPHJAJJL, [In] quaternion EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion JBIIDAOAIDA(Entity KFLBPHJAJJL);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void APKGJOCODDE(Entity KFLBPHJAJJL, [In] float3 CLHMEGFDOKF, [In] quaternion MDJOMEFJFHD);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DPIHJMAAAEG(Entity KFLBPHJAJJL, [Out] float3 CLHMEGFDOKF, [Out] quaternion MDJOMEFJFHD);

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DPIHJMAAAEG(Entity KFLBPHJAJJL, [Out] RigidTransform LMAKAHNFECC);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IKCBLNGIOPP(Entity KFLBPHJAJJL, [Out] float3 CLHMEGFDOKF, [Out] quaternion MDJOMEFJFHD);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IKCBLNGIOPP(Entity KFLBPHJAJJL, [Out] RigidTransform LMAKAHNFECC);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float3 INCONPCKAKO(Entity KFLBPHJAJJL);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IJBFMHIFJEH(Entity KFLBPHJAJJL, [In] float3 EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ICAKEINIGGE(Entity KFLBPHJAJJL, float EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float BLBLPEEINEB(Entity KFLBPHJAJJL);

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KFHGDHBECML(Entity KFLBPHJAJJL, [In] float3 EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 HECMDDNPKDJ(Entity KFLBPHJAJJL);

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PFACMCFMDDB(Entity KFLBPHJAJJL, [In] float3 EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 BKJDEMGLGFN(Entity KFLBPHJAJJL);

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PBAPOIKBADC(Entity KFLBPHJAJJL, [In] quaternion EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	quaternion JAIDGHCONFA(Entity KFLBPHJAJJL);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 MBCBKBCHKFJ(Entity KFLBPHJAJJL);

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BADEIMPGKBB(Entity KFLBPHJAJJL, [In] float3 EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NPILFAGIGMF(Entity KFLBPHJAJJL, float EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float GGLBMKFNGKG(Entity KFLBPHJAJJL);

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BCGFLLLHKPN(Entity KFLBPHJAJJL, [In] float3 EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float3 HFBGCANCJJD(Entity KFLBPHJAJJL);

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void ILDIPOPLAML(Entity KFLBPHJAJJL, [Out] float4x4 PDPDNLJIBAL);

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void NNAAAOOPNNG(Entity KFLBPHJAJJL, [In] float4x4 PDPDNLJIBAL);

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void GLMMEDKKFAN(Entity KFLBPHJAJJL, [Out] float4x4 PDPDNLJIBAL);

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool AKEBDIGFKKM(Entity KFLBPHJAJJL, [Out] Transform HGENDDPKHHK);

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void NOHKEKDDNPN(Entity KFLBPHJAJJL);

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void DLOPEHMJMCK(Entity KFLBPHJAJJL, Entity JHFMLMDHLPE, Entity LNNICEPGDAG);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class DFBJDDAOKHH
{
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface ICEDKPGDOIC
{
	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECIEEEDNGOF(bool NEEIAEKHOHG);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface LLBAMGDPGNH
{
	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OIOIDPHHFOM(AGLPGLMEACF OKCLNECINJK, IEnumerable<string> HNGFBCNFFAA);

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCAOCPGFIOB(AGLPGLMEACF OKCLNECINJK, IEnumerable<string> HNGFBCNFFAA);

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EDGFFJBBBFC(AGLPGLMEACF OKCLNECINJK, params string[] HNGFBCNFFAA);

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EHHHHMFGKOF(AGLPGLMEACF OKCLNECINJK, params string[] HNGFBCNFFAA);

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BDOONLGIOFM(AGLPGLMEACF OKCLNECINJK, params string[] HNGFBCNFFAA);

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NCGCCAGHOFA(AGLPGLMEACF OKCLNECINJK, params string[] HNGFBCNFFAA);

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int FNKGDPHLELL(AGLPGLMEACF OKCLNECINJK);

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int GJNNOJOKEMO(AGLPGLMEACF OKCLNECINJK);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JFIHANMLPFE(AGLPGLMEACF OKCLNECINJK, ICollection<string> FGCMMAHAPIK);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JJMDABFFGDK(AGLPGLMEACF OKCLNECINJK, ICollection<string> FGCMMAHAPIK);

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool NBBGNBNAFBM(AGLPGLMEACF OKCLNECINJK, string ICMMNOKPMGG);

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AIBHIJDPMJE(string ICMMNOKPMGG, DKEAPBGBOMB FDEGONBLBAP);

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FPLEDBBINAE(string ICMMNOKPMGG, DKEAPBGBOMB FDEGONBLBAP);

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HAIHIJEGIBG(AGLPGLMEACF NKHLBPLJGDN, string ICMMNOKPMGG, DKEAPBGBOMB FDEGONBLBAP);

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool DFBCEJDBMNP();

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ICDECGBIBEK(IEnumerable<string> HNGFBCNFFAA);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface NFIEGJBKKMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World HFEOFBBBFPC(string FGJJPGBBCPN = "Main");

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World DMDABEPDLIN(string FGJJPGBBCPN = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World HCGMACLDLDI(string FGJJPGBBCPN = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World FFLBKPIBNLD(string FGJJPGBBCPN = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface JOEKENHMAMF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	World OPFIMEBBGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	World HPBAOCCAPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	EntityManager EFHGOOFKIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	bool ANJBFCDOFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase PNHKENIDBAM(Type DPOLEDLIAMP);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class BIMDCAAELBB
{
	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB20", Offset = "0x6EEDF20", VA = "0x186EEEB20")]
	public static ComponentSystemBase BDJHEJMJHHC(this World NNBFJMEFHAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2BF3630", Offset = "0x2BF2A30", VA = "0x182BF3630")]
	public static T PNHKENIDBAM<T>(this JOEKENHMAMF MNFDOGEOMBE) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface FAMNCJDCNII
{
	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADLFAKHINEJ(NativeListAsync<Entity> IHMJIIBHMAO);

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNEHDDNOILD(GCNHEKPNPMF FLHAEOKEJLB);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DKBMPGNDIJO(NativeListAsync<Entity> IEJDJBHFILI, bool HGBDMGDNDKB);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CEJKODBJDCH();
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface FLNJFJCFCNI
{
	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LNFCBLCGGJK(Collider BHILPBPJHNM, [Out] PNCOGLBPEGO NDIEHLOKPPB);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface NJDIBDJKAFL
{
	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NGPMMFDGGKK(AGLPGLMEACF IMMJHCFALCP, [Out] Collider BHILPBPJHNM);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject IGJCIFCGOOE(AGLPGLMEACF ILAOOBGDIPB, GameObject HMDADBIJECG, Vector3 OGHPOADGEMG, Quaternion MHGGNDLFNAD);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KMGJBHNKKJA(GameObject BHILPBPJHNM);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider CMJCGCFIAII<TCollider>(GameObject MBMMDNGHIFD) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GDGFBHDDONG(Collider BHILPBPJHNM);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject DJJPDPFFCOD<TCollider>(string DDDHPCNFCEK) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public enum NMNINJMOPKC
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface EFEMGNOLOOJ
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public struct CGAGHFEMIKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int KPHHOHHAAEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public GameObject HMDADBIJECG;
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIIOKIFDMII(AGLPGLMEACF IMMJHCFALCP, PAJDJEAGPFE EOCCFAHFBMD, bool HACHGCPHJKM, MHPNLKALAJE CHNEIEMLMKP);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFIMKEIKHBF(AGLPGLMEACF IMMJHCFALCP, PAJDJEAGPFE EOCCFAHFBMD, bool HACHGCPHJKM, bool MONPFBILECA, bool MDNFNFIJAOJ);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MEHFNKLGDCL JLNIBOJFBBH(AGLPGLMEACF KCFGMPGPMFA, List<AGLPGLMEACF> JKCLJDKELMP);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CPLKFDOEKKD(GameObject DKBDOPOECKL, GameObject PCCPAOKDDNE);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LCEMNAFJPOB(GameObject DKBDOPOECKL, List<GameObject> DLLAIFCFKKH);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GELJJCIIHPK(GameObject PCCPAOKDDNE);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T CMJCGCFIAII<T>(GameObject MBMMDNGHIFD) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GDGFBHDDONG(Collider BHILPBPJHNM);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LNONEOCELBB(BLJMICDPKDA IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NPLBNEAPEMA(BLJMICDPKDA IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GameObject EGECCPOOBBM<T>(string DDDHPCNFCEK) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool JHHGAOOLGGE(Collider BHILPBPJHNM, [Out] AGLPGLMEACF OACLGAKONPN);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool EDCBDCCBDAM(AGLPGLMEACF IMMJHCFALCP, [Out] PNCOGLBPEGO NDIEHLOKPPB);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<NMNINJMOPKC> GNJOHEEGJCC(Allocator HPLNAKONHEI = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Mesh[] MPDHPFMJGHO();

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int APNOEFIGLDF(PAJDJEAGPFE EOCCFAHFBMD);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string BAGOLHOOFJP(PAJDJEAGPFE EOCCFAHFBMD);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface BPHANBLNBIF
{
	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BHKAAHKPFIE(AGLPGLMEACF IMMJHCFALCP, AGLPGLMEACF EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DJGNDELDFNH(AGLPGLMEACF IMMJHCFALCP, AGLPGLMEACF EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int AEOLJGLACFG(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AGLPGLMEACF JJHMKPKLGIM(AGLPGLMEACF IMMJHCFALCP, int HAJICDLBEKC);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BLJMICDPKDA BFHKIAKJDME(AGLPGLMEACF IMMJHCFALCP, Allocator HPLNAKONHEI = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CPLEHKEEMKJ(AGLPGLMEACF IMMJHCFALCP, object ABHFNNFMPHA, AGLPGLMEACF EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MNPCLNPADDH(AGLPGLMEACF IMMJHCFALCP, object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool JCOCHJEBLHF(AGLPGLMEACF IMMJHCFALCP, [Out] AGLPGLMEACF EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GOAAMOBOKHJ(AGLPGLMEACF IMMJHCFALCP, float3 EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool MNAGBAGHOLJ(AGLPGLMEACF IMMJHCFALCP, [Out] float3 EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MACPDFFCJGL(AGLPGLMEACF IMMJHCFALCP, float3 EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CGCKHGJOPHC(AGLPGLMEACF IMMJHCFALCP, [Out] float3 EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IBACPFPLCND(AGLPGLMEACF IMMJHCFALCP, (Quaternion rot, Vector3 moments) IFAMPJEONCG);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool JNGPFLLBDNN(AGLPGLMEACF IMMJHCFALCP, [Out] quaternion JKEFKNOEELB, [Out] float3 MHLFJIBJGAC);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GGMJPAFOEIP(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 NGGMLFDEFCG(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 OLBFOAHJNKG(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IFIDBOEMHNE(AGLPGLMEACF IMMJHCFALCP, float3 EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void POODIMOECPI(AGLPGLMEACF IMMJHCFALCP, float3 EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float NPPBJJCHIMI(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float JCMMLLAFLFM(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void PPFAKBDDGIB(AGLPGLMEACF IMMJHCFALCP, float EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void EJGIJDBOPMG(AGLPGLMEACF IMMJHCFALCP, float EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode DOOELCKNAND(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void KLPFEOPGOIA(AGLPGLMEACF IMMJHCFALCP, CollisionDetectionMode EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "25")]
	MLNLAOAECFA OLKCNMIJGDE(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void HHFAGHEIHGD(AGLPGLMEACF IMMJHCFALCP, MLNLAOAECFA EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool BEIPJKBDJAB(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void GMPBHGCLAGD(AGLPGLMEACF IMMJHCFALCP, bool EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "29")]
	AGLPGLMEACF MHBLEPABNBK(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void LKANCCNKDOK(AGLPGLMEACF IMMJHCFALCP, AGLPGLMEACF EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "31")]
	AGLPGLMEACF IPAKFDELFFC(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void HGECDLHOFAC(AGLPGLMEACF IMMJHCFALCP, AGLPGLMEACF EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	LGMGBDCHIJJ GCAPBDKGCBD(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void BGDJNHGLKIN(AGLPGLMEACF IMMJHCFALCP, LGMGBDCHIJJ LGKAHCGFMBH);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool LAONADBFALJ(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void DADMFENAKOE(AGLPGLMEACF IMMJHCFALCP, bool EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool HGLFLCOHOJH(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void ENKNECFBEAA(AGLPGLMEACF IMMJHCFALCP, bool EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints MNOCHFMBKAP(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void MFIODMIOCAN(AGLPGLMEACF IMMJHCFALCP, RigidbodyConstraints EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float HIHFJOFGKOJ(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void HGAKPPOAJLL(AGLPGLMEACF IMMJHCFALCP, float EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float EKNEPJKEINJ(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void MBLEJAAJBJE(AGLPGLMEACF IMMJHCFALCP, float EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool NOBNLNNKFMN(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void HHKOJMNPIFD(AGLPGLMEACF IMMJHCFALCP, bool EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool DPKJALNCDHP(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void PPAEMPDMOHL(AGLPGLMEACF IMMJHCFALCP, bool EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void GPHEPJNMFIO(AGLPGLMEACF IMMJHCFALCP, int EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "50")]
	OPFMAOOBLLA MEKAANNODON(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void HGMLALBLOGA(AGLPGLMEACF IMMJHCFALCP, OPFMAOOBLLA EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "52")]
	PAFPNLLDLFP NABKDCMNEDE(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void NMJJHEIHGJG(AGLPGLMEACF IMMJHCFALCP, PAFPNLLDLFP EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float APFECFFLICA(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void IMMBAIDCKMJ(AGLPGLMEACF IMMJHCFALCP, float EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void BKEFFGGIFJB(AGLPGLMEACF IMMJHCFALCP, object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void OAPJFJHDEOE(AGLPGLMEACF IMMJHCFALCP, object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool FFMKDIBKLCE(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void GAOMADHENLK(AGLPGLMEACF IMMJHCFALCP, object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void NAKELLHMGCC(AGLPGLMEACF IMMJHCFALCP, object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool MFNDGANMMOA(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool PGHGNLPBMGC(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody PGKHDIBIHNP(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void PNBKJACANGB(AGLPGLMEACF IMMJHCFALCP, Rigidbody FLPMJAFBFIG);

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void HNNIKFOPAHB(AGLPGLMEACF IMMJHCFALCP, object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void LAJLCBGBEBF(AGLPGLMEACF IMMJHCFALCP, object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool LJDJGAPPBGJ(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void NOLBOPIGONA(AGLPGLMEACF IMMJHCFALCP, float3 DLNLPMKHKIC);

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void JGEGGJFFPBJ(AGLPGLMEACF IMMJHCFALCP, float3 BGJOJHOMGKA);

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool KHJBNPNJKGB(AGLPGLMEACF IMMJHCFALCP, [Out] float3 DLNLPMKHKIC);

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool JMJBFALGCDH(AGLPGLMEACF IMMJHCFALCP, [Out] float3 BGJOJHOMGKA);

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool OMKBNDMPAEJ(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void POKPEOAIHDP(AGLPGLMEACF IMMJHCFALCP, object ABHFNNFMPHA, bool PKMIKOAMPIA);

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void KBNLMNNGIEL(AGLPGLMEACF IMMJHCFALCP, bool GOFJDKBCCCJ);

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void CONHFNOJGHD(AGLPGLMEACF IMMJHCFALCP);

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool JFKHKAGLHKG(AGLPGLMEACF IMMJHCFALCP);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface AHBPLPMPJCP
{
	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLPCFPOLLDL(Entity EIPMCGLLPEP);

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPCKEIEBIJK(Entity EIPMCGLLPEP);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface OBONOIPFGME
{
	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJIOHFEMBNK(AGLPGLMEACF KDGMCPCFIID, bool NHGPHFBFMLJ);

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FCGHOIOHONH(AGLPGLMEACF KDGMCPCFIID, int AEAJAMHEDBI);
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public delegate void FEKDMMCDPBC(BJCIMCPNCKD JLBNPAKKJJF);
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public readonly ref struct BJCIMCPNCKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly BLJMICDPKDA KFGADIJPBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly NativeArray<byte> OHPMALGHLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly NativeArray<byte> AOBOKCCOBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CJLCNFBKAPH KKMBBLBCHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly int GBDDPPBCPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Type PGGBCACLDOO;

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public BLJMICDPKDA BHMBCEIKFGL
	{
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x442C4F0", Offset = "0x442B8F0", VA = "0x18442C4F0")]
		get
		{
			return default(BLJMICDPKDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEBE0", Offset = "0x6EEDFE0", VA = "0x186EEEBE0")]
	public BJCIMCPNCKD(BLJMICDPKDA KFGADIJPBAA, NativeArray<byte> OHPMALGHLNI, NativeArray<byte> AOBOKCCOBLN, CJLCNFBKAPH KKMBBLBCHGP, int GBDDPPBCPFL, Type PGGBCACLDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x2BF3AE0", Offset = "0x2BF2EE0", VA = "0x182BF3AE0")]
	public NativeArray<T> EDCAAGOFGLA<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x2BF3AA0", Offset = "0x2BF2EA0", VA = "0x182BF3AA0")]
	public NativeArray<T> COCDLFGOKAP<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x2BF39B0", Offset = "0x2BF2DB0", VA = "0x182BF39B0")]
	public (BLJMICDPKDA, NativeArray<T>, NativeArray<T>) CADKKGPFCDD<T>() where T : struct
	{
		return default((BLJMICDPKDA, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEBB0", Offset = "0x6EEDFB0", VA = "0x186EEEBB0")]
	public KCBLGEGNIDN KFMJKKCKKNN()
	{
		return default(KCBLGEGNIDN);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface KEGNHOEGKMN
{
	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	string EIFDOFLNDGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	KEGNHOEGKMN KNGKAHGLDDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	IEnumerable<KEGNHOEGKMN> GGAGFMJDCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface FFEMONILCCP
{
	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	KEGNHOEGKMN AJLAGKDGFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	List<MBCPEBKFPIH> JLMNHKKOLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OANIEMCBMMJ(MBCPEBKFPIH ECJEGOAKEPN, [Out] KEGNHOEGKMN KKOJCNMAGAG);

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MHJHNBDIMHP(MBCPEBKFPIH ECJEGOAKEPN, FEKDMMCDPBC ECPFGFOIDFC);

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AMMAKBKKNOC(MBCPEBKFPIH ECJEGOAKEPN, FEKDMMCDPBC ECPFGFOIDFC);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public readonly ref struct KCBLGEGNIDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly BJCIMCPNCKD AIKOCCMKKAE;

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public BLJMICDPKDA BHMBCEIKFGL
	{
		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x442C4F0", Offset = "0x442B8F0", VA = "0x18442C4F0")]
		get
		{
			return default(BLJMICDPKDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8D60", Offset = "0x6EF8160", VA = "0x186EF8D60")]
	public KCBLGEGNIDN(BJCIMCPNCKD AIKOCCMKKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8C90", Offset = "0x6EF8090", VA = "0x186EF8C90")]
	public BLJMICDPKDA EDCAAGOFGLA()
	{
		return default(BLJMICDPKDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8BC0", Offset = "0x6EF7FC0", VA = "0x186EF8BC0")]
	public BLJMICDPKDA COCDLFGOKAP()
	{
		return default(BLJMICDPKDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x6EF89A0", Offset = "0x6EF7DA0", VA = "0x186EF89A0")]
	public (BLJMICDPKDA, BLJMICDPKDA, BLJMICDPKDA) CADKKGPFCDD()
	{
		return default((BLJMICDPKDA, BLJMICDPKDA, BLJMICDPKDA));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[DefaultMember("Item")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface GGCNPEPIDKD : IEnumerable<CNDMFFBIJGK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	NativeBitArray BNNMGEGFHGH
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	NativeBitArray KEIKBDGKDBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	NativeArray<int> CKKIMODFDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	CNDMFFBIJGK MGACFGHHFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	CNDMFFBIJGK MGACFGHHFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CNDMFFBIJGK BABJPJDOBMO(KMEIGJEGBBB BMAAJNANOMC);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CJLCNFBKAPH NFELGNDBNLN(KMEIGJEGBBB BMAAJNANOMC);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class GHBJHJLENAE
{
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
[DefaultMember("Item")]
public interface FDPHJIKHILD : IEnumerable<BDNBHGILHDL>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	BDNBHGILHDL MGACFGHHFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BDNBHGILHDL BABJPJDOBMO(KMEIGJEGBBB BMAAJNANOMC);

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CJLCNFBKAPH NFELGNDBNLN(KMEIGJEGBBB BMAAJNANOMC);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class FFKDBLGMODK
{
	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x2E491B0", Offset = "0x2E485B0", VA = "0x182E491B0")]
	public static CJLCNFBKAPH NFELGNDBNLN<T>(this FDPHJIKHILD FFGFGLBHEDJ, IDCMBOLHKPN<T> DDDHPCNFCEK) where T : struct
	{
		return default(CJLCNFBKAPH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[DefaultMember("Item")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface LHIIGMDKIIG : IEnumerable<MBCPEBKFPIH>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	MBCPEBKFPIH MGACFGHHFEH
	{
		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MBCPEBKFPIH BABJPJDOBMO(KMEIGJEGBBB BMAAJNANOMC);

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CJLCNFBKAPH NFELGNDBNLN(KMEIGJEGBBB BMAAJNANOMC);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public static class IBACNODMOOF
{
	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x2E8A0E0", Offset = "0x2E894E0", VA = "0x182E8A0E0")]
	public static GKBFLFAGBPA<T> BABJPJDOBMO<T>(this LHIIGMDKIIG FFGFGLBHEDJ, KMEIGJEGBBB DDDHPCNFCEK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x2E8A220", Offset = "0x2E89620", VA = "0x182E8A220")]
	public static CJLCNFBKAPH NFELGNDBNLN<T>(this LHIIGMDKIIG FFGFGLBHEDJ, IDCMBOLHKPN<T> DDDHPCNFCEK) where T : struct
	{
		return default(CJLCNFBKAPH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface PGNAGBGCDHO
{
	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHJHNBDIMHP(KMEIGJEGBBB ECJEGOAKEPN, FEKDMMCDPBC ECPFGFOIDFC);

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMMAKBKKNOC(KMEIGJEGBBB ECJEGOAKEPN, FEKDMMCDPBC ECPFGFOIDFC);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public static class JIFLCAEMIIC
{
	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x2EB3FD0", Offset = "0x2EB33D0", VA = "0x182EB3FD0")]
	public static void MHJHNBDIMHP<T>(this PGNAGBGCDHO FLFAFEMJGOG, IDCMBOLHKPN<T> ECJEGOAKEPN, FEKDMMCDPBC ECPFGFOIDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x2EB3C40", Offset = "0x2EB3040", VA = "0x182EB3C40")]
	public static void AMMAKBKKNOC<T>(this PGNAGBGCDHO FLFAFEMJGOG, IDCMBOLHKPN<T> ECJEGOAKEPN, FEKDMMCDPBC ECPFGFOIDFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface MBOEHKPAOAK
{
	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	MEEJFJBMAKC LCLMMKFCAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BPJMCHGPENK(PBFPCCNOOBK LEELLFGMHHO, CJLCNFBKAPH ECJEGOAKEPN);

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BDHAEINFKEF(PBFPCCNOOBK LEELLFGMHHO, Span<CJLCNFBKAPH> FFGFGLBHEDJ, bool AIFDEDNAIHJ);

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NHOGOGIADLC(NativeArray<PBFPCCNOOBK> BIICPJAJNCF);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public static class MNKJEDJGJMP
{
	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB750", Offset = "0x6EFAB50", VA = "0x186EFB750")]
	public static void BDHAEINFKEF(this MBOEHKPAOAK GHKLOPLANHE, PBFPCCNOOBK LEELLFGMHHO, CJLCNFBKAPH ECJEGOAKEPN, bool AIFDEDNAIHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public readonly struct MEEJFJBMAKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly NativeBitArray IKMNKODGDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly NativeParallelHashMap<PBFPCCNOOBK, int> JKJCKKMANNK;

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	public bool MJGGKOLDCNK
	{
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x6EFADB0", Offset = "0x6EFA1B0", VA = "0x186EFADB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x456C5D0", Offset = "0x456B9D0", VA = "0x18456C5D0")]
	public MEEJFJBMAKC(NativeBitArray IKMNKODGDKI, NativeParallelHashMap<PBFPCCNOOBK, int> JKJCKKMANNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x6EFAC80", Offset = "0x6EFA080", VA = "0x186EFAC80")]
	public bool BPJMCHGPENK(PBFPCCNOOBK LEELLFGMHHO, CJLCNFBKAPH ECJEGOAKEPN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface LDCELPPILBK
{
	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LKCMKGLINOK(AGLPGLMEACF IMMJHCFALCP, NJIHLEJAJJC EEPLCHCGAIN);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface DHNDOLFGJKC
{
	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	OIBFOBLKIEF GLMACLHLEPN
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface KFAMFJAELLB
{
	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONDGIFBIMOD(World NNBFJMEFHAJ);

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MHGGEECOPPI(World NNBFJMEFHAJ);

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase IIJCMHBIBNF(World NNBFJMEFHAJ);

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AFAAGFGBIII(World NNBFJMEFHAJ);

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AGJBMIFFHME(World NNBFJMEFHAJ);

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KFOIMNHKHKC(World NNBFJMEFHAJ);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DMFCOKCGAIB(World NNBFJMEFHAJ);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[AEODNGLJNOH(HNNAHENHILF.LoadInstance)]
public interface HCPOBEAGGMH
{
	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OIGIIKKAIPG(AGLPGLMEACF KDHECHILKME, bool EEPLCHCGAIN);
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public readonly struct KBMDGOFPJEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly IEnumerable<AAFDHJHHGMN> FLIDBFKLGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly IReadOnlyList<GameObject> ECLJJGDFAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly IReadOnlyList<int> CHHHFCHPBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly IReadOnlyList<(PBFPCCNOOBK, PBFPCCNOOBK)> PPKAHHLGEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly int NEBNGEGGFDA;

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	public bool CPKPPJFCLGP
	{
		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x6EF88D0", Offset = "0x6EF7CD0", VA = "0x186EF88D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public int LAKABPBAEJO
	{
		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x92A830", Offset = "0x929C30", VA = "0x18092A830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public IEnumerable<GameObject> GAECHPLOBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x92A850", Offset = "0x929C50", VA = "0x18092A850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	public IEnumerable<(PBFPCCNOOBK src, PBFPCCNOOBK dst)> LHMLBNBHDLD
	{
		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8930", Offset = "0x6EF7D30", VA = "0x186EF8930")]
	public KBMDGOFPJEA(IEnumerable<AAFDHJHHGMN> FLIDBFKLGKA, IReadOnlyList<GameObject> ECLJJGDFAAN, IReadOnlyList<int> CHHHFCHPBKI, IReadOnlyList<(PBFPCCNOOBK src, PBFPCCNOOBK dst)> PPKAHHLGEEG, int NEBNGEGGFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8550", Offset = "0x6EF7950", VA = "0x186EF8550")]
	public (GameObject, int)[] FBOOPPENGJK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface BGECJGGCEIF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public class AOOMPGLIAAC
	{
		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public AGLPGLMEACF CNLABKPDMID
		{
			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
			[CompilerGenerated]
			get
			{
				return default(AGLPGLMEACF);
			}
			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x9667D0", Offset = "0x965BD0", VA = "0x1809667D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public UniformTRS NDFEKCEGMHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x3C15FA0", Offset = "0x3C153A0", VA = "0x183C15FA0")]
			[CompilerGenerated]
			get
			{
				return default(UniformTRS);
			}
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x6EEEA00", Offset = "0x6EEDE00", VA = "0x186EEEA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public bool OBDEMNEDNJG
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x92DDA0", Offset = "0x92D1A0", VA = "0x18092DDA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x92DC40", Offset = "0x92D040", VA = "0x18092DC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public IDNINBPMECK AIABCLLKMHO
		{
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x8AD4C0", Offset = "0x8AC8C0", VA = "0x1808AD4C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x8ADA40", Offset = "0x8ACE40", VA = "0x1808ADA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public bool BKEJIEOBHLN
		{
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x9D2310", Offset = "0x9D1710", VA = "0x1809D2310")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0xCD6FE0", Offset = "0xCD63E0", VA = "0x180CD6FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public InventionIdData ADFPMHCIGFP
		{
			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x8ACAF0", Offset = "0x8ABEF0", VA = "0x1808ACAF0")]
			[CompilerGenerated]
			get
			{
				return default(InventionIdData);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0x9850E0", Offset = "0x9844E0", VA = "0x1809850E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public InventionInstanceIdData OFOFOOJGPOL
		{
			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0xB77DB0", Offset = "0xB771B0", VA = "0x180B77DB0")]
			[CompilerGenerated]
			get
			{
				return default(InventionInstanceIdData);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0xB75E70", Offset = "0xB75270", VA = "0x180B75E70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEA10", Offset = "0x6EEDE10", VA = "0x186EEEA10")]
		public AOOMPGLIAAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	bool PGDKMGKLDNH
	{
		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	bool AHJFJDOFCHB
	{
		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	GAEPGBNNILH DLLCEHELOCO
	{
		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FIKDMBCCMKB IOKDHIKMGKN();

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FIKDMBCCMKB NIKKOJAIJKK(IEnumerable<AGLPGLMEACF> CCBEIEEDJFG, [In] UniformTRS GAEIPIFPBKN);

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NCCBKIJOAHP NBGGPGAMCML(ByteString GBNIBGNJPPO);

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EBNLHOPHAFB ICKHNJJAMAE(ByteString GNHHNHJOMCE, AOOMPGLIAAC BJGOCALJFKP);

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MPCJFHBBIFC();

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KBMDGOFPJEA BGGPEKOJAII(IEnumerable<AAFDHJHHGMN> FLIDBFKLGKA);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class NGHHAGDMJAL
{
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface CDFFIIFLPFM
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action FHLNLNDFCBG;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action FLOCPNEIHAF;
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public struct NFPDGEHEBII : CLNAIEHPFCD, IEquatable<NFPDGEHEBII>
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly int NCGEGAOBOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public APJHGHONFKE JJJPIBKENDJ;

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x6EFBA00", Offset = "0x6EFAE00", VA = "0x186EFBA00", Slot = "5")]
	public void AJCCBGLJAMD(HBJAMCDMOCL GDCGEJPDKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x6EFBAD0", Offset = "0x6EFAED0", VA = "0x186EFBAD0", Slot = "4")]
	public void IFDLICGNEEM(EHLKAHPGCDO HOKCJMCABPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x6EFBB00", Offset = "0x6EFAF00", VA = "0x186EFBB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0xCD3550", Offset = "0xCD2950", VA = "0x180CD3550", Slot = "6")]
	public bool Equals(NFPDGEHEBII KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x6EFBA30", Offset = "0x6EFAE30", VA = "0x186EFBA30", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x92A840", Offset = "0x929C40", VA = "0x18092A840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public struct AAFDHJHHGMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Guid GPJCGLBMIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public string IMDAMHNKLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public Vector3 CLHMEGFDOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public Quaternion MDJOMEFJFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public Vector3 KFNOLBCIBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public int GGBKIEPBOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public Dictionary<string, object> BJGOCALJFKP;

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC400", Offset = "0x6EEB800", VA = "0x186EEC400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC280", Offset = "0x6EEB680", VA = "0x186EEC280")]
	private static string NKLNGBBIDNC(Dictionary<string, object> NELNDAHMMFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public enum CMGNNAGLIJH
{
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	SubGraphReplace,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	RestoreCreationData
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public static class JDFPCMAOKCF
{
	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x62C03B0", Offset = "0x62BF7B0", VA = "0x1862C03B0")]
	public static bool PDGEAGPEGEN(this CMGNNAGLIJH DPOLEDLIAMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[Flags]
public enum HBLDKGCMEHM
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	WorldPhasesMaster = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	AdditivePhases = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public interface EBNLHOPHAFB : GAEPGBNNILH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	IDNINBPMECK AIABCLLKMHO
	{
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EPAPKGBPEKK();

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MCEFNCMMHNJ();
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public interface GAEPGBNNILH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	IEnumerable<AAFDHJHHGMN> AFPCANOHOLF
	{
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	KBMDGOFPJEA PIEMIODKMNN
	{
		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	CMGNNAGLIJH NKDPEDOOFIH
	{
		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	LocalId AEIHIHCNPPH
	{
		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	CIAGGIGPIGF GKLJOFEGKAB
	{
		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DNJGMMIDFGL(HBLDKGCMEHM PGAOBOCGFIK);
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public interface IDNINBPMECK
{
	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DAELLOFOICM(Guid CEMFCPJEKHI, [Out] Guid CJFFIHKDKOL);
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public interface NCCBKIJOAHP : GAEPGBNNILH, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[Flags]
public enum APIJPHNALIC
{
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public interface FIKDMBCCMKB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	CIAGGIGPIGF GFAHNHOFOFM
	{
		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString BPPGJPCPHFG();
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public enum LDBMGEEOKIJ
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public delegate bool OKMFHCPBJJN(DHGODGDMNED IAONOEDMCMC, [In] NMBPLOPJKJI EEPLCHCGAIN);
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public delegate bool ILMCLHNKEOO<T>(DHGODGDMNED IAONOEDMCMC, [In] T EEPLCHCGAIN);
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface DHOKKBGKGLP
{
	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHJHNBDIMHP(CJLCNFBKAPH KKMBBLBCHGP, Type JONIGCMCJBF, OKMFHCPBJJN GEBCFJKFAML);

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FEDBOBPJGIH(CJLCNFBKAPH KKMBBLBCHGP, [Out] OKMFHCPBJJN GEBCFJKFAML);
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public static class HGBGGEKDENF
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class EPDMPKMENHC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public ILMCLHNKEOO<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public EPDMPKMENHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x3BBFEC0", Offset = "0x3BBF2C0", VA = "0x183BBFEC0")]
		internal bool DCOCEHGFKLL(DHGODGDMNED pendingList, [In] NMBPLOPJKJI value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x2E71050", Offset = "0x2E70450", VA = "0x182E71050")]
	public static void MHJHNBDIMHP<T>(this DHOKKBGKGLP FLFAFEMJGOG, CJLCNFBKAPH KKMBBLBCHGP, ILMCLHNKEOO<T> GEBCFJKFAML) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x6EF5500", Offset = "0x6EF4900", VA = "0x186EF5500")]
	public static bool CJMHFPGBNOG(this DHOKKBGKGLP FLFAFEMJGOG, DHGODGDMNED IAONOEDMCMC, CJLCNFBKAPH KKMBBLBCHGP, [In] NMBPLOPJKJI EEPLCHCGAIN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface HMDNKMOEAAF
{
	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	uint AGEDBPMHJLI
	{
		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface DHGODGDMNED
{
	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BDPKFFPAOPA(PBFPCCNOOBK EJNNBCHAGCK, CJLCNFBKAPH KKMBBLBCHGP, ReadOnlySpan<byte> LOKIDMIIEPL, ReadOnlySpan<byte> IBBLHIHMNPL);

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GBABGKFKNOK(PBFPCCNOOBK EJNNBCHAGCK, CJLCNFBKAPH KKMBBLBCHGP, ReadOnlySpan<byte> LOKIDMIIEPL, ReadOnlySpan<byte> IBBLHIHMNPL);

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MNAENPAFOMH(PBFPCCNOOBK EJNNBCHAGCK, CJLCNFBKAPH KKMBBLBCHGP);

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DPMMPPPNHKF(PBFPCCNOOBK EJNNBCHAGCK, CJLCNFBKAPH KKMBBLBCHGP, ReadOnlySpan<byte> IBBLHIHMNPL);

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BMJNLLECJHI(PBFPCCNOOBK EJNNBCHAGCK, CJLCNFBKAPH KKMBBLBCHGP, Span<byte> LOKIDMIIEPL, Span<byte> IBBLHIHMNPL);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public static class CDEKHLCGCNF
{
	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x2C4E7E0", Offset = "0x2C4DBE0", VA = "0x182C4E7E0")]
	public static bool BMJNLLECJHI<T>(this DHGODGDMNED IIBKDECDEHD, PBFPCCNOOBK EJNNBCHAGCK, CJLCNFBKAPH KKMBBLBCHGP, [Out] T LOKIDMIIEPL, [Out] T IBBLHIHMNPL) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x2C4E9D0", Offset = "0x2C4DDD0", VA = "0x182C4E9D0")]
	public static bool DPMMPPPNHKF<T>(this DHGODGDMNED IIBKDECDEHD, PBFPCCNOOBK EJNNBCHAGCK, CJLCNFBKAPH KKMBBLBCHGP, T IBBLHIHMNPL) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public enum OALAAFOMLFG
{
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	End,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface BOKHOKFFBII
{
	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ICHGONCOMLO(FFIHPMCHOMJ GHEAAGKLGOO, ReadOnlySpan<byte> GKKLHKCNNPG);

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KOGCHJNHFLK(uint ENHLEGECDIF, ReadOnlySpan<byte> GKKLHKCNNPG);

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJLCKGPILGN(int EJOBBFLFPJI);
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface IJHHBDAPPCN
{
	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FFIHPMCHOMJ BDMBNLJJGHN(ReadOnlySpan<byte> GKKLHKCNNPG);
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface ACIHKKKCHIJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MLNLIMBFACL(FFIHPMCHOMJ OEOMDKHBDFI, ReadOnlySpan<byte> GKKLHKCNNPG);

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EENIGOABKKO(ReadOnlySpan<FFIHPMCHOMJ> FOIFHKIHJMA);
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public struct AKCIIMGNLDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public FFIHPMCHOMJ GHEAAGKLGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public ReadOnlyMemory<byte> GKKLHKCNNPG;
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public struct FFIHPMCHOMJ
{
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static FFIHPMCHOMJ LMDPOOCEMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public uint IGGOHFNFHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public int DNAJFJKBBMG;

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0xA2AE90", Offset = "0xA2A290", VA = "0x180A2AE90")]
	public FFIHPMCHOMJ(uint IGGOHFNFHAE, int DNAJFJKBBMG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x6EF21C0", Offset = "0x6EF15C0", VA = "0x186EF21C0")]
	public static bool LBFMGPFDJNL([In] FFIHPMCHOMJ JKMLNPBBJIG, [In] FFIHPMCHOMJ JDJGFJGMEAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x6EF20D0", Offset = "0x6EF14D0", VA = "0x186EF20D0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2180", Offset = "0x6EF1580", VA = "0x186EF2180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x6EF21E0", Offset = "0x6EF15E0", VA = "0x186EF21E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x6EF21B0", Offset = "0x6EF15B0", VA = "0x186EF21B0")]
	public void KGNAIFFBBCO([Out] uint IGGOHFNFHAE, [Out] int DNAJFJKBBMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface ONOMFEHNOKI : JOJNIKIBCLH<ONOMFEHNOKI>
{
	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FAKKNFFMHEG(CJLCNFBKAPH NKPCGMJMEIE, [Out] ACCMKACBHPC GDOIAPFGEKG);
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class KDBAACOCAMC
{
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface ACCMKACBHPC
{
	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	Type IIOFMOKOIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJCCBGLJAMD(HBJAMCDMOCL GDCGEJPDKCM, Span<byte> KDGMCPCFIID);

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IFDLICGNEEM(EHLKAHPGCDO HOKCJMCABPI, ReadOnlySpan<byte> GHEAAGKLGOO);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class AOANFIHKJNJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public struct JJCGGMLKFDK : ISystemStateComponentData, IComponentData, IEquatable<JJCGGMLKFDK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public float3 GEJINEDEPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public float3 PECPHJKAAPL;

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x6EF7F20", Offset = "0x6EF7320", VA = "0x186EF7F20", Slot = "4")]
	public bool Equals(JJCGGMLKFDK KNLMODPGFOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface IKFEHLBKLJI
{
	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HAAAICPGAIM(long PPKJKMEBCON);

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NGEKAHJAEHH(NativeParallelHashSet<long> HEIAKHDNDDC);

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PEPDILFCDMC(World NNBFJMEFHAJ, NativeParallelHashMap<Guid, long> FIOIDGFGFOO);

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CELANGBDOKH(PBFPCCNOOBK LEELLFGMHHO);

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FCKKDONOHHB(PBFPCCNOOBK LEELLFGMHHO, [Out] Guid OFHHDHLJLKJ, [Out] long PPKJKMEBCON);

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JIIAGPNACEB(PBFPCCNOOBK LEELLFGMHHO, Guid OFHHDHLJLKJ, long PPKJKMEBCON);

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FBMCIJONCNN(Guid OFHHDHLJLKJ);

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MKBEDNFLGDK(Guid OFHHDHLJLKJ, [Out] int GCBPPALDFMC, [Out] int GPGEKAPAEKL);

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PEMFIBFJBII(Guid OFHHDHLJLKJ, int GCBPPALDFMC, int GPGEKAPAEKL);

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BNGKKKMHGNM(Guid OFHHDHLJLKJ);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public class JHDCDGCMADC
{
	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public JHDCDGCMADC()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
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
