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
	public class LogRegistrationIndex : CCAGPMFGEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7A99110", Offset = "0x7A97B10", VA = "0x187A99110", Slot = "4")]
		public override void BLLBFFICICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BJIOOJAMDHI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7A87790", Offset = "0x7A86190", VA = "0x187A87790")]
	public static void EHLEIFBCJJI(this Rigidbody FCBMDOHAMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7A87660", Offset = "0x7A86060", VA = "0x187A87660")]
	public static void EHLEIFBCJJI(this Rigidbody FCBMDOHAMHL, Vector3 LFHPDEJICKE, Quaternion IFOGOBMIPHM, Vector3 GPPBAHDFEIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct KFKFMJGCIBC : IReadOnlyList<ECEDHFIPBHO>, IEnumerable<ECEDHFIPBHO>, IEnumerable, IReadOnlyCollection<ECEDHFIPBHO>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct IMPPFOKKJCM : IEnumerator<ECEDHFIPBHO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly HOECEAHHGFN DOOFKBLICCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator EEBIIAOHCCB;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ECEDHFIPBHO GNNLOKFDOIK
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7A93CB0", Offset = "0x7A926B0", VA = "0x187A93CB0", Slot = "4")]
			get
			{
				return default(ECEDHFIPBHO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7A93C60", Offset = "0x7A92660", VA = "0x187A93C60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4EA34E0", Offset = "0x4EA1EE0", VA = "0x184EA34E0")]
		public IMPPFOKKJCM(HOECEAHHGFN DOOFKBLICCL, NativeArray<LocalId>.Enumerator EEBIIAOHCCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7A93BA0", Offset = "0x7A925A0", VA = "0x187A93BA0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7A93BE0", Offset = "0x7A925E0", VA = "0x187A93BE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7A93C20", Offset = "0x7A92620", VA = "0x187A93C20", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly IHOCDGBEEFG ENNBIIMEOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> HOBPLOGKOBP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ECEDHFIPBHO NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7A96710", Offset = "0x7A95110", VA = "0x187A96710", Slot = "4")]
		get
		{
			return default(ECEDHFIPBHO);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7A95B00", Offset = "0x7A94500", VA = "0x187A95B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int IAPBKGGBKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9AC1A0", Offset = "0x9AABA0", VA = "0x1809AC1A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public HOECEAHHGFN OFJMFPBDKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7A96210", Offset = "0x7A94C10", VA = "0x187A96210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NIKDNFEJMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9AC1A0", Offset = "0x9AABA0", VA = "0x1809AC1A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool MNPGKBIJONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7A96260", Offset = "0x7A94C60", VA = "0x187A96260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> JOAMPCCAMEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2CDA850", Offset = "0x2CD9250", VA = "0x182CDA850")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> OKBFAJDBDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7A961B0", Offset = "0x7A94BB0", VA = "0x187A961B0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7A96660", Offset = "0x7A95060", VA = "0x187A96660")]
	public KFKFMJGCIBC(int CIIHPLFOGKO, HOECEAHHGFN DOOFKBLICCL, Allocator DDBBFOCJEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7A96380", Offset = "0x7A94D80", VA = "0x187A96380")]
	public KFKFMJGCIBC(IHOCDGBEEFG ENNBIIMEOCP, NativeArray<LocalId> HOBPLOGKOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7A965F0", Offset = "0x7A94FF0", VA = "0x187A965F0")]
	public KFKFMJGCIBC(IHOCDGBEEFG ENNBIIMEOCP, NativeArray<Entity> HOBPLOGKOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7A964B0", Offset = "0x7A94EB0", VA = "0x187A964B0")]
	internal KFKFMJGCIBC(HOECEAHHGFN DOOFKBLICCL, NativeArray<Entity> GABLPEMHKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7A96390", Offset = "0x7A94D90", VA = "0x187A96390")]
	internal KFKFMJGCIBC(HOECEAHHGFN DOOFKBLICCL, NativeArray<LocalId> HOBPLOGKOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7A96400", Offset = "0x7A94E00", VA = "0x187A96400")]
	public KFKFMJGCIBC(HOECEAHHGFN DOOFKBLICCL, int ENHEICOLGJO, Allocator DDBBFOCJEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7A96540", Offset = "0x7A94F40", VA = "0x187A96540")]
	public KFKFMJGCIBC(KFKFMJGCIBC IKOBDEJHPED, Allocator DDBBFOCJEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7A95BA0", Offset = "0x7A945A0", VA = "0x187A95BA0")]
	public void ECPAKGCPJJJ(List<ECEDHFIPBHO> FMFEHIEKOMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7A95F60", Offset = "0x7A94960", VA = "0x187A95F60")]
	public void JCGEJOPMBAH(int DOAKEFBOPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7A96070", Offset = "0x7A94A70", VA = "0x187A96070")]
	public KFKFMJGCIBC MBAELHOLOJC(Allocator DDBBFOCJEFL)
	{
		return default(KFKFMJGCIBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7A95E10", Offset = "0x7A94810", VA = "0x187A95E10")]
	public Span<ECEDHFIPBHO> HHANLDIEGDL()
	{
		return default(Span<ECEDHFIPBHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7A96110", Offset = "0x7A94B10", VA = "0x187A96110")]
	public KFKFMJGCIBC NHIBFECCICA(int GJCFLJFIOAP, int ENHEICOLGJO)
	{
		return default(KFKFMJGCIBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7A95B60", Offset = "0x7A94560", VA = "0x187A95B60", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7A95FB0", Offset = "0x7A949B0", VA = "0x187A95FB0")]
	public IMPPFOKKJCM KCFKLFFNEEA()
	{
		return default(IMPPFOKKJCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7A962A0", Offset = "0x7A94CA0", VA = "0x187A962A0", Slot = "6")]
	private IEnumerator<ECEDHFIPBHO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7A96310", Offset = "0x7A94D10", VA = "0x187A96310", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class LNFBMKAPBHH
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3732620", Offset = "0x3731020", VA = "0x183732620")]
	public static FFLBBHGNCDF<T> KKHBKOJMGDF<T>(this KFKFMJGCIBC KKMIKMKCMKE) where T : Component
	{
		return default(FFLBBHGNCDF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public struct EMJFOIOODEA : IList<ECEDHFIPBHO>, ICollection<ECEDHFIPBHO>, IEnumerable<ECEDHFIPBHO>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct PPPDMBBPPMN : IEnumerator<ECEDHFIPBHO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly HOECEAHHGFN DOOFKBLICCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator EEBIIAOHCCB;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ECEDHFIPBHO GNNLOKFDOIK
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7A9B900", Offset = "0x7A9A300", VA = "0x187A9B900", Slot = "4")]
			get
			{
				return default(ECEDHFIPBHO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7A9B8B0", Offset = "0x7A9A2B0", VA = "0x187A9B8B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4EA34E0", Offset = "0x4EA1EE0", VA = "0x184EA34E0")]
		public PPPDMBBPPMN(HOECEAHHGFN DOOFKBLICCL, NativeArray<LocalId>.Enumerator EEBIIAOHCCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7A9B7F0", Offset = "0x7A9A1F0", VA = "0x187A9B7F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7A9B830", Offset = "0x7A9A230", VA = "0x187A9B830", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7A9B870", Offset = "0x7A9A270", VA = "0x187A9B870", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly HOECEAHHGFN DOOFKBLICCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> HOBPLOGKOBP;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ECEDHFIPBHO NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CB90", Offset = "0x7A8B590", VA = "0x187A8CB90", Slot = "4")]
		get
		{
			return default(ECEDHFIPBHO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CC80", Offset = "0x7A8B680", VA = "0x187A8CC80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C480", Offset = "0x7A8AE80", VA = "0x187A8C480", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int NIKDNFEJMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C480", Offset = "0x7A8AE80", VA = "0x187A8C480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> JOAMPCCAMEA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2CDA850", Offset = "0x2CD9250", VA = "0x182CDA850")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool KMCAIMHLNNE
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7A8CB10", Offset = "0x7A8B510", VA = "0x187A8CB10")]
	public EMJFOIOODEA(HOECEAHHGFN DOOFKBLICCL, Allocator DDBBFOCJEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7A8CA80", Offset = "0x7A8B480", VA = "0x187A8CA80")]
	public EMJFOIOODEA(HOECEAHHGFN DOOFKBLICCL, int ENHEICOLGJO, Allocator DDBBFOCJEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7A8C690", Offset = "0x7A8B090", VA = "0x187A8C690")]
	public KFKFMJGCIBC MNINAEHKIGJ()
	{
		return default(KFKFMJGCIBC);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7A8C1A0", Offset = "0x7A8ABA0", VA = "0x187A8C1A0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7A8C1E0", Offset = "0x7A8ABE0", VA = "0x187A8C1E0", Slot = "13")]
	public bool Contains(ECEDHFIPBHO OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7A8C270", Offset = "0x7A8AC70", VA = "0x187A8C270", Slot = "14")]
	public void CopyTo(ECEDHFIPBHO[] NAKGFAINKPB, int JMDPMMMKOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7A8C120", Offset = "0x7A8AB20", VA = "0x187A8C120", Slot = "11")]
	public void Add(ECEDHFIPBHO OIBJKKOCOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7A8C550", Offset = "0x7A8AF50", VA = "0x187A8C550", Slot = "7")]
	public void Insert(int DOAKEFBOPIA, ECEDHFIPBHO OIBJKKOCOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7A8C7F0", Offset = "0x7A8B1F0", VA = "0x187A8C7F0", Slot = "15")]
	public bool Remove(ECEDHFIPBHO OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7A8C4C0", Offset = "0x7A8AEC0", VA = "0x187A8C4C0", Slot = "6")]
	public int IndexOf(ECEDHFIPBHO OIBJKKOCOBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7A8C7A0", Offset = "0x7A8B1A0", VA = "0x187A8C7A0", Slot = "8")]
	public void RemoveAt(int DOAKEFBOPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7A8C440", Offset = "0x7A8AE40", VA = "0x187A8C440", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7A8C600", Offset = "0x7A8B000", VA = "0x187A8C600")]
	public PPPDMBBPPMN KCFKLFFNEEA()
	{
		return default(PPPDMBBPPMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7A8C8C0", Offset = "0x7A8B2C0", VA = "0x187A8C8C0", Slot = "16")]
	private IEnumerator<ECEDHFIPBHO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7A8C9A0", Offset = "0x7A8B3A0", VA = "0x187A8C9A0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IECNIPLHCGM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ECEDHFIPBHO ECIGFMPCCOA(ECEDHFIPBHO HOBPLOGKOBP);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JEGMEFDAONB : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface CJMCCCAMMAC : GAIPHBCGPFJ, PNHOIBKKDDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	IMMINFICOAN OAJHGFIBKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	PEBMNHFMPEL FMHELOONJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IHOCDGBEEFG HBMBDIEJPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface PNHOIBKKDDI
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool MJIOMGCHBIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.Application)]
public interface IKFKEIGALFM
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JCDBLEFAGFK(bool PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OPINELCICKH();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface AJJDHBMMNJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool NLAFMPIKOCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool JEELPKDHEMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool IIAPMFNDBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool PLLGBOFPGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool EKNFDGINFLN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DFAHKJOBABJ(bool PLGFLNLCLML);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MCKEHGKFNBO(ByteString CCOEICJONAE);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GPDMJGIBNPK();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KALDPNLHECG();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PJDDBCIFADC();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.Application)]
public interface PEBMNHFMPEL
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	LBHNIGEPODB OAJHGFIBKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	CJMCHNBPJHN GOIACHJOPNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	KJNGOJGOIPM OOHENBIELOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	CJMCCCAMMAC OCCMKMLLDON
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	HHCLOLPOAPN JGDHJGFLHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	AJJDHBMMNJJ KCDAKFNHAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	JHFDFCPCPEN CIAOGKHMHJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	NICOALAHIMF AJFIHKBDGKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	EHPGPOEMLFF HMBAJGICBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	CIBKLKDAMDL HAGLCCJCPEA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	EJBDNDBEGED PFLLEKPADKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	CFIDFADBFLH KBDPOBKEHEA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	HOECEAHHGFN OFJMFPBDKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	JANDLFJNOBB KDDFFNJCJEP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	HDEPPMKMBLP KOKJACAPJKC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	KCCJBNPCDBJ BJHDLAJIAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	KCODKAIDEEC BDIHKNFFBKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	JAOKNLEFHDM PDFBAMCFPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	KNEDPIAHBEJ DGHPLGCPAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	OHIIOHLNKLF HLIGMJMLJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	HJEIBNODODH JMBPAABLJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	HIBGAOKPNFD MINGGMFHNOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	HNKDJIDAPJB FDKEHHFPNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	IICAPLAPEPA LIOOJIPOFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	ILPFMHBELGI PKOFGMJALIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	LPCPLNDNBBJ AHIHOJDGDEI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	INGBMGBGOAB GBLKGEGBJMB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	PDMBJJLECEJ GAAGAGBOFIO
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	EHIKEBBECNK OBOFIMIIMCA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	GIAOHCJKLEE BEDAPMHFJML
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	JFEFOGMKAKI OBACEHBICNF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	MIAJELHJLFO CGCFOLKHODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	FFLBIHCFLKP NBLGDCNDBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	FOBBFIMHMEL CMIEOPIAFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(NOEFBGCNBGM))]
public readonly struct ECEDHFIPBHO : IComparable<ECEDHFIPBHO>, IEquatable<ECEDHFIPBHO>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly ECEDHFIPBHO BOFAFIIEJCI;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int FJNPJIMFCLC = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int FEFDGKIFCOG = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int HNNGLPECMMP = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int DMBHBEPGPHM = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId CEJEEJJKEJL;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public HOECEAHHGFN OFJMFPBDKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7A8A630", Offset = "0x7A89030", VA = "0x187A8A630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public CJMCCCAMMAC OCCMKMLLDON
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7A8BB80", Offset = "0x7A8A580", VA = "0x187A8BB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public LocalId OPKJNEKBKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7A8BD00", Offset = "0x7A8A700", VA = "0x187A8BD00")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	internal IHOCDGBEEFG HBMBDIEJPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7A8B8F0", Offset = "0x7A8A2F0", VA = "0x187A8B8F0")]
		get
		{
			return default(IHOCDGBEEFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool IKAEDGDPHLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7A8B7D0", Offset = "0x7A8A1D0", VA = "0x187A8B7D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private bool KEAKCNOJHIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7A8BDC0", Offset = "0x7A8A7C0", VA = "0x187A8BDC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7A8BFD0", Offset = "0x7A8A9D0", VA = "0x187A8BFD0")]
	public ECEDHFIPBHO(HOECEAHHGFN ICDKFKIMABH, LocalId CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7A8BF40", Offset = "0x7A8A940", VA = "0x187A8BF40")]
	public ECEDHFIPBHO(IHOCDGBEEFG ENNBIIMEOCP, LocalId CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
	public DFLEJIJCDEG NAEIPLKMLKM()
	{
		return default(DFLEJIJCDEG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7A8BD40", Offset = "0x7A8A740", VA = "0x187A8BD40")]
	public static LocalId MEHFEEABIDG(ECEDHFIPBHO JENKJOKHCAM)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7A8BD80", Offset = "0x7A8A780", VA = "0x187A8BD80")]
	public static Entity MEHFEEABIDG(ECEDHFIPBHO JENKJOKHCAM)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7A8BBE0", Offset = "0x7A8A5E0", VA = "0x187A8BBE0")]
	public static bool HFGMMLFJJJB(ECEDHFIPBHO KEEADJCBJCP, ECEDHFIPBHO LKKBJAKGIGL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7A89B90", Offset = "0x7A88590", VA = "0x187A89B90")]
	public static bool BDABLEIINAG(ECEDHFIPBHO KEEADJCBJCP, ECEDHFIPBHO LKKBJAKGIGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7A8BE10", Offset = "0x7A8A810", VA = "0x187A8BE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7A8B9F0", Offset = "0x7A8A3F0", VA = "0x187A8B9F0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7A8B900", Offset = "0x7A8A300", VA = "0x187A8B900", Slot = "4")]
	public int CompareTo(ECEDHFIPBHO OLKLGHOAKNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "5")]
	public bool Equals(ECEDHFIPBHO OLKLGHOAKNE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CHDDDKDFKGL
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7A88910", Offset = "0x7A87310", VA = "0x187A88910")]
	public static MNGNDNIEHNP KJNEOCDFJMD(this ECEDHFIPBHO OIIGDBLKEDN)
	{
		return default(MNGNDNIEHNP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class NOEFBGCNBGM
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct IHOCDGBEEFG : IEquatable<IHOCDGBEEFG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly byte ENNBIIMEOCP;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static byte[] MECHNCGCANG;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static HOECEAHHGFN JMLPHKGOHBN;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static CJMCCCAMMAC HKFDBAGOFJF;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static HOECEAHHGFN[] CGKDEAGJADM;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static CJMCCCAMMAC[] EDHFDJHADFD;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static Stack<byte> MFAIIEEKFNK;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public CJMCCCAMMAC OCCMKMLLDON
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7A92380", Offset = "0x7A90D80", VA = "0x187A92380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public HOECEAHHGFN LLADBNBHBDM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7A921F0", Offset = "0x7A90BF0", VA = "0x187A921F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7A92A00", Offset = "0x7A91400", VA = "0x187A92A00")]
	static IHOCDGBEEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2883870", Offset = "0x2882270", VA = "0x182883870")]
	internal IHOCDGBEEFG(byte PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x69F9C60", Offset = "0x69F8660", VA = "0x1869F9C60", Slot = "4")]
	public bool Equals(IHOCDGBEEFG OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7A92150", Offset = "0x7A90B50", VA = "0x187A92150", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xE81DE0", Offset = "0xE807E0", VA = "0x180E81DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7A92940", Offset = "0x7A91340", VA = "0x187A92940", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7A920B0", Offset = "0x7A90AB0", VA = "0x187A920B0")]
	private static HOECEAHHGFN DOKPFBBJLDM(byte ENNBIIMEOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7A922D0", Offset = "0x7A90CD0", VA = "0x187A922D0")]
	private static CJMCCCAMMAC FHPGKFCBMJA(byte ENNBIIMEOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7A927D0", Offset = "0x7A911D0", VA = "0x187A927D0")]
	private static object LKMNCFEKJIN(byte ENNBIIMEOCP, object[] IOMEFCNHNJN, object LPJIMLBFHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7A927C0", Offset = "0x7A911C0", VA = "0x187A927C0")]
	private static int LGOGDDCEIEJ(byte ENNBIIMEOCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7A92930", Offset = "0x7A91330", VA = "0x187A92930")]
	private static int MPLIDADKEKA(byte ENNBIIMEOCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7A91D90", Offset = "0x7A90790", VA = "0x187A91D90")]
	private static (int, int) BGOEAFAEECO(byte ENNBIIMEOCP)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7A92370", Offset = "0x7A90D70", VA = "0x187A92370")]
	private static byte FPFFLCPLAOE(int AIBPOENNNGG, int DOAKEFBOPIA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7A91E10", Offset = "0x7A90810", VA = "0x187A91E10")]
	internal static IHOCDGBEEFG BLLBFFICICF(CJMCCCAMMAC ENAAKLLIHIA, HOECEAHHGFN ABNDEHEFKBM)
	{
		return default(IHOCDGBEEFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7A91BA0", Offset = "0x7A905A0", VA = "0x187A91BA0")]
	internal static void BAPLINGHHOO(IHOCDGBEEFG ENNBIIMEOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7A92460", Offset = "0x7A90E60", VA = "0x187A92460")]
	private static void HLNPBCIDBLI(int CIIHPLFOGKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum JEJEJCOMHPH
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	SubGraph,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	SceneMainInitial,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	SceneMainJoining,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	SceneAdditive
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IAKCPMFMHGL
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool PJBAFGGIPAK
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool MKAJJDLKEBM
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool BGDIEOLPDCD
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool OBONHFPHLAG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool ENFPDDGKPAE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface CCJNAEPOKJM
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JOKCEOAFCOB(FIOOFEINKEM MCJDMILNGAL, int DOAKEFBOPIA);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FIOOFEINKEM : IAKCPMFMHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum NPGNFOFKOIC
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Environment = 0,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Decoration = 1,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Physical_Sticky = 2,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Physical = 4
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool GKCFEFOBMGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool ENBGHEEHPHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool CHJCPAHJAFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	int HCOLPCDIHFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BLEEOFNMCLM(NDDBNDELAJJ GMLPEGDALHF, int DOAKEFBOPIA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface NDDBNDELAJJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool ADFHPEHMFPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	AHBNMJGLFPD LLICMCNEDBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	AFNOLENJMED CIPKLMBDIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	float3 NHAANPHMDOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	quaternion JHFELMOKPLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	float3 MOGENFAMANI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	IHJHIPFBKPL LFCKJDCIBED
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	EJODAALJJDB NAFKEKHKPNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float LADMGFNEMBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float3 NFMCJKEAIBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float GHFAOALAGMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	FFELHMGLKAD GKALKMPIJCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface HNDMNCFLPLK
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float3 GLJBENMMLGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	float3 MEIJPBHHPCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	quaternion CCCNEMCFPKJ(float3 EDIOPPBFIOC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface AFNOLENJMED
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool PODNLPPIGGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool JDJHABCKPOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool HPEMNCOOJKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	float MIEAJCFMJMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	int OHGHIHMCMNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	int MNJFLPMGCDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FABABLKEBHA(HNDMNCFLPLK GMLPEGDALHF, int DOAKEFBOPIA);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[ServiceLifetime(Lifetime.Application)]
public interface JANGPJCAPLG
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	Guid KEBHHGIKNED
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DAGDKDFBGFK(Guid OMAMBNBOHBN, Guid EGEPAJMBPNL, Guid HFLIIJJEKEN);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task JJMIDFGNHOB(Guid OMAMBNBOHBN, Guid[] AELNLBJIDLC, Guid HFLIIJJEKEN);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid HMHNGAKMALJ(Guid PLGEGLLPNNG);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task PMJNILDNCDH(ECEDHFIPBHO OOAIBGMKFAE);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EIGALMPFDLG(Guid PLGEGLLPNNG);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KLPBFOOPDLD(MEJAGEBNPFG NNOCGFPBHBF, Guid DHFOMJJOCEA);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EAJAHLMAMJN(Guid PLGEGLLPNNG, bool PLGFLNLCLML);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.Application)]
public interface GGNDFGLFDOH
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ServiceLifetime(Lifetime.Application)]
public interface PHKGFLEDIFA
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJOKNCIPIOO(GameObject LPEJLEDJCKJ, GameObject MOCFLNLAPCP, int JMPPAOJDMIG);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface LHFJBMADAEE
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "0")]
	void NHJFKBKJIEM(bool AMLCJKDLNFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface CJMCHNBPJHN
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	LHFJBMADAEE ABGCNJEEILM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	AIACCPEDGPB DIAKIHOOKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	GKNNDFMOMFF ABAAAEKKFFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	HLCDHJGHKDK JAOHGEGCIGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	PKFPEIEOMBL IKBJBIGIBMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	POIAKJEFKEN IEKAMLFOBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	KABBGBFCKPB CFKFAEPANHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	PKHBJJPMNOF BMEEFEPLEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.Application)]
public interface AIACCPEDGPB
{
	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	string DDMJHKKLONG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[ServiceLifetime(Lifetime.Application)]
public interface MCAKNBGEHBI
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MMKJIKFBCNA(Action HNDDBOOOBBE, bool OHGAOFBPBAG);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DEIFHKGAOJD(string EMLAIMJKHOE);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int GOOKALLNIBE(string EMLAIMJKHOE, int LPJIMLBFHAO);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NBMIAMOLBDE([Out] bool PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FFFGLMOLAAD([Out] bool PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ILMFBLPCPHC([Out] int PPJFMHBDGNA);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[ServiceLifetime(Lifetime.Application)]
public interface GKNNDFMOMFF
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "0")]
	void BCPOIAFFPBG(bool PLGFLNLCLML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface HLCDHJGHKDK
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected static readonly Guid DJAFMENAIMO;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	static readonly Guid NPFBJPHDBLJ;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	static readonly Guid FEDCKCADDOF;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	static readonly Guid AHMKCLFAJGF;

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool DGOELHHIKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	bool KICCKFODPCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	bool MNMKPNKOMNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7A91510", Offset = "0x7A8FF10", VA = "0x187A91510", Slot = "3")]
	string[] JBFNPACHIHL(KPELGGMCHHD FOGEPJODCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NKOJLBMGGND();

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7A914E0", Offset = "0x7A8FEE0", VA = "0x187A914E0", Slot = "5")]
	Guid CEMBEHEDKHE(Guid GMABHLKFPLK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int MAOPLAKALPE(KPELGGMCHHD FOGEPJODCLG);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AKGMNMONKAF(KPELGGMCHHD FOGEPJODCLG, NativeArray<MMDOPIHLILM> JNKJKNEHMCH, NativeList<UniformTRS> MDOGNMAMNCF);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int APJEFPHEFGB(Guid BIGAPECKJPI);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool BKCALDAENKD(string HGOJKHNLDAC, [Out] Guid BIGAPECKJPI);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string AGPBFPIDIID(Guid BIGAPECKJPI);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool MHPBGPJMFBD(RRObjectPrefabData HJCAPCAFNBP, [Out] LocalId CGNAGBGLBDK);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	FFLBBHGNCDF<byte[]> GLBGKLMJFFE(NativeArray<MMDOPIHLILM> BEOKEHNEGKM);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GIKHAFHDIIC(byte[] BPJKACIIJGE);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GameObject IODHLDKAEFE(string HGOJKHNLDAC);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EPKOFHAHJNB(Transform GBIMAJCBFCJ, RRObjectPrefabData NEMAPDMIBOF, IIJAAMAGBPD OJFCDDMGKNP);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool PCOJFPIJKPL(KPELGGMCHHD FOGEPJODCLG, NativeParallelHashMap<Guid, LocalId> LPCPCNAKNJH, [Out] Exception MDJLCJHKPHD);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HEKGHDKNAPG(KPELGGMCHHD FOGEPJODCLG, NativeParallelHashMap<Guid, LocalId> LPCPCNAKNJH, [Out] NativeArray<LocalId> GABLPEMHKBP, [Out] NativeArray<LocalId> DHKHEFACEBO, [Out] NativeArray<AuthoredLocalPoseData> FPAHAFMJLBD, Allocator DDBBFOCJEFL);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "18")]
	void BCFLKGIJOKJ(KPELGGMCHHD COLBDAEGKBA, NativeArray<int> BNBBEFECELE, HPNOBMMHMAN<GameObject> JEEKLJDABDG, FFLBBHGNCDF<GameObject> JNGNEBLEMOA, JEJEJCOMHPH JBPDFJKPCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void EBFJIHPAGEB();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "20")]
	void FEMFOKHMCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "21")]
	void HOGEJFHJFFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "22")]
	bool ABMONFINPNK(KPELGGMCHHD FOGEPJODCLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "23")]
	CCJNAEPOKJM BEDAKAEGMJD(KPELGGMCHHD FOGEPJODCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "24")]
	void OJLKCJDDCJL(Guid GHMOOFOLHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "25")]
	bool EHLAGNOEGBF(Guid GHMOOFOLHLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7A915A0", Offset = "0x7A8FFA0", VA = "0x187A915A0")]
	static HLCDHJGHKDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface CINKCGGJAMC
{
	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	long MNNKLLJAPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	long PBPJPNKHCMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "1")]
		get
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface PKFPEIEOMBL
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	bool JMJBJHPCHFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool PJCCLFCIFML
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	int EKAPONBNDPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	int CNHHKFIEHBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	int OOGNIJIBAFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	bool AOJNGJKALIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	int HFJONAKLBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "6")]
	void KBCEAIDHPPM(FPDAMLANPLH ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "7")]
	void AIBOPAAAMLE(bool GACNPBFADEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "8")]
	bool GIMLOAMOABD(JKHDNFMHOCD LNFLFPBOJOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "9")]
	void NMLNEOMDADK(object ECGNDACMANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "10")]
	void EEEOIAFOJOH(object ECGNDACMANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "11")]
	void KHGANIEHJPO(object HIKBDNMPFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "12")]
	void NIGHJHJFEID(object HIKBDNMPFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "13")]
	void KFLFKFGOCCB(NativeArray<ViewId> BONBIGDIDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "14")]
	void HNJHDHMDIPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "15")]
	void IPDEJKJABAN(BHMFNJNGEHN OHCGINPDMEI, ReadOnlySpan<byte> DFPGGEDGGGN, JKHDNFMHOCD BPJBLADDKKK, bool NAOCLEPIDOE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "16")]
	void IPDEJKJABAN(BHMFNJNGEHN OHCGINPDMEI, ReadOnlySpan<byte> DBHHGAPEEMC, bool NAOCLEPIDOE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "17")]
	void IPDEJKJABAN(BHMFNJNGEHN OHCGINPDMEI, ReadOnlySpan<byte> DBHHGAPEEMC, ReadOnlySpan<byte> NJKOJFJKKFB, bool NAOCLEPIDOE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "18")]
	void GOGNPFLKBIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "19")]
	void APNHIOIEPEK(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "20")]
	void PBAHCICEKEN(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "21")]
	void EDFHCLEALBM(Dictionary<object, object> EMBALCKBABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "22")]
	void HFGKAEEPEEN(NativeList<MNGNDNIEHNP> LLHKKOFHCEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "24")]
	void NILGNBBPBDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "25")]
	void LBKMJCGDJOI(List<object> DMPOELGMLAH, int FNEPEEDFAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "26")]
	void MCIOMOIAKNH(int DLLOIHPCEBC, object GLECKDJIKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "27")]
	void AONJENIAAHA(JKHDNFMHOCD LNFLFPBOJOG, Dictionary<object, object> FPBCGBJHAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "28")]
	void PLGGHNDMJDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "29")]
	void BOELLHMLBHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class NHICDJCJMJN
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7A9A0E0", Offset = "0x7A98AE0", VA = "0x187A9A0E0")]
	public static HCEDIIDBBKN GKOMLINIOPE(this PKFPEIEOMBL OADJGMBHLBP, object GNAAILLDOKI)
	{
		return default(HCEDIIDBBKN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct HCEDIIDBBKN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private PKFPEIEOMBL OADJGMBHLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private object GNAAILLDOKI;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7A90D70", Offset = "0x7A8F770", VA = "0x187A90D70")]
	public HCEDIIDBBKN(PKFPEIEOMBL OADJGMBHLBP, object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7A90D20", Offset = "0x7A8F720", VA = "0x187A90D20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[ServiceLifetime(Lifetime.Application)]
public interface OBHNFPMJBED
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[ServiceLifetime(Lifetime.Application)]
public interface POIAKJEFKEN
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct ICDNPJNNPLL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private POIAKJEFKEN DDFANDDJOGI;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7A91B10", Offset = "0x7A90510", VA = "0x187A91B10")]
		public ICDNPJNNPLL(POIAKJEFKEN DDFANDDJOGI, string NEADOILGEFJ, string ANHCPFOIGHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7A91AB0", Offset = "0x7A904B0", VA = "0x187A91AB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct PCILIFOIDMN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private POIAKJEFKEN DDFANDDJOGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Task GLCABFFLNII;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7A9AFC0", Offset = "0x7A999C0", VA = "0x187A9AFC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "0")]
	void PGOLCPNMOGN(string FLPDJFEEMLN, float JHEFBFGKIFH = 5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "1")]
	void CHCHJGFJLBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GFHHICGCLKJ(bool OMJHOLAGIPA, string NEADOILGEFJ, string ANHCPFOIGHD);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "3")]
	void NFKOBBGJMCA(string FLPDJFEEMLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class LAAJBEJOIKJ
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7A980C0", Offset = "0x7A96AC0", VA = "0x187A980C0")]
	public static POIAKJEFKEN.ICDNPJNNPLL GPIMKJPPAPN(this POIAKJEFKEN OADJGMBHLBP, string NEADOILGEFJ, string ANHCPFOIGHD)
	{
		return default(POIAKJEFKEN.ICDNPJNNPLL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[ServiceLifetime(Lifetime.Application)]
public interface MDEDGHLPKAJ
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JGKDLEFLIIK(GameObject IHDAMAGFMLN);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MECBBKIHHBC(GameObject IHDAMAGFMLN);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LFDKOMFHHGF(int LNFLFPBOJOG);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object JDMCKMJKEPK(ECEDHFIPBHO CEJEEJJKEJL, GameObject IHDAMAGFMLN, Action<ECEDHFIPBHO, int> PCKPGHHEKOC);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LGPGACBBKFN(GameObject IHDAMAGFMLN, object KLAFFNHNLLD);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[ServiceLifetime(Lifetime.Application)]
public interface IGMBKBBHACN
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CFLEALCFLNK(object OIIGDBLKEDN, NativeList<byte> DFPGGEDGGGN);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object DHOLDBOACBA(NativeArray<byte> DFPGGEDGGGN);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[ServiceLifetime(Lifetime.Application)]
public interface FGMNOGNCNGE
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool GMACHBGOPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate JGNNACAHCJF(EEAKLOMOEIA FJOBKMLKECM, Action<EEAKLOMOEIA> PCKPGHHEKOC);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CPHGOPGGFFK(EEAKLOMOEIA FJOBKMLKECM, Delegate PCKPGHHEKOC);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate ANJEHBMGGBI(EEAKLOMOEIA FJOBKMLKECM, Action<EEAKLOMOEIA> IHHJIIFNNAI);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BFHJBJPBBJF(EEAKLOMOEIA FJOBKMLKECM, Delegate PCKPGHHEKOC);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MLJHDDKNOBB(EEAKLOMOEIA FJOBKMLKECM);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EEAKLOMOEIA EFADCOAFCBP(GameObject IHDAMAGFMLN);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[ServiceLifetime(Lifetime.Application)]
public interface AEOBBKFNNHN
{
	[Cpp2IlInjected.Token(Token = "0x17000078")]
	int FBMNJPDKBNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	int PPMGKDNEFGP
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	bool JMJBJHPCHFI
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	bool AEDKJCEFAKF
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool AHIHOKIEMMD
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ECEDHFIPBHO LFNKLCIEEPM(int LNFLFPBOJOG);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.Application)]
public interface KABBGBFCKPB
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	bool NLAFMPIKOCA
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ServiceLifetime(Lifetime.Application)]
public interface EDBGHLHADIK
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	AMDEOGDAEEI KNLOAKJHFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	HBJPHKMFDDO CHGKFNOICGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	bool JCPCKLGJKBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LCEEGAJDCIF(Transform GBIMAJCBFCJ);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LBOFBMCGFBI(Transform GBIMAJCBFCJ, LCGNEMGJNFI FNOGJLBDEBJ);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BBLLPEJPGGD(Transform GBIMAJCBFCJ, MPMOFPPLHCF FGIHDPOHIFO);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
public interface PKHBJJPMNOF
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action AILFOHEAEEM;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.Application)]
public interface MKIBKCHGJFB
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMFIGFMLJLA();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ServiceLifetime(Lifetime.Application)]
public interface CFOPMPNLOGP
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLFGIFHICAA(GameObject IHDAMAGFMLN, HLDBNBPNCCB NBMCLLHLIGH, PPEOEAGKAEB HKLMDBONFEI);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FNLGJNDNAHL(ECEDHFIPBHO CEJEEJJKEJL, bool JNJMKAEKGCG, float3 HACCPKCHEAN, quaternion GALEMCMANFI);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HPNAGEHMNHP(KFKFMJGCIBC PBEGPGLJMBL);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MMMKMCFKKKN(DFLEJIJCDEG NMGLJLCLAKO, DFLEJIJCDEG HIKBDNMPFJK, PDPDCPPPIIG OAIBEKCJMGA);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BFNLBBHLNHE(DFLEJIJCDEG NMGLJLCLAKO, PDPDCPPPIIG OAIBEKCJMGA);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OHNBIGLJMPN(KFKFMJGCIBC PADCOIFGDKE);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GameObject CAAILCADBBP(Guid PFOIEJEEHEL);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DMODBMLGLAM(EJDGDAIPGFC LPMOKCKBNAB);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct JDLBHJJBGLD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NativeArray<byte> DFPGGEDGGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly GCHandle ENNBIIMEOCP;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7A95050", Offset = "0x7A93A50", VA = "0x187A95050")]
	public JDLBHJJBGLD(ReadOnlyMemory<byte> KIJJLGLBELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7A95010", Offset = "0x7A93A10", VA = "0x187A95010", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum LEDCELHCDKM
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	V0PreObjectModel = 0,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	V1ObjectModelHierarchy = 1,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	V2ObjectModelHierarchy = 2,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	V3Entities050 = 3,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	V4Entities050Compressed = 4,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	V5BumpObjectModelVersionMay2024 = 5,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	OldestCompatibleVersion = 3,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	LatestVersion = 5
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct KPELGGMCHHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public ByteString JNDKGOFMEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public object LJLKGHMHEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object DBAECGAGCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IEnumerable<string> GBLBDNKLMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool HAFOCAFFAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public DFPPKNOOKAB.CDFFMGBLGOF? ECKAPFJMHAD;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7A98040", Offset = "0x7A96A40", VA = "0x187A98040")]
	public KPELGGMCHHD(ByteString JNDKGOFMEIL, [Optional] object LJLKGHMHEDP, [Optional] object DBAECGAGCMH, [Optional] IEnumerable<string> GBLBDNKLMHG, bool HAFOCAFFAMH = true, [Optional] DFPPKNOOKAB.CDFFMGBLGOF? ECKAPFJMHAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct DCLBCCOJNGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object OAJMFPJFILI;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct MMDOPIHLILM
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[Flags]
	public enum EGNDNOJJHAH
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		IsInvalid = 1,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		IsStudioPrefab = 2,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		IsBetaOnly = 4,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		IsDevOnly = 8,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		IsR1Only = 0x10,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		IsR1Upgrade = 0x20
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public RRObjectPrefabData IMGIFEBFJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Guid HGHGJGKJMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Guid NINEKDGNBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid ONCJGJMCAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Guid ENMPMONDOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public EGNDNOJJHAH BNNEEGIINDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Color32 EIGLILGIKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public int JDIKAFJMJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public OJGLABAHOGG OINANJIBGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int DIGLCIKBPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int FIEPAFBALAH;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Guid BACGCEGFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x4EA0740", Offset = "0x4E9F140", VA = "0x184EA0740")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public bool MMFLILFHBAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7A99C60", Offset = "0x7A98660", VA = "0x187A99C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public bool DDCDPADDJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7A99C50", Offset = "0x7A98650", VA = "0x187A99C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public bool LHBCJJAPGIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7A99C40", Offset = "0x7A98640", VA = "0x187A99C40")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct OKFIGDBAPHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal readonly BAJDAOIPJIB GJCFLJFIOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly BAJDAOIPJIB BKICKHECIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal readonly uint LCJMHOCPBLE;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7A9A780", Offset = "0x7A99180", VA = "0x187A9A780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct MCIFEKFMDCP
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal readonly OKFIGDBAPHA HNDDBOOOBBE;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7A8A9E0", Offset = "0x7A893E0", VA = "0x187A8A9E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public readonly struct DNFKBEHGBHG
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal readonly OKFIGDBAPHA HNDDBOOOBBE;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7A8A9E0", Offset = "0x7A893E0", VA = "0x187A8A9E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct FJOJFCNABPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal readonly uint LCJMHOCPBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	internal readonly bool HJPMCKMFBEH;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7A8F9F0", Offset = "0x7A8E3F0", VA = "0x187A8F9F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct BAJDAOIPJIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal int LMGBAALNFHC;

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7A86E20", Offset = "0x7A85820", VA = "0x187A86E20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[ServiceLifetime(Lifetime.Application)]
public interface NONDEKFBPGH
{
	[Cpp2IlInjected.Token(Token = "0x17000085")]
	NGOBGCALAMM MOBAODPIOBH
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface MEJAGEBNPFG
{
	[Cpp2IlInjected.Token(Token = "0x17000086")]
	ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface MKKDOFKBDHI
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class HAOLKBLKFKB
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x36739F0", Offset = "0x36723F0", VA = "0x1836739F0")]
	public static DFLEJIJCDEG NAEIPLKMLKM<T>(this T CEJEEJJKEJL) where T : MEJAGEBNPFG
	{
		return default(DFLEJIJCDEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7A90BE0", Offset = "0x7A8F5E0", VA = "0x187A90BE0")]
	public static MonoBehaviour IDPAOLHMOLH(this MEJAGEBNPFG CEJEEJJKEJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7A90C60", Offset = "0x7A8F660", VA = "0x187A90C60")]
	public static GameObject OJFCLDLGCBC(this MEJAGEBNPFG CEJEEJJKEJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface PNKDDFMFPFG : MEJAGEBNPFG
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(ECEDHFIPBHO OHLJFNOIPDI);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface MMICMMKKBDK : MEJAGEBNPFG
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface IMMFCBKBEJE
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public delegate void JIHPBGFFBFH(AJPNCGACNDE JEBPDDHPIMC);

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event JIHPBGFFBFH NHAFMBBBJPO;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface LAFDEBPMJNI
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface MBJKPHMMLHB
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface JNHJOIKHAHG
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(ECEDHFIPBHO DAKCINHFJOI);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool HELJNFEBCOB);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FFLCFPJJDDF(ECEDHFIPBHO HDDPFCMNNBA);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface EFADMKPHBEK
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(COGOJKBIHHJ NGGOKAEBMMN);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface COGOJKBIHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000087")]
	GameObject IHDAMAGFMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Transform GBIMAJCBFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	AEGDBIMJAKG CKCNOBBDFBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	bool FFMEHOBPEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EDABNPHBCGL(AEGDBIMJAKG GBDMJHAPPHC);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BNAMPFDBALG GetData();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class NCFKGEONGHP
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7A99D50", Offset = "0x7A98750", VA = "0x187A99D50")]
	public static void EPCIHMEPHLE(this COGOJKBIHHJ JCJHLOEIIFO, IIJAAMAGBPD OJFCDDMGKNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface AEGDBIMJAKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	Rigidbody JADPAFJKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	COGOJKBIHHJ KOPGJJGMPFH
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	GameObject OJFCLDLGCBC
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	Transform GKBGOMKDLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	AEGDBIMJAKG LKNIONJKNBM
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	AEGDBIMJAKG LKAEGJLGAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	int BLOGALEBJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	bool JBBBMCHECPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	bool MLJHDDKNOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	bool NEMCFNAJMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	EDDAFEHGANJ AIFJKNOJMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	PMMOKEJBHFJ OHCMFAEHIHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	float PEJGPIMKEKB
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	Vector3 GOMGLAPHAHG
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	Vector3 JFNNBNCGHBP
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	Vector3 JBOLMPDFKDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	Vector3 EEHIJMCACGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool EABHEGNBDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	bool DOGEECAEPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool FLGAHILHJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	bool MOCHOEMIBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	Vector3 DGGLPPHNMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 FPBOMHPDKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	Vector3 LEJBCFNAOGD
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	Vector3 NFBCHABDNEC
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	float DCHGLADGMNH
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	float FBDCBPLJJNH
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	Vector3 BIFJODANNFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	Quaternion GDOEFFLGCMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	float OPECJKNFJCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	float GHFBDEPLCDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool LOEEGOLECOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	JFFGEHLFDPP HBFBJDHEFMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	bool JCNHMCMDBEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	Transform OEODHDMIDIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	Vector3 FKJGNPDLIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	float POFGGGLCGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	float MMEODJGGKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	Quaternion LPIDAMMACLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	Vector3 GLJBENMMLGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	Quaternion GDFHKBKNAFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	RigidbodyConstraints JBABDFEEJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	bool PPGCBNJPMIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	CollisionDetectionMode INCBHDMGFBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	bool GBHOGBPJMED
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event EIMKACMLCOF HPMNGIDAKOL;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event EIMKACMLCOF BEOPJEDGIKK;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event EIMKACMLCOF CEHFNLMIEBM;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event EIMKACMLCOF MJLJPIFOJCD;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event EIMKACMLCOF EIGIABMIGAC;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event EIMKACMLCOF JJHDIEMPODM;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event EIMKACMLCOF LKAKPBAKBIE;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event AAILGCMHGNK JICLOCIGEGP;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<HNIGDDENMGF, HNIGDDENMGF> KFNJJBLINJE;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "26")]
	AEGDBIMJAKG PHKGBJEBKCC(int DOAKEFBOPIA);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void JFACDNBLNMA((Quaternion rot, Vector3 moments) BFILMAEAIPL);

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void GMJBMKIKLGO();

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void CCMHLPMEACK();

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void NAEDHDKIOFD();

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void PLINLFMHMME();

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void HNBPCPCJAHK();

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void GICBAHPKOCO(AEGDBIMJAKG PPJFMHBDGNA, bool OFLGEPPEKAD = false);

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void CELCJCJPFBE(object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void MGKNBKAMPOB(object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 ABOAMJNOFCD(Vector3 PJJJJDKGMGH);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 IGGJJBLPPKA(Vector3 NJBLGKBFLMG);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void AIMEKICABJJ();

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void NJBILFLLADD();

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void DAJJDIHJIFG();

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void NDNMFEBPDPJ(Vector3 KKNIJFMODLP, Vector3 HAKGCOPLKEE);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void PMJEDFAIGPL(Vector3 HOJGOCKJLEI, Vector3 HELMCCBIBJA);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void FJAJFJCLDJK(Vector3 KKAPAIFKKGJ);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void DBPFGEEAFLO(NDBGGMAABME GLDACEOGKOF, Vector3 ICDAHOACGJL, float MFDBDMLHKBO, float CMEMFLLIBBI = 8f, float DMHCNEFBFKH = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void IINNMDPIFOE(MAHCBKNMHNB PEOJMKLPOGJ, Vector3 JBPODNLOLED, float MJDLKKNIKHJ = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void HEODHCBKGJC(MAHCBKNMHNB PEOJMKLPOGJ, Vector3 KONJHPLFEME, float MGFDEACAIGP = 7f, float DLPODANBMAG = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 HMJDCLHNDNE(Vector3 PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 DEBOLEMLKPP(Vector3 PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void OOFMNJCINFK();

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void PLMELKDEAFH(AEGDBIMJAKG GOKDJANKNKE, object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void BEPKDMMKGFO(object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void AKMOEEOCJGK();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void HAFANPILNFO();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void ICCOCPPFPIM();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool HJMKGFNNCFL();

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void KFPHNLHMHHJ();

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void HDEFECDDIFF(object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void OPMHODNMBPM(object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void CHCLPGMJHFM(object GNAAILLDOKI, bool MLIEPCEKKKM);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void JMJIBLJDLFB(Vector3 FBLMAAJOADP, Quaternion FIDEGHHFHJK);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void IAMDFGGLGMI(Vector3 HAMPBLAEJPA, Quaternion OCDILGIKBNM);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool FIIMCLPFNID(float DFLDIKKIDLP);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void FDLBLIHCADK(object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void NOHNHBGONNF(object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void MBNHJKHPNPC(object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void MPICDEHACKI(object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void CCMEJBGHLCK(Vector3 JDEIJIAFEMH, ForceMode MGJAADBPMJD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void MLKHEIEEHGI(Vector3 JDEIJIAFEMH, Vector3 KKIJMCHODGC, ForceMode MGJAADBPMJD);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void CCKICFDOCAP(Vector3 DBNLIBDADBA, ForceMode MGJAADBPMJD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void EIJGDGMOIKI(Vector3 DBNLIBDADBA, ForceMode MGJAADBPMJD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool OBJEAPCONIP(Vector3 BJECPMGLFMN, [Out] RaycastHit ILNEPPLCHJL, float FPNKBMPOCJL);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void JHBHKMFNBIH();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface PMMOKEJBHFJ
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDKLNKDDKAH(Vector3 JEPBDEMEJGA);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HADIIKCJKJH(Vector3 AEJKODDIOPN);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DOFCLCFJKFK(Vector3 JEPBDEMEJGA);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NCCKEOCBCNF(Vector3 AEJKODDIOPN);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface EDDAFEHGANJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 GFKKLLINCGJ();

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 OPIAEKEFBJA();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JFEMNIKOECN(float OCJNNFFGCEI, float OOFNJDLCKHG);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public delegate void EIMKACMLCOF(COGOJKBIHHJ PIKLHDBFCDK);
[Cpp2IlInjected.Token(Token = "0x2000055")]
public enum DCFIGHJGFGA
{
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	ChildAdded,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	ChildRemoved,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	ParentChanged,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	HierarchyMassUpdated,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	SleepChanged,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	DistanceBandChanged,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	IsKinematicChanged,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Discontinuity,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Destroyed,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public enum NDBGGMAABME
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Reflective,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	FullOverride
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public delegate void AAILGCMHGNK(COGOJKBIHHJ PIKLHDBFCDK, bool OFLGEPPEKAD = false);
[Cpp2IlInjected.Token(Token = "0x2000058")]
public enum MAHCBKNMHNB
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct BNAMPFDBALG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Rigidbody LHOBCJGBABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public object BHOIPEJOEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Vector3 LFKEIMJCIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector3 LMGDLPKFLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public FDEOGDPKFCL HAJKLCOCJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public bool ODEBLNEOPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool NMKLIDIGFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool GNBMGGNJFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool FNDOIIBPCCN;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct DFLEJIJCDEG : IEquatable<DFLEJIJCDEG>
{
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public static readonly DFLEJIJCDEG BIJHFGIMDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public GameObject IHDAMAGFMLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7A89ED0", Offset = "0x7A888D0", VA = "0x187A89ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public MNGNDNIEHNP ADNGAANLBDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7A8A540", Offset = "0x7A88F40", VA = "0x187A8A540")]
		get
		{
			return default(MNGNDNIEHNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public PHMLPDLGIJG DBBBBPNFKIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7A8A3E0", Offset = "0x7A88DE0", VA = "0x187A8A3E0")]
		get
		{
			return default(PHMLPDLGIJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public RRObjectPrefabData FAINJKPCAPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7A8A240", Offset = "0x7A88C40", VA = "0x187A8A240")]
		get
		{
			return default(RRObjectPrefabData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool CBAKKLMDCOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7A8A3A0", Offset = "0x7A88DA0", VA = "0x187A8A3A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool CLACEEPINFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7A8A850", Offset = "0x7A89250", VA = "0x187A8A850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool ADFHPEHMFPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7A8A3C0", Offset = "0x7A88DC0", VA = "0x187A8A3C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool BHALAPIJNKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7A89EB0", Offset = "0x7A888B0", VA = "0x187A89EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool CJEIHIJNGLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x7A8A610", Offset = "0x7A89010", VA = "0x187A8A610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool MHEHBPBGMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x7A89BF0", Offset = "0x7A885F0", VA = "0x187A89BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool NGNMACFLNFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x7A8A500", Offset = "0x7A88F00", VA = "0x187A8A500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool PGFJENAKEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x7A8A480", Offset = "0x7A88E80", VA = "0x187A8A480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool PGMLIFNBLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7A89C60", Offset = "0x7A88660", VA = "0x187A89C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool HDHLMGIFPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7A89E70", Offset = "0x7A88870", VA = "0x187A89E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool LNBKMENKCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x7A8A4C0", Offset = "0x7A88EC0", VA = "0x187A8A4C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public DOADNBFIEBI IGGHOBGECBO
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DOADNBFIEBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public MCBAMHINKOO ADLJAEEIMCE
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(MCBAMHINKOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public DNNLNJIHDJH HFPLLJDAIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DNNLNJIHDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public IICNEDBLDGN KDDFFNJCJEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(IICNEDBLDGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public PGOGAFPIEBH PNKONDNCBPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(PGOGAFPIEBH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public AIHONIEOCFP JPAIBEMMILK
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(AIHONIEOCFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public KNKFCAKDHNM EPFPABIIPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(KNKFCAKDHNM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public HMGOCGKKIPE CACGNOKDLKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(HMGOCGKKIPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public CDPDFDBGHCC EAMJDLBKEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(CDPDFDBGHCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public FGKMBPHFBOD KOKJACAPJKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(FGKMBPHFBOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public JCMIAKLCBAD ANGKHDAKHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(JCMIAKLCBAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public DNMBIDHEPPD HBDOAGLNPKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DNMBIDHEPPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public JOBBMBDELKD JFHBCOGGJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(JOBBMBDELKD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public PPPFBLLGEEA EDCCIJFOPED
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(PPPFBLLGEEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool BMAAAAAPBJL
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x7A8A6E0", Offset = "0x7A890E0", VA = "0x187A8A6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool KIEGIJCJKPP
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7A89AF0", Offset = "0x7A884F0", VA = "0x187A89AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool JJFGIMGHFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x7A8A060", Offset = "0x7A88A60", VA = "0x187A8A060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool IKAEDGDPHLM
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x7A89B80", Offset = "0x7A88580", VA = "0x187A89B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool LGDILIMAOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7A89BB0", Offset = "0x7A885B0", VA = "0x187A89BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool DJPCDLBHEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7A89E30", Offset = "0x7A88830", VA = "0x187A89E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool PHAMMIGKPBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7A89C20", Offset = "0x7A88620", VA = "0x187A89C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public FBHOENGECJC GKBGOMKDLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(FBHOENGECJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public DDILFEGPMEM HAGLCCJCPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DDILFEGPMEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private HOECEAHHGFN OFJMFPBDKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7A8A630", Offset = "0x7A89030", VA = "0x187A8A630")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
	public static DFLEJIJCDEG MEHFEEABIDG(ECEDHFIPBHO OHLJFNOIPDI)
	{
		return default(DFLEJIJCDEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7A8A7D0", Offset = "0x7A891D0", VA = "0x187A8A7D0")]
	public GAICLDAFDKN PBAGDAJJJCD()
	{
		return default(GAICLDAFDKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7A8A5E0", Offset = "0x7A88FE0", VA = "0x187A8A5E0")]
	public INNHKPCHPIA OBPNHIADJMA()
	{
		return default(INNHKPCHPIA);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7A89B30", Offset = "0x7A88530", VA = "0x187A89B30")]
	public CFPHMAHBLBF AGNLCPNAAEP()
	{
		return default(CFPHMAHBLBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7A8A370", Offset = "0x7A88D70", VA = "0x187A8A370")]
	public GCHFFBPCNCM IDBFKPFGIKO()
	{
		return default(GCHFFBPCNCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7A8A690", Offset = "0x7A89090", VA = "0x187A8A690")]
	public LOEPKKCPDLC OKCDOBPOMHO()
	{
		return default(LOEPKKCPDLC);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7A8A0A0", Offset = "0x7A88AA0", VA = "0x187A8A0A0")]
	public DAKDBBKDPDC GBOLNLCPGJJ()
	{
		return default(DAKDBBKDPDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7A89CA0", Offset = "0x7A886A0", VA = "0x187A89CA0")]
	public void EGLPAJJNKBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7A8A0F0", Offset = "0x7A88AF0", VA = "0x187A8A0F0")]
	public void HEJCAAOAKNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x7A8A190", Offset = "0x7A88B90", VA = "0x187A8A190")]
	public bool HEPCLDGGEMJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x7A8A870", Offset = "0x7A89270", VA = "0x187A8A870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public DFLEJIJCDEG(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x7A88560", Offset = "0x7A86F60", VA = "0x187A88560")]
	public static bool MEHFEEABIDG(DFLEJIJCDEG PPJFMHBDGNA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
	public static ECEDHFIPBHO MEHFEEABIDG(DFLEJIJCDEG PPJFMHBDGNA)
	{
		return default(ECEDHFIPBHO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x7A8A230", Offset = "0x7A88C30", VA = "0x187A8A230")]
	public static bool HFGMMLFJJJB(DFLEJIJCDEG KEEADJCBJCP, DFLEJIJCDEG LKKBJAKGIGL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x7A89B90", Offset = "0x7A88590", VA = "0x187A89B90")]
	public static bool BDABLEIINAG(DFLEJIJCDEG KEEADJCBJCP, DFLEJIJCDEG LKKBJAKGIGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7A89DA0", Offset = "0x7A887A0", VA = "0x187A89DA0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(DFLEJIJCDEG OLKLGHOAKNE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct JOBBMBDELKD : IEquatable<JOBBMBDELKD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private FOBBFIMHMEL GCCDCIOKEDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7A95990", Offset = "0x7A94390", VA = "0x187A95990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private HOECEAHHGFN OFJMFPBDKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7A8A630", Offset = "0x7A89030", VA = "0x187A8A630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private PEBMNHFMPEL FMHELOONJPM
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7A95900", Offset = "0x7A94300", VA = "0x187A95900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x7A959F0", Offset = "0x7A943F0", VA = "0x187A959F0")]
	public void LMMGNPJDNEH(uint ICHIIHCEGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x7A95800", Offset = "0x7A94200", VA = "0x187A95800")]
	public bool FBIDIDOBLAA([Out] uint ICHIIHCEGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x7A95670", Offset = "0x7A94070", VA = "0x187A95670")]
	public bool BEMOKPPMANG([Out] uint ICHIIHCEGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public JOBBMBDELKD(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x7A95770", Offset = "0x7A94170", VA = "0x187A95770", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(JOBBMBDELKD OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct DOADNBFIEBI : IEquatable<DOADNBFIEBI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public RigidTransform KDPEDMMGPOL
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7A8B690", Offset = "0x7A8A090", VA = "0x187A8B690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public float POFGGGLCGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7A8B6F0", Offset = "0x7A8A0F0", VA = "0x187A8B6F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public FBHOENGECJC GKBGOMKDLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(FBHOENGECJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x7A8B410", Offset = "0x7A89E10", VA = "0x187A8B410")]
	public void ANBEGPPEFHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public DOADNBFIEBI(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7A8B600", Offset = "0x7A8A000", VA = "0x187A8B600", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(DOADNBFIEBI OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct MCBAMHINKOO : IEquatable<MCBAMHINKOO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private JHFDFCPCPEN ENEMPJIFJFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7A99980", Offset = "0x7A98380", VA = "0x187A99980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool PLGEANJELLG
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x7A99620", Offset = "0x7A98020", VA = "0x187A99620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public bool LJIKIKBDMPM
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x7A99B00", Offset = "0x7A98500", VA = "0x187A99B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public bool OPJMDAPFEJC
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x7A998C0", Offset = "0x7A982C0", VA = "0x187A998C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Guid HHMDFGPJOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x7A99220", Offset = "0x7A97C20", VA = "0x187A99220")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Guid DPGPIAPPAAC
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x7A99B40", Offset = "0x7A98540", VA = "0x187A99B40")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Guid BMBKDLKMKGF
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x7A996B0", Offset = "0x7A980B0", VA = "0x187A996B0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public DDILFEGPMEM HAGLCCJCPEA
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DDILFEGPMEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private PEBMNHFMPEL FMHELOONJPM
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x7A85DB0", Offset = "0x7A847B0", VA = "0x187A85DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7A994F0", Offset = "0x7A97EF0", VA = "0x187A994F0")]
	public bool FGPANDCFDME([Out] Guid PLGEGLLPNNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7A993C0", Offset = "0x7A97DC0", VA = "0x187A993C0")]
	public bool EBLFPDKAKCN([Out] Guid EGEPAJMBPNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7A992A0", Offset = "0x7A97CA0", VA = "0x187A992A0")]
	public void DPDNNMPMOEA(Guid OILNFPPOKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7A99590", Offset = "0x7A97F90", VA = "0x187A99590")]
	public void FIOELKOJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7A999E0", Offset = "0x7A983E0", VA = "0x187A999E0")]
	public Guid MANLLBGNNGA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public MCBAMHINKOO(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x7A99460", Offset = "0x7A97E60", VA = "0x187A99460", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(MCBAMHINKOO OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public readonly struct CFPHMAHBLBF : IEquatable<CFPHMAHBLBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private EHPGPOEMLFF OMPBFLMJPLB
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7A87F50", Offset = "0x7A86950", VA = "0x187A87F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public Vector3 CFJEJJJIIHB
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7A88410", Offset = "0x7A86E10", VA = "0x187A88410")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Quaternion OOCHKHLMOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7A88580", Offset = "0x7A86F80", VA = "0x187A88580")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public DFLEJIJCDEG DOFAMCDCNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7A88880", Offset = "0x7A87280", VA = "0x187A88880")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private PEBMNHFMPEL FMHELOONJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7A85DB0", Offset = "0x7A847B0", VA = "0x187A85DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7A87FB0", Offset = "0x7A869B0", VA = "0x187A87FB0")]
	public KFKFMJGCIBC EFMJIOEEIAA(Allocator DDBBFOCJEFL)
	{
		return default(KFKFMJGCIBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7A88110", Offset = "0x7A86B10", VA = "0x187A88110")]
	public bool FHFABCJMEFP(DFLEJIJCDEG HGBJMKAPAJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7A882C0", Offset = "0x7A86CC0", VA = "0x187A882C0")]
	public void JAOIDCOCHPF(Vector3 KKIJMCHODGC, Quaternion KONJHPLFEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7A881B0", Offset = "0x7A86BB0", VA = "0x187A881B0")]
	public void HEADBDCNCDM(float GFDDEGDNEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x7A886C0", Offset = "0x7A870C0", VA = "0x187A886C0")]
	public void NPINJAKBEED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public CFPHMAHBLBF(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x7A88560", Offset = "0x7A86F60", VA = "0x187A88560")]
	public static bool MEHFEEABIDG(CFPHMAHBLBF PPJFMHBDGNA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
	public static ECEDHFIPBHO MEHFEEABIDG(CFPHMAHBLBF PPJFMHBDGNA)
	{
		return default(ECEDHFIPBHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x7A88080", Offset = "0x7A86A80", VA = "0x187A88080", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(CFPHMAHBLBF OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct GAICLDAFDKN : IEquatable<GAICLDAFDKN>
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly GAICLDAFDKN BIJHFGIMDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	private CIBKLKDAMDL GKKKEEGLFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7A901C0", Offset = "0x7A8EBC0", VA = "0x187A901C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
	public Span<DFLEJIJCDEG> OOHHONMBFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7A90040", Offset = "0x7A8EA40", VA = "0x187A90040")]
		get
		{
			return default(Span<DFLEJIJCDEG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public string HFKDIDMKBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7A8FA90", Offset = "0x7A8E490", VA = "0x187A8FA90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7A90140", Offset = "0x7A8EB40", VA = "0x187A90140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public FBHOENGECJC GKBGOMKDLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(FBHOENGECJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public DDILFEGPMEM HAGLCCJCPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DDILFEGPMEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private PEBMNHFMPEL FMHELOONJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7A85DB0", Offset = "0x7A847B0", VA = "0x187A85DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x7A8FB10", Offset = "0x7A8E510", VA = "0x187A8FB10")]
	public void DFNCBOGFJII(GAICLDAFDKN OLKLGHOAKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public GAICLDAFDKN(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x7A88560", Offset = "0x7A86F60", VA = "0x187A88560")]
	public static bool MEHFEEABIDG(GAICLDAFDKN PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x7A8FFB0", Offset = "0x7A8E9B0", VA = "0x187A8FFB0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(GAICLDAFDKN OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
	public static DFLEJIJCDEG MEHFEEABIDG(GAICLDAFDKN IJPDNJELPLO)
	{
		return default(DFLEJIJCDEG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public struct CHDEBNCGAPH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Dictionary<int, object> NCNKGDJFDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private IAEIEHMNGOO HKPLIIJLOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool BBNIOJNCAEJ;

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		[CompilerGenerated]
		readonly get
		{
			return default(DFLEJIJCDEG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public LGNEECJPDPC NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7A889C0", Offset = "0x7A873C0", VA = "0x187A889C0")]
		readonly set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x7A88CD0", Offset = "0x7A876D0", VA = "0x187A88CD0")]
	internal CHDEBNCGAPH(DFLEJIJCDEG OIIGDBLKEDN, bool BBNIOJNCAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x7A88BA0", Offset = "0x7A875A0", VA = "0x187A88BA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x34208E0", Offset = "0x341F2E0", VA = "0x1834208E0")]
	public void GFEPEMIDPMH<T>(LGNEECJPDPC NJBPFCDJFGD, T PPJFMHBDGNA, [Optional] T LPJIMLBFHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x7A88AF0", Offset = "0x7A874F0", VA = "0x187A88AF0")]
	public void CBCJJMKDJJC(LGNEECJPDPC NJBPFCDJFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0xD0E7A0", Offset = "0xD0D1A0", VA = "0x180D0E7A0")]
	public Dictionary<int, object> BHACEJOMPKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x7A88A80", Offset = "0x7A87480", VA = "0x187A88A80")]
	private readonly void BINLFMODAMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class FDDKGOPFDAE
{
	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x7A8EBC0", Offset = "0x7A8D5C0", VA = "0x187A8EBC0")]
	public static CHDEBNCGAPH PBHEELJFPGL(this DFLEJIJCDEG OIIGDBLKEDN)
	{
		return default(CHDEBNCGAPH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct PPPFBLLGEEA : IEquatable<PPPFBLLGEEA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public bool DGBAIEBHLKN
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7A9BAE0", Offset = "0x7A9A4E0", VA = "0x187A9BAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 KKLOGMEJOPL
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7A9BBB0", Offset = "0x7A9A5B0", VA = "0x187A9BBB0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7A9B9D0", Offset = "0x7A9A3D0", VA = "0x187A9B9D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7A9BBB0", Offset = "0x7A9A5B0", VA = "0x187A9BBB0")]
	public Vector3 JACPKGNIMOJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7A9BA60", Offset = "0x7A9A460", VA = "0x187A9BA60")]
	public void DDDFNKMLFJB([In] Vector3 PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B9F0", Offset = "0x7A9A3F0", VA = "0x187A9B9F0")]
	public bool CKNIAMHABEP([In] Vector3 PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public PPPFBLLGEEA(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7A9BB20", Offset = "0x7A9A520", VA = "0x187A9BB20", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(PPPFBLLGEEA OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct DEIPDDPDICE : IEquatable<DEIPDDPDICE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7A89A60", Offset = "0x7A88460", VA = "0x187A89A60", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(DEIPDDPDICE OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct DDILFEGPMEM : IEquatable<DDILFEGPMEM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	private CIBKLKDAMDL GKKKEEGLFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7A895F0", Offset = "0x7A87FF0", VA = "0x187A895F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public ECEDHFIPBHO PLLECEBPKEK
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7A89560", Offset = "0x7A87F60", VA = "0x187A89560")]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public DFLEJIJCDEG LKNIONJKNBM
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7A89440", Offset = "0x7A87E40", VA = "0x187A89440")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public DFLEJIJCDEG LKAEGJLGAIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7A894D0", Offset = "0x7A87ED0", VA = "0x187A894D0")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	private PEBMNHFMPEL FMHELOONJPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x7A85DB0", Offset = "0x7A847B0", VA = "0x187A85DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7A88FF0", Offset = "0x7A879F0", VA = "0x187A88FF0")]
	public Span<DFLEJIJCDEG> CLEEEGMEBMK()
	{
		return default(Span<DFLEJIJCDEG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7A89750", Offset = "0x7A88150", VA = "0x187A89750")]
	public Span<DFLEJIJCDEG> NNEFEBNANMB()
	{
		return default(Span<DFLEJIJCDEG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7A89650", Offset = "0x7A88050", VA = "0x187A89650")]
	public Span<DFLEJIJCDEG> MPEKOLOAMBB()
	{
		return default(Span<DFLEJIJCDEG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7A89180", Offset = "0x7A87B80", VA = "0x187A89180")]
	public Span<DFLEJIJCDEG> FFLOMFPELEN()
	{
		return default(Span<DFLEJIJCDEG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7A89850", Offset = "0x7A88250", VA = "0x187A89850")]
	public Span<DFLEJIJCDEG> NOFMAPOLEAM()
	{
		return default(Span<DFLEJIJCDEG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x7A89310", Offset = "0x7A87D10", VA = "0x187A89310")]
	public bool GICBAHPKOCO(DFLEJIJCDEG HGBJMKAPAJA, bool FBMENNFAIPC = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7A88F50", Offset = "0x7A87950", VA = "0x187A88F50")]
	public bool BCPGJBMNFAN(DFLEJIJCDEG OCMOGBOHIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7A89950", Offset = "0x7A88350", VA = "0x187A89950")]
	public DFLEJIJCDEG OPMDFAAKEAM(uint CDOPCAIHBDC)
	{
		return default(DFLEJIJCDEG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7A89280", Offset = "0x7A87C80", VA = "0x187A89280")]
	public GAICLDAFDKN GCNLGGKJNHM()
	{
		return default(GAICLDAFDKN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public DDILFEGPMEM(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7A88560", Offset = "0x7A86F60", VA = "0x187A88560")]
	public static bool MEHFEEABIDG(DDILFEGPMEM PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x7A890F0", Offset = "0x7A87AF0", VA = "0x187A890F0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(DDILFEGPMEM OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct DNNLNJIHDJH : IEquatable<DNNLNJIHDJH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public string EOBMKMINNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7A8B1C0", Offset = "0x7A89BC0", VA = "0x187A8B1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public string BBCHJIPOHCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7A8B090", Offset = "0x7A89A90", VA = "0x187A8B090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	private bool PLINPEHFHHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7A8ACA0", Offset = "0x7A896A0", VA = "0x187A8ACA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public string KNEPJOBMPGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7A8B2D0", Offset = "0x7A89CD0", VA = "0x187A8B2D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public string IPICBJIDLDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7A8AE40", Offset = "0x7A89840", VA = "0x187A8AE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public string EGHAHGMIGJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7A8B380", Offset = "0x7A89D80", VA = "0x187A8B380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public DNNLNJIHDJH(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7A8B240", Offset = "0x7A89C40", VA = "0x187A8B240", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(DNNLNJIHDJH OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct LOEPKKCPDLC : IEquatable<LOEPKKCPDLC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	private EJBDNDBEGED PFLLEKPADKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7A98C40", Offset = "0x7A97640", VA = "0x187A98C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public KDOFINIJEKG JKJIIHNGBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7A983E0", Offset = "0x7A96DE0", VA = "0x187A983E0")]
		get
		{
			return default(KDOFINIJEKG);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7A98EE0", Offset = "0x7A978E0", VA = "0x187A98EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool IEBMFCNPJCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7A984E0", Offset = "0x7A96EE0", VA = "0x187A984E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x7A98570", Offset = "0x7A96F70", VA = "0x187A98570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public FFLBBHGNCDF<string> FAKELDDEBIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x7A98A00", Offset = "0x7A97400", VA = "0x187A98A00")]
		get
		{
			return default(FFLBBHGNCDF<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7A98DC0", Offset = "0x7A977C0", VA = "0x187A98DC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public FFLBBHGNCDF<string> JIPKIDGBOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x7A98610", Offset = "0x7A97010", VA = "0x187A98610")]
		get
		{
			return default(FFLBBHGNCDF<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7A987C0", Offset = "0x7A971C0", VA = "0x187A987C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public FFLBBHGNCDF<string> AMHOGOEEHEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7A98B20", Offset = "0x7A97520", VA = "0x187A98B20")]
		get
		{
			return default(FFLBBHGNCDF<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7A98FF0", Offset = "0x7A979F0", VA = "0x187A98FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public FFLBBHGNCDF<string> DGIDJGGDPAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7A98CA0", Offset = "0x7A976A0", VA = "0x187A98CA0")]
		get
		{
			return default(FFLBBHGNCDF<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7A988E0", Offset = "0x7A972E0", VA = "0x187A988E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	private PEBMNHFMPEL FMHELOONJPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7A85DB0", Offset = "0x7A847B0", VA = "0x187A85DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x7A98340", Offset = "0x7A96D40", VA = "0x187A98340")]
	public bool ABPEAHJMMLD(ECEDHFIPBHO DHJCIPPGLOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public LOEPKKCPDLC(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
	public static ECEDHFIPBHO MEHFEEABIDG(LOEPKKCPDLC PPJFMHBDGNA)
	{
		return default(ECEDHFIPBHO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x7A98730", Offset = "0x7A97130", VA = "0x187A98730", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(LOEPKKCPDLC OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct DOHPLBAKILD : IEquatable<DOHPLBAKILD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7A8B740", Offset = "0x7A8A140", VA = "0x187A8B740", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(DOHPLBAKILD OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct EJBILFKDDGL : IEquatable<EJBILFKDDGL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7A8C090", Offset = "0x7A8AA90", VA = "0x187A8C090", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(EJBILFKDDGL OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct IICNEDBLDGN : IEquatable<IICNEDBLDGN>
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly ComponentTypes FIPBGCLIHLO;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public static readonly IICNEDBLDGN BIJHFGIMDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public Collider HBEFBGGOBAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7A93330", Offset = "0x7A91D30", VA = "0x187A93330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public PAAKCKFKCBH EIHPIABAJGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7A93760", Offset = "0x7A92160", VA = "0x187A93760")]
		get
		{
			return default(PAAKCKFKCBH);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7A93860", Offset = "0x7A92260", VA = "0x187A93860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public EOOPGOCNLLN APIDFIOKOKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7A938B0", Offset = "0x7A922B0", VA = "0x187A938B0")]
		get
		{
			return default(EOOPGOCNLLN);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7A932E0", Offset = "0x7A91CE0", VA = "0x187A932E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public FBKFJPCAJHI DIFILBNOAFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7A93520", Offset = "0x7A91F20", VA = "0x187A93520")]
		get
		{
			return default(FBKFJPCAJHI);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7A92B70", Offset = "0x7A91570", VA = "0x187A92B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public float FIDMKOLBILN
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7A937A0", Offset = "0x7A921A0", VA = "0x187A937A0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7A93290", Offset = "0x7A91C90", VA = "0x187A93290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public bool GKCFEFOBMGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7A93100", Offset = "0x7A91B00", VA = "0x187A93100")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7A93060", Offset = "0x7A91A60", VA = "0x187A93060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public bool NDGHCDGPNMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7A937E0", Offset = "0x7A921E0", VA = "0x187A937E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7A931F0", Offset = "0x7A91BF0", VA = "0x187A931F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public bool BPPBAHAPHKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7A92CB0", Offset = "0x7A916B0", VA = "0x187A92CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x7A93560", Offset = "0x7A91F60", VA = "0x187A93560")]
	public static bool MADIGOLKANE(DFLEJIJCDEG IDNJDDDKPOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x7A92D30", Offset = "0x7A91730", VA = "0x187A92D30")]
	public static bool EHJIJKOKNAC(DFLEJIJCDEG IDNJDDDKPOD, [Out] IICNEDBLDGN JOBOGDBGGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7A92A10", Offset = "0x7A91410", VA = "0x187A92A10")]
	public bool BAKBBJLOLCB([Out] JNHJOIKHAHG GKCCNNFCLIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7A92BC0", Offset = "0x7A915C0", VA = "0x187A92BC0")]
	public bool CAGOJBKFPKA([Out] ECEDHFIPBHO MHHKOMDGDID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x7A92F70", Offset = "0x7A91970", VA = "0x187A92F70")]
	public bool EIPHOBAELML(ECGPIELDBBK ADHFHCKDLLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x7A93170", Offset = "0x7A91B70", VA = "0x187A93170")]
	public void HDHFOCABOGJ(ECGPIELDBBK ADHFHCKDLLB, bool AMLCJKDLNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7A93480", Offset = "0x7A91E80", VA = "0x187A93480")]
	public void LIFCMMEGBAF(ECGPIELDBBK ADHFHCKDLLB, bool AMLCJKDLNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public IICNEDBLDGN(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7A92FD0", Offset = "0x7A919D0", VA = "0x187A92FD0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(IICNEDBLDGN OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7A938F0", Offset = "0x7A922F0", VA = "0x187A938F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct GCHFFBPCNCM : IEquatable<GCHFFBPCNCM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public bool INNDHGPJNJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x7A902B0", Offset = "0x7A8ECB0", VA = "0x187A902B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public GCHFFBPCNCM(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7A90220", Offset = "0x7A8EC20", VA = "0x187A90220", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(GCHFFBPCNCM OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct PGOGAFPIEBH : IEquatable<PGOGAFPIEBH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private KCCJBNPCDBJ BJHDLAJIAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x7A9B5E0", Offset = "0x7A99FE0", VA = "0x187A9B5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private PEBMNHFMPEL FMHELOONJPM
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x7A85DB0", Offset = "0x7A847B0", VA = "0x187A85DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B4B0", Offset = "0x7A99EB0", VA = "0x187A9B4B0")]
	public void DIECEFOLDPB(bool NADKOBBHMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public PGOGAFPIEBH(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B550", Offset = "0x7A99F50", VA = "0x187A9B550", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(PGOGAFPIEBH OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public readonly struct AIHONIEOCFP : IEquatable<AIHONIEOCFP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool JKFBMPDPJPO
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x7A867A0", Offset = "0x7A851A0", VA = "0x187A867A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool OLHIMKPABAC
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x7A86240", Offset = "0x7A84C40", VA = "0x187A86240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool MIEEBELEFBO
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x7A85B70", Offset = "0x7A84570", VA = "0x187A85B70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x7A85DC0", Offset = "0x7A847C0", VA = "0x187A85DC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool NLMNAIHGNEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x7A861B0", Offset = "0x7A84BB0", VA = "0x187A861B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool DFEJJHDBCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x7A86090", Offset = "0x7A84A90", VA = "0x187A86090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool FHFACPOHFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x7A86750", Offset = "0x7A85150", VA = "0x187A86750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool JKLDCMBCFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x7A85BC0", Offset = "0x7A845C0", VA = "0x187A85BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool LEGFLJGFAIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x7A85D00", Offset = "0x7A84700", VA = "0x187A85D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public bool LOFFAIFDLLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x7A85E70", Offset = "0x7A84870", VA = "0x187A85E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public bool LMOILFEGFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x7A86570", Offset = "0x7A84F70", VA = "0x187A86570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool ALDHCKHJKPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x7A86160", Offset = "0x7A84B60", VA = "0x187A86160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public bool PMAKMILBDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x7A85C10", Offset = "0x7A84610", VA = "0x187A85C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public bool MKAJJDLKEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7A86290", Offset = "0x7A84C90", VA = "0x187A86290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public bool BGDIEOLPDCD
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7A86200", Offset = "0x7A84C00", VA = "0x187A86200")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7A862E0", Offset = "0x7A84CE0", VA = "0x187A862E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public LBBNALJLICL NDANPNODPMP
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7A86530", Offset = "0x7A84F30", VA = "0x187A86530")]
		get
		{
			return default(LBBNALJLICL);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x7A85E20", Offset = "0x7A84820", VA = "0x187A85E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool LGPKOPDCNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7A86410", Offset = "0x7A84E10", VA = "0x187A86410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public PPEOEAGKAEB JMLFMMIGNKA
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7A86340", Offset = "0x7A84D40", VA = "0x187A86340")]
		get
		{
			return default(PPEOEAGKAEB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x7A86040", Offset = "0x7A84A40", VA = "0x187A86040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool OOHPKLNMMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x7A86640", Offset = "0x7A85040", VA = "0x187A86640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public Vector3 OANNLFENHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x7A860E0", Offset = "0x7A84AE0", VA = "0x187A860E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public Vector3 HMDHABDDFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x7A865C0", Offset = "0x7A84FC0", VA = "0x187A865C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool JKHHENHNAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x7A85F10", Offset = "0x7A84910", VA = "0x187A85F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private PEBMNHFMPEL FMHELOONJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x7A85DB0", Offset = "0x7A847B0", VA = "0x187A85DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7A85D50", Offset = "0x7A84750", VA = "0x187A85D50")]
	public bool FDFDBEMFLGJ(NNNDPOOLJMK ADHFHCKDLLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7A86380", Offset = "0x7A84D80", VA = "0x187A86380")]
	public void KDMMPKPCEAK(NNNDPOOLJMK ADHFHCKDLLB, bool AMLCJKDLNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x7A85EC0", Offset = "0x7A848C0", VA = "0x187A85EC0")]
	public bool GOGIFOHNHDM(HLDBNBPNCCB ADHFHCKDLLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x7A866D0", Offset = "0x7A850D0", VA = "0x187A866D0")]
	public void NGBCNCCPCFP(HLDBNBPNCCB ADHFHCKDLLB, bool AMLCJKDLNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7A85DE0", Offset = "0x7A847E0", VA = "0x187A85DE0")]
	public HLDBNBPNCCB FJFINJEPMGH()
	{
		return default(HLDBNBPNCCB);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7A86680", Offset = "0x7A85080", VA = "0x187A86680")]
	public bool NDOMELPHBFH(HLDBNBPNCCB PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public AIHONIEOCFP(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C70", Offset = "0x7A84670", VA = "0x187A85C70", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(AIHONIEOCFP OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public readonly struct KNKFCAKDHNM : IEquatable<KNKFCAKDHNM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private KNEDPIAHBEJ DGHPLGCPAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x7A97B10", Offset = "0x7A96510", VA = "0x187A97B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private PEBMNHFMPEL FMHELOONJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x7A85DB0", Offset = "0x7A847B0", VA = "0x187A85DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x7A97C80", Offset = "0x7A96680", VA = "0x187A97C80")]
	public bool LKMGBGEGNLG(PDPDCPPPIIG OAIBEKCJMGA, List<DFLEJIJCDEG> GOKGPKNNGEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7A97B70", Offset = "0x7A96570", VA = "0x187A97B70")]
	public int KGEHHKJEBPO(PDPDCPPPIIG OAIBEKCJMGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7A978F0", Offset = "0x7A962F0", VA = "0x187A978F0")]
	public void HABJIHOBLEL(List<DFLEJIJCDEG> GOKGPKNNGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x7A97600", Offset = "0x7A96000", VA = "0x187A97600")]
	public int BNJEHECAOFH(DFLEJIJCDEG HIKBDNMPFJK, PDPDCPPPIIG OAIBEKCJMGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7A977C0", Offset = "0x7A961C0", VA = "0x187A977C0")]
	public DFLEJIJCDEG FJEIEMEMBBN(int DOAKEFBOPIA, PDPDCPPPIIG OAIBEKCJMGA)
	{
		return default(DFLEJIJCDEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7A97E60", Offset = "0x7A96860", VA = "0x187A97E60")]
	public void NIFKPFLIDDI(DFLEJIJCDEG HIKBDNMPFJK, PDPDCPPPIIG OAIBEKCJMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7A97DB0", Offset = "0x7A967B0", VA = "0x187A97DB0")]
	public bool LNLMAKJLAPL(DFLEJIJCDEG HIKBDNMPFJK, PDPDCPPPIIG OAIBEKCJMGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7A974F0", Offset = "0x7A95EF0", VA = "0x187A974F0")]
	public void AGHDBGNPFHJ(PDPDCPPPIIG OAIBEKCJMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7A97F90", Offset = "0x7A96990", VA = "0x187A97F90")]
	public bool NNDOLOONKFD(DFLEJIJCDEG HIKBDNMPFJK, PDPDCPPPIIG OAIBEKCJMGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7A97A00", Offset = "0x7A96400", VA = "0x187A97A00")]
	public bool HKIPCEOHAKM(PDPDCPPPIIG OAIBEKCJMGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public KNKFCAKDHNM(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7A97730", Offset = "0x7A96130", VA = "0x187A97730", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(KNKFCAKDHNM OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public readonly struct HMGOCGKKIPE : IEquatable<HMGOCGKKIPE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private PEBMNHFMPEL FMHELOONJPM
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x7A85DB0", Offset = "0x7A847B0", VA = "0x187A85DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x7A91A20", Offset = "0x7A90420", VA = "0x187A91A20")]
	public void PMOIMGDEFMB(bool PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x7A91900", Offset = "0x7A90300", VA = "0x187A91900")]
	public void BLIALJOKKKN(bool PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x369F510", Offset = "0x369DF10", VA = "0x18369F510")]
	public T KCGIHLPJGDL<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public HMGOCGKKIPE(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x7A91990", Offset = "0x7A90390", VA = "0x187A91990", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(HMGOCGKKIPE OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct CDPDFDBGHCC : IEquatable<CDPDFDBGHCC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public bool GPGBBPOAJJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x7A87E00", Offset = "0x7A86800", VA = "0x187A87E00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x7A87DB0", Offset = "0x7A867B0", VA = "0x187A87DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public bool IMKNKEGJLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x7A87E40", Offset = "0x7A86840", VA = "0x187A87E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public int BDNMIGBMHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x7A87CE0", Offset = "0x7A866E0", VA = "0x187A87CE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x7A87EC0", Offset = "0x7A868C0", VA = "0x187A87EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	private PEBMNHFMPEL FMHELOONJPM
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x7A85DB0", Offset = "0x7A847B0", VA = "0x187A85DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public CDPDFDBGHCC(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7A87D20", Offset = "0x7A86720", VA = "0x187A87D20", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(CDPDFDBGHCC OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct NJPMHPIPHBM : IEquatable<NJPMHPIPHBM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public int FDPIMPCMEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x7A9A240", Offset = "0x7A98C40", VA = "0x187A9A240")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x7A9A2D0", Offset = "0x7A98CD0", VA = "0x187A9A2D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public int ELLAKJKABAG
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x7A9A170", Offset = "0x7A98B70", VA = "0x187A9A170")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x7A9A280", Offset = "0x7A98C80", VA = "0x187A9A280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public NJPMHPIPHBM(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7A9A1B0", Offset = "0x7A98BB0", VA = "0x187A9A1B0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(NJPMHPIPHBM OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public readonly struct FGKMBPHFBOD : IEquatable<FGKMBPHFBOD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	private HDEPPMKMBLP ILIGJHBCHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F8F0", Offset = "0x7A8E2F0", VA = "0x187A8F8F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private HIBGAOKPNFD MINGGMFHNOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F560", Offset = "0x7A8DF60", VA = "0x187A8F560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public bool GMGHIKNFLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F7C0", Offset = "0x7A8E1C0", VA = "0x187A8F7C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool CNHDFPIKMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F4C0", Offset = "0x7A8DEC0", VA = "0x187A8F4C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public bool FCHPNPCHLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x7A8EEA0", Offset = "0x7A8D8A0", VA = "0x187A8EEA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public bool NHDCEDGIBJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F5C0", Offset = "0x7A8DFC0", VA = "0x187A8F5C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public bool LHFHNMPHONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x7A8EF60", Offset = "0x7A8D960", VA = "0x187A8EF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool ELMLKENFDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7A8ED60", Offset = "0x7A8D760", VA = "0x187A8ED60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public bool EPGHNBPHBNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F110", Offset = "0x7A8DB10", VA = "0x187A8F110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public bool GFFPDCFOJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F350", Offset = "0x7A8DD50", VA = "0x187A8F350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public bool LDMNOANGMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F690", Offset = "0x7A8E090", VA = "0x187A8F690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	private PEBMNHFMPEL FMHELOONJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7A85DB0", Offset = "0x7A847B0", VA = "0x187A85DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x7A8EF90", Offset = "0x7A8D990", VA = "0x187A8EF90")]
	public bool IHMHCFPNGED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x7A8F950", Offset = "0x7A8E350", VA = "0x187A8F950")]
	public DFLEJIJCDEG PHBCEIBJPJG(DFLEJIJCDEG HIKBDNMPFJK)
	{
		return default(DFLEJIJCDEG);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7A8F000", Offset = "0x7A8DA00", VA = "0x187A8F000")]
	public ECEDHFIPBHO IJFEOCHBPCH()
	{
		return default(ECEDHFIPBHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7A8F850", Offset = "0x7A8E250", VA = "0x187A8F850")]
	public bool ONLHBELNDGC(ECEDHFIPBHO IOPABKBJPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x7A8F2B0", Offset = "0x7A8DCB0", VA = "0x187A8F2B0")]
	public bool LNCHNLJMHFP(ECEDHFIPBHO BPECEKEAEGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x7A8EDF0", Offset = "0x7A8D7F0", VA = "0x187A8EDF0")]
	public bool DBKMNJFGDHO(ECEDHFIPBHO HIKBDNMPFJK, [Out] ECEDHFIPBHO IOPABKBJPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public FGKMBPHFBOD(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7A88560", Offset = "0x7A86F60", VA = "0x187A88560")]
	public static bool MEHFEEABIDG(FGKMBPHFBOD PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x7A8EED0", Offset = "0x7A8D8D0", VA = "0x187A8EED0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(FGKMBPHFBOD OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct INNHKPCHPIA : IEquatable<INNHKPCHPIA>
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly INNHKPCHPIA BIJHFGIMDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public CPEEJIKFAAE LLICMCNEDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x7A94240", Offset = "0x7A92C40", VA = "0x187A94240")]
		get
		{
			return default(CPEEJIKFAAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public EJODAALJJDB NAFKEKHKPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7A93D80", Offset = "0x7A92780", VA = "0x187A93D80")]
		get
		{
			return default(EJODAALJJDB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7A94170", Offset = "0x7A92B70", VA = "0x187A94170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public IHJHIPFBKPL LFCKJDCIBED
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7A93FC0", Offset = "0x7A929C0", VA = "0x187A93FC0")]
		get
		{
			return default(IHJHIPFBKPL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7A94280", Offset = "0x7A92C80", VA = "0x187A94280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public float IJBJDKPIOFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7A94000", Offset = "0x7A92A00", VA = "0x187A94000")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x7A93F70", Offset = "0x7A92970", VA = "0x187A93F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public Vector3 BHIFJEJJFGM
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7A941C0", Offset = "0x7A92BC0", VA = "0x187A941C0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7A93EB0", Offset = "0x7A928B0", VA = "0x187A93EB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public float GHFAOALAGMF
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7A93E60", Offset = "0x7A92860", VA = "0x187A93E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public FFELHMGLKAD GKALKMPIJCI
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7A94040", Offset = "0x7A92A40", VA = "0x187A94040")]
		get
		{
			return default(FFELHMGLKAD);
		}
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7A942D0", Offset = "0x7A92CD0", VA = "0x187A942D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public bool DNAFPIBDLMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7A93F30", Offset = "0x7A92930", VA = "0x187A93F30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7A94080", Offset = "0x7A92A80", VA = "0x187A94080")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public FBHOENGECJC GKBGOMKDLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(FBHOENGECJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public DDILFEGPMEM HAGLCCJCPEA
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DDILFEGPMEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x7A94320", Offset = "0x7A92D20", VA = "0x187A94320")]
	public CPHNEMINGLO OPFLDIGHHEB()
	{
		return default(CPHNEMINGLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x7A93E10", Offset = "0x7A92810", VA = "0x187A93E10")]
	public KJHHHBLLAOE AOFGHHDIMAA()
	{
		return default(KJHHHBLLAOE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x7A93DC0", Offset = "0x7A927C0", VA = "0x187A93DC0")]
	private bool ALJFOJEOKGC(FFELHMGLKAD ADHFHCKDLLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x7A94370", Offset = "0x7A92D70", VA = "0x187A94370")]
	public void PIHKHMDOKNB(FFELHMGLKAD ADHFHCKDLLB, bool AMLCJKDLNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public INNHKPCHPIA(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x7A88560", Offset = "0x7A86F60", VA = "0x187A88560")]
	public static bool MEHFEEABIDG(INNHKPCHPIA PPJFMHBDGNA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x7A89B90", Offset = "0x7A88590", VA = "0x187A89B90")]
	public static bool BDABLEIINAG(INNHKPCHPIA KEEADJCBJCP, INNHKPCHPIA LKKBJAKGIGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x7A940E0", Offset = "0x7A92AE0", VA = "0x187A940E0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(INNHKPCHPIA OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct CPHNEMINGLO : IEquatable<CPHNEMINGLO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public INNHKPCHPIA NNCCBHJKJKB
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(INNHKPCHPIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public AHBNMJGLFPD IINCIAONFCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7A88DA0", Offset = "0x7A877A0", VA = "0x187A88DA0")]
		get
		{
			return default(AHBNMJGLFPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public CPHNEMINGLO(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x7A88560", Offset = "0x7A86F60", VA = "0x187A88560")]
	public static bool MEHFEEABIDG(CPHNEMINGLO PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x7A88DE0", Offset = "0x7A877E0", VA = "0x187A88DE0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(CPHNEMINGLO OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[DefaultMember("Item")]
public readonly struct KJHHHBLLAOE : IEquatable<KJHHHBLLAOE>
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public static readonly KJHHHBLLAOE BIJHFGIMDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	private ILPFMHBELGI PKOFGMJALIK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x7A97240", Offset = "0x7A95C40", VA = "0x187A97240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public INNHKPCHPIA NNCCBHJKJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(INNHKPCHPIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public JPHEOFPJKHK GPLEEPMJFGI
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x7A96C00", Offset = "0x7A95600", VA = "0x187A96C00")]
		get
		{
			return default(JPHEOFPJKHK);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x7A97340", Offset = "0x7A95D40", VA = "0x187A97340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public IEnumerable<NKLIGKJDPMF> KIOPEONEENC
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x7A97050", Offset = "0x7A95A50", VA = "0x187A97050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public NKLIGKJDPMF NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x7A96F40", Offset = "0x7A95940", VA = "0x187A96F40")]
		get
		{
			return default(NKLIGKJDPMF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x7A968B0", Offset = "0x7A952B0", VA = "0x187A968B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public FBHOENGECJC GKBGOMKDLDP
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(FBHOENGECJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	private PEBMNHFMPEL FMHELOONJPM
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7A85DB0", Offset = "0x7A847B0", VA = "0x187A85DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7A96D20", Offset = "0x7A95720", VA = "0x187A96D20")]
	public NKLIGKJDPMF GAMFPBEINAD(float3? KKIJMCHODGC, [Optional] quaternion? KONJHPLFEME, [Optional] Vector3? GFDDEGDNEEN)
	{
		return default(NKLIGKJDPMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x7A96940", Offset = "0x7A95340", VA = "0x187A96940")]
	public NKLIGKJDPMF EECGMKNAFDF(int DOAKEFBOPIA, float3? KKIJMCHODGC, [Optional] quaternion? KONJHPLFEME, [Optional] Vector3? GFDDEGDNEEN)
	{
		return default(NKLIGKJDPMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x7A972A0", Offset = "0x7A95CA0", VA = "0x187A972A0")]
	public void MEANJLPEEFF(int DOAKEFBOPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x7A97460", Offset = "0x7A95E60", VA = "0x187A97460")]
	public void OPINELCICKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public KJHHHBLLAOE(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x7A88560", Offset = "0x7A86F60", VA = "0x187A88560")]
	public static bool MEHFEEABIDG(KJHHHBLLAOE PPJFMHBDGNA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x7A8A230", Offset = "0x7A88C30", VA = "0x187A8A230")]
	public static bool HFGMMLFJJJB(KJHHHBLLAOE KEEADJCBJCP, KJHHHBLLAOE LKKBJAKGIGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x7A96B70", Offset = "0x7A95570", VA = "0x187A96B70", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(KJHHHBLLAOE OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct NKLIGKJDPMF : IEquatable<NKLIGKJDPMF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public KJHHHBLLAOE CIPKLMBDIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7A9A510", Offset = "0x7A98F10", VA = "0x187A9A510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public float3 GLJBENMMLGO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7A9A5A0", Offset = "0x7A98FA0", VA = "0x187A9A5A0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7A9A370", Offset = "0x7A98D70", VA = "0x187A9A370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public quaternion GDFHKBKNAFF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7A9A4C0", Offset = "0x7A98EC0", VA = "0x187A9A4C0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x7A9A660", Offset = "0x7A99060", VA = "0x187A9A660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public float3 MEIJPBHHPCE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7A9A600", Offset = "0x7A99000", VA = "0x187A9A600")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7A9A460", Offset = "0x7A98E60", VA = "0x187A9A460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public BBOGLCEBAKD PGAAKHCADPM
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x7A9A320", Offset = "0x7A98D20", VA = "0x187A9A320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x7A9A590", Offset = "0x7A98F90", VA = "0x187A9A590")]
	public void JMMIACKEPHD(KJHHHBLLAOE PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public NKLIGKJDPMF(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x7A9A3D0", Offset = "0x7A98DD0", VA = "0x187A9A3D0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(NKLIGKJDPMF OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct DAKDBBKDPDC : IEquatable<DAKDBBKDPDC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public bool FEKJIMMBFJL
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x7A88F00", Offset = "0x7A87900", VA = "0x187A88F00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public DAKDBBKDPDC(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x7A88E70", Offset = "0x7A87870", VA = "0x187A88E70", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(DAKDBBKDPDC OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct JCMIAKLCBAD : IEquatable<JCMIAKLCBAD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	private INGBMGBGOAB OGHAMMLLMKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7A94A80", Offset = "0x7A93480", VA = "0x187A94A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	public bool PONPFOLFDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7A94540", Offset = "0x7A92F40", VA = "0x187A94540")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7A947D0", Offset = "0x7A931D0", VA = "0x187A947D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	public bool BNHELEPIOAB
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x7A94E00", Offset = "0x7A93800", VA = "0x187A94E00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7A94440", Offset = "0x7A92E40", VA = "0x187A94440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public float NGDCLFBKNJC
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x7A94FD0", Offset = "0x7A939D0", VA = "0x187A94FD0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x7A94A30", Offset = "0x7A93430", VA = "0x187A94A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public bool NOIDKCAMOIL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x7A94F80", Offset = "0x7A93980", VA = "0x187A94F80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	private PEBMNHFMPEL FMHELOONJPM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7A85DB0", Offset = "0x7A847B0", VA = "0x187A85DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x7A944A0", Offset = "0x7A92EA0", VA = "0x187A944A0")]
	public void DIJBKNHGHFI(int NMGLJLCLAKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x7A94590", Offset = "0x7A92F90", VA = "0x187A94590")]
	public bool EGJBEAJDHFC([Out] int NMGLJLCLAKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x7A94990", Offset = "0x7A93390", VA = "0x187A94990")]
	public void FOCGMNOLINO(bool IODPHBLPIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x7A94940", Offset = "0x7A93340", VA = "0x187A94940")]
	public bool FGINALEGPIH(EBEKHIBDNAC ADHFHCKDLLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x7A94830", Offset = "0x7A93230", VA = "0x187A94830")]
	public void ENCCGHIBHDN(EBEKHIBDNAC ADHFHCKDLLB, bool AMLCJKDLNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x7A94AE0", Offset = "0x7A934E0", VA = "0x187A94AE0")]
	public void JGNMMNBHKLN(float IKNLKGPAJFK, float GHMJCFCPDHG, float EFOOMNIJPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x7A94CB0", Offset = "0x7A936B0", VA = "0x187A94CB0")]
	public void LBANIMICJJM(float3 OFFDJDPGHEJ, quaternion GPFAHJPKNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7A94E50", Offset = "0x7A93850", VA = "0x187A94E50")]
	public bool PCLJFHDMFGM([Out] float3 OFFDJDPGHEJ, [Out] quaternion GPFAHJPKNMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7A946A0", Offset = "0x7A930A0", VA = "0x187A946A0")]
	public bool EGOAMDOGBFE([Out] float LBCHCLEHNMJ, [Out] float CGPLKCIGLEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x7A94C20", Offset = "0x7A93620", VA = "0x187A94C20")]
	public void JLKOOGDILEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public JCMIAKLCBAD(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7A948B0", Offset = "0x7A932B0", VA = "0x187A948B0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(JCMIAKLCBAD OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct FBHOENGECJC : IEquatable<FBHOENGECJC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	private PDMBJJLECEJ EGFCDJKOFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CDC0", Offset = "0x7A8B7C0", VA = "0x187A8CDC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public Vector3 GLJBENMMLGO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7A8E360", Offset = "0x7A8CD60", VA = "0x187A8E360")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x7A8D610", Offset = "0x7A8C010", VA = "0x187A8D610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public Quaternion GDFHKBKNAFF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7A8E120", Offset = "0x7A8CB20", VA = "0x187A8E120")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7A8EAF0", Offset = "0x7A8D4F0", VA = "0x187A8EAF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public Vector3 FKJGNPDLIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x7A8E540", Offset = "0x7A8CF40", VA = "0x187A8E540")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x7A8D2E0", Offset = "0x7A8BCE0", VA = "0x187A8D2E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	public Quaternion LPIDAMMACLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x7A8DD70", Offset = "0x7A8C770", VA = "0x187A8DD70")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x7A8DB10", Offset = "0x7A8C510", VA = "0x187A8DB10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	public float POFGGGLCGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x7A8E080", Offset = "0x7A8CA80", VA = "0x187A8E080")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x7A8E630", Offset = "0x7A8D030", VA = "0x187A8E630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public float MMEODJGGKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x7A8E930", Offset = "0x7A8D330", VA = "0x187A8E930")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	public Matrix4x4 LOGGAOJNKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x7A8E320", Offset = "0x7A8CD20", VA = "0x187A8E320")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public DDILFEGPMEM HAGLCCJCPEA
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DDILFEGPMEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	private HOECEAHHGFN OFJMFPBDKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x7A8A630", Offset = "0x7A89030", VA = "0x187A8A630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x7A8E8E0", Offset = "0x7A8D2E0", VA = "0x187A8E8E0")]
	public FJCDPKDIACD PAIAHGLJOBK()
	{
		return default(FJCDPKDIACD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x7A8E9D0", Offset = "0x7A8D3D0", VA = "0x187A8E9D0")]
	public void PNNHENKNGBF([Out] Matrix4x4 FFKIELGPMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DF80", Offset = "0x7A8C980", VA = "0x187A8DF80")]
	public void HILEIEHJGEB([In] Vector3 GHOLIOPECPJ, [In] Quaternion BOFAHJJKKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DEC0", Offset = "0x7A8C8C0", VA = "0x187A8DEC0")]
	public void HILEIEHJGEB([In] RigidTransform IGPHINOBAOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x7A8CD10", Offset = "0x7A8B710", VA = "0x187A8CD10")]
	public void ABALKFLJLGK([Out] RigidTransform IGPHINOBAOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x7A8D7A0", Offset = "0x7A8C1A0", VA = "0x187A8D7A0")]
	public void EIGHIBGNEMH([In] Vector3 MOPDMNELODI, [In] Quaternion NAONAOOKAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x7A8D6E0", Offset = "0x7A8C0E0", VA = "0x187A8D6E0")]
	public void EIGHIBGNEMH([In] RigidTransform LMHMPOPBLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x7A8D480", Offset = "0x7A8BE80", VA = "0x187A8D480")]
	public void ECPOILFKELB([Out] Vector3 MOPDMNELODI, [Out] Quaternion NAONAOOKAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x7A8D560", Offset = "0x7A8BF60", VA = "0x187A8D560")]
	public void ECPOILFKELB([Out] RigidTransform IGPHINOBAOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DA20", Offset = "0x7A8C420", VA = "0x187A8DA20")]
	public UniformTRS GCJODMGBDOE()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DA50", Offset = "0x7A8C450", VA = "0x187A8DA50")]
	public void GCJODMGBDOE([Out] UniformTRS LMHMPOPBLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x7A8E450", Offset = "0x7A8CE50", VA = "0x187A8E450")]
	public UniformTRS MIEFCFNLFJG()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x7A8E480", Offset = "0x7A8CE80", VA = "0x187A8E480")]
	public void MIEFCFNLFJG([Out] UniformTRS IGPHINOBAOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x7A8D930", Offset = "0x7A8C330", VA = "0x187A8D930")]
	public Vector3 FDKGDGCPFFC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x7A8CF50", Offset = "0x7A8B950", VA = "0x187A8CF50")]
	public void BPDCPNDKKLC([In] Vector3 PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DBE0", Offset = "0x7A8C5E0", VA = "0x187A8DBE0")]
	public Vector3 GFINIOFAHGL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x7A8D170", Offset = "0x7A8BB70", VA = "0x187A8D170")]
	public void DGFIBDIACDI([In] Vector3 PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x7A8D020", Offset = "0x7A8BA20", VA = "0x187A8D020")]
	public Quaternion CCCNEMCFPKJ()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x7A8CE80", Offset = "0x7A8B880", VA = "0x187A8CE80")]
	public void AMEBKEOALFB([In] Quaternion PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x7A8E6E0", Offset = "0x7A8D0E0", VA = "0x187A8E6E0")]
	public Quaternion NDFGFHNEMCK()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7A8D3B0", Offset = "0x7A8BDB0", VA = "0x187A8D3B0")]
	public void DMEDAOBMBPP([In] Quaternion PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DCD0", Offset = "0x7A8C6D0", VA = "0x187A8DCD0")]
	public float GHFEINFKBPP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x7A8E830", Offset = "0x7A8D230", VA = "0x187A8E830")]
	public void OGEGIGPJJLB(float PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x7A8D240", Offset = "0x7A8BC40", VA = "0x187A8D240")]
	public float DHDEKODFMMH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x7A8E270", Offset = "0x7A8CC70", VA = "0x187A8E270")]
	public void IKLDCKJBPJK(float PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public FBHOENGECJC(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x7A8D8A0", Offset = "0x7A8C2A0", VA = "0x187A8D8A0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(FBHOENGECJC OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public readonly struct DNMBIDHEPPD : IEquatable<DNMBIDHEPPD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	private GIAOHCJKLEE BEDAPMHFJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x7A8AB00", Offset = "0x7A89500", VA = "0x187A8AB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	private PEBMNHFMPEL FMHELOONJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x7A85DB0", Offset = "0x7A847B0", VA = "0x187A85DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x7A8AB60", Offset = "0x7A89560", VA = "0x187A8AB60")]
	public void JOJHEOIACGK(string FDBECNGFMME, EMJFOIOODEA DOOFKBLICCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public DNMBIDHEPPD(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x7A8AA70", Offset = "0x7A89470", VA = "0x187A8AA70", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(DNMBIDHEPPD OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x7A867E0", Offset = "0x7A851E0", VA = "0x187A867E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct JKCBJMIPLDD : IEquatable<JKCBJMIPLDD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public NLLAEBLBHHD IDIIMACDAMM
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x7A95520", Offset = "0x7A93F20", VA = "0x187A95520")]
		get
		{
			return default(NLLAEBLBHHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public JKCBJMIPLDD(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x7A95490", Offset = "0x7A93E90", VA = "0x187A95490", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(JKCBJMIPLDD OLKLGHOAKNE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct HENMDPFGPFG : IEquatable<HENMDPFGPFG>
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public struct LDFDBMFJDOL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private ECEDHFIPBHO CEJEEJJKEJL;

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x7A982A0", Offset = "0x7A96CA0", VA = "0x187A982A0")]
		public LDFDBMFJDOL(ECEDHFIPBHO CEJEEJJKEJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x7A98210", Offset = "0x7A96C10", VA = "0x187A98210", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x7A90E00", Offset = "0x7A8F800", VA = "0x187A90E00")]
	public LDFDBMFJDOL DCFJHBDGKOB()
	{
		return default(LDFDBMFJDOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x7A91050", Offset = "0x7A8FA50", VA = "0x187A91050")]
	public CAIGGAIEPFI GHLEGGCDKIP(Allocator DDBBFOCJEFL = Allocator.Temp)
	{
		return default(CAIGGAIEPFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x7A90F20", Offset = "0x7A8F920", VA = "0x187A90F20")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> FNOHDDLDHLM(Allocator DDBBFOCJEFL = Allocator.Temp)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x7A91140", Offset = "0x7A8FB40", VA = "0x187A91140")]
	public NativeArray<MNGNDNIEHNP> GKCPNHOBDOP(Allocator DDBBFOCJEFL = Allocator.Temp)
	{
		return default(NativeArray<MNGNDNIEHNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x7A91370", Offset = "0x7A8FD70", VA = "0x187A91370")]
	public NativeArray<MNGNDNIEHNP> MEAGOHGFGHP(Allocator DDBBFOCJEFL = Allocator.Temp)
	{
		return default(NativeArray<MNGNDNIEHNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x7A911F0", Offset = "0x7A8FBF0", VA = "0x187A911F0")]
	public KFKFMJGCIBC HLABNMEDAHL(Allocator DDBBFOCJEFL = Allocator.Temp)
	{
		return default(KFKFMJGCIBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x7A912B0", Offset = "0x7A8FCB0", VA = "0x187A912B0")]
	public KFKFMJGCIBC HNCGFECDPKL(Allocator DDBBFOCJEFL = Allocator.Temp)
	{
		return default(KFKFMJGCIBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x7A91420", Offset = "0x7A8FE20", VA = "0x187A91420")]
	public KFKFMJGCIBC NHIHMEBDCEF(Allocator DDBBFOCJEFL = Allocator.Temp)
	{
		return default(KFKFMJGCIBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public HENMDPFGPFG(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x7A90E90", Offset = "0x7A8F890", VA = "0x187A90E90", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(HENMDPFGPFG OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x7A87BC0", Offset = "0x7A865C0", VA = "0x187A87BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct GMPKABBHCEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int IECIHJOBNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int IIFKBMNDIIG;
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public readonly struct BKBJBOFJLGE : IEquatable<BKBJBOFJLGE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public HENMDPFGPFG MJHBNFBKANC
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(HENMDPFGPFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public PFJADNNDMHK KIEKGOJDOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(PFJADNNDMHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public JKCBJMIPLDD MNNCEPIAOME
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(JKCBJMIPLDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x7A87B20", Offset = "0x7A86520", VA = "0x187A87B20")]
	public bool NDBGMCPNCBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x7A879A0", Offset = "0x7A863A0", VA = "0x187A879A0")]
	public bool KLIIKNBHLGA([Out] Exception CHDFBHPMACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public BKBJBOFJLGE(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
	public static ECEDHFIPBHO MEHFEEABIDG(BKBJBOFJLGE PPJFMHBDGNA)
	{
		return default(ECEDHFIPBHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7A87910", Offset = "0x7A86310", VA = "0x187A87910", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(BKBJBOFJLGE OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x7A87BC0", Offset = "0x7A865C0", VA = "0x187A87BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public readonly struct JJOBNFNOHNN : IDisposable, IEquatable<JJOBNFNOHNN>
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public static readonly JJOBNFNOHNN BIJHFGIMDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public BKBJBOFJLGE CJOACOKAAPA
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(BKBJBOFJLGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public HENMDPFGPFG MJHBNFBKANC
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(HENMDPFGPFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7A95240", Offset = "0x7A93C40", VA = "0x187A95240", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public JJOBNFNOHNN(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x7A95310", Offset = "0x7A93D10", VA = "0x187A95310", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "5")]
	public bool Equals(JJOBNFNOHNN OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7A953A0", Offset = "0x7A93DA0", VA = "0x187A953A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct PFJADNNDMHK : IEquatable<PFJADNNDMHK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public bool NLILDIAANHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x7A9B390", Offset = "0x7A99D90", VA = "0x187A9B390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	public PFJADNNDMHK(ECEDHFIPBHO CEJEEJJKEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x7A86010", Offset = "0x7A84A10", VA = "0x187A86010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B420", Offset = "0x7A99E20", VA = "0x187A9B420", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x7A85C60", Offset = "0x7A84660", VA = "0x187A85C60", Slot = "4")]
	public bool Equals(PFJADNNDMHK OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x7A87BC0", Offset = "0x7A865C0", VA = "0x187A87BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class LDEICOACALO
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private struct HNPBKKNGDCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Guid BIGAPECKJPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public FGCMPAFJJKN IHAKALCGMCD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	private struct FGCMPAFJJKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int PPJFMHBDGNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int JEEFCHKEHJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int FGDBOPKBMND;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int HALLAIPNLKB;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x7A8EC80", Offset = "0x7A8D680", VA = "0x187A8EC80")]
		public bool GLBGDJIAFCA([Out] MNGNDNIEHNP NBMFEEBJLOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x7A8ED20", Offset = "0x7A8D720", VA = "0x187A8ED20")]
		public FGCMPAFJJKN(MNGNDNIEHNP NBMFEEBJLOH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x7A98170", Offset = "0x7A96B70", VA = "0x187A98170")]
	public static Guid JIFBPBKNABA(this MNGNDNIEHNP NBMFEEBJLOH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x7A98150", Offset = "0x7A96B50", VA = "0x187A98150")]
	public static bool BBNIFLFNKAL(this Guid BIGAPECKJPI, [Out] MNGNDNIEHNP NBMFEEBJLOH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal static class BIFJJBOAAFM
{
	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x7A87540", Offset = "0x7A85F40", VA = "0x187A87540")]
	public static PEBMNHFMPEL FMHELOONJPM(this ECEDHFIPBHO ICHIIHCEGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7A874E0", Offset = "0x7A85EE0", VA = "0x187A874E0")]
	public static MIAJELHJLFO CGCFOLKHODC(this ECEDHFIPBHO ICHIIHCEGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x7A875D0", Offset = "0x7A85FD0", VA = "0x187A875D0")]
	public static EntityManager JIDOJAHOFHN(this ECEDHFIPBHO ICHIIHCEGJD)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x33B7030", Offset = "0x33B5A30", VA = "0x1833B7030")]
	internal static bool PMPDOAHKCHN<T>(this ECEDHFIPBHO ICHIIHCEGJD, bool AMLCJKDLNFI) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x7A873D0", Offset = "0x7A85DD0", VA = "0x187A873D0")]
	public static bool BJEJHIEGNPA(this ECEDHFIPBHO ICHIIHCEGJD, DBDIPFEPNDG LDIFMBFDAPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x33B4B10", Offset = "0x33B3510", VA = "0x1833B4B10")]
	public static bool GOIPOMPHMLB<T>(this ECEDHFIPBHO ICHIIHCEGJD) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x33B6F80", Offset = "0x33B5980", VA = "0x1833B6F80")]
	public static bool LKNABGFKCDL<T>(this ECEDHFIPBHO ICHIIHCEGJD) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x33B5330", Offset = "0x33B3D30", VA = "0x1833B5330")]
	[DPDNONLPJKK]
	public static T JGNNPMDFGOL<T>(this ECEDHFIPBHO ICHIIHCEGJD) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x33B20E0", Offset = "0x33B0AE0", VA = "0x1833B20E0")]
	[DPDNONLPJKK]
	public static T GGBGJNHEHIG<T>(this ECEDHFIPBHO ICHIIHCEGJD) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x33B1FA0", Offset = "0x33B09A0", VA = "0x1833B1FA0")]
	public static bool BDAGNGBKDPI<T>(this ECEDHFIPBHO ICHIIHCEGJD, [Out] T PPJFMHBDGNA) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x33B6EB0", Offset = "0x33B58B0", VA = "0x1833B6EB0")]
	public static T JPHNPLHHEFM<T>(this ECEDHFIPBHO ICHIIHCEGJD) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x33B2040", Offset = "0x33B0A40", VA = "0x1833B2040")]
	public static T FAAJIEHMNNN<T>(this ECEDHFIPBHO ICHIIHCEGJD) where T : class, IComponentData
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
internal static class FGPHPFIKBIB
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[DefaultMember("Item")]
public struct CAIGGAIEPFI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private KFKFMJGCIBC KKMIKMKCMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> NBGBLKIEDMF;

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x5901590", Offset = "0x58FFF90", VA = "0x185901590")]
	public CAIGGAIEPFI(KFKFMJGCIBC KKMIKMKCMKE, NativeArray<EntityRemapUtility.EntityRemapInfo> NBGBLKIEDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x7A87CA0", Offset = "0x7A866A0", VA = "0x187A87CA0")]
	public LocalId ECIGFMPCCOA(LocalId OIIGDBLKEDN)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x7A87C50", Offset = "0x7A86650", VA = "0x187A87C50")]
	public LocalId ECIGFMPCCOA(int DOAKEFBOPIA)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x7A87BE0", Offset = "0x7A865E0", VA = "0x187A87BE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JHFDFCPCPEN
{
	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	Guid KEBHHGIKNED
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	Guid HOCMNHGGLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PLGEANJELLG(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task LMPJGGLHMHD(DFLEJIJCDEG OIIGDBLKEDN);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid MANLLBGNNGA(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DPDNNMPMOEA(ECEDHFIPBHO CEJEEJJKEJL, Guid EGEPAJMBPNL);

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FIOELKOJOBO(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task CJBIGMFIEHD(ECEDHFIPBHO CGGKEPFNHFP, ECEDHFIPBHO HGBJMKAPAJA);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ABDCHADJNCL
{
	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	Guid KEBHHGIKNED
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KABLOOJKMGN(NativeList<Guid> PEOOMLDNGKD, NativeList<Guid> AELNLBJIDLC, NativeList<FixedString64Bytes> FKCOIMFLJJO);
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OHIIOHLNKLF
{
	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KFKFMJGCIBC EKBMNEGENPO(Allocator DDBBFOCJEFL);

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KFKFMJGCIBC CNKCGKDLFOC(Allocator DDBBFOCJEFL);

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DGPGGELMLCI(ECEDHFIPBHO HDDPFCMNNBA);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IMKNKEGJLPJ(ECEDHFIPBHO HDDPFCMNNBA);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GPGBBPOAJJG(ECEDHFIPBHO HDDPFCMNNBA);

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JPKLKJCCHAI(ECEDHFIPBHO HDDPFCMNNBA, int DJPDBDCCOEF);

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ECEDHFIPBHO AJACDMHMCNM(ECEDHFIPBHO ADJCACCAJIF);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FCFHEBBKIKH(KFKFMJGCIBC HOBPLOGKOBP, bool IHCDPLOLLOD);

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LPLIODCMLCP(ECEDHFIPBHO OHLJFNOIPDI);

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool IFONFEDCFPJ(ECEDHFIPBHO HDDPFCMNNBA);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JELALGPMKDK(ECEDHFIPBHO HDDPFCMNNBA, bool MGGILBFLONI);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int AJOEKICMPCB();
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EHPGPOEMLFF
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<ECEDHFIPBHO, ECEDHFIPBHO> OIPKDLLKJDD;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<ECEDHFIPBHO, ECEDHFIPBHO> NEAGNFGIGIN;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<ECEDHFIPBHO, ECEDHFIPBHO, ECEDHFIPBHO> LOJDIIMPAIA;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<ECEDHFIPBHO> DGOCFBCDBLA;

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FHFABCJMEFP(ECEDHFIPBHO CEJEEJJKEJL, ECEDHFIPBHO LEBNFOHPGEK);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ECEDHFIPBHO PIJPHEPKHOC(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KFKFMJGCIBC EFMJIOEEIAA(ECEDHFIPBHO CEJEEJJKEJL, Allocator DDBBFOCJEFL);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ECEDHFIPBHO GFLODBNMOHA(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JAOIDCOCHPF(ECEDHFIPBHO CEJEEJJKEJL, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HEADBDCNCDM(ECEDHFIPBHO CEJEEJJKEJL, float EOLODPHLAFO);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool EGMECHLJBGH(ECEDHFIPBHO CEJEEJJKEJL, [Out] ECEDHFIPBHO HGBJMKAPAJA);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool ACDMEPMHMHB(ECEDHFIPBHO CEJEEJJKEJL, [Out] RigidTransform CBCOCIDFCCM);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 IBJMKNIJHKF(CFPHMAHBLBF DJGPAELJDPJ);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion MEAJENMCJBG(CFPHMAHBLBF DJGPAELJDPJ);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class IOLDGPEKIBO
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OHEOMMICBDN
{
	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	object KCBNJLBMNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NICOALAHIMF
{
	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMDNBOGFBLM(ECEDHFIPBHO OIIGDBLKEDN, EJDGDAIPGFC LPMOKCKBNAB);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GEPLPCJIPNK(EJDGDAIPGFC LPMOKCKBNAB);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KEEFJLPCPGK(ECEDHFIPBHO CEJEEJJKEJL, [Out] EJDGDAIPGFC DGNJNGJPMEP);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[Flags]
public enum PNLEIGPIEFE
{
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	IncludeSelf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	IncludeChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	IncludeDescendants = 6,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	IncludeMask = 7,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Disembodied = 8,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Embodied = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	IgnoreEmbodiment = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	EmbodimentMask = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Runtime = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Authored = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	AuthoredAndRuntime = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	HierarchyMask = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	HintInputsAreDisjoint = 0x80
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public readonly struct FGNCABHBCLO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly string EMLAIMJKHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly T LPJIMLBFHAO;

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x47C6C60", Offset = "0x47C5660", VA = "0x1847C6C60")]
	public FGNCABHBCLO(T LPJIMLBFHAO, [Optional][CallerMemberName] string EMLAIMJKHOE)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public static readonly FGNCABHBCLO<int> FCLGLEOHGNJ;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static readonly FGNCABHBCLO<int> DDOONBJFBHG;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly FGNCABHBCLO<int> IKDNCPADNMM;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public enum FOPKDIDCICH
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class COHLFOCIPJO
{
	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x11800D0", Offset = "0x117EAD0", VA = "0x1811800D0")]
	public static bool HLMDOGFBJKL(this FOPKDIDCICH JCFJJCIGDKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x152FBA0", Offset = "0x152E5A0", VA = "0x18152FBA0")]
	public static bool MBHGPPCPNLD(this FOPKDIDCICH JCFJJCIGDKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x2CC1CF0", Offset = "0x2CC06F0", VA = "0x182CC1CF0")]
	public static bool HOCAGBIMLLK(this FOPKDIDCICH JCFJJCIGDKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FOBBFIMHMEL
{
	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BEMOKPPMANG(ECEDHFIPBHO HDDPFCMNNBA, [Out] uint ICHIIHCEGJD);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FBIDIDOBLAA(ECEDHFIPBHO HDDPFCMNNBA, [Out] uint ICHIIHCEGJD);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LMMGNPJDNEH(ECEDHFIPBHO HDDPFCMNNBA, uint ICHIIHCEGJD);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface DFPPKNOOKAB
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public enum PAFHDDMECGB
	{
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		Unloaded,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		Loading,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		Loaded,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public enum CDFFMGBLGOF
	{
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	PAFHDDMECGB OHPDBLOCGBI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	bool FANHINFJLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	bool BOEKNPCABAN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	CDFFMGBLGOF JPFFEGLNFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[ServiceLifetime(Lifetime.Application)]
public interface KJNGOJGOIPM
{
	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	FOPKDIDCICH EJPDAIKDMKB
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	FOPKDIDCICH MBAELHOLOJC
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	FOPKDIDCICH NAMIFENBLJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	FOPKDIDCICH BHGIPDHFJMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	FOPKDIDCICH FFFPEEAGPKF
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	FOPKDIDCICH DBINBGCNIDK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	FOPKDIDCICH NNOPDEMMJDF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	FOPKDIDCICH NNPJMJBHHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	FOPKDIDCICH KONJGIOBOGD
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	FOPKDIDCICH KDDFFNJCJEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	FOPKDIDCICH GDBKGCEECLG
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	FOPKDIDCICH ENMLKNDCODN
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	FOPKDIDCICH AJOPMHPAAAE
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	FOPKDIDCICH GHIMMLIJLOO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	FOPKDIDCICH NLKFBPGELFB
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	FOPKDIDCICH LLNONHFKKCA
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	FOPKDIDCICH KBKFFMIHOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	FOPKDIDCICH MKDBHEADODP
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BLCCCENAIKI(FGNCABHBCLO<int> MOAPPBPCBJG);
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CIBKLKDAMDL
{
	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event IMMFCBKBEJE.JIHPBGFFBFH NHAFMBBBJPO;

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ECEDHFIPBHO FCEHJKLEFIJ(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KFKFMJGCIBC GOLNGIBCGEK(Allocator DDBBFOCJEFL);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BBOGLCEBAKD OBOAMKHLEEE(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AELDNDEAHDG(IEnumerable<ECEDHFIPBHO> HJEKFICKLEI);

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BBOGLCEBAKD NLBNEEHLLGH(ECEDHFIPBHO HGBJMKAPAJA, ECEDHFIPBHO KKMIKMKCMKE, bool OCKIHHINMCK, ECEDHFIPBHO HIKBDNMPFJK);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ECEDHFIPBHO KHAFIMLOKOF(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GICBAHPKOCO(ECEDHFIPBHO CEJEEJJKEJL, ECEDHFIPBHO HGBJMKAPAJA, bool FBMENNFAIPC = false);

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool LNKNAAENPBC(ECEDHFIPBHO CEJEEJJKEJL, ECEDHFIPBHO HGBJMKAPAJA);

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FFDBCJMGPBD(ECEDHFIPBHO IABDKKLNIKC, ECEDHFIPBHO BDOAKGFDOOK);

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[Obsolete("Use IHierarchyService.GetChildren() instead")]
	KFKFMJGCIBC LLDDFMKLBEC(ECEDHFIPBHO OHLJFNOIPDI);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GNFPKOFHFNN(ECEDHFIPBHO CEJEEJJKEJL, ECEDHFIPBHO BLMHPMNKKHK);

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KFKFMJGCIBC FFLOMFPELEN(KFKFMJGCIBC AIEPBNOJPNN, PNLEIGPIEFE BNNEEGIINDP, Allocator DDBBFOCJEFL);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool BCPGJBMNFAN(ECEDHFIPBHO CEJEEJJKEJL, ECEDHFIPBHO OCMOGBOHIDA);

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	ECEDHFIPBHO FNHMEEHNPBO(ECEDHFIPBHO HIKBDNMPFJK, ECEDHFIPBHO DKEPBBDJGJE);

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool MEJMAFJBIFN(ECEDHFIPBHO HIKBDNMPFJK, ECEDHFIPBHO DKEPBBDJGJE, [Out] ECEDHFIPBHO HIENGNKCFLF);

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	ECEDHFIPBHO HFHEAADOKCO(ECEDHFIPBHO[] HOBPLOGKOBP);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "18")]
	ECEDHFIPBHO OPMDFAAKEAM(ECEDHFIPBHO CEJEEJJKEJL, uint CDOPCAIHBDC);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class OMNGOBOKBDE
{
	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x7A9AE50", Offset = "0x7A99850", VA = "0x187A9AE50")]
	public static bool JBBBMCHECPD(this CIBKLKDAMDL JBPNNEGFBPO, ECEDHFIPBHO CEJEEJJKEJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x7A9ABC0", Offset = "0x7A995C0", VA = "0x187A9ABC0")]
	public static KFKFMJGCIBC FFLOMFPELEN(this CIBKLKDAMDL GCGBBJOEAED, ECEDHFIPBHO CEJEEJJKEJL, PNLEIGPIEFE BNNEEGIINDP, Allocator DDBBFOCJEFL)
	{
		return default(KFKFMJGCIBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x7A9AF40", Offset = "0x7A99940", VA = "0x187A9AF40")]
	public static KFKFMJGCIBC NNEFEBNANMB(this CIBKLKDAMDL GCGBBJOEAED, ECEDHFIPBHO CEJEEJJKEJL, Allocator DDBBFOCJEFL)
	{
		return default(KFKFMJGCIBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x7A9AF80", Offset = "0x7A99980", VA = "0x187A9AF80")]
	public static KFKFMJGCIBC NOFMAPOLEAM(this CIBKLKDAMDL GCGBBJOEAED, ECEDHFIPBHO CEJEEJJKEJL, Allocator DDBBFOCJEFL)
	{
		return default(KFKFMJGCIBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x7A9AF00", Offset = "0x7A99900", VA = "0x187A9AF00")]
	public static KFKFMJGCIBC NBJCIKIONKG(this CIBKLKDAMDL GCGBBJOEAED, ECEDHFIPBHO CEJEEJJKEJL, Allocator DDBBFOCJEFL)
	{
		return default(KFKFMJGCIBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x7A9AEC0", Offset = "0x7A998C0", VA = "0x187A9AEC0")]
	public static KFKFMJGCIBC MPEKOLOAMBB(this CIBKLKDAMDL GCGBBJOEAED, ECEDHFIPBHO CEJEEJJKEJL, Allocator DDBBFOCJEFL)
	{
		return default(KFKFMJGCIBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x7A9A9E0", Offset = "0x7A993E0", VA = "0x187A9A9E0")]
	public static KFKFMJGCIBC CLEEEGMEBMK(this CIBKLKDAMDL GCGBBJOEAED, ECEDHFIPBHO CEJEEJJKEJL, Allocator DDBBFOCJEFL)
	{
		return default(KFKFMJGCIBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x7A9AB80", Offset = "0x7A99580", VA = "0x187A9AB80")]
	public static KFKFMJGCIBC FFLOMFPELEN(this CIBKLKDAMDL GCGBBJOEAED, ECEDHFIPBHO CEJEEJJKEJL, Allocator DDBBFOCJEFL)
	{
		return default(KFKFMJGCIBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x7A9AA20", Offset = "0x7A99420", VA = "0x187A9AA20")]
	public static KFKFMJGCIBC FCHGALINGIA(this CIBKLKDAMDL GCGBBJOEAED, ECEDHFIPBHO CEJEEJJKEJL, Allocator DDBBFOCJEFL)
	{
		return default(KFKFMJGCIBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x7A9AA60", Offset = "0x7A99460", VA = "0x187A9AA60")]
	public static KFKFMJGCIBC FCHGALINGIA(this CIBKLKDAMDL GCGBBJOEAED, KFKFMJGCIBC CEJEEJJKEJL, Allocator DDBBFOCJEFL)
	{
		return default(KFKFMJGCIBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EJBDNDBEGED
{
	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KDOFINIJEKG EFCHFCGLJFA(ECEDHFIPBHO HDDPFCMNNBA);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JEMPMJNHAHB(ECEDHFIPBHO HDDPFCMNNBA, KDOFINIJEKG IJEMBBALLBD);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JNDFFKALLKE(ECEDHFIPBHO HDDPFCMNNBA);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EOIIAGIPEGD(ECEDHFIPBHO HDDPFCMNNBA, bool PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FFLBBHGNCDF<string> PKCDDHNAPJJ(ECEDHFIPBHO HDDPFCMNNBA);

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ECNJKPHEDIH(ECEDHFIPBHO HDDPFCMNNBA, FFLBBHGNCDF<string> AGMGBCKIJCO);

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FFLBBHGNCDF<string> IEDONELNJBH(ECEDHFIPBHO HDDPFCMNNBA);

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NBKBCAIDPDC(ECEDHFIPBHO HDDPFCMNNBA, FFLBBHGNCDF<string> AGMGBCKIJCO);

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FFLBBHGNCDF<string> KECIPKOLDGJ(ECEDHFIPBHO HDDPFCMNNBA);

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BCDAFDHHPMK(ECEDHFIPBHO HDDPFCMNNBA, FFLBBHGNCDF<string> AGMGBCKIJCO);

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FFLBBHGNCDF<string> INKBKBOMKPF(ECEDHFIPBHO HDDPFCMNNBA);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BOMOFLJPBEN(ECEDHFIPBHO HDDPFCMNNBA, FFLBBHGNCDF<string> AGMGBCKIJCO);

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool ABPEAHJMMLD(ECEDHFIPBHO HDDPFCMNNBA, ECEDHFIPBHO DHJCIPPGLOL);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JLGPJMONJFP
{
	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x7A95610", Offset = "0x7A94010", VA = "0x187A95610", Slot = "0")]
	Task<BKBJBOFJLGE> OOJFDGHIHNH(KPELGGMCHHD JIJKJIAKPCO, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "1")]
	void NCOPNLPJEGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EMBEGMEPJAI
{
	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	bool AFCKFIPDOHC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	bool HDPHLFPKGLC
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	bool DMIIHHMAJKO
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LNLLFNOJEBP
{
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DEGJELHGJEG
{
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IICAPLAPEPA
{
	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EOJMDFNJGGN([In] float3 JOCLDJFCONL, [In] float3 BJECPMGLFMN, float FPNKBMPOCJL, [Out] DMLIPMFBIOM CAOJACCHMPP, [Out] ECEDHFIPBHO CIGFHDBGGNF);

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int APBGEHPAADL([In] float3 JOCLDJFCONL, float OAIHKLDEKFL, List<ECEDHFIPBHO> HOBPLOGKOBP);

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int AMDHCIGOPIF(Plane[] IAGADDDOFJI, float3 JOCLDJFCONL, float3 ILKCMJANKPJ, quaternion KONJHPLFEME, List<ECEDHFIPBHO> HOBPLOGKOBP);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EOCHGLLJPCI
{
	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EOJMDFNJGGN([In] NativeArray<Entity> GABLPEMHKBP, [In] float3 JOCLDJFCONL, [In] float3 BJECPMGLFMN, [In] NativeArray<DMLIPMFBIOM> GDJJOAFJLHE);

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> APBGEHPAADL([In] NativeArray<Entity> GABLPEMHKBP, [In] float3 JOCLDJFCONL, float OAIHKLDEKFL);

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> AMDHCIGOPIF([In] NativeArray<Entity> GABLPEMHKBP, [In] NativeArray<float4> ADPMEFPFPKP);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct ALGJLCNHEAB : KPKOEBEHBFB, IEquatable<ALGJLCNHEAB>
{
	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	public int LIGNGKONFNM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x11DE630", Offset = "0x11DD030", VA = "0x1811DE630", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	public int FDJPACNIFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC650", Offset = "0x2CDB050", VA = "0x182CDC650", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x6B6C4D0", Offset = "0x6B6AED0", VA = "0x186B6C4D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x7A86D80", Offset = "0x7A85780", VA = "0x187A86D80", Slot = "8")]
	public bool Equals(ALGJLCNHEAB OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x7A86DD0", Offset = "0x7A857D0", VA = "0x187A86DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public struct DMLIPMFBIOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public float BFHAKMHAFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public float3 MDIKGGEOGCO;
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MOCKFPLHMLN
{
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HOECEAHHGFN
{
	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	PEBMNHFMPEL FMHELOONJPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	IHOCDGBEEFG HBMBDIEJPJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<KFKFMJGCIBC, NativeArray<RRObjectPrefabData>> LAKKHPPAIAG;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<KFKFMJGCIBC> COOEEBGJJME;

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KFKFMJGCIBC NPIDOJGOPOI();

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PHMLPDLGIJG IELEMAGOOGE(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "8")]
	RRObjectPrefabData KOALMEHPAKC(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HEDFOAIFGAC(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DFLEJIJCDEG EGLPAJJNKBK(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool BMAAAAAPBJL(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool AFGEOIEBJMP(ECEDHFIPBHO CEJEEJJKEJL, [Out] Transform GBIMAJCBFCJ);

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "13")]
	ECEDHFIPBHO GKKBKOOBGLM(MNGNDNIEHNP NBMFEEBJLOH);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool KNELPHKJFJA(MNGNDNIEHNP NBMFEEBJLOH, [Out] ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MNGNDNIEHNP KJNEOCDFJMD(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "16")]
	KFKFMJGCIBC GKKBKOOBGLM(NativeArray<MNGNDNIEHNP> NBMFEEBJLOH, Allocator DDBBFOCJEFL, bool MKMJFENOJAF = true);

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MMIOFBHEKLO(RRObjectPrefabData NPLOBGMFJFK, NativeArray<Entity> GABLPEMHKBP);

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool DOIEINNIJAM(NativeArray<KJHENAGCBNO> ANBBIDIDGAA, NativeArray<MNGNDNIEHNP> NCEKHFLFICG, NativeArray<Entity> DBICMKJCAEN);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	DFLEJIJCDEG EBBFNGIICJP();

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	DFLEJIJCDEG MPPHADDNLJD(RRObjectPrefabData NPLOBGMFJFK);

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	GAICLDAFDKN OFNKCFGECPB();

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "22")]
	KJHHHBLLAOE BAJPGMEECOI();

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CPHNEMINGLO CKLAGGEMKAG(AHBNMJGLFPD KJOAMNLGMHI);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BHOOAJLPGBM(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool HEPCLDGGEMJ(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "26")]
	KFKFMJGCIBC DMBOHDPAILE(KFKFMJGCIBC BJFGKOJGIGA, Allocator DDBBFOCJEFL);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool IKAEDGDPHLM(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool FBIPIGNDMNC(ECEDHFIPBHO CEJEEJJKEJL, ComponentTypes PFJHIDGMOFL);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "29")]
	ECEDHFIPBHO HMFGPMMPKOD(Transform GBIMAJCBFCJ);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class GMGACCEHHGO
{
	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x7A90560", Offset = "0x7A8EF60", VA = "0x187A90560")]
	internal static ECEDHFIPBHO CGHLJKCDELF(this Entity CGNAGBGLBDK, HOECEAHHGFN DOOFKBLICCL)
	{
		return default(ECEDHFIPBHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x7A907C0", Offset = "0x7A8F1C0", VA = "0x187A907C0")]
	public static DFLEJIJCDEG GJBLNOJHFOC(this HOECEAHHGFN DOOFKBLICCL, LocalId CEJEEJJKEJL)
	{
		return default(DFLEJIJCDEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x7A907D0", Offset = "0x7A8F1D0", VA = "0x187A907D0")]
	public static ECEDHFIPBHO GKKBKOOBGLM(this HOECEAHHGFN DOOFKBLICCL, LocalId CEJEEJJKEJL)
	{
		return default(ECEDHFIPBHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x7A90880", Offset = "0x7A8F280", VA = "0x187A90880")]
	public static MNGNDNIEHNP KJNEOCDFJMD(this HOECEAHHGFN DOOFKBLICCL, LocalId CEJEEJJKEJL)
	{
		return default(MNGNDNIEHNP);
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x7A908F0", Offset = "0x7A8F2F0", VA = "0x187A908F0")]
	public static GAICLDAFDKN MCHIOAIOJDD(this HOECEAHHGFN DOOFKBLICCL, RigidTransform LMHMPOPBLEA)
	{
		return default(GAICLDAFDKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x7A90610", Offset = "0x7A8F010", VA = "0x187A90610")]
	public static CPHNEMINGLO GADMDGJLGHP(this HOECEAHHGFN DOOFKBLICCL, AHBNMJGLFPD BLBNPJFGILF, RigidTransform LMHMPOPBLEA)
	{
		return default(CPHNEMINGLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x7A90380", Offset = "0x7A8ED80", VA = "0x187A90380")]
	public static KJHHHBLLAOE AACIODKILIA(this HOECEAHHGFN DOOFKBLICCL, RigidTransform LMHMPOPBLEA)
	{
		return default(KJHHHBLLAOE);
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x7A90530", Offset = "0x7A8EF30", VA = "0x187A90530")]
	private static void ANOENPCJFLA(DFLEJIJCDEG IDNJDDDKPOD, RigidTransform LMHMPOPBLEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
internal interface ICNNEPJLGKB
{
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HDEPPMKMBLP
{
	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	bool GGKHPFACNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	ECEDHFIPBHO IGJMFAJCHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	DFLEJIJCDEG LLKDANAJFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event AGBMIMFKIDH FPJNOEEIDJF;

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ECEDHFIPBHO FNHMEEHNPBO(ECEDHFIPBHO HIKBDNMPFJK, ECEDHFIPBHO DKEPBBDJGJE);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MEJMAFJBIFN(ECEDHFIPBHO HIKBDNMPFJK, ECEDHFIPBHO DKEPBBDJGJE, [Out] ECEDHFIPBHO HIENGNKCFLF);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BMCAFJJPIEF();

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AMKHFBOPNED();

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool GMGHIKNFLNI(ECEDHFIPBHO HIKBDNMPFJK);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool ELMLKENFDHJ(ECEDHFIPBHO HIKBDNMPFJK);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public delegate void AGBMIMFKIDH(DFLEJIJCDEG KFNNHHGFDGE, DFLEJIJCDEG CJHHHDGEJCG);
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class PLOHIHOMLDO
{
	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B720", Offset = "0x7A9A120", VA = "0x187A9B720")]
	public static bool DNPGKFCONON(this HDEPPMKMBLP ICIKEBAONAM, DFLEJIJCDEG HIKBDNMPFJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B640", Offset = "0x7A9A040", VA = "0x187A9B640")]
	public static bool BPBMDIKHICP(this HDEPPMKMBLP ICIKEBAONAM, ECEDHFIPBHO HIKBDNMPFJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B770", Offset = "0x7A9A170", VA = "0x187A9B770")]
	public static bool NHDCEDGIBJC(this HDEPPMKMBLP ICIKEBAONAM, ECEDHFIPBHO HIKBDNMPFJK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FFLBIHCFLKP
{
	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCNJGHIJCCC(NativeList<RRObjectPrefabData> GDGGDKNDODC);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KNEDPIAHBEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LKMGBGEGNLG(DFLEJIJCDEG IDNJDDDKPOD, PDPDCPPPIIG OAIBEKCJMGA, List<DFLEJIJCDEG> GOKGPKNNGEF);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int KGEHHKJEBPO(DFLEJIJCDEG IDNJDDDKPOD, PDPDCPPPIIG OAIBEKCJMGA);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HABJIHOBLEL(DFLEJIJCDEG IDNJDDDKPOD, List<DFLEJIJCDEG> GOKGPKNNGEF);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int BNJEHECAOFH(DFLEJIJCDEG NMGLJLCLAKO, DFLEJIJCDEG HIKBDNMPFJK, PDPDCPPPIIG OAIBEKCJMGA);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DFLEJIJCDEG FJEIEMEMBBN(DFLEJIJCDEG NMGLJLCLAKO, int DOAKEFBOPIA, PDPDCPPPIIG OAIBEKCJMGA);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NIFKPFLIDDI(DFLEJIJCDEG NMGLJLCLAKO, DFLEJIJCDEG HIKBDNMPFJK, PDPDCPPPIIG OAIBEKCJMGA);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LNLMAKJLAPL(DFLEJIJCDEG NMGLJLCLAKO, DFLEJIJCDEG HIKBDNMPFJK, PDPDCPPPIIG OAIBEKCJMGA);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AGHDBGNPFHJ(DFLEJIJCDEG NMGLJLCLAKO, PDPDCPPPIIG OAIBEKCJMGA);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NNDOLOONKFD(DFLEJIJCDEG NMGLJLCLAKO, DFLEJIJCDEG HIKBDNMPFJK, PDPDCPPPIIG OAIBEKCJMGA);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OEJLCIPOFJE(Entity NMGLJLCLAKO, Entity HIKBDNMPFJK, PDPDCPPPIIG OAIBEKCJMGA);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LOEAFBAOFGN(Entity NMGLJLCLAKO, PDPDCPPPIIG OAIBEKCJMGA);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool HKIPCEOHAKM(DFLEJIJCDEG HIKBDNMPFJK, PDPDCPPPIIG OAIBEKCJMGA);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HJEIBNODODH
{
	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	JKCBJMIPLDD OPEKJHJLIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NLLAEBLBHHD BJJNCOBBLBH(JKCBJMIPLDD FHMFNFPPKKJ);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JKCBJMIPLDD JEBCMGOMGHM();

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JKCBJMIPLDD DEHOCOIFFOI();
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HIBGAOKPNFD
{
	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ONLHBELNDGC(ECEDHFIPBHO HIKBDNMPFJK, ECEDHFIPBHO IOPABKBJPMA);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LNCHNLJMHFP(ECEDHFIPBHO HIKBDNMPFJK, ECEDHFIPBHO BPECEKEAEGD);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DBKMNJFGDHO(ECEDHFIPBHO HIKBDNMPFJK, [Out] ECEDHFIPBHO MECBIPOBIIG);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HNKDJIDAPJB
{
	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PMOIMGDEFMB(ECEDHFIPBHO OHLJFNOIPDI, bool PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BLIALJOKKKN(ECEDHFIPBHO OHLJFNOIPDI, bool PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EFILIPNEPGM(ECEDHFIPBHO OHLJFNOIPDI, int PPJFMHBDGNA);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ILPFMHBELGI
{
	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ECEDHFIPBHO> GMHPLEONJFH(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ECEDHFIPBHO MGAMDECGLGP(ECEDHFIPBHO CEJEEJJKEJL, int DOAKEFBOPIA);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int DNIEONNGOBD(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JPHEOFPJKHK JHJHCIPCDEC(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NELLLIIMPHJ(ECEDHFIPBHO CEJEEJJKEJL, JPHEOFPJKHK KHABEFHMCBM);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ECEDHFIPBHO PKCHCODBOJD(ECEDHFIPBHO CEJEEJJKEJL, [Optional] float3? KKIJMCHODGC, [Optional] quaternion? KONJHPLFEME, [Optional] float3? GFDDEGDNEEN);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ECEDHFIPBHO EFLHEAPBDOJ(ECEDHFIPBHO CEJEEJJKEJL, int DOAKEFBOPIA, [Optional] float3? KKIJMCHODGC, [Optional] quaternion? KONJHPLFEME, [Optional] float3? GFDDEGDNEEN);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ODMOPFMCPIL(ECEDHFIPBHO CEJEEJJKEJL, int DOAKEFBOPIA);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GMNKBDEKFNC(ECEDHFIPBHO CEJEEJJKEJL);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FLMKHAIAPCI
{
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LPCPLNDNBBJ
{
	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	bool EALGNPCKDGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KAHNDBODGEH();

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KGKFKIOAHLD();

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AGNCDEBHGJP();

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OBDCEMDIFIF();

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LKFCPILGIKK();

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NDMGIDGLFND();

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OLNCNLCHHAB();

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MEAFDIECNDM();

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CMPOHNJLAIA();

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IKNHPBNBOPB();

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JCCEOEPBLME();

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MAPANPJMDHJ();
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface INGBMGBGOAB
{
	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EGJBEAJDHFC(ECEDHFIPBHO HIKBDNMPFJK, [Out] int NMGLJLCLAKO);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DIJBKNHGHFI(ECEDHFIPBHO HIKBDNMPFJK, int NMGLJLCLAKO);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FOCGMNOLINO(ECEDHFIPBHO HIKBDNMPFJK, bool IODPHBLPIHH);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JGNMMNBHKLN(ECEDHFIPBHO HIKBDNMPFJK, float IKNLKGPAJFK, float GHMJCFCPDHG, float EFOOMNIJPIJ);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EGOAMDOGBFE(ECEDHFIPBHO CEJEEJJKEJL, [Out] float GHMJCFCPDHG, [Out] float EFOOMNIJPIJ);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LBANIMICJJM(ECEDHFIPBHO HIKBDNMPFJK, float3 KKIJMCHODGC, quaternion KONJHPLFEME);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PCLJFHDMFGM(ECEDHFIPBHO HIKBDNMPFJK, [Out] float3 KKIJMCHODGC, [Out] quaternion KONJHPLFEME);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JLKOOGDILEH(ECEDHFIPBHO HIKBDNMPFJK);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PDMBJJLECEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BPDCPNDKKLC(Entity CGNAGBGLBDK, [In] float3 PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float3 FDKGDGCPFFC(Entity CGNAGBGLBDK);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AMEBKEOALFB(Entity CGNAGBGLBDK, [In] quaternion PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "3")]
	quaternion CCCNEMCFPKJ(Entity CGNAGBGLBDK);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HILEIEHJGEB(Entity CGNAGBGLBDK, [In] float3 KKIJMCHODGC, [In] quaternion KONJHPLFEME);

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ABALKFLJLGK(Entity CGNAGBGLBDK, [Out] RigidTransform MJNNDJHADIH);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EIGHIBGNEMH(Entity CGNAGBGLBDK, [In] float3 KKIJMCHODGC, [In] quaternion KONJHPLFEME);

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ECPOILFKELB(Entity CGNAGBGLBDK, [Out] float3 KKIJMCHODGC, [Out] quaternion KONJHPLFEME);

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ECPOILFKELB(Entity CGNAGBGLBDK, [Out] RigidTransform MJNNDJHADIH);

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OGEGIGPJJLB(Entity CGNAGBGLBDK, float PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float GHFEINFKBPP(Entity CGNAGBGLBDK);

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DGFIBDIACDI(Entity CGNAGBGLBDK, [In] float3 PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 GFINIOFAHGL(Entity CGNAGBGLBDK);

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DMEDAOBMBPP(Entity CGNAGBGLBDK, [In] quaternion PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "14")]
	quaternion NDFGFHNEMCK(Entity CGNAGBGLBDK);

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IKLDCKJBPJK(Entity CGNAGBGLBDK, float PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float DHDEKODFMMH(Entity CGNAGBGLBDK);

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NDDHMMJGNDB(Entity CGNAGBGLBDK, [Out] float4x4 FFKIELGPMDB);

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BOJJDPMOOAB(Entity CGNAGBGLBDK, [In] float4x4 FFKIELGPMDB);

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void CGDAAKEAAPF(Entity CGNAGBGLBDK);

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OMPANEECOCK(Entity CGNAGBGLBDK, Entity ENJCJLCMMGG, Entity MGKDKKMCMAL);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public static class OPKEEPMOJNG
{
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EHIKEBBECNK
{
	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BDMANJCOPME(bool BJNPGOKOJIA);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GIAOHCJKLEE
{
	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BILJEDDCGCI(ECEDHFIPBHO HDDPFCMNNBA, FFLBBHGNCDF<string> AGMGBCKIJCO);

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DBPGKIKCJPF(ECEDHFIPBHO HDDPFCMNNBA, FFLBBHGNCDF<string> AGMGBCKIJCO);

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EGLPBKDMMJM(ECEDHFIPBHO HDDPFCMNNBA, FFLBBHGNCDF<string> AGMGBCKIJCO);

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CKLEILAAFNP(ECEDHFIPBHO HDDPFCMNNBA, FFLBBHGNCDF<string> AGMGBCKIJCO);

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LPGGNLGGBHE(ECEDHFIPBHO HDDPFCMNNBA, FFLBBHGNCDF<string> AGMGBCKIJCO);

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NNFLGELALPP(ECEDHFIPBHO HDDPFCMNNBA, FFLBBHGNCDF<string> AGMGBCKIJCO);

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int PIOOHPPAIPH(ECEDHFIPBHO HDDPFCMNNBA);

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int MAAMOPNIABH(ECEDHFIPBHO HDDPFCMNNBA);

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int ANEGJELLBHD(ECEDHFIPBHO HDDPFCMNNBA);

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HPNOBMMHMAN<string> LLMKLJCMKOL(ECEDHFIPBHO HDDPFCMNNBA);

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool HBLHCFONDHH(ECEDHFIPBHO HDDPFCMNNBA);

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HPNOBMMHMAN<string> CCJGOANIDJI(ECEDHFIPBHO HDDPFCMNNBA);

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool CFFJFPADIIA(ECEDHFIPBHO HDDPFCMNNBA, string FDBECNGFMME);

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void EBINKNEEBOG(string FDBECNGFMME, EMJFOIOODEA BHMINKNMIIO);

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ECEDHFIPBHO KIGIECHNPEK(string FDBECNGFMME);

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JOCIHBPLECE(string FDBECNGFMME, EMJFOIOODEA BHMINKNMIIO);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JOJHEOIACGK(ECEDHFIPBHO GIOEFAMNGCC, string FDBECNGFMME, EMJFOIOODEA BHMINKNMIIO);
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class NJEGEDCLPIA
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NNMFIPFJCKK
{
	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World HCIOIJOOEDC(string IOMABBOIKIG = "Main");

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World NOCINDKGGAH(string IOMABBOIKIG = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World IFIHJGAEMHE(string IOMABBOIKIG = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World HMDILHNHKCA(string IOMABBOIKIG = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MIAJELHJLFO
{
	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	World FEPCGPFFJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	World DGAJCNAABCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	EntityManager JIDOJAHOFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	bool BHLAOEGENBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase ADHELBFLAEF(Type OHCGINPDMEI);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class IKFOHEOEFGA
{
	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x7A93B10", Offset = "0x7A92510", VA = "0x187A93B10")]
	public static ComponentSystemBase EKKHPPHDDLD(this World ILOAGCFCJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x36BB890", Offset = "0x36BA290", VA = "0x1836BB890")]
	public static T ADHELBFLAEF<T>(this MIAJELHJLFO PODKDDPCBHM) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PAOPDHFIBFB
{
	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCPHHCNMCGG(NativeListAsync<Entity> IHCLDBANPAE);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DJNEFJMMFCN(KALIBJCDCDI NGEBDEDGNDB);

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LMPGFMKCLMI(NativeListAsync<Entity> INLHBCFJDCC, bool DLIHBBBBNGA);

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BPFLHAEJPAF();

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ONMPELBCNIP(Entity MHHKOMDGDID);
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface CFIDFADBFLH
{
	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KKDNPKLMNME(Collider GKCCNNFCLIL, [Out] NGMENJNPHOG OADBPNCGPMD);
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JANDLFJNOBB
{
	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider CHLGPNFMBDO(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject DKFKCGHHIAM(ECEDHFIPBHO JLKNDGCOAKE, GameObject DEMHLIAEAHH, Vector3 GHOLIOPECPJ, Quaternion BOFAHJJKKBL);

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HOEKCACFPHK(GameObject GKCCNNFCLIL);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider FBOPFGIKEDL<TCollider>(GameObject GLKNJHAMEGA) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DFIOMJHAKOD(Collider GKCCNNFCLIL);

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject PMKCHGEJNHC<TCollider>(string EMLAIMJKHOE) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JNHJOIKHAHG BOEGJKICDJB(ECEDHFIPBHO BFMNNJPOCCL, ECEDHFIPBHO BJIBGECKCLN, AHBNMJGLFPD DFMGHOLJBLL, float3 AJPDJAIKPKP, quaternion ACCPMCFLFIB, float3 FCPNAKMBNJM);

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BAKBBJLOLCB(ECEDHFIPBHO CEJEEJJKEJL, [Out] JNHJOIKHAHG GKCCNNFCLIL);

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NMDIBKLMEGM(ECEDHFIPBHO CEJEEJJKEJL, [Out] ECEDHFIPBHO MHHKOMDGDID);
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public enum AFGMHEFNKBC
{
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JABONDMAHIA
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public struct LBNGCGCECFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public int DFMGHOLJBLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public GameObject DEMHLIAEAHH;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IBCLPPHIHIN(ECEDHFIPBHO CEJEEJJKEJL, PAAKCKFKCBH EHACDMLKJNC, bool LKBBDFOHMON, ECGPIELDBBK BGFNKEDPFEJ);

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FCHBOEJCDKO(ECEDHFIPBHO CEJEEJJKEJL, PAAKCKFKCBH EHACDMLKJNC, bool LKBBDFOHMON, bool MFIHNLGMFGC, bool LCPMFDGCLBF);

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OFNGKMJKMMD HNDMIFNFAOD(ECEDHFIPBHO MHHKOMDGDID, List<ECEDHFIPBHO> EDPHMNDFPGL);

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JNHJOIKHAHG GOABDKABBMP(GameObject OIIGJGAOHGN, GameObject HJOAKLAOBME);

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MCBFLCIGALI(GameObject OIIGJGAOHGN, List<GameObject> FELJLNDFBNJ);

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ANFJBLHOMPA(GameObject HJOAKLAOBME);

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T FBOPFGIKEDL<T>(GameObject GLKNJHAMEGA) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DFIOMJHAKOD(Collider GKCCNNFCLIL);

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject FNOKFJMFIIB<T>(string EMLAIMJKHOE) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OLLPPCJCOLO(Collider GKCCNNFCLIL, [Out] ECEDHFIPBHO NMGLJLCLAKO);

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool OFJPNKJFGDB(ECEDHFIPBHO CEJEEJJKEJL, [Out] NGMENJNPHOG OADBPNCGPMD);

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<AFGMHEFNKBC> KJBPFDEJLEL(Allocator DDBBFOCJEFL = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] HOOPMPNCALM();
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JAOKNLEFHDM
{
	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLIGOJPFBFL(ECEDHFIPBHO CEJEEJJKEJL, ECEDHFIPBHO PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IBGHCPICJGI(ECEDHFIPBHO CEJEEJJKEJL, ECEDHFIPBHO PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int CHMLLPFGKJL(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ECEDHFIPBHO PHKGBJEBKCC(ECEDHFIPBHO CEJEEJJKEJL, int DOAKEFBOPIA);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KFKFMJGCIBC JOOPPFKEACJ(ECEDHFIPBHO CEJEEJJKEJL, Allocator DDBBFOCJEFL = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GJPNDNPNBHC(ECEDHFIPBHO CEJEEJJKEJL, object GNAAILLDOKI, ECEDHFIPBHO PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PLLOLJCHBOG(ECEDHFIPBHO CEJEEJJKEJL, object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool JOLFAICIKHJ(ECEDHFIPBHO CEJEEJJKEJL, [Out] ECEDHFIPBHO PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HIMCLGLMCLP(ECEDHFIPBHO CEJEEJJKEJL, float3 PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool IHAMBOGNDLB(ECEDHFIPBHO CEJEEJJKEJL, [Out] float3 PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MOHFCPMFGJA(ECEDHFIPBHO CEJEEJJKEJL, float3 PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KIHMKEEMGCG(ECEDHFIPBHO CEJEEJJKEJL, [Out] float3 PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EHNFPDNLDIE(ECEDHFIPBHO CEJEEJJKEJL, (Quaternion rot, Vector3 moments) BFILMAEAIPL);

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool NMNDGABKKIL(ECEDHFIPBHO CEJEEJJKEJL, [Out] quaternion ADLPINICHDN, [Out] float3 ABAFMKFFKHH);

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BHMOBMGACAD(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 BFABBLEAHLL(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 BHBKMHOIGBH(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PLEMNJGKPIM(ECEDHFIPBHO CEJEEJJKEJL, float3 PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HMJAKJDBCKC(ECEDHFIPBHO CEJEEJJKEJL, float3 PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float EDOHLKAKMDM(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float NHKPLNIDPBP(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void NNPJCNAPKBD(ECEDHFIPBHO CEJEEJJKEJL, float PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JLADCCOKGAB(ECEDHFIPBHO CEJEEJJKEJL, float PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode ACIIMIPCHAC(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CKGDJECGNGN(ECEDHFIPBHO CEJEEJJKEJL, CollisionDetectionMode PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	JFFGEHLFDPP COLMOGDGKAC(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void ALOGDBCHIBA(ECEDHFIPBHO CEJEEJJKEJL, JFFGEHLFDPP PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool IAJFJDEJBOO(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void IBKCNEOCEFO(ECEDHFIPBHO CEJEEJJKEJL, bool PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	ECEDHFIPBHO FCEHJKLEFIJ(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void GHGFIELFJLK(ECEDHFIPBHO CEJEEJJKEJL, ECEDHFIPBHO PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	ECEDHFIPBHO KHAFIMLOKOF(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void GICBAHPKOCO(ECEDHFIPBHO CEJEEJJKEJL, ECEDHFIPBHO PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	FDEOGDPKFCL GJIPNBBBBOM(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void KCEOKONPOEI(ECEDHFIPBHO CEJEEJJKEJL, FDEOGDPKFCL HAJKLCOCJOA);

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool HGCIJMMDEFN(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void EMJGMFFOFNI(ECEDHFIPBHO CEJEEJJKEJL, bool PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool JADEDDKLEHP(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void BCAOCLKEBPF(ECEDHFIPBHO CEJEEJJKEJL, bool PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints NPIIPMKNHLO(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void HFIMJMMNCHH(ECEDHFIPBHO CEJEEJJKEJL, RigidbodyConstraints PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float DOEFMPKLLFP(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void AFKOFJJHOIP(ECEDHFIPBHO CEJEEJJKEJL, float PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float FPIMNHEAAOF(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void LHKEINJLDJA(ECEDHFIPBHO CEJEEJJKEJL, float PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool CKFLGANILEJ(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void IDHKHDOBCJG(ECEDHFIPBHO CEJEEJJKEJL, bool PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool FLPANJHEHPO(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void FHHIFHFGPIK(ECEDHFIPBHO CEJEEJJKEJL, bool PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void KIHMIMLIHGN(ECEDHFIPBHO CEJEEJJKEJL, int PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "50")]
	EDDAFEHGANJ JEEPFPLIJPN(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void JHNGKOGNKFE(ECEDHFIPBHO CEJEEJJKEJL, EDDAFEHGANJ PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "52")]
	PMMOKEJBHFJ FJHGJNAGANH(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void JEIOBDHPEII(ECEDHFIPBHO CEJEEJJKEJL, PMMOKEJBHFJ PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float EEDONPFHJGD(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void LGDMDKJKLGP(ECEDHFIPBHO CEJEEJJKEJL, float PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void IDMNBFLECAL(ECEDHFIPBHO CEJEEJJKEJL, object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void BEOGDKBCOFO(ECEDHFIPBHO CEJEEJJKEJL, object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool CCNKCEBDOJL(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void EBFAABCCPCL(ECEDHFIPBHO CEJEEJJKEJL, object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void DNLAJAIJMEB(ECEDHFIPBHO CEJEEJJKEJL, object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool EJKNLCMCDHE(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool FAHMPMLNIHM(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody AOJJDHKDHGJ(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void HMAENLECJAC(ECEDHFIPBHO CEJEEJJKEJL, Rigidbody NEPEGLKEMNE);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void MBNHJKHPNPC(ECEDHFIPBHO CEJEEJJKEJL, object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void MPICDEHACKI(ECEDHFIPBHO CEJEEJJKEJL, object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool BMDDIKBJAAL(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void EIOIPIEMBMI(ECEDHFIPBHO CEJEEJJKEJL, float3 FKMLPLAMBLK);

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void IIFBKNOPEIF(ECEDHFIPBHO CEJEEJJKEJL, float3 AEJKODDIOPN);

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool JIECJEEBENF(ECEDHFIPBHO CEJEEJJKEJL, [Out] float3 FKMLPLAMBLK);

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool CJEHFHDPCLA(ECEDHFIPBHO CEJEEJJKEJL, [Out] float3 AEJKODDIOPN);

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool JCNHMCMDBEI(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void EBBPGDFMFKF(ECEDHFIPBHO CEJEEJJKEJL, object GNAAILLDOKI, bool MLIEPCEKKKM);

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void LABCDNLOOGA(ECEDHFIPBHO CEJEEJJKEJL, bool FIENLPMCHDP);

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void FFHKFFBDGEO(ECEDHFIPBHO CEJEEJJKEJL);

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool GKGFOICLLMB(ECEDHFIPBHO CEJEEJJKEJL);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KNCBCLELBEK
{
	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHGKLLMPKOK(Entity DMOAHAEEJEL);

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PPHNMHADELA(Entity DMOAHAEEJEL);

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BCBLDFKEJMO(Entity DMOAHAEEJEL);
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KCCJBNPCDBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBOBIEDLNML(ECEDHFIPBHO HIKBDNMPFJK, bool NADKOBBHMLF);
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public delegate void DKIDMJPDGAE(OFFLNPLDBAL FPAHAKEJDOE);
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public readonly ref struct OFFLNPLDBAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly KFKFMJGCIBC PADCOIFGDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly NativeArray<byte> OCDJAMBMLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly NativeArray<byte> IDFOBDFLLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly DBDIPFEPNDG LDIFMBFDAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly int BIOILPFNEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly Type CFKJNCHBIHA;

	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	public KFKFMJGCIBC EMNNNILJNIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x4EA06D0", Offset = "0x4E9F0D0", VA = "0x184EA06D0")]
		get
		{
			return default(KFKFMJGCIBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	public int NIKDNFEJMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x7A9A720", Offset = "0x7A99120", VA = "0x187A9A720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	public DBDIPFEPNDG LDBNNDPEJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x9CB660", Offset = "0x9CA060", VA = "0x1809CB660")]
		get
		{
			return default(DBDIPFEPNDG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x7A9A740", Offset = "0x7A99140", VA = "0x187A9A740")]
	public OFFLNPLDBAL(KFKFMJGCIBC PADCOIFGDKE, NativeArray<byte> OCDJAMBMLIK, NativeArray<byte> IDFOBDFLLCC, DBDIPFEPNDG LDIFMBFDAPL, int BIOILPFNEJJ, Type CFKJNCHBIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x381ADF0", Offset = "0x38197F0", VA = "0x18381ADF0")]
	public NativeArray<T> POFPEPNIDHE<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x381ADB0", Offset = "0x38197B0", VA = "0x18381ADB0")]
	public NativeArray<T> NFNACIIIADO<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x381ACC0", Offset = "0x38196C0", VA = "0x18381ACC0")]
	public (KFKFMJGCIBC, NativeArray<T>, NativeArray<T>) BLCCCENAIKI<T>() where T : struct
	{
		return default((KFKFMJGCIBC, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x7A9A6F0", Offset = "0x7A990F0", VA = "0x187A9A6F0")]
	public AJPNCGACNDE FKDJNNCDCMO()
	{
		return default(AJPNCGACNDE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public interface IAEKMPLBFFD
{
	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	string HCJEMBEEEGO
	{
		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	IAEKMPLBFFD HCDMMGCPAHC
	{
		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	IEnumerable<IAEKMPLBFFD> EDJFBHEJDAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface MPEEOMKACKA
{
	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	IAEKMPLBFFD ABHOKHOGNCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	NativeArray<DBDIPFEPNDG> PLGAKLIPAAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GACENKKIANP(DBDIPFEPNDG LDIFMBFDAPL, [Out] IAEKMPLBFFD ILBJJIFAJFF);

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BLLBFFICICF(DBDIPFEPNDG LDIFMBFDAPL, DKIDMJPDGAE PNDHHPDOPML);

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BAPLINGHHOO(DBDIPFEPNDG LDIFMBFDAPL, DKIDMJPDGAE PNDHHPDOPML);
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KCODKAIDEEC
{
	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BLLBFFICICF(DBDIPFEPNDG LDIFMBFDAPL, DKIDMJPDGAE PNDHHPDOPML);

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAPLINGHHOO(DBDIPFEPNDG LDIFMBFDAPL, DKIDMJPDGAE PNDHHPDOPML);
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public static class EAPFEDHILLN
{
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KPNAOMAKIAK
{
	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	bool HBOMCBFIAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	HLEAEDGOHJG JPEIHOLMIHL
	{
		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OICALFMLJFA(NLLAEBLBHHD NBMFEEBJLOH, bool ACMAIFKCOGO);

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EPPDPGFJHAE(MNGNDNIEHNP NBMFEEBJLOH, DBDIPFEPNDG LDIFMBFDAPL);

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KADGGGLMODK(NativeArray<MNGNDNIEHNP> KIKMCFMBNFE);
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public static class HFCGPLBEMGD
{
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public readonly ref struct AJPNCGACNDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly OFFLNPLDBAL DFPGGEDGGGN;

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	public KFKFMJGCIBC EMNNNILJNIM
	{
		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x4EA06D0", Offset = "0x4E9F0D0", VA = "0x184EA06D0")]
		get
		{
			return default(KFKFMJGCIBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x7A86D50", Offset = "0x7A85750", VA = "0x187A86D50")]
	public AJPNCGACNDE(OFFLNPLDBAL DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x7A86C20", Offset = "0x7A85620", VA = "0x187A86C20")]
	public KFKFMJGCIBC POFPEPNIDHE()
	{
		return default(KFKFMJGCIBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x7A86AF0", Offset = "0x7A854F0", VA = "0x187A86AF0")]
	public KFKFMJGCIBC NFNACIIIADO()
	{
		return default(KFKFMJGCIBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x7A86800", Offset = "0x7A85200", VA = "0x187A86800")]
	public (KFKFMJGCIBC, KFKFMJGCIBC, KFKFMJGCIBC) BLCCCENAIKI()
	{
		return default((KFKFMJGCIBC, KFKFMJGCIBC, KFKFMJGCIBC));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public static class FMEDHFEFIEJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public readonly struct HLEAEDGOHJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly NativeBitArray GBEAGFBFAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly NativeParallelHashMap<MNGNDNIEHNP, int> IAIONNDGLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly NativeParallelHashSet<NLLAEBLBHHD> CJBFKFLOKOB;

	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	public bool AMCNCPFFIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x7A918B0", Offset = "0x7A902B0", VA = "0x187A918B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	public bool HBOMCBFIAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x7A918D0", Offset = "0x7A902D0", VA = "0x187A918D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x597D400", Offset = "0x597BE00", VA = "0x18597D400")]
	public HLEAEDGOHJG(NativeBitArray GBEAGFBFAKP, NativeParallelHashMap<MNGNDNIEHNP, int> IAIONNDGLPN, NativeParallelHashSet<NLLAEBLBHHD> CJBFKFLOKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x7A916C0", Offset = "0x7A900C0", VA = "0x187A916C0")]
	public bool EPPDPGFJHAE(MNGNDNIEHNP NBMFEEBJLOH, DBDIPFEPNDG LDIFMBFDAPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AKICPHADAJJ
{
	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	MPMOFPPLHCF CPNPEFBGNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface NDNBHEHGHAG
{
	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BIEIJPCCBFP(ECEDHFIPBHO CEJEEJJKEJL, GDFAAFKOMOG PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JBGLFFCNIBO OMKHIKDGOLD();
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DHPCIPMOIHO
{
	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NEJBDMOILOL(World ILOAGCFCJMA);

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AIEOPJHPKIM(World ILOAGCFCJMA);

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase MLINKMBCGJO(World ILOAGCFCJMA);

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FEBALICFKMM(World ILOAGCFCJMA);

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OKHFEBIIPCF(World ILOAGCFCJMA);

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MLEMGBGPOFB(World ILOAGCFCJMA);

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GJAJDKAECDB(World ILOAGCFCJMA);

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> PKODNDHHNOB();
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JFEFOGMKAKI
{
	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNOKBAMECAM(ECEDHFIPBHO OHLJFNOIPDI, bool PPJFMHBDGNA);
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public readonly struct FKOAKIHMFHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly IEnumerable<KIJIDFMADEA> NKPIPBALDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly IReadOnlyList<GameObject> IONFDLCLMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly IReadOnlyList<int> CHIJMGGDAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly IReadOnlyList<(MNGNDNIEHNP, MNGNDNIEHNP)> NHLLCFOEBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly int BHNLGPLMGHL;
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public struct IONIAJKGNBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public InventionIdData ICHIIHCEGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public InventionInstanceIdData IIJDFPOELMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool GMDHHJLIIPE;

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x7A943F0", Offset = "0x7A92DF0", VA = "0x187A943F0")]
	public IONIAJKGNBH(long ICHIIHCEGJD, Guid IIJDFPOELMP, bool GMDHHJLIIPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[ServiceLifetime(Lifetime.Application)]
public interface HHCLOLPOAPN
{
	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BKBJBOFJLGE MBBJCNIJJME(KPELGGMCHHD FOGEPJODCLG, int JDEINBJFFIL = 0, bool BNDKFIAEDLB = false);

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JJOBNFNOHNN IGMOIPHLDMG(KPELGGMCHHD FOGEPJODCLG, ECEDHFIPBHO HGBJMKAPAJA, [In] UniformTRS OIACALEFNOH, DHFOCPKOKGI INGAOCHLELG, [Optional] IONIAJKGNBH JANNDCFADNC, bool KIPJNMNNJHK = true, bool KLAMDKBMFIH = false, bool BNDKFIAEDLB = false);

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DGDOMIFEPAN LJNGLNLIGCD();

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DGDOMIFEPAN BCPHNIHCAJK(KFKFMJGCIBC HOBPLOGKOBP, [In] UniformTRS ADMFFMCBABK, [Optional] DHFOCPKOKGI JOEPGIIFNMC);

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NDBGMCPNCBC(ECEDHFIPBHO AFBDIDBNKGC);

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KLIIKNBHLGA(ECEDHFIPBHO AFBDIDBNKGC, [Out] Exception MDJLCJHKPHD);

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<MNGNDNIEHNP> GKCPNHOBDOP(ECEDHFIPBHO AFBDIDBNKGC, Allocator DDBBFOCJEFL);

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeArray<MNGNDNIEHNP> MEAGOHGFGHP(ECEDHFIPBHO AFBDIDBNKGC, Allocator DDBBFOCJEFL);

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KFKFMJGCIBC HLABNMEDAHL(ECEDHFIPBHO AFBDIDBNKGC, Allocator DDBBFOCJEFL);

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KFKFMJGCIBC HNCGFECDPKL(ECEDHFIPBHO AFBDIDBNKGC, Allocator DDBBFOCJEFL);

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KFKFMJGCIBC AECDHHLCCFN(ECEDHFIPBHO AFBDIDBNKGC, Allocator DDBBFOCJEFL);

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> FNOHDDLDHLM(ECEDHFIPBHO AFBDIDBNKGC, Allocator DDBBFOCJEFL);

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool KLNBCIKNJNA(ECEDHFIPBHO AFBDIDBNKGC);

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int NOKDHKCHFPO(ECEDHFIPBHO AFBDIDBNKGC, int PGJKBFGEJNK);
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[ServiceLifetime(Lifetime.Application)]
public interface CAJMJJNIEOC
{
	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0xD66520", Offset = "0xD64F20", VA = "0x180D66520", Slot = "0")]
	bool BODMEEJLOED(object GLECKDJIKIL, HLCLMIGFJLH IALOAICAFFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class MOHICLDIJNE
{
	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x7A99C70", Offset = "0x7A98670", VA = "0x187A99C70")]
	public static bool BODMEEJLOED(this CAJMJJNIEOC GCGBBJOEAED, object GLECKDJIKIL, [Out] HLCLMIGFJLH IALOAICAFFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public enum KNLIEPDMCAA : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	MaxPlayers = byte.MaxValue,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	IsVisible = 254,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	IsOpen = 253,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	PlayerCount = 252,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Removed = 251,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	PropsListedInLobby = 250,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	CleanupCacheOnLeave = 249,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	MasterClientId = 248,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	ExpectedUsers = 247,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	PlayerTtl = 246,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	EmptyRoomTtl = 245,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	HasDedicatedMaster = 87
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface HLCLMIGFJLH
{
	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	OJCJCAFGJEL ABBLELNBDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	JKHDNFMHOCD LICHLKNELCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	bool JIDEEGBEELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E7")]
	bool DEBMOIBPMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0xEB0CA0", Offset = "0xEAF6A0", VA = "0x180EB0CA0", Slot = "4")]
	(JKHDNFMHOCD, Dictionary<object, object>) PHABGBOCAIE()
	{
		return default((JKHDNFMHOCD, Dictionary<object, object>));
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "5")]
	(MNGNDNIEHNP, JKHDNFMHOCD) DDFJIJONJKJ()
	{
		return default((MNGNDNIEHNP, JKHDNFMHOCD));
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "6")]
	IMMIBLOAIDI<(MNGNDNIEHNP, JKHDNFMHOCD)> BAFBFAFHNBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "7")]
	IMMIBLOAIDI<EKFNOCNPMID> AMNGBFMOLHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0xEB0CA0", Offset = "0xEAF6A0", VA = "0x180EB0CA0", Slot = "8")]
	(BHMFNJNGEHN, byte[]) EKFKCMHEBFC()
	{
		return default((BHMFNJNGEHN, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0xEB0CA0", Offset = "0xEAF6A0", VA = "0x180EB0CA0", Slot = "9")]
	(PEEMFHDLDKA, byte[]) FOBNMCPHADI()
	{
		return default((PEEMFHDLDKA, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0xEB0CA0", Offset = "0xEAF6A0", VA = "0x180EB0CA0", Slot = "10")]
	T JINKEBIBEHI<T>()
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class JDNGHKJAMDN
{
	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x7A95100", Offset = "0x7A93B00", VA = "0x187A95100")]
	public static bool OHKBGPGBBBL(this HLCLMIGFJLH LJPMILNMIFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public interface EKFNOCNPMID : IMMIBLOAIDI<DHIJOKOLFJM>
{
	[Cpp2IlInjected.Token(Token = "0x170001E8")]
	MNGNDNIEHNP ADNGAANLBDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[DefaultMember("Item")]
public interface IMMIBLOAIDI<T>
{
	[Cpp2IlInjected.Token(Token = "0x170001E9")]
	T NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EA")]
	int NIKDNFEJMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public enum OJCJCAFGJEL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	BulkInstantiate = 1,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	BulkDestroy = 2,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	EACMessage = 3,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	OMSendPacket = 4,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	RR_OutOfBandMessage = 5,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	RR_FastForwardMarker = 6,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	RR_SelfJoinMarker = 7,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	RR_DebugOp = 10,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	RR_CachedEvent = 11,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	RRRoomRequestEvent = 20,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	RRRoomRequestFailedResponseEvent = 21,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	RRBufferedRoomEvent = 22,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	RRClearBufferedRoomEvent = 23,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	RR_CreationOp = 24,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	RR_CreationOpResponse = 25,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	RR_CreationOp_Unchecked = 26,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	RR_MasterLockBlockComplete = 27,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	RPC = 200,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	SendSerialize = 201,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	Instantiation = 202,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	CloseConnection = 203,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	Destroy = 204,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	RemoveCachedRPCs = 205,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	SendSerializeReliable = 206,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	DestroyPlayer = 207,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	OwnershipRequest = 209,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	OwnershipTransfer = 210,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	VacantViewIds = 211,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	OwnershipUpdate = 212,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	AuthEvent = 223,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	LobbyStats = 224,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	AppStats = 226,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	Match = 227,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	QueueState = 228,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	GameListUpdate = 229,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	GameList = 230,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	CacheSliceChanged = 250,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	ErrorInfo = 251,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	PropertiesChanged = 253,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	Leave = 254,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	Join = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public enum BHMFNJNGEHN : uint
{
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	None = 0u,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	NetworkTransformInitializationData = 1314146628u,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	RestoreCreationData = 1380140064u,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	OldestCachedPacketId = 1329811529u,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	SnapshotPublished = 1397773634u,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	SnapshotPayload = 1397771332u,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	SnapshotClear = 1129337683u
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public static class BDDIFHPCJLA
{
	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x7A86E80", Offset = "0x7A85880", VA = "0x187A86E80")]
	public static MNGNDNIEHNP FIIJJAEAPEO(this IODNIGOKEMO DFPGGEDGGGN)
	{
		return default(MNGNDNIEHNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x7A87140", Offset = "0x7A85B40", VA = "0x187A87140")]
	public static MNGNDNIEHNP LLPKEHCGCND([In] this IODNIGOKEMO DFPGGEDGGGN)
	{
		return default(MNGNDNIEHNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x7A13BD0", Offset = "0x7A125D0", VA = "0x187A13BD0")]
	public static MNGNDNIEHNP ODGIPPBIEFL(this IODNIGOKEMO DFPGGEDGGGN)
	{
		return default(MNGNDNIEHNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x7A13BD0", Offset = "0x7A125D0", VA = "0x187A13BD0")]
	public static ViewId HIGJLIGJKHL(this IODNIGOKEMO DFPGGEDGGGN)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x7A87190", Offset = "0x7A85B90", VA = "0x187A87190")]
	public static FixedString64Bytes MHCCEBHEIBP(this NLLAEBLBHHD ICHIIHCEGJD)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x7A86EC0", Offset = "0x7A858C0", VA = "0x187A86EC0")]
	public static FixedString64Bytes GONGFJCFBIK(this MNGNDNIEHNP ICHIIHCEGJD)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x7A87340", Offset = "0x7A85D40", VA = "0x187A87340")]
	public static FixedString32Bytes MHCCEBHEIBP(this Entity CGNAGBGLBDK)
	{
		return default(FixedString32Bytes);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BGAIIDNJPPP : FPDAMLANPLH
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public enum CNBNBPIPPIA
{
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	End,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MGOIPOJOJAJ
{
	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event Action<object> KHBJDAEHGNC;

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "2")]
	void IDGAOJOJMCN(object GLECKDJIKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "3")]
	void KCIINHIDOJN(PEEMFHDLDKA HBNNPNFAEOC, ReadOnlySpan<byte> ECGNDACMANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "4")]
	void EHGCCFIAGMG(BHMFNJNGEHN OHCGINPDMEI, ReadOnlySpan<byte> ECGNDACMANN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GENMPNAAOGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PEEMFHDLDKA IADGPCFAODC(ReadOnlySpan<byte> ECGNDACMANN);
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CFMLAOCAKEO
{
	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NMLNEOMDADK(PEEMFHDLDKA NJBPFCDJFGD, ReadOnlySpan<byte> ECGNDACMANN);

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DDCIAMOIHGP(ReadOnlySpan<PEEMFHDLDKA> IBPDAMHPHPA);
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public struct EOOJJACECPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public PEEMFHDLDKA HBNNPNFAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public ReadOnlyMemory<byte> ECGNDACMANN;
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public struct PEEMFHDLDKA
{
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static PEEMFHDLDKA OHJIGLPGNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public NLLAEBLBHHD COIFLLKNIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public int OLCMOLLGBMD;

	[Cpp2IlInjected.Token(Token = "0x170001EB")]
	public static NLLAEBLBHHD LPJPLFEAOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x7A9B210", Offset = "0x7A99C10", VA = "0x187A9B210")]
		get
		{
			return default(NLLAEBLBHHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x4E9FCC0", Offset = "0x4E9E6C0", VA = "0x184E9FCC0")]
	public PEEMFHDLDKA(NLLAEBLBHHD COIFLLKNIJD, int OLCMOLLGBMD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B180", Offset = "0x7A99B80", VA = "0x187A9B180")]
	public static bool HFGMMLFJJJB([In] PEEMFHDLDKA HIHOACCANFP, [In] PEEMFHDLDKA JJEIFHEKJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B020", Offset = "0x7A99A20", VA = "0x187A9B020", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B120", Offset = "0x7A99B20", VA = "0x187A9B120", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B260", Offset = "0x7A99C60", VA = "0x187A9B260", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B010", Offset = "0x7A99A10", VA = "0x187A9B010")]
	public void EHJACGLEOBL([Out] NLLAEBLBHHD GFDJFLGIFIE, [Out] int OLCMOLLGBMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public static class NAIAKOIDDKA
{
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public struct KIJIDFMADEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public Guid BIGAPECKJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public string HGOJKHNLDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public Vector3 KKIJMCHODGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public Quaternion KONJHPLFEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public Vector3 GFDDEGDNEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public int AADHCIPDIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public PDJBLPFEHEB KHABEFHMCBM;

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x7A96790", Offset = "0x7A95190", VA = "0x187A96790", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public enum DMFBJOKGNGE
{
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	Scene,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	SubgraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	SubgraphRestore,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	RestoreCreationData,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	InventionPreview
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public static class OEFCBOBCOIM
{
	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x7A9A6B0", Offset = "0x7A990B0", VA = "0x187A9A6B0")]
	public static bool ANJCHGFMGJF(this DMFBJOKGNGE OHCGINPDMEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x7A9A6D0", Offset = "0x7A990D0", VA = "0x187A9A6D0")]
	public static bool HJMLMGNMHID(this DMFBJOKGNGE OHCGINPDMEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x7A9A6E0", Offset = "0x7A990E0", VA = "0x187A9A6E0")]
	public static bool KHMFPKJNNHC(this DMFBJOKGNGE OHCGINPDMEI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[Flags]
public enum JEHALPKBMDI
{
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	WorldPhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	AdditivePhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public interface DHFOCPKOKGI
{
	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IFHBDFLEPBB([In] Guid KKMIKMKCMKE, [Out] Guid GNMBGILIMLJ);
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
[Flags]
public enum EIGFOLMKODI
{
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public interface DGDOMIFEPAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001EC")]
	IECNIPLHCGM EIEMHJDPHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString PNLEFLCBCMJ();
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public enum JPLKDMLDFND
{
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[TypeManager.ForcedStableTypeHash(8944033191217631913uL)]
public struct GEGDOBJALJL : ISystemStateComponentData, IComponentData, IEquatable<GEGDOBJALJL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public float3 BAICAHEDIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public float3 LKFINJBFHDK;

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x7A90300", Offset = "0x7A8ED00", VA = "0x187A90300", Slot = "4")]
	public bool Equals(GEGDOBJALJL OLKLGHOAKNE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MABKIBFMGPO
{
	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GMIAEJHOEHH(long NIFPOEHKIAM);

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGILCLIMHJO(NativeParallelHashSet<long> OFEGJDBEBEB);

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OJBICIANMGB(World ILOAGCFCJMA, NativeParallelHashMap<Guid, long> IKEKHCIOGKI);

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CFNIPOCMPME(MNGNDNIEHNP NBMFEEBJLOH);

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JAHKEIDPHKH(MNGNDNIEHNP NBMFEEBJLOH, [Out] Guid HPMOAAMKJPC, [Out] long NIFPOEHKIAM);

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HKKJIIPGBEE(MNGNDNIEHNP NBMFEEBJLOH, Guid HPMOAAMKJPC, long NIFPOEHKIAM);

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GGHANEIKOBJ(Guid HPMOAAMKJPC);

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DOFHBLICJOM(Guid HPMOAAMKJPC, [Out] int FLOIGHEIELM, [Out] int MDJDPHNKEFK);

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KNADDMBLEHC(Guid HPMOAAMKJPC, int FLOIGHEIELM, int MDJDPHNKEFK);

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ICPKACJEIJN(Guid HPMOAAMKJPC);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public class LPHLOPHCPMO
{
	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public LPHLOPHCPMO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
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
