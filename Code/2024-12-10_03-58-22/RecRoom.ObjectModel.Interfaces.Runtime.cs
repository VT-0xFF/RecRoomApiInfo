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
	public class LogRegistrationIndex : IGKFPLMKJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6D93CB0", Offset = "0x6D928B0", VA = "0x186D93CB0", Slot = "4")]
		public override void PEGPHNFMEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GELIPJICGBO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6D8BC60", Offset = "0x6D8A860", VA = "0x186D8BC60")]
	public static void ECFJAIBGPIO(this Rigidbody IEBPINDGGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6D8BB30", Offset = "0x6D8A730", VA = "0x186D8BB30")]
	public static void ECFJAIBGPIO(this Rigidbody IEBPINDGGHA, Vector3 MKPBELLAFPD, Quaternion HFEAOFBGEKL, Vector3 IAGIACGHBGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct DBLPDLFFIKD : IReadOnlyList<JBKDGFJKCIL>, IEnumerable<JBKDGFJKCIL>, IEnumerable, IReadOnlyCollection<JBKDGFJKCIL>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct FNBPAMMBELK : IEnumerator<JBKDGFJKCIL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly OIMOBMEJAIF KKIIGPHCOLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator LLKKIBMDGDK;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public JBKDGFJKCIL FFEGLPIJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6D8B3A0", Offset = "0x6D89FA0", VA = "0x186D8B3A0", Slot = "4")]
			get
			{
				return default(JBKDGFJKCIL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6D8B320", Offset = "0x6D89F20", VA = "0x186D8B320", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x435BC70", Offset = "0x435A870", VA = "0x18435BC70")]
		public FNBPAMMBELK(OIMOBMEJAIF KKIIGPHCOLG, NativeArray<LocalId>.Enumerator LLKKIBMDGDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6D8B260", Offset = "0x6D89E60", VA = "0x186D8B260", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6D8B2A0", Offset = "0x6D89EA0", VA = "0x186D8B2A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6D8B2E0", Offset = "0x6D89EE0", VA = "0x186D8B2E0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly OIMOBMEJAIF KKIIGPHCOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> CNEBDANMKHA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public JBKDGFJKCIL CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A000", Offset = "0x6D88C00", VA = "0x186D8A000", Slot = "4")]
		get
		{
			return default(JBKDGFJKCIL);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D89AB0", Offset = "0x6D886B0", VA = "0x186D89AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int OGAJAKBBADJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8871A0", Offset = "0x885DA0", VA = "0x1808871A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public OIMOBMEJAIF ONJJENNLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int LDFIBCLBPPF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8871A0", Offset = "0x885DA0", VA = "0x1808871A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool JJKFDCCDGME
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6D899C0", Offset = "0x6D885C0", VA = "0x186D899C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> MKBKDOGPHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2746BA0", Offset = "0x27457A0", VA = "0x182746BA0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> KEPAADKODBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6D89B00", Offset = "0x6D88700", VA = "0x186D89B00")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D89EC0", Offset = "0x6D88AC0", VA = "0x186D89EC0")]
	public DBLPDLFFIKD(int KPFLHEHNDFJ, OIMOBMEJAIF KKIIGPHCOLG, Allocator ICLGONBNBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x435B9B0", Offset = "0x435A5B0", VA = "0x18435B9B0")]
	public DBLPDLFFIKD(OIMOBMEJAIF KKIIGPHCOLG, NativeArray<LocalId> CNEBDANMKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6D89E50", Offset = "0x6D88A50", VA = "0x186D89E50")]
	internal DBLPDLFFIKD(OIMOBMEJAIF KKIIGPHCOLG, NativeArray<Entity> BHNJCFOPBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6D89DB0", Offset = "0x6D889B0", VA = "0x186D89DB0")]
	public DBLPDLFFIKD(OIMOBMEJAIF KKIIGPHCOLG, int OLBMNABBGHI, Allocator ICLGONBNBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6D89F50", Offset = "0x6D88B50", VA = "0x186D89F50")]
	public DBLPDLFFIKD(DBLPDLFFIKD FOOBNDEBOIA, Allocator ICLGONBNBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6D89A00", Offset = "0x6D88600", VA = "0x186D89A00")]
	public DBLPDLFFIKD GBKEAFBIGGC(Allocator ICLGONBNBJO = Allocator.Temp)
	{
		return default(DBLPDLFFIKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6D89980", Offset = "0x6D88580", VA = "0x186D89980", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6D89B60", Offset = "0x6D88760", VA = "0x186D89B60")]
	public FNBPAMMBELK NEGBLLIJCNA()
	{
		return default(FNBPAMMBELK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6D89BF0", Offset = "0x6D887F0", VA = "0x186D89BF0", Slot = "6")]
	private IEnumerator<JBKDGFJKCIL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6D89CD0", Offset = "0x6D888D0", VA = "0x186D89CD0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public struct NOHIPCMMGAJ : IList<JBKDGFJKCIL>, ICollection<JBKDGFJKCIL>, IEnumerable<JBKDGFJKCIL>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct CBIOPKHNAIK : IEnumerator<JBKDGFJKCIL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly OIMOBMEJAIF KKIIGPHCOLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator LLKKIBMDGDK;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public JBKDGFJKCIL FFEGLPIJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6D88140", Offset = "0x6D86D40", VA = "0x186D88140", Slot = "4")]
			get
			{
				return default(JBKDGFJKCIL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6D880C0", Offset = "0x6D86CC0", VA = "0x186D880C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x435BC70", Offset = "0x435A870", VA = "0x18435BC70")]
		public CBIOPKHNAIK(OIMOBMEJAIF KKIIGPHCOLG, NativeArray<LocalId>.Enumerator LLKKIBMDGDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6D88000", Offset = "0x6D86C00", VA = "0x186D88000", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6D88040", Offset = "0x6D86C40", VA = "0x186D88040", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6D88080", Offset = "0x6D86C80", VA = "0x186D88080", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly OIMOBMEJAIF KKIIGPHCOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> CNEBDANMKHA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public JBKDGFJKCIL CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6D97140", Offset = "0x6D95D40", VA = "0x186D97140", Slot = "4")]
		get
		{
			return default(JBKDGFJKCIL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6D971C0", Offset = "0x6D95DC0", VA = "0x186D971C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6D96A30", Offset = "0x6D95630", VA = "0x186D96A30", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int LDFIBCLBPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6D96A30", Offset = "0x6D95630", VA = "0x186D96A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> MKBKDOGPHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2746BA0", Offset = "0x27457A0", VA = "0x182746BA0")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool POMDFADBODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6D97030", Offset = "0x6D95C30", VA = "0x186D97030")]
	public NOHIPCMMGAJ(int KPFLHEHNDFJ, OIMOBMEJAIF KKIIGPHCOLG, Allocator ICLGONBNBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6D970C0", Offset = "0x6D95CC0", VA = "0x186D970C0")]
	public NOHIPCMMGAJ(OIMOBMEJAIF KKIIGPHCOLG, Allocator ICLGONBNBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6D96FA0", Offset = "0x6D95BA0", VA = "0x186D96FA0")]
	public NOHIPCMMGAJ(OIMOBMEJAIF KKIIGPHCOLG, int OLBMNABBGHI, Allocator ICLGONBNBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6D96BB0", Offset = "0x6D957B0", VA = "0x186D96BB0")]
	public DBLPDLFFIKD KMMBCDOJKEP()
	{
		return default(DBLPDLFFIKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6D967D0", Offset = "0x6D953D0", VA = "0x186D967D0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6D96810", Offset = "0x6D95410", VA = "0x186D96810", Slot = "13")]
	public bool Contains(JBKDGFJKCIL ANPIFEPGOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6D968A0", Offset = "0x6D954A0", VA = "0x186D968A0", Slot = "14")]
	public void CopyTo(JBKDGFJKCIL[] BFDOCKABCPN, int GAPDNNJAGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6D96750", Offset = "0x6D95350", VA = "0x186D96750", Slot = "11")]
	public void Add(JBKDGFJKCIL ANPIFEPGOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D96B00", Offset = "0x6D95700", VA = "0x186D96B00", Slot = "7")]
	public void Insert(int MFJLAMOCOBC, JBKDGFJKCIL ANPIFEPGOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6D96D10", Offset = "0x6D95910", VA = "0x186D96D10", Slot = "15")]
	public bool Remove(JBKDGFJKCIL ANPIFEPGOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6D96A70", Offset = "0x6D95670", VA = "0x186D96A70", Slot = "6")]
	public int IndexOf(JBKDGFJKCIL ANPIFEPGOLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6D96CC0", Offset = "0x6D958C0", VA = "0x186D96CC0", Slot = "8")]
	public void RemoveAt(int MFJLAMOCOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6D969F0", Offset = "0x6D955F0", VA = "0x186D969F0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6D96C30", Offset = "0x6D95830", VA = "0x186D96C30")]
	public CBIOPKHNAIK NEGBLLIJCNA()
	{
		return default(CBIOPKHNAIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6D96DE0", Offset = "0x6D959E0", VA = "0x186D96DE0", Slot = "16")]
	private IEnumerator<JBKDGFJKCIL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6D96EC0", Offset = "0x6D95AC0", VA = "0x186D96EC0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface MDIAMGADBAO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int AMLFEMGMFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> IOJAEDGOJLG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JBKDGFJKCIL BDDDFNCEDAN(JBKDGFJKCIL CNEBDANMKHA);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CBJPDBIMFBL : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[ServiceLifetime(Lifetime.Application)]
public interface GHGPFBJIDLM : JMBCAHDNGEB, OEHHMGGELGC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool LNEBBFIJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	KEDKLEKLGOF FIFJKNCFLEG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	HOFFOBHIPEP JGAJCHLELFD
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	CACJPJLNOFJ HIJGPDHINAE
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	MNGLAGDKHKA GPOEMAPMJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface OEHHMGGELGC
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool ONEKHMHADID
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface ANBOHFPECAH
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGCBKBNPDDF(bool CABLCDOIFFL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface GPDMHNGJPPF
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool DELPNMFFJBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBKLLOICOKO(bool DHKFDKHEAMG);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMNIFNPMAKJ();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KLMNMHFCHHA(ByteString JOFDKJOIAEP);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KBHHIKKMKKG();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LKHKOACHNEO();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NAOABLLAPLB();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EPPFHNKCAIN();

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FAMGGCPFPAG();

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KNHCCNOOIKD();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.Application)]
public interface CACJPJLNOFJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	JHKOPLPKGAC FIFJKNCFLEG
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	HOFFOBHIPEP JGAJCHLELFD
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	BIOJOMCAEIE GFOAIEOFDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	MHFEHKCMKNI MLNOJFILHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	GHGPFBJIDLM ABKDCPOPODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	GPDMHNGJPPF FFAJLPLOIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	OIMOBMEJAIF ONJJENNLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	PGJHHNGEJGI APFJABBJNFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DNJBJGGECOC LOMFAGFONCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	MFDDCONEMEL HHJCNGJGNFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	MEKDCHGJIAK NEGEIJNBJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	EMKCMJJEJCB PPEHDBOGMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	JELPHIIIAHJ AJEIHAEODHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	GKOGPPBOBDA MGKFDJAKHMM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	CCJEHMLGOEJ BJKGDIMBAGB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	EHGFHKEMKPG MGEGPOAGLJP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	JDDAFONGDAI KPLKGJNKPKN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	BFNGOOHGMMN MLOKBPPHBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	IIONMFDLBIG CKMHEEFMAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	GOIOHFDKAFM IADOHEEMFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	MFJEFENKHHN BNFEKPHBDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	EHAMHHHNAID JPOKNDIPPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	AOHHHJIMCMA NFIDANJAMHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	CGBHCCJLCEB JIFKJMHLDJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	DOFMNPCIHHG PIJJJGJNHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	DGJINFKHOMH CECFGKOCJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	MJJJDBAHEPH HKBMJNPFJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	AGPHIEAKDAJ NFPJNPKBIEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	NIKBMHJNLNF JLMNNAJMKAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	DADPHLLPINM NIJIMINCEEO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DebuggerTypeProxy(typeof(NDEEHEFAONN))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct JBKDGFJKCIL : IComparable<JBKDGFJKCIL>, IEquatable<JBKDGFJKCIL>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly JBKDGFJKCIL LPNKNEBEAHM;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int BHHKDPPAGDA = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int GDDENPHFGAF = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int DEAEKPOEGBJ = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int KOPBMCAOBDB = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId DKAIINNEBFL;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public OIMOBMEJAIF ONJJENNLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6D86030", Offset = "0x6D84C30", VA = "0x186D86030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public GHGPFBJIDLM ABKDCPOPODA
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6D90970", Offset = "0x6D8F570", VA = "0x186D90970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public LocalId AOGHKJPOHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6D90930", Offset = "0x6D8F530", VA = "0x186D90930")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	internal MNGLAGDKHKA GPOEMAPMJIC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6D90AF0", Offset = "0x6D8F6F0", VA = "0x186D90AF0")]
		get
		{
			return default(MNGLAGDKHKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool AMOCDEJOLHN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6D904C0", Offset = "0x6D8F0C0", VA = "0x186D904C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private bool FENDOBGGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6D908E0", Offset = "0x6D8F4E0", VA = "0x186D908E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6D90C30", Offset = "0x6D8F830", VA = "0x186D90C30")]
	public JBKDGFJKCIL(OIMOBMEJAIF KFNKMPEOPJE, LocalId DKAIINNEBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
	public BDGGMOHGNEL FLOLFKPADNL()
	{
		return default(BDGGMOHGNEL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6D908A0", Offset = "0x6D8F4A0", VA = "0x186D908A0")]
	public static LocalId FGDKAMMLLCN(JBKDGFJKCIL CCLNOOPAMLD)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6D90860", Offset = "0x6D8F460", VA = "0x186D90860")]
	public static Entity FGDKAMMLLCN(JBKDGFJKCIL CCLNOOPAMLD)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6D909D0", Offset = "0x6D8F5D0", VA = "0x186D909D0")]
	public static bool PCHFOHOKDFG(JBKDGFJKCIL ALHLFNOAFIL, JBKDGFJKCIL AFHCIMLJCHF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6D86DB0", Offset = "0x6D859B0", VA = "0x186D86DB0")]
	public static bool GBEMIEIJNBP(JBKDGFJKCIL ALHLFNOAFIL, JBKDGFJKCIL AFHCIMLJCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6D90B00", Offset = "0x6D8F700", VA = "0x186D90B00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6D906D0", Offset = "0x6D8F2D0", VA = "0x186D906D0", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6D905E0", Offset = "0x6D8F1E0", VA = "0x186D905E0", Slot = "4")]
	public int CompareTo(JBKDGFJKCIL FDOEIPBMJJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "5")]
	public bool Equals(JBKDGFJKCIL FDOEIPBMJJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NOHBJJMMHPO
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6D965F0", Offset = "0x6D951F0", VA = "0x186D965F0")]
	public static IOBDJLAADBM BGFFGNINDHK(this JBKDGFJKCIL PLAMADMDGIO)
	{
		return default(IOBDJLAADBM);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6D966A0", Offset = "0x6D952A0", VA = "0x186D966A0")]
	public static BDGGMOHGNEL CEPADAGMGPF(this JBKDGFJKCIL PLAMADMDGIO)
	{
		return default(BDGGMOHGNEL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class NDEEHEFAONN
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct MNGLAGDKHKA : IEquatable<MNGLAGDKHKA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte JBFBMCPGKHE;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] BKJFMIDIDBM;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static OIMOBMEJAIF PJKJBAENFGD;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static GHGPFBJIDLM CPJBAFHKNOD;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static OIMOBMEJAIF[] AEFLKLIIGON;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static GHGPFBJIDLM[] FFKEMEKENGD;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> PLPMIJDHJBN;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public GHGPFBJIDLM ABKDCPOPODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6D950E0", Offset = "0x6D93CE0", VA = "0x186D950E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public OIMOBMEJAIF OFJDEPFNNDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6D94F50", Offset = "0x6D93B50", VA = "0x186D94F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6D95520", Offset = "0x6D94120", VA = "0x186D95520")]
	static MNGLAGDKHKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2324190", Offset = "0x2322D90", VA = "0x182324190")]
	internal MNGLAGDKHKA(byte CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5E48540", Offset = "0x5E47140", VA = "0x185E48540", Slot = "4")]
	public bool Equals(MNGLAGDKHKA FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6D948B0", Offset = "0x6D934B0", VA = "0x186D948B0", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x919930", Offset = "0x918530", VA = "0x180919930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6D95460", Offset = "0x6D94060", VA = "0x186D95460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6D94950", Offset = "0x6D93550", VA = "0x186D94950")]
	private static OIMOBMEJAIF FDFKELOMBIP(byte JBFBMCPGKHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6D95030", Offset = "0x6D93C30", VA = "0x186D95030")]
	private static GHGPFBJIDLM OCAKIHDJNOK(byte JBFBMCPGKHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6D94DE0", Offset = "0x6D939E0", VA = "0x186D94DE0")]
	private static object KAJFEKMIKLC(byte JBFBMCPGKHE, object[] ILAABJMNJPL, object IEDAFAANJNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6D94D50", Offset = "0x6D93950", VA = "0x186D94D50")]
	private static int HJIAJNBNDJB(byte JBFBMCPGKHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6D94F40", Offset = "0x6D93B40", VA = "0x186D94F40")]
	private static int KDPGOGJKFPF(byte JBFBMCPGKHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6D94D60", Offset = "0x6D93960", VA = "0x186D94D60")]
	private static (int, int) JABOFGAGNJG(byte JBFBMCPGKHE)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6D950D0", Offset = "0x6D93CD0", VA = "0x186D950D0")]
	private static byte OEGBMKPIALG(int OGMJKGKJANG, int MFJLAMOCOBC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6D951C0", Offset = "0x6D93DC0", VA = "0x186D951C0")]
	internal static MNGLAGDKHKA PEGPHNFMEDB(GHGPFBJIDLM FNKLNABHFCF, OIMOBMEJAIF HJOCKDGCNDP)
	{
		return default(MNGLAGDKHKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6D946C0", Offset = "0x6D932C0", VA = "0x186D946C0")]
	internal static void ACKIONKPNNI(MNGLAGDKHKA JBFBMCPGKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6D949F0", Offset = "0x6D935F0", VA = "0x186D949F0")]
	private static void FLDPJIKDKKP(int KPFLHEHNDFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface KHJNFPLABDF
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ENFGGGOFDOO();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IMDHCPOBCPE(bool FIHKMONIOIN);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DCFHFPCOGAN(GameObject DKOODDCANLH);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[ServiceLifetime(Lifetime.Application)]
public interface LKKAEMHNGJO
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Guid IIKADJIPLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GHLIPMKJBAN(Guid NPNCGDOKAPJ, Guid KPGLKHEJBED, Guid CCPOEHICJHE);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task ECJPLCDGBED(Guid NPNCGDOKAPJ, Guid[] ICJIJKPKEBP, Guid CCPOEHICJHE);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid IGPJCJDOCGE(Guid JHHAGEEOAEN);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task HCBBDGFBOON(JBKDGFJKCIL PLDLILNBIII);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HALMLKKANKM(FNNOGNIONBO PFEAECKGKMH, Guid CMFKIMEBKAB);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KPAOEPECNBJ(Guid JHHAGEEOAEN, bool DHKFDKHEAMG);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[ServiceLifetime(Lifetime.Application)]
public interface FNKJONIKKCD
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void APCKEGINAKG(DBLPDLFFIKD CNEBDANMKHA);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[ServiceLifetime(Lifetime.Application)]
public interface FKKFIEAKFGD
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LMNPODPAEMK(GameObject LBFBDLGOEFM, GameObject EGJININKFDP, int NNHFLNLJLGN);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[ServiceLifetime(Lifetime.Application)]
public interface HOFFOBHIPEP
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	KHJNFPLABDF DKBILIOFIHA
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	GEMBAHOBFOO AHPPAJLNPNO
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	PIHOIAECOGK PCJMLGIOEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	PHDKKBBDFGI AOAIFEKKGOC
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	CCHEAIIFFFP LKICOCPFHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	BPAFOHKCNDB OBNOKJEKOKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	CGIOMIPHEID BAFPEICMCGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	EAPPCPJHOKO FHLCFPHFBIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	MNHLJABDIBK EHPCNKEJALA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	INOJLNLAEOL IPLAJEGHOBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	FJPPJDGOKEA PDFPDAMKANN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[ServiceLifetime(Lifetime.Application)]
public interface GEMBAHOBFOO
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string DBIPIFMGNBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[ServiceLifetime(Lifetime.Application)]
public interface OFAJDIMMDDD
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CDGDBMGHGBI(Action FNGNLBJEBKM, bool FANPEFONGHD);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OJIPPGLLCHD(string GMBAACDNNFI);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int GGKFJHLJPCF(string GMBAACDNNFI, int IEDAFAANJNE);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DCBPNMKBCKF([Out] bool CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DCJECAPCCEE([Out] bool CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CGMEAPMFHJL([Out] int CABLCDOIFFL);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface PIHOIAECOGK
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	string LLHBHCLKJME
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] INIEGGAMMCK(IEnumerable<MKHKHPCLLCD> HODPFMBLMAN, bool PNLJELDLIBK);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ELJNIKCICIB(GameObject DKOODDCANLH, [Out] IOBDJLAADBM[] OCOGHNMIAAF);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IEFLADGCEAI(GameObject DKOODDCANLH, [Out] int PFCHFMHBCBF, [Out] EKPAFNPHKFE LMKPBPFJEKM);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FNNOGNIONBO CIBFNDBFKFG(MKHKHPCLLCD IBNNNHFPFBF);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FNNOGNIONBO CIBFNDBFKFG(string MFPCKNHBBHM, IOBDJLAADBM[] HNOPHCFBENC, Vector3 GKJAMFFKDLE, Quaternion EAGKGJHHIJH, Vector3 IMPGFCOPLND);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FNNOGNIONBO GDGEFBPPCBJ(string MFPCKNHBBHM, IOBDJLAADBM[] HNOPHCFBENC, Vector3 GKJAMFFKDLE, Quaternion EAGKGJHHIJH, Vector3 IMPGFCOPLND);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject LLEGPJEOPIA(string MFPCKNHBBHM);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OKMLMEDJIIF(GameObject FFGMFNBEGHA, bool ACJNCMDHMAI);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IMOLNGGNNEK(GameObject DKOODDCANLH, bool NELJGLHGOBE, bool MHKMJEMAPKO);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class KANIDGBHEJH
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6D93670", Offset = "0x6D92270", VA = "0x186D93670")]
	public static FNNOGNIONBO CIBFNDBFKFG(this PIHOIAECOGK CPKOIOKIGEH, Vector3 GKJAMFFKDLE, Quaternion EAGKGJHHIJH, Vector3 IMPGFCOPLND, params IOBDJLAADBM[] OCOGHNMIAAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6D937E0", Offset = "0x6D923E0", VA = "0x186D937E0")]
	public static FNNOGNIONBO GDGEFBPPCBJ(this PIHOIAECOGK CPKOIOKIGEH, Vector3 GKJAMFFKDLE, Quaternion EAGKGJHHIJH, Vector3 IMPGFCOPLND, params IOBDJLAADBM[] OCOGHNMIAAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[ServiceLifetime(Lifetime.Application)]
public interface PHDKKBBDFGI
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CHFBAAKJDHP(bool DHKFDKHEAMG);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[ServiceLifetime(Lifetime.Application)]
public interface CCHEAIIFFFP
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool JBKKAAFGPEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool LPBCKNAKDMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool IPCCNKPHMKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	int DJGNCAKEGKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool IEPLNCNMDOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HDHPKGBGGHD(object NCPEFDMEFEF);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CNGJOJNLBHD(object NCPEFDMEFEF);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PPLDGNFGIMN(object CGJNNJHBPPG);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LOOOHJGENFF(object CGJNNJHBPPG);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ViewId JPKBOGMPBJC(GameObject INBNPDODNMN);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KCLOMNLMAHP(NativeArray<ViewId> MMOBFKKHNNA);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MHPKKDMBIIM(NativeArray<ViewId> POHJEOOMENL);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KCOFFPKEPGO();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GCALGJAGJPE(uint IMENBELMNLO, ReadOnlySpan<byte> CLKILKCOPOD, bool MMPBIEIKGDG = false);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GCALGJAGJPE(uint IMENBELMNLO, ReadOnlySpan<byte> CLKILKCOPOD, ReadOnlySpan<byte> FGGFPLCHJLE, bool MMPBIEIKGDG = false);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PLJHICHEDGL(Func<int, bool, int> JKGFMOKIPMI, bool GAJNCNIPNHB);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KABDNOIJJPD(object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OBGMJHEKCJF(object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "18")]
	uint IJEHOGCOOJG(uint KFNONDACKPN);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class CNOICHCLEPI
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6D895D0", Offset = "0x6D881D0", VA = "0x186D895D0")]
	public static MGMFKGOOIKK HMHKJCFDNOD(this CCHEAIIFFFP PIAKONPJLMJ, object DGGGDIFONNG)
	{
		return default(MGMFKGOOIKK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct MGMFKGOOIKK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CCHEAIIFFFP PIAKONPJLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private object DGGGDIFONNG;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6D94040", Offset = "0x6D92C40", VA = "0x186D94040")]
	public MGMFKGOOIKK(CCHEAIIFFFP PIAKONPJLMJ, object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6D93FF0", Offset = "0x6D92BF0", VA = "0x186D93FF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface BPAFOHKCNDB
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHDPCOPNCMP(GameObject DKOODDCANLH);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface CGIOMIPHEID
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public struct LDPHNLHFEEF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private CGIOMIPHEID HFJLKAOEMJE;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6D93C30", Offset = "0x6D92830", VA = "0x186D93C30")]
		public LDPHNLHFEEF(CGIOMIPHEID HFJLKAOEMJE, string LFKIGNHCOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6D93BD0", Offset = "0x6D927D0", VA = "0x186D93BD0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct CLGMPHBNJDE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private CGIOMIPHEID HFJLKAOEMJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Task NEEKHCPCAAC;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6D89580", Offset = "0x6D88180", VA = "0x186D89580", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PMAILHNAAGM(string LFKIGNHCOID, float CPOOPJBHGMD = 5f);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EJIMJDAMKJO();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IOLINIEFIJL(bool KADHLHDKJJP, string LFKIGNHCOID);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class BGNFPJLJHDC
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6D87D60", Offset = "0x6D86960", VA = "0x186D87D60")]
	public static CGIOMIPHEID.LDPHNLHFEEF OCHFGNFELKF(this CGIOMIPHEID PIAKONPJLMJ, string LFKIGNHCOID)
	{
		return default(CGIOMIPHEID.LDPHNLHFEEF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface IPFFDAJGCCJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GGLDGHJDADA(GameObject DKOODDCANLH);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FEABJODCJLG(GameObject DKOODDCANLH);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KEANDBBKPCL(int CAACCCMGHHA);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object LEOIJNMNFKJ(JBKDGFJKCIL DKAIINNEBFL, GameObject DKOODDCANLH, Action<JBKDGFJKCIL, int> NNGDIBHFMBF);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CCDAKIKBNJH(GameObject DKOODDCANLH, object LBKLLENCLDM);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface LDLIDCPNHAI
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool AFHMDPBDDLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate OCEPFLMJFFM(BJGDJCDHJPM.PPGBLIKHCOG DJHGHKKHHGC, Action<BJGDJCDHJPM.PPGBLIKHCOG> NNGDIBHFMBF);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PACGJNGKINK(BJGDJCDHJPM.PPGBLIKHCOG DJHGHKKHHGC, Delegate NNGDIBHFMBF);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate MPFKPNBLCML(BJGDJCDHJPM.PPGBLIKHCOG DJHGHKKHHGC, Action<BJGDJCDHJPM.PPGBLIKHCOG> EMAPLPPCIPI);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LLNLFLKHLDH(BJGDJCDHJPM.PPGBLIKHCOG DJHGHKKHHGC, Delegate NNGDIBHFMBF);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AIPMNIELNMO(BJGDJCDHJPM.PPGBLIKHCOG DJHGHKKHHGC);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BJGDJCDHJPM.PPGBLIKHCOG FAALDPKCOJD(GameObject DKOODDCANLH);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface EAPPCPJHOKO
{
	[Cpp2IlInjected.Token(Token = "0x17000054")]
	int GNLMHKAEMII
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	int KEKONPBENOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool LPBCKNAKDMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool HFOPJIEFGMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int GLEGDCEMLCD(GameObject DKOODDCANLH);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MGPCNMLKBBI([Out] Vector3 GKJAMFFKDLE);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FNDDIHLPCIC();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JBKDGFJKCIL GJEFNLOIBPB(int CAACCCMGHHA);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OPPMLGOKMKN();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[ServiceLifetime(Lifetime.Application)]
public interface MNHLJABDIBK
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool DELPNMFFJBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[ServiceLifetime(Lifetime.Application)]
public interface INOJLNLAEOL
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	LONHKCPEDHN PHEGFAEEAGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	IFIADOEPHCD DCBGKAOFDFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PMPHBCLPJOO(Transform OHCKGBMFMEE);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HHNJDGCLCCA(Transform OHCKGBMFMEE, ODMGODNGJGC JAPNFNJMCEF);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OJLOHNKLGEP(Transform OHCKGBMFMEE, BLNKBACJIBE PBAGHGLELNF);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KFIJGMJIBEA();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IDIFDBNEOEG();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[ServiceLifetime(Lifetime.Application)]
public interface AMFOGNAFIBO
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[ServiceLifetime(Lifetime.Application)]
public interface FJPPJDGOKEA
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action ONPGLMEEPPH;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PANDAIODJFA(DBLPDLFFIKD OCMDDGHEMHD, bool KADHLHDKJJP);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[ServiceLifetime(Lifetime.Application)]
public interface JPCHNEFHFEF
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HPEBJGDEHJL();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ServiceLifetime(Lifetime.Application)]
public interface MALIHJLGEHF
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EKPAFNPHKFE CGDAHOEKLJA(GameObject INBNPDODNMN);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LOGCFBBOGIL(GameObject DKOODDCANLH, IDFJCJHJMNO CCNCKFFIDPG, HGPGHDAEOFM PCOGAHEKAMJ);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FFFMOCCPJEA(JBKDGFJKCIL DKAIINNEBFL, bool PKKONIACAEO, float3 AOBKFBGHGDJ, quaternion EOCFPFGJOBM);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HEDCPHNNIKI(BDGGMOHGNEL LCMKGCMMEHM, BDGGMOHGNEL CGJNNJHBPPG, AFHJIGHFEFH CHCPEAEKFEB);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OELLNHLKAOA(BDGGMOHGNEL LCMKGCMMEHM, AFHJIGHFEFH CHCPEAEKFEB);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EACKLJOLDGH(DBLPDLFFIKD OELIIFKFHNF);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NPOCKEDALFH(DBLPDLFFIKD KKIIGPHCOLG, NativeArray<LocalPoseData> FHNLEHFOHKK, NativeArray<float3> EGLBBFLGAJM);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BFMMDHCABPL(DBLPDLFFIKD KKIIGPHCOLG, DBLPDLFFIKD LLHGNDFGELM);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JJMMCJACHIE(DBLPDLFFIKD KKIIGPHCOLG, bool KMMJNDIPFFF);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CJGMDDBGFLI(DBLPDLFFIKD KKIIGPHCOLG, bool HDLFINBJMHG);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct FONNKDIPMKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly EDAHOAALEMC GMEOEMGBEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly EDAHOAALEMC DAKCGLGCCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint ACEHFOMDKNH;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6D8B3F0", Offset = "0x6D89FF0", VA = "0x186D8B3F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct ABJFGENMJHG
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal readonly FONNKDIPMKN FNGNLBJEBKM;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6D85E30", Offset = "0x6D84A30", VA = "0x186D85E30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct ONILMCHADDD
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal readonly FONNKDIPMKN FNGNLBJEBKM;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6D85E30", Offset = "0x6D84A30", VA = "0x186D85E30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct LDIENHAHPAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal readonly uint ACEHFOMDKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal readonly bool OEGGJGNJIKI;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6D93B30", Offset = "0x6D92730", VA = "0x186D93B30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct EDAHOAALEMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal int APMEPKJBNGD;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6D8A310", Offset = "0x6D88F10", VA = "0x186D8A310", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.Application)]
public interface PNCFCOHMABG
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	JENFDBIOBKO IMGIEBFKKBO
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public enum CHFIJEDGCFE
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
public interface FNNOGNIONBO : GJLBLCCLCKH
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	CHFIJEDGCFE NBDPBJLKMFI
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool BMDLJHGFEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	GameObject DKOODDCANLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<FNNOGNIONBO> FOLDLMBMPLC;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(BIOJOMCAEIE CHCPMCFMNCL, JBKDGFJKCIL IGNNJCLPPOC);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool EMGPHBNAHPC);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class DJKJPGKLANE
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6D8A1E0", Offset = "0x6D88DE0", VA = "0x186D8A1E0")]
	public static bool FIEBFPOFEAG(this FNNOGNIONBO KMCBLHBGCPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6D8A190", Offset = "0x6D88D90", VA = "0x186D8A190")]
	public static bool FFEAOHKDKMB(this FNNOGNIONBO KMCBLHBGCPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6D8A230", Offset = "0x6D88E30", VA = "0x186D8A230")]
	public static bool INKJBCFNDBC(this FNNOGNIONBO KMCBLHBGCPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6D8A280", Offset = "0x6D88E80", VA = "0x186D8A280")]
	public static bool KIIJDPHLFKB(this FNNOGNIONBO KMCBLHBGCPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface GJLBLCCLCKH
{
	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool LNEBBFIJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	JBKDGFJKCIL HJEOCMEBKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface JNKILMALILB
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate void JOJIMKAEEJC(IMCBIEOLNLK OOMPNBENOFL);

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event JOJIMKAEEJC NFLMAEDHAII;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface DPEPDICELJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IBKOMHPHLOG(Vector3 GKJAMFFKDLE, Quaternion EAGKGJHHIJH, Vector3 IMPGFCOPLND);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EOIGELPPMDL(JBKDGFJKCIL CDBGCEIGNJC);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MPAPJMHCEED(bool DJGIJMLPLPG);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BCPCELGDJBO(bool HDLFINBJMHG);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface HKLOAHDEIDH
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface KDGMOFIBABL
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(FKDGABLNLMI CBGPDBHNFOB);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface FKDGABLNLMI
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	GameObject DKOODDCANLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	Transform OHCKGBMFMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	DFINIIBCCEP MDBAPAEOJEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool LPEIBOEKGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IHMFALJEIME(DFINIIBCCEP GMBKDDMMMLD);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface DFINIIBCCEP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000066")]
	JBKDGFJKCIL HJEOCMEBKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Rigidbody NFEIAPALFII
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	FKDGABLNLMI ANCPPECAGND
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	GameObject MNEKHEHNFLF
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	Transform DJCNFDBJOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	DFINIIBCCEP GGAFGBKJIIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	DFINIIBCCEP JAFALLCEFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	int MHCECFLHJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	bool CIIKKBJHNAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	bool AIPMNIELNMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	bool JGIANDHMAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	HFNNNBLDCNA GIGBCDDIFFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	NHFCKNCOFHL BNJCKKMAIEN
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	float PGLPJNKMDCB
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	Vector3 CMDPGAKIAKM
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Vector3 JKOEHFPKHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 EOAIJNEBOIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 JOPLOAMFBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool NIBOLDAIGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	bool IJLNEEJPJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	bool JHLECMNIDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Vector3 NCKIOCCKCLB
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	Vector3 KAPPNMLNCME
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Vector3 EHEFDHIKAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Vector3 KBNEBOGPGBG
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	float BIFIDJPGNNK
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	float MBNFAEGAHNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	Vector3 ECPEKKJNEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Quaternion LCBDHCOEPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	float HIIPFEDIDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "60")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	float OBKAELLMFAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool PFADAKEGFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "64")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	MJNMIJLCBLF KDPJGJPBIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "66")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool DPJLPEODCNO
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Transform NJNJPMCLAND
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Vector3 LHMPEBNIPEG
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "70")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	float AFFFNIPBCOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "72")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	float NMKIACJKDCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "73")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "74")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	Quaternion ODLFLANDFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "75")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	Vector3 LDMDDCKKDNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "78")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	Quaternion ACHKOFDELKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "79")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	RigidbodyConstraints HGFMKNEOENL
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	bool BEFLOIPKEOB
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	CollisionDetectionMode NNAIEJLLLNM
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "86")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	bool DALLNAJDKLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "87")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event FANCDFLCCOJ IPMBNNJCPFO;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event FANCDFLCCOJ HJHJLJPPEMH;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event FANCDFLCCOJ OAGEABIHGLM;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event FANCDFLCCOJ OEGJNEFKFHC;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event FANCDFLCCOJ OBIKLCHEHLF;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event FANCDFLCCOJ ONOKKABJEHP;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event FANCDFLCCOJ ABDHGDHAPNC;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event BEKLGGOJFJM AKPBGIBNKIL;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<PFKPGFLKLMF, PFKPGFLKLMF> DLMOGLDMCON;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "26")]
	DFINIIBCCEP HMNNJDALHAG(int MFJLAMOCOBC);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void JLEFIBPFBOG((Quaternion rot, Vector3 moments) GEGLIBHENMO);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void OJANEOIFOLO();

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void OEALLKICOON();

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void JAAAEOBJNFJ();

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void HDMFOLCNGND();

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void GCGKNLEBBGH();

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void EOIGELPPMDL(DFINIIBCCEP CABLCDOIFFL, bool IHBDDDGGBPK = false);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void HHEBINPCIHG(object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void GHLNLPKHEON(object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "96")]
	Vector3 IHELIJDHFPA(Vector3 HFNEPAGLJGM);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 IHMLDBIKGFH(Vector3 BMFLMHGGHPH);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void GGOKAJCLLAN();

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void LPNDIEIGBLF();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void NLMJJHCEFAK();

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void KGCMLBIIHEF(Vector3 NMOGPAJJGNL, Vector3 ACFFMBMNFIL);

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void KOOFMIMPJDP(Vector3 DNLPADGICAN, Vector3 LPPLMKNAGEI);

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void DEBLGFDAICC(Vector3 JDDIPPFHEHC);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void EMABLOKJGCM(MFONMFNDNGL IDGIIMMBCIL, Vector3 PKIIFMCPGDK, float LIOFPKPIJFM, float CIIBCKHLCED = 8f, float JPLEKJHIBBE = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void EJOGIOHDDPJ(MILNJDMBAGC ANAPHKLDGNK, Vector3 PMMICEJDCDH, float EGOPDCFEMMN = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void LHGIJKKBMAH(MILNJDMBAGC ANAPHKLDGNK, Vector3 EAGKGJHHIJH, float LGJEAIELNIF = 7f, float ANDNDMFDKEN = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "107")]
	Vector3 APMIFMPDGIC(Vector3 CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 EICKODAIFLO(Vector3 CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "109")]
	void JJNOPMIDNNN();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void OJJMBMADKDP(DFINIIBCCEP MHEFINEMHCE, object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void EONINJDAFNJ(object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void KDNJNMKPHPE();

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void GIOFKEMGBKM();

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void BCCMDDNHIFD();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "115")]
	bool IKCEGMJLJMH();

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "116")]
	void OMGKNMJGCFG();

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void HIGHALKIHHK(object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void GKNIEJKJCLG(object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void DFCKPHMJEFG(object DGGGDIFONNG, bool EHIEEFMLLHN);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void CKKGGKNEILD(Vector3 AOLGKMLAGGH, Quaternion ANBJFHCHGMA);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void NBBIPCKBAJB(Vector3 FLGJCLBGIEO, Quaternion OGPBFADONDK);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "122")]
	bool MMIIIFJDFNI(float GBKOKFCKMOC);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void CLLMJPMEJOH(object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void IODCBJEEJJA(object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void KCIMDBGEJEP(object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void BLNDOGCHDLJ(object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void MONAJLCLIKD(Vector3 KHODILEOPHB, ForceMode PLAPFKADIEB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void HNILPEAKOIE(Vector3 KHODILEOPHB, Vector3 GKJAMFFKDLE, ForceMode PLAPFKADIEB);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void HMDHJLIKGOB(Vector3 NJKHALGKIBP, ForceMode PLAPFKADIEB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void PLNPLANPAFP(Vector3 NJKHALGKIBP, ForceMode PLAPFKADIEB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "131")]
	bool FNHJPILPKGF(Vector3 EJOHIEANBFL, [Out] RaycastHit IEALDBEJJDA, float GHBEHFGEGMI);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void NEGIONHHPPM();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface NHFCKNCOFHL
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ODHKELAKILD(Vector3 MFGLGHJDPJB);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFMHMFNCEEJ(Vector3 CMHJKMGAIPO);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BBJHNNJDJNP(Vector3 MFGLGHJDPJB);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MCBHFGLIHAN(Vector3 CMHJKMGAIPO);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface HFNNNBLDCNA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 MGBBHMOGKLB();

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 PFGLLJFDDNB();
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public delegate void FANCDFLCCOJ(FKDGABLNLMI GLLMHKPMCHM);
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum NBNEMFDELLF
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
public enum MFONMFNDNGL
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
public delegate void BEKLGGOJFJM(FKDGABLNLMI GLLMHKPMCHM, bool IHBDDDGGBPK = false);
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum MILNJDMBAGC
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct JAEAHDCMHEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Rigidbody JOOPKCJCOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public object ALIHIEOGJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector3 LIEOAJBFBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector3 IIEDKJMDIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public EGPFJKHDCKA GGPFMEACCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool GIPEIGMADGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool MNAALPLMBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool FOGFCGHEIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public bool CGHCJICLEFF;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct BDGGMOHGNEL : IEquatable<BDGGMOHGNEL>, GJLBLCCLCKH
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly BDGGMOHGNEL CCPNINNEHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public JBKDGFJKCIL HJEOCMEBKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0", Slot = "6")]
		get
		{
			return default(JBKDGFJKCIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public JKHKDBPHELO DJCNFDBJOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(JKHKDBPHELO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public OIAMNKPBEIJ APFJABBJNFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(OIAMNKPBEIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private OIMOBMEJAIF ONJJENNLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6D86030", Offset = "0x6D84C30", VA = "0x186D86030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public GameObject DKOODDCANLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6D879B0", Offset = "0x6D865B0", VA = "0x186D879B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public IOBDJLAADBM PMCMNNBMFAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6D87860", Offset = "0x6D86460", VA = "0x186D87860")]
		get
		{
			return default(IOBDJLAADBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public NDECBIIJMKP FGEKHMFDACK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6D87420", Offset = "0x6D86020", VA = "0x186D87420")]
		get
		{
			return default(NDECBIIJMKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public EKPAFNPHKFE LPOCJKELKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6D874C0", Offset = "0x6D860C0", VA = "0x186D874C0")]
		get
		{
			return default(EKPAFNPHKFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool PGDLMPBLHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6D87C10", Offset = "0x6D86810", VA = "0x186D87C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool KAPOGPCNGHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6D87C30", Offset = "0x6D86830", VA = "0x186D87C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool HDKFHNLOJOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6D87640", Offset = "0x6D86240", VA = "0x186D87640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool HIMOLHCEHBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6D87840", Offset = "0x6D86440", VA = "0x186D87840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool NPCEMJLNGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6D876A0", Offset = "0x6D862A0", VA = "0x186D876A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool OJJLLNMGJIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6D87C50", Offset = "0x6D86850", VA = "0x186D87C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool CHNNONIHHAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6D87B40", Offset = "0x6D86740", VA = "0x186D87B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool PHMFAAAADPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6D87660", Offset = "0x6D86260", VA = "0x186D87660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool KFOJNNJDNPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6D87B80", Offset = "0x6D86780", VA = "0x186D87B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public CELDCMDMJHC HKKLJDJCFML
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(CELDCMDMJHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public MDPMBNOJKCM HNFPNFBKDON
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(MDPMBNOJKCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public LCPMCHEMJCI BJKGDIMBAGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(LCPMCHEMJCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public MOHCOJNLKKG FLOAPAIGMDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(MOHCOJNLKKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public FKJMKPPJINP MGKFDJAKHMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(FKJMKPPJINP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public NEHDDLGFHLN JLFBINPBGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(NEHDDLGFHLN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public IPJBCAJCMEK MMDPOEOOBDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(IPJBCAJCMEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public CFFNCFOPNFJ GKCLEFKBMHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(CFFNCFOPNFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public BLCCHCMBOLF LANMFPIEMMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BLCCHCMBOLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public AEDEPBINILL HHCMEMIPJDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(AEDEPBINILL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public IOPIJGKKIFF KFCELKIMKHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(IOPIJGKKIFF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public COAALBBEJBI DGFOKMKFDJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(COAALBBEJBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public BBJICEFLLKI EFJJICBBBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BBJICEFLLKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool FIEBFPOFEAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6D87750", Offset = "0x6D86350", VA = "0x186D87750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool OCIJDKDGPHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6D87BD0", Offset = "0x6D867D0", VA = "0x186D87BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool FOOFMNGEEIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6D87560", Offset = "0x6D86160", VA = "0x186D87560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool LBAIHDOEHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
	public BDGGMOHGNEL(JBKDGFJKCIL DKAIINNEBFL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6D86CC0", Offset = "0x6D858C0", VA = "0x186D86CC0")]
	public static bool FGDKAMMLLCN(BDGGMOHGNEL CABLCDOIFFL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0xA495A0", Offset = "0xA481A0", VA = "0x180A495A0")]
	public static JBKDGFJKCIL FGDKAMMLLCN(BDGGMOHGNEL CABLCDOIFFL)
	{
		return default(JBKDGFJKCIL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x6D87C70", Offset = "0x6D86870", VA = "0x186D87C70")]
	public static bool PCHFOHOKDFG(BDGGMOHGNEL ALHLFNOAFIL, BDGGMOHGNEL AFHCIMLJCHF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6D86DB0", Offset = "0x6D859B0", VA = "0x186D86DB0")]
	public static bool GBEMIEIJNBP(BDGGMOHGNEL ALHLFNOAFIL, BDGGMOHGNEL AFHCIMLJCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6D876C0", Offset = "0x6D862C0", VA = "0x186D876C0", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(BDGGMOHGNEL FDOEIPBMJJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0xA495A0", Offset = "0xA481A0", VA = "0x180A495A0")]
	public static BDGGMOHGNEL FGDKAMMLLCN(JBKDGFJKCIL IMOBCMCECHO)
	{
		return default(BDGGMOHGNEL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6D87930", Offset = "0x6D86530", VA = "0x186D87930")]
	public IGHLONOGEFM HNONPJLNBOM()
	{
		return default(IGHLONOGEFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6D87BA0", Offset = "0x6D867A0", VA = "0x186D87BA0")]
	public BAFKJGIOLKK MJMJAJDLLJE()
	{
		return default(BAFKJGIOLKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6D873D0", Offset = "0x6D85FD0", VA = "0x186D873D0")]
	public OJKKAEEMNAO ADGOCCKOJIA()
	{
		return default(OJKKAEEMNAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6D87900", Offset = "0x6D86500", VA = "0x186D87900")]
	public OGAPCHLCDON HKDHGAIKHKG()
	{
		return default(OGAPCHLCDON);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6D875A0", Offset = "0x6D861A0", VA = "0x186D875A0")]
	public void CEPADAGMGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6D87C80", Offset = "0x6D86880", VA = "0x186D87C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct IPJBCAJCMEK : IEquatable<IPJBCAJCMEK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public JBKDGFJKCIL HJEOCMEBKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(JBKDGFJKCIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private OIMOBMEJAIF ONJJENNLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6D86030", Offset = "0x6D84C30", VA = "0x186D86030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private CACJPJLNOFJ HIJGPDHINAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6D8FD60", Offset = "0x6D8E960", VA = "0x186D8FD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private BFNGOOHGMMN NKLECOPBIFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6D8FB40", Offset = "0x6D8E740", VA = "0x186D8FB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool GLKJHHFEMNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6D903A0", Offset = "0x6D8EFA0", VA = "0x186D903A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Guid FCOHCEOCEND
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6D900D0", Offset = "0x6D8ECD0", VA = "0x186D900D0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool JEBCEPHFAFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6D901F0", Offset = "0x6D8EDF0", VA = "0x186D901F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Guid FCBHHIFPKCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6D90280", Offset = "0x6D8EE80", VA = "0x186D90280")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
	public IPJBCAJCMEK(JBKDGFJKCIL DKAIINNEBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6D8FC40", Offset = "0x6D8E840", VA = "0x186D8FC40", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(IPJBCAJCMEK FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6D8FBA0", Offset = "0x6D8E7A0", VA = "0x186D8FBA0")]
	public bool DCGHANFGOEG([Out] Guid JHHAGEEOAEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6D8FDF0", Offset = "0x6D8E9F0", VA = "0x186D8FDF0")]
	public void MMOLDBLDLEH(Guid JEODFFDGHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6D90030", Offset = "0x6D8EC30", VA = "0x186D90030")]
	public bool NEHFNGLFJOM([Out] Guid KPGLKHEJBED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6D8FF10", Offset = "0x6D8EB10", VA = "0x186D8FF10")]
	public void NCAMIIAPAGI(Guid JEODFFDGHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6D8FCD0", Offset = "0x6D8E8D0", VA = "0x186D8FCD0")]
	public void HGFBEINDODP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct OJKKAEEMNAO : IEquatable<OJKKAEEMNAO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public JBKDGFJKCIL HJEOCMEBKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(JBKDGFJKCIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private OIMOBMEJAIF ONJJENNLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6D86030", Offset = "0x6D84C30", VA = "0x186D86030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private CACJPJLNOFJ HIJGPDHINAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x6D984B0", Offset = "0x6D970B0", VA = "0x186D984B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private IIONMFDLBIG LMHFPHJPACH
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6D98540", Offset = "0x6D97140", VA = "0x186D98540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public Vector3 MENHDIOJPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6D97E90", Offset = "0x6D96A90", VA = "0x186D97E90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public Quaternion OAJBHNBDOFK
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6D980F0", Offset = "0x6D96CF0", VA = "0x186D980F0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public BDGGMOHGNEL KFGECCCGEPO
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6D98420", Offset = "0x6D97020", VA = "0x186D98420")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
	public OJKKAEEMNAO(JBKDGFJKCIL DKAIINNEBFL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6D86CC0", Offset = "0x6D858C0", VA = "0x186D86CC0")]
	public static bool FGDKAMMLLCN(OJKKAEEMNAO CABLCDOIFFL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0xA495A0", Offset = "0xA481A0", VA = "0x180A495A0")]
	public static JBKDGFJKCIL FGDKAMMLLCN(OJKKAEEMNAO CABLCDOIFFL)
	{
		return default(JBKDGFJKCIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6D98390", Offset = "0x6D96F90", VA = "0x186D98390", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(OJKKAEEMNAO FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x6D98240", Offset = "0x6D96E40", VA = "0x186D98240")]
	public void EMOHKOMJLBA(Vector3 GKJAMFFKDLE, Quaternion EAGKGJHHIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6D97FE0", Offset = "0x6D96BE0", VA = "0x186D97FE0")]
	public void BPOOIIJOJGN(float IMPGFCOPLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6D97CD0", Offset = "0x6D968D0", VA = "0x186D97CD0")]
	public void AAGFEAEAFND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct IGHLONOGEFM : IEquatable<IGHLONOGEFM>
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly IGHLONOGEFM CCPNINNEHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public JBKDGFJKCIL HJEOCMEBKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(JBKDGFJKCIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public JKHKDBPHELO DJCNFDBJOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(JKHKDBPHELO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public OIAMNKPBEIJ APFJABBJNFN
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(OIAMNKPBEIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private OIMOBMEJAIF ONJJENNLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6D86030", Offset = "0x6D84C30", VA = "0x186D86030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private CACJPJLNOFJ HIJGPDHINAE
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6D8DB90", Offset = "0x6D8C790", VA = "0x186D8DB90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	private PGJHHNGEJGI PHHFHMAJCFD
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6D8DC20", Offset = "0x6D8C820", VA = "0x186D8DC20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public DBLPDLFFIKD FLJLNHPLGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D200", Offset = "0x6D8BE00", VA = "0x186D8D200")]
		get
		{
			return default(DBLPDLFFIKD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public IEnumerable<BDGGMOHGNEL> HJJBBJPJLEK
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x6D8DEA0", Offset = "0x6D8CAA0", VA = "0x186D8DEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public IEnumerable<BDGGMOHGNEL> FNGEMDIIDHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6D8E6E0", Offset = "0x6D8D2E0", VA = "0x186D8E6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public int MHCECFLHJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6D8DD10", Offset = "0x6D8C910", VA = "0x186D8DD10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public int JOMKHONFJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6D8E690", Offset = "0x6D8D290", VA = "0x186D8E690")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public string IHBMAHBKJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D470", Offset = "0x6D8C070", VA = "0x186D8D470")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D070", Offset = "0x6D8BC70", VA = "0x186D8D070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public PFAGBDBNINI AMOLHLNENLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D3A0", Offset = "0x6D8BFA0", VA = "0x186D8D3A0")]
		get
		{
			return default(PFAGBDBNINI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D8D0", Offset = "0x6D8C4D0", VA = "0x186D8D8D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public KDBPJBNOMHD PHINCOBBAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D920", Offset = "0x6D8C520", VA = "0x186D8D920")]
		get
		{
			return default(KDBPJBNOMHD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x6D8DDA0", Offset = "0x6D8C9A0", VA = "0x186D8DDA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public JCOOFEPGIPB INIHPJCFEME
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D360", Offset = "0x6D8BF60", VA = "0x186D8D360")]
		get
		{
			return default(JCOOFEPGIPB);
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D0F0", Offset = "0x6D8BCF0", VA = "0x186D8D0F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public float DJHNPALPGOH
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D890", Offset = "0x6D8C490", VA = "0x186D8D890")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6D8DC80", Offset = "0x6D8C880", VA = "0x186D8DC80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool HHPFKKPBNDN
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D140", Offset = "0x6D8BD40", VA = "0x186D8D140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool DELLJIOEGFP
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x6D8DDF0", Offset = "0x6D8C9F0", VA = "0x186D8DDF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool PHLJKCEOBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x6D8E060", Offset = "0x6D8CC60", VA = "0x186D8E060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool AJPJKBONMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D1A0", Offset = "0x6D8BDA0", VA = "0x186D8D1A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool DCPEFOMKLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6D8DCD0", Offset = "0x6D8C8D0", VA = "0x186D8DCD0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6D8E000", Offset = "0x6D8CC00", VA = "0x186D8E000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool LLCAOFEEIML
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D2C0", Offset = "0x6D8BEC0", VA = "0x186D8D2C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D300", Offset = "0x6D8BF00", VA = "0x186D8D300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
	public IGHLONOGEFM(JBKDGFJKCIL DKAIINNEBFL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6D86CC0", Offset = "0x6D858C0", VA = "0x186D86CC0")]
	public static bool FGDKAMMLLCN(IGHLONOGEFM CABLCDOIFFL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6D87C70", Offset = "0x6D86870", VA = "0x186D87C70")]
	public static bool PCHFOHOKDFG(IGHLONOGEFM ALHLFNOAFIL, IGHLONOGEFM AFHCIMLJCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6D8D3E0", Offset = "0x6D8BFE0", VA = "0x186D8D3E0", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(IGHLONOGEFM FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xA495A0", Offset = "0xA481A0", VA = "0x180A495A0")]
	public static BDGGMOHGNEL FGDKAMMLLCN(IGHLONOGEFM GMNCELIMKIF)
	{
		return default(BDGGMOHGNEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6D8E670", Offset = "0x6D8D270", VA = "0x186D8E670")]
	public bool OJLACCJMLNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6D8DE50", Offset = "0x6D8CA50", VA = "0x186D8DE50")]
	public bool MHICLIEPJJF(NCAHLIGACJD JEFLNAOAGOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6D8DB10", Offset = "0x6D8C710", VA = "0x186D8DB10")]
	public void IDCGBANALKL(NCAHLIGACJD JEFLNAOAGOK, bool BFJLCIKEACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6D8D960", Offset = "0x6D8C560", VA = "0x186D8D960")]
	public DBLPDLFFIKD HHAFILKPGHL(Allocator ICLGONBNBJO)
	{
		return default(DBLPDLFFIKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x6D8D4F0", Offset = "0x6D8C0F0", VA = "0x186D8D4F0")]
	public void FNMDBEDHAEB(IGHLONOGEFM FDOEIPBMJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x6D8E0C0", Offset = "0x6D8CCC0", VA = "0x186D8E0C0")]
	public void OAHNELJHMNA(List<BDGGMOHGNEL> CBFFADJCEPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct NMHAMBJCOCM : IEquatable<NMHAMBJCOCM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6D96560", Offset = "0x6D95160", VA = "0x186D96560", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(NMHAMBJCOCM FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct MDPMBNOJKCM : IEquatable<MDPMBNOJKCM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	private OIMOBMEJAIF ONJJENNLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x6D86030", Offset = "0x6D84C30", VA = "0x186D86030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
	public MDPMBNOJKCM(JBKDGFJKCIL DKAIINNEBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6D93D80", Offset = "0x6D92980", VA = "0x186D93D80", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(MDPMBNOJKCM FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6D93F50", Offset = "0x6D92B50", VA = "0x186D93F50")]
	public void PAMNEBLPMKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6D93EB0", Offset = "0x6D92AB0", VA = "0x186D93EB0")]
	public void IFIKJAGMLDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6D93E10", Offset = "0x6D92A10", VA = "0x186D93E10")]
	public bool HBIEICLGOIE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct OIAMNKPBEIJ : IEquatable<OIAMNKPBEIJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public JBKDGFJKCIL HJEOCMEBKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(JBKDGFJKCIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private OIMOBMEJAIF ONJJENNLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x6D86030", Offset = "0x6D84C30", VA = "0x186D86030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private CACJPJLNOFJ HIJGPDHINAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x6D979A0", Offset = "0x6D965A0", VA = "0x186D979A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private PGJHHNGEJGI PHHFHMAJCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x6D97A30", Offset = "0x6D96630", VA = "0x186D97A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public JBKDGFJKCIL KBAELOBLNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x6D97330", Offset = "0x6D95F30", VA = "0x186D97330")]
		get
		{
			return default(JBKDGFJKCIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public BDGGMOHGNEL GGAFGBKJIIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6D97A90", Offset = "0x6D96690", VA = "0x186D97A90")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public BDGGMOHGNEL JAFALLCEFOE
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6D97B20", Offset = "0x6D96720", VA = "0x186D97B20")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
	public OIAMNKPBEIJ(JBKDGFJKCIL DKAIINNEBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6D974F0", Offset = "0x6D960F0", VA = "0x186D974F0", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(OIAMNKPBEIJ FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x6D973C0", Offset = "0x6D95FC0", VA = "0x186D973C0")]
	public bool EOIGELPPMDL(BDGGMOHGNEL CDBGCEIGNJC, bool HEAKKLLNAOG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6D97810", Offset = "0x6D96410", VA = "0x186D97810")]
	public bool GMCCOEOCHND(BDGGMOHGNEL OMPOBHCLMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6D97580", Offset = "0x6D96180", VA = "0x186D97580")]
	private void FMHOBFPOHLK(BDGGMOHGNEL DLNPCHKBDJA, List<BDGGMOHGNEL> MABAFOPPAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6D97910", Offset = "0x6D96510", VA = "0x186D97910")]
	public IGHLONOGEFM JDCAPNDFOHJ()
	{
		return default(IGHLONOGEFM);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6D978B0", Offset = "0x6D964B0", VA = "0x186D978B0")]
	public void ICPFBBAAJKP(List<BDGGMOHGNEL> HMLGPDDADFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6D97BB0", Offset = "0x6D967B0", VA = "0x186D97BB0")]
	public NativeArray<JBKDGFJKCIL> NGHCJDOEEEL()
	{
		return default(NativeArray<JBKDGFJKCIL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct CELDCMDMJHC : IEquatable<CELDCMDMJHC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public string MDADLGCDEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x6D88420", Offset = "0x6D87020", VA = "0x186D88420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public string EDOPDNCJHBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6D88530", Offset = "0x6D87130", VA = "0x186D88530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private bool CNLDKKDHNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6D88190", Offset = "0x6D86D90", VA = "0x186D88190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public string CFFOBALFONG
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6D888B0", Offset = "0x6D874B0", VA = "0x186D888B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public string IECBKJHHMHF
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6D88660", Offset = "0x6D87260", VA = "0x186D88660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public string MMCJOFNKCEF
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6D88330", Offset = "0x6D86F30", VA = "0x186D88330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
	public CELDCMDMJHC(JBKDGFJKCIL DKAIINNEBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6D884A0", Offset = "0x6D870A0", VA = "0x186D884A0", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(CELDCMDMJHC FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct IOPIJGKKIFF : IEquatable<IOPIJGKKIFF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private OIMOBMEJAIF ONJJENNLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6D86030", Offset = "0x6D84C30", VA = "0x186D86030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private CACJPJLNOFJ HIJGPDHINAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6D8F750", Offset = "0x6D8E350", VA = "0x186D8F750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private DADPHLLPINM NIJIMINCEEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6D8F650", Offset = "0x6D8E250", VA = "0x186D8F650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public AALAMJMKCOL PMAGFAIAAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6D8F7E0", Offset = "0x6D8E3E0", VA = "0x186D8F7E0")]
		get
		{
			return default(AALAMJMKCOL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6D8F2F0", Offset = "0x6D8DEF0", VA = "0x186D8F2F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public bool EGFDNKFFJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6D8F8E0", Offset = "0x6D8E4E0", VA = "0x186D8F8E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6D8F5B0", Offset = "0x6D8E1B0", VA = "0x186D8F5B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public string[] PJMEADHPMFH
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6D8F490", Offset = "0x6D8E090", VA = "0x186D8F490")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6D8F250", Offset = "0x6D8DE50", VA = "0x186D8F250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public string[] PJNPLEBPHEA
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6D8F520", Offset = "0x6D8E120", VA = "0x186D8F520")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6D8FAA0", Offset = "0x6D8E6A0", VA = "0x186D8FAA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public string[] GKBEMLIHAIA
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6D8F1C0", Offset = "0x6D8DDC0", VA = "0x186D8F1C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6D8F120", Offset = "0x6D8DD20", VA = "0x186D8F120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public string[] KGBCHLHJFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6D8F970", Offset = "0x6D8E570", VA = "0x186D8F970")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6D8F6B0", Offset = "0x6D8E2B0", VA = "0x186D8F6B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
	public IOPIJGKKIFF(JBKDGFJKCIL DKAIINNEBFL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0xA495A0", Offset = "0xA481A0", VA = "0x180A495A0")]
	public static JBKDGFJKCIL FGDKAMMLLCN(IOPIJGKKIFF CABLCDOIFFL)
	{
		return default(JBKDGFJKCIL);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x6D8F400", Offset = "0x6D8E000", VA = "0x186D8F400", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(IOPIJGKKIFF FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x6D8FA00", Offset = "0x6D8E600", VA = "0x186D8FA00")]
	public bool OANANAMBJCA(JBKDGFJKCIL PMNDEDNNDFE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct EIPJLHIFBKH : IEquatable<EIPJLHIFBKH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6D8A370", Offset = "0x6D88F70", VA = "0x186D8A370", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(EIPJLHIFBKH FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct LCPMCHEMJCI : IEquatable<LCPMCHEMJCI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public Collider HJLLIBHBAKI
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6D939E0", Offset = "0x6D925E0", VA = "0x186D939E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
	public LCPMCHEMJCI(JBKDGFJKCIL DKAIINNEBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6D93950", Offset = "0x6D92550", VA = "0x186D93950", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(LCPMCHEMJCI FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct OGAPCHLCDON : IEquatable<OGAPCHLCDON>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public bool IPHEKJBJNCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6D972E0", Offset = "0x6D95EE0", VA = "0x186D972E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
	public OGAPCHLCDON(JBKDGFJKCIL DKAIINNEBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6D97250", Offset = "0x6D95E50", VA = "0x186D97250", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(OGAPCHLCDON FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct BLCCHCMBOLF : IEquatable<BLCCHCMBOLF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public JBKDGFJKCIL HJEOCMEBKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(JBKDGFJKCIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	private OIMOBMEJAIF ONJJENNLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x6D86030", Offset = "0x6D84C30", VA = "0x186D86030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	private CACJPJLNOFJ HIJGPDHINAE
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x6D87ED0", Offset = "0x6D86AD0", VA = "0x186D87ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private DGJINFKHOMH CECFGKOCJAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x6D87DE0", Offset = "0x6D869E0", VA = "0x186D87DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
	public BLCCHCMBOLF(JBKDGFJKCIL DKAIINNEBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6D87E40", Offset = "0x6D86A40", VA = "0x186D87E40", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(BLCCHCMBOLF FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D87F60", Offset = "0x6D86B60", VA = "0x186D87F60")]
	public void KDEMFGOCCLM(bool MEIFJOCIEOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct MOHCOJNLKKG : IEquatable<MOHCOJNLKKG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public JBKDGFJKCIL HJEOCMEBKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(JBKDGFJKCIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private OIMOBMEJAIF ONJJENNLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6D86030", Offset = "0x6D84C30", VA = "0x186D86030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private CACJPJLNOFJ HIJGPDHINAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6D95B00", Offset = "0x6D94700", VA = "0x186D95B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool ILBNCLEDPOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6D95A10", Offset = "0x6D94610", VA = "0x186D95A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool JKHKMIAEKPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6D955C0", Offset = "0x6D941C0", VA = "0x186D955C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool NGDDAAHBHEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6D958B0", Offset = "0x6D944B0", VA = "0x186D958B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool KIAPAHEBIGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6D95B90", Offset = "0x6D94790", VA = "0x186D95B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool BBNBHCEAHFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x6D956D0", Offset = "0x6D942D0", VA = "0x186D956D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public bool NNINLFMBAMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6D95E40", Offset = "0x6D94A40", VA = "0x186D95E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public bool ACNEPNMBLKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x6D957C0", Offset = "0x6D943C0", VA = "0x186D957C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public bool CANBKECMPND
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x6D95DA0", Offset = "0x6D949A0", VA = "0x186D95DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public bool FFCJBINGKHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x6D95A50", Offset = "0x6D94650", VA = "0x186D95A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public bool ACDBHFGLCPN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x6D95530", Offset = "0x6D94130", VA = "0x186D95530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool CBBFLMPEJPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x6D95720", Offset = "0x6D94320", VA = "0x186D95720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool BEANKIMIMPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x6D95D50", Offset = "0x6D94950", VA = "0x186D95D50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool DBALHIDIGBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x6D95DF0", Offset = "0x6D949F0", VA = "0x186D95DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool CGBMKOGBCKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x6D95ED0", Offset = "0x6D94AD0", VA = "0x186D95ED0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x6D95AA0", Offset = "0x6D946A0", VA = "0x186D95AA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public KOIOJDPNKFG BGAMMEHHKOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6D95610", Offset = "0x6D94210", VA = "0x186D95610")]
		get
		{
			return default(KOIOJDPNKFG);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x6D95770", Offset = "0x6D94370", VA = "0x186D95770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool CMKFMNMJFDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x6D95F10", Offset = "0x6D94B10", VA = "0x186D95F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public HGPGHDAEOFM OFIEMCGPJBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x6D95810", Offset = "0x6D94410", VA = "0x186D95810")]
		get
		{
			return default(HGPGHDAEOFM);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x6D95CB0", Offset = "0x6D948B0", VA = "0x186D95CB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool KNOCGEOAOGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x6D95580", Offset = "0x6D94180", VA = "0x186D95580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Vector3 BPLOPGHOBFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x6D95C30", Offset = "0x6D94830", VA = "0x186D95C30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Vector3 EKIAIDODOOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6D95650", Offset = "0x6D94250", VA = "0x186D95650")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public bool JFDNONBAKJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6D960A0", Offset = "0x6D94CA0", VA = "0x186D960A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
	public MOHCOJNLKKG(JBKDGFJKCIL DKAIINNEBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6D95900", Offset = "0x6D94500", VA = "0x186D95900", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(MOHCOJNLKKG FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x6D95850", Offset = "0x6D94450", VA = "0x186D95850")]
	public bool EGANAOHBFBP(LOPJOLMHFBC JEFLNAOAGOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x6D95D00", Offset = "0x6D94900", VA = "0x186D95D00")]
	public bool KPILMCMJBHP(IDFJCJHJMNO JEFLNAOAGOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6D95990", Offset = "0x6D94590", VA = "0x186D95990")]
	public void HIIEOOBILHO(IDFJCJHJMNO JEFLNAOAGOK, bool BFJLCIKEACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6D95E90", Offset = "0x6D94A90", VA = "0x186D95E90")]
	public IDFJCJHJMNO MJJIFMPINOG()
	{
		return default(IDFJCJHJMNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6D95BE0", Offset = "0x6D947E0", VA = "0x186D95BE0")]
	public bool JOGMBPENJIM(IDFJCJHJMNO CABLCDOIFFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct AEDEPBINILL : IEquatable<AEDEPBINILL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private OIMOBMEJAIF ONJJENNLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6D86030", Offset = "0x6D84C30", VA = "0x186D86030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private CACJPJLNOFJ HIJGPDHINAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6D86820", Offset = "0x6D85420", VA = "0x186D86820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	private NIKBMHJNLNF JLMNNAJMKAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x6D85FD0", Offset = "0x6D84BD0", VA = "0x186D85FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
	public AEDEPBINILL(JBKDGFJKCIL DKAIINNEBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6D86410", Offset = "0x6D85010", VA = "0x186D86410", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(AEDEPBINILL FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6D86A10", Offset = "0x6D85610", VA = "0x186D86A10")]
	public bool OOEIEFFNOEK(AFHJIGHFEFH CHCPEAEKFEB, List<BDGGMOHGNEL> CBFFADJCEPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6D86090", Offset = "0x6D84C90", VA = "0x186D86090")]
	public int CHEMDIELHJK(AFHJIGHFEFH CHCPEAEKFEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6D865E0", Offset = "0x6D851E0", VA = "0x186D865E0")]
	public void HMCNLFGKHMB(List<BDGGMOHGNEL> CBFFADJCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6D866F0", Offset = "0x6D852F0", VA = "0x186D866F0")]
	public int IJKLJNFANMB(BDGGMOHGNEL CGJNNJHBPPG, AFHJIGHFEFH CHCPEAEKFEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6D862D0", Offset = "0x6D84ED0", VA = "0x186D862D0")]
	public BDGGMOHGNEL CLMNFAHLNDG(int MFJLAMOCOBC, AFHJIGHFEFH CHCPEAEKFEB)
	{
		return default(BDGGMOHGNEL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6D861A0", Offset = "0x6D84DA0", VA = "0x186D861A0")]
	public void CLDFJBPOMLC(BDGGMOHGNEL CGJNNJHBPPG, AFHJIGHFEFH CHCPEAEKFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6D868B0", Offset = "0x6D854B0", VA = "0x186D868B0")]
	public bool LJHGBJCGPJC(BDGGMOHGNEL CGJNNJHBPPG, AFHJIGHFEFH CHCPEAEKFEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6D85EC0", Offset = "0x6D84AC0", VA = "0x186D85EC0")]
	public void AJPMDJBCEJD(AFHJIGHFEFH CHCPEAEKFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x6D86960", Offset = "0x6D85560", VA = "0x186D86960")]
	public bool LJPKBLLMELP(BDGGMOHGNEL CGJNNJHBPPG, AFHJIGHFEFH CHCPEAEKFEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x6D864D0", Offset = "0x6D850D0", VA = "0x186D864D0")]
	public bool HLGLKGEEPNB(AFHJIGHFEFH CHCPEAEKFEB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct NEHDDLGFHLN : IEquatable<NEHDDLGFHLN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public JBKDGFJKCIL HJEOCMEBKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(JBKDGFJKCIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private OIMOBMEJAIF ONJJENNLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x6D86030", Offset = "0x6D84C30", VA = "0x186D86030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private CACJPJLNOFJ HIJGPDHINAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x6D962C0", Offset = "0x6D94EC0", VA = "0x186D962C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
	public NEHDDLGFHLN(JBKDGFJKCIL DKAIINNEBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6D961A0", Offset = "0x6D94DA0", VA = "0x186D961A0", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(NEHDDLGFHLN FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6D96350", Offset = "0x6D94F50", VA = "0x186D96350")]
	public void MCIBGCONIDP(bool CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x6D96230", Offset = "0x6D94E30", VA = "0x186D96230")]
	public void HMAHIMGBFHN(bool CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2F616C0", Offset = "0x2F602C0", VA = "0x182F616C0")]
	public T BANBLCKKMFA<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct COAALBBEJBI : IEquatable<COAALBBEJBI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public JBKDGFJKCIL HJEOCMEBKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(JBKDGFJKCIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	private OIMOBMEJAIF ONJJENNLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6D86030", Offset = "0x6D84C30", VA = "0x186D86030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private CACJPJLNOFJ HIJGPDHINAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x6D89780", Offset = "0x6D88380", VA = "0x186D89780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private AOHHHJIMCMA KOIDLONKHKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x6D898A0", Offset = "0x6D884A0", VA = "0x186D898A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public bool LPIFEHIIIAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6D896F0", Offset = "0x6D882F0", VA = "0x186D896F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public bool NKGNKLGBFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x6D89810", Offset = "0x6D88410", VA = "0x186D89810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
	public COAALBBEJBI(JBKDGFJKCIL DKAIINNEBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6D89660", Offset = "0x6D88260", VA = "0x186D89660", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(COAALBBEJBI FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct GCJAFFBIBDL : IEquatable<GCJAFFBIBDL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6D8BAA0", Offset = "0x6D8A6A0", VA = "0x186D8BAA0", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(GCJAFFBIBDL FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct FKJMKPPJINP : IEquatable<FKJMKPPJINP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public JBKDGFJKCIL HJEOCMEBKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(JBKDGFJKCIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private OIMOBMEJAIF ONJJENNLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x6D86030", Offset = "0x6D84C30", VA = "0x186D86030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private CACJPJLNOFJ HIJGPDHINAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A9B0", Offset = "0x6D895B0", VA = "0x186D8A9B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private GKOGPPBOBDA GPBIIOOKDGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x6D8B0C0", Offset = "0x6D89CC0", VA = "0x186D8B0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private EHAMHHHNAID JPOKNDIPPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A400", Offset = "0x6D89000", VA = "0x186D8A400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool BDOOAHNDHGH
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x6D8B000", Offset = "0x6D89C00", VA = "0x186D8B000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool FFFBIOMHBNC
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x6D8B120", Offset = "0x6D89D20", VA = "0x186D8B120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool DGLMABPKOCI
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6D8AF00", Offset = "0x6D89B00", VA = "0x186D8AF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool FKGLCMEBLLI
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x6D8AF30", Offset = "0x6D89B30", VA = "0x186D8AF30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool DAOHKMHHIJC
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x6D8B090", Offset = "0x6D89C90", VA = "0x186D8B090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool OGJGGJLAHAG
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A810", Offset = "0x6D89410", VA = "0x186D8A810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool NAMDFNNAIJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x6D8AA40", Offset = "0x6D89640", VA = "0x186D8AA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public bool FCBPLDDCBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A6A0", Offset = "0x6D892A0", VA = "0x186D8A6A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public bool CGMDIMPCKCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x6D8AC50", Offset = "0x6D89850", VA = "0x186D8AC50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
	public FKJMKPPJINP(JBKDGFJKCIL DKAIINNEBFL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x6D86CC0", Offset = "0x6D858C0", VA = "0x186D86CC0")]
	public static bool FGDKAMMLLCN(FKJMKPPJINP CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6D8A610", Offset = "0x6D89210", VA = "0x186D8A610", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(FKJMKPPJINP FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6D8ADF0", Offset = "0x6D899F0", VA = "0x186D8ADF0")]
	public bool LGGPIAADGCO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6D8A460", Offset = "0x6D89060", VA = "0x186D8A460")]
	public BDGGMOHGNEL CHDAFCHHFKB(BDGGMOHGNEL CGJNNJHBPPG)
	{
		return default(BDGGMOHGNEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6D8A8A0", Offset = "0x6D894A0", VA = "0x186D8A8A0")]
	public JBKDGFJKCIL JEPMKCJOBAM()
	{
		return default(JBKDGFJKCIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6D8AE60", Offset = "0x6D89A60", VA = "0x186D8AE60")]
	public bool LGONLDJGCHP(JBKDGFJKCIL DJDCHEPHJIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6D8B1C0", Offset = "0x6D89DC0", VA = "0x186D8B1C0")]
	public bool PJDIGLCADCI(JBKDGFJKCIL EIFKNJHEOOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6D8A500", Offset = "0x6D89100", VA = "0x186D8A500")]
	public bool DNIODCKDLEF(JBKDGFJKCIL CGJNNJHBPPG, [Out] JBKDGFJKCIL DJDCHEPHJIB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct BAFKJGIOLKK : IEquatable<BAFKJGIOLKK>
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly BAFKJGIOLKK CCPNINNEHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public JBKDGFJKCIL HJEOCMEBKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(JBKDGFJKCIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public JKHKDBPHELO DJCNFDBJOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(JKHKDBPHELO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public OIAMNKPBEIJ APFJABBJNFN
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(OIAMNKPBEIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public JMPLPCFCNKL BHLDBKJCJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x6D86DD0", Offset = "0x6D859D0", VA = "0x186D86DD0")]
		get
		{
			return default(JMPLPCFCNKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public KFACANAEJMG KIGNICELNFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x6D86FD0", Offset = "0x6D85BD0", VA = "0x186D86FD0")]
		get
		{
			return default(KFACANAEJMG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x6D86E10", Offset = "0x6D85A10", VA = "0x186D86E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public IIABJBBPAPB CLNADELPCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x6D87060", Offset = "0x6D85C60", VA = "0x186D87060")]
		get
		{
			return default(IIABJBBPAPB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x6D86BE0", Offset = "0x6D857E0", VA = "0x186D86BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public float EBDOMFOCALN
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6D86E60", Offset = "0x6D85A60", VA = "0x186D86E60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6D86EE0", Offset = "0x6D85AE0", VA = "0x186D86EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public Vector3 MIPOJBCODAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x6D86D30", Offset = "0x6D85930", VA = "0x186D86D30")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x6D86B60", Offset = "0x6D85760", VA = "0x186D86B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public float LIEHFGCJNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x6D86CE0", Offset = "0x6D858E0", VA = "0x186D86CE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public BBKOFHLHEBG EEINCCIOHOP
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x6D86EA0", Offset = "0x6D85AA0", VA = "0x186D86EA0")]
		get
		{
			return default(BBKOFHLHEBG);
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x6D87010", Offset = "0x6D85C10", VA = "0x186D87010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
	public BAFKJGIOLKK(JBKDGFJKCIL DKAIINNEBFL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6D86CC0", Offset = "0x6D858C0", VA = "0x186D86CC0")]
	public static bool FGDKAMMLLCN(BAFKJGIOLKK CABLCDOIFFL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x6D86DB0", Offset = "0x6D859B0", VA = "0x186D86DB0")]
	public static bool GBEMIEIJNBP(BAFKJGIOLKK ALHLFNOAFIL, BAFKJGIOLKK AFHCIMLJCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6D86C30", Offset = "0x6D85830", VA = "0x186D86C30", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(BAFKJGIOLKK FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x6D86F30", Offset = "0x6D85B30", VA = "0x186D86F30")]
	public MLOPJMEMPIM MDBKCMHKJEJ()
	{
		return default(MLOPJMEMPIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6D86F80", Offset = "0x6D85B80", VA = "0x186D86F80")]
	public GJGOCLGMFFN NAPCINLLPOA()
	{
		return default(GJGOCLGMFFN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct MLOPJMEMPIM : IEquatable<MLOPJMEMPIM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public JBKDGFJKCIL HJEOCMEBKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(JBKDGFJKCIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public BAFKJGIOLKK MOPIKHHCCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BAFKJGIOLKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public FLDGGDEOLHM CGAFNLJEBJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x6D945C0", Offset = "0x6D931C0", VA = "0x186D945C0")]
		get
		{
			return default(FLDGGDEOLHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
	public MLOPJMEMPIM(JBKDGFJKCIL DKAIINNEBFL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x6D86CC0", Offset = "0x6D858C0", VA = "0x186D86CC0")]
	public static bool FGDKAMMLLCN(MLOPJMEMPIM CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x6D94530", Offset = "0x6D93130", VA = "0x186D94530", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(MLOPJMEMPIM FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[DefaultMember("Item")]
public readonly struct GJGOCLGMFFN : IEquatable<GJGOCLGMFFN>
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly GJGOCLGMFFN CCPNINNEHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public JBKDGFJKCIL HJEOCMEBKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(JBKDGFJKCIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public JKHKDBPHELO DJCNFDBJOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(JKHKDBPHELO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private OIMOBMEJAIF ONJJENNLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x6D86030", Offset = "0x6D84C30", VA = "0x186D86030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private CACJPJLNOFJ HIJGPDHINAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6D8CA40", Offset = "0x6D8B640", VA = "0x186D8CA40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	private EMKCMJJEJCB PPEHDBOGMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6D8C490", Offset = "0x6D8B090", VA = "0x186D8C490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public BAFKJGIOLKK MOPIKHHCCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BAFKJGIOLKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public ENKLMLKMLJC KPEKKPBAIOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6D8BDE0", Offset = "0x6D8A9E0", VA = "0x186D8BDE0")]
		get
		{
			return default(ENKLMLKMLJC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x6D8C6F0", Offset = "0x6D8B2F0", VA = "0x186D8C6F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public IEnumerable<HGDMNGFMHBN> KDIDHCCPJKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x6D8C4F0", Offset = "0x6D8B0F0", VA = "0x186D8C4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public HGDMNGFMHBN CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x6D8C0D0", Offset = "0x6D8ACD0", VA = "0x186D8C0D0")]
		get
		{
			return default(HGDMNGFMHBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x6D8C040", Offset = "0x6D8AC40", VA = "0x186D8C040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
	public GJGOCLGMFFN(JBKDGFJKCIL DKAIINNEBFL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x6D86CC0", Offset = "0x6D858C0", VA = "0x186D86CC0")]
	public static bool FGDKAMMLLCN(GJGOCLGMFFN CABLCDOIFFL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x6D87C70", Offset = "0x6D86870", VA = "0x186D87C70")]
	public static bool PCHFOHOKDFG(GJGOCLGMFFN ALHLFNOAFIL, GJGOCLGMFFN AFHCIMLJCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x6D8C400", Offset = "0x6D8B000", VA = "0x186D8C400", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(GJGOCLGMFFN FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x6D8C1E0", Offset = "0x6D8ADE0", VA = "0x186D8C1E0")]
	public HGDMNGFMHBN DLDIDIHBEBF(float3? GKJAMFFKDLE, [Optional] quaternion? EAGKGJHHIJH, [Optional] Vector3? IMPGFCOPLND)
	{
		return default(HGDMNGFMHBN);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x6D8C810", Offset = "0x6D8B410", VA = "0x186D8C810")]
	public HGDMNGFMHBN JDDICHJFAAB(int MFJLAMOCOBC, float3? GKJAMFFKDLE, [Optional] quaternion? EAGKGJHHIJH, [Optional] Vector3? IMPGFCOPLND)
	{
		return default(HGDMNGFMHBN);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x6D8BFA0", Offset = "0x6D8ABA0", VA = "0x186D8BFA0")]
	public void BNGHKLOOFMF(int MFJLAMOCOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6D8BF10", Offset = "0x6D8AB10", VA = "0x186D8BF10")]
	public void ANKOMBFBDGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct HGDMNGFMHBN : IEquatable<HGDMNGFMHBN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public JBKDGFJKCIL HJEOCMEBKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(JBKDGFJKCIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public GJGOCLGMFFN JGEICFFNMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x6D8CDE0", Offset = "0x6D8B9E0", VA = "0x186D8CDE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public float3 LDMDDCKKDNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x6D8CCF0", Offset = "0x6D8B8F0", VA = "0x186D8CCF0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x6D8CF10", Offset = "0x6D8BB10", VA = "0x186D8CF10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public quaternion ACHKOFDELKA
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x6D8CF70", Offset = "0x6D8BB70", VA = "0x186D8CF70")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x6D8CE60", Offset = "0x6D8BA60", VA = "0x186D8CE60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public float3 AHFLHLOBPPG
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x6D8CEB0", Offset = "0x6D8BAB0", VA = "0x186D8CEB0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D010", Offset = "0x6D8BC10", VA = "0x186D8D010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public KDOGGLNNCFG PILNNGMPAPA
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x6D8CFC0", Offset = "0x6D8BBC0", VA = "0x186D8CFC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
	public HGDMNGFMHBN(JBKDGFJKCIL DKAIINNEBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x6D8CD50", Offset = "0x6D8B950", VA = "0x186D8CD50", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(HGDMNGFMHBN FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x6D8CCE0", Offset = "0x6D8B8E0", VA = "0x186D8CCE0")]
	public void CLKIGDKHEAO(GJGOCLGMFFN CABLCDOIFFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct CFFNCFOPNFJ : IEquatable<CFFNCFOPNFJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public JBKDGFJKCIL HJEOCMEBKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(JBKDGFJKCIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	private OIMOBMEJAIF ONJJENNLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x6D86030", Offset = "0x6D84C30", VA = "0x186D86030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	private CACJPJLNOFJ HIJGPDHINAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6D89260", Offset = "0x6D87E60", VA = "0x186D89260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	private DOFMNPCIHHG CGCHMCEGPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x6D892F0", Offset = "0x6D87EF0", VA = "0x186D892F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public bool MLPOEBDFFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x6D89350", Offset = "0x6D87F50", VA = "0x186D89350")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x6D89520", Offset = "0x6D88120", VA = "0x186D89520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public bool KJDBNEDBIBB
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x6D88E50", Offset = "0x6D87A50", VA = "0x186D88E50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x6D88CA0", Offset = "0x6D878A0", VA = "0x186D88CA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public float MPINFDPDIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x6D89110", Offset = "0x6D87D10", VA = "0x186D89110")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x6D889F0", Offset = "0x6D875F0", VA = "0x186D889F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public bool OCHNPBFBJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6D889A0", Offset = "0x6D875A0", VA = "0x186D889A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
	public CFFNCFOPNFJ(JBKDGFJKCIL DKAIINNEBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x6D88A40", Offset = "0x6D87640", VA = "0x186D88A40", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(CFFNCFOPNFJ FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x6D88C00", Offset = "0x6D87800", VA = "0x186D88C00")]
	public void FIPBKGFOAIE(int LCMKGCMMEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x6D89150", Offset = "0x6D87D50", VA = "0x186D89150")]
	public bool JEILMCMAKNB([Out] int LCMKGCMMEHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x6D89070", Offset = "0x6D87C70", VA = "0x186D89070")]
	public void IPGLHEJHDOH(bool GBGGBOMPGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x6D893A0", Offset = "0x6D87FA0", VA = "0x186D893A0")]
	public bool NCHDLBPGNJB(DKDJCAKPEJH JEFLNAOAGOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x6D88FF0", Offset = "0x6D87BF0", VA = "0x186D88FF0")]
	public void IOJCILDNDAM(DKDJCAKPEJH JEFLNAOAGOK, bool BFJLCIKEACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x6D88D00", Offset = "0x6D87900", VA = "0x186D88D00")]
	public void FNENGMNIONA(float AMNDAJBPIEC, float OOCKGELNLCO, float KGKLOGECBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x6D88EA0", Offset = "0x6D87AA0", VA = "0x186D88EA0")]
	public void IELLIPEAEEK(float3 DDCFCJJDIOE, quaternion AKLODHBMNIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x6D893F0", Offset = "0x6D87FF0", VA = "0x186D893F0")]
	public bool ODMAGPMPCAE([Out] float3 DDCFCJJDIOE, [Out] quaternion AKLODHBMNIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x6D88AD0", Offset = "0x6D876D0", VA = "0x186D88AD0")]
	public bool FGPMGBCCHJI([Out] float ADNBJOAKDMG, [Out] float EPECNBHCDDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct JKHKDBPHELO : IEquatable<JKHKDBPHELO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public OIAMNKPBEIJ APFJABBJNFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(OIAMNKPBEIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private OIMOBMEJAIF ONJJENNLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6D86030", Offset = "0x6D84C30", VA = "0x186D86030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private DNJBJGGECOC BBHMJJDMJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x6D92C20", Offset = "0x6D91820", VA = "0x186D92C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public bool KJECDMCDAGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x6D93190", Offset = "0x6D91D90", VA = "0x186D93190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public Vector3 LDMDDCKKDNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x6D91780", Offset = "0x6D90380", VA = "0x186D91780")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x6D92A60", Offset = "0x6D91660", VA = "0x186D92A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public Quaternion ACHKOFDELKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x6D92EB0", Offset = "0x6D91AB0", VA = "0x186D92EB0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x6D92560", Offset = "0x6D91160", VA = "0x186D92560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Vector3 LHMPEBNIPEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x6D91F40", Offset = "0x6D90B40", VA = "0x186D91F40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x6D92630", Offset = "0x6D91230", VA = "0x186D92630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public Quaternion ODLFLANDFNO
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x6D92250", Offset = "0x6D90E50", VA = "0x186D92250")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x6D92990", Offset = "0x6D91590", VA = "0x186D92990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public float AFFFNIPBCOB
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x6D91C40", Offset = "0x6D90840", VA = "0x186D91C40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x6D915E0", Offset = "0x6D901E0", VA = "0x186D915E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public float NMKIACJKDCH
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x6D911E0", Offset = "0x6D8FDE0", VA = "0x186D911E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public Vector3 AHFLHLOBPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x6D927D0", Offset = "0x6D913D0", VA = "0x186D927D0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x6D932A0", Offset = "0x6D91EA0", VA = "0x186D932A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public Vector3 HLLDPFOACDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x6D91690", Offset = "0x6D90290", VA = "0x186D91690")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public Matrix4x4 OOJKLCBFGOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x6D92CE0", Offset = "0x6D918E0", VA = "0x186D92CE0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
	public JKHKDBPHELO(JBKDGFJKCIL DKAIINNEBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x6D91BB0", Offset = "0x6D907B0", VA = "0x186D91BB0", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(JKHKDBPHELO FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x6D91B60", Offset = "0x6D90760", VA = "0x186D91B60")]
	public FJFKEFAPLLG EPHBPJLLCLH()
	{
		return default(FJFKEFAPLLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x6D91280", Offset = "0x6D8FE80", VA = "0x186D91280")]
	public void ALFCGMBILOP([Out] Matrix4x4 ICJJPDGCFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x6D93000", Offset = "0x6D91C00", VA = "0x186D93000")]
	public void NDOFALOGPJH([Out] Vector3 HGNDLDBJHAO, [Out] Quaternion BENNLELGGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x6D930E0", Offset = "0x6D91CE0", VA = "0x186D930E0")]
	public void NDOFALOGPJH([Out] RigidTransform BINEPBKBOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x6D92D20", Offset = "0x6D91920", VA = "0x186D92D20")]
	public void MJKOCKEGPKM([Out] Vector3 HGNDLDBJHAO, [Out] Quaternion BENNLELGGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x6D92E00", Offset = "0x6D91A00", VA = "0x186D92E00")]
	public void MJKOCKEGPKM([Out] RigidTransform BINEPBKBOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x6D91930", Offset = "0x6D90530", VA = "0x186D91930")]
	public UniformTRS DFMADHOOJNH()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x6D91870", Offset = "0x6D90470", VA = "0x186D91870")]
	public void DFMADHOOJNH([Out] UniformTRS MBPIJGCEGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x6D910F0", Offset = "0x6D8FCF0", VA = "0x186D910F0")]
	public UniformTRS ACFMGKAKEAH()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x6D91120", Offset = "0x6D8FD20", VA = "0x186D91120")]
	public void ACFMGKAKEAH([Out] UniformTRS BINEPBKBOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x6D913A0", Offset = "0x6D8FFA0", VA = "0x186D913A0")]
	public Vector3 ALPOKOLPIPL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x6D93370", Offset = "0x6D91F70", VA = "0x186D93370")]
	public void OHHIBMKPHEF([In] Vector3 CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x6D91E50", Offset = "0x6D90A50", VA = "0x186D91E50")]
	public Vector3 HEMNFGPPFKN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x6D91CE0", Offset = "0x6D908E0", VA = "0x186D91CE0")]
	public void FHEABHIIEKA([In] Vector3 CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D91A10", Offset = "0x6D90610", VA = "0x186D91A10")]
	public Quaternion EGNEFGJEAAE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x6D920E0", Offset = "0x6D90CE0", VA = "0x186D920E0")]
	public void HPPDLBLPIGN([In] Quaternion CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x6D91490", Offset = "0x6D90090", VA = "0x186D91490")]
	public Quaternion BMFJHBHIKOM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x6D931D0", Offset = "0x6D91DD0", VA = "0x186D931D0")]
	public void OEDDDKDMDHI([In] Quaternion CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x6D91DB0", Offset = "0x6D909B0", VA = "0x186D91DB0")]
	public float HAPDIMPOMHE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6D91960", Offset = "0x6D90560", VA = "0x186D91960")]
	public void EENJPIMNGKA(float CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x6D921B0", Offset = "0x6D90DB0", VA = "0x186D921B0")]
	public float IGOEJFFKCAH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x6D92030", Offset = "0x6D90C30", VA = "0x186D92030")]
	public void HPFGDFPILJO(float CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6D928C0", Offset = "0x6D914C0", VA = "0x186D928C0")]
	public void LDBIMFENAMO([In] Vector3 CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6D91000", Offset = "0x6D8FC00", VA = "0x186D91000")]
	public Vector3 AAGJEHEBMPL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6D93440", Offset = "0x6D92040", VA = "0x186D93440")]
	public void PJPFGIGOGAL([In] Vector3 CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6D92470", Offset = "0x6D91070", VA = "0x186D92470")]
	public Vector3 JFNFPJJMOFF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6D92700", Offset = "0x6D91300", VA = "0x186D92700")]
	public void KMGLBPAECBC([In] Vector3 CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6D92B30", Offset = "0x6D91730", VA = "0x186D92B30")]
	public Vector3 LMCBJGCKNDG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x6D923A0", Offset = "0x6D90FA0", VA = "0x186D923A0")]
	public void JBJAJHAIEOC([In] Vector3 CABLCDOIFFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct BBJICEFLLKI : IEquatable<BBJICEFLLKI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	private OIMOBMEJAIF ONJJENNLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x6D86030", Offset = "0x6D84C30", VA = "0x186D86030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	private CACJPJLNOFJ HIJGPDHINAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x6D872D0", Offset = "0x6D85ED0", VA = "0x186D872D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	private AGPHIEAKDAJ NFPJNPKBIEH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x6D870A0", Offset = "0x6D85CA0", VA = "0x186D870A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
	public BBJICEFLLKI(JBKDGFJKCIL DKAIINNEBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x6D864A0", Offset = "0x6D850A0", VA = "0x186D864A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6D87100", Offset = "0x6D85D00", VA = "0x186D87100", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x6D86400", Offset = "0x6D85000", VA = "0x186D86400", Slot = "4")]
	public bool Equals(BBJICEFLLKI FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6D86B40", Offset = "0x6D85740", VA = "0x186D86B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x6D87190", Offset = "0x6D85D90", VA = "0x186D87190")]
	public void HAFKKEABMPG(string GPACIGDFIMA, NOHIPCMMGAJ KKIIGPHCOLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class MNFKEOEPEFH
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private struct IBJHPENMECG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Guid OCIHAODAEFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public HFHBKDFGNLN EJICJKHIEIN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private struct HFHBKDFGNLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int CABLCDOIFFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int KLBMMHEFIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int IMENBELMNLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int FNEKNIKBNHP;

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x6D8CC10", Offset = "0x6D8B810", VA = "0x186D8CC10")]
		public bool ABHMMMCLCKJ([Out] IOBDJLAADBM HNOPHCFBENC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x6D8CCA0", Offset = "0x6D8B8A0", VA = "0x186D8CCA0")]
		public HFHBKDFGNLN(IOBDJLAADBM HNOPHCFBENC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x6D94600", Offset = "0x6D93200", VA = "0x186D94600")]
	public static Guid LDODKALKPCC(this IOBDJLAADBM HNOPHCFBENC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6D946A0", Offset = "0x6D932A0", VA = "0x186D946A0")]
	public static bool MAAFJKHKMFM(this Guid OCIHAODAEFD, [Out] IOBDJLAADBM HNOPHCFBENC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal static class GBKBIOFALCI
{
	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x6D8BA10", Offset = "0x6D8A610", VA = "0x186D8BA10")]
	public static CACJPJLNOFJ HIJGPDHINAE(this JBKDGFJKCIL MJDOIIBKEKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6D8B940", Offset = "0x6D8A540", VA = "0x186D8B940")]
	public static BIOJOMCAEIE GFOAIEOFDDJ(this JBKDGFJKCIL MJDOIIBKEKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6D8B840", Offset = "0x6D8A440", VA = "0x186D8B840")]
	public static EntityManager EHDJNFFGDFL(this JBKDGFJKCIL MJDOIIBKEKN)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC410", Offset = "0x2DFB010", VA = "0x182DFC410")]
	internal static bool OKCPPEHGHGN<T>(this JBKDGFJKCIL MJDOIIBKEKN, bool BFJLCIKEACO) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6D8B650", Offset = "0x6D8A250", VA = "0x186D8B650")]
	public static bool BGKCMKFFGDG(this JBKDGFJKCIL MJDOIIBKEKN, OPMAHOIMEIC OPOMMFAAAOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2DF8B90", Offset = "0x2DF7790", VA = "0x182DF8B90")]
	public static bool FCOAAIJCNDB<T>(this JBKDGFJKCIL MJDOIIBKEKN) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC360", Offset = "0x2DFAF60", VA = "0x182DFC360")]
	public static bool NGHLLLOGELE<T>(this JBKDGFJKCIL MJDOIIBKEKN) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2DFAE20", Offset = "0x2DF9A20", VA = "0x182DFAE20")]
	[LONDHIMBNDF]
	public static T KKEPCHJFKDC<T>(this JBKDGFJKCIL MJDOIIBKEKN) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2DF8E10", Offset = "0x2DF7A10", VA = "0x182DF8E10")]
	[LONDHIMBNDF]
	public static T GEGMFDFADLF<T>(this JBKDGFJKCIL MJDOIIBKEKN) where T : struct, IComponentData
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BFNGOOHGMMN
{
	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JEBCEPHFAFH(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GLKJHHFEMNG(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DCGHANFGOEG(JBKDGFJKCIL DKAIINNEBFL, [Out] Guid JHHAGEEOAEN);

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid KDENGCEGKEP(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MMOLDBLDLEH(JBKDGFJKCIL DKAIINNEBFL, Guid JHHAGEEOAEN);

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NEHFNGLFJOM(JBKDGFJKCIL DKAIINNEBFL, [Out] Guid KPGLKHEJBED);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid MBOICPPKOPN(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NCAMIIAPAGI(JBKDGFJKCIL DKAIINNEBFL, Guid KPGLKHEJBED);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HGFBEINDODP(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task LGLHABOLPLK(JBKDGFJKCIL MADODMHNENF, JBKDGFJKCIL CDBGCEIGNJC);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface AEDEGKKCCBF
{
	[Cpp2IlInjected.Token(Token = "0x17000177")]
	Guid IIKADJIPLIK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CMIFILOGGPP(NativeList<Guid> LFOBOHKPCFF, NativeList<Guid> ICJIJKPKEBP, NativeList<FixedString64Bytes> OKLNGLIBGIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AOHHHJIMCMA
{
	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DKEBAIKGGAK(List<JBKDGFJKCIL> PFKMPPGHGPB);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HFJKKGCIKMA(List<JBKDGFJKCIL> ODCEKOLHHJF);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KFIHMEMIGHP(JBKDGFJKCIL IGNNJCLPPOC);

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LPIFEHIIIAO(JBKDGFJKCIL IGNNJCLPPOC);

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NKGNKLGBFDB(JBKDGFJKCIL IGNNJCLPPOC);

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int CHPLDPBICPI(JBKDGFJKCIL IGNNJCLPPOC);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NCEFDIAGFAC(JBKDGFJKCIL IGNNJCLPPOC, int EKDFELJLMMH);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JBKDGFJKCIL DMFGJKLEJOD(JBKDGFJKCIL KIJPICMGKJC);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int EKKLIDJAINK(JBKDGFJKCIL KIJPICMGKJC);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NDGEMKLMOJK(JBKDGFJKCIL KIJPICMGKJC, int MGBDJNLKOLA);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int OLMLMFCPJMH(JBKDGFJKCIL KIJPICMGKJC);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DBOPCGHKKOI(JBKDGFJKCIL KIJPICMGKJC, int CGHBGINMCME);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NIMJEOEIHIJ(JBKDGFJKCIL IMOBCMCECHO);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GPKLFPGLPIC(JBKDGFJKCIL DKAIINNEBFL, bool FHOHAGAOKHH);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KHGGAPPIEEL(JBKDGFJKCIL[] CNEBDANMKHA, bool FHOHAGAOKHH);
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OPPJMHCBPNM
{
	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IOBDJLAADBM[] PIHJBAHGKIG(string GMBAACDNNFI, BDGGMOHGNEL JINCADBNFOA, bool DDHEKJDPOMO = false);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ODDLHDIONPP(string MFPCKNHBBHM, IOBDJLAADBM[] OCOGHNMIAAF);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface IIONMFDLBIG
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<JBKDGFJKCIL, JBKDGFJKCIL> INPFFJJLNNK;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<JBKDGFJKCIL, JBKDGFJKCIL> DNHFDMPAEPJ;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<JBKDGFJKCIL, JBKDGFJKCIL, JBKDGFJKCIL> HKOPFNEJHDL;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<JBKDGFJKCIL> NGGGMFHFKML;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DOJJMGPCMIG(JBKDGFJKCIL DKAIINNEBFL, JBKDGFJKCIL BFAFGEHJBEJ);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JBKDGFJKCIL ELMPNLMDDDC(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DBLPDLFFIKD IKFLHKANAEC(JBKDGFJKCIL DKAIINNEBFL, Allocator ICLGONBNBJO);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	JBKDGFJKCIL EFFHFOAMOJL(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EMOHKOMJLBA(JBKDGFJKCIL DKAIINNEBFL, Vector3 IPHLOHGCGMJ, Quaternion BBGFLNFMMOM);

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BPOOIIJOJGN(JBKDGFJKCIL DKAIINNEBFL, float OHFKKMGCGEN);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool MNMKIGCEMMI(JBKDGFJKCIL DKAIINNEBFL, [Out] JBKDGFJKCIL CDBGCEIGNJC);

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool APENMBEFPKM(JBKDGFJKCIL DKAIINNEBFL, [Out] RigidTransform CBFOIIECFFP);

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool KKKJJLCGJCO(JBKDGFJKCIL DKAIINNEBFL, [Out] float KGOLINIHNCJ);

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 BLFGDFCNFNC(OJKKAEEMNAO BGFPAPJDPKA);

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	quaternion DCHOOOCJANP(OJKKAEEMNAO BGFPAPJDPKA);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class OKBDFKPEBIK
{
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface JEBGGLFMBOH
{
	[Cpp2IlInjected.Token(Token = "0x17000178")]
	object NBLMAPKAOLH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APCKEGINAKG(DBLPDLFFIKD CNEBDANMKHA);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public readonly struct KHCOHKEDONF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly string GMBAACDNNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly T IEDAFAANJNE;

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x42BAE70", Offset = "0x42B9A70", VA = "0x1842BAE70")]
	public KHCOHKEDONF(T IEDAFAANJNE, [Optional][CallerMemberName] string GMBAACDNNFI)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public static readonly KHCOHKEDONF<int> AKIODIDIOMB;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly KHCOHKEDONF<int> JPJLOEHANJI;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public static readonly KHCOHKEDONF<int> DFOCNGMEKGE;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public enum EJBIFDKLCMI
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class PJEGGMPKGCP
{
	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0xF509E0", Offset = "0xF4F5E0", VA = "0x180F509E0")]
	public static bool DEKBEFACGIC(this EJBIFDKLCMI GFCPLDIMNPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0xF509F0", Offset = "0xF4F5F0", VA = "0x180F509F0")]
	public static bool KNNFHELKKLC(this EJBIFDKLCMI GFCPLDIMNPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x272A1E0", Offset = "0x2728DE0", VA = "0x18272A1E0")]
	public static bool KBDENMMHDGD(this EJBIFDKLCMI GFCPLDIMNPM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface LDNOMBFMEPC
{
	[Cpp2IlInjected.Token(Token = "0x17000179")]
	bool GJBPLEMJIKM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[ServiceLifetime(Lifetime.Application)]
public interface MFJEFENKHHN
{
	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	EJBIFDKLCMI OAFLJNOLCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	EJBIFDKLCMI JNOOFNDBBED
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	EJBIFDKLCMI FIGEMEIIDNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	EJBIFDKLCMI GBKEAFBIGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	EJBIFDKLCMI NJBFDDFIEHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	EJBIFDKLCMI OLEKOEAACMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	EJBIFDKLCMI FPJHEIBCOEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	EJBIFDKLCMI CCDFIBCNKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	EJBIFDKLCMI BJKGDIMBAGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	EJBIFDKLCMI NNDJGPDPNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	EJBIFDKLCMI PCNKACEKOPH
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	EJBIFDKLCMI ACGJKLIAFCB
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	EJBIFDKLCMI NHDEEEOGPME
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	EJBIFDKLCMI FGFGAAIFPFP
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	EJBIFDKLCMI HMOFKOACLNE
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	EJBIFDKLCMI LOGFIJPPFDB
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int IBIJBNAFKLE(KHCOHKEDONF<int> NLEDHKLDJJG);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PGJHHNGEJGI
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event JNKILMALILB.JOJIMKAEEJC NFLMAEDHAII;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JBKDGFJKCIL HDKDGJIFOAP(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CNOAGJNOLOJ(List<JBKDGFJKCIL> ODCEKOLHHJF);

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KDOGGLNNCFG LCEHHKNGKDN(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JFOHGCCEIIP(IEnumerable<JBKDGFJKCIL> BLIAFFKBIDO);

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KDOGGLNNCFG KFDHCICIAJC(JBKDGFJKCIL CDBGCEIGNJC, JBKDGFJKCIL FCAIJJGOPCC, bool MKMFPJMCHOP, JBKDGFJKCIL CGJNNJHBPPG);

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JBKDGFJKCIL ABELJLHOKHJ(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EOIGELPPMDL(JBKDGFJKCIL DKAIINNEBFL, JBKDGFJKCIL CDBGCEIGNJC, bool HEAKKLLNAOG = false);

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool DEMBJCGELBM(JBKDGFJKCIL DKAIINNEBFL, JBKDGFJKCIL CDBGCEIGNJC);

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KBBDPCAKFGE(JBKDGFJKCIL LPCKILEHBJP, JBKDGFJKCIL ADFJEKLAHPL);

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int MFHBGCEBEIM(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DBLPDLFFIKD GIMLAMEMIAG(JBKDGFJKCIL IMOBCMCECHO);

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<JBKDGFJKCIL> NGHCJDOEEEL(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool DBNGAOPPOCA(JBKDGFJKCIL DKAIINNEBFL, JBKDGFJKCIL MCGMEGCEAFP);

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IEnumerable<JBKDGFJKCIL> IOHHFIGNKGM(JBKDGFJKCIL DKAIINNEBFL, bool HGAHCLBDEPP = false);

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool GMCCOEOCHND(JBKDGFJKCIL DKAIINNEBFL, JBKDGFJKCIL OMPOBHCLMBI);

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "17")]
	JBKDGFJKCIL JMFBJHMPIGN(JBKDGFJKCIL CGJNNJHBPPG, JBKDGFJKCIL BMIIIJAOGMM);

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool LFCGFAPBEFN(JBKDGFJKCIL CGJNNJHBPPG, JBKDGFJKCIL BMIIIJAOGMM, [Out] JBKDGFJKCIL MFNEGCKHFIO);

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "19")]
	JBKDGFJKCIL JHKFLLPDJPK(JBKDGFJKCIL[] CNEBDANMKHA);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class NLIBKFAAOIN
{
	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x6D96450", Offset = "0x6D95050", VA = "0x186D96450")]
	public static List<JBKDGFJKCIL> CNOAGJNOLOJ(this PGJHHNGEJGI OAPHHHCNFOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x6D963E0", Offset = "0x6D94FE0", VA = "0x186D963E0")]
	public static bool CIIKKBJHNAF(this PGJHHNGEJGI OAPHHHCNFOF, JBKDGFJKCIL DKAIINNEBFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface DADPHLLPINM
{
	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AALAMJMKCOL CFAJODHKMEE(JBKDGFJKCIL IGNNJCLPPOC);

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DJIGKNHNDDA(JBKDGFJKCIL IGNNJCLPPOC, AALAMJMKCOL LHNGFPHCODI);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ONHBKOPAOBD(JBKDGFJKCIL IGNNJCLPPOC);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FPLBGFGNBGH(JBKDGFJKCIL IGNNJCLPPOC, bool CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string[] FCAABFCDMNN(JBKDGFJKCIL IGNNJCLPPOC);

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AEEMALPKPHF(JBKDGFJKCIL IGNNJCLPPOC, IEnumerable<string> IONNJJHBKGH);

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string[] OMBFGPPCCDO(JBKDGFJKCIL IGNNJCLPPOC);

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FKPHKGDKPOM(JBKDGFJKCIL IGNNJCLPPOC, IEnumerable<string> IONNJJHBKGH);

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	string[] PIKOGMHENHC(JBKDGFJKCIL IGNNJCLPPOC);

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EJCDNJKNJNE(JBKDGFJKCIL IGNNJCLPPOC, IEnumerable<string> IONNJJHBKGH);

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string[] ACDEFEJGNDH(JBKDGFJKCIL IGNNJCLPPOC);

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PIIIFFDIFCC(JBKDGFJKCIL IGNNJCLPPOC, IEnumerable<string> IONNJJHBKGH);

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool OANANAMBJCA(JBKDGFJKCIL IGNNJCLPPOC, JBKDGFJKCIL PMNDEDNNDFE);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface PKKJIOEKPJA
{
	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	bool NONIEEMHPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	bool FFKADMMFKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	bool FMBCLPNDNEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JELPHIIIAHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DCAKELKIAPC([In] float3 NLLHBHEGIHB, [In] float3 EJOHIEANBFL, float GHBEHFGEGMI, [Out] AEPMKKGEDKM OLDKEPAFINH, [Out] JBKDGFJKCIL HICFJNJABJI);
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GGNHLOHNLOM
{
	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCAKELKIAPC([In] NativeArray<Entity> BHNJCFOPBNC, [In] float3 NLLHBHEGIHB, [In] float3 EJOHIEANBFL, [In] NativeArray<AEPMKKGEDKM> HKHGAGNHJNB);
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct PGCAALCHAGJ : HLDDCBEIKDI, IEquatable<PGCAALCHAGJ>
{
	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public int NAJFJJKNBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xA0B980", Offset = "0xA0A580", VA = "0x180A0B980", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xB227D0", Offset = "0xB213D0", VA = "0x180B227D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public int EJLEFLLIODH
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x2746650", Offset = "0x2745250", VA = "0x182746650", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5D80", Offset = "0x5FB4980", VA = "0x185FB5D80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6D98D20", Offset = "0x6D97920", VA = "0x186D98D20", Slot = "8")]
	public bool Equals(PGCAALCHAGJ FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x6D98D70", Offset = "0x6D97970", VA = "0x186D98D70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct AEPMKKGEDKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public float DHBCKDCJDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float3 DJCDKMIHKHG;
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GLMNLLJIEAC
{
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OIMOBMEJAIF
{
	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	CACJPJLNOFJ HIJGPDHINAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	MNGLAGDKHKA GPOEMAPMJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<DBLPDLFFIKD, NativeArray<EKPAFNPHKFE>> KAGDIOGFOHA;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<DBLPDLFFIKD> HHHCCPKJMIE;

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NDECBIIJMKP OHBADEGIHMK(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EKPAFNPHKFE KGNAPDJEAMI(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PEGPHNFMEDB(IOBDJLAADBM HNOPHCFBENC, FNNOGNIONBO KMCBLHBGCPK);

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GAHEBJGIKCN(IOBDJLAADBM[] OCOGHNMIAAF, GameObject DKOODDCANLH);

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BDGGMOHGNEL CEPADAGMGPF(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NPKJOKDOJLB(JBKDGFJKCIL DKAIINNEBFL, [Out] Transform OHCKGBMFMEE);

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool FIEBFPOFEAG(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NCFDFHICEEE(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	JBKDGFJKCIL KEGHICFGFBF(IOBDJLAADBM HNOPHCFBENC);

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool GBLFCMOJMOJ(IOBDJLAADBM HNOPHCFBENC, [Out] JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IOBDJLAADBM BGFFGNINDHK(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	DBLPDLFFIKD KEGHICFGFBF(NativeArray<IOBDJLAADBM> HNOPHCFBENC, Allocator ICLGONBNBJO);

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(Slot = "18")]
	DBLPDLFFIKD KHFKHPONEAD(EKPAFNPHKFE LMKPBPFJEKM, int KNHHBEFLJAF, Allocator ICLGONBNBJO);

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "19")]
	DBLPDLFFIKD JCHNIDPOBPK(NativeArray<IOBDJLAADBM> HNOPHCFBENC, NativeArray<JGOLJJMIDIM> PLIFAKCKLMA, Allocator ICLGONBNBJO);

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IOBDJLAADBM[] PIHJBAHGKIG(string MFPCKNHBBHM, BDGGMOHGNEL JINCADBNFOA, bool DDHEKJDPOMO);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void ODDLHDIONPP(string MFPCKNHBBHM, IOBDJLAADBM[] OCOGHNMIAAF);

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "22")]
	BDGGMOHGNEL MIEICEMCCNI(EKPAFNPHKFE LMKPBPFJEKM, bool FJBNPOHDKBC);

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "23")]
	BDGGMOHGNEL MIEICEMCCNI(EKPAFNPHKFE LMKPBPFJEKM);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "24")]
	BDGGMOHGNEL BHPKPLBCJHJ(EKPAFNPHKFE LMKPBPFJEKM);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "25")]
	BDGGMOHGNEL KGNGCBNFANM(EKPAFNPHKFE LMKPBPFJEKM);

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "26")]
	BDGGMOHGNEL HHENBLPFHPO(IOBDJLAADBM HNOPHCFBENC, EKPAFNPHKFE LMKPBPFJEKM);

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "27")]
	IGHLONOGEFM HFBMBFDIOPN();

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "28")]
	GJGOCLGMFFN PNHLGIOMDJJ();

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	MLOPJMEMPIM MHEFGJDKLIL(FLDGGDEOLHM GKFAOEHGABL);

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void IFIKJAGMLDP(DBLPDLFFIKD CNEBDANMKHA);

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void PAMNEBLPMKL(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void GPCLHKHOAKL(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void IFIKJAGMLDP(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void CBKPBIMKIIA(JBKDGFJKCIL CNEBDANMKHA);

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool HBIEICLGOIE(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "36")]
	DBLPDLFFIKD ONFIJNHKOHL(DBLPDLFFIKD FKJGOLLHJND, Allocator ICLGONBNBJO);

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool AMOCDEJOLHN(JBKDGFJKCIL DKAIINNEBFL);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class PAMACJEJGKC
{
	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x6D98CA0", Offset = "0x6D978A0", VA = "0x186D98CA0")]
	public static void NCFDFHICEEE(this OIMOBMEJAIF KKIIGPHCOLG, FNNOGNIONBO KMCBLHBGCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6D986F0", Offset = "0x6D972F0", VA = "0x186D986F0")]
	public static BDGGMOHGNEL BDJDPLFNNAM(this OIMOBMEJAIF KKIIGPHCOLG, LocalId DKAIINNEBFL)
	{
		return default(BDGGMOHGNEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x6D98690", Offset = "0x6D97290", VA = "0x186D98690")]
	public static BDGGMOHGNEL BDJDPLFNNAM(this OIMOBMEJAIF KKIIGPHCOLG, IOBDJLAADBM HNOPHCFBENC)
	{
		return default(BDGGMOHGNEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x6D986F0", Offset = "0x6D972F0", VA = "0x186D986F0")]
	public static JBKDGFJKCIL KEGHICFGFBF(this OIMOBMEJAIF KKIIGPHCOLG, LocalId DKAIINNEBFL)
	{
		return default(JBKDGFJKCIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6D98720", Offset = "0x6D97320", VA = "0x186D98720")]
	public static IOBDJLAADBM BGFFGNINDHK(this OIMOBMEJAIF KKIIGPHCOLG, LocalId DKAIINNEBFL)
	{
		return default(IOBDJLAADBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6D98620", Offset = "0x6D97220", VA = "0x186D98620")]
	public static bool AMOCDEJOLHN(this OIMOBMEJAIF KKIIGPHCOLG, IOBDJLAADBM HNOPHCFBENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x6D98AA0", Offset = "0x6D976A0", VA = "0x186D98AA0")]
	public static IGHLONOGEFM GMEKGALJOFK(this OIMOBMEJAIF KKIIGPHCOLG, RigidTransform MBPIJGCEGKG)
	{
		return default(IGHLONOGEFM);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6D987A0", Offset = "0x6D973A0", VA = "0x186D987A0")]
	public static MLOPJMEMPIM EFBENMKOOCF(this OIMOBMEJAIF KKIIGPHCOLG, FLDGGDEOLHM GAABCMMGDNL, RigidTransform MBPIJGCEGKG)
	{
		return default(MLOPJMEMPIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x6D98BA0", Offset = "0x6D977A0", VA = "0x186D98BA0")]
	public static GJGOCLGMFFN KIIKFKLCAOO(this OIMOBMEJAIF KKIIGPHCOLG, RigidTransform MBPIJGCEGKG)
	{
		return default(GJGOCLGMFFN);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x6D988A0", Offset = "0x6D974A0", VA = "0x186D988A0")]
	private static void FHGBMNFMAJK(BDGGMOHGNEL IAFHDHFOLBD, RigidTransform MBPIJGCEGKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface GKOGPPBOBDA
{
	[Cpp2IlInjected.Token(Token = "0x17000191")]
	bool DNECOCAMENL
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	JBKDGFJKCIL FFOLJPDBOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	BDGGMOHGNEL LMOHIIFLIPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event KCGNDFKLLBM FLOHBNBPENE;

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JBKDGFJKCIL JMFBJHMPIGN(JBKDGFJKCIL CGJNNJHBPPG, JBKDGFJKCIL BMIIIJAOGMM);

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LFCGFAPBEFN(JBKDGFJKCIL CGJNNJHBPPG, JBKDGFJKCIL BMIIIJAOGMM, [Out] JBKDGFJKCIL MFNEGCKHFIO);

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IFBBPMNGNLO();

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IPILIEFMLKD();

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool BDOOAHNDHGH(JBKDGFJKCIL CGJNNJHBPPG);

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool OGJGGJLAHAG(JBKDGFJKCIL CGJNNJHBPPG);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public delegate void KCGNDFKLLBM(BDGGMOHGNEL GDBMIKFJIGL, BDGGMOHGNEL DIOBMBHKHOO);
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class JJCJBAOECLK
{
	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6D90F30", Offset = "0x6D8FB30", VA = "0x186D90F30")]
	public static bool DGNJMGMLMMB(this GKOGPPBOBDA NONGLLOLAOH, BDGGMOHGNEL CGJNNJHBPPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6D90E50", Offset = "0x6D8FA50", VA = "0x186D90E50")]
	public static bool AGHIECLALCP(this GKOGPPBOBDA NONGLLOLAOH, JBKDGFJKCIL CGJNNJHBPPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6D90F80", Offset = "0x6D8FB80", VA = "0x186D90F80")]
	public static bool FKGLCMEBLLI(this GKOGPPBOBDA NONGLLOLAOH, JBKDGFJKCIL CGJNNJHBPPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NIKBMHJNLNF
{
	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OOEIEFFNOEK(BDGGMOHGNEL IAFHDHFOLBD, AFHJIGHFEFH CHCPEAEKFEB, List<BDGGMOHGNEL> CBFFADJCEPD);

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int CHEMDIELHJK(BDGGMOHGNEL IAFHDHFOLBD, AFHJIGHFEFH CHCPEAEKFEB);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HMCNLFGKHMB(BDGGMOHGNEL IAFHDHFOLBD, List<BDGGMOHGNEL> CBFFADJCEPD);

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IJKLJNFANMB(BDGGMOHGNEL LCMKGCMMEHM, BDGGMOHGNEL CGJNNJHBPPG, AFHJIGHFEFH CHCPEAEKFEB);

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BDGGMOHGNEL CLMNFAHLNDG(BDGGMOHGNEL LCMKGCMMEHM, int MFJLAMOCOBC, AFHJIGHFEFH CHCPEAEKFEB);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CLDFJBPOMLC(BDGGMOHGNEL LCMKGCMMEHM, BDGGMOHGNEL CGJNNJHBPPG, AFHJIGHFEFH CHCPEAEKFEB);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LJHGBJCGPJC(BDGGMOHGNEL LCMKGCMMEHM, BDGGMOHGNEL CGJNNJHBPPG, AFHJIGHFEFH CHCPEAEKFEB);

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AJPMDJBCEJD(BDGGMOHGNEL LCMKGCMMEHM, AFHJIGHFEFH CHCPEAEKFEB);

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LJPKBLLMELP(BDGGMOHGNEL LCMKGCMMEHM, BDGGMOHGNEL CGJNNJHBPPG, AFHJIGHFEFH CHCPEAEKFEB);

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EELNJEOFIKB(Entity LCMKGCMMEHM, Entity CGJNNJHBPPG, AFHJIGHFEFH CHCPEAEKFEB);

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AHNBHBCPFHJ(Entity LCMKGCMMEHM, AFHJIGHFEFH CHCPEAEKFEB);

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool HLGLKGEEPNB(BDGGMOHGNEL CGJNNJHBPPG, AFHJIGHFEFH CHCPEAEKFEB);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NLDOCEBEMPD
{
	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPDCIPBIMCB(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KNGCBIJGFKM(JBKDGFJKCIL DKAIINNEBFL, Transform OHCKGBMFMEE);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EHAMHHHNAID
{
	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LGONLDJGCHP(JBKDGFJKCIL CGJNNJHBPPG, JBKDGFJKCIL DJDCHEPHJIB);

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PJDIGLCADCI(JBKDGFJKCIL CGJNNJHBPPG, JBKDGFJKCIL EIFKNJHEOOE);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DNIODCKDLEF(JBKDGFJKCIL CGJNNJHBPPG, [Out] JBKDGFJKCIL AIPODLJPHHM);
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface JDDAFONGDAI
{
	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MCIBGCONIDP(JBKDGFJKCIL IMOBCMCECHO, bool CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMAHIMGBFHN(JBKDGFJKCIL IMOBCMCECHO, bool CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ONNLCKGCPOB(JBKDGFJKCIL IMOBCMCECHO, int CABLCDOIFFL);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface EMKCMJJEJCB
{
	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<JBKDGFJKCIL> DLBOJGKGKJC(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JBKDGFJKCIL LICMMMMPGBJ(JBKDGFJKCIL DKAIINNEBFL, int MFJLAMOCOBC);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int EMAEFFNCLDM(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ENKLMLKMLJC FADKJAEGFMK(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MNCOJNJPFEF(JBKDGFJKCIL DKAIINNEBFL, ENKLMLKMLJC HHLMDDDPFNI);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JBKDGFJKCIL PPFPHCJJDJI(JBKDGFJKCIL DKAIINNEBFL, [Optional] float3? GKJAMFFKDLE, [Optional] quaternion? EAGKGJHHIJH, [Optional] float3? IMPGFCOPLND);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JBKDGFJKCIL BMFBDABEJNJ(JBKDGFJKCIL DKAIINNEBFL, int MFJLAMOCOBC, [Optional] float3? GKJAMFFKDLE, [Optional] quaternion? EAGKGJHHIJH, [Optional] float3? IMPGFCOPLND);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EEGCKIHIJLM(JBKDGFJKCIL DKAIINNEBFL, int MFJLAMOCOBC);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DCELLFIILCC(JBKDGFJKCIL DKAIINNEBFL);
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MHFEHKCMKNI
{
	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CNECMLNHFNL();

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BKACBIOMBND();

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KHHJEGLHECC();

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DNLLDIGDANE();

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NGKEBBEIMPN();

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KHAPIBMDPKG();

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KOIHGPLIMDL();

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MBEHEGGGPMA();

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PPFICDFCBOP();

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AOLCIBLJCBF();

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BLLBOOILCEA();

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HHPAJAMCMPB();

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ALEEMHEOOKF();
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface DOFMNPCIHHG
{
	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JEILMCMAKNB(JBKDGFJKCIL CGJNNJHBPPG, [Out] int LCMKGCMMEHM);

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FIPBKGFOAIE(JBKDGFJKCIL CGJNNJHBPPG, int LCMKGCMMEHM);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IPGLHEJHDOH(JBKDGFJKCIL CGJNNJHBPPG, bool GBGGBOMPGNA);

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FNENGMNIONA(JBKDGFJKCIL CGJNNJHBPPG, float AMNDAJBPIEC, float OOCKGELNLCO, float KGKLOGECBMG);

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FGPMGBCCHJI(JBKDGFJKCIL DKAIINNEBFL, [Out] float OOCKGELNLCO, [Out] float KGKLOGECBMG);

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IELLIPEAEEK(JBKDGFJKCIL CGJNNJHBPPG, float3 GKJAMFFKDLE, quaternion EAGKGJHHIJH);

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ODMAGPMPCAE(JBKDGFJKCIL CGJNNJHBPPG, [Out] float3 GKJAMFFKDLE, [Out] quaternion EAGKGJHHIJH);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DNJBJGGECOC
{
	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NBKFPHKKFLK(Entity OKNDNPBNCCC);

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OHHIBMKPHEF(Entity OKNDNPBNCCC, [In] float3 CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 ALPOKOLPIPL(Entity OKNDNPBNCCC);

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HPPDLBLPIGN(Entity OKNDNPBNCCC, [In] quaternion CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion EGNEFGJEAAE(Entity OKNDNPBNCCC);

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FMKMHPMIDJM(Entity OKNDNPBNCCC, [In] float3 GKJAMFFKDLE, [In] quaternion EAGKGJHHIJH);

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NDOFALOGPJH(Entity OKNDNPBNCCC, [Out] float3 GKJAMFFKDLE, [Out] quaternion EAGKGJHHIJH);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NDOFALOGPJH(Entity OKNDNPBNCCC, [Out] RigidTransform HOBHIBIMIAF);

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MJKOCKEGPKM(Entity OKNDNPBNCCC, [Out] float3 GKJAMFFKDLE, [Out] quaternion EAGKGJHHIJH);

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MJKOCKEGPKM(Entity OKNDNPBNCCC, [Out] RigidTransform HOBHIBIMIAF);

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float3 BDABNCKMDGP(Entity OKNDNPBNCCC);

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LDBIMFENAMO(Entity OKNDNPBNCCC, [In] float3 CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EENJPIMNGKA(Entity OKNDNPBNCCC, float CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float HAPDIMPOMHE(Entity OKNDNPBNCCC);

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KMGLBPAECBC(Entity OKNDNPBNCCC, [In] float3 CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 JFNFPJJMOFF(Entity OKNDNPBNCCC);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FHEABHIIEKA(Entity OKNDNPBNCCC, [In] float3 CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 HEMNFGPPFKN(Entity OKNDNPBNCCC);

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OEDDDKDMDHI(Entity OKNDNPBNCCC, [In] quaternion CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	quaternion BMFJHBHIKOM(Entity OKNDNPBNCCC);

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 AAGJEHEBMPL(Entity OKNDNPBNCCC);

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void PJPFGIGOGAL(Entity OKNDNPBNCCC, [In] float3 CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void HPFGDFPILJO(Entity OKNDNPBNCCC, float CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float IGOEJFFKCAH(Entity OKNDNPBNCCC);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JBJAJHAIEOC(Entity OKNDNPBNCCC, [In] float3 CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float3 LMCBJGCKNDG(Entity OKNDNPBNCCC);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void HDKIKHANEMO(Entity OKNDNPBNCCC, [Out] float4x4 ICJJPDGCFNI);

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void CPBAFCFGHHH(Entity OKNDNPBNCCC, [In] float4x4 ICJJPDGCFNI);

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void PCCOFMMLKOK(Entity OKNDNPBNCCC, [Out] float4x4 ICJJPDGCFNI);

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool NPKJOKDOJLB(Entity OKNDNPBNCCC, [Out] Transform OHCKGBMFMEE);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void PKIOJNHNNCM(Entity OKNDNPBNCCC);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void BHAOPMNOBBB(Entity OKNDNPBNCCC, Entity ANOJJEOFNJL, Entity NDJJLBGHFGF);
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class JDEBKFPINNM
{
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MJJJDBAHEPH
{
	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFBLDKDKPOJ(bool GJPNLIHNAHA);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface AGPHIEAKDAJ
{
	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CIMJFAEJOBF(JBKDGFJKCIL IGNNJCLPPOC, IEnumerable<string> IONNJJHBKGH);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HHJLEMLMGGG(JBKDGFJKCIL IGNNJCLPPOC, IEnumerable<string> IONNJJHBKGH);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KGGACAPOCDE(JBKDGFJKCIL IGNNJCLPPOC, params string[] IONNJJHBKGH);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EHEOKDEEEPI(JBKDGFJKCIL IGNNJCLPPOC, params string[] IONNJJHBKGH);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ADIGCBADLED(JBKDGFJKCIL IGNNJCLPPOC, params string[] IONNJJHBKGH);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HBKHLODNEKH(JBKDGFJKCIL IGNNJCLPPOC, params string[] IONNJJHBKGH);

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int KEKCJGADNPP(JBKDGFJKCIL IGNNJCLPPOC);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int GFHCNAABMEP(JBKDGFJKCIL IGNNJCLPPOC);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EHHCGNFILAC(JBKDGFJKCIL IGNNJCLPPOC, ICollection<string> MACLLJELKMA);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BBIFMFLACKL(JBKDGFJKCIL IGNNJCLPPOC, ICollection<string> MACLLJELKMA);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool PMJEHCICFNK(JBKDGFJKCIL IGNNJCLPPOC, string GPACIGDFIMA);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DPCIOCNOMFJ(string GPACIGDFIMA, NOHIPCMMGAJ GDFGFOOBMLG);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	JBKDGFJKCIL CFCPAIBFNMF(string GPACIGDFIMA);

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OBNIOCGOOAP(string GPACIGDFIMA, NOHIPCMMGAJ GDFGFOOBMLG);

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HAFKKEABMPG(JBKDGFJKCIL FIGLGIICPLF, string GPACIGDFIMA, NOHIPCMMGAJ GDFGFOOBMLG);

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool BBJBBBKFEOH();

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CFJPDJOKMNH(IEnumerable<string> IONNJJHBKGH);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FEBOJLMABPL
{
	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World HAGDCKINLKF(string NAIOGNOHGMN = "Main");

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World EPJDBNBNLDD(string NAIOGNOHGMN = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World NNAMHPNLNJD(string NAIOGNOHGMN = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World HPOEBAECGML(string NAIOGNOHGMN = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BIOJOMCAEIE
{
	[Cpp2IlInjected.Token(Token = "0x17000194")]
	World EIHMKCGBGCO
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	World MJDAGNFOOMB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	EntityManager EHDJNFFGDFL
	{
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	bool LNEBBFIJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase LHNKCOMNGJC(Type FIFJJNIIAPF);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class JALJLCPJNOI
{
	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x6D90430", Offset = "0x6D8F030", VA = "0x186D90430")]
	public static ComponentSystemBase DDFDPHMAKGK(this World CHCPMCFMNCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x2E7B560", Offset = "0x2E7A160", VA = "0x182E7B560")]
	public static T LHNKCOMNGJC<T>(this BIOJOMCAEIE BEHIIDLIIIB) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface AHMOACPNAJI
{
	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNCDJMBHAFE(NativeListAsync<Entity> JOGGIPFBJNI);

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NMGPEGJIHCO(HNAOEMJOLDG NMPDKADDJNK);

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JFIDMMFLCHN(NativeListAsync<Entity> MOBAGADHNEB, bool PGAIPAODKNE);

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MPEKGFBHGPP();
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface CGBHCCJLCEB
{
	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KHPBKICLDAO(Collider OBPELBJIGMM, [Out] CBNMDOLKPAM OCGEFLDBEMO);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface CCJEHMLGOEJ
{
	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider COGADFLLNDK(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject NLJAGNJNIBE(JBKDGFJKCIL GCDCIHMLDKD, GameObject LNKGJNJHIPL, Vector3 APNDNNBECGB, Quaternion NDNBHPBJOKJ);

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OMFBMLFPCIB(GameObject OBPELBJIGMM);

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider DBDMKLILLEL<TCollider>(GameObject NAKAFKCPLKN) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AGPKMIAIHOD(Collider OBPELBJIGMM);

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject BIDPGFLFELN<TCollider>(string GMBAACDNNFI) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public enum HGMNMLOPJHG
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
[Cpp2IlInjected.Token(Token = "0x2000094")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface HMEHHLPADPE
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public struct NPABOHFELJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int IBJEGPMINPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public GameObject LNKGJNJHIPL;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LAJKNMHJJOL(JBKDGFJKCIL DKAIINNEBFL, PFAGBDBNINI ENNNCMNOONC, bool CBNGLFDGNKH, NCAHLIGACJD FIMLIAMGMMO);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IBDONMFGCDG(JBKDGFJKCIL DKAIINNEBFL, PFAGBDBNINI ENNNCMNOONC, bool CBNGLFDGNKH, bool PMBICMHLEHO, bool NFPMGEHBLCN);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CFIKKAPKJEG BKCDAPOPCIE(JBKDGFJKCIL AHFIDHNOIFE, List<JBKDGFJKCIL> LLJKCAHFACF);

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CCCNKIBJHIO(GameObject IOLPPGGHHFH, GameObject BDHCEAFHADI);

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ECJLEAEBJFE(GameObject IOLPPGGHHFH, List<GameObject> CIEOMANEBPJ);

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DBDEPIKDMGO(GameObject BDHCEAFHADI);

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T DBDMKLILLEL<T>(GameObject NAKAFKCPLKN) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AGPKMIAIHOD(Collider OBPELBJIGMM);

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BHMPOPHNHDK(DBLPDLFFIKD DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HDEEAODFHOA(DBLPDLFFIKD DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GameObject JLLMKLDKBCA<T>(string GMBAACDNNFI) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool BEOGKEKEJKL(Collider OBPELBJIGMM, [Out] JBKDGFJKCIL LCMKGCMMEHM);

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool CGIAFDFMJBC(JBKDGFJKCIL DKAIINNEBFL, [Out] CBNMDOLKPAM OCGEFLDBEMO);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<HGMNMLOPJHG> OOOPFELAJEP(Allocator ICLGONBNBJO = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Mesh[] DBFLKEFLMOP();

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int HGAFMGEBEPP(PFAGBDBNINI ENNNCMNOONC);

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string JCCLLDDOMAM(PFAGBDBNINI ENNNCMNOONC);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GOIOHFDKAFM
{
	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KICAOPFBPDO(JBKDGFJKCIL DKAIINNEBFL, JBKDGFJKCIL CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALDLMNKMDLP(JBKDGFJKCIL DKAIINNEBFL, JBKDGFJKCIL CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int MFHBGCEBEIM(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JBKDGFJKCIL HMNNJDALHAG(JBKDGFJKCIL DKAIINNEBFL, int MFJLAMOCOBC);

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DBLPDLFFIKD IFFCOCJBKJC(JBKDGFJKCIL DKAIINNEBFL, Allocator ICLGONBNBJO = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DDKMMKKLMOP(JBKDGFJKCIL DKAIINNEBFL, object DGGGDIFONNG, JBKDGFJKCIL CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DAAGJPHHHMG(JBKDGFJKCIL DKAIINNEBFL, object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool LOOIJPOCDIO(JBKDGFJKCIL DKAIINNEBFL, [Out] JBKDGFJKCIL CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NBFGNCNHGKC(JBKDGFJKCIL DKAIINNEBFL, float3 CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool AHJEFCJNPEH(JBKDGFJKCIL DKAIINNEBFL, [Out] float3 CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IJGMGINDBAA(JBKDGFJKCIL DKAIINNEBFL, float3 CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OBJPMAEPIKN(JBKDGFJKCIL DKAIINNEBFL, [Out] float3 CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PEIAFLBJMAP(JBKDGFJKCIL DKAIINNEBFL, (Quaternion rot, Vector3 moments) GEGLIBHENMO);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool BENODAAAKFB(JBKDGFJKCIL DKAIINNEBFL, [Out] quaternion LBFFEMIAIMM, [Out] float3 LDNDKMIALNC);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IPJHLDAMFIE(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 KLJCHCEPAKN(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 IOAFJGALOLN(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NCAAFDAGHCK(JBKDGFJKCIL DKAIINNEBFL, float3 CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GGLGGNDPBPO(JBKDGFJKCIL DKAIINNEBFL, float3 CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float CCBNFLLBJGB(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float DKBGHBMCFHA(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void CKPBDGCNALK(JBKDGFJKCIL DKAIINNEBFL, float CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NLHOENCGIBL(JBKDGFJKCIL DKAIINNEBFL, float CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode PHNJLJBCKCI(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CLOHCHOLHNE(JBKDGFJKCIL DKAIINNEBFL, CollisionDetectionMode CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "25")]
	MJNMIJLCBLF GDHILNBPCJI(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void FONNMOMFEGE(JBKDGFJKCIL DKAIINNEBFL, MJNMIJLCBLF CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool DAJHGIPKEMG(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void COPGDACKLOK(JBKDGFJKCIL DKAIINNEBFL, bool CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "29")]
	JBKDGFJKCIL HDKDGJIFOAP(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void OMAJLEAEDME(JBKDGFJKCIL DKAIINNEBFL, JBKDGFJKCIL CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "31")]
	JBKDGFJKCIL ABELJLHOKHJ(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void EOIGELPPMDL(JBKDGFJKCIL DKAIINNEBFL, JBKDGFJKCIL CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "33")]
	EGPFJKHDCKA NKDMIMGBEJG(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void PHMMCOGBMFN(JBKDGFJKCIL DKAIINNEBFL, EGPFJKHDCKA GGPFMEACCMA);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool AEOJPBFOHCM(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void HGCFGOFJNHF(JBKDGFJKCIL DKAIINNEBFL, bool CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool PJIEMMNBFKD(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void HHLNPKCCONE(JBKDGFJKCIL DKAIINNEBFL, bool CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints LFJNJIILIKN(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void EMLDOBIKFFK(JBKDGFJKCIL DKAIINNEBFL, RigidbodyConstraints CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float PFAOBGIHLOK(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void FOIDCNKMPCG(JBKDGFJKCIL DKAIINNEBFL, float CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float FDJDDNEAGCK(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void DDNLFKPLDOF(JBKDGFJKCIL DKAIINNEBFL, float CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool IFAJADAEHIC(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void DNDBICALOGC(JBKDGFJKCIL DKAIINNEBFL, bool CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool JPLIKAOKMBN(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void KBEHAKALMGE(JBKDGFJKCIL DKAIINNEBFL, bool CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void GGFOPGPJCAM(JBKDGFJKCIL DKAIINNEBFL, int CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "50")]
	HFNNNBLDCNA FFEAMHKMGKD(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void KAAEOMDBHCA(JBKDGFJKCIL DKAIINNEBFL, HFNNNBLDCNA CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "52")]
	NHFCKNCOFHL NOBPLEOLNFA(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void CDKHJINBKOB(JBKDGFJKCIL DKAIINNEBFL, NHFCKNCOFHL CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float PJPLENLELEJ(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void LHFDFFJFFHO(JBKDGFJKCIL DKAIINNEBFL, float CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void OIMEMOMNCIB(JBKDGFJKCIL DKAIINNEBFL, object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void ENFKCICOHLL(JBKDGFJKCIL DKAIINNEBFL, object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool CHNCJMBHECJ(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void PICBDAFFJEG(JBKDGFJKCIL DKAIINNEBFL, object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void ICIBNPGGBCM(JBKDGFJKCIL DKAIINNEBFL, object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool LDADBOMGACA(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool AAIEJEGLLCO(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody GJMPDGKPBPL(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void DOBDHBHJIKN(JBKDGFJKCIL DKAIINNEBFL, Rigidbody DOMJNFIKOOO);

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void KCIMDBGEJEP(JBKDGFJKCIL DKAIINNEBFL, object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void BLNDOGCHDLJ(JBKDGFJKCIL DKAIINNEBFL, object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool NBACHKPKJEO(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void IPNELGPJMCI(JBKDGFJKCIL DKAIINNEBFL, float3 MDMLBPNGPMJ);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void JAKLAHCDFDK(JBKDGFJKCIL DKAIINNEBFL, float3 CMHJKMGAIPO);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool IEMOPOEJOGP(JBKDGFJKCIL DKAIINNEBFL, [Out] float3 MDMLBPNGPMJ);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool PIIEHOMOEKK(JBKDGFJKCIL DKAIINNEBFL, [Out] float3 CMHJKMGAIPO);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool DPJLPEODCNO(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void JIHFJODOCFG(JBKDGFJKCIL DKAIINNEBFL, object DGGGDIFONNG, bool EHIEEFMLLHN);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void CJEKNGDKCND(JBKDGFJKCIL DKAIINNEBFL, bool ALGMIPOMDGH);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void MMFIPAIFJBG(JBKDGFJKCIL DKAIINNEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool FAOEODILPOC(JBKDGFJKCIL DKAIINNEBFL);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface LOBMNDNNNDM
{
	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MLEEDIPGGJK(Entity IIFLLEBADKJ);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LFNKDEKCBOD(Entity IIFLLEBADKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface DGJINFKHOMH
{
	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DNPFPDOLBAH(JBKDGFJKCIL CGJNNJHBPPG, bool MEIFJOCIEOB);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PPJFOENPBGF(JBKDGFJKCIL CGJNNJHBPPG, int CAACCCMGHHA);
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public delegate void COMCLNOBEAH(BCEJBMBJDHG PHEEDIOBOFF);
[Cpp2IlInjected.Token(Token = "0x200009A")]
public readonly ref struct BCEJBMBJDHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly DBLPDLFFIKD OELIIFKFHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly NativeArray<byte> FEHHCEDMMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly NativeArray<byte> KKPLAHEHMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly OPMAHOIMEIC OPOMMFAAAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly int GKPNJEKGLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly Type MHNJGMKNOAO;

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public DBLPDLFFIKD CDOEADOAEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x4200510", Offset = "0x41FF110", VA = "0x184200510")]
		get
		{
			return default(DBLPDLFFIKD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x6D87390", Offset = "0x6D85F90", VA = "0x186D87390")]
	public BCEJBMBJDHG(DBLPDLFFIKD OELIIFKFHNF, NativeArray<byte> FEHHCEDMMPP, NativeArray<byte> KKPLAHEHMOI, OPMAHOIMEIC OPOMMFAAAOF, int GKPNJEKGLHI, Type MHNJGMKNOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B840", Offset = "0x2B8A440", VA = "0x182B8B840")]
	public NativeArray<T> CLKKDMKBHBL<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B880", Offset = "0x2B8A480", VA = "0x182B8B880")]
	public NativeArray<T> GACPLFLHDDF<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B8C0", Offset = "0x2B8A4C0", VA = "0x182B8B8C0")]
	public (DBLPDLFFIKD, NativeArray<T>, NativeArray<T>) IBIJBNAFKLE<T>() where T : struct
	{
		return default((DBLPDLFFIKD, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x6D87360", Offset = "0x6D85F60", VA = "0x186D87360")]
	public IMCBIEOLNLK PIKPHMAMHHP()
	{
		return default(IMCBIEOLNLK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public interface JGMNKKOCJCH
{
	[Cpp2IlInjected.Token(Token = "0x17000199")]
	string EFMLEDNEEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	JGMNKKOCJCH DKGDKHGNCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	IEnumerable<JGMNKKOCJCH> AMNNIPGKEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface ECNHPKOFOFB
{
	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	JGMNKKOCJCH FHNLCKIMIAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	NativeArray<OPMAHOIMEIC> LMPKEIIAOPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FOCKMJBCDPM(OPMAHOIMEIC OPOMMFAAAOF, [Out] JGMNKKOCJCH PKJMBHGNAEI);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PEGPHNFMEDB(OPMAHOIMEIC OPOMMFAAAOF, COMCLNOBEAH NJILHMMLAEF);

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ACKIONKPNNI(OPMAHOIMEIC OPOMMFAAAOF, COMCLNOBEAH NJILHMMLAEF);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface MEKDCHGJIAK
{
	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEGPHNFMEDB(OPMAHOIMEIC OPOMMFAAAOF, COMCLNOBEAH NJILHMMLAEF);

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ACKIONKPNNI(OPMAHOIMEIC OPOMMFAAAOF, COMCLNOBEAH NJILHMMLAEF);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public static class KMJOCJCDCPD
{
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CDGDIIFGCKH
{
	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	DCDMMJGLGKG MABGBIOLDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IDAEGKANCIN(IOBDJLAADBM HNOPHCFBENC, OPMAHOIMEIC OPOMMFAAAOF);

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MJJLLCHEDBI(IOBDJLAADBM HNOPHCFBENC, Span<OPMAHOIMEIC> AJNDHNDCKAK, bool NGPKPNHMGGN);

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NGCIAMNNAMA(NativeArray<IOBDJLAADBM> OCOGHNMIAAF);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class JNFPKKJNCDL
{
	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x6D93510", Offset = "0x6D92110", VA = "0x186D93510")]
	public static void MJJLLCHEDBI(this CDGDIIFGCKH DIIPFEGECOC, IOBDJLAADBM HNOPHCFBENC, OPMAHOIMEIC OPOMMFAAAOF, bool NGPKPNHMGGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public readonly ref struct IMCBIEOLNLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly BCEJBMBJDHG BFLLAIFBMAJ;

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public DBLPDLFFIKD CDOEADOAEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x4200510", Offset = "0x41FF110", VA = "0x184200510")]
		get
		{
			return default(DBLPDLFFIKD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x6D8EBC0", Offset = "0x6D8D7C0", VA = "0x186D8EBC0")]
	public IMCBIEOLNLK(BCEJBMBJDHG BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x6D8E800", Offset = "0x6D8D400", VA = "0x186D8E800")]
	public DBLPDLFFIKD CLKKDMKBHBL()
	{
		return default(DBLPDLFFIKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x6D8E8D0", Offset = "0x6D8D4D0", VA = "0x186D8E8D0")]
	public DBLPDLFFIKD GACPLFLHDDF()
	{
		return default(DBLPDLFFIKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x6D8E9A0", Offset = "0x6D8D5A0", VA = "0x186D8E9A0")]
	public (DBLPDLFFIKD, DBLPDLFFIKD, DBLPDLFFIKD) IBIJBNAFKLE()
	{
		return default((DBLPDLFFIKD, DBLPDLFFIKD, DBLPDLFFIKD));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class GFILPINNKEO
{
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public readonly struct DCDMMJGLGKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly NativeBitArray MIPOOPENBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly NativeParallelHashMap<IOBDJLAADBM, int> LDJOPGEEDFC;

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public bool ONEKHMHADID
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A040", Offset = "0x6D88C40", VA = "0x186D8A040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x4354B90", Offset = "0x4353790", VA = "0x184354B90")]
	public DCDMMJGLGKG(NativeBitArray MIPOOPENBIB, NativeParallelHashMap<IOBDJLAADBM, int> LDJOPGEEDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x6D8A060", Offset = "0x6D88C60", VA = "0x186D8A060")]
	public bool IDAEGKANCIN(IOBDJLAADBM HNOPHCFBENC, OPMAHOIMEIC OPOMMFAAAOF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface PIFCONMIKHN
{
	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BMANOAIJPCE(JBKDGFJKCIL DKAIINNEBFL, CHKJBCCKFLA CABLCDOIFFL);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LKOKMLACDBN
{
	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	BLNKBACJIBE DEBNNMIFCJB
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JINHOAOOCBB
{
	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDCAAHNBDBC(World CHCPMCFMNCL);

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GGPMFKLDANC(World CHCPMCFMNCL);

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase CBAMIKKNEMD(World CHCPMCFMNCL);

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JJMOELMMFHM(World CHCPMCFMNCL);

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CBGMOIKMPDO(World CHCPMCFMNCL);

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HDCJDKGJJKO(World CHCPMCFMNCL);

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LKEBGELEEJC(World CHCPMCFMNCL);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface EHGFHKEMKPG
{
	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDBINNBJJBG(JBKDGFJKCIL IMOBCMCECHO, bool CABLCDOIFFL);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public readonly struct IOHCMHMACKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly IEnumerable<MKHKHPCLLCD> HODPFMBLMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly IReadOnlyList<GameObject> FACBAFEAHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly IReadOnlyList<int> CEOMOEHNLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly IReadOnlyList<(IOBDJLAADBM, IOBDJLAADBM)> DODGBLFGDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly int ACCOCDAGCBC;

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public bool OFMFOLKKKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x6D8ECC0", Offset = "0x6D8D8C0", VA = "0x186D8ECC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public int JDBGBKFBMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x8E9FA0", Offset = "0x8E8BA0", VA = "0x1808E9FA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public IEnumerable<GameObject> GJJEGMAMGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0xA644E0", Offset = "0xA630E0", VA = "0x180A644E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public IEnumerable<(IOBDJLAADBM src, IOBDJLAADBM dst)> BGDILMFPPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x6D8F0B0", Offset = "0x6D8DCB0", VA = "0x186D8F0B0")]
	public IOHCMHMACKB(IEnumerable<MKHKHPCLLCD> HODPFMBLMAN, IReadOnlyList<GameObject> FACBAFEAHBG, IReadOnlyList<int> CEOMOEHNLMI, IReadOnlyList<(IOBDJLAADBM src, IOBDJLAADBM dst)> DODGBLFGDCG, int ACCOCDAGCBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x6D8ED20", Offset = "0x6D8D920", VA = "0x186D8ED20")]
	public (GameObject, int)[] HKKIKAHHALI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[ServiceLifetime(Lifetime.Application)]
public interface MFDDCONEMEL
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class IMFOJNJHPMK
	{
		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public JBKDGFJKCIL GGAFGBKJIIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
			[CompilerGenerated]
			get
			{
				return default(JBKDGFJKCIL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0xB71B80", Offset = "0xB70780", VA = "0x180B71B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public UniformTRS HCJCJGNDKOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x3A63E20", Offset = "0x3A62A20", VA = "0x183A63E20")]
			[CompilerGenerated]
			get
			{
				return default(UniformTRS);
			}
			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x6D8EBF0", Offset = "0x6D8D7F0", VA = "0x186D8EBF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public bool KNBHAJMCOHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000599")]
			[Cpp2IlInjected.Address(RVA = "0xA22400", Offset = "0xA21000", VA = "0x180A22400")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600059A")]
			[Cpp2IlInjected.Address(RVA = "0xB9D5C0", Offset = "0xB9C1C0", VA = "0x180B9D5C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public IFLIHGJFOLI OJCHNDOLNCO
		{
			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x88C520", Offset = "0x88B120", VA = "0x18088C520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0x88C4A0", Offset = "0x88B0A0", VA = "0x18088C4A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public bool DGOHMNFHEHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x8F4160", Offset = "0x8F2D60", VA = "0x1808F4160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0x8F3BB0", Offset = "0x8F27B0", VA = "0x1808F3BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public InventionIdData BDBPFDMLBII
		{
			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0x88C740", Offset = "0x88B340", VA = "0x18088C740")]
			[CompilerGenerated]
			get
			{
				return default(InventionIdData);
			}
			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0x1FABCA0", Offset = "0x1FAA8A0", VA = "0x181FABCA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public InventionInstanceIdData OPCCJJEHOOK
		{
			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0xA54F70", Offset = "0xA53B70", VA = "0x180A54F70")]
			[CompilerGenerated]
			get
			{
				return default(InventionInstanceIdData);
			}
			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0xA52FF0", Offset = "0xA51BF0", VA = "0x180A52FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x6D8EC00", Offset = "0x6D8D800", VA = "0x186D8EC00")]
		public IMFOJNJHPMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	bool EOLLHAIAHAA
	{
		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	bool GLFFIKNONDD
	{
		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	CABKEKMLPLG FCPJDACIJBN
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OCPFPDLJBIE IJEKIOPHNHF();

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OCPFPDLJBIE FDEICDJCMMC(IEnumerable<JBKDGFJKCIL> CNEBDANMKHA, [In] UniformTRS ABJMKEGGPJM);

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MBEFMEGLLCH PBMPNDPEAGA(ByteString EFLMLBNEFDP);

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DLPEGECMOJJ IMGENAGAEJF(ByteString JOFDKJOIAEP, IMFOJNJHPMK HHLMDDDPFNI);

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BCHJOJONDMG();

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IOHCMHMACKB GEBEAGOBDOH(IEnumerable<MKHKHPCLLCD> HODPFMBLMAN);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class GDGFKGGFGPB
{
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[ServiceLifetime(Lifetime.Application)]
public interface DOIOMOJAPJE
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action BEJFINIKCMA;
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct JGOLJJMIDIM : IEquatable<JGOLJJMIDIM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public EKPAFNPHKFE LMKPBPFJEKM;

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x6D90DF0", Offset = "0x6D8F9F0", VA = "0x186D90DF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x182BE10", Offset = "0x182AA10", VA = "0x18182BE10", Slot = "4")]
	public bool Equals(JGOLJJMIDIM FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x6D90D70", Offset = "0x6D8F970", VA = "0x186D90D70", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0xA0B980", Offset = "0xA0A580", VA = "0x180A0B980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HOBJMLCOLCC
{
	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	uint EBEMLHBEFBD
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public enum PGCEJBJFMEO
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	End,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JPHPNMPEMEG
{
	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPCDFMNIGPF(AAEBGLNEJLN DOHADELBNEM, ReadOnlySpan<byte> NCPEFDMEFEF);

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GBEMKBGNADO(uint IMENBELMNLO, ReadOnlySpan<byte> NCPEFDMEFEF);

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GKHHFAGNFFO(int JHAGJOJLMBG);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KILDCOBILBH
{
	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AAEBGLNEJLN OKOPMHCJEOJ(ReadOnlySpan<byte> NCPEFDMEFEF);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FOCKKDNPMIH
{
	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HDHPKGBGGHD(AAEBGLNEJLN NONKDEOLPHL, ReadOnlySpan<byte> NCPEFDMEFEF);

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GGDHNAPEMIG(ReadOnlySpan<AAEBGLNEJLN> BMBOIAKNJMK);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct JFOIKAJAMNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public AAEBGLNEJLN DOHADELBNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public ReadOnlyMemory<byte> NCPEFDMEFEF;
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct AAEBGLNEJLN
{
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public static AAEBGLNEJLN GDKBPDJJGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public uint DFHDOPNDLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int FLPCEDKBAHL;

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x909730", Offset = "0x908330", VA = "0x180909730")]
	public AAEBGLNEJLN(uint DFHDOPNDLHG, int FLPCEDKBAHL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x6D85D20", Offset = "0x6D84920", VA = "0x186D85D20")]
	public static bool PCHFOHOKDFG([In] AAEBGLNEJLN CKONCFGMELN, [In] AAEBGLNEJLN GAAMPOEMOPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x6D85C30", Offset = "0x6D84830", VA = "0x186D85C30", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x6D85CE0", Offset = "0x6D848E0", VA = "0x186D85CE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x6D85D40", Offset = "0x6D84940", VA = "0x186D85D40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x6D85D10", Offset = "0x6D84910", VA = "0x186D85D10")]
	public void KHJFAIMOGKG([Out] uint DFHDOPNDLHG, [Out] int FLPCEDKBAHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public struct MKHKHPCLLCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public Guid OCIHAODAEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public string MFPCKNHBBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public Vector3 GKJAMFFKDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public Quaternion EAGKGJHHIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public Vector3 IMPGFCOPLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int HAILDPPLNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public Dictionary<string, object> HHLMDDDPFNI;

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x6D94250", Offset = "0x6D92E50", VA = "0x186D94250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x6D940D0", Offset = "0x6D92CD0", VA = "0x186D940D0")]
	private static string GMGBLCAADCJ(Dictionary<string, object> GICACIPKCID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public enum GMFHHBHOKJA
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	SubGraphReplace,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	RestoreCreationData
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class LCFKNBOPGKC
{
	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x60EFDD0", Offset = "0x60EE9D0", VA = "0x1860EFDD0")]
	public static bool AIIFEAABLKJ(this GMFHHBHOKJA FIFJJNIIAPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[Flags]
public enum ICAFDCMOFAM
{
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	WorldPhasesMaster = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	AdditivePhases = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public interface DLPEGECMOJJ : CABKEKMLPLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	IFLIHGJFOLI OJCHNDOLNCO
	{
		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBJCFKJEPNA();

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ACPLFKOHIBH();
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public interface CABKEKMLPLG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	IEnumerable<MKHKHPCLLCD> OJOAKOIFDIH
	{
		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	IOHCMHMACKB JCCAOKOFABD
	{
		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	GMFHHBHOKJA LBAEOCJIFPD
	{
		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	LocalId OKGIGBFIJNL
	{
		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	MDIAMGADBAO KAJCHNIDJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NPJFPNAECEE(ICAFDCMOFAM CAONOICADOI);
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public interface IFLIHGJFOLI
{
	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EACBPHCJAGA(Guid FCAIJJGOPCC, [Out] Guid LMJFOHKAJHJ);
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public interface MBEFMEGLLCH : CABKEKMLPLG, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[Flags]
public enum PCAKHCKFHJN
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public interface OCPFPDLJBIE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	MDIAMGADBAO IPKAAHGEGAH
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString BALIHNOKEEH();
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public enum BPCGKKJFIDL
{
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public struct DAKIJMIBLBF : ISystemStateComponentData, IComponentData, IEquatable<DAKIJMIBLBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float3 PHHIFEMAANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float3 DCJBPGFOMOL;

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x6D89900", Offset = "0x6D88500", VA = "0x186D89900", Slot = "4")]
	public bool Equals(DAKIJMIBLBF FDOEIPBMJJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MGJHIAMOMOP
{
	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ILFBKMMIJPP(long KHOKECHLBJO);

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMKPIPIAIOL(NativeParallelHashSet<long> HAPHHJGBOCN);

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CLPOKJPGFBG(World CHCPMCFMNCL, NativeParallelHashMap<Guid, long> FAKBEHJOGBG);

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EDNIAGPONKO(IOBDJLAADBM HNOPHCFBENC);

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DNKCNNDJJJE(IOBDJLAADBM HNOPHCFBENC, [Out] Guid CLEPFFBANLA, [Out] long KHOKECHLBJO);

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LODBCJCKIFE(IOBDJLAADBM HNOPHCFBENC, Guid CLEPFFBANLA, long KHOKECHLBJO);

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EFAJDMKCJDH(Guid CLEPFFBANLA);

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DEAJJMKJGIG(Guid CLEPFFBANLA, [Out] int JADNHEGLBIN, [Out] int LAOGENBIHDO);

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DOIFMLIKGHM(Guid CLEPFFBANLA, int JADNHEGLBIN, int LAOGENBIHDO);

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LPACKEGIBFJ(Guid CLEPFFBANLA);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public class IGMOIHGFJHJ
{
	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public IGMOIHGFJHJ()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
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
