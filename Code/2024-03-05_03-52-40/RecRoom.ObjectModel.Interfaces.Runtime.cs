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
	public class LogRegistrationIndex : OLOBACIMOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x61B56B0", Offset = "0x61B44B0", VA = "0x1861B56B0", Slot = "4")]
		public override void GGPDGFKFIKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[DefaultMember("Item")]
public struct GFADIHGLLAF : IReadOnlyList<EDLOHAABCGP>, IEnumerable<EDLOHAABCGP>, IEnumerable, IReadOnlyCollection<EDLOHAABCGP>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct HJKJCEFJNHM : IEnumerator<EDLOHAABCGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly PHAPBKDLMJL FLJPOIKHIID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator GKFDOPGLMDE;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public EDLOHAABCGP OGCIBGAMGCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x61B10A0", Offset = "0x61AFEA0", VA = "0x1861B10A0", Slot = "4")]
			get
			{
				return default(EDLOHAABCGP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x61B1020", Offset = "0x61AFE20", VA = "0x1861B1020", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3BE6030", Offset = "0x3BE4E30", VA = "0x183BE6030")]
		public HJKJCEFJNHM(PHAPBKDLMJL FLJPOIKHIID, NativeArray<LocalId>.Enumerator GKFDOPGLMDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x61B0F60", Offset = "0x61AFD60", VA = "0x1861B0F60", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x61B0FA0", Offset = "0x61AFDA0", VA = "0x1861B0FA0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x61B0FE0", Offset = "0x61AFDE0", VA = "0x1861B0FE0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly PHAPBKDLMJL FLJPOIKHIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> HGFILCPIOJP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public EDLOHAABCGP GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x61B0370", Offset = "0x61AF170", VA = "0x1861B0370", Slot = "4")]
		get
		{
			return default(EDLOHAABCGP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61AFE90", Offset = "0x61AEC90", VA = "0x1861AFE90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int GFLJBHNBFOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7B8180", Offset = "0x7B6F80", VA = "0x1807B8180", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public PHAPBKDLMJL NMINOKIANBL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int EINKGEEBGAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7B8180", Offset = "0x7B6F80", VA = "0x1807B8180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool LNCGINAIOLE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x61AFDA0", Offset = "0x61AEBA0", VA = "0x1861AFDA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> DPNNOIIEFPF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2239B70", Offset = "0x2238970", VA = "0x182239B70")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> ENNONCIBDEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x61AFEE0", Offset = "0x61AECE0", VA = "0x1861AFEE0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61B0120", Offset = "0x61AEF20", VA = "0x1861B0120")]
	public GFADIHGLLAF(int DKDCFCAKJAJ, PHAPBKDLMJL FLJPOIKHIID, Allocator ALDDPOOJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3BE5CE0", Offset = "0x3BE4AE0", VA = "0x183BE5CE0")]
	public GFADIHGLLAF(PHAPBKDLMJL FLJPOIKHIID, NativeArray<LocalId> HGFILCPIOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x61B0300", Offset = "0x61AF100", VA = "0x1861B0300")]
	internal GFADIHGLLAF(PHAPBKDLMJL FLJPOIKHIID, NativeArray<Entity> ILPEGPIDHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x61B01B0", Offset = "0x61AEFB0", VA = "0x1861B01B0")]
	public GFADIHGLLAF(PHAPBKDLMJL FLJPOIKHIID, int AKCMMEDPGHB, Allocator ALDDPOOJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x61B0250", Offset = "0x61AF050", VA = "0x1861B0250")]
	public GFADIHGLLAF(GFADIHGLLAF JAOKGIFLLFB, Allocator ALDDPOOJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x61AFDE0", Offset = "0x61AEBE0", VA = "0x1861AFDE0")]
	public GFADIHGLLAF LOCLECIGPFG(Allocator ALDDPOOJFGI = Allocator.Temp)
	{
		return default(GFADIHGLLAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x61AFCD0", Offset = "0x61AEAD0", VA = "0x1861AFCD0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x61AFD10", Offset = "0x61AEB10", VA = "0x1861AFD10")]
	public HJKJCEFJNHM GGNEAJGHJIC()
	{
		return default(HJKJCEFJNHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x61AFF40", Offset = "0x61AED40", VA = "0x1861AFF40", Slot = "6")]
	private IEnumerator<EDLOHAABCGP> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x61B0030", Offset = "0x61AEE30", VA = "0x1861B0030", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[DefaultMember("Item")]
public struct CJHADDGPFGM : IList<EDLOHAABCGP>, ICollection<EDLOHAABCGP>, IEnumerable<EDLOHAABCGP>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct KBIFOPGKOMK : IEnumerator<EDLOHAABCGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly PHAPBKDLMJL FLJPOIKHIID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator GKFDOPGLMDE;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public EDLOHAABCGP OGCIBGAMGCC
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x61B2990", Offset = "0x61B1790", VA = "0x1861B2990", Slot = "4")]
			get
			{
				return default(EDLOHAABCGP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x61B2910", Offset = "0x61B1710", VA = "0x1861B2910", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3BE6030", Offset = "0x3BE4E30", VA = "0x183BE6030")]
		public KBIFOPGKOMK(PHAPBKDLMJL FLJPOIKHIID, NativeArray<LocalId>.Enumerator GKFDOPGLMDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x61B2850", Offset = "0x61B1650", VA = "0x1861B2850", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x61B2890", Offset = "0x61B1690", VA = "0x1861B2890", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x61B28D0", Offset = "0x61B16D0", VA = "0x1861B28D0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly PHAPBKDLMJL FLJPOIKHIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> HGFILCPIOJP;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public EDLOHAABCGP GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x61ADC30", Offset = "0x61ACA30", VA = "0x1861ADC30", Slot = "4")]
		get
		{
			return default(EDLOHAABCGP);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x61ADCB0", Offset = "0x61ACAB0", VA = "0x1861ADCB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int EDOFPONLMHN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x61AD6A0", Offset = "0x61AC4A0", VA = "0x1861AD6A0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int EINKGEEBGAC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x61AD6A0", Offset = "0x61AC4A0", VA = "0x1861AD6A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool OJMEMOAMNDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61ADBA0", Offset = "0x61AC9A0", VA = "0x1861ADBA0")]
	public CJHADDGPFGM(PHAPBKDLMJL FLJPOIKHIID, int AKCMMEDPGHB, Allocator ALDDPOOJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x61AD820", Offset = "0x61AC620", VA = "0x1861AD820")]
	public GFADIHGLLAF NENCDAKDEMB()
	{
		return default(GFADIHGLLAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x61AD3B0", Offset = "0x61AC1B0", VA = "0x1861AD3B0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x61AD3F0", Offset = "0x61AC1F0", VA = "0x1861AD3F0", Slot = "13")]
	public bool Contains(EDLOHAABCGP IFKPOCGDKDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x61AD480", Offset = "0x61AC280", VA = "0x1861AD480", Slot = "14")]
	public void CopyTo(EDLOHAABCGP[] HHAMBPGBENG, int ABBBMAHIKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x61AD330", Offset = "0x61AC130", VA = "0x1861AD330", Slot = "11")]
	public void Add(EDLOHAABCGP IFKPOCGDKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x61AD770", Offset = "0x61AC570", VA = "0x1861AD770", Slot = "7")]
	public void Insert(int OHINPGIGDNE, EDLOHAABCGP IFKPOCGDKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x61AD8F0", Offset = "0x61AC6F0", VA = "0x1861AD8F0", Slot = "15")]
	public bool Remove(EDLOHAABCGP IFKPOCGDKDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x61AD6E0", Offset = "0x61AC4E0", VA = "0x1861AD6E0", Slot = "6")]
	public int IndexOf(EDLOHAABCGP IFKPOCGDKDB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x61AD8A0", Offset = "0x61AC6A0", VA = "0x1861AD8A0", Slot = "8")]
	public void RemoveAt(int OHINPGIGDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x61AD5D0", Offset = "0x61AC3D0", VA = "0x1861AD5D0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x61AD610", Offset = "0x61AC410", VA = "0x1861AD610")]
	public KBIFOPGKOMK GGNEAJGHJIC()
	{
		return default(KBIFOPGKOMK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x61AD9C0", Offset = "0x61AC7C0", VA = "0x1861AD9C0", Slot = "16")]
	private IEnumerator<EDLOHAABCGP> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x61ADAB0", Offset = "0x61AC8B0", VA = "0x1861ADAB0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DMFKMIFLJFF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int DCFOMHNIJOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> NLNCFILAJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EDLOHAABCGP IHBOHOMNGBB(EDLOHAABCGP HGFILCPIOJP);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CDIKPPLICIE : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface PICIDOAHGBP : PBGNGIIMAPL, KBFGGFOMOIA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool KMJOLKOJMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	HBGOLNGPMIE GJFAPBPJNKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	JFFAAFKMPJC IJKCONNHPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	CNJPGLLGDND PJNHMDDFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	NKJKINCMCMK MPEBDCFPKOL
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	MHMIGGGDJPE DCJMIPHPGIN
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface KBFGGFOMOIA
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool DINCJKDOFJM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface JCGAKBIINLB
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HKBEGGIDIPP(bool MAEBFBHFPDE);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface NKJKINCMCMK
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool LNEPJGGEDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action LNMKOFAHBHF;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LNLOMIIPMBF(bool IBCOHIKFCFK);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AEAIHIGFALC(ByteString HLMOCJJFAAD);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PCNIEKIAGEP();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JHDFDEFFCEG();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HJHBFJBOGHF();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface CNJPGLLGDND
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	IMCGAAIAFJE GJFAPBPJNKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	JFFAAFKMPJC IJKCONNHPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	MJLGOJBIBDC OLEHJOPCMEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	PICIDOAHGBP EIIECJKGINE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	PHAPBKDLMJL NMINOKIANBL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	OEMIHPOHKKB PDPEJBHJGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	HKDMEIKNPPL KKICKIMNGPD
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	INHDMKDODNB LFBMPAMFKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	HJABEOOCBAM KNOPOALNBHN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	IINIKNKDBNA BJJEBOGEAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	ANAIAOKBNDP GENGOIBNJFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	BMJIIOBAEEC DLMANMPIHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	FMIEFMDIELM MFJIEPPLGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	APJFANKAAAL FKOACCDCEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	GEEBBBDCLIM DHLLIMOECMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	LGGJBFLLBEI PMEJPKLAIKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	MPJMFOACMEE BJPMGJJNJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	FLCMMALDFNG POKBEIKGDAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	EDJJPNKBJMK NDABLCGBFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	GODACKEHHPK HNNGMGHCDJP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NBIFDMECANL KGCAJHDHLKH
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	IMHCOMBEGHK GOEIFKJJGBO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	IHHJLGJOPGF JPEAADPCLIA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(ENKJDAAKHME))]
public readonly struct EDLOHAABCGP : IComparable<EDLOHAABCGP>, IEquatable<EDLOHAABCGP>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly EDLOHAABCGP LCPFPBICDEC;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int ALDFNCOPFIK = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int HIMELFJKFEA = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int DFEGHLGCAHI = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int FEEOBKHCKIB = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId JNDMOGCGEKD;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public PHAPBKDLMJL NMINOKIANBL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x61AA160", Offset = "0x61A8F60", VA = "0x1861AA160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public PICIDOAHGBP EIIECJKGINE
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x61AEAA0", Offset = "0x61AD8A0", VA = "0x1861AEAA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public LocalId POPBDLAHKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x61AEB00", Offset = "0x61AD900", VA = "0x1861AEB00")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	internal MHMIGGGDJPE DCJMIPHPGIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x61AEB40", Offset = "0x61AD940", VA = "0x1861AEB40")]
		get
		{
			return default(MHMIGGGDJPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool LBIFEOPNNOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x61AEB50", Offset = "0x61AD950", VA = "0x1861AEB50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool IICLNFNEFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x61AEA50", Offset = "0x61AD850", VA = "0x1861AEA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool DLLGEGNKIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x61AE750", Offset = "0x61AD550", VA = "0x1861AE750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x61AED60", Offset = "0x61ADB60", VA = "0x1861AED60")]
	public EDLOHAABCGP(PHAPBKDLMJL MPIFIHBPIIE, LocalId JNDMOGCGEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
	public BDPDEANOFFL NNBHENBNCNE()
	{
		return default(BDPDEANOFFL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x61AE5F0", Offset = "0x61AD3F0", VA = "0x1861AE5F0")]
	public static LocalId CCJKPBOFOJB(EDLOHAABCGP KKNDCMAOHLG)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x61AE630", Offset = "0x61AD430", VA = "0x1861AE630")]
	public static Entity CCJKPBOFOJB(EDLOHAABCGP KKNDCMAOHLG)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x61AE7A0", Offset = "0x61AD5A0", VA = "0x1861AE7A0")]
	public static bool EILLJGMDDAM(EDLOHAABCGP AOHIFIJNOBB, EDLOHAABCGP FNDBFMFAGPH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x61AA880", Offset = "0x61A9680", VA = "0x1861AA880")]
	public static bool CDMEFABOJMD(EDLOHAABCGP AOHIFIJNOBB, EDLOHAABCGP FNDBFMFAGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x61AEC30", Offset = "0x61ADA30", VA = "0x1861AEC30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x61AE8C0", Offset = "0x61AD6C0", VA = "0x1861AE8C0", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x61AE670", Offset = "0x61AD470", VA = "0x1861AE670", Slot = "4")]
	public int CompareTo(EDLOHAABCGP EDOEJIMPOFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "5")]
	public bool Equals(EDLOHAABCGP EDOEJIMPOFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HIFFNGHLFBE
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x61B0E70", Offset = "0x61AFC70", VA = "0x1861B0E70")]
	public static HDKJDIEIILD NKHHFODBLCO(this EDLOHAABCGP KDHDNCADFDJ)
	{
		return default(HDKJDIEIILD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x61B0D60", Offset = "0x61AFB60", VA = "0x1861B0D60")]
	public static BDPDEANOFFL FEDDIEBAKEJ(this EDLOHAABCGP KDHDNCADFDJ, [Optional] object BNAJMHPOOCG)
	{
		return default(BDPDEANOFFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2765C70", Offset = "0x2764A70", VA = "0x182765C70")]
	public static T NHODFIKMJMH<T>(this EDLOHAABCGP KDHDNCADFDJ) where T : struct, DPHHBGHMKAH
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class ENKJDAAKHME
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct MHMIGGGDJPE : IEquatable<MHMIGGGDJPE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte PDCBMAPDAEE;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] CMHKEDIBOOI;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static PHAPBKDLMJL LFJBFOCAMJP;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static PICIDOAHGBP AJENDGGAHOL;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static PHAPBKDLMJL[] CDOFMAGNEAP;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static PICIDOAHGBP[] OBPIPOKFKOE;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> CKENJJKPCKP;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public PICIDOAHGBP EIIECJKGINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x61B6DA0", Offset = "0x61B5BA0", VA = "0x1861B6DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public PHAPBKDLMJL PFKAJBJKBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x61B72A0", Offset = "0x61B60A0", VA = "0x1861B72A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x61B7450", Offset = "0x61B6250", VA = "0x1861B7450")]
	static MHMIGGGDJPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xC8D8B0", Offset = "0xC8C6B0", VA = "0x180C8D8B0")]
	internal MHMIGGGDJPE(byte MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x53D25B0", Offset = "0x53D13B0", VA = "0x1853D25B0", Slot = "4")]
	public bool Equals(MHMIGGGDJPE EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x61B6810", Offset = "0x61B5610", VA = "0x1861B6810", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1ADF0F0", Offset = "0x1ADDEF0", VA = "0x181ADF0F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x61B7390", Offset = "0x61B6190", VA = "0x1861B7390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x61B6760", Offset = "0x61B5560", VA = "0x1861B6760")]
	private static PHAPBKDLMJL CDKOLCOPAKL(byte PDCBMAPDAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x61B6CE0", Offset = "0x61B5AE0", VA = "0x1861B6CE0")]
	private static PICIDOAHGBP ILACKNGDJFI(byte PDCBMAPDAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x61B68B0", Offset = "0x61B56B0", VA = "0x1861B68B0")]
	private static object FAHENFALFDC(byte PDCBMAPDAEE, object[] NPCOHMLDIGK, object KKIHKKGMFIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x61B6D90", Offset = "0x61B5B90", VA = "0x1861B6D90")]
	private static int JEPEHINAOKE(byte PDCBMAPDAEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x61B6E80", Offset = "0x61B5C80", VA = "0x1861B6E80")]
	private static int LHAHKJCFIHN(byte PDCBMAPDAEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x61B6E90", Offset = "0x61B5C90", VA = "0x1861B6E90")]
	private static (int, int) LLHGPIGLLGG(byte PDCBMAPDAEE)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x61B7380", Offset = "0x61B6180", VA = "0x1861B7380")]
	private static byte PEFIKFPMPKD(int OCEOBDFJNCG, int OHINPGIGDNE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x61B6A20", Offset = "0x61B5820", VA = "0x1861B6A20")]
	internal static MHMIGGGDJPE GGPDGFKFIKF(PICIDOAHGBP HJGBBLOLKLB, PHAPBKDLMJL GJDPDANDLMJ)
	{
		return default(MHMIGGGDJPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x61B6550", Offset = "0x61B5350", VA = "0x1861B6550")]
	internal static void AHELJNGPOGN(MHMIGGGDJPE PDCBMAPDAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x61B6F10", Offset = "0x61B5D10", VA = "0x1861B6F10")]
	private static void MJKLCCKELAJ(int DKDCFCAKJAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface AJEPAGJFCEE
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HNNDGFKJLCM();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DDEANFFPGIB(bool JLLJFLJGEKF);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MPHAHEEHACJ(GameObject EAPMMKKAJGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface JEKIGNLFBIG
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	Guid IBBBBBPFJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EOONLLMPIEC(Guid PEENKALMDBD, Guid FEIOHDJBJJO);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task BEFIAPCDBDJ(EDLOHAABCGP CGNLNBCPDDA);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DJOKHAAJCJE(EDLOHAABCGP ENAIIHBGJMJ, EDLOHAABCGP FEOGIMKDFKL, [Out] Vector3 OOEFMBGLDAP, [Out] Quaternion POGHNPIKNGB);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NCGDMGDMBAB(LJDODBBOBFF EFGFHFDPEIB, Vector3 OOEFMBGLDAP, Quaternion POGHNPIKNGB);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MOGOJIPJKHC(EDLOHAABCGP PMILBFOBDPJ, [Out] Vector3 GOEMDJEKIHF, [Out] Quaternion DBFNCADOGMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface NJEJBINKNCK
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGHHECEFBMO(GFADIHGLLAF HGFILCPIOJP);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface IPFIGHBOKCI
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FAFGPMBAECJ(GameObject KMLGGCDKGIG, GameObject MOKAOFEPFEJ, int HGIFDFGOCIH);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface JFFAAFKMPJC
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	AJEPAGJFCEE NFBHPGNIGBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	NJAABMHLEIA CGIDDCOMFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	FHCPJEPHBIJ PHNDFPBPPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	CHMIJAOPMNI MCFNIMACLAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	DOECMPMECBL DBDLFFEENIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	BBKECPDIHNG MCDJMOEMKKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	CBGFIGAMNBC OCDBIKPBOGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	NCEMNBNFMGM KNFCEGLGNCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface KKONHCMBHDP
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FMLILBMBNLL(Action CJMBDOEJJJI, bool ECOIKNKHNHK);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NGMPBEPNLHI(string OCCHBLONHPL);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface NJAABMHLEIA
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string OHMCCNGHCGE
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] FDBMJLCKDKL(IEnumerable<OHEJNFIAMDB> OLMKAOHHLBL);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JBBDOFDGLDF(GameObject EAPMMKKAJGJ, [Out] HDKJDIEIILD[] FLKHMJMMFBD);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JPKMKKHBFLC(GameObject EAPMMKKAJGJ, [Out] int EDGAINEDPKD, [Out] HLKLEDFOFOB HCBFDEJPHHJ);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JOKHLKLBCEJ PCBEABPDCON(OHEJNFIAMDB GFBEKCAHNCH);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JOKHLKLBCEJ PCBEABPDCON(string KIFNKLCLPNA, HDKJDIEIILD[] OMOAAJHFJOC, Vector3 AJFNKFFNDBD, Quaternion OKEJHHGCFPM, Vector3 BJOKGACKCGO);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GameObject IGMGFALEHIJ(string KIFNKLCLPNA);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GGOEFCBONNL(GameObject OHAIPFODCHD, bool OOONCECEHDH);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GNAKNLKIEFC(GameObject EAPMMKKAJGJ, bool FDMPOKBALGK, bool HJHOPODONGK);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class NEKNBFGFJHL
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x61B77E0", Offset = "0x61B65E0", VA = "0x1861B77E0")]
	public static JOKHLKLBCEJ PCBEABPDCON(this NJAABMHLEIA GKPFGLIAHLN, Vector3 AJFNKFFNDBD, Quaternion OKEJHHGCFPM, Vector3 BJOKGACKCGO, params HDKJDIEIILD[] FLKHMJMMFBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface FHCPJEPHBIJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KNICPOBDFMM(bool IBCOHIKFCFK);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface CHMIJAOPMNI
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool AAFOIFKDCPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool JJHCCHFCGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool NJJLBMAJDJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	int LEOCOHOEHEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool DKHICDLPCND
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LBDFBCIADFJ(object AOJMAAJAPBJ);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PAJPOONKPMO(object AOJMAAJAPBJ);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HBABGIKLEFO(object EOCODFIAJEL);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PCEBMBBMFEA(object EOCODFIAJEL);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int LNLNEBFDPJG(GameObject JDOCCOMDNNG);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BEMJCNPIEHD(NativeArray<int> HEAPFFKHPOO);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PACEOECJELB(NativeArray<int> FCEENCGCAKP);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CFPMLBGPNDM();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OCDEKMNKNOP(uint EBGBHADEHPM, ReadOnlySpan<byte> GMODKOMFDLN, bool KHIGCMLABJJ = false);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OCDEKMNKNOP(uint EBGBHADEHPM, ReadOnlySpan<byte> GMODKOMFDLN, ReadOnlySpan<byte> HDBKIIGIEJL, bool KHIGCMLABJJ = false);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface DOECMPMECBL
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HICIMLMIPAP(GameObject EAPMMKKAJGJ);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface AEJIFCHPAJI
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OMMKCPHNGGK(string LJCDGDONMLD);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface LCBKFPMNMGG
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NKPDMOBIBDN(GameObject EAPMMKKAJGJ);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMEGHAGKBNO(GameObject EAPMMKKAJGJ);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	object IMFDDDDJDBH(EDLOHAABCGP JNDMOGCGEKD, GameObject EAPMMKKAJGJ, Action<EDLOHAABCGP, int> NHPEKKMOHMO);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LPBDOPFEBPM(GameObject EAPMMKKAJGJ, object BBOAALNJGCI);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface BBKECPDIHNG
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	int MMGCKCGMLPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int CICCAJCJBAI(GameObject EAPMMKKAJGJ);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KBPFPMFNIIF([Out] Vector3 AJFNKFFNDBD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HHJDPPOLJHM();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface CBGFIGAMNBC
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool LNEPJGGEDLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool ANPKFDCKJJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface FINOGKBHHBG
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	MJCILEDACOD MCKBKEDDGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	EGMOECHFJNJ CPNNIIPHIMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KGEEDGLJELD(Transform NBCGMJPEDEM);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GCGBBKFHJIC(Transform NBCGMJPEDEM, EEDFDLJFDEM CAJANEDDNHG);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EPNIELBPMFG(Transform NBCGMJPEDEM, DPIIANELJKL KJMILHHGBID);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface NCEMNBNFMGM
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMLPGLPFEJK();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface ONOAFLLLHPL
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHIMNAMEPGM();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface GKIIINMHNHK
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HLKLEDFOFOB OLHEOKANEII(GameObject JDOCCOMDNNG);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KAOEHCIODIF(GameObject EAPMMKKAJGJ, PGDCJKHFMEC KIDJGCECMHL, PLGEILLLIPO OLEMGPLLPDF);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string HIKBDKBJPIE(int FJIJLBIGEAH);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GOJDANIEDPO(string EAHBLLLJAMK);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MHJAHPNMFFJ(EDLOHAABCGP JNDMOGCGEKD, int[] OOECMMNMHLG);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LLELHPCPGBL(InteractionFilterData EEDANCJJEPL, int GNMODFEIMHL);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LDCPOAIHIBC(EDLOHAABCGP JNDMOGCGEKD, int OOECMMNMHLG);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MMMKCBLHPOB(EDLOHAABCGP JNDMOGCGEKD, int OOECMMNMHLG);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct OLKJACKNALF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly FMIKBHHGHAI CJNJFDOAKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly FMIKBHHGHAI INMKHBKJJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal readonly uint CCKPFBEFJAH;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x61BA0B0", Offset = "0x61B8EB0", VA = "0x1861BA0B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct BBLNPNCFCGK
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly IIFCCHIKGII KOLDIMNADKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly OLKJACKNALF CJMBDOEJJJI;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x61AA620", Offset = "0x61A9420", VA = "0x1861AA620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct CMIBILOEJGM
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly IIFCCHIKGII KOLDIMNADKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly OLKJACKNALF CJMBDOEJJJI;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x61AA620", Offset = "0x61A9420", VA = "0x1861AA620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct EGAAMDALOOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint CCKPFBEFJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly bool NOFIMPIPCJM;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x61AEEA0", Offset = "0x61ADCA0", VA = "0x1861AEEA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct FMIKBHHGHAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal int LBJEFCOBKGF;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x61AFC70", Offset = "0x61AEA70", VA = "0x1861AFC70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface MAEEHOFHAHB
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	HIFOBNOILGP MLCKBDOMKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum DLPMHGADLJO
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
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface JOKHLKLBCEJ : ICOHMKGALPN
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	BDPDEANOFFL JHNIBLNCHHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	DLPMHGADLJO HCDNGEFKKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool KOOGPLMKPJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	GameObject EAPMMKKAJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<JOKHLKLBCEJ> CNNBPCHDKBG;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(MJLGOJBIBDC LHBLFLHHEGA, EDLOHAABCGP BLCFDMELOLF);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool PBNNMBPEBOI);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class MPHEKGDPCED
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x61B7460", Offset = "0x61B6260", VA = "0x1861B7460")]
	public static bool CMIFOPFAHBG(this JOKHLKLBCEJ GCKKDDOBMIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x61B7500", Offset = "0x61B6300", VA = "0x1861B7500")]
	public static bool FANFLMJDNMF(this JOKHLKLBCEJ GCKKDDOBMIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x61B74B0", Offset = "0x61B62B0", VA = "0x1861B74B0")]
	public static bool EMBMCLNALKJ(this JOKHLKLBCEJ GCKKDDOBMIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x61B7550", Offset = "0x61B6350", VA = "0x1861B7550")]
	public static bool KMJOLKOJMGL(this JOKHLKLBCEJ GCKKDDOBMIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface ICOHMKGALPN
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool AMNKABLPIGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	EDLOHAABCGP IJLCCNOBJGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[MIDGHOOAONL(AOJPFHDMMJA.LoadInstance)]
internal interface INHDONFHOFP
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<EKHDEJLFGJL> LDMJPPGHKKI;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface BAEAOFOABIN : NCBHDJPKGOF<HDKJDIEIILD>, FBCOEGBMACK, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface ELMKKAPAPOF<T> : AJLJLLGMOIK<HDKJDIEIILD, T>, NCBHDJPKGOF<HDKJDIEIILD>, FBCOEGBMACK, IDisposable, BAEAOFOABIN where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class PHNCCLICGLE
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x251B430", Offset = "0x251A230", VA = "0x18251B430")]
	public static bool CCEPLMLEFMB<T>(this NCBHDJPKGOF<HDKJDIEIILD> EIJAJNKHLMI, HDKJDIEIILD OMOAAJHFJOC, [Out] T MAEBFBHFPDE) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2742250", Offset = "0x2741050", VA = "0x182742250")]
	public static bool DFGFKLLLOGA<T>(this NCBHDJPKGOF<HDKJDIEIILD> EIJAJNKHLMI, HDKJDIEIILD OMOAAJHFJOC, [In] T BAFHHLIGKHL) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface OBINNBHLFEA : NCBHDJPKGOF<EDLOHAABCGP>, FBCOEGBMACK, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface GLEEEICICAM<T> : AJLJLLGMOIK<EDLOHAABCGP, T>, NCBHDJPKGOF<EDLOHAABCGP>, FBCOEGBMACK, IDisposable, OBINNBHLFEA where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class MPAFMNDKMGG
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2601D90", Offset = "0x2600B90", VA = "0x182601D90")]
	public static T MHEOMGMBJHC<T>(this NCBHDJPKGOF<EDLOHAABCGP> EIJAJNKHLMI, EDLOHAABCGP JNDMOGCGEKD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2742270", Offset = "0x2741070", VA = "0x182742270")]
	public static bool DFGFKLLLOGA<T>(this NCBHDJPKGOF<EDLOHAABCGP> EIJAJNKHLMI, EDLOHAABCGP JNDMOGCGEKD, [In] T BAFHHLIGKHL) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct IMDOBBINGKI : IComparable<IMDOBBINGKI>, IEquatable<IMDOBBINGKI>
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly IMDOBBINGKI LCPFPBICDEC;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly IMDOBBINGKI KEFFFEKIHJJ;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IMDOBBINGKI DKHNMMIPIHB;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly IMDOBBINGKI AINAPAOJPNC;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly IMDOBBINGKI FBKCKEBLPAI;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly IMDOBBINGKI KCBHHFNHANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int LNBHMBDGGMM;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool JFLBFAJPAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x61B1E30", Offset = "0x61B0C30", VA = "0x1861B1E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public int KKKKEIKCOLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x61B1E20", Offset = "0x61B0C20", VA = "0x1861B1E20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8EAF70", Offset = "0x8E9D70", VA = "0x1808EAF70")]
	public IMDOBBINGKI(int OHINPGIGDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x61B1DC0", Offset = "0x61B0BC0", VA = "0x1861B1DC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x61B1D40", Offset = "0x61B0B40", VA = "0x1861B1D40", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x86D940", Offset = "0x86C740", VA = "0x18086D940", Slot = "5")]
	public bool Equals(IMDOBBINGKI EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1813240", Offset = "0x1812040", VA = "0x181813240", Slot = "4")]
	public int CompareTo(IMDOBBINGKI EDOEJIMPOFP)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xD7D620", Offset = "0xD7C420", VA = "0x180D7D620")]
	public static IMDOBBINGKI CCJKPBOFOJB(int OHINPGIGDNE)
	{
		return default(IMDOBBINGKI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0xD7D620", Offset = "0xD7C420", VA = "0x180D7D620")]
	public static int CCJKPBOFOJB(IMDOBBINGKI CMJOIMNALBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x61B1E40", Offset = "0x61B0C40", VA = "0x1861B1E40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public readonly struct BDPDEANOFFL : IEquatable<BDPDEANOFFL>, ICOHMKGALPN
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly BDPDEANOFFL FCOIJBMEOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EDLOHAABCGP IJLCCNOBJGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0", Slot = "6")]
		get
		{
			return default(EDLOHAABCGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public KHBCBIKOPJJ HJKOCBOHHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(KHBCBIKOPJJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public CGEFJAPLICJ PDPEJBHJGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(CGEFJAPLICJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private PHAPBKDLMJL NMINOKIANBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x61AA160", Offset = "0x61A8F60", VA = "0x1861AA160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public GameObject EAPMMKKAJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x61AAA60", Offset = "0x61A9860", VA = "0x1861AAA60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public HDKJDIEIILD IDEOAALEKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x61AA8A0", Offset = "0x61A96A0", VA = "0x1861AA8A0")]
		get
		{
			return default(HDKJDIEIILD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public GKBGKNFOJCD POEELFAKNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x61AADD0", Offset = "0x61A9BD0", VA = "0x1861AADD0")]
		get
		{
			return default(GKBGKNFOJCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public HLKLEDFOFOB DIPGJGDMAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x61AA940", Offset = "0x61A9740", VA = "0x1861AA940")]
		get
		{
			return default(HLKLEDFOFOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool JPOEFLEEDOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x61AAEE0", Offset = "0x61A9CE0", VA = "0x1861AAEE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool NLFFLJLFELF
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x61AA840", Offset = "0x61A9640", VA = "0x1861AA840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool FBFIHEPNLMH
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x61AAE70", Offset = "0x61A9C70", VA = "0x1861AAE70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool LIPHCHEBICP
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x61AABF0", Offset = "0x61A99F0", VA = "0x1861AABF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool IILNNKMCMGN
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x61AAE90", Offset = "0x61A9C90", VA = "0x1861AAE90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool DFEMKMBJNCG
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x61AAD90", Offset = "0x61A9B90", VA = "0x1861AAD90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool JBHOGDGGLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x61AAF60", Offset = "0x61A9D60", VA = "0x1861AAF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool NGJBMLJBCJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x61AAF00", Offset = "0x61A9D00", VA = "0x1861AAF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool LPFAKJCFOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x61AAF40", Offset = "0x61A9D40", VA = "0x1861AAF40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public FKABDLMGJPE OJFLGKNLBBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(FKABDLMGJPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public HJOIIHHNKIH JFBAIFEDIAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(HJOIIHHNKIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public NDCCLBLDEMN MFJIEPPLGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(NDCCLBLDEMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public AHHLKOPAEPA BIBDPDCHBAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(AHHLKOPAEPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public MGNFBHLALIE DLMANMPIHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(MGNFBHLALIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public GJNPBGJKHEA HPPDEPAKOOP
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(GJNPBGJKHEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public LJDODBBOBFF MBNNGNANBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(LJDODBBOBFF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public HIDEHMBJFOL ICICGMDFHMK
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(HIDEHMBJFOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool CMIFOPFAHBG
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x61AA750", Offset = "0x61A9550", VA = "0x1861AA750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool EMEPCLLCHGH
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x61AB180", Offset = "0x61A9F80", VA = "0x1861AB180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool PILGDHEIMPC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x61AAC20", Offset = "0x61A9A20", VA = "0x1861AAC20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	private bool CAKPOOCIODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7D4310", Offset = "0x7D3110", VA = "0x1807D4310", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0")]
	public BDPDEANOFFL(EDLOHAABCGP JNDMOGCGEKD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x61AA860", Offset = "0x61A9660", VA = "0x1861AA860")]
	public static bool CCJKPBOFOJB(BDPDEANOFFL MAEBFBHFPDE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x85C2D0", Offset = "0x85B0D0", VA = "0x18085C2D0")]
	public static EDLOHAABCGP CCJKPBOFOJB(BDPDEANOFFL MAEBFBHFPDE)
	{
		return default(EDLOHAABCGP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x61AAC10", Offset = "0x61A9A10", VA = "0x1861AAC10")]
	public static bool EILLJGMDDAM(BDPDEANOFFL AOHIFIJNOBB, BDPDEANOFFL FNDBFMFAGPH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x61AA880", Offset = "0x61A9680", VA = "0x1861AA880")]
	public static bool CDMEFABOJMD(BDPDEANOFFL AOHIFIJNOBB, BDPDEANOFFL FNDBFMFAGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x61AAC60", Offset = "0x61A9A60", VA = "0x1861AAC60", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "4")]
	public bool Equals(BDPDEANOFFL EDOEJIMPOFP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x85C2D0", Offset = "0x85B0D0", VA = "0x18085C2D0")]
	public static BDPDEANOFFL CCJKPBOFOJB(EDLOHAABCGP PDDIPEOJCBN)
	{
		return default(BDPDEANOFFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x61AA9E0", Offset = "0x61A97E0", VA = "0x1861AA9E0")]
	public ODHAMGOMGLD DKLIJKNMAMN()
	{
		return default(ODHAMGOMGLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x61AAEB0", Offset = "0x61A9CB0", VA = "0x1861AAEB0")]
	public CFMGCFCCPGI LPDHEGIFDDA()
	{
		return default(CFMGCFCCPGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x61AB1C0", Offset = "0x61A9FC0", VA = "0x1861AB1C0")]
	public JMJPADAEJCH PLDCLOJEGJO()
	{
		return default(JMJPADAEJCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x61AACF0", Offset = "0x61A9AF0", VA = "0x1861AACF0")]
	public void FEDDIEBAKEJ([Optional] object BNAJMHPOOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x61AB090", Offset = "0x61A9E90", VA = "0x1861AB090")]
	public bool PENGGLAKNPC(object BNAJMHPOOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x61AAFA0", Offset = "0x61A9DA0", VA = "0x1861AAFA0")]
	public bool OMNHLAGPFJL(object BNAJMHPOOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x61AB210", Offset = "0x61AA010", VA = "0x1861AB210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct LJDODBBOBFF : IEquatable<LJDODBBOBFF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public EDLOHAABCGP IJLCCNOBJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(EDLOHAABCGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public BDPDEANOFFL JHNIBLNCHHG
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	private PHAPBKDLMJL NMINOKIANBL
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x61AA160", Offset = "0x61A8F60", VA = "0x1861AA160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	private CNJPGLLGDND PJNHMDDFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x61B53D0", Offset = "0x61B41D0", VA = "0x1861B53D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	private LGGJBFLLBEI AEONNJJFFJM
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x61B4F70", Offset = "0x61B3D70", VA = "0x1861B4F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool MBAJDLAIJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x61B5460", Offset = "0x61B4260", VA = "0x1861B5460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public Guid BMCPMAGBIAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x61B4E50", Offset = "0x61B3C50", VA = "0x1861B4E50")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public bool JBIIAPOGPJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x61B4DC0", Offset = "0x61B3BC0", VA = "0x1861B4DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public Guid MKINNPMLLHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x61B54F0", Offset = "0x61B42F0", VA = "0x1861B54F0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0")]
	public LJDODBBOBFF(EDLOHAABCGP JNDMOGCGEKD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x61AA860", Offset = "0x61A9660", VA = "0x1861AA860")]
	public static bool CCJKPBOFOJB(LJDODBBOBFF MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x61B5070", Offset = "0x61B3E70", VA = "0x1861B5070", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "4")]
	public bool Equals(LJDODBBOBFF EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x61AA600", Offset = "0x61A9400", VA = "0x1861AA600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x61B4FD0", Offset = "0x61B3DD0", VA = "0x1861B4FD0")]
	public bool CLFONMADHKE([Out] Guid APHIOIJKKOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x61B5100", Offset = "0x61B3F00", VA = "0x1861B5100")]
	public void FCIEPBEHHCI(Guid KJBIGJEIABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x61B5610", Offset = "0x61B4410", VA = "0x1861B5610")]
	public bool PGNFDHFCHOE([Out] Guid GOOFHOHFPNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x61B5220", Offset = "0x61B4020", VA = "0x1861B5220")]
	public void FILMOJGDIPF(Guid KJBIGJEIABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x61B5340", Offset = "0x61B4140", VA = "0x1861B5340")]
	public void FKCFMAFFEAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct JMJPADAEJCH : IEquatable<JMJPADAEJCH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public EDLOHAABCGP IJLCCNOBJGC
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(EDLOHAABCGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public BDPDEANOFFL JHNIBLNCHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private PHAPBKDLMJL NMINOKIANBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x61AA160", Offset = "0x61A8F60", VA = "0x1861AA160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private CNJPGLLGDND PJNHMDDFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x61B2640", Offset = "0x61B1440", VA = "0x1861B2640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private MPJMFOACMEE IKOMLDJPFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x61B27F0", Offset = "0x61B15F0", VA = "0x1861B27F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float3 OEBLJKIOGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x61B23F0", Offset = "0x61B11F0", VA = "0x1861B23F0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public quaternion FPNGPCPDLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x61B26D0", Offset = "0x61B14D0", VA = "0x1861B26D0")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public BDPDEANOFFL KHFAENGNDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x61B25B0", Offset = "0x61B13B0", VA = "0x1861B25B0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0")]
	public JMJPADAEJCH(EDLOHAABCGP JNDMOGCGEKD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x85C2D0", Offset = "0x85B0D0", VA = "0x18085C2D0")]
	public static EDLOHAABCGP CCJKPBOFOJB(JMJPADAEJCH MAEBFBHFPDE)
	{
		return default(EDLOHAABCGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x61B2520", Offset = "0x61B1320", VA = "0x1861B2520", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "4")]
	public bool Equals(JMJPADAEJCH EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x61AA600", Offset = "0x61A9400", VA = "0x1861AA600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct ODHAMGOMGLD : IEquatable<ODHAMGOMGLD>
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly ODHAMGOMGLD FCOIJBMEOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public EDLOHAABCGP IJLCCNOBJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(EDLOHAABCGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public BDPDEANOFFL JHNIBLNCHHG
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public KHBCBIKOPJJ HJKOCBOHHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(KHBCBIKOPJJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CGEFJAPLICJ PDPEJBHJGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(CGEFJAPLICJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private PHAPBKDLMJL NMINOKIANBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x61AA160", Offset = "0x61A8F60", VA = "0x1861AA160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private CNJPGLLGDND PJNHMDDFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x61B8DB0", Offset = "0x61B7BB0", VA = "0x1861B8DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private OEMIHPOHKKB KJKOKAGKIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x61B8410", Offset = "0x61B7210", VA = "0x1861B8410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public GFADIHGLLAF OIOIMPMFMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x61B96C0", Offset = "0x61B84C0", VA = "0x1861B96C0")]
		get
		{
			return default(GFADIHGLLAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public IEnumerable<BDPDEANOFFL> LHMFCJHGBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x61B9A00", Offset = "0x61B8800", VA = "0x1861B9A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public IEnumerable<BDPDEANOFFL> DAJGKGJJHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x61B8BB0", Offset = "0x61B79B0", VA = "0x1861B8BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public int CHILAFOBEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x61B7C70", Offset = "0x61B6A70", VA = "0x1861B7C70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public int IMGMNOMMIIL
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x61B93C0", Offset = "0x61B81C0", VA = "0x1861B93C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public string PAHJIBDDKIP
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x61B7D60", Offset = "0x61B6B60", VA = "0x1861B7D60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x61B9780", Offset = "0x61B8580", VA = "0x1861B9780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public CPFCINEGKPG IMIJKDEJLOL
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x61B8A10", Offset = "0x61B7810", VA = "0x1861B8A10")]
		get
		{
			return default(CPFCINEGKPG);
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x61B8A70", Offset = "0x61B7870", VA = "0x1861B8A70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public GMCCKJLLOHO HGCPFMKHNJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x61B8D50", Offset = "0x61B7B50", VA = "0x1861B8D50")]
		get
		{
			return default(GMCCKJLLOHO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x61B9180", Offset = "0x61B7F80", VA = "0x1861B9180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public BJILLFEBAPF BIAMOABMLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x61B8B50", Offset = "0x61B7950", VA = "0x1861B8B50")]
		get
		{
			return default(BJILLFEBAPF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x61B8AE0", Offset = "0x61B78E0", VA = "0x1861B8AE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public float PJIJDDIIFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x61B83B0", Offset = "0x61B71B0", VA = "0x1861B83B0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x61B95B0", Offset = "0x61B83B0", VA = "0x1861B95B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool ELNBHDEOENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x61B9B70", Offset = "0x61B8970", VA = "0x1861B9B70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x61B89A0", Offset = "0x61B77A0", VA = "0x1861B89A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool MPILPOBHJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x61B7D00", Offset = "0x61B6B00", VA = "0x1861B7D00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x61B92E0", Offset = "0x61B80E0", VA = "0x1861B92E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool GKEFJACHIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x61B9890", Offset = "0x61B8690", VA = "0x1861B9890")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x61B91F0", Offset = "0x61B7FF0", VA = "0x1861B91F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool NDLHPJAJIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x61B9BD0", Offset = "0x61B89D0", VA = "0x1861B9BD0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x61B8470", Offset = "0x61B7270", VA = "0x1861B8470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool JCKMEFDOMGD
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x61B9830", Offset = "0x61B8630", VA = "0x1861B9830")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x61B9350", Offset = "0x61B8150", VA = "0x1861B9350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool JFDAEEHPODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x61B9550", Offset = "0x61B8350", VA = "0x1861B9550")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x61B9480", Offset = "0x61B8280", VA = "0x1861B9480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool JGGAIJJGBOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x61B9120", Offset = "0x61B7F20", VA = "0x1861B9120")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x61B9410", Offset = "0x61B8210", VA = "0x1861B9410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public EOOLPFLHNKA PJPBGEEONFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x61B94F0", Offset = "0x61B82F0", VA = "0x1861B94F0")]
		get
		{
			return default(EOOLPFLHNKA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x61B9990", Offset = "0x61B8790", VA = "0x1861B9990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public IEnumerable<int> FIACAFDIPKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x61B98F0", Offset = "0x61B86F0", VA = "0x1861B98F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x61B8500", Offset = "0x61B7300", VA = "0x1861B8500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public int PPHJNFCLDEA
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x61B9620", Offset = "0x61B8420", VA = "0x1861B9620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0")]
	public ODHAMGOMGLD(EDLOHAABCGP JNDMOGCGEKD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x61AA860", Offset = "0x61A9660", VA = "0x1861AA860")]
	public static bool CCJKPBOFOJB(ODHAMGOMGLD MAEBFBHFPDE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x61AAC10", Offset = "0x61A9A10", VA = "0x1861AAC10")]
	public static bool EILLJGMDDAM(ODHAMGOMGLD AOHIFIJNOBB, ODHAMGOMGLD FNDBFMFAGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x61B8760", Offset = "0x61B7560", VA = "0x1861B8760", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "4")]
	public bool Equals(ODHAMGOMGLD EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x61AA600", Offset = "0x61A9400", VA = "0x1861AA600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x85C2D0", Offset = "0x85B0D0", VA = "0x18085C2D0")]
	public static BDPDEANOFFL CCJKPBOFOJB(ODHAMGOMGLD LANMIEEPANH)
	{
		return default(BDPDEANOFFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x61B84E0", Offset = "0x61B72E0", VA = "0x1861B84E0")]
	public bool EAMEHCNAFPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x61B8CE0", Offset = "0x61B7AE0", VA = "0x1861B8CE0")]
	public bool HPFHDBJPMDP(PNFLHPNKBIO BCCJNCFLBPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x61B9260", Offset = "0x61B8060", VA = "0x1861B9260")]
	public void KNANFNCDDPL(PNFLHPNKBIO BCCJNCFLBPH, bool MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x61B87F0", Offset = "0x61B75F0", VA = "0x1861B87F0")]
	public GFADIHGLLAF FDNBAHALGJA(Allocator ALDDPOOJFGI)
	{
		return default(GFADIHGLLAF);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x61B8E40", Offset = "0x61B7C40", VA = "0x1861B8E40")]
	public void JDFNGIFJGEB(ODHAMGOMGLD EDOEJIMPOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x61B7E10", Offset = "0x61B6C10", VA = "0x1861B7E10")]
	public void CLLAKNPHPOD(List<BDPDEANOFFL> IKDANHICKPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct CKIJMLPNAOL : IEquatable<CKIJMLPNAOL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public BDPDEANOFFL JHNIBLNCHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x61ADD40", Offset = "0x61ACB40", VA = "0x1861ADD40", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "4")]
	public bool Equals(CKIJMLPNAOL EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x61AA600", Offset = "0x61A9400", VA = "0x1861AA600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct HJOIIHHNKIH : IEquatable<HJOIIHHNKIH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public BDPDEANOFFL JHNIBLNCHHG
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private PHAPBKDLMJL NMINOKIANBL
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x61AA160", Offset = "0x61A8F60", VA = "0x1861AA160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0")]
	public HJOIIHHNKIH(EDLOHAABCGP JNDMOGCGEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x61B1960", Offset = "0x61B0760", VA = "0x1861B1960", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "4")]
	public bool Equals(HJOIIHHNKIH EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x61AA600", Offset = "0x61A9400", VA = "0x1861AA600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x61B18C0", Offset = "0x61B06C0", VA = "0x1861B18C0")]
	public void COJAMHJFIEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x61B1820", Offset = "0x61B0620", VA = "0x1861B1820")]
	public void COBKLJAOBIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct HCCEIELMOHD : IEquatable<HCCEIELMOHD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public BDPDEANOFFL JHNIBLNCHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x61B05F0", Offset = "0x61AF3F0", VA = "0x1861B05F0", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "4")]
	public bool Equals(HCCEIELMOHD EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x61AA600", Offset = "0x61A9400", VA = "0x1861AA600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct FCIGODMDBIJ : IEquatable<FCIGODMDBIJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public BDPDEANOFFL JHNIBLNCHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x61AF230", Offset = "0x61AE030", VA = "0x1861AF230", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "4")]
	public bool Equals(FCIGODMDBIJ EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x61AA600", Offset = "0x61A9400", VA = "0x1861AA600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public readonly struct HGOHNCKJMPA : IEquatable<HGOHNCKJMPA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public BDPDEANOFFL JHNIBLNCHHG
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x61B09D0", Offset = "0x61AF7D0", VA = "0x1861B09D0", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "4")]
	public bool Equals(HGOHNCKJMPA EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x61AA600", Offset = "0x61A9400", VA = "0x1861AA600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct BCPIIMGIAJI : IEquatable<BCPIIMGIAJI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public BDPDEANOFFL JHNIBLNCHHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x61AA6C0", Offset = "0x61A94C0", VA = "0x1861AA6C0", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "4")]
	public bool Equals(BCPIIMGIAJI EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x61AA600", Offset = "0x61A9400", VA = "0x1861AA600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct CGEFJAPLICJ : IEquatable<CGEFJAPLICJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public EDLOHAABCGP IJLCCNOBJGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(EDLOHAABCGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public BDPDEANOFFL JHNIBLNCHHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	private PHAPBKDLMJL NMINOKIANBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x61AA160", Offset = "0x61A8F60", VA = "0x1861AA160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	private CNJPGLLGDND PJNHMDDFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x61ACDF0", Offset = "0x61ABBF0", VA = "0x1861ACDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private OEMIHPOHKKB KJKOKAGKIDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x61ACAB0", Offset = "0x61AB8B0", VA = "0x1861ACAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public EDLOHAABCGP HIOBKEGHEHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x61AC990", Offset = "0x61AB790", VA = "0x1861AC990")]
		get
		{
			return default(EDLOHAABCGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public BDPDEANOFFL GAHJCNPPPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x61ACC30", Offset = "0x61ABA30", VA = "0x1861ACC30")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public BDPDEANOFFL IJIEPIJIKFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x61ACBA0", Offset = "0x61AB9A0", VA = "0x1861ACBA0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0")]
	public CGEFJAPLICJ(EDLOHAABCGP JNDMOGCGEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x61ACB10", Offset = "0x61AB910", VA = "0x1861ACB10", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "4")]
	public bool Equals(CGEFJAPLICJ EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x61AA600", Offset = "0x61A9400", VA = "0x1861AA600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x61ACCC0", Offset = "0x61ABAC0", VA = "0x1861ACCC0")]
	public bool JAEGHPCAKDE(BDPDEANOFFL FEOGIMKDFKL, bool ECLEEMGEGDM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x61AD170", Offset = "0x61ABF70", VA = "0x1861AD170")]
	public bool NGMICBEEOJF(BDPDEANOFFL BOCPDIPOGHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x61ACE80", Offset = "0x61ABC80", VA = "0x1861ACE80")]
	private void KBEKCEIGBEP(BDPDEANOFFL HFJPNNMGCLK, List<BDPDEANOFFL> EDCBPMKKFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x61ACA20", Offset = "0x61AB820", VA = "0x1861ACA20")]
	public ODHAMGOMGLD CMOGMPPHLPD()
	{
		return default(ODHAMGOMGLD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x61AD110", Offset = "0x61ABF10", VA = "0x1861AD110")]
	public void LFMPMDNHNAA(List<BDPDEANOFFL> EDGKJLLIHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x61AD210", Offset = "0x61AC010", VA = "0x1861AD210")]
	public NativeArray<EDLOHAABCGP> OICKGGPILOA()
	{
		return default(NativeArray<EDLOHAABCGP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct FKABDLMGJPE : IEquatable<FKABDLMGJPE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public BDPDEANOFFL JHNIBLNCHHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public string JHLBBBDKLCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x61AF8B0", Offset = "0x61AE6B0", VA = "0x1861AF8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public string BHKMNCNAOEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x61AFAB0", Offset = "0x61AE8B0", VA = "0x1861AFAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool BBKGOMDOCLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x61AF770", Offset = "0x61AE570", VA = "0x1861AF770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public string DIHKDGCPADO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x61AFB80", Offset = "0x61AE980", VA = "0x1861AFB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public string HECJCMKACPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x61AF520", Offset = "0x61AE320", VA = "0x1861AF520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public string DJLILJCGGCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x61AF9C0", Offset = "0x61AE7C0", VA = "0x1861AF9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0")]
	public FKABDLMGJPE(EDLOHAABCGP JNDMOGCGEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x61AF930", Offset = "0x61AE730", VA = "0x1861AF930", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "4")]
	public bool Equals(FKABDLMGJPE EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x61AA600", Offset = "0x61A9400", VA = "0x1861AA600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct DMMLGNLNLGP : IEquatable<DMMLGNLNLGP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public BDPDEANOFFL JHNIBLNCHHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x61AE560", Offset = "0x61AD360", VA = "0x1861AE560", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "4")]
	public bool Equals(DMMLGNLNLGP EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x61AA600", Offset = "0x61A9400", VA = "0x1861AA600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct NDCCLBLDEMN : IEquatable<NDCCLBLDEMN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public BDPDEANOFFL JHNIBLNCHHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0")]
	public NDCCLBLDEMN(EDLOHAABCGP JNDMOGCGEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x61B7750", Offset = "0x61B6550", VA = "0x1861B7750", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "4")]
	public bool Equals(NDCCLBLDEMN EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x61AA600", Offset = "0x61A9400", VA = "0x1861AA600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x61B75E0", Offset = "0x61B63E0", VA = "0x1861B75E0")]
	public bool AAGJIPNOMMN([Out] Collider CNCBABNOLDD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct AHHLKOPAEPA : IEquatable<AHHLKOPAEPA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public EDLOHAABCGP IJLCCNOBJGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(EDLOHAABCGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public BDPDEANOFFL JHNIBLNCHHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private PHAPBKDLMJL NMINOKIANBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x61AA160", Offset = "0x61A8F60", VA = "0x1861AA160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private CNJPGLLGDND PJNHMDDFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x61A9DF0", Offset = "0x61A8BF0", VA = "0x1861A9DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private ObjectPolicyDataWrapper ACNPMOEMNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x61A9C10", Offset = "0x61A8A10", VA = "0x1861A9C10")]
		get
		{
			return default(ObjectPolicyDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private NavMeshGenerationDataWrapper NJKEHGMHNCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x61A9760", Offset = "0x61A8560", VA = "0x1861A9760")]
		get
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool EIHCDPHJJEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x61A9AF0", Offset = "0x61A88F0", VA = "0x1861A9AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool NKFLBDAKDNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x61AA0F0", Offset = "0x61A8EF0", VA = "0x1861AA0F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool KJANDOLFKAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x61A95A0", Offset = "0x61A83A0", VA = "0x1861A95A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool KADFMDMKBEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x61A9EE0", Offset = "0x61A8CE0", VA = "0x1861A9EE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool OIGBJDEMKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x61A9CA0", Offset = "0x61A8AA0", VA = "0x1861A9CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool BBJJLGIEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x61A9680", Offset = "0x61A8480", VA = "0x1861A9680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool JGMMCMKKIMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x61A9B30", Offset = "0x61A8930", VA = "0x1861A9B30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool DKFNMOIFBPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x61A9BA0", Offset = "0x61A89A0", VA = "0x1861A9BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool LMAOJJMEBGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x61A9F50", Offset = "0x61A8D50", VA = "0x1861A9F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool AAAMLMJGNFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x61A9D80", Offset = "0x61A8B80", VA = "0x1861A9D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool NJJEHPMLMNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x61A9610", Offset = "0x61A8410", VA = "0x1861A9610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool FCIBDNNEELF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x61AA590", Offset = "0x61A9390", VA = "0x1861AA590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool FJOFEOCMNEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x61A96F0", Offset = "0x61A84F0", VA = "0x1861A96F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool EGOONOLPHHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x61AA220", Offset = "0x61A9020", VA = "0x1861AA220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool LIDLKNPNDIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x61AA1C0", Offset = "0x61A8FC0", VA = "0x1861AA1C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x61AA450", Offset = "0x61A9250", VA = "0x1861AA450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public EIKOJILMNLL DLJAAKGHFAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x61A9E80", Offset = "0x61A8C80", VA = "0x1861A9E80")]
		get
		{
			return default(EIKOJILMNLL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x61A9D10", Offset = "0x61A8B10", VA = "0x1861A9D10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool IKBBGOGMBAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x61AA280", Offset = "0x61A9080", VA = "0x1861AA280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public PLGEILLLIPO HEEMMAKGMMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x61AA530", Offset = "0x61A9330", VA = "0x1861AA530")]
		get
		{
			return default(PLGEILLLIPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool DIKFIKBJEAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x61A9A90", Offset = "0x61A8890", VA = "0x1861A9A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Vector3 JDMMBBBALOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x61A9830", Offset = "0x61A8630", VA = "0x1861A9830")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Vector3 JHGJLPCLHMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x61A9FC0", Offset = "0x61A8DC0", VA = "0x1861A9FC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool DNFADCLJBNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x61A98F0", Offset = "0x61A86F0", VA = "0x1861A98F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0")]
	public AHHLKOPAEPA(EDLOHAABCGP JNDMOGCGEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x61A9A00", Offset = "0x61A8800", VA = "0x1861A9A00", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "4")]
	public bool Equals(AHHLKOPAEPA EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x61AA600", Offset = "0x61A9400", VA = "0x1861AA600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x61AA4C0", Offset = "0x61A92C0", VA = "0x1861AA4C0")]
	public bool NNJDDJCJDJB(IGNLIIMLDGD BCCJNCFLBPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x61A97C0", Offset = "0x61A85C0", VA = "0x1861A97C0")]
	public bool ALDPAJNKGDB(PGDCJKHFMEC BCCJNCFLBPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x61AA070", Offset = "0x61A8E70", VA = "0x1861AA070")]
	public void LIAKOONKBEK(PGDCJKHFMEC BCCJNCFLBPH, bool MCFOJMEHHCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct GJNPBGJKHEA : IEquatable<GJNPBGJKHEA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public EDLOHAABCGP IJLCCNOBJGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(EDLOHAABCGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public BDPDEANOFFL JHNIBLNCHHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	private PHAPBKDLMJL NMINOKIANBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x61AA160", Offset = "0x61A8F60", VA = "0x1861AA160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private CNJPGLLGDND PJNHMDDFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x61B04D0", Offset = "0x61AF2D0", VA = "0x1861B04D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0")]
	public GJNPBGJKHEA(EDLOHAABCGP JNDMOGCGEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x61B0440", Offset = "0x61AF240", VA = "0x1861B0440", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "4")]
	public bool Equals(GJNPBGJKHEA EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x61AA600", Offset = "0x61A9400", VA = "0x1861AA600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x61B03B0", Offset = "0x61AF1B0", VA = "0x1861B03B0")]
	public void EAIKODAOBCN(bool MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x61B0560", Offset = "0x61AF360", VA = "0x1861B0560")]
	public void POGMFCABCIP(bool MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x2740760", Offset = "0x273F560", VA = "0x182740760")]
	public T PMLGPPGOJOC<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct MGNFBHLALIE : IEquatable<MGNFBHLALIE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public EDLOHAABCGP IJLCCNOBJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(EDLOHAABCGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public BDPDEANOFFL JHNIBLNCHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	private PHAPBKDLMJL NMINOKIANBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x61AA160", Offset = "0x61A8F60", VA = "0x1861AA160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private CNJPGLLGDND PJNHMDDFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x61B5C50", Offset = "0x61B4A50", VA = "0x1861B5C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private BMJIIOBAEEC DJLLEKGGFFN
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x61B5BF0", Offset = "0x61B49F0", VA = "0x1861B5BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	private NBIFDMECANL KGCAJHDHLKH
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x61B5A90", Offset = "0x61B4890", VA = "0x1861B5A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public bool EPCBODFLGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x61B6490", Offset = "0x61B5290", VA = "0x1861B6490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool NLGCLFBNBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x61B5CE0", Offset = "0x61B4AE0", VA = "0x1861B5CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool NJKJGLLNHJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x61B6520", Offset = "0x61B5320", VA = "0x1861B6520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool PKMBMCGCHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x61B5890", Offset = "0x61B4690", VA = "0x1861B5890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool KPPJMLFHOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x61B6460", Offset = "0x61B5260", VA = "0x1861B6460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public bool GDCLBODFMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x61B5A00", Offset = "0x61B4800", VA = "0x1861B5A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public bool HLOACAGLLLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x61B60A0", Offset = "0x61B4EA0", VA = "0x1861B60A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public bool OIFPNEHMJJI
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x61B5F30", Offset = "0x61B4D30", VA = "0x1861B5F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0")]
	public MGNFBHLALIE(EDLOHAABCGP JNDMOGCGEKD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x61AA860", Offset = "0x61A9660", VA = "0x1861AA860")]
	public static bool CCJKPBOFOJB(MGNFBHLALIE MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x61B5B60", Offset = "0x61B4960", VA = "0x1861B5B60", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "4")]
	public bool Equals(MGNFBHLALIE EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x61AA600", Offset = "0x61A9400", VA = "0x1861AA600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x61B5AF0", Offset = "0x61B48F0", VA = "0x1861B5AF0")]
	public bool EPKKCPBDFDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x61B5D80", Offset = "0x61B4B80", VA = "0x1861B5D80")]
	public BDPDEANOFFL JCPBICPPJBA(BDPDEANOFFL EOCODFIAJEL)
	{
		return default(BDPDEANOFFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x61B6350", Offset = "0x61B5150", VA = "0x1861B6350")]
	public EDLOHAABCGP MNNDAMNIBOG()
	{
		return default(EDLOHAABCGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x61B62B0", Offset = "0x61B50B0", VA = "0x1861B62B0")]
	public bool MIGGNHGGHMN(EDLOHAABCGP IKFMHCKACAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x61B5960", Offset = "0x61B4760", VA = "0x1861B5960")]
	public bool CFEPFDEFMHE(EDLOHAABCGP KEOGBBMKNFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x61B5E20", Offset = "0x61B4C20", VA = "0x1861B5E20")]
	public bool JFCLDKFEMNM(EDLOHAABCGP EOCODFIAJEL, [Out] EDLOHAABCGP IKFMHCKACAC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct CFMGCFCCPGI : IEquatable<CFMGCFCCPGI>
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly CFMGCFCCPGI FCOIJBMEOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public EDLOHAABCGP IJLCCNOBJGC
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(EDLOHAABCGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public BDPDEANOFFL JHNIBLNCHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public KHBCBIKOPJJ HJKOCBOHHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(KHBCBIKOPJJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private ShapeTypeDataWrapper MPEKKNHFBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x61AC390", Offset = "0x61AB190", VA = "0x1861AC390")]
		get
		{
			return default(ShapeTypeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public StandardRenderableVisualDataWrapper CJNLIBBELGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x61AC5C0", Offset = "0x61AB3C0", VA = "0x1861AC5C0")]
		get
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public PhysicsMaterialDataWrapper LCIKLNIJIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x61AC2D0", Offset = "0x61AB0D0", VA = "0x1861AC2D0")]
		get
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public ShapeConfigDataWrapper MNIIAMFCODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x61AC330", Offset = "0x61AB130", VA = "0x1861AC330")]
		get
		{
			return default(ShapeConfigDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public IAOPLFJAAKL BGCIKPBBOJL
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x61AC770", Offset = "0x61AB570", VA = "0x1861AC770")]
		get
		{
			return default(IAOPLFJAAKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public IJGADHLLDHP EPNBLEOPJED
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x61AC460", Offset = "0x61AB260", VA = "0x1861AC460")]
		get
		{
			return default(IJGADHLLDHP);
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x61AC880", Offset = "0x61AB680", VA = "0x1861AC880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public ONMMOGDAPLI IGFAMDADIGN
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x61AC710", Offset = "0x61AB510", VA = "0x1861AC710")]
		get
		{
			return default(ONMMOGDAPLI);
		}
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x61AC620", Offset = "0x61AB420", VA = "0x1861AC620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public float NGLOCHANFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x61AC1A0", Offset = "0x61AAFA0", VA = "0x1861AC1A0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x61AC260", Offset = "0x61AB060", VA = "0x1861AC260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public Vector3 EBCNOBDILHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x61AC8F0", Offset = "0x61AB6F0", VA = "0x1861AC8F0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x61AC7E0", Offset = "0x61AB5E0", VA = "0x1861AC7E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public float KGAOCEJCOHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x61AC3F0", Offset = "0x61AB1F0", VA = "0x1861AC3F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public GBJAGKOIPPB PPAAMLIHIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x61AC200", Offset = "0x61AB000", VA = "0x1861AC200")]
		get
		{
			return default(GBJAGKOIPPB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x61AC550", Offset = "0x61AB350", VA = "0x1861AC550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0")]
	public CFMGCFCCPGI(EDLOHAABCGP JNDMOGCGEKD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x61AA860", Offset = "0x61A9660", VA = "0x1861AA860")]
	public static bool CCJKPBOFOJB(CFMGCFCCPGI MAEBFBHFPDE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x61AA880", Offset = "0x61A9680", VA = "0x1861AA880")]
	public static bool CDMEFABOJMD(CFMGCFCCPGI AOHIFIJNOBB, CFMGCFCCPGI FNDBFMFAGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x61AC4C0", Offset = "0x61AB2C0", VA = "0x1861AC4C0", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "4")]
	public bool Equals(CFMGCFCCPGI EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x61AA600", Offset = "0x61A9400", VA = "0x1861AA600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x61AC120", Offset = "0x61AAF20", VA = "0x1861AC120")]
	public NGEBAAEDBKO AAFJGIAHKOD()
	{
		return default(NGEBAAEDBKO);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x61AC690", Offset = "0x61AB490", VA = "0x1861AC690")]
	public BHBCKKIJOAE KCJGEBGHMHI()
	{
		return default(BHBCKKIJOAE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct NGEBAAEDBKO : IEquatable<NGEBAAEDBKO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public EDLOHAABCGP IJLCCNOBJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(EDLOHAABCGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public BDPDEANOFFL JHNIBLNCHHG
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public CFMGCFCCPGI DDLFOHKMONN
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(CFMGCFCCPGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	private PrimitiveShapeDataWrapper FKAKFNGDNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x61B7BB0", Offset = "0x61B69B0", VA = "0x1861B7BB0")]
		get
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public JIBPCJADACN MHBKCPEEIBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x61B7C10", Offset = "0x61B6A10", VA = "0x1861B7C10")]
		get
		{
			return default(JIBPCJADACN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0")]
	public NGEBAAEDBKO(EDLOHAABCGP JNDMOGCGEKD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x61AA860", Offset = "0x61A9660", VA = "0x1861AA860")]
	public static bool CCJKPBOFOJB(NGEBAAEDBKO MAEBFBHFPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x61B7B20", Offset = "0x61B6920", VA = "0x1861B7B20", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "4")]
	public bool Equals(NGEBAAEDBKO EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x61AA600", Offset = "0x61A9400", VA = "0x1861AA600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[DefaultMember("Item")]
public readonly struct BHBCKKIJOAE : IEquatable<BHBCKKIJOAE>
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly BHBCKKIJOAE FCOIJBMEOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public EDLOHAABCGP IJLCCNOBJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(EDLOHAABCGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public BDPDEANOFFL JHNIBLNCHHG
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public KHBCBIKOPJJ HJKOCBOHHNL
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(KHBCBIKOPJJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	private PHAPBKDLMJL NMINOKIANBL
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x61AA160", Offset = "0x61A8F60", VA = "0x1861AA160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	private CNJPGLLGDND PJNHMDDFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x61ABDB0", Offset = "0x61AABB0", VA = "0x1861ABDB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	private IINIKNKDBNA BJJEBOGEAIL
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x61ABE40", Offset = "0x61AAC40", VA = "0x1861ABE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public CFMGCFCCPGI DDLFOHKMONN
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(CFMGCFCCPGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public FECIKOMCBBA NEPCOCPHHEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x61ABEA0", Offset = "0x61AACA0", VA = "0x1861ABEA0")]
		get
		{
			return default(FECIKOMCBBA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x61ABB80", Offset = "0x61AA980", VA = "0x1861ABB80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public IEnumerable<CMBHHLJFNGC> BJPDFEPHKGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x61AB400", Offset = "0x61AA200", VA = "0x1861AB400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public CMBHHLJFNGC GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x61ABCA0", Offset = "0x61AAAA0", VA = "0x1861ABCA0")]
		get
		{
			return default(CMBHHLJFNGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public int EDOFPONLMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x61AB6A0", Offset = "0x61AA4A0", VA = "0x1861AB6A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0")]
	public BHBCKKIJOAE(EDLOHAABCGP JNDMOGCGEKD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x61AA860", Offset = "0x61A9660", VA = "0x1861AA860")]
	public static bool CCJKPBOFOJB(BHBCKKIJOAE MAEBFBHFPDE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x61AAC10", Offset = "0x61A9A10", VA = "0x1861AAC10")]
	public static bool EILLJGMDDAM(BHBCKKIJOAE AOHIFIJNOBB, BHBCKKIJOAE FNDBFMFAGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x61AB610", Offset = "0x61AA410", VA = "0x1861AB610", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "4")]
	public bool Equals(BHBCKKIJOAE EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x61AA600", Offset = "0x61A9400", VA = "0x1861AA600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x61AB960", Offset = "0x61AA760", VA = "0x1861AB960")]
	public CMBHHLJFNGC GHCIFJGGKPO(float3? AJFNKFFNDBD, [Optional] quaternion? OKEJHHGCFPM, [Optional] Vector3? BJOKGACKCGO)
	{
		return default(CMBHHLJFNGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x61AB730", Offset = "0x61AA530", VA = "0x1861AB730")]
	public CMBHHLJFNGC FPKCONKHPOM(int OHINPGIGDNE, float3? AJFNKFFNDBD, [Optional] quaternion? OKEJHHGCFPM, [Optional] Vector3? BJOKGACKCGO)
	{
		return default(CMBHHLJFNGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x61AB2F0", Offset = "0x61AA0F0", VA = "0x1861AB2F0")]
	public void ALFONFPACHD(int OHINPGIGDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x61ABFD0", Offset = "0x61AADD0", VA = "0x1861ABFD0")]
	public void OCIHDBDLDKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct CMBHHLJFNGC : IEquatable<CMBHHLJFNGC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public EDLOHAABCGP IJLCCNOBJGC
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(EDLOHAABCGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public BDPDEANOFFL JHNIBLNCHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public BHBCKKIJOAE IGILGHECGIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x61AE020", Offset = "0x61ACE20", VA = "0x1861AE020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public float3 IECMJKODHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x61AE1A0", Offset = "0x61ACFA0", VA = "0x1861AE1A0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x61ADEA0", Offset = "0x61ACCA0", VA = "0x1861ADEA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public quaternion GACOHGOGNDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x61AE280", Offset = "0x61AD080", VA = "0x1861AE280")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x61AE360", Offset = "0x61AD160", VA = "0x1861AE360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public float3 CGPPFEIOGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x61ADFA0", Offset = "0x61ACDA0", VA = "0x1861ADFA0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x61ADF20", Offset = "0x61ACD20", VA = "0x1861ADF20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public KJBEJFJOMFJ IHCNNOGKCHA
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x61ADE30", Offset = "0x61ACC30", VA = "0x1861ADE30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	private SplinePointParentDataWrapper EHDBJCFDNJL
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x61AE0B0", Offset = "0x61ACEB0", VA = "0x1861AE0B0")]
		get
		{
			return default(SplinePointParentDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	private SplinePointPositionDataWrapper LNALMGJABLA
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x61AE220", Offset = "0x61AD020", VA = "0x1861AE220")]
		get
		{
			return default(SplinePointPositionDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	private SplinePointRotationDataWrapper BMGEACPLCOK
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x61AE3D0", Offset = "0x61AD1D0", VA = "0x1861AE3D0")]
		get
		{
			return default(SplinePointRotationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	private SplinePointScaleDataWrapper PBGGJCCFPAI
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x61ADDD0", Offset = "0x61ACBD0", VA = "0x1861ADDD0")]
		get
		{
			return default(SplinePointScaleDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	private SplinePointOrderDataWrapper EIBLIBHPOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x61AE300", Offset = "0x61AD100", VA = "0x1861AE300")]
		get
		{
			return default(SplinePointOrderDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0")]
	public CMBHHLJFNGC(EDLOHAABCGP JNDMOGCGEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x61AE110", Offset = "0x61ACF10", VA = "0x1861AE110", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "4")]
	public bool Equals(CMBHHLJFNGC EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x61AA600", Offset = "0x61A9400", VA = "0x1861AA600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x61AE020", Offset = "0x61ACE20", VA = "0x1861AE020")]
	public void BODIJHDCIHP(BHBCKKIJOAE MAEBFBHFPDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct KHBCBIKOPJJ : IEquatable<KHBCBIKOPJJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public BDPDEANOFFL JHNIBLNCHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public CGEFJAPLICJ PDPEJBHJGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(CGEFJAPLICJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	private PHAPBKDLMJL NMINOKIANBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x61AA160", Offset = "0x61A8F60", VA = "0x1861AA160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	private HKDMEIKNPPL DGCNNBKHGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x61B2F00", Offset = "0x61B1D00", VA = "0x1861B2F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool ECLFJGFGCEC
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x61B3550", Offset = "0x61B2350", VA = "0x1861B3550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public Vector3 IECMJKODHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x61B3EF0", Offset = "0x61B2CF0", VA = "0x1861B3EF0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x61B29E0", Offset = "0x61B17E0", VA = "0x1861B29E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public Quaternion GACOHGOGNDB
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x61B41A0", Offset = "0x61B2FA0", VA = "0x1861B41A0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x61B4C00", Offset = "0x61B3A00", VA = "0x1861B4C00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Vector3 FMPGPGNHBKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x61B3680", Offset = "0x61B2480", VA = "0x1861B3680")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x61B3B50", Offset = "0x61B2950", VA = "0x1861B3B50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Quaternion NAMNFFMILMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x61B3DA0", Offset = "0x61B2BA0", VA = "0x1861B3DA0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x61B3220", Offset = "0x61B2020", VA = "0x1861B3220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public float ELCMGEHFOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x61B4970", Offset = "0x61B3770", VA = "0x1861B4970")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x61B46F0", Offset = "0x61B34F0", VA = "0x1861B46F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public float OJOPHILOEDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x61B30B0", Offset = "0x61B1EB0", VA = "0x1861B30B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public Vector3 CGPPFEIOGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x61B2C50", Offset = "0x61B1A50", VA = "0x1861B2C50")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x61B2AB0", Offset = "0x61B18B0", VA = "0x1861B2AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Vector3 LDOCIKOKIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x61B2E10", Offset = "0x61B1C10", VA = "0x1861B2E10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Matrix4x4 BHJOGGCOBED
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x61B32F0", Offset = "0x61B20F0", VA = "0x1861B32F0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0")]
	public KHBCBIKOPJJ(EDLOHAABCGP JNDMOGCGEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x61B3420", Offset = "0x61B2220", VA = "0x1861B3420", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "4")]
	public bool Equals(KHBCBIKOPJJ EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x61AA600", Offset = "0x61A9400", VA = "0x1861AA600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x61B4920", Offset = "0x61B3720", VA = "0x1861B4920")]
	public BHIFHHDNGPJ OMPOKELDMCH()
	{
		return default(BHIFHHDNGPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x61B4AE0", Offset = "0x61B38E0", VA = "0x1861B4AE0")]
	public void PDKJCMLABFF([Out] Matrix4x4 GCBICDLKKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x61B4390", Offset = "0x61B3190", VA = "0x1861B4390")]
	public void LNMFNOEJNDK([Out] Vector3 DBFKHJIDPAD, [Out] Quaternion GDGMDKOAPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x61B3860", Offset = "0x61B2660", VA = "0x1861B3860")]
	public void GDEEKNGADDA([Out] RigidTransform EIFCBMGNMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x61B3830", Offset = "0x61B2630", VA = "0x1861B3830")]
	public GDAMDHJKEHO GDAABOEKOOJ()
	{
		return default(GDAMDHJKEHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x61B3770", Offset = "0x61B2570", VA = "0x1861B3770")]
	public void GDAABOEKOOJ([Out] GDAMDHJKEHO FOOAJIBMKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x61B2FC0", Offset = "0x61B1DC0", VA = "0x1861B2FC0")]
	public GDAMDHJKEHO CNOMNOMHJGO()
	{
		return default(GDAMDHJKEHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x61B2FF0", Offset = "0x61B1DF0", VA = "0x1861B2FF0")]
	public void CNOMNOMHJGO([Out] GDAMDHJKEHO EIFCBMGNMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x61B3590", Offset = "0x61B2390", VA = "0x1861B3590")]
	public Vector3 FKPPMNPCKAJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x61B2B80", Offset = "0x61B1980", VA = "0x1861B2B80")]
	public void BADGPOKACJL([In] Vector3 MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x61B3330", Offset = "0x61B2130", VA = "0x1861B3330")]
	public Vector3 EFCECKEDPHG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x61B3150", Offset = "0x61B1F50", VA = "0x1861B3150")]
	public void DNBAGGMMDFJ([In] Vector3 MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x61B3910", Offset = "0x61B2710", VA = "0x1861B3910")]
	public Quaternion HCMKINOEMHD()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x61B40D0", Offset = "0x61B2ED0", VA = "0x1861B40D0")]
	public void JNJMPCLFMLE([In] Quaternion MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x61B45A0", Offset = "0x61B33A0", VA = "0x1861B45A0")]
	public Quaternion NFNGGIPECAL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x61B3CD0", Offset = "0x61B2AD0", VA = "0x1861B3CD0")]
	public void IIOKKINLLCJ([In] Quaternion MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x61B34B0", Offset = "0x61B22B0", VA = "0x1861B34B0")]
	public float FFDGCPOCBNO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x61B47A0", Offset = "0x61B35A0", VA = "0x1861B47A0")]
	public void NNEKEIKEJLA(float MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x61B42F0", Offset = "0x61B30F0", VA = "0x1861B42F0")]
	public float LDBPKDEMCBJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x61B3C20", Offset = "0x61B2A20", VA = "0x1861B3C20")]
	public void IHKCOJPAOGN(float MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x61B2D40", Offset = "0x61B1B40", VA = "0x1861B2D40")]
	public void BNBFPMCBEJA([In] Vector3 MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x61B4CD0", Offset = "0x61B3AD0", VA = "0x1861B4CD0")]
	public Vector3 PKEOGJCKHPK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x61B44D0", Offset = "0x61B32D0", VA = "0x1861B44D0")]
	public void MNCDJCCCGOL([In] Vector3 MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x61B3A60", Offset = "0x61B2860", VA = "0x1861B3A60")]
	public Vector3 HOOOLOJABPN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x61B4850", Offset = "0x61B3650", VA = "0x1861B4850")]
	public void OGENNDKIOBG([In] Vector3 MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x61B3FE0", Offset = "0x61B2DE0", VA = "0x1861B3FE0")]
	public Vector3 JLPCJBBOMAE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x61B4A10", Offset = "0x61B3810", VA = "0x1861B4A10")]
	public void PDIBIMCFIMH([In] Vector3 MAEBFBHFPDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct HIDEHMBJFOL : IEquatable<HIDEHMBJFOL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly EDLOHAABCGP PDDIPEOJCBN;

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public EDLOHAABCGP IJLCCNOBJGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(EDLOHAABCGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public BDPDEANOFFL JHNIBLNCHHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
		get
		{
			return default(BDPDEANOFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public int[] EAFPHMPHACJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x61B0B70", Offset = "0x61AF970", VA = "0x1861B0B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool ABPKGCALCAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x61B0B10", Offset = "0x61AF910", VA = "0x1861B0B10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x61B0CF0", Offset = "0x61AFAF0", VA = "0x1861B0CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0")]
	public HIDEHMBJFOL(EDLOHAABCGP JNDMOGCGEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x61A9C70", Offset = "0x61A8A70", VA = "0x1861A9C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x61B0C60", Offset = "0x61AFA60", VA = "0x1861B0C60", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x61A99F0", Offset = "0x61A87F0", VA = "0x1861A99F0", Slot = "4")]
	public bool Equals(HIDEHMBJFOL EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x61AA600", Offset = "0x61A9400", VA = "0x1861AA600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class HHCBDDHBKFD
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct OJJHJGCOGFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid MAAFBDMNKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AEOEKFLILPN OGJLANNNJFN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct AEOEKFLILPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int MAEBFBHFPDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int OAMHNBBJJBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int EBGBHADEHPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int BGHKMHGEGMH;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x61A9480", Offset = "0x61A8280", VA = "0x1861A9480")]
		public bool DJLGFPICLMO([Out] HDKJDIEIILD OMOAAJHFJOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x61A9500", Offset = "0x61A8300", VA = "0x1861A9500")]
		public AEOEKFLILPN(HDKJDIEIILD OMOAAJHFJOC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x61B0A60", Offset = "0x61AF860", VA = "0x1861B0A60")]
	public static Guid JONPMKEMEMA(this HDKJDIEIILD OMOAAJHFJOC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x61B0AF0", Offset = "0x61AF8F0", VA = "0x1861B0AF0")]
	public static bool MNNGILONPPA(this Guid MAAFBDMNKAP, [Out] HDKJDIEIILD OMOAAJHFJOC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal static class FCNGAIBFLHN
{
	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x61AF490", Offset = "0x61AE290", VA = "0x1861AF490")]
	public static CNJPGLLGDND PJNHMDDFHEM(this EDLOHAABCGP FJIJLBIGEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x61AF3C0", Offset = "0x61AE1C0", VA = "0x1861AF3C0")]
	public static MJLGOJBIBDC OLEHJOPCMEA(this EDLOHAABCGP FJIJLBIGEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x61AF2C0", Offset = "0x61AE0C0", VA = "0x1861AF2C0")]
	public static EntityManager BFMJGNLOKCH(this EDLOHAABCGP FJIJLBIGEAH)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2730A10", Offset = "0x272F810", VA = "0x182730A10")]
	public static T MMDJOOGEDLE<T>(this EDLOHAABCGP FJIJLBIGEAH) where T : struct, DPHHBGHMKAH
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x27306A0", Offset = "0x272F4A0", VA = "0x1827306A0")]
	public static bool LKLONBAOEOL<T>(this EDLOHAABCGP FJIJLBIGEAH) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x27305F0", Offset = "0x272F3F0", VA = "0x1827305F0")]
	public static bool KGKIOACLAHG<T>(this EDLOHAABCGP FJIJLBIGEAH) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface LGGJBFLLBEI
{
	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JBIIAPOGPJI(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MBAJDLAIJNO(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CLFONMADHKE(EDLOHAABCGP JNDMOGCGEKD, [Out] Guid APHIOIJKKOI);

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid DBFCGPJHFKO(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FCIEPBEHHCI(EDLOHAABCGP JNDMOGCGEKD, Guid APHIOIJKKOI);

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PGNFDHFCHOE(EDLOHAABCGP JNDMOGCGEKD, [Out] Guid GOOFHOHFPNL);

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid GJCDEGKLPFH(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FILMOJGDIPF(EDLOHAABCGP JNDMOGCGEKD, Guid GOOFHOHFPNL);

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FKCFMAFFEAE(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task AECAMPCGGCE(EDLOHAABCGP ENAIIHBGJMJ, EDLOHAABCGP FEOGIMKDFKL);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[MIDGHOOAONL(AOJPFHDMMJA.LoadInstance)]
public interface JGFPIMOJJEL
{
	[Cpp2IlInjected.Token(Token = "0x17000122")]
	Guid IBBBBBPFJAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJKJAJJGJBG(NativeList<Guid> HBOJHFOIOFL, NativeList<Guid> GCJLCDCMFEE, NativeList<FixedString64Bytes> BLFJHOOOGDI);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface IMHCOMBEGHK
{
	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAIDHLKPENM(List<EDLOHAABCGP> JDKPJKFNDHL);

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LHKBFKBHFDA(EDLOHAABCGP BLCFDMELOLF);

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IHDOEIDCLDB(EDLOHAABCGP BLCFDMELOLF);

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int BFCCELHLHHN(EDLOHAABCGP BLCFDMELOLF);

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OMBADENHAAC(EDLOHAABCGP BLCFDMELOLF, int GNMODFEIMHL);

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EDLOHAABCGP AJOFCABDLKJ(EDLOHAABCGP GOKBHJMEHPA);

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NPNEBHHPNEL(EDLOHAABCGP GOKBHJMEHPA, EDLOHAABCGP JMFOOALNOJB);

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LGGKNBBJGHO(EDLOHAABCGP GOKBHJMEHPA);

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BBMPLFOMDDK(EDLOHAABCGP PDDIPEOJCBN);

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KJNILGGINGH(EDLOHAABCGP JNDMOGCGEKD, bool NEICBIEGKLA);

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BJIMNEIPDMC(EDLOHAABCGP[] HGFILCPIOJP, bool NEICBIEGKLA);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface GODACKEHHPK
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	IReadOnlyCollection<KDEBEHMICDF> NBEPILANCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GBINMMCJGPK(int CEAMMMGHHMC, [Out] KDEBEHMICDF LPAICFACMCK);

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KDEBEHMICDF GFPGHFKJKDK(Type LPFFKBBBCBL);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class FHLKEJOMECI
{
	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2734070", Offset = "0x2732E70", VA = "0x182734070")]
	public static T KOBAFAJMPKG<T>(this GODACKEHHPK AOMPCCHJIKM, Entity JLCPBIBMCCJ) where T : struct, DPHHBGHMKAH
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2733410", Offset = "0x2732210", VA = "0x182733410")]
	public static KDEBEHMICDF GFPGHFKJKDK<T>(this GODACKEHHPK AOMPCCHJIKM) where T : struct, DPHHBGHMKAH
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface HMBANFNGHAP
{
	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HDKJDIEIILD[] GNCBKJDMDMI(string OCCHBLONHPL, BDPDEANOFFL CEIPNICNPMH, bool GEMILFLMMFK = false);

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOBIDKEIGBO(string KIFNKLCLPNA, HDKJDIEIILD[] FLKHMJMMFBD);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[MIDGHOOAONL(AOJPFHDMMJA.LoadInstance)]
public interface MPJMFOACMEE
{
	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<EDLOHAABCGP, EDLOHAABCGP> ICHLEJPDHBD;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<EDLOHAABCGP, EDLOHAABCGP> EHCJJLMAEJB;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<EDLOHAABCGP, EDLOHAABCGP, EDLOHAABCGP> HMHBLGICBEB;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<EDLOHAABCGP> KCBJHAKCDIB;

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EMEJBBHDPJH(EDLOHAABCGP JNDMOGCGEKD, EDLOHAABCGP IKOENJKOHID);

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EDLOHAABCGP KFELPFDIBPD(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<EDLOHAABCGP> GPKNLMNBFAB(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	EDLOHAABCGP JMCHHCKCLFN(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CNGLDPJMBFD(EDLOHAABCGP JNDMOGCGEKD, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM);

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GNDGBCFLAEP(EDLOHAABCGP JNDMOGCGEKD, float LHLKKEFCLAM);

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool GNMBLLFBAKO(EDLOHAABCGP JNDMOGCGEKD, [Out] RigidTransform BAHGKNOCDHE);

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool LKPHANLCFLO(EDLOHAABCGP JNDMOGCGEKD, [Out] float KJNJMOKEMML);

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 KKHLCIBPBIE(JMJPADAEJCH NCAANLDCONA);

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion PBGMCDCHGLD(JMJPADAEJCH NCAANLDCONA);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class FLBAAPBPBON
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[MIDGHOOAONL(AOJPFHDMMJA.LoadInstance)]
public interface BPKMPCKCHJF
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	object HDAHMOJPBEO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGHHECEFBMO(GFADIHGLLAF HGFILCPIOJP);
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum OLFAGMDNEOA
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class KCNPHDGGAHF
{
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0xBC60E0", Offset = "0xBC4EE0", VA = "0x180BC60E0")]
	public static bool GONNNNOPPOG(this OLFAGMDNEOA OHBBLINCHPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0xBC6230", Offset = "0xBC5030", VA = "0x180BC6230")]
	public static bool AFPBDKCOEFP(this OLFAGMDNEOA OHBBLINCHPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x2219A30", Offset = "0x2218830", VA = "0x182219A30")]
	public static bool DFJONGIGPME(this OLFAGMDNEOA OHBBLINCHPH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface EDJJPNKBJMK
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	OLFAGMDNEOA JJEDKOOPFBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	OLFAGMDNEOA BBNPKJNPACJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	OLFAGMDNEOA MAIDNGBLMAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	OLFAGMDNEOA LOCLECIGPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	OLFAGMDNEOA JNEIMEPHMBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	OLFAGMDNEOA KOIECJLHBJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	OLFAGMDNEOA MFJIEPPLGAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	OLFAGMDNEOA KAPBMHGJCJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	OLFAGMDNEOA CDCMDJECLIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	OLFAGMDNEOA AFKKDFBCFJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	OLFAGMDNEOA DOEELAEJIMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	OLFAGMDNEOA CBHPIAPGPOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	OLFAGMDNEOA PBELODIBNBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface OEMIHPOHKKB
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<EKHDEJLFGJL> LDMJPPGHKKI;

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EDLOHAABCGP EJADAJAKMCE(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PEHHCHIBCFK(List<EDLOHAABCGP> JDKPJKFNDHL);

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EDLOHAABCGP DBIPMIJHFHH(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JAEGHPCAKDE(EDLOHAABCGP JNDMOGCGEKD, EDLOHAABCGP FEOGIMKDFKL, bool ECLEEMGEGDM);

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PLJLNBHEPJD(EDLOHAABCGP JNDMOGCGEKD, EDLOHAABCGP FEOGIMKDFKL);

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int DGEHMIEDAGH(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GFADIHGLLAF ABEMFIECPGK(EDLOHAABCGP PDDIPEOJCBN);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NativeArray<EDLOHAABCGP> OICKGGPILOA(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool HKLNOBOJJMI(EDLOHAABCGP JNDMOGCGEKD, EDLOHAABCGP JJJBHPFLCCG);

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NGMICBEEOJF(EDLOHAABCGP JNDMOGCGEKD, EDLOHAABCGP BOCPDIPOGHC);

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(Slot = "12")]
	EDLOHAABCGP HGNAFPNKJEL(EDLOHAABCGP EOCODFIAJEL, EDLOHAABCGP MFOGMJOMFDJ);

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool IFMPCFDGFIJ(EDLOHAABCGP EOCODFIAJEL, EDLOHAABCGP MFOGMJOMFDJ, [Out] EDLOHAABCGP MKCGPILAIEF);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class MEIELJACFGO
{
	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x61B5780", Offset = "0x61B4580", VA = "0x1861B5780")]
	public static List<EDLOHAABCGP> PEHHCHIBCFK(this OEMIHPOHKKB ECOODAPNMOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[MIDGHOOAONL(AOJPFHDMMJA.LoadInstance)]
public interface PICHMNBEPIH
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	bool EGMEKEOJILC
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	bool CNPMHICCGMD
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface MBGEGJFIPDA : JJGLPAHNIOJ
{
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CKACCHIBEGG(Entity JLCPBIBMCCJ, [Out] DJACFHNCPCG PDCBMAPDAEE);

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPHEJNKDKKC(NativeArray<DJACFHNCPCG> CMHKEDIBOOI, NativeArray<AGCPGMFAAPP> FDKGJFKELIK);

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FPGIJKIIFGF(DJACFHNCPCG PDCBMAPDAEE);

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EAIGFEABKHP(DJACFHNCPCG PDCBMAPDAEE, [Out] Collider CNCBABNOLDD);
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[MIDGHOOAONL(AOJPFHDMMJA.LoadInstance)]
public interface JJGLPAHNIOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HCMGPAJKACC([In] float3 CDHDMAIICDB, [In] float3 JMFPDJFKFGP, float CCDDMHMFCJA, Allocator ALDDPOOJFGI, [Out] NativeArray<Entity> ILPEGPIDHBI);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[MIDGHOOAONL(AOJPFHDMMJA.LoadInstance)]
public interface ANAIAOKBNDP
{
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HCMGPAJKACC([In] float3 CDHDMAIICDB, [In] float3 JMFPDJFKFGP, float CCDDMHMFCJA, [Out] FOIDFKFDKLN MEMBLPAFCDL, [Out] EDLOHAABCGP MKOPNCBCKGG);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[MIDGHOOAONL(AOJPFHDMMJA.LoadInstance)]
public interface KAEOIHOACJA
{
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HCMGPAJKACC([In] NativeArray<Entity> ILPEGPIDHBI, [In] float3 CDHDMAIICDB, [In] float3 JMFPDJFKFGP, [In] NativeArray<FOIDFKFDKLN> HCFOGPOOJKH);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct DJACFHNCPCG : LHOPFFBIOKG, IEquatable<DJACFHNCPCG>
{
	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public int LNBHMBDGGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8EAFA0", Offset = "0x8E9DA0", VA = "0x1808EAFA0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8EAF70", Offset = "0x8E9D70", VA = "0x1808EAF70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public int HPLABGPNINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x22396B0", Offset = "0x22384B0", VA = "0x1822396B0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x5534DA0", Offset = "0x5533BA0", VA = "0x185534DA0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x61AE4C0", Offset = "0x61AD2C0", VA = "0x1861AE4C0", Slot = "8")]
	public bool Equals(DJACFHNCPCG EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x61AE510", Offset = "0x61AD310", VA = "0x1861AE510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct FOIDFKFDKLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float JLPKLILLGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float3 BKELBBDDNIG;
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface GMNPFBJGEHE
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface PHAPBKDLMJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000136")]
	CNJPGLLGDND PJNHMDDFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	MHMIGGGDJPE DCJMIPHPGIN
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<GFADIHGLLAF, NativeArray<HLKLEDFOFOB>> NJFJGKBHHPC;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<GFADIHGLLAF> KNNDLPBLECF;

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GKBGKNFOJCD GDPOIKMBFIJ(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HLKLEDFOFOB MAEDKJNOOIA(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GGPDGFKFIKF(HDKJDIEIILD OMOAAJHFJOC, JOKHLKLBCEJ GCKKDDOBMIK);

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BFEIICEINEE(HDKJDIEIILD[] FLKHMJMMFBD, GameObject EAPMMKKAJGJ);

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BDPDEANOFFL FEDDIEBAKEJ(EDLOHAABCGP JNDMOGCGEKD, [Optional] object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool HACMFKMBCOC(EDLOHAABCGP JNDMOGCGEKD, [Out] JOKHLKLBCEJ GCKKDDOBMIK);

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool LEBEGMFFEMA(EDLOHAABCGP JNDMOGCGEKD, [Out] Transform NBCGMJPEDEM);

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool CMIFOPFAHBG(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JIDNCPGCLCN(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool PENGGLAKNPC(LocalId JNDMOGCGEKD, object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool OMNHLAGPFJL(LocalId JNDMOGCGEKD, object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	EDLOHAABCGP OFKNBKICKDH(HDKJDIEIILD OMOAAJHFJOC);

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool EKOKABHBCLP(HDKJDIEIILD OMOAAJHFJOC, [Out] EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	HDKJDIEIILD NKHHFODBLCO(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	GFADIHGLLAF OFKNBKICKDH(NativeArray<HDKJDIEIILD> OMOAAJHFJOC, Allocator ALDDPOOJFGI);

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	GFADIHGLLAF GDIKAGJIPJN(HLKLEDFOFOB HCBFDEJPHHJ, int DPKFLHPPNCH, Allocator ALDDPOOJFGI);

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	GFADIHGLLAF KPNMJIEAHJE(NativeArray<HDKJDIEIILD> OMOAAJHFJOC, NativeArray<PBLJCPDHEDJ> OCKDMIEFPJC, Allocator ALDDPOOJFGI);

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "23")]
	HDKJDIEIILD[] GNCBKJDMDMI(string KIFNKLCLPNA, BDPDEANOFFL CEIPNICNPMH, bool GEMILFLMMFK);

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DOBIDKEIGBO(string KIFNKLCLPNA, HDKJDIEIILD[] FLKHMJMMFBD);

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(Slot = "25")]
	BDPDEANOFFL KEFFFEKIHJJ(HLKLEDFOFOB HCBFDEJPHHJ, bool IBNGEIADACK);

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(Slot = "26")]
	BDPDEANOFFL KEFFFEKIHJJ(HLKLEDFOFOB HCBFDEJPHHJ);

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "27")]
	BDPDEANOFFL OLCDIPJFIIC(HLKLEDFOFOB HCBFDEJPHHJ);

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(Slot = "28")]
	BDPDEANOFFL OCMCOCKAKCM(HLKLEDFOFOB HCBFDEJPHHJ);

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(Slot = "29")]
	BDPDEANOFFL KPNMJIEAHJE(HDKJDIEIILD OMOAAJHFJOC, HLKLEDFOFOB HCBFDEJPHHJ);

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(Slot = "30")]
	ODHAMGOMGLD IAJBLMGFBAK();

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(Slot = "31")]
	BHBCKKIJOAE BJEEHJOPHEG();

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(Slot = "32")]
	NGEBAAEDBKO POIJABGCAKG(JIBPCJADACN PNPNNKGAMOG);

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void COBKLJAOBIM(GFADIHGLLAF HGFILCPIOJP);

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void COJAMHJFIEG(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void LNKMDGLCGLE(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void COBKLJAOBIM(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(Slot = "37")]
	GFADIHGLLAF JLOIFDEPGJL(GFADIHGLLAF DHLOMDDBNPL, Allocator ALDDPOOJFGI);

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool LBIFEOPNNOK(EDLOHAABCGP JNDMOGCGEKD);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class HJMAKNENOIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x61B1400", Offset = "0x61B0200", VA = "0x1861B1400")]
	public static void JIDNCPGCLCN(this PHAPBKDLMJL FLJPOIKHIID, JOKHLKLBCEJ GCKKDDOBMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x61B1700", Offset = "0x61B0500", VA = "0x1861B1700")]
	public static BDPDEANOFFL KDOLCKCLEOM(this PHAPBKDLMJL FLJPOIKHIID, LocalId JNDMOGCGEKD)
	{
		return default(BDPDEANOFFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x61B16A0", Offset = "0x61B04A0", VA = "0x1861B16A0")]
	public static BDPDEANOFFL KDOLCKCLEOM(this PHAPBKDLMJL FLJPOIKHIID, HDKJDIEIILD OMOAAJHFJOC)
	{
		return default(BDPDEANOFFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x61B1700", Offset = "0x61B0500", VA = "0x1861B1700")]
	public static EDLOHAABCGP OFKNBKICKDH(this PHAPBKDLMJL FLJPOIKHIID, LocalId JNDMOGCGEKD)
	{
		return default(EDLOHAABCGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x61B17A0", Offset = "0x61B05A0", VA = "0x1861B17A0")]
	public static HDKJDIEIILD NKHHFODBLCO(this PHAPBKDLMJL FLJPOIKHIID, LocalId JNDMOGCGEKD)
	{
		return default(HDKJDIEIILD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x61B1730", Offset = "0x61B0530", VA = "0x1861B1730")]
	public static bool LBIFEOPNNOK(this PHAPBKDLMJL FLJPOIKHIID, HDKJDIEIILD OMOAAJHFJOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x2766AA0", Offset = "0x27658A0", VA = "0x182766AA0")]
	public static T NHODFIKMJMH<T>(this PHAPBKDLMJL FLJPOIKHIID, LocalId JNDMOGCGEKD) where T : struct, DPHHBGHMKAH
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x61B1300", Offset = "0x61B0100", VA = "0x1861B1300")]
	public static ODHAMGOMGLD IPHFDNHDBPC(this PHAPBKDLMJL FLJPOIKHIID, RigidTransform FOOAJIBMKOO, [Optional] object BNAJMHPOOCG)
	{
		return default(ODHAMGOMGLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x61B11F0", Offset = "0x61AFFF0", VA = "0x1861B11F0")]
	public static NGEBAAEDBKO EFGDGFKJIGB(this PHAPBKDLMJL FLJPOIKHIID, JIBPCJADACN EKMMGLFCDAL, RigidTransform FOOAJIBMKOO, [Optional] object BNAJMHPOOCG)
	{
		return default(NGEBAAEDBKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x61B10F0", Offset = "0x61AFEF0", VA = "0x1861B10F0")]
	public static BHBCKKIJOAE BBCDNJMKOHH(this PHAPBKDLMJL FLJPOIKHIID, RigidTransform FOOAJIBMKOO, [Optional] object BNAJMHPOOCG)
	{
		return default(BHBCKKIJOAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x61B1480", Offset = "0x61B0280", VA = "0x1861B1480")]
	private static void JOMGGNCKIPK(BDPDEANOFFL IOLDGPCINLE, RigidTransform FOOAJIBMKOO, [Optional] object BNAJMHPOOCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[MIDGHOOAONL(AOJPFHDMMJA.LoadInstance)]
public interface BMJIIOBAEEC
{
	[Cpp2IlInjected.Token(Token = "0x17000138")]
	bool PFPFPMGEFPN
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	EDLOHAABCGP KBLEOFAMBAA
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	BDPDEANOFFL KCHBGGDOOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event ECHLCDIMLOI ODPAHDLLLLK;

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EDLOHAABCGP HGNAFPNKJEL(EDLOHAABCGP EOCODFIAJEL, EDLOHAABCGP MFOGMJOMFDJ);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IFMPCFDGFIJ(EDLOHAABCGP EOCODFIAJEL, EDLOHAABCGP MFOGMJOMFDJ, [Out] EDLOHAABCGP MKCGPILAIEF);

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HIHOGMDDJEK();

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FJNOCBINIJJ();

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool EPCBODFLGAJ(EDLOHAABCGP EOCODFIAJEL);

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GDCLBODFMPJ(EDLOHAABCGP EOCODFIAJEL);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public delegate void ECHLCDIMLOI(BDPDEANOFFL HHPKIPAGDBA, BDPDEANOFFL JINLKNBONEA);
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class IMCLHAGOMOL
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x61B1B90", Offset = "0x61B0990", VA = "0x1861B1B90")]
	public static bool ADADIJOKMFP(this BMJIIOBAEEC HOONJEGLBCM, BDPDEANOFFL EOCODFIAJEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x61B1BE0", Offset = "0x61B09E0", VA = "0x1861B1BE0")]
	public static bool DOMNKAAPKKI(this BMJIIOBAEEC HOONJEGLBCM, EDLOHAABCGP EOCODFIAJEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x61B1CC0", Offset = "0x61B0AC0", VA = "0x1861B1CC0")]
	public static bool PKMBMCGCHJB(this BMJIIOBAEEC HOONJEGLBCM, EDLOHAABCGP EOCODFIAJEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface ICOEBDGHACD
{
	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DHNPHALJODI(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JCIDNBBMGIK(EDLOHAABCGP JNDMOGCGEKD, Transform NBCGMJPEDEM);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface NBIFDMECANL
{
	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MIGGNHGGHMN(EDLOHAABCGP EOCODFIAJEL, EDLOHAABCGP IKFMHCKACAC);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CFEPFDEFMHE(EDLOHAABCGP EOCODFIAJEL, EDLOHAABCGP KEOGBBMKNFO);

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JFCLDKFEMNM(EDLOHAABCGP EOCODFIAJEL, [Out] EDLOHAABCGP MOMGIJAOAJD);
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[MIDGHOOAONL(AOJPFHDMMJA.LoadInstance)]
public interface GEEBBBDCLIM
{
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EAIKODAOBCN(EDLOHAABCGP PDDIPEOJCBN, bool MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void POGMFCABCIP(EDLOHAABCGP PDDIPEOJCBN, bool MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NLLNHJEHMKB(EDLOHAABCGP PDDIPEOJCBN, int MAEBFBHFPDE);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[MIDGHOOAONL(AOJPFHDMMJA.LoadInstance)]
public interface IINIKNKDBNA
{
	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<EDLOHAABCGP> LDBBDNHAMHH(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EDLOHAABCGP AIPCDNPNGMB(EDLOHAABCGP JNDMOGCGEKD, int OHINPGIGDNE);

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int KAFMFILBEBC(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FECIKOMCBBA EFOBCGJHOCF(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FLDKLGAFDHN(EDLOHAABCGP JNDMOGCGEKD, FECIKOMCBBA JCKJBGDNIAO);

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EDLOHAABCGP KHJAINAJOCJ(EDLOHAABCGP JNDMOGCGEKD, [Optional] float3? AJFNKFFNDBD, [Optional] quaternion? OKEJHHGCFPM, [Optional] float3? BJOKGACKCGO);

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EDLOHAABCGP INAHPBKLLMD(EDLOHAABCGP JNDMOGCGEKD, int OHINPGIGDNE, [Optional] float3? AJFNKFFNDBD, [Optional] quaternion? OKEJHHGCFPM, [Optional] float3? BJOKGACKCGO);

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CAEEDPNOFGC(EDLOHAABCGP JNDMOGCGEKD, int OHINPGIGDNE);

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GEAFICPLJOP(EDLOHAABCGP JNDMOGCGEKD);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface LABNBBGELEB
{
	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FEJCMGDKLKP();

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMCMGNNGJBI();

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AGABLLKAKHF();

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IGDDHPODFLI();

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HPJOGOMADGI();

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NBPNFMANLCD();

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EFOMAKIHCLP();

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DHDGCHKCJBA();

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KCIGINCGLBC();

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ICNLJIDBFPO();

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CJAKIKJMIMP();
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface HKDMEIKNPPL
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JAHMLEONPOG(Entity JLCPBIBMCCJ);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BADGPOKACJL(Entity JLCPBIBMCCJ, [In] float3 MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 FKPPMNPCKAJ(Entity JLCPBIBMCCJ);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JNJMPCLFMLE(Entity JLCPBIBMCCJ, [In] quaternion MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion HCMKINOEMHD(Entity JLCPBIBMCCJ);

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LNMFNOEJNDK(Entity JLCPBIBMCCJ, [Out] float3 AJFNKFFNDBD, [Out] quaternion OKEJHHGCFPM);

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LNMFNOEJNDK(Entity JLCPBIBMCCJ, [Out] RigidTransform JHPHLKDHHKF);

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GDEEKNGADDA(Entity JLCPBIBMCCJ, [Out] RigidTransform JHPHLKDHHKF);

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 DACKBPGBJPF(Entity JLCPBIBMCCJ);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BNBFPMCBEJA(Entity JLCPBIBMCCJ, [In] float3 MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NNEKEIKEJLA(Entity JLCPBIBMCCJ, float MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float FFDGCPOCBNO(Entity JLCPBIBMCCJ);

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OGENNDKIOBG(Entity JLCPBIBMCCJ, [In] float3 MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 HOOOLOJABPN(Entity JLCPBIBMCCJ);

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DNBAGGMMDFJ(Entity JLCPBIBMCCJ, [In] float3 MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 EFCECKEDPHG(Entity JLCPBIBMCCJ);

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IIOKKINLLCJ(Entity JLCPBIBMCCJ, [In] quaternion MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion NFNGGIPECAL(Entity JLCPBIBMCCJ);

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 PKEOGJCKHPK(Entity JLCPBIBMCCJ);

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void MNCDJCCCGOL(Entity JLCPBIBMCCJ, [In] float3 MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void IHKCOJPAOGN(Entity JLCPBIBMCCJ, float MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float LDBPKDEMCBJ(Entity JLCPBIBMCCJ);

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PDIBIMCFIMH(Entity JLCPBIBMCCJ, [In] float3 MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 JLPCJBBOMAE(Entity JLCPBIBMCCJ);

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FMDOGPDFCAK(Entity JLCPBIBMCCJ, [Out] float4x4 GCBICDLKKHL);

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void ADMJOOLFEBL(Entity JLCPBIBMCCJ, [In] float4x4 GCBICDLKKHL);

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void KMGONPMAJCM(Entity JLCPBIBMCCJ, [Out] float4x4 GCBICDLKKHL);

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool LEBEGMFFEMA(Entity JLCPBIBMCCJ, [Out] Transform NBCGMJPEDEM);

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void PGIKHHAJHEJ(Entity JLCPBIBMCCJ);

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void AMGBODDADOG(Entity JLCPBIBMCCJ, Entity IEFGCLIDDAI, Entity EIECDKIPGGN);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class MNKMGGKBLEK
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface MJCLBGGEFBE
{
	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World NHILOBBPBLN(string IPMLLKCPKNE = "Main");

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World FGIDONNKGAF(string IPMLLKCPKNE = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World MJBANIBDMMH(string IPMLLKCPKNE = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World LNDMBEOILAP(string IPMLLKCPKNE = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface MJLGOJBIBDC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	World KMPAKLIKHEI
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	World KIIPMCEDIDB
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	EntityManager BFMJGNLOKCH
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	bool KMJOLKOJMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase EJLPMMIFEPA(Type LPFFKBBBCBL);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public static class IFINBFIKDEI
{
	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x61B1B00", Offset = "0x61B0900", VA = "0x1861B1B00")]
	public static ComponentSystemBase KIJEBJAIGCH(this World LHBLFLHHEGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x2782A20", Offset = "0x2781820", VA = "0x182782A20")]
	public static T EJLPMMIFEPA<T>(this MJLGOJBIBDC FGOLONIJKOF) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[MIDGHOOAONL(AOJPFHDMMJA.LoadInstance)]
public interface FDBBCHJOAAE
{
	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANEJFAHPEHN(NativeListAsync<Entity> PHCKAGBONON);

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void COBDINHAKJN(GOPKCCMOPLH JICDFJGNHDO);

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KMADBJPMODF(NativeListAsync<Entity> OGMODCOCKEI, bool FMFLLLDNIJI);

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AGJEPICKDAK();
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[MIDGHOOAONL(AOJPFHDMMJA.LoadInstance)]
public interface IHHJLGJOPGF
{
	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MADEAAHHGPF(Collider CNCBABNOLDD, [Out] KNMBPKAMPMH CDJAAIPJGPN);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[MIDGHOOAONL(AOJPFHDMMJA.LoadInstance)]
public interface FMIEFMDIELM
{
	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KNCFHLCGNHM(EDLOHAABCGP JNDMOGCGEKD, [Out] Collider CNCBABNOLDD);

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject HDDKPFPBDBB(EDLOHAABCGP MJGONKNBIBP, GameObject EMCJEOKFHFJ, Vector3 ABJLHEFAGHP, Quaternion NGMKKHFPKEG);

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BLOCIFENLEA(GameObject CNCBABNOLDD);

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider EOBEEPHEMNN<TCollider>(GameObject EMJALEALGBN) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NOPKAIOKBEB(Collider CNCBABNOLDD);

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject KJENFBFIEHP<TCollider>(string OCCHBLONHPL) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[MIDGHOOAONL(AOJPFHDMMJA.LoadInstance)]
public interface KDIEFHDFIHD
{
	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BCMHEECGGMK(EDLOHAABCGP JNDMOGCGEKD, CPFCINEGKPG NAOLNKKFNPO, bool FPPHPEGJLHC, PNFLHPNKBIO BKLJNEEEJOC);

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGECEHKACFD(EDLOHAABCGP JNDMOGCGEKD, CPFCINEGKPG NAOLNKKFNPO, bool FPPHPEGJLHC, bool GGONLGGMLDI, bool GNMIABGCJAC);

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NCKDHGJMLJF HMKONJNJPMF(EDLOHAABCGP GOKLEGFJHEB, List<EDLOHAABCGP> MOCPPECJEAN);

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MKAJCABDDOF(GameObject FEPPONLDDNF, GameObject MBHCFLIEPHK);

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MDHOICGDMOE(GameObject MBHCFLIEPHK);

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T EOBEEPHEMNN<T>(GameObject EMJALEALGBN) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NOPKAIOKBEB(Collider CNCBABNOLDD);

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject LIGJBCNKAME<T>(string OCCHBLONHPL) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NPPHFGIMPGM(Collider CNCBABNOLDD, [Out] EDLOHAABCGP CMIMEIFNPKJ);

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool DEKCLDKJIBA(EDLOHAABCGP JNDMOGCGEKD, [Out] KNMBPKAMPMH CDJAAIPJGPN);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[MIDGHOOAONL(AOJPFHDMMJA.LoadInstance)]
public interface FLCMMALDFNG
{
	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KLFOENIEJBM(EDLOHAABCGP JNDMOGCGEKD, EBHOAKANDLL MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EBHOAKANDLL JGHJNDLLOHC(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JLFICOCDFDA(EDLOHAABCGP JNDMOGCGEKD, EDLOHAABCGP MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FEONMMPMKDG(EDLOHAABCGP JNDMOGCGEKD, EDLOHAABCGP MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int DGEHMIEDAGH(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EDLOHAABCGP KLFGBHCIOIB(EDLOHAABCGP JNDMOGCGEKD, int OHINPGIGDNE);

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GMNCFLMHDGK(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HONKJNIKENM(EDLOHAABCGP JNDMOGCGEKD, object BNAJMHPOOCG, EDLOHAABCGP MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JCCPGIIGJBM(EDLOHAABCGP JNDMOGCGEKD, object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool KKAFOLGAGEF(EDLOHAABCGP JNDMOGCGEKD, [Out] EDLOHAABCGP MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DBKNHLBNFPF(EDLOHAABCGP JNDMOGCGEKD, float3 MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FILIMIKHPOI(EDLOHAABCGP JNDMOGCGEKD, [Out] float3 MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OMFONKJAAEA(EDLOHAABCGP JNDMOGCGEKD, float3 MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool IMJILHJMGHO(EDLOHAABCGP JNDMOGCGEKD, [Out] float3 MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CDAPFOJMLGA(EDLOHAABCGP JNDMOGCGEKD, (Quaternion rot, Vector3 moments) LOPDMLFNDEJ);

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool JNCBODBLNFA(EDLOHAABCGP JNDMOGCGEKD, [Out] quaternion POGHNPIKNGB, [Out] float3 PAEBLJMACPJ);

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CAJFIGMFLMH(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EJBBIPHJAFH(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 KJCMFHIBDEP(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 LMIBPHHNKIF(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NJPGLJENNJL(EDLOHAABCGP JNDMOGCGEKD, float3 MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void LGJIJNPKHMI(EDLOHAABCGP JNDMOGCGEKD, float3 MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float GCPFELINCBJ(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float BCKBHAJJFGB(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CDPGMHEHDAO(EDLOHAABCGP JNDMOGCGEKD, float MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void HDHPEGEGOKF(EDLOHAABCGP JNDMOGCGEKD, float MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CollisionDetectionMode PBONCNCOLFJ(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void IKBNPBGKGJA(EDLOHAABCGP JNDMOGCGEKD, CollisionDetectionMode MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "28")]
	BBFONOIEIIB PFMFMEEHEKN(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void ALNBKKKBFPM(EDLOHAABCGP JNDMOGCGEKD, BBFONOIEIIB MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool INGJCCNFLHH(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void HKELMJPJANB(EDLOHAABCGP JNDMOGCGEKD, bool MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "32")]
	EDLOHAABCGP EJADAJAKMCE(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void ABPBFPBAJPM(EDLOHAABCGP JNDMOGCGEKD, EDLOHAABCGP MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "34")]
	EDLOHAABCGP DBIPMIJHFHH(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void JAEGHPCAKDE(EDLOHAABCGP JNDMOGCGEKD, EDLOHAABCGP MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "36")]
	JDKPCKNKNHD MJNDLJDPLFM(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void DFPLDOFOBPA(EDLOHAABCGP JNDMOGCGEKD, JDKPCKNKNHD FGCJPOAPAMO);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool IMKHKJGKEID(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void JMHBNBKACCA(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool EKHNNNDKEGA(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void LGKKKDBLPLB(EDLOHAABCGP JNDMOGCGEKD, bool MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool OHFNFAAAIBK(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void KOJJGIEICJD(EDLOHAABCGP JNDMOGCGEKD, bool MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "44")]
	RigidbodyConstraints ACKHJNELIND(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void GLJDNCEEMFH(EDLOHAABCGP JNDMOGCGEKD, RigidbodyConstraints MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "46")]
	float GDKJICNABAH(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void PFCODMLINLI(EDLOHAABCGP JNDMOGCGEKD, float MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float GCKECJKNLLN(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void PEEKFCCHPMJ(EDLOHAABCGP JNDMOGCGEKD, float MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool OPDJEJBGJFH(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void CJCGHPKEHOJ(EDLOHAABCGP JNDMOGCGEKD, bool MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool HDLAODDDJDO(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void KHIKMNCLAMP(EDLOHAABCGP JNDMOGCGEKD, bool MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void IELLNJMCFKG(EDLOHAABCGP JNDMOGCGEKD, int MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "55")]
	object GLKLBADPPEK(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void KHJDNDKCMKL(EDLOHAABCGP JNDMOGCGEKD, object MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "57")]
	object CGJEFPBFLIO(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void IPANKIMAKFI(EDLOHAABCGP JNDMOGCGEKD, object MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "59")]
	float KHFACALDMKA(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void LNAMPMODJNM(EDLOHAABCGP JNDMOGCGEKD, float MAEBFBHFPDE);

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void DBEDFACAIED(EDLOHAABCGP JNDMOGCGEKD, object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void BFPIKKIOJLK(EDLOHAABCGP JNDMOGCGEKD, object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "63")]
	bool AHENEOGIAHE(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void MGHFNJLMBIO(EDLOHAABCGP JNDMOGCGEKD, object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void CHPNAKJJEHH(EDLOHAABCGP JNDMOGCGEKD, object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "66")]
	bool IBAMBLEPENF(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool IOEHINLICNC(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Rigidbody OGNKAKIJLJC(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void AOICIAKDBEM(EDLOHAABCGP JNDMOGCGEKD, Rigidbody BNKGAHAACAL);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void BLKPLNMNING(EDLOHAABCGP JNDMOGCGEKD, object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void JFPFGCEJILE(EDLOHAABCGP JNDMOGCGEKD, object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool LNOAPHJNHNH(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void KAKPDGKAEHJ(EDLOHAABCGP JNDMOGCGEKD, float3 HEHJKNMAHHJ);

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void DIDGOJCNMCH(EDLOHAABCGP JNDMOGCGEKD, float3 BCFCIEMLLAJ);

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "75")]
	bool MJJEDBGEAGJ(EDLOHAABCGP JNDMOGCGEKD, [Out] float3 HEHJKNMAHHJ);

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool OFNKMGLGIOB(EDLOHAABCGP JNDMOGCGEKD, [Out] float3 BCFCIEMLLAJ);

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool MHNIFJEJFKF(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void EOJGIGEKLBI(EDLOHAABCGP JNDMOGCGEKD, object BNAJMHPOOCG, bool FBNCDEJLKGB);

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "79")]
	void GEICIIGJIPN(EDLOHAABCGP JNDMOGCGEKD, bool LNCFDCAEMOP);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void ODMNMPLNMII(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool LJCOGIFPGDN(EDLOHAABCGP JNDMOGCGEKD);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[MIDGHOOAONL(AOJPFHDMMJA.LoadInstance)]
public interface MNLLKBFCAPO
{
	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	bool KMJOLKOJMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GPDOAPNPIAC(EDLOHAABCGP JNDMOGCGEKD);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MPPLJOHKILN(EDLOHAABCGP JNDMOGCGEKD, bool FPPHPEGJLHC, bool GGONLGGMLDI, bool BEFGMEEOGNP);

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PDANOBCNBIH(EDLOHAABCGP JNDMOGCGEKD, float3 IBOFICAFDGP);

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IJPPEPBIGNG(EDLOHAABCGP JNDMOGCGEKD, float3 IBOFICAFDGP);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[MIDGHOOAONL(AOJPFHDMMJA.LoadInstance)]
public interface DEHAHPMJENE
{
	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEAKFMCCADE(Entity PEPPDLOIHMG);

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IMLNNMACKAN(Entity PEPPDLOIHMG);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public delegate void NEBJCPHDJHD(CEPPKANNFGC IGCLJCPKHKN);
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct CEPPKANNFGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly GFADIHGLLAF AENMMNJGJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly NativeArray<byte> ILMCAINDAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly NativeArray<byte> JCLDAPCPAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly IMDOBBINGKI CMJOIMNALBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly int JCFMCAKHMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Type LFKKKBOGDHA;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public GFADIHGLLAF DOBGBNMKKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x3613C10", Offset = "0x3612A10", VA = "0x183613C10")]
		get
		{
			return default(GFADIHGLLAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x61AC0B0", Offset = "0x61AAEB0", VA = "0x1861AC0B0")]
	public CEPPKANNFGC(GFADIHGLLAF AENMMNJGJKL, NativeArray<byte> ILMCAINDAOO, NativeArray<byte> JCLDAPCPAFC, IMDOBBINGKI CMJOIMNALBN, int JCFMCAKHMLK, Type LFKKKBOGDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x258F8A0", Offset = "0x258E6A0", VA = "0x18258F8A0")]
	public NativeArray<T> EIDCNIMPEII<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x258F9D0", Offset = "0x258E7D0", VA = "0x18258F9D0")]
	public NativeArray<T> NMEBNMFGBPL<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x258F8E0", Offset = "0x258E6E0", VA = "0x18258F8E0")]
	public (GFADIHGLLAF, NativeArray<T>, NativeArray<T>) MHEOMGMBJHC<T>() where T : struct
	{
		return default((GFADIHGLLAF, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x61AC060", Offset = "0x61AAE60", VA = "0x1861AC060")]
	public EKHDEJLFGJL IILKODHMKGL()
	{
		return default(EKHDEJLFGJL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface GCINKINGHLE
{
	[Cpp2IlInjected.Token(Token = "0x17000141")]
	string OHMCBNHBACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	GCINKINGHLE EFPNMOOLLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	IEnumerable<GCINKINGHLE> ILNAAJPPDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[MIDGHOOAONL(AOJPFHDMMJA.LoadInstance)]
public interface PDGGHCEOJCF
{
	[Cpp2IlInjected.Token(Token = "0x17000144")]
	GCINKINGHLE FPBFPCAGCAE
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	List<OBINNBHLFEA> AGJGPJMJDMG
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IMHOGGGFHGL(OBINNBHLFEA EIJAJNKHLMI, [Out] GCINKINGHLE APONKBIHAIO);

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GGPDGFKFIKF(OBINNBHLFEA EIJAJNKHLMI, NEBJCPHDJHD JCMKHOOIFHJ);

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AHELJNGPOGN(OBINNBHLFEA EIJAJNKHLMI, NEBJCPHDJHD JCMKHOOIFHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public readonly struct EKHDEJLFGJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly CEPPKANNFGC EEDANCJJEPL;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public GFADIHGLLAF DOBGBNMKKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x3613C10", Offset = "0x3612A10", VA = "0x183613C10")]
		get
		{
			return default(GFADIHGLLAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x61AF200", Offset = "0x61AE000", VA = "0x1861AF200")]
	public EKHDEJLFGJL(CEPPKANNFGC EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x61AEF40", Offset = "0x61ADD40", VA = "0x1861AEF40")]
	public GFADIHGLLAF EIDCNIMPEII()
	{
		return default(GFADIHGLLAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x61AF130", Offset = "0x61ADF30", VA = "0x1861AF130")]
	public GFADIHGLLAF NMEBNMFGBPL()
	{
		return default(GFADIHGLLAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x61AF010", Offset = "0x61ADE10", VA = "0x1861AF010")]
	public (GFADIHGLLAF, GFADIHGLLAF, GFADIHGLLAF) MHEOMGMBJHC()
	{
		return default((GFADIHGLLAF, GFADIHGLLAF, GFADIHGLLAF));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
[DefaultMember("Item")]
public interface EABGEJHLGBP : IEnumerable<DMMAAODJPCL>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000147")]
	NativeBitArray MGDHPMDIAOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	NativeArray<int> JOPKODKFGLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	int EDOFPONLMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	DMMAAODJPCL GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	DMMAAODJPCL GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DMMAAODJPCL KAMLHPMEAIC(NJMJEOJGOHE AOPFLAFGCLL);

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IMDOBBINGKI CJGCOMDHBOO(NJMJEOJGOHE AOPFLAFGCLL);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class GCEELHOBCGJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[DefaultMember("Item")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface LCLIKLPBKHC : IEnumerable<BAEAOFOABIN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	int EDOFPONLMHN
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	BAEAOFOABIN GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BAEAOFOABIN KAMLHPMEAIC(NJMJEOJGOHE AOPFLAFGCLL);

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IMDOBBINGKI CJGCOMDHBOO(NJMJEOJGOHE AOPFLAFGCLL);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class AKFLFNABOHF
{
	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x2D005A0", Offset = "0x2CFF3A0", VA = "0x182D005A0")]
	public static IMDOBBINGKI CJGCOMDHBOO<T>(this LCLIKLPBKHC IPHKNHPFNEF, MENBIMFAEDP<T> OCCHBLONHPL) where T : struct
	{
		return default(IMDOBBINGKI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[DefaultMember("Item")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface ELKCBIFHJJL : IEnumerable<OBINNBHLFEA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	int EDOFPONLMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	OBINNBHLFEA GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OBINNBHLFEA KAMLHPMEAIC(NJMJEOJGOHE AOPFLAFGCLL);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IMDOBBINGKI CJGCOMDHBOO(NJMJEOJGOHE AOPFLAFGCLL);
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class LKCIGGNACLE
{
	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x27F7A10", Offset = "0x27F6810", VA = "0x1827F7A10")]
	public static GLEEEICICAM<T> KAMLHPMEAIC<T>(this ELKCBIFHJJL IPHKNHPFNEF, NJMJEOJGOHE OCCHBLONHPL) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x27F7910", Offset = "0x27F6710", VA = "0x1827F7910")]
	public static IMDOBBINGKI CJGCOMDHBOO<T>(this ELKCBIFHJJL IPHKNHPFNEF, MENBIMFAEDP<T> OCCHBLONHPL) where T : struct
	{
		return default(IMDOBBINGKI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[MIDGHOOAONL(AOJPFHDMMJA.LoadInstance)]
public interface HJABEOOCBAM
{
	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGPDGFKFIKF(NJMJEOJGOHE EIJAJNKHLMI, NEBJCPHDJHD JCMKHOOIFHJ);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AHELJNGPOGN(NJMJEOJGOHE EIJAJNKHLMI, NEBJCPHDJHD JCMKHOOIFHJ);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class MJELOIPDKLP
{
	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x2811F80", Offset = "0x2810D80", VA = "0x182811F80")]
	public static void GGPDGFKFIKF<T>(this HJABEOOCBAM CKIHFBFKLLB, MENBIMFAEDP<T> EIJAJNKHLMI, NEBJCPHDJHD JCMKHOOIFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x2811D60", Offset = "0x2810B60", VA = "0x182811D60")]
	public static void AHELJNGPOGN<T>(this HJABEOOCBAM CKIHFBFKLLB, MENBIMFAEDP<T> EIJAJNKHLMI, NEBJCPHDJHD JCMKHOOIFHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface BODOOEBKECD
{
	[Cpp2IlInjected.Token(Token = "0x17000150")]
	HGHMBPPAAHO LIAOJFFNPAI
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOGPIINKJOH(HDKJDIEIILD OMOAAJHFJOC, IMDOBBINGKI EIJAJNKHLMI);

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMFGBFAPFKP(HDKJDIEIILD OMOAAJHFJOC, Span<IMDOBBINGKI> IPHKNHPFNEF, bool OJBONJDIJDK);

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void APCIEGFFGNA(NativeArray<HDKJDIEIILD> FLKHMJMMFBD);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class NELLDLBBAGC
{
	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x61B79C0", Offset = "0x61B67C0", VA = "0x1861B79C0")]
	public static void DMFGBFAPFKP(this BODOOEBKECD IDDCGLJOEFN, HDKJDIEIILD OMOAAJHFJOC, IMDOBBINGKI EIJAJNKHLMI, bool OJBONJDIJDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public readonly struct HGHMBPPAAHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly NativeBitArray EIECMFBBBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly NativeParallelHashMap<HDKJDIEIILD, int> OLHOIEANDOO;

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool DINCJKDOFJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x61B09B0", Offset = "0x61AF7B0", VA = "0x1861B09B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0xBC5670", Offset = "0xBC4470", VA = "0x180BC5670")]
	public HGHMBPPAAHO(NativeBitArray EIECMFBBBJF, NativeParallelHashMap<HDKJDIEIILD, int> OLHOIEANDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x61B0880", Offset = "0x61AF680", VA = "0x1861B0880")]
	public bool DOGPIINKJOH(HDKJDIEIILD OMOAAJHFJOC, IMDOBBINGKI EIJAJNKHLMI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[MIDGHOOAONL(AOJPFHDMMJA.LoadInstance)]
public interface LJBEJGGFAHL
{
	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DAIHPCHBEKP(EDLOHAABCGP JNDMOGCGEKD, KJKFIABCCFG MAEBFBHFPDE);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface EBKLGDOLBPP
{
	[Cpp2IlInjected.Token(Token = "0x17000152")]
	DPIIANELJKL KHOJPEPNNCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface PBLHGHBFCOL
{
	[Cpp2IlInjected.Token(Token = "0x17000153")]
	Type AFOMJPEGEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[MIDGHOOAONL(AOJPFHDMMJA.LoadInstance)]
public interface APJFANKAAAL
{
	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FBFFMHONPAI(EDLOHAABCGP PDDIPEOJCBN, bool MAEBFBHFPDE);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public readonly struct JHHPACLLINJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly IEnumerable<OHEJNFIAMDB> OLMKAOHHLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly IReadOnlyList<GameObject> IMAGHHLCJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly IReadOnlyList<int> JEOHBFKEJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly IReadOnlyList<(HDKJDIEIILD, HDKJDIEIILD)> IPACCMPNGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly int AMMJGMELFDA;

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool ADIMDPHMPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x61B2320", Offset = "0x61B1120", VA = "0x1861B2320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public int PPKFOPMJAFL
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x91FAD0", Offset = "0x91E8D0", VA = "0x18091FAD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public IEnumerable<GameObject> DNNBDKODDAP
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x8E9730", Offset = "0x8E8530", VA = "0x1808E9730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public IEnumerable<(HDKJDIEIILD src, HDKJDIEIILD dst)> BEGNBGDECOL
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x61B2380", Offset = "0x61B1180", VA = "0x1861B2380")]
	public JHHPACLLINJ(IEnumerable<OHEJNFIAMDB> OLMKAOHHLBL, IReadOnlyList<GameObject> IMAGHHLCJCN, IReadOnlyList<int> JEOHBFKEJDN, IReadOnlyList<(HDKJDIEIILD src, HDKJDIEIILD dst)> IPACCMPNGBF, int AMMJGMELFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x61B1F90", Offset = "0x61B0D90", VA = "0x1861B1F90")]
	public (GameObject, int)[] KJLEOKBCMKE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface INHDMKDODNB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000158")]
	bool CCCHAGLMDEP
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	bool ECGILLBLHDI
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	HBEEBKBNPKB HHGAMLNCMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FEIBNCJFNEB CJECHPPNFBC();

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FEIBNCJFNEB IHOEKEHMAJC(IEnumerable<EDLOHAABCGP> HGFILCPIOJP, [In] GDAMDHJKEHO IFOGNEDKFAI);

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GMOKKKFAJOK FCMOLHCLDPD(ByteString CCCPCCDHFLF);

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EJONMPBMKID EFMIBECIIFK(ByteString HLMOCJJFAAD, EDLOHAABCGP FEOGIMKDFKL, [In] GDAMDHJKEHO OFGDKCPCLEH, GCGLPPDNOHG KADEBMHHHLP, bool HIMLOOAKKPG = true);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LDNBIIAPDLJ();

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JHHPACLLINJ FKCJBEKLOOE(IEnumerable<OHEJNFIAMDB> OLMKAOHHLBL);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class OCNMAELNGFH
{
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface ICHEKGJBEKE
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action JHDFDEFFCEG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action IGAMOGFFFOD;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct PBLJCPDHEDJ : DKBGDGLBDGP, IEquatable<PBLJCPDHEDJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public HLKLEDFOFOB HCBFDEJPHHJ;

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x61BA310", Offset = "0x61B9110", VA = "0x1861BA310", Slot = "5")]
	public void APHAODHFANA(IINBKFKJJKB INLIFCPEGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x61BA340", Offset = "0x61B9140", VA = "0x1861BA340", Slot = "4")]
	public void CDDFPMJNNJO(ENIJCOAGKMD FCAJMDOFLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x61BA3F0", Offset = "0x61B91F0", VA = "0x1861BA3F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x86D940", Offset = "0x86C740", VA = "0x18086D940", Slot = "6")]
	public bool Equals(PBLJCPDHEDJ EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x61BA370", Offset = "0x61B9170", VA = "0x1861BA370", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x8EAFA0", Offset = "0x8E9DA0", VA = "0x1808EAFA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct HDKJDIEIILD : IComparable<HDKJDIEIILD>, IEquatable<HDKJDIEIILD>, DKBGDGLBDGP
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public const uint GMFOAOHDNCI = 0u;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public const uint MDPEABIBONI = 255u;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static readonly HDKJDIEIILD LCPFPBICDEC;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private const int JCMODHGMMME = 24;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private const uint IAPKNDFJNKM = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private const int PNHNCBGNLJL = 8;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private const uint JCFOMGDJIIK = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly uint HCFBAPHHICF;

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public uint DCEONGCPFHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x810F90", Offset = "0x80FD90", VA = "0x180810F90")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public uint CIONEDGAKHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x61B07D0", Offset = "0x61AF5D0", VA = "0x1861B07D0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public uint GPNCEMPCBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x8EAFA0", Offset = "0x8E9DA0", VA = "0x1808EAFA0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public bool ADIMDPHMPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x61347B0", Offset = "0x61335B0", VA = "0x1861347B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0xD7D620", Offset = "0xD7C420", VA = "0x180D7D620")]
	public static HDKJDIEIILD KOAIMGCNPAM(uint HCFBAPHHICF)
	{
		return default(HDKJDIEIILD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x61B0870", Offset = "0x61AF670", VA = "0x1861B0870")]
	public HDKJDIEIILD(int IOPOPAOOEHC, int CEGGGJOFKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x61B0870", Offset = "0x61AF670", VA = "0x1861B0870")]
	public HDKJDIEIILD(uint IOPOPAOOEHC, int CEGGGJOFKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x61B0870", Offset = "0x61AF670", VA = "0x1861B0870")]
	public HDKJDIEIILD(uint IOPOPAOOEHC, uint CEGGGJOFKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x8EAF70", Offset = "0x8E9D70", VA = "0x1808EAF70")]
	private HDKJDIEIILD(uint HCFBAPHHICF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x1802CA0", Offset = "0x1801AA0", VA = "0x181802CA0")]
	public static bool EILLJGMDDAM(HDKJDIEIILD AOHIFIJNOBB, HDKJDIEIILD FNDBFMFAGPH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x61B0740", Offset = "0x61AF540", VA = "0x1861B0740")]
	public static bool CDMEFABOJMD(HDKJDIEIILD AOHIFIJNOBB, HDKJDIEIILD FNDBFMFAGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x86D940", Offset = "0x86C740", VA = "0x18086D940", Slot = "5")]
	public bool Equals(HDKJDIEIILD FJIJLBIGEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x61B0750", Offset = "0x61AF550", VA = "0x1861B0750", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x2219940", Offset = "0x2218740", VA = "0x182219940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x61B07E0", Offset = "0x61AF5E0", VA = "0x1861B07E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x61B06E0", Offset = "0x61AF4E0", VA = "0x1861B06E0", Slot = "6")]
	public void CDDFPMJNNJO(ENIJCOAGKMD FCAJMDOFLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x61B0680", Offset = "0x61AF480", VA = "0x1861B0680", Slot = "7")]
	public void APHAODHFANA(IINBKFKJJKB INLIFCPEGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x60E3AB0", Offset = "0x60E28B0", VA = "0x1860E3AB0", Slot = "4")]
	public int CompareTo(HDKJDIEIILD EDOEJIMPOFP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct OHEJNFIAMDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Guid MAAFBDMNKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public string KIFNKLCLPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Vector3 AJFNKFFNDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Quaternion OKEJHHGCFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Vector3 BJOKGACKCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int GIPBFDDJNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Dictionary<string, object> JCKJBGDNIAO;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x61B9DC0", Offset = "0x61B8BC0", VA = "0x1861B9DC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x61B9C30", Offset = "0x61B8A30", VA = "0x1861B9C30")]
	private static string JMAOOIONEKL(Dictionary<string, object> EADPBADKEBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public enum ACCKFNPIBPK
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	World,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class FAAFNBKABHG
{
	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x566C9F0", Offset = "0x566B7F0", VA = "0x18566C9F0")]
	public static bool OEBLOJHCOPC(this ACCKFNPIBPK LPFFKBBBCBL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[Flags]
public enum AHGHGIBMFJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	WorldPhasesMaster = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	AdditivePhases = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface EJONMPBMKID : HBEEBKBNPKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	GCGLPPDNOHG AFJNDKDLDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJJEGALGDPB();

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IIIOOJNJEEP();
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface HBEEBKBNPKB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000160")]
	IEnumerable<OHEJNFIAMDB> CPCJBMJIEAA
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	JHHPACLLINJ JICBOALNDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	LocalId IMOPBMMLEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	DMFKMIFLJFF HCFGNFHPDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GEDDKJPLAEM(AHGHGIBMFJJ FFBLLANINJK);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public interface GCGLPPDNOHG
{
	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MBNHIGGBBEM(Guid MCFKOLILEBF, [Out] Guid LBGOLPFMFDA);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public interface GMOKKKFAJOK : HBEEBKBNPKB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[Flags]
public enum NDKAKPCCKKE
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public interface FEIBNCJFNEB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000164")]
	DMFKMIFLJFF KALJAMJAHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString LGLJFHBJEDJ();
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public enum MJHGPGIPHFF
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public delegate bool JDPKFEPIDEL(PGBPOHCBHMF JFHDPDDFFBD, [In] EKPKCANCJLO MAEBFBHFPDE);
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public delegate bool HNNDONHGKOF<T>(PGBPOHCBHMF JFHDPDDFFBD, [In] T MAEBFBHFPDE);
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface PCDKDDOKPEP
{
	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGPDGFKFIKF(IMDOBBINGKI CMJOIMNALBN, Type DKOBIJJLPPC, JDPKFEPIDEL FEPMHFPNIHJ);

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IAJAJEPHOKD(IMDOBBINGKI CMJOIMNALBN, [Out] JDPKFEPIDEL FEPMHFPNIHJ);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class HOJHKLKBBLO
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class EGBJGMJPLKH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public HNNDONHGKOF<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public EGBJGMJPLKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x32957B0", Offset = "0x32945B0", VA = "0x1832957B0")]
		internal bool BOGDDFBIHJO(PGBPOHCBHMF pendingList, [In] EKPKCANCJLO value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x27711D0", Offset = "0x276FFD0", VA = "0x1827711D0")]
	public static void GGPDGFKFIKF<T>(this PCDKDDOKPEP CKIHFBFKLLB, IMDOBBINGKI CMJOIMNALBN, HNNDONHGKOF<T> FEPMHFPNIHJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x61B19F0", Offset = "0x61B07F0", VA = "0x1861B19F0")]
	public static bool ILAELNHAGGC(this PCDKDDOKPEP CKIHFBFKLLB, PGBPOHCBHMF JFHDPDDFFBD, IMDOBBINGKI CMJOIMNALBN, [In] EKPKCANCJLO MAEBFBHFPDE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface ICKCBCAHIIL
{
	[Cpp2IlInjected.Token(Token = "0x17000165")]
	uint NKPFAAHIFNI
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface PGBPOHCBHMF
{
	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KGONFMDIDKL(HDKJDIEIILD FCGIDAOOKFO, IMDOBBINGKI CMJOIMNALBN, ReadOnlySpan<byte> INOBIGIOBFB, ReadOnlySpan<byte> ABBAOAOPHAN);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DHFBDIAOLEJ(HDKJDIEIILD FCGIDAOOKFO, IMDOBBINGKI CMJOIMNALBN);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GPGLDJMGAFB(HDKJDIEIILD FCGIDAOOKFO, IMDOBBINGKI CMJOIMNALBN, ReadOnlySpan<byte> ABBAOAOPHAN);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AFBGNABALCP(HDKJDIEIILD FCGIDAOOKFO, IMDOBBINGKI CMJOIMNALBN, Span<byte> INOBIGIOBFB, Span<byte> ABBAOAOPHAN);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class NNHIEKPNEDB
{
	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x286B5B0", Offset = "0x286A3B0", VA = "0x18286B5B0")]
	public static bool AFBGNABALCP<T>(this PGBPOHCBHMF JCECDOABOFE, HDKJDIEIILD FCGIDAOOKFO, IMDOBBINGKI CMJOIMNALBN, [Out] T INOBIGIOBFB, [Out] T ABBAOAOPHAN) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x286B760", Offset = "0x286A560", VA = "0x18286B760")]
	public static bool GPGLDJMGAFB<T>(this PGBPOHCBHMF JCECDOABOFE, HDKJDIEIILD FCGIDAOOKFO, IMDOBBINGKI CMJOIMNALBN, T ABBAOAOPHAN) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public enum DGFEEJPEDAK
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	End,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface IAIHKONAOFC
{
	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GAOPLLCEEHE(PBOCPNCJKJM CCBBNNMCBIL, ReadOnlySpan<byte> AOJMAAJAPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNCMOMGJHCO(uint EBGBHADEHPM, ReadOnlySpan<byte> AOJMAAJAPBJ);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface KJKNCPBMBIP
{
	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PBOCPNCJKJM PJKAADHLDDM(ReadOnlySpan<byte> AOJMAAJAPBJ);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface IIBACCMLIBH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LBDFBCIADFJ(PBOCPNCJKJM ONOECNHBCDA, ReadOnlySpan<byte> AOJMAAJAPBJ);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OAPEOGPGPHM(ReadOnlySpan<PBOCPNCJKJM> OLOHAJCBCJN);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct KKCCGCLLOGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public PBOCPNCJKJM CCBBNNMCBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public ReadOnlyMemory<byte> AOJMAAJAPBJ;
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct PBOCPNCJKJM
{
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public static PBOCPNCJKJM AGNHABHKIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public uint IOPOPAOOEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public int EOCJPNCMLJM;

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0xAAB8D0", Offset = "0xAAA6D0", VA = "0x180AAB8D0")]
	public PBOCPNCJKJM(uint IOPOPAOOEHC, int EOCJPNCMLJM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x61BA450", Offset = "0x61B9250", VA = "0x1861BA450")]
	public static bool EILLJGMDDAM([In] PBOCPNCJKJM MAJJJNOEIPE, [In] PBOCPNCJKJM FBEFKCHGALI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x61BA480", Offset = "0x61B9280", VA = "0x1861BA480", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x61BA530", Offset = "0x61B9330", VA = "0x1861BA530", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x61BA560", Offset = "0x61B9360", VA = "0x1861BA560", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x61BA470", Offset = "0x61B9270", VA = "0x1861BA470")]
	public void ELPMHLPMEKH([Out] uint IOPOPAOOEHC, [Out] int EOCJPNCMLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface CBGIOGPDGPI : GCOCMEECAJL<CBGIOGPDGPI>
{
	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CCEPLMLEFMB(IMDOBBINGKI FJIJLBIGEAH, [Out] MJOPNDNHKAP LPAICFACMCK);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public static class KIFFAIPHBKO
{
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public interface MJOPNDNHKAP
{
	[Cpp2IlInjected.Token(Token = "0x17000166")]
	Type DPMFBPNDCOB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APHAODHFANA(IINBKFKJJKB INLIFCPEGKK, Span<byte> EOCODFIAJEL);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CDDFPMJNNJO(ENIJCOAGKMD FCAJMDOFLNK, ReadOnlySpan<byte> CCBBNNMCBIL);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class MEHCLPNBNFJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public struct AGCPGMFAAPP : ISystemStateComponentData, IComponentData, IEquatable<AGCPGMFAAPP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public float3 LKNCJBEPJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public float3 NNKPAGHMBOH;

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x61A9520", Offset = "0x61A8320", VA = "0x1861A9520", Slot = "4")]
	public bool Equals(AGCPGMFAAPP EDOEJIMPOFP)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class HPJJGAKKNAL
{
	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public HPJJGAKKNAL()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
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
