using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
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
	public class LogRegistrationIndex : PBLCGONKBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6B11AD0", Offset = "0x6B100D0", VA = "0x186B11AD0", Slot = "4")]
		public override void NECNOABNHFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PHIACDALGKC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6B16350", Offset = "0x6B14950", VA = "0x186B16350")]
	public static void LLHGDOPDHEC(this Rigidbody CMKNKCMANHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6B164E0", Offset = "0x6B14AE0", VA = "0x186B164E0")]
	public static void LLHGDOPDHEC(this Rigidbody CMKNKCMANHF, Vector3 DOGCJHOBHDG, Quaternion OPDBCGCJIPH, Vector3 LOKANFFOEAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct DBDGEDGIEPP : IReadOnlyList<AMOFBKBMFBA>, IEnumerable<AMOFBKBMFBA>, IEnumerable, IReadOnlyCollection<AMOFBKBMFBA>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct JIJJLCPFOOK : IEnumerator<AMOFBKBMFBA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly CPNHAFLLNGA HPPPLLCFNKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator JGMPEELHOOB;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AMOFBKBMFBA FOBIFFPGMIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6B0E1C0", Offset = "0x6B0C7C0", VA = "0x186B0E1C0", Slot = "4")]
			get
			{
				return default(AMOFBKBMFBA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6B0E140", Offset = "0x6B0C740", VA = "0x186B0E140", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x42B3CE0", Offset = "0x42B22E0", VA = "0x1842B3CE0")]
		public JIJJLCPFOOK(CPNHAFLLNGA HPPPLLCFNKH, NativeArray<LocalId>.Enumerator JGMPEELHOOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6B0E080", Offset = "0x6B0C680", VA = "0x186B0E080", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6B0E0C0", Offset = "0x6B0C6C0", VA = "0x186B0E0C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6B0E100", Offset = "0x6B0C700", VA = "0x186B0E100", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly CPNHAFLLNGA HPPPLLCFNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> NAKHKAGBEGC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public AMOFBKBMFBA CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6B07740", Offset = "0x6B05D40", VA = "0x186B07740", Slot = "4")]
		get
		{
			return default(AMOFBKBMFBA);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6B07280", Offset = "0x6B05880", VA = "0x186B07280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int IDKJFAKPEFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8661A0", Offset = "0x8647A0", VA = "0x1808661A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public CPNHAFLLNGA ECBIJNMIEJE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int LBEGGACHKEL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8661A0", Offset = "0x8647A0", VA = "0x1808661A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool ANHMLBKHNDM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6B072D0", Offset = "0x6B058D0", VA = "0x186B072D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> MMAIOCNFIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x259F470", Offset = "0x259DA70", VA = "0x18259F470")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> PBAGENMDOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6B07190", Offset = "0x6B05790", VA = "0x186B07190")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B075A0", Offset = "0x6B05BA0", VA = "0x186B075A0")]
	public DBDGEDGIEPP(int PLGOIBDCNBN, CPNHAFLLNGA HPPPLLCFNKH, Allocator KOIILCBLJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x42B3E50", Offset = "0x42B2450", VA = "0x1842B3E50")]
	public DBDGEDGIEPP(CPNHAFLLNGA HPPPLLCFNKH, NativeArray<LocalId> NAKHKAGBEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6B07630", Offset = "0x6B05C30", VA = "0x186B07630")]
	internal DBDGEDGIEPP(CPNHAFLLNGA HPPPLLCFNKH, NativeArray<Entity> OKKKBJGONCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6B076A0", Offset = "0x6B05CA0", VA = "0x186B076A0")]
	public DBDGEDGIEPP(CPNHAFLLNGA HPPPLLCFNKH, int JOCLJBACIHN, Allocator KOIILCBLJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6B074F0", Offset = "0x6B05AF0", VA = "0x186B074F0")]
	public DBDGEDGIEPP(DBDGEDGIEPP CMFFEBELHLM, Allocator KOIILCBLJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6B070A0", Offset = "0x6B056A0", VA = "0x186B070A0")]
	public DBDGEDGIEPP AGJCCCHJIOG(Allocator KOIILCBLJPK = Allocator.Temp)
	{
		return default(DBDGEDGIEPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6B07150", Offset = "0x6B05750", VA = "0x186B07150", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6B071F0", Offset = "0x6B057F0", VA = "0x186B071F0")]
	public JIJJLCPFOOK GGGADAADMEJ()
	{
		return default(JIJJLCPFOOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6B07310", Offset = "0x6B05910", VA = "0x186B07310", Slot = "6")]
	private IEnumerator<AMOFBKBMFBA> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6B07400", Offset = "0x6B05A00", VA = "0x186B07400", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public struct JILGHDIEPCE : IList<AMOFBKBMFBA>, ICollection<AMOFBKBMFBA>, IEnumerable<AMOFBKBMFBA>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OGPGMEGAOOH : IEnumerator<AMOFBKBMFBA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly CPNHAFLLNGA HPPPLLCFNKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator JGMPEELHOOB;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public AMOFBKBMFBA FOBIFFPGMIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6B13AC0", Offset = "0x6B120C0", VA = "0x186B13AC0", Slot = "4")]
			get
			{
				return default(AMOFBKBMFBA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6B13A40", Offset = "0x6B12040", VA = "0x186B13A40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x42B3CE0", Offset = "0x42B22E0", VA = "0x1842B3CE0")]
		public OGPGMEGAOOH(CPNHAFLLNGA HPPPLLCFNKH, NativeArray<LocalId>.Enumerator JGMPEELHOOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6B13980", Offset = "0x6B11F80", VA = "0x186B13980", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6B139C0", Offset = "0x6B11FC0", VA = "0x186B139C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6B13A00", Offset = "0x6B12000", VA = "0x186B13A00", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CPNHAFLLNGA HPPPLLCFNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> NAKHKAGBEGC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public AMOFBKBMFBA CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6B0EC20", Offset = "0x6B0D220", VA = "0x186B0EC20", Slot = "4")]
		get
		{
			return default(AMOFBKBMFBA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6B0ECA0", Offset = "0x6B0D2A0", VA = "0x186B0ECA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6B0E290", Offset = "0x6B0C890", VA = "0x186B0E290", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int LBEGGACHKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6B0E290", Offset = "0x6B0C890", VA = "0x186B0E290")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool IJMBFBLHEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6B0EA80", Offset = "0x6B0D080", VA = "0x186B0EA80")]
	public JILGHDIEPCE(int PLGOIBDCNBN, CPNHAFLLNGA HPPPLLCFNKH, Allocator KOIILCBLJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6B0EB10", Offset = "0x6B0D110", VA = "0x186B0EB10")]
	public JILGHDIEPCE(CPNHAFLLNGA HPPPLLCFNKH, Allocator KOIILCBLJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6B0EB90", Offset = "0x6B0D190", VA = "0x186B0EB90")]
	public JILGHDIEPCE(CPNHAFLLNGA HPPPLLCFNKH, int JOCLJBACIHN, Allocator KOIILCBLJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6B0E700", Offset = "0x6B0CD00", VA = "0x186B0E700")]
	public DBDGEDGIEPP PGAEADLCDCO()
	{
		return default(DBDGEDGIEPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6B0E2D0", Offset = "0x6B0C8D0", VA = "0x186B0E2D0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6B0E310", Offset = "0x6B0C910", VA = "0x186B0E310", Slot = "13")]
	public bool Contains(AMOFBKBMFBA JAGONPFFNPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6B0E3A0", Offset = "0x6B0C9A0", VA = "0x186B0E3A0", Slot = "14")]
	public void CopyTo(AMOFBKBMFBA[] FAJBEEIFFCK, int FLPMGGGFGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6B0E210", Offset = "0x6B0C810", VA = "0x186B0E210", Slot = "11")]
	public void Add(AMOFBKBMFBA JAGONPFFNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6B0E650", Offset = "0x6B0CC50", VA = "0x186B0E650", Slot = "7")]
	public void Insert(int PDMMEDBMFPP, AMOFBKBMFBA JAGONPFFNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6B0E7D0", Offset = "0x6B0CDD0", VA = "0x186B0E7D0", Slot = "15")]
	public bool Remove(AMOFBKBMFBA JAGONPFFNPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6B0E5C0", Offset = "0x6B0CBC0", VA = "0x186B0E5C0", Slot = "6")]
	public int IndexOf(AMOFBKBMFBA JAGONPFFNPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6B0E780", Offset = "0x6B0CD80", VA = "0x186B0E780", Slot = "8")]
	public void RemoveAt(int PDMMEDBMFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6B0E4F0", Offset = "0x6B0CAF0", VA = "0x186B0E4F0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6B0E530", Offset = "0x6B0CB30", VA = "0x186B0E530")]
	public OGPGMEGAOOH GGGADAADMEJ()
	{
		return default(OGPGMEGAOOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6B0E8A0", Offset = "0x6B0CEA0", VA = "0x186B0E8A0", Slot = "16")]
	private IEnumerator<AMOFBKBMFBA> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6B0E990", Offset = "0x6B0CF90", VA = "0x186B0E990", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HLFHOIANENN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int KEHHAIPMFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> BOPIENAGPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AMOFBKBMFBA GCBBIJPBBME(AMOFBKBMFBA NAKHKAGBEGC);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HGOIJHDBPMH : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface PAAHGPOJCNK : DJDPCMMLOFE, MEJIGCPJODJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool DBIJCBPOGNN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	OMGJBKNLCMM IFHLNGAMABF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	JABNDPBDNBM FCPKMHCJPEG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	AJEIHOPLKOK MDMIEEDKOGE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	ELBEHJPJIAP DLFFMLFHABC
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface MEJIGCPJODJ
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool FKKNICKBACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface AFAPHEMEJAA
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKKKMEMKLAA(bool DMNGPNKHPKF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DBIJOBJFKFD(OFPDOPBEGLP.PhotonRoom)]
public interface FIMMPNCCECB
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool FELCDHIOPGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GIAEMALIPEF(bool PCJPKCENFJC);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FEJDNKLMPEF();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JBEBHCOMIMA(ByteString EABGAFLLHMP);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JGDMKCLGNGH();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MEHGKDDENJC();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DMPFLIDKNOM();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HGOEHEIBMME();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LGNKJAIJHEP();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface AJEIHOPLKOK
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	DPIICBKDOMF IFHLNGAMABF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	JABNDPBDNBM FCPKMHCJPEG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	JBDAPNANMGI IHGCNCDGIIE
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	AHIJFMNMMHF GAKHCMOMBKI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	PAAHGPOJCNK NENMMFMPHMF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	FIMMPNCCECB LILNFGFELJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	CPNHAFLLNGA ECBIJNMIEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IOCMEJKKNBE DNOCCFDMNNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	BDNDDDCPNMG GAAMCHIHCBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DJFGBIHFJCF HLBOHAJALJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	LBKLDIKNPDP EJKJFGFGELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	MEMPAJLKOPH AFPFLBKIMAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	ACDHLIDFNDG AEILABAEPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	OLBNFMLEBDH HCLLCODBMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	KIPFHHKIEAH JEFEILNBDOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	JEHHKJPHPPM CKFCCBPAEDL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	ANBKJMGFOMJ BCOEONINGDK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	ILJDADPJOGB HIFCLNMBFOI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	IKDKABNIMCK HDAKKEHOAHD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	GCLGLEIPBNA PDHDPLAPPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	JHPKMKLBKFM BGDJAFBEFKM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	GIMOLPPICGB CGCMPBLAHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	FELJAJJKNHJ CMCMMNLKIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	CGMJEDMLICD FPJNEGMACCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	PNKHCKOJKBK IODMLKMOIJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	FDMODKPMNMC FJDAJCFDEEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	CADBJKMBAOO ENDHKOGKCHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	OEEDEOGABKH OHCBOIECEGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	OINAKNKLDHL OKCGMDFIGNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(IMKFHACJGIN))]
public readonly struct AMOFBKBMFBA : IComparable<AMOFBKBMFBA>, IEquatable<AMOFBKBMFBA>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly AMOFBKBMFBA NGHCGFLIPPC;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int GEBEEKJGFBF = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int EJBHBJFPKBB = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int JGGKHNKHAAE = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int BOGMJFFNPOO = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId NACMAJFMJAJ;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public CPNHAFLLNGA ECBIJNMIEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6B03190", Offset = "0x6B01790", VA = "0x186B03190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public PAAHGPOJCNK NENMMFMPHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6B05400", Offset = "0x6B03A00", VA = "0x186B05400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public LocalId JPNDFDGHGOO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6B04F90", Offset = "0x6B03590", VA = "0x186B04F90")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal ELBEHJPJIAP DLFFMLFHABC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6B04FD0", Offset = "0x6B035D0", VA = "0x186B04FD0")]
		get
		{
			return default(ELBEHJPJIAP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool ELDMDCADOCM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6B04E50", Offset = "0x6B03450", VA = "0x186B04E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool PLNDPEICIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6B05480", Offset = "0x6B03A80", VA = "0x186B05480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6B05600", Offset = "0x6B03C00", VA = "0x186B05600")]
	public AMOFBKBMFBA(CPNHAFLLNGA OHDJLHKFOIP, LocalId NACMAJFMJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
	public DPCLFAJCHGB HMOBIKJBGLE()
	{
		return default(DPCLFAJCHGB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6B053C0", Offset = "0x6B039C0", VA = "0x186B053C0")]
	public static LocalId HDKGBCFDEBL(AMOFBKBMFBA DPEDJFGFLFO)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6B05380", Offset = "0x6B03980", VA = "0x186B05380")]
	public static Entity HDKGBCFDEBL(AMOFBKBMFBA DPEDJFGFLFO)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6B05260", Offset = "0x6B03860", VA = "0x186B05260")]
	public static bool FFOLOHFBIHN(AMOFBKBMFBA KHKPJFABMKM, AMOFBKBMFBA CGBLKAAFCDI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6B05460", Offset = "0x6B03A60", VA = "0x186B05460")]
	public static bool NKEIKPOPFDO(AMOFBKBMFBA KHKPJFABMKM, AMOFBKBMFBA CGBLKAAFCDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6B054D0", Offset = "0x6B03AD0", VA = "0x186B054D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6B050C0", Offset = "0x6B036C0", VA = "0x186B050C0", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6B04FE0", Offset = "0x6B035E0", VA = "0x186B04FE0", Slot = "4")]
	public int CompareTo(AMOFBKBMFBA BHFGHGMPKOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "5")]
	public bool Equals(AMOFBKBMFBA BHFGHGMPKOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BDDHFEIJGCA
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6B05820", Offset = "0x6B03E20", VA = "0x186B05820")]
	public static KJCIFKAMOBH GJIJDAFNCJM(this AMOFBKBMFBA NJKKPOFFNNJ)
	{
		return default(KJCIFKAMOBH);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6B058D0", Offset = "0x6B03ED0", VA = "0x186B058D0")]
	public static DPCLFAJCHGB OEOLFDEOGBD(this AMOFBKBMFBA NJKKPOFFNNJ)
	{
		return default(DPCLFAJCHGB);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x292B230", Offset = "0x2929830", VA = "0x18292B230")]
	public static T HHABPHHOLPC<T>(this AMOFBKBMFBA NJKKPOFFNNJ) where T : struct, JLCHKADBFPJ
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class IMKFHACJGIN
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct ELBEHJPJIAP : IEquatable<ELBEHJPJIAP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte FPDGNDMPHII;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] KMMNMMLCLMO;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static CPNHAFLLNGA MMLLACMKBFI;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static PAAHGPOJCNK PMGHAMBOJCH;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static CPNHAFLLNGA[] OIKGEEJIACB;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static PAAHGPOJCNK[] NFMPNGKNFIP;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> KMHDNCLGBPA;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public PAAHGPOJCNK NENMMFMPHMF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6B0B320", Offset = "0x6B09920", VA = "0x186B0B320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public CPNHAFLLNGA FKPCPNIOPII
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6B0B480", Offset = "0x6B09A80", VA = "0x186B0B480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B620", Offset = "0x6B09C20", VA = "0x186B0B620")]
	static ELBEHJPJIAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x21B0DF0", Offset = "0x21AF3F0", VA = "0x1821B0DF0")]
	internal ELBEHJPJIAP(byte DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5C64200", Offset = "0x5C62800", VA = "0x185C64200", Slot = "4")]
	public bool Equals(ELBEHJPJIAP BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A940", Offset = "0x6B08F40", VA = "0x186B0A940", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1DD0B70", Offset = "0x1DCF170", VA = "0x181DD0B70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B560", Offset = "0x6B09B60", VA = "0x186B0B560", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A890", Offset = "0x6B08E90", VA = "0x186B0A890")]
	private static CPNHAFLLNGA CPLGGIIHFMB(byte FPDGNDMPHII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A9E0", Offset = "0x6B08FE0", VA = "0x186B0A9E0")]
	private static PAAHGPOJCNK FMLIINGFFNK(byte FPDGNDMPHII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A720", Offset = "0x6B08D20", VA = "0x186B0A720")]
	private static object BNIOMGHOLLI(byte FPDGNDMPHII, object[] EJHPODPBOEP, object DNKAMNBGFFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B040", Offset = "0x6B09640", VA = "0x186B0B040")]
	private static int LDAOJPNPAHH(byte FPDGNDMPHII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B050", Offset = "0x6B09650", VA = "0x186B0B050")]
	private static int MDPJBLEKEKH(byte FPDGNDMPHII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B400", Offset = "0x6B09A00", VA = "0x186B0B400")]
	private static (int, int) PLKFGKIELHK(byte FPDGNDMPHII)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6B0AA90", Offset = "0x6B09090", VA = "0x186B0AA90")]
	private static byte HDEKAGONEDM(int CICFELNCFMD, int PDMMEDBMFPP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B060", Offset = "0x6B09660", VA = "0x186B0B060")]
	internal static ELBEHJPJIAP NECNOABNHFL(PAAHGPOJCNK OHCOIAHKOJN, CPNHAFLLNGA HKMELHDBELN)
	{
		return default(ELBEHJPJIAP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6B0AE30", Offset = "0x6B09430", VA = "0x186B0AE30")]
	internal static void JDBODJEEEFF(ELBEHJPJIAP FPDGNDMPHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6B0AAA0", Offset = "0x6B090A0", VA = "0x186B0AAA0")]
	private static void JADPIIKGMCH(int PLGOIBDCNBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface PNCMHIFPNKL
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELMEJABAMHA();

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GDLHBPDLOFK(bool HEGLIAAJIDO);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OPAGGFBPGMN(GameObject FNAHDAKHMJN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface GEENIGKOICD
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Guid GGNDNEJMHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FMBCFOLFCJJ(Guid BOCKLOLBFPI, Guid CNJMIDDPAFB, Guid OFNFDLELHNO);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task HBONGCPGIKC(Guid BOCKLOLBFPI, Guid[] ABBGIBAIGDN, Guid OFNFDLELHNO);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid EPBPMICBFEL(Guid EHLNCLBLNMA);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task EEHFGGBPNKD(AMOFBKBMFBA PJKHADAHPPG);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PGJHCCGLCCC(AEBAKOEFOMI NKFCBCNIANN, Guid JGDNIHHHCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EGBFIJCOBNP(Guid EHLNCLBLNMA, bool PCJPKCENFJC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface FFDPEHOAEKI
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INHIFEPFHCN(DBDGEDGIEPP NAKHKAGBEGC);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface ACOGHNCDKAH
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CIBJCNIFCIN(GameObject PIBBBCFMKKI, GameObject KCMPBBNFJKI, int GKEEBAIMJKN);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface JABNDPBDNBM
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	PNCMHIFPNKL FHILJLBKKGB
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	DAKIDNAJJBM AJFBBEFLGJC
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	JLEGLKBKPNE DNECLMCNLHN
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	FFFGCFNIPJO KEHEDMDHAPN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	KAFLBPOMMFM IKIBOFACFPH
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	FEDDNPLDKGB MJGALFPELKD
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	PBIIDHKEHDN CBBHGBBBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	ENHOCDCFELE NIMMGFHHFLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	KFHDNMBJPHG BCHMIDIBJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	MNGLOECMIMI FPDAAKOALKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface DAKIDNAJJBM
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string NCHDFCJOEGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface AIGNIOBCONM
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGDLOPGLMCA(Action PEMICEIPPPL, bool FBNGBPPHNND);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HKPJOLNEDEK(string GJEDHMJMNJA);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int FLCOCKJPBFN(string GJEDHMJMNJA, int DNKAMNBGFFH);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HHLIKBLMFNH([Out] bool DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MHFJACFEKMK([Out] bool DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HLFBIDFAEIC([Out] int DMNGPNKHPKF);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface JLEGLKBKPNE
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string FLNDGONCEOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] OAADOHICBHD(IEnumerable<JJDFDCMKAAP> HCLIJPBLHOP, bool PFPEFMDPKGP);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ALJBMCMEAIE(GameObject FNAHDAKHMJN, [Out] KJCIFKAMOBH[] EBMBOEDMFIM);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LNHOFJHPEJI(GameObject FNAHDAKHMJN, [Out] int MEOMOEPDGEN, [Out] IDEDIMNMLPE MDDJDHCOALA);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AEBAKOEFOMI DNGBMEFOFIE(JJDFDCMKAAP EPDDNPCGMCI);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AEBAKOEFOMI DNGBMEFOFIE(string ALGLCCEBAGM, KJCIFKAMOBH[] FAOMEEFLJBM, Vector3 MCPNOOFMAHG, Quaternion GLKHDAMNPBA, Vector3 ICLEOPHCOMM);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AEBAKOEFOMI OLPEDJNPJIK(string ALGLCCEBAGM, KJCIFKAMOBH[] FAOMEEFLJBM, Vector3 MCPNOOFMAHG, Quaternion GLKHDAMNPBA, Vector3 ICLEOPHCOMM);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject LBGBGGCLGCK(string ALGLCCEBAGM);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DOIMFIOCNOB(GameObject JHFDAJPILPM, bool HBGFFBOKCIG);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FMKMGMGPOKF(GameObject FNAHDAKHMJN, bool JCONPCKKFHM, bool EOJGANLFCEE);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class AMMAEKNFIPA
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6B04B70", Offset = "0x6B03170", VA = "0x186B04B70")]
	public static AEBAKOEFOMI DNGBMEFOFIE(this JLEGLKBKPNE MBKGOLHFIHF, Vector3 MCPNOOFMAHG, Quaternion GLKHDAMNPBA, Vector3 ICLEOPHCOMM, params KJCIFKAMOBH[] EBMBOEDMFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6B04CE0", Offset = "0x6B032E0", VA = "0x186B04CE0")]
	public static AEBAKOEFOMI OLPEDJNPJIK(this JLEGLKBKPNE MBKGOLHFIHF, Vector3 MCPNOOFMAHG, Quaternion GLKHDAMNPBA, Vector3 ICLEOPHCOMM, params KJCIFKAMOBH[] EBMBOEDMFIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface FFFGCFNIPJO
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMDOCEMAGLH(bool PCJPKCENFJC);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface KAFLBPOMMFM
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool NMFEEMEPHNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool BMPGCHGEPCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool EHLIBPECKLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	int IBKODOCGEHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool EOHPOLKFCKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KFJLAOBHJNI(object OGADPHAKNMI);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DECJJCCCOMK(object OGADPHAKNMI);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NOEDFPEKKEF(object PABFDMCLKCE);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BBBIHIDPJJN(object PABFDMCLKCE);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ViewId CAIOCLEHIHG(GameObject AEHACDADEAN);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GMKGENKLKFD(NativeArray<ViewId> KFJFLPEOOJC);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CMFKOJLEPEN(NativeArray<ViewId> GMLPDCKCBOI);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AMNCANNFEHB();

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DPPIPHKCHCF(uint IJHMFIPHMLJ, ReadOnlySpan<byte> BEDHEIKJEDJ, bool BLGMGMIBOEC = false);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DPPIPHKCHCF(uint IJHMFIPHMLJ, ReadOnlySpan<byte> BEDHEIKJEDJ, ReadOnlySpan<byte> PLAGGLHLPNE, bool BLGMGMIBOEC = false);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LDKNBOOJNLE(Func<int, bool, int> MNBIAHMPLPM, bool AFHKMFKMKBF);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KNPOOJDHGCB(object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FPKJJPLKLIA(object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "18")]
	uint EKENPGEBFGK(uint PBJFNDLHABE);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class MEHBJPJFGDC
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6B11C60", Offset = "0x6B10260", VA = "0x186B11C60")]
	public static APBBNDLECCM JPIAOPCDNOJ(this KAFLBPOMMFM OPDBIHNNONK, object NJLOKHEKBBE)
	{
		return default(APBBNDLECCM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct APBBNDLECCM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private KAFLBPOMMFM OPDBIHNNONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private object NJLOKHEKBBE;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6B05790", Offset = "0x6B03D90", VA = "0x186B05790")]
	public APBBNDLECCM(KAFLBPOMMFM OPDBIHNNONK, object NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6B05740", Offset = "0x6B03D40", VA = "0x186B05740", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface FEDDNPLDKGB
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OMJNEKLHJHI(GameObject FNAHDAKHMJN);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface PBIIDHKEHDN
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public struct CMOHMCIIFAK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private PBIIDHKEHDN LKDJIGEINNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Task NAFOIMCAMMG;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Task IPNLKMEKKNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x8FA820", Offset = "0x8F8E20", VA = "0x1808FA820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6B06680", Offset = "0x6B04C80", VA = "0x186B06680")]
		public CMOHMCIIFAK(PBIIDHKEHDN LKDJIGEINNA, CancellationToken FIMAIPEFOAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6B06630", Offset = "0x6B04C30", VA = "0x186B06630", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCKLIILIIKH(string ELIMFPDKMPD, float JCFJIBJJHJJ = 5f);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FFKHEFNOJFH(CancellationToken FIMAIPEFOAM);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EEFPABEDIJO();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class DIPHGEBNCPH
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6B09D50", Offset = "0x6B08350", VA = "0x186B09D50")]
	public static PBIIDHKEHDN.CMOHMCIIFAK GIGLJPIDHNH(this PBIIDHKEHDN OPDBIHNNONK, CancellationToken FIMAIPEFOAM)
	{
		return default(PBIIDHKEHDN.CMOHMCIIFAK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface JBNLCCACKPH
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int OFKAPHFHCHL(GameObject FNAHDAKHMJN);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIDOGNCNEAN(GameObject FNAHDAKHMJN);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KCHJLBHDOGD(int BHJAKHNNONP);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object JOFCFNGPFDL(AMOFBKBMFBA NACMAJFMJAJ, GameObject FNAHDAKHMJN, Action<AMOFBKBMFBA, int> JMMEJHGHOEF);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CGIMJJDCHNO(GameObject FNAHDAKHMJN, object BJOOFLIGCBI);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface DIBFABCJHED
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool NKBMHFAHBJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate GECEMGJKNPJ(HIIKEHCPEFF.KNFKABIBENH HOCLEMKJJJF, Action<HIIKEHCPEFF.KNFKABIBENH> JMMEJHGHOEF);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ANMJAOIFNJI(HIIKEHCPEFF.KNFKABIBENH HOCLEMKJJJF, Delegate JMMEJHGHOEF);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate GMIPEMJOBLF(HIIKEHCPEFF.KNFKABIBENH HOCLEMKJJJF, Action<HIIKEHCPEFF.KNFKABIBENH> HFJLHHNLMNA);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KEGHFFKDOJP(HIIKEHCPEFF.KNFKABIBENH HOCLEMKJJJF, Delegate JMMEJHGHOEF);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EPBKCECLMGI(HIIKEHCPEFF.KNFKABIBENH HOCLEMKJJJF);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HIIKEHCPEFF.KNFKABIBENH JKFEPMCHGPH(GameObject FNAHDAKHMJN);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface ENHOCDCFELE
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	int FEOFAEHPPLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	int AHJJMLJHPKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int BCEFCOKNGFM(GameObject FNAHDAKHMJN);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KGGICHLFEEE([Out] Vector3 MCPNOOFMAHG);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PFLABFOIMAM();

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AMOFBKBMFBA LCIGKHKJCLJ(int BHJAKHNNONP);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface KFHDNMBJPHG
{
	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool FELCDHIOPGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface CGCKJLGKJAC
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	ABMGIHGABKH JGANBMEAGAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	HCJAEIACLKI LIBCNODAHCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MNPDGEAJOMJ(Transform AFJHLFMCCIJ);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PACFMDOBOIO(Transform AFJHLFMCCIJ, PLKHJBLGPPN GLOFNMBDFMP);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BDPDBOBILAF(Transform AFJHLFMCCIJ, IAHLCGIKAIA KLJCIEFJLHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface OAPNIGACKKC
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface MNGLOECMIMI
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action MBGKEDDDGHO;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GCOFMOABPGI(DBDGEDGIEPP LCEFHPGMPLJ, bool LLMIJLANJMH);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface EONKCFLCKBC
{
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FIGFNDKLIPN();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface COGFBLHJKMJ
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDEDIMNMLPE CLEJPFLFBBI(GameObject AEHACDADEAN);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NAIGAFPLJFA(GameObject FNAHDAKHMJN, KBPHFEOEKMF FIEPPBOCNHM, BMDJAEPMNDM AIEAKKNMPDL);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DEIGOOPOKAN(AMOFBKBMFBA NACMAJFMJAJ, bool NKGLOFDAOKJ, float3 PDLMMGHHMEM, quaternion PMHPIFFOCGD);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LJPMHIBEEPI(DPCLFAJCHGB CAAMCMKANHA, DPCLFAJCHGB PABFDMCLKCE, EEMOMCJGFPH GNLDGJDNMDL);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DKOPCPKMEOA(DPCLFAJCHGB CAAMCMKANHA, EEMOMCJGFPH GNLDGJDNMDL);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NNPMPHABGKG(DBDGEDGIEPP NGGFHOBBAGK);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LBLCIKAMABG(DBDGEDGIEPP HPPPLLCFNKH, NativeArray<LocalPoseData> BCAPMMIJGKN, NativeArray<float3> NAMHPCOOCOD);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FCDPACNOBHK(DBDGEDGIEPP HPPPLLCFNKH, DBDGEDGIEPP BKJGJEDLGLM);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HDLFIPMJCKD(DBDGEDGIEPP HPPPLLCFNKH, bool DANEPCLGEPF);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LOLKAMOKJLG(DBDGEDGIEPP HPPPLLCFNKH, bool IALGEGBNEJI);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct CPJABKOGGCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly PNGLAMAOFOG IJNJPAGKLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly PNGLAMAOFOG ENJFDDOBAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly uint KEPDLHMBJEK;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6B06770", Offset = "0x6B04D70", VA = "0x186B06770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct LOGPIOHOIFA
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly PBGLEKOCCEM APPJEAMJBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly CPJABKOGGCJ PEMICEIPPPL;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6B11A30", Offset = "0x6B10030", VA = "0x186B11A30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct PCOFCPMNMNN
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static readonly PBGLEKOCCEM APPJEAMJBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal readonly CPJABKOGGCJ PEMICEIPPPL;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6B11A30", Offset = "0x6B10030", VA = "0x186B11A30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct JJAFAJMANOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal readonly uint KEPDLHMBJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal readonly bool EMLMHEEBKKP;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6B0ED30", Offset = "0x6B0D330", VA = "0x186B0ED30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct PNGLAMAOFOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal int GCMGLJCEDLO;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6B16880", Offset = "0x6B14E80", VA = "0x186B16880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface GBGOBCGDBEK
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	KHEAKBCINAF FMDIBFFIJMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum HGHHJHHMPLG
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Legacy,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Embodied,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Disembodying,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Disembodied
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface AEBAKOEFOMI : DDOOANPILLG
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	HGHHJHHMPLG HLCGNMAFFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool ABGMADJNCDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GameObject FNAHDAKHMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<AEBAKOEFOMI> DGICDFHJLBI;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(JBDAPNANMGI DBIMBFMCJCE, AMOFBKBMFBA PMPEHAMBEGA);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool EJMJKMMJAHP);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class KLPEOOABKNJ
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6B0FFA0", Offset = "0x6B0E5A0", VA = "0x186B0FFA0")]
	public static bool OELJLGGEPFD(this AEBAKOEFOMI EIOMIFFNBNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6B0FF50", Offset = "0x6B0E550", VA = "0x186B0FF50")]
	public static bool FMOKBBPOPIN(this AEBAKOEFOMI EIOMIFFNBNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6B0FE70", Offset = "0x6B0E470", VA = "0x186B0FE70")]
	public static bool ACLOLCFCECL(this AEBAKOEFOMI EIOMIFFNBNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6B0FEC0", Offset = "0x6B0E4C0", VA = "0x186B0FEC0")]
	public static bool DBIJCBPOGNN(this AEBAKOEFOMI EIOMIFFNBNG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface DDOOANPILLG
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool BGBBMOLNFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	AMOFBKBMFBA IMKGIBCHBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
internal interface CGGPBOKGKCM
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<ONPCMLCFACA> OCPFEJHEFOM;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface DOLKEIBNFFG
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHKIKJFBAIM(Vector3 MCPNOOFMAHG, Quaternion GLKHDAMNPBA, Vector3 ICLEOPHCOMM);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GOPGAHCPBFG(AMOFBKBMFBA PPEEAFEPIIK);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ONLJLEDNNHO(bool HEAAHHCNICB);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MNPGMDFPKLN(bool IALGEGBNEJI);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface DJBDAFKKPIP
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface ANGOHJGLEOD
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(DKAMHPILGME AAOIHHIBJIO);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface DKAMHPILGME
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	GameObject FNAHDAKHMJN
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	Transform AFJHLFMCCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	NEDLHIMBFHA DIGHLOCDNIK
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool OMMFIJCLBKD
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FAMPOBKBLMM(NEDLHIMBFHA AKLCDEBLEOF);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface NEDLHIMBFHA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	AMOFBKBMFBA IMKGIBCHBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	Rigidbody JIDGAHELAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	DKAMHPILGME BHKCNGCONEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	GameObject HJMFHICNFLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Transform BIPGCHCOEKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	NEDLHIMBFHA GPPJHNPGLJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	NEDLHIMBFHA DBCKFKNELBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	int LPNPPNCGIEH
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool EPBKCECLMGI
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool FGJHMHFFMPP
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	NGDDLDGNNPG EKGEDOLJCMB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "31")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	NDGEFNLJMAC IADAJOGNIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	float LFEBMBIHGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "35")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 OICLGKNAKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 APKPAJFJKMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	Vector3 OMBMCOIBKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 KIEFOPGJEPG
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool LOCFOHBDCPC
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool LFLLFNIGFFC
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	bool IGFMPAHDGNF
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 ECNEOFFOJHK
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 CIAHPNLACKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 MKIELKNCOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "50")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Vector3 GJPCPFIMBJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	float BFOPBBLOEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	float PLPACLCBEMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	Vector3 BONJCBHHMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Quaternion DCHJEMEHJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	float MCKCDBHOEJF
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	float AHICHIOPFFN
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	bool MNNEEEAOEBM
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	IBJOHPGNLAO HNGJCFHGNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool FGABCNCEAKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Transform HDNBEKMOJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 CNDGMBBGEON
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float BMIGAHHGIOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	float JNBNNNNEDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Quaternion ICHHJMIFMKB
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 AFDJHIPPHGC
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Quaternion JGMGNPPDNFI
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	RigidbodyConstraints GPNINJJAFBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool ECMCFIPLAIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	CollisionDetectionMode FAGPOIEBDIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool HKHDCKOACIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event DODFEPBDCAA CKDHEMDMHGM;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event DODFEPBDCAA FMNPNFLKHGO;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event DODFEPBDCAA NCHLAJEIDLG;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event DODFEPBDCAA PGIMLAKJANJ;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event DODFEPBDCAA BAKMEOLKDHL;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event DODFEPBDCAA MNNBDDKFMBD;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event DODFEPBDCAA PHPNCGGJCDA;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event EMMBFAHGHHH FIGMEEFEPGN;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<JCHEPGBFHGG, JCHEPGBFHGG> ICLOABOBCFK;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	NEDLHIMBFHA HOPIJKGEJHM(int PDMMEDBMFPP);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void JBAAJHJFDLH((Quaternion rot, Vector3 moments) IIIBFELFAJH);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void NDMDMOBKCMD();

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void GNBLJPCGDJG();

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void KGKMGBPFLPH();

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void KGGOJEGNFAM();

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void GOPGAHCPBFG(NEDLHIMBFHA DMNGPNKHPKF, bool ILHLBOIBFME = false);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void IINDOLNHFEK(object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void PIBPPGOMCPM(object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 FKIDMCMFECG(Vector3 AFHHNEMELLI);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "95")]
	Vector3 GFGIFPFOEJI(Vector3 DEOFHMCEHDL);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void IOAEOFFBJDL();

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void FCNIJEHAHAA();

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void INDAIBOJKJH();

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void MEPAMPPEPAB(Vector3 ILPBCAOFHFC, Vector3 BNCHFJNCMAC);

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void LEHHKNIFKIO(Vector3 BGGFFMNEHLJ, Vector3 FMJPBBNAKNO);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void PBKOFMIKDPP(Vector3 FGIOIHCCMGD);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void PBBOHBCIODG(BGCGFDEOGGE NCBLBBPMLOJ, Vector3 DKAPEBBIDMB, float KEAADBCIBNM, float KAJOLOCGJBD = 8f, float EOMIAHCPFMP = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void KKKPDELJAFB(LOONDOIDMJL ACLHBCPAOJF, Vector3 NPEDGDPAGMP, float OJAJPGIKPFI = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void GHOADAOFGPJ(LOONDOIDMJL ACLHBCPAOJF, Vector3 GLKHDAMNPBA, float JCENBACKGJB = 7f, float OMOGOJBEKDL = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "105")]
	Vector3 OAKNDJIBJPF(Vector3 DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "106")]
	Vector3 PNDHLPJJNED(Vector3 DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void JAMHHKKJPLH();

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void LPNDDLMKLAJ(NEDLHIMBFHA BJMEMMNCKAM, object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "109")]
	void KCDMMALODBE(object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void IEFFBHIPMGI();

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void MEDPKKHGJNI();

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void CHIKINPOCCE();

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "113")]
	bool FNHNLLGKJFJ();

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void PJCEGLNOPJJ();

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void ENNODFFCPIE(object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "116")]
	void NGLKGJIFNHM(object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void IDBNMGDDKDI(object NJLOKHEKBBE, bool JJAGHLCDGON);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void MJIMNGPEBBJ(Vector3 BMIACJNKBNO, Quaternion NBMPFMOAJDD);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void HJFOIKLCHHN(Vector3 HKPHFAKOJNH, Quaternion FMACAJCCHFH);

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "120")]
	bool IGOMLAHJKFG(float FEMHAGNJCKL);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void LPKNGANHBFN(object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void PJLPHAKEAPK(object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void MDCGELNKCEI(object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void AHFBOIOGAJP(object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void HMDNLCNGJGB(Vector3 LCIFANAPNML, ForceMode MEKJDPKKBKK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void BJLBNHFKMFJ(Vector3 LCIFANAPNML, Vector3 MCPNOOFMAHG, ForceMode MEKJDPKKBKK);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void OEFJHMAJKGO(Vector3 IGNIGENLOEO, ForceMode MEKJDPKKBKK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void LHHMNHFNFJN(Vector3 IGNIGENLOEO, ForceMode MEKJDPKKBKK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "129")]
	bool OOEAELNAIFD(Vector3 GKDEFPHJFPJ, [Out] RaycastHit HBCOBNFHLDN, float KPAPKDHNJLJ);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void HCLMGPGOGHO();
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface NDGEFNLJMAC
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJFIFAGBCEJ(Vector3 GGAKKEPMENP);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PCOAICPOGDI(Vector3 CDGJDANICCD);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NHKKJEGKPMC(Vector3 GGAKKEPMENP);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EJBIBLDJHMN(Vector3 CDGJDANICCD);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface NGDDLDGNNPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 IAFBJDCFIMB();

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 ELOLHMHMIDM();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public delegate void DODFEPBDCAA(DKAMHPILGME LNDNCEECHJC);
[Cpp2IlInjected.Token(Token = "0x2000040")]
public enum IBEHNNGAOAO
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	ChildAdded,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	ChildRemoved,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	ParentChanged,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	HierarchyMassUpdated,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	SleepChanged,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	DistanceBandChanged,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	IsKinematicChanged,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Discontinuity,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Destroyed,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum BGCGFDEOGGE
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Reflective,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	FullOverride
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public delegate void EMMBFAHGHHH(DKAMHPILGME LNDNCEECHJC, bool ILHLBOIBFME = false);
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum LOONDOIDMJL
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct OGPNDBNBFDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Rigidbody GEAHMGKGGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public object OOONIGNCAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector3 ALIDCNJFNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector3 JMBLMEINHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public JLMNFBGGGIJ DDPEKAFJBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool BHJHEPPHEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool DNKMIKBANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool PEDLCDOHEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool MOCBBILCAAI;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface HCFNAONHOIP : BILJGDPFLDH<KJCIFKAMOBH>, MHOGBINFLBI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface NEPLLEPFBIA<T> : JDBPBADKJGK<KJCIFKAMOBH, T>, BILJGDPFLDH<KJCIFKAMOBH>, MHOGBINFLBI, IDisposable, HCFNAONHOIP where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class GGGPNHMKPMH
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x2B95AA0", Offset = "0x2B940A0", VA = "0x182B95AA0")]
	public static bool EGCGJKFAAFH<T>(this BILJGDPFLDH<KJCIFKAMOBH> FDKAIMCLOIA, KJCIFKAMOBH FAOMEEFLJBM, [Out] T DMNGPNKHPKF) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x2B95A70", Offset = "0x2B94070", VA = "0x182B95A70")]
	public static bool ECADPABFBJL<T>(this BILJGDPFLDH<KJCIFKAMOBH> FDKAIMCLOIA, KJCIFKAMOBH FAOMEEFLJBM, [In] T PIMFKGJDDND) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface HCFBPDIOPOA : BILJGDPFLDH<AMOFBKBMFBA>, MHOGBINFLBI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface LLCOHDGDCHM<T> : JDBPBADKJGK<AMOFBKBMFBA, T>, BILJGDPFLDH<AMOFBKBMFBA>, MHOGBINFLBI, IDisposable, HCFBPDIOPOA where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class PJOMBPFJAND
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2931280", Offset = "0x292F880", VA = "0x182931280")]
	public static T FOHHCFMHKPE<T>(this BILJGDPFLDH<AMOFBKBMFBA> FDKAIMCLOIA, AMOFBKBMFBA NACMAJFMJAJ) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x2B95A70", Offset = "0x2B94070", VA = "0x182B95A70")]
	public static bool ECADPABFBJL<T>(this BILJGDPFLDH<AMOFBKBMFBA> FDKAIMCLOIA, AMOFBKBMFBA NACMAJFMJAJ, [In] T PIMFKGJDDND) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct DANIGNOCLDL : IComparable<DANIGNOCLDL>, IEquatable<DANIGNOCLDL>
{
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly DANIGNOCLDL NGHCGFLIPPC;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly DANIGNOCLDL INLGLCBOJDN;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly DANIGNOCLDL JBKJLFCBCDM;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly DANIGNOCLDL BIIJACHLCGM;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly DANIGNOCLDL NGJBMICOPBK;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly DANIGNOCLDL JBCKLOBENII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public int MIMJDCDEIKK;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool MINFFBDDFGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6B06E50", Offset = "0x6B05450", VA = "0x186B06E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public int DDOFIGBIAPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6B06E40", Offset = "0x6B05440", VA = "0x186B06E40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0xAAF690", Offset = "0xAADC90", VA = "0x180AAF690")]
	public DANIGNOCLDL(int PDMMEDBMFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6B06EF0", Offset = "0x6B054F0", VA = "0x186B06EF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6B06E60", Offset = "0x6B05460", VA = "0x186B06E60", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0xA44B60", Offset = "0xA43160", VA = "0x180A44B60", Slot = "5")]
	public bool Equals(DANIGNOCLDL BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x1ADD5E0", Offset = "0x1ADBBE0", VA = "0x181ADD5E0", Slot = "4")]
	public int CompareTo(DANIGNOCLDL BHFGHGMPKOJ)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0xE29C50", Offset = "0xE28250", VA = "0x180E29C50")]
	public static DANIGNOCLDL HDKGBCFDEBL(int PDMMEDBMFPP)
	{
		return default(DANIGNOCLDL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0xE29C50", Offset = "0xE28250", VA = "0x180E29C50")]
	public static int HDKGBCFDEBL(DANIGNOCLDL KKEFBAKIJFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6B06F50", Offset = "0x6B05550", VA = "0x186B06F50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct DPCLFAJCHGB : IEquatable<DPCLFAJCHGB>, DDOOANPILLG
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly DPCLFAJCHGB FHJCFPMPMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public AMOFBKBMFBA IMKGIBCHBKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830", Slot = "6")]
		get
		{
			return default(AMOFBKBMFBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public DIGCCNOHOGM BIPGCHCOEKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DIGCCNOHOGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public GPMMLOLMFPA DNOCCFDMNNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(GPMMLOLMFPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private CPNHAFLLNGA ECBIJNMIEJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6B03190", Offset = "0x6B01790", VA = "0x186B03190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public GameObject FNAHDAKHMJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6B0A220", Offset = "0x6B08820", VA = "0x186B0A220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public KJCIFKAMOBH LAFNCNDABHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6B09DD0", Offset = "0x6B083D0", VA = "0x186B09DD0")]
		get
		{
			return default(KJCIFKAMOBH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public IDMJFGHFBNP JKNELMAPDMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6B0A3F0", Offset = "0x6B089F0", VA = "0x186B0A3F0")]
		get
		{
			return default(IDMJFGHFBNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public IDEDIMNMLPE BFHJBMJKHKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6B0A130", Offset = "0x6B08730", VA = "0x186B0A130")]
		get
		{
			return default(IDEDIMNMLPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool CIBNKLALJPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6B0A620", Offset = "0x6B08C20", VA = "0x186B0A620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool GHJAEJEKFGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6B0A110", Offset = "0x6B08710", VA = "0x186B0A110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool EIMMFDMKDAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6B0A560", Offset = "0x6B08B60", VA = "0x186B0A560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool CKNFLKMHFIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6B0A060", Offset = "0x6B08660", VA = "0x186B0A060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool BADKJGKDFLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6B09D70", Offset = "0x6B08370", VA = "0x186B09D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool LOLNBHOEMFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6B09E70", Offset = "0x6B08470", VA = "0x186B09E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool DBILOMONELF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6B0A0D0", Offset = "0x6B086D0", VA = "0x186B0A0D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool JIBNKBPJHGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6B09D90", Offset = "0x6B08390", VA = "0x186B09D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool CFAMPGEBLMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6B0A200", Offset = "0x6B08800", VA = "0x186B0A200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public PBMOGAIKDEO PELODICEEPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(PBMOGAIKDEO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public PMMDAKLGKNO MEMDCKPIKPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(PMMDAKLGKNO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public NENMIGHJDLP JEFEILNBDOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(NENMIGHJDLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public LDMBCDKEMEA MBLHCEOJNOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(LDMBCDKEMEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public JDBNMFAHHAD HCLLCODBMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(JDBNMFAHHAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public OKOKCJGECAJ IGCLNKJCJPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(OKOKCJGECAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public OGCILGNGNIE FMMEKIEJFMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(OGCILGNGNIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public AHGAGDPCIGE KKLHFKCFEBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(AHGAGDPCIGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public MFIAKKHGGJF GPJHMNPDOJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(MFIAKKHGGJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public AEFHCLANFOH GGGHFDKGBGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(AEFHCLANFOH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public LGJOAPJJEKE LHFIJPLKLOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(LGJOAPJJEKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public IHFNFMNOCEJ FLALCPDLABJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(IHFNFMNOCEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool OELJLGGEPFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6B09F60", Offset = "0x6B08560", VA = "0x186B09F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool KBBJHMELJPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6B09E90", Offset = "0x6B08490", VA = "0x186B09E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool MBOHOGAMIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6B0A3B0", Offset = "0x6B089B0", VA = "0x186B0A3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	private bool AOMDHBBOHJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
	public DPCLFAJCHGB(AMOFBKBMFBA NACMAJFMJAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A0B0", Offset = "0x6B086B0", VA = "0x186B0A0B0")]
	public static bool HDKGBCFDEBL(DPCLFAJCHGB DMNGPNKHPKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
	public static AMOFBKBMFBA HDKGBCFDEBL(DPCLFAJCHGB DMNGPNKHPKF)
	{
		return default(AMOFBKBMFBA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A050", Offset = "0x6B08650", VA = "0x186B0A050")]
	public static bool FFOLOHFBIHN(DPCLFAJCHGB KHKPJFABMKM, DPCLFAJCHGB CGBLKAAFCDI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6B05460", Offset = "0x6B03A60", VA = "0x186B05460")]
	public static bool NKEIKPOPFDO(DPCLFAJCHGB KHKPJFABMKM, DPCLFAJCHGB CGBLKAAFCDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x6B09ED0", Offset = "0x6B084D0", VA = "0x186B09ED0", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(DPCLFAJCHGB BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
	public static DPCLFAJCHGB HDKGBCFDEBL(AMOFBKBMFBA OOLEDFCEFHP)
	{
		return default(DPCLFAJCHGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A490", Offset = "0x6B08A90", VA = "0x186B0A490")]
	public PGHJEKIIAPM NEKCEHGMEMK()
	{
		return default(PGHJEKIIAPM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A080", Offset = "0x6B08680", VA = "0x186B0A080")]
	public JEPMDIABGDP FJMMCNGJEDD()
	{
		return default(JEPMDIABGDP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A510", Offset = "0x6B08B10", VA = "0x186B0A510")]
	public KBNENCAOFHA NJDIJCPNBNI()
	{
		return default(KBNENCAOFHA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A1D0", Offset = "0x6B087D0", VA = "0x186B0A1D0")]
	public JNEDNEFABHG JOFKGODADLA()
	{
		return default(JNEDNEFABHG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A580", Offset = "0x6B08B80", VA = "0x186B0A580")]
	public void OEOLFDEOGBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A640", Offset = "0x6B08C40", VA = "0x186B0A640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct OGCILGNGNIE : IEquatable<OGCILGNGNIE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public AMOFBKBMFBA IMKGIBCHBKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(AMOFBKBMFBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private CPNHAFLLNGA ECBIJNMIEJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6B03190", Offset = "0x6B01790", VA = "0x186B03190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private AJEIHOPLKOK MDMIEEDKOGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6B13110", Offset = "0x6B11710", VA = "0x186B13110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private ILJDADPJOGB NGHJHMMJDCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6B13630", Offset = "0x6B11C30", VA = "0x186B13630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool MBHCCNIPJAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6B137B0", Offset = "0x6B11DB0", VA = "0x186B137B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Guid FHJFMOPJJKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6B12FF0", Offset = "0x6B115F0", VA = "0x186B12FF0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool PNLODANGOJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6B135A0", Offset = "0x6B11BA0", VA = "0x186B135A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public Guid ONOBLOEDEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6B133F0", Offset = "0x6B119F0", VA = "0x186B133F0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
	public OGCILGNGNIE(AMOFBKBMFBA NACMAJFMJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6B131A0", Offset = "0x6B117A0", VA = "0x186B131A0", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(OGCILGNGNIE BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6B13350", Offset = "0x6B11950", VA = "0x186B13350")]
	public bool HIMMGFHIBNN([Out] Guid EHLNCLBLNMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6B13690", Offset = "0x6B11C90", VA = "0x186B13690")]
	public void KLNCFMDONCD(Guid KPJDKHEOHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6B13840", Offset = "0x6B11E40", VA = "0x186B13840")]
	public bool PLJFFBHKNJA([Out] Guid CNJMIDDPAFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6B13230", Offset = "0x6B11830", VA = "0x186B13230")]
	public void FFMJMMGOCJP(Guid KPJDKHEOHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6B13510", Offset = "0x6B11B10", VA = "0x186B13510")]
	public void ILPIKAIDKJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct KBNENCAOFHA : IEquatable<KBNENCAOFHA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public AMOFBKBMFBA IMKGIBCHBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(AMOFBKBMFBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private CPNHAFLLNGA ECBIJNMIEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6B03190", Offset = "0x6B01790", VA = "0x186B03190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private AJEIHOPLKOK MDMIEEDKOGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F510", Offset = "0x6B0DB10", VA = "0x186B0F510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private IKDKABNIMCK GDKPNLADMBO
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F780", Offset = "0x6B0DD80", VA = "0x186B0F780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 KEOONJNPAIH
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6B0FA30", Offset = "0x6B0E030", VA = "0x186B0FA30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public Quaternion LNPJJAFDICC
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6B0FB80", Offset = "0x6B0E180", VA = "0x186B0FB80")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public DPCLFAJCHGB CAKCJHDDBLD
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F7E0", Offset = "0x6B0DDE0", VA = "0x186B0F7E0")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
	public KBNENCAOFHA(AMOFBKBMFBA NACMAJFMJAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A0B0", Offset = "0x6B086B0", VA = "0x186B0A0B0")]
	public static bool HDKGBCFDEBL(KBNENCAOFHA DMNGPNKHPKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
	public static AMOFBKBMFBA HDKGBCFDEBL(KBNENCAOFHA DMNGPNKHPKF)
	{
		return default(AMOFBKBMFBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6B0F5A0", Offset = "0x6B0DBA0", VA = "0x186B0F5A0", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(KBNENCAOFHA BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6B0F630", Offset = "0x6B0DC30", VA = "0x186B0F630")]
	public void KONGJCNAHDD(Vector3 MCPNOOFMAHG, Quaternion GLKHDAMNPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x6B0FCD0", Offset = "0x6B0E2D0", VA = "0x186B0FCD0")]
	public void PHPILIINBEG(float ICLEOPHCOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6B0F870", Offset = "0x6B0DE70", VA = "0x186B0F870")]
	public void NCMOFOOHHGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct PGHJEKIIAPM : IEquatable<PGHJEKIIAPM>
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly PGHJEKIIAPM FHJCFPMPMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public AMOFBKBMFBA IMKGIBCHBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(AMOFBKBMFBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public DIGCCNOHOGM BIPGCHCOEKG
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DIGCCNOHOGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public GPMMLOLMFPA DNOCCFDMNNN
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(GPMMLOLMFPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private CPNHAFLLNGA ECBIJNMIEJE
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6B03190", Offset = "0x6B01790", VA = "0x186B03190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private AJEIHOPLKOK MDMIEEDKOGE
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6B14D60", Offset = "0x6B13360", VA = "0x186B14D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private IOCMEJKKNBE AHNONAHHNFI
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x6B14B00", Offset = "0x6B13100", VA = "0x186B14B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public DBDGEDGIEPP LKHPOLFPDHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6B15C10", Offset = "0x6B14210", VA = "0x186B15C10")]
		get
		{
			return default(DBDGEDGIEPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public IEnumerable<DPCLFAJCHGB> ANLODCJNAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6B148F0", Offset = "0x6B12EF0", VA = "0x186B148F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public IEnumerable<DPCLFAJCHGB> AOPFJDBOPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6B14E80", Offset = "0x6B13480", VA = "0x186B14E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public int LPNPPNCGIEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6B16250", Offset = "0x6B14850", VA = "0x186B16250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public int OEOPMLEJGPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6B16200", Offset = "0x6B14800", VA = "0x186B16200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public string OABCLOFHIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x6B15AF0", Offset = "0x6B140F0", VA = "0x186B15AF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6B159D0", Offset = "0x6B13FD0", VA = "0x186B159D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public IHPNPIHEBNC PFCELOIMNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6B15280", Offset = "0x6B13880", VA = "0x186B15280")]
		get
		{
			return default(IHPNPIHEBNC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x6B14B60", Offset = "0x6B13160", VA = "0x186B14B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public FGHMMODCMKP NAAPICGNOGK
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6B15340", Offset = "0x6B13940", VA = "0x186B15340")]
		get
		{
			return default(FGHMMODCMKP);
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6B16120", Offset = "0x6B14720", VA = "0x186B16120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public GPBBMBGGIFB GOADPMFELAG
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6B14D00", Offset = "0x6B13300", VA = "0x186B14D00")]
		get
		{
			return default(GPBBMBGGIFB);
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6B15CD0", Offset = "0x6B142D0", VA = "0x186B15CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public float FMCNPAEDLBO
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x6B15220", Offset = "0x6B13820", VA = "0x186B15220")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x6B153A0", Offset = "0x6B139A0", VA = "0x186B153A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool JMOBEPODPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x6B14C30", Offset = "0x6B13230", VA = "0x186B14C30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x6B15BA0", Offset = "0x6B141A0", VA = "0x186B15BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool PMIFPDMMIEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6B15010", Offset = "0x6B13610", VA = "0x186B15010")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6B162E0", Offset = "0x6B148E0", VA = "0x186B162E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool CICGCADGAHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6B14BD0", Offset = "0x6B131D0", VA = "0x186B14BD0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x6B15A80", Offset = "0x6B14080", VA = "0x186B15A80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool LHGGBHFHDAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6B14820", Offset = "0x6B12E20", VA = "0x186B14820")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6B16190", Offset = "0x6B14790", VA = "0x186B16190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool DMEADJHCLGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6B152E0", Offset = "0x6B138E0", VA = "0x186B152E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6B14880", Offset = "0x6B12E80", VA = "0x186B14880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool EAEBNCLLKON
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6B14FB0", Offset = "0x6B135B0", VA = "0x186B14FB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6B15D40", Offset = "0x6B14340", VA = "0x186B15D40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
	public PGHJEKIIAPM(AMOFBKBMFBA NACMAJFMJAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A0B0", Offset = "0x6B086B0", VA = "0x186B0A0B0")]
	public static bool HDKGBCFDEBL(PGHJEKIIAPM DMNGPNKHPKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A050", Offset = "0x6B08650", VA = "0x186B0A050")]
	public static bool FFOLOHFBIHN(PGHJEKIIAPM KHKPJFABMKM, PGHJEKIIAPM CGBLKAAFCDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6B14DF0", Offset = "0x6B133F0", VA = "0x186B14DF0", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(PGHJEKIIAPM BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
	public static DPCLFAJCHGB HDKGBCFDEBL(PGHJEKIIAPM HLIDMKMINHN)
	{
		return default(DPCLFAJCHGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6B14AE0", Offset = "0x6B130E0", VA = "0x186B14AE0")]
	public bool BLBDBJABNAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6B14C90", Offset = "0x6B13290", VA = "0x186B14C90")]
	public bool ELNABFDGBMD(DGLLELHCEGN CCKLIGPOGCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6B14A60", Offset = "0x6B13060", VA = "0x186B14A60")]
	public void BHFHAPMOCFC(DGLLELHCEGN CCKLIGPOGCO, bool DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6B15070", Offset = "0x6B13670", VA = "0x186B15070")]
	public DBDGEDGIEPP GFGGPGBMJIN(Allocator KOIILCBLJPK)
	{
		return default(DBDGEDGIEPP);
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6B15DB0", Offset = "0x6B143B0", VA = "0x186B15DB0")]
	public void NNFCFELLBFM(PGHJEKIIAPM BHFGHGMPKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6B15410", Offset = "0x6B13A10", VA = "0x186B15410")]
	public void IHMDABCLFBN(List<DPCLFAJCHGB> GFJDFHOKGGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct BLFNJGIDCNB : IEquatable<BLFNJGIDCNB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6B05C80", Offset = "0x6B04280", VA = "0x186B05C80", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(BLFNJGIDCNB BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct PMMDAKLGKNO : IEquatable<PMMDAKLGKNO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private CPNHAFLLNGA ECBIJNMIEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x6B03190", Offset = "0x6B01790", VA = "0x186B03190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
	public PMMDAKLGKNO(AMOFBKBMFBA NACMAJFMJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6B16610", Offset = "0x6B14C10", VA = "0x186B16610", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(PMMDAKLGKNO BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6B166A0", Offset = "0x6B14CA0", VA = "0x186B166A0")]
	public void IHOPKBJIMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6B16740", Offset = "0x6B14D40", VA = "0x186B16740")]
	public void NGCIFCPJEJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6B167E0", Offset = "0x6B14DE0", VA = "0x186B167E0")]
	public bool PBIDENGNGJO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct GPMMLOLMFPA : IEquatable<GPMMLOLMFPA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public AMOFBKBMFBA IMKGIBCHBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(AMOFBKBMFBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private CPNHAFLLNGA ECBIJNMIEJE
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6B03190", Offset = "0x6B01790", VA = "0x186B03190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	private AJEIHOPLKOK MDMIEEDKOGE
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C020", Offset = "0x6B0A620", VA = "0x186B0C020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private IOCMEJKKNBE AHNONAHHNFI
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6B0BFC0", Offset = "0x6B0A5C0", VA = "0x186B0BFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public AMOFBKBMFBA GAKAJPCMOPA
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6B0BCA0", Offset = "0x6B0A2A0", VA = "0x186B0BCA0")]
		get
		{
			return default(AMOFBKBMFBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public DPCLFAJCHGB GPPJHNPGLJE
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C5B0", Offset = "0x6B0ABB0", VA = "0x186B0C5B0")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public DPCLFAJCHGB DBCKFKNELBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C520", Offset = "0x6B0AB20", VA = "0x186B0C520")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
	public GPMMLOLMFPA(AMOFBKBMFBA NACMAJFMJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6B0C0B0", Offset = "0x6B0A6B0", VA = "0x186B0C0B0", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(GPMMLOLMFPA BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6B0C140", Offset = "0x6B0A740", VA = "0x186B0C140")]
	public bool GOPGAHCPBFG(DPCLFAJCHGB PPEEAFEPIIK, bool LEMLBFMKMGA = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6B0C480", Offset = "0x6B0AA80", VA = "0x186B0C480")]
	public bool IIPJHALOFGL(DPCLFAJCHGB JGNLPHMJMEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6B0BD30", Offset = "0x6B0A330", VA = "0x186B0BD30")]
	private void BNOHDGLCBLP(DPCLFAJCHGB CNADACLIIAB, List<DPCLFAJCHGB> LALLCGEGIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x6B0C3F0", Offset = "0x6B0A9F0", VA = "0x186B0C3F0")]
	public PGHJEKIIAPM IHBLBPCDPEI()
	{
		return default(PGHJEKIIAPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6B0C390", Offset = "0x6B0A990", VA = "0x186B0C390")]
	public void IABNHMOLDHP(List<DPCLFAJCHGB> NECJNNCJFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6B0C270", Offset = "0x6B0A870", VA = "0x186B0C270")]
	public NativeArray<AMOFBKBMFBA> HPABBGCPPNB()
	{
		return default(NativeArray<AMOFBKBMFBA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct PBMOGAIKDEO : IEquatable<PBMOGAIKDEO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public string MFMHHDGDGKK
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6B145D0", Offset = "0x6B12BD0", VA = "0x186B145D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public string MELJPHPMFOC
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6B14380", Offset = "0x6B12980", VA = "0x186B14380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private bool NDJDFKPILFB
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6B14650", Offset = "0x6B12C50", VA = "0x186B14650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public string KNMDKIOBIDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6B14290", Offset = "0x6B12890", VA = "0x186B14290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public string GBBPPBBFOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6B14040", Offset = "0x6B12640", VA = "0x186B14040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public string KHLIJBKBMDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6B14450", Offset = "0x6B12A50", VA = "0x186B14450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
	public PBMOGAIKDEO(AMOFBKBMFBA NACMAJFMJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6B14540", Offset = "0x6B12B40", VA = "0x186B14540", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(PBMOGAIKDEO BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct LGJOAPJJEKE : IEquatable<LGJOAPJJEKE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private CPNHAFLLNGA ECBIJNMIEJE
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6B03190", Offset = "0x6B01790", VA = "0x186B03190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private AJEIHOPLKOK MDMIEEDKOGE
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6B11270", Offset = "0x6B0F870", VA = "0x186B11270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private OINAKNKLDHL OKCGMDFIGNO
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6B11490", Offset = "0x6B0FA90", VA = "0x186B11490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public ODKKPIAMDKH FEADBOFFOLP
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6B11300", Offset = "0x6B0F900", VA = "0x186B11300")]
		get
		{
			return default(ODKKPIAMDKH);
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6B11630", Offset = "0x6B0FC30", VA = "0x186B11630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public bool EJLKFNDBMLD
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6B11870", Offset = "0x6B0FE70", VA = "0x186B11870")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6B11590", Offset = "0x6B0FB90", VA = "0x186B11590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public string[] BFECBNHHDDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6B119A0", Offset = "0x6B0FFA0", VA = "0x186B119A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6B11010", Offset = "0x6B0F610", VA = "0x186B11010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public string[] PJGHMKOPNBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6B111E0", Offset = "0x6B0F7E0", VA = "0x186B111E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6B11140", Offset = "0x6B0F740", VA = "0x186B11140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public string[] DPFOJLBGJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6B117E0", Offset = "0x6B0FDE0", VA = "0x186B117E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6B11740", Offset = "0x6B0FD40", VA = "0x186B11740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public string[] ANCAALOHGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6B110B0", Offset = "0x6B0F6B0", VA = "0x186B110B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6B11900", Offset = "0x6B0FF00", VA = "0x186B11900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
	public LGJOAPJJEKE(AMOFBKBMFBA NACMAJFMJAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
	public static AMOFBKBMFBA HDKGBCFDEBL(LGJOAPJJEKE DMNGPNKHPKF)
	{
		return default(AMOFBKBMFBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x6B11400", Offset = "0x6B0FA00", VA = "0x186B11400", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(LGJOAPJJEKE BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6B114F0", Offset = "0x6B0FAF0", VA = "0x186B114F0")]
	public bool KNABAFINFHB(AMOFBKBMFBA AKBLJHNIFIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct KFHNAOKIMAI : IEquatable<KFHNAOKIMAI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6B0FDE0", Offset = "0x6B0E3E0", VA = "0x186B0FDE0", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(KFHNAOKIMAI BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct NENMIGHJDLP : IEquatable<NENMIGHJDLP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
	public NENMIGHJDLP(AMOFBKBMFBA NACMAJFMJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6B12CE0", Offset = "0x6B112E0", VA = "0x186B12CE0", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(NENMIGHJDLP BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6B12D70", Offset = "0x6B11370", VA = "0x186B12D70")]
	public bool FCDHPBIHMEM([Out] Collider LHLDOGJGFAN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct JNEDNEFABHG : IEquatable<JNEDNEFABHG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public AMOFBKBMFBA IMKGIBCHBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(AMOFBKBMFBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private MakerPenHeldDataWrapper PKHHAGFFAAF
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F3B0", Offset = "0x6B0D9B0", VA = "0x186B0F3B0")]
		get
		{
			return default(MakerPenHeldDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public bool IHLPEMHLJIF
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F4A0", Offset = "0x6B0DAA0", VA = "0x186B0F4A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
	public JNEDNEFABHG(AMOFBKBMFBA NACMAJFMJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6B0F410", Offset = "0x6B0DA10", VA = "0x186B0F410", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(JNEDNEFABHG BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct MFIAKKHGGJF : IEquatable<MFIAKKHGGJF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public AMOFBKBMFBA IMKGIBCHBKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(AMOFBKBMFBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	private CPNHAFLLNGA ECBIJNMIEJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x6B03190", Offset = "0x6B01790", VA = "0x186B03190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	private AJEIHOPLKOK MDMIEEDKOGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6B11D90", Offset = "0x6B10390", VA = "0x186B11D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private FDMODKPMNMC FJDAJCFDEEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6B11EB0", Offset = "0x6B104B0", VA = "0x186B11EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
	public MFIAKKHGGJF(AMOFBKBMFBA NACMAJFMJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6B11E20", Offset = "0x6B10420", VA = "0x186B11E20", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(MFIAKKHGGJF BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6B11CF0", Offset = "0x6B102F0", VA = "0x186B11CF0")]
	public void AHGPLJJKNKI(bool LLJCAELNPHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct LDMBCDKEMEA : IEquatable<LDMBCDKEMEA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public AMOFBKBMFBA IMKGIBCHBKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(AMOFBKBMFBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private CPNHAFLLNGA ECBIJNMIEJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x6B03190", Offset = "0x6B01790", VA = "0x186B03190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private AJEIHOPLKOK MDMIEEDKOGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x6B104A0", Offset = "0x6B0EAA0", VA = "0x186B104A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	private ObjectPolicyDataWrapper JKJHOMODGBN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x6B10FB0", Offset = "0x6B0F5B0", VA = "0x186B10FB0")]
		get
		{
			return default(ObjectPolicyDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private NavMeshGenerationDataWrapper HBEDADOAGHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x6B10A50", Offset = "0x6B0F050", VA = "0x186B10A50")]
		get
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public bool PADNINHOIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x6B10380", Offset = "0x6B0E980", VA = "0x186B10380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool APAPMBIKFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x6B10D40", Offset = "0x6B0F340", VA = "0x186B10D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool IEAPPGKMPPN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x6B10C00", Offset = "0x6B0F200", VA = "0x186B10C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool NCGPNGCAOEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x6B109E0", Offset = "0x6B0EFE0", VA = "0x186B109E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool PPNINMDGAAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x6B10740", Offset = "0x6B0ED40", VA = "0x186B10740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool ALKIJAHFJFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6B10B10", Offset = "0x6B0F110", VA = "0x186B10B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public bool DPOCFHEPJNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x6B0FFF0", Offset = "0x6B0E5F0", VA = "0x186B0FFF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public bool ELHHILBELDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x6B10E10", Offset = "0x6B0F410", VA = "0x186B10E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public bool PPHKGLDGNFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x6B10140", Offset = "0x6B0E740", VA = "0x186B10140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public bool OAEPHJBPBBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x6B105C0", Offset = "0x6B0EBC0", VA = "0x186B105C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public bool LMDPDBMGGGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x6B10CD0", Offset = "0x6B0F2D0", VA = "0x186B10CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool GENOIFNIJFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x6B10430", Offset = "0x6B0EA30", VA = "0x186B10430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool PCMPLOIDGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6B10AB0", Offset = "0x6B0F0B0", VA = "0x186B10AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool GNCBPPBDBCF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6B10F50", Offset = "0x6B0F550", VA = "0x186B10F50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6B107B0", Offset = "0x6B0EDB0", VA = "0x186B107B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public CHDPAPFDIPP KAJDPIIMMKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6B10C70", Offset = "0x6B0F270", VA = "0x186B10C70")]
		get
		{
			return default(CHDPAPFDIPP);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6B10060", Offset = "0x6B0E660", VA = "0x186B10060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool PCMFLBNBKDF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x6B101B0", Offset = "0x6B0E7B0", VA = "0x186B101B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public BMDJAEPMNDM GKPHEMHMMGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x6B10E80", Offset = "0x6B0F480", VA = "0x186B10E80")]
		get
		{
			return default(BMDJAEPMNDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool KBMHDOOLLHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6B10DB0", Offset = "0x6B0F3B0", VA = "0x186B10DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Vector3 BBBMIJJLAIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6B10920", Offset = "0x6B0EF20", VA = "0x186B10920")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Vector3 EENOAKIBJLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6B10630", Offset = "0x6B0EC30", VA = "0x186B10630")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public bool DKDGBDGIAFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6B10820", Offset = "0x6B0EE20", VA = "0x186B10820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
	public LDMBCDKEMEA(AMOFBKBMFBA NACMAJFMJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6B10530", Offset = "0x6B0EB30", VA = "0x186B10530", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(LDMBCDKEMEA BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x6B10EE0", Offset = "0x6B0F4E0", VA = "0x186B10EE0")]
	public bool OFLDKCBDEOI(EOEDKKLCHJF CCKLIGPOGCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x6B100D0", Offset = "0x6B0E6D0", VA = "0x186B100D0")]
	public bool CADKCHMFKHN(KBPHFEOEKMF CCKLIGPOGCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x6B10B80", Offset = "0x6B0F180", VA = "0x186B10B80")]
	public void KEBAIACLMEO(KBPHFEOEKMF CCKLIGPOGCO, bool AKKNAKBNOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x6B106E0", Offset = "0x6B0ECE0", VA = "0x186B106E0")]
	public KBPHFEOEKMF GELCPGHOLKC()
	{
		return default(KBPHFEOEKMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6B103C0", Offset = "0x6B0E9C0", VA = "0x186B103C0")]
	public bool EGANCLEJMEG(KBPHFEOEKMF DMNGPNKHPKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct AEFHCLANFOH : IEquatable<AEFHCLANFOH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	private CPNHAFLLNGA ECBIJNMIEJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x6B03190", Offset = "0x6B01790", VA = "0x186B03190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private AJEIHOPLKOK MDMIEEDKOGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x6B03030", Offset = "0x6B01630", VA = "0x186B03030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private OEEDEOGABKH OHCBOIECEGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6B03560", Offset = "0x6B01B60", VA = "0x186B03560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
	public AEFHCLANFOH(AMOFBKBMFBA NACMAJFMJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6B030D0", Offset = "0x6B016D0", VA = "0x186B030D0", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(AEFHCLANFOH BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x6B03300", Offset = "0x6B01900", VA = "0x186B03300")]
	public bool KPBOKNAKGPG(EEMOMCJGFPH GNLDGJDNMDL, List<DPCLFAJCHGB> GFJDFHOKGGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6B02F20", Offset = "0x6B01520", VA = "0x186B02F20")]
	public int ELONEIBBHFM(EEMOMCJGFPH GNLDGJDNMDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6B031F0", Offset = "0x6B017F0", VA = "0x186B031F0")]
	public void KGGGNFPLILP(List<DPCLFAJCHGB> GFJDFHOKGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x6B03430", Offset = "0x6B01A30", VA = "0x186B03430")]
	public int LFCMAHLPLCN(DPCLFAJCHGB PABFDMCLKCE, EEMOMCJGFPH GNLDGJDNMDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6B036D0", Offset = "0x6B01CD0", VA = "0x186B036D0")]
	public DPCLFAJCHGB NPMJJMLDIAO(int PDMMEDBMFPP, EEMOMCJGFPH GNLDGJDNMDL)
	{
		return default(DPCLFAJCHGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6B02D40", Offset = "0x6B01340", VA = "0x186B02D40")]
	public void CEFKOHCNLJL(DPCLFAJCHGB PABFDMCLKCE, EEMOMCJGFPH GNLDGJDNMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6B03800", Offset = "0x6B01E00", VA = "0x186B03800")]
	public bool PBAICEDEEDN(DPCLFAJCHGB PABFDMCLKCE, EEMOMCJGFPH GNLDGJDNMDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6B035C0", Offset = "0x6B01BC0", VA = "0x186B035C0")]
	public void NIHCHBGDDBE(EEMOMCJGFPH GNLDGJDNMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6B02E70", Offset = "0x6B01470", VA = "0x186B02E70")]
	public bool COIDELIDJOP(DPCLFAJCHGB PABFDMCLKCE, EEMOMCJGFPH GNLDGJDNMDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6B02C30", Offset = "0x6B01230", VA = "0x186B02C30")]
	public bool AMMDDOOHJOC(EEMOMCJGFPH GNLDGJDNMDL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct OKOKCJGECAJ : IEquatable<OKOKCJGECAJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public AMOFBKBMFBA IMKGIBCHBKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(AMOFBKBMFBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	private CPNHAFLLNGA ECBIJNMIEJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6B03190", Offset = "0x6B01790", VA = "0x186B03190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private AJEIHOPLKOK MDMIEEDKOGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6B13B10", Offset = "0x6B12110", VA = "0x186B13B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
	public OKOKCJGECAJ(AMOFBKBMFBA NACMAJFMJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6B13BA0", Offset = "0x6B121A0", VA = "0x186B13BA0", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(OKOKCJGECAJ BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x6B13C30", Offset = "0x6B12230", VA = "0x186B13C30")]
	public void FGPJGHMIDKP(bool DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x6B13CC0", Offset = "0x6B122C0", VA = "0x186B13CC0")]
	public void LOHKMMFALPG(bool DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x2CFB1D0", Offset = "0x2CF97D0", VA = "0x182CFB1D0")]
	public T NHNDJOCNDAC<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct IHFNFMNOCEJ : IEquatable<IHFNFMNOCEJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public AMOFBKBMFBA IMKGIBCHBKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(AMOFBKBMFBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	private CPNHAFLLNGA ECBIJNMIEJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x6B03190", Offset = "0x6B01790", VA = "0x186B03190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	private AJEIHOPLKOK MDMIEEDKOGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C8E0", Offset = "0x6B0AEE0", VA = "0x186B0C8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private FELJAJJKNHJ NIBNDABEIIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C880", Offset = "0x6B0AE80", VA = "0x186B0C880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public bool KOFEKFKODDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C7F0", Offset = "0x6B0ADF0", VA = "0x186B0C7F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public bool OPDLPGBEABO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C760", Offset = "0x6B0AD60", VA = "0x186B0C760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
	public IHFNFMNOCEJ(AMOFBKBMFBA NACMAJFMJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6B0C970", Offset = "0x6B0AF70", VA = "0x186B0C970", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(IHFNFMNOCEJ BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public readonly struct HEDPAHPCGGG : IEquatable<HEDPAHPCGGG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x6B0C6D0", Offset = "0x6B0ACD0", VA = "0x186B0C6D0", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(HEDPAHPCGGG BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct JDBNMFAHHAD : IEquatable<JDBNMFAHHAD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public AMOFBKBMFBA IMKGIBCHBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(AMOFBKBMFBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private CPNHAFLLNGA ECBIJNMIEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x6B03190", Offset = "0x6B01790", VA = "0x186B03190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private AJEIHOPLKOK MDMIEEDKOGE
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CCF0", Offset = "0x6B0B2F0", VA = "0x186B0CCF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private OLBNFMLEBDH PCOLFBMJAPP
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x6B0D7B0", Offset = "0x6B0BDB0", VA = "0x186B0D7B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private GIMOLPPICGB CGCMPBLAHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CB50", Offset = "0x6B0B150", VA = "0x186B0CB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool AKPKCJFMBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CF50", Offset = "0x6B0B550", VA = "0x186B0CF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool AMMAJEIIBNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x6B0D360", Offset = "0x6B0B960", VA = "0x186B0D360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool JANIHKFMLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CCC0", Offset = "0x6B0B2C0", VA = "0x186B0CCC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool LMFLKAAMMEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x6B0D050", Offset = "0x6B0B650", VA = "0x186B0D050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool LEOBNJDEEFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x6B0D330", Offset = "0x6B0B930", VA = "0x186B0D330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool BGPKBGIOODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x6B0D720", Offset = "0x6B0BD20", VA = "0x186B0D720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool GFFNIAIOEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x6B0D120", Offset = "0x6B0B720", VA = "0x186B0D120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool LMLEHFMKDLE
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6B0D5B0", Offset = "0x6B0BBB0", VA = "0x186B0D5B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
	public JDBNMFAHHAD(AMOFBKBMFBA NACMAJFMJAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A0B0", Offset = "0x6B086B0", VA = "0x186B0A0B0")]
	public static bool HDKGBCFDEBL(JDBNMFAHHAD DMNGPNKHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6B0CD80", Offset = "0x6B0B380", VA = "0x186B0CD80", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(JDBNMFAHHAD BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x6B0CFE0", Offset = "0x6B0B5E0", VA = "0x186B0CFE0")]
	public bool JPJLNAOCEPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6B0D400", Offset = "0x6B0BA00", VA = "0x186B0D400")]
	public DPCLFAJCHGB ONDMLHJIOGF(DPCLFAJCHGB PABFDMCLKCE)
	{
		return default(DPCLFAJCHGB);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x6B0D4A0", Offset = "0x6B0BAA0", VA = "0x186B0D4A0")]
	public AMOFBKBMFBA OOIDCFHLEPD()
	{
		return default(AMOFBKBMFBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x6B0CE10", Offset = "0x6B0B410", VA = "0x186B0CE10")]
	public bool FELBOAENKOH(AMOFBKBMFBA EHENEDFIPPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x6B0CEB0", Offset = "0x6B0B4B0", VA = "0x186B0CEB0")]
	public bool HNBNJAHCPME(AMOFBKBMFBA DKGFGOHKHPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6B0CBB0", Offset = "0x6B0B1B0", VA = "0x186B0CBB0")]
	public bool AKHOOENBEFI(AMOFBKBMFBA PABFDMCLKCE, [Out] AMOFBKBMFBA EHENEDFIPPM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct JEPMDIABGDP : IEquatable<JEPMDIABGDP>
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly JEPMDIABGDP FHJCFPMPMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public AMOFBKBMFBA IMKGIBCHBKE
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(AMOFBKBMFBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public DIGCCNOHOGM BIPGCHCOEKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DIGCCNOHOGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public GPMMLOLMFPA DNOCCFDMNNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(GPMMLOLMFPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private ShapeTypeDataWrapper NEPPJJJIAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6B0D880", Offset = "0x6B0BE80", VA = "0x186B0D880")]
		get
		{
			return default(ShapeTypeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public StandardRenderableVisualDataWrapper LOPNBMBBIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x6B0E020", Offset = "0x6B0C620", VA = "0x186B0E020")]
		get
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public PhysicsMaterialDataWrapper FOLNJGMBJEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x6B0DB80", Offset = "0x6B0C180", VA = "0x186B0DB80")]
		get
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public ShapeConfigDataWrapper FDJPKKJJMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x6B0DBE0", Offset = "0x6B0C1E0", VA = "0x186B0DBE0")]
		get
		{
			return default(ShapeConfigDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public EMOJCCPMLJF MABEBJKNJHO
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6B0D810", Offset = "0x6B0BE10", VA = "0x186B0D810")]
		get
		{
			return default(EMOJCCPMLJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public GDHFDPACHFB MPMBBOKEEJM
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x6B0DF40", Offset = "0x6B0C540", VA = "0x186B0DF40")]
		get
		{
			return default(GDHFDPACHFB);
		}
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x6B0DED0", Offset = "0x6B0C4D0", VA = "0x186B0DED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public EJIAINLLJBH JOEAPFOLGBE
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x6B0DA20", Offset = "0x6B0C020", VA = "0x186B0DA20")]
		get
		{
			return default(EJIAINLLJBH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x6B0DC40", Offset = "0x6B0C240", VA = "0x186B0DC40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public float GDCBFLBHODD
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x6B0DD30", Offset = "0x6B0C330", VA = "0x186B0DD30")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x6B0D8E0", Offset = "0x6B0BEE0", VA = "0x186B0D8E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public Vector3 DDNGCOOMONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x6B0DD90", Offset = "0x6B0C390", VA = "0x186B0DD90")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x6B0DE30", Offset = "0x6B0C430", VA = "0x186B0DE30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public float CEAOPBCPHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x6B0DA80", Offset = "0x6B0C080", VA = "0x186B0DA80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public PPJODBBIPDM MHHKMDMDNFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x6B0D9C0", Offset = "0x6B0BFC0", VA = "0x186B0D9C0")]
		get
		{
			return default(PPJODBBIPDM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x6B0D950", Offset = "0x6B0BF50", VA = "0x186B0D950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
	public JEPMDIABGDP(AMOFBKBMFBA NACMAJFMJAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A0B0", Offset = "0x6B086B0", VA = "0x186B0A0B0")]
	public static bool HDKGBCFDEBL(JEPMDIABGDP DMNGPNKHPKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x6B05460", Offset = "0x6B03A60", VA = "0x186B05460")]
	public static bool NKEIKPOPFDO(JEPMDIABGDP KHKPJFABMKM, JEPMDIABGDP CGBLKAAFCDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6B0DAF0", Offset = "0x6B0C0F0", VA = "0x186B0DAF0", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(JEPMDIABGDP BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x6B0DCB0", Offset = "0x6B0C2B0", VA = "0x186B0DCB0")]
	public IKKPMNDDHLC IPCLLHFPIFL()
	{
		return default(IKKPMNDDHLC);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x6B0DFA0", Offset = "0x6B0C5A0", VA = "0x186B0DFA0")]
	public MFJAFADIOFH OIDJCHDEIMC()
	{
		return default(MFJAFADIOFH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct IKKPMNDDHLC : IEquatable<IKKPMNDDHLC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public AMOFBKBMFBA IMKGIBCHBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(AMOFBKBMFBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public JEPMDIABGDP INKLIMJPJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(JEPMDIABGDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private PrimitiveShapeDataWrapper JANBEDOFMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CAF0", Offset = "0x6B0B0F0", VA = "0x186B0CAF0")]
		get
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public JNBPIKMLHDI FJENGFOLMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CA90", Offset = "0x6B0B090", VA = "0x186B0CA90")]
		get
		{
			return default(JNBPIKMLHDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
	public IKKPMNDDHLC(AMOFBKBMFBA NACMAJFMJAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A0B0", Offset = "0x6B086B0", VA = "0x186B0A0B0")]
	public static bool HDKGBCFDEBL(IKKPMNDDHLC DMNGPNKHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x6B0CA00", Offset = "0x6B0B000", VA = "0x186B0CA00", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(IKKPMNDDHLC BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DefaultMember("Item")]
public readonly struct MFJAFADIOFH : IEquatable<MFJAFADIOFH>
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly MFJAFADIOFH FHJCFPMPMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public AMOFBKBMFBA IMKGIBCHBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(AMOFBKBMFBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public DIGCCNOHOGM BIPGCHCOEKG
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DIGCCNOHOGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private CPNHAFLLNGA ECBIJNMIEJE
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x6B03190", Offset = "0x6B01790", VA = "0x186B03190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private AJEIHOPLKOK MDMIEEDKOGE
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x6B12510", Offset = "0x6B10B10", VA = "0x186B12510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	private MEMPAJLKOPH AFPFLBKIMAC
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x6B121F0", Offset = "0x6B107F0", VA = "0x186B121F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public JEPMDIABGDP INKLIMJPJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(JEPMDIABGDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public LOOJMKCMMDI EHEMMHMAGOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x6B120C0", Offset = "0x6B106C0", VA = "0x186B120C0")]
		get
		{
			return default(LOOJMKCMMDI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x6B11FA0", Offset = "0x6B105A0", VA = "0x186B11FA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public IEnumerable<AFPMKLLMGAG> NDKGKJFENLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x6B12630", Offset = "0x6B10C30", VA = "0x186B12630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public AFPMKLLMGAG CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x6B12B00", Offset = "0x6B11100", VA = "0x186B12B00")]
		get
		{
			return default(AFPMKLLMGAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x6B11F10", Offset = "0x6B10510", VA = "0x186B11F10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
	public MFJAFADIOFH(AMOFBKBMFBA NACMAJFMJAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A0B0", Offset = "0x6B086B0", VA = "0x186B0A0B0")]
	public static bool HDKGBCFDEBL(MFJAFADIOFH DMNGPNKHPKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A050", Offset = "0x6B08650", VA = "0x186B0A050")]
	public static bool FFOLOHFBIHN(MFJAFADIOFH KHKPJFABMKM, MFJAFADIOFH CGBLKAAFCDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x6B125A0", Offset = "0x6B10BA0", VA = "0x186B125A0", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(MFJAFADIOFH BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x6B12840", Offset = "0x6B10E40", VA = "0x186B12840")]
	public AFPMKLLMGAG LOAJHLPEHFH(float3? MCPNOOFMAHG, [Optional] quaternion? GLKHDAMNPBA, [Optional] Vector3? ICLEOPHCOMM)
	{
		return default(AFPMKLLMGAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x6B122E0", Offset = "0x6B108E0", VA = "0x186B122E0")]
	public AFPMKLLMGAG EGGBADNHLGK(int PDMMEDBMFPP, float3? MCPNOOFMAHG, [Optional] quaternion? GLKHDAMNPBA, [Optional] Vector3? ICLEOPHCOMM)
	{
		return default(AFPMKLLMGAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x6B12A60", Offset = "0x6B11060", VA = "0x186B12A60")]
	public void MJIDLAPDOJN(int PDMMEDBMFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x6B12250", Offset = "0x6B10850", VA = "0x186B12250")]
	public void DMCFOMNOLLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct AFPMKLLMGAG : IEquatable<AFPMKLLMGAG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public AMOFBKBMFBA IMKGIBCHBKE
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(AMOFBKBMFBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public MFJAFADIOFH IOLMFOJAADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x6B039B0", Offset = "0x6B01FB0", VA = "0x186B039B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public float3 AFDJHIPPHGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x6B03BB0", Offset = "0x6B021B0", VA = "0x186B03BB0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x6B03B30", Offset = "0x6B02130", VA = "0x186B03B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public quaternion JGMGNPPDNFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x6B03930", Offset = "0x6B01F30", VA = "0x186B03930")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6B03C30", Offset = "0x6B02230", VA = "0x186B03C30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public float3 HNKHKPACFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x6B03EB0", Offset = "0x6B024B0", VA = "0x186B03EB0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x6B03E30", Offset = "0x6B02430", VA = "0x186B03E30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public HKHEOBACNDB KMJAPEAGJGC
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x6B03CA0", Offset = "0x6B022A0", VA = "0x186B03CA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	private SplinePointParentDataWrapper KLLOCEFBCIE
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x6B03AD0", Offset = "0x6B020D0", VA = "0x186B03AD0")]
		get
		{
			return default(SplinePointParentDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	private SplinePointPositionDataWrapper EJINAMDLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x6B03D10", Offset = "0x6B02310", VA = "0x186B03D10")]
		get
		{
			return default(SplinePointPositionDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	private SplinePointRotationDataWrapper MHICCKKBEND
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x6B03D70", Offset = "0x6B02370", VA = "0x186B03D70")]
		get
		{
			return default(SplinePointRotationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	private SplinePointScaleDataWrapper KLMFAILELED
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6B03DD0", Offset = "0x6B023D0", VA = "0x186B03DD0")]
		get
		{
			return default(SplinePointScaleDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	private SplinePointOrderDataWrapper LJIEOGHFJFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x6B038D0", Offset = "0x6B01ED0", VA = "0x186B038D0")]
		get
		{
			return default(SplinePointOrderDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
	public AFPMKLLMGAG(AMOFBKBMFBA NACMAJFMJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x6B03A40", Offset = "0x6B02040", VA = "0x186B03A40", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(AFPMKLLMGAG BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x6B039B0", Offset = "0x6B01FB0", VA = "0x186B039B0")]
	public void JKGICBKENDL(MFJAFADIOFH DMNGPNKHPKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct AHGAGDPCIGE : IEquatable<AHGAGDPCIGE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public AMOFBKBMFBA IMKGIBCHBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(AMOFBKBMFBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	private CPNHAFLLNGA ECBIJNMIEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x6B03190", Offset = "0x6B01790", VA = "0x186B03190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private AJEIHOPLKOK MDMIEEDKOGE
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x6B041A0", Offset = "0x6B027A0", VA = "0x186B041A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private PNKHCKOJKBK HCPJKABEDIE
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x6B045E0", Offset = "0x6B02BE0", VA = "0x186B045E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	private ToolCleanupSettingsDataWrapper PGLDNNAADPC
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6B047C0", Offset = "0x6B02DC0", VA = "0x186B047C0")]
		get
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public bool OFDOPJAFEDM
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x6B044B0", Offset = "0x6B02AB0", VA = "0x186B044B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x6B04B00", Offset = "0x6B03100", VA = "0x186B04B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool NPBHLAIGOMP
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x6B04510", Offset = "0x6B02B10", VA = "0x186B04510")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x6B04570", Offset = "0x6B02B70", VA = "0x186B04570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public float HHGKMKBJGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6B04AA0", Offset = "0x6B030A0", VA = "0x186B04AA0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x6B04640", Offset = "0x6B02C40", VA = "0x186B04640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool NMHEEDFEIPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x6B04100", Offset = "0x6B02700", VA = "0x186B04100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
	public AHGAGDPCIGE(AMOFBKBMFBA NACMAJFMJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x6B04230", Offset = "0x6B02830", VA = "0x186B04230", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(AHGAGDPCIGE BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x6B03F30", Offset = "0x6B02530", VA = "0x186B03F30")]
	public void AHKAMGIONBN(int CAAMCMKANHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x6B046B0", Offset = "0x6B02CB0", VA = "0x186B046B0")]
	public bool KBELCKAGLGH([Out] int CAAMCMKANHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x6B04410", Offset = "0x6B02A10", VA = "0x186B04410")]
	public void GOPEFMPLEKO(bool AMONBMJDMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x6B04820", Offset = "0x6B02E20", VA = "0x186B04820")]
	public void LKPGLHMBKMM(float KMCCPDKDMJF, float DMIFPNBKJHL, float FNNMMAECCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x6B042C0", Offset = "0x6B028C0", VA = "0x186B042C0")]
	public void FLAOCLLBJIJ(float3 CFKIOFGFFHI, quaternion MCHMHBBGCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x6B04970", Offset = "0x6B02F70", VA = "0x186B04970")]
	public bool ODJLFBEKDGB([Out] float3 CFKIOFGFFHI, [Out] quaternion MCHMHBBGCNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x6B03FD0", Offset = "0x6B025D0", VA = "0x186B03FD0")]
	public bool BMGFJNAKLGH([Out] float BPAEOBOLDFC, [Out] float LJBFHBKAMEJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct DIGCCNOHOGM : IEquatable<DIGCCNOHOGM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly AMOFBKBMFBA OOLEDFCEFHP;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public DPCLFAJCHGB JFGGKCGEEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(DPCLFAJCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public GPMMLOLMFPA DNOCCFDMNNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
		get
		{
			return default(GPMMLOLMFPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	private CPNHAFLLNGA ECBIJNMIEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x6B03190", Offset = "0x6B01790", VA = "0x186B03190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	private BDNDDDCPNMG OCOEFLDNDKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x6B08640", Offset = "0x6B06C40", VA = "0x186B08640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public bool ELFGMFFEKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x6B07D60", Offset = "0x6B06360", VA = "0x186B07D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public Vector3 AFDJHIPPHGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x6B08FE0", Offset = "0x6B075E0", VA = "0x186B08FE0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x6B08B50", Offset = "0x6B07150", VA = "0x186B08B50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public Quaternion JGMGNPPDNFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6B08000", Offset = "0x6B06600", VA = "0x186B08000")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x6B090D0", Offset = "0x6B076D0", VA = "0x186B090D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public Vector3 CNDGMBBGEON
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x6B08A60", Offset = "0x6B07060", VA = "0x186B08A60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x6B07DA0", Offset = "0x6B063A0", VA = "0x186B07DA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public Quaternion ICHHJMIFMKB
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x6B07B20", Offset = "0x6B06120", VA = "0x186B07B20")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x6B07A00", Offset = "0x6B06000", VA = "0x186B07A00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public float BMIGAHHGIOC
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x6B08CC0", Offset = "0x6B072C0", VA = "0x186B08CC0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x6B08700", Offset = "0x6B06D00", VA = "0x186B08700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public float JNBNNNNEDJB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x6B09770", Offset = "0x6B07D70", VA = "0x186B09770")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public Vector3 HNKHKPACFEE
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x6B09C60", Offset = "0x6B08260", VA = "0x186B09C60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x6B099F0", Offset = "0x6B07FF0", VA = "0x186B099F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public Vector3 FOFHNLEKFJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x6B07C70", Offset = "0x6B06270", VA = "0x186B07C70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public Matrix4x4 GCEOFKEJAMM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x6B09810", Offset = "0x6B07E10", VA = "0x186B09810")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
	public DIGCCNOHOGM(AMOFBKBMFBA NACMAJFMJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x6B03160", Offset = "0x6B01760", VA = "0x186B03160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6B082F0", Offset = "0x6B068F0", VA = "0x186B082F0", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B016C0", VA = "0x186B030C0", Slot = "4")]
	public bool Equals(DIGCCNOHOGM BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x6B038B0", Offset = "0x6B01EB0", VA = "0x186B038B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x6B07AD0", Offset = "0x6B060D0", VA = "0x186B07AD0")]
	public ANOGDKLDLNH AGNCKPMLBEF()
	{
		return default(ANOGDKLDLNH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x6B08450", Offset = "0x6B06A50", VA = "0x186B08450")]
	public void FJHCBHJFBJD([Out] Matrix4x4 GCKKDKDKEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6B07F20", Offset = "0x6B06520", VA = "0x186B07F20")]
	public void BAIKOIGIPCE([Out] Vector3 IAHELKBMBME, [Out] Quaternion KDPNLEHDGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x6B07E70", Offset = "0x6B06470", VA = "0x186B07E70")]
	public void BAIKOIGIPCE([Out] RigidTransform CKOOIIEAOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x6B08F00", Offset = "0x6B07500", VA = "0x186B08F00")]
	public void JICDKMGJGHH([Out] Vector3 IAHELKBMBME, [Out] Quaternion KDPNLEHDGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6B08E50", Offset = "0x6B07450", VA = "0x186B08E50")]
	public void JICDKMGJGHH([Out] RigidTransform CKOOIIEAOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6B08E20", Offset = "0x6B07420", VA = "0x186B08E20")]
	public UniformTRS JFEDHGKKKGB()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6B08D60", Offset = "0x6B07360", VA = "0x186B08D60")]
	public void JFEDHGKKKGB([Out] UniformTRS KJGAGCEOPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6B08200", Offset = "0x6B06800", VA = "0x186B08200")]
	public UniformTRS EANHJKJPNIO()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6B08230", Offset = "0x6B06830", VA = "0x186B08230")]
	public void EANHJKJPNIO([Out] UniformTRS CKOOIIEAOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6B09680", Offset = "0x6B07C80", VA = "0x186B09680")]
	public Vector3 MCHLPMJIEBO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x6B07840", Offset = "0x6B05E40", VA = "0x186B07840")]
	public void AEJCIOEKOAH([In] Vector3 DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x6B09AC0", Offset = "0x6B080C0", VA = "0x186B09AC0")]
	public Vector3 PDKKGFHECIF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x6B09920", Offset = "0x6B07F20", VA = "0x186B09920")]
	public void OIODDFCHNMD([In] Vector3 DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6B093C0", Offset = "0x6B079C0", VA = "0x186B093C0")]
	public Quaternion LBHPDNMHJME()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x6B09510", Offset = "0x6B07B10", VA = "0x186B09510")]
	public void LEBFIMGCNJA([In] Quaternion DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6B091A0", Offset = "0x6B077A0", VA = "0x186B091A0")]
	public Quaternion KHEBDOILJDE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6B08570", Offset = "0x6B06B70", VA = "0x186B08570")]
	public void FKGHPOEHKBP([In] Quaternion DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6B08C20", Offset = "0x6B07220", VA = "0x186B08C20")]
	public float IJBAACEMPMA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x6B09BB0", Offset = "0x6B081B0", VA = "0x186B09BB0")]
	public void PLDMJEPHOAM(float DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x6B095E0", Offset = "0x6B07BE0", VA = "0x186B095E0")]
	public float LFHNBCHABCH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x6B08150", Offset = "0x6B06750", VA = "0x186B08150")]
	public void CKFMEOHLHMH(float DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x6B088A0", Offset = "0x6B06EA0", VA = "0x186B088A0")]
	public void HFEMHPAJJJD([In] Vector3 DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6B07910", Offset = "0x6B05F10", VA = "0x186B07910")]
	public Vector3 AFIKLKGFLMC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x6B09850", Offset = "0x6B07E50", VA = "0x186B09850")]
	public void OEJDCIMDCIB([In] Vector3 DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x6B087B0", Offset = "0x6B06DB0", VA = "0x186B087B0")]
	public Vector3 HDPLPMJNIEO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x6B092F0", Offset = "0x6B078F0", VA = "0x186B092F0")]
	public void KODIOHLHFLP([In] Vector3 DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6B08970", Offset = "0x6B06F70", VA = "0x186B08970")]
	public Vector3 HGPDINNFDNB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6B08380", Offset = "0x6B06980", VA = "0x186B08380")]
	public void FANCAEIHIOI([In] Vector3 DMNGPNKHPKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class DCJKDKPPGIC
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private struct EPJNAOBOELK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Guid IJNLNGBKEAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NCKMKPPFPKP EKFDBHBCGLM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private struct NCKMKPPFPKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int DMNGPNKHPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int CEDOAPLLDKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int IJHMFIPHMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int NKLFCEMOJPD;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x6B12C10", Offset = "0x6B11210", VA = "0x186B12C10")]
		public bool ECPIGBLGBDI([Out] KJCIFKAMOBH FAOMEEFLJBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x6B12CA0", Offset = "0x6B112A0", VA = "0x186B12CA0")]
		public NCKMKPPFPKP(KJCIFKAMOBH FAOMEEFLJBM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6B07780", Offset = "0x6B05D80", VA = "0x186B07780")]
	public static Guid BEJHHFCEBEP(this KJCIFKAMOBH FAOMEEFLJBM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6B07820", Offset = "0x6B05E20", VA = "0x186B07820")]
	public static bool PJJNBBLCKNG(this Guid IJNLNGBKEAC, [Out] KJCIFKAMOBH FAOMEEFLJBM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal static class FOFECGGNFBE
{
	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B900", Offset = "0x6B09F00", VA = "0x186B0B900")]
	public static AJEIHOPLKOK MDMIEEDKOGE(this AMOFBKBMFBA DAIJJLLIENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B830", Offset = "0x6B09E30", VA = "0x186B0B830")]
	public static JBDAPNANMGI IHGCNCDGIIE(this AMOFBKBMFBA DAIJJLLIENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B990", Offset = "0x6B09F90", VA = "0x186B0B990")]
	public static EntityManager PJGELPMLNAK(this AMOFBKBMFBA DAIJJLLIENA)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2B89450", Offset = "0x2B87A50", VA = "0x182B89450")]
	public static T IMMBFKHFHGI<T>(this AMOFBKBMFBA DAIJJLLIENA) where T : struct, JLCHKADBFPJ
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2B8A710", Offset = "0x2B88D10", VA = "0x182B8A710")]
	public static bool NNFBONKILDB<T>(this AMOFBKBMFBA DAIJJLLIENA) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x2B893A0", Offset = "0x2B879A0", VA = "0x182B893A0")]
	public static bool AIBOGHBMJBD<T>(this AMOFBKBMFBA DAIJJLLIENA) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface ILJDADPJOGB
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PNLODANGOJL(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MBHCCNIPJAH(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task FAAIMEOLJDJ(DPCLFAJCHGB NJKKPOFFNNJ);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HIMMGFHIBNN(AMOFBKBMFBA NACMAJFMJAJ, [Out] Guid EHLNCLBLNMA);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid GBFLIDDCCOD(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KLNCFMDONCD(AMOFBKBMFBA NACMAJFMJAJ, Guid EHLNCLBLNMA);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PLJFFBHKNJA(AMOFBKBMFBA NACMAJFMJAJ, [Out] Guid CNJMIDDPAFB);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Guid LMIACBHPOCI(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FFMJMMGOCJP(AMOFBKBMFBA NACMAJFMJAJ, Guid CNJMIDDPAFB);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ILPIKAIDKJH(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task BFPPDOPEGBO(AMOFBKBMFBA BCMCEBEOPPL, AMOFBKBMFBA PPEEAFEPIIK);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface IMAKMIDFGII
{
	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	Guid GGNDNEJMHFD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HFOKLOCGKKJ(NativeList<Guid> GNDODMLJJFK, NativeList<Guid> ABBGIBAIGDN, NativeList<FixedString64Bytes> JJCDCHHFEMB);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface FELJAJJKNHJ
{
	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BDGKMADMGMB(List<AMOFBKBMFBA> EOMNLFBHKKG);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GOCODMIJJPD(List<AMOFBKBMFBA> CEDPOANLPEJ);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LGCEOMFPLMP(AMOFBKBMFBA PMPEHAMBEGA);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KOFEKFKODDG(AMOFBKBMFBA PMPEHAMBEGA);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OPDLPGBEABO(AMOFBKBMFBA PMPEHAMBEGA);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int AHNCNNBJGFN(AMOFBKBMFBA PMPEHAMBEGA);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IAOMCAPLOHM(AMOFBKBMFBA PMPEHAMBEGA, int FFHBHOMFFND);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AMOFBKBMFBA MKHGMBJHBKG(AMOFBKBMFBA MJAOONFMEBA);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int ACDOBHMOKJL(AMOFBKBMFBA MJAOONFMEBA);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DDFKJGBIAOF(AMOFBKBMFBA MJAOONFMEBA, int JEIFBKDALDH);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int JMBHOGAFHEN(AMOFBKBMFBA MJAOONFMEBA);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PGGDENKIBAG(AMOFBKBMFBA MJAOONFMEBA, int FMEACNBELOP);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EFJIGENLMPP(AMOFBKBMFBA OOLEDFCEFHP);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LBKHEBCONEO(AMOFBKBMFBA NACMAJFMJAJ, bool HLAJDKFGMBO);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NDCLPJDAIIH(AMOFBKBMFBA[] NAKHKAGBEGC, bool HLAJDKFGMBO);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface JHPKMKLBKFM
{
	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	IReadOnlyCollection<HMKFABCJNPL> CLFJEMPDELA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DELCFOCCMMB(int ECLABNAHOPL, [Out] HMKFABCJNPL JBDHPKKOEHC);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HMKFABCJNPL MBOJHECMBBF(Type GOAECDHCJMK);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class KBHLDNJJAPI
{
	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x2C33600", Offset = "0x2C31C00", VA = "0x182C33600")]
	public static T POKMIKCFOFA<T>(this JHPKMKLBKFM MOAIFAKIEIB, Entity PIKIMHFFNIJ) where T : struct, JLCHKADBFPJ
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2C32A30", Offset = "0x2C31030", VA = "0x182C32A30")]
	public static HMKFABCJNPL MBOJHECMBBF<T>(this JHPKMKLBKFM MOAIFAKIEIB) where T : struct, JLCHKADBFPJ
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface EBFKHPHIEFE
{
	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KJCIFKAMOBH[] EOMJPPJCFFP(string GJEDHMJMNJA, DPCLFAJCHGB NNDCDIBGPEO, bool GNICKPMAGBF = false);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LMLPCGKIEMM(string ALGLCCEBAGM, KJCIFKAMOBH[] EBMBOEDMFIM);
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface IKDKABNIMCK
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<AMOFBKBMFBA, AMOFBKBMFBA> DMJONNFJPBH;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<AMOFBKBMFBA, AMOFBKBMFBA> JHJICKAPKGD;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<AMOFBKBMFBA, AMOFBKBMFBA, AMOFBKBMFBA> LCCNLOHPLLC;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<AMOFBKBMFBA> OKFLBDOEAAJ;

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GCKNDFLHPMM(AMOFBKBMFBA NACMAJFMJAJ, AMOFBKBMFBA JOOKFOILIMG);

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	AMOFBKBMFBA BKAGIKGIFCL(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<AMOFBKBMFBA> MOCHOAMHHDG(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	AMOFBKBMFBA IBFOFPPEHBN(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KONGJCNAHDD(AMOFBKBMFBA NACMAJFMJAJ, Vector3 FAHHEDKEBOL, Quaternion PBBJOFPHCIO);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PHPILIINBEG(AMOFBKBMFBA NACMAJFMJAJ, float IDNMIPJFBOL);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool OMBPOPAJGDM(AMOFBKBMFBA NACMAJFMJAJ, [Out] AMOFBKBMFBA PPEEAFEPIIK);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool FEGBFDBCJEE(AMOFBKBMFBA NACMAJFMJAJ, [Out] RigidTransform MJNMGOIONBC);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool BEACNMDKMNN(AMOFBKBMFBA NACMAJFMJAJ, [Out] float BEGJNLEADAO);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 AGGLJOJNNGC(KBNENCAOFHA OFIPLECPJDH);

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "18")]
	quaternion NMPMNMCNFGM(KBNENCAOFHA OFIPLECPJDH);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class BCDEJKCJGCN
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface DHLGJBICILH
{
	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	object PNLGPJHMJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INHIFEPFHCN(DBDGEDGIEPP NAKHKAGBEGC);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct DANNPOCEPPC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly string GJEDHMJMNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly T DNKAMNBGFFH;

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x58A87F0", Offset = "0x58A6DF0", VA = "0x1858A87F0")]
	public DANNPOCEPPC(T DNKAMNBGFFH, [Optional][CallerMemberName] string GJEDHMJMNJA)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public static readonly DANNPOCEPPC<int> KPFIECPNPBA;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public enum JMCNOLFHCHA
{
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class PBLECEEILMB
{
	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0xDB0120", Offset = "0xDAE720", VA = "0x180DB0120")]
	public static bool BONJBCHFDAE(this JMCNOLFHCHA NEIJPCGNELF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0xDB0130", Offset = "0xDAE730", VA = "0x180DB0130")]
	public static bool OEMFDMDNBLH(this JMCNOLFHCHA NEIJPCGNELF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x2583D00", Offset = "0x2582300", VA = "0x182583D00")]
	public static bool FHKJPGMKEIC(this JMCNOLFHCHA NEIJPCGNELF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface PLNCHNFDDGD
{
	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	bool JFLDLKFMNOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface GCLGLEIPBNA
{
	[Cpp2IlInjected.Token(Token = "0x17000180")]
	JMCNOLFHCHA KCHGIEELPJD
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	JMCNOLFHCHA KHNFAICPGCH
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	JMCNOLFHCHA AGJCCCHJIOG
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	JMCNOLFHCHA MLBKFOILAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	JMCNOLFHCHA CPMODMFJGNF
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	JMCNOLFHCHA JEFEILNBDOP
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	JMCNOLFHCHA CPKLLGKBOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	JMCNOLFHCHA EEGNJGMNNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	JMCNOLFHCHA KGLPNMPJHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	JMCNOLFHCHA BIICKIACHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	JMCNOLFHCHA ADIMOODCDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	JMCNOLFHCHA HBMLLCLMJFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	JMCNOLFHCHA JOALBNMMDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	JMCNOLFHCHA DEBPEDIIBII
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	JMCNOLFHCHA BDEFPNHLGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int FOHHCFMHKPE(DANNPOCEPPC<int> NIHBAMBHFCG);
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface IOCMEJKKNBE
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<ONPCMLCFACA> OCPFEJHEFOM;

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AMOFBKBMFBA GINOAKPCJIH(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AAFHCNMBBCN(List<AMOFBKBMFBA> CEDPOANLPEJ);

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HKHEOBACNDB EAMHBJOAPIC(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AOANAAFLBJG(IEnumerable<AMOFBKBMFBA> CPNKBGIDFLB);

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HKHEOBACNDB EHMFCFHMFPN(AMOFBKBMFBA PPEEAFEPIIK, AMOFBKBMFBA MBEDFGIGBHI, bool FEOENMNJAHG, AMOFBKBMFBA PABFDMCLKCE);

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AMOFBKBMFBA AFHOOHJCNBG(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GOPGAHCPBFG(AMOFBKBMFBA NACMAJFMJAJ, AMOFBKBMFBA PPEEAFEPIIK, bool LEMLBFMKMGA);

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool LHGOHMJLMNK(AMOFBKBMFBA NACMAJFMJAJ, AMOFBKBMFBA PPEEAFEPIIK);

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool JMHHGMHCGKM(AMOFBKBMFBA CKFIDMKBDLI, AMOFBKBMFBA OBLNIAFIHEF);

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int BLDLMBNBMLF(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DBDGEDGIEPP DIPJCDOMHHJ(AMOFBKBMFBA OOLEDFCEFHP);

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<AMOFBKBMFBA> HPABBGCPPNB(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool CNKFEOKMCFO(AMOFBKBMFBA NACMAJFMJAJ, AMOFBKBMFBA NNKACKDPGHF);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IEnumerable<AMOFBKBMFBA> AKKIAHFPEKJ(AMOFBKBMFBA NACMAJFMJAJ, bool FIHLOEAAELC = false);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool IIPJHALOFGL(AMOFBKBMFBA NACMAJFMJAJ, AMOFBKBMFBA JGNLPHMJMEF);

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	AMOFBKBMFBA GBPDOLGLFGH(AMOFBKBMFBA PABFDMCLKCE, AMOFBKBMFBA BFEAICLIJNA);

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool GBGECADPHIG(AMOFBKBMFBA PABFDMCLKCE, AMOFBKBMFBA BFEAICLIJNA, [Out] AMOFBKBMFBA DGNMOBIMAPP);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class GDGOKEOAEGB
{
	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6B0BA90", Offset = "0x6B0A090", VA = "0x186B0BA90")]
	public static List<AMOFBKBMFBA> AAFHCNMBBCN(this IOCMEJKKNBE CEFJJCAFMLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x6B0BBA0", Offset = "0x6B0A1A0", VA = "0x186B0BBA0")]
	public static bool DKCHKAELDKH(this IOCMEJKKNBE CEFJJCAFMLI, AMOFBKBMFBA NACMAJFMJAJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface OINAKNKLDHL
{
	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ODKKPIAMDKH NALHBICGPGO(AMOFBKBMFBA PMPEHAMBEGA);

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KIJPBIHEOEB(AMOFBKBMFBA PMPEHAMBEGA, ODKKPIAMDKH NEKIMPLBLGE);

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HFGBCBNDABG(AMOFBKBMFBA PMPEHAMBEGA);

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JKHMMOKJGAC(AMOFBKBMFBA PMPEHAMBEGA, bool DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string[] NDMDKNCIIHM(AMOFBKBMFBA PMPEHAMBEGA);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AAOFMINOCPI(AMOFBKBMFBA PMPEHAMBEGA, IEnumerable<string> FGPDHFALOFH);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string[] COKKOCFIIJJ(AMOFBKBMFBA PMPEHAMBEGA);

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ACABHAEMLNC(AMOFBKBMFBA PMPEHAMBEGA, IEnumerable<string> FGPDHFALOFH);

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "8")]
	string[] FABNAPMJAAI(AMOFBKBMFBA PMPEHAMBEGA);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BNKCCNDFACM(AMOFBKBMFBA PMPEHAMBEGA, IEnumerable<string> FGPDHFALOFH);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string[] GPGMEEIDCFE(AMOFBKBMFBA PMPEHAMBEGA);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IJCKPKENJEE(AMOFBKBMFBA PMPEHAMBEGA, IEnumerable<string> FGPDHFALOFH);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool KNABAFINFHB(AMOFBKBMFBA PMPEHAMBEGA, AMOFBKBMFBA AKBLJHNIFIE);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface BJGACHNJLLB
{
	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	bool DAPAKBNFDDE
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	bool HFBKKCBFCLP
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface PBKOBBKGEPA : BCMONOEODAB
{
	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PMBOBCPFNPL(Entity PIKIMHFFNIJ, [Out] OGOJKBDGFOI FPDGNDMPHII);

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHJCGMNIADM(NativeArray<OGOJKBDGFOI> KMMNMMLCLMO, NativeArray<CEAGKMBBGGO> MCJIPIBOJBB);

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DEIMCDILAON(OGOJKBDGFOI FPDGNDMPHII);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BNFMHGFEOIO(OGOJKBDGFOI FPDGNDMPHII, [Out] Collider LHLDOGJGFAN);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface BCMONOEODAB
{
	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BHEALDMODME([In] float3 BKCDIKNOEPB, [In] float3 GKDEFPHJFPJ, float KPAPKDHNJLJ, Allocator KOIILCBLJPK, [Out] NativeArray<Entity> OKKKBJGONCO);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface ACDHLIDFNDG
{
	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BHEALDMODME([In] float3 BKCDIKNOEPB, [In] float3 GKDEFPHJFPJ, float KPAPKDHNJLJ, [Out] JONIFGDFHOA BDKBOLHPBDG, [Out] AMOFBKBMFBA BOELICHHFGP);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface BLBHNKAOEFO
{
	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BHEALDMODME([In] NativeArray<Entity> OKKKBJGONCO, [In] float3 BKCDIKNOEPB, [In] float3 GKDEFPHJFPJ, [In] NativeArray<JONIFGDFHOA> GIOJCBOPEMM);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct OGOJKBDGFOI : DOGEODOABCA, IEquatable<OGOJKBDGFOI>
{
	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public int MIMJDCDEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0xAAF730", Offset = "0xAADD30", VA = "0x180AAF730", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0xAAF690", Offset = "0xAADC90", VA = "0x180AAF690", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public int HDIHKFJHDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x259FD50", Offset = "0x259E350", VA = "0x18259FD50", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x5DD2910", Offset = "0x5DD0F10", VA = "0x185DD2910", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x6B138E0", Offset = "0x6B11EE0", VA = "0x186B138E0", Slot = "8")]
	public bool Equals(OGOJKBDGFOI BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x6B13930", Offset = "0x6B11F30", VA = "0x186B13930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct JONIFGDFHOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float NPIHKOMDIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float3 MHHLIPGJMOK;
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface PJCDBAJIGLK
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface CPNHAFLLNGA
{
	[Cpp2IlInjected.Token(Token = "0x17000193")]
	AJEIHOPLKOK MDMIEEDKOGE
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	ELBEHJPJIAP DLFFMLFHABC
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<DBDGEDGIEPP, NativeArray<IDEDIMNMLPE>> NKMHLIJLMNC;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<DBDGEDGIEPP> AFCCKADKEKM;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IDMJFGHFBNP OOGJHOGCHHE(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDEDIMNMLPE ELMHIHBGIMP(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NECNOABNHFL(KJCIFKAMOBH FAOMEEFLJBM, AEBAKOEFOMI EIOMIFFNBNG);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GOPEHCFJIDG(KJCIFKAMOBH[] EBMBOEDMFIM, GameObject FNAHDAKHMJN);

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DPCLFAJCHGB OEOLFDEOGBD(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool AOPEJDJHEKP(AMOFBKBMFBA NACMAJFMJAJ, [Out] Transform AFJHLFMCCIJ);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool OELJLGGEPFD(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PEAOAHPHIDK(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "14")]
	AMOFBKBMFBA DCAKJHCHIHA(KJCIFKAMOBH FAOMEEFLJBM);

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool CGGPHJNHAIH(KJCIFKAMOBH FAOMEEFLJBM, [Out] AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	KJCIFKAMOBH GJIJDAFNCJM(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	DBDGEDGIEPP DCAKJHCHIHA(NativeArray<KJCIFKAMOBH> FAOMEEFLJBM, Allocator KOIILCBLJPK);

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	DBDGEDGIEPP KHJAOKPPHEE(IDEDIMNMLPE MDDJDHCOALA, int BMKFLHFENBJ, Allocator KOIILCBLJPK);

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	DBDGEDGIEPP BBLPPDHKBFC(NativeArray<KJCIFKAMOBH> FAOMEEFLJBM, NativeArray<CMGFGKEDLMC> LHCAODEGPOG, Allocator KOIILCBLJPK);

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	KJCIFKAMOBH[] EOMJPPJCFFP(string ALGLCCEBAGM, DPCLFAJCHGB NNDCDIBGPEO, bool GNICKPMAGBF);

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void LMLPCGKIEMM(string ALGLCCEBAGM, KJCIFKAMOBH[] EBMBOEDMFIM);

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "22")]
	DPCLFAJCHGB INLGLCBOJDN(IDEDIMNMLPE MDDJDHCOALA, bool GNGHHAOBMFF);

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "23")]
	DPCLFAJCHGB INLGLCBOJDN(IDEDIMNMLPE MDDJDHCOALA);

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "24")]
	DPCLFAJCHGB LLLIAIFJEGL(IDEDIMNMLPE MDDJDHCOALA);

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "25")]
	DPCLFAJCHGB CFHNOGGEIDI(IDEDIMNMLPE MDDJDHCOALA);

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "26")]
	DPCLFAJCHGB MNLNLHBGICA(KJCIFKAMOBH FAOMEEFLJBM, IDEDIMNMLPE MDDJDHCOALA);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "27")]
	PGHJEKIIAPM LDCFBNPDKOP();

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(Slot = "28")]
	MFJAFADIOFH ENHEIPAMAGA();

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "29")]
	IKKPMNDDHLC KNFEDFHIOIL(JNBPIKMLHDI BBEAEIFEIIN);

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void NGCIFCPJEJP(DBDGEDGIEPP NAKHKAGBEGC);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void IHOPKBJIMEI(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void KKCOLKBBJDF(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void NGCIFCPJEJP(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void CJACJBBEIKC(AMOFBKBMFBA NAKHKAGBEGC);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool PBIDENGNGJO(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(Slot = "36")]
	DBDGEDGIEPP NLNBKHPFJBF(DBDGEDGIEPP JCGFBOMNCCB, Allocator KOIILCBLJPK);

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool ELDMDCADOCM(AMOFBKBMFBA NACMAJFMJAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class CJPBHOCPOIB
{
	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x6B06410", Offset = "0x6B04A10", VA = "0x186B06410")]
	public static void PEAOAHPHIDK(this CPNHAFLLNGA HPPPLLCFNKH, AEBAKOEFOMI EIOMIFFNBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6B06090", Offset = "0x6B04690", VA = "0x186B06090")]
	public static DPCLFAJCHGB INFGFGIAKLJ(this CPNHAFLLNGA HPPPLLCFNKH, LocalId NACMAJFMJAJ)
	{
		return default(DPCLFAJCHGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6B061B0", Offset = "0x6B047B0", VA = "0x186B061B0")]
	public static DPCLFAJCHGB INFGFGIAKLJ(this CPNHAFLLNGA HPPPLLCFNKH, KJCIFKAMOBH FAOMEEFLJBM)
	{
		return default(DPCLFAJCHGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6B06090", Offset = "0x6B04690", VA = "0x186B06090")]
	public static AMOFBKBMFBA DCAKJHCHIHA(this CPNHAFLLNGA HPPPLLCFNKH, LocalId NACMAJFMJAJ)
	{
		return default(AMOFBKBMFBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x6B06130", Offset = "0x6B04730", VA = "0x186B06130")]
	public static KJCIFKAMOBH GJIJDAFNCJM(this CPNHAFLLNGA HPPPLLCFNKH, LocalId NACMAJFMJAJ)
	{
		return default(KJCIFKAMOBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6B060C0", Offset = "0x6B046C0", VA = "0x186B060C0")]
	public static bool ELDMDCADOCM(this CPNHAFLLNGA HPPPLLCFNKH, KJCIFKAMOBH FAOMEEFLJBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x29AF740", Offset = "0x29ADD40", VA = "0x1829AF740")]
	public static T HHABPHHOLPC<T>(this CPNHAFLLNGA HPPPLLCFNKH, LocalId NACMAJFMJAJ) where T : struct, JLCHKADBFPJ
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6B06210", Offset = "0x6B04810", VA = "0x186B06210")]
	public static PGHJEKIIAPM NOFBJFCANIL(this CPNHAFLLNGA HPPPLLCFNKH, RigidTransform KJGAGCEOPBC)
	{
		return default(PGHJEKIIAPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6B05F90", Offset = "0x6B04590", VA = "0x186B05F90")]
	public static IKKPMNDDHLC CJALNFDHLJH(this CPNHAFLLNGA HPPPLLCFNKH, JNBPIKMLHDI BKACNMIEGHC, RigidTransform KJGAGCEOPBC)
	{
		return default(IKKPMNDDHLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6B06310", Offset = "0x6B04910", VA = "0x186B06310")]
	public static MFJAFADIOFH NPMMFOMIOJO(this CPNHAFLLNGA HPPPLLCFNKH, RigidTransform KJGAGCEOPBC)
	{
		return default(MFJAFADIOFH);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6B05D90", Offset = "0x6B04390", VA = "0x186B05D90")]
	private static void BGNFOCCFLHN(DPCLFAJCHGB BCCPOFINLED, RigidTransform KJGAGCEOPBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface OLBNFMLEBDH
{
	[Cpp2IlInjected.Token(Token = "0x17000195")]
	bool LNIBADAJILC
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	AMOFBKBMFBA OEEPIHONHCK
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	DPCLFAJCHGB PIIBJEMCMFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event ICNLOIPGPFG JFIELKELIHF;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AMOFBKBMFBA GBPDOLGLFGH(AMOFBKBMFBA PABFDMCLKCE, AMOFBKBMFBA BFEAICLIJNA);

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GBGECADPHIG(AMOFBKBMFBA PABFDMCLKCE, AMOFBKBMFBA BFEAICLIJNA, [Out] AMOFBKBMFBA DGNMOBIMAPP);

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PNICKFIHCMM();

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HCACHIJFEIG();

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool AKPKCJFMBNP(AMOFBKBMFBA PABFDMCLKCE);

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool BGPKBGIOODO(AMOFBKBMFBA PABFDMCLKCE);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public delegate void ICNLOIPGPFG(DPCLFAJCHGB LAIOMAOBIHC, DPCLFAJCHGB LLPGDKOAFKA);
[Cpp2IlInjected.Token(Token = "0x2000089")]
public static class BKAHLDHEDNG
{
	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6B05C30", Offset = "0x6B04230", VA = "0x186B05C30")]
	public static bool OLALMBKNNCP(this OLBNFMLEBDH AFCIHABAEPL, DPCLFAJCHGB PABFDMCLKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6B05B50", Offset = "0x6B04150", VA = "0x186B05B50")]
	public static bool MMBIGHBLDMB(this OLBNFMLEBDH AFCIHABAEPL, AMOFBKBMFBA PABFDMCLKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x6B05AD0", Offset = "0x6B040D0", VA = "0x186B05AD0")]
	public static bool LMFLKAAMMEL(this OLBNFMLEBDH AFCIHABAEPL, AMOFBKBMFBA PABFDMCLKCE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface OEEDEOGABKH
{
	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KPBOKNAKGPG(DPCLFAJCHGB BCCPOFINLED, EEMOMCJGFPH GNLDGJDNMDL, List<DPCLFAJCHGB> GFJDFHOKGGL);

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int ELONEIBBHFM(DPCLFAJCHGB BCCPOFINLED, EEMOMCJGFPH GNLDGJDNMDL);

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KGGGNFPLILP(DPCLFAJCHGB BCCPOFINLED, List<DPCLFAJCHGB> GFJDFHOKGGL);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LFCMAHLPLCN(DPCLFAJCHGB CAAMCMKANHA, DPCLFAJCHGB PABFDMCLKCE, EEMOMCJGFPH GNLDGJDNMDL);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DPCLFAJCHGB NPMJJMLDIAO(DPCLFAJCHGB CAAMCMKANHA, int PDMMEDBMFPP, EEMOMCJGFPH GNLDGJDNMDL);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CEFKOHCNLJL(DPCLFAJCHGB CAAMCMKANHA, DPCLFAJCHGB PABFDMCLKCE, EEMOMCJGFPH GNLDGJDNMDL);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PBAICEDEEDN(DPCLFAJCHGB CAAMCMKANHA, DPCLFAJCHGB PABFDMCLKCE, EEMOMCJGFPH GNLDGJDNMDL);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NIHCHBGDDBE(DPCLFAJCHGB CAAMCMKANHA, EEMOMCJGFPH GNLDGJDNMDL);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool COIDELIDJOP(DPCLFAJCHGB CAAMCMKANHA, DPCLFAJCHGB PABFDMCLKCE, EEMOMCJGFPH GNLDGJDNMDL);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AMMPHBGGOCA(Entity CAAMCMKANHA, Entity PABFDMCLKCE, EEMOMCJGFPH GNLDGJDNMDL);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GNPAGKIJKOP(Entity CAAMCMKANHA, EEMOMCJGFPH GNLDGJDNMDL);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool AMMDDOOHJOC(DPCLFAJCHGB PABFDMCLKCE, EEMOMCJGFPH GNLDGJDNMDL);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface FCJKGGHKEEL
{
	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHHEMPJEBKG(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GPIMFFMNBPJ(AMOFBKBMFBA NACMAJFMJAJ, Transform AFJHLFMCCIJ);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface GIMOLPPICGB
{
	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FELBOAENKOH(AMOFBKBMFBA PABFDMCLKCE, AMOFBKBMFBA EHENEDFIPPM);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HNBNJAHCPME(AMOFBKBMFBA PABFDMCLKCE, AMOFBKBMFBA DKGFGOHKHPD);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AKHOOENBEFI(AMOFBKBMFBA PABFDMCLKCE, [Out] AMOFBKBMFBA FGPMDHHFIBI);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface ANBKJMGFOMJ
{
	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FGPJGHMIDKP(AMOFBKBMFBA OOLEDFCEFHP, bool DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LOHKMMFALPG(AMOFBKBMFBA OOLEDFCEFHP, bool DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FCFBLMBLDHN(AMOFBKBMFBA OOLEDFCEFHP, int DMNGPNKHPKF);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface MEMPAJLKOPH
{
	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<AMOFBKBMFBA> LBBNJBJLMIC(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AMOFBKBMFBA ANHNGMKEPHG(AMOFBKBMFBA NACMAJFMJAJ, int PDMMEDBMFPP);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int JGAKHHIIJLF(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LOOJMKCMMDI PAGMNNFEBHD(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AIAINHNPKOJ(AMOFBKBMFBA NACMAJFMJAJ, LOOJMKCMMDI FPAICILAIBH);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AMOFBKBMFBA BAEKFKLCFOM(AMOFBKBMFBA NACMAJFMJAJ, [Optional] float3? MCPNOOFMAHG, [Optional] quaternion? GLKHDAMNPBA, [Optional] float3? ICLEOPHCOMM);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AMOFBKBMFBA BHAACPEMOKK(AMOFBKBMFBA NACMAJFMJAJ, int PDMMEDBMFPP, [Optional] float3? MCPNOOFMAHG, [Optional] quaternion? GLKHDAMNPBA, [Optional] float3? ICLEOPHCOMM);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PMDEECACAFL(AMOFBKBMFBA NACMAJFMJAJ, int PDMMEDBMFPP);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DLDDFPLANMH(AMOFBKBMFBA NACMAJFMJAJ);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface AHIJFMNMMHF
{
	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CHCPOLKCLKK();

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LMCBMMBEOMN();

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HOAAAAIFBJA();

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GGDCBOLJLPI();

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JPMCJNNLLMK();

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CNLDNDDCKON();

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IHHBGKHJGCJ();

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HMNNFAAJJPC();

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JMEOCBLNINC();

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CNLIAMDBNIJ();

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PHJJHOPEMPG();

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LLKNACMOJOO();

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NNCFAGJPLDB();
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface PNKHCKOJKBK
{
	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KBELCKAGLGH(AMOFBKBMFBA PABFDMCLKCE, [Out] int CAAMCMKANHA);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AHKAMGIONBN(AMOFBKBMFBA PABFDMCLKCE, int CAAMCMKANHA);

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IAPGODLJCKG(AMOFBKBMFBA PABFDMCLKCE, bool AKKNAKBNOJO);

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GOPEFMPLEKO(AMOFBKBMFBA PABFDMCLKCE, bool AMONBMJDMFG);

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LKPGLHMBKMM(AMOFBKBMFBA PABFDMCLKCE, float KMCCPDKDMJF, float DMIFPNBKJHL, float FNNMMAECCGN);

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BMGFJNAKLGH(AMOFBKBMFBA NACMAJFMJAJ, [Out] float DMIFPNBKJHL, [Out] float FNNMMAECCGN);

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FLAOCLLBJIJ(AMOFBKBMFBA PABFDMCLKCE, float3 MCPNOOFMAHG, quaternion GLKHDAMNPBA);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool ODJLFBEKDGB(AMOFBKBMFBA PABFDMCLKCE, [Out] float3 MCPNOOFMAHG, [Out] quaternion GLKHDAMNPBA);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface BDNDDDCPNMG
{
	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DHGNKGHCNEH(Entity PIKIMHFFNIJ);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEJCIOEKOAH(Entity PIKIMHFFNIJ, [In] float3 DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 MCHLPMJIEBO(Entity PIKIMHFFNIJ);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LEBFIMGCNJA(Entity PIKIMHFFNIJ, [In] quaternion DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion LBHPDNMHJME(Entity PIKIMHFFNIJ);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CEOOLDFGPJG(Entity PIKIMHFFNIJ, [In] float3 MCPNOOFMAHG, [In] quaternion GLKHDAMNPBA);

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BAIKOIGIPCE(Entity PIKIMHFFNIJ, [Out] float3 MCPNOOFMAHG, [Out] quaternion GLKHDAMNPBA);

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BAIKOIGIPCE(Entity PIKIMHFFNIJ, [Out] RigidTransform CLBGONPGPIE);

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JICDKMGJGHH(Entity PIKIMHFFNIJ, [Out] float3 MCPNOOFMAHG, [Out] quaternion GLKHDAMNPBA);

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JICDKMGJGHH(Entity PIKIMHFFNIJ, [Out] RigidTransform CLBGONPGPIE);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float3 FCJFDCIGIOP(Entity PIKIMHFFNIJ);

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HFEMHPAJJJD(Entity PIKIMHFFNIJ, [In] float3 DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PLDMJEPHOAM(Entity PIKIMHFFNIJ, float DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float IJBAACEMPMA(Entity PIKIMHFFNIJ);

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KODIOHLHFLP(Entity PIKIMHFFNIJ, [In] float3 DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 HDPLPMJNIEO(Entity PIKIMHFFNIJ);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OIODDFCHNMD(Entity PIKIMHFFNIJ, [In] float3 DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 PDKKGFHECIF(Entity PIKIMHFFNIJ);

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FKGHPOEHKBP(Entity PIKIMHFFNIJ, [In] quaternion DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "19")]
	quaternion KHEBDOILJDE(Entity PIKIMHFFNIJ);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 AFIKLKGFLMC(Entity PIKIMHFFNIJ);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void OEJDCIMDCIB(Entity PIKIMHFFNIJ, [In] float3 DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void CKFMEOHLHMH(Entity PIKIMHFFNIJ, float DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float LFHNBCHABCH(Entity PIKIMHFFNIJ);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FANCAEIHIOI(Entity PIKIMHFFNIJ, [In] float3 DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float3 HGPDINNFDNB(Entity PIKIMHFFNIJ);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LJEBFBPIAHK(Entity PIKIMHFFNIJ, [Out] float4x4 GCKKDKDKEHM);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void JLMKLLJOHCE(Entity PIKIMHFFNIJ, [In] float4x4 GCKKDKDKEHM);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void GBIJNLNDDMA(Entity PIKIMHFFNIJ, [Out] float4x4 GCKKDKDKEHM);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool AOPEJDJHEKP(Entity PIKIMHFFNIJ, [Out] Transform AFJHLFMCCIJ);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void MLPKCOBNCCP(Entity PIKIMHFFNIJ);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void LCBKJJEDCGB(Entity PIKIMHFFNIJ, Entity NFMEBFLLGBC, Entity MBKJJMHGOEE);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class BENGNDDIENP
{
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface CADBJKMBAOO
{
	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PFJIENPMHHH(bool KBMCAOCOMKD);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface LIDPEMHAECJ
{
	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OELLDBCGDAN(AMOFBKBMFBA PMPEHAMBEGA, IEnumerable<string> FGPDHFALOFH);

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IDAKKJCFGCI(AMOFBKBMFBA PMPEHAMBEGA, IEnumerable<string> FGPDHFALOFH);

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JCBNEPHBKDE(AMOFBKBMFBA PMPEHAMBEGA, params string[] FGPDHFALOFH);

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OADKPMGJLPG(AMOFBKBMFBA PMPEHAMBEGA, params string[] FGPDHFALOFH);

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ENOAIFINMFC(AMOFBKBMFBA PMPEHAMBEGA, params string[] FGPDHFALOFH);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MHNDPOBAOEN(AMOFBKBMFBA PMPEHAMBEGA, params string[] FGPDHFALOFH);

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int DANNIADOOLH(AMOFBKBMFBA PMPEHAMBEGA);

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int LEOLLGLGEPL(AMOFBKBMFBA PMPEHAMBEGA);

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LHPPDGPDLBO(AMOFBKBMFBA PMPEHAMBEGA, ICollection<string> HMLDCDLIOFC);

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NODFCPGMOBG(AMOFBKBMFBA PMPEHAMBEGA, ICollection<string> HMLDCDLIOFC);

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool ALGNOBLBIGB(AMOFBKBMFBA PMPEHAMBEGA, string CMJCNJNCICI);

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MMEGDBONNLJ(string CMJCNJNCICI, JILGHDIEPCE CLNBPGAJNLE);

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CPDNGPIHOEM(string CMJCNJNCICI, JILGHDIEPCE CLNBPGAJNLE);

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool MINEKKKHLOB();

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LGLGJFBKILN(IEnumerable<string> FGPDHFALOFH);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface DCDKOHLJHBE
{
	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World KJIAHEFGDKD(string OEBPECJFMOI = "Main");

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World MHPDJAKOCIG(string OEBPECJFMOI = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World GNOIBOPKCIJ(string OEBPECJFMOI = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World PIMIJGLIGGH(string OEBPECJFMOI = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface JBDAPNANMGI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000198")]
	World FAKDLANGEDG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	World ADMIOFBADIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	EntityManager PJGELPMLNAK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	bool DBIJCBPOGNN
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase MIIHJHLAEAJ(Type GOAECDHCJMK);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class GIHGKLMJJFO
{
	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x6B0BC10", Offset = "0x6B0A210", VA = "0x186B0BC10")]
	public static ComponentSystemBase KMGJDGNBLMM(this World DBIMBFMCJCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x2B95E40", Offset = "0x2B94440", VA = "0x182B95E40")]
	public static T MIIHJHLAEAJ<T>(this JBDAPNANMGI KNKEDIHDCDK) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface CHMIBBPLCNK
{
	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDHEDAGPPLK(NativeListAsync<Entity> BLLNHEBPDEG);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MOBCPKNLIIC(LMOPMEIHOAA HINANDMGLAO);

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OAJNNFAOBIN(NativeListAsync<Entity> DNFMPFHACNO, bool PGMFMIGDENJ);

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AGLHBBDIFAM();
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface CGMJEDMLICD
{
	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HJLCCOONOLA(Collider LHLDOGJGFAN, [Out] BKDKGDOMJML BLJINIOHMLF);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface KIPFHHKIEAH
{
	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ELGFAPLCPCC(AMOFBKBMFBA NACMAJFMJAJ, [Out] Collider LHLDOGJGFAN);

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject KPANCJFNHHK(AMOFBKBMFBA LCHJKKHGAHJ, GameObject KBOBDAFPJFJ, Vector3 DJCNMBEIKME, Quaternion CAANIPGJBEP);

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MCHOELAIPAN(GameObject LHLDOGJGFAN);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider NEHOBLCMNGP<TCollider>(GameObject GIKDPOFAKMC) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ELIDGJPHMCE(Collider LHLDOGJGFAN);

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject PLOHEADAOPM<TCollider>(string GJEDHMJMNJA) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public enum HHEBKHBDIDP
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface LPKNGKDHHJK
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public struct DEAOFBFICFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int DIEHMJOAIJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public GameObject KBOBDAFPJFJ;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIHDIGKPJEJ(AMOFBKBMFBA NACMAJFMJAJ, IHPNPIHEBNC NMCPNENDFHH, bool IKKKMHNMFPK, DGLLELHCEGN EILAMAHBGIP);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NELAKOOAGEB(AMOFBKBMFBA NACMAJFMJAJ, IHPNPIHEBNC NMCPNENDFHH, bool IKKKMHNMFPK, bool FCGNGGOEKHH, bool IIKBIAMFNEA);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PFJBPOOKBAD CCNFCFDNEJD(AMOFBKBMFBA OPJBDKMKMOF, List<AMOFBKBMFBA> ELMFAOKCFBK);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CIHHECCMNKD(GameObject PCFHDIEECHI, GameObject FGADCHAGEHK);

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NPKGJACNDDJ(GameObject PCFHDIEECHI, [In] GKFBNGBAJIH<GameObject> KMCEJGENACA);

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FPMFCCHEDFL(GameObject FGADCHAGEHK);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T NEHOBLCMNGP<T>(GameObject GIKDPOFAKMC) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ELIDGJPHMCE(Collider LHLDOGJGFAN);

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CHBCOCHCBJJ(DBDGEDGIEPP NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NLJNIBOBONK(DBDGEDGIEPP NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GameObject BDFJELPPMEG<T>(string GJEDHMJMNJA) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FEGEBJJOBCN(Collider LHLDOGJGFAN, [Out] AMOFBKBMFBA CAAMCMKANHA);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool ICEGIAEBGAD(AMOFBKBMFBA NACMAJFMJAJ, [Out] BKDKGDOMJML BLJINIOHMLF);

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<HHEBKHBDIDP> IEBAMNGEMCE(Allocator KOIILCBLJPK = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Mesh[] EFIHLLHDFKI();

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int HKKJLHJBEDB(IHPNPIHEBNC NMCPNENDFHH);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string DGDMGECMPEC(IHPNPIHEBNC NMCPNENDFHH);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface DBNDJNGKIIM
{
	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FNDDDBCIJKM(AMOFBKBMFBA NACMAJFMJAJ, AMOFBKBMFBA DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCLEIOPKKPI(AMOFBKBMFBA NACMAJFMJAJ, AMOFBKBMFBA DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int BLDLMBNBMLF(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AMOFBKBMFBA HOPIJKGEJHM(AMOFBKBMFBA NACMAJFMJAJ, int PDMMEDBMFPP);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DBDGEDGIEPP JAHLHODEPBF(AMOFBKBMFBA NACMAJFMJAJ, Allocator KOIILCBLJPK = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MOILNMLIKGJ(AMOFBKBMFBA NACMAJFMJAJ, object NJLOKHEKBBE, AMOFBKBMFBA DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IMEINEHFOAO(AMOFBKBMFBA NACMAJFMJAJ, object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MDEOKEDCHEK(AMOFBKBMFBA NACMAJFMJAJ, [Out] AMOFBKBMFBA DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KJAEFJFPNLA(AMOFBKBMFBA NACMAJFMJAJ, float3 DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool EKHIMMJFAGD(AMOFBKBMFBA NACMAJFMJAJ, [Out] float3 DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ONHEMFFJMHK(AMOFBKBMFBA NACMAJFMJAJ, float3 DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool JIGAPDLGJPA(AMOFBKBMFBA NACMAJFMJAJ, [Out] float3 DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DDFFAEKFDCA(AMOFBKBMFBA NACMAJFMJAJ, (Quaternion rot, Vector3 moments) IIIBFELFAJH);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool NAPCCDABNAN(AMOFBKBMFBA NACMAJFMJAJ, [Out] quaternion HPAIEAFGHDJ, [Out] float3 GCBADBLJAKA);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NEFLOBAJPOM(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 PEAEAAOIGNJ(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 NBEFHDGGIMM(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DPGLPMPKCJC(AMOFBKBMFBA NACMAJFMJAJ, float3 DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EMKBIDDPCBE(AMOFBKBMFBA NACMAJFMJAJ, float3 DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float HCNPGHNFDNC(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float FCNMCDHEGNE(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void HFGLBJBGBJO(AMOFBKBMFBA NACMAJFMJAJ, float DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JEDGFFOIGEB(AMOFBKBMFBA NACMAJFMJAJ, float DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode NHJPMKBFDCA(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FJMOOAGIMJE(AMOFBKBMFBA NACMAJFMJAJ, CollisionDetectionMode DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "25")]
	IBJOHPGNLAO BOHIMMBBBCM(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void MOBACPLNLFC(AMOFBKBMFBA NACMAJFMJAJ, IBJOHPGNLAO DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool BDEKDLOEAPF(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void BMAJGMGNFLL(AMOFBKBMFBA NACMAJFMJAJ, bool DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "29")]
	AMOFBKBMFBA GINOAKPCJIH(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void PKLJEDEGLBF(AMOFBKBMFBA NACMAJFMJAJ, AMOFBKBMFBA DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "31")]
	AMOFBKBMFBA AFHOOHJCNBG(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void GOPGAHCPBFG(AMOFBKBMFBA NACMAJFMJAJ, AMOFBKBMFBA DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "33")]
	JLMNFBGGGIJ GHCPMCPEKIP(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void EINAMMJBDKF(AMOFBKBMFBA NACMAJFMJAJ, JLMNFBGGGIJ DDPEKAFJBCD);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool MAILCEAPDHO(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void OOMFKDKLLIH(AMOFBKBMFBA NACMAJFMJAJ, bool DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool KKPLIGEJEBK(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void HAHEDBOCKAF(AMOFBKBMFBA NACMAJFMJAJ, bool DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints GKOMMFGMCOK(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void PAHIFPGCBBI(AMOFBKBMFBA NACMAJFMJAJ, RigidbodyConstraints DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float HHHDHJGLCAJ(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void LLPFBDONIHO(AMOFBKBMFBA NACMAJFMJAJ, float DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float LPOFMKPBDMO(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void AHPCIFFHAKJ(AMOFBKBMFBA NACMAJFMJAJ, float DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool HOOFLAOEIOA(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void EDHNPDBOOIB(AMOFBKBMFBA NACMAJFMJAJ, bool DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool DBJBCLMOCKK(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void IBNHMHJKPFN(AMOFBKBMFBA NACMAJFMJAJ, bool DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void ABNBOGBFOLO(AMOFBKBMFBA NACMAJFMJAJ, int DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "50")]
	NGDDLDGNNPG LLIDCHAEBAI(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void DBEAPEDKECC(AMOFBKBMFBA NACMAJFMJAJ, NGDDLDGNNPG DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "52")]
	NDGEFNLJMAC IGIJIFMGGAP(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void POCLEHDGFCN(AMOFBKBMFBA NACMAJFMJAJ, NDGEFNLJMAC DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float IHOHGBNHKDM(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void MNEKMDMCPKI(AMOFBKBMFBA NACMAJFMJAJ, float DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void LCCDNBIEIGD(AMOFBKBMFBA NACMAJFMJAJ, object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void MEFLNEPGJJH(AMOFBKBMFBA NACMAJFMJAJ, object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool HDJOPPIMDME(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void MODCFBFLKKK(AMOFBKBMFBA NACMAJFMJAJ, object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void GCGFAANEJBF(AMOFBKBMFBA NACMAJFMJAJ, object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool EJGMCOKHLOI(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool KFOKKIKFGAN(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody NFBLKIICEAL(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void DCFNEHONICN(AMOFBKBMFBA NACMAJFMJAJ, Rigidbody OBCIJMKFLAO);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void MDCGELNKCEI(AMOFBKBMFBA NACMAJFMJAJ, object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void AHFBOIOGAJP(AMOFBKBMFBA NACMAJFMJAJ, object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool JGNHKKAJPHA(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void MMLFNOCCHGC(AMOFBKBMFBA NACMAJFMJAJ, float3 NPPDGHLPBPO);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void JIJHDGHIEBG(AMOFBKBMFBA NACMAJFMJAJ, float3 CDGJDANICCD);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool FCKFDGEBHHK(AMOFBKBMFBA NACMAJFMJAJ, [Out] float3 NPPDGHLPBPO);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool JBFJJCBDPML(AMOFBKBMFBA NACMAJFMJAJ, [Out] float3 CDGJDANICCD);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool FGABCNCEAKK(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void GFJGBKLIKAA(AMOFBKBMFBA NACMAJFMJAJ, object NJLOKHEKBBE, bool JJAGHLCDGON);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void LINDBMIDKJO(AMOFBKBMFBA NACMAJFMJAJ, bool BMGLHHAFEKF);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void FOGMHAADFCE(AMOFBKBMFBA NACMAJFMJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool BPLGMJCBKGJ(AMOFBKBMFBA NACMAJFMJAJ);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface FOPPBAIOLLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KJMMGNMPKDK(Entity FHBPMPGINLC);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EKKNJPOINKM(Entity FHBPMPGINLC);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface FDMODKPMNMC
{
	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAFKHBCLMHF(AMOFBKBMFBA PABFDMCLKCE, bool LLJCAELNPHH);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OONLNPNACFJ(AMOFBKBMFBA PABFDMCLKCE, int BHJAKHNNONP);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public delegate void FKFPJHELPIO(MEECLHGDEMK GKHNKFGHEMI);
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public readonly struct MEECLHGDEMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly DBDGEDGIEPP NGGFHOBBAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly NativeArray<byte> OIOFNFIMBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly NativeArray<byte> GHGACMKFPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly DANIGNOCLDL KKEFBAKIJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly int NDGNPPALKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly Type GBLBAOCMKOK;

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	public DBDGEDGIEPP FHALFPLMFBC
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0xAB3E20", Offset = "0xAB2420", VA = "0x180AB3E20")]
		get
		{
			return default(DBDGEDGIEPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x6B11BF0", Offset = "0x6B101F0", VA = "0x186B11BF0")]
	public MEECLHGDEMK(DBDGEDGIEPP NGGFHOBBAGK, NativeArray<byte> OIOFNFIMBBM, NativeArray<byte> GHGACMKFPJI, DANIGNOCLDL KKEFBAKIJFE, int NDGNPPALKED, Type GBLBAOCMKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F6E0", Offset = "0x2C6DCE0", VA = "0x182C6F6E0")]
	public NativeArray<T> PLPDJJNMCPK<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F6A0", Offset = "0x2C6DCA0", VA = "0x182C6F6A0")]
	public NativeArray<T> IMOLPICHMGB<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F5B0", Offset = "0x2C6DBB0", VA = "0x182C6F5B0")]
	public (DBDGEDGIEPP, NativeArray<T>, NativeArray<T>) FOHHCFMHKPE<T>() where T : struct
	{
		return default((DBDGEDGIEPP, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x6B11BA0", Offset = "0x6B101A0", VA = "0x186B11BA0")]
	public ONPCMLCFACA OFNKHOPGFGO()
	{
		return default(ONPCMLCFACA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface MBEFNFGCNPP
{
	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	string PAMIPHGKJCG
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	MBEFNFGCNPP JKCGCBKHDPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	IEnumerable<MBEFNFGCNPP> HGNHAPPBMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface KNBHBBCBFGJ
{
	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	MBEFNFGCNPP GEOFOFHMOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	List<HCFBPDIOPOA> HMJJEAMGMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AMLECANOEFO(HCFBPDIOPOA FDKAIMCLOIA, [Out] MBEFNFGCNPP AMNPFAMIOOO);

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NECNOABNHFL(HCFBPDIOPOA FDKAIMCLOIA, FKFPJHELPIO OJLKOKAFLOI);

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JDBODJEEEFF(HCFBPDIOPOA FDKAIMCLOIA, FKFPJHELPIO OJLKOKAFLOI);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public readonly struct ONPCMLCFACA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly MEECLHGDEMK MMDLBEBNCGC;

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public DBDGEDGIEPP FHALFPLMFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0xAB3E20", Offset = "0xAB2420", VA = "0x180AB3E20")]
		get
		{
			return default(DBDGEDGIEPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x6B14010", Offset = "0x6B12610", VA = "0x186B14010")]
	public ONPCMLCFACA(MEECLHGDEMK MMDLBEBNCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x6B13F40", Offset = "0x6B12540", VA = "0x186B13F40")]
	public DBDGEDGIEPP PLPDJJNMCPK()
	{
		return default(DBDGEDGIEPP);
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x6B13E70", Offset = "0x6B12470", VA = "0x186B13E70")]
	public DBDGEDGIEPP IMOLPICHMGB()
	{
		return default(DBDGEDGIEPP);
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x6B13D50", Offset = "0x6B12350", VA = "0x186B13D50")]
	public (DBDGEDGIEPP, DBDGEDGIEPP, DBDGEDGIEPP) FOHHCFMHKPE()
	{
		return default((DBDGEDGIEPP, DBDGEDGIEPP, DBDGEDGIEPP));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
[DefaultMember("Item")]
public interface MMLNALGCHNO : IEnumerable<EKPIOBJJCMP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	NativeBitArray JJFOKCHCHPH
	{
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	NativeBitArray FIAJBGMAOBL
	{
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	NativeArray<int> FMDFGHCDMED
	{
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	EKPIOBJJCMP CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	EKPIOBJJCMP CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EKPIOBJJCMP DDEHKHPBIBD(OBIBKJANHBG BHPJGALIOMC);

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DANIGNOCLDL BHIKEGHAGNA(OBIBKJANHBG BHPJGALIOMC);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class GCNDPEIFGMN
{
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[DefaultMember("Item")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface AGBIPLKPHNK : IEnumerable<HCFNAONHOIP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	HCFNAONHOIP CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HCFNAONHOIP DDEHKHPBIBD(OBIBKJANHBG BHPJGALIOMC);

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DANIGNOCLDL BHIKEGHAGNA(OBIBKJANHBG BHPJGALIOMC);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class NJLMLBAFBAC
{
	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x2CD9190", Offset = "0x2CD7790", VA = "0x182CD9190")]
	public static DANIGNOCLDL BHIKEGHAGNA<T>(this AGBIPLKPHNK KPBDIGEGEBF, DJBDLMKHNKL<T> GJEDHMJMNJA) where T : struct
	{
		return default(DANIGNOCLDL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[DefaultMember("Item")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface MFADFLFDMDG : IEnumerable<HCFBPDIOPOA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	HCFBPDIOPOA CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HCFBPDIOPOA DDEHKHPBIBD(OBIBKJANHBG BHPJGALIOMC);

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DANIGNOCLDL BHIKEGHAGNA(OBIBKJANHBG BHPJGALIOMC);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class CEEKBONHCKJ
{
	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x29A4B50", Offset = "0x29A3150", VA = "0x1829A4B50")]
	public static LLCOHDGDCHM<T> DDEHKHPBIBD<T>(this MFADFLFDMDG KPBDIGEGEBF, OBIBKJANHBG GJEDHMJMNJA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x29A45B0", Offset = "0x29A2BB0", VA = "0x1829A45B0")]
	public static DANIGNOCLDL BHIKEGHAGNA<T>(this MFADFLFDMDG KPBDIGEGEBF, DJBDLMKHNKL<T> GJEDHMJMNJA) where T : struct
	{
		return default(DANIGNOCLDL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface LBKLDIKNPDP
{
	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NECNOABNHFL(OBIBKJANHBG FDKAIMCLOIA, FKFPJHELPIO OJLKOKAFLOI);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JDBODJEEEFF(OBIBKJANHBG FDKAIMCLOIA, FKFPJHELPIO OJLKOKAFLOI);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class IFIBJHMHNAE
{
	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x2BC4B70", Offset = "0x2BC3170", VA = "0x182BC4B70")]
	public static void NECNOABNHFL<T>(this LBKLDIKNPDP GNDLHFCECAB, DJBDLMKHNKL<T> FDKAIMCLOIA, FKFPJHELPIO OJLKOKAFLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x2BC47E0", Offset = "0x2BC2DE0", VA = "0x182BC47E0")]
	public static void JDBODJEEEFF<T>(this LBKLDIKNPDP GNDLHFCECAB, DJBDLMKHNKL<T> FDKAIMCLOIA, FKFPJHELPIO OJLKOKAFLOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface LEAFHEKAMOO
{
	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	BJJAIFDBJMO LALOMHEIMED
	{
		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IDDIGFHACLA(KJCIFKAMOBH FAOMEEFLJBM, DANIGNOCLDL FDKAIMCLOIA);

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LPCFCBNNFOB(KJCIFKAMOBH FAOMEEFLJBM, Span<DANIGNOCLDL> KPBDIGEGEBF, bool DNFEFPNNFOJ);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FNABAMFCIDK(NativeArray<KJCIFKAMOBH> EBMBOEDMFIM);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class JKJPLNIGBBF
{
	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x6B0F250", Offset = "0x6B0D850", VA = "0x186B0F250")]
	public static void LPCFCBNNFOB(this LEAFHEKAMOO DAAIIPMFNAM, KJCIFKAMOBH FAOMEEFLJBM, DANIGNOCLDL FDKAIMCLOIA, bool DNFEFPNNFOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public readonly struct BJJAIFDBJMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly NativeBitArray CGAPLOAAKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly NativeParallelHashMap<KJCIFKAMOBH, int> OIHMDNJFPKG;

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public bool FKKNICKBACF
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x6B05AB0", Offset = "0x6B040B0", VA = "0x186B05AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x42AFCF0", Offset = "0x42AE2F0", VA = "0x1842AFCF0")]
	public BJJAIFDBJMO(NativeBitArray CGAPLOAAKPO, NativeParallelHashMap<KJCIFKAMOBH, int> OIHMDNJFPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x6B05980", Offset = "0x6B03F80", VA = "0x186B05980")]
	public bool IDDIGFHACLA(KJCIFKAMOBH FAOMEEFLJBM, DANIGNOCLDL FDKAIMCLOIA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface KOPEPOFAAGG
{
	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GLFPKENJFBK(AMOFBKBMFBA NACMAJFMJAJ, KDNOALABLGK DMNGPNKHPKF);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface GLPLHMPDBLI
{
	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	IAHLCGIKAIA NAJMAFOEEAA
	{
		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface LJDINIMBGJD
{
	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJLPFKIPBCM(World DBIMBFMCJCE);

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJKAPILHCGD(World DBIMBFMCJCE);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase KLPKPDGONFJ(World DBIMBFMCJCE);

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HNKPLFLJCPA(World DBIMBFMCJCE);

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IICMHJHNBHD(World DBIMBFMCJCE);

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HHFELEKFLMP(World DBIMBFMCJCE);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[DBIJOBJFKFD(OFPDOPBEGLP.LoadInstance)]
public interface JEHHKJPHPPM
{
	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DLADGKOOLCE(AMOFBKBMFBA OOLEDFCEFHP, bool DMNGPNKHPKF);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public readonly struct DAEGJPIAPJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly IEnumerable<JJDFDCMKAAP> HCLIJPBLHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly IReadOnlyList<GameObject> GFLPFFJBHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IReadOnlyList<int> KNJLJENKEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly IReadOnlyList<(KJCIFKAMOBH, KJCIFKAMOBH)> FGAJOMHGBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly int OKBLBFNNLIP;

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public bool IPGIKMPLLND
	{
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x6B069E0", Offset = "0x6B04FE0", VA = "0x186B069E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public int LBKMJNFLDBL
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x8F0D30", Offset = "0x8EF330", VA = "0x1808F0D30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public IEnumerable<GameObject> HOGCJDOPGOI
	{
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x8FA820", Offset = "0x8F8E20", VA = "0x1808FA820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public IEnumerable<(KJCIFKAMOBH src, KJCIFKAMOBH dst)> JPNLMAFKMLA
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x6B06DD0", Offset = "0x6B053D0", VA = "0x186B06DD0")]
	public DAEGJPIAPJH(IEnumerable<JJDFDCMKAAP> HCLIJPBLHOP, IReadOnlyList<GameObject> GFLPFFJBHCA, IReadOnlyList<int> KNJLJENKEFE, IReadOnlyList<(KJCIFKAMOBH src, KJCIFKAMOBH dst)> FGAJOMHGBAO, int OKBLBFNNLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x6B06A40", Offset = "0x6B05040", VA = "0x186B06A40")]
	public (GameObject, int)[] LCJGPLKKNDP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface DJFGBIHFJCF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	bool EEOGJAILHHA
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	bool HGGIFMGKIIC
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	LBEBAPHEOPM DDDNINGOBLP
	{
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EPLBLNLNMGA JHDPODDEEOO();

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EPLBLNLNMGA BOGAGCIBAAF(IEnumerable<AMOFBKBMFBA> NAKHKAGBEGC, [In] UniformTRS FFCOIJHGIHB);

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AJNBKMDOFNC PJLKDKGDKFO(ByteString CMEJLLBGMFK);

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IHBJLHIABNN CIFGAEFJFKL(ByteString EABGAFLLHMP, AMOFBKBMFBA PPEEAFEPIIK, [In] UniformTRS GFPHEEFHMNK, FMHCGNACFMC PBCBMDJMJMK, bool CEPCJFJPBLI = true);

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GEPGNNKPIML();

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DAEGJPIAPJH BGJKGBCIMDH(IEnumerable<JJDFDCMKAAP> HCLIJPBLHOP);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class EGCLAICIHBA
{
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface INBKDHFHPCD
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action DMPFLIDKNOM;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action COLAMNNDGEK;
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public struct CMGFGKEDLMC : CIFFJCAGIEN, IEquatable<CMGFGKEDLMC>
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public static readonly int JHFIDOBMICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public IDEDIMNMLPE MDDJDHCOALA;

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x6B06530", Offset = "0x6B04B30", VA = "0x186B06530", Slot = "5")]
	public void OJPHNAHFOOE(JDHBHMPEGEO MMDEOFGAFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x6B06560", Offset = "0x6B04B60", VA = "0x186B06560", Slot = "4")]
	public void PEGIGFCKLEH(FMNOKOIDCFD JFIDOOOHFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x6B06590", Offset = "0x6B04B90", VA = "0x186B06590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0xA44B60", Offset = "0xA43160", VA = "0x180A44B60", Slot = "6")]
	public bool Equals(CMGFGKEDLMC BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x6B06490", Offset = "0x6B04A90", VA = "0x186B06490", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0xAAF730", Offset = "0xAADD30", VA = "0x180AAF730", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public struct JJDFDCMKAAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Guid IJNLNGBKEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public string ALGLCCEBAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Vector3 MCPNOOFMAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Quaternion GLKHDAMNPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Vector3 ICLEOPHCOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int MGCLKILMNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public Dictionary<string, object> FPAICILAIBH;

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x6B0EF60", Offset = "0x6B0D560", VA = "0x186B0EF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x6B0EDD0", Offset = "0x6B0D3D0", VA = "0x186B0EDD0")]
	private static string KOMNLCIGAPP(Dictionary<string, object> JDGKLLKEGLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public enum CPKJFKEBCMF
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	SubGraphReplace,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	RestoreCreationData
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class DKDEGHCDBAP
{
	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x5F10120", Offset = "0x5F0E720", VA = "0x185F10120")]
	public static bool DKBECMDGBEA(this CPKJFKEBCMF GOAECDHCJMK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[Flags]
public enum AMHCAKHCOAA
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	WorldPhasesMaster = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	AdditivePhases = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public interface IHBJLHIABNN : LBEBAPHEOPM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	FMHCGNACFMC NEFEPFBADPG
	{
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKNNLLCHPCG();

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JFCDGBPECBI();
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public interface LBEBAPHEOPM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	IEnumerable<JJDFDCMKAAP> KJHLGJHDBMG
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	DAEGJPIAPJH DNBFKAGDOGD
	{
		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	CPKJFKEBCMF LADEKBPIHJB
	{
		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	LocalId KGFGIGLCOCB
	{
		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	HLFHOIANENN BLPOPOAMCGP
	{
		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PAIJEEONJHA(AMHCAKHCOAA FHKEJEOFAPI);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface FMHCGNACFMC
{
	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FDPLMFPNBPC(Guid MBEDFGIGBHI, [Out] Guid KEDMKHAFLGK);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public interface AJNBKMDOFNC : LBEBAPHEOPM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[Flags]
public enum OLCJGHPAEME
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public interface EPLBLNLNMGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	HLFHOIANENN JFDCPCKBIDE
	{
		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString BPMIPNDNIBK();
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public enum JNAPOCPPLPI
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public delegate bool DDMDEJLFBID(GONMJLCNGEE CKMEJLMDPJN, [In] FIEGLLHKFJI DMNGPNKHPKF);
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public delegate bool HPCPEDEDHNO<T>(GONMJLCNGEE CKMEJLMDPJN, [In] T DMNGPNKHPKF);
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface MOKBKBEDPGK
{
	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NECNOABNHFL(DANIGNOCLDL KKEFBAKIJFE, Type KHBLNMAOCGA, DDMDEJLFBID FCIPKKFKLLG);

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NEGCCNIELAG(DANIGNOCLDL KKEFBAKIJFE, [Out] DDMDEJLFBID FCIPKKFKLLG);
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class NNAHOJBACMD
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class HPIECMIBCCO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public HPCPEDEDHNO<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public HPIECMIBCCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x3DBA520", Offset = "0x3DB8B20", VA = "0x183DBA520")]
		internal bool MIKNNNADLLG(GONMJLCNGEE pendingList, [In] FIEGLLHKFJI value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x2CD9F90", Offset = "0x2CD8590", VA = "0x182CD9F90")]
	public static void NECNOABNHFL<T>(this MOKBKBEDPGK GNDLHFCECAB, DANIGNOCLDL KKEFBAKIJFE, HPCPEDEDHNO<T> FCIPKKFKLLG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x6B12EE0", Offset = "0x6B114E0", VA = "0x186B12EE0")]
	public static bool AKFFGIJKCNE(this MOKBKBEDPGK GNDLHFCECAB, GONMJLCNGEE CKMEJLMDPJN, DANIGNOCLDL KKEFBAKIJFE, [In] FIEGLLHKFJI DMNGPNKHPKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface IMGKCGEIPOA
{
	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	uint LKJDCAFHBAL
	{
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface GONMJLCNGEE
{
	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBOLIEGMBGF(KJCIFKAMOBH PHACLLNPAHE, DANIGNOCLDL KKEFBAKIJFE, ReadOnlySpan<byte> DBFDHFABMBE, ReadOnlySpan<byte> IPDPHOBFLHD);

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GEDJBGFGGAM(KJCIFKAMOBH PHACLLNPAHE, DANIGNOCLDL KKEFBAKIJFE, ReadOnlySpan<byte> DBFDHFABMBE, ReadOnlySpan<byte> IPDPHOBFLHD);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JAJMHAAMBIL(KJCIFKAMOBH PHACLLNPAHE, DANIGNOCLDL KKEFBAKIJFE);

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FCJGHMAMMEF(KJCIFKAMOBH PHACLLNPAHE, DANIGNOCLDL KKEFBAKIJFE, ReadOnlySpan<byte> IPDPHOBFLHD);

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OIEKHABADKE(KJCIFKAMOBH PHACLLNPAHE, DANIGNOCLDL KKEFBAKIJFE, Span<byte> DBFDHFABMBE, Span<byte> IPDPHOBFLHD);
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public static class KDIJOGANGHM
{
	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x2C354E0", Offset = "0x2C33AE0", VA = "0x182C354E0")]
	public static bool OIEKHABADKE<T>(this GONMJLCNGEE HMAEGBCDDNF, KJCIFKAMOBH PHACLLNPAHE, DANIGNOCLDL KKEFBAKIJFE, [Out] T DBFDHFABMBE, [Out] T IPDPHOBFLHD) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x2C353A0", Offset = "0x2C339A0", VA = "0x182C353A0")]
	public static bool FCJGHMAMMEF<T>(this GONMJLCNGEE HMAEGBCDDNF, KJCIFKAMOBH PHACLLNPAHE, DANIGNOCLDL KKEFBAKIJFE, T IPDPHOBFLHD) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public enum PBBMPJPLJPN
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	End,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface GLLMDHOJOAL
{
	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACAMGLCPHEJ(FMCOBICOLLH MADFKNCBFBG, ReadOnlySpan<byte> OGADPHAKNMI);

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJEAGOBBMGE(uint IJHMFIPHMLJ, ReadOnlySpan<byte> OGADPHAKNMI);

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MLBHJDKNMJO(int PIMKLGPIIND);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface DBIMGBNEHLO
{
	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FMCOBICOLLH DMDELOFJJLC(ReadOnlySpan<byte> OGADPHAKNMI);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface FPFHCILOMPM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KFJLAOBHJNI(FMCOBICOLLH IBBDLGCDELM, ReadOnlySpan<byte> OGADPHAKNMI);

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CKFIMNDNCPB(ReadOnlySpan<FMCOBICOLLH> CAEJFPIELEE);
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public struct GLBCDPPPCCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public FMCOBICOLLH MADFKNCBFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public ReadOnlyMemory<byte> OGADPHAKNMI;
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public struct FMCOBICOLLH
{
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static FMCOBICOLLH KOMBOMBFCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public uint BMDIOLCKPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public int DEIDIBFCMAE;

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0xC84530", Offset = "0xC82B30", VA = "0x180C84530")]
	public FMCOBICOLLH(uint BMDIOLCKPIJ, int DEIDIBFCMAE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B6E0", Offset = "0x6B09CE0", VA = "0x186B0B6E0")]
	public static bool FFOLOHFBIHN([In] FMCOBICOLLH OIMGCNDKIAD, [In] FMCOBICOLLH LMBIFCGLAFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B630", Offset = "0x6B09C30", VA = "0x186B0B630", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B710", Offset = "0x6B09D10", VA = "0x186B0B710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B740", Offset = "0x6B09D40", VA = "0x186B0B740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B700", Offset = "0x6B09D00", VA = "0x186B0B700")]
	public void FPPGGEMJOOL([Out] uint BMDIOLCKPIJ, [Out] int DEIDIBFCMAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[DBIJOBJFKFD(OFPDOPBEGLP.OMRoom)]
public interface NDDADKLPNLI : FIIGDADBHFB<NDDADKLPNLI>
{
	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EGCGJKFAAFH(DANIGNOCLDL DAIJJLLIENA, [Out] IBKADGOCNHG JBDHPKKOEHC);
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public static class GNONPGELHBL
{
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public interface IBKADGOCNHG
{
	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	Type MGDLNFGDJNM
	{
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OJPHNAHFOOE(JDHBHMPEGEO MMDEOFGAFEK, Span<byte> PABFDMCLKCE);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PEGIGFCKLEH(FMNOKOIDCFD JFIDOOOHFIL, ReadOnlySpan<byte> MADFKNCBFBG);
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public static class MFLKOABCLLB
{
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public struct CEAGKMBBGGO : ISystemStateComponentData, IComponentData, IEquatable<CEAGKMBBGGO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float3 PNNIPMJPEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public float3 OOJCLNIKJCF;

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x6B05D10", Offset = "0x6B04310", VA = "0x186B05D10", Slot = "4")]
	public bool Equals(CEAGKMBBGGO BHFGHGMPKOJ)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public class DGOGLIDKJLN
{
	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public DGOGLIDKJLN()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
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
