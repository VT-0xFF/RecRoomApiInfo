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
	public class LogRegistrationIndex : JOPFPPBONLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6CC7DD0", Offset = "0x6CC67D0", VA = "0x186CC7DD0", Slot = "4")]
		public override void HEDMFNKAECO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CPALGFLFMCN
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6CBC940", Offset = "0x6CBB340", VA = "0x186CBC940")]
	public static void KAJBLNKEOAN(this Rigidbody CFFLIADABBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6CBC810", Offset = "0x6CBB210", VA = "0x186CBC810")]
	public static void KAJBLNKEOAN(this Rigidbody CFFLIADABBC, Vector3 CLFBEOENDHD, Quaternion AHEJDGJEAEC, Vector3 JIDPHBLCMCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct DECONOAHEMJ : IReadOnlyList<HNLGJNFDBGG>, IEnumerable<HNLGJNFDBGG>, IEnumerable, IReadOnlyCollection<HNLGJNFDBGG>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct MMLBLLABKPB : IEnumerator<HNLGJNFDBGG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly AKFNFIHHCPG HNGOHAEBHPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator ANMEDFHNEAJ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public HNLGJNFDBGG JOCMDMELDEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6CC8300", Offset = "0x6CC6D00", VA = "0x186CC8300", Slot = "4")]
			get
			{
				return default(HNLGJNFDBGG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6CC8280", Offset = "0x6CC6C80", VA = "0x186CC8280", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x440C880", Offset = "0x440B280", VA = "0x18440C880")]
		public MMLBLLABKPB(AKFNFIHHCPG HNGOHAEBHPK, NativeArray<LocalId>.Enumerator ANMEDFHNEAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6CC81C0", Offset = "0x6CC6BC0", VA = "0x186CC81C0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6CC8200", Offset = "0x6CC6C00", VA = "0x186CC8200", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6CC8240", Offset = "0x6CC6C40", VA = "0x186CC8240", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly AKFNFIHHCPG HNGOHAEBHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> DGICEOHLFPK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HNLGJNFDBGG MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6CBD160", Offset = "0x6CBBB60", VA = "0x186CBD160", Slot = "4")]
		get
		{
			return default(HNLGJNFDBGG);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6CBCC80", Offset = "0x6CBB680", VA = "0x186CBCC80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int HFBFEEEAEHM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public AKFNFIHHCPG NCIIENLBPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int PKLCBMGOIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool DNMEJBJAJNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6CBCC40", Offset = "0x6CBB640", VA = "0x186CBCC40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> DNMJEFCMJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x26585D0", Offset = "0x2656FD0", VA = "0x1826585D0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> CPFDNJFNDGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6CBCCD0", Offset = "0x6CBB6D0", VA = "0x186CBCCD0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6CBCFB0", Offset = "0x6CBB9B0", VA = "0x186CBCFB0")]
	public DECONOAHEMJ(int HBMOJAPOCCD, AKFNFIHHCPG HNGOHAEBHPK, Allocator MDICAPEDFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x440C2F0", Offset = "0x440ACF0", VA = "0x18440C2F0")]
	public DECONOAHEMJ(AKFNFIHHCPG HNGOHAEBHPK, NativeArray<LocalId> DGICEOHLFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6CBD040", Offset = "0x6CBBA40", VA = "0x186CBD040")]
	internal DECONOAHEMJ(AKFNFIHHCPG HNGOHAEBHPK, NativeArray<Entity> KJEILEEIDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6CBCF10", Offset = "0x6CBB910", VA = "0x186CBCF10")]
	public DECONOAHEMJ(AKFNFIHHCPG HNGOHAEBHPK, int OMBKDMFPMFJ, Allocator MDICAPEDFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6CBD0B0", Offset = "0x6CBBAB0", VA = "0x186CBD0B0")]
	public DECONOAHEMJ(DECONOAHEMJ LDMAFNKKLHF, Allocator MDICAPEDFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6CBCB90", Offset = "0x6CBB590", VA = "0x186CBCB90")]
	public DECONOAHEMJ HDIAFBEKCKI(Allocator MDICAPEDFAK = Allocator.Temp)
	{
		return default(DECONOAHEMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6CBCB50", Offset = "0x6CBB550", VA = "0x186CBCB50", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6CBCAC0", Offset = "0x6CBB4C0", VA = "0x186CBCAC0")]
	public MMLBLLABKPB BPGPEIEKEPK()
	{
		return default(MMLBLLABKPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6CBCD30", Offset = "0x6CBB730", VA = "0x186CBCD30", Slot = "6")]
	private IEnumerator<HNLGJNFDBGG> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6CBCE20", Offset = "0x6CBB820", VA = "0x186CBCE20", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public struct AMKAHKIBNFK : IList<HNLGJNFDBGG>, ICollection<HNLGJNFDBGG>, IEnumerable<HNLGJNFDBGG>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct DHHLLJMNAHH : IEnumerator<HNLGJNFDBGG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly AKFNFIHHCPG HNGOHAEBHPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator ANMEDFHNEAJ;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public HNLGJNFDBGG JOCMDMELDEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6CBD440", Offset = "0x6CBBE40", VA = "0x186CBD440", Slot = "4")]
			get
			{
				return default(HNLGJNFDBGG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6CBD3C0", Offset = "0x6CBBDC0", VA = "0x186CBD3C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x440C880", Offset = "0x440B280", VA = "0x18440C880")]
		public DHHLLJMNAHH(AKFNFIHHCPG HNGOHAEBHPK, NativeArray<LocalId>.Enumerator ANMEDFHNEAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6CBD300", Offset = "0x6CBBD00", VA = "0x186CBD300", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6CBD340", Offset = "0x6CBBD40", VA = "0x186CBD340", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6CBD380", Offset = "0x6CBBD80", VA = "0x186CBD380", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly AKFNFIHHCPG HNGOHAEBHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> DGICEOHLFPK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public HNLGJNFDBGG MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6CB89E0", Offset = "0x6CB73E0", VA = "0x186CB89E0", Slot = "4")]
		get
		{
			return default(HNLGJNFDBGG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6CB8A60", Offset = "0x6CB7460", VA = "0x186CB8A60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FPAPEBLAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6CB8500", Offset = "0x6CB6F00", VA = "0x186CB8500", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int PKLCBMGOIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6CB8500", Offset = "0x6CB6F00", VA = "0x186CB8500")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool NFLNLAGFBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8840", Offset = "0x6CB7240", VA = "0x186CB8840")]
	public AMKAHKIBNFK(int HBMOJAPOCCD, AKFNFIHHCPG HNGOHAEBHPK, Allocator MDICAPEDFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6CB88D0", Offset = "0x6CB72D0", VA = "0x186CB88D0")]
	public AMKAHKIBNFK(AKFNFIHHCPG HNGOHAEBHPK, Allocator MDICAPEDFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8950", Offset = "0x6CB7350", VA = "0x186CB8950")]
	public AMKAHKIBNFK(AKFNFIHHCPG HNGOHAEBHPK, int OMBKDMFPMFJ, Allocator MDICAPEDFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8050", Offset = "0x6CB6A50", VA = "0x186CB8050")]
	public DECONOAHEMJ BNKKAMLJKNK()
	{
		return default(DECONOAHEMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8160", Offset = "0x6CB6B60", VA = "0x186CB8160", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6CB81A0", Offset = "0x6CB6BA0", VA = "0x186CB81A0", Slot = "13")]
	public bool Contains(HNLGJNFDBGG EDKOAHIAMMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8230", Offset = "0x6CB6C30", VA = "0x186CB8230", Slot = "14")]
	public void CopyTo(HNLGJNFDBGG[] FNCIFDCGDBA, int NPOJHGDDMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7FD0", Offset = "0x6CB69D0", VA = "0x186CB7FD0", Slot = "11")]
	public void Add(HNLGJNFDBGG EDKOAHIAMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8450", Offset = "0x6CB6E50", VA = "0x186CB8450", Slot = "7")]
	public void Insert(int EBDDHAPIAHH, HNLGJNFDBGG EDKOAHIAMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8590", Offset = "0x6CB6F90", VA = "0x186CB8590", Slot = "15")]
	public bool Remove(HNLGJNFDBGG EDKOAHIAMMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6CB83C0", Offset = "0x6CB6DC0", VA = "0x186CB83C0", Slot = "6")]
	public int IndexOf(HNLGJNFDBGG EDKOAHIAMMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8540", Offset = "0x6CB6F40", VA = "0x186CB8540", Slot = "8")]
	public void RemoveAt(int EBDDHAPIAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8380", Offset = "0x6CB6D80", VA = "0x186CB8380", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6CB80D0", Offset = "0x6CB6AD0", VA = "0x186CB80D0")]
	public DHHLLJMNAHH BPGPEIEKEPK()
	{
		return default(DHHLLJMNAHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8660", Offset = "0x6CB7060", VA = "0x186CB8660", Slot = "16")]
	private IEnumerator<HNLGJNFDBGG> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8750", Offset = "0x6CB7150", VA = "0x186CB8750", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface AOEELOPANAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int OMMIJPCJBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> GDCPDHMPOJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HNLGJNFDBGG LICBGACCEKF(HNLGJNFDBGG DGICEOHLFPK);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HOGLJCDMGEC : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface HAFKMDNGPEF : MEHOIGBOHML, BOBFKIFHEGL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool DLOJNDBBAAK
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	CAGLIJIAPEC LNLEKIFMLIM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	EDFCFDFOOIE OOBNHNLFCCI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	OAFALLIAHBA BHBJEHGAJEA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	GDCOFCJLLOD HDPHOPGAILJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface BOBFKIFHEGL
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool LOBPMBCKJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface LIOKMCEOOLO
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGAOIPIAFJG(bool CLMKDBDPNNH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[FACHKNACJCC(KCCBMFNNLJD.PhotonRoom)]
public interface OAGEEPOBIBL
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool MNHONPKJAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BCNDLHBJDOL(bool CEAFCCPFHNA);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HKHGIBHALBD();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IIOHBJLFANM(ByteString CMLPOCNMNKL);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NOBFLILLMKH();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CGDBKBKDHIB();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DHFAHDJIEBM();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HJMKBPPJPNI();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void COBBNNHONOP();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface OAFALLIAHBA
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	KFBOEJEEJNO LNLEKIFMLIM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	EDFCFDFOOIE OOBNHNLFCCI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	LNDIPIINEOG GMMFMDFJJFK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	DJGKINNPEOL EGJAKPHKBMH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	HAFKMDNGPEF GMMIJHACMOK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	OAGEEPOBIBL GGPDBNIFMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	AKFNFIHHCPG NCIIENLBPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	FJAPLNLLFFB LIFEFNNCMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	INCMDLLBCFJ OECDDMNALBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	FKEHAAEBDFE AILJHMPCGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	IDKFIOJAOJP ADFEMPKIPPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	KEMLCCGHOGN DFCAFELHIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	EMKHMEMDPAP CFIIJFDDAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	CEPFICOCOAG JFNLDPHHEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	DAJDLLOOBFB NPOGEPOHNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	ICEGEODOPCL HCFDFJNIJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	KHACGHKOAGH DELIPFFLOIF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	MJLCKCBMGKD FNGIBKFIFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	MLMNDHFKMLB JCABNALLONH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	JFNMKJFMBOB JDMDMDMBIAF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	CNAOIDFFGAE IGJMJOOPJGK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	OIAIHOFHKBH CCMNOBPDLDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	DBBIFKLCCJB BDPHMAAFFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	HDLDMDGHIEE LCECPAEOBOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	DMOFABMJHHG JGOBKBFJILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	LNHAPBFKEAD KEODBLMADOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	LJGHCCKMFAM IIPEMBEMHFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	PBPBCNCHGGP GJKLAKPNCDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	FAGOKNOGCAI AIJLOFIPOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DebuggerTypeProxy(typeof(JAAOHMBFDIH))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct HNLGJNFDBGG : IComparable<HNLGJNFDBGG>, IEquatable<HNLGJNFDBGG>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly HNLGJNFDBGG BONAFNCHILA;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int GKBDKOMKKMC = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int KBDLPLFNPGK = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int ONHJEIOOAGM = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int OLCAFOBGFMN = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId ELHMIJIMOPL;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public AKFNFIHHCPG NCIIENLBPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9530", Offset = "0x6CB7F30", VA = "0x186CB9530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public HAFKMDNGPEF GMMIJHACMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6CC5470", Offset = "0x6CC3E70", VA = "0x186CC5470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public LocalId LOMPIBNGJAE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6CC5610", Offset = "0x6CC4010", VA = "0x186CC5610")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal GDCOFCJLLOD HDPHOPGAILJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6CC58D0", Offset = "0x6CC42D0", VA = "0x186CC58D0")]
		get
		{
			return default(GDCOFCJLLOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool KAMLGAEHELA
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6CC54D0", Offset = "0x6CC3ED0", VA = "0x186CC54D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool FAFLMPBHKPN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6CC58E0", Offset = "0x6CC42E0", VA = "0x186CC58E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6CC5C00", Offset = "0x6CC4600", VA = "0x186CC5C00")]
	public HNLGJNFDBGG(AKFNFIHHCPG KOIKMIOCMGL, LocalId ELHMIJIMOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
	public GKNFJEDFFIC MLLIOHBBBAB()
	{
		return default(GKNFJEDFFIC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6CC5A50", Offset = "0x6CC4450", VA = "0x186CC5A50")]
	public static LocalId PFMAFNCLKDD(HNLGJNFDBGG CMJENOPOHEI)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6CC5A90", Offset = "0x6CC4490", VA = "0x186CC5A90")]
	public static Entity PFMAFNCLKDD(HNLGJNFDBGG CMJENOPOHEI)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6CC5930", Offset = "0x6CC4330", VA = "0x186CC5930")]
	public static bool LBPOCMFLOBH(HNLGJNFDBGG GPKBBMJKBAE, HNLGJNFDBGG AAMOGMLMOOI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2010", Offset = "0x6CC0A10", VA = "0x186CC2010")]
	public static bool CIBBJNPKHCF(HNLGJNFDBGG GPKBBMJKBAE, HNLGJNFDBGG AAMOGMLMOOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6CC5AD0", Offset = "0x6CC44D0", VA = "0x186CC5AD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6CC5730", Offset = "0x6CC4130", VA = "0x186CC5730", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6CC5650", Offset = "0x6CC4050", VA = "0x186CC5650", Slot = "4")]
	public int CompareTo(HNLGJNFDBGG AIPFCMFLDKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "5")]
	public bool Equals(HNLGJNFDBGG AIPFCMFLDKG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class DEILLMCLJKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6CBD1A0", Offset = "0x6CBBBA0", VA = "0x186CBD1A0")]
	public static NONPGOCJFKO ALFIBAJLJKO(this HNLGJNFDBGG GIGIFGONEAO)
	{
		return default(NONPGOCJFKO);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6CBD250", Offset = "0x6CBBC50", VA = "0x186CBD250")]
	public static GKNFJEDFFIC EAPGNAMLGLA(this HNLGJNFDBGG GIGIFGONEAO)
	{
		return default(GKNFJEDFFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2AFD340", Offset = "0x2AFBD40", VA = "0x182AFD340")]
	public static T FHCDKPEOBBD<T>(this HNLGJNFDBGG GIGIFGONEAO) where T : struct, CLEILMDBNCI
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class JAAOHMBFDIH
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct GDCOFCJLLOD : IEquatable<GDCOFCJLLOD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte OMKGKCDECFC;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] AJBLMIKCHLB;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static AKFNFIHHCPG IOGILCMCHDG;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static HAFKMDNGPEF FMHLIANPHAC;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static AKFNFIHHCPG[] IMJLENMINJM;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static HAFKMDNGPEF[] ILNGPDIILCK;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> JCOMHNLIFKD;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public HAFKMDNGPEF GMMIJHACMOK
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6CC0E40", Offset = "0x6CBF840", VA = "0x186CC0E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public AKFNFIHHCPG FALBKLABCIB
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6CC1A50", Offset = "0x6CC0450", VA = "0x186CC1A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1CA0", Offset = "0x6CC06A0", VA = "0x186CC1CA0")]
	static GDCOFCJLLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x225C3B0", Offset = "0x225ADB0", VA = "0x18225C3B0")]
	internal GDCOFCJLLOD(byte CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5E0A550", Offset = "0x5E08F50", VA = "0x185E0A550", Slot = "4")]
	public bool Equals(GDCOFCJLLOD AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6CC13A0", Offset = "0x6CBFDA0", VA = "0x186CC13A0", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x91AAC0", Offset = "0x9194C0", VA = "0x18091AAC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1BE0", Offset = "0x6CC05E0", VA = "0x186CC1BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1300", Offset = "0x6CBFD00", VA = "0x186CC1300")]
	private static AKFNFIHHCPG EAHPIAHPNGA(byte OMKGKCDECFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1B30", Offset = "0x6CC0530", VA = "0x186CC1B30")]
	private static HAFKMDNGPEF KMODHEEBFEL(byte OMKGKCDECFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1120", Offset = "0x6CBFB20", VA = "0x186CC1120")]
	private static object DINLIHIJGNE(byte OMKGKCDECFC, object[] ACOKCANBLGD, object PEMAOEALEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1440", Offset = "0x6CBFE40", VA = "0x186CC1440")]
	private static int FBMAMADBGGB(byte OMKGKCDECFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1110", Offset = "0x6CBFB10", VA = "0x186CC1110")]
	private static int BKBIOINDBIL(byte OMKGKCDECFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1280", Offset = "0x6CBFC80", VA = "0x186CC1280")]
	private static (int, int) DIPIICFAFNI(byte OMKGKCDECFC)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1BD0", Offset = "0x6CC05D0", VA = "0x186CC1BD0")]
	private static byte ODAFIPMJHEC(int DHAIIPINBBD, int EBDDHAPIAHH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6CC17B0", Offset = "0x6CC01B0", VA = "0x186CC17B0")]
	internal static GDCOFCJLLOD HEDMFNKAECO(HAFKMDNGPEF FHIPHDJBKEC, AKFNFIHHCPG HHDENAJPKAI)
	{
		return default(GDCOFCJLLOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0F20", Offset = "0x6CBF920", VA = "0x186CC0F20")]
	internal static void BFCLMIEHOBM(GDCOFCJLLOD OMKGKCDECFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1450", Offset = "0x6CBFE50", VA = "0x186CC1450")]
	private static void FOHHMFJJDFL(int HBMOJAPOCCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface FOMDPMOBLED
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFMJIMPEPOI();

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMJGDDGAEBL(bool NODMJOKLONC);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DAFGMKMBAKA(GameObject EABKFLBGOGN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface JCEIHDJKJNJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Guid ADIMLHDKIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MAIGOFMMLGK(Guid EOGKNMHPMEG, Guid ODLOJKBAHLA, Guid ECFPIKHPAEB);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task BDJLHGPEANL(Guid EOGKNMHPMEG, Guid[] JFGDEMOPEJJ, Guid ECFPIKHPAEB);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid ADNKJCACAHE(Guid OJMCAIBKDOI);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task JBFNPKAHKHJ(HNLGJNFDBGG DNBGHMKOKLF);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LCIHJCHHDIB(GJAKFAKLBCN MHFLCAPHJLM, Guid PFEFPIPCMNI);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GBMLFKIJHPJ(Guid OJMCAIBKDOI, bool CEAFCCPFHNA);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface NHCHJJMAHDC
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NCIDOJLKFCC(DECONOAHEMJ DGICEOHLFPK);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface OCOAIDODJOG
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MBAFHJHPIGB(GameObject NACALJPDNMH, GameObject BACKMBFLFEK, int FBEHBAOLLEG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface EDFCFDFOOIE
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	FOMDPMOBLED FMFMGCJPLLC
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	DFCJDCCNEOC KBGBAKJCKOB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	PJMEHJIGFJD LLIGOCHECHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	LABNDNNLDLJ OKKNIDHNKKF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	MCMLGHIILGD GHHPIPOKHKN
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	NOKJLFNBLCI LEDOAIMMBNG
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	MLHICJAALLC BOPMAFGMBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	BAPOCIBOKDJ FOHGCPENEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	OEJJKJCMIOL APHGCAKKNMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	DKKGENPPMGJ APLIMEMFDAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface DFCJDCCNEOC
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string BHKCPOOGMMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface PMFIOCDHPEB
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKNGPAOEBLI(Action ENNGIICFMFD, bool NODHMJNDFEA);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CHCCIHJAFIH(string HBOONHFLONJ);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int HOMFCFMDDGC(string HBOONHFLONJ, int PEMAOEALEHB);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NKGEIEDELGO([Out] bool CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BEPFOHBGHEA([Out] bool CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FCGBDHLBIEM([Out] int CLMKDBDPNNH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface PJMEHJIGFJD
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string OHBALENOFNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] OFLEGBGGJGM(IEnumerable<AGHNKBGOPOJ> HEFPMFFDCHB, bool COOCKNOCHKK);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IJEOCCFEGOF(GameObject EABKFLBGOGN, [Out] NONPGOCJFKO[] LBOAFPMJOCJ);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AMKBCDGNFLD(GameObject EABKFLBGOGN, [Out] int PNJEDOADFLB, [Out] KFELEOEDBBF DPMCJCFIMPM);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GJAKFAKLBCN IPOMNCOOHPC(AGHNKBGOPOJ IHHJPAMNDBP);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GJAKFAKLBCN IPOMNCOOHPC(string MAOAEMLFGPJ, NONPGOCJFKO[] BHJCOOBDBLN, Vector3 BJDHDJCINFH, Quaternion FJFNLINEAKI, Vector3 ADJNFMJNIAA);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GJAKFAKLBCN CEBBLOFEFHK(string MAOAEMLFGPJ, NONPGOCJFKO[] BHJCOOBDBLN, Vector3 BJDHDJCINFH, Quaternion FJFNLINEAKI, Vector3 ADJNFMJNIAA);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject GLGFJIAHLBN(string MAOAEMLFGPJ);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DGEJOFIHFJP(GameObject BBLIAGCJEAC, bool LICPECIHEKO);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PIKHDCMFLAL(GameObject EABKFLBGOGN, bool GJNGBMJLFKB, bool DBDALNNPIIK);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class HGCGGFFFCBO
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6CC4AA0", Offset = "0x6CC34A0", VA = "0x186CC4AA0")]
	public static GJAKFAKLBCN IPOMNCOOHPC(this PJMEHJIGFJD NAAJCHKOOEC, Vector3 BJDHDJCINFH, Quaternion FJFNLINEAKI, Vector3 ADJNFMJNIAA, params NONPGOCJFKO[] LBOAFPMJOCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6CC4940", Offset = "0x6CC3340", VA = "0x186CC4940")]
	public static GJAKFAKLBCN CEBBLOFEFHK(this PJMEHJIGFJD NAAJCHKOOEC, Vector3 BJDHDJCINFH, Quaternion FJFNLINEAKI, Vector3 ADJNFMJNIAA, params NONPGOCJFKO[] LBOAFPMJOCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface LABNDNNLDLJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IKNHELKGOAO(bool CEAFCCPFHNA);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface MCMLGHIILGD
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool OJGCOKFDDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool MAJNEMOOLAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool PHCLHKCLKBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	int DCEEMFGBFOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool MGMCDJCNNIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JOGDNBOCPLK(object NGDEBDJEGEI);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FCEKFDKEADK(object NGDEBDJEGEI);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LCOEDCCDLJP(object IPOCAIFIKHJ);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EBDJLILKGPO(object IPOCAIFIKHJ);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ViewId BLKFFKELJNO(GameObject BCHIECCDCEC);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NMKHBKLDIHF(NativeArray<ViewId> OHPCGLCOGGN);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FMMMEHACMAG(NativeArray<ViewId> FGPMNBJAADA);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void POMKCMFAHLC();

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OBODDOFKFDE(uint LACDNCHIEBD, ReadOnlySpan<byte> MHDCEGBPPOM, bool MPMGBNOGKNI = false);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OBODDOFKFDE(uint LACDNCHIEBD, ReadOnlySpan<byte> MHDCEGBPPOM, ReadOnlySpan<byte> AACCOBFBJMI, bool MPMGBNOGKNI = false);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GMONCKPKGCB(Func<int, bool, int> JHAGBFMBGAH, bool BECPDHGEMII);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LGHICAEDKKM(object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NNDECADOHCM(object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "18")]
	uint DHCOGOBDFBE(uint DCPDLABEFAK);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class NODONPMILJP
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6CC91F0", Offset = "0x6CC7BF0", VA = "0x186CC91F0")]
	public static PNCOLCBGHJK KLHPOKKKPJA(this MCMLGHIILGD CALPACHLHEI, object KLGLJKMNAIM)
	{
		return default(PNCOLCBGHJK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct PNCOLCBGHJK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private MCMLGHIILGD CALPACHLHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private object KLGLJKMNAIM;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6CCB580", Offset = "0x6CC9F80", VA = "0x186CCB580")]
	public PNCOLCBGHJK(MCMLGHIILGD CALPACHLHEI, object KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6CCB530", Offset = "0x6CC9F30", VA = "0x186CCB530", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface NOKJLFNBLCI
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KGMBMAODFKD(GameObject EABKFLBGOGN);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface MLHICJAALLC
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public struct DOHDIKJOFBC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private MLHICJAALLC IDDLDNIDLAG;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6CBDDD0", Offset = "0x6CBC7D0", VA = "0x186CBDDD0")]
		public DOHDIKJOFBC(MLHICJAALLC IDDLDNIDLAG, string MEBLNPKEJMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6CBDD70", Offset = "0x6CBC770", VA = "0x186CBDD70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct JHHLODMIMGP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private MLHICJAALLC IDDLDNIDLAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Task CCAACFNOONL;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6CC7D10", Offset = "0x6CC6710", VA = "0x186CC7D10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FBDICDGAHMJ(string MEBLNPKEJMN, float PCILJOIJLLL = 5f);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NDBIKFEKDMB();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DGBHMMCLPKC(bool AECODDEOICM, string MEBLNPKEJMN);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class MEGNLBFBHDA
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6CC8140", Offset = "0x6CC6B40", VA = "0x186CC8140")]
	public static MLHICJAALLC.DOHDIKJOFBC KHOMGJGJFPB(this MLHICJAALLC CALPACHLHEI, string MEBLNPKEJMN)
	{
		return default(MLHICJAALLC.DOHDIKJOFBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface JOGFKBBKBBD
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int ENABJIFAFAO(GameObject EABKFLBGOGN);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PIEMMIFOKIC(GameObject EABKFLBGOGN);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GLNCAAEBLKG(int MIDIEPCHOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object NKAJOCHBOLO(HNLGJNFDBGG ELHMIJIMOPL, GameObject EABKFLBGOGN, Action<HNLGJNFDBGG, int> DKOPNCNMOIF);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BJHNEFPMELG(GameObject EABKFLBGOGN, object PKLBGCEEOFD);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface EBPNOAIOFMH
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool MOHNFIMGKIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate FCPHGHOAKGF(ILEODJHHPDA.EEHNONCEOMC LDMEIIOMEGB, Action<ILEODJHHPDA.EEHNONCEOMC> DKOPNCNMOIF);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LNKMMFMJAFG(ILEODJHHPDA.EEHNONCEOMC LDMEIIOMEGB, Delegate DKOPNCNMOIF);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate CIOJINHBEBL(ILEODJHHPDA.EEHNONCEOMC LDMEIIOMEGB, Action<ILEODJHHPDA.EEHNONCEOMC> OPCNKAOJKNF);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MFAFFFLCNJO(ILEODJHHPDA.EEHNONCEOMC LDMEIIOMEGB, Delegate DKOPNCNMOIF);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OPJGDKAGBJB(ILEODJHHPDA.EEHNONCEOMC LDMEIIOMEGB);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ILEODJHHPDA.EEHNONCEOMC KMODEJDBCCC(GameObject EABKFLBGOGN);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface BAPOCIBOKDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	int KLDIMLLCPPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	int ELCFEPBDNJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool MAJNEMOOLAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool HLGFIGDLJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int DILHNFJKJGK(GameObject EABKFLBGOGN);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JLOAKLGCNCC([Out] Vector3 BJDHDJCINFH);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BCKNEFPODPB();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HNLGJNFDBGG ILCAIPLGEEH(int MIDIEPCHOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HELMKOEEJDN();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface OEJJKJCMIOL
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool MNHONPKJAHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface HIEGKEGGIJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	ONKLLCFHLEK BAPHPFBAHGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	CBHFJOBOEMD MANNAMLILIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NFLHAGAANDI(Transform JKDLLOIHFGK);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ENLMBOJGCEM(Transform JKDLLOIHFGK, MKHKMPLGLOM GKILBNBDLFA);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PMFJGFNLJFC(Transform JKDLLOIHFGK, NIDBICOIDOK GHFGJIAINPB);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface CPGGEHKMIEL
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface DKKGENPPMGJ
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action KOLJGBMACNI;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ABDDDDJGGKL(DECONOAHEMJ MCEIFLAEJPC, bool AECODDEOICM);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface KKCNFHFGLMB
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKEGEDBGNPM();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface NPJEAFOMHKJ
{
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KFELEOEDBBF GDCLIIJBJJE(GameObject BCHIECCDCEC);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJCALPLFOEM(GameObject EABKFLBGOGN, GJPPNGCHFKK FMJGNFAMAIA, JMCAKEIMOJI CMAHEEHBECF);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FNNLCAECKNC(HNLGJNFDBGG ELHMIJIMOPL, bool BKNGOCKHNDK, float3 JJLOFBNHDMM, quaternion ILIIOFAHOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NGFJIAOLCDO(GKNFJEDFFIC OMFPMCIAPMD, GKNFJEDFFIC IPOCAIFIKHJ, GKIIHAFLNOK OIKBGDLAKHG);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BNFDBAMOADJ(GKNFJEDFFIC OMFPMCIAPMD, GKIIHAFLNOK OIKBGDLAKHG);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HMLCGBOHFBO(DECONOAHEMJ JPDDIMCFFBO);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LBPBAGLLHHO(DECONOAHEMJ HNGOHAEBHPK, NativeArray<LocalPoseData> NKFHCHDJNKD, NativeArray<float3> CCHPDLKPKPA);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KICCKCLFDAN(DECONOAHEMJ HNGOHAEBHPK, DECONOAHEMJ AHMMFNNKPMO);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GNACCAIGJLB(DECONOAHEMJ HNGOHAEBHPK, bool FEFGIMMPOME);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ODAGEJAIGOP(DECONOAHEMJ HNGOHAEBHPK, bool LEFJNHLHOHP);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct CDDIDBAJLOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly OLGDBMKHIOM PJOMFOPGCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly OLGDBMKHIOM OAACEGBODFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint IFBADJMJAIC;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6CBBDF0", Offset = "0x6CBA7F0", VA = "0x186CBBDF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct PLNFIKDMJAA
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly ANDGIEDMMDP AGICKJCJECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal readonly CDDIDBAJLOM ENNGIICFMFD;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7C80", Offset = "0x6CC6680", VA = "0x186CC7C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct JGKLGLDOHBJ
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly ANDGIEDMMDP AGICKJCJECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal readonly CDDIDBAJLOM ENNGIICFMFD;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7C80", Offset = "0x6CC6680", VA = "0x186CC7C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct CACKELOCDIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal readonly uint IFBADJMJAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal readonly bool PDNDNIILEBN;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6CBBC90", Offset = "0x6CBA690", VA = "0x186CBBC90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct OLGDBMKHIOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal int ELDAPMPELBH;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6CCA210", Offset = "0x6CC8C10", VA = "0x186CCA210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface DCCLBONJFIG
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	FCNDGMKLPFJ AMBGHOJGECJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public enum HMLDIHLHBCB
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
public interface GJAKFAKLBCN : KCKFCGEFOEI
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	HMLDIHLHBCB MBMOAIIIPOM
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool BCHKNAMEDPM
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	GameObject EABKFLBGOGN
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<GJAKFAKLBCN> DKNHGBOIMJO;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(LNDIPIINEOG HHLCCPFFGLC, HNLGJNFDBGG OEPAIEDOBNK);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool NACIJIEFOBC);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class GNMILKNPCBG
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2930", Offset = "0x6CC1330", VA = "0x186CC2930")]
	public static bool IPJFKILMFNI(this GJAKFAKLBCN HDJBPODPFGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6CC28E0", Offset = "0x6CC12E0", VA = "0x186CC28E0")]
	public static bool FBCBJFEHGOE(this GJAKFAKLBCN HDJBPODPFGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2980", Offset = "0x6CC1380", VA = "0x186CC2980")]
	public static bool OENGACCIMMB(this GJAKFAKLBCN HDJBPODPFGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2850", Offset = "0x6CC1250", VA = "0x186CC2850")]
	public static bool DLOJNDBBAAK(this GJAKFAKLBCN HDJBPODPFGE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface KCKFCGEFOEI
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool PAJCHKNMDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	HNLGJNFDBGG HMLBDKHBFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface KKNENOMBIEO
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate void AHMCGILOPKE(IEFGHPNJHKD LBPLIDAEDCO);

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event AHMCGILOPKE INLIEEBIDHI;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface GCEMPILJLDP
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NMFOIFMICOJ(Vector3 BJDHDJCINFH, Quaternion FJFNLINEAKI, Vector3 ADJNFMJNIAA);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPIHKLEMIHN(HNLGJNFDBGG DLPGBMPJIIG);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CNNMAKMOGCH(bool IPBKMIABCGK);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GLMBPHOGHLG(bool LEFJNHLHOHP);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface LIOIBCMNIEO
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface JDGELGGMKIP
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(FJDKJBAPALO MGFMAOHEOAO);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface FJDKJBAPALO
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	GameObject EABKFLBGOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	Transform JKDLLOIHFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	HJICKIEKHCB JGCCEPHIFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool BBBEOAHNFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IIHEJPBPMJJ(HJICKIEKHCB BMCAAIIMEIN);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface HJICKIEKHCB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	HNLGJNFDBGG HMLBDKHBFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	Rigidbody ENJGFFKJICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	FJDKJBAPALO LLPIPPFGNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	GameObject FIDFGJFJLOA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Transform DHHBNJAMIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	HJICKIEKHCB GCDGMCMKOIG
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	HJICKIEKHCB AAHAADHCHKF
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	int FHEGHFENGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool OPJGDKAGBJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	bool HADEFDBIEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	MOINMCBEJEM ODBJPAPAGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "31")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	BNOGFHPHCAG HCKNGOOJLMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	float ADIOGPKDCDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "35")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 LPFOLNGLBAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	Vector3 ECIDGPFBLAC
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 FAAJKJFJEPO
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Vector3 MBFKAFHGKDN
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool LPDJMMMOHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	bool DJPEMFPPIEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool MAPNACMJLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 DEFFNLNMPNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 KAAHBKEPLBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Vector3 KCEKPJILAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "50")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 FPCHOLPNOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	float KDHFLDGHHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float MIGGNCCCNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Vector3 BCKABBMCBMI
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Quaternion POPAGHEFHJP
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	float HPHNEEEKANI
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	float EPCMFHDALND
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool BNJPFDOMFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	NFCFPCIBOBP ILGDOANNLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool ECACFOIGDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Transform MBHDHJFCPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	Vector3 KACBAACBPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	float LKDEHMDCGLA
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	float NBGFHJOBHBF
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Quaternion LEKKDBMJIJL
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Vector3 MHEDOFLPKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	Quaternion MGLMKDCNIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	RigidbodyConstraints ENALJCPNLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	bool FMNKECDKHIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	CollisionDetectionMode MMFMGKDFGGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	bool JKINAMKOAAB
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event NKPGNCNJBFD IEDGJIENIIM;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event NKPGNCNJBFD PNCCADFDAHC;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event NKPGNCNJBFD ODFMBBFOAKF;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event NKPGNCNJBFD NBIFIJICLGO;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event NKPGNCNJBFD DNICKMKOHNE;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event NKPGNCNJBFD KKPBBMAJJGO;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event NKPGNCNJBFD AJLHECBDMME;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event OOHMNMHPFKK EPOBKDBHIGE;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<JNKKEIFENFB, JNKKEIFENFB> AEJNOMLLHBM;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "26")]
	HJICKIEKHCB JIBDJHPGHGL(int EBDDHAPIAHH);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void AEDGDCGJMKG((Quaternion rot, Vector3 moments) FLBDCMBPIHC);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void IMJENBPCPEE();

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void CIPKIFJBFLJ();

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void MDKDIMOAJHH();

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void IEDGDDEBKFI();

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void FPIHKLEMIHN(HJICKIEKHCB CLMKDBDPNNH, bool LHJNJOHGEIJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void JFLCHOFPOKB(object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void LHDFADACBMI(object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 JHNNDLBNDDF(Vector3 IACJOJBIIMH);

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "95")]
	Vector3 LMNMAMIHNPF(Vector3 OHJOFKNMAIN);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void PDDPELNLBLF();

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void DEPFEIPKFNH();

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void JEBKIEAIHCJ();

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void AJAFIDJFFLO(Vector3 EMGHCEJLGLC, Vector3 KJKLMOGLNDO);

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void ELGBIIGBNKJ(Vector3 HPJCGHLPDFH, Vector3 AGNGOBCJFND);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void LFJNIAENKID(Vector3 LFFDCABHEON);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void IOIBEGCCJIK(HBBOOGIPJMD FFJEGHOFDPM, Vector3 EMGGJFAEADN, float CPAMMGNNLIK, float FANFOKDGIAB = 8f, float CDKGJFKHGOO = 1f);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void NFEHHOPLBFI(JENDIECHPBG EDKHDNCHGOP, Vector3 BNLBDJCNEIC, float OBBKOHIDJFD = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void DFNDJDNAENI(JENDIECHPBG EDKHDNCHGOP, Vector3 FJFNLINEAKI, float ELILELMDMOP = 7f, float NHPMFBAHPKH = 1f);

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "105")]
	Vector3 MDNPJINCMNB(Vector3 CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "106")]
	Vector3 GEOJDKKDNBE(Vector3 CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void OCFNMMFLADB();

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void APDICGGOONA(HJICKIEKHCB FHNLPGNOJOF, object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "109")]
	void JMLHMFGHOHO(object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void JILPDFLGOIA();

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void NFLANFFNEKE();

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void LJDOILDGGFC();

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "113")]
	bool DAGFFDAJHPA();

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void PADIIMONECN();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void EKLHHEPCCKC(object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "116")]
	void OKGNMFPINPB(object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void PIFPFDAHBCB(object KLGLJKMNAIM, bool IMIKPNPKFPA);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void HLFGHGFJBHK(Vector3 ILNFMJCEOCO, Quaternion LDGNMLEDOMN);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void LHLGGAMELBI(Vector3 PEEBPBGNOFG, Quaternion BLGCEGNAMEE);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "120")]
	bool JKJDBLPFKHK(float EHGIEAAFJMP);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void BCMOECEMPCD(object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void FAKHJILNJKI(object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void MIICELNANPB(object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void GIILIPCFCKI(object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void LAANHEMGOCB(Vector3 MOFNDFHCJJC, ForceMode JFFPEBEJOGP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void PHKJEADNHIM(Vector3 MOFNDFHCJJC, Vector3 BJDHDJCINFH, ForceMode JFFPEBEJOGP);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void CECHKGFJLEI(Vector3 LGFOKCMDDNH, ForceMode JFFPEBEJOGP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void BJODMGMPAJI(Vector3 LGFOKCMDDNH, ForceMode JFFPEBEJOGP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "129")]
	bool KELNKHMGIFP(Vector3 IMGPFEFAFKM, [Out] RaycastHit OEEPALGMIPF, float NGBAMCDGGDI);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void NLPLHAJCENC();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface BNOGFHPHCAG
{
	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KBKHAAKNHKE(Vector3 EOPLDPICDNK);

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KMHICJLHCFB(Vector3 DJJLOCLIPLL);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OCMPAKFPILL(Vector3 EOPLDPICDNK);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AEFOCOAHMHH(Vector3 DJJLOCLIPLL);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface MOINMCBEJEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 HNLJDHBDHPN();

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 LIINOOCIIKD();
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public delegate void NKPGNCNJBFD(FJDKJBAPALO APKOPDGLCAE);
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum INKFOOEEFOM
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
public enum HBBOOGIPJMD
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
public delegate void OOHMNMHPFKK(FJDKJBAPALO APKOPDGLCAE, bool LHJNJOHGEIJ = false);
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum JENDIECHPBG
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct BBDIDLADECH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Rigidbody BBHGIADMCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public object AMBHKHDIIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector3 AKEOELCGFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector3 NNGNAJJPAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public MFAANDACBHL LJMICMJLNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool MFPFKBMMAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool LMCBENELCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool JCHCOBKNLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public bool KKKBNMBMODP;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface MNMHABPDCMF : EFAPCHNMOJD<NONPGOCJFKO>, JAKKDLLLILG, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface OBICMMPLLPB<T> : DLFIHAKFFEP<NONPGOCJFKO, T>, EFAPCHNMOJD<NONPGOCJFKO>, JAKKDLLLILG, IDisposable, MNMHABPDCMF where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class LNHHJJJDHFK
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x2D46700", Offset = "0x2D45100", VA = "0x182D46700")]
	public static bool MJGHNDKEOOO<T>(this EFAPCHNMOJD<NONPGOCJFKO> FMKCBFNEFEH, NONPGOCJFKO BHJCOOBDBLN, [Out] T CLMKDBDPNNH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9E70", Offset = "0x2AB8870", VA = "0x182AB9E70")]
	public static bool IDPEEMDPGBG<T>(this EFAPCHNMOJD<NONPGOCJFKO> FMKCBFNEFEH, NONPGOCJFKO BHJCOOBDBLN, [In] T ANAJBMGGMGD) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface LOOLGMIMLBH : EFAPCHNMOJD<HNLGJNFDBGG>, JAKKDLLLILG, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface MLOIIHAOOPA<T> : DLFIHAKFFEP<HNLGJNFDBGG, T>, EFAPCHNMOJD<HNLGJNFDBGG>, JAKKDLLLILG, IDisposable, LOOLGMIMLBH where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class CGILDIHNFKH
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x2A10550", Offset = "0x2A0EF50", VA = "0x182A10550")]
	public static T PHNOCPFLPNG<T>(this EFAPCHNMOJD<HNLGJNFDBGG> FMKCBFNEFEH, HNLGJNFDBGG ELHMIJIMOPL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9E70", Offset = "0x2AB8870", VA = "0x182AB9E70")]
	public static bool IDPEEMDPGBG<T>(this EFAPCHNMOJD<HNLGJNFDBGG> FMKCBFNEFEH, HNLGJNFDBGG ELHMIJIMOPL, [In] T ANAJBMGGMGD) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct NFBFCOHOKHJ : IComparable<NFBFCOHOKHJ>, IEquatable<NFBFCOHOKHJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly NFBFCOHOKHJ BONAFNCHILA;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly NFBFCOHOKHJ CLEBAMOKADI;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly NFBFCOHOKHJ BPPKACDKAKN;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly NFBFCOHOKHJ GPCKMENIPFP;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly NFBFCOHOKHJ OBAHEELLPLK;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly NFBFCOHOKHJ LIHBGEDEBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public int MOMFAOPBBMD;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool EKLKKELLCBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x6CC8870", Offset = "0x6CC7270", VA = "0x186CC8870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public int LEKBLEGFGGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x6CC8970", Offset = "0x6CC7370", VA = "0x186CC8970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0xB0FC60", Offset = "0xB0E660", VA = "0x180B0FC60")]
	public NFBFCOHOKHJ(int EBDDHAPIAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6CC8910", Offset = "0x6CC7310", VA = "0x186CC8910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6CC8880", Offset = "0x6CC7280", VA = "0x186CC8880", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0xB7BA80", Offset = "0xB7A480", VA = "0x180B7BA80", Slot = "5")]
	public bool Equals(NFBFCOHOKHJ AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x1CB2800", Offset = "0x1CB1200", VA = "0x181CB2800", Slot = "4")]
	public int CompareTo(NFBFCOHOKHJ AIPFCMFLDKG)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x140D770", Offset = "0x140C170", VA = "0x18140D770")]
	public static NFBFCOHOKHJ PFMAFNCLKDD(int EBDDHAPIAHH)
	{
		return default(NFBFCOHOKHJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x140D770", Offset = "0x140C170", VA = "0x18140D770")]
	public static int PFMAFNCLKDD(NFBFCOHOKHJ BDGIFBFMLEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6CC8980", Offset = "0x6CC7380", VA = "0x186CC8980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct GKNFJEDFFIC : IEquatable<GKNFJEDFFIC>, KCKFCGEFOEI
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly GKNFJEDFFIC GAJKCFIOPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public HNLGJNFDBGG HMLBDKHBFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0", Slot = "6")]
		get
		{
			return default(HNLGJNFDBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public BOLJHNBDPJH DHHBNJAMIOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(BOLJHNBDPJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public IOPBNEOHIPD LIFEFNNCMJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(IOPBNEOHIPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private AKFNFIHHCPG NCIIENLBPIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9530", Offset = "0x6CB7F30", VA = "0x186CB9530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public GameObject EABKFLBGOGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2110", Offset = "0x6CC0B10", VA = "0x186CC2110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public NONPGOCJFKO AHPJHBFOHIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6CC26D0", Offset = "0x6CC10D0", VA = "0x186CC26D0")]
		get
		{
			return default(NONPGOCJFKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public IFLBPGBFPBJ LCCFHMLMLJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6CC23B0", Offset = "0x6CC0DB0", VA = "0x186CC23B0")]
		get
		{
			return default(IFLBPGBFPBJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public KFELEOEDBBF OFCHLDFNLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6CC1F30", Offset = "0x6CC0930", VA = "0x186CC1F30")]
		get
		{
			return default(KFELEOEDBBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool HEFLOHCGIJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6CC1FD0", Offset = "0x6CC09D0", VA = "0x186CC1FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool HNGOAIMFIMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2480", Offset = "0x6CC0E80", VA = "0x186CC2480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool MHHNFDLNEIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6CC1EB0", Offset = "0x6CC08B0", VA = "0x186CC1EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool KAKCBHMDEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6CC1F10", Offset = "0x6CC0910", VA = "0x186CC1F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool EILKNLAHHOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2030", Offset = "0x6CC0A30", VA = "0x186CC2030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool MEECMFIIPDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6CC1FF0", Offset = "0x6CC09F0", VA = "0x186CC1FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool JAIKKLDLHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2510", Offset = "0x6CC0F10", VA = "0x186CC2510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool OMMLDHJEFKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6CC1ED0", Offset = "0x6CC08D0", VA = "0x186CC1ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool BNPLKJKJHDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6CC20F0", Offset = "0x6CC0AF0", VA = "0x186CC20F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public NJAEJEHFLNH CGCIMMPJHOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(NJAEJEHFLNH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public IEKBPHDEOPH CMBCEGKMBAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(IEKBPHDEOPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public NBDKNDEBOBH NPOGEPOHNFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(NBDKNDEBOBH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public OLIEDPFEEDD OKAKJLHBBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(OLIEDPFEEDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public ODIPHPPBKFO JFNLDPHHEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(ODIPHPPBKFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public OJJFJEICHDD IJDKEKBPKCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(OJJFJEICHDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public FHMNGDAOMCN BBLJLIMJMJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(FHMNGDAOMCN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public IDPEJACMACH FGOEEDCEJNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(IDPEJACMACH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public PLCBKEFBKNB OLEBHHDMPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(PLCBKEFBKNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public HDINJHNHADB NEAFPDBMCNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(HDINJHNHADB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public BODEHNIEHLB ONDNLBPPGPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(BODEHNIEHLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public MBPFEMNNNMI CKGFKJMEHKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(MBPFEMNNNMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool IPJFKILMFNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6CC25E0", Offset = "0x6CC0FE0", VA = "0x186CC25E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool GKDKKMAGJHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6CC24D0", Offset = "0x6CC0ED0", VA = "0x186CC24D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool HNDCJMPIBEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2550", Offset = "0x6CC0F50", VA = "0x186CC2550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private bool DAJOFMNJGMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
	public GKNFJEDFFIC(HNLGJNFDBGG ELHMIJIMOPL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x6CBDD50", Offset = "0x6CBC750", VA = "0x186CBDD50")]
	public static bool PFMAFNCLKDD(GKNFJEDFFIC CLMKDBDPNNH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0xA34E90", Offset = "0xA33890", VA = "0x180A34E90")]
	public static HNLGJNFDBGG PFMAFNCLKDD(GKNFJEDFFIC CLMKDBDPNNH)
	{
		return default(HNLGJNFDBGG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6CBFE80", Offset = "0x6CBE880", VA = "0x186CBFE80")]
	public static bool LBPOCMFLOBH(GKNFJEDFFIC GPKBBMJKBAE, GKNFJEDFFIC AAMOGMLMOOI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2010", Offset = "0x6CC0A10", VA = "0x186CC2010")]
	public static bool CIBBJNPKHCF(GKNFJEDFFIC GPKBBMJKBAE, GKNFJEDFFIC AAMOGMLMOOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6CC22A0", Offset = "0x6CC0CA0", VA = "0x186CC22A0", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(GKNFJEDFFIC AIPFCMFLDKG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0xA34E90", Offset = "0xA33890", VA = "0x180A34E90")]
	public static GKNFJEDFFIC PFMAFNCLKDD(HNLGJNFDBGG HDFPPGPMEIA)
	{
		return default(GKNFJEDFFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2330", Offset = "0x6CC0D30", VA = "0x186CC2330")]
	public FIAGMCIBLJJ FEEOLILODOH()
	{
		return default(FIAGMCIBLJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2450", Offset = "0x6CC0E50", VA = "0x186CC2450")]
	public HNJHPNOBKOM HCMEDMACJEG()
	{
		return default(HNJHPNOBKOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2590", Offset = "0x6CC0F90", VA = "0x186CC2590")]
	public DOFPBNLEGOI MIPAKJHOONF()
	{
		return default(DOFPBNLEGOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6CC24A0", Offset = "0x6CC0EA0", VA = "0x186CC24A0")]
	public BHIBIGDEDJL IDAKFLNHBOO()
	{
		return default(BHIBIGDEDJL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2050", Offset = "0x6CC0A50", VA = "0x186CC2050")]
	public void EAPGNAMLGLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2770", Offset = "0x6CC1170", VA = "0x186CC2770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct FHMNGDAOMCN : IEquatable<FHMNGDAOMCN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public HNLGJNFDBGG HMLBDKHBFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(HNLGJNFDBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private AKFNFIHHCPG NCIIENLBPIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9530", Offset = "0x6CB7F30", VA = "0x186CB9530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private OAFALLIAHBA BHBJEHGAJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6CBE5E0", Offset = "0x6CBCFE0", VA = "0x186CBE5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private MJLCKCBMGKD FOONOIGJOBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6CBE790", Offset = "0x6CBD190", VA = "0x186CBE790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool PMFGOLNLDOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6CBEA40", Offset = "0x6CBD440", VA = "0x186CBEA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Guid NKJEAKGIHDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6CBE4C0", Offset = "0x6CBCEC0", VA = "0x186CBE4C0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool DEKAIPNHFOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x6CBEC80", Offset = "0x6CBD680", VA = "0x186CBEC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Guid POLCABBFFLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6CBEAD0", Offset = "0x6CBD4D0", VA = "0x186CBEAD0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
	public FHMNGDAOMCN(HNLGJNFDBGG ELHMIJIMOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6CBE7F0", Offset = "0x6CBD1F0", VA = "0x186CBE7F0", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(FHMNGDAOMCN AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6CBED10", Offset = "0x6CBD710", VA = "0x186CBED10")]
	public bool PFJJFDAKLFP([Out] Guid OJMCAIBKDOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6CBE670", Offset = "0x6CBD070", VA = "0x186CBE670")]
	public void DOHGOJMADPI(Guid APKMEEHDCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6CBE880", Offset = "0x6CBD280", VA = "0x186CBE880")]
	public bool GIBJADCHBKO([Out] Guid ODLOJKBAHLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6CBE920", Offset = "0x6CBD320", VA = "0x186CBE920")]
	public void KBEBOPBDJCC(Guid APKMEEHDCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6CBEBF0", Offset = "0x6CBD5F0", VA = "0x186CBEBF0")]
	public void NFFIHHILJNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct DOFPBNLEGOI : IEquatable<DOFPBNLEGOI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public HNLGJNFDBGG HMLBDKHBFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(HNLGJNFDBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private AKFNFIHHCPG NCIIENLBPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9530", Offset = "0x6CB7F30", VA = "0x186CB9530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private OAFALLIAHBA BHBJEHGAJEA
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6CBD760", Offset = "0x6CBC160", VA = "0x186CBD760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private MLMNDHFKMLB DIAFLFLEKDC
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6CBDA60", Offset = "0x6CBC460", VA = "0x186CBDA60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public Vector3 FNGDOLMIIGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6CBDAC0", Offset = "0x6CBC4C0", VA = "0x186CBDAC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public Quaternion DJNGEPBNBAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6CBDC10", Offset = "0x6CBC610", VA = "0x186CBDC10")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public GKNFJEDFFIC BMILONDONKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6CBD9D0", Offset = "0x6CBC3D0", VA = "0x186CBD9D0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
	public DOFPBNLEGOI(HNLGJNFDBGG ELHMIJIMOPL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6CBDD50", Offset = "0x6CBC750", VA = "0x186CBDD50")]
	public static bool PFMAFNCLKDD(DOFPBNLEGOI CLMKDBDPNNH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xA34E90", Offset = "0xA33890", VA = "0x180A34E90")]
	public static HNLGJNFDBGG PFMAFNCLKDD(DOFPBNLEGOI CLMKDBDPNNH)
	{
		return default(HNLGJNFDBGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x6CBD940", Offset = "0x6CBC340", VA = "0x186CBD940", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(DOFPBNLEGOI AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6CBD7F0", Offset = "0x6CBC1F0", VA = "0x186CBD7F0")]
	public void EAPCAFACKFP(Vector3 BJDHDJCINFH, Quaternion FJFNLINEAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6CBD650", Offset = "0x6CBC050", VA = "0x186CBD650")]
	public void CGIOOLHJGDB(float ADJNFMJNIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6CBD490", Offset = "0x6CBBE90", VA = "0x186CBD490")]
	public void BKJLCBACGLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct FIAGMCIBLJJ : IEquatable<FIAGMCIBLJJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly FIAGMCIBLJJ GAJKCFIOPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public HNLGJNFDBGG HMLBDKHBFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(HNLGJNFDBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public BOLJHNBDPJH DHHBNJAMIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(BOLJHNBDPJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public IOPBNEOHIPD LIFEFNNCMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(IOPBNEOHIPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private AKFNFIHHCPG NCIIENLBPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9530", Offset = "0x6CB7F30", VA = "0x186CB9530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private OAFALLIAHBA BHBJEHGAJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6CBEFB0", Offset = "0x6CBD9B0", VA = "0x186CBEFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private FJAPLNLLFFB HJJEFEOLNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6CC06F0", Offset = "0x6CBF0F0", VA = "0x186CC06F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public DECONOAHEMJ CEHLHDKLLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6CBEE90", Offset = "0x6CBD890", VA = "0x186CBEE90")]
		get
		{
			return default(DECONOAHEMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public IEnumerable<GKNFJEDFFIC> PCCKPONMFLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x6CBF4E0", Offset = "0x6CBDEE0", VA = "0x186CBF4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public IEnumerable<GKNFJEDFFIC> HBMDPEKPKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6CBF280", Offset = "0x6CBDC80", VA = "0x186CBF280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public int FHEGHFENGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6CC0440", Offset = "0x6CBEE40", VA = "0x186CC0440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public int OCMMJJKJICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x6CBF470", Offset = "0x6CBDE70", VA = "0x186CBF470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public string IAIAEPAKLMP
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6CBFE90", Offset = "0x6CBE890", VA = "0x186CBFE90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6CC0390", Offset = "0x6CBED90", VA = "0x186CC0390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public LMMONNPEHEM MDJMMCOLFCA
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6CBFDB0", Offset = "0x6CBE7B0", VA = "0x186CBFDB0")]
		get
		{
			return default(LMMONNPEHEM);
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x6CBFE10", Offset = "0x6CBE810", VA = "0x186CBFE10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public NGOGJPFGOHI GIOJNGCMFDO
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x6CBFCE0", Offset = "0x6CBE6E0", VA = "0x186CBFCE0")]
		get
		{
			return default(NGOGJPFGOHI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x6CBFFB0", Offset = "0x6CBE9B0", VA = "0x186CBFFB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public EKCKEFPLHMO HBNEKGIKBJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x6CBEF50", Offset = "0x6CBD950", VA = "0x186CBEF50")]
		get
		{
			return default(EKCKEFPLHMO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6CBF040", Offset = "0x6CBDA40", VA = "0x186CBF040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public float DNMGKHGLHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6CBF120", Offset = "0x6CBDB20", VA = "0x186CBF120")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6CBF640", Offset = "0x6CBE040", VA = "0x186CBF640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool MPFNKFKAEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x6CBF0B0", Offset = "0x6CBDAB0", VA = "0x186CBF0B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool KGCIPCDFMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6CBF180", Offset = "0x6CBDB80", VA = "0x186CBF180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool AMCMFNHJLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6CBFC70", Offset = "0x6CBE670", VA = "0x186CBFC70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool AFDLMIJDENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6CC04D0", Offset = "0x6CBEED0", VA = "0x186CC04D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool BFDGEJJPBPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6CBEE30", Offset = "0x6CBD830", VA = "0x186CBEE30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6CBFF40", Offset = "0x6CBE940", VA = "0x186CBFF40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool PDEOEDDCOAN
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6CBF410", Offset = "0x6CBDE10", VA = "0x186CBF410")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6CBFD40", Offset = "0x6CBE740", VA = "0x186CBFD40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
	public FIAGMCIBLJJ(HNLGJNFDBGG ELHMIJIMOPL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6CBDD50", Offset = "0x6CBC750", VA = "0x186CBDD50")]
	public static bool PFMAFNCLKDD(FIAGMCIBLJJ CLMKDBDPNNH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6CBFE80", Offset = "0x6CBE880", VA = "0x186CBFE80")]
	public static bool LBPOCMFLOBH(FIAGMCIBLJJ GPKBBMJKBAE, FIAGMCIBLJJ AAMOGMLMOOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6CBF1F0", Offset = "0x6CBDBF0", VA = "0x186CBF1F0", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(FIAGMCIBLJJ AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xA34E90", Offset = "0xA33890", VA = "0x180A34E90")]
	public static GKNFJEDFFIC PFMAFNCLKDD(FIAGMCIBLJJ PECHDAFMNOO)
	{
		return default(GKNFJEDFFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6CBF4C0", Offset = "0x6CBDEC0", VA = "0x186CBF4C0")]
	public bool HEHFBNLOGKM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6CBF3A0", Offset = "0x6CBDDA0", VA = "0x186CBF3A0")]
	public bool GOONKKEMLEF(NKIDGEMOIMN DBFJEMPBGIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6CBEDB0", Offset = "0x6CBD7B0", VA = "0x186CBEDB0")]
	public void ACCOKFMFONP(NKIDGEMOIMN DBFJEMPBGIP, bool CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0540", Offset = "0x6CBEF40", VA = "0x186CC0540")]
	public DECONOAHEMJ PDNLLBHBGPO(Allocator MDICAPEDFAK)
	{
		return default(DECONOAHEMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0020", Offset = "0x6CBEA20", VA = "0x186CC0020")]
	public void MGILKCDJKNH(FIAGMCIBLJJ AIPFCMFLDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6CBF6B0", Offset = "0x6CBE0B0", VA = "0x186CBF6B0")]
	public void ICIFHAKHBBI(List<GKNFJEDFFIC> FKDPICIBJEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct DOPEFFDGIFJ : IEquatable<DOPEFFDGIFJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6CBDE50", Offset = "0x6CBC850", VA = "0x186CBDE50", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(DOPEFFDGIFJ AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct IEKBPHDEOPH : IEquatable<IEKBPHDEOPH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private AKFNFIHHCPG NCIIENLBPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9530", Offset = "0x6CB7F30", VA = "0x186CB9530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
	public IEKBPHDEOPH(HNLGJNFDBGG ELHMIJIMOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7110", Offset = "0x6CC5B10", VA = "0x186CC7110", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(IEKBPHDEOPH AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7070", Offset = "0x6CC5A70", VA = "0x186CC7070")]
	public void EPGEGEJNIJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6CC6FD0", Offset = "0x6CC59D0", VA = "0x186CC6FD0")]
	public void AALDKOBLPAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6CC71A0", Offset = "0x6CC5BA0", VA = "0x186CC71A0")]
	public bool FCIBBGIEOKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct IOPBNEOHIPD : IEquatable<IOPBNEOHIPD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public HNLGJNFDBGG HMLBDKHBFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(HNLGJNFDBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	private AKFNFIHHCPG NCIIENLBPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9530", Offset = "0x6CB7F30", VA = "0x186CB9530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private OAFALLIAHBA BHBJEHGAJEA
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6CC72E0", Offset = "0x6CC5CE0", VA = "0x186CC72E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private FJAPLNLLFFB HJJEFEOLNJG
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6CC7C20", Offset = "0x6CC6620", VA = "0x186CC7C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public HNLGJNFDBGG CKBOBALMNEP
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x6CC7900", Offset = "0x6CC6300", VA = "0x186CC7900")]
		get
		{
			return default(HNLGJNFDBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public GKNFJEDFFIC GCDGMCMKOIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6CC7400", Offset = "0x6CC5E00", VA = "0x186CC7400")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public GKNFJEDFFIC AAHAADHCHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6CC75C0", Offset = "0x6CC5FC0", VA = "0x186CC75C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
	public IOPBNEOHIPD(HNLGJNFDBGG ELHMIJIMOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7370", Offset = "0x6CC5D70", VA = "0x186CC7370", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(IOPBNEOHIPD AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7490", Offset = "0x6CC5E90", VA = "0x186CC7490")]
	public bool FPIHKLEMIHN(GKNFJEDFFIC DLPGBMPJIIG, bool ELMCOJBCBOA = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7650", Offset = "0x6CC6050", VA = "0x186CC7650")]
	public bool JDFADGKCGJG(GKNFJEDFFIC BHNMAGJIIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7990", Offset = "0x6CC6390", VA = "0x186CC7990")]
	private void OLNDCMAMDGG(GKNFJEDFFIC CICINMLBAOL, List<GKNFJEDFFIC> BICFFOHBMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7750", Offset = "0x6CC6150", VA = "0x186CC7750")]
	public FIAGMCIBLJJ MGAPCOFOHCO()
	{
		return default(FIAGMCIBLJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6CC76F0", Offset = "0x6CC60F0", VA = "0x186CC76F0")]
	public void MBCIAGLDFGF(List<GKNFJEDFFIC> JKEKAJPGPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6CC77E0", Offset = "0x6CC61E0", VA = "0x186CC77E0")]
	public NativeArray<HNLGJNFDBGG> NGDOMDMOJKF()
	{
		return default(NativeArray<HNLGJNFDBGG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct NJAEJEHFLNH : IEquatable<NJAEJEHFLNH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public string FMLDLBGKEMP
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6CC9170", Offset = "0x6CC7B70", VA = "0x186CC9170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public string MGGCPAIGJHN
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6CC8AB0", Offset = "0x6CC74B0", VA = "0x186CC8AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool JAJHFJJIELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6CC8B70", Offset = "0x6CC7570", VA = "0x186CC8B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public string EHCGBBCDFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6CC8F90", Offset = "0x6CC7990", VA = "0x186CC8F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public string HKJGKNNHFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6CC8D40", Offset = "0x6CC7740", VA = "0x186CC8D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public string LIFNEJGHJPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6CC9080", Offset = "0x6CC7A80", VA = "0x186CC9080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
	public NJAEJEHFLNH(HNLGJNFDBGG ELHMIJIMOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6CC8CB0", Offset = "0x6CC76B0", VA = "0x186CC8CB0", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(NJAEJEHFLNH AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct BODEHNIEHLB : IEquatable<BODEHNIEHLB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private AKFNFIHHCPG NCIIENLBPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9530", Offset = "0x6CB7F30", VA = "0x186CB9530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private OAFALLIAHBA BHBJEHGAJEA
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6CB8E30", Offset = "0x6CB7830", VA = "0x186CB8E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	private FAGOKNOGCAI AIJLOFIPOFA
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6CB8D40", Offset = "0x6CB7740", VA = "0x186CB8D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public GALKGBKEIBI DOGEIHGACEL
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9620", Offset = "0x6CB8020", VA = "0x186CB9620")]
		get
		{
			return default(GALKGBKEIBI);
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6CB8EC0", Offset = "0x6CB78C0", VA = "0x186CB8EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public bool DMPCLCGODIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6CB8DA0", Offset = "0x6CB77A0", VA = "0x186CB8DA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9240", Offset = "0x6CB7C40", VA = "0x186CB9240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public string[] FNNGECMDBMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9590", Offset = "0x6CB7F90", VA = "0x186CB9590")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9720", Offset = "0x6CB8120", VA = "0x186CB9720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public string[] EFNIGDDMNHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9380", Offset = "0x6CB7D80", VA = "0x186CB9380")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6CB92E0", Offset = "0x6CB7CE0", VA = "0x186CB92E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public string[] IMOIECKADEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6CB94A0", Offset = "0x6CB7EA0", VA = "0x186CB94A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6CB8FD0", Offset = "0x6CB79D0", VA = "0x186CB8FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public string[] LCBHNKABIOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9410", Offset = "0x6CB7E10", VA = "0x186CB9410")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9070", Offset = "0x6CB7A70", VA = "0x186CB9070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
	public BODEHNIEHLB(HNLGJNFDBGG ELHMIJIMOPL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0xA34E90", Offset = "0xA33890", VA = "0x180A34E90")]
	public static HNLGJNFDBGG PFMAFNCLKDD(BODEHNIEHLB CLMKDBDPNNH)
	{
		return default(HNLGJNFDBGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9110", Offset = "0x6CB7B10", VA = "0x186CB9110", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(BODEHNIEHLB AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6CB91A0", Offset = "0x6CB7BA0", VA = "0x186CB91A0")]
	public bool FJMFOACMBCM(HNLGJNFDBGG JGEPDBLHLJG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct OFALJKEEJEK : IEquatable<OFALJKEEJEK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6CC9F40", Offset = "0x6CC8940", VA = "0x186CC9F40", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(OFALJKEEJEK AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct NBDKNDEBOBH : IEquatable<NBDKNDEBOBH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
	public NBDKNDEBOBH(HNLGJNFDBGG ELHMIJIMOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6CC8350", Offset = "0x6CC6D50", VA = "0x186CC8350", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(NBDKNDEBOBH AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6CC83E0", Offset = "0x6CC6DE0", VA = "0x186CC83E0")]
	public bool KPIGECHIHAG([Out] Collider IHHPCPOLGKB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct BHIBIGDEDJL : IEquatable<BHIBIGDEDJL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public HNLGJNFDBGG HMLBDKHBFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(HNLGJNFDBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private MakerPenHeldDataWrapper NCLPBGKFLII
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x6CB8BE0", Offset = "0x6CB75E0", VA = "0x186CB8BE0")]
		get
		{
			return default(MakerPenHeldDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public bool EKLNBAKJNCP
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x6CB8CD0", Offset = "0x6CB76D0", VA = "0x186CB8CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
	public BHIBIGDEDJL(HNLGJNFDBGG ELHMIJIMOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8C40", Offset = "0x6CB7640", VA = "0x186CB8C40", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(BHIBIGDEDJL AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct PLCBKEFBKNB : IEquatable<PLCBKEFBKNB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public HNLGJNFDBGG HMLBDKHBFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(HNLGJNFDBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	private AKFNFIHHCPG NCIIENLBPIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9530", Offset = "0x6CB7F30", VA = "0x186CB9530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private OAFALLIAHBA BHBJEHGAJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6CCB290", Offset = "0x6CC9C90", VA = "0x186CCB290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	private LNHAPBFKEAD KEODBLMADOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6CCB3B0", Offset = "0x6CC9DB0", VA = "0x186CCB3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
	public PLCBKEFBKNB(HNLGJNFDBGG ELHMIJIMOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6CCB320", Offset = "0x6CC9D20", VA = "0x186CCB320", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(PLCBKEFBKNB AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6CCB410", Offset = "0x6CC9E10", VA = "0x186CCB410")]
	public void POBCEEBNCON(bool KJEFBADCIFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct OLIEDPFEEDD : IEquatable<OLIEDPFEEDD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public HNLGJNFDBGG HMLBDKHBFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(HNLGJNFDBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private AKFNFIHHCPG NCIIENLBPIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9530", Offset = "0x6CB7F30", VA = "0x186CB9530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	private OAFALLIAHBA BHBJEHGAJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x6CCA6B0", Offset = "0x6CC90B0", VA = "0x186CCA6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private ObjectPolicyDataWrapper HIHBNOKDBNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x6CCA9D0", Offset = "0x6CC93D0", VA = "0x186CCA9D0")]
		get
		{
			return default(ObjectPolicyDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private NavMeshGenerationDataWrapper HMFEPPHCFBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x6CCA910", Offset = "0x6CC9310", VA = "0x186CCA910")]
		get
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool HPEKHLPOBOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x6CCAB10", Offset = "0x6CC9510", VA = "0x186CCAB10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool OGJDAMJKEHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x6CCAC30", Offset = "0x6CC9630", VA = "0x186CCAC30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool MHFCGKAEECN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x6CCA810", Offset = "0x6CC9210", VA = "0x186CCA810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool MCEIKGCHGNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x6CCAE50", Offset = "0x6CC9850", VA = "0x186CCAE50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool BFFJJNLMHHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6CCAD80", Offset = "0x6CC9780", VA = "0x186CCAD80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public bool IJMNEBOKIIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x6CCACA0", Offset = "0x6CC96A0", VA = "0x186CCACA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public bool DODEFDCOHKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x6CCA370", Offset = "0x6CC8D70", VA = "0x186CCA370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public bool CKOGEEPHBJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x6CCAD10", Offset = "0x6CC9710", VA = "0x186CCAD10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public bool ADBGCLNHLMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x6CCA740", Offset = "0x6CC9140", VA = "0x186CCA740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public bool HMNFKIFDKFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x6CCAB50", Offset = "0x6CC9550", VA = "0x186CCAB50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool GEDBMDAJNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x6CCAA30", Offset = "0x6CC9430", VA = "0x186CCAA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool ECPEMKHIKGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6CCAAA0", Offset = "0x6CC94A0", VA = "0x186CCAAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool DDPFPFJGBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6CCB060", Offset = "0x6CC9A60", VA = "0x186CCB060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool JLGLGJKPEKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6CCA3E0", Offset = "0x6CC8DE0", VA = "0x186CCA3E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6CCAEC0", Offset = "0x6CC98C0", VA = "0x186CCAEC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public ABIAGIAFKIE MNMPFIAAFCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6CCA7B0", Offset = "0x6CC91B0", VA = "0x186CCA7B0")]
		get
		{
			return default(ABIAGIAFKIE);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x6CCA4B0", Offset = "0x6CC8EB0", VA = "0x186CCA4B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool IFAEKAGGOON
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x6CCB0C0", Offset = "0x6CC9AC0", VA = "0x186CCB0C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public JMCAKEIMOJI OCAPKAFIBJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6CCA650", Offset = "0x6CC9050", VA = "0x186CCA650")]
		get
		{
			return default(JMCAKEIMOJI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool GEIBEBMAAKF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6CCADF0", Offset = "0x6CC97F0", VA = "0x186CCADF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Vector3 HKBMOGJLDEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6CCA520", Offset = "0x6CC8F20", VA = "0x186CCA520")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Vector3 AFGGGJKOOPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6CCAF30", Offset = "0x6CC9930", VA = "0x186CCAF30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public bool LDHIDBEEAAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6CCA270", Offset = "0x6CC8C70", VA = "0x186CCA270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
	public OLIEDPFEEDD(HNLGJNFDBGG ELHMIJIMOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6CCA880", Offset = "0x6CC9280", VA = "0x186CCA880", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(OLIEDPFEEDD AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x6CCA440", Offset = "0x6CC8E40", VA = "0x186CCA440")]
	public bool ANBLJLLOHPD(GEIJDOFEBPF DBFJEMPBGIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x6CCA5E0", Offset = "0x6CC8FE0", VA = "0x186CCA5E0")]
	public bool CCNDGJILHND(GJPPNGCHFKK DBFJEMPBGIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x6CCAFE0", Offset = "0x6CC99E0", VA = "0x186CCAFE0")]
	public void OHMIJIJMLAB(GJPPNGCHFKK DBFJEMPBGIP, bool CIPDEENNFMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6CCA970", Offset = "0x6CC9370", VA = "0x186CCA970")]
	public GJPPNGCHFKK FBPBHFNMCMB()
	{
		return default(GJPPNGCHFKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6CCABC0", Offset = "0x6CC95C0", VA = "0x186CCABC0")]
	public bool JAPBEODMNJD(GJPPNGCHFKK CLMKDBDPNNH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct HDINJHNHADB : IEquatable<HDINJHNHADB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private AKFNFIHHCPG NCIIENLBPIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9530", Offset = "0x6CB7F30", VA = "0x186CB9530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private OAFALLIAHBA BHBJEHGAJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2EE0", Offset = "0x6CC18E0", VA = "0x186CC2EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	private PBPBCNCHGGP GJKLAKPNCDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x6CC3530", Offset = "0x6CC1F30", VA = "0x186CC3530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
	public HDINJHNHADB(HNLGJNFDBGG ELHMIJIMOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2F70", Offset = "0x6CC1970", VA = "0x186CC2F70", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(HDINJHNHADB AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2DB0", Offset = "0x6CC17B0", VA = "0x186CC2DB0")]
	public bool BPJIPNPCDPE(GKIIHAFLNOK OIKBGDLAKHG, List<GKNFJEDFFIC> FKDPICIBJEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2CA0", Offset = "0x6CC16A0", VA = "0x186CC2CA0")]
	public int BEMDODGLMOK(GKIIHAFLNOK OIKBGDLAKHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x6CC3420", Offset = "0x6CC1E20", VA = "0x186CC3420")]
	public void LJGPGDDKNHA(List<GKNFJEDFFIC> FKDPICIBJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6CC3000", Offset = "0x6CC1A00", VA = "0x186CC3000")]
	public int FKEKIHAMDBP(GKNFJEDFFIC IPOCAIFIKHJ, GKIIHAFLNOK OIKBGDLAKHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2A60", Offset = "0x6CC1460", VA = "0x186CC2A60")]
	public GKNFJEDFFIC AGAKHJHCLCH(int EBDDHAPIAHH, GKIIHAFLNOK OIKBGDLAKHG)
	{
		return default(GKNFJEDFFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6CC31E0", Offset = "0x6CC1BE0", VA = "0x186CC31E0")]
	public void HEGCMGKCBHB(GKNFJEDFFIC IPOCAIFIKHJ, GKIIHAFLNOK OIKBGDLAKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6CC3130", Offset = "0x6CC1B30", VA = "0x186CC3130")]
	public bool FLDMBOKKGJK(GKNFJEDFFIC IPOCAIFIKHJ, GKIIHAFLNOK OIKBGDLAKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2B90", Offset = "0x6CC1590", VA = "0x186CC2B90")]
	public void ALOEILANFPB(GKIIHAFLNOK OIKBGDLAKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6CC3590", Offset = "0x6CC1F90", VA = "0x186CC3590")]
	public bool PFPGDIOIMDN(GKNFJEDFFIC IPOCAIFIKHJ, GKIIHAFLNOK OIKBGDLAKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6CC3310", Offset = "0x6CC1D10", VA = "0x186CC3310")]
	public bool HKIIAIGIJGG(GKIIHAFLNOK OIKBGDLAKHG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public readonly struct OJJFJEICHDD : IEquatable<OJJFJEICHDD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public HNLGJNFDBGG HMLBDKHBFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(HNLGJNFDBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private AKFNFIHHCPG NCIIENLBPIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9530", Offset = "0x6CB7F30", VA = "0x186CB9530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private OAFALLIAHBA BHBJEHGAJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6CCA060", Offset = "0x6CC8A60", VA = "0x186CCA060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
	public OJJFJEICHDD(HNLGJNFDBGG ELHMIJIMOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6CCA0F0", Offset = "0x6CC8AF0", VA = "0x186CCA0F0", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(OJJFJEICHDD AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x6CC9FD0", Offset = "0x6CC89D0", VA = "0x186CC9FD0")]
	public void BJDMJEMEOMJ(bool CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6CCA180", Offset = "0x6CC8B80", VA = "0x186CCA180")]
	public void ILELCPGAKBC(bool CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x2E164F0", Offset = "0x2E14EF0", VA = "0x182E164F0")]
	public T DAHGJLPAAGO<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct MBPFEMNNNMI : IEquatable<MBPFEMNNNMI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public HNLGJNFDBGG HMLBDKHBFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(HNLGJNFDBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	private AKFNFIHHCPG NCIIENLBPIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9530", Offset = "0x6CB7F30", VA = "0x186CB9530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private OAFALLIAHBA BHBJEHGAJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x6CC7F30", Offset = "0x6CC6930", VA = "0x186CC7F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private DBBIFKLCCJB KBENIDIJDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6CC7FC0", Offset = "0x6CC69C0", VA = "0x186CC7FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public bool EBAOBCEAEIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x6CC80B0", Offset = "0x6CC6AB0", VA = "0x186CC80B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public bool HGJJHACNHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x6CC7EA0", Offset = "0x6CC68A0", VA = "0x186CC7EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
	public MBPFEMNNNMI(HNLGJNFDBGG ELHMIJIMOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6CC8020", Offset = "0x6CC6A20", VA = "0x186CC8020", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(MBPFEMNNNMI AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct BFLBOAIJCKF : IEquatable<BFLBOAIJCKF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B00", Offset = "0x6CB7500", VA = "0x186CB8B00", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(BFLBOAIJCKF AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct ODIPHPPBKFO : IEquatable<ODIPHPPBKFO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public HNLGJNFDBGG HMLBDKHBFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(HNLGJNFDBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private AKFNFIHHCPG NCIIENLBPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9530", Offset = "0x6CB7F30", VA = "0x186CB9530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private OAFALLIAHBA BHBJEHGAJEA
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x6CC9310", Offset = "0x6CC7D10", VA = "0x186CC9310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private CEPFICOCOAG IFNGMMAFDKM
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6CC92B0", Offset = "0x6CC7CB0", VA = "0x186CC92B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private OIAIHOFHKBH CCMNOBPDLDN
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x6CC9EE0", Offset = "0x6CC88E0", VA = "0x186CC9EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool HBJOPJEBOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x6CC9500", Offset = "0x6CC7F00", VA = "0x186CC9500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool IFDNPMDKJJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x6CC9E40", Offset = "0x6CC8840", VA = "0x186CC9E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool OKPCNNINKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x6CC9440", Offset = "0x6CC7E40", VA = "0x186CC9440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool DFAMGHEKKNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x6CC96C0", Offset = "0x6CC80C0", VA = "0x186CC96C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool CGANAGFAAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x6CC9280", Offset = "0x6CC7C80", VA = "0x186CC9280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool BIKCCFHNAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x6CC9590", Offset = "0x6CC7F90", VA = "0x186CC9590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool IJBHKMODIJN
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6CC9AB0", Offset = "0x6CC84B0", VA = "0x186CC9AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public bool DLPJEPIAGDD
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x6CC9940", Offset = "0x6CC8340", VA = "0x186CC9940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
	public ODIPHPPBKFO(HNLGJNFDBGG ELHMIJIMOPL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6CBDD50", Offset = "0x6CBC750", VA = "0x186CBDD50")]
	public static bool PFMAFNCLKDD(ODIPHPPBKFO CLMKDBDPNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6CC9470", Offset = "0x6CC7E70", VA = "0x186CC9470", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(ODIPHPPBKFO AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6CC9DD0", Offset = "0x6CC87D0", VA = "0x186CC9DD0")]
	public bool OJPBGIICGHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x6CC93A0", Offset = "0x6CC7DA0", VA = "0x186CC93A0")]
	public GKNFJEDFFIC CPBIHDFPOGJ(GKNFJEDFFIC IPOCAIFIKHJ)
	{
		return default(GKNFJEDFFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x6CC9CC0", Offset = "0x6CC86C0", VA = "0x186CC9CC0")]
	public HNLGJNFDBGG NIELHKEMALM()
	{
		return default(HNLGJNFDBGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x6CC9620", Offset = "0x6CC8020", VA = "0x186CC9620")]
	public bool GNCHHACPJMM(HNLGJNFDBGG GFMIMGGHPIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6CC98A0", Offset = "0x6CC82A0", VA = "0x186CC98A0")]
	public bool KGNPGLBFOJN(HNLGJNFDBGG KDPEHCJFACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x6CC9790", Offset = "0x6CC8190", VA = "0x186CC9790")]
	public bool JKADLGCOHGH(HNLGJNFDBGG IPOCAIFIKHJ, [Out] HNLGJNFDBGG GFMIMGGHPIJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct HNJHPNOBKOM : IEquatable<HNJHPNOBKOM>
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly HNJHPNOBKOM GAJKCFIOPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public HNLGJNFDBGG HMLBDKHBFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(HNLGJNFDBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public BOLJHNBDPJH DHHBNJAMIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(BOLJHNBDPJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public IOPBNEOHIPD LIFEFNNCMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(IOPBNEOHIPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private ShapeTypeDataWrapper KECOEAHLMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x6CC4C00", Offset = "0x6CC3600", VA = "0x186CC4C00")]
		get
		{
			return default(ShapeTypeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public StandardRenderableVisualDataWrapper KLKKGFCGFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x6CC53B0", Offset = "0x6CC3DB0", VA = "0x186CC53B0")]
		get
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public PhysicsMaterialDataWrapper LBJMFOBOBOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x6CC5410", Offset = "0x6CC3E10", VA = "0x186CC5410")]
		get
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public ShapeConfigDataWrapper BKIKKDBJDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x6CC52B0", Offset = "0x6CC3CB0", VA = "0x186CC52B0")]
		get
		{
			return default(ShapeConfigDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public NDDPHCNKJGA HIFPHGEPFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x6CC5240", Offset = "0x6CC3C40", VA = "0x186CC5240")]
		get
		{
			return default(NDDPHCNKJGA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public CAHACMGAPPM OAKOGEMAGKP
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x6CC4F80", Offset = "0x6CC3980", VA = "0x186CC4F80")]
		get
		{
			return default(CAHACMGAPPM);
		}
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x6CC4CC0", Offset = "0x6CC36C0", VA = "0x186CC4CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public ICPNPPMHPOE CKDAEMELGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x6CC4C60", Offset = "0x6CC3660", VA = "0x186CC4C60")]
		get
		{
			return default(ICPNPPMHPOE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x6CC4E80", Offset = "0x6CC3880", VA = "0x186CC4E80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public float BACHGBJFIGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x6CC4FE0", Offset = "0x6CC39E0", VA = "0x186CC4FE0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x6CC4DB0", Offset = "0x6CC37B0", VA = "0x186CC4DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public Vector3 OPFODFLLAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x6CC50C0", Offset = "0x6CC3AC0", VA = "0x186CC50C0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x6CC5310", Offset = "0x6CC3D10", VA = "0x186CC5310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float FILOIGPNLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x6CC51D0", Offset = "0x6CC3BD0", VA = "0x186CC51D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public MAFMGBEJBCE ENNCOHAJFFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x6CC4E20", Offset = "0x6CC3820", VA = "0x186CC4E20")]
		get
		{
			return default(MAFMGBEJBCE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x6CC5160", Offset = "0x6CC3B60", VA = "0x186CC5160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
	public HNJHPNOBKOM(HNLGJNFDBGG ELHMIJIMOPL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x6CBDD50", Offset = "0x6CBC750", VA = "0x186CBDD50")]
	public static bool PFMAFNCLKDD(HNJHPNOBKOM CLMKDBDPNNH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2010", Offset = "0x6CC0A10", VA = "0x186CC2010")]
	public static bool CIBBJNPKHCF(HNJHPNOBKOM GPKBBMJKBAE, HNJHPNOBKOM AAMOGMLMOOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x6CC4EF0", Offset = "0x6CC38F0", VA = "0x186CC4EF0", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(HNJHPNOBKOM AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x6CC4D30", Offset = "0x6CC3730", VA = "0x186CC4D30")]
	public EOAIEFEDHHH BOEMHKKGGNE()
	{
		return default(EOAIEFEDHHH);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x6CC5040", Offset = "0x6CC3A40", VA = "0x186CC5040")]
	public HFCIPGCEECH JCNPIIOANCG()
	{
		return default(HFCIPGCEECH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct EOAIEFEDHHH : IEquatable<EOAIEFEDHHH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public HNLGJNFDBGG HMLBDKHBFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(HNLGJNFDBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public HNJHPNOBKOM EIIBNJFANMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(HNJHPNOBKOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private PrimitiveShapeDataWrapper EBBMMLLMFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6CBE120", Offset = "0x6CBCB20", VA = "0x186CBE120")]
		get
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public KHHCEDFJMMM LHHCODBJGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x6CBE0C0", Offset = "0x6CBCAC0", VA = "0x186CBE0C0")]
		get
		{
			return default(KHHCEDFJMMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
	public EOAIEFEDHHH(HNLGJNFDBGG ELHMIJIMOPL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x6CBDD50", Offset = "0x6CBC750", VA = "0x186CBDD50")]
	public static bool PFMAFNCLKDD(EOAIEFEDHHH CLMKDBDPNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x6CBE030", Offset = "0x6CBCA30", VA = "0x186CBE030", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(EOAIEFEDHHH AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DefaultMember("Item")]
public readonly struct HFCIPGCEECH : IEquatable<HFCIPGCEECH>
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public static readonly HFCIPGCEECH GAJKCFIOPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public HNLGJNFDBGG HMLBDKHBFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(HNLGJNFDBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public BOLJHNBDPJH DHHBNJAMIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(BOLJHNBDPJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private AKFNFIHHCPG NCIIENLBPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9530", Offset = "0x6CB7F30", VA = "0x186CB9530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	private OAFALLIAHBA BHBJEHGAJEA
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x6CC3850", Offset = "0x6CC2250", VA = "0x186CC3850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	private KEMLCCGHOGN DFCAFELHIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x6CC37F0", Offset = "0x6CC21F0", VA = "0x186CC37F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public HNJHPNOBKOM EIIBNJFANMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(HNJHPNOBKOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public EPIBLGLJFNJ GBLKDLLFMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x6CC40F0", Offset = "0x6CC2AF0", VA = "0x186CC40F0")]
		get
		{
			return default(EPIBLGLJFNJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x6CC3FD0", Offset = "0x6CC29D0", VA = "0x186CC3FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public IEnumerable<FJIPFJKJJGF> EIBDOFGCPCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x6CC3B10", Offset = "0x6CC2510", VA = "0x186CC3B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public FJIPFJKJJGF MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x6CC38E0", Offset = "0x6CC22E0", VA = "0x186CC38E0")]
		get
		{
			return default(FJIPFJKJJGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public int FPAPEBLAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x6CC3A80", Offset = "0x6CC2480", VA = "0x186CC3A80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
	public HFCIPGCEECH(HNLGJNFDBGG ELHMIJIMOPL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x6CBDD50", Offset = "0x6CBC750", VA = "0x186CBDD50")]
	public static bool PFMAFNCLKDD(HFCIPGCEECH CLMKDBDPNNH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x6CBFE80", Offset = "0x6CBE880", VA = "0x186CBFE80")]
	public static bool LBPOCMFLOBH(HFCIPGCEECH GPKBBMJKBAE, HFCIPGCEECH AAMOGMLMOOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x6CC39F0", Offset = "0x6CC23F0", VA = "0x186CC39F0", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(HFCIPGCEECH AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x6CC3DB0", Offset = "0x6CC27B0", VA = "0x186CC3DB0")]
	public FJIPFJKJJGF GMIIOGCKDPD(float3? BJDHDJCINFH, [Optional] quaternion? FJFNLINEAKI, [Optional] Vector3? ADJNFMJNIAA)
	{
		return default(FJIPFJKJJGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x6CC42B0", Offset = "0x6CC2CB0", VA = "0x186CC42B0")]
	public FJIPFJKJJGF PBIBDHLCBJE(int EBDDHAPIAHH, float3? BJDHDJCINFH, [Optional] quaternion? FJFNLINEAKI, [Optional] Vector3? ADJNFMJNIAA)
	{
		return default(FJIPFJKJJGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x6CC3D10", Offset = "0x6CC2710", VA = "0x186CC3D10")]
	public void GFOJIDBFMJC(int EBDDHAPIAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x6CC4220", Offset = "0x6CC2C20", VA = "0x186CC4220")]
	public void IMAFILHGCCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct FJIPFJKJJGF : IEquatable<FJIPFJKJJGF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public HNLGJNFDBGG HMLBDKHBFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(HNLGJNFDBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public HFCIPGCEECH GIKIPNHNDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x6CC0A90", Offset = "0x6CBF490", VA = "0x186CC0A90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public float3 MHEDOFLPKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x6CC0750", Offset = "0x6CBF150", VA = "0x186CC0750")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x6CC0CD0", Offset = "0x6CBF6D0", VA = "0x186CC0CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public quaternion MGLMKDCNIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6CC08B0", Offset = "0x6CBF2B0", VA = "0x186CC08B0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x6CC0B20", Offset = "0x6CBF520", VA = "0x186CC0B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public float3 KIIDGAABMEL
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x6CC07D0", Offset = "0x6CBF1D0", VA = "0x186CC07D0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x6CC0B90", Offset = "0x6CBF590", VA = "0x186CC0B90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public INOIPDKKFGO EECGOCCOIFM
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x6CC0A20", Offset = "0x6CBF420", VA = "0x186CC0A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	private SplinePointParentDataWrapper KHOIJCNICEH
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x6CC0C10", Offset = "0x6CBF610", VA = "0x186CC0C10")]
		get
		{
			return default(SplinePointParentDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	private SplinePointPositionDataWrapper JNBDFBILJNI
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x6CC0930", Offset = "0x6CBF330", VA = "0x186CC0930")]
		get
		{
			return default(SplinePointPositionDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	private SplinePointRotationDataWrapper NLCLFMPIBHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6CC0850", Offset = "0x6CBF250", VA = "0x186CC0850")]
		get
		{
			return default(SplinePointRotationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	private SplinePointScaleDataWrapper NCNNBBMOGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x6CC0C70", Offset = "0x6CBF670", VA = "0x186CC0C70")]
		get
		{
			return default(SplinePointScaleDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	private SplinePointOrderDataWrapper KKAAKHPHCIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x6CC0D50", Offset = "0x6CBF750", VA = "0x186CC0D50")]
		get
		{
			return default(SplinePointOrderDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
	public FJIPFJKJJGF(HNLGJNFDBGG ELHMIJIMOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0990", Offset = "0x6CBF390", VA = "0x186CC0990", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(FJIPFJKJJGF AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0A90", Offset = "0x6CBF490", VA = "0x186CC0A90")]
	public void LCPCGGPLNBN(HFCIPGCEECH CLMKDBDPNNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct IDPEJACMACH : IEquatable<IDPEJACMACH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public HNLGJNFDBGG HMLBDKHBFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(HNLGJNFDBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private AKFNFIHHCPG NCIIENLBPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9530", Offset = "0x6CB7F30", VA = "0x186CB9530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private OAFALLIAHBA BHBJEHGAJEA
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x6CC6270", Offset = "0x6CC4C70", VA = "0x186CC6270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	private DMOFABMJHHG BLDCGCJGLKN
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6CC6A40", Offset = "0x6CC5440", VA = "0x186CC6A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	private ToolCleanupSettingsDataWrapper CIJLNPCGBGK
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x6CC64D0", Offset = "0x6CC4ED0", VA = "0x186CC64D0")]
		get
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool EOONNMPCMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x6CC6530", Offset = "0x6CC4F30", VA = "0x186CC6530")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x6CC6300", Offset = "0x6CC4D00", VA = "0x186CC6300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public bool NEPPAMHJFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x6CC66C0", Offset = "0x6CC50C0", VA = "0x186CC66C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6CC6400", Offset = "0x6CC4E00", VA = "0x186CC6400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public float EGJLEFAKPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x6CC6470", Offset = "0x6CC4E70", VA = "0x186CC6470")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x6CC60F0", Offset = "0x6CC4AF0", VA = "0x186CC60F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public bool IGMEMCGOEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x6CC6AA0", Offset = "0x6CC54A0", VA = "0x186CC6AA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
	public IDPEJACMACH(HNLGJNFDBGG ELHMIJIMOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x6CC6370", Offset = "0x6CC4D70", VA = "0x186CC6370", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(IDPEJACMACH AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x6CC6B40", Offset = "0x6CC5540", VA = "0x186CC6B40")]
	public void OHJGFLNFNEM(int OMFPMCIAPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x6CC6160", Offset = "0x6CC4B60", VA = "0x186CC6160")]
	public bool CBHGIGDIHBL([Out] int OMFPMCIAPMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x6CC6850", Offset = "0x6CC5250", VA = "0x186CC6850")]
	public void NCCIDOPIKLJ(bool PJABBMAGKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x6CC5FA0", Offset = "0x6CC49A0", VA = "0x186CC5FA0")]
	public void AKBEPJNHFDI(float IGNJJPJEPIM, float MBMCHPPKBKG, float ABLDFPIGKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x6CC68F0", Offset = "0x6CC52F0", VA = "0x186CC68F0")]
	public void NCPCAIKAFBF(float3 KMIEEIGGKAL, quaternion KNBHNOGKKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x6CC6590", Offset = "0x6CC4F90", VA = "0x186CC6590")]
	public bool INEBGBGNKPL([Out] float3 KMIEEIGGKAL, [Out] quaternion KNBHNOGKKNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x6CC6720", Offset = "0x6CC5120", VA = "0x186CC6720")]
	public bool KMPKCNLLMKD([Out] float EEIBOHILFGM, [Out] float AIOACPMAPGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct BOLJHNBDPJH : IEquatable<BOLJHNBDPJH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly HNLGJNFDBGG HDFPPGPMEIA;

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public GKNFJEDFFIC CLHDDLICOFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(GKNFJEDFFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public IOPBNEOHIPD LIFEFNNCMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
		get
		{
			return default(IOPBNEOHIPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	private AKFNFIHHCPG NCIIENLBPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9530", Offset = "0x6CB7F30", VA = "0x186CB9530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	private INCMDLLBCFJ IBLKKJIGNNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x6CBBAE0", Offset = "0x6CBA4E0", VA = "0x186CBBAE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public bool JJEOPDEHAEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x6CBB150", Offset = "0x6CB9B50", VA = "0x186CBB150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public Vector3 MHEDOFLPKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9890", Offset = "0x6CB8290", VA = "0x186CB9890")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6CBB850", Offset = "0x6CBA250", VA = "0x186CBB850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public Quaternion MGLMKDCNIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9C30", Offset = "0x6CB8630", VA = "0x186CB9C30")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x6CBAB70", Offset = "0x6CB9570", VA = "0x186CBAB70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public Vector3 KACBAACBPPD
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9EF0", Offset = "0x6CB88F0", VA = "0x186CB9EF0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x6CBA400", Offset = "0x6CB8E00", VA = "0x186CBA400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public Quaternion LEKKDBMJIJL
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x6CBB010", Offset = "0x6CB9A10", VA = "0x186CBB010")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x6CBB780", Offset = "0x6CBA180", VA = "0x186CBB780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public float LKDEHMDCGLA
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x6CBACE0", Offset = "0x6CB96E0", VA = "0x186CBACE0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x6CBB6D0", Offset = "0x6CBA0D0", VA = "0x186CBB6D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public float NBGFHJOBHBF
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x6CBA5F0", Offset = "0x6CB8FF0", VA = "0x186CBA5F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public Vector3 KIIDGAABMEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9980", Offset = "0x6CB8380", VA = "0x186CB9980")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x6CBAD80", Offset = "0x6CB9780", VA = "0x186CBAD80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public Vector3 EAAKDEDIBKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x6CBAF20", Offset = "0x6CB9920", VA = "0x186CBAF20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public Matrix4x4 NMEHCMGIBPM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x6CBA070", Offset = "0x6CB8A70", VA = "0x186CBA070")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
	public BOLJHNBDPJH(HNLGJNFDBGG ELHMIJIMOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B90", Offset = "0x6CB7590", VA = "0x186CB8B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9FE0", Offset = "0x6CB89E0", VA = "0x186CB9FE0", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8AF0", Offset = "0x6CB74F0", VA = "0x186CB8AF0", Slot = "4")]
	public bool Equals(BOLJHNBDPJH AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BC0", Offset = "0x6CB75C0", VA = "0x186CB8BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA3B0", Offset = "0x6CB8DB0", VA = "0x186CBA3B0")]
	public HPFOPEMMFAI GELCJAFCJIB()
	{
		return default(HPFOPEMMFAI);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA4D0", Offset = "0x6CB8ED0", VA = "0x186CBA4D0")]
	public void GKJHHIIDCPD([Out] Matrix4x4 GFJPPCILDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x6CBB240", Offset = "0x6CB9C40", VA = "0x186CBB240")]
	public void KNCCBDCKBPO([Out] Vector3 PLNLMNHLGOJ, [Out] Quaternion FGNEJEMONLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x6CBB190", Offset = "0x6CB9B90", VA = "0x186CBB190")]
	public void KNCCBDCKBPO([Out] RigidTransform ONHBOCKKIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA830", Offset = "0x6CB9230", VA = "0x186CBA830")]
	public void IBPGCIMJION([Out] Vector3 PLNLMNHLGOJ, [Out] Quaternion FGNEJEMONLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA780", Offset = "0x6CB9180", VA = "0x186CBA780")]
	public void IBPGCIMJION([Out] RigidTransform ONHBOCKKIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA9B0", Offset = "0x6CB93B0", VA = "0x186CBA9B0")]
	public UniformTRS IPOOMEABCOA()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA9E0", Offset = "0x6CB93E0", VA = "0x186CBA9E0")]
	public void IPOOMEABCOA([Out] UniformTRS FJCACPIFNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6CBB9F0", Offset = "0x6CBA3F0", VA = "0x186CBB9F0")]
	public UniformTRS OKIOEKMKNBG()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6CBBA20", Offset = "0x6CBA420", VA = "0x186CBBA20")]
	public void OKIOEKMKNBG([Out] UniformTRS ONHBOCKKIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9B40", Offset = "0x6CB8540", VA = "0x186CB9B40")]
	public Vector3 DDOJNJFNPAE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9A70", Offset = "0x6CB8470", VA = "0x186CB9A70")]
	public void CHFKLOJGNKL([In] Vector3 CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA690", Offset = "0x6CB9090", VA = "0x186CBA690")]
	public Vector3 HIOCNDJDHDG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6CBB920", Offset = "0x6CBA320", VA = "0x186CBB920")]
	public void OCMMPAGAKAI([In] Vector3 CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x6CBB4E0", Offset = "0x6CB9EE0", VA = "0x186CBB4E0")]
	public Quaternion KPEJGODJHLI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9E20", Offset = "0x6CB8820", VA = "0x186CB9E20")]
	public void ECHOKODAPAD([In] Quaternion CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA1A0", Offset = "0x6CB8BA0", VA = "0x186CBA1A0")]
	public Quaternion GDDIDPBHHNI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA2E0", Offset = "0x6CB8CE0", VA = "0x186CBA2E0")]
	public void GDHFACNHAGB([In] Quaternion CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA910", Offset = "0x6CB9310", VA = "0x186CBA910")]
	public float IHNMHPGKCEJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9D70", Offset = "0x6CB8770", VA = "0x186CB9D70")]
	public void EBNDCLGNKKO(float CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x6CBAC40", Offset = "0x6CB9640", VA = "0x186CBAC40")]
	public float JKMLLIMHDID()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x6CBB620", Offset = "0x6CBA020", VA = "0x186CBB620")]
	public void LFIBHKKKCPL(float CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6CBAE50", Offset = "0x6CB9850", VA = "0x186CBAE50")]
	public void KANPLDFBOJE([In] Vector3 CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA0B0", Offset = "0x6CB8AB0", VA = "0x186CBA0B0")]
	public Vector3 FGOMEHJPCCO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x6CBB320", Offset = "0x6CB9D20", VA = "0x186CBB320")]
	public void KNPEFPHMMNM([In] Vector3 CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x6CBB3F0", Offset = "0x6CB9DF0", VA = "0x186CBB3F0")]
	public Vector3 KPEBGKNOPFL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6CB97C0", Offset = "0x6CB81C0", VA = "0x186CB97C0")]
	public void BHANLFOBAGB([In] Vector3 CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6CBBBA0", Offset = "0x6CBA5A0", VA = "0x186CBBBA0")]
	public Vector3 PAOJJIHDBOK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6CBAAA0", Offset = "0x6CB94A0", VA = "0x186CBAAA0")]
	public void JGKGIKOBIKI([In] Vector3 CLMKDBDPNNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class CBAFNKJCEED
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private struct FKGPNBOIPFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Guid HLIKNGLOMIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CMLDBHKIECD LHKNEKONJEN;
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private struct CMLDBHKIECD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int CLMKDBDPNNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int BGOBPDPFBHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int LACDNCHIEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int IHEOEDPGPCK;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x6CBC740", Offset = "0x6CBB140", VA = "0x186CBC740")]
		public bool IFBHGBDEJCD([Out] NONPGOCJFKO BHJCOOBDBLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x6CBC7D0", Offset = "0x6CBB1D0", VA = "0x186CBC7D0")]
		public CMLDBHKIECD(NONPGOCJFKO BHJCOOBDBLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6CBBD50", Offset = "0x6CBA750", VA = "0x186CBBD50")]
	public static Guid MKFKFFKHJEF(this NONPGOCJFKO BHJCOOBDBLN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6CBBD30", Offset = "0x6CBA730", VA = "0x186CBBD30")]
	public static bool EMOLEKKIFHH(this Guid HLIKNGLOMIK, [Out] NONPGOCJFKO BHJCOOBDBLN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal static class IBKEPKHBHHG
{
	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x6CC5D40", Offset = "0x6CC4740", VA = "0x186CC5D40")]
	public static OAFALLIAHBA BHBJEHGAJEA(this HNLGJNFDBGG KFBALBFDDFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6CC5ED0", Offset = "0x6CC48D0", VA = "0x186CC5ED0")]
	public static LNDIPIINEOG GMMFMDFJJFK(this HNLGJNFDBGG KFBALBFDDFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6CC5DD0", Offset = "0x6CC47D0", VA = "0x186CC5DD0")]
	public static EntityManager DPEGDPAJBMP(this HNLGJNFDBGG KFBALBFDDFF)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2CCB2A0", Offset = "0x2CC9CA0", VA = "0x182CCB2A0")]
	public static T ONNFIAEIKIP<T>(this HNLGJNFDBGG KFBALBFDDFF) where T : struct, CLEILMDBNCI
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x2CCAFE0", Offset = "0x2CC99E0", VA = "0x182CCAFE0")]
	public static bool CINNAKGEJAH<T>(this HNLGJNFDBGG KFBALBFDDFF) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2CCAF30", Offset = "0x2CC9930", VA = "0x182CCAF30")]
	public static bool BCCAJGOALAP<T>(this HNLGJNFDBGG KFBALBFDDFF) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface MJLCKCBMGKD
{
	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DEKAIPNHFOA(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PMFGOLNLDOO(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task OKGMODFJGMM(GKNFJEDFFIC GIGIFGONEAO);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PFJJFDAKLFP(HNLGJNFDBGG ELHMIJIMOPL, [Out] Guid OJMCAIBKDOI);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid AMLHLAEGMMP(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DOHGOJMADPI(HNLGJNFDBGG ELHMIJIMOPL, Guid OJMCAIBKDOI);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GIBJADCHBKO(HNLGJNFDBGG ELHMIJIMOPL, [Out] Guid ODLOJKBAHLA);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Guid LFBCIFELAIG(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KBEBOPBDJCC(HNLGJNFDBGG ELHMIJIMOPL, Guid ODLOJKBAHLA);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NFFIHHILJNJ(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task FIEFDCIEOEB(HNLGJNFDBGG FGMPPONDFPE, HNLGJNFDBGG DLPGBMPJIIG);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface IOEDKAEMALH
{
	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	Guid ADIMLHDKIEM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGBOIGJFHMB(NativeList<Guid> HGDHPNCCKLD, NativeList<Guid> JFGDEMOPEJJ, NativeList<FixedString64Bytes> HCFMPPGBGGO);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface DBBIFKLCCJB
{
	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ABPKBNKNDDD(List<HNLGJNFDBGG> INFDDAOAJDO);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NAHEBNFPFNM(List<HNLGJNFDBGG> JPADODJFECC);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GAEGJHAEKAC(HNLGJNFDBGG OEPAIEDOBNK);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EBAOBCEAEIH(HNLGJNFDBGG OEPAIEDOBNK);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HGJJHACNHBB(HNLGJNFDBGG OEPAIEDOBNK);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int JKOOIBOMCCB(HNLGJNFDBGG OEPAIEDOBNK);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DKDHCEHNLMG(HNLGJNFDBGG OEPAIEDOBNK, int NCGCLGONMJP);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HNLGJNFDBGG DIJJNAGDMAN(HNLGJNFDBGG HLJOKJGEOAK);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int KPEPGIJBHDF(HNLGJNFDBGG HLJOKJGEOAK);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JLELIKBEDCD(HNLGJNFDBGG HLJOKJGEOAK, int MMKMAAOMNCL);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int BHAOOPEIBED(HNLGJNFDBGG HLJOKJGEOAK);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LNEIMHAOBDP(HNLGJNFDBGG HLJOKJGEOAK, int BGEMIMJOENB);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EMCIDGJPINK(HNLGJNFDBGG HDFPPGPMEIA);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DMABHNLAKGM(HNLGJNFDBGG ELHMIJIMOPL, bool HJDEDCLEIEO);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CHIOJHCLGAC(HNLGJNFDBGG[] DGICEOHLFPK, bool HJDEDCLEIEO);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface CNAOIDFFGAE
{
	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	IReadOnlyCollection<DBBMNHAKBDI> AOMIJPMLAHP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JPDCPHHNPKC(int NNGGOAJPOAO, [Out] DBBMNHAKBDI OGEGPBNNHOD);

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DBBMNHAKBDI INHMKGLOODE(Type NNCMOPPBEEE);
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class OGIBMIHFMEJ
{
	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2DFD860", Offset = "0x2DFC260", VA = "0x182DFD860")]
	public static T EMGHJBJCLEM<T>(this CNAOIDFFGAE IICNDECOLLF, Entity HLKOPNMJGHO) where T : struct, CLEILMDBNCI
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x2DFD910", Offset = "0x2DFC310", VA = "0x182DFD910")]
	public static DBBMNHAKBDI INHMKGLOODE<T>(this CNAOIDFFGAE IICNDECOLLF) where T : struct, CLEILMDBNCI
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface AIHABAPCKHB
{
	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NONPGOCJFKO[] NEILDBGIBHH(string HBOONHFLONJ, GKNFJEDFFIC CJNLGFLACJA, bool CPHKPLNKDCL = false);

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FINKFNJIFMH(string MAOAEMLFGPJ, NONPGOCJFKO[] LBOAFPMJOCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface MLMNDHFKMLB
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<HNLGJNFDBGG, HNLGJNFDBGG> IIOFACEJPBO;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<HNLGJNFDBGG, HNLGJNFDBGG> EIIMOPJDJCJ;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<HNLGJNFDBGG, HNLGJNFDBGG, HNLGJNFDBGG> EKAFDBLDGIP;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<HNLGJNFDBGG> MMKKIOMEFMD;

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ACLFCFCHBGP(HNLGJNFDBGG ELHMIJIMOPL, HNLGJNFDBGG BBHOGONPACC);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HNLGJNFDBGG CKLFLBONFMD(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<HNLGJNFDBGG> BJNFKNMHDNE(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HNLGJNFDBGG LHLGOGABLGI(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EAPCAFACKFP(HNLGJNFDBGG ELHMIJIMOPL, Vector3 LDHLILEGGPL, Quaternion JJJIMNLGNPI);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CGIOOLHJGDB(HNLGJNFDBGG ELHMIJIMOPL, float MAFDCDMMPAH);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool EGGKDGOJEKC(HNLGJNFDBGG ELHMIJIMOPL, [Out] HNLGJNFDBGG DLPGBMPJIIG);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool CFCDFDFIEFO(HNLGJNFDBGG ELHMIJIMOPL, [Out] RigidTransform DNLLGDHLCJG);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool AIADFMJCMJB(HNLGJNFDBGG ELHMIJIMOPL, [Out] float GOFFCKMMAIM);

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 JAEHMDJGCKO(DOFPBNLEGOI IHKKACAIAJP);

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "18")]
	quaternion DKODJPHLPDH(DOFPBNLEGOI IHKKACAIAJP);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class HLGBOGJKENG
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface AKLAFCMPKMB
{
	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	object BNOCFBCCFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NCIDOJLKFCC(DECONOAHEMJ DGICEOHLFPK);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct LKPEEKELBEL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly string HBOONHFLONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly T PEMAOEALEHB;

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x4437100", Offset = "0x4435B00", VA = "0x184437100")]
	public LKPEEKELBEL(T PEMAOEALEHB, [Optional][CallerMemberName] string HBOONHFLONJ)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public static readonly LKPEEKELBEL<int> MCKAIDLNGOH;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public enum MEBHLDEBGFP
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public static class GKEEEHGHPDP
{
	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0xF201F0", Offset = "0xF1EBF0", VA = "0x180F201F0")]
	public static bool JBLOMCCJDAG(this MEBHLDEBGFP ACEEMNFHFMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0xF20200", Offset = "0xF1EC00", VA = "0x180F20200")]
	public static bool LBBJOALIPEE(this MEBHLDEBGFP ACEEMNFHFMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x26471D0", Offset = "0x2645BD0", VA = "0x1826471D0")]
	public static bool CNJGOPIGDHM(this MEBHLDEBGFP ACEEMNFHFMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface FMFBNNOKPBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000180")]
	bool OHNHAHEIENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface JFNMKJFMBOB
{
	[Cpp2IlInjected.Token(Token = "0x17000181")]
	MEBHLDEBGFP IIBJJNOEILP
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	MEBHLDEBGFP LNLMPMKCFAD
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	MEBHLDEBGFP HDIAFBEKCKI
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	MEBHLDEBGFP DOOMPAOGBPM
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	MEBHLDEBGFP KHEEHFADDII
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	MEBHLDEBGFP NPOGEPOHNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	MEBHLDEBGFP COKINHKMLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	MEBHLDEBGFP GIHNAPMHEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	MEBHLDEBGFP CKAGJHCOFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	MEBHLDEBGFP IFGMNIIIHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	MEBHLDEBGFP BCNKKEGEFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	MEBHLDEBGFP DOJKLLJPAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	MEBHLDEBGFP IOJHJHEMBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	MEBHLDEBGFP EIGMMOPAOLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	MEBHLDEBGFP BAHNGPBDFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	MEBHLDEBGFP DLCLDCGKIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PHNOCPFLPNG(LKPEEKELBEL<int> KNPAPMCPMPB);
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface FJAPLNLLFFB
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event KKNENOMBIEO.AHMCGILOPKE INLIEEBIDHI;

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HNLGJNFDBGG OLFHOEEGBNA(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PIPNNGIPEPK(List<HNLGJNFDBGG> JPADODJFECC);

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	INOIPDKKFGO AJDMOHLFPDL(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GAOAHOBDADM(IEnumerable<HNLGJNFDBGG> OOLHNLKNNHD);

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "6")]
	INOIPDKKFGO AMKFFMJAOGG(HNLGJNFDBGG DLPGBMPJIIG, HNLGJNFDBGG CDNMICCKGIM, bool IJDJFIBAPOM, HNLGJNFDBGG IPOCAIFIKHJ);

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HNLGJNFDBGG JEODACCEEOI(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FPIHKLEMIHN(HNLGJNFDBGG ELHMIJIMOPL, HNLGJNFDBGG DLPGBMPJIIG, bool ELMCOJBCBOA);

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool CDNJPIMNACG(HNLGJNFDBGG ELHMIJIMOPL, HNLGJNFDBGG DLPGBMPJIIG);

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KHBCJFAOEJN(HNLGJNFDBGG EHKJCNLDPGA, HNLGJNFDBGG NAEPBKFNOAH);

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int IPAAMOLJEIE(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DECONOAHEMJ INNAGIKLBEJ(HNLGJNFDBGG HDFPPGPMEIA);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<HNLGJNFDBGG> NGDOMDMOJKF(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool FMFPHNNJDDJ(HNLGJNFDBGG ELHMIJIMOPL, HNLGJNFDBGG CFDAPHPJDEO);

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IEnumerable<HNLGJNFDBGG> BAFOFNPHBNL(HNLGJNFDBGG ELHMIJIMOPL, bool KNANDLCCCDN = false);

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool JDFADGKCGJG(HNLGJNFDBGG ELHMIJIMOPL, HNLGJNFDBGG BHNMAGJIIBB);

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	HNLGJNFDBGG COLIIJBHENE(HNLGJNFDBGG IPOCAIFIKHJ, HNLGJNFDBGG EFKCPGAGEHF);

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool KKDCCCBCKKA(HNLGJNFDBGG IPOCAIFIKHJ, HNLGJNFDBGG EFKCPGAGEHF, [Out] HNLGJNFDBGG CFCFAINLCML);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class NDDHBKEEDLJ
{
	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x6CC85C0", Offset = "0x6CC6FC0", VA = "0x186CC85C0")]
	public static List<HNLGJNFDBGG> PIPNNGIPEPK(this FJAPLNLLFFB ECOCBLHIEBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x6CC8550", Offset = "0x6CC6F50", VA = "0x186CC8550")]
	public static bool PFBBECKGEAK(this FJAPLNLLFFB ECOCBLHIEBE, HNLGJNFDBGG ELHMIJIMOPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface FAGOKNOGCAI
{
	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GALKGBKEIBI MCPNAIACLJF(HNLGJNFDBGG OEPAIEDOBNK);

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FGACJNMEGFG(HNLGJNFDBGG OEPAIEDOBNK, GALKGBKEIBI CIPAKAJPNIA);

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LFODIOJLJGA(HNLGJNFDBGG OEPAIEDOBNK);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KNACPIBMMIH(HNLGJNFDBGG OEPAIEDOBNK, bool CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string[] JGGGOKDFAFO(HNLGJNFDBGG OEPAIEDOBNK);

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JJGJFNNCMEG(HNLGJNFDBGG OEPAIEDOBNK, IEnumerable<string> AHLLKDMIMLK);

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string[] BBAJLDJBDMJ(HNLGJNFDBGG OEPAIEDOBNK);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OADGAMCFLBN(HNLGJNFDBGG OEPAIEDOBNK, IEnumerable<string> AHLLKDMIMLK);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "8")]
	string[] KGKBILIDNMG(HNLGJNFDBGG OEPAIEDOBNK);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OGEKBKOCKJL(HNLGJNFDBGG OEPAIEDOBNK, IEnumerable<string> AHLLKDMIMLK);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string[] KCIMFOMLLND(HNLGJNFDBGG OEPAIEDOBNK);

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MCNGNEPFIFN(HNLGJNFDBGG OEPAIEDOBNK, IEnumerable<string> AHLLKDMIMLK);

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool FJMFOACMBCM(HNLGJNFDBGG OEPAIEDOBNK, HNLGJNFDBGG JGEPDBLHLJG);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface ACAMENBHBLO
{
	[Cpp2IlInjected.Token(Token = "0x17000191")]
	bool LIFGNFENFBP
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	bool NILNBJLLLPP
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	bool LMBMCDCCDPB
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface PCLPJIKJEGF : DBGFECGLIMN
{
	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GCOPBMKKPEH(Entity HLKOPNMJGHO, [Out] INDFKHPCMOG OMKGKCDECFC);

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KJEIHLFEJLI(NativeArray<INDFKHPCMOG> AJBLMIKCHLB, NativeArray<AJMFPCKFPAB> OBCBNEIIHJO);

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IHLPPHFAHBE(INDFKHPCMOG OMKGKCDECFC);

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JADBJGNKMHG(INDFKHPCMOG OMKGKCDECFC, [Out] Collider IHHPCPOLGKB);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface DBGFECGLIMN
{
	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KCNGDHOHEGO([In] float3 OBDNGCBKBFA, [In] float3 IMGPFEFAFKM, float NGBAMCDGGDI, Allocator MDICAPEDFAK, [Out] NativeArray<Entity> KJEILEEIDEP);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface EMKHMEMDPAP
{
	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KCNGDHOHEGO([In] float3 OBDNGCBKBFA, [In] float3 IMGPFEFAFKM, float NGBAMCDGGDI, [Out] HJMLJMHOIIK KKELIGPBMHN, [Out] HNLGJNFDBGG GCCNBCCDLBA);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface CPDKAOLHGIP
{
	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCNGDHOHEGO([In] NativeArray<Entity> KJEILEEIDEP, [In] float3 OBDNGCBKBFA, [In] float3 IMGPFEFAFKM, [In] NativeArray<HJMLJMHOIIK> PHNMBFEOMED);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct INDFKHPCMOG : LCMEFFHGKGH, IEquatable<INDFKHPCMOG>
{
	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public int MOMFAOPBBMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x9696E0", Offset = "0x9680E0", VA = "0x1809696E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xB0FC60", Offset = "0xB0E660", VA = "0x180B0FC60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public int EBJFPPIDGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x2664280", Offset = "0x2662C80", VA = "0x182664280", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x5F77A80", Offset = "0x5F76480", VA = "0x185F77A80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7240", Offset = "0x6CC5C40", VA = "0x186CC7240", Slot = "8")]
	public bool Equals(INDFKHPCMOG AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7290", Offset = "0x6CC5C90", VA = "0x186CC7290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct HJMLJMHOIIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float JGLBEKAHEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float3 BELBOBCMBGH;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface GHPNNLCANKC
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface AKFNFIHHCPG
{
	[Cpp2IlInjected.Token(Token = "0x17000196")]
	OAFALLIAHBA BHBJEHGAJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	GDCOFCJLLOD HDPHOPGAILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<DECONOAHEMJ, NativeArray<KFELEOEDBBF>> JDIGAONJLHD;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<DECONOAHEMJ> OLKJGBOAFCF;

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IFLBPGBFPBJ IMEKPCFDHEA(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KFELEOEDBBF IGIFOPLONGC(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HEDMFNKAECO(NONPGOCJFKO BHJCOOBDBLN, GJAKFAKLBCN HDJBPODPFGE);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DPGLCCPCDDI(NONPGOCJFKO[] LBOAFPMJOCJ, GameObject EABKFLBGOGN);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GKNFJEDFFIC EAPGNAMLGLA(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ICOPDCFDDEF(HNLGJNFDBGG ELHMIJIMOPL, [Out] Transform JKDLLOIHFGK);

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool IPJFKILMFNI(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FBFDJBBEDAH(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	HNLGJNFDBGG KNLBMDDMIFP(NONPGOCJFKO BHJCOOBDBLN);

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool MCBIFBFOHLB(NONPGOCJFKO BHJCOOBDBLN, [Out] HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	NONPGOCJFKO ALFIBAJLJKO(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	LocalId FGBDKEFELGI(LocalId GFKAHPJBMCC);

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	DECONOAHEMJ KNLBMDDMIFP(NativeArray<NONPGOCJFKO> BHJCOOBDBLN, Allocator MDICAPEDFAK);

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "19")]
	DECONOAHEMJ NHDDMGNDNMP(KFELEOEDBBF DPMCJCFIMPM, int KFBJHPBJLOG, Allocator MDICAPEDFAK);

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "20")]
	DECONOAHEMJ MKFIINEKLIL(NativeArray<NONPGOCJFKO> BHJCOOBDBLN, NativeArray<NDLOJBFGBBM> BCFCOIHFAKK, Allocator MDICAPEDFAK);

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "21")]
	NONPGOCJFKO[] NEILDBGIBHH(string MAOAEMLFGPJ, GKNFJEDFFIC CJNLGFLACJA, bool CPHKPLNKDCL);

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void FINKFNJIFMH(string MAOAEMLFGPJ, NONPGOCJFKO[] LBOAFPMJOCJ);

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "23")]
	GKNFJEDFFIC CLEBAMOKADI(KFELEOEDBBF DPMCJCFIMPM, bool PGJDFLAFNGE);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "24")]
	GKNFJEDFFIC CLEBAMOKADI(KFELEOEDBBF DPMCJCFIMPM);

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(Slot = "25")]
	GKNFJEDFFIC ELOINHFJPFF(KFELEOEDBBF DPMCJCFIMPM);

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "26")]
	GKNFJEDFFIC EFBMFMKKBKP(KFELEOEDBBF DPMCJCFIMPM);

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "27")]
	GKNFJEDFFIC APLLOGGHBCD(NONPGOCJFKO BHJCOOBDBLN, KFELEOEDBBF DPMCJCFIMPM);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "28")]
	FIAGMCIBLJJ KCAGKEPDLFI();

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "29")]
	HFCIPGCEECH HOOILOOEFID();

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "30")]
	EOAIEFEDHHH IJFPBFBFCAH(KHHCEDFJMMM LHMJNOKDPHE);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void AALDKOBLPAE(DECONOAHEMJ DGICEOHLFPK);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void EPGEGEJNIJO(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void JJHLLBGPBNO(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void AALDKOBLPAE(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void MEOKCNGAMNA(HNLGJNFDBGG DGICEOHLFPK);

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "36")]
	bool FCIBBGIEOKI(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "37")]
	DECONOAHEMJ JGPOELJHAAJ(DECONOAHEMJ LEBDPNMJJLJ, Allocator MDICAPEDFAK);

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool KAMLGAEHELA(HNLGJNFDBGG ELHMIJIMOPL);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class CFEMLOKDKJH
{
	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x6CBC1E0", Offset = "0x6CBABE0", VA = "0x186CBC1E0")]
	public static void FBFDJBBEDAH(this AKFNFIHHCPG HNGOHAEBHPK, GJAKFAKLBCN HDJBPODPFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6CBC6B0", Offset = "0x6CBB0B0", VA = "0x186CBC6B0")]
	public static GKNFJEDFFIC KPLKLKMKAHI(this AKFNFIHHCPG HNGOHAEBHPK, LocalId ELHMIJIMOPL)
	{
		return default(GKNFJEDFFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6CBC6E0", Offset = "0x6CBB0E0", VA = "0x186CBC6E0")]
	public static GKNFJEDFFIC KPLKLKMKAHI(this AKFNFIHHCPG HNGOHAEBHPK, NONPGOCJFKO BHJCOOBDBLN)
	{
		return default(GKNFJEDFFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6CBC6B0", Offset = "0x6CBB0B0", VA = "0x186CBC6B0")]
	public static HNLGJNFDBGG KNLBMDDMIFP(this AKFNFIHHCPG HNGOHAEBHPK, LocalId ELHMIJIMOPL)
	{
		return default(HNLGJNFDBGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6CBC160", Offset = "0x6CBAB60", VA = "0x186CBC160")]
	public static NONPGOCJFKO ALFIBAJLJKO(this AKFNFIHHCPG HNGOHAEBHPK, LocalId ELHMIJIMOPL)
	{
		return default(NONPGOCJFKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6CBC440", Offset = "0x6CBAE40", VA = "0x186CBC440")]
	public static bool KAMLGAEHELA(this AKFNFIHHCPG HNGOHAEBHPK, NONPGOCJFKO BHJCOOBDBLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x2AB8690", Offset = "0x2AB7090", VA = "0x182AB8690")]
	public static T FHCDKPEOBBD<T>(this AKFNFIHHCPG HNGOHAEBHPK, LocalId ELHMIJIMOPL) where T : struct, CLEILMDBNCI
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6CBC350", Offset = "0x6CBAD50", VA = "0x186CBC350")]
	public static FIAGMCIBLJJ JOJNNDKINDO(this AKFNFIHHCPG HNGOHAEBHPK, RigidTransform FJCACPIFNPA)
	{
		return default(FIAGMCIBLJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x6CBC060", Offset = "0x6CBAA60", VA = "0x186CBC060")]
	public static EOAIEFEDHHH AGOLGJHFIPL(this AKFNFIHHCPG HNGOHAEBHPK, KHHCEDFJMMM CBHGLNPOICK, RigidTransform FJCACPIFNPA)
	{
		return default(EOAIEFEDHHH);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6CBC260", Offset = "0x6CBAC60", VA = "0x186CBC260")]
	public static HFCIPGCEECH HKBAMGCGAJC(this AKFNFIHHCPG HNGOHAEBHPK, RigidTransform FJCACPIFNPA)
	{
		return default(HFCIPGCEECH);
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6CBC4B0", Offset = "0x6CBAEB0", VA = "0x186CBC4B0")]
	private static void KJGPJKNCFFK(GKNFJEDFFIC ANPPFPEKMKP, RigidTransform FJCACPIFNPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface CEPFICOCOAG
{
	[Cpp2IlInjected.Token(Token = "0x17000198")]
	bool IDLNOPPIDFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	HNLGJNFDBGG ICMNFHDPMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	GKNFJEDFFIC KJDGINOAONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event GNEBNONNBCF GBLHGIDCHPI;

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HNLGJNFDBGG COLIIJBHENE(HNLGJNFDBGG IPOCAIFIKHJ, HNLGJNFDBGG EFKCPGAGEHF);

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KKDCCCBCKKA(HNLGJNFDBGG IPOCAIFIKHJ, HNLGJNFDBGG EFKCPGAGEHF, [Out] HNLGJNFDBGG CFCFAINLCML);

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AEDLONOGBIP();

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GFINEHKFPHA();

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool HBJOPJEBOOC(HNLGJNFDBGG IPOCAIFIKHJ);

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool BIKCCFHNAIL(HNLGJNFDBGG IPOCAIFIKHJ);
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public delegate void GNEBNONNBCF(GKNFJEDFFIC CBAEGGAOMPJ, GKNFJEDFFIC GNEKJFJMFOE);
[Cpp2IlInjected.Token(Token = "0x200008B")]
public static class HEEEFIPAKBM
{
	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6CC37A0", Offset = "0x6CC21A0", VA = "0x186CC37A0")]
	public static bool IPLKFACHEJA(this CEPFICOCOAG LFMMOIOGCAN, GKNFJEDFFIC IPOCAIFIKHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x6CC3640", Offset = "0x6CC2040", VA = "0x186CC3640")]
	public static bool ACFDNNDJCDI(this CEPFICOCOAG LFMMOIOGCAN, HNLGJNFDBGG IPOCAIFIKHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x6CC3720", Offset = "0x6CC2120", VA = "0x186CC3720")]
	public static bool DFAMGHEKKNA(this CEPFICOCOAG LFMMOIOGCAN, HNLGJNFDBGG IPOCAIFIKHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface PBPBCNCHGGP
{
	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BPJIPNPCDPE(GKNFJEDFFIC ANPPFPEKMKP, GKIIHAFLNOK OIKBGDLAKHG, List<GKNFJEDFFIC> FKDPICIBJEL);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int BEMDODGLMOK(GKNFJEDFFIC ANPPFPEKMKP, GKIIHAFLNOK OIKBGDLAKHG);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LJGPGDDKNHA(GKNFJEDFFIC ANPPFPEKMKP, List<GKNFJEDFFIC> FKDPICIBJEL);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int FKEKIHAMDBP(GKNFJEDFFIC OMFPMCIAPMD, GKNFJEDFFIC IPOCAIFIKHJ, GKIIHAFLNOK OIKBGDLAKHG);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GKNFJEDFFIC AGAKHJHCLCH(GKNFJEDFFIC OMFPMCIAPMD, int EBDDHAPIAHH, GKIIHAFLNOK OIKBGDLAKHG);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HEGCMGKCBHB(GKNFJEDFFIC OMFPMCIAPMD, GKNFJEDFFIC IPOCAIFIKHJ, GKIIHAFLNOK OIKBGDLAKHG);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FLDMBOKKGJK(GKNFJEDFFIC OMFPMCIAPMD, GKNFJEDFFIC IPOCAIFIKHJ, GKIIHAFLNOK OIKBGDLAKHG);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ALOEILANFPB(GKNFJEDFFIC OMFPMCIAPMD, GKIIHAFLNOK OIKBGDLAKHG);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PFPGDIOIMDN(GKNFJEDFFIC OMFPMCIAPMD, GKNFJEDFFIC IPOCAIFIKHJ, GKIIHAFLNOK OIKBGDLAKHG);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JMKDEGHFJCJ(Entity OMFPMCIAPMD, Entity IPOCAIFIKHJ, GKIIHAFLNOK OIKBGDLAKHG);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OFFLHEKDHAB(Entity OMFPMCIAPMD, GKIIHAFLNOK OIKBGDLAKHG);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool HKIIAIGIJGG(GKNFJEDFFIC IPOCAIFIKHJ, GKIIHAFLNOK OIKBGDLAKHG);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface FBEPBACFAIN
{
	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OLEGHCLMEJC(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JIFCBACFDAJ(HNLGJNFDBGG ELHMIJIMOPL, Transform JKDLLOIHFGK);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface OIAIHOFHKBH
{
	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GNCHHACPJMM(HNLGJNFDBGG IPOCAIFIKHJ, HNLGJNFDBGG GFMIMGGHPIJ);

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KGNPGLBFOJN(HNLGJNFDBGG IPOCAIFIKHJ, HNLGJNFDBGG KDPEHCJFACH);

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JKADLGCOHGH(HNLGJNFDBGG IPOCAIFIKHJ, [Out] HNLGJNFDBGG CFDEPBONAFH);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface KHACGHKOAGH
{
	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BJDMJEMEOMJ(HNLGJNFDBGG HDFPPGPMEIA, bool CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILELCPGAKBC(HNLGJNFDBGG HDFPPGPMEIA, bool CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PKPENMJDGFI(HNLGJNFDBGG HDFPPGPMEIA, int CLMKDBDPNNH);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface KEMLCCGHOGN
{
	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<HNLGJNFDBGG> LFMHGPNKAED(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HNLGJNFDBGG BJFDAOPPBNK(HNLGJNFDBGG ELHMIJIMOPL, int EBDDHAPIAHH);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int DLMGFFCIKLB(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EPIBLGLJFNJ ODFPKIDDIFK(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HOIFLLEKFHD(HNLGJNFDBGG ELHMIJIMOPL, EPIBLGLJFNJ APDNBDIKMDG);

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HNLGJNFDBGG CDPEGBJNJPM(HNLGJNFDBGG ELHMIJIMOPL, [Optional] float3? BJDHDJCINFH, [Optional] quaternion? FJFNLINEAKI, [Optional] float3? ADJNFMJNIAA);

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HNLGJNFDBGG NBNGDCAFGLC(HNLGJNFDBGG ELHMIJIMOPL, int EBDDHAPIAHH, [Optional] float3? BJDHDJCINFH, [Optional] quaternion? FJFNLINEAKI, [Optional] float3? ADJNFMJNIAA);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BPNAPONAHAG(HNLGJNFDBGG ELHMIJIMOPL, int EBDDHAPIAHH);

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MOBEILCKPKN(HNLGJNFDBGG ELHMIJIMOPL);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface DJGKINNPEOL
{
	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEEGOHLFKDA();

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IJDNFCEAEDK();

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DAHPKMFHAAG();

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HLMLODMEECO();

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AHNLAPCPGFF();

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OBEOHABLIBC();

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CCFBMLGKHDA();

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OMLEAOKGKGM();

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ICHPCFGJLEB();

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GLCIOKIAFDM();

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JBEKKPCDFAO();

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OFOEIHPKDJM();

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NKJEDLPENJN();
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface DMOFABMJHHG
{
	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CBHGIGDIHBL(HNLGJNFDBGG IPOCAIFIKHJ, [Out] int OMFPMCIAPMD);

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OHJGFLNFNEM(HNLGJNFDBGG IPOCAIFIKHJ, int OMFPMCIAPMD);

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GEONINLFOMF(HNLGJNFDBGG IPOCAIFIKHJ, bool CIPDEENNFMH);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NCCIDOPIKLJ(HNLGJNFDBGG IPOCAIFIKHJ, bool PJABBMAGKPI);

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AKBEPJNHFDI(HNLGJNFDBGG IPOCAIFIKHJ, float IGNJJPJEPIM, float MBMCHPPKBKG, float ABLDFPIGKGK);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KMPKCNLLMKD(HNLGJNFDBGG ELHMIJIMOPL, [Out] float MBMCHPPKBKG, [Out] float ABLDFPIGKGK);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NCPCAIKAFBF(HNLGJNFDBGG IPOCAIFIKHJ, float3 BJDHDJCINFH, quaternion FJFNLINEAKI);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool INEBGBGNKPL(HNLGJNFDBGG IPOCAIFIKHJ, [Out] float3 BJDHDJCINFH, [Out] quaternion FJFNLINEAKI);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface INCMDLLBCFJ
{
	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIHDANGKFJK(Entity HLKOPNMJGHO);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CHFKLOJGNKL(Entity HLKOPNMJGHO, [In] float3 CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 DDOJNJFNPAE(Entity HLKOPNMJGHO);

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ECHOKODAPAD(Entity HLKOPNMJGHO, [In] quaternion CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion KPEJGODJHLI(Entity HLKOPNMJGHO);

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JBMEGFMNJCM(Entity HLKOPNMJGHO, [In] float3 BJDHDJCINFH, [In] quaternion FJFNLINEAKI);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KNCCBDCKBPO(Entity HLKOPNMJGHO, [Out] float3 BJDHDJCINFH, [Out] quaternion FJFNLINEAKI);

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KNCCBDCKBPO(Entity HLKOPNMJGHO, [Out] RigidTransform GJOJBPGNCAJ);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IBPGCIMJION(Entity HLKOPNMJGHO, [Out] float3 BJDHDJCINFH, [Out] quaternion FJFNLINEAKI);

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IBPGCIMJION(Entity HLKOPNMJGHO, [Out] RigidTransform GJOJBPGNCAJ);

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float3 EANCFEAMKEB(Entity HLKOPNMJGHO);

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KANPLDFBOJE(Entity HLKOPNMJGHO, [In] float3 CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EBNDCLGNKKO(Entity HLKOPNMJGHO, float CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float IHNMHPGKCEJ(Entity HLKOPNMJGHO);

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BHANLFOBAGB(Entity HLKOPNMJGHO, [In] float3 CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 KPEBGKNOPFL(Entity HLKOPNMJGHO);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OCMMPAGAKAI(Entity HLKOPNMJGHO, [In] float3 CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 HIOCNDJDHDG(Entity HLKOPNMJGHO);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GDHFACNHAGB(Entity HLKOPNMJGHO, [In] quaternion CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	quaternion GDDIDPBHHNI(Entity HLKOPNMJGHO);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 FGOMEHJPCCO(Entity HLKOPNMJGHO);

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void KNPEFPHMMNM(Entity HLKOPNMJGHO, [In] float3 CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void LFIBHKKKCPL(Entity HLKOPNMJGHO, float CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float JKMLLIMHDID(Entity HLKOPNMJGHO);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JGKGIKOBIKI(Entity HLKOPNMJGHO, [In] float3 CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float3 PAOJJIHDBOK(Entity HLKOPNMJGHO);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void JBLGDEIMFHI(Entity HLKOPNMJGHO, [Out] float4x4 GFJPPCILDBJ);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void BNEJCPMFHKP(Entity HLKOPNMJGHO, [In] float4x4 GFJPPCILDBJ);

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void AIOJNAHGANB(Entity HLKOPNMJGHO, [Out] float4x4 GFJPPCILDBJ);

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool ICOPDCFDDEF(Entity HLKOPNMJGHO, [Out] Transform JKDLLOIHFGK);

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void OAOPNNAGJNL(Entity HLKOPNMJGHO);

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void DHKFINJNMBP(Entity HLKOPNMJGHO, Entity LELOHBCDGCA, Entity GOOHADCPCIA);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class FFIJJLLMPMG
{
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface LJGHCCKMFAM
{
	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CDFPHILGFAO(bool ADIHFCNFDBL);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface KJODHCCNCEB
{
	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KFNAOHCLGHB(HNLGJNFDBGG OEPAIEDOBNK, IEnumerable<string> AHLLKDMIMLK);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DLHCKDPALMF(HNLGJNFDBGG OEPAIEDOBNK, IEnumerable<string> AHLLKDMIMLK);

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DJDOGBEBGLH(HNLGJNFDBGG OEPAIEDOBNK, params string[] AHLLKDMIMLK);

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LKECEEANKCK(HNLGJNFDBGG OEPAIEDOBNK, params string[] AHLLKDMIMLK);

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IDCMGDLAAOK(HNLGJNFDBGG OEPAIEDOBNK, params string[] AHLLKDMIMLK);

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NKJEAFIPEOL(HNLGJNFDBGG OEPAIEDOBNK, params string[] AHLLKDMIMLK);

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int LKJNCMAMEFC(HNLGJNFDBGG OEPAIEDOBNK);

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int EMNPPGEFDLA(HNLGJNFDBGG OEPAIEDOBNK);

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HKOELJBMBOL(HNLGJNFDBGG OEPAIEDOBNK, ICollection<string> OCONNEKPHIL);

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IDJIHNGBJAJ(HNLGJNFDBGG OEPAIEDOBNK, ICollection<string> OCONNEKPHIL);

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool CFDMIILMEJB(HNLGJNFDBGG OEPAIEDOBNK, string HAEMEJAGICK);

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LMGEMPDMOLF(string HAEMEJAGICK, AMKAHKIBNFK FIBPELGCILG);

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EMPOIHAMNPA(string HAEMEJAGICK, AMKAHKIBNFK FIBPELGCILG);

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool HDIKAOHKHIB();

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ECOBAEAOJFP(IEnumerable<string> AHLLKDMIMLK);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface IOGCCJBIPGF
{
	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World DMKILHBNLIB(string DAIOGHOMIEB = "Main");

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World BAFOGANOAJO(string DAIOGHOMIEB = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World FOFDIHBCLKF(string DAIOGHOMIEB = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World HBGGGJMLAOA(string DAIOGHOMIEB = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface LNDIPIINEOG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	World NNDHLDFCNMG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	World NEMNGFEDPOD
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	EntityManager DPEGDPAJBMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	bool DLOJNDBBAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase NGPHDBENGJH(Type NNCMOPPBEEE);
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class FLLEINHLBOI
{
	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0DB0", Offset = "0x6CBF7B0", VA = "0x186CC0DB0")]
	public static ComponentSystemBase BBDPLIIDOPP(this World HHLCCPFFGLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x2C75850", Offset = "0x2C74250", VA = "0x182C75850")]
	public static T NGPHDBENGJH<T>(this LNDIPIINEOG MMMNEIONELM) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface IJMBFJPBCOP
{
	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KNOHNBFONLJ(NativeListAsync<Entity> MNCAFIGCFOE);

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMPKIFBPGHF(MBJIAJCIBII HFFMHFMOHHM);

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DMKNGHOBFCH(NativeListAsync<Entity> MBCAEBDDKJL, bool IMFKFCEBNMG);

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OMAIABMIIFH();
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface HDLDMDGHIEE
{
	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MBMJKDICIFG(Collider IHHPCPOLGKB, [Out] OIPCNBLDOII LDKLLIGCPPD);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface DAJDLLOOBFB
{
	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FOFCMLJDLLB(HNLGJNFDBGG ELHMIJIMOPL, [Out] Collider IHHPCPOLGKB);

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject KMEFIIGEOEE(HNLGJNFDBGG LOIBDIGBNOG, GameObject FNDDMGMPCAM, Vector3 IFAKEDNBGGM, Quaternion CHAHMPCNOAC);

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKLLKNEJKOF(GameObject IHHPCPOLGKB);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider EBDPBIMOBON<TCollider>(GameObject AGJOPIPBLAM) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JEILGAHGDIN(Collider IHHPCPOLGKB);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject ONBNNBOIIEJ<TCollider>(string HBOONHFLONJ) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public enum OJNLNOJBGKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface CGDNGIBOJAB
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public struct LDPDFPBPNNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int LPLHLHAGOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GameObject FNDDMGMPCAM;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FDCHEBCIADK(HNLGJNFDBGG ELHMIJIMOPL, LMMONNPEHEM GKMBLCBHNBL, bool DHOLCCPNBAB, NKIDGEMOIMN JMDPNAMDJHM);

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNPHPJGPBBA(HNLGJNFDBGG ELHMIJIMOPL, LMMONNPEHEM GKMBLCBHNBL, bool DHOLCCPNBAB, bool IHNEHLGIOMG, bool CCHADLOPCNK);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FLFCPHGBMMB CIBDKPGBDFC(HNLGJNFDBGG MGPJOGDJPHA, List<HNLGJNFDBGG> OKBCDLGONGP);

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JEHFCEEHLKB(GameObject NDEFBGOEKJE, GameObject JPBPGAMDAKO);

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JPNHOGBCFCO(GameObject NDEFBGOEKJE, List<GameObject> PFLNJEEKIPC);

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MAOOHGBAIAH(GameObject JPBPGAMDAKO);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T EBDPBIMOBON<T>(GameObject AGJOPIPBLAM) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JEILGAHGDIN(Collider IHHPCPOLGKB);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KIMKKCECKGD(DECONOAHEMJ ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GHDDGNHPMAB(DECONOAHEMJ ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GameObject MLELNIIMIOP<T>(string HBOONHFLONJ) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool DBHFCNJECFP(Collider IHHPCPOLGKB, [Out] HNLGJNFDBGG OMFPMCIAPMD);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool PPIOPHPPKAG(HNLGJNFDBGG ELHMIJIMOPL, [Out] OIPCNBLDOII LDKLLIGCPPD);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<OJNLNOJBGKJ> HPKHFLAMKCF(Allocator MDICAPEDFAK = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Mesh[] EMBCJGFCNFP();

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int GDADJKCEEJF(LMMONNPEHEM GKMBLCBHNBL);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string KCMEIBBDEJM(LMMONNPEHEM GKMBLCBHNBL);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface DKHCPHFIDOB
{
	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FEKGBLJAANA(HNLGJNFDBGG ELHMIJIMOPL, HNLGJNFDBGG CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HNNBFGOKLCI(HNLGJNFDBGG ELHMIJIMOPL, HNLGJNFDBGG CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int IPAAMOLJEIE(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HNLGJNFDBGG JIBDJHPGHGL(HNLGJNFDBGG ELHMIJIMOPL, int EBDDHAPIAHH);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DECONOAHEMJ EOLONEFPMPC(HNLGJNFDBGG ELHMIJIMOPL, Allocator MDICAPEDFAK = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DNEFOANNDAF(HNLGJNFDBGG ELHMIJIMOPL, object KLGLJKMNAIM, HNLGJNFDBGG CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EJIHFLFNLNL(HNLGJNFDBGG ELHMIJIMOPL, object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool LKPEBPNOAID(HNLGJNFDBGG ELHMIJIMOPL, [Out] HNLGJNFDBGG CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AGOOPJFPJGI(HNLGJNFDBGG ELHMIJIMOPL, float3 CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OFHKMOILOPA(HNLGJNFDBGG ELHMIJIMOPL, [Out] float3 CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KIAAMHOPMLA(HNLGJNFDBGG ELHMIJIMOPL, float3 CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool PJKIDACNFFO(HNLGJNFDBGG ELHMIJIMOPL, [Out] float3 CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NLNMFILONNC(HNLGJNFDBGG ELHMIJIMOPL, (Quaternion rot, Vector3 moments) FLBDCMBPIHC);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool NNABLHMLDCF(HNLGJNFDBGG ELHMIJIMOPL, [Out] quaternion CJJEGFAGPAN, [Out] float3 DHJAFALAODC);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NPPHDAMBJHE(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 ILMHIEJKHIL(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 ADGDKEJMOIC(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AGPKKODFLAM(HNLGJNFDBGG ELHMIJIMOPL, float3 CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FEJLDBPBOGO(HNLGJNFDBGG ELHMIJIMOPL, float3 CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float KEOLCKNNFAO(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float PNFFOODFENH(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void DOCFMIOIEHE(HNLGJNFDBGG ELHMIJIMOPL, float CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void FEMBIHLBBHM(HNLGJNFDBGG ELHMIJIMOPL, float CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode GOGKMINDADN(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CDKPLLEALPB(HNLGJNFDBGG ELHMIJIMOPL, CollisionDetectionMode CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "25")]
	NFCFPCIBOBP CNBPAJOALBG(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void KOHPIBJBNJA(HNLGJNFDBGG ELHMIJIMOPL, NFCFPCIBOBP CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool DKIHHBOHNBB(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void HHHLMOKHDJL(HNLGJNFDBGG ELHMIJIMOPL, bool CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "29")]
	HNLGJNFDBGG OLFHOEEGBNA(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void NBAEKEBEJDH(HNLGJNFDBGG ELHMIJIMOPL, HNLGJNFDBGG CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "31")]
	HNLGJNFDBGG JEODACCEEOI(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void FPIHKLEMIHN(HNLGJNFDBGG ELHMIJIMOPL, HNLGJNFDBGG CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "33")]
	MFAANDACBHL DCEKDHIINEA(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void NKCANADCKGL(HNLGJNFDBGG ELHMIJIMOPL, MFAANDACBHL LJMICMJLNPK);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool NGGPBPPNPLP(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void PAEFDLKDNCB(HNLGJNFDBGG ELHMIJIMOPL, bool CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool CHMBBICPCKC(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void OIOKJFNPMKC(HNLGJNFDBGG ELHMIJIMOPL, bool CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints NBPNCBBLLIO(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void FNGKMEBNNHP(HNLGJNFDBGG ELHMIJIMOPL, RigidbodyConstraints CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float GEPDDPIGHPG(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void JEIAHHPELAI(HNLGJNFDBGG ELHMIJIMOPL, float CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float NEKLDBCNNAB(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void PFNDGEJFHGM(HNLGJNFDBGG ELHMIJIMOPL, float CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool PDPMJMPFGBI(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void DLDMNCFMAEC(HNLGJNFDBGG ELHMIJIMOPL, bool CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool GMGJKHLPFAE(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void FIGJKPHGOBL(HNLGJNFDBGG ELHMIJIMOPL, bool CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void BOIDGPBABGJ(HNLGJNFDBGG ELHMIJIMOPL, int CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "50")]
	MOINMCBEJEM CMFACOJJBCO(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void BCGBMKHNMNB(HNLGJNFDBGG ELHMIJIMOPL, MOINMCBEJEM CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "52")]
	BNOGFHPHCAG KEFMJIFDMAI(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void EJHEJMKBFMB(HNLGJNFDBGG ELHMIJIMOPL, BNOGFHPHCAG CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float HIEPBDKCGGL(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void LADGAFLDHKH(HNLGJNFDBGG ELHMIJIMOPL, float CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void CIDIPJAAJLK(HNLGJNFDBGG ELHMIJIMOPL, object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void KLPAHFHAKMN(HNLGJNFDBGG ELHMIJIMOPL, object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool OHLDFANDNNM(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void LLAAGCLICOF(HNLGJNFDBGG ELHMIJIMOPL, object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void HMIPJCBMGCJ(HNLGJNFDBGG ELHMIJIMOPL, object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool OJPMHPNCDPO(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool NNOALHBCEOF(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody APPLEIOEEEN(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void HKBPDAHOKOB(HNLGJNFDBGG ELHMIJIMOPL, Rigidbody BHBGFFIGMHB);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void MIICELNANPB(HNLGJNFDBGG ELHMIJIMOPL, object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void GIILIPCFCKI(HNLGJNFDBGG ELHMIJIMOPL, object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool PILPPDFMMOD(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void NNLPHBCFBOL(HNLGJNFDBGG ELHMIJIMOPL, float3 NJFMAFAPHLI);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void FLHJOIAGDKP(HNLGJNFDBGG ELHMIJIMOPL, float3 DJJLOCLIPLL);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool HAIEPDHKEDO(HNLGJNFDBGG ELHMIJIMOPL, [Out] float3 NJFMAFAPHLI);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool FFCLOOFEDFG(HNLGJNFDBGG ELHMIJIMOPL, [Out] float3 DJJLOCLIPLL);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool ECACFOIGDLA(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void NENFCBPJEMG(HNLGJNFDBGG ELHMIJIMOPL, object KLGLJKMNAIM, bool IMIKPNPKFPA);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void JEDDMNEDJCL(HNLGJNFDBGG ELHMIJIMOPL, bool JGNHHDPCPFM);

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void LFHFBJBKDKG(HNLGJNFDBGG ELHMIJIMOPL);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool KCPKMDPIBGG(HNLGJNFDBGG ELHMIJIMOPL);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface OEDAOHKMIAG
{
	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKDINALEKEC(Entity DDDJBPDJPDG);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FBBMNAFGMOH(Entity DDDJBPDJPDG);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface LNHAPBFKEAD
{
	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEMCBPEHGMF(HNLGJNFDBGG IPOCAIFIKHJ, bool KJEFBADCIFC);

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AIPPOIPGJAN(HNLGJNFDBGG IPOCAIFIKHJ, int MIDIEPCHOAJ);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public delegate void MLIIBJNILPD(KBOAFAMNMOE LFDALCNKOMD);
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public readonly ref struct KBOAFAMNMOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly DECONOAHEMJ JPDDIMCFFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly NativeArray<byte> HGIEOODHPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly NativeArray<byte> FCCAMOBGDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly NFBFCOHOKHJ BDGIFBFMLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly int NMLNMOPHPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly Type JHPGPGDJGDK;

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public DECONOAHEMJ LJPOFBKFPAD
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0xC163E0", Offset = "0xC14DE0", VA = "0x180C163E0")]
		get
		{
			return default(DECONOAHEMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7D90", Offset = "0x6CC6790", VA = "0x186CC7D90")]
	public KBOAFAMNMOE(DECONOAHEMJ JPDDIMCFFBO, NativeArray<byte> HGIEOODHPPK, NativeArray<byte> FCCAMOBGDME, NFBFCOHOKHJ BDGIFBFMLEP, int NMLNMOPHPPM, Type JHPGPGDJGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x2D1F470", Offset = "0x2D1DE70", VA = "0x182D1F470")]
	public NativeArray<T> EMLLLFCMOKK<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x2D1F4B0", Offset = "0x2D1DEB0", VA = "0x182D1F4B0")]
	public NativeArray<T> KFOGNDJJCJE<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x2D1F4F0", Offset = "0x2D1DEF0", VA = "0x182D1F4F0")]
	public (DECONOAHEMJ, NativeArray<T>, NativeArray<T>) PHNOCPFLPNG<T>() where T : struct
	{
		return default((DECONOAHEMJ, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7D60", Offset = "0x6CC6760", VA = "0x186CC7D60")]
	public IEFGHPNJHKD CEIPEOKLFAF()
	{
		return default(IEFGHPNJHKD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public interface IOHBAPJOAJN
{
	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	string NKFCIGPPBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	IOHBAPJOAJN AJKCJAANAFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	IEnumerable<IOHBAPJOAJN> MHMKEHJICBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface ANKMIKPMFAL
{
	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	IOHBAPJOAJN LBLKGLIKMMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	List<LOOLGMIMLBH> AENFBDLMHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NDHOBHMMPHH(LOOLGMIMLBH FMKCBFNEFEH, [Out] IOHBAPJOAJN HLFPHDBLGNI);

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HEDMFNKAECO(LOOLGMIMLBH FMKCBFNEFEH, MLIIBJNILPD DDMMDHGKOFJ);

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BFCLMIEHOBM(LOOLGMIMLBH FMKCBFNEFEH, MLIIBJNILPD DDMMDHGKOFJ);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public readonly ref struct IEFGHPNJHKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly KBOAFAMNMOE OIGMDCDEKEG;

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public DECONOAHEMJ LJPOFBKFPAD
	{
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0xC163E0", Offset = "0xC14DE0", VA = "0x180C163E0")]
		get
		{
			return default(DECONOAHEMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x6CC6FA0", Offset = "0x6CC59A0", VA = "0x186CC6FA0")]
	public IEFGHPNJHKD(KBOAFAMNMOE OIGMDCDEKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x6CC6BE0", Offset = "0x6CC55E0", VA = "0x186CC6BE0")]
	public DECONOAHEMJ EMLLLFCMOKK()
	{
		return default(DECONOAHEMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x6CC6CB0", Offset = "0x6CC56B0", VA = "0x186CC6CB0")]
	public DECONOAHEMJ KFOGNDJJCJE()
	{
		return default(DECONOAHEMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x6CC6D80", Offset = "0x6CC5780", VA = "0x186CC6D80")]
	public (DECONOAHEMJ, DECONOAHEMJ, DECONOAHEMJ) PHNOCPFLPNG()
	{
		return default((DECONOAHEMJ, DECONOAHEMJ, DECONOAHEMJ));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
[DefaultMember("Item")]
public interface MBKOPKLDLBJ : IEnumerable<OADCFHDMLKB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	NativeBitArray IBDCMJBCKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	NativeBitArray NIHMFALHAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	NativeArray<int> NLLBDHOMCOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	int FPAPEBLAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	OADCFHDMLKB MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	OADCFHDMLKB MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OADCFHDMLKB HGBILOGHFKN(FCGMIGBJDCN HEOHALDGBKH);

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NFBFCOHOKHJ ABEMMCJNPHF(FCGMIGBJDCN HEOHALDGBKH);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class FIDOBPDHFMD
{
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
[DefaultMember("Item")]
public interface CLLCHFLIGGM : IEnumerable<MNMHABPDCMF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	int FPAPEBLAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	MNMHABPDCMF MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MNMHABPDCMF HGBILOGHFKN(FCGMIGBJDCN HEOHALDGBKH);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NFBFCOHOKHJ ABEMMCJNPHF(FCGMIGBJDCN HEOHALDGBKH);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class NJABNLGFBNB
{
	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x2DC5540", Offset = "0x2DC3F40", VA = "0x182DC5540")]
	public static NFBFCOHOKHJ ABEMMCJNPHF<T>(this CLLCHFLIGGM OFMOBPOLDIF, EIHNHHDOPEL<T> HBOONHFLONJ) where T : struct
	{
		return default(NFBFCOHOKHJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
[DefaultMember("Item")]
public interface PHCOFAHKHAC : IEnumerable<LOOLGMIMLBH>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	int FPAPEBLAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	LOOLGMIMLBH MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LOOLGMIMLBH HGBILOGHFKN(FCGMIGBJDCN HEOHALDGBKH);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NFBFCOHOKHJ ABEMMCJNPHF(FCGMIGBJDCN HEOHALDGBKH);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class GBECIKEOBKI
{
	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x2C80590", Offset = "0x2C7EF90", VA = "0x182C80590")]
	public static MLOIIHAOOPA<T> HGBILOGHFKN<T>(this PHCOFAHKHAC OFMOBPOLDIF, FCGMIGBJDCN HBOONHFLONJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x2C7FFF0", Offset = "0x2C7E9F0", VA = "0x182C7FFF0")]
	public static NFBFCOHOKHJ ABEMMCJNPHF<T>(this PHCOFAHKHAC OFMOBPOLDIF, EIHNHHDOPEL<T> HBOONHFLONJ) where T : struct
	{
		return default(NFBFCOHOKHJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface IDKFIOJAOJP
{
	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEDMFNKAECO(FCGMIGBJDCN FMKCBFNEFEH, MLIIBJNILPD DDMMDHGKOFJ);

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFCLMIEHOBM(FCGMIGBJDCN FMKCBFNEFEH, MLIIBJNILPD DDMMDHGKOFJ);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class CBEAAOAMFJP
{
	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x2AB6360", Offset = "0x2AB4D60", VA = "0x182AB6360")]
	public static void HEDMFNKAECO<T>(this IDKFIOJAOJP POECJBDALHF, EIHNHHDOPEL<T> FMKCBFNEFEH, MLIIBJNILPD DDMMDHGKOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x2AB5FD0", Offset = "0x2AB49D0", VA = "0x182AB5FD0")]
	public static void BFCLMIEHOBM<T>(this IDKFIOJAOJP POECJBDALHF, EIHNHHDOPEL<T> FMKCBFNEFEH, MLIIBJNILPD DDMMDHGKOFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface ECAJMNLBJKC
{
	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	EMJAAHJIAIN CLKABNMHPBI
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BGIIEPAKAAP(NONPGOCJFKO BHJCOOBDBLN, NFBFCOHOKHJ FMKCBFNEFEH);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHKEHLMKIBG(NONPGOCJFKO BHJCOOBDBLN, Span<NFBFCOHOKHJ> OFMOBPOLDIF, bool KGFFJKEGLIL);

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AEBOEHBDEFM(NativeArray<NONPGOCJFKO> LBOAFPMJOCJ);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class FAADHEHAJLG
{
	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x6CBE250", Offset = "0x6CBCC50", VA = "0x186CBE250")]
	public static void JHKEHLMKIBG(this ECAJMNLBJKC LCMBKKFKIAJ, NONPGOCJFKO BHJCOOBDBLN, NFBFCOHOKHJ FMKCBFNEFEH, bool KGFFJKEGLIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public readonly struct EMJAAHJIAIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly NativeBitArray NMOMMMDOLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly NativeParallelHashMap<NONPGOCJFKO, int> POPFBJINJGI;

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public bool LOBPMBCKJOP
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x6CBE010", Offset = "0x6CBCA10", VA = "0x186CBE010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x44078D0", Offset = "0x44062D0", VA = "0x1844078D0")]
	public EMJAAHJIAIN(NativeBitArray NMOMMMDOLDB, NativeParallelHashMap<NONPGOCJFKO, int> POPFBJINJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x6CBDEE0", Offset = "0x6CBC8E0", VA = "0x186CBDEE0")]
	public bool BGIIEPAKAAP(NONPGOCJFKO BHJCOOBDBLN, NFBFCOHOKHJ FMKCBFNEFEH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface POIPNIAAHNG
{
	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CFMOCLIAKKF(HNLGJNFDBGG ELHMIJIMOPL, DIHDMLIICIG CLMKDBDPNNH);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface OMLHNJPDCMG
{
	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	NIDBICOIDOK KKLGCMIIIEE
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface INGHIHGHHAE
{
	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IAKBBBEHHGB(World HHLCCPFFGLC);

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LIDCIFPHJCF(World HHLCCPFFGLC);

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase DNNCIEMAMCH(World HHLCCPFFGLC);

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NEMFEDAGCNI(World HHLCCPFFGLC);

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HELELIPGJGP(World HHLCCPFFGLC);

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AFIEFAGEJGG(World HHLCCPFFGLC);

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BPOBNDIFLDH(World HHLCCPFFGLC);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[FACHKNACJCC(KCCBMFNNLJD.LoadInstance)]
public interface ICEGEODOPCL
{
	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLLHOBOFBJJ(HNLGJNFDBGG HDFPPGPMEIA, bool CLMKDBDPNNH);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public readonly struct HFIANJIIEBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly IEnumerable<AGHNKBGOPOJ> HEFPMFFDCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IReadOnlyList<GameObject> PIHBFBHAJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly IReadOnlyList<int> LDCHMHKFKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly IReadOnlyList<(NONPGOCJFKO, NONPGOCJFKO)> MIHGLHIGFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly int OCGMGAGIHMK;

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public bool IMCHLNDGPGF
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x6CC44E0", Offset = "0x6CC2EE0", VA = "0x186CC44E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public int IIEFEKDBNNO
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x8F2EF0", Offset = "0x8F18F0", VA = "0x1808F2EF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public IEnumerable<GameObject> LPNGCPHJFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9B0", Offset = "0xA3D3B0", VA = "0x180A3E9B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public IEnumerable<(NONPGOCJFKO src, NONPGOCJFKO dst)> IJPDLJPJDIB
	{
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x6CC48D0", Offset = "0x6CC32D0", VA = "0x186CC48D0")]
	public HFIANJIIEBB(IEnumerable<AGHNKBGOPOJ> HEFPMFFDCHB, IReadOnlyList<GameObject> PIHBFBHAJIF, IReadOnlyList<int> LDCHMHKFKMP, IReadOnlyList<(NONPGOCJFKO src, NONPGOCJFKO dst)> MIHGLHIGFLA, int OCGMGAGIHMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x6CC4540", Offset = "0x6CC2F40", VA = "0x186CC4540")]
	public (GameObject, int)[] OCGKFGBPFAO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface FKEHAAEBDFE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public class EPINLLLAAGA
	{
		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public HNLGJNFDBGG GCDGMCMKOIG
		{
			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
			[CompilerGenerated]
			get
			{
				return default(HNLGJNFDBGG);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0x171BA00", Offset = "0x171A400", VA = "0x18171BA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		public UniformTRS LHFHHECLKEG
		{
			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0x3A08860", Offset = "0x3A07260", VA = "0x183A08860")]
			[CompilerGenerated]
			get
			{
				return default(UniformTRS);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(RVA = "0x6CBE180", Offset = "0x6CBCB80", VA = "0x186CBE180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public bool ILOGBOMEFBA
		{
			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x9ECCE0", Offset = "0x9EB6E0", VA = "0x1809ECCE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0xB66330", Offset = "0xB64D30", VA = "0x180B66330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public GBFLONDPFPA KGOHJCGGJHF
		{
			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0x8869B0", Offset = "0x8853B0", VA = "0x1808869B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0x886990", Offset = "0x885390", VA = "0x180886990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public bool EAAEMDIPDCG
		{
			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x921350", Offset = "0x91FD50", VA = "0x180921350")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0x920D40", Offset = "0x91F740", VA = "0x180920D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public InventionIdData NFIFJNCPENG
		{
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x885FC0", Offset = "0x8849C0", VA = "0x180885FC0")]
			[CompilerGenerated]
			get
			{
				return default(InventionIdData);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x1EF4DD0", Offset = "0x1EF37D0", VA = "0x181EF4DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public InventionInstanceIdData DOEKINBHOCM
		{
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0xA0D7E0", Offset = "0xA0C1E0", VA = "0x180A0D7E0")]
			[CompilerGenerated]
			get
			{
				return default(InventionInstanceIdData);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0xA0C5B0", Offset = "0xA0AFB0", VA = "0x180A0C5B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x6CBE190", Offset = "0x6CBCB90", VA = "0x186CBE190")]
		public EPINLLLAAGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	bool GHLAOIPLFOI
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	bool BPBFGIDDLOI
	{
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	AGDIKICAFHN JMONNCLCADO
	{
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IDHOFPKCGFC BBLCHJFNLMI();

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDHOFPKCGFC DCAJOFKEAPO(IEnumerable<HNLGJNFDBGG> DGICEOHLFPK, [In] UniformTRS KOLEKAGOHJE);

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MMBBNBJLCDO ADMEMNBBGIB(ByteString HGPKHHKLHNN);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CBLMANCMCLM OCDNFEPOGMO(ByteString CMLPOCNMNKL, EPINLLLAAGA APDNBDIKMDG);

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CKEFBECIAPF();

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HFIANJIIEBB KGGJMDKHHEF(IEnumerable<AGHNKBGOPOJ> HEFPMFFDCHB);
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public static class POBBPFMCEFK
{
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface PDILLGDIEFA
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action DHFAHDJIEBM;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action CMOKOCGFJOC;
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public struct NDLOJBFGBBM : LIDEABGBIGA, IEquatable<NDLOJBFGBBM>
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public static readonly int ICKPLCADOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public KFELEOEDBBF DPMCJCFIMPM;

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x6CC8770", Offset = "0x6CC7170", VA = "0x186CC8770", Slot = "5")]
	public void ILDFGHALABA(KBODIELKIMK PHJKOICFNBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x6CC87A0", Offset = "0x6CC71A0", VA = "0x186CC87A0", Slot = "4")]
	public void LKLOMDOAOHF(KNCJHLBABAH GMONMLMLDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x6CC87D0", Offset = "0x6CC71D0", VA = "0x186CC87D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0xB7BA80", Offset = "0xB7A480", VA = "0x180B7BA80", Slot = "6")]
	public bool Equals(NDLOJBFGBBM AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x6CC86D0", Offset = "0x6CC70D0", VA = "0x186CC86D0", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x9696E0", Offset = "0x9680E0", VA = "0x1809696E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public struct AGHNKBGOPOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Guid HLIKNGLOMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public string MAOAEMLFGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Vector3 BJDHDJCINFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public Quaternion FJFNLINEAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public Vector3 ADJNFMJNIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int NJFJPODDODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public Dictionary<string, object> APDNBDIKMDG;

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7C70", Offset = "0x6CB6670", VA = "0x186CB7C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7AF0", Offset = "0x6CB64F0", VA = "0x186CB7AF0")]
	private static string KPOKNEGDPNI(Dictionary<string, object> IANJADGEJJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public enum OFFDDGGIDFN
{
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	SubGraphReplace,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	RestoreCreationData
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public static class FMDGLBPOJHP
{
	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x60B4220", Offset = "0x60B2C20", VA = "0x1860B4220")]
	public static bool MGIKPILKMNL(this OFFDDGGIDFN NNCMOPPBEEE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[Flags]
public enum BACMMGIIIGG
{
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	WorldPhasesMaster = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	AdditivePhases = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public interface CBLMANCMCLM : AGDIKICAFHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	GBFLONDPFPA KGOHJCGGJHF
	{
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIGKFMPFNHH();

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EDOHEGBMJDH();
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public interface AGDIKICAFHN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	IEnumerable<AGHNKBGOPOJ> KALAMNFMBBL
	{
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	HFIANJIIEBB OALEIIJMGKP
	{
		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	OFFDDGGIDFN HMGDADDECHP
	{
		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	LocalId LMAOFDFLHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	AOEELOPANAA DCDGLGCHLLC
	{
		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AAPMEMGCMFN(BACMMGIIIGG DCCFLMBFAGG);
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public interface GBFLONDPFPA
{
	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CEKGGCBGIOK(Guid CDNMICCKGIM, [Out] Guid FHIOPODCIDM);
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public interface MMBBNBJLCDO : AGDIKICAFHN, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[Flags]
public enum MAEHBOIIKHI
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public interface IDHOFPKCGFC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	AOEELOPANAA LHDMHAHEPEC
	{
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString FDJABJDDLJC();
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public enum DNAENIHLAJJ
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public delegate bool CNHHGOGNPLB(IDBPHOIBEON BHDBPGNPJDM, [In] LNHCPJIMKAE CLMKDBDPNNH);
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public delegate bool AHHCEFHPBLE<T>(IDBPHOIBEON BHDBPGNPJDM, [In] T CLMKDBDPNNH);
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface EBFIHMMDCDD
{
	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEDMFNKAECO(NFBFCOHOKHJ BDGIFBFMLEP, Type DKFFFIFLBCK, CNHHGOGNPLB KAACJKHBEMF);

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ACPOAFLHGOC(NFBFCOHOKHJ BDGIFBFMLEP, [Out] CNHHGOGNPLB KAACJKHBEMF);
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public static class FBMIGGBDPKA
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private sealed class NFFMMHOMBHI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AHHCEFHPBLE<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public NFFMMHOMBHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x46AA850", Offset = "0x46A9250", VA = "0x1846AA850")]
		internal bool GCMOCEHDJIA(IDBPHOIBEON pendingList, [In] LNHCPJIMKAE value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x2C5F9B0", Offset = "0x2C5E3B0", VA = "0x182C5F9B0")]
	public static void HEDMFNKAECO<T>(this EBFIHMMDCDD POECJBDALHF, NFBFCOHOKHJ BDGIFBFMLEP, AHHCEFHPBLE<T> KAACJKHBEMF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x6CBE3B0", Offset = "0x6CBCDB0", VA = "0x186CBE3B0")]
	public static bool ELOHEBABMBF(this EBFIHMMDCDD POECJBDALHF, IDBPHOIBEON BHDBPGNPJDM, NFBFCOHOKHJ BDGIFBFMLEP, [In] LNHCPJIMKAE CLMKDBDPNNH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface EAFFGNFFFLE
{
	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	uint LEKEEJHFJPM
	{
		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface IDBPHOIBEON
{
	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KONCDMGFKJJ(NONPGOCJFKO EMHAJHDKHDK, NFBFCOHOKHJ BDGIFBFMLEP, ReadOnlySpan<byte> HAGHECOAKEG, ReadOnlySpan<byte> NABPGHNMOIE);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILGPJFFFACM(NONPGOCJFKO EMHAJHDKHDK, NFBFCOHOKHJ BDGIFBFMLEP, ReadOnlySpan<byte> HAGHECOAKEG, ReadOnlySpan<byte> NABPGHNMOIE);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PICDNJPBIJO(NONPGOCJFKO EMHAJHDKHDK, NFBFCOHOKHJ BDGIFBFMLEP);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FMBPKCOBPJB(NONPGOCJFKO EMHAJHDKHDK, NFBFCOHOKHJ BDGIFBFMLEP, ReadOnlySpan<byte> NABPGHNMOIE);

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NJNDILNBOKK(NONPGOCJFKO EMHAJHDKHDK, NFBFCOHOKHJ BDGIFBFMLEP, Span<byte> HAGHECOAKEG, Span<byte> NABPGHNMOIE);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public static class MBHFGAHDLHH
{
	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x2D5C740", Offset = "0x2D5B140", VA = "0x182D5C740")]
	public static bool NJNDILNBOKK<T>(this IDBPHOIBEON LLNKPPECDLE, NONPGOCJFKO EMHAJHDKHDK, NFBFCOHOKHJ BDGIFBFMLEP, [Out] T HAGHECOAKEG, [Out] T NABPGHNMOIE) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x2D5C600", Offset = "0x2D5B000", VA = "0x182D5C600")]
	public static bool FMBPKCOBPJB<T>(this IDBPHOIBEON LLNKPPECDLE, NONPGOCJFKO EMHAJHDKHDK, NFBFCOHOKHJ BDGIFBFMLEP, T NABPGHNMOIE) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public enum OHMCHDBKLBP
{
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	End,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface AEJNHDMEACL
{
	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FFAGAEELABL(GIOBMJEPOPH NHGOKBHHHPE, ReadOnlySpan<byte> NGDEBDJEGEI);

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ENGJFCGACJE(uint LACDNCHIEBD, ReadOnlySpan<byte> NGDEBDJEGEI);

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLCBLNFDJNC(int MKJHEPONDBD);
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface HLLIMKFEGMO
{
	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GIOBMJEPOPH FJBIIKJDBPG(ReadOnlySpan<byte> NGDEBDJEGEI);
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface IAHMLIGFNPH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOGDNBOCPLK(GIOBMJEPOPH JODEIIFHAPK, ReadOnlySpan<byte> NGDEBDJEGEI);

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCAHHCJOBPL(ReadOnlySpan<GIOBMJEPOPH> PFLAAOFIOHP);
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public struct HFFFIMEPIHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public GIOBMJEPOPH NHGOKBHHHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public ReadOnlyMemory<byte> NGDEBDJEGEI;
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public struct GIOBMJEPOPH
{
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static GIOBMJEPOPH ECLEHMBBLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public uint ENKBOFALDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public int CPMDPHFGDOI;

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x921970", Offset = "0x920370", VA = "0x180921970")]
	public GIOBMJEPOPH(uint ENKBOFALDKE, int CPMDPHFGDOI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1D90", Offset = "0x6CC0790", VA = "0x186CC1D90")]
	public static bool LBPOCMFLOBH([In] GIOBMJEPOPH CGCFANNHAMA, [In] GIOBMJEPOPH GEGAHIEHOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1CB0", Offset = "0x6CC06B0", VA = "0x186CC1CB0", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1D60", Offset = "0x6CC0760", VA = "0x186CC1D60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1DC0", Offset = "0x6CC07C0", VA = "0x186CC1DC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1DB0", Offset = "0x6CC07B0", VA = "0x186CC1DB0")]
	public void LPCIDOHDNGA([Out] uint ENKBOFALDKE, [Out] int CPMDPHFGDOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface CBOKCHOAICF : ABDDPMGBFEO<CBOKCHOAICF>
{
	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MJGHNDKEOOO(NFBFCOHOKHJ KFBALBFDDFF, [Out] OCDLCKIMFEA OGEGPBNNHOD);
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class DBMNPHJGLPL
{
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public interface OCDLCKIMFEA
{
	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	Type ABFIAHJEBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILDFGHALABA(KBODIELKIMK PHJKOICFNBE, Span<byte> IPOCAIFIKHJ);

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LKLOMDOAOHF(KNCJHLBABAH GMONMLMLDAL, ReadOnlySpan<byte> NHGOKBHHHPE);
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public static class PODMANIOAEH
{
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public struct AJMFPCKFPAB : ISystemStateComponentData, IComponentData, IEquatable<AJMFPCKFPAB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public float3 IMADNJPJMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public float3 DJMLGGLMPDJ;

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7F50", Offset = "0x6CB6950", VA = "0x186CB7F50", Slot = "4")]
	public bool Equals(AJMFPCKFPAB AIPFCMFLDKG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[FACHKNACJCC(KCCBMFNNLJD.OMRoom)]
public interface JIOFDFGPOCM
{
	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KCHMBOFFAMH(long GDDNKICGJLM);

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LGBMFHEJMAO(NativeParallelHashSet<long> BEAEBMIAPAJ);

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NFFFHABMJCH(World HHLCCPFFGLC, NativeParallelHashMap<Guid, long> DCFGOJMPGGH);

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PCODPCMNHNL(NONPGOCJFKO BHJCOOBDBLN);

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BAPKEKGNBHH(NONPGOCJFKO BHJCOOBDBLN, [Out] Guid CGDGJFNLIEJ, [Out] long GDDNKICGJLM);

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KJOAPLGAJDJ(NONPGOCJFKO BHJCOOBDBLN, Guid CGDGJFNLIEJ, long GDDNKICGJLM);

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JKCPKAGJEDO(Guid CGDGJFNLIEJ);

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MNPBEOAFCFP(Guid CGDGJFNLIEJ, [Out] int FHALBBLJFED, [Out] int JHKMNICHONL);

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NGGIOIBNILJ(Guid CGDGJFNLIEJ, int FHALBBLJFED, int JHKMNICHONL);

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CDCLGBFCLIC(Guid CGDGJFNLIEJ);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public class HFMJLCPPHLB
{
	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public HFMJLCPPHLB()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
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
