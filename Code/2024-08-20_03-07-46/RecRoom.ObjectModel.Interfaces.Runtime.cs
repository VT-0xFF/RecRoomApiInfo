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
	public class LogRegistrationIndex : AGBKNAFJGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6A807B0", Offset = "0x6A7F7B0", VA = "0x186A807B0", Slot = "4")]
		public override void GGLLICMBJNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DDGBGKBIGPA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A77220", Offset = "0x6A76220", VA = "0x186A77220")]
	public static void GFBEIBEBIMP(this Rigidbody KNDCHPBBGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A770F0", Offset = "0x6A760F0", VA = "0x186A770F0")]
	public static void GFBEIBEBIMP(this Rigidbody KNDCHPBBGMD, Vector3 CACAAMGKKLM, Quaternion LEMMBFDPBCM, Vector3 HLJJAHMCLFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct LKKANPIGGEI : IReadOnlyList<CGNEFKCKCBE>, IEnumerable<CGNEFKCKCBE>, IEnumerable, IReadOnlyCollection<CGNEFKCKCBE>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct OLGMACOEDKI : IEnumerator<CGNEFKCKCBE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly OEENGDBIBNC AAAODCCDNKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator FONGOFJDDJB;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public CGNEFKCKCBE NIGOAHBKKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6A85E00", Offset = "0x6A84E00", VA = "0x186A85E00", Slot = "4")]
			get
			{
				return default(CGNEFKCKCBE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6A85D80", Offset = "0x6A84D80", VA = "0x186A85D80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x42D02F0", Offset = "0x42CF2F0", VA = "0x1842D02F0")]
		public OLGMACOEDKI(OEENGDBIBNC AAAODCCDNKB, NativeArray<LocalId>.Enumerator FONGOFJDDJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6A85CC0", Offset = "0x6A84CC0", VA = "0x186A85CC0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6A85D00", Offset = "0x6A84D00", VA = "0x186A85D00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6A85D40", Offset = "0x6A84D40", VA = "0x186A85D40", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly OEENGDBIBNC AAAODCCDNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> HDBEGMKJNAF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public CGNEFKCKCBE OMCGAJCFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6A7F990", Offset = "0x6A7E990", VA = "0x186A7F990", Slot = "4")]
		get
		{
			return default(CGNEFKCKCBE);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6A7F400", Offset = "0x6A7E400", VA = "0x186A7F400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int FGJJAGMFOHP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8511A0", Offset = "0x8501A0", VA = "0x1808511A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public OEENGDBIBNC KKEOBPFILCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NLCDAFOIEDF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8511A0", Offset = "0x8501A0", VA = "0x1808511A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool COGFBBOENKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6A7F3C0", Offset = "0x6A7E3C0", VA = "0x186A7F3C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> KMNFPLAJDOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x25B6F90", Offset = "0x25B5F90", VA = "0x1825B6F90")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> DHOBFBKNGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6A7F450", Offset = "0x6A7E450", VA = "0x186A7F450")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F900", Offset = "0x6A7E900", VA = "0x186A7F900")]
	public LKKANPIGGEI(int BPIECAEAGAJ, OEENGDBIBNC AAAODCCDNKB, Allocator OOMMBGGEBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x42CFE70", Offset = "0x42CEE70", VA = "0x1842CFE70")]
	public LKKANPIGGEI(OEENGDBIBNC AAAODCCDNKB, NativeArray<LocalId> HDBEGMKJNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F890", Offset = "0x6A7E890", VA = "0x186A7F890")]
	internal LKKANPIGGEI(OEENGDBIBNC AAAODCCDNKB, NativeArray<Entity> LCKAMOJEGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F7F0", Offset = "0x6A7E7F0", VA = "0x186A7F7F0")]
	public LKKANPIGGEI(OEENGDBIBNC AAAODCCDNKB, int IGIHBEMLMOK, Allocator OOMMBGGEBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F740", Offset = "0x6A7E740", VA = "0x186A7F740")]
	public LKKANPIGGEI(LKKANPIGGEI JIHPMENOGOM, Allocator OOMMBGGEBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F4B0", Offset = "0x6A7E4B0", VA = "0x186A7F4B0")]
	public LKKANPIGGEI PANBNAPFBFN(Allocator OOMMBGGEBLM = Allocator.Temp)
	{
		return default(LKKANPIGGEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F2F0", Offset = "0x6A7E2F0", VA = "0x186A7F2F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F330", Offset = "0x6A7E330", VA = "0x186A7F330")]
	public OLGMACOEDKI EAJKDCOBAGF()
	{
		return default(OLGMACOEDKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F560", Offset = "0x6A7E560", VA = "0x186A7F560", Slot = "6")]
	private IEnumerator<CGNEFKCKCBE> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F650", Offset = "0x6A7E650", VA = "0x186A7F650", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public struct BCKKMILDKKA : IList<CGNEFKCKCBE>, ICollection<CGNEFKCKCBE>, IEnumerable<CGNEFKCKCBE>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct BJBDABIEPOC : IEnumerator<CGNEFKCKCBE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly OEENGDBIBNC AAAODCCDNKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator FONGOFJDDJB;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public CGNEFKCKCBE NIGOAHBKKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6A739C0", Offset = "0x6A729C0", VA = "0x186A739C0", Slot = "4")]
			get
			{
				return default(CGNEFKCKCBE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6A73940", Offset = "0x6A72940", VA = "0x186A73940", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x42D02F0", Offset = "0x42CF2F0", VA = "0x1842D02F0")]
		public BJBDABIEPOC(OEENGDBIBNC AAAODCCDNKB, NativeArray<LocalId>.Enumerator FONGOFJDDJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6A73880", Offset = "0x6A72880", VA = "0x186A73880", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6A738C0", Offset = "0x6A728C0", VA = "0x186A738C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6A73900", Offset = "0x6A72900", VA = "0x186A73900", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly OEENGDBIBNC AAAODCCDNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> HDBEGMKJNAF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public CGNEFKCKCBE OMCGAJCFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6A73770", Offset = "0x6A72770", VA = "0x186A73770", Slot = "4")]
		get
		{
			return default(CGNEFKCKCBE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6A737F0", Offset = "0x6A727F0", VA = "0x186A737F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6A73000", Offset = "0x6A72000", VA = "0x186A73000", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int NLCDAFOIEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6A73000", Offset = "0x6A72000", VA = "0x186A73000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool KEMHBPIIPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6A735D0", Offset = "0x6A725D0", VA = "0x186A735D0")]
	public BCKKMILDKKA(int BPIECAEAGAJ, OEENGDBIBNC AAAODCCDNKB, Allocator OOMMBGGEBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A736F0", Offset = "0x6A726F0", VA = "0x186A736F0")]
	public BCKKMILDKKA(OEENGDBIBNC AAAODCCDNKB, Allocator OOMMBGGEBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A73660", Offset = "0x6A72660", VA = "0x186A73660")]
	public BCKKMILDKKA(OEENGDBIBNC AAAODCCDNKB, int IGIHBEMLMOK, Allocator OOMMBGGEBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A73250", Offset = "0x6A72250", VA = "0x186A73250")]
	public LKKANPIGGEI NELOCIEAIEJ()
	{
		return default(LKKANPIGGEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6A72DE0", Offset = "0x6A71DE0", VA = "0x186A72DE0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6A72E20", Offset = "0x6A71E20", VA = "0x186A72E20", Slot = "13")]
	public bool Contains(CGNEFKCKCBE LLGHCONMHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6A72EB0", Offset = "0x6A71EB0", VA = "0x186A72EB0", Slot = "14")]
	public void CopyTo(CGNEFKCKCBE[] IKONNGGNFPH, int MNPIBEICCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A72D60", Offset = "0x6A71D60", VA = "0x186A72D60", Slot = "11")]
	public void Add(CGNEFKCKCBE LLGHCONMHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A731A0", Offset = "0x6A721A0", VA = "0x186A731A0", Slot = "7")]
	public void Insert(int HCALFJOJKJO, CGNEFKCKCBE LLGHCONMHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A73320", Offset = "0x6A72320", VA = "0x186A73320", Slot = "15")]
	public bool Remove(CGNEFKCKCBE LLGHCONMHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6A73110", Offset = "0x6A72110", VA = "0x186A73110", Slot = "6")]
	public int IndexOf(CGNEFKCKCBE LLGHCONMHCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6A732D0", Offset = "0x6A722D0", VA = "0x186A732D0", Slot = "8")]
	public void RemoveAt(int HCALFJOJKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6A73040", Offset = "0x6A72040", VA = "0x186A73040", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6A73080", Offset = "0x6A72080", VA = "0x186A73080")]
	public BJBDABIEPOC EAJKDCOBAGF()
	{
		return default(BJBDABIEPOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6A733F0", Offset = "0x6A723F0", VA = "0x186A733F0", Slot = "16")]
	private IEnumerator<CGNEFKCKCBE> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6A734E0", Offset = "0x6A724E0", VA = "0x186A734E0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GNLLFGJBHME : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int JIONLDFDCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> NNIJKLDNEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CGNEFKCKCBE CDNAFFKMGMK(CGNEFKCKCBE HDBEGMKJNAF);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OEMDGHNGFGD : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface JMACPFIJEKJ : JGMMAINHLJA, LOGKBMOJLKJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool HALEFOFGOBN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	CAGLIKPDIOD HGNJJIHDGPE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	EPPFHHKPCGP GDNKCELMOKI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	FNLPLJPPMJI DDEKKFALKJA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	NPPPNEJNGDK IKDHFOHOEHA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface LOGKBMOJLKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool MALNNBLLMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface OKPNJOIMDID
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGLEOHLLKDJ(bool JJCEIJMGOAB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[CCHFMGLFBCK(ICPIBLGDMFM.PhotonRoom)]
public interface ENKAAIDFFED
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool NHMKMKCLJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LPFHPMPPIHO(bool HFODIMENHKG);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GOAOIKGKPNE();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IFAHKOJMNNI(ByteString ADBDMGOLEGN);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MKBNIAPHGOF();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PBHFPADLKLH();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NJGNDAANLIF();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EJNGKOOHDNH();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PBCDBHALOJD();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface FNLPLJPPMJI
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	APGMJOIFDDC HGNJJIHDGPE
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	EPPFHHKPCGP GDNKCELMOKI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	ACKGFBDMFHC HJGHBBCCHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	IFLPLBCLPON GAIDGBKOHJD
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	JMACPFIJEKJ GCAHCPBGCFM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	ENKAAIDFFED LGNCDOKGPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	OEENGDBIBNC KKEOBPFILCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	AFOMIBACJBH MMPINNONJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	NHCPPBLHPHO HPFKJJNHIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	IFHHFOJEJFD PIMDCOEAPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	LJKMDAEMGNP MLJLHLPNKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	GMAJLNFKMKB GLOECJOGKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	EFHGOFDNKPD NDBIKKAMGOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	FOGCBBJBLKA EOGFGBPELCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	AEHFDOOJOOH LMOMJKJKNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	BCLJKBJGCDM LICFFHAGOKB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	INBICOBKMCK JEOHNCPAPAA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	FMBFPNOAMOB MICAJDMIPLC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	OCMGEOKHNIG FFHCJFJFLHB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	FMHNNPHEFMH MECOCFIFIJL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	KEIMBELKEMB NINADMIDGDH
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	JOPHOCAGIDH OKMLCHLBLAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	HKMAJPPKKMD KBMIMOJHAGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	LDAPHBHMDEG EFMCHKNEGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	ELHOOHGIKMC HMJPPNPIOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	IDFOAMIMPDK NNGJGNLEOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	KHMCLKKAGDP HKGIPCCCOOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	LKLLPLJKLOJ IJGKKMDBBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	JGGKLJNAOEM PPJAEAPLKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DebuggerTypeProxy(typeof(JBEAODGMOFH))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct CGNEFKCKCBE : IComparable<CGNEFKCKCBE>, IEquatable<CGNEFKCKCBE>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly CGNEFKCKCBE JDOOJIEMHEC;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int MNKFHJBHCAA = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int NMEEAMEBPFF = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int IHIPLDALMOM = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int IONNEIEOEMO = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId BAAPAEECMJF;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public OEENGDBIBNC KKEOBPFILCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6A72900", Offset = "0x6A71900", VA = "0x186A72900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public JMACPFIJEKJ GCAHCPBGCFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6A73C90", Offset = "0x6A72C90", VA = "0x186A73C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public LocalId FBDHPDCKHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6A74060", Offset = "0x6A73060", VA = "0x186A74060")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal NPPPNEJNGDK IKDHFOHOEHA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6A741C0", Offset = "0x6A731C0", VA = "0x186A741C0")]
		get
		{
			return default(NPPPNEJNGDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool HDJFKMFFGDE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6A73B50", Offset = "0x6A72B50", VA = "0x186A73B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool FAHIJOALIHP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6A73CF0", Offset = "0x6A72CF0", VA = "0x186A73CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6A74300", Offset = "0x6A73300", VA = "0x186A74300")]
	public CGNEFKCKCBE(OEENGDBIBNC KMLMKJDJPCP, LocalId BAAPAEECMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
	public LBDNIKJOCAM OIMEKHJDLOD()
	{
		return default(LBDNIKJOCAM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6A74000", Offset = "0x6A73000", VA = "0x186A74000")]
	public static LocalId GCCHPLCKKEJ(CGNEFKCKCBE JFOMNANNJGG)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6A73FC0", Offset = "0x6A72FC0", VA = "0x186A73FC0")]
	public static Entity GCCHPLCKKEJ(CGNEFKCKCBE JFOMNANNJGG)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6A740A0", Offset = "0x6A730A0", VA = "0x186A740A0")]
	public static bool MKBCGNPIJEJ(CGNEFKCKCBE MHGINKKGGNL, CGNEFKCKCBE JCHFDOINNOA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6A74040", Offset = "0x6A73040", VA = "0x186A74040")]
	public static bool KGBNGOIDAMB(CGNEFKCKCBE MHGINKKGGNL, CGNEFKCKCBE JCHFDOINNOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6A741D0", Offset = "0x6A731D0", VA = "0x186A741D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6A73E20", Offset = "0x6A72E20", VA = "0x186A73E20", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6A73D40", Offset = "0x6A72D40", VA = "0x186A73D40", Slot = "4")]
	public int CompareTo(CGNEFKCKCBE ACBLPNJDJBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "5")]
	public bool Equals(CGNEFKCKCBE ACBLPNJDJBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LKJAGLAFKEG
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F240", Offset = "0x6A7E240", VA = "0x186A7F240")]
	public static FDJBMECGDOM POBJONAIPNE(this CGNEFKCKCBE NOPFNIKINJA)
	{
		return default(FDJBMECGDOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F190", Offset = "0x6A7E190", VA = "0x186A7F190")]
	public static LBDNIKJOCAM BHBAACEFIIB(this CGNEFKCKCBE NOPFNIKINJA)
	{
		return default(LBDNIKJOCAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2C7D370", Offset = "0x2C7C370", VA = "0x182C7D370")]
	public static T NNJEAJOPEIF<T>(this CGNEFKCKCBE NOPFNIKINJA) where T : struct, MGJOCMDKJPC
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class JBEAODGMOFH
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct NPPPNEJNGDK : IEquatable<NPPPNEJNGDK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte EFPCBKOLOGB;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] DFCFMCAFJAI;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static OEENGDBIBNC PKMPNMKKDFA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static JMACPFIJEKJ GNBOGFJPILC;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static OEENGDBIBNC[] FGKCIHMEAHM;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static JMACPFIJEKJ[] JOGGMLHFDPM;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> PHEGLNACLOH;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public JMACPFIJEKJ GCAHCPBGCFM
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6A83C30", Offset = "0x6A82C30", VA = "0x186A83C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public OEENGDBIBNC MBAFPIDGKLA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6A84750", Offset = "0x6A83750", VA = "0x186A84750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6A84B20", Offset = "0x6A83B20", VA = "0x186A84B20")]
	static NPPPNEJNGDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x21BB7E0", Offset = "0x21BA7E0", VA = "0x1821BB7E0")]
	internal NPPPNEJNGDK(byte JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5BD3800", Offset = "0x5BD2800", VA = "0x185BD3800", Slot = "4")]
	public bool Equals(NPPPNEJNGDK ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6A843F0", Offset = "0x6A833F0", VA = "0x186A843F0", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1E6FF50", Offset = "0x1E6EF50", VA = "0x181E6FF50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6A84A60", Offset = "0x6A83A60", VA = "0x186A84A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6A849B0", Offset = "0x6A839B0", VA = "0x186A849B0")]
	private static OEENGDBIBNC PJOMHCFJMAI(byte EFPCBKOLOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6A84340", Offset = "0x6A83340", VA = "0x186A84340")]
	private static JMACPFIJEKJ EINEDHJMLEG(byte EFPCBKOLOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6A84830", Offset = "0x6A83830", VA = "0x186A84830")]
	private static object LOBMCCKPEEO(byte EFPCBKOLOGB, object[] ADLAOOMHAPB, object KCDEJIJHLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6A849A0", Offset = "0x6A839A0", VA = "0x186A849A0")]
	private static int NFMPNLDJPPB(byte EFPCBKOLOGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6A83C20", Offset = "0x6A82C20", VA = "0x186A83C20")]
	private static int AIMBABCDMJH(byte EFPCBKOLOGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6A83D10", Offset = "0x6A82D10", VA = "0x186A83D10")]
	private static (int, int) CLGAIGCIPJD(byte EFPCBKOLOGB)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6A83FA0", Offset = "0x6A82FA0", VA = "0x186A83FA0")]
	private static byte DAGCJNBHEJK(int FFOAGBHJNBO, int HCALFJOJKJO)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6A84490", Offset = "0x6A83490", VA = "0x186A84490")]
	internal static NPPPNEJNGDK GGLLICMBJNI(JMACPFIJEKJ MNPAGBNGECE, OEENGDBIBNC INJJFGGOEPO)
	{
		return default(NPPPNEJNGDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6A83D90", Offset = "0x6A82D90", VA = "0x186A83D90")]
	internal static void CNEBNJPACBD(NPPPNEJNGDK EFPCBKOLOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6A83FB0", Offset = "0x6A82FB0", VA = "0x186A83FB0")]
	private static void EHOHMGFMCMP(int BPIECAEAGAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface EGDDNIOEEHN
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJLFOCBEJBL();

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KHKNOFJKFML(bool FFEJDGJHCML);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NONLMIIMDGN(GameObject IDHOMJBMFPB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface LFMGHDMKJII
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Guid DDCHCODNCDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NGNJPKACABF(Guid NFAGKHAOKNB, Guid GODNEBGANDJ, Guid CIGGGEOMIOK);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task GDKJBHLFHAL(Guid NFAGKHAOKNB, Guid[] DKDGNHMNBAJ, Guid CIGGGEOMIOK);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid BIDJOHEKNPF(Guid GFIFEILMJAD);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task OAJCGBOACMO(CGNEFKCKCBE OCMDMJDMIBK);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EMHFFOCHHMG(KNAPGDHPEDB EBEILNAEFOJ, Guid GGHDGCIOPFC);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HBAOEGBAAPD(Guid GFIFEILMJAD, bool HFODIMENHKG);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface ELPHIHAJAON
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FDEOGKEAAOG(LKKANPIGGEI HDBEGMKJNAF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface EOIFLDMJPAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KHPJHJCEPAH(GameObject IPHNGBMBHEA, GameObject MMMJPIIACJH, int KFEHOEEBGJI);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface EPPFHHKPCGP
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	EGDDNIOEEHN DDNCOKNPFJO
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	OHLIOOBCCOP GBADBBPDMGP
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	GFMOHANFBBA PGJFBHLJAJG
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	FKNMFMAHHML HLBFCJNDBEP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	OFILILAPBOD MFEBPLCBFNE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	AMGBNNMNFBP DBLENABNMEL
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	LGFOMNIJHHB OGMOEFHIKJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	JOIJONBEINA HFINJCNEKJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	HEMNFOLJNEO GJGNFFIBDPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	GBHNELKHIAC PKPJKNGLBEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface OHLIOOBCCOP
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string FCDIOJGHEPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface OMKGIFHLJFG
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CHKJMIHAFGI(Action JFOAFIPDIOA, bool BNEPCLNAMMI);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JNGGIJEJDKD(string CKEJJGPNKGO);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int GAAPCCBOLEG(string CKEJJGPNKGO, int KCDEJIJHLPJ);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MFLAPAPCEAA([Out] bool JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BNLFJKCBABG([Out] bool JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NPHFJBGPEPP([Out] int JJCEIJMGOAB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface GFMOHANFBBA
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string BBGEICMFAHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] OCLADNHAPNJ(IEnumerable<KLPLGJPOFHA> BLJNPDNFNLG, bool GNFMKLLAIPE);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KELDCAPBPOD(GameObject IDHOMJBMFPB, [Out] FDJBMECGDOM[] HOBPFEIBGHF);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JGJIJNAIOGE(GameObject IDHOMJBMFPB, [Out] int LMODHFJMDCI, [Out] NCCOBPNELMJ LFOOJAPBKNN);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KNAPGDHPEDB HCEENDLICAJ(KLPLGJPOFHA HHNBCLDGHCL);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KNAPGDHPEDB HCEENDLICAJ(string EDIGKGDEKFI, FDJBMECGDOM[] FGMNEAGEGFD, Vector3 LLLHNMGEKPM, Quaternion BCKIPOGEHOJ, Vector3 FHBDGLOPEKN);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KNAPGDHPEDB CMJLJJPECAI(string EDIGKGDEKFI, FDJBMECGDOM[] FGMNEAGEGFD, Vector3 LLLHNMGEKPM, Quaternion BCKIPOGEHOJ, Vector3 FHBDGLOPEKN);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject JHIHGCIBHNH(string EDIGKGDEKFI);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BAHFENFLECB(GameObject FEIKIFLEMIB, bool HHLLKDECJCM);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DHOGFPOBLNE(GameObject IDHOMJBMFPB, bool NJDFJKMHPCO, bool FNMBONKNIDF);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class NDDCLNOCIOI
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A815D0", Offset = "0x6A805D0", VA = "0x186A815D0")]
	public static KNAPGDHPEDB HCEENDLICAJ(this GFMOHANFBBA LCGMLIBOFMO, Vector3 LLLHNMGEKPM, Quaternion BCKIPOGEHOJ, Vector3 FHBDGLOPEKN, params FDJBMECGDOM[] HOBPFEIBGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A81470", Offset = "0x6A80470", VA = "0x186A81470")]
	public static KNAPGDHPEDB CMJLJJPECAI(this GFMOHANFBBA LCGMLIBOFMO, Vector3 LLLHNMGEKPM, Quaternion BCKIPOGEHOJ, Vector3 FHBDGLOPEKN, params FDJBMECGDOM[] HOBPFEIBGHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface FKNMFMAHHML
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void APBPPAKLFNL(bool HFODIMENHKG);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface OFILILAPBOD
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool PBFAEHLMCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool DAEPGHIJCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool PFMCJFNGOKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	int MBJPOAMFIGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool BHKKFANHHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ODBIEFHBNNE(object KLINFCCHIED);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PEOGONFKPFD(object KLINFCCHIED);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PKICPJEIAMJ(object KAEDHDLBKFF);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GHHMLLLFIOE(object KAEDHDLBKFF);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ViewId EKLHBLGDIFG(GameObject PKODOKGPNGI);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LCDCDGNOAAI(NativeArray<ViewId> BEMEAMOEEBJ);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PLBHHDHDJGO(NativeArray<ViewId> KANOJHOKBCA);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LFILHOLNGNI();

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FBGJIIEEBDB(uint EOGGDDCOADP, ReadOnlySpan<byte> BCCCEJCHLCN, bool EDGGMOMNOPP = false);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FBGJIIEEBDB(uint EOGGDDCOADP, ReadOnlySpan<byte> BCCCEJCHLCN, ReadOnlySpan<byte> NDCCKEKOBOJ, bool EDGGMOMNOPP = false);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NINDGJBHFGG(Func<int, bool, int> LCIOJOBBCGK, bool JOMJADBPDMA);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JCGMOAMAALI(object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EJDEHNNHEJO(object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "18")]
	uint DCPHBEFIFNN(uint BOJMPDAJCJP);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class OOCOBGKMNJG
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6A85EE0", Offset = "0x6A84EE0", VA = "0x186A85EE0")]
	public static FMCDOFJMDJH PNBINMFPBIP(this OFILILAPBOD JAJIMFKDCOE, object DJIBMMAIGPE)
	{
		return default(FMCDOFJMDJH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct FMCDOFJMDJH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private OFILILAPBOD JAJIMFKDCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private object DJIBMMAIGPE;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6A78BC0", Offset = "0x6A77BC0", VA = "0x186A78BC0")]
	public FMCDOFJMDJH(OFILILAPBOD JAJIMFKDCOE, object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6A78B70", Offset = "0x6A77B70", VA = "0x186A78B70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface AMGBNNMNFBP
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJFPJKDLIMF(GameObject IDHOMJBMFPB);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface LGFOMNIJHHB
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public struct BOIGBKEGPNL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private LGFOMNIJHHB NEDAHABDJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Task FGPHJGHMKNM;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Task GBALFINANAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x99F860", Offset = "0x99E860", VA = "0x18099F860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6A73A60", Offset = "0x6A72A60", VA = "0x186A73A60")]
		public BOIGBKEGPNL(LGFOMNIJHHB NEDAHABDJKI, CancellationToken LABHBAHABKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6A73A10", Offset = "0x6A72A10", VA = "0x186A73A10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOCIDOMFGHK(string KKHEHGHPOAA, float OCJBGOIAOCN = 5f);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CHAJKABCKPD(CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LBLFIBJEEDO();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class NMEABOEKDJG
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6A83C00", Offset = "0x6A82C00", VA = "0x186A83C00")]
	public static LGFOMNIJHHB.BOIGBKEGPNL HOCEMBLFIPG(this LGFOMNIJHHB JAJIMFKDCOE, CancellationToken LABHBAHABKB)
	{
		return default(LGFOMNIJHHB.BOIGBKEGPNL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface GDAGOLDHCBJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NJMMJIPEAIN(GameObject IDHOMJBMFPB);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKLAJLKLMBB(GameObject IDHOMJBMFPB);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HCNICPIEJFB(int NAOBJALFMLA);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object PDIDACKMGMK(CGNEFKCKCBE BAAPAEECMJF, GameObject IDHOMJBMFPB, Action<CGNEFKCKCBE, int> IPCEAEAAIHH);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LLFCKAJFBDK(GameObject IDHOMJBMFPB, object IJGOPLKINAD);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface DJLAKGPLOMB
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool CKHAKNIFJMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate CCCDMODIJDN(ICLBEHGHDBC.JGLNNOKBOGG NBLBOOALGMD, Action<ICLBEHGHDBC.JGLNNOKBOGG> IPCEAEAAIHH);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LHINJNGOABL(ICLBEHGHDBC.JGLNNOKBOGG NBLBOOALGMD, Delegate IPCEAEAAIHH);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate GPAJIOAIGLE(ICLBEHGHDBC.JGLNNOKBOGG NBLBOOALGMD, Action<ICLBEHGHDBC.JGLNNOKBOGG> PGDAPCPOLHN);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LFNJCCFMIDI(ICLBEHGHDBC.JGLNNOKBOGG NBLBOOALGMD, Delegate IPCEAEAAIHH);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LLPBCOPOAND(ICLBEHGHDBC.JGLNNOKBOGG NBLBOOALGMD);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ICLBEHGHDBC.JGLNNOKBOGG FFGNKOFGLHB(GameObject IDHOMJBMFPB);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface JOIJONBEINA
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	int GGPGGLEPIHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	int MCLPMEIIJLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int KKOALLJKEGN(GameObject IDHOMJBMFPB);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PCKDFLOJMLF([Out] Vector3 LLLHNMGEKPM);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NEIDEIAPOJN();

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CGNEFKCKCBE PLIFCOCBJID(int NAOBJALFMLA);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface HEMNFOLJNEO
{
	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool NHMKMKCLJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface HJLCLEOHDNG
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	DACPOCCEKDB MKAIBGMIFLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	BIHIHPCPJOP CBKPJDOCACI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KCGNECLPMBD(Transform DBCCBLKNBHK);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BEHFAALMFCF(Transform DBCCBLKNBHK, CNPNPNNGEDP NFJBNLCNEMH);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HFBEKPLEJHC(Transform DBCCBLKNBHK, IEOFDADILNN ODDDGHEKLOB);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface MBEMIMFBGGD
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface GBHNELKHIAC
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action JEBAGFKBMGP;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FHGFDCFGNMI(LKKANPIGGEI EMBINKFIGKB, bool LBDGPIJOEOA);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface AIMFGKHBPLC
{
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKBPCEJBAFG();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface NMABGJEPPIH
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NCCOBPNELMJ HNHBKOAGLBL(GameObject PKODOKGPNGI);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MFLJBGODLCO(GameObject IDHOMJBMFPB, AKKFFPHNNIN HGNOFHEIFAH, PGCGAELAGGH MFCIDNEHILL);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HFFPNECIJDH(CGNEFKCKCBE BAAPAEECMJF, bool CKHCPCBDNLM, float3 KNCFGBCLHKB, quaternion GKHAPALPCAD);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HFCEIINIJIK(LBDNIKJOCAM HMLGIEBFMDJ, LBDNIKJOCAM KAEDHDLBKFF, MLMCOPCJNLO GKANCDPDLNF);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CKELDJLAPPJ(LBDNIKJOCAM HMLGIEBFMDJ, MLMCOPCJNLO GKANCDPDLNF);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FJKOIFOPOBH(LKKANPIGGEI CCFCGPNLFED);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AGOOBHAPCDM(LKKANPIGGEI AAAODCCDNKB, NativeArray<LocalPoseData> CMLKHNCFBEJ, NativeArray<float3> GLBKCGEPNFI);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EEBJAPBHGIB(LKKANPIGGEI AAAODCCDNKB, LKKANPIGGEI LBOPPCOKBKL);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IGNNPDAAHMN(LKKANPIGGEI AAAODCCDNKB, bool DLKPOLMMAEO);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void COGMOGDOEJG(LKKANPIGGEI AAAODCCDNKB, bool BKONGNPFKPP);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct ODPBHFDDNBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly IGIIPLJFPJI KKONFBKDDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly IGIIPLJFPJI NBLBDKMENFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly uint HBJMNLPCEKM;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6A84D90", Offset = "0x6A83D90", VA = "0x186A84D90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct KFGKBKFKPEH
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly ODPBHFDDNBH JFOAFIPDIOA;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A77F80", Offset = "0x6A76F80", VA = "0x186A77F80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct EAHLPMGEIJN
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal readonly ODPBHFDDNBH JFOAFIPDIOA;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6A77F80", Offset = "0x6A76F80", VA = "0x186A77F80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct IDDHAGKFOGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal readonly uint HBJMNLPCEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal readonly bool JLANBLKEBPF;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B9A0", Offset = "0x6A7A9A0", VA = "0x186A7B9A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct IGIIPLJFPJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal int BEMLKOBANDO;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BBA0", Offset = "0x6A7ABA0", VA = "0x186A7BBA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface FCBIOIKODNB
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	LPINILDKFDM JHGOJHLNJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum GDONGHDJMCO
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
public interface KNAPGDHPEDB : MOBKLCFLHDA
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	GDONGHDJMCO OJPNGKMLDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool HLJPNEKIEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GameObject IDHOMJBMFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<KNAPGDHPEDB> LNMMCKLGGNG;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(ACKGFBDMFHC EJDHINIBNLN, CGNEFKCKCBE CJDMIKFIPBM);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool FJGIIMPBAFE);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class GCJOPJIAHDO
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A260", Offset = "0x6A79260", VA = "0x186A7A260")]
	public static bool OCMGEBDGBAP(this KNAPGDHPEDB MAGHAAOCCIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A1C0", Offset = "0x6A791C0", VA = "0x186A7A1C0")]
	public static bool HBHEFFNJPNF(this KNAPGDHPEDB MAGHAAOCCIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A210", Offset = "0x6A79210", VA = "0x186A7A210")]
	public static bool JHMHMOKDKJH(this KNAPGDHPEDB MAGHAAOCCIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A130", Offset = "0x6A79130", VA = "0x186A7A130")]
	public static bool HALEFOFGOBN(this KNAPGDHPEDB MAGHAAOCCIG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface MOBKLCFLHDA
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool EFBLDNCDHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	CGNEFKCKCBE KEHFAMPKBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface HOPHAABJPMP
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate void IMFEBEPNEOM(GBDIJAHBFBE AMGMOPCMLMI);

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event IMFEBEPNEOM LOAKGMAEDOH;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface PIAPDBEGNAC
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PHBDLDCNOJJ(Vector3 LLLHNMGEKPM, Quaternion BCKIPOGEHOJ, Vector3 FHBDGLOPEKN);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MLPLIFGNEGJ(CGNEFKCKCBE EMOKCJBMKOL);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MGLBBFHNKDK(bool NPKKMPFLHJC);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GHEFMMONEML(bool BKONGNPFKPP);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface GGNJCIKMKJL
{
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface LAKIPJGLGKB
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(FKKFNKHOOAA DHEIPOCKMIM);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface FKKFNKHOOAA
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	GameObject IDHOMJBMFPB
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	Transform DBCCBLKNBHK
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	DFKFCELAIFJ NHKFGBDMHPC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool IAGFDAGEIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GCNJEFMPGJB(DFKFCELAIFJ OEFGKJLECGH);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface DFKFCELAIFJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	CGNEFKCKCBE KEHFAMPKBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	Rigidbody MIEMDJAPKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	FKKFNKHOOAA INAHDPOKPPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	GameObject AKFNNOMHACD
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Transform EALAKNFEFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	DFKFCELAIFJ EOBHJDGKNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	DFKFCELAIFJ KILMHGFMJMD
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	int OJEOKFFHDBD
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool LLPBCOPOAND
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool HIGNAPNNMIG
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	GHKLKADMCLK MAOOOBLDOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "31")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	JLDEAACPJLG OIKNHNOABJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	float LDIJOKADLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "35")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 BPFENOHBMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 HCOGDBJHCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	Vector3 BLLHMKAKHKP
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 HKHJELDKBGA
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool MKCIOKCMEML
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool IFCCNAKJLMN
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	bool DLGMMAHDEFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 PBFJHAANDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 NIMMPMMFIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 IAKOELCOBDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "50")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Vector3 OBEIAONFNHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	float GBGMHHELEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	float EJFLHGNKANJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	Vector3 AAHHOMEFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Quaternion MCHGPDENHCH
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	float IGBCDKAFKFD
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	float NCMDNGFEPNA
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	bool LPOAFHJMOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	OIAPKHBMKCC EEMHNCNBDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool FECJGCKLHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Transform LAPFKIMJCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 DCAOJBAHOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float MAMICFLBBEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	float IMINBOBANMB
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Quaternion FLFGHMPBLPK
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 OFOBIKFANPO
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Quaternion IMOOEMJKGCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	RigidbodyConstraints ENOOHPAIPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool HBBNKPPIMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	CollisionDetectionMode MKJGANAAIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool LNEJAIMOMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event JMLNINKIFHA IGFHFJKFGJF;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event JMLNINKIFHA DDAMOFBGOLC;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event JMLNINKIFHA JLECKOCGJCJ;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event JMLNINKIFHA IBBFENNFMDH;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event JMLNINKIFHA CNAFCFDIHHM;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event JMLNINKIFHA KAHCDMPJAFG;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event JMLNINKIFHA CDLFDNALIHG;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event ILNJNDCGDOB COGNAEOHMBE;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<OOGOAJCGPNN, OOGOAJCGPNN> JACGAKDPIAP;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	DFKFCELAIFJ OLACCODENNC(int HCALFJOJKJO);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void IGJDLHBDBKE((Quaternion rot, Vector3 moments) FGEFCHPKOHN);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void HKPMLCIOMID();

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void DDONIAFOEKJ();

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void BHBBAJEBOMH();

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void NCGLFOBFHHE();

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void MLPLIFGNEGJ(DFKFCELAIFJ JJCEIJMGOAB, bool PANBHGCACAL = false);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void HLNALJAOEID(object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void MPCACKOBFFM(object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 KEKMJGLJNJP(Vector3 NKDCMJAIHCA);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "95")]
	Vector3 MMAAAIDDKKN(Vector3 CCMFHJLEKOG);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void BACIIGGFLGE();

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void CEECMIGGMDF();

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void IBFPMPLPMAI();

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void ENBDCHCJMNC(Vector3 KBJBGEBKDGD, Vector3 DGLIDJNFFDG);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void JPHIHPPKNEJ(Vector3 NIDALEFHFGP, Vector3 AMMNBNBOHHD);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void CLIGPBPPJPB(Vector3 CGJNBPCMBLF);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void ELKLHMOPGNC(PINDDEBDGAN LJHIOLBCCLM, Vector3 CHJCBNCKLNJ, float PENDKPMEBEM, float IHDHJOHPOID = 8f, float CPJCMINNEPA = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void MEMDAICICEL(IMFKBKBHMKC BPMCIHAHBEP, Vector3 PKAILENOOIF, float HKJPMNKBPCD = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void JNNKCEADNND(IMFKBKBHMKC BPMCIHAHBEP, Vector3 BCKIPOGEHOJ, float BCBOHKMEOIN = 7f, float CBILEDLNPGP = 1f);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "105")]
	Vector3 IGCHDLIAKLN(Vector3 JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "106")]
	Vector3 AEEMBIJBBMG(Vector3 JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void JFAINLNIDHF();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void BCIPOJDCHAJ(DFKFCELAIFJ ILALMEILOHO, object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "109")]
	void MJDECCJNCCG(object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void DJJBEGFPKFN();

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void CGFDKPKFDKM();

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void DCMCPIBNEPN();

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "113")]
	bool FIMHINPOPMB();

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void FKAKBCDENJE();

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void BLNGBDGGJDB(object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "116")]
	void NMDIMOEGJIM(object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void GCKPKKDAKDO(object DJIBMMAIGPE, bool NMJDAPPHKKG);

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void GGIJNBBCPOA(Vector3 OJPBAJPHPBB, Quaternion HCIAOOMDBFP);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void EJFMOCIPCID(Vector3 COLCOHHOFKK, Quaternion ODBILIAIDFP);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "120")]
	bool PCOLKMDAJHA(float JOGFACAPCBE);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void MJELHKNAIJI(object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void HDDPGLGIPOI(object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void CGAAOOCFJLO(object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void BEDABBIDNKK(object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void NPPFCGBENNC(Vector3 HPJKELEMMFE, ForceMode FEOIDGGLIEB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void OFLICFLBDJG(Vector3 HPJKELEMMFE, Vector3 LLLHNMGEKPM, ForceMode FEOIDGGLIEB);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void KMPIHOIHHMG(Vector3 BGMBOOCPFBE, ForceMode FEOIDGGLIEB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void JLGLLONLHNO(Vector3 BGMBOOCPFBE, ForceMode FEOIDGGLIEB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "129")]
	bool BOLPAFLMHKH(Vector3 DJAIHLPIJBH, [Out] RaycastHit IJJOILIEHOI, float BIJEBEJFKBC);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void MGAKKCHNFAK();
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface JLDEAACPJLG
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGNBLOFFADN(Vector3 NOGLMNPMJOC);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ICADIOOJBAG(Vector3 IFMDAJCPKED);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JIOMJFILBKL(Vector3 NOGLMNPMJOC);

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ILGGMDAPOHC(Vector3 IFMDAJCPKED);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface GHKLKADMCLK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 CJFHHLDPLKI();

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 JJNIEMKEABP();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public delegate void JMLNINKIFHA(FKKFNKHOOAA GGALDCKOEDC);
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum JDCEAEFONLN
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
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum PINDDEBDGAN
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
[Cpp2IlInjected.Token(Token = "0x2000043")]
public delegate void ILNJNDCGDOB(FKKFNKHOOAA GGALDCKOEDC, bool PANBHGCACAL = false);
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum IMFKBKBHMKC
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct KFNPMFNDCGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Rigidbody KHNFKMKPMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public object KDEMNNBJFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector3 OLADPOLGPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector3 GIBIPKFLPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public JMHIAMIADEH DJMDNPHHLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool ABDBCKHOBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool PLEJDDHIGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool KFOHBBOIPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool AAPAPMLEIFF;
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface OHCDDLDJCLN : DMAJFPJENEJ<FDJBMECGDOM>, GCALMPIEPIK, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface JEGPLOJNKLG<T> : ENAKDCHIELK<FDJBMECGDOM, T>, DMAJFPJENEJ<FDJBMECGDOM>, GCALMPIEPIK, IDisposable, OHCDDLDJCLN where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class KIABDHEEBHF
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2C720D0", Offset = "0x2C710D0", VA = "0x182C720D0")]
	public static bool KBNDOKPPALD<T>(this DMAJFPJENEJ<FDJBMECGDOM> HNKKKCPLLDH, FDJBMECGDOM FGMNEAGEGFD, [Out] T JJCEIJMGOAB) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7BE0", Offset = "0x2BB6BE0", VA = "0x182BB7BE0")]
	public static bool HACKMLKKHNE<T>(this DMAJFPJENEJ<FDJBMECGDOM> HNKKKCPLLDH, FDJBMECGDOM FGMNEAGEGFD, [In] T ECCBDOCBJDI) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface NAFJPIJGFIL : DMAJFPJENEJ<CGNEFKCKCBE>, GCALMPIEPIK, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface JJGNFGMBJGI<T> : ENAKDCHIELK<CGNEFKCKCBE, T>, DMAJFPJENEJ<CGNEFKCKCBE>, GCALMPIEPIK, IDisposable, NAFJPIJGFIL where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class NBGOMNCPIMG
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x298BCD0", Offset = "0x298ACD0", VA = "0x18298BCD0")]
	public static T MKHPGHPCCLG<T>(this DMAJFPJENEJ<CGNEFKCKCBE> HNKKKCPLLDH, CGNEFKCKCBE BAAPAEECMJF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7BE0", Offset = "0x2BB6BE0", VA = "0x182BB7BE0")]
	public static bool HACKMLKKHNE<T>(this DMAJFPJENEJ<CGNEFKCKCBE> HNKKKCPLLDH, CGNEFKCKCBE BAAPAEECMJF, [In] T ECCBDOCBJDI) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct GJDOIBPJHGJ : IComparable<GJDOIBPJHGJ>, IEquatable<GJDOIBPJHGJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly GJDOIBPJHGJ JDOOJIEMHEC;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly GJDOIBPJHGJ GIHFMEDBBLI;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly GJDOIBPJHGJ EEMIJLHMFPG;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly GJDOIBPJHGJ LMFGKKKCGMK;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly GJDOIBPJHGJ INPOHKIKBFC;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly GJDOIBPJHGJ NHIKPEKPNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public int LCNJIFOOGIB;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool FKIMNHICENH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6A7A800", Offset = "0x6A79800", VA = "0x186A7A800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public int HFCCMEKLLFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6A7A810", Offset = "0x6A79810", VA = "0x186A7A810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0xB57260", Offset = "0xB56260", VA = "0x180B57260")]
	public GJDOIBPJHGJ(int HCALFJOJKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A7A0", Offset = "0x6A797A0", VA = "0x186A7A7A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A710", Offset = "0x6A79710", VA = "0x186A7A710", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0xAE2210", Offset = "0xAE1210", VA = "0x180AE2210", Slot = "5")]
	public bool Equals(GJDOIBPJHGJ ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x1B94100", Offset = "0x1B93100", VA = "0x181B94100", Slot = "4")]
	public int CompareTo(GJDOIBPJHGJ ACBLPNJDJBF)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C640", VA = "0x180E6D640")]
	public static GJDOIBPJHGJ GCCHPLCKKEJ(int HCALFJOJKJO)
	{
		return default(GJDOIBPJHGJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C640", VA = "0x180E6D640")]
	public static int GCCHPLCKKEJ(GJDOIBPJHGJ ILCJHJBBALD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A820", Offset = "0x6A79820", VA = "0x186A7A820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct LBDNIKJOCAM : IEquatable<LBDNIKJOCAM>, MOBKLCFLHDA
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly LBDNIKJOCAM BEIBFMDMNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CGNEFKCKCBE KEHFAMPKBDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870", Slot = "6")]
		get
		{
			return default(CGNEFKCKCBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public NKABHKLHFBI EALAKNFEFIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(NKABHKLHFBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public GAHEIIBAKPC MMPINNONJMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(GAHEIIBAKPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private OEENGDBIBNC KKEOBPFILCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6A72900", Offset = "0x6A71900", VA = "0x186A72900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public GameObject IDHOMJBMFPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6A7EF20", Offset = "0x6A7DF20", VA = "0x186A7EF20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public FDJBMECGDOM FKKBHGNJHDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6A7ED90", Offset = "0x6A7DD90", VA = "0x186A7ED90")]
		get
		{
			return default(FDJBMECGDOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public JNJKFNOHIAL BAMFLHJOKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6A7EC30", Offset = "0x6A7DC30", VA = "0x186A7EC30")]
		get
		{
			return default(JNJKFNOHIAL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public NCCOBPNELMJ BLGICAECFOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6A7ECD0", Offset = "0x6A7DCD0", VA = "0x186A7ECD0")]
		get
		{
			return default(NCCOBPNELMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool CJLMKMGHDDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E8B0", Offset = "0x6A7D8B0", VA = "0x186A7E8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool EHHMJLBLDPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6A7EEC0", Offset = "0x6A7DEC0", VA = "0x186A7EEC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool PBHFPOLBKIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6A7EF00", Offset = "0x6A7DF00", VA = "0x186A7EF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool MDJPBFGIHCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6A7EEE0", Offset = "0x6A7DEE0", VA = "0x186A7EEE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool JLCEELNJHDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6A7EE70", Offset = "0x6A7DE70", VA = "0x186A7EE70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool LIJOHCMOAFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6A7ED70", Offset = "0x6A7DD70", VA = "0x186A7ED70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool NIIDMEIHMGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6A7EAA0", Offset = "0x6A7DAA0", VA = "0x186A7EAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool PBFCMDGKFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6A7EE30", Offset = "0x6A7DE30", VA = "0x186A7EE30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool FMNBANEFNOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E9F0", Offset = "0x6A7D9F0", VA = "0x186A7E9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public FNEBNOHNABN MIHHHGLEGKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(FNEBNOHNABN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public MFHPFAOGFID DPAHMIGHMFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(MFHPFAOGFID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public ELFKJIJPDAO LMOMJKJKNAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(ELFKJIJPDAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public KDCMMCKPCLC OIGMCKADHOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(KDCMMCKPCLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public OFPDDADNENA EOGFGBPELCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(OFPDDADNENA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public BCAJCGOCNEE HKOELCCCPOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(BCAJCGOCNEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public CPPKGMGKFMC GDPCOEFGACG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(CPPKGMGKFMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public LPEMIKKPCLF DAPEBOPADCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LPEMIKKPCLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PPMJKDPAEDN EMFBPHEJEKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(PPMJKDPAEDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public ILAIGGNLLLN DODFDPJAKPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(ILAIGGNLLLN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public DOOJKPAGJMP JAOLGDMAAHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(DOOJKPAGJMP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public MDDAJDOJAAE PFCBKIFMDCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(MDDAJDOJAAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool OCMGEBDGBAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E900", Offset = "0x6A7D900", VA = "0x186A7E900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool LBGODFLJGIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6A7EAE0", Offset = "0x6A7DAE0", VA = "0x186A7EAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool NHDKHEOOBMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6A7EBF0", Offset = "0x6A7DBF0", VA = "0x186A7EBF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	private bool LNNLBCLMCFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
	public LBDNIKJOCAM(CGNEFKCKCBE BAAPAEECMJF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6A758F0", Offset = "0x6A748F0", VA = "0x186A758F0")]
	public static bool GCCHPLCKKEJ(LBDNIKJOCAM JJCEIJMGOAB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x97DF10", Offset = "0x97CF10", VA = "0x18097DF10")]
	public static CGNEFKCKCBE GCCHPLCKKEJ(LBDNIKJOCAM JJCEIJMGOAB)
	{
		return default(CGNEFKCKCBE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x6A764D0", Offset = "0x6A754D0", VA = "0x186A764D0")]
	public static bool MKBCGNPIJEJ(LBDNIKJOCAM MHGINKKGGNL, LBDNIKJOCAM JCHFDOINNOA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x6A74040", Offset = "0x6A73040", VA = "0x186A74040")]
	public static bool KGBNGOIDAMB(LBDNIKJOCAM MHGINKKGGNL, LBDNIKJOCAM JCHFDOINNOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6A7EA10", Offset = "0x6A7DA10", VA = "0x186A7EA10", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(LBDNIKJOCAM ACBLPNJDJBF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x97DF10", Offset = "0x97CF10", VA = "0x18097DF10")]
	public static LBDNIKJOCAM GCCHPLCKKEJ(CGNEFKCKCBE BEHCCOMHFAP)
	{
		return default(LBDNIKJOCAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6A7EB20", Offset = "0x6A7DB20", VA = "0x186A7EB20")]
	public CNPBEIPHOEC HPOHMPMBPAA()
	{
		return default(CNPBEIPHOEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6A7EE90", Offset = "0x6A7DE90", VA = "0x186A7EE90")]
	public KBNKPNADCNC NNELGNAAGIM()
	{
		return default(KBNKPNADCNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6A7EBA0", Offset = "0x6A7DBA0", VA = "0x186A7EBA0")]
	public FJOBILDGDJD IMDOLFBIFMK()
	{
		return default(FJOBILDGDJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E8D0", Offset = "0x6A7D8D0", VA = "0x186A7E8D0")]
	public IGAHIIEAGMI CMKBHAELONM()
	{
		return default(IGAHIIEAGMI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E810", Offset = "0x6A7D810", VA = "0x186A7E810")]
	public void BHBAACEFIIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F0B0", Offset = "0x6A7E0B0", VA = "0x186A7F0B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct CPPKGMGKFMC : IEquatable<CPPKGMGKFMC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public CGNEFKCKCBE KEHFAMPKBDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(CGNEFKCKCBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private OEENGDBIBNC KKEOBPFILCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6A72900", Offset = "0x6A71900", VA = "0x186A72900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private FNLPLJPPMJI DDEKKFALKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6A76E80", Offset = "0x6A75E80", VA = "0x186A76E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private FMBFPNOAMOB HAOOFPCHNDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6A768F0", Offset = "0x6A758F0", VA = "0x186A768F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool IEIOFLHCPKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6A76D50", Offset = "0x6A75D50", VA = "0x186A76D50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Guid IIKIBPOGNLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A76C30", Offset = "0x6A75C30", VA = "0x186A76C30")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool DMOMCLJNFPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6A76950", Offset = "0x6A75950", VA = "0x186A76950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public Guid JNCNODOOAEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6A76F10", Offset = "0x6A75F10", VA = "0x186A76F10")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
	public CPPKGMGKFMC(CGNEFKCKCBE BAAPAEECMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6A76BA0", Offset = "0x6A75BA0", VA = "0x186A76BA0", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(CPPKGMGKFMC ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6A76B00", Offset = "0x6A75B00", VA = "0x186A76B00")]
	public bool ECPFIMBKOJG([Out] Guid GFIFEILMJAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A769E0", Offset = "0x6A759E0", VA = "0x186A769E0")]
	public void DIJNKOPAFHO(Guid AAINAOCHJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6A76DE0", Offset = "0x6A75DE0", VA = "0x186A76DE0")]
	public bool FKPDLFGIHFJ([Out] Guid GODNEBGANDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6A76740", Offset = "0x6A75740", VA = "0x186A76740")]
	public void BCDKFFADELA(Guid AAINAOCHJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6A76860", Offset = "0x6A75860", VA = "0x186A76860")]
	public void BENJCOLJPII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct FJOBILDGDJD : IEquatable<FJOBILDGDJD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public CGNEFKCKCBE KEHFAMPKBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(CGNEFKCKCBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private OEENGDBIBNC KKEOBPFILCO
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6A72900", Offset = "0x6A71900", VA = "0x186A72900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private FNLPLJPPMJI DDEKKFALKJA
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6A789A0", Offset = "0x6A779A0", VA = "0x186A789A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private OCMGEOKHNIG FPDLFINMJFO
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6A78940", Offset = "0x6A77940", VA = "0x186A78940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 OAEBHJNLJJA
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6A787F0", Offset = "0x6A777F0", VA = "0x186A787F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public Quaternion MFHCNCIDKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6A78A30", Offset = "0x6A77A30", VA = "0x186A78A30")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public LBDNIKJOCAM FFOHPFPNDEM
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6A78470", Offset = "0x6A77470", VA = "0x186A78470")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
	public FJOBILDGDJD(CGNEFKCKCBE BAAPAEECMJF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6A758F0", Offset = "0x6A748F0", VA = "0x186A758F0")]
	public static bool GCCHPLCKKEJ(FJOBILDGDJD JJCEIJMGOAB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x97DF10", Offset = "0x97CF10", VA = "0x18097DF10")]
	public static CGNEFKCKCBE GCCHPLCKKEJ(FJOBILDGDJD JJCEIJMGOAB)
	{
		return default(CGNEFKCKCBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6A78650", Offset = "0x6A77650", VA = "0x186A78650", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(FJOBILDGDJD ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6A78500", Offset = "0x6A77500", VA = "0x186A78500")]
	public void EECEAKDEHLD(Vector3 LLLHNMGEKPM, Quaternion BCKIPOGEHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6A786E0", Offset = "0x6A776E0", VA = "0x186A786E0")]
	public void FEKOKLAEDJD(float FHBDGLOPEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6A782B0", Offset = "0x6A772B0", VA = "0x186A782B0")]
	public void DDKHBHHFCCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct CNPBEIPHOEC : IEquatable<CNPBEIPHOEC>
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly CNPBEIPHOEC BEIBFMDMNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public CGNEFKCKCBE KEHFAMPKBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(CGNEFKCKCBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public NKABHKLHFBI EALAKNFEFIK
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(NKABHKLHFBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public GAHEIIBAKPC MMPINNONJMG
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(GAHEIIBAKPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private OEENGDBIBNC KKEOBPFILCO
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x6A72900", Offset = "0x6A71900", VA = "0x186A72900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private FNLPLJPPMJI DDEKKFALKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6A76170", Offset = "0x6A75170", VA = "0x186A76170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private AFOMIBACJBH LIPOOGIDHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6A74BF0", Offset = "0x6A73BF0", VA = "0x186A74BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public LKKANPIGGEI AFLECFHAHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6A75C80", Offset = "0x6A74C80", VA = "0x186A75C80")]
		get
		{
			return default(LKKANPIGGEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public IEnumerable<LBDNIKJOCAM> NMONFNJHMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6A75AB0", Offset = "0x6A74AB0", VA = "0x186A75AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public IEnumerable<LBDNIKJOCAM> HPMLHHJPKCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6A76200", Offset = "0x6A75200", VA = "0x186A76200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public int OJEOKFFHDBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6A75860", Offset = "0x6A74860", VA = "0x186A75860")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public int PKOHAFKNPJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x6A75810", Offset = "0x6A74810", VA = "0x186A75810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public string NPDJPDJBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6A76620", Offset = "0x6A75620", VA = "0x186A76620")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x6A76570", Offset = "0x6A75570", VA = "0x186A76570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public OLHMOHMFBLK MNBPEANGEMA
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6A76330", Offset = "0x6A75330", VA = "0x186A76330")]
		get
		{
			return default(OLHMOHMFBLK);
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6A763F0", Offset = "0x6A753F0", VA = "0x186A763F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public KMMJKNLOIKA OACOHAJJHLB
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6A75980", Offset = "0x6A74980", VA = "0x186A75980")]
		get
		{
			return default(KMMJKNLOIKA);
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6A74C50", Offset = "0x6A73C50", VA = "0x186A74C50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public ELGHMGLNMDC CCNMBEIDIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x6A75D40", Offset = "0x6A74D40", VA = "0x186A75D40")]
		get
		{
			return default(ELGHMGLNMDC);
		}
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x6A76460", Offset = "0x6A75460", VA = "0x186A76460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public float OLEOGFILOGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x6A76390", Offset = "0x6A75390", VA = "0x186A76390")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x6A75A40", Offset = "0x6A74A40", VA = "0x186A75A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool MPHPLNHHKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6A759E0", Offset = "0x6A749E0", VA = "0x186A759E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6A757A0", Offset = "0x6A747A0", VA = "0x186A757A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool MBFIMBGMHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6A754F0", Offset = "0x6A744F0", VA = "0x186A754F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x6A75480", Offset = "0x6A74480", VA = "0x186A75480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool IMCGMFIHMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6A76110", Offset = "0x6A75110", VA = "0x186A76110")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6A76500", Offset = "0x6A75500", VA = "0x186A76500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool AHOOGBOIGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6A75C20", Offset = "0x6A74C20", VA = "0x186A75C20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6A75730", Offset = "0x6A74730", VA = "0x186A75730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool GHLKFBPCBDK
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6A75550", Offset = "0x6A74550", VA = "0x186A75550")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6A756C0", Offset = "0x6A746C0", VA = "0x186A756C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool GDAHMDFDBLB
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6A74CC0", Offset = "0x6A73CC0", VA = "0x186A74CC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6A766D0", Offset = "0x6A756D0", VA = "0x186A766D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
	public CNPBEIPHOEC(CGNEFKCKCBE BAAPAEECMJF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6A758F0", Offset = "0x6A748F0", VA = "0x186A758F0")]
	public static bool GCCHPLCKKEJ(CNPBEIPHOEC JJCEIJMGOAB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6A764D0", Offset = "0x6A754D0", VA = "0x186A764D0")]
	public static bool MKBCGNPIJEJ(CNPBEIPHOEC MHGINKKGGNL, CNPBEIPHOEC JCHFDOINNOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6A75630", Offset = "0x6A74630", VA = "0x186A75630", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(CNPBEIPHOEC ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x97DF10", Offset = "0x97CF10", VA = "0x18097DF10")]
	public static LBDNIKJOCAM GCCHPLCKKEJ(CNPBEIPHOEC KALCJEIICGB)
	{
		return default(LBDNIKJOCAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6A764E0", Offset = "0x6A754E0", VA = "0x186A764E0")]
	public bool MLIEOEEBOGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6A75910", Offset = "0x6A74910", VA = "0x186A75910")]
	public bool GMFBNBCEMIO(CCGENIJLDEA BKDPCDNGDKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6A755B0", Offset = "0x6A745B0", VA = "0x186A755B0")]
	public void EBPBHCICLEH(CCGENIJLDEA BKDPCDNGDKK, bool JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6A74D20", Offset = "0x6A73D20", VA = "0x186A74D20")]
	public LKKANPIGGEI CDPNGCKFDON(Allocator OOMMBGGEBLM)
	{
		return default(LKKANPIGGEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6A75DA0", Offset = "0x6A74DA0", VA = "0x186A75DA0")]
	public void KCFNDBLNJGF(CNPBEIPHOEC ACBLPNJDJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6A74ED0", Offset = "0x6A73ED0", VA = "0x186A74ED0")]
	public void CEDCKJMOHHO(List<LBDNIKJOCAM> NIJMADLECIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct FHEAHGICNPK : IEquatable<FHEAHGICNPK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6A78220", Offset = "0x6A77220", VA = "0x186A78220", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(FHEAHGICNPK ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct MFHPFAOGFID : IEquatable<MFHPFAOGFID>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private OEENGDBIBNC KKEOBPFILCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x6A72900", Offset = "0x6A71900", VA = "0x186A72900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
	public MFHPFAOGFID(CGNEFKCKCBE BAAPAEECMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6A80C60", Offset = "0x6A7FC60", VA = "0x186A80C60", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(MFHPFAOGFID ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6A80BC0", Offset = "0x6A7FBC0", VA = "0x186A80BC0")]
	public void CANECBKHGDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6A80CF0", Offset = "0x6A7FCF0", VA = "0x186A80CF0")]
	public void ICEEEJOHKNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6A80B20", Offset = "0x6A7FB20", VA = "0x186A80B20")]
	public bool BJHJIKBAKMO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct GAHEIIBAKPC : IEquatable<GAHEIIBAKPC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public CGNEFKCKCBE KEHFAMPKBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(CGNEFKCKCBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private OEENGDBIBNC KKEOBPFILCO
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6A72900", Offset = "0x6A71900", VA = "0x186A72900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	private FNLPLJPPMJI DDEKKFALKJA
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6A79A60", Offset = "0x6A78A60", VA = "0x186A79A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private AFOMIBACJBH LIPOOGIDHND
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x6A794D0", Offset = "0x6A784D0", VA = "0x186A794D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public CGNEFKCKCBE HLKMOPHJOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6A79AF0", Offset = "0x6A78AF0", VA = "0x186A79AF0")]
		get
		{
			return default(CGNEFKCKCBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public LBDNIKJOCAM EOBHJDGKNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6A79440", Offset = "0x6A78440", VA = "0x186A79440")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public LBDNIKJOCAM KILMHGFMJMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6A79530", Offset = "0x6A78530", VA = "0x186A79530")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
	public GAHEIIBAKPC(CGNEFKCKCBE BAAPAEECMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6A79970", Offset = "0x6A78970", VA = "0x186A79970", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(GAHEIIBAKPC ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6A79B80", Offset = "0x6A78B80", VA = "0x186A79B80")]
	public bool MLPLIFGNEGJ(LBDNIKJOCAM EMOKCJBMKOL, bool LFPCLIMHHEJ = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x6A793A0", Offset = "0x6A783A0", VA = "0x186A793A0")]
	public bool AAJKDFPIMOD(LBDNIKJOCAM EKGLHBPPKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6A795C0", Offset = "0x6A785C0", VA = "0x186A795C0")]
	private void CANMMBIPKLN(LBDNIKJOCAM HPEPLPLAKHD, List<LBDNIKJOCAM> MBMNJGNEFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6A79CB0", Offset = "0x6A78CB0", VA = "0x186A79CB0")]
	public CNPBEIPHOEC MPEOEJJEFMP()
	{
		return default(CNPBEIPHOEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6A79A00", Offset = "0x6A78A00", VA = "0x186A79A00")]
	public void GLJJDLBHLEJ(List<LBDNIKJOCAM> MAEJHPBPJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x6A79850", Offset = "0x6A78850", VA = "0x186A79850")]
	public NativeArray<CGNEFKCKCBE> CIMLCNJODHF()
	{
		return default(NativeArray<CGNEFKCKCBE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct FNEBNOHNABN : IEquatable<FNEBNOHNABN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public string AFJILKDEOKM
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6A79140", Offset = "0x6A78140", VA = "0x186A79140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public string KMPFNNLDGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6A78D90", Offset = "0x6A77D90", VA = "0x186A78D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private bool NNMMBAPHMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6A78C50", Offset = "0x6A77C50", VA = "0x186A78C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public string KJFAEJJEGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6A791C0", Offset = "0x6A781C0", VA = "0x186A791C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public string CLHNKEMBMGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6A78EF0", Offset = "0x6A77EF0", VA = "0x186A78EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public string ABFOENINDDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6A792B0", Offset = "0x6A782B0", VA = "0x186A792B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
	public FNEBNOHNABN(CGNEFKCKCBE BAAPAEECMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6A78E60", Offset = "0x6A77E60", VA = "0x186A78E60", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(FNEBNOHNABN ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct DOOJKPAGJMP : IEquatable<DOOJKPAGJMP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private OEENGDBIBNC KKEOBPFILCO
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6A72900", Offset = "0x6A71900", VA = "0x186A72900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private FNLPLJPPMJI DDEKKFALKJA
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6A77C30", Offset = "0x6A76C30", VA = "0x186A77C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private JGGKLJNAOEM PPJAEAPLKBI
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6A77D60", Offset = "0x6A76D60", VA = "0x186A77D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public PKICOABIHAJ AJFJELEGKHO
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6A77870", Offset = "0x6A76870", VA = "0x186A77870")]
		get
		{
			return default(PKICOABIHAJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6A77A90", Offset = "0x6A76A90", VA = "0x186A77A90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public bool CGJBNOOLLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6A77DC0", Offset = "0x6A76DC0", VA = "0x186A77DC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6A77CC0", Offset = "0x6A76CC0", VA = "0x186A77CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public string[] MGGLGHNDMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6A77740", Offset = "0x6A76740", VA = "0x186A77740")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6A77600", Offset = "0x6A76600", VA = "0x186A77600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public string[] IHGBICCFOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6A77A00", Offset = "0x6A76A00", VA = "0x186A77A00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6A77E50", Offset = "0x6A76E50", VA = "0x186A77E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public string[] OENFCACBDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6A77BA0", Offset = "0x6A76BA0", VA = "0x186A77BA0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6A77560", Offset = "0x6A76560", VA = "0x186A77560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public string[] HLCKGLNBCIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x6A77EF0", Offset = "0x6A76EF0", VA = "0x186A77EF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6A776A0", Offset = "0x6A766A0", VA = "0x186A776A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
	public DOOJKPAGJMP(CGNEFKCKCBE BAAPAEECMJF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x97DF10", Offset = "0x97CF10", VA = "0x18097DF10")]
	public static CGNEFKCKCBE GCCHPLCKKEJ(DOOJKPAGJMP JJCEIJMGOAB)
	{
		return default(CGNEFKCKCBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x6A77970", Offset = "0x6A76970", VA = "0x186A77970", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(DOOJKPAGJMP ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6A777D0", Offset = "0x6A767D0", VA = "0x186A777D0")]
	public bool DBFPEMFJJPP(CGNEFKCKCBE GOJJHGGKKML)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct OLIFICIMPEA : IEquatable<OLIFICIMPEA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6A85E50", Offset = "0x6A84E50", VA = "0x186A85E50", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(OLIFICIMPEA ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct ELFKJIJPDAO : IEquatable<ELFKJIJPDAO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
	public ELFKJIJPDAO(CGNEFKCKCBE BAAPAEECMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6A78020", Offset = "0x6A77020", VA = "0x186A78020", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(ELFKJIJPDAO ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6A780B0", Offset = "0x6A770B0", VA = "0x186A780B0")]
	public bool KBCIDIBDAED([Out] Collider PEMDJFGIBMG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct IGAHIIEAGMI : IEquatable<IGAHIIEAGMI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public CGNEFKCKCBE KEHFAMPKBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(CGNEFKCKCBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private MakerPenHeldDataWrapper NKEKNDCJPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x6A7BA40", Offset = "0x6A7AA40", VA = "0x186A7BA40")]
		get
		{
			return default(MakerPenHeldDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public bool LKMNGBCCCCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x6A7BB30", Offset = "0x6A7AB30", VA = "0x186A7BB30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
	public IGAHIIEAGMI(CGNEFKCKCBE BAAPAEECMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BAA0", Offset = "0x6A7AAA0", VA = "0x186A7BAA0", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(IGAHIIEAGMI ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct PPMJKDPAEDN : IEquatable<PPMJKDPAEDN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public CGNEFKCKCBE KEHFAMPKBDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(CGNEFKCKCBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	private OEENGDBIBNC KKEOBPFILCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6A72900", Offset = "0x6A71900", VA = "0x186A72900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	private FNLPLJPPMJI DDEKKFALKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A86320", Offset = "0x6A85320", VA = "0x186A86320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private IDFOAMIMPDK NNGJGNLEOIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6A862C0", Offset = "0x6A852C0", VA = "0x186A862C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
	public PPMJKDPAEDN(CGNEFKCKCBE BAAPAEECMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A86190", Offset = "0x6A85190", VA = "0x186A86190", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(PPMJKDPAEDN ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A86220", Offset = "0x6A85220", VA = "0x186A86220")]
	public void FPAKLJHBCPP(bool HCAJOFFCDJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct KDCMMCKPCLC : IEquatable<KDCMMCKPCLC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public CGNEFKCKCBE KEHFAMPKBDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(CGNEFKCKCBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private OEENGDBIBNC KKEOBPFILCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x6A72900", Offset = "0x6A71900", VA = "0x186A72900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private FNLPLJPPMJI DDEKKFALKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x6A7DE20", Offset = "0x6A7CE20", VA = "0x186A7DE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	private ObjectPolicyDataWrapper ILJIIOALIAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D9E0", Offset = "0x6A7C9E0", VA = "0x186A7D9E0")]
		get
		{
			return default(ObjectPolicyDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private NavMeshGenerationDataWrapper PFBOAHEJPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x6A7DAB0", Offset = "0x6A7CAB0", VA = "0x186A7DAB0")]
		get
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public bool BMMMBLGMNOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E100", Offset = "0x6A7D100", VA = "0x186A7E100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool DIOFBEIPIGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x6A7DB10", Offset = "0x6A7CB10", VA = "0x186A7DB10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool FEPNHGPMKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D760", Offset = "0x6A7C760", VA = "0x186A7D760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool DLDFCFOEFLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E290", Offset = "0x6A7D290", VA = "0x186A7E290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool LGENKHBCPBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x6A7DA40", Offset = "0x6A7CA40", VA = "0x186A7DA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool OAFEJGNOLNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D3B0", Offset = "0x6A7C3B0", VA = "0x186A7D3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public bool EKKPBPCJPOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x6A7DDB0", Offset = "0x6A7CDB0", VA = "0x186A7DDB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public bool NEMBNEKLGKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x6A7DEB0", Offset = "0x6A7CEB0", VA = "0x186A7DEB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public bool EDOLJJDLHDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E220", Offset = "0x6A7D220", VA = "0x186A7E220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public bool PCEFLAGNPFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E1B0", Offset = "0x6A7D1B0", VA = "0x186A7E1B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public bool MKGJAHJAHJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E140", Offset = "0x6A7D140", VA = "0x186A7E140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool OJKFOAFOCDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D4F0", Offset = "0x6A7C4F0", VA = "0x186A7D4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool MJLADMAJMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A7DD50", Offset = "0x6A7CD50", VA = "0x186A7DD50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool OALNAHANAAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6A7DFA0", Offset = "0x6A7CFA0", VA = "0x186A7DFA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D2E0", Offset = "0x6A7C2E0", VA = "0x186A7D2E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public JMIIFDEFPMI KADFBHGCCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D490", Offset = "0x6A7C490", VA = "0x186A7D490")]
		get
		{
			return default(JMIIFDEFPMI);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D860", Offset = "0x6A7C860", VA = "0x186A7D860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool EFECOBKPJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6A7DB80", Offset = "0x6A7CB80", VA = "0x186A7DB80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public PGCGAELAGGH KOFOGNBJGIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D5D0", Offset = "0x6A7C5D0", VA = "0x186A7D5D0")]
		get
		{
			return default(PGCGAELAGGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool LNPEFDGNNIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D350", Offset = "0x6A7C350", VA = "0x186A7D350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Vector3 OLGPLKALOFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D630", Offset = "0x6A7C630", VA = "0x186A7D630")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Vector3 DCPNKLIEEPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D8D0", Offset = "0x6A7C8D0", VA = "0x186A7D8D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public bool FLCGCPEFNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E000", Offset = "0x6A7D000", VA = "0x186A7E000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
	public KDCMMCKPCLC(CGNEFKCKCBE BAAPAEECMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D7D0", Offset = "0x6A7C7D0", VA = "0x186A7D7D0", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(KDCMMCKPCLC ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D420", Offset = "0x6A7C420", VA = "0x186A7D420")]
	public bool BANNGMCFHBK(MMJKABJPGFF BKDPCDNGDKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D6F0", Offset = "0x6A7C6F0", VA = "0x186A7D6F0")]
	public bool DIEACJHAKDF(AKKFFPHNNIN BKDPCDNGDKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6A7DF20", Offset = "0x6A7CF20", VA = "0x186A7DF20")]
	public void LLILNDEMEDC(AKKFFPHNNIN BKDPCDNGDKK, bool AJNJOGNFDFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D980", Offset = "0x6A7C980", VA = "0x186A7D980")]
	public AKKFFPHNNIN GPCHDNABFNP()
	{
		return default(AKKFFPHNNIN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D560", Offset = "0x6A7C560", VA = "0x186A7D560")]
	public bool CCHECMJALPI(AKKFFPHNNIN JJCEIJMGOAB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct ILAIGGNLLLN : IEquatable<ILAIGGNLLLN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	private OEENGDBIBNC KKEOBPFILCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6A72900", Offset = "0x6A71900", VA = "0x186A72900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private FNLPLJPPMJI DDEKKFALKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x6A7C620", Offset = "0x6A7B620", VA = "0x186A7C620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private LKLLPLJKLOJ IJGKKMDBBLH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x6A7C5C0", Offset = "0x6A7B5C0", VA = "0x186A7C5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
	public ILAIGGNLLLN(CGNEFKCKCBE BAAPAEECMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C020", Offset = "0x6A7B020", VA = "0x186A7C020", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(ILAIGGNLLLN ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C6B0", Offset = "0x6A7B6B0", VA = "0x186A7C6B0")]
	public bool MCLFKDBOFHF(MLMCOPCJNLO GKANCDPDLNF, List<LBDNIKJOCAM> NIJMADLECIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BC00", Offset = "0x6A7AC00", VA = "0x186A7BC00")]
	public int BFEBHLPGOGB(MLMCOPCJNLO GKANCDPDLNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C1C0", Offset = "0x6A7B1C0", VA = "0x186A7C1C0")]
	public void HAANCEOCHJM(List<LBDNIKJOCAM> NIJMADLECIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BDC0", Offset = "0x6A7ADC0", VA = "0x186A7BDC0")]
	public int CBDGBGLBFJH(LBDNIKJOCAM KAEDHDLBKFF, MLMCOPCJNLO GKANCDPDLNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BEF0", Offset = "0x6A7AEF0", VA = "0x186A7BEF0")]
	public LBDNIKJOCAM DIOOOEHOKHC(int HCALFJOJKJO, MLMCOPCJNLO GKANCDPDLNF)
	{
		return default(LBDNIKJOCAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C2D0", Offset = "0x6A7B2D0", VA = "0x186A7C2D0")]
	public void IJKIOPPKJJG(LBDNIKJOCAM KAEDHDLBKFF, MLMCOPCJNLO GKANCDPDLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C400", Offset = "0x6A7B400", VA = "0x186A7C400")]
	public bool KCNBMNGAPHC(LBDNIKJOCAM KAEDHDLBKFF, MLMCOPCJNLO GKANCDPDLNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C0B0", Offset = "0x6A7B0B0", VA = "0x186A7C0B0")]
	public void FHLCJHEINCI(MLMCOPCJNLO GKANCDPDLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BD10", Offset = "0x6A7AD10", VA = "0x186A7BD10")]
	public bool BIDJEHNMEIJ(LBDNIKJOCAM KAEDHDLBKFF, MLMCOPCJNLO GKANCDPDLNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C4B0", Offset = "0x6A7B4B0", VA = "0x186A7C4B0")]
	public bool KDEGLCPMPHB(MLMCOPCJNLO GKANCDPDLNF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct BCAJCGOCNEE : IEquatable<BCAJCGOCNEE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public CGNEFKCKCBE KEHFAMPKBDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(CGNEFKCKCBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	private OEENGDBIBNC KKEOBPFILCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6A72900", Offset = "0x6A71900", VA = "0x186A72900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private FNLPLJPPMJI DDEKKFALKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6A72B50", Offset = "0x6A71B50", VA = "0x186A72B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
	public BCAJCGOCNEE(CGNEFKCKCBE BAAPAEECMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x6A72970", Offset = "0x6A71970", VA = "0x186A72970", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(BCAJCGOCNEE ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6A72AC0", Offset = "0x6A71AC0", VA = "0x186A72AC0")]
	public void JJMHMDEKAAD(bool JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A30", Offset = "0x6A71A30", VA = "0x186A72A30")]
	public void IHILGIMOHDN(bool JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x29260B0", Offset = "0x29250B0", VA = "0x1829260B0")]
	public T DKCHMDPNLGG<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public readonly struct MDDAJDOJAAE : IEquatable<MDDAJDOJAAE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public CGNEFKCKCBE KEHFAMPKBDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(CGNEFKCKCBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	private OEENGDBIBNC KKEOBPFILCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A72900", Offset = "0x6A71900", VA = "0x186A72900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	private FNLPLJPPMJI DDEKKFALKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6A80A30", Offset = "0x6A7FA30", VA = "0x186A80A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private HKMAJPPKKMD ECFLICCHDAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x6A80AC0", Offset = "0x6A7FAC0", VA = "0x186A80AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public bool CDNONCCEHEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x6A80910", Offset = "0x6A7F910", VA = "0x186A80910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public bool NMIGDJNNIGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x6A80880", Offset = "0x6A7F880", VA = "0x186A80880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
	public MDDAJDOJAAE(CGNEFKCKCBE BAAPAEECMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6A809A0", Offset = "0x6A7F9A0", VA = "0x186A809A0", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(MDDAJDOJAAE ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct IOIGPKJJOEF : IEquatable<IOIGPKJJOEF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C7E0", Offset = "0x6A7B7E0", VA = "0x186A7C7E0", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(IOIGPKJJOEF ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct OFPDDADNENA : IEquatable<OFPDDADNENA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public CGNEFKCKCBE KEHFAMPKBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(CGNEFKCKCBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private OEENGDBIBNC KKEOBPFILCO
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x6A72900", Offset = "0x6A71900", VA = "0x186A72900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private FNLPLJPPMJI DDEKKFALKJA
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6A85A00", Offset = "0x6A84A00", VA = "0x186A85A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private FOGCBBJBLKA DNMNFKPKNPA
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x6A85A90", Offset = "0x6A84A90", VA = "0x186A85A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private JOPHOCAGIDH OKMLCHLBLAN
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x6A85860", Offset = "0x6A84860", VA = "0x186A85860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool ECPJAGCCMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x6A854C0", Offset = "0x6A844C0", VA = "0x186A854C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool BPCMADOCKNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x6A858C0", Offset = "0x6A848C0", VA = "0x186A858C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool CAOHFIGJFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x6A85C90", Offset = "0x6A84C90", VA = "0x186A85C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool BNNCDNDHCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x6A85790", Offset = "0x6A84790", VA = "0x186A85790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool DNIELHIHMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x6A85210", Offset = "0x6A84210", VA = "0x186A85210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool EIJAEEOFFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6A85C00", Offset = "0x6A84C00", VA = "0x186A85C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool OHHHBBJKOMP
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x6A85000", Offset = "0x6A84000", VA = "0x186A85000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool JJFJIKBEMOB
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x6A85350", Offset = "0x6A84350", VA = "0x186A85350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
	public OFPDDADNENA(CGNEFKCKCBE BAAPAEECMJF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6A758F0", Offset = "0x6A748F0", VA = "0x186A758F0")]
	public static bool GCCHPLCKKEJ(OFPDDADNENA JJCEIJMGOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6A85700", Offset = "0x6A84700", VA = "0x186A85700", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(OFPDDADNENA ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x6A85B90", Offset = "0x6A84B90", VA = "0x186A85B90")]
	public bool MDLEJKCNOHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x6A85550", Offset = "0x6A84550", VA = "0x186A85550")]
	public LBDNIKJOCAM EIBFJCBPMIF(LBDNIKJOCAM KAEDHDLBKFF)
	{
		return default(LBDNIKJOCAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x6A855F0", Offset = "0x6A845F0", VA = "0x186A855F0")]
	public CGNEFKCKCBE EKPKDFHPMCD()
	{
		return default(CGNEFKCKCBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6A85AF0", Offset = "0x6A84AF0", VA = "0x186A85AF0")]
	public bool LEOPLIBGHOM(CGNEFKCKCBE GKPCIBCGDDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x6A85960", Offset = "0x6A84960", VA = "0x186A85960")]
	public bool JLACFPAJOEC(CGNEFKCKCBE NJHEGBCLLHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x6A85240", Offset = "0x6A84240", VA = "0x186A85240")]
	public bool CAHKFKHMKDM(CGNEFKCKCBE KAEDHDLBKFF, [Out] CGNEFKCKCBE GKPCIBCGDDP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct KBNKPNADCNC : IEquatable<KBNKPNADCNC>
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly KBNKPNADCNC BEIBFMDMNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public CGNEFKCKCBE KEHFAMPKBDL
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(CGNEFKCKCBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public NKABHKLHFBI EALAKNFEFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(NKABHKLHFBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public GAHEIIBAKPC MMPINNONJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(GAHEIIBAKPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private ShapeTypeDataWrapper FLGDADJKLJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D1B0", Offset = "0x6A7C1B0", VA = "0x186A7D1B0")]
		get
		{
			return default(ShapeTypeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public StandardRenderableVisualDataWrapper FLPFCPLLDGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x6A7CDD0", Offset = "0x6A7BDD0", VA = "0x186A7CDD0")]
		get
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public PhysicsMaterialDataWrapper FFKOKKNLAIK
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x6A7CE90", Offset = "0x6A7BE90", VA = "0x186A7CE90")]
		get
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public ShapeConfigDataWrapper AFNIDFCEOBB
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D280", Offset = "0x6A7C280", VA = "0x186A7D280")]
		get
		{
			return default(ShapeConfigDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public IJPLFLINAEF KFDCCGHMHAD
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D0C0", Offset = "0x6A7C0C0", VA = "0x186A7D0C0")]
		get
		{
			return default(IJPLFLINAEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public KBNDNLNKECK JCCNEGPADMB
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x6A7CAE0", Offset = "0x6A7BAE0", VA = "0x186A7CAE0")]
		get
		{
			return default(KBNDNLNKECK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x6A7CA70", Offset = "0x6A7BA70", VA = "0x186A7CA70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public NNNCMCKEDNE DKEDIIKAFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x6A7CE30", Offset = "0x6A7BE30", VA = "0x186A7CE30")]
		get
		{
			return default(NNNCMCKEDNE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x6A7CF80", Offset = "0x6A7BF80", VA = "0x186A7CF80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public float GAFLNLOOKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x6A7CFF0", Offset = "0x6A7BFF0", VA = "0x186A7CFF0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D210", Offset = "0x6A7C210", VA = "0x186A7D210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public Vector3 DHLGGJKCPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x6A7CC40", Offset = "0x6A7BC40", VA = "0x186A7CC40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x6A7CB40", Offset = "0x6A7BB40", VA = "0x186A7CB40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public float GDCJPOOGOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x6A7CD60", Offset = "0x6A7BD60", VA = "0x186A7CD60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public PFHLCPEJGHL IBHIGOCPEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x6A7CBE0", Offset = "0x6A7BBE0", VA = "0x186A7CBE0")]
		get
		{
			return default(PFHLCPEJGHL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D050", Offset = "0x6A7C050", VA = "0x186A7D050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
	public KBNKPNADCNC(CGNEFKCKCBE BAAPAEECMJF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6A758F0", Offset = "0x6A748F0", VA = "0x186A758F0")]
	public static bool GCCHPLCKKEJ(KBNKPNADCNC JJCEIJMGOAB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6A74040", Offset = "0x6A73040", VA = "0x186A74040")]
	public static bool KGBNGOIDAMB(KBNKPNADCNC MHGINKKGGNL, KBNKPNADCNC JCHFDOINNOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6A7CEF0", Offset = "0x6A7BEF0", VA = "0x186A7CEF0", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(KBNKPNADCNC ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D130", Offset = "0x6A7C130", VA = "0x186A7D130")]
	public HHCMEPCHJNE LDFLGHKHJGB()
	{
		return default(HHCMEPCHJNE);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x6A7CCE0", Offset = "0x6A7BCE0", VA = "0x186A7CCE0")]
	public HIHFENJMIEP DNFOIJAIDBG()
	{
		return default(HIHFENJMIEP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct HHCMEPCHJNE : IEquatable<HHCMEPCHJNE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public CGNEFKCKCBE KEHFAMPKBDL
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(CGNEFKCKCBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public KBNKPNADCNC EPGHLCKONAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(KBNKPNADCNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private PrimitiveShapeDataWrapper LINLJNDOBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x6A7AC40", Offset = "0x6A79C40", VA = "0x186A7AC40")]
		get
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public CBPMDLJFIEM HGHKICENOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6A7AB50", Offset = "0x6A79B50", VA = "0x186A7AB50")]
		get
		{
			return default(CBPMDLJFIEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
	public HHCMEPCHJNE(CGNEFKCKCBE BAAPAEECMJF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x6A758F0", Offset = "0x6A748F0", VA = "0x186A758F0")]
	public static bool GCCHPLCKKEJ(HHCMEPCHJNE JJCEIJMGOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x6A7ABB0", Offset = "0x6A79BB0", VA = "0x186A7ABB0", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(HHCMEPCHJNE ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[DefaultMember("Item")]
public readonly struct HIHFENJMIEP : IEquatable<HIHFENJMIEP>
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly HIHFENJMIEP BEIBFMDMNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public CGNEFKCKCBE KEHFAMPKBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(CGNEFKCKCBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public NKABHKLHFBI EALAKNFEFIK
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(NKABHKLHFBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private OEENGDBIBNC KKEOBPFILCO
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x6A72900", Offset = "0x6A71900", VA = "0x186A72900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private FNLPLJPPMJI DDEKKFALKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B190", Offset = "0x6A7A190", VA = "0x186A7B190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	private GMAJLNFKMKB GLOECJOGKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B130", Offset = "0x6A7A130", VA = "0x186A7B130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public KBNKPNADCNC EPGHLCKONAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(KBNKPNADCNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public DHJPOFIAJDN NEPDAGNHADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x6A7ACA0", Offset = "0x6A79CA0", VA = "0x186A7ACA0")]
		get
		{
			return default(DHJPOFIAJDN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B010", Offset = "0x6A7A010", VA = "0x186A7B010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public IEnumerable<CNDDFIFKHHG> LCPEBHEHOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B450", Offset = "0x6A7A450", VA = "0x186A7B450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public CNDDFIFKHHG OMCGAJCFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x6A7ADD0", Offset = "0x6A79DD0", VA = "0x186A7ADD0")]
		get
		{
			return default(CNDDFIFKHHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B880", Offset = "0x6A7A880", VA = "0x186A7B880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
	public HIHFENJMIEP(CGNEFKCKCBE BAAPAEECMJF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x6A758F0", Offset = "0x6A748F0", VA = "0x186A758F0")]
	public static bool GCCHPLCKKEJ(HIHFENJMIEP JJCEIJMGOAB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x6A764D0", Offset = "0x6A754D0", VA = "0x186A764D0")]
	public static bool MKBCGNPIJEJ(HIHFENJMIEP MHGINKKGGNL, HIHFENJMIEP JCHFDOINNOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x6A7AEE0", Offset = "0x6A79EE0", VA = "0x186A7AEE0", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(HIHFENJMIEP ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B660", Offset = "0x6A7A660", VA = "0x186A7B660")]
	public CNDDFIFKHHG NGJBLAFJBEA(float3? LLLHNMGEKPM, [Optional] quaternion? BCKIPOGEHOJ, [Optional] Vector3? FHBDGLOPEKN)
	{
		return default(CNDDFIFKHHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B220", Offset = "0x6A7A220", VA = "0x186A7B220")]
	public CNDDFIFKHHG LIHBHDHNEGP(int HCALFJOJKJO, float3? LLLHNMGEKPM, [Optional] quaternion? BCKIPOGEHOJ, [Optional] Vector3? FHBDGLOPEKN)
	{
		return default(CNDDFIFKHHG);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x6A7AF70", Offset = "0x6A79F70", VA = "0x186A7AF70")]
	public void FPMFBAADEOI(int HCALFJOJKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B910", Offset = "0x6A7A910", VA = "0x186A7B910")]
	public void PKAGCAPLLKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct CNDDFIFKHHG : IEquatable<CNDDFIFKHHG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public CGNEFKCKCBE KEHFAMPKBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(CGNEFKCKCBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public HIHFENJMIEP CFGBPJLFGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x6A745A0", Offset = "0x6A735A0", VA = "0x186A745A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public float3 OFOBIKFANPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x6A746C0", Offset = "0x6A736C0", VA = "0x186A746C0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6A74830", Offset = "0x6A73830", VA = "0x186A74830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public quaternion IMOOEMJKGCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x6A74520", Offset = "0x6A73520", VA = "0x186A74520")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x6A749D0", Offset = "0x6A739D0", VA = "0x186A749D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public float3 NODPCJAIJOE
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x6A744A0", Offset = "0x6A734A0", VA = "0x186A744A0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x6A74740", Offset = "0x6A73740", VA = "0x186A74740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public DBOINHOPMHF DINNEGCMGAO
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x6A747C0", Offset = "0x6A737C0", VA = "0x186A747C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	private SplinePointParentDataWrapper FFGBEFFIAAB
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x6A74440", Offset = "0x6A73440", VA = "0x186A74440")]
		get
		{
			return default(SplinePointParentDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	private SplinePointPositionDataWrapper LABAAPDDPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6A74970", Offset = "0x6A73970", VA = "0x186A74970")]
		get
		{
			return default(SplinePointPositionDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	private SplinePointRotationDataWrapper DMFDCAICLCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x6A748B0", Offset = "0x6A738B0", VA = "0x186A748B0")]
		get
		{
			return default(SplinePointRotationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	private SplinePointScaleDataWrapper MCKMAFNPMEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x6A74A40", Offset = "0x6A73A40", VA = "0x186A74A40")]
		get
		{
			return default(SplinePointScaleDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	private SplinePointOrderDataWrapper LNDGLCGIEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x6A74910", Offset = "0x6A73910", VA = "0x186A74910")]
		get
		{
			return default(SplinePointOrderDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
	public CNDDFIFKHHG(CGNEFKCKCBE BAAPAEECMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6A74630", Offset = "0x6A73630", VA = "0x186A74630", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(CNDDFIFKHHG ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x6A745A0", Offset = "0x6A735A0", VA = "0x186A745A0")]
	public void ELHFMEKFKGF(HIHFENJMIEP JJCEIJMGOAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct LPEMIKKPCLF : IEquatable<LPEMIKKPCLF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public CGNEFKCKCBE KEHFAMPKBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(CGNEFKCKCBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	private OEENGDBIBNC KKEOBPFILCO
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x6A72900", Offset = "0x6A71900", VA = "0x186A72900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private FNLPLJPPMJI DDEKKFALKJA
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6A801D0", Offset = "0x6A7F1D0", VA = "0x186A801D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private ELHOOHGIKMC FIBLPGPCNPH
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x6A80300", Offset = "0x6A7F300", VA = "0x186A80300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	private ToolCleanupSettingsDataWrapper KPKMILPJOJB
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x6A80060", Offset = "0x6A7F060", VA = "0x186A80060")]
		get
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public bool GCGBPHHOPNB
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x6A80000", Offset = "0x6A7F000", VA = "0x186A80000")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x6A7FD30", Offset = "0x6A7ED30", VA = "0x186A7FD30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool OOMPMOBENIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6A7FE00", Offset = "0x6A7EE00", VA = "0x186A7FE00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x6A7FB70", Offset = "0x6A7EB70", VA = "0x186A7FB70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public float PJLPMLENHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x6A7FDA0", Offset = "0x6A7EDA0", VA = "0x186A7FDA0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x6A80160", Offset = "0x6A7F160", VA = "0x186A80160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool EFOIKMKDLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x6A80260", Offset = "0x6A7F260", VA = "0x186A80260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
	public LPEMIKKPCLF(CGNEFKCKCBE BAAPAEECMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x6A7FF70", Offset = "0x6A7EF70", VA = "0x186A7FF70", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(LPEMIKKPCLF ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x6A804B0", Offset = "0x6A7F4B0", VA = "0x186A804B0")]
	public void OHJJINMJBGJ(int HMLGIEBFMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x6A7FE60", Offset = "0x6A7EE60", VA = "0x186A7FE60")]
	public bool EFHLGAEMFBL([Out] int HMLGIEBFMDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x6A800C0", Offset = "0x6A7F0C0", VA = "0x186A800C0")]
	public void IGOGFAAHFON(bool FGOJNBNDHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x6A7FBE0", Offset = "0x6A7EBE0", VA = "0x186A7FBE0")]
	public void BGNHDPHEPAL(float NIEHCAPCMGN, float DNHNKJBHBBJ, float ALDPOJHHLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x6A80360", Offset = "0x6A7F360", VA = "0x186A80360")]
	public void OCNHCHOBLHC(float3 IHJJNHJFHGK, quaternion PBPJCJAHKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x6A80680", Offset = "0x6A7F680", VA = "0x186A80680")]
	public bool PPKOPPOMKFB([Out] float3 IHJJNHJFHGK, [Out] quaternion PBPJCJAHKBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x6A80550", Offset = "0x6A7F550", VA = "0x186A80550")]
	public bool PCFNAGNHJKK([Out] float GHBEGNKKDKG, [Out] float ILGFIAGMMGA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct NKABHKLHFBI : IEquatable<NKABHKLHFBI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly CGNEFKCKCBE BEHCCOMHFAP;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public LBDNIKJOCAM HLIPLMDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(LBDNIKJOCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public GAHEIIBAKPC MMPINNONJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		get
		{
			return default(GAHEIIBAKPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	private OEENGDBIBNC KKEOBPFILCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x6A72900", Offset = "0x6A71900", VA = "0x186A72900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	private NHCPPBLHPHO PHJHAFHJGBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x6A81960", Offset = "0x6A80960", VA = "0x186A81960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public bool PJDBLCFCNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x6A82FE0", Offset = "0x6A81FE0", VA = "0x186A82FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public Vector3 OFOBIKFANPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6A82570", Offset = "0x6A81570", VA = "0x186A82570")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x6A83290", Offset = "0x6A82290", VA = "0x186A83290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public Quaternion IMOOEMJKGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x6A82110", Offset = "0x6A81110", VA = "0x186A82110")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x6A835C0", Offset = "0x6A825C0", VA = "0x186A835C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public Vector3 DCAOJBAHOHK
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x6A831A0", Offset = "0x6A821A0", VA = "0x186A831A0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x6A830D0", Offset = "0x6A820D0", VA = "0x186A830D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public Quaternion FLFGHMPBLPK
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x6A81FD0", Offset = "0x6A80FD0", VA = "0x186A81FD0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x6A834F0", Offset = "0x6A824F0", VA = "0x186A834F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public float MAMICFLBBEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x6A83760", Offset = "0x6A82760", VA = "0x186A83760")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x6A83020", Offset = "0x6A82020", VA = "0x186A83020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public float IMINBOBANMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x6A82400", Offset = "0x6A81400", VA = "0x186A82400")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public Vector3 NODPCJAIJOE
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x6A81A20", Offset = "0x6A80A20", VA = "0x186A81A20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x6A82AD0", Offset = "0x6A81AD0", VA = "0x186A82AD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public Vector3 IJNLJIONEJE
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x6A83800", Offset = "0x6A82800", VA = "0x186A83800")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public Matrix4x4 NBPOFPOHCHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x6A81730", Offset = "0x6A80730", VA = "0x186A81730")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
	public NKABHKLHFBI(CGNEFKCKCBE BAAPAEECMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A00", Offset = "0x6A71A00", VA = "0x186A72A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x6A82370", Offset = "0x6A81370", VA = "0x186A82370", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71960", VA = "0x186A72960", Slot = "4")]
	public bool Equals(NKABHKLHFBI ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BE0", Offset = "0x6A71BE0", VA = "0x186A72BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x6A82990", Offset = "0x6A81990", VA = "0x186A82990")]
	public GBHEIPHNIPH HJNGBPIOMEA()
	{
		return default(GBHEIPHNIPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x6A82250", Offset = "0x6A81250", VA = "0x186A82250")]
	public void EMCCHOLCFBL([Out] Matrix4x4 NAKEHMEBJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A83410", Offset = "0x6A82410", VA = "0x186A83410")]
	public void NHADGKHIKJI([Out] Vector3 PNGJNGHGLBI, [Out] Quaternion LBEKPAGHBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A83360", Offset = "0x6A82360", VA = "0x186A83360")]
	public void NHADGKHIKJI([Out] RigidTransform CBIFMJNJCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A82730", Offset = "0x6A81730", VA = "0x186A82730")]
	public void HBBLFFLNFCC([Out] Vector3 PNGJNGHGLBI, [Out] Quaternion LBEKPAGHBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A82810", Offset = "0x6A81810", VA = "0x186A82810")]
	public void HBBLFFLNFCC([Out] RigidTransform CBIFMJNJCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A82EE0", Offset = "0x6A81EE0", VA = "0x186A82EE0")]
	public UniformTRS LABNGCBANLK()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A82E20", Offset = "0x6A81E20", VA = "0x186A82E20")]
	public void LABNGCBANLK([Out] UniformTRS NKKKCLCLIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A81BD0", Offset = "0x6A80BD0", VA = "0x186A81BD0")]
	public UniformTRS CGPKOOOJNIG()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A81B10", Offset = "0x6A80B10", VA = "0x186A81B10")]
	public void CGPKOOOJNIG([Out] UniformTRS CBIFMJNJCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D30", Offset = "0x6A81D30", VA = "0x186A82D30")]
	public Vector3 KFNINIHPNGI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A838F0", Offset = "0x6A828F0", VA = "0x186A838F0")]
	public void PDDNJAILNEJ([In] Vector3 JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A81D40", Offset = "0x6A80D40", VA = "0x186A81D40")]
	public Vector3 DBBOABIDLDG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A83B30", Offset = "0x6A82B30", VA = "0x186A83B30")]
	public void POBDKLIOMGC([In] Vector3 JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A81770", Offset = "0x6A80770", VA = "0x186A81770")]
	public Quaternion APCLFIFOPCF()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A82660", Offset = "0x6A81660", VA = "0x186A82660")]
	public void GLNOPJJOAFP([In] Quaternion JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A81C00", Offset = "0x6A80C00", VA = "0x186A81C00")]
	public Quaternion CIKEEPBMJNK()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A83A60", Offset = "0x6A82A60", VA = "0x186A83A60")]
	public void PLDLFGNGLJH([In] Quaternion JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A839C0", Offset = "0x6A829C0", VA = "0x186A839C0")]
	public float PKAPFOIADPO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x6A818B0", Offset = "0x6A808B0", VA = "0x186A818B0")]
	public void BHLBNCHHADC(float JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A82BA0", Offset = "0x6A81BA0", VA = "0x186A82BA0")]
	public float IEHLJNAGKNO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A81F20", Offset = "0x6A80F20", VA = "0x186A81F20")]
	public void DMGBAOBICDB(float JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x6A824A0", Offset = "0x6A814A0", VA = "0x186A824A0")]
	public void FENBGBLGHGM([In] Vector3 JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x6A82C40", Offset = "0x6A81C40", VA = "0x186A82C40")]
	public Vector3 JAIGCEIAMCG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x6A83690", Offset = "0x6A82690", VA = "0x186A83690")]
	public void OPDFCLAKHBJ([In] Vector3 JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6A81E30", Offset = "0x6A80E30", VA = "0x186A81E30")]
	public Vector3 DKBKGLDMPLK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6A82F10", Offset = "0x6A81F10", VA = "0x186A82F10")]
	public void LHNOHACBJEJ([In] Vector3 JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6A829E0", Offset = "0x6A819E0", VA = "0x186A829E0")]
	public Vector3 HKNNCLJDJHA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6A828C0", Offset = "0x6A818C0", VA = "0x186A828C0")]
	public void HIAPDNDBNMB([In] Vector3 JJCEIJMGOAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class DDFIJNODELI
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private struct CEAABJIMKBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Guid CNIMPJMOLDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public HDMMBIPIMCK GDPIGEOBAPF;
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private struct HDMMBIPIMCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int JJCEIJMGOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int NLEHFGPEFDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int EOGGDDCOADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int DDGFDLENMAH;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x6A7AA80", Offset = "0x6A79A80", VA = "0x186A7AA80")]
		public bool FEHLDIBBNGF([Out] FDJBMECGDOM FGMNEAGEGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A7AB10", Offset = "0x6A79B10", VA = "0x186A7AB10")]
		public HDMMBIPIMCK(FDJBMECGDOM FGMNEAGEGFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6A77050", Offset = "0x6A76050", VA = "0x186A77050")]
	public static Guid IEPMKNBNFBN(this FDJBMECGDOM FGMNEAGEGFD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6A77030", Offset = "0x6A76030", VA = "0x186A77030")]
	public static bool DGNKHOHBMHP(this Guid CNIMPJMOLDJ, [Out] FDJBMECGDOM FGMNEAGEGFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class OCFCLGEJDMI
{
	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6A84B30", Offset = "0x6A83B30", VA = "0x186A84B30")]
	public static FNLPLJPPMJI DDEKKFALKJA(this CGNEFKCKCBE KHLDDJPHOBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6A84BC0", Offset = "0x6A83BC0", VA = "0x186A84BC0")]
	public static ACKGFBDMFHC HJGHBBCCHLN(this CGNEFKCKCBE KHLDDJPHOBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x6A84C90", Offset = "0x6A83C90", VA = "0x186A84C90")]
	public static EntityManager IAIHKKDCAON(this CGNEFKCKCBE KHLDDJPHOBA)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x2D3B280", Offset = "0x2D3A280", VA = "0x182D3B280")]
	public static T IEECJHLOHFI<T>(this CGNEFKCKCBE KHLDDJPHOBA) where T : struct, MGJOCMDKJPC
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2D3AF10", Offset = "0x2D39F10", VA = "0x182D3AF10")]
	public static bool AAGFGBNOGAB<T>(this CGNEFKCKCBE KHLDDJPHOBA) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2D3B1D0", Offset = "0x2D3A1D0", VA = "0x182D3B1D0")]
	public static bool ECENEKGKLPJ<T>(this CGNEFKCKCBE KHLDDJPHOBA) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface FMBFPNOAMOB
{
	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DMOMCLJNFPB(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IEIOFLHCPKM(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task OAPGPNOFFMF(LBDNIKJOCAM NOPFNIKINJA);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ECPFIMBKOJG(CGNEFKCKCBE BAAPAEECMJF, [Out] Guid GFIFEILMJAD);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid JKAPODGDBMD(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DIJNKOPAFHO(CGNEFKCKCBE BAAPAEECMJF, Guid GFIFEILMJAD);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FKPDLFGIHFJ(CGNEFKCKCBE BAAPAEECMJF, [Out] Guid GODNEBGANDJ);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Guid EEFDFDFFMGH(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BCDKFFADELA(CGNEFKCKCBE BAAPAEECMJF, Guid GODNEBGANDJ);

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BENJCOLJPII(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task CDOIOIPKMMI(CGNEFKCKCBE CDKDCIHMCOB, CGNEFKCKCBE EMOKCJBMKOL);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface KENLKFIMBDJ
{
	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	Guid DDCHCODNCDH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNPJGBOGEHL(NativeList<Guid> DBJDPEIPMJM, NativeList<Guid> DKDGNHMNBAJ, NativeList<FixedString64Bytes> JCNNIHBAKNH);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface HKMAJPPKKMD
{
	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LNGOIPLLIAI(List<CGNEFKCKCBE> PBBBFGIOKLN);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LJPJPIMDOFD(List<CGNEFKCKCBE> BNMAGGPPOBB);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NOIKMHMHIJC(CGNEFKCKCBE CJDMIKFIPBM);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CDNONCCEHEH(CGNEFKCKCBE CJDMIKFIPBM);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NMIGDJNNIGO(CGNEFKCKCBE CJDMIKFIPBM);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int PLBKDNOKNOG(CGNEFKCKCBE CJDMIKFIPBM);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FHBHGGKHCBE(CGNEFKCKCBE CJDMIKFIPBM, int GCCAFDBPHMC);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CGNEFKCKCBE DPLOGNNPJOM(CGNEFKCKCBE EHLOMPCAMFH);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int FNHOODJAJIC(CGNEFKCKCBE EHLOMPCAMFH);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PPGOBJNEJPN(CGNEFKCKCBE EHLOMPCAMFH, int GJFBKLAPCAJ);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int EFKOACDADKH(CGNEFKCKCBE EHLOMPCAMFH);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AMNMKGKPAHJ(CGNEFKCKCBE EHLOMPCAMFH, int NIBLDFMGNBJ);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OBKFJCKLHDI(CGNEFKCKCBE BEHCCOMHFAP);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LJPFOMGMBIK(CGNEFKCKCBE BAAPAEECMJF, bool LAFIIDLAOEK);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OFELMENFFBN(CGNEFKCKCBE[] HDBEGMKJNAF, bool LAFIIDLAOEK);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface KEIMBELKEMB
{
	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	IReadOnlyCollection<NDHLEAFNGPD> ELDHPFKIBMN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CAJEPIBEHAA(int NMKJGMDJHGN, [Out] NDHLEAFNGPD MOEKDCMNAHP);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NDHLEAFNGPD NPDOEAHPFJG(Type HNGLFCFOHLI);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class BDIMKABLCIH
{
	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x29278F0", Offset = "0x29268F0", VA = "0x1829278F0")]
	public static T MKEIBJBPAFN<T>(this KEIMBELKEMB MGGIAEFLNLO, Entity BOENFECPGGB) where T : struct, MGJOCMDKJPC
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x29279A0", Offset = "0x29269A0", VA = "0x1829279A0")]
	public static NDHLEAFNGPD NPDOEAHPFJG<T>(this KEIMBELKEMB MGGIAEFLNLO) where T : struct, MGJOCMDKJPC
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface KIBFCNJAEGM
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FDJBMECGDOM[] ADDDLIIPDLO(string CKEJJGPNKGO, LBDNIKJOCAM IKKLBFLNFIP, bool LHFPOBNDFIL = false);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BDLADCLDKGD(string EDIGKGDEKFI, FDJBMECGDOM[] HOBPFEIBGHF);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface OCMGEOKHNIG
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<CGNEFKCKCBE, CGNEFKCKCBE> MDLILEBPCNK;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<CGNEFKCKCBE, CGNEFKCKCBE> GMPEOPKGEGO;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<CGNEFKCKCBE, CGNEFKCKCBE, CGNEFKCKCBE> PANDDCKKAIH;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<CGNEFKCKCBE> MKEFPOPAFNA;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PKKHBPPMCDB(CGNEFKCKCBE BAAPAEECMJF, CGNEFKCKCBE NBLGHAFFFJF);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CGNEFKCKCBE MBLGGBDDFFK(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<CGNEFKCKCBE> HPHEFOJBMEB(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	CGNEFKCKCBE FIONLBLNPDB(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EECEAKDEHLD(CGNEFKCKCBE BAAPAEECMJF, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FEKOKLAEDJD(CGNEFKCKCBE BAAPAEECMJF, float FNEHDJDKKGC);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool DNMCBGCLJJN(CGNEFKCKCBE BAAPAEECMJF, [Out] CGNEFKCKCBE EMOKCJBMKOL);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool BCKGMBMKGJJ(CGNEFKCKCBE BAAPAEECMJF, [Out] RigidTransform PPKLABHNCPL);

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool HKGBAGLFGPA(CGNEFKCKCBE BAAPAEECMJF, [Out] float EFNNOCOHFOM);

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 ONCFKGBJLDO(FJOBILDGDJD JIMFJKNHNFO);

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "18")]
	quaternion OHNOFLENFNP(FJOBILDGDJD JIMFJKNHNFO);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class AEAKCOLGMBA
{
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface CFMBKPCNCPN
{
	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	object HGHNIAOJNCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FDEOGKEAAOG(LKKANPIGGEI HDBEGMKJNAF);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct HBKGEBHDKPB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly string CKEJJGPNKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly T KCDEJIJHLPJ;

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1F30", Offset = "0x3DC0F30", VA = "0x183DC1F30")]
	public HBKGEBHDKPB(T KCDEJIJHLPJ, [Optional][CallerMemberName] string CKEJJGPNKGO)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public static readonly HBKGEBHDKPB<int> AKNEGJKNICB;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public enum AODGIEJJAME
{
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public static class FDIIHHGCOFI
{
	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0xE48CC0", Offset = "0xE47CC0", VA = "0x180E48CC0")]
	public static bool EFDHPFNPILC(this AODGIEJJAME JKKAFCBPEPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0xE48CF0", Offset = "0xE47CF0", VA = "0x180E48CF0")]
	public static bool GIHMFDEGHDL(this AODGIEJJAME JKKAFCBPEPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x259B4F0", Offset = "0x259A4F0", VA = "0x18259B4F0")]
	public static bool NJOBPMLLGDB(this AODGIEJJAME JKKAFCBPEPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface ELOJDPFNIDO
{
	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	bool HJOOEFJMGPN
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface FMHNNPHEFMH
{
	[Cpp2IlInjected.Token(Token = "0x17000180")]
	AODGIEJJAME BKOFGJGHCDP
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	AODGIEJJAME DMJCFLNALOI
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	AODGIEJJAME PANBNAPFBFN
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	AODGIEJJAME FCGOMOAPKNN
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	AODGIEJJAME GHLJJKCGCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	AODGIEJJAME LMOMJKJKNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	AODGIEJJAME EECLNCMKDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	AODGIEJJAME IBJKFNIADFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	AODGIEJJAME CDJDECBBDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	AODGIEJJAME HJOOGNMPOHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	AODGIEJJAME KLAJLGCPAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	AODGIEJJAME OGNBPMDNPDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	AODGIEJJAME HHBPMIEDMAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	AODGIEJJAME HPJNDJJLNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	AODGIEJJAME ACENCNJKKEP
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	AODGIEJJAME JAFEJHMJPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int MKHPGHPCCLG(HBKGEBHDKPB<int> IOPKIGDDBDF);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface AFOMIBACJBH
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event HOPHAABJPMP.IMFEBEPNEOM LOAKGMAEDOH;

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CGNEFKCKCBE ICBECLEBNDD(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EPGLAOHKNIF(List<CGNEFKCKCBE> BNMAGGPPOBB);

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DBOINHOPMHF DMKGLODCJAI(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CLAPKOPJIOB(IEnumerable<CGNEFKCKCBE> KDHGCCNPEDM);

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DBOINHOPMHF HPKKFDMNJJD(CGNEFKCKCBE EMOKCJBMKOL, CGNEFKCKCBE ABGFGEMBNMN, bool ENMPBKADGPO, CGNEFKCKCBE KAEDHDLBKFF);

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CGNEFKCKCBE PIEECFGNFDJ(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MLPLIFGNEGJ(CGNEFKCKCBE BAAPAEECMJF, CGNEFKCKCBE EMOKCJBMKOL, bool LFPCLIMHHEJ);

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JICCEKOJJNA(CGNEFKCKCBE BAAPAEECMJF, CGNEFKCKCBE EMOKCJBMKOL);

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KMNLBJDBOMH(CGNEFKCKCBE GDFFBPBOEOM, CGNEFKCKCBE AAKAHFBGPAC);

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int HGFIHGLDIAE(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LKKANPIGGEI NKNNPOFKJDA(CGNEFKCKCBE BEHCCOMHFAP);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<CGNEFKCKCBE> CIMLCNJODHF(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool KPHFCMCABGL(CGNEFKCKCBE BAAPAEECMJF, CGNEFKCKCBE HPICCMDBOOO);

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IEnumerable<CGNEFKCKCBE> GHBPCFMLPBB(CGNEFKCKCBE BAAPAEECMJF, bool OKCIACNFKBA = false);

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool AAJKDFPIMOD(CGNEFKCKCBE BAAPAEECMJF, CGNEFKCKCBE EKGLHBPPKHM);

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	CGNEFKCKCBE ENDKGNGAGOH(CGNEFKCKCBE KAEDHDLBKFF, CGNEFKCKCBE EJOIPKEAGKL);

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool OEONFNMCDFO(CGNEFKCKCBE KAEDHDLBKFF, CGNEFKCKCBE EJOIPKEAGKL, [Out] CGNEFKCKCBE ACEKHGIMKMP);
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class PKJAENIBDGN
{
	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x6A85F70", Offset = "0x6A84F70", VA = "0x186A85F70")]
	public static List<CGNEFKCKCBE> EPGLAOHKNIF(this AFOMIBACJBH DAEHHHGOBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x6A86080", Offset = "0x6A85080", VA = "0x186A86080")]
	public static bool OHHGFHHHIIG(this AFOMIBACJBH DAEHHHGOBNN, CGNEFKCKCBE BAAPAEECMJF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface JGGKLJNAOEM
{
	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PKICOABIHAJ ABMEPCCCILN(CGNEFKCKCBE CJDMIKFIPBM);

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILEADLGBNFK(CGNEFKCKCBE CJDMIKFIPBM, PKICOABIHAJ AJHBEJJHJNH);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IBABIPKGIKN(CGNEFKCKCBE CJDMIKFIPBM);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FKFFJLIDFHH(CGNEFKCKCBE CJDMIKFIPBM, bool JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string[] CEBNLFMFHDM(CGNEFKCKCBE CJDMIKFIPBM);

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FBNNOGDMGNI(CGNEFKCKCBE CJDMIKFIPBM, IEnumerable<string> AIOEALANAFH);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string[] HOJEHECJPCP(CGNEFKCKCBE CJDMIKFIPBM);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JIPJJLIJPAG(CGNEFKCKCBE CJDMIKFIPBM, IEnumerable<string> AIOEALANAFH);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "8")]
	string[] GAJBENAIOFO(CGNEFKCKCBE CJDMIKFIPBM);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ECCLPFBCNBN(CGNEFKCKCBE CJDMIKFIPBM, IEnumerable<string> AIOEALANAFH);

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string[] EDADGMLAAJA(CGNEFKCKCBE CJDMIKFIPBM);

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BJJELFKECMA(CGNEFKCKCBE CJDMIKFIPBM, IEnumerable<string> AIOEALANAFH);

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool DBFPEMFJJPP(CGNEFKCKCBE CJDMIKFIPBM, CGNEFKCKCBE GOJJHGGKKML);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface FKMLLNJJEAH
{
	[Cpp2IlInjected.Token(Token = "0x17000190")]
	bool DHKGKGCLOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	bool DNFKEGFKPLB
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	bool ENJDLPEHFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface JLDNAINOLDM : PFCKKIEAEBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LCINJJAIDMB(Entity BOENFECPGGB, [Out] PPGHFHGIDHH EFPCBKOLOGB);

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GPMCCKDHFLO(NativeArray<PPGHFHGIDHH> DFCFMCAFJAI, NativeArray<HBNOIKLAECM> ODKJMCLECPD);

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ENDCOOLKHHM(PPGHFHGIDHH EFPCBKOLOGB);

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CMDLCLDNPDB(PPGHFHGIDHH EFPCBKOLOGB, [Out] Collider PEMDJFGIBMG);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface PFCKKIEAEBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GJJIHCIMEKB([In] float3 MAFKHKANKNB, [In] float3 DJAIHLPIJBH, float BIJEBEJFKBC, Allocator OOMMBGGEBLM, [Out] NativeArray<Entity> LCKAMOJEGOK);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface EFHGOFDNKPD
{
	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GJJIHCIMEKB([In] float3 MAFKHKANKNB, [In] float3 DJAIHLPIJBH, float BIJEBEJFKBC, [Out] CALFIEDFMJK AMPILLJCNOE, [Out] CGNEFKCKCBE NNDCOCPJBGH);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface NNAHDNCKENE
{
	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJJIHCIMEKB([In] NativeArray<Entity> LCKAMOJEGOK, [In] float3 MAFKHKANKNB, [In] float3 DJAIHLPIJBH, [In] NativeArray<CALFIEDFMJK> DKFODGOBPAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct PPGHFHGIDHH : GONNAKCGBMI, IEquatable<PPGHFHGIDHH>
{
	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public int LCNJIFOOGIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xB57280", Offset = "0xB56280", VA = "0x180B57280", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xB57260", Offset = "0xB56260", VA = "0x180B57260", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public int BPAJHBABCHA
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x25ADC50", Offset = "0x25ACC50", VA = "0x1825ADC50", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x5D41F50", Offset = "0x5D40F50", VA = "0x185D41F50", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x6A860F0", Offset = "0x6A850F0", VA = "0x186A860F0", Slot = "8")]
	public bool Equals(PPGHFHGIDHH ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x6A86140", Offset = "0x6A85140", VA = "0x186A86140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct CALFIEDFMJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float AFLFICBEHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float3 NJOPFIOMLFB;
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface NKBALMNPFNN
{
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface OEENGDBIBNC
{
	[Cpp2IlInjected.Token(Token = "0x17000195")]
	FNLPLJPPMJI DDEKKFALKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	NPPPNEJNGDK IKDHFOHOEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<LKKANPIGGEI, NativeArray<NCCOBPNELMJ>> DMPANMOJBOM;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<LKKANPIGGEI> CFABGGLMAOJ;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JNJKFNOHIAL KMLONFMAHHP(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NCCOBPNELMJ OEKJKCBPCJG(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GGLLICMBJNI(FDJBMECGDOM FGMNEAGEGFD, KNAPGDHPEDB MAGHAAOCCIG);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MLJIINCEHKB(FDJBMECGDOM[] HOBPFEIBGHF, GameObject IDHOMJBMFPB);

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LBDNIKJOCAM BHBAACEFIIB(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool DNLKCBIKKAB(CGNEFKCKCBE BAAPAEECMJF, [Out] Transform DBCCBLKNBHK);

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool OCMGEBDGBAP(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KCNJMJPINMK(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CGNEFKCKCBE DAJDBCACOON(FDJBMECGDOM FGMNEAGEGFD);

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool LLLBHNPHFLP(FDJBMECGDOM FGMNEAGEGFD, [Out] CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	FDJBMECGDOM POBJONAIPNE(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	LocalId BMBHJAKFOBO(LocalId PMMOCHIMBLC);

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "18")]
	LKKANPIGGEI DAJDBCACOON(NativeArray<FDJBMECGDOM> FGMNEAGEGFD, Allocator OOMMBGGEBLM);

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "19")]
	LKKANPIGGEI OHAADNBJEDG(NCCOBPNELMJ LFOOJAPBKNN, int DOPPKGNLPAC, Allocator OOMMBGGEBLM);

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "20")]
	LKKANPIGGEI GEIPOBNMEMG(NativeArray<FDJBMECGDOM> FGMNEAGEGFD, NativeArray<LLDAEMAABEO> FBAANPHLONN, Allocator OOMMBGGEBLM);

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "21")]
	FDJBMECGDOM[] ADDDLIIPDLO(string EDIGKGDEKFI, LBDNIKJOCAM IKKLBFLNFIP, bool LHFPOBNDFIL);

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BDLADCLDKGD(string EDIGKGDEKFI, FDJBMECGDOM[] HOBPFEIBGHF);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "23")]
	LBDNIKJOCAM GIHFMEDBBLI(NCCOBPNELMJ LFOOJAPBKNN, bool GDABFJHODHL);

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(Slot = "24")]
	LBDNIKJOCAM GIHFMEDBBLI(NCCOBPNELMJ LFOOJAPBKNN);

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "25")]
	LBDNIKJOCAM FKNOPPFFJCB(NCCOBPNELMJ LFOOJAPBKNN);

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "26")]
	LBDNIKJOCAM LLBOADOCPAM(NCCOBPNELMJ LFOOJAPBKNN);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "27")]
	LBDNIKJOCAM GOFOGENNHGI(FDJBMECGDOM FGMNEAGEGFD, NCCOBPNELMJ LFOOJAPBKNN);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "28")]
	CNPBEIPHOEC DGFNIEMKGCJ();

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	HIHFENJMIEP CNFBENFEKIJ();

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	HHCMEPCHJNE GLPHCGJFEDE(CBPMDLJFIEM PBABHLCDMLG);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void ICEEEJOHKNP(LKKANPIGGEI HDBEGMKJNAF);

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void CANECBKHGDE(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void JIINMEIPOEL(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void ICEEEJOHKNP(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void NIHBPNCNBHJ(CGNEFKCKCBE HDBEGMKJNAF);

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "36")]
	bool BJHJIKBAKMO(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "37")]
	LKKANPIGGEI IIALAENOIOK(LKKANPIGGEI LPBPCGOPJJI, Allocator OOMMBGGEBLM);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool HDJFKMFFGDE(CGNEFKCKCBE BAAPAEECMJF);
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class MFINCPAIKFL
{
	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6A81110", Offset = "0x6A80110", VA = "0x186A81110")]
	public static void KCNJMJPINMK(this OEENGDBIBNC AAAODCCDNKB, KNAPGDHPEDB MAGHAAOCCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6A80E80", Offset = "0x6A7FE80", VA = "0x186A80E80")]
	public static LBDNIKJOCAM LNDFBMIJIEB(this OEENGDBIBNC AAAODCCDNKB, LocalId BAAPAEECMJF)
	{
		return default(LBDNIKJOCAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6A81190", Offset = "0x6A80190", VA = "0x186A81190")]
	public static LBDNIKJOCAM LNDFBMIJIEB(this OEENGDBIBNC AAAODCCDNKB, FDJBMECGDOM FGMNEAGEGFD)
	{
		return default(LBDNIKJOCAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6A80E80", Offset = "0x6A7FE80", VA = "0x186A80E80")]
	public static CGNEFKCKCBE DAJDBCACOON(this OEENGDBIBNC AAAODCCDNKB, LocalId BAAPAEECMJF)
	{
		return default(CGNEFKCKCBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6A813F0", Offset = "0x6A803F0", VA = "0x186A813F0")]
	public static FDJBMECGDOM POBJONAIPNE(this OEENGDBIBNC AAAODCCDNKB, LocalId BAAPAEECMJF)
	{
		return default(FDJBMECGDOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6A80FA0", Offset = "0x6A7FFA0", VA = "0x186A80FA0")]
	public static bool HDJFKMFFGDE(this OEENGDBIBNC AAAODCCDNKB, FDJBMECGDOM FGMNEAGEGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x2CA2BF0", Offset = "0x2CA1BF0", VA = "0x182CA2BF0")]
	public static T NNJEAJOPEIF<T>(this OEENGDBIBNC AAAODCCDNKB, LocalId BAAPAEECMJF) where T : struct, MGJOCMDKJPC
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x6A80D90", Offset = "0x6A7FD90", VA = "0x186A80D90")]
	public static CNPBEIPHOEC AAEJJAHDGLL(this OEENGDBIBNC AAAODCCDNKB, RigidTransform NKKKCLCLIIH)
	{
		return default(CNPBEIPHOEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6A81010", Offset = "0x6A80010", VA = "0x186A81010")]
	public static HHCMEPCHJNE JKDJDLJBPPD(this OEENGDBIBNC AAAODCCDNKB, CBPMDLJFIEM FMJIFMCJJNB, RigidTransform NKKKCLCLIIH)
	{
		return default(HHCMEPCHJNE);
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6A80EB0", Offset = "0x6A7FEB0", VA = "0x186A80EB0")]
	public static HIHFENJMIEP FFFABPFIJBI(this OEENGDBIBNC AAAODCCDNKB, RigidTransform NKKKCLCLIIH)
	{
		return default(HIHFENJMIEP);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6A811F0", Offset = "0x6A801F0", VA = "0x186A811F0")]
	private static void MPAJIFGCAGI(LBDNIKJOCAM HLOHIJEPADH, RigidTransform NKKKCLCLIIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface FOGCBBJBLKA
{
	[Cpp2IlInjected.Token(Token = "0x17000197")]
	bool DKLCNPFCMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	CGNEFKCKCBE OMOMENOMLAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	LBDNIKJOCAM PFGKDDMLFJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event BJCLLHHLLPG LBPPOLBADEP;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CGNEFKCKCBE ENDKGNGAGOH(CGNEFKCKCBE KAEDHDLBKFF, CGNEFKCKCBE EJOIPKEAGKL);

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OEONFNMCDFO(CGNEFKCKCBE KAEDHDLBKFF, CGNEFKCKCBE EJOIPKEAGKL, [Out] CGNEFKCKCBE ACEKHGIMKMP);

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JLPNHIMBOJE();

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OKIKKDIFFGL();

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ECPJAGCCMPC(CGNEFKCKCBE KAEDHDLBKFF);

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool EIJAEEOFFPM(CGNEFKCKCBE KAEDHDLBKFF);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public delegate void BJCLLHHLLPG(LBDNIKJOCAM OPGMOCKALJP, LBDNIKJOCAM IFOJMNAKOGE);
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class DEFOFLBDOEL
{
	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x6A77510", Offset = "0x6A76510", VA = "0x186A77510")]
	public static bool LOLFDAILOMO(this FOGCBBJBLKA GLOCBKKIDHI, LBDNIKJOCAM KAEDHDLBKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x6A773B0", Offset = "0x6A763B0", VA = "0x186A773B0")]
	public static bool ALAJCJMAPKE(this FOGCBBJBLKA GLOCBKKIDHI, CGNEFKCKCBE KAEDHDLBKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6A77490", Offset = "0x6A76490", VA = "0x186A77490")]
	public static bool BNNCDNDHCKJ(this FOGCBBJBLKA GLOCBKKIDHI, CGNEFKCKCBE KAEDHDLBKFF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface LKLLPLJKLOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MCLFKDBOFHF(LBDNIKJOCAM HLOHIJEPADH, MLMCOPCJNLO GKANCDPDLNF, List<LBDNIKJOCAM> NIJMADLECIB);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int BFEBHLPGOGB(LBDNIKJOCAM HLOHIJEPADH, MLMCOPCJNLO GKANCDPDLNF);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HAANCEOCHJM(LBDNIKJOCAM HLOHIJEPADH, List<LBDNIKJOCAM> NIJMADLECIB);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int CBDGBGLBFJH(LBDNIKJOCAM HMLGIEBFMDJ, LBDNIKJOCAM KAEDHDLBKFF, MLMCOPCJNLO GKANCDPDLNF);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LBDNIKJOCAM DIOOOEHOKHC(LBDNIKJOCAM HMLGIEBFMDJ, int HCALFJOJKJO, MLMCOPCJNLO GKANCDPDLNF);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IJKIOPPKJJG(LBDNIKJOCAM HMLGIEBFMDJ, LBDNIKJOCAM KAEDHDLBKFF, MLMCOPCJNLO GKANCDPDLNF);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KCNBMNGAPHC(LBDNIKJOCAM HMLGIEBFMDJ, LBDNIKJOCAM KAEDHDLBKFF, MLMCOPCJNLO GKANCDPDLNF);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FHLCJHEINCI(LBDNIKJOCAM HMLGIEBFMDJ, MLMCOPCJNLO GKANCDPDLNF);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BIDJEHNMEIJ(LBDNIKJOCAM HMLGIEBFMDJ, LBDNIKJOCAM KAEDHDLBKFF, MLMCOPCJNLO GKANCDPDLNF);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KFIPAIHMPDE(Entity HMLGIEBFMDJ, Entity KAEDHDLBKFF, MLMCOPCJNLO GKANCDPDLNF);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MMPPIAALBFE(Entity HMLGIEBFMDJ, MLMCOPCJNLO GKANCDPDLNF);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KDEGLCPMPHB(LBDNIKJOCAM KAEDHDLBKFF, MLMCOPCJNLO GKANCDPDLNF);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface CEBINELOHPC
{
	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DJHNCPNPCPC(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MEPEMDEEMFE(CGNEFKCKCBE BAAPAEECMJF, Transform DBCCBLKNBHK);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface JOPHOCAGIDH
{
	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LEOPLIBGHOM(CGNEFKCKCBE KAEDHDLBKFF, CGNEFKCKCBE GKPCIBCGDDP);

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JLACFPAJOEC(CGNEFKCKCBE KAEDHDLBKFF, CGNEFKCKCBE NJHEGBCLLHJ);

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CAHKFKHMKDM(CGNEFKCKCBE KAEDHDLBKFF, [Out] CGNEFKCKCBE CGEJCCLBLFG);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface INBICOBKMCK
{
	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJMHMDEKAAD(CGNEFKCKCBE BEHCCOMHFAP, bool JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHILGIMOHDN(CGNEFKCKCBE BEHCCOMHFAP, bool JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DGIOIIFOAJN(CGNEFKCKCBE BEHCCOMHFAP, int JJCEIJMGOAB);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface GMAJLNFKMKB
{
	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<CGNEFKCKCBE> OHBDNDGFNLO(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CGNEFKCKCBE CACNBMBGCFA(CGNEFKCKCBE BAAPAEECMJF, int HCALFJOJKJO);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int BDHOMBAKIMN(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DHJPOFIAJDN DMCFKBGMOCI(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EBKCPLFKEKJ(CGNEFKCKCBE BAAPAEECMJF, DHJPOFIAJDN OEFIADEKGGF);

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CGNEFKCKCBE DHEGFPPOLFO(CGNEFKCKCBE BAAPAEECMJF, [Optional] float3? LLLHNMGEKPM, [Optional] quaternion? BCKIPOGEHOJ, [Optional] float3? FHBDGLOPEKN);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CGNEFKCKCBE PNIJHMAHFEF(CGNEFKCKCBE BAAPAEECMJF, int HCALFJOJKJO, [Optional] float3? LLLHNMGEKPM, [Optional] quaternion? BCKIPOGEHOJ, [Optional] float3? FHBDGLOPEKN);

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LOOLMLBFIFM(CGNEFKCKCBE BAAPAEECMJF, int HCALFJOJKJO);

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PLNOIHJBPON(CGNEFKCKCBE BAAPAEECMJF);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface IFLPLBCLPON
{
	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGFGILKKOAA();

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ELJAGMKOFBA();

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BLHGOAHOACH();

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MBAOHAAFMDB();

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NAMLEOLIIAF();

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HFOEINJPCND();

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PIFDBCKHBFG();

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ECEMBCCAGAC();

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EHICFIJDBDC();

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PJGINFEKEIH();

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FDICEDEDAIK();

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ONPMONBGOKC();

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BFEOLFEBBMO();
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface ELHOOHGIKMC
{
	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EFHLGAEMFBL(CGNEFKCKCBE KAEDHDLBKFF, [Out] int HMLGIEBFMDJ);

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OHJJINMJBGJ(CGNEFKCKCBE KAEDHDLBKFF, int HMLGIEBFMDJ);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CNLMPAJDMII(CGNEFKCKCBE KAEDHDLBKFF, bool AJNJOGNFDFA);

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IGOGFAAHFON(CGNEFKCKCBE KAEDHDLBKFF, bool FGOJNBNDHFG);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BGNHDPHEPAL(CGNEFKCKCBE KAEDHDLBKFF, float NIEHCAPCMGN, float DNHNKJBHBBJ, float ALDPOJHHLDM);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PCFNAGNHJKK(CGNEFKCKCBE BAAPAEECMJF, [Out] float DNHNKJBHBBJ, [Out] float ALDPOJHHLDM);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OCNHCHOBLHC(CGNEFKCKCBE KAEDHDLBKFF, float3 LLLHNMGEKPM, quaternion BCKIPOGEHOJ);

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool PPKOPPOMKFB(CGNEFKCKCBE KAEDHDLBKFF, [Out] float3 LLLHNMGEKPM, [Out] quaternion BCKIPOGEHOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface NHCPPBLHPHO
{
	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HHEFCFNMADJ(Entity BOENFECPGGB);

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDDNJAILNEJ(Entity BOENFECPGGB, [In] float3 JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 KFNINIHPNGI(Entity BOENFECPGGB);

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GLNOPJJOAFP(Entity BOENFECPGGB, [In] quaternion JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion APCLFIFOPCF(Entity BOENFECPGGB);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NLGHOMBLIEN(Entity BOENFECPGGB, [In] float3 LLLHNMGEKPM, [In] quaternion BCKIPOGEHOJ);

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NHADGKHIKJI(Entity BOENFECPGGB, [Out] float3 LLLHNMGEKPM, [Out] quaternion BCKIPOGEHOJ);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NHADGKHIKJI(Entity BOENFECPGGB, [Out] RigidTransform AADDEKEOOHB);

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HBBLFFLNFCC(Entity BOENFECPGGB, [Out] float3 LLLHNMGEKPM, [Out] quaternion BCKIPOGEHOJ);

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HBBLFFLNFCC(Entity BOENFECPGGB, [Out] RigidTransform AADDEKEOOHB);

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float3 HNAPHGIMMBO(Entity BOENFECPGGB);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FENBGBLGHGM(Entity BOENFECPGGB, [In] float3 JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BHLBNCHHADC(Entity BOENFECPGGB, float JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float PKAPFOIADPO(Entity BOENFECPGGB);

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LHNOHACBJEJ(Entity BOENFECPGGB, [In] float3 JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 DKBKGLDMPLK(Entity BOENFECPGGB);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void POBDKLIOMGC(Entity BOENFECPGGB, [In] float3 JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 DBBOABIDLDG(Entity BOENFECPGGB);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PLDLFGNGLJH(Entity BOENFECPGGB, [In] quaternion JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	quaternion CIKEEPBMJNK(Entity BOENFECPGGB);

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 JAIGCEIAMCG(Entity BOENFECPGGB);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void OPDFCLAKHBJ(Entity BOENFECPGGB, [In] float3 JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void DMGBAOBICDB(Entity BOENFECPGGB, float JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float IEHLJNAGKNO(Entity BOENFECPGGB);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void HIAPDNDBNMB(Entity BOENFECPGGB, [In] float3 JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float3 HKNNCLJDJHA(Entity BOENFECPGGB);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NMECPEOBDKD(Entity BOENFECPGGB, [Out] float4x4 NAKEHMEBJJB);

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void AAMNOALFJKJ(Entity BOENFECPGGB, [In] float4x4 NAKEHMEBJJB);

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void HBHIJPDLGLK(Entity BOENFECPGGB, [Out] float4x4 NAKEHMEBJJB);

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool DNLKCBIKKAB(Entity BOENFECPGGB, [Out] Transform DBCCBLKNBHK);

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void DLOIOEOHPAE(Entity BOENFECPGGB);

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void IDJMKIKOJFP(Entity BOENFECPGGB, Entity JHCCBIEGECC, Entity MECDJMBEHCP);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class KHJJJOLIAMJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface KHMCLKKAGDP
{
	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DJDDHEPAILF(bool OJHGBAANJLF);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface HPEPJBFJDOB
{
	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKKHKAOIGFG(CGNEFKCKCBE CJDMIKFIPBM, IEnumerable<string> AIOEALANAFH);

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MGKIMEEGNAF(CGNEFKCKCBE CJDMIKFIPBM, IEnumerable<string> AIOEALANAFH);

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BPHPOJNMOII(CGNEFKCKCBE CJDMIKFIPBM, params string[] AIOEALANAFH);

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GPAMKBIPFDK(CGNEFKCKCBE CJDMIKFIPBM, params string[] AIOEALANAFH);

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PJFNBPLJLCD(CGNEFKCKCBE CJDMIKFIPBM, params string[] AIOEALANAFH);

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CJMHENJOKNE(CGNEFKCKCBE CJDMIKFIPBM, params string[] AIOEALANAFH);

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int AEMMCDBHKKP(CGNEFKCKCBE CJDMIKFIPBM);

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int NPIMJHAJFAB(CGNEFKCKCBE CJDMIKFIPBM);

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JPDFEDKPGOF(CGNEFKCKCBE CJDMIKFIPBM, ICollection<string> BCOEJAHEPCH);

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NLNEDOKIOKK(CGNEFKCKCBE CJDMIKFIPBM, ICollection<string> BCOEJAHEPCH);

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool LKODOLHDDDD(CGNEFKCKCBE CJDMIKFIPBM, string EEMOJGOOGIP);

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FFIHOMKNMPB(string EEMOJGOOGIP, BCKKMILDKKA MMBOLCKPLJG);

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OFDCPMCIGIK(string EEMOJGOOGIP, BCKKMILDKKA MMBOLCKPLJG);

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool EJAEFGCEFFK();

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JMAEFAKHNEP(IEnumerable<string> AIOEALANAFH);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface MKLPKKDIACP
{
	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World MPAFCBOMGHE(string HOJIMECPIMD = "Main");

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World IHAHIHGIDHJ(string HOJIMECPIMD = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World OOAAIEJECIB(string HOJIMECPIMD = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World LEJJLPBEMJC(string HOJIMECPIMD = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface ACKGFBDMFHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	World ONAFIBAGAAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	World PDOMKEIBJGK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	EntityManager IAIHKKDCAON
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	bool HALEFOFGOBN
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase BKCCJNIMPPO(Type HNGLFCFOHLI);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class AJJFIAFEBMP
{
	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A726F0", Offset = "0x6A716F0", VA = "0x186A726F0")]
	public static ComponentSystemBase OIMDOJPLDJI(this World EJDHINIBNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x326B900", Offset = "0x326A900", VA = "0x18326B900")]
	public static T BKCCJNIMPPO<T>(this ACKGFBDMFHC FKNNHIAACNH) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface FOFBKEDHGLC
{
	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGKICOLKLAO(NativeListAsync<Entity> HHHAAAGFNDE);

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDNNCGDNLOO(OJPAIBCHMKF IBAJOAIOBPP);

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GBHHDKLPMFP(NativeListAsync<Entity> HODHAFGJMHE, bool PFGJBPMJCFA);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BKAOLJCIDOO();
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface LDAPHBHMDEG
{
	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DPAFPALOBFF(Collider PEMDJFGIBMG, [Out] BIEBIJDNCGJ DPNFMOLLIDO);
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface AEHFDOOJOOH
{
	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DHHJBGNNHEB(CGNEFKCKCBE BAAPAEECMJF, [Out] Collider PEMDJFGIBMG);

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject KELKIHACPEN(CGNEFKCKCBE ILIMCGEKDMD, GameObject MOMIHMCFFKF, Vector3 IJLMJJLHNIG, Quaternion EJNJAFFEDPH);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IAMKCCCDGKF(GameObject PEMDJFGIBMG);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider DOIHBGNMIPJ<TCollider>(GameObject EGFODBACFPG) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MOABKLDLMPL(Collider PEMDJFGIBMG);

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject JFCGBJPFGBH<TCollider>(string CKEJJGPNKGO) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public enum NELJIJILIFB
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
[Cpp2IlInjected.Token(Token = "0x200009D")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface LDPNDCEILGA
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public struct ANJOBIBCJMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int FACAIJPMLJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public GameObject MOMIHMCFFKF;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CNONLLIHAAE(CGNEFKCKCBE BAAPAEECMJF, OLHMOHMFBLK IAKGNJPCHPE, bool JHBBAOLPPPK, CCGENIJLDEA PFPJGPIFILB);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APIALCEHGLP(CGNEFKCKCBE BAAPAEECMJF, OLHMOHMFBLK IAKGNJPCHPE, bool JHBBAOLPPPK, bool AIBBEPGGHLA, bool JBFOECADAJI);

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MCELAAFGJDH GHFPGKKOKBN(CGNEFKCKCBE JMCFDCHCIPI, List<CGNEFKCKCBE> CCKIHNJNBJI);

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HILINDEBAMG(GameObject AKINJENKGOO, GameObject IMEODPFMEIO);

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ILDKHGEDPDI(GameObject AKINJENKGOO, List<GameObject> CMJFJDFNJLA);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FCAFIDEHAHH(GameObject IMEODPFMEIO);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T DOIHBGNMIPJ<T>(GameObject EGFODBACFPG) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MOABKLDLMPL(Collider PEMDJFGIBMG);

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EGOAAIGJOEA(LKKANPIGGEI BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HFEKHEPNDHB(LKKANPIGGEI BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GameObject JPCLJANJIPM<T>(string CKEJJGPNKGO) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool AEJLEPIAPHM(Collider PEMDJFGIBMG, [Out] CGNEFKCKCBE HMLGIEBFMDJ);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool ACGEFNLEAFP(CGNEFKCKCBE BAAPAEECMJF, [Out] BIEBIJDNCGJ DPNFMOLLIDO);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<NELJIJILIFB> PGKBIFPJLOA(Allocator OOMMBGGEBLM = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Mesh[] HMLCGOAOCNJ();

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int OAEODPGCDOK(OLHMOHMFBLK IAKGNJPCHPE);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string NMAGOKCMEIB(OLHMOHMFBLK IAKGNJPCHPE);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface LIDINEBGDLL
{
	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MOFEODPEIPI(CGNEFKCKCBE BAAPAEECMJF, CGNEFKCKCBE JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JMPGGDOEONM(CGNEFKCKCBE BAAPAEECMJF, CGNEFKCKCBE JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int HGFIHGLDIAE(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CGNEFKCKCBE OLACCODENNC(CGNEFKCKCBE BAAPAEECMJF, int HCALFJOJKJO);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LKKANPIGGEI MLBMLKBENKA(CGNEFKCKCBE BAAPAEECMJF, Allocator OOMMBGGEBLM = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KLPGDAPGCAM(CGNEFKCKCBE BAAPAEECMJF, object DJIBMMAIGPE, CGNEFKCKCBE JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CBGHOOFPECO(CGNEFKCKCBE BAAPAEECMJF, object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool ENBPCANEJCD(CGNEFKCKCBE BAAPAEECMJF, [Out] CGNEFKCKCBE JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PGNNOHPONFM(CGNEFKCKCBE BAAPAEECMJF, float3 JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PLOGALNGAHP(CGNEFKCKCBE BAAPAEECMJF, [Out] float3 JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IGMAOAFKOGG(CGNEFKCKCBE BAAPAEECMJF, float3 JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OPPCIPCMOGF(CGNEFKCKCBE BAAPAEECMJF, [Out] float3 JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IAFCGBKBJIE(CGNEFKCKCBE BAAPAEECMJF, (Quaternion rot, Vector3 moments) FGEFCHPKOHN);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool GLBPCEHLKFE(CGNEFKCKCBE BAAPAEECMJF, [Out] quaternion BDNMFDAFNND, [Out] float3 HKDCGCLOGCC);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IFPBOIKFHLM(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 KHODMIEOFGB(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 AELHHHDGHFO(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JOEIJCAPIID(CGNEFKCKCBE BAAPAEECMJF, float3 JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void LMBCHNGNAGN(CGNEFKCKCBE BAAPAEECMJF, float3 JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float EBECFODKHIB(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float HBIMAEELKFH(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BBOLHOEOFOM(CGNEFKCKCBE BAAPAEECMJF, float JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BHBCLPKGEHN(CGNEFKCKCBE BAAPAEECMJF, float JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode IGDJCICBCOB(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CFFBKIEPJNE(CGNEFKCKCBE BAAPAEECMJF, CollisionDetectionMode JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "25")]
	OIAPKHBMKCC MFOMFMBHJKA(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GJCFMKJPCBJ(CGNEFKCKCBE BAAPAEECMJF, OIAPKHBMKCC JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool HBIPHBJGLNN(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void IBNCKFBDAHB(CGNEFKCKCBE BAAPAEECMJF, bool JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "29")]
	CGNEFKCKCBE ICBECLEBNDD(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void CEJOKLFEGHA(CGNEFKCKCBE BAAPAEECMJF, CGNEFKCKCBE JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	CGNEFKCKCBE PIEECFGNFDJ(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void MLPLIFGNEGJ(CGNEFKCKCBE BAAPAEECMJF, CGNEFKCKCBE JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "33")]
	JMHIAMIADEH MOBBDAAJCDF(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void CNGKECKNMGH(CGNEFKCKCBE BAAPAEECMJF, JMHIAMIADEH DJMDNPHHLCI);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool CLOFKEJICPB(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void MPAHIMNCPNH(CGNEFKCKCBE BAAPAEECMJF, bool JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool MGPBEFDGBJL(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void PEHNDEAACAC(CGNEFKCKCBE BAAPAEECMJF, bool JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints LAHNIJOABLG(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void IPHDHLCLPPK(CGNEFKCKCBE BAAPAEECMJF, RigidbodyConstraints JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float PMDDFHEGNNM(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void ALMFIBMHIBK(CGNEFKCKCBE BAAPAEECMJF, float JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float PFLMCKCMNKK(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void NCNEBJNOFIA(CGNEFKCKCBE BAAPAEECMJF, float JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool AGCONLPIMBO(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void MPGFDNHLIEC(CGNEFKCKCBE BAAPAEECMJF, bool JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool EJMJFNCAKBJ(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void IDBPOFOBLNP(CGNEFKCKCBE BAAPAEECMJF, bool JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void BKHMDADIOCJ(CGNEFKCKCBE BAAPAEECMJF, int JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "50")]
	GHKLKADMCLK ICPIKAPENFB(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void JGDKODEEPPK(CGNEFKCKCBE BAAPAEECMJF, GHKLKADMCLK JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "52")]
	JLDEAACPJLG LMIOEBDHLJP(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void GLADGLLKIBL(CGNEFKCKCBE BAAPAEECMJF, JLDEAACPJLG JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float JGHEDOCEFOG(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void MJCHALGDDAP(CGNEFKCKCBE BAAPAEECMJF, float JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void GHNHGOPFLKK(CGNEFKCKCBE BAAPAEECMJF, object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void AGKAHLKCANF(CGNEFKCKCBE BAAPAEECMJF, object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool HIEOKPKBNOH(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void ECGPGAKPIJD(CGNEFKCKCBE BAAPAEECMJF, object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void KBOJAGGGOEA(CGNEFKCKCBE BAAPAEECMJF, object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool AMEMHCOAINB(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool AABNHNMHAPM(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody ALLGDPFACME(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void KPODCIFCDKJ(CGNEFKCKCBE BAAPAEECMJF, Rigidbody MEADPIPLGKG);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void CGAAOOCFJLO(CGNEFKCKCBE BAAPAEECMJF, object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void BEDABBIDNKK(CGNEFKCKCBE BAAPAEECMJF, object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool JOBCDHJHOGJ(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void AGKMPCFCPDA(CGNEFKCKCBE BAAPAEECMJF, float3 LKAKKODKGLB);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void KNJONNPFNPP(CGNEFKCKCBE BAAPAEECMJF, float3 IFMDAJCPKED);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool DFEBBMEJBIO(CGNEFKCKCBE BAAPAEECMJF, [Out] float3 LKAKKODKGLB);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool MMKPJOCGLCK(CGNEFKCKCBE BAAPAEECMJF, [Out] float3 IFMDAJCPKED);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool FECJGCKLHED(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void PJKMCDLBNMD(CGNEFKCKCBE BAAPAEECMJF, object DJIBMMAIGPE, bool NMJDAPPHKKG);

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void BEJABNLKDIG(CGNEFKCKCBE BAAPAEECMJF, bool MEEOIPHJBIH);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void IACCEJMJAFJ(CGNEFKCKCBE BAAPAEECMJF);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool MHDPNFJCPCI(CGNEFKCKCBE BAAPAEECMJF);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface LEDFGKADNPA
{
	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFGOCNELBLD(Entity FOFDMIJKEPL);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNPCMHLOBIJ(Entity FOFDMIJKEPL);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface IDFOAMIMPDK
{
	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBOABKCPIDK(CGNEFKCKCBE KAEDHDLBKFF, bool HCAJOFFCDJN);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GEJEJCFOEEI(CGNEFKCKCBE KAEDHDLBKFF, int NAOBJALFMLA);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public delegate void NILFDJLCPPH(BBOHBJGINLG LMHJHOMHKMC);
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public readonly ref struct BBOHBJGINLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly LKKANPIGGEI CCFCGPNLFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly NativeArray<byte> MLCLDLJNFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly NativeArray<byte> PKGBKHFHJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly GJDOIBPJHGJ ILCJHJBBALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly int HDLOONGHKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly Type MHLDANHKOCK;

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public LKKANPIGGEI AAGMOAJFDCC
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0xB50CF0", Offset = "0xB4FCF0", VA = "0x180B50CF0")]
		get
		{
			return default(LKKANPIGGEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x6A728C0", Offset = "0x6A718C0", VA = "0x186A728C0")]
	public BBOHBJGINLG(LKKANPIGGEI CCFCGPNLFED, NativeArray<byte> MLCLDLJNFJB, NativeArray<byte> PKGBKHFHJKG, GJDOIBPJHGJ ILCJHJBBALD, int HDLOONGHKEN, Type MHLDANHKOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x2925F40", Offset = "0x2924F40", VA = "0x182925F40")]
	public NativeArray<T> CINGPDMJEEI<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x2926070", Offset = "0x2925070", VA = "0x182926070")]
	public NativeArray<T> NNPDJMDCIIJ<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x2925F80", Offset = "0x2924F80", VA = "0x182925F80")]
	public (LKKANPIGGEI, NativeArray<T>, NativeArray<T>) MKHPGHPCCLG<T>() where T : struct
	{
		return default((LKKANPIGGEI, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x6A72890", Offset = "0x6A71890", VA = "0x186A72890")]
	public GBDIJAHBFBE ALCPKCGBHAP()
	{
		return default(GBDIJAHBFBE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public interface FLGGJCDCOAL
{
	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	string DGEHCOGHMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	FLGGJCDCOAL MCPCHOIAMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	IEnumerable<FLGGJCDCOAL> JGMMBOBFHGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface PJFFDHIKAJF
{
	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	FLGGJCDCOAL KAJDIJKALOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	List<NAFJPIJGFIL> IJPGDNALIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KPPINNFBPAC(NAFJPIJGFIL HNKKKCPLLDH, [Out] FLGGJCDCOAL FMFBBDLJBDD);

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GGLLICMBJNI(NAFJPIJGFIL HNKKKCPLLDH, NILFDJLCPPH JOHKGNANMPE);

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CNEBNJPACBD(NAFJPIJGFIL HNKKKCPLLDH, NILFDJLCPPH JOHKGNANMPE);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public readonly ref struct GBDIJAHBFBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly BBOHBJGINLG AHGAPHMJDIB;

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public LKKANPIGGEI AAGMOAJFDCC
	{
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xB50CF0", Offset = "0xB4FCF0", VA = "0x180B50CF0")]
		get
		{
			return default(LKKANPIGGEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A100", Offset = "0x6A79100", VA = "0x186A7A100")]
	public GBDIJAHBFBE(BBOHBJGINLG AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x6A79D40", Offset = "0x6A78D40", VA = "0x186A79D40")]
	public LKKANPIGGEI CINGPDMJEEI()
	{
		return default(LKKANPIGGEI);
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A030", Offset = "0x6A79030", VA = "0x186A7A030")]
	public LKKANPIGGEI NNPDJMDCIIJ()
	{
		return default(LKKANPIGGEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x6A79E10", Offset = "0x6A78E10", VA = "0x186A79E10")]
	public (LKKANPIGGEI, LKKANPIGGEI, LKKANPIGGEI) MKHPGHPCCLG()
	{
		return default((LKKANPIGGEI, LKKANPIGGEI, LKKANPIGGEI));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
[DefaultMember("Item")]
public interface LEOPGDJGDEN : IEnumerable<LNKAFBNJGBB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	NativeBitArray MGDIDAGNBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	NativeBitArray PKAIIONEFOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	NativeArray<int> GFKLOKNPCBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	LNKAFBNJGBB OMCGAJCFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	LNKAFBNJGBB OMCGAJCFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LNKAFBNJGBB BFBOKNPLOEF(NEIMDFCACOK BGJCPPOHOEL);

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GJDOIBPJHGJ PKANHBMBBLO(NEIMDFCACOK BGJCPPOHOEL);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public static class IMOGJCBDKBL
{
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[DefaultMember("Item")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface OJIIMIJEJCC : IEnumerable<OHCDDLDJCLN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	OHCDDLDJCLN OMCGAJCFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OHCDDLDJCLN BFBOKNPLOEF(NEIMDFCACOK BGJCPPOHOEL);

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GJDOIBPJHGJ PKANHBMBBLO(NEIMDFCACOK BGJCPPOHOEL);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class OOEGFLHMPOE
{
	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x2D648C0", Offset = "0x2D638C0", VA = "0x182D648C0")]
	public static GJDOIBPJHGJ PKANHBMBBLO<T>(this OJIIMIJEJCC BGCNJECCDBE, NAOOJFEJGBJ<T> CKEJJGPNKGO) where T : struct
	{
		return default(GJDOIBPJHGJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
[DefaultMember("Item")]
public interface COFBJEFDEDD : IEnumerable<NAFJPIJGFIL>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	NAFJPIJGFIL OMCGAJCFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NAFJPIJGFIL BFBOKNPLOEF(NEIMDFCACOK BGJCPPOHOEL);

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GJDOIBPJHGJ PKANHBMBBLO(NEIMDFCACOK BGJCPPOHOEL);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class PIAODNDKHNH
{
	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x2D7AA70", Offset = "0x2D79A70", VA = "0x182D7AA70")]
	public static JJGNFGMBJGI<T> BFBOKNPLOEF<T>(this COFBJEFDEDD BGCNJECCDBE, NEIMDFCACOK CKEJJGPNKGO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x2D7ABB0", Offset = "0x2D79BB0", VA = "0x182D7ABB0")]
	public static GJDOIBPJHGJ PKANHBMBBLO<T>(this COFBJEFDEDD BGCNJECCDBE, NAOOJFEJGBJ<T> CKEJJGPNKGO) where T : struct
	{
		return default(GJDOIBPJHGJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface LJKMDAEMGNP
{
	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGLLICMBJNI(NEIMDFCACOK HNKKKCPLLDH, NILFDJLCPPH JOHKGNANMPE);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CNEBNJPACBD(NEIMDFCACOK HNKKKCPLLDH, NILFDJLCPPH JOHKGNANMPE);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public static class GBNGBHELNGH
{
	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6F90", Offset = "0x2BB5F90", VA = "0x182BB6F90")]
	public static void GGLLICMBJNI<T>(this LJKMDAEMGNP CALGOHDDHOG, NAOOJFEJGBJ<T> HNKKKCPLLDH, NILFDJLCPPH JOHKGNANMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6C00", Offset = "0x2BB5C00", VA = "0x182BB6C00")]
	public static void CNEBNJPACBD<T>(this LJKMDAEMGNP CALGOHDDHOG, NAOOJFEJGBJ<T> HNKKKCPLLDH, NILFDJLCPPH JOHKGNANMPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface JDNOLOGMMJL
{
	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	CNJEPMNIKFL MCENIHGNLJK
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KHLIDCLKJEJ(FDJBMECGDOM FGMNEAGEGFD, GJDOIBPJHGJ HNKKKCPLLDH);

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HOBDIMLICGH(FDJBMECGDOM FGMNEAGEGFD, Span<GJDOIBPJHGJ> BGCNJECCDBE, bool CPPDANHADND);

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GPGAIDMAKNH(NativeArray<FDJBMECGDOM> HOBPFEIBGHF);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public static class BCFBGAMDCKI
{
	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x6A72C00", Offset = "0x6A71C00", VA = "0x186A72C00")]
	public static void HOBDIMLICGH(this JDNOLOGMMJL KKNPPLKOIED, FDJBMECGDOM FGMNEAGEGFD, GJDOIBPJHGJ HNKKKCPLLDH, bool CPPDANHADND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public readonly struct CNJEPMNIKFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly NativeBitArray NNEIBGLAFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly NativeParallelHashMap<FDJBMECGDOM, int> JAJBEIKPJDC;

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public bool MALNNBLLMNH
	{
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x6A74BD0", Offset = "0x6A73BD0", VA = "0x186A74BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x42B1DE0", Offset = "0x42B0DE0", VA = "0x1842B1DE0")]
	public CNJEPMNIKFL(NativeBitArray NNEIBGLAFMB, NativeParallelHashMap<FDJBMECGDOM, int> JAJBEIKPJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x6A74AA0", Offset = "0x6A73AA0", VA = "0x186A74AA0")]
	public bool KHLIDCLKJEJ(FDJBMECGDOM FGMNEAGEGFD, GJDOIBPJHGJ HNKKKCPLLDH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface KCMGAICEJJH
{
	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LHPELJDAMJM(CGNEFKCKCBE BAAPAEECMJF, CCGKOGPBOEK JJCEIJMGOAB);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface IJJGKGPECFJ
{
	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	IEOFDADILNN GOEKOIPKAOB
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface HKOGBLBEJOO
{
	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKCMLKLINFP(World EJDHINIBNLN);

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBNJGABKEPK(World EJDHINIBNLN);

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase DOELCHIJMDC(World EJDHINIBNLN);

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MNPHHMBDOKF(World EJDHINIBNLN);

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HLDIGGPGAAC(World EJDHINIBNLN);

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LGNCEFLDHCE(World EJDHINIBNLN);

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JGKHOIGIEAD(World EJDHINIBNLN);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[CCHFMGLFBCK(ICPIBLGDMFM.LoadInstance)]
public interface BCLJKBJGCDM
{
	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KFBJOBDKEMP(CGNEFKCKCBE BEHCCOMHFAP, bool JJCEIJMGOAB);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public readonly struct GHHDLGHBKEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly IEnumerable<KLPLGJPOFHA> BLJNPDNFNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly IReadOnlyList<GameObject> NADDJOJHJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IReadOnlyList<int> CJLLAPLKFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly IReadOnlyList<(FDJBMECGDOM, FDJBMECGDOM)> EDMDIJAPLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly int EOOPPGOIIMP;

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public bool KJINILEJGLO
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x6A7A2B0", Offset = "0x6A792B0", VA = "0x186A7A2B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public int JKCIIIHCGKE
	{
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x9ABFE0", Offset = "0x9AAFE0", VA = "0x1809ABFE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public IEnumerable<GameObject> PAJEPPIHOGP
	{
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x99F860", Offset = "0x99E860", VA = "0x18099F860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public IEnumerable<(FDJBMECGDOM src, FDJBMECGDOM dst)> NMGLHGKDGHK
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A6A0", Offset = "0x6A796A0", VA = "0x186A7A6A0")]
	public GHHDLGHBKEL(IEnumerable<KLPLGJPOFHA> BLJNPDNFNLG, IReadOnlyList<GameObject> NADDJOJHJNM, IReadOnlyList<int> CJLLAPLKFAL, IReadOnlyList<(FDJBMECGDOM src, FDJBMECGDOM dst)> EDMDIJAPLAN, int EOOPPGOIIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A310", Offset = "0x6A79310", VA = "0x186A7A310")]
	public (GameObject, int)[] PGCBOKECFLB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface IFHHFOJEJFD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	bool OMGNEIGNEMA
	{
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	bool AJBKIKNMPOO
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	BLICPJPHDOH NMCCMGFLFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HPMOHLAIEBP LEDBALDBHCP();

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HPMOHLAIEBP FCLFAIACLHD(IEnumerable<CGNEFKCKCBE> HDBEGMKJNAF, [In] UniformTRS JFKKCKLEAEP);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JJJBCBJLHCM OAPDJBGIMFI(ByteString BHHHIINEPHI);

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PPGMEFFEAJK HNPIGODDFGN(ByteString ADBDMGOLEGN, CGNEFKCKCBE EMOKCJBMKOL, [In] UniformTRS CLBCJCHDJLK, LOLCOOKGLMM FIIICKHELNP, bool KDMNABFPADL = true);

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LNEBKCDABJA();

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GHHDLGHBKEL IFJDHLJDDCJ(IEnumerable<KLPLGJPOFHA> BLJNPDNFNLG);
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class DEBHEKCJCGC
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface ACDEMJGOLIC
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action NJGNDAANLIF;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action MJFKPMAIKPI;
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public struct LLDAEMAABEO : POOPKFIJOGK, IEquatable<LLDAEMAABEO>
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public static readonly int LGJLKHDEEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NCCOBPNELMJ LFOOJAPBKNN;

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x6A7FAA0", Offset = "0x6A7EAA0", VA = "0x186A7FAA0", Slot = "5")]
	public void PPFECFLIGJE(NJPDGOJOJOD JBMHGCNDNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x6A7FA70", Offset = "0x6A7EA70", VA = "0x186A7FA70", Slot = "4")]
	public void JMNIMAIKKED(OEHIJPBKINF KOHNEKCBPBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x6A7FAD0", Offset = "0x6A7EAD0", VA = "0x186A7FAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0xAE2210", Offset = "0xAE1210", VA = "0x180AE2210", Slot = "6")]
	public bool Equals(LLDAEMAABEO ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F9D0", Offset = "0x6A7E9D0", VA = "0x186A7F9D0", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0xB57280", Offset = "0xB56280", VA = "0x180B57280", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public struct KLPLGJPOFHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Guid CNIMPJMOLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public string EDIGKGDEKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Vector3 LLLHNMGEKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Quaternion BCKIPOGEHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Vector3 FHBDGLOPEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int EFDALPOEBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public Dictionary<string, object> OEFIADEKGGF;

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E520", Offset = "0x6A7D520", VA = "0x186A7E520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E390", Offset = "0x6A7D390", VA = "0x186A7E390")]
	private static string BHKGEHBCENM(Dictionary<string, object> DMJJLFJCIPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public enum POALLELAHHN
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
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public static class MIBGOKKEMPO
{
	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E7CB80", Offset = "0x5E7BB80", VA = "0x185E7CB80")]
	public static bool ONMIGJHCBAO(this POALLELAHHN HNGLFCFOHLI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[Flags]
public enum HBMHFGLGFKK
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
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public interface PPGMEFFEAJK : BLICPJPHDOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	LOLCOOKGLMM AAECFLLBNEP
	{
		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PCBFBKDIPKL();

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KMEHBAFEADI();
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface BLICPJPHDOH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	IEnumerable<KLPLGJPOFHA> MOOMCIFALGH
	{
		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	GHHDLGHBKEL JBPJKMINAFI
	{
		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	POALLELAHHN PNINAMLCHFD
	{
		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	LocalId HPCKFFLDIOP
	{
		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	GNLLFGJBHME HEMGAJLCIPE
	{
		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ODIGKBLPPJN(HBMHFGLGFKK EEMINKGCKIO);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public interface LOLCOOKGLMM
{
	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HNKGPJONLNG(Guid ABGFGEMBNMN, [Out] Guid FLACBNGODHF);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public interface JJJBCBJLHCM : BLICPJPHDOH, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[Flags]
public enum NNPCDGOOEDH
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
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public interface HPMOHLAIEBP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	GNLLFGJBHME CMDDDHCOBIC
	{
		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString NGILLDAAANI();
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public enum JMPFDBNEPHN
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public delegate bool CPOLJKLONEA(BJIDCPBKPGG FAJBLECGADA, [In] ADBKJBNECHF JJCEIJMGOAB);
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public delegate bool BMELEFPJCJF<T>(BJIDCPBKPGG FAJBLECGADA, [In] T JJCEIJMGOAB);
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface KBBJLNIGHMM
{
	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGLLICMBJNI(GJDOIBPJHGJ ILCJHJBBALD, Type AJPMKNHFJGF, CPOLJKLONEA NOLDNMKKIGM);

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IIHAKOOLDNG(GJDOIBPJHGJ ILCJHJBBALD, [Out] CPOLJKLONEA NOLDNMKKIGM);
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public static class AJPFPBDHLGD
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class OAJENKHEDJN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public BMELEFPJCJF<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public OAJENKHEDJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x46D5B30", Offset = "0x46D4B30", VA = "0x1846D5B30")]
		internal bool CMDLFLNFNKA(BJIDCPBKPGG pendingList, [In] ADBKJBNECHF value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x326BA60", Offset = "0x326AA60", VA = "0x18326BA60")]
	public static void GGLLICMBJNI<T>(this KBBJLNIGHMM CALGOHDDHOG, GJDOIBPJHGJ ILCJHJBBALD, BMELEFPJCJF<T> NOLDNMKKIGM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x6A72780", Offset = "0x6A71780", VA = "0x186A72780")]
	public static bool BHHFBMAEIBH(this KBBJLNIGHMM CALGOHDDHOG, BJIDCPBKPGG FAJBLECGADA, GJDOIBPJHGJ ILCJHJBBALD, [In] ADBKJBNECHF JJCEIJMGOAB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface NDIMHCCDEPL
{
	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	uint IMGGMGNPKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface BJIDCPBKPGG
{
	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NIHCHPDOPLF(FDJBMECGDOM FMBKOKBFBCA, GJDOIBPJHGJ ILCJHJBBALD, ReadOnlySpan<byte> LKJHNFGMLID, ReadOnlySpan<byte> EHKBBFIEIGB);

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LMBOGOAEGFJ(FDJBMECGDOM FMBKOKBFBCA, GJDOIBPJHGJ ILCJHJBBALD, ReadOnlySpan<byte> LKJHNFGMLID, ReadOnlySpan<byte> EHKBBFIEIGB);

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NHKLEKNMAPH(FDJBMECGDOM FMBKOKBFBCA, GJDOIBPJHGJ ILCJHJBBALD);

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JILCLINPIGC(FDJBMECGDOM FMBKOKBFBCA, GJDOIBPJHGJ ILCJHJBBALD, ReadOnlySpan<byte> EHKBBFIEIGB);

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CKODHBMMALC(FDJBMECGDOM FMBKOKBFBCA, GJDOIBPJHGJ ILCJHJBBALD, Span<byte> LKJHNFGMLID, Span<byte> EHKBBFIEIGB);
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public static class ACKAGOJNJCA
{
	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x3262760", Offset = "0x3261760", VA = "0x183262760")]
	public static bool CKODHBMMALC<T>(this BJIDCPBKPGG BOELGMMFFAF, FDJBMECGDOM FMBKOKBFBCA, GJDOIBPJHGJ ILCJHJBBALD, [Out] T LKJHNFGMLID, [Out] T EHKBBFIEIGB) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x3262950", Offset = "0x3261950", VA = "0x183262950")]
	public static bool JILCLINPIGC<T>(this BJIDCPBKPGG BOELGMMFFAF, FDJBMECGDOM FMBKOKBFBCA, GJDOIBPJHGJ ILCJHJBBALD, T EHKBBFIEIGB) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public enum PBNDPAMEPBD
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
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface NHNAJCPFFPG
{
	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JDDAGJIPJHN(KAFNAAJJINP IEJOAHLDAPK, ReadOnlySpan<byte> KLINFCCHIED);

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCGBJCANPBB(uint EOGGDDCOADP, ReadOnlySpan<byte> KLINFCCHIED);

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HDCKJDJBLMP(int PFKCDJAIJBH);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface KLICNPCAOFF
{
	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KAFNAAJJINP INDFEOOMNHF(ReadOnlySpan<byte> KLINFCCHIED);
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface JICJDIOKCOO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ODBIEFHBNNE(KAFNAAJJINP GMFCIHEFPPO, ReadOnlySpan<byte> KLINFCCHIED);

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PLCKGEOAAJM(ReadOnlySpan<KAFNAAJJINP> CDKOJPCNKHH);
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public struct MNHFEDHOBHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public KAFNAAJJINP IEJOAHLDAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public ReadOnlyMemory<byte> KLINFCCHIED;
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public struct KAFNAAJJINP
{
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static KAFNAAJJINP JNOJBCIAKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public uint AOJMKBHJMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public int AAKJMKGAEIE;

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0xD41330", Offset = "0xD40330", VA = "0x180D41330")]
	public KAFNAAJJINP(uint AOJMKBHJMCG, int AAKJMKGAEIE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C960", Offset = "0x6A7B960", VA = "0x186A7C960")]
	public static bool MKBCGNPIJEJ([In] KAFNAAJJINP PNODNPKGJKB, [In] KAFNAAJJINP JHNJJGDAEGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C870", Offset = "0x6A7B870", VA = "0x186A7C870", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C920", Offset = "0x6A7B920", VA = "0x186A7C920", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C980", Offset = "0x6A7B980", VA = "0x186A7C980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C950", Offset = "0x6A7B950", VA = "0x186A7C950")]
	public void JNNCHEFJEMI([Out] uint AOJMKBHJMCG, [Out] int AAKJMKGAEIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface LCOEOJFEGJM : AFIBGLPJDHB<LCOEOJFEGJM>
{
	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KBNDOKPPALD(GJDOIBPJHGJ KHLDDJPHOBA, [Out] KHDKGNJENNE MOEKDCMNAHP);
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public static class IOGHIKPLKAN
{
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public interface KHDKGNJENNE
{
	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	Type JLMNGAFOBAA
	{
		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PPFECFLIGJE(NJPDGOJOJOD JBMHGCNDNMN, Span<byte> KAEDHDLBKFF);

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JMNIMAIKKED(OEHIJPBKINF KOHNEKCBPBH, ReadOnlySpan<byte> IEJOAHLDAPK);
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class PINJLKHBPIH
{
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct HBNOIKLAECM : ISystemStateComponentData, IComponentData, IEquatable<HBNOIKLAECM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float3 BLCGBEGIGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public float3 CNMIKDMCINH;

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x6A7AA00", Offset = "0x6A79A00", VA = "0x186A7AA00", Slot = "4")]
	public bool Equals(HBNOIKLAECM ACBLPNJDJBF)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public class HCDGHKBPKAH
{
	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public HCDGHKBPKAH()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
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
