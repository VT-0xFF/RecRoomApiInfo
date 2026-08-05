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
using JetBrains.Annotations;
using RecRoom;
using RecRoom.DataLayer;
using RecRoom.Foundation;
using RecRoom.Foundation.Mathematics;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ObjectModel_Interfaces_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8174F30", Offset = "0x8173730", VA = "0x188174F30", Slot = "4")]
		public override void KELFLPPCOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ECCLOGOMHCD
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x816B420", Offset = "0x8169C20", VA = "0x18816B420")]
	public static void LBLLNKOHLJM(this Rigidbody FAFFCENHANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x816B5A0", Offset = "0x8169DA0", VA = "0x18816B5A0")]
	public static void LBLLNKOHLJM(this Rigidbody FAFFCENHANK, Vector3 KKHBIJDNFCF, Quaternion MHOHCLIPGIF, Vector3 LCHODKINNBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct KDLFINJPBNM : IReadOnlyList<BMGFKKCFMCO>, IEnumerable<BMGFKKCFMCO>, IEnumerable, IReadOnlyCollection<BMGFKKCFMCO>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct NIBDHJHDHFI : IEnumerator<BMGFKKCFMCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly IPIPLKEIAHG OKNIDGHPEIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator DCDHHMABBCF;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public BMGFKKCFMCO EBPBANINJIP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8177730", Offset = "0x8175F30", VA = "0x188177730", Slot = "4")]
			get
			{
				return default(BMGFKKCFMCO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x81776E0", Offset = "0x8175EE0", VA = "0x1881776E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x524FA40", Offset = "0x524E240", VA = "0x18524FA40")]
		public NIBDHJHDHFI(IPIPLKEIAHG OKNIDGHPEIO, NativeArray<LocalId>.Enumerator DCDHHMABBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8177620", Offset = "0x8175E20", VA = "0x188177620", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8177660", Offset = "0x8175E60", VA = "0x188177660", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x81776A0", Offset = "0x8175EA0", VA = "0x1881776A0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly MJOGKAPKDDN DAMJGGDGMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> NGMIILJPNNB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BMGFKKCFMCO NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x81733F0", Offset = "0x8171BF0", VA = "0x1881733F0", Slot = "4")]
		get
		{
			return default(BMGFKKCFMCO);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8172E90", Offset = "0x8171690", VA = "0x188172E90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int MIEHFEDFDMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IPIPLKEIAHG CJNOHKMKOLM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x81727D0", Offset = "0x8170FD0", VA = "0x1881727D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int FFBDFGAGHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool AGNMEGAEAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8172EF0", Offset = "0x81716F0", VA = "0x188172EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> LDBGJCHBPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2A782A0", Offset = "0x2A76AA0", VA = "0x182A782A0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> DCHGAOCIKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x81729B0", Offset = "0x81711B0", VA = "0x1881729B0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8173100", Offset = "0x8171900", VA = "0x188173100")]
	public KDLFINJPBNM(int BEMGFNOEFHN, IPIPLKEIAHG OKNIDGHPEIO, Allocator GFNKGIEEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8173060", Offset = "0x8171860", VA = "0x188173060")]
	public KDLFINJPBNM(MJOGKAPKDDN DAMJGGDGMEF, NativeArray<LocalId> NGMIILJPNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x81731B0", Offset = "0x81719B0", VA = "0x1881731B0")]
	public KDLFINJPBNM(MJOGKAPKDDN DAMJGGDGMEF, NativeArray<Entity> NGMIILJPNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8173070", Offset = "0x8171870", VA = "0x188173070")]
	internal KDLFINJPBNM(IPIPLKEIAHG OKNIDGHPEIO, NativeArray<Entity> EFHAKLBGNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8173380", Offset = "0x8171B80", VA = "0x188173380")]
	internal KDLFINJPBNM(IPIPLKEIAHG OKNIDGHPEIO, NativeArray<LocalId> NGMIILJPNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x81732D0", Offset = "0x8171AD0", VA = "0x1881732D0")]
	public KDLFINJPBNM(IPIPLKEIAHG OKNIDGHPEIO, int AEPPOMGGPKB, Allocator GFNKGIEEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8173220", Offset = "0x8171A20", VA = "0x188173220")]
	public KDLFINJPBNM(KDLFINJPBNM HGGIBMKGMPN, Allocator GFNKGIEEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8172B50", Offset = "0x8171350", VA = "0x188172B50")]
	public void HBCBFICEHBC(List<BMGFKKCFMCO> NFJJCCDFOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8172F30", Offset = "0x8171730", VA = "0x188172F30")]
	public void OBGNFGONMKB(int PNJCJGEIDHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8172A10", Offset = "0x8171210", VA = "0x188172A10")]
	public KDLFINJPBNM FGIKHGILDDC(Allocator GFNKGIEEHMD)
	{
		return default(KDLFINJPBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8172820", Offset = "0x8171020", VA = "0x188172820")]
	public Span<BMGFKKCFMCO> DEMEAEEIEKM()
	{
		return default(Span<BMGFKKCFMCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8172AB0", Offset = "0x81712B0", VA = "0x188172AB0")]
	public KDLFINJPBNM FLBPDKPKJMJ(int BAGLBFCLNDM, int AEPPOMGGPKB)
	{
		return default(KDLFINJPBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8172970", Offset = "0x8171170", VA = "0x188172970", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8172DD0", Offset = "0x81715D0", VA = "0x188172DD0")]
	public NIBDHJHDHFI KFPOPIJHFBP()
	{
		return default(NIBDHJHDHFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8172F80", Offset = "0x8171780", VA = "0x188172F80", Slot = "6")]
	private IEnumerator<BMGFKKCFMCO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8172FF0", Offset = "0x81717F0", VA = "0x188172FF0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GAALADMKHBO
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x39DC7F0", Offset = "0x39DAFF0", VA = "0x1839DC7F0")]
	public static IBGBEKHIABD<T> IEDNAELEEFB<T>(this KDLFINJPBNM GJKNNKIANJJ) where T : Component
	{
		return default(IBGBEKHIABD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public struct PGCLLCDEJPL : IList<BMGFKKCFMCO>, ICollection<BMGFKKCFMCO>, IEnumerable<BMGFKKCFMCO>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct GNFFMDKJKLE : IEnumerator<BMGFKKCFMCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly IPIPLKEIAHG OKNIDGHPEIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator DCDHHMABBCF;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public BMGFKKCFMCO EBPBANINJIP
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x81708F0", Offset = "0x816F0F0", VA = "0x1881708F0", Slot = "4")]
			get
			{
				return default(BMGFKKCFMCO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x81708A0", Offset = "0x816F0A0", VA = "0x1881708A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x524FA40", Offset = "0x524E240", VA = "0x18524FA40")]
		public GNFFMDKJKLE(IPIPLKEIAHG OKNIDGHPEIO, NativeArray<LocalId>.Enumerator DCDHHMABBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x81707E0", Offset = "0x816EFE0", VA = "0x1881707E0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8170820", Offset = "0x816F020", VA = "0x188170820", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8170860", Offset = "0x816F060", VA = "0x188170860", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly IPIPLKEIAHG OKNIDGHPEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> NGMIILJPNNB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public BMGFKKCFMCO NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x817BFF0", Offset = "0x817A7F0", VA = "0x18817BFF0", Slot = "4")]
		get
		{
			return default(BMGFKKCFMCO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x817C0E0", Offset = "0x817A8E0", VA = "0x18817C0E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x817B8E0", Offset = "0x817A0E0", VA = "0x18817B8E0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int FFBDFGAGHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x817B8E0", Offset = "0x817A0E0", VA = "0x18817B8E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> LDBGJCHBPOP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2A782A0", Offset = "0x2A76AA0", VA = "0x182A782A0")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool FEDAMJDDKCF
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x817BEE0", Offset = "0x817A6E0", VA = "0x18817BEE0")]
	public PGCLLCDEJPL(IPIPLKEIAHG OKNIDGHPEIO, Allocator GFNKGIEEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x817BF60", Offset = "0x817A760", VA = "0x18817BF60")]
	public PGCLLCDEJPL(IPIPLKEIAHG OKNIDGHPEIO, int AEPPOMGGPKB, Allocator GFNKGIEEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x817B920", Offset = "0x817A120", VA = "0x18817B920")]
	public KDLFINJPBNM HMNKAHFBHBF()
	{
		return default(KDLFINJPBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x817B600", Offset = "0x8179E00", VA = "0x18817B600", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x817B640", Offset = "0x8179E40", VA = "0x18817B640", Slot = "13")]
	public bool Contains(BMGFKKCFMCO NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x817B6D0", Offset = "0x8179ED0", VA = "0x18817B6D0", Slot = "14")]
	public void CopyTo(BMGFKKCFMCO[] LPBOBEPEKNH, int LJDJNPPCHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x817B580", Offset = "0x8179D80", VA = "0x18817B580", Slot = "11")]
	public void Add(BMGFKKCFMCO NAGJHHJDFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x817BAC0", Offset = "0x817A2C0", VA = "0x18817BAC0", Slot = "7")]
	public void Insert(int PNJCJGEIDHG, BMGFKKCFMCO NAGJHHJDFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x817BC50", Offset = "0x817A450", VA = "0x18817BC50", Slot = "15")]
	public bool Remove(BMGFKKCFMCO NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x817BA30", Offset = "0x817A230", VA = "0x18817BA30", Slot = "6")]
	public int IndexOf(BMGFKKCFMCO NAGJHHJDFPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x817BC00", Offset = "0x817A400", VA = "0x18817BC00", Slot = "8")]
	public void RemoveAt(int PNJCJGEIDHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x817B8A0", Offset = "0x817A0A0", VA = "0x18817B8A0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x817BB70", Offset = "0x817A370", VA = "0x18817BB70")]
	public GNFFMDKJKLE KFPOPIJHFBP()
	{
		return default(GNFFMDKJKLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x817BD20", Offset = "0x817A520", VA = "0x18817BD20", Slot = "16")]
	private IEnumerator<BMGFKKCFMCO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x817BE00", Offset = "0x817A600", VA = "0x18817BE00", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GOKFDPLMAEF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BMGFKKCFMCO IEFPLCGPNPB(BMGFKKCFMCO NGMIILJPNNB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DNNBLCHKABA : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface HJHCJCGHAMD : IMDDEPOCBHC, IEFIELEPDPK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	CEJNMCMOCOK OBOPDCNIBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	AENKGANHCMH EKDCHCNMKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	MJOGKAPKDDN FCMLHMHKJND
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface IEFIELEPDPK
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool BLNLFGEBLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.Application)]
public interface JGKCAKCODHP
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKJHLFPNNPF(bool MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGGBONADGHB();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface AGLGEAMLMPO
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool BMNAGIBLAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool HJMJLKDAIOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool EJNMHEACJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool LPNJPKBHKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool KANMHLBGGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CJOPMOJLNLA(bool EMMOENAPJHM);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool NCKIFJFOLMJ(ByteString GNMGCGKMOBJ);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ONINJKIBPHE();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CGKONPDBOKJ();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OGIHMHIPBFG();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.Application)]
public interface AENKGANHCMH
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	OBECFEHHJHL OBOPDCNIBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	NNCJINNDNIO KHNDOBPPFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	CHOEIGPMMOK HOLPAAAJICE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	HJHCJCGHAMD KDEMCKCOECM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	JPEEGIJCLKN NMIJDCFEKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	AGLGEAMLMPO BFCEGLGLDBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	CDHMBEHALEL KKIIGDNEJAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	GKCBPBJJNEK ILCJBINBOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	HAMJIEEPBNM AMIDILAKHBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	KCEOHGNKGFN MAINJBKECJH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	MCAKPFLKIGG PGHPPIABEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	BJGJCEIBHCC ALGKIPNGINI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	IPIPLKEIAHG CJNOHKMKOLM
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	LHEDJDCMMEK JLNMIBFLOLN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	KCACKMFEHNE KIJEHIKHJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	FPJOPMDJGMA BCGNFPEHLNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	ANCGJLEODJF KONNBNAIJPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	AFGMLEBJNIL HKCHJBDBABG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	FJODELCFDEA NBDMNNMBHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	BPEPLIGGGAD OGHMHNAKIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	OIIKPGHIHGO DPENIHFPCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	DDJBCBAANIP AHACKHICOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	GPBLIIKCMCB DJHHABDGCDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	GPFGOBLAJKJ JAPELNJJGHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	EDDIOCAGPLM CGJMJJADIPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	BBHKFIBBNGI GMOEPJGEKIF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	INFBPKBBKJP FNHLPMKPHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	HJKEFICBHPD MBJIMADJFHD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	INHIMFOOIBJ JADNLCCPFEO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	BFMGKHADBNH FEEABLIAKEF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	OCKGLNDAPAM FGLGOJBEFIN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	MGOAOGOOHDM IAJPEJHMHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	DGHIMMNEPOC IHKCEOEOBNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	JPKBMMOMLHN ODMPEGEBPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	ENMKEMIGGFF BDFCPKHFJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(JJDNNJEJGCK))]
public readonly struct BMGFKKCFMCO : IComparable<BMGFKKCFMCO>, IEquatable<BMGFKKCFMCO>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly BMGFKKCFMCO HBDEBEHCDNA;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int MGMCBGLNFPL = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int IEPNKOCOPIF = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int EBFKNEPEEJI = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int CJMPDHJNOND = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId MIKNGKGCFKJ;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public IPIPLKEIAHG CJNOHKMKOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8168880", Offset = "0x8167080", VA = "0x188168880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public HJHCJCGHAMD KDEMCKCOECM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8168EC0", Offset = "0x81676C0", VA = "0x188168EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public LocalId APKCJCBKCMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8168D60", Offset = "0x8167560", VA = "0x188168D60")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	internal MJOGKAPKDDN FCMLHMHKJND
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8168D50", Offset = "0x8167550", VA = "0x188168D50")]
		get
		{
			return default(MJOGKAPKDDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool KPPNCAJEGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x81689D0", Offset = "0x81671D0", VA = "0x1881689D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private bool EMHGEJCBHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8168D00", Offset = "0x8167500", VA = "0x188168D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8169050", Offset = "0x8167850", VA = "0x188169050")]
	public BMGFKKCFMCO(IPIPLKEIAHG HCABKBFPNBG, LocalId MIKNGKGCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8169110", Offset = "0x8167910", VA = "0x188169110")]
	public BMGFKKCFMCO(MJOGKAPKDDN DAMJGGDGMEF, LocalId MIKNGKGCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
	public MGMNCEJOGLO ODFJECGPIBF()
	{
		return default(MGMNCEJOGLO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8168C80", Offset = "0x8167480", VA = "0x188168C80")]
	public static LocalId KEINEINMKGA(BMGFKKCFMCO PDGPMIEMGMA)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8168CC0", Offset = "0x81674C0", VA = "0x188168CC0")]
	public static Entity KEINEINMKGA(BMGFKKCFMCO PDGPMIEMGMA)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8168DA0", Offset = "0x81675A0", VA = "0x188168DA0")]
	public static bool NALNDDPCEFD(BMGFKKCFMCO HBMOFOICGEH, BMGFKKCFMCO LDEEDNGKJOE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8168860", Offset = "0x8167060", VA = "0x188168860")]
	public static bool BLLMPNNLKNM(BMGFKKCFMCO HBMOFOICGEH, BMGFKKCFMCO LDEEDNGKJOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8168F20", Offset = "0x8167720", VA = "0x188168F20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8168AF0", Offset = "0x81672F0", VA = "0x188168AF0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x81688E0", Offset = "0x81670E0", VA = "0x1881688E0", Slot = "4")]
	public int CompareTo(BMGFKKCFMCO KEKEFPAJGHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "5")]
	public bool Equals(BMGFKKCFMCO KEKEFPAJGHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class KLENBDJHEOM
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x81735E0", Offset = "0x8171DE0", VA = "0x1881735E0")]
	public static JKKCHPONOAD HDFJIPDHMNK(this BMGFKKCFMCO HPLLAPMNIJF)
	{
		return default(JKKCHPONOAD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class JJDNNJEJGCK
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct MJOGKAPKDDN : IEquatable<MJOGKAPKDDN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly byte DAMJGGDGMEF;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static byte[] NBGKLLBKMKP;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static IPIPLKEIAHG PFFDAPAKMHA;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static HJHCJCGHAMD LEHMKIDMOGI;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static IPIPLKEIAHG[] CDBMKICMICE;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static HJHCJCGHAMD[] IBIGLGKBJFM;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static Stack<byte> LJCIACHFCBA;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public HJHCJCGHAMD KDEMCKCOECM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8176C70", Offset = "0x8175470", VA = "0x188176C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public IPIPLKEIAHG POMJFFNEEDK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8176100", Offset = "0x8174900", VA = "0x188176100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8176E10", Offset = "0x8175610", VA = "0x188176E10")]
	static MJOGKAPKDDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA99A0", Offset = "0x2AA81A0", VA = "0x182AA99A0")]
	internal MJOGKAPKDDN(byte MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x703F320", Offset = "0x703DB20", VA = "0x18703F320", Slot = "4")]
	public bool Equals(MJOGKAPKDDN KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8176060", Offset = "0x8174860", VA = "0x188176060", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xF79A70", Offset = "0xF78270", VA = "0x180F79A70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8176D50", Offset = "0x8175550", VA = "0x188176D50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x8176260", Offset = "0x8174A60", VA = "0x188176260")]
	private static IPIPLKEIAHG HGBCEMMHJJF(byte DAMJGGDGMEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8175FB0", Offset = "0x81747B0", VA = "0x188175FB0")]
	private static HJHCJCGHAMD ALNKKCJPGHC(byte DAMJGGDGMEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x81767A0", Offset = "0x8174FA0", VA = "0x1881767A0")]
	private static object LFCMAJCJPOG(byte DAMJGGDGMEF, object[] IFMNLKCJNMD, object GJPLADDCFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8176900", Offset = "0x8175100", VA = "0x188176900")]
	private static int MLMMNGACJDP(byte DAMJGGDGMEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8176050", Offset = "0x8174850", VA = "0x188176050")]
	private static int BOAOKNPGJEK(byte DAMJGGDGMEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x81761E0", Offset = "0x81749E0", VA = "0x1881761E0")]
	private static (int, int) GEHHIBPCJGO(byte DAMJGGDGMEF)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8176790", Offset = "0x8174F90", VA = "0x188176790")]
	private static byte KGDIBBDDLGA(int EHCBHNLMEHF, int PNJCJGEIDHG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x81764F0", Offset = "0x8174CF0", VA = "0x1881764F0")]
	internal static MJOGKAPKDDN KELFLPPCOLM(HJHCJCGHAMD GDJKBGMMCCG, IPIPLKEIAHG LJJHNICONFL)
	{
		return default(MJOGKAPKDDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8176300", Offset = "0x8174B00", VA = "0x188176300")]
	internal static void HIDPNIODDKH(MJOGKAPKDDN DAMJGGDGMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8176910", Offset = "0x8175110", VA = "0x188176910")]
	private static void MPDFKLAOPPK(int BEMGFNOEFHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum NECBHLPDNKO
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
public interface JHLMGMHKCCO
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool DGJNLJICDEH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool CADNHLJFJJL
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool OHFCMCOOGGA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool GMDGAFAHPAC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool NDKOFJMDOIF
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DPMBCOKIMCK
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LKDKNPJAIGM(ONOFILNELGO MBKOPLBCEJA, int PNJCJGEIDHG);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BGGDKIIJEJA(ONOFILNELGO JKEHHEIGMOA, int PNJCJGEIDHG);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LAFONOJFEPG : ONOFILNELGO, JHLMGMHKCCO
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	int IKPDHFKCPLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HPBJFBLOLOO(ICIMFNLLPNC GOMGOEKJPBC, int PNJCJGEIDHG);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface ONOFILNELGO : JHLMGMHKCCO
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum IJMNAFFHBEB
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

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool PJADFGKKPIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool BKJLLBIFBAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool HGFNHKGHLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface ICIMFNLLPNC
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool PCILNIONOMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	HBIFHMNPGDK GDLJJFCDNKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	COEPENAFNCM CCOFILNGNIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float3 EOALAOOGNLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	quaternion FAABMGBBECF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	float3 HDBDMJCJIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	ODAFNIPBPOF CCOKKNAJIML
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	HJJEDNCFOMD NOCIFGGBANI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float DEKMHJAIAIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float3 EGLNFLGEBJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float FMFGECDBGGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	CMGJMELDMAG MGOGELABEBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface KKKNOKPGJDG
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	float3 IDFHMANDJJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	float3 IFJBKFHAOAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	quaternion EBJIPADPAAB(float3 FGNIOGCKLKH);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface COEPENAFNCM
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool BJJEMCEGIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool AJFFMACCMAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool GEOJDLJFJPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	float CHMGLBHDCCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	int KAKMPJPCNKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int CHEMJOFFLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BBNNCKELAEI(KKKNOKPGJDG GOMGOEKJPBC, int PNJCJGEIDHG);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.Application)]
public interface FNKGHCDLJOE
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Guid LNEKBJBJAFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CHFNIMMHAMF(Guid HABFMOLCJFB, Guid IBMDEKLDACD, Guid FJKCHAKAJKM);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task JIIOCACHBBD(Guid HABFMOLCJFB, Guid[] LBMHOGIHABA, Guid FJKCHAKAJKM);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid PMCLPAHMPPN(Guid MFJIMNDMCML);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task LPAOMHGEOPL(BMGFKKCFMCO CJOIHKAANMG);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JNMGLEAGOOG(Guid MFJIMNDMCML);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool POHPPACNLCP(OAPPHIEPOMF MNNAMFIFNOD, Guid HLFGDGBFPIK);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LILJAHIAIIH(Guid MFJIMNDMCML, bool EMMOENAPJHM);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IHEGKGNFIDC(Guid MFJIMNDMCML, JKKCHPONOAD CPAJDCEBBMM);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LLMDLJOOJGJ(JKKCHPONOAD CPAJDCEBBMM);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FNNLNGKIJGI(BMGFKKCFMCO MIKNGKGCFKJ);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ServiceLifetime(Lifetime.Application)]
public interface MEGKOKINDKJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface OKEKEEJCCIN
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "0")]
	void HOFKDPKABKJ(bool CCCAKBLNGCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface NNCJINNDNIO
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	OKEKEEJCCIN BHFBFFGHPKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	OECGEPEBMAB PHNPGCMIBLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	APKBDDIJJOD EKGAPOJKGKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	ENFEGIABCHP PPBFPOPKFLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	DDAIBCKBNKJ PJKOOGPEPJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	CIGBFAFBHFL KPEMJOHECAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	NJBCJOHLCLD ELDAHLHIDJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	IEHGNBIOBAC BBDHOCIJFHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.Application)]
public interface OECGEPEBMAB
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	string LACLPGOKMAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[ServiceLifetime(Lifetime.Application)]
public interface CEEOIABGGDG
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADJCLKCLDBG(Action AMNCPNDDCLP, bool PBFMDJPDBOA);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KFILPEJLHJL(string HPANEBBHGAC);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int IAEMHOLDODD(string HPANEBBHGAC, int GJPLADDCFJL);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BAHJPEIILOD([Out] bool MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HPLBJBPEJAE([Out] bool MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MAMCIIGHAGP([Out] int MGONBEDEDON);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[ServiceLifetime(Lifetime.Application)]
public interface APKBDDIJJOD
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "0")]
	void FOBPGPGBIHE(bool EMMOENAPJHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface ENFEGIABCHP
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected static readonly Guid DLJCIKCCJEE;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	static readonly Guid BKGEOEMMHBA;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	static readonly Guid JEMCJBIFCOH;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	static readonly Guid DILPFLBPFJJ;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	bool DFBPNFNKMOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	bool BKMCBHKHGNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	bool EFONMKKBJMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x816BDD0", Offset = "0x816A5D0", VA = "0x18816BDD0", Slot = "3")]
	string[] NKDMFKPJEEB(MPOOOMKNOFE FKDJCHFMMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HHFEOBOPAKB();

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x816BDA0", Offset = "0x816A5A0", VA = "0x18816BDA0", Slot = "5")]
	Guid KONBBKMNGFP(Guid OIMIHPHDOGE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int MFGAHFBHMJK(MPOOOMKNOFE FKDJCHFMMAO);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OPJAAMMBFIN(MPOOOMKNOFE FKDJCHFMMAO, NativeArray<JCDLLPCCMGB> FBHGMBLCAGI, NativeList<UniformTRS> ILIGFEECOLH);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int DNJNLFBOHEL(Guid JMHOEKKPCPG);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool IMEGFJBHLNJ(string PFNNEAHDLNK, [Out] Guid JMHOEKKPCPG);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string BOJEKOGPJBO(Guid JMHOEKKPCPG);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KGONILLAGHE(RRObjectPrefabData DHLHNGBKAKM, [Out] LocalId JAOKKIIOCBD);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IBGBEKHIABD<byte[]> AACHMPANNMC(NativeArray<JCDLLPCCMGB> CMOHEKMKINC);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IAKFOKPHCJH(byte[] LGMCHOHKEMK);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GameObject FMIGBCLFHHM(string PFNNEAHDLNK);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HIJCAMEHALB(Transform KCODNJGBFEK, RRObjectPrefabData CCNCJEBJENL, HDJJIILNIDG MJAGIMDGJBK);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool HHGDKOGABKJ(MPOOOMKNOFE FKDJCHFMMAO, NativeParallelHashMap<Guid, LocalId> ONBALMELLME, [Out] Exception COLJEFDGCGI);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MKMLJBIKHPC(MPOOOMKNOFE FKDJCHFMMAO, NativeParallelHashMap<Guid, LocalId> ONBALMELLME, [Out] NativeArray<LocalId> EFHAKLBGNAC, [Out] NativeArray<LocalId> APIDGJJNDDH, [Out] NativeArray<AuthoredLocalPoseData> JDECPMCEGBB, Allocator GFNKGIEEHMD);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "18")]
	void HEAJCKGHFCM(MPOOOMKNOFE JPCNIAHCHAA, NativeArray<int> NDLIBHEDOED, FJODPEEPKJK<GameObject> JLNGJNLOFNC, IBGBEKHIABD<GameObject> JJPMHPHKPEC, NECBHLPDNKO BHHIAENBDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void CLONDOEKCBC();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "20")]
	void POOENKLJLPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "21")]
	void HDOOBFNGDNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "22")]
	bool NENPBJBALNH(MPOOOMKNOFE FKDJCHFMMAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "23")]
	DPMBCOKIMCK NCDJMBNJIFC(MPOOOMKNOFE FKDJCHFMMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "24")]
	void OCMMHENBIOI(Guid NDBBIKEMCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "25")]
	bool OANBCMDDDJI(Guid NDBBIKEMCKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x816BE60", Offset = "0x816A660", VA = "0x18816BE60")]
	static ENFEGIABCHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface CHGLMPPKNMN
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	long IEBDGBFLDFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	long HJFGFMLFIKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "1")]
		get
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface DDAIBCKBNKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool IHCLLIGFBIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool ONAKMGNIIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	int CFFHLJNFCJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	int IKFFONJFPPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	int PCIAIMFFOED
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool CGLEMFFJACE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	int DJHBOCLICNB
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "6")]
	void EPHDIHDGCGG(ABCPNDDIMEF HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "7")]
	void CMPFNNJJEHO(bool BHCLCLCKKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "8")]
	bool GFHEPGDNPKA(GBNNBLFIGLH FIOLDALLLFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "9")]
	void PEHGFJLKEEN(object OILJBDLKBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "10")]
	void PNAKILKFIJA(object OILJBDLKBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HEGKCDGBFFP(Action<object> BBPAEOIJBMN);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EGKPOKCMMBM(Action<object> BBPAEOIJBMN);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "13")]
	void FMJOAPLFLNC(NativeArray<ViewId> OECPLNGCKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "14")]
	void IMENOCFJIJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "15")]
	void HDGALNPKNHG(MKLLDEMFALJ CEPGAJKBPDM, ReadOnlySpan<byte> IMINNNCPCJF, GBNNBLFIGLH CBCINDIMJOG, bool CBCMNILNHGB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "16")]
	void HDGALNPKNHG(MKLLDEMFALJ CEPGAJKBPDM, ReadOnlySpan<byte> PKICEBKAPBH, bool CBCMNILNHGB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "17")]
	void HDGALNPKNHG(MKLLDEMFALJ CEPGAJKBPDM, ReadOnlySpan<byte> PKICEBKAPBH, ReadOnlySpan<byte> HINFGHFJAJF, bool CBCMNILNHGB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "18")]
	void ECINCDHEJMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "19")]
	void DNIHBLOBGIP(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "20")]
	void AFBBPFAIBEF(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "21")]
	void GKJGLIKPLKJ(Dictionary<object, object> JIHOCMLHDBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "22")]
	void KKJPCOGOGMN(NativeList<JKKCHPONOAD> KGCPPABHALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "24")]
	void DILPLIHPMHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "25")]
	void DEMMGMMEHMI(List<object> CGEDDGPEAFA, int COEFDMIBPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "26")]
	void BGKOEDAOPHI(int FMJAILJAADG, object NPLHFNMEMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "27")]
	void GIKJDHNPMOC(GBNNBLFIGLH FIOLDALLLFF, Dictionary<object, object> JKBGANBHBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "28")]
	void BFCHMHAIHIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "29")]
	void DPIPINJGJEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class CNFNMFGOFPM
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x816AD80", Offset = "0x8169580", VA = "0x18816AD80")]
	public static PNCPJPNDCAB PCEDLEBPJBE(this DDAIBCKBNKJ DLJGBAKBBOP, object KAJENDFCCBJ)
	{
		return default(PNCPJPNDCAB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct PNCPJPNDCAB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private DDAIBCKBNKJ DLJGBAKBBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private object KAJENDFCCBJ;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x817C860", Offset = "0x817B060", VA = "0x18817C860")]
	public PNCPJPNDCAB(DDAIBCKBNKJ DLJGBAKBBOP, object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x817C810", Offset = "0x817B010", VA = "0x18817C810", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KNHNDCMLNDE
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate void CDJFNPIKIGM(ViewId HEFGNKGLBJE, DILHAMBPDCK CHEPDNGDHLG, int OHCFIGMIAEM);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "0")]
	void IOLNOEONKMG(CDJFNPIKIGM IIGFLJINNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "1")]
	void BDPPGOPOLJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "2")]
	void FAIDEKPPLKJ(LHOHOFLFMIN CJJAIJHHKDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[ServiceLifetime(Lifetime.Application)]
public interface GGLLMOHIKNC
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ServiceLifetime(Lifetime.Application)]
public interface CIGBFAFBHFL
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct DANEAFHPIAE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private CIGBFAFBHFL DEMBMGOGCHI;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x816AED0", Offset = "0x81696D0", VA = "0x18816AED0")]
		public DANEAFHPIAE(CIGBFAFBHFL DEMBMGOGCHI, string HGCMMCJBAPF, string GHHLNMFNLNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x816AE10", Offset = "0x8169610", VA = "0x18816AE10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct FMKFIFMOBNL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private CIGBFAFBHFL DEMBMGOGCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Task FEGBHCAEMDO;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x816EE20", Offset = "0x816D620", VA = "0x18816EE20", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "0")]
	void GKGNOOHFONI(string ILBALOOKKCP, float EMFFCDLDJIB = 5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "1")]
	void FKIDADMCAJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NKAMCAEPFLP(bool OAFPJCACAGG, string HGCMMCJBAPF, string GHHLNMFNLNC);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "3")]
	void PMGOCPICCIF(string ILBALOOKKCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class GBGOCMPIBJE
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x816FC20", Offset = "0x816E420", VA = "0x18816FC20")]
	public static CIGBFAFBHFL.DANEAFHPIAE EGKFAPBJAAN(this CIGBFAFBHFL DLJGBAKBBOP, string HGCMMCJBAPF, string GHHLNMFNLNC)
	{
		return default(CIGBFAFBHFL.DANEAFHPIAE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[ServiceLifetime(Lifetime.Application)]
public interface OAFPBAPMGDG
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LKHBFGBLGJC(GameObject EMOLHEPHCGI);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HJMADDFFIEH(GameObject EMOLHEPHCGI);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ONABOIFLJKP(int FIOLDALLLFF);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object LHACIKALDBI(BMGFKKCFMCO MIKNGKGCFKJ, GameObject EMOLHEPHCGI, Action<BMGFKKCFMCO, int> LKHIOLGKDDF);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PLGCMHBKEJM(GameObject EMOLHEPHCGI, object BHFNBHBCJEO);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CHPCIBLPCBC
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HADKEMBEJCB(EGIPCMMOIAA EPFGDLJCLLF, EAIHJJGBIAB GHKACKCGIEN);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.Application)]
public interface ENNAGKHKPHK
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJCNJFECIPF(object HPLLAPMNIJF, NativeList<byte> IMINNNCPCJF);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object OLFGCACBCKJ(NativeArray<byte> IMINNNCPCJF);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ServiceLifetime(Lifetime.Application)]
public interface AGIEOEJNKMC
{
	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool JDNMDDFMEML
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate CIFNAHOPMCL(AEGIMLOKCDC HKBFOPIOPHI, Action<AEGIMLOKCDC> LKHIOLGKDDF);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OPPINMKOKGA(AEGIMLOKCDC HKBFOPIOPHI, Delegate LKHIOLGKDDF);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate EFEIABKHMNH(AEGIMLOKCDC HKBFOPIOPHI, Action<AEGIMLOKCDC> EDKPEBNNDBH);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KGIFFBICNEI(AEGIMLOKCDC HKBFOPIOPHI, Delegate LKHIOLGKDDF);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CKMFIGLLOKN(AEGIMLOKCDC HKBFOPIOPHI);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AEGIMLOKCDC PHLLFIKMELM(GameObject EMOLHEPHCGI);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
public interface MIPCMHKJDMF
{
	[Cpp2IlInjected.Token(Token = "0x17000079")]
	int NOJHHPLHBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	int IGFMBGPNGIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	bool IHCLLIGFBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool EPJHIMOAOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	bool JMIAEAPEFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BMGFKKCFMCO IEPCEFIIIPJ(int FIOLDALLLFF);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AFLEIOEELCP(GameObject HLNJFJAOLJK, JobHandle JGKIOKIBHJM);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface HEMFOGHFDJC
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HADKEMBEJCB(int LFGOLEKPJOL, EAIHJJGBIAB HKJMANNLOAK);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ServiceLifetime(Lifetime.Application)]
public interface NJBCJOHLCLD
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	bool BMNAGIBLAPE
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.Application)]
public interface CHKGGGNHDIL
{
	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	EKIIKOCIIMI IKFMGEGBDKF
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	DBFFJCHPNOI NBGMHLGKAIA
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool DHOFMCIMEDN
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IEJCMPALDOD(Transform KCODNJGBFEK);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HDONAGHECJJ(Transform KCODNJGBFEK, FGMEPCABJKL IOCDAELLGJD);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MGGALPPEEFB(Transform KCODNJGBFEK, ELCBLENENFJ FIPGMBEGOHI);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[ServiceLifetime(Lifetime.Application)]
public interface IEHGNBIOBAC
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NDNKDPOFLFK;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[ServiceLifetime(Lifetime.Application)]
public interface DNCKEKMLJIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NFLIAMALGJN();
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[ServiceLifetime(Lifetime.Application)]
public interface OLKLMLIADCI
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNFMKJHHPEE(GameObject EMOLHEPHCGI, KPECNNGKFAP MKHPHPAMOEN, JMDHHCJMALC GPBINIFICLM);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CLGADNJICMA(BMGFKKCFMCO MIKNGKGCFKJ, bool FFCMCLOHIBF, float3 BFCBEPFEMMF, quaternion KOHCIPAGLCF);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ABHDHIEDGKI(KDLFINJPBNM HFCCJBODGBP);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NGMOEJJHGHK(MGMNCEJOGLO PKBMMFHCONE, MGMNCEJOGLO OLBBKGLINIK, HANCEIDOMMA ENEFJOLLDHH);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NEBGMBMCGBF(MGMNCEJOGLO PKBMMFHCONE, HANCEIDOMMA ENEFJOLLDHH);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CFHNJJGNKAE(KDLFINJPBNM OGAMNAKIMKJ);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PNDBNLNIGDA(MPOOOMKNOFE NDOKPGIBONO, ReadOnlySpan<Guid> MMNALEEMEND, ReadOnlySpan<int> HDMCMHAFBPE, IBGBEKHIABD<GameObject> FMFKAFKKPOP);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void APDNBNMPBIJ(OMNGNIEEKFB CMKGOBJPAMC);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct ALEIPLCNFHG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NativeArray<byte> IMINNNCPCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly GCHandle DAMJGGDGMEF;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x8167C40", Offset = "0x8166440", VA = "0x188167C40")]
	public ALEIPLCNFHG(ReadOnlyMemory<byte> HBPINLCGMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x8167C00", Offset = "0x8166400", VA = "0x188167C00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum JKFFJGPHCHA
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
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct MPOOOMKNOFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public ByteString HNONPHBDAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public object AGCHABAEMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object ANAIOLFMGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IEnumerable<string> HLCOOPNGHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool FBDFLNOIJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public OGPCNLDNBGN.NMMENEFKGFJ? IMDLLGMEIPF;

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x81774E0", Offset = "0x8175CE0", VA = "0x1881774E0")]
	public MPOOOMKNOFE(ByteString HNONPHBDAJD, [Optional] object AGCHABAEMGG, [Optional] object ANAIOLFMGHC, [Optional] IEnumerable<string> HLCOOPNGHGC, bool FBDFLNOIJAJ = true, [Optional] OGPCNLDNBGN.NMMENEFKGFJ? IMDLLGMEIPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct ICPFNBJNFDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object MABHFHOJMGF;
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct JCDLLPCCMGB
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[Flags]
	public enum BMBBNFKBIPI
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
	public RRObjectPrefabData BDBPPAAGMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Guid CNLMHNDILAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Guid ELKHBHJDDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid IELIFCIHEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Guid LMIGFIOFHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public BMBBNFKBIPI NMFHGOAHANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Color32 MDNNFNJMIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public int HIBPAHDMGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public LOODBKALLPL ODHDJMNIGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int NPFJONNOJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int GDIDJJFNEAI;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Guid FHHABMPIJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x524B970", Offset = "0x524A170", VA = "0x18524B970")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public bool EECGIKIAMIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8172130", Offset = "0x8170930", VA = "0x188172130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public bool OOOADHHFENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8172120", Offset = "0x8170920", VA = "0x188172120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool OFBMEKDAPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8172140", Offset = "0x8170940", VA = "0x188172140")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct FPKBHFBIECB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal readonly GGAGCBNAACI BAGLBFCLNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly GGAGCBNAACI LLHBGCFGAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal readonly uint OKOOLMJEHDK;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x816F9C0", Offset = "0x816E1C0", VA = "0x18816F9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct MDLCKAPPHBG
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal readonly FPKBHFBIECB AMNCPNDDCLP;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x8175080", Offset = "0x8173880", VA = "0x188175080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct PDJJNHCCGIA
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal readonly FPKBHFBIECB AMNCPNDDCLP;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x8175080", Offset = "0x8173880", VA = "0x188175080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct PNOCJNKDEAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal readonly uint OKOOLMJEHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	internal readonly bool GIFMNCKGMOA;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x817C8F0", Offset = "0x817B0F0", VA = "0x18817C8F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct GGAGCBNAACI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal int BJCMHPBMOOK;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x8170580", Offset = "0x816ED80", VA = "0x188170580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[ServiceLifetime(Lifetime.Application)]
public interface ADOIBHBAPEO
{
	[Cpp2IlInjected.Token(Token = "0x17000086")]
	MHFEOCLBDEB ICEFMMKHECM
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface OAPPHIEPOMF
{
	[Cpp2IlInjected.Token(Token = "0x17000087")]
	BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface CAJBBKFHNDB
{
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class EMEIJKBAAEJ
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3849A90", Offset = "0x3848290", VA = "0x183849A90")]
	public static MGMNCEJOGLO ODFJECGPIBF<T>(this T MIKNGKGCFKJ) where T : OAPPHIEPOMF
	{
		return default(MGMNCEJOGLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x816BC60", Offset = "0x816A460", VA = "0x18816BC60")]
	public static MonoBehaviour BOIOLFKOOPO(this OAPPHIEPOMF MIKNGKGCFKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x816BCE0", Offset = "0x816A4E0", VA = "0x18816BCE0")]
	public static GameObject CBMGDPANAMH(this OAPPHIEPOMF MIKNGKGCFKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface BFAAEMEJCDE : OAPPHIEPOMF
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(BMGFKKCFMCO BDGEMDMFHPC);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface ADAKACEGEFM : OAPPHIEPOMF
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface GADOJBCBAIL
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public delegate void HEGHBAKADEG(OCCHCGAEEDE HHGHOFIIDOH);

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event HEGHBAKADEG GOGHGPAONJA;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface NABEFMDGPOA
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface IDABENNIGNP
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface JHKCNIMOAKE
{
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(BMGFKKCFMCO FHKGANFOPJM);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool PLGNMPEEFFB);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KHLELKCELEM(BMGFKKCFMCO NHDNPGNDBND);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface CBHJJJOEPCP
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(LHDELCHFOJE FACGNHPNNDD);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface LHDELCHFOJE
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	GameObject EMOLHEPHCGI
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Transform KCODNJGBFEK
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	BNECIELGDHO DOFEKKBNMEM
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool LHPEIHEDLCL
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NAKFMDPHKJM(BNECIELGDHO DIIOBAFKCCH);

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FEENKBGNJLG GetData();
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class LOKDKPHKAPI
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8174BB0", Offset = "0x81733B0", VA = "0x188174BB0")]
	public static void MPMNIJBEKLN(this LHDELCHFOJE ACGABOLDOKP, HDJJIILNIDG MJAGIMDGJBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface BNECIELGDHO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	Rigidbody POPJLLBILII
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	LHDELCHFOJE MPEDHOEMJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	GameObject CBMGDPANAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	Transform GNOACPCNCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	BNECIELGDHO IFICPJBFHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	BNECIELGDHO LCHPFLHNGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	int NBPKJKBPHJP
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	bool NAMPEJNDIBP
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	bool CKMFIGLLOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	bool CFKGHHENCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	KBEKBNCLGHN FNOJKPPCACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	EEDPJNEGGND ILKLIPOPHHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	float FJJCCFGDGID
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	Vector3 BNHFKFNPDPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	Vector3 CMEMCAJMCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	Vector3 KGIKDNLAIJI
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	Vector3 MPJHCFFFBCB
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	bool AGMJNELEPLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool PDNJONMGPFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	bool PHCNJGABGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	bool MGCPGJHDFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 IHHGKFNOHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	Vector3 GFGBHLMKMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	Vector3 LEEOAJNGIPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Vector3 IOFFILBCPEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	float JENDPKCADIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	float MKFFGCDCLEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	Vector3 GMKLHNOOCHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	Quaternion IMBCPLCGJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	float HFKLAHKFHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	float PNDGOKFEDJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool EEHEIGJJHBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	LHKNHJGBEJF BOBAFFPNPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	bool JAGALNHALBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	Transform ECALKHMOCAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	Vector3 FJAGBNIPGIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	float MOEIMOPHBKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	float FMFFGMIBDPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	Quaternion KGOJCBJLFFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	Vector3 IDFHMANDJJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	Quaternion AFGCAICPPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	RigidbodyConstraints OOOJOFPCOHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	bool LENKKJOJBED
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	CollisionDetectionMode AHJBBDPMKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	bool BKLEDBPBJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event ABCFNANMJEH DLGCBHGBIGD;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event ABCFNANMJEH AMPKBFPIGMC;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event ABCFNANMJEH EJNDOJMAFEC;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event ABCFNANMJEH LJLJHKPHCPE;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event ABCFNANMJEH HIKFKADFDIM;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event ABCFNANMJEH HLNBJJEAFIF;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event ABCFNANMJEH GGGKEGBLLDN;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event DFMABCKBGFJ MKGNAFDKGNB;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<KEIJGPDJMGG, KEIJGPDJMGG> GFFKNFIOBDA;

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	BNECIELGDHO MODBIOGMKLN(int PNJCJGEIDHG);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void OLOEKKEFKGH((Quaternion rot, Vector3 moments) MCEDHANOLMG);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void GPGBEHCLMLG();

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void PFGBIFMDMGL();

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void FBMIFNPDOBJ();

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void NNOLKKHFMBJ();

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void BNIJGPOBDBF();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void KBJIKDOEMIH(BNECIELGDHO MGONBEDEDON, bool FMFJOLALOHP = false);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void ELAMCHIGAIP(object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void GCPOGAIPMCD(object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 OGCMCOEJLOF(Vector3 EJOPPMIDHIG);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 COMNIPFJHDC(Vector3 FJMKECGDEHL);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void EPFKJKBLHNI();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void GCKOGNPMGDN();

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void GLJPEOPHCGP();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void FAFALCKHNNJ(Vector3 LICAIPLHADH, Vector3 IEEFOOJGDGH);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void PLLMCGPENGI(Vector3 DMGPMFJCFAD, Vector3 FGJALIKHFNI);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void EPAEGBNKPOH(Vector3 PCHFPENLEBH);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void KONLEDECMEO(AILNCLJHELL IAIOELIFIPI, Vector3 MKHKJGAKHCA, float NOAIONKJIBJ, float EKAEALFGBGP = 8f, float PPFLELGLCLE = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void BJIGIBPLKMN(HGKMNDKCDJL GGIOLKEGMJK, Vector3 DIFGALLBNBL, float OIKLFIKCAKB = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void CDPCCFBHJHB(HGKMNDKCDJL GGIOLKEGMJK, Vector3 FENAGHBAFHI, float LDHDGMKHGLA = 7f, float ADJPAMDCLMJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 JKPEHNKINEK(Vector3 MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 LEPJJJAHEIP(Vector3 MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void FFGFFHNGODE();

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void DGICNDPJFON(BNECIELGDHO HKGJBJLGAIL, object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void ILIMMABEMNH(object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void COMFHGOINGI();

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void IGCHGOHEDMC();

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void OJPJFPODHEH();

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool DKICDGBHGLB();

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void OCNEDMICAHL();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void LEPCAHFKKDG(object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void JGOMBCGABON(object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void HHHFHBOFPJB(object KAJENDFCCBJ, bool MANNIEELCNM);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void FHCCDOBKNOB(Vector3 OJLODNLPIPG, Quaternion CCMCEGFNOFE);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void HCGODMOIKEE(Vector3 JGIAKOLAGIC, Quaternion NJIJACEFFCF);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool EICFPPPAGPJ(float KEPHKFOICBM);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void DLFKPGKOFKI(object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void BAILKOABOHO(object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void KFINFFPHJDI(object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void PGCMGOGPNMJ(object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void KKNADNFGPJB(Vector3 IBCIAMDAPFE, ForceMode BHFCPGJKENA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void JPGMEKBHFNN(Vector3 IBCIAMDAPFE, Vector3 KKEEFCOJJFM, ForceMode BHFCPGJKENA);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void BCGENJMAGII(Vector3 MEBPAMBPAPG, ForceMode BHFCPGJKENA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void HFHPBIDEFKL(Vector3 MEBPAMBPAPG, ForceMode BHFCPGJKENA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool IJOONHLEMGL(Vector3 LONBCENHPHO, [Out] RaycastHit CLGLGLNJAHH, float IOEOMGELKJC);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void ILNDMFOFEJK();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface EEDPJNEGGND
{
	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFIFHEPBDOD(Vector3 IAGOHNAGODO);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMKJDHAKAAG(Vector3 CGCEKAJGJHA);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LJDGPHGEOJM(Vector3 IAGOHNAGODO);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CLBCKJHIDOJ(Vector3 CGCEKAJGJHA);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface KBEKBNCLGHN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 BEELMBEPLJJ();

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 ECLENGGGJIB();

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KECDCMOIKJJ(float NJGMPBOKJKF, float FOIANHBCDBC);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public delegate void ABCFNANMJEH(LHDELCHFOJE ILMAOAKPPCK);
[Cpp2IlInjected.Token(Token = "0x2000059")]
public enum OKGPNKIELCO
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
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum AILNCLJHELL
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
[Cpp2IlInjected.Token(Token = "0x200005B")]
public delegate void DFMABCKBGFJ(LHDELCHFOJE ILMAOAKPPCK, bool FMFJOLALOHP = false);
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum HGKMNDKCDJL
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct FEENKBGNJLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Rigidbody JGLNBKCPMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public object AMHLEGGNPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Vector3 EHOBMIPPFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector3 ENANGLGEIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public CAKMKKHPGOG CKOJAFBCIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public bool AOGIONLCMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool NAKOFAOBALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool BPGJCDABIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool EKBOOGFIAOM;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public readonly struct MGMNCEJOGLO : IEquatable<MGMNCEJOGLO>
{
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public static readonly MGMNCEJOGLO NFLNDOEFHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public GameObject EMOLHEPHCGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x81757E0", Offset = "0x8173FE0", VA = "0x1881757E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public JKKCHPONOAD CCNPHGHHLPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8175160", Offset = "0x8173960", VA = "0x188175160")]
		get
		{
			return default(JKKCHPONOAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public HGLHFINFANA KCKPHNCKMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x81754D0", Offset = "0x8173CD0", VA = "0x1881754D0")]
		get
		{
			return default(HGLHFINFANA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public RRObjectPrefabData DPHNLKFPOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x8175B60", Offset = "0x8174360", VA = "0x188175B60")]
		get
		{
			return default(RRObjectPrefabData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool GMHJOGPAJPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x81752F0", Offset = "0x8173AF0", VA = "0x1881752F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool FMEKBCEKKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x81755A0", Offset = "0x8173DA0", VA = "0x1881755A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool PCILNIONOMG
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x81754B0", Offset = "0x8173CB0", VA = "0x1881754B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool ILJNKAMKMAG
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8175200", Offset = "0x8173A00", VA = "0x188175200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool OKPOOMNLFDA
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8175C80", Offset = "0x8174480", VA = "0x188175C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool MGPFFCFMDLC
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8175700", Offset = "0x8173F00", VA = "0x188175700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool CGDDAFIGKPH
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x81756C0", Offset = "0x8173EC0", VA = "0x1881756C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool BHDLHBKJNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8175DC0", Offset = "0x81745C0", VA = "0x188175DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool NLAFGOBCIHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8175470", Offset = "0x8173C70", VA = "0x188175470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool MDDJJOAJIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x81757A0", Offset = "0x8173FA0", VA = "0x1881757A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool NJLGCDIEDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x81753F0", Offset = "0x8173BF0", VA = "0x1881753F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool PPMIFCPOBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x8175220", Offset = "0x8173A20", VA = "0x188175220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public BJOHGKDEPON DJIDDHPLHIA
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BJOHGKDEPON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public PLHPJAFGADG IDAGPGMBBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(PLHPJAFGADG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public PFINPHLHIOA JLNMIBFLOLN
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(PFINPHLHIOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public MOOLOKGPKEN KDCCBBBLHHG
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MOOLOKGPKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public AJPBFAPDOOM BDNAAPAOFBH
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(AJPBFAPDOOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public BNEGDALJOLJ ENACOJOFEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BNEGDALJOLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public MKFKLPDAHHI HNEBHJPMGOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MKFKLPDAHHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public ADBDNHDGGCP LBGCNCIIHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(ADBDNHDGGCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public BOBLOGFEFKN MDADILPENPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BOBLOGFEFKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public FNGHPOBHMKE KIJEHIKHJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(FNGHPOBHMKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public CJGCOLMILKL CKBJHLBCGHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(CJGCOLMILKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public DMAIMBCFMPL ECKDAPLCNDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(DMAIMBCFMPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public HHDGKFAKHII KPKLNKICBDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(HHDGKFAKHII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public FBGMGCKICAI FJGKLDCKIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(FBGMGCKICAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool CLPPOEPPMEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8175970", Offset = "0x8174170", VA = "0x188175970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool HLHJFNHCHCL
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8175760", Offset = "0x8173F60", VA = "0x188175760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool FDAKEKPNHCC
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8175E00", Offset = "0x8174600", VA = "0x188175E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool KPPNCAJEGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8175350", Offset = "0x8173B50", VA = "0x188175350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool HMHCOKPLPJK
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8175310", Offset = "0x8173B10", VA = "0x188175310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool FECPHMNFOPI
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8175430", Offset = "0x8173C30", VA = "0x188175430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public bool ONFJONNHFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8175260", Offset = "0x8173A60", VA = "0x188175260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public FGAOLAHEFHJ GNOACPCNCKE
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(FGAOLAHEFHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public OKIHKIFGHCJ MAINJBKECJH
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(OKIHKIFGHCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private IPIPLKEIAHG CJNOHKMKOLM
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8168880", Offset = "0x8167080", VA = "0x188168880")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
	public static MGMNCEJOGLO KEINEINMKGA(BMGFKKCFMCO BDGEMDMFHPC)
	{
		return default(MGMNCEJOGLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x8175CA0", Offset = "0x81744A0", VA = "0x188175CA0")]
	public FBHGFLHMJFN NEKNPGMOKPH()
	{
		return default(FBHGFLHMJFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x8175730", Offset = "0x8173F30", VA = "0x188175730")]
	public HNCCPNLNKMP JBGAAFGNNNC()
	{
		return default(HNCCPNLNKMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x8175110", Offset = "0x8173910", VA = "0x188175110")]
	public AIOEHGMGPCN BDBPOPFOJNE()
	{
		return default(AIOEHGMGPCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x8175570", Offset = "0x8173D70", VA = "0x188175570")]
	public DJLCPIDJPMG HPFMFKGBJOC()
	{
		return default(DJLCPIDJPMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x81752A0", Offset = "0x8173AA0", VA = "0x1881752A0")]
	public LKDGLPAKKJK CKMGDMECEJM()
	{
		return default(LKDGLPAKKJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x8175A60", Offset = "0x8174260", VA = "0x188175A60")]
	public CJKFIBHCHOD LMLLNIBAENL()
	{
		return default(CJKFIBHCHOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x81755C0", Offset = "0x8173DC0", VA = "0x1881755C0")]
	public void IINPJGDBDLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x8175AB0", Offset = "0x81742B0", VA = "0x188175AB0")]
	public void MMIAFMKGHIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x8175D20", Offset = "0x8174520", VA = "0x188175D20")]
	public bool NLOKFGKPJLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x8175E40", Offset = "0x8174640", VA = "0x188175E40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public MGMNCEJOGLO(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x8166C20", Offset = "0x8165420", VA = "0x188166C20")]
	public static bool KEINEINMKGA(MGMNCEJOGLO MGONBEDEDON)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
	public static BMGFKKCFMCO KEINEINMKGA(MGMNCEJOGLO MGONBEDEDON)
	{
		return default(BMGFKKCFMCO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x8175B50", Offset = "0x8174350", VA = "0x188175B50")]
	public static bool NALNDDPCEFD(MGMNCEJOGLO HBMOFOICGEH, MGMNCEJOGLO LDEEDNGKJOE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x8168860", Offset = "0x8167060", VA = "0x188168860")]
	public static bool BLLMPNNLKNM(MGMNCEJOGLO HBMOFOICGEH, MGMNCEJOGLO LDEEDNGKJOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x8175360", Offset = "0x8173B60", VA = "0x188175360", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(MGMNCEJOGLO KEKEFPAJGHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct HHDGKFAKHII : IEquatable<HHDGKFAKHII>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private JPKBMMOMLHN JBLJOKDKNBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8171580", Offset = "0x816FD80", VA = "0x188171580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private AENKGANHCMH EKDCHCNMKOF
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x81663B0", Offset = "0x8164BB0", VA = "0x1881663B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x8170DD0", Offset = "0x816F5D0", VA = "0x188170DD0")]
	public void AAKKOMJCGMH(uint EBHOIBHGECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x8171480", Offset = "0x816FC80", VA = "0x188171480")]
	public bool MMEGNDDOCLG([Out] uint EBHOIBHGECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x8171070", Offset = "0x816F870", VA = "0x188171070")]
	public bool GHIGMKAFHDC([Out] uint EBHOIBHGECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x8171210", Offset = "0x816FA10", VA = "0x188171210")]
	public void KEJGPBPIKBF(string EBHOIBHGECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x8170ED0", Offset = "0x816F6D0", VA = "0x188170ED0")]
	[CanBeNull]
	public string EJOAPCHNGKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x8171300", Offset = "0x816FB00", VA = "0x188171300")]
	public bool LIFAGCGFIEE([Out] string IJPPIMGMFKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x8171170", Offset = "0x816F970", VA = "0x188171170")]
	public void INBFEPKPNCP(string IJPPIMGMFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public HHDGKFAKHII(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x8170FE0", Offset = "0x816F7E0", VA = "0x188170FE0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(HHDGKFAKHII KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct BJOHGKDEPON : IEquatable<BJOHGKDEPON>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private CDHMBEHALEL NDLIDLFFHJL
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8168580", Offset = "0x8166D80", VA = "0x188168580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private JPKBMMOMLHN ODMPEGEBPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8168230", Offset = "0x8166A30", VA = "0x188168230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public bool DGMECIPEHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x81683B0", Offset = "0x8166BB0", VA = "0x1881683B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool DAHJIFBAGMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8168540", Offset = "0x8166D40", VA = "0x188168540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool DKDNJJNGIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8168700", Offset = "0x8166F00", VA = "0x188168700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public Guid EAGJFJJJHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8168120", Offset = "0x8166920", VA = "0x188168120")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Guid MLDFCHNDCGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8168290", Offset = "0x8166A90", VA = "0x188168290")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Guid PAIFNPNBJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8167DF0", Offset = "0x81665F0", VA = "0x188167DF0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public OKIHKIFGHCJ MAINJBKECJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(OKIHKIFGHCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private AENKGANHCMH EKDCHCNMKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x81663B0", Offset = "0x8164BB0", VA = "0x1881663B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x8168310", Offset = "0x8166B10", VA = "0x188168310")]
	public bool IDLKHNHCNLO([Out] Guid MFJIMNDMCML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x81687C0", Offset = "0x8166FC0", VA = "0x1881687C0")]
	public bool PNDAIDCMHOD([Out] Guid IBMDEKLDACD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8168000", Offset = "0x8166800", VA = "0x188168000")]
	public void EGBLACOIILI(Guid AMJBMFFPJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8168440", Offset = "0x8166C40", VA = "0x188168440")]
	public void IMDLPHLAKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x81685E0", Offset = "0x8166DE0", VA = "0x1881685E0")]
	public Guid OANEABHKDOG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public BJOHGKDEPON(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x81681A0", Offset = "0x81669A0", VA = "0x1881681A0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(BJOHGKDEPON KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct AIOEHGMGPCN : IEquatable<AIOEHGMGPCN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private HAMJIEEPBNM OJIIOECJNIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8166A80", Offset = "0x8165280", VA = "0x188166A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 FNNJJPBFDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8166E90", Offset = "0x8165690", VA = "0x188166E90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Quaternion GBPCDLANLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8166700", Offset = "0x8164F00", VA = "0x188166700")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public MGMNCEJOGLO OIBKPPFJMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8166E00", Offset = "0x8165600", VA = "0x188166E00")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private AENKGANHCMH EKDCHCNMKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x81663B0", Offset = "0x8164BB0", VA = "0x1881663B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x8166AE0", Offset = "0x81652E0", VA = "0x188166AE0")]
	public KDLFINJPBNM HPCLFPAEHBM(Allocator GFNKGIEEHMD)
	{
		return default(KDLFINJPBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x8166950", Offset = "0x8165150", VA = "0x188166950")]
	public bool EHANDKGBBPF(MGMNCEJOGLO MJNLMOPPION)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x81665B0", Offset = "0x8164DB0", VA = "0x1881665B0")]
	public void ACKACBDANKP(Vector3 KKEEFCOJJFM, Quaternion FENAGHBAFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x8166840", Offset = "0x8165040", VA = "0x188166840")]
	public void ECAJAOAGOCO(float DKMKOJPHLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x8166C40", Offset = "0x8165440", VA = "0x188166C40")]
	public void KOGOIHCIHLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public AIOEHGMGPCN(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8166C20", Offset = "0x8165420", VA = "0x188166C20")]
	public static bool KEINEINMKGA(AIOEHGMGPCN MGONBEDEDON)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
	public static BMGFKKCFMCO KEINEINMKGA(AIOEHGMGPCN MGONBEDEDON)
	{
		return default(BMGFKKCFMCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x81669F0", Offset = "0x81651F0", VA = "0x1881669F0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(AIOEHGMGPCN KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct FBHGFLHMJFN : IEquatable<FBHGFLHMJFN>
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly FBHGFLHMJFN NFLNDOEFHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private KCEOHGNKGFN JAEKMGNHFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x816C470", Offset = "0x816AC70", VA = "0x18816C470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
	public Span<MGMNCEJOGLO> FGPCCDOIGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x816C660", Offset = "0x816AE60", VA = "0x18816C660")]
		get
		{
			return default(Span<MGMNCEJOGLO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x816C560", Offset = "0x816AD60", VA = "0x18816C560")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x816C5E0", Offset = "0x816ADE0", VA = "0x18816C5E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public FGAOLAHEFHJ GNOACPCNCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(FGAOLAHEFHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public OKIHKIFGHCJ MAINJBKECJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(OKIHKIFGHCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	private AENKGANHCMH EKDCHCNMKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x81663B0", Offset = "0x8164BB0", VA = "0x1881663B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x816C760", Offset = "0x816AF60", VA = "0x18816C760")]
	public void OEFECFDFEBH(FBHGFLHMJFN KEKEFPAJGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public FBHGFLHMJFN(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x8166C20", Offset = "0x8165420", VA = "0x188166C20")]
	public static bool KEINEINMKGA(FBHGFLHMJFN MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x816C4D0", Offset = "0x816ACD0", VA = "0x18816C4D0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(FBHGFLHMJFN KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
	public static MGMNCEJOGLO KEINEINMKGA(FBHGFLHMJFN DKBBJFIDEGB)
	{
		return default(MGMNCEJOGLO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[DefaultMember("Item")]
public struct OFLLMOPNOGH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Dictionary<int, object> LILGCKMMEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private JEOCDAOJLCO BDOKJFILGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private bool JOOPKFKHMDP;

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		[CompilerGenerated]
		readonly get
		{
			return default(MGMNCEJOGLO);
		}
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public KAMCAEPAIHM NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8178C20", Offset = "0x8177420", VA = "0x188178C20")]
		readonly set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x8178CE0", Offset = "0x81774E0", VA = "0x188178CE0")]
	internal OFLLMOPNOGH(MGMNCEJOGLO HPLLAPMNIJF, bool JOOPKFKHMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x81789D0", Offset = "0x81771D0", VA = "0x1881789D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x3B7C450", Offset = "0x3B7AC50", VA = "0x183B7C450")]
	public void MJDGHPKEDKD<T>(KAMCAEPAIHM MNMCNOJCKAF, T MGONBEDEDON, [Optional] T GJPLADDCFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x8178B00", Offset = "0x8177300", VA = "0x188178B00")]
	public void HKOLMKDGPPH(KAMCAEPAIHM MNMCNOJCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0xE2A210", Offset = "0xE28A10", VA = "0x180E2A210")]
	public Dictionary<int, object> BACLJAEPMIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x8178BB0", Offset = "0x81773B0", VA = "0x188178BB0")]
	private readonly void IABEGPDOFKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class LHCPAJKJBEL
{
	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x8173C10", Offset = "0x8172410", VA = "0x188173C10")]
	public static OFLLMOPNOGH OKKLMFGPIKO(this MGMNCEJOGLO HPLLAPMNIJF)
	{
		return default(OFLLMOPNOGH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct FBGMGCKICAI : IEquatable<FBGMGCKICAI>
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public static readonly FBGMGCKICAI NFLNDOEFHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private bool NJLGCDIEDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x816C010", Offset = "0x816A810", VA = "0x18816C010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public Vector3 AEJILPOIGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x816C180", Offset = "0x816A980", VA = "0x18816C180")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x816C2B0", Offset = "0x816AAB0", VA = "0x18816C2B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x816C230", Offset = "0x816AA30", VA = "0x18816C230")]
	public Vector3 NJFOHMKPIIA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x816C310", Offset = "0x816AB10", VA = "0x18816C310")]
	public void PPLDLFOHKIA([In] Vector3 MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x816C100", Offset = "0x816A900", VA = "0x18816C100")]
	public void KACEANLBPNL([In] Vector3 MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x816C050", Offset = "0x816A850", VA = "0x18816C050")]
	public bool JKNOMFCFGCA([In] Vector3 MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public FBGMGCKICAI(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x816BF80", Offset = "0x816A780", VA = "0x18816BF80", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(FBGMGCKICAI KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x816C390", Offset = "0x816AB90", VA = "0x18816C390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct LLGILKJAMDL : IEquatable<LLGILKJAMDL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x8174AA0", Offset = "0x81732A0", VA = "0x188174AA0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(LLGILKJAMDL KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct OKIHKIFGHCJ : IEquatable<OKIHKIFGHCJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	private KCEOHGNKGFN JAEKMGNHFLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8179C90", Offset = "0x8178490", VA = "0x188179C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public BMGFKKCFMCO PJHMCELBGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8179D80", Offset = "0x8178580", VA = "0x188179D80")]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public MGMNCEJOGLO IFICPJBFHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x817A370", Offset = "0x8178B70", VA = "0x18817A370")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public MGMNCEJOGLO LCHPFLHNGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8179AF0", Offset = "0x81782F0", VA = "0x188179AF0")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	private AENKGANHCMH EKDCHCNMKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x81663B0", Offset = "0x8164BB0", VA = "0x1881663B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x81799F0", Offset = "0x81781F0", VA = "0x1881799F0")]
	public Span<MGMNCEJOGLO> AFCEEKCPKLN()
	{
		return default(Span<MGMNCEJOGLO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x8179FE0", Offset = "0x81787E0", VA = "0x188179FE0")]
	public Span<MGMNCEJOGLO> LJPHKNMKJCH()
	{
		return default(Span<MGMNCEJOGLO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x817A270", Offset = "0x8178A70", VA = "0x18817A270")]
	public Span<MGMNCEJOGLO> NEONDEPKIMH()
	{
		return default(Span<MGMNCEJOGLO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x817A170", Offset = "0x8178970", VA = "0x18817A170")]
	public Span<MGMNCEJOGLO> MPBJIKKCMGI()
	{
		return default(Span<MGMNCEJOGLO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x8179E10", Offset = "0x8178610", VA = "0x188179E10")]
	public bool KBJIKDOEMIH(MGMNCEJOGLO MJNLMOPPION, bool GDOHNGLJJEP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x8179F40", Offset = "0x8178740", VA = "0x188179F40")]
	public bool LBONBJBOBHI(MGMNCEJOGLO AJDDCFHNNNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x8179B80", Offset = "0x8178380", VA = "0x188179B80")]
	public MGMNCEJOGLO BLKLCENJHBF(uint BNPEOEENHME)
	{
		return default(MGMNCEJOGLO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x817A0E0", Offset = "0x81788E0", VA = "0x18817A0E0")]
	public FBHGFLHMJFN LOJCGAEAJJG()
	{
		return default(FBHGFLHMJFN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public OKIHKIFGHCJ(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x8166C20", Offset = "0x8165420", VA = "0x188166C20")]
	public static bool KEINEINMKGA(OKIHKIFGHCJ MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x8179CF0", Offset = "0x81784F0", VA = "0x188179CF0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(OKIHKIFGHCJ KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct PLHPJAFGADG : IEquatable<PLHPJAFGADG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public string DAHGILMMGEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x817C610", Offset = "0x817AE10", VA = "0x18817C610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public string NNHCJAGJFAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x817C270", Offset = "0x817AA70", VA = "0x18817C270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public string HJMNNOFHDCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x817C760", Offset = "0x817AF60", VA = "0x18817C760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public string GGALFNDLPBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x817C370", Offset = "0x817AB70", VA = "0x18817C370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x817C6A0", Offset = "0x817AEA0", VA = "0x18817C6A0")]
	public bool LIFAGCGFIEE([Out] string IJPPIMGMFKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public PLHPJAFGADG(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x817C2E0", Offset = "0x817AAE0", VA = "0x18817C2E0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(PLHPJAFGADG KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct LKDGLPAKKJK : IEquatable<LKDGLPAKKJK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	private MCAKPFLKIGG PGHPPIABEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x81744C0", Offset = "0x8172CC0", VA = "0x1881744C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public DJJLOJMEBGF OMOGBGHMKDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x81749A0", Offset = "0x81731A0", VA = "0x1881749A0")]
		get
		{
			return default(DJJLOJMEBGF);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x8173D60", Offset = "0x8172560", VA = "0x188173D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool JOOOEHMAJOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8173CD0", Offset = "0x81724D0", VA = "0x188173CD0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x8174300", Offset = "0x8172B00", VA = "0x188174300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public IBGBEKHIABD<string> PJPAEPJHMFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x81741E0", Offset = "0x81729E0", VA = "0x1881741E0")]
		get
		{
			return default(IBGBEKHIABD<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x8174640", Offset = "0x8172E40", VA = "0x188174640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public IBGBEKHIABD<string> OHPHOCDDGFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8174760", Offset = "0x8172F60", VA = "0x188174760")]
		get
		{
			return default(IBGBEKHIABD<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8173E70", Offset = "0x8172670", VA = "0x188173E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public IBGBEKHIABD<string> GCBKAHPDLIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8174020", Offset = "0x8172820", VA = "0x188174020")]
		get
		{
			return default(IBGBEKHIABD<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8174880", Offset = "0x8173080", VA = "0x188174880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public IBGBEKHIABD<string> NJDOMALELAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x81743A0", Offset = "0x8172BA0", VA = "0x1881743A0")]
		get
		{
			return default(IBGBEKHIABD<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8174520", Offset = "0x8172D20", VA = "0x188174520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	private AENKGANHCMH EKDCHCNMKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x81663B0", Offset = "0x8164BB0", VA = "0x1881663B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x8174140", Offset = "0x8172940", VA = "0x188174140")]
	public bool HFNKAGMBOJK(BMGFKKCFMCO OINLJEGCCDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public LKDGLPAKKJK(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
	public static BMGFKKCFMCO KEINEINMKGA(LKDGLPAKKJK MGONBEDEDON)
	{
		return default(BMGFKKCFMCO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x8173F90", Offset = "0x8172790", VA = "0x188173F90", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(LKDGLPAKKJK KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct GEJCGDLMHIF : IEquatable<GEJCGDLMHIF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x816FCB0", Offset = "0x816E4B0", VA = "0x18816FCB0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(GEJCGDLMHIF KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct DPDGDNNDLFH : IEquatable<DPDGDNNDLFH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x816B390", Offset = "0x8169B90", VA = "0x18816B390", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(DPDGDNNDLFH KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public readonly struct PFINPHLHIOA : IEquatable<PFINPHLHIOA>
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly ComponentTypes ONLKDGJDANC;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly PFINPHLHIOA NFLNDOEFHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Collider CKDKFCLKGOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x817AE50", Offset = "0x8179650", VA = "0x18817AE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public BAMKOOJPPFO HIBPMELJIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x817AD20", Offset = "0x8179520", VA = "0x18817AD20")]
		get
		{
			return default(BAMKOOJPPFO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x817AFE0", Offset = "0x81797E0", VA = "0x18817AFE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public CAOAEEFLCJP LOBAEHCGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x817A480", Offset = "0x8178C80", VA = "0x18817A480")]
		get
		{
			return default(CAOAEEFLCJP);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x817B0B0", Offset = "0x81798B0", VA = "0x18817B0B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public KDBFAPJFMCH CCENHJLGHHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x817A9F0", Offset = "0x81791F0", VA = "0x18817A9F0")]
		get
		{
			return default(KDBFAPJFMCH);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x817A900", Offset = "0x8179100", VA = "0x18817A900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public float GLAONAGGHEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x817AFA0", Offset = "0x81797A0", VA = "0x18817AFA0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x817AE00", Offset = "0x8179600", VA = "0x18817AE00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool PJADFGKKPIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x817B2F0", Offset = "0x8179AF0", VA = "0x18817B2F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x817AC20", Offset = "0x8179420", VA = "0x18817AC20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public bool BNAHDOLNLHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x817B030", Offset = "0x8179830", VA = "0x18817B030")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x817A950", Offset = "0x8179150", VA = "0x18817A950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public bool EDLFNLKBAOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x817B1F0", Offset = "0x81799F0", VA = "0x18817B1F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x817A4C0", Offset = "0x8178CC0", VA = "0x18817A4C0")]
	public static bool CANEDKKDGGL(MGMNCEJOGLO HHIFBIOFOHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x817A6C0", Offset = "0x8178EC0", VA = "0x18817A6C0")]
	public static bool CLCEOBPBAJN(MGMNCEJOGLO HHIFBIOFOHI, [Out] PFINPHLHIOA CGKFJOFFCIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x817AAC0", Offset = "0x81792C0", VA = "0x18817AAC0")]
	public bool GFNCPBEMIJO([Out] JHKCNIMOAKE MJEGAAMKNMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x817B100", Offset = "0x8179900", VA = "0x18817B100")]
	public bool ODCNIJECBDL([Out] BMGFKKCFMCO MJAMEBJFAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x817ACC0", Offset = "0x81794C0", VA = "0x18817ACC0")]
	public bool GHLHGHNEJAH(KOIOMAEALHN KNDBAOCCLOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x817B270", Offset = "0x8179A70", VA = "0x18817B270")]
	public void OFHJKPDOJMC(KOIOMAEALHN KNDBAOCCLOM, bool CCCAKBLNGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x817AD60", Offset = "0x8179560", VA = "0x18817AD60")]
	public void HGILGLOHJLM(KOIOMAEALHN KNDBAOCCLOM, bool CCCAKBLNGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public PFINPHLHIOA(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x817AA30", Offset = "0x8179230", VA = "0x18817AA30", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(PFINPHLHIOA KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x817B360", Offset = "0x8179B60", VA = "0x18817B360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public readonly struct DJLCPIDJPMG : IEquatable<DJLCPIDJPMG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public bool GLJLCEEMHJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x816B0D0", Offset = "0x81698D0", VA = "0x18816B0D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public DJLCPIDJPMG(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x816B040", Offset = "0x8169840", VA = "0x18816B040", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(DJLCPIDJPMG KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public readonly struct MOOLOKGPKEN : IEquatable<MOOLOKGPKEN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	private FPJOPMDJGMA BCGNFPEHLNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8177350", Offset = "0x8175B50", VA = "0x188177350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private AENKGANHCMH EKDCHCNMKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x81663B0", Offset = "0x8164BB0", VA = "0x1881663B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x8177440", Offset = "0x8175C40", VA = "0x188177440")]
	public void JEBHEJKMCFK(bool FIKNMJMLFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public MOOLOKGPKEN(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x81773B0", Offset = "0x8175BB0", VA = "0x1881773B0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(MOOLOKGPKEN KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct AJPBFAPDOOM : IEquatable<AJPBFAPDOOM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool EHDMEBJGMNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x81676E0", Offset = "0x8165EE0", VA = "0x1881676E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public bool CLNMIFDBADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8167940", Offset = "0x8166140", VA = "0x188167940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool CKKAPNAHIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x81678A0", Offset = "0x81660A0", VA = "0x1881678A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x8167BE0", Offset = "0x81663E0", VA = "0x188167BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool EODENALJAEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x8167360", Offset = "0x8165B60", VA = "0x188167360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool JPBHMGNPCGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x81673B0", Offset = "0x8165BB0", VA = "0x1881673B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool PDNIGHALJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8167600", Offset = "0x8165E00", VA = "0x188167600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool OFJABPOBJLB
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x81679E0", Offset = "0x81661E0", VA = "0x1881679E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool PKLFHCJHIFG
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8167720", Offset = "0x8165F20", VA = "0x188167720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool DDFKFLIMIII
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8167A30", Offset = "0x8166230", VA = "0x188167A30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool BGLEHGIANEP
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8167B90", Offset = "0x8166390", VA = "0x188167B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool GGNOJEIPLEM
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8167850", Offset = "0x8166050", VA = "0x188167850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool HMCOLLKFKCG
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8167990", Offset = "0x8166190", VA = "0x188167990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public bool CADNHLJFJJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x8167690", Offset = "0x8165E90", VA = "0x188167690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public bool OHFCMCOOGGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8167650", Offset = "0x8165E50", VA = "0x188167650")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x8166FE0", Offset = "0x81657E0", VA = "0x188166FE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public BGGCNEGFHDD CCCJPAKFEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x8167B50", Offset = "0x8166350", VA = "0x188167B50")]
		get
		{
			return default(BGGCNEGFHDD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x8167450", Offset = "0x8165C50", VA = "0x188167450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public bool LIENBOMBILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x8167240", Offset = "0x8165A40", VA = "0x188167240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public JMDHHCJMALC JDNHOMCIEPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x81671C0", Offset = "0x81659C0", VA = "0x1881671C0")]
		get
		{
			return default(JMDHHCJMALC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8167B00", Offset = "0x8166300", VA = "0x188167B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public bool IKPCHLMHDAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8167530", Offset = "0x8165D30", VA = "0x188167530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public Vector3 BOMDKCFFMCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x8167770", Offset = "0x8165F70", VA = "0x188167770")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public Vector3 LPGFFAPALHB
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x8167A80", Offset = "0x8166280", VA = "0x188167A80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public bool JGMIEAIGIGD
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x8167040", Offset = "0x8165840", VA = "0x188167040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	private AENKGANHCMH EKDCHCNMKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x81663B0", Offset = "0x8164BB0", VA = "0x1881663B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x81677F0", Offset = "0x8165FF0", VA = "0x1881677F0")]
	public bool IIINDNCMKKM(MDPGAHIEILH KNDBAOCCLOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x81674A0", Offset = "0x8165CA0", VA = "0x1881674A0")]
	public void EFHFFGAKHGO(MDPGAHIEILH KNDBAOCCLOM, bool CCCAKBLNGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x81678F0", Offset = "0x81660F0", VA = "0x1881678F0")]
	public bool JILLCNHBFCG(KPECNNGKFAP KNDBAOCCLOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x8167140", Offset = "0x8165940", VA = "0x188167140")]
	public void CDLNMEJOAMB(KPECNNGKFAP KNDBAOCCLOM, bool CCCAKBLNGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x8167200", Offset = "0x8165A00", VA = "0x188167200")]
	public KPECNNGKFAP CNJHBCONAIM()
	{
		return default(KPECNNGKFAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x8167400", Offset = "0x8165C00", VA = "0x188167400")]
	public bool DJKEBMHIDJH(KPECNNGKFAP MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public AJPBFAPDOOM(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x8167570", Offset = "0x8165D70", VA = "0x188167570", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(AJPBFAPDOOM KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct BNEGDALJOLJ : IEquatable<BNEGDALJOLJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	private FJODELCFDEA NBDMNNMBHHE
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x81691A0", Offset = "0x81679A0", VA = "0x1881691A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	private AENKGANHCMH EKDCHCNMKOF
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x81663B0", Offset = "0x8164BB0", VA = "0x1881663B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x8169500", Offset = "0x8167D00", VA = "0x188169500")]
	public bool HIGLDJBKFNB(HANCEIDOMMA ENEFJOLLDHH, List<MGMNCEJOGLO> EBAHALBPMDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x81699A0", Offset = "0x81681A0", VA = "0x1881699A0")]
	public int MNHOMGLBAAI(HANCEIDOMMA ENEFJOLLDHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x8169AB0", Offset = "0x81682B0", VA = "0x188169AB0")]
	public void NAFJBEKAEAN(List<MGMNCEJOGLO> EBAHALBPMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x8169630", Offset = "0x8167E30", VA = "0x188169630")]
	public int JJKEKPCJLBP(MGMNCEJOGLO OLBBKGLINIK, HANCEIDOMMA ENEFJOLLDHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x8169760", Offset = "0x8167F60", VA = "0x188169760")]
	public MGMNCEJOGLO LGHBKIIKEHP(int PNJCJGEIDHG, HANCEIDOMMA ENEFJOLLDHH)
	{
		return default(MGMNCEJOGLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x8169BC0", Offset = "0x81683C0", VA = "0x188169BC0")]
	public void NEHOIKBOEOH(MGMNCEJOGLO OLBBKGLINIK, HANCEIDOMMA ENEFJOLLDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x8169200", Offset = "0x8167A00", VA = "0x188169200")]
	public bool DHMMOOKHJEK(MGMNCEJOGLO OLBBKGLINIK, HANCEIDOMMA ENEFJOLLDHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x81693F0", Offset = "0x8167BF0", VA = "0x1881693F0")]
	public void GIHOPKGAOOL(HANCEIDOMMA ENEFJOLLDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x8169340", Offset = "0x8167B40", VA = "0x188169340")]
	public bool GIHJEDMJHGE(MGMNCEJOGLO OLBBKGLINIK, HANCEIDOMMA ENEFJOLLDHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x8169890", Offset = "0x8168090", VA = "0x188169890")]
	public bool MLJECEFOLPK(HANCEIDOMMA ENEFJOLLDHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public BNEGDALJOLJ(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x81692B0", Offset = "0x8167AB0", VA = "0x1881692B0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(BNEGDALJOLJ KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public readonly struct MKFKLPDAHHI : IEquatable<MKFKLPDAHHI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private AENKGANHCMH EKDCHCNMKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x81663B0", Offset = "0x8164BB0", VA = "0x1881663B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x8176E20", Offset = "0x8175620", VA = "0x188176E20")]
	public void CJJBFICGDGC(bool MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x8176EB0", Offset = "0x81756B0", VA = "0x188176EB0")]
	public void DEGDLDAKELE(bool MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6150", Offset = "0x3AE4950", VA = "0x183AE6150")]
	public T FDIAPGCGJON<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public MKFKLPDAHHI(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x8176F40", Offset = "0x8175740", VA = "0x188176F40", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(MKFKLPDAHHI KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct ADBDNHDGGCP : IEquatable<ADBDNHDGGCP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool MNLKHDHFHDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x8166430", Offset = "0x8164C30", VA = "0x188166430")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x8166240", Offset = "0x8164A40", VA = "0x188166240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool KJEFCEPMFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x8166330", Offset = "0x8164B30", VA = "0x188166330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public int ANIEJAFONFO
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x81663F0", Offset = "0x8164BF0", VA = "0x1881663F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x8166470", Offset = "0x8164C70", VA = "0x188166470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private AENKGANHCMH EKDCHCNMKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x81663B0", Offset = "0x8164BB0", VA = "0x1881663B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public ADBDNHDGGCP(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x8166290", Offset = "0x8164A90", VA = "0x188166290", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(ADBDNHDGGCP KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct BOBLOGFEFKN : IEquatable<BOBLOGFEFKN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public int POIBEBACCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x8169DD0", Offset = "0x81685D0", VA = "0x188169DD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x8169EA0", Offset = "0x81686A0", VA = "0x188169EA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public int GPHDHLIMBHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x8169EF0", Offset = "0x81686F0", VA = "0x188169EF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x8169CF0", Offset = "0x81684F0", VA = "0x188169CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public uint DNIHBCBJFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x8169E10", Offset = "0x8168610", VA = "0x188169E10")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x8169E50", Offset = "0x8168650", VA = "0x188169E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public BOBLOGFEFKN(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x8169D40", Offset = "0x8168540", VA = "0x188169D40", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(BOBLOGFEFKN KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct FNGHPOBHMKE : IEquatable<FNGHPOBHMKE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	private KCACKMFEHNE EOECKJOAMKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x816F2E0", Offset = "0x816DAE0", VA = "0x18816F2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	private DDJBCBAANIP AHACKHICOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x816F470", Offset = "0x816DC70", VA = "0x18816F470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public bool EEMGKBJFBDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x816F770", Offset = "0x816DF70", VA = "0x18816F770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool DMINMOBLELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x816F110", Offset = "0x816D910", VA = "0x18816F110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool CEDPKCFJECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x816EF70", Offset = "0x816D770", VA = "0x18816EF70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public bool POMDFKADENM
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x816EE70", Offset = "0x816D670", VA = "0x18816EE70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool BDBPGLBECBN
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x816EF40", Offset = "0x816D740", VA = "0x18816EF40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public bool MOJHDPEPPKP
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x816F4D0", Offset = "0x816DCD0", VA = "0x18816F4D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public bool LJKGMKIKCBL
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x816F560", Offset = "0x816DD60", VA = "0x18816F560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public bool FEJKPNHOFAD
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x816EFA0", Offset = "0x816D7A0", VA = "0x18816EFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool HKNNFJJBENA
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x816F1B0", Offset = "0x816D9B0", VA = "0x18816F1B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	private AENKGANHCMH EKDCHCNMKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x81663B0", Offset = "0x8164BB0", VA = "0x1881663B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x816F700", Offset = "0x816DF00", VA = "0x18816F700")]
	public bool JMOCJOOGDJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x816F340", Offset = "0x816DB40", VA = "0x18816F340")]
	public MGMNCEJOGLO EDFFALLFKAM(MGMNCEJOGLO OLBBKGLINIK)
	{
		return default(MGMNCEJOGLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x816F800", Offset = "0x816E000", VA = "0x18816F800")]
	public BMGFKKCFMCO MDHIBELIPBO()
	{
		return default(BMGFKKCFMCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x816F910", Offset = "0x816E110", VA = "0x18816F910")]
	public bool NNGLLCKEOGK(BMGFKKCFMCO OLBBKGLINIK, [Out] BMGFKKCFMCO GPGNHBFOJNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public FNGHPOBHMKE(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x8166C20", Offset = "0x8165420", VA = "0x188166C20")]
	public static bool KEINEINMKGA(FNGHPOBHMKE MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x816F3E0", Offset = "0x816DBE0", VA = "0x18816F3E0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(FNGHPOBHMKE KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct HNCCPNLNKMP : IEquatable<HNCCPNLNKMP>
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly HNCCPNLNKMP NFLNDOEFHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public AHMGEEBMBGP GDLJJFCDNKD
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x81719A0", Offset = "0x81701A0", VA = "0x1881719A0")]
		get
		{
			return default(AHMGEEBMBGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public HJJEDNCFOMD NOCIFGGBANI
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x8171E10", Offset = "0x8170610", VA = "0x188171E10")]
		get
		{
			return default(HJJEDNCFOMD);
		}
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x8171D40", Offset = "0x8170540", VA = "0x188171D40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public ODAFNIPBPOF CCOKKNAJIML
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x8171E50", Offset = "0x8170650", VA = "0x188171E50")]
		get
		{
			return default(ODAFNIPBPOF);
		}
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x8171900", Offset = "0x8170100", VA = "0x188171900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public float NFAPMCGJJLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x8171BC0", Offset = "0x81703C0", VA = "0x188171BC0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x8171950", Offset = "0x8170150", VA = "0x188171950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public Vector3 DJJPFNDLKPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x8171D90", Offset = "0x8170590", VA = "0x188171D90")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x8171A30", Offset = "0x8170230", VA = "0x188171A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public float FMFGECDBGGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x8171CF0", Offset = "0x81704F0", VA = "0x188171CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public CMGJMELDMAG MGOGELABEBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x8171CB0", Offset = "0x81704B0", VA = "0x188171CB0")]
		get
		{
			return default(CMGJMELDMAG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x8171870", Offset = "0x8170070", VA = "0x188171870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool OIJLDMKPBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x81718C0", Offset = "0x81700C0", VA = "0x1881718C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x8171C00", Offset = "0x8170400", VA = "0x188171C00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public FGAOLAHEFHJ GNOACPCNCKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(FGAOLAHEFHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public OKIHKIFGHCJ MAINJBKECJH
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(OKIHKIFGHCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x8171C60", Offset = "0x8170460", VA = "0x188171C60")]
	public GLIAJPACILE JHLJIPNDGIG()
	{
		return default(GLIAJPACILE);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x81719E0", Offset = "0x81701E0", VA = "0x1881719E0")]
	public OHAPFJNKCIG CODJGMLFDGO()
	{
		return default(OHAPFJNKCIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x8171E90", Offset = "0x8170690", VA = "0x188171E90")]
	private bool OKNFHKBLLID(CMGJMELDMAG KNDBAOCCLOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x8171B40", Offset = "0x8170340", VA = "0x188171B40")]
	public void FBIDDPJHKMP(CMGJMELDMAG KNDBAOCCLOM, bool CCCAKBLNGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public HNCCPNLNKMP(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x8166C20", Offset = "0x8165420", VA = "0x188166C20")]
	public static bool KEINEINMKGA(HNCCPNLNKMP MGONBEDEDON)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x8168860", Offset = "0x8167060", VA = "0x188168860")]
	public static bool BLLMPNNLKNM(HNCCPNLNKMP HBMOFOICGEH, HNCCPNLNKMP LDEEDNGKJOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x8171AB0", Offset = "0x81702B0", VA = "0x188171AB0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(HNCCPNLNKMP KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct GLIAJPACILE : IEquatable<GLIAJPACILE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public HNCCPNLNKMP IKLDEACACAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(HNCCPNLNKMP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public HBIFHMNPGDK ADOIFIGOBEO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x8170710", Offset = "0x816EF10", VA = "0x188170710")]
		get
		{
			return default(HBIFHMNPGDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public GLIAJPACILE(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x8166C20", Offset = "0x8165420", VA = "0x188166C20")]
	public static bool KEINEINMKGA(GLIAJPACILE MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x8170750", Offset = "0x816EF50", VA = "0x188170750", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(GLIAJPACILE KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[DefaultMember("Item")]
public readonly struct OHAPFJNKCIG : IEquatable<OHAPFJNKCIG>
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly OHAPFJNKCIG NFLNDOEFHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	private EDDIOCAGPLM CGJMJJADIPN
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x8179880", Offset = "0x8178080", VA = "0x188179880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public HNCCPNLNKMP IKLDEACACAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(HNCCPNLNKMP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public ONDGGPNOKFN HFDJGOOMOHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x8179760", Offset = "0x8177F60", VA = "0x188179760")]
		get
		{
			return default(ONDGGPNOKFN);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x8178E40", Offset = "0x8177640", VA = "0x188178E40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public IEnumerable<NOMICBGIFOL> LLFHEFIGKMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x81794E0", Offset = "0x8177CE0", VA = "0x1881794E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public NOMICBGIFOL NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x81798E0", Offset = "0x81780E0", VA = "0x1881798E0")]
		get
		{
			return default(NOMICBGIFOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x81796D0", Offset = "0x8177ED0", VA = "0x1881796D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public FGAOLAHEFHJ GNOACPCNCKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(FGAOLAHEFHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	private AENKGANHCMH EKDCHCNMKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x81663B0", Offset = "0x8164BB0", VA = "0x1881663B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x8179220", Offset = "0x8177A20", VA = "0x188179220")]
	public NOMICBGIFOL GJNOLKEIEHM(float3? KKEEFCOJJFM, [Optional] quaternion? FENAGHBAFHI, [Optional] Vector3? DKMKOJPHLDD)
	{
		return default(NOMICBGIFOL);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x8178F60", Offset = "0x8177760", VA = "0x188178F60")]
	public NOMICBGIFOL DBIMNIOCAGM(int PNJCJGEIDHG, float3? KKEEFCOJJFM, [Optional] quaternion? FENAGHBAFHI, [Optional] Vector3? DKMKOJPHLDD)
	{
		return default(NOMICBGIFOL);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x8179440", Offset = "0x8177C40", VA = "0x188179440")]
	public void HNMLFODLNIF(int PNJCJGEIDHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x8178DB0", Offset = "0x81775B0", VA = "0x188178DB0")]
	public void CGGBONADGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public OHAPFJNKCIG(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x8166C20", Offset = "0x8165420", VA = "0x188166C20")]
	public static bool KEINEINMKGA(OHAPFJNKCIG MGONBEDEDON)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x8175B50", Offset = "0x8174350", VA = "0x188175B50")]
	public static bool NALNDDPCEFD(OHAPFJNKCIG HBMOFOICGEH, OHAPFJNKCIG LDEEDNGKJOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x8179190", Offset = "0x8177990", VA = "0x188179190", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(OHAPFJNKCIG KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct NOMICBGIFOL : IEquatable<NOMICBGIFOL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public OHAPFJNKCIG CCOFILNGNIF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x8177800", Offset = "0x8176000", VA = "0x188177800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public float3 IDFHMANDJJE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x8177AD0", Offset = "0x81762D0", VA = "0x188177AD0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x8177B30", Offset = "0x8176330", VA = "0x188177B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public quaternion AFGCAICPPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x81779E0", Offset = "0x81761E0", VA = "0x1881779E0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x8177A80", Offset = "0x8176280", VA = "0x188177A80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public float3 IFJBKFHAOAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8177880", Offset = "0x8176080", VA = "0x188177880")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x8177980", Offset = "0x8176180", VA = "0x188177980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public CDNLFFIPOFD PMDGMDMJLCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x8177A30", Offset = "0x8176230", VA = "0x188177A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x8177970", Offset = "0x8176170", VA = "0x188177970")]
	public void GMHJDJMDFJA(OHAPFJNKCIG MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public NOMICBGIFOL(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x81778E0", Offset = "0x81760E0", VA = "0x1881778E0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(NOMICBGIFOL KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public readonly struct CJKFIBHCHOD : IEquatable<CJKFIBHCHOD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public bool MLDEKDPACDG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x816AD30", Offset = "0x8169530", VA = "0x18816AD30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public CJKFIBHCHOD(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x816ACA0", Offset = "0x81694A0", VA = "0x18816ACA0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(CJKFIBHCHOD KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct CJGCOLMILKL : IEquatable<CJGCOLMILKL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	private INFBPKBBKJP GKMILBMHIFD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x816AAA0", Offset = "0x81692A0", VA = "0x18816AAA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public bool AFIMHEOEGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x816A1D0", Offset = "0x81689D0", VA = "0x18816A1D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x816A170", Offset = "0x8168970", VA = "0x18816A170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public bool EACFHHDLIGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x816A900", Offset = "0x8169100", VA = "0x18816A900")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x816A5F0", Offset = "0x8168DF0", VA = "0x18816A5F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public float JMBACJPJFDG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x816AC60", Offset = "0x8169460", VA = "0x18816AC60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x816AB00", Offset = "0x8169300", VA = "0x18816AB00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	public bool MMOGMOPOIMK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x816A360", Offset = "0x8168B60", VA = "0x18816A360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	public BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	private AENKGANHCMH EKDCHCNMKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x81663B0", Offset = "0x8164BB0", VA = "0x1881663B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x816A860", Offset = "0x8169060", VA = "0x18816A860")]
	public void KMLKPDJEIKB(int PKBMMFHCONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x816AB50", Offset = "0x8169350", VA = "0x18816AB50")]
	public bool NDEPCGPCBDG([Out] int PKBMMFHCONE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x816A0D0", Offset = "0x81688D0", VA = "0x18816A0D0")]
	public void BCIILJMMEBG(bool KNMHKJJNIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x816A810", Offset = "0x8169010", VA = "0x18816A810")]
	public bool KKDGCKNCIOM(NKDJMMDIMMK KNDBAOCCLOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x816A570", Offset = "0x8168D70", VA = "0x18816A570")]
	public void FINJINDDDNL(NKDJMMDIMMK KNDBAOCCLOM, bool CCCAKBLNGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x816A220", Offset = "0x8168A20", VA = "0x18816A220")]
	public void DPLIAMPGFMF(float MLPLEACOMMB, float LPLGFPMGJIC, float ADHNDJNFNBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x816A950", Offset = "0x8169150", VA = "0x18816A950")]
	public void LJBEKAKELCA(float3 DOOKOGKNGAM, quaternion NMCELDIPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x816A440", Offset = "0x8168C40", VA = "0x18816A440")]
	public bool FFHBEOPOHED([Out] float3 DOOKOGKNGAM, [Out] quaternion NMCELDIPHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x816A650", Offset = "0x8168E50", VA = "0x18816A650")]
	public bool IHHOECBBFHK([Out] float DHNOPHCKANA, [Out] float JAJOAFCPHJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x816A780", Offset = "0x8168F80", VA = "0x18816A780")]
	public void INGIMKKOAFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public CJGCOLMILKL(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x816A3B0", Offset = "0x8168BB0", VA = "0x18816A3B0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(CJGCOLMILKL KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct FGAOLAHEFHJ : IEquatable<FGAOLAHEFHJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	private HJKEFICBHPD MCHHOAIGOCE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x816D7C0", Offset = "0x816BFC0", VA = "0x18816D7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public Vector3 IDFHMANDJJE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x816E790", Offset = "0x816CF90", VA = "0x18816E790")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x816EBA0", Offset = "0x816D3A0", VA = "0x18816EBA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public Quaternion AFGCAICPPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x816DDF0", Offset = "0x816C5F0", VA = "0x18816DDF0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x816E200", Offset = "0x816CA00", VA = "0x18816E200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public Vector3 FJAGBNIPGIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x816E0B0", Offset = "0x816C8B0", VA = "0x18816E0B0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x816DFE0", Offset = "0x816C7E0", VA = "0x18816DFE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public Quaternion KGOJCBJLFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x816D2E0", Offset = "0x816BAE0", VA = "0x18816D2E0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x816CD00", Offset = "0x816B500", VA = "0x18816CD00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public float MOEIMOPHBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x816DA20", Offset = "0x816C220", VA = "0x18816DA20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x816D970", Offset = "0x816C170", VA = "0x18816D970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public float FMFFGMIBDPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x816E8E0", Offset = "0x816D0E0", VA = "0x18816E8E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	public Matrix4x4 NJMIDHHHLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x816DDB0", Offset = "0x816C5B0", VA = "0x18816DDB0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public OKIHKIFGHCJ MAINJBKECJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(OKIHKIFGHCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	private IPIPLKEIAHG CJNOHKMKOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x8168880", Offset = "0x8167080", VA = "0x188168880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x816CCB0", Offset = "0x816B4B0", VA = "0x18816CCB0")]
	public HOAIPFDEDJB BBGNKMGCMLG()
	{
		return default(HOAIPFDEDJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x816CDD0", Offset = "0x816B5D0", VA = "0x18816CDD0")]
	public void DHECGDHGPDN([Out] Matrix4x4 DJHJNAPODOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x816E2D0", Offset = "0x816CAD0", VA = "0x18816E2D0")]
	public void MNLHNDLALCJ([In] Vector3 BAIEFBENFCP, [In] Quaternion HBPGIGGIBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x816E3D0", Offset = "0x816CBD0", VA = "0x18816E3D0")]
	public void MNLHNDLALCJ([In] RigidTransform LKAPFOMKCNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x816DF30", Offset = "0x816C730", VA = "0x18816DF30")]
	public void LINDAPLJGKG([Out] RigidTransform LKAPFOMKCNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x816E5F0", Offset = "0x816CDF0", VA = "0x18816E5F0")]
	public void NGOJDGEIAOH([In] Vector3 ENPJLBGAJOJ, [In] Quaternion DEALKAGLNOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x816E530", Offset = "0x816CD30", VA = "0x18816E530")]
	public void NGOJDGEIAOH([In] RigidTransform IPFGPMNNMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x816DC00", Offset = "0x816C400", VA = "0x18816DC00")]
	public void JDHPOMKAKJP([Out] Vector3 ENPJLBGAJOJ, [Out] Quaternion DEALKAGLNOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x816DB50", Offset = "0x816C350", VA = "0x18816DB50")]
	public void JDHPOMKAKJP([Out] RigidTransform LKAPFOMKCNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x816D940", Offset = "0x816C140", VA = "0x18816D940")]
	public UniformTRS IGFOCAOANJJ()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x816D880", Offset = "0x816C080", VA = "0x18816D880")]
	public void IGFOCAOANJJ([Out] UniformTRS IPFGPMNNMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x816D4B0", Offset = "0x816BCB0", VA = "0x18816D4B0")]
	public UniformTRS FMKIHILACIL()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x816D4E0", Offset = "0x816BCE0", VA = "0x18816D4E0")]
	public void FMKIHILACIL([Out] UniformTRS LKAPFOMKCNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x816EA50", Offset = "0x816D250", VA = "0x18816EA50")]
	public Vector3 PHBHLBPPDLH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x816CEE0", Offset = "0x816B6E0", VA = "0x18816CEE0")]
	public void DOMFPCFALNE([In] Vector3 MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x816D670", Offset = "0x816BE70", VA = "0x18816D670")]
	public Vector3 HFPOGNLNGPI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x816E980", Offset = "0x816D180", VA = "0x18816E980")]
	public void OOBLBMAJLBN([In] Vector3 MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x816CFB0", Offset = "0x816B7B0", VA = "0x18816CFB0")]
	public Quaternion EBJIPADPAAB()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x816DCE0", Offset = "0x816C4E0", VA = "0x18816DCE0")]
	public void KAHDEMFODHB([In] Quaternion MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x816D0F0", Offset = "0x816B8F0", VA = "0x18816D0F0")]
	public Quaternion EFGPPLGBGFP()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x816D5A0", Offset = "0x816BDA0", VA = "0x18816D5A0")]
	public void HAJCCMKDEMI([In] Quaternion MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x816E490", Offset = "0x816CC90", VA = "0x18816E490")]
	public float NDKPPAAFJJO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x816D230", Offset = "0x816BA30", VA = "0x18816D230")]
	public void EMIJAPGGLFE(float MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x816E6F0", Offset = "0x816CEF0", VA = "0x18816E6F0")]
	public float NKDLFGPKEMJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x816CC00", Offset = "0x816B400", VA = "0x18816CC00")]
	public void ACBPLMIBGFP(float MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x816DAC0", Offset = "0x816C2C0", VA = "0x18816DAC0")]
	public Vector3 JAJFDIEAAIB([In] Vector3 LONBCENHPHO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public FGAOLAHEFHJ(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x816D420", Offset = "0x816BC20", VA = "0x18816D420", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(FGAOLAHEFHJ KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public readonly struct DMAIMBCFMPL : IEquatable<DMAIMBCFMPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	private BFMGKHADBNH FEEABLIAKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x816B330", Offset = "0x8169B30", VA = "0x18816B330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	private AENKGANHCMH EKDCHCNMKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x81663B0", Offset = "0x8164BB0", VA = "0x1881663B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x816B1F0", Offset = "0x81699F0", VA = "0x18816B1F0")]
	public void JFGOPILEAFN(string JIDPAGEBNDJ, PGCLLCDEJPL OKNIDGHPEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public DMAIMBCFMPL(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x816B160", Offset = "0x8169960", VA = "0x18816B160", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(DMAIMBCFMPL KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x8166500", Offset = "0x8164D00", VA = "0x188166500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public readonly struct JJEFEBGGJPA : IEquatable<JJEFEBGGJPA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public EGIPCMMOIAA JEJEIEICFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x81724A0", Offset = "0x8170CA0", VA = "0x1881724A0")]
		get
		{
			return default(EGIPCMMOIAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public JJEFEBGGJPA(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x8172410", Offset = "0x8170C10", VA = "0x188172410", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(JJEFEBGGJPA KEKEFPAJGHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public readonly struct ODFNJPPFOLJ : IEquatable<ODFNJPPFOLJ>
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public struct GICEHHCFAAE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private BMGFKKCFMCO MIKNGKGCFKJ;

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x8170670", Offset = "0x816EE70", VA = "0x188170670")]
		public GICEHHCFAAE(BMGFKKCFMCO MIKNGKGCFKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x81705E0", Offset = "0x816EDE0", VA = "0x1881705E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x8178240", Offset = "0x8176A40", VA = "0x188178240")]
	public GICEHHCFAAE BCCDIBFCGGG()
	{
		return default(GICEHHCFAAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x81785C0", Offset = "0x8176DC0", VA = "0x1881785C0")]
	public PKNPJEMEFKI IMIGKACNLNH(Allocator GFNKGIEEHMD = Allocator.Temp)
	{
		return default(PKNPJEMEFKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x8178490", Offset = "0x8176C90", VA = "0x188178490")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> IMANLMFGDFE(Allocator GFNKGIEEHMD = Allocator.Temp)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x8178110", Offset = "0x8176910", VA = "0x188178110")]
	public NativeArray<JKKCHPONOAD> AIKFDLFFKGC(Allocator GFNKGIEEHMD = Allocator.Temp)
	{
		return default(NativeArray<JKKCHPONOAD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x8178770", Offset = "0x8176F70", VA = "0x188178770")]
	public NativeArray<JKKCHPONOAD> NNEMJGHPDOK(Allocator GFNKGIEEHMD = Allocator.Temp)
	{
		return default(NativeArray<JKKCHPONOAD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x8178640", Offset = "0x8176E40", VA = "0x188178640")]
	public KDLFINJPBNM LGFEPGLONLD(Allocator GFNKGIEEHMD = Allocator.Temp)
	{
		return default(KDLFINJPBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x8178360", Offset = "0x8176B60", VA = "0x188178360")]
	public KDLFINJPBNM FGJKFFEKKCL(Allocator GFNKGIEEHMD = Allocator.Temp)
	{
		return default(KDLFINJPBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x81788A0", Offset = "0x81770A0", VA = "0x1881788A0")]
	public KDLFINJPBNM PJDOIOAHHIC(Allocator GFNKGIEEHMD = Allocator.Temp)
	{
		return default(KDLFINJPBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public ODFNJPPFOLJ(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x81782D0", Offset = "0x8176AD0", VA = "0x1881782D0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(ODFNJPPFOLJ KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x81723F0", Offset = "0x8170BF0", VA = "0x1881723F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct OANNAODKOPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int HINJLPNLHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int HOFEHKBNHLF;
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct JIJIPCHGCJC : IEquatable<JIJIPCHGCJC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public ODFNJPPFOLJ NHIHNGKIMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(ODFNJPPFOLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public JLJMMPNBINC EOJDHIBJAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(JLJMMPNBINC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public JJEFEBGGJPA JIELCJBKAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(JJEFEBGGJPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x8172350", Offset = "0x8170B50", VA = "0x188172350")]
	public bool NDNJMMPOIDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x81721E0", Offset = "0x81709E0", VA = "0x1881721E0")]
	public bool HHLEJCBPAHK([Out] Exception PAPMAHJECNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public JIJIPCHGCJC(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
	public static BMGFKKCFMCO KEINEINMKGA(JIJIPCHGCJC MGONBEDEDON)
	{
		return default(BMGFKKCFMCO);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x8172150", Offset = "0x8170950", VA = "0x188172150", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(JIJIPCHGCJC KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x81723F0", Offset = "0x8170BF0", VA = "0x1881723F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public readonly struct GNIODDEODAP : IDisposable, IEquatable<GNIODDEODAP>
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public static readonly GNIODDEODAP NFLNDOEFHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public JIJIPCHGCJC FJOIPOCPLKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(JIJIPCHGCJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public ODFNJPPFOLJ NHIHNGKIMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(ODFNJPPFOLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x8170B20", Offset = "0x816F320", VA = "0x188170B20")]
	public void HGHLBDEMLGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x81709C0", Offset = "0x816F1C0", VA = "0x1881709C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public GNIODDEODAP(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x8170A90", Offset = "0x816F290", VA = "0x188170A90", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "5")]
	public bool Equals(GNIODDEODAP KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x8170BA0", Offset = "0x816F3A0", VA = "0x188170BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public readonly struct JLJMMPNBINC : IEquatable<JLJMMPNBINC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public bool FEJGBCENHBI
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x8172590", Offset = "0x8170D90", VA = "0x188172590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	public JLJMMPNBINC(BMGFKKCFMCO MIKNGKGCFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x81663C0", Offset = "0x8164BC0", VA = "0x1881663C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x8172620", Offset = "0x8170E20", VA = "0x188172620", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x8166320", Offset = "0x8164B20", VA = "0x188166320", Slot = "4")]
	public bool Equals(JLJMMPNBINC KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x81723F0", Offset = "0x8170BF0", VA = "0x1881723F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class NEEDGFKKMON
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private struct JMEJMPNIOHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Guid JMHOEKKPCPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public KHBHFFLGMND OBGGPFDDNNF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	private struct KHBHFFLGMND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int MGONBEDEDON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int GIJBBJGBHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int PCPAJAADPPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int DDBDOOFMAEC;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x8173470", Offset = "0x8171C70", VA = "0x188173470")]
		public bool CADHDHMALMH([Out] JKKCHPONOAD JLCFKNGJCID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x8173510", Offset = "0x8171D10", VA = "0x188173510")]
		public KHBHFFLGMND(JKKCHPONOAD JLCFKNGJCID)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x8177580", Offset = "0x8175D80", VA = "0x188177580")]
	public static Guid MKKCNAKNDMG(this JKKCHPONOAD JLCFKNGJCID)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x8177560", Offset = "0x8175D60", VA = "0x188177560")]
	public static bool AHJGIHOPKAE(this Guid JMHOEKKPCPG, [Out] JKKCHPONOAD JLCFKNGJCID)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal static class HJJCLPAOLJI
{
	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x8171670", Offset = "0x816FE70", VA = "0x188171670")]
	public static AENKGANHCMH EKDCHCNMKOF(this BMGFKKCFMCO EBHOIBHGECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x8171700", Offset = "0x816FF00", VA = "0x188171700")]
	public static MGOAOGOOHDM IAJPEJHMHCA(this BMGFKKCFMCO EBHOIBHGECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x81715E0", Offset = "0x816FDE0", VA = "0x1881715E0")]
	public static EntityManager BAGCDNKPGAO(this BMGFKKCFMCO EBHOIBHGECB)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x3A06B20", Offset = "0x3A05320", VA = "0x183A06B20")]
	internal static bool NBNMFFKIFBO<T>(this BMGFKKCFMCO EBHOIBHGECB, bool CCCAKBLNGCG) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x8171760", Offset = "0x816FF60", VA = "0x188171760")]
	public static bool OIEAFJFPCNK(this BMGFKKCFMCO EBHOIBHGECB, KIDCJKDOKEJ JMHMMNHPIAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x3A09710", Offset = "0x3A07F10", VA = "0x183A09710")]
	public static bool PPJMNKIKHFA<T>(this BMGFKKCFMCO EBHOIBHGECB) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x3A04D10", Offset = "0x3A03510", VA = "0x183A04D10")]
	public static bool KELENELALDB<T>(this BMGFKKCFMCO EBHOIBHGECB) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x3A04E60", Offset = "0x3A03660", VA = "0x183A04E60")]
	[OPIMMEAFNNB]
	public static T MBFGKBLDMJO<T>(this BMGFKKCFMCO EBHOIBHGECB) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x3A06CE0", Offset = "0x3A054E0", VA = "0x183A06CE0")]
	[OPIMMEAFNNB]
	public static T PAHMIPOPCOC<T>(this BMGFKKCFMCO EBHOIBHGECB) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x3A04B00", Offset = "0x3A03300", VA = "0x183A04B00")]
	public static bool ALCFLABOGJJ<T>(this BMGFKKCFMCO EBHOIBHGECB, [Out] T MGONBEDEDON) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x3A04C40", Offset = "0x3A03440", VA = "0x183A04C40")]
	public static T IHFHCHFDPDH<T>(this BMGFKKCFMCO EBHOIBHGECB) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x3A04DC0", Offset = "0x3A035C0", VA = "0x183A04DC0")]
	public static T LLBJFNFAJNA<T>(this BMGFKKCFMCO EBHOIBHGECB) where T : class, IComponentData
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal static class EKHFEDLHBGO
{
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[DefaultMember("Item")]
public struct PKNPJEMEFKI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private KDLFINJPBNM GJKNNKIANJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> DKONFFGFJHL;

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x5E66AB0", Offset = "0x5E652B0", VA = "0x185E66AB0")]
	public PKNPJEMEFKI(KDLFINJPBNM GJKNNKIANJJ, NativeArray<EntityRemapUtility.EntityRemapInfo> DKONFFGFJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x817C1E0", Offset = "0x817A9E0", VA = "0x18817C1E0")]
	public LocalId IEFPLCGPNPB(LocalId HPLLAPMNIJF)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x817C220", Offset = "0x817AA20", VA = "0x18817C220")]
	public LocalId IEFPLCGPNPB(int PNJCJGEIDHG)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x817C170", Offset = "0x817A970", VA = "0x18817C170", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DNBGKNFHGBA
{
	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPAALHAENNA(World NAHDLONMOKF, NativeParallelHashSet<FixedString64Bytes> DEKEJNFHAMF);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JPKBMMOMLHN
{
	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KDLFINJPBNM BBLHMDFMJDP(Allocator GFNKGIEEHMD);

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GHIGMKAFHDC(BMGFKKCFMCO NHDNPGNDBND, [Out] uint EBHOIBHGECB);

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MMEGNDDOCLG(BMGFKKCFMCO NHDNPGNDBND, [Out] uint EBHOIBHGECB);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AAKKOMJCGMH(BMGFKKCFMCO NHDNPGNDBND, uint EBHOIBHGECB);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KFGPALFJOKL(BMGFKKCFMCO NHDNPGNDBND);

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "5")]
	string EJOAPCHNGKP(BMGFKKCFMCO NHDNPGNDBND);

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KEJGPBPIKBF(BMGFKKCFMCO NHDNPGNDBND, string EBHOIBHGECB);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool LIFAGCGFIEE(BMGFKKCFMCO NHDNPGNDBND, [Out] string IJPPIMGMFKM);

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void INBFEPKPNCP(BMGFKKCFMCO NHDNPGNDBND, string IJPPIMGMFKM);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CDHMBEHALEL
{
	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	Guid LNEKBJBJAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	Guid PHJHEFNJDDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DGMECIPEHDD(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task CDKCGPPJONK(MGMNCEJOGLO HPLLAPMNIJF);

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid OANEABHKDOG(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EGBLACOIILI(BMGFKKCFMCO MIKNGKGCFKJ, Guid IBMDEKLDACD);

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IMDLPHLAKBO(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task JOLHCHOHOIB(BMGFKKCFMCO LNFGEICLAJH, BMGFKKCFMCO MJNLMOPPION);

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BBFALIJGFDC(BMGFKKCFMCO MIKNGKGCFKJ, JKKCHPONOAD CPAJDCEBBMM);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HNOKJENDMHB
{
	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	Guid LNEKBJBJAFD
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FGKDHHKDNHC(NativeList<Guid> AGFDJOFACBL, NativeList<Guid> LBMHOGIHABA, NativeList<FixedString64Bytes> OKENMCLFDDD);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BPEPLIGGGAD
{
	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KDLFINJPBNM CFEENPKCDIP(Allocator GFNKGIEEHMD);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KDLFINJPBNM CBHNADPCHMO(Allocator GFNKGIEEHMD);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LJMMPIHMGGD(BMGFKKCFMCO NHDNPGNDBND);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KJEFCEPMFIL(BMGFKKCFMCO NHDNPGNDBND);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GBOOLBEIINE(BMGFKKCFMCO NHDNPGNDBND, [Out] BMGFKKCFMCO LLIOGHBBGHN);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MNLKHDHFHDI(BMGFKKCFMCO NHDNPGNDBND);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OJEFMLEOIMC(BMGFKKCFMCO NHDNPGNDBND, int LFGOLEKPJOL);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BMGFKKCFMCO GABMIANCAAC(BMGFKKCFMCO LLIOGHBBGHN);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IMFHFAELFDC(KDLFINJPBNM NGMIILJPNNB, bool DOICCDMACJP);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JJJPLALLPHJ(BMGFKKCFMCO NHDNPGNDBND);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NBFIGEJKBDG(BMGFKKCFMCO NHDNPGNDBND, bool PLFJIEGODLP);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int OAKLIOGFBMK();

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FGIKGCCINGH(BMGFKKCFMCO MIKNGKGCFKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HAMJIEEPBNM
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<BMGFKKCFMCO, BMGFKKCFMCO> KGLOBAGEIEA;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<BMGFKKCFMCO, BMGFKKCFMCO> NMCHLKCILNI;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<BMGFKKCFMCO, BMGFKKCFMCO, BMGFKKCFMCO> EGJDBCEEFNE;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<BMGFKKCFMCO> HMNOECLFAHO;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EHANDKGBBPF(BMGFKKCFMCO MIKNGKGCFKJ, BMGFKKCFMCO CLPOMKOIOLC);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BMGFKKCFMCO KLIGNFKCNAM(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KDLFINJPBNM HPCLFPAEHBM(BMGFKKCFMCO MIKNGKGCFKJ, Allocator GFNKGIEEHMD);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BMGFKKCFMCO HADAAPFBBBC(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ACKACBDANKP(BMGFKKCFMCO MIKNGKGCFKJ, Vector3 CGHFJMHBGHH, Quaternion LHADJKBBBLM);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ECAJAOAGOCO(BMGFKKCFMCO MIKNGKGCFKJ, float GGCNJHLPPIH);

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool KCDKCFFKCIN(BMGFKKCFMCO MIKNGKGCFKJ, [Out] BMGFKKCFMCO MJNLMOPPION);

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool PFMAOHCEAJJ(BMGFKKCFMCO MIKNGKGCFKJ, [Out] RigidTransform NFKMFKLMHKF);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 NLECBLCDJHG(AIOEHGMGPCN GFAMPLNMOKM);

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion KKAMPKKKBOE(AIOEHGMGPCN GFAMPLNMOKM);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class CHONAJDLPBG
{
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LEGHIHFCIHK
{
	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	object MFMHBDEDDNH
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GKCBPBJJNEK
{
	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDCEOAFFCHB(BMGFKKCFMCO HPLLAPMNIJF, OMNGNIEEKFB CMKGOBJPAMC);

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GLKPHAMCELE(OMNGNIEEKFB CMKGOBJPAMC);

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CKALEBJDNCP(BMGFKKCFMCO MIKNGKGCFKJ, [Out] OMNGNIEEKFB FHEDMOIOCKB);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[Flags]
public enum AMCDFNBLDDC
{
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	IncludeSelf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	IncludeChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	IncludeDescendants = 6,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	IncludeMask = 7,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Disembodied = 8,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Embodied = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	IgnoreEmbodiment = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	EmbodimentMask = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Runtime = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Authored = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	AuthoredAndRuntime = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	HierarchyMask = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	HintInputsAreDisjoint = 0x80
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public readonly struct AAKIIBMHCDL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly string HPANEBBHGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly T GJPLADDCFJL;

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x4C52F90", Offset = "0x4C51790", VA = "0x184C52F90")]
	public AAKIIBMHCDL(T GJPLADDCFJL, [Optional][CallerMemberName] string HPANEBBHGAC)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static readonly AAKIIBMHCDL<int> PPEENNGNDBE;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly AAKIIBMHCDL<int> DDLGEHKFJLE;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly AAKIIBMHCDL<int> CBADLMHDHHO;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public enum LFCFDKOHGFF
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class PJCBNLHBJIB
{
	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x13317A0", Offset = "0x132FFA0", VA = "0x1813317A0")]
	public static bool CAEKPLKPCGC(this LFCFDKOHGFF OJGLGPLNKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x1732030", Offset = "0x1730830", VA = "0x181732030")]
	public static bool NNGEEOEJGCL(this LFCFDKOHGFF OJGLGPLNKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x2F13270", Offset = "0x2F11A70", VA = "0x182F13270")]
	public static bool IMACJEOIEHA(this LFCFDKOHGFF OJGLGPLNKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x13317B0", Offset = "0x132FFB0", VA = "0x1813317B0")]
	public static bool IJAMGGKIHDK(this LFCFDKOHGFF OJGLGPLNKGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface OGPCNLDNBGN
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public enum OIMFNJEEDIF
	{
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		Unloaded,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		Loading,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		Loaded,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public enum NMMENEFKGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	OIMFNJEEDIF NOGKKPLMKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	bool GNJDLNAMGKE
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	bool EFAECJIHKNI
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	NMMENEFKGFJ MAGGIEGMPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[ServiceLifetime(Lifetime.Application)]
public interface CHOEIGPMMOK
{
	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	LFCFDKOHGFF ABEPBEBFAIB
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	LFCFDKOHGFF FGIKHGILDDC
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	LFCFDKOHGFF CKLNKGIOBOE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	LFCFDKOHGFF BFMJNOOKHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	LFCFDKOHGFF BFCFOMLOKKI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	LFCFDKOHGFF NIBCOCOKHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	LFCFDKOHGFF OBPOOIHHLME
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	LFCFDKOHGFF LOBIGEMCNLP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	LFCFDKOHGFF IMCGGEPICPL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	LFCFDKOHGFF JLNMIBFLOLN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	LFCFDKOHGFF GKFIPPOGDGK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	LFCFDKOHGFF ELEBDOOBOBO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	LFCFDKOHGFF MCFIEJEJGCL
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	LFCFDKOHGFF KOLDOMFCPDI
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	LFCFDKOHGFF NOMHDBODGEB
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	LFCFDKOHGFF CAFBEHOHPGP
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	LFCFDKOHGFF JALCHKOCMMF
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	LFCFDKOHGFF GDKMDEPOKHP
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	LFCFDKOHGFF GLPJAKKPGEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	LFCFDKOHGFF KOIBMOKBBIH
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int CEJDCFFPPDB(AAKIIBMHCDL<int> LDCOIJIBFHA);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KCEOHGNKGFN
{
	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event GADOJBCBAIL.HEGHBAKADEG GOGHGPAONJA;

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BMGFKKCFMCO EJLCHOMCMHC(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KDLFINJPBNM CHAAMNIOGAM(Allocator GFNKGIEEHMD);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CDNLFFIPOFD HLHNAOAFCMH(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PACHNIFOOAM(IEnumerable<BMGFKKCFMCO> BDHBMKOOCDI);

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CDNLFFIPOFD BEGGJIBGBCA(BMGFKKCFMCO MJNLMOPPION, BMGFKKCFMCO GJKNNKIANJJ, bool DOHMNGLLDDG, BMGFKKCFMCO OLBBKGLINIK);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BMGFKKCFMCO AHDMDAEOOFN(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KBJIKDOEMIH(BMGFKKCFMCO MIKNGKGCFKJ, BMGFKKCFMCO MJNLMOPPION, bool GDOHNGLJJEP = false);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GFHMFAFDDMM(BMGFKKCFMCO MIKNGKGCFKJ, BMGFKKCFMCO MJNLMOPPION);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool NBDOKDFAPKL(BMGFKKCFMCO PAJELLKLLLO, BMGFKKCFMCO NFIAJJBHJDA);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[Obsolete("Use IHierarchyService.GetChildren() instead")]
	KDLFINJPBNM NIJELPLIHHE(BMGFKKCFMCO BDGEMDMFHPC);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool IMCCDDIMJOG(BMGFKKCFMCO MIKNGKGCFKJ, BMGFKKCFMCO BNMHCFKMKLN);

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KDLFINJPBNM HICIKPDOCCL(KDLFINJPBNM GBLMBDPBDGD, AMCDFNBLDDC NMFHGOAHANN, Allocator GFNKGIEEHMD);

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool LBONBJBOBHI(BMGFKKCFMCO MIKNGKGCFKJ, BMGFKKCFMCO AJDDCFHNNNO);

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	BMGFKKCFMCO EPKALAAAPMK(BMGFKKCFMCO OLBBKGLINIK, BMGFKKCFMCO NBEKEBPNMBJ);

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool LPBALKELJMA(BMGFKKCFMCO OLBBKGLINIK, BMGFKKCFMCO NBEKEBPNMBJ, [Out] BMGFKKCFMCO CJIFFKKOFIN);

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "17")]
	BMGFKKCFMCO LLPPNCHNANB(BMGFKKCFMCO[] NGMIILJPNNB);

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "18")]
	BMGFKKCFMCO BLKLCENJHBF(BMGFKKCFMCO MIKNGKGCFKJ, uint BNPEOEENHME);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public static class EJCBOCIFPEK
{
	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x816BBB0", Offset = "0x816A3B0", VA = "0x18816BBB0")]
	public static bool NAMPEJNDIBP(this KCEOHGNKGFN DPFNGOIDMCB, BMGFKKCFMCO MIKNGKGCFKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x816B8A0", Offset = "0x816A0A0", VA = "0x18816B8A0")]
	public static KDLFINJPBNM HICIKPDOCCL(this KCEOHGNKGFN OAGNIFCCHFK, BMGFKKCFMCO MIKNGKGCFKJ, AMCDFNBLDDC NMFHGOAHANN, Allocator GFNKGIEEHMD)
	{
		return default(KDLFINJPBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x816BB30", Offset = "0x816A330", VA = "0x18816BB30")]
	public static KDLFINJPBNM LJPHKNMKJCH(this KCEOHGNKGFN OAGNIFCCHFK, BMGFKKCFMCO MIKNGKGCFKJ, Allocator GFNKGIEEHMD)
	{
		return default(KDLFINJPBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x816BB70", Offset = "0x816A370", VA = "0x18816BB70")]
	public static KDLFINJPBNM MPBJIKKCMGI(this KCEOHGNKGFN OAGNIFCCHFK, BMGFKKCFMCO MIKNGKGCFKJ, Allocator GFNKGIEEHMD)
	{
		return default(KDLFINJPBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x816B710", Offset = "0x8169F10", VA = "0x18816B710")]
	public static KDLFINJPBNM BLBHBCJAMFJ(this KCEOHGNKGFN OAGNIFCCHFK, BMGFKKCFMCO MIKNGKGCFKJ, Allocator GFNKGIEEHMD)
	{
		return default(KDLFINJPBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x816BC20", Offset = "0x816A420", VA = "0x18816BC20")]
	public static KDLFINJPBNM NEONDEPKIMH(this KCEOHGNKGFN OAGNIFCCHFK, BMGFKKCFMCO MIKNGKGCFKJ, Allocator GFNKGIEEHMD)
	{
		return default(KDLFINJPBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x816B6D0", Offset = "0x8169ED0", VA = "0x18816B6D0")]
	public static KDLFINJPBNM AFCEEKCPKLN(this KCEOHGNKGFN OAGNIFCCHFK, BMGFKKCFMCO MIKNGKGCFKJ, Allocator GFNKGIEEHMD)
	{
		return default(KDLFINJPBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x816B860", Offset = "0x816A060", VA = "0x18816B860")]
	public static KDLFINJPBNM EPHMJLLPOGL(this KCEOHGNKGFN OAGNIFCCHFK, BMGFKKCFMCO MIKNGKGCFKJ, Allocator GFNKGIEEHMD)
	{
		return default(KDLFINJPBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x816B750", Offset = "0x8169F50", VA = "0x18816B750")]
	public static KDLFINJPBNM EPHMJLLPOGL(this KCEOHGNKGFN OAGNIFCCHFK, KDLFINJPBNM MIKNGKGCFKJ, Allocator GFNKGIEEHMD)
	{
		return default(KDLFINJPBNM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MCAKPFLKIGG
{
	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DJJLOJMEBGF HHHIPHMKDIO(BMGFKKCFMCO NHDNPGNDBND);

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NOLMJDBLBDI(BMGFKKCFMCO NHDNPGNDBND, DJJLOJMEBGF JHIOGKCLKGH);

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PLDDPAHDIDN(BMGFKKCFMCO NHDNPGNDBND);

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CABJEEIDCNF(BMGFKKCFMCO NHDNPGNDBND, bool MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IBGBEKHIABD<string> BPIHJAONKCH(BMGFKKCFMCO NHDNPGNDBND);

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BFBJFGBINCM(BMGFKKCFMCO NHDNPGNDBND, IBGBEKHIABD<string> LKKCBIFCBED);

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IBGBEKHIABD<string> MLJBJCLANHP(BMGFKKCFMCO NHDNPGNDBND);

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PJCFBODADEM(BMGFKKCFMCO NHDNPGNDBND, IBGBEKHIABD<string> LKKCBIFCBED);

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IBGBEKHIABD<string> LFMBNJPECAL(BMGFKKCFMCO NHDNPGNDBND);

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JKJPLIIBOBB(BMGFKKCFMCO NHDNPGNDBND, IBGBEKHIABD<string> LKKCBIFCBED);

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IBGBEKHIABD<string> LBMPMIPHLPC(BMGFKKCFMCO NHDNPGNDBND);

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NAIBFDCFPOL(BMGFKKCFMCO NHDNPGNDBND, IBGBEKHIABD<string> LKKCBIFCBED);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool HFNKAGMBOJK(BMGFKKCFMCO NHDNPGNDBND, BMGFKKCFMCO OINLJEGCCDI);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BANOMJHJEEG
{
	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x8167CF0", Offset = "0x81664F0", VA = "0x188167CF0", Slot = "0")]
	Task<JIJIPCHGCJC> KMOFOLIIOGI(MPOOOMKNOFE NDOKPGIBONO, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "1")]
	void JCKCNIGGBDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface ENMKEMIGGFF
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event GADOJBCBAIL.HEGHBAKADEG GOGHGPAONJA;

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BMGFKKCFMCO AHDMDAEOOFN(BMGFKKCFMCO LNFGEICLAJH);

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ReadOnlySpan<BMGFKKCFMCO> NFOCFPGGHKB();

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ReadOnlySpan<BMGFKKCFMCO> GFEFILPDFBE(BMGFKKCFMCO MJNLMOPPION);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GIHDCGMDJKH(BMGFKKCFMCO CDDHFCFDGNF, BMGFKKCFMCO PJJCONMFOMA, [Out] CDNLFFIPOFD MLCHPGBHIBL);

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MFIFJOLEBFG(BMGFKKCFMCO CDDHFCFDGNF, BMGFKKCFMCO IIGFEGKPHIC, [Out] CDNLFFIPOFD MLCHPGBHIBL);

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MFNPGKKHOFB(BMGFKKCFMCO CDDHFCFDGNF);

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GFHMFAFDDMM(BMGFKKCFMCO NBFNJOPOBFJ, BMGFKKCFMCO OOBPPDKPNFF);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CDNLFFIPOFD GJLFFBMFPHP(BMGFKKCFMCO MIKNGKGCFKJ);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PIPEPLAECIA
{
	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	bool NEPGMJMEGDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	bool CBCMGFAILFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	bool DMFBEDIMDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HFMJFOENKMC
{
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MAHLIPPMJNO
{
	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNEJLPLOOCN(BMGFKKCFMCO MIKNGKGCFKJ, KIDCJKDOKEJ JMHMMNHPIAF);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FBJHPKAPIHD(BMGFKKCFMCO MIKNGKGCFKJ, KIDCJKDOKEJ JMHMMNHPIAF);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GPFGOBLAJKJ
{
	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MOEFDPJIIEA([In] float3 CCEAAKFKCFC, [In] float3 LONBCENHPHO, float IOEOMGELKJC, [Out] BOHMBICADJO HFCNLJEOKJN, [Out] BMGFKKCFMCO KLNCEFCFPOE);

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int GGELIDGILCE([In] float3 CCEAAKFKCFC, float ANIHENNGJAL, List<BMGFKKCFMCO> NGMIILJPNNB);

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int AFJPKKKLCPC(Plane[] OJAJIPNEKHG, float3 CCEAAKFKCFC, float3 HEAFBMOOELE, quaternion FENAGHBAFHI, List<BMGFKKCFMCO> NGMIILJPNNB);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LGCKBBMCKPL
{
	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MOEFDPJIIEA([In] NativeArray<Entity> EFHAKLBGNAC, [In] float3 CCEAAKFKCFC, [In] float3 LONBCENHPHO, [In] NativeArray<BOHMBICADJO> PDCCGDHJDNM);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> GGELIDGILCE([In] NativeArray<Entity> EFHAKLBGNAC, [In] float3 CCEAAKFKCFC, float ANIHENNGJAL);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> AFJPKKKLCPC([In] NativeArray<Entity> EFHAKLBGNAC, [In] NativeArray<float4> LEOPLDIHIFC);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct BHHBHAEGMLJ : OACALCJJELJ, IEquatable<BHHBHAEGMLJ>
{
	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	public int PJLMPJGAPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x139F860", Offset = "0x139E060", VA = "0x18139F860", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	public int MOHDHMLGIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x2F364C0", Offset = "0x2F34CC0", VA = "0x182F364C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x71B2930", Offset = "0x71B1130", VA = "0x1871B2930", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x8167D50", Offset = "0x8166550", VA = "0x188167D50", Slot = "8")]
	public bool Equals(BHHBHAEGMLJ KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x8167DA0", Offset = "0x81665A0", VA = "0x188167DA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct BOHMBICADJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public float PFDIBDNPPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public float3 IILAMILCBNH;
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LJHKOMOMAJB
{
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IPIPLKEIAHG
{
	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	AENKGANHCMH EKDCHCNMKOF
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	MJOGKAPKDDN FCMLHMHKJND
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<KDLFINJPBNM, NativeArray<RRObjectPrefabData>> ICBODLCIIPD;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<KDLFINJPBNM> LFIJHLOOMDB;

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KDLFINJPBNM FJPLAFKICEB();

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HGLHFINFANA MMDKAEBIKCD(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "8")]
	RRObjectPrefabData FMNLCMIDMMI(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MLIOMIIONEP(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "10")]
	MGMNCEJOGLO IINPJGDBDLI(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CLPPOEPPMEC(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool JHFIKJCHCJM(BMGFKKCFMCO MIKNGKGCFKJ, [Out] Transform KCODNJGBFEK);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "13")]
	BMGFKKCFMCO CLJMENPAMPK(JKKCHPONOAD JLCFKNGJCID);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool MCKOGCELJGN(JKKCHPONOAD JLCFKNGJCID, [Out] BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "15")]
	JKKCHPONOAD HDFJIPDHMNK(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "16")]
	KDLFINJPBNM CLJMENPAMPK(NativeArray<JKKCHPONOAD> JLCFKNGJCID, Allocator GFNKGIEEHMD, bool BHMLCMBLKJH = true);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool KAAEDNELNME(NativeArray<FPGJDDPNHNM> AFMDJMBDJOH, NativeArray<JKKCHPONOAD> BJIHPMMFIHJ, NativeArray<Entity> LCEINNKJKKF, IBGBEKHIABD<JEOCDAOJLCO> KAJLBDMMNJM);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	MGMNCEJOGLO PIOGNLHDPGD();

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	MGMNCEJOGLO AEALLBOKEOD(RRObjectPrefabData HIGIPMBNHHD, [Optional] APNNOCBGIPF JDGDDEMCMKC);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	FBHGFLHMJFN GGAGNNCAOBM();

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	OHAPFJNKCIG GLGMMLGMPFP();

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "22")]
	GLIAJPACILE NPLMCIONLKJ(HBIFHMNPGDK AONBGCOLFKJ);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void DOHGJDCOIPO(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool NLOKFGKPJLE(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "25")]
	KDLFINJPBNM LCCMOHMAGEG(KDLFINJPBNM EPNOKEPONML, Allocator GFNKGIEEHMD);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool KPPNCAJEGHJ(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool NBDENJMEDMA(BMGFKKCFMCO MIKNGKGCFKJ, ComponentTypes BMBMNMHPIKM);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "28")]
	BMGFKKCFMCO PMJHPKJJMEG(Transform KCODNJGBFEK);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class GFKPNIAMBFA
{
	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x816FFB0", Offset = "0x816E7B0", VA = "0x18816FFB0")]
	internal static BMGFKKCFMCO HOPMIOIIMNE(this Entity JAOKKIIOCBD, IPIPLKEIAHG OKNIDGHPEIO)
	{
		return default(BMGFKKCFMCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x816FF30", Offset = "0x816E730", VA = "0x18816FF30")]
	public static MGMNCEJOGLO EFOAKCNJHLJ(this IPIPLKEIAHG OKNIDGHPEIO, LocalId MIKNGKGCFKJ)
	{
		return default(MGMNCEJOGLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x816FE80", Offset = "0x816E680", VA = "0x18816FE80")]
	public static BMGFKKCFMCO CLJMENPAMPK(this IPIPLKEIAHG OKNIDGHPEIO, LocalId MIKNGKGCFKJ)
	{
		return default(BMGFKKCFMCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x816FF40", Offset = "0x816E740", VA = "0x18816FF40")]
	public static JKKCHPONOAD HDFJIPDHMNK(this IPIPLKEIAHG OKNIDGHPEIO, LocalId MIKNGKGCFKJ)
	{
		return default(JKKCHPONOAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x8170060", Offset = "0x816E860", VA = "0x188170060")]
	public static FBHGFLHMJFN JNCHPELNJIJ(this IPIPLKEIAHG OKNIDGHPEIO, RigidTransform IPFGPMNNMGF)
	{
		return default(FBHGFLHMJFN);
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x81703A0", Offset = "0x816EBA0", VA = "0x1881703A0")]
	public static GLIAJPACILE OHLLBPLNIML(this IPIPLKEIAHG OKNIDGHPEIO, HBIFHMNPGDK LDIMBHJDJOD, RigidTransform IPFGPMNNMGF)
	{
		return default(GLIAJPACILE);
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x8170200", Offset = "0x816EA00", VA = "0x188170200")]
	public static OHAPFJNKCIG LMBKOFIKDBE(this IPIPLKEIAHG OKNIDGHPEIO, RigidTransform IPFGPMNNMGF)
	{
		return default(OHAPFJNKCIG);
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x8170550", Offset = "0x816ED50", VA = "0x188170550")]
	private static void PANDFBECLDP(MGMNCEJOGLO HHIFBIOFOHI, RigidTransform IPFGPMNNMGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal interface ANLENLNPCKL
{
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KCACKMFEHNE
{
	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	bool IGAMPEBJPJL
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	BMGFKKCFMCO COIKCINOAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	MGMNCEJOGLO LOPGKDJGBGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event OOBKHLDNGLC ENHNIKFIOCB;

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BMGFKKCFMCO EPKALAAAPMK(BMGFKKCFMCO OLBBKGLINIK, BMGFKKCFMCO NBEKEBPNMBJ);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LPBALKELJMA(BMGFKKCFMCO OLBBKGLINIK, BMGFKKCFMCO NBEKEBPNMBJ, [Out] BMGFKKCFMCO CJIFFKKOFIN);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HFDKGGPGECK();

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DIOHBJLDECI();

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool EEMGKBJFBDK(BMGFKKCFMCO OLBBKGLINIK);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MOJHDPEPPKP(BMGFKKCFMCO OLBBKGLINIK);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public delegate void OOBKHLDNGLC(MGMNCEJOGLO OLDEPNFDKIB, MGMNCEJOGLO DNDDNHEMEJF);
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class FGHLEMGBNOL
{
	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x816EC70", Offset = "0x816D470", VA = "0x18816EC70")]
	public static bool GHKEFNPLEMI(this KCACKMFEHNE HFBNHIJFJMA, MGMNCEJOGLO OLBBKGLINIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x816ECC0", Offset = "0x816D4C0", VA = "0x18816ECC0")]
	public static bool JHMMBIEJFEC(this KCACKMFEHNE HFBNHIJFJMA, BMGFKKCFMCO OLBBKGLINIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x816EDA0", Offset = "0x816D5A0", VA = "0x18816EDA0")]
	public static bool POMDFKADENM(this KCACKMFEHNE HFBNHIJFJMA, BMGFKKCFMCO OLBBKGLINIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DGHIMMNEPOC
{
	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHCDMNIIBFO(NativeList<RRObjectPrefabData> CIILCJDAEMN);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FJODELCFDEA
{
	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HIGLDJBKFNB(MGMNCEJOGLO HHIFBIOFOHI, HANCEIDOMMA ENEFJOLLDHH, List<MGMNCEJOGLO> EBAHALBPMDD);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int MNHOMGLBAAI(MGMNCEJOGLO HHIFBIOFOHI, HANCEIDOMMA ENEFJOLLDHH);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NAFJBEKAEAN(MGMNCEJOGLO HHIFBIOFOHI, List<MGMNCEJOGLO> EBAHALBPMDD);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int JJKEKPCJLBP(MGMNCEJOGLO PKBMMFHCONE, MGMNCEJOGLO OLBBKGLINIK, HANCEIDOMMA ENEFJOLLDHH);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MGMNCEJOGLO LGHBKIIKEHP(MGMNCEJOGLO PKBMMFHCONE, int PNJCJGEIDHG, HANCEIDOMMA ENEFJOLLDHH);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NEHOIKBOEOH(MGMNCEJOGLO PKBMMFHCONE, MGMNCEJOGLO OLBBKGLINIK, HANCEIDOMMA ENEFJOLLDHH);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DHMMOOKHJEK(MGMNCEJOGLO PKBMMFHCONE, MGMNCEJOGLO OLBBKGLINIK, HANCEIDOMMA ENEFJOLLDHH);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GIHOPKGAOOL(MGMNCEJOGLO PKBMMFHCONE, HANCEIDOMMA ENEFJOLLDHH);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GIHJEDMJHGE(MGMNCEJOGLO PKBMMFHCONE, MGMNCEJOGLO OLBBKGLINIK, HANCEIDOMMA ENEFJOLLDHH);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EBCCAJIGLAC(Entity PKBMMFHCONE, Entity OLBBKGLINIK, HANCEIDOMMA ENEFJOLLDHH);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CFJEADBCKHJ(Entity PKBMMFHCONE, HANCEIDOMMA ENEFJOLLDHH);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool MLJECEFOLPK(MGMNCEJOGLO OLBBKGLINIK, HANCEIDOMMA ENEFJOLLDHH);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OIIKPGHIHGO
{
	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	JJEFEBGGJPA ALEEOMFNEGO
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EGIPCMMOIAA KOJDNNAHGMN(JJEFEBGGJPA NBLBLIGFFMD);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JJEFEBGGJPA PILGLNLMHBB();

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JJEFEBGGJPA KMBIOBMKIBN();
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DDJBCBAANIP
{
	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NNGLLCKEOGK(BMGFKKCFMCO OLBBKGLINIK, [Out] BMGFKKCFMCO BFNPIHMIHLK);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GPBLIIKCMCB
{
	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CJJBFICGDGC(BMGFKKCFMCO BDGEMDMFHPC, bool MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DEGDLDAKELE(BMGFKKCFMCO BDGEMDMFHPC, bool MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BODGKHIHEJK(BMGFKKCFMCO BDGEMDMFHPC, int MGONBEDEDON);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EDDIOCAGPLM
{
	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<BMGFKKCFMCO> OCFEHJCMLLH(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BMGFKKCFMCO EFEJLNGEHMI(BMGFKKCFMCO MIKNGKGCFKJ, int PNJCJGEIDHG);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int BHIFJLNMACP(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ONDGGPNOKFN KCEDKNDDAKA(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GICGDOIMHEP(BMGFKKCFMCO MIKNGKGCFKJ, ONDGGPNOKFN JCPNJLMMOLN);

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BMGFKKCFMCO OIFBADFKCLF(BMGFKKCFMCO MIKNGKGCFKJ, [Optional] float3? KKEEFCOJJFM, [Optional] quaternion? FENAGHBAFHI, [Optional] float3? DKMKOJPHLDD);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BMGFKKCFMCO DHECDBNBGAD(BMGFKKCFMCO MIKNGKGCFKJ, int PNJCJGEIDHG, [Optional] float3? KKEEFCOJJFM, [Optional] quaternion? FENAGHBAFHI, [Optional] float3? DKMKOJPHLDD);

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HFMMOFOLGAN(BMGFKKCFMCO MIKNGKGCFKJ, int PNJCJGEIDHG);

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BEEACAIPJNJ(BMGFKKCFMCO MIKNGKGCFKJ);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NHLHCOCGILM
{
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BBHKFIBBNGI
{
	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	bool HEPDCJMJLGI
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MMNJKBNDAFA();

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JACLFGCDHGN();

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HIENHFJDLEB();

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BNCPEBOGPAI();

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GAOBMMOAAGN();

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BBHCLKGMNCJ();

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BDBCHDBMPCI();

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JJGFDIGNIPC();

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HCJIKHLGHLN();

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HKKLFBCIGHJ();

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DJIIEKBIGPI();

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BKKBFKPJAPE();
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface INFBPKBBKJP
{
	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NDEPCGPCBDG(BMGFKKCFMCO OLBBKGLINIK, [Out] int PKBMMFHCONE);

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KMLKPDJEIKB(BMGFKKCFMCO OLBBKGLINIK, int PKBMMFHCONE);

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BCIILJMMEBG(BMGFKKCFMCO OLBBKGLINIK, bool KNMHKJJNIKG);

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DPLIAMPGFMF(BMGFKKCFMCO OLBBKGLINIK, float MLPLEACOMMB, float LPLGFPMGJIC, float ADHNDJNFNBE);

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IHHOECBBFHK(BMGFKKCFMCO MIKNGKGCFKJ, [Out] float LPLGFPMGJIC, [Out] float ADHNDJNFNBE);

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LJBEKAKELCA(BMGFKKCFMCO OLBBKGLINIK, float3 KKEEFCOJJFM, quaternion FENAGHBAFHI);

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FFHBEOPOHED(BMGFKKCFMCO OLBBKGLINIK, [Out] float3 KKEEFCOJJFM, [Out] quaternion FENAGHBAFHI);

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void INGIMKKOAFM(BMGFKKCFMCO OLBBKGLINIK);
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HJKEFICBHPD
{
	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOMFPCFALNE(Entity JAOKKIIOCBD, [In] float3 MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float3 PHBHLBPPDLH(Entity JAOKKIIOCBD);

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KAHDEMFODHB(Entity JAOKKIIOCBD, [In] quaternion MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "3")]
	quaternion EBJIPADPAAB(Entity JAOKKIIOCBD);

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MNLHNDLALCJ(Entity JAOKKIIOCBD, [In] float3 KKEEFCOJJFM, [In] quaternion FENAGHBAFHI);

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LINDAPLJGKG(Entity JAOKKIIOCBD, [Out] RigidTransform KMAMDOOHJOO);

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NGOJDGEIAOH(Entity JAOKKIIOCBD, [In] float3 KKEEFCOJJFM, [In] quaternion FENAGHBAFHI);

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JDHPOMKAKJP(Entity JAOKKIIOCBD, [Out] float3 KKEEFCOJJFM, [Out] quaternion FENAGHBAFHI);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JDHPOMKAKJP(Entity JAOKKIIOCBD, [Out] RigidTransform KMAMDOOHJOO);

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EMIJAPGGLFE(Entity JAOKKIIOCBD, float MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float NDKPPAAFJJO(Entity JAOKKIIOCBD);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OOBLBMAJLBN(Entity JAOKKIIOCBD, [In] float3 MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 HFPOGNLNGPI(Entity JAOKKIIOCBD);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HAJCCMKDEMI(Entity JAOKKIIOCBD, [In] quaternion MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "14")]
	quaternion EFGPPLGBGFP(Entity JAOKKIIOCBD);

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ACBPLMIBGFP(Entity JAOKKIIOCBD, float MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float NKDLFGPKEMJ(Entity JAOKKIIOCBD);

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ADJKPEOPADK(Entity JAOKKIIOCBD, [Out] float4x4 DJHJNAPODOP);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void AKGEMKPHJMG(Entity JAOKKIIOCBD, [In] float4x4 DJHJNAPODOP);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void HEPAKMJBBJA(Entity JAOKKIIOCBD);

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void ECIJNMPPOLG(Entity JAOKKIIOCBD, Entity OFDEGCGBALE, Entity OOBPPDKPNFF);
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public static class KMLBNHHALLD
{
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface INHIMFOOIBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACPGOKHAFNB(bool EIHIBPCMLAH);
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BFMGKHADBNH
{
	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KFNFPLODGNO(BMGFKKCFMCO NHDNPGNDBND, IBGBEKHIABD<string> LKKCBIFCBED);

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPDAFAIBONO(BMGFKKCFMCO NHDNPGNDBND, IBGBEKHIABD<string> LKKCBIFCBED);

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OKBMPDNNIAA(BMGFKKCFMCO NHDNPGNDBND, IBGBEKHIABD<string> LKKCBIFCBED);

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DENEPEOJIBE(BMGFKKCFMCO NHDNPGNDBND, IBGBEKHIABD<string> LKKCBIFCBED);

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LJDBIHEAPBK(BMGFKKCFMCO NHDNPGNDBND, IBGBEKHIABD<string> LKKCBIFCBED);

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DNOJHIIGAGK(BMGFKKCFMCO NHDNPGNDBND, IBGBEKHIABD<string> LKKCBIFCBED);

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int CNLHJJMFBAF(BMGFKKCFMCO NHDNPGNDBND);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int DNMDKANBKMB(BMGFKKCFMCO NHDNPGNDBND);

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int OIGPEIEOFHB(BMGFKKCFMCO NHDNPGNDBND);

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FJODPEEPKJK<string> JEEKIDAHCGG(BMGFKKCFMCO NHDNPGNDBND);

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool DONHDNKFDAJ(BMGFKKCFMCO NHDNPGNDBND);

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FJODPEEPKJK<string> LEEDEIHMFBC(BMGFKKCFMCO NHDNPGNDBND);

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool PFKBNKPKAKI(BMGFKKCFMCO NHDNPGNDBND, string JIDPAGEBNDJ);

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ILDGPIJHFNP(string JIDPAGEBNDJ, PGCLLCDEJPL DGKBJOFCMHN);

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	BMGFKKCFMCO JOGHMJPHDEM(string JIDPAGEBNDJ);

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OLKIPEAFMGK(string JIDPAGEBNDJ, PGCLLCDEJPL DGKBJOFCMHN);

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JFGOPILEAFN(BMGFKKCFMCO LFOEGHMKEDI, string JIDPAGEBNDJ, PGCLLCDEJPL DGKBJOFCMHN);

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	FJODPEEPKJK<string> FJKLOEKCMCF();
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class GCKMILKILGG
{
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IJCNECCOLHG
{
	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World BEELNEOBKKD(string AHBAJNALKMN = "Main");

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World AAEBMPKMJCP(string AHBAJNALKMN = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World DJEFPOFLBBK(string AHBAJNALKMN = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World IGGAOGKBOAL(string AHBAJNALKMN = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MGOAOGOOHDM
{
	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	World KDJJCBMMIPB
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	World LOJMPBGCEEE
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	EntityManager BAGCDNKPGAO
	{
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	bool HFNFNBOGCLN
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase PODKJJBKHLE(Type CEPGAJKBPDM);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public static class AFCNHBHPPGF
{
	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x8166520", Offset = "0x8164D20", VA = "0x188166520")]
	public static ComponentSystemBase IAOKHPLIPGO(this World NAHDLONMOKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x41E7480", Offset = "0x41E5C80", VA = "0x1841E7480")]
	public static T PODKJJBKHLE<T>(this MGOAOGOOHDM IJPCIMCIPNH) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LFAHFBDECMK
{
	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJEMDILFEPF(NativeListAsync<Entity> ECBJDPAMJPI);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJMLKOOHDIH(DMAODNGMMLE OHDMGIPDONN);

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IIOCCGFBDCO(NativeListAsync<Entity> CJBJENJKHGI, bool BFCEAMOBHKH);

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EFGFHPKIMNM();

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CAHKKHJGEGM(Entity MJAMEBJFAIN);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface BJGJCEIBHCC
{
	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KANKOMOBMLJ(Collider MJEGAAMKNMM, [Out] IPGDFEPIDBP AABPKDOCNBN);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LHEDJDCMMEK
{
	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider PJENIJEEJJL(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject FLKFBFDJDGI(BMGFKKCFMCO PIIGFADGCGA, GameObject OJKJJCNLKLJ, Vector3 BAIEFBENFCP, Quaternion HBPGIGGIBDO);

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OMKDMDEAMLA(GameObject MJEGAAMKNMM);

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider AELCBMJGGJP<TCollider>(GameObject IPGAMBOPIJC) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KCHEINDIKNP(Collider MJEGAAMKNMM);

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject FCKLBFFDBAL<TCollider>(string HPANEBBHGAC) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JHKCNIMOAKE NKDMIALGCDD(BMGFKKCFMCO DFNAABIMNHG, BMGFKKCFMCO KBMEBNGLOFD, HBIFHMNPGDK DMGOMGEHLIF, float3 JLBCBDJPIFG, quaternion DPIBDGAMJAF, float3 NAFAGKAHDMC);

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool GFNCPBEMIJO(BMGFKKCFMCO MIKNGKGCFKJ, [Out] JHKCNIMOAKE MJEGAAMKNMM);

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EAKCEMCDKKF(BMGFKKCFMCO MIKNGKGCFKJ, [Out] BMGFKKCFMCO MJAMEBJFAIN);
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public enum KKNJPKLAMEJ
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ANNCKEJGCIP
{
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public struct DIBGJOBPEBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public int DMGOMGEHLIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public GameObject OJKJJCNLKLJ;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJHIOLNOMHC(BMGFKKCFMCO MIKNGKGCFKJ, BAMKOOJPPFO HFPGGMOLDIL, bool GOGDIPAMINL, KOIOMAEALHN BLANNLELLEG);

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GCIOGHLCDPG(BMGFKKCFMCO MIKNGKGCFKJ, BAMKOOJPPFO HFPGGMOLDIL, bool GOGDIPAMINL, bool ACPICAGBMEK, bool MLKLDOKOJPD);

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MNLCIJBGECJ HPEFCIIILKK(BMGFKKCFMCO MJAMEBJFAIN, List<BMGFKKCFMCO> KNJHOKGHLPG);

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JHKCNIMOAKE FPNFPFFDPPF(GameObject KDLLKNOPIOB, GameObject CJBGPJBMLPF);

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LEBGIECLEPP(GameObject KDLLKNOPIOB, List<GameObject> GGOBJIDNBOH);

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KJMDEFMKJLM(GameObject CJBGPJBMLPF);

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T AELCBMJGGJP<T>(GameObject IPGAMBOPIJC) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KCHEINDIKNP(Collider MJEGAAMKNMM);

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject GCHBJEDBEHL<T>(string HPANEBBHGAC) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HFNJNADOMMC(Collider MJEGAAMKNMM, [Out] BMGFKKCFMCO PKBMMFHCONE);

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool IEDMNPLCLBL(BMGFKKCFMCO MIKNGKGCFKJ, [Out] IPGDFEPIDBP AABPKDOCNBN);

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<KKNJPKLAMEJ> LENINGLAJII(Allocator GFNKGIEEHMD = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] DBFPONAOHPF();
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AFGMLEBJNIL
{
	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFNMONPOGNP(BMGFKKCFMCO MIKNGKGCFKJ, BMGFKKCFMCO MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HLIKHCJLJOA(BMGFKKCFMCO MIKNGKGCFKJ, BMGFKKCFMCO MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int HGCFBENMCEA(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BMGFKKCFMCO MODBIOGMKLN(BMGFKKCFMCO MIKNGKGCFKJ, int PNJCJGEIDHG);

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KDLFINJPBNM KCOKMMCABLD(BMGFKKCFMCO MIKNGKGCFKJ, Allocator GFNKGIEEHMD = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FOLAADIJNOH(BMGFKKCFMCO MIKNGKGCFKJ, object KAJENDFCCBJ, BMGFKKCFMCO MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CBAGJCMIAMJ(BMGFKKCFMCO MIKNGKGCFKJ, object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BBBLGKFHDPI(BMGFKKCFMCO MIKNGKGCFKJ, [Out] BMGFKKCFMCO MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MIFBFNCCPGF(BMGFKKCFMCO MIKNGKGCFKJ, float3 MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool CCFGDPLLAOH(BMGFKKCFMCO MIKNGKGCFKJ, [Out] float3 MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PCDGBHPLJAI(BMGFKKCFMCO MIKNGKGCFKJ, float3 MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FOMLHJDNJOF(BMGFKKCFMCO MIKNGKGCFKJ, [Out] float3 MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JDBKKIPCEJM(BMGFKKCFMCO MIKNGKGCFKJ, (Quaternion rot, Vector3 moments) MCEDHANOLMG);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool HMOPMEMAALA(BMGFKKCFMCO MIKNGKGCFKJ, [Out] quaternion KHAMCCGPNHN, [Out] float3 IDOEDHOEDAH);

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PFOADMOMGCF(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 LNDFGFBOFCC(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 LNDJOALJGPM(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HJDBEDLFABC(BMGFKKCFMCO MIKNGKGCFKJ, float3 MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EJLBJIEBLAP(BMGFKKCFMCO MIKNGKGCFKJ, float3 MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float MPCKLBIOANA(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float KADNHGFHDEH(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FABFIHBIJCN(BMGFKKCFMCO MIKNGKGCFKJ, float MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void ONBDEJFPCCK(BMGFKKCFMCO MIKNGKGCFKJ, float MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode IMPJOOHOLBC(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GLEKHPDKCJJ(BMGFKKCFMCO MIKNGKGCFKJ, CollisionDetectionMode MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "25")]
	LHKNHJGBEJF KGDMBJBBOGM(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void KFOOMHJNMKM(BMGFKKCFMCO MIKNGKGCFKJ, LHKNHJGBEJF MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool PHEKKCOLLKA(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void LANNGIKHKGF(BMGFKKCFMCO MIKNGKGCFKJ, bool MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "29")]
	BMGFKKCFMCO EJLCHOMCMHC(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void GMCPIENKLHE(BMGFKKCFMCO MIKNGKGCFKJ, BMGFKKCFMCO MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "31")]
	BMGFKKCFMCO AHDMDAEOOFN(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void KBJIKDOEMIH(BMGFKKCFMCO MIKNGKGCFKJ, BMGFKKCFMCO MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "33")]
	CAKMKKHPGOG MKAHKCAGEMM(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void AMCLBJMEGJF(BMGFKKCFMCO MIKNGKGCFKJ, CAKMKKHPGOG CKOJAFBCIHC);

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool DIEJALGOHBL(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void BNMLGMJCBFM(BMGFKKCFMCO MIKNGKGCFKJ, bool MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool CPMIJCCLMFL(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void JHBKGAPFMEH(BMGFKKCFMCO MIKNGKGCFKJ, bool MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints LPBMIBDBDCC(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void HJJGFGCMKGK(BMGFKKCFMCO MIKNGKGCFKJ, RigidbodyConstraints MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float OOKIDFMBNGL(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void HKFEAFCMNGM(BMGFKKCFMCO MIKNGKGCFKJ, float MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float ABBOPMKEJEK(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void EFHOCLOMMDF(BMGFKKCFMCO MIKNGKGCFKJ, float MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool HIONAEBOMJJ(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void HGBODKIIPLH(BMGFKKCFMCO MIKNGKGCFKJ, bool MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool HJBDNKKMJIE(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void OKJFFFNPJLB(BMGFKKCFMCO MIKNGKGCFKJ, bool MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void KGAEBAKACEG(BMGFKKCFMCO MIKNGKGCFKJ, int MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "50")]
	KBEKBNCLGHN DCHBIOIDNMM(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void KABAGOGMOMG(BMGFKKCFMCO MIKNGKGCFKJ, KBEKBNCLGHN MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(Slot = "52")]
	EEDPJNEGGND ACHPOONBHKO(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void PJOPGFBDOBL(BMGFKKCFMCO MIKNGKGCFKJ, EEDPJNEGGND MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float DJNNCHEKOBP(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void OPKCEIPMMNH(BMGFKKCFMCO MIKNGKGCFKJ, float MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void CJFHNMMFKIL(BMGFKKCFMCO MIKNGKGCFKJ, object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void NFDIFFECPME(BMGFKKCFMCO MIKNGKGCFKJ, object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool GNNJJPDMHBA(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void PCAGKGGCKIC(BMGFKKCFMCO MIKNGKGCFKJ, object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void JDMDCMCEPDO(BMGFKKCFMCO MIKNGKGCFKJ, object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool CONGLCEJHHN(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool EPBNJMNADJK(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody CCIADKALJAF(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void CLAIOMPFHNE(BMGFKKCFMCO MIKNGKGCFKJ, Rigidbody HNPNGMHGBOO);

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void KFINFFPHJDI(BMGFKKCFMCO MIKNGKGCFKJ, object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void PGCMGOGPNMJ(BMGFKKCFMCO MIKNGKGCFKJ, object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool JELGGPPPGCE(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void GHEIEJLKNBL(BMGFKKCFMCO MIKNGKGCFKJ, float3 KFKKLCCOCPA);

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void GLFGMGLJPGM(BMGFKKCFMCO MIKNGKGCFKJ, float3 CGCEKAJGJHA);

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool CNIHJKLENAD(BMGFKKCFMCO MIKNGKGCFKJ, [Out] float3 KFKKLCCOCPA);

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool OHAKOOPKBGF(BMGFKKCFMCO MIKNGKGCFKJ, [Out] float3 CGCEKAJGJHA);

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool JAGALNHALBO(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void KHKFELPNNOJ(BMGFKKCFMCO MIKNGKGCFKJ, object KAJENDFCCBJ, bool MANNIEELCNM);

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void BHELCDMKJOE(BMGFKKCFMCO MIKNGKGCFKJ, bool MPNDPCOEKKD);

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void IPKKOHNFDFG(BMGFKKCFMCO MIKNGKGCFKJ);

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool ALPNBMGEOAL(BMGFKKCFMCO MIKNGKGCFKJ);
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LCBMEAGKGEP
{
	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DLPCCPPHHIM(Entity DIOKDEBEJKB);

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NOKNOIDIKMM(Entity DIOKDEBEJKB);

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFKIOICHBCM(Entity DIOKDEBEJKB);
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FPJOPMDJGMA
{
	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJGEEKCCELO(BMGFKKCFMCO OLBBKGLINIK, bool FIKNMJMLFBM);
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public delegate void PDBCELPDEMO(KJBHAIIFIJA PKDOABOLAII);
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public readonly ref struct KJBHAIIFIJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly KDLFINJPBNM OGAMNAKIMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly NativeArray<byte> HAIBAGMKENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly NativeArray<byte> IIPGAFKJNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly KIDCJKDOKEJ JMHMMNHPIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly int IPBDHOKGPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Type GMKHFLICHFE;

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	public KDLFINJPBNM BMFFGEAIPEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x524B930", Offset = "0x524A130", VA = "0x18524B930")]
		get
		{
			return default(KDLFINJPBNM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	public int FFBDFGAGHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x8173550", Offset = "0x8171D50", VA = "0x188173550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	public KIDCJKDOKEJ CKNFHIOIFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0xA46F30", Offset = "0xA45730", VA = "0x180A46F30")]
		get
		{
			return default(KIDCJKDOKEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x81735A0", Offset = "0x8171DA0", VA = "0x1881735A0")]
	public KJBHAIIFIJA(KDLFINJPBNM OGAMNAKIMKJ, NativeArray<byte> HAIBAGMKENG, NativeArray<byte> IIPGAFKJNLB, KIDCJKDOKEJ JMHMMNHPIAF, int IPBDHOKGPBP, Type GMKHFLICHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x3A926A0", Offset = "0x3A90EA0", VA = "0x183A926A0")]
	public NativeArray<T> MLDKKMOBLNM<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x3A92570", Offset = "0x3A90D70", VA = "0x183A92570")]
	public NativeArray<T> AIAABOFLMHA<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x3A925B0", Offset = "0x3A90DB0", VA = "0x183A925B0")]
	public (KDLFINJPBNM, NativeArray<T>, NativeArray<T>) CEJDCFFPPDB<T>() where T : struct
	{
		return default((KDLFINJPBNM, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x8173570", Offset = "0x8171D70", VA = "0x188173570")]
	public OCCHCGAEEDE KANDDODJHOM()
	{
		return default(OCCHCGAEEDE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public interface EOGGBAJBPBF
{
	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	string DHGPEBLKLFO
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	EOGGBAJBPBF NICOPEOMHMP
	{
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	IEnumerable<EOGGBAJBPBF> NFPCMFKGHNM
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface IJCPGIMHBGK
{
	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	EOGGBAJBPBF KFLFCMFOCLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	NativeArray<KIDCJKDOKEJ> GOBPMGJDKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HDJGINDKIMB(KIDCJKDOKEJ JMHMMNHPIAF, [Out] EOGGBAJBPBF LCPLPGNINPG);

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KELFLPPCOLM(KIDCJKDOKEJ JMHMMNHPIAF, PDBCELPDEMO DBBPOHLGKBH);

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HIDPNIODDKH(KIDCJKDOKEJ JMHMMNHPIAF, PDBCELPDEMO DBBPOHLGKBH);
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ANCGJLEODJF
{
	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KELFLPPCOLM(KIDCJKDOKEJ JMHMMNHPIAF, PDBCELPDEMO DBBPOHLGKBH);

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIDPNIODDKH(KIDCJKDOKEJ JMHMMNHPIAF, PDBCELPDEMO DBBPOHLGKBH);
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public static class AFJBEJOACAD
{
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FDLNIFJFJGB
{
	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	bool IHNLIKPADPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	ICHKIOCCGKO MGDJHLJNOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ALEGPHMILFN(EGIPCMMOIAA JLCFKNGJCID, bool KABGJMKDPLL);

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EMCDAKJLJJL(JKKCHPONOAD JLCFKNGJCID, KIDCJKDOKEJ JMHMMNHPIAF);

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HDLLOAHDDON(NativeArray<JKKCHPONOAD> OILPEJPOLDC);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public static class MIOMCBFKOFL
{
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public readonly ref struct OCCHCGAEEDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly KJBHAIIFIJA IMINNNCPCJF;

	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	public KDLFINJPBNM BMFFGEAIPEF
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x524B930", Offset = "0x524A130", VA = "0x18524B930")]
		get
		{
			return default(KDLFINJPBNM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x81780E0", Offset = "0x81768E0", VA = "0x1881780E0")]
	public OCCHCGAEEDE(KJBHAIIFIJA IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x8177FB0", Offset = "0x81767B0", VA = "0x188177FB0")]
	public KDLFINJPBNM MLDKKMOBLNM()
	{
		return default(KDLFINJPBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x8177B90", Offset = "0x8176390", VA = "0x188177B90")]
	public KDLFINJPBNM AIAABOFLMHA()
	{
		return default(KDLFINJPBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x8177CC0", Offset = "0x81764C0", VA = "0x188177CC0")]
	public (KDLFINJPBNM, KDLFINJPBNM, KDLFINJPBNM) CEJDCFFPPDB()
	{
		return default((KDLFINJPBNM, KDLFINJPBNM, KDLFINJPBNM));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public static class BBACNMAEJGP
{
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public readonly struct ICHKIOCCGKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly NativeBitArray OEJCOIEJICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly NativeParallelHashMap<JKKCHPONOAD, int> AKLGLKPGELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly NativeParallelHashSet<EGIPCMMOIAA> NHAJIOFELFM;

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	public bool PJIMKKELKDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x8172100", Offset = "0x8170900", VA = "0x188172100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	public bool IHNLIKPADPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x81720D0", Offset = "0x81708D0", VA = "0x1881720D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC5A0", Offset = "0x5EBADA0", VA = "0x185EBC5A0")]
	public ICHKIOCCGKO(NativeBitArray OEJCOIEJICE, NativeParallelHashMap<JKKCHPONOAD, int> AKLGLKPGELN, NativeParallelHashSet<EGIPCMMOIAA> NHAJIOFELFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x8171EE0", Offset = "0x81706E0", VA = "0x188171EE0")]
	public bool EMCDAKJLJJL(JKKCHPONOAD JLCFKNGJCID, KIDCJKDOKEJ JMHMMNHPIAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PCNNFFFDAKC
{
	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	ELCBLENENFJ BCEIHLGIBKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface ENIMDODCOJL
{
	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DHJNBDEDHFJ(BMGFKKCFMCO MIKNGKGCFKJ, AFPIKACBKKH MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EHLBOOAPMJF NEGEPEGGCHM();
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EINOBEFJFHP
{
	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DALEMKKFMFF(World NAHDLONMOKF);

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKNABFDEOPG(World NAHDLONMOKF);

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase HBKIEDPNCEN(World NAHDLONMOKF);

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BPFKBPHNNNF(World NAHDLONMOKF);

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JHMGOIEDHHK(World NAHDLONMOKF);

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void POKCPMCHEDP(World NAHDLONMOKF);

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PBOFMINNFHC(World NAHDLONMOKF);

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> EBOECHMNLDJ();
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OCKGLNDAPAM
{
	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EOLBEBMBIHL(BMGFKKCFMCO BDGEMDMFHPC, bool MGONBEDEDON);
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public readonly struct LJJPCFMBJAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly IEnumerable<JLPKCIPJEBB> IGDPJPHPMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly IReadOnlyList<GameObject> NMJFIMAAOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly IReadOnlyList<int> MBHCBNPEBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly IReadOnlyList<(JKKCHPONOAD, JKKCHPONOAD)> LLEKIDIBGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int HPMBHFIJKPK;
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public struct CHFGNFKPGGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public InventionIdData EBHOIBHGECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public InventionInstanceIdData EOPIGLIECBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool HCBCJEFIIED;

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x816A080", Offset = "0x8168880", VA = "0x18816A080")]
	public CHFGNFKPGGL(long EBHOIBHGECB, Guid EOPIGLIECBI, bool HCBCJEFIIED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[ServiceLifetime(Lifetime.Application)]
public interface JPEEGIJCLKN
{
	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JIJIPCHGCJC AFFOMBLNLHM(MPOOOMKNOFE FKDJCHFMMAO, int DBLOAICJLAD = 0, bool IIHAEGCHLCJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GNIODDEODAP BAMMHCFCFOB(MPOOOMKNOFE FKDJCHFMMAO, BMGFKKCFMCO MJNLMOPPION, [In] UniformTRS DONOEJJEGCN, ABJKGIEDKOO EPEPDBAEFPJ, [Optional] CHFGNFKPGGL LMGKBEEEIJO, bool OJDFMMFAHMF = true, bool OILNGFBMPJH = false, bool IIHAEGCHLCJ = false, bool PIOOKGFMOIN = false);

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DKOPFDILECI KIOOLDJGHBO();

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DKOPFDILECI DBJFFOHMDGL(KDLFINJPBNM NGMIILJPNNB, [In] UniformTRS IOOLFNFGBBG, [Optional] ABJKGIEDKOO HGFCPLDEGGM);

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NDNJMMPOIDA(BMGFKKCFMCO FJEOMNEHAGN);

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HHLEJCBPAHK(BMGFKKCFMCO FJEOMNEHAGN, [Out] Exception COLJEFDGCGI);

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<JKKCHPONOAD> AIKFDLFFKGC(BMGFKKCFMCO FJEOMNEHAGN, Allocator GFNKGIEEHMD);

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeArray<JKKCHPONOAD> NNEMJGHPDOK(BMGFKKCFMCO FJEOMNEHAGN, Allocator GFNKGIEEHMD);

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KDLFINJPBNM LGFEPGLONLD(BMGFKKCFMCO FJEOMNEHAGN, Allocator GFNKGIEEHMD);

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KDLFINJPBNM FGJKFFEKKCL(BMGFKKCFMCO FJEOMNEHAGN, Allocator GFNKGIEEHMD);

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KDLFINJPBNM FFPGMGHHKEB(BMGFKKCFMCO FJEOMNEHAGN, Allocator GFNKGIEEHMD);

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> IMANLMFGDFE(BMGFKKCFMCO FJEOMNEHAGN, Allocator GFNKGIEEHMD);

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool PENPDMIJFNC(BMGFKKCFMCO FJEOMNEHAGN);

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int GIFDGFLNMFJ(BMGFKKCFMCO FJEOMNEHAGN, int FMGALNGIOGC);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[ServiceLifetime(Lifetime.Application)]
public interface KFPGIMDDCCE
{
	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0xE690A0", Offset = "0xE678A0", VA = "0x180E690A0", Slot = "0")]
	bool MGMJPBJPHJO(object NPLHFNMEMBD, LHOHOFLFMIN ODJFDEMIFBA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class DGMNLAMJIAP
{
	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x816AF60", Offset = "0x8169760", VA = "0x18816AF60")]
	public static bool MGMJPBJPHJO(this KFPGIMDDCCE OAGNIFCCHFK, object NPLHFNMEMBD, [Out] LHOHOFLFMIN ODJFDEMIFBA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public enum EAIGJANFEKD : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	MaxPlayers = byte.MaxValue,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	IsVisible = 254,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	IsOpen = 253,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	PlayerCount = 252,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Removed = 251,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	PropsListedInLobby = 250,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	CleanupCacheOnLeave = 249,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	MasterClientId = 248,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	ExpectedUsers = 247,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	PlayerTtl = 246,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	EmptyRoomTtl = 245,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	HasDedicatedMaster = 87
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public interface LHOHOFLFMIN
{
	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	PCIFKHJOCMO PBNBGAHIAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	GBNNBLFIGLH DGFEGJFLMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	bool EPPBJKFNNGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	bool NBEKAHOOKNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object IJLKEIOJLMI();

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0xF9D310", Offset = "0xF9BB10", VA = "0x180F9D310", Slot = "5")]
	(GBNNBLFIGLH, Dictionary<object, object>) MOJDAOCMAGC()
	{
		return default((GBNNBLFIGLH, Dictionary<object, object>));
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "6")]
	(JKKCHPONOAD, GBNNBLFIGLH) MPDJFNGABEH()
	{
		return default((JKKCHPONOAD, GBNNBLFIGLH));
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "7")]
	AHCMFJODPGC<(JKKCHPONOAD, GBNNBLFIGLH)> GADIHMMPMKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0xF9D310", Offset = "0xF9BB10", VA = "0x180F9D310", Slot = "8")]
	(MKLLDEMFALJ, byte[]) PKKMLMLMLCF()
	{
		return default((MKLLDEMFALJ, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0xF9D310", Offset = "0xF9BB10", VA = "0x180F9D310", Slot = "9")]
	(MNJLPECGPEL, byte[]) FOBINOMBNMP()
	{
		return default((MNJLPECGPEL, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0xF9D310", Offset = "0xF9BB10", VA = "0x180F9D310", Slot = "10")]
	T LMBCPEKNFIC<T>()
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public static class GFCGPJEBGMH
{
	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x816FD40", Offset = "0x816E540", VA = "0x18816FD40")]
	public static bool JDJNEOEKENE(this LHOHOFLFMIN CJJAIJHHKDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public interface ENHKEAJOOCM : AHCMFJODPGC<DILHAMBPDCK>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[DefaultMember("Item")]
public interface AHCMFJODPGC<T>
{
	[Cpp2IlInjected.Token(Token = "0x170001E7")]
	T NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E8")]
	int FFBDFGAGHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public enum PCIFKHJOCMO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	BulkInstantiate = 1,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	BulkDestroy = 2,
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
	RR_NetworkSynchronization = 28,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	RR_NetworkInstantiate = 29,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	RR_BulkInstantiate = 31,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	RR_Destroy = 32,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	RR_BulkDestroy = 33,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	RR_TransferOwnership = 34,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	RR_OwnershipUpdate = 35,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	RR_RPC = 36,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	RR_JoinRequest = 100,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	RR_JoinResponse = 101,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	RR_RoomUpdate = 102,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	RR_PlayerUpdate = 103,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	RR_RemotePlayerJoined = 104,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	RR_RemotePlayerLeft = 105,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	RR_Leave = 106,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	RPC = 200,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	SendSerialize = 201,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Instantiation = 202,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	CloseConnection = 203,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	Destroy = 204,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	RemoveCachedRPCs = 205,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	SendSerializeReliable = 206,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	DestroyPlayer = 207,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	OwnershipRequest = 209,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	OwnershipTransfer = 210,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	VacantViewIds = 211,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	OwnershipUpdate = 212,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	AuthEvent = 223,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	LobbyStats = 224,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	AppStats = 226,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	Match = 227,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	QueueState = 228,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	GameListUpdate = 229,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	GameList = 230,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	CacheSliceChanged = 250,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	ErrorInfo = 251,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	PropertiesChanged = 253,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Leave = 254,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	Join = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public enum MKLLDEMFALJ : uint
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	None = 0u,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	NetworkTransformInitializationData = 1314146628u,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	RestoreCreationData = 1380140064u,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	OldestCachedPacketId = 1329811529u,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	SnapshotPublished = 1397773634u,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	SnapshotPayload = 1397771332u,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	SnapshotClear = 1129337683u
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class KNGBONEFLPA
{
	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x8173970", Offset = "0x8172170", VA = "0x188173970")]
	public static JKKCHPONOAD HKAKKJGAFNO(this MNJLDBCLBGP IMINNNCPCJF)
	{
		return default(JKKCHPONOAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x8173920", Offset = "0x8172120", VA = "0x188173920")]
	public static JKKCHPONOAD BHIAGJIGBEL([In] this MNJLDBCLBGP IMINNNCPCJF)
	{
		return default(JKKCHPONOAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x80F3910", Offset = "0x80F2110", VA = "0x1880F3910")]
	public static JKKCHPONOAD HAHHCEJIMAI(this MNJLDBCLBGP IMINNNCPCJF)
	{
		return default(JKKCHPONOAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x80F3910", Offset = "0x80F2110", VA = "0x1880F3910")]
	public static ViewId AMDBMEAIAJO(this MNJLDBCLBGP IMINNNCPCJF)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x81739B0", Offset = "0x81721B0", VA = "0x1881739B0")]
	public static FixedString64Bytes NAMNOIBBFLH(this EGIPCMMOIAA EBHOIBHGECB)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x8173690", Offset = "0x8171E90", VA = "0x188173690")]
	public static FixedString64Bytes BDPOJJNMAGB(this JKKCHPONOAD EBHOIBHGECB)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x8173B80", Offset = "0x8172380", VA = "0x188173B80")]
	public static FixedString32Bytes NAMNOIBBFLH(this Entity JAOKKIIOCBD)
	{
		return default(FixedString32Bytes);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BFNLMBNLCGJ : ABCPNDDIMEF
{
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public enum BBACCPMDMHB
{
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	End,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CABKADLKCMC
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<object> MMLDHNFPHIJ;

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "2")]
	void MNKIECIALDI(object NPLHFNMEMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "3")]
	void HPPNPKJFIBD(MNJLPECGPEL BJNLPCOGDLM, ReadOnlySpan<byte> OILJBDLKBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	void PAMMPPFAMND(MKLLDEMFALJ CEPGAJKBPDM, ReadOnlySpan<byte> OILJBDLKBKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AGIIPAJCCNB
{
	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MNJLPECGPEL EFFINOINBHN(ReadOnlySpan<byte> OILJBDLKBKC);
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DLBGDMFAPFF
{
	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEHGFJLKEEN(MNJLPECGPEL MNMCNOJCKAF, ReadOnlySpan<byte> OILJBDLKBKC);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJBDLOOIJIL(ReadOnlySpan<MNJLPECGPEL> IMBBBHENFDA);
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public struct FLBEGPKFBPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public MNJLPECGPEL BJNLPCOGDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public ReadOnlyMemory<byte> OILJBDLKBKC;
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public struct MNJLPECGPEL
{
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static MNJLPECGPEL IJHGFHFPEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public EGIPCMMOIAA EPFGDLJCLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public int ECBKFNGOBFP;

	[Cpp2IlInjected.Token(Token = "0x170001E9")]
	public static EGIPCMMOIAA GKNBNAPOCIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x8176FD0", Offset = "0x81757D0", VA = "0x188176FD0")]
		get
		{
			return default(EGIPCMMOIAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x524B0A0", Offset = "0x52498A0", VA = "0x18524B0A0")]
	public MNJLPECGPEL(EGIPCMMOIAA EPFGDLJCLLF, int ECBKFNGOBFP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x8177190", Offset = "0x8175990", VA = "0x188177190")]
	public static bool NALNDDPCEFD([In] MNJLPECGPEL NOGJAHKGFJD, [In] MNJLPECGPEL LHMEHOJLNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x8177030", Offset = "0x8175830", VA = "0x188177030", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x8177130", Offset = "0x8175930", VA = "0x188177130", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x8177220", Offset = "0x8175A20", VA = "0x188177220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x8177020", Offset = "0x8175820", VA = "0x188177020")]
	public void EBKFCGEKMKA([Out] EGIPCMMOIAA MAGIPLDDFJB, [Out] int ECBKFNGOBFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public static class FIBNHNBACDH
{
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public struct JLPKCIPJEBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public Guid JMHOEKKPCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public string PFNNEAHDLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public Vector3 KKEEFCOJJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public Quaternion FENAGHBAFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public Vector3 DKMKOJPHLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public int HMNELONNLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public APNNOCBGIPF JCPNJLMMOLN;

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x81726B0", Offset = "0x8170EB0", VA = "0x1881726B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public enum MBKEKPGEMNF
{
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	Scene,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	SubgraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	SubgraphRestore,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	RestoreCreationData,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	InventionPreview
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public static class DJMCLCIHGEM
{
	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x816B130", Offset = "0x8169930", VA = "0x18816B130")]
	public static bool ANGBGAKCDED(this MBKEKPGEMNF CEPGAJKBPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x816B150", Offset = "0x8169950", VA = "0x18816B150")]
	public static bool DPMJBEENFNC(this MBKEKPGEMNF CEPGAJKBPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x816B120", Offset = "0x8169920", VA = "0x18816B120")]
	public static bool AGAOENFAJBI(this MBKEKPGEMNF CEPGAJKBPDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[Flags]
public enum NDEENEMICFD
{
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	WorldPhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	AdditivePhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public interface ABJKGIEDKOO
{
	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OBGEGMIOPJH([In] Guid GJKNNKIANJJ, [Out] Guid NMNMOFPMJKK);
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[Flags]
public enum PIAJHAKGLKA
{
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public interface DKOPFDILECI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001EA")]
	GOKFDPLMAEF FCODLBKNNLI
	{
		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString KICGAHNGPAN();
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public enum IDPNPPFBNLD
{
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[TypeManager.ForcedStableTypeHash(8944033191217631913uL)]
public struct LMAGGPNPPGJ : ISystemStateComponentData, IComponentData, IEquatable<LMAGGPNPPGJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public float3 IIAOCOIFEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public float3 KNNDNJHDMEG;

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x8174B30", Offset = "0x8173330", VA = "0x188174B30", Slot = "4")]
	public bool Equals(LMAGGPNPPGJ KEKEFPAJGHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KKBGHPNMKLB
{
	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JOFCPDDLAND(long CHMDHAIDMFA);

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CJADKCNMAEF(NativeParallelHashSet<long> GBIKFNPKLAI);

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ENNGFGCJDBJ(World NAHDLONMOKF, NativeParallelHashMap<Guid, long> ADHHBCNNPIN);

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JLKFEFEEBBE(JKKCHPONOAD JLCFKNGJCID);

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EIDJCDOAACF(JKKCHPONOAD JLCFKNGJCID, [Out] Guid GEJCOKKPFFD, [Out] long CHMDHAIDMFA);

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HNJEGBPOAGB(JKKCHPONOAD JLCFKNGJCID, Guid GEJCOKKPFFD, long CHMDHAIDMFA);

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PKPIDMPCFJJ(Guid GEJCOKKPFFD);

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool IGLDONHPHPL(Guid GEJCOKKPFFD, [Out] int FKIODMAGCJI, [Out] int GIFCHMFDIEI);

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IGBNMINAPIM(Guid GEJCOKKPFFD, int FKIODMAGCJI, int GIFCHMFDIEI);

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JBNACIMJGEG(Guid GEJCOKKPFFD);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public class LBHJJCIMPIK
{
	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public LBHJJCIMPIK()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
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
