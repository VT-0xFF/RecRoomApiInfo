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
	public class LogRegistrationIndex : IFEEDCBNDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6956C60", Offset = "0x6955460", VA = "0x186956C60", Slot = "4")]
		public override void MPPLGFJBDHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HBHJDDDNPCO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x694E4E0", Offset = "0x694CCE0", VA = "0x18694E4E0")]
	public static void NBILIAPINGP(this Rigidbody BAIDAAHJDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x694E3B0", Offset = "0x694CBB0", VA = "0x18694E3B0")]
	public static void NBILIAPINGP(this Rigidbody BAIDAAHJDBA, Vector3 JMDFINFKIPJ, Quaternion DGGFILMBGPM, Vector3 JMGCIPPDEPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct IMJGNGJFNGC : IReadOnlyList<PBDHGENIJKH>, IEnumerable<PBDHGENIJKH>, IEnumerable, IReadOnlyCollection<PBDHGENIJKH>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct EAKCOOGLGDI : IEnumerator<PBDHGENIJKH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly KLGGLOMIJJG EGHKIPPNLDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator PLIDPKHELGD;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PBDHGENIJKH APOKPICBEBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x694CAB0", Offset = "0x694B2B0", VA = "0x18694CAB0", Slot = "4")]
			get
			{
				return default(PBDHGENIJKH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x694CA30", Offset = "0x694B230", VA = "0x18694CA30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4133EF0", Offset = "0x41326F0", VA = "0x184133EF0")]
		public EAKCOOGLGDI(KLGGLOMIJJG EGHKIPPNLDD, NativeArray<LocalId>.Enumerator PLIDPKHELGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x694C970", Offset = "0x694B170", VA = "0x18694C970", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x694C9B0", Offset = "0x694B1B0", VA = "0x18694C9B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x694C9F0", Offset = "0x694B1F0", VA = "0x18694C9F0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly KLGGLOMIJJG EGHKIPPNLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> OPDFMPDAKPI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public PBDHGENIJKH EDCCAJFFILN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6952ED0", Offset = "0x69516D0", VA = "0x186952ED0", Slot = "4")]
		get
		{
			return default(PBDHGENIJKH);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6952A10", Offset = "0x6951210", VA = "0x186952A10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int JHNFKKAEDEG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public KLGGLOMIJJG GIINLOOHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int FDFCDEPBPCI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool LONMKELIFFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6952A60", Offset = "0x6951260", VA = "0x186952A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> DDEHOMLICFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x249CAA0", Offset = "0x249B2A0", VA = "0x18249CAA0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> AHHPMIAONDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x69529B0", Offset = "0x69511B0", VA = "0x1869529B0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6952E40", Offset = "0x6951640", VA = "0x186952E40")]
	public IMJGNGJFNGC(int MELGOCPNHFM, KLGGLOMIJJG EGHKIPPNLDD, Allocator KCJKALFMGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4133FB0", Offset = "0x41327B0", VA = "0x184133FB0")]
	public IMJGNGJFNGC(KLGGLOMIJJG EGHKIPPNLDD, NativeArray<LocalId> OPDFMPDAKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6952D30", Offset = "0x6951530", VA = "0x186952D30")]
	internal IMJGNGJFNGC(KLGGLOMIJJG EGHKIPPNLDD, NativeArray<Entity> CLKMHECJDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6952DA0", Offset = "0x69515A0", VA = "0x186952DA0")]
	public IMJGNGJFNGC(KLGGLOMIJJG EGHKIPPNLDD, int IDGMEKAEIMD, Allocator KCJKALFMGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6952C80", Offset = "0x6951480", VA = "0x186952C80")]
	public IMJGNGJFNGC(IMJGNGJFNGC PLAJKDOHBCE, Allocator KCJKALFMGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69528C0", Offset = "0x69510C0", VA = "0x1869528C0")]
	public IMJGNGJFNGC DBMPDAIGBHO(Allocator KCJKALFMGMC = Allocator.Temp)
	{
		return default(IMJGNGJFNGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6952970", Offset = "0x6951170", VA = "0x186952970", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6952830", Offset = "0x6951030", VA = "0x186952830")]
	public EAKCOOGLGDI ALKLFOKMKDP()
	{
		return default(EAKCOOGLGDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6952AA0", Offset = "0x69512A0", VA = "0x186952AA0", Slot = "6")]
	private IEnumerator<PBDHGENIJKH> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6952B90", Offset = "0x6951390", VA = "0x186952B90", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public struct NBBBBHELMOF : IList<PBDHGENIJKH>, ICollection<PBDHGENIJKH>, IEnumerable<PBDHGENIJKH>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct PBOLFPLFKEF : IEnumerator<PBDHGENIJKH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly KLGGLOMIJJG EGHKIPPNLDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator PLIDPKHELGD;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public PBDHGENIJKH APOKPICBEBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x695C6C0", Offset = "0x695AEC0", VA = "0x18695C6C0", Slot = "4")]
			get
			{
				return default(PBDHGENIJKH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x695C640", Offset = "0x695AE40", VA = "0x18695C640", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4133EF0", Offset = "0x41326F0", VA = "0x184133EF0")]
		public PBOLFPLFKEF(KLGGLOMIJJG EGHKIPPNLDD, NativeArray<LocalId>.Enumerator PLIDPKHELGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x695C580", Offset = "0x695AD80", VA = "0x18695C580", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x695C5C0", Offset = "0x695ADC0", VA = "0x18695C5C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x695C600", Offset = "0x695AE00", VA = "0x18695C600", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly KLGGLOMIJJG EGHKIPPNLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> OPDFMPDAKPI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PBDHGENIJKH EDCCAJFFILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6958AD0", Offset = "0x69572D0", VA = "0x186958AD0", Slot = "4")]
		get
		{
			return default(PBDHGENIJKH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6958B50", Offset = "0x6957350", VA = "0x186958B50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int HJCFDKBBGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x69585F0", Offset = "0x6956DF0", VA = "0x1869585F0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int FDFCDEPBPCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x69585F0", Offset = "0x6956DF0", VA = "0x1869585F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool HJHOCNCEBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6958A40", Offset = "0x6957240", VA = "0x186958A40")]
	public NBBBBHELMOF(int MELGOCPNHFM, KLGGLOMIJJG EGHKIPPNLDD, Allocator KCJKALFMGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x69589C0", Offset = "0x69571C0", VA = "0x1869589C0")]
	public NBBBBHELMOF(KLGGLOMIJJG EGHKIPPNLDD, Allocator KCJKALFMGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6958930", Offset = "0x6957130", VA = "0x186958930")]
	public NBBBBHELMOF(KLGGLOMIJJG EGHKIPPNLDD, int IDGMEKAEIMD, Allocator KCJKALFMGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69581D0", Offset = "0x69569D0", VA = "0x1869581D0")]
	public IMJGNGJFNGC CEPPHFJPMBB()
	{
		return default(IMJGNGJFNGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6958250", Offset = "0x6956A50", VA = "0x186958250", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6958290", Offset = "0x6956A90", VA = "0x186958290", Slot = "13")]
	public bool Contains(PBDHGENIJKH ECMCDEIDGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6958320", Offset = "0x6956B20", VA = "0x186958320", Slot = "14")]
	public void CopyTo(PBDHGENIJKH[] JAOFFCELONG, int FAIGDKFEIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6958150", Offset = "0x6956950", VA = "0x186958150", Slot = "11")]
	public void Add(PBDHGENIJKH ECMCDEIDGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6958540", Offset = "0x6956D40", VA = "0x186958540", Slot = "7")]
	public void Insert(int JBDLDJOINOF, PBDHGENIJKH ECMCDEIDGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6958680", Offset = "0x6956E80", VA = "0x186958680", Slot = "15")]
	public bool Remove(PBDHGENIJKH ECMCDEIDGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x69584B0", Offset = "0x6956CB0", VA = "0x1869584B0", Slot = "6")]
	public int IndexOf(PBDHGENIJKH ECMCDEIDGLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6958630", Offset = "0x6956E30", VA = "0x186958630", Slot = "8")]
	public void RemoveAt(int JBDLDJOINOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6958470", Offset = "0x6956C70", VA = "0x186958470", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x69580C0", Offset = "0x69568C0", VA = "0x1869580C0")]
	public PBOLFPLFKEF ALKLFOKMKDP()
	{
		return default(PBOLFPLFKEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6958750", Offset = "0x6956F50", VA = "0x186958750", Slot = "16")]
	private IEnumerator<PBDHGENIJKH> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6958840", Offset = "0x6957040", VA = "0x186958840", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface PNHPJPOKDKJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int EIKGLBDBDNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> GHNJGMPINJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PBDHGENIJKH JBMJMMCNCJJ(PBDHGENIJKH OPDFMPDAKPI);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LGNJJFHDEBB : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface NCLMPFGMGFC : LGGKLPIOPFA, JFNMNHAAKGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool MNHFNMLEMKK
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DFHBBMDAKPJ GNKAGFIEOBK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	PEABHHIDPGF PHHAFNCOPLN
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	OKFMEEFLDCN IFGGGNEDOOG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	HCJDJCLLHFI DIDGOKNAOPC
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface JFNMNHAAKGD
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool FBKFCHCPOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface GPHKGPPFDIA
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLJFICBPLCP(bool IPHHABIKCHD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[FJKCFEHMPEG(KFOAJPDPBBE.PhotonRoom)]
public interface MGAKNMDFNJO
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool KNENLABMBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHEAMNMGABH(bool JKFJGFGHFNB);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPGLCDPNGBE();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GJLKDFHHLPB(ByteString LPKKJDFMNJA);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PJCODFMCMAJ();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CPOOJKIABDP();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MOHKJOMMFBC();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KMKAHKCNGIO();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EIFIHPBLPFB();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface OKFMEEFLDCN
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	CDDEGKNDPAN GNKAGFIEOBK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	PEABHHIDPGF PHHAFNCOPLN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	EFHMBHHCDOE COBIDGJJKBE
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	OHELDAFNEMO OLFFMJPAMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	NCLMPFGMGFC BOMEKHPMBEO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	MGAKNMDFNJO JMLOMELCCII
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	KLGGLOMIJJG GIINLOOHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	MKGBMLANGKF OGGHIBHHBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	OEOPDIPHJKO BPCEAOCKIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	GLBFBOAPFBC LMOCHGJOJME
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	MJCBICEKHLC HNLHNOHFECM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	JLODODAJBKB AEHIJLPGADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	JEGJMFAEFCH GNCBFGDGAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	LMGAGOLNIJL INIMLEOGOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CJLLKMODLHF LGENEJPHBGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	FPENHCMKFBH LKKIKECHGOE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	LCLFLEADMLI CDOLDFABHIB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	OHGOHIGMODC KOMDKEKOKHP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	ALDDMJNLKBP GHPJLPBONKD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	MMNOFDDOHLI LMKPENJLLOI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NMEBOJBNPJL CPIFCLCGHJO
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	FEEEGPEJPCE IADAMGKKOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	HOLEGFNAACB MCEOAFIEDEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	IFNJDKHDAHP EDMEBCOLIGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	IIADBCPLHOP POKHBNENOJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	LHGENCGFGCM HMFKKBLBGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	INDFCJGLIBA DEKAOJDMPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	OCDKHJHJLJB HBCPKCICFBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	GLNJIKIIMBJ LENLBGPCLCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(OMBGGBALBIF))]
public readonly struct PBDHGENIJKH : IComparable<PBDHGENIJKH>, IEquatable<PBDHGENIJKH>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly PBDHGENIJKH GKJEPKMOIEE;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int OFGCEODOBIM = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int JKMNIIJBHGO = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int OCJEPLEIKMA = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int GOIANBNMJEE = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId PHFFNGDOHAF;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public KLGGLOMIJJG GIINLOOHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69494C0", Offset = "0x6947CC0", VA = "0x1869494C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public NCLMPFGMGFC BOMEKHPMBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x695BF30", Offset = "0x695A730", VA = "0x18695BF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public LocalId PAKPEGHLNBP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x695C180", Offset = "0x695A980", VA = "0x18695C180")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal HCJDJCLLHFI DIDGOKNAOPC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x695C300", Offset = "0x695AB00", VA = "0x18695C300")]
		get
		{
			return default(HCJDJCLLHFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool HMKIEFDGCCL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x695C1C0", Offset = "0x695A9C0", VA = "0x18695C1C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool ICLJKDEJOGF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x695BF90", Offset = "0x695A790", VA = "0x18695BF90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x695C440", Offset = "0x695AC40", VA = "0x18695C440")]
	public PBDHGENIJKH(KLGGLOMIJJG NLDAPOLPCDF, LocalId PHFFNGDOHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
	public BCKBAIPBKNN OAONKDKOBKD()
	{
		return default(BCKBAIPBKNN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x695BFE0", Offset = "0x695A7E0", VA = "0x18695BFE0")]
	public static LocalId IKACJOLFJPE(PBDHGENIJKH EBFOAMDGDCJ)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x695C020", Offset = "0x695A820", VA = "0x18695C020")]
	public static Entity IKACJOLFJPE(PBDHGENIJKH EBFOAMDGDCJ)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x695C060", Offset = "0x695A860", VA = "0x18695C060")]
	public static bool JAJJILMADFD(PBDHGENIJKH NKCCEIKLOPK, PBDHGENIJKH ICPBHPBDLLK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6949A80", Offset = "0x6948280", VA = "0x186949A80")]
	public static bool GLAAFHEDDBF(PBDHGENIJKH NKCCEIKLOPK, PBDHGENIJKH ICPBHPBDLLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x695C310", Offset = "0x695AB10", VA = "0x18695C310", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x695BD90", Offset = "0x695A590", VA = "0x18695BD90", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x695BCB0", Offset = "0x695A4B0", VA = "0x18695BCB0", Slot = "4")]
	public int CompareTo(PBDHGENIJKH OGFCKBADKBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "5")]
	public bool Equals(PBDHGENIJKH OGFCKBADKBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class INJBLJMBHGI
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6952FC0", Offset = "0x69517C0", VA = "0x186952FC0")]
	public static GCPCGKHJGKN GDCGACPNNPJ(this PBDHGENIJKH GHDJADLHPAA)
	{
		return default(GCPCGKHJGKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6952F10", Offset = "0x6951710", VA = "0x186952F10")]
	public static BCKBAIPBKNN CMOFMDNJILG(this PBDHGENIJKH GHDJADLHPAA)
	{
		return default(BCKBAIPBKNN);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2AD43B0", Offset = "0x2AD2BB0", VA = "0x182AD43B0")]
	public static T PAIILCHHHPM<T>(this PBDHGENIJKH GHDJADLHPAA) where T : struct, JHNFMAJOMPD
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class OMBGGBALBIF
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct HCJDJCLLHFI : IEquatable<HCJDJCLLHFI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte PFACKKBJPID;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] GBLMJGKPHME;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static KLGGLOMIJJG EEEBGKMBFGA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static NCLMPFGMGFC EOJNFBGANDH;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static KLGGLOMIJJG[] JDEAMNJKOFK;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static NCLMPFGMGFC[] ADLFPPLIJIG;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> KOKOMCLKMLO;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NCLMPFGMGFC BOMEKHPMBEO
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x694EA80", Offset = "0x694D280", VA = "0x18694EA80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public KLGGLOMIJJG KNIFGFKDMLD
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x694E900", Offset = "0x694D100", VA = "0x18694E900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x694F4C0", Offset = "0x694DCC0", VA = "0x18694F4C0")]
	static HCJDJCLLHFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xDCDC00", Offset = "0xDCC400", VA = "0x180DCDC00")]
	internal HCJDJCLLHFI(byte IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5B22530", Offset = "0x5B20D30", VA = "0x185B22530", Slot = "4")]
	public bool Equals(HCJDJCLLHFI OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x694E9E0", Offset = "0x694D1E0", VA = "0x18694E9E0", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1CFF6C0", Offset = "0x1CFDEC0", VA = "0x181CFF6C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x694F400", Offset = "0x694DC00", VA = "0x18694F400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x694EED0", Offset = "0x694D6D0", VA = "0x18694EED0")]
	private static KLGGLOMIJJG IHLGNPDIKHL(byte PFACKKBJPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x694E860", Offset = "0x694D060", VA = "0x18694E860")]
	private static NCLMPFGMGFC BPLKHCPMKEB(byte PFACKKBJPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x694F2A0", Offset = "0x694DAA0", VA = "0x18694F2A0")]
	private static object PBCOJAELCLI(byte PFACKKBJPID, object[] AHHBLMGMEGC, object HLCNDDGKJJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x694EEC0", Offset = "0x694D6C0", VA = "0x18694EEC0")]
	private static int HCJNIMGFCCC(byte PFACKKBJPID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x694F290", Offset = "0x694DA90", VA = "0x18694F290")]
	private static int NMCNHKCBLOH(byte PFACKKBJPID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x694EF70", Offset = "0x694D770", VA = "0x18694EF70")]
	private static (int, int) KMLNNGILBJG(byte PFACKKBJPID)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x694E850", Offset = "0x694D050", VA = "0x18694E850")]
	private static byte BHJNKPKPLKK(int MBDJOBPGDCG, int JBDLDJOINOF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x694EFF0", Offset = "0x694D7F0", VA = "0x18694EFF0")]
	internal static HCJDJCLLHFI MPPLGFJBDHC(NCLMPFGMGFC MHONPLDGBPJ, KLGGLOMIJJG BFPFOCJJAFO)
	{
		return default(HCJDJCLLHFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x694E660", Offset = "0x694CE60", VA = "0x18694E660")]
	internal static void BBPOCOEOMDG(HCJDJCLLHFI PFACKKBJPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x694EB60", Offset = "0x694D360", VA = "0x18694EB60")]
	private static void FMEDGLHIHGP(int MELGOCPNHFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface ENEJHHBMCNE
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOKCDJOEDDA();

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HGIFLLLEKMA(bool PKAECNKKAMO);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FJGGEKHAJNI(GameObject DLBGNHFNDNP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface EECLJEMFCPH
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Guid CAOEHEAMHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LNMNCCGLMDJ(Guid BFLJDDKANKN, Guid GOFMHFABAJA);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task GPNLAEDDONC(PBDHGENIJKH KDDJLNDKEGP);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IAFHKJEDFJB(PBDHGENIJKH CKKNFOBALJL, PBDHGENIJKH GGJNHHDMGON, [Out] Vector3 DBPJNNMJCKO, [Out] Quaternion OOJJBHEGACK);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IGPJAIHGMJF(DJOCLHOLMAO CLNFPFJDJMO, Vector3 DBPJNNMJCKO, Quaternion OOJJBHEGACK);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ONKIEMPIOCL(PBDHGENIJKH MNOMNFHHAOE, [Out] Vector3 CELGDALMLGD, [Out] Quaternion KBHGBLHKLNH);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HLFBGGIOFCB(Guid IKNLCPDILAM, bool JKFJGFGHFNB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface DDAOIPEKKCM
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HNFOPGCJFMA(IMJGNGJFNGC OPDFMPDAKPI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface BFKPCGEIEDD
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLEIJJAIMGN(GameObject CFKHPNKCJEB, GameObject ALINHIHLABE, int HLIOKOODJMM);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface PEABHHIDPGF
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	ENEJHHBMCNE KOJDANCIAOL
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	NHOJNIAGGFL CBINMLINKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	NFKFONNBKAA DKBAGFOMCJC
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	GOPCKODCMDJ MAHIMADKFFN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	OJKAOPHFILF BLFMPCBOACL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	IHIHHDPCKDL CIKGNAAKNHE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	DAGGAHINCGD BAIGBJJKHFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	DFIIHJJPOHA HEGKJKOGJNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	CMOONAKLCAC EDCMKLEGKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface BJMAAEMPPAP
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBKMHCLONNB(Action BMOCGPMNBAF, bool HHJFPDENPMP);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AMEEDPPEICN(string GCDLMFGKKMH);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int PIMPPGEHIKB(string GCDLMFGKKMH, int HLCNDDGKJJF);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface NHOJNIAGGFL
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string IEGLEEDKDPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] ECBFFJBHJGP(IEnumerable<IJMMEEILPJF> HKEBJNJIKEN);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HCMHNJONLKP(GameObject DLBGNHFNDNP, [Out] GCPCGKHJGKN[] NNGIKAPCELN);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NBIIKLHOJBI(GameObject DLBGNHFNDNP, [Out] int OKBNEOFNLOP, [Out] MLDAFHLMJPK HLCODDJIAJC);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GCDLKIMIFND OJPEOBDFPAN(IJMMEEILPJF LOGLBHMJLPF);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GCDLKIMIFND OJPEOBDFPAN(string EDHNNIHIAFG, GCPCGKHJGKN[] DLEBFLGACBD, Vector3 GBKEBGLIOFD, Quaternion LOMIHBHMPMH, Vector3 KEONANJCBKH);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GCDLKIMIFND JNCLKGMOEMD(string EDHNNIHIAFG, GCPCGKHJGKN[] DLEBFLGACBD, Vector3 GBKEBGLIOFD, Quaternion LOMIHBHMPMH, Vector3 KEONANJCBKH);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject JEHKNAACKHO(string EDHNNIHIAFG);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MNKODIDINFC(GameObject LHAEIILHFBL, bool GBHPPBEDPMD);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FNJOLHBLADA(GameObject DLBGNHFNDNP, bool ILKGGILGEGL, bool PFCEHOJDHAI);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class PBBOHHOFJLA
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x695BB40", Offset = "0x695A340", VA = "0x18695BB40")]
	public static GCDLKIMIFND OJPEOBDFPAN(this NHOJNIAGGFL NALLEMLECHL, Vector3 GBKEBGLIOFD, Quaternion LOMIHBHMPMH, Vector3 KEONANJCBKH, params GCPCGKHJGKN[] NNGIKAPCELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x695B9D0", Offset = "0x695A1D0", VA = "0x18695B9D0")]
	public static GCDLKIMIFND JNCLKGMOEMD(this NHOJNIAGGFL NALLEMLECHL, Vector3 GBKEBGLIOFD, Quaternion LOMIHBHMPMH, Vector3 KEONANJCBKH, params GCPCGKHJGKN[] NNGIKAPCELN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface NFKFONNBKAA
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBAIBDLDJIO(bool JKFJGFGHFNB);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface GOPCKODCMDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool JKCGPBFNHCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool PNENFEEBKGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool OIBGCEEINKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	int PMMEKLFPHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool JKPJCKPPDGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DFFOFFLOLAH(object EMIMPCIEFOP);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JKMDKJMHFFJ(object EMIMPCIEFOP);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NMNGODMGFKG(object LFFBLPMMGND);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CHJEDINDBPH(object LFFBLPMMGND);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ViewId BBNOMOJHAKG(GameObject IGGPONJBFJL);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FKCOCEGPNDH(NativeArray<ViewId> JCBLDIOLOIK);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ILIEBLLOLMH(NativeArray<ViewId> KBMGFFOPPHI);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JBNPKBOEDEO();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PJKNDDMCJJO(uint GDOAEOCAAIN, ReadOnlySpan<byte> KCGGBIDAGDH, bool JIODBICIIPI = false);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PJKNDDMCJJO(uint GDOAEOCAAIN, ReadOnlySpan<byte> KCGGBIDAGDH, ReadOnlySpan<byte> LHMKNEHBPBA, bool JIODBICIIPI = false);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DJGBBNHEGMF(Func<int, bool, int> HDILBHIODGL, bool MHPHMNMBFEI);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HFHDOOMLIKK(object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JLJAJKMGBDE(object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	uint MDOCGOMKGBP(uint JEOLOLCNKCP);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class CDOKKGAPCLD
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x694A3E0", Offset = "0x6948BE0", VA = "0x18694A3E0")]
	public static LIGMKFKEKGO OBBAHBFBNCA(this GOPCKODCMDJ FEIKIKEAPDP, object OECMOOGGOOF)
	{
		return default(LIGMKFKEKGO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct LIGMKFKEKGO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private GOPCKODCMDJ FEIKIKEAPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private object OECMOOGGOOF;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6956B10", Offset = "0x6955310", VA = "0x186956B10")]
	public LIGMKFKEKGO(GOPCKODCMDJ FEIKIKEAPDP, object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6956AC0", Offset = "0x69552C0", VA = "0x186956AC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface OJKAOPHFILF
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GPOKMKDHBEO(GameObject DLBGNHFNDNP);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface IHIHHDPCKDL
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct NILHBKMAIIC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private IHIHHDPCKDL NDOGIDEBAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Task GECIOHOBBCH;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Task FCHPNCEPPCO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x8B90C0", Offset = "0x8B78C0", VA = "0x1808B90C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6959BF0", Offset = "0x69583F0", VA = "0x186959BF0")]
		public NILHBKMAIIC(IHIHHDPCKDL NDOGIDEBAHC, CancellationToken ODNHMAMKFFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6959BA0", Offset = "0x69583A0", VA = "0x186959BA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFNFNLJLBKO(string CLBGCJICGJG, float EKBDOJGAIJB = 5f);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KKLIKLMANFF(CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DAFNJIEAIGA();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class FHICIIGCLIK
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x694D3F0", Offset = "0x694BBF0", VA = "0x18694D3F0")]
	public static IHIHHDPCKDL.NILHBKMAIIC EEDEGJNFKAJ(this IHIHHDPCKDL FEIKIKEAPDP, CancellationToken ODNHMAMKFFP)
	{
		return default(IHIHHDPCKDL.NILHBKMAIIC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface LOCIDDAPIIL
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LBDAEFHKENK(GameObject DLBGNHFNDNP);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKADJDAAIIK(GameObject DLBGNHFNDNP);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BECEIAGFLKM(int MALOKOEKACK);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object NAEACJMEDAH(PBDHGENIJKH PHFFNGDOHAF, GameObject DLBGNHFNDNP, Action<PBDHGENIJKH, int> GLJPAFELCNE);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EHNBMCKGHLG(GameObject DLBGNHFNDNP, object IDBJHJMMGOE);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface KFGIBBODGNA
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool KHKMBFHOCHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate EMHAKNPIHEJ(KIAPKLIOIHL.NECCDFBFDNM JNKKGHAILFN, Action<KIAPKLIOIHL.NECCDFBFDNM> GLJPAFELCNE);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void COOIGFPKADL(KIAPKLIOIHL.NECCDFBFDNM JNKKGHAILFN, Delegate GLJPAFELCNE);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate HLPJFGJCMII(KIAPKLIOIHL.NECCDFBFDNM JNKKGHAILFN, Action<KIAPKLIOIHL.NECCDFBFDNM> ABBNLMLLKCI);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AJJICKEMHOM(KIAPKLIOIHL.NECCDFBFDNM JNKKGHAILFN, Delegate GLJPAFELCNE);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OPKOGIKNNAH(KIAPKLIOIHL.NECCDFBFDNM JNKKGHAILFN);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KIAPKLIOIHL.NECCDFBFDNM DIPCIAOBDON(GameObject DLBGNHFNDNP);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface DAGGAHINCGD
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	int OADKIMBHAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	int DLLBDFGHFPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int JIEIINHANHO(GameObject DLBGNHFNDNP);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PJEONOEMGAB([Out] Vector3 GBKEBGLIOFD);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HDPPNEFCIFE();

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PBDHGENIJKH AMFHMCBGAIA(int MALOKOEKACK);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface DFIIHJJPOHA
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool KNENLABMBKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface KOEGFDDLIHM
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	AJDODENHINP JHGADCHDDLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	DJDIAABNLJL DAEACMNLPDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GEIOOJNOHGC(Transform MCHMJHAODPL);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NNODPPCNJMA(Transform MCHMJHAODPL, CLCEIFGJJPL NAJGKDAAOHF);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GJCNLDJBOGJ(Transform MCHMJHAODPL, NIICFFIKABB DCBFCIHPHNB);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface HGLOHCNIACB
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface CMOONAKLCAC
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action IFEHPJMFLAL;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FJGGBMLBEIH(IMJGNGJFNGC JCFHPIMLKPN, bool MPHCENDLGCO);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface EGHFMLOEKIF
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCACBIPPHPP();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface ENKDPJOMHCF
{
	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MLDAFHLMJPK KPCKOHOBCIO(GameObject IGGPONJBFJL);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LBGELACKJAM(GameObject DLBGNHFNDNP, EOKNLIPIJFA MPENCCDLIFI, OMLOEIALCCH FEIFLJKIHEL);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DBJDKPDHAHB(PBDHGENIJKH PHFFNGDOHAF, bool LGIBFAANBII, float3 PICCIFPBMFE, quaternion FIHLOGBOLIP);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JMJKHOPPEFN(BCKBAIPBKNN ECKNMNLLOJH, BCKBAIPBKNN LFFBLPMMGND, JBMHKOHEBLO NBMJJDIPDAE);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ECPPLJBGIEK(BCKBAIPBKNN ECKNMNLLOJH, JBMHKOHEBLO NBMJJDIPDAE);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FFDCHEJOHKF(IMJGNGJFNGC EDHCJFEMMBB);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct HHMHIMFLICP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly BGCEIGAOMNB CKMEAPHLBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly BGCEIGAOMNB KLHAFEOKDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly uint MKOJJMJNBMK;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6950110", Offset = "0x694E910", VA = "0x186950110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct KICFDEFECIA
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly MMJHHDEPGMK LPJFGGMIIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly HHMHIMFLICP BMOCGPMNBAF;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x694CB00", Offset = "0x694B300", VA = "0x18694CB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct EJLLBCFMHDG
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static readonly MMJHHDEPGMK LPJFGGMIIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal readonly HHMHIMFLICP BMOCGPMNBAF;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x694CB00", Offset = "0x694B300", VA = "0x18694CB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct CNICJEMLMBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal readonly uint MKOJJMJNBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal readonly bool AHJCDMBNCLP;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x694A6B0", Offset = "0x6948EB0", VA = "0x18694A6B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct BGCEIGAOMNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal int MFLLOPOPNNG;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x694A1A0", Offset = "0x69489A0", VA = "0x18694A1A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface MBEHMGANMIP
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	OHHJHKANCNK GMGCPGCHIEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public enum HNDFGMECDBD
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
public interface GCDLKIMIFND : CGJEGPJHHCM
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	HNDFGMECDBD BKCAPMPLDOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool PNFMMFMGCPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	GameObject DLBGNHFNDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<GCDLKIMIFND> KKLEANEFKPH;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(EFHMBHHCDOE NGKMHGNGADJ, PBDHGENIJKH MLJIGDGHOBO);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool PMFLFOKDMAH);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class KPOOFIDKLNI
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6956940", Offset = "0x6955140", VA = "0x186956940")]
	public static bool CDBAJNFOGDA(this GCDLKIMIFND ALCMDLBDDMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6956A70", Offset = "0x6955270", VA = "0x186956A70")]
	public static bool OHDLGDBBFAC(this GCDLKIMIFND ALCMDLBDDMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6956990", Offset = "0x6955190", VA = "0x186956990")]
	public static bool DDFILCLFKFJ(this GCDLKIMIFND ALCMDLBDDMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x69569E0", Offset = "0x69551E0", VA = "0x1869569E0")]
	public static bool MNHFNMLEMKK(this GCDLKIMIFND ALCMDLBDDMK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface CGJEGPJHHCM
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool ICIDCBOPNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	PBDHGENIJKH PLPBANMLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
internal interface BFJLDACGNJP
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<IFPPOKJFEIG> JFIAMBNLODG;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface ANHOOAAKBHH
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface BDKHBBKLLHP
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(DACPPDODOBJ AMCEPLIPKHL);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface DACPPDODOBJ
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	GameObject DLBGNHFNDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	Transform MCHMJHAODPL
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	BLIBIMCHNOD JMFJPLIODAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool BFHAEEABGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GHNOIKOKHFJ(BLIBIMCHNOD LHMMDMHNIJC);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface BLIBIMCHNOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000060")]
	PBDHGENIJKH PLPBANMLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	Rigidbody CBNKMMHNKGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	DACPPDODOBJ EAGOIIFAHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	GameObject ADPKHONGLGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	Transform BNMINHJAICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	BLIBIMCHNOD GFHKLHCNBBP
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	BLIBIMCHNOD BENFNHCGCFM
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	int CFJAMIEIIBB
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	bool OPKOGIKNNAH
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool KJOHMFNDCMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	FCAMINOCOJA MEKONANKKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "31")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	JILCCGMFDPF LAPJIFHJGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	float IALJDEHLOFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "35")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 HODGLLMGNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 JKGLJJAHGKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 IHOIHNGCNAI
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 AFOCIAPHPBA
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool IPNDPAFCMME
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool PEINGDFJLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool OMMLNEFLEBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	Vector3 EFINPOPLKCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Vector3 IAHMJIMOAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 MJMHHNPDCGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "50")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 BJAEOLLMDAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	float NOIFPIGGDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float BHAGJPJDMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 LCEENPPGPDE
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Quaternion CPJKDPJHJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float FLCCBCFCFAC
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	float LHMGKIPGNDI
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	bool GJJJAFNFPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	COGJEJCHONG CNNIDAAFDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	bool CLMLPLJBEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	Transform GMOCABCHDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Vector3 FMHDCFKEJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	float OAINCPHPOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	float LCJAICMGMLE
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	Quaternion FIIADFGBHNE
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	Vector3 NPNMPABLGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Quaternion NIILCMPNFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	RigidbodyConstraints MBGDFDDGMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	bool AHPJGJHNNDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	CollisionDetectionMode DECMOOCMCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool IHMAEHBDBEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event JDCBCOFMANP KGHFDCJBICF;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event JDCBCOFMANP DNJPMAKDPMO;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event JDCBCOFMANP GAHOJLCEMPA;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event JDCBCOFMANP DEPFNDDBBKG;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event JDCBCOFMANP IDNGIOKNFLN;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event JDCBCOFMANP HCCJABEAMEB;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event JDCBCOFMANP JFDIAIEIKDI;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event OIOCDFIICEJ KCMDBECEJLM;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<LPELNIAIFBH, LPELNIAIFBH> PFPGJFIOAJB;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	BLIBIMCHNOD HDBMOBPFKBC(int JBDLDJOINOF);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void JBEJPGIKMFB((Quaternion rot, Vector3 moments) EJDPIICEIBJ);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void JGNDLDOBBPO();

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void IFABOCHGFJA();

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void NMEBMIBGGOF();

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void KOFDMENNLIJ();

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void BFFDCAOPJND(BLIBIMCHNOD IPHHABIKCHD, bool NEAOAKEDNKH = false);

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void NDCGKMFHAIL(object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void MBPCNLEIAFL(object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 OAMALPNFMIN(Vector3 FGJLCJLJNIH);

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "95")]
	Vector3 IEAGFGBBACO(Vector3 JDJKHLHCBKJ);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void KOHJLEDPKOC();

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void PFAHOCILJJD();

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void HILPLCDGDCA();

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void FCDJKPADNPE(Vector3 CANJCDKNECM, Vector3 HGAJHDLFDOD);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void JBIFLKBLOIG(Vector3 BBBBLJNFIIN, Vector3 MHHCOPPDPMM);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void HKNCONIMPPD(Vector3 KCCHHOLMGED);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void GEKDDCOAMGG(HHDEFPFLNPK IEKDAIGCGCD, Vector3 IGIFOANCFEK, float GMIEKGDCBNK, float FPFOKJKKFIH = 8f, float ICICHGCMKLL = 1f);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void BNGNNEOHKDB(DPAMEKGJPIB FGKFDJCPHID, Vector3 EJPFIPNBFHE, float JGAPKPCMPGB = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void HNJOBGDEAPL(DPAMEKGJPIB FGKFDJCPHID, Vector3 LOMIHBHMPMH, float OODKBJMFLAN = 7f, float KLHDNNAMDKE = 1f);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "105")]
	Vector3 HCENJEONKBP(Vector3 IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "106")]
	Vector3 EELPKIMHCHN(Vector3 IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void GFMKFDINHOF();

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void EMKIINPCIPB(BLIBIMCHNOD FHOCPFNFMCA, object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "109")]
	void PKDKAGJMDCM(object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void ICLCACMFEHF();

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void BCJNOAFHLBA();

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void AKKFJHEEDKA();

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "113")]
	bool NDMHBGEBIJP();

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void ACGLIAEOOFN();

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void MIMJFPFEPLD(object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "116")]
	void ADCENDCGKGM(object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void OBJFMIGLMGM(object OECMOOGGOOF, bool KCOPEBDIOPC);

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void KNDFCAFEKMF(Vector3 ELGCFIEOFEO, Quaternion DCKHBNEMBML);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void FAJOOGIGOCH(Vector3 AEGPEJCEFDG, Quaternion LDPFGICFDIG);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "120")]
	bool CNDLDOGPJGP(float FMCCCFIPNDL);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void PKOLJANMAKF(object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void HDFPLJMCNJE(object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void OOMOLILEKIP(object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void LNGMHNFFFAF(object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void OMGLNCEALOI(Vector3 AIDFLNGPPBP, ForceMode FAEAIBHJCJL = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void NCCHCEKONBH(Vector3 AIDFLNGPPBP, Vector3 GBKEBGLIOFD, ForceMode FAEAIBHJCJL);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void JFGEJOBBMAO(Vector3 MODELFPBHLJ, ForceMode FAEAIBHJCJL = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void KFBMLPCOLML(Vector3 MODELFPBHLJ, ForceMode FAEAIBHJCJL = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "129")]
	bool CKPKMOKPEAD(Vector3 NHPNENOFEDP, [Out] RaycastHit ODIFANJGAKA, float NGOKPHBDKPG);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void ODFKKDADEDP();
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface JILCCGMFDPF
{
	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EDDFMMGHGEM(Vector3 JJDCNFJBJFA);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBHJNOKPBPB(Vector3 HLMGJIDHMFL);

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IEIJIEJMLMI(Vector3 JJDCNFJBJFA);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ALIFHMNIFBD(Vector3 HLMGJIDHMFL);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface FCAMINOCOJA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 IEMPFFKFJDF();

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 ABDLIHIONAE();
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public delegate void JDCBCOFMANP(DACPPDODOBJ NCEJCIIIEGI);
[Cpp2IlInjected.Token(Token = "0x200003E")]
public enum PABKJCPCBKH
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
[Cpp2IlInjected.Token(Token = "0x200003F")]
public enum HHDEFPFLNPK
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
[Cpp2IlInjected.Token(Token = "0x2000040")]
public delegate void OIOCDFIICEJ(DACPPDODOBJ NCEJCIIIEGI, bool NEAOAKEDNKH = false);
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum DPAMEKGJPIB
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct IFFGFEPPNHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Rigidbody BBEDNPEOIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public object HLJNKLNAEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector3 AFMBELFAFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector3 JKPHILDBACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public AAOCMHJKPKO APONHBLBCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool PBFJIKAJJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool JGAOPAGFGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool HFNFGIBIBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool LAENGAJJAON;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface FEKBJBEJNCD : MAEJGIEPEED<GCPCGKHJGKN>, GEGNBKMOPOM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface DIPDAJKIPFL<T> : OMOGHJEGGBA<GCPCGKHJGKN, T>, MAEJGIEPEED<GCPCGKHJGKN>, GEGNBKMOPOM, IDisposable, FEKBJBEJNCD where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class CGCOFACLHEM
{
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x28ADB30", Offset = "0x28AC330", VA = "0x1828ADB30")]
	public static bool GIPAEIFMNNK<T>(this MAEJGIEPEED<GCPCGKHJGKN> ABBFPCPEMEH, GCPCGKHJGKN DLEBFLGACBD, [Out] T IPHHABIKCHD) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2834770", Offset = "0x2832F70", VA = "0x182834770")]
	public static bool KAMKODPJIMO<T>(this MAEJGIEPEED<GCPCGKHJGKN> ABBFPCPEMEH, GCPCGKHJGKN DLEBFLGACBD, [In] T MKIPENAKAOC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface LOBJACNONFA : MAEJGIEPEED<PBDHGENIJKH>, GEGNBKMOPOM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface KEHGOMKFBPK<T> : OMOGHJEGGBA<PBDHGENIJKH, T>, MAEJGIEPEED<PBDHGENIJKH>, GEGNBKMOPOM, IDisposable, LOBJACNONFA where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class AGMCNNBNMMM
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x28301C0", Offset = "0x282E9C0", VA = "0x1828301C0")]
	public static T NBGKOOJKKKA<T>(this MAEJGIEPEED<PBDHGENIJKH> ABBFPCPEMEH, PBDHGENIJKH PHFFNGDOHAF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x2834770", Offset = "0x2832F70", VA = "0x182834770")]
	public static bool KAMKODPJIMO<T>(this MAEJGIEPEED<PBDHGENIJKH> ABBFPCPEMEH, PBDHGENIJKH PHFFNGDOHAF, [In] T MKIPENAKAOC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct GFKAPELJMJG : IComparable<GFKAPELJMJG>, IEquatable<GFKAPELJMJG>
{
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly GFKAPELJMJG GKJEPKMOIEE;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly GFKAPELJMJG CFPIBNKDHHP;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly GFKAPELJMJG NJPGCKIDGFK;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly GFKAPELJMJG BJFADFMMKJC;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly GFKAPELJMJG CCMIINLOCIB;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly GFKAPELJMJG FONKJKEPMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public int CFDBFCCMKIM;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool MBOFOFIFOJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x694D590", Offset = "0x694BD90", VA = "0x18694D590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public int LNKJMDJDLNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x694D690", Offset = "0x694BE90", VA = "0x18694D690")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0xA36A50", Offset = "0xA35250", VA = "0x180A36A50")]
	public GFKAPELJMJG(int JBDLDJOINOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x694D630", Offset = "0x694BE30", VA = "0x18694D630", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x694D5A0", Offset = "0x694BDA0", VA = "0x18694D5A0", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x9A35E0", Offset = "0x9A1DE0", VA = "0x1809A35E0", Slot = "5")]
	public bool Equals(GFKAPELJMJG OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x1A170B0", Offset = "0x1A158B0", VA = "0x181A170B0", Slot = "4")]
	public int CompareTo(GFKAPELJMJG OGFCKBADKBE)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0xE0B770", Offset = "0xE09F70", VA = "0x180E0B770")]
	public static GFKAPELJMJG IKACJOLFJPE(int JBDLDJOINOF)
	{
		return default(GFKAPELJMJG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0xE0B770", Offset = "0xE09F70", VA = "0x180E0B770")]
	public static int IKACJOLFJPE(GFKAPELJMJG BCCOFCDHGPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x694D6A0", Offset = "0x694BEA0", VA = "0x18694D6A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct BCKBAIPBKNN : IEquatable<BCKBAIPBKNN>, CGJEGPJHHCM
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly BCKBAIPBKNN HOCKBMNCBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public PBDHGENIJKH PLPBANMLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0", Slot = "6")]
		get
		{
			return default(PBDHGENIJKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public INOMIAAGGLN BNMINHJAICK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(INOMIAAGGLN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public GGKNEECAHMB OGGHIBHHBBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(GGKNEECAHMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private KLGGLOMIJJG GIINLOOHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x69494C0", Offset = "0x6947CC0", VA = "0x1869494C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public GameObject DLBGNHFNDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6949C90", Offset = "0x6948490", VA = "0x186949C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public GCPCGKHJGKN NGNGFDKJMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6949AA0", Offset = "0x69482A0", VA = "0x186949AA0")]
		get
		{
			return default(GCPCGKHJGKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public NKJKJPLFHNG LCEFCDJPEJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6949820", Offset = "0x6948020", VA = "0x186949820")]
		get
		{
			return default(NKJKJPLFHNG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public MLDAFHLMJPK MANMOFKKPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6949E20", Offset = "0x6948620", VA = "0x186949E20")]
		get
		{
			return default(MLDAFHLMJPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool CNLJIEMJJLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6949BE0", Offset = "0x69483E0", VA = "0x186949BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool NKIGDKJEPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6949780", Offset = "0x6947F80", VA = "0x186949780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool CDBAPEHCBIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6949680", Offset = "0x6947E80", VA = "0x186949680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool FLDOHMGBBNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6949BC0", Offset = "0x69483C0", VA = "0x186949BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool FILGNDGMMCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6949800", Offset = "0x6948000", VA = "0x186949800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool OLPNMDNJGAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6949C70", Offset = "0x6948470", VA = "0x186949C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool MFEHNLEOPIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6949A40", Offset = "0x6948240", VA = "0x186949A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool DFPDEJPMHOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6949740", Offset = "0x6947F40", VA = "0x186949740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool DBHFAAEJOEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x69497A0", Offset = "0x6947FA0", VA = "0x1869497A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public DCDBKGFALLD MNPNMIJHAHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(DCDBKGFALLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public APJCGOPHCCD DGCJFJMBEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(APJCGOPHCCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public MAOFNOEDLKK LGENEJPHBGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(MAOFNOEDLKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public DDKBEPHLACF GCAGICKIIBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(DDKBEPHLACF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public IMHHMBOCAAA INIMLEOGOPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(IMHHMBOCAAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public CKDOGDBFLKD JBOACJFCOEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(CKDOGDBFLKD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public DJOCLHOLMAO GJBPILDPNKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(DJOCLHOLMAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public HGKAGFMGFLA ADIEDHLMLPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(HGKAGFMGFLA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public MMAJILHPKHP LIDJGIDLGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(MMAJILHPKHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public NFGIDBPCJAA JAEMEJKBHHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(NFGIDBPCJAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public MDLLKKDBDHN NHJDDJKJAJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(MDLLKKDBDHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public IBLIOBEPPJN HJAJBIKBMOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(IBLIOBEPPJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool CDBAJNFOGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6949950", Offset = "0x6948150", VA = "0x186949950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool NGEIFPMHIAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6949C30", Offset = "0x6948430", VA = "0x186949C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool LDMKAOJABHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x69497C0", Offset = "0x6947FC0", VA = "0x1869497C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private bool COIEJDPNBBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
	public BCKBAIPBKNN(PBDHGENIJKH PHFFNGDOHAF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6949B40", Offset = "0x6948340", VA = "0x186949B40")]
	public static bool IKACJOLFJPE(BCKBAIPBKNN IPHHABIKCHD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x8E2600", Offset = "0x8E0E00", VA = "0x1808E2600")]
	public static PBDHGENIJKH IKACJOLFJPE(BCKBAIPBKNN IPHHABIKCHD)
	{
		return default(PBDHGENIJKH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6949BB0", Offset = "0x69483B0", VA = "0x186949BB0")]
	public static bool JAJJILMADFD(BCKBAIPBKNN NKCCEIKLOPK, BCKBAIPBKNN ICPBHPBDLLK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6949A80", Offset = "0x6948280", VA = "0x186949A80")]
	public static bool GLAAFHEDDBF(BCKBAIPBKNN NKCCEIKLOPK, BCKBAIPBKNN ICPBHPBDLLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x69498C0", Offset = "0x69480C0", VA = "0x1869498C0", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(BCKBAIPBKNN OGFCKBADKBE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x8E2600", Offset = "0x8E0E00", VA = "0x1808E2600")]
	public static BCKBAIPBKNN IKACJOLFJPE(PBDHGENIJKH ACMFILFJLEL)
	{
		return default(BCKBAIPBKNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6949EC0", Offset = "0x69486C0", VA = "0x186949EC0")]
	public NPBNJEHNJDF PAIOPNNHHHI()
	{
		return default(NPBNJEHNJDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6949F40", Offset = "0x6948740", VA = "0x186949F40")]
	public JOKDEEFIKCA PAOOEFLHNKN()
	{
		return default(JOKDEEFIKCA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6949B60", Offset = "0x6948360", VA = "0x186949B60")]
	public MGIMJBEMNBJ IKGHGFEFKFP()
	{
		return default(MGIMJBEMNBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6949C00", Offset = "0x6948400", VA = "0x186949C00")]
	public FGFDHCEIOPD LFGNPEOLFMF()
	{
		return default(FGFDHCEIOPD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x69496A0", Offset = "0x6947EA0", VA = "0x1869496A0")]
	public void CMOFMDNJILG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6949F70", Offset = "0x6948770", VA = "0x186949F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct DJOCLHOLMAO : IEquatable<DJOCLHOLMAO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public PBDHGENIJKH PLPBANMLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(PBDHGENIJKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private KLGGLOMIJJG GIINLOOHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x69494C0", Offset = "0x6947CC0", VA = "0x1869494C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private OKFMEEFLDCN IFGGGNEDOOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x694C850", Offset = "0x694B050", VA = "0x18694C850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private OHGOHIGMODC BLPFADDDEFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x694C2C0", Offset = "0x694AAC0", VA = "0x18694C2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool HFGBBNLJDFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x694C7C0", Offset = "0x694AFC0", VA = "0x18694C7C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Guid FLHDCAEDJPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x694C440", Offset = "0x694AC40", VA = "0x18694C440")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool LMLPMFOIDCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x694C600", Offset = "0x694AE00", VA = "0x18694C600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Guid OCEMBOOHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x694C080", Offset = "0x694A880", VA = "0x18694C080")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
	public DJOCLHOLMAO(PBDHGENIJKH PHFFNGDOHAF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6949B40", Offset = "0x6948340", VA = "0x186949B40")]
	public static bool IKACJOLFJPE(DJOCLHOLMAO IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x694C730", Offset = "0x694AF30", VA = "0x18694C730", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(DJOCLHOLMAO OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6949660", Offset = "0x6947E60", VA = "0x186949660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x694C690", Offset = "0x694AE90", VA = "0x18694C690")]
	public bool EDGGOMCAHKM([Out] Guid IKNLCPDILAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x694C1A0", Offset = "0x694A9A0", VA = "0x18694C1A0")]
	public void BHKFKDCIBOG(Guid FCGMGAOCKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x694C560", Offset = "0x694AD60", VA = "0x18694C560")]
	public bool DOHDJDKNJLE([Out] Guid FMPAALMFOIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x694C320", Offset = "0x694AB20", VA = "0x18694C320")]
	public void DGNDFHEHJJA(Guid FCGMGAOCKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x694C8E0", Offset = "0x694B0E0", VA = "0x18694C8E0")]
	public void PPNDNDJEFAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct MGIMJBEMNBJ : IEquatable<MGIMJBEMNBJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public PBDHGENIJKH PLPBANMLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(PBDHGENIJKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private KLGGLOMIJJG GIINLOOHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x69494C0", Offset = "0x6947CC0", VA = "0x1869494C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private OKFMEEFLDCN IFGGGNEDOOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6957BC0", Offset = "0x69563C0", VA = "0x186957BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private ALDDMJNLKBP IPLODDDPJHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x6957C50", Offset = "0x6956450", VA = "0x186957C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 OHKEDOCNBPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6957CB0", Offset = "0x69564B0", VA = "0x186957CB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Quaternion LHPEBNNPPNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x6957A70", Offset = "0x6956270", VA = "0x186957A70")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public BCKBAIPBKNN MCPMBPPHANK
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x6957950", Offset = "0x6956150", VA = "0x186957950")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
	public MGIMJBEMNBJ(PBDHGENIJKH PHFFNGDOHAF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8E2600", Offset = "0x8E0E00", VA = "0x1808E2600")]
	public static PBDHGENIJKH IKACJOLFJPE(MGIMJBEMNBJ IPHHABIKCHD)
	{
		return default(PBDHGENIJKH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x69579E0", Offset = "0x69561E0", VA = "0x1869579E0", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(MGIMJBEMNBJ OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6949660", Offset = "0x6947E60", VA = "0x186949660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct NPBNJEHNJDF : IEquatable<NPBNJEHNJDF>
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly NPBNJEHNJDF HOCKBMNCBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public PBDHGENIJKH PLPBANMLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(PBDHGENIJKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public INOMIAAGGLN BNMINHJAICK
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(INOMIAAGGLN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public GGKNEECAHMB OGGHIBHHBBN
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(GGKNEECAHMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private KLGGLOMIJJG GIINLOOHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x69494C0", Offset = "0x6947CC0", VA = "0x1869494C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private OKFMEEFLDCN IFGGGNEDOOG
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x695B610", Offset = "0x6959E10", VA = "0x18695B610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private MKGBMLANGKF FPNKOOBJMCA
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x695AF10", Offset = "0x6959710", VA = "0x18695AF10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public IMJGNGJFNGC CNDIDLLIJEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x695B0D0", Offset = "0x69598D0", VA = "0x18695B0D0")]
		get
		{
			return default(IMJGNGJFNGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public IEnumerable<BCKBAIPBKNN> EHFDECEFDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x695AF70", Offset = "0x6959770", VA = "0x18695AF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public IEnumerable<BCKBAIPBKNN> LCKNNPHAJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6959CE0", Offset = "0x69584E0", VA = "0x186959CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public int CFJAMIEIIBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x695A170", Offset = "0x6958970", VA = "0x18695A170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public int FDNFMCOPDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x695A270", Offset = "0x6958A70", VA = "0x18695A270")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public string HMPIIAILGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x695A320", Offset = "0x6958B20", VA = "0x18695A320")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x695B4A0", Offset = "0x6959CA0", VA = "0x18695B4A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public ODNJDOOHIFJ EFNNBBHPEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x695A2C0", Offset = "0x6958AC0", VA = "0x18695A2C0")]
		get
		{
			return default(ODNJDOOHIFJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x695AE30", Offset = "0x6959630", VA = "0x18695AE30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public OFDALJLKGDF MAPHAOPEHIO
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x695ABC0", Offset = "0x69593C0", VA = "0x18695ABC0")]
		get
		{
			return default(OFDALJLKGDF);
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x695A9F0", Offset = "0x69591F0", VA = "0x18695A9F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public IDHDPBLIDBO HBGJEADEJIB
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x695AC20", Offset = "0x6959420", VA = "0x18695AC20")]
		get
		{
			return default(IDHDPBLIDBO);
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x695AC80", Offset = "0x6959480", VA = "0x18695AC80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public float CLOMOKFFKIB
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x695B550", Offset = "0x6959D50", VA = "0x18695B550")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x695B710", Offset = "0x6959F10", VA = "0x18695B710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool GKFLCMOGPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x695AD60", Offset = "0x6959560", VA = "0x18695AD60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x695ADC0", Offset = "0x69595C0", VA = "0x18695ADC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool LONJKGJDPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x695B5B0", Offset = "0x6959DB0", VA = "0x18695B5B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x695B6A0", Offset = "0x6959EA0", VA = "0x18695B6A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool DPBEOJGIBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x695B440", Offset = "0x6959C40", VA = "0x18695B440")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x695ACF0", Offset = "0x69594F0", VA = "0x18695ACF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool MLOGCHOJCFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x695AA60", Offset = "0x6959260", VA = "0x18695AA60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x695AAC0", Offset = "0x69592C0", VA = "0x18695AAC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool ALCFHFDHDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x695B3E0", Offset = "0x6959BE0", VA = "0x18695B3E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x695B780", Offset = "0x6959F80", VA = "0x18695B780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool MINCGBOJGHL
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x695A3D0", Offset = "0x6958BD0", VA = "0x18695A3D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x695A200", Offset = "0x6958A00", VA = "0x18695A200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
	public NPBNJEHNJDF(PBDHGENIJKH PHFFNGDOHAF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6949B40", Offset = "0x6948340", VA = "0x186949B40")]
	public static bool IKACJOLFJPE(NPBNJEHNJDF IPHHABIKCHD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6949BB0", Offset = "0x69483B0", VA = "0x186949BB0")]
	public static bool JAJJILMADFD(NPBNJEHNJDF NKCCEIKLOPK, NPBNJEHNJDF ICPBHPBDLLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x695AB30", Offset = "0x6959330", VA = "0x18695AB30", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(NPBNJEHNJDF OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6949660", Offset = "0x6947E60", VA = "0x186949660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8E2600", Offset = "0x8E0E00", VA = "0x1808E2600")]
	public static BCKBAIPBKNN IKACJOLFJPE(NPBNJEHNJDF EGJINJKGIAK)
	{
		return default(BCKBAIPBKNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x695B190", Offset = "0x6959990", VA = "0x18695B190")]
	public bool JBAJEMKHCHO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x695AEA0", Offset = "0x69596A0", VA = "0x18695AEA0")]
	public bool IBLGAIMNEOG(KNIOBLBDGHD DNLBGNBJLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x695B360", Offset = "0x6959B60", VA = "0x18695B360")]
	public void LBEFAKHMBJK(KNIOBLBDGHD DNLBGNBJLAH, bool IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x695B1B0", Offset = "0x69599B0", VA = "0x18695B1B0")]
	public IMJGNGJFNGC JCLDGJALCPP(Allocator KCJKALFMGMC)
	{
		return default(IMJGNGJFNGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6959E00", Offset = "0x6958600", VA = "0x186959E00")]
	public void ALMGAPBNOPJ(NPBNJEHNJDF OGFCKBADKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x695A430", Offset = "0x6958C30", VA = "0x18695A430")]
	public void CJLKEGIDPCI(List<BCKBAIPBKNN> KOGKINGMFGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct OAFGDBKADBN : IEquatable<OAFGDBKADBN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x695B7F0", Offset = "0x6959FF0", VA = "0x18695B7F0", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(OAFGDBKADBN OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6949660", Offset = "0x6947E60", VA = "0x186949660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct APJCGOPHCCD : IEquatable<APJCGOPHCCD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	private KLGGLOMIJJG GIINLOOHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x69494C0", Offset = "0x6947CC0", VA = "0x1869494C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
	public APJCGOPHCCD(PBDHGENIJKH PHFFNGDOHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6949350", Offset = "0x6947B50", VA = "0x186949350", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(APJCGOPHCCD OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6949660", Offset = "0x6947E60", VA = "0x186949660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6949520", Offset = "0x6947D20", VA = "0x186949520")]
	public void PGFGBHFCFEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6949420", Offset = "0x6947C20", VA = "0x186949420")]
	public void HIHAJDAPMFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x69495C0", Offset = "0x6947DC0", VA = "0x1869495C0")]
	public bool PIOKMOPPFIP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct GGKNEECAHMB : IEquatable<GGKNEECAHMB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public PBDHGENIJKH PLPBANMLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(PBDHGENIJKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private KLGGLOMIJJG GIINLOOHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x69494C0", Offset = "0x6947CC0", VA = "0x1869494C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	private OKFMEEFLDCN IFGGGNEDOOG
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x694DFC0", Offset = "0x694C7C0", VA = "0x18694DFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private MKGBMLANGKF FPNKOOBJMCA
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x694DE40", Offset = "0x694C640", VA = "0x18694DE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public PBDHGENIJKH LBAJCJIPOGG
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x694DEA0", Offset = "0x694C6A0", VA = "0x18694DEA0")]
		get
		{
			return default(PBDHGENIJKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public BCKBAIPBKNN GFHKLHCNBBP
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x694DF30", Offset = "0x694C730", VA = "0x18694DF30")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public BCKBAIPBKNN BENFNHCGCFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x694DDB0", Offset = "0x694C5B0", VA = "0x18694DDB0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
	public GGKNEECAHMB(PBDHGENIJKH PHFFNGDOHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x694DC20", Offset = "0x694C420", VA = "0x18694DC20", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(GGKNEECAHMB OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6949660", Offset = "0x6947E60", VA = "0x186949660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x694D7D0", Offset = "0x694BFD0", VA = "0x18694D7D0")]
	public bool BFFDCAOPJND(BCKBAIPBKNN GGJNHHDMGON, bool BFMLLILPKHA = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x694DD10", Offset = "0x694C510", VA = "0x18694DD10")]
	public bool HALDJFGILLM(BCKBAIPBKNN FOFBODJKPLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x694D900", Offset = "0x694C100", VA = "0x18694D900")]
	private void EGFCNKEMBJN(BCKBAIPBKNN KLGDOCABLFC, List<BCKBAIPBKNN> LNHKDIKAPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x694DB90", Offset = "0x694C390", VA = "0x18694DB90")]
	public NPBNJEHNJDF EPIECLENIEP()
	{
		return default(NPBNJEHNJDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x694DCB0", Offset = "0x694C4B0", VA = "0x18694DCB0")]
	public void FHHCIPNOEGD(List<BCKBAIPBKNN> DGGNPFAGIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x694E050", Offset = "0x694C850", VA = "0x18694E050")]
	public NativeArray<PBDHGENIJKH> POIOJCONGMA()
	{
		return default(NativeArray<PBDHGENIJKH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct DCDBKGFALLD : IEquatable<DCDBKGFALLD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public string DHCMDJCLOOB
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x694ADF0", Offset = "0x69495F0", VA = "0x18694ADF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public string KCCFAAGFCJN
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x694AAE0", Offset = "0x69492E0", VA = "0x18694AAE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool CDODNPHNIFF
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x694A9A0", Offset = "0x69491A0", VA = "0x18694A9A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public string NDFFCPGCNHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x694A8B0", Offset = "0x69490B0", VA = "0x18694A8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public string OJIECMAIOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x694ABA0", Offset = "0x69493A0", VA = "0x18694ABA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public string GEBLEKHMAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x694AF00", Offset = "0x6949700", VA = "0x18694AF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
	public DCDBKGFALLD(PBDHGENIJKH PHFFNGDOHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x694AE70", Offset = "0x6949670", VA = "0x18694AE70", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(DCDBKGFALLD OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x6949660", Offset = "0x6947E60", VA = "0x186949660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct MDLLKKDBDHN : IEquatable<MDLLKKDBDHN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	private KLGGLOMIJJG GIINLOOHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x69494C0", Offset = "0x6947CC0", VA = "0x1869494C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private OKFMEEFLDCN IFGGGNEDOOG
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6957660", Offset = "0x6955E60", VA = "0x186957660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private GLNJIKIIMBJ LENLBGPCLCI
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6957600", Offset = "0x6955E00", VA = "0x186957600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public EIJIJHCHANM FBMLLBDEDKF
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6956FD0", Offset = "0x69557D0", VA = "0x186956FD0")]
		get
		{
			return default(EIJIJHCHANM);
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6957450", Offset = "0x6955C50", VA = "0x186957450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public bool FJFCGLAEJDN
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6957290", Offset = "0x6955A90", VA = "0x186957290")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6957820", Offset = "0x6956020", VA = "0x186957820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public string[] FIBEMIHACOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x69573C0", Offset = "0x6955BC0", VA = "0x1869573C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6957160", Offset = "0x6955960", VA = "0x186957160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public string[] IIKBBJFDHEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x69578C0", Offset = "0x69560C0", VA = "0x1869578C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6956F30", Offset = "0x6955730", VA = "0x186956F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public string[] PIKNPDBNKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6957200", Offset = "0x6955A00", VA = "0x186957200")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6957780", Offset = "0x6955F80", VA = "0x186957780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public string[] OMPFHHGCNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x69576F0", Offset = "0x6955EF0", VA = "0x1869576F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6957320", Offset = "0x6955B20", VA = "0x186957320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
	public MDLLKKDBDHN(PBDHGENIJKH PHFFNGDOHAF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8E2600", Offset = "0x8E0E00", VA = "0x1808E2600")]
	public static PBDHGENIJKH IKACJOLFJPE(MDLLKKDBDHN IPHHABIKCHD)
	{
		return default(PBDHGENIJKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x69570D0", Offset = "0x69558D0", VA = "0x1869570D0", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(MDLLKKDBDHN OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x6949660", Offset = "0x6947E60", VA = "0x186949660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x6957560", Offset = "0x6955D60", VA = "0x186957560")]
	public bool KPFGDBHFMGE(PBDHGENIJKH PENGDIMNCLF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct IEHGOJFMMIJ : IEquatable<IEHGOJFMMIJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x6951390", Offset = "0x694FB90", VA = "0x186951390", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(IEHGOJFMMIJ OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x6949660", Offset = "0x6947E60", VA = "0x186949660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct MAOFNOEDLKK : IEquatable<MAOFNOEDLKK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
	public MAOFNOEDLKK(PBDHGENIJKH PHFFNGDOHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x6956EA0", Offset = "0x69556A0", VA = "0x186956EA0", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(MAOFNOEDLKK OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x6949660", Offset = "0x6947E60", VA = "0x186949660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6956D30", Offset = "0x6955530", VA = "0x186956D30")]
	public bool EPKBILPHBIH([Out] Collider NEBJBGFEICB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct FGFDHCEIOPD : IEquatable<FGFDHCEIOPD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public PBDHGENIJKH PLPBANMLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(PBDHGENIJKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	private MakerPenHeldDataWrapper LKEOMIGPMCF
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x694D320", Offset = "0x694BB20", VA = "0x18694D320")]
		get
		{
			return default(MakerPenHeldDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool AJKKFIEJLDI
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x694D380", Offset = "0x694BB80", VA = "0x18694D380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
	public FGFDHCEIOPD(PBDHGENIJKH PHFFNGDOHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x694D290", Offset = "0x694BA90", VA = "0x18694D290", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(FGFDHCEIOPD OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6949660", Offset = "0x6947E60", VA = "0x186949660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct MMAJILHPKHP : IEquatable<MMAJILHPKHP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public PBDHGENIJKH PLPBANMLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(PBDHGENIJKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	private KLGGLOMIJJG GIINLOOHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x69494C0", Offset = "0x6947CC0", VA = "0x1869494C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	private OKFMEEFLDCN IFGGGNEDOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6957F90", Offset = "0x6956790", VA = "0x186957F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	private LHGENCGFGCM HMFKKBLBGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6957F30", Offset = "0x6956730", VA = "0x186957F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
	public MMAJILHPKHP(PBDHGENIJKH PHFFNGDOHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6957E00", Offset = "0x6956600", VA = "0x186957E00", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(MMAJILHPKHP OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6949660", Offset = "0x6947E60", VA = "0x186949660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6957E90", Offset = "0x6956690", VA = "0x186957E90")]
	public void JPPBJIAFNHP(bool NLGCNEMBLDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct DDKBEPHLACF : IEquatable<DDKBEPHLACF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public PBDHGENIJKH PLPBANMLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(PBDHGENIJKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	private KLGGLOMIJJG GIINLOOHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x69494C0", Offset = "0x6947CC0", VA = "0x1869494C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	private OKFMEEFLDCN IFGGGNEDOOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x694BBA0", Offset = "0x694A3A0", VA = "0x18694BBA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private ObjectPolicyDataWrapper HPGKGLEDBCB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x694AFF0", Offset = "0x69497F0", VA = "0x18694AFF0")]
		get
		{
			return default(ObjectPolicyDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private NavMeshGenerationDataWrapper PHJNIFNOOCF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x694BC30", Offset = "0x694A430", VA = "0x18694BC30")]
		get
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public bool HOHLMAAEKNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x694B570", Offset = "0x6949D70", VA = "0x18694B570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public bool DMKHAMIIJHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x694BD40", Offset = "0x694A540", VA = "0x18694BD40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public bool KMJAPDPFPPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x694BED0", Offset = "0x694A6D0", VA = "0x18694BED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool HBJEHGGBMNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x694BF40", Offset = "0x694A740", VA = "0x18694BF40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool LKELOCOFPBN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x694B750", Offset = "0x6949F50", VA = "0x18694B750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool IHADNGFPLKF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x694B490", Offset = "0x6949C90", VA = "0x18694B490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool DKMFNABICBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x694BA40", Offset = "0x694A240", VA = "0x18694BA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool CIOONHNDLBH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x694BB30", Offset = "0x694A330", VA = "0x18694BB30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public bool HKGFACFEKON
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x694B8A0", Offset = "0x694A0A0", VA = "0x18694B8A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public bool KGPPJPGOOGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x694B320", Offset = "0x6949B20", VA = "0x18694B320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public bool KJFNDDFJNEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x694B420", Offset = "0x6949C20", VA = "0x18694B420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public bool LLNHGOLDOHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x694B670", Offset = "0x6949E70", VA = "0x18694B670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public bool LHBEJAMICCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x694B830", Offset = "0x694A030", VA = "0x18694B830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool OOEBFOFFJOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x694B5B0", Offset = "0x6949DB0", VA = "0x18694B5B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool PEFILMHEENE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x694B910", Offset = "0x694A110", VA = "0x18694B910")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x694B7C0", Offset = "0x6949FC0", VA = "0x18694B7C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public GELOENNNENA IGPENMNNNAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x694BDB0", Offset = "0x694A5B0", VA = "0x18694BDB0")]
		get
		{
			return default(GELOENNNENA);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x694B9D0", Offset = "0x694A1D0", VA = "0x18694B9D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool EJLELKAFKAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x694B150", Offset = "0x6949950", VA = "0x18694B150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public OMLOEIALCCH PFPMLNAPLBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x694BFB0", Offset = "0x694A7B0", VA = "0x18694BFB0")]
		get
		{
			return default(OMLOEIALCCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool LEEHDCFNHJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x694B610", Offset = "0x6949E10", VA = "0x18694B610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Vector3 MCDOPNFCABM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x694BE10", Offset = "0x694A610", VA = "0x18694BE10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Vector3 MBIFCGJAFHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x694BC90", Offset = "0x694A490", VA = "0x18694BC90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool CNKJBHDOJPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x694B050", Offset = "0x6949850", VA = "0x18694B050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
	public DDKBEPHLACF(PBDHGENIJKH PHFFNGDOHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x694B390", Offset = "0x6949B90", VA = "0x18694B390", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(DDKBEPHLACF OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6949660", Offset = "0x6947E60", VA = "0x186949660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x694B500", Offset = "0x6949D00", VA = "0x18694B500")]
	public bool FNHFJAEHKBG(EJDKCHOKHOI DNLBGNBJLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x694B6E0", Offset = "0x6949EE0", VA = "0x18694B6E0")]
	public bool ICOPOFMPFJA(EOKNLIPIJFA DNLBGNBJLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x694BAB0", Offset = "0x694A2B0", VA = "0x18694BAB0")]
	public void LOMMMOEOGGF(EOKNLIPIJFA DNLBGNBJLAH, bool IOAFJLAKIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x694B970", Offset = "0x694A170", VA = "0x18694B970")]
	public EOKNLIPIJFA KNJJNBJKFJG()
	{
		return default(EOKNLIPIJFA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x694C010", Offset = "0x694A810", VA = "0x18694C010")]
	public bool PKICKJFPFDE(EOKNLIPIJFA IPHHABIKCHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct NFGIDBPCJAA : IEquatable<NFGIDBPCJAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	private KLGGLOMIJJG GIINLOOHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x69494C0", Offset = "0x6947CC0", VA = "0x1869494C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	private OKFMEEFLDCN IFGGGNEDOOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6959950", Offset = "0x6958150", VA = "0x186959950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private OCDKHJHJLJB HBCPKCICFBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6959220", Offset = "0x6957A20", VA = "0x186959220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
	public NFGIDBPCJAA(PBDHGENIJKH PHFFNGDOHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x69594C0", Offset = "0x6957CC0", VA = "0x1869594C0", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(NFGIDBPCJAA OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6949660", Offset = "0x6947E60", VA = "0x186949660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x6959820", Offset = "0x6958020", VA = "0x186959820")]
	public bool LKKMDHEEFPA(JBMHKOHEBLO NBMJJDIPDAE, List<BCKBAIPBKNN> KOGKINGMFGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x6959550", Offset = "0x6957D50", VA = "0x186959550")]
	public int IFOKJCEAMJG(JBMHKOHEBLO NBMJJDIPDAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x6959710", Offset = "0x6957F10", VA = "0x186959710")]
	public void KKKJPKACCEC(List<BCKBAIPBKNN> KOGKINGMFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x6959040", Offset = "0x6957840", VA = "0x186959040")]
	public int AEDBEMBEOJF(BCKBAIPBKNN LFFBLPMMGND, JBMHKOHEBLO NBMJJDIPDAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x6959280", Offset = "0x6957A80", VA = "0x186959280")]
	public BCKBAIPBKNN DLLCPMBBFPI(int JBDLDJOINOF, JBMHKOHEBLO NBMJJDIPDAE)
	{
		return default(BCKBAIPBKNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x69599E0", Offset = "0x69581E0", VA = "0x1869599E0")]
	public void OAKOCECIOOH(BCKBAIPBKNN LFFBLPMMGND, JBMHKOHEBLO NBMJJDIPDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6959170", Offset = "0x6957970", VA = "0x186959170")]
	public bool BIEFGLMFEKH(BCKBAIPBKNN LFFBLPMMGND, JBMHKOHEBLO NBMJJDIPDAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x69593B0", Offset = "0x6957BB0", VA = "0x1869593B0")]
	public void EDGCDPLBKKH(JBMHKOHEBLO NBMJJDIPDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6959660", Offset = "0x6957E60", VA = "0x186959660")]
	public bool IHAFPDFGEBL(BCKBAIPBKNN LFFBLPMMGND, JBMHKOHEBLO NBMJJDIPDAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct CKDOGDBFLKD : IEquatable<CKDOGDBFLKD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public PBDHGENIJKH PLPBANMLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(PBDHGENIJKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	private KLGGLOMIJJG GIINLOOHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x69494C0", Offset = "0x6947CC0", VA = "0x1869494C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	private OKFMEEFLDCN IFGGGNEDOOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x694A620", Offset = "0x6948E20", VA = "0x18694A620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
	public CKDOGDBFLKD(PBDHGENIJKH PHFFNGDOHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x694A470", Offset = "0x6948C70", VA = "0x18694A470", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(CKDOGDBFLKD OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x6949660", Offset = "0x6947E60", VA = "0x186949660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x694A590", Offset = "0x6948D90", VA = "0x18694A590")]
	public void HEILHPOOCHE(bool IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x694A500", Offset = "0x6948D00", VA = "0x18694A500")]
	public void GLKAJJKBPNP(bool IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x28AF3B0", Offset = "0x28ADBB0", VA = "0x1828AF3B0")]
	public T LLJMLENKILK<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct IBLIOBEPPJN : IEquatable<IBLIOBEPPJN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public PBDHGENIJKH PLPBANMLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(PBDHGENIJKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	private KLGGLOMIJJG GIINLOOHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x69494C0", Offset = "0x6947CC0", VA = "0x1869494C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	private OKFMEEFLDCN IFGGGNEDOOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x6951300", Offset = "0x694FB00", VA = "0x186951300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	private HOLEGFNAACB AECDLBLCOIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6951210", Offset = "0x694FA10", VA = "0x186951210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public bool EPEJDBIJNDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6951270", Offset = "0x694FA70", VA = "0x186951270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public bool KEDAIPDFLMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x69510F0", Offset = "0x694F8F0", VA = "0x1869510F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
	public IBLIOBEPPJN(PBDHGENIJKH PHFFNGDOHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6951180", Offset = "0x694F980", VA = "0x186951180", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(IBLIOBEPPJN OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x6949660", Offset = "0x6947E60", VA = "0x186949660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct IMHHMBOCAAA : IEquatable<IMHHMBOCAAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public PBDHGENIJKH PLPBANMLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(PBDHGENIJKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private KLGGLOMIJJG GIINLOOHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x69494C0", Offset = "0x6947CC0", VA = "0x1869494C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private OKFMEEFLDCN IFGGGNEDOOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6952480", Offset = "0x6950C80", VA = "0x186952480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private LMGAGOLNIJL NGBPPLLKEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6952110", Offset = "0x6950910", VA = "0x186952110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private FEEEGPEJPCE IADAMGKKOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x6952350", Offset = "0x6950B50", VA = "0x186952350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool GJBGHCMMKCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6951CD0", Offset = "0x69504D0", VA = "0x186951CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool CNFOJIBAKDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x6952790", Offset = "0x6950F90", VA = "0x186952790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool JINEEJJIAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x6951C10", Offset = "0x6950410", VA = "0x186951C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool BNNFLIAOBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x69523B0", Offset = "0x6950BB0", VA = "0x1869523B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool FDMHILPCKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x6952280", Offset = "0x6950A80", VA = "0x186952280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool NPHBCCJPGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x6951C40", Offset = "0x6950440", VA = "0x186951C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool MEJKKIHKMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x6952580", Offset = "0x6950D80", VA = "0x186952580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool JNKFFFOOOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x6951D60", Offset = "0x6950560", VA = "0x186951D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
	public IMHHMBOCAAA(PBDHGENIJKH PHFFNGDOHAF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x6949B40", Offset = "0x6948340", VA = "0x186949B40")]
	public static bool IKACJOLFJPE(IMHHMBOCAAA IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6951F70", Offset = "0x6950770", VA = "0x186951F70", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(IMHHMBOCAAA OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6949660", Offset = "0x6947E60", VA = "0x186949660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x6952510", Offset = "0x6950D10", VA = "0x186952510")]
	public bool MOHJMKNIIHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x69522B0", Offset = "0x6950AB0", VA = "0x1869522B0")]
	public BCKBAIPBKNN JJNLLHFIPAA(BCKBAIPBKNN LFFBLPMMGND)
	{
		return default(BCKBAIPBKNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x6952000", Offset = "0x6950800", VA = "0x186952000")]
	public PBDHGENIJKH FDGABJOBCKN()
	{
		return default(PBDHGENIJKH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x6951B70", Offset = "0x6950370", VA = "0x186951B70")]
	public bool ANIDOPBKPBJ(PBDHGENIJKH DKIBGNNJMFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6951ED0", Offset = "0x69506D0", VA = "0x186951ED0")]
	public bool DOLOIMPHNLA(PBDHGENIJKH KMPJDLCJLJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x6952170", Offset = "0x6950970", VA = "0x186952170")]
	public bool HBKOJINJEHM(PBDHGENIJKH LFFBLPMMGND, [Out] PBDHGENIJKH DKIBGNNJMFJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct JOKDEEFIKCA : IEquatable<JOKDEEFIKCA>
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly JOKDEEFIKCA HOCKBMNCBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public PBDHGENIJKH PLPBANMLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(PBDHGENIJKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public INOMIAAGGLN BNMINHJAICK
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(INOMIAAGGLN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public GGKNEECAHMB OGGHIBHHBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(GGKNEECAHMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private ShapeTypeDataWrapper GPGPNNEAEPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x6956120", Offset = "0x6954920", VA = "0x186956120")]
		get
		{
			return default(ShapeTypeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public StandardRenderableVisualDataWrapper OGPDJJDPMNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x69562C0", Offset = "0x6954AC0", VA = "0x1869562C0")]
		get
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public PhysicsMaterialDataWrapper EHEGLAPKKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x69567A0", Offset = "0x6954FA0", VA = "0x1869567A0")]
		get
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public ShapeConfigDataWrapper BNKNIEJBCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x6956060", Offset = "0x6954860", VA = "0x186956060")]
		get
		{
			return default(ShapeConfigDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public PLKBBHEGOHJ GFJEBOOCCGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x69565D0", Offset = "0x6954DD0", VA = "0x1869565D0")]
		get
		{
			return default(PLKBBHEGOHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public DAHLIGHBIPG BJDFJONKEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x69561F0", Offset = "0x69549F0", VA = "0x1869561F0")]
		get
		{
			return default(DAHLIGHBIPG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x6955F90", Offset = "0x6954790", VA = "0x186955F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public BFFCOEEOEHO OIIHCFBIELL
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x69560C0", Offset = "0x69548C0", VA = "0x1869560C0")]
		get
		{
			return default(BFFCOEEOEHO);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x6956730", Offset = "0x6954F30", VA = "0x186956730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public float DGPLADDPOKL
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x6956000", Offset = "0x6954800", VA = "0x186956000")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x6956250", Offset = "0x6954A50", VA = "0x186956250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public Vector3 AFNHBCOIKHB
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x6956530", Offset = "0x6954D30", VA = "0x186956530")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x6956320", Offset = "0x6954B20", VA = "0x186956320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public float EIJIMDOKBIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x6956180", Offset = "0x6954980", VA = "0x186956180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public JENFECLMIAE DFALDDLOOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x69564D0", Offset = "0x6954CD0", VA = "0x1869564D0")]
		get
		{
			return default(JENFECLMIAE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x6956640", Offset = "0x6954E40", VA = "0x186956640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
	public JOKDEEFIKCA(PBDHGENIJKH PHFFNGDOHAF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6949B40", Offset = "0x6948340", VA = "0x186949B40")]
	public static bool IKACJOLFJPE(JOKDEEFIKCA IPHHABIKCHD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6949A80", Offset = "0x6948280", VA = "0x186949A80")]
	public static bool GLAAFHEDDBF(JOKDEEFIKCA NKCCEIKLOPK, JOKDEEFIKCA ICPBHPBDLLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x6956440", Offset = "0x6954C40", VA = "0x186956440", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(JOKDEEFIKCA OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x6949660", Offset = "0x6947E60", VA = "0x186949660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x69563C0", Offset = "0x6954BC0", VA = "0x1869563C0")]
	public OGIJAOKFLIM EODONMLANGF()
	{
		return default(OGIJAOKFLIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x69566B0", Offset = "0x6954EB0", VA = "0x1869566B0")]
	public HPGFGBAMMOA MJIDFHHDEDP()
	{
		return default(HPGFGBAMMOA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public readonly struct OGIJAOKFLIM : IEquatable<OGIJAOKFLIM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public PBDHGENIJKH PLPBANMLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(PBDHGENIJKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public JOKDEEFIKCA JDMLLFJNBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(JOKDEEFIKCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private PrimitiveShapeDataWrapper ALKEHCEEANN
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x695B970", Offset = "0x695A170", VA = "0x18695B970")]
		get
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public DOAIKOFFLKL HNEKNBBEJOP
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x695B880", Offset = "0x695A080", VA = "0x18695B880")]
		get
		{
			return default(DOAIKOFFLKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
	public OGIJAOKFLIM(PBDHGENIJKH PHFFNGDOHAF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6949B40", Offset = "0x6948340", VA = "0x186949B40")]
	public static bool IKACJOLFJPE(OGIJAOKFLIM IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x695B8E0", Offset = "0x695A0E0", VA = "0x18695B8E0", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(OGIJAOKFLIM OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x6949660", Offset = "0x6947E60", VA = "0x186949660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[DefaultMember("Item")]
public readonly struct HPGFGBAMMOA : IEquatable<HPGFGBAMMOA>
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly HPGFGBAMMOA HOCKBMNCBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public PBDHGENIJKH PLPBANMLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(PBDHGENIJKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public INOMIAAGGLN BNMINHJAICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(INOMIAAGGLN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private KLGGLOMIJJG GIINLOOHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x69494C0", Offset = "0x6947CC0", VA = "0x1869494C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	private OKFMEEFLDCN IFGGGNEDOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x6950F40", Offset = "0x694F740", VA = "0x186950F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private JLODODAJBKB AEHIJLPGADM
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x6950620", Offset = "0x694EE20", VA = "0x186950620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public JOKDEEFIKCA JDMLLFJNBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(JOKDEEFIKCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public MBCNCENFLII MEOBNHCHABK
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x6950680", Offset = "0x694EE80", VA = "0x186950680")]
		get
		{
			return default(MBCNCENFLII);
		}
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x6950FD0", Offset = "0x694F7D0", VA = "0x186950FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public IEnumerable<JADBGFJCCAH> KOBFLAEFMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x69509E0", Offset = "0x694F1E0", VA = "0x1869509E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public JADBGFJCCAH EDCCAJFFILN
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x69507B0", Offset = "0x694EFB0", VA = "0x1869507B0")]
		get
		{
			return default(JADBGFJCCAH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public int HJCFDKBBGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x6950EB0", Offset = "0x694F6B0", VA = "0x186950EB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
	public HPGFGBAMMOA(PBDHGENIJKH PHFFNGDOHAF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x6949B40", Offset = "0x6948340", VA = "0x186949B40")]
	public static bool IKACJOLFJPE(HPGFGBAMMOA IPHHABIKCHD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x6949BB0", Offset = "0x69483B0", VA = "0x186949BB0")]
	public static bool JAJJILMADFD(HPGFGBAMMOA NKCCEIKLOPK, HPGFGBAMMOA ICPBHPBDLLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x69508C0", Offset = "0x694F0C0", VA = "0x1869508C0", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(HPGFGBAMMOA OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x6949660", Offset = "0x6947E60", VA = "0x186949660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x6950400", Offset = "0x694EC00", VA = "0x186950400")]
	public JADBGFJCCAH AJBCBEPOLBC(float3? GBKEBGLIOFD, [Optional] quaternion? LOMIHBHMPMH, [Optional] Vector3? KEONANJCBKH)
	{
		return default(JADBGFJCCAH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x6950BE0", Offset = "0x694F3E0", VA = "0x186950BE0")]
	public JADBGFJCCAH HLODEDBNJDD(int JBDLDJOINOF, float3? GBKEBGLIOFD, [Optional] quaternion? LOMIHBHMPMH, [Optional] Vector3? KEONANJCBKH)
	{
		return default(JADBGFJCCAH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x6950E10", Offset = "0x694F610", VA = "0x186950E10")]
	public void IHHAHDCKHPA(int JBDLDJOINOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x6950950", Offset = "0x694F150", VA = "0x186950950")]
	public void GLOOIBDLHCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct JADBGFJCCAH : IEquatable<JADBGFJCCAH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public PBDHGENIJKH PLPBANMLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(PBDHGENIJKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public HPGFGBAMMOA FCOJAHEPKBG
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x6955730", Offset = "0x6953F30", VA = "0x186955730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public float3 NPNMPABLGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x6955C90", Offset = "0x6954490", VA = "0x186955C90")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x6955C10", Offset = "0x6954410", VA = "0x186955C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public quaternion NIILCMPNFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x69559E0", Offset = "0x69541E0", VA = "0x1869559E0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x6955A60", Offset = "0x6954260", VA = "0x186955A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public float3 GBINFLEDHIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x6955D10", Offset = "0x6954510", VA = "0x186955D10")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x6955B30", Offset = "0x6954330", VA = "0x186955B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public KMAJGEEABAB ELBGCFNCAGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x6955880", Offset = "0x6954080", VA = "0x186955880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	private SplinePointParentDataWrapper HDEMIKJDOCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x6955AD0", Offset = "0x69542D0", VA = "0x186955AD0")]
		get
		{
			return default(SplinePointParentDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	private SplinePointPositionDataWrapper JBABLAJKCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x69558F0", Offset = "0x69540F0", VA = "0x1869558F0")]
		get
		{
			return default(SplinePointPositionDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	private SplinePointRotationDataWrapper GPCILBKAOAL
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x6955BB0", Offset = "0x69543B0", VA = "0x186955BB0")]
		get
		{
			return default(SplinePointRotationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	private SplinePointScaleDataWrapper GDDOEBPPCCG
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x6955820", Offset = "0x6954020", VA = "0x186955820")]
		get
		{
			return default(SplinePointScaleDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	private SplinePointOrderDataWrapper KKBLKBHFPMF
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x69557C0", Offset = "0x6953FC0", VA = "0x1869557C0")]
		get
		{
			return default(SplinePointOrderDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
	public JADBGFJCCAH(PBDHGENIJKH PHFFNGDOHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x6955950", Offset = "0x6954150", VA = "0x186955950", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(JADBGFJCCAH OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x6949660", Offset = "0x6947E60", VA = "0x186949660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x6955730", Offset = "0x6953F30", VA = "0x186955730")]
	public void JGOHGAHEJAM(HPGFGBAMMOA IPHHABIKCHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct HGKAGFMGFLA : IEquatable<HGKAGFMGFLA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public PBDHGENIJKH PLPBANMLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(PBDHGENIJKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	private KLGGLOMIJJG GIINLOOHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x69494C0", Offset = "0x6947CC0", VA = "0x1869494C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private OKFMEEFLDCN IFGGGNEDOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x694FFB0", Offset = "0x694E7B0", VA = "0x18694FFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	private IIADBCPLHOP CAIKKGECDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x6950040", Offset = "0x694E840", VA = "0x186950040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private ToolCleanupSettingsDataWrapper FOHAJKHOEAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x694FC20", Offset = "0x694E420", VA = "0x18694FC20")]
		get
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public bool CKCGNFFKIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x694FEE0", Offset = "0x694E6E0", VA = "0x18694FEE0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x694F8D0", Offset = "0x694E0D0", VA = "0x18694F8D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public bool BJELDGMCEHC
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x694F4D0", Offset = "0x694DCD0", VA = "0x18694F4D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x694FF40", Offset = "0x694E740", VA = "0x18694FF40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public float PLEIKCJEPHC
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x694FBC0", Offset = "0x694E3C0", VA = "0x18694FBC0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x69500A0", Offset = "0x694E8A0", VA = "0x1869500A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool OMNEHLGPODC
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x694F530", Offset = "0x694DD30", VA = "0x18694F530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
	public HGKAGFMGFLA(PBDHGENIJKH PHFFNGDOHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x694F7A0", Offset = "0x694DFA0", VA = "0x18694F7A0", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(HGKAGFMGFLA OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6949660", Offset = "0x6947E60", VA = "0x186949660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x694F830", Offset = "0x694E030", VA = "0x18694F830")]
	public void GHHMHAMCEJB(int ECKNMNLLOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x694FC80", Offset = "0x694E480", VA = "0x18694FC80")]
	public bool KECCBLBKCMI([Out] int ECKNMNLLOJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x694F700", Offset = "0x694DF00", VA = "0x18694F700")]
	public void BDNFLIFKCPI(bool GEHBNGFIMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x694FA70", Offset = "0x694E270", VA = "0x18694FA70")]
	public void HBGMIBOLCAJ(float DPPFIEGKAEB, float KLIDHAOEIFK, float DNNDLKEKBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x694FD90", Offset = "0x694E590", VA = "0x18694FD90")]
	public void LHOJBBELALH(float3 CELAENHHOMK, quaternion NEMHMGOMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x694F940", Offset = "0x694E140", VA = "0x18694F940")]
	public bool GKNKEIBHIKJ([Out] float3 CELAENHHOMK, [Out] quaternion NEMHMGOMNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x694F5D0", Offset = "0x694DDD0", VA = "0x18694F5D0")]
	public bool BBIDPBJFAMJ([Out] float DPGCGKMDOOP, [Out] float EAHEEBJPJIA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct INOMIAAGGLN : IEquatable<INOMIAAGGLN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly PBDHGENIJKH ACMFILFJLEL;

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public BCKBAIPBKNN CLFKIENLAIL
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(BCKBAIPBKNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public GGKNEECAHMB OGGHIBHHBBN
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
		get
		{
			return default(GGKNEECAHMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	private KLGGLOMIJJG GIINLOOHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x69494C0", Offset = "0x6947CC0", VA = "0x1869494C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	private OEOPDIPHJKO AHMOEBNGLPF
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x6954060", Offset = "0x6952860", VA = "0x186954060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public bool HHGACLKLLCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x69536D0", Offset = "0x6951ED0", VA = "0x1869536D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public Vector3 NPNMPABLGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6954CB0", Offset = "0x69534B0", VA = "0x186954CB0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x69546F0", Offset = "0x6952EF0", VA = "0x1869546F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public Quaternion NIILCMPNFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x69538F0", Offset = "0x69520F0", VA = "0x1869538F0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x6953DA0", Offset = "0x69525A0", VA = "0x186953DA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public Vector3 FMHDCFKEJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x6954A20", Offset = "0x6953220", VA = "0x186954A20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x6954BE0", Offset = "0x69533E0", VA = "0x186954BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public Quaternion FIIADFGBHNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x6953710", Offset = "0x6951F10", VA = "0x186953710")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x6953470", Offset = "0x6951C70", VA = "0x186953470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public float OAINCPHPOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x69552C0", Offset = "0x6953AC0", VA = "0x1869552C0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x6953B30", Offset = "0x6952330", VA = "0x186953B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public float LCJAICMGMLE
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x6953540", Offset = "0x6951D40", VA = "0x186953540")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public Vector3 GBINFLEDHIN
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x69550F0", Offset = "0x69538F0", VA = "0x1869550F0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x6953E70", Offset = "0x6952670", VA = "0x186953E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public Vector3 IPBCOHHFANP
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x69543E0", Offset = "0x6952BE0", VA = "0x1869543E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public Matrix4x4 DPCIACMJMEL
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x6954DA0", Offset = "0x69535A0", VA = "0x186954DA0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
	public INOMIAAGGLN(PBDHGENIJKH PHFFNGDOHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x69493F0", Offset = "0x6947BF0", VA = "0x1869493F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x6953860", Offset = "0x6952060", VA = "0x186953860", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x69493E0", Offset = "0x6947BE0", VA = "0x1869493E0", Slot = "4")]
	public bool Equals(INOMIAAGGLN OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x6949660", Offset = "0x6947E60", VA = "0x186949660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x69541F0", Offset = "0x69529F0", VA = "0x1869541F0")]
	public IPIEAMMDHIP JDGOBHAKDBL()
	{
		return default(IPIEAMMDHIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x6953F40", Offset = "0x6952740", VA = "0x186953F40")]
	public void IIOOFJEEHDI([Out] Matrix4x4 GLLDBGEFOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x69551E0", Offset = "0x69539E0", VA = "0x1869551E0")]
	public void OMEMDIJKIMA([Out] Vector3 DNJHFFNIGCO, [Out] Quaternion PHAHCFMAGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x6954890", Offset = "0x6953090", VA = "0x186954890")]
	public void MFNCNLMOEKA([Out] Vector3 DNJHFFNIGCO, [Out] Quaternion PHAHCFMAGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x6954970", Offset = "0x6953170", VA = "0x186954970")]
	public void MFNCNLMOEKA([Out] RigidTransform KGFOMEMHIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x6953CA0", Offset = "0x69524A0", VA = "0x186953CA0")]
	public UniformTRS GMMCKAAGPMO()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x6953BE0", Offset = "0x69523E0", VA = "0x186953BE0")]
	public void GMMCKAAGPMO([Out] UniformTRS JHDLHPHDGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x69532B0", Offset = "0x6951AB0", VA = "0x1869532B0")]
	public UniformTRS BEDKELHBLFG()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x69531F0", Offset = "0x69519F0", VA = "0x1869531F0")]
	public void BEDKELHBLFG([Out] UniformTRS KGFOMEMHIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x6954240", Offset = "0x6952A40", VA = "0x186954240")]
	public Vector3 JEDMJEDJEOM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x6954DE0", Offset = "0x69535E0", VA = "0x186954DE0")]
	public void NGOKLNHOBNN([In] Vector3 IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x6953380", Offset = "0x6951B80", VA = "0x186953380")]
	public Vector3 BKKHGICAHII()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x6953070", Offset = "0x6951870", VA = "0x186953070")]
	public void AKKJKHKIBLK([In] Vector3 IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x6954EB0", Offset = "0x69536B0", VA = "0x186954EB0")]
	public Quaternion NJEIMHCKJCI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x6954120", Offset = "0x6952920", VA = "0x186954120")]
	public void JBMBLIIDDKJ([In] Quaternion IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x69544D0", Offset = "0x6952CD0", VA = "0x1869544D0")]
	public Quaternion KJLPAEHHEAB()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x6953CD0", Offset = "0x69524D0", VA = "0x186953CD0")]
	public void HHHBEAKFCFB([In] Quaternion IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x69532E0", Offset = "0x6951AE0", VA = "0x1869532E0")]
	public float BKGLNCMDIDB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x6954330", Offset = "0x6952B30", VA = "0x186954330")]
	public void JEMHHDFPPID(float IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x6955430", Offset = "0x6953C30", VA = "0x186955430")]
	public float PKCCJOILKGC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x6953140", Offset = "0x6951940", VA = "0x186953140")]
	public void AOAPBIBGKPK(float IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x6955360", Offset = "0x6953B60", VA = "0x186955360")]
	public void PIJPAOKEPPD([In] Vector3 IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x6953A40", Offset = "0x6952240", VA = "0x186953A40")]
	public Vector3 FNHNBEBNFJA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6954620", Offset = "0x6952E20", VA = "0x186954620")]
	public void KLLKLEFGILH([In] Vector3 IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x69535E0", Offset = "0x6951DE0", VA = "0x1869535E0")]
	public Vector3 DEKMFBPLNAM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x6954B10", Offset = "0x6953310", VA = "0x186954B10")]
	public void MPNOGAIPKFK([In] Vector3 IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6955000", Offset = "0x6953800", VA = "0x186955000")]
	public Vector3 NOABHBMLGJF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x69547C0", Offset = "0x6952FC0", VA = "0x1869547C0")]
	public void LDFLHEOFBIP([In] Vector3 IPHHABIKCHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class KKGNOPFAOMA
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private struct LPHOIDLMNNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Guid PGOHCHKMLGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public BPBMFNAFAEG BOPMAONNBDE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private struct BPBMFNAFAEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int IPHHABIKCHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int LFPDEFCHPIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int GDOAEOCAAIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int MCANLGBNODP;

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x694A310", Offset = "0x6948B10", VA = "0x18694A310")]
		public bool OEMNKLHMIFF([Out] GCPCGKHJGKN DLEBFLGACBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x694A3A0", Offset = "0x6948BA0", VA = "0x18694A3A0")]
		public BPBMFNAFAEG(GCPCGKHJGKN DLEBFLGACBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x69568A0", Offset = "0x69550A0", VA = "0x1869568A0")]
	public static Guid CFABCEOMNDJ(this GCPCGKHJGKN DLEBFLGACBD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6956880", Offset = "0x6955080", VA = "0x186956880")]
	public static bool AIMJHLBLDOA(this Guid PGOHCHKMLGH, [Out] GCPCGKHJGKN DLEBFLGACBD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal static class IODLINKMLAE
{
	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x69555A0", Offset = "0x6953DA0", VA = "0x1869555A0")]
	public static OKFMEEFLDCN IFGGGNEDOOG(this PBDHGENIJKH EGNLNANJFMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x69554D0", Offset = "0x6953CD0", VA = "0x1869554D0")]
	public static EFHMBHHCDOE COBIDGJJKBE(this PBDHGENIJKH EGNLNANJFMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x6955630", Offset = "0x6953E30", VA = "0x186955630")]
	public static EntityManager LPIEJIAIKCE(this PBDHGENIJKH EGNLNANJFMI)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4980", Offset = "0x2AD3180", VA = "0x182AD4980")]
	public static T BKDBGJLDJNN<T>(this PBDHGENIJKH EGNLNANJFMI) where T : struct, JHNFMAJOMPD
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5C40", Offset = "0x2AD4440", VA = "0x182AD5C40")]
	public static bool JIKFNDLMOHK<T>(this PBDHGENIJKH EGNLNANJFMI) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5F00", Offset = "0x2AD4700", VA = "0x182AD5F00")]
	public static bool PMNEDEJPCOM<T>(this PBDHGENIJKH EGNLNANJFMI) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface OHGOHIGMODC
{
	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LMLPMFOIDCB(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HFGBBNLJDFE(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EDGGOMCAHKM(PBDHGENIJKH PHFFNGDOHAF, [Out] Guid IKNLCPDILAM);

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid MDMFIKLBILF(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BHKFKDCIBOG(PBDHGENIJKH PHFFNGDOHAF, Guid IKNLCPDILAM);

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DOHDJDKNJLE(PBDHGENIJKH PHFFNGDOHAF, [Out] Guid FMPAALMFOIG);

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid IMONNBMKEAH(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DGNDFHEHJJA(PBDHGENIJKH PHFFNGDOHAF, Guid FMPAALMFOIG);

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PPNDNDJEFAN(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task GKMBBMHLMIA(PBDHGENIJKH CKKNFOBALJL, PBDHGENIJKH GGJNHHDMGON);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface CIDEAICIELN
{
	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	Guid CAOEHEAMHFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GIOKFKGPPJK(NativeList<Guid> AKKMJPINBIM, NativeList<Guid> OHKDIKBGECO, NativeList<FixedString64Bytes> HCKDNNJIOOD);
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface HOLEGFNAACB
{
	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPMKOCCGHPN(List<PBDHGENIJKH> IIAMEACJGMN);

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMMKLNNHEJA(List<PBDHGENIJKH> OALOGAIBJFE);

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FGECDPMEAKL(PBDHGENIJKH MLJIGDGHOBO);

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EPEJDBIJNDE(PBDHGENIJKH MLJIGDGHOBO);

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KEDAIPDFLMJ(PBDHGENIJKH MLJIGDGHOBO);

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int DPFKPDFHCGA(PBDHGENIJKH MLJIGDGHOBO);

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ICHLGNJFCNE(PBDHGENIJKH MLJIGDGHOBO, int HKJHDCJABMO);

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PBDHGENIJKH HJOHJOBJFMH(PBDHGENIJKH GOEIPMBMNMD);

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CCCEHLMJEEK(PBDHGENIJKH GOEIPMBMNMD, PBDHGENIJKH FLAOBBKMPDB);

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LBOPDNECFIJ(PBDHGENIJKH GOEIPMBMNMD);

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int APJLGKIAMMK(PBDHGENIJKH GOEIPMBMNMD);

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CADHBLDKPNA(PBDHGENIJKH GOEIPMBMNMD, int EIOJDKNCBIN);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	int BHINFGGNDEG(PBDHGENIJKH GOEIPMBMNMD);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GCMLOKCOPCH(PBDHGENIJKH GOEIPMBMNMD, int GNONDFLMDGB);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KPFEEKJBDPD(PBDHGENIJKH ACMFILFJLEL);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IJOKNKAIPIJ(PBDHGENIJKH PHFFNGDOHAF, bool ILIOPLLLNEP);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IJAMHFCMMPM(PBDHGENIJKH[] OPDFMPDAKPI, bool ILIOPLLLNEP);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface NMEBOJBNPJL
{
	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	IReadOnlyCollection<APLHCNNOPEK> LGLPLPLDILO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HKDOBIADFDJ(int COMFAOIGFPJ, [Out] APLHCNNOPEK CHIFHGDIIOI);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	APLHCNNOPEK HJMKGHJODDI(Type HKAKMPIMEOA);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class AKHMOBHCALF
{
	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x314AFD0", Offset = "0x31497D0", VA = "0x18314AFD0")]
	public static T CPBEHAGCAOF<T>(this NMEBOJBNPJL IMACCFJNMHN, Entity JIPIEBFBEML) where T : struct, JHNFMAJOMPD
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x314B080", Offset = "0x3149880", VA = "0x18314B080")]
	public static APLHCNNOPEK HJMKGHJODDI<T>(this NMEBOJBNPJL IMACCFJNMHN) where T : struct, JHNFMAJOMPD
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface FMNOGJNJCNP
{
	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GCPCGKHJGKN[] AJADDFKCOBI(string GCDLMFGKKMH, BCKBAIPBKNN LLFFFDCMGPB, bool FKENGHPEBAP = false);

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MMEAGBINDDP(string EDHNNIHIAFG, GCPCGKHJGKN[] NNGIKAPCELN);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface ALDDMJNLKBP
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<PBDHGENIJKH, PBDHGENIJKH> CPMCDHLCINC;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<PBDHGENIJKH, PBDHGENIJKH> JBEFAGKKOMN;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<PBDHGENIJKH, PBDHGENIJKH, PBDHGENIJKH> MAJMEPADHJN;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<PBDHGENIJKH> KNHEOFIKENH;

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GNPJOOIKBIA(PBDHGENIJKH PHFFNGDOHAF, PBDHGENIJKH AKLBOKGHOKD);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PBDHGENIJKH PACGONLNJGP(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<PBDHGENIJKH> GBIJLDABCDM(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	PBDHGENIJKH MGLJIJCOKPF(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DHEGAJELPJN(PBDHGENIJKH PHFFNGDOHAF, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DAIICKMBGED(PBDHGENIJKH PHFFNGDOHAF, float OJLHODMLAFN);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool KDDNPMHCHHG(PBDHGENIJKH PHFFNGDOHAF, [Out] PBDHGENIJKH GGJNHHDMGON);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool PMJIKBLDJEI(PBDHGENIJKH PHFFNGDOHAF, [Out] RigidTransform FNOLHKKLFJM);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool BCEDLIOFBHF(PBDHGENIJKH PHFFNGDOHAF, [Out] float APBHJBIEOEA);

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 MEICKBIBANA(MGIMJBEMNBJ OGNAKNBDFIL);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "18")]
	quaternion IJDBEPGECOF(MGIMJBEMNBJ OGNAKNBDFIL);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class FNJJAAHBKPI
{
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface DOANDLGHKND
{
	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	object MNKGILBKIKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HNFOPGCJFMA(IMJGNGJFNGC OPDFMPDAKPI);
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public readonly struct DMPDDMOMNGN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly string GCDLMFGKKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly T HLCNDDGKJJF;

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x57B5000", Offset = "0x57B3800", VA = "0x1857B5000")]
	public DMPDDMOMNGN(T HLCNDDGKJJF, [Optional][CallerMemberName] string GCDLMFGKKMH)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly DMPDDMOMNGN<int> JGCCJMBIKJD;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum FGKHHNGOCFK
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class DFAJMCFGKKO
{
	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0xD32890", Offset = "0xD31090", VA = "0x180D32890")]
	public static bool CKBDJHCPJFF(this FGKHHNGOCFK DAGLKLOEBMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0xD32660", Offset = "0xD30E60", VA = "0x180D32660")]
	public static bool MDFKGLIENFD(this FGKHHNGOCFK DAGLKLOEBMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x247DDD0", Offset = "0x247C5D0", VA = "0x18247DDD0")]
	public static bool PAGJEGFGJJF(this FGKHHNGOCFK DAGLKLOEBMA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface BHDDNBFNGGC
{
	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	bool PKCDACEIFMO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface MMNOFDDOHLI
{
	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	FGKHHNGOCFK ABDAGJJOKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	FGKHHNGOCFK IEMOCPOOCJG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	FGKHHNGOCFK DBMPDAIGBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	FGKHHNGOCFK AOKMMIFKCDE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	FGKHHNGOCFK DDBPMFKFDGM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	FGKHHNGOCFK LGENEJPHBGM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	FGKHHNGOCFK JGAFMHCIKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	FGKHHNGOCFK DEEOEJJACPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	FGKHHNGOCFK PGBECFOADPO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	FGKHHNGOCFK MCLCJONGAME
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	FGKHHNGOCFK HLJKGBFBEPN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	FGKHHNGOCFK OKBAKLHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	FGKHHNGOCFK JIDFEHFKECP
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	FGKHHNGOCFK CBHKHBDPDIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	FGKHHNGOCFK AIADJJACALL
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NBGKOOJKKKA(DMPDDMOMNGN<int> LNOEPHEPJGF);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface MKGBMLANGKF
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<IFPPOKJFEIG> JFIAMBNLODG;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PBDHGENIJKH LJLKIFBIEHB(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KOADBMMIHOM(List<PBDHGENIJKH> OALOGAIBJFE);

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KMAJGEEABAB HCAEABCBKOG(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KMAJGEEABAB PFOJKCNBHIM(PBDHGENIJKH GGJNHHDMGON, PBDHGENIJKH AMBKIFNGGDN, bool OOMLIDMOFPP, PBDHGENIJKH LFFBLPMMGND);

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PBDHGENIJKH BPHPODIDNCF(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BFFDCAOPJND(PBDHGENIJKH PHFFNGDOHAF, PBDHGENIJKH GGJNHHDMGON, bool BFMLLILPKHA);

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EEBNCBLACLH(PBDHGENIJKH PHFFNGDOHAF, PBDHGENIJKH GGJNHHDMGON);

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool EIMJFEMMJOB(PBDHGENIJKH AGOILNNHDLI, PBDHGENIJKH HFLCCHLJDMO);

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int HJGHMFDKCBC(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IMJGNGJFNGC FLHELBMCGBN(PBDHGENIJKH ACMFILFJLEL);

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NativeArray<PBDHGENIJKH> POIOJCONGMA(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool BNBDDPHJMEF(PBDHGENIJKH PHFFNGDOHAF, PBDHGENIJKH IEOEAICPLBD);

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<PBDHGENIJKH> OHBJFNCKDFI(PBDHGENIJKH PHFFNGDOHAF, bool BKIPGDMDFMJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool HALDJFGILLM(PBDHGENIJKH PHFFNGDOHAF, PBDHGENIJKH FOFBODJKPLN);

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(Slot = "16")]
	PBDHGENIJKH NMFHKHPFMDN(PBDHGENIJKH LFFBLPMMGND, PBDHGENIJKH HMCNBKHDPKF);

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool GLKFBGFLHNI(PBDHGENIJKH LFFBLPMMGND, PBDHGENIJKH HMCNBKHDPKF, [Out] PBDHGENIJKH IJNHCGGPCDO);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public static class FNFAOALCDCI
{
	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x694D410", Offset = "0x694BC10", VA = "0x18694D410")]
	public static List<PBDHGENIJKH> KOADBMMIHOM(this MKGBMLANGKF GPGBLFPGCJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x694D520", Offset = "0x694BD20", VA = "0x18694D520")]
	public static bool PFCCDAMMLFD(this MKGBMLANGKF GPGBLFPGCJO, PBDHGENIJKH PHFFNGDOHAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface GLNJIKIIMBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EIJIJHCHANM PJAHDMIIPLH(PBDHGENIJKH MLJIGDGHOBO);

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FDJBNPIBFEB(PBDHGENIJKH MLJIGDGHOBO, EIJIJHCHANM OMGGIBDNMDA);

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BGKNGFAEJKC(PBDHGENIJKH MLJIGDGHOBO);

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GHKGJIBOJKB(PBDHGENIJKH MLJIGDGHOBO, bool IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string[] IMPAMDIKOMH(PBDHGENIJKH MLJIGDGHOBO);

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KEBMGEGFMJC(PBDHGENIJKH MLJIGDGHOBO, IEnumerable<string> KJGCAHPCGKA);

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string[] EMJKNIGKHIF(PBDHGENIJKH MLJIGDGHOBO);

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EJNMGPCPHJH(PBDHGENIJKH MLJIGDGHOBO, IEnumerable<string> KJGCAHPCGKA);

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "8")]
	string[] IAEHLDNBJED(PBDHGENIJKH MLJIGDGHOBO);

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BJALJLOLOGD(PBDHGENIJKH MLJIGDGHOBO, IEnumerable<string> KJGCAHPCGKA);

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string[] LLJBILLFKCA(PBDHGENIJKH MLJIGDGHOBO);

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AKEAPDBKOHC(PBDHGENIJKH MLJIGDGHOBO, IEnumerable<string> KJGCAHPCGKA);

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool KPFGDBHFMGE(PBDHGENIJKH MLJIGDGHOBO, PBDHGENIJKH PENGDIMNCLF);
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface HIFAPHBLLHA
{
	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	bool OMOAKEHDLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	bool NGCBBNKOIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface OPPNMKGEGMF : HDNPKFNMCGM
{
	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LEHKHMEGMJM(Entity JIPIEBFBEML, [Out] MNDDOINCLIO PFACKKBJPID);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADIFCJDJIEM(NativeArray<MNDDOINCLIO> GBLMJGKPHME, NativeArray<HNOCCMOEEGD> EBOJBKOEKJA);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void COCMOJMMOHK(MNDDOINCLIO PFACKKBJPID);

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GEMGIMHBEEC(MNDDOINCLIO PFACKKBJPID, [Out] Collider NEBJBGFEICB);
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface HDNPKFNMCGM
{
	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFJKDGMOPBD([In] float3 KAIFHAHFLAN, [In] float3 NHPNENOFEDP, float NGOKPHBDKPG, Allocator KCJKALFMGMC, [Out] NativeArray<Entity> CLKMHECJDKN);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface JEGJMFAEFCH
{
	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFJKDGMOPBD([In] float3 KAIFHAHFLAN, [In] float3 NHPNENOFEDP, float NGOKPHBDKPG, [Out] DMENEOMKOJL DLIPEMJKKBN, [Out] PBDHGENIJKH NMJBHNPAEDN);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface MMHHJDHNMGC
{
	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFJKDGMOPBD([In] NativeArray<Entity> CLKMHECJDKN, [In] float3 KAIFHAHFLAN, [In] float3 NHPNENOFEDP, [In] NativeArray<DMENEOMKOJL> PCPHIKGNKKK);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct MNDDOINCLIO : POIKBLLOAII, IEquatable<MNDDOINCLIO>
{
	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public int CFDBFCCMKIM
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x8FC6D0", Offset = "0x8FAED0", VA = "0x1808FC6D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xA36A50", Offset = "0xA35250", VA = "0x180A36A50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public int BCBMJBGNDJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x248EF50", Offset = "0x248D750", VA = "0x18248EF50", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x5C84E60", Offset = "0x5C83660", VA = "0x185C84E60", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x6958020", Offset = "0x6956820", VA = "0x186958020", Slot = "8")]
	public bool Equals(MNDDOINCLIO OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x6958070", Offset = "0x6956870", VA = "0x186958070", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct DMENEOMKOJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float DABDJLLOPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 ANAAMNHLGOD;
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface CGMGHHMJCPK
{
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface KLGGLOMIJJG
{
	[Cpp2IlInjected.Token(Token = "0x17000191")]
	OKFMEEFLDCN IFGGGNEDOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	HCJDJCLLHFI DIDGOKNAOPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<IMJGNGJFNGC, NativeArray<MLDAFHLMJPK>> MHGGLMAEHPH;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<IMJGNGJFNGC> OPKKFNKBOGA;

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NKJKJPLFHNG OALPALNIOCO(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MLDAFHLMJPK KMEEJHNFCBA(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MPPLGFJBDHC(GCPCGKHJGKN DLEBFLGACBD, GCDLKIMIFND ALCMDLBDDMK);

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PKDMFJJKGEB(GCPCGKHJGKN[] NNGIKAPCELN, GameObject DLBGNHFNDNP);

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BCKBAIPBKNN CMOFMDNJILG(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FENMBNPGGBC(PBDHGENIJKH PHFFNGDOHAF, [Out] Transform MCHMJHAODPL);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool CDBAJNFOGDA(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FAANGLCBJGO(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "14")]
	PBDHGENIJKH LPBHPIOJCOG(GCPCGKHJGKN DLEBFLGACBD);

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool NABIEOKCLOM(GCPCGKHJGKN DLEBFLGACBD, [Out] PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "16")]
	GCPCGKHJGKN GDCGACPNNPJ(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IMJGNGJFNGC LPBHPIOJCOG(NativeArray<GCPCGKHJGKN> DLEBFLGACBD, Allocator KCJKALFMGMC);

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "18")]
	IMJGNGJFNGC OAHPKCBPBPP(MLDAFHLMJPK HLCODDJIAJC, int POAAACAIHKJ, Allocator KCJKALFMGMC);

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IMJGNGJFNGC HAKOEJBFNAK(NativeArray<GCPCGKHJGKN> DLEBFLGACBD, NativeArray<AAOBNIPHHDN> GKGLNDIDHCI, Allocator KCJKALFMGMC);

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "20")]
	GCPCGKHJGKN[] AJADDFKCOBI(string EDHNNIHIAFG, BCKBAIPBKNN LLFFFDCMGPB, bool FKENGHPEBAP);

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void MMEAGBINDDP(string EDHNNIHIAFG, GCPCGKHJGKN[] NNGIKAPCELN);

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(Slot = "22")]
	BCKBAIPBKNN CFPIBNKDHHP(MLDAFHLMJPK HLCODDJIAJC, bool OKKFOONDJNP);

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	BCKBAIPBKNN CFPIBNKDHHP(MLDAFHLMJPK HLCODDJIAJC);

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	BCKBAIPBKNN DLJBOPCKCEF(MLDAFHLMJPK HLCODDJIAJC);

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	BCKBAIPBKNN BJPOKMGHGAA(MLDAFHLMJPK HLCODDJIAJC);

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "26")]
	BCKBAIPBKNN PLJMOKGEECE(GCPCGKHJGKN DLEBFLGACBD, MLDAFHLMJPK HLCODDJIAJC);

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "27")]
	NPBNJEHNJDF EBBJMJMEKBP();

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(Slot = "28")]
	HPGFGBAMMOA KACFHHHMCDK();

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "29")]
	OGIJAOKFLIM PCADNJEOLHP(DOAIKOFFLKL ICLBCKPDFAG);

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void HIHAJDAPMFN(IMJGNGJFNGC OPDFMPDAKPI);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void PGFGBHFCFEG(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void IIEPIMHAEJM(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void HIHAJDAPMFN(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void NMKPPKGMKBF(PBDHGENIJKH OPDFMPDAKPI);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool PIOKMOPPFIP(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "36")]
	IMJGNGJFNGC DAOENGCMEAA(IMJGNGJFNGC PBBBJNDHJMF, Allocator KCJKALFMGMC);

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool HMKIEFDGCCL(PBDHGENIJKH PHFFNGDOHAF);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class FEALMNKLIAJ
{
	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x694CC90", Offset = "0x694B490", VA = "0x18694CC90")]
	public static void FAANGLCBJGO(this KLGGLOMIJJG EGHKIPPNLDD, GCDLKIMIFND ALCMDLBDDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x694D160", Offset = "0x694B960", VA = "0x18694D160")]
	public static BCKBAIPBKNN LFDFEPHFNNF(this KLGGLOMIJJG EGHKIPPNLDD, LocalId PHFFNGDOHAF)
	{
		return default(BCKBAIPBKNN);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x694D100", Offset = "0x694B900", VA = "0x18694D100")]
	public static BCKBAIPBKNN LFDFEPHFNNF(this KLGGLOMIJJG EGHKIPPNLDD, GCPCGKHJGKN DLEBFLGACBD)
	{
		return default(BCKBAIPBKNN);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x694D160", Offset = "0x694B960", VA = "0x18694D160")]
	public static PBDHGENIJKH LPBHPIOJCOG(this KLGGLOMIJJG EGHKIPPNLDD, LocalId PHFFNGDOHAF)
	{
		return default(PBDHGENIJKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x694CD10", Offset = "0x694B510", VA = "0x18694CD10")]
	public static GCPCGKHJGKN GDCGACPNNPJ(this KLGGLOMIJJG EGHKIPPNLDD, LocalId PHFFNGDOHAF)
	{
		return default(GCPCGKHJGKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x694CD90", Offset = "0x694B590", VA = "0x18694CD90")]
	public static bool HMKIEFDGCCL(this KLGGLOMIJJG EGHKIPPNLDD, GCPCGKHJGKN DLEBFLGACBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x2A6D310", Offset = "0x2A6BB10", VA = "0x182A6D310")]
	public static T PAIILCHHHPM<T>(this KLGGLOMIJJG EGHKIPPNLDD, LocalId PHFFNGDOHAF) where T : struct, JHNFMAJOMPD
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x694CE00", Offset = "0x694B600", VA = "0x18694CE00")]
	public static NPBNJEHNJDF IKAMNIBPCHO(this KLGGLOMIJJG EGHKIPPNLDD, RigidTransform JHDLHPHDGCE)
	{
		return default(NPBNJEHNJDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x694D190", Offset = "0x694B990", VA = "0x18694D190")]
	public static OGIJAOKFLIM MGMDGKPIEJF(this KLGGLOMIJJG EGHKIPPNLDD, DOAIKOFFLKL MCAIFPINGIA, RigidTransform JHDLHPHDGCE)
	{
		return default(OGIJAOKFLIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x694CB90", Offset = "0x694B390", VA = "0x18694CB90")]
	public static HPGFGBAMMOA BKAHKOLLJDJ(this KLGGLOMIJJG EGHKIPPNLDD, RigidTransform JHDLHPHDGCE)
	{
		return default(HPGFGBAMMOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x694CF00", Offset = "0x694B700", VA = "0x18694CF00")]
	private static void JAHADAPLNCM(BCKBAIPBKNN DCGFGAGJJFJ, RigidTransform JHDLHPHDGCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface LMGAGOLNIJL
{
	[Cpp2IlInjected.Token(Token = "0x17000193")]
	bool PPKGBPHJHFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	PBDHGENIJKH KOKLJBNODIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	BCKBAIPBKNN DJDBKCHMFBF
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event NGJCIHDILGN AHPMKGNHNAJ;

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PBDHGENIJKH NMFHKHPFMDN(PBDHGENIJKH LFFBLPMMGND, PBDHGENIJKH HMCNBKHDPKF);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GLKFBGFLHNI(PBDHGENIJKH LFFBLPMMGND, PBDHGENIJKH HMCNBKHDPKF, [Out] PBDHGENIJKH IJNHCGGPCDO);

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OOAGKDLKDNO();

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CBBNFKENHNI();

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool GJBGHCMMKCM(PBDHGENIJKH LFFBLPMMGND);

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NPHBCCJPGPD(PBDHGENIJKH LFFBLPMMGND);
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public delegate void NGJCIHDILGN(BCKBAIPBKNN DMEMLBJOMBO, BCKBAIPBKNN HJJHMCOJKHB);
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class GMGPLJKMCCL
{
	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x694E2D0", Offset = "0x694CAD0", VA = "0x18694E2D0")]
	public static bool NHLHKOJEEPG(this LMGAGOLNIJL HCHNFOPLEGA, BCKBAIPBKNN LFFBLPMMGND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x694E1F0", Offset = "0x694C9F0", VA = "0x18694E1F0")]
	public static bool LMBMGGCBMKK(this LMGAGOLNIJL HCHNFOPLEGA, PBDHGENIJKH LFFBLPMMGND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x694E170", Offset = "0x694C970", VA = "0x18694E170")]
	public static bool BNNFLIAOBAA(this LMGAGOLNIJL HCHNFOPLEGA, PBDHGENIJKH LFFBLPMMGND)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface OCDKHJHJLJB
{
	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LKKMDHEEFPA(BCKBAIPBKNN DCGFGAGJJFJ, JBMHKOHEBLO NBMJJDIPDAE, List<BCKBAIPBKNN> KOGKINGMFGP);

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int IFOKJCEAMJG(BCKBAIPBKNN DCGFGAGJJFJ, JBMHKOHEBLO NBMJJDIPDAE);

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KKKJPKACCEC(BCKBAIPBKNN DCGFGAGJJFJ, List<BCKBAIPBKNN> KOGKINGMFGP);

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int AEDBEMBEOJF(BCKBAIPBKNN ECKNMNLLOJH, BCKBAIPBKNN LFFBLPMMGND, JBMHKOHEBLO NBMJJDIPDAE);

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BCKBAIPBKNN DLLCPMBBFPI(BCKBAIPBKNN ECKNMNLLOJH, int JBDLDJOINOF, JBMHKOHEBLO NBMJJDIPDAE);

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OAKOCECIOOH(BCKBAIPBKNN ECKNMNLLOJH, BCKBAIPBKNN LFFBLPMMGND, JBMHKOHEBLO NBMJJDIPDAE);

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BIEFGLMFEKH(BCKBAIPBKNN ECKNMNLLOJH, BCKBAIPBKNN LFFBLPMMGND, JBMHKOHEBLO NBMJJDIPDAE);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EDGCDPLBKKH(BCKBAIPBKNN ECKNMNLLOJH, JBMHKOHEBLO NBMJJDIPDAE);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IHAFPDFGEBL(BCKBAIPBKNN ECKNMNLLOJH, BCKBAIPBKNN LFFBLPMMGND, JBMHKOHEBLO NBMJJDIPDAE);

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GFGDHGGKNGN(Entity ECKNMNLLOJH, Entity LFFBLPMMGND, JBMHKOHEBLO NBMJJDIPDAE);

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NLJLOOJLAAD(Entity ECKNMNLLOJH, JBMHKOHEBLO NBMJJDIPDAE);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface BLGOJBONPNN
{
	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OANHJDCLEOJ(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ECAEFBHHIPE(PBDHGENIJKH PHFFNGDOHAF, Transform MCHMJHAODPL);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface FEEEGPEJPCE
{
	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ANIDOPBKPBJ(PBDHGENIJKH LFFBLPMMGND, PBDHGENIJKH DKIBGNNJMFJ);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DOLOIMPHNLA(PBDHGENIJKH LFFBLPMMGND, PBDHGENIJKH KMPJDLCJLJH);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HBKOJINJEHM(PBDHGENIJKH LFFBLPMMGND, [Out] PBDHGENIJKH FKLPMABGMHH);
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface LCLFLEADMLI
{
	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEILHPOOCHE(PBDHGENIJKH ACMFILFJLEL, bool IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GLKAJJKBPNP(PBDHGENIJKH ACMFILFJLEL, bool IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BHMOCAOHKHF(PBDHGENIJKH ACMFILFJLEL, int IPHHABIKCHD);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface JLODODAJBKB
{
	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<PBDHGENIJKH> KOLFPBJMFAE(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PBDHGENIJKH GCCGOCEHLGG(PBDHGENIJKH PHFFNGDOHAF, int JBDLDJOINOF);

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int BIJNMHIBCPP(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MBCNCENFLII EILDEIIDBIJ(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NJFGDGGEHFH(PBDHGENIJKH PHFFNGDOHAF, MBCNCENFLII EKJGIMBPPBA);

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PBDHGENIJKH GOMCHANAPFJ(PBDHGENIJKH PHFFNGDOHAF, [Optional] float3? GBKEBGLIOFD, [Optional] quaternion? LOMIHBHMPMH, [Optional] float3? KEONANJCBKH);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PBDHGENIJKH DAIOGMNAJLL(PBDHGENIJKH PHFFNGDOHAF, int JBDLDJOINOF, [Optional] float3? GBKEBGLIOFD, [Optional] quaternion? LOMIHBHMPMH, [Optional] float3? KEONANJCBKH);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JCHAAIOIAFH(PBDHGENIJKH PHFFNGDOHAF, int JBDLDJOINOF);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EJHJOLAPEFA(PBDHGENIJKH PHFFNGDOHAF);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface OHELDAFNEMO
{
	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IKGIHNLDDGA();

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GNMNINAFCLJ();

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJHLFPEIGLO();

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BLMJDBHHJMP();

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LIBNBOHIAMK();

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KDIHHJICAFO();

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OBIPFAIDCIL();

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OILPFICOJJN();

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BDAIBJLKCKA();

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JEEKJFFMLLH();

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OCCFPMEHCID();

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PFEIOKJFNNL();

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ENLLGACJEOL();
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface IIADBCPLHOP
{
	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KECCBLBKCMI(PBDHGENIJKH LFFBLPMMGND, [Out] int ECKNMNLLOJH);

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GHHMHAMCEJB(PBDHGENIJKH LFFBLPMMGND, int ECKNMNLLOJH);

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KMMKNKIALEP(PBDHGENIJKH LFFBLPMMGND, bool IOAFJLAKIKP);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BDNFLIFKCPI(PBDHGENIJKH LFFBLPMMGND, bool GEHBNGFIMJE);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HBGMIBOLCAJ(PBDHGENIJKH LFFBLPMMGND, float DPPFIEGKAEB, float KLIDHAOEIFK, float DNNDLKEKBON);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BBIDPBJFAMJ(PBDHGENIJKH PHFFNGDOHAF, [Out] float KLIDHAOEIFK, [Out] float DNNDLKEKBON);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LHOJBBELALH(PBDHGENIJKH LFFBLPMMGND, float3 GBKEBGLIOFD, quaternion LOMIHBHMPMH);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool GKNKEIBHIKJ(PBDHGENIJKH LFFBLPMMGND, [Out] float3 GBKEBGLIOFD, [Out] quaternion LOMIHBHMPMH);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface OEOPDIPHJKO
{
	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFGEIHFGHFA(Entity JIPIEBFBEML);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NGOKLNHOBNN(Entity JIPIEBFBEML, [In] float3 IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 JEDMJEDJEOM(Entity JIPIEBFBEML);

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JBMBLIIDDKJ(Entity JIPIEBFBEML, [In] quaternion IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion NJEIMHCKJCI(Entity JIPIEBFBEML);

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OMEMDIJKIMA(Entity JIPIEBFBEML, [Out] float3 GBKEBGLIOFD, [Out] quaternion LOMIHBHMPMH);

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OMEMDIJKIMA(Entity JIPIEBFBEML, [Out] RigidTransform MDBPANCBBKJ);

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MFNCNLMOEKA(Entity JIPIEBFBEML, [Out] float3 GBKEBGLIOFD, [Out] quaternion LOMIHBHMPMH);

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MFNCNLMOEKA(Entity JIPIEBFBEML, [Out] RigidTransform MDBPANCBBKJ);

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	float3 JHPLBBHCFBH(Entity JIPIEBFBEML);

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PIJPAOKEPPD(Entity JIPIEBFBEML, [In] float3 IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JEMHHDFPPID(Entity JIPIEBFBEML, float IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float BKGLNCMDIDB(Entity JIPIEBFBEML);

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MPNOGAIPKFK(Entity JIPIEBFBEML, [In] float3 IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	float3 DEKMFBPLNAM(Entity JIPIEBFBEML);

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AKKJKHKIBLK(Entity JIPIEBFBEML, [In] float3 IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 BKKHGICAHII(Entity JIPIEBFBEML);

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HHHBEAKFCFB(Entity JIPIEBFBEML, [In] quaternion IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "18")]
	quaternion KJLPAEHHEAB(Entity JIPIEBFBEML);

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 FNHNBEBNFJA(Entity JIPIEBFBEML);

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void KLLKLEFGILH(Entity JIPIEBFBEML, [In] float3 IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void AOAPBIBGKPK(Entity JIPIEBFBEML, float IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float PKCCJOILKGC(Entity JIPIEBFBEML);

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void LDFLHEOFBIP(Entity JIPIEBFBEML, [In] float3 IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "24")]
	float3 NOABHBMLGJF(Entity JIPIEBFBEML);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void IIDBCOOIKLJ(Entity JIPIEBFBEML, [Out] float4x4 GLLDBGEFOBO);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void ECGIOBPPEIM(Entity JIPIEBFBEML, [In] float4x4 GLLDBGEFOBO);

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void KMIAJIAPGDB(Entity JIPIEBFBEML, [Out] float4x4 GLLDBGEFOBO);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool FENMBNPGGBC(Entity JIPIEBFBEML, [Out] Transform MCHMJHAODPL);

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void DKJJFIHEJNE(Entity JIPIEBFBEML);

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void OGMHLFDGBJO(Entity JIPIEBFBEML, Entity BHNOOIHFKDH, Entity OGAPKPCGEHM);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class HKFFCGIAMMI
{
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface INDFCJGLIBA
{
	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKKJFEHJMPL(bool EJKKPOHPAHN);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface AEGONIEAOGB
{
	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDJPADKGEEM(PBDHGENIJKH MLJIGDGHOBO, IEnumerable<string> KJGCAHPCGKA);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OOENDKJKAPB(PBDHGENIJKH MLJIGDGHOBO, IEnumerable<string> KJGCAHPCGKA);

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KJFLCKDGIKG(PBDHGENIJKH MLJIGDGHOBO, params string[] KJGCAHPCGKA);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EKOGAICIFBO(PBDHGENIJKH MLJIGDGHOBO, params string[] KJGCAHPCGKA);

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FLMDMNOPDKM(PBDHGENIJKH MLJIGDGHOBO, params string[] KJGCAHPCGKA);

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ALLNCMHCCGC(PBDHGENIJKH MLJIGDGHOBO, params string[] KJGCAHPCGKA);

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int FFEIPMKPMPD(PBDHGENIJKH MLJIGDGHOBO);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int LBABPMKBOCK(PBDHGENIJKH MLJIGDGHOBO);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BFOBALAAIAL(PBDHGENIJKH MLJIGDGHOBO, ICollection<string> INMPCJAIIGO);

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LMBEAILLJLI(PBDHGENIJKH MLJIGDGHOBO, ICollection<string> INMPCJAIIGO);

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool GPJFDKACIGB(PBDHGENIJKH MLJIGDGHOBO, string MAMHFGLGIND);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MEBKFFHEBIN(string MAMHFGLGIND, NBBBBHELMOF JOAOMENFFJD);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BJAIKHIBHDH(string MAMHFGLGIND, NBBBBHELMOF JOAOMENFFJD);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool KMNAHNNJBJG();

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PKEMCMNABDG(IEnumerable<string> KJGCAHPCGKA);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface POFNHMAMHJA
{
	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World BICKKIPHEHH(string GBIJBLHAHGK = "Main");

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World OHBJHAMKMDM(string GBIJBLHAHGK = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World AHJEMIIAHKK(string GBIJBLHAHGK = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World LNFDMNEMIGF(string GBIJBLHAHGK = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface EFHMBHHCDOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000196")]
	World GFIBAGKFCPI
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	World JHCJADHJCKH
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	EntityManager LPIEJIAIKCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	bool MNHFNMLEMKK
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase FMJMCHIBBLA(Type HKAKMPIMEOA);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class NFIODLLHKGK
{
	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x6959B10", Offset = "0x6958310", VA = "0x186959B10")]
	public static ComponentSystemBase PIPDOLLNGDN(this World NGKMHGNGADJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x2BDC020", Offset = "0x2BDA820", VA = "0x182BDC020")]
	public static T FMJMCHIBBLA<T>(this EFHMBHHCDOE JKALDNMNLCF) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface KKAPACIGFEE
{
	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOAFJLCGJOC(NativeListAsync<Entity> MCEOIHENDCG);

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MHPPABFGJPN(PGDBGHABCPE GMKHIMLLPFH);

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJNDDLDHPGL(NativeListAsync<Entity> KKNKFPMHBKC, bool OGPENOALNJC);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LPCJEHAFMPB();
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface IFNJDKHDAHP
{
	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FIIHPAKJJAM(Collider NEBJBGFEICB, [Out] FFMOAGNKKDO CKLNCMLIKAM);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface CJLLKMODLHF
{
	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PLEIKHDBPFJ(PBDHGENIJKH PHFFNGDOHAF, [Out] Collider NEBJBGFEICB);

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject FHODKOCBEEP(PBDHGENIJKH BLGOOMAPJIE, GameObject OFMCNHNFFAE, Vector3 KKDCNJKFOII, Quaternion HGJODEDMNMO);

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLHAMBNFPJE(GameObject NEBJBGFEICB);

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider ELAGGMJODPB<TCollider>(GameObject JJNMDNJEBME) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OGJAGIGDIHK(Collider NEBJBGFEICB);

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject LDPDLGDPGOD<TCollider>(string GCDLMFGKKMH) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public enum DMDBAJJKKDP
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
[Cpp2IlInjected.Token(Token = "0x2000099")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface HKACEJLCJNN
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public struct KIEKMHPPNNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int BEKKJCDIOPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public GameObject OFMCNHNFFAE;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFLGLFINHBD(PBDHGENIJKH PHFFNGDOHAF, ODNJDOOHIFJ BLDPHJHLJMJ, bool AJMJOBKLPOH, KNIOBLBDGHD EOJDDPLBFCB);

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CNONKICFDJG(PBDHGENIJKH PHFFNGDOHAF, ODNJDOOHIFJ BLDPHJHLJMJ, bool AJMJOBKLPOH, bool NDJOJNJBDJB, bool NGGCKOKCKNP);

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DGCAKFDHMLL OHMADHGPJCL(PBDHGENIJKH AHKBBGKKCNK, List<PBDHGENIJKH> GENIPHEPOGF);

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CFPJHOKGNGK(GameObject MBAKFAJDGME, GameObject OCDKOFANMOD);

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IPFDBKIEGBO(GameObject MBAKFAJDGME, [In] OMHIDPJPNNC<GameObject> BDCEIDNFCCA);

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KKCMDDBHKNA(GameObject OCDKOFANMOD);

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T ELAGGMJODPB<T>(GameObject JJNMDNJEBME) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OGJAGIGDIHK(Collider NEBJBGFEICB);

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NIENJOIOLEA(IMJGNGJFNGC PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MKCKHPELDJL(IMJGNGJFNGC PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GameObject DCIOGBALENB<T>(string GCDLMFGKKMH) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IBFOGPIHHOL(Collider NEBJBGFEICB, [Out] PBDHGENIJKH ECKNMNLLOJH);

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool EKDJFDLBLEN(PBDHGENIJKH PHFFNGDOHAF, [Out] FFMOAGNKKDO CKLNCMLIKAM);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<DMDBAJJKKDP> HFKCIIIOGEA(Allocator KCJKALFMGMC = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Mesh[] DAOECBKHKEB();

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int DDMLCMBKLOP(ODNJDOOHIFJ BLDPHJHLJMJ);

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string BLHKBCKCFMI(ODNJDOOHIFJ BLDPHJHLJMJ);
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface PFMNPFOFANG
{
	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FMNJLOIFMNG(PBDHGENIJKH PHFFNGDOHAF, PBDHGENIJKH IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEHKHJKDOJE(PBDHGENIJKH PHFFNGDOHAF, PBDHGENIJKH IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int HJGHMFDKCBC(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PBDHGENIJKH HDBMOBPFKBC(PBDHGENIJKH PHFFNGDOHAF, int JBDLDJOINOF);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IMJGNGJFNGC GOJJLGAOHLO(PBDHGENIJKH PHFFNGDOHAF, Allocator KCJKALFMGMC = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JBGGGEHKLNE(PBDHGENIJKH PHFFNGDOHAF, object OECMOOGGOOF, PBDHGENIJKH IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KHGHAIHMNJB(PBDHGENIJKH PHFFNGDOHAF, object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OKMCCAAHGJO(PBDHGENIJKH PHFFNGDOHAF, [Out] PBDHGENIJKH IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ILALJNELIBI(PBDHGENIJKH PHFFNGDOHAF, float3 IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool EOIILOHJFON(PBDHGENIJKH PHFFNGDOHAF, [Out] float3 IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AELAKCIIDPF(PBDHGENIJKH PHFFNGDOHAF, float3 IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NKIPKLHOCLK(PBDHGENIJKH PHFFNGDOHAF, [Out] float3 IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JGHGIJLGBPL(PBDHGENIJKH PHFFNGDOHAF, (Quaternion rot, Vector3 moments) EJDPIICEIBJ);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool PFOPCDCKKPI(PBDHGENIJKH PHFFNGDOHAF, [Out] quaternion OOJJBHEGACK, [Out] float3 CLJAEMFLHFA);

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PLGFKAPPHNI(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 GOGKKNOIAHA(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 DNMDKOCFNKK(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FMKKFDJHIAC(PBDHGENIJKH PHFFNGDOHAF, float3 IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OECLMNDIEIC(PBDHGENIJKH PHFFNGDOHAF, float3 IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float IMADNIELOLA(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float IEIHLIFDBBF(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void HAGPGJIKOJH(PBDHGENIJKH PHFFNGDOHAF, float IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void EDNNADGCJME(PBDHGENIJKH PHFFNGDOHAF, float IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode PJCDBKJHGMC(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IGBEGEMHOFO(PBDHGENIJKH PHFFNGDOHAF, CollisionDetectionMode IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "25")]
	COGJEJCHONG GGHAAPMFBBG(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void AINFODPANGD(PBDHGENIJKH PHFFNGDOHAF, COGJEJCHONG IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool GKNBPGENGEJ(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void POIMAFBLBEE(PBDHGENIJKH PHFFNGDOHAF, bool IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	PBDHGENIJKH LJLKIFBIEHB(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void MAKPLGAJGDM(PBDHGENIJKH PHFFNGDOHAF, PBDHGENIJKH IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	PBDHGENIJKH BPHPODIDNCF(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void BFFDCAOPJND(PBDHGENIJKH PHFFNGDOHAF, PBDHGENIJKH IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "33")]
	AAOCMHJKPKO CGMKEEPKDMI(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void HFIAKGADAJA(PBDHGENIJKH PHFFNGDOHAF, AAOCMHJKPKO APONHBLBCOK);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool HCONIFPBLCM(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void DPELFDLKFCL(PBDHGENIJKH PHFFNGDOHAF, bool IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool BBNIBLJHGPK(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void BFEHIAOGGFP(PBDHGENIJKH PHFFNGDOHAF, bool IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints LNKDCDODBKF(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void HODFGLIELGK(PBDHGENIJKH PHFFNGDOHAF, RigidbodyConstraints IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float ENPAJPOLPKH(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void FGBFBOFAAED(PBDHGENIJKH PHFFNGDOHAF, float IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float OHJKAEJFKBK(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void GODHGGPECHN(PBDHGENIJKH PHFFNGDOHAF, float IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool JADHNCCBGIE(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void PLEBAIDBBOP(PBDHGENIJKH PHFFNGDOHAF, bool IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool COMAEBFOBBB(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void BHEDNCIPBNB(PBDHGENIJKH PHFFNGDOHAF, bool IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void JNHACEKNEDG(PBDHGENIJKH PHFFNGDOHAF, int IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "50")]
	FCAMINOCOJA GFKDJCDNJAH(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void JAMLGKPIDPG(PBDHGENIJKH PHFFNGDOHAF, FCAMINOCOJA IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "52")]
	JILCCGMFDPF HEDOJLCMHFL(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void HHGPEELAFPF(PBDHGENIJKH PHFFNGDOHAF, JILCCGMFDPF IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float LGLGEJEGKHH(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void NHJOGCHKCNE(PBDHGENIJKH PHFFNGDOHAF, float IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void JJNBBGPEJLK(PBDHGENIJKH PHFFNGDOHAF, object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void IHFDLNHMOEO(PBDHGENIJKH PHFFNGDOHAF, object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool LOPGEFFHKBI(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void EEOJLOPFHBO(PBDHGENIJKH PHFFNGDOHAF, object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void LHLJJGOMJKC(PBDHGENIJKH PHFFNGDOHAF, object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool IPKLEPDKKJM(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool LCOMCPNGNBO(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody JPFONBLILEG(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void NGCHPMIOIBG(PBDHGENIJKH PHFFNGDOHAF, Rigidbody EBBDKHLIBPM);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void OOMOLILEKIP(PBDHGENIJKH PHFFNGDOHAF, object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void LNGMHNFFFAF(PBDHGENIJKH PHFFNGDOHAF, object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool GBDLLGOBDJJ(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void GBBMAFDFLIK(PBDHGENIJKH PHFFNGDOHAF, float3 BDPGEMOCEKF);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void MPMHCDJAAIM(PBDHGENIJKH PHFFNGDOHAF, float3 HLMGJIDHMFL);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool POJFNKKPOEB(PBDHGENIJKH PHFFNGDOHAF, [Out] float3 BDPGEMOCEKF);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool CCNLGPOEIHD(PBDHGENIJKH PHFFNGDOHAF, [Out] float3 HLMGJIDHMFL);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool CLMLPLJBEEL(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void KDJMNGIOAMG(PBDHGENIJKH PHFFNGDOHAF, object OECMOOGGOOF, bool KCOPEBDIOPC);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void EGCBIHGMGJG(PBDHGENIJKH PHFFNGDOHAF, bool PMFCMKMEAHK);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void DIELHLDBLOP(PBDHGENIJKH PHFFNGDOHAF);

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool EDLEKCDIHIA(PBDHGENIJKH PHFFNGDOHAF);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface FBIHEJCBKFA
{
	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLLBNPIKONP(Entity AIHMJJIKJJM);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CIBBFBABJKK(Entity AIHMJJIKJJM);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface LHGENCGFGCM
{
	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHCDOCNAJPE(PBDHGENIJKH LFFBLPMMGND, bool NLGCNEMBLDA);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HJLFOMBDDCK(PBDHGENIJKH LFFBLPMMGND, int MALOKOEKACK);
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public delegate void CGPLJHLAKFM(LPBLJJFHELJ HDONDKONEFI);
[Cpp2IlInjected.Token(Token = "0x200009F")]
public readonly struct LPBLJJFHELJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly IMJGNGJFNGC EDHCJFEMMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly NativeArray<byte> GNAJPFLMGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly NativeArray<byte> MDLDMPODJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly GFKAPELJMJG BCCOFCDHGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly int JGALIILINEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Type EPDILKJOBEO;

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public IMJGNGJFNGC MMAAMKNLHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0xA37B20", Offset = "0xA36320", VA = "0x180A37B20")]
		get
		{
			return default(IMJGNGJFNGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x6956BF0", Offset = "0x69553F0", VA = "0x186956BF0")]
	public LPBLJJFHELJ(IMJGNGJFNGC EDHCJFEMMBB, NativeArray<byte> GNAJPFLMGKG, NativeArray<byte> MDLDMPODJCD, GFKAPELJMJG BCCOFCDHGPL, int JGALIILINEI, Type EPDILKJOBEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x2B5AD30", Offset = "0x2B59530", VA = "0x182B5AD30")]
	public NativeArray<T> NMAFAKINKDB<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x2B5AC00", Offset = "0x2B59400", VA = "0x182B5AC00")]
	public NativeArray<T> MPEFBMAOFDM<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x2B5AC40", Offset = "0x2B59440", VA = "0x182B5AC40")]
	public (IMJGNGJFNGC, NativeArray<T>, NativeArray<T>) NBGKOOJKKKA<T>() where T : struct
	{
		return default((IMJGNGJFNGC, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x6956BA0", Offset = "0x69553A0", VA = "0x186956BA0")]
	public IFPPOKJFEIG MLNMMAAHEDF()
	{
		return default(IFPPOKJFEIG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface DDEBBEIEKAP
{
	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	string JIHHIFNCDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	DDEBBEIEKAP HCBCILFDJOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	IEnumerable<DDEBBEIEKAP> BBDIFLCJHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface BCKOABGEHIP
{
	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	DDEBBEIEKAP AANMPPNMGGA
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	List<LOBJACNONFA> DLEOCKAIELJ
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GMBPBOCFGAH(LOBJACNONFA ABBFPCPEMEH, [Out] DDEBBEIEKAP COODGNDJFPK);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MPPLGFJBDHC(LOBJACNONFA ABBFPCPEMEH, CGPLJHLAKFM NKPOECCEKKH);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BBPOCOEOMDG(LOBJACNONFA ABBFPCPEMEH, CGPLJHLAKFM NKPOECCEKKH);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public readonly struct IFPPOKJFEIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly LPBLJJFHELJ MLKNGAFFKGE;

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public IMJGNGJFNGC MMAAMKNLHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0xA37B20", Offset = "0xA36320", VA = "0x180A37B20")]
		get
		{
			return default(IMJGNGJFNGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x69516E0", Offset = "0x694FEE0", VA = "0x1869516E0")]
	public IFPPOKJFEIG(LPBLJJFHELJ MLKNGAFFKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x6951610", Offset = "0x694FE10", VA = "0x186951610")]
	public IMJGNGJFNGC NMAFAKINKDB()
	{
		return default(IMJGNGJFNGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x6951420", Offset = "0x694FC20", VA = "0x186951420")]
	public IMJGNGJFNGC MPEFBMAOFDM()
	{
		return default(IMJGNGJFNGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x69514F0", Offset = "0x694FCF0", VA = "0x1869514F0")]
	public (IMJGNGJFNGC, IMJGNGJFNGC, IMJGNGJFNGC) NBGKOOJKKKA()
	{
		return default((IMJGNGJFNGC, IMJGNGJFNGC, IMJGNGJFNGC));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
[DefaultMember("Item")]
public interface NMAPKDPNOEP : IEnumerable<FMPDKKGEHKK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	NativeBitArray LACIAPECGLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	NativeBitArray NNGEHOKACBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	NativeArray<int> PKCBABAFLPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	int HJCFDKBBGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	FMPDKKGEHKK EDCCAJFFILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	FMPDKKGEHKK EDCCAJFFILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FMPDKKGEHKK AKKGMIKKION(FPHCOHCKING FBCHOEIGMMO);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GFKAPELJMJG AFBPHDLPDDG(FPHCOHCKING FBCHOEIGMMO);
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class PKGDMOFMEJK
{
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
[DefaultMember("Item")]
public interface FIJMGNGCKAL : IEnumerable<FEKBJBEJNCD>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	int HJCFDKBBGAL
	{
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	FEKBJBEJNCD EDCCAJFFILN
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FEKBJBEJNCD AKKGMIKKION(FPHCOHCKING FBCHOEIGMMO);

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GFKAPELJMJG AFBPHDLPDDG(FPHCOHCKING FBCHOEIGMMO);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class KMJPOHOLFKN
{
	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x2B2BA40", Offset = "0x2B2A240", VA = "0x182B2BA40")]
	public static GFKAPELJMJG AFBPHDLPDDG<T>(this FIJMGNGCKAL BMOBNAKEFBN, PIJKAEAANBM<T> GCDLMFGKKMH) where T : struct
	{
		return default(GFKAPELJMJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[DefaultMember("Item")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface EAOJIAADGIJ : IEnumerable<LOBJACNONFA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	int HJCFDKBBGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	LOBJACNONFA EDCCAJFFILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LOBJACNONFA AKKGMIKKION(FPHCOHCKING FBCHOEIGMMO);

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GFKAPELJMJG AFBPHDLPDDG(FPHCOHCKING FBCHOEIGMMO);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public static class DINJJJHJGNL
{
	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x28F5780", Offset = "0x28F3F80", VA = "0x1828F5780")]
	public static KEHGOMKFBPK<T> AKKGMIKKION<T>(this EAOJIAADGIJ BMOBNAKEFBN, FPHCOHCKING GCDLMFGKKMH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x28F51E0", Offset = "0x28F39E0", VA = "0x1828F51E0")]
	public static GFKAPELJMJG AFBPHDLPDDG<T>(this EAOJIAADGIJ BMOBNAKEFBN, PIJKAEAANBM<T> GCDLMFGKKMH) where T : struct
	{
		return default(GFKAPELJMJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface MJCBICEKHLC
{
	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPPLGFJBDHC(FPHCOHCKING ABBFPCPEMEH, CGPLJHLAKFM NKPOECCEKKH);

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BBPOCOEOMDG(FPHCOHCKING ABBFPCPEMEH, CGPLJHLAKFM NKPOECCEKKH);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class FDLPAHAKAEF
{
	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CFB0", Offset = "0x2A6B7B0", VA = "0x182A6CFB0")]
	public static void MPPLGFJBDHC<T>(this MJCBICEKHLC MOFKBIMAAEJ, PIJKAEAANBM<T> ABBFPCPEMEH, CGPLJHLAKFM NKPOECCEKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CC20", Offset = "0x2A6B420", VA = "0x182A6CC20")]
	public static void BBPOCOEOMDG<T>(this MJCBICEKHLC MOFKBIMAAEJ, PIJKAEAANBM<T> ABBFPCPEMEH, CGPLJHLAKFM NKPOECCEKKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface MPIFEDDNFMD
{
	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	BFMNPHFKAJO EIHFNOHIMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NIOHFCMFMFO(GCPCGKHJGKN DLEBFLGACBD, GFKAPELJMJG ABBFPCPEMEH);

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GDKIHDDNPAO(GCPCGKHJGKN DLEBFLGACBD, Span<GFKAPELJMJG> BMOBNAKEFBN, bool PKPKFFOLDHG);

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LOFHECJHEKO(NativeArray<GCPCGKHJGKN> NNGIKAPCELN);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class DAAEHNBOAOM
{
	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x694A750", Offset = "0x6948F50", VA = "0x18694A750")]
	public static void GDKIHDDNPAO(this MPIFEDDNFMD FHKBFOAGKKH, GCPCGKHJGKN DLEBFLGACBD, GFKAPELJMJG ABBFPCPEMEH, bool PKPKFFOLDHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public readonly struct BFMNPHFKAJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly NativeBitArray KNCIMBHDFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly NativeParallelHashMap<GCPCGKHJGKN, int> GFNEPEABKKA;

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public bool FBKFCHCPOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x694A050", Offset = "0x6948850", VA = "0x18694A050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0xD20540", Offset = "0xD1ED40", VA = "0x180D20540")]
	public BFMNPHFKAJO(NativeBitArray KNCIMBHDFEN, NativeParallelHashMap<GCPCGKHJGKN, int> GFNEPEABKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x694A070", Offset = "0x6948870", VA = "0x18694A070")]
	public bool NIOHFCMFMFO(GCPCGKHJGKN DLEBFLGACBD, GFKAPELJMJG ABBFPCPEMEH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface DNCDLIKOFHE
{
	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HAFODPHHJJO(PBDHGENIJKH PHFFNGDOHAF, IBKJLLBNKOA IPHHABIKCHD);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface BELLHIHJMHM
{
	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	NIICFFIKABB PCJJAKCEPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface EEDCGEDIJKK
{
	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGBPCOEBIFK(World NGKMHGNGADJ);

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HPMDIBJHPCP(World NGKMHGNGADJ);

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase FOLINGKIJEH(World NGKMHGNGADJ);

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KGKJOEGFMDN(World NGKMHGNGADJ);

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DPLPMDOINIJ(World NGKMHGNGADJ);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LANPDCJNNEN(World NGKMHGNGADJ);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[FJKCFEHMPEG(KFOAJPDPBBE.LoadInstance)]
public interface FPENHCMKFBH
{
	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HIIMIFEAIBD(PBDHGENIJKH ACMFILFJLEL, bool IPHHABIKCHD);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public readonly struct NEOBICGGIGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly IEnumerable<IJMMEEILPJF> HKEBJNJIKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly IReadOnlyList<GameObject> NIKBJOFLMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly IReadOnlyList<int> HLEPACBCADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IReadOnlyList<(GCPCGKHJGKN, GCPCGKHJGKN)> AKCFCPKPHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly int AKECLPNFBIL;

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public bool CPEGFNCLDBH
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x6958F70", Offset = "0x6957770", VA = "0x186958F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	public int EECBBIAABGF
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x8B89F0", Offset = "0x8B71F0", VA = "0x1808B89F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public IEnumerable<GameObject> IDAAKLBEEOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x8B90C0", Offset = "0x8B78C0", VA = "0x1808B90C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public IEnumerable<(GCPCGKHJGKN src, GCPCGKHJGKN dst)> BILDHGJIKBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x6958FD0", Offset = "0x69577D0", VA = "0x186958FD0")]
	public NEOBICGGIGD(IEnumerable<IJMMEEILPJF> HKEBJNJIKEN, IReadOnlyList<GameObject> NIKBJOFLMLG, IReadOnlyList<int> HLEPACBCADI, IReadOnlyList<(GCPCGKHJGKN src, GCPCGKHJGKN dst)> AKCFCPKPHCC, int AKECLPNFBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x6958BE0", Offset = "0x69573E0", VA = "0x186958BE0")]
	public (GameObject, int)[] FNGDGIAHKAH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface GLBFBOAPFBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	bool MFGDEKLAANO
	{
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	bool MFMMMMOHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	EDOMFDJNKKK EMGKDLMNPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HOOEKAFOLHD FJHGDJELFDJ();

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HOOEKAFOLHD LJOEEPLNLDK(IEnumerable<PBDHGENIJKH> OPDFMPDAKPI, [In] UniformTRS DIPDJLGDONO);

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DKJACMOINOC FHKLEMJPADF(ByteString PGMNHFOLPNC);

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DBDCLELCNFD CDHFFMAJDOM(ByteString LPKKJDFMNJA, PBDHGENIJKH GGJNHHDMGON, [In] UniformTRS LHHKBBMHMEG, JBFMBLBKCMB NKPOCAOGCDH, bool IFIKJLHEEEA = true);

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IONLHFELBLF();

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NEOBICGGIGD HODOKJLLPJF(IEnumerable<IJMMEEILPJF> HKEBJNJIKEN);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public static class FOFAFCDHKID
{
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface DMDKMIBAKEI
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action MOHKJOMMFBC;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action DOCHIHNLCCE;
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public struct AAOBNIPHHDN : MMJLCDBBDEC, IEquatable<AAOBNIPHHDN>
{
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public static readonly int CDABDLIDLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public MLDAFHLMJPK HLCODDJIAJC;

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x6949280", Offset = "0x6947A80", VA = "0x186949280", Slot = "5")]
	public void PKPMANIAHDL(CNEIDIOGAGH PJOJHFLPHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x6949250", Offset = "0x6947A50", VA = "0x186949250", Slot = "4")]
	public void HNAIEAEAFJH(LAOEOOKOBMH COHNONCDMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x69492B0", Offset = "0x6947AB0", VA = "0x1869492B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x9A35E0", Offset = "0x9A1DE0", VA = "0x1809A35E0", Slot = "6")]
	public bool Equals(AAOBNIPHHDN OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x69491B0", Offset = "0x69479B0", VA = "0x1869491B0", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x8FC6D0", Offset = "0x8FAED0", VA = "0x1808FC6D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public struct IJMMEEILPJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public Guid PGOHCHKMLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public string EDHNNIHIAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Vector3 GBKEBGLIOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Quaternion LOMIHBHMPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Vector3 KEONANJCBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public int DHHCCDLCMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Dictionary<string, object> EKJGIMBPPBA;

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x6951890", Offset = "0x6950090", VA = "0x186951890", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x6951710", Offset = "0x694FF10", VA = "0x186951710")]
	private static string BCAFHHBPCKF(Dictionary<string, object> HHCGBAEONME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public enum MBPNCDOEGAH
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
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public static class GOAOKDCCEGC
{
	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB830", Offset = "0x5DBA030", VA = "0x185DBB830")]
	public static bool EGKAHAJLMND(this MBPNCDOEGAH HKAKMPIMEOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[Flags]
public enum KPCPMCFHDPH
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
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public interface DBDCLELCNFD : EDOMFDJNKKK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	JBFMBLBKCMB KJFDPJPCDAN
	{
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OHLHHBJPLCP();

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JGCMOGPMKHB();
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public interface EDOMFDJNKKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	IEnumerable<IJMMEEILPJF> JPKANNNMGCF
	{
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	NEOBICGGIGD DPDBEONDNIO
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	MBPNCDOEGAH LBCGEBEPPGP
	{
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	LocalId ABAHFEPEPAE
	{
		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	PNHPJPOKDKJ OAPDLDNGALM
	{
		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HHNAPLDDAPJ(KPCPMCFHDPH EIMCAKNOIAI);
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public interface JBFMBLBKCMB
{
	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HBAKGJNDGHB(Guid AMBKIFNGGDN, [Out] Guid OKKHHHCDIHJ);
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public interface DKJACMOINOC : EDOMFDJNKKK, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[Flags]
public enum KBPOLMKDJGC
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
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface HOOEKAFOLHD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	PNHPJPOKDKJ FGPAPACKIOE
	{
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString NCKLOOEOIBG();
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public enum APEPFNKOHAL
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public delegate bool KNEJOAEJCMA(AFJJCGIFKHM ALEAAOEKAEL, [In] OFJFMHKNJIC IPHHABIKCHD);
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public delegate bool NLLHKNBEBFF<T>(AFJJCGIFKHM ALEAAOEKAEL, [In] T IPHHABIKCHD);
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface PCCFOCLLOMM
{
	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPPLGFJBDHC(GFKAPELJMJG BCCOFCDHGPL, Type MAKGPFPHNCK, KNEJOAEJCMA KFAPNDKJADO);

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LMCALOLJMHM(GFKAPELJMJG BCCOFCDHGPL, [Out] KNEJOAEJCMA KFAPNDKJADO);
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public static class BMKBINEGGDN
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class EPMLBNPBEKK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public NLLHKNBEBFF<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public EPMLBNPBEKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x37772C0", Offset = "0x3775AC0", VA = "0x1837772C0")]
		internal bool CIDCHPEPNKM(AFJJCGIFKHM pendingList, [In] OFJFMHKNJIC value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x283DDC0", Offset = "0x283C5C0", VA = "0x18283DDC0")]
	public static void MPPLGFJBDHC<T>(this PCCFOCLLOMM MOFKBIMAAEJ, GFKAPELJMJG BCCOFCDHGPL, NLLHKNBEBFF<T> KFAPNDKJADO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x694A200", Offset = "0x6948A00", VA = "0x18694A200")]
	public static bool MCBECLNHKII(this PCCFOCLLOMM MOFKBIMAAEJ, AFJJCGIFKHM ALEAAOEKAEL, GFKAPELJMJG BCCOFCDHGPL, [In] OFJFMHKNJIC IPHHABIKCHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface LCPGPFLJECF
{
	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	uint GFPIDBJFAAA
	{
		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface AFJJCGIFKHM
{
	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KBNIODHDIAJ(GCPCGKHJGKN FMJIDEMGEKO, GFKAPELJMJG BCCOFCDHGPL, ReadOnlySpan<byte> JFFJAFLOJIG, ReadOnlySpan<byte> MIGIMKHFCKG);

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NICGPINIINI(GCPCGKHJGKN FMJIDEMGEKO, GFKAPELJMJG BCCOFCDHGPL, ReadOnlySpan<byte> JFFJAFLOJIG, ReadOnlySpan<byte> MIGIMKHFCKG);

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PDPLBGMDFLL(GCPCGKHJGKN FMJIDEMGEKO, GFKAPELJMJG BCCOFCDHGPL);

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool COLOLIOJBLP(GCPCGKHJGKN FMJIDEMGEKO, GFKAPELJMJG BCCOFCDHGPL, ReadOnlySpan<byte> MIGIMKHFCKG);

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AAPGKPMMHEH(GCPCGKHJGKN FMJIDEMGEKO, GFKAPELJMJG BCCOFCDHGPL, Span<byte> JFFJAFLOJIG, Span<byte> MIGIMKHFCKG);
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public static class CELLKJFNLLP
{
	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x28A76D0", Offset = "0x28A5ED0", VA = "0x1828A76D0")]
	public static bool AAPGKPMMHEH<T>(this AFJJCGIFKHM HEEBPGOHHFG, GCPCGKHJGKN FMJIDEMGEKO, GFKAPELJMJG BCCOFCDHGPL, [Out] T JFFJAFLOJIG, [Out] T MIGIMKHFCKG) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x28A78C0", Offset = "0x28A60C0", VA = "0x1828A78C0")]
	public static bool COLOLIOJBLP<T>(this AFJJCGIFKHM HEEBPGOHHFG, GCPCGKHJGKN FMJIDEMGEKO, GFKAPELJMJG BCCOFCDHGPL, T MIGIMKHFCKG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public enum HJNFLMCMGND
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
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface KLCHDMJKIIM
{
	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHMGPEAMBII(JODNDKDNMOK CMAEAOPOFPD, ReadOnlySpan<byte> EMIMPCIEFOP);

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void POFIBFJAKIO(uint GDOAEOCAAIN, ReadOnlySpan<byte> EMIMPCIEFOP);

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EIGONLBDOBE(int FEHFONEBDKD);
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface NPIJGHDMMBA
{
	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JODNDKDNMOK PKJMMPNNFLH(ReadOnlySpan<byte> EMIMPCIEFOP);
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface AMCAAKGHLNM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFFOFFLOLAH(JODNDKDNMOK JOEHGGMHBAA, ReadOnlySpan<byte> EMIMPCIEFOP);

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NFDGFNNEJJD(ReadOnlySpan<JODNDKDNMOK> LBDDEDJIIBL);
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public struct KNDELFDJIJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public JODNDKDNMOK CMAEAOPOFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public ReadOnlyMemory<byte> EMIMPCIEFOP;
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public struct JODNDKDNMOK
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static JODNDKDNMOK DNKHILNCDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public uint IAHONLPBBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public int OAGDDGIENEG;

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0xC07F10", Offset = "0xC06710", VA = "0x180C07F10")]
	public JODNDKDNMOK(uint IAHONLPBBCJ, int OAGDDGIENEG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x6955E70", Offset = "0x6954670", VA = "0x186955E70")]
	public static bool JAJJILMADFD([In] JODNDKDNMOK JOMKMIJJPCA, [In] JODNDKDNMOK DFLDBCDDIFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x6955D90", Offset = "0x6954590", VA = "0x186955D90", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x6955E40", Offset = "0x6954640", VA = "0x186955E40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x6955EA0", Offset = "0x69546A0", VA = "0x186955EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x6955E90", Offset = "0x6954690", VA = "0x186955E90")]
	public void LNLDOCGFLCM([Out] uint IAHONLPBBCJ, [Out] int OAGDDGIENEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface JAKANNHGLOH : ABGEEHMEFDE<JAKANNHGLOH>
{
	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GIPAEIFMNNK(GFKAPELJMJG EGNLNANJFMI, [Out] IBIDFPMMGBE CHIFHGDIIOI);
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public static class CLPEIGKBJHC
{
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public interface IBIDFPMMGBE
{
	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	Type DNCNNIKNNBE
	{
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKPMANIAHDL(CNEIDIOGAGH PJOJHFLPHKO, Span<byte> LFFBLPMMGND);

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HNAIEAEAFJH(LAOEOOKOBMH COHNONCDMOG, ReadOnlySpan<byte> CMAEAOPOFPD);
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public static class BBCLJPENNHB
{
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public struct HNOCCMOEEGD : ISystemStateComponentData, IComponentData, IEquatable<HNOCCMOEEGD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float3 JHDFHPJEFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float3 IAPHLKJGJKC;

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x6950380", Offset = "0x694EB80", VA = "0x186950380", Slot = "4")]
	public bool Equals(HNOCCMOEEGD OGFCKBADKBE)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public class CBIBAIGKJBN
{
	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public CBIBAIGKJBN()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
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
