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
	public class LogRegistrationIndex : NNEIMJEPGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x64E77C0", Offset = "0x64E69C0", VA = "0x1864E77C0", Slot = "4")]
		public override void FLGJIGKCNJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PHLKHMIHMHD
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x64ECBF0", Offset = "0x64EBDF0", VA = "0x1864ECBF0")]
	public static void BDKKJMDJJKL(this Rigidbody BEKCENIMBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x64ECAC0", Offset = "0x64EBCC0", VA = "0x1864ECAC0")]
	public static void BDKKJMDJJKL(this Rigidbody BEKCENIMBCG, Vector3 NCKAADPONKI, Quaternion DLCGJPBMPJE, Vector3 OGAEMHAPAOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct FLGPIOIONCG : IReadOnlyList<NKJBKLODBOM>, IEnumerable<NKJBKLODBOM>, IEnumerable, IReadOnlyCollection<NKJBKLODBOM>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct OAEBEPKKNON : IEnumerator<NKJBKLODBOM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly EPHMCHMFEHM HODJLJDOIHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator NBJLILNDAJO;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public NKJBKLODBOM NPODDCIDCOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x64EC780", Offset = "0x64EB980", VA = "0x1864EC780", Slot = "4")]
			get
			{
				return default(NKJBKLODBOM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x64EC700", Offset = "0x64EB900", VA = "0x1864EC700", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3F239C0", Offset = "0x3F22BC0", VA = "0x183F239C0")]
		public OAEBEPKKNON(EPHMCHMFEHM HODJLJDOIHB, NativeArray<LocalId>.Enumerator NBJLILNDAJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x64EC640", Offset = "0x64EB840", VA = "0x1864EC640", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x64EC680", Offset = "0x64EB880", VA = "0x1864EC680", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x64EC6C0", Offset = "0x64EB8C0", VA = "0x1864EC6C0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly EPHMCHMFEHM HODJLJDOIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> DOLLNNCPINB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NKJBKLODBOM FOFBNHMHKAA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x64DF8A0", Offset = "0x64DEAA0", VA = "0x1864DF8A0", Slot = "4")]
		get
		{
			return default(NKJBKLODBOM);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x64DF420", Offset = "0x64DE620", VA = "0x1864DF420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int DJPHNFCAEHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C8110", Offset = "0x7C7310", VA = "0x1807C8110", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EPHMCHMFEHM DGOELBMGKDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int BOHPGPGHAFI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C8110", Offset = "0x7C7310", VA = "0x1807C8110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool BOAGEKAOIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x64DF330", Offset = "0x64DE530", VA = "0x1864DF330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> EOGIBFBHNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x241D060", Offset = "0x241C260", VA = "0x18241D060")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> EFPOFPBJEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x64DF240", Offset = "0x64DE440", VA = "0x1864DF240")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x64DF760", Offset = "0x64DE960", VA = "0x1864DF760")]
	public FLGPIOIONCG(int EFDILNFHNJD, EPHMCHMFEHM HODJLJDOIHB, Allocator LGNDPBNMKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3F23CA0", Offset = "0x3F22EA0", VA = "0x183F23CA0")]
	public FLGPIOIONCG(EPHMCHMFEHM HODJLJDOIHB, NativeArray<LocalId> DOLLNNCPINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x64DF650", Offset = "0x64DE850", VA = "0x1864DF650")]
	internal FLGPIOIONCG(EPHMCHMFEHM HODJLJDOIHB, NativeArray<Entity> BGEKIKEJMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x64DF6C0", Offset = "0x64DE8C0", VA = "0x1864DF6C0")]
	public FLGPIOIONCG(EPHMCHMFEHM HODJLJDOIHB, int MKCBFIBLIDD, Allocator LGNDPBNMKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x64DF7F0", Offset = "0x64DE9F0", VA = "0x1864DF7F0")]
	public FLGPIOIONCG(FLGPIOIONCG GNBDDILJCKK, Allocator LGNDPBNMKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x64DF370", Offset = "0x64DE570", VA = "0x1864DF370")]
	public FLGPIOIONCG NJPJPNDOPCO(Allocator LGNDPBNMKMP = Allocator.Temp)
	{
		return default(FLGPIOIONCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x64DF200", Offset = "0x64DE400", VA = "0x1864DF200", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x64DF2A0", Offset = "0x64DE4A0", VA = "0x1864DF2A0")]
	public OAEBEPKKNON KBKKLBPIAFK()
	{
		return default(OAEBEPKKNON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x64DF470", Offset = "0x64DE670", VA = "0x1864DF470", Slot = "6")]
	private IEnumerator<NKJBKLODBOM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x64DF560", Offset = "0x64DE760", VA = "0x1864DF560", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public struct BLFFMLHAEMB : IList<NKJBKLODBOM>, ICollection<NKJBKLODBOM>, IEnumerable<NKJBKLODBOM>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct DFBBBAAKNNB : IEnumerator<NKJBKLODBOM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly EPHMCHMFEHM HODJLJDOIHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator NBJLILNDAJO;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public NKJBKLODBOM NPODDCIDCOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x64DD3B0", Offset = "0x64DC5B0", VA = "0x1864DD3B0", Slot = "4")]
			get
			{
				return default(NKJBKLODBOM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x64DD330", Offset = "0x64DC530", VA = "0x1864DD330", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3F239C0", Offset = "0x3F22BC0", VA = "0x183F239C0")]
		public DFBBBAAKNNB(EPHMCHMFEHM HODJLJDOIHB, NativeArray<LocalId>.Enumerator NBJLILNDAJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x64DD270", Offset = "0x64DC470", VA = "0x1864DD270", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x64DD2B0", Offset = "0x64DC4B0", VA = "0x1864DD2B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x64DD2F0", Offset = "0x64DC4F0", VA = "0x1864DD2F0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly EPHMCHMFEHM HODJLJDOIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> DOLLNNCPINB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NKJBKLODBOM FOFBNHMHKAA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x64DC6F0", Offset = "0x64DB8F0", VA = "0x1864DC6F0", Slot = "4")]
		get
		{
			return default(NKJBKLODBOM);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x64DC770", Offset = "0x64DB970", VA = "0x1864DC770", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int HJGLMCCDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x64DBDF0", Offset = "0x64DAFF0", VA = "0x1864DBDF0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int BOHPGPGHAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x64DBDF0", Offset = "0x64DAFF0", VA = "0x1864DBDF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool PMLPHGCHDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x64DC660", Offset = "0x64DB860", VA = "0x1864DC660")]
	public BLFFMLHAEMB(EPHMCHMFEHM HODJLJDOIHB, int MKCBFIBLIDD, Allocator LGNDPBNMKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x64DC110", Offset = "0x64DB310", VA = "0x1864DC110")]
	public FLGPIOIONCG FDENKPCOFKN()
	{
		return default(FLGPIOIONCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x64DBEB0", Offset = "0x64DB0B0", VA = "0x1864DBEB0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x64DBEF0", Offset = "0x64DB0F0", VA = "0x1864DBEF0", Slot = "13")]
	public bool Contains(NKJBKLODBOM OIJOJELHKIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x64DBF80", Offset = "0x64DB180", VA = "0x1864DBF80", Slot = "14")]
	public void CopyTo(NKJBKLODBOM[] HPGKNFECNHG, int HFIJABHHPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x64DBE30", Offset = "0x64DB030", VA = "0x1864DBE30", Slot = "11")]
	public void Add(NKJBKLODBOM OIJOJELHKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x64DC220", Offset = "0x64DB420", VA = "0x1864DC220", Slot = "7")]
	public void Insert(int PMNHOLIPOMJ, NKJBKLODBOM OIJOJELHKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x64DC3B0", Offset = "0x64DB5B0", VA = "0x1864DC3B0", Slot = "15")]
	public bool Remove(NKJBKLODBOM OIJOJELHKIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x64DC190", Offset = "0x64DB390", VA = "0x1864DC190", Slot = "6")]
	public int IndexOf(NKJBKLODBOM OIJOJELHKIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x64DC360", Offset = "0x64DB560", VA = "0x1864DC360", Slot = "8")]
	public void RemoveAt(int PMNHOLIPOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x64DC0D0", Offset = "0x64DB2D0", VA = "0x1864DC0D0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x64DC2D0", Offset = "0x64DB4D0", VA = "0x1864DC2D0")]
	public DFBBBAAKNNB KBKKLBPIAFK()
	{
		return default(DFBBBAAKNNB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x64DC480", Offset = "0x64DB680", VA = "0x1864DC480", Slot = "16")]
	private IEnumerator<NKJBKLODBOM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x64DC570", Offset = "0x64DB770", VA = "0x1864DC570", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KDKCEOPEEPM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int KFGELKBBELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> BANJGHCGNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NKJBKLODBOM AOAMADOBKJA(NKJBKLODBOM DOLLNNCPINB);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DMFHNIEKGKJ : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface MAEFPPEBHNC : DMPONJNKEBA, MLAHKJBCIOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool ICKIPDGCPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	EGDBHGLKBDP ONIFPJMBPKO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	ANKPABKKNLD FCNHNAJCBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	EPHCHEDHFPC MKJOLGNKEPP
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	EEAEPACFKID DBCPNIEPHPD
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	NJGGKCKMDDO JAAMONNBCDL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface MLAHKJBCIOP
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool EHNLPDCDCKF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface ADHCNHDIAEH
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEGDFIBMBDO(bool HLCKBKFCMPI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface EEAEPACFKID
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool EFCLHOABANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PAMGBHNKOBP;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HPAJMKBLBNL(bool IJMGAKGNGDB);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ONOLIJFDIID(ByteString FENHJHOBMAI);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FLIIJMKKGAO();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IFMNAPOIJNJ();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JEDAIOBHIMI();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface EPHCHEDHFPC
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	JGBBAMADHPC ONIFPJMBPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	ANKPABKKNLD FCNHNAJCBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	APCMOMBHJDC MEIGPDMBGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	MAEFPPEBHNC AEDHPFKJGGP
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	EPHMCHMFEHM DGOELBMGKDO
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	PCDCMHBMMHN LFAOMMHPIGB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	POENGOLNAPO OLOOEHBOGJL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	BBGEKGIFDCN JPDGDIHOADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	CIJPBBJALDI IFBCDMNOKDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	KFOOIFGGANC CIJDICNLPJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	EDINHEBNCMI BCPIDIPFEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	FEMEOHGPJIO CBBDKBJNJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	GFBGEFGOCGN OEIFPJFNDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	EBKKKPHJKGB HCAGHJENMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	ICFGFGDIJLB EELEFEDIIII
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	OINOKJPDJJO ANGDHJNMONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	IOIHFMFNNMN CPKOANNHOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	EPIKFCIMLBH LBNENJMFMML
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	GOCNJIDFDDI JLACOKMDCFB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	JOHINECKDDP NIDPANKMMIM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	DDODHCOINEI DMOEOOGDHDE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	OPBMJCKFKEN GKELBPLOLNP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	FDOBNPHKCKF GMBOAOJNJHF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	DDOGGLEPLPC HCDKMFNEGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	OIIICELEAFK BMDGDKJLLKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(AEMKCDJDKMC))]
public readonly struct NKJBKLODBOM : IComparable<NKJBKLODBOM>, IEquatable<NKJBKLODBOM>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly NKJBKLODBOM LCFMFCBHMEC;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int HGCHAAOJODC = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int CPIGKBHMBAM = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int FJFINDHFCPO = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int GKDNCGDNAAJ = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId LMABLLHEJEF;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public EPHMCHMFEHM DGOELBMGKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x64DCB10", Offset = "0x64DBD10", VA = "0x1864DCB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public MAEFPPEBHNC AEDHPFKJGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x64EBC00", Offset = "0x64EAE00", VA = "0x1864EBC00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public LocalId BHPDAFCHNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x64EBCB0", Offset = "0x64EAEB0", VA = "0x1864EBCB0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal NJGGKCKMDDO JAAMONNBCDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x64EBA50", Offset = "0x64EAC50", VA = "0x1864EBA50")]
		get
		{
			return default(NJGGKCKMDDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool ABDMLBNKFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x64EBE90", Offset = "0x64EB090", VA = "0x1864EBE90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private bool MBHIAAGJNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x64EBC60", Offset = "0x64EAE60", VA = "0x1864EBC60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x64EC100", Offset = "0x64EB300", VA = "0x1864EC100")]
	public NKJBKLODBOM(EPHMCHMFEHM LBEMCDAKHCF, LocalId LMABLLHEJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
	public HHOEFFJIFCP NEEBFMIEOAI()
	{
		return default(HHOEFFJIFCP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x64EBE10", Offset = "0x64EB010", VA = "0x1864EBE10")]
	public static LocalId LOFAPGLBJHK(NKJBKLODBOM CCIFJGPPLCN)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x64EBE50", Offset = "0x64EB050", VA = "0x1864EBE50")]
	public static Entity LOFAPGLBJHK(NKJBKLODBOM CCIFJGPPLCN)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x64EBCF0", Offset = "0x64EAEF0", VA = "0x1864EBCF0")]
	public static bool LOAKJDDAMKI(NKJBKLODBOM BPOHBPAMNLC, NKJBKLODBOM NOIIDJMAOFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x64DB770", Offset = "0x64DA970", VA = "0x1864DB770")]
	public static bool IICOCCMJGPI(NKJBKLODBOM BPOHBPAMNLC, NKJBKLODBOM NOIIDJMAOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x64EBFD0", Offset = "0x64EB1D0", VA = "0x1864EBFD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x64EBA60", Offset = "0x64EAC60", VA = "0x1864EBA60", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x64DB610", Offset = "0x64DA810", VA = "0x1864DB610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x64EB970", Offset = "0x64EAB70", VA = "0x1864EB970", Slot = "4")]
	public int CompareTo(NKJBKLODBOM JPLJHFMPDFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x64DB510", Offset = "0x64DA710", VA = "0x1864DB510", Slot = "5")]
	public bool Equals(NKJBKLODBOM JPLJHFMPDFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KPNMLPDHDOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x64E7360", Offset = "0x64E6560", VA = "0x1864E7360")]
	public static AOHONJCJOFF AKBHHHODFAN(this NKJBKLODBOM CDJAKLIPEBF)
	{
		return default(AOHONJCJOFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x64E7410", Offset = "0x64E6610", VA = "0x1864E7410")]
	public static HHOEFFJIFCP GODEALJNCAH(this NKJBKLODBOM CDJAKLIPEBF, [Optional] object CEFPPEHCFCF)
	{
		return default(HHOEFFJIFCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2A2CE90", Offset = "0x2A2C090", VA = "0x182A2CE90")]
	public static T ALHCIKMCCFB<T>(this NKJBKLODBOM CDJAKLIPEBF) where T : struct, GKOELECAOJK
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class AEMKCDJDKMC
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct NJGGKCKMDDO : IEquatable<NJGGKCKMDDO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte DHPHAFDDMEE;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] PCCLDFEANNE;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static EPHMCHMFEHM GLBGKDJOFHI;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static MAEFPPEBHNC HNLLHBPHEHF;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static EPHMCHMFEHM[] LHKOAAGCHMJ;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static MAEFPPEBHNC[] OMEKHJDJCGF;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> AGHKDHCIGHM;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public MAEFPPEBHNC AEDHPFKJGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x64EB120", Offset = "0x64EA320", VA = "0x1864EB120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public EPHMCHMFEHM NLJCCDJLCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x64EB4C0", Offset = "0x64EA6C0", VA = "0x1864EB4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x64EB960", Offset = "0x64EAB60", VA = "0x1864EB960")]
	static NJGGKCKMDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xD65FE0", Offset = "0xD651E0", VA = "0x180D65FE0")]
	internal NJGGKCKMDDO(byte HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x56B6390", Offset = "0x56B5590", VA = "0x1856B6390", Slot = "4")]
	public bool Equals(NJGGKCKMDDO JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x64EB000", Offset = "0x64EA200", VA = "0x1864EB000", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1C8DA40", Offset = "0x1C8CC40", VA = "0x181C8DA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x64EB8A0", Offset = "0x64EAAA0", VA = "0x1864EB8A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x64EB7F0", Offset = "0x64EA9F0", VA = "0x1864EB7F0")]
	private static EPHMCHMFEHM OPIJFNEEEBC(byte DHPHAFDDMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x64EB730", Offset = "0x64EA930", VA = "0x1864EB730")]
	private static MAEFPPEBHNC MHNHKPHDHNB(byte DHPHAFDDMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x64EB5C0", Offset = "0x64EA7C0", VA = "0x1864EB5C0")]
	private static object KEMAEEGHDAI(byte DHPHAFDDMEE, object[] IJMHBFBFIEM, object AKBALOLNFML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x64EB5B0", Offset = "0x64EA7B0", VA = "0x1864EB5B0")]
	private static int IKKNDGLGFIK(byte DHPHAFDDMEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x64EB5A0", Offset = "0x64EA7A0", VA = "0x1864EB5A0")]
	private static int HLHMOABNCIK(byte DHPHAFDDMEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x64EB0A0", Offset = "0x64EA2A0", VA = "0x1864EB0A0")]
	private static (int, int) FBNJKCINGBM(byte DHPHAFDDMEE)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x64EB7E0", Offset = "0x64EA9E0", VA = "0x1864EB7E0")]
	private static byte OEBDONLOEAN(int DHGBHLPPCDP, int PMNHOLIPOMJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x64EB200", Offset = "0x64EA400", VA = "0x1864EB200")]
	internal static NJGGKCKMDDO FLGJIGKCNJL(MAEFPPEBHNC AOOCIDGAOJB, EPHMCHMFEHM PEBHIMIDFDE)
	{
		return default(NJGGKCKMDDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x64EAA60", Offset = "0x64E9C60", VA = "0x1864EAA60")]
	internal static void EDLBJFIEJDL(NJGGKCKMDDO DHPHAFDDMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x64EAC70", Offset = "0x64E9E70", VA = "0x1864EAC70")]
	private static void EIHFHHLBIBJ(int EFDILNFHNJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface OIJPFCKCMBO
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IMBPLCEGLOK();

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIHNMAKMKFJ(bool KPCFNMLCDMO);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CNHKDBABIFL(GameObject IIDBEBHLIGH);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface GGHMOKMPLMD
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	Guid ENNOCKDDAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IDJFPAMKFEI(Guid BAHDEKEPJHM, Guid KBIFNAMBNMF);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task IECNPCHHCHP(NKJBKLODBOM MCGAOEPIELG);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PJOMECBFBJA(NKJBKLODBOM POGNIHKEPMJ, NKJBKLODBOM BGILIGANMHA, [Out] Vector3 AMCKGDEABAD, [Out] Quaternion HKEEEIOLJKM);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CAMINMCEJOJ(DIFKHEIHLBE PBPLOPDAANA, Vector3 AMCKGDEABAD, Quaternion HKEEEIOLJKM);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OOAPLGEINOA(NKJBKLODBOM FLENJGBLJAL, [Out] Vector3 KGAJFGOBHPF, [Out] Quaternion PIAMLBPJCEF);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface FGMEIDDJKDF
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEFJOGBMLNF(FLGPIOIONCG DOLLNNCPINB);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface OIILMAIOAIO
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFGGDCBKCFF(GameObject FNFGKJDNINF, GameObject MHKNIMCKJEL, int IOLMDHFIFNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface ANKPABKKNLD
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	OIJPFCKCMBO FDPCJGIFOBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	EJLIGHAOBJM JKNPDELAPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	KANOHLNGNOO PIPKNHKKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	FKHDHNFADPD GLFBKDJPLPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	AEHFOGLNNGC OHAEBFGEIHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	CDBLNNPKCCF CKGFAEMFCDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	NDNIBLOFLCC MPHKFPOCDEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	HGKGBKHEMBK PBIOBPBKFFM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	CFFAMJBCFBK JFMLIEELMLF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface HIKAMJNFDGH
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGDFMBPBEOL(Action BGMBJALDBDD, bool KGNAAGECGBK);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DKAOFJBNCPE(string IIADHBOODBK);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface EJLIGHAOBJM
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string ANPDIEJBKEC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] FIMCABDBHAE(IEnumerable<CEANAOOGMEO> BGGLMHCGIFB);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IBOCPGGFNDB(GameObject IIDBEBHLIGH, [Out] AOHONJCJOFF[] BHCHGCPMHAI);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JFJCHHBLFGJ(GameObject IIDBEBHLIGH, [Out] int HHOMHHPADCP, [Out] LFJMPPMLIHF KCLAFPDDNOC);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MBENLKIEPOK NLPJNJMLNDJ(CEANAOOGMEO DAFMLJPHFGN);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MBENLKIEPOK NLPJNJMLNDJ(string HDOGLMBKHEN, AOHONJCJOFF[] OLFMODBDOAG, Vector3 CAOOPLKANIG, Quaternion JCCMNAMJFGM, Vector3 MGKBJKPBCFA);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GameObject BHJEAEIOBGI(string HDOGLMBKHEN);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IEPGDDELNLO(GameObject LBFFEGHGLFA, bool OAPODLLOLMF);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JAJNDHOBEEG(GameObject IIDBEBHLIGH, bool CDDGCFAMECA, bool CBNHPHOCABK);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class PNBPEOCINCF
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x64ED620", Offset = "0x64EC820", VA = "0x1864ED620")]
	public static MBENLKIEPOK NLPJNJMLNDJ(this EJLIGHAOBJM BJEABGEEHGJ, Vector3 CAOOPLKANIG, Quaternion JCCMNAMJFGM, Vector3 MGKBJKPBCFA, params AOHONJCJOFF[] BHCHGCPMHAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface KANOHLNGNOO
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCKMCPAAFHA(bool IJMGAKGNGDB);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface FKHDHNFADPD
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool IJAOHIGAJFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool HGMINGHHBIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool CFNDCGBJLPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	int FPLEIJNHIKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool NPBAAHACMGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IKBPLILOLFK(object EIAKFCMMIEA);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KMCCFBCGEHH(object EIAKFCMMIEA);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BCOPAKGGKEC(object FMEDEJNEJHJ);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NLGDPMMBMFK(object FMEDEJNEJHJ);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int KDJCLCOBPBM(GameObject KGIANBEAMHM);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AMFIFNBBKII(NativeArray<int> MGHAKCEBEDI);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PHLODGJDNGI(NativeArray<int> MOBHEICAGFA);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CCBPJLCGNKG();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void COKEABFNILF(uint LBEICOGLEFF, ReadOnlySpan<byte> BFIIAKLKPOP, bool FLLMIHGKOIK = false);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void COKEABFNILF(uint LBEICOGLEFF, ReadOnlySpan<byte> BFIIAKLKPOP, ReadOnlySpan<byte> GLDBBLJDJKE, bool FLLMIHGKOIK = false);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface AEHFOGLNNGC
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JACBIMKBPAB(GameObject IIDBEBHLIGH);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface ACPGHBCMIGJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPFKBPPOLGG(string PPGBBBOBJLN);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface EHPIBEMFJDB
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int OGJMJNNPOMN(GameObject IIDBEBHLIGH);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CJEGPNABFAP(GameObject IIDBEBHLIGH);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IEHEFAHAFMD(int HGLMKMOLHBA);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object MABDKDEHNOK(NKJBKLODBOM LMABLLHEJEF, GameObject IIDBEBHLIGH, Action<NKJBKLODBOM, int> GPGHCLCHGND);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CMBPDGJNMOE(GameObject IIDBEBHLIGH, object CJNIDNBPBIM);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface JLENNCMLJIE
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool NDAPDKELNLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate MECPDIPMIIL(FNCPACBDGLM.OEAJNEMPBOD IMHIJKPFGGM, Action<FNCPACBDGLM.OEAJNEMPBOD> GPGHCLCHGND);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFNGMMLPBEI(FNCPACBDGLM.OEAJNEMPBOD IMHIJKPFGGM, Delegate GPGHCLCHGND);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate FIEBOOKPKHK(FNCPACBDGLM.OEAJNEMPBOD IMHIJKPFGGM, Action<FNCPACBDGLM.OEAJNEMPBOD> HNNDNHHCDFP);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HOPLIKPJKLM(FNCPACBDGLM.OEAJNEMPBOD IMHIJKPFGGM, Delegate GPGHCLCHGND);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HOAOHAGBBLB(FNCPACBDGLM.OEAJNEMPBOD IMHIJKPFGGM);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FNCPACBDGLM.OEAJNEMPBOD LMLPFPPKNEK(GameObject IIDBEBHLIGH);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface CDBLNNPKCCF
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	int BOOFLHJDPLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	int ABBAKNJEILJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int HHHIPHGBFOG(GameObject IIDBEBHLIGH);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DGHMJHFFJNB([Out] Vector3 CAOOPLKANIG);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AGOJMOKFCCB();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface NDNIBLOFLCC
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool EFCLHOABANE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool IOPFPFGMOLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface OCFKIGACIGF
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	PLKBHOHMKKK GMCOKPHGCGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	KKILDLONEMD HANBDOLPOGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AFFGMLLJNGO(Transform HANHCEFMJDD);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AKABLFDNHKI(Transform HANHCEFMJDD, GFBGGLPIGEH IHEBEMBCGPI);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HCNIHEALNAL(Transform HANHCEFMJDD, IGEOLMBFFAJ CLCCJLMKKCB);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface HGKGBKHEMBK
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OMGNLENLENE();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface CFFAMJBCFBK
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action PDPHNPEGNAK;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GCMBILHNMLD(FLGPIOIONCG FMJABFOFEGM, bool BKHJHFKALNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface GABDBDCCNGI
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLDOEAELMLM();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface AJPEJPBFJLI
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LFJMPPMLIHF KAMAEJBOKEA(GameObject KGIANBEAMHM);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EEGCPJEOBCM(GameObject IIDBEBHLIGH, BPFEAHFPDEI GEJNGCANKAM, MJCCNDEFHPO CLCKPKMOPLA);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string JACFDPJKHLL(int IFAFPBGLEJO);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int ONOIGIGDFAD(string KKPDFEBGEBN);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FGGHFHJIBJJ(NKJBKLODBOM LMABLLHEJEF, int[] IHLALKIMHCE);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BHIOFGMAKBA(InteractionFilterData JLJKEBMIIPF, int MDCNPPDPLHN);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ILBIOEPKLOJ(NKJBKLODBOM LMABLLHEJEF, int IHLALKIMHCE);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NFJJLIBAJCA(NKJBKLODBOM LMABLLHEJEF, int IHLALKIMHCE);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HNCCCPNLBFD(NKJBKLODBOM LMABLLHEJEF, bool BAHHACJIMCB, float3 PIIKEOFEBAO, quaternion PNNHGMGJLNM);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct GELJCPNJGGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly DGEBKPDECGK IFNAKMJKBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly DGEBKPDECGK AADBIEHCAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal readonly uint KGOALIJAKHO;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x64E0310", Offset = "0x64DF510", VA = "0x1864E0310", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct GCFGGCBNIKM
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly LBOEGNBEJHN AMPJEKFBOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly GELJCPNJGGA BGMBJALDBDD;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x64DF8E0", Offset = "0x64DEAE0", VA = "0x1864DF8E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct KBFICALKMBD
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly LBOEGNBEJHN AMPJEKFBOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly GELJCPNJGGA BGMBJALDBDD;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x64DF8E0", Offset = "0x64DEAE0", VA = "0x1864DF8E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct KHNAKOKAJID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint KGOALIJAKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly bool FEKHJELHLMO;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x64E72C0", Offset = "0x64E64C0", VA = "0x1864E72C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct DGEBKPDECGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal int CFPEDCFCDGK;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x64DD400", Offset = "0x64DC600", VA = "0x1864DD400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface OBCJBDDNLNO
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	PHJAIHJFMED FMCEINGDOJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public enum OEMEFAPEALG
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
public interface MBENLKIEPOK : HOAAILCELBK
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	HHOEFFJIFCP FNJNMMOAFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	OEMEFAPEALG IFIBBEEIBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool OPOGGCFOHDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	GameObject IIDBEBHLIGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<MBENLKIEPOK> NCJMMLEGMJD;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(APCMOMBHJDC JNALJCCENAG, NKJBKLODBOM AFPGOBDHGKJ);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool JFOOCHOHNKM);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class NFCJLIMFKHI
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x64EA980", Offset = "0x64E9B80", VA = "0x1864EA980")]
	public static bool BKJJHFLKEBA(this MBENLKIEPOK JGNFNCCPLCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x64EA930", Offset = "0x64E9B30", VA = "0x1864EA930")]
	public static bool BEKOBAHIPIB(this MBENLKIEPOK JGNFNCCPLCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x64EA8E0", Offset = "0x64E9AE0", VA = "0x1864EA8E0")]
	public static bool BAFBKKHGKAO(this MBENLKIEPOK JGNFNCCPLCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x64EA9D0", Offset = "0x64E9BD0", VA = "0x1864EA9D0")]
	public static bool ICKIPDGCPNL(this MBENLKIEPOK JGNFNCCPLCB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface HOAAILCELBK
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool CABIBPNMJEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	NKJBKLODBOM NIMFNJAPLNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[FNBGDBIFOLG(OLEKGNKHMMB.LoadInstance)]
internal interface NNKJJHBDJFN
{
	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<PGLDIBNMGHH> JBAFDAACOIM;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface IANJAOACEII
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface EBIKELFHKPD
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(JIFDJNGDNBF JOJFMJLDCKB);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface JIFDJNGDNBF
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	GameObject IIDBEBHLIGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	Transform HANHCEFMJDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	MLBMNLCAMKC GFNHPIPGGIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool LOOOHCEIAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JDIILGELAHJ(MLBMNLCAMKC FNFDOEGAMFP);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface MLBMNLCAMKC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	NKJBKLODBOM NIMFNJAPLNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	Rigidbody HKCDHJFADIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	JIFDJNGDNBF LGFACAOBOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	GameObject ABFNCMAFNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	Transform CGDFLGLNEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	MLBMNLCAMKC DPGEGBIPNMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	MLBMNLCAMKC LHCGPINMKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	int GGLIOEIHAGG
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool HOAOHAGBBLB
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	bool HEJDBCNPDEG
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	HGDEADHMLPB PAEMNMIPHFK
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "31")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	ADACCNNPCMH NHGOIAIBBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	float CLHNPKJEKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "35")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	Vector3 BJEPGMCEGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	Vector3 OKJJBAPADJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Vector3 PFKDBCAEKBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 MPOGMCLMGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	bool MIHCFFEIEJD
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	bool JIFBIHHBFHC
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	bool ILNPIGNFNGC
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	Vector3 FAJCEAKEFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 IECIKDIFPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Vector3 DNFOLPHPADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "50")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	Vector3 BGJFBCMDJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float GBEJFLLHBCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	float CJALDMPNNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 LEMDFFDMIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Quaternion PBEMDKEHNKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float NCLNCILOJCN
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	float HLOFEGMDDPH
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	bool ANNDCPJNOEC
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	HLACIDOJOGN EAELJIAICHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	bool NAKOAPFAJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Transform KAIPCDOFCKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Vector3 MHPPJPHAOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	float HGONEJLKJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	float AECLGOKMGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Quaternion HGAAFJGFGCB
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Vector3 IKDGFFADEMN
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Quaternion MBPJHPHFEML
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	RigidbodyConstraints MGBDMOMNEAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool JPAFICCGOKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	CollisionDetectionMode OLHKHODMHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	bool MAOCKBIGHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event AJLICCNEBGN HJBGBJDDJNN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event AJLICCNEBGN ACGNDKIELMB;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event AJLICCNEBGN PAIFKHNNABM;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event AJLICCNEBGN EPIBEKDMNGD;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event AJLICCNEBGN GEOLLDMFHDC;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event AJLICCNEBGN LLBODENLJJG;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event AJLICCNEBGN JAKODDHNACF;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event JCLJMAKIKCG HNFDIBDHMFG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<IEIKJHNHGAC, IEIKJHNHGAC> CPBOLKGBPPH;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	MLBMNLCAMKC KBOMDFOMOPE(int PMNHOLIPOMJ);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void KMPMDCIKOCD((Quaternion rot, Vector3 moments) HOGIILJMFNM);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void GENMKELLIEJ();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void JOBLCGKNBGB();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void IICMOCFDDKJ();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void DDNJLABBBKN();

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void NDMMKDCEAMC(MLBMNLCAMKC HLCKBKFCMPI, bool KHENNGFPBJA = false);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void BKLGBNGLILO(object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void MEACGFOKMIK(object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 GAHFGNCCNEI(Vector3 AFMJJPANOMP);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "95")]
	Vector3 KBECBHDFLBL(Vector3 FGFDGBCPILN);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void HDPLKKMDNPD();

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void AHDMJDPBIAO();

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void PAOJHICNPLG();

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void JIBBKGEAECD(Vector3 JJJBAPONEMM, Vector3 IJOJBCPABEP);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void MLPLNPGBJBG(Vector3 NLCAFHPBMBL, Vector3 CBADBDPEHDG);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void IEKNJPPHKKM(Vector3 EHKJBKDMPFH);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void LAFFEJBOCJB(GFDEOLECDKI PDKKCJGKJON, Vector3 BBLCKOPMCNG, float FDFBILKKBBE, float MKNLLALMFAI = 8f, float KOGOLPMGEIH = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void ALIEEIAANFJ(JCMCBMFLILG BFMIDLCNFLF, Vector3 PADGEFFBBON, float PGKGMEEJICP = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void HLMADCNFDJO(JCMCBMFLILG BFMIDLCNFLF, Vector3 JCCMNAMJFGM, float JAOCLLEPJKG = 7f, float CIJCOKDJPCK = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "105")]
	Vector3 NCPGDGBHEKB(Vector3 HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "106")]
	Vector3 AEFNPINOLPP(Vector3 HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void LMIPMOKCPOD();

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void CFKOPIEACGH(MLBMNLCAMKC FJHBOCHLGKB, object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "109")]
	void LNFMIFDCAHO(object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void KPDDLMJMCOA();

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void MEMNDDBKPBK();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void CPDCLMMKGOM();

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "113")]
	bool IMDPPCPMHKN();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void PPALGMNDKAC();

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void PEJPDILMIBL(object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "116")]
	void KANKOMFMBOD(object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void GPDCEJFENKH(object CEFPPEHCFCF, bool FBFCNIMNMCH);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void JLAOEDDFNBO(Vector3 LMOBBILKECB, Quaternion LDLNNPHEAPK);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void MPLGNHELLDA(Vector3 BOALPCHKKBL, Quaternion PMOGLIHDKBD);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "120")]
	bool CKFHMCFEMKA(float ONKBHOLJPKL);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void BGIHIOEEFNM(object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void GJFNAJLEKPJ(object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void HABHNOOKKKB(object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void ENDPKLCJOGC(object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void BCIDKICACAE(Vector3 LBPGAAMAJKE, ForceMode KEFPKBHNHNL = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void NLEGEFDHPLD(Vector3 LBPGAAMAJKE, Vector3 CAOOPLKANIG, ForceMode KEFPKBHNHNL);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void NBFMPPOMLMG(Vector3 CCLGGMMGBEG, ForceMode KEFPKBHNHNL = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void MNBILPCOKHG(Vector3 CCLGGMMGBEG, ForceMode KEFPKBHNHNL = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "129")]
	bool BBLEMPEKGOP(Vector3 GDLGHHBOJHM, [Out] RaycastHit MBAPAGKHAEB, float DLJLDGNAIFD);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void HLKCDMOBFPJ();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface ADACCNNPCMH
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIFKAKALNCL(Vector3 OLHJJKAKEPM);

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HHLFDMHANBG(Vector3 MELEABFLNHP);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HPBBFCDOHPG(Vector3 OLHJJKAKEPM);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OJFMFGMNDIL(Vector3 MELEABFLNHP);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface HGDEADHMLPB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 AKPALBGAJLD();

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 EJCJDNGCOPB();
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public delegate void AJLICCNEBGN(JIFDJNGDNBF DCGPMNLAODD);
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum OHDDGIHNAPI
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
public enum GFDEOLECDKI
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
public delegate void JCLJMAKIKCG(JIFDJNGDNBF DCGPMNLAODD, bool KHENNGFPBJA = false);
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum JCMCBMFLILG
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct KIHAJJACEBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Rigidbody IOIJBGDBPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object MBBBGFBBHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Vector3 FOBAICDJODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Vector3 FLPHCNMPJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public MGOCMEIHPAH OOIAPDIEPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public bool OLGEPJOGILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public bool LDKPOJONMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool CNMKNLNAKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public bool JGIJFJENIOC;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface IJOCAJGKIAB : FGFGJKMFKFP<AOHONJCJOFF>, NDLICJEMNKE, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface GCHMKHMAHKM<T> : CEFAHHHBJMB<AOHONJCJOFF, T>, FGFGJKMFKFP<AOHONJCJOFF>, NDLICJEMNKE, IDisposable, IJOCAJGKIAB where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class OCJJDBLKJHJ
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x29D7BD0", Offset = "0x29D6DD0", VA = "0x1829D7BD0")]
	public static bool AAGKBFDKAOO<T>(this FGFGJKMFKFP<AOHONJCJOFF> EHMJOHOMDOD, AOHONJCJOFF OLFMODBDOAG, [Out] T HLCKBKFCMPI) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x2774630", Offset = "0x2773830", VA = "0x182774630")]
	public static bool HNJFJKPNHAB<T>(this FGFGJKMFKFP<AOHONJCJOFF> EHMJOHOMDOD, AOHONJCJOFF OLFMODBDOAG, [In] T LMGOHOIPBAN) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface OOBELHIGCDM : FGFGJKMFKFP<NKJBKLODBOM>, NDLICJEMNKE, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface CDJAHFBFNFL<T> : CEFAHHHBJMB<NKJBKLODBOM, T>, FGFGJKMFKFP<NKJBKLODBOM>, NDLICJEMNKE, IDisposable, OOBELHIGCDM where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class CJJPONBHPAJ
{
	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x27744D0", Offset = "0x27736D0", VA = "0x1827744D0")]
	public static T JIBGFLOLNJM<T>(this FGFGJKMFKFP<NKJBKLODBOM> EHMJOHOMDOD, NKJBKLODBOM LMABLLHEJEF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x2774760", Offset = "0x2773960", VA = "0x182774760")]
	public static bool HNJFJKPNHAB<T>(this FGFGJKMFKFP<NKJBKLODBOM> EHMJOHOMDOD, NKJBKLODBOM LMABLLHEJEF, [In] T LMGOHOIPBAN) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct FEKOGHEDMJE : IComparable<FEKOGHEDMJE>, IEquatable<FEKOGHEDMJE>
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly FEKOGHEDMJE LCFMFCBHMEC;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly FEKOGHEDMJE IPOICMPCNJF;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly FEKOGHEDMJE APCDOAGPENE;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly FEKOGHEDMJE LKKFKBMCJJH;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly FEKOGHEDMJE FGPDADHDLAK;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly FEKOGHEDMJE JOIGGIMKMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public int DMDPAHAMEGP;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool CGIBHOJOBJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x64DF090", Offset = "0x64DE290", VA = "0x1864DF090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int HLFPLFINCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x64DF0A0", Offset = "0x64DE2A0", VA = "0x1864DF0A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x9CBB80", Offset = "0x9CAD80", VA = "0x1809CBB80")]
	public FEKOGHEDMJE(int PMNHOLIPOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x64DF030", Offset = "0x64DE230", VA = "0x1864DF030", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x64DEFA0", Offset = "0x64DE1A0", VA = "0x1864DEFA0", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x92A880", Offset = "0x929A80", VA = "0x18092A880", Slot = "5")]
	public bool Equals(FEKOGHEDMJE JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x19A1470", Offset = "0x19A0670", VA = "0x1819A1470", Slot = "4")]
	public int CompareTo(FEKOGHEDMJE JPLJHFMPDFD)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0xD96860", Offset = "0xD95A60", VA = "0x180D96860")]
	public static FEKOGHEDMJE LOFAPGLBJHK(int PMNHOLIPOMJ)
	{
		return default(FEKOGHEDMJE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0xD96860", Offset = "0xD95A60", VA = "0x180D96860")]
	public static int LOFAPGLBJHK(FEKOGHEDMJE FNCDBPBCGFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x64DF0B0", Offset = "0x64DE2B0", VA = "0x1864DF0B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct HHOEFFJIFCP : IEquatable<HHOEFFJIFCP>, HOAAILCELBK
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly HHOEFFJIFCP JIBJIEJDBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly NKJBKLODBOM IAODGFOMGBJ;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public NKJBKLODBOM NIMFNJAPLNP
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70", Slot = "6")]
		get
		{
			return default(NKJBKLODBOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public HGFAIFHKIIG CGDFLGLNEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HGFAIFHKIIG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public GCJOKAPNNEP LFAOMMHPIGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(GCJOKAPNNEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private EPHMCHMFEHM DGOELBMGKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x64DCB10", Offset = "0x64DBD10", VA = "0x1864DCB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GameObject IIDBEBHLIGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x64E4B80", Offset = "0x64E3D80", VA = "0x1864E4B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public AOHONJCJOFF MPHNCNFJNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x64E4900", Offset = "0x64E3B00", VA = "0x1864E4900")]
		get
		{
			return default(AOHONJCJOFF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public CDEBHKLHJMI GIHOFMNANOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x64E4D30", Offset = "0x64E3F30", VA = "0x1864E4D30")]
		get
		{
			return default(CDEBHKLHJMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public LFJMPPMLIHF KDHFFFBGMIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x64E49E0", Offset = "0x64E3BE0", VA = "0x1864E49E0")]
		get
		{
			return default(LFJMPPMLIHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool CPHJBDKLFHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x64E4350", Offset = "0x64E3550", VA = "0x1864E4350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool CNBIJJIEJHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x64E4D10", Offset = "0x64E3F10", VA = "0x1864E4D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool KFFEAKNPLLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x64E45C0", Offset = "0x64E37C0", VA = "0x1864E45C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool JODGLOKLOFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x64E48E0", Offset = "0x64E3AE0", VA = "0x1864E48E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool FNCNPNJBIME
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x64E4370", Offset = "0x64E3570", VA = "0x1864E4370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool BMEHHCKKNNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x64E49A0", Offset = "0x64E3BA0", VA = "0x1864E49A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool NOBNIFCPCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x64E4390", Offset = "0x64E3590", VA = "0x1864E4390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool AHLDPAANADE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x64E4490", Offset = "0x64E3690", VA = "0x1864E4490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool MECLAPHBEDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x64E4700", Offset = "0x64E3900", VA = "0x1864E4700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public PLDIEBOKBPG BAFKNLFFILN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(PLDIEBOKBPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public CDPFICJJMIH PHAGKNCHCCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(CDPFICJJMIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public IEEOIBJJIKL OEIFPJFNDDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(IEEOIBJJIKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public JAHPOGHNAIC BPEALGAHODJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(JAHPOGHNAIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public DKIPEDONHJJ CBBDKBJNJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(DKIPEDONHJJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public PPOBJDOPLOL BIMMAIDNJPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(PPOBJDOPLOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public DIFKHEIHLBE FMGJBLFDPLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(DIFKHEIHLBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public MBKDIJPCGBB JPPLGIEPENC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(MBKDIJPCGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public HAJOOFGAHGO PFPENFLIMOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HAJOOFGAHGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public GKHKCAMLIBD LOOBHOKEOBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(GKHKCAMLIBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public JLCCPMBGDPA CAKLNHKBBKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(JLCCPMBGDPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool BKJJHFLKEBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x64E4A90", Offset = "0x64E3C90", VA = "0x1864E4A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool CABMFBCCHKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x64E45E0", Offset = "0x64E37E0", VA = "0x1864E45E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool BBIFIKBDPKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x64E43D0", Offset = "0x64E35D0", VA = "0x1864E43D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	private bool BDEAOCIIFIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
	public HHOEFFJIFCP(NKJBKLODBOM LMABLLHEJEF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x64DB8B0", Offset = "0x64DAAB0", VA = "0x1864DB8B0")]
	public static bool LOFAPGLBJHK(HHOEFFJIFCP HLCKBKFCMPI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250")]
	public static NKJBKLODBOM LOFAPGLBJHK(HHOEFFJIFCP HLCKBKFCMPI)
	{
		return default(NKJBKLODBOM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x64E4A80", Offset = "0x64E3C80", VA = "0x1864E4A80")]
	public static bool LOAKJDDAMKI(HHOEFFJIFCP BPOHBPAMNLC, HHOEFFJIFCP NOIIDJMAOFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x64DB770", Offset = "0x64DA970", VA = "0x1864DB770")]
	public static bool IICOCCMJGPI(HHOEFFJIFCP BPOHBPAMNLC, HHOEFFJIFCP NOIIDJMAOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x64DB610", Offset = "0x64DA810", VA = "0x1864DB610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x64E4620", Offset = "0x64E3820", VA = "0x1864E4620", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x64DB510", Offset = "0x64DA710", VA = "0x1864DB510", Slot = "4")]
	public bool Equals(HHOEFFJIFCP JPLJHFMPDFD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250")]
	public static HHOEFFJIFCP LOFAPGLBJHK(NKJBKLODBOM IAODGFOMGBJ)
	{
		return default(HHOEFFJIFCP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x64E4410", Offset = "0x64E3610", VA = "0x1864E4410")]
	public MFADIOANFGK BNAKJGILMDL()
	{
		return default(MFADIOANFGK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x64E4810", Offset = "0x64E3A10", VA = "0x1864E4810")]
	public ADFJPEGPMLG GLDOPLCEFMF()
	{
		return default(ADFJPEGPMLG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x64E46B0", Offset = "0x64E38B0", VA = "0x1864E46B0")]
	public IGFHMCGPHMP FEDFILADCLM()
	{
		return default(IGFHMCGPHMP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x64E4840", Offset = "0x64E3A40", VA = "0x1864E4840")]
	public void GODEALJNCAH([Optional] object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x64E44D0", Offset = "0x64E36D0", VA = "0x1864E44D0")]
	public bool CLGOJABPPCC(object CEFPPEHCFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x64E4720", Offset = "0x64E3920", VA = "0x1864E4720")]
	public bool FLNKIONEKNB(object CEFPPEHCFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x64E4DD0", Offset = "0x64E3FD0", VA = "0x1864E4DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct DIFKHEIHLBE : IEquatable<DIFKHEIHLBE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly NKJBKLODBOM IAODGFOMGBJ;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public NKJBKLODBOM NIMFNJAPLNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(NKJBKLODBOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public HHOEFFJIFCP FNJNMMOAFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private EPHMCHMFEHM DGOELBMGKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x64DCB10", Offset = "0x64DBD10", VA = "0x1864DCB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private EPHCHEDHFPC MKJOLGNKEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x64DD5A0", Offset = "0x64DC7A0", VA = "0x1864DD5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	private OINOKJPDJJO LFGIBJLIGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x64DDB50", Offset = "0x64DCD50", VA = "0x1864DDB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool APMJODPLEKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x64DDCD0", Offset = "0x64DCED0", VA = "0x1864DDCD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Guid LDDIAOCHMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x64DD7F0", Offset = "0x64DC9F0", VA = "0x1864DD7F0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool NDFCMAAOIEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x64DD760", Offset = "0x64DC960", VA = "0x1864DD760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public Guid FOBPNIEHPMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x64DDBB0", Offset = "0x64DCDB0", VA = "0x1864DDBB0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
	public DIFKHEIHLBE(NKJBKLODBOM LMABLLHEJEF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x64DB8B0", Offset = "0x64DAAB0", VA = "0x1864DB8B0")]
	public static bool LOFAPGLBJHK(DIFKHEIHLBE HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x64DB610", Offset = "0x64DA810", VA = "0x1864DB610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x64DD6D0", Offset = "0x64DC8D0", VA = "0x1864DD6D0", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x64DB510", Offset = "0x64DA710", VA = "0x1864DB510", Slot = "4")]
	public bool Equals(DIFKHEIHLBE JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x64DBB00", Offset = "0x64DAD00", VA = "0x1864DBB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x64DD630", Offset = "0x64DC830", VA = "0x1864DD630")]
	public bool EACLAFAMABH([Out] Guid DOLMKPMNMEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x64DDA30", Offset = "0x64DCC30", VA = "0x1864DDA30")]
	public void JCMKBBIGLEC(Guid LGIDDHPGAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x64DDD60", Offset = "0x64DCF60", VA = "0x1864DDD60")]
	public bool PKJBCLKGJFI([Out] Guid PNCKNAFMFGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x64DD910", Offset = "0x64DCB10", VA = "0x1864DD910")]
	public void ICMHHHCCNHG(Guid LGIDDHPGAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x64DD510", Offset = "0x64DC710", VA = "0x1864DD510")]
	public void BJFDFNOJACG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct IGFHMCGPHMP : IEquatable<IGFHMCGPHMP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly NKJBKLODBOM IAODGFOMGBJ;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public NKJBKLODBOM NIMFNJAPLNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(NKJBKLODBOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public HHOEFFJIFCP FNJNMMOAFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private EPHMCHMFEHM DGOELBMGKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x64DCB10", Offset = "0x64DBD10", VA = "0x1864DCB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private EPHCHEDHFPC MKJOLGNKEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x64E57A0", Offset = "0x64E49A0", VA = "0x1864E57A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private IOIHFMFNNMN LHPLIBOJAKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x64E5A10", Offset = "0x64E4C10", VA = "0x1864E5A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public Vector3 FEGOLBPHAIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x64E58C0", Offset = "0x64E4AC0", VA = "0x1864E58C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Quaternion BGFJOCPAPIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x64E5A70", Offset = "0x64E4C70", VA = "0x1864E5A70")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public HHOEFFJIFCP MENLOPOAFDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x64E5BB0", Offset = "0x64E4DB0", VA = "0x1864E5BB0")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
	public IGFHMCGPHMP(NKJBKLODBOM LMABLLHEJEF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250")]
	public static NKJBKLODBOM LOFAPGLBJHK(IGFHMCGPHMP HLCKBKFCMPI)
	{
		return default(NKJBKLODBOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x64DB610", Offset = "0x64DA810", VA = "0x1864DB610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x64E5830", Offset = "0x64E4A30", VA = "0x1864E5830", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x64DB510", Offset = "0x64DA710", VA = "0x1864DB510", Slot = "4")]
	public bool Equals(IGFHMCGPHMP JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x64DBB00", Offset = "0x64DAD00", VA = "0x1864DBB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct MFADIOANFGK : IEquatable<MFADIOANFGK>
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly MFADIOANFGK JIBJIEJDBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly NKJBKLODBOM IAODGFOMGBJ;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public NKJBKLODBOM NIMFNJAPLNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(NKJBKLODBOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public HHOEFFJIFCP FNJNMMOAFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public HGFAIFHKIIG CGDFLGLNEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HGFAIFHKIIG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public GCJOKAPNNEP LFAOMMHPIGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(GCJOKAPNNEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private EPHMCHMFEHM DGOELBMGKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x64DCB10", Offset = "0x64DBD10", VA = "0x1864DCB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private EPHCHEDHFPC MKJOLGNKEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x64E8EF0", Offset = "0x64E80F0", VA = "0x1864E8EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private PCDCMHBMMHN HADBPHACLFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x64E9320", Offset = "0x64E8520", VA = "0x1864E9320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public FLGPIOIONCG JFPCHEPBLLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x64E9850", Offset = "0x64E8A50", VA = "0x1864E9850")]
		get
		{
			return default(FLGPIOIONCG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public IEnumerable<HHOEFFJIFCP> NKCCOGCCNBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x64E8F80", Offset = "0x64E8180", VA = "0x1864E8F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public IEnumerable<HHOEFFJIFCP> PNMMLECDOJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x64EA540", Offset = "0x64E9740", VA = "0x1864EA540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int GGLIOEIHAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x64E9D80", Offset = "0x64E8F80", VA = "0x1864E9D80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public int KJDPJMBCDNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x64E8820", Offset = "0x64E7A20", VA = "0x1864E8820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public string KLNBLIAPPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x64E9BB0", Offset = "0x64E8DB0", VA = "0x1864E9BB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x64E9CD0", Offset = "0x64E8ED0", VA = "0x1864E9CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public COMPIDEPGKL EKEHCFLDPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x64E9E10", Offset = "0x64E9010", VA = "0x1864E9E10")]
		get
		{
			return default(COMPIDEPGKL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x64EA400", Offset = "0x64E9600", VA = "0x1864EA400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public CKCINOKLGJJ PACLKILDJFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x64E9380", Offset = "0x64E8580", VA = "0x1864E9380")]
		get
		{
			return default(CKCINOKLGJJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x64EA870", Offset = "0x64E9A70", VA = "0x1864EA870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public NOHKFEMOOIC CCPPACPOLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x64E9FE0", Offset = "0x64E91E0", VA = "0x1864E9FE0")]
		get
		{
			return default(NOHKFEMOOIC);
		}
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x64EA7A0", Offset = "0x64E99A0", VA = "0x1864EA7A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public float IHDDBGJFBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x64E9A60", Offset = "0x64E8C60", VA = "0x1864E9A60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x64E99F0", Offset = "0x64E8BF0", VA = "0x1864E99F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool GBKAJLNDMDE
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x64EA6D0", Offset = "0x64E98D0", VA = "0x1864EA6D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x64E93E0", Offset = "0x64E85E0", VA = "0x1864E93E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool NMJGAMMJELG
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x64E9E70", Offset = "0x64E9070", VA = "0x1864E9E70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x64EA730", Offset = "0x64E9930", VA = "0x1864EA730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool FLACPGLCAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x64EA670", Offset = "0x64E9870", VA = "0x1864EA670")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x64E9C60", Offset = "0x64E8E60", VA = "0x1864E9C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool KLAOFEKCHPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x64EA470", Offset = "0x64E9670", VA = "0x1864EA470")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x64E88E0", Offset = "0x64E7AE0", VA = "0x1864E88E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool GKMAMICLIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x64EA810", Offset = "0x64E9A10", VA = "0x1864EA810")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x64E87B0", Offset = "0x64E79B0", VA = "0x1864E87B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool EIJFGKAIFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x64EA3A0", Offset = "0x64E95A0", VA = "0x1864EA3A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x64E8870", Offset = "0x64E7A70", VA = "0x1864E8870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool NHOMHINJBPK
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x64E9B50", Offset = "0x64E8D50", VA = "0x1864E9B50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x64EA4D0", Offset = "0x64E96D0", VA = "0x1864EA4D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public BPANFDAIIDA BGKBBMJCLBK
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x64EA340", Offset = "0x64E9540", VA = "0x1864EA340")]
		get
		{
			return default(BPANFDAIIDA);
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x64E9AE0", Offset = "0x64E8CE0", VA = "0x1864E9AE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public IEnumerable<int> IKIGHKLNAON
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x64E9F40", Offset = "0x64E9140", VA = "0x1864E9F40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x64EA0E0", Offset = "0x64E92E0", VA = "0x1864EA0E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public int CNDNCENBECM
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x64EA040", Offset = "0x64E9240", VA = "0x1864EA040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
	public MFADIOANFGK(NKJBKLODBOM LMABLLHEJEF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x64DB8B0", Offset = "0x64DAAB0", VA = "0x1864DB8B0")]
	public static bool LOFAPGLBJHK(MFADIOANFGK HLCKBKFCMPI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x64E4A80", Offset = "0x64E3C80", VA = "0x1864E4A80")]
	public static bool LOAKJDDAMKI(MFADIOANFGK BPOHBPAMNLC, MFADIOANFGK NOIIDJMAOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x64DB610", Offset = "0x64DA810", VA = "0x1864DB610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x64E9450", Offset = "0x64E8650", VA = "0x1864E9450", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x64DB510", Offset = "0x64DA710", VA = "0x1864DB510", Slot = "4")]
	public bool Equals(MFADIOANFGK JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x64DBB00", Offset = "0x64DAD00", VA = "0x1864DBB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250")]
	public static HHOEFFJIFCP LOFAPGLBJHK(MFADIOANFGK CJKIBFNGPNM)
	{
		return default(HHOEFFJIFCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x64E9AC0", Offset = "0x64E8CC0", VA = "0x1864E9AC0")]
	public bool JLJLOEPNGBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x64E9ED0", Offset = "0x64E90D0", VA = "0x1864E9ED0")]
	public bool MMGPKPLCMCG(ACJBFNFLLFC GHPONFJEPLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x64E9970", Offset = "0x64E8B70", VA = "0x1864E9970")]
	public void FJEAIIHDLBN(ACJBFNFLLFC GHPONFJEPLA, bool HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x64E90F0", Offset = "0x64E82F0", VA = "0x1864E90F0")]
	public FLGPIOIONCG CPOPHGBHMML(Allocator LGNDPBNMKMP)
	{
		return default(FLGPIOIONCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x64E94E0", Offset = "0x64E86E0", VA = "0x1864E94E0")]
	public void FELBBGCABOM(MFADIOANFGK JPLJHFMPDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x64E8950", Offset = "0x64E7B50", VA = "0x1864E8950")]
	public void CJGOKOIMKNM(List<HHOEFFJIFCP> NGKEJLECIDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct GLJEMKOLGJI : IEquatable<GLJEMKOLGJI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly NKJBKLODBOM IAODGFOMGBJ;

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public HHOEFFJIFCP FNJNMMOAFKA
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x64DB610", Offset = "0x64DA810", VA = "0x1864DB610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x64E0740", Offset = "0x64DF940", VA = "0x1864E0740", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x64DB510", Offset = "0x64DA710", VA = "0x1864DB510", Slot = "4")]
	public bool Equals(GLJEMKOLGJI JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x64DBB00", Offset = "0x64DAD00", VA = "0x1864DBB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct CDPFICJJMIH : IEquatable<CDPFICJJMIH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly NKJBKLODBOM IAODGFOMGBJ;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public HHOEFFJIFCP FNJNMMOAFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	private EPHMCHMFEHM DGOELBMGKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x64DCB10", Offset = "0x64DBD10", VA = "0x1864DCB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
	public CDPFICJJMIH(NKJBKLODBOM LMABLLHEJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x64DB610", Offset = "0x64DA810", VA = "0x1864DB610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x64DC8A0", Offset = "0x64DBAA0", VA = "0x1864DC8A0", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x64DB510", Offset = "0x64DA710", VA = "0x1864DB510", Slot = "4")]
	public bool Equals(CDPFICJJMIH JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x64DBB00", Offset = "0x64DAD00", VA = "0x1864DBB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x64DC9D0", Offset = "0x64DBBD0", VA = "0x1864DC9D0")]
	public void HJOADCBEFJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x64DCA70", Offset = "0x64DBC70", VA = "0x1864DCA70")]
	public void MKCDOJOACFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x64DC930", Offset = "0x64DBB30", VA = "0x1864DC930")]
	public bool FIJHEABHFON()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct GCJOKAPNNEP : IEquatable<GCJOKAPNNEP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly NKJBKLODBOM IAODGFOMGBJ;

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public NKJBKLODBOM NIMFNJAPLNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(NKJBKLODBOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public HHOEFFJIFCP FNJNMMOAFKA
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private EPHMCHMFEHM DGOELBMGKDO
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x64DCB10", Offset = "0x64DBD10", VA = "0x1864DCB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	private EPHCHEDHFPC MKJOLGNKEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x64DFAB0", Offset = "0x64DECB0", VA = "0x1864DFAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private PCDCMHBMMHN HADBPHACLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x64DFB40", Offset = "0x64DED40", VA = "0x1864DFB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public NKJBKLODBOM FLHGPOKHDJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x64DFD50", Offset = "0x64DEF50", VA = "0x1864DFD50")]
		get
		{
			return default(NKJBKLODBOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public HHOEFFJIFCP DPGEGBIPNMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x64DF980", Offset = "0x64DEB80", VA = "0x1864DF980")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public HHOEFFJIFCP LHCGPINMKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x64DFC30", Offset = "0x64DEE30", VA = "0x1864DFC30")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
	public GCJOKAPNNEP(NKJBKLODBOM LMABLLHEJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x64DB610", Offset = "0x64DA810", VA = "0x1864DB610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x64DFBA0", Offset = "0x64DEDA0", VA = "0x1864DFBA0", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x64DB510", Offset = "0x64DA710", VA = "0x1864DB510", Slot = "4")]
	public bool Equals(GCJOKAPNNEP JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x64DBB00", Offset = "0x64DAD00", VA = "0x1864DBB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x64E0180", Offset = "0x64DF380", VA = "0x1864E0180")]
	public bool NDMMKDCEAMC(HHOEFFJIFCP BGILIGANMHA, bool KNMNLMOMPGE = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x64DFA10", Offset = "0x64DEC10", VA = "0x1864DFA10")]
	public bool BKKPOCMIOIA(HHOEFFJIFCP JIHELKOFMCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x64DFDE0", Offset = "0x64DEFE0", VA = "0x1864DFDE0")]
	private void LIKGDLHEHDA(HHOEFFJIFCP LHPDKFKPDEA, List<HHOEFFJIFCP> OELOODJBKMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x64DFCC0", Offset = "0x64DEEC0", VA = "0x1864DFCC0")]
	public MFADIOANFGK KDFAEONHBOM()
	{
		return default(MFADIOANFGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x64E02B0", Offset = "0x64DF4B0", VA = "0x1864E02B0")]
	public void OJAGEDIDPID(List<HHOEFFJIFCP> EOHOAJBFMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x64E0060", Offset = "0x64DF260", VA = "0x1864E0060")]
	public NativeArray<NKJBKLODBOM> NAPOPLHGJOI()
	{
		return default(NativeArray<NKJBKLODBOM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct PLDIEBOKBPG : IEquatable<PLDIEBOKBPG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly NKJBKLODBOM IAODGFOMGBJ;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public HHOEFFJIFCP FNJNMMOAFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public string BEDLHJMHALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x64ED4B0", Offset = "0x64EC6B0", VA = "0x1864ED4B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public string BOMMNEEAHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x64ECED0", Offset = "0x64EC0D0", VA = "0x1864ECED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool KFGBKAIDKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x64ED090", Offset = "0x64EC290", VA = "0x1864ED090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public string HALPIOBLNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x64ED530", Offset = "0x64EC730", VA = "0x1864ED530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public string LGKFECJHDLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x64ED260", Offset = "0x64EC460", VA = "0x1864ED260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public string OINDBLGBOJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x64ECFA0", Offset = "0x64EC1A0", VA = "0x1864ECFA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
	public PLDIEBOKBPG(NKJBKLODBOM LMABLLHEJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x64DB610", Offset = "0x64DA810", VA = "0x1864DB610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x64ED1D0", Offset = "0x64EC3D0", VA = "0x1864ED1D0", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x64DB510", Offset = "0x64DA710", VA = "0x1864DB510", Slot = "4")]
	public bool Equals(PLDIEBOKBPG JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x64DBB00", Offset = "0x64DAD00", VA = "0x1864DBB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct LJDCENBJHIJ : IEquatable<LJDCENBJHIJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly NKJBKLODBOM IAODGFOMGBJ;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public HHOEFFJIFCP FNJNMMOAFKA
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x64DB610", Offset = "0x64DA810", VA = "0x1864DB610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x64E75E0", Offset = "0x64E67E0", VA = "0x1864E75E0", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x64DB510", Offset = "0x64DA710", VA = "0x1864DB510", Slot = "4")]
	public bool Equals(LJDCENBJHIJ JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x64DBB00", Offset = "0x64DAD00", VA = "0x1864DBB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct IEEOIBJJIKL : IEquatable<IEEOIBJJIKL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly NKJBKLODBOM IAODGFOMGBJ;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public HHOEFFJIFCP FNJNMMOAFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
	public IEEOIBJJIKL(NKJBKLODBOM LMABLLHEJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x64DB610", Offset = "0x64DA810", VA = "0x1864DB610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x64E4F50", Offset = "0x64E4150", VA = "0x1864E4F50", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x64DB510", Offset = "0x64DA710", VA = "0x1864DB510", Slot = "4")]
	public bool Equals(IEEOIBJJIKL JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x64DBB00", Offset = "0x64DAD00", VA = "0x1864DBB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x64E4FE0", Offset = "0x64E41E0", VA = "0x1864E4FE0")]
	public bool IBGKPGDGFMJ([Out] Collider MJPKEDNHCHC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct GKHKCAMLIBD : IEquatable<GKHKCAMLIBD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly NKJBKLODBOM IAODGFOMGBJ;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public NKJBKLODBOM NIMFNJAPLNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(NKJBKLODBOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public HHOEFFJIFCP FNJNMMOAFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private DDOGGLEPLPC EECPMIBJLFN
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x64E0610", Offset = "0x64DF810", VA = "0x1864E0610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
	public GKHKCAMLIBD(NKJBKLODBOM LMABLLHEJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x64DB610", Offset = "0x64DA810", VA = "0x1864DB610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x64E0580", Offset = "0x64DF780", VA = "0x1864E0580", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x64DB510", Offset = "0x64DA710", VA = "0x1864DB510", Slot = "4")]
	public bool Equals(GKHKCAMLIBD JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x64DBB00", Offset = "0x64DAD00", VA = "0x1864DBB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x64E06D0", Offset = "0x64DF8D0", VA = "0x1864E06D0")]
	public void LIGDHCAGDFD(bool FBONKBLIAIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct JAHPOGHNAIC : IEquatable<JAHPOGHNAIC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly NKJBKLODBOM IAODGFOMGBJ;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public NKJBKLODBOM NIMFNJAPLNP
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(NKJBKLODBOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public HHOEFFJIFCP FNJNMMOAFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private EPHMCHMFEHM DGOELBMGKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x64DCB10", Offset = "0x64DBD10", VA = "0x1864DCB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private EPHCHEDHFPC MKJOLGNKEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x64E5E00", Offset = "0x64E5000", VA = "0x1864E5E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private ObjectPolicyDataWrapper MCPAKJIDKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x64E64E0", Offset = "0x64E56E0", VA = "0x1864E64E0")]
		get
		{
			return default(ObjectPolicyDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private NavMeshGenerationDataWrapper HKGDIGJFIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x64E68F0", Offset = "0x64E5AF0", VA = "0x1864E68F0")]
		get
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public bool LNBEGNCJAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x64E6430", Offset = "0x64E5630", VA = "0x1864E6430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool ICMCJOBFFOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x64E66D0", Offset = "0x64E58D0", VA = "0x1864E66D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public bool ACGLKPGPCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x64E6A30", Offset = "0x64E5C30", VA = "0x1864E6A30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public bool MANAJALOIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x64E6470", Offset = "0x64E5670", VA = "0x1864E6470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool JKNAHMHKOLP
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x64E6D50", Offset = "0x64E5F50", VA = "0x1864E6D50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public bool EDFEHOMLDNO
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x64E6740", Offset = "0x64E5940", VA = "0x1864E6740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public bool ALBGDCPNBHL
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x64E69C0", Offset = "0x64E5BC0", VA = "0x1864E69C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public bool ODHGIJEEFNA
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x64E6110", Offset = "0x64E5310", VA = "0x1864E6110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool AIFBPIHHCDD
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x64E6180", Offset = "0x64E5380", VA = "0x1864E6180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public bool NKAGFAGMBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x64E6950", Offset = "0x64E5B50", VA = "0x1864E6950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public bool MNJMIMHNKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x64E6250", Offset = "0x64E5450", VA = "0x1864E6250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public bool LLHFECBAHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x64E5D90", Offset = "0x64E4F90", VA = "0x1864E5D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool HKHEDEOOIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x64E67B0", Offset = "0x64E59B0", VA = "0x1864E67B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool JHGFEHCJIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x64E6540", Offset = "0x64E5740", VA = "0x1864E6540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public bool OMGIPHIGFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x64E5F00", Offset = "0x64E5100", VA = "0x1864E5F00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x64E5E90", Offset = "0x64E5090", VA = "0x1864E5E90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public MLBJKKJIKNB MALFNDPHKAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x64E6AA0", Offset = "0x64E5CA0", VA = "0x1864E6AA0")]
		get
		{
			return default(MLBJKKJIKNB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x64E6660", Offset = "0x64E5860", VA = "0x1864E6660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public bool EGCCBFKEFNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x64E6B00", Offset = "0x64E5D00", VA = "0x1864E6B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public MJCCNDEFHPO DNEDFCOLBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x64E61F0", Offset = "0x64E53F0", VA = "0x1864E61F0")]
		get
		{
			return default(MJCCNDEFHPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public bool MAJMAMLANMO
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x64E6DC0", Offset = "0x64E5FC0", VA = "0x1864E6DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 GNAOBCJKOBF
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x64E65A0", Offset = "0x64E57A0", VA = "0x1864E65A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 MHHLPMOBNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x64E5FD0", Offset = "0x64E51D0", VA = "0x1864E5FD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool MEPNNCJANFD
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x64E6330", Offset = "0x64E5530", VA = "0x1864E6330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
	public JAHPOGHNAIC(NKJBKLODBOM LMABLLHEJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x64DB610", Offset = "0x64DA810", VA = "0x1864DB610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x64E6080", Offset = "0x64E5280", VA = "0x1864E6080", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x64DB510", Offset = "0x64DA710", VA = "0x1864DB510", Slot = "4")]
	public bool Equals(JAHPOGHNAIC JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x64DBB00", Offset = "0x64DAD00", VA = "0x1864DBB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x64E62C0", Offset = "0x64E54C0", VA = "0x1864E62C0")]
	public bool GOFFBMKLKJH(EIPKNFIBHOC GHPONFJEPLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x64E5F60", Offset = "0x64E5160", VA = "0x1864E5F60")]
	public bool DLNOAPILAGH(BPFEAHFPDEI GHPONFJEPLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x64E6CD0", Offset = "0x64E5ED0", VA = "0x1864E6CD0")]
	public void OJIBGJCOEKK(BPFEAHFPDEI GHPONFJEPLA, bool AIDBJIBCPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x64E6820", Offset = "0x64E5A20", VA = "0x1864E6820")]
	public BPFEAHFPDEI LOJGJENFMGC()
	{
		return default(BPFEAHFPDEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x64E6880", Offset = "0x64E5A80", VA = "0x1864E6880")]
	public bool MBPKONPGMKL(BPFEAHFPDEI HLCKBKFCMPI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct PPOBJDOPLOL : IEquatable<PPOBJDOPLOL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly NKJBKLODBOM IAODGFOMGBJ;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public NKJBKLODBOM NIMFNJAPLNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(NKJBKLODBOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public HHOEFFJIFCP FNJNMMOAFKA
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	private EPHMCHMFEHM DGOELBMGKDO
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x64DCB10", Offset = "0x64DBD10", VA = "0x1864DCB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	private EPHCHEDHFPC MKJOLGNKEPP
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x64ED7F0", Offset = "0x64EC9F0", VA = "0x1864ED7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
	public PPOBJDOPLOL(NKJBKLODBOM LMABLLHEJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x64DB610", Offset = "0x64DA810", VA = "0x1864DB610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x64ED910", Offset = "0x64ECB10", VA = "0x1864ED910", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x64DB510", Offset = "0x64DA710", VA = "0x1864DB510", Slot = "4")]
	public bool Equals(PPOBJDOPLOL JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x64DBB00", Offset = "0x64DAD00", VA = "0x1864DBB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x64ED880", Offset = "0x64ECA80", VA = "0x1864ED880")]
	public void DDIDLGJGIAJ(bool HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x64ED9A0", Offset = "0x64ECBA0", VA = "0x1864ED9A0")]
	public void JFPMECPDGJO(bool HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x2B1E200", Offset = "0x2B1D400", VA = "0x182B1E200")]
	public T OMCKLHDMEIB<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct JLCCPMBGDPA : IEquatable<JLCCPMBGDPA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly NKJBKLODBOM IAODGFOMGBJ;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public NKJBKLODBOM NIMFNJAPLNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(NKJBKLODBOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public HHOEFFJIFCP FNJNMMOAFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private EPHMCHMFEHM DGOELBMGKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x64DCB10", Offset = "0x64DBD10", VA = "0x1864DCB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private EPHCHEDHFPC MKJOLGNKEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x64E6EB0", Offset = "0x64E60B0", VA = "0x1864E6EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	private DDODHCOINEI JDDAFNMEGFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x64E6FD0", Offset = "0x64E61D0", VA = "0x1864E6FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool MKGIOCOLNCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x64E6E20", Offset = "0x64E6020", VA = "0x1864E6E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool NBOIAFKACHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x64E7030", Offset = "0x64E6230", VA = "0x1864E7030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
	public JLCCPMBGDPA(NKJBKLODBOM LMABLLHEJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x64DB610", Offset = "0x64DA810", VA = "0x1864DB610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x64E6F40", Offset = "0x64E6140", VA = "0x1864E6F40", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x64DB510", Offset = "0x64DA710", VA = "0x1864DB510", Slot = "4")]
	public bool Equals(JLCCPMBGDPA JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x64DBB00", Offset = "0x64DAD00", VA = "0x1864DBB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct DKIPEDONHJJ : IEquatable<DKIPEDONHJJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly NKJBKLODBOM IAODGFOMGBJ;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public NKJBKLODBOM NIMFNJAPLNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(NKJBKLODBOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public HHOEFFJIFCP FNJNMMOAFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	private EPHMCHMFEHM DGOELBMGKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x64DCB10", Offset = "0x64DBD10", VA = "0x1864DCB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	private EPHCHEDHFPC MKJOLGNKEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x64DDFA0", Offset = "0x64DD1A0", VA = "0x1864DDFA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private FEMEOHGPJIO JHFJCKDDGDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x64DE030", Offset = "0x64DD230", VA = "0x1864DE030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	private JOHINECKDDP NIDPANKMMIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x64DE360", Offset = "0x64DD560", VA = "0x1864DE360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public bool JBAIHEAPLHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x64DE960", Offset = "0x64DDB60", VA = "0x1864DE960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public bool IHHBEJNELKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x64DE890", Offset = "0x64DDA90", VA = "0x1864DE890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public bool MFMJCAEFHNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x64DE930", Offset = "0x64DDB30", VA = "0x1864DE930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public bool MJGAGJOLHDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x64DE9F0", Offset = "0x64DDBF0", VA = "0x1864DE9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public bool NBPFGHBEAAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x64DE090", Offset = "0x64DD290", VA = "0x1864DE090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool JAPOBNAALNN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x64DDE70", Offset = "0x64DD070", VA = "0x1864DDE70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool DEFIBBFHEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x64DE150", Offset = "0x64DD350", VA = "0x1864DE150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public bool BPBMCGDHHLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x64DE3C0", Offset = "0x64DD5C0", VA = "0x1864DE3C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
	public DKIPEDONHJJ(NKJBKLODBOM LMABLLHEJEF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x64DB8B0", Offset = "0x64DAAB0", VA = "0x1864DB8B0")]
	public static bool LOFAPGLBJHK(DKIPEDONHJJ HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x64DB610", Offset = "0x64DA810", VA = "0x1864DB610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x64DE0C0", Offset = "0x64DD2C0", VA = "0x1864DE0C0", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x64DB510", Offset = "0x64DA710", VA = "0x1864DB510", Slot = "4")]
	public bool Equals(DKIPEDONHJJ JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x64DBB00", Offset = "0x64DAD00", VA = "0x1864DBB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x64DDE00", Offset = "0x64DD000", VA = "0x1864DDE00")]
	public bool ABHJAEKDMHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x64DE640", Offset = "0x64DD840", VA = "0x1864DE640")]
	public HHOEFFJIFCP INDLPEJFCDN(HHOEFFJIFCP FMEDEJNEJHJ)
	{
		return default(HHOEFFJIFCP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x64DE530", Offset = "0x64DD730", VA = "0x1864DE530")]
	public NKJBKLODBOM IDNIGJOCPHB()
	{
		return default(NKJBKLODBOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x64DDF00", Offset = "0x64DD100", VA = "0x1864DDF00")]
	public bool CHELELGBDFB(NKJBKLODBOM JPFIPGFOBLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x64DE6E0", Offset = "0x64DD8E0", VA = "0x1864DE6E0")]
	public bool KOFDLMGGAAB(NKJBKLODBOM AINDMFCOMAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x64DE780", Offset = "0x64DD980", VA = "0x1864DE780")]
	public bool NEJJEDCEMIJ(NKJBKLODBOM FMEDEJNEJHJ, [Out] NKJBKLODBOM JPFIPGFOBLL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct ADFJPEGPMLG : IEquatable<ADFJPEGPMLG>
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly ADFJPEGPMLG JIBJIEJDBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly NKJBKLODBOM IAODGFOMGBJ;

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public NKJBKLODBOM NIMFNJAPLNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(NKJBKLODBOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public HHOEFFJIFCP FNJNMMOAFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public HGFAIFHKIIG CGDFLGLNEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HGFAIFHKIIG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public GCJOKAPNNEP LFAOMMHPIGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(GCJOKAPNNEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private ShapeTypeDataWrapper FCKJNBAKBAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x64DB710", Offset = "0x64DA910", VA = "0x1864DB710")]
		get
		{
			return default(ShapeTypeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public StandardRenderableVisualDataWrapper PCMOJKECCOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x64DB210", Offset = "0x64DA410", VA = "0x1864DB210")]
		get
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public PhysicsMaterialDataWrapper COMCPFHFIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x64DB3B0", Offset = "0x64DA5B0", VA = "0x1864DB3B0")]
		get
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public ShapeConfigDataWrapper IFIJFEICJGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x64DB5B0", Offset = "0x64DA7B0", VA = "0x1864DB5B0")]
		get
		{
			return default(ShapeConfigDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public OPOOJGGNJKH MKANJIHOJLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x64DB6A0", Offset = "0x64DA8A0", VA = "0x1864DB6A0")]
		get
		{
			return default(OPOOJGGNJKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public DNGGAHCCLGO HJNOELOMHDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x64DB4B0", Offset = "0x64DA6B0", VA = "0x1864DB4B0")]
		get
		{
			return default(DNGGAHCCLGO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x64DBA90", Offset = "0x64DAC90", VA = "0x1864DBA90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public FDGOEMEGONN COFJHALALNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x64DB640", Offset = "0x64DA840", VA = "0x1864DB640")]
		get
		{
			return default(FDGOEMEGONN);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x64DBA20", Offset = "0x64DAC20", VA = "0x1864DBA20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public float PBOOJKEHHGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x64DB2D0", Offset = "0x64DA4D0", VA = "0x1864DB2D0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x64DB940", Offset = "0x64DAB40", VA = "0x1864DB940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public Vector3 PILJJGMEGIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x64DB410", Offset = "0x64DA610", VA = "0x1864DB410")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x64DB790", Offset = "0x64DA990", VA = "0x1864DB790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public float PGGDENCLKGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x64DB9B0", Offset = "0x64DABB0", VA = "0x1864DB9B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public EBPGHJKKMKE PBCJDAIFJPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x64DB270", Offset = "0x64DA470", VA = "0x1864DB270")]
		get
		{
			return default(EBPGHJKKMKE);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x64DB8D0", Offset = "0x64DAAD0", VA = "0x1864DB8D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
	public ADFJPEGPMLG(NKJBKLODBOM LMABLLHEJEF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x64DB8B0", Offset = "0x64DAAB0", VA = "0x1864DB8B0")]
	public static bool LOFAPGLBJHK(ADFJPEGPMLG HLCKBKFCMPI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x64DB770", Offset = "0x64DA970", VA = "0x1864DB770")]
	public static bool IICOCCMJGPI(ADFJPEGPMLG BPOHBPAMNLC, ADFJPEGPMLG NOIIDJMAOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x64DB610", Offset = "0x64DA810", VA = "0x1864DB610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x64DB520", Offset = "0x64DA720", VA = "0x1864DB520", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x64DB510", Offset = "0x64DA710", VA = "0x1864DB510", Slot = "4")]
	public bool Equals(ADFJPEGPMLG JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x64DBB00", Offset = "0x64DAD00", VA = "0x1864DBB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x64DB830", Offset = "0x64DAA30", VA = "0x1864DB830")]
	public LKKCEOPFDDM LKKLJKAHEHA()
	{
		return default(LKKCEOPFDDM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x64DB330", Offset = "0x64DA530", VA = "0x1864DB330")]
	public MAANFADKFIC DGOKIFNMDNM()
	{
		return default(MAANFADKFIC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct LKKCEOPFDDM : IEquatable<LKKCEOPFDDM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly NKJBKLODBOM IAODGFOMGBJ;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public NKJBKLODBOM NIMFNJAPLNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(NKJBKLODBOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public HHOEFFJIFCP FNJNMMOAFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public ADFJPEGPMLG KBKAOMFCNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(ADFJPEGPMLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	private PrimitiveShapeDataWrapper GGIOBHNJIPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x64E76D0", Offset = "0x64E68D0", VA = "0x1864E76D0")]
		get
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public MEENIEMELIG PHGHIAPGNJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x64E7670", Offset = "0x64E6870", VA = "0x1864E7670")]
		get
		{
			return default(MEENIEMELIG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
	public LKKCEOPFDDM(NKJBKLODBOM LMABLLHEJEF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x64DB8B0", Offset = "0x64DAAB0", VA = "0x1864DB8B0")]
	public static bool LOFAPGLBJHK(LKKCEOPFDDM HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x64DB610", Offset = "0x64DA810", VA = "0x1864DB610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x64E7730", Offset = "0x64E6930", VA = "0x1864E7730", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x64DB510", Offset = "0x64DA710", VA = "0x1864DB510", Slot = "4")]
	public bool Equals(LKKCEOPFDDM JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x64DBB00", Offset = "0x64DAD00", VA = "0x1864DBB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[DefaultMember("Item")]
public readonly struct MAANFADKFIC : IEquatable<MAANFADKFIC>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly MAANFADKFIC JIBJIEJDBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly NKJBKLODBOM IAODGFOMGBJ;

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public NKJBKLODBOM NIMFNJAPLNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(NKJBKLODBOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public HHOEFFJIFCP FNJNMMOAFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public HGFAIFHKIIG CGDFLGLNEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HGFAIFHKIIG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	private EPHMCHMFEHM DGOELBMGKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x64DCB10", Offset = "0x64DBD10", VA = "0x1864DCB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private EPHCHEDHFPC MKJOLGNKEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x64E7A20", Offset = "0x64E6C20", VA = "0x1864E7A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private KFOOIFGGANC CIJDICNLPJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x64E79C0", Offset = "0x64E6BC0", VA = "0x1864E79C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public ADFJPEGPMLG KBKAOMFCNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(ADFJPEGPMLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public GAGNBDNECAG OIKDEDHIIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x64E83B0", Offset = "0x64E75B0", VA = "0x1864E83B0")]
		get
		{
			return default(GAGNBDNECAG);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x64E7E40", Offset = "0x64E7040", VA = "0x1864E7E40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public IEnumerable<IELFEBOOCLD> DHIBOGLNFOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x64E7BC0", Offset = "0x64E6DC0", VA = "0x1864E7BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public IELFEBOOCLD FOFBNHMHKAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x64E7AB0", Offset = "0x64E6CB0", VA = "0x1864E7AB0")]
		get
		{
			return default(IELFEBOOCLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public int HJGLMCCDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x64E84D0", Offset = "0x64E76D0", VA = "0x1864E84D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
	public MAANFADKFIC(NKJBKLODBOM LMABLLHEJEF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x64DB8B0", Offset = "0x64DAAB0", VA = "0x1864DB8B0")]
	public static bool LOFAPGLBJHK(MAANFADKFIC HLCKBKFCMPI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x64E4A80", Offset = "0x64E3C80", VA = "0x1864E4A80")]
	public static bool LOAKJDDAMKI(MAANFADKFIC BPOHBPAMNLC, MAANFADKFIC NOIIDJMAOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x64DB610", Offset = "0x64DA810", VA = "0x1864DB610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x64E7DB0", Offset = "0x64E6FB0", VA = "0x1864E7DB0", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x64DB510", Offset = "0x64DA710", VA = "0x1864DB510", Slot = "4")]
	public bool Equals(MAANFADKFIC JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x64DBB00", Offset = "0x64DAD00", VA = "0x1864DBB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x64E7F60", Offset = "0x64E7160", VA = "0x1864E7F60")]
	public IELFEBOOCLD FMKPBENDBJE(float3? CAOOPLKANIG, [Optional] quaternion? JCCMNAMJFGM, [Optional] Vector3? MGKBJKPBCFA)
	{
		return default(IELFEBOOCLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x64E8180", Offset = "0x64E7380", VA = "0x1864E8180")]
	public IELFEBOOCLD HLFHLDCGEJO(int PMNHOLIPOMJ, float3? CAOOPLKANIG, [Optional] quaternion? JCCMNAMJFGM, [Optional] Vector3? MGKBJKPBCFA)
	{
		return default(IELFEBOOCLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x64E7920", Offset = "0x64E6B20", VA = "0x1864E7920")]
	public void BFKMEMCNNLL(int PMNHOLIPOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x64E7890", Offset = "0x64E6A90", VA = "0x1864E7890")]
	public void BFDHFEEMFPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct IELFEBOOCLD : IEquatable<IELFEBOOCLD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly NKJBKLODBOM IAODGFOMGBJ;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public NKJBKLODBOM NIMFNJAPLNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(NKJBKLODBOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public HHOEFFJIFCP FNJNMMOAFKA
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public MAANFADKFIC PPMHAEJDJOH
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x64E51B0", Offset = "0x64E43B0", VA = "0x1864E51B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public float3 IKDGFFADEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x64E52A0", Offset = "0x64E44A0", VA = "0x1864E52A0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x64E5480", Offset = "0x64E4680", VA = "0x1864E5480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public quaternion MBPJHPHFEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x64E5720", Offset = "0x64E4920", VA = "0x1864E5720")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x64E5320", Offset = "0x64E4520", VA = "0x1864E5320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float3 HAOBHHIMAOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x64E5500", Offset = "0x64E4700", VA = "0x1864E5500")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x64E5580", Offset = "0x64E4780", VA = "0x1864E5580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public KFBDLGJJCOB MNGDPOCJDDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x64E5140", Offset = "0x64E4340", VA = "0x1864E5140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private SplinePointParentDataWrapper OFJBELHIOOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x64E5600", Offset = "0x64E4800", VA = "0x1864E5600")]
		get
		{
			return default(SplinePointParentDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private SplinePointPositionDataWrapper EGJMFAEDCIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x64E5240", Offset = "0x64E4440", VA = "0x1864E5240")]
		get
		{
			return default(SplinePointPositionDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private SplinePointRotationDataWrapper LCPBIAMIHNA
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x64E5660", Offset = "0x64E4860", VA = "0x1864E5660")]
		get
		{
			return default(SplinePointRotationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private SplinePointScaleDataWrapper ECJDPOABEEP
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x64E56C0", Offset = "0x64E48C0", VA = "0x1864E56C0")]
		get
		{
			return default(SplinePointScaleDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private SplinePointOrderDataWrapper HMFCNDFCMOF
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x64E5420", Offset = "0x64E4620", VA = "0x1864E5420")]
		get
		{
			return default(SplinePointOrderDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
	public IELFEBOOCLD(NKJBKLODBOM LMABLLHEJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x64DB610", Offset = "0x64DA810", VA = "0x1864DB610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x64E5390", Offset = "0x64E4590", VA = "0x1864E5390", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x64DB510", Offset = "0x64DA710", VA = "0x1864DB510", Slot = "4")]
	public bool Equals(IELFEBOOCLD JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x64DBB00", Offset = "0x64DAD00", VA = "0x1864DBB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x64E51B0", Offset = "0x64E43B0", VA = "0x1864E51B0")]
	public void BLLKHOPBDKL(MAANFADKFIC HLCKBKFCMPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct HAJOOFGAHGO : IEquatable<HAJOOFGAHGO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly NKJBKLODBOM IAODGFOMGBJ;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public NKJBKLODBOM NIMFNJAPLNP
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(NKJBKLODBOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public HHOEFFJIFCP FNJNMMOAFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private EPHMCHMFEHM DGOELBMGKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x64DCB10", Offset = "0x64DBD10", VA = "0x1864DCB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private EPHCHEDHFPC MKJOLGNKEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x64E0940", Offset = "0x64DFB40", VA = "0x1864E0940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	private FDOBNPHKCKF GALIOFGFNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x64E0DF0", Offset = "0x64DFFF0", VA = "0x1864E0DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	private ToolCleanupSettingsDataWrapper BENDKCIOIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x64E0FF0", Offset = "0x64E01F0", VA = "0x1864E0FF0")]
		get
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool OJBKDPCDHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x64E07D0", Offset = "0x64DF9D0", VA = "0x1864E07D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x64E0B70", Offset = "0x64DFD70", VA = "0x1864E0B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public bool KMAMGDKFDOH
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x64E0EF0", Offset = "0x64E00F0", VA = "0x1864E0EF0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x64E0CE0", Offset = "0x64DFEE0", VA = "0x1864E0CE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public float MKIGLJGIFCL
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x64E09D0", Offset = "0x64DFBD0", VA = "0x1864E09D0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x64E0C70", Offset = "0x64DFE70", VA = "0x1864E0C70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public bool GKMGEGDMJDB
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x64E0D50", Offset = "0x64DFF50", VA = "0x1864E0D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
	public HAJOOFGAHGO(NKJBKLODBOM LMABLLHEJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x64DB610", Offset = "0x64DA810", VA = "0x1864DB610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x64E0BE0", Offset = "0x64DFDE0", VA = "0x1864E0BE0", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x64DB510", Offset = "0x64DA710", VA = "0x1864DB510", Slot = "4")]
	public bool Equals(HAJOOFGAHGO JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x64DBB00", Offset = "0x64DAD00", VA = "0x1864DBB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x64E0E50", Offset = "0x64E0050", VA = "0x1864E0E50")]
	public void KHHMIFHOKIE(int OFDCFOKBLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x64E0830", Offset = "0x64DFA30", VA = "0x1864E0830")]
	public bool BNFGDKEFOPG([Out] int OFDCFOKBLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x64E0F50", Offset = "0x64E0150", VA = "0x1864E0F50")]
	public void MLMMGEIACKI(bool AGNHECNPPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x64E0A30", Offset = "0x64DFC30", VA = "0x1864E0A30")]
	public void EDAAPLBJPGM(float DIHJHCHGAHB, float IEIEOIINEGH, float GKHLPFJDIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x64E1050", Offset = "0x64E0250", VA = "0x1864E1050")]
	public void OCDMJKJDLOJ(float3 PMNNHKKFBBD, quaternion NBJOCAAKLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x64E11A0", Offset = "0x64E03A0", VA = "0x1864E11A0")]
	public bool OGJNPHKDIEJ([Out] float3 PMNNHKKFBBD, [Out] quaternion NBJOCAAKLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x64E12D0", Offset = "0x64E04D0", VA = "0x1864E12D0")]
	public bool OPGCKJNAJNK([Out] float GEOCABDFKOM, [Out] float BPAMJHNNIKN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct HGFAIFHKIIG : IEquatable<HGFAIFHKIIG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly NKJBKLODBOM IAODGFOMGBJ;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public HHOEFFJIFCP FNJNMMOAFKA
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public GCJOKAPNNEP LFAOMMHPIGB
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(GCJOKAPNNEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private EPHMCHMFEHM DGOELBMGKDO
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x64DCB10", Offset = "0x64DBD10", VA = "0x1864DCB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private POENGOLNAPO HJBGKEGFDIK
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x64E2140", Offset = "0x64E1340", VA = "0x1864E2140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool ANDOFPHHGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x64E2880", Offset = "0x64E1A80", VA = "0x1864E2880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public Vector3 IKDGFFADEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x64E1E00", Offset = "0x64E1000", VA = "0x1864E1E00")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x64E2AE0", Offset = "0x64E1CE0", VA = "0x1864E2AE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public Quaternion MBPJHPHFEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x64E38C0", Offset = "0x64E2AC0", VA = "0x1864E38C0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x64E24F0", Offset = "0x64E16F0", VA = "0x1864E24F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public Vector3 MHPPJPHAOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x64E2D00", Offset = "0x64E1F00", VA = "0x1864E2D00")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x64E2FD0", Offset = "0x64E21D0", VA = "0x1864E2FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public Quaternion HGAAFJGFGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x64E3730", Offset = "0x64E2930", VA = "0x1864E3730")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x64E28C0", Offset = "0x64E1AC0", VA = "0x1864E28C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public float HGONEJLKJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x64E1F50", Offset = "0x64E1150", VA = "0x1864E1F50")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x64E33D0", Offset = "0x64E25D0", VA = "0x1864E33D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public float AECLGOKMGJL
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x64E3690", Offset = "0x64E2890", VA = "0x1864E3690")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public Vector3 HAOBHHIMAOM
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x64E2BB0", Offset = "0x64E1DB0", VA = "0x1864E2BB0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x64E2E50", Offset = "0x64E2050", VA = "0x1864E2E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public Vector3 DCBDGAPJMBC
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x64E23A0", Offset = "0x64E15A0", VA = "0x1864E23A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public Matrix4x4 FHHJBEDDMME
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x64E1B20", Offset = "0x64E0D20", VA = "0x1864E1B20")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
	public HGFAIFHKIIG(NKJBKLODBOM LMABLLHEJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x64DB610", Offset = "0x64DA810", VA = "0x1864DB610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x64E2670", Offset = "0x64E1870", VA = "0x1864E2670", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x64DB510", Offset = "0x64DA710", VA = "0x1864DB510", Slot = "4")]
	public bool Equals(HGFAIFHKIIG JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x64DBB00", Offset = "0x64DAD00", VA = "0x1864DBB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x64E3870", Offset = "0x64E2A70", VA = "0x1864E3870")]
	public KLLANJMFCIJ NINBEJHKOKO()
	{
		return default(KLLANJMFCIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x64E3ED0", Offset = "0x64E30D0", VA = "0x1864E3ED0")]
	public void PJAOCPHOACL([Out] Matrix4x4 NBFEINKEDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x64E3DA0", Offset = "0x64E2FA0", VA = "0x1864E3DA0")]
	public void PEKKLGGKJKM([Out] Vector3 FOMAEPCINBA, [Out] Quaternion OOCNPJGEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x64E25C0", Offset = "0x64E17C0", VA = "0x1864E25C0")]
	public void EMEIICJEDFP([Out] RigidTransform LACLLHFNJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x64E3BE0", Offset = "0x64E2DE0", VA = "0x1864E3BE0")]
	public UniformTRS OLLFHHPCNKF()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x64E3C10", Offset = "0x64E2E10", VA = "0x1864E3C10")]
	public void OLLFHHPCNKF([Out] UniformTRS FNFMJEFHKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x64E3170", Offset = "0x64E2370", VA = "0x1864E3170")]
	public UniformTRS JOKLFNFMLKG()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x64E31A0", Offset = "0x64E23A0", VA = "0x1864E31A0")]
	public void JOKLFNFMLKG([Out] UniformTRS LACLLHFNJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x64E1FF0", Offset = "0x64E11F0", VA = "0x1864E1FF0")]
	public Vector3 CHMPOPBKEMH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x64E22D0", Offset = "0x64E14D0", VA = "0x1864E22D0")]
	public void DNJGPLACIEG([In] Vector3 HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x64E2990", Offset = "0x64E1B90", VA = "0x1864E2990")]
	public Vector3 GKANMDPJGEC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x64E4130", Offset = "0x64E3330", VA = "0x1864E4130")]
	public void PPEKINNIBHA([In] Vector3 HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x64E3A00", Offset = "0x64E2C00", VA = "0x1864E3A00")]
	public Quaternion NNLKCOHDFMK()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x64E2700", Offset = "0x64E1900", VA = "0x1864E2700")]
	public void FIMJAEPKENM([In] Quaternion HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x64E3550", Offset = "0x64E2750", VA = "0x1864E3550")]
	public Quaternion NAHLKFDKFIC()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x64E3CD0", Offset = "0x64E2ED0", VA = "0x1864E3CD0")]
	public void ONEAMNGKMIM([In] Quaternion HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x64E3B40", Offset = "0x64E2D40", VA = "0x1864E3B40")]
	public float OCDNHLCCBPP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x64E27D0", Offset = "0x64E19D0", VA = "0x1864E27D0")]
	public void FLBKOBCKMEE(float HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x64E3330", Offset = "0x64E2530", VA = "0x1864E3330")]
	public float LPGBEJEENGO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x64E2F20", Offset = "0x64E2120", VA = "0x1864E2F20")]
	public void INFOBGGLPMP(float HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x64E30A0", Offset = "0x64E22A0", VA = "0x1864E30A0")]
	public void JGAPOOEIJLK([In] Vector3 HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x64E1B60", Offset = "0x64E0D60", VA = "0x1864E1B60")]
	public Vector3 CCAOLFAJEGG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x64E3480", Offset = "0x64E2680", VA = "0x1864E3480")]
	public void MLMDCAOIIFM([In] Vector3 HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x64E1CB0", Offset = "0x64E0EB0", VA = "0x1864E1CB0")]
	public Vector3 CECPHNMHNDP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x64E2200", Offset = "0x64E1400", VA = "0x1864E2200")]
	public void CLMIEMILING([In] Vector3 HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x64E3FE0", Offset = "0x64E31E0", VA = "0x1864E3FE0")]
	public Vector3 PLDJGOPMLEO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x64E3260", Offset = "0x64E2460", VA = "0x1864E3260")]
	public void KKBHDENJHLF([In] Vector3 HLCKBKFCMPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct MBKDIJPCGBB : IEquatable<MBKDIJPCGBB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly NKJBKLODBOM IAODGFOMGBJ;

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public NKJBKLODBOM NIMFNJAPLNP
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(NKJBKLODBOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public HHOEFFJIFCP FNJNMMOAFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		get
		{
			return default(HHOEFFJIFCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public int[] AJPCGFPLGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x64E8560", Offset = "0x64E7760", VA = "0x1864E8560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public bool OCAJFNEGEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x64E86E0", Offset = "0x64E78E0", VA = "0x1864E86E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x64E8740", Offset = "0x64E7940", VA = "0x1864E8740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
	public MBKDIJPCGBB(NKJBKLODBOM LMABLLHEJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x64DB610", Offset = "0x64DA810", VA = "0x1864DB610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x64E8650", Offset = "0x64E7850", VA = "0x1864E8650", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x64DB510", Offset = "0x64DA710", VA = "0x1864DB510", Slot = "4")]
	public bool Equals(MBKDIJPCGBB JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x64DBB00", Offset = "0x64DAD00", VA = "0x1864DBB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class DIEPGBECEJI
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private struct HGDBBNLHJNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Guid LDJEJDDHHLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public HMLIGMAGCLC FIHMLPFDIIG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private struct HMLIGMAGCLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int HLCKBKFCMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int NANPNDOPEOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int LBEICOGLEFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int GKKJLGJIBOB;

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x64E4EB0", Offset = "0x64E40B0", VA = "0x1864E4EB0")]
		public bool FEMDNGPAPHB([Out] AOHONJCJOFF OLFMODBDOAG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x64E4F30", Offset = "0x64E4130", VA = "0x1864E4F30")]
		public HMLIGMAGCLC(AOHONJCJOFF OLFMODBDOAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x64DD460", Offset = "0x64DC660", VA = "0x1864DD460")]
	public static Guid AEHEALGDBMG(this AOHONJCJOFF OLFMODBDOAG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x64DD4F0", Offset = "0x64DC6F0", VA = "0x1864DD4F0")]
	public static bool PFMAKHNNEJL(this Guid LDJEJDDHHLO, [Out] AOHONJCJOFF OLFMODBDOAG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal static class OAAGCDNNKGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x64EC5B0", Offset = "0x64EB7B0", VA = "0x1864EC5B0")]
	public static EPHCHEDHFPC MKJOLGNKEPP(this NKJBKLODBOM IFAFPBGLEJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x64EC4E0", Offset = "0x64EB6E0", VA = "0x1864EC4E0")]
	public static APCMOMBHJDC MEIGPDMBGHN(this NKJBKLODBOM IFAFPBGLEJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x64EC3E0", Offset = "0x64EB5E0", VA = "0x1864EC3E0")]
	public static EntityManager CINBCAKEAKN(this NKJBKLODBOM IFAFPBGLEJO)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9E10", Offset = "0x2AE9010", VA = "0x182AE9E10")]
	public static T CEDODOAEPOI<T>(this NKJBKLODBOM IFAFPBGLEJO) where T : struct, GKOELECAOJK
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2AEAF20", Offset = "0x2AEA120", VA = "0x182AEAF20")]
	public static bool ENEMPLGFKDM<T>(this NKJBKLODBOM IFAFPBGLEJO) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB290", Offset = "0x2AEA490", VA = "0x182AEB290")]
	public static bool INNCIEENEJN<T>(this NKJBKLODBOM IFAFPBGLEJO) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface OINOKJPDJJO
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NDFCMAAOIEI(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool APMJODPLEKK(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EACLAFAMABH(NKJBKLODBOM LMABLLHEJEF, [Out] Guid DOLMKPMNMEL);

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid OKHPFLNOLNK(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JCMKBBIGLEC(NKJBKLODBOM LMABLLHEJEF, Guid DOLMKPMNMEL);

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PKJBCLKGJFI(NKJBKLODBOM LMABLLHEJEF, [Out] Guid PNCKNAFMFGK);

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid OHFEPNJNDHF(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ICMHHHCCNHG(NKJBKLODBOM LMABLLHEJEF, Guid PNCKNAFMFGK);

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BJFDFNOJACG(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task KHNOEKOJIPJ(NKJBKLODBOM POGNIHKEPMJ, NKJBKLODBOM BGILIGANMHA);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[FNBGDBIFOLG(OLEKGNKHMMB.LoadInstance)]
public interface MLKJPFOIJFN
{
	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	Guid ENNOCKDDAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FIGLCIIKJKM(NativeList<Guid> KIBJAIIFELC, NativeList<Guid> JGJAFCFNKDL, NativeList<FixedString64Bytes> PLCAIBOAMOA);
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface DDODHCOINEI
{
	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NOIPNDEEOHC(List<NKJBKLODBOM> PNKFGGGLFFK);

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJFMOAOIPHM(List<NKJBKLODBOM> KNFKBNDAICO);

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KKCDECONDBE(NKJBKLODBOM AFPGOBDHGKJ);

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MKGIOCOLNCD(NKJBKLODBOM AFPGOBDHGKJ);

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NBOIAFKACHL(NKJBKLODBOM AFPGOBDHGKJ);

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int FKFMOOEMGOK(NKJBKLODBOM AFPGOBDHGKJ);

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HEDFKIKACGD(NKJBKLODBOM AFPGOBDHGKJ, int MDCNPPDPLHN);

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NKJBKLODBOM GIDLMPMKIMK(NKJBKLODBOM CKPFAONIECP);

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GLPHLCKLLIG(NKJBKLODBOM CKPFAONIECP, NKJBKLODBOM FELJKEHOAJB);

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IFMBJHKFFDP(NKJBKLODBOM CKPFAONIECP);

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int FNMHNKDLCFC(NKJBKLODBOM CKPFAONIECP);

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DEPEOCKKCAI(NKJBKLODBOM CKPFAONIECP, int EMKONJJIKNI);

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(Slot = "12")]
	int AONAHIMAJJE(NKJBKLODBOM CKPFAONIECP);

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PCAODFEKFKO(NKJBKLODBOM CKPFAONIECP, int HJJFFKBBFGP);

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BKLEMNMJJGD(NKJBKLODBOM IAODGFOMGBJ);

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LCLNIHLGAFA(NKJBKLODBOM LMABLLHEJEF, bool ELHNLBMDHPO);

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FBLDGEIPDJH(NKJBKLODBOM[] DOLLNNCPINB, bool ELHNLBMDHPO);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface GOCNJIDFDDI
{
	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	IReadOnlyCollection<ACIEECMHDBP> LEMPDMCCHNA
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GEMHBKBJCGC(int ANKFEMDGJKO, [Out] ACIEECMHDBP OPKCMDNJEAG);

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ACIEECMHDBP POKHMLDGBJP(Type HHJOOHJDNNM);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public static class KHMPCAIINDN
{
	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x2A21240", Offset = "0x2A20440", VA = "0x182A21240")]
	public static T LNCGGCPBLKA<T>(this GOCNJIDFDDI JEKAANGODJK, Entity FOJNONDDGDN) where T : struct, GKOELECAOJK
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x2A212E0", Offset = "0x2A204E0", VA = "0x182A212E0")]
	public static ACIEECMHDBP POKHMLDGBJP<T>(this GOCNJIDFDDI JEKAANGODJK) where T : struct, GKOELECAOJK
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface FGDHFHEEHOB
{
	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AOHONJCJOFF[] KKAAPOLKKNI(string IIADHBOODBK, HHOEFFJIFCP FLMNHCACECL, bool NJBAKLFIHPC = false);

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CKIHIPEMMJI(string HDOGLMBKHEN, AOHONJCJOFF[] BHCHGCPMHAI);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[FNBGDBIFOLG(OLEKGNKHMMB.LoadInstance)]
public interface IOIHFMFNNMN
{
	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<NKJBKLODBOM, NKJBKLODBOM> ICAKLAFGAMO;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<NKJBKLODBOM, NKJBKLODBOM> HBIHHMNFHLG;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<NKJBKLODBOM, NKJBKLODBOM, NKJBKLODBOM> JNNPANAMANE;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<NKJBKLODBOM> KEMIALGKEAH;

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DBBNMICJILD(NKJBKLODBOM LMABLLHEJEF, NKJBKLODBOM ANBKOFHGBPI);

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NKJBKLODBOM AHBFDILMBMD(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<NKJBKLODBOM> GLNAJKLHJIH(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NKJBKLODBOM KMACHEBPFAE(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KLLLOFLDDAI(NKJBKLODBOM LMABLLHEJEF, Vector3 HEPLIBJGFEO, Quaternion BDGNHLPHCGP);

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DAJLHCNAEKH(NKJBKLODBOM LMABLLHEJEF, float JHBDJMECJAM);

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool DFFCAGCGNBB(NKJBKLODBOM LMABLLHEJEF, [Out] RigidTransform FLNGAJHBAEN);

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool AIGBGEEDECB(NKJBKLODBOM LMABLLHEJEF, [Out] float MMAHGFDEMDC);

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 LDPOLLBBNGK(IGFHMCGPHMP IAAKNFMEEFL);

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion ELFEJCJIMFJ(IGFHMCGPHMP IAAKNFMEEFL);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class MJJNECMPAOG
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[FNBGDBIFOLG(OLEKGNKHMMB.LoadInstance)]
public interface JJGCIJGKIHO
{
	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	object KKBKMGLAKND
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEFJOGBMLNF(FLGPIOIONCG DOLLNNCPINB);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public enum OCPNENIEKGM
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class NKIIKGGGPDA
{
	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0xCBC820", Offset = "0xCBBA20", VA = "0x180CBC820")]
	public static bool LLNICEPGKFG(this OCPNENIEKGM JLPFJEBDMDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0xCBC800", Offset = "0xCBBA00", VA = "0x180CBC800")]
	public static bool LNMIEBIDAML(this OCPNENIEKGM JLPFJEBDMDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x24029C0", Offset = "0x2401BC0", VA = "0x1824029C0")]
	public static bool DDKGEJLNHLB(this OCPNENIEKGM JLPFJEBDMDB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface EPIKFCIMLBH
{
	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	OCPNENIEKGM NNACMBPPOLG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	OCPNENIEKGM BICCBCNLADE
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	OCPNENIEKGM CIALDCDEGDF
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	OCPNENIEKGM NJPJPNDOPCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	OCPNENIEKGM DHKENPKNKGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	OCPNENIEKGM GIGACJIFBAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	OCPNENIEKGM OEIFPJFNDDE
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	OCPNENIEKGM LDIEGGIPOBD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	OCPNENIEKGM HEMGBKGFAJK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	OCPNENIEKGM LOBFHBLLJMK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	OCPNENIEKGM EKLOPEIOENG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	OCPNENIEKGM BPGAHEFAIFB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	OCPNENIEKGM OPNCLNLJBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface PCDCMHBMMHN
{
	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<PGLDIBNMGHH> JBAFDAACOIM;

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NKJBKLODBOM FNMLLBADPHM(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ABBPHPKCMGL(List<NKJBKLODBOM> KNFKBNDAICO);

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KFBDLGJJCOB DLIDKGALGNJ(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KFBDLGJJCOB AMNPKKIOKII(NKJBKLODBOM BGILIGANMHA, NKJBKLODBOM NAKAAHDEHKM, bool MIDDDHLGBHI, NKJBKLODBOM FMEDEJNEJHJ);

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NKJBKLODBOM OKIAIBIAEDD(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool NDMMKDCEAMC(NKJBKLODBOM LMABLLHEJEF, NKJBKLODBOM BGILIGANMHA, bool KNMNLMOMPGE);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NMHCFIGGAKE(NKJBKLODBOM LMABLLHEJEF, NKJBKLODBOM BGILIGANMHA);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool EADKNBIGIML(NKJBKLODBOM BMGLMCJKKPN, NKJBKLODBOM JAIGBLDJHMA);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int CIEDPKOJKAD(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FLGPIOIONCG OLCHHLOJLCN(NKJBKLODBOM IAODGFOMGBJ);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NativeArray<NKJBKLODBOM> NAPOPLHGJOI(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool LHMNHFAIGOF(NKJBKLODBOM LMABLLHEJEF, NKJBKLODBOM FLMMLCBCBDI);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<NKJBKLODBOM> DNEHCGPPEOF(NKJBKLODBOM LMABLLHEJEF, bool CKOEPNKAPCI = false);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool BKKPOCMIOIA(NKJBKLODBOM LMABLLHEJEF, NKJBKLODBOM JIHELKOFMCM);

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "16")]
	NKJBKLODBOM LJBAJEDCOKK(NKJBKLODBOM FMEDEJNEJHJ, NKJBKLODBOM ONPHPDBIJDL);

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool LDEANKBJNDL(NKJBKLODBOM FMEDEJNEJHJ, NKJBKLODBOM ONPHPDBIJDL, [Out] NKJBKLODBOM KKICODCEEFP);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class KEAKPKNKCBE
{
	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x64E7150", Offset = "0x64E6350", VA = "0x1864E7150")]
	public static List<NKJBKLODBOM> ABBPHPKCMGL(this PCDCMHBMMHN JCLPMKKELGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x64E7250", Offset = "0x64E6450", VA = "0x1864E7250")]
	public static bool FMPMOALNLGO(this PCDCMHBMMHN JCLPMKKELGB, NKJBKLODBOM LMABLLHEJEF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[FNBGDBIFOLG(OLEKGNKHMMB.LoadInstance)]
public interface PEHFIPAPDKD
{
	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	bool JGIBLDAHHDG
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	bool IDPCJJLDFDN
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface JJJGCLOKMCL : KBOONMNKKIE
{
	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FCDMDCCOPLM(Entity FOJNONDDGDN, [Out] BPMKMDALMJP DHPHAFDDMEE);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OALNAGCJECJ(NativeArray<BPMKMDALMJP> PCCLDFEANNE, NativeArray<DAHEELCIBLC> ENEPKJDGCNO);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JGCKJMDMBCO(BPMKMDALMJP DHPHAFDDMEE);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NMAGILINMPA(BPMKMDALMJP DHPHAFDDMEE, [Out] Collider MJPKEDNHCHC);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[FNBGDBIFOLG(OLEKGNKHMMB.LoadInstance)]
public interface KBOONMNKKIE
{
	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JLCKCHAHBJJ([In] float3 LEDLONHHKMC, [In] float3 GDLGHHBOJHM, float DLJLDGNAIFD, Allocator LGNDPBNMKMP, [Out] NativeArray<Entity> BGEKIKEJMHP);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[FNBGDBIFOLG(OLEKGNKHMMB.LoadInstance)]
public interface EDINHEBNCMI
{
	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JLCKCHAHBJJ([In] float3 LEDLONHHKMC, [In] float3 GDLGHHBOJHM, float DLJLDGNAIFD, [Out] FBPPNONBBEK FKIPEBAIEBN, [Out] NKJBKLODBOM BCALGAKKMJK);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[FNBGDBIFOLG(OLEKGNKHMMB.LoadInstance)]
public interface PCLDDONNNPJ
{
	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLCKCHAHBJJ([In] NativeArray<Entity> BGEKIKEJMHP, [In] float3 LEDLONHHKMC, [In] float3 GDLGHHBOJHM, [In] NativeArray<FBPPNONBBEK> DHKNCCBEHJD);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct BPMKMDALMJP : OPLAPEEBMGF, IEquatable<BPMKMDALMJP>
{
	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public int DMDPAHAMEGP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x877370", Offset = "0x876570", VA = "0x180877370", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x9CBB80", Offset = "0x9CAD80", VA = "0x1809CBB80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public int BAGLMBHIAAA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x24131E0", Offset = "0x24123E0", VA = "0x1824131E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x5819400", Offset = "0x5818600", VA = "0x185819400", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x64DC800", Offset = "0x64DBA00", VA = "0x1864DC800", Slot = "8")]
	public bool Equals(BPMKMDALMJP JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x64DC850", Offset = "0x64DBA50", VA = "0x1864DC850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct FBPPNONBBEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float PPMMHHHAAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public float3 BGIIKDPIDDB;
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface KNKDMFEPHJD
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface EPHMCHMFEHM
{
	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	EPHCHEDHFPC MKJOLGNKEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	NJGGKCKMDDO JAAMONNBCDL
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<FLGPIOIONCG, NativeArray<LFJMPPMLIHF>> AJJAONGNMCJ;

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event Action<FLGPIOIONCG> EAAELOEMINL;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CDEBHKLHJMI MBPHEMCAOHO(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LFJMPPMLIHF PMKFKKFIIJB(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FLGJIGKCNJL(AOHONJCJOFF OLFMODBDOAG, MBENLKIEPOK JGNFNCCPLCB);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FOABNFIICOL(AOHONJCJOFF[] BHCHGCPMHAI, GameObject IIDBEBHLIGH);

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HHOEFFJIFCP GODEALJNCAH(NKJBKLODBOM LMABLLHEJEF, [Optional] object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool MGOLOPOOHEH(NKJBKLODBOM LMABLLHEJEF, [Out] MBENLKIEPOK JGNFNCCPLCB);

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool EGKCAOAMLKB(NKJBKLODBOM LMABLLHEJEF, [Out] Transform HANHCEFMJDD);

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool BKJJHFLKEBA(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CEDGPICOCGB(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool CLGOJABPPCC(LocalId LMABLLHEJEF, object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool FLNKIONEKNB(LocalId LMABLLHEJEF, object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	NKJBKLODBOM HOMAFMGINNG(AOHONJCJOFF OLFMODBDOAG);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool PAOMHNMGOPB(AOHONJCJOFF OLFMODBDOAG, [Out] NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "19")]
	AOHONJCJOFF AKBHHHODFAN(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "20")]
	FLGPIOIONCG HOMAFMGINNG(NativeArray<AOHONJCJOFF> OLFMODBDOAG, Allocator LGNDPBNMKMP);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "21")]
	FLGPIOIONCG NGBPKBJMBFC(LFJMPPMLIHF KCLAFPDDNOC, int BIFLOKBJAPK, Allocator LGNDPBNMKMP);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "22")]
	FLGPIOIONCG MLCBFPOILDE(NativeArray<AOHONJCJOFF> OLFMODBDOAG, NativeArray<PKGMOMJHDBO> JBPMOCOFABP, Allocator LGNDPBNMKMP);

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "23")]
	AOHONJCJOFF[] KKAAPOLKKNI(string HDOGLMBKHEN, HHOEFFJIFCP FLMNHCACECL, bool NJBAKLFIHPC);

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CKIHIPEMMJI(string HDOGLMBKHEN, AOHONJCJOFF[] BHCHGCPMHAI);

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "25")]
	HHOEFFJIFCP IPOICMPCNJF(LFJMPPMLIHF KCLAFPDDNOC, bool GOCPBMJMKJH);

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(Slot = "26")]
	HHOEFFJIFCP IPOICMPCNJF(LFJMPPMLIHF KCLAFPDDNOC);

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "27")]
	HHOEFFJIFCP HCJMFAAGHHF(LFJMPPMLIHF KCLAFPDDNOC);

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "28")]
	HHOEFFJIFCP JHEBFCAFEBE(LFJMPPMLIHF KCLAFPDDNOC);

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "29")]
	HHOEFFJIFCP MKOIDNBCMMD(AOHONJCJOFF OLFMODBDOAG, LFJMPPMLIHF KCLAFPDDNOC);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "30")]
	MFADIOANFGK BJOMEIHFDDP();

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(Slot = "31")]
	MAANFADKFIC LPAPODOCKBG();

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(Slot = "32")]
	LKKCEOPFDDM BPPGGGCGHIO(MEENIEMELIG KDNABNMDJNA);

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void MKCDOJOACFI(FLGPIOIONCG DOLLNNCPINB);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void HJOADCBEFJH(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void BLGMOELEJIH(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void MKCDOJOACFI(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool FIJHEABHFON(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(Slot = "38")]
	FLGPIOIONCG IOMLFIHINJC(FLGPIOIONCG LNGCEEHMIAF, Allocator LGNDPBNMKMP);

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool ABDMLBNKFOD(NKJBKLODBOM LMABLLHEJEF);
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public static class HFFIHOADHHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x64E16F0", Offset = "0x64E08F0", VA = "0x1864E16F0")]
	public static void CEDGPICOCGB(this EPHMCHMFEHM HODJLJDOIHB, MBENLKIEPOK JGNFNCCPLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x64E1770", Offset = "0x64E0970", VA = "0x1864E1770")]
	public static HHOEFFJIFCP MCMMOIAHKOB(this EPHMCHMFEHM HODJLJDOIHB, LocalId LMABLLHEJEF)
	{
		return default(HHOEFFJIFCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x64E1AC0", Offset = "0x64E0CC0", VA = "0x1864E1AC0")]
	public static HHOEFFJIFCP MCMMOIAHKOB(this EPHMCHMFEHM HODJLJDOIHB, AOHONJCJOFF OLFMODBDOAG)
	{
		return default(HHOEFFJIFCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x64E1770", Offset = "0x64E0970", VA = "0x1864E1770")]
	public static NKJBKLODBOM HOMAFMGINNG(this EPHMCHMFEHM HODJLJDOIHB, LocalId LMABLLHEJEF)
	{
		return default(NKJBKLODBOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x64E1470", Offset = "0x64E0670", VA = "0x1864E1470")]
	public static AOHONJCJOFF AKBHHHODFAN(this EPHMCHMFEHM HODJLJDOIHB, LocalId LMABLLHEJEF)
	{
		return default(AOHONJCJOFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x64E1400", Offset = "0x64E0600", VA = "0x1864E1400")]
	public static bool ABDMLBNKFOD(this EPHMCHMFEHM HODJLJDOIHB, AOHONJCJOFF OLFMODBDOAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x29B2CD0", Offset = "0x29B1ED0", VA = "0x1829B2CD0")]
	public static T ALHCIKMCCFB<T>(this EPHMCHMFEHM HODJLJDOIHB, LocalId LMABLLHEJEF) where T : struct, GKOELECAOJK
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x64E14F0", Offset = "0x64E06F0", VA = "0x1864E14F0")]
	public static MFADIOANFGK BJGPPIOLHCI(this EPHMCHMFEHM HODJLJDOIHB, RigidTransform FNFMJEFHKAG, [Optional] object CEFPPEHCFCF)
	{
		return default(MFADIOANFGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x64E17A0", Offset = "0x64E09A0", VA = "0x1864E17A0")]
	public static LKKCEOPFDDM JCJPAGOGMFG(this EPHMCHMFEHM HODJLJDOIHB, MEENIEMELIG HMHEMHPCAML, RigidTransform FNFMJEFHKAG, [Optional] object CEFPPEHCFCF)
	{
		return default(LKKCEOPFDDM);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x64E15F0", Offset = "0x64E07F0", VA = "0x1864E15F0")]
	public static MAANFADKFIC CDCBDGKGMIM(this EPHMCHMFEHM HODJLJDOIHB, RigidTransform FNFMJEFHKAG, [Optional] object CEFPPEHCFCF)
	{
		return default(MAANFADKFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x64E18A0", Offset = "0x64E0AA0", VA = "0x1864E18A0")]
	private static void LDHOEDKKHLK(HHOEFFJIFCP NJMGAKGEPED, RigidTransform FNFMJEFHKAG, [Optional] object CEFPPEHCFCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[FNBGDBIFOLG(OLEKGNKHMMB.LoadInstance)]
public interface FEMEOHGPJIO
{
	[Cpp2IlInjected.Token(Token = "0x17000180")]
	bool JBKNANGCCMC
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	NKJBKLODBOM MCFFKHNFPJG
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	HHOEFFJIFCP PHODMJHCPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event MGFFOJPPKEB JFGPAJHMJNI;

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NKJBKLODBOM LJBAJEDCOKK(NKJBKLODBOM FMEDEJNEJHJ, NKJBKLODBOM ONPHPDBIJDL);

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LDEANKBJNDL(NKJBKLODBOM FMEDEJNEJHJ, NKJBKLODBOM ONPHPDBIJDL, [Out] NKJBKLODBOM KKICODCEEFP);

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KLCCHEHJKPL();

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HFIHPOOMEEG();

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool JBAIHEAPLHA(NKJBKLODBOM FMEDEJNEJHJ);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool JAPOBNAALNN(NKJBKLODBOM FMEDEJNEJHJ);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public delegate void MGFFOJPPKEB(HHOEFFJIFCP NKIEEACGLAG, HHOEFFJIFCP MCJELAANNJJ);
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class NLEAOCHKKAK
{
	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x64EC310", Offset = "0x64EB510", VA = "0x1864EC310")]
	public static bool KEILBJFMMCB(this FEMEOHGPJIO MCNNBLBDNPB, HHOEFFJIFCP FMEDEJNEJHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x64EC230", Offset = "0x64EB430", VA = "0x1864EC230")]
	public static bool CPBEIFICLOD(this FEMEOHGPJIO MCNNBLBDNPB, NKJBKLODBOM FMEDEJNEJHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x64EC360", Offset = "0x64EB560", VA = "0x1864EC360")]
	public static bool MJGAGJOLHDG(this FEMEOHGPJIO MCNNBLBDNPB, NKJBKLODBOM FMEDEJNEJHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface AKCMNJLLKDP
{
	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BLFBAFNGICN(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LHOLLDNGDDJ(NKJBKLODBOM LMABLLHEJEF, Transform HANHCEFMJDD);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface JOHINECKDDP
{
	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CHELELGBDFB(NKJBKLODBOM FMEDEJNEJHJ, NKJBKLODBOM JPFIPGFOBLL);

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KOFDLMGGAAB(NKJBKLODBOM FMEDEJNEJHJ, NKJBKLODBOM AINDMFCOMAO);

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NEJJEDCEMIJ(NKJBKLODBOM FMEDEJNEJHJ, [Out] NKJBKLODBOM LEHGNBGICEN);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[FNBGDBIFOLG(OLEKGNKHMMB.LoadInstance)]
public interface ICFGFGDIJLB
{
	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDIDLGJGIAJ(NKJBKLODBOM IAODGFOMGBJ, bool HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFPMECPDGJO(NKJBKLODBOM IAODGFOMGBJ, bool HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IIADILHJHND(NKJBKLODBOM IAODGFOMGBJ, int HLCKBKFCMPI);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[FNBGDBIFOLG(OLEKGNKHMMB.LoadInstance)]
public interface KFOOIFGGANC
{
	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<NKJBKLODBOM> MNPGEHIOPGE(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NKJBKLODBOM EAOODGHFNMA(NKJBKLODBOM LMABLLHEJEF, int PMNHOLIPOMJ);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int OMONGJMFHJK(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GAGNBDNECAG JJMHFBPJJML(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GEGEAJEGNBG(NKJBKLODBOM LMABLLHEJEF, GAGNBDNECAG EOHMOLAFOBC);

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NKJBKLODBOM MCPAABJGPJM(NKJBKLODBOM LMABLLHEJEF, [Optional] float3? CAOOPLKANIG, [Optional] quaternion? JCCMNAMJFGM, [Optional] float3? MGKBJKPBCFA);

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NKJBKLODBOM GOFHNDBBBBD(NKJBKLODBOM LMABLLHEJEF, int PMNHOLIPOMJ, [Optional] float3? CAOOPLKANIG, [Optional] quaternion? JCCMNAMJFGM, [Optional] float3? MGKBJKPBCFA);

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CEIIDAEMLCM(NKJBKLODBOM LMABLLHEJEF, int PMNHOLIPOMJ);

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ODGCEEONNNA(NKJBKLODBOM LMABLLHEJEF);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface FFEANLEHALG
{
	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNBJGCBHLEP();

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BPEGBPHKOAN();

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GNBOKGCEIBC();

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FPFMBOENBNE();

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BGFAPLBPDPP();

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MMLMCKEIFIB();

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void INOIJAHIOIF();

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HNMMALLHIDA();

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JJGICHFHNIK();

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DNDIFANNKMJ();

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DCLEBIONOCP();

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MAGPAMONMCG();
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[FNBGDBIFOLG(OLEKGNKHMMB.LoadInstance)]
public interface FDOBNPHKCKF
{
	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNFGDKEFOPG(NKJBKLODBOM FMEDEJNEJHJ, [Out] int OFDCFOKBLAO);

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KHHMIFHOKIE(NKJBKLODBOM FMEDEJNEJHJ, int OFDCFOKBLAO);

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ICIKEPMINKI(NKJBKLODBOM FMEDEJNEJHJ, bool AIDBJIBCPEA);

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MLMMGEIACKI(NKJBKLODBOM FMEDEJNEJHJ, bool AGNHECNPPBB);

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EDAAPLBJPGM(NKJBKLODBOM FMEDEJNEJHJ, float DIHJHCHGAHB, float IEIEOIINEGH, float GKHLPFJDIOM);

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OPGCKJNAJNK(NKJBKLODBOM LMABLLHEJEF, [Out] float IEIEOIINEGH, [Out] float GKHLPFJDIOM);

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OCDMJKJDLOJ(NKJBKLODBOM FMEDEJNEJHJ, float3 CAOOPLKANIG, quaternion JCCMNAMJFGM);

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OGJNPHKDIEJ(NKJBKLODBOM FMEDEJNEJHJ, [Out] float3 CAOOPLKANIG, [Out] quaternion JCCMNAMJFGM);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface POENGOLNAPO
{
	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CHCDDKHKLFN(Entity FOJNONDDGDN);

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNJGPLACIEG(Entity FOJNONDDGDN, [In] float3 HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 CHMPOPBKEMH(Entity FOJNONDDGDN);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FIMJAEPKENM(Entity FOJNONDDGDN, [In] quaternion HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion NNLKCOHDFMK(Entity FOJNONDDGDN);

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PEKKLGGKJKM(Entity FOJNONDDGDN, [Out] float3 CAOOPLKANIG, [Out] quaternion JCCMNAMJFGM);

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PEKKLGGKJKM(Entity FOJNONDDGDN, [Out] RigidTransform OMMPGCGBPBN);

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EMEIICJEDFP(Entity FOJNONDDGDN, [Out] RigidTransform OMMPGCGBPBN);

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 FEMNEDHMCLN(Entity FOJNONDDGDN);

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JGAPOOEIJLK(Entity FOJNONDDGDN, [In] float3 HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FLBKOBCKMEE(Entity FOJNONDDGDN, float HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float OCDNHLCCBPP(Entity FOJNONDDGDN);

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CLMIEMILING(Entity FOJNONDDGDN, [In] float3 HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 CECPHNMHNDP(Entity FOJNONDDGDN);

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PPEKINNIBHA(Entity FOJNONDDGDN, [In] float3 HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 GKANMDPJGEC(Entity FOJNONDDGDN);

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ONEAMNGKMIM(Entity FOJNONDDGDN, [In] quaternion HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion NAHLKFDKFIC(Entity FOJNONDDGDN);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 CCAOLFAJEGG(Entity FOJNONDDGDN);

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void MLMDCAOIIFM(Entity FOJNONDDGDN, [In] float3 HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void INFOBGGLPMP(Entity FOJNONDDGDN, float HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float LPGBEJEENGO(Entity FOJNONDDGDN);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KKBHDENJHLF(Entity FOJNONDDGDN, [In] float3 HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 PLDJGOPMLEO(Entity FOJNONDDGDN);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GOACDIBPEOK(Entity FOJNONDDGDN, [Out] float4x4 NBFEINKEDJM);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void HNPDDGMJGNK(Entity FOJNONDDGDN, [In] float4x4 NBFEINKEDJM);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void IPANGLFHHNL(Entity FOJNONDDGDN, [Out] float4x4 NBFEINKEDJM);

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool EGKCAOAMLKB(Entity FOJNONDDGDN, [Out] Transform HANHCEFMJDD);

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void GODOHIGJHGL(Entity FOJNONDDGDN);

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void OIFHOIJEALG(Entity FOJNONDDGDN, Entity LNPIGCAIMML, Entity KFDAFHAJFEH);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class JCOLFAPIGGF
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface OIIICELEAFK
{
	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KEBHAAIHCPC(bool NPGCEAJJJDI);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface BHMHFMGLECP
{
	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World HKJNPCKJOKM(string BLIOKKPNFPK = "Main");

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World KNNCCCFIKJK(string BLIOKKPNFPK = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World CCPBHHDOKNA(string BLIOKKPNFPK = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World MEBLKJHGLPL(string BLIOKKPNFPK = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface APCMOMBHJDC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000183")]
	World MPJPGPPHLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	World GNLLEMLEJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	EntityManager CINBCAKEAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	bool ICKIPDGCPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase GHMCLIKJGLI(Type HHJOOHJDNNM);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class FCBDMOKFAJA
{
	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x64DEF10", Offset = "0x64DE110", VA = "0x1864DEF10")]
	public static ComponentSystemBase CBCIEDINIAO(this World JNALJCCENAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x294E2E0", Offset = "0x294D4E0", VA = "0x18294E2E0")]
	public static T GHMCLIKJGLI<T>(this APCMOMBHJDC ODHNKACFLON) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[FNBGDBIFOLG(OLEKGNKHMMB.LoadInstance)]
public interface GJDDOAJKAPM
{
	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HHPEKKLOLEH(NativeListAsync<Entity> DKCPDNAOEIL);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PCIECNKPMFJ(DFHONOJNOEJ MILGMIKPGOF);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CHMEJJHAKBC(NativeListAsync<Entity> DKBEJNJFJAC, bool AMEFIJMKCDL);

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IOJPCIDLPGP();
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[FNBGDBIFOLG(OLEKGNKHMMB.LoadInstance)]
public interface OPBMJCKFKEN
{
	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MOCEICCBIGG(Collider MJPKEDNHCHC, [Out] OPBCKKJBLPD IFCHDBOOIOM);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[FNBGDBIFOLG(OLEKGNKHMMB.LoadInstance)]
public interface GFBGEFGOCGN
{
	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CAKJADOMHNJ(NKJBKLODBOM LMABLLHEJEF, [Out] Collider MJPKEDNHCHC);

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject NGEMNKPCECA(NKJBKLODBOM PIAINDJAIHC, GameObject PFEBHHJNIAE, Vector3 HNNAMHMDPNC, Quaternion LNJHJGHHPKI);

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EKEOBFBCOHG(GameObject MJPKEDNHCHC);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider CAGPEBHPCAI<TCollider>(GameObject CPIOCPMDBEO) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FCINLKGHNJC(Collider MJPKEDNHCHC);

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject NHLCNBCLOGH<TCollider>(string IIADHBOODBK) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[FNBGDBIFOLG(OLEKGNKHMMB.LoadInstance)]
public interface KCFACOPFNOH
{
	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GHNAKNGMOBK(NKJBKLODBOM LMABLLHEJEF, COMPIDEPGKL MGMCIDCLDGL, bool GCAFAIPKEBF, ACJBFNFLLFC GJPLNPBIHAK);

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PGAKAIPKLFL(NKJBKLODBOM LMABLLHEJEF, COMPIDEPGKL MGMCIDCLDGL, bool GCAFAIPKEBF, bool KLKOHBKADME, bool MPCLABLLHNB);

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ENFPOFMALBI NGENEFPMAKH(NKJBKLODBOM LNOFAKNEFAA, List<NKJBKLODBOM> NONEGBINDPA);

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NKJFBKPDKFM(GameObject CLGKCJGNADL, GameObject IPAHHCHGAIG);

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JPBLDFJAOOB(GameObject IPAHHCHGAIG);

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T CAGPEBHPCAI<T>(GameObject CPIOCPMDBEO) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FCINLKGHNJC(Collider MJPKEDNHCHC);

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject NBJABKCKBOO<T>(string IIADHBOODBK) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GAJPMFLAJLD(Collider MJPKEDNHCHC, [Out] NKJBKLODBOM OFDCFOKBLAO);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool KDBCBPEFNIM(NKJBKLODBOM LMABLLHEJEF, [Out] OPBCKKJBLPD IFCHDBOOIOM);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface ACALCNJGOEA
{
	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HDOMKOPCCKF(NKJBKLODBOM LMABLLHEJEF, NKJBKLODBOM HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNAPFILCBHP(NKJBKLODBOM LMABLLHEJEF, NKJBKLODBOM HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int CIEDPKOJKAD(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NKJBKLODBOM KBOMDFOMOPE(NKJBKLODBOM LMABLLHEJEF, int PMNHOLIPOMJ);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FLGPIOIONCG KIIOMEDHBIL(NKJBKLODBOM LMABLLHEJEF, Allocator LGNDPBNMKMP = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FCEPHEDFFLM(NKJBKLODBOM LMABLLHEJEF, object CEFPPEHCFCF, NKJBKLODBOM HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JFJMCDFAADI(NKJBKLODBOM LMABLLHEJEF, object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BBIJNKPGPFH(NKJBKLODBOM LMABLLHEJEF, [Out] NKJBKLODBOM HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PEAHAPCGLIP(NKJBKLODBOM LMABLLHEJEF, float3 HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool ANMDECBCAGH(NKJBKLODBOM LMABLLHEJEF, [Out] float3 HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HMBJOFJPMNA(NKJBKLODBOM LMABLLHEJEF, float3 HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool BLEDFJEAPLA(NKJBKLODBOM LMABLLHEJEF, [Out] float3 HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BNDEFOLDDOI(NKJBKLODBOM LMABLLHEJEF, (Quaternion rot, Vector3 moments) HOGIILJMFNM);

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool JIIHNFDNHLC(NKJBKLODBOM LMABLLHEJEF, [Out] quaternion HKEEEIOLJKM, [Out] float3 MCBLBEEAPHC);

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CDFMMCKBNII(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 APBJJOLKBLL(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 NLNALEPFOCI(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EGOGBAAKFJD(NKJBKLODBOM LMABLLHEJEF, float3 HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OEHICAJGNGN(NKJBKLODBOM LMABLLHEJEF, float3 HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float KKEAJFEMPNE(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float DHEINGNIGIL(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void JBHCGOONBEI(NKJBKLODBOM LMABLLHEJEF, float HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PDLKCGMJMGD(NKJBKLODBOM LMABLLHEJEF, float HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode FNNHBFLIFLJ(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JAFEHLKNGNE(NKJBKLODBOM LMABLLHEJEF, CollisionDetectionMode HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "25")]
	HLACIDOJOGN KLLNFOCOPJI(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NHAKJOFBICO(NKJBKLODBOM LMABLLHEJEF, HLACIDOJOGN HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool DKHKNJHNJHE(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void CFCODLHFNAM(NKJBKLODBOM LMABLLHEJEF, bool HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "29")]
	NKJBKLODBOM FNMLLBADPHM(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void HLNDAPNMALG(NKJBKLODBOM LMABLLHEJEF, NKJBKLODBOM HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "31")]
	NKJBKLODBOM OKIAIBIAEDD(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void NDMMKDCEAMC(NKJBKLODBOM LMABLLHEJEF, NKJBKLODBOM HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "33")]
	MGOCMEIHPAH BFFFLAEPCLA(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void DCPBEPOKFAG(NKJBKLODBOM LMABLLHEJEF, MGOCMEIHPAH OOIAPDIEPPC);

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool KAJBHBDNJFO(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void AAKAEAHALJB(NKJBKLODBOM LMABLLHEJEF, bool HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool CJEMMPBJFBD(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void CFNIPAAJBIF(NKJBKLODBOM LMABLLHEJEF, bool HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints CALIPHPBLEO(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void MAIJGNAGCLA(NKJBKLODBOM LMABLLHEJEF, RigidbodyConstraints HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float KLGGMCLDKFN(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void IIDKPLBCGGE(NKJBKLODBOM LMABLLHEJEF, float HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float LABLNGPBKCI(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void ALIHFGPBFIG(NKJBKLODBOM LMABLLHEJEF, float HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool HAOBNKGKAGD(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void ONFNAOIDLDO(NKJBKLODBOM LMABLLHEJEF, bool HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool PMBDLJPGICO(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void EOLGCKIGDCI(NKJBKLODBOM LMABLLHEJEF, bool HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void MJIAGDGNFMH(NKJBKLODBOM LMABLLHEJEF, int HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "50")]
	HGDEADHMLPB LPININEEAMB(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void KOOHJBBKGHL(NKJBKLODBOM LMABLLHEJEF, HGDEADHMLPB HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "52")]
	ADACCNNPCMH PDGNGDBGGNB(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void JGLGPBMGFBP(NKJBKLODBOM LMABLLHEJEF, ADACCNNPCMH HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float ODEBOEAIMIF(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void IGGBLIIIOPP(NKJBKLODBOM LMABLLHEJEF, float HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void LABABPGNAPJ(NKJBKLODBOM LMABLLHEJEF, object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void IBFEBIHPNPF(NKJBKLODBOM LMABLLHEJEF, object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool GOOMEMJJLEH(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void KFGPEFCKBHE(NKJBKLODBOM LMABLLHEJEF, object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void GHEBBLDALPH(NKJBKLODBOM LMABLLHEJEF, object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool LMGBPODAAML(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool BGJFEBCHKJK(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody ICAADIGIBNJ(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void HGCLGOCNFPN(NKJBKLODBOM LMABLLHEJEF, Rigidbody NCIFAJPFOJP);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void HABHNOOKKKB(NKJBKLODBOM LMABLLHEJEF, object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void ENDPKLCJOGC(NKJBKLODBOM LMABLLHEJEF, object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool GDGKGIJDOPI(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void PIIDFKCHJIO(NKJBKLODBOM LMABLLHEJEF, float3 OAFPAEEDKIL);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void FJNMGIABDMD(NKJBKLODBOM LMABLLHEJEF, float3 MELEABFLNHP);

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool FBHHNFIDOMA(NKJBKLODBOM LMABLLHEJEF, [Out] float3 OAFPAEEDKIL);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool FFEPGBKCHGP(NKJBKLODBOM LMABLLHEJEF, [Out] float3 MELEABFLNHP);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool NAKOAPFAJJB(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void CALJKLPEFIM(NKJBKLODBOM LMABLLHEJEF, object CEFPPEHCFCF, bool FBFCNIMNMCH);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void OGLKJMIJMOJ(NKJBKLODBOM LMABLLHEJEF, bool MFOEIEEDPPK);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void FJEJDIPIBLL(NKJBKLODBOM LMABLLHEJEF);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool FJBOBKCDNKO(NKJBKLODBOM LMABLLHEJEF);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[FNBGDBIFOLG(OLEKGNKHMMB.LoadInstance)]
public interface IIPOGGINBFH
{
	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBCJJCPPFBB(Entity AIGGJECCMFL);

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JEKJGDLGNOF(Entity AIGGJECCMFL);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[FNBGDBIFOLG(OLEKGNKHMMB.LoadInstance)]
public interface DDOGGLEPLPC
{
	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CALCMFCGGDD(NKJBKLODBOM FMEDEJNEJHJ, bool FBONKBLIAIN);

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFENLONJLKG(NKJBKLODBOM FMEDEJNEJHJ, int HGLMKMOLHBA);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public delegate void LNOAHFGAFJE(BHIIDIFEHEO IBIGJBKNJEL);
[Cpp2IlInjected.Token(Token = "0x2000091")]
public readonly struct BHIIDIFEHEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly FLGPIOIONCG ANICODJELGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly NativeArray<byte> DDBPKNAMPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly NativeArray<byte> CJOPJCNNDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly FEKOGHEDMJE FNCDBPBCGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly int LBHNBFPNGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly Type ACJMJIIBALE;

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public FLGPIOIONCG NBBFKEAIICP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x9BF250", Offset = "0x9BE450", VA = "0x1809BF250")]
		get
		{
			return default(FLGPIOIONCG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x64DBD80", Offset = "0x64DAF80", VA = "0x1864DBD80")]
	public BHIIDIFEHEO(FLGPIOIONCG ANICODJELGG, NativeArray<byte> DDBPKNAMPGF, NativeArray<byte> CJOPJCNNDJJ, FEKOGHEDMJE FNCDBPBCGFM, int LBHNBFPNGAA, Type ACJMJIIBALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x2775710", Offset = "0x2774910", VA = "0x182775710")]
	public NativeArray<T> CCOEEBBPKOH<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x2775840", Offset = "0x2774A40", VA = "0x182775840")]
	public NativeArray<T> NBILNMCEDFD<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2775750", Offset = "0x2774950", VA = "0x182775750")]
	public (FLGPIOIONCG, NativeArray<T>, NativeArray<T>) JIBGFLOLNJM<T>() where T : struct
	{
		return default((FLGPIOIONCG, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x64DBD30", Offset = "0x64DAF30", VA = "0x1864DBD30")]
	public PGLDIBNMGHH JCDOAOBCFHC()
	{
		return default(PGLDIBNMGHH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public interface JGMLEKIFIMO
{
	[Cpp2IlInjected.Token(Token = "0x17000188")]
	string JHNMAJLCCGI
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	JGMLEKIFIMO CDLNGHAJJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	IEnumerable<JGMLEKIFIMO> OAKPDEKNPOE
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[FNBGDBIFOLG(OLEKGNKHMMB.LoadInstance)]
public interface GMGFAACODHI
{
	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	JGMLEKIFIMO HHAPAHBPKPF
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	List<OOBELHIGCDM> AOOGKMFBDHB
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LFPCLJAPPGM(OOBELHIGCDM EHMJOHOMDOD, [Out] JGMLEKIFIMO FPAMHMBGLIL);

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FLGJIGKCNJL(OOBELHIGCDM EHMJOHOMDOD, LNOAHFGAFJE EOIICMCDNAE);

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EDLBJFIEJDL(OOBELHIGCDM EHMJOHOMDOD, LNOAHFGAFJE EOIICMCDNAE);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public readonly struct PGLDIBNMGHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly BHIIDIFEHEO JLJKEBMIIPF;

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public FLGPIOIONCG NBBFKEAIICP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x9BF250", Offset = "0x9BE450", VA = "0x1809BF250")]
		get
		{
			return default(FLGPIOIONCG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x64ECA90", Offset = "0x64EBC90", VA = "0x1864ECA90")]
	public PGLDIBNMGHH(BHIIDIFEHEO JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x64EC7D0", Offset = "0x64EB9D0", VA = "0x1864EC7D0")]
	public FLGPIOIONCG CCOEEBBPKOH()
	{
		return default(FLGPIOIONCG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x64EC9C0", Offset = "0x64EBBC0", VA = "0x1864EC9C0")]
	public FLGPIOIONCG NBILNMCEDFD()
	{
		return default(FLGPIOIONCG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x64EC8A0", Offset = "0x64EBAA0", VA = "0x1864EC8A0")]
	public (FLGPIOIONCG, FLGPIOIONCG, FLGPIOIONCG) JIBGFLOLNJM()
	{
		return default((FLGPIOIONCG, FLGPIOIONCG, FLGPIOIONCG));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[DefaultMember("Item")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface PLCMNDFDOBK : IEnumerable<NCIJLJCLLBO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	NativeBitArray HHIAEGOPPLN
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	NativeArray<int> CEEEOBLPHBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	int HJGLMCCDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	NCIJLJCLLBO FOFBNHMHKAA
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	NCIJLJCLLBO FOFBNHMHKAA
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NCIJLJCLLBO NADBFMPDFJA(GFJEFLGHFJD HFIBFDNGBHE);

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FEKOGHEDMJE BHIGAHOHABF(GFJEFLGHFJD HFIBFDNGBHE);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class DJLLCPHMDLB
{
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
[DefaultMember("Item")]
public interface JKLPJJIIDHH : IEnumerable<IJOCAJGKIAB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000193")]
	int HJGLMCCDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	IJOCAJGKIAB FOFBNHMHKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IJOCAJGKIAB NADBFMPDFJA(GFJEFLGHFJD HFIBFDNGBHE);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FEKOGHEDMJE BHIGAHOHABF(GFJEFLGHFJD HFIBFDNGBHE);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class CNPCNGOIOBO
{
	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x27D9E10", Offset = "0x27D9010", VA = "0x1827D9E10")]
	public static FEKOGHEDMJE BHIGAHOHABF<T>(this JKLPJJIIDHH GCKNBJJCNMG, AKLFANKGLAK<T> IIADHBOODBK) where T : struct
	{
		return default(FEKOGHEDMJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[DefaultMember("Item")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface AIMCKHGIGLN : IEnumerable<OOBELHIGCDM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000195")]
	int HJGLMCCDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	OOBELHIGCDM FOFBNHMHKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OOBELHIGCDM NADBFMPDFJA(GFJEFLGHFJD HFIBFDNGBHE);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FEKOGHEDMJE BHIGAHOHABF(GFJEFLGHFJD HFIBFDNGBHE);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class JKMFKDLKHPH
{
	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x29F5710", Offset = "0x29F4910", VA = "0x1829F5710")]
	public static CDJAHFBFNFL<T> NADBFMPDFJA<T>(this AIMCKHGIGLN GCKNBJJCNMG, GFJEFLGHFJD IIADHBOODBK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x29F5610", Offset = "0x29F4810", VA = "0x1829F5610")]
	public static FEKOGHEDMJE BHIGAHOHABF<T>(this AIMCKHGIGLN GCKNBJJCNMG, AKLFANKGLAK<T> IIADHBOODBK) where T : struct
	{
		return default(FEKOGHEDMJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[FNBGDBIFOLG(OLEKGNKHMMB.LoadInstance)]
public interface CIJPBBJALDI
{
	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLGJIGKCNJL(GFJEFLGHFJD EHMJOHOMDOD, LNOAHFGAFJE EOIICMCDNAE);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EDLBJFIEJDL(GFJEFLGHFJD EHMJOHOMDOD, LNOAHFGAFJE EOIICMCDNAE);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public static class LIEPJCBEKBL
{
	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2A358F0", Offset = "0x2A34AF0", VA = "0x182A358F0")]
	public static void FLGJIGKCNJL<T>(this CIJPBBJALDI LLBBFOOGOEC, AKLFANKGLAK<T> EHMJOHOMDOD, LNOAHFGAFJE EOIICMCDNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2A356D0", Offset = "0x2A348D0", VA = "0x182A356D0")]
	public static void EDLBJFIEJDL<T>(this CIJPBBJALDI LLBBFOOGOEC, AKLFANKGLAK<T> EHMJOHOMDOD, LNOAHFGAFJE EOIICMCDNAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface LLPPAIINIHE
{
	[Cpp2IlInjected.Token(Token = "0x17000197")]
	HGMIJGBEJFJ FOOJFPMMPPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IJOMOALNCPC(AOHONJCJOFF OLFMODBDOAG, FEKOGHEDMJE EHMJOHOMDOD);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OCHODJOPEKF(AOHONJCJOFF OLFMODBDOAG, Span<FEKOGHEDMJE> GCKNBJJCNMG, bool CKLJNJKDFKF);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DKHIGMADMNC(NativeArray<AOHONJCJOFF> BHCHGCPMHAI);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public static class IIANDCNHEKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x64E5C40", Offset = "0x64E4E40", VA = "0x1864E5C40")]
	public static void OCHODJOPEKF(this LLPPAIINIHE EDBDJDGGLLB, AOHONJCJOFF OLFMODBDOAG, FEKOGHEDMJE EHMJOHOMDOD, bool CKLJNJKDFKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public readonly struct HGMIJGBEJFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly NativeBitArray OLBDBJENLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly NativeParallelHashMap<AOHONJCJOFF, int> NJGBIIADEIE;

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public bool EHNLPDCDCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x64E4200", Offset = "0x64E3400", VA = "0x1864E4200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0xC93880", Offset = "0xC92A80", VA = "0x180C93880")]
	public HGMIJGBEJFJ(NativeBitArray OLBDBJENLMN, NativeParallelHashMap<AOHONJCJOFF, int> NJGBIIADEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x64E4220", Offset = "0x64E3420", VA = "0x1864E4220")]
	public bool IJOMOALNCPC(AOHONJCJOFF OLFMODBDOAG, FEKOGHEDMJE EHMJOHOMDOD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[FNBGDBIFOLG(OLEKGNKHMMB.LoadInstance)]
public interface JJBHOKBDAPK
{
	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GNPCHFLDNOE(NKJBKLODBOM LMABLLHEJEF, IIIFPNNMFAO HLCKBKFCMPI);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface LCPILLPDIJG
{
	[Cpp2IlInjected.Token(Token = "0x17000199")]
	IGEOLMBFFAJ JCNOLIINCPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface CKONFDIJNAI
{
	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	Type MFPCCNMIHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[FNBGDBIFOLG(OLEKGNKHMMB.LoadInstance)]
public interface EBKKKPHJKGB
{
	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EAKEPEMMCJC(NKJBKLODBOM IAODGFOMGBJ, bool HLCKBKFCMPI);
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public readonly struct FBGBPOGKJDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly IEnumerable<CEANAOOGMEO> BGGLMHCGIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly IReadOnlyList<GameObject> HGBANPPGCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly IReadOnlyList<int> BJFOFGDMCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly IReadOnlyList<(AOHONJCJOFF, AOHONJCJOFF)> KMFCFCOFEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly int OGAMLNFKAEN;

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public bool DOILPLLJOOE
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x64DEAC0", Offset = "0x64DDCC0", VA = "0x1864DEAC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	public int GCDJFIPHNJH
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x831BC0", Offset = "0x830DC0", VA = "0x180831BC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public IEnumerable<GameObject> GGAAGHNICFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x837D60", Offset = "0x836F60", VA = "0x180837D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public IEnumerable<(AOHONJCJOFF src, AOHONJCJOFF dst)> JPKAILAFMMB
	{
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x64DEEA0", Offset = "0x64DE0A0", VA = "0x1864DEEA0")]
	public FBGBPOGKJDF(IEnumerable<CEANAOOGMEO> BGGLMHCGIFB, IReadOnlyList<GameObject> HGBANPPGCFG, IReadOnlyList<int> BJFOFGDMCHA, IReadOnlyList<(AOHONJCJOFF src, AOHONJCJOFF dst)> KMFCFCOFEDK, int OGAMLNFKAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x64DEB20", Offset = "0x64DDD20", VA = "0x1864DEB20")]
	public (GameObject, int)[] KDBMGKJGCLD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface BBGEKGIFDCN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	bool BNBMDFLIMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	bool BGIHHJPPMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	KBBBFALLBFC EMJNJCHPEPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GBCBFMNMHMD PMNKDMMGHOC();

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GBCBFMNMHMD GCICILKMJAK(IEnumerable<NKJBKLODBOM> DOLLNNCPINB, [In] UniformTRS HEBLKHDBMJE);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MJIENAKHBFM HPDKKDIHOIL(ByteString BPEBLFGALHH);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GEKFDFLLKIH LAEJKEGHBGJ(ByteString FENHJHOBMAI, NKJBKLODBOM BGILIGANMHA, [In] UniformTRS FDNGEFJJENC, CAPHPKBHNAE LOEMGPHEPMG, bool CCNCODLECON = true);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OOBDKIIHEFC();

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FBGBPOGKJDF JMFDMDHDMDN(IEnumerable<CEANAOOGMEO> BGGLMHCGIFB);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class EAKOCKDLEEN
{
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface CJMBDLMJLFD
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action IFMNAPOIJNJ;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event Action EALNIELAEPN;
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct PKGMOMJHDBO : ILHEOHOKJAJ, IEquatable<PKGMOMJHDBO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public LFJMPPMLIHF KCLAFPDDNOC;

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x64ECE40", Offset = "0x64EC040", VA = "0x1864ECE40", Slot = "5")]
	public void IHPADLGFHBL(GCKPPDHHJOE LAAOMLILGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x64ECE10", Offset = "0x64EC010", VA = "0x1864ECE10", Slot = "4")]
	public void GKNEHCEDNDE(AHJFMLMCBMD AELHGGJOBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x64ECE70", Offset = "0x64EC070", VA = "0x1864ECE70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x92A880", Offset = "0x929A80", VA = "0x18092A880", Slot = "6")]
	public bool Equals(PKGMOMJHDBO JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x64ECD80", Offset = "0x64EBF80", VA = "0x1864ECD80", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x877370", Offset = "0x876570", VA = "0x180877370", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct AOHONJCJOFF : IComparable<AOHONJCJOFF>, IEquatable<AOHONJCJOFF>, ILHEOHOKJAJ
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public const uint HKBLIGIKMGB = 0u;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public const uint PDIHELNEBOA = 255u;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly AOHONJCJOFF LCFMFCBHMEC;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private const int AMGHICNMEFE = 24;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private const uint EGPKKBEDGAE = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private const int HDNPMLOLLNB = 8;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private const uint CHALJIOGPMG = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly uint PGPEJDBBJED;

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public uint NCMGLEOGAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x814280", Offset = "0x813480", VA = "0x180814280")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public uint OGADOHBOMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x64DBC80", Offset = "0x64DAE80", VA = "0x1864DBC80")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public uint CGNJCNCEFNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x877370", Offset = "0x876570", VA = "0x180877370")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public bool DOILPLLJOOE
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x6453360", Offset = "0x6452560", VA = "0x186453360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0xD96860", Offset = "0xD95A60", VA = "0x180D96860")]
	public static AOHONJCJOFF JFMJMLKPDEA(uint PGPEJDBBJED)
	{
		return default(AOHONJCJOFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x64DBD20", Offset = "0x64DAF20", VA = "0x1864DBD20")]
	public AOHONJCJOFF(int NBANNMCADJI, int ILGHCONAKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x64DBD20", Offset = "0x64DAF20", VA = "0x1864DBD20")]
	public AOHONJCJOFF(uint NBANNMCADJI, int ILGHCONAKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x64DBD20", Offset = "0x64DAF20", VA = "0x1864DBD20")]
	public AOHONJCJOFF(uint NBANNMCADJI, uint ILGHCONAKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x9CBB80", Offset = "0x9CAD80", VA = "0x1809CBB80")]
	private AOHONJCJOFF(uint PGPEJDBBJED)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x1994A80", Offset = "0x1993C80", VA = "0x181994A80")]
	public static bool LOAKJDDAMKI(AOHONJCJOFF BPOHBPAMNLC, AOHONJCJOFF NOIIDJMAOFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x64DBC70", Offset = "0x64DAE70", VA = "0x1864DBC70")]
	public static bool IICOCCMJGPI(AOHONJCJOFF BPOHBPAMNLC, AOHONJCJOFF NOIIDJMAOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x92A880", Offset = "0x929A80", VA = "0x18092A880", Slot = "5")]
	public bool Equals(AOHONJCJOFF IFAFPBGLEJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x64DBB20", Offset = "0x64DAD20", VA = "0x1864DBB20", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x24028D0", Offset = "0x2401AD0", VA = "0x1824028D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x64DBC90", Offset = "0x64DAE90", VA = "0x1864DBC90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x64DBBB0", Offset = "0x64DADB0", VA = "0x1864DBBB0", Slot = "6")]
	public void GKNEHCEDNDE(AHJFMLMCBMD AELHGGJOBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x64DBC10", Offset = "0x64DAE10", VA = "0x1864DBC10", Slot = "7")]
	public void IHPADLGFHBL(GCKPPDHHJOE LAAOMLILGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x63FFA40", Offset = "0x63FEC40", VA = "0x1863FFA40", Slot = "4")]
	public int CompareTo(AOHONJCJOFF JPLJHFMPDFD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public struct CEANAOOGMEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Guid LDJEJDDHHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public string HDOGLMBKHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Vector3 CAOOPLKANIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Quaternion JCCMNAMJFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Vector3 MGKBJKPBCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public int HGEPONOBKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Dictionary<string, object> EOHMOLAFOBC;

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x64DCD00", Offset = "0x64DBF00", VA = "0x1864DCD00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x64DCB70", Offset = "0x64DBD70", VA = "0x1864DCB70")]
	private static string FBLEHMLOOGA(Dictionary<string, object> HANDLMFNBGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public enum KOAJFFHNNLO
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class POFIHONIOAO
{
	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x59514B0", Offset = "0x59506B0", VA = "0x1859514B0")]
	public static bool BLBMNLGGGNO(this KOAJFFHNNLO HHJOOHJDNNM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[Flags]
public enum PJFOBJPKAAH
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
public interface GEKFDFLLKIH : KBBBFALLBFC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	CAPHPKBHNAE HILIFBOPBEO
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMLDLFJMPOP();

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BEMGDLCENDH();
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public interface KBBBFALLBFC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	IEnumerable<CEANAOOGMEO> HEBLMFLJKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	FBGBPOGKJDF CBMAMMJMNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	LocalId DMMLONPONOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	KDKCEOPEEPM PJCJGBJHBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DMDKHAOOBDK(PJFOBJPKAAH PBHPGPAMENJ);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public interface CAPHPKBHNAE
{
	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DGBJKKMMGNA(Guid NAKAAHDEHKM, [Out] Guid MMPICMIHPIL);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public interface MJIENAKHBFM : KBBBFALLBFC, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[Flags]
public enum MNLGCHEKDGD
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
public interface GBCBFMNMHMD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	KDKCEOPEEPM ADEKMFNCBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString ICHNLNAFCCC();
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public enum LCGBAJLPBEF
{
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public delegate bool GBDPAIHCPEJ(PDMAOIJJLND DBPADPNAIIG, [In] DKKBPBAMFKA HLCKBKFCMPI);
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public delegate bool FHJKKPCKIKB<T>(PDMAOIJJLND DBPADPNAIIG, [In] T HLCKBKFCMPI);
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface GKPBIOAJIEG
{
	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLGJIGKCNJL(FEKOGHEDMJE FNCDBPBCGFM, Type BAJMHOIPFBE, GBDPAIHCPEJ EPHCAGJNHBF);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JLOIDIKGAJA(FEKOGHEDMJE FNCDBPBCGFM, [Out] GBDPAIHCPEJ EPHCAGJNHBF);
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public static class LFFDBIEADMP
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private sealed class GGMNPPODLJF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public FHJKKPCKIKB<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public GGMNPPODLJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x39CFF90", Offset = "0x39CF190", VA = "0x1839CFF90")]
		internal bool PNDPDANNFBP(PDMAOIJJLND pendingList, [In] DKKBPBAMFKA value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x2A34100", Offset = "0x2A33300", VA = "0x182A34100")]
	public static void FLGJIGKCNJL<T>(this GKPBIOAJIEG LLBBFOOGOEC, FEKOGHEDMJE FNCDBPBCGFM, FHJKKPCKIKB<T> EPHCAGJNHBF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x64E74D0", Offset = "0x64E66D0", VA = "0x1864E74D0")]
	public static bool CKFJOAPGIJC(this GKPBIOAJIEG LLBBFOOGOEC, PDMAOIJJLND DBPADPNAIIG, FEKOGHEDMJE FNCDBPBCGFM, [In] DKKBPBAMFKA HLCKBKFCMPI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface CLIEDIECEEE
{
	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	uint DMKKPLDCFDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface PDMAOIJJLND
{
	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBLIABMDCJA(AOHONJCJOFF OFOBABNHLCO, FEKOGHEDMJE FNCDBPBCGFM, ReadOnlySpan<byte> EKEJBEHHGAF, ReadOnlySpan<byte> BLLPEHDBLBA);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HKENJMLPPCN(AOHONJCJOFF OFOBABNHLCO, FEKOGHEDMJE FNCDBPBCGFM);

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LOEDFAAHLIJ(AOHONJCJOFF OFOBABNHLCO, FEKOGHEDMJE FNCDBPBCGFM, ReadOnlySpan<byte> BLLPEHDBLBA);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NBEMHKJGBJO(AOHONJCJOFF OFOBABNHLCO, FEKOGHEDMJE FNCDBPBCGFM, Span<byte> EKEJBEHHGAF, Span<byte> BLLPEHDBLBA);
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class LHJMHIEKMKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x2A351F0", Offset = "0x2A343F0", VA = "0x182A351F0")]
	public static bool NBEMHKJGBJO<T>(this PDMAOIJJLND DFFKLLOBKGK, AOHONJCJOFF OFOBABNHLCO, FEKOGHEDMJE FNCDBPBCGFM, [Out] T EKEJBEHHGAF, [Out] T BLLPEHDBLBA) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x2A350D0", Offset = "0x2A342D0", VA = "0x182A350D0")]
	public static bool LOEDFAAHLIJ<T>(this PDMAOIJJLND DFFKLLOBKGK, AOHONJCJOFF OFOBABNHLCO, FEKOGHEDMJE FNCDBPBCGFM, T BLLPEHDBLBA) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public enum ENNEEOOLOCD
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
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface OOJGBJFJLGE
{
	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EAGFBFILFNK(CLOIMHFLJCP GNIGPOPNBEB, ReadOnlySpan<byte> EIAKFCMMIEA);

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBPFJAPFJIE(uint LBEICOGLEFF, ReadOnlySpan<byte> EIAKFCMMIEA);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLJOHCIGKLC(int INKLJIDKDDM);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface GKANOGNMFGE
{
	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CLOIMHFLJCP OELEPMKDMKL(ReadOnlySpan<byte> EIAKFCMMIEA);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface BPDGJNCDCHN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IKBPLILOLFK(CLOIMHFLJCP MNOIAMGNLNL, ReadOnlySpan<byte> EIAKFCMMIEA);

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JJECJANACDL(ReadOnlySpan<CLOIMHFLJCP> IFGIBCIIBJO);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public struct DJBBMHDDJDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public CLOIMHFLJCP GNIGPOPNBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public ReadOnlyMemory<byte> EIAKFCMMIEA;
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public struct CLOIMHFLJCP
{
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public static CLOIMHFLJCP IBBCPDFPHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public uint NBANNMCADJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public int EDMAIDCBKHN;

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0xB93B00", Offset = "0xB92D00", VA = "0x180B93B00")]
	public CLOIMHFLJCP(uint NBANNMCADJI, int EDMAIDCBKHN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x64DD0E0", Offset = "0x64DC2E0", VA = "0x1864DD0E0")]
	public static bool LOAKJDDAMKI([In] CLOIMHFLJCP GFINPEICFEL, [In] CLOIMHFLJCP ENBAOKALGHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x64DCFF0", Offset = "0x64DC1F0", VA = "0x1864DCFF0", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x64DD0B0", Offset = "0x64DC2B0", VA = "0x1864DD0B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x64DD100", Offset = "0x64DC300", VA = "0x1864DD100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x64DD0A0", Offset = "0x64DC2A0", VA = "0x1864DD0A0")]
	public void FPCLJKLMLOD([Out] uint NBANNMCADJI, [Out] int EDMAIDCBKHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[FNBGDBIFOLG(OLEKGNKHMMB.OMRoom)]
public interface DMKKAEFLECA : PPGBPPLBNCB<DMKKAEFLECA>
{
	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AAGKBFDKAOO(FEKOGHEDMJE IFAFPBGLEJO, [Out] HLDBJHGFOIC OPKCMDNJEAG);
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class CKENFDJPLBL
{
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public interface HLDBJHGFOIC
{
	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	Type EENCBANFCHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHPADLGFHBL(GCKPPDHHJOE LAAOMLILGHH, Span<byte> FMEDEJNEJHJ);

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GKNEHCEDNDE(AHJFMLMCBMD AELHGGJOBCK, ReadOnlySpan<byte> GNIGPOPNBEB);
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class JPKGPOMCFOC
{
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public struct DAHEELCIBLC : ISystemStateComponentData, IComponentData, IEquatable<DAHEELCIBLC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public float3 PDGAAEFHKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public float3 AKHGFIDPLGL;

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x64DD1F0", Offset = "0x64DC3F0", VA = "0x1864DD1F0", Slot = "4")]
	public bool Equals(DAHEELCIBLC JPLJHFMPDFD)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class MIKFNFJDMKB
{
	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public MIKFNFJDMKB()
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
