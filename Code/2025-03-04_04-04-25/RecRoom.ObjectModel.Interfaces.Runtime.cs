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
	public class LogRegistrationIndex : EIAOKFHFGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x768A990", Offset = "0x7688F90", VA = "0x18768A990", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JADDAJAKIEF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7684D50", Offset = "0x7683350", VA = "0x187684D50")]
	public static void KENFBHMLJBA(this Rigidbody OLLDADPKNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7684C20", Offset = "0x7683220", VA = "0x187684C20")]
	public static void KENFBHMLJBA(this Rigidbody OLLDADPKNPC, Vector3 PLMKEIBFICP, Quaternion KMLKLHHAONB, Vector3 CBCNENALPMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct PCANLNGHNBK : IReadOnlyList<FHNHGOPNICC>, IEnumerable<FHNHGOPNICC>, IEnumerable, IReadOnlyCollection<FHNHGOPNICC>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct LDKKNBPLJAF : IEnumerator<FHNHGOPNICC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly ANDACNBFJKF JJPIAJMIOLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator KGHMANIHPMP;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public FHNHGOPNICC FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7688220", Offset = "0x7686820", VA = "0x187688220", Slot = "4")]
			get
			{
				return default(FHNHGOPNICC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x76881D0", Offset = "0x76867D0", VA = "0x1876881D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4B9E640", Offset = "0x4B9CC40", VA = "0x184B9E640")]
		public LDKKNBPLJAF(ANDACNBFJKF JJPIAJMIOLG, NativeArray<LocalId>.Enumerator KGHMANIHPMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7688110", Offset = "0x7686710", VA = "0x187688110", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7688150", Offset = "0x7686750", VA = "0x187688150", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7688190", Offset = "0x7686790", VA = "0x187688190", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly AEGEMGIHCCJ ILIIBOPHLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> KDAGENDCBLC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FHNHGOPNICC NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7690890", Offset = "0x768EE90", VA = "0x187690890", Slot = "4")]
		get
		{
			return default(FHNHGOPNICC);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7690190", Offset = "0x768E790", VA = "0x187690190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int OHGBMKHLCNA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9501A0", Offset = "0x94E7A0", VA = "0x1809501A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ANDACNBFJKF EGGGEPPGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x76903D0", Offset = "0x768E9D0", VA = "0x1876903D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int AFNDGLAJDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9501A0", Offset = "0x94E7A0", VA = "0x1809501A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool LCHDPNFEMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7690250", Offset = "0x768E850", VA = "0x187690250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> GMAMCIEENDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF310", Offset = "0x2BBD910", VA = "0x182BBF310")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> LMHAGNABNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x76901F0", Offset = "0x768E7F0", VA = "0x1876901F0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x76907E0", Offset = "0x768EDE0", VA = "0x1876907E0")]
	public PCANLNGHNBK(int CCAKDDNOMFJ, ANDACNBFJKF JJPIAJMIOLG, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x76907D0", Offset = "0x768EDD0", VA = "0x1876907D0")]
	public PCANLNGHNBK(AEGEMGIHCCJ ILIIBOPHLDK, NativeArray<LocalId> KDAGENDCBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7690660", Offset = "0x768EC60", VA = "0x187690660")]
	public PCANLNGHNBK(AEGEMGIHCCJ ILIIBOPHLDK, NativeArray<Entity> KDAGENDCBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x76906D0", Offset = "0x768ECD0", VA = "0x1876906D0")]
	internal PCANLNGHNBK(ANDACNBFJKF JJPIAJMIOLG, NativeArray<Entity> AKCBEPDCJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7690760", Offset = "0x768ED60", VA = "0x187690760")]
	internal PCANLNGHNBK(ANDACNBFJKF JJPIAJMIOLG, NativeArray<LocalId> KDAGENDCBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x76905B0", Offset = "0x768EBB0", VA = "0x1876905B0")]
	public PCANLNGHNBK(ANDACNBFJKF JJPIAJMIOLG, int GIGAFKHMOHH, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7690500", Offset = "0x768EB00", VA = "0x187690500")]
	public PCANLNGHNBK(PCANLNGHNBK HDCIPPHECII, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x768FD40", Offset = "0x768E340", VA = "0x18768FD40")]
	public void DCNHFJIJBBF(List<FHNHGOPNICC> BHMKCPLLJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x768FFB0", Offset = "0x768E5B0", VA = "0x18768FFB0")]
	public void DJJCEMFAJHG(int EAHKFAJBNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7690290", Offset = "0x768E890", VA = "0x187690290")]
	public PCANLNGHNBK KKJJGGFFFGK(Allocator LEILKJFLDFN)
	{
		return default(PCANLNGHNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7690000", Offset = "0x768E600", VA = "0x187690000")]
	public Span<FHNHGOPNICC> DNDGFDNMALG()
	{
		return default(Span<FHNHGOPNICC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7690330", Offset = "0x768E930", VA = "0x187690330")]
	public PCANLNGHNBK PAMHNKDCMKL(int HHIGALLBHNK, int GIGAFKHMOHH)
	{
		return default(PCANLNGHNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7690150", Offset = "0x768E750", VA = "0x187690150", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x768FC80", Offset = "0x768E280", VA = "0x18768FC80")]
	public LDKKNBPLJAF BNIMLGJMJBK()
	{
		return default(LDKKNBPLJAF);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7690420", Offset = "0x768EA20", VA = "0x187690420", Slot = "6")]
	private IEnumerator<FHNHGOPNICC> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7690490", Offset = "0x768EA90", VA = "0x187690490", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class PNDBLFDLEGP
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3613370", Offset = "0x3611970", VA = "0x183613370")]
	public static JLFIEIINFCM<T> NNBNOMOKLMI<T>(this PCANLNGHNBK MOEBIEOOLFC) where T : Component
	{
		return default(JLFIEIINFCM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public struct PCENCNMKLOB : IList<FHNHGOPNICC>, ICollection<FHNHGOPNICC>, IEnumerable<FHNHGOPNICC>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct FCAFMJNPPLA : IEnumerator<FHNHGOPNICC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly ANDACNBFJKF JJPIAJMIOLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator KGHMANIHPMP;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public FHNHGOPNICC FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7680B40", Offset = "0x767F140", VA = "0x187680B40", Slot = "4")]
			get
			{
				return default(FHNHGOPNICC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7680AF0", Offset = "0x767F0F0", VA = "0x187680AF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4B9E640", Offset = "0x4B9CC40", VA = "0x184B9E640")]
		public FCAFMJNPPLA(ANDACNBFJKF JJPIAJMIOLG, NativeArray<LocalId>.Enumerator KGHMANIHPMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7680A30", Offset = "0x767F030", VA = "0x187680A30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7680A70", Offset = "0x767F070", VA = "0x187680A70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7680AB0", Offset = "0x767F0B0", VA = "0x187680AB0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly ANDACNBFJKF JJPIAJMIOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> KDAGENDCBLC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FHNHGOPNICC NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7691560", Offset = "0x768FB60", VA = "0x187691560", Slot = "4")]
		get
		{
			return default(FHNHGOPNICC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7691650", Offset = "0x768FC50", VA = "0x187691650", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7691130", Offset = "0x768F730", VA = "0x187691130", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int AFNDGLAJDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7691130", Offset = "0x768F730", VA = "0x187691130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> GMAMCIEENDN
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF310", Offset = "0x2BBD910", VA = "0x182BBF310")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool NJEEMOHCODN
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7691450", Offset = "0x768FA50", VA = "0x187691450")]
	public PCENCNMKLOB(ANDACNBFJKF JJPIAJMIOLG, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x76914D0", Offset = "0x768FAD0", VA = "0x1876914D0")]
	public PCENCNMKLOB(ANDACNBFJKF JJPIAJMIOLG, int GIGAFKHMOHH, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7691020", Offset = "0x768F620", VA = "0x187691020")]
	public PCANLNGHNBK JMMFOEIKCJJ()
	{
		return default(PCANLNGHNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7690C00", Offset = "0x768F200", VA = "0x187690C00", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7690C40", Offset = "0x768F240", VA = "0x187690C40", Slot = "13")]
	public bool Contains(FHNHGOPNICC MBDDOPABDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7690CD0", Offset = "0x768F2D0", VA = "0x187690CD0", Slot = "14")]
	public void CopyTo(FHNHGOPNICC[] CJFOOLJEHLK, int BJJLGILDBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7690AF0", Offset = "0x768F0F0", VA = "0x187690AF0", Slot = "11")]
	public void Add(FHNHGOPNICC MBDDOPABDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7690F70", Offset = "0x768F570", VA = "0x187690F70", Slot = "7")]
	public void Insert(int EAHKFAJBNDN, FHNHGOPNICC MBDDOPABDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x76911C0", Offset = "0x768F7C0", VA = "0x1876911C0", Slot = "15")]
	public bool Remove(FHNHGOPNICC MBDDOPABDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7690EE0", Offset = "0x768F4E0", VA = "0x187690EE0", Slot = "6")]
	public int IndexOf(FHNHGOPNICC MBDDOPABDGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7691170", Offset = "0x768F770", VA = "0x187691170", Slot = "8")]
	public void RemoveAt(int EAHKFAJBNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7690EA0", Offset = "0x768F4A0", VA = "0x187690EA0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7690B70", Offset = "0x768F170", VA = "0x187690B70")]
	public FCAFMJNPPLA BNIMLGJMJBK()
	{
		return default(FCAFMJNPPLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7691290", Offset = "0x768F890", VA = "0x187691290", Slot = "16")]
	private IEnumerator<FHNHGOPNICC> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7691370", Offset = "0x768F970", VA = "0x187691370", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MLNIHIMLLFL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FHNHGOPNICC LGIFLKDNMCB(FHNHGOPNICC KDAGENDCBLC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EBKCFEDHNBB : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface JLGJNLMEKNG : LLIJEKOFHPN, PEPCDDOCDNO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	HEMIOEPGHGJ PFKCPNBFIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	KOJAMECNJEF NLDGJODPDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	AEGEMGIHCCJ PLBIHHBNEKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface PEPCDDOCDNO
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool COJHKELOEJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.Application)]
public interface CMOPCCCCBNO
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NNAKINMLDOH(bool KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KKIOKOIHHPE();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface EDDNFLGGNCP
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool HMJLNLMDMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool CPFBFMLFFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool NIKLHAIEMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool IAMBHEBPFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool AMGBCGJMIAO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JBCADINJCCP(bool GCDMKJKGKMA);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FMMHKJLDPEC(ByteString AFMJILKOIND);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BDMKFKFBLDL();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NANACBHIMAI();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BKHNKCMPEJH();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.Application)]
public interface KOJAMECNJEF
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	APLBLLDKDCG PFKCPNBFIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	FMLKHCFGBCI OPLKDHGAEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	PGELPCAAOPM JCDLAFNKMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	JLGJNLMEKNG MNPIJNNOECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	DPBEBOPHMGB KCJMPFMMELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	EDDNFLGGNCP EGNFDNAHNJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	PGCIHGMCKEE BPOBAIJOMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	HJODKEHGPJN CJNGFBIDHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	GIFNIBDCFIP BNGGIMLJOGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	IMLCHGCIBDL FLDIKFAONCC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	PFMKCGLAJFE KFLIBLIKNIP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	IEPAOKKIIIO NMCGKNNJBGL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	ANDACNBFJKF EGGGEPPGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	PGAOOIFDBBC ENNJFINEENK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	IALGJCOKLIO MOPNFKEBMFI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CFLNNNFPHBA JCKNPCLMBCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	GCBFHACKPEG CNPGAOKDPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	POMLDMADPGA DFDEEMFBIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	BPLJCDNMHGN GFHDNGFPMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	KAGOHBOHHHF FJCMOCGODIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	KOJAFJBMJFD CELIILEFAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	FNHIKEJNFOA BHFBNHPNGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NPONJMFEIBM GBBBMBCGCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	NENGGIIPFNE OEHPILMJGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	OHHBLDMFDPB MKNNHPDPPJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	ALAIBBMINGM ICCEFKIECNA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	LNGDPPIAHJG BPDNFAAPEPL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	FDJNGADHLPI KMNIOGMIMKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	GBPADHKLFCC CGEMBAPJEED
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	ELBCPBMHNBO IHNIEJPBIKM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	NFMPJODALLJ KEJBLDLHIMI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	GDMALILFBDO GAHPOFMMCLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	EHEDDPDOCFC MFKNAMLPKEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DebuggerTypeProxy(typeof(IDCNNDNAKLN))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct FHNHGOPNICC : IComparable<FHNHGOPNICC>, IEquatable<FHNHGOPNICC>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly FHNHGOPNICC NACGKDEGDLG;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int DFBCIAAMOHM = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int IDFNJOAJDMH = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int NBHAELLLALG = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int OPHILKJEDAD = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId KPOCLGHHOEP;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public ANDACNBFJKF EGGGEPPGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x767F520", Offset = "0x767DB20", VA = "0x18767F520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public JLGJNLMEKNG MNPIJNNOECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7680F50", Offset = "0x767F550", VA = "0x187680F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public LocalId OGFOOBGNEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7680FB0", Offset = "0x767F5B0", VA = "0x187680FB0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	internal AEGEMGIHCCJ PLBIHHBNEKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x76815B0", Offset = "0x767FBB0", VA = "0x1876815B0")]
		get
		{
			return default(AEGEMGIHCCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool GAJJJBGADKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7681110", Offset = "0x767F710", VA = "0x187681110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private bool DJFDAIPBACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7681560", Offset = "0x767FB60", VA = "0x187681560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x76816F0", Offset = "0x767FCF0", VA = "0x1876816F0")]
	public FHNHGOPNICC(ANDACNBFJKF CMBKNOODMNE, LocalId KPOCLGHHOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x76817B0", Offset = "0x767FDB0", VA = "0x1876817B0")]
	public FHNHGOPNICC(AEGEMGIHCCJ ILIIBOPHLDK, LocalId KPOCLGHHOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
	public JHDEHBMJKKK BOJCMAKKIAM()
	{
		return default(JHDEHBMJKKK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x76814C0", Offset = "0x767FAC0", VA = "0x1876814C0")]
	public static LocalId HEGJABMHLEC(FHNHGOPNICC NFNFJFJJBBH)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7681500", Offset = "0x767FB00", VA = "0x187681500")]
	public static Entity HEGJABMHLEC(FHNHGOPNICC NFNFJFJJBBH)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7680FF0", Offset = "0x767F5F0", VA = "0x187680FF0")]
	public static bool BFIJCNNIIMH(FHNHGOPNICC AMGCKABOOPF, FHNHGOPNICC PPCFCAEIJMM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7681540", Offset = "0x767FB40", VA = "0x187681540")]
	public static bool HKDAGECLGLD(FHNHGOPNICC AMGCKABOOPF, FHNHGOPNICC PPCFCAEIJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x76815C0", Offset = "0x767FBC0", VA = "0x1876815C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7681320", Offset = "0x767F920", VA = "0x187681320", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7681230", Offset = "0x767F830", VA = "0x187681230", Slot = "4")]
	public int CompareTo(FHNHGOPNICC OKCHLIEAIJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "5")]
	public bool Equals(FHNHGOPNICC OKCHLIEAIJP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FALJEAIBGFI
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7680900", Offset = "0x767EF00", VA = "0x187680900")]
	public static GFBOHEINDFO CPAPHHKAGLH(this FHNHGOPNICC GMFKPONAANG)
	{
		return default(GFBOHEINDFO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class IDCNNDNAKLN
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct AEGEMGIHCCJ : IEquatable<AEGEMGIHCCJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly byte ILIIBOPHLDK;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static byte[] FEJHOLHIAPJ;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static ANDACNBFJKF HIFIKNICDPC;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static JLGJNLMEKNG HLJAGOGCNEP;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static ANDACNBFJKF[] KEKDMGJACNC;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static JLGJNLMEKNG[] JJHABGEPBEN;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static Stack<byte> JDDGEDNEKKJ;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public JLGJNLMEKNG MNPIJNNOECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x767C630", Offset = "0x767AC30", VA = "0x18767C630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public ANDACNBFJKF CCGCANPAOLN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x767CE10", Offset = "0x767B410", VA = "0x18767CE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x767D530", Offset = "0x767BB30", VA = "0x18767D530")]
	static AEGEMGIHCCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x27743C0", Offset = "0x27729C0", VA = "0x1827743C0")]
	internal AEGEMGIHCCJ(byte KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6651690", Offset = "0x664FC90", VA = "0x186651690", Slot = "4")]
	public bool Equals(AEGEMGIHCCJ OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x767CB60", Offset = "0x767B160", VA = "0x18767CB60", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xD77BA0", Offset = "0xD761A0", VA = "0x180D77BA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x767D470", Offset = "0x767BA70", VA = "0x18767D470", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x767D3C0", Offset = "0x767B9C0", VA = "0x18767D3C0")]
	private static ANDACNBFJKF PFECCHLALNA(byte ILIIBOPHLDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x767CAA0", Offset = "0x767B0A0", VA = "0x18767CAA0")]
	private static JLGJNLMEKNG DFNHLOAOHIH(byte ILIIBOPHLDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x767D240", Offset = "0x767B840", VA = "0x18767D240")]
	private static object OIKOGECPPOO(byte ILIIBOPHLDK, object[] BMKDAHEBDHE, object IDJBNLNBJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x767D3B0", Offset = "0x767B9B0", VA = "0x18767D3B0")]
	private static int ONFEBNFGIAN(byte ILIIBOPHLDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x767CF70", Offset = "0x767B570", VA = "0x18767CF70")]
	private static int MJGCPNEONAH(byte ILIIBOPHLDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x767CEF0", Offset = "0x767B4F0", VA = "0x18767CEF0")]
	private static (int, int) IKCPHPENKPA(byte ILIIBOPHLDK)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x767CB50", Offset = "0x767B150", VA = "0x18767CB50")]
	private static byte DIFHPLMHODF(int EPKMALKPPHD, int EAHKFAJBNDN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x767CF80", Offset = "0x767B580", VA = "0x18767CF80")]
	internal static AEGEMGIHCCJ OCICFIBHEPA(JLGJNLMEKNG NBECHPHNOPH, ANDACNBFJKF BGEKAAMBMEF)
	{
		return default(AEGEMGIHCCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x767CC00", Offset = "0x767B200", VA = "0x18767CC00")]
	internal static void IBEJEPFGGMM(AEGEMGIHCCJ ILIIBOPHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x767C710", Offset = "0x767AD10", VA = "0x18767C710")]
	private static void CANFNLHFDFB(int CCAKDDNOMFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum HPFICBFBEJH
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
[ServiceLifetime(Lifetime.Application)]
public interface ELPLDANEMFG
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Guid MEIBALMGCHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CFCAOPJNGAA(Guid NKNBCGMJPLG, Guid MEGMENINLOE, Guid GCICPGKPGFI);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task GGNFNMNIOOM(Guid NKNBCGMJPLG, Guid[] GNFNEFOKFHF, Guid GCICPGKPGFI);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid PILIGIKIAAA(Guid JLMDJNDONMA);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task IPADNCCMFPI(FHNHGOPNICC DPBDBJENELC);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EFHBNNHGLIC(Guid JLMDJNDONMA);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JDIOALDCHPG(MANJAEAMIEB PDDFMAJDLIB, Guid OFNKNFMEKEE);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BLCPOHLNMJK(Guid JLMDJNDONMA, bool GCDMKJKGKMA);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[ServiceLifetime(Lifetime.Application)]
public interface NMLBDKMKDCC
{
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[ServiceLifetime(Lifetime.Application)]
public interface IEMICDFJMLH
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CKDOKEIFAGO(GameObject IJHKKOLKDEL, GameObject CLIKBLHKIIM, int IGEFECFIJLF);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[ServiceLifetime(Lifetime.Application)]
public interface FENLNFNGNEK
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "0")]
	void PCJANBNHGHP(bool BDDPPMGPFHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface FMLKHCFGBCI
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	FENLNFNGNEK DCJEFKLHCGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	IOBGNMMOIIJ BDJBDGHMCKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	DOLCNOHBJFN KFHBLOKIBAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	PCCLMNMMGOB IGKPLCBBICD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	OKOHFBPGIKA EHDKPEHHPDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	HPCELMLOBHJ CCIDBLMDGGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	IEEJJOCNKOI IBLPJEKJIIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	BGJMHJBFBFB IFCICNHJCJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface IOBGNMMOIIJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string NHAHEDAHDFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[ServiceLifetime(Lifetime.Application)]
public interface GPIIAPONMNE
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JCGCBFMDOFP(Action PJDAFKMDDCG, bool KJJGJHGONFF);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EBHKMFNDAFM(string OMOOEGOLALI);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int BBNEDFGFMOB(string OMOOEGOLALI, int IDJBNLNBJCD);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EBMKDMJHKMH([Out] bool KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FKIIPKJEGFJ([Out] bool KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MNIMELJPPBB([Out] int KBGCCIOIGBD);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[ServiceLifetime(Lifetime.Application)]
public interface DOLCNOHBJFN
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "0")]
	void DCHJGNFLINJ(bool GCDMKJKGKMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.Application)]
public interface PCCLMNMMGOB
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	protected static readonly Guid IBBHMMLFNHP;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	static readonly Guid MKCKKKOLOFF;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	static readonly Guid PCIKCGDHDPH;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	static readonly Guid HOCLJGCJAII;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool KEFDLJHJEPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool DDGOLGCKJLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool BNKJABDLNHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7690940", Offset = "0x768EF40", VA = "0x187690940", Slot = "3")]
	string[] JNEFFOJNLKO(PLEGJMDHKHI OCPBOBGPENE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LPHJBPHKGNP();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7690910", Offset = "0x768EF10", VA = "0x187690910", Slot = "5")]
	Guid BOFBBEFKODF(Guid DJCNBKHHDNE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int ILINEPFLIEG(PLEGJMDHKHI OCPBOBGPENE);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DEFGOOOADEE(PLEGJMDHKHI OCPBOBGPENE, NativeArray<LFCNJIPFIBC> FFMDKNBBIDF, NativeList<UniformTRS> LDPFGLNPENE);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int ABCHFIALDFA(Guid JINNLDEOCMO);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JMHFNODBNKM(string HEEFCLHHCJJ, [Out] Guid JINNLDEOCMO);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string OHPEONLPPIO(Guid JINNLDEOCMO);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OCNPOBFNGJP(RRObjectPrefabData FCAOLNNLJPH, [Out] LocalId FCJGDHPNMHF);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	GameObject MIHIJECOJLI(string HEEFCLHHCJJ);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AHAKFKAPGIA(Transform EJNLPEDOMDD, RRObjectPrefabData AEIJGOBBFHA, DBGGEFBGBDL BPPCEJGCMKA);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool GCNOBAJBODC(PLEGJMDHKHI OCPBOBGPENE, NativeParallelHashMap<Guid, LocalId> PDBKMPJHOIH, [Out] Exception BNMNAMAKIOH);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LMGHNCDOIAF(PLEGJMDHKHI OCPBOBGPENE, NativeParallelHashMap<Guid, LocalId> PDBKMPJHOIH, [Out] NativeArray<LocalId> AKCBEPDCJFL, [Out] NativeArray<LocalId> DMHMKEKNCJN, [Out] NativeArray<AuthoredLocalPoseData> BKAAMCHOIIO, Allocator LEILKJFLDFN);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "16")]
	void BEILPNIIIKC(PLEGJMDHKHI MIMFFPFKBEA, NativeArray<int> HKAJIOBOKII, EFMCPKJOHAF<GameObject> BILCNKNOJOK, JLFIEIINFCM<GameObject> EEKINEGOMPA, HPFICBFBEJH FMGMAMKAKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MHGKMCCKGBN();

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "18")]
	void JGLIICNKJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "19")]
	void PINHAAOCOKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "20")]
	bool CKBBGEIJKJO(PLEGJMDHKHI OCPBOBGPENE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "21")]
	MGGBHJLPOLE MIEEPACHJJG(PLEGJMDHKHI OCPBOBGPENE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x76909D0", Offset = "0x768EFD0", VA = "0x1876909D0")]
	static PCCLMNMMGOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface MGGBHJLPOLE
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NMHIIAHFLHB(NLKMKFKGELE MGOKPJKELJG, int EAHKFAJBNDN);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface PIBONJANKDC
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool KPDLFIACIPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool EPJNOKGFDHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool HCKEMBJGEMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool ICKHEDGIIGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool KIELANHDIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NLKMKFKGELE : PIBONJANKDC
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public enum FDHAOOAIMOM
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Environment = 0,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Decoration = 1,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Physical_Sticky = 2,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Physical = 4
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool OODGLHIFJMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool JOEDDEKHHJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool JKMJJDGOLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	int FCKFNGMLKBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NOGIHCAEBKN(EMPOMOFDPHK LFCFKCMCBCB, int EAHKFAJBNDN);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface EMPOMOFDPHK
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool KOKJJEEFCGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	OFHIFDOIEMG LGCJHPEGOEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	HLKJFJIIJCB KMOHBHNONJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	float3 NAMOIOBECGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	quaternion KGCMOGJCFFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	float3 PKJENICKIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	FLMNFNBLJCG IAODGAIPHAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	CPAENDDAKAG GKMLNPEPKPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	float INBIAHCDOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	float3 HDHBKBDNLLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	float APALEEOGEDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	EDJKJELJDNI GEJIFEELINC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface HLKJFJIIJCB
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool EJGEJEKCLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	bool KFEKJCLAOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool BOAGBKMLGEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	float PPAPPOJMPFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	int HOOGEGKJHIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	int DDEAECAGNJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FLGOKJDDBFB(DIHHKFPLCIH LFCFKCMCBCB, int EAHKFAJBNDN);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface DIHHKFPLCIH
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	float3 KOHIGCEHKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	float3 JCCHJCKKHHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	quaternion BMCNMGAIGJL(float3 CNOFPGCGFHF);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface KDLPMNCONOF
{
	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	long AHCOCLEFCCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	long OGBMDIDDMFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "1")]
		get
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface OKOHFBPGIKA
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	bool DIHDOFMHJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	bool ECHDLCKIPIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	int DMMOFKKFCNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	int KMDCADAAJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	int BKELHJFJGBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool LHDMKGHGMJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	int BMOPGIPBFOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "6")]
	void EIDENGANPGG(KBNMBGAIHKJ ODAGIILJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "7")]
	void EPKAJHHJPFI(bool IJCGJFMBKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "8")]
	bool GPKDGJKDAEB(NOONNECLOAO KHELFHBHLMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "9")]
	void MOIFJPCLECM(object GOAPBALNOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "10")]
	void ICCDDAJCFAF(object GOAPBALNOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "11")]
	void LDHIGBEEBDA(object MOCLCNOAHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "12")]
	void LHFJDKJKNJE(object MOCLCNOAHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "13")]
	void MELHECCOAOH(NativeArray<ViewId> KCFLPIBOOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "14")]
	void CMIJGHPKMKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "15")]
	void HKGHPBGCFEO(KMFPLICNEPB BMIPLDLMPCD, ReadOnlySpan<byte> GIDGOODJFLJ, NOONNECLOAO KDEGGOPAACC, bool LNJPBAEGAPL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "16")]
	void HKGHPBGCFEO(KMFPLICNEPB BMIPLDLMPCD, ReadOnlySpan<byte> LPKDNFKEKKI, bool LNJPBAEGAPL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "17")]
	void HKGHPBGCFEO(KMFPLICNEPB BMIPLDLMPCD, ReadOnlySpan<byte> LPKDNFKEKKI, ReadOnlySpan<byte> NHLFEGGEBMF, bool LNJPBAEGAPL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "18")]
	void PKIIEJADHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "19")]
	void MEAKANAPBMM(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "20")]
	void CDECOMCDJIB(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "21")]
	void GPKFGPNDJCI(Dictionary<object, object> JCHGKNDGBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "22")]
	void DHFCMCAJOJG(NativeList<GFBOHEINDFO> PKAIJDCJIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "24")]
	void GDKJKDMHIBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "25")]
	void IAKLIFDIFLD(List<object> HHONMODOICF, int EKDINNHMJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "26")]
	void LIKPOMBHBDH(int OLOJBBBJBOB, object NBGBHBICCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "27")]
	void MCADLJEGOJK(NOONNECLOAO KHELFHBHLMG, Dictionary<object, object> GHLDAFCMHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "28")]
	void NDBONFMDEOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "29")]
	void KBJKEGJDPMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class DHEGHGMNGJB
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7680600", Offset = "0x767EC00", VA = "0x187680600")]
	public static HDKHJAEGKMA BAEAHNMADNB(this OKOHFBPGIKA KPHLIDJMEFA, object LAAJFAFNFCN)
	{
		return default(HDKHJAEGKMA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct HDKHJAEGKMA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private OKOHFBPGIKA KPHLIDJMEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private object LAAJFAFNFCN;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7683900", Offset = "0x7681F00", VA = "0x187683900")]
	public HDKHJAEGKMA(OKOHFBPGIKA KPHLIDJMEFA, object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x76838B0", Offset = "0x7681EB0", VA = "0x1876838B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[ServiceLifetime(Lifetime.Application)]
public interface DGFABILIFIB
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[ServiceLifetime(Lifetime.Application)]
public interface HPCELMLOBHJ
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct JCLOJHJGODN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private HPCELMLOBHJ MGJIILNONMH;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7684FA0", Offset = "0x76835A0", VA = "0x187684FA0")]
		public JCLOJHJGODN(HPCELMLOBHJ MGJIILNONMH, string HJLOFBIEILC, string JGBPNOGAICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7684EE0", Offset = "0x76834E0", VA = "0x187684EE0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct NHELDJIDLCO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private HPCELMLOBHJ MGJIILNONMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Task CBPINBDBDCO;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x768D8B0", Offset = "0x768BEB0", VA = "0x18768D8B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "0")]
	void LHACKFDIDPA(string MIALAMIFNLM, float LKDAAJDJIMN = 5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "1")]
	void CBHKIPIOIOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FHOPNBIOHIK(bool OMJBCAAIGCJ, string HJLOFBIEILC, string JGBPNOGAICL);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "3")]
	void BOJOPONCLAO(string MIALAMIFNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class COJCCKBEMEM
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x767FF00", Offset = "0x767E500", VA = "0x18767FF00")]
	public static HPCELMLOBHJ.JCLOJHJGODN FEEFHLIGING(this HPCELMLOBHJ KPHLIDJMEFA, string HJLOFBIEILC, string JGBPNOGAICL)
	{
		return default(HPCELMLOBHJ.JCLOJHJGODN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[ServiceLifetime(Lifetime.Application)]
public interface LNBMLNKEEGF
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LIJKEEMPHIB(GameObject HHDLNMHBJJD);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IDJFHBCGGLN(GameObject HHDLNMHBJJD);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JEBOKBLOJNA(int KHELFHBHLMG);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object PKLIJHNENEF(FHNHGOPNICC KPOCLGHHOEP, GameObject HHDLNMHBJJD, Action<FHNHGOPNICC, int> IJCKFHFIADK);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ENFBKBIHHGK(GameObject HHDLNMHBJJD, object NFAKKAIAHOC);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[ServiceLifetime(Lifetime.Application)]
public interface CANCPLOHILK
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IMJDHHAECMF(object GMFKPONAANG, NativeList<byte> GIDGOODJFLJ);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object GFOCOOKFNLL(NativeArray<byte> GIDGOODJFLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[ServiceLifetime(Lifetime.Application)]
public interface LEKPNJAJHPC
{
	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool DKDKPMLLNMB
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate OFDOLJEOCDH(PDOOMAJLGEG KJBFPKEKDAM, Action<PDOOMAJLGEG> IJCKFHFIADK);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IKNMKMOIDOH(PDOOMAJLGEG KJBFPKEKDAM, Delegate IJCKFHFIADK);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate HBOAOONDDKJ(PDOOMAJLGEG KJBFPKEKDAM, Action<PDOOMAJLGEG> ECOFGABKICH);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HBGNPEMAOEO(PDOOMAJLGEG KJBFPKEKDAM, Delegate IJCKFHFIADK);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BFGJHJKGOIE(PDOOMAJLGEG KJBFPKEKDAM);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PDOOMAJLGEG FIIMPEMNIKJ(GameObject HHDLNMHBJJD);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[ServiceLifetime(Lifetime.Application)]
public interface EDBFGFMGCBM
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	int JFPFICFFMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	int PLDKFDMLOHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	bool DIHDOFMHJHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	bool CDCFIMPJKEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	bool HLPFDIBOAIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FHNHGOPNICC LCICKLPODNB(int KHELFHBHLMG);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.Application)]
public interface IEEJJOCNKOI
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool HMJLNLMDMEF
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ServiceLifetime(Lifetime.Application)]
public interface AKJLCMLCONF
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	JIMDDOODGGB HKAGCELIHLL
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	LNJLGFCNCEA DIFOMIBHGHP
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LJPFOKOFCAM(Transform EJNLPEDOMDD);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CEFLBGNNEFL(Transform EJNLPEDOMDD, MDOKODFBGBL EOJEIEKIBIN);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AGAEODNBBOM(Transform EJNLPEDOMDD, FFCHMNNCDPE BANIDBBGDNO);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
public interface BGJMHJBFBFB
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action JDGJFDEILNM;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.Application)]
public interface EKHLALHOMLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BPOLBPJMOBM();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ServiceLifetime(Lifetime.Application)]
public interface NHIIAKEPAKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFKNLOCOHNJ(GameObject HHDLNMHBJJD, MIICMHIJAKL HNHJCIIEIAM, HPHAOIABICP PDDJHBJGACA);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NKMFMDIGDKB(FHNHGOPNICC KPOCLGHHOEP, bool GMLIDHIADLF, float3 MGMADMOOOJF, quaternion KEKPFCBMCOO);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IANGBEIABAN(PCANLNGHNBK PHHLDPNPPCE);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NGMOFHINNHE(JHDEHBMJKKK ADMEOFCKKPF, JHDEHBMJKKK MOCLCNOAHKF, EKDALHPLPPO OPCPCOOFBPO);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MGLPHCDFAKF(JHDEHBMJKKK ADMEOFCKKPF, EKDALHPLPPO OPCPCOOFBPO);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MJHLGLHJHBP(PCANLNGHNBK APLBIBIENJC);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GameObject MLLKJFDGHDM(Guid GMGHCFFGAOM);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CPAKIEMCCNK(OJOCGBDBALB FKOFMENDCEB);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct ICPNOPPNPFC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NativeArray<byte> GIDGOODJFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly GCHandle ILIIBOPHLDK;

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7684960", Offset = "0x7682F60", VA = "0x187684960")]
	public ICPNOPPNPFC(ReadOnlyMemory<byte> EEFIHHOPAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7684920", Offset = "0x7682F20", VA = "0x187684920", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum NBHBBNHHMHH
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
public struct PLEGJMDHKHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public ByteString COGEHJFLBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public object OJMOOPLDBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object IMLHMGJEAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IEnumerable<string> GEINDCJEHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool APMDCKNLIGB;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7691BA0", Offset = "0x76901A0", VA = "0x187691BA0")]
	public PLEGJMDHKHI(ByteString COGEHJFLBOL, [Optional] object OJMOOPLDBAD, [Optional] object IMLHMGJEAKL, [Optional] IEnumerable<string> GEINDCJEHMF, bool APMDCKNLIGB = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct HICCPELJGMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public object OMKDFLCLBEL;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct LFCNJIPFIBC
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[Flags]
	public enum MLLFFJJNAGE
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		IsInvalid = 1,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		IsStudioPrefab = 2,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		IsBetaOnly = 4,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		IsDevOnly = 8,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		IsR1Only = 0x10,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		IsR1Upgrade = 0x20
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public RRObjectPrefabData NEKDLFACDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Guid IEJINLAAIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Guid NOILOGDOBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Guid PKAOKHPMPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid FKLDMFPHHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public MLLFFJJNAGE PNCPEFMKILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Color32 JKCDHFCOFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public int FBLPOOJAEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public ABEOGEOCEMB BCMPIAKEHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public int CGFOJOJODHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int KKIOINJGMEJ;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Guid EKLGMMJOOIB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x4B9EDA0", Offset = "0x4B9D3A0", VA = "0x184B9EDA0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool DPBOIMBGKJE
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7688AE0", Offset = "0x76870E0", VA = "0x187688AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool BADLAAELLAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7688AD0", Offset = "0x76870D0", VA = "0x187688AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public bool ONCGCEEMNCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7688AF0", Offset = "0x76870F0", VA = "0x187688AF0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct PNOAEDHFMGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal readonly GDPEFKGOMGI HHIGALLBHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal readonly GDPEFKGOMGI PDNKBEEOLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly uint GHGLELKHBLD;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7691CA0", Offset = "0x76902A0", VA = "0x187691CA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct PMIICLOKJJB
{
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal readonly PNOAEDHFMGG PJDAFKMDDCG;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x768D520", Offset = "0x768BB20", VA = "0x18768D520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public readonly struct NANFIHAHOEH
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal readonly PNOAEDHFMGG PJDAFKMDDCG;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x768D520", Offset = "0x768BB20", VA = "0x18768D520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct AJJFJCILHHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal readonly uint GHGLELKHBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal readonly bool IPEKMFILADG;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x767D540", Offset = "0x767BB40", VA = "0x18767D540", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct GDPEFKGOMGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	internal int FDJGEFDKBBO;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7681D00", Offset = "0x7680300", VA = "0x187681D00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[ServiceLifetime(Lifetime.Application)]
public interface HMCBAFEJGFG
{
	[Cpp2IlInjected.Token(Token = "0x17000083")]
	LGLHFNEAPJN FHEOOEJKOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface MANJAEAMIEB
{
	[Cpp2IlInjected.Token(Token = "0x17000084")]
	FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface JJBDFDDAJPF
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class NGOONJKHCJG
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x35B4E90", Offset = "0x35B3490", VA = "0x1835B4E90")]
	public static JHDEHBMJKKK BOJCMAKKIAM<T>(this T KPOCLGHHOEP) where T : MANJAEAMIEB
	{
		return default(JHDEHBMJKKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x768D770", Offset = "0x768BD70", VA = "0x18768D770")]
	public static MonoBehaviour IMNKOMFKLDI(this MANJAEAMIEB KPOCLGHHOEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x768D7F0", Offset = "0x768BDF0", VA = "0x18768D7F0")]
	public static GameObject PFCBGIFALLD(this MANJAEAMIEB KPOCLGHHOEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface NFKLPDMHGNG : MANJAEAMIEB
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(FHNHGOPNICC NMFKPCDLLEP);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface CHGKCHJHJHB : MANJAEAMIEB
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface HAFCLLKMOOM
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public delegate void JHHMEOJGAFP(BJGLMIHPBFI KAHBBPINLDA);

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event JHHMEOJGAFP IBNAIONLCDP;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface LPMMIBAJKKP
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface JAPKCJCIDCN
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface BAACBHFDECL
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(FHNHGOPNICC JFKGLDGAEPG);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool EECEENIIILH);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IFPJEFKHLBE(FHNHGOPNICC JOFIFDPGHKD);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface KJDFHLCNEEG
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(DOJENFHJKGB NGPJLBENOFE);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface DOJENFHJKGB
{
	[Cpp2IlInjected.Token(Token = "0x17000085")]
	GameObject HHDLNMHBJJD
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	Transform EJNLPEDOMDD
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	ALGKOANMNJA IFGANDELOJE
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	bool DNABDOIEBPB
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ILMBOGBDAOA(ALGKOANMNJA AAMBBOLAGCO);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OLOMKIEJIDK GetData();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class PLBLFFEJGLA
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7691810", Offset = "0x768FE10", VA = "0x187691810")]
	public static void DBCONKFOLJD(this DOJENFHJKGB AMDJMIBOJED, DBGGEFBGBDL BPPCEJGCMKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface ALGKOANMNJA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000089")]
	FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	Rigidbody EFGIGFEGANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	DOJENFHJKGB ABOOBHLFACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	GameObject PFCBGIFALLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	Transform KECLKMNFMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	ALGKOANMNJA IACMILFIJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	ALGKOANMNJA HAMMPINBCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	int KIIPMJCADCA
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	bool DDBFPNBFMBI
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	bool BFGJHJKGOIE
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	bool EGPMEMMIMPM
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	OPMGDNEPOAI APEKLIAHFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	HHKIIOIPKEL JFPFGLNJMAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	float POMMCKJPGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	Vector3 LIJIPPGHPIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	Vector3 LMCBCFBPCFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	Vector3 LMLKLDELBCM
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	Vector3 GMGNGJFELMM
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	bool BFIFIOEMIHG
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	bool KDNCHPOIPEK
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool HFNDMANAEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	bool EFAJKHNIDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	Vector3 CECEIGEKICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	Vector3 IJMJINEDEDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	Vector3 KOANBGPJFPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 AJFFEJMHNNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	float OMDIFBBGKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	float DENPBICKFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Vector3 BAJNCDKBLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	Quaternion OCCAONDPAKK
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	float DBCBEFOFKFM
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	float PFCBECDMHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	bool PNKJPKBKDJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	GPBDIJCMDDB IDGNDNBMKBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool OAHEBJFIIJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	Transform IEAFPNGLCKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	Vector3 LEEAOGLADAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	float JBJGLOCLKJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	float BBPBPOAPNGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	Quaternion PEKONLBNMJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	Vector3 KOHIGCEHKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	Quaternion NDNJPIJMLJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	RigidbodyConstraints LCLBBGJJKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	bool NFOMOHIOLOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	CollisionDetectionMode HAFEJEBADGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	bool MCIMPKMOLLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event PDAGHPCAEPO JMNJMHPELEN;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event PDAGHPCAEPO DCNDBKKAIHJ;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event PDAGHPCAEPO DCJADKAAFCA;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event PDAGHPCAEPO HIGJAJALGPE;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event PDAGHPCAEPO MEOEMMEMNAM;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event PDAGHPCAEPO IJCFEOLPONG;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event PDAGHPCAEPO LCGOPILANPJ;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event PEAKMKHCICL CHGIDFLHNNP;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<OINJBHOKJEJ, OINJBHOKJEJ> HDINLCLOKNE;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	ALGKOANMNJA FODDECJFNCE(int EAHKFAJBNDN);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void IGDPPDADKPC((Quaternion rot, Vector3 moments) BDGCMKHKJGI);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void AEGNBCCGJEM();

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void OMNCAKKNONI();

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void KEEBHJFCMPO();

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void AOOFEJBFDDA();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void JIIIELNBPIF();

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void PDMHANMAJFJ(ALGKOANMNJA KBGCCIOIGBD, bool GAMHFCBCJBI = false);

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void MMKPBALBOBB(object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void PAMIHHDAFMA(object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 BAFJFDPAAGM(Vector3 DBLIJGKPLMN);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 EKENBHPHKOJ(Vector3 HGIAGFCHLPB);

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void EDJHAMEFIIB();

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void EJOHHKODEHE();

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void NJADJDABIDO();

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void OOJJBIHGABB(Vector3 IOGHHNAIODM, Vector3 GKDEKLKFMAA);

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void OCNELKPIIEL(Vector3 AFAALGOINNG, Vector3 PMBLIKDJDDC);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void GEGDBMJAFCD(Vector3 MJMCMBGBGHN);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void LBJEHICKFOF(FFOJPNNBINM CIJGAJPJOGK, Vector3 FMNAADBCOPL, float EFHIEALGFPF, float NEKEGLHIFON = 8f, float IIPFNMPOOEO = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void GHMFILLJBFH(PKKKNPNJAHH GAIPBHPLCOO, Vector3 FHCLGDCLCNG, float MMNFGNNBPMC = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void PFFMPEONJID(PKKKNPNJAHH GAIPBHPLCOO, Vector3 MLMNPOCKAAE, float BLKFPBEEMHA = 7f, float CIDODHEEICJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 PHAGPDAFEDM(Vector3 KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 PGECOLEOIDJ(Vector3 KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void PEPAHFAOHLH();

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void LKGIAHIOKLN(ALGKOANMNJA ANNFJIHMGGG, object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void ENLMECHGGAL(object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void CFHAHFFIBGO();

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void KOIKIBIHFIN();

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void HPCMKGLGOFK();

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool GMIKMKKIIKN();

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void OHACHHIJHKA();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void LFNOFHOCLDI(object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void EEFJJODOBMP(object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void FPBIFIJGBOB(object LAAJFAFNFCN, bool OCMDPMDMEEP);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void LHBJMNBGGEB(Vector3 NMOENKJNINF, Quaternion GJHDMIEGGGE);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void PDJDLOAJIPC(Vector3 EKNIMOGELNJ, Quaternion MPPGEACKGGL);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool MOKCDOPFMIO(float AJFLFDACHCD);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void HHMPELEDFFM(object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void CKHCOJLGKJB(object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void HLDEHJLFKFN(object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void EBAOIBANCHE(object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void EJNPIADIJKL(Vector3 MHOOEDPKADD, ForceMode CFFKAOJCDML = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void OFPILGCEHPI(Vector3 MHOOEDPKADD, Vector3 NDADPNJPMFO, ForceMode CFFKAOJCDML);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void IBHONFEMPKJ(Vector3 KGNOGLDDKGP, ForceMode CFFKAOJCDML = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void BCBPOCEDEKA(Vector3 KGNOGLDDKGP, ForceMode CFFKAOJCDML = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool ENBOKHHPFMD(Vector3 BNCGOADGBEC, [Out] RaycastHit OLEHNOEJHML, float HIAAOMCAGFP);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void FPFPICGMACE();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface HHKIIOIPKEL
{
	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDJGPOPAFME(Vector3 GCCCJELNJHP);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IDAHIFFDILO(Vector3 GNFIJOGHJJB);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CMMGOGGMPCM(Vector3 GCCCJELNJHP);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EJOABAJIBIC(Vector3 GNFIJOGHJJB);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface OPMGDNEPOAI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 LIDPKMGBHFK();

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 HMPAHDJCAJF();

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LOAHDELBHEB(float OAJECFFFKCD, float OPIKHPHPKLF);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public delegate void PDAGHPCAEPO(DOJENFHJKGB FMDIHHHHKAN);
[Cpp2IlInjected.Token(Token = "0x2000055")]
public enum CJICDLIFCDO
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	ChildAdded,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	ChildRemoved,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	ParentChanged,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	HierarchyMassUpdated,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	SleepChanged,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	DistanceBandChanged,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	IsKinematicChanged,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Discontinuity,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Destroyed,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public enum FFOJPNNBINM
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Reflective,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	FullOverride
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public delegate void PEAKMKHCICL(DOJENFHJKGB FMDIHHHHKAN, bool GAMHFCBCJBI = false);
[Cpp2IlInjected.Token(Token = "0x2000058")]
public enum PKKKNPNJAHH
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct OLOMKIEJIDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Rigidbody JAPHJPDIABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public object MAHGMLPJMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector3 OHLHGJJLLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Vector3 AIPKHFOBLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public FALLENFFJHK BHLDBBEMKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public bool DFOJAHLIKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public bool PLLBHIDIGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool KBPGGDGMJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool IHHJJFNGMLO;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct JHDEHBMJKKK : IEquatable<JHDEHBMJKKK>
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly JHDEHBMJKKK OPDBFMPDHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public GameObject HHDLNMHBJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7685EB0", Offset = "0x76844B0", VA = "0x187685EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public GFBOHEINDFO MKJAIBBHPJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x76856D0", Offset = "0x7683CD0", VA = "0x1876856D0")]
		get
		{
			return default(GFBOHEINDFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public CBKOFJIKNOE OEHPIEKNIPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x7685C60", Offset = "0x7684260", VA = "0x187685C60")]
		get
		{
			return default(CBKOFJIKNOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public RRObjectPrefabData FBMPBPGLMGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7685860", Offset = "0x7683E60", VA = "0x187685860")]
		get
		{
			return default(RRObjectPrefabData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool ELADFOGMAPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x7685D00", Offset = "0x7684300", VA = "0x187685D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool EOBNMOKBJAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7686060", Offset = "0x7684660", VA = "0x187686060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool KOKJJEEFCGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7686040", Offset = "0x7684640", VA = "0x187686040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool KOBNGOJEKOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7686120", Offset = "0x7684720", VA = "0x187686120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool JPKJIGNEIII
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7685770", Offset = "0x7683D70", VA = "0x187685770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool ANCCIMMGHAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7686140", Offset = "0x7684740", VA = "0x187686140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool NCOFIAKKDHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x76857E0", Offset = "0x7683DE0", VA = "0x1876857E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool BLKIBEOCHCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7685BD0", Offset = "0x76841D0", VA = "0x187685BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool GHMFNJBEJGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7686270", Offset = "0x7684870", VA = "0x187686270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool LFLFIFEDNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x76862F0", Offset = "0x76848F0", VA = "0x1876862F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public KJKECLAGEIA LAFGEFFDDAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(KJKECLAGEIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public BGKBCIBLGFD EHGAOJJJPBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(BGKBCIBLGFD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public LBCKJGMDKPE KJLMIKMOEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(LBCKJGMDKPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public BFINECMEGHO ENNJFINEENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(BFINECMEGHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public EDPAEDFCDBF NIEHLCAJGMO
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(EDPAEDFCDBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public HHIAADIGMAN FNOCIAIGBHB
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(HHIAADIGMAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public GJBCDEOFCBM KODMHDEDBGD
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(GJBCDEOFCBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public NLINPOPBMMJ KIMEJONAOIP
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(NLINPOPBMMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public FDMHONCAMGP CNMJBHIOOOO
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(FDMHONCAMGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public GGIFBJBCJEI MOPNFKEBMFI
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(GGIFBJBCJEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public LLFLNDONOCH ICBKHMBFCDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(LLFLNDONOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public BIHLNGOIOPN LIIFMOPHCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(BIHLNGOIOPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public POICIGGKDHL BJPGCCDCJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(POICIGGKDHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool LPBCLBCDAGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7685D20", Offset = "0x7684320", VA = "0x187685D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool NBCLMBCAOJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x76862B0", Offset = "0x76848B0", VA = "0x1876862B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool NBEIHBJPAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7685A90", Offset = "0x7684090", VA = "0x187685A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool KIHHPHKKEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7685B90", Offset = "0x7684190", VA = "0x187685B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool GHHDIFGLEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x7685820", Offset = "0x7683E20", VA = "0x187685820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool BCBLBPEJHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x76857A0", Offset = "0x7683DA0", VA = "0x1876857A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public MCOOOFNMHCJ KECLKMNFMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(MCOOOFNMHCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public NMLAECPNCHG FLDIKFAONCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(NMLAECPNCHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private ANDACNBFJKF EGGGEPPGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x767F520", Offset = "0x767DB20", VA = "0x18767F520")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
	public static JHDEHBMJKKK HEGJABMHLEC(FHNHGOPNICC NMFKPCDLLEP)
	{
		return default(JHDEHBMJKKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x76859C0", Offset = "0x7683FC0", VA = "0x1876859C0")]
	public NIJDLJAFJCA DBCKPHLKEIE()
	{
		return default(NIJDLJAFJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7685AD0", Offset = "0x76840D0", VA = "0x187685AD0")]
	public MEMNNEFBJEI ENBBGHJCGBC()
	{
		return default(MEMNNEFBJEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7685C10", Offset = "0x7684210", VA = "0x187685C10")]
	public LJGDHGEBGHI GEDDNBHANCO()
	{
		return default(LJGDHGEBGHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7685990", Offset = "0x7683F90", VA = "0x187685990")]
	public LABFLFKOHDN CNMBKPLOPFC()
	{
		return default(LABFLFKOHDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7685A40", Offset = "0x7684040", VA = "0x187685A40")]
	public JMCJMJDDLHN EAJGAPKEOKM()
	{
		return default(JMCJMJDDLHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x7686170", Offset = "0x7684770", VA = "0x187686170")]
	public void NJINGLNDKBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7686080", Offset = "0x7684680", VA = "0x187686080")]
	public void MHAKNCNBNPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7685E10", Offset = "0x7684410", VA = "0x187685E10")]
	public bool LDNKPNCBHMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7686330", Offset = "0x7684930", VA = "0x187686330", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public JHDEHBMJKKK(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x76827F0", Offset = "0x7680DF0", VA = "0x1876827F0")]
	public static bool HEGJABMHLEC(JHDEHBMJKKK KBGCCIOIGBD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
	public static FHNHGOPNICC HEGJABMHLEC(JHDEHBMJKKK KBGCCIOIGBD)
	{
		return default(FHNHGOPNICC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7685790", Offset = "0x7683D90", VA = "0x187685790")]
	public static bool BFIJCNNIIMH(JHDEHBMJKKK AMGCKABOOPF, JHDEHBMJKKK PPCFCAEIJMM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7681540", Offset = "0x767FB40", VA = "0x187681540")]
	public static bool HKDAGECLGLD(JHDEHBMJKKK AMGCKABOOPF, JHDEHBMJKKK PPCFCAEIJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7685B00", Offset = "0x7684100", VA = "0x187685B00", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(JHDEHBMJKKK OKCHLIEAIJP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct KJKECLAGEIA : IEquatable<KJKECLAGEIA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidTransform PMDHLEBGBPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7687860", Offset = "0x7685E60", VA = "0x187687860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public float JBJGLOCLKJM
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7687810", Offset = "0x7685E10", VA = "0x187687810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public MCOOOFNMHCJ KECLKMNFMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(MCOOOFNMHCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x7687620", Offset = "0x7685C20", VA = "0x187687620")]
	public void GNCDDFEGIPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public KJKECLAGEIA(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7687590", Offset = "0x7685B90", VA = "0x187687590", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(KJKECLAGEIA OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct BGKBCIBLGFD : IEquatable<BGKBCIBLGFD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private PGCIHGMCKEE DFAIELHICGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x767F130", Offset = "0x767D730", VA = "0x18767F130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool JAPHPIHOFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x767F2F0", Offset = "0x767D8F0", VA = "0x18767F2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool BEPPJLIKGEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x767ED90", Offset = "0x767D390", VA = "0x18767ED90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public bool DBBPFLJFNBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x767F190", Offset = "0x767D790", VA = "0x18767F190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public Guid KCLMIPMJJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x767EE60", Offset = "0x767D460", VA = "0x18767EE60")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public Guid HLCGAADKCLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x767F380", Offset = "0x767D980", VA = "0x18767F380")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public Guid JPBBGBOJFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x767EB00", Offset = "0x767D100", VA = "0x18767EB00")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public NMLAECPNCHG FLDIKFAONCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(NMLAECPNCHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	private ANDACNBFJKF EGGGEPPGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x767F520", Offset = "0x767DB20", VA = "0x18767F520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private KOJAMECNJEF NLDGJODPDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x767EDD0", Offset = "0x767D3D0", VA = "0x18767EDD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x767F250", Offset = "0x767D850", VA = "0x18767F250")]
	public bool GAKMBAIHEOM([Out] Guid JLMDJNDONMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x767F000", Offset = "0x767D600", VA = "0x18767F000")]
	public bool EHAMNOLNJPB([Out] Guid MEGMENINLOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x767EEE0", Offset = "0x767D4E0", VA = "0x18767EEE0")]
	public void DKINNIEHGID(Guid DGOEGFOLJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x767EA70", Offset = "0x767D070", VA = "0x18767EA70")]
	public void ACPLMICIHDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x767F400", Offset = "0x767DA00", VA = "0x18767F400")]
	public Guid NNJMDLOJAKF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public BGKBCIBLGFD(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x767F0A0", Offset = "0x767D6A0", VA = "0x18767F0A0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(BGKBCIBLGFD OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct LJGDHGEBGHI : IEquatable<LJGDHGEBGHI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private GIFNIBDCFIP AIDHHPENAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x76892E0", Offset = "0x76878E0", VA = "0x1876892E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 JHEAEENCGHD
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x7688E70", Offset = "0x7687470", VA = "0x187688E70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Quaternion EHKELIGGIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x7688D30", Offset = "0x7687330", VA = "0x187688D30")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public JHDEHBMJKKK DFKLAGADFDK
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x7689090", Offset = "0x7687690", VA = "0x187689090")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private ANDACNBFJKF EGGGEPPGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x767F520", Offset = "0x767DB20", VA = "0x18767F520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private KOJAMECNJEF NLDGJODPDLC
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7688B00", Offset = "0x7687100", VA = "0x187688B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7688FC0", Offset = "0x76875C0", VA = "0x187688FC0")]
	public PCANLNGHNBK JDGDFMEFOJI(Allocator LEILKJFLDFN)
	{
		return default(PCANLNGHNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7689490", Offset = "0x7687A90", VA = "0x187689490")]
	public bool PEFOMJKNMKD(JHDEHBMJKKK LDIAONMHHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7689340", Offset = "0x7687940", VA = "0x187689340")]
	public void OADOKCCCHGO(Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7688C20", Offset = "0x7687220", VA = "0x187688C20")]
	public void FFBIFGIFHAL(float JJCKONKIIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7689120", Offset = "0x7687720", VA = "0x187689120")]
	public void MAMHELBNHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public LJGDHGEBGHI(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x76827F0", Offset = "0x7680DF0", VA = "0x1876827F0")]
	public static bool HEGJABMHLEC(LJGDHGEBGHI KBGCCIOIGBD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
	public static FHNHGOPNICC HEGJABMHLEC(LJGDHGEBGHI KBGCCIOIGBD)
	{
		return default(FHNHGOPNICC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7688B90", Offset = "0x7687190", VA = "0x187688B90", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(LJGDHGEBGHI OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public readonly struct NIJDLJAFJCA : IEquatable<NIJDLJAFJCA>
{
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly NIJDLJAFJCA OPDBFMPDHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private IMLCHGCIBDL JPGBBNPBMFL
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x768D900", Offset = "0x768BF00", VA = "0x18768D900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
	public Span<JHDEHBMJKKK> OAHIIDOOIJE
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x768DF30", Offset = "0x768C530", VA = "0x18768DF30")]
		get
		{
			return default(Span<JHDEHBMJKKK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public string OPDMIMOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x768DE30", Offset = "0x768C430", VA = "0x18768DE30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x768DEB0", Offset = "0x768C4B0", VA = "0x18768DEB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public MCOOOFNMHCJ KECLKMNFMIH
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(MCOOOFNMHCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public NMLAECPNCHG FLDIKFAONCC
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(NMLAECPNCHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	private ANDACNBFJKF EGGGEPPGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x767F520", Offset = "0x767DB20", VA = "0x18767F520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	private KOJAMECNJEF NLDGJODPDLC
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x768D960", Offset = "0x768BF60", VA = "0x18768D960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x768D9F0", Offset = "0x768BFF0", VA = "0x18768D9F0")]
	public void DNPLHHKOKEI(NIJDLJAFJCA OKCHLIEAIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public NIJDLJAFJCA(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x76827F0", Offset = "0x7680DF0", VA = "0x1876827F0")]
	public static bool HEGJABMHLEC(NIJDLJAFJCA KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x768DDA0", Offset = "0x768C3A0", VA = "0x18768DDA0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(NIJDLJAFJCA OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
	public static JHDEHBMJKKK HEGJABMHLEC(NIJDLJAFJCA JDCFMPOHCEA)
	{
		return default(JHDEHBMJKKK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[DefaultMember("Item")]
public struct FNJFJFBHCFA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private Dictionary<int, object> JAGFBALGAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private DLFJAADKMKH MJBPIAENHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool PALJJFCJPCE;

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		[CompilerGenerated]
		readonly get
		{
			return default(JHDEHBMJKKK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public IGNCGNKDNME NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7681970", Offset = "0x767FF70", VA = "0x187681970")]
		readonly set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x7681B50", Offset = "0x7680150", VA = "0x187681B50")]
	internal FNJFJFBHCFA(JHDEHBMJKKK GMFKPONAANG, bool PALJJFCJPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x7681840", Offset = "0x767FE40", VA = "0x187681840", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x33C3180", Offset = "0x33C1780", VA = "0x1833C3180")]
	public void OKCBENGKJJG<T>(IGNCGNKDNME LKMGECEEGEE, T KBGCCIOIGBD, [Optional] T IDJBNLNBJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x7681AA0", Offset = "0x76800A0", VA = "0x187681AA0")]
	public void OCDDHDAHAOD(IGNCGNKDNME LKMGECEEGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0xC3A160", Offset = "0xC38760", VA = "0x180C3A160")]
	public Dictionary<int, object> KAAACLLHBNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x7681A30", Offset = "0x7680030", VA = "0x187681A30")]
	private readonly void EIONMEKDBJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class HKPFLEPAGDP
{
	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x7684600", Offset = "0x7682C00", VA = "0x187684600")]
	public static FNJFJFBHCFA GCEFOFBIMLN(this JHDEHBMJKKK GMFKPONAANG)
	{
		return default(FNJFJFBHCFA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct POICIGGKDHL : IEquatable<POICIGGKDHL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public bool IGBNLHEHOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7691F80", Offset = "0x7690580", VA = "0x187691F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Vector3 NBAMIOOMJDE
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7692050", Offset = "0x7690650", VA = "0x187692050")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7692150", Offset = "0x7690750", VA = "0x187692150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x7692050", Offset = "0x7690650", VA = "0x187692050")]
	public Vector3 GPEIAAHFMLP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x76920D0", Offset = "0x76906D0", VA = "0x1876920D0")]
	public void IADHEHADJAG([In] Vector3 KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x7691F10", Offset = "0x7690510", VA = "0x187691F10")]
	public bool BAEFPGPMAKG([In] Vector3 KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public POICIGGKDHL(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x7691FC0", Offset = "0x76905C0", VA = "0x187691FC0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(POICIGGKDHL OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct NMLAECPNCHG : IEquatable<NMLAECPNCHG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private IMLCHGCIBDL JPGBBNPBMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x768E270", Offset = "0x768C870", VA = "0x18768E270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public FHNHGOPNICC MIHHHGCJBBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x768EA50", Offset = "0x768D050", VA = "0x18768EA50")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public JHDEHBMJKKK IACMILFIJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x768E480", Offset = "0x768CA80", VA = "0x18768E480")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public JHDEHBMJKKK HAMMPINBCBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x768E2D0", Offset = "0x768C8D0", VA = "0x18768E2D0")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	private ANDACNBFJKF EGGGEPPGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x767F520", Offset = "0x767DB20", VA = "0x18767F520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	private KOJAMECNJEF NLDGJODPDLC
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x768E3F0", Offset = "0x768C9F0", VA = "0x18768E3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x768E510", Offset = "0x768CB10", VA = "0x18768E510")]
	public Span<JHDEHBMJKKK> DFNOKBDLICK()
	{
		return default(Span<JHDEHBMJKKK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x768E610", Offset = "0x768CC10", VA = "0x18768E610")]
	public Span<JHDEHBMJKKK> DKBMGDAGAIE()
	{
		return default(Span<JHDEHBMJKKK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x768EAE0", Offset = "0x768D0E0", VA = "0x18768EAE0")]
	public Span<JHDEHBMJKKK> MGFFPDGOJED()
	{
		return default(Span<JHDEHBMJKKK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x768ED10", Offset = "0x768D310", VA = "0x18768ED10")]
	public Span<JHDEHBMJKKK> PMICALBNGNI()
	{
		return default(Span<JHDEHBMJKKK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x768E8B0", Offset = "0x768CEB0", VA = "0x18768E8B0")]
	public Span<JHDEHBMJKKK> JNPNJPMJKCI()
	{
		return default(Span<JHDEHBMJKKK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x768EBE0", Offset = "0x768D1E0", VA = "0x18768EBE0")]
	public bool PDMHANMAJFJ(JHDEHBMJKKK LDIAONMHHPK, bool LMFFCHAIHLC = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x768E9B0", Offset = "0x768CFB0", VA = "0x18768E9B0")]
	public bool JPEBAKPLOOH(JHDEHBMJKKK LGNIHKABDBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x768E7A0", Offset = "0x768CDA0", VA = "0x18768E7A0")]
	public JHDEHBMJKKK FBFBHFCEDDO(uint HAKLJPKGBKK)
	{
		return default(JHDEHBMJKKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x768E360", Offset = "0x768C960", VA = "0x18768E360")]
	public NIJDLJAFJCA CIINLGKEFFA()
	{
		return default(NIJDLJAFJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public NMLAECPNCHG(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x76827F0", Offset = "0x7680DF0", VA = "0x1876827F0")]
	public static bool HEGJABMHLEC(NMLAECPNCHG KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x768E710", Offset = "0x768CD10", VA = "0x18768E710", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(NMLAECPNCHG OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct LBCKJGMDKPE : IEquatable<LBCKJGMDKPE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public string DDMJIJIMJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7688090", Offset = "0x7686690", VA = "0x187688090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public string DHGNEPBKPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7687D10", Offset = "0x7686310", VA = "0x187687D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	private bool IJGLNLCEJBH
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7687EF0", Offset = "0x76864F0", VA = "0x187687EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public string JNIIEHDCDBM
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7687E40", Offset = "0x7686440", VA = "0x187687E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public string FDPPNGFHJPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7687AC0", Offset = "0x76860C0", VA = "0x187687AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public string MKFKAAADPMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x76879A0", Offset = "0x7685FA0", VA = "0x1876879A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public LBCKJGMDKPE(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7687A30", Offset = "0x7686030", VA = "0x187687A30", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(LBCKJGMDKPE OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct JMCJMJDDLHN : IEquatable<JMCJMJDDLHN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private PFMKCGLAJFE KFLIBLIKNIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7686BD0", Offset = "0x76851D0", VA = "0x187686BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public ADAPBJDILJP ACMDMKMKDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x76866E0", Offset = "0x7684CE0", VA = "0x1876866E0")]
		get
		{
			return default(ADAPBJDILJP);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7686900", Offset = "0x7684F00", VA = "0x187686900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool PAJHFIEHLBA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7687150", Offset = "0x7685750", VA = "0x187687150")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x76870B0", Offset = "0x76856B0", VA = "0x1876870B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public JLFIEIINFCM<string> HDFLJHOFHFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7686D50", Offset = "0x7685350", VA = "0x187686D50")]
		get
		{
			return default(JLFIEIINFCM<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7686C30", Offset = "0x7685230", VA = "0x187686C30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public JLFIEIINFCM<string> GKOOIPGPFIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x76864A0", Offset = "0x7684AA0", VA = "0x1876864A0")]
		get
		{
			return default(JLFIEIINFCM<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x76871E0", Offset = "0x76857E0", VA = "0x1876871E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public JLFIEIINFCM<string> KJCJGJFLGEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x76865C0", Offset = "0x7684BC0", VA = "0x1876865C0")]
		get
		{
			return default(JLFIEIINFCM<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x76867E0", Offset = "0x7684DE0", VA = "0x1876867E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public JLFIEIINFCM<string> CJNDOEJKLGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7686E70", Offset = "0x7685470", VA = "0x187686E70")]
		get
		{
			return default(JLFIEIINFCM<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7686F90", Offset = "0x7685590", VA = "0x187686F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private ANDACNBFJKF EGGGEPPGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x767F520", Offset = "0x767DB20", VA = "0x18767F520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	private KOJAMECNJEF NLDGJODPDLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7686A10", Offset = "0x7685010", VA = "0x187686A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7686B30", Offset = "0x7685130", VA = "0x187686B30")]
	public bool FHHLCCDKBEE(FHNHGOPNICC OEIBHCOIKMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public JMCJMJDDLHN(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
	public static FHNHGOPNICC HEGJABMHLEC(JMCJMJDDLHN KBGCCIOIGBD)
	{
		return default(FHNHGOPNICC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7686AA0", Offset = "0x76850A0", VA = "0x187686AA0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(JMCJMJDDLHN OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct IFGMMBEKFAL : IEquatable<IFGMMBEKFAL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7684A10", Offset = "0x7683010", VA = "0x187684A10", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(IFGMMBEKFAL OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct BFINECMEGHO : IEquatable<BFINECMEGHO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Collider LADMPJKFHLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x767E440", Offset = "0x767CA40", VA = "0x18767E440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public LAKFMIPGDFM NEHKEDNCDFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x767E860", Offset = "0x767CE60", VA = "0x18767E860")]
		get
		{
			return default(LAKFMIPGDFM);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x767E090", Offset = "0x767C690", VA = "0x18767E090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public BBKFGBALMBJ OGHJFJBBABJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x767E290", Offset = "0x767C890", VA = "0x18767E290")]
		get
		{
			return default(BBKFGBALMBJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x767E2D0", Offset = "0x767C8D0", VA = "0x18767E2D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public AEONEPFEMAI KEHGCDLEIEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x767E820", Offset = "0x767CE20", VA = "0x18767E820")]
		get
		{
			return default(AEONEPFEMAI);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x767E1D0", Offset = "0x767C7D0", VA = "0x18767E1D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public float PHJPPJPIIED
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x767E590", Offset = "0x767CB90", VA = "0x18767E590")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x767E3C0", Offset = "0x767C9C0", VA = "0x18767E3C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool OODGLHIFJMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x767E8F0", Offset = "0x767CEF0", VA = "0x18767E8F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x767E020", Offset = "0x767C620", VA = "0x18767E020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public bool IDLONMFFIDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x767E8A0", Offset = "0x767CEA0", VA = "0x18767E8A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x767E220", Offset = "0x767C820", VA = "0x18767E220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x767E5D0", Offset = "0x767CBD0", VA = "0x18767E5D0")]
	public bool LGNGBJCJBFK([Out] BAACBHFDECL FAEGMNIAGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x767E0E0", Offset = "0x767C6E0", VA = "0x18767E0E0")]
	public bool CBGECJFBHLJ([Out] FHNHGOPNICC JGHOOBNHEJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x767E7C0", Offset = "0x767CDC0", VA = "0x18767E7C0")]
	public bool MGOADPONAJG(KMKOJLIANAG JFJMJEFHFHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x767E740", Offset = "0x767CD40", VA = "0x18767E740")]
	public void LPFBMMADNBG(KMKOJLIANAG JFJMJEFHFHO, bool BDDPPMGPFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public BFINECMEGHO(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x767E320", Offset = "0x767C920", VA = "0x18767E320", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(BFINECMEGHO OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct LABFLFKOHDN : IEquatable<LABFLFKOHDN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public bool ALDCKLPJEMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x7687950", Offset = "0x7685F50", VA = "0x187687950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public LABFLFKOHDN(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x76878C0", Offset = "0x7685EC0", VA = "0x1876878C0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(LABFLFKOHDN OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct EDPAEDFCDBF : IEquatable<EDPAEDFCDBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	private CFLNNNFPHBA JCKNPCLMBCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7680850", Offset = "0x767EE50", VA = "0x187680850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	private ANDACNBFJKF EGGGEPPGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x767F520", Offset = "0x767DB20", VA = "0x18767F520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private KOJAMECNJEF NLDGJODPDLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7680690", Offset = "0x767EC90", VA = "0x187680690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7680720", Offset = "0x767ED20", VA = "0x187680720")]
	public void DAADMOGKJFL(bool BOJJJKNPNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public EDPAEDFCDBF(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x76807C0", Offset = "0x767EDC0", VA = "0x1876807C0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(EDPAEDFCDBF OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct HHIAADIGMAN : IEquatable<HHIAADIGMAN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public bool CHCFPJMGAPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7684090", Offset = "0x7682690", VA = "0x187684090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public bool AHKJLDFCLCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7683F40", Offset = "0x7682540", VA = "0x187683F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool BIILGFPNAJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7684230", Offset = "0x7682830", VA = "0x187684230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public bool GBJBEKMHMEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7683D20", Offset = "0x7682320", VA = "0x187683D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool NDELIODPMFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7683F90", Offset = "0x7682590", VA = "0x187683F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool OACCOJCKNHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7684380", Offset = "0x7682980", VA = "0x187684380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool LDAMKENILBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7683E40", Offset = "0x7682440", VA = "0x187683E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool LDCFELIIAGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7683CD0", Offset = "0x76822D0", VA = "0x187683CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool JEEJBCAGBEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x76843D0", Offset = "0x76829D0", VA = "0x1876843D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool HMNAONEOJIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x76841E0", Offset = "0x76827E0", VA = "0x1876841E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool BOCAIABDKAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x7683EF0", Offset = "0x76824F0", VA = "0x187683EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool OLBCLHIKFDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x7683BB0", Offset = "0x76821B0", VA = "0x187683BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool EPJNOKGFDHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x76840D0", Offset = "0x76826D0", VA = "0x1876840D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool HCKEMBJGEMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7683C00", Offset = "0x7682200", VA = "0x187683C00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x7683E90", Offset = "0x7682490", VA = "0x187683E90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public PGBKBOPFMNI IGJNOMICANO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x7684120", Offset = "0x7682720", VA = "0x187684120")]
		get
		{
			return default(PGBKBOPFMNI);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x7683990", Offset = "0x7681F90", VA = "0x187683990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public bool MIMFGJFNBFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x76839E0", Offset = "0x7681FE0", VA = "0x1876839E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public HPHAOIABICP NAMCPPDBMCL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x7684420", Offset = "0x7682A20", VA = "0x187684420")]
		get
		{
			return default(HPHAOIABICP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x7684460", Offset = "0x7682A60", VA = "0x187684460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public bool HGBHNHNMJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x7683B70", Offset = "0x7682170", VA = "0x187683B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Vector3 JJKDGPBDKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x7684580", Offset = "0x7682B80", VA = "0x187684580")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Vector3 GFOMGEBNALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x7684500", Offset = "0x7682B00", VA = "0x187684500")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public bool BFAFLGJFLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x7684280", Offset = "0x7682880", VA = "0x187684280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private ANDACNBFJKF EGGGEPPGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x767F520", Offset = "0x767DB20", VA = "0x18767F520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private KOJAMECNJEF NLDGJODPDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x7683C40", Offset = "0x7682240", VA = "0x187683C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7683FE0", Offset = "0x76825E0", VA = "0x187683FE0")]
	public bool GANCAHFLCBJ(GNIEIAEKOMM JFJMJEFHFHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x76844B0", Offset = "0x7682AB0", VA = "0x1876844B0")]
	public bool OKAGDOAABEC(MIICMHIJAKL JFJMJEFHFHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7684160", Offset = "0x7682760", VA = "0x187684160")]
	public void LADJAMNEGED(MIICMHIJAKL JFJMJEFHFHO, bool BDDPPMGPFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7683E00", Offset = "0x7682400", VA = "0x187683E00")]
	public MIICMHIJAKL FCPMJEDGCED()
	{
		return default(MIICMHIJAKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7684040", Offset = "0x7682640", VA = "0x187684040")]
	public bool GCJOKFGIKIP(MIICMHIJAKL KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public HHIAADIGMAN(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7683D70", Offset = "0x7682370", VA = "0x187683D70", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(HHIAADIGMAN OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct GJBCDEOFCBM : IEquatable<GJBCDEOFCBM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	private BPLJCDNMHGN GFHDNGFPMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x76830A0", Offset = "0x76816A0", VA = "0x1876830A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	private ANDACNBFJKF EGGGEPPGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x767F520", Offset = "0x767DB20", VA = "0x18767F520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	private KOJAMECNJEF NLDGJODPDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x7682D40", Offset = "0x7681340", VA = "0x187682D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x7683230", Offset = "0x7681830", VA = "0x187683230")]
	public bool JKDPPGLECMM(EKDALHPLPPO OPCPCOOFBPO, List<JHDEHBMJKKK> JCAJHFICHIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7682B80", Offset = "0x7681180", VA = "0x187682B80")]
	public int AMBEHCLCEEG(EKDALHPLPPO OPCPCOOFBPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x7683650", Offset = "0x7681C50", VA = "0x187683650")]
	public void NDGNPPKJEPO(List<JHDEHBMJKKK> JCAJHFICHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x7682F70", Offset = "0x7681570", VA = "0x187682F70")]
	public int FBHOADIJODJ(JHDEHBMJKKK MOCLCNOAHKF, EKDALHPLPPO OPCPCOOFBPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x7683100", Offset = "0x7681700", VA = "0x187683100")]
	public JHDEHBMJKKK IICGKFDIMDE(int EAHKFAJBNDN, EKDALHPLPPO OPCPCOOFBPO)
	{
		return default(JHDEHBMJKKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x7683520", Offset = "0x7681B20", VA = "0x187683520")]
	public void MFKCKPFFGGA(JHDEHBMJKKK MOCLCNOAHKF, EKDALHPLPPO OPCPCOOFBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x7683360", Offset = "0x7681960", VA = "0x187683360")]
	public bool LKLKJIJBINM(JHDEHBMJKKK MOCLCNOAHKF, EKDALHPLPPO OPCPCOOFBPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x7682DD0", Offset = "0x76813D0", VA = "0x187682DD0")]
	public void DBPCDLKGOMJ(EKDALHPLPPO OPCPCOOFBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x7682C90", Offset = "0x7681290", VA = "0x187682C90")]
	public bool APBPODKILAH(JHDEHBMJKKK MOCLCNOAHKF, EKDALHPLPPO OPCPCOOFBPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x7683410", Offset = "0x7681A10", VA = "0x187683410")]
	public bool LOPAOCGDDJO(EKDALHPLPPO OPCPCOOFBPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public GJBCDEOFCBM(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x7682EE0", Offset = "0x76814E0", VA = "0x187682EE0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(GJBCDEOFCBM OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct NLINPOPBMMJ : IEquatable<NLINPOPBMMJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private ANDACNBFJKF EGGGEPPGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x767F520", Offset = "0x767DB20", VA = "0x18767F520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private KOJAMECNJEF NLDGJODPDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x768E030", Offset = "0x768C630", VA = "0x18768E030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x768E1E0", Offset = "0x768C7E0", VA = "0x18768E1E0")]
	public void NKICFGFBLHG(bool KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x768E150", Offset = "0x768C750", VA = "0x18768E150")]
	public void HBBOHLPIFHC(bool KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x35B9290", Offset = "0x35B7890", VA = "0x1835B9290")]
	public T NBLNDPOLGFI<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public NLINPOPBMMJ(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x768E0C0", Offset = "0x768C6C0", VA = "0x18768E0C0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(NLINPOPBMMJ OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public readonly struct FDMHONCAMGP : IEquatable<FDMHONCAMGP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool IFEDLCGAPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x7680E80", Offset = "0x767F480", VA = "0x187680E80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x7680D60", Offset = "0x767F360", VA = "0x187680D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public int NGJIHIDCENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x7680E40", Offset = "0x767F440", VA = "0x187680E40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x7680EC0", Offset = "0x767F4C0", VA = "0x187680EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private ANDACNBFJKF EGGGEPPGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x767F520", Offset = "0x767DB20", VA = "0x18767F520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private KOJAMECNJEF NLDGJODPDLC
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x7680CD0", Offset = "0x767F2D0", VA = "0x187680CD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public FDMHONCAMGP(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7680DB0", Offset = "0x767F3B0", VA = "0x187680DB0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(FDMHONCAMGP OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public readonly struct NFEDGOKLOID : IEquatable<NFEDGOKLOID>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public int GMEAGIAIMNE
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x768D650", Offset = "0x768BC50", VA = "0x18768D650")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x768D6D0", Offset = "0x768BCD0", VA = "0x18768D6D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public int POMJMFFBCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x768D690", Offset = "0x768BC90", VA = "0x18768D690")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x768D720", Offset = "0x768BD20", VA = "0x18768D720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public NFEDGOKLOID(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x768D5C0", Offset = "0x768BBC0", VA = "0x18768D5C0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(NFEDGOKLOID OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public readonly struct GGIFBJBCJEI : IEquatable<GGIFBJBCJEI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	private IALGJCOKLIO JNLGMKLLMBM
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x7682A60", Offset = "0x7681060", VA = "0x187682A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	private FNHIKEJNFOA BHFBNHPNGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7682170", Offset = "0x7680770", VA = "0x187682170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public bool HPBMOAHLDAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x7682AF0", Offset = "0x76810F0", VA = "0x187682AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool HFNCGGMGIJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x76826B0", Offset = "0x7680CB0", VA = "0x1876826B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool LJJDALHMJNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x7682AC0", Offset = "0x76810C0", VA = "0x187682AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public bool EOHKAGAOFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x7681D60", Offset = "0x7680360", VA = "0x187681D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool BBEDOGGECPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x7682680", Offset = "0x7680C80", VA = "0x187682680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public bool KKBHHJEBIHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x7682930", Offset = "0x7680F30", VA = "0x187682930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public bool HGDFAAHIFEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x7682270", Offset = "0x7680870", VA = "0x187682270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public bool ECAONDKNLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x7682510", Offset = "0x7680B10", VA = "0x187682510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool HBNCCMAFBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x7681F40", Offset = "0x7680540", VA = "0x187681F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	private ANDACNBFJKF EGGGEPPGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x767F520", Offset = "0x767DB20", VA = "0x18767F520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	private KOJAMECNJEF NLDGJODPDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x76820E0", Offset = "0x76806E0", VA = "0x1876820E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x76828C0", Offset = "0x7680EC0", VA = "0x1876828C0")]
	public bool IFNCGMNFCGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x76821D0", Offset = "0x76807D0", VA = "0x1876821D0")]
	public JHDEHBMJKKK EMFIKEOFINC(JHDEHBMJKKK MOCLCNOAHKF)
	{
		return default(JHDEHBMJKKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x7681E30", Offset = "0x7680430", VA = "0x187681E30")]
	public FHNHGOPNICC CFMJNGKHHMH()
	{
		return default(FHNHGOPNICC);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x7682750", Offset = "0x7680D50", VA = "0x187682750")]
	public bool HDPLDPBBHFI(FHNHGOPNICC INCCPBHMOJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x76829C0", Offset = "0x7680FC0", VA = "0x1876829C0")]
	public bool KBEBKPNACGO(FHNHGOPNICC LCOFPEMJPFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7682810", Offset = "0x7680E10", VA = "0x187682810")]
	public bool HOFFNBJOGHF(FHNHGOPNICC MOCLCNOAHKF, [Out] FHNHGOPNICC INCCPBHMOJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public GGIFBJBCJEI(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x76827F0", Offset = "0x7680DF0", VA = "0x1876827F0")]
	public static bool HEGJABMHLEC(GGIFBJBCJEI KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x7682480", Offset = "0x7680A80", VA = "0x187682480", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(GGIFBJBCJEI OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct MEMNNEFBJEI : IEquatable<MEMNNEFBJEI>
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly MEMNNEFBJEI OPDBFMPDHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public ADOECMLOFOB LGCJHPEGOEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x768CDC0", Offset = "0x768B3C0", VA = "0x18768CDC0")]
		get
		{
			return default(ADOECMLOFOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public CPAENDDAKAG GKMLNPEPKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x768CE00", Offset = "0x768B400", VA = "0x18768CE00")]
		get
		{
			return default(CPAENDDAKAG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x768C9F0", Offset = "0x768AFF0", VA = "0x18768C9F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public FLMNFNBLJCG IAODGAIPHAL
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x768CFA0", Offset = "0x768B5A0", VA = "0x18768CFA0")]
		get
		{
			return default(FLMNFNBLJCG);
		}
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x768CAF0", Offset = "0x768B0F0", VA = "0x18768CAF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public float ANLEPLHKAAN
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x768CCA0", Offset = "0x768B2A0", VA = "0x18768CCA0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x768CAA0", Offset = "0x768B0A0", VA = "0x18768CAA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public Vector3 MIKDNJLJDDB
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x768CED0", Offset = "0x768B4D0", VA = "0x18768CED0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x768CFE0", Offset = "0x768B5E0", VA = "0x18768CFE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public float APALEEOGEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x768CF50", Offset = "0x768B550", VA = "0x18768CF50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public EDJKJELJDNI GEJIFEELINC
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x768CE40", Offset = "0x768B440", VA = "0x18768CE40")]
		get
		{
			return default(EDJKJELJDNI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x768CC10", Offset = "0x768B210", VA = "0x18768CC10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public bool HFKONJBLIDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x768CC60", Offset = "0x768B260", VA = "0x18768CC60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x768CA40", Offset = "0x768B040", VA = "0x18768CA40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public MCOOOFNMHCJ KECLKMNFMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(MCOOOFNMHCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public NMLAECPNCHG FLDIKFAONCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(NMLAECPNCHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x768CBC0", Offset = "0x768B1C0", VA = "0x18768CBC0")]
	public PIMADICJMLC CMDHOALBEBF()
	{
		return default(PIMADICJMLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x768CE80", Offset = "0x768B480", VA = "0x18768CE80")]
	public OMGPNKEPIHM LCOFLAEIPHL()
	{
		return default(OMGPNKEPIHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x768CD70", Offset = "0x768B370", VA = "0x18768CD70")]
	private bool FLJAEHGCCBI(EDJKJELJDNI JFJMJEFHFHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x768CB40", Offset = "0x768B140", VA = "0x18768CB40")]
	public void BIKFLHMNGDB(EDJKJELJDNI JFJMJEFHFHO, bool BDDPPMGPFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public MEMNNEFBJEI(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x76827F0", Offset = "0x7680DF0", VA = "0x1876827F0")]
	public static bool HEGJABMHLEC(MEMNNEFBJEI KBGCCIOIGBD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x7681540", Offset = "0x767FB40", VA = "0x187681540")]
	public static bool HKDAGECLGLD(MEMNNEFBJEI AMGCKABOOPF, MEMNNEFBJEI PPCFCAEIJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x768CCE0", Offset = "0x768B2E0", VA = "0x18768CCE0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(MEMNNEFBJEI OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct PIMADICJMLC : IEquatable<PIMADICJMLC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public MEMNNEFBJEI DAAJNEDOHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(MEMNNEFBJEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public OFHIFDOIEMG FJHDNLPGOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7691770", Offset = "0x768FD70", VA = "0x187691770")]
		get
		{
			return default(OFHIFDOIEMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public PIMADICJMLC(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x76827F0", Offset = "0x7680DF0", VA = "0x1876827F0")]
	public static bool HEGJABMHLEC(PIMADICJMLC KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x76916E0", Offset = "0x768FCE0", VA = "0x1876916E0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(PIMADICJMLC OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[DefaultMember("Item")]
public readonly struct OMGPNKEPIHM : IEquatable<OMGPNKEPIHM>
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static readonly OMGPNKEPIHM OPDBFMPDHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	private OHHBLDMFDPB MKNNHPDPPJG
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x768F2C0", Offset = "0x768D8C0", VA = "0x18768F2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public MEMNNEFBJEI DAAJNEDOHBP
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(MEMNNEFBJEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public GHMFPPOCHDI NKIDCMIPBFE
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x768FA30", Offset = "0x768E030", VA = "0x18768FA30")]
		get
		{
			return default(GHMFPPOCHDI);
		}
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x768EEF0", Offset = "0x768D4F0", VA = "0x18768EEF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public IEnumerable<MOFBEMKMNKK> JFLJKEJLMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x768F3B0", Offset = "0x768D9B0", VA = "0x18768F3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public MOFBEMKMNKK NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x768F660", Offset = "0x768DC60", VA = "0x18768F660")]
		get
		{
			return default(MOFBEMKMNKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x768FB60", Offset = "0x768E160", VA = "0x18768FB60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public MCOOOFNMHCJ KECLKMNFMIH
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(MCOOOFNMHCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	private ANDACNBFJKF EGGGEPPGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x767F520", Offset = "0x767DB20", VA = "0x18767F520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	private KOJAMECNJEF NLDGJODPDLC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x768F230", Offset = "0x768D830", VA = "0x18768F230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x768F010", Offset = "0x768D610", VA = "0x18768F010")]
	public MOFBEMKMNKK CGDLHICEKJD(float3? NDADPNJPMFO, [Optional] quaternion? MLMNPOCKAAE, [Optional] Vector3? JJCKONKIIAI)
	{
		return default(MOFBEMKMNKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x768F800", Offset = "0x768DE00", VA = "0x18768F800")]
	public MOFBEMKMNKK KLHNJBNJIGK(int EAHKFAJBNDN, float3? NDADPNJPMFO, [Optional] quaternion? MLMNPOCKAAE, [Optional] Vector3? JJCKONKIIAI)
	{
		return default(MOFBEMKMNKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x768F5C0", Offset = "0x768DBC0", VA = "0x18768F5C0")]
	public void IKJELBOAPFN(int EAHKFAJBNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x768F770", Offset = "0x768DD70", VA = "0x18768F770")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public OMGPNKEPIHM(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x76827F0", Offset = "0x7680DF0", VA = "0x1876827F0")]
	public static bool HEGJABMHLEC(OMGPNKEPIHM KBGCCIOIGBD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x7685790", Offset = "0x7683D90", VA = "0x187685790")]
	public static bool BFIJCNNIIMH(OMGPNKEPIHM AMGCKABOOPF, OMGPNKEPIHM PPCFCAEIJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x768F320", Offset = "0x768D920", VA = "0x18768F320", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(OMGPNKEPIHM OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct MOFBEMKMNKK : IEquatable<MOFBEMKMNKK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public OMGPNKEPIHM KMOHBHNONJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x768D390", Offset = "0x768B990", VA = "0x18768D390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public float3 KOHIGCEHKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x768D190", Offset = "0x768B790", VA = "0x18768D190")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x768D470", Offset = "0x768BA70", VA = "0x18768D470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public quaternion NDNJPIJMLJM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x768D1F0", Offset = "0x768B7F0", VA = "0x18768D1F0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x768D4D0", Offset = "0x768BAD0", VA = "0x18768D4D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public float3 JCCHJCKKHHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x768D250", Offset = "0x768B850", VA = "0x18768D250")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x768D410", Offset = "0x768BA10", VA = "0x18768D410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public HMNOMFGLPAB BCMALLHHLBO
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x768D2B0", Offset = "0x768B8B0", VA = "0x18768D2B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x768D240", Offset = "0x768B840", VA = "0x18768D240")]
	public void CMOPBFELFDM(OMGPNKEPIHM KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public MOFBEMKMNKK(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x768D300", Offset = "0x768B900", VA = "0x18768D300", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(MOFBEMKMNKK OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct LLFLNDONOCH : IEquatable<LLFLNDONOCH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	private LNGDPPIAHJG HGOFHIBBKAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x768A080", Offset = "0x7688680", VA = "0x18768A080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public bool PPPJKGFGIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7689F40", Offset = "0x7688540", VA = "0x187689F40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7689EE0", Offset = "0x76884E0", VA = "0x187689EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public bool GCPBKNDLGKN
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7689920", Offset = "0x7687F20", VA = "0x187689920")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x768A020", Offset = "0x7688620", VA = "0x18768A020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public float POPBMCCAEMF
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x768A200", Offset = "0x7688800", VA = "0x18768A200")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x768A290", Offset = "0x7688890", VA = "0x18768A290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	public bool EOIMIOLEBBL
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x76898D0", Offset = "0x7687ED0", VA = "0x1876898D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	public FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	private ANDACNBFJKF EGGGEPPGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x767F520", Offset = "0x767DB20", VA = "0x18767F520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	private KOJAMECNJEF NLDGJODPDLC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7689B40", Offset = "0x7688140", VA = "0x187689B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x768A0E0", Offset = "0x76886E0", VA = "0x18768A0E0")]
	public void JOOPLBPKEHA(int ADMEOFCKKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x768A430", Offset = "0x7688A30", VA = "0x18768A430")]
	public bool OECKIJKLDEL([Out] int ADMEOFCKKPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x7689AA0", Offset = "0x76880A0", VA = "0x187689AA0")]
	public void CMDPOMJAHJO(bool JCJFCCPEKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x768A240", Offset = "0x7688840", VA = "0x18768A240")]
	public bool MAHDPMNGONJ(EIFCHLJGNJM JFJMJEFHFHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x768A180", Offset = "0x7688780", VA = "0x18768A180")]
	public void LBGDPFECGCO(EIFCHLJGNJM JFJMJEFHFHO, bool BDDPPMGPFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x768A2E0", Offset = "0x76888E0", VA = "0x18768A2E0")]
	public void MNKHDDNPDIG(float PDIODPHMHGF, float APKLJMPADLG, float ONPHHDAHFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x7689BD0", Offset = "0x76881D0", VA = "0x187689BD0")]
	public void DALGMDIABJG(float3 NGJFINCCCLI, quaternion CEJEPHNHIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x7689D20", Offset = "0x7688320", VA = "0x187689D20")]
	public bool DDDBIEJFCAF([Out] float3 NGJFINCCCLI, [Out] quaternion CEJEPHNHIBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x7689970", Offset = "0x7687F70", VA = "0x187689970")]
	public bool CBLDOMNOJCG([Out] float FIBJCNJHNMM, [Out] float HGKOJJCLAOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x7689F90", Offset = "0x7688590", VA = "0x187689F90")]
	public void HILODPEAODF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public LLFLNDONOCH(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x7689E50", Offset = "0x7688450", VA = "0x187689E50", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(LLFLNDONOCH OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct MCOOOFNMHCJ : IEquatable<MCOOOFNMHCJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	private FDJNGADHLPI MOBNNHOEMOB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x768C930", Offset = "0x768AF30", VA = "0x18768C930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public Vector3 KOHIGCEHKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x768AC50", Offset = "0x7689250", VA = "0x18768AC50")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x768C2E0", Offset = "0x768A8E0", VA = "0x18768C2E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public Quaternion NDNJPIJMLJM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x768B020", Offset = "0x7689620", VA = "0x18768B020")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x768C520", Offset = "0x768AB20", VA = "0x18768C520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public Vector3 LEEAOGLADAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x768B5B0", Offset = "0x7689BB0", VA = "0x18768B5B0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x768B900", Offset = "0x7689F00", VA = "0x18768B900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public Quaternion PEKONLBNMJB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x768BDA0", Offset = "0x768A3A0", VA = "0x18768BDA0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x768BCD0", Offset = "0x768A2D0", VA = "0x18768BCD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public float JBJGLOCLKJM
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x768BAA0", Offset = "0x768A0A0", VA = "0x18768BAA0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x768C230", Offset = "0x768A830", VA = "0x18768C230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	public float BBPBPOAPNGP
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x768C190", Offset = "0x768A790", VA = "0x18768C190")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	public Matrix4x4 NIBNHBJIIGI
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x768C8F0", Offset = "0x768AEF0", VA = "0x18768C8F0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	public NMLAECPNCHG FLDIKFAONCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(NMLAECPNCHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	private ANDACNBFJKF EGGGEPPGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x767F520", Offset = "0x767DB20", VA = "0x18767F520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x768C5F0", Offset = "0x768ABF0", VA = "0x18768C5F0")]
	public LCHJICBNMPB NMFCEEOABPF()
	{
		return default(LCHJICBNMPB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x768B730", Offset = "0x7689D30", VA = "0x18768B730")]
	public void FCPIOONGMJC([Out] Matrix4x4 GLNFFLIPMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x768B220", Offset = "0x7689820", VA = "0x18768B220")]
	public void DCPOGLHNDGB([In] Vector3 IJNCCGADGJC, [In] Quaternion BALNGIJIBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x768B160", Offset = "0x7689760", VA = "0x18768B160")]
	public void DCPOGLHNDGB([In] RigidTransform AJPMFLCPPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x768B500", Offset = "0x7689B00", VA = "0x18768B500")]
	public void EDGFILNCIHJ([Out] RigidTransform AJPMFLCPPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x768C700", Offset = "0x768AD00", VA = "0x18768C700")]
	public void OAMAMDGIFPM([In] Vector3 JEBADFJBDID, [In] Quaternion JNAFDDNECGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x768C640", Offset = "0x768AC40", VA = "0x18768C640")]
	public void OAMAMDGIFPM([In] RigidTransform EJDKLMAIDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x768BB40", Offset = "0x768A140", VA = "0x18768BB40")]
	public void JDACLLOKHBP([Out] Vector3 JEBADFJBDID, [Out] Quaternion JNAFDDNECGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x768BC20", Offset = "0x768A220", VA = "0x18768BC20")]
	public void JDACLLOKHBP([Out] RigidTransform AJPMFLCPPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x768C8C0", Offset = "0x768AEC0", VA = "0x18768C8C0")]
	public UniformTRS OCELKOLFNKF()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x768C800", Offset = "0x768AE00", VA = "0x18768C800")]
	public void OCELKOLFNKF([Out] UniformTRS EJDKLMAIDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x768B4D0", Offset = "0x7689AD0", VA = "0x18768B4D0")]
	public UniformTRS DLAOABINBAJ()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x768B410", Offset = "0x7689A10", VA = "0x18768B410")]
	public void DLAOABINBAJ([Out] UniformTRS AJPMFLCPPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x768B320", Offset = "0x7689920", VA = "0x18768B320")]
	public Vector3 DJPMFBAFCIK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x768AB80", Offset = "0x7689180", VA = "0x18768AB80")]
	public void AJGENMFNDCH([In] Vector3 KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x768AD40", Offset = "0x7689340", VA = "0x18768AD40")]
	public Vector3 BJPKMHFKEEP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x768C0C0", Offset = "0x768A6C0", VA = "0x18768C0C0")]
	public void KLIDAHAIOCC([In] Vector3 KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x768AE30", Offset = "0x7689430", VA = "0x18768AE30")]
	public Quaternion BMCNMGAIGJL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x768C3B0", Offset = "0x768A9B0", VA = "0x18768C3B0")]
	public void MAABBEGGFHN([In] Quaternion KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x768BEE0", Offset = "0x768A4E0", VA = "0x18768BEE0")]
	public Quaternion KDFMNJPLEFD()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x768B9D0", Offset = "0x7689FD0", VA = "0x18768B9D0")]
	public void GLEPIOFOLIJ([In] Quaternion KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x768C480", Offset = "0x768AA80", VA = "0x18768C480")]
	public float MOOMGAGALEJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x768B850", Offset = "0x7689E50", VA = "0x18768B850")]
	public void FOKIHFCPLHE(float KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x768C020", Offset = "0x768A620", VA = "0x18768C020")]
	public float KDOCLBEDCNH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x768AF70", Offset = "0x7689570", VA = "0x18768AF70")]
	public void BMHMFHKJFIH(float KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public MCOOOFNMHCJ(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x768B6A0", Offset = "0x7689CA0", VA = "0x18768B6A0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(MCOOOFNMHCJ OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct BIHLNGOIOPN : IEquatable<BIHLNGOIOPN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	private ELBCPBMHNBO IHNIEJPBIKM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x767F920", Offset = "0x767DF20", VA = "0x18767F920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	public JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	private ANDACNBFJKF EGGGEPPGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x767F520", Offset = "0x767DB20", VA = "0x18767F520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	private KOJAMECNJEF NLDGJODPDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x767F6C0", Offset = "0x767DCC0", VA = "0x18767F6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x767F7E0", Offset = "0x767DDE0", VA = "0x18767F7E0")]
	public void LDCMLNJKJLA(string FHGNCBECHHF, PCENCNMKLOB JJPIAJMIOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public BIHLNGOIOPN(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x767F750", Offset = "0x767DD50", VA = "0x18767F750", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(BIHLNGOIOPN OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x767E930", Offset = "0x767CF30", VA = "0x18767E930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct IGKBNNCJFDD : IEquatable<IGKBNNCJFDD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public GOBCHKKNALB EIMDMONAKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x7684B30", Offset = "0x7683130", VA = "0x187684B30")]
		get
		{
			return default(GOBCHKKNALB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public IGKBNNCJFDD(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x7684AA0", Offset = "0x76830A0", VA = "0x187684AA0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(IGKBNNCJFDD OKCHLIEAIJP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct LELPMBPANMN : IEquatable<LELPMBPANMN>
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public struct MMIMOMDLEHP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private FHNHGOPNICC KPOCLGHHOEP;

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x768D0F0", Offset = "0x768B6F0", VA = "0x18768D0F0")]
		public MMIMOMDLEHP(FHNHGOPNICC KPOCLGHHOEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x768D060", Offset = "0x768B660", VA = "0x18768D060", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x7688660", Offset = "0x7686C60", VA = "0x187688660")]
	public MMIMOMDLEHP FOFIHJEGBLL()
	{
		return default(MMIMOMDLEHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x76884E0", Offset = "0x7686AE0", VA = "0x1876884E0")]
	public AMLBPDJCHBI EPLHCNKDBAK(Allocator LEILKJFLDFN = Allocator.Temp)
	{
		return default(AMLBPDJCHBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x76883B0", Offset = "0x76869B0", VA = "0x1876883B0")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> DLLGJHKJKMI(Allocator LEILKJFLDFN = Allocator.Temp)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x76886F0", Offset = "0x7686CF0", VA = "0x1876886F0")]
	public NativeArray<GFBOHEINDFO> IMIFLJIMMFN(Allocator LEILKJFLDFN = Allocator.Temp)
	{
		return default(NativeArray<GFBOHEINDFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x76889A0", Offset = "0x7686FA0", VA = "0x1876889A0")]
	public NativeArray<GFBOHEINDFO> LKPJDPACGBI(Allocator LEILKJFLDFN = Allocator.Temp)
	{
		return default(NativeArray<GFBOHEINDFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x76888E0", Offset = "0x7686EE0", VA = "0x1876888E0")]
	public PCANLNGHNBK LFKEFCPLHAJ(Allocator LEILKJFLDFN = Allocator.Temp)
	{
		return default(PCANLNGHNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x7688820", Offset = "0x7686E20", VA = "0x187688820")]
	public PCANLNGHNBK JKJPOEAJDEH(Allocator LEILKJFLDFN = Allocator.Temp)
	{
		return default(PCANLNGHNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x76882F0", Offset = "0x76868F0", VA = "0x1876882F0")]
	public PCANLNGHNBK ABIKMMHINJM(Allocator LEILKJFLDFN = Allocator.Temp)
	{
		return default(PCANLNGHNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public LELPMBPANMN(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x76885D0", Offset = "0x7686BD0", VA = "0x1876885D0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(LELPMBPANMN OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x767F6A0", Offset = "0x767DCA0", VA = "0x18767F6A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct DNEKKHHAHNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public int JJKOODBGBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public int FEGKGFBIHMH;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct LNNECADLIEA : IEquatable<LNNECADLIEA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public LELPMBPANMN AAIJMEJAHEP
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(LELPMBPANMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public BGLAODGDACA IONAMOKNDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(BGLAODGDACA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public IGKBNNCJFDD BJEJGLAGBKD
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(IGKBNNCJFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x768A780", Offset = "0x7688D80", VA = "0x18768A780")]
	public bool FBHBILGCCKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x768A820", Offset = "0x7688E20", VA = "0x18768A820")]
	public bool GNGOFDIEFJJ([Out] Exception JNJDMGFBFDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public LNNECADLIEA(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
	public static FHNHGOPNICC HEGJABMHLEC(LNNECADLIEA KBGCCIOIGBD)
	{
		return default(FHNHGOPNICC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x768A6F0", Offset = "0x7688CF0", VA = "0x18768A6F0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(LNNECADLIEA OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x767F6A0", Offset = "0x767DCA0", VA = "0x18767F6A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct HNIKKMCLFOF : IDisposable, IEquatable<HNIKKMCLFOF>
{
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly HNIKKMCLFOF OPDBFMPDHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public LNNECADLIEA NBDKCOPBDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(LNNECADLIEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public LELPMBPANMN AAIJMEJAHEP
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(LELPMBPANMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x76846C0", Offset = "0x7682CC0", VA = "0x1876846C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public HNIKKMCLFOF(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x7684790", Offset = "0x7682D90", VA = "0x187684790", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "5")]
	public bool Equals(HNIKKMCLFOF OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x7684820", Offset = "0x7682E20", VA = "0x187684820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public readonly struct BGLAODGDACA : IEquatable<BGLAODGDACA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public bool LLJIALBNKJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x767F580", Offset = "0x767DB80", VA = "0x18767F580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	public BGLAODGDACA(FHNHGOPNICC KPOCLGHHOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x767E410", Offset = "0x767CA10", VA = "0x18767E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x767F610", Offset = "0x767DC10", VA = "0x18767F610", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x767E3B0", Offset = "0x767C9B0", VA = "0x18767E3B0", Slot = "4")]
	public bool Equals(BGLAODGDACA OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x767F6A0", Offset = "0x767DCA0", VA = "0x18767F6A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class FDIPBADBDEA
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private struct EOOFBKDGDAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Guid JINNLDEOCMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public OICLFODNOLJ EPHDGLKLHHJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private struct OICLFODNOLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int KBGCCIOIGBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int PBNKONBPKJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public int PDHAAKBNHGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int GGMJBAACHGB;

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x768EE10", Offset = "0x768D410", VA = "0x18768EE10")]
		public bool BNKHEKNHLKO([Out] GFBOHEINDFO OJGFMNKCCFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x768EEB0", Offset = "0x768D4B0", VA = "0x18768EEB0")]
		public OICLFODNOLJ(GFBOHEINDFO OJGFMNKCCFJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x7680C10", Offset = "0x767F210", VA = "0x187680C10")]
	public static Guid EOGNEKGKFMB(this GFBOHEINDFO OJGFMNKCCFJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x7680CB0", Offset = "0x767F2B0", VA = "0x187680CB0")]
	public static bool JBGCDENMAAN(this Guid JINNLDEOCMO, [Out] GFBOHEINDFO OJGFMNKCCFJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal static class KHNOMHIMMHM
{
	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x7687500", Offset = "0x7685B00", VA = "0x187687500")]
	public static KOJAMECNJEF NLDGJODPDLC(this FHNHGOPNICC KGHCKLKGJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x7687390", Offset = "0x7685990", VA = "0x187687390")]
	public static GDMALILFBDO GAHPOFMMCLE(this FHNHGOPNICC KGHCKLKGJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x7687300", Offset = "0x7685900", VA = "0x187687300")]
	public static EntityManager FJADCGKECOJ(this FHNHGOPNICC KGHCKLKGJKM)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x34AB2D0", Offset = "0x34A98D0", VA = "0x1834AB2D0")]
	internal static bool DAJEKIPGFJH<T>(this FHNHGOPNICC KGHCKLKGJKM, bool BDDPPMGPFHE) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x76873F0", Offset = "0x76859F0", VA = "0x1876873F0")]
	public static bool KBLLKIEDGPJ(this FHNHGOPNICC KGHCKLKGJKM, IDDBKPIMPMC KKCCAKAEMAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x34AFAB0", Offset = "0x34AE0B0", VA = "0x1834AFAB0")]
	public static bool IJEJEBMEKBP<T>(this FHNHGOPNICC KGHCKLKGJKM) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x34ADE80", Offset = "0x34AC480", VA = "0x1834ADE80")]
	public static bool HGJAOFKABLC<T>(this FHNHGOPNICC KGHCKLKGJKM) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x34ADF30", Offset = "0x34AC530", VA = "0x1834ADF30")]
	[LAHMMLMGGEA]
	public static T HKPNFBACEHO<T>(this FHNHGOPNICC KGHCKLKGJKM) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x34AB3B0", Offset = "0x34A99B0", VA = "0x1834AB3B0")]
	[LAHMMLMGGEA]
	public static T DDBPDCOFBJL<T>(this FHNHGOPNICC KGHCKLKGJKM) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x34ADDE0", Offset = "0x34AC3E0", VA = "0x1834ADDE0")]
	public static bool DIMOHPGIHJM<T>(this FHNHGOPNICC KGHCKLKGJKM, [Out] T KBGCCIOIGBD) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x34B0230", Offset = "0x34AE830", VA = "0x1834B0230")]
	public static T PINLPLPPHLP<T>(this FHNHGOPNICC KGHCKLKGJKM) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x34B0300", Offset = "0x34AE900", VA = "0x1834B0300")]
	public static T PNKENCNMFAC<T>(this FHNHGOPNICC KGHCKLKGJKM) where T : class, IComponentData
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal static class CKGMNMDHAHC
{
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DefaultMember("Item")]
public struct AMLBPDJCHBI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private PCANLNGHNBK MOEBIEOOLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> HOHEAFBHMGK;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x5623D00", Offset = "0x5622300", VA = "0x185623D00")]
	public AMLBPDJCHBI(PCANLNGHNBK MOEBIEOOLFC, NativeArray<EntityRemapUtility.EntityRemapInfo> HOHEAFBHMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x767DD50", Offset = "0x767C350", VA = "0x18767DD50")]
	public LocalId LGIFLKDNMCB(LocalId GMFKPONAANG)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x767DD90", Offset = "0x767C390", VA = "0x18767DD90")]
	public LocalId LGIFLKDNMCB(int EAHKFAJBNDN)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x767DCE0", Offset = "0x767C2E0", VA = "0x18767DCE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PGCIHGMCKEE
{
	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	Guid MEIBALMGCHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	Guid HGDALMIPLKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JAPHPIHOFEG(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task IDAMBAFBFPM(JHDEHBMJKKK GMFKPONAANG);

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid NNJMDLOJAKF(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DKINNIEHGID(FHNHGOPNICC KPOCLGHHOEP, Guid MEGMENINLOE);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ACPLMICIHDN(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task FMBCNCKPHGB(FHNHGOPNICC DJHFBAMKFNI, FHNHGOPNICC LDIAONMHHPK);
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JNPDLFCEKDL
{
	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	Guid MEIBALMGCHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOJCGNJMCCE(NativeList<Guid> OMDJCPDNFEN, NativeList<Guid> GNFNEFOKFHF, NativeList<FixedString64Bytes> CJFAOPBKIEL);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KAGOHBOHHHF
{
	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PCANLNGHNBK APKGJODKIFB(Allocator LEILKJFLDFN);

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PCANLNGHNBK JEMFILOHOBN(Allocator LEILKJFLDFN);

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NLBALCKHEOO(FHNHGOPNICC JOFIFDPGHKD);

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PDDEDICKIKI(FHNHGOPNICC JOFIFDPGHKD);

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IFEDLCGAPEP(FHNHGOPNICC JOFIFDPGHKD);

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LKKGCMAIELJ(FHNHGOPNICC JOFIFDPGHKD, int CGHBAOIKKLL);

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FHNHGOPNICC LLHFHBBCHAM(FHNHGOPNICC JEGMNGJHPFL);

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JHEBKEALADC(PCANLNGHNBK KDAGENDCBLC, bool JECGFOPMLHH);

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DIIFEPHOIFP(FHNHGOPNICC NMFKPCDLLEP, bool HLIIILHEDFA);

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool MBGBIOCPLKD(FHNHGOPNICC JOFIFDPGHKD);

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JGIPJFJMKIN(FHNHGOPNICC JOFIFDPGHKD, bool BCIIJFODFJL);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int AHJPNNJCMKE();
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GIFNIBDCFIP
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<FHNHGOPNICC, FHNHGOPNICC> CNCOJEHHKPE;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<FHNHGOPNICC, FHNHGOPNICC> EEPGEGJEBOL;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<FHNHGOPNICC, FHNHGOPNICC, FHNHGOPNICC> PJIJBLGKMDP;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<FHNHGOPNICC> GFAMBKDAJHM;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PEFOMJKNMKD(FHNHGOPNICC KPOCLGHHOEP, FHNHGOPNICC KDNCMGDENBO);

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FHNHGOPNICC DGDJLNKPKJI(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "10")]
	PCANLNGHNBK JDGDFMEFOJI(FHNHGOPNICC KPOCLGHHOEP, Allocator LEILKJFLDFN);

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FHNHGOPNICC ADGAIBBDHJD(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OADOKCCCHGO(FHNHGOPNICC KPOCLGHHOEP, Vector3 FDCPPCKCABA, Quaternion IEODDBPKAOA);

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FFBIFGIFHAL(FHNHGOPNICC KPOCLGHHOEP, float OPPJBCDKOCC);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool JOBFNGMKDIP(FHNHGOPNICC KPOCLGHHOEP, [Out] FHNHGOPNICC LDIAONMHHPK);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool LHDLDAGHFPD(FHNHGOPNICC KPOCLGHHOEP, [Out] RigidTransform MFBADEAOMFD);

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 BLNJCKFPNGD(LJGDHGEBGHI DGKBEFCBLCI);

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion BFIGOAPKCOL(LJGDHGEBGHI DGKBEFCBLCI);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class OIJJHLNKAJL
{
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FNHEEJOANFA
{
	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	object DJFPOPGBOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HJODKEHGPJN
{
	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOKAKEIIFAN(FHNHGOPNICC GMFKPONAANG, OJOCGBDBALB FKOFMENDCEB);

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OKJHJLEKDLK(OJOCGBDBALB FKOFMENDCEB);

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KJFMPBNDOGB(FHNHGOPNICC KPOCLGHHOEP, [Out] OJOCGBDBALB PEMCMDBPGGA);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[Flags]
public enum JDANLPMOHME
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	IncludeSelf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	IncludeChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	IncludeDescendants = 6,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	IncludeMask = 7,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Disembodied = 8,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Embodied = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	IgnoreEmbodiment = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	EmbodimentMask = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Runtime = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Authored = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	AuthoredAndRuntime = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	HierarchyMask = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	HintInputsAreDisjoint = 0x80
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public readonly struct CMMDHOPHNGF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly string OMOOEGOLALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly T IDJBNLNBJCD;

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x5C48420", Offset = "0x5C46A20", VA = "0x185C48420")]
	public CMMDHOPHNGF(T IDJBNLNBJCD, [Optional][CallerMemberName] string OMOOEGOLALI)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public static readonly CMMDHOPHNGF<int> BOAEPFBGEKC;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public static readonly CMMDHOPHNGF<int> KEGHLKAMJAM;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public static readonly CMMDHOPHNGF<int> HBGJCONIHCH;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public enum FHNFEOPEBII
{
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class BBNAIEIHEFP
{
	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x105FA60", Offset = "0x105E060", VA = "0x18105FA60")]
	public static bool CCOHJJBBHBI(this FHNFEOPEBII CEGAGHAOIDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x1401690", Offset = "0x13FFC90", VA = "0x181401690")]
	public static bool HHEKPEKCJLJ(this FHNFEOPEBII CEGAGHAOIDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x2BA1BF0", Offset = "0x2BA01F0", VA = "0x182BA1BF0")]
	public static bool KPHEDDGCLMJ(this FHNFEOPEBII CEGAGHAOIDD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface GIFHHNPEBIO
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public enum IECABAHJKCP
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		Unloaded,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		Loading,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		Loaded,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public enum LJMFDKHEGDA
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	IECABAHJKCP BLOPHGENEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	bool NJFJDPKONAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	bool PPAAIGIGKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	LJMFDKHEGDA DEDJHPPKCED
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[ServiceLifetime(Lifetime.Application)]
public interface PGELPCAAOPM
{
	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	FHNFEOPEBII GJMKKBEGBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	FHNFEOPEBII KKJJGGFFFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	FHNFEOPEBII PJJJFIHAIOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	FHNFEOPEBII CFNGCKEKLEF
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	FHNFEOPEBII IONOGHDCAFL
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	FHNFEOPEBII NHGDFEHJCDC
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	FHNFEOPEBII OFBPCGHHCMG
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	FHNFEOPEBII NBIKACGDOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	FHNFEOPEBII BBMCEDMBKJE
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	FHNFEOPEBII ENNJFINEENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	FHNFEOPEBII FIHIOBAAADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	FHNFEOPEBII KBAALCIBFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	FHNFEOPEBII OLKDMJFOOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	FHNFEOPEBII GKADFIDLDEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	FHNFEOPEBII IDGCPCLHFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	FHNFEOPEBII FGKELPGENKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	FHNFEOPEBII MFOANPHOLOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NPPDIJEBOHO(CMMDHOPHNGF<int> HIGIOODIHPF);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IMLCHGCIBDL
{
	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event HAFCLLKMOOM.JHHMEOJGAFP IBNAIONLCDP;

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FHNHGOPNICC OIKELICKEGK(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PCANLNGHNBK PGAPJGFEBAN(Allocator LEILKJFLDFN);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HMNOMFGLPAB OLCLFAJIKLH(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PLHHCEJBIIG(IEnumerable<FHNHGOPNICC> JNHKOIEBHOL);

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HMNOMFGLPAB BOFHDBDOEOK(FHNHGOPNICC LDIAONMHHPK, FHNHGOPNICC MOEBIEOOLFC, bool OAFEJFONPMA, FHNHGOPNICC MOCLCNOAHKF);

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FHNHGOPNICC KLKMJAGJCKK(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PDMHANMAJFJ(FHNHGOPNICC KPOCLGHHOEP, FHNHGOPNICC LDIAONMHHPK, bool LMFFCHAIHLC = false);

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool CBLGCILBGKF(FHNHGOPNICC KPOCLGHHOEP, FHNHGOPNICC LDIAONMHHPK);

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool IHNLMNOAMEC(FHNHGOPNICC FPBAPGAKDMN, FHNHGOPNICC DBILKENBPAN);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[Obsolete("Use IHierarchyService.GetChildren() instead")]
	PCANLNGHNBK GPANCEGEKEB(FHNHGOPNICC NMFKPCDLLEP);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool DLGOMJHGNMB(FHNHGOPNICC KPOCLGHHOEP, FHNHGOPNICC IOMOJBPAMEP);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	PCANLNGHNBK PMICALBNGNI(PCANLNGHNBK MAJLFJCHEPP, JDANLPMOHME PNCPEFMKILJ, Allocator LEILKJFLDFN);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool JPEBAKPLOOH(FHNHGOPNICC KPOCLGHHOEP, FHNHGOPNICC LGNIHKABDBC);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	FHNHGOPNICC FFKGEFBAGIA(FHNHGOPNICC MOCLCNOAHKF, FHNHGOPNICC MICOBGHPPNH);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool LMHPEEEDIDM(FHNHGOPNICC MOCLCNOAHKF, FHNHGOPNICC MICOBGHPPNH, [Out] FHNHGOPNICC JFGNAMIHIOJ);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	FHNHGOPNICC LEMECGPCDCA(FHNHGOPNICC[] KDAGENDCBLC);

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "18")]
	FHNHGOPNICC FBFBHFCEDDO(FHNHGOPNICC KPOCLGHHOEP, uint HAKLJPKGBKK);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class COJDFBCOILF
{
	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x76800F0", Offset = "0x767E6F0", VA = "0x1876800F0")]
	public static bool DDBFPNBFMBI(this IMLCHGCIBDL PNMHGOHNFCK, FHNHGOPNICC KPOCLGHHOEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x76802A0", Offset = "0x767E8A0", VA = "0x1876802A0")]
	public static PCANLNGHNBK PMICALBNGNI(this IMLCHGCIBDL GJJILEPKCHB, FHNHGOPNICC KPOCLGHHOEP, JDANLPMOHME PNCPEFMKILJ, Allocator LEILKJFLDFN)
	{
		return default(PCANLNGHNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x76801A0", Offset = "0x767E7A0", VA = "0x1876801A0")]
	public static PCANLNGHNBK DKBMGDAGAIE(this IMLCHGCIBDL GJJILEPKCHB, FHNHGOPNICC KPOCLGHHOEP, Allocator LEILKJFLDFN)
	{
		return default(PCANLNGHNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x7680220", Offset = "0x767E820", VA = "0x187680220")]
	public static PCANLNGHNBK JNPNJPMJKCI(this IMLCHGCIBDL GJJILEPKCHB, FHNHGOPNICC KPOCLGHHOEP, Allocator LEILKJFLDFN)
	{
		return default(PCANLNGHNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x76801E0", Offset = "0x767E7E0", VA = "0x1876801E0")]
	public static PCANLNGHNBK IJPGFHKNHPB(this IMLCHGCIBDL GJJILEPKCHB, FHNHGOPNICC KPOCLGHHOEP, Allocator LEILKJFLDFN)
	{
		return default(PCANLNGHNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x7680260", Offset = "0x767E860", VA = "0x187680260")]
	public static PCANLNGHNBK MGFFPDGOJED(this IMLCHGCIBDL GJJILEPKCHB, FHNHGOPNICC KPOCLGHHOEP, Allocator LEILKJFLDFN)
	{
		return default(PCANLNGHNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x7680160", Offset = "0x767E760", VA = "0x187680160")]
	public static PCANLNGHNBK DFNOKBDLICK(this IMLCHGCIBDL GJJILEPKCHB, FHNHGOPNICC KPOCLGHHOEP, Allocator LEILKJFLDFN)
	{
		return default(PCANLNGHNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x7680530", Offset = "0x767EB30", VA = "0x187680530")]
	public static PCANLNGHNBK PMICALBNGNI(this IMLCHGCIBDL GJJILEPKCHB, FHNHGOPNICC KPOCLGHHOEP, Allocator LEILKJFLDFN)
	{
		return default(PCANLNGHNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x76800B0", Offset = "0x767E6B0", VA = "0x1876800B0")]
	public static PCANLNGHNBK ABDLOGMAJBJ(this IMLCHGCIBDL GJJILEPKCHB, FHNHGOPNICC KPOCLGHHOEP, Allocator LEILKJFLDFN)
	{
		return default(PCANLNGHNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x767FF90", Offset = "0x767E590", VA = "0x18767FF90")]
	public static PCANLNGHNBK ABDLOGMAJBJ(this IMLCHGCIBDL GJJILEPKCHB, PCANLNGHNBK KPOCLGHHOEP, Allocator LEILKJFLDFN)
	{
		return default(PCANLNGHNBK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PFMKCGLAJFE
{
	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ADAPBJDILJP NILOKNDIDOM(FHNHGOPNICC JOFIFDPGHKD);

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJEHPKGJAGE(FHNHGOPNICC JOFIFDPGHKD, ADAPBJDILJP JFBINNAEIKL);

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JLPBIPMLJBO(FHNHGOPNICC JOFIFDPGHKD);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JHPIKHBGPIF(FHNHGOPNICC JOFIFDPGHKD, bool KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JLFIEIINFCM<string> DHCFIGJDIKC(FHNHGOPNICC JOFIFDPGHKD);

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NIIAMKPGAKE(FHNHGOPNICC JOFIFDPGHKD, JLFIEIINFCM<string> KEJFIGAFLGB);

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JLFIEIINFCM<string> DALLKPOGEHB(FHNHGOPNICC JOFIFDPGHKD);

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OAFCFFLIBND(FHNHGOPNICC JOFIFDPGHKD, JLFIEIINFCM<string> KEJFIGAFLGB);

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	JLFIEIINFCM<string> FKBNMGBAIDB(FHNHGOPNICC JOFIFDPGHKD);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BKOIKPHDAFI(FHNHGOPNICC JOFIFDPGHKD, JLFIEIINFCM<string> KEJFIGAFLGB);

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JLFIEIINFCM<string> PFHDOFAOIAI(FHNHGOPNICC JOFIFDPGHKD);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LODCFADAFBE(FHNHGOPNICC JOFIFDPGHKD, JLFIEIINFCM<string> KEJFIGAFLGB);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool FHHLCCDKBEE(FHNHGOPNICC JOFIFDPGHKD, FHNHGOPNICC OEIBHCOIKMG);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PJENFBHPOMD
{
	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x76917B0", Offset = "0x768FDB0", VA = "0x1876917B0", Slot = "0")]
	Task<LNNECADLIEA> PFKCMCOBLKM(PLEGJMDHKHI PIBAHAPGAGK, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "1")]
	void MMFFKIEDIDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JLLLEOFLDKA
{
	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	bool ACEKDEAEJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	bool AECOJLKGKFH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	bool KEPNKMPFEND
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NENGGIIPFNE
{
	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KFBIJDJKACF([In] float3 IGFMIOBPFAL, [In] float3 BNCGOADGBEC, float HIAAOMCAGFP, [Out] GJDKPOODDGE PCIAIPKBJIK, [Out] FHNHGOPNICC JBENCCOBBHH);

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int BNHIEBKIJOI([In] float3 IGFMIOBPFAL, float PMGAIALCDAG, List<FHNHGOPNICC> KDAGENDCBLC);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int IKPHLEGAJAC(Plane[] PLJECPKBPKM, float3 IGFMIOBPFAL, float3 NIMGHHOFKBJ, quaternion MLMNPOCKAAE, List<FHNHGOPNICC> KDAGENDCBLC);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MLLAIFPGGAJ
{
	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KFBIJDJKACF([In] NativeArray<Entity> AKCBEPDCJFL, [In] float3 IGFMIOBPFAL, [In] float3 BNCGOADGBEC, [In] NativeArray<GJDKPOODDGE> KPFFEKNKJEM);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> BNHIEBKIJOI([In] NativeArray<Entity> AKCBEPDCJFL, [In] float3 IGFMIOBPFAL, float PMGAIALCDAG);

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> IKPHLEGAJAC([In] NativeArray<Entity> AKCBEPDCJFL, [In] NativeArray<float4> LIDIKGMFJIB);
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct MBDMBJAFBFP : KBLKBJHICLE, IEquatable<MBDMBJAFBFP>
{
	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	public int MPMCCDHNNEC
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x99D850", Offset = "0x99BE50", VA = "0x18099D850", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x10AD620", Offset = "0x10ABC20", VA = "0x1810AD620", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	public int EMCKBBMGOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB1F0", Offset = "0x2BB97F0", VA = "0x182BBB1F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x67C36C0", Offset = "0x67C1CC0", VA = "0x1867C36C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x768AAA0", Offset = "0x76890A0", VA = "0x18768AAA0", Slot = "8")]
	public bool Equals(MBDMBJAFBFP OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x768AAF0", Offset = "0x76890F0", VA = "0x18768AAF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct GJDKPOODDGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public float GCIOBCHMLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float3 FGKLFPNFOKI;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LBGHDBNNFCM
{
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ANDACNBFJKF
{
	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	KOJAMECNJEF NLDGJODPDLC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	AEGEMGIHCCJ PLBIHHBNEKH
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<PCANLNGHNBK, NativeArray<RRObjectPrefabData>> FALFDKFFLJJ;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<PCANLNGHNBK> AOLHKOHDDIO;

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CBKOFJIKNOE DECAAHAIDDG(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	RRObjectPrefabData PKBNILLDFKA(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KABPHDGGDHJ(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JHDEHBMJKKK NJINGLNDKBL(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool LPBCLBCDAGE(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IOKNLENABEG(FHNHGOPNICC KPOCLGHHOEP, [Out] Transform EJNLPEDOMDD);

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	FHNHGOPNICC OGJAACJLCME(GFBOHEINDFO OJGFMNKCCFJ);

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool GKIFBLIBHNF(GFBOHEINDFO OJGFMNKCCFJ, [Out] FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GFBOHEINDFO CPAPHHKAGLH(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	PCANLNGHNBK OGJAACJLCME(NativeArray<GFBOHEINDFO> OJGFMNKCCFJ, Allocator LEILKJFLDFN, bool FNEGDIDBPLE = true);

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HINJLNINBBJ(RRObjectPrefabData GHJDJHIELJH, NativeArray<Entity> AKCBEPDCJFL);

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool IMPBBMFJCLB(NativeArray<MNGFOGALJIN> PEPGIMENHCJ, NativeArray<GFBOHEINDFO> KMMICFJHCIC, NativeArray<Entity> KLCLONKBOCH);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	JHDEHBMJKKK BJEDIDGDNMJ();

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	JHDEHBMJKKK PPDNPJPLIPJ(RRObjectPrefabData GHJDJHIELJH);

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	NIJDLJAFJCA ICBOADJOEDF();

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	OMGPNKEPIHM GOFKBLFCKDM();

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	PIMADICJMLC CPNFPCFBDII(OFHIFDOIEMG BOAGHNFLLNN);

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void PNHKGLMNFCI();

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void KEEFIMLDFLA(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool LDNKPNCBHMK(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "26")]
	PCANLNGHNBK BCCAFGKNGPJ(PCANLNGHNBK CIJMICAOHEP, Allocator LEILKJFLDFN);

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool GAJJJBGADKG(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	FHNHGOPNICC DEGKKLEBEPC(Transform EJNLPEDOMDD);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public static class AKAGFMEEKKF
{
	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x767D840", Offset = "0x767BE40", VA = "0x18767D840")]
	internal static FHNHGOPNICC KLMJOOKLDBK(this Entity FCJGDHPNMHF, ANDACNBFJKF JJPIAJMIOLG)
	{
		return default(FHNHGOPNICC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x767D5E0", Offset = "0x767BBE0", VA = "0x18767D5E0")]
	public static JHDEHBMJKKK BHECCNGJBAM(this ANDACNBFJKF JJPIAJMIOLG, LocalId KPOCLGHHOEP)
	{
		return default(JHDEHBMJKKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x767D8F0", Offset = "0x767BEF0", VA = "0x18767D8F0")]
	public static FHNHGOPNICC OGJAACJLCME(this ANDACNBFJKF JJPIAJMIOLG, LocalId KPOCLGHHOEP)
	{
		return default(FHNHGOPNICC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x767D5F0", Offset = "0x767BBF0", VA = "0x18767D5F0")]
	public static GFBOHEINDFO CPAPHHKAGLH(this ANDACNBFJKF JJPIAJMIOLG, LocalId KPOCLGHHOEP)
	{
		return default(GFBOHEINDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x767DB40", Offset = "0x767C140", VA = "0x18767DB40")]
	public static NIJDLJAFJCA OKPFCPCBCNP(this ANDACNBFJKF JJPIAJMIOLG, RigidTransform EJDKLMAIDCF)
	{
		return default(NIJDLJAFJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x767D660", Offset = "0x767BC60", VA = "0x18767D660")]
	public static PIMADICJMLC FMGNPCPENJJ(this ANDACNBFJKF JJPIAJMIOLG, OFHIFDOIEMG GOAJLEACEKF, RigidTransform EJDKLMAIDCF)
	{
		return default(PIMADICJMLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x767D9A0", Offset = "0x767BFA0", VA = "0x18767D9A0")]
	public static OMGPNKEPIHM OHLJDLNJKML(this ANDACNBFJKF JJPIAJMIOLG, RigidTransform EJDKLMAIDCF)
	{
		return default(OMGPNKEPIHM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x767D810", Offset = "0x767BE10", VA = "0x18767D810")]
	private static void JFOJHCOKAPP(JHDEHBMJKKK AGGONAKKLJF, RigidTransform EJDKLMAIDCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal interface OHPGBLDNGBO
{
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IALGJCOKLIO
{
	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	bool ELJNHIPNNIH
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	FHNHGOPNICC EEPGGLHOMAE
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	JHDEHBMJKKK DGKCMKFBNNA
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event AJIPIILGBDP NOBPNPFJECN;

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FHNHGOPNICC FFKGEFBAGIA(FHNHGOPNICC MOCLCNOAHKF, FHNHGOPNICC MICOBGHPPNH);

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LMHPEEEDIDM(FHNHGOPNICC MOCLCNOAHKF, FHNHGOPNICC MICOBGHPPNH, [Out] FHNHGOPNICC JFGNAMIHIOJ);

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CEFBEJGKIEB();

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MMGAPKLOPNH();

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool HPBMOAHLDAF(FHNHGOPNICC MOCLCNOAHKF);

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool KKBHHJEBIHD(FHNHGOPNICC MOCLCNOAHKF);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public delegate void AJIPIILGBDP(JHDEHBMJKKK ILANIJMCLIJ, JHDEHBMJKKK BIOOPIGDEBB);
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class LNNCFJJLINB
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x768A540", Offset = "0x7688B40", VA = "0x18768A540")]
	public static bool CNIJEAPGBNG(this IALGJCOKLIO NDGKPKJDCND, JHDEHBMJKKK MOCLCNOAHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x768A610", Offset = "0x7688C10", VA = "0x18768A610")]
	public static bool FLBDGHELNJE(this IALGJCOKLIO NDGKPKJDCND, FHNHGOPNICC MOCLCNOAHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x768A590", Offset = "0x7688B90", VA = "0x18768A590")]
	public static bool EOHKAGAOFDG(this IALGJCOKLIO NDGKPKJDCND, FHNHGOPNICC MOCLCNOAHKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EHEDDPDOCFC
{
	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DINEDAEBKAB(NativeList<RRObjectPrefabData> GNJCEGEACGF);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BPLJCDNMHGN
{
	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JKDPPGLECMM(JHDEHBMJKKK AGGONAKKLJF, EKDALHPLPPO OPCPCOOFBPO, List<JHDEHBMJKKK> JCAJHFICHIE);

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int AMBEHCLCEEG(JHDEHBMJKKK AGGONAKKLJF, EKDALHPLPPO OPCPCOOFBPO);

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NDGNPPKJEPO(JHDEHBMJKKK AGGONAKKLJF, List<JHDEHBMJKKK> JCAJHFICHIE);

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int FBHOADIJODJ(JHDEHBMJKKK ADMEOFCKKPF, JHDEHBMJKKK MOCLCNOAHKF, EKDALHPLPPO OPCPCOOFBPO);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JHDEHBMJKKK IICGKFDIMDE(JHDEHBMJKKK ADMEOFCKKPF, int EAHKFAJBNDN, EKDALHPLPPO OPCPCOOFBPO);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MFKCKPFFGGA(JHDEHBMJKKK ADMEOFCKKPF, JHDEHBMJKKK MOCLCNOAHKF, EKDALHPLPPO OPCPCOOFBPO);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LKLKJIJBINM(JHDEHBMJKKK ADMEOFCKKPF, JHDEHBMJKKK MOCLCNOAHKF, EKDALHPLPPO OPCPCOOFBPO);

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DBPCDLKGOMJ(JHDEHBMJKKK ADMEOFCKKPF, EKDALHPLPPO OPCPCOOFBPO);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool APBPODKILAH(JHDEHBMJKKK ADMEOFCKKPF, JHDEHBMJKKK MOCLCNOAHKF, EKDALHPLPPO OPCPCOOFBPO);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EPNOLOIPGDK(Entity ADMEOFCKKPF, Entity MOCLCNOAHKF, EKDALHPLPPO OPCPCOOFBPO);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LNGOBNNHPHM(Entity ADMEOFCKKPF, EKDALHPLPPO OPCPCOOFBPO);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LOPAOCGDDJO(JHDEHBMJKKK MOCLCNOAHKF, EKDALHPLPPO OPCPCOOFBPO);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KOJAFJBMJFD
{
	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	IGKBNNCJFDD AFJMNLIIGKD
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GOBCHKKNALB GMPCDAKDHJE(IGKBNNCJFDD BKPGIELGADI);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IGKBNNCJFDD DAKOIDKOPAO();

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IGKBNNCJFDD PDPGGNJCBMD();
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FNHIKEJNFOA
{
	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HDPLDPBBHFI(FHNHGOPNICC MOCLCNOAHKF, FHNHGOPNICC INCCPBHMOJL);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KBEBKPNACGO(FHNHGOPNICC MOCLCNOAHKF, FHNHGOPNICC LCOFPEMJPFM);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HOFFNBJOGHF(FHNHGOPNICC MOCLCNOAHKF, [Out] FHNHGOPNICC JIPDIBNNGJL);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NPONJMFEIBM
{
	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NKICFGFBLHG(FHNHGOPNICC NMFKPCDLLEP, bool KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBBOHLPIFHC(FHNHGOPNICC NMFKPCDLLEP, bool KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BCBJGOKJEDH(FHNHGOPNICC NMFKPCDLLEP, int KBGCCIOIGBD);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OHHBLDMFDPB
{
	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<FHNHGOPNICC> IMPFBNCGDGC(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FHNHGOPNICC FMIDNCNCKDC(FHNHGOPNICC KPOCLGHHOEP, int EAHKFAJBNDN);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int JFNAFEOALLC(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GHMFPPOCHDI MAOADHDGIBJ(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KMBFJKNEALH(FHNHGOPNICC KPOCLGHHOEP, GHMFPPOCHDI FJJOKDBOKAE);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FHNHGOPNICC ELGGDJLLHDN(FHNHGOPNICC KPOCLGHHOEP, [Optional] float3? NDADPNJPMFO, [Optional] quaternion? MLMNPOCKAAE, [Optional] float3? JJCKONKIIAI);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FHNHGOPNICC IEJJHAHAMGM(FHNHGOPNICC KPOCLGHHOEP, int EAHKFAJBNDN, [Optional] float3? NDADPNJPMFO, [Optional] quaternion? MLMNPOCKAAE, [Optional] float3? JJCKONKIIAI);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PAIBGEOPEHI(FHNHGOPNICC KPOCLGHHOEP, int EAHKFAJBNDN);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MHMALNELKBD(FHNHGOPNICC KPOCLGHHOEP);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ALAIBBMINGM
{
	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	bool IPBAHPGFFFA
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBHOFMHMNHB();

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ALBEDDNEBOM();

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LDGMDODBDFL();

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MHBOCBEGJKO();

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PAMCKALCLFD();

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LAKAHNJBGME();

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AHKJMDNEHPP();

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GKFPIEPECOL();

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NCBCDPFJKGM();

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KJMDCDENEFJ();

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FOHLLEFHILA();

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KPMAENDEFJE();
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LNGDPPIAHJG
{
	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OECKIJKLDEL(FHNHGOPNICC MOCLCNOAHKF, [Out] int ADMEOFCKKPF);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JOOPLBPKEHA(FHNHGOPNICC MOCLCNOAHKF, int ADMEOFCKKPF);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CMDPOMJAHJO(FHNHGOPNICC MOCLCNOAHKF, bool JCJFCCPEKEA);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MNKHDDNPDIG(FHNHGOPNICC MOCLCNOAHKF, float PDIODPHMHGF, float APKLJMPADLG, float ONPHHDAHFID);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CBLDOMNOJCG(FHNHGOPNICC KPOCLGHHOEP, [Out] float APKLJMPADLG, [Out] float ONPHHDAHFID);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DALGMDIABJG(FHNHGOPNICC MOCLCNOAHKF, float3 NDADPNJPMFO, quaternion MLMNPOCKAAE);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DDDBIEJFCAF(FHNHGOPNICC MOCLCNOAHKF, [Out] float3 NDADPNJPMFO, [Out] quaternion MLMNPOCKAAE);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HILODPEAODF(FHNHGOPNICC MOCLCNOAHKF);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FDJNGADHLPI
{
	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AJGENMFNDCH(Entity FCJGDHPNMHF, [In] float3 KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float3 DJPMFBAFCIK(Entity FCJGDHPNMHF);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MAABBEGGFHN(Entity FCJGDHPNMHF, [In] quaternion KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "3")]
	quaternion BMCNMGAIGJL(Entity FCJGDHPNMHF);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DCPOGLHNDGB(Entity FCJGDHPNMHF, [In] float3 NDADPNJPMFO, [In] quaternion MLMNPOCKAAE);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EDGFILNCIHJ(Entity FCJGDHPNMHF, [Out] RigidTransform HGFICPLCPIO);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OAMAMDGIFPM(Entity FCJGDHPNMHF, [In] float3 NDADPNJPMFO, [In] quaternion MLMNPOCKAAE);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JDACLLOKHBP(Entity FCJGDHPNMHF, [Out] float3 NDADPNJPMFO, [Out] quaternion MLMNPOCKAAE);

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JDACLLOKHBP(Entity FCJGDHPNMHF, [Out] RigidTransform HGFICPLCPIO);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FOKIHFCPLHE(Entity FCJGDHPNMHF, float KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float MOOMGAGALEJ(Entity FCJGDHPNMHF);

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KLIDAHAIOCC(Entity FCJGDHPNMHF, [In] float3 KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 BJPKMHFKEEP(Entity FCJGDHPNMHF);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GLEPIOFOLIJ(Entity FCJGDHPNMHF, [In] quaternion KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	quaternion KDFMNJPLEFD(Entity FCJGDHPNMHF);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BMHMFHKJFIH(Entity FCJGDHPNMHF, float KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float KDOCLBEDCNH(Entity FCJGDHPNMHF);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ABMBMKABKFC(Entity FCJGDHPNMHF, [Out] float4x4 GLNFFLIPMPB);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NNALIJDDGHI(Entity FCJGDHPNMHF, [In] float4x4 GLNFFLIPMPB);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void KOEPLGABLAM(Entity FCJGDHPNMHF);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void ALPBLBDKGLL(Entity FCJGDHPNMHF, Entity OIKBDABGNHP, Entity DFDGPBFKIGC);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class OFBEHOFPCGF
{
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GBPADHKLFCC
{
	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOIKBPJGINE(bool IGJKIMIMKAB);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ELBCPBMHNBO
{
	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBNNMPDNKNB(FHNHGOPNICC JOFIFDPGHKD, JLFIEIINFCM<string> KEJFIGAFLGB);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OONFFMGJNMD(FHNHGOPNICC JOFIFDPGHKD, JLFIEIINFCM<string> KEJFIGAFLGB);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MEPMLLHMJMG(FHNHGOPNICC JOFIFDPGHKD, JLFIEIINFCM<string> KEJFIGAFLGB);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AIONNMGBANK(FHNHGOPNICC JOFIFDPGHKD, JLFIEIINFCM<string> KEJFIGAFLGB);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GHDFFKHPIHJ(FHNHGOPNICC JOFIFDPGHKD, JLFIEIINFCM<string> KEJFIGAFLGB);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DDLNEOLDDLE(FHNHGOPNICC JOFIFDPGHKD, JLFIEIINFCM<string> KEJFIGAFLGB);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int IACEJJLHDEG(FHNHGOPNICC JOFIFDPGHKD);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int CHFBFFPGGEE(FHNHGOPNICC JOFIFDPGHKD);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int AAOLGHJLHBJ(FHNHGOPNICC JOFIFDPGHKD);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EFMCPKJOHAF<string> AGHKHGCFFLA(FHNHGOPNICC JOFIFDPGHKD);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KBMDBHPMPGP(FHNHGOPNICC JOFIFDPGHKD);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "11")]
	EFMCPKJOHAF<string> MOCEDFFGIJK(FHNHGOPNICC JOFIFDPGHKD);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MHBBGHMMLMJ(FHNHGOPNICC JOFIFDPGHKD, string FHGNCBECHHF);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LKMGFJMNEDG(string FHGNCBECHHF, PCENCNMKLOB IEBNFIPPJPN);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FHNHGOPNICC AGLNPJIHMLK(string FHGNCBECHHF);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IOAHILDKAOG(string FHGNCBECHHF, PCENCNMKLOB IEBNFIPPJPN);

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LDCMLNJKJLA(FHNHGOPNICC NDACNEEFKIN, string FHGNCBECHHF, PCENCNMKLOB IEBNFIPPJPN);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public static class GDABMLELPMF
{
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OFKGJGIEFKK
{
	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World DPNHNOGGAIK(string JGIEBLFGHHA = "Main");

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World IBAFNJJBNGM(string JGIEBLFGHHA = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World PIDNLKFBMDP(string JGIEBLFGHHA = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World LJFDFDIPAAE(string JGIEBLFGHHA = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GDMALILFBDO
{
	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	World FLENAKDPEIA
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	World NKOMAKOIEIA
	{
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	EntityManager FJADCGKECOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	bool KFMLNKJFEGL
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase ABFIMHDNAEP(Type BMIPLDLMPCD);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public static class OMLHOBAKBON
{
	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x768FBF0", Offset = "0x768E1F0", VA = "0x18768FBF0")]
	public static ComponentSystemBase NOMFEHBIFJI(this World ENFBJMHAMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x35FB4F0", Offset = "0x35F9AF0", VA = "0x1835FB4F0")]
	public static T ABFIMHDNAEP<T>(this GDMALILFBDO FAGEJIFELCM) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BEIMKIFECNK
{
	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNENLIMKGMM(NativeListAsync<Entity> GDHBJJKHBIH);

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IFAEEEMKFKI(HIEKEBOAHBL KFCJCCMOPDN);

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HPNDLOFONDA(NativeListAsync<Entity> HKGLBCMKCFB, bool KPBEAEKPEMK);

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KCBEIIJHMMO();

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JFEAMIGAMGE(Entity JGHOOBNHEJB);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface IEPAOKKIIIO
{
	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DLAAKDCLPCK(Collider FAEGMNIAGDM, [Out] CEAJMDNMFIO FJIGJMMMAOC);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PGAOOIFDBBC
{
	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider HDNAANLFOFN(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject LKFEMAMHEDH(FHNHGOPNICC NKBAOBBJFOG, GameObject CFENBMBECBB, Vector3 IJNCCGADGJC, Quaternion BALNGIJIBOK);

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IBBBODJHDOD(GameObject FAEGMNIAGDM);

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider MMHJFDEGEFK<TCollider>(GameObject EBOEBOKGGHI) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DDPAFGJAIGJ(Collider FAEGMNIAGDM);

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject PHJOKLMDJKN<TCollider>(string OMOOEGOLALI) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BAACBHFDECL NKOLCBCCCKD(FHNHGOPNICC EMJHFKCDDDH, FHNHGOPNICC NDKPAMHJHII, OFHIFDOIEMG JCAGGJMGMBJ, float3 KNADGLGKLEA, quaternion GELGEBGODHP, float3 IGOKMENAGDH);

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool LGNGBJCJBFK(FHNHGOPNICC KPOCLGHHOEP, [Out] BAACBHFDECL FAEGMNIAGDM);

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool AEHHJBABMNN(FHNHGOPNICC KPOCLGHHOEP, [Out] FHNHGOPNICC JGHOOBNHEJB);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public enum BDKIBGINBAL
{
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IAGBBFEPOKL
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public struct DEADOPBFLPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int JCAGGJMGMBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public GameObject CFENBMBECBB;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKCABBIGFAG(FHNHGOPNICC KPOCLGHHOEP, LAKFMIPGDFM LNMNPIKFANM, bool PBDCLPPHOHB, KMKOJLIANAG CMPALLPMJLC);

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KGHILNCHFGF(FHNHGOPNICC KPOCLGHHOEP, LAKFMIPGDFM LNMNPIKFANM, bool PBDCLPPHOHB, bool KBAOINDCBFN, bool IFKHIAONNHB);

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EBPEBDALCPC FJNENLCPKGC(FHNHGOPNICC JGHOOBNHEJB, List<FHNHGOPNICC> NEKPLALKOPL);

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BAACBHFDECL ACIGPFIKKOB(GameObject AACNMIFEANO, GameObject LHLJGIAGEBN);

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NAHLBAHFKHF(GameObject AACNMIFEANO, List<GameObject> LHMFFNPABHM);

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DCIMGEKDAJC(GameObject LHLJGIAGEBN);

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T MMHJFDEGEFK<T>(GameObject EBOEBOKGGHI) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DDPAFGJAIGJ(Collider FAEGMNIAGDM);

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject HJCENAHIGJI<T>(string OMOOEGOLALI) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GLGOFLOKKLM(Collider FAEGMNIAGDM, [Out] FHNHGOPNICC ADMEOFCKKPF);

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MGLMDMMFJPE(FHNHGOPNICC KPOCLGHHOEP, [Out] CEAJMDNMFIO FJIGJMMMAOC);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<BDKIBGINBAL> GBMLFMLDGBA(Allocator LEILKJFLDFN = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] ONODIFFGAML();
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface POMLDMADPGA
{
	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FCMEIMELBLA(FHNHGOPNICC KPOCLGHHOEP, FHNHGOPNICC KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCPCDKKDOMN(FHNHGOPNICC KPOCLGHHOEP, FHNHGOPNICC KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int EEPGBFKEEPP(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FHNHGOPNICC FODDECJFNCE(FHNHGOPNICC KPOCLGHHOEP, int EAHKFAJBNDN);

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PCANLNGHNBK BKHHJNIBJBN(FHNHGOPNICC KPOCLGHHOEP, Allocator LEILKJFLDFN = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NKFKMCOPBNA(FHNHGOPNICC KPOCLGHHOEP, object LAAJFAFNFCN, FHNHGOPNICC KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NIGEMEABLPO(FHNHGOPNICC KPOCLGHHOEP, object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool KPABJCOFJCK(FHNHGOPNICC KPOCLGHHOEP, [Out] FHNHGOPNICC KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OFLPEKBMMLE(FHNHGOPNICC KPOCLGHHOEP, float3 KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool NILEDGNPCJG(FHNHGOPNICC KPOCLGHHOEP, [Out] float3 KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KOJHAEIGDDO(FHNHGOPNICC KPOCLGHHOEP, float3 KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OGGIDLKHJPM(FHNHGOPNICC KPOCLGHHOEP, [Out] float3 KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PJKHAEOAAGO(FHNHGOPNICC KPOCLGHHOEP, (Quaternion rot, Vector3 moments) BDGCMKHKJGI);

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool NOLKINFIJAA(FHNHGOPNICC KPOCLGHHOEP, [Out] quaternion PPMLNGGNBKE, [Out] float3 GCCGAPLOELI);

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GLPBEPFKLOK(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 LPIBAFHABJO(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 ODPNPCEKBCC(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CANBHGGFLLA(FHNHGOPNICC KPOCLGHHOEP, float3 KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void LKBJJCCIGMA(FHNHGOPNICC KPOCLGHHOEP, float3 KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float NJCMCGFJMCA(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float GDNBNNHFDBL(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void NJLNNEAIIML(FHNHGOPNICC KPOCLGHHOEP, float KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NIEHKOKOIBH(FHNHGOPNICC KPOCLGHHOEP, float KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode NBJCCDEPBMP(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CINDOOEOPJI(FHNHGOPNICC KPOCLGHHOEP, CollisionDetectionMode KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(Slot = "25")]
	GPBDIJCMDDB CMEPPMFPCPO(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void HDMDNIGHAJA(FHNHGOPNICC KPOCLGHHOEP, GPBDIJCMDDB KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool DPJLDLDNBEN(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void JLLJBFEGFPD(FHNHGOPNICC KPOCLGHHOEP, bool KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(Slot = "29")]
	FHNHGOPNICC OIKELICKEGK(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void ABAPOJGEKAH(FHNHGOPNICC KPOCLGHHOEP, FHNHGOPNICC KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(Slot = "31")]
	FHNHGOPNICC KLKMJAGJCKK(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void PDMHANMAJFJ(FHNHGOPNICC KPOCLGHHOEP, FHNHGOPNICC KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(Slot = "33")]
	FALLENFFJHK NLBBHBFBNAO(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void AHFIIIABIKK(FHNHGOPNICC KPOCLGHHOEP, FALLENFFJHK BHLDBBEMKKJ);

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool PGJMGOKFMPJ(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void EPEDBPJEMCP(FHNHGOPNICC KPOCLGHHOEP, bool KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool GMKDJAAKFAI(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void LEKAJFOPCHH(FHNHGOPNICC KPOCLGHHOEP, bool KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints ENLDDAHDPJL(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void DPBADMKOBHK(FHNHGOPNICC KPOCLGHHOEP, RigidbodyConstraints KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float LFEBDOIBIGB(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void MLOMCPFHJNO(FHNHGOPNICC KPOCLGHHOEP, float KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float JGAPPPOAPND(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void INBHHMLDACG(FHNHGOPNICC KPOCLGHHOEP, float KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool EPLLLJHNEBN(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void IKAGGMDHEIF(FHNHGOPNICC KPOCLGHHOEP, bool KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool JMHCLEMPMMH(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void PNBBBLHCJDB(FHNHGOPNICC KPOCLGHHOEP, bool KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void HFIKEILFCPA(FHNHGOPNICC KPOCLGHHOEP, int KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(Slot = "50")]
	OPMGDNEPOAI FDMLAHICDMM(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void FCIHNPBGIFO(FHNHGOPNICC KPOCLGHHOEP, OPMGDNEPOAI KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(Slot = "52")]
	HHKIIOIPKEL DLBBCFKHCHJ(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void NBGNFKMBHIK(FHNHGOPNICC KPOCLGHHOEP, HHKIIOIPKEL KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float MIDOGJCELBM(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void BLLEBGOJPCD(FHNHGOPNICC KPOCLGHHOEP, float KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void OHAPIGCKFPM(FHNHGOPNICC KPOCLGHHOEP, object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void NDJBJPJPLOL(FHNHGOPNICC KPOCLGHHOEP, object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool ENPBDGLJEDK(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void BLGFBHCKAMI(FHNHGOPNICC KPOCLGHHOEP, object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void EICFLGEMAMF(FHNHGOPNICC KPOCLGHHOEP, object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool HKKMPLLMCME(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool DKMAHDLIJDC(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody BNJNBJLBAOK(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void LBKEJJBEINE(FHNHGOPNICC KPOCLGHHOEP, Rigidbody HFMGHKAPEPN);

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void HLDEHJLFKFN(FHNHGOPNICC KPOCLGHHOEP, object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void EBAOIBANCHE(FHNHGOPNICC KPOCLGHHOEP, object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool CFBLKJMJNJF(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void INFEAMJEJKL(FHNHGOPNICC KPOCLGHHOEP, float3 PGIPNLMJJCH);

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void IOMBMELNDFP(FHNHGOPNICC KPOCLGHHOEP, float3 GNFIJOGHJJB);

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool HCFGBFGHDBI(FHNHGOPNICC KPOCLGHHOEP, [Out] float3 PGIPNLMJJCH);

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool PKMKICMIPCD(FHNHGOPNICC KPOCLGHHOEP, [Out] float3 GNFIJOGHJJB);

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool OAHEBJFIIJA(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void PABKEGCKIHH(FHNHGOPNICC KPOCLGHHOEP, object LAAJFAFNFCN, bool OCMDPMDMEEP);

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void HNBJAEGBMHL(FHNHGOPNICC KPOCLGHHOEP, bool LLGGOPCIBLP);

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void NJFBHNJCNEL(FHNHGOPNICC KPOCLGHHOEP);

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool LLPOCDMNCPH(FHNHGOPNICC KPOCLGHHOEP);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ABADBCCGOJC
{
	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IMEOCNGMECH(Entity BMAEGHBHDFK);

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FGJCEFAHJHM(Entity BMAEGHBHDFK);
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CFLNNNFPHBA
{
	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LPPBMEJOFFM(FHNHGOPNICC MOCLCNOAHKF, bool BOJJJKNPNPO);
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public delegate void DBJBBBEIEOP(DDHAFLMHIMF BICOLGKMENG);
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public readonly ref struct DDHAFLMHIMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly PCANLNGHNBK APLBIBIENJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly NativeArray<byte> OJLBMLCGKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly NativeArray<byte> NDFDECAONLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly IDDBKPIMPMC KKCCAKAEMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly int LLMIMMLMOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly Type PNOFKLHJDOK;

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	public PCANLNGHNBK DECCOIHMBAD
	{
		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x4788C50", Offset = "0x4787250", VA = "0x184788C50")]
		get
		{
			return default(PCANLNGHNBK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	public int AFNDGLAJDJM
	{
		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x76805A0", Offset = "0x767EBA0", VA = "0x1876805A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x76805C0", Offset = "0x767EBC0", VA = "0x1876805C0")]
	public DDHAFLMHIMF(PCANLNGHNBK APLBIBIENJC, NativeArray<byte> OJLBMLCGKGE, NativeArray<byte> NDFDECAONLF, IDDBKPIMPMC KKCCAKAEMAH, int LLMIMMLMOOB, Type PNOFKLHJDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x3246D20", Offset = "0x3245320", VA = "0x183246D20")]
	public NativeArray<T> JCICKJJFPIN<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x3246D60", Offset = "0x3245360", VA = "0x183246D60")]
	public NativeArray<T> MDNKECEBEEH<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x3246DA0", Offset = "0x32453A0", VA = "0x183246DA0")]
	public (PCANLNGHNBK, NativeArray<T>, NativeArray<T>) NPPDIJEBOHO<T>() where T : struct
	{
		return default((PCANLNGHNBK, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x7680570", Offset = "0x767EB70", VA = "0x187680570")]
	public BJGLMIHPBFI HDCJJKCDHPJ()
	{
		return default(BJGLMIHPBFI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public interface MCKBJDDOOCN
{
	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	string DDAOLGHNGIB
	{
		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	MCKBJDDOOCN NGLCBNJHCIK
	{
		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	IEnumerable<MCKBJDDOOCN> MGFBGKHIKFA
	{
		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface FNNLKBKLOIG
{
	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	MCKBJDDOOCN PAJKGCLIBDP
	{
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	NativeArray<IDDBKPIMPMC> PHPPDDPIFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GLADEBAOJHJ(IDDBKPIMPMC KKCCAKAEMAH, [Out] MCKBJDDOOCN CMHPCDCAOKM);

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OCICFIBHEPA(IDDBKPIMPMC KKCCAKAEMAH, DBJBBBEIEOP NLBJBMPFGCD);

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IBEJEPFGGMM(IDDBKPIMPMC KKCCAKAEMAH, DBJBBBEIEOP NLBJBMPFGCD);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GCBFHACKPEG
{
	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCICFIBHEPA(IDDBKPIMPMC KKCCAKAEMAH, DBJBBBEIEOP NLBJBMPFGCD);

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IBEJEPFGGMM(IDDBKPIMPMC KKCCAKAEMAH, DBJBBBEIEOP NLBJBMPFGCD);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class JBMMLECKIMM
{
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DKLOBKFLFLH
{
	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	bool EIBPIHECLOC
	{
		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	APJNMIKLDJK FNMLJDGHFJF
	{
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MMODMDBINGB(GOBCHKKNALB OJGFMNKCCFJ, bool LBNOHOEGLNE);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AHOPGJLPCIB(GFBOHEINDFO OJGFMNKCCFJ, IDDBKPIMPMC KKCCAKAEMAH);

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IHOKDPOLIKI(NativeArray<GFBOHEINDFO> FIEKPLDABEH);
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public static class GCNLPCGDCFA
{
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public readonly ref struct BJGLMIHPBFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly DDHAFLMHIMF GIDGOODJFLJ;

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	public PCANLNGHNBK DECCOIHMBAD
	{
		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x4788C50", Offset = "0x4787250", VA = "0x184788C50")]
		get
		{
			return default(PCANLNGHNBK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x767FED0", Offset = "0x767E4D0", VA = "0x18767FED0")]
	public BJGLMIHPBFI(DDHAFLMHIMF GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x767F980", Offset = "0x767DF80", VA = "0x18767F980")]
	public PCANLNGHNBK JCICKJJFPIN()
	{
		return default(PCANLNGHNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x767FAB0", Offset = "0x767E0B0", VA = "0x18767FAB0")]
	public PCANLNGHNBK MDNKECEBEEH()
	{
		return default(PCANLNGHNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x767FBE0", Offset = "0x767E1E0", VA = "0x18767FBE0")]
	public (PCANLNGHNBK, PCANLNGHNBK, PCANLNGHNBK) NPPDIJEBOHO()
	{
		return default((PCANLNGHNBK, PCANLNGHNBK, PCANLNGHNBK));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public static class KOBLLKDFEPJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public readonly struct APJNMIKLDJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly NativeBitArray CBNKHNAKNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly NativeParallelHashMap<GFBOHEINDFO, int> ALEBNDKKMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly NativeParallelHashSet<GOBCHKKNALB> FLJOMHKIHCM;

	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	public bool FMIKOAOEFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x767DFD0", Offset = "0x767C5D0", VA = "0x18767DFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	public bool EIBPIHECLOC
	{
		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x767DFF0", Offset = "0x767C5F0", VA = "0x18767DFF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x56A44A0", Offset = "0x56A2AA0", VA = "0x1856A44A0")]
	public APJNMIKLDJK(NativeBitArray CBNKHNAKNDO, NativeParallelHashMap<GFBOHEINDFO, int> ALEBNDKKMIL, NativeParallelHashSet<GOBCHKKNALB> FLJOMHKIHCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x767DDE0", Offset = "0x767C3E0", VA = "0x18767DDE0")]
	public bool AHOPGJLPCIB(GFBOHEINDFO OJGFMNKCCFJ, IDDBKPIMPMC KKCCAKAEMAH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OBFOPMLNHAJ
{
	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	FFCHMNNCDPE LGBOACBHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface KADHNIAOJGG
{
	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AEJBKDCDDDH(FHNHGOPNICC KPOCLGHHOEP, MCJIKLCEHHO KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DGKNAAFCKEM LOOLAEAPJBD();
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BOMHNKIDBAA
{
	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HALELABMJKE(World ENFBJMHAMNL);

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GCOLGNFLEPO(World ENFBJMHAMNL);

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase NNFBCGIIGKL(World ENFBJMHAMNL);

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EAIHIKJGCGG(World ENFBJMHAMNL);

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HNPNNLNNEEE(World ENFBJMHAMNL);

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AKPOJNGDJIH(World ENFBJMHAMNL);

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OOOOJLFIILA(World ENFBJMHAMNL);

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> KNBPBFOMJHC();
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NFMPJODALLJ
{
	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEBCOEBCIAM(FHNHGOPNICC NMFKPCDLLEP, bool KBGCCIOIGBD);
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public readonly struct HPJEIGBNCAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly IEnumerable<BGEHNHONEMA> MCKHCNKFJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly IReadOnlyList<GameObject> EPPMBMLCMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly IReadOnlyList<int> KOKAFDPFKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly IReadOnlyList<(GFBOHEINDFO, GFBOHEINDFO)> IKJHGKHGEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly int PFEDPNDEBII;
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public struct EMMKEPOBLDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public InventionIdData KGHCKLKGJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public InventionInstanceIdData IBBBMNKKNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public bool CHBIOMHDGNE;

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x76808B0", Offset = "0x767EEB0", VA = "0x1876808B0")]
	public EMMKEPOBLDG(long KGHCKLKGJKM, Guid IBBBMNKKNOJ, bool CHBIOMHDGNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[ServiceLifetime(Lifetime.Application)]
public interface DPBEBOPHMGB
{
	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LNNECADLIEA IMMCCBPEFCO(PLEGJMDHKHI OCPBOBGPENE, int MLGLNBMGCAA = 0, bool FGEKLHKPICE = false);

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HNIKKMCLFOF LBIBFOAAHKD(PLEGJMDHKHI OCPBOBGPENE, FHNHGOPNICC LDIAONMHHPK, [In] UniformTRS FPDFJICJNOF, KEFHNHHELAB CDGFGMLIACM, [Optional] EMMKEPOBLDG PFCDPICNBEO, bool KDMIGIEELDB = true, bool NJKBDLPPGMD = false, bool FGEKLHKPICE = false);

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AOCPMMFELLJ EKCJEIPFPGA();

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AOCPMMFELLJ PJIOHCKPLHF(PCANLNGHNBK KDAGENDCBLC, [In] UniformTRS ODFGAAALAPK);

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FBHBILGCCKO(FHNHGOPNICC IFHPHKGDDHL);

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GNGOFDIEFJJ(FHNHGOPNICC IFHPHKGDDHL, [Out] Exception BNMNAMAKIOH);

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<GFBOHEINDFO> IMIFLJIMMFN(FHNHGOPNICC IFHPHKGDDHL, Allocator LEILKJFLDFN);

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeArray<GFBOHEINDFO> LKPJDPACGBI(FHNHGOPNICC IFHPHKGDDHL, Allocator LEILKJFLDFN);

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PCANLNGHNBK LFKEFCPLHAJ(FHNHGOPNICC IFHPHKGDDHL, Allocator LEILKJFLDFN);

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PCANLNGHNBK JKJPOEAJDEH(FHNHGOPNICC IFHPHKGDDHL, Allocator LEILKJFLDFN);

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(Slot = "10")]
	PCANLNGHNBK FGBNLIGKBLD(FHNHGOPNICC IFHPHKGDDHL, Allocator LEILKJFLDFN);

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> DLLGJHKJKMI(FHNHGOPNICC IFHPHKGDDHL, Allocator LEILKJFLDFN);

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool PPBFIKLHFGC(FHNHGOPNICC IFHPHKGDDHL);

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int ININDEPOBJG(FHNHGOPNICC IFHPHKGDDHL, int BBEJNKBNMID);
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[ServiceLifetime(Lifetime.Application)]
public interface ICPBLHMDHAL
{
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[ServiceLifetime(Lifetime.Application)]
public interface MFJFKMPFBNK
{
	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0xC8EC80", Offset = "0xC8D280", VA = "0x180C8EC80", Slot = "0")]
	bool COOFJEFBFLM(object NBGBHBICCPM, INFHIIKLKAN GEOGBHLBPCJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public static class GCFPMLANAML
{
	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x7681C20", Offset = "0x7680220", VA = "0x187681C20")]
	public static bool COOFJEFBFLM(this MFJFKMPFBNK GJJILEPKCHB, object NBGBHBICCPM, [Out] INFHIIKLKAN GEOGBHLBPCJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public enum KBPOEJBFJGA : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	MaxPlayers = byte.MaxValue,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	IsVisible = 254,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	IsOpen = 253,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	PlayerCount = 252,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	Removed = 251,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	PropsListedInLobby = 250,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	CleanupCacheOnLeave = 249,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	MasterClientId = 248,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	ExpectedUsers = 247,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	PlayerTtl = 246,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	EmptyRoomTtl = 245,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	HasDedicatedMaster = 87
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public interface INFHIIKLKAN
{
	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	EOLMHCHBNFD LNMDBHDAJAC
	{
		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	NOONNECLOAO LPPNANPKNMG
	{
		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	bool DAENMPDLMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	bool FBHGANLCLCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0xDC04F0", Offset = "0xDBEAF0", VA = "0x180DC04F0", Slot = "4")]
	(NOONNECLOAO, Dictionary<object, object>) EJDKLPAMBEC()
	{
		return default((NOONNECLOAO, Dictionary<object, object>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "5")]
	(GFBOHEINDFO, NOONNECLOAO) LEPJEGGCCDB()
	{
		return default((GFBOHEINDFO, NOONNECLOAO));
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "6")]
	DOCFNPLLADF<(GFBOHEINDFO, NOONNECLOAO)> IGOBHPECCIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "7")]
	DOCFNPLLADF<KPNNDKAJNNN> JEAHNONPNMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0xDC04F0", Offset = "0xDBEAF0", VA = "0x180DC04F0", Slot = "8")]
	(KMFPLICNEPB, byte[]) EEICCELIHFA()
	{
		return default((KMFPLICNEPB, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0xDC04F0", Offset = "0xDBEAF0", VA = "0x180DC04F0", Slot = "9")]
	(LLEIPKNCFLN, byte[]) BONCIBLHOJB()
	{
		return default((LLEIPKNCFLN, byte[]));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public static class JEOCJOJIMMH
{
	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x7685580", Offset = "0x7683B80", VA = "0x187685580")]
	public static bool OEMEKMLIJBO(this INFHIIKLKAN DMODBLGEPMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public interface KPNNDKAJNNN : DOCFNPLLADF<KJMMAOIEJBO>
{
	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	GFBOHEINDFO MKJAIBBHPJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[DefaultMember("Item")]
public interface DOCFNPLLADF<T>
{
	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	T NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E7")]
	int AFNDGLAJDJM
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public enum EOLMHCHBNFD : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	BulkInstantiate = 1,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	BulkDestroy = 2,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	EACMessage = 3,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	OMSendPacket = 4,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	RR_OutOfBandMessage = 5,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	RR_FastForwardMarker = 6,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	RR_SelfJoinMarker = 7,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	RR_DebugOp = 10,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	RR_CachedEvent = 11,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	RRRoomRequestEvent = 20,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	RRRoomRequestFailedResponseEvent = 21,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	RRBufferedRoomEvent = 22,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	RRClearBufferedRoomEvent = 23,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	RR_CreationOp = 24,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	RR_CreationOpResponse = 25,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	RR_CreationOp_Unchecked = 26,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	RPC = 200,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	SendSerialize = 201,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Instantiation = 202,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	CloseConnection = 203,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Destroy = 204,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	RemoveCachedRPCs = 205,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	SendSerializeReliable = 206,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	DestroyPlayer = 207,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	OwnershipRequest = 209,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	OwnershipTransfer = 210,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	VacantViewIds = 211,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	OwnershipUpdate = 212,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	AuthEvent = 223,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	LobbyStats = 224,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	AppStats = 226,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	Match = 227,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	QueueState = 228,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	GameListUpdate = 229,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	GameList = 230,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	CacheSliceChanged = 250,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	ErrorInfo = 251,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	PropertiesChanged = 253,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	Leave = 254,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	Join = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public enum KMFPLICNEPB : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	None = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	NetworkTransformInitializationData = 1314146628u,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	RestoreCreationData = 1380140064u,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	OldestCachedPacketId = 1329811529u,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	SnapshotPublished = 1397773634u,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	SnapshotPayload = 1397771332u,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	SnapshotClear = 1129337683u
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class JEJNHKEPJFJ
{
	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x7685540", Offset = "0x7683B40", VA = "0x187685540")]
	public static GFBOHEINDFO JHNGFDLIPPO(this ICKMJEODMIL GIDGOODJFLJ)
	{
		return default(GFBOHEINDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x7685270", Offset = "0x7683870", VA = "0x187685270")]
	public static GFBOHEINDFO DFJBEANFBGF([In] this ICKMJEODMIL GIDGOODJFLJ)
	{
		return default(GFBOHEINDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x76062D0", Offset = "0x76048D0", VA = "0x1876062D0")]
	public static GFBOHEINDFO IKEBAIGPGAG(this ICKMJEODMIL GIDGOODJFLJ)
	{
		return default(GFBOHEINDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x76062D0", Offset = "0x76048D0", VA = "0x1876062D0")]
	public static ViewId ODPMIILMMPA(this ICKMJEODMIL GIDGOODJFLJ)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x7685030", Offset = "0x7683630", VA = "0x187685030")]
	public static FixedString64Bytes CJIFDCFIPIK(this GOBCHKKNALB KGHCKLKGJKM)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x76852C0", Offset = "0x76838C0", VA = "0x1876852C0")]
	public static FixedString64Bytes DIKCCMPGBKH(this GFBOHEINDFO KGHCKLKGJKM)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x76851E0", Offset = "0x76837E0", VA = "0x1876851E0")]
	public static FixedString32Bytes CJIFDCFIPIK(this Entity FCJGDHPNMHF)
	{
		return default(FixedString32Bytes);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AGBJPOCNANP : KBNMBGAIHKJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public enum OFNEBLEFLGM
{
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	End,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BJKOFCICCMA
{
	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event Action<object> CBHDNELMOAP;

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "2")]
	void IIAIEENGJEB(object NBGBHBICCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "3")]
	void MMIKADAFEKB(LLEIPKNCFLN MBDLAJMBAIN, ReadOnlySpan<byte> GOAPBALNOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "4")]
	void KAMHPIPKANC(KMFPLICNEPB BMIPLDLMPCD, ReadOnlySpan<byte> GOAPBALNOKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BOPDGHJPNON
{
	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LLEIPKNCFLN CBJHNBJOEFE(ReadOnlySpan<byte> GOAPBALNOKD);
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MEHFGDFMLNC
{
	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MOIFJPCLECM(LLEIPKNCFLN LKMGECEEGEE, ReadOnlySpan<byte> GOAPBALNOKD);

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOGJGGFIACJ(ReadOnlySpan<LLEIPKNCFLN> OLPNLNLFAOC);
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public struct PBOMDEKIEML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public LLEIPKNCFLN MBDLAJMBAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public ReadOnlyMemory<byte> GOAPBALNOKD;
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public struct LLEIPKNCFLN
{
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static LLEIPKNCFLN BOCKGNJBMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public GOBCHKKNALB ANNFGFFKKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public int PJHGAKALHBP;

	[Cpp2IlInjected.Token(Token = "0x170001E8")]
	public static GOBCHKKNALB FHBPBEFMHCH
	{
		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x7689740", Offset = "0x7687D40", VA = "0x187689740")]
		get
		{
			return default(GOBCHKKNALB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x4B9DF60", Offset = "0x4B9C560", VA = "0x184B9DF60")]
	public LLEIPKNCFLN(GOBCHKKNALB ANNFGFFKKNA, int PJHGAKALHBP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x7689530", Offset = "0x7687B30", VA = "0x187689530")]
	public static bool BFIJCNNIIMH([In] LLEIPKNCFLN CLHNCHKFPON, [In] LLEIPKNCFLN KMNANLEEDKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x76895C0", Offset = "0x7687BC0", VA = "0x1876895C0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x76896D0", Offset = "0x7687CD0", VA = "0x1876896D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x7689790", Offset = "0x7687D90", VA = "0x187689790", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x7689730", Offset = "0x7687D30", VA = "0x187689730")]
	public void JNMBAPLKJHM([Out] GOBCHKKNALB JPPHMPLKKOL, [Out] int PJHGAKALHBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class LMFCNALNGNK
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public struct BGEHNHONEMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public Guid JINNLDEOCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public string HEEFCLHHCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public Vector3 NDADPNJPMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public Quaternion MLMNPOCKAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public Vector3 JJCKONKIIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public int JCLDOFKJGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public DPGADNNJFDK FJJOKDBOKAE;

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x767E950", Offset = "0x767CF50", VA = "0x18767E950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public enum GPNIMJCLHOP
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Scene,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	SubgraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	SubgraphRestore,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	RestoreCreationData,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	InventionPreview
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public static class MCMEAEHPGJI
{
	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x768AB50", Offset = "0x7689150", VA = "0x18768AB50")]
	public static bool GMAFFHFCCPJ(this GPNIMJCLHOP BMIPLDLMPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x768AB70", Offset = "0x7689170", VA = "0x18768AB70")]
	public static bool LLKMICBJGOD(this GPNIMJCLHOP BMIPLDLMPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x768AB40", Offset = "0x7689140", VA = "0x18768AB40")]
	public static bool CJNENFOHBAH(this GPNIMJCLHOP BMIPLDLMPCD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[Flags]
public enum GCNEPOCPPLM
{
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	WorldPhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	AdditivePhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public interface KEFHNHHELAB
{
	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BEHHBGGAONF([In] Guid MOEBIEOOLFC, [Out] Guid JEFFDGNDMGE);
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
[Flags]
public enum IAOPAGCIIDP
{
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public interface AOCPMMFELLJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001E9")]
	MLNIHIMLLFL HJPLCBJGDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString ONBNGOIINKF();
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public enum FAKPHEMACOF
{
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	World,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public struct FBHJCBGINJI : ISystemStateComponentData, IComponentData, IEquatable<FBHJCBGINJI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public float3 MJPJCMEJEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public float3 NODBNBNHGPA;

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x76809B0", Offset = "0x767EFB0", VA = "0x1876809B0", Slot = "4")]
	public bool Equals(FBHJCBGINJI OKCHLIEAIJP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NEOJCDJPKOA
{
	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GMFDJFBCNEF(long NLOEKCPDMHG);

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKPDGKFMGFC(NativeParallelHashSet<long> LJCPDBIBBGE);

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NJNIEOPNEOL(World ENFBJMHAMNL, NativeParallelHashMap<Guid, long> EDMOECAGMMB);

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NGADDJNKCOB(GFBOHEINDFO OJGFMNKCCFJ);

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GDLFHLGKCNF(GFBOHEINDFO OJGFMNKCCFJ, [Out] Guid GBFELLGGLFE, [Out] long NLOEKCPDMHG);

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EFADOAGKEDB(GFBOHEINDFO OJGFMNKCCFJ, Guid GBFELLGGLFE, long NLOEKCPDMHG);

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DAGOCMBBMEJ(Guid GBFELLGGLFE);

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OCGJPDHIOBA(Guid GBFELLGGLFE, [Out] int NAALFHOIKAO, [Out] int NPDMAEEHIDD);

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IAAHGOGHMLK(Guid GBFELLGGLFE, int NAALFHOIKAO, int NPDMAEEHIDD);

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ACEAGEBHIJF(Guid GBFELLGGLFE);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public class OKEBKGOCPLK
{
	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public OKEBKGOCPLK()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
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
