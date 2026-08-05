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
	public class LogRegistrationIndex : MBMEJMGLEPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x69D1C50", Offset = "0x69D0650", VA = "0x1869D1C50", Slot = "4")]
		public override void PMAGAGNLFOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NKEMPJMBNKE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69D2F70", Offset = "0x69D1970", VA = "0x1869D2F70")]
	public static void FLJPDMFMCOG(this Rigidbody BMGJPPIBOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69D2E40", Offset = "0x69D1840", VA = "0x1869D2E40")]
	public static void FLJPDMFMCOG(this Rigidbody BMGJPPIBOPD, Vector3 OIILFPJGMNB, Quaternion PDEGLHKGEJC, Vector3 ELEGHFDHEMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct NAKBJJNCGAC : IReadOnlyList<CGKDLJPPHGG>, IEnumerable<CGKDLJPPHGG>, IEnumerable, IReadOnlyCollection<CGKDLJPPHGG>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct NMDLOLKLHKK : IEnumerator<CGKDLJPPHGG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly MLMBOMBKNMD HKKFANGDDDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator CBNHKGJHAAB;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public CGKDLJPPHGG NHBEFFGDNPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x69D3F10", Offset = "0x69D2910", VA = "0x1869D3F10", Slot = "4")]
			get
			{
				return default(CGKDLJPPHGG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x69D3E90", Offset = "0x69D2890", VA = "0x1869D3E90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x42562F0", Offset = "0x4254CF0", VA = "0x1842562F0")]
		public NMDLOLKLHKK(MLMBOMBKNMD HKKFANGDDDO, NativeArray<LocalId>.Enumerator CBNHKGJHAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x69D3DD0", Offset = "0x69D27D0", VA = "0x1869D3DD0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x69D3E10", Offset = "0x69D2810", VA = "0x1869D3E10", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x69D3E50", Offset = "0x69D2850", VA = "0x1869D3E50", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly MLMBOMBKNMD HKKFANGDDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> OGMGDOCHOGN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public CGKDLJPPHGG PBAJKHBLIBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69D2460", Offset = "0x69D0E60", VA = "0x1869D2460", Slot = "4")]
		get
		{
			return default(CGKDLJPPHGG);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x69D1E00", Offset = "0x69D0800", VA = "0x1869D1E00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int FBFNIJCLFND
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x84C1A0", Offset = "0x84ABA0", VA = "0x18084C1A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public MLMBOMBKNMD LLLFBOHOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NBLIGAPNOOE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84C1A0", Offset = "0x84ABA0", VA = "0x18084C1A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool JJCCGNCICLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69D1DC0", Offset = "0x69D07C0", VA = "0x1869D1DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> PGLFHANJIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x252FD70", Offset = "0x252E770", VA = "0x18252FD70")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> DOODGCLCIFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x69D1E90", Offset = "0x69D0890", VA = "0x1869D1E90")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69D23D0", Offset = "0x69D0DD0", VA = "0x1869D23D0")]
	public NAKBJJNCGAC(int OLPFIFFGHOM, MLMBOMBKNMD HKKFANGDDDO, Allocator BPMIGAHMDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4255F80", Offset = "0x4254980", VA = "0x184255F80")]
	public NAKBJJNCGAC(MLMBOMBKNMD HKKFANGDDDO, NativeArray<LocalId> OGMGDOCHOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69D2210", Offset = "0x69D0C10", VA = "0x1869D2210")]
	internal NAKBJJNCGAC(MLMBOMBKNMD HKKFANGDDDO, NativeArray<Entity> MIIDIGABFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69D2330", Offset = "0x69D0D30", VA = "0x1869D2330")]
	public NAKBJJNCGAC(MLMBOMBKNMD HKKFANGDDDO, int NDKEFFPEPII, Allocator BPMIGAHMDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69D2280", Offset = "0x69D0C80", VA = "0x1869D2280")]
	public NAKBJJNCGAC(NAKBJJNCGAC CAIGJAGLCED, Allocator BPMIGAHMDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69D1EF0", Offset = "0x69D08F0", VA = "0x1869D1EF0")]
	public NAKBJJNCGAC KHMOMCMPNHI(Allocator BPMIGAHMDHE = Allocator.Temp)
	{
		return default(NAKBJJNCGAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69D1E50", Offset = "0x69D0850", VA = "0x1869D1E50", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69D1FA0", Offset = "0x69D09A0", VA = "0x1869D1FA0")]
	public NMDLOLKLHKK PNMCCDOOLCI()
	{
		return default(NMDLOLKLHKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69D2030", Offset = "0x69D0A30", VA = "0x1869D2030", Slot = "6")]
	private IEnumerator<CGKDLJPPHGG> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69D2120", Offset = "0x69D0B20", VA = "0x1869D2120", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public struct PNCPKFJNNGO : IList<CGKDLJPPHGG>, ICollection<CGKDLJPPHGG>, IEnumerable<CGKDLJPPHGG>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct HMLHDMOGBIB : IEnumerator<CGKDLJPPHGG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly MLMBOMBKNMD HKKFANGDDDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator CBNHKGJHAAB;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public CGKDLJPPHGG NHBEFFGDNPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x69CC140", Offset = "0x69CAB40", VA = "0x1869CC140", Slot = "4")]
			get
			{
				return default(CGKDLJPPHGG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x69CC0C0", Offset = "0x69CAAC0", VA = "0x1869CC0C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x42562F0", Offset = "0x4254CF0", VA = "0x1842562F0")]
		public HMLHDMOGBIB(MLMBOMBKNMD HKKFANGDDDO, NativeArray<LocalId>.Enumerator CBNHKGJHAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x69CC000", Offset = "0x69CAA00", VA = "0x1869CC000", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x69CC040", Offset = "0x69CAA40", VA = "0x1869CC040", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x69CC080", Offset = "0x69CAA80", VA = "0x1869CC080", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MLMBOMBKNMD HKKFANGDDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> OGMGDOCHOGN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public CGKDLJPPHGG PBAJKHBLIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x69D6390", Offset = "0x69D4D90", VA = "0x1869D6390", Slot = "4")]
		get
		{
			return default(CGKDLJPPHGG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x69D6410", Offset = "0x69D4E10", VA = "0x1869D6410", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x69D5C60", Offset = "0x69D4660", VA = "0x1869D5C60", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int NBLIGAPNOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x69D5C60", Offset = "0x69D4660", VA = "0x1869D5C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool DODHMAHIADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69D61F0", Offset = "0x69D4BF0", VA = "0x1869D61F0")]
	public PNCPKFJNNGO(int OLPFIFFGHOM, MLMBOMBKNMD HKKFANGDDDO, Allocator BPMIGAHMDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x69D6280", Offset = "0x69D4C80", VA = "0x1869D6280")]
	public PNCPKFJNNGO(MLMBOMBKNMD HKKFANGDDDO, Allocator BPMIGAHMDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x69D6300", Offset = "0x69D4D00", VA = "0x1869D6300")]
	public PNCPKFJNNGO(MLMBOMBKNMD HKKFANGDDDO, int NDKEFFPEPII, Allocator BPMIGAHMDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69D5DE0", Offset = "0x69D47E0", VA = "0x1869D5DE0")]
	public NAKBJJNCGAC JDFNOGKBOBG()
	{
		return default(NAKBJJNCGAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x69D5A00", Offset = "0x69D4400", VA = "0x1869D5A00", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x69D5A40", Offset = "0x69D4440", VA = "0x1869D5A40", Slot = "13")]
	public bool Contains(CGKDLJPPHGG IMMLPPOHEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x69D5AD0", Offset = "0x69D44D0", VA = "0x1869D5AD0", Slot = "14")]
	public void CopyTo(CGKDLJPPHGG[] MHMBNFEOIBK, int KJCAHDMHMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x69D5980", Offset = "0x69D4380", VA = "0x1869D5980", Slot = "11")]
	public void Add(CGKDLJPPHGG IMMLPPOHEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x69D5D30", Offset = "0x69D4730", VA = "0x1869D5D30", Slot = "7")]
	public void Insert(int ILOCEPPJPDO, CGKDLJPPHGG IMMLPPOHEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x69D5F40", Offset = "0x69D4940", VA = "0x1869D5F40", Slot = "15")]
	public bool Remove(CGKDLJPPHGG IMMLPPOHEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x69D5CA0", Offset = "0x69D46A0", VA = "0x1869D5CA0", Slot = "6")]
	public int IndexOf(CGKDLJPPHGG IMMLPPOHEAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x69D5EF0", Offset = "0x69D48F0", VA = "0x1869D5EF0", Slot = "8")]
	public void RemoveAt(int ILOCEPPJPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x69D5C20", Offset = "0x69D4620", VA = "0x1869D5C20", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x69D5E60", Offset = "0x69D4860", VA = "0x1869D5E60")]
	public HMLHDMOGBIB PNMCCDOOLCI()
	{
		return default(HMLHDMOGBIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x69D6010", Offset = "0x69D4A10", VA = "0x1869D6010", Slot = "16")]
	private IEnumerator<CGKDLJPPHGG> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x69D6100", Offset = "0x69D4B00", VA = "0x1869D6100", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FDDNPLJJLNC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int HEKAECIJEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> DDBEBNGCFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CGKDLJPPHGG OHAEKMCJDMC(CGKDLJPPHGG OGMGDOCHOGN);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NEIBJIAAJHG : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface NGEGIKNMDON : IBLIMOJHJNC, IKJAJBIJIFA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool FIGHPIBDBNL
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	JDKMLFFGACL EHPGMFHAPPD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	FIDFCBNABDD HBMACIDKHAP
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	JOHMDBMKIAN IBECFGKEHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	KLFMBFKCFME OKHOECLJEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface IKJAJBIJIFA
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool CEPCMMODIML
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface NOMJANJFFNC
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JIIPLKIOMNP(bool DBOBEHLEAAE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[PDIHONIFFOJ(BLECGLOBIIF.PhotonRoom)]
public interface FFDJNAPEOBK
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool DLAFGKJNLML
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OBJBFLDPCDG(bool OPDIOPBPNGJ);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LJHJBOEAMMH();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LNBPKHOCLPM(ByteString AIOLAHHPMLA);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PLDOEMMIEIF();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MLENDLIDOHG();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MONFKJFPCPN();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MNDMODCAGFH();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KCNKNMHKMCD();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface JOHMDBMKIAN
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	GHEIIEALIKL EHPGMFHAPPD
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	FIDFCBNABDD HBMACIDKHAP
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	GMHMJBINOFM NPPLAENOLGP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	PAJELBIKBJD JHBAOEFIJBC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	NGEGIKNMDON OALDJBHMDAA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	FFDJNAPEOBK CDPEBGMEGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	MLMBOMBKNMD LLLFBOHOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	DKDHMCENGAO LNBAMHJPONJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	AAOHJGIHKFB ODEPOPAPIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	EHPLCKIIOCC MDODKKICDOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	OGDFBGGLLPK OCNJEICABHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	JIDBIEEPAJD FPDIMFHCNLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	JJDFBCPONGI OKDCNJGBGLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	ELBDOCAEELF PCKNFHJFAHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	IAFJOGAAGBA KJMMHCACCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	KINCDCCJKBJ EMHBKBMGBHL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	EIBKPAKINKJ NMPFJPBPBGC
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	MJFANEGMEKK GNGGACCOCKC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	BINFGJEJBIM ONJHKNBGBBB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	HIKHEIGECCE CALAEOHEKKH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	HGHBBJBCEPA PEMPELCADOC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	CDPGOKKHBGC ADLAGBAKJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	ADLGAMPPLJO BGLEBOIANEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	HHGHIFLNHHH PGAOMCBJINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	EHBMJCNPHBB GKCAJHGPHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	BIHANNBMCFM ILEJACCCNHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	NCCGCHJNPFA HNOFFOIDLNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	AIIOEGMABAH LHDJCLMHNLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	GOGLKACKFLJ CJKIIFFEGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(LJDJCCBCEAH))]
public readonly struct CGKDLJPPHGG : IComparable<CGKDLJPPHGG>, IEquatable<CGKDLJPPHGG>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly CGKDLJPPHGG OPGDHOBODPJ;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int BPGNFPFENMD = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int IBECKPBIDID = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int GNPEHNDFHDE = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int EHLJDGIIMCB = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId IDEOIAGJPJE;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public MLMBOMBKNMD LLLFBOHOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69C3720", Offset = "0x69C2120", VA = "0x1869C3720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public NGEGIKNMDON OALDJBHMDAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69C5F00", Offset = "0x69C4900", VA = "0x1869C5F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public LocalId KMIHEFGGJOK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x69C5EC0", Offset = "0x69C48C0", VA = "0x1869C5EC0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal KLFMBFKCFME OKHOECLJEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x69C6440", Offset = "0x69C4E40", VA = "0x1869C6440")]
		get
		{
			return default(KLFMBFKCFME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool DBBOGLGLBCM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x69C5F60", Offset = "0x69C4960", VA = "0x1869C5F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool BDFABPIBEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x69C64D0", Offset = "0x69C4ED0", VA = "0x1869C64D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x69C6650", Offset = "0x69C5050", VA = "0x1869C6650")]
	public CGKDLJPPHGG(MLMBOMBKNMD OLKEDAFCOCC, LocalId IDEOIAGJPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
	public BBFFIPHJEOF GGNMFEDAFIH()
	{
		return default(BBFFIPHJEOF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x69C6490", Offset = "0x69C4E90", VA = "0x1869C6490")]
	public static LocalId OCHPDIOAFKC(CGKDLJPPHGG HKIBFMKHIED)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69C6450", Offset = "0x69C4E50", VA = "0x1869C6450")]
	public static Entity OCHPDIOAFKC(CGKDLJPPHGG HKIBFMKHIED)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x69C6320", Offset = "0x69C4D20", VA = "0x1869C6320")]
	public static bool IKJGJDJDJIH(CGKDLJPPHGG GDMICPKKGFK, CGKDLJPPHGG JCAJPPHEFGK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x69C4900", Offset = "0x69C3300", VA = "0x1869C4900")]
	public static bool BNNGOGJDCPO(CGKDLJPPHGG GDMICPKKGFK, CGKDLJPPHGG JCAJPPHEFGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x69C6520", Offset = "0x69C4F20", VA = "0x1869C6520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x69C6180", Offset = "0x69C4B80", VA = "0x1869C6180", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x69C60A0", Offset = "0x69C4AA0", VA = "0x1869C60A0", Slot = "4")]
	public int CompareTo(CGKDLJPPHGG HENLEJBGFIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "5")]
	public bool Equals(CGKDLJPPHGG HENLEJBGFIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class DOEHMBHOBAN
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x69C7060", Offset = "0x69C5A60", VA = "0x1869C7060")]
	public static MHHMJHGEJDN GALHMCAPMFJ(this CGKDLJPPHGG GKHPLGCJCPF)
	{
		return default(MHHMJHGEJDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x69C6FB0", Offset = "0x69C59B0", VA = "0x1869C6FB0")]
	public static BBFFIPHJEOF ADLOAHPGAPP(this CGKDLJPPHGG GKHPLGCJCPF)
	{
		return default(BBFFIPHJEOF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2994C80", Offset = "0x2993680", VA = "0x182994C80")]
	public static T EGIDIBFMGIG<T>(this CGKDLJPPHGG GKHPLGCJCPF) where T : struct, KJIEOKOBPKO
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class LJDJCCBCEAH
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct KLFMBFKCFME : IEquatable<KLFMBFKCFME>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte AHCMMMOBCPP;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] PAMHLPPBCHD;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static MLMBOMBKNMD POMDICPEPNN;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static NGEGIKNMDON CGJCDGIPLOP;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static MLMBOMBKNMD[] ENLIAGKCHJN;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static NGEGIKNMDON[] EHOLKDEDBBE;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> KPNADDOJPMG;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NGEGIKNMDON OALDJBHMDAA
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x69CFAF0", Offset = "0x69CE4F0", VA = "0x1869CFAF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public MLMBOMBKNMD CEKBAPNDGEB
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x69D0220", Offset = "0x69CEC20", VA = "0x1869D0220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x69D0870", Offset = "0x69CF270", VA = "0x1869D0870")]
	static KLFMBFKCFME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xE21AD0", Offset = "0xE204D0", VA = "0x180E21AD0")]
	internal KLFMBFKCFME(byte DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5B3FAE0", Offset = "0x5B3E4E0", VA = "0x185B3FAE0", Slot = "4")]
	public bool Equals(KLFMBFKCFME HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x69CFDF0", Offset = "0x69CE7F0", VA = "0x1869CFDF0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D5C580", Offset = "0x1D5AF80", VA = "0x181D5C580", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x69D07B0", Offset = "0x69CF1B0", VA = "0x1869D07B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x69D0390", Offset = "0x69CED90", VA = "0x1869D0390")]
	private static MLMBOMBKNMD OJJHBIEPKJP(byte AHCMMMOBCPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x69D0440", Offset = "0x69CEE40", VA = "0x1869D0440")]
	private static NGEGIKNMDON OLBHEOGFPEE(byte AHCMMMOBCPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x69CF970", Offset = "0x69CE370", VA = "0x1869CF970")]
	private static object AGFMADDGHJJ(byte AHCMMMOBCPP, object[] AHBFNFFEMPG, object JIEGAHKKHCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x69D0380", Offset = "0x69CED80", VA = "0x1869D0380")]
	private static int NLGNMECLJIG(byte AHCMMMOBCPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x69CFAE0", Offset = "0x69CE4E0", VA = "0x1869CFAE0")]
	private static int BCGDIOILKAC(byte AHCMMMOBCPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x69D0300", Offset = "0x69CED00", VA = "0x1869D0300")]
	private static (int, int) LPFMAMDOKBL(byte AHCMMMOBCPP)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x69CFDE0", Offset = "0x69CE7E0", VA = "0x1869CFDE0")]
	private static byte EFLKGCONKIF(int OKMBFDMPMHM, int ILOCEPPJPDO)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x69D04F0", Offset = "0x69CEEF0", VA = "0x1869D04F0")]
	internal static KLFMBFKCFME PMAGAGNLFOG(NGEGIKNMDON GHPIBOGBGEI, MLMBOMBKNMD DJBAFBLCEDH)
	{
		return default(KLFMBFKCFME);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x69CFBD0", Offset = "0x69CE5D0", VA = "0x1869CFBD0")]
	internal static void DHJCJMHEBFH(KLFMBFKCFME AHCMMMOBCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x69CFE90", Offset = "0x69CE890", VA = "0x1869CFE90")]
	private static void FHKHKHLJNEM(int OLPFIFFGHOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface PJPBPCLBPED
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDNDMDLGFLB();

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPNPKICNEOH(bool LCLBHDEPDJI);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LOGAHGGNLPG(GameObject AOOABPFBFDN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface MJJLAACAKAE
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Guid HNMPIAKFIFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FNNKEIOLNMP(Guid MGFMAFPODJC, Guid OAAAKELMLJG, Guid JDFGAMCHMGP);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Guid JIMAIHONACE(Guid OLJKGANNLIC);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task AGIDOFJMACL(CGKDLJPPHGG MFJBPDOGJGA);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IDPAOMICNDA(CGKDLJPPHGG DPEMCBKEJDJ, CGKDLJPPHGG EMNGIAIDBPA, [Out] Vector3 FKMPANFIJIC, [Out] Quaternion CMAJCEDKDLM);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MGPODJOKEOC(PLPKBNHGIGB IJAPOIOBPKJ, Vector3 FKMPANFIJIC, Quaternion CMAJCEDKDLM);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DHCKKHLAPCD(CGKDLJPPHGG HFBAPJKBHMB, [Out] Vector3 DJNAGJBBKMF, [Out] Quaternion EKDGAFADBBP);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OLBNGLFFOGD(EDEPECMONIO GCKIAAJACND, Guid NGHFPGGGJDF);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NPAPKLAGHCE(Guid OLJKGANNLIC, bool OPDIOPBPNGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface COJMHEGPAFM
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FHCLJBNNLCH(NAKBJJNCGAC OGMGDOCHOGN);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface ECOOJIPCENE
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GEONPCACIAE(GameObject EOFGKAGLHBN, GameObject FGNDNIHHMIM, int LGCICENBILD);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface FIDFCBNABDD
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	PJPBPCLBPED IBOABGNKIKL
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	LNEPOLMJBJD COFNGFECCGA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	AOAEOFBFPGF MFDKPHINNEB
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	KLGEMCNMPOB NIMMAHAGMHK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	FKLLPNJJOPJ BFCCGAMOFGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	FKCCBCAHFMB BHNDNCPJOCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AIBDFEIPFME POOMAEMIONB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	NBAFGCONOHO LMPKCBEEKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	PCIEODKFLMA HACPMCCPCOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	FPLHHLMFCEB AACAMOPHDGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface LNEPOLMJBJD
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string MHFOABCLHAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface DLDFLFACGKE
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KMONLCIJCJF(Action GKKKLNHPKBN, bool JIGDAKLNGOF);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IHKPKDLAELP(string CCMEKJGADHN);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int PJNOHNHNKKD(string CCMEKJGADHN, int JIEGAHKKHCA);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BIOCPMDHHBP([Out] bool DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JGMNIAOAHFO([Out] bool DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OJNCOKJLCIJ([Out] int DBOBEHLEAAE);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface AOAEOFBFPGF
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string DGDIHAOFFPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] JMLPAOMDJIE(IEnumerable<LOKEPPMGDGP> KFKIKNHIHCL);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EEFGJAEAPPE(GameObject AOOABPFBFDN, [Out] MHHMJHGEJDN[] LFGKPJIGHOO);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HNCIDAGACOC(GameObject AOOABPFBFDN, [Out] int KKHNBALIAFD, [Out] MMAKLLHOPJG ECCNNFLILMF);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EDEPECMONIO IMEOGKGJHIL(LOKEPPMGDGP BJLMEIJMPBN);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EDEPECMONIO IMEOGKGJHIL(string MGIDEFLKNJN, MHHMJHGEJDN[] DCKEDDMMHKE, Vector3 GLNEOPDBMFP, Quaternion NGGFFKDNCFB, Vector3 GIFACOBMIEN);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EDEPECMONIO OHEFPKJNBIA(string MGIDEFLKNJN, MHHMJHGEJDN[] DCKEDDMMHKE, Vector3 GLNEOPDBMFP, Quaternion NGGFFKDNCFB, Vector3 GIFACOBMIEN);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject PGLNJENLGIG(string MGIDEFLKNJN);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ANMBEFJFNHK(GameObject ECLGMCHICJD, bool GEBFAKFHJEB);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CBEPIGCOEHH(GameObject AOOABPFBFDN, bool AIAHIFDGKPN, bool ODCIAJGCPAC);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class ANIBEIEMPCM
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x69C4340", Offset = "0x69C2D40", VA = "0x1869C4340")]
	public static EDEPECMONIO IMEOGKGJHIL(this AOAEOFBFPGF GLFIGPDLPBG, Vector3 GLNEOPDBMFP, Quaternion NGGFFKDNCFB, Vector3 GIFACOBMIEN, params MHHMJHGEJDN[] LFGKPJIGHOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x69C4490", Offset = "0x69C2E90", VA = "0x1869C4490")]
	public static EDEPECMONIO OHEFPKJNBIA(this AOAEOFBFPGF GLFIGPDLPBG, Vector3 GLNEOPDBMFP, Quaternion NGGFFKDNCFB, Vector3 GIFACOBMIEN, params MHHMJHGEJDN[] LFGKPJIGHOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface KLGEMCNMPOB
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IBAKFCCNIGK(bool OPDIOPBPNGJ);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface FKLLPNJJOPJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool FJNIIPLNCND
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool IGOCMKBBFCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool GEIEGKKGMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	int NBALPEKDIJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool JBMOPGBKNDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FFCDLNKIHKE(object NBBCEJPPPCO);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FDAGMKGEIPH(object NBBCEJPPPCO);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LNDMMFJEBHP(object PIBCCEDJCCL);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ELNPBNAFCEF(object PIBCCEDJCCL);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ViewId LMNJJHFBHFO(GameObject DLAKGLDPKHI);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KGCPFINHKIG(NativeArray<ViewId> EGNJPDDIHGJ);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LOCKCFJBNIO(NativeArray<ViewId> GLFFAOKBJLH);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GFJAFIPMENE();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KKNCDJCPBMB(uint KLANLLGOPBE, ReadOnlySpan<byte> EAPANCNBPNA, bool AEGLJHDINAI = false);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KKNCDJCPBMB(uint KLANLLGOPBE, ReadOnlySpan<byte> EAPANCNBPNA, ReadOnlySpan<byte> LJEEBAKOGJO, bool AEGLJHDINAI = false);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KANIDKDNOOI(Func<int, bool, int> LKGEBALAMJA, bool CPHACLGAKPB);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KAPLFLLILPB(object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AALGNIICKMK(object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	uint EGLIHMINOFP(uint JJCMLJHKNHF);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class IECMEJGIJKC
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x69CEC10", Offset = "0x69CD610", VA = "0x1869CEC10")]
	public static NDEAMOHBGOB DGKFJBCMKGJ(this FKLLPNJJOPJ GGBLAFAJJAN, object JCIFCENKMKP)
	{
		return default(NDEAMOHBGOB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct NDEAMOHBGOB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private FKLLPNJJOPJ GGBLAFAJJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private object JCIFCENKMKP;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x69D2DB0", Offset = "0x69D17B0", VA = "0x1869D2DB0")]
	public NDEAMOHBGOB(FKLLPNJJOPJ GGBLAFAJJAN, object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x69D2D60", Offset = "0x69D1760", VA = "0x1869D2D60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface FKCCBCAHFMB
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKBJOKCDCAC(GameObject AOOABPFBFDN);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface AIBDFEIPFME
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public struct JKHBMFCAJJO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private AIBDFEIPFME JJJPFGLKCGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Task JCINMAJOONI;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Task GKKIOFPGLJA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4B0", Offset = "0x8BDEB0", VA = "0x1808BF4B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x69CF080", Offset = "0x69CDA80", VA = "0x1869CF080")]
		public JKHBMFCAJJO(AIBDFEIPFME JJJPFGLKCGO, CancellationToken AOLOJHLCMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x69CF030", Offset = "0x69CDA30", VA = "0x1869CF030", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BEOHFMOHNNB(string BDCMABOIIFF, float IHJBBHNOLLJ = 5f);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HBPOCGBOHAC(CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ELNNGBDEHFH();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class CGJKPBDGIOD
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x69C5EA0", Offset = "0x69C48A0", VA = "0x1869C5EA0")]
	public static AIBDFEIPFME.JKHBMFCAJJO PANHCHNNEEP(this AIBDFEIPFME GGBLAFAJJAN, CancellationToken AOLOJHLCMLE)
	{
		return default(AIBDFEIPFME.JKHBMFCAJJO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface PKJDMEKNPBC
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JOFJAHJDLNL(GameObject AOOABPFBFDN);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BEALDNBDMDI(GameObject AOOABPFBFDN);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HPGHNHLGBGO(int CEGCHAFCKNG);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object OFOKKNPLJFO(CGKDLJPPHGG IDEOIAGJPJE, GameObject AOOABPFBFDN, Action<CGKDLJPPHGG, int> BHKFHJNIBAC);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FEMKJCFDNBF(GameObject AOOABPFBFDN, object OPABCBJHPOD);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface LOPEFKBMOEL
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool EGLMKEKIOOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate AMHLGLDAIMG(HPGJMHGDAMA.FFENLDPFBKH HOJPPOPGLCN, Action<HPGJMHGDAMA.FFENLDPFBKH> BHKFHJNIBAC);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HPGIKEEOFKL(HPGJMHGDAMA.FFENLDPFBKH HOJPPOPGLCN, Delegate BHKFHJNIBAC);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate NBKFLOCJEII(HPGJMHGDAMA.FFENLDPFBKH HOJPPOPGLCN, Action<HPGJMHGDAMA.FFENLDPFBKH> GCOIAPALLHE);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PGLCABPEEOO(HPGJMHGDAMA.FFENLDPFBKH HOJPPOPGLCN, Delegate BHKFHJNIBAC);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OJBMLGHDKLP(HPGJMHGDAMA.FFENLDPFBKH HOJPPOPGLCN);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HPGJMHGDAMA.FFENLDPFBKH LAELFLLCLEK(GameObject AOOABPFBFDN);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface NBAFGCONOHO
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	int JDJMKJNDIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	int KFGIAEBOBGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int AFKPOLHINOC(GameObject AOOABPFBFDN);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PCHJNNBEFDB([Out] Vector3 GLNEOPDBMFP);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NKDBJFFCHAF();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CGKDLJPPHGG LGLPMPGPGBF(int CEGCHAFCKNG);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface PCIEODKFLMA
{
	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool DLAFGKJNLML
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface IPAFOCECOHG
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	POPMLBEHLKI DDMFFGLLAMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	ILECDBAGIBM PGDHPPCHEGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NHPLPJJCHPP(Transform OFGHBAGNEDJ);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OEPCNNFDEDN(Transform OFGHBAGNEDJ, NNIPIIDFJHC NHHKIAGJOHG);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HPKNFAKJHMP(Transform OFGHBAGNEDJ, ALFFGGLLEIB COJIOHPGJMM);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface EOAMFKOALPJ
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface FPLHHLMFCEB
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PIGANBLAPON;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GLDHLKCKKOC(NAKBJJNCGAC EFNBIJLLLBG, bool CGIGFPIDADA);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface ONHBNMGDOCN
{
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDMFCIPCGLP();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface EHGKIIIOHIC
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MMAKLLHOPJG JEEODNIFBJH(GameObject DLAKGLDPKHI);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JONBMHMPMDI(GameObject AOOABPFBFDN, PKOJBPLDAHP AHAAFAHPNFN, AFMKDICJKCC BALBBCGLJOG);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool INKDDPHDDJC(CGKDLJPPHGG IDEOIAGJPJE, bool OEMPFHLDJPP, float3 ABFBLOJBNIH, quaternion ELGAFDDBMBJ);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LJHPMMHKAHL(BBFFIPHJEOF BDGKMFGNNGD, BBFFIPHJEOF PIBCCEDJCCL, KGNHGFCDFGP IOHMFKLLMFN);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PJCONCBMODD(BBFFIPHJEOF BDGKMFGNNGD, KGNHGFCDFGP IOHMFKLLMFN);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OIDLKCPACDB(NAKBJJNCGAC AIBDNJKOPDB);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KCKLEMNBGOG(NAKBJJNCGAC HKKFANGDDDO, NativeArray<LocalPoseData> HEJHKAOMCOB, NativeArray<float3> OLKEKHNFGGI);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JENHKHNECBN(NAKBJJNCGAC HKKFANGDDDO, NAKBJJNCGAC GEOLOHPNJPH);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LMMJJNCDDHK(NAKBJJNCGAC HKKFANGDDDO, bool DHJDCEHIAFN);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KFBGDNFLLGB(NAKBJJNCGAC HKKFANGDDDO, bool ILGGCMPLENN);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct JNHLOJMNACD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly BCIAGPAGMGD BPFHAJJBCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly BCIAGPAGMGD PECJJMDPJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly uint HCIECLKPLPC;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x69CF410", Offset = "0x69CDE10", VA = "0x1869CF410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct KILJPPLBLNB
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly LGKLDLNGEGN DHOGKNDCDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly JNHLOJMNACD GKKKLNHPKBN;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x69C6C50", Offset = "0x69C5650", VA = "0x1869C6C50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct DBHBMBAENJP
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static readonly LGKLDLNGEGN DHOGKNDCDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal readonly JNHLOJMNACD GKKKLNHPKBN;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x69C6C50", Offset = "0x69C5650", VA = "0x1869C6C50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct MGJMJKKJBAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal readonly uint HCIECLKPLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal readonly bool CILOABHPBIE;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x69D1D20", Offset = "0x69D0720", VA = "0x1869D1D20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct BCIAGPAGMGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal int LJEHDHLGGJA;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x69C5020", Offset = "0x69C3A20", VA = "0x1869C5020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface LNGLCLNGGAO
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	MAEJGPFOFIH BGCJBFOAHHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum CFENICNNCEM
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
public interface EDEPECMONIO : FHDNGCDLHNE
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	CFENICNNCEM DEFDLPLIMAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool LGMCJFFNFAD
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GameObject AOOABPFBFDN
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<EDEPECMONIO> MCOOBJHAGIO;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(GMHMJBINOFM LHKJIBFFKNG, CGKDLJPPHGG HEHHGMKHDHB);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool IAHBNBEBLDH);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class CKOOLJIMKML
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x69C6860", Offset = "0x69C5260", VA = "0x1869C6860")]
	public static bool NOFBECBNIND(this EDEPECMONIO BAOLDOMIMDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x69C68B0", Offset = "0x69C52B0", VA = "0x1869C68B0")]
	public static bool OMGFOKFOCPH(this EDEPECMONIO BAOLDOMIMDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x69C6780", Offset = "0x69C5180", VA = "0x1869C6780")]
	public static bool BFGHJAILCBJ(this EDEPECMONIO BAOLDOMIMDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x69C67D0", Offset = "0x69C51D0", VA = "0x1869C67D0")]
	public static bool FIGHPIBDBNL(this EDEPECMONIO BAOLDOMIMDG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface FHDNGCDLHNE
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool NMLOGLDCMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	CGKDLJPPHGG CHLKNJOLKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
internal interface KOMFDHCGAHB
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<BNOABJKHKBM> MKFCGPHPNHC;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface PEMLDCJCDMK
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLOABBIBMGM(Vector3 GLNEOPDBMFP, Quaternion NGGFFKDNCFB, Vector3 GIFACOBMIEN);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APFFKENNKIB(CGKDLJPPHGG EMNGIAIDBPA);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FNKBJCDPGIL(bool KPABAFFDKJG);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NLIFLHCIPHA(bool ILGGCMPLENN);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface LEMMBDELOHJ
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface KKHOOOEGFPA
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(HMIKMKPGKPD KBMBAELNABJ);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface HMIKMKPGKPD
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	GameObject AOOABPFBFDN
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	Transform OFGHBAGNEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	JKJIEFIICJB PFJMLGGGGCM
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool KMJLNIADHEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EIGFGHOLKAA(JKJIEFIICJB PEDEOCHCNFH);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface JKJIEFIICJB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	CGKDLJPPHGG CHLKNJOLKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	Rigidbody ANKDGFGHEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	HMIKMKPGKPD FEBHEKFMAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	GameObject PEPDCAMMCBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Transform JKDHBCECKGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	JKJIEFIICJB LKABBOLBEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	JKJIEFIICJB CMJBHOFLJPO
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	int KPPAJCGFPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool OJBMLGHDKLP
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool OLEIKJADGKE
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	EBKBOJHOLGL GBKKBMKCHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "31")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	EGCBEDHFHPO APDAHLMFMPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	float HCFPALINGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "35")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 OHIMHJKNBBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 JKIBPHPNMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	Vector3 CMLKBLFDDLA
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 CGHCHFLNLEF
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool BBNFHNPPLBC
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool BBMLDLGJCJA
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	bool GAOHMGIOIKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 LMGIBEHEHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 AOOBNGPIECO
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 LKBBFDLMBHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "50")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Vector3 EKHBCLMDCOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	float KJIHPLPMADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	float LANFEFDKEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	Vector3 EDPIICPNBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Quaternion JHCNHKODLPA
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	float JADHIHMHHMG
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	float PMHDKIEDGMN
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	bool NEDLPALOLMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	ALFJCHGPFEB JODJINPJKCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool ADHPAKJDEOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Transform JHFGJGILODH
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 GBLOKAEKGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float EADKAPOFDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	float OKCMJJPFOML
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Quaternion OKAGPECGPFM
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 ILAABAGNPPN
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Quaternion MNPKHAFPMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	RigidbodyConstraints KNEMAKFPIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool DOLMDGJBAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	CollisionDetectionMode AEDNJJODHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool KOEEFHLGECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event FAKKNJDHEEJ EEIPCPBLFLF;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event FAKKNJDHEEJ OGJCLDNCBDJ;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event FAKKNJDHEEJ ANDDKFFFLNB;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event FAKKNJDHEEJ EIKDMIJICCO;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event FAKKNJDHEEJ MFEODPJIPMC;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event FAKKNJDHEEJ OGAKFGNKACL;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event FAKKNJDHEEJ OHJFMGGNIDG;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event JDMIOPHFEMM PAOPDENECIC;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<KFIHHKNEBMF, KFIHHKNEBMF> ACAFKCPEHDK;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	JKJIEFIICJB OEKONKEJMOF(int ILOCEPPJPDO);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void GAPPAGCJDEF((Quaternion rot, Vector3 moments) IIFLMEOHBOK);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void GONOBOFENIO();

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void BIMKGBAEGEP();

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void FLLAAJGOOLP();

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void DNCBBDPIJIF();

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void APFFKENNKIB(JKJIEFIICJB DBOBEHLEAAE, bool OLBIGMEKFFD = false);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void PFHNPGOOLDF(object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void MAKAEJINPPM(object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 KAOEOAFIGHJ(Vector3 PJHDGKKEAIL);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "95")]
	Vector3 IGJHINDIJMJ(Vector3 LNGMMPKBNBD);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void JPCNAOMICAJ();

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void JANLJPDNGLA();

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void FBMNKHGFFNB();

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void MOLKJLBJFLJ(Vector3 LADJHAOBEDO, Vector3 HEFMKCBGOPG);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void GEDAGAIHADD(Vector3 PIFHENFKDHB, Vector3 AMLNDCBAFED);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void CHGEDLILKHL(Vector3 JGCMFGPJEBC);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void KHCKHMIPMNC(KELPIDMOECD PNOFGNKBEPL, Vector3 LCCMGOJPBMA, float IGGAJLACDEJ, float LFEDGHAJLBJ = 8f, float DELKKLHPPEP = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void HCGOKDHLMOF(DAOMMCIAOEJ NGLIKOKHABN, Vector3 HDLPFGDIGCD, float KAKBEDIMKEC = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void OPCAGBODJDB(DAOMMCIAOEJ NGLIKOKHABN, Vector3 NGGFFKDNCFB, float EIPKJPHAGMD = 7f, float JHPDDNKFPBF = 1f);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "105")]
	Vector3 FGHIMFBLDFP(Vector3 DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "106")]
	Vector3 PFDKGENAMEN(Vector3 DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void EKDEKGLCNFJ();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void PPJPBCBBLDE(JKJIEFIICJB CNBPKDOLLMB, object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "109")]
	void CKDPNJLJKDK(object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void LOOMDOJOFHB();

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void PNIADNPDMEB();

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void KAKHHKCOMEP();

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "113")]
	bool KDFLEENLFFK();

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void OILIAJJHDPL();

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void MIPHLDNNFFM(object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "116")]
	void FKLCBPOGBCL(object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void GLNDKFEBIMN(object JCIFCENKMKP, bool MGPOKEFPGBG);

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void FKDGKOOBJKB(Vector3 PPBFOEBKKOC, Quaternion EKPDKJAAKLF);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void FFBABMDBLJA(Vector3 CDCOLBIEICK, Quaternion KIJAKHEBLHL);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "120")]
	bool LMFKKPFLEEL(float MCFAHFLECNM);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void PIPHPFIIOPI(object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void MCMAJPNOPLO(object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void BKOIIDAFPJE(object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void JJLLHEJKBEB(object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void KHBAFNHBCGF(Vector3 JFKDELALDJD, ForceMode HFPFADDBPGP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void LLMJHCPBEGE(Vector3 JFKDELALDJD, Vector3 GLNEOPDBMFP, ForceMode HFPFADDBPGP);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void EIIIEIJMMOD(Vector3 EKGFJGIMCEO, ForceMode HFPFADDBPGP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void BDHIHLIEIFN(Vector3 EKGFJGIMCEO, ForceMode HFPFADDBPGP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "129")]
	bool GGEPOKHBBLE(Vector3 NMAFDGGPBKA, [Out] RaycastHit KGGKMKMJHGJ, float APKOACGHEPL);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void PIIDJCGOECO();
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface EGCBEDHFHPO
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NCCEJDFMHOA(Vector3 NCIFDHFGPGG);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AENCDPENANH(Vector3 FJPMHBKDAMB);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KBBJAEPEBBK(Vector3 NCIFDHFGPGG);

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CINKDAFNCFB(Vector3 FJPMHBKDAMB);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface EBKBOJHOLGL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 BNHJBOOGGCI();

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 DKAMHJAJBPM();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public delegate void FAKKNJDHEEJ(HMIKMKPGKPD ADLKKBOLEFK);
[Cpp2IlInjected.Token(Token = "0x2000040")]
public enum BLKPGPCFEOP
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
public enum KELPIDMOECD
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
public delegate void JDMIOPHFEMM(HMIKMKPGKPD ADLKKBOLEFK, bool OLBIGMEKFFD = false);
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum DAOMMCIAOEJ
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct OHPIALCJANL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Rigidbody NIHPDINGBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public object BMLCBLNGOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector3 BALABFLOFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector3 EEIBIMBJMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public AHFBHELEKED NNJNCPOKHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool DMPKEEFFDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool KAAPHAKFDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool IEHNMHPMCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool OBDJGFEAFEH;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface ECDPNBAPABD : FEBPCDAKPKJ<MHHMJHGEJDN>, KGAIHEGCMCF, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface AEALEDGJNKI<T> : PNHKMJJBEPJ<MHHMJHGEJDN, T>, FEBPCDAKPKJ<MHHMJHGEJDN>, KGAIHEGCMCF, IDisposable, ECDPNBAPABD where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class PEHBPIBCJEP
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2C7D360", Offset = "0x2C7BD60", VA = "0x182C7D360")]
	public static bool GBFLHMLGFGE<T>(this FEBPCDAKPKJ<MHHMJHGEJDN> DDHAIBOKNCF, MHHMJHGEJDN DCKEDDMMHKE, [Out] T DBOBEHLEAAE) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x2990760", Offset = "0x298F160", VA = "0x182990760")]
	public static bool BJDAAADFLKD<T>(this FEBPCDAKPKJ<MHHMJHGEJDN> DDHAIBOKNCF, MHHMJHGEJDN DCKEDDMMHKE, [In] T JHNCHHHEDDG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface MLEDKOIKBOA : FEBPCDAKPKJ<CGKDLJPPHGG>, KGAIHEGCMCF, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface GMIMFDEEIBG<T> : PNHKMJJBEPJ<CGKDLJPPHGG, T>, FEBPCDAKPKJ<CGKDLJPPHGG>, KGAIHEGCMCF, IDisposable, MLEDKOIKBOA where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class DKOGGDPHLBM
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x2990730", Offset = "0x298F130", VA = "0x182990730")]
	public static T AMGKFNFCLFC<T>(this FEBPCDAKPKJ<CGKDLJPPHGG> DDHAIBOKNCF, CGKDLJPPHGG IDEOIAGJPJE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x2990760", Offset = "0x298F160", VA = "0x182990760")]
	public static bool BJDAAADFLKD<T>(this FEBPCDAKPKJ<CGKDLJPPHGG> DDHAIBOKNCF, CGKDLJPPHGG IDEOIAGJPJE, [In] T JHNCHHHEDDG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct IECHECDALGG : IComparable<IECHECDALGG>, IEquatable<IECHECDALGG>
{
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly IECHECDALGG OPGDHOBODPJ;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly IECHECDALGG IKIFPCBCCLD;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly IECHECDALGG GKEANMLNGOH;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IECHECDALGG OEDGDCEFKDL;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly IECHECDALGG KEHOBNOLHND;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly IECHECDALGG GNCOJAGMLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public int JCLKIAMNLIO;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool EODJJIPCFKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x69CE9B0", Offset = "0x69CD3B0", VA = "0x1869CE9B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public int KJHOJIDAPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x69CEA50", Offset = "0x69CD450", VA = "0x1869CEA50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0xA72650", Offset = "0xA71050", VA = "0x180A72650")]
	public IECHECDALGG(int ILOCEPPJPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x69CEA60", Offset = "0x69CD460", VA = "0x1869CEA60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x69CE9C0", Offset = "0x69CD3C0", VA = "0x1869CE9C0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x9E72B0", Offset = "0x9E5CB0", VA = "0x1809E72B0", Slot = "5")]
	public bool Equals(IECHECDALGG HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x1A67A40", Offset = "0x1A66440", VA = "0x181A67A40", Slot = "4")]
	public int CompareTo(IECHECDALGG HENLEJBGFIE)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0xE061B0", Offset = "0xE04BB0", VA = "0x180E061B0")]
	public static IECHECDALGG OCHPDIOAFKC(int ILOCEPPJPDO)
	{
		return default(IECHECDALGG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0xE061B0", Offset = "0xE04BB0", VA = "0x180E061B0")]
	public static int OCHPDIOAFKC(IECHECDALGG PKDIIGAGCEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x69CEAC0", Offset = "0x69CD4C0", VA = "0x1869CEAC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct BBFFIPHJEOF : IEquatable<BBFFIPHJEOF>, FHDNGCDLHNE
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly BBFFIPHJEOF BIHBLIMKEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CGKDLJPPHGG CHLKNJOLKLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0", Slot = "6")]
		get
		{
			return default(CGKDLJPPHGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IDPMJGIKLKJ JKDHBCECKGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(IDPMJGIKLKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public KOBPFMMEJOB LNBAMHJPONJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(KOBPFMMEJOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private MLMBOMBKNMD LLLFBOHOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x69C3720", Offset = "0x69C2120", VA = "0x1869C3720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public GameObject AOOABPFBFDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x69C4C00", Offset = "0x69C3600", VA = "0x1869C4C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public MHHMJHGEJDN INANABFMHEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x69C4A40", Offset = "0x69C3440", VA = "0x1869C4A40")]
		get
		{
			return default(MHHMJHGEJDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public COBMOEEAMHE KOEKGKKBOPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x69C4AE0", Offset = "0x69C34E0", VA = "0x1869C4AE0")]
		get
		{
			return default(COBMOEEAMHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public MMAKLLHOPJG CPOLNAEFCBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x69C4E10", Offset = "0x69C3810", VA = "0x1869C4E10")]
		get
		{
			return default(MMAKLLHOPJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool AGCCHNLKMGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x69C4DB0", Offset = "0x69C37B0", VA = "0x1869C4DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool PJPGIKOIKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x69C4950", Offset = "0x69C3350", VA = "0x1869C4950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool DGGJAINEBKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x69C4970", Offset = "0x69C3370", VA = "0x1869C4970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool IFDJIPJGOBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x69C4D90", Offset = "0x69C3790", VA = "0x1869C4D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool AHGJJCFIMDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x69C4DD0", Offset = "0x69C37D0", VA = "0x1869C4DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool BGMKBHDMCFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x69C4A20", Offset = "0x69C3420", VA = "0x1869C4A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool PEDEDDCOKBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x69C4840", Offset = "0x69C3240", VA = "0x1869C4840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool JPDHIFDCFJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x69C4EB0", Offset = "0x69C38B0", VA = "0x1869C4EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool KEHJEKFLECP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x69C4DF0", Offset = "0x69C37F0", VA = "0x1869C4DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public GNGKNBADJLC BMDBPKMKOMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(GNGKNBADJLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public LDCIAJNPNHD PFFOIBNIOIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(LDCIAJNPNHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public PIDAPKBNHCF KJMMHCACCOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(PIDAPKBNHCF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public DPNNBCCEDKP CFLNKNKGCHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(DPNNBCCEDKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public EDACOANBHBO PCKNFHJFAHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(EDACOANBHBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public COOKCLFJOFN HHBIPDJBLGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(COOKCLFJOFN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public PLPKBNHGIGB EKAOBEBOPEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(PLPKBNHGIGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public HCEKGBKALKE NJKFDCKDDIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(HCEKGBKALKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public IJPGCHJIOEO ALINNIKPLBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(IJPGCHJIOEO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public NNHGJCBDOGN BBLLMOOEJFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(NNHGJCBDOGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public FDFLHPMCPAA DHGKBAOEPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(FDFLHPMCPAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public JMIAMMFPJEF ECPPJCAAPBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(JMIAMMFPJEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool NOFBECBNIND
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x69C46B0", Offset = "0x69C30B0", VA = "0x1869C46B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool CBFALEGBMFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x69C4B80", Offset = "0x69C3580", VA = "0x1869C4B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool BAIJNHJMBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x69C4BC0", Offset = "0x69C35C0", VA = "0x1869C4BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	private bool FKOKAOJGBEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
	public BBFFIPHJEOF(CGKDLJPPHGG IDEOIAGJPJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x69C4050", Offset = "0x69C2A50", VA = "0x1869C4050")]
	public static bool OCHPDIOAFKC(BBFFIPHJEOF DBOBEHLEAAE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
	public static CGKDLJPPHGG OCHPDIOAFKC(BBFFIPHJEOF DBOBEHLEAAE)
	{
		return default(CGKDLJPPHGG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x69C3710", Offset = "0x69C2110", VA = "0x1869C3710")]
	public static bool IKJGJDJDJIH(BBFFIPHJEOF GDMICPKKGFK, BBFFIPHJEOF JCAJPPHEFGK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x69C4900", Offset = "0x69C3300", VA = "0x1869C4900")]
	public static bool BNNGOGJDCPO(BBFFIPHJEOF GDMICPKKGFK, BBFFIPHJEOF JCAJPPHEFGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x69C4990", Offset = "0x69C3390", VA = "0x1869C4990", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(BBFFIPHJEOF HENLEJBGFIE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
	public static BBFFIPHJEOF OCHPDIOAFKC(CGKDLJPPHGG MODIGHHCJLK)
	{
		return default(BBFFIPHJEOF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x69C4880", Offset = "0x69C3280", VA = "0x1869C4880")]
	public AFNMFMNDJHK BLNBCCLLEAD()
	{
		return default(AFNMFMNDJHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x69C4680", Offset = "0x69C3080", VA = "0x1869C4680")]
	public EKJJOHOMAMI AAFIHOHADJJ()
	{
		return default(EKJJOHOMAMI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x69C4EF0", Offset = "0x69C38F0", VA = "0x1869C4EF0")]
	public NBHDMDGMCDP PPGMEJLPGHL()
	{
		return default(NBHDMDGMCDP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x69C4920", Offset = "0x69C3320", VA = "0x1869C4920")]
	public EBIIDGPIAFB CAOLLGCIIAO()
	{
		return default(EBIIDGPIAFB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x69C47A0", Offset = "0x69C31A0", VA = "0x1869C47A0")]
	public void ADLOAHPGAPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x69C4F40", Offset = "0x69C3940", VA = "0x1869C4F40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct PLPKBNHGIGB : IEquatable<PLPKBNHGIGB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public CGKDLJPPHGG CHLKNJOLKLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(CGKDLJPPHGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private MLMBOMBKNMD LLLFBOHOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x69C3720", Offset = "0x69C2120", VA = "0x1869C3720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private JOHMDBMKIAN IBECFGKEHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x69D5890", Offset = "0x69D4290", VA = "0x1869D5890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private MJFANEGMEKK DHHFBEEJHPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x69D5920", Offset = "0x69D4320", VA = "0x1869D5920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool JEMNBCFGAJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x69D5490", Offset = "0x69D3E90", VA = "0x1869D5490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Guid HFHKDEJHIFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x69D5130", Offset = "0x69D3B30", VA = "0x1869D5130")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool PJICNFIMFBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x69D5400", Offset = "0x69D3E00", VA = "0x1869D5400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public Guid PDGNDMNFBHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x69D5640", Offset = "0x69D4040", VA = "0x1869D5640")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
	public PLPKBNHGIGB(CGKDLJPPHGG IDEOIAGJPJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x69C4050", Offset = "0x69C2A50", VA = "0x1869C4050")]
	public static bool OCHPDIOAFKC(PLPKBNHGIGB DBOBEHLEAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x69D5250", Offset = "0x69D3C50", VA = "0x1869D5250", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(PLPKBNHGIGB HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x69D57F0", Offset = "0x69D41F0", VA = "0x1869D57F0")]
	public bool KEIGPHEKCDJ([Out] Guid OLJKGANNLIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x69D5520", Offset = "0x69D3F20", VA = "0x1869D5520")]
	public void IKJGKEBDJAB(Guid EHIEOLDDJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x69D5090", Offset = "0x69D3A90", VA = "0x1869D5090")]
	public bool DNLLEGBCADG([Out] Guid OAAAKELMLJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x69D52E0", Offset = "0x69D3CE0", VA = "0x1869D52E0")]
	public void GDCCMJCEFBI(Guid EHIEOLDDJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x69D5760", Offset = "0x69D4160", VA = "0x1869D5760")]
	public void KBNKHKGAIPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct NBHDMDGMCDP : IEquatable<NBHDMDGMCDP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public CGKDLJPPHGG CHLKNJOLKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(CGKDLJPPHGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private MLMBOMBKNMD LLLFBOHOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x69C3720", Offset = "0x69C2120", VA = "0x1869C3720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private JOHMDBMKIAN IBECFGKEHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x69D2BC0", Offset = "0x69D15C0", VA = "0x1869D2BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private BINFGJEJBIM EHBEJGKPDGO
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x69D2B60", Offset = "0x69D1560", VA = "0x1869D2B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 AHCPDGPMPKM
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x69D24A0", Offset = "0x69D0EA0", VA = "0x1869D24A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public Quaternion DONGEGCCCPG
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x69D2840", Offset = "0x69D1240", VA = "0x1869D2840")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public BBFFIPHJEOF NIMEFNIFKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x69D2AD0", Offset = "0x69D14D0", VA = "0x1869D2AD0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
	public NBHDMDGMCDP(CGKDLJPPHGG IDEOIAGJPJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x69C4050", Offset = "0x69C2A50", VA = "0x1869C4050")]
	public static bool OCHPDIOAFKC(NBHDMDGMCDP DBOBEHLEAAE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
	public static CGKDLJPPHGG OCHPDIOAFKC(NBHDMDGMCDP DBOBEHLEAAE)
	{
		return default(CGKDLJPPHGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x69D25F0", Offset = "0x69D0FF0", VA = "0x1869D25F0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(NBHDMDGMCDP HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x69D2980", Offset = "0x69D1380", VA = "0x1869D2980")]
	public void IJIBKKAAPIO(Vector3 GLNEOPDBMFP, Quaternion NGGFFKDNCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x69D2C50", Offset = "0x69D1650", VA = "0x1869D2C50")]
	public void NIEHDLMFCFI(float GIFACOBMIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x69D2680", Offset = "0x69D1080", VA = "0x1869D2680")]
	public void FDGOAGMAAIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct AFNMFMNDJHK : IEquatable<AFNMFMNDJHK>
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly AFNMFMNDJHK BIHBLIMKEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public CGKDLJPPHGG CHLKNJOLKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(CGKDLJPPHGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public IDPMJGIKLKJ JKDHBCECKGL
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(IDPMJGIKLKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public KOBPFMMEJOB LNBAMHJPONJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(KOBPFMMEJOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private MLMBOMBKNMD LLLFBOHOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x69C3720", Offset = "0x69C2120", VA = "0x1869C3720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private JOHMDBMKIAN IBECFGKEHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x69C3A50", Offset = "0x69C2450", VA = "0x1869C3A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private DKDHMCENGAO MPELJGNPEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x69C3350", Offset = "0x69C1D50", VA = "0x1869C3350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public NAKBJJNCGAC ILBPFJBFMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x69C33B0", Offset = "0x69C1DB0", VA = "0x1869C33B0")]
		get
		{
			return default(NAKBJJNCGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public IEnumerable<BBFFIPHJEOF> BEPAPADOIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x69C2F40", Offset = "0x69C1940", VA = "0x1869C2F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public IEnumerable<BBFFIPHJEOF> MKPIFKACHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x69C3850", Offset = "0x69C2250", VA = "0x1869C3850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public int KPPAJCGFPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x69C4190", Offset = "0x69C2B90", VA = "0x1869C4190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public int CILKPJCFONC
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x69C34D0", Offset = "0x69C1ED0", VA = "0x1869C34D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public string JGFOABOCNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x69C3FA0", Offset = "0x69C29A0", VA = "0x1869C3FA0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x69C3D80", Offset = "0x69C2780", VA = "0x1869C3D80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public PMMKGLFIGMM DNBAGMPAEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x69C2EE0", Offset = "0x69C18E0", VA = "0x1869C2EE0")]
		get
		{
			return default(PMMKGLFIGMM);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x69C3D10", Offset = "0x69C2710", VA = "0x1869C3D10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public LJIPFCBIIIE JOAHHMKODGG
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x69C36B0", Offset = "0x69C20B0", VA = "0x1869C36B0")]
		get
		{
			return default(LJIPFCBIIIE);
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x69C4220", Offset = "0x69C2C20", VA = "0x1869C4220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public NFFMNGFGBJB ONPEMDGNAFB
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x69C3250", Offset = "0x69C1C50", VA = "0x1869C3250")]
		get
		{
			return default(NFFMNGFGBJB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x69C3980", Offset = "0x69C2380", VA = "0x1869C3980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public float DGCEFEPGMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x69C30B0", Offset = "0x69C1AB0", VA = "0x1869C30B0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x69C3640", Offset = "0x69C2040", VA = "0x1869C3640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool AJIPAOOPJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x69C37F0", Offset = "0x69C21F0", VA = "0x1869C37F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x69C31E0", Offset = "0x69C1BE0", VA = "0x1869C31E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool GEEBJJJAHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x69C3110", Offset = "0x69C1B10", VA = "0x1869C3110")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x69C3F30", Offset = "0x69C2930", VA = "0x1869C3F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool NPMKFKFFDGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x69C40D0", Offset = "0x69C2AD0", VA = "0x1869C40D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x69C3170", Offset = "0x69C1B70", VA = "0x1869C3170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool JOFOCPAFDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x69C4070", Offset = "0x69C2A70", VA = "0x1869C4070")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x69C3780", Offset = "0x69C2180", VA = "0x1869C3780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool FODAGPGIDKM
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x69C39F0", Offset = "0x69C23F0", VA = "0x1869C39F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x69C3E30", Offset = "0x69C2830", VA = "0x1869C3E30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool HEGJPAAOBDB
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x69C4130", Offset = "0x69C2B30", VA = "0x1869C4130")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x69C3EA0", Offset = "0x69C28A0", VA = "0x1869C3EA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
	public AFNMFMNDJHK(CGKDLJPPHGG IDEOIAGJPJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x69C4050", Offset = "0x69C2A50", VA = "0x1869C4050")]
	public static bool OCHPDIOAFKC(AFNMFMNDJHK DBOBEHLEAAE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x69C3710", Offset = "0x69C2110", VA = "0x1869C3710")]
	public static bool IKJGJDJDJIH(AFNMFMNDJHK GDMICPKKGFK, AFNMFMNDJHK JCAJPPHEFGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x69C32B0", Offset = "0x69C1CB0", VA = "0x1869C32B0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(AFNMFMNDJHK HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
	public static BBFFIPHJEOF OCHPDIOAFKC(AFNMFMNDJHK BBCPNLGGBMJ)
	{
		return default(BBFFIPHJEOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x69C3F10", Offset = "0x69C2910", VA = "0x1869C3F10")]
	public bool NGGIPEKKIHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x69C35D0", Offset = "0x69C1FD0", VA = "0x1869C35D0")]
	public bool IGLLBMFCKNM(FCGHOGLKKBI AGLFAEIOBAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x69C3550", Offset = "0x69C1F50", VA = "0x1869C3550")]
	public void HBIGJLCHDPI(FCGHOGLKKBI AGLFAEIOBAB, bool DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x69C3AE0", Offset = "0x69C24E0", VA = "0x1869C3AE0")]
	public NAKBJJNCGAC MGNKKKEJDMB(Allocator BPMIGAHMDHE)
	{
		return default(NAKBJJNCGAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x69C2B70", Offset = "0x69C1570", VA = "0x1869C2B70")]
	public void AKNEPGEODEE(AFNMFMNDJHK HENLEJBGFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x69C25C0", Offset = "0x69C0FC0", VA = "0x1869C25C0")]
	public void AGHNFKAIDMP(List<BBFFIPHJEOF> EADJMLPAEHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct DKLBPBIOOIB : IEquatable<DKLBPBIOOIB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x69C6D70", Offset = "0x69C5770", VA = "0x1869C6D70", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(DKLBPBIOOIB HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct LDCIAJNPNHD : IEquatable<LDCIAJNPNHD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private MLMBOMBKNMD LLLFBOHOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x69C3720", Offset = "0x69C2120", VA = "0x1869C3720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
	public LDCIAJNPNHD(CGKDLJPPHGG IDEOIAGJPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x69D1360", Offset = "0x69CFD60", VA = "0x1869D1360", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(LDCIAJNPNHD HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x69D1530", Offset = "0x69CFF30", VA = "0x1869D1530")]
	public void IKAGPDLIFEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x69D13F0", Offset = "0x69CFDF0", VA = "0x1869D13F0")]
	public void GDFDFKDJLJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x69D1490", Offset = "0x69CFE90", VA = "0x1869D1490")]
	public bool IHLBMBAFHII()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct KOBPFMMEJOB : IEquatable<KOBPFMMEJOB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public CGKDLJPPHGG CHLKNJOLKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(CGKDLJPPHGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private MLMBOMBKNMD LLLFBOHOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x69C3720", Offset = "0x69C2120", VA = "0x1869C3720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	private JOHMDBMKIAN IBECFGKEHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x69D0DE0", Offset = "0x69CF7E0", VA = "0x1869D0DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private DKDHMCENGAO MPELJGNPEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x69D0AD0", Offset = "0x69CF4D0", VA = "0x1869D0AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public CGKDLJPPHGG AADDCHGCAEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x69D0E70", Offset = "0x69CF870", VA = "0x1869D0E70")]
		get
		{
			return default(CGKDLJPPHGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public BBFFIPHJEOF LKABBOLBEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x69D0F00", Offset = "0x69CF900", VA = "0x1869D0F00")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public BBFFIPHJEOF CMJBHOFLJPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x69D09B0", Offset = "0x69CF3B0", VA = "0x1869D09B0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
	public KOBPFMMEJOB(CGKDLJPPHGG IDEOIAGJPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x69D0A40", Offset = "0x69CF440", VA = "0x1869D0A40", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(KOBPFMMEJOB HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x69D0880", Offset = "0x69CF280", VA = "0x1869D0880")]
	public bool APFFKENNKIB(BBFFIPHJEOF EMNGIAIDBPA, bool NPMCCHJPCKA = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x69D0BC0", Offset = "0x69CF5C0", VA = "0x1869D0BC0")]
	public bool JCEBKEDDHLJ(BBFFIPHJEOF EINNADCIGFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x69D0F90", Offset = "0x69CF990", VA = "0x1869D0F90")]
	private void OJBMNBGHMFO(BBFFIPHJEOF GLIKLMDFLAM, List<BBFFIPHJEOF> BGCALEMNHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x69D0B30", Offset = "0x69CF530", VA = "0x1869D0B30")]
	public AFNMFMNDJHK IHABHEGAGBB()
	{
		return default(AFNMFMNDJHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x69D0C60", Offset = "0x69CF660", VA = "0x1869D0C60")]
	public void MCMBCOJHIJE(List<BBFFIPHJEOF> AMFJIIICOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x69D0CC0", Offset = "0x69CF6C0", VA = "0x1869D0CC0")]
	public NativeArray<CGKDLJPPHGG> MEKOMNFJLAK()
	{
		return default(NativeArray<CGKDLJPPHGG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct GNGKNBADJLC : IEquatable<GNGKNBADJLC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public string BBAOPMPDOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x69CAB10", Offset = "0x69C9510", VA = "0x1869CAB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public string EBPMBJEFION
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x69CAA40", Offset = "0x69C9440", VA = "0x1869CAA40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private bool JHKCINIPMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x69CA5C0", Offset = "0x69C8FC0", VA = "0x1869CA5C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public string KEFOGGBJCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x69CA950", Offset = "0x69C9350", VA = "0x1869CA950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public string IMNJLMLCOEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x69CA700", Offset = "0x69C9100", VA = "0x1869CA700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public string IIABFFFAJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x69CA440", Offset = "0x69C8E40", VA = "0x1869CA440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
	public GNGKNBADJLC(CGKDLJPPHGG IDEOIAGJPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x69CA530", Offset = "0x69C8F30", VA = "0x1869CA530", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(GNGKNBADJLC HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct FDFLHPMCPAA : IEquatable<FDFLHPMCPAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private MLMBOMBKNMD LLLFBOHOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x69C3720", Offset = "0x69C2120", VA = "0x1869C3720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private JOHMDBMKIAN IBECFGKEHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x69CA160", Offset = "0x69C8B60", VA = "0x1869CA160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private GOGLKACKFLJ CJKIIFFEGJF
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x69CA100", Offset = "0x69C8B00", VA = "0x1869CA100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public AKMIHCNIDHN HOCPCICGDED
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x69C9990", Offset = "0x69C8390", VA = "0x1869C9990")]
		get
		{
			return default(AKMIHCNIDHN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x69C9BD0", Offset = "0x69C85D0", VA = "0x1869C9BD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public bool FHPPJFELKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x69CA280", Offset = "0x69C8C80", VA = "0x1869CA280")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x69C9FC0", Offset = "0x69C89C0", VA = "0x1869C9FC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public string[] KAPDLMAOKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x69C9F30", Offset = "0x69C8930", VA = "0x1869C9F30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x69CA310", Offset = "0x69C8D10", VA = "0x1869CA310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public string[] JBONFHJGEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x69C9CE0", Offset = "0x69C86E0", VA = "0x1869C9CE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x69C9E90", Offset = "0x69C8890", VA = "0x1869C9E90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public string[] KIJCICJABMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x69CA1F0", Offset = "0x69C8BF0", VA = "0x1869CA1F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x69CA060", Offset = "0x69C8A60", VA = "0x1869CA060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public string[] JBDJPCHFALP
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x69C9E00", Offset = "0x69C8800", VA = "0x1869C9E00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x69C9B30", Offset = "0x69C8530", VA = "0x1869C9B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
	public FDFLHPMCPAA(CGKDLJPPHGG IDEOIAGJPJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
	public static CGKDLJPPHGG OCHPDIOAFKC(FDFLHPMCPAA DBOBEHLEAAE)
	{
		return default(CGKDLJPPHGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x69C9D70", Offset = "0x69C8770", VA = "0x1869C9D70", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(FDFLHPMCPAA HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x69C9A90", Offset = "0x69C8490", VA = "0x1869C9A90")]
	public bool CHIOIJLAPJM(CGKDLJPPHGG HNOBHNILHCN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct EAJNBILFKAB : IEquatable<EAJNBILFKAB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x69C81A0", Offset = "0x69C6BA0", VA = "0x1869C81A0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(EAJNBILFKAB HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct PIDAPKBNHCF : IEquatable<PIDAPKBNHCF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
	public PIDAPKBNHCF(CGKDLJPPHGG IDEOIAGJPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x69D4EA0", Offset = "0x69D38A0", VA = "0x1869D4EA0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(PIDAPKBNHCF HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x69D4F30", Offset = "0x69D3930", VA = "0x1869D4F30")]
	public bool LNNBIIDFOLM([Out] Collider ICFPDPJMPEN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct EBIIDGPIAFB : IEquatable<EBIIDGPIAFB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public CGKDLJPPHGG CHLKNJOLKLI
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(CGKDLJPPHGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private MakerPenHeldDataWrapper GAFHKMKHKEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x69C8230", Offset = "0x69C6C30", VA = "0x1869C8230")]
		get
		{
			return default(MakerPenHeldDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public bool BPMLBGJGDFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x69C8320", Offset = "0x69C6D20", VA = "0x1869C8320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
	public EBIIDGPIAFB(CGKDLJPPHGG IDEOIAGJPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x69C8290", Offset = "0x69C6C90", VA = "0x1869C8290", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(EBIIDGPIAFB HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct IJPGCHJIOEO : IEquatable<IJPGCHJIOEO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public CGKDLJPPHGG CHLKNJOLKLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(CGKDLJPPHGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	private MLMBOMBKNMD LLLFBOHOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x69C3720", Offset = "0x69C2120", VA = "0x1869C3720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	private JOHMDBMKIAN IBECFGKEHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x69CEF40", Offset = "0x69CD940", VA = "0x1869CEF40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private BIHANNBMCFM ILEJACCCNHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x69CEFD0", Offset = "0x69CD9D0", VA = "0x1869CEFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
	public IJPGCHJIOEO(CGKDLJPPHGG IDEOIAGJPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x69CEE10", Offset = "0x69CD810", VA = "0x1869CEE10", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(IJPGCHJIOEO HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x69CEEA0", Offset = "0x69CD8A0", VA = "0x1869CEEA0")]
	public void IFFAKCNJECP(bool MAJJBPMFGGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct DPNNBCCEDKP : IEquatable<DPNNBCCEDKP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public CGKDLJPPHGG CHLKNJOLKLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(CGKDLJPPHGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private MLMBOMBKNMD LLLFBOHOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x69C3720", Offset = "0x69C2120", VA = "0x1869C3720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private JOHMDBMKIAN IBECFGKEHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x69C7C40", Offset = "0x69C6640", VA = "0x1869C7C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	private ObjectPolicyDataWrapper LDODODBJBIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x69C71C0", Offset = "0x69C5BC0", VA = "0x1869C71C0")]
		get
		{
			return default(ObjectPolicyDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private NavMeshGenerationDataWrapper BNDEHBANGBM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x69C8030", Offset = "0x69C6A30", VA = "0x1869C8030")]
		get
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public bool IAAALKFAKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x69C8160", Offset = "0x69C6B60", VA = "0x1869C8160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool BGAKNJEMIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x69C7430", Offset = "0x69C5E30", VA = "0x1869C7430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool LBIIEJCDKMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x69C80F0", Offset = "0x69C6AF0", VA = "0x1869C80F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool JPPFLBEOHIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x69C75B0", Offset = "0x69C5FB0", VA = "0x1869C75B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool CHMLHKNJBKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x69C7700", Offset = "0x69C6100", VA = "0x1869C7700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool EPEJLFCDDEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x69C7A20", Offset = "0x69C6420", VA = "0x1869C7A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public bool HKNIAAOPGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x69C7770", Offset = "0x69C6170", VA = "0x1869C7770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public bool BDDDCFANOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x69C7620", Offset = "0x69C6020", VA = "0x1869C7620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public bool ANFEPIGBEJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x69C72F0", Offset = "0x69C5CF0", VA = "0x1869C72F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public bool NIHAAGLCMKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x69C7280", Offset = "0x69C5C80", VA = "0x1869C7280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public bool OHPHIOEGEFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x69C79B0", Offset = "0x69C63B0", VA = "0x1869C79B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool EKADBONDIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x69C73C0", Offset = "0x69C5DC0", VA = "0x1869C73C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool BFEPKLNJBIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x69C7FC0", Offset = "0x69C69C0", VA = "0x1869C7FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool LFKKHHNDKMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x69C78E0", Offset = "0x69C62E0", VA = "0x1869C78E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool MAOPJDCADND
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x69C7B00", Offset = "0x69C6500", VA = "0x1869C7B00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x69C7690", Offset = "0x69C6090", VA = "0x1869C7690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public HNCJGHHAJIP DPHABFLBACH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x69C7360", Offset = "0x69C5D60", VA = "0x1869C7360")]
		get
		{
			return default(HNCJGHHAJIP);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x69C7A90", Offset = "0x69C6490", VA = "0x1869C7A90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool EEFJNHGJCME
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x69C7D90", Offset = "0x69C6790", VA = "0x1869C7D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public AFMKDICJKCC HAFNKEELIBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x69C8090", Offset = "0x69C6A90", VA = "0x1869C8090")]
		get
		{
			return default(AFMKDICJKCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool FEDPCFELCJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x69C7220", Offset = "0x69C5C20", VA = "0x1869C7220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Vector3 CPIBGFFEELP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x69C7CD0", Offset = "0x69C66D0", VA = "0x1869C7CD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Vector3 ODHFLKJPLPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x69C7110", Offset = "0x69C5B10", VA = "0x1869C7110")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public bool IOLCODHHACD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x69C77E0", Offset = "0x69C61E0", VA = "0x1869C77E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
	public DPNNBCCEDKP(CGKDLJPPHGG IDEOIAGJPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x69C7520", Offset = "0x69C5F20", VA = "0x1869C7520", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(DPNNBCCEDKP HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x69C7B60", Offset = "0x69C6560", VA = "0x1869C7B60")]
	public bool LPPPMPEAPLH(EKMICOLCDKG AGLFAEIOBAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x69C7940", Offset = "0x69C6340", VA = "0x1869C7940")]
	public bool HMNOKCHFLDJ(PKOJBPLDAHP AGLFAEIOBAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x69C74A0", Offset = "0x69C5EA0", VA = "0x1869C74A0")]
	public void EMFCPKOLFAL(PKOJBPLDAHP AGLFAEIOBAB, bool MOPHDJCHLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x69C7F60", Offset = "0x69C6960", VA = "0x1869C7F60")]
	public PKOJBPLDAHP OGJNBLMEPCD()
	{
		return default(PKOJBPLDAHP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x69C7BD0", Offset = "0x69C65D0", VA = "0x1869C7BD0")]
	public bool MAGBIGOBODN(PKOJBPLDAHP DBOBEHLEAAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct NNHGJCBDOGN : IEquatable<NNHGJCBDOGN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private MLMBOMBKNMD LLLFBOHOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x69C3720", Offset = "0x69C2120", VA = "0x1869C3720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private JOHMDBMKIAN IBECFGKEHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x69D4760", Offset = "0x69D3160", VA = "0x1869D4760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	private AIIOEGMABAH LHDJCLMHNLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x69D4140", Offset = "0x69D2B40", VA = "0x1869D4140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
	public NNHGJCBDOGN(CGKDLJPPHGG IDEOIAGJPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x69D41A0", Offset = "0x69D2BA0", VA = "0x1869D41A0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(NNHGJCBDOGN HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x69D3F60", Offset = "0x69D2960", VA = "0x1869D3F60")]
	public bool ALCKHNKMNIC(KGNHGFCDFGP IOHMFKLLMFN, List<BBFFIPHJEOF> EADJMLPAEHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x69D4650", Offset = "0x69D3050", VA = "0x1869D4650")]
	public int JKIMMNJLMFA(KGNHGFCDFGP IOHMFKLLMFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x69D4540", Offset = "0x69D2F40", VA = "0x1869D4540")]
	public void JGBOFHJKAGN(List<BBFFIPHJEOF> EADJMLPAEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x69D4360", Offset = "0x69D2D60", VA = "0x1869D4360")]
	public int IHJKALNGAGB(BBFFIPHJEOF PIBCCEDJCCL, KGNHGFCDFGP IOHMFKLLMFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x69D47F0", Offset = "0x69D31F0", VA = "0x1869D47F0")]
	public BBFFIPHJEOF MPEOCKAIFHM(int ILOCEPPJPDO, KGNHGFCDFGP IOHMFKLLMFN)
	{
		return default(BBFFIPHJEOF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x69D4230", Offset = "0x69D2C30", VA = "0x1869D4230")]
	public void HDJNADIOOKO(BBFFIPHJEOF PIBCCEDJCCL, KGNHGFCDFGP IOHMFKLLMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x69D4490", Offset = "0x69D2E90", VA = "0x1869D4490")]
	public bool IPJBHFEHBHF(BBFFIPHJEOF PIBCCEDJCCL, KGNHGFCDFGP IOHMFKLLMFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x69D4920", Offset = "0x69D3320", VA = "0x1869D4920")]
	public void NECMBBBANPF(KGNHGFCDFGP IOHMFKLLMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x69D4090", Offset = "0x69D2A90", VA = "0x1869D4090")]
	public bool AMFLIHJAKEB(BBFFIPHJEOF PIBCCEDJCCL, KGNHGFCDFGP IOHMFKLLMFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct COOKCLFJOFN : IEquatable<COOKCLFJOFN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public CGKDLJPPHGG CHLKNJOLKLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(CGKDLJPPHGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private MLMBOMBKNMD LLLFBOHOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x69C3720", Offset = "0x69C2120", VA = "0x1869C3720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private JOHMDBMKIAN IBECFGKEHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x69C6BC0", Offset = "0x69C55C0", VA = "0x1869C6BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
	public COOKCLFJOFN(CGKDLJPPHGG IDEOIAGJPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x69C6A10", Offset = "0x69C5410", VA = "0x1869C6A10", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(COOKCLFJOFN HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x69C6AA0", Offset = "0x69C54A0", VA = "0x1869C6AA0")]
	public void JCCFKGJGKMC(bool DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x69C6B30", Offset = "0x69C5530", VA = "0x1869C6B30")]
	public void JFAOLKCDEOP(bool DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x2935020", Offset = "0x2933A20", VA = "0x182935020")]
	public T DALANBKBNJJ<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct JMIAMMFPJEF : IEquatable<JMIAMMFPJEF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public CGKDLJPPHGG CHLKNJOLKLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(CGKDLJPPHGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	private MLMBOMBKNMD LLLFBOHOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x69C3720", Offset = "0x69C2120", VA = "0x1869C3720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private JOHMDBMKIAN IBECFGKEHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x69CF2F0", Offset = "0x69CDCF0", VA = "0x1869CF2F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private ADLGAMPPLJO AIEANDCEEKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x69CF170", Offset = "0x69CDB70", VA = "0x1869CF170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public bool ONJCAKIADEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x69CF380", Offset = "0x69CDD80", VA = "0x1869CF380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public bool JDIPCFLGFGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x69CF260", Offset = "0x69CDC60", VA = "0x1869CF260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
	public JMIAMMFPJEF(CGKDLJPPHGG IDEOIAGJPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x69CF1D0", Offset = "0x69CDBD0", VA = "0x1869CF1D0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(JMIAMMFPJEF HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public readonly struct AGDJDPCJPEG : IEquatable<AGDJDPCJPEG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x69C42B0", Offset = "0x69C2CB0", VA = "0x1869C42B0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(AGDJDPCJPEG HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct EDACOANBHBO : IEquatable<EDACOANBHBO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public CGKDLJPPHGG CHLKNJOLKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(CGKDLJPPHGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private MLMBOMBKNMD LLLFBOHOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x69C3720", Offset = "0x69C2120", VA = "0x1869C3720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private JOHMDBMKIAN IBECFGKEHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x69C8CA0", Offset = "0x69C76A0", VA = "0x1869C8CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private ELBDOCAEELF PMFMOOIGCGG
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x69C8390", Offset = "0x69C6D90", VA = "0x1869C8390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private CDPGOKKHBGC ADLAGBAKJJA
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x69C89C0", Offset = "0x69C73C0", VA = "0x1869C89C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool FKHPALFIJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x69C85C0", Offset = "0x69C6FC0", VA = "0x1869C85C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool JEOKGHIJGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x69C8480", Offset = "0x69C6E80", VA = "0x1869C8480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool EKEOJAIONFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x69C8780", Offset = "0x69C7180", VA = "0x1869C8780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool KEKJEJEIGID
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x69C8B60", Offset = "0x69C7560", VA = "0x1869C8B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool NGFKHFOBHKF
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x69C8A20", Offset = "0x69C7420", VA = "0x1869C8A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool JIAKBJOFCPN
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x69C83F0", Offset = "0x69C6DF0", VA = "0x1869C83F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool MBIANHDONNE
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x69C87B0", Offset = "0x69C71B0", VA = "0x1869C87B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public bool DGOKAIPFELO
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x69C8D30", Offset = "0x69C7730", VA = "0x1869C8D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
	public EDACOANBHBO(CGKDLJPPHGG IDEOIAGJPJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x69C4050", Offset = "0x69C2A50", VA = "0x1869C4050")]
	public static bool OCHPDIOAFKC(EDACOANBHBO DBOBEHLEAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x69C86F0", Offset = "0x69C70F0", VA = "0x1869C86F0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(EDACOANBHBO HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x69C8C30", Offset = "0x69C7630", VA = "0x1869C8C30")]
	public bool KIPICHFNFMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x69C8EA0", Offset = "0x69C78A0", VA = "0x1869C8EA0")]
	public BBFFIPHJEOF NJGHCFINGDO(BBFFIPHJEOF PIBCCEDJCCL)
	{
		return default(BBFFIPHJEOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x69C8F40", Offset = "0x69C7940", VA = "0x1869C8F40")]
	public CGKDLJPPHGG OBHIILBGEBM()
	{
		return default(CGKDLJPPHGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x69C8520", Offset = "0x69C6F20", VA = "0x1869C8520")]
	public bool CJFFHCBLIHK(CGKDLJPPHGG NOIEPEHDJCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x69C8650", Offset = "0x69C7050", VA = "0x1869C8650")]
	public bool DPICFAHNOGD(CGKDLJPPHGG PAKLCGMGMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x69C8A50", Offset = "0x69C7450", VA = "0x1869C8A50")]
	public bool JJDFNFJLEJG(CGKDLJPPHGG PIBCCEDJCCL, [Out] CGKDLJPPHGG NOIEPEHDJCI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct EKJJOHOMAMI : IEquatable<EKJJOHOMAMI>
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly EKJJOHOMAMI BIHBLIMKEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public CGKDLJPPHGG CHLKNJOLKLI
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(CGKDLJPPHGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public IDPMJGIKLKJ JKDHBCECKGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(IDPMJGIKLKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public KOBPFMMEJOB LNBAMHJPONJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(KOBPFMMEJOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private ShapeTypeDataWrapper NENLPKFPKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x69C96C0", Offset = "0x69C80C0", VA = "0x1869C96C0")]
		get
		{
			return default(ShapeTypeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public StandardRenderableVisualDataWrapper GCFMNFMADIF
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x69C9660", Offset = "0x69C8060", VA = "0x1869C9660")]
		get
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public PhysicsMaterialDataWrapper DDFMDAOBKGH
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x69C9860", Offset = "0x69C8260", VA = "0x1869C9860")]
		get
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public ShapeConfigDataWrapper OIIBHHAPOBN
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x69C94F0", Offset = "0x69C7EF0", VA = "0x1869C94F0")]
		get
		{
			return default(ShapeConfigDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public NHMKJJKKPJH BLHMHKPJMEO
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x69C97F0", Offset = "0x69C81F0", VA = "0x1869C97F0")]
		get
		{
			return default(NHMKJJKKPJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public DMOGMHMAFJH CFMBBGMFHHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x69C9720", Offset = "0x69C8120", VA = "0x1869C9720")]
		get
		{
			return default(DMOGMHMAFJH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x69C9050", Offset = "0x69C7A50", VA = "0x1869C9050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public OGAKFOBILNM ELGPMOBIFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x69C92A0", Offset = "0x69C7CA0", VA = "0x1869C92A0")]
		get
		{
			return default(OGAKFOBILNM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x69C9390", Offset = "0x69C7D90", VA = "0x1869C9390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public float BEENHBJFIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x69C91C0", Offset = "0x69C7BC0", VA = "0x1869C91C0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8180", VA = "0x1869C9780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public Vector3 BPFGADIHPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x69C90C0", Offset = "0x69C7AC0", VA = "0x1869C90C0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x69C95C0", Offset = "0x69C7FC0", VA = "0x1869C95C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float KPNLIGDHFNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x69C9550", Offset = "0x69C7F50", VA = "0x1869C9550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public LHBGCBDDANP PJOJBODAGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x69C9160", Offset = "0x69C7B60", VA = "0x1869C9160")]
		get
		{
			return default(LHBGCBDDANP);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x69C9400", Offset = "0x69C7E00", VA = "0x1869C9400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
	public EKJJOHOMAMI(CGKDLJPPHGG IDEOIAGJPJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x69C4050", Offset = "0x69C2A50", VA = "0x1869C4050")]
	public static bool OCHPDIOAFKC(EKJJOHOMAMI DBOBEHLEAAE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x69C4900", Offset = "0x69C3300", VA = "0x1869C4900")]
	public static bool BNNGOGJDCPO(EKJJOHOMAMI GDMICPKKGFK, EKJJOHOMAMI JCAJPPHEFGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x69C9300", Offset = "0x69C7D00", VA = "0x1869C9300", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(EKJJOHOMAMI HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x69C9470", Offset = "0x69C7E70", VA = "0x1869C9470")]
	public LABPBBECBLM HEFDOEBJFFO()
	{
		return default(LABPBBECBLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x69C9220", Offset = "0x69C7C20", VA = "0x1869C9220")]
	public NKHGAPNIFFN EGEHDKOEDIJ()
	{
		return default(NKHGAPNIFFN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct LABPBBECBLM : IEquatable<LABPBBECBLM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public CGKDLJPPHGG CHLKNJOLKLI
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(CGKDLJPPHGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public EKJJOHOMAMI KGLJAOMOKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(EKJJOHOMAMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private PrimitiveShapeDataWrapper AIMKHCNDHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x69D1300", Offset = "0x69CFD00", VA = "0x1869D1300")]
		get
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public KLOIDLPMPGK MPDKHEHLPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x69D12A0", Offset = "0x69CFCA0", VA = "0x1869D12A0")]
		get
		{
			return default(KLOIDLPMPGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
	public LABPBBECBLM(CGKDLJPPHGG IDEOIAGJPJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x69C4050", Offset = "0x69C2A50", VA = "0x1869C4050")]
	public static bool OCHPDIOAFKC(LABPBBECBLM DBOBEHLEAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x69D1210", Offset = "0x69CFC10", VA = "0x1869D1210", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(LABPBBECBLM HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DefaultMember("Item")]
public readonly struct NKHGAPNIFFN : IEquatable<NKHGAPNIFFN>
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly NKHGAPNIFFN BIHBLIMKEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public CGKDLJPPHGG CHLKNJOLKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(CGKDLJPPHGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public IDPMJGIKLKJ JKDHBCECKGL
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(IDPMJGIKLKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private MLMBOMBKNMD LLLFBOHOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x69C3720", Offset = "0x69C2120", VA = "0x1869C3720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	private JOHMDBMKIAN IBECFGKEHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x69D38F0", Offset = "0x69D22F0", VA = "0x1869D38F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	private JIDBIEEPAJD FPDIMFHCNLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x69D3460", Offset = "0x69D1E60", VA = "0x1869D3460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public EKJJOHOMAMI KGLJAOMOKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(EKJJOHOMAMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public BAOPFIECBOP PPHBAICGIFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x69D34C0", Offset = "0x69D1EC0", VA = "0x1869D34C0")]
		get
		{
			return default(BAOPFIECBOP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x69D35E0", Offset = "0x69D1FE0", VA = "0x1869D35E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public IEnumerable<HDFLAOKEEJJ> DLJCMKMIFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x69D3700", Offset = "0x69D2100", VA = "0x1869D3700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public HDFLAOKEEJJ PBAJKHBLIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x69D32C0", Offset = "0x69D1CC0", VA = "0x1869D32C0")]
		get
		{
			return default(HDFLAOKEEJJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x69D31A0", Offset = "0x69D1BA0", VA = "0x1869D31A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
	public NKHGAPNIFFN(CGKDLJPPHGG IDEOIAGJPJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x69C4050", Offset = "0x69C2A50", VA = "0x1869C4050")]
	public static bool OCHPDIOAFKC(NKHGAPNIFFN DBOBEHLEAAE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x69C3710", Offset = "0x69C2110", VA = "0x1869C3710")]
	public static bool IKJGJDJDJIH(NKHGAPNIFFN GDMICPKKGFK, NKHGAPNIFFN JCAJPPHEFGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x69D33D0", Offset = "0x69D1DD0", VA = "0x1869D33D0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(NKHGAPNIFFN HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x69D3BB0", Offset = "0x69D25B0", VA = "0x1869D3BB0")]
	public HDFLAOKEEJJ MKOPHGCIALK(float3? GLNEOPDBMFP, [Optional] quaternion? NGGFFKDNCFB, [Optional] Vector3? GIFACOBMIEN)
	{
		return default(HDFLAOKEEJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x69D3980", Offset = "0x69D2380", VA = "0x1869D3980")]
	public HDFLAOKEEJJ MIGHHNCLEFL(int ILOCEPPJPDO, float3? GLNEOPDBMFP, [Optional] quaternion? NGGFFKDNCFB, [Optional] Vector3? GIFACOBMIEN)
	{
		return default(HDFLAOKEEJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x69D3100", Offset = "0x69D1B00", VA = "0x1869D3100")]
	public void ANAMAJGCDBL(int ILOCEPPJPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x69D3230", Offset = "0x69D1C30", VA = "0x1869D3230")]
	public void EIMPLACCFNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct HDFLAOKEEJJ : IEquatable<HDFLAOKEEJJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public CGKDLJPPHGG CHLKNJOLKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(CGKDLJPPHGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public NKHGAPNIFFN KAACAJFJELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x69CBA10", Offset = "0x69CA410", VA = "0x1869CBA10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public float3 ILAABAGNPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x69CB990", Offset = "0x69CA390", VA = "0x1869CB990")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x69CBC60", Offset = "0x69CA660", VA = "0x1869CBC60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public quaternion MNPKHAFPMPA
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x69CBCE0", Offset = "0x69CA6E0", VA = "0x1869CBCE0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x69CBD60", Offset = "0x69CA760", VA = "0x1869CBD60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public float3 GDBBEBEENMC
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x69CBE30", Offset = "0x69CA830", VA = "0x1869CBE30")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x69CB910", Offset = "0x69CA310", VA = "0x1869CB910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public JCBPDGOJBKL CBOGPEPBHEI
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x69CBB00", Offset = "0x69CA500", VA = "0x1869CBB00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	private SplinePointParentDataWrapper DCMOOAIHHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x69CBAA0", Offset = "0x69CA4A0", VA = "0x1869CBAA0")]
		get
		{
			return default(SplinePointParentDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	private SplinePointPositionDataWrapper COICIKFPNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x69CBC00", Offset = "0x69CA600", VA = "0x1869CBC00")]
		get
		{
			return default(SplinePointPositionDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	private SplinePointRotationDataWrapper NCBCCIEGDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x69CB8B0", Offset = "0x69CA2B0", VA = "0x1869CB8B0")]
		get
		{
			return default(SplinePointRotationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	private SplinePointScaleDataWrapper NIEMGALAABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x69CBDD0", Offset = "0x69CA7D0", VA = "0x1869CBDD0")]
		get
		{
			return default(SplinePointScaleDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	private SplinePointOrderDataWrapper LCLLAAEOPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x69CB850", Offset = "0x69CA250", VA = "0x1869CB850")]
		get
		{
			return default(SplinePointOrderDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
	public HDFLAOKEEJJ(CGKDLJPPHGG IDEOIAGJPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x69CBB70", Offset = "0x69CA570", VA = "0x1869CBB70", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(HDFLAOKEEJJ HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x69CBA10", Offset = "0x69CA410", VA = "0x1869CBA10")]
	public void HMEENGOEFAI(NKHGAPNIFFN DBOBEHLEAAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct HCEKGBKALKE : IEquatable<HCEKGBKALKE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public CGKDLJPPHGG CHLKNJOLKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(CGKDLJPPHGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private MLMBOMBKNMD LLLFBOHOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x69C3720", Offset = "0x69C2120", VA = "0x1869C3720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private JOHMDBMKIAN IBECFGKEHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x69CB310", Offset = "0x69C9D10", VA = "0x1869CB310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	private EHBMJCNPHBB GIBJLAFEODJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x69CAE30", Offset = "0x69C9830", VA = "0x1869CAE30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	private ToolCleanupSettingsDataWrapper MOODGPFOKIC
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x69CADD0", Offset = "0x69C97D0", VA = "0x1869CADD0")]
		get
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool KKCGOKGINJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x69CB6C0", Offset = "0x69CA0C0", VA = "0x1869CB6C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x69CB440", Offset = "0x69C9E40", VA = "0x1869CB440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public bool MBDHCKBDOGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x69CB600", Offset = "0x69CA000", VA = "0x1869CB600")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x69CB050", Offset = "0x69C9A50", VA = "0x1869CB050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public float GOHEGIGDMCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x69CB660", Offset = "0x69CA060", VA = "0x1869CB660")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x69CAD60", Offset = "0x69C9760", VA = "0x1869CAD60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public bool KCHBGLHDCPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x69CB3A0", Offset = "0x69C9DA0", VA = "0x1869CB3A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
	public HCEKGBKALKE(CGKDLJPPHGG IDEOIAGJPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x69CAFC0", Offset = "0x69C99C0", VA = "0x1869CAFC0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(HCEKGBKALKE HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x69CAC20", Offset = "0x69C9620", VA = "0x1869CAC20")]
	public void AEEDFILDGKO(int BDGKMFGNNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x69CB200", Offset = "0x69C9C00", VA = "0x1869CB200")]
	public bool KMCDBIMBLOL([Out] int BDGKMFGNNGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x69CACC0", Offset = "0x69C96C0", VA = "0x1869CACC0")]
	public void BJIEIBHOGNI(bool FNGJIBDHOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x69CB0C0", Offset = "0x69C9AC0", VA = "0x1869CB0C0")]
	public void KJPDHFPKMDA(float LEDOIJNMLAF, float NIAEHLNEFFA, float AGMDBKPECIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x69CB4B0", Offset = "0x69C9EB0", VA = "0x1869CB4B0")]
	public void NOMKCFLKOGO(float3 KJLCKDCOGCP, quaternion LJJICBFONJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x69CB720", Offset = "0x69CA120", VA = "0x1869CB720")]
	public bool OPGGCBHFBEG([Out] float3 KJLCKDCOGCP, [Out] quaternion LJJICBFONJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x69CAE90", Offset = "0x69C9890", VA = "0x1869CAE90")]
	public bool EGNJLIJDDAB([Out] float MLMKHJKEILL, [Out] float FGKGHKHLGPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct IDPMJGIKLKJ : IEquatable<IDPMJGIKLKJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly CGKDLJPPHGG MODIGHHCJLK;

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public BBFFIPHJEOF OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(BBFFIPHJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public KOBPFMMEJOB LNBAMHJPONJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
		get
		{
			return default(KOBPFMMEJOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	private MLMBOMBKNMD LLLFBOHOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x69C3720", Offset = "0x69C2120", VA = "0x1869C3720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	private AAOHJGIHKFB BJONOBFCOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x69CDB20", Offset = "0x69CC520", VA = "0x1869CDB20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public bool OGGAIEKBHME
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x69CC980", Offset = "0x69CB380", VA = "0x1869CC980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public Vector3 ILAABAGNPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x69CC610", Offset = "0x69CB010", VA = "0x1869CC610")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x69CD910", Offset = "0x69CC310", VA = "0x1869CD910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public Quaternion MNPKHAFPMPA
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x69CDD30", Offset = "0x69CC730", VA = "0x1869CDD30")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x69CDE70", Offset = "0x69CC870", VA = "0x1869CDE70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public Vector3 GBLOKAEKGFI
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x69CCB20", Offset = "0x69CB520", VA = "0x1869CCB20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x69CE0C0", Offset = "0x69CCAC0", VA = "0x1869CE0C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public Quaternion OKAGPECGPFM
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x69CD9E0", Offset = "0x69CC3E0", VA = "0x1869CD9E0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x69CCFE0", Offset = "0x69CB9E0", VA = "0x1869CCFE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public float EADKAPOFDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x69CE490", Offset = "0x69CCE90", VA = "0x1869CE490")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x69CE010", Offset = "0x69CCA10", VA = "0x1869CE010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public float OKCMJJPFOML
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x69CE3F0", Offset = "0x69CCDF0", VA = "0x1869CE3F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public Vector3 GDBBEBEENMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x69CE2A0", Offset = "0x69CCCA0", VA = "0x1869CE2A0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x69CC450", Offset = "0x69CAE50", VA = "0x1869CC450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public Vector3 OALBDLEIGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x69CD1D0", Offset = "0x69CBBD0", VA = "0x1869CD1D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public Matrix4x4 IOCMOPLLPAH
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x69CC760", Offset = "0x69CB160", VA = "0x1869CC760")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x1A63640", Offset = "0x1A62040", VA = "0x181A63640")]
	public IDPMJGIKLKJ(CGKDLJPPHGG IDEOIAGJPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x69C3520", Offset = "0x69C1F20", VA = "0x1869C3520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x69CCA90", Offset = "0x69CB490", VA = "0x1869CCA90", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x69C3340", Offset = "0x69C1D40", VA = "0x1869C3340", Slot = "4")]
	public bool Equals(IDPMJGIKLKJ HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x69C4290", Offset = "0x69C2C90", VA = "0x1869C4290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x69CD180", Offset = "0x69CBB80", VA = "0x1869CD180")]
	public DJBABNHKILH HOMMACBPFCO()
	{
		return default(DJBABNHKILH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x69CE190", Offset = "0x69CCB90", VA = "0x1869CE190")]
	public void NCELLHBPDHG([Out] Matrix4x4 EEPHIDFBPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x69CD630", Offset = "0x69CC030", VA = "0x1869CD630")]
	public void JHJLIPKEGIO([Out] Vector3 MLKMNBOKEHF, [Out] Quaternion ALDKPMDBBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x69CD710", Offset = "0x69CC110", VA = "0x1869CD710")]
	public void JHJLIPKEGIO([Out] RigidTransform GCKGPMJLFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x69CE750", Offset = "0x69CD150", VA = "0x1869CE750")]
	public void OOBFIFMMBKM([Out] Vector3 MLKMNBOKEHF, [Out] Quaternion ALDKPMDBBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x69CE830", Offset = "0x69CD230", VA = "0x1869CE830")]
	public void OOBFIFMMBKM([Out] RigidTransform GCKGPMJLFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x69CD4B0", Offset = "0x69CBEB0", VA = "0x1869CD4B0")]
	public UniformTRS IOAENLEFFCA()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x69CD3F0", Offset = "0x69CBDF0", VA = "0x1869CD3F0")]
	public void IOAENLEFFCA([Out] UniformTRS CHLCJCBLBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x69CC520", Offset = "0x69CAF20", VA = "0x1869CC520")]
	public UniformTRS CPDNEBCPOEJ()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x69CC550", Offset = "0x69CAF50", VA = "0x1869CC550")]
	public void CPDNEBCPOEJ([Out] UniformTRS GCKGPMJLFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x69CC260", Offset = "0x69CAC60", VA = "0x1869CC260")]
	public Vector3 BAAABNMNCBE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x69CD0B0", Offset = "0x69CBAB0", VA = "0x1869CD0B0")]
	public void HLBINKAJEJE([In] Vector3 DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x69CDBE0", Offset = "0x69CC5E0", VA = "0x1869CDBE0")]
	public Vector3 LDBFDPHIGNO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x69CC190", Offset = "0x69CAB90", VA = "0x1869CC190")]
	public void ADJLDGDJKIF([In] Vector3 DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x69CCEA0", Offset = "0x69CB8A0", VA = "0x1869CCEA0")]
	public Quaternion GMMABOCFOMD()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x69CCD20", Offset = "0x69CB720", VA = "0x1869CCD20")]
	public void GEIDLINCCDL([In] Quaternion DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x69CC7A0", Offset = "0x69CB1A0", VA = "0x1869CC7A0")]
	public Quaternion DLIFOGLHGAC()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x69CC9C0", Offset = "0x69CB3C0", VA = "0x1869CC9C0")]
	public void EEOOONBOHDD([In] Quaternion DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x69CC3B0", Offset = "0x69CADB0", VA = "0x1869CC3B0")]
	public float CBKDFKPLLIM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x69CCC70", Offset = "0x69CB670", VA = "0x1869CCC70")]
	public void FEKCHGDIANO(float DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x69CC8E0", Offset = "0x69CB2E0", VA = "0x1869CC8E0")]
	public float EAPNBPLIAAF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x69CCDF0", Offset = "0x69CB7F0", VA = "0x1869CCDF0")]
	public void GFHAOMJCMBF(float DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x69CDF40", Offset = "0x69CC940", VA = "0x1869CDF40")]
	public void LPHJBLEFJMK([In] Vector3 DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x69CD4E0", Offset = "0x69CBEE0", VA = "0x1869CD4E0")]
	public Vector3 JENOJCMLGIM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x69CE8E0", Offset = "0x69CD2E0", VA = "0x1869CE8E0")]
	public void PJCEJGOBKNL([In] Vector3 DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x69CD7C0", Offset = "0x69CC1C0", VA = "0x1869CD7C0")]
	public Vector3 JIIDKNFNEOB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x69CD320", Offset = "0x69CBD20", VA = "0x1869CD320")]
	public void IKCPHHFMEIH([In] Vector3 DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x69CE530", Offset = "0x69CCF30", VA = "0x1869CE530")]
	public Vector3 OHLAGFBOEMG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x69CE680", Offset = "0x69CD080", VA = "0x1869CE680")]
	public void OJEDDJNFLML([In] Vector3 DBOBEHLEAAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class KHCBDDODGGB
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private struct AHNDHLGCJKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Guid JCMDDLFAGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public EOJFDIDEHCP PIOGPEAKDJF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private struct EOJFDIDEHCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int DBOBEHLEAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int CKEJLPAANKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int KLANLLGOPBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int KABGEDIMBAO;

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x69C98C0", Offset = "0x69C82C0", VA = "0x1869C98C0")]
		public bool EDOHCLDGNNL([Out] MHHMJHGEJDN DCKEDDMMHKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x69C9950", Offset = "0x69C8350", VA = "0x1869C9950")]
		public EOJFDIDEHCP(MHHMJHGEJDN DCKEDDMMHKE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x69CF820", Offset = "0x69CE220", VA = "0x1869CF820")]
	public static Guid DCBJIMAGOHP(this MHHMJHGEJDN DCKEDDMMHKE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x69CF8C0", Offset = "0x69CE2C0", VA = "0x1869CF8C0")]
	public static bool MJDKOLKEDLA(this Guid JCMDDLFAGEN, [Out] MHHMJHGEJDN DCKEDDMMHKE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal static class NPGKLGOHHEP
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B30", Offset = "0x69D3530", VA = "0x1869D4B30")]
	public static JOHMDBMKIAN IBECFGKEHBB(this CGKDLJPPHGG OBDGAAHPMCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x69D4BC0", Offset = "0x69D35C0", VA = "0x1869D4BC0")]
	public static GMHMJBINOFM NPPLAENOLGP(this CGKDLJPPHGG OBDGAAHPMCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x69D4A30", Offset = "0x69D3430", VA = "0x1869D4A30")]
	public static EntityManager DJLCCPNJBOC(this CGKDLJPPHGG OBDGAAHPMCD)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2C84650", Offset = "0x2C83050", VA = "0x182C84650")]
	public static T HHOCJKJBOAE<T>(this CGKDLJPPHGG OBDGAAHPMCD) where T : struct, KJIEOKOBPKO
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2C84390", Offset = "0x2C82D90", VA = "0x182C84390")]
	public static bool EGPFEHJINBI<T>(this CGKDLJPPHGG OBDGAAHPMCD) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2C842E0", Offset = "0x2C82CE0", VA = "0x182C842E0")]
	public static bool DMAPIBONCEC<T>(this CGKDLJPPHGG OBDGAAHPMCD) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface MJFANEGMEKK
{
	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PJICNFIMFBF(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JEMNBCFGAJP(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KEIGPHEKCDJ(CGKDLJPPHGG IDEOIAGJPJE, [Out] Guid OLJKGANNLIC);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid OHJJGCMILKJ(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IKJGKEBDJAB(CGKDLJPPHGG IDEOIAGJPJE, Guid OLJKGANNLIC);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DNLLEGBCADG(CGKDLJPPHGG IDEOIAGJPJE, [Out] Guid OAAAKELMLJG);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid IMPHALGFBIC(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GDCCMJCEFBI(CGKDLJPPHGG IDEOIAGJPJE, Guid OAAAKELMLJG);

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KBNKHKGAIPL(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task NONFBAPIFHL(CGKDLJPPHGG DPEMCBKEJDJ, CGKDLJPPHGG EMNGIAIDBPA);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface MAIPDJOCOLO
{
	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	Guid HNMPIAKFIFE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AHEBJMFHNFO(NativeList<Guid> FIPNJNHANPB, NativeList<Guid> MBEICLDDFIM, NativeList<FixedString64Bytes> GCPPKKNCFGG);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface ADLGAMPPLJO
{
	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GPOJNFHKEOM(List<CGKDLJPPHGG> AIEJOKIFDBP);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GPIFMPBMFGC(List<CGKDLJPPHGG> OHJCPCFAIHG);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LMPMGAEBEKL(CGKDLJPPHGG HEHHGMKHDHB);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ONJCAKIADEA(CGKDLJPPHGG HEHHGMKHDHB);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JDIPCFLGFGB(CGKDLJPPHGG HEHHGMKHDHB);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int LADJMAOMFFK(CGKDLJPPHGG HEHHGMKHDHB);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GKKAKMINPFP(CGKDLJPPHGG HEHHGMKHDHB, int IOILMCLNKLG);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CGKDLJPPHGG LDNINEIIJCA(CGKDLJPPHGG PNIJCGMHJBE);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int KOJMHIOJLEK(CGKDLJPPHGG PNIJCGMHJBE);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KPDNEDKEIJA(CGKDLJPPHGG PNIJCGMHJBE, int MELMJDPPPID);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int LGNLEJCLCKF(CGKDLJPPHGG PNIJCGMHJBE);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NDEENAAAMIF(CGKDLJPPHGG PNIJCGMHJBE, int NNKHFHJKDEK);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AKJPKFFOPNJ(CGKDLJPPHGG MODIGHHCJLK);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IFNACEOFLFI(CGKDLJPPHGG IDEOIAGJPJE, bool CCPJPIIEDBL);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AGMOCGLCGKF(CGKDLJPPHGG[] OGMGDOCHOGN, bool CCPJPIIEDBL);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface HGHBBJBCEPA
{
	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	IReadOnlyCollection<MOJDDLODPFG> OKAOJGDIKKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OIKJJGNNBNL(int NCLOOEMMHHO, [Out] MOJDDLODPFG GLLAODOIGMP);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MOJDDLODPFG KHAFNJGFMOF(Type ADDOHDGDFOD);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class FDPLJNADALD
{
	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x2B107F0", Offset = "0x2B0F1F0", VA = "0x182B107F0")]
	public static T HKJCGICNHEA<T>(this HGHBBJBCEPA DNAFLJMFMNB, Entity INJBCGOEBHC) where T : struct, KJIEOKOBPKO
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x2B108A0", Offset = "0x2B0F2A0", VA = "0x182B108A0")]
	public static MOJDDLODPFG KHAFNJGFMOF<T>(this HGHBBJBCEPA DNAFLJMFMNB) where T : struct, KJIEOKOBPKO
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface AEIHOJEFEIB
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MHHMJHGEJDN[] CKCAOGNIDLO(string CCMEKJGADHN, BBFFIPHJEOF KDPENMMMOAD, bool BEFOEIIKJLB = false);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IKBAHJJOFAI(string MGIDEFLKNJN, MHHMJHGEJDN[] LFGKPJIGHOO);
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface BINFGJEJBIM
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<CGKDLJPPHGG, CGKDLJPPHGG> DEHGPHEOFDB;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<CGKDLJPPHGG, CGKDLJPPHGG> NODBIOANEFP;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<CGKDLJPPHGG, CGKDLJPPHGG, CGKDLJPPHGG> FJFJDCIBLEN;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<CGKDLJPPHGG> DEBECHPNBPH;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IMJMFLKJDFE(CGKDLJPPHGG IDEOIAGJPJE, CGKDLJPPHGG LACHIMFDJHG);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CGKDLJPPHGG GJELGEDDKNM(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<CGKDLJPPHGG> MIGLFAAHNFB(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	CGKDLJPPHGG PKLLGGHLIGH(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IJIBKKAAPIO(CGKDLJPPHGG IDEOIAGJPJE, Vector3 BFKCBCOMOMP, Quaternion PPPPAEFEOEM);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NIEHDLMFCFI(CGKDLJPPHGG IDEOIAGJPJE, float MPJHHFFMCDO);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool IOIEEIADJOI(CGKDLJPPHGG IDEOIAGJPJE, [Out] CGKDLJPPHGG EMNGIAIDBPA);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool GHHMHMKJECF(CGKDLJPPHGG IDEOIAGJPJE, [Out] RigidTransform EIEGCAFMLOF);

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool AAPPGKLBOHN(CGKDLJPPHGG IDEOIAGJPJE, [Out] float KJPEEHNHADE);

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 OBDCAMNDOCE(NBHDMDGMCDP LEPKBPDKJAO);

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "18")]
	quaternion CFHLMMFAPDE(NBHDMDGMCDP LEPKBPDKJAO);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class ACKNIGKLFIK
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface INJHBGCDPEF
{
	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	object OKMJPCBJGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FHCLJBNNLCH(NAKBJJNCGAC OGMGDOCHOGN);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct GNBPHGGPEDB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly string CCMEKJGADHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly T JIEGAHKKHCA;

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x3D3DCD0", Offset = "0x3D3C6D0", VA = "0x183D3DCD0")]
	public GNBPHGGPEDB(T JIEGAHKKHCA, [Optional][CallerMemberName] string CCMEKJGADHN)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public static readonly GNBPHGGPEDB<int> HDJBJBCNBIB;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public enum MIOHHKBMILH
{
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class GBFFKIAEBPC
{
	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0xD66E30", Offset = "0xD65830", VA = "0x180D66E30")]
	public static bool EBJCKDHAGIB(this MIOHHKBMILH FAKDNFCMPPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0xD67030", Offset = "0xD65A30", VA = "0x180D67030")]
	public static bool EDMMBIHPJIA(this MIOHHKBMILH FAKDNFCMPPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x251F620", Offset = "0x251E020", VA = "0x18251F620")]
	public static bool LMLBPKAKADK(this MIOHHKBMILH FAKDNFCMPPB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface EFFPDPAJPII
{
	[Cpp2IlInjected.Token(Token = "0x17000180")]
	bool NLBHFAEJOMO
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface HIKHEIGECCE
{
	[Cpp2IlInjected.Token(Token = "0x17000181")]
	MIOHHKBMILH NKHHCFGBNGG
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	MIOHHKBMILH BGGBHBONJHL
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	MIOHHKBMILH KHMOMCMPNHI
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	MIOHHKBMILH HKMNEEIMBIP
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	MIOHHKBMILH JHFNOOPBGIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	MIOHHKBMILH KJMMHCACCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	MIOHHKBMILH MEKGAADIMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	MIOHHKBMILH EFELJNBECGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	MIOHHKBMILH IEKLAMNMBDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	MIOHHKBMILH GPCDHENEICG
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	MIOHHKBMILH PKACGMKLPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	MIOHHKBMILH IHOAPPKDMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	MIOHHKBMILH GGCOCLPANGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	MIOHHKBMILH BLDMEPDNONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	MIOHHKBMILH LOHDGPLJANC
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int AMGKFNFCLFC(GNBPHGGPEDB<int> FBFDHBHFJCB);
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface DKDHMCENGAO
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<BNOABJKHKBM> MKFCGPHPNHC;

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CGKDLJPPHGG HONEBCNANME(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IPLDEDBKBDJ(List<CGKDLJPPHGG> OHJCPCFAIHG);

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JCBPDGOJBKL BBEOJGGKCOI(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JCBPDGOJBKL POILCEKOMJJ(CGKDLJPPHGG EMNGIAIDBPA, CGKDLJPPHGG PPJABDMHAEE, bool FBHKHIOPIEK, CGKDLJPPHGG PIBCCEDJCCL);

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CGKDLJPPHGG ELIAGIAABGB(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool APFFKENNKIB(CGKDLJPPHGG IDEOIAGJPJE, CGKDLJPPHGG EMNGIAIDBPA, bool NPMCCHJPCKA);

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NCKKGJJJPDH(CGKDLJPPHGG IDEOIAGJPJE, CGKDLJPPHGG EMNGIAIDBPA);

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool DAHCHLAGPJK(CGKDLJPPHGG EPNNCAPHLAG, CGKDLJPPHGG KFOBIBOKNOC);

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int JBGCOEPEEEC(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NAKBJJNCGAC HMDOJIMIJBB(CGKDLJPPHGG MODIGHHCJLK);

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NativeArray<CGKDLJPPHGG> MEKOMNFJLAK(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool AFAAEGOBJFE(CGKDLJPPHGG IDEOIAGJPJE, CGKDLJPPHGG PGFBKHDGDFM);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<CGKDLJPPHGG> ICBGABJBFGG(CGKDLJPPHGG IDEOIAGJPJE, bool JDHKGKDJAIA = false);

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool JCEBKEDDHLJ(CGKDLJPPHGG IDEOIAGJPJE, CGKDLJPPHGG EINNADCIGFA);

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	CGKDLJPPHGG KHMFHLLCAPL(CGKDLJPPHGG PIBCCEDJCCL, CGKDLJPPHGG DBCDBEODKBO);

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool PKOCIIKGLNI(CGKDLJPPHGG PIBCCEDJCCL, CGKDLJPPHGG DBCDBEODKBO, [Out] CGKDLJPPHGG BMOLEHNIOND);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class IGJJABLFGLH
{
	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x69CED10", Offset = "0x69CD710", VA = "0x1869CED10")]
	public static List<CGKDLJPPHGG> IPLDEDBKBDJ(this DKDHMCENGAO FLNKLJIEOMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x69CECA0", Offset = "0x69CD6A0", VA = "0x1869CECA0")]
	public static bool EIMBCEIHIEG(this DKDHMCENGAO FLNKLJIEOMN, CGKDLJPPHGG IDEOIAGJPJE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface GOGLKACKFLJ
{
	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AKMIHCNIDHN HOEALDJEKPI(CGKDLJPPHGG HEHHGMKHDHB);

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DGHKEDMPFBF(CGKDLJPPHGG HEHHGMKHDHB, AKMIHCNIDHN MDIEOGGELPH);

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GMIJIKOONJJ(CGKDLJPPHGG HEHHGMKHDHB);

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GGFFOCEEOPK(CGKDLJPPHGG HEHHGMKHDHB, bool DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string[] NLFJLKEHEMM(CGKDLJPPHGG HEHHGMKHDHB);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EJECPANGKHL(CGKDLJPPHGG HEHHGMKHDHB, IEnumerable<string> JLAJKJKMAEO);

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string[] ACJELCOEAPM(CGKDLJPPHGG HEHHGMKHDHB);

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PEOLMOMEPPP(CGKDLJPPHGG HEHHGMKHDHB, IEnumerable<string> JLAJKJKMAEO);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "8")]
	string[] PAIOPNFKACG(CGKDLJPPHGG HEHHGMKHDHB);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EGJEIDFAMEG(CGKDLJPPHGG HEHHGMKHDHB, IEnumerable<string> JLAJKJKMAEO);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string[] ACLHLPGKMDP(CGKDLJPPHGG HEHHGMKHDHB);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CNIFLDBBGBH(CGKDLJPPHGG HEHHGMKHDHB, IEnumerable<string> JLAJKJKMAEO);

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool CHIOIJLAPJM(CGKDLJPPHGG HEHHGMKHDHB, CGKDLJPPHGG HNOBHNILHCN);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface JCJHGIBIOJF
{
	[Cpp2IlInjected.Token(Token = "0x17000190")]
	bool NABJAGBFNNM
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	bool IHAIDDLFOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface KEHIOHAECLL : OGNKFMGJMOH
{
	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HOALGMMEPOA(Entity INJBCGOEBHC, [Out] BAMGIBGLBLM AHCMMMOBCPP);

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NKAAOPMACHK(NativeArray<BAMGIBGLBLM> PAMHLPPBCHD, NativeArray<DKFILABEDKN> AFMGAJBHIFA);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PEMBEGFLLDH(BAMGIBGLBLM AHCMMMOBCPP);

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CNCKOOMGIPH(BAMGIBGLBLM AHCMMMOBCPP, [Out] Collider ICFPDPJMPEN);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface OGNKFMGJMOH
{
	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MAMIIPGIMLP([In] float3 FLANCHPFPCL, [In] float3 NMAFDGGPBKA, float APKOACGHEPL, Allocator BPMIGAHMDHE, [Out] NativeArray<Entity> MIIDIGABFDA);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface JJDFBCPONGI
{
	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MAMIIPGIMLP([In] float3 FLANCHPFPCL, [In] float3 NMAFDGGPBKA, float APKOACGHEPL, [Out] DICMICDMDLP OMOLADMCKGF, [Out] CGKDLJPPHGG EIACEIPENBI);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface ECKMGEEKPCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MAMIIPGIMLP([In] NativeArray<Entity> MIIDIGABFDA, [In] float3 FLANCHPFPCL, [In] float3 NMAFDGGPBKA, [In] NativeArray<DICMICDMDLP> CBOMCOAAKLN);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct BAMGIBGLBLM : JAPLOFGMOOP, IEquatable<BAMGIBGLBLM>
{
	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public int JCLKIAMNLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x92B7E0", Offset = "0x92A1E0", VA = "0x18092B7E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xA72650", Offset = "0xA71050", VA = "0x180A72650", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public int MOFBDCNAPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x253EE00", Offset = "0x253D800", VA = "0x18253EE00", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x5CABAD0", Offset = "0x5CAA4D0", VA = "0x185CABAD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x69C45E0", Offset = "0x69C2FE0", VA = "0x1869C45E0", Slot = "8")]
	public bool Equals(BAMGIBGLBLM HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x69C4630", Offset = "0x69C3030", VA = "0x1869C4630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct DICMICDMDLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float FOIKLHPMOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float3 GKJCNLBHEIK;
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface IAJLJHLDKNA
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface MLMBOMBKNMD
{
	[Cpp2IlInjected.Token(Token = "0x17000194")]
	JOHMDBMKIAN IBECFGKEHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	KLFMBFKCFME OKHOECLJEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<NAKBJJNCGAC, NativeArray<MMAKLLHOPJG>> AGOONMNHCPG;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<NAKBJJNCGAC> AHGGFKIKLCL;

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "6")]
	COBMOEEAMHE DPBLOIMOLDC(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MMAKLLHOPJG FKHPEEDHGLC(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PMAGAGNLFOG(MHHMJHGEJDN DCKEDDMMHKE, EDEPECMONIO BAOLDOMIMDG);

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OLOFJNBFLMK(MHHMJHGEJDN[] LFGKPJIGHOO, GameObject AOOABPFBFDN);

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BBFFIPHJEOF ADLOAHPGAPP(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NBMIHJDPIDJ(CGKDLJPPHGG IDEOIAGJPJE, [Out] Transform OFGHBAGNEDJ);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NOFBECBNIND(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JDBLMLOICCF(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CGKDLJPPHGG PLIHBEDDDLN(MHHMJHGEJDN DCKEDDMMHKE);

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool HAPFDCHLGLO(MHHMJHGEJDN DCKEDDMMHKE, [Out] CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	MHHMJHGEJDN GALHMCAPMFJ(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	NAKBJJNCGAC PLIHBEDDDLN(NativeArray<MHHMJHGEJDN> DCKEDDMMHKE, Allocator BPMIGAHMDHE);

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	NAKBJJNCGAC CHIJBPMMDDL(MMAKLLHOPJG ECCNNFLILMF, int OHELHAFFKFF, Allocator BPMIGAHMDHE);

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	NAKBJJNCGAC OJFCHBFEKFN(NativeArray<MHHMJHGEJDN> DCKEDDMMHKE, NativeArray<KEBONIAPHNN> MNHGIMGECKA, Allocator BPMIGAHMDHE);

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	MHHMJHGEJDN[] CKCAOGNIDLO(string MGIDEFLKNJN, BBFFIPHJEOF KDPENMMMOAD, bool BEFOEIIKJLB);

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IKBAHJJOFAI(string MGIDEFLKNJN, MHHMJHGEJDN[] LFGKPJIGHOO);

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "22")]
	BBFFIPHJEOF IKIFPCBCCLD(MMAKLLHOPJG ECCNNFLILMF, bool FOAGJIDDDIO);

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "23")]
	BBFFIPHJEOF IKIFPCBCCLD(MMAKLLHOPJG ECCNNFLILMF);

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "24")]
	BBFFIPHJEOF GEALJHKJLLI(MMAKLLHOPJG ECCNNFLILMF);

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "25")]
	BBFFIPHJEOF LAJBHJMNIHD(MMAKLLHOPJG ECCNNFLILMF);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "26")]
	BBFFIPHJEOF GAJPOLJJDAI(MHHMJHGEJDN DCKEDDMMHKE, MMAKLLHOPJG ECCNNFLILMF);

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(Slot = "27")]
	AFNMFMNDJHK DOBIKKHEKDL();

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "28")]
	NKHGAPNIFFN JPAIINOHOIE();

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "29")]
	LABPBBECBLM GKAEMBDJNIN(KLOIDLPMPGK CAFBMCAFFML);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void GDFDFKDJLJK(NAKBJJNCGAC OGMGDOCHOGN);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void IKAGPDLIFEB(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void LKHODBEABGA(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void GDFDFKDJLJK(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void NIAPODKPJNI(CGKDLJPPHGG OGMGDOCHOGN);

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool IHLBMBAFHII(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	NAKBJJNCGAC CKEEIKCNEBO(NAKBJJNCGAC BNKECCLLAMJ, Allocator BPMIGAHMDHE);

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool DBBOGLGLBCM(CGKDLJPPHGG IDEOIAGJPJE);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class BGFKKPBGKAN
{
	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x69C5560", Offset = "0x69C3F60", VA = "0x1869C5560")]
	public static void JDBLMLOICCF(this MLMBOMBKNMD HKKFANGDDDO, EDEPECMONIO BAOLDOMIMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x69C5640", Offset = "0x69C4040", VA = "0x1869C5640")]
	public static BBFFIPHJEOF JJCDGGHEPMF(this MLMBOMBKNMD HKKFANGDDDO, LocalId IDEOIAGJPJE)
	{
		return default(BBFFIPHJEOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x69C55E0", Offset = "0x69C3FE0", VA = "0x1869C55E0")]
	public static BBFFIPHJEOF JJCDGGHEPMF(this MLMBOMBKNMD HKKFANGDDDO, MHHMJHGEJDN DCKEDDMMHKE)
	{
		return default(BBFFIPHJEOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x69C5640", Offset = "0x69C4040", VA = "0x1869C5640")]
	public static CGKDLJPPHGG PLIHBEDDDLN(this MLMBOMBKNMD HKKFANGDDDO, LocalId IDEOIAGJPJE)
	{
		return default(CGKDLJPPHGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x69C54E0", Offset = "0x69C3EE0", VA = "0x1869C54E0")]
	public static MHHMJHGEJDN GALHMCAPMFJ(this MLMBOMBKNMD HKKFANGDDDO, LocalId IDEOIAGJPJE)
	{
		return default(MHHMJHGEJDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x69C5080", Offset = "0x69C3A80", VA = "0x1869C5080")]
	public static bool DBBOGLGLBCM(this MLMBOMBKNMD HKKFANGDDDO, MHHMJHGEJDN DCKEDDMMHKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x28BB0C0", Offset = "0x28B9AC0", VA = "0x1828BB0C0")]
	public static T EGIDIBFMGIG<T>(this MLMBOMBKNMD HKKFANGDDDO, LocalId IDEOIAGJPJE) where T : struct, KJIEOKOBPKO
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x69C50F0", Offset = "0x69C3AF0", VA = "0x1869C50F0")]
	public static AFNMFMNDJHK EBPLCOBEBGD(this MLMBOMBKNMD HKKFANGDDDO, RigidTransform CHLCJCBLBFB)
	{
		return default(AFNMFMNDJHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x69C53E0", Offset = "0x69C3DE0", VA = "0x1869C53E0")]
	public static LABPBBECBLM FJLJNJFIIJC(this MLMBOMBKNMD HKKFANGDDDO, KLOIDLPMPGK KCGKPNOBBIC, RigidTransform CHLCJCBLBFB)
	{
		return default(LABPBBECBLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x69C5670", Offset = "0x69C4070", VA = "0x1869C5670")]
	public static NKHGAPNIFFN LLOPFMPGEEG(this MLMBOMBKNMD HKKFANGDDDO, RigidTransform CHLCJCBLBFB)
	{
		return default(NKHGAPNIFFN);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x69C51E0", Offset = "0x69C3BE0", VA = "0x1869C51E0")]
	private static void EFBNPPONENL(BBFFIPHJEOF PKMMOOPCMLB, RigidTransform CHLCJCBLBFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface ELBDOCAEELF
{
	[Cpp2IlInjected.Token(Token = "0x17000196")]
	bool CIJKDOANDDK
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	CGKDLJPPHGG MDKJPBPNADP
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	BBFFIPHJEOF KIPFGBCNHFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event KFCACPMGEJD KNACKDBFGAM;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CGKDLJPPHGG KHMFHLLCAPL(CGKDLJPPHGG PIBCCEDJCCL, CGKDLJPPHGG DBCDBEODKBO);

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PKOCIIKGLNI(CGKDLJPPHGG PIBCCEDJCCL, CGKDLJPPHGG DBCDBEODKBO, [Out] CGKDLJPPHGG BMOLEHNIOND);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FNMLKMBOFIJ();

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ODMJPOFIPCK();

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FKHPALFIJII(CGKDLJPPHGG PIBCCEDJCCL);

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool JIAKBJOFCPN(CGKDLJPPHGG PIBCCEDJCCL);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public delegate void KFCACPMGEJD(BBFFIPHJEOF DHDEAPDALCL, BBFFIPHJEOF AIJDCMGGHJD);
[Cpp2IlInjected.Token(Token = "0x2000089")]
public static class DLKNEDCMABK
{
	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x69C6E00", Offset = "0x69C5800", VA = "0x1869C6E00")]
	public static bool EJBAANPJLMI(this ELBDOCAEELF OJLEJJHLGEL, BBFFIPHJEOF PIBCCEDJCCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x69C6E50", Offset = "0x69C5850", VA = "0x1869C6E50")]
	public static bool IHABFBPFDDJ(this ELBDOCAEELF OJLEJJHLGEL, CGKDLJPPHGG PIBCCEDJCCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x69C6F30", Offset = "0x69C5930", VA = "0x1869C6F30")]
	public static bool KEKJEJEIGID(this ELBDOCAEELF OJLEJJHLGEL, CGKDLJPPHGG PIBCCEDJCCL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface AIIOEGMABAH
{
	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ALCKHNKMNIC(BBFFIPHJEOF PKMMOOPCMLB, KGNHGFCDFGP IOHMFKLLMFN, List<BBFFIPHJEOF> EADJMLPAEHB);

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int JKIMMNJLMFA(BBFFIPHJEOF PKMMOOPCMLB, KGNHGFCDFGP IOHMFKLLMFN);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JGBOFHJKAGN(BBFFIPHJEOF PKMMOOPCMLB, List<BBFFIPHJEOF> EADJMLPAEHB);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IHJKALNGAGB(BBFFIPHJEOF BDGKMFGNNGD, BBFFIPHJEOF PIBCCEDJCCL, KGNHGFCDFGP IOHMFKLLMFN);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BBFFIPHJEOF MPEOCKAIFHM(BBFFIPHJEOF BDGKMFGNNGD, int ILOCEPPJPDO, KGNHGFCDFGP IOHMFKLLMFN);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HDJNADIOOKO(BBFFIPHJEOF BDGKMFGNNGD, BBFFIPHJEOF PIBCCEDJCCL, KGNHGFCDFGP IOHMFKLLMFN);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool IPJBHFEHBHF(BBFFIPHJEOF BDGKMFGNNGD, BBFFIPHJEOF PIBCCEDJCCL, KGNHGFCDFGP IOHMFKLLMFN);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NECMBBBANPF(BBFFIPHJEOF BDGKMFGNNGD, KGNHGFCDFGP IOHMFKLLMFN);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool AMFLIHJAKEB(BBFFIPHJEOF BDGKMFGNNGD, BBFFIPHJEOF PIBCCEDJCCL, KGNHGFCDFGP IOHMFKLLMFN);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ILELJKHFOED(Entity BDGKMFGNNGD, Entity PIBCCEDJCCL, KGNHGFCDFGP IOHMFKLLMFN);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PHOPNLKIMCJ(Entity BDGKMFGNNGD, KGNHGFCDFGP IOHMFKLLMFN);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface CADJGGCMIBP
{
	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EFGFOGJHPML(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KCHMAHAHHBM(CGKDLJPPHGG IDEOIAGJPJE, Transform OFGHBAGNEDJ);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface CDPGOKKHBGC
{
	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CJFFHCBLIHK(CGKDLJPPHGG PIBCCEDJCCL, CGKDLJPPHGG NOIEPEHDJCI);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DPICFAHNOGD(CGKDLJPPHGG PIBCCEDJCCL, CGKDLJPPHGG PAKLCGMGMKC);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JJDFNFJLEJG(CGKDLJPPHGG PIBCCEDJCCL, [Out] CGKDLJPPHGG CGEJBDIELEI);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface EIBKPAKINKJ
{
	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JCCFKGJGKMC(CGKDLJPPHGG MODIGHHCJLK, bool DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFAOLKCDEOP(CGKDLJPPHGG MODIGHHCJLK, bool DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NOPEJDCGLNC(CGKDLJPPHGG MODIGHHCJLK, int DBOBEHLEAAE);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface JIDBIEEPAJD
{
	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<CGKDLJPPHGG> BABNEEOAEEB(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CGKDLJPPHGG BFOPLMNMGAH(CGKDLJPPHGG IDEOIAGJPJE, int ILOCEPPJPDO);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int HBNGMICIKHG(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BAOPFIECBOP PMCGAIPAKAD(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AAEGODJACFO(CGKDLJPPHGG IDEOIAGJPJE, BAOPFIECBOP FFNDHFNNMLH);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CGKDLJPPHGG IGIOPGEPCMC(CGKDLJPPHGG IDEOIAGJPJE, [Optional] float3? GLNEOPDBMFP, [Optional] quaternion? NGGFFKDNCFB, [Optional] float3? GIFACOBMIEN);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CGKDLJPPHGG CEFANACKJOC(CGKDLJPPHGG IDEOIAGJPJE, int ILOCEPPJPDO, [Optional] float3? GLNEOPDBMFP, [Optional] quaternion? NGGFFKDNCFB, [Optional] float3? GIFACOBMIEN);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BHGONEPLCIB(CGKDLJPPHGG IDEOIAGJPJE, int ILOCEPPJPDO);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void APHCEGLDOCN(CGKDLJPPHGG IDEOIAGJPJE);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface PAJELBIKBJD
{
	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BIIBHLBDIIN();

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOEHMLACBAD();

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AAJAKNOOJFA();

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BGCMMAEBPHO();

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OGOEAFPNGGB();

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KFHEHPKOBBG();

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JAFGJAEGKJN();

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LAGHDGPJKML();

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LCAEMCMJBKD();

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CKNCEABDLHK();

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LLEGFNHOHNH();

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DCDHOAFLAEO();

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MHADBMOMNPI();
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface EHBMJCNPHBB
{
	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KMCDBIMBLOL(CGKDLJPPHGG PIBCCEDJCCL, [Out] int BDGKMFGNNGD);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEEDFILDGKO(CGKDLJPPHGG PIBCCEDJCCL, int BDGKMFGNNGD);

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AGNCBEHBJBF(CGKDLJPPHGG PIBCCEDJCCL, bool MOPHDJCHLDM);

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BJIEIBHOGNI(CGKDLJPPHGG PIBCCEDJCCL, bool FNGJIBDHOBN);

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KJPDHFPKMDA(CGKDLJPPHGG PIBCCEDJCCL, float LEDOIJNMLAF, float NIAEHLNEFFA, float AGMDBKPECIE);

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EGNJLIJDDAB(CGKDLJPPHGG IDEOIAGJPJE, [Out] float NIAEHLNEFFA, [Out] float AGMDBKPECIE);

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NOMKCFLKOGO(CGKDLJPPHGG PIBCCEDJCCL, float3 GLNEOPDBMFP, quaternion NGGFFKDNCFB);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OPGGCBHFBEG(CGKDLJPPHGG PIBCCEDJCCL, [Out] float3 GLNEOPDBMFP, [Out] quaternion NGGFFKDNCFB);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface AAOHJGIHKFB
{
	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOMLAKKDAAH(Entity INJBCGOEBHC);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HLBINKAJEJE(Entity INJBCGOEBHC, [In] float3 DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 BAAABNMNCBE(Entity INJBCGOEBHC);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GEIDLINCCDL(Entity INJBCGOEBHC, [In] quaternion DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion GMMABOCFOMD(Entity INJBCGOEBHC);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LAHOPDLNMII(Entity INJBCGOEBHC, [In] float3 GLNEOPDBMFP, [In] quaternion NGGFFKDNCFB);

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JHJLIPKEGIO(Entity INJBCGOEBHC, [Out] float3 GLNEOPDBMFP, [Out] quaternion NGGFFKDNCFB);

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JHJLIPKEGIO(Entity INJBCGOEBHC, [Out] RigidTransform CBGNPIBBGNC);

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OOBFIFMMBKM(Entity INJBCGOEBHC, [Out] float3 GLNEOPDBMFP, [Out] quaternion NGGFFKDNCFB);

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OOBFIFMMBKM(Entity INJBCGOEBHC, [Out] RigidTransform CBGNPIBBGNC);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float3 KOIOGBGCCIE(Entity INJBCGOEBHC);

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LPHJBLEFJMK(Entity INJBCGOEBHC, [In] float3 DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FEKCHGDIANO(Entity INJBCGOEBHC, float DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float CBKDFKPLLIM(Entity INJBCGOEBHC);

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IKCPHHFMEIH(Entity INJBCGOEBHC, [In] float3 DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 JIIDKNFNEOB(Entity INJBCGOEBHC);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ADJLDGDJKIF(Entity INJBCGOEBHC, [In] float3 DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 LDBFDPHIGNO(Entity INJBCGOEBHC);

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EEOOONBOHDD(Entity INJBCGOEBHC, [In] quaternion DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "19")]
	quaternion DLIFOGLHGAC(Entity INJBCGOEBHC);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 JENOJCMLGIM(Entity INJBCGOEBHC);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void PJCEJGOBKNL(Entity INJBCGOEBHC, [In] float3 DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GFHAOMJCMBF(Entity INJBCGOEBHC, float DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float EAPNBPLIAAF(Entity INJBCGOEBHC);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OJEDDJNFLML(Entity INJBCGOEBHC, [In] float3 DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float3 OHLAGFBOEMG(Entity INJBCGOEBHC);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GPOHCMNEECH(Entity INJBCGOEBHC, [Out] float4x4 EEPHIDFBPBM);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void CMICHGNJLID(Entity INJBCGOEBHC, [In] float4x4 EEPHIDFBPBM);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void ENALDGLNKEO(Entity INJBCGOEBHC, [Out] float4x4 EEPHIDFBPBM);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool NBMIHJDPIDJ(Entity INJBCGOEBHC, [Out] Transform OFGHBAGNEDJ);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void IMJJFDCLDGJ(Entity INJBCGOEBHC);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void OCGDGJNJBOJ(Entity INJBCGOEBHC, Entity KBPJFANAICH, Entity AEJHEFECOBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class ECCADDILMBO
{
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface NCCGCHJNPFA
{
	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHAIFJMFNMP(bool MHOIIAGFKCN);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface JKEKJPDCKGC
{
	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFDKPKNIOEE(CGKDLJPPHGG HEHHGMKHDHB, IEnumerable<string> JLAJKJKMAEO);

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MBNBNPEKDHA(CGKDLJPPHGG HEHHGMKHDHB, IEnumerable<string> JLAJKJKMAEO);

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HLBNPBMHIHB(CGKDLJPPHGG HEHHGMKHDHB, params string[] JLAJKJKMAEO);

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CJOMBGAOJCK(CGKDLJPPHGG HEHHGMKHDHB, params string[] JLAJKJKMAEO);

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OPIHPALDFAM(CGKDLJPPHGG HEHHGMKHDHB, params string[] JLAJKJKMAEO);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KKMGKEIDOOC(CGKDLJPPHGG HEHHGMKHDHB, params string[] JLAJKJKMAEO);

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int PMJOLENNHNB(CGKDLJPPHGG HEHHGMKHDHB);

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int HKNNNNGOJNJ(CGKDLJPPHGG HEHHGMKHDHB);

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JJBCJGPDDPB(CGKDLJPPHGG HEHHGMKHDHB, ICollection<string> JGPMKECJHJJ);

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BGJBAJKADPP(CGKDLJPPHGG HEHHGMKHDHB, ICollection<string> JGPMKECJHJJ);

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool IMNDEBPECCJ(CGKDLJPPHGG HEHHGMKHDHB, string INNDIMHALJD);

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LIGOICCLJBG(string INNDIMHALJD, PNCPKFJNNGO NEDOBFLNOCA);

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KCAKFCACIEF(string INNDIMHALJD, PNCPKFJNNGO NEDOBFLNOCA);

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool HJPNKIIEPGA();

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FGCBLEKBOPD(IEnumerable<string> JLAJKJKMAEO);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface JGMBOJJPBIC
{
	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World AKHHCLPALJD(string BBKDMFNILBF = "Main");

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World GAAEHCJOFNI(string BBKDMFNILBF = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World OLOHIAJPJBK(string BBKDMFNILBF = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World DNLMENFFAIM(string BBKDMFNILBF = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface GMHMJBINOFM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000199")]
	World DJPPMGBABJA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	World EEJBELFFELK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	EntityManager DJLCCPNJBOC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	bool FIGHPIBDBNL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase EKDEEGDDOEC(Type ADDOHDGDFOD);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class FIMNMAGCJDM
{
	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x69CA3B0", Offset = "0x69C8DB0", VA = "0x1869CA3B0")]
	public static ComponentSystemBase HBJKIOGDKLL(this World LHKJIBFFKNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x2B12FD0", Offset = "0x2B119D0", VA = "0x182B12FD0")]
	public static T EKDEEGDDOEC<T>(this GMHMJBINOFM PPINPNLJFFC) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface FGJBIHMKKHL
{
	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGKECAPGOPO(NativeListAsync<Entity> DOBCFLKBFGL);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PCKMOLDCMJK(JBGCEOCMBEP CKOIPOAPCOP);

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OOFLCHGNCBJ(NativeListAsync<Entity> ECFAKFCIIOC, bool IDPHLFABLIO);

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HFLIONPEODG();
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface HHGHIFLNHHH
{
	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EEODGGGFHCF(Collider ICFPDPJMPEN, [Out] EOGELEDJNHE HKLHOMJCKLP);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface IAFJOGAAGBA
{
	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MFHJIAKNHIJ(CGKDLJPPHGG IDEOIAGJPJE, [Out] Collider ICFPDPJMPEN);

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject JNOCCEJEIDD(CGKDLJPPHGG JDFKOJGEPAL, GameObject GJEJJJDCBIG, Vector3 KHAKKIFNDKN, Quaternion IMKGMPHEJPJ);

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LEPHMKJJPPE(GameObject ICFPDPJMPEN);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider MGADNPPIMCD<TCollider>(GameObject KCMOABFCNGE) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BENNAIFGDNO(Collider ICFPDPJMPEN);

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject EJPCNAAAFEA<TCollider>(string CCMEKJGADHN) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public enum MLPIHNHDMAD
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
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface BADJCDMENDD
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public struct CBKNAOHIEOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int FMHLFHNOEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public GameObject GJEJJJDCBIG;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFJKGMLNIFG(CGKDLJPPHGG IDEOIAGJPJE, PMMKGLFIGMM MOIPAPMGMIC, bool KCDGNGOGIPO, FCGHOGLKKBI BIBIENNBELB);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KBEPACJNIED(CGKDLJPPHGG IDEOIAGJPJE, PMMKGLFIGMM MOIPAPMGMIC, bool KCDGNGOGIPO, bool EOCNJPALMOC, bool OOELDAAEBGE);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CDDGDDGILIM EPNJMDFCJAI(CGKDLJPPHGG GPKGNPPAAHE, List<CGKDLJPPHGG> DLPALLJDNPO);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HPOCJGPIMJE(GameObject GEELEOODPJJ, GameObject PJKNNOMKMAC);

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NCLIIMLDBGB(GameObject GEELEOODPJJ, [In] PAIPBEOLENN<GameObject> FMDJHCOCODP);

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ECCEGGCHJLP(GameObject PJKNNOMKMAC);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T MGADNPPIMCD<T>(GameObject KCMOABFCNGE) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BENNAIFGDNO(Collider ICFPDPJMPEN);

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JFMBJNFHCFA(NAKBJJNCGAC IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BOJKIELEAOK(NAKBJJNCGAC IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GameObject NKCEBLPMMIJ<T>(string CCMEKJGADHN) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FLFLNJCOBHC(Collider ICFPDPJMPEN, [Out] CGKDLJPPHGG BDGKMFGNNGD);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool BHOLPNHLHJD(CGKDLJPPHGG IDEOIAGJPJE, [Out] EOGELEDJNHE HKLHOMJCKLP);

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<MLPIHNHDMAD> MJCABGDDKMO(Allocator BPMIGAHMDHE = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Mesh[] KELMCMCEJGJ();

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int JMGPEHBKCBK(PMMKGLFIGMM MOIPAPMGMIC);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string GFHDNNPDOPM(PMMKGLFIGMM MOIPAPMGMIC);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface HIEHILOCJFH
{
	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HLDFMJHFEAO(CGKDLJPPHGG IDEOIAGJPJE, CGKDLJPPHGG DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IDFAGPAKMCH(CGKDLJPPHGG IDEOIAGJPJE, CGKDLJPPHGG DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int JBGCOEPEEEC(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CGKDLJPPHGG OEKONKEJMOF(CGKDLJPPHGG IDEOIAGJPJE, int ILOCEPPJPDO);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NAKBJJNCGAC GLGFEGDEKCF(CGKDLJPPHGG IDEOIAGJPJE, Allocator BPMIGAHMDHE = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DNHKHLDIPPM(CGKDLJPPHGG IDEOIAGJPJE, object JCIFCENKMKP, CGKDLJPPHGG DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AKEHBIJEMGE(CGKDLJPPHGG IDEOIAGJPJE, object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MKBFCCMLLBD(CGKDLJPPHGG IDEOIAGJPJE, [Out] CGKDLJPPHGG DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NPJCBMHBMMB(CGKDLJPPHGG IDEOIAGJPJE, float3 DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool NFNCNDEGAAL(CGKDLJPPHGG IDEOIAGJPJE, [Out] float3 DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EDBOOGLLDMH(CGKDLJPPHGG IDEOIAGJPJE, float3 DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LGGDCLJAGAP(CGKDLJPPHGG IDEOIAGJPJE, [Out] float3 DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PAHAOAGDGHK(CGKDLJPPHGG IDEOIAGJPJE, (Quaternion rot, Vector3 moments) IIFLMEOHBOK);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool LLJLPKKCLNO(CGKDLJPPHGG IDEOIAGJPJE, [Out] quaternion CMAJCEDKDLM, [Out] float3 AJHJPODBFNI);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LEKKOCOGJAF(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 JAMEEDDAAKJ(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 JHMEKCANNDO(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BJIEFCFFEDD(CGKDLJPPHGG IDEOIAGJPJE, float3 DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BOKFEJFHNGJ(CGKDLJPPHGG IDEOIAGJPJE, float3 DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float AENBJPLBCPD(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float DNHAOJDAIFJ(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GCJHJGFJGFM(CGKDLJPPHGG IDEOIAGJPJE, float DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KJICEJGEGDM(CGKDLJPPHGG IDEOIAGJPJE, float DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode ABHIAKBBBFH(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GPNGPPCIMDA(CGKDLJPPHGG IDEOIAGJPJE, CollisionDetectionMode DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "25")]
	ALFJCHGPFEB EEMEPIKHOJG(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void MLOBKFPDJDC(CGKDLJPPHGG IDEOIAGJPJE, ALFJCHGPFEB DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool EGPKCDBMMIE(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void DAKIBFLGLHK(CGKDLJPPHGG IDEOIAGJPJE, bool DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "29")]
	CGKDLJPPHGG HONEBCNANME(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void PJBGGOHKMPD(CGKDLJPPHGG IDEOIAGJPJE, CGKDLJPPHGG DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "31")]
	CGKDLJPPHGG ELIAGIAABGB(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void APFFKENNKIB(CGKDLJPPHGG IDEOIAGJPJE, CGKDLJPPHGG DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "33")]
	AHFBHELEKED KOIHPBNNBAF(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void LHCCKLEDLMP(CGKDLJPPHGG IDEOIAGJPJE, AHFBHELEKED NNJNCPOKHGJ);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool ONJAMLKOGKJ(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void GCKLLAKBKMA(CGKDLJPPHGG IDEOIAGJPJE, bool DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool EHEKBAAJAOP(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void AAAIIFCFJJI(CGKDLJPPHGG IDEOIAGJPJE, bool DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints GJCKEIEDKEJ(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void PLDOGHMKMPB(CGKDLJPPHGG IDEOIAGJPJE, RigidbodyConstraints DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float IDLPJEACNBB(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void KPFDDFDNIKL(CGKDLJPPHGG IDEOIAGJPJE, float DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float NCPDPKBOJGP(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void FBCGCIMNBFB(CGKDLJPPHGG IDEOIAGJPJE, float DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool OPPLICOLJBC(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void IJOABPEOLAL(CGKDLJPPHGG IDEOIAGJPJE, bool DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool OBIPDDHHILE(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void EODHMAHEDCK(CGKDLJPPHGG IDEOIAGJPJE, bool DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void JBGLDPLKGMK(CGKDLJPPHGG IDEOIAGJPJE, int DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "50")]
	EBKBOJHOLGL CDINEHEOCHM(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void NFCGKLMJIDP(CGKDLJPPHGG IDEOIAGJPJE, EBKBOJHOLGL DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "52")]
	EGCBEDHFHPO CHFDKAKAFPF(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void DKJMOAEGHAG(CGKDLJPPHGG IDEOIAGJPJE, EGCBEDHFHPO DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float HBNNODHDNGH(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void GOKNBPNKFMF(CGKDLJPPHGG IDEOIAGJPJE, float DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void GCGHJDMJHBH(CGKDLJPPHGG IDEOIAGJPJE, object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void GHIFBNMFBNK(CGKDLJPPHGG IDEOIAGJPJE, object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool JHAGBHGGMNF(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void BGOJGOAGJFD(CGKDLJPPHGG IDEOIAGJPJE, object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void PLJDFPFIBEO(CGKDLJPPHGG IDEOIAGJPJE, object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool EKCLLCLOJLN(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool PDPCGCKHCMK(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody MMHDABNPCMB(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void BCEJPICEMEI(CGKDLJPPHGG IDEOIAGJPJE, Rigidbody AOJGKLNIGLI);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void BKOIIDAFPJE(CGKDLJPPHGG IDEOIAGJPJE, object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void JJLLHEJKBEB(CGKDLJPPHGG IDEOIAGJPJE, object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool KNOJBIOKABF(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void GDAICPCHDDM(CGKDLJPPHGG IDEOIAGJPJE, float3 PBGBFAMBAMF);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void OOBAEINKPPJ(CGKDLJPPHGG IDEOIAGJPJE, float3 FJPMHBKDAMB);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool ENCEGIOCLLN(CGKDLJPPHGG IDEOIAGJPJE, [Out] float3 PBGBFAMBAMF);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool DPEKMJBCFCP(CGKDLJPPHGG IDEOIAGJPJE, [Out] float3 FJPMHBKDAMB);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool ADHPAKJDEOI(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void DDGCOFJBCLH(CGKDLJPPHGG IDEOIAGJPJE, object JCIFCENKMKP, bool MGPOKEFPGBG);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void IMAKFLIGCFO(CGKDLJPPHGG IDEOIAGJPJE, bool IBIHEGFBOAC);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void CHPEFDIIEBJ(CGKDLJPPHGG IDEOIAGJPJE);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool IEEILMIIMJO(CGKDLJPPHGG IDEOIAGJPJE);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface PBGCOEBIBLO
{
	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NICGJLLOOHO(Entity BPCGKJBILPI);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFMFHGPMFBH(Entity BPCGKJBILPI);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface BIHANNBMCFM
{
	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJEIKGOMPIG(CGKDLJPPHGG PIBCCEDJCCL, bool MAJJBPMFGGH);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPOKOCEANGK(CGKDLJPPHGG PIBCCEDJCCL, int CEGCHAFCKNG);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public delegate void PDEANDJLFEH(PGEBFDAMECD DFENEILCJMP);
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public readonly struct PGEBFDAMECD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly NAKBJJNCGAC AIBDNJKOPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly NativeArray<byte> AHMBAAOPIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly NativeArray<byte> JMNJJNAEPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly IECHECDALGG PKDIIGAGCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly int FFGLAPCMEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly Type DFLCEIJAJGJ;

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public NAKBJJNCGAC GOFPEDJIKDH
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0xA72A10", Offset = "0xA71410", VA = "0x180A72A10")]
		get
		{
			return default(NAKBJJNCGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x69D4CE0", Offset = "0x69D36E0", VA = "0x1869D4CE0")]
	public PGEBFDAMECD(NAKBJJNCGAC AIBDNJKOPDB, NativeArray<byte> AHMBAAOPIPD, NativeArray<byte> JMNJJNAEPGB, IECHECDALGG PKDIIGAGCEA, int FFGLAPCMEMN, Type DFLCEIJAJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x2CF1320", Offset = "0x2CEFD20", VA = "0x182CF1320")]
	public NativeArray<T> GHDBMCOMOEF<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x2CF12E0", Offset = "0x2CEFCE0", VA = "0x182CF12E0")]
	public NativeArray<T> CLNMMEFPJJP<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x2CF11F0", Offset = "0x2CEFBF0", VA = "0x182CF11F0")]
	public (NAKBJJNCGAC, NativeArray<T>, NativeArray<T>) AMGKFNFCLFC<T>() where T : struct
	{
		return default((NAKBJJNCGAC, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C90", Offset = "0x69D3690", VA = "0x1869D4C90")]
	public BNOABJKHKBM MIBOEKNPFAH()
	{
		return default(BNOABJKHKBM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface ILBJAGEEGDH
{
	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	string MCOOMFOEHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	ILBJAGEEGDH HABIFNMBNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	IEnumerable<ILBJAGEEGDH> BDKCMEACIOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface CPFIKPPOADO
{
	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	ILBJAGEEGDH KLLEMDEKNLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	List<MLEDKOIKBOA> LAFEFJNHEIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GLHMFGJPFEF(MLEDKOIKBOA DDHAIBOKNCF, [Out] ILBJAGEEGDH OHMLPFICLKB);

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PMAGAGNLFOG(MLEDKOIKBOA DDHAIBOKNCF, PDEANDJLFEH FFDNDHHCFKB);

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DHJCJMHEBFH(MLEDKOIKBOA DDHAIBOKNCF, PDEANDJLFEH FFDNDHHCFKB);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public readonly struct BNOABJKHKBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly PGEBFDAMECD EEOBDBMOHPL;

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public NAKBJJNCGAC GOFPEDJIKDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0xA72A10", Offset = "0xA71410", VA = "0x180A72A10")]
		get
		{
			return default(NAKBJJNCGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x69C5A20", Offset = "0x69C4420", VA = "0x1869C5A20")]
	public BNOABJKHKBM(PGEBFDAMECD EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x69C5950", Offset = "0x69C4350", VA = "0x1869C5950")]
	public NAKBJJNCGAC GHDBMCOMOEF()
	{
		return default(NAKBJJNCGAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x69C5880", Offset = "0x69C4280", VA = "0x1869C5880")]
	public NAKBJJNCGAC CLNMMEFPJJP()
	{
		return default(NAKBJJNCGAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x69C5760", Offset = "0x69C4160", VA = "0x1869C5760")]
	public (NAKBJJNCGAC, NAKBJJNCGAC, NAKBJJNCGAC) AMGKFNFCLFC()
	{
		return default((NAKBJJNCGAC, NAKBJJNCGAC, NAKBJJNCGAC));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[DefaultMember("Item")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface AHOEBDMAHNH : IEnumerable<OCLDNFFAGFE>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	NativeBitArray PJFDEFHCMKC
	{
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	NativeBitArray IDBEMIDDLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	NativeArray<int> GOEHBBJIINM
	{
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	OCLDNFFAGFE PBAJKHBLIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	OCLDNFFAGFE PBAJKHBLIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OCLDNFFAGFE OCDHEMJGAEJ(GPFGGCIPDEK NBNDOLIHNCP);

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IECHECDALGG COFNELOODJD(GPFGGCIPDEK NBNDOLIHNCP);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class MGDAKKKAHMP
{
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[DefaultMember("Item")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface POKICAJAMPL : IEnumerable<ECDPNBAPABD>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	ECDPNBAPABD PBAJKHBLIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ECDPNBAPABD OCDHEMJGAEJ(GPFGGCIPDEK NBNDOLIHNCP);

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IECHECDALGG COFNELOODJD(GPFGGCIPDEK NBNDOLIHNCP);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class PLGNOCAGCNB
{
	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x2CF67F0", Offset = "0x2CF51F0", VA = "0x182CF67F0")]
	public static IECHECDALGG COFNELOODJD<T>(this POKICAJAMPL DHMABLLFKDN, AIDENNNABKN<T> CCMEKJGADHN) where T : struct
	{
		return default(IECHECDALGG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
[DefaultMember("Item")]
public interface GPBPIDIJFDF : IEnumerable<MLEDKOIKBOA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	MLEDKOIKBOA PBAJKHBLIBN
	{
		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MLEDKOIKBOA OCDHEMJGAEJ(GPFGGCIPDEK NBNDOLIHNCP);

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IECHECDALGG COFNELOODJD(GPFGGCIPDEK NBNDOLIHNCP);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class BBAIILHJCIK
{
	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x28B7D90", Offset = "0x28B6790", VA = "0x1828B7D90")]
	public static GMIMFDEEIBG<T> OCDHEMJGAEJ<T>(this GPBPIDIJFDF DHMABLLFKDN, GPFGGCIPDEK CCMEKJGADHN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x28B77F0", Offset = "0x28B61F0", VA = "0x1828B77F0")]
	public static IECHECDALGG COFNELOODJD<T>(this GPBPIDIJFDF DHMABLLFKDN, AIDENNNABKN<T> CCMEKJGADHN) where T : struct
	{
		return default(IECHECDALGG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface OGDFBGGLLPK
{
	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PMAGAGNLFOG(GPFGGCIPDEK DDHAIBOKNCF, PDEANDJLFEH FFDNDHHCFKB);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DHJCJMHEBFH(GPFGGCIPDEK DDHAIBOKNCF, PDEANDJLFEH FFDNDHHCFKB);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class HCICEBGBHNF
{
	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x2B31260", Offset = "0x2B2FC60", VA = "0x182B31260")]
	public static void PMAGAGNLFOG<T>(this OGDFBGGLLPK GBNEIHNOADG, AIDENNNABKN<T> DDHAIBOKNCF, PDEANDJLFEH FFDNDHHCFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x2B30ED0", Offset = "0x2B2F8D0", VA = "0x182B30ED0")]
	public static void DHJCJMHEBFH<T>(this OGDFBGGLLPK GBNEIHNOADG, AIDENNNABKN<T> DDHAIBOKNCF, PDEANDJLFEH FFDNDHHCFKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface GBLDDPBOKNK
{
	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	HFFJNFKFDFA IKDHKCNGNBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GDPABKOGLCE(MHHMJHGEJDN DCKEDDMMHKE, IECHECDALGG DDHAIBOKNCF);

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIHCIKAEECF(MHHMJHGEJDN DCKEDDMMHKE, Span<IECHECDALGG> DHMABLLFKDN, bool COLGIKIMJGH);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DIFFPGIFFDD(NativeArray<MHHMJHGEJDN> LFGKPJIGHOO);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class PHCEBBIGONE
{
	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x69D4D50", Offset = "0x69D3750", VA = "0x1869D4D50")]
	public static void OIHCIKAEECF(this GBLDDPBOKNK BIGJMICDBAP, MHHMJHGEJDN DCKEDDMMHKE, IECHECDALGG DDHAIBOKNCF, bool COLGIKIMJGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public readonly struct HFFJNFKFDFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly NativeBitArray PIAHEEBGEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly NativeParallelHashMap<MHHMJHGEJDN, int> AKOJHKBLGBG;

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	public bool CEPCMMODIML
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x69CBFE0", Offset = "0x69CA9E0", VA = "0x1869CBFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x424F280", Offset = "0x424DC80", VA = "0x18424F280")]
	public HFFJNFKFDFA(NativeBitArray PIAHEEBGEDP, NativeParallelHashMap<MHHMJHGEJDN, int> AKOJHKBLGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x69CBEB0", Offset = "0x69CA8B0", VA = "0x1869CBEB0")]
	public bool GDPABKOGLCE(MHHMJHGEJDN DCKEDDMMHKE, IECHECDALGG DDHAIBOKNCF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface EGGCODCJLAE
{
	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EHLHOLPPBFC(CGKDLJPPHGG IDEOIAGJPJE, GCPLBGGDBJP DBOBEHLEAAE);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface KNOCGMGDPEF
{
	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	ALFFGGLLEIB NALJMBKBOJP
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
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface AKOCEDIDNDH
{
	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KPFLJCIJABG(World LHKJIBFFKNG);

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NMLCDOMGCFF(World LHKJIBFFKNG);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase PCHFMJCJFDB(World LHKJIBFFKNG);

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JBPHIHPOLJL(World LHKJIBFFKNG);

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GIHFCPKNOAG(World LHKJIBFFKNG);

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GELBIHDGBPO(World LHKJIBFFKNG);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[PDIHONIFFOJ(BLECGLOBIIF.LoadInstance)]
public interface KINCDCCJKBJ
{
	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGPGEBJADCC(CGKDLJPPHGG MODIGHHCJLK, bool DBOBEHLEAAE);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public readonly struct CCHHNEMLINI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly IEnumerable<LOKEPPMGDGP> KFKIKNHIHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly IReadOnlyList<GameObject> PDJKOPOAFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IReadOnlyList<int> PJLPIELPEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly IReadOnlyList<(MHHMJHGEJDN, MHHMJHGEJDN)> FHELLLPLMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly int ODEEODFOAAJ;

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public bool JPOGMMCJBGM
	{
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x69C5A50", Offset = "0x69C4450", VA = "0x1869C5A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public int OIKIDKLOAPM
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3B0", Offset = "0x8B8DB0", VA = "0x1808BA3B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public IEnumerable<GameObject> MCCPOAEHNMG
	{
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4B0", Offset = "0x8BDEB0", VA = "0x1808BF4B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public IEnumerable<(MHHMJHGEJDN src, MHHMJHGEJDN dst)> ILBBCECIDNN
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x69C5E30", Offset = "0x69C4830", VA = "0x1869C5E30")]
	public CCHHNEMLINI(IEnumerable<LOKEPPMGDGP> KFKIKNHIHCL, IReadOnlyList<GameObject> PDJKOPOAFMH, IReadOnlyList<int> PJLPIELPEBE, IReadOnlyList<(MHHMJHGEJDN src, MHHMJHGEJDN dst)> FHELLLPLMCK, int ODEEODFOAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x69C5AB0", Offset = "0x69C44B0", VA = "0x1869C5AB0")]
	public (GameObject, int)[] OFAMNIANELJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface EHPLCKIIOCC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	bool FAJFFPGDFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	bool EKOABGCODHD
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	LNHNJAPKGDG HHALBADADAM
	{
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MPDINAAPAKF HFMIGHBOGBG();

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MPDINAAPAKF IGOIFHACLOB(IEnumerable<CGKDLJPPHGG> OGMGDOCHOGN, [In] UniformTRS CMCJNFGCIDL);

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FJIHJJAAEDM PIEFJFPOCLL(ByteString BJOJKFNCPJN);

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HCNOKPGECMD IFHKMLHGBKP(ByteString AIOLAHHPMLA, CGKDLJPPHGG EMNGIAIDBPA, [In] UniformTRS HENIGDPMBOK, JLPDJBIDDOF CFMMLFKMLEJ, bool MAOMJCNBOFL = true);

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NLKNLEGAGGF();

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CCHHNEMLINI JOBBNFCEDNP(IEnumerable<LOKEPPMGDGP> KFKIKNHIHCL);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class MBPKPOOLHDF
{
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface BCCALNPHLOE
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action MONFKJFPCPN;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action OBBJMCJHPID;
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public struct KEBONIAPHNN : FIILODEJPOA, IEquatable<KEBONIAPHNN>
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public static readonly int KOEBNDNJGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public MMAKLLHOPJG ECCNNFLILMF;

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x69CF720", Offset = "0x69CE120", VA = "0x1869CF720", Slot = "5")]
	public void FIOJCIMJMME(IOPLKNHCKLE DGAMLJBEAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x69CF750", Offset = "0x69CE150", VA = "0x1869CF750", Slot = "4")]
	public void KJCBMOAEMAH(FBEHPONBLLD AACOMNCLNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x69CF780", Offset = "0x69CE180", VA = "0x1869CF780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x9E72B0", Offset = "0x9E5CB0", VA = "0x1809E72B0", Slot = "6")]
	public bool Equals(KEBONIAPHNN HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x69CF680", Offset = "0x69CE080", VA = "0x1869CF680", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x92B7E0", Offset = "0x92A1E0", VA = "0x18092B7E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public struct LOKEPPMGDGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Guid JCMDDLFAGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public string MGIDEFLKNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Vector3 GLNEOPDBMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Quaternion NGGFFKDNCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Vector3 GIFACOBMIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int EHOGCCJJFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public Dictionary<string, object> FFNDHFNNMLH;

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x69D1960", Offset = "0x69D0360", VA = "0x1869D1960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x69D17D0", Offset = "0x69D01D0", VA = "0x1869D17D0")]
	private static string HJHDHGIIOAG(Dictionary<string, object> PJKOKMEJLGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public enum PPEMDEPMBNA
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
public static class FGPIIPOIDMP
{
	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x5DE47C0", Offset = "0x5DE31C0", VA = "0x185DE47C0")]
	public static bool EDBNOCLDGPJ(this PPEMDEPMBNA ADDOHDGDFOD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[Flags]
public enum DOIAFBABCEH
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
public interface HCNOKPGECMD : LNHNJAPKGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	JLPDJBIDDOF IOLEJOPIBGK
	{
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJIENLNABLE();

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CKDBEIECCGO();
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public interface LNHNJAPKGDG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	IEnumerable<LOKEPPMGDGP> MKLJDGDOGEI
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	CCHHNEMLINI JMOGHFHPFPI
	{
		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	PPEMDEPMBNA PNFBJLDEHGB
	{
		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	LocalId BAPLBGMIHPG
	{
		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	FDDNPLJJLNC FJKINLOPBAN
	{
		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GGDEKLHCCBN(DOIAFBABCEH NFHNCJEKBAG);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface JLPDJBIDDOF
{
	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KGOENODNGMM(Guid PPJABDMHAEE, [Out] Guid JEDBDINPIII);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public interface FJIHJJAAEDM : LNHNJAPKGDG, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[Flags]
public enum ONNFCMBIOBK
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
public interface MPDINAAPAKF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	FDDNPLJJLNC HEAKPBNGFEO
	{
		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString LNBDLLHLFFG();
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public enum EGEECMCEMCE
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public delegate bool HHGKODBEDHL(IOBBEPLHEHM PBKDMLHAJOH, [In] HHDNMKIADAH DBOBEHLEAAE);
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public delegate bool EJHKNDDCJDF<T>(IOBBEPLHEHM PBKDMLHAJOH, [In] T DBOBEHLEAAE);
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface HHBFODLBGPK
{
	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PMAGAGNLFOG(IECHECDALGG PKDIIGAGCEA, Type GJBOJPLGIKN, HHGKODBEDHL AEOHHFDMNKC);

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DGLLBKIJJAM(IECHECDALGG PKDIIGAGCEA, [Out] HHGKODBEDHL AEOHHFDMNKC);
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class CLGBPOFJPHA
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class GMDKGGKGAEH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public EJHKNDDCJDF<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public GMDKGGKGAEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x3D3A5E0", Offset = "0x3D38FE0", VA = "0x183D3A5E0")]
		internal bool NHCOABAHDCL(IOBBEPLHEHM pendingList, [In] HHDNMKIADAH value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x2933D10", Offset = "0x2932710", VA = "0x182933D10")]
	public static void PMAGAGNLFOG<T>(this HHBFODLBGPK GBNEIHNOADG, IECHECDALGG PKDIIGAGCEA, EJHKNDDCJDF<T> AEOHHFDMNKC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x69C6900", Offset = "0x69C5300", VA = "0x1869C6900")]
	public static bool IBPNMEJPGIF(this HHBFODLBGPK GBNEIHNOADG, IOBBEPLHEHM PBKDMLHAJOH, IECHECDALGG PKDIIGAGCEA, [In] HHDNMKIADAH DBOBEHLEAAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface BBEKLHDAHAN
{
	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	uint GFGJPLCBOIO
	{
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface IOBBEPLHEHM
{
	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DNHEPFODONH(MHHMJHGEJDN PEKJMDPJPBG, IECHECDALGG PKDIIGAGCEA, ReadOnlySpan<byte> IJELANNLAHF, ReadOnlySpan<byte> EFJKDBCMNGF);

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJMAMHIINMF(MHHMJHGEJDN PEKJMDPJPBG, IECHECDALGG PKDIIGAGCEA, ReadOnlySpan<byte> IJELANNLAHF, ReadOnlySpan<byte> EFJKDBCMNGF);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JOIHHDJHCHG(MHHMJHGEJDN PEKJMDPJPBG, IECHECDALGG PKDIIGAGCEA);

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IKNMBAFLBIA(MHHMJHGEJDN PEKJMDPJPBG, IECHECDALGG PKDIIGAGCEA, ReadOnlySpan<byte> EFJKDBCMNGF);

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OAOGGJOFKKH(MHHMJHGEJDN PEKJMDPJPBG, IECHECDALGG PKDIIGAGCEA, Span<byte> IJELANNLAHF, Span<byte> EFJKDBCMNGF);
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public static class DPEIINLACOJ
{
	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x29981E0", Offset = "0x2996BE0", VA = "0x1829981E0")]
	public static bool OAOGGJOFKKH<T>(this IOBBEPLHEHM DKMHBJKFKHB, MHHMJHGEJDN PEKJMDPJPBG, IECHECDALGG PKDIIGAGCEA, [Out] T IJELANNLAHF, [Out] T EFJKDBCMNGF) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x29980A0", Offset = "0x2996AA0", VA = "0x1829980A0")]
	public static bool IKNMBAFLBIA<T>(this IOBBEPLHEHM DKMHBJKFKHB, MHHMJHGEJDN PEKJMDPJPBG, IECHECDALGG PKDIIGAGCEA, T EFJKDBCMNGF) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public enum LIKLHNKBBNF
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
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface FMCCFEFNDJI
{
	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JANAGLHDIAH(LLFNKNHKEML LBIKMBJEOGO, ReadOnlySpan<byte> NBBCEJPPPCO);

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ABNICPKKEOM(uint KLANLLGOPBE, ReadOnlySpan<byte> NBBCEJPPPCO);

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IDGHPKHPHID(int FKLHBPOKHPO);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface KGFLCGJHFKD
{
	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LLFNKNHKEML GEBICKGEILN(ReadOnlySpan<byte> NBBCEJPPPCO);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface EBHEPDJKHBB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FFCDLNKIHKE(LLFNKNHKEML LDDEKIBHION, ReadOnlySpan<byte> NBBCEJPPPCO);

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GNCCNOBJDIE(ReadOnlySpan<LLFNKNHKEML> IFEHAPMLGIN);
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public struct HCBGEMFNGHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public LLFNKNHKEML LBIKMBJEOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public ReadOnlyMemory<byte> NBBCEJPPPCO;
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public struct LLFNKNHKEML
{
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static LLFNKNHKEML OPIBNLOPKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public uint MBFLFICGBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public int BFGJAIHNBJD;

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0xC2A010", Offset = "0xC28A10", VA = "0x180C2A010")]
	public LLFNKNHKEML(uint MBFLFICGBAG, int BFGJAIHNBJD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x69D16C0", Offset = "0x69D00C0", VA = "0x1869D16C0")]
	public static bool IKJGJDJDJIH([In] LLFNKNHKEML NNEJNMNIIPM, [In] LLFNKNHKEML MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x69D15E0", Offset = "0x69CFFE0", VA = "0x1869D15E0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x69D1690", Offset = "0x69D0090", VA = "0x1869D1690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x69D16E0", Offset = "0x69D00E0", VA = "0x1869D16E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x69D15D0", Offset = "0x69CFFD0", VA = "0x1869D15D0")]
	public void DNIPHOADCKN([Out] uint MBFLFICGBAG, [Out] int BFGJAIHNBJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[PDIHONIFFOJ(BLECGLOBIIF.OMRoom)]
public interface GDKOFBBFJGK : LIPEKHHEOHM<GDKOFBBFJGK>
{
	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GBFLHMLGFGE(IECHECDALGG OBDGAAHPMCD, [Out] HGPDLGMBHEB GLLAODOIGMP);
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public static class FGBABLHNGGD
{
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public interface HGPDLGMBHEB
{
	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	Type BKGBJDLKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FIOJCIMJMME(IOPLKNHCKLE DGAMLJBEAIK, Span<byte> PIBCCEDJCCL);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KJCBMOAEMAH(FBEHPONBLLD AACOMNCLNFJ, ReadOnlySpan<byte> LBIKMBJEOGO);
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public static class HNDNCFLDDCH
{
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public struct DKFILABEDKN : ISystemStateComponentData, IComponentData, IEquatable<DKFILABEDKN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float3 GDMMNJCMFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public float3 MIEBIAHHAGF;

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x69C6CF0", Offset = "0x69C56F0", VA = "0x1869C6CF0", Slot = "4")]
	public bool Equals(DKFILABEDKN HENLEJBGFIE)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public class GGKFJPNBAIC
{
	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public GGKFJPNBAIC()
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
