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
	public class LogRegistrationIndex : GEPCMJPGCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x70B2A60", Offset = "0x70B1260", VA = "0x1870B2A60", Slot = "4")]
		public override void CCEDGNHHKOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KIBECBHGHDI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x70B1770", Offset = "0x70AFF70", VA = "0x1870B1770")]
	public static void CJAFENGFILM(this Rigidbody IJJCJMLBBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x70B1640", Offset = "0x70AFE40", VA = "0x1870B1640")]
	public static void CJAFENGFILM(this Rigidbody IJJCJMLBBLK, Vector3 PGGEAMEGCLM, Quaternion CCMEOENCNOJ, Vector3 FAGNEKCDOBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct DLIACAMIKND : IReadOnlyList<NLPICMPDONC>, IEnumerable<NLPICMPDONC>, IEnumerable, IReadOnlyCollection<NLPICMPDONC>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct NEGOPGACECP : IEnumerator<NLPICMPDONC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly PJJOGJFNMIM HIOGCNEKLDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator DDLDHCJHPPE;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public NLPICMPDONC NEPDGMBEJHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x70B3760", Offset = "0x70B1F60", VA = "0x1870B3760", Slot = "4")]
			get
			{
				return default(NLPICMPDONC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x70B36E0", Offset = "0x70B1EE0", VA = "0x1870B36E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x46D6000", Offset = "0x46D4800", VA = "0x1846D6000")]
		public NEGOPGACECP(PJJOGJFNMIM HIOGCNEKLDG, NativeArray<LocalId>.Enumerator DDLDHCJHPPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x70B3620", Offset = "0x70B1E20", VA = "0x1870B3620", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x70B3660", Offset = "0x70B1E60", VA = "0x1870B3660", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x70B36A0", Offset = "0x70B1EA0", VA = "0x1870B36A0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly PJJOGJFNMIM HIOGCNEKLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> OBBIGKIBBBG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NLPICMPDONC DBNKEBOPCEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x70A67B0", Offset = "0x70A4FB0", VA = "0x1870A67B0", Slot = "4")]
		get
		{
			return default(NLPICMPDONC);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x70A6220", Offset = "0x70A4A20", VA = "0x1870A6220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int AOICIBOPEJE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8B51A0", Offset = "0x8B39A0", VA = "0x1808B51A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public PJJOGJFNMIM KJPEHNEANDN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NALHPIPMEMO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8B51A0", Offset = "0x8B39A0", VA = "0x1808B51A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool BJEHFDDNHKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x70A6300", Offset = "0x70A4B00", VA = "0x1870A6300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> EFDELDINLBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2931ED0", Offset = "0x29306D0", VA = "0x182931ED0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> MIFPGANLNCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x70A6340", Offset = "0x70A4B40", VA = "0x1870A6340")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x70A6600", Offset = "0x70A4E00", VA = "0x1870A6600")]
	public DLIACAMIKND(int DEOEMPAJCCC, PJJOGJFNMIM HIOGCNEKLDG, Allocator MOBIJPCBMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x46D5DC0", Offset = "0x46D45C0", VA = "0x1846D5DC0")]
	public DLIACAMIKND(PJJOGJFNMIM HIOGCNEKLDG, NativeArray<LocalId> OBBIGKIBBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x70A6690", Offset = "0x70A4E90", VA = "0x1870A6690")]
	internal DLIACAMIKND(PJJOGJFNMIM HIOGCNEKLDG, NativeArray<Entity> NFLDGMHEJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x70A6560", Offset = "0x70A4D60", VA = "0x1870A6560")]
	public DLIACAMIKND(PJJOGJFNMIM HIOGCNEKLDG, int OANKAJFHCKB, Allocator MOBIJPCBMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x70A6700", Offset = "0x70A4F00", VA = "0x1870A6700")]
	public DLIACAMIKND(DLIACAMIKND OAOMDEBCNKD, Allocator MOBIJPCBMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x70A6170", Offset = "0x70A4970", VA = "0x1870A6170")]
	public DLIACAMIKND GPGJNKBEMKC(Allocator MOBIJPCBMOB = Allocator.Temp)
	{
		return default(DLIACAMIKND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x70A6130", Offset = "0x70A4930", VA = "0x1870A6130", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x70A6270", Offset = "0x70A4A70", VA = "0x1870A6270")]
	public NEGOPGACECP IGEPHCDGPEC()
	{
		return default(NEGOPGACECP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x70A63A0", Offset = "0x70A4BA0", VA = "0x1870A63A0", Slot = "6")]
	private IEnumerator<NLPICMPDONC> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x70A6480", Offset = "0x70A4C80", VA = "0x1870A6480", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public struct HCJHPMIHCEN : IList<NLPICMPDONC>, ICollection<NLPICMPDONC>, IEnumerable<NLPICMPDONC>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct HIFFNGMICJE : IEnumerator<NLPICMPDONC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly PJJOGJFNMIM HIOGCNEKLDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator DDLDHCJHPPE;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NLPICMPDONC NEPDGMBEJHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x70AF3E0", Offset = "0x70ADBE0", VA = "0x1870AF3E0", Slot = "4")]
			get
			{
				return default(NLPICMPDONC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x70AF360", Offset = "0x70ADB60", VA = "0x1870AF360", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x46D6000", Offset = "0x46D4800", VA = "0x1846D6000")]
		public HIFFNGMICJE(PJJOGJFNMIM HIOGCNEKLDG, NativeArray<LocalId>.Enumerator DDLDHCJHPPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x70AF2A0", Offset = "0x70ADAA0", VA = "0x1870AF2A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x70AF2E0", Offset = "0x70ADAE0", VA = "0x1870AF2E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x70AF320", Offset = "0x70ADB20", VA = "0x1870AF320", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly PJJOGJFNMIM HIOGCNEKLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> OBBIGKIBBBG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NLPICMPDONC DBNKEBOPCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x70AF190", Offset = "0x70AD990", VA = "0x1870AF190", Slot = "4")]
		get
		{
			return default(NLPICMPDONC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x70AF210", Offset = "0x70ADA10", VA = "0x1870AF210", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x70AECD0", Offset = "0x70AD4D0", VA = "0x1870AECD0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int NALHPIPMEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x70AECD0", Offset = "0x70AD4D0", VA = "0x1870AECD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> EFDELDINLBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2931ED0", Offset = "0x29306D0", VA = "0x182931ED0")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool CDFNJCJNLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x70AF070", Offset = "0x70AD870", VA = "0x1870AF070")]
	public HCJHPMIHCEN(int DEOEMPAJCCC, PJJOGJFNMIM HIOGCNEKLDG, Allocator MOBIJPCBMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x70AEFF0", Offset = "0x70AD7F0", VA = "0x1870AEFF0")]
	public HCJHPMIHCEN(PJJOGJFNMIM HIOGCNEKLDG, Allocator MOBIJPCBMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x70AF100", Offset = "0x70AD900", VA = "0x1870AF100")]
	public HCJHPMIHCEN(PJJOGJFNMIM HIOGCNEKLDG, int OANKAJFHCKB, Allocator MOBIJPCBMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x70AE820", Offset = "0x70AD020", VA = "0x1870AE820")]
	public DLIACAMIKND CICNJJJADLI()
	{
		return default(DLIACAMIKND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x70AE8A0", Offset = "0x70AD0A0", VA = "0x1870AE8A0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x70AE8E0", Offset = "0x70AD0E0", VA = "0x1870AE8E0", Slot = "13")]
	public bool Contains(NLPICMPDONC DEDDGCENOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x70AE970", Offset = "0x70AD170", VA = "0x1870AE970", Slot = "14")]
	public void CopyTo(NLPICMPDONC[] GHAIAFELBIF, int KHBFEFGODGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x70AE7A0", Offset = "0x70ACFA0", VA = "0x1870AE7A0", Slot = "11")]
	public void Add(NLPICMPDONC DEDDGCENOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x70AEC20", Offset = "0x70AD420", VA = "0x1870AEC20", Slot = "7")]
	public void Insert(int ECDOOAABOPD, NLPICMPDONC DEDDGCENOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x70AED60", Offset = "0x70AD560", VA = "0x1870AED60", Slot = "15")]
	public bool Remove(NLPICMPDONC DEDDGCENOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x70AEB90", Offset = "0x70AD390", VA = "0x1870AEB90", Slot = "6")]
	public int IndexOf(NLPICMPDONC DEDDGCENOOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x70AED10", Offset = "0x70AD510", VA = "0x1870AED10", Slot = "8")]
	public void RemoveAt(int ECDOOAABOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x70AEAC0", Offset = "0x70AD2C0", VA = "0x1870AEAC0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x70AEB00", Offset = "0x70AD300", VA = "0x1870AEB00")]
	public HIFFNGMICJE IGEPHCDGPEC()
	{
		return default(HIFFNGMICJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x70AEE30", Offset = "0x70AD630", VA = "0x1870AEE30", Slot = "16")]
	private IEnumerator<NLPICMPDONC> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x70AEF10", Offset = "0x70AD710", VA = "0x1870AEF10", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface AKGEKLOCHMK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int JAMMHOLBPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> MEHKDBCGGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NLPICMPDONC HPJHDMBIPGB(NLPICMPDONC OBBIGKIBBBG);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HOLHOCKHPDG : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[ServiceLifetime(Lifetime.Application)]
public interface KAHMHPEDNOM : ELBBMELODEN, KDOKNCAMHOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool KNPGJHABEDH
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IHKONCGCMNJ INPGPKGFGEN
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	KMLIJBCDHKP FLLBPNEHIOI
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	JIKKDKGBDLB POADOIIONBB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	GOJGONNCHIC AIBGFHBLONB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface KDOKNCAMHOF
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool LABKLDNMCOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface LLFPAKKOKJP
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JBPAGPIILEE(bool INDENPJBLHO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface IJLFDNBMOAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool GAHPCDLDIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CDHJKFNAPAM(bool KDHIKINJBAG);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKNPICPCHKO();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AFCCHANPEJH(ByteString AHCJGDGJNCB);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EGIGGDGKAPP();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FOCEPCDIKDH();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FHCGDNGCFHO();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PNDKGEMMDFM();

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JOOCNGNBHKP();

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AMPKNPMKNBK();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.Application)]
public interface JIKKDKGBDLB
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	IMGHKCMNGFB INPGPKGFGEN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	KMLIJBCDHKP FLLBPNEHIOI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	GIAJMCLBEFD EEGIJJFADFF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	CGEBLKEKCOJ JEENPHPONIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	KAHMHPEDNOM KGDPGJGJICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	IJLFDNBMOAJ IPGPKMOAIIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	PJJOGJFNMIM KJPEHNEANDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	HFLAEHHBNFF FLDCGOPMPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	IMJOBFPMAKJ LNEHDOKPNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DEDDPGIPADH ALABPKDOFPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	PHCKIPGLJNG FNLGBBFOJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	KNMBABCNKJO IJEAKFCMHII
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	DMEBDNNKCFG AADNMPNJNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	LIGDBFMOLCN CJPGAFCMEPI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	OAOPDONAOPN KCHJAJLKFFP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	INENKMLOBJI EAIPDKIHNOI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	NOHGGPDMLKA PPBHOPHFDNA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	JBNNPMJGKEL PPPJOCNOPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	EAPGCLJFNAN DFBKGLPKFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	OCNNJJGHEBG JHGBAIIJDIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	DBAOMEMHJED OJFMHLLLDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	FOKHHODNCAE PCLLJBLNGJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	HABOCNEGLON NGBBGIJOGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	EJINNBHBDHI GIEBFNDBLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	EEPDPHLFPIE JEDPMIHBIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	CCILDPOFEOM DMCPCMCOGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	DFCMGIKOHMB FKDENFKILJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	FLMLIDNECPL KCHLDDMCFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	COFCEECBFGH IKJCNFMFKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CDOHJBENMOK KFFCOCFBPJE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	HHKCACGEMAG BGFPEHNKJJH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(AEIHGBHALPB))]
public readonly struct NLPICMPDONC : IComparable<NLPICMPDONC>, IEquatable<NLPICMPDONC>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly NLPICMPDONC EOIJNKLPKGL;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int HFLBNLBEHOO = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int FBKEEALLEJC = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int NFFMCIFFEPC = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int GLMINNCPIGC = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId BCECCNCMCGN;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public PJJOGJFNMIM KJPEHNEANDN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x70A3860", Offset = "0x70A2060", VA = "0x1870A3860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public KAHMHPEDNOM KGDPGJGJICC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x70B4C30", Offset = "0x70B3430", VA = "0x1870B4C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public LocalId AAICGMCEGJK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x70B4BF0", Offset = "0x70B33F0", VA = "0x1870B4BF0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	internal GOJGONNCHIC AIBGFHBLONB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x70B4C90", Offset = "0x70B3490", VA = "0x1870B4C90")]
		get
		{
			return default(GOJGONNCHIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool GDDFGENFMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x70B4CA0", Offset = "0x70B34A0", VA = "0x1870B4CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private bool FIGLKNFMGFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x70B48A0", Offset = "0x70B30A0", VA = "0x1870B48A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x70B5010", Offset = "0x70B3810", VA = "0x1870B5010")]
	public NLPICMPDONC(PJJOGJFNMIM HGBAINJFEON, LocalId BCECCNCMCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
	public COHFKJEBDIE DJFPDOBECDM()
	{
		return default(COHFKJEBDIE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x70B4B70", Offset = "0x70B3370", VA = "0x1870B4B70")]
	public static LocalId FMEIMHFCNHG(NLPICMPDONC GGENKOHKGAJ)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x70B4BB0", Offset = "0x70B33B0", VA = "0x1870B4BB0")]
	public static Entity FMEIMHFCNHG(NLPICMPDONC GGENKOHKGAJ)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x70B4DC0", Offset = "0x70B35C0", VA = "0x1870B4DC0")]
	public static bool PCBECHOJFKF(NLPICMPDONC DAOGAHJCGEC, NLPICMPDONC NBDADAEEFHF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x70A4DA0", Offset = "0x70A35A0", VA = "0x1870A4DA0")]
	public static bool DJBIFFEEEPL(NLPICMPDONC DAOGAHJCGEC, NLPICMPDONC NBDADAEEFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x70B4EE0", Offset = "0x70B36E0", VA = "0x1870B4EE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x70B49E0", Offset = "0x70B31E0", VA = "0x1870B49E0", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x70B48F0", Offset = "0x70B30F0", VA = "0x1870B48F0", Slot = "4")]
	public int CompareTo(NLPICMPDONC LIHCAHPMPHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "5")]
	public bool Equals(NLPICMPDONC LIHCAHPMPHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class EGHFMDBFHKI
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x70A93A0", Offset = "0x70A7BA0", VA = "0x1870A93A0")]
	public static HDJIEEPKAHE PKKNBIIFEGI(this NLPICMPDONC INCBEIDOHDO)
	{
		return default(HDJIEEPKAHE);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x70A92F0", Offset = "0x70A7AF0", VA = "0x1870A92F0")]
	public static COHFKJEBDIE CDLHJNOLJNG(this NLPICMPDONC INCBEIDOHDO)
	{
		return default(COHFKJEBDIE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class AEIHGBHALPB
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct GOJGONNCHIC : IEquatable<GOJGONNCHIC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte KACBIAOBGKP;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] FOOPPDKFADO;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static PJJOGJFNMIM GJOILLODEBD;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static KAHMHPEDNOM DOPGDDFIFCM;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static PJJOGJFNMIM[] HADOCIFMDFA;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static KAHMHPEDNOM[] MKGEAAJGMDL;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> IGPEHNHKOFI;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public KAHMHPEDNOM KGDPGJGJICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x70AE070", Offset = "0x70AC870", VA = "0x1870AE070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public PJJOGJFNMIM OJOJNPBCELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x70ADBF0", Offset = "0x70AC3F0", VA = "0x1870ADBF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x70AE4D0", Offset = "0x70ACCD0", VA = "0x1870AE4D0")]
	static GOJGONNCHIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x251B6A0", Offset = "0x2519EA0", VA = "0x18251B6A0")]
	internal GOJGONNCHIC(byte INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6123AE0", Offset = "0x61222E0", VA = "0x186123AE0", Slot = "4")]
	public bool Equals(GOJGONNCHIC LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x70AD920", Offset = "0x70AC120", VA = "0x1870AD920", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xAFF9B0", Offset = "0xAFE1B0", VA = "0x180AFF9B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x70AE410", Offset = "0x70ACC10", VA = "0x1870AE410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x70ADB40", Offset = "0x70AC340", VA = "0x1870ADB40")]
	private static PJJOGJFNMIM JEHOAPKHIND(byte KACBIAOBGKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x70AE150", Offset = "0x70AC950", VA = "0x1870AE150")]
	private static KAHMHPEDNOM NEICDIEIIIJ(byte KACBIAOBGKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x70AD9D0", Offset = "0x70AC1D0", VA = "0x1870AD9D0")]
	private static object IGFFBGIGHJD(byte KACBIAOBGKP, object[] MCAFGDLBCDD, object DFEJJOPGBKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x70ADCD0", Offset = "0x70AC4D0", VA = "0x1870ADCD0")]
	private static int JMHHFNJECMH(byte KACBIAOBGKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x70AD9C0", Offset = "0x70AC1C0", VA = "0x1870AD9C0")]
	private static int GICPGCHKGCN(byte KACBIAOBGKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x70AD8A0", Offset = "0x70AC0A0", VA = "0x1870AD8A0")]
	private static (int, int) DAMAHLGPMOP(byte KACBIAOBGKP)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x70AD5D0", Offset = "0x70ABDD0", VA = "0x1870AD5D0")]
	private static byte APHBOEPGLGE(int MAAOIFPNGGJ, int ECDOOAABOPD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x70AD5E0", Offset = "0x70ABDE0", VA = "0x1870AD5E0")]
	internal static GOJGONNCHIC CCEDGNHHKOL(KAHMHPEDNOM AGPEMLNJJAH, PJJOGJFNMIM FLGLGKAHJAB)
	{
		return default(GOJGONNCHIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x70AE200", Offset = "0x70ACA00", VA = "0x1870AE200")]
	internal static void NKAGGCHHKCB(GOJGONNCHIC KACBIAOBGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x70ADCE0", Offset = "0x70AC4E0", VA = "0x1870ADCE0")]
	private static void KLHHDOLGBPL(int DEOEMPAJCCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface EEJKOCJBPFC
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HOKANEFHFEM();

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NCEDOOGAFKE(bool APNIOENDBKI);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OPDOFILKNBG(GameObject PBJIFBOBIOP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[ServiceLifetime(Lifetime.Application)]
public interface ALBNCNDACEO
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Guid IGOHLLPCLGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GIGLBCFFLLN(Guid BBIEJEFKCIE, Guid FJIFOJCFNEO, Guid GFIOPLMHGGI);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task INNCFLNMPFI(Guid BBIEJEFKCIE, Guid[] AKNDAKIMFAD, Guid GFIOPLMHGGI);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid AIGLAKNMDCC(Guid JJFBINJJNLK);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task MFJJIMHDKHN(NLPICMPDONC PODFCCAGNCO);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DNIBHHEFLJO(Guid JJFBINJJNLK);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MHAAFEMEPKI(HDAAKMEENMN OOBILKGFEDD, Guid KFIDMKEENMB);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ACHBDPMJGFP(Guid JJFBINJJNLK, bool KDHIKINJBAG);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[ServiceLifetime(Lifetime.Application)]
public interface NGFJPJGKOCI
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFFLOCLFHDP(DLIACAMIKND OBBIGKIBBBG);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[ServiceLifetime(Lifetime.Application)]
public interface IAKIKGLFHIG
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DHDFONPICLO(GameObject MHDKJAJDJGE, GameObject MIPGJGIDJJM, int GBLAELHDBMF);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[ServiceLifetime(Lifetime.Application)]
public interface KMLIJBCDHKP
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EEJKOCJBPFC BGBFCGBCBLG
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	CGCMMLFDKOK GKDPGPFJFIA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	LBMLKBGOHBE JJKCDODNJJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	HIENGENHKMF ELCGNCOMPFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	IEJODCAPFKJ JGEPGLGIGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	JOINBKHAOJA CFKNJHFOIKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	BKIHDGGECGH IMMHLJNHMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	PMAPPHAFLII DNBNCKPNNOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	KODGEIONFBG FKGLIHANJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	LMDHMHAKCOB BDOPAOJFPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	JCHGHEFPGON DOMCPLEDKHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[ServiceLifetime(Lifetime.Application)]
public interface CGCMMLFDKOK
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	string BLNOEOAAOPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[ServiceLifetime(Lifetime.Application)]
public interface NFPEMGKBFDB
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NOAOLMACFKD(Action ILIPDNLABEN, bool PLPAJKBFJAB);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CKCOIFONEOF(string IKMKCMDHFDC);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int GIEMIGNNLEK(string IKMKCMDHFDC, int DFEJJOPGBKP);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NHLGGOJCJEF([Out] bool INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BHPBOAFBEGM([Out] bool INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LEOIMCNILAM([Out] int INDENPJBLHO);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface LBMLKBGOHBE
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	string AKLHPACMNHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] DIMJLEHFFBP(IEnumerable<CEKOGANACJF> OGGNALBGGIL, bool APLPOJJKCBA);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NPNADPOOAFF(GameObject PBJIFBOBIOP, [Out] HDJIEEPKAHE[] FCJKDFCDMDN);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GBFEJPBEKAM(GameObject PBJIFBOBIOP, [Out] int BNNDKLOLFNH, [Out] BKBMPOCGEPN AAFKJACPDJA);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HDAAKMEENMN BNFIEEEOCCP(CEKOGANACJF BPCGMGBPPCA);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HDAAKMEENMN BNFIEEEOCCP(string GGLFPAKLDNL, HDJIEEPKAHE[] JINIJLGMOEA, Vector3 BALIIBCILHH, Quaternion OJEGGOKKPLF, Vector3 FKICLIIJEHG);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HDAAKMEENMN JHPFKAGADAE(string GGLFPAKLDNL, HDJIEEPKAHE[] JINIJLGMOEA, Vector3 BALIIBCILHH, Quaternion OJEGGOKKPLF, Vector3 FKICLIIJEHG);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject BHDJMBHLDBM(string GGLFPAKLDNL);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DDHIILANHNH(GameObject JBIJKGAAAFD, bool PBBJGOAILGI);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BHKDOGNMMNE(GameObject PBJIFBOBIOP, bool KDLEIIAJOJP, bool MILKHDNBOAE);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class FHOBELEHIGA
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x70AA200", Offset = "0x70A8A00", VA = "0x1870AA200")]
	public static HDAAKMEENMN BNFIEEEOCCP(this LBMLKBGOHBE BIJBPNIFOLE, Vector3 BALIIBCILHH, Quaternion OJEGGOKKPLF, Vector3 FKICLIIJEHG, params HDJIEEPKAHE[] FCJKDFCDMDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x70AA350", Offset = "0x70A8B50", VA = "0x1870AA350")]
	public static HDAAKMEENMN JHPFKAGADAE(this LBMLKBGOHBE BIJBPNIFOLE, Vector3 BALIIBCILHH, Quaternion OJEGGOKKPLF, Vector3 FKICLIIJEHG, params HDJIEEPKAHE[] FCJKDFCDMDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[ServiceLifetime(Lifetime.Application)]
public interface HIENGENHKMF
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAOJFOIBEGK(bool KDHIKINJBAG);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[ServiceLifetime(Lifetime.Application)]
public interface IEJODCAPFKJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool ANJKJAOMKIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool ILEJCAKOEMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool CNCEADFAAGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	int JBANLAACLJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool CKPMACKDIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KMNKHMFMKNI(object OANAMCHLGCB);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JJLFGLNANGO(object OANAMCHLGCB);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IKDBKEFHPPE(object BIINCLMPDMO);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KNPCCBLBGIA(object BIINCLMPDMO);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ViewId ILFENBOFOLL(GameObject CLJHIFMEGEB);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BPHCJMCHHNN(NativeArray<ViewId> BCMCOMGECGD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LKEONCMILDF(NativeArray<ViewId> EALAAKOBPLF);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LPNDJOEHFDC();

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FLGKAKLAIMH(uint BNPHHPHFBPC, ReadOnlySpan<byte> OBBMGEFNLBJ, bool IGPJNHKIJAA = false);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FLGKAKLAIMH(uint BNPHHPHFBPC, ReadOnlySpan<byte> OBBMGEFNLBJ, ReadOnlySpan<byte> KCOLEFNFEOA, bool IGPJNHKIJAA = false);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NCKLGCLBJDL(Func<int, bool, int> KHNOIKNBDIC, bool JDFGHCBBLLO);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HOHGJBJKDLM(object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FCAFNMKOCIC(object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "18")]
	uint NDNJCOBHJHE(uint HCEFDNFIGAF);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class EGFDBAELIFF
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x70A9260", Offset = "0x70A7A60", VA = "0x1870A9260")]
	public static OPBANNHAFND KLHIBFALDPI(this IEJODCAPFKJ AFFIFGJEAGI, object DJIMHLGHFGI)
	{
		return default(OPBANNHAFND);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct OPBANNHAFND : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private IEJODCAPFKJ AFFIFGJEAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private object DJIMHLGHFGI;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x70B65F0", Offset = "0x70B4DF0", VA = "0x1870B65F0")]
	public OPBANNHAFND(IEJODCAPFKJ AFFIFGJEAGI, object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x70B65A0", Offset = "0x70B4DA0", VA = "0x1870B65A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface JOINBKHAOJA
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGHLBOCNDMH(GameObject PBJIFBOBIOP);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface BKIHDGGECGH
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public struct ILMCJBIEEHG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private BKIHDGGECGH HLDDLPJHFEL;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x70B0C40", Offset = "0x70AF440", VA = "0x1870B0C40")]
		public ILMCJBIEEHG(BKIHDGGECGH HLDDLPJHFEL, string PJFOMDHJLBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x70B0BE0", Offset = "0x70AF3E0", VA = "0x1870B0BE0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct EPLDHDIPJOI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private BKIHDGGECGH HLDDLPJHFEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Task DIGFCMIOIEB;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x70AA1B0", Offset = "0x70A89B0", VA = "0x1870AA1B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GIBMNIIAGNP(string PJFOMDHJLBF, float IGEHIFGNOPE = 5f);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMHEENCMHJO();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HPDAJHPIDNJ(bool OIMFMJGKCPJ, string PJFOMDHJLBF);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class PKPIGHDLGDL
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x70B67D0", Offset = "0x70B4FD0", VA = "0x1870B67D0")]
	public static BKIHDGGECGH.ILMCJBIEEHG CLEABGOMBFC(this BKIHDGGECGH AFFIFGJEAGI, string PJFOMDHJLBF)
	{
		return default(BKIHDGGECGH.ILMCJBIEEHG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface LBGDOLCBAMI
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int FCOMLBDIAHL(GameObject PBJIFBOBIOP);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ONAJBOMMMGI(GameObject PBJIFBOBIOP);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KHKJHOLIANN(int NEHJMKFJILC);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object BOGIHNBFACO(NLPICMPDONC BCECCNCMCGN, GameObject PBJIFBOBIOP, Action<NLPICMPDONC, int> KNMHMBJIFMM);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HCEAHHECDAL(GameObject PBJIFBOBIOP, object MECLOINKHOK);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface ABKBCNFMPEE
{
	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool BLEBMFHFILD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate AINPGICAIJA(CNIPNDAJGFI.BADAIHEHHNP KKKCGCDGEDD, Action<CNIPNDAJGFI.BADAIHEHHNP> KNMHMBJIFMM);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BKLHDMGIHCL(CNIPNDAJGFI.BADAIHEHHNP KKKCGCDGEDD, Delegate KNMHMBJIFMM);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate JDLMGJCAGAG(CNIPNDAJGFI.BADAIHEHHNP KKKCGCDGEDD, Action<CNIPNDAJGFI.BADAIHEHHNP> BCNHLCBPLPE);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CIBFIGHBAPB(CNIPNDAJGFI.BADAIHEHHNP KKKCGCDGEDD, Delegate KNMHMBJIFMM);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FCLMMMCPFMI(CNIPNDAJGFI.BADAIHEHHNP KKKCGCDGEDD);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CNIPNDAJGFI.BADAIHEHHNP AAFEONKHJDM(GameObject PBJIFBOBIOP);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface PMAPPHAFLII
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	int MFLLOFAJPLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	int OEJGJPLANDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool ILEJCAKOEMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool CMNBAANEGNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int POEMBNMJJKD(GameObject PBJIFBOBIOP);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CHLACFPKKJD([Out] Vector3 BALIIBCILHH);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IMJNOPACHDH();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NLPICMPDONC OIGPKLCDCFL(int NEHJMKFJILC);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ONFALDACPNB();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[ServiceLifetime(Lifetime.Application)]
public interface KODGEIONFBG
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool GAHPCDLDIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[ServiceLifetime(Lifetime.Application)]
public interface LMDHMHAKCOB
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	IPOCMNFOENG HINKIGIPEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	NNAOBFCCCAA NDLGLFPPHLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KAAJNDLJHCF(Transform NBEDBEKEEBM);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OCNNKKACLOA(Transform NBEDBEKEEBM, EMCNJLJEEBA DPENLAKAGKN);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JCOGOHOOOMP(Transform NBEDBEKEEBM, LDFEEADCCGN CPOJFOEHPBN);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BLGAEFHNCMA();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ABJFAGEPFPP();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[ServiceLifetime(Lifetime.Application)]
public interface MMAPPJNEMLH
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[ServiceLifetime(Lifetime.Application)]
public interface JCHGHEFPGON
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action BGOGODHBLOC;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EOJDCJJHDNO(DLIACAMIKND OINBFMLJNAN, bool OIMFMJGKCPJ);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[ServiceLifetime(Lifetime.Application)]
public interface OLEIFLOOBEM
{
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OBJALKEMFCI();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ServiceLifetime(Lifetime.Application)]
public interface IHFOBCIAAIC
{
	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BKBMPOCGEPN GOEFPHKHFAF(GameObject CLJHIFMEGEB);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HENFMEBDDLF(GameObject PBJIFBOBIOP, CDEPPFIGPHB MHEICMIGALG, INHFPBMEMPN COLENNJAKLG);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EPFHKOKBGGI(NLPICMPDONC BCECCNCMCGN, bool FPDCICCKLGA, float3 ANOHMCKGGGP, quaternion BIKPFAPHEHP);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PDJJIKAEHFI(COHFKJEBDIE AFJCLAOHICF, COHFKJEBDIE BIINCLMPDMO, JBOELMKONKK NNGPPKEHFMP);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PHGMJFMJIJC(COHFKJEBDIE AFJCLAOHICF, JBOELMKONKK NNGPPKEHFMP);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NPJKDKFFPGD(DLIACAMIKND GPEHJPJPEPJ);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BLBMLLFIBJP(DLIACAMIKND HIOGCNEKLDG, NativeArray<LocalPoseData> KCIGODFLBKO, NativeArray<float3> HCPPDKIEFEJ);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DKBLMEBMEMC(DLIACAMIKND HIOGCNEKLDG, DLIACAMIKND AMPAKEENBAD);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CIOCJMJGFGN(DLIACAMIKND HIOGCNEKLDG, bool ABCGMBPKEGG);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ICPPHFKODBC(DLIACAMIKND HIOGCNEKLDG, bool CFKCOLNKANJ);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GameObject NCCAHOLCHFF(Guid KEAAIPFMBPN);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JAMIOJKJHCG(DOGDACMPKBI CKKNJFDGPPK);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct AKOOPPLNHAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly IEIDAPIFJMH EEPGNNLBJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly IEIDAPIFJMH GNDBPGCEJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint PIGLPBBCKHI;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x70A2D10", Offset = "0x70A1510", VA = "0x1870A2D10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct KOILAHOHDJN
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal readonly AKOOPPLNHAI ILIPDNLABEN;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x70AF430", Offset = "0x70ADC30", VA = "0x1870AF430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct HJAJOJDMIGE
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal readonly AKOOPPLNHAI ILIPDNLABEN;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x70AF430", Offset = "0x70ADC30", VA = "0x1870AF430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct COHGBPJMBFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal readonly uint PIGLPBBCKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal readonly bool PKOKCEICCBN;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x70A53E0", Offset = "0x70A3BE0", VA = "0x1870A53E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct IEIDAPIFJMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal int MHPJBPKHONI;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x70B0B80", Offset = "0x70AF380", VA = "0x1870B0B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.Application)]
public interface FIOJCHFMGDJ
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	IKPFDGMBKDK DAGIAHGKHGF
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public enum KBABMJNHDDI
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
public interface HDAAKMEENMN : FOLMINFPFOG
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	KBABMJNHDDI AECLPALMIEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool PACECDEJFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	GameObject PBJIFBOBIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<HDAAKMEENMN> AIGKPPFBGBJ;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(GIAJMCLBEFD LHFELFOPEAG, NLPICMPDONC KKPONDJIGMO);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool JKEFOBIHJPL);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class NICCOOKAOED
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x70B4850", Offset = "0x70B3050", VA = "0x1870B4850")]
	public static bool MINFAMBMNMC(this HDAAKMEENMN CELALIAMGNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x70B4720", Offset = "0x70B2F20", VA = "0x1870B4720")]
	public static bool HEKBDJDEEOO(this HDAAKMEENMN CELALIAMGNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x70B4770", Offset = "0x70B2F70", VA = "0x1870B4770")]
	public static bool KGEDIAGELPO(this HDAAKMEENMN CELALIAMGNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x70B47C0", Offset = "0x70B2FC0", VA = "0x1870B47C0")]
	public static bool LJDEGIELPAP(this HDAAKMEENMN CELALIAMGNM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface FOLMINFPFOG
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool KNPGJHABEDH
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	NLPICMPDONC IAKMOOCKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface JBGOPIDCEEM
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate void CGHIGDNGOHD(GLOBPNCNKOJ LMMBBJLNONF);

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event CGHIGDNGOHD OKBEMBPMJPK;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface KCNIBCFNIPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DHDPJDGKDEN(Vector3 BALIIBCILHH, Quaternion OJEGGOKKPLF, Vector3 FKICLIIJEHG);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DDCCBIGAKMA(NLPICMPDONC NCCLECGLDAO);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KOFNLMOEEIC(bool CDDDOIECLCL);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JBDEFCEGAPM(bool CFKCOLNKANJ);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface OLMGAELMFFH
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface KIPCMJEHAFM
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(NLPICMPDONC BDDDIBKBEEE);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool PHBIMLIFBEC);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GHICJOFLKAI(NLPICMPDONC KKPONDJIGMO);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface PKOBBNHPMDA
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(LDJJPBBNOHE FFEAKMPDLBP);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface LDJJPBBNOHE
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	GameObject PBJIFBOBIOP
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	Transform NBEDBEKEEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	CLKDHEIJDPM GOEDLKNLAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	bool PGPBGBKGLBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HAGKDGIMMGA(CLKDHEIJDPM CLCEHBDJMEK);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface CLKDHEIJDPM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	NLPICMPDONC IAKMOOCKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Rigidbody HIPNKAOEIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	LDJJPBBNOHE PNNDDMLJICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	GameObject BOMBMPDPILP
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	Transform KEKDMLOCEEG
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	CLKDHEIJDPM MHMOKMJDLAF
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	CLKDHEIJDPM JJAKCGIGEEC
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	int DKOJDBHPCKH
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	bool LGOLHEAHKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	bool FCLMMMCPFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool KFLDOLPOEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	JBNIKIOLDLF KNCLLFKNBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	MBMIBMKAFBA OCKFMKMEPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	float MGBPLPCNCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Vector3 KEJINJCIGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 EBKJJPKMODE
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 LBNNPBIDFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 DBHPKKICEIA
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	bool JAAEGIACACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	bool NCNOGIDJLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	bool JOJNGDGIGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	Vector3 PCNPNEJGBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Vector3 GDDNELAPFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Vector3 BHGBHOLOBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Vector3 OCMLFPAFCBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	float OBICABEGEKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	float IKNNFHJBACJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Vector3 PJNHHCLFIGC
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Quaternion KLOLJBMEMDC
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	float KNNCHAJPCLK
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "60")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float MPDJELAGIJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool FKDPMNMNENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "64")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	FMLELDCHGMI FEGAPJIGNIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "66")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	bool HBGLEDGEAAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Transform KANCOIDCOHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	Vector3 KANAGPKDKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "70")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	float MIHAIJGPNOI
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "72")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	float FKDCOACEDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "73")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "74")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	Quaternion OCICAGHFMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "75")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	Vector3 MAGAFCIBJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "78")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	Quaternion HPCBIJNFAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "79")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "80")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	RigidbodyConstraints DHEIMOODHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "82")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	bool OIDKFEONKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	CollisionDetectionMode LNPCAGOAEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "86")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	bool CKJKIGBHOKI
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "87")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event KJOJIKKICPM AOADHMFLHHD;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event KJOJIKKICPM GJBKPELNFGK;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event KJOJIKKICPM KMAOLGOKLEH;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event KJOJIKKICPM ENNIKABMLLF;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event KJOJIKKICPM DKJPADICAID;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event KJOJIKKICPM HACMIDNDACF;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event KJOJIKKICPM AIDPNAIBMDN;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event LKNNFBAGKCD KGNLKJOGCPF;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<HNNBIECDFEH, HNNBIECDFEH> PENDLLPMKAO;

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CLKDHEIJDPM JFFBKLJCMHI(int ECDOOAABOPD);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void LIEGMGMENOM((Quaternion rot, Vector3 moments) GONNOPNNDDD);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void JNLOKBHKNIB();

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void KJFJKFGHICB();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void PCJCDGBEAOH();

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void PFLIEJBLKMJ();

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void IGAKIOOAGHE();

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void DDCCBIGAKMA(CLKDHEIJDPM INDENPJBLHO, bool NCJCCAJKLJN = false);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void IBNECMGCCBE(object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void LJDAOBCCLCF(object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "96")]
	Vector3 AHNJJDLLBIM(Vector3 PCALFOEEPAF);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 JPABHDFFLJA(Vector3 EPGELPCMLDO);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void BIJGCPALBCB();

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void DDMMBAMAOJB();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void EJCIOEBEFGN();

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void DICCAJJNCPA(Vector3 EDONNCIELGP, Vector3 HCJLGMKALKF);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void CCJJCFAJKPP(Vector3 LPLJFCLGJKM, Vector3 HOPDBNLFMHO);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void DIFBBCFEJIC(Vector3 JKCDJCOBNFD);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void AABHOIJCEPE(CAGMBFKGEMC GHLELCMGNEE, Vector3 JPHOJJCHKHD, float KANLLIFFDJB, float NDNEEMGLJDD = 8f, float PEFEPHIPIEA = 1f);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void IMIONDKKMCP(AOIBDNAKBNG INFBLAPINDA, Vector3 JDHNCLHOBJL, float JHKMJBBILBB = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void NGPHDFNAKAB(AOIBDNAKBNG INFBLAPINDA, Vector3 OJEGGOKKPLF, float MHNMFOIOAKI = 7f, float HGDNLAPNDME = 1f);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "107")]
	Vector3 AFGFJFHNODC(Vector3 INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 JAOOJPDJKOH(Vector3 INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "109")]
	void DFKCKFJCDJJ();

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void EJANDGAIOFJ(CLKDHEIJDPM BEHILLMJEKM, object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void IKFAIMJLCIK(object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void LMHMCEKKFIL();

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void CNJBBDKPIKE();

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void MJEMIAPJHGI();

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "115")]
	bool KJJAHCAGAMI();

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "116")]
	void OBKPNCKIMEG();

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void LHOMBJDILPL(object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void JECKHECCMHJ(object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void NGILCALIHMA(object DJIMHLGHFGI, bool NJPKHDOCLPC);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void LKJFLEHIDOC(Vector3 MKBPBNELLML, Quaternion EIBNEKFAKNO);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void AFLDKBAHLKF(Vector3 LNBFCBPPFCP, Quaternion PLHOLEPGJHB);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "122")]
	bool FDJLAEKLHCK(float JIEAOBFDGBL);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void OLJBAKLMDEG(object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void LCJDHNFNHBD(object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void ACNPMEFFPLJ(object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void NOMEBGPDCMB(object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void AKAJMJMIOEI(Vector3 KHDIFEIJFDB, ForceMode JJAPHGHHBJE = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void IJABKPPHMOK(Vector3 KHDIFEIJFDB, Vector3 BALIIBCILHH, ForceMode JJAPHGHHBJE);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void BCHPEGFCLNP(Vector3 OKFDNEPALDE, ForceMode JJAPHGHHBJE = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void HFDDEEJOACG(Vector3 OKFDNEPALDE, ForceMode JJAPHGHHBJE = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "131")]
	bool DEDKHLCDJDI(Vector3 NGBCGJCGHJG, [Out] RaycastHit PFJHGCCOMGD, float HFFBJNAMAGI);

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void GFFDCONBCGL();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface MBMIBMKAFBA
{
	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJBGLMLOCGP(Vector3 MDDHJCHPKDO);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OCCMPMJEFLH(Vector3 NAILJECMJDD);

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AIEKHKMNNIC(Vector3 MDDHJCHPKDO);

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JMJMFCGKPKJ(Vector3 NAILJECMJDD);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface JBNIKIOLDLF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 JJKNIHHEPCM();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 CBDLJKGGLHC();
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public delegate void KJOJIKKICPM(LDJJPBBNOHE OIMOMEBHOAM);
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum KONHLMKMGGF
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
public enum CAGMBFKGEMC
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
public delegate void LKNNFBAGKCD(LDJJPBBNOHE OIMOMEBHOAM, bool NCJCCAJKLJN = false);
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum AOIBDNAKBNG
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct AHMFFPIAIMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Rigidbody JPHPMPANJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public object BKKJPNGFNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector3 IFKGFAGLFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector3 HEHDOAGPNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NEDCKNNIBBL FHHJIDAFGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool POIOHEFAHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool LKBNDMBEJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool ABKPEJOENKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public bool BPCHMHKFMAA;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct COHFKJEBDIE : IEquatable<COHFKJEBDIE>, FOLMINFPFOG
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly COHFKJEBDIE EMNAMALOMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public NLPICMPDONC IAKMOOCKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870", Slot = "6")]
		get
		{
			return default(NLPICMPDONC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public EEJLODDODNB KEKDMLOCEEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(EEJLODDODNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public HMJJFBIINHB FLDCGOPMPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(HMJJFBIINHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private PJJOGJFNMIM KJPEHNEANDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x70A3860", Offset = "0x70A2060", VA = "0x1870A3860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public GameObject PBJIFBOBIOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x70A4C10", Offset = "0x70A3410", VA = "0x1870A4C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public HDJIEEPKAHE HKLBILFJPBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x70A4FE0", Offset = "0x70A37E0", VA = "0x1870A4FE0")]
		get
		{
			return default(HDJIEEPKAHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public HODFNNMKOAA AGCKCIBBNID
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x70A4EA0", Offset = "0x70A36A0", VA = "0x1870A4EA0")]
		get
		{
			return default(HODFNNMKOAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public BKBMPOCGEPN DNCIKEPEPFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x70A4AD0", Offset = "0x70A32D0", VA = "0x1870A4AD0")]
		get
		{
			return default(BKBMPOCGEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool HKOFEBKEGEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x70A5240", Offset = "0x70A3A40", VA = "0x1870A5240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool APLAOMOELDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x70A4DF0", Offset = "0x70A35F0", VA = "0x1870A4DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool HJBOECEMJNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x70A51D0", Offset = "0x70A39D0", VA = "0x1870A51D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool MJJCDGMADJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x70A4A10", Offset = "0x70A3210", VA = "0x1870A4A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool GKIJNJHOHMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x70A4AB0", Offset = "0x70A32B0", VA = "0x1870A4AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool KBNHCIFHDDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x70A51B0", Offset = "0x70A39B0", VA = "0x1870A51B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool HJAPFCDBGOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x70A4F60", Offset = "0x70A3760", VA = "0x1870A4F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool LIALFKOFFFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x70A52C0", Offset = "0x70A3AC0", VA = "0x1870A52C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool NMLCGJKBLHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x70A5220", Offset = "0x70A3A20", VA = "0x1870A5220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public GACPKPNDJOP OBGOJLJAGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(GACPKPNDJOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public DANBGNDLGFI BFJOBCNEGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(DANBGNDLGFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public GDHAKMMGNHM KCHJAJLKFFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(GDHAKMMGNHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public NFJNHOFIDEA PNIEPMOILDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(NFJNHOFIDEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public NNEIMABPMFB CJPGAFCMEPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(NNEIMABPMFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public CHFMEPPLNJI KOHHHFJLDFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(CHFMEPPLNJI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public KIDENFMJCDD IJKFHAMBHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(KIDENFMJCDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public APGAJEOGAJF MJMALKBLDAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(APGAJEOGAJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public NHICMEMIGCD BFIKNENJCBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(NHICMEMIGCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public IAOAONIABGB LFDBLOIPJPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(IAOAONIABGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public MJPFCKCAKBO HBCALKPEBFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(MJPFCKCAKBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public BAJDCCNGOIN MGDHBIOFIPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(BAJDCCNGOIN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public BHOGIGGHPFE JFGKNDLEPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(BHOGIGGHPFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool MINFAMBMNMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x70A5080", Offset = "0x70A3880", VA = "0x1870A5080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool GLJDCMJFELE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x70A4FA0", Offset = "0x70A37A0", VA = "0x1870A4FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool JOELEMKMHKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x70A5170", Offset = "0x70A3970", VA = "0x1870A5170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private bool EABIDGGIJHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	public COHFKJEBDIE(NLPICMPDONC BCECCNCMCGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x70A4F40", Offset = "0x70A3740", VA = "0x1870A4F40")]
	public static bool FMEIMHFCNHG(COHFKJEBDIE INDENPJBLHO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0xA85ED0", Offset = "0xA846D0", VA = "0x180A85ED0")]
	public static NLPICMPDONC FMEIMHFCNHG(COHFKJEBDIE INDENPJBLHO)
	{
		return default(NLPICMPDONC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x70A5260", Offset = "0x70A3A60", VA = "0x1870A5260")]
	public static bool PCBECHOJFKF(COHFKJEBDIE DAOGAHJCGEC, COHFKJEBDIE NBDADAEEFHF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x70A4DA0", Offset = "0x70A35A0", VA = "0x1870A4DA0")]
	public static bool DJBIFFEEEPL(COHFKJEBDIE DAOGAHJCGEC, COHFKJEBDIE NBDADAEEFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x70A4E10", Offset = "0x70A3610", VA = "0x1870A4E10", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(COHFKJEBDIE LIHCAHPMPHD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0xA85ED0", Offset = "0xA846D0", VA = "0x180A85ED0")]
	public static COHFKJEBDIE FMEIMHFCNHG(NLPICMPDONC JDJHDGCHHFG)
	{
		return default(COHFKJEBDIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x70A4A30", Offset = "0x70A3230", VA = "0x1870A4A30")]
	public FOHOGCAIENK BKCAIFIGOPD()
	{
		return default(FOHOGCAIENK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x70A4DC0", Offset = "0x70A35C0", VA = "0x1870A4DC0")]
	public IOLDNKIJJJK EEMGCIDFHCF()
	{
		return default(IOLDNKIJJJK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x70A5270", Offset = "0x70A3A70", VA = "0x1870A5270")]
	public DDOHALFLGNO PEEPONEFNIH()
	{
		return default(DDOHALFLGNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x70A51F0", Offset = "0x70A39F0", VA = "0x1870A51F0")]
	public NEPBOLEKLND MKBMHNMNLEG()
	{
		return default(NEPBOLEKLND);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x70A4B70", Offset = "0x70A3370", VA = "0x1870A4B70")]
	public void CDLHJNOLJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x70A5300", Offset = "0x70A3B00", VA = "0x1870A5300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct KIDENFMJCDD : IEquatable<KIDENFMJCDD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public NLPICMPDONC IAKMOOCKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(NLPICMPDONC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private PJJOGJFNMIM KJPEHNEANDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x70A3860", Offset = "0x70A2060", VA = "0x1870A3860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private JIKKDKGBDLB POADOIIONBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x70B1F10", Offset = "0x70B0710", VA = "0x1870B1F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private JBNNPMJGKEL PHPMNNCLCFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x70B1C60", Offset = "0x70B0460", VA = "0x1870B1C60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool HNCOOBJLHOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x70B1FA0", Offset = "0x70B07A0", VA = "0x1870B1FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Guid HMBGHOHADAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x70B1A20", Offset = "0x70B0220", VA = "0x1870B1A20")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool JBNNKFLOGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x70B1E80", Offset = "0x70B0680", VA = "0x1870B1E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Guid LGBCBIAHNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x70B1900", Offset = "0x70B0100", VA = "0x1870B1900")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	public KIDENFMJCDD(NLPICMPDONC BCECCNCMCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x70B1B40", Offset = "0x70B0340", VA = "0x1870B1B40", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(KIDENFMJCDD LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x70B1DE0", Offset = "0x70B05E0", VA = "0x1870B1DE0")]
	public bool HMANOIOLGIJ([Out] Guid JJFBINJJNLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x70B2030", Offset = "0x70B0830", VA = "0x1870B2030")]
	public void PDDHPPLEIPI(Guid DBIIPNGMHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x70B2150", Offset = "0x70B0950", VA = "0x1870B2150")]
	public bool PHOBOHABFJN([Out] Guid FJIFOJCFNEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x70B1CC0", Offset = "0x70B04C0", VA = "0x1870B1CC0")]
	public void HJIAFINKOHC(Guid DBIIPNGMHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x70B1BD0", Offset = "0x70B03D0", VA = "0x1870B1BD0")]
	public void GILBEEJFGIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct DDOHALFLGNO : IEquatable<DDOHALFLGNO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public NLPICMPDONC IAKMOOCKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(NLPICMPDONC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private PJJOGJFNMIM KJPEHNEANDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x70A3860", Offset = "0x70A2060", VA = "0x1870A3860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private JIKKDKGBDLB POADOIIONBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x70A5B70", Offset = "0x70A4370", VA = "0x1870A5B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private EAPGCLJFNAN MFGGBHIJHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x70A5FE0", Offset = "0x70A47E0", VA = "0x1870A5FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public Vector3 OBGKMPGODFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x70A5E90", Offset = "0x70A4690", VA = "0x1870A5E90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public Quaternion CEPKMIJMOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x70A5C00", Offset = "0x70A4400", VA = "0x1870A5C00")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public COHFKJEBDIE KABNJOJDNJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x70A5940", Offset = "0x70A4140", VA = "0x1870A5940")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	public DDOHALFLGNO(NLPICMPDONC BCECCNCMCGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x70A4F40", Offset = "0x70A3740", VA = "0x1870A4F40")]
	public static bool FMEIMHFCNHG(DDOHALFLGNO INDENPJBLHO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xA85ED0", Offset = "0xA846D0", VA = "0x180A85ED0")]
	public static NLPICMPDONC FMEIMHFCNHG(DDOHALFLGNO INDENPJBLHO)
	{
		return default(NLPICMPDONC);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x70A59D0", Offset = "0x70A41D0", VA = "0x1870A59D0", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(DDOHALFLGNO LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x70A5D40", Offset = "0x70A4540", VA = "0x1870A5D40")]
	public void LOLNNBGCKIA(Vector3 BALIIBCILHH, Quaternion OJEGGOKKPLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x70A5A60", Offset = "0x70A4260", VA = "0x1870A5A60")]
	public void FJJNFJNMEPJ(float FKICLIIJEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x70A5780", Offset = "0x70A3F80", VA = "0x1870A5780")]
	public void APBILJFHBFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct FOHOGCAIENK : IEquatable<FOHOGCAIENK>
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly FOHOGCAIENK EMNAMALOMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public NLPICMPDONC IAKMOOCKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(NLPICMPDONC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public EEJLODDODNB KEKDMLOCEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(EEJLODDODNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public HMJJFBIINHB FLDCGOPMPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(HMJJFBIINHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private PJJOGJFNMIM KJPEHNEANDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x70A3860", Offset = "0x70A2060", VA = "0x1870A3860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	private JIKKDKGBDLB POADOIIONBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x70AB620", Offset = "0x70A9E20", VA = "0x1870AB620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	private HFLAEHHBNFF AODGNDFOEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x70AB5C0", Offset = "0x70A9DC0", VA = "0x1870AB5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public DLIACAMIKND FILJDFDJKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x70AAC60", Offset = "0x70A9460", VA = "0x1870AAC60")]
		get
		{
			return default(DLIACAMIKND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public IEnumerable<COHFKJEBDIE> LBGOPIOOHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x70AB7E0", Offset = "0x70A9FE0", VA = "0x1870AB7E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public IEnumerable<COHFKJEBDIE> GEDABLEAFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x70AB6B0", Offset = "0x70A9EB0", VA = "0x1870AB6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public int DKOJDBHPCKH
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x70ABB00", Offset = "0x70AA300", VA = "0x1870ABB00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public int KHOBFDJJEON
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x70AB110", Offset = "0x70A9910", VA = "0x1870AB110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public string AEHPFKGBHAA
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x70AB540", Offset = "0x70A9D40", VA = "0x1870AB540")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x70ABBB0", Offset = "0x70AA3B0", VA = "0x1870ABBB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public ELBAPEAMABC COMNAECJHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x70ABA10", Offset = "0x70AA210", VA = "0x1870ABA10")]
		get
		{
			return default(ELBAPEAMABC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x70AA530", Offset = "0x70A8D30", VA = "0x1870AA530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public HHJBDBCFGBD ACMGBGNFIGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x70AB090", Offset = "0x70A9890", VA = "0x1870AB090")]
		get
		{
			return default(HHJBDBCFGBD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x70ABD30", Offset = "0x70AA530", VA = "0x1870ABD30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public GCMPNPKCMPJ NEBDJAMILIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x70AB0D0", Offset = "0x70A98D0", VA = "0x1870AB0D0")]
		get
		{
			return default(GCMPNPKCMPJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x70AA580", Offset = "0x70A8D80", VA = "0x1870AA580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public float LOCONMNFKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x70ABCF0", Offset = "0x70AA4F0", VA = "0x1870ABCF0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x70AB040", Offset = "0x70A9840", VA = "0x1870AB040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool PBJMNLFKDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x70AB950", Offset = "0x70AA150", VA = "0x1870AB950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool DOFHMMBMBDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x70AB9B0", Offset = "0x70AA1B0", VA = "0x1870AB9B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool OBIPKELEGMK
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x70AAB80", Offset = "0x70A9380", VA = "0x1870AAB80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool OBNGKPFPMMP
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x70ABAA0", Offset = "0x70AA2A0", VA = "0x1870ABAA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool MIPILACBLOI
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x70ABD80", Offset = "0x70AA580", VA = "0x1870ABD80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x70ABC90", Offset = "0x70AA490", VA = "0x1870ABC90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool KFCADODPMDO
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x70AB160", Offset = "0x70A9960", VA = "0x1870AB160")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x70ABC30", Offset = "0x70AA430", VA = "0x1870ABC30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	public FOHOGCAIENK(NLPICMPDONC BCECCNCMCGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x70A4F40", Offset = "0x70A3740", VA = "0x1870A4F40")]
	public static bool FMEIMHFCNHG(FOHOGCAIENK INDENPJBLHO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x70A5260", Offset = "0x70A3A60", VA = "0x1870A5260")]
	public static bool PCBECHOJFKF(FOHOGCAIENK DAOGAHJCGEC, FOHOGCAIENK NBDADAEEFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x70AAD80", Offset = "0x70A9580", VA = "0x1870AAD80", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(FOHOGCAIENK LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xA85ED0", Offset = "0xA846D0", VA = "0x180A85ED0")]
	public static COHFKJEBDIE FMEIMHFCNHG(FOHOGCAIENK EGGDEECAALI)
	{
		return default(COHFKJEBDIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x70ABB90", Offset = "0x70AA390", VA = "0x1870ABB90")]
	public bool MHNFFPLGAHD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x70ABA50", Offset = "0x70AA250", VA = "0x1870ABA50")]
	public bool LJGAOGNIBNN(IBNNJJAFPLG PNPOCGOGHBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x70AABE0", Offset = "0x70A93E0", VA = "0x1870AABE0")]
	public void DKELDCINLCL(IBNNJJAFPLG PNPOCGOGHBA, bool NLMMCMCMPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x70AAE10", Offset = "0x70A9610", VA = "0x1870AAE10")]
	public DLIACAMIKND FADJOKGJFBJ(Allocator MOBIJPCBMOB)
	{
		return default(DLIACAMIKND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x70AB1A0", Offset = "0x70A99A0", VA = "0x1870AB1A0")]
	public void IODHJDLPGIE(FOHOGCAIENK LIHCAHPMPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x70AA5D0", Offset = "0x70A8DD0", VA = "0x1870AA5D0")]
	public void CMBKFJJMIJP(List<COHFKJEBDIE> OPNJOKBMFIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct ELBINDLBDEO : IEquatable<ELBINDLBDEO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x70A9450", Offset = "0x70A7C50", VA = "0x1870A9450", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(ELBINDLBDEO LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct DANBGNDLGFI : IEquatable<DANBGNDLGFI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private PJJOGJFNMIM KJPEHNEANDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x70A3860", Offset = "0x70A2060", VA = "0x1870A3860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	public DANBGNDLGFI(NLPICMPDONC BCECCNCMCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x70A5650", Offset = "0x70A3E50", VA = "0x1870A5650", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(DANBGNDLGFI LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x70A5510", Offset = "0x70A3D10", VA = "0x1870A5510")]
	public void ANFLKJPBFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x70A55B0", Offset = "0x70A3DB0", VA = "0x1870A55B0")]
	public void CCFHGMIKMLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x70A56E0", Offset = "0x70A3EE0", VA = "0x1870A56E0")]
	public bool FNKCOIODFLL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct HMJJFBIINHB : IEquatable<HMJJFBIINHB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public NLPICMPDONC IAKMOOCKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(NLPICMPDONC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private PJJOGJFNMIM KJPEHNEANDN
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x70A3860", Offset = "0x70A2060", VA = "0x1870A3860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private JIKKDKGBDLB POADOIIONBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x70AFA90", Offset = "0x70AE290", VA = "0x1870AFA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private HFLAEHHBNFF AODGNDFOEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x70AFA30", Offset = "0x70AE230", VA = "0x1870AFA30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public NLPICMPDONC PAJJICKBPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x70AF910", Offset = "0x70AE110", VA = "0x1870AF910")]
		get
		{
			return default(NLPICMPDONC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public COHFKJEBDIE MHMOKMJDLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x70AFB20", Offset = "0x70AE320", VA = "0x1870AFB20")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public COHFKJEBDIE JJAKCGIGEEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x70AF750", Offset = "0x70ADF50", VA = "0x1870AF750")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	public HMJJFBIINHB(NLPICMPDONC BCECCNCMCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x70AF9A0", Offset = "0x70AE1A0", VA = "0x1870AF9A0", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(HMJJFBIINHB LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x70AF7E0", Offset = "0x70ADFE0", VA = "0x1870AF7E0")]
	public bool DDCCBIGAKMA(COHFKJEBDIE NCCLECGLDAO, bool OGNCDPLKMPH = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x70AFDD0", Offset = "0x70AE5D0", VA = "0x1870AFDD0")]
	public bool PIHFFAMBCEP(COHFKJEBDIE IKEBJEMGHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x70AF4D0", Offset = "0x70ADCD0", VA = "0x1870AF4D0")]
	private void ALGMKNLDBII(COHFKJEBDIE LOMKFCCAPBI, List<COHFKJEBDIE> HAOMHBGNKOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x70AFBB0", Offset = "0x70AE3B0", VA = "0x1870AFBB0")]
	public void LOHDMLFFNBM(List<COHFKJEBDIE> KADEIOEJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x70AFE70", Offset = "0x70AE670", VA = "0x1870AFE70")]
	public FOHOGCAIENK PMENJPKANHH()
	{
		return default(FOHOGCAIENK);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x70AFCE0", Offset = "0x70AE4E0", VA = "0x1870AFCE0")]
	public void NLICAMIFCBI(List<COHFKJEBDIE> KADEIOEJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x70AFBC0", Offset = "0x70AE3C0", VA = "0x1870AFBC0")]
	public NativeArray<NLPICMPDONC> NGODKMEJJGF()
	{
		return default(NativeArray<NLPICMPDONC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x70AFD40", Offset = "0x70AE540", VA = "0x1870AFD40")]
	public int PFAKOKENDLG()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct GACPKPNDJOP : IEquatable<GACPKPNDJOP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public string FEFBPCBFNHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x70AC050", Offset = "0x70AA850", VA = "0x1870AC050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public string FMPDDNGHNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x70AC4A0", Offset = "0x70AACA0", VA = "0x1870AC4A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private bool NCNMJIIKOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x70ABDC0", Offset = "0x70AA5C0", VA = "0x1870ABDC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public string APJDGHKJIIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x70ABF60", Offset = "0x70AA760", VA = "0x1870ABF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public string LKPKKOKFINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x70AC250", Offset = "0x70AAA50", VA = "0x1870AC250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public string OMBAFHGNLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x70AC160", Offset = "0x70AA960", VA = "0x1870AC160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	public GACPKPNDJOP(NLPICMPDONC BCECCNCMCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x70AC0D0", Offset = "0x70AA8D0", VA = "0x1870AC0D0", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(GACPKPNDJOP LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct MJPFCKCAKBO : IEquatable<MJPFCKCAKBO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private PJJOGJFNMIM KJPEHNEANDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x70A3860", Offset = "0x70A2060", VA = "0x1870A3860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private JIKKDKGBDLB POADOIIONBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x70B3170", Offset = "0x70B1970", VA = "0x1870B3170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private CDOHJBENMOK KFFCOCFBPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x70B2FE0", Offset = "0x70B17E0", VA = "0x1870B2FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public CBDFFPLOJIF HNDHGJNGJEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x70B33B0", Offset = "0x70B1BB0", VA = "0x1870B33B0")]
		get
		{
			return default(CBDFFPLOJIF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x70B32A0", Offset = "0x70B1AA0", VA = "0x1870B32A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool NOGHPEFGCIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x70B2F50", Offset = "0x70B1750", VA = "0x1870B2F50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x70B34B0", Offset = "0x70B1CB0", VA = "0x1870B34B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public string[] LEJAPIHFPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x70B2EC0", Offset = "0x70B16C0", VA = "0x1870B2EC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x70B2C60", Offset = "0x70B1460", VA = "0x1870B2C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public string[] LLGNOGCEHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x70B3040", Offset = "0x70B1840", VA = "0x1870B3040")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x70B2D90", Offset = "0x70B1590", VA = "0x1870B2D90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public string[] GLINNEKNLCC
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x70B2BD0", Offset = "0x70B13D0", VA = "0x1870B2BD0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x70B2B30", Offset = "0x70B1330", VA = "0x1870B2B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public string[] KBCFBFKAGFO
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x70B2D00", Offset = "0x70B1500", VA = "0x1870B2D00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x70B3200", Offset = "0x70B1A00", VA = "0x1870B3200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	public MJPFCKCAKBO(NLPICMPDONC BCECCNCMCGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0xA85ED0", Offset = "0xA846D0", VA = "0x180A85ED0")]
	public static NLPICMPDONC FMEIMHFCNHG(MJPFCKCAKBO INDENPJBLHO)
	{
		return default(NLPICMPDONC);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x70B2E30", Offset = "0x70B1630", VA = "0x1870B2E30", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(MJPFCKCAKBO LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x70B30D0", Offset = "0x70B18D0", VA = "0x1870B30D0")]
	public bool HDDBPJNOOGM(NLPICMPDONC FGIHDJGGIMF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct FILBHPNPCLM : IEquatable<FILBHPNPCLM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x70AA4A0", Offset = "0x70A8CA0", VA = "0x1870AA4A0", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(FILBHPNPCLM LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct GDHAKMMGNHM : IEquatable<GDHAKMMGNHM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public Collider FHOPBFDDCIH
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x70ACF30", Offset = "0x70AB730", VA = "0x1870ACF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	public GDHAKMMGNHM(NLPICMPDONC BCECCNCMCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x70ACEA0", Offset = "0x70AB6A0", VA = "0x1870ACEA0", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(GDHAKMMGNHM LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x70AD080", Offset = "0x70AB880", VA = "0x1870AD080")]
	public bool JNGJACKIEHG([Out] KIPCMJEHAFM JFOLGMCMDLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x70ACDB0", Offset = "0x70AB5B0", VA = "0x1870ACDB0")]
	public bool CMGPICNBMNJ([Out] NLPICMPDONC KAMAKIBPPKG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct NEPBOLEKLND : IEquatable<NEPBOLEKLND>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public bool GCJOMPBJHHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x70B3840", Offset = "0x70B2040", VA = "0x1870B3840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	public NEPBOLEKLND(NLPICMPDONC BCECCNCMCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x70B37B0", Offset = "0x70B1FB0", VA = "0x1870B37B0", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(NEPBOLEKLND LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct NHICMEMIGCD : IEquatable<NHICMEMIGCD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public NLPICMPDONC IAKMOOCKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(NLPICMPDONC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	private PJJOGJFNMIM KJPEHNEANDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x70A3860", Offset = "0x70A2060", VA = "0x1870A3860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private JIKKDKGBDLB POADOIIONBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x70B4690", Offset = "0x70B2E90", VA = "0x1870B4690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private CCILDPOFEOM DMCPCMCOGKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x70B4630", Offset = "0x70B2E30", VA = "0x1870B4630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	public NHICMEMIGCD(NLPICMPDONC BCECCNCMCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x70B45A0", Offset = "0x70B2DA0", VA = "0x1870B45A0", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(NHICMEMIGCD LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x70B4500", Offset = "0x70B2D00", VA = "0x1870B4500")]
	public void CMCHBOJPHJH(bool JOMBFMIHEII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct NFJNHOFIDEA : IEquatable<NFJNHOFIDEA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public NLPICMPDONC IAKMOOCKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(NLPICMPDONC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private PJJOGJFNMIM KJPEHNEANDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x70A3860", Offset = "0x70A2060", VA = "0x1870A3860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	private JIKKDKGBDLB POADOIIONBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x70B4200", Offset = "0x70B2A00", VA = "0x1870B4200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool CGBPHKCMIPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x70B4390", Offset = "0x70B2B90", VA = "0x1870B4390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool CNHBNDGDJBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x70B3F00", Offset = "0x70B2700", VA = "0x1870B3F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool IMBNIHPLGFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x70B3F90", Offset = "0x70B2790", VA = "0x1870B3F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool OHKKCKLLGMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x70B4170", Offset = "0x70B2970", VA = "0x1870B4170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public bool NAKBFLDCKHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x70B4420", Offset = "0x70B2C20", VA = "0x1870B4420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public bool JBBFECDPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x70B3910", Offset = "0x70B2110", VA = "0x1870B3910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public bool ECKDJJABKCB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x70B3D40", Offset = "0x70B2540", VA = "0x1870B3D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public bool LJPOJKNAHMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x70B39E0", Offset = "0x70B21E0", VA = "0x1870B39E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public bool GCNBAHMAOAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x70B3BC0", Offset = "0x70B23C0", VA = "0x1870B3BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool NKCACDGHNFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x70B42E0", Offset = "0x70B2AE0", VA = "0x1870B42E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool EGOMADJDGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x70B4290", Offset = "0x70B2A90", VA = "0x1870B4290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool IJGEBKDMBAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x70B43D0", Offset = "0x70B2BD0", VA = "0x1870B43D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool KCNHJNILOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x70B3E70", Offset = "0x70B2670", VA = "0x1870B3E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool GKHMOINIBGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x70B44C0", Offset = "0x70B2CC0", VA = "0x1870B44C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x70B3E10", Offset = "0x70B2610", VA = "0x1870B3E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public ECFHGLELIKG CGJILLNPMIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x70B3A30", Offset = "0x70B2230", VA = "0x1870B3A30")]
		get
		{
			return default(ECFHGLELIKG);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x70B4470", Offset = "0x70B2C70", VA = "0x1870B4470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool GLNPGBAJLEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x70B3FE0", Offset = "0x70B27E0", VA = "0x1870B3FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public INHFPBMEMPN EBHJDNKFOGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x70B3F50", Offset = "0x70B2750", VA = "0x1870B3F50")]
		get
		{
			return default(INHFPBMEMPN);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x70B3B70", Offset = "0x70B2370", VA = "0x1870B3B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool FBCDIPOHKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x70B41C0", Offset = "0x70B29C0", VA = "0x1870B41C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Vector3 CLEFAOHDJKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x70B3960", Offset = "0x70B2160", VA = "0x1870B3960")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public Vector3 JJJEHNNMECK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x70B3D90", Offset = "0x70B2590", VA = "0x1870B3D90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public bool DCMJKPPNGFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x70B3A70", Offset = "0x70B2270", VA = "0x1870B3A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	public NFJNHOFIDEA(NLPICMPDONC BCECCNCMCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x70B3C60", Offset = "0x70B2460", VA = "0x1870B3C60", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(NFJNHOFIDEA LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x70B4330", Offset = "0x70B2B30", VA = "0x1870B4330")]
	public bool NLNEEDINPEF(JIFEMNLPCNF PNPOCGOGHBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x70B3CF0", Offset = "0x70B24F0", VA = "0x1870B3CF0")]
	public bool FANDBGIDEAP(CDEPPFIGPHB PNPOCGOGHBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x70B3890", Offset = "0x70B2090", VA = "0x1870B3890")]
	public void AELMHMOJDOI(CDEPPFIGPHB PNPOCGOGHBA, bool NLMMCMCMPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x70B3EC0", Offset = "0x70B26C0", VA = "0x1870B3EC0")]
	public CDEPPFIGPHB GEJDMMJOMFG()
	{
		return default(CDEPPFIGPHB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x70B3C10", Offset = "0x70B2410", VA = "0x1870B3C10")]
	public bool EEBKMGJJHBP(CDEPPFIGPHB INDENPJBLHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct IAOAONIABGB : IEquatable<IAOAONIABGB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private PJJOGJFNMIM KJPEHNEANDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x70A3860", Offset = "0x70A2060", VA = "0x1870A3860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	private JIKKDKGBDLB POADOIIONBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x70B07B0", Offset = "0x70AEFB0", VA = "0x1870B07B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	private COFCEECBFGH IKJCNFMFKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x70B0A80", Offset = "0x70AF280", VA = "0x1870B0A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	public IAOAONIABGB(NLPICMPDONC BCECCNCMCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x70B0300", Offset = "0x70AEB00", VA = "0x1870B0300", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(IAOAONIABGB LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x70B0570", Offset = "0x70AED70", VA = "0x1870B0570")]
	public bool HIPDBPDOKCC(JBOELMKONKK NNGPPKEHFMP, List<COHFKJEBDIE> OPNJOKBMFIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x70B06A0", Offset = "0x70AEEA0", VA = "0x1870B06A0")]
	public int HNIBJGDCKOF(JBOELMKONKK NNGPPKEHFMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x70B0970", Offset = "0x70AF170", VA = "0x1870B0970")]
	public void NMNKHFFPAII(List<COHFKJEBDIE> OPNJOKBMFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x70B0840", Offset = "0x70AF040", VA = "0x1870B0840")]
	public int NBGOGJONJGM(COHFKJEBDIE BIINCLMPDMO, JBOELMKONKK NNGPPKEHFMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x70B0010", Offset = "0x70AE810", VA = "0x1870B0010")]
	public COHFKJEBDIE BJLPKDNGKJK(int ECDOOAABOPD, JBOELMKONKK NNGPPKEHFMP)
	{
		return default(COHFKJEBDIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x70B0440", Offset = "0x70AEC40", VA = "0x1870B0440")]
	public void GDADJBEGGPE(COHFKJEBDIE BIINCLMPDMO, JBOELMKONKK NNGPPKEHFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x70B0390", Offset = "0x70AEB90", VA = "0x1870B0390")]
	public bool FIMEJLOEIKM(COHFKJEBDIE BIINCLMPDMO, JBOELMKONKK NNGPPKEHFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x70AFF00", Offset = "0x70AE700", VA = "0x1870AFF00")]
	public void AACKFDCEDMG(JBOELMKONKK NNGPPKEHFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x70B0250", Offset = "0x70AEA50", VA = "0x1870B0250")]
	public bool EGFJIKHHGMO(COHFKJEBDIE BIINCLMPDMO, JBOELMKONKK NNGPPKEHFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x70B0140", Offset = "0x70AE940", VA = "0x1870B0140")]
	public bool CCKLBJOMKEP(JBOELMKONKK NNGPPKEHFMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct CHFMEPPLNJI : IEquatable<CHFMEPPLNJI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public NLPICMPDONC IAKMOOCKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(NLPICMPDONC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private PJJOGJFNMIM KJPEHNEANDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x70A3860", Offset = "0x70A2060", VA = "0x1870A3860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	private JIKKDKGBDLB POADOIIONBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x70A4790", Offset = "0x70A2F90", VA = "0x1870A4790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	public CHFMEPPLNJI(NLPICMPDONC BCECCNCMCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x70A4700", Offset = "0x70A2F00", VA = "0x1870A4700", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(CHFMEPPLNJI LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x70A4820", Offset = "0x70A3020", VA = "0x1870A4820")]
	public void LACGCLCHDEC(bool INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x70A48B0", Offset = "0x70A30B0", VA = "0x1870A48B0")]
	public void LHOGBIGLDFN(bool INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x2E610C0", Offset = "0x2E5F8C0", VA = "0x182E610C0")]
	public T DDDMOLAADDO<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct BAJDCCNGOIN : IEquatable<BAJDCCNGOIN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public NLPICMPDONC IAKMOOCKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(NLPICMPDONC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private PJJOGJFNMIM KJPEHNEANDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x70A3860", Offset = "0x70A2060", VA = "0x1870A3860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private JIKKDKGBDLB POADOIIONBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x70A3DB0", Offset = "0x70A25B0", VA = "0x1870A3DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	private HABOCNEGLON AKNGPLGLIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x70A3E40", Offset = "0x70A2640", VA = "0x1870A3E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public bool OHHOEBNLIBH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x70A3EA0", Offset = "0x70A26A0", VA = "0x1870A3EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public bool OAGIFGMOOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x70A3C90", Offset = "0x70A2490", VA = "0x1870A3C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	public BAJDCCNGOIN(NLPICMPDONC BCECCNCMCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x70A3D20", Offset = "0x70A2520", VA = "0x1870A3D20", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(BAJDCCNGOIN LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct CHDIDCFJFOI : IEquatable<CHDIDCFJFOI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x70A4670", Offset = "0x70A2E70", VA = "0x1870A4670", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(CHDIDCFJFOI LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct NNEIMABPMFB : IEquatable<NNEIMABPMFB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public NLPICMPDONC IAKMOOCKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(NLPICMPDONC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private PJJOGJFNMIM KJPEHNEANDN
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x70A3860", Offset = "0x70A2060", VA = "0x1870A3860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private JIKKDKGBDLB POADOIIONBB
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x70B5680", Offset = "0x70B3E80", VA = "0x1870B5680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private LIGDBFMOLCN ACKBPNCEOHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x70B5C20", Offset = "0x70B4420", VA = "0x1870B5C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private FOKHHODNCAE PCLLJBLNGJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x70B54F0", Offset = "0x70B3CF0", VA = "0x1870B54F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool NGKMLFEAFHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x70B5550", Offset = "0x70B3D50", VA = "0x1870B5550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool NKADJCLLCOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x70B5AF0", Offset = "0x70B42F0", VA = "0x1870B5AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool INMGEMBCNAO
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x70B5710", Offset = "0x70B3F10", VA = "0x1870B5710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool FHCJEOCJECN
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x70B5910", Offset = "0x70B4110", VA = "0x1870B5910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool KNJPJOCDPFP
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x70B58E0", Offset = "0x70B40E0", VA = "0x1870B58E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool FEHLPPFKJBM
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x70B5B90", Offset = "0x70B4390", VA = "0x1870B5B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public bool MGHKMFFFDJP
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x70B5D30", Offset = "0x70B4530", VA = "0x1870B5D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public bool EFMFDCJFKNN
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x70B5140", Offset = "0x70B3940", VA = "0x1870B5140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool CBAJNNMJBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x70B5740", Offset = "0x70B3F40", VA = "0x1870B5740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	public NNEIMABPMFB(NLPICMPDONC BCECCNCMCGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x70A4F40", Offset = "0x70A3740", VA = "0x1870A4F40")]
	public static bool FMEIMHFCNHG(NNEIMABPMFB INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x70B5460", Offset = "0x70B3C60", VA = "0x1870B5460", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(NNEIMABPMFB LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x70B59E0", Offset = "0x70B41E0", VA = "0x1870B59E0")]
	public bool MNEAAKGHFJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x70B5A50", Offset = "0x70B4250", VA = "0x1870B5A50")]
	public COHFKJEBDIE NGDNGOGKMHE(COHFKJEBDIE BIINCLMPDMO)
	{
		return default(COHFKJEBDIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x70B5350", Offset = "0x70B3B50", VA = "0x1870B5350")]
	public NLPICMPDONC BJAOEHPJFDP()
	{
		return default(NLPICMPDONC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x70B55E0", Offset = "0x70B3DE0", VA = "0x1870B55E0")]
	public bool IJJMGGCICIB(NLPICMPDONC EFCDBBNPLBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x70B52B0", Offset = "0x70B3AB0", VA = "0x1870B52B0")]
	public bool AKCDMMBNPAK(NLPICMPDONC CCBPINNNGCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x70B5C80", Offset = "0x70B4480", VA = "0x1870B5C80")]
	public bool OEKIPKBDGFA(NLPICMPDONC BIINCLMPDMO, [Out] NLPICMPDONC EFCDBBNPLBH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct IOLDNKIJJJK : IEquatable<IOLDNKIJJJK>
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly IOLDNKIJJJK EMNAMALOMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public NLPICMPDONC IAKMOOCKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(NLPICMPDONC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public EEJLODDODNB KEKDMLOCEEG
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(EEJLODDODNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public HMJJFBIINHB FLDCGOPMPGN
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(HMJJFBIINHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public EIHHNGMFHPM KEHLIBNFKIM
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x70B1190", Offset = "0x70AF990", VA = "0x1870B1190")]
		get
		{
			return default(EIHHNGMFHPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public KDFAPGKOLBP JLCDCPNFHLG
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x70B1070", Offset = "0x70AF870", VA = "0x1870B1070")]
		get
		{
			return default(KDFAPGKOLBP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x70B12B0", Offset = "0x70AFAB0", VA = "0x1870B12B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public KIHOFADNKAM OAPEFBDFDDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x70B1530", Offset = "0x70AFD30", VA = "0x1870B1530")]
		get
		{
			return default(KIHOFADNKAM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x70B1300", Offset = "0x70AFB00", VA = "0x1870B1300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public float CLMKHNJMHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x70B1350", Offset = "0x70AFB50", VA = "0x1870B1350")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x70B1410", Offset = "0x70AFC10", VA = "0x1870B1410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public Vector3 JACNOFOMCGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x70B1460", Offset = "0x70AFC60", VA = "0x1870B1460")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x70B1390", Offset = "0x70AFB90", VA = "0x1870B1390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public float BCBOOJHHOIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x70B1260", Offset = "0x70AFA60", VA = "0x1870B1260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public JIKEHJJLJAI CLAPJGNLABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x70B1100", Offset = "0x70AF900", VA = "0x1870B1100")]
		get
		{
			return default(JIKEHJJLJAI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x70B1140", Offset = "0x70AF940", VA = "0x1870B1140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	public IOLDNKIJJJK(NLPICMPDONC BCECCNCMCGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x70A4F40", Offset = "0x70A3740", VA = "0x1870A4F40")]
	public static bool FMEIMHFCNHG(IOLDNKIJJJK INDENPJBLHO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x70A4DA0", Offset = "0x70A35A0", VA = "0x1870A4DA0")]
	public static bool DJBIFFEEEPL(IOLDNKIJJJK DAOGAHJCGEC, IOLDNKIJJJK NBDADAEEFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x70B11D0", Offset = "0x70AF9D0", VA = "0x1870B11D0", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(IOLDNKIJJJK LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x70B10B0", Offset = "0x70AF8B0", VA = "0x1870B10B0")]
	public JIFJKOAHNFO BEICILHLIMM()
	{
		return default(JIFJKOAHNFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x70B14E0", Offset = "0x70AFCE0", VA = "0x1870B14E0")]
	public ENCIOJMOOGP OBDLJMNOHCC()
	{
		return default(ENCIOJMOOGP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct JIFJKOAHNFO : IEquatable<JIFJKOAHNFO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public NLPICMPDONC IAKMOOCKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(NLPICMPDONC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public IOLDNKIJJJK OPFDAGLGEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(IOLDNKIJJJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public KCDIPBECKHL JOFNHCCGGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x70B1600", Offset = "0x70AFE00", VA = "0x1870B1600")]
		get
		{
			return default(KCDIPBECKHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	public JIFJKOAHNFO(NLPICMPDONC BCECCNCMCGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x70A4F40", Offset = "0x70A3740", VA = "0x1870A4F40")]
	public static bool FMEIMHFCNHG(JIFJKOAHNFO INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x70B1570", Offset = "0x70AFD70", VA = "0x1870B1570", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(JIFJKOAHNFO LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DefaultMember("Item")]
public readonly struct ENCIOJMOOGP : IEquatable<ENCIOJMOOGP>
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly ENCIOJMOOGP EMNAMALOMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public NLPICMPDONC IAKMOOCKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(NLPICMPDONC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public EEJLODDODNB KEKDMLOCEEG
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(EEJLODDODNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private PJJOGJFNMIM KJPEHNEANDN
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x70A3860", Offset = "0x70A2060", VA = "0x1870A3860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	private JIKKDKGBDLB POADOIIONBB
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x70A9C30", Offset = "0x70A8430", VA = "0x1870A9C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private KNMBABCNKJO IJEAKFCMHII
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x70A9830", Offset = "0x70A8030", VA = "0x1870A9830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public IOLDNKIJJJK OPFDAGLGEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(IOLDNKIJJJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public GMIJGAFIAIM JLFJKDHAMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x70A9CC0", Offset = "0x70A84C0", VA = "0x1870A9CC0")]
		get
		{
			return default(GMIJGAFIAIM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x70A9B10", Offset = "0x70A8310", VA = "0x1870A9B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public IEnumerable<GADNAPGBOLM> IGIBGLPADCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x70A9920", Offset = "0x70A8120", VA = "0x1870A9920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public GADNAPGBOLM DBNKEBOPCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x70A9DE0", Offset = "0x70A85E0", VA = "0x1870A9DE0")]
		get
		{
			return default(GADNAPGBOLM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public int BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x70A9EF0", Offset = "0x70A86F0", VA = "0x1870A9EF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	public ENCIOJMOOGP(NLPICMPDONC BCECCNCMCGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x70A4F40", Offset = "0x70A3740", VA = "0x1870A4F40")]
	public static bool FMEIMHFCNHG(ENCIOJMOOGP INDENPJBLHO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x70A5260", Offset = "0x70A3A60", VA = "0x1870A5260")]
	public static bool PCBECHOJFKF(ENCIOJMOOGP DAOGAHJCGEC, ENCIOJMOOGP NBDADAEEFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x70A9890", Offset = "0x70A8090", VA = "0x1870A9890", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(ENCIOJMOOGP LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x70A94E0", Offset = "0x70A7CE0", VA = "0x1870A94E0")]
	public GADNAPGBOLM BDGOPCJIDAH(float3? BALIIBCILHH, [Optional] quaternion? OJEGGOKKPLF, [Optional] Vector3? FKICLIIJEHG)
	{
		return default(GADNAPGBOLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x70A9F80", Offset = "0x70A8780", VA = "0x1870A9F80")]
	public GADNAPGBOLM PEGGGLMFMFF(int ECDOOAABOPD, float3? BALIIBCILHH, [Optional] quaternion? OJEGGOKKPLF, [Optional] Vector3? FKICLIIJEHG)
	{
		return default(GADNAPGBOLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x70A9790", Offset = "0x70A7F90", VA = "0x1870A9790")]
	public void DOCBBKKFCAB(int ECDOOAABOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x70A9700", Offset = "0x70A7F00", VA = "0x1870A9700")]
	public void CPGLBCDJJEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct GADNAPGBOLM : IEquatable<GADNAPGBOLM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public NLPICMPDONC IAKMOOCKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(NLPICMPDONC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public ENCIOJMOOGP OPDEIDKAKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x70AC810", Offset = "0x70AB010", VA = "0x1870AC810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public float3 MAGAFCIBJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x70AC720", Offset = "0x70AAF20", VA = "0x1870AC720")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x70AC890", Offset = "0x70AB090", VA = "0x1870AC890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public quaternion HPCBIJNFAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x70AC5D0", Offset = "0x70AADD0", VA = "0x1870AC5D0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x70AC680", Offset = "0x70AAE80", VA = "0x1870AC680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public float3 IBIBACKHKLD
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x70AC620", Offset = "0x70AAE20", VA = "0x1870AC620")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x70AC8F0", Offset = "0x70AB0F0", VA = "0x1870AC8F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public IPENIDGIMGH GLMJCEOHCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x70AC6D0", Offset = "0x70AAED0", VA = "0x1870AC6D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	public GADNAPGBOLM(NLPICMPDONC BCECCNCMCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x70AC780", Offset = "0x70AAF80", VA = "0x1870AC780", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(GADNAPGBOLM LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x70AC950", Offset = "0x70AB150", VA = "0x1870AC950")]
	public void IAPEBHOINBG(ENCIOJMOOGP INDENPJBLHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct APGAJEOGAJF : IEquatable<APGAJEOGAJF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public NLPICMPDONC IAKMOOCKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(NLPICMPDONC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	private PJJOGJFNMIM KJPEHNEANDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x70A3860", Offset = "0x70A2060", VA = "0x1870A3860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	private JIKKDKGBDLB POADOIIONBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x70A35F0", Offset = "0x70A1DF0", VA = "0x1870A35F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	private EEPDPHLFPIE DLNGMPMIEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x70A3280", Offset = "0x70A1A80", VA = "0x1870A3280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public bool BEHLKHELLJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x70A35A0", Offset = "0x70A1DA0", VA = "0x1870A35A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x70A34B0", Offset = "0x70A1CB0", VA = "0x1870A34B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public bool ODIELKGCDMO
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x70A3430", Offset = "0x70A1C30", VA = "0x1870A3430")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x70A32E0", Offset = "0x70A1AE0", VA = "0x1870A32E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public float BFDLNMJLLMD
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x70A3560", Offset = "0x70A1D60", VA = "0x1870A3560")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x70A3510", Offset = "0x70A1D10", VA = "0x1870A3510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public bool ILAIGJFGEBG
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x70A3340", Offset = "0x70A1B40", VA = "0x1870A3340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	public APGAJEOGAJF(NLPICMPDONC BCECCNCMCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x70A33A0", Offset = "0x70A1BA0", VA = "0x1870A33A0", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(APGAJEOGAJF LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x70A39D0", Offset = "0x70A21D0", VA = "0x1870A39D0")]
	public void OFPGCLBGMAP(int AFJCLAOHICF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x70A38C0", Offset = "0x70A20C0", VA = "0x1870A38C0")]
	public bool NMDHKAOHMNP([Out] int AFJCLAOHICF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x70A30A0", Offset = "0x70A18A0", VA = "0x1870A30A0")]
	public void AKDIFGKCEGI(bool DPMNHMKBOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C20", Offset = "0x70A2420", VA = "0x1870A3C20")]
	public bool PFOBKCLGMON(HCMCHHADEDD PNPOCGOGHBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x70A3A70", Offset = "0x70A2270", VA = "0x1870A3A70")]
	public void OLHLFPLAFLB(HCMCHHADEDD PNPOCGOGHBA, bool NLMMCMCMPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x70A3140", Offset = "0x70A1940", VA = "0x1870A3140")]
	public void APHLHPOLCOE(float FPDMMLDGKNC, float NDHKLMFMFJG, float LFMHKBMDBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x70A3680", Offset = "0x70A1E80", VA = "0x1870A3680")]
	public void LLFMELPOMPP(float3 ECHFFJIICOK, quaternion KEGHBFFAIEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x70A3AF0", Offset = "0x70A22F0", VA = "0x1870A3AF0")]
	public bool PBDCIDOGGME([Out] float3 ECHFFJIICOK, [Out] quaternion KEGHBFFAIEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x70A2F70", Offset = "0x70A1770", VA = "0x1870A2F70")]
	public bool AAFEMKDMMOE([Out] float CHKPLABLNBG, [Out] float BDFLLGHGBLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x70A37D0", Offset = "0x70A1FD0", VA = "0x1870A37D0")]
	public void LMBMKBEHPCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct EEJLODDODNB : IEquatable<EEJLODDODNB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public HMJJFBIINHB FLDCGOPMPGN
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(HMJJFBIINHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private PJJOGJFNMIM KJPEHNEANDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x70A3860", Offset = "0x70A2060", VA = "0x1870A3860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	private IMJOBFPMAKJ HPADFEOGHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x70A8D60", Offset = "0x70A7560", VA = "0x1870A8D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public bool DPBKFADAAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x70A7E70", Offset = "0x70A6670", VA = "0x1870A7E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public Vector3 MAGAFCIBJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x70A77F0", Offset = "0x70A5FF0", VA = "0x1870A77F0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x70A7B20", Offset = "0x70A6320", VA = "0x1870A7B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Quaternion HPCBIJNFAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x70A6C70", Offset = "0x70A5470", VA = "0x1870A6C70")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x70A7650", Offset = "0x70A5E50", VA = "0x1870A7650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public Vector3 KANAGPKDKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x70A8E20", Offset = "0x70A7620", VA = "0x1870A8E20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x70A82D0", Offset = "0x70A6AD0", VA = "0x1870A82D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public Quaternion OCICAGHFMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x70A8C20", Offset = "0x70A7420", VA = "0x1870A8C20")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x70A85A0", Offset = "0x70A6DA0", VA = "0x1870A85A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public float MIHAIJGPNOI
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x70A8050", Offset = "0x70A6850", VA = "0x1870A8050")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x70A79E0", Offset = "0x70A61E0", VA = "0x1870A79E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public float FKDCOACEDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x70A7940", Offset = "0x70A6140", VA = "0x1870A7940")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public Vector3 IBIBACKHKLD
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x70A6F00", Offset = "0x70A5700", VA = "0x1870A6F00")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x70A7F80", Offset = "0x70A6780", VA = "0x1870A7F80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public Vector3 GHINJEIGAAP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x70A6DB0", Offset = "0x70A55B0", VA = "0x1870A6DB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public Vector3 EHLEGKBDGOM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x70A71F0", Offset = "0x70A59F0", VA = "0x1870A71F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public Matrix4x4 LCJONKEHLIL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x70A7D40", Offset = "0x70A6540", VA = "0x1870A7D40")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	public EEJLODDODNB(NLPICMPDONC BCECCNCMCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x70A7A90", Offset = "0x70A6290", VA = "0x1870A7A90", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(EEJLODDODNB LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x70A6930", Offset = "0x70A5130", VA = "0x1870A6930")]
	public IGANFMNEEBA ABDJOOKCLCN()
	{
		return default(IGANFMNEEBA);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x70A8490", Offset = "0x70A6C90", VA = "0x1870A8490")]
	public void LJAOJOCAAML([Out] Matrix4x4 KBJBMNDHNHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x70A7340", Offset = "0x70A5B40", VA = "0x1870A7340")]
	public void CMJMCOMGLOJ([Out] Vector3 KCGODCAKPIB, [Out] Quaternion DAMLBBHHMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x70A7420", Offset = "0x70A5C20", VA = "0x1870A7420")]
	public void CMJMCOMGLOJ([Out] RigidTransform EACKELHAIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x70A90C0", Offset = "0x70A78C0", VA = "0x1870A90C0")]
	public void PHKKBPGNOMC([In] Vector3 KCGODCAKPIB, [In] Quaternion DAMLBBHHMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x70A8670", Offset = "0x70A6E70", VA = "0x1870A8670")]
	public void MEKKMCKCGKM([Out] Vector3 KCGODCAKPIB, [Out] Quaternion DAMLBBHHMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x70A8750", Offset = "0x70A6F50", VA = "0x1870A8750")]
	public void MEKKMCKCGKM([Out] RigidTransform EACKELHAIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x70A8460", Offset = "0x70A6C60", VA = "0x1870A8460")]
	public UniformTRS KPMOBAANOJC()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x70A83A0", Offset = "0x70A6BA0", VA = "0x1870A83A0")]
	public void KPMOBAANOJC([Out] UniformTRS PJDIPJCPCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x70A7D80", Offset = "0x70A6580", VA = "0x1870A7D80")]
	public UniformTRS GFOBOOOPCPP()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x70A7DB0", Offset = "0x70A65B0", VA = "0x1870A7DB0")]
	public void GFOBOOOPCPP([Out] UniformTRS EACKELHAIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x70A8F70", Offset = "0x70A7770", VA = "0x1870A8F70")]
	public Vector3 OMCIEHFEIPM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x70A7720", Offset = "0x70A5F20", VA = "0x1870A7720")]
	public void EGHPADAMLCO([In] Vector3 INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x70A7BF0", Offset = "0x70A63F0", VA = "0x1870A7BF0")]
	public Vector3 FPHOOJEDAKB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x70A6980", Offset = "0x70A5180", VA = "0x1870A6980")]
	public void AOMFLNGEDCA([In] Vector3 INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x70A67F0", Offset = "0x70A4FF0", VA = "0x1870A67F0")]
	public Quaternion AAPPGEFBJJE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x70A8B50", Offset = "0x70A7350", VA = "0x1870A8B50")]
	public void NPCCLNBCLIP([In] Quaternion INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x70A8190", Offset = "0x70A6990", VA = "0x1870A8190")]
	public Quaternion KLBLNALAAEF()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x70A74D0", Offset = "0x70A5CD0", VA = "0x1870A74D0")]
	public void COJAJHMHLNP([In] Quaternion INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x70A80F0", Offset = "0x70A68F0", VA = "0x1870A80F0")]
	public float KENBMPOHAKG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x70A8AA0", Offset = "0x70A72A0", VA = "0x1870A8AA0")]
	public void NAHMHLOFMNL(float INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x70A91C0", Offset = "0x70A79C0", VA = "0x1870A91C0")]
	public float PJHGIFJIOHM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x70A75A0", Offset = "0x70A5DA0", VA = "0x1870A75A0")]
	public void DEMLKECODDJ(float INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x70A6A50", Offset = "0x70A5250", VA = "0x1870A6A50")]
	public void BCBGMFDEIMC([In] Vector3 INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x70A8800", Offset = "0x70A7000", VA = "0x1870A8800")]
	public Vector3 MFMKPIMCBJM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x70A7EB0", Offset = "0x70A66B0", VA = "0x1870A7EB0")]
	public void HIHLMENFJOK([In] Vector3 INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x70A6B20", Offset = "0x70A5320", VA = "0x1870A6B20")]
	public Vector3 BDDJPCOAALP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x70A7050", Offset = "0x70A5850", VA = "0x1870A7050")]
	public void CEGLLPGINGO([In] Vector3 INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x70A8950", Offset = "0x70A7150", VA = "0x1870A8950")]
	public Vector3 MOJCGPEBIKK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x70A7120", Offset = "0x70A5920", VA = "0x1870A7120")]
	public void CFPGLAAAJLN([In] Vector3 INDENPJBLHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct BHOGIGGHPFE : IEquatable<BHOGIGGHPFE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	private PJJOGJFNMIM KJPEHNEANDN
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x70A3860", Offset = "0x70A2060", VA = "0x1870A3860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	private JIKKDKGBDLB POADOIIONBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x70A4160", Offset = "0x70A2960", VA = "0x1870A4160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	private FLMLIDNECPL KCHLDDMCFKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x70A3F30", Offset = "0x70A2730", VA = "0x1870A3F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
	public BHOGIGGHPFE(NLPICMPDONC BCECCNCMCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A1C80", VA = "0x1870A3480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x70A40D0", Offset = "0x70A28D0", VA = "0x1870A40D0", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x70A3390", Offset = "0x70A1B90", VA = "0x1870A3390", Slot = "4")]
	public bool Equals(BHOGIGGHPFE LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C70", Offset = "0x70A2470", VA = "0x1870A3C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x70A3F90", Offset = "0x70A2790", VA = "0x1870A3F90")]
	public void BGGLKKHLLCG(string LJMDFKCKKHM, HCJHPMIHCEN HIOGCNEKLDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class OKBBIBLHKOB
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private struct IGBKCFPJIDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Guid PLMJELCKKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public MLCFEFNMFEP MHPOFEJBJDM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private struct MLCFEFNMFEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int INDENPJBLHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int FMMIBJNHACN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int BNPHHPHFBPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int NFMEJICHLDE;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x70B3550", Offset = "0x70B1D50", VA = "0x1870B3550")]
		public bool DAPGJKEHHHL([Out] HDJIEEPKAHE JINIJLGMOEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x70B35E0", Offset = "0x70B1DE0", VA = "0x1870B35E0")]
		public MLCFEFNMFEP(HDJIEEPKAHE JINIJLGMOEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x70B64E0", Offset = "0x70B4CE0", VA = "0x1870B64E0")]
	public static Guid BMAHAMLMHKJ(this HDJIEEPKAHE JINIJLGMOEA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x70B6580", Offset = "0x70B4D80", VA = "0x1870B6580")]
	public static bool HADCBHBADOO(this Guid PLMJELCKKDA, [Out] HDJIEEPKAHE JINIJLGMOEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal static class NPHIIHANFMD
{
	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x70B6300", Offset = "0x70B4B00", VA = "0x1870B6300")]
	public static JIKKDKGBDLB POADOIIONBB(this NLPICMPDONC DOBPKLNCBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x70B5F40", Offset = "0x70B4740", VA = "0x1870B5F40")]
	public static GIAJMCLBEFD EEGIJJFADFF(this NLPICMPDONC DOBPKLNCBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x70B6200", Offset = "0x70B4A00", VA = "0x1870B6200")]
	public static EntityManager LMPOOGFFNHC(this NLPICMPDONC DOBPKLNCBDO)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x31D77B0", Offset = "0x31D5FB0", VA = "0x1831D77B0")]
	internal static bool OCDAHMLGKOE<T>(this NLPICMPDONC DOBPKLNCBDO, bool NLMMCMCMPNL) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x70B6010", Offset = "0x70B4810", VA = "0x1870B6010")]
	public static bool EHKDEPOLOMI(this NLPICMPDONC DOBPKLNCBDO, JDHJHMOFOLO MFCFAMOHGBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x31D5520", Offset = "0x31D3D20", VA = "0x1831D5520")]
	public static bool MFOABJHACNK<T>(this NLPICMPDONC DOBPKLNCBDO) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x31D7890", Offset = "0x31D6090", VA = "0x1831D7890")]
	public static bool OGMLBNKEOCF<T>(this NLPICMPDONC DOBPKLNCBDO) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x31D7940", Offset = "0x31D6140", VA = "0x1831D7940")]
	[PFKAANLEJBN]
	public static T PJNHBDAPOBJ<T>(this NLPICMPDONC DOBPKLNCBDO) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x31D57A0", Offset = "0x31D3FA0", VA = "0x1831D57A0")]
	[PFKAANLEJBN]
	public static T NHCFDBNNCKL<T>(this NLPICMPDONC DOBPKLNCBDO) where T : struct, IComponentData
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JBNNPMJGKEL
{
	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JBNNKFLOGED(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HNCOOBJLHOB(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task OLHIFABHJKC(COHFKJEBDIE INCBEIDOHDO);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HMANOIOLGIJ(NLPICMPDONC BCECCNCMCGN, [Out] Guid JJFBINJJNLK);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid KJOEOKBCNAF(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PDDHPPLEIPI(NLPICMPDONC BCECCNCMCGN, Guid JJFBINJJNLK);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PHOBOHABFJN(NLPICMPDONC BCECCNCMCGN, [Out] Guid FJIFOJCFNEO);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Guid DFCPANJNBMA(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HJIAFINKOHC(NLPICMPDONC BCECCNCMCGN, Guid FJIFOJCFNEO);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GILBEEJFGIO(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task MILDJHMPIHB(NLPICMPDONC IDCFOEBAIPD, NLPICMPDONC NCCLECGLDAO);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface GJJNNBKFPEN
{
	[Cpp2IlInjected.Token(Token = "0x17000179")]
	Guid IGOHLLPCLGO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DLMCKGMFKLP(NativeList<Guid> ILKIKBEJMDI, NativeList<Guid> AKNDAKIMFAD, NativeList<FixedString64Bytes> EPCHFJLDEJD);
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HABOCNEGLON
{
	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KMPELAEMCLF(List<NLPICMPDONC> JDCCHMHNGLB);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ANPMLCNDGPK(List<NLPICMPDONC> GMDHIEFOGKJ);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PJBIFFHDPEG(NLPICMPDONC KKPONDJIGMO);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OHHOEBNLIBH(NLPICMPDONC KKPONDJIGMO);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OAGIFGMOOOI(NLPICMPDONC KKPONDJIGMO);

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int EILLHDJLFCO(NLPICMPDONC KKPONDJIGMO);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void APAOINLAFKK(NLPICMPDONC KKPONDJIGMO, int LGAFEOMEGIH);

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NLPICMPDONC FBNMBBMFEOH(NLPICMPDONC BAFMFPBOLIC);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int OBOOGOOMFHG(NLPICMPDONC BAFMFPBOLIC);

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AOMALLOILNB(NLPICMPDONC BAFMFPBOLIC, int GFNCPGCKHCL);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int EBNALMKOFDL(NLPICMPDONC BAFMFPBOLIC);

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IEILILNGFBD(NLPICMPDONC BAFMFPBOLIC, int MAEBENPHJJH);

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HGCBCMFGLKN(NLPICMPDONC JDJHDGCHHFG);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CNEFLAPEBLI(NLPICMPDONC BCECCNCMCGN, bool JGJCHBGCLFD);

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HCJNAIKMMJH(NLPICMPDONC[] OBBIGKIBBBG, bool JGJCHBGCLFD);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FKKNCHCANGF
{
	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HDJIEEPKAHE[] GGANEJCKNMD(string IKMKCMDHFDC, COHFKJEBDIE ECLOICLFHIE, bool CKOJOHKNHLB = false);

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJMOOHDLGGN(string GGLFPAKLDNL, HDJIEEPKAHE[] FCJKDFCDMDN);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface EAPGCLJFNAN
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<NLPICMPDONC, NLPICMPDONC> HHNJPLPLMNI;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<NLPICMPDONC, NLPICMPDONC> COPJBHCHMKF;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<NLPICMPDONC, NLPICMPDONC, NLPICMPDONC> KJIOCPPHHBH;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<NLPICMPDONC> GIHICFLCENO;

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HFINOHPMANA(NLPICMPDONC BCECCNCMCGN, NLPICMPDONC OKAKABGBPOG);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NLPICMPDONC LHBCIHKHCNE(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DLIACAMIKND MPNIHALDNEB(NLPICMPDONC BCECCNCMCGN, Allocator MOBIJPCBMOB);

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NLPICMPDONC OPCLJPPNOHK(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LOLNNBGCKIA(NLPICMPDONC BCECCNCMCGN, Vector3 PEFINJDLJNE, Quaternion AMDPIHMKEKI);

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FJJNFJNMEPJ(NLPICMPDONC BCECCNCMCGN, float KDHKEEFDLKB);

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool IHLIGHEECNH(NLPICMPDONC BCECCNCMCGN, [Out] NLPICMPDONC NCCLECGLDAO);

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool AEEKMBKEHEL(NLPICMPDONC BCECCNCMCGN, [Out] RigidTransform IPOOOBNCCAG);

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool PGPCICIDDEM(NLPICMPDONC BCECCNCMCGN, [Out] float LBKCGLMDEHL);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 FJFGNKIHGJA(DDOHALFLGNO EJCDAPFAAIN);

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(Slot = "18")]
	quaternion DEKHOMBJMIP(DDOHALFLGNO EJCDAPFAAIN);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public static class AJNOJBBBIHA
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface CMFELPFGCMH
{
	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	object PIMCFEJPABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MFFLOCLFHDP(DLIACAMIKND OBBIGKIBBBG);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface HHKCACGEMAG
{
	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEOJJBBJJCC(NLPICMPDONC INCBEIDOHDO, DOGDACMPKBI CKKNJFDGPPK);

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LLLFFKGJBME(DOGDACMPKBI CKKNJFDGPPK);

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool APKEDDKPDPD(NLPICMPDONC BCECCNCMCGN, [Out] DOGDACMPKBI GIGHELCMIBM);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct KMCLFCKEGFN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly string IKMKCMDHFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly T DFEJJOPGBKP;

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x466CFE0", Offset = "0x466B7E0", VA = "0x18466CFE0")]
	public KMCLFCKEGFN(T DFEJJOPGBKP, [Optional][CallerMemberName] string IKMKCMDHFDC)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public static readonly KMCLFCKEGFN<int> GJKGNCIKCDL;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly KMCLFCKEGFN<int> FDGALAGMKIK;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public static readonly KMCLFCKEGFN<int> AMGEBKABFIF;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum BLEHBHFHALK
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class EGFOHJMPODO
{
	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x1140730", Offset = "0x113EF30", VA = "0x181140730")]
	public static bool ANHNNCGDNEG(this BLEHBHFHALK LCFHGACCKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x1140750", Offset = "0x113EF50", VA = "0x181140750")]
	public static bool MLFJHAMKKEL(this BLEHBHFHALK LCFHGACCKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x291C410", Offset = "0x291AC10", VA = "0x18291C410")]
	public static bool KINIFKBEFGB(this BLEHBHFHALK LCFHGACCKAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface NFILCDNAPOD
{
	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	bool MPKEMAPKLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[ServiceLifetime(Lifetime.Application)]
public interface DBAOMEMHJED
{
	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	BLEHBHFHALK CDHGPAGHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	BLEHBHFHALK IGANKIJEKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	BLEHBHFHALK JBDJJFGCLPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	BLEHBHFHALK GPGJNKBEMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	BLEHBHFHALK GEKCMDEFGFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	BLEHBHFHALK EIDONBEGHJC
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	BLEHBHFHALK GNPDBMNHEGD
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	BLEHBHFHALK BMKKNDEFOAA
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	BLEHBHFHALK EJEAOIOLJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	BLEHBHFHALK KCHJAJLKFFP
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	BLEHBHFHALK DNBFECHKDLL
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	BLEHBHFHALK CHPPMGFDHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	BLEHBHFHALK MLIAOJEMIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	BLEHBHFHALK MBPHAMKEHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	BLEHBHFHALK KDBDEFJNNLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	BLEHBHFHALK IHECODOMBGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	BLEHBHFHALK DHIAHPNNCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int EFGCOGNKKLM(KMCLFCKEGFN<int> MEGJMJCJPOE);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HFLAEHHBNFF
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event JBGOPIDCEEM.CGHIGDNGOHD OKBEMBPMJPK;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NLPICMPDONC HIMCAINOHCI(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EFPJEKNIAKJ(List<NLPICMPDONC> GMDHIEFOGKJ);

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IPENIDGIMGH HKNLOLLDCPI(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LHBBPAPIDLC(IEnumerable<NLPICMPDONC> CDCKICJIAOC);

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IPENIDGIMGH AIJCOPDKLKE(NLPICMPDONC NCCLECGLDAO, NLPICMPDONC HJDPFHBMCGB, bool GPONHEBHFKA, NLPICMPDONC BIINCLMPDMO);

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NLPICMPDONC PDAFPNMDFJN(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DDCCBIGAKMA(NLPICMPDONC BCECCNCMCGN, NLPICMPDONC NCCLECGLDAO, bool OGNCDPLKMPH = false);

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool KLLIHHMFFFG(NLPICMPDONC BCECCNCMCGN, NLPICMPDONC NCCLECGLDAO);

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KBKMNOKHDKI(NLPICMPDONC EOHBBAPOAJC, NLPICMPDONC OCIJIPLCHLB);

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int PFAKOKENDLG(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DLIACAMIKND NILMPIKNMKP(NLPICMPDONC JDJHDGCHHFG);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<NLPICMPDONC> NGODKMEJJGF(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool ANAOLAOLGCO(NLPICMPDONC BCECCNCMCGN, NLPICMPDONC CKFPNHMDEJM);

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IEnumerable<NLPICMPDONC> GONCGOCHNJE(NLPICMPDONC BCECCNCMCGN, bool KKPELIFONII = false);

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool PIHFFAMBCEP(NLPICMPDONC BCECCNCMCGN, NLPICMPDONC IKEBJEMGHHO);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "17")]
	NLPICMPDONC FLKMIBPIDIL(NLPICMPDONC BIINCLMPDMO, NLPICMPDONC OPINNMDODMB);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool EPBFFALDKHI(NLPICMPDONC BIINCLMPDMO, NLPICMPDONC OPINNMDODMB, [Out] NLPICMPDONC KPBDJNDPIOI);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "19")]
	NLPICMPDONC IGBGKAILHNI(NLPICMPDONC[] OBBIGKIBBBG);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class GOMGDFPMANO
{
	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x70AE4E0", Offset = "0x70ACCE0", VA = "0x1870AE4E0")]
	public static List<NLPICMPDONC> EFPJEKNIAKJ(this HFLAEHHBNFF NBHCIJIPGIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x70AE5E0", Offset = "0x70ACDE0", VA = "0x1870AE5E0")]
	public static bool LGOLHEAHKIB(this HFLAEHHBNFF NBHCIJIPGIM, NLPICMPDONC BCECCNCMCGN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface CDOHJBENMOK
{
	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CBDFFPLOJIF OGINPEBOGFG(NLPICMPDONC KKPONDJIGMO);

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LBMFNECMNBL(NLPICMPDONC KKPONDJIGMO, CBDFFPLOJIF KCIGHONLLPK);

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EMOFANCGOHF(NLPICMPDONC KKPONDJIGMO);

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CBLICLHHLKG(NLPICMPDONC KKPONDJIGMO, bool INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string[] OKIACJNCABC(NLPICMPDONC KKPONDJIGMO);

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HOGGLJHGIMB(NLPICMPDONC KKPONDJIGMO, IEnumerable<string> LJIMCKDEHJA);

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string[] FJFHDBJONIO(NLPICMPDONC KKPONDJIGMO);

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IOFGGIODBPA(NLPICMPDONC KKPONDJIGMO, IEnumerable<string> LJIMCKDEHJA);

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "8")]
	string[] FBBPJKHLGCD(NLPICMPDONC KKPONDJIGMO);

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JAOCNKPAPBI(NLPICMPDONC KKPONDJIGMO, IEnumerable<string> LJIMCKDEHJA);

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string[] JMEAGNIAIII(NLPICMPDONC KKPONDJIGMO);

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HGIJOJPLFBA(NLPICMPDONC KKPONDJIGMO, IEnumerable<string> LJIMCKDEHJA);

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool HDDBPJNOOGM(NLPICMPDONC KKPONDJIGMO, NLPICMPDONC FGIHDJGGIMF);
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface CONJMKEBONK
{
	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	bool PIBBFOGJEGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	bool NFDJFKBJAKI
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	bool DBCEODMMIKC
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DMEBDNNKCFG
{
	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HNPONEOLKIK([In] float3 EJDLMDEMKCD, [In] float3 NGBCGJCGHJG, float HFFBJNAMAGI, [Out] BCHAAOMJKLI IFDLDONOIOL, [Out] NLPICMPDONC GBFAPJDBEMN);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NPNLGPCCCHO
{
	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HNPONEOLKIK([In] NativeArray<Entity> NFLDGMHEJEF, [In] float3 EJDLMDEMKCD, [In] float3 NGBCGJCGHJG, [In] NativeArray<BCHAAOMJKLI> OKPMLLAAFNC);
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct ICOBOBPOIMJ : KCFKJNPGMEA, IEquatable<ICOBOBPOIMJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public int MBLPHBBBBKP
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x9E3640", Offset = "0x9E1E40", VA = "0x1809E3640", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0xD1C690", Offset = "0xD1AE90", VA = "0x180D1C690", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public int KCBFDBADCEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x293C5C0", Offset = "0x293ADC0", VA = "0x18293C5C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x6292880", Offset = "0x6291080", VA = "0x186292880", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x70B0AE0", Offset = "0x70AF2E0", VA = "0x1870B0AE0", Slot = "8")]
	public bool Equals(ICOBOBPOIMJ LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x70B0B30", Offset = "0x70AF330", VA = "0x1870B0B30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct BCHAAOMJKLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public float FLFOMIFMFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float3 LHHMNOGMEMF;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AHJINAEJKFA
{
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PJJOGJFNMIM
{
	[Cpp2IlInjected.Token(Token = "0x17000192")]
	JIKKDKGBDLB POADOIIONBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	GOJGONNCHIC AIBGFHBLONB
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<DLIACAMIKND, NativeArray<BKBMPOCGEPN>> MOJHIHLBBAD;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<DLIACAMIKND> LOKECEFHOMJ;

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HODFNNMKOAA CBOMMGNOKAE(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BKBMPOCGEPN OJNGICKHPMI(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CCEDGNHHKOL(HDJIEEPKAHE JINIJLGMOEA, HDAAKMEENMN CELALIAMGNM);

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DIPDKLCLGKO(HDJIEEPKAHE[] FCJKDFCDMDN, GameObject PBJIFBOBIOP);

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	COHFKJEBDIE CDLHJNOLJNG(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KENGPIEPNHB(NLPICMPDONC BCECCNCMCGN, [Out] Transform NBEDBEKEEBM);

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MINFAMBMNMC(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LMIEPILOKJP(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NLPICMPDONC AJLLGDKGLMM(HDJIEEPKAHE JINIJLGMOEA);

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool OIKEFPDDKEN(HDJIEEPKAHE JINIJLGMOEA, [Out] NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "16")]
	HDJIEEPKAHE PKKNBIIFEGI(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "17")]
	DLIACAMIKND AJLLGDKGLMM(NativeArray<HDJIEEPKAHE> JINIJLGMOEA, Allocator MOBIJPCBMOB);

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(Slot = "18")]
	DLIACAMIKND PNLPPFFOJKG(BKBMPOCGEPN AAFKJACPDJA, int NELOIEKKMHO, Allocator MOBIJPCBMOB);

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "19")]
	DLIACAMIKND IOPEJFKNLCF(NativeArray<HDJIEEPKAHE> JINIJLGMOEA, NativeArray<LCBMKGNCMPC> JEMDMDIKNBJ, Allocator MOBIJPCBMOB);

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "20")]
	HDJIEEPKAHE[] GGANEJCKNMD(string GGLFPAKLDNL, COHFKJEBDIE ECLOICLFHIE, bool CKOJOHKNHLB);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BJMOOHDLGGN(string GGLFPAKLDNL, HDJIEEPKAHE[] FCJKDFCDMDN);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "22")]
	COHFKJEBDIE CODFAIKNJPP(BKBMPOCGEPN AAFKJACPDJA, bool JJKEACGMJDE);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	COHFKJEBDIE CODFAIKNJPP(BKBMPOCGEPN AAFKJACPDJA);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	COHFKJEBDIE BFFJNHDHINH(BKBMPOCGEPN AAFKJACPDJA);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	COHFKJEBDIE GCIHCGOIGAB(BKBMPOCGEPN AAFKJACPDJA);

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(Slot = "26")]
	COHFKJEBDIE LGAMANDJIHC(HDJIEEPKAHE JINIJLGMOEA, BKBMPOCGEPN AAFKJACPDJA);

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "27")]
	FOHOGCAIENK JGFGGIBAOPE();

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "28")]
	ENCIOJMOOGP PFEEGAPJIAJ();

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "29")]
	JIFJKOAHNFO DFBKIMNEGAH(KCDIPBECKHL CHNLJMHJGIL);

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void CCFHGMIKMLB(DLIACAMIKND OBBIGKIBBBG);

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void ANFLKJPBFFP(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void HLOFAJKOIEG(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void CCFHGMIKMLB(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void EIJCKCNACMB(NLPICMPDONC OBBIGKIBBBG);

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool FNKCOIODFLL(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "36")]
	DLIACAMIKND EHIKDLKIDIA(DLIACAMIKND IPPDKNCKKEG, Allocator MOBIJPCBMOB);

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool GDDFGENFMPA(NLPICMPDONC BCECCNCMCGN);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class LDJCFCJIMIE
{
	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x70B2850", Offset = "0x70B1050", VA = "0x1870B2850")]
	public static void LMIEPILOKJP(this PJJOGJFNMIM HIOGCNEKLDG, HDAAKMEENMN CELALIAMGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x70B2360", Offset = "0x70B0B60", VA = "0x1870B2360")]
	public static COHFKJEBDIE LGEMEBLDBMM(this PJJOGJFNMIM HIOGCNEKLDG, LocalId BCECCNCMCGN)
	{
		return default(COHFKJEBDIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x70B27F0", Offset = "0x70B0FF0", VA = "0x1870B27F0")]
	public static COHFKJEBDIE LGEMEBLDBMM(this PJJOGJFNMIM HIOGCNEKLDG, HDJIEEPKAHE JINIJLGMOEA)
	{
		return default(COHFKJEBDIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x70B2360", Offset = "0x70B0B60", VA = "0x1870B2360")]
	public static NLPICMPDONC AJLLGDKGLMM(this PJJOGJFNMIM HIOGCNEKLDG, LocalId BCECCNCMCGN)
	{
		return default(NLPICMPDONC);
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x70B29C0", Offset = "0x70B11C0", VA = "0x1870B29C0")]
	public static HDJIEEPKAHE PKKNBIIFEGI(this PJJOGJFNMIM HIOGCNEKLDG, LocalId BCECCNCMCGN)
	{
		return default(HDJIEEPKAHE);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x70B2680", Offset = "0x70B0E80", VA = "0x1870B2680")]
	public static bool GDDFGENFMPA(this PJJOGJFNMIM HIOGCNEKLDG, HDJIEEPKAHE JINIJLGMOEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x70B2590", Offset = "0x70B0D90", VA = "0x1870B2590")]
	public static FOHOGCAIENK FCNBFEBIALP(this PJJOGJFNMIM HIOGCNEKLDG, RigidTransform PJDIPJCPCAD)
	{
		return default(FOHOGCAIENK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x70B26F0", Offset = "0x70B0EF0", VA = "0x1870B26F0")]
	public static JIFJKOAHNFO KOEANEMGJIE(this PJJOGJFNMIM HIOGCNEKLDG, KCDIPBECKHL FFPEKFKIDDJ, RigidTransform PJDIPJCPCAD)
	{
		return default(JIFJKOAHNFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x70B28D0", Offset = "0x70B10D0", VA = "0x1870B28D0")]
	public static ENCIOJMOOGP MLLAIOHDNII(this PJJOGJFNMIM HIOGCNEKLDG, RigidTransform PJDIPJCPCAD)
	{
		return default(ENCIOJMOOGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x70B2390", Offset = "0x70B0B90", VA = "0x1870B2390")]
	private static void DJKGPNDANNP(COHFKJEBDIE BNOFKKFEBAM, RigidTransform PJDIPJCPCAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface LIGDBFMOLCN
{
	[Cpp2IlInjected.Token(Token = "0x17000194")]
	bool KJKFENHCOIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	NLPICMPDONC OGAJFONOAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	COHFKJEBDIE NECKLBBFOAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event PMPBMGGIPLM CHJNOEMNICI;

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NLPICMPDONC FLKMIBPIDIL(NLPICMPDONC BIINCLMPDMO, NLPICMPDONC OPINNMDODMB);

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EPBFFALDKHI(NLPICMPDONC BIINCLMPDMO, NLPICMPDONC OPINNMDODMB, [Out] NLPICMPDONC KPBDJNDPIOI);

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GHIKKDKBLBA();

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BCACMMCKBME();

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NGKMLFEAFHE(NLPICMPDONC BIINCLMPDMO);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool FEHLPPFKJBM(NLPICMPDONC BIINCLMPDMO);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public delegate void PMPBMGGIPLM(COHFKJEBDIE EDOFAENPOKB, COHFKJEBDIE DLBGMBBCJOI);
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class INCEEAIALEN
{
	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x70B0F40", Offset = "0x70AF740", VA = "0x1870B0F40")]
	public static bool NLFJAEHGCJB(this LIGDBFMOLCN DBMPGNLONNC, COHFKJEBDIE BIINCLMPDMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x70B0F90", Offset = "0x70AF790", VA = "0x1870B0F90")]
	public static bool NOOKDJPILLG(this LIGDBFMOLCN DBMPGNLONNC, NLPICMPDONC BIINCLMPDMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x70B0EC0", Offset = "0x70AF6C0", VA = "0x1870B0EC0")]
	public static bool FHCJEOCJECN(this LIGDBFMOLCN DBMPGNLONNC, NLPICMPDONC BIINCLMPDMO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface COFCEECBFGH
{
	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HIPDBPDOKCC(COHFKJEBDIE BNOFKKFEBAM, JBOELMKONKK NNGPPKEHFMP, List<COHFKJEBDIE> OPNJOKBMFIN);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int HNIBJGDCKOF(COHFKJEBDIE BNOFKKFEBAM, JBOELMKONKK NNGPPKEHFMP);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NMNKHFFPAII(COHFKJEBDIE BNOFKKFEBAM, List<COHFKJEBDIE> OPNJOKBMFIN);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NBGOGJONJGM(COHFKJEBDIE AFJCLAOHICF, COHFKJEBDIE BIINCLMPDMO, JBOELMKONKK NNGPPKEHFMP);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	COHFKJEBDIE BJLPKDNGKJK(COHFKJEBDIE AFJCLAOHICF, int ECDOOAABOPD, JBOELMKONKK NNGPPKEHFMP);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GDADJBEGGPE(COHFKJEBDIE AFJCLAOHICF, COHFKJEBDIE BIINCLMPDMO, JBOELMKONKK NNGPPKEHFMP);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FIMEJLOEIKM(COHFKJEBDIE AFJCLAOHICF, COHFKJEBDIE BIINCLMPDMO, JBOELMKONKK NNGPPKEHFMP);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AACKFDCEDMG(COHFKJEBDIE AFJCLAOHICF, JBOELMKONKK NNGPPKEHFMP);

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EGFJIKHHGMO(COHFKJEBDIE AFJCLAOHICF, COHFKJEBDIE BIINCLMPDMO, JBOELMKONKK NNGPPKEHFMP);

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ILIFPGNMLJM(Entity AFJCLAOHICF, Entity BIINCLMPDMO, JBOELMKONKK NNGPPKEHFMP);

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FNAMPOCCCDN(Entity AFJCLAOHICF, JBOELMKONKK NNGPPKEHFMP);

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CCKLBJOMKEP(COHFKJEBDIE BIINCLMPDMO, JBOELMKONKK NNGPPKEHFMP);
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NKPLDHPHLMG
{
	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGAMIHLGIOB(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LFAGGFMGGOH(NLPICMPDONC BCECCNCMCGN, Transform NBEDBEKEEBM);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FOKHHODNCAE
{
	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IJJMGGCICIB(NLPICMPDONC BIINCLMPDMO, NLPICMPDONC EFCDBBNPLBH);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AKCDMMBNPAK(NLPICMPDONC BIINCLMPDMO, NLPICMPDONC CCBPINNNGCM);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OEKIPKBDGFA(NLPICMPDONC BIINCLMPDMO, [Out] NLPICMPDONC BCPOILLLJPM);
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface NOHGGPDMLKA
{
	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LACGCLCHDEC(NLPICMPDONC JDJHDGCHHFG, bool INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LHOGBIGLDFN(NLPICMPDONC JDJHDGCHHFG, bool INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JONANPIEHHN(NLPICMPDONC JDJHDGCHHFG, int INDENPJBLHO);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface KNMBABCNKJO
{
	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<NLPICMPDONC> PMOCJBKLGBJ(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NLPICMPDONC INLABPHLHEI(NLPICMPDONC BCECCNCMCGN, int ECDOOAABOPD);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int NFFECGLMBEL(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GMIJGAFIAIM JOFLIMJFGKC(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JJJJPEOEHAD(NLPICMPDONC BCECCNCMCGN, GMIJGAFIAIM OFGFBCNFINC);

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NLPICMPDONC GLPHAGJIHHB(NLPICMPDONC BCECCNCMCGN, [Optional] float3? BALIIBCILHH, [Optional] quaternion? OJEGGOKKPLF, [Optional] float3? FKICLIIJEHG);

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NLPICMPDONC IOPOJLDDCOJ(NLPICMPDONC BCECCNCMCGN, int ECDOOAABOPD, [Optional] float3? BALIIBCILHH, [Optional] quaternion? OJEGGOKKPLF, [Optional] float3? FKICLIIJEHG);

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CGGBKPDAGAL(NLPICMPDONC BCECCNCMCGN, int ECDOOAABOPD);

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EPCEPLDIJFC(NLPICMPDONC BCECCNCMCGN);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CGEBLKEKCOJ
{
	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ICLIBALDMHO();

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPLEKABEOFN();

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GBGGLBFDHNO();

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ICIENCCGEON();

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KHCCOHLGOIL();

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KOBMAIHOLIO();

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MNNMHGEKDME();

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EMBADDLCANG();

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KHNHLCMKLDO();

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MLBBPMMDOCB();

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JEMIGFDCIKJ();

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FGELHMLGILM();

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AJHKDEJOOBN();
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface EEPDPHLFPIE
{
	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NMDHKAOHMNP(NLPICMPDONC BIINCLMPDMO, [Out] int AFJCLAOHICF);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFPGCLBGMAP(NLPICMPDONC BIINCLMPDMO, int AFJCLAOHICF);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKDIFGKCEGI(NLPICMPDONC BIINCLMPDMO, bool DPMNHMKBOMO);

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void APHLHPOLCOE(NLPICMPDONC BIINCLMPDMO, float FPDMMLDGKNC, float NDHKLMFMFJG, float LFMHKBMDBII);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AAFEMKDMMOE(NLPICMPDONC BCECCNCMCGN, [Out] float NDHKLMFMFJG, [Out] float LFMHKBMDBII);

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LLFMELPOMPP(NLPICMPDONC BIINCLMPDMO, float3 BALIIBCILHH, quaternion OJEGGOKKPLF);

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PBDCIDOGGME(NLPICMPDONC BIINCLMPDMO, [Out] float3 BALIIBCILHH, [Out] quaternion OJEGGOKKPLF);

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LMBMKBEHPCC(NLPICMPDONC BIINCLMPDMO);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IMJOBFPMAKJ
{
	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CJLNBFCLPBI(Entity DPHKAEKJOIN);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGHPADAMLCO(Entity DPHKAEKJOIN, [In] float3 INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 OMCIEHFEIPM(Entity DPHKAEKJOIN);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NPCCLNBCLIP(Entity DPHKAEKJOIN, [In] quaternion INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion AAPPGEFBJJE(Entity DPHKAEKJOIN);

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CLLDKNLIIBK(Entity DPHKAEKJOIN, [In] float3 BALIIBCILHH, [In] quaternion OJEGGOKKPLF);

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CMJMCOMGLOJ(Entity DPHKAEKJOIN, [Out] float3 BALIIBCILHH, [Out] quaternion OJEGGOKKPLF);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CMJMCOMGLOJ(Entity DPHKAEKJOIN, [Out] RigidTransform CLOPIJFLBBF);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PHKKBPGNOMC(Entity DPHKAEKJOIN, [In] float3 BALIIBCILHH, [In] quaternion OJEGGOKKPLF);

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MEKKMCKCGKM(Entity DPHKAEKJOIN, [Out] float3 BALIIBCILHH, [Out] quaternion OJEGGOKKPLF);

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MEKKMCKCGKM(Entity DPHKAEKJOIN, [Out] RigidTransform CLOPIJFLBBF);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float3 LHNDJIBHFFL(Entity DPHKAEKJOIN);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BCBGMFDEIMC(Entity DPHKAEKJOIN, [In] float3 INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NAHMHLOFMNL(Entity DPHKAEKJOIN, float INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	float KENBMPOHAKG(Entity DPHKAEKJOIN);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CEGLLPGINGO(Entity DPHKAEKJOIN, [In] float3 INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 BDDJPCOAALP(Entity DPHKAEKJOIN);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AOMFLNGEDCA(Entity DPHKAEKJOIN, [In] float3 INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 FPHOOJEDAKB(Entity DPHKAEKJOIN);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void COJAJHMHLNP(Entity DPHKAEKJOIN, [In] quaternion INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "20")]
	quaternion KLBLNALAAEF(Entity DPHKAEKJOIN);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float3 MFMKPIMCBJM(Entity DPHKAEKJOIN);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void HIHLMENFJOK(Entity DPHKAEKJOIN, [In] float3 INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void DEMLKECODDJ(Entity DPHKAEKJOIN, float INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "24")]
	float PJHGIFJIOHM(Entity DPHKAEKJOIN);

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void CFPGLAAAJLN(Entity DPHKAEKJOIN, [In] float3 INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "26")]
	float3 MOJCGPEBIKK(Entity DPHKAEKJOIN);

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void IECHFKIKPHM(Entity DPHKAEKJOIN, [Out] float4x4 KBJBMNDHNHM);

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void GGADGLAJNIN(Entity DPHKAEKJOIN, [In] float4x4 KBJBMNDHNHM);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void BGLNDGLFDBP(Entity DPHKAEKJOIN, [Out] float4x4 KBJBMNDHNHM);

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool KENGPIEPNHB(Entity DPHKAEKJOIN, [Out] Transform NBEDBEKEEBM);

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void JBBHEADACIF(Entity DPHKAEKJOIN);

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void MAHGBEHGALK(Entity DPHKAEKJOIN, Entity GJKNLJJHFGH, Entity FABMJJHDKOA);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class GFPLDLLEBIK
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DFCMGIKOHMB
{
	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKMDCFPHAHB(bool EMGABJHBLDH);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface FLMLIDNECPL
{
	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNJEKPDMPJD(NLPICMPDONC KKPONDJIGMO, IEnumerable<string> LJIMCKDEHJA);

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APDGADIPKAN(NLPICMPDONC KKPONDJIGMO, IEnumerable<string> LJIMCKDEHJA);

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IGOIPHEGEIF(NLPICMPDONC KKPONDJIGMO, params string[] LJIMCKDEHJA);

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MIJFFMBGLPG(NLPICMPDONC KKPONDJIGMO, params string[] LJIMCKDEHJA);

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BACOJIKPLIA(NLPICMPDONC KKPONDJIGMO, params string[] LJIMCKDEHJA);

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EHLMHGKCNJI(NLPICMPDONC KKPONDJIGMO, params string[] LJIMCKDEHJA);

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int CPMNOFPNLCM(NLPICMPDONC KKPONDJIGMO);

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int NKKALKHDJPG(NLPICMPDONC KKPONDJIGMO);

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int LIBINADNOJP(NLPICMPDONC KKPONDJIGMO);

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BJAHDPGCCMF(NLPICMPDONC KKPONDJIGMO, ICollection<string> CKBILOFPLBJ);

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FIBLNKKCILJ(NLPICMPDONC KKPONDJIGMO);

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DOIMKNFFGEM(NLPICMPDONC KKPONDJIGMO, ICollection<string> CKBILOFPLBJ);

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool FODLEAFLCGP(NLPICMPDONC KKPONDJIGMO, string LJMDFKCKKHM);

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NJMJCAKHBMN(string LJMDFKCKKHM, HCJHPMIHCEN OKCAIKLLOJJ);

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NLPICMPDONC JEJBCMPNFJM(string LJMDFKCKKHM);

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JMKNLEACNLA(string LJMDFKCKKHM, HCJHPMIHCEN OKCAIKLLOJJ);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BGGLKKHLLCG(NLPICMPDONC EDGIIEBELJD, string LJMDFKCKKHM, HCJHPMIHCEN OKCAIKLLOJJ);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool AENOIBIMPFF();

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void IAOFPKDCBHI(IEnumerable<string> LJIMCKDEHJA);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JIGOJDKLMLM
{
	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World ENPPGJOEHHI(string BOOHGGIFBBL = "Main");

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World MGPNMHFEFHL(string BOOHGGIFBBL = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World NKNNGFHDOPK(string BOOHGGIFBBL = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World GOPOGLGLDLG(string BOOHGGIFBBL = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GIAJMCLBEFD
{
	[Cpp2IlInjected.Token(Token = "0x17000197")]
	World OCLIBNGLBOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	World LMGHDIOGCKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	EntityManager LMPOOGFFNHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	bool KNPGJHABEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase MPMLABEMFNI(Type OCLAPBNMMGE);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class DACJBIKKHGM
{
	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x70A5480", Offset = "0x70A3C80", VA = "0x1870A5480")]
	public static ComponentSystemBase MHBIEPEFHKK(this World LHFELFOPEAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x2E96810", Offset = "0x2E95010", VA = "0x182E96810")]
	public static T MPMLABEMFNI<T>(this GIAJMCLBEFD HACOHOJHCHN) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface ABOPBMBNPNL
{
	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDAMKKCEHFF(NativeListAsync<Entity> ODMELMKFNPF);

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCJBLJNDBMM(KMCDGIIKEAC ELIGCFFOCBI);

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DLNJANPBPDF(NativeListAsync<Entity> OHLMDDNHMCF, bool KHCLPHIANIF);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BBFJNGKHNON();

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KBNNMFOBOHJ(Entity KAMAKIBPPKG);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface EJINNBHBDHI
{
	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BDGBJMJNGBI(Collider JFOLGMCMDLO, [Out] ACHFDAAAJAJ HPFDHHFEIKP);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface OAOPDONAOPN
{
	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider IPLONDLOJIA(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject INLIHEIMACL(NLPICMPDONC ALOKLMFICMB, GameObject CBJCLOIGING, Vector3 BIIIOAKOBBK, Quaternion HAODNGMNEJG);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MCDIBCHDBHD(GameObject JFOLGMCMDLO);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider OFGBJJLLOGM<TCollider>(GameObject LFIPNHIIMPI) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KBEGAJEAPIP(Collider JFOLGMCMDLO);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject GGKEKJKPLFJ<TCollider>(string IKMKCMDHFDC) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KIPCMJEHAFM FBHBECBOKPB(NLPICMPDONC HPGIMINGKOC, NLPICMPDONC HPHDJDEOAJO, KCDIPBECKHL MFIKALIOBLE, float3 ONBAAPECKPL, quaternion LEPMOOPGIJK, float3 NKMMNLFLKPG);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool JNGJACKIEHG(NLPICMPDONC BCECCNCMCGN, [Out] KIPCMJEHAFM JFOLGMCMDLO);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JOCCKAOBKEL(NLPICMPDONC BCECCNCMCGN, [Out] NLPICMPDONC KAMAKIBPPKG);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public enum JNJBKFILDEP
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface EFHAFOHFCIE
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public struct JCLHOMECNDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int MFIKALIOBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public GameObject CBJCLOIGING;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FIMGLPBDCOC(NLPICMPDONC BCECCNCMCGN, ELBAPEAMABC NDAMHGCIDEM, bool PEDLDOJMHOI, IBNNJJAFPLG GBFGEPEHHDP);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOJEIMBOAAC(NLPICMPDONC BCECCNCMCGN, ELBAPEAMABC NDAMHGCIDEM, bool PEDLDOJMHOI, bool GPPHABPCNPM, bool HDMMHAANCEL);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BAJINNPGNMG FBBFKEBDANH(NLPICMPDONC KAMAKIBPPKG, List<NLPICMPDONC> DGLEEJKPONK);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KIPCMJEHAFM KFGODAIHEOA(GameObject FOMIKGMHMCP, GameObject NCKNDBMJHCB);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AOCCLHMEEBF(GameObject FOMIKGMHMCP, List<GameObject> ACNPEJKKNFH);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KFKNOMNJNKK(GameObject NCKNDBMJHCB);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T OFGBJJLLOGM<T>(GameObject LFIPNHIIMPI) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KBEGAJEAPIP(Collider JFOLGMCMDLO);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject KOKPCMBMLGO<T>(string IKMKCMDHFDC) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool DCAAELFIINJ(Collider JFOLGMCMDLO, [Out] NLPICMPDONC AFJCLAOHICF);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool CDCBKLJPCFJ(NLPICMPDONC BCECCNCMCGN, [Out] ACHFDAAAJAJ HPFDHHFEIKP);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<JNJBKFILDEP> CMIBDHOLHLL(Allocator MOBIJPCBMOB = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] FBEJNFOINFM();

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int BDENNCCLLNJ(ELBAPEAMABC NDAMHGCIDEM);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "14")]
	string KANGOECOBHM(ELBAPEAMABC NDAMHGCIDEM);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OCNNJJGHEBG
{
	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKLHNGDLCJI(NLPICMPDONC BCECCNCMCGN, NLPICMPDONC INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNBAPNNPFJG(NLPICMPDONC BCECCNCMCGN, NLPICMPDONC INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int PFAKOKENDLG(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NLPICMPDONC JFFBKLJCMHI(NLPICMPDONC BCECCNCMCGN, int ECDOOAABOPD);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DLIACAMIKND MOILOHDOPPD(NLPICMPDONC BCECCNCMCGN, Allocator MOBIJPCBMOB = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DPNEADJLDIC(NLPICMPDONC BCECCNCMCGN, object DJIMHLGHFGI, NLPICMPDONC INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MMPLHDPCHFL(NLPICMPDONC BCECCNCMCGN, object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool CMAAFHECFDD(NLPICMPDONC BCECCNCMCGN, [Out] NLPICMPDONC INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NBHJFDCACJM(NLPICMPDONC BCECCNCMCGN, float3 INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool FMCPNFOEFCC(NLPICMPDONC BCECCNCMCGN, [Out] float3 INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CMEFKHILMFF(NLPICMPDONC BCECCNCMCGN, float3 INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CDJOMPBMILO(NLPICMPDONC BCECCNCMCGN, [Out] float3 INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EACANLNPKHM(NLPICMPDONC BCECCNCMCGN, (Quaternion rot, Vector3 moments) GONNOPNNDDD);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool OCBGNFNKONJ(NLPICMPDONC BCECCNCMCGN, [Out] quaternion FCCAJAMDPOO, [Out] float3 NPNJAOKPDPP);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ACCDJAACADG(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 IIJMCDPMOOF(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 OPEBKBAMILG(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void GNBHJKBOLGA(NLPICMPDONC BCECCNCMCGN, float3 INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EKLCLNMKCND(NLPICMPDONC BCECCNCMCGN, float3 INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float CBLOKMNPLAK(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float NAEHOMGPPGI(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void PIEMCJBMNHF(NLPICMPDONC BCECCNCMCGN, float INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void CBOOPLNIGCJ(NLPICMPDONC BCECCNCMCGN, float INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode HODLDFENFNJ(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GPCHLFJCHKP(NLPICMPDONC BCECCNCMCGN, CollisionDetectionMode INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "25")]
	FMLELDCHGMI JKMDKNDGAAH(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void BADNAAGEOMO(NLPICMPDONC BCECCNCMCGN, FMLELDCHGMI INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool HGLJLBPEEID(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void EDLAGBBGMLF(NLPICMPDONC BCECCNCMCGN, bool INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "29")]
	NLPICMPDONC HIMCAINOHCI(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void OLOBBONFAKC(NLPICMPDONC BCECCNCMCGN, NLPICMPDONC INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "31")]
	NLPICMPDONC PDAFPNMDFJN(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void DDCCBIGAKMA(NLPICMPDONC BCECCNCMCGN, NLPICMPDONC INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "33")]
	NEDCKNNIBBL CIGLLMCKKBN(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void IDFMPNLJNJD(NLPICMPDONC BCECCNCMCGN, NEDCKNNIBBL FHHJIDAFGDE);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool NCIJGAPNJBA(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void GCKAAHBNJKN(NLPICMPDONC BCECCNCMCGN, bool INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool HIIDMFALFMM(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void DIGFNCDICKG(NLPICMPDONC BCECCNCMCGN, bool INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints IBKNHPIKLLI(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void LBLHMJNOANI(NLPICMPDONC BCECCNCMCGN, RigidbodyConstraints INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float FLNIHAPOJOI(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void DJFNJENADFO(NLPICMPDONC BCECCNCMCGN, float INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float JMLMMLAGCIF(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void PINCMCHOFEA(NLPICMPDONC BCECCNCMCGN, float INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool NPJMHHCJJGI(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void FDJDNCKHHMH(NLPICMPDONC BCECCNCMCGN, bool INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool FKLJIALIILF(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void PNLEFPNFLLK(NLPICMPDONC BCECCNCMCGN, bool INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void CDAGADGGBIG(NLPICMPDONC BCECCNCMCGN, int INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "50")]
	JBNIKIOLDLF KBJCHGEDGIP(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void HJODCFACGLF(NLPICMPDONC BCECCNCMCGN, JBNIKIOLDLF INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "52")]
	MBMIBMKAFBA FMMOCGPDAAE(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void LFABPGEPPMP(NLPICMPDONC BCECCNCMCGN, MBMIBMKAFBA INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float GBHODOFEPLJ(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void HKEFCFJBFBH(NLPICMPDONC BCECCNCMCGN, float INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void DMPEKCHNJLP(NLPICMPDONC BCECCNCMCGN, object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void JDPPKOLDDJA(NLPICMPDONC BCECCNCMCGN, object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool CGAIGLMMGOA(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void HKCPENDJEOH(NLPICMPDONC BCECCNCMCGN, object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void EBKBHPCKFBO(NLPICMPDONC BCECCNCMCGN, object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool IFNFNFELCHN(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool JCGLCGLEPEM(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody PCJPPLHBHKA(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void BAILPIOFKHH(NLPICMPDONC BCECCNCMCGN, Rigidbody PFJJBBEKFJA);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void ACNPMEFFPLJ(NLPICMPDONC BCECCNCMCGN, object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void NOMEBGPDCMB(NLPICMPDONC BCECCNCMCGN, object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool AINLBJDHPOP(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void IMNIHIJOLME(NLPICMPDONC BCECCNCMCGN, float3 KAHKKJLHEEJ);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void JNPEHOMFBGB(NLPICMPDONC BCECCNCMCGN, float3 NAILJECMJDD);

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool JIEGGGOLICA(NLPICMPDONC BCECCNCMCGN, [Out] float3 KAHKKJLHEEJ);

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool IKAIKLCEHEF(NLPICMPDONC BCECCNCMCGN, [Out] float3 NAILJECMJDD);

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool HBGLEDGEAAP(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void ONJPEKNCIIP(NLPICMPDONC BCECCNCMCGN, object DJIMHLGHFGI, bool NJPKHDOCLPC);

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void PBPNGBOCOIN(NLPICMPDONC BCECCNCMCGN, bool OKKBFBEHAMF);

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void FLHPMKDIKHO(NLPICMPDONC BCECCNCMCGN);

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool FHKKOPNGEAL(NLPICMPDONC BCECCNCMCGN);
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface HJDAPACIGHA
{
	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCCHIMCLDEB(Entity IJPBFCHDHGG);

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OBCPELDJONF(Entity IJPBFCHDHGG);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface CCILDPOFEOM
{
	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LOMKDMGBFEE(NLPICMPDONC BIINCLMPDMO, bool JOMBFMIHEII);

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMGNODCBIFN(NLPICMPDONC BIINCLMPDMO, int NEHJMKFJILC);
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public delegate void JCFAMFFIBNB(DFOMLPNOHEJ BBJFEOHJKIP);
[Cpp2IlInjected.Token(Token = "0x200009C")]
public readonly ref struct DFOMLPNOHEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly DLIACAMIKND GPEHJPJPEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly NativeArray<byte> EHAFKKPIECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly NativeArray<byte> JMFBCIGGDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly JDHJHMOFOLO MFCFAMOHGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly int COCMMELMOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly Type AAJLGHJONGM;

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public DLIACAMIKND DBCCHEFDKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x46D1CF0", Offset = "0x46D04F0", VA = "0x1846D1CF0")]
		get
		{
			return default(DLIACAMIKND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x70A60F0", Offset = "0x70A48F0", VA = "0x1870A60F0")]
	public DFOMLPNOHEJ(DLIACAMIKND GPEHJPJPEPJ, NativeArray<byte> EHAFKKPIECD, NativeArray<byte> JMFBCIGGDOB, JDHJHMOFOLO MFCFAMOHGBK, int COCMMELMOOM, Type AAJLGHJONGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x2EA32D0", Offset = "0x2EA1AD0", VA = "0x182EA32D0")]
	public NativeArray<T> EDLLFEPNLCK<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x2EA3400", Offset = "0x2EA1C00", VA = "0x182EA3400")]
	public NativeArray<T> HHFLLDHEAGB<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x2EA3310", Offset = "0x2EA1B10", VA = "0x182EA3310")]
	public (DLIACAMIKND, NativeArray<T>, NativeArray<T>) EFGCOGNKKLM<T>() where T : struct
	{
		return default((DLIACAMIKND, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x70A60C0", Offset = "0x70A48C0", VA = "0x1870A60C0")]
	public GLOBPNCNKOJ EOLICBHBBKJ()
	{
		return default(GLOBPNCNKOJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public interface GNKNGOOFCEM
{
	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	string EGBCBCBBBHI
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	GNKNGOOFCEM AAKNCHHHLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	IEnumerable<GNKNGOOFCEM> IOINBDPKPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface CNBAHPNGKPD
{
	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	GNKNGOOFCEM CGIMJBCJKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	NativeArray<JDHJHMOFOLO> PLBOINKABGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HCLCAICALIG(JDHJHMOFOLO MFCFAMOHGBK, [Out] GNKNGOOFCEM PMGFPJDBJBB);

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CCEDGNHHKOL(JDHJHMOFOLO MFCFAMOHGBK, JCFAMFFIBNB PGHGFBOCPGM);

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NKAGGCHHKCB(JDHJHMOFOLO MFCFAMOHGBK, JCFAMFFIBNB PGHGFBOCPGM);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface PHCKIPGLJNG
{
	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCEDGNHHKOL(JDHJHMOFOLO MFCFAMOHGBK, JCFAMFFIBNB PGHGFBOCPGM);

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NKAGGCHHKCB(JDHJHMOFOLO MFCFAMOHGBK, JCFAMFFIBNB PGHGFBOCPGM);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class OJAJFLPLKHH
{
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JFFDEFJMHAP
{
	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	OFGAFMMIFFO NNMEFCNKPMI
	{
		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ELIFOLHJJOE(HDJIEEPKAHE JINIJLGMOEA, JDHJHMOFOLO MFCFAMOHGBK);

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LHNJAJNHFDJ(HDJIEEPKAHE JINIJLGMOEA, Span<JDHJHMOFOLO> DABHNNJBAFE, bool IMEOBBFIADL);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IJLHFEICOEA(NativeArray<HDJIEEPKAHE> FCJKDFCDMDN);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class PEEMIAFLHBJ
{
	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x70B6680", Offset = "0x70B4E80", VA = "0x1870B6680")]
	public static void LHNJAJNHFDJ(this JFFDEFJMHAP DJCCAFCIALM, HDJIEEPKAHE JINIJLGMOEA, JDHJHMOFOLO MFCFAMOHGBK, bool IMEOBBFIADL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public readonly ref struct GLOBPNCNKOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly DFOMLPNOHEJ EBNFOODJNOB;

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public DLIACAMIKND DBCCHEFDKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x46D1CF0", Offset = "0x46D04F0", VA = "0x1846D1CF0")]
		get
		{
			return default(DLIACAMIKND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x70AD5A0", Offset = "0x70ABDA0", VA = "0x1870AD5A0")]
	public GLOBPNCNKOJ(DFOMLPNOHEJ EBNFOODJNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x70AD1E0", Offset = "0x70AB9E0", VA = "0x1870AD1E0")]
	public DLIACAMIKND EDLLFEPNLCK()
	{
		return default(DLIACAMIKND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x70AD4D0", Offset = "0x70ABCD0", VA = "0x1870AD4D0")]
	public DLIACAMIKND HHFLLDHEAGB()
	{
		return default(DLIACAMIKND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x70AD2B0", Offset = "0x70ABAB0", VA = "0x1870AD2B0")]
	public (DLIACAMIKND, DLIACAMIKND, DLIACAMIKND) EFGCOGNKKLM()
	{
		return default((DLIACAMIKND, DLIACAMIKND, DLIACAMIKND));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class ADOHPJLKJPI
{
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public readonly struct OFGAFMMIFFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly NativeBitArray KICNPFGNBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly NativeParallelHashMap<HDJIEEPKAHE, int> BLDDKIDEBEI;

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public bool LABKLDNMCOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x70B64C0", Offset = "0x70B4CC0", VA = "0x1870B64C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x46D1A40", Offset = "0x46D0240", VA = "0x1846D1A40")]
	public OFGAFMMIFFO(NativeBitArray KICNPFGNBCK, NativeParallelHashMap<HDJIEEPKAHE, int> BLDDKIDEBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x70B6390", Offset = "0x70B4B90", VA = "0x1870B6390")]
	public bool ELIFOLHJJOE(HDJIEEPKAHE JINIJLGMOEA, JDHJHMOFOLO MFCFAMOHGBK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface KIMALLHGCOF
{
	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JBPIEEJKCDE(NLPICMPDONC BCECCNCMCGN, NAGHPEHFOJO INDENPJBLHO);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HIAGFACLOGL
{
	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	LDFEEADCCGN KPOANAODNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GHBENOJCJFF
{
	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EGDHEPCNGIO(World LHFELFOPEAG);

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NBFAAJAPJNL(World LHFELFOPEAG);

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase PDCADGCJLEF(World LHFELFOPEAG);

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ABJBKHGPLAA(World LHFELFOPEAG);

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IHFAFPOFPAH(World LHFELFOPEAG);

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ICFOGHKJKIL(World LHFELFOPEAG);

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JPBHMAGFJMN(World LHFELFOPEAG);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> OFBKDHNKEOB();
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface INENKMLOBJI
{
	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBBDAOPPHAO(NLPICMPDONC JDJHDGCHHFG, bool INDENPJBLHO);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public readonly struct GBFGHLDIDKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly IEnumerable<CEKOGANACJF> OGGNALBGGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly IReadOnlyList<GameObject> KBCGEFIJPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly IReadOnlyList<int> OEAIDCHLAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly IReadOnlyList<(HDJIEEPKAHE, HDJIEEPKAHE)> LHENHGKOJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly int HPEBCPPCFFM;

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public bool LNCHMIOPEFL
	{
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x70ACCE0", Offset = "0x70AB4E0", VA = "0x1870ACCE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public int ILCJAOMNFGI
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x958980", Offset = "0x957180", VA = "0x180958980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public IEnumerable<GameObject> LFIIPOCOOHF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x9BC8B0", Offset = "0x9BB0B0", VA = "0x1809BC8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public IEnumerable<(HDJIEEPKAHE src, HDJIEEPKAHE dst)> CCAHNJMIJKK
	{
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x70ACD40", Offset = "0x70AB540", VA = "0x1870ACD40")]
	public GBFGHLDIDKD(IEnumerable<CEKOGANACJF> OGGNALBGGIL, IReadOnlyList<GameObject> KBCGEFIJPHP, IReadOnlyList<int> OEAIDCHLAAI, IReadOnlyList<(HDJIEEPKAHE src, HDJIEEPKAHE dst)> LHENHGKOJDH, int HPEBCPPCFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x70AC960", Offset = "0x70AB160", VA = "0x1870AC960")]
	public (GameObject, int)[] FLCKFBCCKGN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[ServiceLifetime(Lifetime.Application)]
public interface DEDDPGIPADH
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public class CLCNDNNMJMC
	{
		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public NLPICMPDONC MHMOKMJDLAF
		{
			[Cpp2IlInjected.Token(Token = "0x60005B2")]
			[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
			[CompilerGenerated]
			get
			{
				return default(NLPICMPDONC);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0x946360", Offset = "0x944B60", VA = "0x180946360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public UniformTRS LOIOEGFHIBI
		{
			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x3D4A010", Offset = "0x3D48810", VA = "0x183D4A010")]
			[CompilerGenerated]
			get
			{
				return default(UniformTRS);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x70A4940", Offset = "0x70A3140", VA = "0x1870A4940")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public bool EKMHOMKKDBO
		{
			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x9EA050", Offset = "0x9E8850", VA = "0x1809EA050")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x9E9C10", Offset = "0x9E8410", VA = "0x1809E9C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public BKOMOBLAELM BFBEMMDDCHC
		{
			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x8BD1D0", Offset = "0x8BB9D0", VA = "0x1808BD1D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x8BB250", Offset = "0x8B9A50", VA = "0x1808BB250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public bool ACKPOBFOFAB
		{
			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x997550", Offset = "0x995D50", VA = "0x180997550")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0x99EA30", Offset = "0x99D230", VA = "0x18099EA30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public InventionIdData ECDLKMGFNGE
		{
			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0x8B7500", Offset = "0x8B5D00", VA = "0x1808B7500")]
			[CompilerGenerated]
			get
			{
				return default(InventionIdData);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(RVA = "0xA3CDF0", Offset = "0xA3B5F0", VA = "0x180A3CDF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public InventionInstanceIdData NIAHCAFDLEC
		{
			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x95B910", Offset = "0x95A110", VA = "0x18095B910")]
			[CompilerGenerated]
			get
			{
				return default(InventionInstanceIdData);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0xC55830", Offset = "0xC54030", VA = "0x180C55830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public bool PHMKKFNBEFH
		{
			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0x95B8D0", Offset = "0x95A0D0", VA = "0x18095B8D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0xAF9040", Offset = "0xAF7840", VA = "0x180AF9040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x70A4950", Offset = "0x70A3150", VA = "0x1870A4950")]
		public CLCNDNNMJMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	bool BHDECOGLPDF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	bool CJPNFMIIMOA
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	IOFKIFCFMEE BPMNFJHEMLP
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IJAAGHFAPCE OFJDBCBALMK();

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IJAAGHFAPCE IGDJKCHLANP(IEnumerable<NLPICMPDONC> OBBIGKIBBBG, [In] UniformTRS LMBBEAFEJIL);

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JPKHIJCFGJB KJELOHPGIPI(ByteString GILHHAAGIIM);

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LJPKPBHHMFN CMJOIOBEPLO(ByteString AHCJGDGJNCB, CLCNDNNMJMC OFGFBCNFINC);

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FHBIPIPMFDP();

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GBFGHLDIDKD JMFGPDCIDIJ(IEnumerable<CEKOGANACJF> OGGNALBGGIL);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class IAMJKGINFGF
{
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[ServiceLifetime(Lifetime.Application)]
public interface FPAGFBEKLEO
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action EAOPAIBELMD;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public struct LCBMKGNCMPC : IEquatable<LCBMKGNCMPC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public BKBMPOCGEPN AAFKJACPDJA;

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x70B2300", Offset = "0x70B0B00", VA = "0x1870B2300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x1B1B8F0", Offset = "0x1B1A0F0", VA = "0x181B1B8F0", Slot = "4")]
	public bool Equals(LCBMKGNCMPC LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x70B2280", Offset = "0x70B0A80", VA = "0x1870B2280", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x9E3640", Offset = "0x9E1E40", VA = "0x1809E3640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LKKHEEEKIIC
{
	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	uint ODLBJAEAMLL
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public enum EJLAILNOPAJ
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	End,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LHPFKHKAJDK
{
	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FINCNHFCEKC(IMINHCKABCI IHDNMHOODCP, ReadOnlySpan<byte> OANAMCHLGCB);

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPGNHBAKBDD(uint BNPHHPHFBPC, ReadOnlySpan<byte> OANAMCHLGCB);

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BKCEABLLJEE(int EBOCJAGBOEL);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FPPOONJAKCJ
{
	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IMINHCKABCI NFBIMFJHEFD(ReadOnlySpan<byte> OANAMCHLGCB);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IAKGGNJFJNM
{
	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KMNKHMFMKNI(IMINHCKABCI KCGKBDGKIOP, ReadOnlySpan<byte> OANAMCHLGCB);

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INLBENKPFNH(ReadOnlySpan<IMINHCKABCI> LILGLJPFOCD);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public struct OCFKLMKKJAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public IMINHCKABCI IHDNMHOODCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public ReadOnlyMemory<byte> OANAMCHLGCB;
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public struct IMINHCKABCI
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public static IMINHCKABCI PFKFHJBNHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public uint LDJBHMFOPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public int NEONBCGNBJD;

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x95D280", Offset = "0x95BA80", VA = "0x18095D280")]
	public IMINHCKABCI(uint LDJBHMFOPJL, int NEONBCGNBJD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x70B0DB0", Offset = "0x70AF5B0", VA = "0x1870B0DB0")]
	public static bool PCBECHOJFKF([In] IMINHCKABCI GJAJAHIEACP, [In] IMINHCKABCI MCEIDNFODED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x70B0CD0", Offset = "0x70AF4D0", VA = "0x1870B0CD0", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x70B0D80", Offset = "0x70AF580", VA = "0x1870B0D80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x70B0DD0", Offset = "0x70AF5D0", VA = "0x1870B0DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x70B0CC0", Offset = "0x70AF4C0", VA = "0x1870B0CC0")]
	public void CCFBGGDGJEK([Out] uint LDJBHMFOPJL, [Out] int NEONBCGNBJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public struct CEKOGANACJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public Guid PLMJELCKKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public string GGLFPAKLDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public Vector3 BALIIBCILHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public Quaternion OJEGGOKKPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public Vector3 FKICLIIJEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int DDINJPPLINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public Dictionary<string, object> OFGFBCNFINC;

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x70A4380", Offset = "0x70A2B80", VA = "0x1870A4380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x70A41F0", Offset = "0x70A29F0", VA = "0x1870A41F0")]
	private static string OKBBAJLOOJP(Dictionary<string, object> CDAHCNPNJEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public enum NJPAFBPJGLI
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	SubGraphReplace,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	RestoreCreationData,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	InventionPreview
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public static class LIJDGJMFCKD
{
	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x70B2A40", Offset = "0x70B1240", VA = "0x1870B2A40")]
	public static bool OJCOGFHHDLP(this NJPAFBPJGLI OCLAPBNMMGE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[Flags]
public enum CEHFJHEJKKF
{
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	WorldPhasesMaster = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	AdditivePhases = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public interface LJPKPBHHMFN : IOFKIFCFMEE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	BKOMOBLAELM BFBEMMDDCHC
	{
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BDBMLJNBAHE();

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BEOBKDKNEFN();
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public interface IOFKIFCFMEE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	IEnumerable<CEKOGANACJF> LIEKBAHBKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	GBFGHLDIDKD EAFFDOLLDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	NJPAFBPJGLI JDHDLBDLIBL
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	LocalId OLLIMKGOFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	AKGEKLOCHMK AHPNCONAMCN
	{
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FPGKMMGLAFA(CEHFJHEJKKF HOLLLDFOEBJ);
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public interface BKOMOBLAELM
{
	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EMDNGDMHMDB(Guid HJDPFHBMCGB, [Out] Guid CMEODCENMPF);
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public interface JPKHIJCFGJB : IOFKIFCFMEE, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[Flags]
public enum HELEFCCFHKN
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface IJAAGHFAPCE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	AKGEKLOCHMK EGFDAFLGDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString MKHOAOBAKEN();
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public enum FBDGNEMJFFH
{
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public struct DFIJJNKGDLH : ISystemStateComponentData, IComponentData, IEquatable<DFIJJNKGDLH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float3 LILCKOIOLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float3 BFNCNDPEPLE;

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x70A6040", Offset = "0x70A4840", VA = "0x1870A6040", Slot = "4")]
	public bool Equals(DFIJJNKGDLH LIHCAHPMPHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MANHHBKAHOO
{
	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OEOCHJHCCMC(long JKPHJHLMDIJ);

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ECIBEMBPIJK(NativeParallelHashSet<long> KBFJAPEIHDA);

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EPAIGIJJJCF(World LHFELFOPEAG, NativeParallelHashMap<Guid, long> FLJKOENEEKD);

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EJIJIDBHMOC(HDJIEEPKAHE JINIJLGMOEA);

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GAOKPBLJHOH(HDJIEEPKAHE JINIJLGMOEA, [Out] Guid HAHLJOMFGNC, [Out] long JKPHJHLMDIJ);

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LABBHJHGJJK(HDJIEEPKAHE JINIJLGMOEA, Guid HAHLJOMFGNC, long JKPHJHLMDIJ);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PMEOPIBLHME(Guid HAHLJOMFGNC);

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MJFAMJDJLEA(Guid HAHLJOMFGNC, [Out] int LFCKFNFNCFP, [Out] int PNDGOIKNDLL);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void APFKFNGLMNH(Guid HAHLJOMFGNC, int LFCKFNFNCFP, int PNDGOIKNDLL);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MDGNHNIBGIP(Guid HAHLJOMFGNC);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class AGIJBHGDPCL
{
	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public AGIJBHGDPCL()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
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
