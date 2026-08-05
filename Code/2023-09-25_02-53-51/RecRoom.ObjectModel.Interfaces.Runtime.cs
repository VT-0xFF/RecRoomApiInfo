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
public struct KLCLLLJMBOO : IReadOnlyList<CAKFEHOBCAO>, IEnumerable<CAKFEHOBCAO>, IEnumerable, IReadOnlyCollection<CAKFEHOBCAO>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct DBHNLAMFHNK : IEnumerator<CAKFEHOBCAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly CDJJECGMMII JJMFHKECKEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator MLKCGGMDNEJ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public CAKFEHOBCAO KCBEOJELDAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5DA81E0", Offset = "0x5DA75E0", VA = "0x185DA81E0", Slot = "4")]
			get
			{
				return default(CAKFEHOBCAO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5DA8150", Offset = "0x5DA7550", VA = "0x185DA8150", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x38AFD60", Offset = "0x38AF160", VA = "0x1838AFD60")]
		public DBHNLAMFHNK(CDJJECGMMII JJMFHKECKEI, NativeArray<LocalId>.Enumerator MLKCGGMDNEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8090", Offset = "0x5DA7490", VA = "0x185DA8090", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5DA80D0", Offset = "0x5DA74D0", VA = "0x185DA80D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8110", Offset = "0x5DA7510", VA = "0x185DA8110", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> MOMJNKBEDGK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public CAKFEHOBCAO ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF4A0", Offset = "0x5DAE8A0", VA = "0x185DAF4A0", Slot = "4")]
		get
		{
			return default(CAKFEHOBCAO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5DAEFB0", Offset = "0x5DAE3B0", VA = "0x185DAEFB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int DFFKELIGFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x762180", Offset = "0x761580", VA = "0x180762180", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public CDJJECGMMII LCJLLGELGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA95A00", Offset = "0xA94E00", VA = "0x180A95A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int JBNGEMMLBJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x762180", Offset = "0x761580", VA = "0x180762180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool PJPBOLEMKCC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DAEF70", Offset = "0x5DAE370", VA = "0x185DAEF70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> KBMCOJOIAOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x38AC400", Offset = "0x38AB800", VA = "0x1838AC400")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> HGONJGHJKGA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DAEF10", Offset = "0x5DAE310", VA = "0x185DAEF10")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF410", Offset = "0x5DAE810", VA = "0x185DAF410")]
	public KLCLLLJMBOO(int ACGAEDNGFFD, CDJJECGMMII JJMFHKECKEI, Allocator JIIMEDFKEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x38AFAA0", Offset = "0x38AEEA0", VA = "0x1838AFAA0")]
	public KLCLLLJMBOO(CDJJECGMMII JJMFHKECKEI, NativeArray<LocalId> MOMJNKBEDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF3A0", Offset = "0x5DAE7A0", VA = "0x185DAF3A0")]
	internal KLCLLLJMBOO(CDJJECGMMII JJMFHKECKEI, NativeArray<Entity> JIBDNODJOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF250", Offset = "0x5DAE650", VA = "0x185DAF250")]
	public KLCLLLJMBOO(CDJJECGMMII JJMFHKECKEI, int FADEBHLHEEP, Allocator JIIMEDFKEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF2F0", Offset = "0x5DAE6F0", VA = "0x185DAF2F0")]
	public KLCLLLJMBOO(KLCLLLJMBOO CIPPNMCCODM, Allocator JIIMEDFKEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5DAEFC0", Offset = "0x5DAE3C0", VA = "0x185DAEFC0")]
	public KLCLLLJMBOO PCONDBHNLLG(Allocator JIIMEDFKEME = Allocator.Temp)
	{
		return default(KLCLLLJMBOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5DAEED0", Offset = "0x5DAE2D0", VA = "0x185DAEED0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5DAEE40", Offset = "0x5DAE240", VA = "0x185DAEE40")]
	public DBHNLAMFHNK DDJBJFDOGGC()
	{
		return default(DBHNLAMFHNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF070", Offset = "0x5DAE470", VA = "0x185DAF070", Slot = "6")]
	private IEnumerator<CAKFEHOBCAO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF160", Offset = "0x5DAE560", VA = "0x185DAF160", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct EMJPBDKFLKA : IList<CAKFEHOBCAO>, ICollection<CAKFEHOBCAO>, IEnumerable<CAKFEHOBCAO>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct OHLHFEDFDPH : IEnumerator<CAKFEHOBCAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly CDJJECGMMII JJMFHKECKEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator MLKCGGMDNEJ;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public CAKFEHOBCAO KCBEOJELDAC
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5DB1800", Offset = "0x5DB0C00", VA = "0x185DB1800", Slot = "4")]
			get
			{
				return default(CAKFEHOBCAO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5DB1770", Offset = "0x5DB0B70", VA = "0x185DB1770", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x38AFD60", Offset = "0x38AF160", VA = "0x1838AFD60")]
		public OHLHFEDFDPH(CDJJECGMMII JJMFHKECKEI, NativeArray<LocalId>.Enumerator MLKCGGMDNEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB16B0", Offset = "0x5DB0AB0", VA = "0x185DB16B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5DB16F0", Offset = "0x5DB0AF0", VA = "0x185DB16F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1730", Offset = "0x5DB0B30", VA = "0x185DB1730", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> MOMJNKBEDGK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public CAKFEHOBCAO ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5DA9EA0", Offset = "0x5DA92A0", VA = "0x185DA9EA0", Slot = "4")]
		get
		{
			return default(CAKFEHOBCAO);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5DA9F20", Offset = "0x5DA9320", VA = "0x185DA9F20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5DA9A30", Offset = "0x5DA8E30", VA = "0x185DA9A30", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int JBNGEMMLBJK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5DA9A30", Offset = "0x5DA8E30", VA = "0x185DA9A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool DNCECCDBGAH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9E10", Offset = "0x5DA9210", VA = "0x185DA9E10")]
	public EMJPBDKFLKA(CDJJECGMMII JJMFHKECKEI, int FADEBHLHEEP, Allocator JIIMEDFKEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9600", Offset = "0x5DA8A00", VA = "0x185DA9600")]
	public KLCLLLJMBOO BAIEKAPIMGB()
	{
		return default(KLCLLLJMBOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9680", Offset = "0x5DA8A80", VA = "0x185DA9680", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5DA96C0", Offset = "0x5DA8AC0", VA = "0x185DA96C0", Slot = "13")]
	public bool Contains(CAKFEHOBCAO IBHHDIJNMFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9720", Offset = "0x5DA8B20", VA = "0x185DA9720", Slot = "14")]
	public void CopyTo(CAKFEHOBCAO[] FOAJABBKLPB, int MHBLGNNCLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5DA95A0", Offset = "0x5DA89A0", VA = "0x185DA95A0", Slot = "11")]
	public void Add(CAKFEHOBCAO IBHHDIJNMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9AD0", Offset = "0x5DA8ED0", VA = "0x185DA9AD0", Slot = "7")]
	public void Insert(int JPEMHHILGGG, CAKFEHOBCAO IBHHDIJNMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9BA0", Offset = "0x5DA8FA0", VA = "0x185DA9BA0", Slot = "15")]
	public bool Remove(CAKFEHOBCAO IBHHDIJNMFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9A70", Offset = "0x5DA8E70", VA = "0x185DA9A70", Slot = "6")]
	public int IndexOf(CAKFEHOBCAO IBHHDIJNMFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9B50", Offset = "0x5DA8F50", VA = "0x185DA9B50", Slot = "8")]
	public void RemoveAt(int JPEMHHILGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5DA99F0", Offset = "0x5DA8DF0", VA = "0x185DA99F0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9960", Offset = "0x5DA8D60", VA = "0x185DA9960")]
	public OHLHFEDFDPH DDJBJFDOGGC()
	{
		return default(OHLHFEDFDPH);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9C30", Offset = "0x5DA9030", VA = "0x185DA9C30", Slot = "16")]
	private IEnumerator<CAKFEHOBCAO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9D20", Offset = "0x5DA9120", VA = "0x185DA9D20", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PAEPNGDGNBO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int LMFDPDKPOIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> FCNPHJFMOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CAKFEHOBCAO KJADHLDCIPC(CAKFEHOBCAO MOMJNKBEDGK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OKNBNCGLGHA : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface LMFELGCOCBG : PNLMNOEHBNA, EOAILPGBNIC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool DMGAPDBKGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	JMIBEAJAMBD AGOENIEKEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	JPNIIOOOMOP IBEJPPJAKBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	CPBLFKHDDGN NKHNPFLPACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	OAPOPJMEPNA AGOLEMGECKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface EOAILPGBNIC
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool ENLBFFMNMKN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface NBAFOHEBHDH
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CNOOJKLJJDP(bool LPCGJALKADL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface OAPOPJMEPNA
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool LGAJFECOMFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action AAOJNFDAGAG;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DEICEPJKFDL(bool GGJLDJABGMP);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IHGBDBPIGJB(ByteString KHPJJNGKJGC);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AADMAAIDNBK();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ICKNFFFCLJG();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ABIKFDNBPMC();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface CPBLFKHDDGN
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	FIMDMOFKGJF AGOENIEKEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	JPNIIOOOMOP IBEJPPJAKBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	HONAKLLNIOE DELMCPMFCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	CDJJECGMMII LCJLLGELGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	GMEBHOOMEDK EFBMJCLPBLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	EPEIHHNCIHD FIHFHBBKOKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	JFKABFIKFCO LJIAHPNMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	HGBLHAOBLKK EHBCBJJGHJI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	EEJAONCFMLK NIEPLNGJGKP
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	FHBDOMJNNEJ BGDAAGBHOIG
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	NCBLCPIDIEA CPCCPCBLEDG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	AEMEMLHFPNC CEAOLLGHOLM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	JFDAFKCNFNC MACMDECLGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	EJLACCPBJAD OJIKIGPDDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CMLGHDCNGPG HMFFELCEKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	GLJHEKCADEF BHKIMOFNAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CAMBFJGGDMI GKBLEPDKEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	IBNLNIKJFKJ IEECJPHCDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	EKBKOBJCEAO KFDKCHBJAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(PHKOPLMPGJP))]
public readonly struct CAKFEHOBCAO : IComparable<CAKFEHOBCAO>, IEquatable<CAKFEHOBCAO>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly CAKFEHOBCAO AJNJPGPIKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly OBPNGNFDEPN EKHBDCNGFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly LocalId AJAFIOGCMHP;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public CDJJECGMMII LCJLLGELGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5DA67B0", Offset = "0x5DA5BB0", VA = "0x185DA67B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public LocalId FKJOPJBIFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x17C49C0", Offset = "0x17C3DC0", VA = "0x1817C49C0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool NDBJGAPFHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6B00", Offset = "0x5DA5F00", VA = "0x185DA6B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool DFOBOMCPBKO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6720", Offset = "0x5DA5B20", VA = "0x185DA6720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool GCGFOAHDKGK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6BF0", Offset = "0x5DA5FF0", VA = "0x185DA6BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6CD0", Offset = "0x5DA60D0", VA = "0x185DA6CD0")]
	public CAKFEHOBCAO(CDJJECGMMII LMMMDFJMILJ, LocalId AJAFIOGCMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
	public BAJJJAGOPJE HDPJBAONJJI()
	{
		return default(BAJJJAGOPJE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x17C49C0", Offset = "0x17C3DC0", VA = "0x1817C49C0")]
	public static LocalId DLNOOKJDMMJ(CAKFEHOBCAO GEJPNCFJGPK)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5DA67A0", Offset = "0x5DA5BA0", VA = "0x185DA67A0")]
	public static Entity DLNOOKJDMMJ(CAKFEHOBCAO GEJPNCFJGPK)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6AA0", Offset = "0x5DA5EA0", VA = "0x185DA6AA0")]
	public static bool HCMKGGFOPFL(CAKFEHOBCAO BOGGCLFEFDJ, CAKFEHOBCAO OGHJEHJOFGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6960", Offset = "0x5DA5D60", VA = "0x185DA6960")]
	public static bool GKDOMDKCOOJ(CAKFEHOBCAO BOGGCLFEFDJ, CAKFEHOBCAO OGHJEHJOFGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6C10", Offset = "0x5DA6010", VA = "0x185DA6C10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6830", Offset = "0x5DA5C30", VA = "0x185DA6830", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6740", Offset = "0x5DA5B40", VA = "0x185DA6740", Slot = "4")]
	public int CompareTo(CAKFEHOBCAO KEEHOGPOIFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5DA5160", Offset = "0x5DA4560", VA = "0x185DA5160", Slot = "5")]
	public bool Equals(CAKFEHOBCAO KEEHOGPOIFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class KEPCOEEKEFP
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5DAEBC0", Offset = "0x5DADFC0", VA = "0x185DAEBC0")]
	public static IKAJAHLJFMC CDLFJKIJIFJ(this CAKFEHOBCAO IBBNLILJNEB)
	{
		return default(IKAJAHLJFMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x242D480", Offset = "0x242C880", VA = "0x18242D480")]
	public static T DDAKKFPKNCG<T>(this CAKFEHOBCAO IBBNLILJNEB) where T : struct, IComponent
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal sealed class PHKOPLMPGJP
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct OBPNGNFDEPN : IEquatable<OBPNGNFDEPN>
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal const int LMAMAAIOJFB = 1;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal const int KCELPKBDIBG = 4;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	internal const int FOPOCKHENBE = 8;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal const int JKEINJPPAIJ = 24;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal const uint NCGLCOGNPIH = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal const uint BOFEABPDKEM = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly uint EKHBDCNGFLP;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static uint[] HHPNPODNLFG;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static CDJJECGMMII[] MHCBJGOCOMD;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static uint FDACFBIBHPK;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public CDJJECGMMII LCHHHEMODDP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0A00", Offset = "0x5DAFE00", VA = "0x185DB0A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5DB13B0", Offset = "0x5DB07B0", VA = "0x185DB13B0")]
	static OBPNGNFDEPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7D2F60", Offset = "0x7D2360", VA = "0x1807D2F60")]
	internal OBPNGNFDEPN(uint LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x15EFF70", Offset = "0x15EF370", VA = "0x1815EFF70", Slot = "4")]
	public bool Equals(OBPNGNFDEPN KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0A60", Offset = "0x5DAFE60", VA = "0x185DB0A60", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x9786C0", Offset = "0x977AC0", VA = "0x1809786C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5DB12B0", Offset = "0x5DB06B0", VA = "0x185DB12B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0CD0", Offset = "0x5DB00D0", VA = "0x185DB0CD0")]
	private CDJJECGMMII KBNKLBJAAEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5DB10E0", Offset = "0x5DB04E0", VA = "0x185DB10E0")]
	private static uint LNDPEHBIDBK(uint EKHBDCNGFLP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5DB10F0", Offset = "0x5DB04F0", VA = "0x185DB10F0")]
	private static (uint, uint) MPJFMCMJAPJ(uint EKHBDCNGFLP)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0A50", Offset = "0x5DAFE50", VA = "0x185DB0A50")]
	private static uint CJDMKIFHDPA(uint KAHINILDCOI, uint JPEMHHILGGG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0B00", Offset = "0x5DAFF00", VA = "0x185DB0B00")]
	internal static OBPNGNFDEPN GFCMFFOEFBO(CDJJECGMMII CDNLGICPHJL)
	{
		return default(OBPNGNFDEPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1150", Offset = "0x5DB0550", VA = "0x185DB1150")]
	internal static void OOFKJBAJEMO(OBPNGNFDEPN EKHBDCNGFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0E70", Offset = "0x5DB0270", VA = "0x185DB0E70")]
	private static void KGLCGOKANLA(int ACGAEDNGFFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface MIHEJMLNMCP
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKKJEKLPILJ();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LPLKNMEPKEC(bool GGBINENOFHH);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KBNANNCJOMF(GameObject GHAOKLKOOCA);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface HEKCKKAGEFC
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BFMCDKIOIPI(GameObject GHAOKLKOOCA);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DPPKGEEOAOP(GameObject GHAOKLKOOCA);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	object BBGPAOGJADF(CAKFEHOBCAO AJAFIOGCMHP, GameObject GHAOKLKOOCA, Action<CAKFEHOBCAO, int> AIBILCAOCLG);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IHFCGAHJNHN(GameObject GHAOKLKOOCA, object PAEOBGECBJI);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface OPAANNDNOCG
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPFEEKPEIOK(KLCLLLJMBOO MOMJNKBEDGK);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 DOCFILCILKH(GameObject GHAOKLKOOCA, int ONIMDKCNGLF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface JPNIIOOOMOP
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	MIHEJMLNMCP CJFLBIONFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	NFFPLOOJDLP OPEJFEANDJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	MKGHLKFDBNM JNJLHAFPLCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	BKIMEPBHNGA CDLANPMGNBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	MLEALBJMIOH IGDOIILIPHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	GENLJBHGPDA BOIAFBECOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ENDHDICDHJA HNEDLGOLDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CPKNDJKPEFJ IALKDHMOHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface JMLLBGKNGCC
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PAHLNJABDMM(Action PAFFKHOCLGN, bool FEKKHPGNBJG);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KKMLGONFGED(string DKFEAPHKBMP);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface NFFPLOOJDLP
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string AJFCEKOGNDF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] MJGLNNEHEML(IEnumerable<OPBDJAPIKJM> AHCDBFBGANG);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IKAJAHLJFMC IGELGCHKFDC(Guid OFNNGNGCJGH);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BALBPKOALDF(GameObject GHAOKLKOOCA, [Out] IKAJAHLJFMC MIPKLHDFLBO);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KNLOHOCGFBF(GameObject GHAOKLKOOCA, [Out] int NHPCEECPNIH, [Out] HNGHCMBBKEB HOAIKLJFCGK);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CGNNELOIABF KHIDIEHOLHL(OPBDJAPIKJM EJJHDDFDLOL);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CGNNELOIABF KHIDIEHOLHL(string CMKNABKHAEG, IKAJAHLJFMC MIPKLHDFLBO, Vector3 BAONBICGOEJ, Quaternion CKFJFCLIANA, Vector3 IJMHENINMDB);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PKLAAIDKGFD(GameObject DIPCJCNGOKB, bool NGEFJHDPCLO);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NBKCAEIELOL(GameObject GHAOKLKOOCA, bool EBOGAFAGNMB, bool LDNACDJOHDF);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class HNHKAEFPPND
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE0D0", Offset = "0x5DAD4D0", VA = "0x185DAE0D0")]
	public static CGNNELOIABF KHIDIEHOLHL(this NFFPLOOJDLP FDEKFCDLHEC, IKAJAHLJFMC MIPKLHDFLBO, Vector3 BAONBICGOEJ, Quaternion CKFJFCLIANA, Vector3 IJMHENINMDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface MKGHLKFDBNM
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECPLDLGMPMB(bool GGJLDJABGMP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface BKIMEPBHNGA
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool HDJNLALAKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool CKDAOOBHLAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool IFDEAMEIGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	bool BHPEOEMOCJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BPLOMEHFCFF(object CJFCIOOMJGN);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EKLFCLNGHBN(object ADOGMMPMLJB);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JFFNPNIIDHE(object ADOGMMPMLJB);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int ELJLPMGACAD(GameObject DHIHKCPMIMH);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EAEIJJBHFGM(NativeArray<int> AFMGBCOMGNM);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface MLEALBJMIOH
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNLCEDKIDBJ(GameObject GHAOKLKOOCA);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface KNLDJMFLGFE
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PECJEFCILHG(string LMJAPBNMKLG);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface GENLJBHGPDA
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	int BFFCKGEDPCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int CCAEIKPKAFI(GameObject GHAOKLKOOCA);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DLNICLCIAOH([Out] Vector3 BAONBICGOEJ);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AENEKPFBNBC();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface ENDHDICDHJA
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool LGAJFECOMFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	bool MPEEPJJLCOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface KIMFLBFDMNG
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	MIKJKBLJLIL BDAFBJEFKFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	LICBIGCJLJE HPOBIHHPNLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KNBLAGBJNEH(Transform IJKPFNCIDCJ);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MJPNAGEKBFJ(Transform IJKPFNCIDCJ, OEDAPBKPHMN EMBDKEKAECP);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DNDCCHJDHAJ(Transform IJKPFNCIDCJ, HKEOIHFAMCC FJGJCFHIBJI);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface CPKNDJKPEFJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGGILBINEKA();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface JJOAKEFCJNP
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FJAHKIELPKK();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface DDJENBEKAAO
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HNGHCMBBKEB NLLBGNNLEEN(GameObject DHIHKCPMIMH);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BGHNPDCFEJA(GameObject GHAOKLKOOCA, AGMJJKFLOHH HKNABNLNNAF, PJIHJNCGMAC DPLBONDPGFF);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct GFKBHJBLMKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly HMAJIPCBGOH CJJOHOENBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly HMAJIPCBGOH KAABKEFBBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal readonly uint PKFEJLJHJKB;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB570", Offset = "0x5DAA970", VA = "0x185DAB570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct IJLCDECFLMK
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly GFKBHJBLMKM PAFFKHOCLGN;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE350", Offset = "0x5DAD750", VA = "0x185DAE350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct ICGDKDFGNOC
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly GFKBHJBLMKM PAFFKHOCLGN;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE350", Offset = "0x5DAD750", VA = "0x185DAE350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct FOBGMHKFEMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint PKFEJLJHJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly bool EFNHPIFGDAF;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB350", Offset = "0x5DAA750", VA = "0x185DAB350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct HMAJIPCBGOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal int POBHOBNPPIN;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5DADFD0", Offset = "0x5DAD3D0", VA = "0x185DADFD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface DNJKCCBHJNO
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	LHJOFILDEAL KBOMEFMFFAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum OANLLCBMGJL
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
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface CGNNELOIABF : MAIPDEKHDOP
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	OANLLCBMGJL JOIAGLGDJGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool PNEMGIOOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	GameObject GHAOKLKOOCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<CGNNELOIABF> MODKIIHHLMP;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(HONAKLLNIOE KMPNHHILNIL, CAKFEHOBCAO BCKPEHNNCPM);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool IHNGGFIGPOG);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class GAPJEDLFHAO
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB3F0", Offset = "0x5DAA7F0", VA = "0x185DAB3F0")]
	public static bool BDLMEDCBLOE(this CGNNELOIABF LKCOHANNNDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB520", Offset = "0x5DAA920", VA = "0x185DAB520")]
	public static bool PHCHOKEOEAL(this CGNNELOIABF LKCOHANNNDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB4D0", Offset = "0x5DAA8D0", VA = "0x185DAB4D0")]
	public static bool NNFCGINLOHL(this CGNNELOIABF LKCOHANNNDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB440", Offset = "0x5DAA840", VA = "0x185DAB440")]
	public static bool DMGAPDBKGAP(this CGNNELOIABF LKCOHANNNDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface MAIPDEKHDOP
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool JMGKFCEFHMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	CAKFEHOBCAO DBJNLKBFEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
internal interface CNJPIPKMIKP
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<OGALCPHBFJB> HBOMIODELKD;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface DNHFDIEHCPF : PKPMIGECBKB<IKAJAHLJFMC>, IJNFIHACIMM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface FAGIAHAODNP<T> : JIMDNDNBHNB<IKAJAHLJFMC, T>, PKPMIGECBKB<IKAJAHLJFMC>, IJNFIHACIMM, IDisposable, DNHFDIEHCPF where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class PBAJDEMIFKI
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x23F5C90", Offset = "0x23F5090", VA = "0x1823F5C90")]
	public static bool ICFEPCNMLOH<T>(this PKPMIGECBKB<IKAJAHLJFMC> OIBKEMMFJDM, IKAJAHLJFMC MIPKLHDFLBO, [Out] T LPCGJALKADL) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x222B070", Offset = "0x222A470", VA = "0x18222B070")]
	public static bool FAJCEJLMNJF<T>(this PKPMIGECBKB<IKAJAHLJFMC> OIBKEMMFJDM, IKAJAHLJFMC MIPKLHDFLBO, [In] T GJFJLOBMJBE) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface LJEACGFBGAF : PKPMIGECBKB<CAKFEHOBCAO>, IJNFIHACIMM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface FACGOEDLDML<T> : JIMDNDNBHNB<CAKFEHOBCAO, T>, PKPMIGECBKB<CAKFEHOBCAO>, IJNFIHACIMM, IDisposable, LJEACGFBGAF where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class GHLLDGIHIKD
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x23C6B50", Offset = "0x23C5F50", VA = "0x1823C6B50")]
	public static T KJBHHOOLCCM<T>(this PKPMIGECBKB<CAKFEHOBCAO> OIBKEMMFJDM, CAKFEHOBCAO AJAFIOGCMHP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x23C6B10", Offset = "0x23C5F10", VA = "0x1823C6B10")]
	public static bool FAJCEJLMNJF<T>(this PKPMIGECBKB<CAKFEHOBCAO> OIBKEMMFJDM, CAKFEHOBCAO AJAFIOGCMHP, [In] T GJFJLOBMJBE) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct NHGDGBFBAIF : IComparable<NHGDGBFBAIF>, IEquatable<NHGDGBFBAIF>
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly NHGDGBFBAIF AJNJPGPIKEO;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly NHGDGBFBAIF KEABAAMENCA;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly NHGDGBFBAIF PMIJAAKNGEH;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly NHGDGBFBAIF BILMODGFJFF;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly NHGDGBFBAIF HDCGMIBNNCD;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly NHGDGBFBAIF NGMMIBGBLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int ICOODGEKGMA;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool KNEFJLLNJMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5DB07B0", Offset = "0x5DAFBB0", VA = "0x185DB07B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public int HHKCDJJHMHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5DB07C0", Offset = "0x5DAFBC0", VA = "0x185DB07C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7D2F60", Offset = "0x7D2360", VA = "0x1807D2F60")]
	public NHGDGBFBAIF(int JPEMHHILGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0850", Offset = "0x5DAFC50", VA = "0x185DB0850", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5DB07D0", Offset = "0x5DAFBD0", VA = "0x185DB07D0", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x15EFF70", Offset = "0x15EF370", VA = "0x1815EFF70", Slot = "5")]
	public bool Equals(NHGDGBFBAIF KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x15FE540", Offset = "0x15FD940", VA = "0x1815FE540", Slot = "4")]
	public int CompareTo(NHGDGBFBAIF KEEHOGPOIFD)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0xBD40E0", Offset = "0xBD34E0", VA = "0x180BD40E0")]
	public static NHGDGBFBAIF DLNOOKJDMMJ(int JPEMHHILGGG)
	{
		return default(NHGDGBFBAIF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xBD40E0", Offset = "0xBD34E0", VA = "0x180BD40E0")]
	public static int DLNOOKJDMMJ(NHGDGBFBAIF LNAKMGONIOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DB08B0", Offset = "0x5DAFCB0", VA = "0x185DB08B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public readonly struct BAJJJAGOPJE : IEquatable<BAJJJAGOPJE>, MAIPDEKHDOP
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly BAJJJAGOPJE OIEMKDCLNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public CAKFEHOBCAO DBJNLKBFEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790", Slot = "6")]
		get
		{
			return default(CAKFEHOBCAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public HLCKIENKHEB LGIAJFCOGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(HLCKIENKHEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public HHJDNEMOPBF EFBMJCLPBLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(HHJDNEMOPBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private CDJJECGMMII LCJLLGELGBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4120", Offset = "0x5DA3520", VA = "0x185DA4120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public GameObject GHAOKLKOOCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5DA5510", Offset = "0x5DA4910", VA = "0x185DA5510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public IKAJAHLJFMC HKBIBMLBFBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4E90", Offset = "0x5DA4290", VA = "0x185DA4E90")]
		get
		{
			return default(IKAJAHLJFMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public PLMJAAHFMOO CIBGGJJFEJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4DA0", Offset = "0x5DA41A0", VA = "0x185DA4DA0")]
		get
		{
			return default(PLMJAAHFMOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public HNGHCMBBKEB GCOOEFPKEFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5DA49E0", Offset = "0x5DA3DE0", VA = "0x185DA49E0")]
		get
		{
			return default(HNGHCMBBKEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool LBIODPPHJDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5DA5370", Offset = "0x5DA4770", VA = "0x185DA5370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool IHGJEGFNHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4BC0", Offset = "0x5DA3FC0", VA = "0x185DA4BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool FIAMPGGCLLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5DA5470", Offset = "0x5DA4870", VA = "0x185DA5470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool LLGCBHPDFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5DA53D0", Offset = "0x5DA47D0", VA = "0x185DA53D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool JAIOBJPCJAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5DA5390", Offset = "0x5DA4790", VA = "0x185DA5390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool ICDEGINNHKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5DA5000", Offset = "0x5DA4400", VA = "0x185DA5000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool FLGONMKGDML
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4FE0", Offset = "0x5DA43E0", VA = "0x185DA4FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool LBGGNDLEHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4BE0", Offset = "0x5DA3FE0", VA = "0x185DA4BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool HFBBLHKCBNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5DA53B0", Offset = "0x5DA47B0", VA = "0x185DA53B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public OOCOKOLKPEF DKOLHBFMBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(OOCOKOLKPEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public KNNGANGPLHD OBIHKLGLDFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(KNNGANGPLHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public BJKOCFKAFGD CEAOLLGHOLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BJKOCFKAFGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public NAADPBIIKFF FKKHGIJOHLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(NAADPBIIKFF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public FDLDEBDGMCO CPCCPCBLEDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(FDLDEBDGMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public NDOKNJLDJNC HNMEDLBAMEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(NDOKNJLDJNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public ALMEJJCLCED GNCIMIPDOFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(ALMEJJCLCED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool BDLMEDCBLOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5DA5060", Offset = "0x5DA4460", VA = "0x185DA5060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool JKALNAELGKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4D50", Offset = "0x5DA4150", VA = "0x185DA4D50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	private bool LILHIOHGCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x77E3E0", Offset = "0x77D7E0", VA = "0x18077E3E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1ED65C0", Offset = "0x1ED59C0", VA = "0x181ED65C0")]
	public BAJJJAGOPJE(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4110", Offset = "0x5DA3510", VA = "0x185DA4110")]
	public static bool DLNOOKJDMMJ(BAJJJAGOPJE LPCGJALKADL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
	public static CAKFEHOBCAO DLNOOKJDMMJ(BAJJJAGOPJE LPCGJALKADL)
	{
		return default(CAKFEHOBCAO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5DA5160", Offset = "0x5DA4560", VA = "0x185DA5160")]
	public static bool HCMKGGFOPFL(BAJJJAGOPJE BOGGCLFEFDJ, BAJJJAGOPJE OGHJEHJOFGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5DA5020", Offset = "0x5DA4420", VA = "0x185DA5020")]
	public static bool GKDOMDKCOOJ(BAJJJAGOPJE BOGGCLFEFDJ, BAJJJAGOPJE OGHJEHJOFGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4C30", Offset = "0x5DA4030", VA = "0x185DA4C30", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(BAJJJAGOPJE KEEHOGPOIFD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
	public static BAJJJAGOPJE DLNOOKJDMMJ(CAKFEHOBCAO PCOAABDKEED)
	{
		return default(BAJJJAGOPJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5DA52A0", Offset = "0x5DA46A0", VA = "0x185DA52A0")]
	public PNAAPOCOKHE HLJCLJNEJID()
	{
		return default(PNAAPOCOKHE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4F80", Offset = "0x5DA4380", VA = "0x185DA4F80")]
	public DGNDEBEIMLG FOAINOKEHAH()
	{
		return default(DGNDEBEIMLG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5DA5320", Offset = "0x5DA4720", VA = "0x185DA5320")]
	public IINKIDGMBIP ICPEFIFCELP()
	{
		return default(IINKIDGMBIP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5DA53F0", Offset = "0x5DA47F0", VA = "0x185DA53F0")]
	public EBLBJNHIABP MGHBPONNOIN()
	{
		return default(EBLBJNHIABP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4AD0", Offset = "0x5DA3ED0", VA = "0x185DA4AD0")]
	public void ALDDGBMMJNL([Optional] object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5DA5490", Offset = "0x5DA4890", VA = "0x185DA5490")]
	public bool NFIDNGBGDFA(object IBLOMPOENGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4CD0", Offset = "0x5DA40D0", VA = "0x185DA4CD0")]
	public bool FDDJPIDFEJE(object IBLOMPOENGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5DA5650", Offset = "0x5DA4A50", VA = "0x185DA5650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct ALMEJJCLCED : IEquatable<ALMEJJCLCED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public CAKFEHOBCAO DBJNLKBFEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(CAKFEHOBCAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	private CDJJECGMMII LCJLLGELGBE
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4120", Offset = "0x5DA3520", VA = "0x185DA4120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	private CPBLFKHDDGN NKHNPFLPACC
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5DA3E30", Offset = "0x5DA3230", VA = "0x185DA3E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	private CMLGHDCNGPG NLPMGFABBEP
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4080", Offset = "0x5DA3480", VA = "0x185DA4080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool BHLPKBKNODM
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4630", Offset = "0x5DA3A30", VA = "0x185DA4630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public Guid HLMJOIBMECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4310", Offset = "0x5DA3710", VA = "0x185DA4310")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool KLBBHODBIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4720", Offset = "0x5DA3B20", VA = "0x185DA4720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Guid GHAGOGIMHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4200", Offset = "0x5DA3600", VA = "0x185DA4200")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1ED65C0", Offset = "0x1ED59C0", VA = "0x181ED65C0")]
	public ALMEJJCLCED(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4110", Offset = "0x5DA3510", VA = "0x185DA4110")]
	public static bool DLNOOKJDMMJ(ALMEJJCLCED LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4130", Offset = "0x5DA3530", VA = "0x185DA4130", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(ALMEJJCLCED KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3D10", VA = "0x185DA4910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3E90", Offset = "0x5DA3290", VA = "0x185DA3E90")]
	public bool CDOEEOBKFMM([Out] Guid OFLFFIGFOIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4800", Offset = "0x5DA3C00", VA = "0x185DA4800")]
	public void NHOBFOFGMLM(Guid FLJKEGLJDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4530", Offset = "0x5DA3930", VA = "0x185DA4530")]
	public bool MFKCFCIAJIF([Out] Guid CNCFOBBIEIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4420", Offset = "0x5DA3820", VA = "0x185DA4420")]
	public void LNBGIIMKAPM(Guid FLJKEGLJDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3F90", Offset = "0x5DA3390", VA = "0x185DA3F90")]
	public void CMBOGPPCDHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct EBLBJNHIABP : IEquatable<EBLBJNHIABP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public CAKFEHOBCAO DBJNLKBFEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(CAKFEHOBCAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	private CDJJECGMMII LCJLLGELGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4120", Offset = "0x5DA3520", VA = "0x185DA4120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	private CPBLFKHDDGN NKHNPFLPACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8BE0", Offset = "0x5DA7FE0", VA = "0x185DA8BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	private GLJHEKCADEF PKJBNENDLPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8F00", Offset = "0x5DA8300", VA = "0x185DA8F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float3 IPIGEAJMEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8D50", Offset = "0x5DA8150", VA = "0x185DA8D50")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public quaternion ONLNDEOFAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8F90", Offset = "0x5DA8390", VA = "0x185DA8F90")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public BAJJJAGOPJE BBJCMEDNLBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8C40", Offset = "0x5DA8040", VA = "0x185DA8C40")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1ED65C0", Offset = "0x1ED59C0", VA = "0x181ED65C0")]
	public EBLBJNHIABP(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
	public static CAKFEHOBCAO DLNOOKJDMMJ(EBLBJNHIABP LPCGJALKADL)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8E60", Offset = "0x5DA8260", VA = "0x185DA8E60", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(EBLBJNHIABP KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3D10", VA = "0x185DA4910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public readonly struct PNAAPOCOKHE : IEquatable<PNAAPOCOKHE>
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly PNAAPOCOKHE OIEMKDCLNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public CAKFEHOBCAO DBJNLKBFEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(CAKFEHOBCAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public HLCKIENKHEB LGIAJFCOGHM
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(HLCKIENKHEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public HHJDNEMOPBF EFBMJCLPBLE
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(HHJDNEMOPBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private CDJJECGMMII LCJLLGELGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4120", Offset = "0x5DA3520", VA = "0x185DA4120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private CPBLFKHDDGN NKHNPFLPACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5DB22B0", Offset = "0x5DB16B0", VA = "0x185DB22B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private GMEBHOOMEDK HJFLFMKEGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2310", Offset = "0x5DB1710", VA = "0x185DB2310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public KLCLLLJMBOO PNFOMKEBDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2E70", Offset = "0x5DB2270", VA = "0x185DB2E70")]
		get
		{
			return default(KLCLLLJMBOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public IEnumerable<BAJJJAGOPJE> JCAOBOKADOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5DB28F0", Offset = "0x5DB1CF0", VA = "0x185DB28F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public IEnumerable<BAJJJAGOPJE> BDOBJPLAJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2740", Offset = "0x5DB1B40", VA = "0x185DB2740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public int BJMHAHBINFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5DB21C0", Offset = "0x5DB15C0", VA = "0x185DB21C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int LJNCOPNPEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2A60", Offset = "0x5DB1E60", VA = "0x185DB2A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public string PDBKHDHIBAE
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5DB23C0", Offset = "0x5DB17C0", VA = "0x185DB23C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public GIPDCNOKOFM AANFAGEAKHB
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2650", Offset = "0x5DB1A50", VA = "0x185DB2650")]
		get
		{
			return default(GIPDCNOKOFM);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2870", Offset = "0x5DB1C70", VA = "0x185DB2870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public JCINPLFGCIG EFKCGHFHEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5DB26D0", Offset = "0x5DB1AD0", VA = "0x185DB26D0")]
		get
		{
			return default(JCINPLFGCIG);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2F90", Offset = "0x5DB2390", VA = "0x185DB2F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool DBDDFCJGCEL
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2490", Offset = "0x5DB1890", VA = "0x185DB2490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool FAPGLMAJFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2610", Offset = "0x5DB1A10", VA = "0x185DB2610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool ICKAFIOBEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5DB23A0", Offset = "0x5DB17A0", VA = "0x185DB23A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool BIHDJJCEELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2630", Offset = "0x5DB1A30", VA = "0x185DB2630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool CPJCENACIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2E60", Offset = "0x5DB2260", VA = "0x185DB2E60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5DB24B0", Offset = "0x5DB18B0", VA = "0x185DB24B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool GNHJFGEOPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2560", Offset = "0x5DB1960", VA = "0x185DB2560")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5DB26C0", Offset = "0x5DB1AC0", VA = "0x185DB26C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1ED65C0", Offset = "0x1ED59C0", VA = "0x181ED65C0")]
	public PNAAPOCOKHE(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4110", Offset = "0x5DA3510", VA = "0x185DA4110")]
	public static bool DLNOOKJDMMJ(PNAAPOCOKHE LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2570", Offset = "0x5DB1970", VA = "0x185DB2570", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(PNAAPOCOKHE KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3D10", VA = "0x185DA4910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
	public static BAJJJAGOPJE DLNOOKJDMMJ(PNAAPOCOKHE MIPCMNILFEO)
	{
		return default(BAJJJAGOPJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2540", Offset = "0x5DB1940", VA = "0x185DB2540")]
	public bool EIFLPCAAIMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5DB24C0", Offset = "0x5DB18C0", VA = "0x185DB24C0")]
	public bool EHBHDHDCGBA(KLIANFEEIOH LGHBOELIKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2AB0", Offset = "0x5DB1EB0", VA = "0x185DB2AB0")]
	public void LDIMNIFPCOM(KLIANFEEIOH LGHBOELIKLL, bool LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2C70", Offset = "0x5DB2070", VA = "0x185DB2C70")]
	public KLCLLLJMBOO NBBCIDHFPLG(Allocator JIIMEDFKEME)
	{
		return default(KLCLLLJMBOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2B40", Offset = "0x5DB1F40", VA = "0x185DB2B40")]
	public void MEOFAGDAFIJ(PNAAPOCOKHE KEEHOGPOIFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct HNKDJGGCIMI : IEquatable<HNKDJGGCIMI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE2B0", Offset = "0x5DAD6B0", VA = "0x185DAE2B0", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(HNKDJGGCIMI KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3D10", VA = "0x185DA4910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct KNNGANGPLHD : IEquatable<KNNGANGPLHD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private CDJJECGMMII LCJLLGELGBE
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4120", Offset = "0x5DA3520", VA = "0x185DA4120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x1ED65C0", Offset = "0x1ED59C0", VA = "0x181ED65C0")]
	public KNNGANGPLHD(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF4E0", Offset = "0x5DAE8E0", VA = "0x185DAF4E0", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(KNNGANGPLHD KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3D10", VA = "0x185DA4910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF580", Offset = "0x5DAE980", VA = "0x185DAF580")]
	public void OMMIKAHKMGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF670", Offset = "0x5DAEA70", VA = "0x185DAF670")]
	public void PICMAPEPIMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct PBJLPCJNMBN : IEquatable<PBJLPCJNMBN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1FE0", Offset = "0x5DB13E0", VA = "0x185DB1FE0", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(PBJLPCJNMBN KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3D10", VA = "0x185DA4910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct AONIFDGJPJK : IEquatable<AONIFDGJPJK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4940", Offset = "0x5DA3D40", VA = "0x185DA4940", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(AONIFDGJPJK KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3D10", VA = "0x185DA4910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct PMILBIDLJCN : IEquatable<PMILBIDLJCN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2120", Offset = "0x5DB1520", VA = "0x185DB2120", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(PMILBIDLJCN KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3D10", VA = "0x185DA4910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct PCMBDLNLDCC : IEquatable<PCMBDLNLDCC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2080", Offset = "0x5DB1480", VA = "0x185DB2080", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(PCMBDLNLDCC KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3D10", VA = "0x185DA4910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct HHJDNEMOPBF : IEquatable<HHJDNEMOPBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public CAKFEHOBCAO DBJNLKBFEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(CAKFEHOBCAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private CDJJECGMMII LCJLLGELGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4120", Offset = "0x5DA3520", VA = "0x185DA4120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private CPBLFKHDDGN NKHNPFLPACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x5DAB7D0", Offset = "0x5DAABD0", VA = "0x185DAB7D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private GMEBHOOMEDK HJFLFMKEGKO
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5DAB830", Offset = "0x5DAAC30", VA = "0x185DAB830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public CAKFEHOBCAO ALFBPAGABIK
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5DAB8C0", Offset = "0x5DAACC0", VA = "0x185DAB8C0")]
		get
		{
			return default(CAKFEHOBCAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public BAJJJAGOPJE KDDFGHHFEPG
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5DABA70", Offset = "0x5DAAE70", VA = "0x185DABA70")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public BAJJJAGOPJE BFOGAKMAJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5DABB80", Offset = "0x5DAAF80", VA = "0x185DABB80")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1ED65C0", Offset = "0x1ED59C0", VA = "0x181ED65C0")]
	public HHJDNEMOPBF(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB9D0", Offset = "0x5DAADD0", VA = "0x185DAB9D0", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(HHJDNEMOPBF KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3D10", VA = "0x185DA4910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5DABC90", Offset = "0x5DAB090", VA = "0x185DABC90")]
	public bool LEKFLKBIABP(BAJJJAGOPJE DCLCDDGJKIC, bool HLAFCEMDKOA = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5DABDB0", Offset = "0x5DAB1B0", VA = "0x185DABDB0")]
	public bool OMHDFCIKAMC(BAJJJAGOPJE JHJELAILOKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public readonly struct OOCOKOLKPEF : IEquatable<OOCOKOLKPEF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public string NDGMEGMCDLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1970", Offset = "0x5DB0D70", VA = "0x185DB1970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public string DDJHEJGHIOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1860", Offset = "0x5DB0C60", VA = "0x185DB1860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x1ED65C0", Offset = "0x1ED59C0", VA = "0x181ED65C0")]
	public OOCOKOLKPEF(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5DB18D0", Offset = "0x5DB0CD0", VA = "0x185DB18D0", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(OOCOKOLKPEF KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3D10", VA = "0x185DA4910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct CKIKPMAMJJJ : IEquatable<CKIKPMAMJJJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5DA7FF0", Offset = "0x5DA73F0", VA = "0x185DA7FF0", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(CKIKPMAMJJJ KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3D10", VA = "0x185DA4910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct BJKOCFKAFGD : IEquatable<BJKOCFKAFGD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x1ED65C0", Offset = "0x1ED59C0", VA = "0x181ED65C0")]
	public BJKOCFKAFGD(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6530", Offset = "0x5DA5930", VA = "0x185DA6530", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(BJKOCFKAFGD KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3D10", VA = "0x185DA4910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x5DA65D0", Offset = "0x5DA59D0", VA = "0x185DA65D0")]
	public bool LADANOBHLDO([Out] Collider MHOODELGFIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct NAADPBIIKFF : IEquatable<NAADPBIIKFF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public CAKFEHOBCAO DBJNLKBFEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(CAKFEHOBCAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private CDJJECGMMII LCJLLGELGBE
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4120", Offset = "0x5DA3520", VA = "0x185DA4120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private CPBLFKHDDGN NKHNPFLPACC
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF8E0", Offset = "0x5DAECE0", VA = "0x185DAF8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private CGPANMIAIOE DKFFONOPOIK
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFFA0", Offset = "0x5DAF3A0", VA = "0x185DAFFA0")]
		get
		{
			return default(CGPANMIAIOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool CMHDOJFICJD
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFD80", Offset = "0x5DAF180", VA = "0x185DAFD80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool ELHPAOMAPMG
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0010", Offset = "0x5DAF410", VA = "0x185DB0010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool KMCLACJLLOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFE50", Offset = "0x5DAF250", VA = "0x185DAFE50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool PPDCIOFJAPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFB70", Offset = "0x5DAEF70", VA = "0x185DAFB70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool HPDKELMPDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFC20", Offset = "0x5DAF020", VA = "0x185DAFC20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool APAMPIJDELA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFD60", Offset = "0x5DAF160", VA = "0x185DAFD60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool GPHPBJAGGJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFB60", Offset = "0x5DAEF60", VA = "0x185DAFB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool HNLGLJCIMDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFE70", Offset = "0x5DAF270", VA = "0x185DAFE70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool MBIGHDDBGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFE60", Offset = "0x5DAF260", VA = "0x185DAFE60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool NHMKDEOEACJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFCC0", Offset = "0x5DAF0C0", VA = "0x185DAFCC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool DNBHACFKBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0020", Offset = "0x5DAF420", VA = "0x185DB0020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool MMLIBKKPCII
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFD50", Offset = "0x5DAF150", VA = "0x185DAFD50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool JKGGFJACEIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFB50", Offset = "0x5DAEF50", VA = "0x185DAFB50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool FNLFKLIDFGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFCB0", Offset = "0x5DAF0B0", VA = "0x185DAFCB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool OEOKMEMMJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0030", Offset = "0x5DAF430", VA = "0x185DB0030")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFD70", Offset = "0x5DAF170", VA = "0x185DAFD70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool EDPBNPBIKEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFA00", Offset = "0x5DAEE00", VA = "0x185DAFA00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public PJIHJNCGMAC HBKIPKCHIPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFDE0", Offset = "0x5DAF1E0", VA = "0x185DAFDE0")]
		get
		{
			return default(PJIHJNCGMAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool PMADOLGELAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFAD0", Offset = "0x5DAEED0", VA = "0x185DAFAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public Vector3 KNHPIHKIKMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0040", Offset = "0x5DAF440", VA = "0x185DB0040")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 DBFIBCNGIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF940", Offset = "0x5DAED40", VA = "0x185DAF940")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool FCBMDDJNKON
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFE80", Offset = "0x5DAF280", VA = "0x185DAFE80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x1ED65C0", Offset = "0x1ED59C0", VA = "0x181ED65C0")]
	public NAADPBIIKFF(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x5DAFB80", Offset = "0x5DAEF80", VA = "0x185DAFB80", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(NAADPBIIKFF KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3D10", VA = "0x185DA4910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x5DAFC30", Offset = "0x5DAF030", VA = "0x185DAFC30")]
	public bool FNGBBLCOPOE(MNDOHIPFFMC LGHBOELIKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5DAFCD0", Offset = "0x5DAF0D0", VA = "0x185DAFCD0")]
	public bool GPBOHLLAAOI(AGMJJKFLOHH LGHBOELIKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0120", Offset = "0x5DAF520", VA = "0x185DB0120")]
	public void PLGKNJIFKLL(AGMJJKFLOHH LGHBOELIKLL, bool FAGLGPEMPJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct IINKIDGMBIP : IEquatable<IINKIDGMBIP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private CBNMJPKELMG ONECPIHJCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x5DAE530", Offset = "0x5DAD930", VA = "0x185DAE530")]
		get
		{
			return default(CBNMJPKELMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public IDDFBLEEJOO NKPLPOELLFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x5DAE5A0", Offset = "0x5DAD9A0", VA = "0x185DAE5A0")]
		get
		{
			return default(IDDFBLEEJOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x1ED65C0", Offset = "0x1ED59C0", VA = "0x181ED65C0")]
	public IINKIDGMBIP(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE490", Offset = "0x5DAD890", VA = "0x185DAE490", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(IINKIDGMBIP KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3D10", VA = "0x185DA4910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE3F0", Offset = "0x5DAD7F0", VA = "0x185DAE3F0")]
	public NCNMAFGBAIJ CKKGLOFAGBE()
	{
		return default(NCNMAFGBAIJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct NCNMAFGBAIJ : IEquatable<NCNMAFGBAIJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private DLDHEGGEIKL JAOJBKLJPHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0230", Offset = "0x5DAF630", VA = "0x185DB0230")]
		get
		{
			return default(DLDHEGGEIKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public OOOKHLEFLPC DPAEEAIGPNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5DB01B0", Offset = "0x5DAF5B0", VA = "0x185DB01B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x1ED65C0", Offset = "0x1ED59C0", VA = "0x181ED65C0")]
	public NCNMAFGBAIJ(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5DB02A0", Offset = "0x5DAF6A0", VA = "0x185DB02A0", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(NCNMAFGBAIJ KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3D10", VA = "0x185DA4910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct NDOKNJLDJNC : IEquatable<NDOKNJLDJNC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public CAKFEHOBCAO DBJNLKBFEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(CAKFEHOBCAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private CDJJECGMMII LCJLLGELGBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4120", Offset = "0x5DA3520", VA = "0x185DA4120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private CPBLFKHDDGN NKHNPFLPACC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0340", Offset = "0x5DAF740", VA = "0x185DB0340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x1ED65C0", Offset = "0x1ED59C0", VA = "0x181ED65C0")]
	public NDOKNJLDJNC(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0500", Offset = "0x5DAF900", VA = "0x185DB0500", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(NDOKNJLDJNC KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3D10", VA = "0x185DA4910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5DB05A0", Offset = "0x5DAF9A0", VA = "0x185DB05A0")]
	public void GJCNHNDJGBM(bool LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5DB03A0", Offset = "0x5DAF7A0", VA = "0x185DB03A0")]
	public void BBHDHNHEGGC(bool LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x24E41E0", Offset = "0x24E35E0", VA = "0x1824E41E0")]
	public T EKDJKGFLNPI<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct FDLDEBDGMCO : IEquatable<FDLDEBDGMCO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public CAKFEHOBCAO DBJNLKBFEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(CAKFEHOBCAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private CDJJECGMMII LCJLLGELGBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4120", Offset = "0x5DA3520", VA = "0x185DA4120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private CPBLFKHDDGN NKHNPFLPACC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA200", Offset = "0x5DA9600", VA = "0x185DAA200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private NCBLCPIDIEA ACBGKJNPJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA440", Offset = "0x5DA9840", VA = "0x185DAA440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool LOHAEJHJHFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA4D0", Offset = "0x5DA98D0", VA = "0x185DAA4D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool PNLMJPLKJHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA010", Offset = "0x5DA9410", VA = "0x185DAA010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool DFLBJGAIGIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5DAAA10", Offset = "0x5DA9E10", VA = "0x185DAAA10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool COEGIOPFMHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5DAAA40", Offset = "0x5DA9E40", VA = "0x185DAAA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool CBIPBBJEPBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA5C0", Offset = "0x5DA99C0", VA = "0x185DAA5C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool INCJHNKDFDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA830", Offset = "0x5DA9C30", VA = "0x185DAA830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x1ED65C0", Offset = "0x1ED59C0", VA = "0x181ED65C0")]
	public FDLDEBDGMCO(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4110", Offset = "0x5DA3510", VA = "0x185DA4110")]
	public static bool DLNOOKJDMMJ(FDLDEBDGMCO LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA3A0", Offset = "0x5DA97A0", VA = "0x185DAA3A0", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(FDLDEBDGMCO KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3D10", VA = "0x185DA4910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAB50", Offset = "0x5DA9F50", VA = "0x185DAAB50")]
	public bool MLALINOABPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA260", Offset = "0x5DA9660", VA = "0x185DAA260")]
	public BAJJJAGOPJE CMJLKNCPHMA(BAJJJAGOPJE ADOGMMPMLJB)
	{
		return default(BAJJJAGOPJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAB90", Offset = "0x5DA9F90", VA = "0x185DAAB90")]
	public CAKFEHOBCAO OPBEPHNDGBI()
	{
		return default(CAKFEHOBCAO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct DGNDEBEIMLG : IEquatable<DGNDEBEIMLG>
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly DGNDEBEIMLG OIEMKDCLNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public CAKFEHOBCAO DBJNLKBFEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(CAKFEHOBCAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public HLCKIENKHEB LGIAJFCOGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(HLCKIENKHEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	private LENBEMCFAMM OHIKEKJKIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x5DA89D0", Offset = "0x5DA7DD0", VA = "0x185DA89D0")]
		get
		{
			return default(LENBEMCFAMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public GINLDGMCKAC BAJLFFDNNED
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8460", Offset = "0x5DA7860", VA = "0x185DA8460")]
		get
		{
			return default(GINLDGMCKAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public JPDGCFMHNPC FGMHFKKPFAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8550", Offset = "0x5DA7950", VA = "0x185DA8550")]
		get
		{
			return default(JPDGCFMHNPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public OEMEJPDOAIM GDPPIFGNPEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8AB0", Offset = "0x5DA7EB0", VA = "0x185DA8AB0")]
		get
		{
			return default(OEMEJPDOAIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public DFOLKCOBCLF PBFGKMMKABK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5DA88D0", Offset = "0x5DA7CD0", VA = "0x185DA88D0")]
		get
		{
			return default(DFOLKCOBCLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public DCIDHALDCEC ECDKMOIOOBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8690", Offset = "0x5DA7A90", VA = "0x185DA8690")]
		get
		{
			return default(DCIDHALDCEC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x5DA82D0", Offset = "0x5DA76D0", VA = "0x185DA82D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public LLJDLBGKLMH JGPBGJCKBJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8A40", Offset = "0x5DA7E40", VA = "0x185DA8A40")]
		get
		{
			return default(LLJDLBGKLMH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x5DA84D0", Offset = "0x5DA78D0", VA = "0x185DA84D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public float ENHMBGAOJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8350", Offset = "0x5DA7750", VA = "0x185DA8350")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8610", Offset = "0x5DA7A10", VA = "0x185DA8610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public Vector3 HIENOEMDKKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8240", Offset = "0x5DA7640", VA = "0x185DA8240")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8780", Offset = "0x5DA7B80", VA = "0x185DA8780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public float CGJMKJMGLEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8700", Offset = "0x5DA7B00", VA = "0x185DA8700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public OBIKGGNDJAN.FAKKOBNKBNF IDOMMKJAKGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8810", Offset = "0x5DA7C10", VA = "0x185DA8810")]
		get
		{
			return default(OBIKGGNDJAN.FAKKOBNKBNF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8950", Offset = "0x5DA7D50", VA = "0x185DA8950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x1ED65C0", Offset = "0x1ED59C0", VA = "0x181ED65C0")]
	public DGNDEBEIMLG(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4110", Offset = "0x5DA3510", VA = "0x185DA4110")]
	public static bool DLNOOKJDMMJ(DGNDEBEIMLG LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5DA83C0", Offset = "0x5DA77C0", VA = "0x185DA83C0", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(DGNDEBEIMLG KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3D10", VA = "0x185DA4910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5DA85C0", Offset = "0x5DA79C0", VA = "0x185DA85C0")]
	public LNDHJLHCOEC HIGFBFCGLDK()
	{
		return default(LNDHJLHCOEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8880", Offset = "0x5DA7C80", VA = "0x185DA8880")]
	public BHAKFOIGDML KNGMIKEOLCG()
	{
		return default(BHAKFOIGDML);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct LNDHJLHCOEC : IEquatable<LNDHJLHCOEC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public CAKFEHOBCAO DBJNLKBFEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(CAKFEHOBCAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public DGNDEBEIMLG MDCKGNJACLM
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(DGNDEBEIMLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private GMDGNLKFALJ KDFKBDGKMDG
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF760", Offset = "0x5DAEB60", VA = "0x185DAF760")]
		get
		{
			return default(GMDGNLKFALJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public JHDIEJNPMMJ MKBHBOPJGND
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF870", Offset = "0x5DAEC70", VA = "0x185DAF870")]
		get
		{
			return default(JHDIEJNPMMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x1ED65C0", Offset = "0x1ED59C0", VA = "0x181ED65C0")]
	public LNDHJLHCOEC(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4110", Offset = "0x5DA3510", VA = "0x185DA4110")]
	public static bool DLNOOKJDMMJ(LNDHJLHCOEC LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF7D0", Offset = "0x5DAEBD0", VA = "0x185DAF7D0", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(LNDHJLHCOEC KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3D10", VA = "0x185DA4910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public readonly struct BHAKFOIGDML : IEquatable<BHAKFOIGDML>
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly BHAKFOIGDML OIEMKDCLNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public CAKFEHOBCAO DBJNLKBFEIC
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(CAKFEHOBCAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public HLCKIENKHEB LGIAJFCOGHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(HLCKIENKHEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private CDJJECGMMII LCJLLGELGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4120", Offset = "0x5DA3520", VA = "0x185DA4120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private CPBLFKHDDGN NKHNPFLPACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x5DA5840", Offset = "0x5DA4C40", VA = "0x185DA5840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private EEJAONCFMLK NIEPLNGJGKP
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x5DA60C0", Offset = "0x5DA54C0", VA = "0x185DA60C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public DGNDEBEIMLG MDCKGNJACLM
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(DGNDEBEIMLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public LOAAMPEDBNJ KKJDCKOMBLD
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x5DA5730", Offset = "0x5DA4B30", VA = "0x185DA5730")]
		get
		{
			return default(LOAAMPEDBNJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6330", Offset = "0x5DA5730", VA = "0x185DA6330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public IEnumerable<POOIEFEDADK> OOLPONPILIO
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x5DA58A0", Offset = "0x5DA4CA0", VA = "0x185DA58A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public POOIEFEDADK ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x5DA5A90", Offset = "0x5DA4E90", VA = "0x185DA5A90")]
		get
		{
			return default(POOIEFEDADK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6150", Offset = "0x5DA5550", VA = "0x185DA6150")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x1ED65C0", Offset = "0x1ED59C0", VA = "0x181ED65C0")]
	public BHAKFOIGDML(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4110", Offset = "0x5DA3510", VA = "0x185DA4110")]
	public static bool DLNOOKJDMMJ(BHAKFOIGDML LPCGJALKADL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5DA5160", Offset = "0x5DA4560", VA = "0x185DA5160")]
	public static bool HCMKGGFOPFL(BHAKFOIGDML BOGGCLFEFDJ, BHAKFOIGDML OGHJEHJOFGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5DA5DE0", Offset = "0x5DA51E0", VA = "0x185DA5DE0", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(BHAKFOIGDML KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3D10", VA = "0x185DA4910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x5DA5BB0", Offset = "0x5DA4FB0", VA = "0x185DA5BB0")]
	public POOIEFEDADK EMPJPFIOCIH(float3? BAONBICGOEJ, [Optional] quaternion? CKFJFCLIANA, [Optional] Vector3? IJMHENINMDB)
	{
		return default(POOIEFEDADK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x5DA5E80", Offset = "0x5DA5280", VA = "0x185DA5E80")]
	public POOIEFEDADK FDOKNFHKCAH(int JPEMHHILGGG, float3? BAONBICGOEJ, [Optional] quaternion? CKFJFCLIANA, [Optional] Vector3? IJMHENINMDB)
	{
		return default(POOIEFEDADK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6240", Offset = "0x5DA5640", VA = "0x185DA6240")]
	public void KIHHJLPPGAD(int JPEMHHILGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6440", Offset = "0x5DA5840", VA = "0x185DA6440")]
	public void OOAOJFKKMLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct POOIEFEDADK : IEquatable<POOIEFEDADK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public CAKFEHOBCAO DBJNLKBFEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(CAKFEHOBCAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public BHAKFOIGDML LNFCCMDIGDP
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3010", Offset = "0x5DB2410", VA = "0x185DB3010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public float3 MBLHMGPEFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x5DB34E0", Offset = "0x5DB28E0", VA = "0x185DB34E0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x5DB35E0", Offset = "0x5DB29E0", VA = "0x185DB35E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public quaternion JFMPNIDBDLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x5DB30A0", Offset = "0x5DB24A0", VA = "0x185DB30A0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3450", Offset = "0x5DB2850", VA = "0x185DB3450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public float3 AOKNLNFPDPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x5DB32B0", Offset = "0x5DB26B0", VA = "0x185DB32B0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3340", Offset = "0x5DB2740", VA = "0x185DB3340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public KIEGJAEKKEG DHMHBKFIBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x5DB33D0", Offset = "0x5DB27D0", VA = "0x185DB33D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	private KHHENODABGD OHJDEMCAAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3570", Offset = "0x5DB2970", VA = "0x185DB3570")]
		get
		{
			return default(KHHENODABGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	private ACPDHGGBBNL KCLPMMAKPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x5DB36E0", Offset = "0x5DB2AE0", VA = "0x185DB36E0")]
		get
		{
			return default(ACPDHGGBBNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private AKFEABIFKHA CEADOKFCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3130", Offset = "0x5DB2530", VA = "0x185DB3130")]
		get
		{
			return default(AKFEABIFKHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private EKCMFEFPIDJ IHDOHNKKBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x5DB31A0", Offset = "0x5DB25A0", VA = "0x185DB31A0")]
		get
		{
			return default(EKCMFEFPIDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private EPLCLMJNBKC EHINOJMNKAH
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3670", Offset = "0x5DB2A70", VA = "0x185DB3670")]
		get
		{
			return default(EPLCLMJNBKC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x1ED65C0", Offset = "0x1ED59C0", VA = "0x181ED65C0")]
	public POOIEFEDADK(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3210", Offset = "0x5DB2610", VA = "0x185DB3210", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(POOIEFEDADK KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3D10", VA = "0x185DA4910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3010", Offset = "0x5DB2410", VA = "0x185DB3010")]
	public void DHDBPCOHKIM(BHAKFOIGDML LPCGJALKADL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct HLCKIENKHEB : IEquatable<HLCKIENKHEB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public BAJJJAGOPJE KNMGHOCIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x1ED6790", Offset = "0x1ED5B90", VA = "0x181ED6790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	private CDJJECGMMII LCJLLGELGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4120", Offset = "0x5DA3520", VA = "0x185DA4120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	private EPEIHHNCIHD EMBEKPBOBLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5DAD040", Offset = "0x5DAC440", VA = "0x185DAD040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public bool JHMGKLPCLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5DAD900", Offset = "0x5DACD00", VA = "0x185DAD900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public Vector3 MBLHMGPEFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x5DACCB0", Offset = "0x5DAC0B0", VA = "0x185DACCB0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x5DAD1F0", Offset = "0x5DAC5F0", VA = "0x185DAD1F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Quaternion JFMPNIDBDLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x5DABF60", Offset = "0x5DAB360", VA = "0x185DABF60")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x5DACBF0", Offset = "0x5DABFF0", VA = "0x185DACBF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public Vector3 JIOHNMPCCCM
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC210", Offset = "0x5DAB610", VA = "0x185DAC210")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC380", Offset = "0x5DAB780", VA = "0x185DAC380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public Quaternion PJDLILOOPJL
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5DAD2B0", Offset = "0x5DAC6B0", VA = "0x185DAD2B0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC660", Offset = "0x5DABA60", VA = "0x185DAC660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public float COMHGNIDJLO
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x5DACD80", Offset = "0x5DAC180", VA = "0x185DACD80")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x5DABEC0", Offset = "0x5DAB2C0", VA = "0x185DABEC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public float BLFDJHCMPAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x5DACEC0", Offset = "0x5DAC2C0", VA = "0x185DACEC0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 AOKNLNFPDPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC7C0", Offset = "0x5DABBC0", VA = "0x185DAC7C0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x5DACA30", Offset = "0x5DABE30", VA = "0x185DACA30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 LNODONPIGEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x5DADE30", Offset = "0x5DAD230", VA = "0x185DADE30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 EHFJABHJPIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC960", Offset = "0x5DABD60", VA = "0x185DAC960")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Matrix4x4 GHAEGJDIGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x5DACF40", Offset = "0x5DAC340", VA = "0x185DACF40")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x1ED65C0", Offset = "0x1ED59C0", VA = "0x181ED65C0")]
	public HLCKIENKHEB(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC720", Offset = "0x5DABB20", VA = "0x185DAC720", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x5DA41D0", Offset = "0x5DA35D0", VA = "0x185DA41D0", Slot = "4")]
	public bool Equals(HLCKIENKHEB KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3D10", VA = "0x185DA4910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD0C0", Offset = "0x5DAC4C0", VA = "0x185DAD0C0")]
	public NOGOGGHJDHE KEDFDOPKNLM()
	{
		return default(NOGOGGHJDHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x5DACAF0", Offset = "0x5DABEF0", VA = "0x185DACAF0")]
	public void GGPPKJPIKOM([Out] Matrix4x4 BFDECFAPKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD590", Offset = "0x5DAC990", VA = "0x185DAD590")]
	public void MGMFCEHDLMO([Out] Vector3 JBBBJKKBNPD, [Out] Quaternion NMGPAOCHONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC5C0", Offset = "0x5DAB9C0", VA = "0x185DAC5C0")]
	public void ECIDLHAOAHH([Out] RigidTransform GGNCKOFKBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x5DADFA0", Offset = "0x5DAD3A0", VA = "0x185DADFA0")]
	public CJOBJHHCGGP POJIHHGLOAI()
	{
		return default(CJOBJHHCGGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x5DADEF0", Offset = "0x5DAD2F0", VA = "0x185DADEF0")]
	public void POJIHHGLOAI([Out] CJOBJHHCGGP LOCOPBDKIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD8D0", Offset = "0x5DACCD0", VA = "0x185DAD8D0")]
	public CJOBJHHCGGP MLAMPHLIAEK()
	{
		return default(CJOBJHHCGGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD820", Offset = "0x5DACC20", VA = "0x185DAD820")]
	public void MLAMPHLIAEK([Out] CJOBJHHCGGP GGNCKOFKBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC890", Offset = "0x5DABC90", VA = "0x185DAC890")]
	public Vector3 FOIMDLGHOPD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x5DACF80", Offset = "0x5DAC380", VA = "0x185DACF80")]
	public void KDBAMBKBMAK([In] Vector3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD120", Offset = "0x5DAC520", VA = "0x185DAD120")]
	public Vector3 KEGJIIGHKDE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x5DADC20", Offset = "0x5DAD020", VA = "0x185DADC20")]
	public void PBHFKJEOLIA([In] Vector3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x5DADA20", Offset = "0x5DACE20", VA = "0x185DADA20")]
	public Quaternion ONPCLDDJECM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x5DACE00", Offset = "0x5DAC200", VA = "0x185DACE00")]
	public void JFOFKKNAHGL([In] Quaternion LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD3E0", Offset = "0x5DAC7E0", VA = "0x185DAD3E0")]
	public Quaternion LIEOCLOELCH()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC500", Offset = "0x5DAB900", VA = "0x185DAC500")]
	public void EBGIHCANICC([In] Quaternion LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD510", Offset = "0x5DAC910", VA = "0x185DAD510")]
	public float LODIFPINEAL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC2E0", Offset = "0x5DAB6E0", VA = "0x185DAC2E0")]
	public void BMNKFONIFDG(float LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x5DADCE0", Offset = "0x5DAD0E0", VA = "0x185DADCE0")]
	public float PBIEAAPIOKH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD6C0", Offset = "0x5DACAC0", VA = "0x185DAD6C0")]
	public void MIBBBHNADII(float LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC440", Offset = "0x5DAB840", VA = "0x185DAC440")]
	public void CNOCJDKBOFP([In] Vector3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x5DADD60", Offset = "0x5DAD160", VA = "0x185DADD60")]
	public Vector3 PDKBCNAGNHG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC150", Offset = "0x5DAB550", VA = "0x185DAC150")]
	public void BFPKHMPHDPM([In] Vector3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x5DADB50", Offset = "0x5DACF50", VA = "0x185DADB50")]
	public Vector3 PAICGNMPDGP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC090", Offset = "0x5DAB490", VA = "0x185DAC090")]
	public void BELDBNJGCLB([In] Vector3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD950", Offset = "0x5DACD50", VA = "0x185DAD950")]
	public Vector3 OMNKCNNIGGI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD760", Offset = "0x5DACB60", VA = "0x185DAD760")]
	public void MJIGIMEJFKC([In] Vector3 LPCGJALKADL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class NFHFHBILHME
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct IGJDCNPNCIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public Guid HILDEDLDEPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EEEJJKCLNDB JDFNJCJDIAG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct EEEJJKCLNDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int LPCGJALKADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int PFKFPFMGIFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int EMFDAJKAJOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int ALPHCOCMJKM;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x5DA90A0", Offset = "0x5DA84A0", VA = "0x185DA90A0")]
		public bool EBFJPHKJEMO([Out] IKAJAHLJFMC MIPKLHDFLBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5DA9120", Offset = "0x5DA8520", VA = "0x185DA9120")]
		public EEEJJKCLNDB(IKAJAHLJFMC MIPKLHDFLBO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0720", Offset = "0x5DAFB20", VA = "0x185DB0720")]
	public static Guid LPLMONIBPID(this IKAJAHLJFMC MIPKLHDFLBO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0700", Offset = "0x5DAFB00", VA = "0x185DB0700")]
	public static bool FIFBDMMLDNE(this Guid HILDEDLDEPK, [Out] IKAJAHLJFMC MIPKLHDFLBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal static class JPCLPBGIFNK
{
	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x5DAEA20", Offset = "0x5DADE20", VA = "0x185DAEA20")]
	public static CPBLFKHDDGN NKHNPFLPACC(this CAKFEHOBCAO KOJKDECJOKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE920", Offset = "0x5DADD20", VA = "0x185DAE920")]
	public static HONAKLLNIOE DELMCPMFCJC(this CAKFEHOBCAO KOJKDECJOKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x5DAEA80", Offset = "0x5DADE80", VA = "0x185DAEA80")]
	public static EntityManager PHDBLFJLAGP(this CAKFEHOBCAO KOJKDECJOKK)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x2418910", Offset = "0x2417D10", VA = "0x182418910")]
	public static T BDHJGONCABL<T>(this CAKFEHOBCAO KOJKDECJOKK) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x2419900", Offset = "0x2418D00", VA = "0x182419900")]
	public static bool GJGCHKFGOFL<T>(this CAKFEHOBCAO KOJKDECJOKK) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface MFLEFLGGBDF
{
	[Cpp2IlInjected.Token(Token = "0x17000109")]
	Guid INKJIFHJOJA
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BOBIOGDCFLG(Guid BJCCBIBLGOE, Guid JHFJHMCJKJM);

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task BBCLGDCIGPO(CAKFEHOBCAO NHAHHKGJMEN);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GMICMNBLMBA(CAKFEHOBCAO PPNMHLJNNKC, CAKFEHOBCAO DCLCDDGJKIC, [Out] Vector3 FJEACGMCDJE, [Out] Quaternion BFDFAOOEJAP);

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DNINNKAGLHH(ALMEJJCLCED BAAEHDODHFJ, Vector3 FJEACGMCDJE, Quaternion BFDFAOOEJAP);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public interface CMLGHDCNGPG
{
	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KLBBHODBIHC(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BHLPKBKNODM(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CDOEEOBKFMM(CAKFEHOBCAO AJAFIOGCMHP, [Out] Guid OFLFFIGFOIA);

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid LKCOGBHFJMM(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NHOBFOFGMLM(CAKFEHOBCAO AJAFIOGCMHP, Guid OFLFFIGFOIA);

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MFKCFCIAJIF(CAKFEHOBCAO AJAFIOGCMHP, [Out] Guid CNCFOBBIEIM);

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid ANJIMKAHKEO(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LNBGIIMKAPM(CAKFEHOBCAO AJAFIOGCMHP, Guid CNCFOBBIEIM);

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CMBOGPPCDHK(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CBKFCLMBIHF(CAKFEHOBCAO PPNMHLJNNKC, CAKFEHOBCAO DCLCDDGJKIC);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
public interface NAFMALLINPC
{
	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	Guid INKJIFHJOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPJHAKJGGOB(Guid OFLFFIGFOIA, Guid CNCFOBBIEIM, string DKFEAPHKBMP);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface EKBKOBJCEAO
{
	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	IReadOnlyCollection<BPMBFEJHHKF> GLIHDJHBKAL
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CPEBJLMJNCJ(int CEOOILAHGGI, [Out] BPMBFEJHHKF EHDKAJFMMFD);

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BPMBFEJHHKF OLHPKJLDOEH(Type DJMKKNDNCBM);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class OJFGBENEMOK
{
	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x252F0C0", Offset = "0x252E4C0", VA = "0x18252F0C0")]
	public static T OABKLKICEKC<T>(this EKBKOBJCEAO NPKOEECOIIM, Entity AHNNJNFIHFM) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x252F160", Offset = "0x252E560", VA = "0x18252F160")]
	public static BPMBFEJHHKF OLHPKJLDOEH<T>(this EKBKOBJCEAO NPKOEECOIIM) where T : struct, IComponent
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
public interface GLJHEKCADEF
{
	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	Func<HMJPDGHCKHI> LBALBOHAPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<CAKFEHOBCAO, CAKFEHOBCAO> BBIJGGGHIJG;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<CAKFEHOBCAO, CAKFEHOBCAO> CBCOGKMIMDC;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<CAKFEHOBCAO, CAKFEHOBCAO, CAKFEHOBCAO> CAIPHDJOBFK;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<CAKFEHOBCAO> BCKIJKIILII;

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color ABLENOAFODI(CAKFEHOBCAO AJAFIOGCMHP, int CHLEKMDCCGF);

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float3 DOCFILCILKH(CAKFEHOBCAO AJAFIOGCMHP, int CHLEKMDCCGF);

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GFKGOEMFKKA(CAKFEHOBCAO AJAFIOGCMHP, CAKFEHOBCAO PIFNMNCMMHD);

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	CAKFEHOBCAO LDBCOCPEGCB(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<CAKFEHOBCAO> NEBPMCOAEIH(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	CAKFEHOBCAO FNCIEIIHFBM(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JJBGCHDCBLA(CAKFEHOBCAO AJAFIOGCMHP, Vector3 MGNPLBJCIGD, Quaternion BPBIOAIOLLL);

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KNKDAAHKKIM(CAKFEHOBCAO AJAFIOGCMHP, float CBLNFJJIPNH);

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool ANLHDNLDAEB(CAKFEHOBCAO AJAFIOGCMHP, [Out] RigidTransform JADIKJPFLKC);

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool DCBGOLFHNIM(CAKFEHOBCAO AJAFIOGCMHP, [Out] float GHINOBFIOBF);

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 FAMKHIGHLDC(EBLBJNHIABP DICNEHFKPLG);

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "21")]
	quaternion EAKKGLDGNHJ(EBLBJNHIABP DICNEHFKPLG);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class JMKPPDFJODA
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
public interface OMHOJHJBKGP
{
	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	object PGFBKELGIKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPFEEKPEIOK(KLCLLLJMBOO MOMJNKBEDGK);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface HMJPDGHCKHI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	LocalId HFFOJFAPLON
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	LocalId LPJFLGDHFCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AFACPACBAIE(float3 FJEACGMCDJE);

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EPIOGBHBLIJ(float3 FJEACGMCDJE);

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FPBAAJLOHCE([Out] float3 CJJOHOENBLA, [Out] float3 KAABKEFBBLK);

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AHKANNPAIDG(float3 CJJOHOENBLA, float3 KAABKEFBBLK);

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JLIDKOLIHPN(Color CJJOHOENBLA, Color KAABKEFBBLK);

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HMJPDGHCKHI Instantiate(Transform IJKPFNCIDCJ);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface AOJFMLLEOJE
{
	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OMELHDOHHCI(Transform IJKPFNCIDCJ, HMJPDGHCKHI FAIHDGNEAFI);

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HMJPDGHCKHI LBALBOHAPKB();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum NBPHAGCBFCO
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class NPDGHEGOLPD
{
	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0xA71250", Offset = "0xA70650", VA = "0x180A71250")]
	public static bool DKCCELGONJG(this NBPHAGCBFCO CGABFKIJBOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0xA71270", Offset = "0xA70670", VA = "0x180A71270")]
	public static bool ENNBJOPAPKB(this NBPHAGCBFCO CGABFKIJBOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x1F86B50", Offset = "0x1F85F50", VA = "0x181F86B50")]
	public static bool PNNLLDAIEEM(this NBPHAGCBFCO CGABFKIJBOC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface IBNLNIKJFKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000110")]
	NBPHAGCBFCO BMMKBBBMIIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	NBPHAGCBFCO JLKIGCNMAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	NBPHAGCBFCO BOJEMDGECMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	NBPHAGCBFCO PCONDBHNLLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	NBPHAGCBFCO NDGMEKCFKIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	NBPHAGCBFCO NHEPPELDCPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	NBPHAGCBFCO CEAOLLGHOLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	NBPHAGCBFCO BHBGFGFGFPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	NBPHAGCBFCO BBHMEIFDOJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public interface GMEBHOOMEDK
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<OGALCPHBFJB> HBOMIODELKD;

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CAKFEHOBCAO IKLADMFFKPA(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JCEFKGHBPFN(List<CAKFEHOBCAO> ALDIHCKBCEP);

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CAKFEHOBCAO NALNAGAMHFP(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LEKFLKBIABP(CAKFEHOBCAO AJAFIOGCMHP, CAKFEHOBCAO DCLCDDGJKIC, bool HLAFCEMDKOA);

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GNMLKPBGKPO(CAKFEHOBCAO AJAFIOGCMHP, CAKFEHOBCAO DCLCDDGJKIC);

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int NAODMJCGMDJ(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KLCLLLJMBOO DIAHBPCGMNJ(CAKFEHOBCAO PCOAABDKEED);

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GBDKGPAEEJJ(CAKFEHOBCAO AJAFIOGCMHP, CAKFEHOBCAO JBFHBGCJGMG);

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool OMHDFCIKAMC(CAKFEHOBCAO AJAFIOGCMHP, CAKFEHOBCAO JHJELAILOKH);

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	CAKFEHOBCAO LFJGHBELPCN(CAKFEHOBCAO ADOGMMPMLJB, CAKFEHOBCAO EOFPNCBMKHP);

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool HMBKMODMMCG(CAKFEHOBCAO ADOGMMPMLJB, CAKFEHOBCAO EOFPNCBMKHP, [Out] CAKFEHOBCAO AFMEONIJNGK);
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class FMKKPPKJAFF
{
	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB240", Offset = "0x5DAA640", VA = "0x185DAB240")]
	public static List<CAKFEHOBCAO> JCEFKGHBPFN(this GMEBHOOMEDK PIKEAKJOJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB140", Offset = "0x5DAA540", VA = "0x185DAB140")]
	public static bool IKEOHJNIHOH(this GMEBHOOMEDK PIKEAKJOJCD, CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
public interface KIOMKHMJPMB
{
	[Cpp2IlInjected.Token(Token = "0x17000119")]
	bool JEADELAIMGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	bool JCDBKPNJMOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public interface NGDPKGKNNBP : FOAPOKJFCAL
{
	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HMGDPCDJKDM DHMHMLBLFOJ(Entity AHNNJNFIHFM);

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PAIFIIADEJB(NativeArray<HMGDPCDJKDM> HHPNPODNLFG, NativeArray<JABAMAIPKGD> AKLEIOCDFMP);

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NGBINGGPKBF(HMGDPCDJKDM EKHBDCNGFLP);

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PDILAFMNMHO(HMGDPCDJKDM EKHBDCNGFLP, [Out] Collider MHOODELGFIC);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
public interface FOAPOKJFCAL
{
	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KIILMPOMDOF([In] float3 PKOLMJEBDFI, [In] float3 DDLNIHBIJPM, float FECAAKMJJAF, Allocator JIIMEDFKEME, [Out] NativeArray<Entity> JIBDNODJOAB);
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
public interface FHBDOMJNNEJ
{
	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KIILMPOMDOF([In] float3 PKOLMJEBDFI, [In] float3 DDLNIHBIJPM, float FECAAKMJJAF, [Out] MKOEHACBNCO HMKJLANMADO, [Out] CAKFEHOBCAO ALKPGICEAHM);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
public interface ABLMCLHDBNO
{
	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIILMPOMDOF([In] NativeArray<Entity> JIBDNODJOAB, [In] float3 PKOLMJEBDFI, [In] float3 DDLNIHBIJPM, [In] NativeArray<MKOEHACBNCO> HDMFOJGBNEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct HMGDPCDJKDM : CEILLBLPNIE, IEquatable<HMGDPCDJKDM>
{
	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public int ICOODGEKGMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x9786C0", Offset = "0x977AC0", VA = "0x1809786C0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x7D2F60", Offset = "0x7D2360", VA = "0x1807D2F60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public int CIBDPGBBMPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x5220E10", Offset = "0x5220210", VA = "0x185220E10", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE030", Offset = "0x5DAD430", VA = "0x185DAE030", Slot = "8")]
	public bool Equals(HMGDPCDJKDM KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE080", Offset = "0x5DAD480", VA = "0x185DAE080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct MKOEHACBNCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float EMIAGFPEPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 DDEDMKGDKMA;
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public interface COABIPGNKOL
{
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public interface CDJJECGMMII : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	CPBLFKHDDGN NKHNPFLPACC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	OBPNGNFDEPN NGPOIHIFCBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<KLCLLLJMBOO, NativeArray<HNGHCMBBKEB>> ABCOPLNBDEP;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<KLCLLLJMBOO> CHDCLLPLJKN;

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PLMJAAHFMOO CBFFKDJAICB(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HNGHCMBBKEB HHHMIGOGAJK(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GFCMFFOEFBO(IKAJAHLJFMC MIPKLHDFLBO, CGNNELOIABF LKCOHANNNDC);

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BAJJJAGOPJE ALDDGBMMJNL(CAKFEHOBCAO AJAFIOGCMHP, [Optional] object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KEDFCEGBEDG(CAKFEHOBCAO AJAFIOGCMHP, [Out] CGNNELOIABF LKCOHANNNDC);

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NHKFAJGADBA(CAKFEHOBCAO AJAFIOGCMHP, [Out] Transform IJKPFNCIDCJ);

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool BDLMEDCBLOE(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DAFHNGHAEML(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool NFIDNGBGDFA(LocalId AJAFIOGCMHP, object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool FDDJPIDFEJE(LocalId AJAFIOGCMHP, object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(Slot = "16")]
	CAKFEHOBCAO MBBJHIFDBPF(IKAJAHLJFMC MIPKLHDFLBO);

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool DMFHNPPLLIH(IKAJAHLJFMC MIPKLHDFLBO, [Out] CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(Slot = "18")]
	IKAJAHLJFMC CDLFJKIJIFJ(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(Slot = "19")]
	KLCLLLJMBOO MBBJHIFDBPF(NativeArray<IKAJAHLJFMC> MIPKLHDFLBO, Allocator JIIMEDFKEME);

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "20")]
	KLCLLLJMBOO FIOLIIPCNDJ(NativeArray<IKAJAHLJFMC> MIPKLHDFLBO, NativeArray<CHCOMAAHOED> CPBGBMAIAGD, Allocator JIIMEDFKEME);

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	BAJJJAGOPJE KEABAAMENCA(HNGHCMBBKEB HOAIKLJFCGK, bool BONNBAOJEFF);

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(Slot = "22")]
	BAJJJAGOPJE KEABAAMENCA(HNGHCMBBKEB HOAIKLJFCGK);

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(Slot = "23")]
	BAJJJAGOPJE KCANJMAFAGK(HNGHCMBBKEB HOAIKLJFCGK);

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(Slot = "24")]
	BAJJJAGOPJE AONPGCLANIO(HNGHCMBBKEB HOAIKLJFCGK);

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(Slot = "25")]
	BAJJJAGOPJE FIOLIIPCNDJ(IKAJAHLJFMC MIPKLHDFLBO, HNGHCMBBKEB HOAIKLJFCGK);

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(Slot = "26")]
	PNAAPOCOKHE GLLDEMPMFCB();

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(Slot = "27")]
	BHAKFOIGDML MDIMLHEMGML();

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(Slot = "28")]
	LNDHJLHCOEC BCBCDPHCOFG(JHDIEJNPMMJ AIANDPLENPF);

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void PICMAPEPIMK(KLCLLLJMBOO MOMJNKBEDGK);

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void OMMIKAHKMGL(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void PMDLPBBGJKF(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void PICMAPEPIMK(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(Slot = "33")]
	KLCLLLJMBOO GPLBOIIHMOK(KLCLLLJMBOO KPFNJKBFGEC, Allocator JIIMEDFKEME);

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool NDBJGAPFHCF(CAKFEHOBCAO AJAFIOGCMHP);
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class CCOIJCPDLBD
{
	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6F00", Offset = "0x5DA6300", VA = "0x185DA6F00")]
	public static void DAFHNGHAEML(this CDJJECGMMII JJMFHKECKEI, CGNNELOIABF LKCOHANNNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6DD0", Offset = "0x5DA61D0", VA = "0x185DA6DD0")]
	public static BAJJJAGOPJE BKLGKCDNGDA(this CDJJECGMMII JJMFHKECKEI, LocalId AJAFIOGCMHP)
	{
		return default(BAJJJAGOPJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5DA7730", Offset = "0x5DA6B30", VA = "0x185DA7730")]
	public static CAKFEHOBCAO MBBJHIFDBPF(this CDJJECGMMII JJMFHKECKEI, LocalId AJAFIOGCMHP)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6E10", Offset = "0x5DA6210", VA = "0x185DA6E10")]
	public static IKAJAHLJFMC CDLFJKIJIFJ(this CDJJECGMMII JJMFHKECKEI, LocalId AJAFIOGCMHP)
	{
		return default(IKAJAHLJFMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x5DA7760", Offset = "0x5DA6B60", VA = "0x185DA7760")]
	public static bool NDBJGAPFHCF(this CDJJECGMMII JJMFHKECKEI, IKAJAHLJFMC MIPKLHDFLBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x21FC5A0", Offset = "0x21FB9A0", VA = "0x1821FC5A0")]
	public static T DDAKKFPKNCG<T>(this CDJJECGMMII JJMFHKECKEI, LocalId AJAFIOGCMHP) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x5DA78E0", Offset = "0x5DA6CE0", VA = "0x185DA78E0")]
	public static PNAAPOCOKHE OAJFGBEELLL(this CDJJECGMMII JJMFHKECKEI, RigidTransform LOCOPBDKIJH, [Optional] object IBLOMPOENGH)
	{
		return default(PNAAPOCOKHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x5DA7410", Offset = "0x5DA6810", VA = "0x185DA7410")]
	public static LNDHJLHCOEC FKEOFIBBAKE(this CDJJECGMMII JJMFHKECKEI, JHDIEJNPMMJ FIPIOPDONEP, RigidTransform LOCOPBDKIJH, [Optional] object IBLOMPOENGH)
	{
		return default(LNDHJLHCOEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x5DA72D0", Offset = "0x5DA66D0", VA = "0x185DA72D0")]
	public static BHAKFOIGDML EGJGIKELKGD(this CDJJECGMMII JJMFHKECKEI, RigidTransform LOCOPBDKIJH, [Optional] object IBLOMPOENGH)
	{
		return default(BHAKFOIGDML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x5DA7010", Offset = "0x5DA6410", VA = "0x185DA7010")]
	private static void DIBHECFENJE(BAJJJAGOPJE HOGODMNEKGA, RigidTransform LOCOPBDKIJH, [Optional] object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x5DA7560", Offset = "0x5DA6960", VA = "0x185DA7560")]
	internal static NCNMAFGBAIJ KPHFFCJBFFC(this CDJJECGMMII JJMFHKECKEI, OOOKHLEFLPC MLKBHDGIANN, [Optional] object IBLOMPOENGH)
	{
		return default(NCNMAFGBAIJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
public interface NCBLCPIDIEA
{
	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	bool LDAOAEAIIDC
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	CAKFEHOBCAO DNFLNGMMCIP
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	BAJJJAGOPJE NGAMFNGJMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event KEBLKNNECFM GAPJGIMLFIN;

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CAKFEHOBCAO LFJGHBELPCN(CAKFEHOBCAO ADOGMMPMLJB, CAKFEHOBCAO EOFPNCBMKHP);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HMBKMODMMCG(CAKFEHOBCAO ADOGMMPMLJB, CAKFEHOBCAO EOFPNCBMKHP, [Out] CAKFEHOBCAO AFMEONIJNGK);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CJLPJDLHJCM();

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PINBDFJFFJJ();

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LOHAEJHJHFA(CAKFEHOBCAO ADOGMMPMLJB);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public delegate void KEBLKNNECFM(BAJJJAGOPJE MFDGPNALPKO, BAJJJAGOPJE FCFBKMEPDEK);
[Cpp2IlInjected.Token(Token = "0x200006D")]
public static class CIKICPJFOBB
{
	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x5DA7C60", Offset = "0x5DA7060", VA = "0x185DA7C60")]
	public static bool ILLJKKKCIHP(this NCBLCPIDIEA JBLBJMHLOFE, CAKFEHOBCAO ADOGMMPMLJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x5DA7B60", Offset = "0x5DA6F60", VA = "0x185DA7B60")]
	public static bool COEGIOPFMHL(this NCBLCPIDIEA JBLBJMHLOFE, CAKFEHOBCAO ADOGMMPMLJB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public interface LAKGPMMKLEK
{
	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OMMBBCDEIAG(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OCGICDDBFKB(CAKFEHOBCAO AJAFIOGCMHP, Transform IJKPFNCIDCJ);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
public interface EJLACCPBJAD
{
	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJCNHNDJGBM(CAKFEHOBCAO PCOAABDKEED, bool LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BBHDHNHEGGC(CAKFEHOBCAO PCOAABDKEED, bool LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JJHEBLMMMIK(CAKFEHOBCAO PCOAABDKEED, int LPCGJALKADL);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
public interface EEJAONCFMLK
{
	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<CAKFEHOBCAO> ADPGBGFKCGP(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CAKFEHOBCAO CAPDGJPGLFG(CAKFEHOBCAO AJAFIOGCMHP, int JPEMHHILGGG);

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int CBDDKDJFEPL(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LOAAMPEDBNJ CLCCBNABFEK(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MEMANMIEHGD(CAKFEHOBCAO AJAFIOGCMHP, LOAAMPEDBNJ OJJNHGGGKOD);

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CAKFEHOBCAO CEPJOKGIHKA(CAKFEHOBCAO AJAFIOGCMHP, [Optional] float3? BAONBICGOEJ, [Optional] quaternion? CKFJFCLIANA, [Optional] float3? IJMHENINMDB);

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CAKFEHOBCAO OAILJPFJCKI(CAKFEHOBCAO AJAFIOGCMHP, int JPEMHHILGGG, [Optional] float3? BAONBICGOEJ, [Optional] quaternion? CKFJFCLIANA, [Optional] float3? IJMHENINMDB);

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GCPHEPDOAJG(CAKFEHOBCAO AJAFIOGCMHP, int JPEMHHILGGG);

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DJHKJFCACCA(CAKFEHOBCAO AJAFIOGCMHP);
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public interface KBADIJFHJMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKNAKEALBNN();

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOLHLDCHAHK();

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KCKEIALFJEG();

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BJBJNHGALAE();

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BDNJCEPJADM();

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BACIAADNNED();

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FHGBMPAHFEI();

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LCCHJDLAEEJ();

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KHFJBIHOHDN();

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LFKINDAJIIP();

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NKMOAHAEANH();
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public interface EPEIHHNCIHD
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NABGKJCIJEJ(Entity AHNNJNFIHFM);

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KDBAMBKBMAK(Entity AHNNJNFIHFM, [In] float3 LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 FOIMDLGHOPD(Entity AHNNJNFIHFM);

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JFOFKKNAHGL(Entity AHNNJNFIHFM, [In] quaternion LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion ONPCLDDJECM(Entity AHNNJNFIHFM);

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MGMFCEHDLMO(Entity AHNNJNFIHFM, [Out] float3 BAONBICGOEJ, [Out] quaternion CKFJFCLIANA);

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MGMFCEHDLMO(Entity AHNNJNFIHFM, [Out] RigidTransform BLHLKIADHCI);

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ECIDLHAOAHH(Entity AHNNJNFIHFM, [Out] RigidTransform BLHLKIADHCI);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 IJCHDLNCBKK(Entity AHNNJNFIHFM);

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CNOCJDKBOFP(Entity AHNNJNFIHFM, [In] float3 LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BMNKFONIFDG(Entity AHNNJNFIHFM, float LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float LODIFPINEAL(Entity AHNNJNFIHFM);

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BELDBNJGCLB(Entity AHNNJNFIHFM, [In] float3 LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 PAICGNMPDGP(Entity AHNNJNFIHFM);

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PBHFKJEOLIA(Entity AHNNJNFIHFM, [In] float3 LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 KEGJIIGHKDE(Entity AHNNJNFIHFM);

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EBGIHCANICC(Entity AHNNJNFIHFM, [In] quaternion LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion LIEOCLOELCH(Entity AHNNJNFIHFM);

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 PDKBCNAGNHG(Entity AHNNJNFIHFM);

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void BFPKHMPHDPM(Entity AHNNJNFIHFM, [In] float3 LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MIBBBHNADII(Entity AHNNJNFIHFM, float LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float PBIEAAPIOKH(Entity AHNNJNFIHFM);

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void MJIGIMEJFKC(Entity AHNNJNFIHFM, [In] float3 LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 OMNKCNNIGGI(Entity AHNNJNFIHFM);

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void EIGDCDLBOPD(Entity AHNNJNFIHFM, [Out] float4x4 BFDECFAPKAM);

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void NCNCKLBNGKJ(Entity AHNNJNFIHFM, [In] float4x4 BFDECFAPKAM);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void PIGNKMLMHMH(Entity AHNNJNFIHFM, [Out] float4x4 BFDECFAPKAM);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool NHKFAJGADBA(Entity AHNNJNFIHFM, [Out] Transform IJKPFNCIDCJ);

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void CEMCJLIKJOA(Entity AHNNJNFIHFM);

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void PLNILILGDLI(Entity AHNNJNFIHFM, Entity CLBKMLECIHH, Entity KJOCICNOINI);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class JDNEAECBOMJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public interface JEKOGBJNELB
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World AICLFEIEJFD();

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World IHKNANCMGFD();

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World AIHGPEGGMAI();

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World PEOJJJINLLC();
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public interface HONAKLLNIOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000122")]
	World KMONKLDHPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	World CACIINNIHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	EntityManager PHDBLFJLAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	bool DMGAPDBKGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase CFDAHOBDPKD(Type DJMKKNDNCBM);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class EOKJLEBCHME
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9F80", Offset = "0x5DA9380", VA = "0x185DA9F80")]
	public static ComponentSystemBase JKMAPGECNCA(this World KMPNHHILNIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x225B430", Offset = "0x225A830", VA = "0x18225B430")]
	public static T CFDAHOBDPKD<T>(this HONAKLLNIOE BDMHHEHOOAE) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
public interface DPIEMLJJLCJ
{
	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKCCMDIBFII(NativeListAsync<Entity> JHMGNBLFIOD);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGMFLODOOOF(GPEGLENBLNP COLMKMGNEDJ);

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DKCAMGDLMPC(NativeListAsync<Entity> MMCCPEIHMDG, bool KLIGAFICGJD);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ANPJEGGEMGB();
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
public interface AEMEMLHFPNC
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HAOMAKBHCDC(CAKFEHOBCAO AJAFIOGCMHP, [Out] Collider MHOODELGFIC);

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject BLDIONAMLBD(CAKFEHOBCAO FLFGBOOJAIK, GameObject BDNIDEKLIGD, Vector3 EDOEDBAJLGN, Quaternion ALNLHNLOHOA);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DAKCHAFEEID(GameObject MHOODELGFIC);

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider EHEDNJODCKJ<TCollider>(GameObject OAMKKHHFDEP) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DJENMLKKBFO(Collider MHOODELGFIC);

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject ADFIBOODNIO<TCollider>(string DKFEAPHKBMP) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
public interface BOJOADFJNML
{
	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FNPIAIJFJOC(CAKFEHOBCAO AJAFIOGCMHP, GIPDCNOKOFM NOIHOGLAIJL, bool KFEKGACJEDO, KLIANFEEIOH AAMJNKKPGGI);

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBJMILIFCHE(CAKFEHOBCAO AJAFIOGCMHP, GIPDCNOKOFM NOIHOGLAIJL, bool KFEKGACJEDO, bool PAEBLLNNODM, bool GKAALNMMCGD);

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KECPHEPKDGP CMMNBGBEDAI(CAKFEHOBCAO JMNDOLBKAMN, List<CAKFEHOBCAO> EDOHJFBONNA);

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FNEFLNLAFHN(GameObject BKAGAKKCOJP, GameObject MDAFHHOFGFB);

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AFLHEBIEGCM(GameObject MDAFHHOFGFB);

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T EHEDNJODCKJ<T>(GameObject OAMKKHHFDEP) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DJENMLKKBFO(Collider MHOODELGFIC);

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject DGDMIMNPMIK<T>(string DKFEAPHKBMP) where T : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
public interface CAMBFJGGDMI
{
	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IOIPLAFKPLK(CAKFEHOBCAO AJAFIOGCMHP, EOMJBFBJHKL LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EOMJBFBJHKL BKOIEMKCJEN(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFBCIDBKJPK(CAKFEHOBCAO AJAFIOGCMHP, CAKFEHOBCAO LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BOJDPHNKIJA(CAKFEHOBCAO AJAFIOGCMHP, CAKFEHOBCAO LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NAODMJCGMDJ(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CAKFEHOBCAO AAJAIICOEAP(CAKFEHOBCAO AJAFIOGCMHP, int JPEMHHILGGG);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LIFAMBKLFMA(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ANFJAKJKEIE(CAKFEHOBCAO AJAFIOGCMHP, object IBLOMPOENGH, CAKFEHOBCAO LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NHLBJCNGJDN(CAKFEHOBCAO AJAFIOGCMHP, object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool DPJPFDIOIAH(CAKFEHOBCAO AJAFIOGCMHP, [Out] CAKFEHOBCAO LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ADLOAHLPKMN(CAKFEHOBCAO AJAFIOGCMHP, float3 LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NPIFMHKCNNM(CAKFEHOBCAO AJAFIOGCMHP, [Out] float3 LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IHAOOMMBMEF(CAKFEHOBCAO AJAFIOGCMHP, float3 LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool ANHCBEMDGIJ(CAKFEHOBCAO AJAFIOGCMHP, [Out] float3 LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BIHLKFFOIGB(CAKFEHOBCAO AJAFIOGCMHP, (Quaternion rot, Vector3 moments) ALHLPOFJJID);

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool GJNOIFGPOLE(CAKFEHOBCAO AJAFIOGCMHP, [Out] quaternion BFDFAOOEJAP, [Out] float3 LFPMLPFJALN);

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AEJCOCDNJBE(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ACNLHCHJOAP(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 PNINNBIKIFA(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 KAJNKJKKCHL(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OHJHFPDAKLO(CAKFEHOBCAO AJAFIOGCMHP, float3 LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void KFHEDNJHJPA(CAKFEHOBCAO AJAFIOGCMHP, float3 LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float FMICGLMFLGO(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float AKPNDJCNKPP(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void KFIOKECDAJF(CAKFEHOBCAO AJAFIOGCMHP, float LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void CJJEBOGMCHN(CAKFEHOBCAO AJAFIOGCMHP, float LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CollisionDetectionMode EJCELKLFNLG(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void BBABGNHNKPH(CAKFEHOBCAO AJAFIOGCMHP, CollisionDetectionMode LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	LHMMHIJEJEH FMEHBDDLJIJ(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FAOBFHNDNPE(CAKFEHOBCAO AJAFIOGCMHP, LHMMHIJEJEH LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool NGCBGDFHEAM(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void BGENHPEAHBJ(CAKFEHOBCAO AJAFIOGCMHP, bool LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(Slot = "32")]
	CAKFEHOBCAO IKLADMFFKPA(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void ADIKJJDDBPK(CAKFEHOBCAO AJAFIOGCMHP, CAKFEHOBCAO LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(Slot = "34")]
	CAKFEHOBCAO NALNAGAMHFP(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void LEKFLKBIABP(CAKFEHOBCAO AJAFIOGCMHP, CAKFEHOBCAO LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(Slot = "36")]
	JJDKBJICEBO DKIDFIKELLO(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void EEJJPCHAFLB(CAKFEHOBCAO AJAFIOGCMHP, JJDKBJICEBO JCCGOBCMAPF);

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool GALBCOBALMG(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void CGBMEKACBDL(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool DDJOOPMGHHI(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void GCFBKFKKIAH(CAKFEHOBCAO AJAFIOGCMHP, bool LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool KCCNBGCKIIK(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void NNCANHGOODB(CAKFEHOBCAO AJAFIOGCMHP, bool LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(Slot = "44")]
	RigidbodyConstraints LPOOBAGHPJJ(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void LKHDNHAKICI(CAKFEHOBCAO AJAFIOGCMHP, RigidbodyConstraints LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(Slot = "46")]
	float CEMOKJDICPD(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void IIPCFAGHDIK(CAKFEHOBCAO AJAFIOGCMHP, float LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float CJLFNOGKMCJ(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void NEDDOHIEABH(CAKFEHOBCAO AJAFIOGCMHP, float LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool AIKCLBABIJN(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void ODCAGPJOLJO(CAKFEHOBCAO AJAFIOGCMHP, bool LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool MJDMHFFMNGE(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void CEEEPMPEMNG(CAKFEHOBCAO AJAFIOGCMHP, bool LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void JBANJHPFMMD(CAKFEHOBCAO AJAFIOGCMHP, int LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(Slot = "55")]
	object GHHAKMPLIIK(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void OLGDEODKAID(CAKFEHOBCAO AJAFIOGCMHP, object LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(Slot = "57")]
	object DJGBFCGNNIO(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void NDDOPHBLGIO(CAKFEHOBCAO AJAFIOGCMHP, object LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "59")]
	float JIOJFMGLNLO(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void GBALDBDDJEH(CAKFEHOBCAO AJAFIOGCMHP, float LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void HDELMPEGJEH(CAKFEHOBCAO AJAFIOGCMHP, object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void BOCBLGJAFLA(CAKFEHOBCAO AJAFIOGCMHP, object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(Slot = "63")]
	bool BNJDIPFJNGE(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void AKPIBHNFMDJ(CAKFEHOBCAO AJAFIOGCMHP, object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void HHNOMBFDOFK(CAKFEHOBCAO AJAFIOGCMHP, object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(Slot = "66")]
	bool MKNOMFEFACD(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool IPNHICNDDAH(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Rigidbody FJLPGGBIFGL(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void AHGCNHEHEJD(CAKFEHOBCAO AJAFIOGCMHP, Rigidbody DKNAEDLPCJA);

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void ONCMECCPFEJ(CAKFEHOBCAO AJAFIOGCMHP, object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void GGEHJOCGMEA(CAKFEHOBCAO AJAFIOGCMHP, object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool EEOAJIPHNKN(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void FNHGJJMPBAP(CAKFEHOBCAO AJAFIOGCMHP, float3 FJGOAHOCDJJ);

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void KIOILKINCGH(CAKFEHOBCAO AJAFIOGCMHP, float3 DPKJDPPAHNL);

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(Slot = "75")]
	bool EBLJFOACMNM(CAKFEHOBCAO AJAFIOGCMHP, [Out] float3 FJGOAHOCDJJ);

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool NCODECCIGIO(CAKFEHOBCAO AJAFIOGCMHP, [Out] float3 DPKJDPPAHNL);

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool FGMBIHKBJEA(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void KMJCGIHOIBO(CAKFEHOBCAO AJAFIOGCMHP, object IBLOMPOENGH, bool CHLKIHBDBEI);

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(Slot = "79")]
	void DGOHJENHDKA(CAKFEHOBCAO AJAFIOGCMHP, bool NDDCPACLCHM);

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void GMDPJHBLEIG(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool OBGOCKBMCFN(CAKFEHOBCAO AJAFIOGCMHP);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
public interface FEGCGGPGJLI
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	bool DMGAPDBKGAP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KIPNPCMDEBA(CAKFEHOBCAO AJAFIOGCMHP);

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CCLCIBPDLJB(CAKFEHOBCAO AJAFIOGCMHP, bool KFEKGACJEDO, bool PAEBLLNNODM, bool MCHEPAJCBOE);
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
public interface JCGFEEDFAOG
{
	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HCECHKJKDBB(Entity NCFEPMCAPNO);

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KBFIEMKIOCD(Entity NCFEPMCAPNO);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public delegate void GGCLCHAMHEE(DMMDOJFOBIA IEMDMBKFBFO);
[Cpp2IlInjected.Token(Token = "0x200007E")]
public readonly struct DMMDOJFOBIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly KLCLLLJMBOO GIIACOBGMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly NativeArray<byte> HDAGINFADOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly NativeArray<byte> LFEAEFFENHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly NHGDGBFBAIF LNAKMGONIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly int KNIOECFCABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly Type MBFOEAHNKBO;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public KLCLLLJMBOO DIFMKMJDJCB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x38AC2C0", Offset = "0x38AB6C0", VA = "0x1838AC2C0")]
		get
		{
			return default(KLCLLLJMBOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8B70", Offset = "0x5DA7F70", VA = "0x185DA8B70")]
	public DMMDOJFOBIA(KLCLLLJMBOO GIIACOBGMNH, NativeArray<byte> HDAGINFADOG, NativeArray<byte> LFEAEFFENHM, NHGDGBFBAIF LNAKMGONIOO, int KNIOECFCABA, Type MBFOEAHNKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x222AB30", Offset = "0x2229F30", VA = "0x18222AB30")]
	public NativeArray<T> CFOMEOJJOBL<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x222AB70", Offset = "0x2229F70", VA = "0x18222AB70")]
	public NativeArray<T> KEABDMCGODF<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x222ABB0", Offset = "0x2229FB0", VA = "0x18222ABB0")]
	public (KLCLLLJMBOO, NativeArray<T>, NativeArray<T>) KJBHHOOLCCM<T>() where T : struct
	{
		return default((KLCLLLJMBOO, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8B20", Offset = "0x5DA7F20", VA = "0x185DA8B20")]
	public OGALCPHBFJB MDDHJEDMJFH()
	{
		return default(OGALCPHBFJB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface IBNGANGAIIG
{
	[Cpp2IlInjected.Token(Token = "0x17000128")]
	string HCFDKLNAKMG
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	IBNGANGAIIG NEGNKOPKGGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	IEnumerable<IBNGANGAIIG> DFNLKFGGGAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
public interface JIJFKEDMCGO
{
	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	IBNGANGAIIG CAHOKKAJPFH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	List<LJEACGFBGAF> OJCNEHAEBHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PANMBMJOILD(LJEACGFBGAF OIBKEMMFJDM, [Out] IBNGANGAIIG DMBGGOLNLAM);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GFCMFFOEFBO(LJEACGFBGAF OIBKEMMFJDM, GGCLCHAMHEE LNKIKCGJLFE);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OOFKJBAJEMO(LJEACGFBGAF OIBKEMMFJDM, GGCLCHAMHEE LNKIKCGJLFE);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct OGALCPHBFJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly DMMDOJFOBIA OOIBMCBCEPD;

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public KLCLLLJMBOO DIFMKMJDJCB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x38AC2C0", Offset = "0x38AB6C0", VA = "0x1838AC2C0")]
		get
		{
			return default(KLCLLLJMBOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1680", Offset = "0x5DB0A80", VA = "0x185DB1680")]
	public OGALCPHBFJB(DMMDOJFOBIA OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DB13C0", Offset = "0x5DB07C0", VA = "0x185DB13C0")]
	public KLCLLLJMBOO CFOMEOJJOBL()
	{
		return default(KLCLLLJMBOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1490", Offset = "0x5DB0890", VA = "0x185DB1490")]
	public KLCLLLJMBOO KEABDMCGODF()
	{
		return default(KLCLLLJMBOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1560", Offset = "0x5DB0960", VA = "0x185DB1560")]
	public (KLCLLLJMBOO, KLCLLLJMBOO, KLCLLLJMBOO) KJBHHOOLCCM()
	{
		return default((KLCLLLJMBOO, KLCLLLJMBOO, KLCLLLJMBOO));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
[DefaultMember("Item")]
public interface KHBOFPBPOBG : IEnumerable<BLKKNKJIPKI>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	NativeBitArray GMPIOECNCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	NativeArray<int> GKAAKCHBNEB
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	BLKKNKJIPKI ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	BLKKNKJIPKI ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BLKKNKJIPKI OHHBJJNGNKB(AMAMFBGBCKA OKJGMJDJMMC);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NHGDGBFBAIF DCIEGAAPHFM(AMAMFBGBCKA OKJGMJDJMMC);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class INBNMIFPFFF
{
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
[DefaultMember("Item")]
public interface EGMLFPKLELH : IEnumerable<DNHFDIEHCPF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000133")]
	int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	DNHFDIEHCPF ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DNHFDIEHCPF OHHBJJNGNKB(AMAMFBGBCKA OKJGMJDJMMC);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NHGDGBFBAIF DCIEGAAPHFM(AMAMFBGBCKA OKJGMJDJMMC);
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class ANKBIOHAKJH
{
	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x29F4EC0", Offset = "0x29F42C0", VA = "0x1829F4EC0")]
	public static NHGDGBFBAIF DCIEGAAPHFM<T>(this EGMLFPKLELH MJHCCCCPHBO, EMNGLKONKEK<T> DKFEAPHKBMP) where T : struct
	{
		return default(NHGDGBFBAIF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
[DefaultMember("Item")]
public interface DFLIKLKNDFH : IEnumerable<LJEACGFBGAF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000135")]
	int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	LJEACGFBGAF ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LJEACGFBGAF OHHBJJNGNKB(AMAMFBGBCKA OKJGMJDJMMC);

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NHGDGBFBAIF DCIEGAAPHFM(AMAMFBGBCKA OKJGMJDJMMC);
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class FKNHJCGLENG
{
	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x23B9650", Offset = "0x23B8A50", VA = "0x1823B9650")]
	public static FACGOEDLDML<T> OHHBJJNGNKB<T>(this DFLIKLKNDFH MJHCCCCPHBO, AMAMFBGBCKA DKFEAPHKBMP) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x23B9790", Offset = "0x23B8B90", VA = "0x1823B9790")]
	public static FACGOEDLDML<T> OHHBJJNGNKB<T>(this DFLIKLKNDFH MJHCCCCPHBO, EMNGLKONKEK<T> DKFEAPHKBMP) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x23B9550", Offset = "0x23B8950", VA = "0x1823B9550")]
	public static NHGDGBFBAIF DCIEGAAPHFM<T>(this DFLIKLKNDFH MJHCCCCPHBO, EMNGLKONKEK<T> DKFEAPHKBMP) where T : struct
	{
		return default(NHGDGBFBAIF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
public interface HGBLHAOBLKK
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFCMFFOEFBO(AMAMFBGBCKA OIBKEMMFJDM, GGCLCHAMHEE LNKIKCGJLFE);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OOFKJBAJEMO(AMAMFBGBCKA OIBKEMMFJDM, GGCLCHAMHEE LNKIKCGJLFE);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public interface DJOMFACBNME
{
	[Cpp2IlInjected.Token(Token = "0x17000137")]
	FLHKGHBAAMG IFFBKABLDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EBCGHJDNCEE(IKAJAHLJFMC MIPKLHDFLBO, NHGDGBFBAIF OIBKEMMFJDM);

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCFDCBAHABD(IKAJAHLJFMC MIPKLHDFLBO, Span<NHGDGBFBAIF> MJHCCCCPHBO, bool IJMJAJBCLEH);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DJECLGDMNGP(NativeArray<IKAJAHLJFMC> LLBGDKONGBO);
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class FFOANEKKLPE
{
	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAD80", Offset = "0x5DAA180", VA = "0x185DAAD80")]
	public static void JCFDCBAHABD(this DJOMFACBNME IEDKLDPPILG, IKAJAHLJFMC MIPKLHDFLBO, NHGDGBFBAIF OIBKEMMFJDM, bool IJMJAJBCLEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public readonly struct FLHKGHBAAMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly NativeBitArray GJFOJEDJCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly NativeParallelHashMap<IKAJAHLJFMC, int> DLPKMMJLNKA;

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool ENLBFFMNMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x5DAB010", Offset = "0x5DAA410", VA = "0x185DAB010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0xA40010", Offset = "0xA3F410", VA = "0x180A40010")]
	public FLHKGHBAAMG(NativeBitArray GJFOJEDJCDO, NativeParallelHashMap<IKAJAHLJFMC, int> DLPKMMJLNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAEE0", Offset = "0x5DAA2E0", VA = "0x185DAAEE0")]
	public bool EBCGHJDNCEE(IKAJAHLJFMC MIPKLHDFLBO, NHGDGBFBAIF OIBKEMMFJDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
public interface NPNIMFLBBPG
{
	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IKHBJDJJOLO(CAKFEHOBCAO AJAFIOGCMHP, PAAILIGMCIN LPCGJALKADL);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public interface CHBEHJHHAIC
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	HKEOIHFAMCC HKEECIFBCAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public interface MOHMCBFIKAN
{
	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	Type MMABIHFJPJE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
public interface JFDAFKCNFNC
{
	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OLNICKOCIEG(CAKFEHOBCAO PCOAABDKEED, bool LPCGJALKADL);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public readonly struct EEKDDPBIMAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly IEnumerable<OPBDJAPIKJM> AHCDBFBGANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly IReadOnlyList<GameObject> GLOKOAEHOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly IReadOnlyList<int> EGMGKCBFJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly IReadOnlyList<(IKAJAHLJFMC, IKAJAHLJFMC)> MOMMELGGCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly int NLMFLECOPGP;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool ADBIFDDOPEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x5DA9140", Offset = "0x5DA8540", VA = "0x185DA9140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public int BCMDHEJMMGF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x7EF630", Offset = "0x7EEA30", VA = "0x1807EF630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public IEnumerable<GameObject> JBLOHFAPJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x978670", Offset = "0x977A70", VA = "0x180978670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public IEnumerable<(IKAJAHLJFMC src, IKAJAHLJFMC dst)> KJAEEGDLDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9530", Offset = "0x5DA8930", VA = "0x185DA9530")]
	public EEKDDPBIMAP(IEnumerable<OPBDJAPIKJM> AHCDBFBGANG, IReadOnlyList<GameObject> GLOKOAEHOBO, IReadOnlyList<int> EGMGKCBFJEH, IReadOnlyList<(IKAJAHLJFMC src, IKAJAHLJFMC dst)> MOMMELGGCBK, int NLMFLECOPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5DA91A0", Offset = "0x5DA85A0", VA = "0x185DA91A0")]
	public (GameObject, int)[] OKEMCHPIIKA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface JFKABFIKFCO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	bool JNPNFAEJDJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	bool APJLDIFMKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	KLDHNDGGMFO ANPCHGNBOLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EINHHNIDDEG NHMEKPHCMOI();

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EINHHNIDDEG GDHPIIHLFOC(IEnumerable<CAKFEHOBCAO> MOMJNKBEDGK, [In] CJOBJHHCGGP MGMGONHABNF);

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GOPDDEOGDJM FIKEIGEMCPF(ByteString PGKNPBPFALN);

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CCDCMKEIGFA EKKNNINADNC(ByteString KHPJJNGKJGC, CAKFEHOBCAO DCLCDDGJKIC, [In] CJOBJHHCGGP EDKPGHPBAJK, IIOGBKCCMMK BEDKGOACLBP, bool LGDOBIONJGG = true);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KINAHPFLLOK();

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EEKDDPBIMAP JJJKAMEDMMF(IEnumerable<OPBDJAPIKJM> AHCDBFBGANG);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class HDPHIHCNIKE
{
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface MAICAFPPDGB
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action ICKNFFFCLJG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action PIGBEIEEOAI;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action GBGGLNAFMAI;
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct CHCOMAAHOED : GJJMNANPJKP, IEquatable<CHCOMAAHOED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public HNGHCMBBKEB HOAIKLJFCGK;

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x5DA7AA0", Offset = "0x5DA6EA0", VA = "0x185DA7AA0", Slot = "5")]
	public void HNNKJEMPCFP(FGNCKLJOJDM FCCGPHFBEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x5DA7AD0", Offset = "0x5DA6ED0", VA = "0x185DA7AD0", Slot = "4")]
	public void MFIMBGNEKOH(BMMCFOKNLEA OKFNJFEOHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x5DA7B00", Offset = "0x5DA6F00", VA = "0x185DA7B00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x15EFF70", Offset = "0x15EF370", VA = "0x1815EFF70", Slot = "6")]
	public bool Equals(CHCOMAAHOED KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x5DA7A20", Offset = "0x5DA6E20", VA = "0x185DA7A20", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x9786C0", Offset = "0x977AC0", VA = "0x1809786C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct IKAJAHLJFMC : IComparable<IKAJAHLJFMC>, IEquatable<IKAJAHLJFMC>, GJJMNANPJKP
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public const uint MLKHHDCMCFP = 0u;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public const uint HDPJIBGFJJC = 255u;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static readonly IKAJAHLJFMC AJNJPGPIKEO;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private const int JKEINJPPAIJ = 24;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private const uint NCGLCOGNPIH = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private const int AEODDBEDMEA = 8;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private const uint OJACPPOEHOE = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly uint FBMKKLOJFGJ;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public uint IPJKKJKOALH
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x7B8DF0", Offset = "0x7B81F0", VA = "0x1807B8DF0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public uint OFPAGNFLHNE
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x5DAE6A0", Offset = "0x5DADAA0", VA = "0x185DAE6A0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public uint LHBLMPOAICH
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x9786C0", Offset = "0x977AC0", VA = "0x1809786C0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool ADBIFDDOPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x5D11810", Offset = "0x5D10C10", VA = "0x185D11810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0xBD40E0", Offset = "0xBD34E0", VA = "0x180BD40E0")]
	public static IKAJAHLJFMC EPIEGJLKAFK(uint FBMKKLOJFGJ)
	{
		return default(IKAJAHLJFMC);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE890", Offset = "0x5DADC90", VA = "0x185DAE890")]
	public IKAJAHLJFMC(int JKFKBDCHGAH, int NKKMMABDLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE890", Offset = "0x5DADC90", VA = "0x185DAE890")]
	public IKAJAHLJFMC(uint JKFKBDCHGAH, int NKKMMABDLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE890", Offset = "0x5DADC90", VA = "0x185DAE890")]
	public IKAJAHLJFMC(uint JKFKBDCHGAH, uint NKKMMABDLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x7D2F60", Offset = "0x7D2360", VA = "0x1807D2F60")]
	private IKAJAHLJFMC(uint FBMKKLOJFGJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x15EFF90", Offset = "0x15EF390", VA = "0x1815EFF90")]
	public static bool HCMKGGFOPFL(IKAJAHLJFMC BOGGCLFEFDJ, IKAJAHLJFMC OGHJEHJOFGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x15EFF70", Offset = "0x15EF370", VA = "0x1815EFF70", Slot = "5")]
	public bool Equals(IKAJAHLJFMC KOJKDECJOKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE6C0", Offset = "0x5DADAC0", VA = "0x185DAE6C0", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x1F86A60", Offset = "0x1F85E60", VA = "0x181F86A60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE800", Offset = "0x5DADC00", VA = "0x185DAE800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE7A0", Offset = "0x5DADBA0", VA = "0x185DAE7A0", Slot = "6")]
	public void MFIMBGNEKOH(BMMCFOKNLEA OKFNJFEOHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE740", Offset = "0x5DADB40", VA = "0x185DAE740", Slot = "7")]
	public void HNNKJEMPCFP(FGNCKLJOJDM FCCGPHFBEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE6B0", Offset = "0x5DADAB0", VA = "0x185DAE6B0", Slot = "4")]
	public int CompareTo(IKAJAHLJFMC KEEHOGPOIFD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct OPBDJAPIKJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Guid HILDEDLDEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public string CMKNABKHAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Vector3 BAONBICGOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Quaternion CKFJFCLIANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Vector3 IJMHENINMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public int CLOBMLNKHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Dictionary<string, object> OJJNHGGGKOD;

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1CF0", Offset = "0x5DB10F0", VA = "0x185DB1CF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1B60", Offset = "0x5DB0F60", VA = "0x185DB1B60")]
	private static string JKAMACHBLPK(Dictionary<string, object> EGLHFCPNJBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public enum EKHFHKEJHJI
{
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	World,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class HDEGOOBLKHF
{
	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x5336A30", Offset = "0x5335E30", VA = "0x185336A30")]
	public static bool MIAAGFDKGDE(this EKHFHKEJHJI DJMKKNDNCBM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[Flags]
public enum IFNNGLCOHHI
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	WorldPhasesMaster = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	AdditivePhases = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public interface CCDCMKEIGFA : KLDHNDGGMFO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000146")]
	IIOGBKCCMMK KIHKEBEEIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LAGINJJKIEC();

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FGLPKGAHHBL();
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public interface KLDHNDGGMFO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000147")]
	IEnumerable<OPBDJAPIKJM> FGJNENOGIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	EEKDDPBIMAP AOECMCHHIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	LocalId JDBDAAELPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	PAEPNGDGNBO PKDHCIJNEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	Task EBDDGDCHACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HPOJNLGPELL(IFNNGLCOHHI KBOPLLOOOBM);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public interface IIOGBKCCMMK
{
	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JGOKBKBFJPD(Guid KECAMMIJJDM, [Out] Guid PFDAOEPJLFE);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public interface GOPDDEOGDJM : KLDHNDGGMFO, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[Flags]
public enum LHGMPMDECJG
{
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface EINHHNIDDEG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	PAEPNGDGNBO NFGALDMCCAK
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString IEBDGLIPLJK();
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public enum DHIOCBGLFGF
{
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public delegate bool EFJKFDNPHHB(LIKHNKHJBKG NACJMGHLEIJ, [In] JGFJHAANPIB LPCGJALKADL);
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public delegate bool OBPNFDDKGMJ<T>(LIKHNKHJBKG NACJMGHLEIJ, [In] T LPCGJALKADL);
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public interface HNKKIALLFBA
{
	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFCMFFOEFBO(NHGDGBFBAIF LNAKMGONIOO, Type GHFMALLEBKD, EFJKFDNPHHB HENPJKGACEF);

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CKBEIJEBHOM(NHGDGBFBAIF LNAKMGONIOO, [Out] EFJKFDNPHHB HENPJKGACEF);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class FLKMKBLPJGK
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class OHGHCEGPNHH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public OBPNFDDKGMJ<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public OHGHCEGPNHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5940", Offset = "0x3CD4D40", VA = "0x183CD5940")]
		internal bool EEIFPBEMCPF(LIKHNKHJBKG pendingList, [In] JGFJHAANPIB value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x23B9F90", Offset = "0x23B9390", VA = "0x1823B9F90")]
	public static void GFCMFFOEFBO<T>(this HNKKIALLFBA CDNLGICPHJL, NHGDGBFBAIF LNAKMGONIOO, OBPNFDDKGMJ<T> HENPJKGACEF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB030", Offset = "0x5DAA430", VA = "0x185DAB030")]
	public static bool CBIENJFFACD(this HNKKIALLFBA CDNLGICPHJL, LIKHNKHJBKG NACJMGHLEIJ, NHGDGBFBAIF LNAKMGONIOO, [In] JGFJHAANPIB LPCGJALKADL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public interface KNKIEHNOADO
{
	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	uint KLFIKFANBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public interface LIKHNKHJBKG
{
	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BIDOBNAKMAB(IKAJAHLJFMC HKGAELMMDKP, NHGDGBFBAIF LNAKMGONIOO, ReadOnlySpan<byte> HOPEEMIHCOI, ReadOnlySpan<byte> FLPEKKAACDI);

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EEADKPFANCG(IKAJAHLJFMC HKGAELMMDKP, NHGDGBFBAIF LNAKMGONIOO);

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GFMKBBPNBAE(IKAJAHLJFMC HKGAELMMDKP, NHGDGBFBAIF LNAKMGONIOO, ReadOnlySpan<byte> FLPEKKAACDI);

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FPLKEFDEEJM(IKAJAHLJFMC HKGAELMMDKP, NHGDGBFBAIF LNAKMGONIOO, Span<byte> HOPEEMIHCOI, Span<byte> FLPEKKAACDI);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class KGDIHPECPIK
{
	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x242D7D0", Offset = "0x242CBD0", VA = "0x18242D7D0")]
	public static bool FPLKEFDEEJM<T>(this LIKHNKHJBKG EOKBIMBPDBL, IKAJAHLJFMC HKGAELMMDKP, NHGDGBFBAIF LNAKMGONIOO, [Out] T HOPEEMIHCOI, [Out] T FLPEKKAACDI) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x242D980", Offset = "0x242CD80", VA = "0x18242D980")]
	public static bool GFMKBBPNBAE<T>(this LIKHNKHJBKG EOKBIMBPDBL, IKAJAHLJFMC HKGAELMMDKP, NHGDGBFBAIF LNAKMGONIOO, T FLPEKKAACDI) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public enum EHGAAOCMEKI
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	End,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public interface OAFEOPGEEED
{
	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MODFCKCNHMB(KFHEKKOEHDF OFAFLOECBGM, ReadOnlySpan<byte> CJFCIOOMJGN);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public interface JCFKEMAHKEJ
{
	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KFHEKKOEHDF HALOCBBBACF(ReadOnlySpan<byte> CJFCIOOMJGN);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public interface HNCJOLMBHOI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BPLOMEHFCFF(KFHEKKOEHDF IHHOPACLNAK, ReadOnlySpan<byte> CJFCIOOMJGN);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public struct NGFKNMJLNMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public KFHEKKOEHDF OFAFLOECBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public ReadOnlyMemory<byte> CJFCIOOMJGN;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public struct KFHEKKOEHDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public uint JKFKBDCHGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public int NDCLADKHPGD;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x962380", Offset = "0x961780", VA = "0x180962380")]
	public KFHEKKOEHDF(uint JKFKBDCHGAH, int NDCLADKHPGD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x5DAED80", Offset = "0x5DAE180", VA = "0x185DAED80")]
	public static bool HCMKGGFOPFL([In] KFHEKKOEHDF IOJNHOGOOGI, [In] KFHEKKOEHDF IODCBCAEEGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x5DAECC0", Offset = "0x5DAE0C0", VA = "0x185DAECC0", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x5DAED50", Offset = "0x5DAE150", VA = "0x185DAED50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x5DAEDA0", Offset = "0x5DAE1A0", VA = "0x185DAEDA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public interface FAIPBIJPAFL : KGOEGJIDJFF<FAIPBIJPAFL>
{
	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ICFEPCNMLOH(NHGDGBFBAIF KOJKDECJOKK, [Out] BJHMFLEMCLP EHDKAJFMMFD);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class POHFCMOMPEP
{
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public interface BJHMFLEMCLP
{
	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	Type GKAOFJPDKKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HNNKJEMPCFP(FGNCKLJOJDM FCCGPHFBEFP, Span<byte> ADOGMMPMLJB);

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MFIMBGNEKOH(BMMCFOKNLEA OKFNJFEOHFM, ReadOnlySpan<byte> OFAFLOECBGM);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public static class AKHHOCDGHBP
{
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct JABAMAIPKGD : ISystemStateComponentData, IComponentData, IEquatable<JABAMAIPKGD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public float3 ENADLNHEAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public float3 PLPMJCBOBHK;

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE8A0", Offset = "0x5DADCA0", VA = "0x185DAE8A0", Slot = "4")]
	public bool Equals(JABAMAIPKGD KEEHOGPOIFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface MDENMKNBFKL
{
	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NPCOHFDIHDL IOHABDODGHF(int CEOOILAHGGI);

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int LGPEKMMIDMH(NPCOHFDIHDL LJBNFNGNFKD);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface MIEDEIBEABA
{
	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	IEnumerable<GEECJLGCMBE> KLOFONBIABB
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LKCGCPACHJB(int CEOOILAHGGI, [Out] GEECJLGCMBE EHDKAJFMMFD);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface AODHIDPNNDN
{
	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LNDPEHBIDBK(int CEOOILAHGGI);
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface OCINJOAANAF
{
	[Cpp2IlInjected.Token(Token = "0x17000150")]
	List<(NPCOHFDIHDL nameHash, HOFAJMHGPOB stableTypeHash, Type type)> GHFDBDMNOAO
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class FCJMKIHNMJN
{
	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public FCJMKIHNMJN()
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
