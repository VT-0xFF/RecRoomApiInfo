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
using RecRoom.ObjectModel;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DefaultMember("Item")]
public struct DLCLMIEPGBN : IReadOnlyList<LHNHNFAONOD>, IEnumerable<LHNHNFAONOD>, IEnumerable, IReadOnlyCollection<LHNHNFAONOD>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct EBDFDNILBOG : IEnumerator<LHNHNFAONOD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly INHGBAEAGHP NMNJDGCCMMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator HBGFNOABMDF;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public LHNHNFAONOD PNJHIMNMKKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5D54300", Offset = "0x5D53700", VA = "0x185D54300", Slot = "4")]
			get
			{
				return default(LHNHNFAONOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5D54280", Offset = "0x5D53680", VA = "0x185D54280", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x395C8C0", Offset = "0x395BCC0", VA = "0x18395C8C0")]
		public EBDFDNILBOG(INHGBAEAGHP NMNJDGCCMMD, NativeArray<LocalId>.Enumerator HBGFNOABMDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5D541C0", Offset = "0x5D535C0", VA = "0x185D541C0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5D54200", Offset = "0x5D53600", VA = "0x185D54200", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5D54240", Offset = "0x5D53640", VA = "0x185D54240", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> GAKOOBMLEII;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public LHNHNFAONOD LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D53F30", Offset = "0x5D53330", VA = "0x185D53F30", Slot = "4")]
		get
		{
			return default(LHNHNFAONOD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D53A70", Offset = "0x5D52E70", VA = "0x185D53A70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int OCOEEEINJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x75C180", Offset = "0x75B580", VA = "0x18075C180", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public INHGBAEAGHP JJDEFEEBFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int EKAAEPEENKL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x75C180", Offset = "0x75B580", VA = "0x18075C180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool ONBNDEEHGPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D53AC0", Offset = "0x5D52EC0", VA = "0x185D53AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> GHFNOJMNGKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3955080", Offset = "0x3954480", VA = "0x183955080")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5D53EA0", Offset = "0x5D532A0", VA = "0x185D53EA0")]
	public DLCLMIEPGBN(int OOIJDECJBIB, INHGBAEAGHP NMNJDGCCMMD, Allocator KIKFOGPECEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x395C890", Offset = "0x395BC90", VA = "0x18395C890")]
	public DLCLMIEPGBN(INHGBAEAGHP NMNJDGCCMMD, NativeArray<LocalId> GAKOOBMLEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D53D80", Offset = "0x5D53180", VA = "0x185D53D80")]
	internal DLCLMIEPGBN(INHGBAEAGHP NMNJDGCCMMD, NativeArray<Entity> BAPHNAADJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D53CE0", Offset = "0x5D530E0", VA = "0x185D53CE0")]
	public DLCLMIEPGBN(INHGBAEAGHP NMNJDGCCMMD, int KIHHOMBMMEI, Allocator KIKFOGPECEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D53DF0", Offset = "0x5D531F0", VA = "0x185D53DF0")]
	public DLCLMIEPGBN(DLCLMIEPGBN GGFGMFCGPNH, Allocator KIKFOGPECEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D53930", Offset = "0x5D52D30", VA = "0x185D53930")]
	public DLCLMIEPGBN GFOOEPCPPKC(Allocator KIKFOGPECEC = Allocator.Temp)
	{
		return default(DLCLMIEPGBN);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5D538F0", Offset = "0x5D52CF0", VA = "0x185D538F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D539E0", Offset = "0x5D52DE0", VA = "0x185D539E0")]
	public EBDFDNILBOG JBKAHEPNGNA()
	{
		return default(EBDFDNILBOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5D53B00", Offset = "0x5D52F00", VA = "0x185D53B00", Slot = "6")]
	private IEnumerator<LHNHNFAONOD> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D53BF0", Offset = "0x5D52FF0", VA = "0x185D53BF0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct OKEBPAKPGDH : IList<LHNHNFAONOD>, ICollection<LHNHNFAONOD>, IEnumerable<LHNHNFAONOD>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct PNGAHNNIPHA : IEnumerator<LHNHNFAONOD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly INHGBAEAGHP NMNJDGCCMMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator HBGFNOABMDF;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public LHNHNFAONOD PNJHIMNMKKP
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5D61680", Offset = "0x5D60A80", VA = "0x185D61680", Slot = "4")]
			get
			{
				return default(LHNHNFAONOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5D61600", Offset = "0x5D60A00", VA = "0x185D61600", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x395C8C0", Offset = "0x395BCC0", VA = "0x18395C8C0")]
		public PNGAHNNIPHA(INHGBAEAGHP NMNJDGCCMMD, NativeArray<LocalId>.Enumerator HBGFNOABMDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5D61540", Offset = "0x5D60940", VA = "0x185D61540", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5D61580", Offset = "0x5D60980", VA = "0x185D61580", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5D615C0", Offset = "0x5D609C0", VA = "0x185D615C0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> GAKOOBMLEII;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public LHNHNFAONOD LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5D60290", Offset = "0x5D5F690", VA = "0x185D60290", Slot = "4")]
		get
		{
			return default(LHNHNFAONOD);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5D60310", Offset = "0x5D5F710", VA = "0x185D60310", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5D5FEC0", Offset = "0x5D5F2C0", VA = "0x185D5FEC0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int EKAAEPEENKL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5D5FEC0", Offset = "0x5D5F2C0", VA = "0x185D5FEC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool LIGHAHNLJDN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5D60200", Offset = "0x5D5F600", VA = "0x185D60200")]
	public OKEBPAKPGDH(INHGBAEAGHP NMNJDGCCMMD, int KIHHOMBMMEI, Allocator KIKFOGPECEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D5FE40", Offset = "0x5D5F240", VA = "0x185D5FE40")]
	public DLCLMIEPGBN MFGHILNBOBE()
	{
		return default(DLCLMIEPGBN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D5FA10", Offset = "0x5D5EE10", VA = "0x185D5FA10", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D5FA50", Offset = "0x5D5EE50", VA = "0x185D5FA50", Slot = "13")]
	public bool Contains(LHNHNFAONOD JJEIFGHOKOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D5FAE0", Offset = "0x5D5EEE0", VA = "0x185D5FAE0", Slot = "14")]
	public void CopyTo(LHNHNFAONOD[] FFAHMFOPGLA, int FJCKEJMMOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D5F990", Offset = "0x5D5ED90", VA = "0x185D5F990", Slot = "11")]
	public void Add(LHNHNFAONOD JJEIFGHOKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5D5FD00", Offset = "0x5D5F100", VA = "0x185D5FD00", Slot = "7")]
	public void Insert(int APOENOPNHBG, LHNHNFAONOD JJEIFGHOKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5D5FF50", Offset = "0x5D5F350", VA = "0x185D5FF50", Slot = "15")]
	public bool Remove(LHNHNFAONOD JJEIFGHOKOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D5FC70", Offset = "0x5D5F070", VA = "0x185D5FC70", Slot = "6")]
	public int IndexOf(LHNHNFAONOD JJEIFGHOKOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D5FF00", Offset = "0x5D5F300", VA = "0x185D5FF00", Slot = "8")]
	public void RemoveAt(int APOENOPNHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D5FC30", Offset = "0x5D5F030", VA = "0x185D5FC30", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D5FDB0", Offset = "0x5D5F1B0", VA = "0x185D5FDB0")]
	public PNGAHNNIPHA JBKAHEPNGNA()
	{
		return default(PNGAHNNIPHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D60020", Offset = "0x5D5F420", VA = "0x185D60020", Slot = "16")]
	private IEnumerator<LHNHNFAONOD> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5D60110", Offset = "0x5D5F510", VA = "0x185D60110", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IPLKNLMFFDP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int IDEEPCEAJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> ODCBGEMHLPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LHNHNFAONOD EDHDCECNBEG(LHNHNFAONOD GAKOOBMLEII);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FBAIDFDFFOJ : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface KENPJEONHPC : PMEJGPCHMNC, FDJDNGGEHIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool GHLFCACBCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	BJOIGMMCCHE OAFBJOCEDHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	NBIPELNFGHB KOHEIAADMPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	GNGBPCPDDMI OHMNMMPCAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	ALLMMPKGJCM DFHLBFHMNHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	PLGBKBNKNDI KPAPLDAGLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface FDJDNGGEHIB
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool FGAOPKACOEL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface FDFCIENILNM
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EEIOAAFEHLB(bool EOHMJBFGDPD);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface ALLMMPKGJCM
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool FIJAEMDLBNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action DDCAGJFPANI;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AAOCABPFAHD(bool EGKJFJONNCD);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PEHEHLEHJFM(ByteString EGFEGIMIICO);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CCGGMHJMGHE();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FJCEJCMDELL();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LDMIFEDAPNB();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface GNGBPCPDDMI
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	FJPIIIPDBML OAFBJOCEDHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	NBIPELNFGHB KOHEIAADMPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	IMHPKNCJCOD KLNOCOBGHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	KENPJEONHPC DHFHHKAKAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	INHGBAEAGHP JJDEFEEBFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	NMDHGCKCBIM IKJMCNLLEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	KFJHDAOPGPA GHHBICFAIFA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	NBCENCLEOLD BIDKFJGGJJH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	CEJODIHFCGC HPMBALAHCBD
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	JIIJKCLIHFI BOHNEDDGBBD
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DPBFPLBNLLG DPDIDFCGDHA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	AAJHNHAHHBB HELCAPEGHFM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	CNCGGMKKCEC ELKECBPOJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	LIHDLACLGHM PDBCOGGHPGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	NLJBCKCCFIP FDGKHJCPFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	KCGPOJECAHP LJMLCHKKNDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	FINDIDOCBAK IECDKGKKBHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	JICJPEPDNGF FDDMBMODNCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	PMPMJLEMOAG CENPIFCHHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	CCCMOPCHHIG KOBLJGHDKAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DebuggerTypeProxy(typeof(CEFCLCBAOLL))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct LHNHNFAONOD : IComparable<LHNHNFAONOD>, IEquatable<LHNHNFAONOD>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly LHNHNFAONOD JCNACNONIMC;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int GLIMOODJCEP = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int DGPOABBEMOK = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int HKHCFCBNEAO = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int ECMANJIOOPO = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId PIBFDGEOBKF;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public INHGBAEAGHP JJDEFEEBFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5D52D00", Offset = "0x5D52100", VA = "0x185D52D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public LocalId CCABNOCKPHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5D5A8C0", Offset = "0x5D59CC0", VA = "0x185D5A8C0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	internal PLGBKBNKNDI KPAPLDAGLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5D5ADC0", Offset = "0x5D5A1C0", VA = "0x185D5ADC0")]
		get
		{
			return default(PLGBKBNKNDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool AOKIEGPHIBB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5D5ABC0", Offset = "0x5D59FC0", VA = "0x185D5ABC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool MIMHPCBGPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5D5ADD0", Offset = "0x5D5A1D0", VA = "0x185D5ADD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool HPJBDLMEMPK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5D5A9E0", Offset = "0x5D59DE0", VA = "0x185D5A9E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5D5AF50", Offset = "0x5D5A350", VA = "0x185D5AF50")]
	public LHNHNFAONOD(INHGBAEAGHP OHJEKCIEBHB, LocalId PIBFDGEOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
	public FDLKIDLAABP LBGINADDMGM()
	{
		return default(FDLKIDLAABP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5D5A880", Offset = "0x5D59C80", VA = "0x185D5A880")]
	public static LocalId BNPEICKPPJA(LHNHNFAONOD AGIFKOKGBDL)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5D5A840", Offset = "0x5D59C40", VA = "0x185D5A840")]
	public static Entity BNPEICKPPJA(LHNHNFAONOD AGIFKOKGBDL)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5D5ACA0", Offset = "0x5D5A0A0", VA = "0x185D5ACA0")]
	public static bool MEMFAJGIIAO(LHNHNFAONOD IFAOGMEBPFN, LHNHNFAONOD DNPBOPMFFFF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5D56360", Offset = "0x5D55760", VA = "0x185D56360")]
	public static bool OPPLDLMADNB(LHNHNFAONOD IFAOGMEBPFN, LHNHNFAONOD DNPBOPMFFFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D5AE20", Offset = "0x5D5A220", VA = "0x185D5AE20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5D5AA30", Offset = "0x5D59E30", VA = "0x185D5AA30", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5D5A900", Offset = "0x5D59D00", VA = "0x185D5A900", Slot = "4")]
	public int CompareTo(LHNHNFAONOD LJIBJAOOGGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "5")]
	public bool Equals(LHNHNFAONOD LJIBJAOOGGF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class IJCJAHAHMFB
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5D57A70", Offset = "0x5D56E70", VA = "0x185D57A70")]
	public static IJFILFNCAOA GEMBKIKECJJ(this LHNHNFAONOD BAFDGKKJJJD)
	{
		return default(IJFILFNCAOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x23D4780", Offset = "0x23D3B80", VA = "0x1823D4780")]
	public static T FBPGPEFKDJK<T>(this LHNHNFAONOD BAFDGKKJJJD) where T : struct, IComponent
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal sealed class CEFCLCBAOLL
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct PLGBKBNKNDI : IEquatable<PLGBKBNKNDI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte DELBIPHKFDD;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] AGMEADBOBGM;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static INHGBAEAGHP IAAJIHGIFCA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static KENPJEONHPC LDFALENJFGA;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static INHGBAEAGHP[] HAFGCKJBDBH;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static KENPJEONHPC[] MFADJJKHNNK;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static int IMJEOHJKANA;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public INHGBAEAGHP FKBOBNOHOKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5D61150", Offset = "0x5D60550", VA = "0x185D61150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5D61530", Offset = "0x5D60930", VA = "0x185D61530")]
	static PLGBKBNKNDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xB488D0", Offset = "0xB47CD0", VA = "0x180B488D0")]
	internal PLGBKBNKNDI(byte EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x50317A0", Offset = "0x5030BA0", VA = "0x1850317A0", Slot = "4")]
	public bool Equals(PLGBKBNKNDI LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5D608C0", Offset = "0x5D5FCC0", VA = "0x185D608C0", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1926750", Offset = "0x1925B50", VA = "0x181926750", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5D61470", Offset = "0x5D60870", VA = "0x185D61470", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5D613B0", Offset = "0x5D607B0", VA = "0x185D613B0")]
	private static INHGBAEAGHP PMBFAECOFJH(byte DELBIPHKFDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5D61240", Offset = "0x5D60640", VA = "0x185D61240")]
	private static object NLPCOBPGEOJ(byte DELBIPHKFDD, object[] PKDIDJEMOMO, object DPPAMEJDDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5D61230", Offset = "0x5D60630", VA = "0x185D61230")]
	private static int MBMGBIMPEOK(byte DELBIPHKFDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5D61460", Offset = "0x5D60860", VA = "0x185D61460")]
	private static int PPEJMPNGEON(byte DELBIPHKFDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5D60B40", Offset = "0x5D5FF40", VA = "0x185D60B40")]
	private static (int, int) HDDAPEBLCDE(byte DELBIPHKFDD)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5D608B0", Offset = "0x5D5FCB0", VA = "0x185D608B0")]
	private static byte CKMAJLAGJPG(int FOIKACEEEGH, int APOENOPNHBG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5D60EA0", Offset = "0x5D602A0", VA = "0x185D60EA0")]
	internal static PLGBKBNKNDI KIPDOAILNDA(KENPJEONHPC EPKJOOEACNA, INHGBAEAGHP NFFIAJHDGDD)
	{
		return default(PLGBKBNKNDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5D60960", Offset = "0x5D5FD60", VA = "0x185D60960")]
	internal static void FOMBLDAJHNJ(PLGBKBNKNDI DELBIPHKFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5D60BC0", Offset = "0x5D5FFC0", VA = "0x185D60BC0")]
	private static void KFNCODKKLFD(int OOIJDECJBIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface ADOFIMCFGAO
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CHIIFIGNFLM();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ANANAJLNINO(bool GLJJBMABIGB);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IIHGPEGNECO(GameObject IPAGFDLNMDK);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface MMONOMOIAFI
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	Guid IKCLCFFALLN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BHHJFGDDILI(Guid ECBHCFPFIOJ, Guid IFBGAIHMHIG);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task AOBNBBPDMFA(LHNHNFAONOD GDANGJOOBEI);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NCNEPKGBNFA(LHNHNFAONOD JHAODPLJNCN, LHNHNFAONOD EBFCMPBKGBM, [Out] Vector3 HLENKEBAKND, [Out] Quaternion OCCLANFLOLP);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BCAECBFNPNI(JOIHKMPAGFE MDFNIIOLLHB, Vector3 HLENKEBAKND, Quaternion OCCLANFLOLP);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface JKPJPBADHMP
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MMHGIGLHJAB(DLCLMIEPGBN GAKOOBMLEII);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface NBIPELNFGHB
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	ADOFIMCFGAO CJNCCAFDDGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	MJMAOFFIBEJ BNAFEJLEEDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	GIJNOGPDJNH NELLMLBHNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	OBDFANNJJFO HEBJDHHHPKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	DGGIPPFDHEO FDPKLJDGEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	KFJAFIJIKDB GHBGPMIKACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	KNMOBKNCALK FEIHNKLKGKM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	HKDMOLLIAMN HFCEGAEDEDG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface JHAPJOBBFII
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BCKJJDBMHBD(Action GMCEKENFDDF, bool BEMKKOAIGKL);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EJKJNMAPELL(string LFAIHEECJFK);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface MJMAOFFIBEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	string GFCDMMDOAHH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] HAJAIDOELKI(IEnumerable<BDDINDDAOMP> JJAIIAGNJLG);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FINNGIOBDPD(GameObject IPAGFDLNMDK, [Out] IJFILFNCAOA[] OMNMPNPKGPB);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ADKPOJEOBPH(GameObject IPAGFDLNMDK, [Out] int NLMOECICDEK, [Out] JMFEOGDEHDH INONPCNKMNK);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PCCDMPNJHHD KFIGDOAGFJH(BDDINDDAOMP PLGCCHMKBMF);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PCCDMPNJHHD KFIGDOAGFJH(string HFCKFJICBCH, IJFILFNCAOA[] JNPKHIBFGKN, Vector3 LPAPEIIOLFG, Quaternion KBKHJHIFKGI, Vector3 NMGPAHAPPCF);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GameObject EBFBCJELFDC(string HFCKFJICBCH);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DKFDGMECGHO(GameObject FNADFCPODOH, bool ELBHFFKMPJI);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CCMMMHJHMAG(GameObject IPAGFDLNMDK, bool JONDAAKDGOK, bool MEJODNHDEEF);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class AIEMELDOGGK
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5D51E10", Offset = "0x5D51210", VA = "0x185D51E10")]
	public static PCCDMPNJHHD KFIGDOAGFJH(this MJMAOFFIBEJ LFANGALDMHE, Vector3 LPAPEIIOLFG, Quaternion KBKHJHIFKGI, Vector3 NMGPAHAPPCF, params IJFILFNCAOA[] OMNMPNPKGPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface GIJNOGPDJNH
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KNLNGHJNJAO(bool EGKJFJONNCD);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface OBDFANNJJFO
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	bool NOFDHONNOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool EFNBKJOEKCE
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool ILIACOFMHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	bool KCKHJBCBICB
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FDPDLHCJFBF(object HEFGEKEDAKE);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PEBKCDHKOFF(object BGICHGONLEL);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OHJJMCEPLLC(object BGICHGONLEL);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int ECGCCDBMKME(GameObject OCEAKGFKBEH);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MGPOODOJOOB(NativeArray<int> JLHEEOGHAJA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface DGGIPPFDHEO
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKDDHNMABIB(GameObject IPAGFDLNMDK);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface JPLLAMGFKJI
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPMNJIMENAI(string NJKPBIBMIJE);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface IGKLMANCLGL
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int AGHNCKDBCOA(GameObject IPAGFDLNMDK);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HGPNLPOPJEO(GameObject IPAGFDLNMDK);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	object GACEOEENPKI(LHNHNFAONOD PIBFDGEOBKF, GameObject IPAGFDLNMDK, Action<LHNHNFAONOD, int> IOKENELNCLP);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LAIBNEKJKAM(GameObject IPAGFDLNMDK, object JMKNEHOFACC);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface KFJAFIJIKDB
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	int LJOMJMMHMMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int GMLCLBAMMFP(GameObject IPAGFDLNMDK);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IIKPMONJADH([Out] Vector3 LPAPEIIOLFG);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KNFPCOKPNEG();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface KNMOBKNCALK
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool FIJAEMDLBNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool DFABIHBPKMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface BODNLCIOGJO
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	OAEENPGHNAJ AAMEJKPFIMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	DGOAMENBLKI PKPCBGJMHDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HPKECEKKNOF(Transform OLPLDGDFGHL);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NCPAAKPAKNP(Transform OLPLDGDFGHL, BCKKKFEDNPH LOBNCOGHBMF);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HMFJNAKGGAM(Transform OLPLDGDFGHL, OKMBENJPNJO OPGIAEPOGBD);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface HKDMOLLIAMN
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEAFPLMDCGL();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface MICHBMMIPGJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BDGHICBIJAI();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface AFLJLAKFEOK
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JMFEOGDEHDH ABDMNAGIAHG(GameObject OCEAKGFKBEH);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DBEJEEJCMDI(GameObject IPAGFDLNMDK, BFOJEBGGLIC BNGPLBAOKGE, HIKIIHDHHAA MCKACALLEHM);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string MMGKKHNPEHI(int PIKCMFPLBNL);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int KHCMFOOEIEL(string EIDCNFCDMOH);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EJDGHOMPMPD(LHNHNFAONOD PIBFDGEOBKF, int[] JEBHMNBHGHL);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct HFCKDMJMNLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly ELKDFBPEDKP NBBMHNNJHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly ELKDFBPEDKP ICPDBPOHHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal readonly uint COJIBGDICPO;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D57260", Offset = "0x5D56660", VA = "0x185D57260", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct KFLJHIHBCDL
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly HFCKDMJMNLI GMCEKENFDDF;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D547B0", Offset = "0x5D53BB0", VA = "0x185D547B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct EDLAPCCOPKL
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly HFCKDMJMNLI GMCEKENFDDF;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5D547B0", Offset = "0x5D53BB0", VA = "0x185D547B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct IADEBCACFMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint COJIBGDICPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly bool ABLDCLHNKIO;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5D574C0", Offset = "0x5D568C0", VA = "0x185D574C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct ELKDFBPEDKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal int APBJNEFOGOC;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5D54A20", Offset = "0x5D53E20", VA = "0x185D54A20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface MKCGGMKFMJC
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	AFKLFOJMMJO DNAHOOHGDED
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum FDKLFGADELG
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
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface PCCDMPNJHHD : COAMOALCCMA
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	FDLKIDLAABP LOMBCMGOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	FDKLFGADELG CGHLFPGKMMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool BOHFIPBHPDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	GameObject IPAGFDLNMDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<PCCDMPNJHHD> LKGDLFIICDC;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(IMHPKNCJCOD MOIDEPLOCKC, LHNHNFAONOD JJCBAPGMGLL);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool EOAMIPFFDKE);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class FLLEIPGLKMO
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5D56670", Offset = "0x5D55A70", VA = "0x185D56670")]
	public static bool HEIAMNBIGPH(this PCCDMPNJHHD PIOJMHPNEKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5D566C0", Offset = "0x5D55AC0", VA = "0x185D566C0")]
	public static bool LACCMCLGLCO(this PCCDMPNJHHD PIOJMHPNEKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5D56590", Offset = "0x5D55990", VA = "0x185D56590")]
	public static bool CIMOGPLELEA(this PCCDMPNJHHD PIOJMHPNEKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5D565E0", Offset = "0x5D559E0", VA = "0x185D565E0")]
	public static bool GHLFCACBCML(this PCCDMPNJHHD PIOJMHPNEKO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface COAMOALCCMA
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool MDIKGCAGGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	LHNHNFAONOD NJBGKNJCFAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
internal interface POGJBDCDPAC
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<HDHIDMCJGCD> FENGFCMOPKC;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface IELJJLAMLND : CMHIFLHHMKA<IJFILFNCAOA>, BAPMFMKMMNM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface MNDJINKEOKO<T> : MGPJIDJKJFM<IJFILFNCAOA, T>, CMHIFLHHMKA<IJFILFNCAOA>, BAPMFMKMMNM, IDisposable, IELJJLAMLND where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class FFGFGIBOICA
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x236D020", Offset = "0x236C420", VA = "0x18236D020")]
	public static bool IIDAIDKPMAP<T>(this CMHIFLHHMKA<IJFILFNCAOA> ANNDMLIIDLL, IJFILFNCAOA JNPKHIBFGKN, [Out] T EOHMJBFGDPD) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x236D000", Offset = "0x236C400", VA = "0x18236D000")]
	public static bool GMFKOPHMECD<T>(this CMHIFLHHMKA<IJFILFNCAOA> ANNDMLIIDLL, IJFILFNCAOA JNPKHIBFGKN, [In] T BDDLEBIAAAH) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface ADLHMGAHKNA : CMHIFLHHMKA<LHNHNFAONOD>, BAPMFMKMMNM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface LJLPBCHNEGF<T> : MGPJIDJKJFM<LHNHNFAONOD, T>, CMHIFLHHMKA<LHNHNFAONOD>, BAPMFMKMMNM, IDisposable, ADLHMGAHKNA where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class PFDMMMJNKDP
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2258770", Offset = "0x2257B70", VA = "0x182258770")]
	public static T OPODPAEFLEB<T>(this CMHIFLHHMKA<LHNHNFAONOD> ANNDMLIIDLL, LHNHNFAONOD PIBFDGEOBKF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2438E40", Offset = "0x2438240", VA = "0x182438E40")]
	public static bool GMFKOPHMECD<T>(this CMHIFLHHMKA<LHNHNFAONOD> ANNDMLIIDLL, LHNHNFAONOD PIBFDGEOBKF, [In] T BDDLEBIAAAH) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct EAAMNLEDMLN : IComparable<EAAMNLEDMLN>, IEquatable<EAAMNLEDMLN>
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly EAAMNLEDMLN JCNACNONIMC;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly EAAMNLEDMLN KKPKACBLAKD;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly EAAMNLEDMLN OFDCPGNHBDN;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly EAAMNLEDMLN MKMAHOANJHG;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly EAAMNLEDMLN PEPKDKNNNLO;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly EAAMNLEDMLN NLJGBFMONBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int CBNNNKAIBOB;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool BAJAFHDGNBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5D53F70", Offset = "0x5D53370", VA = "0x185D53F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public int NFCPFLKLCGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5D54060", Offset = "0x5D53460", VA = "0x185D54060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7DFAC0", Offset = "0x7DEEC0", VA = "0x1807DFAC0")]
	public EAAMNLEDMLN(int APOENOPNHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5D54000", Offset = "0x5D53400", VA = "0x185D54000", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5D53F80", Offset = "0x5D53380", VA = "0x185D53F80", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1642C20", Offset = "0x1642020", VA = "0x181642C20", Slot = "5")]
	public bool Equals(EAAMNLEDMLN LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x16507C0", Offset = "0x164FBC0", VA = "0x1816507C0", Slot = "4")]
	public int CompareTo(EAAMNLEDMLN LJIBJAOOGGF)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0xBC9740", Offset = "0xBC8B40", VA = "0x180BC9740")]
	public static EAAMNLEDMLN BNPEICKPPJA(int APOENOPNHBG)
	{
		return default(EAAMNLEDMLN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0xBC9740", Offset = "0xBC8B40", VA = "0x180BC9740")]
	public static int BNPEICKPPJA(EAAMNLEDMLN KMKGEGCGMGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5D54070", Offset = "0x5D53470", VA = "0x185D54070", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct FDLKIDLAABP : IEquatable<FDLKIDLAABP>, COAMOALCCMA
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly FDLKIDLAABP GIHJJMPCPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public LHNHNFAONOD NJBGKNJCFAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00", Slot = "6")]
		get
		{
			return default(LHNHNFAONOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public LMJHNLCIBDO JGKOKOJENGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(LMJHNLCIBDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public LPICOBPFPNA IKJMCNLLEAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(LPICOBPFPNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private INHGBAEAGHP JJDEFEEBFNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5D52D00", Offset = "0x5D52100", VA = "0x185D52D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public GameObject IPAGFDLNMDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5D560C0", Offset = "0x5D554C0", VA = "0x185D560C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public IJFILFNCAOA AADLPBGNMOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D56380", Offset = "0x5D55780", VA = "0x185D56380")]
		get
		{
			return default(IJFILFNCAOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public NGBPNMOBPJE KCAIMBCBMCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5D55E40", Offset = "0x5D55240", VA = "0x185D55E40")]
		get
		{
			return default(NGBPNMOBPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public JMFEOGDEHDH JHENHJPBGAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5D55EE0", Offset = "0x5D552E0", VA = "0x185D55EE0")]
		get
		{
			return default(JMFEOGDEHDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool EBCBBMFHCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5D55BD0", Offset = "0x5D54FD0", VA = "0x185D55BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool BEKBCOJKBLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5D56070", Offset = "0x5D55470", VA = "0x185D56070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool JODHJHFNKCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5D56250", Offset = "0x5D55650", VA = "0x185D56250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool FIEPDBPEAEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5D55A00", Offset = "0x5D54E00", VA = "0x185D55A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool DHDOIABGEGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5D56090", Offset = "0x5D55490", VA = "0x185D56090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool JHLNDCODFHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5D55CD0", Offset = "0x5D550D0", VA = "0x185D55CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool CCMGFKKOCDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5D55D10", Offset = "0x5D55110", VA = "0x185D55D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public JFBHNIMMHOL LMANFBJJOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(JFBHNIMMHOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public KICNOLOAGGC FMNPINLGKLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(KICNOLOAGGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public AAJDPEBBPFH ELKECBPOJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(AAJDPEBBPFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public FCFHKNJEJEJ NGNFGEMEKKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(FCFHKNJEJEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public BHLIJHOGNDD HELCAPEGHFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(BHLIJHOGNDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public IBHCKDDJCLA ILJNNBBAMAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(IBHCKDDJCLA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public JOIHKMPAGFE KLHGINFLOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(JOIHKMPAGFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public ICEJGNLJBIG PMKGKFOFJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(ICEJGNLJBIG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool HEIAMNBIGPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5D56270", Offset = "0x5D55670", VA = "0x185D56270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public bool AKKNLNOOBEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5D55B60", Offset = "0x5D54F60", VA = "0x185D55B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	private bool APBJPLJJONC
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7785F0", Offset = "0x7779F0", VA = "0x1807785F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50")]
	public FDLKIDLAABP(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5D52590", Offset = "0x5D51990", VA = "0x185D52590")]
	public static bool BNPEICKPPJA(FDLKIDLAABP EOHMJBFGDPD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0xA2A8A0", Offset = "0xA29CA0", VA = "0x180A2A8A0")]
	public static LHNHNFAONOD BNPEICKPPJA(FDLKIDLAABP EOHMJBFGDPD)
	{
		return default(LHNHNFAONOD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5D560B0", Offset = "0x5D554B0", VA = "0x185D560B0")]
	public static bool MEMFAJGIIAO(FDLKIDLAABP IFAOGMEBPFN, FDLKIDLAABP DNPBOPMFFFF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5D56360", Offset = "0x5D55760", VA = "0x185D56360")]
	public static bool OPPLDLMADNB(FDLKIDLAABP IFAOGMEBPFN, FDLKIDLAABP DNPBOPMFFFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5D55C40", Offset = "0x5D55040", VA = "0x185D55C40", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "4")]
	public bool Equals(FDLKIDLAABP LJIBJAOOGGF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0xA2A8A0", Offset = "0xA29CA0", VA = "0x180A2A8A0")]
	public static FDLKIDLAABP BNPEICKPPJA(LHNHNFAONOD GIPGBEGNLCD)
	{
		return default(FDLKIDLAABP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5D55A20", Offset = "0x5D54E20", VA = "0x185D55A20")]
	public MIMPJHHKPIA CCBOGFIEOEN()
	{
		return default(MIMPJHHKPIA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5D55BA0", Offset = "0x5D54FA0", VA = "0x185D55BA0")]
	public MNMABBGFKEB EEFNAEMLMIK()
	{
		return default(MNMABBGFKEB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D55BF0", Offset = "0x5D54FF0", VA = "0x185D55BF0")]
	public PEILNHFAGGO EHOHGODOAEN()
	{
		return default(PEILNHFAGGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5D55D30", Offset = "0x5D55130", VA = "0x185D55D30")]
	public void HFGJIPKOLGA([Optional] object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5D55F80", Offset = "0x5D55380", VA = "0x185D55F80")]
	public bool KJDJBAPPIFP(object KJAGMGIFCEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5D55A70", Offset = "0x5D54E70", VA = "0x185D55A70")]
	public bool DCPFEBKPKND(object KJAGMGIFCEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5D56420", Offset = "0x5D55820", VA = "0x185D56420", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct JOIHKMPAGFE : IEquatable<JOIHKMPAGFE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public LHNHNFAONOD NJBGKNJCFAM
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(LHNHNFAONOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public FDLKIDLAABP LOMBCMGOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	private INHGBAEAGHP JJDEFEEBFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5D52D00", Offset = "0x5D52100", VA = "0x185D52D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	private GNGBPCPDDMI OHMNMMPCAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5D59FF0", Offset = "0x5D593F0", VA = "0x185D59FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private KCGPOJECAHP KPGJIJBONAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5D5A110", Offset = "0x5D59510", VA = "0x185D5A110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool BCPAMGCFCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5D5A2A0", Offset = "0x5D596A0", VA = "0x185D5A2A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Guid ACOGLACENBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5D59E30", Offset = "0x5D59230", VA = "0x185D59E30")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool BLKAPNOLDPL
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5D5A210", Offset = "0x5D59610", VA = "0x185D5A210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Guid IFDLANLODLO
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5D59D10", Offset = "0x5D59110", VA = "0x185D59D10")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50")]
	public JOIHKMPAGFE(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5D52590", Offset = "0x5D51990", VA = "0x185D52590")]
	public static bool BNPEICKPPJA(JOIHKMPAGFE EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5D59B60", Offset = "0x5D58F60", VA = "0x185D59B60", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "4")]
	public bool Equals(JOIHKMPAGFE LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CE0", Offset = "0x5D510E0", VA = "0x185D51CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5D59F50", Offset = "0x5D59350", VA = "0x185D59F50")]
	public bool LFMJNBOLLJF([Out] Guid PDHLDIFODOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5D59A40", Offset = "0x5D58E40", VA = "0x185D59A40")]
	public void BOBKCCPBOGP(Guid PGHIMEILAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5D5A170", Offset = "0x5D59570", VA = "0x185D5A170")]
	public bool OBCEOACDMOI([Out] Guid EKIGMNBCJDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5D59BF0", Offset = "0x5D58FF0", VA = "0x185D59BF0")]
	public void HGMECABFBME(Guid PGHIMEILAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5D5A080", Offset = "0x5D59480", VA = "0x185D5A080")]
	public void NFMBMIJNPEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public readonly struct PEILNHFAGGO : IEquatable<PEILNHFAGGO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public LHNHNFAONOD NJBGKNJCFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(LHNHNFAONOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public FDLKIDLAABP LOMBCMGOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	private INHGBAEAGHP JJDEFEEBFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5D52D00", Offset = "0x5D52100", VA = "0x185D52D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	private GNGBPCPDDMI OHMNMMPCAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5D60610", Offset = "0x5D5FA10", VA = "0x185D60610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	private FINDIDOCBAK GAKDOLICGLG
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5D606A0", Offset = "0x5D5FAA0", VA = "0x185D606A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float3 NCLNECKFIJF
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5D60450", Offset = "0x5D5F850", VA = "0x185D60450")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public quaternion LLMKAOAECKP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5D60790", Offset = "0x5D5FB90", VA = "0x185D60790")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public FDLKIDLAABP JIHDOFJLOOI
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5D60700", Offset = "0x5D5FB00", VA = "0x185D60700")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50")]
	public PEILNHFAGGO(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0xA2A8A0", Offset = "0xA29CA0", VA = "0x180A2A8A0")]
	public static LHNHNFAONOD BNPEICKPPJA(PEILNHFAGGO EOHMJBFGDPD)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5D60580", Offset = "0x5D5F980", VA = "0x185D60580", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "4")]
	public bool Equals(PEILNHFAGGO LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CE0", Offset = "0x5D510E0", VA = "0x185D51CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct MIMPJHHKPIA : IEquatable<MIMPJHHKPIA>
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly MIMPJHHKPIA GIHJJMPCPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public LHNHNFAONOD NJBGKNJCFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(LHNHNFAONOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public FDLKIDLAABP LOMBCMGOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public LMJHNLCIBDO JGKOKOJENGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(LMJHNLCIBDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public LPICOBPFPNA IKJMCNLLEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(LPICOBPFPNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private INHGBAEAGHP JJDEFEEBFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5D52D00", Offset = "0x5D52100", VA = "0x185D52D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private GNGBPCPDDMI OHMNMMPCAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5D5E550", Offset = "0x5D5D950", VA = "0x185D5E550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private NMDHGCKCBIM HMAOLJDKMNB
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5D5E0B0", Offset = "0x5D5D4B0", VA = "0x185D5E0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public DLCLMIEPGBN HOCNMAGGHIF
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5D5DE80", Offset = "0x5D5D280", VA = "0x185D5DE80")]
		get
		{
			return default(DLCLMIEPGBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public IEnumerable<FDLKIDLAABP> APDMNNGBLFI
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5D5E110", Offset = "0x5D5D510", VA = "0x185D5E110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public IEnumerable<FDLKIDLAABP> JFBAGMHMKIL
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5D5DAC0", Offset = "0x5D5CEC0", VA = "0x185D5DAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int IMIOPGDPPJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5D5D970", Offset = "0x5D5CD70", VA = "0x185D5D970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public int KKBLCMIGKHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5D5DFB0", Offset = "0x5D5D3B0", VA = "0x185D5DFB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public string PCDEPGOAGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5D5E000", Offset = "0x5D5D400", VA = "0x185D5E000")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5D5E2F0", Offset = "0x5D5D6F0", VA = "0x185D5E2F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public JHONAEGJBJL ADPCGOIBGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5D5DD90", Offset = "0x5D5D190", VA = "0x185D5DD90")]
		get
		{
			return default(JHONAEGJBJL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5D5DCC0", Offset = "0x5D5D0C0", VA = "0x185D5DCC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public BIPCOEBMACL HHGGAPIAHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5D5E410", Offset = "0x5D5D810", VA = "0x185D5E410")]
		get
		{
			return default(BIPCOEBMACL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5D5E970", Offset = "0x5D5DD70", VA = "0x185D5E970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public IFIHINKEGCP HCNDFCBLBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5D5DD30", Offset = "0x5D5D130", VA = "0x185D5DD30")]
		get
		{
			return default(IFIHINKEGCP);
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5D5E900", Offset = "0x5D5DD00", VA = "0x185D5E900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public float HJEOALICKHG
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5D5DA60", Offset = "0x5D5CE60", VA = "0x185D5DA60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5D5DF40", Offset = "0x5D5D340", VA = "0x185D5DF40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool HPPOPIPFAKE
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5D5EBB0", Offset = "0x5D5DFB0", VA = "0x185D5EBB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool BGFGHJKOEDH
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5D5E280", Offset = "0x5D5D680", VA = "0x185D5E280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool HMNMBLNGLAH
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5D5E4E0", Offset = "0x5D5D8E0", VA = "0x185D5E4E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool JBNCCMFOOPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5D5E3A0", Offset = "0x5D5D7A0", VA = "0x185D5E3A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool AMPACLEIOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5D5DBF0", Offset = "0x5D5CFF0", VA = "0x185D5DBF0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5D5E890", Offset = "0x5D5DC90", VA = "0x185D5E890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool APODPAPNAIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5D5DA00", Offset = "0x5D5CE00", VA = "0x185D5DA00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5D5DC50", Offset = "0x5D5D050", VA = "0x185D5DC50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50")]
	public MIMPJHHKPIA(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5D52590", Offset = "0x5D51990", VA = "0x185D52590")]
	public static bool BNPEICKPPJA(MIMPJHHKPIA EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5D5DDF0", Offset = "0x5D5D1F0", VA = "0x185D5DDF0", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "4")]
	public bool Equals(MIMPJHHKPIA LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CE0", Offset = "0x5D510E0", VA = "0x185D51CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0xA2A8A0", Offset = "0xA29CA0", VA = "0x180A2A8A0")]
	public static FDLKIDLAABP BNPEICKPPJA(MIMPJHHKPIA KBPJCNHNBHJ)
	{
		return default(FDLKIDLAABP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5D5E9E0", Offset = "0x5D5DDE0", VA = "0x185D5E9E0")]
	public bool OJNHCCDNNNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5D5E470", Offset = "0x5D5D870", VA = "0x185D5E470")]
	public bool KPLDNKJIDMJ(FCEMCBKNAEB MIIJFFOGLNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5D5EC20", Offset = "0x5D5E020", VA = "0x185D5EC20")]
	public void PKOCAACNAFA(FCEMCBKNAEB MIIJFFOGLNG, bool EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5D5EA00", Offset = "0x5D5DE00", VA = "0x185D5EA00")]
	public DLCLMIEPGBN PAAFGFPDCKP(Allocator KIKFOGPECEC)
	{
		return default(DLCLMIEPGBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5D5E5E0", Offset = "0x5D5D9E0", VA = "0x185D5E5E0")]
	public void MEAELCEBNND(MIMPJHHKPIA LJIBJAOOGGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct LCINGDOHMKF : IEquatable<LCINGDOHMKF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public FDLKIDLAABP LOMBCMGOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5D5A7B0", Offset = "0x5D59BB0", VA = "0x185D5A7B0", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "4")]
	public bool Equals(LCINGDOHMKF LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CE0", Offset = "0x5D510E0", VA = "0x185D51CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct KICNOLOAGGC : IEquatable<KICNOLOAGGC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public FDLKIDLAABP LOMBCMGOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private INHGBAEAGHP JJDEFEEBFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5D52D00", Offset = "0x5D52100", VA = "0x185D52D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50")]
	public KICNOLOAGGC(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5D5A540", Offset = "0x5D59940", VA = "0x185D5A540", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "4")]
	public bool Equals(KICNOLOAGGC LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CE0", Offset = "0x5D510E0", VA = "0x185D51CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5D5A5D0", Offset = "0x5D599D0", VA = "0x185D5A5D0")]
	public void FOEGEAAAFMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5D5A670", Offset = "0x5D59A70", VA = "0x185D5A670")]
	public void LEFNEIHNBJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct JIPGNKMLDHO : IEquatable<JIPGNKMLDHO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public FDLKIDLAABP LOMBCMGOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5D58C40", Offset = "0x5D58040", VA = "0x185D58C40", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "4")]
	public bool Equals(JIPGNKMLDHO LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CE0", Offset = "0x5D510E0", VA = "0x185D51CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct BMGNDKAGHMI : IEquatable<BMGNDKAGHMI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public FDLKIDLAABP LOMBCMGOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5D530B0", Offset = "0x5D524B0", VA = "0x185D530B0", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "4")]
	public bool Equals(BMGNDKAGHMI LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CE0", Offset = "0x5D510E0", VA = "0x185D51CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct NEPNDPLHPIP : IEquatable<NEPNDPLHPIP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public FDLKIDLAABP LOMBCMGOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5D5F4D0", Offset = "0x5D5E8D0", VA = "0x185D5F4D0", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "4")]
	public bool Equals(NEPNDPLHPIP LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CE0", Offset = "0x5D510E0", VA = "0x185D51CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct FHNDFFPJJOJ : IEquatable<FHNDFFPJJOJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public FDLKIDLAABP LOMBCMGOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5D56500", Offset = "0x5D55900", VA = "0x185D56500", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "4")]
	public bool Equals(FHNDFFPJJOJ LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CE0", Offset = "0x5D510E0", VA = "0x185D51CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public readonly struct LPICOBPFPNA : IEquatable<LPICOBPFPNA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public LHNHNFAONOD NJBGKNJCFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(LHNHNFAONOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public FDLKIDLAABP LOMBCMGOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private INHGBAEAGHP JJDEFEEBFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5D52D00", Offset = "0x5D52100", VA = "0x185D52D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private GNGBPCPDDMI OHMNMMPCAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5D5D840", Offset = "0x5D5CC40", VA = "0x185D5D840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private NMDHGCKCBIM HMAOLJDKMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5D5D750", Offset = "0x5D5CB50", VA = "0x185D5D750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public LHNHNFAONOD FIMKKOKGMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5D5D7B0", Offset = "0x5D5CBB0", VA = "0x185D5D7B0")]
		get
		{
			return default(LHNHNFAONOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public FDLKIDLAABP NCEKKJFNJNC
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5D5D470", Offset = "0x5D5C870", VA = "0x185D5D470")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public FDLKIDLAABP DFDPGOHHPEM
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5D5D500", Offset = "0x5D5C900", VA = "0x185D5D500")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50")]
	public LPICOBPFPNA(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5D5D590", Offset = "0x5D5C990", VA = "0x185D5D590", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "4")]
	public bool Equals(LPICOBPFPNA LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CE0", Offset = "0x5D510E0", VA = "0x185D51CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5D5D620", Offset = "0x5D5CA20", VA = "0x185D5D620")]
	public bool HEBPNKMJKGE(FDLKIDLAABP EBFCMPBKGBM, bool PANNPBLEODG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5D5D8D0", Offset = "0x5D5CCD0", VA = "0x185D5D8D0")]
	public bool MLAEFHBCNIM(FDLKIDLAABP MGPFGPKIGND)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct JFBHNIMMHOL : IEquatable<JFBHNIMMHOL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public FDLKIDLAABP LOMBCMGOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public string CDPBNEAFHPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5D57FC0", Offset = "0x5D573C0", VA = "0x185D57FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public string MBFKBNIJCAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x5D58610", Offset = "0x5D57A10", VA = "0x185D58610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private bool EOKOOAGBBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5D586B0", Offset = "0x5D57AB0", VA = "0x185D586B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public string MNOMFPKJFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x5D58B50", Offset = "0x5D57F50", VA = "0x185D58B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public string FNFAOBLHKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x5D587C0", Offset = "0x5D57BC0", VA = "0x185D587C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public string DBJKDIBCBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5D58AA0", Offset = "0x5D57EA0", VA = "0x185D58AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50")]
	public JFBHNIMMHOL(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5D58A10", Offset = "0x5D57E10", VA = "0x185D58A10", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "4")]
	public bool Equals(JFBHNIMMHOL LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CE0", Offset = "0x5D510E0", VA = "0x185D51CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x5D58040", Offset = "0x5D57440", VA = "0x185D58040")]
	private static string CMIGHELMPBG(JMFEOGDEHDH JPANLJJIADG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct EKPJDCNFMPI : IEquatable<EKPJDCNFMPI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public FDLKIDLAABP LOMBCMGOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5D54990", Offset = "0x5D53D90", VA = "0x185D54990", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "4")]
	public bool Equals(EKPJDCNFMPI LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CE0", Offset = "0x5D510E0", VA = "0x185D51CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct AAJDPEBBPFH : IEquatable<AAJDPEBBPFH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public FDLKIDLAABP LOMBCMGOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50")]
	public AAJDPEBBPFH(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5D51AA0", Offset = "0x5D50EA0", VA = "0x185D51AA0", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "4")]
	public bool Equals(AAJDPEBBPFH LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CE0", Offset = "0x5D510E0", VA = "0x185D51CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B40", Offset = "0x5D50F40", VA = "0x185D51B40")]
	public bool FLGGMDCFJEI([Out] Collider LIMGOFLBOKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct FCFHKNJEJEJ : IEquatable<FCFHKNJEJEJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public LHNHNFAONOD NJBGKNJCFAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(LHNHNFAONOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public FDLKIDLAABP LOMBCMGOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private INHGBAEAGHP JJDEFEEBFNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x5D52D00", Offset = "0x5D52100", VA = "0x185D52D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private GNGBPCPDDMI OHMNMMPCAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5D55360", Offset = "0x5D54760", VA = "0x185D55360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private NCEPNHJOMND PLCMOGNFEEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5D557F0", Offset = "0x5D54BF0", VA = "0x185D557F0")]
		get
		{
			return default(NCEPNHJOMND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool MOGOFGEODLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5D55320", Offset = "0x5D54720", VA = "0x185D55320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool DBFMIMDOKJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5D55780", Offset = "0x5D54B80", VA = "0x185D55780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool POFPHFGOEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x5D54D30", Offset = "0x5D54130", VA = "0x185D54D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool LDLDNMMNFKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x5D54F90", Offset = "0x5D54390", VA = "0x185D54F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool DODMPECBPDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x5D55990", Offset = "0x5D54D90", VA = "0x185D55990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool JOHFCMPNGIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x5D558C0", Offset = "0x5D54CC0", VA = "0x185D558C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool ECMCPBJMBNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x5D55240", Offset = "0x5D54640", VA = "0x185D55240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool GHPDGGGPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x5D552B0", Offset = "0x5D546B0", VA = "0x185D552B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool ACFPDMCOEEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x5D54DA0", Offset = "0x5D541A0", VA = "0x185D54DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool PCAHDGEGLPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x5D55850", Offset = "0x5D54C50", VA = "0x185D55850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool CJPAPILEOPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x5D556A0", Offset = "0x5D54AA0", VA = "0x185D556A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool IBICHOHEAFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x5D55710", Offset = "0x5D54B10", VA = "0x185D55710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool CBGFEFGKLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x5D551D0", Offset = "0x5D545D0", VA = "0x185D551D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool PCIJGLPNBBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x5D54C30", Offset = "0x5D54030", VA = "0x185D54C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool BCNMJFDKGPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5D54B40", Offset = "0x5D53F40", VA = "0x185D54B40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x5D55460", Offset = "0x5D54860", VA = "0x185D55460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool HDDCNJGFLIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x5D554D0", Offset = "0x5D548D0", VA = "0x185D554D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public HIKIIHDHHAA AKEHFOLFGJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x5D55930", Offset = "0x5D54D30", VA = "0x185D55930")]
		get
		{
			return default(HIKIIHDHHAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool NIKKILGFLIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x5D54F30", Offset = "0x5D54330", VA = "0x185D54F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public Vector3 CANDKNINJAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x5D55100", Offset = "0x5D54500", VA = "0x185D55100")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public Vector3 LCBGCBCIJNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x5D54E10", Offset = "0x5D54210", VA = "0x185D54E10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool GIPIIPFNPKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x5D55000", Offset = "0x5D54400", VA = "0x185D55000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50")]
	public FCFHKNJEJEJ(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5D54CA0", Offset = "0x5D540A0", VA = "0x185D54CA0", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "4")]
	public bool Equals(FCFHKNJEJEJ LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CE0", Offset = "0x5D510E0", VA = "0x185D51CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5D553F0", Offset = "0x5D547F0", VA = "0x185D553F0")]
	public bool MDCFFHNKAJI(JPPEPEIKMNE MIIJFFOGLNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5D54EC0", Offset = "0x5D542C0", VA = "0x185D54EC0")]
	public bool HNENBNACAMM(BFOJEBGGLIC MIIJFFOGLNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x5D54BB0", Offset = "0x5D53FB0", VA = "0x185D54BB0")]
	public void BLAOCJGCKPB(BFOJEBGGLIC MIIJFFOGLNG, bool MBDDGEBPNPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct IBHCKDDJCLA : IEquatable<IBHCKDDJCLA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public LHNHNFAONOD NJBGKNJCFAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(LHNHNFAONOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public FDLKIDLAABP LOMBCMGOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private INHGBAEAGHP JJDEFEEBFNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5D52D00", Offset = "0x5D52100", VA = "0x185D52D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private GNGBPCPDDMI OHMNMMPCAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5D57710", Offset = "0x5D56B10", VA = "0x185D57710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50")]
	public IBHCKDDJCLA(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5D575F0", Offset = "0x5D569F0", VA = "0x185D575F0", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "4")]
	public bool Equals(IBHCKDDJCLA LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CE0", Offset = "0x5D510E0", VA = "0x185D51CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5D57680", Offset = "0x5D56A80", VA = "0x185D57680")]
	public void JOCHLFPDDND(bool EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5D57560", Offset = "0x5D56960", VA = "0x185D57560")]
	public void EPGINAPDJGB(bool EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x23B0AC0", Offset = "0x23AFEC0", VA = "0x1823B0AC0")]
	public T IBMONKFPCGE<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct BHLIJHOGNDD : IEquatable<BHLIJHOGNDD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public LHNHNFAONOD NJBGKNJCFAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(LHNHNFAONOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public FDLKIDLAABP LOMBCMGOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private INHGBAEAGHP JJDEFEEBFNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5D52D00", Offset = "0x5D52100", VA = "0x185D52D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private GNGBPCPDDMI OHMNMMPCAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5D52910", Offset = "0x5D51D10", VA = "0x185D52910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	private AAJHNHAHHBB MLOLCIAAHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5D52530", Offset = "0x5D51930", VA = "0x185D52530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool AALEPNHGOIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5D52C40", Offset = "0x5D52040", VA = "0x185D52C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool JLEHLMLHAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5D52BA0", Offset = "0x5D51FA0", VA = "0x185D52BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool MFLIIFLJHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5D52500", Offset = "0x5D51900", VA = "0x185D52500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool LJEEKAJAMAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x5D52FE0", Offset = "0x5D523E0", VA = "0x185D52FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool ANNMKADHEKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x5D52CD0", Offset = "0x5D520D0", VA = "0x185D52CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool NPLPGEABKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x5D52B10", Offset = "0x5D51F10", VA = "0x185D52B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool PLDHDOGHBKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x5D52D60", Offset = "0x5D52160", VA = "0x185D52D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool ACBPGGAAAGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5D529A0", Offset = "0x5D51DA0", VA = "0x185D529A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50")]
	public BHLIJHOGNDD(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5D52590", Offset = "0x5D51990", VA = "0x185D52590")]
	public static bool BNPEICKPPJA(BHLIJHOGNDD EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5D526C0", Offset = "0x5D51AC0", VA = "0x185D526C0", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "4")]
	public bool Equals(BHLIJHOGNDD LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CE0", Offset = "0x5D510E0", VA = "0x185D51CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x5D527F0", Offset = "0x5D51BF0", VA = "0x185D527F0")]
	public bool KLFBOFDKPCL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5D52750", Offset = "0x5D51B50", VA = "0x185D52750")]
	public FDLKIDLAABP FBMKFJLMKPM(FDLKIDLAABP BGICHGONLEL)
	{
		return default(FDLKIDLAABP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x5D525B0", Offset = "0x5D519B0", VA = "0x185D525B0")]
	public LHNHNFAONOD EMPJFKKOFEL()
	{
		return default(LHNHNFAONOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct MNMABBGFKEB : IEquatable<MNMABBGFKEB>
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly MNMABBGFKEB GIHJJMPCPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public LHNHNFAONOD NJBGKNJCFAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(LHNHNFAONOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public FDLKIDLAABP LOMBCMGOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public LMJHNLCIBDO JGKOKOJENGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(LMJHNLCIBDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private MBNMAFLFCDH OACEKLMPFID
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5D5F100", Offset = "0x5D5E500", VA = "0x185D5F100")]
		get
		{
			return default(MBNMAFLFCDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public NLEIJFNBAHO ILCOBADPCCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5D5F250", Offset = "0x5D5E650", VA = "0x185D5F250")]
		get
		{
			return default(NLEIJFNBAHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public JFDPKNIIPBB AMBNJGKHDFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5D5EF60", Offset = "0x5D5E360", VA = "0x185D5EF60")]
		get
		{
			return default(JFDPKNIIPBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public LMBMBPGOIPJ EAAKDKCONIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5D5F0A0", Offset = "0x5D5E4A0", VA = "0x185D5F0A0")]
		get
		{
			return default(LMBMBPGOIPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public JKKGODIJMHG BNDDFKBDMCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x5D5EEF0", Offset = "0x5D5E2F0", VA = "0x185D5EEF0")]
		get
		{
			return default(JKKGODIJMHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public CHMJHOOAACL FEPKEELHEIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x5D5F410", Offset = "0x5D5E810", VA = "0x185D5F410")]
		get
		{
			return default(CHMJHOOAACL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x5D5EFC0", Offset = "0x5D5E3C0", VA = "0x185D5EFC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public LMFHKGGHMJL FLCAGAFJEAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x5D5F330", Offset = "0x5D5E730", VA = "0x185D5F330")]
		get
		{
			return default(LMFHKGGHMJL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x5D5ECA0", Offset = "0x5D5E0A0", VA = "0x185D5ECA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public float GNFPEILGEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x5D5F470", Offset = "0x5D5E870", VA = "0x185D5F470")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x5D5EDF0", Offset = "0x5D5E1F0", VA = "0x185D5EDF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public Vector3 JIHMKEJAPOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x5D5F390", Offset = "0x5D5E790", VA = "0x185D5F390")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5D5F1D0", Offset = "0x5D5E5D0", VA = "0x185D5F1D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public float EKODBABBNDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x5D5F030", Offset = "0x5D5E430", VA = "0x185D5F030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public EKEKCBCPHMC.MGEELPGJGMM ABEININOONN
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5D5ED90", Offset = "0x5D5E190", VA = "0x185D5ED90")]
		get
		{
			return default(EKEKCBCPHMC.MGEELPGJGMM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5D5F160", Offset = "0x5D5E560", VA = "0x185D5F160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50")]
	public MNMABBGFKEB(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5D52590", Offset = "0x5D51990", VA = "0x185D52590")]
	public static bool BNPEICKPPJA(MNMABBGFKEB EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5D5EE60", Offset = "0x5D5E260", VA = "0x185D5EE60", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "4")]
	public bool Equals(MNMABBGFKEB LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CE0", Offset = "0x5D510E0", VA = "0x185D51CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5D5F2B0", Offset = "0x5D5E6B0", VA = "0x185D5F2B0")]
	public IDMBOMOIAMC LCACEAKNMLJ()
	{
		return default(IDMBOMOIAMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5D5ED10", Offset = "0x5D5E110", VA = "0x185D5ED10")]
	public JKEKDMMJELC CMJPBKMHCJA()
	{
		return default(JKEKDMMJELC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct IDMBOMOIAMC : IEquatable<IDMBOMOIAMC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public LHNHNFAONOD NJBGKNJCFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(LHNHNFAONOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public FDLKIDLAABP LOMBCMGOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public MNMABBGFKEB HIFJOFBHHAD
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(MNMABBGFKEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private FEFGKKPLBEP KLOFEFLPNJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x5D57920", Offset = "0x5D56D20", VA = "0x185D57920")]
		get
		{
			return default(FEFGKKPLBEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public AFADFPDANEE OJMLHOAPMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x5D57A10", Offset = "0x5D56E10", VA = "0x185D57A10")]
		get
		{
			return default(AFADFPDANEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50")]
	public IDMBOMOIAMC(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5D52590", Offset = "0x5D51990", VA = "0x185D52590")]
	public static bool BNPEICKPPJA(IDMBOMOIAMC EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x5D57980", Offset = "0x5D56D80", VA = "0x185D57980", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "4")]
	public bool Equals(IDMBOMOIAMC LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CE0", Offset = "0x5D510E0", VA = "0x185D51CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[DefaultMember("Item")]
public readonly struct JKEKDMMJELC : IEquatable<JKEKDMMJELC>
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly JKEKDMMJELC GIHJJMPCPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public LHNHNFAONOD NJBGKNJCFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(LHNHNFAONOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public FDLKIDLAABP LOMBCMGOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public LMJHNLCIBDO JGKOKOJENGE
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(LMJHNLCIBDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private INHGBAEAGHP JJDEFEEBFNC
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x5D52D00", Offset = "0x5D52100", VA = "0x185D52D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private GNGBPCPDDMI OHMNMMPCAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x5D59730", Offset = "0x5D58B30", VA = "0x185D59730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private JIIJKCLIHFI BOHNEDDGBBD
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x5D597C0", Offset = "0x5D58BC0", VA = "0x185D597C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public MNMABBGFKEB HIFJOFBHHAD
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(MNMABBGFKEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public MHNILHILJOG HMKIBPFDLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5D593F0", Offset = "0x5D587F0", VA = "0x185D593F0")]
		get
		{
			return default(MHNILHILJOG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5D58DF0", Offset = "0x5D581F0", VA = "0x185D58DF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public IEnumerable<GKEFLMPEGBC> EJKLMMOPBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5D59520", Offset = "0x5D58920", VA = "0x185D59520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public GKEFLMPEGBC LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5D58FA0", Offset = "0x5D583A0", VA = "0x185D58FA0")]
		get
		{
			return default(GKEFLMPEGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x5D58D60", Offset = "0x5D58160", VA = "0x185D58D60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50")]
	public JKEKDMMJELC(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5D52590", Offset = "0x5D51990", VA = "0x185D52590")]
	public static bool BNPEICKPPJA(JKEKDMMJELC EOHMJBFGDPD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5D560B0", Offset = "0x5D554B0", VA = "0x185D560B0")]
	public static bool MEMFAJGIIAO(JKEKDMMJELC IFAOGMEBPFN, JKEKDMMJELC DNPBOPMFFFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5D58F10", Offset = "0x5D58310", VA = "0x185D58F10", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "4")]
	public bool Equals(JKEKDMMJELC LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CE0", Offset = "0x5D510E0", VA = "0x185D51CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x5D59820", Offset = "0x5D58C20", VA = "0x185D59820")]
	public GKEFLMPEGBC PFCEOOPOAEA(float3? LPAPEIIOLFG, [Optional] quaternion? KBKHJHIFKGI, [Optional] Vector3? NMGPAHAPPCF)
	{
		return default(GKEFLMPEGBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x5D590B0", Offset = "0x5D584B0", VA = "0x185D590B0")]
	public GKEFLMPEGBC IAPFJMIKAIG(int APOENOPNHBG, float3? LPAPEIIOLFG, [Optional] quaternion? KBKHJHIFKGI, [Optional] Vector3? NMGPAHAPPCF)
	{
		return default(GKEFLMPEGBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5D592E0", Offset = "0x5D586E0", VA = "0x185D592E0")]
	public void JKEBLLDCMHE(int APOENOPNHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x5D58CD0", Offset = "0x5D580D0", VA = "0x185D58CD0")]
	public void BPHEMFKLBDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct GKEFLMPEGBC : IEquatable<GKEFLMPEGBC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public LHNHNFAONOD NJBGKNJCFAM
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(LHNHNFAONOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public FDLKIDLAABP LOMBCMGOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public JKEKDMMJELC PGLNFONEKJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x5D56830", Offset = "0x5D55C30", VA = "0x185D56830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public float3 MKJKOHNLCOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x5D567B0", Offset = "0x5D55BB0", VA = "0x185D567B0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x5D56C50", Offset = "0x5D56050", VA = "0x185D56C50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public quaternion OIFBJHBHDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x5D56BD0", Offset = "0x5D55FD0", VA = "0x185D56BD0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x5D56A30", Offset = "0x5D55E30", VA = "0x185D56A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public float3 NJHIHNHHHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x5D568C0", Offset = "0x5D55CC0", VA = "0x185D568C0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x5D56D90", Offset = "0x5D56190", VA = "0x185D56D90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public NHDPLENDLGL AJPIOCAAFGD
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x5D56B00", Offset = "0x5D55F00", VA = "0x185D56B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private JNPMAPMPDHI MAHFEHEDOAM
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5D56D30", Offset = "0x5D56130", VA = "0x185D56D30")]
		get
		{
			return default(JNPMAPMPDHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	private MAJDHNCHDAM OGHPFGLCEJI
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x5D56940", Offset = "0x5D55D40", VA = "0x185D56940")]
		get
		{
			return default(MAJDHNCHDAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	private FMJLPJGMNKI EKJGFEFFNCI
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5D56B70", Offset = "0x5D55F70", VA = "0x185D56B70")]
		get
		{
			return default(FMJLPJGMNKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	private HMMMAHPBGEF IEKMEAHLKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x5D56AA0", Offset = "0x5D55EA0", VA = "0x185D56AA0")]
		get
		{
			return default(HMMMAHPBGEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	private JFNKPKBJOCF IJBJPCPHJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5D56CD0", Offset = "0x5D560D0", VA = "0x185D56CD0")]
		get
		{
			return default(JFNKPKBJOCF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50")]
	public GKEFLMPEGBC(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x5D569A0", Offset = "0x5D55DA0", VA = "0x185D569A0", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "4")]
	public bool Equals(GKEFLMPEGBC LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CE0", Offset = "0x5D510E0", VA = "0x185D51CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x5D56830", Offset = "0x5D55C30", VA = "0x185D56830")]
	public void FOCONCBINBE(JKEKDMMJELC EOHMJBFGDPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct LMJHNLCIBDO : IEquatable<LMJHNLCIBDO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public FDLKIDLAABP LOMBCMGOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	private INHGBAEAGHP JJDEFEEBFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x5D52D00", Offset = "0x5D52100", VA = "0x185D52D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	private KFJHDAOPGPA EEMACIMJBFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x5D5C380", Offset = "0x5D5B780", VA = "0x185D5C380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public bool FJODFMKLCML
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x5D5BA00", Offset = "0x5D5AE00", VA = "0x185D5BA00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public Vector3 MKJKOHNLCOL
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5D5B300", Offset = "0x5D5A700", VA = "0x185D5B300")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5D5C590", Offset = "0x5D5B990", VA = "0x185D5C590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public Quaternion OIFBJHBHDIL
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5D5C440", Offset = "0x5D5B840", VA = "0x185D5C440")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x5D5BD40", Offset = "0x5D5B140", VA = "0x185D5BD40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 BFIMMMNJJEB
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x5D5CF70", Offset = "0x5D5C370", VA = "0x185D5CF70")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x5D5B160", Offset = "0x5D5A560", VA = "0x185D5B160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Quaternion EOOPIAMLFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x5D5C8F0", Offset = "0x5D5BCF0", VA = "0x185D5C8F0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x5D5D060", Offset = "0x5D5C460", VA = "0x185D5D060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public float DLDGBIHEMNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x5D5C2E0", Offset = "0x5D5B6E0", VA = "0x185D5C2E0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x5D5D130", Offset = "0x5D5C530", VA = "0x185D5D130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public float LHDFLHMPEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x5D5B630", Offset = "0x5D5AA30", VA = "0x185D5B630")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public Vector3 NJHIHNHHHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x5D5B840", Offset = "0x5D5AC40", VA = "0x185D5B840")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x5D5D2D0", Offset = "0x5D5C6D0", VA = "0x185D5D2D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public Vector3 LBCCPCLKJAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x5D5D1E0", Offset = "0x5D5C5E0", VA = "0x185D5D1E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public Matrix4x4 PKKIFJHGEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x5D5BA40", Offset = "0x5D5AE40", VA = "0x185D5BA40")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50")]
	public LMJHNLCIBDO(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x5D5BCB0", Offset = "0x5D5B0B0", VA = "0x185D5BCB0", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "4")]
	public bool Equals(LMJHNLCIBDO LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CE0", Offset = "0x5D510E0", VA = "0x185D51CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5D5BB70", Offset = "0x5D5AF70", VA = "0x185D5BB70")]
	public FJPDIMNMGMC DNHFPMPPALP()
	{
		return default(FJPDIMNMGMC);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x5D5CC50", Offset = "0x5D5C050", VA = "0x185D5CC50")]
	public void MKHADFDLIAI([Out] Matrix4x4 HADNJFPICLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x5D5CB10", Offset = "0x5D5BF10", VA = "0x185D5CB10")]
	public void MBIOPMBABME([Out] Vector3 IHKNCEFBKKJ, [Out] Quaternion OMOAGEFECGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x5D5C840", Offset = "0x5D5BC40", VA = "0x185D5C840")]
	public void LOOLBJMMENL([Out] RigidTransform HCAELKBLCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5D5BB40", Offset = "0x5D5AF40", VA = "0x185D5BB40")]
	public EKDOHGHOOFO DMCKIAGKOFE()
	{
		return default(EKDOHGHOOFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x5D5BA80", Offset = "0x5D5AE80", VA = "0x185D5BA80")]
	public void DMCKIAGKOFE([Out] EKDOHGHOOFO CENNAHINDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x5D5C0F0", Offset = "0x5D5B4F0", VA = "0x185D5C0F0")]
	public EKDOHGHOOFO GEJBDHDOBOF()
	{
		return default(EKDOHGHOOFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x5D5C030", Offset = "0x5D5B430", VA = "0x185D5C030")]
	public void GEJBDHDOBOF([Out] EKDOHGHOOFO HCAELKBLCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x5D5BBC0", Offset = "0x5D5AFC0", VA = "0x185D5BBC0")]
	public Vector3 EMKLLIFBIHI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x5D5BF60", Offset = "0x5D5B360", VA = "0x185D5BF60")]
	public void FHGIOMOOJOM([In] Vector3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x5D5C660", Offset = "0x5D5BA60", VA = "0x185D5C660")]
	public Vector3 JJDGJNMDPEO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x5D5B090", Offset = "0x5D5A490", VA = "0x185D5B090")]
	public void AABNFNFJOED([In] Vector3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x5D5BE10", Offset = "0x5D5B210", VA = "0x185D5BE10")]
	public Quaternion FGCBMPPKJED()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x5D5CA40", Offset = "0x5D5BE40", VA = "0x185D5CA40")]
	public void MBBPIMFGAGK([In] Quaternion EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x5D5B3F0", Offset = "0x5D5A7F0", VA = "0x185D5B3F0")]
	public Quaternion AMIMBCINAKN()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x5D5B930", Offset = "0x5D5AD30", VA = "0x185D5B930")]
	public void CLGOCGLCHLF([In] Quaternion EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x5D5B6D0", Offset = "0x5D5AAD0", VA = "0x185D5B6D0")]
	public float BEJMJFDAAOG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x5D5CE10", Offset = "0x5D5C210", VA = "0x185D5CE10")]
	public void NCPALADIGEO(float EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x5D5CD70", Offset = "0x5D5C170", VA = "0x185D5CD70")]
	public float MPGNDNOGEJD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x5D5CEC0", Offset = "0x5D5C2C0", VA = "0x185D5CEC0")]
	public void NFGLIJNOKKA(float EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x5D5C120", Offset = "0x5D5B520", VA = "0x185D5C120")]
	public void GNNOCLCGJFD([In] Vector3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x5D5C1F0", Offset = "0x5D5B5F0", VA = "0x185D5C1F0")]
	public Vector3 GNOLJMBOIBB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x5D5B770", Offset = "0x5D5AB70", VA = "0x185D5B770")]
	public void BIOJKOBIMEI([In] Vector3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x5D5B540", Offset = "0x5D5A940", VA = "0x185D5B540")]
	public Vector3 BBHMKJIBMJJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x5D5B230", Offset = "0x5D5A630", VA = "0x185D5B230")]
	public void AENFGGIMCKH([In] Vector3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x5D5C750", Offset = "0x5D5BB50", VA = "0x185D5C750")]
	public Vector3 JKAGHHMENCF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x5D5D3A0", Offset = "0x5D5C7A0", VA = "0x185D5D3A0")]
	public void PGHNOELEANF([In] Vector3 EOHMJBFGDPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct ICEJGNLJBIG : IEquatable<ICEJGNLJBIG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public LHNHNFAONOD NJBGKNJCFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(LHNHNFAONOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public FDLKIDLAABP LOMBCMGOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public int[] BIIKCOJPFLM
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x5D57830", Offset = "0x5D56C30", VA = "0x185D57830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50")]
	public ICEJGNLJBIG(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D510B0", VA = "0x185D51CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x5D577A0", Offset = "0x5D56BA0", VA = "0x185D577A0", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B30", Offset = "0x5D50F30", VA = "0x185D51B30", Slot = "4")]
	public bool Equals(ICEJGNLJBIG LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CE0", Offset = "0x5D510E0", VA = "0x185D51CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class OOHGMAFHNOJ
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct FBDFCNFOCNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid OGGNLGCIGBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public GDLOOLAHPMK LKMFMKHMFHD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct GDLOOLAHPMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int EOHMJBFGDPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int CEKDDEJPAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int KKBCODKDAOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int PGBCICKHJFF;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x5D56710", Offset = "0x5D55B10", VA = "0x185D56710")]
		public bool MGOHCEIGIFH([Out] IJFILFNCAOA JNPKHIBFGKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x5D56790", Offset = "0x5D55B90", VA = "0x185D56790")]
		public GDLOOLAHPMK(IJFILFNCAOA JNPKHIBFGKN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x5D603C0", Offset = "0x5D5F7C0", VA = "0x185D603C0")]
	public static Guid NDKFOJGIIPA(this IJFILFNCAOA JNPKHIBFGKN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x5D603A0", Offset = "0x5D5F7A0", VA = "0x185D603A0")]
	public static bool HIEAMCOCHME(this Guid OGGNLGCIGBJ, [Out] IJFILFNCAOA JNPKHIBFGKN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal static class JEAAKOCDOMH
{
	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x5D57F30", Offset = "0x5D57330", VA = "0x185D57F30")]
	public static GNGBPCPDDMI OHMNMMPCAFJ(this LHNHNFAONOD PIKCMFPLBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x5D57D60", Offset = "0x5D57160", VA = "0x185D57D60")]
	public static IMHPKNCJCOD KLNOCOBGHJG(this LHNHNFAONOD PIKCMFPLBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x5D57E30", Offset = "0x5D57230", VA = "0x185D57E30")]
	public static EntityManager NAALHPNIIKC(this LHNHNFAONOD PIKCMFPLBNL)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x23EFE30", Offset = "0x23EF230", VA = "0x1823EFE30")]
	public static T HBNFIFKIBCC<T>(this LHNHNFAONOD PIKCMFPLBNL) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x23F0CD0", Offset = "0x23F00D0", VA = "0x1823F0CD0")]
	public static bool IKPCJMGBDAL<T>(this LHNHNFAONOD PIKCMFPLBNL) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface KCGPOJECAHP
{
	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BLKAPNOLDPL(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BCPAMGCFCJA(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LFMJNBOLLJF(LHNHNFAONOD PIBFDGEOBKF, [Out] Guid PDHLDIFODOP);

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid KBJIENCFAFN(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BOBKCCPBOGP(LHNHNFAONOD PIBFDGEOBKF, Guid PDHLDIFODOP);

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OBCEOACDMOI(LHNHNFAONOD PIBFDGEOBKF, [Out] Guid EKIGMNBCJDB);

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid DEDMACFGKJK(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HGMECABFBME(LHNHNFAONOD PIBFDGEOBKF, Guid EKIGMNBCJDB);

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NFMBMIJNPEP(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HEIJOJEDKOM(LHNHNFAONOD JHAODPLJNCN, LHNHNFAONOD EBFCMPBKGBM);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public interface EMNPAEAJLNA
{
	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	Guid IKCLCFFALLN
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MMBDOAMHALC(Guid PDHLDIFODOP, Guid EKIGMNBCJDB, string LFAIHEECJFK);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface CCCMOPCHHIG
{
	[Cpp2IlInjected.Token(Token = "0x17000110")]
	IReadOnlyCollection<FKMDJINEHMO> FLPDMOCOECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HJKCFIGGHJO(int PIEALCBDGOA, [Out] FKMDJINEHMO HOGACIGOPKL);

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FKMDJINEHMO HBCLLHKOGEL(Type IJFAMCPOKBO);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class MBHBHJJFOFN
{
	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x2469CF0", Offset = "0x24690F0", VA = "0x182469CF0")]
	public static T BEPMDIGLCAC<T>(this CCCMOPCHHIG GKMLAKMFINK, Entity FILKDLNBIJH) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x2469D90", Offset = "0x2469190", VA = "0x182469D90")]
	public static FKMDJINEHMO HBCLLHKOGEL<T>(this CCCMOPCHHIG GKMLAKMFINK) where T : struct, IComponent
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface PPDPMAOOACO
{
	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IJFILFNCAOA[] MBCOBOICKFL(string LFAIHEECJFK, FDLKIDLAABP DCLLGDLJCDH, bool CPLDJDAKCIM = false);

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HADILHNEJHB(string HFCKFJICBCH, IJFILFNCAOA[] OMNMPNPKGPB);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public interface FINDIDOCBAK
{
	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<LHNHNFAONOD, LHNHNFAONOD> KOMJCMDLJNM;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<LHNHNFAONOD, LHNHNFAONOD> KAKPMHHCILH;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<LHNHNFAONOD, LHNHNFAONOD, LHNHNFAONOD> CAKBDKPBFAG;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<LHNHNFAONOD> DIBLOCNAECE;

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JHGDDIBIACA(LHNHNFAONOD PIBFDGEOBKF, LHNHNFAONOD KBPCHFHDIBM);

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LHNHNFAONOD DHLPIOCFDEA(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<LHNHNFAONOD> GPMBMCMDHDC(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LHNHNFAONOD BENGNMIJNMG(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GNLGFEENMGJ(LHNHNFAONOD PIBFDGEOBKF, Vector3 KCJMDKMCCLM, Quaternion NIFBONPNAFO);

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NEPHBJDBLEL(LHNHNFAONOD PIBFDGEOBKF, float BKLOJAMMHDA);

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool LFDJFJNGAPG(LHNHNFAONOD PIBFDGEOBKF, [Out] RigidTransform HGDMPDAHIGI);

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool AMAKJOPGGFN(LHNHNFAONOD PIBFDGEOBKF, [Out] float EHGBMIPCMNM);

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 GGAMGHMJKEP(PEILNHFAGGO AAINKMJJJEG);

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion MDLMBNDBEAH(PEILNHFAGGO AAINKMJJJEG);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class BNFKGODEICB
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public interface NAPCKLFHLCM
{
	[Cpp2IlInjected.Token(Token = "0x17000111")]
	object GGNBFIBDLPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MMHGIGLHJAB(DLCLMIEPGBN GAKOOBMLEII);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum DJCLMCCBNGM
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class DFDGENKNALL
{
	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0xA8FEF0", Offset = "0xA8F2F0", VA = "0x180A8FEF0")]
	public static bool BHPMLHMDFIH(this DJCLMCCBNGM JEPPHOGINNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0xA8FEE0", Offset = "0xA8F2E0", VA = "0x180A8FEE0")]
	public static bool FBIMPGBIFBB(this DJCLMCCBNGM JEPPHOGINNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF950", Offset = "0x1FEED50", VA = "0x181FEF950")]
	public static bool KNJDKEAIGKJ(this DJCLMCCBNGM JEPPHOGINNJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface PMPMJLEMOAG
{
	[Cpp2IlInjected.Token(Token = "0x17000112")]
	DJCLMCCBNGM GMFGGIPNMCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	DJCLMCCBNGM PMCLJDDACFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	DJCLMCCBNGM BJDGLOACJDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	DJCLMCCBNGM GFOOEPCPPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	DJCLMCCBNGM GJHBAHDGHAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	DJCLMCCBNGM PEEABEPDGOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	DJCLMCCBNGM ELKECBPOJFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	DJCLMCCBNGM CBLEMNAMGBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	DJCLMCCBNGM NCLGNNCBIAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	DJCLMCCBNGM CCDBGLNJIEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	DJCLMCCBNGM CGIINMFIJEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	DJCLMCCBNGM CNPGAFNAFOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface NMDHGCKCBIM
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<HDHIDMCJGCD> FENGFCMOPKC;

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LHNHNFAONOD NKAFPNBHAEE(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CBGNFIEJFNP(List<LHNHNFAONOD> BJEJBGEKBMB);

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LHNHNFAONOD OBHLIPJDBGF(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HEBPNKMJKGE(LHNHNFAONOD PIBFDGEOBKF, LHNHNFAONOD EBFCMPBKGBM, bool PANNPBLEODG);

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LJDLEFCDHAM(LHNHNFAONOD PIBFDGEOBKF, LHNHNFAONOD EBFCMPBKGBM);

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int DBNHBIOACAG(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DLCLMIEPGBN EPALCICOBFP(LHNHNFAONOD GIPGBEGNLCD);

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool FLFPNBFPDPC(LHNHNFAONOD PIBFDGEOBKF, LHNHNFAONOD DFAAINNDBBH);

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MLAEFHBCNIM(LHNHNFAONOD PIBFDGEOBKF, LHNHNFAONOD MGPFGPKIGND);

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LHNHNFAONOD BOFEBEAMOOA(LHNHNFAONOD BGICHGONLEL, LHNHNFAONOD AGPMPKBMMOB);

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GKMCHOHAPGM(LHNHNFAONOD BGICHGONLEL, LHNHNFAONOD AGPMPKBMMOB, [Out] LHNHNFAONOD MAKPPJALCAB);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class KIBDJMBIIJG
{
	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x5D5A3C0", Offset = "0x5D597C0", VA = "0x185D5A3C0")]
	public static List<LHNHNFAONOD> CBGNFIEJFNP(this NMDHGCKCBIM BEOJNJDKKFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x5D5A4D0", Offset = "0x5D598D0", VA = "0x185D5A4D0")]
	public static bool EKDOCCFKAGJ(this NMDHGCKCBIM BEOJNJDKKFM, LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public interface NHPFFAEKKJH
{
	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	bool EDALKLENKLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	bool HBBGOMGHLGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface FGAHOPPNDBO : PCIIECOCADI
{
	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LAPKFFFPOAD PLNAIKEGLDI(Entity FILKDLNBIJH);

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BEEJDJFKAKD(NativeArray<LAPKFFFPOAD> AGMEADBOBGM, NativeArray<CMLIFCOKLLM> OFKFPFOEFJA);

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EHAJAAOIMIF(LAPKFFFPOAD DELBIPHKFDD);

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MMLJKBBAMCB(LAPKFFFPOAD DELBIPHKFDD, [Out] Collider LIMGOFLBOKH);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public interface PCIIECOCADI
{
	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NNJLPEJLDHA([In] float3 HJGLLCKAOEB, [In] float3 PIOPMIBANBL, float EJKOOCGEPCD, Allocator KIKFOGPECEC, [Out] NativeArray<Entity> BAPHNAADJCK);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public interface DPBFPLBNLLG
{
	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NNJLPEJLDHA([In] float3 HJGLLCKAOEB, [In] float3 PIOPMIBANBL, float EJKOOCGEPCD, [Out] IKAHLCGAFCI PFKOENMJOPI, [Out] LHNHNFAONOD ACICFHDBOLC);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public interface KHFEJHGDIKF
{
	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NNJLPEJLDHA([In] NativeArray<Entity> BAPHNAADJCK, [In] float3 HJGLLCKAOEB, [In] float3 PIOPMIBANBL, [In] NativeArray<IKAHLCGAFCI> PBLNGJMBFOH);
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct LAPKFFFPOAD : KNNNCNBLDBG, IEquatable<LAPKFFFPOAD>
{
	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public int CBNNNKAIBOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAD0", Offset = "0x7DEED0", VA = "0x1807DFAD0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAC0", Offset = "0x7DEEC0", VA = "0x1807DFAC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public int EIHKBEAJCFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x200C1F0", Offset = "0x200B5F0", VA = "0x18200C1F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x51828C0", Offset = "0x5181CC0", VA = "0x1851828C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x5D5A710", Offset = "0x5D59B10", VA = "0x185D5A710", Slot = "8")]
	public bool Equals(LAPKFFFPOAD LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x5D5A760", Offset = "0x5D59B60", VA = "0x185D5A760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct IKAHLCGAFCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float IEHLHGBKKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float3 MBCOBAGMLHO;
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface NFCMJBKKOLL
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface INHGBAEAGHP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000122")]
	GNGBPCPDDMI OHMNMMPCAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	PLGBKBNKNDI KPAPLDAGLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<DLCLMIEPGBN, NativeArray<JMFEOGDEHDH>> DNFDBJHGGBI;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<DLCLMIEPGBN> PIBIAANAPKJ;

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NGBPNMOBPJE MMNDAFMFLJH(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JMFEOGDEHDH PKPJNJIAHBH(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KIPDOAILNDA(IJFILFNCAOA JNPKHIBFGKN, PCCDMPNJHHD PIOJMHPNEKO);

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GAMIJMMLFLB(IJFILFNCAOA[] OMNMPNPKGPB, GameObject IPAGFDLNMDK);

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FDLKIDLAABP HFGJIPKOLGA(LHNHNFAONOD PIBFDGEOBKF, [Optional] object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool DHIPACEFKGL(LHNHNFAONOD PIBFDGEOBKF, [Out] PCCDMPNJHHD PIOJMHPNEKO);

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool LFEOLBBNFPA(LHNHNFAONOD PIBFDGEOBKF, [Out] Transform OLPLDGDFGHL);

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool HEIAMNBIGPH(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NOJOAOHGNKO(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool KJDJBAPPIFP(LocalId PIBFDGEOBKF, object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool DCPFEBKPKND(LocalId PIBFDGEOBKF, object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	LHNHNFAONOD OLOICJPHOFL(IJFILFNCAOA JNPKHIBFGKN);

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool KJMILBLALPL(IJFILFNCAOA JNPKHIBFGKN, [Out] LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IJFILFNCAOA GEMBKIKECJJ(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(Slot = "20")]
	DLCLMIEPGBN OLOICJPHOFL(NativeArray<IJFILFNCAOA> JNPKHIBFGKN, Allocator KIKFOGPECEC);

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(Slot = "21")]
	DLCLMIEPGBN NCFPNPLAFKO(NativeArray<IJFILFNCAOA> JNPKHIBFGKN, NativeArray<EIDGNLJLKDK> CHAFPPHFFEK, Allocator KIKFOGPECEC);

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(Slot = "22")]
	IJFILFNCAOA[] MBCOBOICKFL(string HFCKFJICBCH, FDLKIDLAABP DCLLGDLJCDH, bool CPLDJDAKCIM);

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void HADILHNEJHB(string HFCKFJICBCH, IJFILFNCAOA[] OMNMPNPKGPB);

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "24")]
	FDLKIDLAABP KKPKACBLAKD(JMFEOGDEHDH INONPCNKMNK, bool IABBDCHOAPD);

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "25")]
	FDLKIDLAABP KKPKACBLAKD(JMFEOGDEHDH INONPCNKMNK);

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(Slot = "26")]
	FDLKIDLAABP BFGFKICLJCL(JMFEOGDEHDH INONPCNKMNK);

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(Slot = "27")]
	FDLKIDLAABP CMFODKOPDHJ(JMFEOGDEHDH INONPCNKMNK);

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(Slot = "28")]
	FDLKIDLAABP NCFPNPLAFKO(IJFILFNCAOA JNPKHIBFGKN, JMFEOGDEHDH INONPCNKMNK);

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(Slot = "29")]
	MIMPJHHKPIA AJAACPDOBFL();

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(Slot = "30")]
	JKEKDMMJELC IGCCOCINEHG();

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IDMBOMOIAMC NGFJKKMDBAC(AFADFPDANEE DHJDPBPNKGC);

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void LEFNEIHNBJP(DLCLMIEPGBN GAKOOBMLEII);

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void FOEGEAAAFMJ(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void CJFFPOFKONJ(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void LEFNEIHNBJP(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(Slot = "36")]
	DLCLMIEPGBN IKFIBPFDHJJ(DLCLMIEPGBN FGKMGJALCKJ, Allocator KIKFOGPECEC);

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool AOKIEGPHIBB(LHNHNFAONOD PIBFDGEOBKF);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class CDOBPPKNLMI
{
	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5D536F0", Offset = "0x5D52AF0", VA = "0x185D536F0")]
	public static void NOJOAOHGNKO(this INHGBAEAGHP NMNJDGCCMMD, PCCDMPNJHHD PIOJMHPNEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5D53210", Offset = "0x5D52610", VA = "0x185D53210")]
	public static FDLKIDLAABP EBNIIIDFCKA(this INHGBAEAGHP NMNJDGCCMMD, LocalId PIBFDGEOBKF)
	{
		return default(FDLKIDLAABP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5D53210", Offset = "0x5D52610", VA = "0x185D53210")]
	public static LHNHNFAONOD OLOICJPHOFL(this INHGBAEAGHP NMNJDGCCMMD, LocalId PIBFDGEOBKF)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5D53240", Offset = "0x5D52640", VA = "0x185D53240")]
	public static IJFILFNCAOA GEMBKIKECJJ(this INHGBAEAGHP NMNJDGCCMMD, LocalId PIBFDGEOBKF)
	{
		return default(IJFILFNCAOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x5D53140", Offset = "0x5D52540", VA = "0x185D53140")]
	public static bool AOKIEGPHIBB(this INHGBAEAGHP NMNJDGCCMMD, IJFILFNCAOA JNPKHIBFGKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x22024F0", Offset = "0x22018F0", VA = "0x1822024F0")]
	public static T FBPGPEFKDJK<T>(this INHGBAEAGHP NMNJDGCCMMD, LocalId PIBFDGEOBKF) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x5D534E0", Offset = "0x5D528E0", VA = "0x185D534E0")]
	public static MIMPJHHKPIA KDPGOEFONLC(this INHGBAEAGHP NMNJDGCCMMD, RigidTransform CENNAHINDOO, [Optional] object KJAGMGIFCEM)
	{
		return default(MIMPJHHKPIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x5D535E0", Offset = "0x5D529E0", VA = "0x185D535E0")]
	public static IDMBOMOIAMC MIOKCJAJNBM(this INHGBAEAGHP NMNJDGCCMMD, AFADFPDANEE DONMFFDAEEC, RigidTransform CENNAHINDOO, [Optional] object KJAGMGIFCEM)
	{
		return default(IDMBOMOIAMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x5D53770", Offset = "0x5D52B70", VA = "0x185D53770")]
	public static JKEKDMMJELC PLPDMNJHAGB(this INHGBAEAGHP NMNJDGCCMMD, RigidTransform CENNAHINDOO, [Optional] object KJAGMGIFCEM)
	{
		return default(JKEKDMMJELC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x5D532C0", Offset = "0x5D526C0", VA = "0x185D532C0")]
	private static void IMBNKFJLDNO(FDLKIDLAABP NDHEEGDLJCJ, RigidTransform CENNAHINDOO, [Optional] object KJAGMGIFCEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public interface AAJHNHAHHBB
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	bool PELLJEJNJAL
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	LHNHNFAONOD HKNOHNEGJBK
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	FDLKIDLAABP PBPMJEHLHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event HJMEDKOBEMC NAAAAHPDOKI;

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LHNHNFAONOD BOFEBEAMOOA(LHNHNFAONOD BGICHGONLEL, LHNHNFAONOD AGPMPKBMMOB);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GKMCHOHAPGM(LHNHNFAONOD BGICHGONLEL, LHNHNFAONOD AGPMPKBMMOB, [Out] LHNHNFAONOD MAKPPJALCAB);

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KPLJFDBPDIF();

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HAJNBHAPBHI();

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool AALEPNHGOIH(LHNHNFAONOD BGICHGONLEL);

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NPLPGEABKJO(LHNHNFAONOD BGICHGONLEL);
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public delegate void HJMEDKOBEMC(FDLKIDLAABP HPMDNFBGCLN, FDLKIDLAABP HECIBKGADCC);
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class HBLDBFJGMOM
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x5D56E10", Offset = "0x5D56210", VA = "0x185D56E10")]
	public static bool CHNOFFKEJEJ(this AAJHNHAHHBB IBNLLHACJFB, LHNHNFAONOD BGICHGONLEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x5D56EF0", Offset = "0x5D562F0", VA = "0x185D56EF0")]
	public static bool LJEEKAJAMAF(this AAJHNHAHHBB IBNLLHACJFB, LHNHNFAONOD BGICHGONLEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface LGPKLAKDANM
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLKGCLMNMDN(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MKNJGCMLMKG(LHNHNFAONOD PIBFDGEOBKF, Transform OLPLDGDFGHL);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public interface NLJBCKCCFIP
{
	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOCHLFPDDND(LHNHNFAONOD GIPGBEGNLCD, bool EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EPGINAPDJGB(LHNHNFAONOD GIPGBEGNLCD, bool EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FMMPNIGDDAH(LHNHNFAONOD GIPGBEGNLCD, int EOHMJBFGDPD);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public interface JIIJKCLIHFI
{
	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<LHNHNFAONOD> HADBNIDPNPF(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LHNHNFAONOD LCECEMFKAKO(LHNHNFAONOD PIBFDGEOBKF, int APOENOPNHBG);

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int AJKFLPALNNO(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MHNILHILJOG GCBFCEJOEGD(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KCOOIDELICO(LHNHNFAONOD PIBFDGEOBKF, MHNILHILJOG ILKHBODBFFI);

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LHNHNFAONOD BJCFFFHEGNM(LHNHNFAONOD PIBFDGEOBKF, [Optional] float3? LPAPEIIOLFG, [Optional] quaternion? KBKHJHIFKGI, [Optional] float3? NMGPAHAPPCF);

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LHNHNFAONOD EAJMAHEBBHE(LHNHNFAONOD PIBFDGEOBKF, int APOENOPNHBG, [Optional] float3? LPAPEIIOLFG, [Optional] quaternion? KBKHJHIFKGI, [Optional] float3? NMGPAHAPPCF);

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FKFBBINNHDM(LHNHNFAONOD PIBFDGEOBKF, int APOENOPNHBG);

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KDOHNFAPJMP(LHNHNFAONOD PIBFDGEOBKF);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface FMNCGEAPDKG
{
	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BHBJIEDONMI();

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KHPNKDFLAFK();

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FCILFEKJMPD();

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HJPKPEDBMCL();

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DOOGMPIMBHH();

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DOLGKEPDIOL();

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OMHNADMCNAI();

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BFCMIILNBHD();

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EBINAFLDDAE();

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JHJEEFGNLGG();

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OGGPIKIBFMJ();
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface KFJHDAOPGPA
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OKMMAOFGAAN(Entity FILKDLNBIJH);

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FHGIOMOOJOM(Entity FILKDLNBIJH, [In] float3 EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 EMKLLIFBIHI(Entity FILKDLNBIJH);

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MBBPIMFGAGK(Entity FILKDLNBIJH, [In] quaternion EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion FGCBMPPKJED(Entity FILKDLNBIJH);

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MBIOPMBABME(Entity FILKDLNBIJH, [Out] float3 LPAPEIIOLFG, [Out] quaternion KBKHJHIFKGI);

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MBIOPMBABME(Entity FILKDLNBIJH, [Out] RigidTransform DPJEBGDEPHK);

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LOOLBJMMENL(Entity FILKDLNBIJH, [Out] RigidTransform DPJEBGDEPHK);

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 MELIPNBOBPF(Entity FILKDLNBIJH);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GNNOCLCGJFD(Entity FILKDLNBIJH, [In] float3 EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NCPALADIGEO(Entity FILKDLNBIJH, float EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float BEJMJFDAAOG(Entity FILKDLNBIJH);

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AENFGGIMCKH(Entity FILKDLNBIJH, [In] float3 EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 BBHMKJIBMJJ(Entity FILKDLNBIJH);

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AABNFNFJOED(Entity FILKDLNBIJH, [In] float3 EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 JJDGJNMDPEO(Entity FILKDLNBIJH);

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CLGOCGLCHLF(Entity FILKDLNBIJH, [In] quaternion EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion AMIMBCINAKN(Entity FILKDLNBIJH);

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 GNOLJMBOIBB(Entity FILKDLNBIJH);

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void BIOJKOBIMEI(Entity FILKDLNBIJH, [In] float3 EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NFGLIJNOKKA(Entity FILKDLNBIJH, float EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float MPGNDNOGEJD(Entity FILKDLNBIJH);

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PGHNOELEANF(Entity FILKDLNBIJH, [In] float3 EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 JKAGHHMENCF(Entity FILKDLNBIJH);

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void KNMGLOIEFFH(Entity FILKDLNBIJH, [Out] float4x4 HADNJFPICLN);

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void GOCBLPONMOG(Entity FILKDLNBIJH, [In] float4x4 HADNJFPICLN);

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void MDDLCAPBNMM(Entity FILKDLNBIJH, [Out] float4x4 HADNJFPICLN);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool LFEOLBBNFPA(Entity FILKDLNBIJH, [Out] Transform OLPLDGDFGHL);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OGCJPHICKOL(Entity FILKDLNBIJH);

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void APACBCNCELF(Entity FILKDLNBIJH, Entity JGNFAOENAOD, Entity JOOENMAHIDL);
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class FMIOLKGBGNB
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface PAFDHAFMDMH
{
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World KJGAPLCOJCE();

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World FCENIBILJDC();

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World OCGEILIGGLC();

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World BMLNGCNPPJN();
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface IMHPKNCJCOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000127")]
	World MGNDKLKJBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	World PPGDOEHNLKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	EntityManager NAALHPNIIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	bool GHLFCACBCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase HGIBAIGMMOJ(Type IJFAMCPOKBO);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class ANPFIPGLBJB
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x5D51FF0", Offset = "0x5D513F0", VA = "0x185D51FF0")]
	public static ComponentSystemBase OJDDHLHMCBP(this World MOIDEPLOCKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x29D6A40", Offset = "0x29D5E40", VA = "0x1829D6A40")]
	public static T HGIBAIGMMOJ<T>(this IMHPKNCJCOD HBALCJECAMK) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public interface PEKDDHBDMJC
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void POMJFPJAFIK(NativeListAsync<Entity> PKKHEMBJFNP);

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DIACDPMKCGH(ALICEELGBJJ MBJAGJOJNGH);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KHOAJGCEOIA(NativeListAsync<Entity> ICAPADDFOJH, bool HPGCDJNJIFF);

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OMEJLLCLAPN();
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public interface CNCGGMKKCEC
{
	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NPMDNODOMAK(LHNHNFAONOD PIBFDGEOBKF, [Out] Collider LIMGOFLBOKH);

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject BIKAELNLAIF(LHNHNFAONOD CJCKLNNIGME, GameObject FOHPGKLHLGD, Vector3 DPHLBKLFIPE, Quaternion CMOGOLPKHJO);

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NIEAMCEDOJE(GameObject LIMGOFLBOKH);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider NMPPGADILKK<TCollider>(GameObject BPIILIEHLBN) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IPBAPBJJHCH(Collider LIMGOFLBOKH);

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject EIJOBENKDBN<TCollider>(string LFAIHEECJFK) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public interface CBGFAEGLCDH
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEJHENEDHNA(LHNHNFAONOD PIBFDGEOBKF, JHONAEGJBJL GOJIBFLGAID, bool HCNNKBKDCBO, FCEMCBKNAEB DMEHNGNNKDK);

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NGMLLGBLHEB(LHNHNFAONOD PIBFDGEOBKF, JHONAEGJBJL GOJIBFLGAID, bool HCNNKBKDCBO, bool NALODFLEJOB, bool CHNEBELOEFF);

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EMBPHMDELIE CPECIFLFMEE(LHNHNFAONOD OGEFIHKILIO, List<LHNHNFAONOD> PBHFAPDGDDK);

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DJFHGDIKEEN(GameObject MEIAKDFMANF, GameObject DLPDAAFHKOP);

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PPJLAEPDCHH(GameObject DLPDAAFHKOP);

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T NMPPGADILKK<T>(GameObject BPIILIEHLBN) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IPBAPBJJHCH(Collider LIMGOFLBOKH);

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject BMFGHFEFAOO<T>(string LFAIHEECJFK) where T : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public interface JICJPEPDNGF
{
	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CFMBDFNIABC(LHNHNFAONOD PIBFDGEOBKF, CMHAFMKPEIJ EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CMHAFMKPEIJ NKKGNGNDAOD(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFDAFIGKKAE(LHNHNFAONOD PIBFDGEOBKF, LHNHNFAONOD EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AEELOJHOFOJ(LHNHNFAONOD PIBFDGEOBKF, LHNHNFAONOD EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int DBNHBIOACAG(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LHNHNFAONOD JENKCCNLLLH(LHNHNFAONOD PIBFDGEOBKF, int APOENOPNHBG);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GNNLBIGHJPL(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HFAKOAMCFCM(LHNHNFAONOD PIBFDGEOBKF, object KJAGMGIFCEM, LHNHNFAONOD EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PBKBIAAKFOK(LHNHNFAONOD PIBFDGEOBKF, object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool DOKPCFMHEEC(LHNHNFAONOD PIBFDGEOBKF, [Out] LHNHNFAONOD EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EKLHCMIFDPE(LHNHNFAONOD PIBFDGEOBKF, float3 EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LGAFBGDOKIE(LHNHNFAONOD PIBFDGEOBKF, [Out] float3 EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IHNNMEFMLGK(LHNHNFAONOD PIBFDGEOBKF, float3 EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool DNONFOBIGIA(LHNHNFAONOD PIBFDGEOBKF, [Out] float3 EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EEHJEBMJHPL(LHNHNFAONOD PIBFDGEOBKF, (Quaternion rot, Vector3 moments) NCNIHGBNECM);

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool MMDMNIPAEBP(LHNHNFAONOD PIBFDGEOBKF, [Out] quaternion OCCLANFLOLP, [Out] float3 KBOPNEPIKHO);

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MKJCDBPNEAF(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ONIFDHPLKKH(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 FNIOJMPIAFN(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 LJNKJPFBHGN(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void ALLOCBBAFBA(LHNHNFAONOD PIBFDGEOBKF, float3 EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FBPHLPGMKGG(LHNHNFAONOD PIBFDGEOBKF, float3 EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float MEBCLADPJON(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float HDPIINGMNCD(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DHMNCGOFAEM(LHNHNFAONOD PIBFDGEOBKF, float EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void DELCPHKJAGF(LHNHNFAONOD PIBFDGEOBKF, float EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CollisionDetectionMode DBJEKCCKJIA(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LIEAHOEPIAF(LHNHNFAONOD PIBFDGEOBKF, CollisionDetectionMode EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(Slot = "28")]
	CEAJINAKHIE BJKJLIKDDPO(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FKMDIJHJAAD(LHNHNFAONOD PIBFDGEOBKF, CEAJINAKHIE EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool AAPAPHCMAMN(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void DCGLNLHGILI(LHNHNFAONOD PIBFDGEOBKF, bool EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(Slot = "32")]
	LHNHNFAONOD NKAFPNBHAEE(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void KOLJIHDPMJA(LHNHNFAONOD PIBFDGEOBKF, LHNHNFAONOD EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(Slot = "34")]
	LHNHNFAONOD OBHLIPJDBGF(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void HEBPNKMJKGE(LHNHNFAONOD PIBFDGEOBKF, LHNHNFAONOD EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(Slot = "36")]
	NCDNMOIPOGI PHFFJLGBGPA(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void KIDAFGHOIEO(LHNHNFAONOD PIBFDGEOBKF, NCDNMOIPOGI LBALPLBNKBN);

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool EAMMPCLOOHK(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void KKLECDBKGCO(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool JBHGBMFDAIE(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void GIAKMJLHIKB(LHNHNFAONOD PIBFDGEOBKF, bool EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool DELEGAJMBFC(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void FJGKBLBAHDD(LHNHNFAONOD PIBFDGEOBKF, bool EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(Slot = "44")]
	RigidbodyConstraints ENAICEEAFPC(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void IIGMMCGGNOF(LHNHNFAONOD PIBFDGEOBKF, RigidbodyConstraints EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(Slot = "46")]
	float JKJAIJBIBME(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void NGNNHKCHEHC(LHNHNFAONOD PIBFDGEOBKF, float EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float EHHFBLEHLHA(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void BJNPHPDGCFC(LHNHNFAONOD PIBFDGEOBKF, float EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool PKCMOBNKNCE(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void MCGKMBKEFBG(LHNHNFAONOD PIBFDGEOBKF, bool EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool KIHGPNOJIHJ(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void DNIGOFOHCFD(LHNHNFAONOD PIBFDGEOBKF, bool EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void FHBEPFANBOA(LHNHNFAONOD PIBFDGEOBKF, int EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(Slot = "55")]
	object POCPOFDJAFJ(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void EMHIDPNLLKP(LHNHNFAONOD PIBFDGEOBKF, object EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(Slot = "57")]
	object JNIMDHBEHBN(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void AJOGOGKKFHM(LHNHNFAONOD PIBFDGEOBKF, object EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(Slot = "59")]
	float KMFOJECMJHJ(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void BCDCHHFFOGO(LHNHNFAONOD PIBFDGEOBKF, float EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void OGDCEDLIDCN(LHNHNFAONOD PIBFDGEOBKF, object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void EOLHBLFGOIH(LHNHNFAONOD PIBFDGEOBKF, object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(Slot = "63")]
	bool MPFBAHEDAOG(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void AMLBGEOKINK(LHNHNFAONOD PIBFDGEOBKF, object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void AFKEKFKEDIE(LHNHNFAONOD PIBFDGEOBKF, object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(Slot = "66")]
	bool MAIIOABMNJE(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool EBHKBMGOCAE(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Rigidbody BGAOOHMGOIM(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void NHHBLLLHJEM(LHNHNFAONOD PIBFDGEOBKF, Rigidbody IMHHODKMCIF);

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void CEDEMEPPALB(LHNHNFAONOD PIBFDGEOBKF, object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void MLKIEMGEEPP(LHNHNFAONOD PIBFDGEOBKF, object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool IBGGLOFOHOD(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void OBMCHKENEKI(LHNHNFAONOD PIBFDGEOBKF, float3 GKMPFMKFGID);

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void KIANPIHCKME(LHNHNFAONOD PIBFDGEOBKF, float3 BADJPOOCLHC);

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(Slot = "75")]
	bool KPLLMDCILFE(LHNHNFAONOD PIBFDGEOBKF, [Out] float3 GKMPFMKFGID);

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool MOMIMOCLPKO(LHNHNFAONOD PIBFDGEOBKF, [Out] float3 BADJPOOCLHC);

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool HCGHILJJDJE(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void GNJIIEEEEDB(LHNHNFAONOD PIBFDGEOBKF, object KJAGMGIFCEM, bool LLALDMDCIAM);

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(Slot = "79")]
	void DALMGKGAGEM(LHNHNFAONOD PIBFDGEOBKF, bool CAFHFPCMBEJ);

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void HCHAOIHMJIC(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool FDEDIMAFEMP(LHNHNFAONOD PIBFDGEOBKF);
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public interface BIPCGCLALOO
{
	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	bool GHLFCACBCML
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PLCHCHHMFEE(LHNHNFAONOD PIBFDGEOBKF);

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EIKIHGOFDJE(LHNHNFAONOD PIBFDGEOBKF, bool HCNNKBKDCBO, bool NALODFLEJOB, bool NMNLIGBGBIP);

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ECMEOIKODCB(LHNHNFAONOD PIBFDGEOBKF, float3 EKHMFCCFGPL);

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JLFOKBIEOOE(LHNHNFAONOD PIBFDGEOBKF, float3 EKHMFCCFGPL);
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public interface OOHKDNCOFFD
{
	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEOEDOMKMEE(Entity OAKCPIKBPJF);

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HNPMIIHHFAK(Entity OAKCPIKBPJF);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public delegate void EOEOMGNNBCG(EOHKGDILIIA KGCCOANEADN);
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct EOHKGDILIIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly DLCLMIEPGBN KAJFFCPILBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly NativeArray<byte> DIPNGLKFBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly NativeArray<byte> GBMOELLOINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly EAAMNLEDMLN KMKGEGCGMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly int PIBMNCBGNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Type PAIOOAEGLIP;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public DLCLMIEPGBN ADMKMBFPINE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x3955050", Offset = "0x3954450", VA = "0x183955050")]
		get
		{
			return default(DLCLMIEPGBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x5D54AD0", Offset = "0x5D53ED0", VA = "0x185D54AD0")]
	public EOHKGDILIIA(DLCLMIEPGBN KAJFFCPILBD, NativeArray<byte> DIPNGLKFBLA, NativeArray<byte> GBMOELLOINK, EAAMNLEDMLN KMKGEGCGMGD, int PIBMNCBGNAK, Type PAIOOAEGLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x225E320", Offset = "0x225D720", VA = "0x18225E320")]
	public NativeArray<T> IELCKNLHIBD<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x225E360", Offset = "0x225D760", VA = "0x18225E360")]
	public NativeArray<T> NDOJEBBAADN<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x225E3A0", Offset = "0x225D7A0", VA = "0x18225E3A0")]
	public (DLCLMIEPGBN, NativeArray<T>, NativeArray<T>) OPODPAEFLEB<T>() where T : struct
	{
		return default((DLCLMIEPGBN, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x5D54A80", Offset = "0x5D53E80", VA = "0x185D54A80")]
	public HDHIDMCJGCD PNJPMHEDBAC()
	{
		return default(HDHIDMCJGCD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public interface LBDCPCFBDCC
{
	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	string JCJIFLBLMDP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	LBDCPCFBDCC PINIPGOECLE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	IEnumerable<LBDCPCFBDCC> MPBAFNBOBOP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public interface MEEOILEJJHG
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	LBDCPCFBDCC EPDAJJCLAEN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	List<ADLHMGAHKNA> EAALOBBKNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IJHNFKABONC(ADLHMGAHKNA ANNDMLIIDLL, [Out] LBDCPCFBDCC KHCLELLAFNP);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KIPDOAILNDA(ADLHMGAHKNA ANNDMLIIDLL, EOEOMGNNBCG HHDLGPINDHI);

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FOMBLDAJHNJ(ADLHMGAHKNA ANNDMLIIDLL, EOEOMGNNBCG HHDLGPINDHI);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public readonly struct HDHIDMCJGCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly EOHKGDILIIA GHFAAPNAFDE;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public DLCLMIEPGBN ADMKMBFPINE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x3955050", Offset = "0x3954450", VA = "0x183955050")]
		get
		{
			return default(DLCLMIEPGBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5D57230", Offset = "0x5D56630", VA = "0x185D57230")]
	public HDHIDMCJGCD(EOHKGDILIIA GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x5D56F70", Offset = "0x5D56370", VA = "0x185D56F70")]
	public DLCLMIEPGBN IELCKNLHIBD()
	{
		return default(DLCLMIEPGBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x5D57040", Offset = "0x5D56440", VA = "0x185D57040")]
	public DLCLMIEPGBN NDOJEBBAADN()
	{
		return default(DLCLMIEPGBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5D57110", Offset = "0x5D56510", VA = "0x185D57110")]
	public (DLCLMIEPGBN, DLCLMIEPGBN, DLCLMIEPGBN) OPODPAEFLEB()
	{
		return default((DLCLMIEPGBN, DLCLMIEPGBN, DLCLMIEPGBN));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DefaultMember("Item")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface BBAOLHNDKHB : IEnumerable<EHEMBOJPNLK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000133")]
	NativeBitArray MBLELDIBBCN
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	NativeArray<int> MNKLPNONHEI
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	EHEMBOJPNLK LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	EHEMBOJPNLK LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EHEMBOJPNLK KIODCLFIOFD(PGMBACGNAAP IHPCGCBJCJP);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EAAMNLEDMLN CKOILIBPNJH(PGMBACGNAAP IHPCGCBJCJP);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class ABKJNAEDNEA
{
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DefaultMember("Item")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface IIALBECIDBK : IEnumerable<IELJJLAMLND>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000138")]
	int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	IELJJLAMLND LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IELJJLAMLND KIODCLFIOFD(PGMBACGNAAP IHPCGCBJCJP);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EAAMNLEDMLN CKOILIBPNJH(PGMBACGNAAP IHPCGCBJCJP);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class BHDHNEFACFF
{
	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x21A2030", Offset = "0x21A1430", VA = "0x1821A2030")]
	public static EAAMNLEDMLN CKOILIBPNJH<T>(this IIALBECIDBK MFEJFLABCIK, OFMDLNJBPPF<T> LFAIHEECJFK) where T : struct
	{
		return default(EAAMNLEDMLN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DefaultMember("Item")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface BEIEPOGCFMG : IEnumerable<ADLHMGAHKNA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	ADLHMGAHKNA LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ADLHMGAHKNA KIODCLFIOFD(PGMBACGNAAP IHPCGCBJCJP);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EAAMNLEDMLN CKOILIBPNJH(PGMBACGNAAP IHPCGCBJCJP);
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class BKNGJMNJHIB
{
	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x21A35C0", Offset = "0x21A29C0", VA = "0x1821A35C0")]
	public static LJLPBCHNEGF<T> KIODCLFIOFD<T>(this BEIEPOGCFMG MFEJFLABCIK, PGMBACGNAAP LFAIHEECJFK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x21A34C0", Offset = "0x21A28C0", VA = "0x1821A34C0")]
	public static EAAMNLEDMLN CKOILIBPNJH<T>(this BEIEPOGCFMG MFEJFLABCIK, OFMDLNJBPPF<T> LFAIHEECJFK) where T : struct
	{
		return default(EAAMNLEDMLN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public interface CEJODIHFCGC
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIPDOAILNDA(PGMBACGNAAP ANNDMLIIDLL, EOEOMGNNBCG HHDLGPINDHI);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FOMBLDAJHNJ(PGMBACGNAAP ANNDMLIIDLL, EOEOMGNNBCG HHDLGPINDHI);
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class DNOFAOHBDMK
{
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface AOIJIDDNGFE
{
	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	OFOMCGLEDAP KKEGIONHGCG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GHCDJPAIEBP(IJFILFNCAOA JNPKHIBFGKN, EAAMNLEDMLN ANNDMLIIDLL);

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMPGEEDPLEG(IJFILFNCAOA JNPKHIBFGKN, Span<EAAMNLEDMLN> MFEJFLABCIK, bool KFBHGNMLDFM);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BMCBGEPDDJE(NativeArray<IJFILFNCAOA> OMNMPNPKGPB);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public static class OHAMHGAIFJG
{
	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D5F830", Offset = "0x5D5EC30", VA = "0x185D5F830")]
	public static void AMPGEEDPLEG(this AOIJIDDNGFE DKHFFJHAFEN, IJFILFNCAOA JNPKHIBFGKN, EAAMNLEDMLN ANNDMLIIDLL, bool KFBHGNMLDFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public readonly struct OFOMCGLEDAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly NativeBitArray CNACOCMPEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly NativeParallelHashMap<IJFILFNCAOA, int> GEGIHDNKDAP;

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public bool FGAOPKACOEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x5D5F6E0", Offset = "0x5D5EAE0", VA = "0x185D5F6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0xA9D410", Offset = "0xA9C810", VA = "0x180A9D410")]
	public OFOMCGLEDAP(NativeBitArray CNACOCMPEDM, NativeParallelHashMap<IJFILFNCAOA, int> GEGIHDNKDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D5F700", Offset = "0x5D5EB00", VA = "0x185D5F700")]
	public bool GHCDJPAIEBP(IJFILFNCAOA JNPKHIBFGKN, EAAMNLEDMLN ANNDMLIIDLL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public interface FILMIOFJDPA
{
	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IGNIKMDMLEH(LHNHNFAONOD PIBFDGEOBKF, KOKEBPMKNGL EOHMJBFGDPD);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface HFIKKOFPOIC
{
	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	OKMBENJPNJO CNJGKMGEGKF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface OAIGFOPCPFO
{
	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	Type EMIKKEHILOB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public interface LIHDLACLGHM
{
	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHFHGHHLHAL(LHNHNFAONOD GIPGBEGNLCD, bool EOHMJBFGDPD);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public readonly struct ECHNGDHAHOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly IEnumerable<BDDINDDAOMP> JJAIIAGNJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly IReadOnlyList<GameObject> DOMNBOJJOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly IReadOnlyList<int> CCKFOKMIHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly IReadOnlyList<(IJFILFNCAOA, IJFILFNCAOA)> CIMGNCABPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly int OPHBEGOJHPH;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool AAMDFDDBPGE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x5D546E0", Offset = "0x5D53AE0", VA = "0x185D546E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public int HMMBHFLLPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x8124E0", Offset = "0x8118E0", VA = "0x1808124E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public IEnumerable<GameObject> CLCJKKHFGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x998C40", Offset = "0x998040", VA = "0x180998C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public IEnumerable<(IJFILFNCAOA src, IJFILFNCAOA dst)> JCBGLIMALAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D54740", Offset = "0x5D53B40", VA = "0x185D54740")]
	public ECHNGDHAHOM(IEnumerable<BDDINDDAOMP> JJAIIAGNJLG, IReadOnlyList<GameObject> DOMNBOJJOED, IReadOnlyList<int> CCKFOKMIHFC, IReadOnlyList<(IJFILFNCAOA src, IJFILFNCAOA dst)> CIMGNCABPOB, int OPHBEGOJHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5D54350", Offset = "0x5D53750", VA = "0x185D54350")]
	public (GameObject, int)[] BOAHEMMOLGI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface NBCENCLEOLD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000144")]
	bool LHIKIAAGGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	bool FCMHLDLKONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	CPKPDFPLDCI IHADLJLAJIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JPGOBCIEAFB PIPAJEOKLFP();

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JPGOBCIEAFB MNMAFFKLIIC(IEnumerable<LHNHNFAONOD> GAKOOBMLEII, [In] EKDOHGHOOFO FFGNHFDKOFB);

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DCCFMDGIBCB JFPBNGMDKOO(ByteString NDPODJAOEBF);

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MFDFMBOIECB NBHOFAEMLGL(ByteString EGFEGIMIICO, LHNHNFAONOD EBFCMPBKGBM, [In] EKDOHGHOOFO CLFGJFGNNGG, JIKHBIMIMDL IFHPDALFBDB, bool HCKANGNGGLP = true);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FBNDFBECIAL();

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ECHNGDHAHOM AKEOPOJABHA(IEnumerable<BDDINDDAOMP> JJAIIAGNJLG);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class LNAMGPINCME
{
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface GAHOIFMALLF
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action FJCEJCMDELL;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action MJNIHLKJIEN;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct EIDGNLJLKDK : OGIDOOLIEGA, IEquatable<EIDGNLJLKDK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public JMFEOGDEHDH INONPCNKMNK;

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x5D548D0", Offset = "0x5D53CD0", VA = "0x185D548D0", Slot = "5")]
	public void ONLENKPGCBM(BDLPMJHFHLL IOJEJAFBOHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x5D54900", Offset = "0x5D53D00", VA = "0x185D54900", Slot = "4")]
	public void PJNKBIHCNDA(LPHAAGNHOAH MKIOBJMIBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x5D54930", Offset = "0x5D53D30", VA = "0x185D54930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x1642C20", Offset = "0x1642020", VA = "0x181642C20", Slot = "6")]
	public bool Equals(EIDGNLJLKDK LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x5D54850", Offset = "0x5D53C50", VA = "0x185D54850", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x7DFAD0", Offset = "0x7DEED0", VA = "0x1807DFAD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct IJFILFNCAOA : IComparable<IJFILFNCAOA>, IEquatable<IJFILFNCAOA>, OGIDOOLIEGA
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public const uint NAKEPHABMBK = 0u;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public const uint GBNGAEOBBDI = 255u;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static readonly IJFILFNCAOA JCNACNONIMC;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private const int NKGBJCODNPM = 24;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private const uint NDLONIFPFME = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private const int CAEFDODAFIB = 8;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private const uint EILAFLDDJKJ = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly uint HPOLMACFBHD;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public uint KCPBJKNDOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x7B2CB0", Offset = "0x7B20B0", VA = "0x1807B2CB0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public uint DFNAILAPHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x5D57B70", Offset = "0x5D56F70", VA = "0x185D57B70")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public uint FMIFIKMGMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAD0", Offset = "0x7DEED0", VA = "0x1807DFAD0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public bool AAMDFDDBPGE
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x5CBD2B0", Offset = "0x5CBC6B0", VA = "0x185CBD2B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0xBC9740", Offset = "0xBC8B40", VA = "0x180BC9740")]
	public static IJFILFNCAOA NGFPNCHCLPK(uint HPOLMACFBHD)
	{
		return default(IJFILFNCAOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x5D57D50", Offset = "0x5D57150", VA = "0x185D57D50")]
	public IJFILFNCAOA(int MDPJPABGGLO, int DJLHHNIPGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x5D57D50", Offset = "0x5D57150", VA = "0x185D57D50")]
	public IJFILFNCAOA(uint MDPJPABGGLO, int DJLHHNIPGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x5D57D50", Offset = "0x5D57150", VA = "0x185D57D50")]
	public IJFILFNCAOA(uint MDPJPABGGLO, uint DJLHHNIPGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x7DFAC0", Offset = "0x7DEEC0", VA = "0x1807DFAC0")]
	private IJFILFNCAOA(uint HPOLMACFBHD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x1642C40", Offset = "0x1642040", VA = "0x181642C40")]
	public static bool MEMFAJGIIAO(IJFILFNCAOA IFAOGMEBPFN, IJFILFNCAOA DNPBOPMFFFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x1642C20", Offset = "0x1642020", VA = "0x181642C20", Slot = "5")]
	public bool Equals(IJFILFNCAOA PIKCMFPLBNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x5D57B80", Offset = "0x5D56F80", VA = "0x185D57B80", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF860", Offset = "0x1FEEC60", VA = "0x181FEF860", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x5D57CC0", Offset = "0x5D570C0", VA = "0x185D57CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x5D57C60", Offset = "0x5D57060", VA = "0x185D57C60", Slot = "6")]
	public void PJNKBIHCNDA(LPHAAGNHOAH MKIOBJMIBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x5D57C00", Offset = "0x5D57000", VA = "0x185D57C00", Slot = "7")]
	public void ONLENKPGCBM(BDLPMJHFHLL IOJEJAFBOHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x5D57B60", Offset = "0x5D56F60", VA = "0x185D57B60", Slot = "4")]
	public int CompareTo(IJFILFNCAOA LJIBJAOOGGF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct BDDINDDAOMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Guid OGGNLGCIGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public string HFCKFJICBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Vector3 LPAPEIIOLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Quaternion KBKHJHIFKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Vector3 NMGPAHAPPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int IJLKJNDPCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Dictionary<string, object> ILKHBODBFFI;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x5D52210", Offset = "0x5D51610", VA = "0x185D52210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x5D52080", Offset = "0x5D51480", VA = "0x185D52080")]
	private static string DHAPABHGHIH(Dictionary<string, object> OCPCJNPGDLF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public enum CEGGGNMKAAC
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	World,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class BKMLEKJNEDH
{
	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x52AA6B0", Offset = "0x52A9AB0", VA = "0x1852AA6B0")]
	public static bool EMKHJBIKKMH(this CEGGGNMKAAC IJFAMCPOKBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[Flags]
public enum LMGFAGPMGOB
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
[Cpp2IlInjected.Token(Token = "0x200009A")]
public interface MFDFMBOIECB : CPKPDFPLDCI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	JIKHBIMIMDL IGCEJJPMDMP
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEPLBNHKDFP();

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MBFHDLOEBKO();
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public interface CPKPDFPLDCI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	IEnumerable<BDDINDDAOMP> FENNFBLMAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	ECHNGDHAHOM PGDNJMPKEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	LocalId JJPEIMIAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	IPLKNLMFFDP BFFEGJPNAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	Task IKMGLLNDKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PKJOKDNDIPB(LMGFAGPMGOB ACCDAPFKBCP);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public interface JIKHBIMIMDL
{
	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LPBIHNKMOEC(Guid ABNGLIALIJA, [Out] Guid DCAHFNCPDMJ);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public interface DCCFMDGIBCB : CPKPDFPLDCI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[Flags]
public enum BHHPBIAJGIJ
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
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface JPGOBCIEAFB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000151")]
	IPLKNLMFFDP FLIDMMKFLLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString PCENJPCJCHM();
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public enum OMIBOHIOEFO
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public delegate bool MPBADIPFPFK(DGGBEDJKEHK BBGCLNBNLJA, [In] IBIHAHCALHC EOHMJBFGDPD);
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public delegate bool HFPGMIJBBGO<T>(DGGBEDJKEHK BBGCLNBNLJA, [In] T EOHMJBFGDPD);
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface GHBGCJBELNC
{
	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIPDOAILNDA(EAAMNLEDMLN KMKGEGCGMGD, Type NHPINLBPLPD, MPBADIPFPFK MLPOPDPEHEA);

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NLPBEBDFKCA(EAAMNLEDMLN KMKGEGCGMGD, [Out] MPBADIPFPFK MLPOPDPEHEA);
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class ADEOHJELKNC
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class BPNMMGFADDI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public HFPGMIJBBGO<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public BPNMMGFADDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x4852840", Offset = "0x4851C40", VA = "0x184852840")]
		internal bool KMJLMCBHMNJ(DGGBEDJKEHK pendingList, [In] IBIHAHCALHC value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x29CCC90", Offset = "0x29CC090", VA = "0x1829CCC90")]
	public static void KIPDOAILNDA<T>(this GHBGCJBELNC PDMNBLCHBOO, EAAMNLEDMLN KMKGEGCGMGD, HFPGMIJBBGO<T> MLPOPDPEHEA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x5D51D00", Offset = "0x5D51100", VA = "0x185D51D00")]
	public static bool FBNEEHJPECA(this GHBGCJBELNC PDMNBLCHBOO, DGGBEDJKEHK BBGCLNBNLJA, EAAMNLEDMLN KMKGEGCGMGD, [In] IBIHAHCALHC EOHMJBFGDPD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface HABDGJEIGLI
{
	[Cpp2IlInjected.Token(Token = "0x17000152")]
	uint NLMDKCJIAHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface DGGBEDJKEHK
{
	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCPGAEAJPGD(IJFILFNCAOA AJLJLPIIIFD, EAAMNLEDMLN KMKGEGCGMGD, ReadOnlySpan<byte> KFAOHDMIJNF, ReadOnlySpan<byte> EGFDIPNELEE);

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NMFBBFCJGOP(IJFILFNCAOA AJLJLPIIIFD, EAAMNLEDMLN KMKGEGCGMGD);

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CFMPJKMJHNE(IJFILFNCAOA AJLJLPIIIFD, EAAMNLEDMLN KMKGEGCGMGD, ReadOnlySpan<byte> EGFDIPNELEE);

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LDOHFNHJPIG(IJFILFNCAOA AJLJLPIIIFD, EAAMNLEDMLN KMKGEGCGMGD, Span<byte> KFAOHDMIJNF, Span<byte> EGFDIPNELEE);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public static class LHKKFKPIEAH
{
	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x244F890", Offset = "0x244EC90", VA = "0x18244F890")]
	public static bool LDOHFNHJPIG<T>(this DGGBEDJKEHK OPANBBAHNJD, IJFILFNCAOA AJLJLPIIIFD, EAAMNLEDMLN KMKGEGCGMGD, [Out] T KFAOHDMIJNF, [Out] T EGFDIPNELEE) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x244F760", Offset = "0x244EB60", VA = "0x18244F760")]
	public static bool CFMPJKMJHNE<T>(this DGGBEDJKEHK OPANBBAHNJD, IJFILFNCAOA AJLJLPIIIFD, EAAMNLEDMLN KMKGEGCGMGD, T EGFDIPNELEE) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public enum IOGGJJNDOHI
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
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface AHAAPFOIKPK
{
	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ABLLGMLPLDH(OCNDOGNDAKK OAGNBNMPALP, ReadOnlySpan<byte> HEFGEKEDAKE);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface BENCMKIONLD
{
	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OCNDOGNDAKK OOMGEBCLGKC(ReadOnlySpan<byte> HEFGEKEDAKE);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface CBGNJCOKJKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FDPDLHCJFBF(OCNDOGNDAKK DGCJCBHPPBD, ReadOnlySpan<byte> HEFGEKEDAKE);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct PMPNKHCNPNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public OCNDOGNDAKK OAGNBNMPALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public ReadOnlyMemory<byte> HEFGEKEDAKE;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public struct OCNDOGNDAKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public uint MDPJPABGGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public int HCCCMDDKKIH;

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x982310", Offset = "0x981710", VA = "0x180982310")]
	public OCNDOGNDAKK(uint MDPJPABGGLO, int HCCCMDDKKIH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x5D5F620", Offset = "0x5D5EA20", VA = "0x185D5F620")]
	public static bool MEMFAJGIIAO([In] OCNDOGNDAKK IBOMHLKOLJB, [In] OCNDOGNDAKK FFDHLLBEMJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x5D5F560", Offset = "0x5D5E960", VA = "0x185D5F560", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x5D5F5F0", Offset = "0x5D5E9F0", VA = "0x185D5F5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x5D5F640", Offset = "0x5D5EA40", VA = "0x185D5F640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public interface IOEPDKPCAAM : GPOELIKPIAP<IOEPDKPCAAM>
{
	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IIDAIDKPMAP(EAAMNLEDMLN PIKCMFPLBNL, [Out] IMINMDJAAHH HOGACIGOPKL);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public static class JIPKFALEGOI
{
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public interface IMINMDJAAHH
{
	[Cpp2IlInjected.Token(Token = "0x17000153")]
	Type PJLEKBCNEJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ONLENKPGCBM(BDLPMJHFHLL IOJEJAFBOHN, Span<byte> BGICHGONLEL);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJNKBIHCNDA(LPHAAGNHOAH MKIOBJMIBCN, ReadOnlySpan<byte> OAGNBNMPALP);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public static class KBJNOHNDEBC
{
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct CMLIFCOKLLM : ISystemStateComponentData, IComponentData, IEquatable<CMLIFCOKLLM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public float3 INKHBAEDGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public float3 MIFFOAPOICF;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x5D53870", Offset = "0x5D52C70", VA = "0x185D53870", Slot = "4")]
	public bool Equals(CMLIFCOKLLM LJIBJAOOGGF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface DMNMIPIKKHC
{
	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CBJELEJDOHN PLIHNIGAMIL(int PIEALCBDGOA);

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int ECLDCOBNOPP(CBJELEJDOHN MKFHNGHEFLL);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface KDBONONDPOD
{
	[Cpp2IlInjected.Token(Token = "0x17000154")]
	IEnumerable<LDAMFPBECCI> HHPIMJECGON
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DKCBNGKBCMH(int PIEALCBDGOA, [Out] LDAMFPBECCI HOGACIGOPKL);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface PMHNFJPNKBF
{
	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int MBMGBIMPEOK(int PIEALCBDGOA);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface NDEPEEAJPLD
{
	[Cpp2IlInjected.Token(Token = "0x17000155")]
	List<(CBJELEJDOHN nameHash, AIPJMJJAMPA stableTypeHash, Type type)> GENGIIAHKFC
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class GJFEHICIKAF
{
	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public GJFEHICIKAF()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
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
