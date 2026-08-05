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
	public class LogRegistrationIndex : EJFLMJDOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8642B80", Offset = "0x8641180", VA = "0x188642B80", Slot = "4")]
		public override void CBPAAEAGBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EBKHKMODJGB
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8636480", Offset = "0x8634A80", VA = "0x188636480")]
	public static void IPLIJPEAGCM(this Rigidbody GACCHOIDNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8636350", Offset = "0x8634950", VA = "0x188636350")]
	public static void IPLIJPEAGCM(this Rigidbody GACCHOIDNLA, Vector3 EAAFEEKIEOE, Quaternion EGBMJDKPNIB, Vector3 BPODDDDDLFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct KBNDPJOLEPO : IReadOnlyList<JPDMABGMGFC>, IEnumerable<JPDMABGMGFC>, IEnumerable, IReadOnlyCollection<JPDMABGMGFC>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct BLLHFLPDGAJ : IEnumerator<JPDMABGMGFC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly OBECOIDGDPJ CGAAKJBHOHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator NNLAAMJMCJN;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public JPDMABGMGFC MKKCMPLEMEF
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x86333F0", Offset = "0x86319F0", VA = "0x1886333F0", Slot = "4")]
			get
			{
				return default(JPDMABGMGFC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x86333A0", Offset = "0x86319A0", VA = "0x1886333A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5682750", Offset = "0x5680D50", VA = "0x185682750")]
		public BLLHFLPDGAJ(OBECOIDGDPJ CGAAKJBHOHG, NativeArray<LocalId>.Enumerator NNLAAMJMCJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x86332E0", Offset = "0x86318E0", VA = "0x1886332E0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8633320", Offset = "0x8631920", VA = "0x188633320", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8633360", Offset = "0x8631960", VA = "0x188633360", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly OCEOCOFMNNA IINGFCBPPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> JGHIMEJLIML;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public JPDMABGMGFC BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8640300", Offset = "0x863E900", VA = "0x188640300", Slot = "4")]
		get
		{
			return default(JPDMABGMGFC);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x863F6F0", Offset = "0x863DCF0", VA = "0x18863F6F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int BGJDHBCPGEG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public OBECOIDGDPJ MAKJIOAKLNO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x863FD50", Offset = "0x863E350", VA = "0x18863FD50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int LFBOMEJGMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool ODCDDECAKBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x863FCB0", Offset = "0x863E2B0", VA = "0x18863FCB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> NMGHMHLNCPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2D05D90", Offset = "0x2D04390", VA = "0x182D05D90")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> MJGGCEJBABO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x863FCF0", Offset = "0x863E2F0", VA = "0x18863FCF0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8640080", Offset = "0x863E680", VA = "0x188640080")]
	public KBNDPJOLEPO(int FAALOCBOHHG, OBECOIDGDPJ CGAAKJBHOHG, Allocator EKNOCGFFMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x863FFE0", Offset = "0x863E5E0", VA = "0x18863FFE0")]
	public KBNDPJOLEPO(OCEOCOFMNNA IINGFCBPPPE, NativeArray<LocalId> JGHIMEJLIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x863FF70", Offset = "0x863E570", VA = "0x18863FF70")]
	public KBNDPJOLEPO(OCEOCOFMNNA IINGFCBPPPE, NativeArray<Entity> JGHIMEJLIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x863FFF0", Offset = "0x863E5F0", VA = "0x18863FFF0")]
	internal KBNDPJOLEPO(OBECOIDGDPJ CGAAKJBHOHG, NativeArray<Entity> GIPMABPLBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8640130", Offset = "0x863E730", VA = "0x188640130")]
	internal KBNDPJOLEPO(OBECOIDGDPJ CGAAKJBHOHG, NativeArray<LocalId> JGHIMEJLIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x86401A0", Offset = "0x863E7A0", VA = "0x1886401A0")]
	public KBNDPJOLEPO(OBECOIDGDPJ CGAAKJBHOHG, int FODNOPLPBPI, Allocator EKNOCGFFMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8640250", Offset = "0x863E850", VA = "0x188640250")]
	public KBNDPJOLEPO(KBNDPJOLEPO GNHNBJMBCJP, Allocator EKNOCGFFMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x863F750", Offset = "0x863DD50", VA = "0x18863F750")]
	public void CBDEJAGDNOD(List<JPDMABGMGFC> AHJLBOEGGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x863FE40", Offset = "0x863E440", VA = "0x18863FE40")]
	public void OKNKNAGGEPA(int LEPAEEGOBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x863FC10", Offset = "0x863E210", VA = "0x18863FC10")]
	public KBNDPJOLEPO JJDCBGIHCCL(Allocator EKNOCGFFMAE)
	{
		return default(KBNDPJOLEPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x863FAC0", Offset = "0x863E0C0", VA = "0x18863FAC0")]
	public Span<JPDMABGMGFC> EBDECOFENGH()
	{
		return default(Span<JPDMABGMGFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x863FDA0", Offset = "0x863E3A0", VA = "0x18863FDA0")]
	public KBNDPJOLEPO OCMBIEPKECH(int NEIBMENBNPA, int FODNOPLPBPI)
	{
		return default(KBNDPJOLEPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x863FA80", Offset = "0x863E080", VA = "0x18863FA80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x863F9C0", Offset = "0x863DFC0", VA = "0x18863F9C0")]
	public BLLHFLPDGAJ DKMCAGKLCHH()
	{
		return default(BLLHFLPDGAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x863FE90", Offset = "0x863E490", VA = "0x18863FE90", Slot = "6")]
	private IEnumerator<JPDMABGMGFC> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x863FF00", Offset = "0x863E500", VA = "0x18863FF00", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DHMCIMCODHM
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3BD83B0", Offset = "0x3BD69B0", VA = "0x183BD83B0")]
	public static BHDJDKBLBGL<T> POBEFGMPPDC<T>(this KBNDPJOLEPO JHGKHIGHBBL) where T : Component
	{
		return default(BHDJDKBLBGL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public struct OFEOMCMBEAB : IList<JPDMABGMGFC>, ICollection<JPDMABGMGFC>, IEnumerable<JPDMABGMGFC>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct JKLLCBBKGHL : IEnumerator<JPDMABGMGFC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly OBECOIDGDPJ CGAAKJBHOHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator NNLAAMJMCJN;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public JPDMABGMGFC MKKCMPLEMEF
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x863DBE0", Offset = "0x863C1E0", VA = "0x18863DBE0", Slot = "4")]
			get
			{
				return default(JPDMABGMGFC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x863DB90", Offset = "0x863C190", VA = "0x18863DB90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5682750", Offset = "0x5680D50", VA = "0x185682750")]
		public JKLLCBBKGHL(OBECOIDGDPJ CGAAKJBHOHG, NativeArray<LocalId>.Enumerator NNLAAMJMCJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x863DAD0", Offset = "0x863C0D0", VA = "0x18863DAD0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x863DB10", Offset = "0x863C110", VA = "0x18863DB10", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x863DB50", Offset = "0x863C150", VA = "0x18863DB50", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly OBECOIDGDPJ CGAAKJBHOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> JGHIMEJLIML;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public JPDMABGMGFC BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8648F80", Offset = "0x8647580", VA = "0x188648F80", Slot = "4")]
		get
		{
			return default(JPDMABGMGFC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8649070", Offset = "0x8647670", VA = "0x188649070", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8648A40", Offset = "0x8647040", VA = "0x188648A40", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int LFBOMEJGMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8648A40", Offset = "0x8647040", VA = "0x188648A40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> NMGHMHLNCPE
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2D05D90", Offset = "0x2D04390", VA = "0x182D05D90")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool HBGKHJAILJC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8648E70", Offset = "0x8647470", VA = "0x188648E70")]
	public OFEOMCMBEAB(OBECOIDGDPJ CGAAKJBHOHG, Allocator EKNOCGFFMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8648EF0", Offset = "0x86474F0", VA = "0x188648EF0")]
	public OFEOMCMBEAB(OBECOIDGDPJ CGAAKJBHOHG, int FODNOPLPBPI, Allocator EKNOCGFFMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8648A80", Offset = "0x8647080", VA = "0x188648A80")]
	public KBNDPJOLEPO OCFMBLPFGCA()
	{
		return default(KBNDPJOLEPO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8648590", Offset = "0x8646B90", VA = "0x188648590", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x86485D0", Offset = "0x8646BD0", VA = "0x1886485D0", Slot = "13")]
	public bool Contains(JPDMABGMGFC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8648660", Offset = "0x8646C60", VA = "0x188648660", Slot = "14")]
	public void CopyTo(JPDMABGMGFC[] OHHBFAGELLA, int NCHALONGAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8648510", Offset = "0x8646B10", VA = "0x188648510", Slot = "11")]
	public void Add(JPDMABGMGFC KGKOGFAMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8648990", Offset = "0x8646F90", VA = "0x188648990", Slot = "7")]
	public void Insert(int LEPAEEGOBDO, JPDMABGMGFC KGKOGFAMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8648BE0", Offset = "0x86471E0", VA = "0x188648BE0", Slot = "15")]
	public bool Remove(JPDMABGMGFC KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8648900", Offset = "0x8646F00", VA = "0x188648900", Slot = "6")]
	public int IndexOf(JPDMABGMGFC KGKOGFAMIIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8648B90", Offset = "0x8647190", VA = "0x188648B90", Slot = "8")]
	public void RemoveAt(int LEPAEEGOBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x86488C0", Offset = "0x8646EC0", VA = "0x1886488C0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8648830", Offset = "0x8646E30", VA = "0x188648830")]
	public JKLLCBBKGHL DKMCAGKLCHH()
	{
		return default(JKLLCBBKGHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8648CB0", Offset = "0x86472B0", VA = "0x188648CB0", Slot = "16")]
	private IEnumerator<JPDMABGMGFC> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8648D90", Offset = "0x8647390", VA = "0x188648D90", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CFMBCIJODAF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JPDMABGMGFC GKGEBEFJHKP(JPDMABGMGFC JGHIMEJLIML);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LAINCHCHKMN : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface FODPANCCEMH : IPLENKPGLEF, DBPBMPDMPEK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	EFOHDDHICHK KCHIEKKIGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	JEGHBMGNMHL IBEKGCKCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	OCEOCOFMNNA NDOGMIJONNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface DBPBMPDMPEK
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool NEHLGHEFIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.Application)]
public interface PJCJPMPNGPM
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBPGBGFLPGO(bool FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OOIGDCNPPFG();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface CACBMMMBLFL
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool BHELOHIJIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool LLHFMKHMIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool NJBGIGFNFBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool DJOHBIMOABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool CFBHHJLEGIK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ICBMEFDKCLH(bool ANBCINBEIHB);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool NMKAGPLKBIO(ByteString BNBLBKPNCFH);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IPPJGAIHLDH();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DAHPONINLKJ();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KLKNONLHCAL();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.Application)]
public interface JEGHBMGNMHL
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	MKDGNELEFKI KCHIEKKIGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	NMJLIPFKJIN GBEBIDHCNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	JLHECGDOECJ ODNPBIFMLAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	FODPANCCEMH ICIGMALFBGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	EKCLPIHHFHM AJNGHLFBALB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	CACBMMMBLFL IFBKJKIKFEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	BKHALAPJAAA PKNLIOHGDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	MMIAIOKFILG AIOLPIIHLBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	LCOKMAMHPKO PKEGDJKGEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	PJMIJJNNDLG PPPIHOJNMPG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	OPGIHBLMGOL LLKEGBCIDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	DNAJKNPOMBA DDEPALPMIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	OBECOIDGDPJ MAKJIOAKLNO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	JADIKJNPNMB OMCFLHGALAE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	GFMNBMCKDCK BCPPPEDIICI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CEDJNBNBJKO MNNDFJPCEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	PEOJDDIEDKM IHDBHBNAHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	KHHNOKPHJIO CPDKNPLCHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	KPBLBAHGLCA PKNDHHHAMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	PKNPLCMMCBH CDCJHGEAGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	ODANGKLKGBE BPPAICGOMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	ODLKCBMJKEM PHOCFJILPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	HGLOKDGFNDP FOGCOFNLCDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	MNJDPDLIIMN HPBGCPIOLGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	LGOOCNJBMPM LBHBFCCFODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	NNHFPOFCEGC JMMIHMCBDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	CIFJPDAEAKC GGEEDMMJDOI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	CMLIPCHHEFN KFKKGHJNMPG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	ODOCLMEHGNL DIMGCLNLBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	JKFEBNFJACN BHLFMMDHMHK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ECPFBPCHFNL NPHIJOKLING
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	PNCGDOMLIHN JHKDEFOAAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	JNJJKDDCAKI CAAKOFCCFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	HNBKDPFHNOF EFFNAEJMLEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	ACGCFACLMIE GAEAGHDBCOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	OOHNHOIMFOH FECBOPDIKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	ADANKEPIGLL JJKJGEIDDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	KHKDPNKPPLH JHGHFNJGPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	PCGKFGEEAPL NKNBJHBJIBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	GBCLPAEIMJK JODOKKNJAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DebuggerTypeProxy(typeof(BPHNELPNCPO))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct JPDMABGMGFC : IComparable<JPDMABGMGFC>, IEquatable<JPDMABGMGFC>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly JPDMABGMGFC OBPFBJLIFCL;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int APOHPDNFMDI = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int DDFKICADOIJ = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int IPJEDCJMDEN = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int FOAHJPPMHLM = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId DLICMGKJENE;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public OBECOIDGDPJ MAKJIOAKLNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x863D170", Offset = "0x863B770", VA = "0x18863D170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public FODPANCCEMH ICIGMALFBGG
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x863EB60", Offset = "0x863D160", VA = "0x18863EB60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public LocalId PNIMHFMJKDH
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x863F000", Offset = "0x863D600", VA = "0x18863F000")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	internal OCEOCOFMNNA NDOGMIJONNG
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x863ECB0", Offset = "0x863D2B0", VA = "0x18863ECB0")]
		get
		{
			return default(OCEOCOFMNNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool ANHHLAMACIC
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x863F040", Offset = "0x863D640", VA = "0x18863F040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private bool LHPAOONCEKE
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x863F160", Offset = "0x863D760", VA = "0x18863F160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x863F370", Offset = "0x863D970", VA = "0x18863F370")]
	public JPDMABGMGFC(OBECOIDGDPJ BNNJBBHDJJN, LocalId DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x863F2E0", Offset = "0x863D8E0", VA = "0x18863F2E0")]
	public JPDMABGMGFC(OCEOCOFMNNA IINGFCBPPPE, LocalId DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
	public IKNCJJMPFDD BOBGEMOBIKE()
	{
		return default(IKNCJJMPFDD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x863EE60", Offset = "0x863D460", VA = "0x18863EE60")]
	public static LocalId HPNBGLLBBBG(JPDMABGMGFC FKLFNAOMMOL)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x863EEA0", Offset = "0x863D4A0", VA = "0x18863EEA0")]
	public static Entity HPNBGLLBBBG(JPDMABGMGFC FKLFNAOMMOL)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x863EEE0", Offset = "0x863D4E0", VA = "0x18863EEE0")]
	public static bool LMIMJGGKHMP(JPDMABGMGFC IAFDMJDNHDH, JPDMABGMGFC DFKKOPOBCBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8633E80", Offset = "0x8632480", VA = "0x188633E80")]
	public static bool PACMOMIAEBP(JPDMABGMGFC IAFDMJDNHDH, JPDMABGMGFC DFKKOPOBCBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x863F1B0", Offset = "0x863D7B0", VA = "0x18863F1B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x863ECC0", Offset = "0x863D2C0", VA = "0x18863ECC0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x863EBC0", Offset = "0x863D1C0", VA = "0x18863EBC0", Slot = "4")]
	public int CompareTo(JPDMABGMGFC IBCMCOKAJEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "5")]
	public bool Equals(JPDMABGMGFC IBCMCOKAJEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MBFPNCKBACL
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8642D20", Offset = "0x8641320", VA = "0x188642D20")]
	public static DFCAHNMFPEN NEJADLHJLHB(this JPDMABGMGFC NDBJJGOPOFO)
	{
		return default(DFCAHNMFPEN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class BPHNELPNCPO
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct OCEOCOFMNNA : IEquatable<OCEOCOFMNNA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly byte IINGFCBPPPE;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static byte[] DEDILDEDBEA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static OBECOIDGDPJ DNKAAEAFFGG;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static FODPANCCEMH CDEACFEFJMJ;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static OBECOIDGDPJ[] IBMMHENJFAN;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static FODPANCCEMH[] GIHGMOMPBAI;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static Stack<byte> DNACIKODELD;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public FODPANCCEMH ICIGMALFBGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8647700", Offset = "0x8645D00", VA = "0x188647700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public OBECOIDGDPJ IOMANDIIOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8647600", Offset = "0x8645C00", VA = "0x188647600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8648500", Offset = "0x8646B00", VA = "0x188648500")]
	static OCEOCOFMNNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2D7FA20", Offset = "0x2D7E020", VA = "0x182D7FA20")]
	internal OCEOCOFMNNA(byte FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x745C220", Offset = "0x745A820", VA = "0x18745C220", Slot = "4")]
	public bool Equals(OCEOCOFMNNA IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8647CB0", Offset = "0x86462B0", VA = "0x188647CB0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x10B0470", Offset = "0x10AEA70", VA = "0x1810B0470", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8648440", Offset = "0x8646A40", VA = "0x188648440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8648310", Offset = "0x8646910", VA = "0x188648310")]
	private static OBECOIDGDPJ PACMBDLFHFO(byte IINGFCBPPPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8647D50", Offset = "0x8646350", VA = "0x188647D50")]
	private static FODPANCCEMH FBJFFIMANII(byte IINGFCBPPPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8647E00", Offset = "0x8646400", VA = "0x188647E00")]
	private static object FOCHCMELBBD(byte IINGFCBPPPE, object[] DMJEPOICLBJ, object DAKPJNHJLJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x86476F0", Offset = "0x8645CF0", VA = "0x1886476F0")]
	private static int AJEICOJDHIG(byte IINGFCBPPPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8648300", Offset = "0x8646900", VA = "0x188648300")]
	private static int NEPHAMINJHF(byte IINGFCBPPPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x86483C0", Offset = "0x86469C0", VA = "0x1886483C0")]
	private static (int, int) PFKOPMFCFNE(byte IINGFCBPPPE)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x86476E0", Offset = "0x8645CE0", VA = "0x1886476E0")]
	private static byte AGCPLOBMCNG(int FOBPLBPGNLL, int LEPAEEGOBDO)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x86477E0", Offset = "0x8645DE0", VA = "0x1886477E0")]
	internal static OCEOCOFMNNA CBPAAEAGBMC(FODPANCCEMH FKPELLCKDHO, OBECOIDGDPJ AFBKJDCCCLC)
	{
		return default(OCEOCOFMNNA);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8647AA0", Offset = "0x86460A0", VA = "0x188647AA0")]
	internal static void EEAAOMNILHP(OCEOCOFMNNA IINGFCBPPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8647F70", Offset = "0x8646570", VA = "0x188647F70")]
	private static void KGLCJHLBNDI(int FAALOCBOHHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum BDFIPHDKHFP
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
public interface CPHPHIBJLNE
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool GJGIJDKMDIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool BAHCAJPJKGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool JLKPABJNDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool HHDFLHGPGHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool FALCAHDBCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface ELAFJAGMCCG
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DNGBGBGDIJG(ILIBGPIBNOC LOLOEONEEKB, int LEPAEEGOBDO);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GBPHCJNLMNC(ILIBGPIBNOC BAIMPFDAPND, int LEPAEEGOBDO);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CJCJNMJDCEA(KMOLGOGOMLG PNCKILBPMIM, int LEPAEEGOBDO);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface PJOKIGOJNDF : ILIBGPIBNOC, CPHPHIBJLNE
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	int DHFLGPJKMMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MCBHPAJEKNH(PMAJCMHOHNB NDLHPLKACFL, int LEPAEEGOBDO);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface ILIBGPIBNOC : CPHPHIBJLNE
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum AKMBIJKNEJP
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

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool KHHLHAENMBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool BNELPHMEEHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool AGAFJJAFGEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface PMAJCMHOHNB
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool KDGGJMLAPFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	FNNLELJCGID CHFAAJLMGGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	KHCOKIOHFNP HBKFGBPDLAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float3 IIKJNDDFMGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	quaternion NEMGOCEHIKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float3 PFMPFEHANLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	BBOJGHFINDF OHJGNAFEKGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	DLKBGAHIKAB JIIKHGGPGBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	float BALIPDKKMHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	float3 FHCKALKBBOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	float KJOOAFFHHKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	DFBCNJDDJPE BAICMBFMLKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface IACKDBDMDPN
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	float3 GBLBIHIAFHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	float3 NONHGDCBEOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	quaternion NKMKCOMHMCC(float3 PCNNNFAHELF);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface KHCOKIOHFNP
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool KBLBFPOEDPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool KDGEOLNDMEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool IJLHGOCOMNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	float FMHEGOGCEON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	int AOIAILACBGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	int LIMMNPDDGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DNDNAJFMDGH(IACKDBDMDPN NDLHPLKACFL, int LEPAEEGOBDO);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.OMRoom)]
public class DMJAKMLDEDD
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public DMJAKMLDEDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ServiceLifetime(Lifetime.Application)]
public interface OIHLBKKCOCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Guid JLKPPOIDJFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IKBHNFCNGAH(Guid ANDMKLHNLNC, Guid BHKHNPBBPIB, Guid JHDNEPPAEMD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task JPDDCCJHBOP(Guid ANDMKLHNLNC, Guid[] MIEBGGIOGNG, Guid JHDNEPPAEMD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid GKMDKGJDCCB(Guid PJHNKIKCAOJ);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task KHIOHCPIBCE(JPDMABGMGFC KNIMIJFIPAI);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LKJFCBOCGON(Guid PJHNKIKCAOJ);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LIFCPIEDGDJ(MMNAAMLCNJE JDGEKNNHOBE, Guid EDDGOGFEFBH);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KADNNOGIPHD(Guid PJHNKIKCAOJ, bool ANBCINBEIHB);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NOMFEJBGOHJ(Guid PJHNKIKCAOJ, DFCAHNMFPEN DGKIBFCKLJG);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AKMACOPFMIJ(DFCAHNMFPEN DGKIBFCKLJG);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ONHCFLCCMDC(JPDMABGMGFC DLICMGKJENE);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface LHABKLEDKNO
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface MFKBGCIPOBK
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "0")]
	void LIIIJFEIHIE(bool COPJEOGEKIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.Application)]
public interface NMJLIPFKJIN
{
	[Cpp2IlInjected.Token(Token = "0x17000068")]
	MFKBGCIPOBK ANDPCCELKFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	KLLHNKEELIO LGPPOIDJIKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	GPLEDDACLOC HHINGAKJBCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	MNHLBPLBIDF PMBBPDMCGEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	CAMBEBEGFGN BCABPOHDHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	DFOFCPPOFMH DBMAFGOMGFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	NPBBNGMCFAL BHCPIONIPDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	MGJBJDFIMEN JHNAABCMKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[ServiceLifetime(Lifetime.Application)]
public interface KLLHNKEELIO
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	string HMLLFLBKJCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[ServiceLifetime(Lifetime.Application)]
public interface HDIKKBFAIJP
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LOKGIEHNPBP(Action CBDPHPPPDFI, bool FHAEFMDJDPG);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NDCIDDBKAGD(string DJFMCHMDHGK);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int BFKOPJPKKEI(string DJFMCHMDHGK, int DAKPJNHJLJO);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LCKMNCBLHON([Out] bool FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BDEHNDCGDGI([Out] bool FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GKNIHFDMGIM([Out] int FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GFOHLAHGAAE([Out] bool FKMNCAKIOFK);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface GPLEDDACLOC
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "0")]
	void GPIHBBJPNJJ(bool ANBCINBEIHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface MNHLBPLBIDF
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected static readonly Guid ACPKLFDBADN;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	static readonly Guid PMEIMCBGGHM;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	static readonly Guid MCJNHKFNELM;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	static readonly Guid MBJLMKAIPOJ;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool COOEHMNLNFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool BBNDHCALHLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool FOMEGBHLJPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "2")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool GENEGKHIMIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x86469F0", Offset = "0x8644FF0", VA = "0x1886469F0", Slot = "4")]
	string[] DJJFOJBPDAE(CNNNEKPIBJG PGNLGGKNNAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FDHFNHMMCNB();

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x86469C0", Offset = "0x8644FC0", VA = "0x1886469C0", Slot = "6")]
	Guid CJIFJLOLJEP(Guid JOFOIKPMDKA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int DCOOGKCOBNA(CNNNEKPIBJG PGNLGGKNNAO);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PPOBBBCALDK(CNNNEKPIBJG PGNLGGKNNAO, NativeArray<NJNPLIKCPEN> MMDGIILFCOK, NativeList<UniformTRS> FLLMJMAKNJO);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int OKOIEPBMALP(Guid CLPJLOJHBDJ);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool BFAHMFJIONI(string MAIHBFHEECO, [Out] Guid CLPJLOJHBDJ);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string EDAKGCNDEAD(Guid CLPJLOJHBDJ);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool KEIBLCJHGNA(RRObjectPrefabData LDOHOOFEHPE, [Out] LocalId COIPJNEHPIG);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	BHDJDKBLBGL<byte[]> LMFCEJBNPDP(NativeArray<NJNPLIKCPEN> GIIGKDEGAHM);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FCOONAGCOLL(byte[] LABFIAMKKFA);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GameObject JBHEFKPFHBG(string MAIHBFHEECO);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AHPKOLHHGLM(Transform JAHKFPBBGHB, RRObjectPrefabData NMDLEOPAMKN, BECEKGEMHAB HHPFOCCGJIF);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool IKDHNNIMNNB(CNNNEKPIBJG PGNLGGKNNAO, NativeParallelHashMap<Guid, LocalId> MCKONEFBMAO, [Out] Exception MEEGIIKCBDI);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void KHDIFCDPCEC(CNNNEKPIBJG PGNLGGKNNAO, NativeParallelHashMap<Guid, LocalId> MCKONEFBMAO, [Out] NativeArray<LocalId> GIPMABPLBDJ, [Out] NativeArray<LocalId> PGGNJCNLBKL, [Out] NativeArray<AuthoredLocalPoseData> POGFPHEBNKD, Allocator EKNOCGFFMAE);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "19")]
	void GOFFCHIGPML(CNNNEKPIBJG CPLJEEOPGOB, NativeArray<int> IFAGBCNDJLL, BIGICIGIIKM<GameObject> DJPDPHEMPGK, BHDJDKBLBGL<GameObject> AHOCMBGPKDL, BDFIPHDKHFP KOMPNLBNMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void EDLPABALAHA();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "21")]
	void LPBLHOGCDMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "22")]
	void EJGDCJHBBOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "23")]
	bool IPLEHMHEIEH(CNNNEKPIBJG PGNLGGKNNAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "24")]
	ELAFJAGMCCG ELNHDLNAJHP(CNNNEKPIBJG PGNLGGKNNAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "25")]
	void GLNHLFDBLJF(Guid GCAPLDKJFDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "26")]
	bool MFONNFGICDG(Guid GCAPLDKJFDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x8646A80", Offset = "0x8645080", VA = "0x188646A80")]
	static MNHLBPLBIDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface GEFPKFNKIHA
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	long JKFLJCJDFJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	long OALKLMEJDNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "1")]
		get
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[ServiceLifetime(Lifetime.Application)]
public interface CAMBEBEGFGN
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool DOGCGDIFJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool MAGADPHIMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	int EFPILIKODBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	int GCMKNPCOFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	int IHOGNOIAEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool KJCJKOJLGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	int GKJDFAIICOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "6")]
	void MEMNGNPAPIA(GNPEAAGOCDM DCFBCOLBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
	void FEDGLKIKABB(bool JHEGCFHJIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "8")]
	bool IFJACCKOLGO(NAPCGDBANAF PDIOIHNCAEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "9")]
	void DLFNHJGPKGD(object KMJEOGEJMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "10")]
	void GIGICKEEFNG(object KMJEOGEJMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HMGGABEMOJB(Action<object> PKNDDFLEDDK);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OANLGFFGHFB(Action<object> PKNDDFLEDDK);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "13")]
	void LEGLDOCAGEJ(NativeArray<ViewId> AJLPHFLJHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "14")]
	void MIAIIBOGCMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "15")]
	void HCACIEOAOBO(GNAHHGJHLEP EHLAHNIAPLD, ReadOnlySpan<byte> DAJAOHIJHHL, NAPCGDBANAF OFMAIOJLPIF, bool LDBIFDCOJOM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "16")]
	void HCACIEOAOBO(GNAHHGJHLEP EHLAHNIAPLD, ReadOnlySpan<byte> PGJDLJMJCCL, bool LDBIFDCOJOM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "17")]
	void HCACIEOAOBO(GNAHHGJHLEP EHLAHNIAPLD, ReadOnlySpan<byte> PGJDLJMJCCL, ReadOnlySpan<byte> PKKCINEGEDN, bool LDBIFDCOJOM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "18")]
	void HDILPNOKCKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "19")]
	void MEIJECIGGBJ(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "20")]
	void EJPDALCFIOP(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "21")]
	void LGKLFCKCHFL(Dictionary<object, object> CDBLFIFJFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "22")]
	void FPGHKMDINHE(NativeList<DFCAHNMFPEN> MHLCCNKKKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "24")]
	void KPLJODLADOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "25")]
	void GOAHLBMPNHA(List<object> GKACGEGLCCI, int JNIDLJHCIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "26")]
	void ODHCBGKJJFN(int DAIJJKOJCMN, object KJOIOABMAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "27")]
	void LGCJPLGPLNH(NAPCGDBANAF PDIOIHNCAEJ, object PAEBKOFLOKP, bool CDOLEBNLLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "28")]
	void PHBPELHDHLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "29")]
	void NNMEHNKOPDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class HJONCHGNNNL
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x863BCA0", Offset = "0x863A2A0", VA = "0x18863BCA0")]
	public static NMCIIIOJOOI LJPNDGHMFKI(this CAMBEBEGFGN AEAKONLNGGP, object HNGIMMGBLII)
	{
		return default(NMCIIIOJOOI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct NMCIIIOJOOI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private CAMBEBEGFGN AEAKONLNGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private object HNGIMMGBLII;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x86470F0", Offset = "0x86456F0", VA = "0x1886470F0")]
	public NMCIIIOJOOI(CAMBEBEGFGN AEAKONLNGGP, object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x86470A0", Offset = "0x86456A0", VA = "0x1886470A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PGKPGCJEIJN
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate void PAKNBGDFILP(ViewId KBEDHBMNMBE, HINBANPDLCM HFOPCCIGBNM, int MFKMLFFHCFD);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "0")]
	void PCEOJEMCNIE(PAKNBGDFILP EKGFEIFBJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "1")]
	void BFGGJLOPFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "2")]
	void IGPICAOBBGO(EAJHCAPHDEM KMDFLMLKEEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ServiceLifetime(Lifetime.Application)]
public interface DOPPGABIOAL
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[ServiceLifetime(Lifetime.Application)]
public interface DFOFCPPOFMH
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct HKJCIIEPLHP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private DFOFCPPOFMH CDDEFFPAABC;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x863BD90", Offset = "0x863A390", VA = "0x18863BD90")]
		public HKJCIIEPLHP(DFOFCPPOFMH CDDEFFPAABC, string AMFFBMMHAII, string CNPIBONGDHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x863BD30", Offset = "0x863A330", VA = "0x18863BD30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct CNOFKOIOLCD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private DFOFCPPOFMH CDDEFFPAABC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Task PIKAFIDPPMC;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8634650", Offset = "0x8632C50", VA = "0x188634650", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "0")]
	void FKHMGFLBCDG(string IFEHDCDCFPK, float ECPJMMFGCIP = 5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "1")]
	void KNCPBCAJOAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PHFFDNPPGCP(bool EAPAAEELEDI, string AMFFBMMHAII, string CNPIBONGDHI);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "3")]
	void AOIHCNCOKFG(string IFEHDCDCFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class MKKKGGDEAPL
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x8646930", Offset = "0x8644F30", VA = "0x188646930")]
	public static DFOFCPPOFMH.HKJCIIEPLHP PAPBGCDLECC(this DFOFCPPOFMH AEAKONLNGGP, string AMFFBMMHAII, string CNPIBONGDHI)
	{
		return default(DFOFCPPOFMH.HKJCIIEPLHP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[ServiceLifetime(Lifetime.Application)]
public interface LBNHJIFCHIM
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PDFAGHDNAHD(GameObject EGMHLHLEIMH);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPEECCPMMCP(GameObject EGMHLHLEIMH);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OBPMJCMECAM(int PDIOIHNCAEJ);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object DMLENOKALPI(JPDMABGMGFC DLICMGKJENE, GameObject EGMHLHLEIMH, Action<JPDMABGMGFC, int> GDMDDGECOJI);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JANCNHCEGAD(GameObject EGMHLHLEIMH, object FBFLLAMMPBF);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CONLNIEICBJ
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	INCAMEIFDNK EIHGCIFHOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KLENIAELIFN
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CBLGDJPEKIM(JAIIIGOGONJ FDKJEEOLCHJ, KMKJDHGACLG MOEBMMOEFPE);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HOIJOCJLBIA(NAPCGDBANAF LIOICDJHFAF, EMDHJAPEHGM JJBKDHJPPJK);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
public interface FENIPKGBPBF
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAELEDFILEL(object NDBJJGOPOFO, NativeList<byte> DAJAOHIJHHL);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object KJBCLIOBDIC(NativeArray<byte> DAJAOHIJHHL);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.Application)]
public interface FACKPNFHHCE
{
	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool DMIAJNBLEFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate OABHGAMCIPF(FPKEBICGPLH DKHBKLMKDHA, Action<FPKEBICGPLH> GDMDDGECOJI);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void INOAIJKNHCJ(FPKEBICGPLH DKHBKLMKDHA, Delegate GDMDDGECOJI);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate EMMEIECIPON(FPKEBICGPLH DKHBKLMKDHA, Action<FPKEBICGPLH> HHHCINJGLBB);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FJDHPFOLCHP(FPKEBICGPLH DKHBKLMKDHA, Delegate GDMDDGECOJI);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HEKMOFNACBN(FPKEBICGPLH DKHBKLMKDHA);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FPKEBICGPLH LJGOCODDKPN(GameObject EGMHLHLEIMH);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ServiceLifetime(Lifetime.Application)]
public interface LBLEICJOPGC
{
	[Cpp2IlInjected.Token(Token = "0x17000080")]
	int AANFBLCLEAM
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	int LCJOAKCLFFL
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool DOGCGDIFJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool LAIECJPHHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	bool CLFGJOBCBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JPDMABGMGFC FNBAJHMDKPF(int PDIOIHNCAEJ);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OGJNCPJBNPJ(GameObject PNFBCBCAIEI, JobHandle BELLEOGGJAM);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface INCAMEIFDNK
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DLNIHEDOKCI(EMDHJAPEHGM DOKHFDLMEOG, KMKJDHGACLG NMNPMBAPOME);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[ServiceLifetime(Lifetime.Application)]
public interface NPBBNGMCFAL
{
	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool BHELOHIJIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[ServiceLifetime(Lifetime.Application)]
public interface OKDKNCHKIHF
{
	[Cpp2IlInjected.Token(Token = "0x17000086")]
	IPGDEIOBDCB PIEDHEBMLBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	KPOKAGBLPPC PIKGLOCCKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	bool KCKIBDEGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KNIAHCMOEAP(Transform JAHKFPBBGHB);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LFEAEBDJNKL(Transform JAHKFPBBGHB, BFKHDCBEHIE JIPFFJLAIDA);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PFEDKDFKPGJ(Transform JAHKFPBBGHB, HPNEHHPMAMF OOEPNBCGDBB);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[ServiceLifetime(Lifetime.Application)]
public interface MGJBJDFIMEN
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PMEEAJJMEPP;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[ServiceLifetime(Lifetime.Application)]
public interface OPMBGGNEJCA
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHECIBLAOJL();
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[ServiceLifetime(Lifetime.Application)]
public interface GCDGLNJGCOF
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CJILCDAFDNG(GameObject EGMHLHLEIMH, KPKPCLALEAL CPNNGCPCJIL, BKNAOBLPGDM HPIALANFPLO);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EIAJOPHNLOL(JPDMABGMGFC DLICMGKJENE, bool PCEFHJGEGNE, float3 PEBFGONDNON, quaternion ECJEFNILICF);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LFFKHIENEPG(KBNDPJOLEPO DKMFDEGJBHJ);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BGPOCFDOAMC(IKNCJJMPFDD DBPGJLKPCJJ, IKNCJJMPFDD LKEAKCADNOO, APBOCLHIEMC DEKFAJBJCEK);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BNBFPKKHKBG(IKNCJJMPFDD DBPGJLKPCJJ, APBOCLHIEMC DEKFAJBJCEK);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EOGMMJHMKBF(KBNDPJOLEPO BOFKEJFAOCE);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LJNGFNIHLAA(CNNNEKPIBJG IIPDIFDFMDN, ReadOnlySpan<Guid> IGMKELPHONN, ReadOnlySpan<int> GPBKEMCOHGD, BHDJDKBLBGL<GameObject> EJFPKPIPOMD);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KLHAABKOJAF(HLAHLGBMHKC DMOKHLJOOMK);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EEHLLKHACJK(NCNPPEKJBKG GLCJCMODJOI, NCNPPEKJBKG GEBJIDPMOEE);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HKNDMMMOHIN(NCNPPEKJBKG GLCJCMODJOI, NCNPPEKJBKG GEBJIDPMOEE);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EPJOPIKCKEA(JPDMABGMGFC HBPFLCBPAFL);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct GBIDIEKPPDP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NativeArray<byte> DAJAOHIJHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly GCHandle IINGFCBPPPE;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x86399E0", Offset = "0x8637FE0", VA = "0x1886399E0")]
	public GBIDIEKPPDP(ReadOnlyMemory<byte> BIHMAKMFGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x86399A0", Offset = "0x8637FA0", VA = "0x1886399A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public enum CKMLCBOHHNB
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
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct CNNNEKPIBJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public ByteString BEDEIFCIBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public object IILLECGKLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object CGLLGLABLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IEnumerable<string> MKEDLJCHBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool NPKGIDFHPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public KBJOHEFJLLK.CHEMLDFAIML? JFALEJBFOHG;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x86345D0", Offset = "0x8632BD0", VA = "0x1886345D0")]
	public CNNNEKPIBJG(ByteString BEDEIFCIBEI, [Optional] object IILLECGKLLO, [Optional] object CGLLGLABLFL, [Optional] IEnumerable<string> MKEDLJCHBAJ, bool NPKGIDFHPGK = true, [Optional] KBJOHEFJLLK.CHEMLDFAIML? JFALEJBFOHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct ONNJOEEBBAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object FONIPLDANBE;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct NJNPLIKCPEN
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[Flags]
	public enum BOAJPJJGLNK
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
		IsR1Upgrade = 0x20,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		IsAllowedDevOnly = 0x40
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public RRObjectPrefabData HNHOCEELIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Guid DEMDENAPFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Guid EDCNOOCOLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid OEFHFJDHMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Guid CLHPDDENGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public BOAJPJJGLNK OAKCIAMNOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Color32 HEKIKFPHLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public int GGKKMCPLKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public KLLOAOOFOJM NKPNMGAFBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int HCLHEGEMHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int HCMHCHJLBDG;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public Guid OKDEOJLPLPK
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x5682FB0", Offset = "0x56815B0", VA = "0x185682FB0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool CDLFMONHDCC
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8647090", Offset = "0x8645690", VA = "0x188647090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool ALCJCJKLCCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8647060", Offset = "0x8645660", VA = "0x188647060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool LNMJHENLEPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8647070", Offset = "0x8645670", VA = "0x188647070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool MNJNPAAHAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8647080", Offset = "0x8645680", VA = "0x188647080")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct HDHLBLFFNPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly NPGAKENEBEP NEIBMENBNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal readonly NPGAKENEBEP LGCPIJCGKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal readonly uint CMKPCKGGNGE;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x863A100", Offset = "0x8638700", VA = "0x18863A100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct DDGAHPNOCFI
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal readonly HDHLBLFFNPM CBDPHPPPDFI;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x8636040", Offset = "0x8634640", VA = "0x188636040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct GKAANPKKJPF
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal readonly HDHLBLFFNPM CBDPHPPPDFI;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x8636040", Offset = "0x8634640", VA = "0x188636040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct OHFANFOCPCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	internal readonly uint CMKPCKGGNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal readonly bool NEADDJGFILO;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x8649230", Offset = "0x8647830", VA = "0x188649230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct NPGAKENEBEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal int EFCGAKGCCGN;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x8647410", Offset = "0x8645A10", VA = "0x188647410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[ServiceLifetime(Lifetime.Application)]
public interface HLPBABGLADM
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	HCPMBINGFEP ANOANIDMAHD
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface MMNAAMLCNJE
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface PCDKNBOLDCC
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class IEEKPOLLNIG
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3E03020", Offset = "0x3E01620", VA = "0x183E03020")]
	public static IKNCJJMPFDD BOBGEMOBIKE<T>(this T DLICMGKJENE) where T : MMNAAMLCNJE
	{
		return default(IKNCJJMPFDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x863BE20", Offset = "0x863A420", VA = "0x18863BE20")]
	public static MonoBehaviour GINIFJFCLAL(this MMNAAMLCNJE DLICMGKJENE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x863BEA0", Offset = "0x863A4A0", VA = "0x18863BEA0")]
	public static GameObject OKIANKCJMNL(this MMNAAMLCNJE DLICMGKJENE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface EPDIGGLLOBL : MMNAAMLCNJE
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(JPDMABGMGFC IEIKHLNDANP);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface DLFCDCBAMFB : MMNAAMLCNJE
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface IPPKGHDPCJD
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public delegate void FBPAMAKCHNK(DBIANIHBEEN AOKGBJPIEHD);

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event FBPAMAKCHNK LOHEOJHLKLN;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface DIDEDMFELLI
{
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface DLFCPJIPOGI
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface NBALKAFBMOC
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(JPDMABGMGFC IMJKJDHFMLH);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool KDCEMCAGBCE);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CPFGOPGPFPH(JPDMABGMGFC EKIEPLMIJBC);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface BGBNPNHMIDB
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(FFEDAAPDFJC ENLEKFEIAHI);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface FFEDAAPDFJC
{
	[Cpp2IlInjected.Token(Token = "0x17000090")]
	GameObject EGMHLHLEIMH
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	Transform JAHKFPBBGHB
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	PLDICLLJPJP JGBDBDFMADE
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	bool PPBGKJPBHFB
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BFCAKJHMOMM(PLDICLLJPJP FCFHEFKEJPB);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HAPFNJKACCD GetData();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class IFLLCNHHPAN
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x863BF60", Offset = "0x863A560", VA = "0x18863BF60")]
	public static void BBFNJKNLHOA(this FFEDAAPDFJC IJBOEHJOLPI, BECEKGEMHAB HHPFOCCGJIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface PLDICLLJPJP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000094")]
	JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Rigidbody CLHIEGMEABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	FFEDAAPDFJC DOBFHBMCOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	GameObject OKIANKCJMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	Transform ADNKINOHCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	PLDICLLJPJP DHPGFGLBJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	PLDICLLJPJP KFENKPOKOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	int KGPMDALJGCO
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	bool HGAPFBEBFEO
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool HEKMOFNACBN
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	bool BNBDFJENCAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	GMILAJLHIHL GHNHKBGKCPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	CAFAOJANFEB IADNEHFBALF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	float MPNFMFDJKGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 LOBPBIDCCFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	Vector3 DBCICGFIPDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	Vector3 HJDKOMOPEEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Vector3 AOPBBIIEBFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	bool PLENCFJBOCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	bool AIIEPILKLLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	bool CDAHPKKLMEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	bool GGNDCMPEAJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	Vector3 IIJIBBGLIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	Vector3 INODLPFDIBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	Vector3 GLMKMJCCMFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	Vector3 DNILPNFLHFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	float NJLFNJHOGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	float FOBMOJJLBHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	Vector3 PEKCLGMLGCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	Quaternion DHIIINIAGDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	float PMANGOFGHII
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	float ONJNNFJBIMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	bool EIHMNFIPHPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	MMEGJHMINAN OFBLHGPDGCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	bool MCNFPMEGDEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	Transform PFJFLENGLLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	Vector3 FCCPKFEGACO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	float OJBPHIEOEOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	float CIDGLEKGCAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	Quaternion OOOFHBFIALB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	Vector3 GBLBIHIAFHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	Quaternion ABMIOHAELPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	RigidbodyConstraints OKJBFKCHAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	bool CCPFHDGJAOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	CollisionDetectionMode INDJBNAOLNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	bool KGAPCBCJLHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event OICGOOGFDLN JJKHKPBNKIK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event OICGOOGFDLN NHJNLCICBMB;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event OICGOOGFDLN FMPAJDHFJFA;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event OICGOOGFDLN HLLCPJOLMPI;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event OICGOOGFDLN MFLBPACFDJN;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event OICGOOGFDLN ECGHOCKKCMH;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event OICGOOGFDLN DEMIOKNLJCO;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event CJEGOOJGBEM MKFINJCHJMK;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<JGCNGACGAAH, JGCNGACGAAH> MFJELJEDPMJ;

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	PLDICLLJPJP OHMJFBCBFPF(int LEPAEEGOBDO);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void CEJCFBDIFHI((Quaternion rot, Vector3 moments) ALGBGLDGENP);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void IPAAAFNGFFP();

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void GMBGDNHKJIP();

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void ENEOFGGEKEH();

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void HFJFABIJJAA();

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void MFIKAIGMEOM();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void MBGDBGDPEAA(PLDICLLJPJP FKMNCAKIOFK, bool EAPOMGLHHCP = false);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void IDNBJLPAHBC(object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void HNGDEMIJHKG(object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 MBADFDKJKOF(Vector3 AOFGNGADMDL);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 KLMGPDGEODJ(Vector3 ECJAEJHHBNF);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void LELKILHBIMM();

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void PEIEDHEIIDL();

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void ICFFCJEMLOL();

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void HFNJMCGIBDL(Vector3 PHJHLLDKOJF, Vector3 DPFKBGCGGPA);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void NGAHBCOFFOH(Vector3 LOHJNHEMLOP, Vector3 MPFAFOAJOIH);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void CAOIBOCPLFB(Vector3 NIGGFNPPODK);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void EKFCJPEDPKI(MILMBLMNICG IOFMKIHBING, Vector3 CGEBBGCIENO, float EPAAIIHMNGB, float EHJKHHAKCNE = 8f, float BCAICAPEAID = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void JHFAPBDGALA(AJEKPFKLAEG KCELOENKKEK, Vector3 OEJOJNFFOKK, float CDOHNMIAGPG = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void LFCBDCAHKHC(AJEKPFKLAEG KCELOENKKEK, Vector3 NEOIPHFFLHF, float LCJCHDBLDCK = 7f, float FELCNEKKNNF = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 IHMJIAJEBDO(Vector3 FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 OKAHJKAHAIB(Vector3 FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void JHFDPCGJHMO();

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void LBLPAGHAEHK(PLDICLLJPJP CFPPCACOMOG, object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void KCJMIODDFDE(object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void OHKMNDOPGAB();

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void MAOPACCHBPE();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void DBEFIDEPKFJ();

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool LPKIDOLJMEI();

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void HNKCBEMPAEE();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void ONLHPHHECIP(object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void DGNOOINKJNB(object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void BJEFIKGNLAO(object HNGIMMGBLII, bool DHIOOCFCCAJ);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void FGEKGNFEBND(Vector3 CMNDAAHGGNG, Quaternion CCFILMDIOEO);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void HEAMKNBMIEN(Vector3 MMOFCAILDPO, Quaternion HNJFMDBMALE);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool KIKJOMOLPIE(float DFPGIFAKBHK);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void IOBEJKGHPIC(object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void HGMMGBPKFBB(object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void HMMOKBBCAPF(object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void OCGIEAAEOMB(object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void AAHAIGFAGKH(Vector3 MKJGBAFLMBJ, ForceMode LLLMFFEODME = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void LHHLLAIOPOO(Vector3 MKJGBAFLMBJ, Vector3 AANGPKCDGHO, ForceMode LLLMFFEODME);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void BEJFHACKMHM(Vector3 CLJPODDAMOF, ForceMode LLLMFFEODME = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void ANPPPLFDIHO(Vector3 CLJPODDAMOF, ForceMode LLLMFFEODME = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool NNBGLIOEJNK(Vector3 FANJPCNJGDA, [Out] RaycastHit JKJAABNABOH, float LHLABDNDDPG);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void APDJCIBGIJM();
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface CAFAOJANFEB
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class IELJOKPGCBJ : CAFAOJANFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public IELJOKPGCBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "0")]
	void KKBJILIHFHK(Vector3 NKJINFPEABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "1")]
	void ALBNFIGOEBM(Vector3 EHALKHPCJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "2")]
	void FLHPMDLOAKO(Vector3 NKJINFPEABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "3")]
	void PFGLCIDDJCN(Vector3 EHALKHPCJIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface GMILAJLHIHL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 HOEMJAMGLAN();

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 BHEDMPCICNL();

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KOCEHMKAPIH(float OALKIIAHIOB, float IEPIOJNAPKG);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public delegate void OICGOOGFDLN(FFEDAAPDFJC NKMMLEJMEID);
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum BHKCGCNECCN
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	ChildAdded,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	ChildRemoved,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	ParentChanged,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	HierarchyMassUpdated,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	SleepChanged,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	DistanceBandChanged,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	IsKinematicChanged,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Discontinuity,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Destroyed,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum MILMBLMNICG
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Reflective,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	FullOverride
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public delegate void CJEGOOJGBEM(FFEDAAPDFJC NKMMLEJMEID, bool EAPOMGLHHCP = false);
[Cpp2IlInjected.Token(Token = "0x200005F")]
public enum AJEKPFKLAEG
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct HAPFNJKACCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Rigidbody LGAEALOIBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public object HPPGNKNPKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector3 PLICJHAOKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Vector3 NHEBLHFDEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public DJKEJGBLBEI PNGGNDMGCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool PBIBPCODJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool DDHDPODEIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool BJOMAGHLDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public bool IKJGODMMPPE;
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct IKNCJJMPFDD : IEquatable<IKNCJJMPFDD>
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly IKNCJJMPFDD HJDKPCINMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public GameObject EGMHLHLEIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x863C500", Offset = "0x863AB00", VA = "0x18863C500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public DFCAHNMFPEN NOCMABOLNHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x863C800", Offset = "0x863AE00", VA = "0x18863C800")]
		get
		{
			return default(DFCAHNMFPEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public HCOAEMGEKKC JNFEJNANMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x863CEF0", Offset = "0x863B4F0", VA = "0x18863CEF0")]
		get
		{
			return default(HCOAEMGEKKC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public RRObjectPrefabData CBFDDFPACDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x863C8D0", Offset = "0x863AED0", VA = "0x18863C8D0")]
		get
		{
			return default(RRObjectPrefabData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool IPEHBEFFHJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x863C380", Offset = "0x863A980", VA = "0x18863C380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool DBHGKOKDKIO
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x863C690", Offset = "0x863AC90", VA = "0x18863C690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool KDGGJMLAPFH
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x863CBE0", Offset = "0x863B1E0", VA = "0x18863CBE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool OMAOKFDMDFP
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x863CD90", Offset = "0x863B390", VA = "0x18863CD90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool MFHIKJPLLHI
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x863D150", Offset = "0x863B750", VA = "0x18863D150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool FILFCFFFFON
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x863C8A0", Offset = "0x863AEA0", VA = "0x18863C8A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool FBNPLELONBN
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x863D0D0", Offset = "0x863B6D0", VA = "0x18863D0D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool NGNCLHFHAMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x863D1E0", Offset = "0x863B7E0", VA = "0x18863D1E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool HKPOCIHHGBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x863D2C0", Offset = "0x863B8C0", VA = "0x18863D2C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool CMCFCJDDEBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x863CC00", Offset = "0x863B200", VA = "0x18863CC00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool MLFHHOJLGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x863C700", Offset = "0x863AD00", VA = "0x18863C700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool IPHGCNPDFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x863C780", Offset = "0x863AD80", VA = "0x18863C780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool PEDLNHBIMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x863CE30", Offset = "0x863B430", VA = "0x18863CE30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool POOLAGONHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x863CBA0", Offset = "0x863B1A0", VA = "0x18863CBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool DMIBBIHBKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x863D110", Offset = "0x863B710", VA = "0x18863D110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool PFAGIBPALLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x863CDF0", Offset = "0x863B3F0", VA = "0x18863CDF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public DAJJCCNALMC EFLCIANKNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(DAJJCCNALMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public MFGFLDINGBG AEAGONFBJGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(MFGFLDINGBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public PGPCEBFHKAJ OMCFLHGALAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(PGPCEBFHKAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public JPIFIINAOCK JLFHAPFBHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPIFIINAOCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public KGJHHEFOEFC KDPLIGMHFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(KGJHHEFOEFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public OPKADCOPKMF JOHAKOEPPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(OPKADCOPKMF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public DLNCHKBPDME HHGOCIMONCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(DLNCHKBPDME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public PGDMHIODFLD KIJFDMMCOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(PGDMHIODFLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public PIPGJNJPPKO EANPGICKCEH
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(PIPGJNJPPKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public LJLCHKDFEMH BCPPPEDIICI
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(LJLCHKDFEMH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public FDPGBLDGEAC HBEJLKOHALL
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(FDPGBLDGEAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public NOCJHKHGDGF CPEICAICBJH
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(NOCJHKHGDGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public ENOLJEDDIBL OLPGFNPGOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(ENOLJEDDIBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public HIBKHKCHLLC OADOMDPOBJC
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(HIBKHKCHLLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public FAJCOJOBOAG KKONLDNBNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(FAJCOJOBOAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public bool NHFDHNJCAEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x863C3E0", Offset = "0x863A9E0", VA = "0x18863C3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public bool FHINKIMDFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x863CA00", Offset = "0x863B000", VA = "0x18863CA00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public bool OAGMHEJCFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x863CDB0", Offset = "0x863B3B0", VA = "0x18863CDB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public bool ANHHLAMACIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x863D1D0", Offset = "0x863B7D0", VA = "0x18863D1D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool NPDGLEABEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x863C740", Offset = "0x863AD40", VA = "0x18863C740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool LDMKPIDIPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x863C7C0", Offset = "0x863ADC0", VA = "0x18863C7C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public bool HDAIOJGJMGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x863C3A0", Offset = "0x863A9A0", VA = "0x18863C3A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public MHFACKMJJFN ADNKINOHCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(MHFACKMJJFN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public PFPHDBBDPLO PPPIHOJNMPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(PFPHDBBDPLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	private OBECOIDGDPJ MAKJIOAKLNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x863D170", Offset = "0x863B770", VA = "0x18863D170")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0")]
	public static IKNCJJMPFDD HPNBGLLBBBG(JPDMABGMGFC IEIKHLNDANP)
	{
		return default(IKNCJJMPFDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x863CE70", Offset = "0x863B470", VA = "0x18863CE70")]
	public MHEOAEBOFDI JLBGALGHHKJ()
	{
		return default(MHEOAEBOFDI);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x863CB20", Offset = "0x863B120", VA = "0x18863CB20")]
	public CAEBENODCFE FBLGFCPGKOA()
	{
		return default(CAEBENODCFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x863CFE0", Offset = "0x863B5E0", VA = "0x18863CFE0")]
	public DCLLEBFPMFK LOBHPELLCMK()
	{
		return default(DCLLEBFPMFK);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x863C4D0", Offset = "0x863AAD0", VA = "0x18863C4D0")]
	public KAJEAFEGDJK BKMKDIFDGKO()
	{
		return default(KAJEAFEGDJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x863C6B0", Offset = "0x863ACB0", VA = "0x18863C6B0")]
	public MIJNLHPJEPK CFMIKNKLLBN()
	{
		return default(MIJNLHPJEPK);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x863CA40", Offset = "0x863B040", VA = "0x18863CA40")]
	public NPGOHPFPDDD EMNJPBEFGDA()
	{
		return default(NPGOHPFPDDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x863CD40", Offset = "0x863B340", VA = "0x18863CD40")]
	public NCNPPEKJBKG GPEJJHEGIGM()
	{
		return default(NCNPPEKJBKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x863CB50", Offset = "0x863B150", VA = "0x18863CB50")]
	public KJEJNJEPCIO FELFHAILOOG()
	{
		return default(KJEJNJEPCIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x863CF90", Offset = "0x863B590", VA = "0x18863CF90")]
	public FKDDEHFGECO LKMIHMBNIJJ()
	{
		return default(FKDDEHFGECO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x863CC40", Offset = "0x863B240", VA = "0x18863CC40")]
	public void GPECJAGCCDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x863D030", Offset = "0x863B630", VA = "0x18863D030")]
	public void LOMEBHIDOPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x863D220", Offset = "0x863B820", VA = "0x18863D220")]
	public bool ONPINHCKBML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x863D300", Offset = "0x863B900", VA = "0x18863D300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public IKNCJJMPFDD(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x8633A20", Offset = "0x8632020", VA = "0x188633A20")]
	public static bool HPNBGLLBBBG(IKNCJJMPFDD FKMNCAKIOFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0")]
	public static JPDMABGMGFC HPNBGLLBBBG(IKNCJJMPFDD FKMNCAKIOFK)
	{
		return default(JPDMABGMGFC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x863AAD0", Offset = "0x86390D0", VA = "0x18863AAD0")]
	public static bool LMIMJGGKHMP(IKNCJJMPFDD IAFDMJDNHDH, IKNCJJMPFDD DFKKOPOBCBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x8633E80", Offset = "0x8632480", VA = "0x188633E80")]
	public static bool PACMOMIAEBP(IKNCJJMPFDD IAFDMJDNHDH, IKNCJJMPFDD DFKKOPOBCBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x863CA90", Offset = "0x863B090", VA = "0x18863CA90", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(IKNCJJMPFDD IBCMCOKAJEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct ENOLJEDDIBL : IEquatable<ENOLJEDDIBL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private HNBKDPFHNOF MLEDAANHNHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8636D30", Offset = "0x8635330", VA = "0x188636D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private JEGHBMGNMHL IBEKGCKCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8634FD0", Offset = "0x86335D0", VA = "0x188634FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8636D90", Offset = "0x8635390", VA = "0x188636D90")]
	public void BFLEDJAFENI(uint JIEJOKBHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x86373B0", Offset = "0x86359B0", VA = "0x1886373B0")]
	public bool PHIGNPIKPHE([Out] uint JIEJOKBHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8637040", Offset = "0x8635640", VA = "0x188637040")]
	public bool HCDCLGHHHEJ([Out] uint JIEJOKBHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8637140", Offset = "0x8635740", VA = "0x188637140")]
	public void OADEFCAHEIM(string JIEJOKBHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8636EA0", Offset = "0x86354A0", VA = "0x188636EA0")]
	[CanBeNull]
	public string EJEMMPALKPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x8637230", Offset = "0x8635830", VA = "0x188637230")]
	public bool PFONMBNNFFN([Out] string NMGPEJCBHKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x8636C90", Offset = "0x8635290", VA = "0x188636C90")]
	public void BAEPCCOBEHK(string NMGPEJCBHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public ENOLJEDDIBL(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x8636FB0", Offset = "0x86355B0", VA = "0x188636FB0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(ENOLJEDDIBL IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct DAJJCCNALMC : IEquatable<DAJJCCNALMC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private BKHALAPJAAA PAOLKBMKHJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8634820", Offset = "0x8632E20", VA = "0x188634820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private HNBKDPFHNOF EFFNAEJMLEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8634BF0", Offset = "0x86331F0", VA = "0x188634BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool DFAPJGNKLDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8634B60", Offset = "0x8633160", VA = "0x188634B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public bool FABLDMEPHJG
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x8634B20", Offset = "0x8633120", VA = "0x188634B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public bool DEDPIPDPMHC
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x8634FE0", Offset = "0x86335E0", VA = "0x188634FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public Guid ONFAKLHFLEK
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x86346A0", Offset = "0x8632CA0", VA = "0x1886346A0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public Guid KBKPKJHJIFB
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x86350A0", Offset = "0x86336A0", VA = "0x1886350A0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public Guid KBHFONNPOEO
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8634880", Offset = "0x8632E80", VA = "0x188634880")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public PFPHDBBDPLO PPPIHOJNMPG
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(PFPHDBBDPLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	private JEGHBMGNMHL IBEKGCKCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8634FD0", Offset = "0x86335D0", VA = "0x188634FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x8634C50", Offset = "0x8633250", VA = "0x188634C50")]
	public bool LGFIPKFADHH([Out] Guid PJHNKIKCAOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8634E10", Offset = "0x8633410", VA = "0x188634E10")]
	public bool MMFNJLMAKNE([Out] Guid BHKHNPBBPIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x8634EB0", Offset = "0x86334B0", VA = "0x188634EB0")]
	public void NBCKLPPEHNF(Guid PGNMBFKGLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x8634720", Offset = "0x8632D20", VA = "0x188634720")]
	public void BGILJMHKCHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x8634CF0", Offset = "0x86332F0", VA = "0x188634CF0")]
	public Guid LJOKHFAKODE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public DAJJCCNALMC(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x8634A90", Offset = "0x8633090", VA = "0x188634A90", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(DAJJCCNALMC IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct DCLLEBFPMFK : IEquatable<DCLLEBFPMFK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private LCOKMAMHPKO EFAHFBNBEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8635900", Offset = "0x8633F00", VA = "0x188635900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Vector3 CJIHLEGDDOM
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x86357B0", Offset = "0x8633DB0", VA = "0x1886357B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public Quaternion JNOCJLEJNCA
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8635B40", Offset = "0x8634140", VA = "0x188635B40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public IKNCJJMPFDD EBJIPIPHNML
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8635D20", Offset = "0x8634320", VA = "0x188635D20")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private JEGHBMGNMHL IBEKGCKCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x8634FD0", Offset = "0x86335D0", VA = "0x188634FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x8635DB0", Offset = "0x86343B0", VA = "0x188635DB0")]
	public KBNDPJOLEPO KDHKCAEDHAK(Allocator EKNOCGFFMAE)
	{
		return default(KBNDPJOLEPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x8635C80", Offset = "0x8634280", VA = "0x188635C80")]
	public bool HMEJJDMEFKJ(IKNCJJMPFDD IGDHFGFJBMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x86359F0", Offset = "0x8633FF0", VA = "0x1886359F0")]
	public void FHJLEGKDNFN(Vector3 AANGPKCDGHO, Quaternion NEOIPHFFLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x86356A0", Offset = "0x8633CA0", VA = "0x1886356A0")]
	public void ABAEBIHGNDP(float ILFCOODFNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x8635E80", Offset = "0x8634480", VA = "0x188635E80")]
	public void KLHGAMLLLCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public DCLLEBFPMFK(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x8633A20", Offset = "0x8632020", VA = "0x188633A20")]
	public static bool HPNBGLLBBBG(DCLLEBFPMFK FKMNCAKIOFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0")]
	public static JPDMABGMGFC HPNBGLLBBBG(DCLLEBFPMFK FKMNCAKIOFK)
	{
		return default(JPDMABGMGFC);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x8635960", Offset = "0x8633F60", VA = "0x188635960", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(DCLLEBFPMFK IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct MHEOAEBOFDI : IEquatable<MHEOAEBOFDI>
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly MHEOAEBOFDI HJDKPCINMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private PJMIJJNNDLG FMEDNMPAKGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8643BC0", Offset = "0x86421C0", VA = "0x188643BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
	public Span<IKNCJJMPFDD> CKHLPOACJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x86435A0", Offset = "0x8641BA0", VA = "0x1886435A0")]
		get
		{
			return default(Span<IKNCJJMPFDD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8643B40", Offset = "0x8642140", VA = "0x188643B40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8643490", Offset = "0x8641A90", VA = "0x188643490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public MHFACKMJJFN ADNKINOHCOK
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(MHFACKMJJFN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public PFPHDBBDPLO PPPIHOJNMPG
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(PFPHDBBDPLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	private JEGHBMGNMHL IBEKGCKCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8634FD0", Offset = "0x86335D0", VA = "0x188634FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x86436A0", Offset = "0x8641CA0", VA = "0x1886436A0")]
	public void JKCKKBFKKHC(MHEOAEBOFDI IBCMCOKAJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public MHEOAEBOFDI(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x8633A20", Offset = "0x8632020", VA = "0x188633A20")]
	public static bool HPNBGLLBBBG(MHEOAEBOFDI FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x8643510", Offset = "0x8641B10", VA = "0x188643510", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(MHEOAEBOFDI IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0")]
	public static IKNCJJMPFDD HPNBGLLBBBG(MHEOAEBOFDI CCKLBDLJPNG)
	{
		return default(IKNCJJMPFDD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[DefaultMember("Item")]
public struct KMJBHELCIEH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Dictionary<int, object> GKLIJOFCGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NHGAECOMCAG JJNJIDOPKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool MGNIHBNKHPG;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		[CompilerGenerated]
		readonly get
		{
			return default(IKNCJJMPFDD);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public LIABGOOHOMJ BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8641AA0", Offset = "0x86400A0", VA = "0x188641AA0")]
		readonly set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x8641DB0", Offset = "0x86403B0", VA = "0x188641DB0")]
	internal KMJBHELCIEH(IKNCJJMPFDD NDBJJGOPOFO, bool MGNIHBNKHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x8641B60", Offset = "0x8640160", VA = "0x188641B60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x3E67E10", Offset = "0x3E66410", VA = "0x183E67E10")]
	public void GJKNFNDKGEP<T>(LIABGOOHOMJ HFLDIIIPBCG, T FKMNCAKIOFK, [Optional] T DAKPJNHJLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x8641D00", Offset = "0x8640300", VA = "0x188641D00")]
	public void HCDNAOEAAEJ(LIABGOOHOMJ HFLDIIIPBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0xB41580", Offset = "0xB3FB80", VA = "0x180B41580")]
	public Dictionary<int, object> EGEIFJKDKIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x8641C90", Offset = "0x8640290", VA = "0x188641C90")]
	private readonly void GJJABMJLCNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class HGFBJEAKJBI
{
	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x863AFD0", Offset = "0x86395D0", VA = "0x18863AFD0")]
	public static KMJBHELCIEH KNNDABIEEDB(this IKNCJJMPFDD NDBJJGOPOFO)
	{
		return default(KMJBHELCIEH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct HIBKHKCHLLC : IEquatable<HIBKHKCHLLC>
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly HIBKHKCHLLC HJDKPCINMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private bool MLFHHOJLGOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x863B810", Offset = "0x8639E10", VA = "0x18863B810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public Vector3 NNGEJFFOLAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x863BA90", Offset = "0x863A090", VA = "0x18863BA90")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x863B7B0", Offset = "0x8639DB0", VA = "0x18863B7B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x863BB40", Offset = "0x863A140", VA = "0x18863BB40")]
	public Vector3 MNFEJKLMBMC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x863B8E0", Offset = "0x8639EE0", VA = "0x18863B8E0")]
	public void FGMFBHGNPJJ([In] Vector3 FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x863B960", Offset = "0x8639F60", VA = "0x18863B960")]
	public void IKPPPLMGOFO([In] Vector3 FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x863B9E0", Offset = "0x8639FE0", VA = "0x18863B9E0")]
	public bool JOBGKCGDILF([In] Vector3 FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public HIBKHKCHLLC(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x863B850", Offset = "0x8639E50", VA = "0x18863B850", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(HIBKHKCHLLC IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x863BBC0", Offset = "0x863A1C0", VA = "0x18863BBC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct BGIGNBPHJOM : IEquatable<BGIGNBPHJOM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x8632F80", Offset = "0x8631580", VA = "0x188632F80", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(BGIGNBPHJOM IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct KJEJNJEPCIO : IEquatable<KJEJNJEPCIO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	private ADANKEPIGLL JJKJGEIDDBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8641590", Offset = "0x863FB90", VA = "0x188641590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool PPLLNIAJFNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8641840", Offset = "0x863FE40", VA = "0x188641840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool LEPDAOBHBHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x86411C0", Offset = "0x863F7C0", VA = "0x1886411C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public AMNLCHKILHE KEHEFPNLGPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8641970", Offset = "0x863FF70", VA = "0x188641970")]
		get
		{
			return default(AMNLCHKILHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool EDIBOJPKGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x86412F0", Offset = "0x863F8F0", VA = "0x1886412F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool KFOIGNLBMCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x8641500", Offset = "0x863FB00", VA = "0x188641500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public bool BIMANKMKMNE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x86415F0", Offset = "0x863FBF0", VA = "0x1886415F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private JEGHBMGNMHL IBEKGCKCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8634FD0", Offset = "0x86335D0", VA = "0x188634FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8641330", Offset = "0x863F930", VA = "0x188641330")]
	public bool EHDLABIIIFM(KJEJNJEPCIO PNBDBIBMODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8641680", Offset = "0x863FC80", VA = "0x188641680")]
	public bool MJKOAIHDCOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8641460", Offset = "0x863FA60", VA = "0x188641460")]
	public bool IDDHPLOHBFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8641720", Offset = "0x863FD20", VA = "0x188641720")]
	public ReadOnlySpan<JPDMABGMGFC> OEJGKEHIBHP()
	{
		return default(ReadOnlySpan<JPDMABGMGFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public KJEJNJEPCIO(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x863AAD0", Offset = "0x86390D0", VA = "0x18863AAD0")]
	public static bool LMIMJGGKHMP(KJEJNJEPCIO IAFDMJDNHDH, KJEJNJEPCIO DFKKOPOBCBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x8633E80", Offset = "0x8632480", VA = "0x188633E80")]
	public static bool PACMOMIAEBP(KJEJNJEPCIO IAFDMJDNHDH, KJEJNJEPCIO DFKKOPOBCBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x86413D0", Offset = "0x863F9D0", VA = "0x1886413D0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(KJEJNJEPCIO IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct NCNPPEKJBKG : IEquatable<NCNPPEKJBKG>
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly NCNPPEKJBKG HJDKPCINMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private ADANKEPIGLL GNKILFDGMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x8646E10", Offset = "0x8645410", VA = "0x188646E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public bool CEBBGGGKHGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8646C80", Offset = "0x8645280", VA = "0x188646C80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public MHFACKMJJFN ADNKINOHCOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(MHFACKMJJFN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private JEGHBMGNMHL IBEKGCKCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8634FD0", Offset = "0x86335D0", VA = "0x188634FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8646CE0", Offset = "0x86452E0", VA = "0x188646CE0")]
	public bool EHDLABIIIFM(NCNPPEKJBKG IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x8646E70", Offset = "0x8645470", VA = "0x188646E70")]
	public bool NDEKNPCIAAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x8646BA0", Offset = "0x86451A0", VA = "0x188646BA0")]
	public bool AEOLEFIBIFP([Out] NCNPPEKJBKG PDCMAMDIMDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x8646F10", Offset = "0x8645510", VA = "0x188646F10")]
	public void PHPKHPPBAPM(FIJDIDACNHL KNIHNMIOGJJ, bool EHKFFMBEBOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public NCNPPEKJBKG(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x863AAD0", Offset = "0x86390D0", VA = "0x18863AAD0")]
	public static bool LMIMJGGKHMP(NCNPPEKJBKG IAFDMJDNHDH, NCNPPEKJBKG DFKKOPOBCBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x8633E80", Offset = "0x8632480", VA = "0x188633E80")]
	public static bool PACMOMIAEBP(NCNPPEKJBKG IAFDMJDNHDH, NCNPPEKJBKG DFKKOPOBCBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x8646D80", Offset = "0x8645380", VA = "0x188646D80", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(NCNPPEKJBKG IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public readonly struct PFPHDBBDPLO : IEquatable<PFPHDBBDPLO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	private PJMIJJNNDLG FMEDNMPAKGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x864A710", Offset = "0x8648D10", VA = "0x18864A710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public JPDMABGMGFC NABDENNIDJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x864A350", Offset = "0x8648950", VA = "0x18864A350")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public IKNCJJMPFDD DHPGFGLBJLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x864A770", Offset = "0x8648D70", VA = "0x18864A770")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public IKNCJJMPFDD KFENKPOKOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x864A580", Offset = "0x8648B80", VA = "0x18864A580")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private JEGHBMGNMHL IBEKGCKCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8634FD0", Offset = "0x86335D0", VA = "0x188634FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x864AA30", Offset = "0x8649030", VA = "0x18864AA30")]
	public Span<IKNCJJMPFDD> OFCEGFOOEHI()
	{
		return default(Span<IKNCJJMPFDD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x864A930", Offset = "0x8648F30", VA = "0x18864A930")]
	public Span<IKNCJJMPFDD> NLKBACHBIPD()
	{
		return default(Span<IKNCJJMPFDD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x864A1C0", Offset = "0x86487C0", VA = "0x18864A1C0")]
	public Span<IKNCJJMPFDD> CBILFODPJKJ()
	{
		return default(Span<IKNCJJMPFDD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x864A610", Offset = "0x8648C10", VA = "0x18864A610")]
	public Span<IKNCJJMPFDD> KKLKAEKIJNE()
	{
		return default(Span<IKNCJJMPFDD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x864A800", Offset = "0x8648E00", VA = "0x18864A800")]
	public bool MBGDBGDPEAA(IKNCJJMPFDD IGDHFGFJBMG, bool NMNOBFFEDFI = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x864A120", Offset = "0x8648720", VA = "0x18864A120")]
	public bool APNAFAFBGKN(IKNCJJMPFDD KABCEGDMAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x864A470", Offset = "0x8648A70", VA = "0x18864A470")]
	public IKNCJJMPFDD IJFDOLGGAGE(uint KKMPBBAOBND)
	{
		return default(IKNCJJMPFDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x864A2C0", Offset = "0x86488C0", VA = "0x18864A2C0")]
	public MHEOAEBOFDI DHOPOJDJJLO()
	{
		return default(MHEOAEBOFDI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public PFPHDBBDPLO(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x8633A20", Offset = "0x8632020", VA = "0x188633A20")]
	public static bool HPNBGLLBBBG(PFPHDBBDPLO FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x864A3E0", Offset = "0x86489E0", VA = "0x18864A3E0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(PFPHDBBDPLO IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public readonly struct MFGFLDINGBG : IEquatable<MFGFLDINGBG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public string KOEPNMMBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x86430A0", Offset = "0x86416A0", VA = "0x1886430A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public string LOIGELAHLOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8642EF0", Offset = "0x86414F0", VA = "0x188642EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public string FKEJIKLLFLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x8642FF0", Offset = "0x86415F0", VA = "0x188642FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public string AOKFFEIFBDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8643130", Offset = "0x8641730", VA = "0x188643130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x86433D0", Offset = "0x86419D0", VA = "0x1886433D0")]
	public bool PFONMBNNFFN([Out] string NMGPEJCBHKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public MFGFLDINGBG(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x8642F60", Offset = "0x8641560", VA = "0x188642F60", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(MFGFLDINGBG IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public readonly struct IJAPONHIAHG : IEquatable<IJAPONHIAHG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x863C2F0", Offset = "0x863A8F0", VA = "0x18863C2F0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(IJAPONHIAHG IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct JNIHJGIKLDG : IEquatable<JNIHJGIKLDG>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[Flags]
	public enum MMLHEHNCKPF
	{
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		SUCCESS = 0,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		ANCHOR_A_INVALID = 1,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		ANCHOR_B_INVALID = 2,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		ANCHOR_A_ALREADY_CONNECTED = 4,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		ANCHOR_B_ALREADY_CONNECTED = 8
	}

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly JNIHJGIKLDG HJDKPCINMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private OBECOIDGDPJ MAKJIOAKLNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x863D170", Offset = "0x863B770", VA = "0x18863D170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x863E840", Offset = "0x863CE40", VA = "0x18863E840")]
	public static MMLHEHNCKPF NEOOCCKBBFF(JNIHJGIKLDG IAFDMJDNHDH, JNIHJGIKLDG DFKKOPOBCBA)
	{
		return default(MMLHEHNCKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x863DEC0", Offset = "0x863C4C0", VA = "0x18863DEC0")]
	public bool DOBOIHNAMGC([Out] GameObject IGDHFGFJBMG, [Out] GameObject EGMHLHLEIMH, [Out] IKNCJJMPFDD MNDEPGPFHEB, [Out] IKNCJJMPFDD JPCCGIJDPME, [Out] Vector3 AANGPKCDGHO, [Out] Vector3 DHCEMGDEGPN, [Out] Vector3 AFKKIIAKKFD, [Out] IKNCJJMPFDD IELPPNBBFNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x863DCB0", Offset = "0x863C2B0", VA = "0x18863DCB0")]
	public bool DNKLECOEGFP([Out] GameObject IGDHFGFJBMG, [Out] GameObject EGMHLHLEIMH, [Out] IKNCJJMPFDD MNDEPGPFHEB, [Out] IKNCJJMPFDD JPCCGIJDPME, [Out] Vector3 AANGPKCDGHO, [Out] Vector3 DHCEMGDEGPN, [Out] Vector3 AFKKIIAKKFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x863E480", Offset = "0x863CA80", VA = "0x18863E480")]
	private void IILCHONGKIC(Entity COIPJNEHPIG, EntityManager GMAHLIOIDEM, MagneticAnchorData ABACHKLKBIA, [Out] GameObject IGDHFGFJBMG, [Out] GameObject EGMHLHLEIMH, [Out] IKNCJJMPFDD MNDEPGPFHEB, [Out] IKNCJJMPFDD JPCCGIJDPME, [Out] Vector3 AANGPKCDGHO, [Out] Vector3 DHCEMGDEGPN, [Out] Vector3 AFKKIIAKKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public JNIHJGIKLDG(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x863E3F0", Offset = "0x863C9F0", VA = "0x18863E3F0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(JNIHJGIKLDG IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x863EA60", Offset = "0x863D060", VA = "0x18863EA60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public readonly struct ABBIALOCLOI : IEquatable<ABBIALOCLOI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x8632AC0", Offset = "0x86310C0", VA = "0x188632AC0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(ABBIALOCLOI IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct FAJCOJOBOAG : IEquatable<FAJCOJOBOAG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	private KHKDPNKPPLH GNKILFDGMLB
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8637920", Offset = "0x8635F20", VA = "0x188637920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public EKGHLLENOHA KAJJANDGHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x86377C0", Offset = "0x8635DC0", VA = "0x1886377C0")]
		get
		{
			return default(EKGHLLENOHA);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8637650", Offset = "0x8635C50", VA = "0x188637650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public BHDJDKBLBGL<string> EFBMAIIHCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x86374B0", Offset = "0x8635AB0", VA = "0x1886374B0")]
		get
		{
			return default(BHDJDKBLBGL<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x86376A0", Offset = "0x8635CA0", VA = "0x1886376A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public BHDJDKBLBGL<string> HDFDCHHJDLK
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8637980", Offset = "0x8635F80", VA = "0x188637980")]
		get
		{
			return default(BHDJDKBLBGL<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x8637800", Offset = "0x8635E00", VA = "0x188637800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	private JEGHBMGNMHL IBEKGCKCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8634FD0", Offset = "0x86335D0", VA = "0x188634FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public FAJCOJOBOAG(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x86375C0", Offset = "0x8635BC0", VA = "0x1886375C0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(FAJCOJOBOAG IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct PGPCEBFHKAJ : IEquatable<PGPCEBFHKAJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly ComponentTypes KDIBEJFMDCK;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly PGPCEBFHKAJ HJDKPCINMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public Collider PJJMENEMJMO
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x864BAA0", Offset = "0x864A0A0", VA = "0x18864BAA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public KBEFHOKOHMI OCIMDDMNJON
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x864B480", Offset = "0x8649A80", VA = "0x18864B480")]
		get
		{
			return default(KBEFHOKOHMI);
		}
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x864B960", Offset = "0x8649F60", VA = "0x18864B960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public MCDIDCAJDOP ANHGMJCEPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x864B680", Offset = "0x8649C80", VA = "0x18864B680")]
		get
		{
			return default(MCDIDCAJDOP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x864AFF0", Offset = "0x86495F0", VA = "0x18864AFF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public EENGOGLBEIG AMFBPNKBKMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x864B8A0", Offset = "0x8649EA0", VA = "0x18864B8A0")]
		get
		{
			return default(EENGOGLBEIG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x864BA50", Offset = "0x864A050", VA = "0x18864BA50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public float OEHIDJGPIJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x864B310", Offset = "0x8649910", VA = "0x18864B310")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x864AFA0", Offset = "0x86495A0", VA = "0x18864AFA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool KHHLHAENMBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x864B830", Offset = "0x8649E30", VA = "0x18864B830")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x864B9B0", Offset = "0x8649FB0", VA = "0x18864B9B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public bool LBIKDKIKJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x864B6C0", Offset = "0x8649CC0", VA = "0x18864B6C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x864B350", Offset = "0x8649950", VA = "0x18864B350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool DDCDBPDIEOP
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x864B8E0", Offset = "0x8649EE0", VA = "0x18864B8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x864ADA0", Offset = "0x86493A0", VA = "0x18864ADA0")]
	public static bool AJPNBFJGBAF(IKNCJJMPFDD CGHOHHNMHOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x864B0C0", Offset = "0x86496C0", VA = "0x18864B0C0")]
	public static bool BOHILBMMPDC(IKNCJJMPFDD CGHOHHNMHOO, [Out] PGPCEBFHKAJ ONBLIFGMALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x864B4C0", Offset = "0x8649AC0", VA = "0x18864B4C0")]
	public bool HDKDKGBOLPE([Out] NBALKAFBMOC ABMPKGCACDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x864B740", Offset = "0x8649D40", VA = "0x18864B740")]
	public bool LGKIJFDKAHC([Out] JPDMABGMGFC PPOKNBNEDHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x864B620", Offset = "0x8649C20", VA = "0x18864B620")]
	public bool JAMLJDEPEGM(DJIAOOPCFNI KNIHNMIOGJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x864B040", Offset = "0x8649640", VA = "0x18864B040")]
	public void BGGLCMJIOPE(DJIAOOPCFNI KNIHNMIOGJJ, bool COPJEOGEKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x864BBF0", Offset = "0x864A1F0", VA = "0x18864BBF0")]
	public void OOJEICNIJAK(DJIAOOPCFNI KNIHNMIOGJJ, bool COPJEOGEKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public PGPCEBFHKAJ(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x864B3F0", Offset = "0x86499F0", VA = "0x18864B3F0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(PGPCEBFHKAJ IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x864BC90", Offset = "0x864A290", VA = "0x18864BC90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct KAJEAFEGDJK : IEquatable<KAJEAFEGDJK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool CKBKHIGPKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x863F6A0", Offset = "0x863DCA0", VA = "0x18863F6A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public KAJEAFEGDJK(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x863F610", Offset = "0x863DC10", VA = "0x18863F610", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(KAJEAFEGDJK IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct JPIFIINAOCK : IEquatable<JPIFIINAOCK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	private CEDJNBNBJKO MNNDFJPCEOH
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x863F4C0", Offset = "0x863DAC0", VA = "0x18863F4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private JEGHBMGNMHL IBEKGCKCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x8634FD0", Offset = "0x86335D0", VA = "0x188634FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x863F520", Offset = "0x863DB20", VA = "0x18863F520")]
	public void LLNBJNPNKFN(bool KFPNHAIFGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public JPIFIINAOCK(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x863F430", Offset = "0x863DA30", VA = "0x18863F430", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(JPIFIINAOCK IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct MIJNLHPJEPK : IEquatable<MIJNLHPJEPK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private OPGIHBLMGOL LLKEGBCIDMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8645C80", Offset = "0x8644280", VA = "0x188645C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public EKGHLLENOHA MLPCFIIKDKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x86460D0", Offset = "0x86446D0", VA = "0x1886460D0")]
		get
		{
			return default(EKGHLLENOHA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x8646420", Offset = "0x8644A20", VA = "0x188646420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool MJOCEPGLAIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x86461D0", Offset = "0x86447D0", VA = "0x1886461D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x8646380", Offset = "0x8644980", VA = "0x188646380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public BHDJDKBLBGL<string> EMBNEGGIKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x8646530", Offset = "0x8644B30", VA = "0x188646530")]
		get
		{
			return default(BHDJDKBLBGL<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x8645B60", Offset = "0x8644160", VA = "0x188645B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public BHDJDKBLBGL<string> HIFICHKIAKG
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x8645E00", Offset = "0x8644400", VA = "0x188645E00")]
		get
		{
			return default(BHDJDKBLBGL<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8646650", Offset = "0x8644C50", VA = "0x188646650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public BHDJDKBLBGL<string> JMNBHJEHBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x8646260", Offset = "0x8644860", VA = "0x188646260")]
		get
		{
			return default(BHDJDKBLBGL<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x8646810", Offset = "0x8644E10", VA = "0x188646810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public BHDJDKBLBGL<string> FLPGAHGEPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x8645FB0", Offset = "0x86445B0", VA = "0x188645FB0")]
		get
		{
			return default(BHDJDKBLBGL<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x8645CE0", Offset = "0x86442E0", VA = "0x188645CE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	private JEGHBMGNMHL IBEKGCKCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x8634FD0", Offset = "0x86335D0", VA = "0x188634FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x8646770", Offset = "0x8644D70", VA = "0x188646770")]
	public bool OFOIBJBAEGG(JPDMABGMGFC LIOICDJHFAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public MIJNLHPJEPK(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0")]
	public static JPDMABGMGFC HPNBGLLBBBG(MIJNLHPJEPK FKMNCAKIOFK)
	{
		return default(JPDMABGMGFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x8645F20", Offset = "0x8644520", VA = "0x188645F20", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(MIJNLHPJEPK IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct KGJHHEFOEFC : IEquatable<KGJHHEFOEFC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool ALPBEIGOIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x8640E10", Offset = "0x863F410", VA = "0x188640E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool DEPECIHEFHH
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x8640D20", Offset = "0x863F320", VA = "0x188640D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public bool KBFBEHKMCOD
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x86404E0", Offset = "0x863EAE0", VA = "0x1886404E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x86410B0", Offset = "0x863F6B0", VA = "0x1886410B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public bool IKHOMACOOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x86410D0", Offset = "0x863F6D0", VA = "0x1886410D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public bool FGFCFCDHAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x8641170", Offset = "0x863F770", VA = "0x188641170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public bool KCFLCAPHMCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x8640490", Offset = "0x863EA90", VA = "0x188640490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool ONJJDADLCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x8641120", Offset = "0x863F720", VA = "0x188641120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool PBABONLEGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x8640DC0", Offset = "0x863F3C0", VA = "0x188640DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public bool DIGPEBANGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x8640900", Offset = "0x863EF00", VA = "0x188640900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool LCLIFFLKPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x8640400", Offset = "0x863EA00", VA = "0x188640400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public bool MEGEMCILEEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x86408B0", Offset = "0x863EEB0", VA = "0x1886408B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public bool PBLNKHBOALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x86407D0", Offset = "0x863EDD0", VA = "0x1886407D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public bool BAHCAJPJKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x86405E0", Offset = "0x863EBE0", VA = "0x1886405E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool JLKPABJNDNA
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x8640450", Offset = "0x863EA50", VA = "0x188640450")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x8640EE0", Offset = "0x863F4E0", VA = "0x188640EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public bool DAOFDFFCOKD
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x8640530", Offset = "0x863EB30", VA = "0x188640530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public FDHJIACFCFO IDEDKOCJCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x8640E50", Offset = "0x863F450", VA = "0x188640E50")]
		get
		{
			return default(FDHJIACFCFO);
		}
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x8640A70", Offset = "0x863F070", VA = "0x188640A70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public bool MCKBCIGMLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x8640950", Offset = "0x863EF50", VA = "0x188640950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public BKNAOBLPGDM APIKJBFHEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x86403C0", Offset = "0x863E9C0", VA = "0x1886403C0")]
		get
		{
			return default(BKNAOBLPGDM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x8640E90", Offset = "0x863F490", VA = "0x188640E90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public bool AKKIHKFKGDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x8640380", Offset = "0x863E980", VA = "0x188640380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public Vector3 MJNFCOIGCIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x8640F40", Offset = "0x863F540", VA = "0x188640F40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public Vector3 CHNAIKJCFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x8640830", Offset = "0x863EE30", VA = "0x188640830")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public bool GLEIAFEAONC
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x8640AC0", Offset = "0x863F0C0", VA = "0x188640AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public bool CPNOAGDFCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x8640FC0", Offset = "0x863F5C0", VA = "0x188640FC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	private JEGHBMGNMHL IBEKGCKCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x8634FD0", Offset = "0x86335D0", VA = "0x188634FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	private EntityManager HNJPJAEOPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x8640820", Offset = "0x863EE20", VA = "0x188640820")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x8640580", Offset = "0x863EB80", VA = "0x188640580")]
	public bool DDJLGGLBHMK(CJAJHINJADJ KNIHNMIOGJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x8640C90", Offset = "0x863F290", VA = "0x188640C90")]
	public void JHOHKMIJAPP(CJAJHINJADJ KNIHNMIOGJJ, bool COPJEOGEKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x8640D70", Offset = "0x863F370", VA = "0x188640D70")]
	public bool KHAAEHNKFIL(KPKPCLALEAL KNIHNMIOGJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x8640750", Offset = "0x863ED50", VA = "0x188640750")]
	public void FJDNMEGOIGF(KPKPCLALEAL KNIHNMIOGJJ, bool COPJEOGEKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x8640630", Offset = "0x863EC30", VA = "0x188640630")]
	public KPKPCLALEAL DKAIFLAFNJK()
	{
		return default(KPKPCLALEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x8640670", Offset = "0x863EC70", VA = "0x188640670")]
	public bool ENBOGNBBAFG(KPKPCLALEAL FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public KGJHHEFOEFC(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x86406C0", Offset = "0x863ECC0", VA = "0x1886406C0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(KGJHHEFOEFC IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct OPKADCOPKMF : IEquatable<OPKADCOPKMF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	private KPBLBAHGLCA PKNDHHHAMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x8649A70", Offset = "0x8648070", VA = "0x188649A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	private JEGHBMGNMHL IBEKGCKCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x8634FD0", Offset = "0x86335D0", VA = "0x188634FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x8649490", Offset = "0x8647A90", VA = "0x188649490")]
	public bool CNIDJGADDBK(APBOCLHIEMC DEKFAJBJCEK, List<IKNCJJMPFDD> CJDAJOJGDLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x8649670", Offset = "0x8647C70", VA = "0x188649670")]
	public int ENKDJINCGOP(APBOCLHIEMC DEKFAJBJCEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x8649CF0", Offset = "0x86482F0", VA = "0x188649CF0")]
	public void MMPMHLGBCLA(List<IKNCJJMPFDD> CJDAJOJGDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x8649E00", Offset = "0x8648400", VA = "0x188649E00")]
	public int NPHKDLLOMIF(IKNCJJMPFDD LKEAKCADNOO, APBOCLHIEMC DEKFAJBJCEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x8649940", Offset = "0x8647F40", VA = "0x188649940")]
	public IKNCJJMPFDD HAEBJKHNDFM(int LEPAEEGOBDO, APBOCLHIEMC DEKFAJBJCEK)
	{
		return default(IKNCJJMPFDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x8649780", Offset = "0x8647D80", VA = "0x188649780")]
	public void EPCOIEFPOHN(IKNCJJMPFDD LKEAKCADNOO, APBOCLHIEMC DEKFAJBJCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x86495C0", Offset = "0x8647BC0", VA = "0x1886495C0")]
	public bool EIGNDAAEBCJ(IKNCJJMPFDD LKEAKCADNOO, APBOCLHIEMC DEKFAJBJCEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x8649BE0", Offset = "0x86481E0", VA = "0x188649BE0")]
	public void LHPMKPMMBKN(APBOCLHIEMC DEKFAJBJCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x86493E0", Offset = "0x86479E0", VA = "0x1886493E0")]
	public bool CFKKOHGNONO(IKNCJJMPFDD LKEAKCADNOO, APBOCLHIEMC DEKFAJBJCEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x8649AD0", Offset = "0x86480D0", VA = "0x188649AD0")]
	public bool KECFJAEGOBE(APBOCLHIEMC DEKFAJBJCEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public OPKADCOPKMF(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x86498B0", Offset = "0x8647EB0", VA = "0x1886498B0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(OPKADCOPKMF IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct DLNCHKBPDME : IEquatable<DLNCHKBPDME>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	private JEGHBMGNMHL IBEKGCKCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x8634FD0", Offset = "0x86335D0", VA = "0x188634FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x86362C0", Offset = "0x86348C0", VA = "0x1886362C0")]
	public void IEIJFIJGNLA(bool FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x86361A0", Offset = "0x86347A0", VA = "0x1886361A0")]
	public void DDIKJFILLKN(bool FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x3BE6C50", Offset = "0x3BE5250", VA = "0x183BE6C50")]
	public T MBPEOLOFDMO<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public DLNCHKBPDME(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x8636230", Offset = "0x8634830", VA = "0x188636230", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(DLNCHKBPDME IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public readonly struct PGDMHIODFLD : IEquatable<PGDMHIODFLD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public bool OKKOOAJCOFI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x864AB80", Offset = "0x8649180", VA = "0x18864AB80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x864AB30", Offset = "0x8649130", VA = "0x18864AB30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public bool OHNMEGPEFCH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x864ABC0", Offset = "0x86491C0", VA = "0x18864ABC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public int BGLGOOAJNLN
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x864AD60", Offset = "0x8649360", VA = "0x18864AD60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x864ACD0", Offset = "0x86492D0", VA = "0x18864ACD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	private JEGHBMGNMHL IBEKGCKCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x8634FD0", Offset = "0x86335D0", VA = "0x188634FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public PGDMHIODFLD(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x864AC40", Offset = "0x8649240", VA = "0x18864AC40", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(PGDMHIODFLD IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct PIPGJNJPPKO : IEquatable<PIPGJNJPPKO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public int AOCGHCNKKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x864BEF0", Offset = "0x864A4F0", VA = "0x18864BEF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x864BF30", Offset = "0x864A530", VA = "0x18864BF30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public int BIJMILICPOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x864BEB0", Offset = "0x864A4B0", VA = "0x18864BEB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x864C0A0", Offset = "0x864A6A0", VA = "0x18864C0A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public uint EPLHABOAHGD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x864C060", Offset = "0x864A660", VA = "0x18864C060")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x864BF80", Offset = "0x864A580", VA = "0x18864BF80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public PIPGJNJPPKO(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x864BFD0", Offset = "0x864A5D0", VA = "0x18864BFD0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(PIPGJNJPPKO IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct LJLCHKDFEMH : IEquatable<LJLCHKDFEMH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	private GFMNBMCKDCK IHJHDKPODEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x8642170", Offset = "0x8640770", VA = "0x188642170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	private ODLKCBMJKEM PHOCFJILPKH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x86429E0", Offset = "0x8640FE0", VA = "0x1886429E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public bool PHKNNEBDNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x8642300", Offset = "0x8640900", VA = "0x188642300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public bool BCDIIOKMKGD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x86420D0", Offset = "0x86406D0", VA = "0x1886420D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public bool CDDPNLMCKEO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x8642500", Offset = "0x8640B00", VA = "0x188642500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public bool NFCLEPBHOGA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x8642530", Offset = "0x8640B30", VA = "0x188642530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public bool MLAMHMLIBGM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x8642810", Offset = "0x8640E10", VA = "0x188642810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public bool AJIJGBKKCGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8642710", Offset = "0x8640D10", VA = "0x188642710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public bool FGLDFAGGBIO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x8642840", Offset = "0x8640E40", VA = "0x188642840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public bool GKBMBCAPACD
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x8642390", Offset = "0x8640990", VA = "0x188642390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public bool KAFOJCOJFCM
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8641FA0", Offset = "0x86405A0", VA = "0x188641FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	private JEGHBMGNMHL IBEKGCKCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x8634FD0", Offset = "0x86335D0", VA = "0x188634FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x86427A0", Offset = "0x8640DA0", VA = "0x1886427A0")]
	public bool KKKBKMHPDJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x8642260", Offset = "0x8640860", VA = "0x188642260")]
	public IKNCJJMPFDD FLKBEBHOLPL(IKNCJJMPFDD LKEAKCADNOO)
	{
		return default(IKNCJJMPFDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x8642600", Offset = "0x8640C00", VA = "0x188642600")]
	public JPDMABGMGFC JBEPGBCMFBA()
	{
		return default(JPDMABGMGFC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x8642A40", Offset = "0x8641040", VA = "0x188642A40")]
	public bool PAMHJDMMEKG(JPDMABGMGFC LKEAKCADNOO, [Out] JPDMABGMGFC NGHOCOKFCII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public LJLCHKDFEMH(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x8633A20", Offset = "0x8632020", VA = "0x188633A20")]
	public static bool HPNBGLLBBBG(LJLCHKDFEMH FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x86421D0", Offset = "0x86407D0", VA = "0x1886421D0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(LJLCHKDFEMH IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public readonly struct CAEBENODCFE : IEquatable<CAEBENODCFE>
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static readonly CAEBENODCFE HJDKPCINMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public PPBNHAEPJLD CHFAAJLMGGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x8633DA0", Offset = "0x86323A0", VA = "0x188633DA0")]
		get
		{
			return default(PPBNHAEPJLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public DLKBGAHIKAB JIIKHGGPGBF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x86339E0", Offset = "0x8631FE0", VA = "0x1886339E0")]
		get
		{
			return default(DLKBGAHIKAB);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x8633B70", Offset = "0x8632170", VA = "0x188633B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public BBOJGHFINDF OHJGNAFEKGA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x8633A90", Offset = "0x8632090", VA = "0x188633A90")]
		get
		{
			return default(BBOJGHFINDF);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x86337F0", Offset = "0x8631DF0", VA = "0x1886337F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public float AILJEANAAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x8633920", Offset = "0x8631F20", VA = "0x188633920")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x8633A40", Offset = "0x8632040", VA = "0x188633A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public Vector3 NDLGEOHLFDM
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x8633D20", Offset = "0x8632320", VA = "0x188633D20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x8633960", Offset = "0x8631F60", VA = "0x188633960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public float KJOOAFFHHKF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x8633AD0", Offset = "0x86320D0", VA = "0x188633AD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public DFBCNJDDJPE BAICMBFMLKA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x8633C00", Offset = "0x8632200", VA = "0x188633C00")]
		get
		{
			return default(DFBCNJDDJPE);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x8633840", Offset = "0x8631E40", VA = "0x188633840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public bool DKBOGHJDABA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x8633BC0", Offset = "0x86321C0", VA = "0x188633BC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x8633CC0", Offset = "0x86322C0", VA = "0x188633CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	public MHFACKMJJFN ADNKINOHCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(MHFACKMJJFN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public PFPHDBBDPLO PPPIHOJNMPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(PFPHDBBDPLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x8633E30", Offset = "0x8632430", VA = "0x188633E30")]
	public OKNKKKBOHOE OFOPEPCBFPF()
	{
		return default(OKNKKKBOHOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x8633DE0", Offset = "0x86323E0", VA = "0x188633DE0")]
	public HFLBAJMNINP MJBFPEENEAD()
	{
		return default(HFLBAJMNINP);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x8633B20", Offset = "0x8632120", VA = "0x188633B20")]
	private bool JHDMFDGCDOB(DFBCNJDDJPE KNIHNMIOGJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x8633C40", Offset = "0x8632240", VA = "0x188633C40")]
	public void LAHAHIBNELC(DFBCNJDDJPE KNIHNMIOGJJ, bool COPJEOGEKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public CAEBENODCFE(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x8633A20", Offset = "0x8632020", VA = "0x188633A20")]
	public static bool HPNBGLLBBBG(CAEBENODCFE FKMNCAKIOFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x8633E80", Offset = "0x8632480", VA = "0x188633E80")]
	public static bool PACMOMIAEBP(CAEBENODCFE IAFDMJDNHDH, CAEBENODCFE DFKKOPOBCBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x8633890", Offset = "0x8631E90", VA = "0x188633890", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(CAEBENODCFE IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public readonly struct OKNKKKBOHOE : IEquatable<OKNKKKBOHOE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	public CAEBENODCFE INLAKFHEKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(CAEBENODCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public FNNLELJCGID LFEMELPPIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x8649360", Offset = "0x8647960", VA = "0x188649360")]
		get
		{
			return default(FNNLELJCGID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public OKNKKKBOHOE(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x8633A20", Offset = "0x8632020", VA = "0x188633A20")]
	public static bool HPNBGLLBBBG(OKNKKKBOHOE FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x86492D0", Offset = "0x86478D0", VA = "0x1886492D0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(OKNKKKBOHOE IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DefaultMember("Item")]
public readonly struct HFLBAJMNINP : IEquatable<HFLBAJMNINP>
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public static readonly HFLBAJMNINP HJDKPCINMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	private LGOOCNJBMPM LBHBFCCFODB
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x863A840", Offset = "0x8638E40", VA = "0x18863A840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public CAEBENODCFE INLAKFHEKMB
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(CAEBENODCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public EKPIPMMBPJG KGFNDKNOAJC
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x863AAE0", Offset = "0x86390E0", VA = "0x18863AAE0")]
		get
		{
			return default(EKPIPMMBPJG);
		}
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x863AE20", Offset = "0x8639420", VA = "0x18863AE20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public IEnumerable<HACCFGPOJHK> LPHHKCKHJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x863A370", Offset = "0x8638970", VA = "0x18863A370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public HACCFGPOJHK BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x863A730", Offset = "0x8638D30", VA = "0x18863A730")]
		get
		{
			return default(HACCFGPOJHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x863A570", Offset = "0x8638B70", VA = "0x18863A570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public MHFACKMJJFN ADNKINOHCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(MHFACKMJJFN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	private JEGHBMGNMHL IBEKGCKCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x8634FD0", Offset = "0x86335D0", VA = "0x188634FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x863AC00", Offset = "0x8639200", VA = "0x18863AC00")]
	public HACCFGPOJHK OBHFLNAIMDF(float3? AANGPKCDGHO, [Optional] quaternion? NEOIPHFFLHF, [Optional] Vector3? ILFCOODFNFF)
	{
		return default(HACCFGPOJHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x863A8A0", Offset = "0x8638EA0", VA = "0x18863A8A0")]
	public HACCFGPOJHK LIJOICNDJHE(int LEPAEEGOBDO, float3? AANGPKCDGHO, [Optional] quaternion? NEOIPHFFLHF, [Optional] Vector3? ILFCOODFNFF)
	{
		return default(HACCFGPOJHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x863A600", Offset = "0x8638C00", VA = "0x18863A600")]
	public void DGHIAJCJCEN(int LEPAEEGOBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x863AF40", Offset = "0x8639540", VA = "0x18863AF40")]
	public void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public HFLBAJMNINP(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x8633A20", Offset = "0x8632020", VA = "0x188633A20")]
	public static bool HPNBGLLBBBG(HFLBAJMNINP FKMNCAKIOFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x863AAD0", Offset = "0x86390D0", VA = "0x18863AAD0")]
	public static bool LMIMJGGKHMP(HFLBAJMNINP IAFDMJDNHDH, HFLBAJMNINP DFKKOPOBCBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x863A6A0", Offset = "0x8638CA0", VA = "0x18863A6A0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(HFLBAJMNINP IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct HACCFGPOJHK : IEquatable<HACCFGPOJHK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public HFLBAJMNINP HBKFGBPDLAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x863A020", Offset = "0x8638620", VA = "0x18863A020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public float3 GBLBIHIAFHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x863A0A0", Offset = "0x86386A0", VA = "0x18863A0A0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x8639F10", Offset = "0x8638510", VA = "0x188639F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public quaternion ABMIOHAELPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x8639F70", Offset = "0x8638570", VA = "0x188639F70")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x8639EC0", Offset = "0x86384C0", VA = "0x188639EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public float3 NONHGDCBEOB
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x8639D70", Offset = "0x8638370", VA = "0x188639D70")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x8639FC0", Offset = "0x86385C0", VA = "0x188639FC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public EDCLCHHFDDJ HBFGFFLJNDB
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x8639E70", Offset = "0x8638470", VA = "0x188639E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x8639DD0", Offset = "0x86383D0", VA = "0x188639DD0")]
	public void CMKNBBJCEND(HFLBAJMNINP FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public HACCFGPOJHK(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x8639DE0", Offset = "0x86383E0", VA = "0x188639DE0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(HACCFGPOJHK IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct NPGOHPFPDDD : IEquatable<NPGOHPFPDDD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public bool OIBCKBMFCJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x8647500", Offset = "0x8645B00", VA = "0x188647500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public NPGOHPFPDDD(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x8647470", Offset = "0x8645A70", VA = "0x188647470", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(NPGOHPFPDDD IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public readonly struct FKDDEHFGECO : IEquatable<FKDDEHFGECO>
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public static readonly FKDDEHFGECO HJDKPCINMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	private GBCLPAEIMJK JODOKKNJAIC
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x8638E20", Offset = "0x8637420", VA = "0x188638E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public uint PJNNKKOMDNB
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x8638AB0", Offset = "0x86370B0", VA = "0x188638AB0")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x8638820", Offset = "0x8636E20", VA = "0x188638820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public LMJANGHOCHE LNKNHMPIAIK
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x8638F40", Offset = "0x8637540", VA = "0x188638F40")]
		get
		{
			return default(LMJANGHOCHE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x8638F80", Offset = "0x8637580", VA = "0x188638F80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public float NJFLEEBCMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x86389A0", Offset = "0x8636FA0", VA = "0x1886389A0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x8638BF0", Offset = "0x86371F0", VA = "0x188638BF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public float OHJEFJECILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x86389E0", Offset = "0x8636FE0", VA = "0x1886389E0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x8638870", Offset = "0x8636E70", VA = "0x188638870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public IDAMNGPLNCK HPLIIPDAFKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x8638910", Offset = "0x8636F10", VA = "0x188638910")]
		get
		{
			return default(IDAMNGPLNCK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x8638670", Offset = "0x8636C70", VA = "0x188638670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public float MLBPLKINGFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x8638DE0", Offset = "0x86373E0", VA = "0x188638DE0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x8638C80", Offset = "0x8637280", VA = "0x188638C80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	public float GLEECAEFNJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x8638FD0", Offset = "0x86375D0", VA = "0x188638FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public float OINKEJMINDF
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x8638C40", Offset = "0x8637240", VA = "0x188638C40")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	public float CGOMPHPKPAM
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x8638BB0", Offset = "0x86371B0", VA = "0x188638BB0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x86388C0", Offset = "0x8636EC0", VA = "0x1886388C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	public DLKBGAHIKAB PBPDOBHGEIH
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x86387E0", Offset = "0x8636DE0", VA = "0x1886387E0")]
		get
		{
			return default(DLKBGAHIKAB);
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x86390F0", Offset = "0x86376F0", VA = "0x1886390F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	public DLKBGAHIKAB NLHALAKIFIN
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x8639020", Offset = "0x8637620", VA = "0x188639020")]
		get
		{
			return default(DLKBGAHIKAB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x8638950", Offset = "0x8636F50", VA = "0x188638950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public float BDMMFBDJFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x86390B0", Offset = "0x86376B0", VA = "0x1886390B0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x8639060", Offset = "0x8637660", VA = "0x188639060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public ReadOnlySpan<TerrainGenerationLayer> GHGALCJEENN
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x8638AF0", Offset = "0x86370F0", VA = "0x188638AF0")]
		get
		{
			return default(ReadOnlySpan<TerrainGenerationLayer>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x8638CD0", Offset = "0x86372D0", VA = "0x188638CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	public ReadOnlySpan<NPDFLAAOGLM> ICMPEGGNGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x8638E80", Offset = "0x8637480", VA = "0x188638E80")]
		get
		{
			return default(ReadOnlySpan<NPDFLAAOGLM>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x86386C0", Offset = "0x8636CC0", VA = "0x1886386C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	private JEGHBMGNMHL IBEKGCKCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x8634FD0", Offset = "0x86335D0", VA = "0x188634FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public FKDDEHFGECO(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0")]
	public static JPDMABGMGFC HPNBGLLBBBG(FKDDEHFGECO FKMNCAKIOFK)
	{
		return default(JPDMABGMGFC);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x8638A20", Offset = "0x8637020", VA = "0x188638A20", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(FKDDEHFGECO IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public readonly struct FDPGBLDGEAC : IEquatable<FDPGBLDGEAC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	private CIFJPDAEAKC AHMAJEDMCPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x8638130", Offset = "0x8636730", VA = "0x188638130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	public bool DPDENNEHAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x8638190", Offset = "0x8636790", VA = "0x188638190")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x8637BE0", Offset = "0x86361E0", VA = "0x188637BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	public bool IHFHJHPCAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x86381E0", Offset = "0x86367E0", VA = "0x1886381E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x86380D0", Offset = "0x86366D0", VA = "0x1886380D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	public float BCEFKMILKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x8638470", Offset = "0x8636A70", VA = "0x188638470")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x8638230", Offset = "0x8636830", VA = "0x188638230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	public bool PJDNCNGDOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x8637DF0", Offset = "0x86363F0", VA = "0x188637DF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	private JEGHBMGNMHL IBEKGCKCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x8634FD0", Offset = "0x86335D0", VA = "0x188634FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x8637C40", Offset = "0x8636240", VA = "0x188637C40")]
	public void BPADMMEKBDB(int DBPGJLKPCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x8637CE0", Offset = "0x86362E0", VA = "0x188637CE0")]
	public bool CAJLIMJBNLG([Out] int DBPGJLKPCJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x86383D0", Offset = "0x86369D0", VA = "0x1886383D0")]
	public void MIPMNODCLHO(bool JEAIDNPFABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x8637E40", Offset = "0x8636440", VA = "0x188637E40")]
	public bool ELICDKNBCPP(BPPEILIDMBL KNIHNMIOGJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x8637F20", Offset = "0x8636520", VA = "0x188637F20")]
	public void FKDHGCMGBFN(BPPEILIDMBL KNIHNMIOGJJ, bool COPJEOGEKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x8637AA0", Offset = "0x86360A0", VA = "0x188637AA0")]
	public void AJLENOOOEKD(float OJNDOININCB, float OLEOPJECKDE, float OCOMKMIGINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x8638280", Offset = "0x8636880", VA = "0x188638280")]
	public void KLFPJEIPMDI(float3 AOBHMHMEBEP, quaternion MECAJPEOEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x86384B0", Offset = "0x8636AB0", VA = "0x1886384B0")]
	public bool PHGLNFAOPCN([Out] float3 AOBHMHMEBEP, [Out] quaternion MECAJPEOEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x8637FA0", Offset = "0x86365A0", VA = "0x188637FA0")]
	public bool HDALHIPJBDO([Out] float NJACGBMECKB, [Out] float KNBEPMPKLDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x86385E0", Offset = "0x8636BE0", VA = "0x1886385E0")]
	public void POFFNJINHND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public FDPGBLDGEAC(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x8637E90", Offset = "0x8636490", VA = "0x188637E90", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(FDPGBLDGEAC IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public readonly struct MHFACKMJJFN : IEquatable<MHFACKMJJFN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	private CMLIPCHHEFN AFDHHFBGPJN
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x8645280", Offset = "0x8643880", VA = "0x188645280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	public Vector3 GBLBIHIAFHF
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x86459E0", Offset = "0x8643FE0", VA = "0x1886459E0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x86446B0", Offset = "0x8642CB0", VA = "0x1886446B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	public Quaternion ABMIOHAELPG
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x8644D70", Offset = "0x8643370", VA = "0x188644D70")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x8644230", Offset = "0x8642830", VA = "0x188644230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	public Vector3 FCCPKFEGACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x8644BE0", Offset = "0x86431E0", VA = "0x188644BE0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x8644B10", Offset = "0x8643110", VA = "0x188644B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	public Quaternion OOOFHBFIALB
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x8644870", Offset = "0x8642E70", VA = "0x188644870")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x8643F10", Offset = "0x8642510", VA = "0x188643F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	public float OJBPHIEOEOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x8643C20", Offset = "0x8642220", VA = "0x188643C20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x86449C0", Offset = "0x8642FC0", VA = "0x1886449C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	public float CIDGLEKGCAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x8644A70", Offset = "0x8643070", VA = "0x188644A70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	public Matrix4x4 BOJAPGJIBNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x8644580", Offset = "0x8642B80", VA = "0x188644580")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	public PFPHDBBDPLO PPPIHOJNMPG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(PFPHDBBDPLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	private OBECOIDGDPJ MAKJIOAKLNO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x863D170", Offset = "0x863B770", VA = "0x18863D170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x86458E0", Offset = "0x8643EE0", VA = "0x1886458E0")]
	public HGOECGDMDII OJBEJECMPIL()
	{
		return default(HGOECGDMDII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x8643FE0", Offset = "0x86425E0", VA = "0x188643FE0")]
	public void EKCBBIHKEBN([Out] Matrix4x4 LHPFFMMIKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x86450C0", Offset = "0x86436C0", VA = "0x1886450C0")]
	public void LGKBKABINPP([In] Vector3 AEDFHMKGLON, [In] Quaternion IOCPNAEAJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x86451C0", Offset = "0x86437C0", VA = "0x1886451C0")]
	public void LGKBKABINPP([In] RigidTransform CKPPOOLEIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x8645010", Offset = "0x8643610", VA = "0x188645010")]
	public void KFOAMDOFEFM([Out] RigidTransform CKPPOOLEIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x8645410", Offset = "0x8643A10", VA = "0x188645410")]
	public void NGHDFDJFHHC([In] Vector3 EHBIBJAMJFB, [In] Quaternion BBONKDGKNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x8645510", Offset = "0x8643B10", VA = "0x188645510")]
	public void NGHDFDJFHHC([In] RigidTransform CDOMFLOAMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x8644300", Offset = "0x8642900", VA = "0x188644300")]
	public void FPHIBMLAJMN([Out] Vector3 EHBIBJAMJFB, [Out] Quaternion BBONKDGKNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x86443E0", Offset = "0x86429E0", VA = "0x1886443E0")]
	public void FPHIBMLAJMN([Out] RigidTransform CKPPOOLEIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x86458B0", Offset = "0x8643EB0", VA = "0x1886458B0")]
	public UniformTRS OGJMLFDKECP()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x86457F0", Offset = "0x8643DF0", VA = "0x1886457F0")]
	public void OGJMLFDKECP([Out] UniformTRS CDOMFLOAMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x8644680", Offset = "0x8642C80", VA = "0x188644680")]
	public UniformTRS GHKCEEJJMKI()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x86445C0", Offset = "0x8642BC0", VA = "0x1886445C0")]
	public void GHKCEEJJMKI([Out] UniformTRS CKPPOOLEIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x8644780", Offset = "0x8642D80", VA = "0x188644780")]
	public Vector3 GIKMBEBNGNB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x8645340", Offset = "0x8643940", VA = "0x188645340")]
	public void NADHFBDPEMB([In] Vector3 FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x8644490", Offset = "0x8642A90", VA = "0x188644490")]
	public Vector3 GAGKMEDOHAO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x8643CC0", Offset = "0x86422C0", VA = "0x188643CC0")]
	public void CNNBIBJKJGF([In] Vector3 FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x86455D0", Offset = "0x8643BD0", VA = "0x1886455D0")]
	public Quaternion NKMKCOMHMCC()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x8645720", Offset = "0x8643D20", VA = "0x188645720")]
	public void NPGJLNJIGPA([In] Quaternion FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x8644EC0", Offset = "0x86434C0", VA = "0x188644EC0")]
	public Quaternion KALOJPBFNHP()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x8643D90", Offset = "0x8642390", VA = "0x188643D90")]
	public void DHNOGEMPBDH([In] Quaternion FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x8644190", Offset = "0x8642790", VA = "0x188644190")]
	public float FAGBOIJFJHK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x8643E60", Offset = "0x8642460", VA = "0x188643E60")]
	public void DLFKCOCMNOE(float FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x8644CD0", Offset = "0x86432D0", VA = "0x188644CD0")]
	public float IOJGMFEPNDO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x8645930", Offset = "0x8643F30", VA = "0x188645930")]
	public void PEFMKOADEPI(float FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x8645AD0", Offset = "0x86440D0", VA = "0x188645AD0")]
	public Vector3 PMLBMGGCMJJ([In] Vector3 FANJPCNJGDA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public MHFACKMJJFN(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x8644100", Offset = "0x8642700", VA = "0x188644100", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(MHFACKMJJFN IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public readonly struct NOCJHKHGDGF : IEquatable<NOCJHKHGDGF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	private JKFEBNFJACN BHLFMMDHMHK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x8647350", Offset = "0x8645950", VA = "0x188647350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	public IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	private JEGHBMGNMHL IBEKGCKCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x8634FD0", Offset = "0x86335D0", VA = "0x188634FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x8647210", Offset = "0x8645810", VA = "0x188647210")]
	public void KCIDEGPFMNO(string BBLDJOHEJKC, OFEOMCMBEAB CGAAKJBHOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public NOCJHKHGDGF(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x8647180", Offset = "0x8645780", VA = "0x188647180", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(NOCJHKHGDGF IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x8632B90", Offset = "0x8631190", VA = "0x188632B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public readonly struct BMNOFAFDNLB : IEquatable<BMNOFAFDNLB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	public JAIIIGOGONJ ALFMDFDIBAB
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x8633550", Offset = "0x8631B50", VA = "0x188633550")]
		get
		{
			return default(JAIIIGOGONJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public BMNOFAFDNLB(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x86334C0", Offset = "0x8631AC0", VA = "0x1886334C0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(BMNOFAFDNLB IBCMCOKAJEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public readonly struct CJFMNLEJEOP : IEquatable<CJFMNLEJEOP>
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public struct OFIOJNJIGOO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private JPDMABGMGFC DLICMGKJENE;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x8649190", Offset = "0x8647790", VA = "0x188649190")]
		public OFIOJNJIGOO(JPDMABGMGFC DLICMGKJENE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x8649100", Offset = "0x8647700", VA = "0x188649100", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x8633EF0", Offset = "0x86324F0", VA = "0x188633EF0")]
	public OFIOJNJIGOO CJEEDJAHBIB()
	{
		return default(OFIOJNJIGOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x8634200", Offset = "0x8632800", VA = "0x188634200")]
	public GKJHBKAPOCJ FHGGGPHEDAL(Allocator EKNOCGFFMAE = Allocator.Temp)
	{
		return default(GKJHBKAPOCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x86340D0", Offset = "0x86326D0", VA = "0x1886340D0")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> FHFMGGKHCPM(Allocator EKNOCGFFMAE = Allocator.Temp)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x86342F0", Offset = "0x86328F0", VA = "0x1886342F0")]
	public NativeArray<DFCAHNMFPEN> HDDELNONFFG(Allocator EKNOCGFFMAE = Allocator.Temp)
	{
		return default(NativeArray<DFCAHNMFPEN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x86343A0", Offset = "0x86329A0", VA = "0x1886343A0")]
	public NativeArray<DFCAHNMFPEN> HFJDPKPBGCJ(Allocator EKNOCGFFMAE = Allocator.Temp)
	{
		return default(NativeArray<DFCAHNMFPEN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x8634450", Offset = "0x8632A50", VA = "0x188634450")]
	public KBNDPJOLEPO NADCODEANDB(Allocator EKNOCGFFMAE = Allocator.Temp)
	{
		return default(KBNDPJOLEPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x8634510", Offset = "0x8632B10", VA = "0x188634510")]
	public KBNDPJOLEPO NBDAONDPEBK(Allocator EKNOCGFFMAE = Allocator.Temp)
	{
		return default(KBNDPJOLEPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x8634010", Offset = "0x8632610", VA = "0x188634010")]
	public KBNDPJOLEPO FBIBHEBJOHL(Allocator EKNOCGFFMAE = Allocator.Temp)
	{
		return default(KBNDPJOLEPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public CJFMNLEJEOP(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x8633F80", Offset = "0x8632580", VA = "0x188633F80", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(CJFMNLEJEOP IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x86332C0", Offset = "0x86318C0", VA = "0x1886332C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct DHCFEIKDCGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int HLJEBOEPPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public int JJBPJOJLOLC;
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public readonly struct BLHKDPCKPPH : IEquatable<BLHKDPCKPPH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	public CJFMNLEJEOP PCEHBANLONK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(CJFMNLEJEOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	public MCEHLGJOPFI AJMNBCHCLHA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(MCEHLGJOPFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	public BMNOFAFDNLB DKDGCDPLGFF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(BMNOFAFDNLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x8633220", Offset = "0x8631820", VA = "0x188633220")]
	public bool PPDPJMPLALM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x86330A0", Offset = "0x86316A0", VA = "0x1886330A0")]
	public bool IHFHOHKFMHF([Out] Exception ANEOEAMDEHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public BLHKDPCKPPH(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0")]
	public static JPDMABGMGFC HPNBGLLBBBG(BLHKDPCKPPH FKMNCAKIOFK)
	{
		return default(JPDMABGMGFC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x8633010", Offset = "0x8631610", VA = "0x188633010", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(BLHKDPCKPPH IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x86332C0", Offset = "0x86318C0", VA = "0x1886332C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public readonly struct EECBFEGMEIG : IDisposable, IEquatable<EECBFEGMEIG>
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public static readonly EECBFEGMEIG HJDKPCINMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	public BLHKDPCKPPH KIIPNKBLOIP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(BLHKDPCKPPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	public CJFMNLEJEOP PCEHBANLONK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(CJFMNLEJEOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x86369B0", Offset = "0x8634FB0", VA = "0x1886369B0")]
	public void ABKDBGMGHHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x8636A30", Offset = "0x8635030", VA = "0x188636A30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public EECBFEGMEIG(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x8636B00", Offset = "0x8635100", VA = "0x188636B00", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "5")]
	public bool Equals(EECBFEGMEIG IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x8636B90", Offset = "0x8635190", VA = "0x188636B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public readonly struct MCEHLGJOPFI : IEquatable<MCEHLGJOPFI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	public bool PBJKHHFAGEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x8642E60", Offset = "0x8641460", VA = "0x188642E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	public MCEHLGJOPFI(JPDMABGMGFC DLICMGKJENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631160", VA = "0x188632B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x8642DD0", Offset = "0x86413D0", VA = "0x188642DD0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x8632B50", Offset = "0x8631150", VA = "0x188632B50", Slot = "4")]
	public bool Equals(MCEHLGJOPFI IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x86332C0", Offset = "0x86318C0", VA = "0x1886332C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class DKPEGIKMFCH
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private struct OIPGAMOEFKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Guid CLPJLOJHBDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public JJLBPIHKHAD OHHPMLMGEBI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private struct JJLBPIHKHAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int FKMNCAKIOFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int NAOLNBDNHEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int FILIKLALKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int GHNGAKLNGCK;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x863D9F0", Offset = "0x863BFF0", VA = "0x18863D9F0")]
		public bool DNAALKCOIII([Out] DFCAHNMFPEN CBBPNNMFEHI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x863DA90", Offset = "0x863C090", VA = "0x18863DA90")]
		public JJLBPIHKHAD(DFCAHNMFPEN CBBPNNMFEHI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x8636100", Offset = "0x8634700", VA = "0x188636100")]
	public static Guid MGGFGKMEOPI(this DFCAHNMFPEN CBBPNNMFEHI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x86360E0", Offset = "0x86346E0", VA = "0x1886360E0")]
	public static bool KJIECCJCCHE(this Guid CLPJLOJHBDJ, [Out] DFCAHNMFPEN CBBPNNMFEHI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class BFLJAMDOBNH
{
	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x8632D80", Offset = "0x8631380", VA = "0x188632D80")]
	public static JEGHBMGNMHL IBEKGCKCBFO(this JPDMABGMGFC JIEJOKBHEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x8632E10", Offset = "0x8631410", VA = "0x188632E10")]
	public static PNCGDOMLIHN JHKDEFOAAPD(this JPDMABGMGFC JIEJOKBHEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x8632CF0", Offset = "0x86312F0", VA = "0x188632CF0")]
	public static EntityManager HNJPJAEOPKA(this JPDMABGMGFC JIEJOKBHEMF)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C720", Offset = "0x3B1AD20", VA = "0x183B1C720")]
	internal static bool KHHHMIOIENA<T>(this JPDMABGMGFC JIEJOKBHEMF, bool COPJEOGEKIA) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x8632E70", Offset = "0x8631470", VA = "0x188632E70")]
	public static bool JJGLICIEEGF(this JPDMABGMGFC JIEJOKBHEMF, OBBAANPPIBD BJBANDBIGLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C8E0", Offset = "0x3B1AEE0", VA = "0x183B1C8E0")]
	public static bool KPDHECMGFNP<T>(this JPDMABGMGFC JIEJOKBHEMF) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x3B19360", Offset = "0x3B17960", VA = "0x183B19360")]
	public static bool CIDJKHMPEOE<T>(this JPDMABGMGFC JIEJOKBHEMF) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x3B19270", Offset = "0x3B17870", VA = "0x183B19270")]
	[KFCMEJPEOPB]
	internal static NativeArray<T> BOPEHADLBGO<T>(this JPDMABGMGFC JIEJOKBHEMF, Allocator EKNOCGFFMAE) where T : struct, IBufferElementData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D430", Offset = "0x3B1BA30", VA = "0x183B1D430")]
	[KFCMEJPEOPB]
	public static T PLMHCJGDFED<T>(this JPDMABGMGFC JIEJOKBHEMF) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x3B19660", Offset = "0x3B17C60", VA = "0x183B19660")]
	[KFCMEJPEOPB]
	public static T HHHPGPHCHLD<T>(this JPDMABGMGFC JIEJOKBHEMF) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x3B194C0", Offset = "0x3B17AC0", VA = "0x183B194C0")]
	public static bool GMPLEJMOOGD<T>(this JPDMABGMGFC JIEJOKBHEMF, [Out] T FKMNCAKIOFK) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D380", Offset = "0x3B1B980", VA = "0x183B1D380")]
	public static T OHGHPAIGAEJ<T>(this JPDMABGMGFC JIEJOKBHEMF) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x3B195E0", Offset = "0x3B17BE0", VA = "0x183B195E0")]
	public static T HHCODKDOGGE<T>(this JPDMABGMGFC JIEJOKBHEMF) where T : class, IComponentData
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
internal static class ELBFCILCGMD
{
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[DefaultMember("Item")]
public struct GKJHBKAPOCJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private KBNDPJOLEPO JHGKHIGHBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> EHEPMGLMALL;

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x62404E0", Offset = "0x623EAE0", VA = "0x1862404E0")]
	public GKJHBKAPOCJ(KBNDPJOLEPO JHGKHIGHBBL, NativeArray<EntityRemapUtility.EntityRemapInfo> EHEPMGLMALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x8639B90", Offset = "0x8638190", VA = "0x188639B90")]
	public LocalId GKGEBEFJHKP(LocalId NDBJJGOPOFO)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x8639BD0", Offset = "0x86381D0", VA = "0x188639BD0")]
	public LocalId GKGEBEFJHKP(int LEPAEEGOBDO)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x8639B20", Offset = "0x8638120", VA = "0x188639B20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HNBKDPFHNOF
{
	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HCDCLGHHHEJ(JPDMABGMGFC EKIEPLMIJBC, [Out] uint JIEJOKBHEMF);

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PHIGNPIKPHE(JPDMABGMGFC EKIEPLMIJBC, [Out] uint JIEJOKBHEMF);

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BFLEDJAFENI(JPDMABGMGFC EKIEPLMIJBC, uint JIEJOKBHEMF);

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CBAGIEBKCKD(JPDMABGMGFC EKIEPLMIJBC);

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string EJEMMPALKPB(JPDMABGMGFC EKIEPLMIJBC);

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OADEFCAHEIM(JPDMABGMGFC EKIEPLMIJBC, string JIEJOKBHEMF);

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PFONMBNNFFN(JPDMABGMGFC EKIEPLMIJBC, [Out] string NMGPEJCBHKM);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BAEPCCOBEHK(JPDMABGMGFC EKIEPLMIJBC, string NMGPEJCBHKM);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BKHALAPJAAA
{
	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	Guid JLKPPOIDJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	Guid HEAJAHLEIOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DFAPJGNKLDL(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task HOIKHIBDPLA(IKNCJJMPFDD NDBJJGOPOFO);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid LJOKHFAKODE(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NBCKLPPEHNF(JPDMABGMGFC DLICMGKJENE, Guid BHKHNPBBPIB);

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BGILJMHKCHH(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task EIIANNLONEO(JPDMABGMGFC OGHJJFPEOAI, JPDMABGMGFC IGDHFGFJBMG);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IEEACGOMJBG(JPDMABGMGFC DLICMGKJENE, DFCAHNMFPEN DGKIBFCKLJG);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FOGKHNBHFFA
{
	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	Guid JLKPPOIDJFF
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKAEFICOBGP(NativeList<Guid> FFHGHKMKPIJ, NativeList<Guid> MIEBGGIOGNG, NativeList<FixedString64Bytes> LFCHEGFBADL);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PKNPLCMMCBH
{
	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KBNDPJOLEPO INEFCOILAOF(Allocator EKNOCGFFMAE);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KBNDPJOLEPO AJLDCOFCGHG(Allocator EKNOCGFFMAE);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AIPAKLLFLFH(JPDMABGMGFC EKIEPLMIJBC);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OHNMEGPEFCH(JPDMABGMGFC EKIEPLMIJBC);

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EJKEFEFLFPA(JPDMABGMGFC EKIEPLMIJBC, [Out] JPDMABGMGFC PIDJDCPCBOC);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OKKOOAJCOFI(JPDMABGMGFC EKIEPLMIJBC);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MCDGIFBODAJ(JPDMABGMGFC EKIEPLMIJBC, int KDNODDPEIGC);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JPDMABGMGFC GAAODKLHFOP(JPDMABGMGFC PIDJDCPCBOC);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void POEIBDLBDGH(KBNDPJOLEPO JGHIMEJLIML, bool KLNEAOGJMFK);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool ANKFPENFMHN(JPDMABGMGFC EKIEPLMIJBC);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JMHGMKCEAMD(JPDMABGMGFC EKIEPLMIJBC, bool ILJBNAPKFFN);

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int IIBJPPJJHBP();

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FFBHHMPCJHG(JPDMABGMGFC DLICMGKJENE);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LCOKMAMHPKO
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<JPDMABGMGFC, JPDMABGMGFC> POGDGFMMAJE;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<JPDMABGMGFC, JPDMABGMGFC> AJNMKPGNDHB;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<JPDMABGMGFC, JPDMABGMGFC, JPDMABGMGFC> LBFPPAIBJMI;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<JPDMABGMGFC> JPBGFOMKHDI;

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HMEJJDMEFKJ(JPDMABGMGFC DLICMGKJENE, JPDMABGMGFC IJPIOOCFEBB);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JPDMABGMGFC CIMLCJGNDDG(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KBNDPJOLEPO KDHKCAEDHAK(JPDMABGMGFC DLICMGKJENE, Allocator EKNOCGFFMAE);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "11")]
	JPDMABGMGFC DNJDDGCDJFD(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FHJLEGKDNFN(JPDMABGMGFC DLICMGKJENE, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ABAEBIHGNDP(JPDMABGMGFC DLICMGKJENE, float FHGHMAANLMC);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool AMLLNJKMDEG(JPDMABGMGFC DLICMGKJENE, [Out] JPDMABGMGFC IGDHFGFJBMG);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool GCMDFIFNMPM(JPDMABGMGFC DLICMGKJENE, [Out] RigidTransform BBMJHJHNFIB);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 PCEGMLOIIAI(DCLLEBFPMFK MDFAACGKJPJ);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion DDADMNGIMJM(DCLLEBFPMFK MDFAACGKJPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class OAAHPKJFOLJ
{
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EACLJNGLLNL
{
	[Cpp2IlInjected.Token(Token = "0x170001E7")]
	object FMNGNGFCJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MMIAIOKFILG
{
	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FJJBCGKBIAC(JPDMABGMGFC NDBJJGOPOFO, HLAHLGBMHKC DMOKHLJOOMK);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NPMOLONGDKF(HLAHLGBMHKC DMOKHLJOOMK);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GLCPGMKMPAA(JPDMABGMGFC DLICMGKJENE, [Out] HLAHLGBMHKC KIHCMIDFHLC);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PCGKFGEEAPL
{
	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JMAOBFPMLCM(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeArray<JPDMABGMGFC> EAGNCOMHODH();
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[Flags]
public enum CGADOIGNABM
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	IncludeSelf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	IncludeChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	IncludeDescendants = 6,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	IncludeMask = 7,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Disembodied = 8,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Embodied = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	IgnoreEmbodiment = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	EmbodimentMask = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	Runtime = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	Authored = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	AuthoredAndRuntime = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	HierarchyMask = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	HintInputsAreDisjoint = 0x80
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface ADANKEPIGLL
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public ref struct KOIOCFKMHCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ReadOnlySpan<JPDMABGMGFC> BFDIFICLMLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public ReadOnlySpan<JPDMABGMGFC> OJLJMBAGDNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public JPDMABGMGFC GMIMNLIEHHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public JPDMABGMGFC FGDOLAEINPP;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LLJLCHEGFFL(JPDMABGMGFC CHEFNJHEGAJ, JPDMABGMGFC MPPPMKINBIE);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GGONPBEMLHJ(JPDMABGMGFC BALOOJJJPJM, bool MKJGBAFLMBJ);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FBHEJEKJKGM(JPDMABGMGFC ECDPBEGNCDG, JPDMABGMGFC CBDBAEGPFME);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ACJKKPEMNDI(JPDMABGMGFC OBLNGAJKDPB, bool MKJGBAFLMBJ);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BIMANKMKMNE(JPDMABGMGFC OBLNGAJKDPB);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KFOIGNLBMCD(JPDMABGMGFC OBLNGAJKDPB);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JPDMABGMGFC OAOONKBJNOE(JPDMABGMGFC BALOOJJJPJM);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ReadOnlySpan<JPDMABGMGFC> JKACPMKHCMK(JPDMABGMGFC OBLNGAJKDPB);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ReadOnlySpan<JPDMABGMGFC> OAPPCCNMDCF(JPDMABGMGFC OBLNGAJKDPB);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KOIOCFKMHCO EBFKPBMJJNJ(JPDMABGMGFC OBLNGAJKDPB, float MCNLDONFCAD, float BLGIGMAJGBG);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool NCKBKIFOBGG(JPDMABGMGFC OBLNGAJKDPB, [Out] AMNLCHKILHE MCNLLIMEENK);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MCHBGINNLII(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PKLEKFBIFDC(JPDMABGMGFC DLICMGKJENE);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public readonly struct IAPMADEKGFH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly string DJFMCHMDHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly T DAKPJNHJLJO;

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x52169C0", Offset = "0x5214FC0", VA = "0x1852169C0")]
	public IAPMADEKGFH(T DAKPJNHJLJO, [Optional][CallerMemberName] string DJFMCHMDHGK)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly IAPMADEKGFH<int> FKHLPMOAMLK;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public static readonly IAPMADEKGFH<int> JONKMHHMFMM;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public static readonly IAPMADEKGFH<int> PPJNAHFOLKA;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public enum PFCPKBMJGCA
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class AHIIFPMFKDK
{
	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x150FB40", Offset = "0x150E140", VA = "0x18150FB40")]
	public static bool IACALJFCOFE(this PFCPKBMJGCA BJGEPEKIJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x191E180", Offset = "0x191C780", VA = "0x18191E180")]
	public static bool PHBFKBJFEDD(this PFCPKBMJGCA BJGEPEKIJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x31FC8C0", Offset = "0x31FAEC0", VA = "0x1831FC8C0")]
	public static bool CMEOFDKJBKE(this PFCPKBMJGCA BJGEPEKIJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x150FB50", Offset = "0x150E150", VA = "0x18150FB50")]
	public static bool JHDBBICFDOC(this PFCPKBMJGCA BJGEPEKIJPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface KBJOHEFJLLK
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public enum GGBPNBHANOI
	{
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		Unloaded,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		Loading,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		Loaded,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public enum CHEMLDFAIML
	{
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x170001E8")]
	GGBPNBHANOI DPBAHOFHHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E9")]
	bool HCEHGADACEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EA")]
	bool DACLOFBDGIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EB")]
	CHEMLDFAIML CCEGLELLDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[ServiceLifetime(Lifetime.Application)]
public interface JLHECGDOECJ
{
	[Cpp2IlInjected.Token(Token = "0x170001EC")]
	PFCPKBMJGCA OIMPCNDOHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001ED")]
	PFCPKBMJGCA JJDCBGIHCCL
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EE")]
	PFCPKBMJGCA CPOKDFPIMBG
	{
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EF")]
	PFCPKBMJGCA CCEONOOKKGH
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F0")]
	PFCPKBMJGCA GEMAPLLABNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F1")]
	PFCPKBMJGCA NEHOKBJEIKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F2")]
	PFCPKBMJGCA KFIOJGPIEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F3")]
	PFCPKBMJGCA AAMJKJNMAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F4")]
	PFCPKBMJGCA FLPIIHMDACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F5")]
	PFCPKBMJGCA OMCFLHGALAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F6")]
	PFCPKBMJGCA CGHMLHBCCIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F7")]
	PFCPKBMJGCA CFEONLLOAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F8")]
	PFCPKBMJGCA BOFMNGLGLHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F9")]
	PFCPKBMJGCA HGOKAJBLDHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FA")]
	PFCPKBMJGCA GKFLIJJBFPG
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FB")]
	PFCPKBMJGCA OHDOEPMOJBF
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FC")]
	PFCPKBMJGCA DICHMGOFION
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FD")]
	PFCPKBMJGCA EHPOHCCGCNC
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FE")]
	PFCPKBMJGCA CILEKKGLFLH
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JLOHDPKHFGN(IAPMADEKGFH<int> CKJHMCELOAA);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PJMIJJNNDLG
{
	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event IPPKGHDPCJD.FBPAMAKCHNK LOHEOJHLKLN;

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JPDMABGMGFC AFFGEPDHNLC(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KBNDPJOLEPO FKCLCOFFKAM(Allocator EKNOCGFFMAE);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EDCLCHHFDDJ IACLPJGLBHM(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OCGEMBELOFA(IEnumerable<JPDMABGMGFC> IFMJDJHKLAP);

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EDCLCHHFDDJ AEONFNIDGDP(JPDMABGMGFC IGDHFGFJBMG, JPDMABGMGFC JHGKHIGHBBL, bool IDIDHJHBMGF, JPDMABGMGFC LKEAKCADNOO);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JPDMABGMGFC KHLABIBIDLF(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MBGDBGDPEAA(JPDMABGMGFC DLICMGKJENE, JPDMABGMGFC IGDHFGFJBMG, bool NMNOBFFEDFI = false);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OKFMNDLMFLA(JPDMABGMGFC DLICMGKJENE, JPDMABGMGFC IGDHFGFJBMG);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool AAOKAHEKILB(JPDMABGMGFC CEGIODCDBFF, JPDMABGMGFC IADPEIJGEAM);

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[Obsolete("Use IHierarchyService.GetChildren() instead")]
	KBNDPJOLEPO JIGBDAEKFGB(JPDMABGMGFC IEIKHLNDANP);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool BFMFGBHIAEK(JPDMABGMGFC DLICMGKJENE, JPDMABGMGFC NBHOBEABGAN);

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KBNDPJOLEPO KGGAHAHICKO(KBNDPJOLEPO AIEPEINMAJP, CGADOIGNABM OAKCIAMNOIJ, Allocator EKNOCGFFMAE);

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool APNAFAFBGKN(JPDMABGMGFC DLICMGKJENE, JPDMABGMGFC KABCEGDMAJC);

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	JPDMABGMGFC BMBACBHOEGL(JPDMABGMGFC LKEAKCADNOO, JPDMABGMGFC DHPJAJNLOGD);

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool KMBPPHEOEFF(JPDMABGMGFC LKEAKCADNOO, JPDMABGMGFC DHPJAJNLOGD, [Out] JPDMABGMGFC JNGGBNEEAEA);

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(Slot = "17")]
	JPDMABGMGFC EBPKKAECHHB(JPDMABGMGFC[] JGHIMEJLIML);

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "18")]
	JPDMABGMGFC IJFDOLGGAGE(JPDMABGMGFC DLICMGKJENE, uint KKMPBBAOBND);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class GAMHHCEIOGH
{
	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x8639440", Offset = "0x8637A40", VA = "0x188639440")]
	public static bool HGAPFBEBFEO(this PJMIJJNNDLG OFEABOHNFFG, JPDMABGMGFC DLICMGKJENE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x8639650", Offset = "0x8637C50", VA = "0x188639650")]
	public static KBNDPJOLEPO KGGAHAHICKO(this PJMIJJNNDLG PDGKOFDJCFH, JPDMABGMGFC DLICMGKJENE, CGADOIGNABM OAKCIAMNOIJ, Allocator EKNOCGFFMAE)
	{
		return default(KBNDPJOLEPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x8639920", Offset = "0x8637F20", VA = "0x188639920")]
	public static KBNDPJOLEPO NLKBACHBIPD(this PJMIJJNNDLG PDGKOFDJCFH, JPDMABGMGFC DLICMGKJENE, Allocator EKNOCGFFMAE)
	{
		return default(KBNDPJOLEPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x86398E0", Offset = "0x8637EE0", VA = "0x1886398E0")]
	public static KBNDPJOLEPO KKLKAEKIJNE(this PJMIJJNNDLG PDGKOFDJCFH, JPDMABGMGFC DLICMGKJENE, Allocator EKNOCGFFMAE)
	{
		return default(KBNDPJOLEPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x8639610", Offset = "0x8637C10", VA = "0x188639610")]
	public static KBNDPJOLEPO IPLHBOLIPHG(this PJMIJJNNDLG PDGKOFDJCFH, JPDMABGMGFC DLICMGKJENE, Allocator EKNOCGFFMAE)
	{
		return default(KBNDPJOLEPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x8639400", Offset = "0x8637A00", VA = "0x188639400")]
	public static KBNDPJOLEPO CBILFODPJKJ(this PJMIJJNNDLG PDGKOFDJCFH, JPDMABGMGFC DLICMGKJENE, Allocator EKNOCGFFMAE)
	{
		return default(KBNDPJOLEPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x8639960", Offset = "0x8637F60", VA = "0x188639960")]
	public static KBNDPJOLEPO OFCEGFOOEHI(this PJMIJJNNDLG PDGKOFDJCFH, JPDMABGMGFC DLICMGKJENE, Allocator EKNOCGFFMAE)
	{
		return default(KBNDPJOLEPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x86395D0", Offset = "0x8637BD0", VA = "0x1886395D0")]
	public static KBNDPJOLEPO HPOPGFNGHBI(this PJMIJJNNDLG PDGKOFDJCFH, JPDMABGMGFC DLICMGKJENE, Allocator EKNOCGFFMAE)
	{
		return default(KBNDPJOLEPO);
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x86394B0", Offset = "0x8637AB0", VA = "0x1886394B0")]
	public static KBNDPJOLEPO HPOPGFNGHBI(this PJMIJJNNDLG PDGKOFDJCFH, KBNDPJOLEPO DLICMGKJENE, Allocator EKNOCGFFMAE)
	{
		return default(KBNDPJOLEPO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NOODHNFGAPA
{
	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x86473B0", Offset = "0x86459B0", VA = "0x1886473B0", Slot = "0")]
	Task<BLHKDPCKPPH> GIJMFPAMAMC(CNNNEKPIBJG IIPDIFDFMDN, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "1")]
	void IEBFBCNKGOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface ACGCFACLMIE
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event IPPKGHDPCJD.FBPAMAKCHNK LOHEOJHLKLN;

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JPDMABGMGFC KHLABIBIDLF(JPDMABGMGFC OGHJJFPEOAI);

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ReadOnlySpan<JPDMABGMGFC> AIHHHECMOFB();

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ReadOnlySpan<JPDMABGMGFC> ELMJFCEKMHN(JPDMABGMGFC IGDHFGFJBMG);

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GLKBJNGEHDB(JPDMABGMGFC PKCOJOJEMOM, JPDMABGMGFC HBNEHEJGIND, [Out] EDCLCHHFDDJ ACKONEOPDOK);

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool IHMCFJKHAHP(JPDMABGMGFC PKCOJOJEMOM, JPDMABGMGFC KOHILJGKLMD, [Out] EDCLCHHFDDJ ACKONEOPDOK);

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MHHLBJDBLNF(JPDMABGMGFC PKCOJOJEMOM);

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OKFMNDLMFLA(JPDMABGMGFC LHFIKNDEEAN, JPDMABGMGFC GHOEBAIBIJA);

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EDCLCHHFDDJ IOGLHJFDGIM(JPDMABGMGFC DLICMGKJENE);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MDNJPDDHNCC
{
	[Cpp2IlInjected.Token(Token = "0x170001FF")]
	bool BDLECMADHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000200")]
	bool HGCOMAKDNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000201")]
	bool LOGDJCBACHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GMEDFIFKEJB
{
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IJEGBCMDEPI
{
	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KDIKDIEFEIF(JPDMABGMGFC DLICMGKJENE, OBBAANPPIBD BJBANDBIGLN);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPKBJIHOOGN(JPDMABGMGFC DLICMGKJENE, OBBAANPPIBD BJBANDBIGLN);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface KHKDPNKPPLH
{
	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BHDJDKBLBGL<string> AKILHBJMAEK(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BHDJDKBLBGL<string> GJJBPGLEEMM(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BCHMJJEMIKD(JPDMABGMGFC DLICMGKJENE, BHDJDKBLBGL<string> MFBOBLCOBIC);

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BEBBOAFGEAA(JPDMABGMGFC DLICMGKJENE, BHDJDKBLBGL<string> MFBOBLCOBIC);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BFKMHNNEPEL(JPDMABGMGFC MJNOEAJIBJI, JPDMABGMGFC IOPIPLKACJK);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OPGIHBLMGOL
{
	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EKGHLLENOHA FBJOOHOECGM(JPDMABGMGFC EKIEPLMIJBC);

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IONPFPDCIDA(JPDMABGMGFC EKIEPLMIJBC, EKGHLLENOHA ODAEJFIKMEL);

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CLCHNCGCBIO(JPDMABGMGFC EKIEPLMIJBC);

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EAPEEKALLFA(JPDMABGMGFC EKIEPLMIJBC, bool FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BHDJDKBLBGL<string> IJMLELLMHAF(JPDMABGMGFC EKIEPLMIJBC);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HCMEAFIOABK(JPDMABGMGFC EKIEPLMIJBC, BHDJDKBLBGL<string> MFBOBLCOBIC);

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BHDJDKBLBGL<string> MEMJJDAIKOA(JPDMABGMGFC EKIEPLMIJBC);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GDIHAFJNDEL(JPDMABGMGFC EKIEPLMIJBC, BHDJDKBLBGL<string> MFBOBLCOBIC);

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BHDJDKBLBGL<string> BHHCIEMBCCO(JPDMABGMGFC EKIEPLMIJBC);

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PPPDMMBGHFE(JPDMABGMGFC EKIEPLMIJBC, BHDJDKBLBGL<string> MFBOBLCOBIC);

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BHDJDKBLBGL<string> BJEKJFOHNAJ(JPDMABGMGFC EKIEPLMIJBC);

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CABGHCDPGJB(JPDMABGMGFC EKIEPLMIJBC, BHDJDKBLBGL<string> MFBOBLCOBIC);

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool OFOIBJBAEGG(JPDMABGMGFC EKIEPLMIJBC, JPDMABGMGFC LIOICDJHFAF);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MNJDPDLIIMN
{
	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BMLOALMKDLK([In] float3 COELDBNFGAO, [In] float3 FANJPCNJGDA, float LHLABDNDDPG, [Out] IBNBBCAHHCN DPNBMJCCOLC, [Out] JPDMABGMGFC NLAOFGKAGCG);

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int FOMPCEDFIAB([In] float3 COELDBNFGAO, float OFHHJJPMNHK, List<JPDMABGMGFC> JGHIMEJLIML);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int LIDMFMJLMJD(Plane[] NCLJFHKMKKK, float3 COELDBNFGAO, float3 BNGBMCKMBBL, quaternion NEOIPHFFLHF, List<JPDMABGMGFC> JGHIMEJLIML);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IHCFIEIGGON
{
	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BMLOALMKDLK([In] NativeArray<Entity> GIPMABPLBDJ, [In] float3 COELDBNFGAO, [In] float3 FANJPCNJGDA, [In] NativeArray<IBNBBCAHHCN> KPJCPFGKKMB);

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> FOMPCEDFIAB([In] NativeArray<Entity> GIPMABPLBDJ, [In] float3 COELDBNFGAO, float OFHHJJPMNHK);

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> LIDMFMJLMJD([In] NativeArray<Entity> GIPMABPLBDJ, [In] NativeArray<float4> LHDCIOGGHGD);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct PBEDEAIDJJM : ILGHCGIBOJL, IEquatable<PBEDEAIDJJM>
{
	[Cpp2IlInjected.Token(Token = "0x17000202")]
	public int LBGMECNKHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x1574730", Offset = "0x1572D30", VA = "0x181574730", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000203")]
	public int CIDOMJAOOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x302EA20", Offset = "0x302D020", VA = "0x18302EA20", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x302EA30", Offset = "0x302D030", VA = "0x18302EA30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x864A080", Offset = "0x8648680", VA = "0x18864A080", Slot = "8")]
	public bool Equals(PBEDEAIDJJM IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x864A0D0", Offset = "0x86486D0", VA = "0x18864A0D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct IBNBBCAHHCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float AMNAKHPFFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public float3 NNMAALGIDJM;
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LHGHNOHHPJM
{
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OBECOIDGDPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000204")]
	JEGHBMGNMHL IBEKGCKCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000205")]
	OCEOCOFMNNA NDOGMIJONNG
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000206")]
	int BNOMHOBOEKH
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000207")]
	int CFHFIIJHONB
	{
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000208")]
	int NPNFMGDOMAA
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000209")]
	int PJEGGFAJICJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<KBNDPJOLEPO, NativeArray<RRObjectPrefabData>> NOJCCLKNEGJ;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<KBNDPJOLEPO> OPHOCGLBEGD;

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KBNDPJOLEPO OLBIJBIEKED();

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HCOAEMGEKKC GLNPCJGIMEJ(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	RRObjectPrefabData EAAHNIEJLJP(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void APKAIJECKIM(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IKNCJJMPFDD GPECJAGCCDD(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool NHFDHNJCAEC(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool EPLGMNCLHNG(JPDMABGMGFC DLICMGKJENE, [Out] Transform JAHKFPBBGHB);

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	JPDMABGMGFC IKAGPECJIDK(DFCAHNMFPEN CBBPNNMFEHI);

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool IEMNLFDGPID(DFCAHNMFPEN CBBPNNMFEHI, [Out] JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(Slot = "19")]
	DFCAHNMFPEN NEJADLHJLHB(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	KBNDPJOLEPO IKAGPECJIDK(NativeArray<DFCAHNMFPEN> CBBPNNMFEHI, Allocator EKNOCGFFMAE, bool CFILDFKOHNF = true);

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool IOKLHDHNKDB(NativeArray<GHNOPBMMBDI> JHOOIFBNLBI, NativeArray<DFCAHNMFPEN> COGCHCHPDMO, NativeArray<Entity> IEOGPPIOKPF, BHDJDKBLBGL<NHGAECOMCAG> LKEECMGHLLM);

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	IKNCJJMPFDD GIFBLEIBPAP();

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	IKNCJJMPFDD KLCCKEGCKGG(RRObjectPrefabData MMBNDPFHBFJ, [Optional] DDNEFPADLOB MNJNEMLJNMP);

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	MHEOAEBOFDI HFHGODFHAFA();

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	HFLBAJMNINP ECHEPOOPAFJ();

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	OKNKKKBOHOE KDGICLDODPC(FNNLELJCGID LJGNBNPPJMG);

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DGMNKKIJJMO(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool ONPINHCKBML(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(Slot = "29")]
	KBNDPJOLEPO BLNFGGICGAL(KBNDPJOLEPO NDOMHCGKPHC, Allocator EKNOCGFFMAE);

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool ANHHLAMACIC(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool GNPEGBBEEHN(JPDMABGMGFC DLICMGKJENE, ComponentTypes DNGPNAMHMCG);

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "32")]
	JPDMABGMGFC CMMAGPHEMCA(Transform JAHKFPBBGHB);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class HHJBDMPFGDI
{
	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x863B270", Offset = "0x8639870", VA = "0x18863B270")]
	internal static JPDMABGMGFC GDEKAIFFABM(this Entity COIPJNEHPIG, OBECOIDGDPJ CGAAKJBHOHG)
	{
		return default(JPDMABGMGFC);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x863B730", Offset = "0x8639D30", VA = "0x18863B730")]
	public static IKNCJJMPFDD MAKKBKCPEAK(this OBECOIDGDPJ CGAAKJBHOHG, LocalId DLICMGKJENE)
	{
		return default(IKNCJJMPFDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x863B4D0", Offset = "0x8639AD0", VA = "0x18863B4D0")]
	public static JPDMABGMGFC IKAGPECJIDK(this OBECOIDGDPJ CGAAKJBHOHG, LocalId DLICMGKJENE)
	{
		return default(JPDMABGMGFC);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x863B740", Offset = "0x8639D40", VA = "0x18863B740")]
	public static DFCAHNMFPEN NEJADLHJLHB(this OBECOIDGDPJ CGAAKJBHOHG, LocalId DLICMGKJENE)
	{
		return default(DFCAHNMFPEN);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x863B090", Offset = "0x8639690", VA = "0x18863B090")]
	public static MHEOAEBOFDI AMOHOGGGDPG(this OBECOIDGDPJ CGAAKJBHOHG, RigidTransform CDOMFLOAMJF)
	{
		return default(MHEOAEBOFDI);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x863B580", Offset = "0x8639B80", VA = "0x18863B580")]
	public static OKNKKKBOHOE JCMMJPFMOJK(this OBECOIDGDPJ CGAAKJBHOHG, FNNLELJCGID BPBDHNPBNNC, RigidTransform CDOMFLOAMJF)
	{
		return default(OKNKKKBOHOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x863B320", Offset = "0x8639920", VA = "0x18863B320")]
	public static HFLBAJMNINP HIBBFDMIFAM(this OBECOIDGDPJ CGAAKJBHOHG, RigidTransform CDOMFLOAMJF)
	{
		return default(HFLBAJMNINP);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x863B240", Offset = "0x8639840", VA = "0x18863B240")]
	private static void CECNBCNEFDK(IKNCJJMPFDD CGHOHHNMHOO, RigidTransform CDOMFLOAMJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal interface MKKAGHCNOLI
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GFMNBMCKDCK
{
	[Cpp2IlInjected.Token(Token = "0x1700020A")]
	bool OFJJNBCPMDI
	{
		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020B")]
	JPDMABGMGFC PCKLDIHGKEH
	{
		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020C")]
	IKNCJJMPFDD JPPPCEEPFNL
	{
		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event DFIGMDKOMGB BPCFJIFAEML;

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JPDMABGMGFC BMBACBHOEGL(JPDMABGMGFC LKEAKCADNOO, JPDMABGMGFC DHPJAJNLOGD);

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KMBPPHEOEFF(JPDMABGMGFC LKEAKCADNOO, JPDMABGMGFC DHPJAJNLOGD, [Out] JPDMABGMGFC JNGGBNEEAEA);

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MBLCINFENBO();

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OGOKCEGAJDG();

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool PHKNNEBDNGJ(JPDMABGMGFC LKEAKCADNOO);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool AJIJGBKKCGN(JPDMABGMGFC LKEAKCADNOO);
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public delegate void DFIGMDKOMGB(IKNCJJMPFDD GBCBLDCJJGP, IKNCJJMPFDD NBHPFGEBDHF);
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class BNCOPJLKIIL
{
	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x8633720", Offset = "0x8631D20", VA = "0x188633720")]
	public static bool DJBBNHNGKKD(this GFMNBMCKDCK ONKLKNCHMGE, IKNCJJMPFDD LKEAKCADNOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x8633640", Offset = "0x8631C40", VA = "0x188633640")]
	public static bool AILLHNGBDBI(this GFMNBMCKDCK ONKLKNCHMGE, JPDMABGMGFC LKEAKCADNOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x8633770", Offset = "0x8631D70", VA = "0x188633770")]
	public static bool NFCLEPBHOGA(this GFMNBMCKDCK ONKLKNCHMGE, JPDMABGMGFC LKEAKCADNOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JNJJKDDCAKI
{
	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GAEJDFMEADE(NativeList<RRObjectPrefabData> BIIMOGDNNEI);
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KPBLBAHGLCA
{
	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CNIDJGADDBK(IKNCJJMPFDD CGHOHHNMHOO, APBOCLHIEMC DEKFAJBJCEK, List<IKNCJJMPFDD> CJDAJOJGDLD);

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int ENKDJINCGOP(IKNCJJMPFDD CGHOHHNMHOO, APBOCLHIEMC DEKFAJBJCEK);

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MMPMHLGBCLA(IKNCJJMPFDD CGHOHHNMHOO, List<IKNCJJMPFDD> CJDAJOJGDLD);

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NPHKDLLOMIF(IKNCJJMPFDD DBPGJLKPCJJ, IKNCJJMPFDD LKEAKCADNOO, APBOCLHIEMC DEKFAJBJCEK);

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IKNCJJMPFDD HAEBJKHNDFM(IKNCJJMPFDD DBPGJLKPCJJ, int LEPAEEGOBDO, APBOCLHIEMC DEKFAJBJCEK);

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EPCOIEFPOHN(IKNCJJMPFDD DBPGJLKPCJJ, IKNCJJMPFDD LKEAKCADNOO, APBOCLHIEMC DEKFAJBJCEK);

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EIGNDAAEBCJ(IKNCJJMPFDD DBPGJLKPCJJ, IKNCJJMPFDD LKEAKCADNOO, APBOCLHIEMC DEKFAJBJCEK);

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LHPMKPMMBKN(IKNCJJMPFDD DBPGJLKPCJJ, APBOCLHIEMC DEKFAJBJCEK);

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CFKKOHGNONO(IKNCJJMPFDD DBPGJLKPCJJ, IKNCJJMPFDD LKEAKCADNOO, APBOCLHIEMC DEKFAJBJCEK);

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MMHNOFFMKFG(Entity DBPGJLKPCJJ, Entity LKEAKCADNOO, APBOCLHIEMC DEKFAJBJCEK);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AEDBLFGNADD(Entity DBPGJLKPCJJ, APBOCLHIEMC DEKFAJBJCEK);

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KECFJAEGOBE(IKNCJJMPFDD LKEAKCADNOO, APBOCLHIEMC DEKFAJBJCEK);
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ODANGKLKGBE
{
	[Cpp2IlInjected.Token(Token = "0x1700020D")]
	BMNOFAFDNLB GFJPPPHGLCG
	{
		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JAIIIGOGONJ NFMOLLADFBG(BMNOFAFDNLB PDFMOBOALJB);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BMNOFAFDNLB LCJBCINGJIM();

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BMNOFAFDNLB FJPNLJJDJGJ();
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ODLKCBMJKEM
{
	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PAMHJDMMEKG(JPDMABGMGFC LKEAKCADNOO, [Out] JPDMABGMGFC NMMHEOOEAFB);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HGLOKDGFNDP
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<JPDMABGMGFC> PBANDLKPCJE;

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IEIJFIJGNLA(JPDMABGMGFC IEIKHLNDANP, bool FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DDIKJFILLKN(JPDMABGMGFC IEIKHLNDANP, bool FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DNNCPDBODID(JPDMABGMGFC IEIKHLNDANP, int FKMNCAKIOFK);
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LGOOCNJBMPM
{
	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<JPDMABGMGFC> CLLAHIJKDOP(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JPDMABGMGFC JMBCNPICEJG(JPDMABGMGFC DLICMGKJENE, int LEPAEEGOBDO);

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int EMIIJONHNGF(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EKPIPMMBPJG CONLLNNDNOD(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NFDACKHFBAG(JPDMABGMGFC DLICMGKJENE, EKPIPMMBPJG MHCCEBNBPPI);

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JPDMABGMGFC AANDCEGMNDA(JPDMABGMGFC DLICMGKJENE, [Optional] float3? AANGPKCDGHO, [Optional] quaternion? NEOIPHFFLHF, [Optional] float3? ILFCOODFNFF);

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JPDMABGMGFC NEAKMJHKPGM(JPDMABGMGFC DLICMGKJENE, int LEPAEEGOBDO, [Optional] float3? AANGPKCDGHO, [Optional] quaternion? NEOIPHFFLHF, [Optional] float3? ILFCOODFNFF);

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void COKLCFGOIHC(JPDMABGMGFC DLICMGKJENE, int LEPAEEGOBDO);

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LDLEABOGPDD(JPDMABGMGFC DLICMGKJENE);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HELKEBMPMOK
{
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface GBCLPAEIMJK
{
	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGBDGBOLOEK(JPDMABGMGFC DLICMGKJENE, ReadOnlySpan<TerrainGenerationLayer> HOJKHOAIOFC);

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LMLGHKIKNDD(JPDMABGMGFC DLICMGKJENE, ReadOnlySpan<NPDFLAAOGLM> HOJKHOAIOFC);
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NNHFPOFCEGC
{
	[Cpp2IlInjected.Token(Token = "0x1700020E")]
	bool OBCGGHGAMGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KOJFNNDMJPM();

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BNIFIHDNKEC();

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BKCGBFOEAFN();

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OHKIJDBJKDH();

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EHKPJLHIDPI();

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HKJKHNAMEPE();

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KIEDEOAEKGI();

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IPCELFIDDNP();

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NOCOCOJFJNP();

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BEIEKFPBAIG();

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GJNIDPAGKPB();

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FLACDHCFLBF();
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CIFJPDAEAKC
{
	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CAJLIMJBNLG(JPDMABGMGFC LKEAKCADNOO, [Out] int DBPGJLKPCJJ);

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BPADMMEKBDB(JPDMABGMGFC LKEAKCADNOO, int DBPGJLKPCJJ);

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MIPMNODCLHO(JPDMABGMGFC LKEAKCADNOO, bool JEAIDNPFABG);

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AJLENOOOEKD(JPDMABGMGFC LKEAKCADNOO, float OJNDOININCB, float OLEOPJECKDE, float OCOMKMIGINM);

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HDALHIPJBDO(JPDMABGMGFC DLICMGKJENE, [Out] float OLEOPJECKDE, [Out] float OCOMKMIGINM);

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KLFPJEIPMDI(JPDMABGMGFC LKEAKCADNOO, float3 AANGPKCDGHO, quaternion NEOIPHFFLHF);

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PHGLNFAOPCN(JPDMABGMGFC LKEAKCADNOO, [Out] float3 AANGPKCDGHO, [Out] quaternion NEOIPHFFLHF);

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void POFFNJINHND(JPDMABGMGFC LKEAKCADNOO);
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CMLIPCHHEFN
{
	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NADHFBDPEMB(Entity COIPJNEHPIG, [In] float3 FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float3 GIKMBEBNGNB(Entity COIPJNEHPIG);

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NPGJLNJIGPA(Entity COIPJNEHPIG, [In] quaternion FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(Slot = "3")]
	quaternion NKMKCOMHMCC(Entity COIPJNEHPIG);

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LGKBKABINPP(Entity COIPJNEHPIG, [In] float3 AANGPKCDGHO, [In] quaternion NEOIPHFFLHF);

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KFOAMDOFEFM(Entity COIPJNEHPIG, [Out] RigidTransform EAMKMKADNDA);

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NGHDFDJFHHC(Entity COIPJNEHPIG, [In] float3 AANGPKCDGHO, [In] quaternion NEOIPHFFLHF);

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FPHIBMLAJMN(Entity COIPJNEHPIG, [Out] float3 AANGPKCDGHO, [Out] quaternion NEOIPHFFLHF);

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FPHIBMLAJMN(Entity COIPJNEHPIG, [Out] RigidTransform EAMKMKADNDA);

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DLFKCOCMNOE(Entity COIPJNEHPIG, float FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float FAGBOIJFJHK(Entity COIPJNEHPIG);

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CNNBIBJKJGF(Entity COIPJNEHPIG, [In] float3 FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 GAGKMEDOHAO(Entity COIPJNEHPIG);

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DHNOGEMPBDH(Entity COIPJNEHPIG, [In] quaternion FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	quaternion KALOJPBFNHP(Entity COIPJNEHPIG);

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PEFMKOADEPI(Entity COIPJNEHPIG, float FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float IOJGMFEPNDO(Entity COIPJNEHPIG);

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CIIPJLMAMMD(Entity COIPJNEHPIG, [Out] float4x4 LHPFFMMIKCK);

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void POAJMMNHPEG(Entity COIPJNEHPIG, [In] float4x4 LHPFFMMIKCK);

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void FANCEHLGNBL(Entity COIPJNEHPIG);

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LJJDAKMOGGM(Entity COIPJNEHPIG, Entity AMAKHBDINOP, Entity GHOEBAIBIJA);
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class HODFFIJPFGK
{
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ODOCLMEHGNL
{
	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECFEDJDOBMG(bool BPEBLCNNACG);
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JKFEBNFJACN
{
	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNDDJIAGIFD(JPDMABGMGFC EKIEPLMIJBC, BHDJDKBLBGL<string> MFBOBLCOBIC);

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EKHCNCDCHLN(JPDMABGMGFC EKIEPLMIJBC, BHDJDKBLBGL<string> MFBOBLCOBIC);

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OCJMCKPPHMD(JPDMABGMGFC EKIEPLMIJBC, BHDJDKBLBGL<string> MFBOBLCOBIC);

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EJAMHGJCIMI(JPDMABGMGFC EKIEPLMIJBC, BHDJDKBLBGL<string> MFBOBLCOBIC);

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MKJBHGEEHKH(JPDMABGMGFC EKIEPLMIJBC, BHDJDKBLBGL<string> MFBOBLCOBIC);

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ICMCKPDHLME(JPDMABGMGFC EKIEPLMIJBC, BHDJDKBLBGL<string> MFBOBLCOBIC);

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int AGAOAEPJIAA(JPDMABGMGFC EKIEPLMIJBC);

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int FNDALNIACIL(JPDMABGMGFC EKIEPLMIJBC);

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int FMDLKMHJCMF(JPDMABGMGFC EKIEPLMIJBC);

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BIGICIGIIKM<string> JIPDHPPIEPH(JPDMABGMGFC EKIEPLMIJBC);

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool DABEJPNAOOF(JPDMABGMGFC EKIEPLMIJBC);

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BIGICIGIIKM<string> CAODGJNCAMJ(JPDMABGMGFC EKIEPLMIJBC);

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool IFCDCDIAAFC(JPDMABGMGFC EKIEPLMIJBC, string BBLDJOHEJKC);

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GFIJMMHCJPA(string BBLDJOHEJKC, OFEOMCMBEAB JDGNKDPHDLC);

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(Slot = "14")]
	JPDMABGMGFC FLIPOBFCPND(string BBLDJOHEJKC);

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JBLPPBHLHFL(string BBLDJOHEJKC, OFEOMCMBEAB JDGNKDPHDLC);

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KCIDEGPFMNO(JPDMABGMGFC HOHEMDMMBEB, string BBLDJOHEJKC, OFEOMCMBEAB JDGNKDPHDLC);

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(Slot = "17")]
	BIGICIGIIKM<string> GAHMCJNMHGK();
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public static class EMKMANHEGJM
{
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CCBGDPLHDKA
{
	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World HKLMOKEHOFI(string AJAGJMEMIPD = "Main");

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World ONHNFMOFMND(string AJAGJMEMIPD = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World JCAHMIBNNEH(string AJAGJMEMIPD = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World BGEOOHMKKDI(string AJAGJMEMIPD = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PNCGDOMLIHN
{
	[Cpp2IlInjected.Token(Token = "0x1700020F")]
	World KAGKOCFAGJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000210")]
	World OHIKABKMONL
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000211")]
	EntityManager HNJPJAEOPKA
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000212")]
	bool MMNPCHICOFF
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase KBMCGGLMDML(Type EHLAHNIAPLD);
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public static class LPMPBPKCBFH
{
	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x8642AF0", Offset = "0x86410F0", VA = "0x188642AF0")]
	public static ComponentSystemBase LHEMEPFIPLC(this World JJBMFGJCFJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x3E8AF70", Offset = "0x3E89570", VA = "0x183E8AF70")]
	public static T KBMCGGLMDML<T>(this PNCGDOMLIHN BNEPIPHNALE) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OFBPKMGBBMD
{
	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPLIBDOLDOC(NativeListAsync<Entity> LDCHIEEMGMI);

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NGJJHOBJCAH(HFPDLIPAPCD GKOMJCLMCNG);

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CMJAADPGLCL(NativeListAsync<Entity> POMBHGHPGLN, bool PKJELNLDBFJ);

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FJLDPDDKGCG();

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MDCBBIBLHIN(Entity PPOKNBNEDHM);
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface DNAJKNPOMBA
{
	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MJDIFOEECIB(Collider ABMPKGCACDO, [Out] OJCCFOIEAFE KLKFLDEMHIJ);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JADIKJNPNMB
{
	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider KHCGLJAGJIC(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject FKPGBHLJHHP(JPDMABGMGFC FODNKOODFAA, GameObject EEGMKGNBEOE, Vector3 AEDFHMKGLON, Quaternion IOCPNAEAJJE);

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MPBALIDEMNE(GameObject ABMPKGCACDO);

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider NEJHOIFDLDD<TCollider>(GameObject BDNPHEEJLPG) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LLCCLNLHOLE(Collider ABMPKGCACDO);

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject DCNJACFPDHG<TCollider>(string DJFMCHMDHGK) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NBALKAFBMOC FPKADDGICIF(JPDMABGMGFC GDOINFIDPNC, JPDMABGMGFC GOLLPIHGAFL, FNNLELJCGID IBGOFAHJPDE, float3 MNHICBAKOKC, quaternion PGJOHBBCBAD, float3 JLENBJDEIJA);

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HDKDKGBOLPE(JPDMABGMGFC DLICMGKJENE, [Out] NBALKAFBMOC ABMPKGCACDO);

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ABJGKMNMONP(JPDMABGMGFC DLICMGKJENE, [Out] JPDMABGMGFC PPOKNBNEDHM);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public enum HJMBGDPDIJB
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KNLCBINKMLD
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public struct OJOMDHMDLMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int IBGOFAHJPDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public GameObject EEGMKGNBEOE;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NKNKGOFCHCF(JPDMABGMGFC DLICMGKJENE, KBEFHOKOHMI CIDFPLMCAJE, bool KKKGIGMCBPC, DJIAOOPCFNI CLKHHNGFGPP);

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFMPNOMFOAN(JPDMABGMGFC DLICMGKJENE, KBEFHOKOHMI CIDFPLMCAJE, bool KKKGIGMCBPC, bool MAELOCPOELD, bool AFOMLABIGBF);

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IHFILFAJGML FJOBECIEBDN(JPDMABGMGFC PPOKNBNEDHM, List<JPDMABGMGFC> OPNHLFICKPF);

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NBALKAFBMOC LKDCCILCLEL(GameObject OCCILGFHGDI, GameObject AAKOPNCMIEB);

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EIOBLPCDEGM(GameObject OCCILGFHGDI, List<GameObject> FDFIHILNEKI);

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FDCMCDDKIOO(GameObject AAKOPNCMIEB);

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T NEJHOIFDLDD<T>(GameObject BDNPHEEJLPG) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LLCCLNLHOLE(Collider ABMPKGCACDO);

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject JFHIEPEMPAB<T>(string DJFMCHMDHGK) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GLPGEMFHDCK(Collider ABMPKGCACDO, [Out] JPDMABGMGFC DBPGJLKPCJJ);

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool LNMKPFINPPE(JPDMABGMGFC DLICMGKJENE, [Out] OJCCFOIEAFE KLKFLDEMHIJ);

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<HJMBGDPDIJB> PJAOJABFLHG(Allocator EKNOCGFFMAE = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] IGFFJINFKII();
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KHHNOKPHJIO
{
	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CIHCHEDEEEJ(JPDMABGMGFC DLICMGKJENE, JPDMABGMGFC FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AIDHOBEDGKE(JPDMABGMGFC DLICMGKJENE, JPDMABGMGFC FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int NJGBJAMENCG(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JPDMABGMGFC OHMJFBCBFPF(JPDMABGMGFC DLICMGKJENE, int LEPAEEGOBDO);

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KBNDPJOLEPO JDCMIECNOIF(JPDMABGMGFC DLICMGKJENE, Allocator EKNOCGFFMAE = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HFGGGGDGPGF(JPDMABGMGFC DLICMGKJENE, object HNGIMMGBLII, JPDMABGMGFC FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DBDJGLOJLPD(JPDMABGMGFC DLICMGKJENE, object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool JJHNLPMLIEG(JPDMABGMGFC DLICMGKJENE, [Out] JPDMABGMGFC FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HNABBDJPJBG(JPDMABGMGFC DLICMGKJENE, float3 FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool AKGGHGGPEEB(JPDMABGMGFC DLICMGKJENE, [Out] float3 FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NICMIOMBOFL(JPDMABGMGFC DLICMGKJENE, float3 FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FPDGCCJIAGG(JPDMABGMGFC DLICMGKJENE, [Out] float3 FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CKJICODCCCP(JPDMABGMGFC DLICMGKJENE, (Quaternion rot, Vector3 moments) ALGBGLDGENP);

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool GLOALPGOAPA(JPDMABGMGFC DLICMGKJENE, [Out] quaternion LNFJGJBDGFN, [Out] float3 PLANJLKJGOC);

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IMPPPNMHKDH(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 KELJLDINLBP(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 DJNLGDHFEFD(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JAPIBODCAPC(JPDMABGMGFC DLICMGKJENE, float3 FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void DENJLOAOHMO(JPDMABGMGFC DLICMGKJENE, float3 FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float CDFMMMFNACG(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float MLCPPODLIBB(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void ADPCDKMPFAE(JPDMABGMGFC DLICMGKJENE, float FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IFBLNCDIHKP(JPDMABGMGFC DLICMGKJENE, float FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode KDNCIPGLEIM(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CCHBKAJIIEO(JPDMABGMGFC DLICMGKJENE, CollisionDetectionMode FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(Slot = "25")]
	MMEGJHMINAN EJAEFPBFGIM(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void HFAIMKJDGIL(JPDMABGMGFC DLICMGKJENE, MMEGJHMINAN FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool BLHFLKKMGCN(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void JJLPPDALADE(JPDMABGMGFC DLICMGKJENE, bool FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(Slot = "29")]
	JPDMABGMGFC AFFGEPDHNLC(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void JHIOGIBHLNG(JPDMABGMGFC DLICMGKJENE, JPDMABGMGFC FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(Slot = "31")]
	JPDMABGMGFC KHLABIBIDLF(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void MBGDBGDPEAA(JPDMABGMGFC DLICMGKJENE, JPDMABGMGFC FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(Slot = "33")]
	DJKEJGBLBEI FOBPEIKHGHP(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void HGDIPLEMHLG(JPDMABGMGFC DLICMGKJENE, DJKEJGBLBEI PNGGNDMGCFO);

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool DKICOPCBCDE(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void FNPABGBALMD(JPDMABGMGFC DLICMGKJENE, bool FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool DNKANMGCJLD(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void AEBKEJHEMNO(JPDMABGMGFC DLICMGKJENE, bool FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints MOIINEGCNLM(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void CHAPPKNPJNB(JPDMABGMGFC DLICMGKJENE, RigidbodyConstraints FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float PKCGJKDMMHK(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void EBDIKKNPLDL(JPDMABGMGFC DLICMGKJENE, float FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float FLBKJDHGEII(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void JPHGBGFCCLM(JPDMABGMGFC DLICMGKJENE, float FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool OFMIAPFJNJI(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void OMNCLPDLIIH(JPDMABGMGFC DLICMGKJENE, bool FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool FABDKHMAMAO(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void EFJEGFOJKFL(JPDMABGMGFC DLICMGKJENE, bool FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void BKBEJNDPMGA(JPDMABGMGFC DLICMGKJENE, int FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(Slot = "50")]
	GMILAJLHIHL FBNBCNDGKLI(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void HJIBIFKMIGE(JPDMABGMGFC DLICMGKJENE, GMILAJLHIHL FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(Slot = "52")]
	CAFAOJANFEB JLGMELLKJHO(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void JPBAPPGNCEA(JPDMABGMGFC DLICMGKJENE, CAFAOJANFEB FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float PPCDHIENFNA(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void IBDNABIKHNC(JPDMABGMGFC DLICMGKJENE, float FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void HELKBFCCIEL(JPDMABGMGFC DLICMGKJENE, object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void KIEKLNOAJHA(JPDMABGMGFC DLICMGKJENE, object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool DMADBLEEIFO(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void KDBMOBEBLEI(JPDMABGMGFC DLICMGKJENE, object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void CJIJNHMMFGJ(JPDMABGMGFC DLICMGKJENE, object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool HAKGEGOAMCL(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool MGFMAJPHAEK(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody PLMHHNAEFLL(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void AMJJOKOFEON(JPDMABGMGFC DLICMGKJENE, Rigidbody JBKOGKCDDOF);

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void HMMOKBBCAPF(JPDMABGMGFC DLICMGKJENE, object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void OCGIEAAEOMB(JPDMABGMGFC DLICMGKJENE, object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool HLGMADCGOFE(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void DEPGGGJPJNG(JPDMABGMGFC DLICMGKJENE, float3 NCEIMCLGMCB);

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void DABIJPJMJCC(JPDMABGMGFC DLICMGKJENE, float3 EHALKHPCJIA);

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool PGJOFBDGIEF(JPDMABGMGFC DLICMGKJENE, [Out] float3 NCEIMCLGMCB);

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool NNKKCIGBPCJ(JPDMABGMGFC DLICMGKJENE, [Out] float3 EHALKHPCJIA);

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool MCNFPMEGDEH(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void POPKIEJEHME(JPDMABGMGFC DLICMGKJENE, object HNGIMMGBLII, bool DHIOOCFCCAJ);

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void CMBHEOCLHHJ(JPDMABGMGFC DLICMGKJENE, bool GPHAKCKEKCL);

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void JLCCHBIJPPO(JPDMABGMGFC DLICMGKJENE);

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool LJLFCJGBBNB(JPDMABGMGFC DLICMGKJENE);
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FFCGIAPFPOD
{
	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BPGJNLMFJAL(Entity PNIPEOHJGBO);

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KJLHBEKINCK(Entity PNIPEOHJGBO);

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EDADDKMKIHD(Entity PNIPEOHJGBO);
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CEDJNBNBJKO
{
	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KNHPJPEJGMG(JPDMABGMGFC LKEAKCADNOO, bool KFPNHAIFGGL);
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public delegate void LAADADMNPFA(NPONMLONMCA EBFPNFGJKKP);
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public readonly ref struct NPONMLONMCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly KBNDPJOLEPO BOFKEJFAOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly NativeArray<byte> GFHDKHCEGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly NativeArray<byte> AHOIBMBJKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly OBBAANPPIBD BJBANDBIGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly int ADOFPMGKCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly Type FKPJCFEPGDJ;

	[Cpp2IlInjected.Token(Token = "0x17000213")]
	public KBNDPJOLEPO LKCADKLLIFN
	{
		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x5672950", Offset = "0x5670F50", VA = "0x185672950")]
		get
		{
			return default(KBNDPJOLEPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000214")]
	public int LFBOMEJGMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x86475A0", Offset = "0x8645BA0", VA = "0x1886475A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000215")]
	public OBBAANPPIBD LPHPDCKDOKI
	{
		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0xAB3880", Offset = "0xAB1E80", VA = "0x180AB3880")]
		get
		{
			return default(OBBAANPPIBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x86475C0", Offset = "0x8645BC0", VA = "0x1886475C0")]
	public NPONMLONMCA(KBNDPJOLEPO BOFKEJFAOCE, NativeArray<byte> GFHDKHCEGAG, NativeArray<byte> AHOIBMBJKJO, OBBAANPPIBD BJBANDBIGLN, int ADOFPMGKCIE, Type FKPJCFEPGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x3F1DA30", Offset = "0x3F1C030", VA = "0x183F1DA30")]
	public NativeArray<T> HADEINJFOJH<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x3F1DA70", Offset = "0x3F1C070", VA = "0x183F1DA70")]
	public NativeArray<T> IIHBALPJKGJ<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x3F1DAB0", Offset = "0x3F1C0B0", VA = "0x183F1DAB0")]
	public (KBNDPJOLEPO, NativeArray<T>, NativeArray<T>) JLOHDPKHFGN<T>() where T : struct
	{
		return default((KBNDPJOLEPO, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x8647570", Offset = "0x8645B70", VA = "0x188647570")]
	public DBIANIHBEEN GCHKCDOCFKA()
	{
		return default(DBIANIHBEEN);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public interface EBNBJJHKEKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000216")]
	string IIJFLBCAGBI
	{
		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000217")]
	EBNBJJHKEKJ FBNHBGCODCH
	{
		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000218")]
	IEnumerable<EBNBJJHKEKJ> NFMANCEDENG
	{
		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface IKLADFCDFIO
{
	[Cpp2IlInjected.Token(Token = "0x17000219")]
	EBNBJJHKEKJ MMFCCLMBEMI
	{
		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700021A")]
	NativeArray<OBBAANPPIBD> LDLIAKIHMKD
	{
		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PBAPNALDFMO(OBBAANPPIBD BJBANDBIGLN, [Out] EBNBJJHKEKJ IJNDEDMJCID);

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CBPAAEAGBMC(OBBAANPPIBD BJBANDBIGLN, LAADADMNPFA NIDBPCGGJCI);

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EEAAOMNILHP(OBBAANPPIBD BJBANDBIGLN, LAADADMNPFA NIDBPCGGJCI);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PEOJDDIEDKM
{
	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBPAAEAGBMC(OBBAANPPIBD BJBANDBIGLN, LAADADMNPFA NIDBPCGGJCI);

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EEAAOMNILHP(OBBAANPPIBD BJBANDBIGLN, LAADADMNPFA NIDBPCGGJCI);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class GIELIBLGPCK
{
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NGDFNIKLJAF
{
	[Cpp2IlInjected.Token(Token = "0x1700021B")]
	bool JALEIAIIIOC
	{
		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700021C")]
	FPLNFGNNMON CKMGHHKHOAF
	{
		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ABJNHHBNFNL(JAIIIGOGONJ CBBPNNMFEHI, bool HDEMMBAEHEB);

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool COGFEGMIIKM(DFCAHNMFPEN CBBPNNMFEHI, OBBAANPPIBD BJBANDBIGLN);

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DKNOAGCLEHB(NativeArray<DFCAHNMFPEN> PLPODJNMGGF);
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class HCBHBJHCOGJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public readonly ref struct DBIANIHBEEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly NPONMLONMCA DAJAOHIJHHL;

	[Cpp2IlInjected.Token(Token = "0x1700021D")]
	public KBNDPJOLEPO LKCADKLLIFN
	{
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x5672950", Offset = "0x5670F50", VA = "0x185672950")]
		get
		{
			return default(KBNDPJOLEPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x8635670", Offset = "0x8633C70", VA = "0x188635670")]
	public DBIANIHBEEN(NPONMLONMCA DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x8635120", Offset = "0x8633720", VA = "0x188635120")]
	public KBNDPJOLEPO HADEINJFOJH()
	{
		return default(KBNDPJOLEPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x8635250", Offset = "0x8633850", VA = "0x188635250")]
	public KBNDPJOLEPO IIHBALPJKGJ()
	{
		return default(KBNDPJOLEPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x8635380", Offset = "0x8633980", VA = "0x188635380")]
	public (KBNDPJOLEPO, KBNDPJOLEPO, KBNDPJOLEPO) JLOHDPKHFGN()
	{
		return default((KBNDPJOLEPO, KBNDPJOLEPO, KBNDPJOLEPO));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public static class FNJHOBICCLG
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public readonly struct FPLNFGNNMON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly NativeBitArray AFHEGKBBANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly NativeParallelHashMap<DFCAHNMFPEN, int> HMMMIEBIPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly NativeParallelHashSet<JAIIIGOGONJ> JJNLOMPPOMH;

	[Cpp2IlInjected.Token(Token = "0x1700021E")]
	public bool BIAJJMECKPK
	{
		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x8639360", Offset = "0x8637960", VA = "0x188639360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021F")]
	public bool JALEIAIIIOC
	{
		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x8639140", Offset = "0x8637740", VA = "0x188639140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x62BF830", Offset = "0x62BDE30", VA = "0x1862BF830")]
	public FPLNFGNNMON(NativeBitArray AFHEGKBBANK, NativeParallelHashMap<DFCAHNMFPEN, int> HMMMIEBIPFN, NativeParallelHashSet<JAIIIGOGONJ> JJNLOMPPOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x8639170", Offset = "0x8637770", VA = "0x188639170")]
	public bool COGFEGMIIKM(DFCAHNMFPEN CBBPNNMFEHI, OBBAANPPIBD BJBANDBIGLN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LKMDPNOBCID
{
	[Cpp2IlInjected.Token(Token = "0x17000220")]
	HPNEHHPMAMF NCFDIGAMAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface BLACCFEAHOH
{
	[Cpp2IlInjected.Token(Token = "0x17000221")]
	int DHFLGPJKMMD
	{
		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000222")]
	int NDCGHJNMKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EHNGKFKGOHL(JPDMABGMGFC DLICMGKJENE, DJHKGJKFELM FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MOELEHFPCPE DIBCICMDGPB();
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BMLBEFCPPAN
{
	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PILEAPGEGPM(World JJBMFGJCFJD);

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PPLLAGBPKJL(World JJBMFGJCFJD);

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase MKCOFEFMODM(World JJBMFGJCFJD);

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PLAFPOPGHFP(World JJBMFGJCFJD);

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DFBLAKGEFAD(World JJBMFGJCFJD);

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JNLFCKLOBMI(World JJBMFGJCFJD);

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OBDHBBDIMLJ(World JJBMFGJCFJD);

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> BGPACMDALIH();
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ECPFBPCHFNL
{
	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHILDKOINMF(JPDMABGMGFC IEIKHLNDANP, bool FKMNCAKIOFK);
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public readonly struct OMIHENNPPEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly IEnumerable<LDIGPPKFMJB> FAJNOCIIJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly IReadOnlyList<GameObject> ABAEEJDBLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly IReadOnlyList<int> PIGCBJAKIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly IReadOnlyList<(DFCAHNMFPEN, DFCAHNMFPEN)> HEPAIIPONIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly int JKLDFMFHDNE;
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public struct CGEBINJEICH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public InventionIdData JIEJOKBHEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public InventionInstanceIdData KGJPNPGPIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public bool DEKBECPDKNG;

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x8633EA0", Offset = "0x86324A0", VA = "0x188633EA0")]
	public CGEBINJEICH(long JIEJOKBHEMF, Guid KGJPNPGPIKM, bool DEKBECPDKNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
[ServiceLifetime(Lifetime.Application)]
public interface EKCLPIHHFHM
{
	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BLHKDPCKPPH DGLHEIPHMOJ(CNNNEKPIBJG PGNLGGKNNAO, int KCJJLNAHDKI = 0, bool JNOJAGGIGPF = false);

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EECBFEGMEIG DDGOJEFPOIM(CNNNEKPIBJG PGNLGGKNNAO, JPDMABGMGFC IGDHFGFJBMG, [In] UniformTRS OIPBMOFHCCO, DCALFBJILMO EOCMAHGKNJE, [Optional] CGEBINJEICH NMMNNMDFLPK, bool BIPGFGIPIBM = true, bool AIGCGPGBNJC = false, bool JNOJAGGIGPF = false, bool LOBLDFELNLP = false);

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NGJONMHKJMO JAFPAODHIFM();

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NGJONMHKJMO NIOBOOEFNLD(KBNDPJOLEPO JGHIMEJLIML, [In] UniformTRS ICPGCPALDJB, [Optional] DCALFBJILMO ODLOPKMHGGD);

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PPDPJMPLALM(JPDMABGMGFC PCPECBCMDHI);

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IHFHOHKFMHF(JPDMABGMGFC PCPECBCMDHI, [Out] Exception MEEGIIKCBDI);

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<DFCAHNMFPEN> HDDELNONFFG(JPDMABGMGFC PCPECBCMDHI, Allocator EKNOCGFFMAE);

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeArray<DFCAHNMFPEN> HFJDPKPBGCJ(JPDMABGMGFC PCPECBCMDHI, Allocator EKNOCGFFMAE);

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KBNDPJOLEPO NADCODEANDB(JPDMABGMGFC PCPECBCMDHI, Allocator EKNOCGFFMAE);

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KBNDPJOLEPO NBDAONDPEBK(JPDMABGMGFC PCPECBCMDHI, Allocator EKNOCGFFMAE);

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KBNDPJOLEPO BHLDBJCCBFI(JPDMABGMGFC PCPECBCMDHI, Allocator EKNOCGFFMAE);

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> FHFMGGKHCPM(JPDMABGMGFC PCPECBCMDHI, Allocator EKNOCGFFMAE);

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NKIAMANOANG(JPDMABGMGFC PCPECBCMDHI);

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int AFDBHMGKHIM(JPDMABGMGFC PCPECBCMDHI, int FEEKNNBMJMM);
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[ServiceLifetime(Lifetime.Application)]
public interface KHKDPIBCEIO
{
	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0xF70EF0", Offset = "0xF6F4F0", VA = "0x180F70EF0", Slot = "0")]
	bool ABLHAGFIIDN(object KJOIOABMAMH, EAJHCAPHDEM DDEFJBAICMI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public static class NDEEMNDOEBM
{
	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x8646F80", Offset = "0x8645580", VA = "0x188646F80")]
	public static bool ABLHAGFIIDN(this KHKDPIBCEIO PDGKOFDJCFH, object KJOIOABMAMH, [Out] EAJHCAPHDEM DDEFJBAICMI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public enum KNHBNELFKAK : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	MaxPlayers = byte.MaxValue,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	IsVisible = 254,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	IsOpen = 253,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	PlayerCount = 252,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Removed = 251,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	PropsListedInLobby = 250,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	CleanupCacheOnLeave = 249,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	MasterClientId = 248,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	ExpectedUsers = 247,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	PlayerTtl = 246,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	EmptyRoomTtl = 245,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	HasDedicatedMaster = 87
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public interface EAJHCAPHDEM
{
	[Cpp2IlInjected.Token(Token = "0x17000223")]
	BGMNBFIFPOB MONFNOPPPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000224")]
	NAPCGDBANAF APDIKMDHFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000225")]
	bool AAHCFOKAHMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000226")]
	bool DDKHPIJOKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object ECACAOJHGKN();

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x10DAEC0", Offset = "0x10D94C0", VA = "0x1810DAEC0", Slot = "5")]
	(NAPCGDBANAF, object) KFLMJNKILPP()
	{
		return default((NAPCGDBANAF, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "6")]
	(DFCAHNMFPEN, NAPCGDBANAF) NLJINKBCFDJ()
	{
		return default((DFCAHNMFPEN, NAPCGDBANAF));
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "7")]
	JHHNOACDLEC<(DFCAHNMFPEN, NAPCGDBANAF)> FLFJJJPHOPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x10DAEC0", Offset = "0x10D94C0", VA = "0x1810DAEC0", Slot = "8")]
	(GNAHHGJHLEP, byte[]) KPDDOHIDBLM()
	{
		return default((GNAHHGJHLEP, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x10DAEC0", Offset = "0x10D94C0", VA = "0x1810DAEC0", Slot = "9")]
	(EDIKLMECBPD, byte[]) CPLCMDDCEOE()
	{
		return default((EDIKLMECBPD, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x10DAEC0", Offset = "0x10D94C0", VA = "0x1810DAEC0", Slot = "10")]
	T BPHAABJLGCF<T>()
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public static class BCPGCPNAPLL
{
	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x8632BB0", Offset = "0x86311B0", VA = "0x188632BB0")]
	public static bool EPFCHAPBFBO(this EAJHCAPHDEM KMDFLMLKEEC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public interface MDNFOJALDGH : JHHNOACDLEC<HINBANPDLCM>
{
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[DefaultMember("Item")]
public interface JHHNOACDLEC<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000227")]
	T BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000228")]
	int LFBOMEJGMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public enum BGMNBFIFPOB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	BulkInstantiate = 1,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	BulkDestroy = 2,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	OMSendPacket = 4,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	RR_OutOfBandMessage = 5,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	RR_FastForwardMarker = 6,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	RR_SelfJoinMarker = 7,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	RR_DebugOp = 10,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	RR_CachedEvent = 11,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	RRRoomRequestEvent = 20,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	RRRoomRequestFailedResponseEvent = 21,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	RRBufferedRoomEvent = 22,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	RRClearBufferedRoomEvent = 23,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	RR_CreationOp = 24,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	RR_CreationOpResponse = 25,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	RR_CreationOp_Unchecked = 26,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	RR_MasterLockBlockComplete = 27,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	RR_NetworkSynchronization = 28,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	RR_NetworkInstantiate = 29,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	RR_BulkInstantiate = 31,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	RR_Destroy = 32,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	RR_BulkDestroy = 33,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	RR_TransferOwnership = 34,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	RR_OwnershipUpdate = 35,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	RR_RPC = 36,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	RR_JoinRequest = 100,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	RR_JoinResponse = 101,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	RR_RoomUpdate = 102,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	RR_PlayerUpdate = 103,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	RR_RemotePlayerJoined = 104,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	RR_RemotePlayerLeft = 105,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	RR_Leave = 106,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	RPC = 200,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	SendSerialize = 201,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Instantiation = 202,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	CloseConnection = 203,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	Destroy = 204,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	RemoveCachedRPCs = 205,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	SendSerializeReliable = 206,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	DestroyPlayer = 207,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	OwnershipRequest = 209,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	OwnershipTransfer = 210,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	VacantViewIds = 211,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	OwnershipUpdate = 212,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	AuthEvent = 223,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	LobbyStats = 224,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	AppStats = 226,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Match = 227,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	QueueState = 228,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	GameListUpdate = 229,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	GameList = 230,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	CacheSliceChanged = 250,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	ErrorInfo = 251,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	PropertiesChanged = 253,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	Leave = 254,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	Join = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public enum GNAHHGJHLEP : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	None = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	NetworkTransformInitializationData = 1314146628u,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	RestoreCreationData = 1380140064u,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	OldestCachedPacketId = 1329811529u,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	SnapshotPublished = 1397773634u,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	SnapshotPayload = 1397771332u,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	SnapshotClear = 1129337683u
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public static class JBEOKKFNNOE
{
	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x863D720", Offset = "0x863BD20", VA = "0x18863D720")]
	public static DFCAHNMFPEN OCJDPECMNMB(this KMNJDLGPFLI DAJAOHIJHHL)
	{
		return default(DFCAHNMFPEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x863D6D0", Offset = "0x863BCD0", VA = "0x18863D6D0")]
	public static DFCAHNMFPEN MPOFLMKLKFC([In] this KMNJDLGPFLI DAJAOHIJHHL)
	{
		return default(DFCAHNMFPEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x85B9380", Offset = "0x85B7980", VA = "0x1885B9380")]
	public static DFCAHNMFPEN AECPEGHLMBN(this KMNJDLGPFLI DAJAOHIJHHL)
	{
		return default(DFCAHNMFPEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x85B9380", Offset = "0x85B7980", VA = "0x1885B9380")]
	public static ViewId PIGPOOOJBEJ(this KMNJDLGPFLI DAJAOHIJHHL)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x863D470", Offset = "0x863BA70", VA = "0x18863D470")]
	public static FixedString64Bytes JPHPDCNCODP(this JAIIIGOGONJ JIEJOKBHEMF)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x863D760", Offset = "0x863BD60", VA = "0x18863D760")]
	public static FixedString64Bytes PJINGEAOBNI(this DFCAHNMFPEN JIEJOKBHEMF)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x863D640", Offset = "0x863BC40", VA = "0x18863D640")]
	public static FixedString32Bytes JPHPDCNCODP(this Entity COIPJNEHPIG)
	{
		return default(FixedString32Bytes);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HCNJGGLMGEL : GNPEAAGOCDM
{
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public enum GEKCILJENJH
{
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	End,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GDMBHKAFGNG
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<object> GDMKCFBGPDB;

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "2")]
	void FPPHJOGKMFM(object KJOIOABMAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "3")]
	void CBJBGJCOOIN(EDIKLMECBPD LBHNPIBFMBH, ReadOnlySpan<byte> KMJEOGEJMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	void IPMACIIPPKI(GNAHHGJHLEP EHLAHNIAPLD, ReadOnlySpan<byte> KMJEOGEJMHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MOPDAILJFNC
{
	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EDIKLMECBPD EOFHJKDIBJH(ReadOnlySpan<byte> KMJEOGEJMHB);
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JDABOHMACFB
{
	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DLFNHJGPKGD(EDIKLMECBPD HFLDIIIPBCG, ReadOnlySpan<byte> KMJEOGEJMHB);

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NPFHFOCFIDD(ReadOnlySpan<EDIKLMECBPD> JCJKPDOHPFN);
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public struct POCGPCJEBJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public EDIKLMECBPD LBHNPIBFMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public ReadOnlyMemory<byte> KMJEOGEJMHB;
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public struct EDIKLMECBPD
{
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public static EDIKLMECBPD EJFFGKOGMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public JAIIIGOGONJ FDKJEEOLCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public int NHOGKABMBIF;

	[Cpp2IlInjected.Token(Token = "0x17000229")]
	public static JAIIIGOGONJ EMAPGGKNLHG
	{
		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x8636610", Offset = "0x8634C10", VA = "0x188636610")]
		get
		{
			return default(JAIIIGOGONJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x5682400", Offset = "0x5680A00", VA = "0x185682400")]
	public EDIKLMECBPD(JAIIIGOGONJ FDKJEEOLCHJ, int NHOGKABMBIF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x86367E0", Offset = "0x8634DE0", VA = "0x1886367E0")]
	public static bool LMIMJGGKHMP([In] EDIKLMECBPD KNPHEACNGDK, [In] EDIKLMECBPD IMDBLBCMEAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x8636670", Offset = "0x8634C70", VA = "0x188636670", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x8636780", Offset = "0x8634D80", VA = "0x188636780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x8636870", Offset = "0x8634E70", VA = "0x188636870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x8636660", Offset = "0x8634C60", VA = "0x188636660")]
	public void BHACFNDCJGJ([Out] JAIIIGOGONJ AFJLFPJABFP, [Out] int NHOGKABMBIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public static class NBIIMBOJKMI
{
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public struct LDIGPPKFMJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public Guid CLPJLOJHBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public string MAIHBFHEECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public Vector3 AANGPKCDGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public Quaternion NEOIPHFFLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public Vector3 ILFCOODFNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public int AKJOIHBOOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public DDNEFPADLOB MHCCEBNBPPI;

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x8641E80", Offset = "0x8640480", VA = "0x188641E80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public enum CENNECEHGLC
{
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	Scene,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	SubgraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	SubgraphRestore,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	RestoreCreationData,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	InventionPreview
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public static class OOLDOMCKEAO
{
	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x86493B0", Offset = "0x86479B0", VA = "0x1886493B0")]
	public static bool FLNJFKFLCEH(this CENNECEHGLC EHLAHNIAPLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x86493A0", Offset = "0x86479A0", VA = "0x1886493A0")]
	public static bool APJGDEMMBDD(this CENNECEHGLC EHLAHNIAPLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x86493D0", Offset = "0x86479D0", VA = "0x1886493D0")]
	public static bool KMCGDDLBNPK(this CENNECEHGLC EHLAHNIAPLD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
[Flags]
public enum JOIHKMJMDOD
{
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	WorldPhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	AdditivePhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public interface DCALFBJILMO
{
	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PDBDANDGHKD([In] Guid JHGKHIGHBBL, [Out] Guid BDHPLBBJNMG);
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
[Flags]
public enum BEPBFMDHIDE
{
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public interface NGJONMHKJMO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700022A")]
	CFMBCIJODAF ECPLFDOOOJL
	{
		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString DHENAAIBBHJ();
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public enum HMHJIMAGINJ
{
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
[TypeManager.ForcedStableTypeHash(8944033191217631913uL)]
public struct GACNLMEAPEF : ISystemStateComponentData, IComponentData, IEquatable<GACNLMEAPEF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public float3 KOPJEFOFJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public float3 CMHDCGJCFIE;

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x8639380", Offset = "0x8637980", VA = "0x188639380", Slot = "4")]
	public bool Equals(GACNLMEAPEF IBCMCOKAJEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OOHNHOIMFOH
{
	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ReadOnlySpan<JPDMABGMGFC> FHPPGAKEJJI(JPDMABGMGFC OBLNGAJKDPB);

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ELNNKJGBHED(JPDMABGMGFC HMKNMBOHIJI, [Out] JPDMABGMGFC CMCENLMPKHD);
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ALOONHAOJKC
{
	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EANHOOEBGGK(long CBEPDHCCOGN);

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APOHJFLEJHH(NativeParallelHashSet<long> NLGNHFAIHJP);

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NLGLHFGHNJN(World JJBMFGJCFJD, NativeParallelHashMap<Guid, long> OIBPGNPICBF);

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OHDKJOBGFPD(DFCAHNMFPEN CBBPNNMFEHI);

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OLCGDEMEOOB(DFCAHNMFPEN CBBPNNMFEHI, [Out] Guid ELEFAKNGDKI, [Out] long CBEPDHCCOGN);

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IAAGJBFGBHI(DFCAHNMFPEN CBBPNNMFEHI, Guid ELEFAKNGDKI, long CBEPDHCCOGN);

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool INNODECNJLL(Guid ELEFAKNGDKI);

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool NOLLBKFPMGM(Guid ELEFAKNGDKI, [Out] int ILJKPKDBDGP, [Out] int BDKGCKMNLCO);

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GHAIDLLFEEH(Guid ELEFAKNGDKI, int ILJKPKDBDGP, int BDKGCKMNLCO);

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PKMNOPNHECA(Guid ELEFAKNGDKI);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class CMLEPANJLDE
{
	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public CMLEPANJLDE()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
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
