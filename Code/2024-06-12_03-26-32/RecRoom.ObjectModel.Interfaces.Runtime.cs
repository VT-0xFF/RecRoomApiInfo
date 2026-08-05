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
	public class LogRegistrationIndex : BOJNKDJNMOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x69D86A0", Offset = "0x69D72A0", VA = "0x1869D86A0", Slot = "4")]
		public override void FHCDBNBHAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HOCPBCPNLKH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69D6C30", Offset = "0x69D5830", VA = "0x1869D6C30")]
	public static void OMFBFLHDAIA(this Rigidbody ODGAOFGKFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69D6DC0", Offset = "0x69D59C0", VA = "0x1869D6DC0")]
	public static void OMFBFLHDAIA(this Rigidbody ODGAOFGKFFH, Vector3 KMAGKNDPBIK, Quaternion JBNGPHNPCMH, Vector3 HABOPIIKMDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct HDPBPBEDBGP : IReadOnlyList<PHLHMBGDJPB>, IEnumerable<PHLHMBGDJPB>, IEnumerable, IReadOnlyCollection<PHLHMBGDJPB>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct FIOAKJBMLOE : IEnumerator<PHLHMBGDJPB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly AGDKOLPOPCA KAMJHGKBFDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator CACLGIIFKFJ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PHLHMBGDJPB KDHPDJIABMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x69D54B0", Offset = "0x69D40B0", VA = "0x1869D54B0", Slot = "4")]
			get
			{
				return default(PHLHMBGDJPB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x69D5430", Offset = "0x69D4030", VA = "0x1869D5430", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x41E29C0", Offset = "0x41E15C0", VA = "0x1841E29C0")]
		public FIOAKJBMLOE(AGDKOLPOPCA KAMJHGKBFDK, NativeArray<LocalId>.Enumerator CACLGIIFKFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x69D5370", Offset = "0x69D3F70", VA = "0x1869D5370", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x69D53B0", Offset = "0x69D3FB0", VA = "0x1869D53B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x69D53F0", Offset = "0x69D3FF0", VA = "0x1869D53F0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly AGDKOLPOPCA KAMJHGKBFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> OCMEKIBCJIK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public PHLHMBGDJPB ENBJMEPMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69D65D0", Offset = "0x69D51D0", VA = "0x1869D65D0", Slot = "4")]
		get
		{
			return default(PHLHMBGDJPB);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x69D5FE0", Offset = "0x69D4BE0", VA = "0x1869D5FE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int NJDGPKANIMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8431A0", Offset = "0x841DA0", VA = "0x1808431A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public AGDKOLPOPCA LNADJLMCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int CJOHGCFPKAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8431A0", Offset = "0x841DA0", VA = "0x1808431A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CAKMGDHDFAF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69D6160", Offset = "0x69D4D60", VA = "0x1869D6160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> HMFMEIGOMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x251A0F0", Offset = "0x2518CF0", VA = "0x18251A0F0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> JMADFMNFDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x69D6070", Offset = "0x69D4C70", VA = "0x1869D6070")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69D6540", Offset = "0x69D5140", VA = "0x1869D6540")]
	public HDPBPBEDBGP(int ECCOECALPKO, AGDKOLPOPCA KAMJHGKBFDK, Allocator BLMBIIGOJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x41E2AE0", Offset = "0x41E16E0", VA = "0x1841E2AE0")]
	public HDPBPBEDBGP(AGDKOLPOPCA KAMJHGKBFDK, NativeArray<LocalId> OCMEKIBCJIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69D6430", Offset = "0x69D5030", VA = "0x1869D6430")]
	internal HDPBPBEDBGP(AGDKOLPOPCA KAMJHGKBFDK, NativeArray<Entity> NBNHBNDLFMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69D64A0", Offset = "0x69D50A0", VA = "0x1869D64A0")]
	public HDPBPBEDBGP(AGDKOLPOPCA KAMJHGKBFDK, int JKBHNDINMGD, Allocator BLMBIIGOJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69D6380", Offset = "0x69D4F80", VA = "0x1869D6380")]
	public HDPBPBEDBGP(HDPBPBEDBGP ONJOFIBKPFI, Allocator BLMBIIGOJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69D5F30", Offset = "0x69D4B30", VA = "0x1869D5F30")]
	public HDPBPBEDBGP AIIIFAEPLFO(Allocator BLMBIIGOJPG = Allocator.Temp)
	{
		return default(HDPBPBEDBGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69D6030", Offset = "0x69D4C30", VA = "0x1869D6030", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69D60D0", Offset = "0x69D4CD0", VA = "0x1869D60D0")]
	public FIOAKJBMLOE NDANHGBCNEI()
	{
		return default(FIOAKJBMLOE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69D61A0", Offset = "0x69D4DA0", VA = "0x1869D61A0", Slot = "6")]
	private IEnumerator<PHLHMBGDJPB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69D6290", Offset = "0x69D4E90", VA = "0x1869D6290", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public struct CODGPKCCPEF : IList<PHLHMBGDJPB>, ICollection<PHLHMBGDJPB>, IEnumerable<PHLHMBGDJPB>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct INGHENPAMJA : IEnumerator<PHLHMBGDJPB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly AGDKOLPOPCA KAMJHGKBFDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator CACLGIIFKFJ;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public PHLHMBGDJPB KDHPDJIABMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x69D7110", Offset = "0x69D5D10", VA = "0x1869D7110", Slot = "4")]
			get
			{
				return default(PHLHMBGDJPB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x69D7090", Offset = "0x69D5C90", VA = "0x1869D7090", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x41E29C0", Offset = "0x41E15C0", VA = "0x1841E29C0")]
		public INGHENPAMJA(AGDKOLPOPCA KAMJHGKBFDK, NativeArray<LocalId>.Enumerator CACLGIIFKFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x69D6FD0", Offset = "0x69D5BD0", VA = "0x1869D6FD0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x69D7010", Offset = "0x69D5C10", VA = "0x1869D7010", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x69D7050", Offset = "0x69D5C50", VA = "0x1869D7050", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly AGDKOLPOPCA KAMJHGKBFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> OCMEKIBCJIK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PHLHMBGDJPB ENBJMEPMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x69D1060", Offset = "0x69CFC60", VA = "0x1869D1060", Slot = "4")]
		get
		{
			return default(PHLHMBGDJPB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x69D10E0", Offset = "0x69CFCE0", VA = "0x1869D10E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x69D0B80", Offset = "0x69CF780", VA = "0x1869D0B80", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int CJOHGCFPKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x69D0B80", Offset = "0x69CF780", VA = "0x1869D0B80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool LJENBABOAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69D0FD0", Offset = "0x69CFBD0", VA = "0x1869D0FD0")]
	public CODGPKCCPEF(int ECCOECALPKO, AGDKOLPOPCA KAMJHGKBFDK, Allocator BLMBIIGOJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x69D0EC0", Offset = "0x69CFAC0", VA = "0x1869D0EC0")]
	public CODGPKCCPEF(AGDKOLPOPCA KAMJHGKBFDK, Allocator BLMBIIGOJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x69D0F40", Offset = "0x69CFB40", VA = "0x1869D0F40")]
	public CODGPKCCPEF(AGDKOLPOPCA KAMJHGKBFDK, int JKBHNDINMGD, Allocator BLMBIIGOJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69D0930", Offset = "0x69CF530", VA = "0x1869D0930")]
	public HDPBPBEDBGP EFLGNHAFOCB()
	{
		return default(HDPBPBEDBGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x69D06D0", Offset = "0x69CF2D0", VA = "0x1869D06D0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x69D0710", Offset = "0x69CF310", VA = "0x1869D0710", Slot = "13")]
	public bool Contains(PHLHMBGDJPB LBACBPHHKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x69D07A0", Offset = "0x69CF3A0", VA = "0x1869D07A0", Slot = "14")]
	public void CopyTo(PHLHMBGDJPB[] CHPEIOMPEEH, int JNGLDMDNOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x69D0650", Offset = "0x69CF250", VA = "0x1869D0650", Slot = "11")]
	public void Add(PHLHMBGDJPB LBACBPHHKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x69D0A40", Offset = "0x69CF640", VA = "0x1869D0A40", Slot = "7")]
	public void Insert(int OPDMGNJCACB, PHLHMBGDJPB LBACBPHHKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x69D0C10", Offset = "0x69CF810", VA = "0x1869D0C10", Slot = "15")]
	public bool Remove(PHLHMBGDJPB LBACBPHHKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x69D09B0", Offset = "0x69CF5B0", VA = "0x1869D09B0", Slot = "6")]
	public int IndexOf(PHLHMBGDJPB LBACBPHHKAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x69D0BC0", Offset = "0x69CF7C0", VA = "0x1869D0BC0", Slot = "8")]
	public void RemoveAt(int OPDMGNJCACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x69D08F0", Offset = "0x69CF4F0", VA = "0x1869D08F0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x69D0AF0", Offset = "0x69CF6F0", VA = "0x1869D0AF0")]
	public INGHENPAMJA NDANHGBCNEI()
	{
		return default(INGHENPAMJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x69D0CE0", Offset = "0x69CF8E0", VA = "0x1869D0CE0", Slot = "16")]
	private IEnumerator<PHLHMBGDJPB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x69D0DD0", Offset = "0x69CF9D0", VA = "0x1869D0DD0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DHBPKAPHOAB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int NOBOAGIJGAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> OGAAPKKFIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PHLHMBGDJPB EKBJAALHEGN(PHLHMBGDJPB OCMEKIBCJIK);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AOICLNFHDBI : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface EHMGCPAIAJE : OEMILCIFPFN, GDNNDJMCIJI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool INNHKJOMFBL
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	CCBGJDFEGLG OOOAMCDONDC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	KODNPDHHIGL FIGBCCIHGGN
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	LAADALIJNDM MOEMEJHHHHD
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	DIIGHFDBNIN BKFDBPBMPNM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface GDNNDJMCIJI
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool CIGKNHKCONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface OGMMIFABIGN
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBNCKAIKCAJ(bool GLMEMJNJKAN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[PDLAMBIDAOD(DJPDPGDGFEF.PhotonRoom)]
public interface LMFIBJHOADL
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool OMNMJLCJHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MIFLNAOOHMB(bool MPKDEMAOPIG);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LELNBNPJMJO();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IOFECDFPBGD(ByteString EJGADLCOEON);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ILBDKOGIJCB();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PFMIJEJAJII();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LGHGLNBIPDD();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EDJDBEMGLCN();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IMLPOFDMOIN();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface LAADALIJNDM
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	OIDPNHHGIAF OOOAMCDONDC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	KODNPDHHIGL FIGBCCIHGGN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	PEEMGFPFANC OENFPIGDKMC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	PHPFCEGINBO FJODJKMAOHP
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	EHMGCPAIAJE NKHPIAMCPNI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	LMFIBJHOADL OMIHAIGEJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	AGDKOLPOPCA LNADJLMCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	PKFMNIKNNCC MJOGDCELAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	PEGAAPFIEAN KMCHLIOEEFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	BLBCFKIIMDN GHOKMCNLJKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	GFIFOMICEJK DCAFAILNEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	GIKIIGOKLLC BCFEMLHMCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	LHOAMCKABGN FPFCCFHEIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	BEHODOPNIEL KAEPGPNFIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	IHKDKLHNPMB GLANMJNBDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	DAELOLGDFHA AHEGGHGOMMP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	LDBFHNNICCO AGEKHMHABOP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	BIJLCBNDPDM ODCFJIKNEPC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	GMFOIJLKJDI IAHJFDEKHJG
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	BGPNIJCCIDK FAKADIBHBOH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	LBEDGKMPEAF BLIIOJGEDNF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	KFEPGCIEIDC PEMBMDNOOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	OADJDJJMHKE GBFFGFHAGDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	AFHDMKPDBEH PMLKBCLDOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	DBIOJFOONBD IGCGLKHFDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	IFPAINJGJMB IPBBEDIDPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	KJMNLHCMMLG GMDLMPPLMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	MCNBHCFGCFL HDHBDFEEGJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	HPADFHGNAHD JIOBKGCKAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(OOLICGHJEMB))]
public readonly struct PHLHMBGDJPB : IComparable<PHLHMBGDJPB>, IEquatable<PHLHMBGDJPB>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly PHLHMBGDJPB GFAAJGGODEO;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int HOIIAJNIFNO = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int BIJFBBJNGDA = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int KICKMPILPME = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int FOEEOMMDPGB = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId FFODPEFFKPK;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public AGDKOLPOPCA LNADJLMCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69C9390", Offset = "0x69C7F90", VA = "0x1869C9390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public EHMGCPAIAJE NKHPIAMCPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69DB0B0", Offset = "0x69D9CB0", VA = "0x1869DB0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public LocalId OJKBJEDEOJP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x69DB110", Offset = "0x69D9D10", VA = "0x1869DB110")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal DIIGHFDBNIN BKFDBPBMPNM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x69DB050", Offset = "0x69D9C50", VA = "0x1869DB050")]
		get
		{
			return default(DIIGHFDBNIN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool OKKJPEEAMCN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x69DB3D0", Offset = "0x69D9FD0", VA = "0x1869DB3D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool JFLOKFDKCAI
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x69DB060", Offset = "0x69D9C60", VA = "0x1869DB060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x69DB7E0", Offset = "0x69DA3E0", VA = "0x1869DB7E0")]
	public PHLHMBGDJPB(AGDKOLPOPCA JJDHIGGIALO, LocalId FFODPEFFKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
	public BBGFBJMHCKM FIPDAHBONCL()
	{
		return default(BBGFBJMHCKM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x69DB670", Offset = "0x69DA270", VA = "0x1869DB670")]
	public static LocalId NBHHLKKAPBL(PHLHMBGDJPB CAMJBPNNEBO)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69DB630", Offset = "0x69DA230", VA = "0x1869DB630")]
	public static Entity NBHHLKKAPBL(PHLHMBGDJPB CAMJBPNNEBO)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x69DB510", Offset = "0x69DA110", VA = "0x1869DB510")]
	public static bool NBAHCGFACIA(PHLHMBGDJPB NABHBOMGBNH, PHLHMBGDJPB EIKHFLMLKJH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x69C9A20", Offset = "0x69C8620", VA = "0x1869C9A20")]
	public static bool OONFJEHFBJE(PHLHMBGDJPB NABHBOMGBNH, PHLHMBGDJPB EIKHFLMLKJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x69DB6B0", Offset = "0x69DA2B0", VA = "0x1869DB6B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x69DB230", Offset = "0x69D9E30", VA = "0x1869DB230", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x69DB150", Offset = "0x69D9D50", VA = "0x1869DB150", Slot = "4")]
	public int CompareTo(PHLHMBGDJPB OCNJFCPHJLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "5")]
	public bool Equals(PHLHMBGDJPB OCNJFCPHJLD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GJKEKONPEBF
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x69D5AF0", Offset = "0x69D46F0", VA = "0x1869D5AF0")]
	public static DDPLMDBOHKM ALFEKABCLFN(this PHLHMBGDJPB HAHECKLGOJC)
	{
		return default(DDPLMDBOHKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x69D5BA0", Offset = "0x69D47A0", VA = "0x1869D5BA0")]
	public static BBGFBJMHCKM CALPDMBLOON(this PHLHMBGDJPB HAHECKLGOJC)
	{
		return default(BBGFBJMHCKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2B12420", Offset = "0x2B11020", VA = "0x182B12420")]
	public static T AJAJOLNKCHO<T>(this PHLHMBGDJPB HAHECKLGOJC) where T : struct, IPGDFDBELNL
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class OOLICGHJEMB
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct DIIGHFDBNIN : IEquatable<DIIGHFDBNIN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte POAHFHMMEAF;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] DACJNHAOMKL;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static AGDKOLPOPCA CODGPDKIIAG;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static EHMGCPAIAJE LFLMJEICJIL;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static AGDKOLPOPCA[] GNALAFOBLDF;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static EHMGCPAIAJE[] MKPPLADAFEI;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> NEIFKGBAELD;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public EHMGCPAIAJE NKHPIAMCPNI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x69D1520", Offset = "0x69D0120", VA = "0x1869D1520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public AGDKOLPOPCA GJCBMHOKIDB
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x69D1FD0", Offset = "0x69D0BD0", VA = "0x1869D1FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x69D22E0", Offset = "0x69D0EE0", VA = "0x1869D22E0")]
	static DIIGHFDBNIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xE21B70", Offset = "0xE20770", VA = "0x180E21B70")]
	internal DIIGHFDBNIN(byte GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5B7D6E0", Offset = "0x5B7C2E0", VA = "0x185B7D6E0", Slot = "4")]
	public bool Equals(DIIGHFDBNIN OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x69D18C0", Offset = "0x69D04C0", VA = "0x1869D18C0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D4EB50", Offset = "0x1D4D750", VA = "0x181D4EB50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x69D2220", Offset = "0x69D0E20", VA = "0x1869D2220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x69D1810", Offset = "0x69D0410", VA = "0x1869D1810")]
	private static AGDKOLPOPCA CPODOKLMOOP(byte POAHFHMMEAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x69D13E0", Offset = "0x69CFFE0", VA = "0x1869D13E0")]
	private static EHMGCPAIAJE BAKFBAADOBJ(byte POAHFHMMEAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x69D20B0", Offset = "0x69D0CB0", VA = "0x1869D20B0")]
	private static object OGMMJKMNOMJ(byte POAHFHMMEAF, object[] DJGHJNNEKKN, object NJMAFDCOBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x69D1C30", Offset = "0x69D0830", VA = "0x1869D1C30")]
	private static int LMCECPBEMHL(byte POAHFHMMEAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x69D1C20", Offset = "0x69D0820", VA = "0x1869D1C20")]
	private static int IFGFAFPIDAP(byte POAHFHMMEAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x69D1490", Offset = "0x69D0090", VA = "0x1869D1490")]
	private static (int, int) BIGCDONGBBB(byte POAHFHMMEAF)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x69D1510", Offset = "0x69D0110", VA = "0x1869D1510")]
	private static byte BJOKJCLCAEI(int IDPOJNOELJM, int OPDMGNJCACB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x69D1960", Offset = "0x69D0560", VA = "0x1869D1960")]
	internal static DIIGHFDBNIN FHCDBNBHAOK(EHMGCPAIAJE CEPMCBDOCEC, AGDKOLPOPCA MPLBKIPCCME)
	{
		return default(DIIGHFDBNIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x69D1600", Offset = "0x69D0200", VA = "0x1869D1600")]
	internal static void CHBCOEBOKCE(DIIGHFDBNIN POAHFHMMEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x69D1C40", Offset = "0x69D0840", VA = "0x1869D1C40")]
	private static void NJLJBDPNNPI(int ECCOECALPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface MDBDDBBOCEG
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFJODPDDAHI();

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KNIPDCGNNFD(bool KKGPLLPHAHM);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LBEJJOOAICJ(GameObject OLFFLDPKCIP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface KBECGLKHAJL
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Guid IALLMEAFGOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GGAMDHCICEM(Guid BBGNPFGLKIG, Guid LKBGECPHNGO);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Guid LMNDNLBADNO(Guid KJPMBCBOCOO);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task JEIGNILPOLA(PHLHMBGDJPB FMCAGNNIPGN);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GIPDFPHNCJL(PHLHMBGDJPB EJMCPAEEGJH, PHLHMBGDJPB GPMGJNAOOEP, [Out] Vector3 CILJGBPKAKN, [Out] Quaternion JLMIPDKPKDA);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CJNAFBGANDC(CFPPBFCIPGE JELMPOLNHAJ, Vector3 CILJGBPKAKN, Quaternion JLMIPDKPKDA);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HBAMPJCINDA(PHLHMBGDJPB HMADBJHFPHM, [Out] Vector3 PDGJDFPHAPK, [Out] Quaternion JCFADHAHHEL);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CHIKIBBCKBI(Guid DJGLMBCCEPH, bool MPKDEMAOPIG);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface CMJJBPKNOGM
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FHECANLGHKE(HDPBPBEDBGP OCMEKIBCJIK);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface ILINCOOHHPD
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CFIGJELKLDJ(GameObject DKNFBHGKPNP, GameObject KALKNBLEODB, int BEPKAGFNBCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface KODNPDHHIGL
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	MDBDDBBOCEG GCANGMLDLOH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	IGFJPBNCKEA DMJOENNGFMB
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	FKENDAOCNFC IPFGIONPBMG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	CEGBPGBAGCH FBKBMONFIHN
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	BBHGIFIGOAP JMBKAKNIDMB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	IHKMMGANCCD NOBKHDGNDDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	JIJGBMIMOMM PPFMCAHBDFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	FHOHALCLKKE ONHICLCKHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	MMNHKIOIALO JNIIMGIMJAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface EMGOPAFDBKE
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFAJHDFMHKE(Action FIPNCHEIGMJ, bool NOIBNHIBBBL);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JLAANIEJJPL(string GFLNGGKHEOH);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int JOMJJGLIEKK(string GFLNGGKHEOH, int NJMAFDCOBGL);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JBPJOHJHIGC([Out] bool GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KNHPKLMEJDL([Out] bool GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GHHJBLLANMJ([Out] int GLMEMJNJKAN);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface IGFJPBNCKEA
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string BPNDIECKEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] PADMODNDDFD(IEnumerable<HMJEKGIMIDG> KNDHKFBIBCF);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PKCBHDKOOEB(GameObject OLFFLDPKCIP, [Out] DDPLMDBOHKM[] CNAJMFBNAGA);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NNHHKIMEHHK(GameObject OLFFLDPKCIP, [Out] int HGGHJBDCPKH, [Out] KGAFPCDNLAE BNEADFDDBLJ);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BGNCMHHLOJM GNGGDHJCPIC(HMJEKGIMIDG CLBGLGJCBEB);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BGNCMHHLOJM GNGGDHJCPIC(string NNDJGABFEBC, DDPLMDBOHKM[] PIOJFCHBCHD, Vector3 DFPHDEDIHFK, Quaternion DELGPMLKBMI, Vector3 IADPMFLONGE);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BGNCMHHLOJM KNJDKFMDAGM(string NNDJGABFEBC, DDPLMDBOHKM[] PIOJFCHBCHD, Vector3 DFPHDEDIHFK, Quaternion DELGPMLKBMI, Vector3 IADPMFLONGE);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject NDKLGDABIED(string NNDJGABFEBC);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ABKOOPIKODE(GameObject GKLECAMPKKF, bool FDMPLBLFINE);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JKEPCIGDOPL(GameObject OLFFLDPKCIP, bool PKJMDKAHPAM, bool IIHIHGNINAO);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class OFACJKINCND
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x69D9F00", Offset = "0x69D8B00", VA = "0x1869D9F00")]
	public static BGNCMHHLOJM GNGGDHJCPIC(this IGFJPBNCKEA KHAIJLCNIAO, Vector3 DFPHDEDIHFK, Quaternion DELGPMLKBMI, Vector3 IADPMFLONGE, params DDPLMDBOHKM[] CNAJMFBNAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x69DA060", Offset = "0x69D8C60", VA = "0x1869DA060")]
	public static BGNCMHHLOJM KNJDKFMDAGM(this IGFJPBNCKEA KHAIJLCNIAO, Vector3 DFPHDEDIHFK, Quaternion DELGPMLKBMI, Vector3 IADPMFLONGE, params DDPLMDBOHKM[] CNAJMFBNAGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface FKENDAOCNFC
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGPJMCOCNFB(bool MPKDEMAOPIG);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface CEGBPGBAGCH
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool FLCPACCMNDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool KLKLLOMFGIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool NAJFNJNAFGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	int IJPDEPJJHKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool HABJAIIMBOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GBKKKHOCLNE(object FAPAFOGIGGO);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BIPEAFELAHO(object FAPAFOGIGGO);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void POLDFBAMGMK(object PJIFCLGMLOL);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DKGDBEEDOJG(object PJIFCLGMLOL);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ViewId KFJDDDJDEEO(GameObject GLPOGDKHFDA);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LPHBKPHLHKD(NativeArray<ViewId> LCBEIGHPNNG);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LFMBCBPGEAB(NativeArray<ViewId> EBEPOAFHGBH);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EFDCGKFCKIJ();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ACPDPBDPLPE(uint IGNHBMOEIFD, ReadOnlySpan<byte> GHIFABPBKNK, bool FBHCHIIAELE = false);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ACPDPBDPLPE(uint IGNHBMOEIFD, ReadOnlySpan<byte> GHIFABPBKNK, ReadOnlySpan<byte> CKHABNGLFKI, bool FBHCHIIAELE = false);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CBFBIAAONBF(Func<int, bool, int> CFPONBIAJGO, bool OODAAHIDIAI);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GGGHMCEGIDC(object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CKHJKHKICMB(object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "18")]
	uint JLIOAMNMPKC(uint HLLDCJMGAKE);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class LAFKPGFEAFH
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x69D84D0", Offset = "0x69D70D0", VA = "0x1869D84D0")]
	public static IEBDPAJJKMD DAKHFOAFFDJ(this CEGBPGBAGCH DIPPLEBBBBE, object FGIAGALCIAP)
	{
		return default(IEBDPAJJKMD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct IEBDPAJJKMD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CEGBPGBAGCH DIPPLEBBBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private object FGIAGALCIAP;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x69D6F40", Offset = "0x69D5B40", VA = "0x1869D6F40")]
	public IEBDPAJJKMD(CEGBPGBAGCH DIPPLEBBBBE, object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x69D6EF0", Offset = "0x69D5AF0", VA = "0x1869D6EF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface BBHGIFIGOAP
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHGNCCEDEOA(GameObject OLFFLDPKCIP);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface IHKMMGANCCD
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct LOAMEGAJDBC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private IHKMMGANCCD APCJNJAEMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Task HPIAAAJAFJD;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Task PEBBJOKIENJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DA0", Offset = "0x8B39A0", VA = "0x1808B4DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x69D85B0", Offset = "0x69D71B0", VA = "0x1869D85B0")]
		public LOAMEGAJDBC(IHKMMGANCCD APCJNJAEMOB, CancellationToken MPLCHGMFENA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x69D8560", Offset = "0x69D7160", VA = "0x1869D8560", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKCNCNGOHGI(string JIMAFLGJGFB, float HOHIHOOEIIK = 5f);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JDOGFEIGJFD(CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OOLJEPAPLPA();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class OHFFABLIOCC
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x69DA2D0", Offset = "0x69D8ED0", VA = "0x1869DA2D0")]
	public static IHKMMGANCCD.LOAMEGAJDBC FLCIDAJKBGP(this IHKMMGANCCD DIPPLEBBBBE, CancellationToken MPLCHGMFENA)
	{
		return default(IHKMMGANCCD.LOAMEGAJDBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface IHALLLNHELC
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int CNHLNIGFMKH(GameObject OLFFLDPKCIP);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MBHIPDAPHII(GameObject OLFFLDPKCIP);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AEKLLEKBOAN(int LDNLBCKJNFL);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object LIIAEKNEDMP(PHLHMBGDJPB FFODPEFFKPK, GameObject OLFFLDPKCIP, Action<PHLHMBGDJPB, int> LHMNAJJOJLL);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EJMEACHDKLF(GameObject OLFFLDPKCIP, object IDAPFEIOBFC);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface HOPHMNPNHPL
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool MJPEMBPNCEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate JEAOFNOPMNB(AFMNCACHFPE.OAJPCFLCEDN ICNBMDMDLNO, Action<AFMNCACHFPE.OAJPCFLCEDN> LHMNAJJOJLL);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IKAHJCHPJEN(AFMNCACHFPE.OAJPCFLCEDN ICNBMDMDLNO, Delegate LHMNAJJOJLL);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate PNCBHJIHCIC(AFMNCACHFPE.OAJPCFLCEDN ICNBMDMDLNO, Action<AFMNCACHFPE.OAJPCFLCEDN> OGOGEHCODNC);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DHNINHPMIEI(AFMNCACHFPE.OAJPCFLCEDN ICNBMDMDLNO, Delegate LHMNAJJOJLL);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OOAGPJDKLHL(AFMNCACHFPE.OAJPCFLCEDN ICNBMDMDLNO);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AFMNCACHFPE.OAJPCFLCEDN LCKNNOKDOOH(GameObject OLFFLDPKCIP);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface JIJGBMIMOMM
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	int POIBCLMIMJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	int GOGBLFOAPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int BHKIIFIEIGL(GameObject OLFFLDPKCIP);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HEOKCBELLIE([Out] Vector3 DFPHDEDIHFK);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IJFPNJGLOJA();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PHLHMBGDJPB FCMGJNAIIAL(int LDNLBCKJNFL);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface FHOHALCLKKE
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool OMNMJLCJHEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface ELECAKBLNLA
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	BNFEDEHFLHM ACBCELBEKFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	KHMALMBOJKE GGGJLBEHEEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DEPMKPEABGJ(Transform KHIOEALLADK);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GDJIPJJLNJG(Transform KHIOEALLADK, PGDKMJABBAO CLMABHCHDKD);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HLLOIKFMPLK(Transform KHIOEALLADK, MHJGHFLMOAG AGFHCGHHMOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface JFOMLIAKEHA
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface MMNHKIOIALO
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action BFOLIJCCONF;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HOEKMKICJMI(HDPBPBEDBGP DBJKOOBJEFA, bool ECJEHODDMGP);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface DECEDHJBDJD
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJLHLLMLBBP();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface FJGNJFIFNPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KGAFPCDNLAE EHIMIGKPOPE(GameObject GLPOGDKHFDA);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDPPENDODIG(GameObject OLFFLDPKCIP, BCCIMNDHFAP EPCOEACPJFB, EFGMDLKHKBH JDNECLHKDLP);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CIEPNMOHJPD(PHLHMBGDJPB FFODPEFFKPK, bool FAAOJNEEKCN, float3 GAGLBHPMJPJ, quaternion AJOHMPKOIAA);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CDMBMGFDPPC(BBGFBJMHCKM ONIAHHAAJEH, BBGFBJMHCKM PJIFCLGMLOL, LECJGOBHOND OLADDMOOKPM);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KHAHGKJODJE(BBGFBJMHCKM ONIAHHAAJEH, LECJGOBHOND OLADDMOOKPM);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PINCJDPPGHL(HDPBPBEDBGP KNBOJNCEMAO);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LFLIKBEDFIE(HDPBPBEDBGP KAMJHGKBFDK, NativeArray<LocalPoseData> NHGIKHGFNIP, NativeArray<float3> PPICFJBINHP);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CCEAKDDDKFH(HDPBPBEDBGP KAMJHGKBFDK, HDPBPBEDBGP PFPCFDGMAEJ);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FCGMECBLHHK(HDPBPBEDBGP KAMJHGKBFDK, bool NOGOCMPGJNA);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MKEDPDMDNIP(HDPBPBEDBGP KAMJHGKBFDK, bool FMFNEBAIAGI);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct DFJFBCKGLKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly PJAAAOGBBEI BGCAJHMJIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly PJAAAOGBBEI JPLEPBDKKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly uint BGOICIACNGD;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x69D1170", Offset = "0x69CFD70", VA = "0x1869D1170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct MGJMHMHKKOO
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly DFJFBCKGLKO FIPNCHEIGMJ;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x69D5C50", Offset = "0x69D4850", VA = "0x1869D5C50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct GMCHLKJOMLE
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal readonly DFJFBCKGLKO FIPNCHEIGMJ;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x69D5C50", Offset = "0x69D4850", VA = "0x1869D5C50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct OOOLCEBBJDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal readonly uint BGOICIACNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal readonly bool NKMNIDHIFCD;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x69DA5E0", Offset = "0x69D91E0", VA = "0x1869DA5E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct PJAAAOGBBEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal int MANKJHLJMBO;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x69DB920", Offset = "0x69DA520", VA = "0x1869DB920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface IIKLIAIIJMH
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	MDNIBNHHECP EMEILDKFNFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public enum HLDLBDLINEB
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
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface BGNCMHHLOJM : PLICLNHIHNE
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	HLDLBDLINEB NFHGOICDIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool JLJNGCKFDAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	GameObject OLFFLDPKCIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<BGNCMHHLOJM> FHEAOJJMDJO;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(PEEMGFPFANC BKIPEHEIIHC, PHLHMBGDJPB IGGNOAIAMJB);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool LGOELJDCCCA);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class JBGFHDMOFCH
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x69D71E0", Offset = "0x69D5DE0", VA = "0x1869D71E0")]
	public static bool BJDHGOIKFMA(this BGNCMHHLOJM OHJHPCELAOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x69D7230", Offset = "0x69D5E30", VA = "0x1869D7230")]
	public static bool HBNCLGOPJJL(this BGNCMHHLOJM OHJHPCELAOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x69D7280", Offset = "0x69D5E80", VA = "0x1869D7280")]
	public static bool HGAMFELPJEA(this BGNCMHHLOJM OHJHPCELAOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x69D72D0", Offset = "0x69D5ED0", VA = "0x1869D72D0")]
	public static bool INNHKJOMFBL(this BGNCMHHLOJM OHJHPCELAOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface PLICLNHIHNE
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool OKAHPDGICCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	PHLHMBGDJPB BEHACKJMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
internal interface EKOHPPMCOJK
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<OOBHMNCCLGF> FIBKIPFLNML;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface HPELPLNLINL
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FAOCCJJJLHC(Vector3 DFPHDEDIHFK, Quaternion DELGPMLKBMI, Vector3 IADPMFLONGE);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INMMMEFJOBK(PHLHMBGDJPB GPMGJNAOOEP);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OELPCHCAMEH(bool OPDHIINODHL);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JDECHFDPPMA(bool FMFNEBAIAGI);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface CCILGPDIFOO
{
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface KHLABGHGLNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(OOHKIHMPJNC CMBHLOMIHLH);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface OOHKIHMPJNC
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	GameObject OLFFLDPKCIP
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	Transform KHIOEALLADK
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	DDAOGFDCOOH IBFJCBIDNKE
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool EICKEJPPKMB
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JJOEOCGIHFK(DDAOGFDCOOH NHLLCDFJMEP);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface DDAOGFDCOOH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000060")]
	PHLHMBGDJPB BEHACKJMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	Rigidbody KEIMENOGDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	OOHKIHMPJNC DBEPHNOIOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	GameObject KNJFPDLIBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	Transform KIMEAEOEPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	DDAOGFDCOOH MHBJGCIDGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	DDAOGFDCOOH MOHNEGNCIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	int COCCIAEPPKD
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	bool OOAGPJDKLHL
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool APMKCCEHIKI
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	DGGLCAMAKMJ LEMHLCNHAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "31")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	FJFFINOAFID CCPBGIMFGAL
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	float BKCEMCMHNFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "35")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 ALLHEBGBOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 CHLEMIIMBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 ONPFKEDCNHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 MPGJMEAJPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool BENMOBGHGPC
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool NFODCDHNEMF
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool LALIMOBDCIM
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	Vector3 EJOCFBACPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Vector3 DECBMPLODHA
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 KELEGGHFEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "50")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 FHFAIIKLIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	float JKDIHAGIKGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float JHGNOGKIPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 EHBJFKCKNDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Quaternion POMDKKODDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float IJDINGPGKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	float KDHPPPPOPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	bool BEAIDGLDKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	EHMENGICDDK AMMIBIKIAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	bool JOEIBFGJACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	Transform AGEKEPENCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Vector3 EOHOOMJOMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	float MFAPAGPDOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	float LAJFDNOAJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	Quaternion BHIAIJDAHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	Vector3 OCLAILDFLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Quaternion OJMCLJJHOHA
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	RigidbodyConstraints IOEFEOBLGDM
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	bool GEKFGNKAHFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	CollisionDetectionMode HMLOKICDEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool FLGDOCPBPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event KHPGPMAKEDG CNCOOAKKEOP;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event KHPGPMAKEDG OGGACPOBCAN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event KHPGPMAKEDG AOLHLNBDNKL;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event KHPGPMAKEDG ONFGNGCFKEI;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event KHPGPMAKEDG IFLNCOKIILG;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event KHPGPMAKEDG GJCOGAIJJAM;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event KHPGPMAKEDG JOFIODJILGG;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event LHPNJLPJABN AIIAMCJPDCG;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<PHMIKAKJJJM, PHMIKAKJJJM> CPOONJOIHHO;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "26")]
	DDAOGFDCOOH AIKBLINKLIA(int OPDMGNJCACB);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void OAIJLGJIIJM((Quaternion rot, Vector3 moments) FGLOGFKAGCE);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void BECEGOJLPJN();

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void BPJHNHCEHKH();

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void HGNFAKEJLFF();

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void IGHLBBNBECA();

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void INMMMEFJOBK(DDAOGFDCOOH GLMEMJNJKAN, bool AHOFFNDGFPE = false);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void IFECGGABOHG(object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void JOLLHBHENCJ(object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 GFCJMJHAGDM(Vector3 IBKMAAFCHJE);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "95")]
	Vector3 JDACKOKKNNG(Vector3 JNDAJMGACPK);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void ABBPAIPCJHO();

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void BJEALMDBJNC();

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void GCNFOIDKAPE();

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void NGCILIKOJJD(Vector3 MBKALLPNBAM, Vector3 OAMEOEEJNEL);

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void JLNKDNILLCM(Vector3 HLKLDKCKCEH, Vector3 HHFOOHMFEHK);

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void MGDPJEOBKAG(Vector3 LBMPLEAJHCD);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void PIJBCDAOOME(OJJDFFFIEGN NPNMFINKOEA, Vector3 ENPIBMKFHAB, float EHFKNBFHCDH, float OLKAKNJODNP = 8f, float JFBCEBFFGCN = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void ENJKBCNDMJI(JHDMGOFKGOA BCJMONNKMDM, Vector3 MMKABMNCDKC, float IFBKEEKNDLA = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void KDPDANBCNFI(JHDMGOFKGOA BCJMONNKMDM, Vector3 DELGPMLKBMI, float DENHBDKCCBI = 7f, float FHILGBPMMLD = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "105")]
	Vector3 KMKFKNHLOKH(Vector3 GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "106")]
	Vector3 HJINCKJFPJP(Vector3 GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void INOLOIMKMCF();

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void BOBKKGMMEEN(DDAOGFDCOOH NFNMFDHLBLI, object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "109")]
	void GKNKGHFBOEN(object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void LAALAMLCKCE();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void HMDNDJHJMGO();

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void OLAAAIDJIIL();

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "113")]
	bool MPBEMIDPCGA();

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void AMKCDMMGKBK();

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void FGALEIOGJOF(object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "116")]
	void BCJCJCALFOM(object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void CFDOKFMNMMN(object FGIAGALCIAP, bool KLOJNKJOLCC);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void OHKJLLPEMBE(Vector3 DFICJCFPDHF, Quaternion MFLPLOGCDIF);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void PNAKNPIEKIA(Vector3 JDMAEIMLNKI, Quaternion NCDIEHFMCNN);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "120")]
	bool GBENLCKHGAO(float EIHPNDPLKCM);

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void HICPHMAMADG(object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void LIKLOMCELCB(object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void JGEJKFLBIDJ(object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void GKHMFBAFNFD(object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void OOOEEJBKFBI(Vector3 NDHMLIPBMEM, ForceMode CABLINBFCNG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void LALOIGOPNAL(Vector3 NDHMLIPBMEM, Vector3 DFPHDEDIHFK, ForceMode CABLINBFCNG);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void OEAEDKNBCBH(Vector3 LGNHCCNOFPE, ForceMode CABLINBFCNG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void PDKLEDPMGBI(Vector3 LGNHCCNOFPE, ForceMode CABLINBFCNG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "129")]
	bool JIGNGHLIKCP(Vector3 ALGFLILJAIC, [Out] RaycastHit PFOKHEBHEKI, float CEGICKHHGEL);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void BFDEJOCCNGJ();
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface FJFFINOAFID
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EOCMKBDJAIO(Vector3 ALEKMNACIIP);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGCHKEABOJF(Vector3 ICGDBJCJHBC);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OCGKIBGLGEE(Vector3 ALEKMNACIIP);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BBKIFCNGMPK(Vector3 ICGDBJCJHBC);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface DGGLCAMAKMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 FMOBGOPIDCM();

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 AAMDMGMPHFH();
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public delegate void KHPGPMAKEDG(OOHKIHMPJNC OKNMDFAJNKN);
[Cpp2IlInjected.Token(Token = "0x200003F")]
public enum JNAPDPEIFLH
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
[Cpp2IlInjected.Token(Token = "0x2000040")]
public enum OJJDFFFIEGN
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
[Cpp2IlInjected.Token(Token = "0x2000041")]
public delegate void LHPNJLPJABN(OOHKIHMPJNC OKNMDFAJNKN, bool AHOFFNDGFPE = false);
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum JHDMGOFKGOA
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct JFIFCIHDNHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Rigidbody GOCIBKPJBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public object GNOFKBHKOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector3 AFOBJDMFBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector3 OGNCCDPDPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public IIIFFGPCIFG DPJMCLAAMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool EMHBDLLJNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool LNKBGKPBOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool HJKBHKDKAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool HAJOJLGGDDC;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface ONIEOEDHHIG : KNNDAHEBDGA<DDPLMDBOHKM>, PMJEFJENCPC, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface KCDPNGKDCPK<T> : MPNHIAJCMOH<DDPLMDBOHKM, T>, KNNDAHEBDGA<DDPLMDBOHKM>, PMJEFJENCPC, IDisposable, ONIEOEDHHIG where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class NNJPPFENNHF
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x288AD20", Offset = "0x2889920", VA = "0x18288AD20")]
	public static bool KEKFKPJEKCC<T>(this KNNDAHEBDGA<DDPLMDBOHKM> LKOIJCCHEHO, DDPLMDBOHKM PIOJFCHBCHD, [Out] T GLMEMJNJKAN) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x2CA2360", Offset = "0x2CA0F60", VA = "0x182CA2360")]
	public static bool CBGDEMCKLAL<T>(this KNNDAHEBDGA<DDPLMDBOHKM> LKOIJCCHEHO, DDPLMDBOHKM PIOJFCHBCHD, [In] T CAGOIFBMMMG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface OHDJOMCMGLM : KNNDAHEBDGA<PHLHMBGDJPB>, PMJEFJENCPC, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface PGEMAIGPEFG<T> : MPNHIAJCMOH<PHLHMBGDJPB, T>, KNNDAHEBDGA<PHLHMBGDJPB>, PMJEFJENCPC, IDisposable, OHDJOMCMGLM where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class AAHNLKFFNFH
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x28852E0", Offset = "0x2883EE0", VA = "0x1828852E0")]
	public static T HCNFCFFAFEI<T>(this KNNDAHEBDGA<PHLHMBGDJPB> LKOIJCCHEHO, PHLHMBGDJPB FFODPEFFKPK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2CA2360", Offset = "0x2CA0F60", VA = "0x182CA2360")]
	public static bool CBGDEMCKLAL<T>(this KNNDAHEBDGA<PHLHMBGDJPB> LKOIJCCHEHO, PHLHMBGDJPB FFODPEFFKPK, [In] T CAGOIFBMMMG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct BHHMIGLMNDB : IComparable<BHHMIGLMNDB>, IEquatable<BHHMIGLMNDB>
{
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly BHHMIGLMNDB GFAAJGGODEO;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly BHHMIGLMNDB BAICPAEEANB;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly BHHMIGLMNDB HNGHFHHBJIL;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly BHHMIGLMNDB KICCNMHCBEE;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly BHHMIGLMNDB JIKLHCCBBJB;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly BHHMIGLMNDB MGEEBOJHPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public int HDEPOMLIBHF;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool JGIGFLCFFNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x69CA180", Offset = "0x69C8D80", VA = "0x1869CA180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public int JNFMJBKENKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x69CA280", Offset = "0x69C8E80", VA = "0x1869CA280")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0xA63EA0", Offset = "0xA62AA0", VA = "0x180A63EA0")]
	public BHHMIGLMNDB(int OPDMGNJCACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x69CA220", Offset = "0x69C8E20", VA = "0x1869CA220", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x69CA190", Offset = "0x69C8D90", VA = "0x1869CA190", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x9D6EA0", Offset = "0x9D5AA0", VA = "0x1809D6EA0", Slot = "5")]
	public bool Equals(BHHMIGLMNDB OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1A5CF60", Offset = "0x1A5BB60", VA = "0x181A5CF60", Slot = "4")]
	public int CompareTo(BHHMIGLMNDB OCNJFCPHJLD)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0xDFE9C0", Offset = "0xDFD5C0", VA = "0x180DFE9C0")]
	public static BHHMIGLMNDB NBHHLKKAPBL(int OPDMGNJCACB)
	{
		return default(BHHMIGLMNDB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0xDFE9C0", Offset = "0xDFD5C0", VA = "0x180DFE9C0")]
	public static int NBHHLKKAPBL(BHHMIGLMNDB INFKGBJLKGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x69CA290", Offset = "0x69C8E90", VA = "0x1869CA290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct BBGFBJMHCKM : IEquatable<BBGFBJMHCKM>, PLICLNHIHNE
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly BBGFBJMHCKM NKMJAMBBALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public PHLHMBGDJPB BEHACKJMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0", Slot = "6")]
		get
		{
			return default(PHLHMBGDJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public BPFEIHLNCAM KIMEAEOEPFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BPFEIHLNCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CIMPBBNOEAE MJOGDCELAPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(CIMPBBNOEAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private AGDKOLPOPCA LNADJLMCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x69C9390", Offset = "0x69C7F90", VA = "0x1869C9390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public GameObject OLFFLDPKCIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x69C9A60", Offset = "0x69C8660", VA = "0x1869C9A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public DDPLMDBOHKM EAIGICFAPML
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x69C96E0", Offset = "0x69C82E0", VA = "0x1869C96E0")]
		get
		{
			return default(DDPLMDBOHKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public BKOKLOEODFF JDODKIIDIDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x69C9860", Offset = "0x69C8460", VA = "0x1869C9860")]
		get
		{
			return default(BKOKLOEODFF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public KGAFPCDNLAE EDJFJMCPIGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x69C9490", Offset = "0x69C8090", VA = "0x1869C9490")]
		get
		{
			return default(KGAFPCDNLAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool PHMDBEHNCEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x69C9A40", Offset = "0x69C8640", VA = "0x1869C9A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool CNDMHOCIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x69C9990", Offset = "0x69C8590", VA = "0x1869C9990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool EOMNNKKKJBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x69C97B0", Offset = "0x69C83B0", VA = "0x1869C97B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool BAFBFDBFECO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x69C9BF0", Offset = "0x69C87F0", VA = "0x1869C9BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool ICIHGMEFHFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x69C96C0", Offset = "0x69C82C0", VA = "0x1869C96C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool CKBAMEHAMJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x69C9840", Offset = "0x69C8440", VA = "0x1869C9840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool LIIGAGLKEHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x69C9CE0", Offset = "0x69C88E0", VA = "0x1869C9CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool OCPHKJMFKMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x69C9950", Offset = "0x69C8550", VA = "0x1869C9950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool ABDOLEPBNEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x69C9900", Offset = "0x69C8500", VA = "0x1869C9900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public KKIEPLFBMDA NKLPPPGPJMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(KKIEPLFBMDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public JDBMCCKNMIP KNIFPGIDENH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(JDBMCCKNMIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public BIPMELJNPPK GLANMJNBDKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BIPMELJNPPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public PLMGLCBOHFE DECIOKHOHEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(PLMGLCBOHFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public CCBFMICECML KAEPGPNFIAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(CCBFMICECML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public FEPOHCPDJFB FCOMBIBLBPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(FEPOHCPDJFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public CFPPBFCIPGE PBGHIHOAKMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(CFPPBFCIPGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public EPPPGEFDBAA LOMHFGGMEGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(EPPPGEFDBAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public MMDENFGGNOI ABIONKMOOOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(MMDENFGGNOI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public MHCHLFKBBPD GEIEOFFBKBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(MHCHLFKBBPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public ECPBGLCBKKE JFMIAOHEFPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(ECPBGLCBKKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public BCKAPDGJECC PGADACFIOPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BCKAPDGJECC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool BJDHGOIKFMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x69C9530", Offset = "0x69C8130", VA = "0x1869C9530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool KCHLPPNNMCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x69C99E0", Offset = "0x69C85E0", VA = "0x1869C99E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool HCCJPPIMJDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x69C97D0", Offset = "0x69C83D0", VA = "0x1869C97D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private bool BDABAAONKFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
	public BBGFBJMHCKM(PHLHMBGDJPB FFODPEFFKPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x69C99C0", Offset = "0x69C85C0", VA = "0x1869C99C0")]
	public static bool NBHHLKKAPBL(BBGFBJMHCKM GLMEMJNJKAN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
	public static PHLHMBGDJPB NBHHLKKAPBL(BBGFBJMHCKM GLMEMJNJKAN)
	{
		return default(PHLHMBGDJPB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x69C99B0", Offset = "0x69C85B0", VA = "0x1869C99B0")]
	public static bool NBAHCGFACIA(BBGFBJMHCKM NABHBOMGBNH, BBGFBJMHCKM EIKHFLMLKJH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x69C9A20", Offset = "0x69C8620", VA = "0x1869C9A20")]
	public static bool OONFJEHFBJE(BBGFBJMHCKM NABHBOMGBNH, BBGFBJMHCKM EIKHFLMLKJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x69C9620", Offset = "0x69C8220", VA = "0x1869C9620", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(BBGFBJMHCKM OCNJFCPHJLD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
	public static BBGFBJMHCKM NBHHLKKAPBL(PHLHMBGDJPB NKMEKLOOCFN)
	{
		return default(BBGFBJMHCKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x69C9C60", Offset = "0x69C8860", VA = "0x1869C9C60")]
	public BMPHEBHOCLC PHCFPFMDKMI()
	{
		return default(BMPHEBHOCLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x69C9810", Offset = "0x69C8410", VA = "0x1869C9810")]
	public OPPAHJBFLDL JFBIKMIGDPP()
	{
		return default(OPPAHJBFLDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x69C9C10", Offset = "0x69C8810", VA = "0x1869C9C10")]
	public MAIBLCHFCHO PDLOPLDOFLA()
	{
		return default(MAIBLCHFCHO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x69C9920", Offset = "0x69C8520", VA = "0x1869C9920")]
	public EPKDHBOKLCK LCJFMJFKBNI()
	{
		return default(EPKDHBOKLCK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x69C93F0", Offset = "0x69C7FF0", VA = "0x1869C93F0")]
	public void CALPDMBLOON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x69C9D20", Offset = "0x69C8920", VA = "0x1869C9D20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct CFPPBFCIPGE : IEquatable<CFPPBFCIPGE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public PHLHMBGDJPB BEHACKJMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(PHLHMBGDJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private AGDKOLPOPCA LNADJLMCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x69C9390", Offset = "0x69C7F90", VA = "0x1869C9390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private LAADALIJNDM MOEMEJHHHHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x69CF9D0", Offset = "0x69CE5D0", VA = "0x1869CF9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private BIJLCBNDPDM HDCNDPKIHDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x69CF4F0", Offset = "0x69CE0F0", VA = "0x1869CF4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool BBHDPMEEMAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x69CF700", Offset = "0x69CE300", VA = "0x1869CF700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Guid LEBKOPCAFOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x69CF790", Offset = "0x69CE390", VA = "0x1869CF790")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool ACMGDJGDIGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x69CFB80", Offset = "0x69CE780", VA = "0x1869CFB80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Guid HDAOECHBDCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x69CF8B0", Offset = "0x69CE4B0", VA = "0x1869CF8B0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
	public CFPPBFCIPGE(PHLHMBGDJPB FFODPEFFKPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x69C99C0", Offset = "0x69C85C0", VA = "0x1869C99C0")]
	public static bool NBHHLKKAPBL(CFPPBFCIPGE GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x69CF550", Offset = "0x69CE150", VA = "0x1869CF550", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(CFPPBFCIPGE OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C8CA0", VA = "0x1869CA0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x69CF3B0", Offset = "0x69CDFB0", VA = "0x1869CF3B0")]
	public bool DKICFMCBFNF([Out] Guid DJGLMBCCEPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x69CF5E0", Offset = "0x69CE1E0", VA = "0x1869CF5E0")]
	public void FKHCMFCPLEB(Guid CLJFFIBMODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x69CF450", Offset = "0x69CE050", VA = "0x1869CF450")]
	public bool EAFHBCNDNJP([Out] Guid KJPMBCBOCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x69CFA60", Offset = "0x69CE660", VA = "0x1869CFA60")]
	public void JKOKJHDLLAI(Guid CLJFFIBMODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x69CF320", Offset = "0x69CDF20", VA = "0x1869CF320")]
	public void BFDFAMEGMOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct MAIBLCHFCHO : IEquatable<MAIBLCHFCHO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public PHLHMBGDJPB BEHACKJMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(PHLHMBGDJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private AGDKOLPOPCA LNADJLMCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x69C9390", Offset = "0x69C7F90", VA = "0x1869C9390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private LAADALIJNDM MOEMEJHHHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x69D8A90", Offset = "0x69D7690", VA = "0x1869D8A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private GMFOIJLKJDI OIKOOGFOLFK
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x69D8E80", Offset = "0x69D7A80", VA = "0x1869D8E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 NCOCDMCJKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x69D8770", Offset = "0x69D7370", VA = "0x1869D8770")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Quaternion IDBEMIDBFBF
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x69D8950", Offset = "0x69D7550", VA = "0x1869D8950")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public BBGFBJMHCKM CFMMAPMKAIP
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x69D8DF0", Offset = "0x69D79F0", VA = "0x1869D8DF0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
	public MAIBLCHFCHO(PHLHMBGDJPB FFODPEFFKPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x69C99C0", Offset = "0x69C85C0", VA = "0x1869C99C0")]
	public static bool NBHHLKKAPBL(MAIBLCHFCHO GLMEMJNJKAN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
	public static PHLHMBGDJPB NBHHLKKAPBL(MAIBLCHFCHO GLMEMJNJKAN)
	{
		return default(PHLHMBGDJPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x69D88C0", Offset = "0x69D74C0", VA = "0x1869D88C0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(MAIBLCHFCHO OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C8CA0", VA = "0x1869CA0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x69D8EE0", Offset = "0x69D7AE0", VA = "0x1869D8EE0")]
	public void POFENMKJANK(Vector3 DFPHDEDIHFK, Quaternion DELGPMLKBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x69D8B20", Offset = "0x69D7720", VA = "0x1869D8B20")]
	public void JGHAHEEPMCN(float IADPMFLONGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x69D8C30", Offset = "0x69D7830", VA = "0x1869D8C30")]
	public void MPMAJPLIEAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct BMPHEBHOCLC : IEquatable<BMPHEBHOCLC>
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly BMPHEBHOCLC NKMJAMBBALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public PHLHMBGDJPB BEHACKJMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(PHLHMBGDJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public BPFEIHLNCAM KIMEAEOEPFL
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BPFEIHLNCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public CIMPBBNOEAE MJOGDCELAPN
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(CIMPBBNOEAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private AGDKOLPOPCA LNADJLMCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x69C9390", Offset = "0x69C7F90", VA = "0x1869C9390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private LAADALIJNDM MOEMEJHHHHD
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x69CB1F0", Offset = "0x69C9DF0", VA = "0x1869CB1F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private PKFMNIKNNCC KELNGHKMNKK
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x69CBB60", Offset = "0x69CA760", VA = "0x1869CBB60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public HDPBPBEDBGP FALAHFABCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x69CB0C0", Offset = "0x69C9CC0", VA = "0x1869CB0C0")]
		get
		{
			return default(HDPBPBEDBGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public IEnumerable<BBGFBJMHCKM> ENJDMAIPEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x69CAB60", Offset = "0x69C9760", VA = "0x1869CAB60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public IEnumerable<BBGFBJMHCKM> IIGLBCFEJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x69CBF20", Offset = "0x69CAB20", VA = "0x1869CBF20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public int COCCIAEPPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x69CBBC0", Offset = "0x69CA7C0", VA = "0x1869CBBC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public int IIOKENKFBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x69CBED0", Offset = "0x69CAAD0", VA = "0x1869CBED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public string JBJAOBKIEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x69CBAB0", Offset = "0x69CA6B0", VA = "0x1869CBAB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x69CC050", Offset = "0x69CAC50", VA = "0x1869CC050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public EEBCFHBCHAF JHIHKOHCBHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x69CA5E0", Offset = "0x69C91E0", VA = "0x1869CA5E0")]
		get
		{
			return default(EEBCFHBCHAF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x69CAE80", Offset = "0x69C9A80", VA = "0x1869CAE80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public LEGGIBKEPLP LGPGNBCPFMA
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x69CB830", Offset = "0x69CA430", VA = "0x1869CB830")]
		get
		{
			return default(LEGGIBKEPLP);
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x69CBDF0", Offset = "0x69CA9F0", VA = "0x1869CBDF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public GGFFHFFDBGK GOPDHDLKKBF
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x69CB890", Offset = "0x69CA490", VA = "0x1869CB890")]
		get
		{
			return default(GGFFHFFDBGK);
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x69CBD20", Offset = "0x69CA920", VA = "0x1869CBD20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public float FNAPKOEHCIO
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x69CADC0", Offset = "0x69C99C0", VA = "0x1869CADC0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x69CB050", Offset = "0x69C9C50", VA = "0x1869CB050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool BHJAIPHMKEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x69CAE20", Offset = "0x69C9A20", VA = "0x1869CAE20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x69CB9C0", Offset = "0x69CA5C0", VA = "0x1869CB9C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool FAGBBIKNIIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x69CB8F0", Offset = "0x69CA4F0", VA = "0x1869CB8F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x69CB950", Offset = "0x69CA550", VA = "0x1869CB950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool OLFEHOGNIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x69CBC50", Offset = "0x69CA850", VA = "0x1869CBC50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x69CB180", Offset = "0x69C9D80", VA = "0x1869CB180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool MGMALPDKJEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x69CBD90", Offset = "0x69CA990", VA = "0x1869CBD90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x69CBCB0", Offset = "0x69CA8B0", VA = "0x1869CBCB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool DKMCMKFKJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x69CAEF0", Offset = "0x69C9AF0", VA = "0x1869CAEF0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x69CBE60", Offset = "0x69CAA60", VA = "0x1869CBE60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool ECBOLMGCODM
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x69CACD0", Offset = "0x69C98D0", VA = "0x1869CACD0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x69CAFE0", Offset = "0x69C9BE0", VA = "0x1869CAFE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
	public BMPHEBHOCLC(PHLHMBGDJPB FFODPEFFKPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x69C99C0", Offset = "0x69C85C0", VA = "0x1869C99C0")]
	public static bool NBHHLKKAPBL(BMPHEBHOCLC GLMEMJNJKAN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x69C99B0", Offset = "0x69C85B0", VA = "0x1869C99B0")]
	public static bool NBAHCGFACIA(BMPHEBHOCLC NABHBOMGBNH, BMPHEBHOCLC EIKHFLMLKJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x69CAF50", Offset = "0x69C9B50", VA = "0x1869CAF50", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(BMPHEBHOCLC OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C8CA0", VA = "0x1869CA0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
	public static BBGFBJMHCKM NBHHLKKAPBL(BMPHEBHOCLC HNFMOHFACKF)
	{
		return default(BBGFBJMHCKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x69CADA0", Offset = "0x69C99A0", VA = "0x1869CADA0")]
	public bool EEMOOLAJAGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x69CAD30", Offset = "0x69C9930", VA = "0x1869CAD30")]
	public bool DKGPDOGDAGO(KLJFOIFHPPB FAONJBNKABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x69CBA30", Offset = "0x69CA630", VA = "0x1869CBA30")]
	public void LHFLNPEAHNI(KLJFOIFHPPB FAONJBNKABK, bool GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x69CA640", Offset = "0x69C9240", VA = "0x1869CA640")]
	public HDPBPBEDBGP CAKDNKMBDAF(Allocator BLMBIIGOJPG)
	{
		return default(HDPBPBEDBGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x69CA7F0", Offset = "0x69C93F0", VA = "0x1869CA7F0")]
	public void CCFJFJLOEPJ(BMPHEBHOCLC OCNJFCPHJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x69CB280", Offset = "0x69C9E80", VA = "0x1869CB280")]
	public void JJHHGONBLCK(List<BBGFBJMHCKM> JDPGDKPFNJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct EDNFJMOKMLB : IEquatable<EDNFJMOKMLB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x69D3400", Offset = "0x69D2000", VA = "0x1869D3400", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(EDNFJMOKMLB OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C8CA0", VA = "0x1869CA0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct JDBMCCKNMIP : IEquatable<JDBMCCKNMIP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	private AGDKOLPOPCA LNADJLMCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x69C9390", Offset = "0x69C7F90", VA = "0x1869C9390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
	public JDBMCCKNMIP(PHLHMBGDJPB FFODPEFFKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x69D7360", Offset = "0x69D5F60", VA = "0x1869D7360", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(JDBMCCKNMIP OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C8CA0", VA = "0x1869CA0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x69D7490", Offset = "0x69D6090", VA = "0x1869D7490")]
	public void IICIADDLCDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x69D7530", Offset = "0x69D6130", VA = "0x1869D7530")]
	public void OKNFFCDFMEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x69D73F0", Offset = "0x69D5FF0", VA = "0x1869D73F0")]
	public bool HLBGILIKEIP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct CIMPBBNOEAE : IEquatable<CIMPBBNOEAE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public PHLHMBGDJPB BEHACKJMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(PHLHMBGDJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private AGDKOLPOPCA LNADJLMCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x69C9390", Offset = "0x69C7F90", VA = "0x1869C9390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	private LAADALIJNDM MOEMEJHHHHD
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x69D01D0", Offset = "0x69CEDD0", VA = "0x1869D01D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private PKFMNIKNNCC KELNGHKMNKK
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x69D04F0", Offset = "0x69CF0F0", VA = "0x1869D04F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public PHLHMBGDJPB IMAGJDIEDNF
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x69CFCB0", Offset = "0x69CE8B0", VA = "0x1869CFCB0")]
		get
		{
			return default(PHLHMBGDJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public BBGFBJMHCKM MHBJGCIDGAC
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x69CFE60", Offset = "0x69CEA60", VA = "0x1869CFE60")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public BBGFBJMHCKM MOHNEGNCIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x69CFEF0", Offset = "0x69CEAF0", VA = "0x1869CFEF0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
	public CIMPBBNOEAE(PHLHMBGDJPB FFODPEFFKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x69CFDD0", Offset = "0x69CE9D0", VA = "0x1869CFDD0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(CIMPBBNOEAE OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C8CA0", VA = "0x1869CA0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x69D00A0", Offset = "0x69CECA0", VA = "0x1869D00A0")]
	public bool INMMMEFJOBK(BBGFBJMHCKM GPMGJNAOOEP, bool OMBLHEEJENF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x69D0550", Offset = "0x69CF150", VA = "0x1869D0550")]
	public bool OGNDBFIBJJE(BBGFBJMHCKM EDBAEOCEHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x69D0260", Offset = "0x69CEE60", VA = "0x1869D0260")]
	private void JLEFAABACBJ(BBGFBJMHCKM DEHGOAMJJDC, List<BBGFBJMHCKM> MMFCNLGOPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x69CFD40", Offset = "0x69CE940", VA = "0x1869CFD40")]
	public BMPHEBHOCLC CPGECKMLIBH()
	{
		return default(BMPHEBHOCLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x69D05F0", Offset = "0x69CF1F0", VA = "0x1869D05F0")]
	public void PAAEAKEGHAF(List<BBGFBJMHCKM> HHPJMOIPKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x69CFF80", Offset = "0x69CEB80", VA = "0x1869CFF80")]
	public NativeArray<PHLHMBGDJPB> HJEMEJMDGHJ()
	{
		return default(NativeArray<PHLHMBGDJPB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct KKIEPLFBMDA : IEquatable<KKIEPLFBMDA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public string DKCABFIGINA
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x69D8040", Offset = "0x69D6C40", VA = "0x1869D8040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public string FMLMOKMGOEM
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x69D80C0", Offset = "0x69D6CC0", VA = "0x1869D80C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool IAFFEPEJGPN
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x69D7D80", Offset = "0x69D6980", VA = "0x1869D7D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public string MODNMBAGHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x69D7EC0", Offset = "0x69D6AC0", VA = "0x1869D7EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public string CFKAFLCIKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x69D8190", Offset = "0x69D6D90", VA = "0x1869D8190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public string NCKACJFNDBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x69D83E0", Offset = "0x69D6FE0", VA = "0x1869D83E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
	public KKIEPLFBMDA(PHLHMBGDJPB FFODPEFFKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x69D7FB0", Offset = "0x69D6BB0", VA = "0x1869D7FB0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(KKIEPLFBMDA OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C8CA0", VA = "0x1869CA0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct ECPBGLCBKKE : IEquatable<ECPBGLCBKKE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	private AGDKOLPOPCA LNADJLMCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x69C9390", Offset = "0x69C7F90", VA = "0x1869C9390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private LAADALIJNDM MOEMEJHHHHD
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x69D2FA0", Offset = "0x69D1BA0", VA = "0x1869D2FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private HPADFHGNAHD JIOBKGCKAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x69D30D0", Offset = "0x69D1CD0", VA = "0x1869D30D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public JKBEILLLHJC MCIKBFLECLE
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x69D3270", Offset = "0x69D1E70", VA = "0x1869D3270")]
		get
		{
			return default(JKBEILLLHJC);
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x69D2BC0", Offset = "0x69D17C0", VA = "0x1869D2BC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public bool KLKBACNJIEC
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x69D2D60", Offset = "0x69D1960", VA = "0x1869D2D60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x69D3130", Offset = "0x69D1D30", VA = "0x1869D3130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public string[] BJMGKFAFCHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x69D2F10", Offset = "0x69D1B10", VA = "0x1869D2F10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x69D3030", Offset = "0x69D1C30", VA = "0x1869D3030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public string[] NHKBAGMBCPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x69D2DF0", Offset = "0x69D19F0", VA = "0x1869D2DF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x69D29E0", Offset = "0x69D15E0", VA = "0x1869D29E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public string[] LNAOGEFJOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x69D2E80", Offset = "0x69D1A80", VA = "0x1869D2E80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x69D2A80", Offset = "0x69D1680", VA = "0x1869D2A80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public string[] LINCAGKDBGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x69D3370", Offset = "0x69D1F70", VA = "0x1869D3370")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x69D31D0", Offset = "0x69D1DD0", VA = "0x1869D31D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
	public ECPBGLCBKKE(PHLHMBGDJPB FFODPEFFKPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
	public static PHLHMBGDJPB NBHHLKKAPBL(ECPBGLCBKKE GLMEMJNJKAN)
	{
		return default(PHLHMBGDJPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x69D2CD0", Offset = "0x69D18D0", VA = "0x1869D2CD0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(ECPBGLCBKKE OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C8CA0", VA = "0x1869CA0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x69D2B20", Offset = "0x69D1720", VA = "0x1869D2B20")]
	public bool DLNCCGALJDB(PHLHMBGDJPB KBMFHBINANN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct BPKHAPGENKJ : IEquatable<BPKHAPGENKJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x69CE5D0", Offset = "0x69CD1D0", VA = "0x1869CE5D0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(BPKHAPGENKJ OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C8CA0", VA = "0x1869CA0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct BIPMELJNPPK : IEquatable<BIPMELJNPPK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
	public BIPMELJNPPK(PHLHMBGDJPB FFODPEFFKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x69CA550", Offset = "0x69C9150", VA = "0x1869CA550", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(BIPMELJNPPK OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C8CA0", VA = "0x1869CA0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x69CA3E0", Offset = "0x69C8FE0", VA = "0x1869CA3E0")]
	public bool ANPDEOHDCPH([Out] Collider FJEKLDBPJED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct EPKDHBOKLCK : IEquatable<EPKDHBOKLCK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public PHLHMBGDJPB BEHACKJMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(PHLHMBGDJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	private MakerPenHeldDataWrapper ACMPFICCIAG
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x69D4490", Offset = "0x69D3090", VA = "0x1869D4490")]
		get
		{
			return default(MakerPenHeldDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool CMCJCEGHDCM
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x69D4420", Offset = "0x69D3020", VA = "0x1869D4420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
	public EPKDHBOKLCK(PHLHMBGDJPB FFODPEFFKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x69D4390", Offset = "0x69D2F90", VA = "0x1869D4390", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(EPKDHBOKLCK OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C8CA0", VA = "0x1869CA0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct MMDENFGGNOI : IEquatable<MMDENFGGNOI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public PHLHMBGDJPB BEHACKJMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(PHLHMBGDJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	private AGDKOLPOPCA LNADJLMCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x69C9390", Offset = "0x69C7F90", VA = "0x1869C9390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	private LAADALIJNDM MOEMEJHHHHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x69D9D20", Offset = "0x69D8920", VA = "0x1869D9D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	private IFPAINJGJMB IPBBEDIDPLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x69D9B90", Offset = "0x69D8790", VA = "0x1869D9B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
	public MMDENFGGNOI(PHLHMBGDJPB FFODPEFFKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x69D9C90", Offset = "0x69D8890", VA = "0x1869D9C90", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(MMDENFGGNOI OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C8CA0", VA = "0x1869CA0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x69D9BF0", Offset = "0x69D87F0", VA = "0x1869D9BF0")]
	public void EDLIMHEENDK(bool EIDGLBDJAHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct PLMGLCBOHFE : IEquatable<PLMGLCBOHFE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public PHLHMBGDJPB BEHACKJMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(PHLHMBGDJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	private AGDKOLPOPCA LNADJLMCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x69C9390", Offset = "0x69C7F90", VA = "0x1869C9390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	private LAADALIJNDM MOEMEJHHHHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x69DC710", Offset = "0x69DB310", VA = "0x1869DC710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private ObjectPolicyDataWrapper GBJMGBCJIPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x69DC880", Offset = "0x69DB480", VA = "0x1869DC880")]
		get
		{
			return default(ObjectPolicyDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private NavMeshGenerationDataWrapper AIEKNFMJJPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x69DCE10", Offset = "0x69DBA10", VA = "0x1869DCE10")]
		get
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public bool JCAPEKNCNCF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x69DBEC0", Offset = "0x69DAAC0", VA = "0x1869DBEC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public bool ACEECJNMFBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x69DC550", Offset = "0x69DB150", VA = "0x1869DC550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public bool CJEMAEDMEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x69DCCF0", Offset = "0x69DB8F0", VA = "0x1869DCCF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool DMEIICOGGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x69DC310", Offset = "0x69DAF10", VA = "0x1869DC310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool MACGNLKNBBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x69DCB00", Offset = "0x69DB700", VA = "0x1869DCB00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool LGKDOLDOLIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x69DC7A0", Offset = "0x69DB3A0", VA = "0x1869DC7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool KLOIKDMNBAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x69DC9D0", Offset = "0x69DB5D0", VA = "0x1869DC9D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool ADMDEHPFPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x69DBDE0", Offset = "0x69DA9E0", VA = "0x1869DBDE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public bool FEAEICLLGLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x69DC1D0", Offset = "0x69DADD0", VA = "0x1869DC1D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public bool MHECEMMAOIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x69DC380", Offset = "0x69DAF80", VA = "0x1869DC380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public bool OBFNLECPCOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x69DBE50", Offset = "0x69DAA50", VA = "0x1869DBE50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public bool CMEBJEHHEFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x69DC630", Offset = "0x69DB230", VA = "0x1869DC630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public bool HBOPPMPJCAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x69DC6A0", Offset = "0x69DB2A0", VA = "0x1869DC6A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool MBKKJDKBOAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x69DCB70", Offset = "0x69DB770", VA = "0x1869DCB70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool LGAEBILNCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x69DCC30", Offset = "0x69DB830", VA = "0x1869DCC30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x69DC240", Offset = "0x69DAE40", VA = "0x1869DC240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public MEGLICJNLED AJGLPBNCHHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x69DCBD0", Offset = "0x69DB7D0", VA = "0x1869DCBD0")]
		get
		{
			return default(MEGLICJNLED);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x69DC5C0", Offset = "0x69DB1C0", VA = "0x1869DC5C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool IHABBKMPMFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x69DC000", Offset = "0x69DAC00", VA = "0x1869DC000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public EFGMDLKHKBH AJHHIAEFODI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x69DC3F0", Offset = "0x69DAFF0", VA = "0x1869DC3F0")]
		get
		{
			return default(EFGMDLKHKBH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool CFDGDNPMGPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x69DCC90", Offset = "0x69DB890", VA = "0x1869DCC90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Vector3 DKNLDNINPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x69DCA40", Offset = "0x69DB640", VA = "0x1869DCA40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Vector3 PDLNGAGPOGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x69DCD60", Offset = "0x69DB960", VA = "0x1869DCD60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool OONDHEKICPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x69DBF00", Offset = "0x69DAB00", VA = "0x1869DBF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
	public PLMGLCBOHFE(PHLHMBGDJPB FFODPEFFKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x69DC4C0", Offset = "0x69DB0C0", VA = "0x1869DC4C0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(PLMGLCBOHFE OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C8CA0", VA = "0x1869CA0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x69DC450", Offset = "0x69DB050", VA = "0x1869DC450")]
	public bool EFJANPAOKCK(HJDKAEONDEG FAONJBNKABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x69DC960", Offset = "0x69DB560", VA = "0x1869DC960")]
	public bool LHCIKGJOAOH(BCCIMNDHFAP FAONJBNKABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x69DC8E0", Offset = "0x69DB4E0", VA = "0x1869DC8E0")]
	public void KJNOAMOIOIC(BCCIMNDHFAP FAONJBNKABK, bool MOAICLIJDKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x69DC2B0", Offset = "0x69DAEB0", VA = "0x1869DC2B0")]
	public BCCIMNDHFAP BKMGFMDBEPM()
	{
		return default(BCCIMNDHFAP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x69DC810", Offset = "0x69DB410", VA = "0x1869DC810")]
	public bool JJOLEKMBHMA(BCCIMNDHFAP GLMEMJNJKAN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct MHCHLFKBBPD : IEquatable<MHCHLFKBBPD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	private AGDKOLPOPCA LNADJLMCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x69C9390", Offset = "0x69C7F90", VA = "0x1869C9390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	private LAADALIJNDM MOEMEJHHHHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x69D9730", Offset = "0x69D8330", VA = "0x1869D9730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private MCNBHCFGCFL HDHBDFEEGJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x69D98F0", Offset = "0x69D84F0", VA = "0x1869D98F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
	public MHCHLFKBBPD(PHLHMBGDJPB FFODPEFFKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x69D91D0", Offset = "0x69D7DD0", VA = "0x1869D91D0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(MHCHLFKBBPD OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C8CA0", VA = "0x1869CA0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x69D9A60", Offset = "0x69D8660", VA = "0x1869D9A60")]
	public bool NGLLHJIBBAL(LECJGOBHOND OLADDMOOKPM, List<BBGFBJMHCKM> JDPGDKPFNJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x69D9310", Offset = "0x69D7F10", VA = "0x1869D9310")]
	public int GLENIBNKFNG(LECJGOBHOND OLADDMOOKPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x69D9950", Offset = "0x69D8550", VA = "0x1869D9950")]
	public void MFFIAHKKDBK(List<BBGFBJMHCKM> JDPGDKPFNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x69D9420", Offset = "0x69D8020", VA = "0x1869D9420")]
	public int HNKMEOEHJLO(BBGFBJMHCKM PJIFCLGMLOL, LECJGOBHOND OLADDMOOKPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x69D9550", Offset = "0x69D8150", VA = "0x1869D9550")]
	public BBGFBJMHCKM HPDDHGBMMLI(int OPDMGNJCACB, LECJGOBHOND OLADDMOOKPM)
	{
		return default(BBGFBJMHCKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x69D97C0", Offset = "0x69D83C0", VA = "0x1869D97C0")]
	public void JNGDMHIAKLJ(BBGFBJMHCKM PJIFCLGMLOL, LECJGOBHOND OLADDMOOKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x69D9680", Offset = "0x69D8280", VA = "0x1869D9680")]
	public bool IHAIEIGBCGP(BBGFBJMHCKM PJIFCLGMLOL, LECJGOBHOND OLADDMOOKPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x69D90C0", Offset = "0x69D7CC0", VA = "0x1869D90C0")]
	public void AFMHNNABBAI(LECJGOBHOND OLADDMOOKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x69D9260", Offset = "0x69D7E60", VA = "0x1869D9260")]
	public bool GEKEFMEEOKP(BBGFBJMHCKM PJIFCLGMLOL, LECJGOBHOND OLADDMOOKPM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct FEPOHCPDJFB : IEquatable<FEPOHCPDJFB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public PHLHMBGDJPB BEHACKJMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(PHLHMBGDJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	private AGDKOLPOPCA LNADJLMCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x69C9390", Offset = "0x69C7F90", VA = "0x1869C9390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	private LAADALIJNDM MOEMEJHHHHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x69D52E0", Offset = "0x69D3EE0", VA = "0x1869D52E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
	public FEPOHCPDJFB(PHLHMBGDJPB FFODPEFFKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x69D51C0", Offset = "0x69D3DC0", VA = "0x1869D51C0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(FEPOHCPDJFB OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C8CA0", VA = "0x1869CA0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x69D5250", Offset = "0x69D3E50", VA = "0x1869D5250")]
	public void IELBOCKCEGL(bool GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x69D5130", Offset = "0x69D3D30", VA = "0x1869D5130")]
	public void EEHPEKHFEMF(bool GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4D40", Offset = "0x2AE3940", VA = "0x182AE4D40")]
	public T EJBPCPKNMNG<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct BCKAPDGJECC : IEquatable<BCKAPDGJECC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public PHLHMBGDJPB BEHACKJMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(PHLHMBGDJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	private AGDKOLPOPCA LNADJLMCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x69C9390", Offset = "0x69C7F90", VA = "0x1869C9390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	private LAADALIJNDM MOEMEJHHHHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x69C9F80", Offset = "0x69C8B80", VA = "0x1869C9F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	private OADJDJJMHKE CIIJIECJOAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x69C9F20", Offset = "0x69C8B20", VA = "0x1869C9F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public bool NEBBDHPDKIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x69CA010", Offset = "0x69C8C10", VA = "0x1869CA010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public bool LODGFDCOFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x69C9E90", Offset = "0x69C8A90", VA = "0x1869C9E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
	public BCKAPDGJECC(PHLHMBGDJPB FFODPEFFKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x69C9E00", Offset = "0x69C8A00", VA = "0x1869C9E00", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(BCKAPDGJECC OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C8CA0", VA = "0x1869CA0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct CCBFMICECML : IEquatable<CCBFMICECML>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public PHLHMBGDJPB BEHACKJMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(PHLHMBGDJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private AGDKOLPOPCA LNADJLMCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x69C9390", Offset = "0x69C7F90", VA = "0x1869C9390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private LAADALIJNDM MOEMEJHHHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x69CEF50", Offset = "0x69CDB50", VA = "0x1869CEF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private BEHODOPNIEL PIFKHDAGFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x69CEE30", Offset = "0x69CDA30", VA = "0x1869CEE30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private KFEPGCIEIDC PEMBMDNOOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x69CF110", Offset = "0x69CDD10", VA = "0x1869CF110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool JNDHKCAKJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x69CEE90", Offset = "0x69CDA90", VA = "0x1869CEE90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool NGJNAJNNDKL
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x69CEC60", Offset = "0x69CD860", VA = "0x1869CEC60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool JGBFJKCPIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x69CEF20", Offset = "0x69CDB20", VA = "0x1869CEF20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool FJJKKOKPPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x69CE660", Offset = "0x69CD260", VA = "0x1869CE660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool KMNKKHEPOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x69CF070", Offset = "0x69CDC70", VA = "0x1869CF070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool CMFHCKJALKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x69CEFE0", Offset = "0x69CDBE0", VA = "0x1869CEFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool LFJICILHIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x69CEA50", Offset = "0x69CD650", VA = "0x1869CEA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool EFCJMCOPAMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x69CE7D0", Offset = "0x69CD3D0", VA = "0x1869CE7D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
	public CCBFMICECML(PHLHMBGDJPB FFODPEFFKPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x69C99C0", Offset = "0x69C85C0", VA = "0x1869C99C0")]
	public static bool NBHHLKKAPBL(CCBFMICECML GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x69CEDA0", Offset = "0x69CD9A0", VA = "0x1869CEDA0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(CCBFMICECML OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C8CA0", VA = "0x1869CA0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x69CF0A0", Offset = "0x69CDCA0", VA = "0x1869CF0A0")]
	public bool KNGCKBJJGHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x69CF170", Offset = "0x69CDD70", VA = "0x1869CF170")]
	public BBGFBJMHCKM NBIDCNHNJBN(BBGFBJMHCKM PJIFCLGMLOL)
	{
		return default(BBGFBJMHCKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x69CF210", Offset = "0x69CDE10", VA = "0x1869CF210")]
	public PHLHMBGDJPB NNPFJOKDAJO()
	{
		return default(PHLHMBGDJPB);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x69CE730", Offset = "0x69CD330", VA = "0x1869CE730")]
	public bool AEPKDACOKPG(PHLHMBGDJPB JHHENFAIBDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x69CED00", Offset = "0x69CD900", VA = "0x1869CED00")]
	public bool EPLNLLIBKNC(PHLHMBGDJPB KEDHPDODLIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x69CE940", Offset = "0x69CD540", VA = "0x1869CE940")]
	public bool DKCNFOFGONM(PHLHMBGDJPB PJIFCLGMLOL, [Out] PHLHMBGDJPB JHHENFAIBDG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public readonly struct OPPAHJBFLDL : IEquatable<OPPAHJBFLDL>
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly OPPAHJBFLDL NKMJAMBBALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public PHLHMBGDJPB BEHACKJMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(PHLHMBGDJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public BPFEIHLNCAM KIMEAEOEPFL
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BPFEIHLNCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public CIMPBBNOEAE MJOGDCELAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(CIMPBBNOEAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private ShapeTypeDataWrapper EONCBNAAMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x69DADC0", Offset = "0x69D99C0", VA = "0x1869DADC0")]
		get
		{
			return default(ShapeTypeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public StandardRenderableVisualDataWrapper CKMFIAFCMPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x69DA880", Offset = "0x69D9480", VA = "0x1869DA880")]
		get
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public PhysicsMaterialDataWrapper GMIEFFNFIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x69DA680", Offset = "0x69D9280", VA = "0x1869DA680")]
		get
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public ShapeConfigDataWrapper AJNMFEJDLEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x69DAE20", Offset = "0x69D9A20", VA = "0x1869DAE20")]
		get
		{
			return default(ShapeConfigDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public IFAAMIPBLNN JKGLBPHONLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x69DA6E0", Offset = "0x69D92E0", VA = "0x1869DA6E0")]
		get
		{
			return default(IFAAMIPBLNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public EFKMGKJGMIM IFLIDIAMOMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x69DAC50", Offset = "0x69D9850", VA = "0x1869DAC50")]
		get
		{
			return default(EFKMGKJGMIM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x69DAD50", Offset = "0x69D9950", VA = "0x1869DAD50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public GDIFGOILILA AFDBCPGONJK
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x69DAA90", Offset = "0x69D9690", VA = "0x1869DAA90")]
		get
		{
			return default(GDIFGOILILA);
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x69DAE80", Offset = "0x69D9A80", VA = "0x1869DAE80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public float AHODCAJLIDM
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x69DA9C0", Offset = "0x69D95C0", VA = "0x1869DA9C0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x69DAA20", Offset = "0x69D9620", VA = "0x1869DAA20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public Vector3 OGNCIPOODIK
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x69DA750", Offset = "0x69D9350", VA = "0x1869DA750")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x69DACB0", Offset = "0x69D98B0", VA = "0x1869DACB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public float OOILGEHABJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x69DAAF0", Offset = "0x69D96F0", VA = "0x1869DAAF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public PJNOCAJGACO PLEMNJOLHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x69DA960", Offset = "0x69D9560", VA = "0x1869DA960")]
		get
		{
			return default(PJNOCAJGACO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x69DABE0", Offset = "0x69D97E0", VA = "0x1869DABE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
	public OPPAHJBFLDL(PHLHMBGDJPB FFODPEFFKPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x69C99C0", Offset = "0x69C85C0", VA = "0x1869C99C0")]
	public static bool NBHHLKKAPBL(OPPAHJBFLDL GLMEMJNJKAN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x69C9A20", Offset = "0x69C8620", VA = "0x1869C9A20")]
	public static bool OONFJEHFBJE(OPPAHJBFLDL NABHBOMGBNH, OPPAHJBFLDL EIKHFLMLKJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x69DA7F0", Offset = "0x69D93F0", VA = "0x1869DA7F0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(OPPAHJBFLDL OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C8CA0", VA = "0x1869CA0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x69DAB60", Offset = "0x69D9760", VA = "0x1869DAB60")]
	public NANDHBFEAAP MGDODJNJLJI()
	{
		return default(NANDHBFEAAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x69DA8E0", Offset = "0x69D94E0", VA = "0x1869DA8E0")]
	public EEHLMFIBPKA FICHLCODNCH()
	{
		return default(EEHLMFIBPKA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct NANDHBFEAAP : IEquatable<NANDHBFEAAP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public PHLHMBGDJPB BEHACKJMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(PHLHMBGDJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public OPPAHJBFLDL MGOKCEPFKGL
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(OPPAHJBFLDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private PrimitiveShapeDataWrapper HMHLAADDGMB
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x69D9E10", Offset = "0x69D8A10", VA = "0x1869D9E10")]
		get
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public IPMKGJBCEGN JAAPJMHBFFF
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x69D9DB0", Offset = "0x69D89B0", VA = "0x1869D9DB0")]
		get
		{
			return default(IPMKGJBCEGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
	public NANDHBFEAAP(PHLHMBGDJPB FFODPEFFKPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x69C99C0", Offset = "0x69C85C0", VA = "0x1869C99C0")]
	public static bool NBHHLKKAPBL(NANDHBFEAAP GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x69D9E70", Offset = "0x69D8A70", VA = "0x1869D9E70", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(NANDHBFEAAP OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C8CA0", VA = "0x1869CA0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public readonly struct EEHLMFIBPKA : IEquatable<EEHLMFIBPKA>
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly EEHLMFIBPKA NKMJAMBBALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public PHLHMBGDJPB BEHACKJMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(PHLHMBGDJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public BPFEIHLNCAM KIMEAEOEPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BPFEIHLNCAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private AGDKOLPOPCA LNADJLMCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x69C9390", Offset = "0x69C7F90", VA = "0x1869C9390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	private LAADALIJNDM MOEMEJHHHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x69D3C20", Offset = "0x69D2820", VA = "0x1869D3C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private GIKIIGOKLLC BCFEMLHMCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x69D3F00", Offset = "0x69D2B00", VA = "0x1869D3F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public OPPAHJBFLDL MGOKCEPFKGL
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(OPPAHJBFLDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public OFPOAEGCOLE CONHCMLNGJC
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x69D3CB0", Offset = "0x69D28B0", VA = "0x1869D3CB0")]
		get
		{
			return default(OFPOAEGCOLE);
		}
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x69D37E0", Offset = "0x69D23E0", VA = "0x1869D37E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public IEnumerable<DJFOKEDDECC> MPAFEGLGHAC
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x69D3900", Offset = "0x69D2500", VA = "0x1869D3900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public DJFOKEDDECC ENBJMEPMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x69D3B10", Offset = "0x69D2710", VA = "0x1869D3B10")]
		get
		{
			return default(DJFOKEDDECC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public int FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x69D3DE0", Offset = "0x69D29E0", VA = "0x1869D3DE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
	public EEHLMFIBPKA(PHLHMBGDJPB FFODPEFFKPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x69C99C0", Offset = "0x69C85C0", VA = "0x1869C99C0")]
	public static bool NBHHLKKAPBL(EEHLMFIBPKA GLMEMJNJKAN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x69C99B0", Offset = "0x69C85B0", VA = "0x1869C99B0")]
	public static bool NBAHCGFACIA(EEHLMFIBPKA NABHBOMGBNH, EEHLMFIBPKA EIKHFLMLKJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x69D3750", Offset = "0x69D2350", VA = "0x1869D3750", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(EEHLMFIBPKA OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C8CA0", VA = "0x1869CA0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x69D3530", Offset = "0x69D2130", VA = "0x1869D3530")]
	public DJFOKEDDECC DCNHNFPJNMN(float3? DFPHDEDIHFK, [Optional] quaternion? DELGPMLKBMI, [Optional] Vector3? IADPMFLONGE)
	{
		return default(DJFOKEDDECC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x69D3F60", Offset = "0x69D2B60", VA = "0x1869D3F60")]
	public DJFOKEDDECC POPNBBOIFCJ(int OPDMGNJCACB, float3? DFPHDEDIHFK, [Optional] quaternion? DELGPMLKBMI, [Optional] Vector3? IADPMFLONGE)
	{
		return default(DJFOKEDDECC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x69D3490", Offset = "0x69D2090", VA = "0x1869D3490")]
	public void AJEGLFHDELH(int OPDMGNJCACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x69D3E70", Offset = "0x69D2A70", VA = "0x1869D3E70")]
	public void ONDHHAABKMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct DJFOKEDDECC : IEquatable<DJFOKEDDECC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public PHLHMBGDJPB BEHACKJMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(PHLHMBGDJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public EEHLMFIBPKA DFOHFCMEGPD
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x69D24E0", Offset = "0x69D10E0", VA = "0x1869D24E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public float3 OCLAILDFLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x69D26B0", Offset = "0x69D12B0", VA = "0x1869D26B0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x69D22F0", Offset = "0x69D0EF0", VA = "0x1869D22F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public quaternion OJMCLJJHOHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x69D2460", Offset = "0x69D1060", VA = "0x1869D2460")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x69D28E0", Offset = "0x69D14E0", VA = "0x1869D28E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public float3 CBAPDJBOKEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x69D2860", Offset = "0x69D1460", VA = "0x1869D2860")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x69D25D0", Offset = "0x69D11D0", VA = "0x1869D25D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public CBNCODLAAAJ FPNIFDOLLCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x69D2790", Offset = "0x69D1390", VA = "0x1869D2790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	private SplinePointParentDataWrapper IKMBEICNJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x69D2400", Offset = "0x69D1000", VA = "0x1869D2400")]
		get
		{
			return default(SplinePointParentDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	private SplinePointPositionDataWrapper FNJBMDCLJBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x69D2570", Offset = "0x69D1170", VA = "0x1869D2570")]
		get
		{
			return default(SplinePointPositionDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	private SplinePointRotationDataWrapper LFGJFHGLAMC
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x69D2800", Offset = "0x69D1400", VA = "0x1869D2800")]
		get
		{
			return default(SplinePointRotationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	private SplinePointScaleDataWrapper EANEJADGJOF
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x69D2650", Offset = "0x69D1250", VA = "0x1869D2650")]
		get
		{
			return default(SplinePointScaleDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	private SplinePointOrderDataWrapper CIMDEMOLFAK
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x69D2730", Offset = "0x69D1330", VA = "0x1869D2730")]
		get
		{
			return default(SplinePointOrderDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
	public DJFOKEDDECC(PHLHMBGDJPB FFODPEFFKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x69D2370", Offset = "0x69D0F70", VA = "0x1869D2370", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(DJFOKEDDECC OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C8CA0", VA = "0x1869CA0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x69D24E0", Offset = "0x69D10E0", VA = "0x1869D24E0")]
	public void KFPOENFEGNK(EEHLMFIBPKA GLMEMJNJKAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct EPPPGEFDBAA : IEquatable<EPPPGEFDBAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public PHLHMBGDJPB BEHACKJMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(PHLHMBGDJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	private AGDKOLPOPCA LNADJLMCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x69C9390", Offset = "0x69C7F90", VA = "0x1869C9390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private LAADALIJNDM MOEMEJHHHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x69D4A50", Offset = "0x69D3650", VA = "0x1869D4A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	private DBIOJFOONBD PBGELDCACLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x69D4DF0", Offset = "0x69D39F0", VA = "0x1869D4DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private ToolCleanupSettingsDataWrapper DJAJFFDCGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x69D4AE0", Offset = "0x69D36E0", VA = "0x1869D4AE0")]
		get
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public bool DCIDIOIBMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x69D4770", Offset = "0x69D3370", VA = "0x1869D4770")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x69D4660", Offset = "0x69D3260", VA = "0x1869D4660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public bool OKHJDJHAANG
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x69D4BE0", Offset = "0x69D37E0", VA = "0x1869D4BE0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x69D44F0", Offset = "0x69D30F0", VA = "0x1869D44F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public float MBAEKJLEPBC
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x69D4E50", Offset = "0x69D3A50", VA = "0x1869D4E50")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x69D45F0", Offset = "0x69D31F0", VA = "0x1869D45F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool EMBKECHCLFG
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x69D46D0", Offset = "0x69D32D0", VA = "0x1869D46D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
	public EPPPGEFDBAA(PHLHMBGDJPB FFODPEFFKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x69D4560", Offset = "0x69D3160", VA = "0x1869D4560", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(EPPPGEFDBAA OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C8CA0", VA = "0x1869CA0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x69D4B40", Offset = "0x69D3740", VA = "0x1869D4B40")]
	public void LFBCPLACOCH(int ONIAHHAAJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C40", Offset = "0x69D3840", VA = "0x1869D4C40")]
	public bool NCLGOPDJCDC([Out] int ONIAHHAAJEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x69D4D50", Offset = "0x69D3950", VA = "0x1869D4D50")]
	public void NNJKJICBIJB(bool IMMCDALLIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x69D4FE0", Offset = "0x69D3BE0", VA = "0x1869D4FE0")]
	public void PLKJOOOANIC(float FJCGOBLIPDF, float BDKHHIDEJKA, float NAFDOOEEGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x69D4900", Offset = "0x69D3500", VA = "0x1869D4900")]
	public void JBALOAEICFG(float3 NELEGHHJIKE, quaternion GIPEDKANICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x69D4EB0", Offset = "0x69D3AB0", VA = "0x1869D4EB0")]
	public bool OPGGBEEMEFC([Out] float3 NELEGHHJIKE, [Out] quaternion GIPEDKANICC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x69D47D0", Offset = "0x69D33D0", VA = "0x1869D47D0")]
	public bool IOMOPJDELEH([Out] float OBHLGNGDFCO, [Out] float OBBJGCAOHBG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct BPFEIHLNCAM : IEquatable<BPFEIHLNCAM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly PHLHMBGDJPB NKMEKLOOCFN;

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public BBGFBJMHCKM NPFANBOBOND
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(BBGFBJMHCKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public CIMPBBNOEAE MJOGDCELAPN
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
		get
		{
			return default(CIMPBBNOEAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	private AGDKOLPOPCA LNADJLMCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x69C9390", Offset = "0x69C7F90", VA = "0x1869C9390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	private PEGAAPFIEAN HPMMLKMIJFG
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x69CD830", Offset = "0x69CC430", VA = "0x1869CD830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public bool EGLGPJKDLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x69CC100", Offset = "0x69CAD00", VA = "0x1869CC100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public Vector3 OCLAILDFLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x69CDE60", Offset = "0x69CCA60", VA = "0x1869CDE60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x69CC480", Offset = "0x69CB080", VA = "0x1869CC480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public Quaternion OJMCLJJHOHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x69CD450", Offset = "0x69CC050", VA = "0x1869CD450")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x69CE410", Offset = "0x69CD010", VA = "0x1869CE410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public Vector3 EOHOOMJOMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x69CE4E0", Offset = "0x69CD0E0", VA = "0x1869CE4E0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x69CC300", Offset = "0x69CAF00", VA = "0x1869CC300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public Quaternion BHIAIJDAHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x69CD0A0", Offset = "0x69CBCA0", VA = "0x1869CD0A0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x69CE160", Offset = "0x69CCD60", VA = "0x1869CE160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public float MFAPAGPDOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x69CDA60", Offset = "0x69CC660", VA = "0x1869CDA60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x69CD2B0", Offset = "0x69CBEB0", VA = "0x1869CD2B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public float LAJFDNOAJCA
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x69CD000", Offset = "0x69CBC00", VA = "0x1869CD000")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public Vector3 CBAPDJBOKEG
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x69CE230", Offset = "0x69CCE30", VA = "0x1869CE230")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x69CD990", Offset = "0x69CC590", VA = "0x1869CD990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public Vector3 FMNJPJOLBNB
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x69CC550", Offset = "0x69CB150", VA = "0x1869CC550")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public Matrix4x4 CMCIDOBOAOE
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x69CD7F0", Offset = "0x69CC3F0", VA = "0x1869CD7F0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x1A515C0", Offset = "0x1A501C0", VA = "0x181A515C0")]
	public BPFEIHLNCAM(PHLHMBGDJPB FFODPEFFKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x69C9780", Offset = "0x69C8380", VA = "0x1869C9780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x69CCD10", Offset = "0x69CB910", VA = "0x1869CCD10", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x69C96B0", Offset = "0x69C82B0", VA = "0x1869C96B0", Slot = "4")]
	public bool Equals(BPFEIHLNCAM OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0A0", Offset = "0x69C8CA0", VA = "0x1869CA0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x69CDF50", Offset = "0x69CCB50", VA = "0x1869CDF50")]
	public CPCCGGOJAEN MKFHNCJPHFE()
	{
		return default(CPCCGGOJAEN);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x69CD590", Offset = "0x69CC190", VA = "0x1869CD590")]
	public void IHLNCKBEGLA([Out] Matrix4x4 DALJHNGMIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x69CC8B0", Offset = "0x69CB4B0", VA = "0x1869CC8B0")]
	public void DCBFOPCIEHK([Out] Vector3 OGJJNMDPFHM, [Out] Quaternion NBGNMMMGFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x69CC800", Offset = "0x69CB400", VA = "0x1869CC800")]
	public void DCBFOPCIEHK([Out] RigidTransform JGDCDEOFBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x69CCDA0", Offset = "0x69CB9A0", VA = "0x1869CCDA0")]
	public void FMNNKGDPCOP([Out] Vector3 OGJJNMDPFHM, [Out] Quaternion NBGNMMMGFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x69CCE80", Offset = "0x69CBA80", VA = "0x1869CCE80")]
	public void FMNNKGDPCOP([Out] RigidTransform JGDCDEOFBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x69CE3E0", Offset = "0x69CCFE0", VA = "0x1869CE3E0")]
	public UniformTRS POMMBNJIMPP()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x69CE320", Offset = "0x69CCF20", VA = "0x1869CE320")]
	public void POMMBNJIMPP([Out] UniformTRS BFJLHHOANID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x69CDFA0", Offset = "0x69CCBA0", VA = "0x1869CDFA0")]
	public UniformTRS OALPFLGFIEM()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x69CDFD0", Offset = "0x69CCBD0", VA = "0x1869CDFD0")]
	public void OALPFLGFIEM([Out] UniformTRS JGDCDEOFBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x69CCAE0", Offset = "0x69CB6E0", VA = "0x1869CCAE0")]
	public Vector3 EPGNGKHHACA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x69CDB00", Offset = "0x69CC700", VA = "0x1869CDB00")]
	public void KAODHAGFBKD([In] Vector3 GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x69CC640", Offset = "0x69CB240", VA = "0x1869CC640")]
	public Vector3 COCIOMJCLMA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x69CC730", Offset = "0x69CB330", VA = "0x1869CC730")]
	public void DBONMFHAKOM([In] Vector3 GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x69CD6B0", Offset = "0x69CC2B0", VA = "0x1869CD6B0")]
	public Quaternion ILCEDCALGHA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x69CD1E0", Offset = "0x69CBDE0", VA = "0x1869CD1E0")]
	public void GOEEBONCFBA([In] Quaternion GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x69CCBD0", Offset = "0x69CB7D0", VA = "0x1869CCBD0")]
	public Quaternion EPJBGGCBOKF()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x69CDCC0", Offset = "0x69CC8C0", VA = "0x1869CDCC0")]
	public void KGHKEKGEEME([In] Quaternion GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x69CCA40", Offset = "0x69CB640", VA = "0x1869CCA40")]
	public float EMMMNFHNGIC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x69CC990", Offset = "0x69CB590", VA = "0x1869CC990")]
	public void EMMFMNAOPDO(float GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x69CD8F0", Offset = "0x69CC4F0", VA = "0x1869CD8F0")]
	public float JKGLFHKLOAG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x69CC3D0", Offset = "0x69CAFD0", VA = "0x1869CC3D0")]
	public void BBAKDKJPFPG(float GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x69CE090", Offset = "0x69CCC90", VA = "0x1869CE090")]
	public void OCDLKGGEOPK([In] Vector3 GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x69CD360", Offset = "0x69CBF60", VA = "0x1869CD360")]
	public Vector3 IBIILFMFBPM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x69CCF30", Offset = "0x69CBB30", VA = "0x1869CCF30")]
	public void FPNLJMEIBHP([In] Vector3 GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x69CDBD0", Offset = "0x69CC7D0", VA = "0x1869CDBD0")]
	public Vector3 KELPNFHCLHP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x69CDD90", Offset = "0x69CC990", VA = "0x1869CDD90")]
	public void KNCBLFLKFFE([In] Vector3 GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x69CC140", Offset = "0x69CAD40", VA = "0x1869CC140")]
	public Vector3 ADHPHFKBGGC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x69CC230", Offset = "0x69CAE30", VA = "0x1869CC230")]
	public void AHIOGFPCOHF([In] Vector3 GLMEMJNJKAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class FPGHNCOCJOH
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private struct MNDGFBAJAEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Guid CICFLOBNFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public JDGKAMGPPCP CBMEBOCDNLA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private struct JDGKAMGPPCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int GLMEMJNJKAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int MFMCKPDJLHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int IGNHBMOEIFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int FONKKFKAFAN;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x69D75D0", Offset = "0x69D61D0", VA = "0x1869D75D0")]
		public bool IEFNCHCIMIO([Out] DDPLMDBOHKM PIOJFCHBCHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x69D7660", Offset = "0x69D6260", VA = "0x1869D7660")]
		public JDGKAMGPPCP(DDPLMDBOHKM PIOJFCHBCHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x69D58E0", Offset = "0x69D44E0", VA = "0x1869D58E0")]
	public static Guid MMOCNIHNFLL(this DDPLMDBOHKM PIOJFCHBCHD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x69D5980", Offset = "0x69D4580", VA = "0x1869D5980")]
	public static bool PCPDHGEFOBB(this Guid CICFLOBNFHG, [Out] DDPLMDBOHKM PIOJFCHBCHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal static class FMGNDHCGLDD
{
	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x69D5780", Offset = "0x69D4380", VA = "0x1869D5780")]
	public static LAADALIJNDM MOEMEJHHHHD(this PHLHMBGDJPB EPKGPGILADI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x69D5810", Offset = "0x69D4410", VA = "0x1869D5810")]
	public static PEEMGFPFANC OENFPIGDKMC(this PHLHMBGDJPB EPKGPGILADI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x69D5680", Offset = "0x69D4280", VA = "0x1869D5680")]
	public static EntityManager MNIGOFNGCJL(this PHLHMBGDJPB EPKGPGILADI)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2AF4D40", Offset = "0x2AF3940", VA = "0x182AF4D40")]
	public static T PLGMBGFHHHD<T>(this PHLHMBGDJPB EPKGPGILADI) where T : struct, IPGDFDBELNL
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x2AF4A80", Offset = "0x2AF3680", VA = "0x182AF4A80")]
	public static bool LMKHBGFFLLP<T>(this PHLHMBGDJPB EPKGPGILADI) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2AF49D0", Offset = "0x2AF35D0", VA = "0x182AF49D0")]
	public static bool FILCLAOMCIG<T>(this PHLHMBGDJPB EPKGPGILADI) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface BIJLCBNDPDM
{
	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ACMGDJGDIGN(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BBHDPMEEMAL(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DKICFMCBFNF(PHLHMBGDJPB FFODPEFFKPK, [Out] Guid DJGLMBCCEPH);

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid IGONNPPCKKG(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FKHCMFCPLEB(PHLHMBGDJPB FFODPEFFKPK, Guid DJGLMBCCEPH);

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EAFHBCNDNJP(PHLHMBGDJPB FFODPEFFKPK, [Out] Guid KJPMBCBOCOO);

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid ALKCGGDIEJK(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JKOKJHDLLAI(PHLHMBGDJPB FFODPEFFKPK, Guid KJPMBCBOCOO);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BFDFAMEGMOJ(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task KIKEBFAAJOC(PHLHMBGDJPB EJMCPAEEGJH, PHLHMBGDJPB GPMGJNAOOEP);
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface DOCBDFIIOCE
{
	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	Guid IALLMEAFGOB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FIAHDBFIIMB(NativeList<Guid> KAOFKLKKOIG, NativeList<Guid> PBBDEBGHHBE, NativeList<FixedString64Bytes> NFCHGINFJAP);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface OADJDJJMHKE
{
	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ABHGCECHFOJ(List<PHLHMBGDJPB> DOHLFFCLMII);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBEIFLJFJGA(List<PHLHMBGDJPB> EHBBFIMCPIA);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DMHDPMDIJEF(PHLHMBGDJPB IGGNOAIAMJB);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NEBBDHPDKIB(PHLHMBGDJPB IGGNOAIAMJB);

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LODGFDCOFAO(PHLHMBGDJPB IGGNOAIAMJB);

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int MFKLGPJPKAM(PHLHMBGDJPB IGGNOAIAMJB);

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GKFNONAIPGJ(PHLHMBGDJPB IGGNOAIAMJB, int OPBLCCPLEKK);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PHLHMBGDJPB JDNNDACIKGN(PHLHMBGDJPB LFILNICLJAO);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GDJJNDDNIBH(PHLHMBGDJPB LFILNICLJAO, PHLHMBGDJPB BEDKFMEIFCA);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JGFNOEJFBOO(PHLHMBGDJPB LFILNICLJAO);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int DEMHJOKLAPK(PHLHMBGDJPB LFILNICLJAO);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OOFKHFCOJAF(PHLHMBGDJPB LFILNICLJAO, int BCKHJCMAHDI);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	int GJKMNAPNFBD(PHLHMBGDJPB LFILNICLJAO);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PIJICKBFBCD(PHLHMBGDJPB LFILNICLJAO, int DJEDNOJEKFK);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FAEEOBMDHBE(PHLHMBGDJPB NKMEKLOOCFN);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MKEBKNMPPIC(PHLHMBGDJPB FFODPEFFKPK, bool NBJGKHPENAA);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OILCOHCILNA(PHLHMBGDJPB[] OCMEKIBCJIK, bool NBJGKHPENAA);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface LBEDGKMPEAF
{
	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	IReadOnlyCollection<MMJHHOKKNMF> CECAJGPIJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PLDLLEIMPEB(int CCJPPHADPEH, [Out] MMJHHOKKNMF FFABADEFODC);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MMJHHOKKNMF GBGEDNBHKLC(Type NCNNODEFPOG);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public static class GGEMBKAIPPG
{
	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2B0F960", Offset = "0x2B0E560", VA = "0x182B0F960")]
	public static T HCPFBEJKCJO<T>(this LBEDGKMPEAF OCDDCHCENFF, Entity NGLCFDBCFFC) where T : struct, IPGDFDBELNL
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2B0ED90", Offset = "0x2B0D990", VA = "0x182B0ED90")]
	public static MMJHHOKKNMF GBGEDNBHKLC<T>(this LBEDGKMPEAF OCDDCHCENFF) where T : struct, IPGDFDBELNL
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface PJDDGGAGIKC
{
	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DDPLMDBOHKM[] PBOJCPMNMFC(string GFLNGGKHEOH, BBGFBJMHCKM BMGMJONGOBL, bool HDBFJALILID = false);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGMNLEONGBJ(string NNDJGABFEBC, DDPLMDBOHKM[] CNAJMFBNAGA);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface GMFOIJLKJDI
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<PHLHMBGDJPB, PHLHMBGDJPB> NOAGIKFPAAH;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<PHLHMBGDJPB, PHLHMBGDJPB> ILCLLLKLIJD;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<PHLHMBGDJPB, PHLHMBGDJPB, PHLHMBGDJPB> EHLJKMEBODI;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<PHLHMBGDJPB> LKPHGDNKPMM;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LLLPNFNGCHK(PHLHMBGDJPB FFODPEFFKPK, PHLHMBGDJPB KELJNLNAABF);

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PHLHMBGDJPB LFFGCGHHNBE(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<PHLHMBGDJPB> JJBFNGEMJCJ(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	PHLHMBGDJPB ALCMBFGEBPE(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void POFENMKJANK(PHLHMBGDJPB FFODPEFFKPK, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ);

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JGHAHEEPMCN(PHLHMBGDJPB FFODPEFFKPK, float GOMEDJNNMDN);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool NMKGIMAIHMI(PHLHMBGDJPB FFODPEFFKPK, [Out] PHLHMBGDJPB GPMGJNAOOEP);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool AEHJPANNKAI(PHLHMBGDJPB FFODPEFFKPK, [Out] RigidTransform GHHDAKIAGJA);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool OMLLHEOGMCB(PHLHMBGDJPB FFODPEFFKPK, [Out] float OADBPACFMDK);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 AFJOLMFIMIK(MAIBLCHFCHO LOAHLPFCCII);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	quaternion NJCNHMKDELN(MAIBLCHFCHO LOAHLPFCCII);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class HHBEOHGPJPH
{
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface IIEIDIJGFMF
{
	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	object BLANOHFGBOM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FHECANLGHKE(HDPBPBEDBGP OCMEKIBCJIK);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct DDMIIEHPFFE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly string GFLNGGKHEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly T NJMAFDCOBGL;

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x57C7850", Offset = "0x57C6450", VA = "0x1857C7850")]
	public DDMIIEHPFFE(T NJMAFDCOBGL, [Optional][CallerMemberName] string GFLNGGKHEOH)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly DDMIIEHPFFE<int> MJAHDFMKHCG;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public enum MLLCOHNCJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class GOLFPIBNELK
{
	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0xD613E0", Offset = "0xD5FFE0", VA = "0x180D613E0")]
	public static bool CNDHFBEAHOF(this MLLCOHNCJBK GJEHPOMDLIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0xD613F0", Offset = "0xD5FFF0", VA = "0x180D613F0")]
	public static bool FELHEAEEGOG(this MLLCOHNCJBK GJEHPOMDLIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x2501DD0", Offset = "0x25009D0", VA = "0x182501DD0")]
	public static bool LAHJECDIFEO(this MLLCOHNCJBK GJEHPOMDLIP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface EPNDEDFGKDO
{
	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	bool BALOEODMOGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface BGPNIJCCIDK
{
	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	MLLCOHNCJBK KAPHIFHGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	MLLCOHNCJBK KLPACBHCBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	MLLCOHNCJBK AIIIFAEPLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	MLLCOHNCJBK HCPCNLFLPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	MLLCOHNCJBK NADADMMFMOO
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	MLLCOHNCJBK GLANMJNBDKA
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	MLLCOHNCJBK ANFFACBPHGI
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	MLLCOHNCJBK FJECJIFLHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	MLLCOHNCJBK PDHLOPOHHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	MLLCOHNCJBK CKDOJLKAOAN
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	MLLCOHNCJBK JOEDNDACEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	MLLCOHNCJBK IMFEHJKPIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	MLLCOHNCJBK GEMLMMAKIBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	MLLCOHNCJBK JPJCPPNDLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	MLLCOHNCJBK MNMGOPHMGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int HCNFCFFAFEI(DDMIIEHPFFE<int> BPPGADPMEGH);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface PKFMNIKNNCC
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<OOBHMNCCLGF> FIBKIPFLNML;

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PHLHMBGDJPB LPEACFDCGIP(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AJAENAPFFLC(List<PHLHMBGDJPB> EHBBFIMCPIA);

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CBNCODLAAAJ GFIHLFALFFI(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CBNCODLAAAJ JOEFFKLPFCD(PHLHMBGDJPB GPMGJNAOOEP, PHLHMBGDJPB AIFEMCDFFGN, bool HOJFKDCOANL, PHLHMBGDJPB PJIFCLGMLOL);

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PHLHMBGDJPB JBKFGMBCAFH(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool INMMMEFJOBK(PHLHMBGDJPB FFODPEFFKPK, PHLHMBGDJPB GPMGJNAOOEP, bool OMBLHEEJENF);

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HMEBBMJDCCI(PHLHMBGDJPB FFODPEFFKPK, PHLHMBGDJPB GPMGJNAOOEP);

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GIOGFIDDKNB(PHLHMBGDJPB KKPLOEPOFGC, PHLHMBGDJPB JKOFHMPLHDK);

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int KJBKOFPFAIB(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HDPBPBEDBGP MADOKJGMNNO(PHLHMBGDJPB NKMEKLOOCFN);

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NativeArray<PHLHMBGDJPB> HJEMEJMDGHJ(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool MFEBLIOHFGJ(PHLHMBGDJPB FFODPEFFKPK, PHLHMBGDJPB CNLKKJAGMEP);

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<PHLHMBGDJPB> FAEIIDLCJNJ(PHLHMBGDJPB FFODPEFFKPK, bool MFLHCGPFFCL = false);

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool OGNDBFIBJJE(PHLHMBGDJPB FFODPEFFKPK, PHLHMBGDJPB EDBAEOCEHON);

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "16")]
	PHLHMBGDJPB PIJGFFCLGCF(PHLHMBGDJPB PJIFCLGMLOL, PHLHMBGDJPB FCNHBACGFAM);

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool BGLMNMOFDKB(PHLHMBGDJPB PJIFCLGMLOL, PHLHMBGDJPB FCNHBACGFAM, [Out] PHLHMBGDJPB HNHAIPADCBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public static class FLPFNEFJJDB
{
	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x69D5500", Offset = "0x69D4100", VA = "0x1869D5500")]
	public static List<PHLHMBGDJPB> AJAENAPFFLC(this PKFMNIKNNCC BCEHGAICLHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x69D5610", Offset = "0x69D4210", VA = "0x1869D5610")]
	public static bool KANIPLBECCM(this PKFMNIKNNCC BCEHGAICLHK, PHLHMBGDJPB FFODPEFFKPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface HPADFHGNAHD
{
	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JKBEILLLHJC HAAMJJHDNDH(PHLHMBGDJPB IGGNOAIAMJB);

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OEPJJBANBOG(PHLHMBGDJPB IGGNOAIAMJB, JKBEILLLHJC FGMGEGFGJIA);

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JNLGBDAFGDO(PHLHMBGDJPB IGGNOAIAMJB);

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PHJJGKGDEBP(PHLHMBGDJPB IGGNOAIAMJB, bool GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string[] NIHEABIIHKO(PHLHMBGDJPB IGGNOAIAMJB);

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NAOIPKAELFF(PHLHMBGDJPB IGGNOAIAMJB, IEnumerable<string> JFFGADICANO);

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string[] PCLJGNBAGKH(PHLHMBGDJPB IGGNOAIAMJB);

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IEAAGPMIFAE(PHLHMBGDJPB IGGNOAIAMJB, IEnumerable<string> JFFGADICANO);

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "8")]
	string[] GEAMLMOJGOJ(PHLHMBGDJPB IGGNOAIAMJB);

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MLFNHGNHDFI(PHLHMBGDJPB IGGNOAIAMJB, IEnumerable<string> JFFGADICANO);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string[] PHCDPDDKCBG(PHLHMBGDJPB IGGNOAIAMJB);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KDGPMIEFLHL(PHLHMBGDJPB IGGNOAIAMJB, IEnumerable<string> JFFGADICANO);

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool DLNCCGALJDB(PHLHMBGDJPB IGGNOAIAMJB, PHLHMBGDJPB KBMFHBINANN);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface LLEKIKBNFOB
{
	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	bool DHDLOIMOGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	bool IAAFALDFBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface JOMEIBCMHEE : MCADIIHAMDO
{
	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MPOHGBGNPGI(Entity NGLCFDBCFFC, [Out] CGLJGMDOLIG POAHFHMMEAF);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FEMDGJPNJDD(NativeArray<CGLJGMDOLIG> DACJNHAOMKL, NativeArray<IPFAGJCOPOO> AKMEOKEDLJG);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void APOFCHFILLI(CGLJGMDOLIG POAHFHMMEAF);

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DCHLLHFEHNM(CGLJGMDOLIG POAHFHMMEAF, [Out] Collider FJEKLDBPJED);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface MCADIIHAMDO
{
	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OCNNMABHDCD([In] float3 JJNNAHKJEAK, [In] float3 ALGFLILJAIC, float CEGICKHHGEL, Allocator BLMBIIGOJPG, [Out] NativeArray<Entity> NBNHBNDLFMG);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface LHOAMCKABGN
{
	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OCNNMABHDCD([In] float3 JJNNAHKJEAK, [In] float3 ALGFLILJAIC, float CEGICKHHGEL, [Out] GFAMKNDKBAH MJCAFGOGLJL, [Out] PHLHMBGDJPB KPFKIOCNACH);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface DOPENPNHPFL
{
	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCNNMABHDCD([In] NativeArray<Entity> NBNHBNDLFMG, [In] float3 JJNNAHKJEAK, [In] float3 ALGFLILJAIC, [In] NativeArray<GFAMKNDKBAH> CNAGHPOKDEL);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct CGLJGMDOLIG : MJOKIKKGNLI, IEquatable<CGLJGMDOLIG>
{
	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public int HDEPOMLIBHF
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x916930", Offset = "0x915530", VA = "0x180916930", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0xA63EA0", Offset = "0xA62AA0", VA = "0x180A63EA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public int LEANFGGOJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x251F470", Offset = "0x251E070", VA = "0x18251F470", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x5CE1680", Offset = "0x5CE0280", VA = "0x185CE1680", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x69CFC10", Offset = "0x69CE810", VA = "0x1869CFC10", Slot = "8")]
	public bool Equals(CGLJGMDOLIG OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x69CFC60", Offset = "0x69CE860", VA = "0x1869CFC60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct GFAMKNDKBAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float JMIELJENIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 KLEPCPADMKG;
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface HJHOGFFEJAO
{
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface AGDKOLPOPCA
{
	[Cpp2IlInjected.Token(Token = "0x17000191")]
	LAADALIJNDM MOEMEJHHHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	DIIGHFDBNIN BKFDBPBMPNM
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<HDPBPBEDBGP, NativeArray<KGAFPCDNLAE>> BINNCECBODB;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<HDPBPBEDBGP> MNGFFLPFHJI;

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BKOKLOEODFF NOGBFLNHOCK(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KGAFPCDNLAE FDJDCDIEHFI(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FHCDBNBHAOK(DDPLMDBOHKM PIOJFCHBCHD, BGNCMHHLOJM OHJHPCELAOK);

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CKDPFFCLBFK(DDPLMDBOHKM[] CNAJMFBNAGA, GameObject OLFFLDPKCIP);

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BBGFBJMHCKM CALPDMBLOON(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CAJPMGCKEGG(PHLHMBGDJPB FFODPEFFKPK, [Out] Transform KHIOEALLADK);

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool BJDHGOIKFMA(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OFEGGCJCFEH(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "14")]
	PHLHMBGDJPB EAKGCJIPOED(DDPLMDBOHKM PIOJFCHBCHD);

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool EPILHKNOGLD(DDPLMDBOHKM PIOJFCHBCHD, [Out] PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "16")]
	DDPLMDBOHKM ALFEKABCLFN(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "17")]
	HDPBPBEDBGP EAKGCJIPOED(NativeArray<DDPLMDBOHKM> PIOJFCHBCHD, Allocator BLMBIIGOJPG);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "18")]
	HDPBPBEDBGP IFLJAJPCNPG(KGAFPCDNLAE BNEADFDDBLJ, int HDFABDCMCAG, Allocator BLMBIIGOJPG);

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "19")]
	HDPBPBEDBGP HKFACBMOAMK(NativeArray<DDPLMDBOHKM> PIOJFCHBCHD, NativeArray<HHADOOHOBAN> NEMCGOBFNOA, Allocator BLMBIIGOJPG);

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "20")]
	DDPLMDBOHKM[] PBOJCPMNMFC(string NNDJGABFEBC, BBGFBJMHCKM BMGMJONGOBL, bool HDBFJALILID);

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void JGMNLEONGBJ(string NNDJGABFEBC, DDPLMDBOHKM[] CNAJMFBNAGA);

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "22")]
	BBGFBJMHCKM BAICPAEEANB(KGAFPCDNLAE BNEADFDDBLJ, bool PPHEAFFOJJC);

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "23")]
	BBGFBJMHCKM BAICPAEEANB(KGAFPCDNLAE BNEADFDDBLJ);

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "24")]
	BBGFBJMHCKM COOIAHILJIB(KGAFPCDNLAE BNEADFDDBLJ);

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "25")]
	BBGFBJMHCKM PAMJAPBJCFC(KGAFPCDNLAE BNEADFDDBLJ);

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(Slot = "26")]
	BBGFBJMHCKM FFGKBGGFJOM(DDPLMDBOHKM PIOJFCHBCHD, KGAFPCDNLAE BNEADFDDBLJ);

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "27")]
	BMPHEBHOCLC ENPMOGIHJBG();

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "28")]
	EEHLMFIBPKA AKEICHPIIHP();

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "29")]
	NANDHBFEAAP MAFKEABAJIG(IPMKGJBCEGN OBBKEJHJKND);

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void OKNFFCDFMEO(HDPBPBEDBGP OCMEKIBCJIK);

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void IICIADDLCDE(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void OMLOLGJCMEI(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void OKNFFCDFMEO(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void AGANFKPEELE(PHLHMBGDJPB OCMEKIBCJIK);

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool HLBGILIKEIP(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "36")]
	HDPBPBEDBGP EJEMNCOOIHB(HDPBPBEDBGP KOICMCFMHJM, Allocator BLMBIIGOJPG);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool OKKJPEEAMCN(PHLHMBGDJPB FFODPEFFKPK);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class JFFLOJPCMNJ
{
	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x69D7C90", Offset = "0x69D6890", VA = "0x1869D7C90")]
	public static void OFEGGCJCFEH(this AGDKOLPOPCA KAMJHGKBFDK, BGNCMHHLOJM OHJHPCELAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x69D7A10", Offset = "0x69D6610", VA = "0x1869D7A10")]
	public static BBGFBJMHCKM KOCFCAFCPFO(this AGDKOLPOPCA KAMJHGKBFDK, LocalId FFODPEFFKPK)
	{
		return default(BBGFBJMHCKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x69D7B30", Offset = "0x69D6730", VA = "0x1869D7B30")]
	public static BBGFBJMHCKM KOCFCAFCPFO(this AGDKOLPOPCA KAMJHGKBFDK, DDPLMDBOHKM PIOJFCHBCHD)
	{
		return default(BBGFBJMHCKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x69D7A10", Offset = "0x69D6610", VA = "0x1869D7A10")]
	public static PHLHMBGDJPB EAKGCJIPOED(this AGDKOLPOPCA KAMJHGKBFDK, LocalId FFODPEFFKPK)
	{
		return default(PHLHMBGDJPB);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x69D76A0", Offset = "0x69D62A0", VA = "0x1869D76A0")]
	public static DDPLMDBOHKM ALFEKABCLFN(this AGDKOLPOPCA KAMJHGKBFDK, LocalId FFODPEFFKPK)
	{
		return default(DDPLMDBOHKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x69D7D10", Offset = "0x69D6910", VA = "0x1869D7D10")]
	public static bool OKKJPEEAMCN(this AGDKOLPOPCA KAMJHGKBFDK, DDPLMDBOHKM PIOJFCHBCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x2B966B0", Offset = "0x2B952B0", VA = "0x182B966B0")]
	public static T AJAJOLNKCHO<T>(this AGDKOLPOPCA KAMJHGKBFDK, LocalId FFODPEFFKPK) where T : struct, IPGDFDBELNL
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x69D7720", Offset = "0x69D6320", VA = "0x1869D7720")]
	public static BMPHEBHOCLC BAADEEACDDP(this AGDKOLPOPCA KAMJHGKBFDK, RigidTransform BFJLHHOANID)
	{
		return default(BMPHEBHOCLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x69D7B90", Offset = "0x69D6790", VA = "0x1869D7B90")]
	public static NANDHBFEAAP NDMLLLBEKBK(this AGDKOLPOPCA KAMJHGKBFDK, IPMKGJBCEGN KLKPLIAGPJD, RigidTransform BFJLHHOANID)
	{
		return default(NANDHBFEAAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x69D7A40", Offset = "0x69D6640", VA = "0x1869D7A40")]
	public static EEHLMFIBPKA FFBECKCECEF(this AGDKOLPOPCA KAMJHGKBFDK, RigidTransform BFJLHHOANID)
	{
		return default(EEHLMFIBPKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x69D7810", Offset = "0x69D6410", VA = "0x1869D7810")]
	private static void BPFAMHMPMLO(BBGFBJMHCKM IBDHKNOJDGE, RigidTransform BFJLHHOANID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface BEHODOPNIEL
{
	[Cpp2IlInjected.Token(Token = "0x17000193")]
	bool LCGMCBMBFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	PHLHMBGDJPB DABJICNPCFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	BBGFBJMHCKM LECLEJKPGKC
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event IDGFJENEDOH FMFBDLNPDCO;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PHLHMBGDJPB PIJGFFCLGCF(PHLHMBGDJPB PJIFCLGMLOL, PHLHMBGDJPB FCNHBACGFAM);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BGLMNMOFDKB(PHLHMBGDJPB PJIFCLGMLOL, PHLHMBGDJPB FCNHBACGFAM, [Out] PHLHMBGDJPB HNHAIPADCBJ);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GLPOMFLBFLN();

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PMCCJKDFJDH();

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool JNDHKCAKJFI(PHLHMBGDJPB PJIFCLGMLOL);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool CMFHCKJALKC(PHLHMBGDJPB PJIFCLGMLOL);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public delegate void IDGFJENEDOH(BBGFBJMHCKM LKFKACCBCME, BBGFBJMHCKM KIMMGICMGJF);
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class HBCDOALDBAD
{
	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x69D5EE0", Offset = "0x69D4AE0", VA = "0x1869D5EE0")]
	public static bool OLKDGFEMPHF(this BEHODOPNIEL OBMBKJIBJBG, BBGFBJMHCKM PJIFCLGMLOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x69D5E00", Offset = "0x69D4A00", VA = "0x1869D5E00")]
	public static bool LEGFMLCPNCP(this BEHODOPNIEL OBMBKJIBJBG, PHLHMBGDJPB PJIFCLGMLOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x69D5D80", Offset = "0x69D4980", VA = "0x1869D5D80")]
	public static bool FJJKKOKPPIE(this BEHODOPNIEL OBMBKJIBJBG, PHLHMBGDJPB PJIFCLGMLOL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface MCNBHCFGCFL
{
	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NGLLHJIBBAL(BBGFBJMHCKM IBDHKNOJDGE, LECJGOBHOND OLADDMOOKPM, List<BBGFBJMHCKM> JDPGDKPFNJF);

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int GLENIBNKFNG(BBGFBJMHCKM IBDHKNOJDGE, LECJGOBHOND OLADDMOOKPM);

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MFFIAHKKDBK(BBGFBJMHCKM IBDHKNOJDGE, List<BBGFBJMHCKM> JDPGDKPFNJF);

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HNKMEOEHJLO(BBGFBJMHCKM ONIAHHAAJEH, BBGFBJMHCKM PJIFCLGMLOL, LECJGOBHOND OLADDMOOKPM);

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BBGFBJMHCKM HPDDHGBMMLI(BBGFBJMHCKM ONIAHHAAJEH, int OPDMGNJCACB, LECJGOBHOND OLADDMOOKPM);

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JNGDMHIAKLJ(BBGFBJMHCKM ONIAHHAAJEH, BBGFBJMHCKM PJIFCLGMLOL, LECJGOBHOND OLADDMOOKPM);

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool IHAIEIGBCGP(BBGFBJMHCKM ONIAHHAAJEH, BBGFBJMHCKM PJIFCLGMLOL, LECJGOBHOND OLADDMOOKPM);

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AFMHNNABBAI(BBGFBJMHCKM ONIAHHAAJEH, LECJGOBHOND OLADDMOOKPM);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GEKEFMEEOKP(BBGFBJMHCKM ONIAHHAAJEH, BBGFBJMHCKM PJIFCLGMLOL, LECJGOBHOND OLADDMOOKPM);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FOJIOMPAJFE(Entity ONIAHHAAJEH, Entity PJIFCLGMLOL, LECJGOBHOND OLADDMOOKPM);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HKCCIKCEFEC(Entity ONIAHHAAJEH, LECJGOBHOND OLADDMOOKPM);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface BAMEJPKFIFI
{
	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMLPHFBCNBO(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HNKGCNNFCCF(PHLHMBGDJPB FFODPEFFKPK, Transform KHIOEALLADK);
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface KFEPGCIEIDC
{
	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AEPKDACOKPG(PHLHMBGDJPB PJIFCLGMLOL, PHLHMBGDJPB JHHENFAIBDG);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EPLNLLIBKNC(PHLHMBGDJPB PJIFCLGMLOL, PHLHMBGDJPB KEDHPDODLIE);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DKCNFOFGONM(PHLHMBGDJPB PJIFCLGMLOL, [Out] PHLHMBGDJPB MNBACMNKJON);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface LDBFHNNICCO
{
	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IELBOCKCEGL(PHLHMBGDJPB NKMEKLOOCFN, bool GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EEHPEKHFEMF(PHLHMBGDJPB NKMEKLOOCFN, bool GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DNMOEHABABC(PHLHMBGDJPB NKMEKLOOCFN, int GLMEMJNJKAN);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface GIKIIGOKLLC
{
	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<PHLHMBGDJPB> GEFLLIHJBLN(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PHLHMBGDJPB DKJPLGLLFDK(PHLHMBGDJPB FFODPEFFKPK, int OPDMGNJCACB);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int KMOHMEEIDMJ(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OFPOAEGCOLE GJJPEFCCNGD(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GEEDBNCABBO(PHLHMBGDJPB FFODPEFFKPK, OFPOAEGCOLE ENFOCCMDNKP);

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PHLHMBGDJPB OJMPCDAGMHE(PHLHMBGDJPB FFODPEFFKPK, [Optional] float3? DFPHDEDIHFK, [Optional] quaternion? DELGPMLKBMI, [Optional] float3? IADPMFLONGE);

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PHLHMBGDJPB GDFIPGHNGOB(PHLHMBGDJPB FFODPEFFKPK, int OPDMGNJCACB, [Optional] float3? DFPHDEDIHFK, [Optional] quaternion? DELGPMLKBMI, [Optional] float3? IADPMFLONGE);

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DDANBNNHGBL(PHLHMBGDJPB FFODPEFFKPK, int OPDMGNJCACB);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HPCIAMIPGGM(PHLHMBGDJPB FFODPEFFKPK);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface PHPFCEGINBO
{
	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDPDLLLDOJF();

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIEMAKMDGIH();

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MIPGJDDNEBN();

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JGBKGDPHFOK();

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NPLDAJIMPPO();

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LCMAJMKCHLF();

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LOGDPFKHKOK();

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LJLKANDCMAN();

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FIODMPJGFAG();

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FOKBJGEBKEH();

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CMKLMOJEFAK();

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CMNIFDKJMKP();

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GNLNDBNPFIB();
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface DBIOJFOONBD
{
	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NCLGOPDJCDC(PHLHMBGDJPB PJIFCLGMLOL, [Out] int ONIAHHAAJEH);

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LFBCPLACOCH(PHLHMBGDJPB PJIFCLGMLOL, int ONIAHHAAJEH);

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OPLFAFLLLAM(PHLHMBGDJPB PJIFCLGMLOL, bool MOAICLIJDKD);

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NNJKJICBIJB(PHLHMBGDJPB PJIFCLGMLOL, bool IMMCDALLIFO);

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PLKJOOOANIC(PHLHMBGDJPB PJIFCLGMLOL, float FJCGOBLIPDF, float BDKHHIDEJKA, float NAFDOOEEGDD);

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IOMOPJDELEH(PHLHMBGDJPB FFODPEFFKPK, [Out] float BDKHHIDEJKA, [Out] float NAFDOOEEGDD);

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JBALOAEICFG(PHLHMBGDJPB PJIFCLGMLOL, float3 DFPHDEDIHFK, quaternion DELGPMLKBMI);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OPGGBEEMEFC(PHLHMBGDJPB PJIFCLGMLOL, [Out] float3 DFPHDEDIHFK, [Out] quaternion DELGPMLKBMI);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface PEGAAPFIEAN
{
	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CNLDMLFKAAM(Entity NGLCFDBCFFC);

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KAODHAGFBKD(Entity NGLCFDBCFFC, [In] float3 GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 EPGNGKHHACA(Entity NGLCFDBCFFC);

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GOEEBONCFBA(Entity NGLCFDBCFFC, [In] quaternion GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion ILCEDCALGHA(Entity NGLCFDBCFFC);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DCBFOPCIEHK(Entity NGLCFDBCFFC, [Out] float3 DFPHDEDIHFK, [Out] quaternion DELGPMLKBMI);

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DCBFOPCIEHK(Entity NGLCFDBCFFC, [Out] RigidTransform JJMNGKHFGKD);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FMNNKGDPCOP(Entity NGLCFDBCFFC, [Out] float3 DFPHDEDIHFK, [Out] quaternion DELGPMLKBMI);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FMNNKGDPCOP(Entity NGLCFDBCFFC, [Out] RigidTransform JJMNGKHFGKD);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	float3 INEGFDPOIDJ(Entity NGLCFDBCFFC);

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OCDLKGGEOPK(Entity NGLCFDBCFFC, [In] float3 GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EMMFMNAOPDO(Entity NGLCFDBCFFC, float GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float EMMMNFHNGIC(Entity NGLCFDBCFFC);

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KNCBLFLKFFE(Entity NGLCFDBCFFC, [In] float3 GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	float3 KELPNFHCLHP(Entity NGLCFDBCFFC);

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DBONMFHAKOM(Entity NGLCFDBCFFC, [In] float3 GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 COCIOMJCLMA(Entity NGLCFDBCFFC);

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KGHKEKGEEME(Entity NGLCFDBCFFC, [In] quaternion GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "18")]
	quaternion EPJBGGCBOKF(Entity NGLCFDBCFFC);

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 IBIILFMFBPM(Entity NGLCFDBCFFC);

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void FPNLJMEIBHP(Entity NGLCFDBCFFC, [In] float3 GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BBAKDKJPFPG(Entity NGLCFDBCFFC, float GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float JKGLFHKLOAG(Entity NGLCFDBCFFC);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void AHIOGFPCOHF(Entity NGLCFDBCFFC, [In] float3 GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(Slot = "24")]
	float3 ADHPHFKBGGC(Entity NGLCFDBCFFC);

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void ELHKJECGBNK(Entity NGLCFDBCFFC, [Out] float4x4 DALJHNGMIBO);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void FGPNDKPDICN(Entity NGLCFDBCFFC, [In] float4x4 DALJHNGMIBO);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void EODFKEMEDBF(Entity NGLCFDBCFFC, [Out] float4x4 DALJHNGMIBO);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool CAJPMGCKEGG(Entity NGLCFDBCFFC, [Out] Transform KHIOEALLADK);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void JHPPDEMLHPI(Entity NGLCFDBCFFC);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void CEIEEAFNPCI(Entity NGLCFDBCFFC, Entity PPDINOJPANB, Entity IAAJMIGCLIP);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class HJKPFMMJABN
{
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface KJMNLHCMMLG
{
	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PHGHNFMBGGO(bool JABMDCHHMKH);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface KFONCDFCNBN
{
	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FFNHNEEIHAP(PHLHMBGDJPB IGGNOAIAMJB, IEnumerable<string> JFFGADICANO);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IMDIMFEGFKF(PHLHMBGDJPB IGGNOAIAMJB, IEnumerable<string> JFFGADICANO);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void POJIDEICCHC(PHLHMBGDJPB IGGNOAIAMJB, params string[] JFFGADICANO);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BMBPBBKPJPJ(PHLHMBGDJPB IGGNOAIAMJB, params string[] JFFGADICANO);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AOBKHNLACPI(PHLHMBGDJPB IGGNOAIAMJB, params string[] JFFGADICANO);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IGJOFDHDCIB(PHLHMBGDJPB IGGNOAIAMJB, params string[] JFFGADICANO);

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int KNMCCHHKNHB(PHLHMBGDJPB IGGNOAIAMJB);

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int IIMIKLFEFPK(PHLHMBGDJPB IGGNOAIAMJB);

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DGNCNOIKJEJ(PHLHMBGDJPB IGGNOAIAMJB, ICollection<string> CEBJBEGAIBF);

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FKNGAGOALOG(PHLHMBGDJPB IGGNOAIAMJB, ICollection<string> CEBJBEGAIBF);

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool CMGNLLOHEEL(PHLHMBGDJPB IGGNOAIAMJB, string HGIJFHOADFN);

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LJGPJEJKCIE(string HGIJFHOADFN, CODGPKCCPEF IGKBIHAFMDE);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HDPAJLHFNOI(string HGIJFHOADFN, CODGPKCCPEF IGKBIHAFMDE);

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool AENINAFBNIF();

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HNDNBBBOPAN(IEnumerable<string> JFFGADICANO);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface DIOBKLNEBBO
{
	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World IAOICHAIBHK(string FJJMABLMNHA = "Main");

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World NGIBKIPBAEN(string FJJMABLMNHA = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World HKKBCMLLJPJ(string FJJMABLMNHA = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World OHMPIIHEGDA(string FJJMABLMNHA = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface PEEMGFPFANC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000196")]
	World CEDGBMIAALG
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	World ONFHCEICAHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	EntityManager MNIGOFNGCJL
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	bool INNHKJOMFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase HANPBBBBFOE(Type NCNNODEFPOG);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class DKECJEAKPHB
{
	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x69D2950", Offset = "0x69D1550", VA = "0x1869D2950")]
	public static ComponentSystemBase KECNKIADJBA(this World BKIPEHEIIHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x29301D0", Offset = "0x292EDD0", VA = "0x1829301D0")]
	public static T HANPBBBBFOE<T>(this PEEMGFPFANC KGALMGBOABL) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface EBIIKHEFLEE
{
	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DLABJJBKAOI(NativeListAsync<Entity> JGDEKKBMNAN);

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KBDCACODOEN(FPCNFKGFCHF JCPJNDBIJFL);

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HGNMCGGKMME(NativeListAsync<Entity> OGBOCLKIIAE, bool FOMOAOKCEDD);

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IPMJEEOHKDH();
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface AFHDMKPDBEH
{
	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AOGLPONMOAG(Collider FJEKLDBPJED, [Out] CJCHPKAMHAP KGNIOEPGGHA);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface IHKDKLHNPMB
{
	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EBIKLGPPGGG(PHLHMBGDJPB FFODPEFFKPK, [Out] Collider FJEKLDBPJED);

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject NAODKFNAHLP(PHLHMBGDJPB GKKMAJJBIJG, GameObject ICDGFAMNJCJ, Vector3 FKKCBKBCNEL, Quaternion MFHPKPAOAAP);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GOMMHNNOGII(GameObject FJEKLDBPJED);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider APGJMDKFGIN<TCollider>(GameObject APGMCKJNCKO) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FBHPFEIPKAF(Collider FJEKLDBPJED);

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject MCKNJBDCMOA<TCollider>(string GFLNGGKHEOH) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public enum IJLLPDJANKN
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface OPCEADHOOKK
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public struct PAJOACNEHHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int HACODLOFMLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public GameObject ICDGFAMNJCJ;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GEFMAPBPCKB(PHLHMBGDJPB FFODPEFFKPK, EEBCFHBCHAF FGLEEHGIMCE, bool BKDOPOINBED, KLJFOIFHPPB IPCKLBBBNBO);

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNNMAJNOALA(PHLHMBGDJPB FFODPEFFKPK, EEBCFHBCHAF FGLEEHGIMCE, bool BKDOPOINBED, bool HGHGMABHHAJ, bool HEDLCGJLMLC);

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BLGKAGCDBDF ALCCCGDJPGG(PHLHMBGDJPB BLPDMPJLPPJ, List<PHLHMBGDJPB> NENKENCFIFI);

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AENCOIFIHHE(GameObject JEEKHJDHKMN, GameObject EANGAPDDLDD);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void COHALLEOPJB(GameObject JEEKHJDHKMN, [In] FLCPOFJGBNN<GameObject> IPKGNMIEBNB);

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AHGPPGHEDMO(GameObject EANGAPDDLDD);

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T APGJMDKFGIN<T>(GameObject APGMCKJNCKO) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FBHPFEIPKAF(Collider FJEKLDBPJED);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NILAHMDCILN(HDPBPBEDBGP FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GDPCJNHLIHM(HDPBPBEDBGP FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GameObject PBJPDILLPKF<T>(string GFLNGGKHEOH) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IPPHDHMGGPH(Collider FJEKLDBPJED, [Out] PHLHMBGDJPB ONIAHHAAJEH);

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool DGJKBPECKOH(PHLHMBGDJPB FFODPEFFKPK, [Out] CJCHPKAMHAP KGNIOEPGGHA);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<IJLLPDJANKN> NKFAPGELADA(Allocator BLMBIIGOJPG = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Mesh[] GCGIEACLDMM();

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int ICMJPBJCKIM(EEBCFHBCHAF FGLEEHGIMCE);

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string CGIHODKOEJP(EEBCFHBCHAF FGLEEHGIMCE);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface CNPDJOPOOEN
{
	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LEMHFMODGPL(PHLHMBGDJPB FFODPEFFKPK, PHLHMBGDJPB GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BLPBDNHKHGC(PHLHMBGDJPB FFODPEFFKPK, PHLHMBGDJPB GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int KJBKOFPFAIB(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PHLHMBGDJPB AIKBLINKLIA(PHLHMBGDJPB FFODPEFFKPK, int OPDMGNJCACB);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HDPBPBEDBGP CAACGKPILLB(PHLHMBGDJPB FFODPEFFKPK, Allocator BLMBIIGOJPG = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GJHCBBMPMPI(PHLHMBGDJPB FFODPEFFKPK, object FGIAGALCIAP, PHLHMBGDJPB GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BFGFMEHPLFH(PHLHMBGDJPB FFODPEFFKPK, object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool KLFHLGNOIIN(PHLHMBGDJPB FFODPEFFKPK, [Out] PHLHMBGDJPB GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NCIBBJPNMLI(PHLHMBGDJPB FFODPEFFKPK, float3 GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool CEEPLBPOEKG(PHLHMBGDJPB FFODPEFFKPK, [Out] float3 GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PJOHDOJHDNN(PHLHMBGDJPB FFODPEFFKPK, float3 GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OHGODGEINJD(PHLHMBGDJPB FFODPEFFKPK, [Out] float3 GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GFBLALMCHHA(PHLHMBGDJPB FFODPEFFKPK, (Quaternion rot, Vector3 moments) FGLOGFKAGCE);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool HDBLMFCHDKG(PHLHMBGDJPB FFODPEFFKPK, [Out] quaternion JLMIPDKPKDA, [Out] float3 AFKNBDCFOJN);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AKKJGAHDMHC(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 JJJCKOLOIGJ(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 KLNEBBGJKID(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EDFDIBIJEEB(PHLHMBGDJPB FFODPEFFKPK, float3 GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MCNIFCLNECN(PHLHMBGDJPB FFODPEFFKPK, float3 GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float GALHLPIFJMN(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float AABJFHMLJHI(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void AGGFNPCHGFI(PHLHMBGDJPB FFODPEFFKPK, float GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void LLPBFMHCMKP(PHLHMBGDJPB FFODPEFFKPK, float GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode EFJOBEODAPO(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void NPOMJLGIBMF(PHLHMBGDJPB FFODPEFFKPK, CollisionDetectionMode GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "25")]
	EHMENGICDDK FMOGNMKCNFD(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DCEOOBGGJGH(PHLHMBGDJPB FFODPEFFKPK, EHMENGICDDK GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool JJCIJLBHBDB(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void KIJNHKCOFMM(PHLHMBGDJPB FFODPEFFKPK, bool GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "29")]
	PHLHMBGDJPB LPEACFDCGIP(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void HOPKKAFFANJ(PHLHMBGDJPB FFODPEFFKPK, PHLHMBGDJPB GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "31")]
	PHLHMBGDJPB JBKFGMBCAFH(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void INMMMEFJOBK(PHLHMBGDJPB FFODPEFFKPK, PHLHMBGDJPB GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "33")]
	IIIFFGPCIFG NDFLAPPCNOM(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void CAMNCLCCLGK(PHLHMBGDJPB FFODPEFFKPK, IIIFFGPCIFG DPJMCLAAMAE);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool EECIMJHGLJD(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void JFICHJLHOIF(PHLHMBGDJPB FFODPEFFKPK, bool GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool FCDKLOELOGI(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void OOGAJKHJDNO(PHLHMBGDJPB FFODPEFFKPK, bool GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints NLMDKMJNLOF(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void ILEFIAOHLCO(PHLHMBGDJPB FFODPEFFKPK, RigidbodyConstraints GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float OLBGFNJLFKL(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void CGCNEJDDLGG(PHLHMBGDJPB FFODPEFFKPK, float GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float NGKDOMLAHEF(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void OKOLJGIHKHC(PHLHMBGDJPB FFODPEFFKPK, float GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool EPKLLKAMBCN(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void BEOCBDHPLAM(PHLHMBGDJPB FFODPEFFKPK, bool GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool GNGFOCAKOPE(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void AGPBNFLIPEP(PHLHMBGDJPB FFODPEFFKPK, bool GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void NOHDNLNAJFC(PHLHMBGDJPB FFODPEFFKPK, int GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "50")]
	DGGLCAMAKMJ NMIALAFMFHJ(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void PHFNEJKJPOP(PHLHMBGDJPB FFODPEFFKPK, DGGLCAMAKMJ GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "52")]
	FJFFINOAFID FIHCBDMPBNL(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void POLACIJIPKM(PHLHMBGDJPB FFODPEFFKPK, FJFFINOAFID GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float LFLJFOKHFMG(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void MFNFPJIJMGH(PHLHMBGDJPB FFODPEFFKPK, float GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void BKLEHFKPEIM(PHLHMBGDJPB FFODPEFFKPK, object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void EOAIKBCDBEG(PHLHMBGDJPB FFODPEFFKPK, object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool DPHAPOMGHFK(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void HFCPHAPFHBK(PHLHMBGDJPB FFODPEFFKPK, object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void BKIFABOKCPC(PHLHMBGDJPB FFODPEFFKPK, object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool NOPEHAAAJNI(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool OBEAGGAOCGH(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody IDNAAEIODBA(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void PMALCKGFDGA(PHLHMBGDJPB FFODPEFFKPK, Rigidbody GKIOHLGLLID);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void JGEJKFLBIDJ(PHLHMBGDJPB FFODPEFFKPK, object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void GKHMFBAFNFD(PHLHMBGDJPB FFODPEFFKPK, object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool BNELGDDPNGB(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void GHHMECAADIN(PHLHMBGDJPB FFODPEFFKPK, float3 LEDLAOFKHKA);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void AODGPOENGOJ(PHLHMBGDJPB FFODPEFFKPK, float3 ICGDBJCJHBC);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool HPHLBMAFKPP(PHLHMBGDJPB FFODPEFFKPK, [Out] float3 LEDLAOFKHKA);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool EGBOCEDAOHC(PHLHMBGDJPB FFODPEFFKPK, [Out] float3 ICGDBJCJHBC);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool JOEIBFGJACF(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void JKOCFIHMAAI(PHLHMBGDJPB FFODPEFFKPK, object FGIAGALCIAP, bool KLOJNKJOLCC);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void GMAIBEDDLGB(PHLHMBGDJPB FFODPEFFKPK, bool JGOMAPCAIFH);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void AMGNBFCLNIH(PHLHMBGDJPB FFODPEFFKPK);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool HFNDDGONPOL(PHLHMBGDJPB FFODPEFFKPK);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface NMKMHFAIDIB
{
	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LBHPHBLHABB(Entity ACJAEEGLDAK);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JJBEEGAPCEP(Entity ACJAEEGLDAK);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface IFPAINJGJMB
{
	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MIPIHHEPJON(PHLHMBGDJPB PJIFCLGMLOL, bool EIDGLBDJAHD);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNGMHPLJBDC(PHLHMBGDJPB PJIFCLGMLOL, int LDNLBCKJNFL);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public delegate void DHHCGIFPIIO(BFJAJEMIIKP PAPOKMOCCPH);
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public readonly struct BFJAJEMIIKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly HDPBPBEDBGP KNBOJNCEMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly NativeArray<byte> KNHGOFEIOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly NativeArray<byte> GBKGAHGJACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly BHHMIGLMNDB INFKGBJLKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly int AIGGMEAKCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Type ANHBMHIDMIB;

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public HDPBPBEDBGP HLGMBGFPPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xA67B90", Offset = "0xA66790", VA = "0x180A67B90")]
		get
		{
			return default(HDPBPBEDBGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x69CA110", Offset = "0x69C8D10", VA = "0x1869CA110")]
	public BFJAJEMIIKP(HDPBPBEDBGP KNBOJNCEMAO, NativeArray<byte> KNHGOFEIOHM, NativeArray<byte> GBKGAHGJACH, BHHMIGLMNDB INFKGBJLKGB, int AIGGMEAKCPM, Type ANHBMHIDMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x2885720", Offset = "0x2884320", VA = "0x182885720")]
	public NativeArray<T> AKOPDLFCCBC<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x2885850", Offset = "0x2884450", VA = "0x182885850")]
	public NativeArray<T> LNOLPCPKKAI<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x2885760", Offset = "0x2884360", VA = "0x182885760")]
	public (HDPBPBEDBGP, NativeArray<T>, NativeArray<T>) HCNFCFFAFEI<T>() where T : struct
	{
		return default((HDPBPBEDBGP, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x69CA0C0", Offset = "0x69C8CC0", VA = "0x1869CA0C0")]
	public OOBHMNCCLGF MAHPHCPJJAO()
	{
		return default(OOBHMNCCLGF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public interface BDHNFKKDDGJ
{
	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	string JBLMLCENMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	BDHNFKKDDGJ AJLGFMDLLDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	IEnumerable<BDHNFKKDDGJ> HFKFFJDOJIB
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface ONECEHHAPOL
{
	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	BDHNFKKDDGJ FMPHODIDOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	List<OHDJOMCMGLM> KAIJKMCDLJL
	{
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KHOOMMPGKAN(OHDJOMCMGLM LKOIJCCHEHO, [Out] BDHNFKKDDGJ PHEDNOCBEEM);

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FHCDBNBHAOK(OHDJOMCMGLM LKOIJCCHEHO, DHHCGIFPIIO NBILOJOJDCE);

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CHBCOEBOKCE(OHDJOMCMGLM LKOIJCCHEHO, DHHCGIFPIIO NBILOJOJDCE);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public readonly struct OOBHMNCCLGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly BFJAJEMIIKP IMCLGJBJJKP;

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public HDPBPBEDBGP HLGMBGFPPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0xA67B90", Offset = "0xA66790", VA = "0x180A67B90")]
		get
		{
			return default(HDPBPBEDBGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x69DA5B0", Offset = "0x69D91B0", VA = "0x1869DA5B0")]
	public OOBHMNCCLGF(BFJAJEMIIKP IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x69DA2F0", Offset = "0x69D8EF0", VA = "0x1869DA2F0")]
	public HDPBPBEDBGP AKOPDLFCCBC()
	{
		return default(HDPBPBEDBGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x69DA4E0", Offset = "0x69D90E0", VA = "0x1869DA4E0")]
	public HDPBPBEDBGP LNOLPCPKKAI()
	{
		return default(HDPBPBEDBGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x69DA3C0", Offset = "0x69D8FC0", VA = "0x1869DA3C0")]
	public (HDPBPBEDBGP, HDPBPBEDBGP, HDPBPBEDBGP) HCNFCFFAFEI()
	{
		return default((HDPBPBEDBGP, HDPBPBEDBGP, HDPBPBEDBGP));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
[DefaultMember("Item")]
public interface HDKEHJAOODC : IEnumerable<DEPCKBDOBLK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	NativeBitArray GDJLKJLOBAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	NativeBitArray ACMNEMBFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	NativeArray<int> KDMOMHAKHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	int FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	DEPCKBDOBLK ENBJMEPMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	DEPCKBDOBLK ENBJMEPMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DEPCKBDOBLK GBHGAHGMBAO(EFPMEGLJAGG ALMPCPBBOLG);

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BHHMIGLMNDB JBBOGPPAACK(EFPMEGLJAGG ALMPCPBBOLG);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class MLHBCEFNOFK
{
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
[DefaultMember("Item")]
public interface NIAHBIPHIPD : IEnumerable<ONIEOEDHHIG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	int FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	ONIEOEDHHIG ENBJMEPMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ONIEOEDHHIG GBHGAHGMBAO(EFPMEGLJAGG ALMPCPBBOLG);

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BHHMIGLMNDB JBBOGPPAACK(EFPMEGLJAGG ALMPCPBBOLG);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class DBBLDBMCGCI
{
	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x292BAF0", Offset = "0x292A6F0", VA = "0x18292BAF0")]
	public static BHHMIGLMNDB JBBOGPPAACK<T>(this NIAHBIPHIPD BDOEOJENHDO, GAFGIJDLHMM<T> GFLNGGKHEOH) where T : struct
	{
		return default(BHHMIGLMNDB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[DefaultMember("Item")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface PFLHOGMMBLP : IEnumerable<OHDJOMCMGLM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	int FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	OHDJOMCMGLM ENBJMEPMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OHDJOMCMGLM GBHGAHGMBAO(EFPMEGLJAGG ALMPCPBBOLG);

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BHHMIGLMNDB JBBOGPPAACK(EFPMEGLJAGG ALMPCPBBOLG);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class BEBLGNFHMNB
{
	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x2881D10", Offset = "0x2880910", VA = "0x182881D10")]
	public static PGEMAIGPEFG<T> GBHGAHGMBAO<T>(this PFLHOGMMBLP BDOEOJENHDO, EFPMEGLJAGG GFLNGGKHEOH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x2881E50", Offset = "0x2880A50", VA = "0x182881E50")]
	public static BHHMIGLMNDB JBBOGPPAACK<T>(this PFLHOGMMBLP BDOEOJENHDO, GAFGIJDLHMM<T> GFLNGGKHEOH) where T : struct
	{
		return default(BHHMIGLMNDB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface GFIFOMICEJK
{
	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FHCDBNBHAOK(EFPMEGLJAGG LKOIJCCHEHO, DHHCGIFPIIO NBILOJOJDCE);

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CHBCOEBOKCE(EFPMEGLJAGG LKOIJCCHEHO, DHHCGIFPIIO NBILOJOJDCE);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class NIFBDHIKFPL
{
	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x2C9F250", Offset = "0x2C9DE50", VA = "0x182C9F250")]
	public static void FHCDBNBHAOK<T>(this GFIFOMICEJK MEGLJCJKABN, GAFGIJDLHMM<T> LKOIJCCHEHO, DHHCGIFPIIO NBILOJOJDCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x2C9EEC0", Offset = "0x2C9DAC0", VA = "0x182C9EEC0")]
	public static void CHBCOEBOKCE<T>(this GFIFOMICEJK MEGLJCJKABN, GAFGIJDLHMM<T> LKOIJCCHEHO, DHHCGIFPIIO NBILOJOJDCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface AJFJDBLEKFK
{
	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	GJAMLPLBOEM FLEJKNKEBGG
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KNAHNDKKBLG(DDPLMDBOHKM PIOJFCHBCHD, BHHMIGLMNDB LKOIJCCHEHO);

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCAGFCAAGGL(DDPLMDBOHKM PIOJFCHBCHD, Span<BHHMIGLMNDB> BDOEOJENHDO, bool JIDNCEOJHFN);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OHAKMEEIKGN(NativeArray<DDPLMDBOHKM> CNAJMFBNAGA);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class PEFOPAPDNLM
{
	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x69DAEF0", Offset = "0x69D9AF0", VA = "0x1869DAEF0")]
	public static void BCAGFCAAGGL(this AJFJDBLEKFK OGEHJFKNDEF, DDPLMDBOHKM PIOJFCHBCHD, BHHMIGLMNDB LKOIJCCHEHO, bool JIDNCEOJHFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public readonly struct GJAMLPLBOEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly NativeBitArray LGBIAINLOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly NativeParallelHashMap<DDPLMDBOHKM, int> CAPEBGEOPJP;

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public bool CIGKNHKCONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x69D5AD0", Offset = "0x69D46D0", VA = "0x1869D5AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x41DBA70", Offset = "0x41DA670", VA = "0x1841DBA70")]
	public GJAMLPLBOEM(NativeBitArray LGBIAINLOIK, NativeParallelHashMap<DDPLMDBOHKM, int> CAPEBGEOPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x69D59A0", Offset = "0x69D45A0", VA = "0x1869D59A0")]
	public bool KNAHNDKKBLG(DDPLMDBOHKM PIOJFCHBCHD, BHHMIGLMNDB LKOIJCCHEHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface LIFOEBJPPKM
{
	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IPDKBLHJMOI(PHLHMBGDJPB FFODPEFFKPK, MLKBLKDDCDI GLMEMJNJKAN);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface BADIEPKFPFG
{
	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	MHJGHFLMOAG CHJOKCIAADN
	{
		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface IJFPGLMDMLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGPIHCAHJIN(World BKIPEHEIIHC);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MHHGLAOBJDJ(World BKIPEHEIIHC);

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase KIHMLBAEJDP(World BKIPEHEIIHC);

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FBLGKGJBMBO(World BKIPEHEIIHC);

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FJILGCDAMNE(World BKIPEHEIIHC);

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HJJOPCCJAIG(World BKIPEHEIIHC);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[PDLAMBIDAOD(DJPDPGDGFEF.LoadInstance)]
public interface DAELOLGDFHA
{
	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKJDODKOLMO(PHLHMBGDJPB NKMEKLOOCFN, bool GLMEMJNJKAN);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public readonly struct PLHALELJAGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly IEnumerable<HMJEKGIMIDG> KNDHKFBIBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly IReadOnlyList<GameObject> COOGDGDEDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly IReadOnlyList<int> NLEAOHGJKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IReadOnlyList<(DDPLMDBOHKM, DDPLMDBOHKM)> GPPKPFONGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly int FEMIJEHPPGN;

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public bool GKFNCCNFNCH
	{
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x69DBD10", Offset = "0x69DA910", VA = "0x1869DBD10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	public int JABHEKGBAKD
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x8BAEF0", Offset = "0x8B9AF0", VA = "0x1808BAEF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public IEnumerable<GameObject> HHMPCHMOJOK
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DA0", Offset = "0x8B39A0", VA = "0x1808B4DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public IEnumerable<(DDPLMDBOHKM src, DDPLMDBOHKM dst)> IOOHLEKGGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x69DBD70", Offset = "0x69DA970", VA = "0x1869DBD70")]
	public PLHALELJAGC(IEnumerable<HMJEKGIMIDG> KNDHKFBIBCF, IReadOnlyList<GameObject> COOGDGDEDGH, IReadOnlyList<int> NLEAOHGJKGB, IReadOnlyList<(DDPLMDBOHKM src, DDPLMDBOHKM dst)> GPPKPFONGCB, int FEMIJEHPPGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x69DB980", Offset = "0x69DA580", VA = "0x1869DB980")]
	public (GameObject, int)[] CHOLGJEAGKH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface BLBCFKIIMDN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	bool PCFBBBNEGEI
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	bool FFLDAGDAPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	NAGNDCGCDGD LBCPOJNBCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FDLHKOFPFOL NBKBGALEKPF();

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FDLHKOFPFOL OENAAJDDKDO(IEnumerable<PHLHMBGDJPB> OCMEKIBCJIK, [In] UniformTRS IBCFNFENLBJ);

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OGDHBNDMMLP PKJEOPACPMB(ByteString NCMAEAOKKFJ);

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KMKBENJKOMG MIKOBMNLOAN(ByteString EJGADLCOEON, PHLHMBGDJPB GPMGJNAOOEP, [In] UniformTRS EEKDHHKKLOF, KJIGBCGAAMC BGFEPGBHOKH, bool AJHJFJAKJIH = true);

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LAMGNMMMBLG();

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PLHALELJAGC NKDGDOPIEOA(IEnumerable<HMJEKGIMIDG> KNDHKFBIBCF);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public static class ABAGKBMADMN
{
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface KEAHEJDNJOC
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action LGHGLNBIPDD;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action PNMCPHBODKD;
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public struct HHADOOHOBAN : JPPLBHHNBKC, IEquatable<HHADOOHOBAN>
{
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public static readonly int IOFOLEFFOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public KGAFPCDNLAE BNEADFDDBLJ;

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x69D6610", Offset = "0x69D5210", VA = "0x1869D6610", Slot = "5")]
	public void EGCBEAACMHC(HJOMNJNLOEI GGPHPLOPODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x69D66E0", Offset = "0x69D52E0", VA = "0x1869D66E0", Slot = "4")]
	public void PLFEAILJDFE(HKGFKELOBIK AKHHKFNOJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x69D6710", Offset = "0x69D5310", VA = "0x1869D6710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x9D6EA0", Offset = "0x9D5AA0", VA = "0x1809D6EA0", Slot = "6")]
	public bool Equals(HHADOOHOBAN OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x69D6640", Offset = "0x69D5240", VA = "0x1869D6640", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x916930", Offset = "0x915530", VA = "0x180916930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public struct HMJEKGIMIDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public Guid CICFLOBNFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public string NNDJGABFEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Vector3 DFPHDEDIHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Quaternion DELGPMLKBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Vector3 IADPMFLONGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public int OJKILABBMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Dictionary<string, object> ENFOCCMDNKP;

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x69D6940", Offset = "0x69D5540", VA = "0x1869D6940", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x69D67B0", Offset = "0x69D53B0", VA = "0x1869D67B0")]
	private static string EOAEAMNMOHH(Dictionary<string, object> FHINEEGCGMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public enum CIEPKBJHKAF
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	SubGraphReplace,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	RestoreCreationData
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class MLLLPJLOGHI
{
	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E17160", Offset = "0x5E15D60", VA = "0x185E17160")]
	public static bool BLLBNPLICAB(this CIEPKBJHKAF NCNNODEFPOG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[Flags]
public enum MHBAPCNFALE
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	WorldPhasesMaster = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	AdditivePhases = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public interface KMKBENJKOMG : NAGNDCGCDGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	KJIGBCGAAMC POOHGKGGKLC
	{
		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHMLCEABGGF();

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FNGILJPILJA();
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public interface NAGNDCGCDGD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	IEnumerable<HMJEKGIMIDG> JCBANLBOJMH
	{
		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	PLHALELJAGC KFACKICIANB
	{
		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	CIEPKBJHKAF AJCKJIKGPNK
	{
		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	LocalId FFJKJHPMOLC
	{
		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	DHBPKAPHOAB NNFKCDNKGJC
	{
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FLADJOFCMKI(MHBAPCNFALE HNPEHALBGNP);
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public interface KJIGBCGAAMC
{
	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GHOHGHFEALA(Guid AIFEMCDFFGN, [Out] Guid OPHLCCBBKLN);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public interface OGDHBNDMMLP : NAGNDCGCDGD, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[Flags]
public enum ADILLILOAKJ
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public interface FDLHKOFPFOL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	DHBPKAPHOAB AOKEPFMDCCC
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString DKJGGMBABDD();
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public enum AFCNHIIDMHF
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public delegate bool GCKODOECGLJ(JODJMDKKGHL DILFCFOFFJG, [In] MDEDOBLHNPN GLMEMJNJKAN);
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public delegate bool JLEMEHLGOJE<T>(JODJMDKKGHL DILFCFOFFJG, [In] T GLMEMJNJKAN);
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface NIADNHBIOAA
{
	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FHCDBNBHAOK(BHHMIGLMNDB INFKGBJLKGB, Type LGKCIKLFDOI, GCKODOECGLJ LNEKIFGHHNE);

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PBLDAGDBMHJ(BHHMIGLMNDB INFKGBJLKGB, [Out] GCKODOECGLJ LNEKIFGHHNE);
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class OGDEENDPLMN
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class ELPIFJOPPAI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public JLEMEHLGOJE<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public ELPIFJOPPAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x380A8E0", Offset = "0x38094E0", VA = "0x18380A8E0")]
		internal bool PAABOIGHMID(JODJMDKKGHL pendingList, [In] MDEDOBLHNPN value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7C90", Offset = "0x2CD6890", VA = "0x182CD7C90")]
	public static void FHCDBNBHAOK<T>(this NIADNHBIOAA MEGLJCJKABN, BHHMIGLMNDB INFKGBJLKGB, JLEMEHLGOJE<T> LNEKIFGHHNE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x69DA1C0", Offset = "0x69D8DC0", VA = "0x1869DA1C0")]
	public static bool CBAFBKBDNHJ(this NIADNHBIOAA MEGLJCJKABN, JODJMDKKGHL DILFCFOFFJG, BHHMIGLMNDB INFKGBJLKGB, [In] MDEDOBLHNPN GLMEMJNJKAN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface JPGNGOCIJKF
{
	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	uint JKKPJHBFPCI
	{
		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface JODJMDKKGHL
{
	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IJDDHENIHAG(DDPLMDBOHKM FOCIDGJHKAP, BHHMIGLMNDB INFKGBJLKGB, ReadOnlySpan<byte> CGDNJECHEEA, ReadOnlySpan<byte> AKLLLMHDOKJ);

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IOPOJLBNEMB(DDPLMDBOHKM FOCIDGJHKAP, BHHMIGLMNDB INFKGBJLKGB, ReadOnlySpan<byte> CGDNJECHEEA, ReadOnlySpan<byte> AKLLLMHDOKJ);

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FEPAHLNLHCF(DDPLMDBOHKM FOCIDGJHKAP, BHHMIGLMNDB INFKGBJLKGB);

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FGIBCIPHHEA(DDPLMDBOHKM FOCIDGJHKAP, BHHMIGLMNDB INFKGBJLKGB, ReadOnlySpan<byte> AKLLLMHDOKJ);

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EADPPHGIEPF(DDPLMDBOHKM FOCIDGJHKAP, BHHMIGLMNDB INFKGBJLKGB, Span<byte> CGDNJECHEEA, Span<byte> AKLLLMHDOKJ);
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public static class MGHFPLGBIDM
{
	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x2C33350", Offset = "0x2C31F50", VA = "0x182C33350")]
	public static bool EADPPHGIEPF<T>(this JODJMDKKGHL DJIEOEPIMIG, DDPLMDBOHKM FOCIDGJHKAP, BHHMIGLMNDB INFKGBJLKGB, [Out] T CGDNJECHEEA, [Out] T AKLLLMHDOKJ) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x2C33540", Offset = "0x2C32140", VA = "0x182C33540")]
	public static bool FGIBCIPHHEA<T>(this JODJMDKKGHL DJIEOEPIMIG, DDPLMDBOHKM FOCIDGJHKAP, BHHMIGLMNDB INFKGBJLKGB, T AKLLLMHDOKJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public enum KEFKAIPKJGF
{
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	End,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface KKDEKEEBDHN
{
	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIAGGACEECJ(EGFJIDPKBLC OGOLDJHPDFA, ReadOnlySpan<byte> FAPAFOGIGGO);

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALMGKLPDMFA(uint IGNHBMOEIFD, ReadOnlySpan<byte> FAPAFOGIGGO);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BOOGJLFAPFI(int IOAGGAPBOAC);
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface KLHLOLDBIOD
{
	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EGFJIDPKBLC HLDFFPKKANM(ReadOnlySpan<byte> FAPAFOGIGGO);
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface APCBEDLLPGE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBKKKHOCLNE(EGFJIDPKBLC DPHIOKCFMFC, ReadOnlySpan<byte> FAPAFOGIGGO);

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KBMHOGCGLJG(ReadOnlySpan<EGFJIDPKBLC> FEPPKPGPJCA);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public struct DHMJPNKBMPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public EGFJIDPKBLC OGOLDJHPDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public ReadOnlyMemory<byte> FAPAFOGIGGO;
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public struct EGFJIDPKBLC
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static EGFJIDPKBLC IBMANNKOKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public uint DCDOFODHOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public int AIANLMKAHKJ;

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0xC225C0", Offset = "0xC211C0", VA = "0x180C225C0")]
	public EGFJIDPKBLC(uint DCDOFODHOCA, int AIANLMKAHKJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x69D4280", Offset = "0x69D2E80", VA = "0x1869D4280")]
	public static bool NBAHCGFACIA([In] EGFJIDPKBLC HLHDFJDLHFM, [In] EGFJIDPKBLC GIHDHONABPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x69D41A0", Offset = "0x69D2DA0", VA = "0x1869D41A0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x69D4250", Offset = "0x69D2E50", VA = "0x1869D4250", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x69D42A0", Offset = "0x69D2EA0", VA = "0x1869D42A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x69D4190", Offset = "0x69D2D90", VA = "0x1869D4190")]
	public void ALCMIDHBGAI([Out] uint DCDOFODHOCA, [Out] int AIANLMKAHKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface LIGJPDHFGDK : CAHGBFPDKIG<LIGJPDHFGDK>
{
	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KEKFKPJEKCC(BHHMIGLMNDB EPKGPGILADI, [Out] DMDFNPGIKEI FFABADEFODC);
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public static class FAIABLHJNLH
{
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public interface DMDFNPGIKEI
{
	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	Type MBAGNHFLLNM
	{
		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGCBEAACMHC(HJOMNJNLOEI GGPHPLOPODB, Span<byte> PJIFCLGMLOL);

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLFEAILJDFE(HKGFKELOBIK AKHHKFNOJLO, ReadOnlySpan<byte> OGOLDJHPDFA);
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public static class DKDEDOJBFPI
{
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public struct IPFAGJCOPOO : ISystemStateComponentData, IComponentData, IEquatable<IPFAGJCOPOO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float3 OKEJJJPMBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float3 IKHKIFHEHEI;

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x69D7160", Offset = "0x69D5D60", VA = "0x1869D7160", Slot = "4")]
	public bool Equals(IPFAGJCOPOO OCNJFCPHJLD)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class MOPBIGCLMGE
{
	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public MOPBIGCLMGE()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
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
