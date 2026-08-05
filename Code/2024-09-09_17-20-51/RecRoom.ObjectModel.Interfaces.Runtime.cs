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
	public class LogRegistrationIndex : NDHLMBGDHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3260", Offset = "0x6CB1C60", VA = "0x186CB3260", Slot = "4")]
		public override void FBIMIMMHNIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class COFOILOHIDL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9EB0", Offset = "0x6CA88B0", VA = "0x186CA9EB0")]
	public static void LCKIELNHFIF(this Rigidbody KILNAAKBJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6CAA030", Offset = "0x6CA8A30", VA = "0x186CAA030")]
	public static void LCKIELNHFIF(this Rigidbody KILNAAKBJGO, Vector3 DOKGAHBECAK, Quaternion PEAAMJLAGCI, Vector3 IICJEDLPLPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct ECKJADHBOIC : IReadOnlyList<LBMKHNNNCPK>, IEnumerable<LBMKHNNNCPK>, IEnumerable, IReadOnlyCollection<LBMKHNNNCPK>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct PEEDAHBDHDM : IEnumerator<LBMKHNNNCPK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly MIKMJLGOEBN MGHIMHACJJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator BJLCJBDKLFF;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LBMKHNNNCPK EEAPHIFBJLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6CB73C0", Offset = "0x6CB5DC0", VA = "0x186CB73C0", Slot = "4")]
			get
			{
				return default(LBMKHNNNCPK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6CB7340", Offset = "0x6CB5D40", VA = "0x186CB7340", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x446E370", Offset = "0x446CD70", VA = "0x18446E370")]
		public PEEDAHBDHDM(MIKMJLGOEBN MGHIMHACJJP, NativeArray<LocalId>.Enumerator BJLCJBDKLFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7280", Offset = "0x6CB5C80", VA = "0x186CB7280", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6CB72C0", Offset = "0x6CB5CC0", VA = "0x186CB72C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7300", Offset = "0x6CB5D00", VA = "0x186CB7300", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly MIKMJLGOEBN MGHIMHACJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> AOFJCLOAGBF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public LBMKHNNNCPK BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6CAAD50", Offset = "0x6CA9750", VA = "0x186CAAD50", Slot = "4")]
		get
		{
			return default(LBMKHNNNCPK);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA750", Offset = "0x6CA9150", VA = "0x186CAA750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int CMJANHEPHCD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public MIKMJLGOEBN JACABIFDODA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NBHPLECAMHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool DOLICCCNJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA710", Offset = "0x6CA9110", VA = "0x186CAA710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> ABEJMKMJCLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x26F5940", Offset = "0x26F4340", VA = "0x1826F5940")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> OCADMJNNBCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA850", Offset = "0x6CA9250", VA = "0x186CAA850")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6CAACC0", Offset = "0x6CA96C0", VA = "0x186CAACC0")]
	public ECKJADHBOIC(int PAODLCPDLEP, MIKMJLGOEBN MGHIMHACJJP, Allocator MPFEIGMBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x446DE00", Offset = "0x446C800", VA = "0x18446DE00")]
	public ECKJADHBOIC(MIKMJLGOEBN MGHIMHACJJP, NativeArray<LocalId> AOFJCLOAGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6CAAC50", Offset = "0x6CA9650", VA = "0x186CAAC50")]
	internal ECKJADHBOIC(MIKMJLGOEBN MGHIMHACJJP, NativeArray<Entity> NLHOBFOIDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6CAAB00", Offset = "0x6CA9500", VA = "0x186CAAB00")]
	public ECKJADHBOIC(MIKMJLGOEBN MGHIMHACJJP, int CGDCIDKGGML, Allocator MPFEIGMBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6CAABA0", Offset = "0x6CA95A0", VA = "0x186CAABA0")]
	public ECKJADHBOIC(ECKJADHBOIC LFDLOEOKGKB, Allocator MPFEIGMBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6CAA7A0", Offset = "0x6CA91A0", VA = "0x186CAA7A0")]
	public ECKJADHBOIC LGMKCBFJFDH(Allocator MPFEIGMBFCP = Allocator.Temp)
	{
		return default(ECKJADHBOIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6CAA6D0", Offset = "0x6CA90D0", VA = "0x186CAA6D0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6CAA8B0", Offset = "0x6CA92B0", VA = "0x186CAA8B0")]
	public PEEDAHBDHDM PBHEMGCNMMA()
	{
		return default(PEEDAHBDHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6CAA940", Offset = "0x6CA9340", VA = "0x186CAA940", Slot = "6")]
	private IEnumerator<LBMKHNNNCPK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6CAAA20", Offset = "0x6CA9420", VA = "0x186CAAA20", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public struct FIGOJKPGIIP : IList<LBMKHNNNCPK>, ICollection<LBMKHNNNCPK>, IEnumerable<LBMKHNNNCPK>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct GNDICJIDBEP : IEnumerator<LBMKHNNNCPK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly MIKMJLGOEBN MGHIMHACJJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator BJLCJBDKLFF;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LBMKHNNNCPK EEAPHIFBJLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6CAD460", Offset = "0x6CABE60", VA = "0x186CAD460", Slot = "4")]
			get
			{
				return default(LBMKHNNNCPK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6CAD3E0", Offset = "0x6CABDE0", VA = "0x186CAD3E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x446E370", Offset = "0x446CD70", VA = "0x18446E370")]
		public GNDICJIDBEP(MIKMJLGOEBN MGHIMHACJJP, NativeArray<LocalId>.Enumerator BJLCJBDKLFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD320", Offset = "0x6CABD20", VA = "0x186CAD320", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD360", Offset = "0x6CABD60", VA = "0x186CAD360", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD3A0", Offset = "0x6CABDA0", VA = "0x186CAD3A0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MIKMJLGOEBN MGHIMHACJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> AOFJCLOAGBF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public LBMKHNNNCPK BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD170", Offset = "0x6CABB70", VA = "0x186CAD170", Slot = "4")]
		get
		{
			return default(LBMKHNNNCPK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD1F0", Offset = "0x6CABBF0", VA = "0x186CAD1F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6CACAE0", Offset = "0x6CAB4E0", VA = "0x186CACAE0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int NBHPLECAMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6CACAE0", Offset = "0x6CAB4E0", VA = "0x186CACAE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool MEAEOHJNNNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6CACFD0", Offset = "0x6CAB9D0", VA = "0x186CACFD0")]
	public FIGOJKPGIIP(int PAODLCPDLEP, MIKMJLGOEBN MGHIMHACJJP, Allocator MPFEIGMBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD0F0", Offset = "0x6CABAF0", VA = "0x186CAD0F0")]
	public FIGOJKPGIIP(MIKMJLGOEBN MGHIMHACJJP, Allocator MPFEIGMBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD060", Offset = "0x6CABA60", VA = "0x186CAD060")]
	public FIGOJKPGIIP(MIKMJLGOEBN MGHIMHACJJP, int CGDCIDKGGML, Allocator MPFEIGMBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6CAC800", Offset = "0x6CAB200", VA = "0x186CAC800")]
	public ECKJADHBOIC CHCCHDKPLEN()
	{
		return default(ECKJADHBOIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6CAC880", Offset = "0x6CAB280", VA = "0x186CAC880", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6CAC8C0", Offset = "0x6CAB2C0", VA = "0x186CAC8C0", Slot = "13")]
	public bool Contains(LBMKHNNNCPK LHFGBAJKEKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6CAC950", Offset = "0x6CAB350", VA = "0x186CAC950", Slot = "14")]
	public void CopyTo(LBMKHNNNCPK[] FEMJEOMOEIN, int CFALBIKCKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6CAC780", Offset = "0x6CAB180", VA = "0x186CAC780", Slot = "11")]
	public void Add(LBMKHNNNCPK LHFGBAJKEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6CACBB0", Offset = "0x6CAB5B0", VA = "0x186CACBB0", Slot = "7")]
	public void Insert(int ENMILGHAHOM, LBMKHNNNCPK LHFGBAJKEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6CACD40", Offset = "0x6CAB740", VA = "0x186CACD40", Slot = "15")]
	public bool Remove(LBMKHNNNCPK LHFGBAJKEKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6CACB20", Offset = "0x6CAB520", VA = "0x186CACB20", Slot = "6")]
	public int IndexOf(LBMKHNNNCPK LHFGBAJKEKO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6CACCF0", Offset = "0x6CAB6F0", VA = "0x186CACCF0", Slot = "8")]
	public void RemoveAt(int ENMILGHAHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6CACAA0", Offset = "0x6CAB4A0", VA = "0x186CACAA0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6CACC60", Offset = "0x6CAB660", VA = "0x186CACC60")]
	public GNDICJIDBEP PBHEMGCNMMA()
	{
		return default(GNDICJIDBEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6CACE10", Offset = "0x6CAB810", VA = "0x186CACE10", Slot = "16")]
	private IEnumerator<LBMKHNNNCPK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6CACEF0", Offset = "0x6CAB8F0", VA = "0x186CACEF0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IPFNJFKBKOP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int OBCNGBMJPFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> OLLDEJGNOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LBMKHNNNCPK IIGHBDNNFDH(LBMKHNNNCPK AOFJCLOAGBF);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FJAEMGBDHPL : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface FPHKIFBPDPF : AOGGJPAHCIF, KNKBCNKBMPM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool LOJKAIEMICI
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	MIEMBEBKOCM LBODAKPHOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	LLLDEEECIJF NEGNKNJNNEA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	FIFFNHJNCCK MBMKGLOPNPC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	AEPMPJBOJMJ CCBBGFHNMMI
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface KNKBCNKBMPM
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool LPLMCBCEJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface MEIPLAONPPK
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIDLDGKODNM(bool IPHMAHBENGI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[BDNMHMNCMLI(DACEBDJEIDP.PhotonRoom)]
public interface IECPFAGNLFN
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool LNCPEHGCGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MOFJPPKEHJF(bool PBBOCFHFMJC);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMEMBPNJAKP();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FNHBMDIJHNI(ByteString INKPEPIELNA);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LDOEDLEOAPB();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AKFEDAMBENI();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EJLLOBECKFO();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KOIADBKJGCH();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OMAHJKCMOJP();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface FIFFNHJNCCK
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	BEMAECNLOEH LBODAKPHOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	LLLDEEECIJF NEGNKNJNNEA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	CABHEBNIFLN MEOELIIGJDA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	ALAKNGJHMBC JCAGCBMCHAF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	FPHKIFBPDPF IBPMPKEPKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	IECPFAGNLFN FKNLFEKCKHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	MIKMJLGOEBN JACABIFDODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	LMKIIMOLCHA FCJKIIMGIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	JFDKBKANKAF HCHKOPDOLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	KFFACANDNPF BEEIKJADMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	HIKCCMEIIFO IFPOCIOGBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	PDBGALDEFLB CAGFMHMOHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	OIIFCDGJLKK MAMBPEKILAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	HMMGCDHAEBI OGKBHCNCIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	ODNMACJAAPN LPECMMDJLIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	NDNEJDNIKAA PKGEDOPEFDF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	POFICOKCLNC ELCJOKBCFKA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	CGJEBAEAPGL FNMGDPFIGJO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	KHHOHOFHBIL ALCPJIBOBNP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	GLCEODGDPDJ AEONHNGJCMG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	KPIONGHDHCI EADNFHAIMLN
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	PADLCAJDGFM EGEKACOCEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	MEJIJLAAPOH JILIAIPGEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	OJMIDDPILBF BJOPOJDFBHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	FIEKMEKJLHL NALJEDPHEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	PPCBPBEGNBC JEBHKGEALOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	KLFKGMMIEHM MFFIFBMAOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	BGJLPGJHEDM CAJIHMNGKJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	NKGMMLAHCIG MDOAPFMCOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DebuggerTypeProxy(typeof(NOHHKPLMNAB))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct LBMKHNNNCPK : IComparable<LBMKHNNNCPK>, IEquatable<LBMKHNNNCPK>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly LBMKHNNNCPK GOLLGDANENM;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int MGFONLAEHHP = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int ICCKCKCFKPB = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int EMCCNILHIIC = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int FLMGCCOABOC = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId GMEDGMJCEEO;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public MIKMJLGOEBN JACABIFDODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5F10", Offset = "0x6CA4910", VA = "0x186CA5F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public FPHKIFBPDPF IBPMPKEPKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6CB21E0", Offset = "0x6CB0BE0", VA = "0x186CB21E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public LocalId BGPOHFIGMJK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6CB2540", Offset = "0x6CB0F40", VA = "0x186CB2540")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal AEPMPJBOJMJ CCBBGFHNMMI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6CB2040", Offset = "0x6CB0A40", VA = "0x186CB2040")]
		get
		{
			return default(AEPMPJBOJMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool GHBEHEKGDOG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6CB2580", Offset = "0x6CB0F80", VA = "0x186CB2580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool MLFKMBBCOJM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6CB24F0", Offset = "0x6CB0EF0", VA = "0x186CB24F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6CB27D0", Offset = "0x6CB11D0", VA = "0x186CB27D0")]
	public LBMKHNNNCPK(MIKMJLGOEBN IJCKNHMONPM, LocalId GMEDGMJCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
	public NMHACHFNADO FHILNDBFKCD()
	{
		return default(NMHACHFNADO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2180", Offset = "0x6CB0B80", VA = "0x186CB2180")]
	public static LocalId DBMBPMAANBF(LBMKHNNNCPK HPICPJFOCMM)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2140", Offset = "0x6CB0B40", VA = "0x186CB2140")]
	public static Entity DBMBPMAANBF(LBMKHNNNCPK HPICPJFOCMM)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6CB23D0", Offset = "0x6CB0DD0", VA = "0x186CB23D0")]
	public static bool JGJOKBKMGBC(LBMKHNNNCPK KPNKONMDFPM, LBMKHNNNCPK NGNLLOFPDHF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6CB21C0", Offset = "0x6CB0BC0", VA = "0x186CB21C0")]
	public static bool DCLBGLCHDNG(LBMKHNNNCPK KPNKONMDFPM, LBMKHNNNCPK NGNLLOFPDHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6CB26A0", Offset = "0x6CB10A0", VA = "0x186CB26A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2240", Offset = "0x6CB0C40", VA = "0x186CB2240", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2050", Offset = "0x6CB0A50", VA = "0x186CB2050", Slot = "4")]
	public int CompareTo(LBMKHNNNCPK CGCLEIBHLHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "5")]
	public bool Equals(LBMKHNNNCPK CGCLEIBHLHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HJOMANJOMHL
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6CADD60", Offset = "0x6CAC760", VA = "0x186CADD60")]
	public static PPCIBOGOOFM EIAGHHJDOAM(this LBMKHNNNCPK FHFDEAHMMBI)
	{
		return default(PPCIBOGOOFM);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6CADE10", Offset = "0x6CAC810", VA = "0x186CADE10")]
	public static NMHACHFNADO IHJKEBCHIED(this LBMKHNNNCPK FHFDEAHMMBI)
	{
		return default(NMHACHFNADO);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2D82920", Offset = "0x2D81320", VA = "0x182D82920")]
	public static T PLMNALMPNEK<T>(this LBMKHNNNCPK FHFDEAHMMBI) where T : struct, FIALOONBIKB
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class NOHHKPLMNAB
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct AEPMPJBOJMJ : IEquatable<AEPMPJBOJMJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte DKMIJDPJCBM;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] MBFKMAJIOBB;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static MIKMJLGOEBN OOAOAAHEAPM;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static FPHKIFBPDPF JAHFGKKPMEK;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static MIKMJLGOEBN[] OCONLONAGPH;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static FPHKIFBPDPF[] LCPKJFADIII;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> JFPCAGIKAIH;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public FPHKIFBPDPF IBPMPKEPKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6CA4C90", Offset = "0x6CA3690", VA = "0x186CA4C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public MIKMJLGOEBN IGBDEJILGAP
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5750", Offset = "0x6CA4150", VA = "0x186CA5750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA58F0", Offset = "0x6CA42F0", VA = "0x186CA58F0")]
	static AEPMPJBOJMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2300B30", Offset = "0x22FF530", VA = "0x182300B30")]
	internal AEPMPJBOJMJ(byte IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7230", Offset = "0x5DF5C30", VA = "0x185DF7230", Slot = "4")]
	public bool Equals(AEPMPJBOJMJ CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4D70", Offset = "0x6CA3770", VA = "0x186CA4D70", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x9B4AB0", Offset = "0x9B34B0", VA = "0x1809B4AB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5830", Offset = "0x6CA4230", VA = "0x186CA5830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6CA56B0", Offset = "0x6CA40B0", VA = "0x186CA56B0")]
	private static MIKMJLGOEBN NABKFGIPCMO(byte DKMIJDPJCBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5610", Offset = "0x6CA4010", VA = "0x186CA5610")]
	private static FPHKIFBPDPF LMGNGJPAJAJ(byte DKMIJDPJCBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4B20", Offset = "0x6CA3520", VA = "0x186CA4B20")]
	private static object BICNDPGLELO(byte DKMIJDPJCBM, object[] KIAGDMGGGNM, object FABNMHPKJIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6CA50B0", Offset = "0x6CA3AB0", VA = "0x186CA50B0")]
	private static int GPPEDLBLNNN(byte DKMIJDPJCBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4B10", Offset = "0x6CA3510", VA = "0x186CA4B10")]
	private static int BCNLOINKNAD(byte DKMIJDPJCBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4A90", Offset = "0x6CA3490", VA = "0x186CA4A90")]
	private static (int, int) ADFBMEOJDJE(byte DKMIJDPJCBM)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4C80", Offset = "0x6CA3680", VA = "0x186CA4C80")]
	private static byte EFPDKDLKFAP(int MOOGIOAAOOM, int ENMILGHAHOM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4E10", Offset = "0x6CA3810", VA = "0x186CA4E10")]
	internal static AEPMPJBOJMJ FBIMIMMHNIB(FPHKIFBPDPF INDKBPJONOA, MIKMJLGOEBN DKOGOIOPAFN)
	{
		return default(AEPMPJBOJMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5420", Offset = "0x6CA3E20", VA = "0x186CA5420")]
	internal static void IFGBNDJNHBH(AEPMPJBOJMJ DKMIJDPJCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6CA50C0", Offset = "0x6CA3AC0", VA = "0x186CA50C0")]
	private static void HGLDNHMBNED(int PAODLCPDLEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface PPNPJGNJJML
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBJIHINFMFH();

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFFGBMEFDCO(bool MHMCLOPAIII);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IFHDBHEJIKO(GameObject BICFCMICGIH);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface IJDHNEKDPAF
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Guid PCODBICPGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EBCPNAFEAOJ(Guid BKFAMEGJCEJ, Guid HEPLADJNIKE, Guid ALMEMPEMACG);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task LNAPDLBKFNK(Guid BKFAMEGJCEJ, Guid[] MKENKKGAFLA, Guid ALMEMPEMACG);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid ECDADFBDHFP(Guid FAABINMBEKH);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task OMAIMFOKALM(LBMKHNNNCPK GJPDHAGHEPH);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EPMKMECNDAK(EHBJCKAPCDI ICKHICBFJOC, Guid FANHJPLHFPG);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EKOHKODHOLF(Guid FAABINMBEKH, bool PBBOCFHFMJC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface JPHNOHHLLLL
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFBDFPHEGDL(ECKJADHBOIC AOFJCLOAGBF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface JEJMHPKPLNP
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NKBMDCBOPPO(GameObject ONADAKNIAJM, GameObject GKFCBAIBHKI, int EPEPDOGEKHL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface LLLDEEECIJF
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	PPNPJGNJJML LDBJFFEEHGH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	IMBBNHJLAFH ILMCFLCNDGC
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	HMJEKHNFJKN NKBGEMLNMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	FGGFAFPOLPO EGHCLNHCBIK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	KGABFMCILEJ IMNOEACHEHF
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	DMNFBPMEMBE NIDJIOHMCFN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	LMCOMPPFNFC KIOKAEOHKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	GKLIJOPJHKD DDBBANMNLMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	EDBGPHECANK NACIIEBFBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	AEAMPNIPOMM JMKICNHOGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface IMBBNHJLAFH
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string DOPOPDONAGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface CHDEBCAAALA
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INLPNJAJCGJ(Action GGEEGOKOMKJ, bool EBNLFNKKJKH);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NANFOCHGLFK(string DDDMPLCOGIM);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int GGDBFJNBLOK(string DDDMPLCOGIM, int FABNMHPKJIP);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HNBMEBJCAOA([Out] bool IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EIMEDGALKDB([Out] bool IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GIHBKGCCHNH([Out] int IPHMAHBENGI);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface HMJEKHNFJKN
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string OIBNDENCHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] BLPIGGOONML(IEnumerable<BKLPFBJMBNM> ENBJOACEOJO, bool KEPHNMHEEAD);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NMAIDHFLLFL(GameObject BICFCMICGIH, [Out] PPCIBOGOOFM[] JFPHLGMDCNK);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FFOCGMEDFON(GameObject BICFCMICGIH, [Out] int NAJAKEHHACI, [Out] ADNGPIOLLLA NLMEGDEGAEA);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EHBJCKAPCDI EEKAGOGMNNP(BKLPFBJMBNM MGBHCKLJEHL);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EHBJCKAPCDI EEKAGOGMNNP(string JHNHANNFJPH, PPCIBOGOOFM[] OGPFJDHMIGP, Vector3 EJEBFMEPKGF, Quaternion PCIAHIPKDFG, Vector3 FCFDEHNOPJK);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EHBJCKAPCDI CPHKNBKJIDO(string JHNHANNFJPH, PPCIBOGOOFM[] OGPFJDHMIGP, Vector3 EJEBFMEPKGF, Quaternion PCIAHIPKDFG, Vector3 FCFDEHNOPJK);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject OGBMGOEHLJG(string JHNHANNFJPH);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HOMIIBBPMGD(GameObject MFBEODNDHIF, bool GJHDHJFGOFN);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FAMOOBCCKPH(GameObject BICFCMICGIH, bool MHONCFKGHAK, bool HCOPCLFLBGC);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class EJLDGIEFLCH
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB250", Offset = "0x6CA9C50", VA = "0x186CAB250")]
	public static EHBJCKAPCDI EEKAGOGMNNP(this HMJEKHNFJKN HILLMDJLLHN, Vector3 EJEBFMEPKGF, Quaternion PCIAHIPKDFG, Vector3 FCFDEHNOPJK, params PPCIBOGOOFM[] JFPHLGMDCNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB0F0", Offset = "0x6CA9AF0", VA = "0x186CAB0F0")]
	public static EHBJCKAPCDI CPHKNBKJIDO(this HMJEKHNFJKN HILLMDJLLHN, Vector3 EJEBFMEPKGF, Quaternion PCIAHIPKDFG, Vector3 FCFDEHNOPJK, params PPCIBOGOOFM[] JFPHLGMDCNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface FGGFAFPOLPO
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFDMENOGLMA(bool PBBOCFHFMJC);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface KGABFMCILEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool NCMGFGKEPCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool PDOKLFBKPDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool HBPEOCHKMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	int EEAJCMGJBOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool HFFGMDOANHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PDEDJLKFILJ(object HDOCILHNNDE);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NGOLDNJHGAG(object HDOCILHNNDE);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AFDHIGAOEFG(object CDHECNAFHCH);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OAGGFKDKDJA(object CDHECNAFHCH);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ViewId AMLCIJIHGPE(GameObject IHJCDAFDGLD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ODMIOOKDDKB(NativeArray<ViewId> MOJNFECFEHB);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MCKMKMGFFPN(NativeArray<ViewId> IINIAEMFBOC);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MLHBFPKAACN();

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NPLKHMNFFDL(uint JPCACEEEJLI, ReadOnlySpan<byte> AADNEFCBBPH, bool CCBCFLHHHLK = false);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NPLKHMNFFDL(uint JPCACEEEJLI, ReadOnlySpan<byte> AADNEFCBBPH, ReadOnlySpan<byte> AGLLHJJFEMF, bool CCBCFLHHHLK = false);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EAPICMILBEM(Func<int, bool, int> PPGKJLEHGJG, bool BKCFJCPKAII);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void POOKLFOMAHG(object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LAMHHIMKKEN(object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "18")]
	uint FBFGEKMKCHG(uint PFOPPCFDLPJ);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class HCBAPHDGBAG
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6CADBA0", Offset = "0x6CAC5A0", VA = "0x186CADBA0")]
	public static OCAAOEOGFLM NGJCFDDFHMD(this KGABFMCILEJ FGHAHIFNFEN, object OEELDHBFFAF)
	{
		return default(OCAAOEOGFLM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct OCAAOEOGFLM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private KGABFMCILEJ FGHAHIFNFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private object OEELDHBFFAF;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4D70", Offset = "0x6CB3770", VA = "0x186CB4D70")]
	public OCAAOEOGFLM(KGABFMCILEJ FGHAHIFNFEN, object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4D20", Offset = "0x6CB3720", VA = "0x186CB4D20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface DMNFBPMEMBE
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFACMEJHMID(GameObject BICFCMICGIH);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface LMCOMPPFNFC
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public struct HDFMMDKFJIH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private LMCOMPPFNFC OHJAONILCFG;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6CADC90", Offset = "0x6CAC690", VA = "0x186CADC90")]
		public HDFMMDKFJIH(LMCOMPPFNFC OHJAONILCFG, string BBDGOIMNDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6CADC30", Offset = "0x6CAC630", VA = "0x186CADC30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct HEAHMMKJMDI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private LMCOMPPFNFC OHJAONILCFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Task DJIALEEMCOO;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6CADD10", Offset = "0x6CAC710", VA = "0x186CADD10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFBHGFDJOKH(string BBDGOIMNDJI, float GLIHGPEPPCD = 5f);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MIEGHPLPJND();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CFNOEMPAKCK(bool EIMECBCGEBC, string BBDGOIMNDJI);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class MBEBMDDAELH
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3550", Offset = "0x6CB1F50", VA = "0x186CB3550")]
	public static LMCOMPPFNFC.HDFMMDKFJIH DHGHMKJHDIG(this LMCOMPPFNFC FGHAHIFNFEN, string BBDGOIMNDJI)
	{
		return default(LMCOMPPFNFC.HDFMMDKFJIH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface PFMLCEFJAFK
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PACAHJHNEOJ(GameObject BICFCMICGIH);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPFOLOBOFCM(GameObject BICFCMICGIH);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AOOHBHFLLDA(int ILBCHIFAEFG);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object BMHIEMODBMD(LBMKHNNNCPK GMEDGMJCEEO, GameObject BICFCMICGIH, Action<LBMKHNNNCPK, int> AGMLFHLAIFJ);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ANMFFGLNEHK(GameObject BICFCMICGIH, object GAEAHGCAAAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface OMAHEJNPCOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool MAAGOEKHMJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate DBMIEGHOCOA(HIBAGOJAADI.LKBJGBEGKBN DDFJIHBNOLF, Action<HIBAGOJAADI.LKBJGBEGKBN> AGMLFHLAIFJ);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JNNCNDBNOFO(HIBAGOJAADI.LKBJGBEGKBN DDFJIHBNOLF, Delegate AGMLFHLAIFJ);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate GHLLPMDCPFJ(HIBAGOJAADI.LKBJGBEGKBN DDFJIHBNOLF, Action<HIBAGOJAADI.LKBJGBEGKBN> KAKEACCMMJO);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BLJJJKPGHEC(HIBAGOJAADI.LKBJGBEGKBN DDFJIHBNOLF, Delegate AGMLFHLAIFJ);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GLJAGCBNLCF(HIBAGOJAADI.LKBJGBEGKBN DDFJIHBNOLF);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HIBAGOJAADI.LKBJGBEGKBN KIADKIBCOGM(GameObject BICFCMICGIH);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface GKLIJOPJHKD
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	int JKLAKNLKNBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	int ONOAJHDNGJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool PDOKLFBKPDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool AKBFCAJELLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int BAJCBKIJPOC(GameObject BICFCMICGIH);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BMHDDKBFJND([Out] Vector3 EJEBFMEPKGF);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PJEJIMOLLJJ();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LBMKHNNNCPK KLGOBKLPHLK(int ILBCHIFAEFG);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NIBOOLJNFLL();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface EDBGPHECANK
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool LNCPEHGCGPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface DHNPNIIAGDO
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	GAFDHANDCAD IFELMNHHJCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	KOEBEDLCMKN OABABJFLIHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IENGPMFLKIO(Transform ICGEMCDDICC);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LKAEGPLCLKH(Transform ICGEMCDDICC, AGNEHGOBOAO HAOFHDKCLJF);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IHGGIANIFHG(Transform ICGEMCDDICC, OHFCNPENGBB NNKPOGBBDGK);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface JNJLNDGLMFH
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface AEAMPNIPOMM
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NCFFOCHNKEG;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AOICNHKBDOH(ECKJADHBOIC GHNIFPJFEMJ, bool EIMECBCGEBC);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface CECIDPNBALJ
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ILHNKCBHOHF();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface BCDJCMNFJFE
{
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ADNGPIOLLLA NDJMJJNMFHC(GameObject IHJCDAFDGLD);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AIAOPDLOBIJ(GameObject BICFCMICGIH, NFCIMKIGCDM HDOADLHOKMO, LEAMHLPCKGF GICCBLOEBPD);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EBKMNIKOCCD(LBMKHNNNCPK GMEDGMJCEEO, bool LKIBIMMAHME, float3 MLPDOFHBEMJ, quaternion NFAICHEGKIE);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PKDGOCHALOO(NMHACHFNADO LKDGGBDDBJM, NMHACHFNADO CDHECNAFHCH, NAKOJNDAOID CJJFHMMBLHB);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AMONOPMGKIE(NMHACHFNADO LKDGGBDDBJM, NAKOJNDAOID CJJFHMMBLHB);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BPAAFBIMJJI(ECKJADHBOIC IEAACCGEKDH);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HBCDAOONIKM(ECKJADHBOIC MGHIMHACJJP, NativeArray<LocalPoseData> OJANNBLBOBG, NativeArray<float3> LKPENHEDKLM);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ABCKPIKGHNB(ECKJADHBOIC MGHIMHACJJP, ECKJADHBOIC HMCIIOALDCO);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KPLKKJDCHHD(ECKJADHBOIC MGHIMHACJJP, bool HGEHGIDIOLK);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GOLGKOJNKNO(ECKJADHBOIC MGHIMHACJJP, bool ONKEDFDOCJN);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct KJHEPLDCIDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly JHBBGMGIMHD ICLEKBDIINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly JHBBGMGIMHD BCIIGBDEKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint ICPKFILPPFB;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6CB1BE0", Offset = "0x6CB05E0", VA = "0x186CB1BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct LLLDHANDEBI
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal readonly KJHEPLDCIDG GGEEGOKOMKJ;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3140", Offset = "0x6CB1B40", VA = "0x186CB3140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct PMOGMBCBJAH
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal readonly KJHEPLDCIDG GGEEGOKOMKJ;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3140", Offset = "0x6CB1B40", VA = "0x186CB3140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct GBCJLJOPLFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal readonly uint ICPKFILPPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal readonly bool DLMIOLKKIAP;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD280", Offset = "0x6CABC80", VA = "0x186CAD280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct JHBBGMGIMHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal int EDCGGCHLNEI;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6CAEE10", Offset = "0x6CAD810", VA = "0x186CAEE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface OAFDJBFFMPM
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	MPAFKPJHOCH DDCLJNABADG
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public enum EEEGKFJGLJL
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
public interface EHBJCKAPCDI : DCGDCFKOLFG
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	EEEGKFJGLJL CJCBHMNDABM
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool FCOJFMEGKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	GameObject BICFCMICGIH
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<EHBJCKAPCDI> PMOJFLDEEML;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(CABHEBNIFLN OBOIAEHHCBI, LBMKHNNNCPK BEEOIKPJMCJ);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool EKABJIMNEAK);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class DHAOLIHAOEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6CAA5A0", Offset = "0x6CA8FA0", VA = "0x186CAA5A0")]
	public static bool GIPDPCDBIMP(this EHBJCKAPCDI GFOCHBOMMIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6CAA5F0", Offset = "0x6CA8FF0", VA = "0x186CAA5F0")]
	public static bool LEGFPACLGEC(this EHBJCKAPCDI GFOCHBOMMIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6CAA550", Offset = "0x6CA8F50", VA = "0x186CAA550")]
	public static bool DHOPOOHBNJL(this EHBJCKAPCDI GFOCHBOMMIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6CAA640", Offset = "0x6CA9040", VA = "0x186CAA640")]
	public static bool LOJKAIEMICI(this EHBJCKAPCDI GFOCHBOMMIG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface DCGDCFKOLFG
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool HACHFHFHEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	LBMKHNNNCPK AMOIIJBOOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface KDFGDLOCEMI
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate void OAPAAAJKPIO(CONJIDBLNCG IMOPJBAOHFD);

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event OAPAAAJKPIO OBBONOHKDOA;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface IGDLMCLKMAA
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HIOMBELFHDA(Vector3 EJEBFMEPKGF, Quaternion PCIAHIPKDFG, Vector3 FCFDEHNOPJK);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJPHAMCIKMD(LBMKHNNNCPK KMAENCDMJDN);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BBPHPJCCGCJ(bool PHCJCKHNKGA);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GMAEELCFJCD(bool ONKEDFDOCJN);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface MFGJMNBKMIF
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface BGEJNALFBIP
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(HFLALFLFNKL FKKFJJDIIFI);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface HFLALFLFNKL
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	GameObject BICFCMICGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	Transform ICGEMCDDICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	OBJADMFPMJH KPJIGPMNPPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool EPMDBPGJGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HFFIFHFBGOO(OBJADMFPMJH KCEPABIAINB);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface OBJADMFPMJH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	LBMKHNNNCPK AMOIIJBOOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	Rigidbody LMOODLOFANM
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	HFLALFLFNKL FIKFFPNBCDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	GameObject HIHCJEHCKAF
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Transform LFKJKOHKNFF
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	OBJADMFPMJH JEBILDNGPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	OBJADMFPMJH CHMOOKFGBDO
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	int NFJJMFLIFGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool GLJAGCBNLCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	bool FNNONNNMHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	EAEHANAOBNM AFBAAJPFHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "31")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	EFMMKCONAKN PNLCBHJMPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	float OBNECJIFDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "35")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 KNBHDMOLPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	Vector3 CJDIOLOJBLA
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 GMCDCOKFIIO
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Vector3 IHGLKAFHAJN
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool AFJEFEFBAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	bool PLAFMNFAGNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool JONIPFJBLPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 PPMHLINFJNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 KAKKDFCIPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Vector3 JIBEMDPOGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "50")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 NKHEICDPLAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	float CHFHCFNLOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float PDGNJGENKJI
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Vector3 HOBBFJCBPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Quaternion CMEBOEMNIOG
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	float FFGBNMGCNEK
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	float FMAENBBMKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool BNPFHDHMLKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	JGCAFIGAFFP JCGDEDNKJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool GGPDDMGENEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Transform FEAFHMIFNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	Vector3 MNAPKDBFHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	float BNGJEHMADBL
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	float PMNNJADHKDG
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Quaternion IHFEKLBPKFH
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Vector3 AIFDJMPCLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	Quaternion HCLPIOBIAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	RigidbodyConstraints LPECEDODPNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	bool ODFMFNHICOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	CollisionDetectionMode JENKMMFDLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	bool APKDHMBELGH
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event JIBAICMKDBF PLLJDLBDCIN;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event JIBAICMKDBF KAGPEGHHNBH;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event JIBAICMKDBF KNAHBFFHDDL;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event JIBAICMKDBF HIFBEIGFKHF;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event JIBAICMKDBF APDLPNCFNBK;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event JIBAICMKDBF HELFJJFGNFM;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event JIBAICMKDBF BGDEBCFEJKC;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event FMDFHEHDPPJ BNNFELKGANA;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<HDLBMLPIHPN, HDLBMLPIHPN> LNMNLFIDGAC;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "26")]
	OBJADMFPMJH LNHPKHIMEPL(int ENMILGHAHOM);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void DDGKNGAHJFL((Quaternion rot, Vector3 moments) KEAIEABHOPH);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void PNBEJFPEDIJ();

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void IDNHGDBOGIJ();

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void GCFKKEGNCDH();

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void OPABKONNCBM();

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void NJPHAMCIKMD(OBJADMFPMJH IPHMAHBENGI, bool NOCMPIEOFCP = false);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void DFNBBBAMPMM(object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void BAAGALPHEMH(object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 CCFOBGDNPCK(Vector3 MGCJLNPPEHB);

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "95")]
	Vector3 EFPIBHDKJHO(Vector3 KDBAABAMFFN);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void EKHIMMNIPEL();

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void JCANOFJDADK();

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void DHMAFDFHBIC();

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void GJMJHNCDPNG(Vector3 CMOABHDGOOA, Vector3 OFDEGDNPEGJ);

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void AABEDGLNCKP(Vector3 JJPPCHKBGCE, Vector3 NHLDMOEHBNF);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void HAHIILPKFJK(Vector3 KHPDDAPGGEM);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void CJPBHAPNMFG(KFHHPEHINFA IGPGKDFNPIE, Vector3 MKNOEHKBNIG, float BJFBGGPKGPA, float EFMCFCCKEMH = 8f, float JBMOFLKNCDP = 1f);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void OGPDFMKJDFI(HOBGLFAGAKH GGCOHIKNBGE, Vector3 FODDDPLGLIO, float GANNKOJAILG = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void GGKLLBBNOAC(HOBGLFAGAKH GGCOHIKNBGE, Vector3 PCIAHIPKDFG, float IBHPJNLNOPM = 7f, float PAOBAPJMBLG = 1f);

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "105")]
	Vector3 DFEHIKEOCCH(Vector3 IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "106")]
	Vector3 KHKLOIIMINK(Vector3 IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void FIPFFHLOCEL();

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void DBDOCPIAHDH(OBJADMFPMJH HBPBPEHMMEK, object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "109")]
	void CPFOJOCHHKB(object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void FJIFKEHOGFP();

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void JKFFMLHADFL();

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void LFBJHLBLBPF();

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "113")]
	bool MBKLFPKPOMA();

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void BIEJNIFKODB();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void HAOENGGNPGD(object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "116")]
	void KFILENDOGBD(object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void JIFDANPJPHH(object OEELDHBFFAF, bool GHLPIJPFEDO);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void NPNMAPDDIKF(Vector3 MMHKIDDFEKP, Quaternion NMANLJPNBHK);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void DIFGLEKFDDM(Vector3 JJPDKKMDNGG, Quaternion EKPDAGMGKPC);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "120")]
	bool MFGHFCBEFBK(float IBDBBIJPGDC);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void LCHCEDDLHNE(object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void LCIKPFAJPFD(object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void ONLCBPFAFMM(object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void CPBCCIHJINH(object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void OHFFLMGGOEE(Vector3 LCIPAAAOEPD, ForceMode COIAPCCPMKA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void CNBEAJFIEBH(Vector3 LCIPAAAOEPD, Vector3 EJEBFMEPKGF, ForceMode COIAPCCPMKA);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void AHEIBOGMLPO(Vector3 LPAGCBFLEJB, ForceMode COIAPCCPMKA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void NBGIFGNIIII(Vector3 LPAGCBFLEJB, ForceMode COIAPCCPMKA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "129")]
	bool LBJCAILECDJ(Vector3 FJODMBFILLK, [Out] RaycastHit NJKLEFHEHBB, float PEAKDEKJAOG);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void IDFHACHAABG();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface EFMMKCONAKN
{
	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNLHJNDGOPO(Vector3 JHBGIIGMEFE);

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPADHBJNFPF(Vector3 LJFEFIKHHHB);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NDCOFEHCGLJ(Vector3 JHBGIIGMEFE);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FCHCPOHCFEF(Vector3 LJFEFIKHHHB);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface EAEHANAOBNM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 CIEBEHAEGOO();

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 FCJAAOBIKII();
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public delegate void JIBAICMKDBF(HFLALFLFNKL HCBAFJHBDPP);
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum HDLACJBKHEG
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
public enum KFHHPEHINFA
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
public delegate void FMDFHEHDPPJ(HFLALFLFNKL HCBAFJHBDPP, bool NOCMPIEOFCP = false);
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum HOBGLFAGAKH
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct AIPJCHOFLBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Rigidbody ODEHBHJNBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public object LENOGFOLHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector3 JEJOBFHBDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector3 PCIJHHCOBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public DJFECCHKBLN KKELJBMGMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool APPHJCEKOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool CEFEMOANGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool DACFIAKHDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public bool DNDBBHMCEOA;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface FAKNFDNJNPG : OBCALFIHPEE<PPCIBOGOOFM>, ABECDDJBCHC, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface LKOHLEMEMPK<T> : GBFJLHKCFEF<PPCIBOGOOFM, T>, OBCALFIHPEE<PPCIBOGOOFM>, ABECDDJBCHC, IDisposable, FAKNFDNJNPG where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class CPHDOBLNELB
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x2B58F20", Offset = "0x2B57920", VA = "0x182B58F20")]
	public static bool OIOKEJAEGIB<T>(this OBCALFIHPEE<PPCIBOGOOFM> GDCGGGDDADM, PPCIBOGOOFM OGPFJDHMIGP, [Out] T IPHMAHBENGI) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x2B5F2C0", Offset = "0x2B5DCC0", VA = "0x182B5F2C0")]
	public static bool ODIPBPJKHHK<T>(this OBCALFIHPEE<PPCIBOGOOFM> GDCGGGDDADM, PPCIBOGOOFM OGPFJDHMIGP, [In] T HELFJHKDFKA) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface LINPEJNFPGO : OBCALFIHPEE<LBMKHNNNCPK>, ABECDDJBCHC, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface KMIBFHEDCIB<T> : GBFJLHKCFEF<LBMKHNNNCPK, T>, OBCALFIHPEE<LBMKHNNNCPK>, ABECDDJBCHC, IDisposable, LINPEJNFPGO where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class AEIMJDGNDHA
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9FD0", Offset = "0x2AC89D0", VA = "0x182AC9FD0")]
	public static T GJMIFHLLDMF<T>(this OBCALFIHPEE<LBMKHNNNCPK> GDCGGGDDADM, LBMKHNNNCPK GMEDGMJCEEO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x2B5F2C0", Offset = "0x2B5DCC0", VA = "0x182B5F2C0")]
	public static bool ODIPBPJKHHK<T>(this OBCALFIHPEE<LBMKHNNNCPK> GDCGGGDDADM, LBMKHNNNCPK GMEDGMJCEEO, [In] T HELFJHKDFKA) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct ELCMDOELFKK : IComparable<ELCMDOELFKK>, IEquatable<ELCMDOELFKK>
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly ELCMDOELFKK GOLLGDANENM;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly ELCMDOELFKK EONFGEMDPIM;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly ELCMDOELFKK NKEOKKMJNMP;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly ELCMDOELFKK AFFAMNHEJCG;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly ELCMDOELFKK IGKAPFHEMII;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly ELCMDOELFKK IEJFBADKOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public int BDIPFIAMOOH;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool LLDBDFOIOEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x6CAB3B0", Offset = "0x6CA9DB0", VA = "0x186CAB3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public int CEMKHOAEBEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x6CAB4A0", Offset = "0x6CA9EA0", VA = "0x186CAB4A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0xBAA9E0", Offset = "0xBA93E0", VA = "0x180BAA9E0")]
	public ELCMDOELFKK(int ENMILGHAHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB440", Offset = "0x6CA9E40", VA = "0x186CAB440", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB3C0", Offset = "0x6CA9DC0", VA = "0x186CAB3C0", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0xC41910", Offset = "0xC40310", VA = "0x180C41910", Slot = "5")]
	public bool Equals(ELCMDOELFKK CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x1E00F00", Offset = "0x1DFF900", VA = "0x181E00F00", Slot = "4")]
	public int CompareTo(ELCMDOELFKK CGCLEIBHLHF)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x1605D90", Offset = "0x1604790", VA = "0x181605D90")]
	public static ELCMDOELFKK DBMBPMAANBF(int ENMILGHAHOM)
	{
		return default(ELCMDOELFKK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1605D90", Offset = "0x1604790", VA = "0x181605D90")]
	public static int DBMBPMAANBF(ELCMDOELFKK MEOOGDKENOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB4B0", Offset = "0x6CA9EB0", VA = "0x186CAB4B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct NMHACHFNADO : IEquatable<NMHACHFNADO>, DCGDCFKOLFG
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly NMHACHFNADO DDDMBDBLMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public LBMKHNNNCPK AMOIIJBOOND
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0", Slot = "6")]
		get
		{
			return default(LBMKHNNNCPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public BDBOOCOGEBJ LFKJKOHKNFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(BDBOOCOGEBJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public AJHILEDOPLL FCJKIIMGIJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(AJHILEDOPLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private MIKMJLGOEBN JACABIFDODA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5F10", Offset = "0x6CA4910", VA = "0x186CA5F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public GameObject BICFCMICGIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4780", Offset = "0x6CB3180", VA = "0x186CB4780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public PPCIBOGOOFM MOOCGAKJFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4310", Offset = "0x6CB2D10", VA = "0x186CB4310")]
		get
		{
			return default(PPCIBOGOOFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public JMLDBJLEEAH GGDOFODGCIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6CB49B0", Offset = "0x6CB33B0", VA = "0x186CB49B0")]
		get
		{
			return default(JMLDBJLEEAH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public ADNGPIOLLLA CHHOGCKJJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6CB43B0", Offset = "0x6CB2DB0", VA = "0x186CB43B0")]
		get
		{
			return default(ADNGPIOLLLA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool GGGNHPEMPEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4990", Offset = "0x6CB3390", VA = "0x186CB4990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool PNOIAJOPHIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4A50", Offset = "0x6CB3450", VA = "0x186CB4A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool MKFINPJBPNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4610", Offset = "0x6CB3010", VA = "0x186CB4610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool GLFHGFJNCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4720", Offset = "0x6CB3120", VA = "0x186CB4720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool KJLLFACFBAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6CB42C0", Offset = "0x6CB2CC0", VA = "0x186CB42C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool BCEMCLCHMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4470", Offset = "0x6CB2E70", VA = "0x186CB4470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool ILEJLKADHJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4740", Offset = "0x6CB3140", VA = "0x186CB4740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool FKMOAGKPPNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4250", Offset = "0x6CB2C50", VA = "0x186CB4250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool CMMDGGPFEIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4450", Offset = "0x6CB2E50", VA = "0x186CB4450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public OFJFGLICEKM JIDMHNBDOID
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(OFJFGLICEKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public CDBKEKNDHGB PFOIIKANAGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(CDBKEKNDHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public PLOAADDAFIG LPECMMDJLIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(PLOAADDAFIG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public FCNNKJCEMFH GNHDPFCMGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(FCNNKJCEMFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public KDEFNJCNDEN OGKBHCNCIIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(KDEFNJCNDEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public ALABOPBEGNH NLDINHMBNBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(ALABOPBEGNH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public OEFDCADBLFH CNMLOJLKEAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(OEFDCADBLFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public HMEMHBBGELK LABMHNOKDHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(HMEMHBBGELK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public MANPODBFNEM HBLPJHCNJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(MANPODBFNEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public OFHPFPBHJKH JJJIEDDONDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(OFHPFPBHJKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public NCLOJINOGBN EDEEEAINLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NCLOJINOGBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public EFCGILJKKIB EOIIHDPNCHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(EFCGILJKKIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool GIPDPCDBIMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4520", Offset = "0x6CB2F20", VA = "0x186CB4520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool NJOOONHLGBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4950", Offset = "0x6CB3350", VA = "0x186CB4950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool KBFOMEMBINI
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4910", Offset = "0x6CB3310", VA = "0x186CB4910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private bool HGJDCELNGNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
	public NMHACHFNADO(LBMKHNNNCPK GMEDGMJCEEO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9660", Offset = "0x6CA8060", VA = "0x186CA9660")]
	public static bool DBMBPMAANBF(NMHACHFNADO IPHMAHBENGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x933670", Offset = "0x932070", VA = "0x180933670")]
	public static LBMKHNNNCPK DBMBPMAANBF(NMHACHFNADO IPHMAHBENGI)
	{
		return default(LBMKHNNNCPK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6CB1370", Offset = "0x6CAFD70", VA = "0x186CB1370")]
	public static bool JGJOKBKMGBC(NMHACHFNADO KPNKONMDFPM, NMHACHFNADO NGNLLOFPDHF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6CB21C0", Offset = "0x6CB0BC0", VA = "0x186CB21C0")]
	public static bool DCLBGLCHDNG(NMHACHFNADO KPNKONMDFPM, NMHACHFNADO NGNLLOFPDHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4490", Offset = "0x6CB2E90", VA = "0x186CB4490", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(NMHACHFNADO CGCLEIBHLHF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x933670", Offset = "0x932070", VA = "0x180933670")]
	public static NMHACHFNADO DBMBPMAANBF(LBMKHNNNCPK NDHGEIKELEB)
	{
		return default(NMHACHFNADO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4A70", Offset = "0x6CB3470", VA = "0x186CB4A70")]
	public KGPIHFGABOG PAKANEHMDBF()
	{
		return default(KGPIHFGABOG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4290", Offset = "0x6CB2C90", VA = "0x186CB4290")]
	public PDAEBGPLLHG AHEINAKDAPC()
	{
		return default(PDAEBGPLLHG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6CB46D0", Offset = "0x6CB30D0", VA = "0x186CB46D0")]
	public CLKALMIKKIG IJFCOMIPOJD()
	{
		return default(CLKALMIKKIG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6CB42E0", Offset = "0x6CB2CE0", VA = "0x186CB42E0")]
	public JKJHKEBAKFG CNNILENKAJH()
	{
		return default(JKJHKEBAKFG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4630", Offset = "0x6CB3030", VA = "0x186CB4630")]
	public void IHJKEBCHIED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4AF0", Offset = "0x6CB34F0", VA = "0x186CB4AF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct OEFDCADBLFH : IEquatable<OEFDCADBLFH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public LBMKHNNNCPK AMOIIJBOOND
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(LBMKHNNNCPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private MIKMJLGOEBN JACABIFDODA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5F10", Offset = "0x6CA4910", VA = "0x186CA5F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private FIFFNHJNCCK MBMKGLOPNPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4FB0", Offset = "0x6CB39B0", VA = "0x186CB4FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private CGJEBAEAPGL BICGNEHLMII
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5690", Offset = "0x6CB4090", VA = "0x186CB5690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool CENLBOFPMMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4E00", Offset = "0x6CB3800", VA = "0x186CB4E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Guid BJAHJDJKOGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5040", Offset = "0x6CB3A40", VA = "0x186CB5040")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool MHFMPNHHPMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5600", Offset = "0x6CB4000", VA = "0x186CB5600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Guid CAIJIBIACCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6CB51F0", Offset = "0x6CB3BF0", VA = "0x186CB51F0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
	public OEFDCADBLFH(LBMKHNNNCPK GMEDGMJCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5310", Offset = "0x6CB3D10", VA = "0x186CB5310", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(OEFDCADBLFH CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5560", Offset = "0x6CB3F60", VA = "0x186CB5560")]
	public bool MLDAKGNEMOE([Out] Guid FAABINMBEKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4E90", Offset = "0x6CB3890", VA = "0x186CB4E90")]
	public void AIOFIEKGPKP(Guid POCLHBJGKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6CB53A0", Offset = "0x6CB3DA0", VA = "0x186CB53A0")]
	public bool KPFCKJNHMID([Out] Guid HEPLADJNIKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5440", Offset = "0x6CB3E40", VA = "0x186CB5440")]
	public void LNLFFNCKKOD(Guid POCLHBJGKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5160", Offset = "0x6CB3B60", VA = "0x186CB5160")]
	public void EJKLONOGCJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct CLKALMIKKIG : IEquatable<CLKALMIKKIG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public LBMKHNNNCPK AMOIIJBOOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(LBMKHNNNCPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private MIKMJLGOEBN JACABIFDODA
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5F10", Offset = "0x6CA4910", VA = "0x186CA5F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private FIFFNHJNCCK MBMKGLOPNPC
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6CA95D0", Offset = "0x6CA7FD0", VA = "0x186CA95D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private KHHOHOFHBIL AGFOGCEHEFM
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9860", Offset = "0x6CA8260", VA = "0x186CA9860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public Vector3 MAOHHEDEIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9710", Offset = "0x6CA8110", VA = "0x186CA9710")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public Quaternion EDIDIKLLGDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6CA98C0", Offset = "0x6CA82C0", VA = "0x186CA98C0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public NMHACHFNADO HGKBDIJMKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9A00", Offset = "0x6CA8400", VA = "0x186CA9A00")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
	public CLKALMIKKIG(LBMKHNNNCPK GMEDGMJCEEO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9660", Offset = "0x6CA8060", VA = "0x186CA9660")]
	public static bool DBMBPMAANBF(CLKALMIKKIG IPHMAHBENGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x933670", Offset = "0x932070", VA = "0x180933670")]
	public static LBMKHNNNCPK DBMBPMAANBF(CLKALMIKKIG IPHMAHBENGI)
	{
		return default(LBMKHNNNCPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9680", Offset = "0x6CA8080", VA = "0x186CA9680", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(CLKALMIKKIG CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9D60", Offset = "0x6CA8760", VA = "0x186CA9D60")]
	public void PLFGEDFPKIH(Vector3 EJEBFMEPKGF, Quaternion PCIAHIPKDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9A90", Offset = "0x6CA8490", VA = "0x186CA9A90")]
	public void OJIEDIAMPFG(float FCFDEHNOPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9BA0", Offset = "0x6CA85A0", VA = "0x186CA9BA0")]
	public void PCIAGEBBJBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct KGPIHFGABOG : IEquatable<KGPIHFGABOG>
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly KGPIHFGABOG DDDMBDBLMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public LBMKHNNNCPK AMOIIJBOOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(LBMKHNNNCPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public BDBOOCOGEBJ LFKJKOHKNFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(BDBOOCOGEBJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public AJHILEDOPLL FCJKIIMGIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(AJHILEDOPLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private MIKMJLGOEBN JACABIFDODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5F10", Offset = "0x6CA4910", VA = "0x186CA5F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private FIFFNHJNCCK MBMKGLOPNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6CB0CC0", Offset = "0x6CAF6C0", VA = "0x186CB0CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private LMKIIMOLCHA CBGEEPJABJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6CB1940", Offset = "0x6CB0340", VA = "0x186CB1940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public ECKJADHBOIC GINIJFIEILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6CB01A0", Offset = "0x6CAEBA0", VA = "0x186CB01A0")]
		get
		{
			return default(ECKJADHBOIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public IEnumerable<NMHACHFNADO> EGPJBHPFBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x6CB1210", Offset = "0x6CAFC10", VA = "0x186CB1210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public IEnumerable<NMHACHFNADO> IACNJLCGJKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6CB1730", Offset = "0x6CB0130", VA = "0x186CB1730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public int NFJJMFLIFGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6CB0F50", Offset = "0x6CAF950", VA = "0x186CB0F50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public int BFDMJCICLAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x6CB0FE0", Offset = "0x6CAF9E0", VA = "0x186CB0FE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public string FMJDNGHFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6CB00F0", Offset = "0x6CAEAF0", VA = "0x186CB00F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6CB1160", Offset = "0x6CAFB60", VA = "0x186CB1160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public CMPAOPHFPKI FCBEJBCDOID
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6CB1660", Offset = "0x6CB0060", VA = "0x186CB1660")]
		get
		{
			return default(CMPAOPHFPKI);
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x6CB0D70", Offset = "0x6CAF770", VA = "0x186CB0D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public KMLJHEHHFAG MEIJKACAEOD
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x6CB1380", Offset = "0x6CAFD80", VA = "0x186CB1380")]
		get
		{
			return default(KMLJHEHHFAG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x6CB0DE0", Offset = "0x6CAF7E0", VA = "0x186CB0DE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public IAACMHHCDGE LCDFGPOAJKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x6CB1030", Offset = "0x6CAFA30", VA = "0x186CB1030")]
		get
		{
			return default(IAACMHHCDGE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6CB1A10", Offset = "0x6CB0410", VA = "0x186CB1A10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public float HJDEICGGGMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6CB0260", Offset = "0x6CAEC60", VA = "0x186CB0260")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6CB1090", Offset = "0x6CAFA90", VA = "0x186CB1090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool LKKLJMEAHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x6CB0C50", Offset = "0x6CAF650", VA = "0x186CB0C50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool GADOLPOPGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6CB02C0", Offset = "0x6CAECC0", VA = "0x186CB02C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool CPNKFFMACNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6CB0E50", Offset = "0x6CAF850", VA = "0x186CB0E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool DPHDJKANEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6CB19A0", Offset = "0x6CB03A0", VA = "0x186CB19A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool PODJLBAONJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6CB13E0", Offset = "0x6CAFDE0", VA = "0x186CB13E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6CB1440", Offset = "0x6CAFE40", VA = "0x186CB1440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool ABGOJELKAKM
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6CB1100", Offset = "0x6CAFB00", VA = "0x186CB1100")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6CB16C0", Offset = "0x6CB00C0", VA = "0x186CB16C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
	public KGPIHFGABOG(LBMKHNNNCPK GMEDGMJCEEO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9660", Offset = "0x6CA8060", VA = "0x186CA9660")]
	public static bool DBMBPMAANBF(KGPIHFGABOG IPHMAHBENGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6CB1370", Offset = "0x6CAFD70", VA = "0x186CB1370")]
	public static bool JGJOKBKMGBC(KGPIHFGABOG KPNKONMDFPM, KGPIHFGABOG NGNLLOFPDHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6CB0EC0", Offset = "0x6CAF8C0", VA = "0x186CB0EC0", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(KGPIHFGABOG CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x933670", Offset = "0x932070", VA = "0x180933670")]
	public static NMHACHFNADO DBMBPMAANBF(KGPIHFGABOG NKCEKILMAAM)
	{
		return default(NMHACHFNADO);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6CB0D50", Offset = "0x6CAF750", VA = "0x186CB0D50")]
	public bool CJFBIDCMMJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6CB18D0", Offset = "0x6CB02D0", VA = "0x186CB18D0")]
	public bool MHAKIOOHKDA(PCKDAGNPJNH FPONPAAIKFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6CB1850", Offset = "0x6CB0250", VA = "0x186CB1850")]
	public void MFHNGEJNCMI(PCKDAGNPJNH FPONPAAIKFC, bool IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6CB14B0", Offset = "0x6CAFEB0", VA = "0x186CB14B0")]
	public ECKJADHBOIC LNBLPHEHLEI(Allocator MPFEIGMBFCP)
	{
		return default(ECKJADHBOIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6CB0330", Offset = "0x6CAED30", VA = "0x186CB0330")]
	public void AGMNPDPMDHI(KGPIHFGABOG CGCLEIBHLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6CB06A0", Offset = "0x6CAF0A0", VA = "0x186CB06A0")]
	public void BFDJAHFKHDP(List<NMHACHFNADO> KDEIPJICKNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct LPMAIHPMBKO : IEquatable<LPMAIHPMBKO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6CB31D0", Offset = "0x6CB1BD0", VA = "0x186CB31D0", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(LPMAIHPMBKO CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct CDBKEKNDHGB : IEquatable<CDBKEKNDHGB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private MIKMJLGOEBN JACABIFDODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5F10", Offset = "0x6CA4910", VA = "0x186CA5F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
	public CDBKEKNDHGB(LBMKHNNNCPK GMEDGMJCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6CA92D0", Offset = "0x6CA7CD0", VA = "0x186CA92D0", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(CDBKEKNDHGB CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6CA94A0", Offset = "0x6CA7EA0", VA = "0x186CA94A0")]
	public void MOGENANDEFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9400", Offset = "0x6CA7E00", VA = "0x186CA9400")]
	public void LEMLOFPKIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9360", Offset = "0x6CA7D60", VA = "0x186CA9360")]
	public bool IOGKIEMEAFN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct AJHILEDOPLL : IEquatable<AJHILEDOPLL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public LBMKHNNNCPK AMOIIJBOOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(LBMKHNNNCPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	private MIKMJLGOEBN JACABIFDODA
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5F10", Offset = "0x6CA4910", VA = "0x186CA5F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private FIFFNHJNCCK MBMKGLOPNPC
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5DF0", Offset = "0x6CA47F0", VA = "0x186CA5DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private LMKIIMOLCHA CBGEEPJABJK
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6CA6260", Offset = "0x6CA4C60", VA = "0x186CA6260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public LBMKHNNNCPK HPIOIDKOBNL
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5E80", Offset = "0x6CA4880", VA = "0x186CA5E80")]
		get
		{
			return default(LBMKHNNNCPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public NMHACHFNADO JEBILDNGPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6CA60A0", Offset = "0x6CA4AA0", VA = "0x186CA60A0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public NMHACHFNADO CHMOOKFGBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6CA63F0", Offset = "0x6CA4DF0", VA = "0x186CA63F0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
	public AJHILEDOPLL(LBMKHNNNCPK GMEDGMJCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F80", Offset = "0x6CA4980", VA = "0x186CA5F80", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(AJHILEDOPLL CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6CA62C0", Offset = "0x6CA4CC0", VA = "0x186CA62C0")]
	public bool NJPHAMCIKMD(NMHACHFNADO KMAENCDMJDN, bool GALIBFNBNCO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6130", Offset = "0x6CA4B30", VA = "0x186CA6130")]
	public bool IEPMHFBNFHL(NMHACHFNADO MODBHFMJGIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5B60", Offset = "0x6CA4560", VA = "0x186CA5B60")]
	private void BHPJKEHJDOA(NMHACHFNADO KIICGGOCFPC, List<NMHACHFNADO> DAODNECBOKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6CA61D0", Offset = "0x6CA4BD0", VA = "0x186CA61D0")]
	public KGPIHFGABOG JKGPFGOPFDC()
	{
		return default(KGPIHFGABOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6010", Offset = "0x6CA4A10", VA = "0x186CA6010")]
	public void FLEHIPKHHKH(List<NMHACHFNADO> DGPOPLJLCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5A40", Offset = "0x6CA4440", VA = "0x186CA5A40")]
	public NativeArray<LBMKHNNNCPK> AKEAGMEEBON()
	{
		return default(NativeArray<LBMKHNNNCPK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct OFJFGLICEKM : IEquatable<OFJFGLICEKM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public string MBOLGOCFBNP
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6990", Offset = "0x6CB5390", VA = "0x186CB6990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public string DIIJFFLKJFF
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6CB62D0", Offset = "0x6CB4CD0", VA = "0x186CB62D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool BCBMFCHNKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6CB66D0", Offset = "0x6CB50D0", VA = "0x186CB66D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public string BLHLHIHOICH
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6CB68A0", Offset = "0x6CB52A0", VA = "0x186CB68A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public string MODLMPENEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6480", Offset = "0x6CB4E80", VA = "0x186CB6480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public string NLPAMMOIBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6390", Offset = "0x6CB4D90", VA = "0x186CB6390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
	public OFJFGLICEKM(LBMKHNNNCPK GMEDGMJCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6810", Offset = "0x6CB5210", VA = "0x186CB6810", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(OFJFGLICEKM CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct NCLOJINOGBN : IEquatable<NCLOJINOGBN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private MIKMJLGOEBN JACABIFDODA
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5F10", Offset = "0x6CA4910", VA = "0x186CA5F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private FIFFNHJNCCK MBMKGLOPNPC
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6CB39C0", Offset = "0x6CB23C0", VA = "0x186CB39C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	private NKGMMLAHCIG MDOAPFMCOOK
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3830", Offset = "0x6CB2230", VA = "0x186CB3830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public BKHMLAEEIKH IGBNIKBFJHP
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6CB40B0", Offset = "0x6CB2AB0", VA = "0x186CB40B0")]
		get
		{
			return default(BKHMLAEEIKH);
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3F00", Offset = "0x6CB2900", VA = "0x186CB3F00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public bool LIHPOIOAOJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3E70", Offset = "0x6CB2870", VA = "0x186CB3E70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3DD0", Offset = "0x6CB27D0", VA = "0x186CB3DD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public string[] EDLABINPADG
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3B70", Offset = "0x6CB2570", VA = "0x186CB3B70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6CB41B0", Offset = "0x6CB2BB0", VA = "0x186CB41B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public string[] AGOLPLMCDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3AE0", Offset = "0x6CB24E0", VA = "0x186CB3AE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3C90", Offset = "0x6CB2690", VA = "0x186CB3C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public string[] GKKHHCIJPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3A50", Offset = "0x6CB2450", VA = "0x186CB3A50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4010", Offset = "0x6CB2A10", VA = "0x186CB4010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public string[] OODIEFICDGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3930", Offset = "0x6CB2330", VA = "0x186CB3930")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3D30", Offset = "0x6CB2730", VA = "0x186CB3D30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
	public NCLOJINOGBN(LBMKHNNNCPK GMEDGMJCEEO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x933670", Offset = "0x932070", VA = "0x180933670")]
	public static LBMKHNNNCPK DBMBPMAANBF(NCLOJINOGBN IPHMAHBENGI)
	{
		return default(LBMKHNNNCPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3C00", Offset = "0x6CB2600", VA = "0x186CB3C00", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(NCLOJINOGBN CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3890", Offset = "0x6CB2290", VA = "0x186CB3890")]
	public bool AMINFADMNOD(LBMKHNNNCPK DBKPGAEGHAD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct ANLDJPEKDIE : IEquatable<ANLDJPEKDIE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6760", Offset = "0x6CA5160", VA = "0x186CA6760", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(ANLDJPEKDIE CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct PLOAADDAFIG : IEquatable<PLOAADDAFIG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
	public PLOAADDAFIG(LBMKHNNNCPK GMEDGMJCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8410", Offset = "0x6CB6E10", VA = "0x186CB8410", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(PLOAADDAFIG CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6CB82A0", Offset = "0x6CB6CA0", VA = "0x186CB82A0")]
	public bool CMOFKEANFIG([Out] Collider CFMHFMLEKHC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct JKJHKEBAKFG : IEquatable<JKJHKEBAKFG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public LBMKHNNNCPK AMOIIJBOOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(LBMKHNNNCPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private MakerPenHeldDataWrapper OJCMNIABOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x6CAEF70", Offset = "0x6CAD970", VA = "0x186CAEF70")]
		get
		{
			return default(MakerPenHeldDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public bool MEKBAEADOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x6CAEE70", Offset = "0x6CAD870", VA = "0x186CAEE70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
	public JKJHKEBAKFG(LBMKHNNNCPK GMEDGMJCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6CAEEE0", Offset = "0x6CAD8E0", VA = "0x186CAEEE0", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(JKJHKEBAKFG CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct MANPODBFNEM : IEquatable<MANPODBFNEM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public LBMKHNNNCPK AMOIIJBOOND
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(LBMKHNNNCPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	private MIKMJLGOEBN JACABIFDODA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5F10", Offset = "0x6CA4910", VA = "0x186CA5F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private FIFFNHJNCCK MBMKGLOPNPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6CB33D0", Offset = "0x6CB1DD0", VA = "0x186CB33D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	private PPCBPBEGNBC JEBHKGEALOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6CB34F0", Offset = "0x6CB1EF0", VA = "0x186CB34F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
	public MANPODBFNEM(LBMKHNNNCPK GMEDGMJCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3460", Offset = "0x6CB1E60", VA = "0x186CB3460", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(MANPODBFNEM CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3330", Offset = "0x6CB1D30", VA = "0x186CB3330")]
	public void ADNADNBPKBG(bool MNPONNOKKLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct FCNNKJCEMFH : IEquatable<FCNNKJCEMFH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public LBMKHNNNCPK AMOIIJBOOND
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(LBMKHNNNCPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private MIKMJLGOEBN JACABIFDODA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5F10", Offset = "0x6CA4910", VA = "0x186CA5F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	private FIFFNHJNCCK MBMKGLOPNPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x6CABAD0", Offset = "0x6CAA4D0", VA = "0x186CABAD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private ObjectPolicyDataWrapper DJKOAFEABEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC4A0", Offset = "0x6CAAEA0", VA = "0x186CAC4A0")]
		get
		{
			return default(ObjectPolicyDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private NavMeshGenerationDataWrapper IIIAHDEGBIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x6CABE80", Offset = "0x6CAA880", VA = "0x186CABE80")]
		get
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool BFODNNCLEGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x6CAB940", Offset = "0x6CAA340", VA = "0x186CAB940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool INLBOAEAOLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC500", Offset = "0x6CAAF00", VA = "0x186CAC500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool OFIHCKBGFJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x6CABC40", Offset = "0x6CAA640", VA = "0x186CABC40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool DEKHMPINBPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x6CABB60", Offset = "0x6CAA560", VA = "0x186CABB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool JBDCDFHKJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6CAB760", Offset = "0x6CAA160", VA = "0x186CAB760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public bool HKKJFDAEODK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC260", Offset = "0x6CAAC60", VA = "0x186CAC260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public bool OBIIDBKAIDC
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x6CABD80", Offset = "0x6CAA780", VA = "0x186CABD80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public bool CPABOMLHMAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x6CABA60", Offset = "0x6CAA460", VA = "0x186CABA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public bool FOEKPEMFCIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x6CABD10", Offset = "0x6CAA710", VA = "0x186CABD10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public bool KIIMHGMMBFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC430", Offset = "0x6CAAE30", VA = "0x186CAC430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool OGDFHPEBOMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC640", Offset = "0x6CAB040", VA = "0x186CAC640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool FHKPAPIBFNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6CABEE0", Offset = "0x6CAA8E0", VA = "0x186CABEE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool HMMPMHIDDFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6CABCB0", Offset = "0x6CAA6B0", VA = "0x186CABCB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool JBJONACBHMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6CABF50", Offset = "0x6CAA950", VA = "0x186CABF50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC710", Offset = "0x6CAB110", VA = "0x186CAC710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public IOHEPHKHNGL OBEBNECOMME
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6CAB980", Offset = "0x6CAA380", VA = "0x186CAB980")]
		get
		{
			return default(IOHEPHKHNGL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x6CABFB0", Offset = "0x6CAA9B0", VA = "0x186CABFB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool GKFCCLGHHBN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC090", Offset = "0x6CAAA90", VA = "0x186CAC090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public LEAMHLPCKGF NGHCBJHLJEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC6B0", Offset = "0x6CAB0B0", VA = "0x186CAC6B0")]
		get
		{
			return default(LEAMHLPCKGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool ILIOBPMBOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC2D0", Offset = "0x6CAACD0", VA = "0x186CAC2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Vector3 LNBFGLHBOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6CAB7D0", Offset = "0x6CAA1D0", VA = "0x186CAB7D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Vector3 LIKCBJJEGHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6CAB890", Offset = "0x6CAA290", VA = "0x186CAB890")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public bool IEAAOHLLDAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC330", Offset = "0x6CAAD30", VA = "0x186CAC330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
	public FCNNKJCEMFH(LBMKHNNNCPK GMEDGMJCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6CABDF0", Offset = "0x6CAA7F0", VA = "0x186CABDF0", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(FCNNKJCEMFH CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x6CAC570", Offset = "0x6CAAF70", VA = "0x186CAC570")]
	public bool LAPGOOFIABD(IOBEOGCFEND FPONPAAIKFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x6CAC020", Offset = "0x6CAAA20", VA = "0x186CAC020")]
	public bool GJPGFILHLON(NFCIMKIGCDM FPONPAAIKFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB9E0", Offset = "0x6CAA3E0", VA = "0x186CAB9E0")]
	public void BFDNPHNLBGJ(NFCIMKIGCDM FPONPAAIKFC, bool MPFEOFHFNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6CAC5E0", Offset = "0x6CAAFE0", VA = "0x186CAC5E0")]
	public NFCIMKIGCDM LEKAJPEKJIL()
	{
		return default(NFCIMKIGCDM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6CABBD0", Offset = "0x6CAA5D0", VA = "0x186CABBD0")]
	public bool CEEHHBIOKPI(NFCIMKIGCDM IPHMAHBENGI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct OFHPFPBHJKH : IEquatable<OFHPFPBHJKH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private MIKMJLGOEBN JACABIFDODA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5F10", Offset = "0x6CA4910", VA = "0x186CA5F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private FIFFNHJNCCK MBMKGLOPNPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5800", Offset = "0x6CB4200", VA = "0x186CB5800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	private BGJLPGJHEDM CAJIHMNGKJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6030", Offset = "0x6CB4A30", VA = "0x186CB6030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
	public OFHPFPBHJKH(LBMKHNNNCPK GMEDGMJCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5AD0", Offset = "0x6CB44D0", VA = "0x186CB5AD0", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(OFHPFPBHJKH CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5B60", Offset = "0x6CB4560", VA = "0x186CB5B60")]
	public bool FFIENLPLFNN(NAKOJNDAOID CJJFHMMBLHB, List<NMHACHFNADO> KDEIPJICKNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6CB59C0", Offset = "0x6CB43C0", VA = "0x186CB59C0")]
	public int DAACMGDLLNE(NAKOJNDAOID CJJFHMMBLHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5C90", Offset = "0x6CB4690", VA = "0x186CB5C90")]
	public void HBNGFPDKPOJ(List<NMHACHFNADO> KDEIPJICKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5890", Offset = "0x6CB4290", VA = "0x186CB5890")]
	public int COKCFNJBHFI(NMHACHFNADO CDHECNAFHCH, NAKOJNDAOID CJJFHMMBLHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5DA0", Offset = "0x6CB47A0", VA = "0x186CB5DA0")]
	public NMHACHFNADO KIDCEHFIGOM(int ENMILGHAHOM, NAKOJNDAOID CJJFHMMBLHB)
	{
		return default(NMHACHFNADO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6090", Offset = "0x6CB4A90", VA = "0x186CB6090")]
	public void OAEDNFEODPG(NMHACHFNADO CDHECNAFHCH, NAKOJNDAOID CJJFHMMBLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5F80", Offset = "0x6CB4980", VA = "0x186CB5F80")]
	public bool NIGFOCNLMPO(NMHACHFNADO CDHECNAFHCH, NAKOJNDAOID CJJFHMMBLHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6CB61C0", Offset = "0x6CB4BC0", VA = "0x186CB61C0")]
	public void ODCACIPBBFN(NAKOJNDAOID CJJFHMMBLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5ED0", Offset = "0x6CB48D0", VA = "0x186CB5ED0")]
	public bool KJHNJIBBPPB(NMHACHFNADO CDHECNAFHCH, NAKOJNDAOID CJJFHMMBLHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6CB56F0", Offset = "0x6CB40F0", VA = "0x186CB56F0")]
	public bool BMCIFFODCIE(NAKOJNDAOID CJJFHMMBLHB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public readonly struct ALABOPBEGNH : IEquatable<ALABOPBEGNH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public LBMKHNNNCPK AMOIIJBOOND
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(LBMKHNNNCPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private MIKMJLGOEBN JACABIFDODA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5F10", Offset = "0x6CA4910", VA = "0x186CA5F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private FIFFNHJNCCK MBMKGLOPNPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6CA64A0", Offset = "0x6CA4EA0", VA = "0x186CA64A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
	public ALABOPBEGNH(LBMKHNNNCPK GMEDGMJCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6530", Offset = "0x6CA4F30", VA = "0x186CA6530", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(ALABOPBEGNH CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x6CA65C0", Offset = "0x6CA4FC0", VA = "0x186CA65C0")]
	public void HJFDFHJHIKO(bool IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6650", Offset = "0x6CA5050", VA = "0x186CA6650")]
	public void NMFNPDPIBGN(bool IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x34485D0", Offset = "0x3446FD0", VA = "0x1834485D0")]
	public T BODODMHGIDM<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct EFCGILJKKIB : IEquatable<EFCGILJKKIB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public LBMKHNNNCPK AMOIIJBOOND
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(LBMKHNNNCPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	private MIKMJLGOEBN JACABIFDODA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5F10", Offset = "0x6CA4910", VA = "0x186CA5F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private FIFFNHJNCCK MBMKGLOPNPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x6CAAD90", Offset = "0x6CA9790", VA = "0x186CAAD90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private MEJIJLAAPOH DKJDIOHJNNN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6CAAF40", Offset = "0x6CA9940", VA = "0x186CAAF40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public bool IDOFILMMJJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x6CAAFA0", Offset = "0x6CA99A0", VA = "0x186CAAFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public bool GOFKHCAEABA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x6CAAE20", Offset = "0x6CA9820", VA = "0x186CAAE20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
	public EFCGILJKKIB(LBMKHNNNCPK GMEDGMJCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6CAAEB0", Offset = "0x6CA98B0", VA = "0x186CAAEB0", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(EFCGILJKKIB CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct ILPCANABGJB : IEquatable<ILPCANABGJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6CAED80", Offset = "0x6CAD780", VA = "0x186CAED80", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(ILPCANABGJB CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct KDEFNJCNDEN : IEquatable<KDEFNJCNDEN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public LBMKHNNNCPK AMOIIJBOOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(LBMKHNNNCPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private MIKMJLGOEBN JACABIFDODA
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5F10", Offset = "0x6CA4910", VA = "0x186CA5F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private FIFFNHJNCCK MBMKGLOPNPC
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x6CAF5A0", Offset = "0x6CADFA0", VA = "0x186CAF5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private HMMGCDHAEBI APKJGODBEOP
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6CAF790", Offset = "0x6CAE190", VA = "0x186CAF790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private PADLCAJDGFM EGEKACOCEAC
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x6CAFC30", Offset = "0x6CAE630", VA = "0x186CAFC30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool IIECNNENNLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x6CAFBA0", Offset = "0x6CAE5A0", VA = "0x186CAFBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool JDKDNMPHHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x6CAF500", Offset = "0x6CADF00", VA = "0x186CAF500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool LNENJKBDDDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x6CAFFB0", Offset = "0x6CAE9B0", VA = "0x186CAFFB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool MECODCCHAOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x6CAF430", Offset = "0x6CADE30", VA = "0x186CAF430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool ILCPBCJEGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x6CAF630", Offset = "0x6CAE030", VA = "0x186CAF630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool PNEJIOCJHIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x6CAFB10", Offset = "0x6CAE510", VA = "0x186CAFB10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool AHFAIDILBDB
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6CAF900", Offset = "0x6CAE300", VA = "0x186CAF900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public bool AAOMBBALHOC
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x6CAFD30", Offset = "0x6CAE730", VA = "0x186CAFD30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
	public KDEFNJCNDEN(LBMKHNNNCPK GMEDGMJCEEO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9660", Offset = "0x6CA8060", VA = "0x186CA9660")]
	public static bool DBMBPMAANBF(KDEFNJCNDEN IPHMAHBENGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6CAF660", Offset = "0x6CAE060", VA = "0x186CAF660", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(KDEFNJCNDEN CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6CAFEA0", Offset = "0x6CAE8A0", VA = "0x186CAFEA0")]
	public bool LICLLHENFEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x6CAF6F0", Offset = "0x6CAE0F0", VA = "0x186CAF6F0")]
	public NMHACHFNADO FKFDHPOMCED(NMHACHFNADO CDHECNAFHCH)
	{
		return default(NMHACHFNADO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x6CAFFE0", Offset = "0x6CAE9E0", VA = "0x186CAFFE0")]
	public LBMKHNNNCPK PJJBONFAOAE()
	{
		return default(LBMKHNNNCPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x6CAFC90", Offset = "0x6CAE690", VA = "0x186CAFC90")]
	public bool KPBCDJLIGNH(LBMKHNNNCPK KMLNHJDFBDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6CAFF10", Offset = "0x6CAE910", VA = "0x186CAFF10")]
	public bool NBFAMILGOBK(LBMKHNNNCPK HFEPEPGFIAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x6CAF7F0", Offset = "0x6CAE1F0", VA = "0x186CAF7F0")]
	public bool GFCMFHENAKE(LBMKHNNNCPK CDHECNAFHCH, [Out] LBMKHNNNCPK KMLNHJDFBDB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct PDAEBGPLLHG : IEquatable<PDAEBGPLLHG>
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly PDAEBGPLLHG DDDMBDBLMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public LBMKHNNNCPK AMOIIJBOOND
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(LBMKHNNNCPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public BDBOOCOGEBJ LFKJKOHKNFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(BDBOOCOGEBJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public AJHILEDOPLL FCJKIIMGIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(AJHILEDOPLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private ShapeTypeDataWrapper JHANJJGGACD
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7080", Offset = "0x6CB5A80", VA = "0x186CB7080")]
		get
		{
			return default(ShapeTypeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public StandardRenderableVisualDataWrapper BGEPBNGGFEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6E80", Offset = "0x6CB5880", VA = "0x186CB6E80")]
		get
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public PhysicsMaterialDataWrapper NNBIEFDPKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7020", Offset = "0x6CB5A20", VA = "0x186CB7020")]
		get
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public ShapeConfigDataWrapper HHNLJGNJGFI
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6BE0", Offset = "0x6CB55E0", VA = "0x186CB6BE0")]
		get
		{
			return default(ShapeConfigDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public LDFLIPIODHK AAOCCCFBABO
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6DA0", Offset = "0x6CB57A0", VA = "0x186CB6DA0")]
		get
		{
			return default(LDFLIPIODHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public KIPGNFHCHPL CBBLFCJPJBB
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6AB0", Offset = "0x6CB54B0", VA = "0x186CB6AB0")]
		get
		{
			return default(KIPGNFHCHPL);
		}
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6FB0", Offset = "0x6CB59B0", VA = "0x186CB6FB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public KLDMBKIAFMO LEJGECJHNOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6D40", Offset = "0x6CB5740", VA = "0x186CB6D40")]
		get
		{
			return default(KLDMBKIAFMO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6B70", Offset = "0x6CB5570", VA = "0x186CB6B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public float BFCAKMEGJNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6B10", Offset = "0x6CB5510", VA = "0x186CB6B10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6E10", Offset = "0x6CB5810", VA = "0x186CB6E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public Vector3 GIOIKCJCOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6A10", Offset = "0x6CB5410", VA = "0x186CB6A10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x6CB70E0", Offset = "0x6CB5AE0", VA = "0x186CB70E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float DMIMLBHACPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6C40", Offset = "0x6CB5640", VA = "0x186CB6C40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public NLDPOFDOMMH LJICIACMLME
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6F50", Offset = "0x6CB5950", VA = "0x186CB6F50")]
		get
		{
			return default(NLDPOFDOMMH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6EE0", Offset = "0x6CB58E0", VA = "0x186CB6EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
	public PDAEBGPLLHG(LBMKHNNNCPK GMEDGMJCEEO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9660", Offset = "0x6CA8060", VA = "0x186CA9660")]
	public static bool DBMBPMAANBF(PDAEBGPLLHG IPHMAHBENGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6CB21C0", Offset = "0x6CB0BC0", VA = "0x186CB21C0")]
	public static bool DCLBGLCHDNG(PDAEBGPLLHG KPNKONMDFPM, PDAEBGPLLHG NGNLLOFPDHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6CB0", Offset = "0x6CB56B0", VA = "0x186CB6CB0", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(PDAEBGPLLHG CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7180", Offset = "0x6CB5B80", VA = "0x186CB7180")]
	public NOFKILLLHIG MNBDOLFMAHC()
	{
		return default(NOFKILLLHIG);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7200", Offset = "0x6CB5C00", VA = "0x186CB7200")]
	public PFJNJPAKKAJ OJPAPNIADAI()
	{
		return default(PFJNJPAKKAJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct NOFKILLLHIG : IEquatable<NOFKILLLHIG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public LBMKHNNNCPK AMOIIJBOOND
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(LBMKHNNNCPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public PDAEBGPLLHG HMCGIKDCIOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(PDAEBGPLLHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private PrimitiveShapeDataWrapper BPJLKKGMHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4CC0", Offset = "0x6CB36C0", VA = "0x186CB4CC0")]
		get
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public NIGNKOFGHHP ALBLPHNHCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4C60", Offset = "0x6CB3660", VA = "0x186CB4C60")]
		get
		{
			return default(NIGNKOFGHHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
	public NOFKILLLHIG(LBMKHNNNCPK GMEDGMJCEEO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9660", Offset = "0x6CA8060", VA = "0x186CA9660")]
	public static bool DBMBPMAANBF(NOFKILLLHIG IPHMAHBENGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4BD0", Offset = "0x6CB35D0", VA = "0x186CB4BD0", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(NOFKILLLHIG CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DefaultMember("Item")]
public readonly struct PFJNJPAKKAJ : IEquatable<PFJNJPAKKAJ>
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public static readonly PFJNJPAKKAJ DDDMBDBLMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public LBMKHNNNCPK AMOIIJBOOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(LBMKHNNNCPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public BDBOOCOGEBJ LFKJKOHKNFF
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(BDBOOCOGEBJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private MIKMJLGOEBN JACABIFDODA
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5F10", Offset = "0x6CA4910", VA = "0x186CA5F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	private FIFFNHJNCCK MBMKGLOPNPC
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7410", Offset = "0x6CB5E10", VA = "0x186CB7410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	private PDBGALDEFLB CAGFMHMOHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x6CB8010", Offset = "0x6CB6A10", VA = "0x186CB8010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public PDAEBGPLLHG HMCGIKDCIOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(PDAEBGPLLHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public GDJKHIELFIH KJAMHKDHCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x6CB76F0", Offset = "0x6CB60F0", VA = "0x186CB76F0")]
		get
		{
			return default(GDJKHIELFIH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x6CB75D0", Offset = "0x6CB5FD0", VA = "0x186CB75D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public IEnumerable<GOGDGHOPHPO> BMNPEJGOILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7E10", Offset = "0x6CB6810", VA = "0x186CB7E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public GOGDGHOPHPO BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7D00", Offset = "0x6CB6700", VA = "0x186CB7D00")]
		get
		{
			return default(GOGDGHOPHPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7540", Offset = "0x6CB5F40", VA = "0x186CB7540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
	public PFJNJPAKKAJ(LBMKHNNNCPK GMEDGMJCEEO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9660", Offset = "0x6CA8060", VA = "0x186CA9660")]
	public static bool DBMBPMAANBF(PFJNJPAKKAJ IPHMAHBENGI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x6CB1370", Offset = "0x6CAFD70", VA = "0x186CB1370")]
	public static bool JGJOKBKMGBC(PFJNJPAKKAJ KPNKONMDFPM, PFJNJPAKKAJ NGNLLOFPDHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7820", Offset = "0x6CB6220", VA = "0x186CB7820", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(PFJNJPAKKAJ CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x6CB78B0", Offset = "0x6CB62B0", VA = "0x186CB78B0")]
	public GOGDGHOPHPO FFOEOKOCNDM(float3? EJEBFMEPKGF, [Optional] quaternion? PCIAHIPKDFG, [Optional] Vector3? FCFDEHNOPJK)
	{
		return default(GOGDGHOPHPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7AD0", Offset = "0x6CB64D0", VA = "0x186CB7AD0")]
	public GOGDGHOPHPO MHGAKADDEOO(int ENMILGHAHOM, float3? EJEBFMEPKGF, [Optional] quaternion? PCIAHIPKDFG, [Optional] Vector3? FCFDEHNOPJK)
	{
		return default(GOGDGHOPHPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x6CB74A0", Offset = "0x6CB5EA0", VA = "0x186CB74A0")]
	public void CDFFICCMFMF(int ENMILGHAHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8070", Offset = "0x6CB6A70", VA = "0x186CB8070")]
	public void ODPBLJHKGDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct GOGDGHOPHPO : IEquatable<GOGDGHOPHPO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public LBMKHNNNCPK AMOIIJBOOND
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(LBMKHNNNCPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public PFJNJPAKKAJ EIFPBEBDHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x6CADA80", Offset = "0x6CAC480", VA = "0x186CADA80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public float3 AIFDJMPCLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD530", Offset = "0x6CABF30", VA = "0x186CAD530")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD7D0", Offset = "0x6CAC1D0", VA = "0x186CAD7D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public quaternion HCLPIOBIAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD990", Offset = "0x6CAC390", VA = "0x186CAD990")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x6CADA10", Offset = "0x6CAC410", VA = "0x186CADA10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public float3 GNKMAIOMENK
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD4B0", Offset = "0x6CABEB0", VA = "0x186CAD4B0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD850", Offset = "0x6CAC250", VA = "0x186CAD850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public JEPGGBIAAIP NIKHBBLBOFO
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD610", Offset = "0x6CAC010", VA = "0x186CAD610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	private SplinePointParentDataWrapper AEHIHKIHGGE
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD930", Offset = "0x6CAC330", VA = "0x186CAD930")]
		get
		{
			return default(SplinePointParentDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	private SplinePointPositionDataWrapper BJIGGIMGNAC
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD680", Offset = "0x6CAC080", VA = "0x186CAD680")]
		get
		{
			return default(SplinePointPositionDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	private SplinePointRotationDataWrapper IJPMDBOBIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD8D0", Offset = "0x6CAC2D0", VA = "0x186CAD8D0")]
		get
		{
			return default(SplinePointRotationDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	private SplinePointScaleDataWrapper FBGACOINBAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD6E0", Offset = "0x6CAC0E0", VA = "0x186CAD6E0")]
		get
		{
			return default(SplinePointScaleDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	private SplinePointOrderDataWrapper CEJKOEOAJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD5B0", Offset = "0x6CABFB0", VA = "0x186CAD5B0")]
		get
		{
			return default(SplinePointOrderDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
	public GOGDGHOPHPO(LBMKHNNNCPK GMEDGMJCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD740", Offset = "0x6CAC140", VA = "0x186CAD740", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(GOGDGHOPHPO CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x6CADA80", Offset = "0x6CAC480", VA = "0x186CADA80")]
	public void OOBIGBBBMBP(PFJNJPAKKAJ IPHMAHBENGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct HMEMHBBGELK : IEquatable<HMEMHBBGELK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public LBMKHNNNCPK AMOIIJBOOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(LBMKHNNNCPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private MIKMJLGOEBN JACABIFDODA
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5F10", Offset = "0x6CA4910", VA = "0x186CA5F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private FIFFNHJNCCK MBMKGLOPNPC
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x6CADFD0", Offset = "0x6CAC9D0", VA = "0x186CADFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	private FIEKMEKJLHL IGIDLHBEKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6CAEA30", Offset = "0x6CAD430", VA = "0x186CAEA30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	private ToolCleanupSettingsDataWrapper DLHDIPCEALI
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x6CAE260", Offset = "0x6CACC60", VA = "0x186CAE260")]
		get
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool NFBHCHHPNBP
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x6CAE820", Offset = "0x6CAD220", VA = "0x186CAE820")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x6CADF60", Offset = "0x6CAC960", VA = "0x186CADF60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public bool PIOKAAAOHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x6CAE100", Offset = "0x6CACB00", VA = "0x186CAE100")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6CAE160", Offset = "0x6CACB60", VA = "0x186CAE160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public float ELMBFKKEION
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x6CAE880", Offset = "0x6CAD280", VA = "0x186CAE880")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x6CAEA90", Offset = "0x6CAD490", VA = "0x186CAEA90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public bool JDIKAOEJFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x6CAE520", Offset = "0x6CACF20", VA = "0x186CAE520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
	public HMEMHBBGELK(LBMKHNNNCPK GMEDGMJCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE1D0", Offset = "0x6CACBD0", VA = "0x186CAE1D0", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(HMEMHBBGELK CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x6CADEC0", Offset = "0x6CAC8C0", VA = "0x186CADEC0")]
	public void AFFNEPGBNFP(int LKDGGBDDBJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE410", Offset = "0x6CACE10", VA = "0x186CAE410")]
	public bool GEDLMABCIGH([Out] int LKDGGBDDBJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE060", Offset = "0x6CACA60", VA = "0x186CAE060")]
	public void BOHDGDEBDPM(bool LKMFJLIGKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE2C0", Offset = "0x6CACCC0", VA = "0x186CAE2C0")]
	public void GBLDMIKNNKO(float MPHKLHPJEJN, float KFNEAMNANID, float INAGMMCFKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE8E0", Offset = "0x6CAD2E0", VA = "0x186CAE8E0")]
	public void OADLFMCGMGF(float3 AOALCNKMDGB, quaternion GHGCFDOGCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE5C0", Offset = "0x6CACFC0", VA = "0x186CAE5C0")]
	public bool JINFKKMPCMB([Out] float3 AOALCNKMDGB, [Out] quaternion GHGCFDOGCAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE6F0", Offset = "0x6CAD0F0", VA = "0x186CAE6F0")]
	public bool KLFDHHBKNEB([Out] float CEAHHHNJBJG, [Out] float PHDCPGKBBCN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct BDBOOCOGEBJ : IEquatable<BDBOOCOGEBJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly LBMKHNNNCPK NDHGEIKELEB;

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public NMHACHFNADO ILOIGOCAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(NMHACHFNADO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public AJHILEDOPLL FCJKIIMGIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		get
		{
			return default(AJHILEDOPLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	private MIKMJLGOEBN JACABIFDODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5F10", Offset = "0x6CA4910", VA = "0x186CA5F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	private JFDKBKANKAF GGGMHDNOPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x6CA7320", Offset = "0x6CA5D20", VA = "0x186CA7320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public bool ACJBMJDMCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x6CA7110", Offset = "0x6CA5B10", VA = "0x186CA7110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public Vector3 AIFDJMPCLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x6CA6980", Offset = "0x6CA5380", VA = "0x186CA6980")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6CA7570", Offset = "0x6CA5F70", VA = "0x186CA7570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public Quaternion HCLPIOBIAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x6CA7B80", Offset = "0x6CA6580", VA = "0x186CA7B80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x6CA8270", Offset = "0x6CA6C70", VA = "0x186CA8270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public Vector3 MNAPKDBFHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x6CA6DD0", Offset = "0x6CA57D0", VA = "0x186CA6DD0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x6CA6B60", Offset = "0x6CA5560", VA = "0x186CA6B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public Quaternion IHFEKLBPKFH
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x6CA7F50", Offset = "0x6CA6950", VA = "0x186CA7F50")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x6CA7E80", Offset = "0x6CA6880", VA = "0x186CA7E80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public float BNGJEHMADBL
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x6CA7640", Offset = "0x6CA6040", VA = "0x186CA7640")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x6CA8950", Offset = "0x6CA7350", VA = "0x186CA8950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public float PMNNJADHKDG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x6CA7AE0", Offset = "0x6CA64E0", VA = "0x186CA7AE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public Vector3 GNKMAIOMENK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x6CA6890", Offset = "0x6CA5290", VA = "0x186CA6890")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x6CA76E0", Offset = "0x6CA60E0", VA = "0x186CA76E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public Vector3 HKLJBAFGNHI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x6CA86A0", Offset = "0x6CA70A0", VA = "0x186CA86A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public Matrix4x4 BJCFAJPOLJG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x6CA8AA0", Offset = "0x6CA74A0", VA = "0x186CA8AA0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
	public BDBOOCOGEBJ(LBMKHNNNCPK GMEDGMJCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6070", Offset = "0x6CA4A70", VA = "0x186CA6070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7290", Offset = "0x6CA5C90", VA = "0x186CA7290", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5F70", Offset = "0x6CA4970", VA = "0x186CA5F70", Slot = "4")]
	public bool Equals(BDBOOCOGEBJ CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6480", Offset = "0x6CA4E80", VA = "0x186CA6480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8410", Offset = "0x6CA6E10", VA = "0x186CA8410")]
	public FGHMMAJOCCM NALOOBGBMMI()
	{
		return default(FGHMMAJOCCM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7880", Offset = "0x6CA6280", VA = "0x186CA7880")]
	public void HOMLCOGHJKM([Out] Matrix4x4 HELHGEGHHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x6CA73E0", Offset = "0x6CA5DE0", VA = "0x186CA73E0")]
	public void FLKCGKNONAA([Out] Vector3 BLLHPKJKILA, [Out] Quaternion DILDELHDLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x6CA74C0", Offset = "0x6CA5EC0", VA = "0x186CA74C0")]
	public void FLKCGKNONAA([Out] RigidTransform OKJCMGPOAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8B90", Offset = "0x6CA7590", VA = "0x186CA8B90")]
	public void PKFBDBIOCPG([Out] Vector3 BLLHPKJKILA, [Out] Quaternion DILDELHDLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8AE0", Offset = "0x6CA74E0", VA = "0x186CA8AE0")]
	public void PKFBDBIOCPG([Out] RigidTransform OKJCMGPOAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8180", Offset = "0x6CA6B80", VA = "0x186CA8180")]
	public UniformTRS MDCJKEDJFPK()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6CA81B0", Offset = "0x6CA6BB0", VA = "0x186CA81B0")]
	public void MDCJKEDJFPK([Out] UniformTRS GLKOCMNKMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8C70", Offset = "0x6CA7670", VA = "0x186CA8C70")]
	public UniformTRS PMKOGAJGLHH()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8CA0", Offset = "0x6CA76A0", VA = "0x186CA8CA0")]
	public void PMKOGAJGLHH([Out] UniformTRS OKJCMGPOAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8090", Offset = "0x6CA6A90", VA = "0x186CA8090")]
	public Vector3 LHCEOINGLOP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8880", Offset = "0x6CA7280", VA = "0x186CA8880")]
	public void PAMNIEEAHMJ([In] Vector3 IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6A70", Offset = "0x6CA5470", VA = "0x186CA6A70")]
	public Vector3 BBEGOEOMIEO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7040", Offset = "0x6CA5A40", VA = "0x186CA7040")]
	public void BOIFFELPCNB([In] Vector3 IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7150", Offset = "0x6CA5B50", VA = "0x186CA7150")]
	public Quaternion DBFALMEAGEC()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6EC0", Offset = "0x6CA58C0", VA = "0x186CA6EC0")]
	public void BLLOKILOEAA([In] Quaternion IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6CA79A0", Offset = "0x6CA63A0", VA = "0x186CA79A0")]
	public Quaternion IOKAOJOFMKM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8460", Offset = "0x6CA6E60", VA = "0x186CA8460")]
	public void NGCIKFMOMMN([In] Quaternion IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8A00", Offset = "0x6CA7400", VA = "0x186CA8A00")]
	public float PFFFIGMFIOO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6D20", Offset = "0x6CA5720", VA = "0x186CA6D20")]
	public void BCOINEBHLON(float IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8530", Offset = "0x6CA6F30", VA = "0x186CA8530")]
	public float NOOJGBKKIKF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6F90", Offset = "0x6CA5990", VA = "0x186CA6F90")]
	public void BOBOPDJPDKI(float IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7DB0", Offset = "0x6CA67B0", VA = "0x186CA7DB0")]
	public void KLMLCICBBAH([In] Vector3 IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8790", Offset = "0x6CA7190", VA = "0x186CA8790")]
	public Vector3 OFCEIDCHBKH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x6CA85D0", Offset = "0x6CA6FD0", VA = "0x186CA85D0")]
	public void OCDKGKNCGEF([In] Vector3 IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6C30", Offset = "0x6CA5630", VA = "0x186CA6C30")]
	public Vector3 BCCOLFEGPLI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8340", Offset = "0x6CA6D40", VA = "0x186CA8340")]
	public void MNMCJHCGFKJ([In] Vector3 IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7CC0", Offset = "0x6CA66C0", VA = "0x186CA7CC0")]
	public Vector3 KLCBHHLKGDP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6CA77B0", Offset = "0x6CA61B0", VA = "0x186CA77B0")]
	public void HKFEIGIEOMH([In] Vector3 IPHMAHBENGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class EJLADNMPIKH
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private struct LEHGMEBNLBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Guid OKMPNEEAGBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public IINPIMIPDLJ GOJPLCODNOC;
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private struct IINPIMIPDLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int IPHMAHBENGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int GPDFNLNLNDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int JPCACEEEJLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int KIIPDPMAMBP;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x6CAEB00", Offset = "0x6CAD500", VA = "0x186CAEB00")]
		public bool CKJNCDGKOLK([Out] PPCIBOGOOFM OGPFJDHMIGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x6CAEB90", Offset = "0x6CAD590", VA = "0x186CAEB90")]
		public IINPIMIPDLJ(PPCIBOGOOFM OGPFJDHMIGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB030", Offset = "0x6CA9A30", VA = "0x186CAB030")]
	public static Guid AHIACMPJJHM(this PPCIBOGOOFM OGPFJDHMIGP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB0D0", Offset = "0x6CA9AD0", VA = "0x186CAB0D0")]
	public static bool LKFGIMOLLMF(this Guid OKMPNEEAGBI, [Out] PPCIBOGOOFM OGPFJDHMIGP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal static class MEOAABCMGFF
{
	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x6CB35D0", Offset = "0x6CB1FD0", VA = "0x186CB35D0")]
	public static FIFFNHJNCCK MBMKGLOPNPC(this LBMKHNNNCPK DNICIAANFHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3660", Offset = "0x6CB2060", VA = "0x186CB3660")]
	public static CABHEBNIFLN MEOELIIGJDA(this LBMKHNNNCPK DNICIAANFHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3730", Offset = "0x6CB2130", VA = "0x186CB3730")]
	public static EntityManager NIPEMELLCKA(this LBMKHNNNCPK DNICIAANFHD)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2E6CC80", Offset = "0x2E6B680", VA = "0x182E6CC80")]
	public static T NPKHNJICONK<T>(this LBMKHNNNCPK DNICIAANFHD) where T : struct, FIALOONBIKB
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C9C0", Offset = "0x2E6B3C0", VA = "0x182E6C9C0")]
	public static bool GBBJKLEAHGB<T>(this LBMKHNNNCPK DNICIAANFHD) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C910", Offset = "0x2E6B310", VA = "0x182E6C910")]
	public static bool DJDNICEKIBA<T>(this LBMKHNNNCPK DNICIAANFHD) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface CGJEBAEAPGL
{
	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MHFMPNHHPMB(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CENLBOFPMMP(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MLDAKGNEMOE(LBMKHNNNCPK GMEDGMJCEEO, [Out] Guid FAABINMBEKH);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid NMONOCCOCEP(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AIOFIEKGPKP(LBMKHNNNCPK GMEDGMJCEEO, Guid FAABINMBEKH);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KPFCKJNHMID(LBMKHNNNCPK GMEDGMJCEEO, [Out] Guid HEPLADJNIKE);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid IIOLMHOGPAH(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LNLFFNCKKOD(LBMKHNNNCPK GMEDGMJCEEO, Guid HEPLADJNIKE);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EJKLONOGCJC(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task PIJKOKNBDHL(LBMKHNNNCPK PPFEFKBKBLH, LBMKHNNNCPK KMAENCDMJDN);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface NEIELLPNAIP
{
	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	Guid PCODBICPGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDMFPIHBOCK(NativeList<Guid> NKFHAIFEDPI, NativeList<Guid> MKENKKGAFLA, NativeList<FixedString64Bytes> HJKMLNJCDAF);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface MEJIJLAAPOH
{
	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEGMIGAKNPH(List<LBMKHNNNCPK> HIDMOHPNIFH);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DLMJAJBOBHP(List<LBMKHNNNCPK> JMCEIJEPPIK);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BCOPODMHIKJ(LBMKHNNNCPK BEEOIKPJMCJ);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IDOFILMMJJA(LBMKHNNNCPK BEEOIKPJMCJ);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GOFKHCAEABA(LBMKHNNNCPK BEEOIKPJMCJ);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int OIJKNFGKNLJ(LBMKHNNNCPK BEEOIKPJMCJ);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NIGHPKOBCAG(LBMKHNNNCPK BEEOIKPJMCJ, int EKEAKMCADMP);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LBMKHNNNCPK DOHMGPIAGNM(LBMKHNNNCPK NCNCEAKCIMO);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int NDGFGHMDINP(LBMKHNNNCPK NCNCEAKCIMO);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PJEIGDAMPNE(LBMKHNNNCPK NCNCEAKCIMO, int JNKPPINKJBM);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int OMDDKGCLIEE(LBMKHNNNCPK NCNCEAKCIMO);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GPCNNJHLIMH(LBMKHNNNCPK NCNCEAKCIMO, int COMINFCAHGG);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ADEJBELNDOI(LBMKHNNNCPK NDHGEIKELEB);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GIIFNFAMFAH(LBMKHNNNCPK GMEDGMJCEEO, bool NNOBBAILHPK);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NOPNDNNHJPJ(LBMKHNNNCPK[] AOFJCLOAGBF, bool NNOBBAILHPK);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface KPIONGHDHCI
{
	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	IReadOnlyCollection<HKIJLJGOPMH> CGDMGMALMID
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DFDOIGEOHKA(int DFOHIMDHCEM, [Out] HKIJLJGOPMH GKBHCOPNOKD);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HKIJLJGOPMH AMDGCFIJKKF(Type AOGCIMANLIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class KCMCLINGKGO
{
	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x2E00680", Offset = "0x2DFF080", VA = "0x182E00680")]
	public static T EKEDAIFKKGB<T>(this KPIONGHDHCI MMIBAFNJDJA, Entity AFNIOPPCKNG) where T : struct, FIALOONBIKB
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2DFFAB0", Offset = "0x2DFE4B0", VA = "0x182DFFAB0")]
	public static HKIJLJGOPMH AMDGCFIJKKF<T>(this KPIONGHDHCI MMIBAFNJDJA) where T : struct, FIALOONBIKB
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface NKFPHNDHHPF
{
	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PPCIBOGOOFM[] MPICIFJKGEI(string DDDMPLCOGIM, NMHACHFNADO MPCODCGFHCE, bool DMKLGDMAPKG = false);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KDKLIBBCOFG(string JHNHANNFJPH, PPCIBOGOOFM[] JFPHLGMDCNK);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface KHHOHOFHBIL
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<LBMKHNNNCPK, LBMKHNNNCPK> NEMIEDOHDGJ;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<LBMKHNNNCPK, LBMKHNNNCPK> IEAIAKGAEGE;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<LBMKHNNNCPK, LBMKHNNNCPK, LBMKHNNNCPK> PEGHAJEEHJN;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<LBMKHNNNCPK> NIANPJDCLOA;

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CCMBGHDFFPL(LBMKHNNNCPK GMEDGMJCEEO, LBMKHNNNCPK LHBBGMKOKEP);

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LBMKHNNNCPK NONEHGINFDC(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<LBMKHNNNCPK> DMLDBEBGBKP(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LBMKHNNNCPK KACNJEFGFII(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PLFGEDFPKIH(LBMKHNNNCPK GMEDGMJCEEO, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OJIEDIAMPFG(LBMKHNNNCPK GMEDGMJCEEO, float EOPFFPFBBDA);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool JMPNFIOCKEG(LBMKHNNNCPK GMEDGMJCEEO, [Out] LBMKHNNNCPK KMAENCDMJDN);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool MAHFHEGFNPJ(LBMKHNNNCPK GMEDGMJCEEO, [Out] RigidTransform FMCJBCBKFFC);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool OKBHAPIBHMI(LBMKHNNNCPK GMEDGMJCEEO, [Out] float NNFOIGCPMLO);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 PBCIHNHGNGB(CLKALMIKKIG EAPGILEBPPH);

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "18")]
	quaternion PMEPMHHEHHO(CLKALMIKKIG EAPGILEBPPH);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class KLFIOANBMNP
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface BEPELBPKCEE
{
	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	object NIJKIHHKMOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IFBDFPHEGDL(ECKJADHBOIC AOFJCLOAGBF);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct JDGPBCLJPOC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly string DDDMPLCOGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly T FABNMHPKJIP;

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x42761B0", Offset = "0x4274BB0", VA = "0x1842761B0")]
	public JDGPBCLJPOC(T FABNMHPKJIP, [Optional][CallerMemberName] string DDDMPLCOGIM)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public static readonly JDGPBCLJPOC<int> GGLHIHEBBBM;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public enum MBHEMOMJBKA
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public static class NPLDOJDANJD
{
	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0xFC22E0", Offset = "0xFC0CE0", VA = "0x180FC22E0")]
	public static bool IMGNOLIODMB(this MBHEMOMJBKA PFFGBBPKGJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0xFC22F0", Offset = "0xFC0CF0", VA = "0x180FC22F0")]
	public static bool KJJHMHDKFGH(this MBHEMOMJBKA PFFGBBPKGJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x26DD900", Offset = "0x26DC300", VA = "0x1826DD900")]
	public static bool PCAHLDGMHHB(this MBHEMOMJBKA PFFGBBPKGJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface HMICOAHDACB
{
	[Cpp2IlInjected.Token(Token = "0x17000180")]
	bool BBJGLJFEGFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface GLCEODGDPDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000181")]
	MBHEMOMJBKA ONMEJLHDDPE
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	MBHEMOMJBKA HNCMOJOADMF
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	MBHEMOMJBKA LGMKCBFJFDH
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	MBHEMOMJBKA DEDCKIOEEPD
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	MBHEMOMJBKA DOPNPBDLFJO
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	MBHEMOMJBKA LPECMMDJLIC
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	MBHEMOMJBKA HFIHJOPLMPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	MBHEMOMJBKA IBMKBEBPOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	MBHEMOMJBKA BCLMAGMAPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	MBHEMOMJBKA GPAPIEFLODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	MBHEMOMJBKA ODAOCENHGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	MBHEMOMJBKA ANKMDNBOFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	MBHEMOMJBKA MAOIHFLEPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	MBHEMOMJBKA NLJFCCEJNGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	MBHEMOMJBKA DPHBCNMMNKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	MBHEMOMJBKA PMBFLGAPLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GJMIFHLLDMF(JDGPBCLJPOC<int> EILKMNJGOBA);
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface LMKIIMOLCHA
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event KDFGDLOCEMI.OAPAAAJKPIO OBBONOHKDOA;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LBMKHNNNCPK FOMDNOCIPAN(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MPIFGLPDLPC(List<LBMKHNNNCPK> JMCEIJEPPIK);

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JEPGGBIAAIP DGOIAPINBCM(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MHEHPCCCLKC(IEnumerable<LBMKHNNNCPK> MCOHEBKKCFC);

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JEPGGBIAAIP KECIKPDGEPP(LBMKHNNNCPK KMAENCDMJDN, LBMKHNNNCPK EEBGELKKKEJ, bool KNMHBNJMIMI, LBMKHNNNCPK CDHECNAFHCH);

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LBMKHNNNCPK DLBCCIGLBHE(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NJPHAMCIKMD(LBMKHNNNCPK GMEDGMJCEEO, LBMKHNNNCPK KMAENCDMJDN, bool GALIBFNBNCO);

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool ELGBILHHKEB(LBMKHNNNCPK GMEDGMJCEEO, LBMKHNNNCPK KMAENCDMJDN);

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool PMPCAKEIALM(LBMKHNNNCPK ALFGCNFOHAC, LBMKHNNNCPK DEJGIIBCLKF);

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int BIGCJCJNNBI(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "12")]
	ECKJADHBOIC OLMHLHJAOKE(LBMKHNNNCPK NDHGEIKELEB);

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<LBMKHNNNCPK> AKEAGMEEBON(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool MHKNFIJANMD(LBMKHNNNCPK GMEDGMJCEEO, LBMKHNNNCPK JDHPHILMCGD);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IEnumerable<LBMKHNNNCPK> MGCHHLJKAPF(LBMKHNNNCPK GMEDGMJCEEO, bool EJOPFPJDLAK = false);

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool IEPMHFBNFHL(LBMKHNNNCPK GMEDGMJCEEO, LBMKHNNNCPK MODBHFMJGIB);

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	LBMKHNNNCPK JFEHBCEDIIL(LBMKHNNNCPK CDHECNAFHCH, LBMKHNNNCPK ELNCJBBNJEP);

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool CIBPIELMOPA(LBMKHNNNCPK CDHECNAFHCH, LBMKHNNNCPK ELNCJBBNJEP, [Out] LBMKHNNNCPK FPFDKFILPEJ);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class ENAGLMHBFJC
{
	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB650", Offset = "0x6CAA050", VA = "0x186CAB650")]
	public static List<LBMKHNNNCPK> MPIFGLPDLPC(this LMKIIMOLCHA CKMLNLJIJOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB5E0", Offset = "0x6CA9FE0", VA = "0x186CAB5E0")]
	public static bool MHCELDGENCE(this LMKIIMOLCHA CKMLNLJIJOM, LBMKHNNNCPK GMEDGMJCEEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface NKGMMLAHCIG
{
	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BKHMLAEEIKH PCLBNHBAFOA(LBMKHNNNCPK BEEOIKPJMCJ);

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LMEAOBOBOCK(LBMKHNNNCPK BEEOIKPJMCJ, BKHMLAEEIKH CIBCIEIMJNA);

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BHIHKKDOHKG(LBMKHNNNCPK BEEOIKPJMCJ);

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KJEFPJNHLLL(LBMKHNNNCPK BEEOIKPJMCJ, bool IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string[] OGINCAPMFKI(LBMKHNNNCPK BEEOIKPJMCJ);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KMBOFHMKOCP(LBMKHNNNCPK BEEOIKPJMCJ, IEnumerable<string> CMLOGHHHANB);

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string[] JGBJECAHMLA(LBMKHNNNCPK BEEOIKPJMCJ);

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HIPDBMGLHDO(LBMKHNNNCPK BEEOIKPJMCJ, IEnumerable<string> CMLOGHHHANB);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "8")]
	string[] BLBPKKLHLAF(LBMKHNNNCPK BEEOIKPJMCJ);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JCKKMPJHKMP(LBMKHNNNCPK BEEOIKPJMCJ, IEnumerable<string> CMLOGHHHANB);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string[] EOLLEFNNCID(LBMKHNNNCPK BEEOIKPJMCJ);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BFGMBPCGHOC(LBMKHNNNCPK BEEOIKPJMCJ, IEnumerable<string> CMLOGHHHANB);

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool AMINFADMNOD(LBMKHNNNCPK BEEOIKPJMCJ, LBMKHNNNCPK DBKPGAEGHAD);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface CHIDGKIFKBN
{
	[Cpp2IlInjected.Token(Token = "0x17000191")]
	bool BNKEMBEECCD
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	bool NNJDAIEBKIF
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	bool GADFKLAGCFP
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface EPHIFMJMAGK : DFDDBFPCEHO
{
	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LOKPPMCFLIL(Entity AFNIOPPCKNG, [Out] AOBLBKKPALO DKMIJDPJCBM);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ENAEHHOGBJP(NativeArray<AOBLBKKPALO> MBFKMAJIOBB, NativeArray<ANCIAFGMNMH> OBOMBLGEGIE);

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LKDCLKNHKBJ(AOBLBKKPALO DKMIJDPJCBM);

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CJNFNONDICI(AOBLBKKPALO DKMIJDPJCBM, [Out] Collider CFMHFMLEKHC);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface DFDDBFPCEHO
{
	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AAOFHEELBKN([In] float3 AAJPOGDAOAO, [In] float3 FJODMBFILLK, float PEAKDEKJAOG, Allocator MPFEIGMBFCP, [Out] NativeArray<Entity> NLHOBFOIDFG);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface OIIFCDGJLKK
{
	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AAOFHEELBKN([In] float3 AAJPOGDAOAO, [In] float3 FJODMBFILLK, float PEAKDEKJAOG, [Out] JKFFIJAGKMO KOOLNHKOPEG, [Out] LBMKHNNNCPK DOOOLJJPPKH);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface JGMEDCEBDAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAOFHEELBKN([In] NativeArray<Entity> NLHOBFOIDFG, [In] float3 AAJPOGDAOAO, [In] float3 FJODMBFILLK, [In] NativeArray<JKFFIJAGKMO> PMELAHHDFED);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct AOBLBKKPALO : JEDKKJGHJPP, IEquatable<AOBLBKKPALO>
{
	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public int BDIPFIAMOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x9FE7F0", Offset = "0x9FD1F0", VA = "0x1809FE7F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xBAA9E0", Offset = "0xBA93E0", VA = "0x180BAA9E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public int PCGHHNFLFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x26E9F30", Offset = "0x26E8930", VA = "0x1826E9F30", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x5F64670", Offset = "0x5F63070", VA = "0x185F64670", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x6CA67F0", Offset = "0x6CA51F0", VA = "0x186CA67F0", Slot = "8")]
	public bool Equals(AOBLBKKPALO CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6840", Offset = "0x6CA5240", VA = "0x186CA6840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct JKFFIJAGKMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float BBFEANEOPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float3 MLNCIIKLLEK;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface FBDEOGNKHMC
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface MIKMJLGOEBN
{
	[Cpp2IlInjected.Token(Token = "0x17000196")]
	FIFFNHJNCCK MBMKGLOPNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	AEPMPJBOJMJ CCBBGFHNMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<ECKJADHBOIC, NativeArray<ADNGPIOLLLA>> EPLEMNGAAJE;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<ECKJADHBOIC> LGAPCGGIPAK;

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JMLDBJLEEAH KFAMAMDHCCA(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ADNGPIOLLLA BOBKLLGODJL(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FBIMIMMHNIB(PPCIBOGOOFM OGPFJDHMIGP, EHBJCKAPCDI GFOCHBOMMIG);

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NHFEMNCJCFA(PPCIBOGOOFM[] JFPHLGMDCNK, GameObject BICFCMICGIH);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NMHACHFNADO IHJKEBCHIED(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool GDKHPHEJJEL(LBMKHNNNCPK GMEDGMJCEEO, [Out] Transform ICGEMCDDICC);

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GIPDPCDBIMP(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FHACMOHJAFM(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	LBMKHNNNCPK EFFCLNDPHJA(PPCIBOGOOFM OGPFJDHMIGP);

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool NFECJBFLEAH(PPCIBOGOOFM OGPFJDHMIGP, [Out] LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	PPCIBOGOOFM EIAGHHJDOAM(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	LocalId JKKPPLFEFKM(LocalId LEBKMGBPBLL);

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	ECKJADHBOIC EFFCLNDPHJA(NativeArray<PPCIBOGOOFM> OGPFJDHMIGP, Allocator MPFEIGMBFCP);

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	ECKJADHBOIC JOHCEIHLBJG(ADNGPIOLLLA NLMEGDEGAEA, int CMNDBGDABDM, Allocator MPFEIGMBFCP);

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "20")]
	ECKJADHBOIC LLNFJFIALCI(NativeArray<PPCIBOGOOFM> OGPFJDHMIGP, NativeArray<PJJFGNPGFAJ> PNEDDAGLINP, Allocator MPFEIGMBFCP);

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "21")]
	PPCIBOGOOFM[] MPICIFJKGEI(string JHNHANNFJPH, NMHACHFNADO MPCODCGFHCE, bool DMKLGDMAPKG);

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KDKLIBBCOFG(string JHNHANNFJPH, PPCIBOGOOFM[] JFPHLGMDCNK);

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "23")]
	NMHACHFNADO EONFGEMDPIM(ADNGPIOLLLA NLMEGDEGAEA, bool MPHILGCNNJF);

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "24")]
	NMHACHFNADO EONFGEMDPIM(ADNGPIOLLLA NLMEGDEGAEA);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "25")]
	NMHACHFNADO DGMMBPBFOBG(ADNGPIOLLLA NLMEGDEGAEA);

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(Slot = "26")]
	NMHACHFNADO DPPCNLAFOBE(ADNGPIOLLLA NLMEGDEGAEA);

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "27")]
	NMHACHFNADO CGAONJHBNLM(PPCIBOGOOFM OGPFJDHMIGP, ADNGPIOLLLA NLMEGDEGAEA);

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "28")]
	KGPIHFGABOG IDFOBCHNBHF();

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "29")]
	PFJNJPAKKAJ ELHEDNBNIGM();

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "30")]
	NOFKILLLHIG CCAJPBNPOBF(NIGNKOFGHHP OPDIDHKOPJD);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void LEMLOFPKIAG(ECKJADHBOIC AOFJCLOAGBF);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void MOGENANDEFO(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void FDKMPNBFHPP(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void LEMLOFPKIAG(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void LIOGFOAAEHI(LBMKHNNNCPK AOFJCLOAGBF);

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "36")]
	bool IOGKIEMEAFN(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "37")]
	ECKJADHBOIC EFOIAJIJKIH(ECKJADHBOIC PLADPMICPKC, Allocator MPFEIGMBFCP);

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool GHBEHEKGDOG(LBMKHNNNCPK GMEDGMJCEEO);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class LKBJDBDMHBN
{
	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2B10", Offset = "0x6CB1510", VA = "0x186CB2B10")]
	public static void FHACMOHJAFM(this MIKMJLGOEBN MGHIMHACJJP, EHBJCKAPCDI GFOCHBOMMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2A60", Offset = "0x6CB1460", VA = "0x186CB2A60")]
	public static NMHACHFNADO NDFGALCMJGG(this MIKMJLGOEBN MGHIMHACJJP, LocalId GMEDGMJCEEO)
	{
		return default(NMHACHFNADO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2EF0", Offset = "0x6CB18F0", VA = "0x186CB2EF0")]
	public static NMHACHFNADO NDFGALCMJGG(this MIKMJLGOEBN MGHIMHACJJP, PPCIBOGOOFM OGPFJDHMIGP)
	{
		return default(NMHACHFNADO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2A60", Offset = "0x6CB1460", VA = "0x186CB2A60")]
	public static LBMKHNNNCPK EFFCLNDPHJA(this MIKMJLGOEBN MGHIMHACJJP, LocalId GMEDGMJCEEO)
	{
		return default(LBMKHNNNCPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2A90", Offset = "0x6CB1490", VA = "0x186CB2A90")]
	public static PPCIBOGOOFM EIAGHHJDOAM(this MIKMJLGOEBN MGHIMHACJJP, LocalId GMEDGMJCEEO)
	{
		return default(PPCIBOGOOFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2B90", Offset = "0x6CB1590", VA = "0x186CB2B90")]
	public static bool GHBEHEKGDOG(this MIKMJLGOEBN MGHIMHACJJP, PPCIBOGOOFM OGPFJDHMIGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x2E51EA0", Offset = "0x2E508A0", VA = "0x182E51EA0")]
	public static T PLMNALMPNEK<T>(this MIKMJLGOEBN MGHIMHACJJP, LocalId GMEDGMJCEEO) where T : struct, FIALOONBIKB
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2F50", Offset = "0x6CB1950", VA = "0x186CB2F50")]
	public static KGPIHFGABOG PEBEIDBEMHB(this MIKMJLGOEBN MGHIMHACJJP, RigidTransform GLKOCMNKMNE)
	{
		return default(KGPIHFGABOG);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3040", Offset = "0x6CB1A40", VA = "0x186CB3040")]
	public static NOFKILLLHIG PJMJBFDFGBL(this MIKMJLGOEBN MGHIMHACJJP, NIGNKOFGHHP HLGGOGKBNMG, RigidTransform GLKOCMNKMNE)
	{
		return default(NOFKILLLHIG);
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2E00", Offset = "0x6CB1800", VA = "0x186CB2E00")]
	public static PFJNJPAKKAJ KKHPBGAJJBD(this MIKMJLGOEBN MGHIMHACJJP, RigidTransform GLKOCMNKMNE)
	{
		return default(PFJNJPAKKAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2C00", Offset = "0x6CB1600", VA = "0x186CB2C00")]
	private static void HICKOIBIPMJ(NMHACHFNADO JBJNKEPBIKI, RigidTransform GLKOCMNKMNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface HMMGCDHAEBI
{
	[Cpp2IlInjected.Token(Token = "0x17000198")]
	bool KCCMLKDMCDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	LBMKHNNNCPK CPECMKFPPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	NMHACHFNADO HIAHONAOLMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event FHNIKIJHKIB OMEDCIJBJNL;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LBMKHNNNCPK JFEHBCEDIIL(LBMKHNNNCPK CDHECNAFHCH, LBMKHNNNCPK ELNCJBBNJEP);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CIBPIELMOPA(LBMKHNNNCPK CDHECNAFHCH, LBMKHNNNCPK ELNCJBBNJEP, [Out] LBMKHNNNCPK FPFDKFILPEJ);

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NNDDAKCFBIC();

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IIEMKMHMOFL();

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IIECNNENNLE(LBMKHNNNCPK CDHECNAFHCH);

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool PNEJIOCJHIC(LBMKHNNNCPK CDHECNAFHCH);
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public delegate void FHNIKIJHKIB(NMHACHFNADO NPDCKAMCLOF, NMHACHFNADO BGPHAGAOEOM);
[Cpp2IlInjected.Token(Token = "0x200008B")]
public static class IJBAFILJBEH
{
	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6CAED30", Offset = "0x6CAD730", VA = "0x186CAED30")]
	public static bool ODFABGOAIHM(this HMMGCDHAEBI EAJJPNKNOKO, NMHACHFNADO CDHECNAFHCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6CAEBD0", Offset = "0x6CAD5D0", VA = "0x186CAEBD0")]
	public static bool FGFKNBEOFCM(this HMMGCDHAEBI EAJJPNKNOKO, LBMKHNNNCPK CDHECNAFHCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x6CAECB0", Offset = "0x6CAD6B0", VA = "0x186CAECB0")]
	public static bool MECODCCHAOA(this HMMGCDHAEBI EAJJPNKNOKO, LBMKHNNNCPK CDHECNAFHCH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface BGJLPGJHEDM
{
	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FFIENLPLFNN(NMHACHFNADO JBJNKEPBIKI, NAKOJNDAOID CJJFHMMBLHB, List<NMHACHFNADO> KDEIPJICKNJ);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int DAACMGDLLNE(NMHACHFNADO JBJNKEPBIKI, NAKOJNDAOID CJJFHMMBLHB);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HBNGFPDKPOJ(NMHACHFNADO JBJNKEPBIKI, List<NMHACHFNADO> KDEIPJICKNJ);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int COKCFNJBHFI(NMHACHFNADO LKDGGBDDBJM, NMHACHFNADO CDHECNAFHCH, NAKOJNDAOID CJJFHMMBLHB);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NMHACHFNADO KIDCEHFIGOM(NMHACHFNADO LKDGGBDDBJM, int ENMILGHAHOM, NAKOJNDAOID CJJFHMMBLHB);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OAEDNFEODPG(NMHACHFNADO LKDGGBDDBJM, NMHACHFNADO CDHECNAFHCH, NAKOJNDAOID CJJFHMMBLHB);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NIGFOCNLMPO(NMHACHFNADO LKDGGBDDBJM, NMHACHFNADO CDHECNAFHCH, NAKOJNDAOID CJJFHMMBLHB);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ODCACIPBBFN(NMHACHFNADO LKDGGBDDBJM, NAKOJNDAOID CJJFHMMBLHB);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KJHNJIBBPPB(NMHACHFNADO LKDGGBDDBJM, NMHACHFNADO CDHECNAFHCH, NAKOJNDAOID CJJFHMMBLHB);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IFFKHMDHFHB(Entity LKDGGBDDBJM, Entity CDHECNAFHCH, NAKOJNDAOID CJJFHMMBLHB);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AMIPBNCCPJH(Entity LKDGGBDDBJM, NAKOJNDAOID CJJFHMMBLHB);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool BMCIFFODCIE(NMHACHFNADO CDHECNAFHCH, NAKOJNDAOID CJJFHMMBLHB);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface JJBJNFACMIG
{
	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MMAIOOFBFJB(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KNKGNKKEMMN(LBMKHNNNCPK GMEDGMJCEEO, Transform ICGEMCDDICC);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface PADLCAJDGFM
{
	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KPBCDJLIGNH(LBMKHNNNCPK CDHECNAFHCH, LBMKHNNNCPK KMLNHJDFBDB);

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NBFAMILGOBK(LBMKHNNNCPK CDHECNAFHCH, LBMKHNNNCPK HFEPEPGFIAM);

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GFCMFHENAKE(LBMKHNNNCPK CDHECNAFHCH, [Out] LBMKHNNNCPK KAPMJGOAEMF);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface POFICOKCLNC
{
	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HJFDFHJHIKO(LBMKHNNNCPK NDHGEIKELEB, bool IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NMFNPDPIBGN(LBMKHNNNCPK NDHGEIKELEB, bool IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HJDPNBGCLIJ(LBMKHNNNCPK NDHGEIKELEB, int IPHMAHBENGI);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface PDBGALDEFLB
{
	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<LBMKHNNNCPK> POBIDGPAGLL(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LBMKHNNNCPK GPJALOJPJFO(LBMKHNNNCPK GMEDGMJCEEO, int ENMILGHAHOM);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int EPEIHMBCFJN(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GDJKHIELFIH GDELICCNDMF(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MDGPHDBOHIK(LBMKHNNNCPK GMEDGMJCEEO, GDJKHIELFIH LFOFLLOHBIA);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LBMKHNNNCPK ACAOHLBJGPN(LBMKHNNNCPK GMEDGMJCEEO, [Optional] float3? EJEBFMEPKGF, [Optional] quaternion? PCIAHIPKDFG, [Optional] float3? FCFDEHNOPJK);

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LBMKHNNNCPK MJPIFDFJMOK(LBMKHNNNCPK GMEDGMJCEEO, int ENMILGHAHOM, [Optional] float3? EJEBFMEPKGF, [Optional] quaternion? PCIAHIPKDFG, [Optional] float3? FCFDEHNOPJK);

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AJMKOHMANII(LBMKHNNNCPK GMEDGMJCEEO, int ENMILGHAHOM);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MACFLFGPANL(LBMKHNNNCPK GMEDGMJCEEO);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface ALAKNGJHMBC
{
	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFKODPEJKMO();

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMIHILKAMPJ();

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AAFEIAPBKKJ();

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CIMNKPCKKND();

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PGKBPEJPHNC();

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CCCCDFCFGJN();

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HOCEDKIOLPI();

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JOKFNBOCNLO();

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ANJFFDFMCCG();

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PKDNCNEBDLC();

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void POODOJOJCGI();

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BEKMAENNBCG();

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IFDNOCOEAIF();
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface FIEKMEKJLHL
{
	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GEDLMABCIGH(LBMKHNNNCPK CDHECNAFHCH, [Out] int LKDGGBDDBJM);

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFFNEPGBNFP(LBMKHNNNCPK CDHECNAFHCH, int LKDGGBDDBJM);

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CLABFILACOH(LBMKHNNNCPK CDHECNAFHCH, bool MPFEOFHFNBC);

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BOHDGDEBDPM(LBMKHNNNCPK CDHECNAFHCH, bool LKMFJLIGKMI);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GBLDMIKNNKO(LBMKHNNNCPK CDHECNAFHCH, float MPHKLHPJEJN, float KFNEAMNANID, float INAGMMCFKIB);

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KLFDHHBKNEB(LBMKHNNNCPK GMEDGMJCEEO, [Out] float KFNEAMNANID, [Out] float INAGMMCFKIB);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OADLFMCGMGF(LBMKHNNNCPK CDHECNAFHCH, float3 EJEBFMEPKGF, quaternion PCIAHIPKDFG);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool JINFKKMPCMB(LBMKHNNNCPK CDHECNAFHCH, [Out] float3 EJEBFMEPKGF, [Out] quaternion PCIAHIPKDFG);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface JFDKBKANKAF
{
	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHHPBECKEGL(Entity AFNIOPPCKNG);

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PAMNIEEAHMJ(Entity AFNIOPPCKNG, [In] float3 IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 LHCEOINGLOP(Entity AFNIOPPCKNG);

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BLLOKILOEAA(Entity AFNIOPPCKNG, [In] quaternion IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion DBFALMEAGEC(Entity AFNIOPPCKNG);

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HMCPMCAILIJ(Entity AFNIOPPCKNG, [In] float3 EJEBFMEPKGF, [In] quaternion PCIAHIPKDFG);

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FLKCGKNONAA(Entity AFNIOPPCKNG, [Out] float3 EJEBFMEPKGF, [Out] quaternion PCIAHIPKDFG);

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FLKCGKNONAA(Entity AFNIOPPCKNG, [Out] RigidTransform LHPJEBPEIHG);

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PKFBDBIOCPG(Entity AFNIOPPCKNG, [Out] float3 EJEBFMEPKGF, [Out] quaternion PCIAHIPKDFG);

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PKFBDBIOCPG(Entity AFNIOPPCKNG, [Out] RigidTransform LHPJEBPEIHG);

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float3 MHNMALJNFID(Entity AFNIOPPCKNG);

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KLMLCICBBAH(Entity AFNIOPPCKNG, [In] float3 IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BCOINEBHLON(Entity AFNIOPPCKNG, float IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float PFFFIGMFIOO(Entity AFNIOPPCKNG);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MNMCJHCGFKJ(Entity AFNIOPPCKNG, [In] float3 IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 BCCOLFEGPLI(Entity AFNIOPPCKNG);

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BOIFFELPCNB(Entity AFNIOPPCKNG, [In] float3 IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 BBEGOEOMIEO(Entity AFNIOPPCKNG);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NGCIKFMOMMN(Entity AFNIOPPCKNG, [In] quaternion IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "19")]
	quaternion IOKAOJOFMKM(Entity AFNIOPPCKNG);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 OFCEIDCHBKH(Entity AFNIOPPCKNG);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void OCDKGKNCGEF(Entity AFNIOPPCKNG, [In] float3 IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BOBOPDJPDKI(Entity AFNIOPPCKNG, float IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float NOOJGBKKIKF(Entity AFNIOPPCKNG);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void HKFEIGIEOMH(Entity AFNIOPPCKNG, [In] float3 IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float3 KLCBHHLKGDP(Entity AFNIOPPCKNG);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void PCPMJIFLIPJ(Entity AFNIOPPCKNG, [Out] float4x4 HELHGEGHHJI);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DHCCGLEJDCB(Entity AFNIOPPCKNG, [In] float4x4 HELHGEGHHJI);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void EAKKCJLIIOH(Entity AFNIOPPCKNG, [Out] float4x4 HELHGEGHHJI);

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool GDKHPHEJJEL(Entity AFNIOPPCKNG, [Out] Transform ICGEMCDDICC);

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void KJMCBMKPAFI(Entity AFNIOPPCKNG);

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void FCDENKEANAB(Entity AFNIOPPCKNG, Entity CJNGOIMNLJM, Entity AAJANANFHLN);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class DAJACAICJIB
{
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface KLFKGMMIEHM
{
	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DKMFKENBEAP(bool ELHHPBLDOIH);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface FPGKBMBDPMK
{
	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BDODKBBJINJ(LBMKHNNNCPK BEEOIKPJMCJ, IEnumerable<string> CMLOGHHHANB);

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IFGGFBNDIBG(LBMKHNNNCPK BEEOIKPJMCJ, IEnumerable<string> CMLOGHHHANB);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BENENFJIKKL(LBMKHNNNCPK BEEOIKPJMCJ, params string[] CMLOGHHHANB);

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void APKPDHCKMHK(LBMKHNNNCPK BEEOIKPJMCJ, params string[] CMLOGHHHANB);

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FAGCLEJEEEL(LBMKHNNNCPK BEEOIKPJMCJ, params string[] CMLOGHHHANB);

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MLAOJPAHADJ(LBMKHNNNCPK BEEOIKPJMCJ, params string[] CMLOGHHHANB);

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int IBDCOHABCAK(LBMKHNNNCPK BEEOIKPJMCJ);

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int KFDLJJIBHIA(LBMKHNNNCPK BEEOIKPJMCJ);

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KKKIPFJFKOH(LBMKHNNNCPK BEEOIKPJMCJ, ICollection<string> HIIAACMLODE);

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PHLOIGHFPBO(LBMKHNNNCPK BEEOIKPJMCJ, ICollection<string> HIIAACMLODE);

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool JBENJNOAGNK(LBMKHNNNCPK BEEOIKPJMCJ, string EEIDNNLIIHD);

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LBLKGCCNNKB(string EEIDNNLIIHD, FIGOJKPGIIP FKGPAHOIGGM);

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OBGBOAIAOEH(string EEIDNNLIIHD, FIGOJKPGIIP FKGPAHOIGGM);

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool BFKGEPGDDGK();

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IGGNHAKPOJI(IEnumerable<string> CMLOGHHHANB);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface OODNHGJGJGN
{
	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World HPCFNNLEPMA(string OOECNEEFLPM = "Main");

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World JNPKPLICGGN(string OOECNEEFLPM = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World EAGNINPCAJH(string OOECNEEFLPM = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World LHBBLMMFPGD(string OOECNEEFLPM = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface CABHEBNIFLN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	World AHFAHKLHIEH
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	World KILKGDFPANP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	EntityManager NIPEMELLCKA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	bool LOJKAIEMICI
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase GIGOHCCCFMK(Type AOGCIMANLIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class CINOLOBMNAK
{
	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9540", Offset = "0x6CA7F40", VA = "0x186CA9540")]
	public static ComponentSystemBase MMIJDCIJNOD(this World OBOIAEHHCBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x2B59DC0", Offset = "0x2B587C0", VA = "0x182B59DC0")]
	public static T GIGOHCCCFMK<T>(this CABHEBNIFLN OCFLDFFGPHE) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface MBAJOJNBPCB
{
	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLKNHEOJNNE(NativeListAsync<Entity> HCGBAIKLADF);

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CMFAGKPNPBI(EAMENLPPBCA IKBAJFJAAAG);

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JMJOFKMLJPC(NativeListAsync<Entity> CBACPBPPJLE, bool DLKDKMCEBDP);

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OKBHBNCFDCO();
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface OJMIDDPILBF
{
	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJLAIGIIAJM(Collider CFMHFMLEKHC, [Out] BDJIMJLHAMG GGGKLAHGKOD);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface ODNMACJAAPN
{
	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GKGIFEILPKG(LBMKHNNNCPK GMEDGMJCEEO, [Out] Collider CFMHFMLEKHC);

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject BCJKMOHMLAE(LBMKHNNNCPK EOBJCKBGGFN, GameObject IGOFBEPEIGI, Vector3 BJDMPNAKILN, Quaternion GPDCENANAMK);

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LIOAAKOEEPC(GameObject CFMHFMLEKHC);

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider MEEPFEDFMNF<TCollider>(GameObject BKOODODDGCL) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JNGBACDIJHG(Collider CFMHFMLEKHC);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject JNLKBFAKLDF<TCollider>(string DDDMPLCOGIM) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public enum CMMJGEPFHCI
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
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface PEILJIBCKEN
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public struct MPKIEMFEGLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int OHFCIEJHAHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GameObject IGOFBEPEIGI;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OBJBFMBCBLH(LBMKHNNNCPK GMEDGMJCEEO, CMPAOPHFPKI FNMEJBJLAOC, bool KBFNMLADDNK, PCKDAGNPJNH BFNMMLLBLMO);

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMHJPFJHBCF(LBMKHNNNCPK GMEDGMJCEEO, CMPAOPHFPKI FNMEJBJLAOC, bool KBFNMLADDNK, bool GCMJGLKEODM, bool OKFCOBBDAIH);

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IPHNMELIAEK JPEBOLKKALD(LBMKHNNNCPK BAFHJDFHJHD, List<LBMKHNNNCPK> HIDEHFOJNCG);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IINAPCFFMPK(GameObject DOHHBOALNFP, GameObject OCMFLHLHAON);

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NOILDKCFDNH(GameObject DOHHBOALNFP, List<GameObject> GNGALHECAJA);

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HHJJAPPGENG(GameObject OCMFLHLHAON);

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T MEEPFEDFMNF<T>(GameObject BKOODODDGCL) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JNGBACDIJHG(Collider CFMHFMLEKHC);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LDKMGEGIMOF(ECKJADHBOIC GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LHJFLACBOJG(ECKJADHBOIC GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GameObject OIANAFJBMOK<T>(string DDDMPLCOGIM) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool GHDMJLPBLOO(Collider CFMHFMLEKHC, [Out] LBMKHNNNCPK LKDGGBDDBJM);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool OGFLGKDAJLK(LBMKHNNNCPK GMEDGMJCEEO, [Out] BDJIMJLHAMG GGGKLAHGKOD);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NativeArray<CMMJGEPFHCI> JMCCKHGJLMJ(Allocator MPFEIGMBFCP = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Mesh[] PKAOLKANHEH();

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int ANJEMKKDHKH(CMPAOPHFPKI FNMEJBJLAOC);

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string JCBMMIPDCOE(CMPAOPHFPKI FNMEJBJLAOC);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface MBABLMLFDNI
{
	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBLGBIHLLBM(LBMKHNNNCPK GMEDGMJCEEO, LBMKHNNNCPK IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMHGNMEIMPN(LBMKHNNNCPK GMEDGMJCEEO, LBMKHNNNCPK IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int BIGCJCJNNBI(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LBMKHNNNCPK LNHPKHIMEPL(LBMKHNNNCPK GMEDGMJCEEO, int ENMILGHAHOM);

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ECKJADHBOIC BNAOODBCEJH(LBMKHNNNCPK GMEDGMJCEEO, Allocator MPFEIGMBFCP = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LFMLLOKFGIJ(LBMKHNNNCPK GMEDGMJCEEO, object OEELDHBFFAF, LBMKHNNNCPK IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FBLNKDJMOLJ(LBMKHNNNCPK GMEDGMJCEEO, object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MJOKELEHMPK(LBMKHNNNCPK GMEDGMJCEEO, [Out] LBMKHNNNCPK IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MEIOFDLLKMG(LBMKHNNNCPK GMEDGMJCEEO, float3 IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool DABINIJOOKE(LBMKHNNNCPK GMEDGMJCEEO, [Out] float3 IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GJPPEEMJHPL(LBMKHNNNCPK GMEDGMJCEEO, float3 IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool HDPFACFIFAK(LBMKHNNNCPK GMEDGMJCEEO, [Out] float3 IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NJBCEMOMBJE(LBMKHNNNCPK GMEDGMJCEEO, (Quaternion rot, Vector3 moments) KEAIEABHOPH);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool IKLDCNPLBHI(LBMKHNNNCPK GMEDGMJCEEO, [Out] quaternion GNJAOBEFJHH, [Out] float3 EFPDPEDMEJN);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JOAHDNHKBPB(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 BLDFHCIPGFL(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 MJNBAMNMMHJ(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IHOJECKMKJF(LBMKHNNNCPK GMEDGMJCEEO, float3 IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NOKJMGGANNF(LBMKHNNNCPK GMEDGMJCEEO, float3 IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float JAPJOKCCBNL(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float LDFKCHOBBCF(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void JJKIEJELDLL(LBMKHNNNCPK GMEDGMJCEEO, float IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GDLDGDBAILG(LBMKHNNNCPK GMEDGMJCEEO, float IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode ENHFGNCPDFD(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LKJECBKEOEC(LBMKHNNNCPK GMEDGMJCEEO, CollisionDetectionMode IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "25")]
	JGCAFIGAFFP PAAIPNAOLHB(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void CBKJGBKIMPL(LBMKHNNNCPK GMEDGMJCEEO, JGCAFIGAFFP IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool PLHBCHBNJDI(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void FIEDOOCILKN(LBMKHNNNCPK GMEDGMJCEEO, bool IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "29")]
	LBMKHNNNCPK FOMDNOCIPAN(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void KMFNKCJKJCK(LBMKHNNNCPK GMEDGMJCEEO, LBMKHNNNCPK IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "31")]
	LBMKHNNNCPK DLBCCIGLBHE(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void NJPHAMCIKMD(LBMKHNNNCPK GMEDGMJCEEO, LBMKHNNNCPK IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	DJFECCHKBLN BOAKOAKHLOH(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void DOCMJAMJLCP(LBMKHNNNCPK GMEDGMJCEEO, DJFECCHKBLN KKELJBMGMIN);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool GPOLENMFFCP(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void DLKKJMAHDKE(LBMKHNNNCPK GMEDGMJCEEO, bool IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool JFNKKBKFBDL(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void JHGEEBCFOID(LBMKHNNNCPK GMEDGMJCEEO, bool IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints NNIGELNPMDC(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void NOAJLHGKALF(LBMKHNNNCPK GMEDGMJCEEO, RigidbodyConstraints IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float NCIAICJNBEO(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void IIGPPDBGFHA(LBMKHNNNCPK GMEDGMJCEEO, float IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float MMAPOLDHMLI(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void GOCFNNHHIMN(LBMKHNNNCPK GMEDGMJCEEO, float IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool OHACLJAJCDN(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void IOKEPPNMACI(LBMKHNNNCPK GMEDGMJCEEO, bool IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool JIMNHLPMGCC(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void ANEGDOOFIEM(LBMKHNNNCPK GMEDGMJCEEO, bool IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void HNBPPBNCLLB(LBMKHNNNCPK GMEDGMJCEEO, int IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "50")]
	EAEHANAOBNM ALJAFDGLODB(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void MEHOKPFNHBA(LBMKHNNNCPK GMEDGMJCEEO, EAEHANAOBNM IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "52")]
	EFMMKCONAKN LKNKCFDBLLM(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void GJEFAFNPPMN(LBMKHNNNCPK GMEDGMJCEEO, EFMMKCONAKN IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float MOJKPLNOHGO(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void KIGLBLAAGBJ(LBMKHNNNCPK GMEDGMJCEEO, float IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void DBPNOKPIOHK(LBMKHNNNCPK GMEDGMJCEEO, object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void HNPKABLEDBO(LBMKHNNNCPK GMEDGMJCEEO, object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool BJFIMKHMMFH(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void IBAINJJBBJJ(LBMKHNNNCPK GMEDGMJCEEO, object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void OPFJHJPKFCA(LBMKHNNNCPK GMEDGMJCEEO, object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool CJOAIGIEDGD(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool AOJMBBNKHMO(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody FHDFLFHHEKM(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void JPMICBIGLDN(LBMKHNNNCPK GMEDGMJCEEO, Rigidbody EKAOOBAECFJ);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void ONLCBPFAFMM(LBMKHNNNCPK GMEDGMJCEEO, object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void CPBCCIHJINH(LBMKHNNNCPK GMEDGMJCEEO, object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool ABOIAJINKCK(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void KEELGAJKNDM(LBMKHNNNCPK GMEDGMJCEEO, float3 DPBIGMHBMBN);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void EPGFHAGBPBI(LBMKHNNNCPK GMEDGMJCEEO, float3 LJFEFIKHHHB);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool OGBEMHKOKDN(LBMKHNNNCPK GMEDGMJCEEO, [Out] float3 DPBIGMHBMBN);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool BFLGEHCDGGH(LBMKHNNNCPK GMEDGMJCEEO, [Out] float3 LJFEFIKHHHB);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool GGPDDMGENEE(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void JFNKGDANDJL(LBMKHNNNCPK GMEDGMJCEEO, object OEELDHBFFAF, bool GHLPIJPFEDO);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void OGIMOBFILIB(LBMKHNNNCPK GMEDGMJCEEO, bool LMCKIHCKGFE);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void LKPFIANBJPM(LBMKHNNNCPK GMEDGMJCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool OBJFNKBDAIA(LBMKHNNNCPK GMEDGMJCEEO);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface DFDOIMEGOBE
{
	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KBIHLLONLEK(Entity OACEGPKCAPC);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMDBOKPOHJO(Entity OACEGPKCAPC);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface PPCBPBEGNBC
{
	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDIOHOBICHG(LBMKHNNNCPK CDHECNAFHCH, bool MNPONNOKKLP);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GGNHGIPAEHP(LBMKHNNNCPK CDHECNAFHCH, int ILBCHIFAEFG);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public delegate void FPMENKMDKCC(AFKMFGJFDJC IOILJAEKOKN);
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public readonly ref struct AFKMFGJFDJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ECKJADHBOIC IEAACCGEKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly NativeArray<byte> NENLDDPFCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly NativeArray<byte> FACCDLKIJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ELCMDOELFKK MEOOGDKENOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly int PNLOGGFMLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly Type ONDDGDAAPCM;

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public ECKJADHBOIC GHFBPOPPJNE
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x4469CB0", Offset = "0x44686B0", VA = "0x184469CB0")]
		get
		{
			return default(ECKJADHBOIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5930", Offset = "0x6CA4330", VA = "0x186CA5930")]
	public AFKMFGJFDJC(ECKJADHBOIC IEAACCGEKDH, NativeArray<byte> NENLDDPFCGK, NativeArray<byte> FACCDLKIJBD, ELCMDOELFKK MEOOGDKENOH, int PNLOGGFMLAC, Type ONDDGDAAPCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x34303A0", Offset = "0x342EDA0", VA = "0x1834303A0")]
	public NativeArray<T> LPDLMNIBPAL<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x3430360", Offset = "0x342ED60", VA = "0x183430360")]
	public NativeArray<T> LJJPKBMCCKM<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x3430270", Offset = "0x342EC70", VA = "0x183430270")]
	public (ECKJADHBOIC, NativeArray<T>, NativeArray<T>) GJMIFHLLDMF<T>() where T : struct
	{
		return default((ECKJADHBOIC, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5900", Offset = "0x6CA4300", VA = "0x186CA5900")]
	public CONJIDBLNCG NPLEFPLODII()
	{
		return default(CONJIDBLNCG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public interface NPLAGNCBHEK
{
	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	string DKIGHAHDDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	NPLAGNCBHEK PGPNPFBJDJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	IEnumerable<NPLAGNCBHEK> NOPMGJADOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface KOLKIMFJIEI
{
	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	NPLAGNCBHEK GAJHDHENBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	List<LINPEJNFPGO> MBDEJOHJBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GBFFOFIHCNG(LINPEJNFPGO GDCGGGDDADM, [Out] NPLAGNCBHEK FGKAOJPFKBO);

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FBIMIMMHNIB(LINPEJNFPGO GDCGGGDDADM, FPMENKMDKCC LLNDKECLJCJ);

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IFGBNDJNHBH(LINPEJNFPGO GDCGGGDDADM, FPMENKMDKCC LLNDKECLJCJ);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public readonly ref struct CONJIDBLNCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly AFKMFGJFDJC LNCKNHNHHDF;

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public ECKJADHBOIC GHFBPOPPJNE
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x4469CB0", Offset = "0x44686B0", VA = "0x184469CB0")]
		get
		{
			return default(ECKJADHBOIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x6CAA520", Offset = "0x6CA8F20", VA = "0x186CAA520")]
	public CONJIDBLNCG(AFKMFGJFDJC LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x6CAA450", Offset = "0x6CA8E50", VA = "0x186CAA450")]
	public ECKJADHBOIC LPDLMNIBPAL()
	{
		return default(ECKJADHBOIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x6CAA380", Offset = "0x6CA8D80", VA = "0x186CAA380")]
	public ECKJADHBOIC LJJPKBMCCKM()
	{
		return default(ECKJADHBOIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x6CAA160", Offset = "0x6CA8B60", VA = "0x186CAA160")]
	public (ECKJADHBOIC, ECKJADHBOIC, ECKJADHBOIC) GJMIFHLLDMF()
	{
		return default((ECKJADHBOIC, ECKJADHBOIC, ECKJADHBOIC));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
[DefaultMember("Item")]
public interface NEAMAFPABAD : IEnumerable<JFFFCDBCMIK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	NativeBitArray NCACPLMHDOO
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	NativeBitArray EOJENEEFFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	NativeArray<int> CGPLLCDKOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	JFFFCDBCMIK BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	JFFFCDBCMIK BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JFFFCDBCMIK IJHHAMNODBC(FBOFDHIKKKJ PCFKMOBOMBL);

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ELCMDOELFKK GMMBBAGAKCC(FBOFDHIKKKJ PCFKMOBOMBL);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class IDJFGJFKIHM
{
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
[DefaultMember("Item")]
public interface NDDEJMLMBAN : IEnumerable<FAKNFDNJNPG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	FAKNFDNJNPG BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FAKNFDNJNPG IJHHAMNODBC(FBOFDHIKKKJ PCFKMOBOMBL);

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ELCMDOELFKK GMMBBAGAKCC(FBOFDHIKKKJ PCFKMOBOMBL);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class DOFLACOFHIC
{
	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x2BAD570", Offset = "0x2BABF70", VA = "0x182BAD570")]
	public static ELCMDOELFKK GMMBBAGAKCC<T>(this NDDEJMLMBAN PBCMNPMKICM, KAOPOCIMJOB<T> DDDMPLCOGIM) where T : struct
	{
		return default(ELCMDOELFKK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
[DefaultMember("Item")]
public interface MKBDHNMOFJK : IEnumerable<LINPEJNFPGO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	LINPEJNFPGO BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LINPEJNFPGO IJHHAMNODBC(FBOFDHIKKKJ PCFKMOBOMBL);

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ELCMDOELFKK GMMBBAGAKCC(FBOFDHIKKKJ PCFKMOBOMBL);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class IDJIAICGOOK
{
	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x2D9CFD0", Offset = "0x2D9B9D0", VA = "0x182D9CFD0")]
	public static KMIBFHEDCIB<T> IJHHAMNODBC<T>(this MKBDHNMOFJK PBCMNPMKICM, FBOFDHIKKKJ DDDMPLCOGIM) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x2D9CA30", Offset = "0x2D9B430", VA = "0x182D9CA30")]
	public static ELCMDOELFKK GMMBBAGAKCC<T>(this MKBDHNMOFJK PBCMNPMKICM, KAOPOCIMJOB<T> DDDMPLCOGIM) where T : struct
	{
		return default(ELCMDOELFKK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface HIKCCMEIIFO
{
	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FBIMIMMHNIB(FBOFDHIKKKJ GDCGGGDDADM, FPMENKMDKCC LLNDKECLJCJ);

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IFGBNDJNHBH(FBOFDHIKKKJ GDCGGGDDADM, FPMENKMDKCC LLNDKECLJCJ);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class HBEMBFJLJAF
{
	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x2D77080", Offset = "0x2D75A80", VA = "0x182D77080")]
	public static void FBIMIMMHNIB<T>(this HIKCCMEIIFO AFNEFLPPKOL, KAOPOCIMJOB<T> GDCGGGDDADM, FPMENKMDKCC LLNDKECLJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x2D773E0", Offset = "0x2D75DE0", VA = "0x182D773E0")]
	public static void IFGBNDJNHBH<T>(this HIKCCMEIIFO AFNEFLPPKOL, KAOPOCIMJOB<T> GDCGGGDDADM, FPMENKMDKCC LLNDKECLJCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface OEFNPMGGHJP
{
	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	LIMMCOMCDEA JGNJKNIOBJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBNHMGPDOCD(PPCIBOGOOFM OGPFJDHMIGP, ELCMDOELFKK GDCGGGDDADM);

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GOELMGBLGOF(PPCIBOGOOFM OGPFJDHMIGP, Span<ELCMDOELFKK> PBCMNPMKICM, bool NMMNGFDPFAE);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OFPPPNECJOF(NativeArray<PPCIBOGOOFM> JFPHLGMDCNK);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class KIKPPGCHIGI
{
	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x6CB1A80", Offset = "0x6CB0480", VA = "0x186CB1A80")]
	public static void GOELMGBLGOF(this OEFNPMGGHJP BMAKLIMDBJH, PPCIBOGOOFM OGPFJDHMIGP, ELCMDOELFKK GDCGGGDDADM, bool NMMNGFDPFAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public readonly struct LIMMCOMCDEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly NativeBitArray LIBGGOJKIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly NativeParallelHashMap<PPCIBOGOOFM, int> PBHHGPMEBIB;

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public bool LPLMCBCEJBD
	{
		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x6CB2910", Offset = "0x6CB1310", VA = "0x186CB2910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x4469B80", Offset = "0x4468580", VA = "0x184469B80")]
	public LIMMCOMCDEA(NativeBitArray LIBGGOJKIOD, NativeParallelHashMap<PPCIBOGOOFM, int> PBHHGPMEBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2930", Offset = "0x6CB1330", VA = "0x186CB2930")]
	public bool NBNHMGPDOCD(PPCIBOGOOFM OGPFJDHMIGP, ELCMDOELFKK GDCGGGDDADM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface GMFIJFNAAJK
{
	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBPMMDJAOLN(LBMKHNNNCPK GMEDGMJCEEO, LHLKFGKGHKF IPHMAHBENGI);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface IKBFEJNLFDF
{
	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	OHFCNPENGBB FEOHBBEPDGK
	{
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface BIGICEPAFFJ
{
	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NKNDAOPJDLG(World OBOIAEHHCBI);

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JKCCMINPONG(World OBOIAEHHCBI);

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase NKKCHLNPHOB(World OBOIAEHHCBI);

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EBBGMPCKHIC(World OBOIAEHHCBI);

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GLLCINADBEM(World OBOIAEHHCBI);

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BMIJOONFKIA(World OBOIAEHHCBI);

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MDMDCEDMAOG(World OBOIAEHHCBI);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[BDNMHMNCMLI(DACEBDJEIDP.LoadInstance)]
public interface NDNEJDNIKAA
{
	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGIDBEFFMOF(LBMKHNNNCPK NDHGEIKELEB, bool IPHMAHBENGI);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public readonly struct JMKPHJPKDPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly IEnumerable<BKLPFBJMBNM> ENBJOACEOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IReadOnlyList<GameObject> EFKAHPCDOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly IReadOnlyList<int> LIAGGNDJNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly IReadOnlyList<(PPCIBOGOOFM, PPCIBOGOOFM)> IOADHOKIMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly int ADIKGFEEFLC;

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public bool DDBKACNOMBL
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x6CAEFD0", Offset = "0x6CAD9D0", VA = "0x186CAEFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public int JGPLHBMGPGD
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x92EC80", Offset = "0x92D680", VA = "0x18092EC80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public IEnumerable<GameObject> DIKFCDIJKMC
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xAFAF10", Offset = "0xAF9910", VA = "0x180AFAF10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public IEnumerable<(PPCIBOGOOFM src, PPCIBOGOOFM dst)> ONFEGLGHBGM
	{
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x6CAF3C0", Offset = "0x6CADDC0", VA = "0x186CAF3C0")]
	public JMKPHJPKDPN(IEnumerable<BKLPFBJMBNM> ENBJOACEOJO, IReadOnlyList<GameObject> EFKAHPCDOGI, IReadOnlyList<int> LIAGGNDJNJB, IReadOnlyList<(PPCIBOGOOFM src, PPCIBOGOOFM dst)> IOADHOKIMBF, int ADIKGFEEFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x6CAF030", Offset = "0x6CADA30", VA = "0x186CAF030")]
	public (GameObject, int)[] LIDGPCNOJPK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface KFFACANDNPF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public class AFMJBFGJMBH
	{
		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public LBMKHNNNCPK JEBILDNGPEC
		{
			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
			[CompilerGenerated]
			get
			{
				return default(LBMKHNNNCPK);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x903080", Offset = "0x901A80", VA = "0x180903080")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		public UniformTRS FMIFENOJPCM
		{
			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0x3A9F2F0", Offset = "0x3A9DCF0", VA = "0x183A9F2F0")]
			[CompilerGenerated]
			get
			{
				return default(UniformTRS);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0x6CA5970", Offset = "0x6CA4370", VA = "0x186CA5970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public bool POKDEPGDFLD
		{
			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(RVA = "0x92EC70", Offset = "0x92D670", VA = "0x18092EC70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0xC24E20", Offset = "0xC23820", VA = "0x180C24E20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public FNNLJJENCBJ GNAOJGJDLML
		{
			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0x889090", Offset = "0x887A90", VA = "0x180889090")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0x8890B0", Offset = "0x887AB0", VA = "0x1808890B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public bool HKMHJENAGKC
		{
			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0xAAC060", Offset = "0xAAAA60", VA = "0x180AAC060")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0xC55C90", Offset = "0xC54690", VA = "0x180C55C90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public InventionIdData GCNIDBEHAIN
		{
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0x88B2B0", Offset = "0x889CB0", VA = "0x18088B2B0")]
			[CompilerGenerated]
			get
			{
				return default(InventionIdData);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x90FA40", Offset = "0x90E440", VA = "0x18090FA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public InventionInstanceIdData LHEAIGGKADD
		{
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0xACB440", Offset = "0xAC9E40", VA = "0x180ACB440")]
			[CompilerGenerated]
			get
			{
				return default(InventionInstanceIdData);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0xAC8F20", Offset = "0xAC7920", VA = "0x180AC8F20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5980", Offset = "0x6CA4380", VA = "0x186CA5980")]
		public AFMJBFGJMBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	bool GLADOOKFLAH
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	bool MDODAKANPLB
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	DMNNMJGBOII KGDOLELHBLB
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BAMMMEKGLJK NENINGDFANM();

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BAMMMEKGLJK MCELPKNLOHO(IEnumerable<LBMKHNNNCPK> AOFJCLOAGBF, [In] UniformTRS LPFHGNAPGJP);

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JHNNDGCHDLG OIIHPGBDNIP(ByteString PCIIMKODILG);

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PLAAPAALKAC GKGFCMJJAEI(ByteString INKPEPIELNA, AFMJBFGJMBH LFOFLLOHBIA);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MBBHFCAFIOI();

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JMKPHJPKDPN CINMIOBKCBN(IEnumerable<BKLPFBJMBNM> ENBJOACEOJO);
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public static class ADGGENJPCBO
{
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface BGJHIONHCHL
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action EJLLOBECKFO;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action AONOBNJBFBN;
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public struct PJJFGNPGFAJ : NLMPJHABEMF, IEquatable<PJJFGNPGFAJ>
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public static readonly int OANLACPEPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public ADNGPIOLLLA NLMEGDEGAEA;

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x6CB81D0", Offset = "0x6CB6BD0", VA = "0x186CB81D0", Slot = "5")]
	public void MPIHBHFBPAP(DDIPKFKCFAD BPJDDKOBEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8100", Offset = "0x6CB6B00", VA = "0x186CB8100", Slot = "4")]
	public void BBLOJHGNHMB(IEDFJKMOPIO HJIMDHLCBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8200", Offset = "0x6CB6C00", VA = "0x186CB8200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0xC41910", Offset = "0xC40310", VA = "0x180C41910", Slot = "6")]
	public bool Equals(PJJFGNPGFAJ CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8130", Offset = "0x6CB6B30", VA = "0x186CB8130", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x9FE7F0", Offset = "0x9FD1F0", VA = "0x1809FE7F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public struct BKLPFBJMBNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Guid OKMPNEEAGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public string JHNHANNFJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Vector3 EJEBFMEPKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public Quaternion PCIAHIPKDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public Vector3 FCFDEHNOPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int BALBEJDMLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public Dictionary<string, object> LFOFLLOHBIA;

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8EE0", Offset = "0x6CA78E0", VA = "0x186CA8EE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8D60", Offset = "0x6CA7760", VA = "0x186CA8D60")]
	private static string LHHGBMPIPFC(Dictionary<string, object> ICFMCHEMBJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public enum EELCAFJMMDD
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
public static class MKKKIDLBEEH
{
	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x609D2D0", Offset = "0x609BCD0", VA = "0x18609D2D0")]
	public static bool EAJKLEPBLJK(this EELCAFJMMDD AOGCIMANLIJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[Flags]
public enum ALDKCMPBIJB
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
public interface PLAAPAALKAC : DMNNMJGBOII, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	FNNLJJENCBJ GNAOJGJDLML
	{
		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KELODGGKPBN();

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GMMJMFLMAPO();
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public interface DMNNMJGBOII : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	IEnumerable<BKLPFBJMBNM> OHFJOLLPJCC
	{
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	JMKPHJPKDPN LKHLEDHJJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	EELCAFJMMDD GPKIFFDGPEH
	{
		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	LocalId BECNNHBALGM
	{
		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	IPFNJFKBKOP HBDDLFGGBJP
	{
		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DBFKLINPIFI(ALDKCMPBIJB OADCNCKAODL);
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public interface FNNLJJENCBJ
{
	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MOAKPEFOJJI(Guid EEBGELKKKEJ, [Out] Guid NMMHFBINDGD);
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public interface JHNNDGCHDLG : DMNNMJGBOII, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[Flags]
public enum PNPELOHALHA
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
public interface BAMMMEKGLJK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	IPFNJFKBKOP AGOEEONLFGA
	{
		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString KNHPAAPNFGD();
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public enum INGFIMMFKDE
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public delegate bool FACCOPEGIDA(IKLBACDFKIO JIEACINPKKJ, [In] LJBEBGPAIAD IPHMAHBENGI);
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public delegate bool IKHLEBHDEJB<T>(IKLBACDFKIO JIEACINPKKJ, [In] T IPHMAHBENGI);
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface HHNCJOECLNC
{
	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FBIMIMMHNIB(ELCMDOELFKK MEOOGDKENOH, Type HEDNIOHCGLH, FACCOPEGIDA CHMMFFGCOHH);

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MPLKABJINPD(ELCMDOELFKK MEOOGDKENOH, [Out] FACCOPEGIDA CHMMFFGCOHH);
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public static class CBHMBPADMBL
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private sealed class HCMLIBPDFIM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public IKHLEBHDEJB<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public HCMLIBPDFIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x3F4ADA0", Offset = "0x3F497A0", VA = "0x183F4ADA0")]
		internal bool CCFJKPOHENB(IKLBACDFKIO pendingList, [In] LJBEBGPAIAD value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x2B51A60", Offset = "0x2B50460", VA = "0x182B51A60")]
	public static void FBIMIMMHNIB<T>(this HHNCJOECLNC AFNEFLPPKOL, ELCMDOELFKK MEOOGDKENOH, IKHLEBHDEJB<T> CHMMFFGCOHH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x6CA91C0", Offset = "0x6CA7BC0", VA = "0x186CA91C0")]
	public static bool IFCFPLDHFNC(this HHNCJOECLNC AFNEFLPPKOL, IKLBACDFKIO JIEACINPKKJ, ELCMDOELFKK MEOOGDKENOH, [In] LJBEBGPAIAD IPHMAHBENGI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface JFOMAMBEIEB
{
	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	uint ANLBONLPNJG
	{
		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface IKLBACDFKIO
{
	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NHPJGLFKLOC(PPCIBOGOOFM ACFLFBJCHHM, ELCMDOELFKK MEOOGDKENOH, ReadOnlySpan<byte> HAIFGOENFLH, ReadOnlySpan<byte> BFPBJCHFCBI);

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFLKLMDHGJK(PPCIBOGOOFM ACFLFBJCHHM, ELCMDOELFKK MEOOGDKENOH, ReadOnlySpan<byte> HAIFGOENFLH, ReadOnlySpan<byte> BFPBJCHFCBI);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KLCILBGFGCG(PPCIBOGOOFM ACFLFBJCHHM, ELCMDOELFKK MEOOGDKENOH);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GFLPDHBOFLE(PPCIBOGOOFM ACFLFBJCHHM, ELCMDOELFKK MEOOGDKENOH, ReadOnlySpan<byte> BFPBJCHFCBI);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MCNFKMHIGPC(PPCIBOGOOFM ACFLFBJCHHM, ELCMDOELFKK MEOOGDKENOH, Span<byte> HAIFGOENFLH, Span<byte> BFPBJCHFCBI);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public static class HNPNOMFMDPJ
{
	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x2D851D0", Offset = "0x2D83BD0", VA = "0x182D851D0")]
	public static bool MCNFKMHIGPC<T>(this IKLBACDFKIO OMNOPOCGFJA, PPCIBOGOOFM ACFLFBJCHHM, ELCMDOELFKK MEOOGDKENOH, [Out] T HAIFGOENFLH, [Out] T BFPBJCHFCBI) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x2D85090", Offset = "0x2D83A90", VA = "0x182D85090")]
	public static bool GFLPDHBOFLE<T>(this IKLBACDFKIO OMNOPOCGFJA, PPCIBOGOOFM ACFLFBJCHHM, ELCMDOELFKK MEOOGDKENOH, T BFPBJCHFCBI) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public enum JPNGGNBEHNF
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
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface CFMJBCEEOKI
{
	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KOMIBLGBKAE(KNIHLCMNKMN FCLIEHCKPJG, ReadOnlySpan<byte> HDOCILHNNDE);

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PIDFMBNHCEC(uint JPCACEEEJLI, ReadOnlySpan<byte> HDOCILHNNDE);

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JHBOIFMNOID(int PNGLOPHCFDI);
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface BAGECNPKFCA
{
	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KNIHLCMNKMN EFOKLHCNHHM(ReadOnlySpan<byte> HDOCILHNNDE);
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface MKBBONDDLMP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDEDJLKFILJ(KNIHLCMNKMN COMNIKKFEEB, ReadOnlySpan<byte> HDOCILHNNDE);

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKOEPGMJNCN(ReadOnlySpan<KNIHLCMNKMN> BFMNNFHOFFA);
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public struct ALBKONEFMJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public KNIHLCMNKMN FCLIEHCKPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public ReadOnlyMemory<byte> HDOCILHNNDE;
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public struct KNIHLCMNKMN
{
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static KNIHLCMNKMN LAAPFBCFPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public uint DDOIBEJDFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public int BGJNOMGCGMO;

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x9B5B10", Offset = "0x9B4510", VA = "0x1809B5B10")]
	public KNIHLCMNKMN(uint DDOIBEJDFIA, int BGJNOMGCGMO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x6CB1F30", Offset = "0x6CB0930", VA = "0x186CB1F30")]
	public static bool JGJOKBKMGBC([In] KNIHLCMNKMN MFLKJAHENBP, [In] KNIHLCMNKMN PLHCHKLJLJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x6CB1E40", Offset = "0x6CB0840", VA = "0x186CB1E40", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x6CB1F00", Offset = "0x6CB0900", VA = "0x186CB1F00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x6CB1F50", Offset = "0x6CB0950", VA = "0x186CB1F50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x6CB1EF0", Offset = "0x6CB08F0", VA = "0x186CB1EF0")]
	public void GJGCCCKLLFN([Out] uint DDOIBEJDFIA, [Out] int BGJNOMGCGMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface MEENOOPCCHA : ODPDDKOFHPL<MEENOOPCCHA>
{
	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OIOKEJAEGIB(ELCMDOELFKK DNICIAANFHD, [Out] OAJDHNAGCNL GKBHCOPNOKD);
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class JBPLADLGGEE
{
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public interface OAJDHNAGCNL
{
	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	Type EEIBGJNBMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MPIHBHFBPAP(DDIPKFKCFAD BPJDDKOBEGL, Span<byte> CDHECNAFHCH);

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BBLOJHGNHMB(IEDFJKMOPIO HJIMDHLCBKF, ReadOnlySpan<byte> FCLIEHCKPJG);
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public static class DAHBLBLFFCL
{
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public struct ANCIAFGMNMH : ISystemStateComponentData, IComponentData, IEquatable<ANCIAFGMNMH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public float3 HMDHFGCBKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public float3 BHFMCKOEBKL;

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x6CA66E0", Offset = "0x6CA50E0", VA = "0x186CA66E0", Slot = "4")]
	public bool Equals(ANCIAFGMNMH CGCLEIBHLHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface PDPCBIBNPLA
{
	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KDGJAIGMAJB(long ABEKDMBCADJ);

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFICJAAOIGF(NativeParallelHashSet<long> OINPIIBGAMJ);

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IGMDCMLGMJL(World OBOIAEHHCBI, NativeParallelHashMap<Guid, long> NHKOCMGDPBO);

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EIGDEHNNOLI(PPCIBOGOOFM OGPFJDHMIGP);

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LONCGEPNEPP(PPCIBOGOOFM OGPFJDHMIGP, [Out] Guid CFOPPEHMMID, [Out] long ABEKDMBCADJ);

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CGBIGAHBPOF(PPCIBOGOOFM OGPFJDHMIGP, Guid CFOPPEHMMID, long ABEKDMBCADJ);

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BEEOEOPANIE(Guid CFOPPEHMMID);

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool IJABMOFAAOH(Guid CFOPPEHMMID, [Out] int PAJBEBGHODE, [Out] int BJKIBDFHJBK);

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IHDDDAJKGLO(Guid CFOPPEHMMID, int PAJBEBGHODE, int BJKIBDFHJBK);

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BMOFAEPPHPG(Guid CFOPPEHMMID);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public class MDNKJAHJAPB
{
	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public MDNKJAHJAPB()
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
